using System;
using EntityStates;
using EntityStates.Engi.EngiMissilePainter;

namespace TechnoEmperorMod.SkillStates
{
	public class Finish : BaseLockOnMissileState
	{
		public override void OnEnter()
		{
			base.OnEnter();
			if (base.isAuthority)
			{
				this.outer.SetNextState(new Idle());
			}
		}
	}
}