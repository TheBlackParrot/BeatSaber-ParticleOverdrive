using JetBrains.Annotations;
using ParticleOverdrive.UI;
using Zenject;

namespace ParticleOverdrive.Installers;

[UsedImplicitly]
internal class MenuInstaller : Installer
{
    public override void InstallBindings()
    {
        Container.Bind<SettingsMenu>().AsSingle();
        Container.BindInterfacesTo<SettingsMenuManager>().AsSingle();
    }
}