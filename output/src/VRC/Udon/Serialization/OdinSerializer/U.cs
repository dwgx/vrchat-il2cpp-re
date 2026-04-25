// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 7
// Methods: 53

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class UInt16Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD5542D680
        public void WriteValue(){} // RVA: 0x7FFD5542E350
        public void .ctor(){} // RVA: 0x7FFD5542E3C0
    }

    public class UInt32Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD5542E430
        public void WriteValue(){} // RVA: 0x7FFD5542F100
        public void .ctor(){} // RVA: 0x7FFD5542F170
    }

    public class UInt64Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD5542F1E0
        public void WriteValue(){} // RVA: 0x7FFD5542FEA0
        public void .ctor(){} // RVA: 0x7FFD5542FF10
    }

    public class UIntPtrSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD5542FF80
        public void WriteValue(){} // RVA: 0x7FFD55430C40
        public void .ctor(){} // RVA: 0x7FFD55430CB0
    }

    public class UnityReferenceResolver : Object
    {
        public System.Collections.Generic.Dictionary`2<UnityEngine.Object,int> referenceIndexMapping; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.Object> referencedUnityObjects; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5543CE60 | overloaded x2
        public void GetReferencedUnityObjects(){} // RVA: 0x7FFD4E3447C0
        public void SetReferencedUnityObjects(){} // RVA: 0x7FFD5543D000
        public void CanReference(){} // RVA: 0x7FFD5543D240
        public void TryResolveReference(){} // RVA: 0x7FFD5543D4C0
        public void Reset(){} // RVA: 0x7FFD5543D5D0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7FFD5543D5D0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7FFD4E341310
    }

    public class UnitySerializationInitializer : Object
    {
        public object Initialized;
        public bool CurrentPlatform; // 0x8
        public 0x664D9580 <CurrentPlatform>k__BackingField; // 0xC

        // ── Methods ──
        public void get_Initialized(){} // RVA: 0x7FFD5543D680
        public void get_CurrentPlatform(){} // RVA: 0x7FFD5543D6E0
        public void set_CurrentPlatform(){} // RVA: 0x7FFD5543D740
        public void Initialize(){} // RVA: 0x7FFD5543D7A0
        public void InitializeRuntime(){} // RVA: 0x7FFD5543DBB0
        public void .cctor(){} // RVA: 0x7FFD5543DC00
    }

    public class UnitySerializationUtility : Object
    {
        public System.Type SerializeReferenceAttributeType;
        public System.Reflection.Assembly String_Assembly; // 0x8
        public System.Reflection.Assembly HashSet_Assembly; // 0x10
        public System.Reflection.Assembly LinkedList_Assembly; // 0x18
        public System.Collections.Generic.Dictionary`2<System.Reflection.MemberInfo,0x66586C98> UnityMemberGetters; // 0x20
        public System.Collections.Generic.Dictionary`2<System.Reflection.MemberInfo,0x66586CF0> UnityMemberSetters; // 0x28
        public System.Collections.Generic.Dictionary`2<System.Reflection.MemberInfo,bool> UnityWillSerializeMembersCache; // 0x30
        public System.Collections.Generic.Dictionary`2<System.Type,bool> UnityWillSerializeTypesCache; // 0x38
        public System.Collections.Generic.HashSet`1<System.Type> UnityNeverSerializesTypes; // 0x40
        public System.Collections.Generic.HashSet`1<string> UnityNeverSerializesTypeNames; // 0x48
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy UnityPolicy; // 0x50
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy EverythingPolicy; // 0x58
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy StrictPolicy; // 0x60
        public System.Collections.Generic.Dictionary`2<System.Reflection.MemberInfo,0x66586140> OdinWillSerializeCache_UnityPolicy; // 0x68
        public System.Collections.Generic.Dictionary`2<System.Reflection.MemberInfo,0x66586140> OdinWillSerializeCache_EverythingPolicy; // 0x70
        public System.Collections.Generic.Dictionary`2<System.Reflection.MemberInfo,0x66586140> OdinWillSerializeCache_StrictPolicy; // 0x78
        public System.Collections.Generic.Dictionary`2<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,System.Collections.Generic.Dictionary`2<System.Reflection.MemberInfo,0x66586140>> OdinWillSerializeCache_CustomPolicies; // 0x80

        // ── Methods ──
        public void OdinWillSerialize(){} // RVA: 0x7FFD5543DCC0
        public void CalculateOdinWillSerialize(){} // RVA: 0x7FFD5543E540
        public void GuessIfUnityWillSerialize(){} // RVA: 0x7FFD5543EEB0 | overloaded x2
        public void GuessIfUnityWillSerializePrivate(){} // RVA: 0x7FFD5543F200 | overloaded x2
        public void SerializeUnityObject(){} // RVA: 0x7FFD554410E0 | overloaded x4
        public void DeserializeUnityObject(){} // RVA: 0x7FFD554434D0 | overloaded x5
        public void SerializePrefabModifications(){} // RVA: 0x7FFD55444160
        public void GetStringFromStreamAndReset(){} // RVA: 0x7FFD55444DD0
        public void DeserializePrefabModifications(){} // RVA: 0x7FFD55444EE0
        public void CreateDefaultUnityInitializedObject(){} // RVA: 0x7FFD554463F0 | overloaded x2
        public void ApplyPrefabModifications(){} // RVA: 0x7FFD55446B70
        public void GetCachedUnityMemberGetter(){} // RVA: 0x7FFD55446E50
        public void GetCachedUnityMemberSetter(){} // RVA: 0x7FFD554473A0
        public void GetCachedUnityWriter(){} // RVA: 0x7FFD554478F0
        public void GetCachedUnityReader(){} // RVA: 0x7FFD55447B20
        public void .cctor(){} // RVA: 0x7FFD55447D50
    }

}