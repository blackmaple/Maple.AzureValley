
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
    /// class ["AzureValley".""."LocalPlayerController"]
    /// [PlayerController]=>[PlayerBehaviour]=>[BaseBehaviour]=>[UnityEngine.MonoBehaviour]=>[UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// [IUnlockReceiver]=>[IControlMode]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x0200047CU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [76, 111, 99, 97, 108, 80, 108, 97, 121, 101, 114, 67, 111, 110, 116, 114, 111, 108, 108, 101, 114])]
                
    //  class static System.Collections.Generic.Dictionary<System.Type,System.Reflection.MethodInfo[]> m_mask
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"m_mask", "M_MASK", true)]
            
    //  struct static System.Int32 OffsetOfInstanceIDInCPlusPlusObject
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"OffsetOfInstanceIDInCPlusPlusObject", "OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT", true)]
                
    // struct 0x10 System.IntPtr m_CachedPtr
    // [MonoCollectorSearchFieldAttribute(typeof(System.IntPtr),"m_CachedPtr", "M_CACHED_PTR")]
            
    // class 0x18 System.Action[] m_events
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_events", "M_EVENTS")]
            
    // struct 0x20 System.Int32 UniqueScriptID
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"UniqueScriptID", "UNIQUE_SCRIPT_ID")]
            
    // struct 0x24 System.Boolean m_eventsEnabled
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_eventsEnabled", "M_EVENTS_ENABLED")]
            
    // abstract class 0x28 PlayerController <Player>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Player>k__BackingField", "PLAYER")]
            
    // class 0x30 PlayerData <Data>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Data>k__BackingField", "DATA")]
            
    // class 0x38 GameUI <GameUI>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<GameUI>k__BackingField", "GAME_UI")]
            
    // class 0x40 TopDownTrackingCamera <TrackingCamera>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<TrackingCamera>k__BackingField", "TRACKING_CAMERA")]
            
    // class 0x48 Pawn m_pawn
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_pawn", "M_PAWN")]
            
    // class 0x50 TutorialController m_tutorialController
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_tutorialController", "M_TUTORIAL_CONTROLLER")]
            
    // class 0x58 IngameCutsceneController m_cutsceneController
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_cutsceneController", "M_CUTSCENE_CONTROLLER")]
            
    // class 0x60 FXTrigger m_onPickupFX
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_onPickupFX", "M_ON_PICKUP_FX")]
            
    // class 0x68 FXTrigger m_onNewBlueprintOrRecipe
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_onNewBlueprintOrRecipe", "M_ON_NEW_BLUEPRINT_OR_RECIPE")]
            
    // class 0x70 FXTrigger m_onNewToolFX
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_onNewToolFX", "M_ON_NEW_TOOL_FX")]
            
    // class 0x78 FXTrigger m_onSpawnLumaFX
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_onSpawnLumaFX", "M_ON_SPAWN_LUMA_FX")]
            
    // class 0x80 FXTrigger m_onDespawnLumaFX
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_onDespawnLumaFX", "M_ON_DESPAWN_LUMA_FX")]
            
    // class 0x88 FXTrigger m_onSandMinedFX
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_onSandMinedFX", "M_ON_SAND_MINED_FX")]
            
    // class 0x90 FXTrigger m_onHurt
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_onHurt", "M_ON_HURT")]
            
    // class 0x98 FXTrigger m_onPlayGesture
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_onPlayGesture", "M_ON_PLAY_GESTURE")]
            
    // class 0xA0 System.Action <OnMovedWithinLevel>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<OnMovedWithinLevel>k__BackingField", "ON_MOVED_WITHIN_LEVEL")]
            
    // class 0xA8 System.Action<Level> <BeforeLevelChanged>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<BeforeLevelChanged>k__BackingField", "BEFORE_LEVEL_CHANGED")]
            
    // class 0xB0 System.Action<Level> <OnLevelChanged>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<OnLevelChanged>k__BackingField", "ON_LEVEL_CHANGED")]
            
    // class 0xB8 System.Action<PlayerController,Level> <OnAfterLevelChanged>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<OnAfterLevelChanged>k__BackingField", "ON_AFTER_LEVEL_CHANGED")]
            
    // class 0xC0 System.Action<InventoryItemsData> <OnChangeSeen>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<OnChangeSeen>k__BackingField", "ON_CHANGE_SEEN")]
            
    // class 0xC8 System.Action<RecipesData> <OnChangeRecipeSeen>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<OnChangeRecipeSeen>k__BackingField", "ON_CHANGE_RECIPE_SEEN")]
            
    // class 0xD0 System.Action<BuffInstance> <OnBuffAdded>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<OnBuffAdded>k__BackingField", "ON_BUFF_ADDED")]
            
    // class 0xD8 System.Action<BuffInstance> <OnBuffRemoved>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<OnBuffRemoved>k__BackingField", "ON_BUFF_REMOVED")]
            
    // class 0xE0 System.Action<PlayerController,MagneticLoot> <OnMagneticLootPickedUp>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<OnMagneticLootPickedUp>k__BackingField", "ON_MAGNETIC_LOOT_PICKED_UP")]
            
    // class 0xE8 PlayerInventory <PlayerInventory>k__BackingField
      [MonoCollectorSearchFieldAttribute(typeof(PlayerInventory.Ptr_PlayerInventory),"<PlayerInventory>k__BackingField", "PLAYER_INVENTORY")]
            
    // class 0xF0 Level <CurrentLevel>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<CurrentLevel>k__BackingField", "CURRENT_LEVEL")]
            
    // class 0xF8 Level <TargetLevel>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<TargetLevel>k__BackingField", "TARGET_LEVEL")]
            
    // class 0x100 System.Collections.Generic.List<BuffInstance> <Buffs>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Buffs>k__BackingField", "BUFFS")]
            
    // class 0x108 System.Action<LevelPosition> OnPlayerTeleported
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnPlayerTeleported", "ON_PLAYER_TELEPORTED")]
            
    // class 0x110 Carryable m_carrying
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_carrying", "M_CARRYING")]
            
    // class 0x118 InventoryItem <TemporaryTool>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<TemporaryTool>k__BackingField", "TEMPORARY_TOOL")]
            
    // class 0x120 AtRiskLootCollector m_atRiskLootCollector
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_atRiskLootCollector", "M_AT_RISK_LOOT_COLLECTOR")]
            
    // struct 0x128 System.Boolean <IsBusyFishing>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<IsBusyFishing>k__BackingField", "IS_BUSY_FISHING")]
            
    // struct 0x129 System.Boolean <IsBusySwitchingLevel>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<IsBusySwitchingLevel>k__BackingField", "IS_BUSY_SWITCHING_LEVEL")]
            
    // struct 0x12A System.Boolean <IsBusySwitchingTempleRooms>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<IsBusySwitchingTempleRooms>k__BackingField", "IS_BUSY_SWITCHING_TEMPLE_ROOMS")]
            
    // struct 0x12C System.Int32 <SelectedItemIndex>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"<SelectedItemIndex>k__BackingField", "SELECTED_ITEM_INDEX")]
            
    // struct 0x130 System.Boolean <IsInCutscene>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<IsInCutscene>k__BackingField", "IS_IN_CUTSCENE")]
            
    // struct 0x131 System.Boolean <IsReadyToEndDay>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<IsReadyToEndDay>k__BackingField", "IS_READY_TO_END_DAY")]
            
    // struct 0x132 System.Boolean <IsReadyToQuit>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<IsReadyToQuit>k__BackingField", "IS_READY_TO_QUIT")]
            
    // struct 0x133 System.Boolean <IsDead>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<IsDead>k__BackingField", "IS_DEAD")]
            
    // struct 0x134 System.Boolean <ReadyToKickOffLeech>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<ReadyToKickOffLeech>k__BackingField", "READY_TO_KICK_OFF_LEECH")]
            
    // struct 0x135 System.Boolean <IsHookedToPushPullObject>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<IsHookedToPushPullObject>k__BackingField", "IS_HOOKED_TO_PUSH_PULL_OBJECT")]
            
    // class 0x138 System.Action<System.Int32> OnMoneyValueChanged
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnMoneyValueChanged", "ON_MONEY_VALUE_CHANGED")]
            
    // class 0x140 System.Action<RecipesData> OnRecipeUnlocked
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnRecipeUnlocked", "ON_RECIPE_UNLOCKED")]
            
    // class 0x148 System.Action<System.Boolean> OnCutsceneStatusChanged
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnCutsceneStatusChanged", "ON_CUTSCENE_STATUS_CHANGED")]
            
    // class 0x150 System.Action<InventoryItem> OnItemThrown
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnItemThrown", "ON_ITEM_THROWN")]
            
    // class 0x158 System.Action OnSelectedItemChanged
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnSelectedItemChanged", "ON_SELECTED_ITEM_CHANGED")]
            
    // class 0x160 System.Action<LocalPlayerController> OnPlayerReset
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnPlayerReset", "ON_PLAYER_RESET")]
            
    // class 0x168 System.Action<InventoryItemsData,System.Boolean> OnBlueprintUnlocked
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnBlueprintUnlocked", "ON_BLUEPRINT_UNLOCKED")]
            
    // class 0x170 System.Action<PlayerController,Unity.Mathematics.int2> OnInteractCallback
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnInteractCallback", "ON_INTERACT_CALLBACK")]
            
    // class 0x178 System.Action<System.Boolean,PlayerDeathType> OnDeathStateChanged
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnDeathStateChanged", "ON_DEATH_STATE_CHANGED")]
            
    // class 0x180 System.Action OnDayEndForPlayer
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnDayEndForPlayer", "ON_DAY_END_FOR_PLAYER")]
            
    // class 0x188 System.Collections.Generic.Dictionary<System.Guid,System.Single> m_holdStartTime
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_holdStartTime", "M_HOLD_START_TIME")]
            
    // class 0x190 System.Collections.Generic.Dictionary<System.Guid,System.Boolean> m_isValidHoldInteraction
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_isValidHoldInteraction", "M_IS_VALID_HOLD_INTERACTION")]
            
    // class 0x198 System.String <ActiveDevice>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<ActiveDevice>k__BackingField", "ACTIVE_DEVICE")]
            
    // class 0x1A0 UnityEngine.Transform m_heldItemBone
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_heldItemBone", "M_HELD_ITEM_BONE")]
            
    // class 0x1A8 TileHighlight m_highlighter
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_highlighter", "M_HIGHLIGHTER")]
            
    // class 0x1B0 UnityEngine.AudioClip m_failSound
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_failSound", "M_FAIL_SOUND")]
            
    // class 0x1B8 LevelFilter m_blockIdleSwingIn
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_blockIdleSwingIn", "M_BLOCK_IDLE_SWING_IN")]
            
    // class 0x1C0 UnityEngine.Behaviour[] toDisableWhileSwitchingLevels
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"toDisableWhileSwitchingLevels", "TO_DISABLE_WHILE_SWITCHING_LEVELS")]
            
    // class 0x1C8 UnityEngine.Localization.LocalizedString m_consumeItemString
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_consumeItemString", "M_CONSUME_ITEM_STRING")]
            
    // class 0x1D0 UnityEngine.InputSystem.InputActionReference m_consumeItemButton
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_consumeItemButton", "M_CONSUME_ITEM_BUTTON")]
            
    // class 0x1D8 UnityEngine.Localization.LocalizedString m_throwPotionString
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_throwPotionString", "M_THROW_POTION_STRING")]
            
    // class 0x1E0 UnityEngine.InputSystem.InputActionReference m_throwPotionButton
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_throwPotionButton", "M_THROW_POTION_BUTTON")]
            
    // class 0x1E8 UnityEngine.Localization.LocalizedString m_useItemString
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_useItemString", "M_USE_ITEM_STRING")]
            
    // class 0x1F0 UnityEngine.InputSystem.InputActionReference m_useItemButton
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_useItemButton", "M_USE_ITEM_BUTTON")]
            
    // class 0x1F8 UnityEngine.Localization.LocalizedString m_cancelTemporaryItemString
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_cancelTemporaryItemString", "M_CANCEL_TEMPORARY_ITEM_STRING")]
            
    // class 0x200 UnityEngine.InputSystem.InputActionReference m_cancelButton
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_cancelButton", "M_CANCEL_BUTTON")]
            
    // class 0x208 System.Collections.Generic.List<ItemFilter> m_showWarpieOnce
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_showWarpieOnce", "M_SHOW_WARPIE_ONCE")]
            
    // class 0x210 System.Collections.Generic.List<ItemFilter> m_showWarpieAlways
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_showWarpieAlways", "M_SHOW_WARPIE_ALWAYS")]
            
    // class 0x218 System.Action<LevelPosition> OnPlayerTeleported
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnPlayerTeleported", "ON_PLAYER_TELEPORTED")]
            
    // class 0x220 SprayController m_sprayController
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_sprayController", "M_SPRAY_CONTROLLER")]
            
    // class 0x228 PlayerFishingBehavior m_fishingController
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_fishingController", "M_FISHING_CONTROLLER")]
            
    // class 0x230 ThrowControllerAim m_throwController
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_throwController", "M_THROW_CONTROLLER")]
            
    // class 0x238 TileSelector m_tileSelector
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_tileSelector", "M_TILE_SELECTOR")]
            
    // class 0x240 UnityEngine.InputSystem.PlayerInput m_input
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_input", "M_INPUT")]
            
    // class 0x248 TargetedTile m_targetedTile
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_targetedTile", "M_TARGETED_TILE")]
            
    // class 0x250 UnityEngine.InputSystem.InputActionMap m_playerActions
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_playerActions", "M_PLAYER_ACTIONS")]
            
    // class 0x258 Cysharp.Threading.Tasks.UniTaskCompletionSource<System.Boolean> m_showingToolAnimatingCompletionResult
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_showingToolAnimatingCompletionResult", "M_SHOWING_TOOL_ANIMATING_COMPLETION_RESULT")]
            
    // class 0x260 System.Collections.Generic.List<System.Int32> m_newItems
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_newItems", "M_NEW_ITEMS")]
            
    // class 0x268 Stopwatch m_heldStopwatch
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_heldStopwatch", "M_HELD_STOPWATCH")]
            
    // class 0x270 UnityEngine.GameObject m_oldTarget
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_oldTarget", "M_OLD_TARGET")]
            
    // class 0x278 ControlContextManager m_controlContext
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_controlContext", "M_CONTROL_CONTEXT")]
            
    // class 0x280 UnityEngine.Transform m_originalRootParent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_originalRootParent", "M_ORIGINAL_ROOT_PARENT")]
            
    // class 0x288 System.Threading.CancellationTokenSource m_warpieCancellationToken
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_warpieCancellationToken", "M_WARPIE_CANCELLATION_TOKEN")]
            
    // class 0x290 Timer m_levelSwitchInvulnerabilityTimer
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_levelSwitchInvulnerabilityTimer", "M_LEVEL_SWITCH_INVULNERABILITY_TIMER")]
            
    // class 0x298 FloatingContextHintsUI m_hintsUI
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_hintsUI", "M_HINTS_UI")]
            
    // class 0x2A0 System.Collections.Generic.List<PlayerController.PlayerFreeze> m_freeze
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_freeze", "M_FREEZE")]
            
    // class 0x2A8 PlayerController.PlayerFreeze m_loadingFreeze
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_loadingFreeze", "M_LOADING_FREEZE")]
            
    // struct 0x2B0 System.Single <HoseSpeedModifier>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"<HoseSpeedModifier>k__BackingField", "HOSE_SPEED_MODIFIER")]
            
    // struct 0x2B4 System.Boolean <DoFirstTimeInitialize>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<DoFirstTimeInitialize>k__BackingField", "DO_FIRST_TIME_INITIALIZE")]
            
    // struct 0x2B5 System.Boolean <ReadyToSleep>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<ReadyToSleep>k__BackingField", "READY_TO_SLEEP")]
            
    // struct 0x2B6 System.Boolean <HasHostFinishedLoadingCurrentLevel>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<HasHostFinishedLoadingCurrentLevel>k__BackingField", "HAS_HOST_FINISHED_LOADING_CURRENT_LEVEL")]
            
    // struct 0x2B7 System.Boolean <IsWarpieActive>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<IsWarpieActive>k__BackingField", "IS_WARPIE_ACTIVE")]
            
    // struct 0x2B8 System.Boolean <WarpieEnabled>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<WarpieEnabled>k__BackingField", "WARPIE_ENABLED")]
            
    // struct 0x2B9 System.Boolean <IsPerformingUnstuck>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<IsPerformingUnstuck>k__BackingField", "IS_PERFORMING_UNSTUCK")]
            
    // struct 0x2BA System.Boolean <PlaySafeFXNextWarpie>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<PlaySafeFXNextWarpie>k__BackingField", "PLAY_SAFE_FX_NEXT_WARPIE")]
            
    // struct 0x2BC System.Single m_deadzone
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"m_deadzone", "M_DEADZONE")]
            
    // struct 0x2C0 System.Single m_actionLockTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"m_actionLockTime", "M_ACTION_LOCK_TIME")]
            
    // struct 0x2C4 System.Single m_castDistance
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"m_castDistance", "M_CAST_DISTANCE")]
            
    // struct 0x2C8 System.Single m_selectionForwardOffset
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"m_selectionForwardOffset", "M_SELECTION_FORWARD_OFFSET")]
            
    // struct 0x2CC System.Single m_maxSelectionDistance
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"m_maxSelectionDistance", "M_MAX_SELECTION_DISTANCE")]
            
    // struct 0x2D0 System.Single m_AOERippleDelay
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"m_AOERippleDelay", "M_AOE_RIPPLE_DELAY")]
            
    // struct 0x2D4 System.Single m_AOEChargeTimePerStep
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"m_AOEChargeTimePerStep", "M_AOE_CHARGE_TIME_PER_STEP")]
            
    // struct 0x2D8 System.Single m_dropItemICDSeconds
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"m_dropItemICDSeconds", "M_DROP_ITEM_ICD_SECONDS")]
            
    // struct 0x2DC System.Single m_idleTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"m_idleTime", "M_IDLE_TIME")]
            
    // struct 0x2E0 System.Int32 m_lastItemIndex
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"m_lastItemIndex", "M_LAST_ITEM_INDEX")]
            
    // struct 0x2E4 System.Boolean m_interactHeld
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_interactHeld", "M_INTERACT_HELD")]
            
    // struct 0x2E8 System.Single m_finalHeldTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"m_finalHeldTime", "M_FINAL_HELD_TIME")]
            
    // struct 0x2EC System.Boolean m_cancelHeld
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_cancelHeld", "M_CANCEL_HELD")]
            
    // struct 0x2ED System.Boolean m_equippedItemChangedSinceStartOfAnimation
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_equippedItemChangedSinceStartOfAnimation", "M_EQUIPPED_ITEM_CHANGED_SINCE_START_OF_ANIMATION")]
            
    // struct 0x2F0 System.Int32 m_lastInteractionFrame
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"m_lastInteractionFrame", "M_LAST_INTERACTION_FRAME")]
            
    // struct 0x2F4 System.Boolean m_isWhipping
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_isWhipping", "M_IS_WHIPPING")]
            
    // struct 0x2F5 System.Boolean m_whipInputHeld
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_whipInputHeld", "M_WHIP_INPUT_HELD")]
            
    // struct 0x2F8 System.Single m_timeOfLastDamage
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"m_timeOfLastDamage", "M_TIME_OF_LAST_DAMAGE")]
            
    // struct 0x2FC System.Boolean m_isPressingNextItem
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_isPressingNextItem", "M_IS_PRESSING_NEXT_ITEM")]
            
    // struct 0x2FD System.Boolean m_isPressingPreviousItem
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_isPressingPreviousItem", "M_IS_PRESSING_PREVIOUS_ITEM")]
            
    // struct 0x300 System.Single m_waitedTimeToCycleItem
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"m_waitedTimeToCycleItem", "M_WAITED_TIME_TO_CYCLE_ITEM")]
            
    // struct 0x304 Unity.Mathematics.int2 m_interactionGravityTile
    // [MonoCollectorSearchFieldAttribute(typeof(Unity.Mathematics.int2),"m_interactionGravityTile", "M_INTERACTION_GRAVITY_TILE")]
    public partial class LocalPlayerController
    { 
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "LocalPlayerController";
        //public static byte[] Static_ClassName { get; } = [76, 111, 99, 97, 108, 80, 108, 97, 121, 101, 114, 67, 111, 110, 116, 114, 111, 108, 108, 101, 114];

        //public const uint Const_TypeToken = 0x0200047CU;



                    
        /// <summary>
        /// class System.String objectIsNullMessage "The Object you want to instantiate is null."
        /// </summary>
        /// public const nint OBJECT_IS_NULL_MESSAGE=>"The Object you want to instantiate is null.";
            
        /// <summary>
        /// class System.String cloneDestroyedMessage "Instantiate failed because the clone was destroyed during creati"
        /// </summary>
        /// public const nint CLONE_DESTROYED_MESSAGE=>"Instantiate failed because the clone was destroyed during creati";
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_LocalPlayerController(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_LocalPlayerController(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_LocalPlayerController obj) => obj._ptr;
            public static implicit operator bool(Ptr_LocalPlayerController obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["AzureValley".""."LocalPlayerController"]
        /// </summary>
        public partial class LocalPlayerController
        { 

            
            
            /// <summary>
            ///   System.Void <Awake>b__200_0()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Awake>b__200_0")]
            ///  extern void <AWAKE>B__200_0 ();

            
            /// <summary>
            ///   System.Void <FixedUpdate>b__206_0(IPlayerFocusListener l)
            /// </summary>
            /// <param name="l">interface IPlayerFocusListener</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<FixedUpdate>b__206_0")]
            ///  extern void <FIXED_UPDATE>B__206_0 (nint l);

            
            /// <summary>
            ///   System.Void <FixedUpdate>b__206_1(IPlayerFocusListener l)
            /// </summary>
            /// <param name="l">interface IPlayerFocusListener</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<FixedUpdate>b__206_1")]
            ///  extern void <FIXED_UPDATE>B__206_1 (nint l);

            
            /// <summary>
            ///   System.Void <Kill>b__157_0()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Kill>b__157_0")]
            ///  extern void <KILL>B__157_0 ();

            
            /// <summary>
            ///   System.Boolean <PlayerStretch>b__185_0()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<PlayerStretch>b__185_0")]
            ///  extern System.Boolean <PLAYER_STRETCH>B__185_0 ();

            
            /// <summary>
            ///   System.Void add_OnBlueprintUnlocked(System.Action<InventoryItemsData,System.Boolean> value)
            /// </summary>
            /// <param name="value">class System.Action<InventoryItemsData,System.Boolean></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnBlueprintUnlocked")]
            ///  extern void ADD_ON_BLUEPRINT_UNLOCKED (nint value);

            
            /// <summary>
            ///   System.Void add_OnCutsceneStatusChanged(System.Action<System.Boolean> value)
            /// </summary>
            /// <param name="value">class System.Action<System.Boolean></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnCutsceneStatusChanged")]
            ///  extern void ADD_ON_CUTSCENE_STATUS_CHANGED (nint value);

            
            /// <summary>
            ///   System.Void add_OnDayEndForPlayer(System.Action value)
            /// </summary>
            /// <param name="value">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnDayEndForPlayer")]
            ///  extern void ADD_ON_DAY_END_FOR_PLAYER (nint value);

            
            /// <summary>
            ///   System.Void add_OnDeathStateChanged(System.Action<System.Boolean,PlayerDeathType> value)
            /// </summary>
            /// <param name="value">class System.Action<System.Boolean,PlayerDeathType></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnDeathStateChanged")]
            ///  extern void ADD_ON_DEATH_STATE_CHANGED (nint value);

            
            /// <summary>
            ///   System.Void add_OnItemThrown(System.Action<InventoryItem> value)
            /// </summary>
            /// <param name="value">class System.Action<InventoryItem></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnItemThrown")]
            ///  extern void ADD_ON_ITEM_THROWN (nint value);

            
            /// <summary>
            ///   System.Void add_OnMoneyValueChanged(System.Action<System.Int32> value)
            /// </summary>
            /// <param name="value">class System.Action<System.Int32></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnMoneyValueChanged")]
            ///  extern void ADD_ON_MONEY_VALUE_CHANGED (nint value);

            
            /// <summary>
            ///   System.Void add_OnPlayerReset(System.Action<LocalPlayerController> value)
            /// </summary>
            /// <param name="value">class System.Action<LocalPlayerController></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnPlayerReset")]
            ///  extern void ADD_ON_PLAYER_RESET (nint value);

            
            /// <summary>
            ///   System.Void add_OnRecipeUnlocked(System.Action<RecipesData> value)
            /// </summary>
            /// <param name="value">class System.Action<RecipesData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnRecipeUnlocked")]
            ///  extern void ADD_ON_RECIPE_UNLOCKED (nint value);

            
            /// <summary>
            ///   System.Void AddBuff(BuffsData buffType)
            /// </summary>
            /// <param name="buffType">class BuffsData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBuff")]
            ///  extern void ADD_BUFF (nint buffType);

            
            /// <summary>
            ///   System.Void AddLoadingFreeze()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLoadingFreeze")]
            ///  extern void ADD_LOADING_FREEZE ();

            
            /// <summary>
            ///   System.Void AddSeenItem(InventoryItemsData item)
            /// </summary>
            /// <param name="item">class InventoryItemsData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSeenItem")]
            ///  extern void ADD_SEEN_ITEM (nint item);

            
            /// <summary>
            ///   System.Void AddSeenRecipe(RecipesData recipe)
            /// </summary>
            /// <param name="recipe">class RecipesData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSeenRecipe")]
            ///  extern void ADD_SEEN_RECIPE (nint recipe);

            
            /// <summary>
            ///   System.Void AddSeenShopItem(InventoryItemsData item)
            /// </summary>
            /// <param name="item">class InventoryItemsData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSeenShopItem")]
            ///  extern void ADD_SEEN_SHOP_ITEM (nint item);

            
            /// <summary>
            ///   System.ValueTuple<UnityEngine.Localization.LocalizedString,UnityEngine.InputSystem.InputActionReference> AddTileHandlersToTarget(TargetedTile currentTileTarget, Unity.Mathematics.int2 pos, System.Int32& currentTilePriority)
            /// </summary>
            /// <param name="currentTileTarget">class TargetedTile</param>
            /// <param name="pos">struct Unity.Mathematics.int2</param>
            /// <param name="currentTilePriority">struct System.Int32&</param>
            /// <returns>struct System.ValueTuple<UnityEngine.Localization.LocalizedString,UnityEngine.InputSystem.InputActionReference></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTileHandlersToTarget")]
            ///  extern System.ValueTuple<UnityEngine.Localization.LocalizedString,UnityEngine.InputSystem.InputActionReference> ADD_TILE_HANDLERS_TO_TARGET (nint currentTileTarget, Unity.Mathematics.int2 pos, System.Int32& currentTilePriority);

            
            /// <summary>
            ///   System.Void Animate(UnityEngine.InputSystem.InputActionReference type, InventoryItem item, TargetedTile interactingTile, PawnAnimationType animation, System.Action onApex, System.Action onWindup)
            /// </summary>
            /// <param name="type">class UnityEngine.InputSystem.InputActionReference</param>
            /// <param name="item">class InventoryItem</param>
            /// <param name="interactingTile">class TargetedTile</param>
            /// <param name="animation">enum PawnAnimationType</param>
            /// <param name="onApex">class System.Action</param>
            /// <param name="onWindup">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Animate")]
            ///  extern void ANIMATE (nint type, nint item, nint interactingTile, PawnAnimationType animation, nint onApex, nint onWindup);

            
            /// <summary>
            ///   System.Void BeginPlacement(WorldItemsData type, InventoryItemsData blueprint)
            /// </summary>
            /// <param name="type">class WorldItemsData</param>
            /// <param name="blueprint">class InventoryItemsData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BeginPlacement")]
            ///  extern void BEGIN_PLACEMENT (nint type, nint blueprint);

            
            /// <summary>
            ///   System.Void CancelHold(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelHold")]
            ///  extern void CANCEL_HOLD (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Boolean CanPlayerMove()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanPlayerMove")]
            ///  extern System.Boolean CAN_PLAYER_MOVE ();

            
            /// <summary>
            ///   System.Boolean CanPlayerRotate()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanPlayerRotate")]
            ///  extern System.Boolean CAN_PLAYER_ROTATE ();

            
            /// <summary>
            ///   System.Boolean CanThrowItem(InventoryItem item)
            /// </summary>
            /// <param name="item">class InventoryItem</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanThrowItem")]
            ///  extern System.Boolean CAN_THROW_ITEM (nint item);

            
            /// <summary>
            ///   System.Boolean CheckIfIsComponentAndEnabled(IPlayerFocusListener listener)
            /// </summary>
            /// <param name="listener">interface IPlayerFocusListener</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckIfIsComponentAndEnabled")]
            ///  extern System.Boolean CHECK_IF_IS_COMPONENT_AND_ENABLED (nint listener);

            
            /// <summary>
            /// static  System.Void CheckNullArgument(System.Object arg, System.String message)
            /// </summary>
            /// <param name="arg">class System.Object</param>
            /// <param name="message">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckNullArgument")]
            /// static extern void CHECK_NULL_ARGUMENT (nint arg, nint message);

            
            /// <summary>
            ///   System.Void CollectMagneticLoot(MagneticLoot magneticLoot)
            /// </summary>
            /// <param name="magneticLoot">class MagneticLoot</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CollectMagneticLoot")]
            ///  extern void COLLECT_MAGNETIC_LOOT (nint magneticLoot);

            
            /// <summary>
            /// static  System.Boolean CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs)
            /// </summary>
            /// <param name="lhs">class UnityEngine.Object</param>
            /// <param name="rhs">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareBaseObjects")]
            /// static extern System.Boolean COMPARE_BASE_OBJECTS (nint lhs, nint rhs);

            
            /// <summary>
            ///   System.Boolean CompareTag(System.String tag)
            /// </summary>
            /// <param name="tag">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTag")]
            ///  extern System.Boolean COMPARE_TAG (nint tag);

            
            /// <summary>
            /// static  System.Boolean CurrentThreadIsMainThread()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CurrentThreadIsMainThread")]
            /// static extern System.Boolean CURRENT_THREAD_IS_MAIN_THREAD ();

            
            /// <summary>
            ///   System.Void DeathStateChanged(System.Boolean isDead, PlayerDeathType type)
            /// </summary>
            /// <param name="isDead">struct System.Boolean</param>
            /// <param name="type">enum PlayerDeathType</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DeathStateChanged")]
            ///  extern void DEATH_STATE_CHANGED (System.Boolean isDead, PlayerDeathType type);

            
            /// <summary>
            ///   System.Void DisableGlobalEvents()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DisableGlobalEvents")]
            ///  extern void DISABLE_GLOBAL_EVENTS ();

            
            /// <summary>
            ///   System.Void DisplayCancelForTemporaryTool()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DisplayCancelForTemporaryTool")]
            ///  extern void DISPLAY_CANCEL_FOR_TEMPORARY_TOOL ();

            
            /// <summary>
            ///   System.Void DisplayHighlight()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DisplayHighlight")]
            ///  extern void DISPLAY_HIGHLIGHT ();

            
            /// <summary>
            ///   System.Void DoCameraRotateLogic()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DoCameraRotateLogic")]
            ///  extern void DO_CAMERA_ROTATE_LOGIC ();

            
            /// <summary>
            /// static  System.Boolean DoesObjectWithInstanceIDExist(System.Int32 instanceID)
            /// </summary>
            /// <param name="instanceID">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DoesObjectWithInstanceIDExist")]
            /// static extern System.Boolean DOES_OBJECT_WITH_INSTANCE_ID_EXIST (System.Int32 instanceID);

            
            /// <summary>
            ///   System.Boolean DoesWhipOverride()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DoesWhipOverride")]
            ///  extern System.Boolean DOES_WHIP_OVERRIDE ();

            
            /// <summary>
            ///   System.Void DoHoldingItemBehaviorLogic()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DoHoldingItemBehaviorLogic")]
            ///  extern void DO_HOLDING_ITEM_BEHAVIOR_LOGIC ();

            
            /// <summary>
            ///   System.Void DoMoveAndCameraRotateLogic()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DoMoveAndCameraRotateLogic")]
            ///  extern void DO_MOVE_AND_CAMERA_ROTATE_LOGIC ();

            
            /// <summary>
            /// static  System.Void DontDestroyOnLoad(UnityEngine.Object target)
            /// </summary>
            /// <param name="target">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DontDestroyOnLoad")]
            /// static extern void DONT_DESTROY_ON_LOAD (nint target);

            
            /// <summary>
            ///   System.Void DoTeleportToSpawn(Level level, System.String spawnpointNameOrCoords, System.Boolean isActuallySwitching)
            /// </summary>
            /// <param name="level">class Level</param>
            /// <param name="spawnpointNameOrCoords">class System.String</param>
            /// <param name="isActuallySwitching">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DoTeleportToSpawn")]
            ///  extern void DO_TELEPORT_TO_SPAWN (nint level, nint spawnpointNameOrCoords, System.Boolean isActuallySwitching);

            
            /// <summary>
            ///   System.Void EnableGlobalEvents()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnableGlobalEvents")]
            ///  extern void ENABLE_GLOBAL_EVENTS ();

            
            /// <summary>
            ///   System.Void EnsureRunningOnMainThread()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnsureRunningOnMainThread")]
            ///  extern void ENSURE_RUNNING_ON_MAIN_THREAD ();

            
            /// <summary>
            ///   System.Void EnterControlMode()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnterControlMode")]
            ///  extern void ENTER_CONTROL_MODE ();

            
            /// <summary>
            ///   System.Boolean Equals(System.Object other)
            /// </summary>
            /// <param name="other">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals")]
            ///  extern System.Boolean EQUALS (nint other);

            
            /// <summary>
            ///   System.Void ExecuteInteract(TargetedTile target, InventoryItem item, UnityEngine.InputSystem.InputActionReference type)
            /// </summary>
            /// <param name="target">class TargetedTile</param>
            /// <param name="item">class InventoryItem</param>
            /// <param name="type">class UnityEngine.InputSystem.InputActionReference</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExecuteInteract")]
            ///  extern void EXECUTE_INTERACT (nint target, nint item, nint type);

            
            /// <summary>
            ///   System.Void ExecuteTeleportWithFade(LevelPosition target, System.Action callbackAtBlack)
            /// </summary>
            /// <param name="target">struct LevelPosition</param>
            /// <param name="callbackAtBlack">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExecuteTeleportWithFade")]
            ///  extern void EXECUTE_TELEPORT_WITH_FADE (LevelPosition target, nint callbackAtBlack);

            
            /// <summary>
            ///   System.Void ExitControlMode()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExitControlMode")]
            ///  extern void EXIT_CONTROL_MODE ();

            
            /// <summary>
            /// static  UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID)
            /// </summary>
            /// <param name="instanceID">struct System.Int32</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectFromInstanceID")]
            /// static extern nint FIND_OBJECT_FROM_INSTANCE_ID (System.Int32 instanceID);

            
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfTypeAll")]
            /// static extern nint FIND_OBJECTS_OF_TYPE_ALL (nint type);

            
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfTypeIncludingAssets")]
            /// static extern nint FIND_OBJECTS_OF_TYPE_INCLUDING_ASSETS (nint type);

            
            /// <summary>
            /// static  UnityEngine.Object[] FindSceneObjectsOfType(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindSceneObjectsOfType")]
            /// static extern nint FIND_SCENE_OBJECTS_OF_TYPE (nint type);

            
            /// <summary>
            /// static  UnityEngine.Object ForceLoadFromInstanceID(System.Int32 instanceID)
            /// </summary>
            /// <param name="instanceID">struct System.Int32</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ForceLoadFromInstanceID")]
            /// static extern nint FORCE_LOAD_FROM_INSTANCE_ID (System.Int32 instanceID);

            
            /// <summary>
            ///   System.String get_ActiveDevice()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ActiveDevice")]
            ///  extern nint GET_ACTIVE_DEVICE ();

            
            /// <summary>
            ///   AtRiskLootCollector get_AtRiskLootCollector()
            /// </summary>
            /// <returns>class AtRiskLootCollector</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AtRiskLootCollector")]
            ///  extern nint GET_AT_RISK_LOOT_COLLECTOR ();

            
            /// <summary>
            ///   AutoUnlockTracker get_AutoUnlock()
            /// </summary>
            /// <returns>class AutoUnlockTracker</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AutoUnlock")]
            ///  extern nint GET_AUTO_UNLOCK ();

            
            /// <summary>
            ///   System.Action<Level> get_BeforeLevelChanged()
            /// </summary>
            /// <returns>class System.Action<Level></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_BeforeLevelChanged")]
            ///  extern nint GET_BEFORE_LEVEL_CHANGED ();

            
            /// <summary>
            ///   System.Collections.Generic.List<BuffInstance> get_Buffs()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<BuffInstance></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Buffs")]
            ///  extern nint GET_BUFFS ();

            
            /// <summary>
            ///   TopDownTrackingCamera get_Camera()
            /// </summary>
            /// <returns>class TopDownTrackingCamera</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Camera")]
            ///  extern nint GET_CAMERA ();

            
            /// <summary>
            ///   System.Boolean get_CanSwitchLevels()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CanSwitchLevels")]
            ///  extern System.Boolean GET_CAN_SWITCH_LEVELS ();

            
            /// <summary>
            ///   System.Boolean get_CanUnstuck()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CanUnstuck")]
            ///  extern System.Boolean GET_CAN_UNSTUCK ();

            
            /// <summary>
            ///   Carryable get_Carrying()
            /// </summary>
            /// <returns>class Carryable</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Carrying")]
            ///  extern nint GET_CARRYING ();

            
            /// <summary>
            ///   FloatingContextHintsUI get_ContextHints()
            /// </summary>
            /// <returns>class FloatingContextHintsUI</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ContextHints")]
            ///  extern nint GET_CONTEXT_HINTS ();

            
            /// <summary>
            ///   Level get_CurrentLevel()
            /// </summary>
            /// <returns>class Level</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CurrentLevel")]
            ///  extern nint GET_CURRENT_LEVEL ();

            
            /// <summary>
            ///   Level get_CurrentLevelWithCinematics()
            /// </summary>
            /// <returns>class Level</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CurrentLevelWithCinematics")]
            ///  extern nint GET_CURRENT_LEVEL_WITH_CINEMATICS ();

            
            /// <summary>
            ///   IngameCutsceneController get_CutsceneController()
            /// </summary>
            /// <returns>class IngameCutsceneController</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CutsceneController")]
            ///  extern nint GET_CUTSCENE_CONTROLLER ();

            
            /// <summary>
            ///   PlayerData get_Data()
            /// </summary>
            /// <returns>class PlayerData</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Data")]
            ///  extern nint GET_DATA ();

            
            /// <summary>
            ///   System.Boolean get_DoFirstTimeInitialize()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DoFirstTimeInitialize")]
            ///  extern System.Boolean GET_DO_FIRST_TIME_INITIALIZE ();

            
            /// <summary>
            ///   System.Boolean get_enabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_enabled")]
            ///  extern System.Boolean GET_ENABLED ();

            
            /// <summary>
            ///   System.Collections.Generic.List<PlayerController.PlayerFreeze> get_FreezeList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PlayerController.PlayerFreeze></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FreezeList")]
            ///  extern nint GET_FREEZE_LIST ();

            
            /// <summary>
            ///   UnityEngine.GameObject get_gameObject()
            /// </summary>
            /// <returns>class UnityEngine.GameObject</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameObject")]
            ///  extern nint GET_GAME_OBJECT ();

            
            /// <summary>
            ///   GameUI get_GameUI()
            /// </summary>
            /// <returns>class GameUI</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameUI")]
            ///  extern nint GET_GAME_UI ();

            
            /// <summary>
            ///   System.Boolean get_HasHostFinishedLoadingCurrentLevel()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HasHostFinishedLoadingCurrentLevel")]
            ///  extern System.Boolean GET_HAS_HOST_FINISHED_LOADING_CURRENT_LEVEL ();

            
            /// <summary>
            ///   UnityEngine.HideFlags get_hideFlags()
            /// </summary>
            /// <returns>enum UnityEngine.HideFlags</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hideFlags")]
            ///  extern UnityEngine.HideFlags GET_HIDE_FLAGS ();

            
            /// <summary>
            ///   System.Single get_HoseSpeedModifier()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HoseSpeedModifier")]
            ///  extern System.Single GET_HOSE_SPEED_MODIFIER ();

            
            /// <summary>
            ///   UnityEngine.InputSystem.PlayerInput get_Input()
            /// </summary>
            /// <returns>class UnityEngine.InputSystem.PlayerInput</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Input")]
            ///  extern nint GET_INPUT ();

            
            /// <summary>
            ///   Inventory get_Inventory()
            /// </summary>
            /// <returns>class Inventory</returns>
              [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Inventory")]
               extern Inventory.Ptr_Inventory GET_INVENTORY ();

            
            /// <summary>
            ///   System.Boolean get_isActiveAndEnabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isActiveAndEnabled")]
            ///  extern System.Boolean GET_IS_ACTIVE_AND_ENABLED ();

            
            /// <summary>
            ///   System.Boolean get_IsBusyFishing()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsBusyFishing")]
            ///  extern System.Boolean GET_IS_BUSY_FISHING ();

            
            /// <summary>
            ///   System.Boolean get_IsBusySwitchingLevel()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsBusySwitchingLevel")]
            ///  extern System.Boolean GET_IS_BUSY_SWITCHING_LEVEL ();

            
            /// <summary>
            ///   System.Boolean get_IsBusySwitchingTempleRooms()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsBusySwitchingTempleRooms")]
            ///  extern System.Boolean GET_IS_BUSY_SWITCHING_TEMPLE_ROOMS ();

            
            /// <summary>
            ///   System.Boolean get_IsDead()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsDead")]
            ///  extern System.Boolean GET_IS_DEAD ();

            
            /// <summary>
            ///   System.Boolean get_IsHookedToPushPullObject()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsHookedToPushPullObject")]
            ///  extern System.Boolean GET_IS_HOOKED_TO_PUSH_PULL_OBJECT ();

            
            /// <summary>
            ///   System.Boolean get_IsInCutscene()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsInCutscene")]
            ///  extern System.Boolean GET_IS_IN_CUTSCENE ();

            
            /// <summary>
            ///   System.Boolean get_IsPerformingUnstuck()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsPerformingUnstuck")]
            ///  extern System.Boolean GET_IS_PERFORMING_UNSTUCK ();

            
            /// <summary>
            ///   System.Boolean get_IsReadyToEndDay()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsReadyToEndDay")]
            ///  extern System.Boolean GET_IS_READY_TO_END_DAY ();

            
            /// <summary>
            ///   System.Boolean get_IsReadyToQuit()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsReadyToQuit")]
            ///  extern System.Boolean GET_IS_READY_TO_QUIT ();

            
            /// <summary>
            ///   System.Boolean get_IsWarpieActive()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsWarpieActive")]
            ///  extern System.Boolean GET_IS_WARPIE_ACTIVE ();

            
            /// <summary>
            ///   System.Boolean get_IsWhipping()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsWhipping")]
            ///  extern System.Boolean GET_IS_WHIPPING ();

            
            /// <summary>
            ///   Level get_Level()
            /// </summary>
            /// <returns>class Level</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Level")]
            ///  extern nint GET_LEVEL ();

            
            /// <summary>
            ///   LevelPosition get_LevelPosition()
            /// </summary>
            /// <returns>struct LevelPosition</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LevelPosition")]
            ///  extern LevelPosition GET_LEVEL_POSITION ();

            
            /// <summary>
            ///   LocalPlayerController get_Local()
            /// </summary>
            /// <returns>class LocalPlayerController</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Local")]
            ///  extern nint GET_LOCAL ();

            
            /// <summary>
            ///   System.String get_name()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_name")]
            ///  extern nint GET_NAME ();

            
            /// <summary>
            ///   System.Collections.Generic.Dictionary<TokensData,System.Int32> get_NumTokens()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<TokensData,System.Int32></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_NumTokens")]
            ///  extern nint GET_NUM_TOKENS ();

            
            /// <summary>
            ///   Unity.Mathematics.int4 get_ObjectID()
            /// </summary>
            /// <returns>struct Unity.Mathematics.int4</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ObjectID")]
            ///  extern Unity.Mathematics.int4 GET_OBJECT_ID ();

            
            /// <summary>
            ///   System.Action<PlayerController,Level> get_OnAfterLevelChanged()
            /// </summary>
            /// <returns>class System.Action<PlayerController,Level></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnAfterLevelChanged")]
            ///  extern nint GET_ON_AFTER_LEVEL_CHANGED ();

            
            /// <summary>
            ///   System.Action<BuffInstance> get_OnBuffAdded()
            /// </summary>
            /// <returns>class System.Action<BuffInstance></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnBuffAdded")]
            ///  extern nint GET_ON_BUFF_ADDED ();

            
            /// <summary>
            ///   System.Action<BuffInstance> get_OnBuffRemoved()
            /// </summary>
            /// <returns>class System.Action<BuffInstance></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnBuffRemoved")]
            ///  extern nint GET_ON_BUFF_REMOVED ();

            
            /// <summary>
            ///   System.Action<RecipesData> get_OnChangeRecipeSeen()
            /// </summary>
            /// <returns>class System.Action<RecipesData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnChangeRecipeSeen")]
            ///  extern nint GET_ON_CHANGE_RECIPE_SEEN ();

            
            /// <summary>
            ///   System.Action<InventoryItemsData> get_OnChangeSeen()
            /// </summary>
            /// <returns>class System.Action<InventoryItemsData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnChangeSeen")]
            ///  extern nint GET_ON_CHANGE_SEEN ();

            
            /// <summary>
            ///   System.Action<Level> get_OnLevelChanged()
            /// </summary>
            /// <returns>class System.Action<Level></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnLevelChanged")]
            ///  extern nint GET_ON_LEVEL_CHANGED ();

            
            /// <summary>
            ///   System.Action<PlayerController,MagneticLoot> get_OnMagneticLootPickedUp()
            /// </summary>
            /// <returns>class System.Action<PlayerController,MagneticLoot></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnMagneticLootPickedUp")]
            ///  extern nint GET_ON_MAGNETIC_LOOT_PICKED_UP ();

            
            /// <summary>
            ///   System.Action get_OnMovedWithinLevel()
            /// </summary>
            /// <returns>class System.Action</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnMovedWithinLevel")]
            ///  extern nint GET_ON_MOVED_WITHIN_LEVEL ();

            
            /// <summary>
            ///   Pawn get_Pawn()
            /// </summary>
            /// <returns>class Pawn</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Pawn")]
            ///  extern nint GET_PAWN ();

            
            /// <summary>
            ///   System.Collections.Generic.List<PerksData> get_Perks()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PerksData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Perks")]
            ///  extern nint GET_PERKS ();

            
            /// <summary>
            ///   Inventory get_PetSlot()
            /// </summary>
            /// <returns>class Inventory</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PetSlot")]
            ///  extern nint GET_PET_SLOT ();

            
            /// <summary>
            ///   PlayerController get_Player()
            /// </summary>
            /// <returns>abstract class PlayerController</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Player")]
            ///  extern nint GET_PLAYER ();

            
            /// <summary>
            ///   System.String get_PlayerID()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerID")]
            ///  extern nint GET_PLAYER_ID ();

            
            /// <summary>
            ///   PlayerInventory get_PlayerInventory()
            /// </summary>
            /// <returns>class PlayerInventory</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerInventory")]
            ///  extern nint GET_PLAYER_INVENTORY ();

            
            /// <summary>
            ///   System.Boolean get_PlaySafeFXNextWarpie()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlaySafeFXNextWarpie")]
            ///  extern System.Boolean GET_PLAY_SAFE_FX_NEXT_WARPIE ();

            
            /// <summary>
            ///   System.Boolean get_ReadyToKickOffLeech()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ReadyToKickOffLeech")]
            ///  extern System.Boolean GET_READY_TO_KICK_OFF_LEECH ();

            
            /// <summary>
            ///   System.Boolean get_ReadyToSleep()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ReadyToSleep")]
            ///  extern System.Boolean GET_READY_TO_SLEEP ();

            
            /// <summary>
            ///   RemotePlayerController get_Remote()
            /// </summary>
            /// <returns>class RemotePlayerController</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Remote")]
            ///  extern nint GET_REMOTE ();

            
            /// <summary>
            ///   System.Collections.Generic.List<System.String> get_SeenRecipes()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SeenRecipes")]
            ///  extern nint GET_SEEN_RECIPES ();

            
            /// <summary>
            ///   InventoryItemsData get_SelectedBaitType()
            /// </summary>
            /// <returns>class InventoryItemsData</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SelectedBaitType")]
            ///  extern nint GET_SELECTED_BAIT_TYPE ();

            
            /// <summary>
            ///   System.Int32 get_SelectedItemIndex()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SelectedItemIndex")]
            ///  extern System.Int32 GET_SELECTED_ITEM_INDEX ();

            
            /// <summary>
            ///   System.Boolean get_ShouldDisableMonobehaviorOnExit()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShouldDisableMonobehaviorOnExit")]
            ///  extern System.Boolean GET_SHOULD_DISABLE_MONOBEHAVIOR_ON_EXIT ();

            
            /// <summary>
            ///   System.String get_tag()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tag")]
            ///  extern nint GET_TAG ();

            
            /// <summary>
            ///   Level get_TargetLevel()
            /// </summary>
            /// <returns>class Level</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TargetLevel")]
            ///  extern nint GET_TARGET_LEVEL ();

            
            /// <summary>
            ///   InventoryItem get_TemporaryTool()
            /// </summary>
            /// <returns>class InventoryItem</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TemporaryTool")]
            ///  extern nint GET_TEMPORARY_TOOL ();

            
            /// <summary>
            ///   TopDownTrackingCamera get_TrackingCamera()
            /// </summary>
            /// <returns>class TopDownTrackingCamera</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TrackingCamera")]
            ///  extern nint GET_TRACKING_CAMERA ();

            
            /// <summary>
            ///   UnityEngine.Transform get_transform()
            /// </summary>
            /// <returns>class UnityEngine.Transform</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_transform")]
            ///  extern nint GET_TRANSFORM ();

            
            /// <summary>
            ///   TutorialController get_TutorialController()
            /// </summary>
            /// <returns>class TutorialController</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TutorialController")]
            ///  extern nint GET_TUTORIAL_CONTROLLER ();

            
            /// <summary>
            ///   System.Collections.Generic.List<InventoryItemsData> get_UnlockedBuildings()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<InventoryItemsData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UnlockedBuildings")]
            ///  extern nint GET_UNLOCKED_BUILDINGS ();

            
            /// <summary>
            ///   System.Collections.Generic.List<FoodsData> get_UnlockedFoods()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<FoodsData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UnlockedFoods")]
            ///  extern nint GET_UNLOCKED_FOODS ();

            
            /// <summary>
            ///   System.Collections.Generic.List<RecipesData> get_UnlockedRecipes()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<RecipesData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UnlockedRecipes")]
            ///  extern nint GET_UNLOCKED_RECIPES ();

            
            /// <summary>
            ///   System.Collections.Generic.List<InventoryItemsData> get_UnlockedShopItems()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<InventoryItemsData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UnlockedShopItems")]
            ///  extern nint GET_UNLOCKED_SHOP_ITEMS ();

            
            /// <summary>
            ///   System.Boolean get_useGUILayout()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_useGUILayout")]
            ///  extern System.Boolean GET_USE_GUI_LAYOUT ();

            
            /// <summary>
            ///   System.Boolean get_WarpieEnabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WarpieEnabled")]
            ///  extern System.Boolean GET_WARPIE_ENABLED ();

            
            /// <summary>
            ///   WorldPosition get_WorldPosition()
            /// </summary>
            /// <returns>struct WorldPosition</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldPosition")]
            ///  extern WorldPosition GET_WORLD_POSITION ();

            
            /// <summary>
            ///   System.IntPtr GetCachedPtr()
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCachedPtr")]
            ///  extern System.IntPtr GET_CACHED_PTR ();

            
            /// <summary>
            ///   PlayerController.FreezeMode GetCalculatedFreezeMode()
            /// </summary>
            /// <returns>enum PlayerController.FreezeMode</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCalculatedFreezeMode")]
            ///  extern PlayerController.FreezeMode GET_CALCULATED_FREEZE_MODE ();

            
            /// <summary>
            ///   System.Void GetComponentFastPath(System.Type type, System.IntPtr oneFurtherThanResultValue)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="oneFurtherThanResultValue">struct System.IntPtr</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentFastPath")]
            ///  extern void GET_COMPONENT_FAST_PATH (nint type, System.IntPtr oneFurtherThanResultValue);

            
            /// <summary>
            ///   System.Void GetComponentsForListInternal(System.Type searchType, System.Object resultList)
            /// </summary>
            /// <param name="searchType">abstract class System.Type</param>
            /// <param name="resultList">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsForListInternal")]
            ///  extern void GET_COMPONENTS_FOR_LIST_INTERNAL (nint searchType, nint resultList);

            
            /// <summary>
            ///   Level GetCurrentLevel()
            /// </summary>
            /// <returns>class Level</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCurrentLevel")]
            ///  extern nint GET_CURRENT_LEVEL ();

            
            /// <summary>
            ///   System.Int32 GetHashCode()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
            ///  extern System.Int32 GET_HASH_CODE ();

            
            /// <summary>
            ///   System.Int32 GetInstanceID()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInstanceID")]
            ///  extern System.Int32 GET_INSTANCE_ID ();

            
            /// <summary>
            ///   UnityEngine.Color GetInteractionColor(TargetedTile targetedTile)
            /// </summary>
            /// <param name="targetedTile">class TargetedTile</param>
            /// <returns>struct UnityEngine.Color</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInteractionColor")]
            ///  extern UnityEngine.Color GET_INTERACTION_COLOR (nint targetedTile);

            
            /// <summary>
            /// static  System.String GetName(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetName")]
            /// static extern nint GET_NAME (nint obj);

            
            /// <summary>
            /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetOffsetOfInstanceIDInCPlusPlusObject")]
            /// static extern System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT ();

            
            /// <summary>
            ///   Unity.Mathematics.int2 GetOriginTile()
            /// </summary>
            /// <returns>struct Unity.Mathematics.int2</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetOriginTile")]
            ///  extern Unity.Mathematics.int2 GET_ORIGIN_TILE ();

            
            /// <summary>
            ///   System.String GetScriptClassName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetScriptClassName")]
            ///  extern nint GET_SCRIPT_CLASS_NAME ();

            
            /// <summary>
            ///   ItemStack GetSelectedItemStack()
            /// </summary>
            /// <returns>class ItemStack</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSelectedItemStack")]
            ///  extern nint GET_SELECTED_ITEM_STACK ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Unity.Mathematics.int2> GetSweepTiles(Unity.Mathematics.int2 playerTile, Unity.Mathematics.int2 targetTile)
            /// </summary>
            /// <param name="playerTile">struct Unity.Mathematics.int2</param>
            /// <param name="targetTile">struct Unity.Mathematics.int2</param>
            /// <returns>class System.Collections.Generic.List<Unity.Mathematics.int2></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSweepTiles")]
            ///  extern nint GET_SWEEP_TILES (Unity.Mathematics.int2 playerTile, Unity.Mathematics.int2 targetTile);

            
            /// <summary>
            ///   TargetedTile GetTargetedTile()
            /// </summary>
            /// <returns>class TargetedTile</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTargetedTile")]
            ///  extern nint GET_TARGETED_TILE ();

            
            /// <summary>
            ///   System.Void GoToNextItem()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GoToNextItem")]
            ///  extern void GO_TO_NEXT_ITEM ();

            
            /// <summary>
            ///   System.Void GoToPreviousItem()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GoToPreviousItem")]
            ///  extern void GO_TO_PREVIOUS_ITEM ();

            
            /// <summary>
            ///   System.Boolean HasBlueprint(InventoryItemsData blueprint)
            /// </summary>
            /// <param name="blueprint">class InventoryItemsData</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasBlueprint")]
            ///  extern System.Boolean HAS_BLUEPRINT (nint blueprint);

            
            /// <summary>
            ///   System.Boolean HasBuff(BuffsData type)
            /// </summary>
            /// <param name="type">class BuffsData</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasBuff")]
            ///  extern System.Boolean HAS_BUFF (nint type);

            
            /// <summary>
            ///   System.Boolean HasRecipe(RecipesData recipe)
            /// </summary>
            /// <param name="recipe">class RecipesData</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasRecipe")]
            ///  extern System.Boolean HAS_RECIPE (nint recipe);

            
            /// <summary>
            ///   System.Boolean HasSeenItem(InventoryItemsData item)
            /// </summary>
            /// <param name="item">class InventoryItemsData</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasSeenItem")]
            ///  extern System.Boolean HAS_SEEN_ITEM (nint item);

            
            /// <summary>
            ///   System.Boolean HasShopItem(InventoryItemsData item)
            /// </summary>
            /// <param name="item">class InventoryItemsData</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasShopItem")]
            ///  extern System.Boolean HAS_SHOP_ITEM (nint item);

            
            /// <summary>
            ///   System.Void Initialize()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Initialize")]
            ///  extern void INITIALIZE ();

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask InitializeTempleRoom()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitializeTempleRoom")]
            ///  extern Cysharp.Threading.Tasks.UniTask INITIALIZE_TEMPLE_ROOM ();

            
            /// <summary>
            /// static  System.Void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CancelInvokeAll")]
            /// static extern void INTERNAL_CANCEL_INVOKE_ALL (nint self);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CloneSingle")]
            /// static extern nint INTERNAL_CLONE_SINGLE (nint data);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="worldPositionStays">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CloneSingleWithParent")]
            /// static extern nint INTERNAL_CLONE_SINGLE_WITH_PARENT (nint data, nint parent, System.Boolean worldPositionStays);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <param name="pos">struct UnityEngine.Vector3</param>
            /// <param name="rot">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingle")]
            /// static extern nint INTERNAL_INSTANTIATE_SINGLE (nint data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            
            
            
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor", Search = typeof(Search_LocalPlayerController))]
            /// static extern void .CCTOR_00 ();

            
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor", Search = typeof(Search_LocalPlayerController))]
            /// static extern void .CCTOR_01 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_LocalPlayerController))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_LocalPlayerController))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_LocalPlayerController))]
            ///  extern void .CTOR_02 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_LocalPlayerController))]
            ///  extern void .CTOR_03 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_LocalPlayerController))]
            ///  extern void .CTOR_04 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_LocalPlayerController))]
            ///  extern void .CTOR_05 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_LocalPlayerController))]
            ///  extern void .CTOR_06 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_LocalPlayerController))]
            ///  extern void .CTOR_07 ();

            
            /// <summary>
            ///   System.Void add_OnInteractCallback(System.Action<PlayerController,Unity.Mathematics.int2> value)
            /// </summary>
            /// <param name="value">class System.Action<PlayerController,Unity.Mathematics.int2></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnInteractCallback", Search = typeof(Search_LocalPlayerController))]
            ///  extern void ADD_ON_INTERACT_CALLBACK_00 (nint value);

            
            /// <summary>
            ///  abstract System.Void add_OnInteractCallback(System.Action<PlayerController,Unity.Mathematics.int2> value)
            /// </summary>
            /// <param name="value">class System.Action<PlayerController,Unity.Mathematics.int2></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnInteractCallback", Search = typeof(Search_LocalPlayerController))]
            ///  extern void ADD_ON_INTERACT_CALLBACK_01 (nint value);

            
            /// <summary>
            ///   System.Void add_OnPlayerTeleported(System.Action<LevelPosition> value)
            /// </summary>
            /// <param name="value">class System.Action<LevelPosition></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnPlayerTeleported", Search = typeof(Search_LocalPlayerController))]
            ///  extern void ADD_ON_PLAYER_TELEPORTED_00 (nint value);

            
            /// <summary>
            ///   System.Void add_OnPlayerTeleported(System.Action<LevelPosition> value)
            /// </summary>
            /// <param name="value">class System.Action<LevelPosition></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnPlayerTeleported", Search = typeof(Search_LocalPlayerController))]
            ///  extern void ADD_ON_PLAYER_TELEPORTED_01 (nint value);

            
            /// <summary>
            ///   PlayerController.PlayerFreeze AddFreeze(PlayerController.FreezeMode mode, System.String tag)
            /// </summary>
            /// <param name="mode">enum PlayerController.FreezeMode</param>
            /// <param name="tag">class System.String</param>
            /// <returns>class PlayerController.PlayerFreeze</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFreeze", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint ADD_FREEZE_00 (PlayerController.FreezeMode mode, nint tag);

            
            /// <summary>
            ///  abstract PlayerController.PlayerFreeze AddFreeze(PlayerController.FreezeMode mode, System.String tag)
            /// </summary>
            /// <param name="mode">enum PlayerController.FreezeMode</param>
            /// <param name="tag">class System.String</param>
            /// <returns>class PlayerController.PlayerFreeze</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFreeze", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint ADD_FREEZE_01 (PlayerController.FreezeMode mode, nint tag);

            
            /// <summary>
            ///   System.Void Awake()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Awake", Search = typeof(Search_LocalPlayerController))]
            ///  extern void AWAKE_00 ();

            
            /// <summary>
            ///   System.Void Awake()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Awake", Search = typeof(Search_LocalPlayerController))]
            ///  extern void AWAKE_01 ();

            
            /// <summary>
            ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="parameter">class System.Object</param>
            /// <param name="options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_LocalPlayerController))]
            ///  extern void BROADCAST_MESSAGE_00 (nint methodName, nint parameter, UnityEngine.SendMessageOptions options);

            
            /// <summary>
            ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="parameter">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_LocalPlayerController))]
            ///  extern void BROADCAST_MESSAGE_01 (nint methodName, nint parameter);

            
            /// <summary>
            ///   System.Void BroadcastMessage(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_LocalPlayerController))]
            ///  extern void BROADCAST_MESSAGE_02 (nint methodName);

            
            /// <summary>
            ///   System.Void BroadcastMessage(System.String methodName, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_LocalPlayerController))]
            ///  extern void BROADCAST_MESSAGE_03 (nint methodName, UnityEngine.SendMessageOptions options);

            
            /// <summary>
            ///   System.Void CancelInvoke()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_LocalPlayerController))]
            ///  extern void CANCEL_INVOKE_00 ();

            
            /// <summary>
            ///   System.Void CancelInvoke(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_LocalPlayerController))]
            ///  extern void CANCEL_INVOKE_01 (nint methodName);

            
            /// <summary>
            /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_LocalPlayerController))]
            /// static extern void CANCEL_INVOKE_02 (nint self, nint methodName);

            
            /// <summary>
            ///   System.Int32 CountOwnedItems(InventoryItemsData item)
            /// </summary>
            /// <param name="item">class InventoryItemsData</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CountOwnedItems", Search = typeof(Search_LocalPlayerController))]
            ///  extern System.Int32 COUNT_OWNED_ITEMS_00 (nint item);

            
            /// <summary>
            ///   System.Int32 CountOwnedItems(InventoryItemsData item)
            /// </summary>
            /// <param name="item">class InventoryItemsData</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CountOwnedItems", Search = typeof(Search_LocalPlayerController))]
            ///  extern System.Int32 COUNT_OWNED_ITEMS_01 (nint item);

            
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <param name="t">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_LocalPlayerController))]
            /// static extern void DESTROY_00 (nint obj, System.Single t);

            
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_LocalPlayerController))]
            /// static extern void DESTROY_01 (nint obj);

            
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <param name="allowDestroyingAssets">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_LocalPlayerController))]
            /// static extern void DESTROY_IMMEDIATE_00 (nint obj, System.Boolean allowDestroyingAssets);

            
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_LocalPlayerController))]
            /// static extern void DESTROY_IMMEDIATE_01 (nint obj);

            
            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <param name="t">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyObject", Search = typeof(Search_LocalPlayerController))]
            /// static extern void DESTROY_OBJECT_00 (nint obj, System.Single t);

            
            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyObject", Search = typeof(Search_LocalPlayerController))]
            /// static extern void DESTROY_OBJECT_01 (nint obj);

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask DoSetLevelLogic(Level level, System.String spawnpointNameOrCoords, System.Boolean animateFade)
            /// </summary>
            /// <param name="level">class Level</param>
            /// <param name="spawnpointNameOrCoords">class System.String</param>
            /// <param name="animateFade">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DoSetLevelLogic", Search = typeof(Search_LocalPlayerController))]
            ///  extern Cysharp.Threading.Tasks.UniTask DO_SET_LEVEL_LOGIC_00 (nint level, nint spawnpointNameOrCoords, System.Boolean animateFade);

            
            /// <summary>
            ///  abstract Cysharp.Threading.Tasks.UniTask DoSetLevelLogic(Level level, System.String spawnpointName, System.Boolean animateFade)
            /// </summary>
            /// <param name="level">class Level</param>
            /// <param name="spawnpointName">class System.String</param>
            /// <param name="animateFade">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DoSetLevelLogic", Search = typeof(Search_LocalPlayerController))]
            ///  extern Cysharp.Threading.Tasks.UniTask DO_SET_LEVEL_LOGIC_01 (nint level, nint spawnpointName, System.Boolean animateFade);

            
            /// <summary>
            ///   System.Void DropItems(System.Int32 amount, System.Boolean getHurt, System.String source)
            /// </summary>
            /// <param name="amount">struct System.Int32</param>
            /// <param name="getHurt">struct System.Boolean</param>
            /// <param name="source">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DropItems", Search = typeof(Search_LocalPlayerController))]
            ///  extern void DROP_ITEMS_00 (System.Int32 amount, System.Boolean getHurt, nint source);

            
            /// <summary>
            ///  abstract System.Void DropItems(System.Int32 amount, System.Boolean getHurt, System.String source)
            /// </summary>
            /// <param name="amount">struct System.Int32</param>
            /// <param name="getHurt">struct System.Boolean</param>
            /// <param name="source">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DropItems", Search = typeof(Search_LocalPlayerController))]
            ///  extern void DROP_ITEMS_01 (System.Int32 amount, System.Boolean getHurt, nint source);

            
            /// <summary>
            /// static  T FindObjectOfType()
            /// </summary>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint FIND_OBJECT_OF_TYPE_00 ();

            
            /// <summary>
            /// static  T FindObjectOfType(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint FIND_OBJECT_OF_TYPE_01 (System.Boolean includeInactive);

            
            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint FIND_OBJECT_OF_TYPE_02 (nint type);

            
            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint FIND_OBJECT_OF_TYPE_03 (nint type, System.Boolean includeInactive);

            
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint FIND_OBJECTS_OF_TYPE_00 (nint type);

            
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint FIND_OBJECTS_OF_TYPE_01 (nint type, System.Boolean includeInactive);

            
            /// <summary>
            /// static  T[] FindObjectsOfType()
            /// </summary>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint FIND_OBJECTS_OF_TYPE_02 ();

            
            /// <summary>
            /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint FIND_OBJECTS_OF_TYPE_03 (System.Boolean includeInactive);

            
            /// <summary>
            ///   System.Void FixedUpdate()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FixedUpdate", Search = typeof(Search_LocalPlayerController))]
            ///  extern void FIXED_UPDATE_00 ();

            
            /// <summary>
            ///   System.Void FixedUpdate()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FixedUpdate", Search = typeof(Search_LocalPlayerController))]
            ///  extern void FIXED_UPDATE_01 ();

            
            /// <summary>
            ///   System.Boolean get_CanBeKilled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CanBeKilled", Search = typeof(Search_LocalPlayerController))]
            ///  extern System.Boolean GET_CAN_BE_KILLED_00 ();

            
            /// <summary>
            ///   System.Boolean get_CanBeKilled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CanBeKilled", Search = typeof(Search_LocalPlayerController))]
            ///  extern System.Boolean GET_CAN_BE_KILLED_01 ();

            
            /// <summary>
            ///   System.Boolean get_HasAuthority()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HasAuthority", Search = typeof(Search_LocalPlayerController))]
            ///  extern System.Boolean GET_HAS_AUTHORITY_00 ();

            
            /// <summary>
            ///  abstract System.Boolean get_HasAuthority()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HasAuthority", Search = typeof(Search_LocalPlayerController))]
            ///  extern System.Boolean GET_HAS_AUTHORITY_01 ();

            
            /// <summary>
            ///   System.Int32 get_Money()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Money", Search = typeof(Search_LocalPlayerController))]
            ///  extern System.Int32 GET_MONEY_00 ();

            
            /// <summary>
            ///  abstract System.Int32 get_Money()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Money", Search = typeof(Search_LocalPlayerController))]
            ///  extern System.Int32 GET_MONEY_01 ();

            
            /// <summary>
            ///   UnityEngine.Component GetComponent(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENT_00 (nint type);

            
            /// <summary>
            ///   T GetComponent()
            /// </summary>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENT_01 ();

            
            /// <summary>
            ///   UnityEngine.Component GetComponent(System.String type)
            /// </summary>
            /// <param name="type">class System.String</param>
            /// <returns>class UnityEngine.Component</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENT_02 (nint type);

            
            /// <summary>
            ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENT_IN_CHILDREN_00 (nint t, System.Boolean includeInactive);

            
            /// <summary>
            ///   UnityEngine.Component GetComponentInChildren(System.Type t)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENT_IN_CHILDREN_01 (nint t);

            
            /// <summary>
            ///   T GetComponentInChildren(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENT_IN_CHILDREN_02 (System.Boolean includeInactive);

            
            /// <summary>
            ///   T GetComponentInChildren()
            /// </summary>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENT_IN_CHILDREN_03 ();

            
            /// <summary>
            ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENT_IN_PARENT_00 (nint t, System.Boolean includeInactive);

            
            /// <summary>
            ///   UnityEngine.Component GetComponentInParent(System.Type t)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENT_IN_PARENT_01 (nint t);

            
            /// <summary>
            ///   T GetComponentInParent(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENT_IN_PARENT_02 (System.Boolean includeInactive);

            
            /// <summary>
            ///   T GetComponentInParent()
            /// </summary>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENT_IN_PARENT_03 ();

            
            /// <summary>
            ///   UnityEngine.Component[] GetComponents(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENTS_00 (nint type);

            
            /// <summary>
            ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="results">class System.Collections.Generic.List<UnityEngine.Component></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_LocalPlayerController))]
            ///  extern void GET_COMPONENTS_01 (nint type, nint results);

            
            /// <summary>
            ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name="results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_LocalPlayerController))]
            ///  extern void GET_COMPONENTS_02 (nint results);

            
            /// <summary>
            ///   T[] GetComponents()
            /// </summary>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENTS_03 ();

            
            /// <summary>
            ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENTS_IN_CHILDREN_00 (nint t, System.Boolean includeInactive);

            
            /// <summary>
            ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENTS_IN_CHILDREN_01 (nint t);

            
            /// <summary>
            ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENTS_IN_CHILDREN_02 (System.Boolean includeInactive);

            
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <param name="result">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_LocalPlayerController))]
            ///  extern void GET_COMPONENTS_IN_CHILDREN_03 (System.Boolean includeInactive, nint result);

            
            /// <summary>
            ///   T[] GetComponentsInChildren()
            /// </summary>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENTS_IN_CHILDREN_04 ();

            
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name="results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_LocalPlayerController))]
            ///  extern void GET_COMPONENTS_IN_CHILDREN_05 (nint results);

            
            /// <summary>
            ///   UnityEngine.Component[] GetComponentsInParent(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENTS_IN_PARENT_00 (nint t, System.Boolean includeInactive);

            
            /// <summary>
            ///   UnityEngine.Component[] GetComponentsInParent(System.Type t)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENTS_IN_PARENT_01 (nint t);

            
            /// <summary>
            ///   T[] GetComponentsInParent(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENTS_IN_PARENT_02 (System.Boolean includeInactive);

            
            /// <summary>
            ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <param name="results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_LocalPlayerController))]
            ///  extern void GET_COMPONENTS_IN_PARENT_03 (System.Boolean includeInactive, nint results);

            
            /// <summary>
            ///   T[] GetComponentsInParent()
            /// </summary>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_COMPONENTS_IN_PARENT_04 ();

            
            /// <summary>
            ///   System.Void GetHurt()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHurt", Search = typeof(Search_LocalPlayerController))]
            ///  extern void GET_HURT_00 ();

            
            /// <summary>
            ///  abstract System.Void GetHurt()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHurt", Search = typeof(Search_LocalPlayerController))]
            ///  extern void GET_HURT_01 ();

            
            /// <summary>
            ///   InventoryItem GetSelectedItem()
            /// </summary>
            /// <returns>class InventoryItem</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSelectedItem", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_SELECTED_ITEM_00 ();

            
            /// <summary>
            ///  abstract InventoryItem GetSelectedItem()
            /// </summary>
            /// <returns>class InventoryItem</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSelectedItem", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint GET_SELECTED_ITEM_01 ();

            
            /// <summary>
            ///   Unity.Mathematics.int2 GetTargetedTilePos()
            /// </summary>
            /// <returns>struct Unity.Mathematics.int2</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTargetedTilePos", Search = typeof(Search_LocalPlayerController))]
            ///  extern Unity.Mathematics.int2 GET_TARGETED_TILE_POS_00 ();

            
            /// <summary>
            ///  abstract Unity.Mathematics.int2 GetTargetedTilePos()
            /// </summary>
            /// <returns>struct Unity.Mathematics.int2</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTargetedTilePos", Search = typeof(Search_LocalPlayerController))]
            ///  extern Unity.Mathematics.int2 GET_TARGETED_TILE_POS_01 ();

            
            /// <summary>
            ///   UnityEngine.Vector3 GetWorldMovementVector()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetWorldMovementVector", Search = typeof(Search_LocalPlayerController))]
            ///  extern UnityEngine.Vector3 GET_WORLD_MOVEMENT_VECTOR_00 ();

            
            /// <summary>
            ///  abstract UnityEngine.Vector3 GetWorldMovementVector()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetWorldMovementVector", Search = typeof(Search_LocalPlayerController))]
            ///  extern UnityEngine.Vector3 GET_WORLD_MOVEMENT_VECTOR_01 ();

            
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <param name="position">struct UnityEngine.Vector3</param>
            /// <param name="rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint INSTANTIATE_00 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);

            
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <param name="position">struct UnityEngine.Vector3</param>
            /// <param name="rotation">struct UnityEngine.Quaternion</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint INSTANTIATE_01 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);

            
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint INSTANTIATE_02 (nint original);

            
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint INSTANTIATE_03 (nint original, nint parent);

            
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="instantiateInWorldSpace">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint INSTANTIATE_04 (nint original, nint parent, System.Boolean instantiateInWorldSpace);

            
            /// <summary>
            /// static  T Instantiate(T original)
            /// </summary>
            /// <param name="original">class T</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint INSTANTIATE_05 (nint original);

            
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="position">struct UnityEngine.Vector3</param>
            /// <param name="rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint INSTANTIATE_06 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);

            
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="position">struct UnityEngine.Vector3</param>
            /// <param name="rotation">struct UnityEngine.Quaternion</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint INSTANTIATE_07 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);

            
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint INSTANTIATE_08 (nint original, nint parent);

            
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="worldPositionStays">struct System.Boolean</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint INSTANTIATE_09 (nint original, nint parent, System.Boolean worldPositionStays);

            
            /// public static partial class Search_LocalPlayerController
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    /// static  System.Void .cctor()
                    /// </summary>
                    /// public static bool .CCTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".cctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void .cctor()
                    /// </summary>
                    /// public static bool .CCTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".cctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void add_OnInteractCallback(System.Action<PlayerController,Unity.Mathematics.int2> value)
                    /// </summary>
                    /// public static bool ADD_ON_INTERACT_CALLBACK_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "add_OnInteractCallback", "System.Action<PlayerController,Unity.Mathematics.int2>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void add_OnInteractCallback(System.Action<PlayerController,Unity.Mathematics.int2> value)
                    /// </summary>
                    /// public static bool ADD_ON_INTERACT_CALLBACK_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "add_OnInteractCallback", "System.Action<PlayerController,Unity.Mathematics.int2>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void add_OnPlayerTeleported(System.Action<LevelPosition> value)
                    /// </summary>
                    /// public static bool ADD_ON_PLAYER_TELEPORTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "add_OnPlayerTeleported", "System.Action<LevelPosition>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void add_OnPlayerTeleported(System.Action<LevelPosition> value)
                    /// </summary>
                    /// public static bool ADD_ON_PLAYER_TELEPORTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "add_OnPlayerTeleported", "System.Action<LevelPosition>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   PlayerController.PlayerFreeze AddFreeze(PlayerController.FreezeMode mode, System.String tag)
                    /// </summary>
                    /// public static bool ADD_FREEZE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddFreeze", "PlayerController.FreezeMode", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract PlayerController.PlayerFreeze AddFreeze(PlayerController.FreezeMode mode, System.String tag)
                    /// </summary>
                    /// public static bool ADD_FREEZE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddFreeze", "PlayerController.FreezeMode", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Awake()
                    /// </summary>
                    /// public static bool AWAKE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Awake");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Awake()
                    /// </summary>
                    /// public static bool AWAKE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Awake");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options)
                    /// </summary>
                    /// public static bool BROADCAST_MESSAGE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String", "System.Object", "UnityEngine.SendMessageOptions");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter)
                    /// </summary>
                    /// public static bool BROADCAST_MESSAGE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String", "System.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void BroadcastMessage(System.String methodName)
                    /// </summary>
                    /// public static bool BROADCAST_MESSAGE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void BroadcastMessage(System.String methodName, UnityEngine.SendMessageOptions options)
                    /// </summary>
                    /// public static bool BROADCAST_MESSAGE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String", "UnityEngine.SendMessageOptions");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void CancelInvoke()
                    /// </summary>
                    /// public static bool CANCEL_INVOKE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CancelInvoke");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void CancelInvoke(System.String methodName)
                    /// </summary>
                    /// public static bool CANCEL_INVOKE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CancelInvoke", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
                    /// </summary>
                    /// public static bool CANCEL_INVOKE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CancelInvoke", "UnityEngine.MonoBehaviour", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Int32 CountOwnedItems(InventoryItemsData item)
                    /// </summary>
                    /// public static bool COUNT_OWNED_ITEMS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CountOwnedItems", "InventoryItemsData");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Int32 CountOwnedItems(InventoryItemsData item)
                    /// </summary>
                    /// public static bool COUNT_OWNED_ITEMS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CountOwnedItems", "InventoryItemsData");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
                    /// </summary>
                    /// public static bool DESTROY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Destroy", "UnityEngine.Object", "System.Single");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void Destroy(UnityEngine.Object obj)
                    /// </summary>
                    /// public static bool DESTROY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Destroy", "UnityEngine.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
                    /// </summary>
                    /// public static bool DESTROY_IMMEDIATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyImmediate", "UnityEngine.Object", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
                    /// </summary>
                    /// public static bool DESTROY_IMMEDIATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyImmediate", "UnityEngine.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
                    /// </summary>
                    /// public static bool DESTROY_OBJECT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyObject", "UnityEngine.Object", "System.Single");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void DestroyObject(UnityEngine.Object obj)
                    /// </summary>
                    /// public static bool DESTROY_OBJECT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyObject", "UnityEngine.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   Cysharp.Threading.Tasks.UniTask DoSetLevelLogic(Level level, System.String spawnpointNameOrCoords, System.Boolean animateFade)
                    /// </summary>
                    /// public static bool DO_SET_LEVEL_LOGIC_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DoSetLevelLogic", "Level", "System.String", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract Cysharp.Threading.Tasks.UniTask DoSetLevelLogic(Level level, System.String spawnpointName, System.Boolean animateFade)
                    /// </summary>
                    /// public static bool DO_SET_LEVEL_LOGIC_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DoSetLevelLogic", "Level", "System.String", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void DropItems(System.Int32 amount, System.Boolean getHurt, System.String source)
                    /// </summary>
                    /// public static bool DROP_ITEMS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DropItems", "System.Int32", "System.Boolean", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void DropItems(System.Int32 amount, System.Boolean getHurt, System.String source)
                    /// </summary>
                    /// public static bool DROP_ITEMS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DropItems", "System.Int32", "System.Boolean", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T FindObjectOfType()
                    /// </summary>
                    /// public static bool FIND_OBJECT_OF_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T FindObjectOfType(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool FIND_OBJECT_OF_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object FindObjectOfType(System.Type type)
                    /// </summary>
                    /// public static bool FIND_OBJECT_OF_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool FIND_OBJECT_OF_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
                    /// </summary>
                    /// public static bool FIND_OBJECTS_OF_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool FIND_OBJECTS_OF_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T[] FindObjectsOfType()
                    /// </summary>
                    /// public static bool FIND_OBJECTS_OF_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool FIND_OBJECTS_OF_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void FixedUpdate()
                    /// </summary>
                    /// public static bool FIXED_UPDATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FixedUpdate");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void FixedUpdate()
                    /// </summary>
                    /// public static bool FIXED_UPDATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FixedUpdate");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean get_CanBeKilled()
                    /// </summary>
                    /// public static bool GET_CAN_BE_KILLED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_CanBeKilled");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean get_CanBeKilled()
                    /// </summary>
                    /// public static bool GET_CAN_BE_KILLED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_CanBeKilled");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean get_HasAuthority()
                    /// </summary>
                    /// public static bool GET_HAS_AUTHORITY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_HasAuthority");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Boolean get_HasAuthority()
                    /// </summary>
                    /// public static bool GET_HAS_AUTHORITY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_HasAuthority");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Int32 get_Money()
                    /// </summary>
                    /// public static bool GET_MONEY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Money");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Int32 get_Money()
                    /// </summary>
                    /// public static bool GET_MONEY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Money");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponent(System.Type type)
                    /// </summary>
                    /// public static bool GET_COMPONENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponent()
                    /// </summary>
                    /// public static bool GET_COMPONENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponent(System.String type)
                    /// </summary>
                    /// public static bool GET_COMPONENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_CHILDREN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponentInChildren(System.Type t)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_CHILDREN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponentInChildren(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_CHILDREN_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponentInChildren()
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_CHILDREN_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_PARENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponentInParent(System.Type t)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_PARENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponentInParent(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_PARENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponentInParent()
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_PARENT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component[] GetComponents(System.Type type)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Type", "System.Collections.Generic.List<UnityEngine.Component>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponents()
                    /// </summary>
                    /// public static bool GET_COMPONENTS_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Boolean", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInChildren()
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component[] GetComponentsInParent(System.Type t, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component[] GetComponentsInParent(System.Type t)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInParent(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Boolean", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInParent()
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetHurt()
                    /// </summary>
                    /// public static bool GET_HURT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetHurt");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void GetHurt()
                    /// </summary>
                    /// public static bool GET_HURT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetHurt");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   InventoryItem GetSelectedItem()
                    /// </summary>
                    /// public static bool GET_SELECTED_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetSelectedItem");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract InventoryItem GetSelectedItem()
                    /// </summary>
                    /// public static bool GET_SELECTED_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetSelectedItem");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   Unity.Mathematics.int2 GetTargetedTilePos()
                    /// </summary>
                    /// public static bool GET_TARGETED_TILE_POS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTargetedTilePos");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract Unity.Mathematics.int2 GetTargetedTilePos()
                    /// </summary>
                    /// public static bool GET_TARGETED_TILE_POS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTargetedTilePos");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Vector3 GetWorldMovementVector()
                    /// </summary>
                    /// public static bool GET_WORLD_MOVEMENT_VECTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetWorldMovementVector");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract UnityEngine.Vector3 GetWorldMovementVector()
                    /// </summary>
                    /// public static bool GET_WORLD_MOVEMENT_VECTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetWorldMovementVector");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
                    /// </summary>
                    /// public static bool INSTANTIATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Vector3", "UnityEngine.Quaternion");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
                    /// </summary>
                    /// public static bool INSTANTIATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Transform");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
                    /// </summary>
                    /// public static bool INSTANTIATE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
                    /// </summary>
                    /// public static bool INSTANTIATE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Transform");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
                    /// </summary>
                    /// public static bool INSTANTIATE_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Transform", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original)
                    /// </summary>
                    /// public static bool INSTANTIATE_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
                    /// </summary>
                    /// public static bool INSTANTIATE_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
                    /// </summary>
                    /// public static bool INSTANTIATE_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Transform");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Transform parent)
                    /// </summary>
                    /// public static bool INSTANTIATE_08 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
                    /// </summary>
                    /// public static bool INSTANTIATE_09 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform", "System.Boolean");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }

        /// <summary>
        /// ["AzureValley".""."LocalPlayerController"]
        /// </summary>
        public partial class LocalPlayerController
        { 

            
            
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <param name="pos">struct UnityEngine.Vector3&</param>
            /// <param name="rot">struct UnityEngine.Quaternion&</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingle_Injected")]
            /// static extern nint INTERNAL_INSTANTIATE_SINGLE_INJECTED (nint data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="pos">struct UnityEngine.Vector3</param>
            /// <param name="rot">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingleWithParent")]
            /// static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT (nint data, nint parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="pos">struct UnityEngine.Vector3&</param>
            /// <param name="rot">struct UnityEngine.Quaternion&</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingleWithParent_Injected")]
            /// static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT_INJECTED (nint data, nint parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot);

            
            /// <summary>
            /// static  System.Boolean Internal_IsInvokingAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_IsInvokingAll")]
            /// static extern System.Boolean INTERNAL_IS_INVOKING_ALL (nint self);

            
            /// <summary>
            ///   System.Void Invoke(System.String methodName, System.Single time)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="time">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Invoke")]
            ///  extern void INVOKE (nint methodName, System.Single time);

            
            /// <summary>
            /// static  System.Void InvokeDelayed(UnityEngine.MonoBehaviour self, System.String methodName, System.Single time, System.Single repeatRate)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <param name="methodName">class System.String</param>
            /// <param name="time">struct System.Single</param>
            /// <param name="repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InvokeDelayed")]
            /// static extern void INVOKE_DELAYED (nint self, nint methodName, System.Single time, System.Single repeatRate);

            
            /// <summary>
            ///   System.Void InvokeRepeating(System.String methodName, System.Single time, System.Single repeatRate)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="time">struct System.Single</param>
            /// <param name="repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InvokeRepeating")]
            ///  extern void INVOKE_REPEATING (nint methodName, System.Single time, System.Single repeatRate);

            
            /// <summary>
            ///   System.Boolean IsBaitSelectedInAnyRod(InventoryItemsData bait)
            /// </summary>
            /// <param name="bait">class InventoryItemsData</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsBaitSelectedInAnyRod")]
            ///  extern System.Boolean IS_BAIT_SELECTED_IN_ANY_ROD (nint bait);

            
            /// <summary>
            /// static  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
            /// </summary>
            /// <param name="o">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsNativeObjectAlive")]
            /// static extern System.Boolean IS_NATIVE_OBJECT_ALIVE (nint o);

            
            /// <summary>
            /// static  System.Boolean IsObjectMonoBehaviour(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsObjectMonoBehaviour")]
            /// static extern System.Boolean IS_OBJECT_MONO_BEHAVIOUR (nint obj);

            
            /// <summary>
            /// static  System.Boolean IsPersistent(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsPersistent")]
            /// static extern System.Boolean IS_PERSISTENT (nint obj);

            
            /// <summary>
            ///   System.Boolean MergeInteractions(TargetedTile target, Interactable[] interactables, System.Int32& maxPriority)
            /// </summary>
            /// <param name="target">class TargetedTile</param>
            /// <param name="interactables">class Interactable[]</param>
            /// <param name="maxPriority">struct System.Int32&</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MergeInteractions")]
            ///  extern System.Boolean MERGE_INTERACTIONS (nint target, nint interactables, System.Int32& maxPriority);

            
            /// <summary>
            ///   System.Void OnApplicationQuit()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnApplicationQuit")]
            ///  extern void ON_APPLICATION_QUIT ();

            
            /// <summary>
            ///   System.Void OnBlueprints(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnBlueprints")]
            ///  extern void ON_BLUEPRINTS (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnCameraPreRender(UnityEngine.Camera camera)
            /// </summary>
            /// <param name="camera">class UnityEngine.Camera</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCameraPreRender")]
            ///  extern void ON_CAMERA_PRE_RENDER (nint camera);

            
            /// <summary>
            ///   System.Void OnCancel(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCancel")]
            ///  extern void ON_CANCEL (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnCancelledNextItem(UnityEngine.InputSystem.InputAction.CallbackContext obj)
            /// </summary>
            /// <param name="obj">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCancelledNextItem")]
            ///  extern void ON_CANCELLED_NEXT_ITEM (UnityEngine.InputSystem.InputAction.CallbackContext obj);

            
            /// <summary>
            ///   System.Void OnCancelledPreviousItem(UnityEngine.InputSystem.InputAction.CallbackContext obj)
            /// </summary>
            /// <param name="obj">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCancelledPreviousItem")]
            ///  extern void ON_CANCELLED_PREVIOUS_ITEM (UnityEngine.InputSystem.InputAction.CallbackContext obj);

            
            /// <summary>
            ///   System.Void OnCancelRepeat(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCancelRepeat")]
            ///  extern void ON_CANCEL_REPEAT (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnCancelUI(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCancelUI")]
            ///  extern void ON_CANCEL_UI (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnClosedGestureMenu()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnClosedGestureMenu")]
            ///  extern void ON_CLOSED_GESTURE_MENU ();

            
            /// <summary>
            ///   System.Void OnCloseGestureMenu(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCloseGestureMenu")]
            ///  extern void ON_CLOSE_GESTURE_MENU (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnControlsChanged()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnControlsChanged")]
            ///  extern void ON_CONTROLS_CHANGED ();

            
            /// <summary>
            ///   System.Void OnDefaultInteract(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnDefaultInteract")]
            ///  extern void ON_DEFAULT_INTERACT (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnDestroy()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnDestroy")]
            ///  extern void ON_DESTROY ();

            
            /// <summary>
            ///   System.Void OnEndDay()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnEndDay")]
            ///  extern void ON_END_DAY ();

            
            /// <summary>
            ///   System.Void OnInteract(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInteract")]
            ///  extern void ON_INTERACT (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Boolean OnInteractImpl(UnityEngine.InputSystem.InputAction sourceAction)
            /// </summary>
            /// <param name="sourceAction">class UnityEngine.InputSystem.InputAction</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInteractImpl")]
            ///  extern System.Boolean ON_INTERACT_IMPL (nint sourceAction);

            
            /// <summary>
            ///   System.Void OnInteractRepeatEnd(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInteractRepeatEnd")]
            ///  extern void ON_INTERACT_REPEAT_END (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnInteractRepeatStart(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInteractRepeatStart")]
            ///  extern void ON_INTERACT_REPEAT_START (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnInventory(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInventory")]
            ///  extern void ON_INVENTORY (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnInventoryChanged(InventoryChangeEvent evt)
            /// </summary>
            /// <param name="evt">struct InventoryChangeEvent</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInventoryChanged")]
            ///  extern void ON_INVENTORY_CHANGED (InventoryChangeEvent evt);

            
            /// <summary>
            ///   System.Void OnLevelChangedCallback(PlayerController player, Level level)
            /// </summary>
            /// <param name="player">abstract class PlayerController</param>
            /// <param name="level">class Level</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnLevelChangedCallback")]
            ///  extern void ON_LEVEL_CHANGED_CALLBACK (nint player, nint level);

            
            /// <summary>
            ///   System.Void OnLevelPostProcess(Level level)
            /// </summary>
            /// <param name="level">class Level</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnLevelPostProcess")]
            ///  extern void ON_LEVEL_POST_PROCESS (nint level);

            
            /// <summary>
            ///   System.Void OnLootPickedUp(MagneticLoot magneticLoot)
            /// </summary>
            /// <param name="magneticLoot">class MagneticLoot</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnLootPickedUp")]
            ///  extern void ON_LOOT_PICKED_UP (nint magneticLoot);

            
            /// <summary>
            ///   System.Void OnMainMenu(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnMainMenu")]
            ///  extern void ON_MAIN_MENU (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnNextItem(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnNextItem")]
            ///  extern void ON_NEXT_ITEM (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnOpenGestureMenu(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnOpenGestureMenu")]
            ///  extern void ON_OPEN_GESTURE_MENU (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnPlayGesture(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnPlayGesture")]
            ///  extern void ON_PLAY_GESTURE (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnPreviousItem(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnPreviousItem")]
            ///  extern void ON_PREVIOUS_ITEM (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnQuestMenu(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnQuestMenu")]
            ///  extern void ON_QUEST_MENU (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnSelectItem(UnityEngine.InputSystem.InputAction.CallbackContext ctx, System.Int32 index)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnSelectItem")]
            ///  extern void ON_SELECT_ITEM (UnityEngine.InputSystem.InputAction.CallbackContext ctx, System.Int32 index);

            
            /// <summary>
            ///   System.Void OnStartedNextItem(UnityEngine.InputSystem.InputAction.CallbackContext obj)
            /// </summary>
            /// <param name="obj">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnStartedNextItem")]
            ///  extern void ON_STARTED_NEXT_ITEM (UnityEngine.InputSystem.InputAction.CallbackContext obj);

            
            /// <summary>
            ///   System.Void OnStartedPreviousItem(UnityEngine.InputSystem.InputAction.CallbackContext obj)
            /// </summary>
            /// <param name="obj">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnStartedPreviousItem")]
            ///  extern void ON_STARTED_PREVIOUS_ITEM (UnityEngine.InputSystem.InputAction.CallbackContext obj);

            
            /// <summary>
            ///   System.Void OnThrow(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnThrow")]
            ///  extern void ON_THROW (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnThrowImpactPoint(InventoryItem item)
            /// </summary>
            /// <param name="item">class InventoryItem</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnThrowImpactPoint")]
            ///  extern void ON_THROW_IMPACT_POINT (nint item);

            
            /// <summary>
            ///   System.Void OnWhip()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnWhip")]
            ///  extern void ON_WHIP ();

            
            /// <summary>
            ///   System.Void OnWhipEnd(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnWhipEnd")]
            ///  extern void ON_WHIP_END (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void OnWhipStart(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnWhipStart")]
            ///  extern void ON_WHIP_START (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            /// static  System.Boolean op_Equality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name="x">class UnityEngine.Object</param>
            /// <param name="y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Equality")]
            /// static extern System.Boolean OP_EQUALITY (nint x, nint y);

            
            /// <summary>
            /// static  System.Boolean op_Implicit(UnityEngine.Object exists)
            /// </summary>
            /// <param name="exists">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit")]
            /// static extern System.Boolean OP_IMPLICIT (nint exists);

            
            /// <summary>
            /// static  System.Boolean op_Inequality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name="x">class UnityEngine.Object</param>
            /// <param name="y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Inequality")]
            /// static extern System.Boolean OP_INEQUALITY (nint x, nint y);

            
            /// <summary>
            ///   System.Void PerformUnstuckLogic()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PerformUnstuckLogic")]
            ///  extern void PERFORM_UNSTUCK_LOGIC ();

            
            /// <summary>
            ///   System.Collections.IEnumerator PlayerStretch()
            /// </summary>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayerStretch")]
            ///  extern nint PLAYER_STRETCH ();

            
            /// <summary>
            ///   System.Void PlayGesture(System.String gestureAnimation, PawnAnimationType gestureAnimationType)
            /// </summary>
            /// <param name="gestureAnimation">class System.String</param>
            /// <param name="gestureAnimationType">enum PawnAnimationType</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayGesture")]
            ///  extern void PLAY_GESTURE (nint gestureAnimation, PawnAnimationType gestureAnimationType);

            
            /// <summary>
            ///   System.Void PlayMinedSandFX(Unity.Mathematics.int2 targetTile)
            /// </summary>
            /// <param name="targetTile">struct Unity.Mathematics.int2</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayMinedSandFX")]
            ///  extern void PLAY_MINED_SAND_FX (Unity.Mathematics.int2 targetTile);

            
            /// <summary>
            /// static  System.Void print(System.Object message)
            /// </summary>
            /// <param name="message">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("print")]
            /// static extern void PRINT (nint message);

            
            /// <summary>
            ///   System.Void ReceiveHostFinishedLoadingLevel()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReceiveHostFinishedLoadingLevel")]
            ///  extern void RECEIVE_HOST_FINISHED_LOADING_LEVEL ();

            
            /// <summary>
            ///   System.Void RegisterToOnEquippedBaitChanged(System.Action<InventoryItemsData> action)
            /// </summary>
            /// <param name="action">class System.Action<InventoryItemsData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RegisterToOnEquippedBaitChanged")]
            ///  extern void REGISTER_TO_ON_EQUIPPED_BAIT_CHANGED (nint action);

            
            /// <summary>
            ///   System.Void remove_OnBlueprintUnlocked(System.Action<InventoryItemsData,System.Boolean> value)
            /// </summary>
            /// <param name="value">class System.Action<InventoryItemsData,System.Boolean></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnBlueprintUnlocked")]
            ///  extern void REMOVE_ON_BLUEPRINT_UNLOCKED (nint value);

            
            /// <summary>
            ///   System.Void remove_OnCutsceneStatusChanged(System.Action<System.Boolean> value)
            /// </summary>
            /// <param name="value">class System.Action<System.Boolean></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnCutsceneStatusChanged")]
            ///  extern void REMOVE_ON_CUTSCENE_STATUS_CHANGED (nint value);

            
            /// <summary>
            ///   System.Void remove_OnDayEndForPlayer(System.Action value)
            /// </summary>
            /// <param name="value">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnDayEndForPlayer")]
            ///  extern void REMOVE_ON_DAY_END_FOR_PLAYER (nint value);

            
            /// <summary>
            ///   System.Void remove_OnDeathStateChanged(System.Action<System.Boolean,PlayerDeathType> value)
            /// </summary>
            /// <param name="value">class System.Action<System.Boolean,PlayerDeathType></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnDeathStateChanged")]
            ///  extern void REMOVE_ON_DEATH_STATE_CHANGED (nint value);

            
            /// <summary>
            ///   System.Void remove_OnItemThrown(System.Action<InventoryItem> value)
            /// </summary>
            /// <param name="value">class System.Action<InventoryItem></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnItemThrown")]
            ///  extern void REMOVE_ON_ITEM_THROWN (nint value);

            
            /// <summary>
            ///   System.Void remove_OnMoneyValueChanged(System.Action<System.Int32> value)
            /// </summary>
            /// <param name="value">class System.Action<System.Int32></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnMoneyValueChanged")]
            ///  extern void REMOVE_ON_MONEY_VALUE_CHANGED (nint value);

            
            /// <summary>
            ///   System.Void remove_OnPlayerReset(System.Action<LocalPlayerController> value)
            /// </summary>
            /// <param name="value">class System.Action<LocalPlayerController></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnPlayerReset")]
            ///  extern void REMOVE_ON_PLAYER_RESET (nint value);

            
            /// <summary>
            ///   System.Void remove_OnRecipeUnlocked(System.Action<RecipesData> value)
            /// </summary>
            /// <param name="value">class System.Action<RecipesData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnRecipeUnlocked")]
            ///  extern void REMOVE_ON_RECIPE_UNLOCKED (nint value);

            
            /// <summary>
            ///   System.Void RemoveBuff(BuffInstance buff)
            /// </summary>
            /// <param name="buff">class BuffInstance</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBuff")]
            ///  extern void REMOVE_BUFF (nint buff);

            
            /// <summary>
            ///   System.Void RemoveInputListeners()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInputListeners")]
            ///  extern void REMOVE_INPUT_LISTENERS ();

            
            /// <summary>
            ///   System.Void RemoveLoadingFreeze()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLoadingFreeze")]
            ///  extern void REMOVE_LOADING_FREEZE ();

            
            /// <summary>
            ///   System.Void ResetContextHints()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetContextHints")]
            ///  extern void RESET_CONTEXT_HINTS ();

            
            /// <summary>
            ///   System.Void ResetPlayer(System.Boolean hideLoadingScreen)
            /// </summary>
            /// <param name="hideLoadingScreen">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetPlayer")]
            ///  extern void RESET_PLAYER (System.Boolean hideLoadingScreen);

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTaskVoid SelectBlueprint()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTaskVoid</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SelectBlueprint")]
            ///  extern Cysharp.Threading.Tasks.UniTaskVoid SELECT_BLUEPRINT ();

            
            /// <summary>
            ///   System.Void set_ActiveDevice(System.String value)
            /// </summary>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ActiveDevice")]
            ///  extern void SET_ACTIVE_DEVICE (nint value);

            
            /// <summary>
            ///   System.Void set_BeforeLevelChanged(System.Action<Level> value)
            /// </summary>
            /// <param name="value">class System.Action<Level></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_BeforeLevelChanged")]
            ///  extern void SET_BEFORE_LEVEL_CHANGED (nint value);

            
            /// <summary>
            ///   System.Void set_Buffs(System.Collections.Generic.List<BuffInstance> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.List<BuffInstance></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Buffs")]
            ///  extern void SET_BUFFS (nint value);

            
            /// <summary>
            ///   System.Void set_Carrying(Carryable value)
            /// </summary>
            /// <param name="value">class Carryable</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Carrying")]
            ///  extern void SET_CARRYING (nint value);

            
            /// <summary>
            ///   System.Void set_CurrentLevel(Level value)
            /// </summary>
            /// <param name="value">class Level</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_CurrentLevel")]
            ///  extern void SET_CURRENT_LEVEL (nint value);

            
            /// <summary>
            ///   System.Void set_Data(PlayerData value)
            /// </summary>
            /// <param name="value">class PlayerData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Data")]
            ///  extern void SET_DATA (nint value);

            
            /// <summary>
            ///   System.Void set_DoFirstTimeInitialize(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_DoFirstTimeInitialize")]
            ///  extern void SET_DO_FIRST_TIME_INITIALIZE (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_enabled(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_enabled")]
            ///  extern void SET_ENABLED (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_GameUI(GameUI value)
            /// </summary>
            /// <param name="value">class GameUI</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_GameUI")]
            ///  extern void SET_GAME_UI (nint value);

            
            /// <summary>
            ///   System.Void set_HasHostFinishedLoadingCurrentLevel(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_HasHostFinishedLoadingCurrentLevel")]
            ///  extern void SET_HAS_HOST_FINISHED_LOADING_CURRENT_LEVEL (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
            /// </summary>
            /// <param name="value">enum UnityEngine.HideFlags</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_hideFlags")]
            ///  extern void SET_HIDE_FLAGS (UnityEngine.HideFlags value);

            
            /// <summary>
            ///   System.Void set_HoseSpeedModifier(System.Single value)
            /// </summary>
            /// <param name="value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_HoseSpeedModifier")]
            ///  extern void SET_HOSE_SPEED_MODIFIER (System.Single value);

            
            /// <summary>
            ///   System.Void set_Inventory(Inventory value)
            /// </summary>
            /// <param name="value">class Inventory</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Inventory")]
            ///  extern void SET_INVENTORY (nint value);

            
            /// <summary>
            ///   System.Void set_IsBusyFishing(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsBusyFishing")]
            ///  extern void SET_IS_BUSY_FISHING (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_IsBusySwitchingLevel(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsBusySwitchingLevel")]
            ///  extern void SET_IS_BUSY_SWITCHING_LEVEL (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_IsBusySwitchingTempleRooms(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsBusySwitchingTempleRooms")]
            ///  extern void SET_IS_BUSY_SWITCHING_TEMPLE_ROOMS (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_IsDead(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsDead")]
            ///  extern void SET_IS_DEAD (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_IsHookedToPushPullObject(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsHookedToPushPullObject")]
            ///  extern void SET_IS_HOOKED_TO_PUSH_PULL_OBJECT (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_IsInCutscene(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsInCutscene")]
            ///  extern void SET_IS_IN_CUTSCENE (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_IsPerformingUnstuck(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsPerformingUnstuck")]
            ///  extern void SET_IS_PERFORMING_UNSTUCK (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_IsReadyToEndDay(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsReadyToEndDay")]
            ///  extern void SET_IS_READY_TO_END_DAY (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_IsReadyToQuit(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsReadyToQuit")]
            ///  extern void SET_IS_READY_TO_QUIT (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_IsWarpieActive(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsWarpieActive")]
            ///  extern void SET_IS_WARPIE_ACTIVE (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_name(System.String value)
            /// </summary>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_name")]
            ///  extern void SET_NAME (nint value);

            
            /// <summary>
            ///   System.Void set_OnAfterLevelChanged(System.Action<PlayerController,Level> value)
            /// </summary>
            /// <param name="value">class System.Action<PlayerController,Level></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_OnAfterLevelChanged")]
            ///  extern void SET_ON_AFTER_LEVEL_CHANGED (nint value);

            
            /// <summary>
            ///   System.Void set_OnBuffAdded(System.Action<BuffInstance> value)
            /// </summary>
            /// <param name="value">class System.Action<BuffInstance></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_OnBuffAdded")]
            ///  extern void SET_ON_BUFF_ADDED (nint value);

            
            /// <summary>
            ///   System.Void set_OnBuffRemoved(System.Action<BuffInstance> value)
            /// </summary>
            /// <param name="value">class System.Action<BuffInstance></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_OnBuffRemoved")]
            ///  extern void SET_ON_BUFF_REMOVED (nint value);

            
            /// <summary>
            ///   System.Void set_OnChangeRecipeSeen(System.Action<RecipesData> value)
            /// </summary>
            /// <param name="value">class System.Action<RecipesData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_OnChangeRecipeSeen")]
            ///  extern void SET_ON_CHANGE_RECIPE_SEEN (nint value);

            
            /// <summary>
            ///   System.Void set_OnChangeSeen(System.Action<InventoryItemsData> value)
            /// </summary>
            /// <param name="value">class System.Action<InventoryItemsData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_OnChangeSeen")]
            ///  extern void SET_ON_CHANGE_SEEN (nint value);

            
            /// <summary>
            ///   System.Void set_OnLevelChanged(System.Action<Level> value)
            /// </summary>
            /// <param name="value">class System.Action<Level></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_OnLevelChanged")]
            ///  extern void SET_ON_LEVEL_CHANGED (nint value);

            
            /// <summary>
            ///   System.Void set_OnMagneticLootPickedUp(System.Action<PlayerController,MagneticLoot> value)
            /// </summary>
            /// <param name="value">class System.Action<PlayerController,MagneticLoot></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_OnMagneticLootPickedUp")]
            ///  extern void SET_ON_MAGNETIC_LOOT_PICKED_UP (nint value);

            
            /// <summary>
            ///   System.Void set_OnMovedWithinLevel(System.Action value)
            /// </summary>
            /// <param name="value">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_OnMovedWithinLevel")]
            ///  extern void SET_ON_MOVED_WITHIN_LEVEL (nint value);

            
            /// <summary>
            ///   System.Void set_Player(PlayerController value)
            /// </summary>
            /// <param name="value">abstract class PlayerController</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Player")]
            ///  extern void SET_PLAYER (nint value);

            
            /// <summary>
            ///   System.Void set_PlayerInventory(PlayerInventory value)
            /// </summary>
            /// <param name="value">class PlayerInventory</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_PlayerInventory")]
            ///  extern void SET_PLAYER_INVENTORY (nint value);

            
            /// <summary>
            ///   System.Void set_PlaySafeFXNextWarpie(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_PlaySafeFXNextWarpie")]
            ///  extern void SET_PLAY_SAFE_FX_NEXT_WARPIE (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_ReadyToKickOffLeech(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ReadyToKickOffLeech")]
            ///  extern void SET_READY_TO_KICK_OFF_LEECH (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_ReadyToSleep(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ReadyToSleep")]
            ///  extern void SET_READY_TO_SLEEP (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_SelectedItemIndex(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_SelectedItemIndex")]
            ///  extern void SET_SELECTED_ITEM_INDEX (System.Int32 value);

            
            /// <summary>
            ///   System.Void set_tag(System.String value)
            /// </summary>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_tag")]
            ///  extern void SET_TAG (nint value);

            
            /// <summary>
            ///   System.Void set_TargetLevel(Level value)
            /// </summary>
            /// <param name="value">class Level</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_TargetLevel")]
            ///  extern void SET_TARGET_LEVEL (nint value);

            
            /// <summary>
            ///   System.Void set_TemporaryTool(InventoryItem value)
            /// </summary>
            /// <param name="value">class InventoryItem</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_TemporaryTool")]
            ///  extern void SET_TEMPORARY_TOOL (nint value);

            
            /// <summary>
            ///   System.Void set_TrackingCamera(TopDownTrackingCamera value)
            /// </summary>
            /// <param name="value">class TopDownTrackingCamera</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_TrackingCamera")]
            ///  extern void SET_TRACKING_CAMERA (nint value);

            
            /// <summary>
            ///   System.Void set_useGUILayout(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_useGUILayout")]
            ///  extern void SET_USE_GUI_LAYOUT (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_WarpieEnabled(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_WarpieEnabled")]
            ///  extern void SET_WARPIE_ENABLED (System.Boolean value);

            
            /// <summary>
            ///   System.Void SetHoldStartTime(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
            /// </summary>
            /// <param name="ctx">struct UnityEngine.InputSystem.InputAction.CallbackContext</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetHoldStartTime")]
            ///  extern void SET_HOLD_START_TIME (UnityEngine.InputSystem.InputAction.CallbackContext ctx);

            
            /// <summary>
            ///   System.Void SetIsDead(System.Boolean isDead)
            /// </summary>
            /// <param name="isDead">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetIsDead")]
            ///  extern void SET_IS_DEAD (System.Boolean isDead);

            
            /// <summary>
            ///   System.Void SetLevelAfterLoad(Level level)
            /// </summary>
            /// <param name="level">class Level</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLevelAfterLoad")]
            ///  extern void SET_LEVEL_AFTER_LOAD (nint level);

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask SetLevelWithCoords(Level level, Unity.Mathematics.int2 tile, System.Single playerHeading, System.Single cameraHeading, System.Boolean animateFade)
            /// </summary>
            /// <param name="level">class Level</param>
            /// <param name="tile">struct Unity.Mathematics.int2</param>
            /// <param name="playerHeading">struct System.Single</param>
            /// <param name="cameraHeading">struct System.Single</param>
            /// <param name="animateFade">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLevelWithCoords")]
            ///  extern Cysharp.Threading.Tasks.UniTask SET_LEVEL_WITH_COORDS (nint level, Unity.Mathematics.int2 tile, System.Single playerHeading, System.Single cameraHeading, System.Boolean animateFade);

            
            /// <summary>
            /// static  System.Void SetName(UnityEngine.Object obj, System.String name)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <param name="name">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetName")]
            /// static extern void SET_NAME (nint obj, nint name);

            
            /// <summary>
            ///   System.Void SetPosition(LevelPosition position)
            /// </summary>
            /// <param name="position">struct LevelPosition</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetPosition")]
            ///  extern void SET_POSITION (LevelPosition position);

            
            /// <summary>
            ///   System.Void SetSelectedItem(System.Int32 slot)
            /// </summary>
            /// <param name="slot">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSelectedItem")]
            ///  extern void SET_SELECTED_ITEM (System.Int32 slot);

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask ShowNewTool(System.Threading.CancellationToken cancellationToken, System.Int32 slot)
            /// </summary>
            /// <param name="cancellationToken">struct System.Threading.CancellationToken</param>
            /// <param name="slot">struct System.Int32</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowNewTool")]
            ///  extern Cysharp.Threading.Tasks.UniTask SHOW_NEW_TOOL (System.Threading.CancellationToken cancellationToken, System.Int32 slot);

            
            /// <summary>
            ///   System.Void Start()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Start")]
            ///  extern void START ();

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine_Auto")]
            ///  extern nint START_COROUTINE_AUTO (nint routine);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged(System.String methodName, System.Object value)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutineManaged")]
            ///  extern nint START_COROUTINE_MANAGED (nint methodName, nint value);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator)
            /// </summary>
            /// <param name="enumerator">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutineManaged2")]
            ///  extern nint START_COROUTINE_MANAGED2 (nint enumerator);

            
            /// <summary>
            ///   System.Void StopAllCoroutines()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopAllCoroutines")]
            ///  extern void STOP_ALL_COROUTINES ();

            
            /// <summary>
            ///   System.Void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutineFromEnumeratorManaged")]
            ///  extern void STOP_COROUTINE_FROM_ENUMERATOR_MANAGED (nint routine);

            
            /// <summary>
            ///   System.Void StopCoroutineManaged(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name="routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutineManaged")]
            ///  extern void STOP_COROUTINE_MANAGED (nint routine);

            
            /// <summary>
            ///   System.Void SyncDeathState()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SyncDeathState")]
            ///  extern void SYNC_DEATH_STATE ();

            
            /// <summary>
            ///   System.Func<Cysharp.Threading.Tasks.UniTask> TeleportToSpawn(Level level, System.String spawnpointNameOrCoords, System.Boolean isActuallySwitching)
            /// </summary>
            /// <param name="level">class Level</param>
            /// <param name="spawnpointNameOrCoords">class System.String</param>
            /// <param name="isActuallySwitching">struct System.Boolean</param>
            /// <returns>class System.Func<Cysharp.Threading.Tasks.UniTask></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TeleportToSpawn")]
            ///  extern nint TELEPORT_TO_SPAWN (nint level, nint spawnpointNameOrCoords, System.Boolean isActuallySwitching);

            
            /// <summary>
            ///   System.Void Throw(InventoryItem item, System.Boolean createMagneticLootOnDrop)
            /// </summary>
            /// <param name="item">class InventoryItem</param>
            /// <param name="createMagneticLootOnDrop">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Throw")]
            ///  extern void THROW (nint item, System.Boolean createMagneticLootOnDrop);

            
            /// <summary>
            ///   System.Void TryAddHandlersToTarget(GameLogic.GameLogicEvent evt, TargetedTile currentTileTarget, System.Boolean autoDetermineTargetIdentity, System.Int32& currentTilePriority)
            /// </summary>
            /// <param name="evt">class GameLogic.GameLogicEvent</param>
            /// <param name="currentTileTarget">class TargetedTile</param>
            /// <param name="autoDetermineTargetIdentity">struct System.Boolean</param>
            /// <param name="currentTilePriority">struct System.Int32&</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryAddHandlersToTarget")]
            ///  extern void TRY_ADD_HANDLERS_TO_TARGET (nint evt, nint currentTileTarget, System.Boolean autoDetermineTargetIdentity, System.Int32& currentTilePriority);

            
            /// <summary>
            ///   System.Void UnlockFood(FoodsData food, System.Boolean displayMessage, AutoUnlocksData source)
            /// </summary>
            /// <param name="food">class FoodsData</param>
            /// <param name="displayMessage">struct System.Boolean</param>
            /// <param name="source">class AutoUnlocksData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnlockFood")]
            ///  extern void UNLOCK_FOOD (nint food, System.Boolean displayMessage, nint source);

            
            /// <summary>
            ///   System.Void UnregisterToOnEquippedBaitChanged(System.Action<InventoryItemsData> action)
            /// </summary>
            /// <param name="action">class System.Action<InventoryItemsData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnregisterToOnEquippedBaitChanged")]
            ///  extern void UNREGISTER_TO_ON_EQUIPPED_BAIT_CHANGED (nint action);

            
            /// <summary>
            ///   System.Void UpdateContextHints()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateContextHints")]
            ///  extern void UPDATE_CONTEXT_HINTS ();

            
            /// <summary>
            ///   System.Void UpdateSelectedItem(System.Int32 selectedItem)
            /// </summary>
            /// <param name="selectedItem">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateSelectedItem")]
            ///  extern void UPDATE_SELECTED_ITEM (System.Int32 selectedItem);

            
            /// <summary>
            ///   System.Void UpdateTarget()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateTarget")]
            ///  extern void UPDATE_TARGET ();
            
            
            
            /// <summary>
            ///   System.Boolean IsFrozen(PlayerController.FreezeMode mode)
            /// </summary>
            /// <param name="mode">enum PlayerController.FreezeMode</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsFrozen", Search = typeof(Search_LocalPlayerController))]
            ///  extern System.Boolean IS_FROZEN_00 (PlayerController.FreezeMode mode);

            
            /// <summary>
            ///  abstract System.Boolean IsFrozen(PlayerController.FreezeMode mode)
            /// </summary>
            /// <param name="mode">enum PlayerController.FreezeMode</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsFrozen", Search = typeof(Search_LocalPlayerController))]
            ///  extern System.Boolean IS_FROZEN_01 (PlayerController.FreezeMode mode);

            
            /// <summary>
            ///   System.Boolean IsInvoking()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_LocalPlayerController))]
            ///  extern System.Boolean IS_INVOKING_00 ();

            
            /// <summary>
            ///   System.Boolean IsInvoking(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_LocalPlayerController))]
            ///  extern System.Boolean IS_INVOKING_01 (nint methodName);

            
            /// <summary>
            /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_LocalPlayerController))]
            /// static extern System.Boolean IS_INVOKING_02 (nint self, nint methodName);

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask Kill(PlayerDeathType deathType, System.Boolean animateFade)
            /// </summary>
            /// <param name="deathType">enum PlayerDeathType</param>
            /// <param name="animateFade">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Kill", Search = typeof(Search_LocalPlayerController))]
            ///  extern Cysharp.Threading.Tasks.UniTask KILL_00 (PlayerDeathType deathType, System.Boolean animateFade);

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask Kill(System.String reviveAtSpawnPoint, Level reviveInLevel, PlayerDeathType deathType, System.Boolean performFade, System.Boolean showDeathScreen, DungeonController.DungeonFailureReason failureReason)
            /// </summary>
            /// <param name="reviveAtSpawnPoint">class System.String</param>
            /// <param name="reviveInLevel">class Level</param>
            /// <param name="deathType">enum PlayerDeathType</param>
            /// <param name="performFade">struct System.Boolean</param>
            /// <param name="showDeathScreen">struct System.Boolean</param>
            /// <param name="failureReason">enum DungeonController.DungeonFailureReason</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Kill", Search = typeof(Search_LocalPlayerController))]
            ///  extern Cysharp.Threading.Tasks.UniTask KILL_01 (nint reviveAtSpawnPoint, nint reviveInLevel, PlayerDeathType deathType, System.Boolean performFade, System.Boolean showDeathScreen, DungeonController.DungeonFailureReason failureReason);

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask Kill(LevelPosition reviveAtLocation, PlayerDeathType deathType, System.Boolean performFade, System.Boolean atRiskLoot)
            /// </summary>
            /// <param name="reviveAtLocation">struct LevelPosition</param>
            /// <param name="deathType">enum PlayerDeathType</param>
            /// <param name="performFade">struct System.Boolean</param>
            /// <param name="atRiskLoot">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Kill", Search = typeof(Search_LocalPlayerController))]
            ///  extern Cysharp.Threading.Tasks.UniTask KILL_02 (LevelPosition reviveAtLocation, PlayerDeathType deathType, System.Boolean performFade, System.Boolean atRiskLoot);

            
            /// <summary>
            ///  abstract Cysharp.Threading.Tasks.UniTask Kill(PlayerDeathType deathType, System.Boolean animateFade)
            /// </summary>
            /// <param name="deathType">enum PlayerDeathType</param>
            /// <param name="animateFade">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Kill", Search = typeof(Search_LocalPlayerController))]
            ///  extern Cysharp.Threading.Tasks.UniTask KILL_03 (PlayerDeathType deathType, System.Boolean animateFade);

            
            /// <summary>
            ///  abstract Cysharp.Threading.Tasks.UniTask Kill(System.String reviveAtSpawnpoint, Level reviveInLevel, PlayerDeathType deathType, System.Boolean performFade, System.Boolean showDeathScreen, DungeonController.DungeonFailureReason dungeonFailureReason)
            /// </summary>
            /// <param name="reviveAtSpawnpoint">class System.String</param>
            /// <param name="reviveInLevel">class Level</param>
            /// <param name="deathType">enum PlayerDeathType</param>
            /// <param name="performFade">struct System.Boolean</param>
            /// <param name="showDeathScreen">struct System.Boolean</param>
            /// <param name="dungeonFailureReason">enum DungeonController.DungeonFailureReason</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Kill", Search = typeof(Search_LocalPlayerController))]
            ///  extern Cysharp.Threading.Tasks.UniTask KILL_04 (nint reviveAtSpawnpoint, nint reviveInLevel, PlayerDeathType deathType, System.Boolean performFade, System.Boolean showDeathScreen, DungeonController.DungeonFailureReason dungeonFailureReason);

            
            /// <summary>
            ///  abstract Cysharp.Threading.Tasks.UniTask Kill(LevelPosition reviveAtLocation, PlayerDeathType deathType, System.Boolean performFade, System.Boolean atRiskLoot)
            /// </summary>
            /// <param name="reviveAtLocation">struct LevelPosition</param>
            /// <param name="deathType">enum PlayerDeathType</param>
            /// <param name="performFade">struct System.Boolean</param>
            /// <param name="atRiskLoot">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Kill", Search = typeof(Search_LocalPlayerController))]
            ///  extern Cysharp.Threading.Tasks.UniTask KILL_05 (LevelPosition reviveAtLocation, PlayerDeathType deathType, System.Boolean performFade, System.Boolean atRiskLoot);

            
            /// <summary>
            ///   System.Void OnCreate()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCreate", Search = typeof(Search_LocalPlayerController))]
            ///  extern void ON_CREATE_00 ();

            
            /// <summary>
            ///   System.Void OnCreate()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCreate", Search = typeof(Search_LocalPlayerController))]
            ///  extern void ON_CREATE_01 ();

            
            /// <summary>
            ///   System.Void OnDestroyed()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnDestroyed", Search = typeof(Search_LocalPlayerController))]
            ///  extern void ON_DESTROYED_00 ();

            
            /// <summary>
            ///   System.Void OnDestroyed()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnDestroyed", Search = typeof(Search_LocalPlayerController))]
            ///  extern void ON_DESTROYED_01 ();

            
            /// <summary>
            ///   System.Void OnGameUIInitialized(GameUI gameUI)
            /// </summary>
            /// <param name="gameUI">class GameUI</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnGameUIInitialized", Search = typeof(Search_LocalPlayerController))]
            ///  extern void ON_GAME_UI_INITIALIZED_00 (nint gameUI);

            
            /// <summary>
            ///   System.Void OnGameUIInitialized(GameUI gameUI)
            /// </summary>
            /// <param name="gameUI">class GameUI</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnGameUIInitialized", Search = typeof(Search_LocalPlayerController))]
            ///  extern void ON_GAME_UI_INITIALIZED_01 (nint gameUI);

            
            /// <summary>
            ///   System.Void Pickup(Pickupable obj)
            /// </summary>
            /// <param name="obj">class Pickupable</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Pickup", Search = typeof(Search_LocalPlayerController))]
            ///  extern void PICKUP_00 (nint obj);

            
            /// <summary>
            ///  abstract System.Void Pickup(Pickupable obj)
            /// </summary>
            /// <param name="obj">class Pickupable</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Pickup", Search = typeof(Search_LocalPlayerController))]
            ///  extern void PICKUP_01 (nint obj);

            
            /// <summary>
            ///   System.Void remove_OnInteractCallback(System.Action<PlayerController,Unity.Mathematics.int2> value)
            /// </summary>
            /// <param name="value">class System.Action<PlayerController,Unity.Mathematics.int2></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnInteractCallback", Search = typeof(Search_LocalPlayerController))]
            ///  extern void REMOVE_ON_INTERACT_CALLBACK_00 (nint value);

            
            /// <summary>
            ///  abstract System.Void remove_OnInteractCallback(System.Action<PlayerController,Unity.Mathematics.int2> value)
            /// </summary>
            /// <param name="value">class System.Action<PlayerController,Unity.Mathematics.int2></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnInteractCallback", Search = typeof(Search_LocalPlayerController))]
            ///  extern void REMOVE_ON_INTERACT_CALLBACK_01 (nint value);

            
            /// <summary>
            ///   System.Void remove_OnPlayerTeleported(System.Action<LevelPosition> value)
            /// </summary>
            /// <param name="value">class System.Action<LevelPosition></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnPlayerTeleported", Search = typeof(Search_LocalPlayerController))]
            ///  extern void REMOVE_ON_PLAYER_TELEPORTED_00 (nint value);

            
            /// <summary>
            ///   System.Void remove_OnPlayerTeleported(System.Action<LevelPosition> value)
            /// </summary>
            /// <param name="value">class System.Action<LevelPosition></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnPlayerTeleported", Search = typeof(Search_LocalPlayerController))]
            ///  extern void REMOVE_ON_PLAYER_TELEPORTED_01 (nint value);

            
            /// <summary>
            ///   System.Void RemoveFreeze(PlayerController.PlayerFreeze freeze)
            /// </summary>
            /// <param name="freeze">class PlayerController.PlayerFreeze</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFreeze", Search = typeof(Search_LocalPlayerController))]
            ///  extern void REMOVE_FREEZE_00 (nint freeze);

            
            /// <summary>
            ///  abstract System.Void RemoveFreeze(PlayerController.PlayerFreeze freeze)
            /// </summary>
            /// <param name="freeze">class PlayerController.PlayerFreeze</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFreeze", Search = typeof(Search_LocalPlayerController))]
            ///  extern void REMOVE_FREEZE_01 (nint freeze);

            
            /// <summary>
            ///   System.Void SendMessage(System.String methodName, System.Object value)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_LocalPlayerController))]
            ///  extern void SEND_MESSAGE_00 (nint methodName, nint value);

            
            /// <summary>
            ///   System.Void SendMessage(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_LocalPlayerController))]
            ///  extern void SEND_MESSAGE_01 (nint methodName);

            
            /// <summary>
            ///   System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <param name="options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_LocalPlayerController))]
            ///  extern void SEND_MESSAGE_02 (nint methodName, nint value, UnityEngine.SendMessageOptions options);

            
            /// <summary>
            ///   System.Void SendMessage(System.String methodName, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_LocalPlayerController))]
            ///  extern void SEND_MESSAGE_03 (nint methodName, UnityEngine.SendMessageOptions options);

            
            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <param name="options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_LocalPlayerController))]
            ///  extern void SEND_MESSAGE_UPWARDS_00 (nint methodName, nint value, UnityEngine.SendMessageOptions options);

            
            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName, System.Object value)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_LocalPlayerController))]
            ///  extern void SEND_MESSAGE_UPWARDS_01 (nint methodName, nint value);

            
            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_LocalPlayerController))]
            ///  extern void SEND_MESSAGE_UPWARDS_02 (nint methodName);

            
            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_LocalPlayerController))]
            ///  extern void SEND_MESSAGE_UPWARDS_03 (nint methodName, UnityEngine.SendMessageOptions options);

            
            /// <summary>
            ///   System.Void set_Money(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Money", Search = typeof(Search_LocalPlayerController))]
            ///  extern void SET_MONEY_00 (System.Int32 value);

            
            /// <summary>
            ///  abstract System.Void set_Money(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Money", Search = typeof(Search_LocalPlayerController))]
            ///  extern void SET_MONEY_01 (System.Int32 value);

            
            /// <summary>
            ///   System.Void SetCarrying(Carryable carryable)
            /// </summary>
            /// <param name="carryable">class Carryable</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCarrying", Search = typeof(Search_LocalPlayerController))]
            ///  extern void SET_CARRYING_00 (nint carryable);

            
            /// <summary>
            ///  abstract System.Void SetCarrying(Carryable carryable)
            /// </summary>
            /// <param name="carryable">class Carryable</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCarrying", Search = typeof(Search_LocalPlayerController))]
            ///  extern void SET_CARRYING_01 (nint carryable);

            
            /// <summary>
            ///   System.Void SetIsInCutscene(System.Boolean inCutscene)
            /// </summary>
            /// <param name="inCutscene">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetIsInCutscene", Search = typeof(Search_LocalPlayerController))]
            ///  extern void SET_IS_IN_CUTSCENE_00 (System.Boolean inCutscene);

            
            /// <summary>
            ///  abstract System.Void SetIsInCutscene(System.Boolean inCutscene)
            /// </summary>
            /// <param name="inCutscene">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetIsInCutscene", Search = typeof(Search_LocalPlayerController))]
            ///  extern void SET_IS_IN_CUTSCENE_01 (System.Boolean inCutscene);

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask SetLevel(Level level, System.String spawnpointName, System.Boolean animateFade)
            /// </summary>
            /// <param name="level">class Level</param>
            /// <param name="spawnpointName">class System.String</param>
            /// <param name="animateFade">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLevel", Search = typeof(Search_LocalPlayerController))]
            ///  extern Cysharp.Threading.Tasks.UniTask SET_LEVEL_00 (nint level, nint spawnpointName, System.Boolean animateFade);

            
            /// <summary>
            ///  abstract Cysharp.Threading.Tasks.UniTask SetLevel(Level level, System.String spawnpointName, System.Boolean animateFade)
            /// </summary>
            /// <param name="level">class Level</param>
            /// <param name="spawnpointName">class System.String</param>
            /// <param name="animateFade">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLevel", Search = typeof(Search_LocalPlayerController))]
            ///  extern Cysharp.Threading.Tasks.UniTask SET_LEVEL_01 (nint level, nint spawnpointName, System.Boolean animateFade);

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<System.Boolean> ShowNewTools()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<System.Boolean></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowNewTools", Search = typeof(Search_LocalPlayerController))]
            ///  extern Cysharp.Threading.Tasks.UniTask<System.Boolean> SHOW_NEW_TOOLS_00 ();

            
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<System.Boolean> ShowNewTools(System.Threading.CancellationToken cancellationToken)
            /// </summary>
            /// <param name="cancellationToken">struct System.Threading.CancellationToken</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<System.Boolean></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowNewTools", Search = typeof(Search_LocalPlayerController))]
            ///  extern Cysharp.Threading.Tasks.UniTask<System.Boolean> SHOW_NEW_TOOLS_01 (System.Threading.CancellationToken cancellationToken);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint START_COROUTINE_00 (nint methodName);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint START_COROUTINE_01 (nint methodName, nint value);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint START_COROUTINE_02 (nint routine);

            
            /// <summary>
            ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_LocalPlayerController))]
            ///  extern void STOP_COROUTINE_00 (nint routine);

            
            /// <summary>
            ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name="routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_LocalPlayerController))]
            ///  extern void STOP_COROUTINE_01 (nint routine);

            
            /// <summary>
            ///   System.Void StopCoroutine(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_LocalPlayerController))]
            ///  extern void STOP_COROUTINE_02 (nint methodName);

            
            /// <summary>
            ///   System.Void TeleportToLevelForCutscene(Level level)
            /// </summary>
            /// <param name="level">class Level</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TeleportToLevelForCutscene", Search = typeof(Search_LocalPlayerController))]
            ///  extern void TELEPORT_TO_LEVEL_FOR_CUTSCENE_00 (nint level);

            
            /// <summary>
            ///  abstract System.Void TeleportToLevelForCutscene(Level level)
            /// </summary>
            /// <param name="level">class Level</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TeleportToLevelForCutscene", Search = typeof(Search_LocalPlayerController))]
            ///  extern void TELEPORT_TO_LEVEL_FOR_CUTSCENE_01 (nint level);

            
            /// <summary>
            ///   System.Void TeleportWithFade(LevelPosition target, System.Action callbackAtBlack, System.Single delay)
            /// </summary>
            /// <param name="target">struct LevelPosition</param>
            /// <param name="callbackAtBlack">class System.Action</param>
            /// <param name="delay">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TeleportWithFade", Search = typeof(Search_LocalPlayerController))]
            ///  extern void TELEPORT_WITH_FADE_00 (LevelPosition target, nint callbackAtBlack, System.Single delay);

            
            /// <summary>
            ///  abstract System.Void TeleportWithFade(LevelPosition target, System.Action callbackAtBlack, System.Single delay)
            /// </summary>
            /// <param name="target">struct LevelPosition</param>
            /// <param name="callbackAtBlack">class System.Action</param>
            /// <param name="delay">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TeleportWithFade", Search = typeof(Search_LocalPlayerController))]
            ///  extern void TELEPORT_WITH_FADE_01 (LevelPosition target, nint callbackAtBlack, System.Single delay);

            
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_LocalPlayerController))]
            ///  extern nint TO_STRING_00 ();

            
            /// <summary>
            /// static  System.String ToString(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_LocalPlayerController))]
            /// static extern nint TO_STRING_01 (nint obj);

            
            /// <summary>
            ///   System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="component">class UnityEngine.Component&</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetComponent", Search = typeof(Search_LocalPlayerController))]
            ///  extern System.Boolean TRY_GET_COMPONENT_00 (nint type, nint component);

            
            /// <summary>
            ///   System.Boolean TryGetComponent(T& component)
            /// </summary>
            /// <param name="component">class T&</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetComponent", Search = typeof(Search_LocalPlayerController))]
            ///  extern System.Boolean TRY_GET_COMPONENT_01 (nint component);

            
            /// <summary>
            ///   System.Void UnlockBlueprint(InventoryItemsData blueprint, System.Boolean displayMessage, AutoUnlocksData source)
            /// </summary>
            /// <param name="blueprint">class InventoryItemsData</param>
            /// <param name="displayMessage">struct System.Boolean</param>
            /// <param name="source">class AutoUnlocksData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnlockBlueprint", Search = typeof(Search_LocalPlayerController))]
            ///  extern void UNLOCK_BLUEPRINT_00 (nint blueprint, System.Boolean displayMessage, nint source);

            
            /// <summary>
            ///  abstract System.Void UnlockBlueprint(InventoryItemsData item, System.Boolean displayMessage, AutoUnlocksData source)
            /// </summary>
            /// <param name="item">class InventoryItemsData</param>
            /// <param name="displayMessage">struct System.Boolean</param>
            /// <param name="source">class AutoUnlocksData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnlockBlueprint", Search = typeof(Search_LocalPlayerController))]
            ///  extern void UNLOCK_BLUEPRINT_01 (nint item, System.Boolean displayMessage, nint source);

            
            /// <summary>
            ///   System.Void UnlockRecipe(RecipesData recipe, System.Boolean displayMessage, AutoUnlocksData source)
            /// </summary>
            /// <param name="recipe">class RecipesData</param>
            /// <param name="displayMessage">struct System.Boolean</param>
            /// <param name="source">class AutoUnlocksData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnlockRecipe", Search = typeof(Search_LocalPlayerController))]
            ///  extern void UNLOCK_RECIPE_00 (nint recipe, System.Boolean displayMessage, nint source);

            
            /// <summary>
            ///  abstract System.Void UnlockRecipe(RecipesData recipe, System.Boolean displayMessage, AutoUnlocksData source)
            /// </summary>
            /// <param name="recipe">class RecipesData</param>
            /// <param name="displayMessage">struct System.Boolean</param>
            /// <param name="source">class AutoUnlocksData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnlockRecipe", Search = typeof(Search_LocalPlayerController))]
            ///  extern void UNLOCK_RECIPE_01 (nint recipe, System.Boolean displayMessage, nint source);

            
            /// <summary>
            ///   System.Void UnlockShopItem(InventoryItemsData blueprint, System.Boolean displayMessage, AutoUnlocksData source)
            /// </summary>
            /// <param name="blueprint">class InventoryItemsData</param>
            /// <param name="displayMessage">struct System.Boolean</param>
            /// <param name="source">class AutoUnlocksData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnlockShopItem", Search = typeof(Search_LocalPlayerController))]
            ///  extern void UNLOCK_SHOP_ITEM_00 (nint blueprint, System.Boolean displayMessage, nint source);

            
            /// <summary>
            ///  abstract System.Void UnlockShopItem(InventoryItemsData item, System.Boolean displayMessage, AutoUnlocksData source)
            /// </summary>
            /// <param name="item">class InventoryItemsData</param>
            /// <param name="displayMessage">struct System.Boolean</param>
            /// <param name="source">class AutoUnlocksData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnlockShopItem", Search = typeof(Search_LocalPlayerController))]
            ///  extern void UNLOCK_SHOP_ITEM_01 (nint item, System.Boolean displayMessage, nint source);

            
            /// <summary>
            ///   System.Void Update()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Update", Search = typeof(Search_LocalPlayerController))]
            ///  extern void UPDATE_00 ();

            
            /// <summary>
            ///   System.Void Update()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Update", Search = typeof(Search_LocalPlayerController))]
            ///  extern void UPDATE_01 ();

            
            /// public static partial class Search_LocalPlayerController
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    ///   System.Boolean IsFrozen(PlayerController.FreezeMode mode)
                    /// </summary>
                    /// public static bool IS_FROZEN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsFrozen", "PlayerController.FreezeMode");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Boolean IsFrozen(PlayerController.FreezeMode mode)
                    /// </summary>
                    /// public static bool IS_FROZEN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsFrozen", "PlayerController.FreezeMode");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean IsInvoking()
                    /// </summary>
                    /// public static bool IS_INVOKING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsInvoking");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean IsInvoking(System.String methodName)
                    /// </summary>
                    /// public static bool IS_INVOKING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsInvoking", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
                    /// </summary>
                    /// public static bool IS_INVOKING_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsInvoking", "UnityEngine.MonoBehaviour", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   Cysharp.Threading.Tasks.UniTask Kill(PlayerDeathType deathType, System.Boolean animateFade)
                    /// </summary>
                    /// public static bool KILL_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Kill", "PlayerDeathType", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   Cysharp.Threading.Tasks.UniTask Kill(System.String reviveAtSpawnPoint, Level reviveInLevel, PlayerDeathType deathType, System.Boolean performFade, System.Boolean showDeathScreen, DungeonController.DungeonFailureReason failureReason)
                    /// </summary>
                    /// public static bool KILL_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Kill", "System.String", "Level", "PlayerDeathType", "System.Boolean", "System.Boolean", "DungeonController.DungeonFailureReason");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   Cysharp.Threading.Tasks.UniTask Kill(LevelPosition reviveAtLocation, PlayerDeathType deathType, System.Boolean performFade, System.Boolean atRiskLoot)
                    /// </summary>
                    /// public static bool KILL_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Kill", "LevelPosition", "PlayerDeathType", "System.Boolean", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract Cysharp.Threading.Tasks.UniTask Kill(PlayerDeathType deathType, System.Boolean animateFade)
                    /// </summary>
                    /// public static bool KILL_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Kill", "PlayerDeathType", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract Cysharp.Threading.Tasks.UniTask Kill(System.String reviveAtSpawnpoint, Level reviveInLevel, PlayerDeathType deathType, System.Boolean performFade, System.Boolean showDeathScreen, DungeonController.DungeonFailureReason dungeonFailureReason)
                    /// </summary>
                    /// public static bool KILL_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Kill", "System.String", "Level", "PlayerDeathType", "System.Boolean", "System.Boolean", "DungeonController.DungeonFailureReason");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract Cysharp.Threading.Tasks.UniTask Kill(LevelPosition reviveAtLocation, PlayerDeathType deathType, System.Boolean performFade, System.Boolean atRiskLoot)
                    /// </summary>
                    /// public static bool KILL_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Kill", "LevelPosition", "PlayerDeathType", "System.Boolean", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnCreate()
                    /// </summary>
                    /// public static bool ON_CREATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnCreate");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnCreate()
                    /// </summary>
                    /// public static bool ON_CREATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnCreate");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnDestroyed()
                    /// </summary>
                    /// public static bool ON_DESTROYED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnDestroyed");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnDestroyed()
                    /// </summary>
                    /// public static bool ON_DESTROYED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnDestroyed");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnGameUIInitialized(GameUI gameUI)
                    /// </summary>
                    /// public static bool ON_GAME_UI_INITIALIZED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnGameUIInitialized", "GameUI");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnGameUIInitialized(GameUI gameUI)
                    /// </summary>
                    /// public static bool ON_GAME_UI_INITIALIZED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnGameUIInitialized", "GameUI");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Pickup(Pickupable obj)
                    /// </summary>
                    /// public static bool PICKUP_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Pickup", "Pickupable");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void Pickup(Pickupable obj)
                    /// </summary>
                    /// public static bool PICKUP_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Pickup", "Pickupable");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void remove_OnInteractCallback(System.Action<PlayerController,Unity.Mathematics.int2> value)
                    /// </summary>
                    /// public static bool REMOVE_ON_INTERACT_CALLBACK_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "remove_OnInteractCallback", "System.Action<PlayerController,Unity.Mathematics.int2>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void remove_OnInteractCallback(System.Action<PlayerController,Unity.Mathematics.int2> value)
                    /// </summary>
                    /// public static bool REMOVE_ON_INTERACT_CALLBACK_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "remove_OnInteractCallback", "System.Action<PlayerController,Unity.Mathematics.int2>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void remove_OnPlayerTeleported(System.Action<LevelPosition> value)
                    /// </summary>
                    /// public static bool REMOVE_ON_PLAYER_TELEPORTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "remove_OnPlayerTeleported", "System.Action<LevelPosition>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void remove_OnPlayerTeleported(System.Action<LevelPosition> value)
                    /// </summary>
                    /// public static bool REMOVE_ON_PLAYER_TELEPORTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "remove_OnPlayerTeleported", "System.Action<LevelPosition>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void RemoveFreeze(PlayerController.PlayerFreeze freeze)
                    /// </summary>
                    /// public static bool REMOVE_FREEZE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveFreeze", "PlayerController.PlayerFreeze");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void RemoveFreeze(PlayerController.PlayerFreeze freeze)
                    /// </summary>
                    /// public static bool REMOVE_FREEZE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveFreeze", "PlayerController.PlayerFreeze");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessage(System.String methodName, System.Object value)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String", "System.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessage(System.String methodName)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String", "System.Object", "UnityEngine.SendMessageOptions");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessage(System.String methodName, UnityEngine.SendMessageOptions options)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String", "UnityEngine.SendMessageOptions");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessageUpwards(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_UPWARDS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String", "System.Object", "UnityEngine.SendMessageOptions");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessageUpwards(System.String methodName, System.Object value)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_UPWARDS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String", "System.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessageUpwards(System.String methodName)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_UPWARDS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessageUpwards(System.String methodName, UnityEngine.SendMessageOptions options)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_UPWARDS_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String", "UnityEngine.SendMessageOptions");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void set_Money(System.Int32 value)
                    /// </summary>
                    /// public static bool SET_MONEY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "set_Money", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void set_Money(System.Int32 value)
                    /// </summary>
                    /// public static bool SET_MONEY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "set_Money", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SetCarrying(Carryable carryable)
                    /// </summary>
                    /// public static bool SET_CARRYING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetCarrying", "Carryable");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void SetCarrying(Carryable carryable)
                    /// </summary>
                    /// public static bool SET_CARRYING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetCarrying", "Carryable");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SetIsInCutscene(System.Boolean inCutscene)
                    /// </summary>
                    /// public static bool SET_IS_IN_CUTSCENE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetIsInCutscene", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void SetIsInCutscene(System.Boolean inCutscene)
                    /// </summary>
                    /// public static bool SET_IS_IN_CUTSCENE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetIsInCutscene", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   Cysharp.Threading.Tasks.UniTask SetLevel(Level level, System.String spawnpointName, System.Boolean animateFade)
                    /// </summary>
                    /// public static bool SET_LEVEL_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetLevel", "Level", "System.String", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract Cysharp.Threading.Tasks.UniTask SetLevel(Level level, System.String spawnpointName, System.Boolean animateFade)
                    /// </summary>
                    /// public static bool SET_LEVEL_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetLevel", "Level", "System.String", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   Cysharp.Threading.Tasks.UniTask<System.Boolean> ShowNewTools()
                    /// </summary>
                    /// public static bool SHOW_NEW_TOOLS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ShowNewTools");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   Cysharp.Threading.Tasks.UniTask<System.Boolean> ShowNewTools(System.Threading.CancellationToken cancellationToken)
                    /// </summary>
                    /// public static bool SHOW_NEW_TOOLS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ShowNewTools", "System.Threading.CancellationToken");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
                    /// </summary>
                    /// public static bool START_COROUTINE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartCoroutine", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
                    /// </summary>
                    /// public static bool START_COROUTINE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartCoroutine", "System.String", "System.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
                    /// </summary>
                    /// public static bool START_COROUTINE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartCoroutine", "System.Collections.IEnumerator");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
                    /// </summary>
                    /// public static bool STOP_COROUTINE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopCoroutine", "System.Collections.IEnumerator");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
                    /// </summary>
                    /// public static bool STOP_COROUTINE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopCoroutine", "UnityEngine.Coroutine");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void StopCoroutine(System.String methodName)
                    /// </summary>
                    /// public static bool STOP_COROUTINE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopCoroutine", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void TeleportToLevelForCutscene(Level level)
                    /// </summary>
                    /// public static bool TELEPORT_TO_LEVEL_FOR_CUTSCENE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TeleportToLevelForCutscene", "Level");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void TeleportToLevelForCutscene(Level level)
                    /// </summary>
                    /// public static bool TELEPORT_TO_LEVEL_FOR_CUTSCENE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TeleportToLevelForCutscene", "Level");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void TeleportWithFade(LevelPosition target, System.Action callbackAtBlack, System.Single delay)
                    /// </summary>
                    /// public static bool TELEPORT_WITH_FADE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TeleportWithFade", "LevelPosition", "System.Action", "System.Single");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void TeleportWithFade(LevelPosition target, System.Action callbackAtBlack, System.Single delay)
                    /// </summary>
                    /// public static bool TELEPORT_WITH_FADE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TeleportWithFade", "LevelPosition", "System.Action", "System.Single");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.String ToString()
                    /// </summary>
                    /// public static bool TO_STRING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.String ToString(UnityEngine.Object obj)
                    /// </summary>
                    /// public static bool TO_STRING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString", "UnityEngine.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
                    /// </summary>
                    /// public static bool TRY_GET_COMPONENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TryGetComponent", "System.Type", "UnityEngine.Component&");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean TryGetComponent(T& component)
                    /// </summary>
                    /// public static bool TRY_GET_COMPONENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TryGetComponent", "T&");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void UnlockBlueprint(InventoryItemsData blueprint, System.Boolean displayMessage, AutoUnlocksData source)
                    /// </summary>
                    /// public static bool UNLOCK_BLUEPRINT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "UnlockBlueprint", "InventoryItemsData", "System.Boolean", "AutoUnlocksData");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void UnlockBlueprint(InventoryItemsData item, System.Boolean displayMessage, AutoUnlocksData source)
                    /// </summary>
                    /// public static bool UNLOCK_BLUEPRINT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "UnlockBlueprint", "InventoryItemsData", "System.Boolean", "AutoUnlocksData");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void UnlockRecipe(RecipesData recipe, System.Boolean displayMessage, AutoUnlocksData source)
                    /// </summary>
                    /// public static bool UNLOCK_RECIPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "UnlockRecipe", "RecipesData", "System.Boolean", "AutoUnlocksData");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void UnlockRecipe(RecipesData recipe, System.Boolean displayMessage, AutoUnlocksData source)
                    /// </summary>
                    /// public static bool UNLOCK_RECIPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "UnlockRecipe", "RecipesData", "System.Boolean", "AutoUnlocksData");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void UnlockShopItem(InventoryItemsData blueprint, System.Boolean displayMessage, AutoUnlocksData source)
                    /// </summary>
                    /// public static bool UNLOCK_SHOP_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "UnlockShopItem", "InventoryItemsData", "System.Boolean", "AutoUnlocksData");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void UnlockShopItem(InventoryItemsData item, System.Boolean displayMessage, AutoUnlocksData source)
                    /// </summary>
                    /// public static bool UNLOCK_SHOP_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "UnlockShopItem", "InventoryItemsData", "System.Boolean", "AutoUnlocksData");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Update()
                    /// </summary>
                    /// public static bool UPDATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Update");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Update()
                    /// </summary>
                    /// public static bool UPDATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Update");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}