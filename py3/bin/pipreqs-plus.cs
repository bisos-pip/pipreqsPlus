#! /bin/env python
# -*- coding: utf-8 -*-

""" #+begin_org
* ~[Summary]~ :: A =CSXU= for initiating AI collaborative development templates.
#+end_org """

""" #+begin_org
* [[elisp:(org-cycle)][| ~Description~ |]] :: [[file:/bisos/panels/bisos-core/bisos-pip/bisos.tocsModules/_nodeBase_/fullUsagePanel-en.org][BISOS Panel]]   [[elisp:(org-cycle)][| ]]

** Status: In use with BISOS
** /[[elisp:(org-cycle)][| Planned Improvements |]]/ :
*** TODO Review Panel's Design and Evolution section.
#+end_org """


####+BEGIN: b:py3:cs:file/dblockControls :classification "cs-mu"
""" #+begin_org
* [[elisp:(org-cycle)][| /Control Parameters Of This File/ |]] :: dblk ctrls classifications=cs-mu
#+BEGIN_SRC emacs-lisp
(setq-local b:dblockControls t) ; (setq-local b:dblockControls nil)
(put 'b:dblockControls 'py3:cs:Classification "cs-mu") ; one of cs-mu, cs-u, cs-lib, bpf-lib, pyLibPure
#+END_SRC
#+RESULTS:
: cs-mu
#+end_org """
####+END:

####+BEGIN: b:prog:file/proclamations :outLevel 1
""" #+begin_org
* *[[elisp:(org-cycle)][| Proclamations |]]* :: Libre-Halaal Software --- Part Of BISOS ---  Poly-COMEEGA Format.
** This is Libre-Halaal Software. © Neda Communications, Inc. Subject to AGPL.
** It is part of BISOS (ByStar Internet Services OS)
** Best read and edited  with Blee in Poly-COMEEGA (Polymode Colaborative Org-Mode Enhance Emacs Generalized Authorship)
#+end_org """
####+END:

####+BEGIN: b:prog:file/particulars :authors ("./inserts/authors-mb.org")
""" #+begin_org
* *[[elisp:(org-cycle)][| Particulars |]]* :: Authors, version
** This File: /bisos/git/auth/bxRepos/bisos-pip/startAiActivity/py3/bin/startAiActivity.cs
** Authors: Mohsen BANAN, http://mohsen.banan.1.byname.net/contact
#+end_org """
####+END:

####+BEGIN: b:py3:file/particulars-csInfo :status "inUse"
""" #+begin_org
* *[[elisp:(org-cycle)][| Particulars-csInfo |]]*
#+end_org """
import typing
csInfo: typing.Dict[str, typing.Any] = { 'moduleName': ['pipreqs-plus'], }
csInfo['version'] = '202507241200'
csInfo['status']  = 'inUse'
csInfo['panel'] = 'pipreqs-plus-Panel.org'
csInfo['groupingType'] = 'IcmGroupingType-pkged'
csInfo['cmndParts'] = 'IcmCmndParts[common] IcmCmndParts[param]'
####+END:


####+BEGIN: b:prog:file/orgTopControls :outLevel 1
""" #+begin_org
* [[elisp:(org-cycle)][| Controls |]] :: [[elisp:(delete-other-windows)][(1)]] | [[elisp:(show-all)][Show-All]]  [[elisp:(org-shifttab)][Overview]]  [[elisp:(progn (org-shifttab) (org-content))][Content]] | [[file:Panel.org][Panel]] | [[elisp:(blee:ppmm:org-mode-toggle)][Nat]] | [[elisp:(bx:org:run-me)][Run]] | [[elisp:(bx:org:run-me-eml)][RunEml]] | [[elisp:(progn (save-buffer) (kill-buffer))][S&Q]]  [[elisp:(save-buffer)][Save]]  [[elisp:(kill-buffer)][Quit]] [[elisp:(org-cycle)][| ]]
** /Version Control/ ::  [[elisp:(call-interactively (quote cvs-update))][cvs-update]]  [[elisp:(vc-update)][vc-update]] | [[elisp:(bx:org:agenda:this-file-otherWin)][Agenda-List]]  [[elisp:(bx:org:todo:this-file-otherWin)][ToDo-List]]

#+end_org """
####+END:

####+BEGIN: b:py3:file/workbench :outLevel 1
""" #+begin_org
* [[elisp:(org-cycle)][| Workbench |]] :: [[elisp:(python-check (format "/bisos/venv/py3/bisos3/bin/python -m pyclbr %s" (bx:buf-fname))))][pyclbr]] || [[elisp:(python-check (format "/bisos/venv/py3/bisos3/bin/python -m pydoc ./%s" (bx:buf-fname))))][pydoc]] || [[elisp:(python-check (format "/bisos/pipx/bin/pyflakes %s" (bx:buf-fname)))][pyflakes]] | [[elisp:(python-check (format "/bisos/pipx/bin/pychecker %s" (bx:buf-fname))))][pychecker (executes)]] | [[elisp:(python-check (format "/bisos/pipx/bin/pycodestyle %s" (bx:buf-fname))))][pycodestyle]] | [[elisp:(python-check (format "/bisos/pipx/bin/flake8 %s" (bx:buf-fname))))][flake8]] | [[elisp:(python-check (format "/bisos/pipx/bin/pylint %s" (bx:buf-fname))))][pylint]]  [[elisp:(org-cycle)][| ]]
#+end_org """
####+END:

####+BEGIN: b:py3:cs:framework/imports :basedOn "classification"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] *Imports* =Based on Classification=cs-mu=
#+end_org """
from bisos import b
from bisos.b import cs
from bisos.b import b_io
from bisos.common import csParam

import collections
####+END:

import ast
import datetime
import os
import pathlib
import shutil
import subprocess
import sys
import typing

from bisos.pipreqsPlus import scanner
from bisos.pipreqsPlus import symlinkTree

""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] ~csuList emacs-list Specifications~  [[elisp:(blee:org:code-block/above-run)][ /Eval Below/ ]] [[elisp:(org-cycle)][| ]]
#+BEGIN_SRC emacs-lisp
(setq  b:py:cs:csuList
  (list
   "bisos.b.userConfig_csu"
 ))
#+END_SRC
#+RESULTS:
| bisos.b.userConfig_csu |
#+end_org """

####+BEGIN: b:py3:cs:framework/csuListProc :pyImports t :csuImports t :csuParams t :csxuParams nil
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] ~Process CSU List~ with /1/ in csuList pyImports=t csuImports=t csuParams=t
#+end_org """

from bisos.b import userConfig_csu

csuList = [ 'bisos.b.userConfig_csu', ]

g_importedCmndsModules = cs.csuList_importedModules(csuList)

def g_extraParams():
    csParams = cs.param.CmndParamDict()
    cs.csuList_commonParamsSpecify(csuList, csParams)
    cs.argsparseBasedOnCsParams(csParams)

####+END:




####+BEGIN: b:py3:cs:orgItem/section :title "Common Parameters Specification"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  /Section/    [[elisp:(outline-show-subtree+toggle)][||]] *Common Parameters Specification*  [[elisp:(org-cycle)][| ]]
#+end_org """
####+END:


def commonParamsSpecify(
        csParams: cs.param.CmndParamDict,
) -> None:

    csParams.parDictAdd(
        parName='srcDir',
        parDescription=(
            "Path to the package source tree to scan for imports. "
            "Recursively walked by pipreqs."
        ),
        parDataType=None,
        parDefault=None,
        parChoices=[],
        argparseShortOpt=None,
        argparseLongOpt='--srcDir',
    )
    csParams.parDictAdd(
        parName='binDir',
        parDescription=(
            "Optional directory of executables/scripts to also scan. "
            "Top-level only (no recursion). Python-source files are "
            "detected by (1) .py extension, (2) matching --extraExts, "
            "or (3) a Python shebang on the first line. Defaults to ./bin."
        ),
        parDataType=None,
        parDefault=None,
        parChoices=[],
        argparseShortOpt=None,
        argparseLongOpt='--binDir',
    )
    csParams.parDictAdd(
        parName='outFile',
        parDescription="Path to write requirements.txt. Defaults to ./requirements.txt.",
        parDataType=None,
        parDefault=None,
        parChoices=[],
        argparseShortOpt=None,
        argparseLongOpt='--outFile',
    )
    csParams.parDictAdd(
        parName='extraExts',
        parDescription=(
            "Python-literal list of extra file extensions (without dots) "
            "to treat as Python source in addition to shebang-detected "
            "files. Example: --extraExts=\"['cs', 'pcs', 'mcs']\". "
            "Empty by default; auto-detection via shebang catches most cases."
        ),
        parDataType=None,
        parDefault=None,
        parChoices=[],
        argparseShortOpt=None,
        argparseLongOpt='--extraExts',
    )
    csParams.parDictAdd(
        parName='namespaces',
        parDescription=(
            "Python-literal list of namespace packages whose submodule "
            "imports should be expanded to their two-level PyPI names. "
            "Example: --namespaces=\"['bisos', 'other']\". "
            "pipreqs collapses =from NS.X import ...= down to =NS=; this "
            "list restores =NS.X= as separate requirements. "
            "Defaults to ['bisos']."
        ),
        parDataType=None,
        parDefault=None,
        parChoices=[],
        argparseShortOpt=None,
        argparseLongOpt='--namespaces',
    )
    csParams.parDictAdd(
        parName='pipreqsMode',
        parDescription=(
            "Value passed through to pipreqs --mode. "
            "Defaults to 'no-pin' (unpinned requirements, appropriate for libraries)."
        ),
        parDataType=None,
        parDefault=None,
        parChoices=[],
        argparseShortOpt=None,
        argparseLongOpt='--pipreqsMode',
    )


####+BEGIN: b:py3:cs:main/outcomeReportControl :disabled? nil :cmnd t :ro nil
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] ~Invokation's Outcome Reporting Control~ with /cmnd=t/ /ro=nil/
#+end_org """
# cs.invOutcomeReportControl(cmnd=True, ro=True)
####+END:

####+BEGIN: b:py3:cs:orgItem/section :title "Support Functions"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  /Section/    [[elisp:(outline-show-subtree+toggle)][||]] *Common Parameters Specification*  [[elisp:(org-cycle)][| ]]
#+end_org """
####+END:

def _resolveListParam(rawValue, defaultList):
    """Parse a Python-literal list param.

    If =rawValue= is a non-empty string, evaluate it as a Python literal
    via =ast.literal_eval= and return the result. Otherwise return
    =defaultList=.
    """
    if rawValue is None:
        return list(defaultList)
    if isinstance(rawValue, list):
        return rawValue
    if isinstance(rawValue, str):
        stripped = rawValue.strip()
        if not stripped:
            return list(defaultList)
        result = ast.literal_eval(stripped)
        if not isinstance(result, list):
            raise ValueError(
                f"Expected a Python-literal list, got {type(result).__name__}: {rawValue!r}"
            )
        return result
    raise TypeError(f"Cannot interpret {rawValue!r} as a list.")


def _augmentWithNamespaces(
        outFile: pathlib.Path,
        submods: typing.Set[str],
) -> None:
    """Append two-level namespace-submodule names to outFile, then sort-uniq
    the file in place. Idempotent across re-runs.
    """
    if not submods:
        return
    existing = outFile.read_text().splitlines() if outFile.exists() else []
    combined = sorted(set(existing) | submods)
    # Drop blank lines but preserve everything else pipreqs wrote.
    combined = [line for line in combined if line.strip()]
    outFile.write_text("\n".join(combined) + "\n")



####+BEGIN: blee:bxPanel:foldingSection :outLevel 0 :sep nil :title "CmndSvcs" :anchor ""  :extraInfo "Command Services Section"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*     [[elisp:(outline-show-subtree+toggle)][| _CmndSvcs_: |]]  Command Services Section  [[elisp:(org-shifttab)][<)]] E|
#+end_org """
####+END:

####+BEGIN: b:py3:cs:cmnd/classHead :cmndName "examples" :extent "verify" :ro "noCli" :comment "FrameWrk: CS-Main-Examples" :parsMand "" :parsOpt "" :argsMin 0 :argsMax 0 :pyInv ""
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CmndSvc-   [[elisp:(outline-show-subtree+toggle)][||]] <<examples>>  *FrameWrk: CS-Main-Examples*  =verify= ro=noCli   [[elisp:(org-cycle)][| ]]
#+end_org """
class examples(cs.Cmnd):
    cmndParamsMandatory = [ ]
    cmndParamsOptional = [ ]
    cmndArgsLen = {'Min': 0, 'Max': 0,}
    rtInvConstraints = cs.rtInvoker.RtInvoker.new_noRo() # NO RO From CLI

    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmnd(self,
             rtInv: cs.RtInvoker,
             cmndOutcome: b.op.Outcome,
    ) -> b.op.Outcome:
        """FrameWrk: CS-Main-Examples"""
        failed = b_io.eh.badOutcome
        callParamsDict = {}
        if self.invocationValidate(rtInv, cmndOutcome, callParamsDict, None).isProblematic():
            return failed(cmndOutcome)
####+END:
        self.cmndDocStr(f""" #+begin_org
***** [[elisp:(org-cycle)][| *CmndDesc:* | ]]  Conventional top level example.
        #+end_org """)

        cs.examples.myName(cs.G.icmMyName(), cs.G.icmMyFullName())
        cs.examples.commonBrief()

        # userConfig_csu.examples_csu().pyCmnd()

        od = collections.OrderedDict
        cmnd = cs.examples.cmndEnter

        cs.examples.menuChapter('=Generate Requirements= / =gen requirements.txt via pipreqs + namespace expansion=')
        cmnd('genRequirements',
             pars=od([
                 ('srcDir', './bisos/pipreqsPlus'),
             ]),
             comment="# Minimal: scans srcDir + ./bin; namespaces defaults to [\"bisos\"]")
        cmnd('genRequirements',
             pars=od([
                 ('srcDir',     './bisos/pipreqsPlus'),
                 ('binDir',     './bin'),
                 ('outFile',    './requirements.txt'),
                 ('namespaces', "[\'bisos\', \'other\']"),
             ]),
             comment="# Multi-namespace expansion")
        cmnd('genRequirements',
             pars=od([
                 ('srcDir',    './bisos/pipreqsPlus'),
                 ('extraExts', "[\'cs\', \'pcs\', \'mcs\']"),
             ]),
             comment="# Force-include files by extension in addition to shebang detection")

        return(cmndOutcome)



####+BEGIN: b:py3:cs:cmnd/classHead :cmndName "genRequirements" :comment "Generate requirements.txt via pipreqs + namespace expansion" :extent "verify" :ro "cli" :parsMand "srcDir" :parsOpt "binDir outFile extraExts namespaces pipreqsMode" :argsMin 0 :argsMax 0 :pyInv ""
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CmndSvc-   [[elisp:(outline-show-subtree+toggle)][||]] <<genRequirements>>  *Generate requirements.txt via pipreqs + namespace expansion*  =verify= parsMand=srcDir parsOpt=binDir outFile extraExts namespaces pipreqsMode ro=cli   [[elisp:(org-cycle)][| ]]
#+end_org """
class genRequirements(cs.Cmnd):
    cmndParamsMandatory = [ 'srcDir', ]
    cmndParamsOptional = [ 'binDir', 'outFile', 'extraExts', 'namespaces', 'pipreqsMode', ]
    cmndArgsLen = {'Min': 0, 'Max': 0,}

    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmnd(self,
             rtInv: cs.RtInvoker,
             cmndOutcome: b.op.Outcome,
             srcDir: typing.Optional[str]=None,  # Cs Mandatory Param
             binDir: typing.Optional[str]=None,  # Cs Optional Param
             outFile: typing.Optional[str]=None,  # Cs Optional Param
             extraExts: typing.Optional[str]=None,  # Cs Optional Param
             namespaces: typing.Optional[str]=None,  # Cs Optional Param
             pipreqsMode: typing.Optional[str]=None,  # Cs Optional Param
    ) -> b.op.Outcome:
        """Generate requirements.txt via pipreqs + namespace expansion"""
        failed = b_io.eh.badOutcome
        callParamsDict = {'srcDir': srcDir, 'binDir': binDir, 'outFile': outFile,
                          'extraExts': extraExts, 'namespaces': namespaces, 'pipreqsMode': pipreqsMode, }
        if self.invocationValidate(rtInv, cmndOutcome, callParamsDict, None).isProblematic():
            return failed(cmndOutcome)
        srcDir = csParam.mappedValue('srcDir', srcDir)
        binDir = csParam.mappedValue('binDir', binDir)
        outFile = csParam.mappedValue('outFile', outFile)
        extraExts = csParam.mappedValue('extraExts', extraExts)
        namespaces = csParam.mappedValue('namespaces', namespaces)
        pipreqsMode = csParam.mappedValue('pipreqsMode', pipreqsMode)
####+END:
        self.cmndDocStr(f""" #+begin_org
** [[elisp:(org-cycle)][| *CmndDesc:* | ]]  Generate =requirements.txt= via pipreqs, then augment
   with namespace-package submodule names that pipreqs collapses.

Params:
1) srcDir (Mandatory) --- package source tree to scan.
2) binDir (Optional, default ./bin) --- directory of executables/scripts.
   Top-level only (no recursion). Python-source files are detected by:
   (a) .py extension, (b) matching --extraExts, or (c) a Python shebang.
3) outFile (Optional, default ./requirements.txt) --- where to write.
4) extraExts (Optional, default []) --- Python-literal list of extra
   file extensions (without dots). Example: "['cs', 'pcs', 'mcs']".
5) namespaces (Optional, default ['bisos']) --- Python-literal list of
   namespace packages to expand. Two-level names (=NS.X=) are extracted
   and appended to requirements.txt.
6) pipreqsMode (Optional, default "no-pin") --- passed to pipreqs --mode.

Returns the path to the written requirements.txt on success.
        #+end_org """)

        # Resolve relative paths against the original invocation cwd, not
        # the framework's possibly-different runtime cwd. $PWD is set by
        # every interactive shell and survives internal chdir() calls.
        invocationCwd = pathlib.Path(os.environ.get("PWD", os.getcwd()))

        def _resolveRel(rawPath, defaultRel):
            p = rawPath if rawPath else defaultRel
            path = pathlib.Path(p).expanduser()
            if not path.is_absolute():
                path = invocationCwd / path
            return path.resolve()

        srcDirPath = _resolveRel(srcDir, srcDir)
        binDirPath = _resolveRel(binDir, "./bin")
        outFilePath = _resolveRel(outFile, "./requirements.txt")
        extraExtsList = _resolveListParam(extraExts, [])
        namespacesList = _resolveListParam(namespaces, ["bisos"])
        modeStr = pipreqsMode if pipreqsMode else "no-pin"

        # Validate srcDir.
        if not srcDirPath.is_dir():
            b_io.eh.problem_notyet(f"srcDir does not exist or is not a directory: {srcDirPath}")
            return failed(cmndOutcome)

        # Verify pipreqs is on PATH.
        if shutil.which("pipreqs") is None:
            b_io.eh.problem_notyet(
                "pipreqs not found on PATH; install with: pipx install pipreqs"
            )
            return failed(cmndOutcome)

        b_io.ann.note(f"Scanning srcDir={srcDirPath}")
        if binDirPath.is_dir():
            b_io.ann.note(f"Scanning binDir={binDirPath} (top-level only; extraExts={extraExtsList})")
        else:
            b_io.ann.note(f"binDir={binDirPath} not present; skipping")
            binDirPath = None

        # Build the scratch scan tree (.py symlinks for pipreqs).
        scanDir = symlinkTree.build(srcDirPath, binDirPath, extraExtsList)

        try:
            # Run pipreqs against the scratch tree.
            pipreqsCmd = [
                "pipreqs", "--force", "--mode", modeStr,
                "--savepath", str(outFilePath), str(scanDir),
            ]
            b_io.ann.note(f"Running: {' '.join(pipreqsCmd)}")
            result = subprocess.run(pipreqsCmd, capture_output=True, text=True)

            if result.returncode != 0:
                b_io.eh.problem_notyet(
                    f"pipreqs failed (rc={result.returncode}): {result.stderr.strip()}"
                )
                return cmndOutcome.set(
                    opError=b.op.OpError.Failure,
                    opResults=result.stderr.strip(),
                )

            # Augment with two-level namespace-submodule imports.
            submods = scanner.findNamespaceImports(scanDir, namespacesList)
            if submods:
                _augmentWithNamespaces(outFilePath, submods)
                b_io.ann.note(
                    f"Augmented {outFilePath.name} with namespace submodules: {sorted(submods)}"
                )
        finally:
            symlinkTree.cleanup(scanDir)

        b_io.ann.note(f"Wrote {outFilePath}")

        return cmndOutcome.set(
            opError=b.op.OpError.Success,
            opResults=str(outFilePath),
        )



####+BEGIN: blee:bxPanel:foldingSection :outLevel 0 :sep nil :title "Main" :anchor ""  :extraInfo "Framework DBlock"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*     [[elisp:(outline-show-subtree+toggle)][| _Main_: |]]  Framework DBlock  [[elisp:(org-shifttab)][<)]] E|
#+end_org """
####+END:

####+BEGIN: b:py3:cs:framework/main :csInfo "csInfo" :noCmndEntry "examples" :extraParamsHook "g_extraParams" :importedCmndsModules "g_importedCmndsModules"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] =g_csMain= (csInfo, _examples_, g_extraParams, g_importedCmndsModules)
#+end_org """

if __name__ == '__main__':
    cs.main.g_csMain(
        csInfo=csInfo,
        noCmndEntry=examples,
        extraParamsHook=g_extraParams,
        ignoreUnknownParams=False,
        importedCmndsModules=g_importedCmndsModules,
    )

####+END:

####+BEGIN: b:py3:cs:framework/endOfFile :basedOn "classification"
""" #+begin_org
* [[elisp:(org-cycle)][| *End-Of-Editable-Text* |]] :: emacs and org variables and control parameters
#+end_org """

#+STARTUP: showall

### local variables:
### no-byte-compile: t
### end:
####+END:
