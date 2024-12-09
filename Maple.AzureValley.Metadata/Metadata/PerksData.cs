
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
    /// class ["AzureValley".""."PerksData"]
    /// [System.Object]
    /// [Sirenix.OdinInspector.ISearchFilterable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x020000B2U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [80, 101, 114, 107, 115, 68, 97, 116, 97])]


    // class 0x10 System.String name
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"name", "NAME")]

    // class 0x18 System.String displayname
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"displayname", "DISPLAYNAME")]

    // class 0x20 System.String icon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon", "ICON")]

    // class 0x28 System.String[] parentsand
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"parentsand", "PARENTSAND")]

    // class 0x30 System.String[] parentsor
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"parentsor", "PARENTSOR")]

    // class 0x38 System.String[] menu
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"menu", "MENU")]

    // class 0x40 System.String[] tokens
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"tokens", "TOKENS")]

    // class 0x48 System.Int32[] tokenamount
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"tokenamount", "TOKENAMOUNT")]

    // class 0x50 System.String[] unlocksdrawing
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlocksdrawing", "UNLOCKSDRAWING")]

    // struct 0x58 System.Int32 columnid
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"columnid", "COLUMNID")]
    public partial class PerksData
    {
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "PerksData";
        //public static byte[] Static_ClassName { get; } = [80, 101, 114, 107, 115, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x020000B2U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_PerksData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_PerksData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_PerksData obj) => obj._ptr;
            public static implicit operator bool(Ptr_PerksData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["AzureValley".""."PerksData"]
    /// </summary>
    public partial class PerksData
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   System.Int32 get_Columnid()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Columnid")]
        ///  extern System.Int32 GET_COLUMNID ();


        /// <summary>
        ///   System.String get_Displayname()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Displayname")]
        ///  extern nint GET_DISPLAYNAME ();


        /// <summary>
        ///   System.String get_Icon()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Icon")]
        ///  extern nint GET_ICON ();


        /// <summary>
        ///   System.String[] get_Menu()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Menu")]
        ///  extern nint GET_MENU ();


        /// <summary>
        ///   System.String get_Name()
        /// </summary>
        /// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Name")]
        extern PMonoString GET_NAME();


        /// <summary>
        ///   System.String[] get_Parentsand()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Parentsand")]
        ///  extern nint GET_PARENTSAND ();


        /// <summary>
        ///   System.String[] get_Parentsor()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Parentsor")]
        ///  extern nint GET_PARENTSOR ();


        /// <summary>
        ///   System.Int32[] get_Tokenamount()
        /// </summary>
        /// <returns>class System.Int32[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Tokenamount")]
        ///  extern nint GET_TOKENAMOUNT ();


        /// <summary>
        ///   System.String[] get_Tokens()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Tokens")]
        ///  extern nint GET_TOKENS ();


        /// <summary>
        ///   System.String[] get_Unlocksdrawing()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Unlocksdrawing")]
        ///  extern nint GET_UNLOCKSDRAWING ();


        /// <summary>
        ///   System.String GetLocalizedName()
        /// </summary>
        /// <returns>class System.String</returns>
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
        /////   System.Void set_Columnid(System.Int32 value)
        ///// </summary>
        ///// <param name="value">struct System.Int32</param>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Columnid")]
        /////  extern void SET_COLUMNID (System.Int32 value);


        ///// <summary>
        /////   System.Void set_Displayname(System.String value)
        ///// </summary>
        ///// <param name="value">class System.String</param>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Displayname")]
        /////  extern void SET_DISPLAYNAME (nint value);


        ///// <summary>
        /////   System.Void set_Icon(System.String value)
        ///// </summary>
        ///// <param name="value">class System.String</param>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Icon")]
        /////  extern void SET_ICON (nint value);


        ///// <summary>
        /////   System.Void set_Menu(System.String[] value)
        ///// </summary>
        ///// <param name="value">class System.String[]</param>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Menu")]
        /////  extern void SET_MENU (nint value);


        ///// <summary>
        /////   System.Void set_Name(System.String value)
        ///// </summary>
        ///// <param name="value">class System.String</param>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Name")]
        /////  extern void SET_NAME (nint value);


        ///// <summary>
        /////   System.Void set_Parentsand(System.String[] value)
        ///// </summary>
        ///// <param name="value">class System.String[]</param>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Parentsand")]
        /////  extern void SET_PARENTSAND (nint value);


        ///// <summary>
        /////   System.Void set_Parentsor(System.String[] value)
        ///// </summary>
        ///// <param name="value">class System.String[]</param>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Parentsor")]
        /////  extern void SET_PARENTSOR (nint value);


        ///// <summary>
        /////   System.Void set_Tokenamount(System.Int32[] value)
        ///// </summary>
        ///// <param name="value">class System.Int32[]</param>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Tokenamount")]
        /////  extern void SET_TOKENAMOUNT (nint value);


        ///// <summary>
        /////   System.Void set_Tokens(System.String[] value)
        ///// </summary>
        ///// <param name="value">class System.String[]</param>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Tokens")]
        /////  extern void SET_TOKENS (nint value);


        ///// <summary>
        /////   System.Void set_Unlocksdrawing(System.String[] value)
        ///// </summary>
        ///// <param name="value">class System.String[]</param>
        ///// <returns>struct System.Void</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Unlocksdrawing")]
        /////  extern void SET_UNLOCKSDRAWING (nint value);



        ///// <summary>
        /////   System.String GetLocalizedDescription()
        ///// </summary>
        ///// <returns>class System.String</returns>
        //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDescription", Search = typeof(Search_PerksData))]
        //extern PMonoString GET_LOCALIZED_DESCRIPTION_00();


        ///// <summary>
        /////   System.String GetLocalizedDescription(System.Object[] args)
        ///// </summary>
        ///// <param name="args">class System.Object[]</param>
        ///// <returns>class System.String</returns>
        ///// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDescription", Search = typeof(Search_PerksData))]
        /////  extern nint GET_LOCALIZED_DESCRIPTION_01 (nint args);


        //public static partial class Search_PerksData
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