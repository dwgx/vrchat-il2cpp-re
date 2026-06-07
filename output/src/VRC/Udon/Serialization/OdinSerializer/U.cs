// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 7
// Methods: 53

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class UInt16Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x78834D0
        public void WriteValue(){} // RVA: 0x78841A0
        public void .ctor(){} // RVA: 0x7884210
    }

    public class UInt32Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7884280
        public void WriteValue(){} // RVA: 0x7884F50
        public void .ctor(){} // RVA: 0x7884FC0
    }

    public class UInt64Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7885030
        public void WriteValue(){} // RVA: 0x7885CF0
        public void .ctor(){} // RVA: 0x7885D60
    }

    public class UIntPtrSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7885DD0
        public void WriteValue(){} // RVA: 0x7886A90
        public void .ctor(){} // RVA: 0x7886B00
    }

    public class UnityReferenceResolver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7892C90 | overloaded x2
        public void GetReferencedUnityObjects(){} // RVA: 0x2E07C0
        public void SetReferencedUnityObjects(){} // RVA: 0x7892E30
        public void CanReference(){} // RVA: 0x7893070
        public void TryResolveReference(){} // RVA: 0x78932F0
        public void Reset(){} // RVA: 0x7893400
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7893400
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x2DD310
    }

    public class UnitySerializationInitializer
    {
        // ── Methods ──
        public void get_Initialized(){} // RVA: 0x78934B0
        public void get_CurrentPlatform(){} // RVA: 0x7893510
        public void set_CurrentPlatform(){} // RVA: 0x7893570
        public void Initialize(){} // RVA: 0x78935D0
        public void InitializeRuntime(){} // RVA: 0x78939E0
        public void .cctor(){} // RVA: 0x7893A30
    }

    public class UnitySerializationUtility
    {
        // ── Methods ──
        public void OdinWillSerialize(){} // RVA: 0x7893AF0
        public void CalculateOdinWillSerialize(){} // RVA: 0x7894370
        public void GuessIfUnityWillSerialize(){} // RVA: 0x7894CE0 | overloaded x2
        public void GuessIfUnityWillSerializePrivate(){} // RVA: 0x7895030 | overloaded x2
        public void SerializeUnityObject(){} // RVA: 0x7896F10 | overloaded x4
        public void DeserializeUnityObject(){} // RVA: 0x7899300 | overloaded x5
        public void SerializePrefabModifications(){} // RVA: 0x7899F90
        public void GetStringFromStreamAndReset(){} // RVA: 0x789AC00
        public void DeserializePrefabModifications(){} // RVA: 0x789AD10
        public void CreateDefaultUnityInitializedObject(){} // RVA: 0x789C220 | overloaded x2
        public void ApplyPrefabModifications(){} // RVA: 0x789C9A0
        public void GetCachedUnityMemberGetter(){} // RVA: 0x789CC80
        public void GetCachedUnityMemberSetter(){} // RVA: 0x789D1D0
        public void GetCachedUnityWriter(){} // RVA: 0x789D720
        public void GetCachedUnityReader(){} // RVA: 0x789D950
        public void .cctor(){} // RVA: 0x789DB80
    }

}