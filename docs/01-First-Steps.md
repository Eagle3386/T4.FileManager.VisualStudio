# First steps

## Requirements

- Visual Studio 2017 or Visual Studio 2019

## Getting started

Install the File Manager with nuget.

### .NET Core and .NET Standard

```
Install-Package T4.FileManager.VisualStudio
```

Build or rebuild the project where the File Manager has been added as a package. After that `T4.FileManager.VisualStudio.ttinclude` is automatically added to the project root.

#### Short note on compatibility with .NET Core/.NET Standard

Compatibility is not possible directly with .NET Core. But due to the fact that T4 can be executed independently from C# code, it is possible to add the File Manager to a .NET Core project. This results in a certain dependency on Visual Studio and restrictions to other platforms. The code generated by the File Manager can then easily be .NET Core capable. 

### .NET Framework

```
Install-Package T4.FileManager.VisualStudio
```

`T4.FileManager.VisualStudio.ttinclude` should be automatically added to your project root.
