using System;
using System.Reflection;
using System.Runtime.InteropServices;
using HansKindberg.VisualStudio.Extensions.TextFormatter;

[assembly: AssemblyCompany(Vsix.Author)]
[assembly: AssemblyConfiguration(
#if DEBUG
	"Debug"
#else
	"Release"
#endif
)]
[assembly: AssemblyDescription(Vsix.Description)]
[assembly: AssemblyFileVersion(Vsix.Version)]
[assembly: AssemblyProduct(Vsix.Name)]
[assembly: AssemblyTitle(Vsix.Name)]
[assembly: AssemblyVersion(Vsix.Version)]
[assembly: CLSCompliant(false)]
[assembly: ComVisible(false)]