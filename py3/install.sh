#!/bin/bash
#
# This is for user files based (git) installation. For development, use pypiProc.sh
#
set -x
#
pip uninstall -y polytson.soncli
pip install . --upgrade
