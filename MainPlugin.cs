using BepInEx;
using HarmonyLib;

namespace AddAmountOfRecipePer1min
{

    [BepInPlugin(ModGuid, ModName, ModVersion)]
    [BepInProcess("DSPGAME.exe")]
    public class MainPlugin : BaseUnityPlugin
    {
        public const string ModGuid = "com.enriquein.plugins.addamountofrecipeper1min_continued";
        public const string ModName = "AddAmountOfRecipePer1min";
        public const string ModVersion = "1.0.0";

        public void Awake()
        {
            var harmony = new Harmony("com.enriquein.plugins.addamountofrecipeper1min_continued.patch");
            harmony.PatchAll(typeof(Patch_UIItemTip_SetTip));
            harmony.PatchAll(typeof(Patch_UIItemTip_OnDisable));
        }
    }
}
