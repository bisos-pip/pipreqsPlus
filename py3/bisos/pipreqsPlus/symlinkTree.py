""" #+begin_org
* ~[Summary]~ :: Build a scratch scan directory of =.py= symlinks.

pipreqs only walks =*.py= files. To let it see Python sources that
use non-=.py= extensions (e.g. BISOS =.cs=/=.pcs=/=.mcs= command
files), we build a scratch directory whose contents are symlinks to
the real source files but renamed with a =.py= suffix. pipreqs is
then run against the scratch directory.

Detection of "is this file Python source?" uses two signals:
  1. Extension is =.py=.
  2. First line matches a Python shebang.
  3. Extension (without dot) is in the caller-provided =extraExts= list.
#+end_org """

import pathlib
import re
import shutil
import tempfile
from typing import Iterable, Optional


_PYTHON_SHEBANG_RE = re.compile(r'^#!.*\bpython\d*\b')


def isPythonSource(
        path: pathlib.Path,
        extraExts: Iterable[str],
) -> bool:
    """Return True if =path= should be treated as Python source.

    Signals, checked in order:
      1. Extension is =.py=.
      2. Extension (without dot) is in =extraExts=.
      3. First line of the file matches a Python shebang pattern.
    """
    if path.suffix == '.py':
        return True

    ext = path.suffix.lstrip('.')
    if ext and ext in set(extraExts):
        return True

    try:
        with path.open('r', encoding='utf-8', errors='replace') as fh:
            firstLine = fh.readline()
    except OSError:
        return False

    return bool(_PYTHON_SHEBANG_RE.match(firstLine))


def build(
        srcDir: pathlib.Path,
        binDir: Optional[pathlib.Path],
        extraExts: Iterable[str],
) -> pathlib.Path:
    """Build a scratch scan directory. Returns the scratch dir path.

    The scratch dir contains:
      - =pkgSrc/= --- a symlink to =srcDir= (walked recursively by pipreqs).
      - =bin/= --- top-level =.py= symlinks for each Python-source file
        found in =binDir=. Non-Python files are skipped. Subdirectories
        of =binDir= are NOT recursed.

    Caller is responsible for cleaning up the returned directory
    (=cleanup= is the reverse).
    """
    scanDir = pathlib.Path(tempfile.mkdtemp(prefix='pipreqsPlus.'))

    (scanDir / 'pkgSrc').symlink_to(srcDir.resolve(), target_is_directory=True)

    if binDir is not None and binDir.is_dir():
        binScanDir = scanDir / 'bin'
        binScanDir.mkdir()
        for child in binDir.iterdir():
            if not child.is_file():
                continue
            if not isPythonSource(child, extraExts):
                continue
            linkName = binScanDir / f'{child.stem}.py'
            # Handle name collisions (e.g. foo.py and foo.cs) by
            # appending the original extension before .py.
            if linkName.exists():
                linkName = binScanDir / f'{child.stem}_{child.suffix.lstrip(".")}.py'
            linkName.symlink_to(child.resolve())

    return scanDir


def cleanup(scanDir: pathlib.Path) -> None:
    """Remove the scratch scan directory."""
    if scanDir and scanDir.exists():
        shutil.rmtree(scanDir)