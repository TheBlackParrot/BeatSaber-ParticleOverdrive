using ParticleOverdrive.Configuration;
using System.Collections;
using System.Linq;
using JetBrains.Annotations;
using UnityEngine;
using Zenject;

namespace ParticleOverdrive.Controllers;

[UsedImplicitly]
internal class DustParticleController : IInitializable
{
    private static ParticleConfig config => ParticleConfig.Instance;
    private readonly ICoroutineStarter coroutineStarter;
    private readonly string dustParticlesName;
    
    private DustParticleController(ICoroutineStarter coroutineStarter, [InjectOptional] EnvironmentSceneSetupData? environmentData)
    {
        this.coroutineStarter = coroutineStarter;
        dustParticlesName = environmentData == null ? "DustPS" : environmentData.environmentInfo.serializedName switch
        {
            "BritneyEnvironment" => "DustBritney",
            _ => "DustPS"
        };
    }

    private ParticleSystem? dustPS;

    public void Initialize()
    {
        // only has to be done in a coroutine because of MultiPlayer being like a frame too early...
        coroutineStarter.StartCoroutine(InitializeCoroutine());
    }

    private IEnumerator InitializeCoroutine()
    {
        yield return new WaitUntil(() =>
        {
            dustPS = Object.FindObjectsByType<ParticleSystem>(FindObjectsSortMode.None).FirstOrDefault(p => p.name == dustParticlesName);
            return dustPS != null;
        });
        if (dustPS != null) dustPS.gameObject.SetActive(config.DustParticles);
    }
}