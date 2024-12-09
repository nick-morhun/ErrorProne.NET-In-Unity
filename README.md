# ErrorProne.NET-In-Unity
[ErrorProne.NET](https://github.com/SergeyTeplyakov/ErrorProne.NET) set up with [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity).
Tested with Unity 2022.3 LTS and JetBrains Rider 2024.3. The warnings may not appear in Unity console; in that case, use the IDE (in Rider it's Problems tool).
All libraries are configured only for the Editor platform. When you opent the project in Unity Editor for the first time, NuGetForUnity will install actual packages. Errors about globalconfig files may appear.

## Usage
1. Add [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) to your Unity project.
2. Copy Assets/packages.config into your projects under the same path.
3. Optionally copy contents of NuGet_Packages into your Nuget packages directory. Packages there are set up to minimize dependencies.
4. Open the project in Unity.
5. Use NuGet -> Restore Packages menu if needed.
6. Don't forget to read the licenses and include a third party notice.
7. Restart Unity again. This will activate the new analysers.
8. Delete your C# project files.
9. Open C# project in your IDE from your Unity project.
10. Commit the files in your project.
