using HarmonyLib;
using IHateMondays.Utilities;
using Nick;
using System;

namespace IHateMondays.HarmonyPatches
{
    [HarmonyPatch(typeof(CharacterSlotData), "CursorClick")]
    class ReallyNoPurchasePatch
    {
        static bool Prefix(CharacterSlotData __instance)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && 
                __instance.slotcmd.id == "char_orb" && 
                __instance.GetProperty<bool>("charLocked"))
                return false;
            return true;
        }
    }
}
