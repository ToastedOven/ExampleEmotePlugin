using BepInEx;
using BepInEx.Configuration;
using EmotesAPI;
using R2API;
using R2API.Utils;
using RiskOfOptions;
using RiskOfOptions.Options;
using RoR2;
using UnityEngine;

namespace ExamplePlugin
{
    [BepInDependency("com.weliveinasociety.CustomEmotesAPI")]
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.EveryoneNeedSameModVersion)]
    [R2APISubmoduleDependency("SoundAPI", "PrefabAPI", "CommandHelper", "ResourcesAPI")]
    public class CaramellPlugin : BaseUnityPlugin
    {
        public const string PluginGUID = "com.weliveinasociety.caramelldansen";
        public const string PluginAuthor = "Nunchuk";
        public const string PluginName = "Caramelldansen";
        public const string PluginVersion = "1.0.4";
        public void Awake()
        {
            Assets.PopulateAssets();
            Assets.AddSoundBank("caramelldeeznuts.bnk");
            Assets.LoadSoundBanks();
            CustomEmotesAPI.AddCustomAnimation(Assets.Load<AnimationClip>("@ExampleEmotePlugin_caramelldansen:assets/animationreplacements/caramelldansen.anim"), false, "PlayCaramell", "StopCaramell", dimWhenClose: true,syncAnim: true, syncAudio: true);
        }
    }
}
