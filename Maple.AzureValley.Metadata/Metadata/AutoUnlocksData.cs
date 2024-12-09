
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
    /// class ["AzureValley".""."AutoUnlocksData"]
    /// [System.Object]
    /// [Sirenix.OdinInspector.ISearchFilterable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x020000A0U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [65, 117, 116, 111, 85, 110, 108, 111, 99, 107, 115, 68, 97, 116, 97])]


    // class 0x10 System.String name
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"name", "NAME")]

    // class 0x18 System.String precedingunlock
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"precedingunlock", "PRECEDINGUNLOCK")]

    // class 0x20 System.String[] requiresglobalstates
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"requiresglobalstates", "REQUIRESGLOBALSTATES")]

    // class 0x28 System.String[] requiresplayerstates
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"requiresplayerstates", "REQUIRESPLAYERSTATES")]

    // class 0x30 System.String[] requireshasseenitems
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"requireshasseenitems", "REQUIRESHASSEENITEMS")]

    // class 0x38 System.String[] requireshasbuilt
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"requireshasbuilt", "REQUIRESHASBUILT")]

    // class 0x40 System.String[] unlockshopitems
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlockshopitems", "UNLOCKSHOPITEMS")]

    // class 0x48 System.String[] unlockcraftbenchrecipes
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlockcraftbenchrecipes", "UNLOCKCRAFTBENCHRECIPES")]

    // class 0x50 System.String[] unlockplayerblueprints
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlockplayerblueprints", "UNLOCKPLAYERBLUEPRINTS")]

    // class 0x58 System.String notificationsprite
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"notificationsprite", "NOTIFICATIONSPRITE")]

    // struct 0x60 System.Boolean showgrayedoutpreview
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"showgrayedoutpreview", "SHOWGRAYEDOUTPREVIEW")]

    // struct 0x61 System.Boolean showunlockedparticles
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"showunlockedparticles", "SHOWUNLOCKEDPARTICLES")]
    public partial class AutoUnlocksData
    {
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "AutoUnlocksData";
        //public static byte[] Static_ClassName { get; } = [65, 117, 116, 111, 85, 110, 108, 111, 99, 107, 115, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x020000A0U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_AutoUnlocksData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_AutoUnlocksData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_AutoUnlocksData obj) => obj._ptr;
            public static implicit operator bool(Ptr_AutoUnlocksData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["AzureValley".""."AutoUnlocksData"]
    /// </summary>
    public partial class AutoUnlocksData
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   System.String get_Name()
        /// </summary>
        /// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Name")]
        extern PMonoString GET_NAME();


        /// <summary>
        ///   System.String get_Notificationsprite()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Notificationsprite")]
        ///  extern nint GET_NOTIFICATIONSPRITE ();


        /// <summary>
        ///   System.String get_Precedingunlock()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Precedingunlock")]
        ///  extern nint GET_PRECEDINGUNLOCK ();


        /// <summary>
        ///   System.String[] get_Requiresglobalstates()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Requiresglobalstates")]
        ///  extern nint GET_REQUIRESGLOBALSTATES ();


        /// <summary>
        ///   System.String[] get_Requireshasbuilt()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Requireshasbuilt")]
        ///  extern nint GET_REQUIRESHASBUILT ();


        /// <summary>
        ///   System.String[] get_Requireshasseenitems()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Requireshasseenitems")]
        ///  extern nint GET_REQUIRESHASSEENITEMS ();


        /// <summary>
        ///   System.String[] get_Requiresplayerstates()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Requiresplayerstates")]
        ///  extern nint GET_REQUIRESPLAYERSTATES ();


        /// <summary>
        ///   System.Boolean get_Showgrayedoutpreview()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Showgrayedoutpreview")]
        ///  extern System.Boolean GET_SHOWGRAYEDOUTPREVIEW ();


        /// <summary>
        ///   System.Boolean get_Showunlockedparticles()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Showunlockedparticles")]
        ///  extern System.Boolean GET_SHOWUNLOCKEDPARTICLES ();


        /// <summary>
        ///   System.String[] get_Unlockcraftbenchrecipes()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Unlockcraftbenchrecipes")]
        ///  extern nint GET_UNLOCKCRAFTBENCHRECIPES ();


        /// <summary>
        ///   System.String[] get_Unlockplayerblueprints()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Unlockplayerblueprints")]
        ///  extern nint GET_UNLOCKPLAYERBLUEPRINTS ();


        /// <summary>
        ///   System.String[] get_Unlockshopitems()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Unlockshopitems")]
        ///  extern nint GET_UNLOCKSHOPITEMS ();


        /// <summary>
        ///   System.String GetLocalizedName()
        /// </summary>
        /// <returns>class System.String</returns>
        //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedName")]
        //extern PMonoString GET_LOCALIZED_NAME();


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
        //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTranslationNameTag")]
        //extern PMonoString GET_TRANSLATION_NAME_TAG();


        /// <summary>
        ///   System.Boolean IsMatch(System.String searchString)
        /// </summary>
        /// <param name="searchString">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsMatch")]
        ///  extern System.Boolean IS_MATCH (nint searchString);


        /// <summary>
        ///   System.Void set_Name(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Name")]
        ///  extern void SET_NAME (nint value);


        /// <summary>
        ///   System.Void set_Notificationsprite(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Notificationsprite")]
        ///  extern void SET_NOTIFICATIONSPRITE (nint value);


        /// <summary>
        ///   System.Void set_Precedingunlock(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Precedingunlock")]
        ///  extern void SET_PRECEDINGUNLOCK (nint value);


        /// <summary>
        ///   System.Void set_Requiresglobalstates(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Requiresglobalstates")]
        ///  extern void SET_REQUIRESGLOBALSTATES (nint value);


        /// <summary>
        ///   System.Void set_Requireshasbuilt(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Requireshasbuilt")]
        ///  extern void SET_REQUIRESHASBUILT (nint value);


        /// <summary>
        ///   System.Void set_Requireshasseenitems(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Requireshasseenitems")]
        ///  extern void SET_REQUIRESHASSEENITEMS (nint value);


        /// <summary>
        ///   System.Void set_Requiresplayerstates(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Requiresplayerstates")]
        ///  extern void SET_REQUIRESPLAYERSTATES (nint value);


        /// <summary>
        ///   System.Void set_Showgrayedoutpreview(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Showgrayedoutpreview")]
        ///  extern void SET_SHOWGRAYEDOUTPREVIEW (System.Boolean value);


        /// <summary>
        ///   System.Void set_Showunlockedparticles(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Showunlockedparticles")]
        ///  extern void SET_SHOWUNLOCKEDPARTICLES (System.Boolean value);


        /// <summary>
        ///   System.Void set_Unlockcraftbenchrecipes(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Unlockcraftbenchrecipes")]
        ///  extern void SET_UNLOCKCRAFTBENCHRECIPES (nint value);


        /// <summary>
        ///   System.Void set_Unlockplayerblueprints(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Unlockplayerblueprints")]
        ///  extern void SET_UNLOCKPLAYERBLUEPRINTS (nint value);


        /// <summary>
        ///   System.Void set_Unlockshopitems(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Unlockshopitems")]
        ///  extern void SET_UNLOCKSHOPITEMS (nint value);



        /// <summary>
        ///   System.String GetLocalizedDescription()
        /// </summary>
        /// <returns>class System.String</returns>
        //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDescription", Search = typeof(Search_AutoUnlocksData))]
        //extern PMonoString GET_LOCALIZED_DESCRIPTION_00();


        /// <summary>
        ///   System.String GetLocalizedDescription(System.Object[] args)
        /// </summary>
        /// <param name="args">class System.Object[]</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDescription", Search = typeof(Search_AutoUnlocksData))]
        ///  extern nint GET_LOCALIZED_DESCRIPTION_01 (nint args);


        public static partial class Search_AutoUnlocksData
        {
            /// 
            ///     

            /// <summary>
            ///   System.String GetLocalizedDescription()
            /// </summary>
            public static bool GET_LOCALIZED_DESCRIPTION_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetLocalizedDescription");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.String GetLocalizedDescription(System.Object[] args)
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