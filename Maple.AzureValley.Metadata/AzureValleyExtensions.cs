using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;

namespace Maple.AzureValley.Metadata
{
    public static class AzureValleyExtensions
    {
        public static List<GameInventoryDisplayDTO> CacheAutoUnlocks { get; } = new List<GameInventoryDisplayDTO>(1024);
        public static List<GameInventoryDisplayDTO> CacheBuffs { get; } = new List<GameInventoryDisplayDTO>(1024);
        public static List<GameInventoryDisplayDTO> CacheConstants { get; } = new List<GameInventoryDisplayDTO>(1024);
        public static List<GameInventoryDisplayDTO> CacheConstructibles { get; } = new List<GameInventoryDisplayDTO>(1024);
        public static List<GameInventoryDisplayDTO> CacheFoods { get; } = new List<GameInventoryDisplayDTO>(1024);
        public static List<GameInventoryDisplayDTO> CacheHints { get; } = new List<GameInventoryDisplayDTO>(1024);
        public static List<GameInventoryDisplayDTO> CacheInventoryItems { get; } = new List<GameInventoryDisplayDTO>(1024);
        public static List<GameInventoryDisplayDTO> CachePerks { get; } = new List<GameInventoryDisplayDTO>(1024);
        public static List<GameInventoryDisplayDTO> CacheRecipes { get; } = new List<GameInventoryDisplayDTO>(1024);
        public static List<GameInventoryDisplayDTO> CacheTokens { get; } = new List<GameInventoryDisplayDTO>(1024);
        public static List<GameInventoryDisplayDTO> CacheWorldItems { get; } = new List<GameInventoryDisplayDTO>(1024);


        public static AzureValleyEnvironment GetAzureValleyEnvironment(this AzureValleyMetadata @this)
            => new(@this);

        public static void WaitLoadResource(this AzureValleyEnvironment @this)
        {
            @this.WaitInitGameData();
            SpinWait.SpinUntil(() => @this.Ptr_GameData.AUTO_UNLOCKS_DB.Valid());
            SpinWait.SpinUntil(() => @this.Ptr_GameData.BUFFS_DB.Valid());
            SpinWait.SpinUntil(() => @this.Ptr_GameData.CONSTANTS_DB.Valid());
            SpinWait.SpinUntil(() => @this.Ptr_GameData.CONSTRUCTIBLES_DB.Valid());
            SpinWait.SpinUntil(() => @this.Ptr_GameData.FOODS_DB.Valid());
            SpinWait.SpinUntil(() => @this.Ptr_GameData.HINTS_DB.Valid());
            SpinWait.SpinUntil(() => @this.Ptr_GameData.INVENTORY_ITEMS_DB.Valid());
            SpinWait.SpinUntil(() => @this.Ptr_GameData.PERKS_DB.Valid());
            SpinWait.SpinUntil(() => @this.Ptr_GameData.RECIPES_DB.Valid());
            SpinWait.SpinUntil(() => @this.Ptr_GameData.TOKENS_DB.Valid());
            SpinWait.SpinUntil(() => @this.Ptr_GameData.WORLD_ITEMS_DB.Valid());

        }


        public static void FirstLoadResource(this AzureValleyEnvironment @this)
        {
           
            @this.FirstEnumResource<AutoUnlocks.Ptr_AutoUnlocks, AutoUnlocksData.Ptr_AutoUnlocksData>(@this.Ptr_GameData.AUTO_UNLOCKS_DB);
            @this.FirstEnumResource<Buffs.Ptr_Buffs, BuffsData.Ptr_BuffsData>(@this.Ptr_GameData.BUFFS_DB);
            @this.FirstEnumResource<Constants.Ptr_Constants, ConstantsData.Ptr_ConstantsData>(@this.Ptr_GameData.CONSTANTS_DB);
            @this.FirstEnumResource<Constructibles.Ptr_Constructibles, ConstructiblesData.Ptr_ConstructiblesData>(@this.Ptr_GameData.CONSTRUCTIBLES_DB);
           
            @this.FirstEnumResource<Foods.Ptr_Foods, FoodsData.Ptr_FoodsData>(@this.Ptr_GameData.FOODS_DB);
           
            @this.FirstEnumResource<Hints.Ptr_Hints, HintsData.Ptr_HintsData>(@this.Ptr_GameData.HINTS_DB);
            @this.FirstEnumResource<InventoryItems.Ptr_InventoryItems, InventoryItemsData.Ptr_InventoryItemsData>(@this.Ptr_GameData.INVENTORY_ITEMS_DB);
            @this.FirstEnumResource<Perks.Ptr_Perks, PerksData.Ptr_PerksData>(@this.Ptr_GameData.PERKS_DB);
            @this.FirstEnumResource<Recipes.Ptr_Recipes, RecipesData.Ptr_RecipesData>(@this.Ptr_GameData.RECIPES_DB);
            @this.FirstEnumResource<Tokens.Ptr_Tokens, TokensData.Ptr_TokensData>(@this.Ptr_GameData.TOKENS_DB);
            @this.FirstEnumResource<WorldItems.Ptr_WorldItems, WorldItemsData.Ptr_WorldItemsData>(@this.Ptr_GameData.WORLD_ITEMS_DB);

        }

        public static void LoadAutoUnlocks(this AzureValleyEnvironment @this)
        {
            var items = @this.EnumResource<AutoUnlocks.Ptr_AutoUnlocks, AutoUnlocksData.Ptr_AutoUnlocksData>(@this.Ptr_GameData.AUTO_UNLOCKS_DB);
            CacheAutoUnlocks.AddRange(items);
            @this.Logger.LogInformation("LoadAutoUnlocks:{size}", CacheAutoUnlocks.Count);
        }
        public static void LoadBuffs(this AzureValleyEnvironment @this)
        {
            var items = @this.EnumResource<Buffs.Ptr_Buffs, BuffsData.Ptr_BuffsData>(@this.Ptr_GameData.BUFFS_DB);
            CacheBuffs.AddRange(items);
            @this.Logger.LogInformation("LoadBuffs:{size}", CacheBuffs.Count);
        }
        public static void LoadConstants(this AzureValleyEnvironment @this)
        {
            var items = @this.EnumResource<Constants.Ptr_Constants, ConstantsData.Ptr_ConstantsData>(@this.Ptr_GameData.CONSTANTS_DB);
            CacheConstants.AddRange(items);
            @this.Logger.LogInformation("LoadConstants:{size}", CacheConstants.Count);
        }
        public static void LoadConstructibles(this AzureValleyEnvironment @this)
        {
            var items = @this.EnumResource<Constructibles.Ptr_Constructibles, ConstructiblesData.Ptr_ConstructiblesData>(@this.Ptr_GameData.CONSTRUCTIBLES_DB);
            CacheConstructibles.AddRange(items);
            @this.Logger.LogInformation("LoadConstructibles:{size}", CacheConstructibles.Count);
        }
        public static void LoadFoods(this AzureValleyEnvironment @this)
        {
            var items = @this.EnumResource<Foods.Ptr_Foods, FoodsData.Ptr_FoodsData>(@this.Ptr_GameData.FOODS_DB);
            CacheFoods.AddRange(items);
            @this.Logger.LogInformation("LoadFoods:{size}", CacheFoods.Count);
        }
        public static void LoadHints(this AzureValleyEnvironment @this)
        {
            var items = @this.EnumResource<Hints.Ptr_Hints, HintsData.Ptr_HintsData>(@this.Ptr_GameData.HINTS_DB);
            CacheHints.AddRange(items);
            @this.Logger.LogInformation("LoadHints:{size}", CacheHints.Count);
        }
        public static void LoadInventoryItems(this AzureValleyEnvironment @this)
        {
            var items = @this.EnumResource<InventoryItems.Ptr_InventoryItems, InventoryItemsData.Ptr_InventoryItemsData>(@this.Ptr_GameData.INVENTORY_ITEMS_DB);
            CacheInventoryItems.AddRange(items);
            @this.Logger.LogInformation("LoadInventoryItems:{size}", CacheInventoryItems.Count);
        }
        public static void LoadPerks(this AzureValleyEnvironment @this)
        {
            var items = @this.EnumResource<Perks.Ptr_Perks, PerksData.Ptr_PerksData>(@this.Ptr_GameData.PERKS_DB);
            CachePerks.AddRange(items);
            @this.Logger.LogInformation("LoadPerks:{size}", CachePerks.Count);
        }
        public static void LoadRecipes(this AzureValleyEnvironment @this)
        {
            var items = @this.EnumResource<Recipes.Ptr_Recipes, RecipesData.Ptr_RecipesData>(@this.Ptr_GameData.RECIPES_DB);
            CacheRecipes.AddRange(items);
            @this.Logger.LogInformation("LoadRecipes:{size}", CacheRecipes.Count);
        }
        public static void LoadTokens(this AzureValleyEnvironment @this)
        {
            var items = @this.EnumResource<Tokens.Ptr_Tokens, TokensData.Ptr_TokensData>(@this.Ptr_GameData.TOKENS_DB);
            CacheTokens.AddRange(items);
            @this.Logger.LogInformation("LoadTokens:{size}", CacheTokens.Count);
        }
        public static void LoadWorldItems(this AzureValleyEnvironment @this)
        {
            var items = @this.EnumResource<WorldItems.Ptr_WorldItems, WorldItemsData.Ptr_WorldItemsData>(@this.Ptr_GameData.WORLD_ITEMS_DB);
            CacheWorldItems.AddRange(items);
            @this.Logger.LogInformation("LoadWorldItems:{size}", CacheWorldItems.Count);
        }


        static IEnumerable<GameInventoryDisplayDTO> EnumResource<T_GameItem, T_GameItemData>(this AzureValleyEnvironment @this, T_GameItem items)
            where T_GameItem : unmanaged, IGameItem<T_GameItemData>
            where T_GameItemData : unmanaged, IGameItemData
        {

            foreach (var ptrItem in items.Data)
            {
                var data = new GameInventoryDisplayDTO()
                {
                    ObjectId = ptrItem.Id,
                    DisplayName = ptrItem.Name,
                    DisplayDesc = ptrItem.Description,
                    DisplayCategory = ptrItem.Type.ToString(),
                };
                @this.Logger.LogInformation("{id}=>{name}=>{desc}=>{category}",
                    data.ObjectId,
                    data.DisplayName,
                    data.DisplayDesc,
                    data.DisplayCategory);
                yield return data;


            }
        }
        static void FirstEnumResource<T_GameItem, T_GameItemData>(this AzureValleyEnvironment @this, T_GameItem items)
            where T_GameItem : unmanaged, IGameItem<T_GameItemData>
            where T_GameItemData : unmanaged, IGameItemData
        {
            foreach (var ptrItem in items.Data)
            {
               _ = ptrItem.Name;
                _ = ptrItem.Description;
                return;
            }
        }

    }



}
