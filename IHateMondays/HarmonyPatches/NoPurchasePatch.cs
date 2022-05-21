using HarmonyLib;
using Nick;
using System;
using UnityEngine;

namespace IHateMondays.HarmonyPatches
{
    [HarmonyPatch(typeof(CharacterSlotData), "Apply")]
    class NoPurchasePatch
    {
        static void Postfix(CharacterMetaData chmd, ref GameObject ___lockImage)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && chmd.id == "char_orb")
                ___lockImage.SetActive(false);
        }
    }
}
