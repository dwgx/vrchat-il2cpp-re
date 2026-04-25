// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 4
// Methods: 69

namespace ThirdParty.Unity.UnityEngine
{
    public class Object : Object
    {
        public UIntPtr name; // 0x10
        public int hideFlags;
        public string objectIsNullMessage;
        public string cloneDestroyedMessage;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD54CE5BD0
        public void GetHashCode(){} // RVA: 0x7FFD54CE5CD0
        public void Equals(){} // RVA: 0x7FFD54CE5CE0
        public void op_Implicit(){} // RVA: 0x7FFD54CE5F10
        public void CompareBaseObjects(){} // RVA: 0x7FFD54CE5FA0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD54CE6070
        public void GetCachedPtr(){} // RVA: 0x7FFD510E4750
        public void get_name(){} // RVA: 0x7FFD54CE6090
        public void set_name(){} // RVA: 0x7FFD54CE6120
        public void Instantiate(){} // RVA: 0x7FFD4E2ADC40 | overloaded x10
        public void Destroy(){} // RVA: 0x7FFD54CE6CF0 | overloaded x2
        public void DestroyImmediate(){} // RVA: 0x7FFD54CE6DE0 | overloaded x2
        public void FindObjectsOfType(){} // RVA: 0x7FFD54CE6F00 | overloaded x2
        public void FindObjectsByType(){} // RVA: 0x7FFD4E07E8C0 | overloaded x3
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD54CE7070
        public void get_hideFlags(){} // RVA: 0x7FFD54CE70C0
        public void set_hideFlags(){} // RVA: 0x7FFD54CE7110
        public void FindObjectOfType(){} // RVA: 0x7FFD54CE7340 | overloaded x3
        public void FindFirstObjectByType(){} // RVA: 0x7FFD54CE7400 | overloaded x4
        public void CheckNullArgument(){} // RVA: 0x7FFD54CE7170
        public void ToString(){} // RVA: 0x7FFD54CE7A00 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD54CE7560
        public void op_Inequality(){} // RVA: 0x7FFD54CE7670
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFD54CE7780
        public void Internal_CloneSingle(){} // RVA: 0x7FFD54CE77D0
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFD54CE7820
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFD54CE7890
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFD54CE7940
        public void GetName(){} // RVA: 0x7FFD54CE7A50
        public void SetName(){} // RVA: 0x7FFD54CE7AA0
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFD54CE7B00
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFD54CE7B50
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54CE7BA0
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFD54CE7BE0
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFD54CE7C50
    }

    public class ObjectDispatcher : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public System.Action`6<UnityEngine.Object[],UIntPtr,UIntPtr,int,int,System.Action`1<0x664DD8E0>> s_TypeDispatch;
        public System.Action`8<UIntPtr,UIntPtr,UIntPtr,UIntPtr,UIntPtr,UIntPtr,int,System.Action`1<0x664DD938>> s_TransformDispatch; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54CD65D0
    }

    public class OcclusionArea : Component
    {
        public object center;
        public object size;

        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFD54CA8610
        public void set_center(){} // RVA: 0x7FFD54CA8680
        public void get_size(){} // RVA: 0x7FFD54CA86E0
        public void set_size(){} // RVA: 0x7FFD54CA8750
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_center_Injected(){} // RVA: 0x7FFD54CA87B0
        public void set_center_Injected(){} // RVA: 0x7FFD54CA8810
        public void get_size_Injected(){} // RVA: 0x7FFD54CA8870
        public void set_size_Injected(){} // RVA: 0x7FFD54CA88D0
    }

    public class OcclusionPortal : Component
    {
        public object open;

        // ── Methods ──
        public void get_open(){} // RVA: 0x7FFD54CA8560
        public void set_open(){} // RVA: 0x7FFD54CA85B0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}