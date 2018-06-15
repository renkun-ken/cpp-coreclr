#! /bin/bash
cmake --build build --config Debug --target all -- -j 10
cd manlib
dotnet build
cd ..
cp manlib/bin/Debug/netstandard2.0/manlib.dll build
