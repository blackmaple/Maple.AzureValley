using Maple.AzureValley.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameContext;
using Maple.MonoGameAssistant.HotKey;
using Maple.MonoGameAssistant.Model;
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


    }
}
