﻿using RoR2;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HenryMod.Modules {

    internal static class Buffs
    {
        public static BuffDef zapShieldBuff;
        
        public static BuffDef conductiveBuffTeam;
        public static BuffDef conductiveBuffTeamGrace;

        //public static BuffDef blinkCooldownBuff;

        public static BuffDef desolatorArmorBuff;
        public static BuffDef desolatorDeployBuff;

        public static BuffDef desolatorArmorShredDeBuff;
        public static BuffDef desolatorDotDeBuff;

        //Aliem
        public static BuffDef riddenBuff;

        public static void RegisterBuffs() {
            zapShieldBuff =
                AddNewBuff("Tesla Barrier",
                           LegacyResourcesAPI.Load<BuffDef>("BuffDefs/HiddenInvincibility").iconSprite,
                           Color.cyan,
                           false,
                           false);

            Sprite teslaIcon = LegacyResourcesAPI.Load<BuffDef>("BuffDefs/TeslaField").iconSprite;

            conductiveBuffTeam =
                AddNewBuff("Charged",
                           teslaIcon,
                           Color.cyan,
                           false,
                           false);
            conductiveBuffTeamGrace =
                AddNewBuff("Charged2",
                           teslaIcon,
                           Color.blue,
                           false,
                           false);
            //blinkCooldownBuff =
            //    AddNewBuff("BlinkCooldown",
            //               LegacyResourcesAPI.Load<BuffDef>("BuffDefs/Cloak").iconSprite,
            //               Color.gray,
            //               false,
            //               false);
        }

        public static BuffDef AddNewBuff(string buffName, Sprite buffIcon, Color buffColor, bool canStack, bool isDebuff) {
            BuffDef buffDef = ScriptableObject.CreateInstance<BuffDef>();
            buffDef.name = buffName;
            buffDef.iconSprite = buffIcon;
            buffDef.buffColor = buffColor;
            buffDef.canStack = canStack;
            buffDef.isDebuff = isDebuff;
            buffDef.eliteDef = null;

            Modules.Content.AddBuffDef(buffDef);

            return buffDef;
        }
    }
}