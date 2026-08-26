using JetBrains.Annotations;
using ParticleOverdrive.Controllers;
using Zenject;

namespace ParticleOverdrive.Installers;

[UsedImplicitly]
internal class WorldParticlesInstaller : Installer
{
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<CameraNoiseController>().AsSingle();
        Container.BindInterfacesAndSelfTo<DustParticleController>().AsSingle();
    }
}