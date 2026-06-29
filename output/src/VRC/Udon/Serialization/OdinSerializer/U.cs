// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 7
// Methods: 42

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class UInt16Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84BEF70
        public void WriteValue(){} // RVA: 0x84BFBE0
        public void .ctor(){} // RVA: 0x84BFC50
    }

    public class UInt32Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84BFCC0
        public void WriteValue(){} // RVA: 0x84C0930
        public void .ctor(){} // RVA: 0x84C09A0
    }

    public class UInt64Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84C0A10
        public void WriteValue(){} // RVA: 0x84C1680
        public void .ctor(){} // RVA: 0x84C16F0
    }

    public class UIntPtrSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84C1760
        public void WriteValue(){} // RVA: 0x84C23D0
        public void .ctor(){} // RVA: 0x84C2440
    }

    public class UnityReferenceResolver : Object
    {
        public object referenceIndexMapping;
        public object referencedUnityObjects;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x84CDE20
        public void GetReferencedUnityObjects(){} // RVA: 0xB465B0
        public void SetReferencedUnityObjects(){} // RVA: 0x84CDFD0
        public void CanReference(){} // RVA: 0x84CE220
        public void TryResolveReference(){} // RVA: 0x84CE4A0
        public void Reset(){} // RVA: 0x84CE5B0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x84CE5B0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0xB43310
    }

    public class UnitySerializationInitializer : Object
    {
        public object LOCK;
        public object initialized;
        public object _currentPlatform;

        // ── Methods ──
        public void get_Initialized(){} // RVA: 0x84CE660
        public void get_CurrentPlatform(){} // RVA: 0x84CE6C0
        public void set_CurrentPlatform(){} // RVA: 0x84CE720
        public void Initialize(){} // RVA: 0x84CE780
        public void InitializeRuntime(){} // RVA: 0x84CEB60
        public void .cctor(){} // RVA: 0x84CEBB0
    }

    public class UnitySerializationUtility : Object
    {
        public object SerializeReferenceAttributeType;
        public object String_Assembly;
        public object HashSet_Assembly;
        public object LinkedList_Assembly;
        public object UnityMemberGetters;
        public object UnityMemberSetters;
        public object UnityWillSerializeMembersCache;
        public object UnityWillSerializeTypesCache;
        public object UnityNeverSerializesTypes;
        public object UnityNeverSerializesTypeNames;
        public object UnityPolicy;
        public object EverythingPolicy;
        public object StrictPolicy;
        public object OdinWillSerializeCache_UnityPolicy;
        public object OdinWillSerializeCache_EverythingPolicy;
        public object OdinWillSerializeCache_StrictPolicy;
        public object OdinWillSerializeCache_CustomPolicies;

        // ── Methods ──
        public void OdinWillSerialize(){} // RVA: 0x84CEC70
        public void CalculateOdinWillSerialize(){} // RVA: 0x84CF4A0
        public void GuessIfUnityWillSerialize(){} // RVA: 0x84CFD50
        public void GuessIfUnityWillSerializePrivate(){} // RVA: 0x84D0050
        public void SerializeUnityObject(){} // RVA: 0x84D1E80
        public void DeserializeUnityObject(){} // RVA: 0x84D4270
        public void SerializePrefabModifications(){} // RVA: 0x84D4EE0
        public void GetStringFromStreamAndReset(){} // RVA: 0x84D5B40
        public void DeserializePrefabModifications(){} // RVA: 0x84D5C50
        public void CreateDefaultUnityInitializedObject(){} // RVA: 0x84D7120
        public void ApplyPrefabModifications(){} // RVA: 0x84D7880
        public void GetCachedUnityMemberGetter(){} // RVA: 0x84D7B60
        public void GetCachedUnityMemberSetter(){} // RVA: 0x84D8090
        public void GetCachedUnityWriter(){} // RVA: 0x84D85C0
        public void GetCachedUnityReader(){} // RVA: 0x84D87F0
        public void .cctor(){} // RVA: 0x84D8A20
    }

}