# ErrorProne.NET-In-Unity
[ErrorProne.NET](https://github.com/SergeyTeplyakov/ErrorProne.NET) set up with [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity).
Tested with Unity 2022.3 LTS and JetBrains Rider 2024.3. The warnings may not appear in Unity console; in that case, use the IDE (in Rider it's Problems tool).
All libraries are configured only for the Editor platform. Errors about globalconfig files may appear when the project is open in Unity.

## Usage
1. Add [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) to your Unity project.
2. Copy Assets/packages.config into your projects under the same path.
3. Use NuGet -> Restore Packages menu if needed.
4. Optionally copy NuGet_Packages into your Nuget packages directory.
