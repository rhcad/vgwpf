#!/bin/sh
# Type './build.sh' to generate C# classes.

rm -rf ../touchvglib/core/*.*
mkdir -p ../touchvglib/core

swig -c++ -csharp -namespace touchvg.core \
    -outdir ../touchvglib/core \
    -o touchvg_csharp_wrap.cpp \
    -I../../vgcore/core/include \
    -I../../vgcore/core/include/canvas \
    -I../../vgcore/core/include/graph \
    -I../../vgcore/core/include/cmd \
    -I../../vgcore/core/include/storage \
    -I../../vgcore/core/include/geom \
    -I../../vgcore/core/include/gshape \
    -I../../vgcore/core/include/shape \
    -I../../vgcore/core/include/cmdobserver \
    -I../../vgcore/core/include/cmdbase \
    -I../../vgcore/core/include/test \
    -I../../vgcore/core/include/view \
    -I../../vgcore/core/include/cmdbasic \
    -I../../vgcore/core/include/shapedoc \
    -I../../vgcore/core/include/jsonstorage \
    -I../../vgcore/core/include/cmdmgr \
    -I../../vgcore/core/include/record \
    -I../../vgcore/core/src/view \
      ../../vgcore/core/src/view/touchvg.swig
