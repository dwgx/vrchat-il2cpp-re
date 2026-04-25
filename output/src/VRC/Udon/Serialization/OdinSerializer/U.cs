// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 7
// Methods: 53

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class UInt16Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA00D680
        public void WriteValue(){} // RVA: 0x7FFACA00E350
        public void .ctor(){} // RVA: 0x7FFACA00E3C0
    }

    public class UInt32Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA00E430
        public void WriteValue(){} // RVA: 0x7FFACA00F100
        public void .ctor(){} // RVA: 0x7FFACA00F170
    }

    public class UInt64Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA00F1E0
        public void WriteValue(){} // RVA: 0x7FFACA00FEA0
        public void .ctor(){} // RVA: 0x7FFACA00FF10
    }

    public class UIntPtrSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA00FF80
        public void WriteValue(){} // RVA: 0x7FFACA010C40
        public void .ctor(){} // RVA: 0x7FFACA010CB0
    }

    public class UnityReferenceResolver : Object
    {
        public System.Collections.Generic.Dictionary`2<UnityEngine.Object,int> referenceIndexMapping; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.Object> referencedUnityObjects; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACA01CE60 | overloaded x2
        public void GetReferencedUnityObjects(){} // RVA: 0x7FFAC2F247C0
        public void SetReferencedUnityObjects(){} // RVA: 0x7FFACA01D000
        public void CanReference(){} // RVA: 0x7FFACA01D240
        public void TryResolveReference(){} // RVA: 0x7FFACA01D4C0
        public void Reset(){} // RVA: 0x7FFACA01D5D0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7FFACA01D5D0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7FFAC2F21310
    }

    public class UnitySerializationInitializer : Object
    {
        public object Initialized;
        public bool CurrentPlatform; // 0x8
        public 0x6B179580 <CurrentPlatform>k__BackingField; // 0xC

        // ── Methods ──
        public void get_Initialized(){} // RVA: 0x7FFACA01D680
        public void get_CurrentPlatform(){} // RVA: 0x7FFACA01D6E0
        public void set_CurrentPlatform(){} // RVA: 0x7FFACA01D740
        public void Initialize(){} // RVA: 0x7FFACA01D7A0
        public void InitializeRuntime(){} // RVA: 0x7FFACA01DBB0
        public void .cctor(){} // RVA: 0x7FFACA01DC00
    }

    public class UnitySerializationUtility : Object
    {
        public System.Type SerializeReferenceAttributeType;
        public System.Reflection.Assembly String_Assembly; // 0x8
        public System.Reflection.Assembly HashSet_Assembly; // 0x10
        public System.Reflection.Assembly LinkedList_Assembly; // 0x18
        public System.Collections.Generic.Dictionary`2<System.Reflection.MemberInfo,VRC.Udon.Serialization.OdinSerializer.Utilities.WeakValueGetter> UnityMemberGetters; // 0x20
        public System.Collections.Generic.Dictionary`2<System.Reflection.MemberInfo,VRC.Udon.Serialization.OdinSerializer.Utilities.WeakValueSetter> UnityMemberSetters; // 0x28
        public System.Collections.Generic.Dictionary`2<System.Reflection.MemberInfo,bool> UnityWillSerializeMembersCache; // 0x30
        public System.Collections.Generic.Dictionary`2<System.Type,bool> UnityWillSerializeTypesCache; // 0x38
        public System.Collections.Generic.HashSet`1<System.Type> UnityNeverSerializesTypes; // 0x40
        public System.Collections.Generic.HashSet`1<string> UnityNeverSerializesTypeNames; // 0x48
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy UnityPolicy; // 0x50
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy EverythingPolicy; // 0x58
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy StrictPolicy; // 0x60
        public System.Collections.Generic.Dictionary`2<System.Reflection.MemberInfo,CachedSerializationBackendResult> OdinWillSerializeCache_UnityPolicy; // 0x68
        public System.Collections.Generic.Dictionary`2<System.Reflection.MemberInfo,CachedSerializationBackendResult> OdinWillSerializeCache_EverythingPolicy; // 0x70
        public System.Collections.Generic.Dictionary`2<System.Reflection.MemberInfo,CachedSerializationBackendResult> OdinWillSerializeCache_StrictPolicy; // 0x78
        public System.Collections.Generic.Dictionary`2<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,System.Collections.Generic.Dictionary`2<System.Reflection.MemberInfo,CachedSerializationBackendResult>> OdinWillSerializeCache_CustomPolicies; // 0x80

        // ── Methods ──
        public void OdinWillSerialize(){} // RVA: 0x7FFACA01DCC0
        public void CalculateOdinWillSerialize(){} // RVA: 0x7FFACA01E540
        public void GuessIfUnityWillSerialize(){} // RVA: 0x7FFACA01EEB0 | overloaded x2
        public void GuessIfUnityWillSerializePrivate(){} // RVA: 0x7FFACA01F200 | overloaded x2
        public void SerializeUnityObject(){} // RVA: 0x7FFACA0210E0 | overloaded x4
        public void DeserializeUnityObject(){} // RVA: 0x7FFACA0234D0 | overloaded x5
        public void SerializePrefabModifications(){} // RVA: 0x7FFACA024160
        public void GetStringFromStreamAndReset(){} // RVA: 0x7FFACA024DD0
        public void DeserializePrefabModifications(){} // RVA: 0x7FFACA024EE0
        public void CreateDefaultUnityInitializedObject(){} // RVA: 0x7FFACA0263F0 | overloaded x2
        public void ApplyPrefabModifications(){} // RVA: 0x7FFACA026B70
        public void GetCachedUnityMemberGetter(){} // RVA: 0x7FFACA026E50
        public void GetCachedUnityMemberSetter(){} // RVA: 0x7FFACA0273A0
        public void GetCachedUnityWriter(){} // RVA: 0x7FFACA0278F0
        public void GetCachedUnityReader(){} // RVA: 0x7FFACA027B20
        public void .cctor(){} // RVA: 0x7FFACA027D50
    }

}