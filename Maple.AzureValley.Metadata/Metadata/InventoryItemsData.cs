
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
    /// class ["AzureValley".""."InventoryItemsData"]
    /// [System.Object]
    /// [Sirenix.OdinInspector.ISearchFilterable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x020000AFU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [73, 110, 118, 101, 110, 116, 111, 114, 121, 73, 116, 101, 109, 115, 68, 97, 116, 97])]


    // class 0x10 System.String name
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"name", "NAME")]

    // class 0x18 System.String visual
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"visual", "VISUAL")]

    // class 0x20 UnityEngine.AddressableAssets.AssetReference visualGameObjectRef
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"visualGameObjectRef", "VISUAL_GAME_OBJECT_REF")]

    // class 0x28 UnityEngine.GameObject m_loadedVisualGameObject
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_loadedVisualGameObject", "M_LOADED_VISUAL_GAME_OBJECT")]

    // class 0x30 System.String convertsto
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"convertsto", "CONVERTSTO")]

    // class 0x38 System.String[] classification
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"classification", "CLASSIFICATION")]

    // class 0x40 System.String interactmethod
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"interactmethod", "INTERACTMETHOD")]

    // class 0x48 System.String audiotag
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"audiotag", "AUDIOTAG")]

    // class 0x50 System.String specialbehaviourscript
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"specialbehaviourscript", "SPECIALBEHAVIOURSCRIPT")]

    // class 0x58 System.String typetag
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"typetag", "TYPETAG")]

    // class 0x60 System.String[] usagetag
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"usagetag", "USAGETAG")]

    // class 0x68 System.String origintag
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"origintag", "ORIGINTAG")]

    // struct 0x70 System.Boolean sellable
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"sellable", "SELLABLE")]

    // struct 0x74 System.Int32 maxstack
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"maxstack", "MAXSTACK")]

    // struct 0x78 System.Single damage
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"damage", "DAMAGE")]

    // struct 0x7C System.Single hardness
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"hardness", "HARDNESS")]

    // struct 0x80 System.Int32 buyvalue
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"buyvalue", "BUYVALUE")]

    // struct 0x84 System.Int32 sellvalue
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"sellvalue", "SELLVALUE")]

    // struct 0x88 System.Boolean canthrow
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"canthrow", "CANTHROW")]

    // struct 0x89 System.Boolean hasspecialbehaviour
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"hasspecialbehaviour", "HASSPECIALBEHAVIOUR")]

    // struct 0x8C System.Single mass
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"mass", "MASS")]

    // struct 0x90 System.Int32 level
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"level", "LEVEL")]

    // struct 0x94 System.Int32 sorting
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"sorting", "SORTING")]
    public partial class InventoryItemsData
    {
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "InventoryItemsData";
        //public static byte[] Static_ClassName { get; } = [73, 110, 118, 101, 110, 116, 111, 114, 121, 73, 116, 101, 109, 115, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x020000AFU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_InventoryItemsData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_InventoryItemsData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_InventoryItemsData obj) => obj._ptr;
            public static implicit operator bool(Ptr_InventoryItemsData obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["AzureValley".""."InventoryItemsData"]
    /// </summary>
    public partial class InventoryItemsData
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   System.String get_Audiotag()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Audiotag")]
        ///  extern nint GET_AUDIOTAG ();


        /// <summary>
        ///   System.Int32 get_Buyvalue()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Buyvalue")]
        ///  extern System.Int32 GET_BUYVALUE ();


        /// <summary>
        ///   System.Boolean get_Canthrow()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Canthrow")]
        ///  extern System.Boolean GET_CANTHROW ();


        /// <summary>
        ///   System.String[] get_Classification()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Classification")]
        ///  extern nint GET_CLASSIFICATION ();


        /// <summary>
        ///   System.String get_Convertsto()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Convertsto")]
        ///  extern nint GET_CONVERTSTO ();


        /// <summary>
        ///   System.Single get_Damage()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Damage")]
        ///  extern System.Single GET_DAMAGE ();


        /// <summary>
        ///   System.Single get_Hardness()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Hardness")]
        ///  extern System.Single GET_HARDNESS ();


        /// <summary>
        ///   System.Boolean get_Hasspecialbehaviour()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Hasspecialbehaviour")]
        ///  extern System.Boolean GET_HASSPECIALBEHAVIOUR ();


        /// <summary>
        ///   System.String get_Interactmethod()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Interactmethod")]
        ///  extern nint GET_INTERACTMETHOD ();


        /// <summary>
        ///   System.Int32 get_Level()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Level")]
        //extern System.Int32 GET_LEVEL();


        /// <summary>
        ///   System.Single get_Mass()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Mass")]
        ///  extern System.Single GET_MASS ();


        /// <summary>
        ///   System.Int32 get_Maxstack()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Maxstack")]
        //extern System.Int32 GET_MAXSTACK();


        /// <summary>
        ///   System.String get_Name()
        /// </summary>
        /// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Name")]
        extern PMonoString GET_NAME();


        /// <summary>
        ///   System.String get_Origintag()
        /// </summary>
        /// <returns>class System.String</returns>
        //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Origintag")]
        //extern PMonoString GET_ORIGINTAG();


        /// <summary>
        ///   System.Boolean get_Sellable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Sellable")]
        ///  extern System.Boolean GET_SELLABLE ();


        /// <summary>
        ///   System.Int32 get_Sellvalue()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Sellvalue")]
        ///  extern System.Int32 GET_SELLVALUE ();


        /// <summary>
        ///   System.Int32 get_Sorting()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Sorting")]
        ///  extern System.Int32 GET_SORTING ();


        /// <summary>
        ///   System.String get_Specialbehaviourscript()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Specialbehaviourscript")]
        ///  extern nint GET_SPECIALBEHAVIOURSCRIPT ();


        /// <summary>
        ///   System.String get_Typetag()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Typetag")]
        ///  extern nint GET_TYPETAG ();


        /// <summary>
        ///   System.String[] get_Usagetag()
        /// </summary>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Usagetag")]
        ///  extern nint GET_USAGETAG ();


        /// <summary>
        ///   System.String get_Visual()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Visual")]
        ///  extern nint GET_VISUAL ();


        /// <summary>
        ///   UnityEngine.GameObject get_VisualGameObject()
        /// </summary>
        /// <returns>class UnityEngine.GameObject</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_VisualGameObject")]
        ///  extern nint GET_VISUAL_GAME_OBJECT ();


        /// <summary>
        ///   UnityEngine.AddressableAssets.AssetReference get_VisualGameObjectRef()
        /// </summary>
        /// <returns>class UnityEngine.AddressableAssets.AssetReference</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_VisualGameObjectRef")]
        ///  extern nint GET_VISUAL_GAME_OBJECT_REF ();


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
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTranslationDescriptionTag")]
        extern nint GET_TRANSLATION_DESCRIPTION_TAG();


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
        ///   System.Void set_Audiotag(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Audiotag")]
        ///  extern void SET_AUDIOTAG (nint value);


        /// <summary>
        ///   System.Void set_Buyvalue(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Buyvalue")]
        ///  extern void SET_BUYVALUE (System.Int32 value);


        /// <summary>
        ///   System.Void set_Canthrow(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Canthrow")]
        ///  extern void SET_CANTHROW (System.Boolean value);


        /// <summary>
        ///   System.Void set_Classification(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Classification")]
        ///  extern void SET_CLASSIFICATION (nint value);


        /// <summary>
        ///   System.Void set_Convertsto(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Convertsto")]
        ///  extern void SET_CONVERTSTO (nint value);


        /// <summary>
        ///   System.Void set_Damage(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Damage")]
        ///  extern void SET_DAMAGE (System.Single value);


        /// <summary>
        ///   System.Void set_Hardness(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Hardness")]
        ///  extern void SET_HARDNESS (System.Single value);


        /// <summary>
        ///   System.Void set_Hasspecialbehaviour(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Hasspecialbehaviour")]
        ///  extern void SET_HASSPECIALBEHAVIOUR (System.Boolean value);


        /// <summary>
        ///   System.Void set_Interactmethod(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Interactmethod")]
        ///  extern void SET_INTERACTMETHOD (nint value);


        /// <summary>
        ///   System.Void set_Level(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Level")]
        ///  extern void SET_LEVEL (System.Int32 value);


        /// <summary>
        ///   System.Void set_Mass(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Mass")]
        ///  extern void SET_MASS (System.Single value);


        /// <summary>
        ///   System.Void set_Maxstack(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Maxstack")]
        ///  extern void SET_MAXSTACK (System.Int32 value);


        /// <summary>
        ///   System.Void set_Name(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Name")]
        ///  extern void SET_NAME (nint value);


        /// <summary>
        ///   System.Void set_Origintag(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Origintag")]
        ///  extern void SET_ORIGINTAG (nint value);


        /// <summary>
        ///   System.Void set_Sellable(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Sellable")]
        ///  extern void SET_SELLABLE (System.Boolean value);


        /// <summary>
        ///   System.Void set_Sellvalue(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Sellvalue")]
        ///  extern void SET_SELLVALUE (System.Int32 value);


        /// <summary>
        ///   System.Void set_Sorting(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Sorting")]
        ///  extern void SET_SORTING (System.Int32 value);


        /// <summary>
        ///   System.Void set_Specialbehaviourscript(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Specialbehaviourscript")]
        ///  extern void SET_SPECIALBEHAVIOURSCRIPT (nint value);


        /// <summary>
        ///   System.Void set_Typetag(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Typetag")]
        ///  extern void SET_TYPETAG (nint value);


        /// <summary>
        ///   System.Void set_Usagetag(System.String[] value)
        /// </summary>
        /// <param name="value">class System.String[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Usagetag")]
        ///  extern void SET_USAGETAG (nint value);


        /// <summary>
        ///   System.Void set_Visual(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Visual")]
        ///  extern void SET_VISUAL (nint value);


        /// <summary>
        ///   System.Void set_VisualGameObject(UnityEngine.GameObject value)
        /// </summary>
        /// <param name="value">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_VisualGameObject")]
        ///  extern void SET_VISUAL_GAME_OBJECT (nint value);


        /// <summary>
        ///   System.Void set_VisualGameObjectRef(UnityEngine.AddressableAssets.AssetReference value)
        /// </summary>
        /// <param name="value">class UnityEngine.AddressableAssets.AssetReference</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_VisualGameObjectRef")]
        ///  extern void SET_VISUAL_GAME_OBJECT_REF (nint value);



        /// <summary>
        ///   System.String GetLocalizedDescription()
        /// </summary>
        /// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDescription", Search = typeof(Search_InventoryItemsData))]
        extern PMonoString GET_LOCALIZED_DESCRIPTION_00();


        /// <summary>
        ///   System.String GetLocalizedDescription(System.Object[] args)
        /// </summary>
        /// <param name="args">class System.Object[]</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDescription", Search = typeof(Search_InventoryItemsData))]
        ///  extern nint GET_LOCALIZED_DESCRIPTION_01 (nint args);


        public static partial class Search_InventoryItemsData
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