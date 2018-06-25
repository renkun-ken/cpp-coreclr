# cpp-coreclr

Calling .NET Core methods from C++

This project is a minimal example that reproduces <http://yizhang82.me/hosting-coreclr>.

Use `./build.sh` to build the project.

Run `build/main` with the directory that contains CoreCLR dynamic libraries, which is usually found as following:

```sh
dotnet --list-runtimes
```

For example, on Ubuntu 18.04:

```sh
build/main /usr/share/dotnet/shared/Microsoft.NETCore.App
```
