using System;
using RoR2;
using EntityStates;
using EntityStates.Mage;

namespace TechnoEmperorMod
{
	public class ConquererCharacterMain : GenericCharacterMain
	{
		public override void OnEnter()
		{
			base.OnEnter();
			this.jetpackStateMachine = EntityStateMachine.FindByCustomName(base.gameObject, "Body");
		}

		public override void ProcessJump()
		{
			base.ProcessJump();
			if (this.hasCharacterMotor && this.hasInputBank && base.isAuthority)
			{
				object obj = base.inputBank.jump.down && base.characterMotor.velocity.y < 0f && !base.characterMotor.isGrounded;
				bool flag = this.jetpackStateMachine.state.GetType() == typeof(JetpackOn);
				bool obj2 = (bool)obj;
				if (obj2 != false && !flag)
				{
					this.jetpackStateMachine.SetNextState(new JetpackOn());
				}
				if (obj2 == false && flag)
				{
					this.jetpackStateMachine.SetNextState(new Idle());
				}
			}
		}

		public override void OnExit()
		{
			if (base.isAuthority && this.jetpackStateMachine)
			{
				this.jetpackStateMachine.SetNextState(new Idle());
			}
			base.OnExit();
		}

		private EntityStateMachine jetpackStateMachine;
	}
}