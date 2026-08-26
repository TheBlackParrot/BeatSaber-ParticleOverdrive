using System.Runtime.CompilerServices;
using IPA.Config.Stores;
using JetBrains.Annotations;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]

namespace ParticleOverdrive.Configuration;

[UsedImplicitly]
internal class ParticleConfig
{
    internal static ParticleConfig Instance { get; set; } = null!;

    public virtual bool DustParticlesInMenu { get; set; } = true;
    public virtual bool DustParticlesInGame { get; set; } = true;
    public virtual bool CameraGrain { get; set; } = true;

    public virtual float SlashParticleMultiplier { get; set; } = 1f;
    public virtual float SlashParticleLifetimeMultiplier { get; set; } = 1f;
    public virtual float SlashParticleSizeMultiplier { get; set; } = 1f;
    public virtual float ExplosionParticleMultiplier { get; set; } = 1f;
    public virtual float ExplosionParticleLifetimeMultiplier { get; set; } = 1f;
    public virtual float ExplosionParticleSizeMultiplier { get; set; } = 1f;
    public virtual bool RainbowParticles { get; set; }
    public virtual bool NoteCoreParticles { get; set; } = true;

    public virtual float ClashParticleMultiplier { get; set; } = 1f;
    public virtual float ClashParticleLifetimeMultiplier { get; set; } = 1f;
    public virtual float ClashParticleSizeMultiplier { get; set; } = 1f;
    public virtual bool ClashGlow { get; set; } = true;

    public virtual float ObstacleParticleMultiplier { get; set; } = 1f;
    public virtual float ObstacleParticleLifetimeMultiplier { get; set; } = 1f;
    public virtual float ObstacleParticleSizeMultiplier { get; set; } = 1f;
}