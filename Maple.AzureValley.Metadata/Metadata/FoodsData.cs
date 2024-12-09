
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
    /// class ["AzureValley".""."FoodsData"]
    /// [System.Object]
    /// [Sirenix.OdinInspector.ISearchFilterable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x020000A9U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [70, 111, 111, 100, 115, 68, 97, 116, 97])]


    // class 0x10 System.String name
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"name", "NAME")]

    // class 0x18 System.String displayname
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"displayname", "DISPLAYNAME")]

    // class 0x20 System.String[] buffs
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"buffs", "BUFFS")]

    // class 0x28 System.String[] ingredients
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"ingredients", "INGREDIENTS")]

    // class 0x30 System.Int32[] ingredientamounts
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"ingredientamounts", "INGREDIENTAMOUNTS")]
    public partial class FoodsData
    {
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "FoodsData";
        //public static byte[] Static_ClassName { get; } = [70, 111, 111, 100, 115, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x020000A9U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_FoodsData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_FoodsData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_FoodsData obj) => obj._ptr;
            public static implicit operator bool(Ptr_FoodsData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["AzureValley".""."FoodsData"]
    /// </summary>
    public partial class FoodsData
    {



        ///// <summary>
        /////   System.Void .ctor()
        ///// </summary>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        /////  extern void .CTOR ();


        ///// <summary>
        /////   System.String[] get_Buffs()
        ///// </summary>
        ///// <returns>class System.String[]</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Buffs")]
        /////  extern nint GET_BUFFS ();


        ///// <summary>
        /////   System.String get_Displayname()
        ///// </summary>
        ///// <returns>class System.String</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Displayname")]
        /////  extern nint GET_DISPLAYNAME ();


        ///// <summary>
        /////   System.Int32[] get_Ingredientamounts()
        ///// </summary>
        ///// <returns>class System.Int32[]</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Ingredientamounts")]
        /////  extern nint GET_INGREDIENTAMOUNTS ();


        ///// <summary>
        /////   System.String[] get_Ingredients()
        ///// </summary>
        ///// <returns>class System.String[]</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Ingredients")]
        /////  extern nint GET_INGREDIENTS ();


        ///// <summary>
        /////   System.String get_Name()
        ///// </summary>
        ///// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Name")]
        extern PMonoString GET_NAME();


        ///// <summary>
        /////   UnityEngine.Localization.LocalizedString GetLocalizedName()
        ///// </summary>
        ///// <returns>class UnityEngine.Localization.LocalizedString</returns>
        //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedName")]
        //extern PMonoString GET_LOCALIZED_NAME();


        ///// <summary>
        /////   System.String GetTranslationDescriptionTag()
        ///// </summary>
        ///// <returns>class System.String</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTranslationDescriptionTag")]
        /////  extern nint GET_TRANSLATION_DESCRIPTION_TAG ();


        ///// <summary>
        /////   System.String GetTranslationNameTag()
        ///// </summary>
        ///// <returns>class System.String</returns>
        //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTranslationNameTag")]
        //extern PMonoString GET_TRANSLATION_NAME_TAG();


        ///// <summary>
        /////   System.Boolean IsMatch(System.String searchString)
        ///// </summary>
        ///// <param name="searchString">class System.String</param>
        ///// <returns>struct System.Boolean</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsMatch")]
        /////  extern System.Boolean IS_MATCH (nint searchString);


        ///// <summary>
        /////   System.Void set_Buffs(System.String[] value)
        ///// </summary>
        ///// <param name="value">class System.String[]</param>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Buffs")]
        /////  extern void SET_BUFFS (nint value);


        ///// <summary>
        /////   System.Void set_Displayname(System.String value)
        ///// </summary>
        ///// <param name="value">class System.String</param>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Displayname")]
        /////  extern void SET_DISPLAYNAME (nint value);


        ///// <summary>
        /////   System.Void set_Ingredientamounts(System.Int32[] value)
        ///// </summary>
        ///// <param name="value">class System.Int32[]</param>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Ingredientamounts")]
        /////  extern void SET_INGREDIENTAMOUNTS (nint value);


        ///// <summary>
        /////   System.Void set_Ingredients(System.String[] value)
        ///// </summary>
        ///// <param name="value">class System.String[]</param>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Ingredients")]
        /////  extern void SET_INGREDIENTS (nint value);


        ///// <summary>
        /////   System.Void set_Name(System.String value)
        ///// </summary>
        ///// <param name="value">class System.String</param>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Name")]
        /////  extern void SET_NAME (nint value);



        ///// <summary>
        /////   System.String GetLocalizedDescription()
        ///// </summary>
        ///// <returns>class System.String</returns>
        //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDescription", Search = typeof(Search_FoodsData))]
        //extern PMonoString GET_LOCALIZED_DESCRIPTION_00();


        ///// <summary>
        /////   System.String GetLocalizedDescription(System.Object[] args)
        ///// </summary>
        ///// <param name="args">class System.Object[]</param>
        ///// <returns>class System.String</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDescription", Search = typeof(Search_FoodsData))]
        /////  extern nint GET_LOCALIZED_DESCRIPTION_01 (nint args);


        //public static partial class Search_FoodsData
        //{
        //    /// 
        //    ///     

        //    /// <summary>
        //    ///   System.String GetLocalizedDescription()
        //    /// </summary>
        //    public static bool GET_LOCALIZED_DESCRIPTION_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        //        => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetLocalizedDescription");
        //    ///     
        //    ///  
        //    /// 


        //    /// <summary>
        //    ///   System.String GetLocalizedDescription(System.Object[] args)
        //    /// </summary>
        //    /// public static bool GET_LOCALIZED_DESCRIPTION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        //    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetLocalizedDescription", "System.Object[]");
        //    ///     
        //    ///  
        //    /// 
        //    /// 
        //}

    }


}