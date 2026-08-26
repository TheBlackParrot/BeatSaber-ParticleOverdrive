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
    
    internal static DustParticleController? MenuInstance { get; private set; }
    private readonly bool _isMenu;
    
    private DustParticleController(ICoroutineStarter coroutineStarter, [InjectOptional] EnvironmentSceneSetupData? environmentData)
    {
        MenuInstance ??= this;
        if (environmentData == null)
        {
            _isMenu = true;
        }
        
        this.coroutineStarter = coroutineStarter;
        dustParticlesName = environmentData?.environmentInfo.serializedName switch
        {
            "BritneyEnvironment" => "DustBritney",
            _ => "DustPS"
        };
    }

    private ParticleSystem? dustPS;

    public void Initialize()
    {
        Plugin.Log.Info(dustParticlesName);
        // only has to be done in a coroutine because of MultiPlayer being like a frame too early...
        coroutineStarter.StartCoroutine(InitializeCoroutine());
    }

    private IEnumerator InitializeCoroutine()
    {
        yield return new WaitUntil(() =>
        {
            dustPS = Object.FindObjectsByType<ParticleSystem>(FindObjectsInactive.Include, FindObjectsSortMode.None)
                .FirstOrDefault(p => p.name == dustParticlesName);
            return dustPS != null;
        });
        if (dustPS != null) dustPS.gameObject.SetActive(_isMenu ? config.DustParticlesInMenu : config.DustParticlesInGame);
    }
}