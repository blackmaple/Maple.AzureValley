
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.AzureValley.Metadata
{


    /// <summary>
    /// class ["AzureValley".""."GameData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x020004C8U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [71, 97, 109, 101, 68, 97, 116, 97])]

    //  class static GameData m_instance
    [MonoCollectorSearchFieldAttribute(typeof(GameData.Ptr_GameData), "m_instance", "M_INSTANCE", true)]

    // class 0x10 WorldItems <WorldItemsDB>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(WorldItems.Ptr_WorldItems), "<WorldItemsDB>k__BackingField", "WORLD_ITEMS_DB")]

    // class 0x18 InventoryItems <InventoryItemsDB>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(InventoryItems.Ptr_InventoryItems), "<InventoryItemsDB>k__BackingField", "INVENTORY_ITEMS_DB")]

    // class 0x20 Recipes <RecipesDB>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(Recipes.Ptr_Recipes), "<RecipesDB>k__BackingField", "RECIPES_DB")]

    // class 0x28 Tokens <TokensDB>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(Tokens.Ptr_Tokens), "<TokensDB>k__BackingField", "TOKENS_DB")]

    // class 0x30 Constants <ConstantsDB>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(Constants.Ptr_Constants), "<ConstantsDB>k__BackingField", "CONSTANTS_DB")]

    // class 0x38 Buffs <BuffsDB>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(Buffs.Ptr_Buffs), "<BuffsDB>k__BackingField", "BUFFS_DB")]

    // class 0x40 Foods <FoodsDB>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(Foods.Ptr_Foods), "<FoodsDB>k__BackingField", "FOODS_DB")]

    // class 0x48 Perks <PerksDB>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(Perks.Ptr_Perks), "<PerksDB>k__BackingField", "PERKS_DB")]

    // class 0x50 Hints <HintsDB>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(Hints.Ptr_Hints), "<HintsDB>k__BackingField", "HINTS_DB")]

    // class 0x58 Constructibles <ConstructiblesDB>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(Constructibles.Ptr_Constructibles), "<ConstructiblesDB>k__BackingField", "CONSTRUCTIBLES_DB")]

    // class 0x60 AutoUnlocks <AutoUnlocksDB>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(AutoUnlocks.Ptr_AutoUnlocks), "<AutoUnlocksDB>k__BackingField", "AUTO_UNLOCKS_DB")]

    // class 0x68 GameLogic.GameLogic <GameLogic>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<GameLogic>k__BackingField", "GAME_LOGIC")]

    // class 0x70 GameInitializationData <InitializationData>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<InitializationData>k__BackingField", "INITIALIZATION_DATA")]

    // class 0x78 SpawnPool <SpawningPool>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<SpawningPool>k__BackingField", "SPAWNING_POOL")]

    // class 0x80 FarmAnimalData <FarmAnimalData>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<FarmAnimalData>k__BackingField", "FARM_ANIMAL_DATA")]

    // class 0x88 RockFlowSettings <RockFlowSettings>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<RockFlowSettings>k__BackingField", "ROCK_FLOW_SETTINGS")]

    // class 0x90 AudioZoneConfig <AudioZoneConfig>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<AudioZoneConfig>k__BackingField", "AUDIO_ZONE_CONFIG")]

    // class 0x98 System.Collections.Generic.Dictionary<System.String,AreaOfEffect> <AreaOfEffects>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<AreaOfEffects>k__BackingField", "AREA_OF_EFFECTS")]

    // class 0xA0 FishingZones <FishingZones>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<FishingZones>k__BackingField", "FISHING_ZONES")]

    // class 0xA8 CritterZones <CritterZones>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<CritterZones>k__BackingField", "CRITTER_ZONES")]

    // class 0xB0 WeatherConfig <WeatherConfig>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<WeatherConfig>k__BackingField", "WEATHER_CONFIG")]

    // class 0xB8 XPDrops <XPDrops>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<XPDrops>k__BackingField", "XP_DROPS")]

    // class 0xC0 System.Collections.Generic.List<UnityEngine.Texture2D> <Stamps>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Stamps>k__BackingField", "STAMPS")]

    // class 0xC8 Calendar <Calendar>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Calendar>k__BackingField", "CALENDAR")]

    // class 0xD0 WindZones <WindZones>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<WindZones>k__BackingField", "WIND_ZONES")]

    // class 0xD8 TileModifierPrefabConfig <TileModifierConfig>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<TileModifierConfig>k__BackingField", "TILE_MODIFIER_CONFIG")]

    // class 0xE0 DynamicAmbientConfig <DynamicAmbientConfig>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<DynamicAmbientConfig>k__BackingField", "DYNAMIC_AMBIENT_CONFIG")]

    // struct 0xE8 System.Boolean <IsInitialized>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "<IsInitialized>k__BackingField", "IS_INITIALIZED")]

    // struct 0xE9 System.Boolean <IsLoading>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "<IsLoading>k__BackingField", "IS_LOADING")]
    public partial class GameData
    {
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GameData";
        //public static byte[] Static_ClassName { get; } = [71, 97, 109, 101, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x020004C8U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GameData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GameData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GameData obj) => obj._ptr;
            public static implicit operator bool(Ptr_GameData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["AzureValley".""."GameData"]
    /// </summary>
    public partial class GameData
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   System.Void <Initialize>b__119_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<WorldItems> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<WorldItems></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_0")]
        ///  extern void <INITIALIZE>B__119_0 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<WorldItems> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_1(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<InventoryItems> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<InventoryItems></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_1")]
        ///  extern void <INITIALIZE>B__119_1 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<InventoryItems> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_10(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Constructibles> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Constructibles></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_10")]
        ///  extern void <INITIALIZE>B__119_10 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Constructibles> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_11(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<AutoUnlocks> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<AutoUnlocks></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_11")]
        ///  extern void <INITIALIZE>B__119_11 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<AutoUnlocks> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_12(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<FarmAnimalData> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<FarmAnimalData></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_12")]
        ///  extern void <INITIALIZE>B__119_12 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<FarmAnimalData> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_13(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<RockFlowSettings> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<RockFlowSettings></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_13")]
        ///  extern void <INITIALIZE>B__119_13 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<RockFlowSettings> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_14(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<AudioZoneConfig> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<AudioZoneConfig></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_14")]
        ///  extern void <INITIALIZE>B__119_14 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<AudioZoneConfig> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_15(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<FishingZones> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<FishingZones></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_15")]
        ///  extern void <INITIALIZE>B__119_15 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<FishingZones> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_16(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<CritterZones> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<CritterZones></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_16")]
        ///  extern void <INITIALIZE>B__119_16 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<CritterZones> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_17(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<WeatherConfig> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<WeatherConfig></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_17")]
        ///  extern void <INITIALIZE>B__119_17 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<WeatherConfig> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_18(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Calendar> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Calendar></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_18")]
        ///  extern void <INITIALIZE>B__119_18 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Calendar> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_19(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<WindZones> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<WindZones></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_19")]
        ///  extern void <INITIALIZE>B__119_19 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<WindZones> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_2(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Recipes> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Recipes></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_2")]
        ///  extern void <INITIALIZE>B__119_2 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Recipes> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_20(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TileModifierPrefabConfig> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TileModifierPrefabConfig></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_20")]
        ///  extern void <INITIALIZE>B__119_20 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TileModifierPrefabConfig> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_21(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<DynamicAmbientConfig> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<DynamicAmbientConfig></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_21")]
        ///  extern void <INITIALIZE>B__119_21 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<DynamicAmbientConfig> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_22(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameLogic.GameLogic> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameLogic.GameLogic></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_22")]
        ///  extern void <INITIALIZE>B__119_22 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameLogic.GameLogic> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_23(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameInitializationData> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameInitializationData></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_23")]
        ///  extern void <INITIALIZE>B__119_23 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameInitializationData> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_3(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Tokens> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Tokens></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_3")]
        ///  extern void <INITIALIZE>B__119_3 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Tokens> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_4(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Constants> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Constants></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_4")]
        ///  extern void <INITIALIZE>B__119_4 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Constants> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_5(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Buffs> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Buffs></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_5")]
        ///  extern void <INITIALIZE>B__119_5 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Buffs> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_6(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Foods> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Foods></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_6")]
        ///  extern void <INITIALIZE>B__119_6 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Foods> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_7(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Perks> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Perks></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_7")]
        ///  extern void <INITIALIZE>B__119_7 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Perks> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_8(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Hints> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Hints></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_8")]
        ///  extern void <INITIALIZE>B__119_8 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<Hints> handle);


        /// <summary>
        ///   System.Void <Initialize>b__119_9(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<XPDrops> handle)
        /// </summary>
        /// <param name="handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<XPDrops></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Initialize>b__119_9")]
        ///  extern void <INITIALIZE>B__119_9 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<XPDrops> handle);


        /// <summary>
        ///   System.Collections.Generic.Dictionary<System.String,AreaOfEffect> get_AreaOfEffects()
        /// </summary>
        /// <returns>class System.Collections.Generic.Dictionary<System.String,AreaOfEffect></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AreaOfEffects")]
        ///  extern nint GET_AREA_OF_EFFECTS ();


        /// <summary>
        ///   AudioZoneConfig get_AudioZoneConfig()
        /// </summary>
        /// <returns>class AudioZoneConfig</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AudioZoneConfig")]
        ///  extern nint GET_AUDIO_ZONE_CONFIG ();


        /// <summary>
        ///   AutoUnlocks get_AutoUnlocksDB()
        /// </summary>
        /// <returns>class AutoUnlocks</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AutoUnlocksDB")]
        ///  extern nint GET_AUTO_UNLOCKS_DB ();


        /// <summary>
        ///   Buffs get_BuffsDB()
        /// </summary>
        /// <returns>class Buffs</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_BuffsDB")]
        ///  extern nint GET_BUFFS_DB ();


        /// <summary>
        ///   Calendar get_Calendar()
        /// </summary>
        /// <returns>class Calendar</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Calendar")]
        ///  extern nint GET_CALENDAR ();


        /// <summary>
        ///   Constants get_ConstantsDB()
        /// </summary>
        /// <returns>class Constants</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ConstantsDB")]
        ///  extern nint GET_CONSTANTS_DB ();


        /// <summary>
        ///   Constructibles get_ConstructiblesDB()
        /// </summary>
        /// <returns>class Constructibles</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ConstructiblesDB")]
        ///  extern nint GET_CONSTRUCTIBLES_DB ();


        /// <summary>
        ///   CritterZones get_CritterZones()
        /// </summary>
        /// <returns>class CritterZones</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CritterZones")]
        ///  extern nint GET_CRITTER_ZONES ();


        /// <summary>
        ///   DynamicAmbientConfig get_DynamicAmbientConfig()
        /// </summary>
        /// <returns>class DynamicAmbientConfig</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DynamicAmbientConfig")]
        ///  extern nint GET_DYNAMIC_AMBIENT_CONFIG ();


        /// <summary>
        ///   FarmAnimalData get_FarmAnimalData()
        /// </summary>
        /// <returns>class FarmAnimalData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FarmAnimalData")]
        ///  extern nint GET_FARM_ANIMAL_DATA ();


        /// <summary>
        ///   FishingZones get_FishingZones()
        /// </summary>
        /// <returns>class FishingZones</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FishingZones")]
        ///  extern nint GET_FISHING_ZONES ();


        /// <summary>
        ///   Foods get_FoodsDB()
        /// </summary>
        /// <returns>class Foods</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FoodsDB")]
        ///  extern nint GET_FOODS_DB ();


        /// <summary>
        ///   GameLogic.GameLogic get_GameLogic()
        /// </summary>
        /// <returns>class GameLogic.GameLogic</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameLogic")]
        ///  extern nint GET_GAME_LOGIC ();


        /// <summary>
        ///   Hints get_HintsDB()
        /// </summary>
        /// <returns>class Hints</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HintsDB")]
        ///  extern nint GET_HINTS_DB ();


        /// <summary>
        ///   GameInitializationData get_InitializationData()
        /// </summary>
        /// <returns>class GameInitializationData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InitializationData")]
        ///  extern nint GET_INITIALIZATION_DATA ();


        /// <summary>
        /// static  GameData get_Instance()
        /// </summary>
        /// <returns>class GameData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Instance")]
        /// static extern nint GET_INSTANCE ();


        /// <summary>
        ///   InventoryItems get_InventoryItemsDB()
        /// </summary>
        /// <returns>class InventoryItems</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InventoryItemsDB")]
        ///  extern nint GET_INVENTORY_ITEMS_DB ();


        /// <summary>
        ///   System.Boolean get_IsInitialized()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsInitialized")]
        ///  extern System.Boolean GET_IS_INITIALIZED ();


        /// <summary>
        ///   System.Boolean get_IsLoading()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsLoading")]
        ///  extern System.Boolean GET_IS_LOADING ();


        /// <summary>
        ///   Perks get_PerksDB()
        /// </summary>
        /// <returns>class Perks</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PerksDB")]
        ///  extern nint GET_PERKS_DB ();


        /// <summary>
        ///   Recipes get_RecipesDB()
        /// </summary>
        /// <returns>class Recipes</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RecipesDB")]
        ///  extern nint GET_RECIPES_DB ();


        /// <summary>
        ///   RockFlowSettings get_RockFlowSettings()
        /// </summary>
        /// <returns>class RockFlowSettings</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RockFlowSettings")]
        ///  extern nint GET_ROCK_FLOW_SETTINGS ();


        /// <summary>
        ///   SpawnPool get_SpawningPool()
        /// </summary>
        /// <returns>class SpawnPool</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SpawningPool")]
        ///  extern nint GET_SPAWNING_POOL ();


        /// <summary>
        ///   System.Collections.Generic.List<UnityEngine.Texture2D> get_Stamps()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<UnityEngine.Texture2D></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Stamps")]
        ///  extern nint GET_STAMPS ();


        /// <summary>
        ///   TileModifierPrefabConfig get_TileModifierConfig()
        /// </summary>
        /// <returns>class TileModifierPrefabConfig</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TileModifierConfig")]
        ///  extern nint GET_TILE_MODIFIER_CONFIG ();


        /// <summary>
        ///   Tokens get_TokensDB()
        /// </summary>
        /// <returns>class Tokens</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TokensDB")]
        ///  extern nint GET_TOKENS_DB ();


        /// <summary>
        ///   WeatherConfig get_WeatherConfig()
        /// </summary>
        /// <returns>class WeatherConfig</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WeatherConfig")]
        ///  extern nint GET_WEATHER_CONFIG ();


        /// <summary>
        ///   WindZones get_WindZones()
        /// </summary>
        /// <returns>class WindZones</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WindZones")]
        ///  extern nint GET_WIND_ZONES ();


        /// <summary>
        ///   WorldItems get_WorldItemsDB()
        /// </summary>
        /// <returns>class WorldItems</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldItemsDB")]
        ///  extern nint GET_WORLD_ITEMS_DB ();


        /// <summary>
        ///   XPDrops get_XPDrops()
        /// </summary>
        /// <returns>class XPDrops</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_XPDrops")]
        ///  extern nint GET_XP_DROPS ();


        /// <summary>
        ///   Cysharp.Threading.Tasks.UniTask Initialize()
        /// </summary>
        /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Initialize")]
        ///  extern Cysharp.Threading.Tasks.UniTask INITIALIZE ();


        /// <summary>
        ///   System.Void LoadAreaOfEffect(AreaOfEffect obj)
        /// </summary>
        /// <param name="obj">class AreaOfEffect</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadAreaOfEffect")]
        ///  extern void LOAD_AREA_OF_EFFECT (nint obj);


        /// <summary>
        ///   System.Void LoadStamp(UnityEngine.Texture2D obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Texture2D</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadStamp")]
        ///  extern void LOAD_STAMP (nint obj);


        /// <summary>
        ///   System.Void RegenerateSpawnPool()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RegenerateSpawnPool")]
        ///  extern void REGENERATE_SPAWN_POOL ();


        /// <summary>
        ///   System.Void set_AreaOfEffects(System.Collections.Generic.Dictionary<System.String,AreaOfEffect> value)
        /// </summary>
        /// <param name="value">class System.Collections.Generic.Dictionary<System.String,AreaOfEffect></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_AreaOfEffects")]
        ///  extern void SET_AREA_OF_EFFECTS (nint value);


        /// <summary>
        ///   System.Void set_AudioZoneConfig(AudioZoneConfig value)
        /// </summary>
        /// <param name="value">class AudioZoneConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_AudioZoneConfig")]
        ///  extern void SET_AUDIO_ZONE_CONFIG (nint value);


        /// <summary>
        ///   System.Void set_AutoUnlocksDB(AutoUnlocks value)
        /// </summary>
        /// <param name="value">class AutoUnlocks</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_AutoUnlocksDB")]
        ///  extern void SET_AUTO_UNLOCKS_DB (nint value);


        /// <summary>
        ///   System.Void set_BuffsDB(Buffs value)
        /// </summary>
        /// <param name="value">class Buffs</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_BuffsDB")]
        ///  extern void SET_BUFFS_DB (nint value);


        /// <summary>
        ///   System.Void set_Calendar(Calendar value)
        /// </summary>
        /// <param name="value">class Calendar</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Calendar")]
        ///  extern void SET_CALENDAR (nint value);


        /// <summary>
        ///   System.Void set_ConstantsDB(Constants value)
        /// </summary>
        /// <param name="value">class Constants</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ConstantsDB")]
        ///  extern void SET_CONSTANTS_DB (nint value);


        /// <summary>
        ///   System.Void set_ConstructiblesDB(Constructibles value)
        /// </summary>
        /// <param name="value">class Constructibles</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ConstructiblesDB")]
        ///  extern void SET_CONSTRUCTIBLES_DB (nint value);


        /// <summary>
        ///   System.Void set_CritterZones(CritterZones value)
        /// </summary>
        /// <param name="value">class CritterZones</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_CritterZones")]
        ///  extern void SET_CRITTER_ZONES (nint value);


        /// <summary>
        ///   System.Void set_DynamicAmbientConfig(DynamicAmbientConfig value)
        /// </summary>
        /// <param name="value">class DynamicAmbientConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_DynamicAmbientConfig")]
        ///  extern void SET_DYNAMIC_AMBIENT_CONFIG (nint value);


        /// <summary>
        ///   System.Void set_FarmAnimalData(FarmAnimalData value)
        /// </summary>
        /// <param name="value">class FarmAnimalData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_FarmAnimalData")]
        ///  extern void SET_FARM_ANIMAL_DATA (nint value);


        /// <summary>
        ///   System.Void set_FishingZones(FishingZones value)
        /// </summary>
        /// <param name="value">class FishingZones</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_FishingZones")]
        ///  extern void SET_FISHING_ZONES (nint value);


        /// <summary>
        ///   System.Void set_FoodsDB(Foods value)
        /// </summary>
        /// <param name="value">class Foods</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_FoodsDB")]
        ///  extern void SET_FOODS_DB (nint value);


        /// <summary>
        ///   System.Void set_GameLogic(GameLogic.GameLogic value)
        /// </summary>
        /// <param name="value">class GameLogic.GameLogic</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_GameLogic")]
        ///  extern void SET_GAME_LOGIC (nint value);


        /// <summary>
        ///   System.Void set_HintsDB(Hints value)
        /// </summary>
        /// <param name="value">class Hints</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_HintsDB")]
        ///  extern void SET_HINTS_DB (nint value);


        /// <summary>
        ///   System.Void set_InitializationData(GameInitializationData value)
        /// </summary>
        /// <param name="value">class GameInitializationData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_InitializationData")]
        ///  extern void SET_INITIALIZATION_DATA (nint value);


        /// <summary>
        ///   System.Void set_InventoryItemsDB(InventoryItems value)
        /// </summary>
        /// <param name="value">class InventoryItems</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_InventoryItemsDB")]
        ///  extern void SET_INVENTORY_ITEMS_DB (nint value);


        /// <summary>
        ///   System.Void set_IsInitialized(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsInitialized")]
        ///  extern void SET_IS_INITIALIZED (System.Boolean value);


        /// <summary>
        ///   System.Void set_IsLoading(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsLoading")]
        ///  extern void SET_IS_LOADING (System.Boolean value);


        /// <summary>
        ///   System.Void set_PerksDB(Perks value)
        /// </summary>
        /// <param name="value">class Perks</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_PerksDB")]
        ///  extern void SET_PERKS_DB (nint value);


        /// <summary>
        ///   System.Void set_RecipesDB(Recipes value)
        /// </summary>
        /// <param name="value">class Recipes</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_RecipesDB")]
        ///  extern void SET_RECIPES_DB (nint value);


        /// <summary>
        ///   System.Void set_RockFlowSettings(RockFlowSettings value)
        /// </summary>
        /// <param name="value">class RockFlowSettings</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_RockFlowSettings")]
        ///  extern void SET_ROCK_FLOW_SETTINGS (nint value);


        /// <summary>
        ///   System.Void set_SpawningPool(SpawnPool value)
        /// </summary>
        /// <param name="value">class SpawnPool</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_SpawningPool")]
        ///  extern void SET_SPAWNING_POOL (nint value);


        /// <summary>
        ///   System.Void set_Stamps(System.Collections.Generic.List<UnityEngine.Texture2D> value)
        /// </summary>
        /// <param name="value">class System.Collections.Generic.List<UnityEngine.Texture2D></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Stamps")]
        ///  extern void SET_STAMPS (nint value);


        /// <summary>
        ///   System.Void set_TileModifierConfig(TileModifierPrefabConfig value)
        /// </summary>
        /// <param name="value">class TileModifierPrefabConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_TileModifierConfig")]
        ///  extern void SET_TILE_MODIFIER_CONFIG (nint value);


        /// <summary>
        ///   System.Void set_TokensDB(Tokens value)
        /// </summary>
        /// <param name="value">class Tokens</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_TokensDB")]
        ///  extern void SET_TOKENS_DB (nint value);


        /// <summary>
        ///   System.Void set_WeatherConfig(WeatherConfig value)
        /// </summary>
        /// <param name="value">class WeatherConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_WeatherConfig")]
        ///  extern void SET_WEATHER_CONFIG (nint value);


        /// <summary>
        ///   System.Void set_WindZones(WindZones value)
        /// </summary>
        /// <param name="value">class WindZones</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_WindZones")]
        ///  extern void SET_WIND_ZONES (nint value);


        /// <summary>
        ///   System.Void set_WorldItemsDB(WorldItems value)
        /// </summary>
        /// <param name="value">class WorldItems</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_WorldItemsDB")]
        ///  extern void SET_WORLD_ITEMS_DB (nint value);


        /// <summary>
        ///   System.Void set_XPDrops(XPDrops value)
        /// </summary>
        /// <param name="value">class XPDrops</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_XPDrops")]
        ///  extern void SET_XP_DROPS (nint value);




        /// public static partial class Search_GameData
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}