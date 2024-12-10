
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
    /// class ["AzureValley".""."InventoryItem"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x0200010AU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [73, 110, 118, 101, 110, 116, 111, 114, 121, 73, 116, 101, 109])]


    // class 0x10 InventoryItemsData type
    [MonoCollectorSearchFieldAttribute(typeof(InventoryItemsData.Ptr_InventoryItemsData), "type", "TYPE")]

    // class 0x18 ItemVariation variation
    [MonoCollectorSearchFieldAttribute(typeof(ItemVariation.Ptr_ItemVariation), "variation", "VARIATION")]

    // class 0x20 System.String pickedUpByPlayerID
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"pickedUpByPlayerID", "PICKED_UP_BY_PLAYER_ID")]

    // class 0x28 ItemBehaviour behaviour
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"behaviour", "BEHAVIOUR")]

    // class 0x30 ToolUpgradeConfig toolUpgradeConfig
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"toolUpgradeConfig", "TOOL_UPGRADE_CONFIG")]

    // class 0x38 System.Text.StringBuilder descriptiveNameBuilder
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"descriptiveNameBuilder", "DESCRIPTIVE_NAME_BUILDER")]

    // struct 0x40 System.Nullable<System.Int32> globalReferenceID
    // [MonoCollectorSearchFieldAttribute(typeof(System.Nullable<System.Int32>),"globalReferenceID", "GLOBAL_REFERENCE_ID")]
    public partial class InventoryItem
    {
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "InventoryItem";
        //public static byte[] Static_ClassName { get; } = [73, 110, 118, 101, 110, 116, 111, 114, 121, 73, 116, 101, 109];

        //public const uint Const_TypeToken = 0x0200010AU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_InventoryItem(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_InventoryItem(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_InventoryItem obj) => obj._ptr;
            public static implicit operator bool(Ptr_InventoryItem obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["AzureValley".""."InventoryItem"]
    /// </summary>
    public partial class InventoryItem
    {



        /// <summary>
        ///   InventoryItem Clone()
        /// </summary>
        /// <returns>class InventoryItem</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clone")]
        ///  extern nint CLONE ();


        /// <summary>
        ///   System.Void DeleteBehaviour()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DeleteBehaviour")]
        ///  extern void DELETE_BEHAVIOUR ();


        /// <summary>
        ///   System.Boolean Equals(System.Object obj)
        /// </summary>
        /// <param name="obj">class System.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals")]
        ///  extern System.Boolean EQUALS (nint obj);


        /// <summary>
        ///   System.Boolean get_IsMax()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsMax")]
        ///  extern System.Boolean GET_IS_MAX ();


        /// <summary>
        ///   System.Int32 get_Level()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Level")]
        ///  extern System.Int32 GET_LEVEL ();


        /// <summary>
        ///   System.Boolean get_ReadyToLevelUp()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ReadyToLevelUp")]
        ///  extern System.Boolean GET_READY_TO_LEVEL_UP ();


        /// <summary>
        ///   ToolUpgradeConfig get_ToolUpgradeConfig()
        /// </summary>
        /// <returns>class ToolUpgradeConfig</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ToolUpgradeConfig")]
        ///  extern nint GET_TOOL_UPGRADE_CONFIG ();


        /// <summary>
        ///   System.Int32 get_XP()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_XP")]
        ///  extern System.Int32 GET_XP ();


        /// <summary>
        ///   System.String GetDescriptiveName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDescriptiveName")]
        ///  extern nint GET_DESCRIPTIVE_NAME ();


        /// <summary>
        ///   System.Int32 GetHashCode()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
        ///  extern System.Int32 GET_HASH_CODE ();


        /// <summary>
        ///   System.Void InstantiateBehaviours(PlayerController player)
        /// </summary>
        /// <param name="player">abstract class PlayerController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InstantiateBehaviours")]
        ///  extern void INSTANTIATE_BEHAVIOURS (nint player);


        /// <summary>
        ///   System.Boolean IsCurrency()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCurrency")]
        ///  extern System.Boolean IS_CURRENCY ();



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_InventoryItem))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor(InventoryItemsData type, ItemVariation variation)
        /// </summary>
        /// <param name="type">class InventoryItemsData</param>
        /// <param name="variation">class ItemVariation</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_InventoryItem))]
        extern void CTOR_01(nint type, nint variation);


        public static partial class Search_InventoryItem
        {
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
            ///   System.Void .ctor(InventoryItemsData type, ItemVariation variation)
            /// </summary>
            public static bool CTOR_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "InventoryItemsData", "ItemVariation");
            ///     
            ///  
            /// 
            /// 
        }

    }


}