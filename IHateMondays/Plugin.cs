using BepInEx;
using HarmonyLib;

namespace IHateMondays
{
    [BepInPlugin("com.steven.nasb.monday", "I Hate Mondays", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            gameObject.name = "I Hate Mondays";

            var harmony = new Harmony("com.steven.nasb.monday");
            harmony.PatchAll();
        }
    }
}
