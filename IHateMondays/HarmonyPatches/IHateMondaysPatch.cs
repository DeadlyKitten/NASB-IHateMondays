using HarmonyLib;
using Nick;
using System;

namespace IHateMondays.HarmonyPatches
{
    [HarmonyPatch(typeof(DLCManager), "IsUnlocked", new Type[] { typeof(CharacterMetaData) })]
    class IHateMondaysPatch
    {
        static void Postfix(CharacterMetaData charMeta, ref bool __result)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && charMeta.id == "char_orb")
                __result = false;
        }
    }
}
