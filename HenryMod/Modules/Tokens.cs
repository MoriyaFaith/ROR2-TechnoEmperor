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
            string outroFailure = "..and so he vanished, brilliant light falling dormant.";

            LanguageAPI.Add(prefix + "NAME", "Techno Emperor");
            LanguageAPI.Add(prefix + "DESCRIPTION", desc);
            LanguageAPI.Add(prefix + "SUBTITLE", "Megalomaniacal Genius");
            LanguageAPI.Add(prefix + "LORE", "I've come to make an announcement; Shadow The Hedgehog's a bitch ass motherfucker, he pissed on my fucking wife. Thats right, he took his hedgehog quilly dick out and he pissed on my fucking wife, and he said his dick was "This big" and I said that's disgusting, so I'm making a callout post on my twitter dot com, Shadow the Hedgehog, you've got a small dick, it's the size of this walnut except WAY smaller, and guess what? Here's what my dong looks like: PFFFT, THAT'S RIGHT, BABY. ALL POINTS, NO QUILLS, NO PILLOWS. Look at that, it looks like two balls and a bong. He fucked my wife so guess what? I'm gonna fuck the Earth. THAT'S RIGHT THIS IS WHAT YOU GET, MY SUPER LASER PISS! Except I'm not gonna piss on the earth. I'm gonna go higher. I'M PISSING ON THE MOON! HOW DO YOU LIKE THAT, OBAMA? I PISSED ON THE MOON YOU IDIOT! YOU HAVE 23 HOURS BEFORE THE PISS DROPLETS HIT THE FUCKING EARTH NOW GET OUT OF MY SIGHT BEFORE I PISS ON YOU TOO.");
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
            LanguageAPI.Add(prefix + "PRIMARY_SLASH_NAME", "Sword");
            LanguageAPI.Add(prefix + "PRIMARY_SLASH_DESCRIPTION", Helpers.agilePrefix + $"Swing forward for <style=cIsDamage>{100f * StaticValues.swordDamageCoefficient}% damage</style>.");
            #endregion

            #region Secondary
            LanguageAPI.Add(prefix + "SECONDARY_GUN_NAME", "Handgun");
            LanguageAPI.Add(prefix + "SECONDARY_GUN_DESCRIPTION", Helpers.agilePrefix + $"Fire a handgun for <style=cIsDamage>{100f * StaticValues.gunDamageCoefficient}% damage</style>.");
            #endregion

            #region Utility
            LanguageAPI.Add(prefix + "UTILITY_ROLL_NAME", "Roll");
            LanguageAPI.Add(prefix + "UTILITY_ROLL_DESCRIPTION", "Roll a short distance, gaining <style=cIsUtility>300 armor</style>. <style=cIsUtility>You cannot be hit during the roll.</style>");
            #endregion

            #region Special
            LanguageAPI.Add(prefix + "SPECIAL_BOMB_NAME", "Bomb");
            LanguageAPI.Add(prefix + "SPECIAL_BOMB_DESCRIPTION", $"Throw a bomb for <style=cIsDamage>{100f * StaticValues.bombDamageCoefficient}% damage</style>.");
            #endregion

            #region Achievements
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_NAME", "Henry: Mastery");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_DESC", "As Henry, beat the game or obliterate on Monsoon.");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_UNLOCKABLE_NAME", "Henry: Mastery");
            #endregion
            #endregion
        }
    }
}