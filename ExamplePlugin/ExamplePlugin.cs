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
        public const string PluginGUID = "com.weliveinasociety.badassemotes";
        public const string PluginAuthor = "Nunchuk";
        public const string PluginName = "BadAssEmotes";
        public const string PluginVersion = "1.0.0";
        public void Awake()
        {
            Assets.PopulateAssets();
            Assets.AddSoundBank("BadAssEmotes.bnk");
            Assets.LoadSoundBanks();
            AddAnimation("Breakin", "Breakin_");
            AddAnimation("Breakneck", "Breakneck");
            AddAnimation("Crabby", "Crabby");
            AddAnimation("Dabstand", "Dabstand");
            AddAnimation("DanceMoves", "DanceMoves");
            AddAnimation("DanceTherapyIntro", "DanceTherapyIntro", "DanceTherapyLoop");
            AddAnimation("DeepDab", "Dabstand");
            AddAnimation("Droop", "Droop");
            AddAnimation("ElectroSwing", "ElectroSwing");
            AddAnimation("Extraterrestrial", "Extraterrestrial");
            AddAnimation("FancyFeet", "FancyFeet");
            AddAnimation("FlamencoIntro", "Flamenco", "FlamencoLoop");
            AddAnimation("Floss", "Floss");
            AddAnimation("Fresh", "Fresh");
            AddAnimation("Hype", "Hype");
            AddAnimation("Infectious", "Infectious");
            AddAnimation("InfinidabIntro", "InfinidabIntro", "InfinidabLoop");
            AddAnimation("IntensityIntro", "IntensityIntro", "IntensityLoop");
            AddAnimation("NeverGonna", "NeverGonna");
            AddAnimation("NinjaStyle", "NinjaStyle");
            AddAnimation("OldSchool", "OldSchool");
            AddAnimation("OrangeJustice", "OrangeJustice");
            AddAnimation("Overdrive", "Overdrive");
            AddAnimation("PawsAndClaws", "Paws_Claws");
            AddAnimation("PhoneItIn", "PhoneItIn");
            AddAnimation("PopLock", "PopLock");
            AddAnimation("Scenario", "Scenario");
            AddAnimation("SpringLoaded", "SpringLoaded");
            AddAnimation("Springy", "Springy");
            AddAnimation("SquatKickIntro", "SquatKick", "SquatKickLoop");
        }
        internal void AddAnimation(string AnimClip, string wwise)
        {
            CustomEmotesAPI.AddCustomAnimation(Assets.Load<AnimationClip>($"@ExampleEmotePlugin_badassemotes:assets/{AnimClip}.anim"), Assets.Load<AnimationClip>($"@ExampleEmotePlugin_badassemotes:assets/{AnimClip}.anim").isLooping, $"Play_{wwise}", $"Stop_{wwise}");
        }
        internal void AddAnimation(string AnimClip, string wwise, string AnimClip2ElectricBoogaloo)
        {
            CustomEmotesAPI.AddCustomAnimation(Assets.Load<AnimationClip>($"@ExampleEmotePlugin_badassemotes:assets/{AnimClip}.anim"), Assets.Load<AnimationClip>($"@ExampleEmotePlugin_badassemotes:assets/{AnimClip}.anim").isLooping, $"Play_{wwise}", $"Stop_{wwise}", secondaryAnimation: Assets.Load<AnimationClip>($"@ExampleEmotePlugin_badassemotes:assets/{AnimClip}.anim"));
        }
    }
}
