using TechnoEmperorMod.SkillStates;
using TechnoEmperorMod.SkillStates.BaseStates;
using System.Collections.Generic;
using System;

namespace TechnoEmperorMod.Modules
{
    public static class States
    {
        internal static void RegisterStates()
        {
            Modules.Content.AddEntityState(typeof(BaseMeleeAttack));

            #region Lock On
            Modules.Content.AddEntityState(typeof(BaseLockOnMissileState));
            Modules.Content.AddEntityState(typeof(LockOn));
            Modules.Content.AddEntityState(typeof(FireMissiles));
            Modules.Content.AddEntityState(typeof(Finish));
            Modules.Content.AddEntityState(typeof(Startup));
            #endregion
            #region
            Modules.Content.AddEntityState(typeof(ShieldDeploy));
            Modules.Content.AddEntityState(typeof(ShieldStop));
            #endregion

            Modules.Content.AddEntityState(typeof(Shoot));
            Modules.Content.AddEntityState(typeof(Roll));
            Modules.Content.AddEntityState(typeof(ThrowBomb));
        }
    }
}