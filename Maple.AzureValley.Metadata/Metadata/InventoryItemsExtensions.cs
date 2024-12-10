
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.AzureValley.Metadata
{


    /// <summary>
    /// static class ["AzureValley".""."InventoryItemsExtensions"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x020000B0U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [73, 110, 118, 101, 110, 116, 111, 114, 121, 73, 116, 101, 109, 115, 69, 120, 116, 101, 110, 115, 105, 111, 110, 115])]


    public partial class InventoryItemsExtensions
    {
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "InventoryItemsExtensions";
        //public static byte[] Static_ClassName { get; } = [73, 110, 118, 101, 110, 116, 111, 114, 121, 73, 116, 101, 109, 115, 69, 120, 116, 101, 110, 115, 105, 111, 110, 115];

        //public const uint Const_TypeToken = 0x020000B0U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_InventoryItemsExtensions(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_InventoryItemsExtensions(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_InventoryItemsExtensions obj) => obj._ptr;
            public static implicit operator bool(Ptr_InventoryItemsExtensions obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["AzureValley".""."InventoryItemsExtensions"]
    /// </summary>
    public partial class InventoryItemsExtensions
    {



        /// <summary>
        /// static  UnityEngine.Localization.LocalizedString GenerateInformation(InventoryItemsData item, System.Boolean includeDescription)
        /// </summary>
        /// <param name="item">class InventoryItemsData</param>
        /// <param name="includeDescription">struct System.Boolean</param>
        /// <returns>class UnityEngine.Localization.LocalizedString</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateInformation")]
        /// static extern nint GENERATE_INFORMATION (nint item, System.Boolean includeDescription);


        /// <summary>
        /// static  System.String GetAddressablePath(InventoryItemsData item)
        /// </summary>
        /// <param name="item">class InventoryItemsData</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAddressablePath")]
        /// static extern nint GET_ADDRESSABLE_PATH (nint item);


        /// <summary>
        /// static  System.String GetAnimationAddressablePath(InventoryItemsData item, System.Int32 frame)
        /// </summary>
        /// <param name="item">class InventoryItemsData</param>
        /// <param name="frame">struct System.Int32</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAnimationAddressablePath")]
        /// static extern nint GET_ANIMATION_ADDRESSABLE_PATH (nint item, System.Int32 frame);


        /// <summary>
        /// static  System.String GetClassificationName(InventoryItemsData data)
        /// </summary>
        /// <param name="data">class InventoryItemsData</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetClassificationName")]
        /// static extern nint GET_CLASSIFICATION_NAME (nint data);


        /// <summary>
        /// static  System.Int32 GetCostInShop(InventoryItemsData item, System.String shopName)
        /// </summary>
        /// <param name="item">class InventoryItemsData</param>
        /// <param name="shopName">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCostInShop")]
        /// static extern System.Int32 GET_COST_IN_SHOP (nint item, nint shopName);


        /// <summary>
        /// static  UnityEngine.Localization.LocalizedString GetDescription(InventoryItemsData item)
        /// </summary>
        /// <param name="item">class InventoryItemsData</param>
        /// <returns>class UnityEngine.Localization.LocalizedString</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDescription")]
        /// static extern nint GET_DESCRIPTION (nint item);


        /// <summary>
        /// static  UnityEngine.Localization.LocalizedString GetLocalizedOrigin(InventoryItemsData itemType)
        /// </summary>
        /// <param name="itemType">class InventoryItemsData</param>
        /// <returns>class UnityEngine.Localization.LocalizedString</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedOrigin")]
        /// static extern nint GET_LOCALIZED_ORIGIN (nint itemType);


        /// <summary>
        /// static  UnityEngine.Localization.LocalizedString GetLocalizedType(InventoryItemsData itemType)
        /// </summary>
        /// <param name="itemType">class InventoryItemsData</param>
        /// <returns>class UnityEngine.Localization.LocalizedString</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedType")]
        /// static extern nint GET_LOCALIZED_TYPE (nint itemType);


        /// <summary>
        /// static  System.Collections.Generic.List<UnityEngine.Localization.LocalizedString> GetLocalizedUpgradeProperties(InventoryItem item)
        /// </summary>
        /// <param name="item">class InventoryItem</param>
        /// <returns>class System.Collections.Generic.List<UnityEngine.Localization.LocalizedString></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedUpgradeProperties")]
        /// static extern nint GET_LOCALIZED_UPGRADE_PROPERTIES (nint item);


        /// <summary>
        /// static  System.Collections.Generic.List<UnityEngine.Localization.LocalizedString> GetLocalizedUses(InventoryItemsData itemType)
        /// </summary>
        /// <param name="itemType">class InventoryItemsData</param>
        /// <returns>class System.Collections.Generic.List<UnityEngine.Localization.LocalizedString></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedUses")]
        /// static extern nint GET_LOCALIZED_USES (nint itemType);


        /// <summary>
        /// static  UnityEngine.Localization.LocalizedString GetName(InventoryItemsData item)
        /// </summary>
        /// <param name="item">class InventoryItemsData</param>
        /// <returns>class UnityEngine.Localization.LocalizedString</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetName")]
        /// static extern nint GET_NAME (nint item);


        /// <summary>
        /// static  RecipesData GetRecipeToBuildItem(InventoryItemsData itemType)
        /// </summary>
        /// <param name="itemType">class InventoryItemsData</param>
        /// <returns>class RecipesData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRecipeToBuildItem")]
        /// static extern nint GET_RECIPE_TO_BUILD_ITEM (nint itemType);


        /// <summary>
        /// static  InventoryItemsData GetShopCurrency(InventoryItemsData item, System.String shopName)
        /// </summary>
        /// <param name="item">class InventoryItemsData</param>
        /// <param name="shopName">class System.String</param>
        /// <returns>class InventoryItemsData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetShopCurrency")]
        /// static extern nint GET_SHOP_CURRENCY (nint item, nint shopName);


        /// <summary>
        /// static  System.Int32 GetSkin(InventoryItem item)
        /// </summary>
        /// <param name="item">class InventoryItem</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSkin")]
        /// static extern System.Int32 GET_SKIN (nint item);


        /// <summary>
        /// static  System.String GetSkinAddressablePath(InventoryItemsData item, System.Int32 skin)
        /// </summary>
        /// <param name="item">class InventoryItemsData</param>
        /// <param name="skin">struct System.Int32</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSkinAddressablePath")]
        /// static extern nint GET_SKIN_ADDRESSABLE_PATH (nint item, System.Int32 skin);


        /// <summary>
        /// static  UnityEngine.GameObject GetWorldObjectInstance(InventoryItemsData itemType)
        /// </summary>
        /// <param name="itemType">class InventoryItemsData</param>
        /// <returns>class UnityEngine.GameObject</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetWorldObjectInstance")]
        /// static extern nint GET_WORLD_OBJECT_INSTANCE (nint itemType);


        /// <summary>
        /// static  System.Boolean IsBlueprint(InventoryItemsData itemType)
        /// </summary>
        /// <param name="itemType">class InventoryItemsData</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsBlueprint")]
        /// static extern System.Boolean IS_BLUEPRINT (nint itemType);


        /// <summary>
        /// static  System.Boolean IsHidden(InventoryItemsData itemType)
        /// </summary>
        /// <param name="itemType">class InventoryItemsData</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsHidden")]
        /// static extern System.Boolean IS_HIDDEN (nint itemType);


        /// <summary>
        /// static  System.Boolean IsQuest(InventoryItemsData itemType)
        /// </summary>
        /// <param name="itemType">class InventoryItemsData</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsQuest")]
        /// static extern System.Boolean IS_QUEST (nint itemType);


        /// <summary>
        /// static  System.Boolean IsTool(InventoryItemsData itemType)
        /// </summary>
        /// <param name="itemType">class InventoryItemsData</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsTool")]
        /// static extern System.Boolean IS_TOOL (nint itemType);


        /// <summary>
        /// static  System.Boolean IsTorch(InventoryItemsData itemType)
        /// </summary>
        /// <param name="itemType">class InventoryItemsData</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsTorch")]
        /// static extern System.Boolean IS_TORCH (nint itemType);


        /// <summary>
        /// static  System.Void IterateOverInteractedTiles(InventoryItemsData item, Level level, Unity.Mathematics.float3 from, Unity.Mathematics.int2 target, System.Action<Unity.Mathematics.int2,System.Single> tileCallback)
        /// </summary>
        /// <param name="item">class InventoryItemsData</param>
        /// <param name="level">class Level</param>
        /// <param name="from">struct Unity.Mathematics.float3</param>
        /// <param name="target">struct Unity.Mathematics.int2</param>
        /// <param name="tileCallback">class System.Action<Unity.Mathematics.int2,System.Single></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IterateOverInteractedTiles")]
        /// static extern void ITERATE_OVER_INTERACTED_TILES (nint item, nint level, Unity.Mathematics.float3 from, Unity.Mathematics.int2 target, nint tileCallback);


        /// <summary>
        /// static  WorldItemsData ToWorldItem(InventoryItemsData item)
        /// </summary>
        /// <param name="item">class InventoryItemsData</param>
        /// <returns>class WorldItemsData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToWorldItem")]
        /// static extern nint TO_WORLD_ITEM (nint item);



        /// <summary>
        /// static  UnityEngine.Sprite GetSprite(InventoryItemsData itemType, System.Nullable<System.Int32> skin)
        /// </summary>
        /// <param name="itemType">class InventoryItemsData</param>
        /// <param name="skin">struct System.Nullable<System.Int32></param>
        /// <returns>class UnityEngine.Sprite</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSprite", Search = typeof(Search_InventoryItemsExtensions))]
        static extern nint GET_SPRITE_00(InventoryItemsData.Ptr_InventoryItemsData itemType, REF_NULLABLE<int> skin);


        /// <summary>
        /// static  UnityEngine.Sprite GetSprite(InventoryItem item)
        /// </summary>
        /// <param name="item">class InventoryItem</param>
        /// <returns>class UnityEngine.Sprite</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSprite", Search = typeof(Search_InventoryItemsExtensions))]
        static extern nint GET_SPRITE_01(InventoryItem.Ptr_InventoryItem item);


        public static partial class Search_InventoryItemsExtensions
        {
            /// 
            ///     

            /// <summary>
            /// static  UnityEngine.Sprite GetSprite(InventoryItemsData itemType, System.Nullable<System.Int32> skin)
            /// </summary>
            public static bool GET_SPRITE_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetSprite", "InventoryItemsData", "System.Nullable<System.Int32>");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Sprite GetSprite(InventoryItem item)
            /// </summary>
            public static bool GET_SPRITE_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetSprite", "InventoryItem");
            ///     
            ///  
            /// 
            /// 
        }

    }


}