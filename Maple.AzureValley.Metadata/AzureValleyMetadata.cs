using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.AzureValley.Metadata
{

    [MonoCollectorOptions(
typeof(MonoCollectorContext),
typeof(MonoCollectorMember),
typeof(MonoRuntimeContext),
typeof(MonoCollectorClassInfo)
)]


    [MonoCollectorType(typeof(GameData))]
    //[MonoCollectorType(typeof(WorldItems))]

    [MonoCollectorType(typeof(InventoryItems))]
    [MonoCollectorType(typeof(InventoryItemsData))]

    [MonoCollectorType(typeof(Recipes))]
    [MonoCollectorType(typeof(RecipesData))]

    [MonoCollectorType(typeof(Constants))]
    [MonoCollectorType(typeof(ConstantsData))]

    [MonoCollectorType(typeof(Buffs))]
    [MonoCollectorType(typeof(BuffsData))]

    [MonoCollectorType(typeof(Foods))]
    [MonoCollectorType(typeof(FoodsData))]

    [MonoCollectorType(typeof(Perks))]
    [MonoCollectorType(typeof(PerksData))]

    [MonoCollectorType(typeof(Hints))]
    [MonoCollectorType(typeof(HintsData))]

    [MonoCollectorType(typeof(Constructibles))]
    [MonoCollectorType(typeof(ConstructiblesData))]

    [MonoCollectorType(typeof(AutoUnlocks))]
    [MonoCollectorType(typeof(AutoUnlocksData))]

    [MonoCollectorType(typeof(Tokens))]
    [MonoCollectorType(typeof(TokensData))]

    [MonoCollectorType(typeof(WorldItems))]
    [MonoCollectorType(typeof(WorldItemsData))]


    [MonoCollectorType(typeof(GameState))]



    [MonoCollectorType(typeof(PlayersManager))]
    [MonoCollectorType(typeof(LocalPlayerController))]
    [MonoCollectorType(typeof(PlayerInventory))]
    [MonoCollectorType(typeof(Inventory))]
    [MonoCollectorType(typeof(ItemStack))]
    [MonoCollectorType(typeof(InventoryItem))]
    [MonoCollectorType(typeof(ItemVariation))]

    [MonoCollectorType(typeof(PlayerData))]

    
    public partial class AzureValleyMetadata
    {

    }
}
