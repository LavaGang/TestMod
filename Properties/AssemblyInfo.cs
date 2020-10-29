using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(TestMod.BuildInfo.Description)]
[assembly: AssemblyDescription(TestMod.BuildInfo.Description)]
[assembly: AssemblyCompany(TestMod.BuildInfo.Company)]
[assembly: AssemblyProduct(TestMod.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + TestMod.BuildInfo.Author)]
[assembly: AssemblyTrademark(TestMod.BuildInfo.Company)]
[assembly: AssemblyVersion(TestMod.BuildInfo.Version)]
[assembly: AssemblyFileVersion(TestMod.BuildInfo.Version)]
[assembly: MelonInfo(typeof(TestMod.TestMod), TestMod.BuildInfo.Name, TestMod.BuildInfo.Version, TestMod.BuildInfo.Author, TestMod.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]