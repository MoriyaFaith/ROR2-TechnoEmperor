using R2API;
using System;

namespace HenryMod.Modules
{
    internal static class Tokens
    {
        internal static void AddTokens()
        {
            #region Henry
            string prefix = HenryPlugin.DEVELOPER_PREFIX + "_TECHNO_EMPEROR_BODY_";

            string desc = "Henry is a skilled fighter who makes use of a wide arsenal of weaponry to take down his foes.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Sword is a good all-rounder while Boxing Gloves are better for laying a beatdown on more powerful foes." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Pistol is a powerful anti air, with its low cooldown and high damage." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Roll has a lingering armor buff that helps to use it aggressively." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Bomb can be used to wipe crowds with ease." + Environment.NewLine + Environment.NewLine;

            string outro = "..and so he left, to expand his empire.";
            string outroFailure = "..and so he vanished, brilliant lights falling dormant.";

            LanguageAPI.Add(prefix + "NAME", "Techno Emperor");
            LanguageAPI.Add(prefix + "DESCRIPTION", desc);
            LanguageAPI.Add(prefix + "SUBTITLE", "Megalomaniacal Genius");
            LanguageAPI.Add(prefix + "LORE", "I've come to make an announcement; Shadow The Hedgehog's a bitch ass motherfucker, he pissed on my fucking wife. Thats right, he took his hedgehog quilly dick out and he pissed on my fucking wife, and he said his dick was \"This big\" and I said that's disgusting, so I'm making a callout post on my twitter dot com, Shadow the Hedgehog, you've got a small dick, it's the size of this walnut except WAY smaller, and guess what? Here's what my dong looks like: PFFFT, THAT'S RIGHT, BABY. ALL POINTS, NO QUILLS, NO PILLOWS. Look at that, it looks like two balls and a bong. He fucked my wife so guess what? I'm gonna fuck the Earth. THAT'S RIGHT THIS IS WHAT YOU GET, MY SUPER LASER PISS! Except I'm not gonna piss on the earth. I'm gonna go higher. I'M PISSING ON THE MOON! HOW DO YOU LIKE THAT, OBAMA? I PISSED ON THE MOON YOU IDIOT! YOU HAVE 23 HOURS BEFORE THE PISS DROPLETS HIT THE FUCKING EARTH NOW GET OUT OF MY SIGHT BEFORE I PISS ON YOU TOO.");
            LanguageAPI.Add(prefix + "OUTRO_FLAVOR", outro);
            LanguageAPI.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            LanguageAPI.Add(prefix + "DEFAULT_SKIN_NAME", "Default");
            LanguageAPI.Add(prefix + "MASTERY_SKIN_NAME", "Hard-Boiled");
            LanguageAPI.Add(prefix + "TYPHOON_SKIN_NAME", "Kilometer");
            LanguageAPI.Add(prefix + "INFERNO_SKIN_NAME", "Man on Fire");
            #endregion

            #region Passive
            LanguageAPI.Add(prefix + "PASSIVE_NAME", "Reverse-Engineering");
            LanguageAPI.Add(prefix + "PASSIVE_DESCRIPTION", "Instead of drones becoming an ally when bought, they are turned into Scrap, with similar machines being added to your army.");
            #endregion

            #region Primary
            LanguageAPI.Add(prefix + "PRIMARY_MISSILE_NAME", "Homing Missile Launch");
            LanguageAPI.Add(prefix + "PRIMARY_MISSILE_DESCRIPTION", Helpers.agilePrefix + $"Lock-on up to 8 enemies while held down. On release, launch a missile at each target for <style=cIsDamage>{100f * StaticValues.swordDamageCoefficient}% damage</style>.");
            LanguageAPI.Add(prefix + "PRIMARY_VULKAN_NAME", "Vulkan Cannon");
            LanguageAPI.Add(prefix + "PRIMARY_VULKAN_DESCRIPTION", $"Fire a heavy cannon for <style=cIsDamage>{100f * StaticValues.gunDamageCoefficient}% damage</style>.");
            #endregion

            #region Secondary
            LanguageAPI.Add(prefix + "SECONDARY_BOMB_NAME", "Mortar Launch");
            LanguageAPI.Add(prefix + "SECONDARY_BOMB_DESCRIPTION", $"Throw a bomb for <style=cIsDamage>{100f * StaticValues.bombDamageCoefficient}% damage</style>.");
            #endregion

            #region Utility
            LanguageAPI.Add(prefix + "UTILITY_ROLL_NAME", "Thruster Dodge");
            LanguageAPI.Add(prefix + "UTILITY_ROLL_DESCRIPTION", $"Roll a short distance, gaining <style=cIsUtility>300 armor</style>. <style=cIsUtility>You cannot be hit during the roll.</style>");
            #endregion

            #region Special
            LanguageAPI.Add(prefix + "SPECIAL_CANNON_NAME", "Eclipse Cannon");
            LanguageAPI.Add(prefix + "SPECIAL_CANNON_DESCRIPTION", $"Call down a massive oribital laser from your armada, dealing <style=cIsDamage>{100f * StaticValues.cannonDamageCoefficient}% damage</style>.");
            #endregion

            #region Achievements
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_NAME", "Techno Emperor: Mastery");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_DESC", "As Techno Emperor, beat the game or obliterate on Monsoon.");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_UNLOCKABLE_NAME", "Techno Emperor: Mastery");
            LanguageAPI.Add(prefix + "GRANDMASTERYUNLOCKABLE_ACHIEVEMENT_NAME", "Techno Emperor: Grand Mastery");
            LanguageAPI.Add(prefix + "GRANDMASTERYUNLOCKABLE_ACHIEVEMENT_DESC", "As Techno Emperor, beat the game or obliterate on Typhoon or Eclipse.");
            LanguageAPI.Add(prefix + "GRANDMASTERYUNLOCKABLE_UNLOCKABLE_NAME", "Techno Emperor: Grand Mastery");
            LanguageAPI.Add(prefix + "INFERNOMASTERYUNLOCKABLE_ACHIEVEMENT_NAME", "Techno Emperor: Survival");
            LanguageAPI.Add(prefix + "INFERNOMASTERYUNLOCKABLE_ACHIEVEMENT_DESC", "As Techno Emperor, beat the game or obliterate on Inferno.");
            LanguageAPI.Add(prefix + "INFERNOMASTERYUNLOCKABLE_UNLOCKABLE_NAME", "Techno Emperor: Survival");
            #endregion
            #endregion
        }
    }
}