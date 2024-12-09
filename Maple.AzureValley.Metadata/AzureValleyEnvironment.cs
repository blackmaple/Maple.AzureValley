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
        public PlayerData.Ptr_PlayerData Ptr_PlayerData => Ptr_GameState.GET_LOCAL_HOST_PLAYER();

        public LocalPlayerController.Ptr_LocalPlayerController Ptr_LocalPlayerController => Metadata.PlayersManager.INSTANCE.GET_LOCAL_PLAYER();
        public PlayerInventory.Ptr_PlayerInventory Ptr_PlayerInventory => Ptr_LocalPlayerController.PLAYER_INVENTORY;
       // public PlayerInventory.Ptr_PlayerInventory PLAYER => Ptr_PlayerInventory.PLAYER;

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
