using IPA;
using IPA.Config.Stores;
using ParticleOverdrive.Installers;
using SiraUtil.Zenject;
using IPA.Loader;
using JetBrains.Annotations;
using ParticleOverdrive.Configuration;
using IPALogger = IPA.Logging.Logger;
using IPAConfig = IPA.Config.Config;

namespace ParticleOverdrive;

[Plugin(RuntimeOptions.SingleStartInit), NoEnableDisable]
[UsedImplicitly]
public class Plugin
{
    // ReSharper disable once UnusedAutoPropertyAccessor.Global
    internal static IPALogger Log { get; private set; } = null!;
    
    [Init]
    public Plugin(Zenjector zenjector, PluginMetadata metadata, IPALogger logger, IPAConfig ipaConfig)
    {
        Log = logger;
        zenjector.UseLogger(logger);
        
        ParticleConfig c = ipaConfig.Generated<ParticleConfig>();
        ParticleConfig.Instance = c;
        
        zenjector.Install<MenuInstaller>(Location.Menu);
        zenjector.Install<PlayerInstaller>(Location.Player);
        zenjector.Install<WorldParticlesInstaller>(Location.Menu | Location.Player);
        
        logger.Info($"{metadata.Name} {metadata.HVersion} initialized.");
    }
}