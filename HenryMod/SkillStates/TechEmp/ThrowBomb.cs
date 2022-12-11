using EntityStates;
using RoR2;
using RoR2.Projectile;
using UnityEngine;

namespace TechnoEmperorMod.SkillStates
{
    public class ThrowBomb : GenericProjectileBaseState
    {

        public static float BaseDuration = 0.65f;
        //delay here for example and to match animation
        //ordinarily I recommend not having a delay before projectiles. makes the move feel sluggish
        public static float BaseDelayDuration = 0.35f;
        public int bombIndex = 0;
        public static float DamageCoefficient = Modules.StaticValues.bombDamageCoefficient;
        public bool firedAllProjectile = false;

        public override void OnEnter()
        {
            base.projectilePrefab = Modules.Projectiles.bombPrefab;
            //base.effectPrefab = Modules.Assets.SomeMuzzleEffect;
            //targetmuzzle = "muzzleThrow"

            base.attackSoundString = "HenryBombThrow";

            base.baseDuration = BaseDuration;
            //base.baseDelayBeforeFiringProjectile = BaseDelayDuration;

            base.damageCoefficient = DamageCoefficient;
            //proc coefficient is set on the components of the projectile prefab
            base.force = 80f;

            //base.projectilePitchBonus = 0;
            //base.minSpread = 0;
            //base.maxSpread = 0;

            base.recoilAmplitude = 0.1f;
            base.bloom = 10;

            base.OnEnter();
        }

        public override void FixedUpdate()
        {
            this.fixedAge += Time.fixedDeltaTime;
            this.stopwatch += Time.fixedDeltaTime;
            if (this.stopwatch >= this.delayBeforeFiringProjectile && !this.firedProjectile || this.stopwatch >= this.delayBeforeFiringProjectile * 10f && !this.firedAllProjectile)
            {
                this.FireProjectile();
                this.DoFireEffects();
                this.stopwatch = 0;
                this.firedProjectile = true;
                bombIndex++;
            }
            if (bombIndex > 3)
                this.firedAllProjectile = true;
            if (this.stopwatch >= this.duration && base.isAuthority)
            {
                this.outer.SetNextStateToMain();
                return;
            }
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.Skill;
        }

        public override void PlayAnimation(float duration)
        {

            if (base.GetModelAnimator())
            {
                base.PlayAnimation("Gesture, Override", "ThrowBomb", "ThrowBomb.playbackRate", this.duration);
            }
        }
    }
}