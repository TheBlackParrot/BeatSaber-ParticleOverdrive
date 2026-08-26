using ParticleOverdrive.Configuration;
using SiraUtil.Affinity;
using UnityEngine;

namespace ParticleOverdrive.Patches;

internal class ObstacleSaberSparkleEffectPatch : IAffinity
{
    private static ParticleConfig config => ParticleConfig.Instance;

    [AffinityPatch(typeof(ObstacleSaberSparkleEffect), nameof(ObstacleSaberSparkleEffect.Awake))]
    public void Postfix(ObstacleSaberSparkleEffect __instance)
    {
        ParticleSystem? sparkleParticles = __instance._sparkleParticleSystem;
        ParticleSystem.EmissionModule sparkleEmission = sparkleParticles.emission;
        ParticleSystem.MainModule sparkleMainModule = sparkleParticles.main;

        sparkleEmission.rateOverDistanceMultiplier *= config.ObstacleParticleMultiplier;
        sparkleEmission.rateOverTimeMultiplier *= config.ObstacleParticleMultiplier;
        sparkleMainModule.maxParticles = int.MaxValue;
        sparkleMainModule.startLifetimeMultiplier *= config.ObstacleParticleLifetimeMultiplier;
        sparkleMainModule.startSizeMultiplier *= config.ObstacleParticleSizeMultiplier;
    }
}