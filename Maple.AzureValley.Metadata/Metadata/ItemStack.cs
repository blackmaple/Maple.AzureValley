
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
    /// class ["AzureValley".""."ItemStack"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x0200010EU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [73, 116, 101, 109, 83, 116, 97, 99, 107])]


    // class 0x10 InventoryItem item
    [MonoCollectorSearchFieldAttribute(typeof(InventoryItem.Ptr_InventoryItem), "item", "ITEM")]

    // struct 0x18 System.Int32 amount
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "amount", "AMOUNT", IsReadOnly = false)]
    public partial class ItemStack
    {
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "ItemStack";
        //public static byte[] Static_ClassName { get; } = [73, 116, 101, 109, 83, 116, 97, 99, 107];

        //public const uint Const_TypeToken = 0x0200010EU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_ItemStack(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ItemStack(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ItemStack obj) => obj._ptr;
            public static implicit operator bool(Ptr_ItemStack obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["AzureValley".""."ItemStack"]
    /// </summary>
    public partial class ItemStack
    {



        /// <summary>
        ///   System.Int32 GetBuyPrice()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBuyPrice")]
        ///  extern System.Int32 GET_BUY_PRICE ();


        /// <summary>
        ///   System.Int32 GetSellPrice()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSellPrice")]
        ///  extern System.Int32 GET_SELL_PRICE ();


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
        ///  extern nint TO_STRING ();



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ItemStack))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor(InventoryItem item, System.Int32 amount)
        /// </summary>
        /// <param name="item">class InventoryItem</param>
        /// <param name="amount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ItemStack))]
        ///  extern void .CTOR_01 (nint item, System.Int32 amount);


        /// public static partial class Search_ItemStack
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
        ///   System.Void .ctor(InventoryItem item, System.Int32 amount)
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "InventoryItem", "System.Int32");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}