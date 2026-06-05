// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 7
// Methods: 53

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class UInt16Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAFA3334D0
        public void WriteValue(){} // RVA: 0x7FFAFA3341A0
        public void .ctor(){} // RVA: 0x7FFAFA334210
    }

    public class UInt32Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAFA334280
        public void WriteValue(){} // RVA: 0x7FFAFA334F50
        public void .ctor(){} // RVA: 0x7FFAFA334FC0
    }

    public class UInt64Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAFA335030
        public void WriteValue(){} // RVA: 0x7FFAFA335CF0
        public void .ctor(){} // RVA: 0x7FFAFA335D60
    }

    public class UIntPtrSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAFA335DD0
        public void WriteValue(){} // RVA: 0x7FFAFA336A90
        public void .ctor(){} // RVA: 0x7FFAFA336B00
    }

    public class UnityReferenceResolver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA342C90 | overloaded x2
        public void GetReferencedUnityObjects(){} // RVA: 0x7FFAF2D907C0
        public void SetReferencedUnityObjects(){} // RVA: 0x7FFAFA342E30
        public void CanReference(){} // RVA: 0x7FFAFA343070
        public void TryResolveReference(){} // RVA: 0x7FFAFA3432F0
        public void Reset(){} // RVA: 0x7FFAFA343400
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7FFAFA343400
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7FFAF2D8D310
    }

    public class UnitySerializationInitializer
    {
        // ── Methods ──
        public void get_Initialized(){} // RVA: 0x7FFAFA3434B0
        public void get_CurrentPlatform(){} // RVA: 0x7FFAFA343510
        public void set_CurrentPlatform(){} // RVA: 0x7FFAFA343570
        public void Initialize(){} // RVA: 0x7FFAFA3435D0
        public void InitializeRuntime(){} // RVA: 0x7FFAFA3439E0
        public void .cctor(){} // RVA: 0x7FFAFA343A30
    }

    public class UnitySerializationUtility
    {
        // ── Methods ──
        public void OdinWillSerialize(){} // RVA: 0x7FFAFA343AF0
        public void CalculateOdinWillSerialize(){} // RVA: 0x7FFAFA344370
        public void GuessIfUnityWillSerialize(){} // RVA: 0x7FFAFA344CE0 | overloaded x2
        public void GuessIfUnityWillSerializePrivate(){} // RVA: 0x7FFAFA345030 | overloaded x2
        public void SerializeUnityObject(){} // RVA: 0x7FFAFA346F10 | overloaded x4
        public void DeserializeUnityObject(){} // RVA: 0x7FFAFA349300 | overloaded x5
        public void SerializePrefabModifications(){} // RVA: 0x7FFAFA349F90
        public void GetStringFromStreamAndReset(){} // RVA: 0x7FFAFA34AC00
        public void DeserializePrefabModifications(){} // RVA: 0x7FFAFA34AD10
        public void CreateDefaultUnityInitializedObject(){} // RVA: 0x7FFAFA34C220 | overloaded x2
        public void ApplyPrefabModifications(){} // RVA: 0x7FFAFA34C9A0
        public void GetCachedUnityMemberGetter(){} // RVA: 0x7FFAFA34CC80
        public void GetCachedUnityMemberSetter(){} // RVA: 0x7FFAFA34D1D0
        public void GetCachedUnityWriter(){} // RVA: 0x7FFAFA34D720
        public void GetCachedUnityReader(){} // RVA: 0x7FFAFA34D950
        public void .cctor(){} // RVA: 0x7FFAFA34DB80
    }

}