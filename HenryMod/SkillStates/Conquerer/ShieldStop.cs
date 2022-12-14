using System;
using RoR2;
using RoR2.Projectile;
using UnityEngine.Networking;
using EntityStates.Engi.EngiBubbleShield;
using EntityStates;

namespace TechnoEmperorMod.SkillStates
{
	public class ShieldStop : BaseSkillState
	{
		public override void OnEnter()
		{
			base.OnEnter();
			ProjectileController component = base.GetComponent<ProjectileController>();
			this.projectileStickOnImpact = base.GetComponent<ProjectileStickOnImpact>();
			if (NetworkServer.active && component.owner)
			{
				CharacterBody component2 = component.owner.GetComponent<CharacterBody>();
				if (component2)
				{
					CharacterMaster master = component2.master;
					if (master)
					{
						master.AddDeployable(base.GetComponent<Deployable>(), DeployableSlot.EngiBubbleShield);
					}
				}
			}
		}

		public override void FixedUpdate()
		{
			base.FixedUpdate();
			if (this.projectileStickOnImpact.stuck && NetworkServer.active)
			{
				this.SetNextState();
			}
		}

		protected virtual void SetNextState()
		{
			this.outer.SetNextStateToMain();
		}

		private ProjectileStickOnImpact projectileStickOnImpact;
	}
}
