// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 7
// Methods: 53

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class UInt16Serializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa300a0
        public void WriteValue(){} // RVA: 0x7ffaafa30d70
        public void .ctor(){} // RVA: 0x7ffaafa30de0
    }

    public class UInt32Serializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa30e50
        public void WriteValue(){} // RVA: 0x7ffaafa31b20
        public void .ctor(){} // RVA: 0x7ffaafa31b90
    }

    public class UInt64Serializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa31c00
        public void WriteValue(){} // RVA: 0x7ffaafa328c0
        public void .ctor(){} // RVA: 0x7ffaafa32930
    }

    public class UIntPtrSerializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa329a0
        public void WriteValue(){} // RVA: 0x7ffaafa33660
        public void .ctor(){} // RVA: 0x7ffaafa336d0
    }

    public class UnityReferenceResolver : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaafa3f880
        public void .ctor(){} // RVA: 0x7ffaafa3f880
        public void CanReference(){} // RVA: 0x7ffaafa3fc60
        public void TryResolveReference(){} // RVA: 0x7ffaafa3fee0
        public void Reset(){} // RVA: 0x7ffaafa3fff0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7ffaafa3fff0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetReferencedUnityObjects(){} // RVA: 0x7ffaa89357c0
        public void SetReferencedUnityObjects(){} // RVA: 0x7ffaafa3fa20
    }

    public class UnitySerializationInitializer : Object
    {
        public object _currentPlatform; // 0x33CC4B20, was: <CurrentPlatform>k__BackingFie
        public object Initialized; // 0x17000065

        // ── Original Methods ──
        public void get_Initialized(){} // RVA: 0x7ffaafa400a0
        public void get_CurrentPlatform(){} // RVA: 0x7ffaafa40100
        public void set_CurrentPlatform(){} // RVA: 0x7ffaafa40160
        public void Initialize(){} // RVA: 0x7ffaafa401c0
        public void InitializeRuntime(){} // RVA: 0x7ffaafa405d0
        public void .cctor(){} // RVA: 0x7ffaafa40620
    }

    public class UnitySerializationUtility : Object
    {
        public object HashSet_Assembly; // 0x339BC030
        public object UnityMemberSetters; // 0x339BC030
        public object UnityNeverSerializesTypes; // 0x339BC030
        public object EverythingPolicy; // 0x339BC030
        public object OdinWillSerializeCache_EverythingPolicy; // 0x339BC030
        public object DeAliasField; // 0xB4199B40

        // ── Original Methods ──
        public void OdinWillSerialize(){} // RVA: 0x7ffaafa406e0
        public void CalculateOdinWillSerialize(){} // RVA: 0x7ffaafa40f60
        public void GuessIfUnityWillSerialize(){} // RVA: 0x7ffaafa418d0
        public void GuessIfUnityWillSerializePrivate(){} // RVA: 0x7ffaafa41c20
        public void GuessIfUnityWillSerialize(){} // RVA: 0x7ffaafa418d0
        public void GuessIfUnityWillSerializePrivate(){} // RVA: 0x7ffaafa41c20
        public void SerializeUnityObject(){} // RVA: 0x7ffaafa43b00
        public void SerializeUnityObject(){} // RVA: 0x7ffaafa43b00
        public void SerializeUnityObject(){} // RVA: 0x7ffaafa43b00
        public void SerializeUnityObject(){} // RVA: 0x7ffaafa43b00
        public void DeserializeUnityObject(){} // RVA: 0x7ffaafa45ef0
        public void DeserializeUnityObject(){} // RVA: 0x7ffaafa45ef0
        public void DeserializeUnityObject(){} // RVA: 0x7ffaafa45ef0
        public void DeserializeUnityObject(){} // RVA: 0x7ffaafa45ef0
        public void DeserializeUnityObject(){} // RVA: 0x7ffaafa45ef0
        public void SerializePrefabModifications(){} // RVA: 0x7ffaafa46b80
        public void DeserializePrefabModifications(){} // RVA: 0x7ffaafa47900
        public void CreateDefaultUnityInitializedObject(){} // RVA: 0x7ffaafa48e10
        public void CreateDefaultUnityInitializedObject(){} // RVA: 0x7ffaafa48e10
        public void ApplyPrefabModifications(){} // RVA: 0x7ffaafa49590
        public void .cctor(){} // RVA: 0x7ffaafa4a770
        // ── Binary Analysis Named ──
        public void GetStringFromStreamAndReset(){} // RVA: 0x7ffaafa477f0
        public void GetCachedUnityMemberGetter(){} // RVA: 0x7ffaafa49870
        public void GetCachedUnityMemberSetter(){} // RVA: 0x7ffaafa49dc0
        public void GetCachedUnityWriter(){} // RVA: 0x7ffaafa4a310
        public void GetCachedUnityReader(){} // RVA: 0x7ffaafa4a540
    }

}