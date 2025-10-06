using System.Collections.Generic;
using System.Linq;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace AddAmountOfRecipePer1min
{
    [BepInPlugin(ModGuid, ModName, ModVersion)]
    [BepInProcess("DSPGAME.exe")]
    public class MainPlugin : BaseUnityPlugin
    {
        public const string ModGuid = "com.enriquein.plugins.addamountofrecipeper1min_continued";
        public const string ModName = "AddAmountOfRecipePer1min";
        public const string ModVersion = "1.3.1";

        public static string MK1 = "mk1";
        public static string MK2 = "mk2";
        public static string MK3 = "mk3";
        public static Dictionary<string, double> ValidSpeedsForAssembler =
            new Dictionary<string, double>()
            {
                { MK1, 0.75 },
                { MK2, 1.0 },
                { MK3, 1.5 }
            };

        public static Dictionary<string, double> ValidSpeedsForSmelter =
            new Dictionary<string, double>()
            {
                { MK1, 1.0 },
                { MK2, 2.0 }
            };

        public static ConfigEntry<bool> LimitDefaultAssemblerSpeedToLatestUnlocked { get; set; }
        public static ConfigEntry<string> DefaultAssemblerSpeed { get; set; }
        public static ConfigEntry<bool> LimitDefaultSmelterSpeedToLatestUnlocked { get; set; }
        public static ConfigEntry<string> DefaultSmelterSpeed { get; set; }
        public static ConfigEntry<string> SpeedToShowOnLeftCtrl { get; set; }
        public static ConfigEntry<string> SpeedToShowOnLeftShift { get; set; }
        public static ConfigEntry<string> SpeedToShowOnLeftAlt { get; set; }

        public void Awake()
        {
            LoadConfig();

            var harmony = new Harmony("com.enriquein.plugins.addamountofrecipeper1min_continued.patch");
            harmony.PatchAll(typeof(Patch_UIItemTip_SetTip));
            harmony.PatchAll(typeof(Patch_UIItemTip_OnDisable));
        }

        private void LoadConfig()
        {
            DefaultAssemblerSpeed = Config.Bind<string>("Default Speeds", "Default_Assembler_Speed", MK2, "Default speed to use for Assembler recipe tooltips.");
            DefaultAssemblerSpeed.Value = GetDefaultIfInvalid(ValidSpeedsForAssembler.Keys, DefaultAssemblerSpeed.Value, MK2);

            DefaultSmelterSpeed = Config.Bind<string>("Default Speeds", "Default_Smelter_Speed", MK1, "Default speed to use for Smelter recipe tooltips.");
            DefaultSmelterSpeed.Value = GetDefaultIfInvalid(ValidSpeedsForSmelter.Keys, DefaultSmelterSpeed.Value, MK1);

            LimitDefaultAssemblerSpeedToLatestUnlocked = Config.Bind<bool>("Default Speeds", "Limit_Default_Assembler_Speed_To_Latest_Unlocked", true, "When `true` it will limit the default speed to the maximum assembler speed unlocked. Useful if you want to display a specific speed, but only if you have unlocked it. If `false` it will always use the default speed regardless of your unlocks.");
            LimitDefaultSmelterSpeedToLatestUnlocked = Config.Bind<bool>("Default Speeds", "Limit_Default_Smelter_Speed_To_Latest_Unlocked", true, "When `true` it will limit the default speed to the maximum smelter speed unlocked. Useful if you want to display a specific speed, but only if you have unlocked it. If `false` it will always use the default speed regardless of your unlocks.");

            SpeedToShowOnLeftCtrl = Config.Bind<string>("Hover key bindings", "Speed_To_Show_On_Left_Ctrl", MK1, $"Speed to show when pressing the left Ctrl key while hovering over an item. Valid values are {MK1}, {MK2}, and {MK3}. Only applies to Assemblers, since Smelters will use the non-default speed on hover.");
            SpeedToShowOnLeftCtrl.Value = GetDefaultIfInvalid(ValidSpeedsForAssembler.Keys, SpeedToShowOnLeftCtrl.Value, MK1);

            SpeedToShowOnLeftShift = Config.Bind<string>("Hover key bindings", "Speed_To_Show_On_Left_Shift", MK2, $"Speed to show when pressing the left Shift key while hovering over an item. Valid values are {MK1}, {MK2}, and {MK3}. Only applies to Assemblers, since Smelters will use the non-default speed on hover.");
            SpeedToShowOnLeftShift.Value = GetDefaultIfInvalid(ValidSpeedsForAssembler.Keys, SpeedToShowOnLeftShift.Value, MK2);

            SpeedToShowOnLeftAlt = Config.Bind<string>("Hover key bindings", "Speed_To_Show_On_Left_Alt", MK3, $"Speed to show when pressing the left Alt key while hovering over an item. Valid values are {MK1}, {MK2}, and {MK3}. Only applies to Assemblers, since Smelters will use the non-default speed on hover.");
            SpeedToShowOnLeftAlt.Value = GetDefaultIfInvalid(ValidSpeedsForAssembler.Keys, SpeedToShowOnLeftAlt.Value, MK3);
        }

        private string GetDefaultIfInvalid(IEnumerable<string> validValues, string value, string defaultValue)
        {
            return validValues.Count(x => x.ToLowerInvariant() == value.ToLowerInvariant()) > 0
                ? value.ToLowerInvariant()
                : defaultValue;
        }
    }
}
