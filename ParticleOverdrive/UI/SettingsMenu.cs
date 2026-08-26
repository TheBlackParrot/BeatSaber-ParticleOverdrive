using ParticleOverdrive.Configuration;
using JetBrains.Annotations;
using ParticleOverdrive.Controllers;

namespace ParticleOverdrive.UI;

[UsedImplicitly]
public class SettingsMenu
{
    private static ParticleConfig config => ParticleConfig.Instance;

    public bool CameraGrain
    {
        get => config.CameraGrain;
        set
        {
            config.CameraGrain = value;
            CameraNoiseController.MenuInstance?.SetCameraNoiseActive(value);
        }
    }

    public bool DustParticlesMenu
    {
        get => config.DustParticlesInMenu;
        set
        {
            config.DustParticlesInMenu = value;
            DustParticleController.MenuInstance?.Initialize();
        }
    }

    public bool DustParticlesGame
    {
        get => config.DustParticlesInGame;
        set => config.DustParticlesInGame = value;
    }

    public float SlashParticleMultiplier
    {
        get => config.SlashParticleMultiplier;
        set => config.SlashParticleMultiplier = value;
    }
    
    public float SlashParticleLifetimeMultiplier
    {
        get => config.SlashParticleLifetimeMultiplier;
        set => config.SlashParticleLifetimeMultiplier = value;
    }

    public float SlashParticleSizeMultiplier
    {
        get => config.SlashParticleSizeMultiplier;
        set => config.SlashParticleSizeMultiplier = value;
    }
    
    public float ExplosionParticleMultiplier
    {
        get => config.ExplosionParticleMultiplier;
        set => config.ExplosionParticleMultiplier = value;
    }
    
    public float ExplosionParticleLifetimeMultiplier
    {
        get => config.ExplosionParticleLifetimeMultiplier;
        set => config.ExplosionParticleLifetimeMultiplier = value;
    }

    public float ExplosionParticleSizeMultiplier
    {
        get => config.ExplosionParticleSizeMultiplier;
        set => config.ExplosionParticleSizeMultiplier = value;
    }
    
    public bool RainbowParticles
    {
        get => config.RainbowParticles;
        set => config.RainbowParticles = value;
    }
    
    public bool NoteCoreParticles
    {
        get => config.NoteCoreParticles;
        set => config.NoteCoreParticles = value;
    }
    
    public float ClashParticleMultiplier
    {
        get => config.ClashParticleMultiplier;
        set => config.ClashParticleMultiplier = value;
    }
    
    public float ClashParticleLifetimeMultiplier
    {
        get => config.ClashParticleLifetimeMultiplier;
        set => config.ClashParticleLifetimeMultiplier = value;
    }
    
    public float ClashParticleSizeMultiplier
    {
        get => config.ClashParticleSizeMultiplier;
        set => config.ClashParticleSizeMultiplier = value;
    }
    
    public bool ClashGlow
    {
        get => config.ClashGlow;
        set => config.ClashGlow = value;
    }
    
    public float ObstacleParticleMultiplier
    {
        get => config.ObstacleParticleMultiplier;
        set => config.ObstacleParticleMultiplier = value;
    }
    
    public float ObstacleParticleLifetimeMultiplier
    {
        get => config.ObstacleParticleLifetimeMultiplier;
        set => config.ObstacleParticleLifetimeMultiplier = value;
    }
    
    public float ObstacleParticleSizeMultiplier
    {
        get => config.ObstacleParticleSizeMultiplier;
        set => config.ObstacleParticleSizeMultiplier = value;
    }

    public string MultiplierDisplay(float multiplier) => $"{multiplier * 100f}%";
}