
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
    /// class ["AzureValley".""."PlayerInventory"]
    /// [PlayerBehaviour]=>[BaseBehaviour]=>[UnityEngine.MonoBehaviour]=>[UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], 0x0200048DU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121], [], [80, 108, 97, 121, 101, 114, 73, 110, 118, 101, 110, 116, 111, 114, 121])]
                
    //  class static System.Collections.Generic.Dictionary<System.Type,System.Reflection.MethodInfo[]> m_mask
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"m_mask", "M_MASK", true)]
            
    //  struct static System.Int32 OffsetOfInstanceIDInCPlusPlusObject
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"OffsetOfInstanceIDInCPlusPlusObject", "OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT", true)]
                
    // struct 0x10 System.IntPtr m_CachedPtr
    // [MonoCollectorSearchFieldAttribute(typeof(System.IntPtr),"m_CachedPtr", "M_CACHED_PTR")]
            
    // class 0x18 System.Action[] m_events
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_events", "M_EVENTS")]
            
    // struct 0x20 System.Int32 UniqueScriptID
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"UniqueScriptID", "UNIQUE_SCRIPT_ID")]
            
    // struct 0x24 System.Boolean m_eventsEnabled
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_eventsEnabled", "M_EVENTS_ENABLED")]
            
    // abstract class 0x28 PlayerController <Player>k__BackingField
      [MonoCollectorSearchFieldAttribute(typeof(PMonoObject),"<Player>k__BackingField", "PLAYER")]
            
    // class 0x30 PlayerData <Data>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Data>k__BackingField", "DATA")]
            
    // class 0x38 GameUI <GameUI>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<GameUI>k__BackingField", "GAME_UI")]
            
    // class 0x40 TopDownTrackingCamera <TrackingCamera>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<TrackingCamera>k__BackingField", "TRACKING_CAMERA")]
    public partial class PlayerInventory
    { 
        //public const string Const_ImageName = "AzureValley";
        //public static byte[] Static_ImageName { get; } = [65, 122, 117, 114, 101, 86, 97, 108, 108, 101, 121];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "PlayerInventory";
        //public static byte[] Static_ClassName { get; } = [80, 108, 97, 121, 101, 114, 73, 110, 118, 101, 110, 116, 111, 114, 121];

        //public const uint Const_TypeToken = 0x0200048DU;



                    
        /// <summary>
        /// class System.String objectIsNullMessage "The Object you want to instantiate is null."
        /// </summary>
        /// public const nint OBJECT_IS_NULL_MESSAGE=>"The Object you want to instantiate is null.";
            
        /// <summary>
        /// class System.String cloneDestroyedMessage "Instantiate failed because the clone was destroyed during creati"
        /// </summary>
        /// public const nint CLONE_DESTROYED_MESSAGE=>"Instantiate failed because the clone was destroyed during creati";
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_PlayerInventory(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_PlayerInventory(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_PlayerInventory obj) => obj._ptr;
            public static implicit operator bool(Ptr_PlayerInventory obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["AzureValley".""."PlayerInventory"]
        /// </summary>
        public partial class PlayerInventory
        { 

            
            
            /// <summary>
            /// static  System.Void CheckNullArgument(System.Object arg, System.String message)
            /// </summary>
            /// <param name="arg">class System.Object</param>
            /// <param name="message">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckNullArgument")]
            /// static extern void CHECK_NULL_ARGUMENT (nint arg, nint message);

            
            /// <summary>
            /// static  System.Boolean CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs)
            /// </summary>
            /// <param name="lhs">class UnityEngine.Object</param>
            /// <param name="rhs">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareBaseObjects")]
            /// static extern System.Boolean COMPARE_BASE_OBJECTS (nint lhs, nint rhs);

            
            /// <summary>
            ///   System.Boolean CompareTag(System.String tag)
            /// </summary>
            /// <param name="tag">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTag")]
            ///  extern System.Boolean COMPARE_TAG (nint tag);

            
            /// <summary>
            /// static  System.Boolean CurrentThreadIsMainThread()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CurrentThreadIsMainThread")]
            /// static extern System.Boolean CURRENT_THREAD_IS_MAIN_THREAD ();

            
            /// <summary>
            ///   System.Void DeathStateChanged(System.Boolean isDead, PlayerDeathType type)
            /// </summary>
            /// <param name="isDead">struct System.Boolean</param>
            /// <param name="type">enum PlayerDeathType</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DeathStateChanged")]
            ///  extern void DEATH_STATE_CHANGED (System.Boolean isDead, PlayerDeathType type);

            
            /// <summary>
            ///   System.Void DisableGlobalEvents()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DisableGlobalEvents")]
            ///  extern void DISABLE_GLOBAL_EVENTS ();

            
            /// <summary>
            /// static  System.Boolean DoesObjectWithInstanceIDExist(System.Int32 instanceID)
            /// </summary>
            /// <param name="instanceID">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DoesObjectWithInstanceIDExist")]
            /// static extern System.Boolean DOES_OBJECT_WITH_INSTANCE_ID_EXIST (System.Int32 instanceID);

            
            /// <summary>
            ///   System.Void DoGivePlayerSharedItemLogic(InventoryItem item, System.Int32 amount)
            /// </summary>
            /// <param name="item">class InventoryItem</param>
            /// <param name="amount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DoGivePlayerSharedItemLogic")]
            ///  extern void DO_GIVE_PLAYER_SHARED_ITEM_LOGIC (nint item, System.Int32 amount);

            
            /// <summary>
            /// static  System.Void DontDestroyOnLoad(UnityEngine.Object target)
            /// </summary>
            /// <param name="target">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DontDestroyOnLoad")]
            /// static extern void DONT_DESTROY_ON_LOAD (nint target);

            
            /// <summary>
            ///   System.Void DoTakeSharedItemFromPLayerLogic(InventoryItem item, System.Int32 amount)
            /// </summary>
            /// <param name="item">class InventoryItem</param>
            /// <param name="amount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DoTakeSharedItemFromPLayerLogic")]
            ///  extern void DO_TAKE_SHARED_ITEM_FROM_P_LAYER_LOGIC (nint item, System.Int32 amount);

            
            /// <summary>
            ///   System.Void EnableGlobalEvents()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnableGlobalEvents")]
            ///  extern void ENABLE_GLOBAL_EVENTS ();

            
            /// <summary>
            ///   System.Void EnsureRunningOnMainThread()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnsureRunningOnMainThread")]
            ///  extern void ENSURE_RUNNING_ON_MAIN_THREAD ();

            
            /// <summary>
            ///   System.Boolean Equals(System.Object other)
            /// </summary>
            /// <param name="other">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals")]
            ///  extern System.Boolean EQUALS (nint other);

            
            /// <summary>
            /// static  UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID)
            /// </summary>
            /// <param name="instanceID">struct System.Int32</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectFromInstanceID")]
            /// static extern nint FIND_OBJECT_FROM_INSTANCE_ID (System.Int32 instanceID);

            
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfTypeAll")]
            /// static extern nint FIND_OBJECTS_OF_TYPE_ALL (nint type);

            
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfTypeIncludingAssets")]
            /// static extern nint FIND_OBJECTS_OF_TYPE_INCLUDING_ASSETS (nint type);

            
            /// <summary>
            /// static  UnityEngine.Object[] FindSceneObjectsOfType(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindSceneObjectsOfType")]
            /// static extern nint FIND_SCENE_OBJECTS_OF_TYPE (nint type);

            
            /// <summary>
            /// static  UnityEngine.Object ForceLoadFromInstanceID(System.Int32 instanceID)
            /// </summary>
            /// <param name="instanceID">struct System.Int32</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ForceLoadFromInstanceID")]
            /// static extern nint FORCE_LOAD_FROM_INSTANCE_ID (System.Int32 instanceID);

            
            /// <summary>
            ///   PlayerData get_Data()
            /// </summary>
            /// <returns>class PlayerData</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Data")]
            ///  extern nint GET_DATA ();

            
            /// <summary>
            ///   System.Boolean get_enabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_enabled")]
            ///  extern System.Boolean GET_ENABLED ();

            
            /// <summary>
            ///   UnityEngine.GameObject get_gameObject()
            /// </summary>
            /// <returns>class UnityEngine.GameObject</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameObject")]
            ///  extern nint GET_GAME_OBJECT ();

            
            /// <summary>
            ///   GameUI get_GameUI()
            /// </summary>
            /// <returns>class GameUI</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameUI")]
            ///  extern nint GET_GAME_UI ();

            
            /// <summary>
            ///   UnityEngine.HideFlags get_hideFlags()
            /// </summary>
            /// <returns>enum UnityEngine.HideFlags</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hideFlags")]
            ///  extern UnityEngine.HideFlags GET_HIDE_FLAGS ();

            
            /// <summary>
            ///   System.Boolean get_isActiveAndEnabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isActiveAndEnabled")]
            ///  extern System.Boolean GET_IS_ACTIVE_AND_ENABLED ();

            
            /// <summary>
            ///   Level get_Level()
            /// </summary>
            /// <returns>class Level</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Level")]
            ///  extern nint GET_LEVEL ();

            
            /// <summary>
            ///   System.String get_name()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_name")]
            ///  extern nint GET_NAME ();

            
            /// <summary>
            ///   PlayerController get_Player()
            /// </summary>
            /// <returns>abstract class PlayerController</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Player")]
            ///  extern nint GET_PLAYER ();

            
            /// <summary>
            ///   System.String get_tag()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tag")]
            ///  extern nint GET_TAG ();

            
            /// <summary>
            ///   TopDownTrackingCamera get_TrackingCamera()
            /// </summary>
            /// <returns>class TopDownTrackingCamera</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TrackingCamera")]
            ///  extern nint GET_TRACKING_CAMERA ();

            
            /// <summary>
            ///   UnityEngine.Transform get_transform()
            /// </summary>
            /// <returns>class UnityEngine.Transform</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_transform")]
            ///  extern nint GET_TRANSFORM ();

            
            /// <summary>
            ///   System.Boolean get_useGUILayout()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_useGUILayout")]
            ///  extern System.Boolean GET_USE_GUI_LAYOUT ();

            
            /// <summary>
            ///   System.IntPtr GetCachedPtr()
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCachedPtr")]
            ///  extern System.IntPtr GET_CACHED_PTR ();

            
            /// <summary>
            ///   System.Void GetComponentFastPath(System.Type type, System.IntPtr oneFurtherThanResultValue)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="oneFurtherThanResultValue">struct System.IntPtr</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentFastPath")]
            ///  extern void GET_COMPONENT_FAST_PATH (nint type, System.IntPtr oneFurtherThanResultValue);

            
            /// <summary>
            ///   System.Void GetComponentsForListInternal(System.Type searchType, System.Object resultList)
            /// </summary>
            /// <param name="searchType">abstract class System.Type</param>
            /// <param name="resultList">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsForListInternal")]
            ///  extern void GET_COMPONENTS_FOR_LIST_INTERNAL (nint searchType, nint resultList);

            
            /// <summary>
            ///   System.Int32 GetHashCode()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
            ///  extern System.Int32 GET_HASH_CODE ();

            
            /// <summary>
            ///   System.Int32 GetInstanceID()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInstanceID")]
            ///  extern System.Int32 GET_INSTANCE_ID ();

            
            /// <summary>
            /// static  System.String GetName(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetName")]
            /// static extern nint GET_NAME (nint obj);

            
            /// <summary>
            /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetOffsetOfInstanceIDInCPlusPlusObject")]
            /// static extern System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT ();

            
            /// <summary>
            ///   System.String GetScriptClassName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetScriptClassName")]
            ///  extern nint GET_SCRIPT_CLASS_NAME ();

            
            /// <summary>
            ///   System.Void HostApplyDelta(ClientInventoryDeltaData delta)
            /// </summary>
            /// <param name="delta">class ClientInventoryDeltaData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HostApplyDelta")]
            ///  extern void HOST_APPLY_DELTA (nint delta);

            
            /// <summary>
            /// static  System.Void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CancelInvokeAll")]
            /// static extern void INTERNAL_CANCEL_INVOKE_ALL (nint self);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CloneSingle")]
            /// static extern nint INTERNAL_CLONE_SINGLE (nint data);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="worldPositionStays">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CloneSingleWithParent")]
            /// static extern nint INTERNAL_CLONE_SINGLE_WITH_PARENT (nint data, nint parent, System.Boolean worldPositionStays);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <param name="pos">struct UnityEngine.Vector3</param>
            /// <param name="rot">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingle")]
            /// static extern nint INTERNAL_INSTANTIATE_SINGLE (nint data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <param name="pos">struct UnityEngine.Vector3&</param>
            /// <param name="rot">struct UnityEngine.Quaternion&</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingle_Injected")]
            /// static extern nint INTERNAL_INSTANTIATE_SINGLE_INJECTED (nint data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="pos">struct UnityEngine.Vector3</param>
            /// <param name="rot">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingleWithParent")]
            /// static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT (nint data, nint parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);

            
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
            /// </summary>
            /// <param name="data">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="pos">struct UnityEngine.Vector3&</param>
            /// <param name="rot">struct UnityEngine.Quaternion&</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingleWithParent_Injected")]
            /// static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT_INJECTED (nint data, nint parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot);

            
            /// <summary>
            /// static  System.Boolean Internal_IsInvokingAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_IsInvokingAll")]
            /// static extern System.Boolean INTERNAL_IS_INVOKING_ALL (nint self);

            
            /// <summary>
            ///   System.Void Invoke(System.String methodName, System.Single time)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="time">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Invoke")]
            ///  extern void INVOKE (nint methodName, System.Single time);

            
            /// <summary>
            /// static  System.Void InvokeDelayed(UnityEngine.MonoBehaviour self, System.String methodName, System.Single time, System.Single repeatRate)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <param name="methodName">class System.String</param>
            /// <param name="time">struct System.Single</param>
            /// <param name="repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InvokeDelayed")]
            /// static extern void INVOKE_DELAYED (nint self, nint methodName, System.Single time, System.Single repeatRate);

            
            /// <summary>
            ///   System.Void InvokeRepeating(System.String methodName, System.Single time, System.Single repeatRate)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="time">struct System.Single</param>
            /// <param name="repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InvokeRepeating")]
            ///  extern void INVOKE_REPEATING (nint methodName, System.Single time, System.Single repeatRate);

            
            /// <summary>
            /// static  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
            /// </summary>
            /// <param name="o">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsNativeObjectAlive")]
            /// static extern System.Boolean IS_NATIVE_OBJECT_ALIVE (nint o);

            
            /// <summary>
            /// static  System.Boolean IsObjectMonoBehaviour(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsObjectMonoBehaviour")]
            /// static extern System.Boolean IS_OBJECT_MONO_BEHAVIOUR (nint obj);

            
            /// <summary>
            /// static  System.Boolean IsPersistent(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsPersistent")]
            /// static extern System.Boolean IS_PERSISTENT (nint obj);

            
            /// <summary>
            ///   System.Void OnGameUIInitialized(GameUI gameUI)
            /// </summary>
            /// <param name="gameUI">class GameUI</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnGameUIInitialized")]
            ///  extern void ON_GAME_UI_INITIALIZED (nint gameUI);

            
            /// <summary>
            ///   System.Void OnInventoryUpdated(InventoryChangeEvent changeEvent)
            /// </summary>
            /// <param name="changeEvent">struct InventoryChangeEvent</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnInventoryUpdated")]
            ///  extern void ON_INVENTORY_UPDATED (InventoryChangeEvent changeEvent);

            
            /// <summary>
            ///   System.Void OnLevelChangedCallback(PlayerController player, Level level)
            /// </summary>
            /// <param name="player">abstract class PlayerController</param>
            /// <param name="level">class Level</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnLevelChangedCallback")]
            ///  extern void ON_LEVEL_CHANGED_CALLBACK (nint player, nint level);

            
            /// <summary>
            ///   System.Void OnLevelPostProcess(Level level)
            /// </summary>
            /// <param name="level">class Level</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnLevelPostProcess")]
            ///  extern void ON_LEVEL_POST_PROCESS (nint level);

            
            /// <summary>
            ///   System.Void OnPetSlotUpdated(InventoryChangeEvent changeEvent)
            /// </summary>
            /// <param name="changeEvent">struct InventoryChangeEvent</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnPetSlotUpdated")]
            ///  extern void ON_PET_SLOT_UPDATED (InventoryChangeEvent changeEvent);

            
            /// <summary>
            ///   System.Void OnSorted()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnSorted")]
            ///  extern void ON_SORTED ();

            
            /// <summary>
            /// static  System.Boolean op_Equality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name="x">class UnityEngine.Object</param>
            /// <param name="y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Equality")]
            /// static extern System.Boolean OP_EQUALITY (nint x, nint y);

            
            /// <summary>
            /// static  System.Boolean op_Implicit(UnityEngine.Object exists)
            /// </summary>
            /// <param name="exists">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit")]
            /// static extern System.Boolean OP_IMPLICIT (nint exists);

            
            /// <summary>
            /// static  System.Boolean op_Inequality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name="x">class UnityEngine.Object</param>
            /// <param name="y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Inequality")]
            /// static extern System.Boolean OP_INEQUALITY (nint x, nint y);

            
            /// <summary>
            /// static  System.Void print(System.Object message)
            /// </summary>
            /// <param name="message">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("print")]
            /// static extern void PRINT (nint message);

            
            /// <summary>
            ///   System.Void RemoveFromSharedInventory(InventoryItem item, System.Int32 amount)
            /// </summary>
            /// <param name="item">class InventoryItem</param>
            /// <param name="amount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFromSharedInventory")]
            ///  extern void REMOVE_FROM_SHARED_INVENTORY (nint item, System.Int32 amount);

            
            /// <summary>
            ///   System.Void set_Data(PlayerData value)
            /// </summary>
            /// <param name="value">class PlayerData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Data")]
            ///  extern void SET_DATA (nint value);

            
            /// <summary>
            ///   System.Void set_enabled(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_enabled")]
            ///  extern void SET_ENABLED (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_GameUI(GameUI value)
            /// </summary>
            /// <param name="value">class GameUI</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_GameUI")]
            ///  extern void SET_GAME_UI (nint value);

            
            /// <summary>
            ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
            /// </summary>
            /// <param name="value">enum UnityEngine.HideFlags</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_hideFlags")]
            ///  extern void SET_HIDE_FLAGS (UnityEngine.HideFlags value);

            
            /// <summary>
            ///   System.Void set_name(System.String value)
            /// </summary>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_name")]
            ///  extern void SET_NAME (nint value);

            
            /// <summary>
            ///   System.Void set_Player(PlayerController value)
            /// </summary>
            /// <param name="value">abstract class PlayerController</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Player")]
            ///  extern void SET_PLAYER (nint value);

            
            /// <summary>
            ///   System.Void set_tag(System.String value)
            /// </summary>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_tag")]
            ///  extern void SET_TAG (nint value);

            
            /// <summary>
            ///   System.Void set_TrackingCamera(TopDownTrackingCamera value)
            /// </summary>
            /// <param name="value">class TopDownTrackingCamera</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_TrackingCamera")]
            ///  extern void SET_TRACKING_CAMERA (nint value);

            
            /// <summary>
            ///   System.Void set_useGUILayout(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_useGUILayout")]
            ///  extern void SET_USE_GUI_LAYOUT (System.Boolean value);

            
            /// <summary>
            /// static  System.Void SetName(UnityEngine.Object obj, System.String name)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <param name="name">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetName")]
            /// static extern void SET_NAME (nint obj, nint name);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine_Auto")]
            ///  extern nint START_COROUTINE_AUTO (nint routine);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged(System.String methodName, System.Object value)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutineManaged")]
            ///  extern nint START_COROUTINE_MANAGED (nint methodName, nint value);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator)
            /// </summary>
            /// <param name="enumerator">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutineManaged2")]
            ///  extern nint START_COROUTINE_MANAGED2 (nint enumerator);

            
            /// <summary>
            ///   System.Void StopAllCoroutines()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopAllCoroutines")]
            ///  extern void STOP_ALL_COROUTINES ();

            
            /// <summary>
            ///   System.Void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutineFromEnumeratorManaged")]
            ///  extern void STOP_COROUTINE_FROM_ENUMERATOR_MANAGED (nint routine);

            
            /// <summary>
            ///   System.Void StopCoroutineManaged(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name="routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutineManaged")]
            ///  extern void STOP_COROUTINE_MANAGED (nint routine);
            
            
            
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor", Search = typeof(Search_PlayerInventory))]
            /// static extern void .CCTOR_00 ();

            
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor", Search = typeof(Search_PlayerInventory))]
            /// static extern void .CCTOR_01 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_PlayerInventory))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_PlayerInventory))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_PlayerInventory))]
            ///  extern void .CTOR_02 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_PlayerInventory))]
            ///  extern void .CTOR_03 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_PlayerInventory))]
            ///  extern void .CTOR_04 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_PlayerInventory))]
            ///  extern void .CTOR_05 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_PlayerInventory))]
            ///  extern void .CTOR_06 ();

            
            /// <summary>
            ///   System.Boolean AnyOf(InventoryItemsData item)
            /// </summary>
            /// <param name="item">class InventoryItemsData</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AnyOf", Search = typeof(Search_PlayerInventory))]
            ///  extern System.Boolean ANY_OF_00 (nint item);

            
            /// <summary>
            ///   System.Boolean AnyOf(ItemFilter filter)
            /// </summary>
            /// <param name="filter">class ItemFilter</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AnyOf", Search = typeof(Search_PlayerInventory))]
            ///  extern System.Boolean ANY_OF_01 (nint filter);

            
            /// <summary>
            ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="parameter">class System.Object</param>
            /// <param name="options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_PlayerInventory))]
            ///  extern void BROADCAST_MESSAGE_00 (nint methodName, nint parameter, UnityEngine.SendMessageOptions options);

            
            /// <summary>
            ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="parameter">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_PlayerInventory))]
            ///  extern void BROADCAST_MESSAGE_01 (nint methodName, nint parameter);

            
            /// <summary>
            ///   System.Void BroadcastMessage(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_PlayerInventory))]
            ///  extern void BROADCAST_MESSAGE_02 (nint methodName);

            
            /// <summary>
            ///   System.Void BroadcastMessage(System.String methodName, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_PlayerInventory))]
            ///  extern void BROADCAST_MESSAGE_03 (nint methodName, UnityEngine.SendMessageOptions options);

            
            /// <summary>
            ///   System.Void CancelInvoke()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_PlayerInventory))]
            ///  extern void CANCEL_INVOKE_00 ();

            
            /// <summary>
            ///   System.Void CancelInvoke(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_PlayerInventory))]
            ///  extern void CANCEL_INVOKE_01 (nint methodName);

            
            /// <summary>
            /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_PlayerInventory))]
            /// static extern void CANCEL_INVOKE_02 (nint self, nint methodName);

            
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <param name="t">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_PlayerInventory))]
            /// static extern void DESTROY_00 (nint obj, System.Single t);

            
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_PlayerInventory))]
            /// static extern void DESTROY_01 (nint obj);

            
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <param name="allowDestroyingAssets">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_PlayerInventory))]
            /// static extern void DESTROY_IMMEDIATE_00 (nint obj, System.Boolean allowDestroyingAssets);

            
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_PlayerInventory))]
            /// static extern void DESTROY_IMMEDIATE_01 (nint obj);

            
            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <param name="t">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyObject", Search = typeof(Search_PlayerInventory))]
            /// static extern void DESTROY_OBJECT_00 (nint obj, System.Single t);

            
            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyObject", Search = typeof(Search_PlayerInventory))]
            /// static extern void DESTROY_OBJECT_01 (nint obj);

            
            /// <summary>
            /// static  T FindObjectOfType()
            /// </summary>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_PlayerInventory))]
            /// static extern nint FIND_OBJECT_OF_TYPE_00 ();

            
            /// <summary>
            /// static  T FindObjectOfType(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_PlayerInventory))]
            /// static extern nint FIND_OBJECT_OF_TYPE_01 (System.Boolean includeInactive);

            
            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_PlayerInventory))]
            /// static extern nint FIND_OBJECT_OF_TYPE_02 (nint type);

            
            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_PlayerInventory))]
            /// static extern nint FIND_OBJECT_OF_TYPE_03 (nint type, System.Boolean includeInactive);

            
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_PlayerInventory))]
            /// static extern nint FIND_OBJECTS_OF_TYPE_00 (nint type);

            
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_PlayerInventory))]
            /// static extern nint FIND_OBJECTS_OF_TYPE_01 (nint type, System.Boolean includeInactive);

            
            /// <summary>
            /// static  T[] FindObjectsOfType()
            /// </summary>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_PlayerInventory))]
            /// static extern nint FIND_OBJECTS_OF_TYPE_02 ();

            
            /// <summary>
            /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_PlayerInventory))]
            /// static extern nint FIND_OBJECTS_OF_TYPE_03 (System.Boolean includeInactive);

            
            /// <summary>
            ///   UnityEngine.Component GetComponent(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENT_00 (nint type);

            
            /// <summary>
            ///   T GetComponent()
            /// </summary>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENT_01 ();

            
            /// <summary>
            ///   UnityEngine.Component GetComponent(System.String type)
            /// </summary>
            /// <param name="type">class System.String</param>
            /// <returns>class UnityEngine.Component</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENT_02 (nint type);

            
            /// <summary>
            ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENT_IN_CHILDREN_00 (nint t, System.Boolean includeInactive);

            
            /// <summary>
            ///   UnityEngine.Component GetComponentInChildren(System.Type t)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENT_IN_CHILDREN_01 (nint t);

            
            /// <summary>
            ///   T GetComponentInChildren(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENT_IN_CHILDREN_02 (System.Boolean includeInactive);

            
            /// <summary>
            ///   T GetComponentInChildren()
            /// </summary>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENT_IN_CHILDREN_03 ();

            
            /// <summary>
            ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENT_IN_PARENT_00 (nint t, System.Boolean includeInactive);

            
            /// <summary>
            ///   UnityEngine.Component GetComponentInParent(System.Type t)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENT_IN_PARENT_01 (nint t);

            
            /// <summary>
            ///   T GetComponentInParent(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENT_IN_PARENT_02 (System.Boolean includeInactive);

            
            /// <summary>
            ///   T GetComponentInParent()
            /// </summary>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENT_IN_PARENT_03 ();

            
            /// <summary>
            ///   UnityEngine.Component[] GetComponents(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENTS_00 (nint type);

            
            /// <summary>
            ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="results">class System.Collections.Generic.List<UnityEngine.Component></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_PlayerInventory))]
            ///  extern void GET_COMPONENTS_01 (nint type, nint results);

            
            /// <summary>
            ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name="results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_PlayerInventory))]
            ///  extern void GET_COMPONENTS_02 (nint results);

            
            /// <summary>
            ///   T[] GetComponents()
            /// </summary>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENTS_03 ();

            
            /// <summary>
            ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENTS_IN_CHILDREN_00 (nint t, System.Boolean includeInactive);

            
            /// <summary>
            ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENTS_IN_CHILDREN_01 (nint t);

            
            /// <summary>
            ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENTS_IN_CHILDREN_02 (System.Boolean includeInactive);

            
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <param name="result">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_PlayerInventory))]
            ///  extern void GET_COMPONENTS_IN_CHILDREN_03 (System.Boolean includeInactive, nint result);

            
            /// <summary>
            ///   T[] GetComponentsInChildren()
            /// </summary>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENTS_IN_CHILDREN_04 ();

            
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name="results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_PlayerInventory))]
            ///  extern void GET_COMPONENTS_IN_CHILDREN_05 (nint results);

            
            /// <summary>
            ///   UnityEngine.Component[] GetComponentsInParent(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENTS_IN_PARENT_00 (nint t, System.Boolean includeInactive);

            
            /// <summary>
            ///   UnityEngine.Component[] GetComponentsInParent(System.Type t)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENTS_IN_PARENT_01 (nint t);

            
            /// <summary>
            ///   T[] GetComponentsInParent(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENTS_IN_PARENT_02 (System.Boolean includeInactive);

            
            /// <summary>
            ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <param name="results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_PlayerInventory))]
            ///  extern void GET_COMPONENTS_IN_PARENT_03 (System.Boolean includeInactive, nint results);

            
            /// <summary>
            ///   T[] GetComponentsInParent()
            /// </summary>
            /// <returns>class T[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_PlayerInventory))]
            ///  extern nint GET_COMPONENTS_IN_PARENT_04 ();

            
            /// <summary>
            ///   System.Void GivePlayerItem(InventoryItemsData itemType, System.Int32 amount)
            /// </summary>
            /// <param name="itemType">class InventoryItemsData</param>
            /// <param name="amount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GivePlayerItem", Search = typeof(Search_PlayerInventory))]
            ///  extern void GIVE_PLAYER_ITEM_00 (nint itemType, System.Int32 amount);

            
            /// <summary>
            ///   System.Void GivePlayerItem(InventoryItem item, System.Int32 amount)
            /// </summary>
            /// <param name="item">class InventoryItem</param>
            /// <param name="amount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GivePlayerItem", Search = typeof(Search_PlayerInventory))]
            ///  extern void GIVE_PLAYER_ITEM_01 (nint item, System.Int32 amount);

            
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <param name="position">struct UnityEngine.Vector3</param>
            /// <param name="rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_PlayerInventory))]
            /// static extern nint INSTANTIATE_00 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);

            
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <param name="position">struct UnityEngine.Vector3</param>
            /// <param name="rotation">struct UnityEngine.Quaternion</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_PlayerInventory))]
            /// static extern nint INSTANTIATE_01 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);

            
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_PlayerInventory))]
            /// static extern nint INSTANTIATE_02 (nint original);

            
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_PlayerInventory))]
            /// static extern nint INSTANTIATE_03 (nint original, nint parent);

            
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="instantiateInWorldSpace">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_PlayerInventory))]
            /// static extern nint INSTANTIATE_04 (nint original, nint parent, System.Boolean instantiateInWorldSpace);

            
            /// <summary>
            /// static  T Instantiate(T original)
            /// </summary>
            /// <param name="original">class T</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_PlayerInventory))]
            /// static extern nint INSTANTIATE_05 (nint original);

            
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="position">struct UnityEngine.Vector3</param>
            /// <param name="rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_PlayerInventory))]
            /// static extern nint INSTANTIATE_06 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);

            
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="position">struct UnityEngine.Vector3</param>
            /// <param name="rotation">struct UnityEngine.Quaternion</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_PlayerInventory))]
            /// static extern nint INSTANTIATE_07 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);

            
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_PlayerInventory))]
            /// static extern nint INSTANTIATE_08 (nint original, nint parent);

            
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="worldPositionStays">struct System.Boolean</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_PlayerInventory))]
            /// static extern nint INSTANTIATE_09 (nint original, nint parent, System.Boolean worldPositionStays);

            
            /// <summary>
            ///   System.Boolean IsInvoking()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_PlayerInventory))]
            ///  extern System.Boolean IS_INVOKING_00 ();

            
            /// <summary>
            ///   System.Boolean IsInvoking(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_PlayerInventory))]
            ///  extern System.Boolean IS_INVOKING_01 (nint methodName);

            
            /// <summary>
            /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_PlayerInventory))]
            /// static extern System.Boolean IS_INVOKING_02 (nint self, nint methodName);

            
            /// <summary>
            ///   System.Void OnCreate()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCreate", Search = typeof(Search_PlayerInventory))]
            ///  extern void ON_CREATE_00 ();

            
            /// <summary>
            ///   System.Void OnCreate()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCreate", Search = typeof(Search_PlayerInventory))]
            ///  extern void ON_CREATE_01 ();

            
            /// <summary>
            ///   System.Void OnCreate()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCreate", Search = typeof(Search_PlayerInventory))]
            ///  extern void ON_CREATE_02 ();

            
            /// <summary>
            ///   System.Void OnDestroyed()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnDestroyed", Search = typeof(Search_PlayerInventory))]
            ///  extern void ON_DESTROYED_00 ();

            
            /// <summary>
            ///   System.Void OnDestroyed()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnDestroyed", Search = typeof(Search_PlayerInventory))]
            ///  extern void ON_DESTROYED_01 ();

            
            /// <summary>
            ///   System.Void OnDestroyed()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnDestroyed", Search = typeof(Search_PlayerInventory))]
            ///  extern void ON_DESTROYED_02 ();

            
            /// <summary>
            ///   System.Void SendMessage(System.String methodName, System.Object value)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_PlayerInventory))]
            ///  extern void SEND_MESSAGE_00 (nint methodName, nint value);

            
            /// <summary>
            ///   System.Void SendMessage(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_PlayerInventory))]
            ///  extern void SEND_MESSAGE_01 (nint methodName);

            
            /// <summary>
            ///   System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <param name="options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_PlayerInventory))]
            ///  extern void SEND_MESSAGE_02 (nint methodName, nint value, UnityEngine.SendMessageOptions options);

            
            /// <summary>
            ///   System.Void SendMessage(System.String methodName, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_PlayerInventory))]
            ///  extern void SEND_MESSAGE_03 (nint methodName, UnityEngine.SendMessageOptions options);

            
            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <param name="options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_PlayerInventory))]
            ///  extern void SEND_MESSAGE_UPWARDS_00 (nint methodName, nint value, UnityEngine.SendMessageOptions options);

            
            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName, System.Object value)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_PlayerInventory))]
            ///  extern void SEND_MESSAGE_UPWARDS_01 (nint methodName, nint value);

            
            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_PlayerInventory))]
            ///  extern void SEND_MESSAGE_UPWARDS_02 (nint methodName);

            
            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_PlayerInventory))]
            ///  extern void SEND_MESSAGE_UPWARDS_03 (nint methodName, UnityEngine.SendMessageOptions options);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_PlayerInventory))]
            ///  extern nint START_COROUTINE_00 (nint methodName);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_PlayerInventory))]
            ///  extern nint START_COROUTINE_01 (nint methodName, nint value);

            
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_PlayerInventory))]
            ///  extern nint START_COROUTINE_02 (nint routine);

            
            /// <summary>
            ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_PlayerInventory))]
            ///  extern void STOP_COROUTINE_00 (nint routine);

            
            /// <summary>
            ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name="routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_PlayerInventory))]
            ///  extern void STOP_COROUTINE_01 (nint routine);

            
            /// <summary>
            ///   System.Void StopCoroutine(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_PlayerInventory))]
            ///  extern void STOP_COROUTINE_02 (nint methodName);

            
            /// <summary>
            ///   System.Void TakeItemFromPlayer(InventoryItem item, System.Int32 amount, System.Boolean allowClientsToTakeSharedInventoryItems)
            /// </summary>
            /// <param name="item">class InventoryItem</param>
            /// <param name="amount">struct System.Int32</param>
            /// <param name="allowClientsToTakeSharedInventoryItems">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TakeItemFromPlayer", Search = typeof(Search_PlayerInventory))]
            ///  extern void TAKE_ITEM_FROM_PLAYER_00 (nint item, System.Int32 amount, System.Boolean allowClientsToTakeSharedInventoryItems);

            
            /// <summary>
            ///   System.Void TakeItemFromPlayer(InventoryItemsData item)
            /// </summary>
            /// <param name="item">class InventoryItemsData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TakeItemFromPlayer", Search = typeof(Search_PlayerInventory))]
            ///  extern void TAKE_ITEM_FROM_PLAYER_01 (nint item);

            
            /// <summary>
            ///   System.Void TakeItemFromPlayer(InventoryItemsData item, System.Int32 amount)
            /// </summary>
            /// <param name="item">class InventoryItemsData</param>
            /// <param name="amount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TakeItemFromPlayer", Search = typeof(Search_PlayerInventory))]
            ///  extern void TAKE_ITEM_FROM_PLAYER_02 (nint item, System.Int32 amount);

            
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_PlayerInventory))]
            ///  extern nint TO_STRING_00 ();

            
            /// <summary>
            /// static  System.String ToString(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_PlayerInventory))]
            /// static extern nint TO_STRING_01 (nint obj);

            
            /// <summary>
            ///   System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="component">class UnityEngine.Component&</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetComponent", Search = typeof(Search_PlayerInventory))]
            ///  extern System.Boolean TRY_GET_COMPONENT_00 (nint type, nint component);

            
            /// <summary>
            ///   System.Boolean TryGetComponent(T& component)
            /// </summary>
            /// <param name="component">class T&</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetComponent", Search = typeof(Search_PlayerInventory))]
            ///  extern System.Boolean TRY_GET_COMPONENT_01 (nint component);

            
            /// public static partial class Search_PlayerInventory
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    /// static  System.Void .cctor()
                    /// </summary>
                    /// public static bool .CCTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".cctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void .cctor()
                    /// </summary>
                    /// public static bool .CCTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".cctor");
                    ///     
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
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean AnyOf(InventoryItemsData item)
                    /// </summary>
                    /// public static bool ANY_OF_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AnyOf", "InventoryItemsData");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean AnyOf(ItemFilter filter)
                    /// </summary>
                    /// public static bool ANY_OF_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AnyOf", "ItemFilter");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options)
                    /// </summary>
                    /// public static bool BROADCAST_MESSAGE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String", "System.Object", "UnityEngine.SendMessageOptions");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter)
                    /// </summary>
                    /// public static bool BROADCAST_MESSAGE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String", "System.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void BroadcastMessage(System.String methodName)
                    /// </summary>
                    /// public static bool BROADCAST_MESSAGE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void BroadcastMessage(System.String methodName, UnityEngine.SendMessageOptions options)
                    /// </summary>
                    /// public static bool BROADCAST_MESSAGE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String", "UnityEngine.SendMessageOptions");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void CancelInvoke()
                    /// </summary>
                    /// public static bool CANCEL_INVOKE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CancelInvoke");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void CancelInvoke(System.String methodName)
                    /// </summary>
                    /// public static bool CANCEL_INVOKE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CancelInvoke", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
                    /// </summary>
                    /// public static bool CANCEL_INVOKE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CancelInvoke", "UnityEngine.MonoBehaviour", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
                    /// </summary>
                    /// public static bool DESTROY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Destroy", "UnityEngine.Object", "System.Single");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void Destroy(UnityEngine.Object obj)
                    /// </summary>
                    /// public static bool DESTROY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Destroy", "UnityEngine.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
                    /// </summary>
                    /// public static bool DESTROY_IMMEDIATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyImmediate", "UnityEngine.Object", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
                    /// </summary>
                    /// public static bool DESTROY_IMMEDIATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyImmediate", "UnityEngine.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
                    /// </summary>
                    /// public static bool DESTROY_OBJECT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyObject", "UnityEngine.Object", "System.Single");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void DestroyObject(UnityEngine.Object obj)
                    /// </summary>
                    /// public static bool DESTROY_OBJECT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyObject", "UnityEngine.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T FindObjectOfType()
                    /// </summary>
                    /// public static bool FIND_OBJECT_OF_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T FindObjectOfType(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool FIND_OBJECT_OF_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object FindObjectOfType(System.Type type)
                    /// </summary>
                    /// public static bool FIND_OBJECT_OF_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool FIND_OBJECT_OF_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
                    /// </summary>
                    /// public static bool FIND_OBJECTS_OF_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool FIND_OBJECTS_OF_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T[] FindObjectsOfType()
                    /// </summary>
                    /// public static bool FIND_OBJECTS_OF_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool FIND_OBJECTS_OF_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponent(System.Type type)
                    /// </summary>
                    /// public static bool GET_COMPONENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponent()
                    /// </summary>
                    /// public static bool GET_COMPONENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponent(System.String type)
                    /// </summary>
                    /// public static bool GET_COMPONENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_CHILDREN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponentInChildren(System.Type t)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_CHILDREN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponentInChildren(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_CHILDREN_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponentInChildren()
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_CHILDREN_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_PARENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponentInParent(System.Type t)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_PARENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponentInParent(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_PARENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponentInParent()
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_PARENT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component[] GetComponents(System.Type type)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Type", "System.Collections.Generic.List<UnityEngine.Component>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponents()
                    /// </summary>
                    /// public static bool GET_COMPONENTS_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Boolean", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInChildren()
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component[] GetComponentsInParent(System.Type t, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component[] GetComponentsInParent(System.Type t)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInParent(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Boolean", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInParent()
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GivePlayerItem(InventoryItemsData itemType, System.Int32 amount)
                    /// </summary>
                    /// public static bool GIVE_PLAYER_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GivePlayerItem", "InventoryItemsData", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GivePlayerItem(InventoryItem item, System.Int32 amount)
                    /// </summary>
                    /// public static bool GIVE_PLAYER_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GivePlayerItem", "InventoryItem", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
                    /// </summary>
                    /// public static bool INSTANTIATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Vector3", "UnityEngine.Quaternion");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
                    /// </summary>
                    /// public static bool INSTANTIATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Transform");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
                    /// </summary>
                    /// public static bool INSTANTIATE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
                    /// </summary>
                    /// public static bool INSTANTIATE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Transform");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
                    /// </summary>
                    /// public static bool INSTANTIATE_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Transform", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original)
                    /// </summary>
                    /// public static bool INSTANTIATE_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
                    /// </summary>
                    /// public static bool INSTANTIATE_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
                    /// </summary>
                    /// public static bool INSTANTIATE_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Transform");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Transform parent)
                    /// </summary>
                    /// public static bool INSTANTIATE_08 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
                    /// </summary>
                    /// public static bool INSTANTIATE_09 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean IsInvoking()
                    /// </summary>
                    /// public static bool IS_INVOKING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsInvoking");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean IsInvoking(System.String methodName)
                    /// </summary>
                    /// public static bool IS_INVOKING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsInvoking", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
                    /// </summary>
                    /// public static bool IS_INVOKING_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsInvoking", "UnityEngine.MonoBehaviour", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnCreate()
                    /// </summary>
                    /// public static bool ON_CREATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnCreate");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnCreate()
                    /// </summary>
                    /// public static bool ON_CREATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnCreate");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnCreate()
                    /// </summary>
                    /// public static bool ON_CREATE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnCreate");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnDestroyed()
                    /// </summary>
                    /// public static bool ON_DESTROYED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnDestroyed");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnDestroyed()
                    /// </summary>
                    /// public static bool ON_DESTROYED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnDestroyed");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void OnDestroyed()
                    /// </summary>
                    /// public static bool ON_DESTROYED_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "OnDestroyed");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessage(System.String methodName, System.Object value)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String", "System.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessage(System.String methodName)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String", "System.Object", "UnityEngine.SendMessageOptions");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessage(System.String methodName, UnityEngine.SendMessageOptions options)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String", "UnityEngine.SendMessageOptions");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessageUpwards(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_UPWARDS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String", "System.Object", "UnityEngine.SendMessageOptions");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessageUpwards(System.String methodName, System.Object value)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_UPWARDS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String", "System.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessageUpwards(System.String methodName)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_UPWARDS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SendMessageUpwards(System.String methodName, UnityEngine.SendMessageOptions options)
                    /// </summary>
                    /// public static bool SEND_MESSAGE_UPWARDS_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String", "UnityEngine.SendMessageOptions");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
                    /// </summary>
                    /// public static bool START_COROUTINE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartCoroutine", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
                    /// </summary>
                    /// public static bool START_COROUTINE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartCoroutine", "System.String", "System.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
                    /// </summary>
                    /// public static bool START_COROUTINE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartCoroutine", "System.Collections.IEnumerator");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
                    /// </summary>
                    /// public static bool STOP_COROUTINE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopCoroutine", "System.Collections.IEnumerator");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
                    /// </summary>
                    /// public static bool STOP_COROUTINE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopCoroutine", "UnityEngine.Coroutine");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void StopCoroutine(System.String methodName)
                    /// </summary>
                    /// public static bool STOP_COROUTINE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopCoroutine", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void TakeItemFromPlayer(InventoryItem item, System.Int32 amount, System.Boolean allowClientsToTakeSharedInventoryItems)
                    /// </summary>
                    /// public static bool TAKE_ITEM_FROM_PLAYER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TakeItemFromPlayer", "InventoryItem", "System.Int32", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void TakeItemFromPlayer(InventoryItemsData item)
                    /// </summary>
                    /// public static bool TAKE_ITEM_FROM_PLAYER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TakeItemFromPlayer", "InventoryItemsData");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void TakeItemFromPlayer(InventoryItemsData item, System.Int32 amount)
                    /// </summary>
                    /// public static bool TAKE_ITEM_FROM_PLAYER_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TakeItemFromPlayer", "InventoryItemsData", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.String ToString()
                    /// </summary>
                    /// public static bool TO_STRING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.String ToString(UnityEngine.Object obj)
                    /// </summary>
                    /// public static bool TO_STRING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString", "UnityEngine.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
                    /// </summary>
                    /// public static bool TRY_GET_COMPONENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TryGetComponent", "System.Type", "UnityEngine.Component&");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean TryGetComponent(T& component)
                    /// </summary>
                    /// public static bool TRY_GET_COMPONENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TryGetComponent", "T&");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}