
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
    /// class ["AzureValley".""."SaveGame"]
    /// [System.Object]
    /// [MessagePack.IMessagePackSerializationCallbackReceiver]=>[ICanLoadFromRepository]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x020002C6U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [83, 97, 118, 101, 71, 97, 109, 101])]
                
    //  struct static System.Int32 FileVersion
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"FileVersion", "FILE_VERSION", true)]
                
    // class 0x10 System.String <Name>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Name>k__BackingField", "NAME")]
            
    // class 0x18 System.Collections.Generic.List<PlayerData> <Players>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Players>k__BackingField", "PLAYERS")]
            
    // class 0x20 System.Collections.Generic.List<NPC> <SerializedNPCs>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<SerializedNPCs>k__BackingField", "SERIALIZED_NP_CS")]
            
    // class 0x28 GlobalStates <GlobalStates>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<GlobalStates>k__BackingField", "GLOBAL_STATES")]
            
    // class 0x30 System.Collections.Generic.Dictionary<System.String,Inventory> <GlobalInventories>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<GlobalInventories>k__BackingField", "GLOBAL_INVENTORIES")]
            
    // class 0x38 System.Collections.Generic.List<VehicleData> <Vehicles>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Vehicles>k__BackingField", "VEHICLES")]
            
    // class 0x40 System.Collections.Generic.List<Level> <Levels>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Levels>k__BackingField", "LEVELS")]
            
    // class 0x48 System.Collections.Generic.Dictionary<Unity.Mathematics.int4,GenericData> <DataForObjectID>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<DataForObjectID>k__BackingField", "DATA_FOR_OBJECT_ID")]
            
    // class 0x50 System.Collections.Generic.List<Quest> <Quests>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Quests>k__BackingField", "QUESTS")]
            
    // class 0x58 System.String <GameVersion>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<GameVersion>k__BackingField", "GAME_VERSION")]
            
    // class 0x60 Inventory <SharedInventory>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<SharedInventory>k__BackingField", "SHARED_INVENTORY")]
            
    // class 0x68 SemanticVersion <CreatedAtVersion>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<CreatedAtVersion>k__BackingField", "CREATED_AT_VERSION")]
            
    // class 0x70 SemanticVersion <MigratedAtVersion>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<MigratedAtVersion>k__BackingField", "MIGRATED_AT_VERSION")]
            
    // class 0x78 SemanticVersion <LastPlayedAtVersion>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<LastPlayedAtVersion>k__BackingField", "LAST_PLAYED_AT_VERSION")]
            
    // class 0x80 System.Collections.Generic.List<NPC> <NPCs>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<NPCs>k__BackingField", "NP_CS")]
            
    // class 0x88 System.Collections.Generic.Dictionary<System.String,Level> <LevelsByName>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<LevelsByName>k__BackingField", "LEVELS_BY_NAME")]
            
    // struct 0x90 System.Int32 <DaysPassed>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"<DaysPassed>k__BackingField", "DAYS_PASSED")]
            
    // struct 0x94 System.Int32 <WeatherPresetIndex>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"<WeatherPresetIndex>k__BackingField", "WEATHER_PRESET_INDEX")]
            
    // struct 0x98 System.Nullable<System.TimeSpan> <TimeOfDay>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Nullable<System.TimeSpan>),"<TimeOfDay>k__BackingField", "TIME_OF_DAY")]
            
    // struct 0xA8 System.Nullable<System.Boolean> <EmitDayStartOnce>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Nullable<System.Boolean>),"<EmitDayStartOnce>k__BackingField", "EMIT_DAY_START_ONCE")]
            
    // struct 0xAC System.Nullable<System.Int32> <m_maxSharedID>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Nullable<System.Int32>),"<m_maxSharedID>k__BackingField", "M_MAX_SHARED_ID")]
            
    // struct 0xB8 System.DateTime <CreatedAt>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.DateTime),"<CreatedAt>k__BackingField", "CREATED_AT")]
            
    // struct 0xC0 System.DateTime <MigratedAt>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.DateTime),"<MigratedAt>k__BackingField", "MIGRATED_AT")]
            
    // struct 0xC8 System.DateTime <LastPlayedAt>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.DateTime),"<LastPlayedAt>k__BackingField", "LAST_PLAYED_AT")]
            
    // struct 0xD0 System.Nullable<System.Boolean> <ConsoleEverOpened>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Nullable<System.Boolean>),"<ConsoleEverOpened>k__BackingField", "CONSOLE_EVER_OPENED")]
            
    // struct 0xD2 System.Boolean <SerializeAllNPCS>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<SerializeAllNPCS>k__BackingField", "SERIALIZE_ALL_NPCS")]
    public partial class SaveGame
    { 
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "SaveGame";
        //public static byte[] Static_ClassName { get; } = [83, 97, 118, 101, 71, 97, 109, 101];

        //public const uint Const_TypeToken = 0x020002C6U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_SaveGame(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_SaveGame(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_SaveGame obj) => obj._ptr;
            public static implicit operator bool(Ptr_SaveGame obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["AzureValley".""."SaveGame"]
        /// </summary>
        public partial class SaveGame
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
            /// static  Cysharp.Threading.Tasks.UniTask<SaveGame> Create(System.String name)
            /// </summary>
            /// <param name="name">class System.String</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<SaveGame></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Create")]
            /// static extern Cysharp.Threading.Tasks.UniTask<SaveGame> CREATE (nint name);

            
            /// <summary>
            /// static  SaveGame CreateJoined()
            /// </summary>
            /// <returns>class SaveGame</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateJoined")]
            /// static extern nint CREATE_JOINED ();

            
            /// <summary>
            /// static  SaveGame CreateTemplate(System.String sceneName)
            /// </summary>
            /// <param name="sceneName">class System.String</param>
            /// <returns>class SaveGame</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateTemplate")]
            /// static extern nint CREATE_TEMPLATE (nint sceneName);

            
            /// <summary>
            ///   SaveGameHeader GenerateHeader()
            /// </summary>
            /// <returns>class SaveGameHeader</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateHeader")]
            ///  extern nint GENERATE_HEADER ();

            
            /// <summary>
            ///   System.Nullable<System.Boolean> get_ConsoleEverOpened()
            /// </summary>
            /// <returns>struct System.Nullable<System.Boolean></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ConsoleEverOpened")]
            ///  extern System.Nullable<System.Boolean> GET_CONSOLE_EVER_OPENED ();

            
            /// <summary>
            ///   System.DateTime get_CreatedAt()
            /// </summary>
            /// <returns>struct System.DateTime</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CreatedAt")]
            ///  extern System.DateTime GET_CREATED_AT ();

            
            /// <summary>
            ///   SemanticVersion get_CreatedAtVersion()
            /// </summary>
            /// <returns>class SemanticVersion</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CreatedAtVersion")]
            ///  extern nint GET_CREATED_AT_VERSION ();

            
            /// <summary>
            ///   System.Collections.Generic.Dictionary<Unity.Mathematics.int4,GenericData> get_DataForObjectID()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<Unity.Mathematics.int4,GenericData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DataForObjectID")]
            ///  extern nint GET_DATA_FOR_OBJECT_ID ();

            
            /// <summary>
            ///   System.Int32 get_DaysPassed()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DaysPassed")]
            ///  extern System.Int32 GET_DAYS_PASSED ();

            
            /// <summary>
            ///   System.Nullable<System.Boolean> get_EmitDayStartOnce()
            /// </summary>
            /// <returns>struct System.Nullable<System.Boolean></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EmitDayStartOnce")]
            ///  extern System.Nullable<System.Boolean> GET_EMIT_DAY_START_ONCE ();

            
            /// <summary>
            ///   System.String get_FileName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FileName")]
            ///  extern nint GET_FILE_NAME ();

            
            /// <summary>
            ///   GameDifficulty get_GameDifficulty()
            /// </summary>
            /// <returns>enum GameDifficulty</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameDifficulty")]
            ///  extern GameDifficulty GET_GAME_DIFFICULTY ();

            
            /// <summary>
            ///   System.String get_GameVersion()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameVersion")]
            ///  extern nint GET_GAME_VERSION ();

            
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String,Inventory> get_GlobalInventories()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String,Inventory></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GlobalInventories")]
            ///  extern nint GET_GLOBAL_INVENTORIES ();

            
            /// <summary>
            ///   GlobalStates get_GlobalStates()
            /// </summary>
            /// <returns>class GlobalStates</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GlobalStates")]
            ///  extern nint GET_GLOBAL_STATES ();

            
            /// <summary>
            ///   System.String get_HeaderFileName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HeaderFileName")]
            ///  extern nint GET_HEADER_FILE_NAME ();

            
            /// <summary>
            ///   System.DateTime get_LastPlayedAt()
            /// </summary>
            /// <returns>struct System.DateTime</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LastPlayedAt")]
            ///  extern System.DateTime GET_LAST_PLAYED_AT ();

            
            /// <summary>
            ///   SemanticVersion get_LastPlayedAtVersion()
            /// </summary>
            /// <returns>class SemanticVersion</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LastPlayedAtVersion")]
            ///  extern nint GET_LAST_PLAYED_AT_VERSION ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Level> get_Levels()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Level></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Levels")]
            ///  extern nint GET_LEVELS ();

            
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String,Level> get_LevelsByName()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String,Level></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LevelsByName")]
            ///  extern nint GET_LEVELS_BY_NAME ();

            
            /// <summary>
            ///   System.Nullable<System.Int32> get_m_maxSharedID()
            /// </summary>
            /// <returns>struct System.Nullable<System.Int32></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_m_maxSharedID")]
            ///  extern System.Nullable<System.Int32> GET_M_MAX_SHARED_ID ();

            
            /// <summary>
            ///   System.DateTime get_MigratedAt()
            /// </summary>
            /// <returns>struct System.DateTime</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MigratedAt")]
            ///  extern System.DateTime GET_MIGRATED_AT ();

            
            /// <summary>
            ///   SemanticVersion get_MigratedAtVersion()
            /// </summary>
            /// <returns>class SemanticVersion</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MigratedAtVersion")]
            ///  extern nint GET_MIGRATED_AT_VERSION ();

            
            /// <summary>
            ///   System.String get_Name()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Name")]
            ///  extern nint GET_NAME ();

            
            /// <summary>
            ///   System.Collections.Generic.List<NPC> get_NPCs()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<NPC></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_NPCs")]
            ///  extern nint GET_NP_CS ();

            
            /// <summary>
            ///   System.Collections.Generic.List<PlayerData> get_Players()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PlayerData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Players")]
            ///  extern nint GET_PLAYERS ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Quest> get_Quests()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Quest></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Quests")]
            ///  extern nint GET_QUESTS ();

            
            /// <summary>
            ///   System.Boolean get_SerializeAllNPCS()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SerializeAllNPCS")]
            ///  extern System.Boolean GET_SERIALIZE_ALL_NPCS ();

            
            /// <summary>
            ///   System.Collections.Generic.List<NPC> get_SerializedNPCs()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<NPC></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SerializedNPCs")]
            ///  extern nint GET_SERIALIZED_NP_CS ();

            
            /// <summary>
            ///   Inventory get_SharedInventory()
            /// </summary>
            /// <returns>class Inventory</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SharedInventory")]
            ///  extern nint GET_SHARED_INVENTORY ();

            
            /// <summary>
            ///   System.Nullable<System.TimeSpan> get_TimeOfDay()
            /// </summary>
            /// <returns>struct System.Nullable<System.TimeSpan></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TimeOfDay")]
            ///  extern System.Nullable<System.TimeSpan> GET_TIME_OF_DAY ();

            
            /// <summary>
            ///   System.Collections.Generic.List<VehicleData> get_Vehicles()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<VehicleData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Vehicles")]
            ///  extern nint GET_VEHICLES ();

            
            /// <summary>
            ///   System.Int32 get_WeatherPresetIndex()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WeatherPresetIndex")]
            ///  extern System.Int32 GET_WEATHER_PRESET_INDEX ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Level> GetAllLevels(LevelFilter[] levelsToExclude)
            /// </summary>
            /// <param name="levelsToExclude">class LevelFilter[]</param>
            /// <returns>class System.Collections.Generic.List<Level></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAllLevels")]
            ///  extern nint GET_ALL_LEVELS (nint levelsToExclude);

            
            /// <summary>
            ///   T GetDataForObjectID(Unity.Mathematics.int4 id)
            /// </summary>
            /// <param name="id">struct Unity.Mathematics.int4</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDataForObjectID")]
            ///  extern nint GET_DATA_FOR_OBJECT_ID (Unity.Mathematics.int4 id);

            
            /// <summary>
            ///   Inventory GetGlobalInventory(System.String name, System.Int32 size, System.Boolean autoGrow, System.Boolean autoDestroyEmptyStacks, System.Boolean useMaxStackSize, System.Boolean overrideIfExists)
            /// </summary>
            /// <param name="name">class System.String</param>
            /// <param name="size">struct System.Int32</param>
            /// <param name="autoGrow">struct System.Boolean</param>
            /// <param name="autoDestroyEmptyStacks">struct System.Boolean</param>
            /// <param name="useMaxStackSize">struct System.Boolean</param>
            /// <param name="overrideIfExists">struct System.Boolean</param>
            /// <returns>class Inventory</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGlobalInventory")]
            ///  extern nint GET_GLOBAL_INVENTORY (nint name, System.Int32 size, System.Boolean autoGrow, System.Boolean autoDestroyEmptyStacks, System.Boolean useMaxStackSize, System.Boolean overrideIfExists);

            
            /// <summary>
            ///   System.Int32 GetNextSharedItemID()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetNextSharedItemID")]
            ///  extern System.Int32 GET_NEXT_SHARED_ITEM_ID ();

            
            /// <summary>
            ///   T GetOrCreateDataForObjectID(Unity.Mathematics.int4 id, System.Func<T> createInstanceIfNoneFound)
            /// </summary>
            /// <param name="id">struct Unity.Mathematics.int4</param>
            /// <param name="createInstanceIfNoneFound">class System.Func<T></param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetOrCreateDataForObjectID")]
            ///  extern nint GET_OR_CREATE_DATA_FOR_OBJECT_ID (Unity.Mathematics.int4 id, nint createInstanceIfNoneFound);

            
            /// <summary>
            ///   System.TimeSpan GetTotalTime()
            /// </summary>
            /// <returns>struct System.TimeSpan</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTotalTime")]
            ///  extern System.TimeSpan GET_TOTAL_TIME ();

            
            /// <summary>
            ///   System.Boolean IsValid()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsValid")]
            ///  extern System.Boolean IS_VALID ();

            
            /// <summary>
            /// static  SaveGame LoadFromStreamEditor(System.IO.Stream stream)
            /// </summary>
            /// <param name="stream">abstract class System.IO.Stream</param>
            /// <returns>class SaveGame</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadFromStreamEditor")]
            /// static extern nint LOAD_FROM_STREAM_EDITOR (nint stream);

            
            /// <summary>
            ///   System.Byte[] MessagePackSaveData()
            /// </summary>
            /// <returns>class System.Byte[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MessagePackSaveData")]
            ///  extern nint MESSAGE_PACK_SAVE_DATA ();

            
            /// <summary>
            ///   System.Void OnAfterDeserialize()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnAfterDeserialize")]
            ///  extern void ON_AFTER_DESERIALIZE ();

            
            /// <summary>
            ///   System.Void OnBeforeSerialize()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnBeforeSerialize")]
            ///  extern void ON_BEFORE_SERIALIZE ();

            
            /// <summary>
            ///   System.Void RemoveDataForObjectID(Unity.Mathematics.int4 id)
            /// </summary>
            /// <param name="id">struct Unity.Mathematics.int4</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDataForObjectID")]
            ///  extern void REMOVE_DATA_FOR_OBJECT_ID (Unity.Mathematics.int4 id);

            
            /// <summary>
            ///   System.Void set_ConsoleEverOpened(System.Nullable<System.Boolean> value)
            /// </summary>
            /// <param name="value">struct System.Nullable<System.Boolean></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ConsoleEverOpened")]
            ///  extern void SET_CONSOLE_EVER_OPENED (System.Nullable<System.Boolean> value);

            
            /// <summary>
            ///   System.Void set_CreatedAt(System.DateTime value)
            /// </summary>
            /// <param name="value">struct System.DateTime</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_CreatedAt")]
            ///  extern void SET_CREATED_AT (System.DateTime value);

            
            /// <summary>
            ///   System.Void set_CreatedAtVersion(SemanticVersion value)
            /// </summary>
            /// <param name="value">class SemanticVersion</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_CreatedAtVersion")]
            ///  extern void SET_CREATED_AT_VERSION (nint value);

            
            /// <summary>
            ///   System.Void set_DataForObjectID(System.Collections.Generic.Dictionary<Unity.Mathematics.int4,GenericData> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.Dictionary<Unity.Mathematics.int4,GenericData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_DataForObjectID")]
            ///  extern void SET_DATA_FOR_OBJECT_ID (nint value);

            
            /// <summary>
            ///   System.Void set_DaysPassed(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_DaysPassed")]
            ///  extern void SET_DAYS_PASSED (System.Int32 value);

            
            /// <summary>
            ///   System.Void set_EmitDayStartOnce(System.Nullable<System.Boolean> value)
            /// </summary>
            /// <param name="value">struct System.Nullable<System.Boolean></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_EmitDayStartOnce")]
            ///  extern void SET_EMIT_DAY_START_ONCE (System.Nullable<System.Boolean> value);

            
            /// <summary>
            ///   System.Void set_GameVersion(System.String value)
            /// </summary>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_GameVersion")]
            ///  extern void SET_GAME_VERSION (nint value);

            
            /// <summary>
            ///   System.Void set_GlobalInventories(System.Collections.Generic.Dictionary<System.String,Inventory> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.Dictionary<System.String,Inventory></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_GlobalInventories")]
            ///  extern void SET_GLOBAL_INVENTORIES (nint value);

            
            /// <summary>
            ///   System.Void set_GlobalStates(GlobalStates value)
            /// </summary>
            /// <param name="value">class GlobalStates</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_GlobalStates")]
            ///  extern void SET_GLOBAL_STATES (nint value);

            
            /// <summary>
            ///   System.Void set_LastPlayedAt(System.DateTime value)
            /// </summary>
            /// <param name="value">struct System.DateTime</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_LastPlayedAt")]
            ///  extern void SET_LAST_PLAYED_AT (System.DateTime value);

            
            /// <summary>
            ///   System.Void set_LastPlayedAtVersion(SemanticVersion value)
            /// </summary>
            /// <param name="value">class SemanticVersion</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_LastPlayedAtVersion")]
            ///  extern void SET_LAST_PLAYED_AT_VERSION (nint value);

            
            /// <summary>
            ///   System.Void set_Levels(System.Collections.Generic.List<Level> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.List<Level></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Levels")]
            ///  extern void SET_LEVELS (nint value);

            
            /// <summary>
            ///   System.Void set_LevelsByName(System.Collections.Generic.Dictionary<System.String,Level> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.Dictionary<System.String,Level></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_LevelsByName")]
            ///  extern void SET_LEVELS_BY_NAME (nint value);

            
            /// <summary>
            ///   System.Void set_m_maxSharedID(System.Nullable<System.Int32> value)
            /// </summary>
            /// <param name="value">struct System.Nullable<System.Int32></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_m_maxSharedID")]
            ///  extern void SET_M_MAX_SHARED_ID (System.Nullable<System.Int32> value);

            
            /// <summary>
            ///   System.Void set_MigratedAt(System.DateTime value)
            /// </summary>
            /// <param name="value">struct System.DateTime</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_MigratedAt")]
            ///  extern void SET_MIGRATED_AT (System.DateTime value);

            
            /// <summary>
            ///   System.Void set_MigratedAtVersion(SemanticVersion value)
            /// </summary>
            /// <param name="value">class SemanticVersion</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_MigratedAtVersion")]
            ///  extern void SET_MIGRATED_AT_VERSION (nint value);

            
            /// <summary>
            ///   System.Void set_Name(System.String value)
            /// </summary>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Name")]
            ///  extern void SET_NAME (nint value);

            
            /// <summary>
            ///   System.Void set_NPCs(System.Collections.Generic.List<NPC> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.List<NPC></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_NPCs")]
            ///  extern void SET_NP_CS (nint value);

            
            /// <summary>
            ///   System.Void set_Players(System.Collections.Generic.List<PlayerData> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.List<PlayerData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Players")]
            ///  extern void SET_PLAYERS (nint value);

            
            /// <summary>
            ///   System.Void set_Quests(System.Collections.Generic.List<Quest> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.List<Quest></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Quests")]
            ///  extern void SET_QUESTS (nint value);

            
            /// <summary>
            ///   System.Void set_SerializeAllNPCS(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_SerializeAllNPCS")]
            ///  extern void SET_SERIALIZE_ALL_NPCS (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_SerializedNPCs(System.Collections.Generic.List<NPC> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.List<NPC></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_SerializedNPCs")]
            ///  extern void SET_SERIALIZED_NP_CS (nint value);

            
            /// <summary>
            ///   System.Void set_SharedInventory(Inventory value)
            /// </summary>
            /// <param name="value">class Inventory</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_SharedInventory")]
            ///  extern void SET_SHARED_INVENTORY (nint value);

            
            /// <summary>
            ///   System.Void set_TimeOfDay(System.Nullable<System.TimeSpan> value)
            /// </summary>
            /// <param name="value">struct System.Nullable<System.TimeSpan></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_TimeOfDay")]
            ///  extern void SET_TIME_OF_DAY (System.Nullable<System.TimeSpan> value);

            
            /// <summary>
            ///   System.Void set_Vehicles(System.Collections.Generic.List<VehicleData> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.List<VehicleData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Vehicles")]
            ///  extern void SET_VEHICLES (nint value);

            
            /// <summary>
            ///   System.Void set_WeatherPresetIndex(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_WeatherPresetIndex")]
            ///  extern void SET_WEATHER_PRESET_INDEX (System.Int32 value);

            
            /// <summary>
            ///   System.Void SetLastPlayed(System.String applicationVersion)
            /// </summary>
            /// <param name="applicationVersion">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLastPlayed")]
            ///  extern void SET_LAST_PLAYED (nint applicationVersion);

            
            /// <summary>
            ///   System.Void SetMigrated(SemanticVersion migratedAt)
            /// </summary>
            /// <param name="migratedAt">class SemanticVersion</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMigrated")]
            ///  extern void SET_MIGRATED (nint migratedAt);

            
            /// <summary>
            ///   System.Void UpdateDataForObjectID(Unity.Mathematics.int4 id, GenericData data)
            /// </summary>
            /// <param name="id">struct Unity.Mathematics.int4</param>
            /// <param name="data">abstract class GenericData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateDataForObjectID")]
            ///  extern void UPDATE_DATA_FOR_OBJECT_ID (Unity.Mathematics.int4 id, nint data);
            
            

            
            /// public static partial class Search_SaveGame
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}