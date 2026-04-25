// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 5
// Methods: 75

namespace ThirdParty.Unity.UnityEngine
{
    public class Object : Object
    {
        public UIntPtr name; // 0x10
        public int hideFlags;
        public string objectIsNullMessage;
        public string cloneDestroyedMessage;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC98C5BD0
        public void GetHashCode(){} // RVA: 0x7FFAC98C5CD0
        public void Equals(){} // RVA: 0x7FFAC98C5CE0
        public void op_Implicit(){} // RVA: 0x7FFAC98C5F10
        public void CompareBaseObjects(){} // RVA: 0x7FFAC98C5FA0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC98C6070
        public void GetCachedPtr(){} // RVA: 0x7FFAC5CC4750
        public void get_name(){} // RVA: 0x7FFAC98C6090
        public void set_name(){} // RVA: 0x7FFAC98C6120
        public void Instantiate(){} // RVA: 0x7FFAC2E8DC40 | overloaded x10
        public void Destroy(){} // RVA: 0x7FFAC98C6CF0 | overloaded x2
        public void DestroyImmediate(){} // RVA: 0x7FFAC98C6DE0 | overloaded x2
        public void FindObjectsOfType(){} // RVA: 0x7FFAC98C6F00 | overloaded x2
        public void FindObjectsByType(){} // RVA: 0x7FFAC2C5E8C0 | overloaded x3
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC98C7070
        public void get_hideFlags(){} // RVA: 0x7FFAC98C70C0
        public void set_hideFlags(){} // RVA: 0x7FFAC98C7110
        public void FindObjectOfType(){} // RVA: 0x7FFAC98C7340 | overloaded x3
        public void FindFirstObjectByType(){} // RVA: 0x7FFAC98C7400 | overloaded x4
        public void CheckNullArgument(){} // RVA: 0x7FFAC98C7170
        public void ToString(){} // RVA: 0x7FFAC98C7A00 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC98C7560
        public void op_Inequality(){} // RVA: 0x7FFAC98C7670
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFAC98C7780
        public void Internal_CloneSingle(){} // RVA: 0x7FFAC98C77D0
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFAC98C7820
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFAC98C7890
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFAC98C7940
        public void GetName(){} // RVA: 0x7FFAC98C7A50
        public void SetName(){} // RVA: 0x7FFAC98C7AA0
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFAC98C7B00
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFAC98C7B50
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC98C7BA0
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFAC98C7BE0
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFAC98C7C50
    }

    public class ObjectDispatcher : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public System.Action`6<UnityEngine.Object[],UIntPtr,UIntPtr,int,int,System.Action`1<UnityEngine.TypeDispatchData>> s_TypeDispatch;
        public System.Action`8<UIntPtr,UIntPtr,UIntPtr,UIntPtr,UIntPtr,UIntPtr,int,System.Action`1<UnityEngine.TransformDispatchData>> s_TransformDispatch; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC98B65D0
    }

    public class ObjectGUIState : Object
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC992E140
        public void Dispose(){} // RVA: 0x7FFAC992E190
        public void Finalize(){} // RVA: 0x7FFAC992E1F0
        public void Destroy(){} // RVA: 0x7FFAC992E230
        public void Internal_Create(){} // RVA: 0x7FFAC992E2A0
        public void Internal_Destroy(){} // RVA: 0x7FFAC992E2F0
    }

    public class OcclusionArea : Component
    {
        public object center;
        public object size;

        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFAC9888610
        public void set_center(){} // RVA: 0x7FFAC9888680
        public void get_size(){} // RVA: 0x7FFAC98886E0
        public void set_size(){} // RVA: 0x7FFAC9888750
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_center_Injected(){} // RVA: 0x7FFAC98887B0
        public void set_center_Injected(){} // RVA: 0x7FFAC9888810
        public void get_size_Injected(){} // RVA: 0x7FFAC9888870
        public void set_size_Injected(){} // RVA: 0x7FFAC98888D0
    }

    public class OcclusionPortal : Component
    {
        public object open;

        // ── Methods ──
        public void get_open(){} // RVA: 0x7FFAC9888560
        public void set_open(){} // RVA: 0x7FFAC98885B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

}