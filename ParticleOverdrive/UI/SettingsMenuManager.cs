using BeatSaberMarkupLanguage.Settings;
using System;
using JetBrains.Annotations;
using Zenject;

namespace ParticleOverdrive.UI;

[UsedImplicitly]
internal class SettingsMenuManager : IInitializable, IDisposable
{
    private readonly SettingsMenu settingsMenu;
    private readonly BSMLSettings bsmlSettings;

    private SettingsMenuManager(SettingsMenu settingsMenu, BSMLSettings bsmlSettings)
    {
        this.settingsMenu = settingsMenu;
        this.bsmlSettings = bsmlSettings;
    }

    public void Initialize()
    {
        bsmlSettings.AddSettingsMenu("Particle Overdrive", "ParticleOverdrive.UI.SettingsMenu.bsml", settingsMenu);
    }

    public void Dispose()
    {
        bsmlSettings.RemoveSettingsMenu(settingsMenu);
    }
}