""" #+begin_org
* ~[Summary]~ :: Import scanning for namespace-package augmentation.

Walks a directory tree of Python source files, extracts =from NS.X ...=
and =import NS.X ...= statements for each configured namespace =NS=,
and returns the deduplicated two-level names (=NS.X=).

Used to augment pipreqs output, which by default collapses submodule
imports of namespace packages down to the bare namespace name.
#+end_org """

import pathlib
import re
from typing import Iterable, Set


def _importRe(namespace: str) -> re.Pattern:
    """Return a compiled regex that matches lines like:
       =from NS.X import ...= or =import NS.X (as ...)?=
    and captures the two-level name =NS.X=.
    """
    escapedNs = re.escape(namespace)
    return re.compile(
        rf'^\s*(?:from|import)\s+({escapedNs}\.[a-zA-Z_][a-zA-Z0-9_]*)',
        re.MULTILINE,
    )


def findNamespaceImports(
        scanDir: pathlib.Path,
        namespaces: Iterable[str],
) -> Set[str]:
    """Walk =scanDir= (recursively; symlinks followed) looking at =*.py=
    files, and return the set of two-level =NS.X= names imported for
    each =NS= in =namespaces=.

    Third-and-lower-level names (=NS.X.Y=) are truncated to =NS.X=.
    """
    result: Set[str] = set()
    patterns = [_importRe(ns) for ns in namespaces]

    for pyFile in scanDir.rglob('*.py'):
        try:
            content = pyFile.read_text(encoding='utf-8', errors='replace')
        except OSError:
            continue
        for pattern in patterns:
            for match in pattern.finditer(content):
                result.add(match.group(1))

    return result