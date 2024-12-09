

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
    /// class ["AzureValley".""."Inventory"]
    /// [System.Object]
    /// [MessagePack.IMessagePackSerializationCallbackReceiver]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x02000109U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [73, 110, 118, 101, 110, 116, 111, 114, 121])]


    // class 0x10 System.Action<ItemStack> OnAddedToInventory
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnAddedToInventory", "ON_ADDED_TO_INVENTORY")]

    // class 0x18 System.Action<ItemStack,System.Int32> OnRemovedFromInventory
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnRemovedFromInventory", "ON_REMOVED_FROM_INVENTORY")]

    // class 0x20 System.Action<ItemStack> OnNotifyAddedToInventory
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnNotifyAddedToInventory", "ON_NOTIFY_ADDED_TO_INVENTORY")]

    // class 0x28 System.Action<ItemStack,System.Int32> OnNotifyRemovedFromInventory
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnNotifyRemovedFromInventory", "ON_NOTIFY_REMOVED_FROM_INVENTORY")]

    // class 0x30 ItemStack[] m_items
      [MonoCollectorSearchFieldAttribute(typeof(PMonoArray<ItemStack.Ptr_ItemStack>),"m_items", "M_ITEMS")]

    // class 0x38 ItemFilter[] m_filters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_filters", "M_FILTERS")]

    // class 0x40 System.Action<Inventory,Inventory,System.Int32,System.Int32> OnItemSwap
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnItemSwap", "ON_ITEM_SWAP")]

    // class 0x48 System.Action OnSwapAnimationCompleted
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnSwapAnimationCompleted", "ON_SWAP_ANIMATION_COMPLETED")]

    // class 0x50 System.Action<Inventory,Inventory,System.Int32,System.Int32> OnAnyItemSwap
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnAnyItemSwap", "ON_ANY_ITEM_SWAP")]

    // class 0x58 System.Action OnInventoryUpdated
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnInventoryUpdated", "ON_INVENTORY_UPDATED")]

    // class 0x60 System.Action<System.Int32> <OnChange>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<OnChange>k__BackingField", "ON_CHANGE")]

    // class 0x68 System.Action<InventoryChangeEvent> <OnChangeDetailed>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<OnChangeDetailed>k__BackingField", "ON_CHANGE_DETAILED")]

    // class 0x70 System.Action <OnSorted>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<OnSorted>k__BackingField", "ON_SORTED")]

    // class 0x78 System.Action <OnResize>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<OnResize>k__BackingField", "ON_RESIZE")]

    // class 0x80 ItemStack[] m_currencyAndQuest
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_currencyAndQuest", "M_CURRENCY_AND_QUEST")]

    // abstract class 0x88 PlayerController <Player>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Player>k__BackingField", "PLAYER")]

    // struct 0x90 System.Int32 <NumSlots>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"<NumSlots>k__BackingField", "NUM_SLOTS")]

    // struct 0x94 System.Int32 <PreferredStartSlot>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"<PreferredStartSlot>k__BackingField", "PREFERRED_START_SLOT")]

    // struct 0x98 System.Int32 <LastChangedSlot>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"<LastChangedSlot>k__BackingField", "LAST_CHANGED_SLOT")]

    // struct 0x9C System.Boolean <UseMaxStackSizes>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<UseMaxStackSizes>k__BackingField", "USE_MAX_STACK_SIZES")]

    // struct 0x9D System.Boolean <AutoGrow>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<AutoGrow>k__BackingField", "AUTO_GROW")]

    // struct 0x9E System.Boolean <AutoDeleteEmptyStacks>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<AutoDeleteEmptyStacks>k__BackingField", "AUTO_DELETE_EMPTY_STACKS")]

    // struct 0xA0 System.Int32 <AutoGrowStepSize>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"<AutoGrowStepSize>k__BackingField", "AUTO_GROW_STEP_SIZE")]
    public partial class Inventory
    {
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "Inventory";
        //public static byte[] Static_ClassName { get; } = [73, 110, 118, 101, 110, 116, 111, 114, 121];

        //public const uint Const_TypeToken = 0x02000109U;




        /// <summary>
        /// struct System.Int32 HotbarMaxIndex "0"
        /// </summary>
        /// public const System.Int32 HOTBAR_MAX_INDEX=>"0";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Inventory(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Inventory(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Inventory obj) => obj._ptr;
            public static implicit operator bool(Ptr_Inventory obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["AzureValley".""."Inventory"]
    /// </summary>
    public partial class Inventory
    {



        /// <summary>
        ///   System.Void add_OnAddedToInventory(System.Action<ItemStack> value)
        /// </summary>
        /// <param name="value">class System.Action<ItemStack></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnAddedToInventory")]
        ///  extern void ADD_ON_ADDED_TO_INVENTORY (nint value);


        /// <summary>
        ///   System.Void add_OnNotifyAddedToInventory(System.Action<ItemStack> value)
        /// </summary>
        /// <param name="value">class System.Action<ItemStack></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnNotifyAddedToInventory")]
        ///  extern void ADD_ON_NOTIFY_ADDED_TO_INVENTORY (nint value);


        /// <summary>
        ///   System.Void add_OnNotifyRemovedFromInventory(System.Action<ItemStack,System.Int32> value)
        /// </summary>
        /// <param name="value">class System.Action<ItemStack,System.Int32></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnNotifyRemovedFromInventory")]
        ///  extern void ADD_ON_NOTIFY_REMOVED_FROM_INVENTORY (nint value);


        /// <summary>
        ///   System.Boolean AddToolToInventory(InventoryItem newItem, System.Int32 amount, System.Boolean showOnItemLog)
        /// </summary>
        /// <param name="newItem">class InventoryItem</param>
        /// <param name="amount">struct System.Int32</param>
        /// <param name="showOnItemLog">struct System.Boolean</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddToolToInventory")]
        ///  extern System.Boolean ADD_TOOL_TO_INVENTORY (nint newItem, System.Int32 amount, System.Boolean showOnItemLog);


        /// <summary>
        ///   System.Void Clear()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clear")]
        ///  extern void CLEAR ();


        /// <summary>
        ///   System.Void CopyItems(Inventory copy)
        /// </summary>
        /// <param name="copy">class Inventory</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CopyItems")]
        ///  extern void COPY_ITEMS (nint copy);


        /// <summary>
        ///   System.Void DoAutoGrow(System.Int32 numNewCells)
        /// </summary>
        /// <param name="numNewCells">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DoAutoGrow")]
        ///  extern void DO_AUTO_GROW (System.Int32 numNewCells);


        /// <summary>
        ///   System.Void DropStackAsMagneticLoot(System.Int32 slot, MagneticLootFlags flags, System.Boolean canCallFromClient)
        /// </summary>
        /// <param name="slot">struct System.Int32</param>
        /// <param name="flags">enum MagneticLootFlags</param>
        /// <param name="canCallFromClient">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DropStackAsMagneticLoot")]
        ///  extern void DROP_STACK_AS_MAGNETIC_LOOT (System.Int32 slot, MagneticLootFlags flags, System.Boolean canCallFromClient);


        /// <summary>
        ///   System.Void ForceSetStack(System.Int32 slot, ItemStack stack)
        /// </summary>
        /// <param name="slot">struct System.Int32</param>
        /// <param name="stack">class ItemStack</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ForceSetStack")]
        ///  extern void FORCE_SET_STACK (System.Int32 slot, nint stack);


        /// <summary>
        ///   System.Boolean get_AutoDeleteEmptyStacks()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AutoDeleteEmptyStacks")]
        ///  extern System.Boolean GET_AUTO_DELETE_EMPTY_STACKS ();


        /// <summary>
        ///   System.Boolean get_AutoGrow()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AutoGrow")]
        ///  extern System.Boolean GET_AUTO_GROW ();


        /// <summary>
        ///   System.Int32 get_AutoGrowStepSize()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AutoGrowStepSize")]
        ///  extern System.Int32 GET_AUTO_GROW_STEP_SIZE ();


        /// <summary>
        ///   System.Int32 get_LastChangedSlot()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LastChangedSlot")]
        ///  extern System.Int32 GET_LAST_CHANGED_SLOT ();


        /// <summary>
        ///   System.Int32 get_NumSlots()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_NumSlots")]
        ///  extern System.Int32 GET_NUM_SLOTS ();


        /// <summary>
        ///   System.Action<System.Int32> get_OnChange()
        /// </summary>
        /// <returns>class System.Action<System.Int32></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnChange")]
        ///  extern nint GET_ON_CHANGE ();


        /// <summary>
        ///   System.Action<InventoryChangeEvent> get_OnChangeDetailed()
        /// </summary>
        /// <returns>class System.Action<InventoryChangeEvent></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnChangeDetailed")]
        ///  extern nint GET_ON_CHANGE_DETAILED ();


        /// <summary>
        ///   System.Action get_OnResize()
        /// </summary>
        /// <returns>class System.Action</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnResize")]
        ///  extern nint GET_ON_RESIZE ();


        /// <summary>
        ///   System.Action get_OnSorted()
        /// </summary>
        /// <returns>class System.Action</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnSorted")]
        ///  extern nint GET_ON_SORTED ();


        /// <summary>
        ///   PlayerController get_Player()
        /// </summary>
        /// <returns>abstract class PlayerController</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Player")]
        ///  extern nint GET_PLAYER ();


        /// <summary>
        ///   System.Int32 get_PreferredStartSlot()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PreferredStartSlot")]
        ///  extern System.Int32 GET_PREFERRED_START_SLOT ();


        /// <summary>
        ///   System.Boolean get_UseMaxStackSizes()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UseMaxStackSizes")]
        ///  extern System.Boolean GET_USE_MAX_STACK_SIZES ();


        /// <summary>
        ///   System.Collections.Generic.List<ItemStack> GetAllNonNullStacks()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<ItemStack></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAllNonNullStacks")]
        ///  extern nint GET_ALL_NON_NULL_STACKS ();


        /// <summary>
        ///   ItemStack[] GetAllStacks()
        /// </summary>
        /// <returns>class ItemStack[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAllStacks")]
        ///  extern nint GET_ALL_STACKS ();


        /// <summary>
        ///   System.Int32 GetAmount(InventoryItemsData itemType)
        /// </summary>
        /// <param name="itemType">class InventoryItemsData</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAmount")]
        ///  extern System.Int32 GET_AMOUNT (nint itemType);


        /// <summary>
        ///   System.Int32 GetCount(InventoryItemsData type)
        /// </summary>
        /// <param name="type">class InventoryItemsData</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCount")]
        ///  extern System.Int32 GET_COUNT (nint type);


        /// <summary>
        ///   System.Int32 GetCurrencyAmount(System.String currencyName)
        /// </summary>
        /// <param name="currencyName">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCurrencyAmount")]
        ///  extern System.Int32 GET_CURRENCY_AMOUNT (nint currencyName);


        /// <summary>
        ///   System.Int32 GetEmptyHotbarSlot()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEmptyHotbarSlot")]
        ///  extern System.Int32 GET_EMPTY_HOTBAR_SLOT ();


        /// <summary>
        ///   System.Int32 GetEmptyNonHotbarSlot()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEmptyNonHotbarSlot")]
        ///  extern System.Int32 GET_EMPTY_NON_HOTBAR_SLOT ();


        /// <summary>
        ///   System.Int32 GetEmptySlot()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEmptySlot")]
        ///  extern System.Int32 GET_EMPTY_SLOT ();


        /// <summary>
        ///   ItemFilter GetFilter(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class ItemFilter</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetFilter")]
        ///  extern nint GET_FILTER (System.Int32 index);


        /// <summary>
        ///   ItemStack[] GetHotbar()
        /// </summary>
        /// <returns>class ItemStack[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHotbar")]
        ///  extern nint GET_HOTBAR ();


        /// <summary>
        ///   System.Int32[] GetHotbarSlotsByFilter(System.Func<InventoryItem,System.Boolean> filter)
        /// </summary>
        /// <param name="filter">class System.Func<InventoryItem,System.Boolean></param>
        /// <returns>class System.Int32[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHotbarSlotsByFilter")]
        ///  extern nint GET_HOTBAR_SLOTS_BY_FILTER (nint filter);


        /// <summary>
        ///   InventoryItem[] GetItemsByFilter(System.Func<InventoryItem,System.Boolean> filter)
        /// </summary>
        /// <param name="filter">class System.Func<InventoryItem,System.Boolean></param>
        /// <returns>class InventoryItem[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemsByFilter")]
        ///  extern nint GET_ITEMS_BY_FILTER (nint filter);


        /// <summary>
        ///   InventoryItem GetItemWithClassification(System.String classification)
        /// </summary>
        /// <param name="classification">class System.String</param>
        /// <returns>class InventoryItem</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemWithClassification")]
        ///  extern nint GET_ITEM_WITH_CLASSIFICATION (nint classification);


        /// <summary>
        ///   System.Int32 GetMaxStack(InventoryItemsData type)
        /// </summary>
        /// <param name="type">class InventoryItemsData</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetMaxStack")]
        ///  extern System.Int32 GET_MAX_STACK (nint type);


        /// <summary>
        ///   System.Int32 GetPotentialSpace(InventoryItemsData type)
        /// </summary>
        /// <param name="type">class InventoryItemsData</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetPotentialSpace")]
        ///  extern System.Int32 GET_POTENTIAL_SPACE (nint type);


        /// <summary>
        ///   System.Collections.Generic.IEnumerable<System.Int32> GetPreferredOrder(InventoryItemsData type)
        /// </summary>
        /// <param name="type">class InventoryItemsData</param>
        /// <returns>interface System.Collections.Generic.IEnumerable<System.Int32></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetPreferredOrder")]
        ///  extern nint GET_PREFERRED_ORDER (nint type);


        /// <summary>
        ///   System.Int32[] GetSlotsByFilter(System.Func<InventoryItem,System.Boolean> filter)
        /// </summary>
        /// <param name="filter">class System.Func<InventoryItem,System.Boolean></param>
        /// <returns>class System.Int32[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSlotsByFilter")]
        ///  extern nint GET_SLOTS_BY_FILTER (nint filter);


        /// <summary>
        ///   System.Int32 GetSpaceFor(InventoryItemsData type, ItemVariation variation)
        /// </summary>
        /// <param name="type">class InventoryItemsData</param>
        /// <param name="variation">class ItemVariation</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSpaceFor")]
        ///  extern System.Int32 GET_SPACE_FOR (nint type, nint variation);


        /// <summary>
        ///   InventoryItem GetStackItemNonAlloc(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class InventoryItem</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetStackItemNonAlloc")]
        ///  extern nint GET_STACK_ITEM_NON_ALLOC (System.Int32 index);


        /// <summary>
        ///   System.Int32 GetTotalStacks()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTotalStacks")]
        ///  extern System.Int32 GET_TOTAL_STACKS ();


        /// <summary>
        ///   System.Boolean HasPlaceFor(InventoryItemsData type, System.Int32 amount, ItemVariation variation)
        /// </summary>
        /// <param name="type">class InventoryItemsData</param>
        /// <param name="amount">struct System.Int32</param>
        /// <param name="variation">class ItemVariation</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasPlaceFor")]
        ///  extern System.Boolean HAS_PLACE_FOR (nint type, System.Int32 amount, nint variation);


        /// <summary>
        ///   System.Void IncreaseItemXP(InventoryItem item)
        /// </summary>
        /// <param name="item">class InventoryItem</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IncreaseItemXP")]
        ///  extern void INCREASE_ITEM_XP (nint item);


        /// <summary>
        ///   System.Boolean IsEmpty()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsEmpty")]
        ///  extern System.Boolean IS_EMPTY ();


        /// <summary>
        ///   System.Void Move(System.Int32 startingIndex, System.Int32 targetIndex)
        /// </summary>
        /// <param name="startingIndex">struct System.Int32</param>
        /// <param name="targetIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Move")]
        ///  extern void MOVE (System.Int32 startingIndex, System.Int32 targetIndex);


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
        ///   System.Void remove_OnAddedToInventory(System.Action<ItemStack> value)
        /// </summary>
        /// <param name="value">class System.Action<ItemStack></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnAddedToInventory")]
        ///  extern void REMOVE_ON_ADDED_TO_INVENTORY (nint value);


        /// <summary>
        ///   System.Void remove_OnNotifyAddedToInventory(System.Action<ItemStack> value)
        /// </summary>
        /// <param name="value">class System.Action<ItemStack></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnNotifyAddedToInventory")]
        ///  extern void REMOVE_ON_NOTIFY_ADDED_TO_INVENTORY (nint value);


        /// <summary>
        ///   System.Void remove_OnNotifyRemovedFromInventory(System.Action<ItemStack,System.Int32> value)
        /// </summary>
        /// <param name="value">class System.Action<ItemStack,System.Int32></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnNotifyRemovedFromInventory")]
        ///  extern void REMOVE_ON_NOTIFY_REMOVED_FROM_INVENTORY (nint value);


        /// <summary>
        ///   System.Boolean RemoveOneIfContained(InventoryItemsData type)
        /// </summary>
        /// <param name="type">class InventoryItemsData</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveOneIfContained")]
        ///  extern System.Boolean REMOVE_ONE_IF_CONTAINED (nint type);


        /// <summary>
        ///   System.Void Repaint(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Repaint")]
        ///  extern void REPAINT (System.Int32 index);


        /// <summary>
        ///   System.Void Replace(System.Int32 slot, InventoryItem newItem, System.Int32 amount)
        /// </summary>
        /// <param name="slot">struct System.Int32</param>
        /// <param name="newItem">class InventoryItem</param>
        /// <param name="amount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Replace")]
        ///  extern void REPLACE (System.Int32 slot, nint newItem, System.Int32 amount);


        /// <summary>
        ///   System.Void Resize(System.Int32 newSize)
        /// </summary>
        /// <param name="newSize">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Resize")]
        ///  extern void RESIZE (System.Int32 newSize);


        /// <summary>
        ///   System.Void set_AutoDeleteEmptyStacks(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_AutoDeleteEmptyStacks")]
        ///  extern void SET_AUTO_DELETE_EMPTY_STACKS (System.Boolean value);


        /// <summary>
        ///   System.Void set_AutoGrow(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_AutoGrow")]
        ///  extern void SET_AUTO_GROW (System.Boolean value);


        /// <summary>
        ///   System.Void set_AutoGrowStepSize(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_AutoGrowStepSize")]
        ///  extern void SET_AUTO_GROW_STEP_SIZE (System.Int32 value);


        /// <summary>
        ///   System.Void set_LastChangedSlot(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_LastChangedSlot")]
        ///  extern void SET_LAST_CHANGED_SLOT (System.Int32 value);


        /// <summary>
        ///   System.Void set_NumSlots(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_NumSlots")]
        ///  extern void SET_NUM_SLOTS (System.Int32 value);


        /// <summary>
        ///   System.Void set_OnChange(System.Action<System.Int32> value)
        /// </summary>
        /// <param name="value">class System.Action<System.Int32></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_OnChange")]
        ///  extern void SET_ON_CHANGE (nint value);


        /// <summary>
        ///   System.Void set_OnChangeDetailed(System.Action<InventoryChangeEvent> value)
        /// </summary>
        /// <param name="value">class System.Action<InventoryChangeEvent></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_OnChangeDetailed")]
        ///  extern void SET_ON_CHANGE_DETAILED (nint value);


        /// <summary>
        ///   System.Void set_OnResize(System.Action value)
        /// </summary>
        /// <param name="value">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_OnResize")]
        ///  extern void SET_ON_RESIZE (nint value);


        /// <summary>
        ///   System.Void set_OnSorted(System.Action value)
        /// </summary>
        /// <param name="value">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_OnSorted")]
        ///  extern void SET_ON_SORTED (nint value);


        /// <summary>
        ///   System.Void set_Player(PlayerController value)
        /// </summary>
        /// <param name="value">abstract class PlayerController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Player")]
        ///  extern void SET_PLAYER (nint value);


        /// <summary>
        ///   System.Void set_PreferredStartSlot(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_PreferredStartSlot")]
        ///  extern void SET_PREFERRED_START_SLOT (System.Int32 value);


        /// <summary>
        ///   System.Void set_UseMaxStackSizes(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_UseMaxStackSizes")]
        ///  extern void SET_USE_MAX_STACK_SIZES (System.Boolean value);


        /// <summary>
        ///   System.Void SetCurrencyAmount(System.String currencyName, System.Int32 amount)
        /// </summary>
        /// <param name="currencyName">class System.String</param>
        /// <param name="amount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCurrencyAmount")]
        ///  extern void SET_CURRENCY_AMOUNT (nint currencyName, System.Int32 amount);


        /// <summary>
        ///   System.Void SetFilters(System.Collections.Generic.List<ItemFilter> filters)
        /// </summary>
        /// <param name="filters">class System.Collections.Generic.List<ItemFilter></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFilters")]
        ///  extern void SET_FILTERS (nint filters);


        /// <summary>
        ///   System.Void SetPlayer(PlayerController player)
        /// </summary>
        /// <param name="player">abstract class PlayerController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetPlayer")]
        ///  extern void SET_PLAYER (nint player);


        /// <summary>
        ///   System.Void SlotChanged(System.Int32 index, System.Int32 changeAmount, InventoryItemsData changedType, System.Boolean triggerUpdated)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="changeAmount">struct System.Int32</param>
        /// <param name="changedType">class InventoryItemsData</param>
        /// <param name="triggerUpdated">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SlotChanged")]
        ///  extern void SLOT_CHANGED (System.Int32 index, System.Int32 changeAmount, nint changedType, System.Boolean triggerUpdated);


        /// <summary>
        ///   System.Void Sort(System.Collections.Generic.IComparer<ItemStack> order, System.Boolean excludeHotbar)
        /// </summary>
        /// <param name="order">interface System.Collections.Generic.IComparer<ItemStack></param>
        /// <param name="excludeHotbar">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Sort")]
        ///  extern void SORT (nint order, System.Boolean excludeHotbar);


        /// <summary>
        /// static  System.Void Swap(Inventory srcInventory, Inventory destInventory, System.Int32 srcIndex, System.Int32 destIndex)
        /// </summary>
        /// <param name="srcInventory">class Inventory</param>
        /// <param name="destInventory">class Inventory</param>
        /// <param name="srcIndex">struct System.Int32</param>
        /// <param name="destIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Swap")]
        /// static extern void SWAP (nint srcInventory, nint destInventory, System.Int32 srcIndex, System.Int32 destIndex);


        /// <summary>
        ///   System.Int32 TakeFromSlot(InventoryItem item, System.Int32 amount, System.Int32 index)
        /// </summary>
        /// <param name="item">class InventoryItem</param>
        /// <param name="amount">struct System.Int32</param>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TakeFromSlot")]
        ///  extern System.Int32 TAKE_FROM_SLOT (nint item, System.Int32 amount, System.Int32 index);


        /// <summary>
        ///   InventoryItem TakeOneExact(InventoryItemsData type, System.Boolean showNotification)
        /// </summary>
        /// <param name="type">class InventoryItemsData</param>
        /// <param name="showNotification">struct System.Boolean</param>
        /// <returns>class InventoryItem</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TakeOneExact")]
        ///  extern nint TAKE_ONE_EXACT (nint type, System.Boolean showNotification);


        /// <summary>
        ///   System.Boolean TransferOne(Inventory transferTo, InventoryItemsData itemType, System.Boolean showNotification)
        /// </summary>
        /// <param name="transferTo">class Inventory</param>
        /// <param name="itemType">class InventoryItemsData</param>
        /// <param name="showNotification">struct System.Boolean</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransferOne")]
        ///  extern System.Boolean TRANSFER_ONE (nint transferTo, nint itemType, System.Boolean showNotification);


        /// <summary>
        ///   System.Boolean TryTakeOne(InventoryItem item, System.Int32 i, System.Boolean showNotification)
        /// </summary>
        /// <param name="item">class InventoryItem</param>
        /// <param name="i">struct System.Int32</param>
        /// <param name="showNotification">struct System.Boolean</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryTakeOne")]
        ///  extern System.Boolean TRY_TAKE_ONE (nint item, System.Int32 i, System.Boolean showNotification);


        /// <summary>
        ///   System.Void UpdateAchievements(InventoryItem item, System.Int32 amount)
        /// </summary>
        /// <param name="item">class InventoryItem</param>
        /// <param name="amount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateAchievements")]
        ///  extern void UPDATE_ACHIEVEMENTS (nint item, System.Int32 amount);



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Inventory))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor(System.Int32 numberOfSlots)
        /// </summary>
        /// <param name="numberOfSlots">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Inventory))]
        ///  extern void .CTOR_01 (System.Int32 numberOfSlots);


        /// <summary>
        ///   System.Void .ctor(Inventory copy)
        /// </summary>
        /// <param name="copy">class Inventory</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Inventory))]
        ///  extern void .CTOR_02 (nint copy);


        /// <summary>
        ///   System.Boolean Add(InventoryItem item, System.Int32 amount, System.Collections.Generic.List<System.Int32> targetedIndexes, System.Boolean showOnItemLog, System.Boolean canAddToHotbar)
        /// </summary>
        /// <param name="item">class InventoryItem</param>
        /// <param name="amount">struct System.Int32</param>
        /// <param name="targetedIndexes">class System.Collections.Generic.List<System.Int32></param>
        /// <param name="showOnItemLog">struct System.Boolean</param>
        /// <param name="canAddToHotbar">struct System.Boolean</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Add", Search = typeof(Search_Inventory))]
        ///  extern System.Boolean ADD_00 (nint item, System.Int32 amount, nint targetedIndexes, System.Boolean showOnItemLog, System.Boolean canAddToHotbar);


        /// <summary>
        ///   System.Boolean Add(InventoryItemsData type, System.Int32 amount, ItemVariation variation, System.Boolean showOnItemLog)
        /// </summary>
        /// <param name="type">class InventoryItemsData</param>
        /// <param name="amount">struct System.Int32</param>
        /// <param name="variation">class ItemVariation</param>
        /// <param name="showOnItemLog">struct System.Boolean</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Add", Search = typeof(Search_Inventory))]
        ///  extern System.Boolean ADD_01 (nint type, System.Int32 amount, nint variation, System.Boolean showOnItemLog);


        /// <summary>
        ///   System.Int32 AddAtIndex(InventoryItem item, System.Int32 amount, System.Int32 index, System.Boolean showOnItemLog, System.Boolean overwrite)
        /// </summary>
        /// <param name="item">class InventoryItem</param>
        /// <param name="amount">struct System.Int32</param>
        /// <param name="index">struct System.Int32</param>
        /// <param name="showOnItemLog">struct System.Boolean</param>
        /// <param name="overwrite">struct System.Boolean</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAtIndex", Search = typeof(Search_Inventory))]
        ///  extern System.Int32 ADD_AT_INDEX_00 (nint item, System.Int32 amount, System.Int32 index, System.Boolean showOnItemLog, System.Boolean overwrite);


        /// <summary>
        ///   System.Int32 AddAtIndex(InventoryItemsData type, System.Int32 amount, System.Int32 index, ItemVariation variation, System.Boolean showOnItemLog)
        /// </summary>
        /// <param name="type">class InventoryItemsData</param>
        /// <param name="amount">struct System.Int32</param>
        /// <param name="index">struct System.Int32</param>
        /// <param name="variation">class ItemVariation</param>
        /// <param name="showOnItemLog">struct System.Boolean</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAtIndex", Search = typeof(Search_Inventory))]
        ///  extern System.Int32 ADD_AT_INDEX_01 (nint type, System.Int32 amount, System.Int32 index, nint variation, System.Boolean showOnItemLog);


        /// <summary>
        ///   System.Boolean AnyOf(ItemFilter filter)
        /// </summary>
        /// <param name="filter">class ItemFilter</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AnyOf", Search = typeof(Search_Inventory))]
        ///  extern System.Boolean ANY_OF_00 (nint filter);


        /// <summary>
        ///   System.Boolean AnyOf(InventoryItemsData type)
        /// </summary>
        /// <param name="type">class InventoryItemsData</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AnyOf", Search = typeof(Search_Inventory))]
        ///  extern System.Boolean ANY_OF_01 (nint type);


        /// <summary>
        ///   InventoryItemsData AnyOf(InventoryItemsData[] items)
        /// </summary>
        /// <param name="items">class InventoryItemsData[]</param>
        /// <returns>class InventoryItemsData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AnyOf", Search = typeof(Search_Inventory))]
        ///  extern nint ANY_OF_02 (nint items);


        /// <summary>
        ///   System.Boolean AnyOf(System.Func<InventoryItem,System.Boolean> filter)
        /// </summary>
        /// <param name="filter">class System.Func<InventoryItem,System.Boolean></param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AnyOf", Search = typeof(Search_Inventory))]
        ///  extern System.Boolean ANY_OF_03 (nint filter);


        /// <summary>
        ///   System.Boolean Contains(InventoryItem item)
        /// </summary>
        /// <param name="item">class InventoryItem</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Contains", Search = typeof(Search_Inventory))]
        ///  extern System.Boolean CONTAINS_00 (nint item);


        /// <summary>
        ///   System.Boolean Contains(ItemStack stack)
        /// </summary>
        /// <param name="stack">class ItemStack</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Contains", Search = typeof(Search_Inventory))]
        ///  extern System.Boolean CONTAINS_01 (nint stack);


        /// <summary>
        ///   System.Boolean Contains(System.Collections.Generic.List<ItemStack> required)
        /// </summary>
        /// <param name="required">class System.Collections.Generic.List<ItemStack></param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Contains", Search = typeof(Search_Inventory))]
        ///  extern System.Boolean CONTAINS_02 (nint required);


        /// <summary>
        ///   ItemStack GetStack(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class ItemStack</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetStack", Search = typeof(Search_Inventory))]
        ///  extern nint GET_STACK_00 (System.Int32 index);


        /// <summary>
        ///   ItemStack GetStack(ItemFilter filter)
        /// </summary>
        /// <param name="filter">class ItemFilter</param>
        /// <returns>class ItemStack</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetStack", Search = typeof(Search_Inventory))]
        ///  extern nint GET_STACK_01 (nint filter);


        /// <summary>
        ///   System.Int32 IndexOf(ItemStack stack)
        /// </summary>
        /// <param name="stack">class ItemStack</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IndexOf", Search = typeof(Search_Inventory))]
        ///  extern System.Int32 INDEX_OF_00 (nint stack);


        /// <summary>
        ///   System.Int32 IndexOf(InventoryItem item)
        /// </summary>
        /// <param name="item">class InventoryItem</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IndexOf", Search = typeof(Search_Inventory))]
        ///  extern System.Int32 INDEX_OF_01 (nint item);


        /// <summary>
        ///   System.Int32 IndexOf(InventoryItem item, System.Int32 amount)
        /// </summary>
        /// <param name="item">class InventoryItem</param>
        /// <param name="amount">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IndexOf", Search = typeof(Search_Inventory))]
        ///  extern System.Int32 INDEX_OF_02 (nint item, System.Int32 amount);


        /// <summary>
        ///   System.Int32 IndexOf(System.String item)
        /// </summary>
        /// <param name="item">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IndexOf", Search = typeof(Search_Inventory))]
        ///  extern System.Int32 INDEX_OF_03 (nint item);


        /// <summary>
        ///   System.Int32[] IndexOf(InventoryItemsData item)
        /// </summary>
        /// <param name="item">class InventoryItemsData</param>
        /// <returns>class System.Int32[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IndexOf", Search = typeof(Search_Inventory))]
        ///  extern nint INDEX_OF_04 (nint item);


        /// <summary>
        ///   System.Void SetUnsafe(System.Int32 slot, InventoryItemsData item, System.Int32 amount)
        /// </summary>
        /// <param name="slot">struct System.Int32</param>
        /// <param name="item">class InventoryItemsData</param>
        /// <param name="amount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUnsafe", Search = typeof(Search_Inventory))]
        ///  extern void SET_UNSAFE_00 (System.Int32 slot, nint item, System.Int32 amount);


        /// <summary>
        ///   System.Void SetUnsafe(System.Int32 slot, InventoryItem item, System.Int32 amount)
        /// </summary>
        /// <param name="slot">struct System.Int32</param>
        /// <param name="item">class InventoryItem</param>
        /// <param name="amount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUnsafe", Search = typeof(Search_Inventory))]
        ///  extern void SET_UNSAFE_01 (System.Int32 slot, nint item, System.Int32 amount);


        /// <summary>
        ///   System.Void Take(InventoryItemsData type, System.Int32 amount, System.Int32 preferredIndex)
        /// </summary>
        /// <param name="type">class InventoryItemsData</param>
        /// <param name="amount">struct System.Int32</param>
        /// <param name="preferredIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Take", Search = typeof(Search_Inventory))]
        ///  extern void TAKE_00 (nint type, System.Int32 amount, System.Int32 preferredIndex);


        /// <summary>
        ///   System.Int32 Take(InventoryItem item, System.Int32 amount, System.Int32 preferredIndex, System.Boolean showNotification)
        /// </summary>
        /// <param name="item">class InventoryItem</param>
        /// <param name="amount">struct System.Int32</param>
        /// <param name="preferredIndex">struct System.Int32</param>
        /// <param name="showNotification">struct System.Boolean</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Take", Search = typeof(Search_Inventory))]
        ///  extern System.Int32 TAKE_01 (nint item, System.Int32 amount, System.Int32 preferredIndex, System.Boolean showNotification);


        /// <summary>
        ///   System.Int32 Take(System.Collections.Generic.List<ItemStack> required, System.Int32 preferredIndex, System.Boolean onlyUsePreferredIndex, System.Boolean showNotification)
        /// </summary>
        /// <param name="required">class System.Collections.Generic.List<ItemStack></param>
        /// <param name="preferredIndex">struct System.Int32</param>
        /// <param name="onlyUsePreferredIndex">struct System.Boolean</param>
        /// <param name="showNotification">struct System.Boolean</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Take", Search = typeof(Search_Inventory))]
        ///  extern System.Int32 TAKE_02 (nint required, System.Int32 preferredIndex, System.Boolean onlyUsePreferredIndex, System.Boolean showNotification);


        /// <summary>
        ///   System.Int32 TakeOne(InventoryItemsData type, System.Int32 preferredIndex, System.Boolean showNotification)
        /// </summary>
        /// <param name="type">class InventoryItemsData</param>
        /// <param name="preferredIndex">struct System.Int32</param>
        /// <param name="showNotification">struct System.Boolean</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TakeOne", Search = typeof(Search_Inventory))]
        ///  extern System.Int32 TAKE_ONE_00 (nint type, System.Int32 preferredIndex, System.Boolean showNotification);


        /// <summary>
        ///   System.Int32 TakeOne(InventoryItem item, System.Int32 preferredIndex, System.Boolean showNotification)
        /// </summary>
        /// <param name="item">class InventoryItem</param>
        /// <param name="preferredIndex">struct System.Int32</param>
        /// <param name="showNotification">struct System.Boolean</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TakeOne", Search = typeof(Search_Inventory))]
        ///  extern System.Int32 TAKE_ONE_01 (nint item, System.Int32 preferredIndex, System.Boolean showNotification);


        /// public static partial class Search_Inventory
        /// {
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
        ///   System.Void .ctor(System.Int32 numberOfSlots)
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(Inventory copy)
        /// </summary>
        /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "Inventory");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean Add(InventoryItem item, System.Int32 amount, System.Collections.Generic.List<System.Int32> targetedIndexes, System.Boolean showOnItemLog, System.Boolean canAddToHotbar)
        /// </summary>
        /// public static bool ADD_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Add", "InventoryItem", "System.Int32", "System.Collections.Generic.List<System.Int32>", "System.Boolean", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean Add(InventoryItemsData type, System.Int32 amount, ItemVariation variation, System.Boolean showOnItemLog)
        /// </summary>
        /// public static bool ADD_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Add", "InventoryItemsData", "System.Int32", "ItemVariation", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 AddAtIndex(InventoryItem item, System.Int32 amount, System.Int32 index, System.Boolean showOnItemLog, System.Boolean overwrite)
        /// </summary>
        /// public static bool ADD_AT_INDEX_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAtIndex", "InventoryItem", "System.Int32", "System.Int32", "System.Boolean", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 AddAtIndex(InventoryItemsData type, System.Int32 amount, System.Int32 index, ItemVariation variation, System.Boolean showOnItemLog)
        /// </summary>
        /// public static bool ADD_AT_INDEX_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAtIndex", "InventoryItemsData", "System.Int32", "System.Int32", "ItemVariation", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean AnyOf(ItemFilter filter)
        /// </summary>
        /// public static bool ANY_OF_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AnyOf", "ItemFilter");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean AnyOf(InventoryItemsData type)
        /// </summary>
        /// public static bool ANY_OF_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AnyOf", "InventoryItemsData");
        ///     
        ///  
        /// 


        /// <summary>
        ///   InventoryItemsData AnyOf(InventoryItemsData[] items)
        /// </summary>
        /// public static bool ANY_OF_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AnyOf", "InventoryItemsData[]");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean AnyOf(System.Func<InventoryItem,System.Boolean> filter)
        /// </summary>
        /// public static bool ANY_OF_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AnyOf", "System.Func<InventoryItem,System.Boolean>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean Contains(InventoryItem item)
        /// </summary>
        /// public static bool CONTAINS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Contains", "InventoryItem");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean Contains(ItemStack stack)
        /// </summary>
        /// public static bool CONTAINS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Contains", "ItemStack");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean Contains(System.Collections.Generic.List<ItemStack> required)
        /// </summary>
        /// public static bool CONTAINS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Contains", "System.Collections.Generic.List<ItemStack>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   ItemStack GetStack(System.Int32 index)
        /// </summary>
        /// public static bool GET_STACK_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetStack", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   ItemStack GetStack(ItemFilter filter)
        /// </summary>
        /// public static bool GET_STACK_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetStack", "ItemFilter");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 IndexOf(ItemStack stack)
        /// </summary>
        /// public static bool INDEX_OF_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IndexOf", "ItemStack");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 IndexOf(InventoryItem item)
        /// </summary>
        /// public static bool INDEX_OF_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IndexOf", "InventoryItem");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 IndexOf(InventoryItem item, System.Int32 amount)
        /// </summary>
        /// public static bool INDEX_OF_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IndexOf", "InventoryItem", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 IndexOf(System.String item)
        /// </summary>
        /// public static bool INDEX_OF_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IndexOf", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32[] IndexOf(InventoryItemsData item)
        /// </summary>
        /// public static bool INDEX_OF_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IndexOf", "InventoryItemsData");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetUnsafe(System.Int32 slot, InventoryItemsData item, System.Int32 amount)
        /// </summary>
        /// public static bool SET_UNSAFE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetUnsafe", "System.Int32", "InventoryItemsData", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetUnsafe(System.Int32 slot, InventoryItem item, System.Int32 amount)
        /// </summary>
        /// public static bool SET_UNSAFE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetUnsafe", "System.Int32", "InventoryItem", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Take(InventoryItemsData type, System.Int32 amount, System.Int32 preferredIndex)
        /// </summary>
        /// public static bool TAKE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Take", "InventoryItemsData", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 Take(InventoryItem item, System.Int32 amount, System.Int32 preferredIndex, System.Boolean showNotification)
        /// </summary>
        /// public static bool TAKE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Take", "InventoryItem", "System.Int32", "System.Int32", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 Take(System.Collections.Generic.List<ItemStack> required, System.Int32 preferredIndex, System.Boolean onlyUsePreferredIndex, System.Boolean showNotification)
        /// </summary>
        /// public static bool TAKE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Take", "System.Collections.Generic.List<ItemStack>", "System.Int32", "System.Boolean", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 TakeOne(InventoryItemsData type, System.Int32 preferredIndex, System.Boolean showNotification)
        /// </summary>
        /// public static bool TAKE_ONE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TakeOne", "InventoryItemsData", "System.Int32", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 TakeOne(InventoryItem item, System.Int32 preferredIndex, System.Boolean showNotification)
        /// </summary>
        /// public static bool TAKE_ONE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TakeOne", "InventoryItem", "System.Int32", "System.Boolean");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}