using HarmonyLib;
using UI.ObjectMarker;

namespace LabelsOn
{
    [HarmonyPatch(typeof(ObjectMarkerViewer), "Awake")]
    internal class ObjectMarkerViewerPatch
    {
        static void Postfix(ref bool ___abilityToggled)
        {
            ___abilityToggled = true;
        }
    }
}
