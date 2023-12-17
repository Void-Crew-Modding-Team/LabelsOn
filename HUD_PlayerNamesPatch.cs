using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LabelsOn
{
    [HarmonyPatch(typeof(HUD_PlayerNames), "Start")]
    internal class HUD_PlayerNamesPatch
    {
        private static MethodInfo showMethod = AccessTools.Method(typeof(HUD_PlayerNames), "Show");

        static void Postfix(HUD_PlayerNames __instance, ref bool ___abilityToggled)
        {
            ___abilityToggled = true;
            showMethod.Invoke(__instance, new object[] { true });
        }
    }
}
