#!/bin/sh
# Type './build.sh' to generate C# classes.

if [ ! -f ../vgcore/win/vc2010.sln ] ; then
    git clone https://github.com/touchvg/vgcore ../vgcore
fi
cd touchvg; sh build.sh; cd ..
