// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 7
// Methods: 42

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class UInt16Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AF662490
        public void WriteValue(){} // RVA: 0x7AF663190
        public void .ctor(){} // RVA: 0x7AF663200
    }

    public class UInt32Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AF663270
        public void WriteValue(){} // RVA: 0x7AF663F70
        public void .ctor(){} // RVA: 0x7AF663FE0
    }

    public class UInt64Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AF664050
        public void WriteValue(){} // RVA: 0x7AF664D40
        public void .ctor(){} // RVA: 0x7AF664DB0
    }

    public class UIntPtrSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AF664E20
        public void WriteValue(){} // RVA: 0x7AF665B10
        public void .ctor(){} // RVA: 0x7AF665B80
    }

    public class UnityReferenceResolver : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF671D10
        public void GetReferencedUnityObjects(){} // RVA: 0x7A80DA7B0
        public void SetReferencedUnityObjects(){} // RVA: 0x7AF671EC0
        public void CanReference(){} // RVA: 0x7AF672110
        public void TryResolveReference(){} // RVA: 0x7AF672390
        public void Reset(){} // RVA: 0x7AF6724A0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7AF6724A0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7A80D7310
    }

    public class UnitySerializationInitializer : Object
    {
        // ── Methods ──
        public void get_Initialized(){} // RVA: 0x7AF672550
        public void get_CurrentPlatform(){} // RVA: 0x7AF6725B0
        public void set_CurrentPlatform(){} // RVA: 0x7AF672610
        public void Initialize(){} // RVA: 0x7AF672670
        public void InitializeRuntime(){} // RVA: 0x7AF672A50
        public void .cctor(){} // RVA: 0x7AF672AA0
    }

    public class UnitySerializationUtility : Object
    {
        // ── Methods ──
        public void OdinWillSerialize(){} // RVA: 0x7AF672B60
        public void CalculateOdinWillSerialize(){} // RVA: 0x7AF673390
        public void GuessIfUnityWillSerialize(){} // RVA: 0x7AF673CA0
        public void GuessIfUnityWillSerializePrivate(){} // RVA: 0x7AF673FB0
        public void SerializeUnityObject(){} // RVA: 0x7AF675E70
        public void DeserializeUnityObject(){} // RVA: 0x7AF678280
        public void SerializePrefabModifications(){} // RVA: 0x7AF678EF0
        public void GetStringFromStreamAndReset(){} // RVA: 0x7AF679B50
        public void DeserializePrefabModifications(){} // RVA: 0x7AF679C60
        public void CreateDefaultUnityInitializedObject(){} // RVA: 0x7AF67B150
        public void ApplyPrefabModifications(){} // RVA: 0x7AF67B8D0
        public void GetCachedUnityMemberGetter(){} // RVA: 0x7AF67BBB0
        public void GetCachedUnityMemberSetter(){} // RVA: 0x7AF67C0E0
        public void GetCachedUnityWriter(){} // RVA: 0x7AF67C610
        public void GetCachedUnityReader(){} // RVA: 0x7AF67C840
        public void .cctor(){} // RVA: 0x7AF67CA70
    }

}