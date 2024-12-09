using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;

namespace Maple.AzureValley.Metadata
{
    public class AzureValleyEnvironment(AzureValleyMetadata metadata)
    {
        public AzureValleyMetadata Metadata { get; } = metadata;
        public ILogger Logger => Metadata.Logger;
        public GameData.Ptr_GameData Ptr_GameData { get; } = metadata.GameData.M_INSTANCE;
        public GameState.Ptr_GameState Ptr_GameState { get; } = metadata.GameState.INSTANCE;

        public void WaitInitGameData()
        {
            SpinWait.SpinUntil(() => this.Ptr_GameData.IS_LOADING == false && this.Ptr_GameData.IS_INITIALIZED);
        }
 
        public bool IsLoadSaveData()
        {
            return Ptr_GameState.Valid();
        }
    }
}
