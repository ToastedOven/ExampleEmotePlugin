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
    [R2APISubmoduleDependency("SoundAPI", "PrefabAPI", "CommandHelper", "LoadoutAPI", "SurvivorAPI", "ResourcesAPI", "LanguageAPI", "NetworkingAPI", "UnlockAPI")]
    public class ExamplePlugin : BaseUnityPlugin
    {
        public const string PluginGUID = "com.weliveinasociety.caramelldansen";
        public const string PluginAuthor = "Nunchuk";
        public const string PluginName = "Caramelldansen";
        public const string PluginVersion = "1.0.0";
        public void Awake()
        {
            Assets.PopulateAssets();
            Assets.AddSoundBank("caramell.bnk");
            Assets.LoadSoundBanks();
            CustomEmotesAPI.AddCustomAnimation(Assets.Load<AnimationClip>("@ExampleEmotePlugin_caramelldansen:assets/animationreplacements/caramelldansen.anim"), false, "Play_Caramell", "Stop_Caramell", dimWhenClose: true,syncAnim: true, syncAudio: true);
        }
    }
}
