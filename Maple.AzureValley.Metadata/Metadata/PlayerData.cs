
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
    /// class ["AzureValley".""."PlayerData"]
    /// [System.Object]
    /// [NPCInterest]=>[MessagePack.IMessagePackSerializationCallbackReceiver]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x020004D8U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [80, 108, 97, 121, 101, 114, 68, 97, 116, 97])]
                
    //  struct static System.Int32 INVENTORY_SLOT_COUNT
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"INVENTORY_SLOT_COUNT", "INVENTORY_SLOT_COUNT", true)]
            
    //  struct static System.Int32 HOTBAR_SLOT_SIZE
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"HOTBAR_SLOT_SIZE", "HOTBAR_SLOT_SIZE", true)]
            
    //  class static PlayerData <ClientBackupData>k__BackingField
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"<ClientBackupData>k__BackingField", "CLIENT_BACKUP_DATA", true)]
                
    // class 0x10 System.Collections.Generic.Dictionary<TokensData,System.Int32> numTokens
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"numTokens", "NUM_TOKENS")]
            
    // class 0x18 System.Collections.Generic.List<PerksData> perks
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"perks", "PERKS")]
            
    // class 0x20 Inventory inventory
      [MonoCollectorSearchFieldAttribute(typeof(Inventory.Ptr_Inventory),"inventory", "INVENTORY")]
            
    // class 0x28 PlayerStates PlayerStates
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"PlayerStates", "PLAYER_STATES")]
            
    // class 0x30 AutoUnlockTracker autoUnlocks
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"autoUnlocks", "AUTO_UNLOCKS")]
            
    // class 0x38 System.Collections.Generic.List<InventoryItemsData> unlockedBlueprints
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlockedBlueprints", "UNLOCKED_BLUEPRINTS")]
            
    // class 0x40 System.Collections.Generic.List<InventoryItemsData> unlockedShopItems
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlockedShopItems", "UNLOCKED_SHOP_ITEMS")]
            
    // class 0x48 System.Collections.Generic.List<System.String> TempleLockouts
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"TempleLockouts", "TEMPLE_LOCKOUTS")]
            
    // class 0x50 System.Collections.Generic.List<FoodsData> unlockedFoods
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlockedFoods", "UNLOCKED_FOODS")]
            
    // class 0x58 System.Collections.Generic.List<RecipesData> unlockedRecipes
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlockedRecipes", "UNLOCKED_RECIPES")]
            
    // class 0x60 System.String spawnLocation
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"spawnLocation", "SPAWN_LOCATION")]
            
    // class 0x68 Inventory petSlot
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"petSlot", "PET_SLOT")]
            
    // class 0x70 System.String PlayerID
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"PlayerID", "PLAYER_ID")]
            
    // class 0x78 System.Collections.Generic.List<InventoryItemsData> SeenItems
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"SeenItems", "SEEN_ITEMS")]
            
    // class 0x80 System.Collections.Generic.List<InventoryItemsData> SeenShopItems
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"SeenShopItems", "SEEN_SHOP_ITEMS")]
            
    // class 0x88 CharacterCreateData CharacterData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"CharacterData", "CHARACTER_DATA")]
            
    // class 0x90 System.String <CurrentLevelString>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<CurrentLevelString>k__BackingField", "CURRENT_LEVEL_STRING")]
            
    // class 0x98 System.Collections.Generic.List<System.String> <GlobalStateItemsReceived>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<GlobalStateItemsReceived>k__BackingField", "GLOBAL_STATE_ITEMS_RECEIVED")]
            
    // class 0xA0 System.Collections.Generic.List<Quest> <Quests>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Quests>k__BackingField", "QUESTS")]
            
    // class 0xA8 System.Collections.Generic.List<System.String> <TrackedQuests>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<TrackedQuests>k__BackingField", "TRACKED_QUESTS")]
            
    // class 0xB0 System.String <SavedSpawnLocation>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<SavedSpawnLocation>k__BackingField", "SAVED_SPAWN_LOCATION")]
            
    // class 0xB8 System.Collections.Generic.List<PlayerCheckpointData> <CheckpointData>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<CheckpointData>k__BackingField", "CHECKPOINT_DATA")]
            
    // class 0xC0 System.Collections.Generic.List<System.String> SeenCraftRecipes
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"SeenCraftRecipes", "SEEN_CRAFT_RECIPES")]
            
    // class 0xC8 AchievementStates AchievementStates
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"AchievementStates", "ACHIEVEMENT_STATES")]
            
    // class 0xD0 System.String <CurrentGesture>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<CurrentGesture>k__BackingField", "CURRENT_GESTURE")]
            
    // abstract class 0xD8 PlayerController <Instance>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Instance>k__BackingField", "INSTANCE")]
            
    // class 0xE0 TopDownTrackingCamera <Camera>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Camera>k__BackingField", "CAMERA")]
            
    // class 0xE8 System.Action<PlayerData> <OnInstanceCreated>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<OnInstanceCreated>k__BackingField", "ON_INSTANCE_CREATED")]
            
    // class 0xF0 System.Action<PlayerData> <OnInstanceDestroyed>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<OnInstanceDestroyed>k__BackingField", "ON_INSTANCE_DESTROYED")]
            
    // class 0xF8 PlayerData <CinematicPlayerData>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<CinematicPlayerData>k__BackingField", "CINEMATIC_PLAYER_DATA")]
            
    // class 0x100 System.Action<PlayerData> OnLoggedOut
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnLoggedOut", "ON_LOGGED_OUT")]
            
    // class 0x108 System.Action OnCharacterDataUpdated
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnCharacterDataUpdated", "ON_CHARACTER_DATA_UPDATED")]
            
    // class 0x110 System.Action<InventoryItemsData> OnShopItemSeen
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnShopItemSeen", "ON_SHOP_ITEM_SEEN")]
            
    // class 0x118 UnityEngine.GameObject m_gameObject
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_gameObject", "M_GAME_OBJECT")]
            
    // struct 0x120 System.Boolean IsSplitScreenPlayer
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"IsSplitScreenPlayer", "IS_SPLIT_SCREEN_PLAYER")]
            
    // struct 0x121 System.Boolean IsOnline
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"IsOnline", "IS_ONLINE")]
            
    // struct 0x124 UnityEngine.Color <PlayerColor>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(UnityEngine.Color),"<PlayerColor>k__BackingField", "PLAYER_COLOR")]
            
    // struct 0x134 LevelPosition <SavedPosition>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(LevelPosition),"<SavedPosition>k__BackingField", "SAVED_POSITION")]
            
    // struct 0x140 System.Boolean <DoesHaveSavedPosition>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<DoesHaveSavedPosition>k__BackingField", "DOES_HAVE_SAVED_POSITION")]
            
    // struct 0x144 System.Nullable<System.Int32> <AssignedColorIndex>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Nullable<System.Int32>),"<AssignedColorIndex>k__BackingField", "ASSIGNED_COLOR_INDEX")]
            
    // struct 0x14C System.Boolean <IsReadyToSleep>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<IsReadyToSleep>k__BackingField", "IS_READY_TO_SLEEP")]
            
    // struct 0x14D System.Boolean <IsSleeping>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<IsSleeping>k__BackingField", "IS_SLEEPING")]
            
    // struct 0x14E System.Boolean <GodMode>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<GodMode>k__BackingField", "GOD_MODE")]
            
    // struct 0x14F System.Boolean <IsCinematicPlayer>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<IsCinematicPlayer>k__BackingField", "IS_CINEMATIC_PLAYER")]
            
    // struct 0x150 System.Boolean <IsUsingWardrobe>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<IsUsingWardrobe>k__BackingField", "IS_USING_WARDROBE")]
    public partial class PlayerData
    { 
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "PlayerData";
        //public static byte[] Static_ClassName { get; } = [80, 108, 97, 121, 101, 114, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x020004D8U;



                    
        /// <summary>
        /// struct System.Int32 MaxPlayerColorID "12"
        /// </summary>
        /// public const System.Int32 MAX_PLAYER_COLOR_ID=>"12";
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_PlayerData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_PlayerData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_PlayerData obj) => obj._ptr;
            public static implicit operator bool(Ptr_PlayerData obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["AzureValley".""."PlayerData"]
        /// </summary>
        public partial class PlayerData
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
            ///   System.Void ActivateInstance()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ActivateInstance")]
            ///  extern void ACTIVATE_INSTANCE ();

            
            /// <summary>
            ///   System.Void add_OnCharacterDataUpdated(System.Action value)
            /// </summary>
            /// <param name="value">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnCharacterDataUpdated")]
            ///  extern void ADD_ON_CHARACTER_DATA_UPDATED (nint value);

            
            /// <summary>
            ///   System.Void add_OnLoggedOut(System.Action<PlayerData> value)
            /// </summary>
            /// <param name="value">class System.Action<PlayerData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnLoggedOut")]
            ///  extern void ADD_ON_LOGGED_OUT (nint value);

            
            /// <summary>
            ///   System.Void add_OnShopItemSeen(System.Action<InventoryItemsData> value)
            /// </summary>
            /// <param name="value">class System.Action<InventoryItemsData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnShopItemSeen")]
            ///  extern void ADD_ON_SHOP_ITEM_SEEN (nint value);

            
            /// <summary>
            ///   System.Void AddSeenShopItem(InventoryItemsData item)
            /// </summary>
            /// <param name="item">class InventoryItemsData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSeenShopItem")]
            ///  extern void ADD_SEEN_SHOP_ITEM (nint item);

            
            /// <summary>
            ///   System.Void ChangeLockoutStateOfTemple(System.String temple, System.Boolean shouldBeLockedOut)
            /// </summary>
            /// <param name="temple">class System.String</param>
            /// <param name="shouldBeLockedOut">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ChangeLockoutStateOfTemple")]
            ///  extern void CHANGE_LOCKOUT_STATE_OF_TEMPLE (nint temple, System.Boolean shouldBeLockedOut);

            
            /// <summary>
            ///   System.Void CopyFromClientData(PlayerData clientData)
            /// </summary>
            /// <param name="clientData">class PlayerData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CopyFromClientData")]
            ///  extern void COPY_FROM_CLIENT_DATA (nint clientData);

            
            /// <summary>
            ///   System.Void CreateCinematicInstance(LocalPlayerController localPlayer)
            /// </summary>
            /// <param name="localPlayer">class LocalPlayerController</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateCinematicInstance")]
            ///  extern void CREATE_CINEMATIC_INSTANCE (nint localPlayer);

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask CreateLocalInstance(DependencyChain chain)
            /// </summary>
            /// <param name="chain">class DependencyChain</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateLocalInstance")]
            ///  extern Cysharp.Threading.Tasks.UniTask CREATE_LOCAL_INSTANCE (nint chain);

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask CreateRemoteInstance(System.Boolean isNewPlayer)
            /// </summary>
            /// <param name="isNewPlayer">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateRemoteInstance")]
            ///  extern Cysharp.Threading.Tasks.UniTask CREATE_REMOTE_INSTANCE (System.Boolean isNewPlayer);

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask DestroyInstance()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyInstance")]
            ///  extern Cysharp.Threading.Tasks.UniTask DESTROY_INSTANCE ();

            
            /// <summary>
            ///   System.Nullable<System.Int32> get_AssignedColorIndex()
            /// </summary>
            /// <returns>struct System.Nullable<System.Int32></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AssignedColorIndex")]
            ///  extern System.Nullable<System.Int32> GET_ASSIGNED_COLOR_INDEX ();

            
            /// <summary>
            ///   TopDownTrackingCamera get_Camera()
            /// </summary>
            /// <returns>class TopDownTrackingCamera</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Camera")]
            ///  extern nint GET_CAMERA ();

            
            /// <summary>
            ///   System.Collections.Generic.List<PlayerCheckpointData> get_CheckpointData()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PlayerCheckpointData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CheckpointData")]
            ///  extern nint GET_CHECKPOINT_DATA ();

            
            /// <summary>
            ///   PlayerData get_CinematicPlayerData()
            /// </summary>
            /// <returns>class PlayerData</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CinematicPlayerData")]
            ///  extern nint GET_CINEMATIC_PLAYER_DATA ();

            
            /// <summary>
            /// static  PlayerData get_ClientBackupData()
            /// </summary>
            /// <returns>class PlayerData</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ClientBackupData")]
            /// static extern nint GET_CLIENT_BACKUP_DATA ();

            
            /// <summary>
            ///   System.String get_CurrentGesture()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CurrentGesture")]
            ///  extern nint GET_CURRENT_GESTURE ();

            
            /// <summary>
            ///   System.String get_CurrentLevelString()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CurrentLevelString")]
            ///  extern nint GET_CURRENT_LEVEL_STRING ();

            
            /// <summary>
            ///   System.Boolean get_DoesHaveSavedPosition()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DoesHaveSavedPosition")]
            ///  extern System.Boolean GET_DOES_HAVE_SAVED_POSITION ();

            
            /// <summary>
            ///   System.Boolean get_ExistsInLevel()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ExistsInLevel")]
            ///  extern System.Boolean GET_EXISTS_IN_LEVEL ();

            
            /// <summary>
            ///   System.Collections.Generic.List<System.String> get_GlobalStateItemsReceived()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GlobalStateItemsReceived")]
            ///  extern nint GET_GLOBAL_STATE_ITEMS_RECEIVED ();

            
            /// <summary>
            ///   System.Boolean get_GodMode()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GodMode")]
            ///  extern System.Boolean GET_GOD_MODE ();

            
            /// <summary>
            ///   System.Boolean get_HasAuthority()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HasAuthority")]
            ///  extern System.Boolean GET_HAS_AUTHORITY ();

            
            /// <summary>
            ///   PlayerController get_Instance()
            /// </summary>
            /// <returns>abstract class PlayerController</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Instance")]
            ///  extern nint GET_INSTANCE ();

            
            /// <summary>
            ///   System.Boolean get_IsCinematicPlayer()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsCinematicPlayer")]
            ///  extern System.Boolean GET_IS_CINEMATIC_PLAYER ();

            
            /// <summary>
            ///   System.Boolean get_IsReadyToSleep()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsReadyToSleep")]
            ///  extern System.Boolean GET_IS_READY_TO_SLEEP ();

            
            /// <summary>
            ///   System.Boolean get_IsSleeping()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsSleeping")]
            ///  extern System.Boolean GET_IS_SLEEPING ();

            
            /// <summary>
            ///   System.Boolean get_IsUsingWardrobe()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsUsingWardrobe")]
            ///  extern System.Boolean GET_IS_USING_WARDROBE ();

            
            /// <summary>
            ///   LocalPlayerController get_LocalInstance()
            /// </summary>
            /// <returns>class LocalPlayerController</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LocalInstance")]
            ///  extern nint GET_LOCAL_INSTANCE ();

            
            /// <summary>
            ///   System.Int32 get_money()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_money")]
            ///  extern System.Int32 GET_MONEY ();

            
            /// <summary>
            ///   System.Action<PlayerData> get_OnInstanceCreated()
            /// </summary>
            /// <returns>class System.Action<PlayerData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnInstanceCreated")]
            ///  extern nint GET_ON_INSTANCE_CREATED ();

            
            /// <summary>
            ///   System.Action<PlayerData> get_OnInstanceDestroyed()
            /// </summary>
            /// <returns>class System.Action<PlayerData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnInstanceDestroyed")]
            ///  extern nint GET_ON_INSTANCE_DESTROYED ();

            
            /// <summary>
            ///   UnityEngine.Color get_PlayerColor()
            /// </summary>
            /// <returns>struct UnityEngine.Color</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerColor")]
            ///  extern UnityEngine.Color GET_PLAYER_COLOR ();

            
            /// <summary>
            ///   System.String get_PlayerName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerName")]
            ///  extern nint GET_PLAYER_NAME ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Quest> get_Quests()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Quest></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Quests")]
            ///  extern nint GET_QUESTS ();

            
            /// <summary>
            ///   LevelPosition get_SavedPosition()
            /// </summary>
            /// <returns>struct LevelPosition</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SavedPosition")]
            ///  extern LevelPosition GET_SAVED_POSITION ();

            
            /// <summary>
            ///   System.String get_SavedSpawnLocation()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SavedSpawnLocation")]
            ///  extern nint GET_SAVED_SPAWN_LOCATION ();

            
            /// <summary>
            ///   System.Collections.Generic.List<System.String> get_TrackedQuests()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TrackedQuests")]
            ///  extern nint GET_TRACKED_QUESTS ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Quest> GetAllActiveIncompletedQuests()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Quest></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAllActiveIncompletedQuests")]
            ///  extern nint GET_ALL_ACTIVE_INCOMPLETED_QUESTS ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Quest> GetAllActiveOrCompletedQuests()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Quest></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAllActiveOrCompletedQuests")]
            ///  extern nint GET_ALL_ACTIVE_OR_COMPLETED_QUESTS ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Quest> GetAllActiveQuests()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Quest></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAllActiveQuests")]
            ///  extern nint GET_ALL_ACTIVE_QUESTS ();

            
            /// <summary>
            ///   Quest GetLastTrackedQuest()
            /// </summary>
            /// <returns>class Quest</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLastTrackedQuest")]
            ///  extern nint GET_LAST_TRACKED_QUEST ();

            
            /// <summary>
            ///   Quest GetQuest(System.String questID)
            /// </summary>
            /// <param name="questID">class System.String</param>
            /// <returns>class Quest</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetQuest")]
            ///  extern nint GET_QUEST (nint questID);

            
            /// <summary>
            ///   System.Void HostAssignColor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HostAssignColor")]
            ///  extern void HOST_ASSIGN_COLOR ();

            
            /// <summary>
            ///   System.Boolean IsLockedOutOf(System.String temple)
            /// </summary>
            /// <param name="temple">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsLockedOutOf")]
            ///  extern System.Boolean IS_LOCKED_OUT_OF (nint temple);

            
            /// <summary>
            ///   System.Void LeaveGame()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LeaveGame")]
            ///  extern void LEAVE_GAME ();

            
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
            ///   System.Void OnSharedInventoryItemAdded(ItemStack stack)
            /// </summary>
            /// <param name="stack">class ItemStack</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnSharedInventoryItemAdded")]
            ///  extern void ON_SHARED_INVENTORY_ITEM_ADDED (nint stack);

            
            /// <summary>
            ///   System.Void OnSharedInventoryItemRemoved(ItemStack removedStack, System.Int32 amount)
            /// </summary>
            /// <param name="removedStack">class ItemStack</param>
            /// <param name="amount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnSharedInventoryItemRemoved")]
            ///  extern void ON_SHARED_INVENTORY_ITEM_REMOVED (nint removedStack, System.Int32 amount);

            
            /// <summary>
            ///   System.Void remove_OnCharacterDataUpdated(System.Action value)
            /// </summary>
            /// <param name="value">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnCharacterDataUpdated")]
            ///  extern void REMOVE_ON_CHARACTER_DATA_UPDATED (nint value);

            
            /// <summary>
            ///   System.Void remove_OnLoggedOut(System.Action<PlayerData> value)
            /// </summary>
            /// <param name="value">class System.Action<PlayerData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnLoggedOut")]
            ///  extern void REMOVE_ON_LOGGED_OUT (nint value);

            
            /// <summary>
            ///   System.Void remove_OnShopItemSeen(System.Action<InventoryItemsData> value)
            /// </summary>
            /// <param name="value">class System.Action<InventoryItemsData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnShopItemSeen")]
            ///  extern void REMOVE_ON_SHOP_ITEM_SEEN (nint value);

            
            /// <summary>
            ///   System.Void set_AssignedColorIndex(System.Nullable<System.Int32> value)
            /// </summary>
            /// <param name="value">struct System.Nullable<System.Int32></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_AssignedColorIndex")]
            ///  extern void SET_ASSIGNED_COLOR_INDEX (System.Nullable<System.Int32> value);

            
            /// <summary>
            ///   System.Void set_Camera(TopDownTrackingCamera value)
            /// </summary>
            /// <param name="value">class TopDownTrackingCamera</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Camera")]
            ///  extern void SET_CAMERA (nint value);

            
            /// <summary>
            ///   System.Void set_CheckpointData(System.Collections.Generic.List<PlayerCheckpointData> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.List<PlayerCheckpointData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_CheckpointData")]
            ///  extern void SET_CHECKPOINT_DATA (nint value);

            
            /// <summary>
            ///   System.Void set_CinematicPlayerData(PlayerData value)
            /// </summary>
            /// <param name="value">class PlayerData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_CinematicPlayerData")]
            ///  extern void SET_CINEMATIC_PLAYER_DATA (nint value);

            
            /// <summary>
            /// static  System.Void set_ClientBackupData(PlayerData value)
            /// </summary>
            /// <param name="value">class PlayerData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ClientBackupData")]
            /// static extern void SET_CLIENT_BACKUP_DATA (nint value);

            
            /// <summary>
            ///   System.Void set_CurrentGesture(System.String value)
            /// </summary>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_CurrentGesture")]
            ///  extern void SET_CURRENT_GESTURE (nint value);

            
            /// <summary>
            ///   System.Void set_CurrentLevelString(System.String value)
            /// </summary>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_CurrentLevelString")]
            ///  extern void SET_CURRENT_LEVEL_STRING (nint value);

            
            /// <summary>
            ///   System.Void set_DoesHaveSavedPosition(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_DoesHaveSavedPosition")]
            ///  extern void SET_DOES_HAVE_SAVED_POSITION (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_GlobalStateItemsReceived(System.Collections.Generic.List<System.String> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.List<System.String></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_GlobalStateItemsReceived")]
            ///  extern void SET_GLOBAL_STATE_ITEMS_RECEIVED (nint value);

            
            /// <summary>
            ///   System.Void set_GodMode(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_GodMode")]
            ///  extern void SET_GOD_MODE (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_Instance(PlayerController value)
            /// </summary>
            /// <param name="value">abstract class PlayerController</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Instance")]
            ///  extern void SET_INSTANCE (nint value);

            
            /// <summary>
            ///   System.Void set_IsCinematicPlayer(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsCinematicPlayer")]
            ///  extern void SET_IS_CINEMATIC_PLAYER (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_IsReadyToSleep(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsReadyToSleep")]
            ///  extern void SET_IS_READY_TO_SLEEP (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_IsSleeping(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsSleeping")]
            ///  extern void SET_IS_SLEEPING (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_IsUsingWardrobe(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsUsingWardrobe")]
            ///  extern void SET_IS_USING_WARDROBE (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_money(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_money")]
            ///  extern void SET_MONEY (System.Int32 value);

            
            /// <summary>
            ///   System.Void set_OnInstanceCreated(System.Action<PlayerData> value)
            /// </summary>
            /// <param name="value">class System.Action<PlayerData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_OnInstanceCreated")]
            ///  extern void SET_ON_INSTANCE_CREATED (nint value);

            
            /// <summary>
            ///   System.Void set_OnInstanceDestroyed(System.Action<PlayerData> value)
            /// </summary>
            /// <param name="value">class System.Action<PlayerData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_OnInstanceDestroyed")]
            ///  extern void SET_ON_INSTANCE_DESTROYED (nint value);

            
            /// <summary>
            ///   System.Void set_PlayerColor(UnityEngine.Color value)
            /// </summary>
            /// <param name="value">struct UnityEngine.Color</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_PlayerColor")]
            ///  extern void SET_PLAYER_COLOR (UnityEngine.Color value);

            
            /// <summary>
            ///   System.Void set_Quests(System.Collections.Generic.List<Quest> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.List<Quest></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Quests")]
            ///  extern void SET_QUESTS (nint value);

            
            /// <summary>
            ///   System.Void set_SavedPosition(LevelPosition value)
            /// </summary>
            /// <param name="value">struct LevelPosition</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_SavedPosition")]
            ///  extern void SET_SAVED_POSITION (LevelPosition value);

            
            /// <summary>
            ///   System.Void set_SavedSpawnLocation(System.String value)
            /// </summary>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_SavedSpawnLocation")]
            ///  extern void SET_SAVED_SPAWN_LOCATION (nint value);

            
            /// <summary>
            ///   System.Void set_TrackedQuests(System.Collections.Generic.List<System.String> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.List<System.String></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_TrackedQuests")]
            ///  extern void SET_TRACKED_QUESTS (nint value);

            
            /// <summary>
            ///   System.Void SetCharacterData(CharacterCreateData data)
            /// </summary>
            /// <param name="data">class CharacterCreateData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCharacterData")]
            ///  extern void SET_CHARACTER_DATA (nint data);

            
            /// <summary>
            ///   System.Void SyncSharedInventory()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SyncSharedInventory")]
            ///  extern void SYNC_SHARED_INVENTORY ();

            
            /// <summary>
            ///   System.Void UpdateSpawnLocation()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateSpawnLocation")]
            ///  extern void UPDATE_SPAWN_LOCATION ();
            
            

            
            /// public static partial class Search_PlayerData
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}