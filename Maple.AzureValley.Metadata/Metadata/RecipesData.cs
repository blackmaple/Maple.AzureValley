
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
    /// class ["AzureValley".""."RecipesData"]
    /// [System.Object]
    /// [Sirenix.OdinInspector.ISearchFilterable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x020000B4U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [82, 101, 99, 105, 112, 101, 115, 68, 97, 116, 97])]


    // class 0x10 System.String name
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"name", "NAME")]

    // class 0x18 System.String icon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon", "ICON")]

    // class 0x20 System.String[] ingredients
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"ingredients", "INGREDIENTS")]

    // class 0x28 System.Int32[] inputamount
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"inputamount", "INPUTAMOUNT")]

    // class 0x30 System.String[] station
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"station", "STATION")]

    // class 0x38 System.String output
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"output", "OUTPUT")]

    // class 0x40 System.String[] outputloottable
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"outputloottable", "OUTPUTLOOTTABLE")]

    // class 0x48 System.Int32[] outputloottableamount
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"outputloottableamount", "OUTPUTLOOTTABLEAMOUNT")]

    // class 0x50 System.String[] filterby
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"filterby", "FILTERBY")]

    // struct 0x58 System.Int32 moneycost
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"moneycost", "MONEYCOST")]

    // struct 0x5C System.Int32 outputamount
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"outputamount", "OUTPUTAMOUNT")]

    // struct 0x60 System.Int32 craftdays
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"craftdays", "CRAFTDAYS")]

    // struct 0x64 System.Single crafthours
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"crafthours", "CRAFTHOURS")]
    public partial class RecipesData
    {
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "RecipesData";
        //public static byte[] Static_ClassName { get; } = [82, 101, 99, 105, 112, 101, 115, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x020000B4U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_RecipesData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_RecipesData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_RecipesData obj) => obj._ptr;
            public static implicit operator bool(Ptr_RecipesData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["AzureValley".""."RecipesData"]
    /// </summary>
    public partial class RecipesData
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   System.Int32 get_Craftdays()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Craftdays")]
        ///  extern System.Int32 GET_CRAFTDAYS ();


        /// <summary>
        ///   System.Single get_Crafthours()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Crafthours")]
        ///  extern System.Single GET_CRAFTHOURS ();


        /// <summary>
        ///   System.String[] get_Filterby()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Filterby")]
        ///  extern nint GET_FILTERBY ();


        /// <summary>
        ///   System.String get_Icon()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Icon")]
        ///  extern nint GET_ICON ();


        /// <summary>
        ///   System.String[] get_Ingredients()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Ingredients")]
        ///  extern nint GET_INGREDIENTS ();


        /// <summary>
        ///   System.Int32[] get_Inputamount()
        /// </summary>
        /// <returns>class System.Int32[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Inputamount")]
        ///  extern nint GET_INPUTAMOUNT ();


        /// <summary>
        ///   System.Int32 get_Moneycost()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Moneycost")]
        ///  extern System.Int32 GET_MONEYCOST ();


        /// <summary>
        ///   System.String get_Name()
        /// </summary>
        /// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Name")]
        extern PMonoString GET_NAME();


        /// <summary>
        ///   System.String get_Output()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Output")]
        ///  extern nint GET_OUTPUT ();


        /// <summary>
        ///   System.Int32 get_Outputamount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Outputamount")]
        ///  extern System.Int32 GET_OUTPUTAMOUNT ();


        /// <summary>
        ///   System.String[] get_Outputloottable()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Outputloottable")]
        ///  extern nint GET_OUTPUTLOOTTABLE ();


        /// <summary>
        ///   System.Int32[] get_Outputloottableamount()
        /// </summary>
        /// <returns>class System.Int32[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Outputloottableamount")]
        ///  extern nint GET_OUTPUTLOOTTABLEAMOUNT ();


        /// <summary>
        ///   System.String[] get_Station()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Station")]
        ///  extern nint GET_STATION ();


        /// <summary>
        ///   UnityEngine.Localization.LocalizedString GetLocalizedName()
        /// </summary>
        /// <returns>class UnityEngine.Localization.LocalizedString</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedName")]
        extern PMonoString GET_LOCALIZED_NAME();


        /// <summary>
        ///   System.String GetTranslationDescriptionTag()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTranslationDescriptionTag")]
        ///  extern nint GET_TRANSLATION_DESCRIPTION_TAG ();


        /// <summary>
        ///   System.String GetTranslationNameTag()
        /// </summary>
        /// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTranslationNameTag")]
        extern PMonoString GET_TRANSLATION_NAME_TAG();


        /// <summary>
        ///   System.Boolean IsMatch(System.String searchString)
        /// </summary>
        /// <param name="searchString">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsMatch")]
        ///  extern System.Boolean IS_MATCH (nint searchString);


        /// <summary>
        ///   System.Void set_Craftdays(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Craftdays")]
        ///  extern void SET_CRAFTDAYS (System.Int32 value);


        /// <summary>
        ///   System.Void set_Crafthours(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Crafthours")]
        ///  extern void SET_CRAFTHOURS (System.Single value);


        /// <summary>
        ///   System.Void set_Filterby(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Filterby")]
        ///  extern void SET_FILTERBY (nint value);


        /// <summary>
        ///   System.Void set_Icon(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Icon")]
        ///  extern void SET_ICON (nint value);


        /// <summary>
        ///   System.Void set_Ingredients(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Ingredients")]
        ///  extern void SET_INGREDIENTS (nint value);


        /// <summary>
        ///   System.Void set_Inputamount(System.Int32[] value)
        /// </summary>
        /// <param name="value">class System.Int32[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Inputamount")]
        ///  extern void SET_INPUTAMOUNT (nint value);


        /// <summary>
        ///   System.Void set_Moneycost(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Moneycost")]
        ///  extern void SET_MONEYCOST (System.Int32 value);


        /// <summary>
        ///   System.Void set_Name(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Name")]
        ///  extern void SET_NAME (nint value);


        /// <summary>
        ///   System.Void set_Output(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Output")]
        ///  extern void SET_OUTPUT (nint value);


        /// <summary>
        ///   System.Void set_Outputamount(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Outputamount")]
        ///  extern void SET_OUTPUTAMOUNT (System.Int32 value);


        /// <summary>
        ///   System.Void set_Outputloottable(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Outputloottable")]
        ///  extern void SET_OUTPUTLOOTTABLE (nint value);


        /// <summary>
        ///   System.Void set_Outputloottableamount(System.Int32[] value)
        /// </summary>
        /// <param name="value">class System.Int32[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Outputloottableamount")]
        ///  extern void SET_OUTPUTLOOTTABLEAMOUNT (nint value);


        /// <summary>
        ///   System.Void set_Station(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Station")]
        ///  extern void SET_STATION (nint value);



        /// <summary>
        ///   UnityEngine.Localization.LocalizedString GetLocalizedDescription()
        /// </summary>
        /// <returns>class UnityEngine.Localization.LocalizedString</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDescription", Search = typeof(Search_RecipesData))]
        extern PMonoString GET_LOCALIZED_DESCRIPTION_00();


        /// <summary>
        ///   UnityEngine.Localization.LocalizedString GetLocalizedDescription(System.Object[] args)
        /// </summary>
        /// <param name="args">class System.Object[]</param>
        /// <returns>class UnityEngine.Localization.LocalizedString</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDescription", Search = typeof(Search_RecipesData))]
        ///  extern nint GET_LOCALIZED_DESCRIPTION_01 (nint args);


        public static partial class Search_RecipesData
        {
            /// 
            ///     

            /// <summary>
            ///   UnityEngine.Localization.LocalizedString GetLocalizedDescription()
            /// </summary>
            public static bool GET_LOCALIZED_DESCRIPTION_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetLocalizedDescription");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Localization.LocalizedString GetLocalizedDescription(System.Object[] args)
            /// </summary>
            /// public static bool GET_LOCALIZED_DESCRIPTION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetLocalizedDescription", "System.Object[]");
            ///     
            ///  
            /// 
            /// 
        }

    }


}