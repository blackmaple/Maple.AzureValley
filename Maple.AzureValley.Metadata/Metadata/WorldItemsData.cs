
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
    /// class ["AzureValley".""."WorldItemsData"]
    /// [System.Object]
    /// [Sirenix.OdinInspector.ISearchFilterable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x020000BBU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [87, 111, 114, 108, 100, 73, 116, 101, 109, 115, 68, 97, 116, 97])]


    // class 0x10 System.String name
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"name", "NAME")]

    // class 0x18 System.String worldvisual
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"worldvisual", "WORLDVISUAL")]

    // class 0x20 UnityEngine.AddressableAssets.AssetReference worldvisualGameObjectRef
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"worldvisualGameObjectRef", "WORLDVISUAL_GAME_OBJECT_REF")]

    // class 0x28 UnityEngine.GameObject m_loadedWorldvisualGameObject
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_loadedWorldvisualGameObject", "M_LOADED_WORLDVISUAL_GAME_OBJECT")]

    // class 0x30 System.String holdingvisual
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"holdingvisual", "HOLDINGVISUAL")]

    // class 0x38 System.String[] classification
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"classification", "CLASSIFICATION")]

    // class 0x40 System.String audiotag
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"audiotag", "AUDIOTAG")]

    // class 0x48 System.String ambienttag
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"ambienttag", "AMBIENTTAG")]

    // class 0x50 System.String[] data
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"data", "DATA")]

    // struct 0x58 System.Int32 maxhealth
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"maxhealth", "MAXHEALTH")]

    // enum 0x5C WalkableBy walkableby
    // [MonoCollectorSearchFieldAttribute(typeof(WalkableBy),"walkableby", "WALKABLEBY")]

    // struct 0x60 System.Int32 level
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"level", "LEVEL")]
    public partial class WorldItemsData
    {
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "WorldItemsData";
        //public static byte[] Static_ClassName { get; } = [87, 111, 114, 108, 100, 73, 116, 101, 109, 115, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x020000BBU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_WorldItemsData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_WorldItemsData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_WorldItemsData obj) => obj._ptr;
            public static implicit operator bool(Ptr_WorldItemsData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["AzureValley".""."WorldItemsData"]
    /// </summary>
    public partial class WorldItemsData
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   System.String get_Ambienttag()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Ambienttag")]
        ///  extern nint GET_AMBIENTTAG ();


        /// <summary>
        ///   System.String get_Audiotag()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Audiotag")]
        ///  extern nint GET_AUDIOTAG ();


        /// <summary>
        ///   System.String[] get_Classification()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Classification")]
        ///  extern nint GET_CLASSIFICATION ();


        /// <summary>
        ///   System.String[] get_Data()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Data")]
        ///  extern nint GET_DATA ();


        /// <summary>
        ///   System.String get_Holdingvisual()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Holdingvisual")]
        ///  extern nint GET_HOLDINGVISUAL ();


        /// <summary>
        ///   System.Int32 get_Level()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Level")]
        ///  extern System.Int32 GET_LEVEL ();


        /// <summary>
        ///   System.Int32 get_Maxhealth()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Maxhealth")]
        ///  extern System.Int32 GET_MAXHEALTH ();


        /// <summary>
        ///   System.String get_Name()
        /// </summary>
        /// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Name")]
        extern PMonoString GET_NAME();


        /// <summary>
        ///   WalkableBy get_Walkableby()
        /// </summary>
        /// <returns>enum WalkableBy</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Walkableby")]
        ///  extern WalkableBy GET_WALKABLEBY ();


        /// <summary>
        ///   System.String get_Worldvisual()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Worldvisual")]
        ///  extern nint GET_WORLDVISUAL ();


        /// <summary>
        ///   UnityEngine.GameObject get_WorldvisualGameObject()
        /// </summary>
        /// <returns>class UnityEngine.GameObject</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldvisualGameObject")]
        ///  extern nint GET_WORLDVISUAL_GAME_OBJECT ();


        /// <summary>
        ///   UnityEngine.AddressableAssets.AssetReference get_WorldvisualGameObjectRef()
        /// </summary>
        /// <returns>class UnityEngine.AddressableAssets.AssetReference</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldvisualGameObjectRef")]
        ///  extern nint GET_WORLDVISUAL_GAME_OBJECT_REF ();


        /// <summary>
        ///   System.String GetLocalizedName()
        /// </summary>
        /// <returns>class System.String</returns>
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
        ///   System.Void set_Ambienttag(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Ambienttag")]
        ///  extern void SET_AMBIENTTAG (nint value);


        /// <summary>
        ///   System.Void set_Audiotag(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Audiotag")]
        ///  extern void SET_AUDIOTAG (nint value);


        /// <summary>
        ///   System.Void set_Classification(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Classification")]
        ///  extern void SET_CLASSIFICATION (nint value);


        /// <summary>
        ///   System.Void set_Data(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Data")]
        ///  extern void SET_DATA (nint value);


        /// <summary>
        ///   System.Void set_Holdingvisual(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Holdingvisual")]
        ///  extern void SET_HOLDINGVISUAL (nint value);


        /// <summary>
        ///   System.Void set_Level(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Level")]
        ///  extern void SET_LEVEL (System.Int32 value);


        /// <summary>
        ///   System.Void set_Maxhealth(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Maxhealth")]
        ///  extern void SET_MAXHEALTH (System.Int32 value);


        /// <summary>
        ///   System.Void set_Name(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Name")]
        ///  extern void SET_NAME (nint value);


        /// <summary>
        ///   System.Void set_Walkableby(WalkableBy value)
        /// </summary>
        /// <param name="value">enum WalkableBy</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Walkableby")]
        ///  extern void SET_WALKABLEBY (WalkableBy value);


        /// <summary>
        ///   System.Void set_Worldvisual(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Worldvisual")]
        ///  extern void SET_WORLDVISUAL (nint value);


        /// <summary>
        ///   System.Void set_WorldvisualGameObject(UnityEngine.GameObject value)
        /// </summary>
        /// <param name="value">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_WorldvisualGameObject")]
        ///  extern void SET_WORLDVISUAL_GAME_OBJECT (nint value);


        /// <summary>
        ///   System.Void set_WorldvisualGameObjectRef(UnityEngine.AddressableAssets.AssetReference value)
        /// </summary>
        /// <param name="value">class UnityEngine.AddressableAssets.AssetReference</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_WorldvisualGameObjectRef")]
        ///  extern void SET_WORLDVISUAL_GAME_OBJECT_REF (nint value);



        /// <summary>
        ///   System.String GetLocalizedDescription()
        /// </summary>
        /// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDescription", Search = typeof(Search_WorldItemsData))]
        extern PMonoString GET_LOCALIZED_DESCRIPTION_00();


        /// <summary>
        ///   System.String GetLocalizedDescription(System.Object[] args)
        /// </summary>
        /// <param name="args">class System.Object[]</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDescription", Search = typeof(Search_WorldItemsData))]
        ///  extern nint GET_LOCALIZED_DESCRIPTION_01 (nint args);


        public static partial class Search_WorldItemsData
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