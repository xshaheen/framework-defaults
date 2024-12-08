# Framework.Defaults

This is the Framework.Defaults package, which provides the standard configurations and settings for the Framework
projects. Such as `.editorconfig`, build props and targets.
All of our projects are built on top of this package, so we can have a consistent build process and settings across all
of our projects.

## Installation

To install this package, you can use the following command:
[Defaults.csproj](Defaults.csproj)

```bash
dotnet add package Framework.Defaults
```

or add the following package reference to your project file:

```xml
<PackageReference Include="Framework.Defaults" Version="x.x.x" PrivateAssets="all"/>
```