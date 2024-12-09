using Maple.AzureValley.Metadata;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameContext;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.HotKey;
using Maple.MonoGameAssistant.Logger;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.UITask;
using Microsoft.Extensions.Logging;

namespace Maple.AzureValley.GameService
{

    internal sealed partial class AzureValleyGameService(ILogger<AzureValleyGameService> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
        : GameContextService<AzureValleyMetadata>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)

    {
        protected sealed override AzureValleyMetadata LoadGameContext()
        {
            //    return AzureValleyMetadata.LoadGameContext(RuntimeContext, MonoGameAssistant.MonoCollectorDataV2.EnumMonoCollectorTypeVersion.APP, Logger);

            return new AzureValleyMetadata(this.RuntimeContext, MonoGameAssistant.MonoCollectorDataV2.EnumMonoCollectorTypeVersion.APP, this.Logger, "202412071650");
        }

        protected sealed override async ValueTask LoadGameDataAsync()
        {
            var gameEnv = await this.MonoTaskAsync(p => p.GetAzureValleyEnvironment()).ConfigureAwait(false);
            await this.UITaskAsync(static (p, args) => args.FirstLoadResource(), gameEnv).ConfigureAwait(false);

            var task0 = this.MonoTaskAsync(static (p, args) => args.LoadAutoUnlocks(), gameEnv);
            var task1 = this.MonoTaskAsync(static (p, args) => args.LoadBuffs(), gameEnv);
            var task2 = this.MonoTaskAsync(static (p, args) => args.LoadConstants(), gameEnv);
            var task3 = this.MonoTaskAsync(static (p, args) => args.LoadConstructibles(), gameEnv);
            var task4 = this.MonoTaskAsync(static (p, args) => args.LoadFoods(), gameEnv);
            var task5 = this.MonoTaskAsync(static (p, args) => args.LoadHints(), gameEnv);
            var task6 = this.MonoTaskAsync(static (p, args) => args.LoadInventoryItems(), gameEnv);
            var task7 = this.MonoTaskAsync(static (p, args) => args.LoadPerks(), gameEnv);
            var task8 = this.MonoTaskAsync(static (p, args) => args.LoadRecipes(), gameEnv);
            var task9 = this.MonoTaskAsync(static (p, args) => args.LoadTokens(), gameEnv);
            var taskA = this.MonoTaskAsync(static (p, args) => args.LoadWorldItems(), gameEnv);
            await foreach (var task in Task.WhenEach(task0, task1, task2, task3, task4, task5, task6, task7, task8, task9, taskA).ConfigureAwait(false))
            {
                await task.ConfigureAwait(false);
            }

        }

        private Task<AzureValleyEnvironment> GetAzureValleyEnvironment()
        {
            return this.MonoTaskAsync(p => p.GetAzureValleyEnvironment());
        }
        private async Task<AzureValleyEnvironment> GetAzureValleyEnvironmentThrowIfNotLoaded()
        {
            var gameEnv = await this.MonoTaskAsync(p => p.GetAzureValleyEnvironment()).ConfigureAwait(false);
            return gameEnv.IsLoadSaveData() ? gameEnv : GameException.ThrowIfNotLoaded<AzureValleyEnvironment>();

        }

        public sealed override async ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            var gameEnv = await this.GetAzureValleyEnvironment().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.GetGameInventoryDisplays(), gameEnv).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var gameEnv = await this.GetAzureValleyEnvironmentThrowIfNotLoaded().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.GetGameInventoryInfo(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var gameEnv = await this.GetAzureValleyEnvironmentThrowIfNotLoaded().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.UpdateGameInventoryInfo(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }


    }
}
