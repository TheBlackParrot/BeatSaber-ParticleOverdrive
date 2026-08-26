using ParticleOverdrive.Configuration;
using SiraUtil.Affinity;
using UnityEngine;

namespace ParticleOverdrive.Patches;

public class SaberClashEffectPatch : IAffinity
{
    private static ParticleConfig config => ParticleConfig.Instance;

    [AffinityPatch(typeof(SaberClashEffect), nameof(SaberClashEffect.Start))]
    public void Postfix(SaberClashEffect __instance)
    {
        ParticleSystem.EmissionModule glowEmissionModule = __instance._glowParticleSystem.emission;
        ParticleSystem.EmissionModule sparkleEmissionModule = __instance._sparkleParticleSystem.emission;

        ParticleSystem.MainModule glowMainModule = __instance._glowParticleSystem.main;
        ParticleSystem.MainModule sparkleMainModule = __instance._sparkleParticleSystem.main;

        if (!config.ClashGlow)
        {
            glowMainModule.startLifetimeMultiplier = 0;
        }

        sparkleEmissionModule.rateOverDistanceMultiplier *= config.ClashParticleMultiplier;
        sparkleEmissionModule.rateOverTimeMultiplier *= config.ClashParticleMultiplier;

        glowEmissionModule.rateOverDistanceMultiplier *= config.ClashParticleMultiplier;
        glowEmissionModule.rateOverTimeMultiplier *= config.ClashParticleMultiplier;

        sparkleMainModule.maxParticles = int.MaxValue;
        sparkleMainModule.startLifetimeMultiplier *= config.ClashParticleLifetimeMultiplier;
        sparkleMainModule.startSizeMultiplier *= config.ClashParticleSizeMultiplier;
    }
}