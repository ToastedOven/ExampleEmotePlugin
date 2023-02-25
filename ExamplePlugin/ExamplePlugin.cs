using BepInEx;
using BepInEx.Configuration;
using RoR2;
using UnityEngine;

namespace CSSPluginSpace
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class CSSPlugin : BaseUnityPlugin
    {
        public const string PluginGUID = "com.valve.CSS";
        public const string PluginAuthor = "Nunchuk";
        public const string PluginName = "CSS";
        public const string PluginVersion = "1.0.0";
        public static GameObject CSSDesker;
        public void Awake()
        {
            Assets.AddBundle($"css");
            CSSDesker = Assets.Load<GameObject>("Assets/Prefabs/CSSDesker.prefab");
            Debug.Log($"CSS Loaded {CSSDesker}");
        }
    }
}
