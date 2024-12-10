
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
    /// class ["AzureValley".""."ItemVariation"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x02000114U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [73, 116, 101, 109, 86, 97, 114, 105, 97, 116, 105, 111, 110])]


    // class 0x10 InventoryItemsData <DecoratorItem>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<DecoratorItem>k__BackingField", "DECORATOR_ITEM")]

    // class 0x18 System.Collections.Generic.Dictionary<System.String,System.Single> <Data>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Data>k__BackingField", "DATA")]

    // struct 0x20 System.Int32 <XP>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "<XP>k__BackingField", "XP", IsReadOnly = false)]

    // struct 0x24 System.Int32 <Level>k__BackingField
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "<Level>k__BackingField", "LEVEL", IsReadOnly = false)]
    public partial class ItemVariation
    {
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "ItemVariation";
        //public static byte[] Static_ClassName { get; } = [73, 116, 101, 109, 86, 97, 114, 105, 97, 116, 105, 111, 110];

        //public const uint Const_TypeToken = 0x02000114U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_ItemVariation(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ItemVariation(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ItemVariation obj) => obj._ptr;
            public static implicit operator bool(Ptr_ItemVariation obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["AzureValley".""."ItemVariation"]
    /// </summary>
    public partial class ItemVariation
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   ItemVariation Clone()
        /// </summary>
        /// <returns>class ItemVariation</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clone")]
        ///  extern nint CLONE ();


        /// <summary>
        ///   System.Collections.Generic.Dictionary<System.String,System.Single> get_Data()
        /// </summary>
        /// <returns>class System.Collections.Generic.Dictionary<System.String,System.Single></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Data")]
        ///  extern nint GET_DATA ();


        /// <summary>
        ///   InventoryItemsData get_DecoratorItem()
        /// </summary>
        /// <returns>class InventoryItemsData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DecoratorItem")]
        ///  extern nint GET_DECORATOR_ITEM ();


        /// <summary>
        ///   System.Int32 get_Level()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Level")]
        ///  extern System.Int32 GET_LEVEL ();


        /// <summary>
        ///   System.Int32 get_XP()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_XP")]
        ///  extern System.Int32 GET_XP ();


        /// <summary>
        ///   System.Int32 GetHashCode()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
        ///  extern System.Int32 GET_HASH_CODE ();


        /// <summary>
        ///   System.Void set_Data(System.Collections.Generic.Dictionary<System.String,System.Single> value)
        /// </summary>
        /// <param name="value">class System.Collections.Generic.Dictionary<System.String,System.Single></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Data")]
        ///  extern void SET_DATA (nint value);


        /// <summary>
        ///   System.Void set_DecoratorItem(InventoryItemsData value)
        /// </summary>
        /// <param name="value">class InventoryItemsData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_DecoratorItem")]
        ///  extern void SET_DECORATOR_ITEM (nint value);


        /// <summary>
        ///   System.Void set_Level(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Level")]
        ///  extern void SET_LEVEL (System.Int32 value);


        /// <summary>
        ///   System.Void set_XP(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_XP")]
        ///  extern void SET_XP (System.Int32 value);




        /// public static partial class Search_ItemVariation
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}