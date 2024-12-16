using Maple.AzureValley.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Maple.MonoGameAssistant.Windows.UITask;
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

        protected sealed override UnityEngineContext? LoadUnityEngineContext()
        {
            return new UnityEngineContext_AzureValley(this.RuntimeContext, this.Logger);
        }
        protected sealed override async ValueTask LoadGameDataAsync()
        {
            var gameEnv = await this.MonoTaskAsync(p => p.GetAzureValleyEnvironment()).ConfigureAwait(false);
            //  await this.UITaskAsync(static (p, args) => args.LoadInventoryItems(), gameEnv).ConfigureAwait(false);

            var task0 = this.MonoTaskAsync(static (p, args) => args.LoadAutoUnlocks(), gameEnv);
            var task1 = this.MonoTaskAsync(static (p, args) => args.LoadBuffs(), gameEnv);
            var task2 = this.MonoTaskAsync(static (p, args) => args.LoadConstants(), gameEnv);
            var task3 = this.MonoTaskAsync(static (p, args) => args.LoadConstructibles(), gameEnv);
            var task4 = this.MonoTaskAsync(static (p, args) => args.LoadFoods(), gameEnv);
            var task5 = this.MonoTaskAsync(static (p, args) => args.LoadHints(), gameEnv);

            var task6 = this.UITaskAsync(static (p, args) => args.LoadInventoryItems(), gameEnv).AsTask();

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
            var items = await this.MonoTaskAsync(static (p, args) => args.GetGameInventoryDisplays(), gameEnv).ConfigureAwait(false);
            foreach (var item in items)
            {
                if (this.GameSettings.TryGetGameResourceUrl(item.DisplayCategory!, $"{item.ObjectId}.png", out var url))
                {
                    item.DisplayImage = url;
                }
            }
            return items;
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var gameEnv = await this.GetAzureValleyEnvironmentThrowIfNotLoaded().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.GetGameInventoryInfo(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var gameEnv = await this.GetAzureValleyEnvironmentThrowIfNotLoaded().ConfigureAwait(false);
            return await this.UITaskAsync(static (p, args) => args.gameEnv.UpdateGameInventoryInfo(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }

        public sealed override async ValueTask<GameSessionInfoDTO> LoadResourceAsync()
        {
            if (this.UnityEngineContext is not null)
            {

                var gameEnv = await this.GetAzureValleyEnvironmentThrowIfNotLoaded().ConfigureAwait(false);
                //    await this.UITaskAsync((p, args) =>args.SetAllGameInventoryInfo(),gameEnv).ConfigureAwait(false);

                var imageDatas = await this.UITaskAsync(static (p, args) => LoadResource(args.gameEnv, args.UnityEngineContext).ToArray(), (gameEnv, this.UnityEngineContext)).ConfigureAwait(false);
                foreach (var itemData in imageDatas)
                {
                    this.GameSettings.WriteImageFile(itemData.ImageData.AsReadOnlySpan(), itemData.Category, $"{itemData.Name}.png");
                }
            }
            return await base.LoadResourceAsync().ConfigureAwait(false);
        }

        static IEnumerable<UnitySpriteImageData> LoadResource(AzureValleyEnvironment @this, UnityEngineContext unityEngineContext)
        {
            foreach (var itemType in @this.Ptr_GameData.INVENTORY_ITEMS_DB.DATA_ARRAY)
            {
                var ptr_item = @this.Metadata.InventoryItem.GCNew<InventoryItem.Ptr_InventoryItem>(false);
                ptr_item.Target.CTOR_01(itemType, nint.Zero);
                var ptr_sprite = (Sprite.Ptr_Sprite)InventoryItemsExtensions.Ptr_InventoryItemsExtensions.GET_SPRITE_01(ptr_item);
                var ptrArray = unityEngineContext.ReadSprite2Png(ptr_sprite, 2);
                yield return new UnitySpriteImageData()
                {
                    Category = GameItemType.InventoryItems.ToString(),
                    Name = itemType.GET_NAME().ToString(),
                    ImageData = ptrArray
                };

                //if (false == ptr_sprite.Valid())
                //{
                //    continue;
                //}

                //var ptr_texture = ptr_sprite.GET_TEXTURE();
                //if (false == ptr_texture.Valid())
                //{
                //    continue;
                //}

                //@this.Logger.Info("2");

                //var clone_texture = unityEngineContext.Texture2D.GCNew<Texture2D.Ptr_Texture2D>(false);
                //ptr_sprite.GET_TEXTURE_RECT_INJECTED(out var ref_Rect);
                //@this.Logger.LogInformation("3:{x}|{y}|{h}|{w}", ref_Rect.m_XMin, ref_Rect.m_YMin, ref_Rect.m_Height, ref_Rect.m_Width);

                //CopyToTexture2D2(@this, ptr_texture, clone_texture, in ref_Rect);
                //var ptrArray = Maple.MonoGameAssistant.UnityCore.UnityEngine.ImageConversion.Ptr_ImageConversion.ENCODE_TO_PNG(clone_texture);
                //yield return new UnitySpriteImageData()
                //{
                //    Category = GameItemType.InventoryItems.ToString(),
                //    Name = itemType.GET_NAME().ToString(),
                //    ImageData = ptrArray
                //};

            }


        }

        //private static void CopyToTexture2D2(AzureValleyEnvironment @this, Texture2D.Ptr_Texture2D pSrc, Texture2D.Ptr_Texture2D pDest, in Rect.Ref_Rect ref_Rect)
        //{
        //    int wIDTH = pSrc.GET_WIDTH();
        //    int hEIGHT = pSrc.GET_HEIGHT();
        //    @this.Logger.LogInformation("CopyToTexture2D2:{w}|{h}", wIDTH, hEIGHT);

        //    RenderTexture.Ptr_RenderTexture ptr_RenderTexture = Maple.MonoGameAssistant.UnityCore.UnityEngine.RenderTexture.Ptr_RenderTexture.GET_TEMPORARY_0A(wIDTH, hEIGHT, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
        //    @this.Logger.Info("CopyToTexture2D2:a0");

        //    Maple.MonoGameAssistant.UnityCore.UnityEngine.Graphics.Ptr_Graphics.BLIT2((nint)pSrc, (nint)ptr_RenderTexture);
        //    @this.Logger.Info("CopyToTexture2D2:a1");

        //    nint aCTIVE = Maple.MonoGameAssistant.UnityCore.UnityEngine.RenderTexture.Ptr_RenderTexture.GET_ACTIVE();
        //    @this.Logger.Info("CopyToTexture2D2:a2");

        //    Maple.MonoGameAssistant.UnityCore.UnityEngine.RenderTexture.Ptr_RenderTexture.SET_ACTIVE((nint)ptr_RenderTexture);
        //    @this.Logger.Info("CopyToTexture2D2:a3");
        //    int width = (int)ref_Rect.m_Width;
        //    int height = (int)ref_Rect.m_Height;
        //    float yMin = (float)hEIGHT - (ref_Rect.m_YMin + ref_Rect.m_Height);
        //    pDest.CTOR_08(width, height);
        //    Rect.Ref_Rect source = new Rect.Ref_Rect
        //    {
        //        m_XMin = ref_Rect.m_XMin,
        //        m_YMin = yMin,
        //        m_Width = ref_Rect.m_Width,
        //        m_Height = ref_Rect.m_Height
        //    };
        //    @this.Logger.Info("CopyToTexture2D2:c");
        //    pDest.READ_PIXELS_IMPL_INJECTED(in source, 0, 0, recalculateMipMaps: true);
        //    pDest.APPLY_02();
        //    @this.Logger.Info("CopyToTexture2D2:d");
        //    Maple.MonoGameAssistant.UnityCore.UnityEngine.RenderTexture.Ptr_RenderTexture.SET_ACTIVE(aCTIVE);
        //    @this.Logger.Info("CopyToTexture2D2:e");
        //    Maple.MonoGameAssistant.UnityCore.UnityEngine.RenderTexture.Ptr_RenderTexture.RELEASE_TEMPORARY((nint)ptr_RenderTexture);
        //    @this.Logger.Info("CopyToTexture2D2:f");
        //}

    }
}
