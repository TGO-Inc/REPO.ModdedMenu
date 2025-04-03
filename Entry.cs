using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Shared.Game;

namespace ModdedMenu;

[BepInPlugin(PluginGuid, PluginName, PluginVersion), 
 BepInDependency("tgo.shared", "1.0.0.0")]
internal sealed class Entry : BaseUnityPlugin
{
    private const string PluginGuid = "tgo.moddedmenu";
    private const string PluginName = "ModdedMenu";
    private const string PluginVersion = "1.0.0.0";
    private static readonly Harmony Harmony = new(PluginGuid);
    internal static ManualLogSource LogSource { get; } = BepInEx.Logging.Logger.CreateLogSource(PluginGuid);
    
    internal static readonly Core.MenuEngine InternalEngine = new();
    private void Awake()
    {
        InternalEngine.Initialize();
    }
}