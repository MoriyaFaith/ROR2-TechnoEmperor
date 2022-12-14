using System;
using RoR2;
using UnityEngine;
using UnityEngine.Networking;
using EntityStates.Engi.EngiBubbleShield;
using EntityStates;

namespace TechnoEmperorMod.SkillStates
{
	public class ShieldDeploy : BaseSkillState
	{
		public override void OnEnter()
		{
			base.OnEnter();
			Util.PlaySound(Deployed.initialSoundString, base.gameObject);
		}

		public override void FixedUpdate()
		{
			base.FixedUpdate();
			if (!this.hasDeployed && base.fixedAge >= Deployed.delayToDeploy)
			{
				ChildLocator component = base.GetComponent<ChildLocator>();
				if (component)
				{
					component.FindChild(Deployed.childLocatorString).gameObject.SetActive(true);
					this.hasDeployed = true;
				}
			}
			if (base.fixedAge >= Deployed.lifetime && NetworkServer.active)
			{
				this.outer.SetNextState(new ShieldStop());
			}
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0004B06C File Offset: 0x0004926C
		public override void OnExit()
		{
			base.OnExit();
			EffectManager.SpawnEffect(this.destroyEffectPrefab, new EffectData
			{
				origin = base.transform.position,
				rotation = base.transform.rotation,
				scale = this.destroyEffectRadius
			}, false);
			Util.PlaySound(Deployed.destroySoundString, base.gameObject);
		}

		public static string childLocatorString;
		public static string initialSoundString;
		public static string destroySoundString;
		public static float delayToDeploy;
		public static float lifetime;
		[SerializeField]
		public GameObject destroyEffectPrefab;
		[SerializeField]
		public float destroyEffectRadius;
		private bool hasDeployed;
	}
}
