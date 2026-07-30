#
# This is for user files based (git) installation. For development, use pypiProc.ps1
#
$VerbosePreference = "Continue"

pip uninstall -y polytson.soncli
pip install . --upgrade
