﻿using RoR2;
using System;
using UnityEngine;

namespace TechnoEmperorMod.Modules.Achievements
{
    internal class MasteryAchievement : BaseMasteryUnlockable
    {
        public override string AchievementTokenPrefix => TechnoEmperorPlugin.DEVELOPER_PREFIX + "_TECHNO_EMPEROR_BODY_MASTERY";
        //the name of the sprite in your bundle
        public override string AchievementSpriteName => "texMasteryAchievement";
        //the token of your character's unlock achievement if you have one
        public override string PrerequisiteUnlockableIdentifier => TechnoEmperorPlugin.DEVELOPER_PREFIX + "_TECHNO_EMPEROR_BODY_UNLOCKABLE_REWARD_ID";

        public override string RequiredCharacterBody => "HenryBody";
        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}