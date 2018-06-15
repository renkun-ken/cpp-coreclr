# cpp-coreclr

Calling .NET Core methods from C++

This project is a minimal example that reproduces <http://yizhang82.me/hosting-coreclr>.

Use `./build.sh` to build the project.

Run `build/main` with the directory that contains CoreCLR dynamic libraries, which is usually found as following:

## Linux

```text
/opt/dotnet/shared/Microsoft.NETCore.App
```

## MacOS

```text
/usr/local/share/dotnet/shared/Microsoft.NETCore.App
```
