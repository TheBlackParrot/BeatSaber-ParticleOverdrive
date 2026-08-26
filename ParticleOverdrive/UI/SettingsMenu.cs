using ParticleOverdrive.Configuration;
using System.Collections.Generic;
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
    
    [UsedImplicitly] private readonly List<object> ParticleMultiplierChoicesList =
    [
        0f,
        1f,
        1.1f,
        1.2f,
        1.3f,
        1.4f,
        1.5f,
        1.6f,
        1.7f,
        1.8f,
        1.9f,
        2f,
        2.25f,
        2.5f,
        2.75f,
        3f,
        3.25f,
        3.5f,
        3.75f,
        4f,
        4.25f,
        4.5f,
        4.75f,
        5f,
        5.5f,
        6f,
        6.5f,
        7f,
        7.5f,
        8f,
        8.5f,
        9f,
        9.5f,
        10f,
        11f,
        12f,
        13f,
        14f,
        15f,
        16f,
        17f,
        18f,
        19f,
        20f,
        22.5f,
        25f,
        27.5f,
        30f,
        32.5f,
        35f,
        37.5f,
        40f,
        42.5f,
        45f,
        47.5f,
        50f,
        55f,
        60f,
        65f,
        70f,
        75f,
        80f,
        85f,
        90f,
        100f,
        110f,
        120f,
        130f,
        140f,
        150f,
        160f,
        170f,
        180f,
        190f,
        200f
    ];
        
    [UsedImplicitly] private readonly List<object> LifetimeValues =
    [
        0f,
        0.1f,
        0.2f,
        0.3f,
        0.4f,
        0.5f,
        0.6f,
        0.7f,
        0.8f,
        0.9f,
        1f,
        1.1f,
        1.2f,
        1.3f,
        1.4f,
        1.5f,
        1.6f,
        1.7f,
        1.8f,
        1.9f,
        2f,
        2.25f,
        2.5f,
        2.75f,
        3f,
        3.25f,
        3.5f,
        3.75f,
        4f,
        4.25f,
        4.5f,
        4.75f,
        5f,
        7.5f,
        10f,
        15f,
        20f,
        30f,
        40f,
        50f,
        75f,
        100f
    ];
}