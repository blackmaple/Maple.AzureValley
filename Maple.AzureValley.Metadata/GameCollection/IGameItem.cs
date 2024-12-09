using Maple.MonoGameAssistant.Core;

namespace Maple.AzureValley.Metadata
{
    public interface IGameItem<T_GameItemData> where T_GameItemData : unmanaged, IGameItemData
    {
        PMonoArray<T_GameItemData> Data { get; }
    }
    public interface IGameItemData
    {
        string Id { get; }
        public string? Name => string.Empty;
        public string? Description => string.Empty;
        GameItemType Type { get; }


    }

    partial class AutoUnlocks
    {
        partial struct Ptr_AutoUnlocks : IGameItem<AutoUnlocksData.Ptr_AutoUnlocksData>
        {
            public PMonoArray<AutoUnlocksData.Ptr_AutoUnlocksData> Data => DATA_ARRAY;
        }
    }
    partial class AutoUnlocksData
    {
        partial struct Ptr_AutoUnlocksData : IGameItemData
        {
            public string Id => GET_NAME().ToString()!;
            public GameItemType Type => GameItemType.AutoUnlocks;


        }
    }


    partial class Buffs
    {
        partial struct Ptr_Buffs : IGameItem<BuffsData.Ptr_BuffsData>
        {
            public PMonoArray<BuffsData.Ptr_BuffsData> Data => DATA_ARRAY;
        }
    }
    partial class BuffsData
    {
        partial struct Ptr_BuffsData : IGameItemData
        {
            public string Id => GET_NAME().ToString()!;
            public GameItemType Type => GameItemType.Buffs;


        }
    }


    partial class Constants
    {
        partial struct Ptr_Constants : IGameItem<ConstantsData.Ptr_ConstantsData>
        {
            public PMonoArray<ConstantsData.Ptr_ConstantsData> Data => DATA_ARRAY;
        }
    }
    partial class ConstantsData
    {
        partial struct Ptr_ConstantsData : IGameItemData
        {
            public string Id => GET_NAME().ToString()!;
            public GameItemType Type => GameItemType.Constants;


        }
    }


    partial class Foods
    {
        partial struct Ptr_Foods : IGameItem<FoodsData.Ptr_FoodsData>
        {
            public PMonoArray<FoodsData.Ptr_FoodsData> Data => DATA_ARRAY;
        }
    }
    partial class FoodsData
    {
        partial struct Ptr_FoodsData : IGameItemData
        {
            public string Id => GET_NAME().ToString()!;
            public GameItemType Type => GameItemType.Foods;


        }
    }

    partial class Constructibles
    {
        partial struct Ptr_Constructibles : IGameItem<ConstructiblesData.Ptr_ConstructiblesData>
        {
            public PMonoArray<ConstructiblesData.Ptr_ConstructiblesData> Data => DATA_ARRAY;
        }
    }
    partial class ConstructiblesData
    {
        partial struct Ptr_ConstructiblesData : IGameItemData
        {
            public string Id => GET_NAME().ToString()!;
            public GameItemType Type => GameItemType.Constructibles;


        }
    }

    partial class Hints
    {
        partial struct Ptr_Hints : IGameItem<HintsData.Ptr_HintsData>
        {
            public PMonoArray<HintsData.Ptr_HintsData> Data => DATA_ARRAY;
        }
    }
    partial class HintsData
    {
        partial struct Ptr_HintsData : IGameItemData
        {
            public string Id => GET_NAME().ToString()!;
            public GameItemType Type => GameItemType.Hints;


        }
    }

    partial class InventoryItems
    {
        partial struct Ptr_InventoryItems : IGameItem<InventoryItemsData.Ptr_InventoryItemsData>
        {
            public PMonoArray<InventoryItemsData.Ptr_InventoryItemsData> Data => DATA_ARRAY;
        }
    }
    partial class InventoryItemsData
    {
        partial struct Ptr_InventoryItemsData : IGameItemData
        {
            public string Id => GET_NAME().ToString()!;
            public string? Name => GET_LOCALIZED_NAME().ToString();
            //public string? Description => GET_LOCALIZED_DESCRIPTION_00().ToString();
            public GameItemType Type => GameItemType.InventoryItems;


        }
    }

    partial class Perks
    {
        partial struct Ptr_Perks : IGameItem<PerksData.Ptr_PerksData>
        {
            public PMonoArray<PerksData.Ptr_PerksData> Data => DATA_ARRAY;
        }
    }
    partial class PerksData
    {
        partial struct Ptr_PerksData : IGameItemData
        {
            public string Id => GET_NAME().ToString()!;
            public GameItemType Type => GameItemType.Perks;


        }
    }

    partial class Recipes
    {
        partial struct Ptr_Recipes : IGameItem<RecipesData.Ptr_RecipesData>
        {
            public PMonoArray<RecipesData.Ptr_RecipesData> Data => DATA_ARRAY;
        }
    }
    partial class RecipesData
    {
        partial struct Ptr_RecipesData : IGameItemData
        {
            public string Id => GET_NAME().ToString()!;
            //public string? Name => GET_LOCALIZED_NAME().ToString();
            //public string? Description => GET_LOCALIZED_DESCRIPTION_00().ToString();
            public GameItemType Type => GameItemType.Recipes;


        }
    }


    partial class Tokens
    {
        partial struct Ptr_Tokens : IGameItem<TokensData.Ptr_TokensData>
        {
            public PMonoArray<TokensData.Ptr_TokensData> Data => DATA_ARRAY;
        }
    }
    partial class TokensData
    {
        partial struct Ptr_TokensData : IGameItemData
        {
            public string Id => GET_NAME().ToString()!;
            public GameItemType Type => GameItemType.Tokens;
        }
    }


    partial class WorldItems
    {
        partial struct Ptr_WorldItems : IGameItem<WorldItemsData.Ptr_WorldItemsData>
        {
            public PMonoArray<WorldItemsData.Ptr_WorldItemsData> Data => DATA_ARRAY;
        }
    }
    partial class WorldItemsData
    {
        partial struct Ptr_WorldItemsData : IGameItemData
        {
            public string Id => GET_NAME().ToString()!;
            //public string? Name => GET_LOCALIZED_NAME().ToString();
             public GameItemType Type => GameItemType.WorldItems;


        }
    }
}
