using UnityEngine;
using Zenject;

namespace CampfireSurvivors
{
    [CreateAssetMenu(fileName = "GameSettingsInstaller", menuName = "Installers/GameSettingsInstaller")]
    public class GameSettingsInstaller : ScriptableObjectInstaller<GameSettingsInstaller>
    {
        public override void InstallBindings()
        {
        }
    }
}
