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
            var gameEnv = await  this.MonoTaskAsync(p => p.GetAzureValleyEnvironment()).ConfigureAwait(false);
            await this.UITaskAsync(static (p, args) => args.FirstLoadResource(), gameEnv).ConfigureAwait(false);

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

        public sealed override async ValueTask<GameSessionInfoDTO> LoadResourceAsync()
        {
            var gameEnv = await this.GetAzureValleyEnvironmentThrowIfNotLoaded().ConfigureAwait(false);

            //MonoDefaultLogger.Default.LogInformation("LoadAutoUnlocks");
            //await this.MonoTaskAsync(static (p, args) => args.LoadAutoUnlocks(), gameEnv);

            MonoDefaultLogger.Default.LogInformation("LoadBuffs");
            await this.MonoTaskAsync(static (p, args) => args.LoadBuffs(), gameEnv);

            //MonoDefaultLogger.Default.LogInformation("LoadConstants");
            //await this.MonoTaskAsync(static (p, args) => args.LoadConstants(), gameEnv);

            //MonoDefaultLogger.Default.LogInformation("LoadConstructibles");
            //await this.MonoTaskAsync(static (p, args) => args.LoadConstructibles(), gameEnv);

            MonoDefaultLogger.Default.LogInformation("LoadFoods");
            await this.MonoTaskAsync(static (p, args) => args.LoadFoods(), gameEnv);

            //MonoDefaultLogger.Default.LogInformation("LoadHints");
            //await this.MonoTaskAsync(static (p, args) => args.LoadHints(), gameEnv);

            MonoDefaultLogger.Default.LogInformation("LoadInventoryItems");
            await this.MonoTaskAsync(static (p, args) => args.LoadInventoryItems(), gameEnv);

            MonoDefaultLogger.Default.LogInformation("LoadPerks");
            await this.MonoTaskAsync(static (p, args) => args.LoadPerks(), gameEnv);

            MonoDefaultLogger.Default.LogInformation("LoadRecipes");
            await this.MonoTaskAsync(static (p, args) => args.LoadRecipes(), gameEnv);

            MonoDefaultLogger.Default.LogInformation("LoadTokens");
            await this.MonoTaskAsync(static (p, args) => args.LoadTokens(), gameEnv);

            MonoDefaultLogger.Default.LogInformation("LoadWorldItems");
            await this.MonoTaskAsync(static (p, args) => args.LoadWorldItems(), gameEnv);
            //await foreach (var task in Task.WhenEach(task1, task2, task3, task4, task5, task6, task7, task8, task9, taskA).ConfigureAwait(false))
            //{
            //    await task.ConfigureAwait(false);
            //}
            return await base.LoadResourceAsync().ConfigureAwait(false);
        }



    }
}
