// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 7
// Methods: 53

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class UInt16Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883C0190
        public void WriteValue(){} // RVA: 0x7FFE883C0E60
        public void .ctor(){} // RVA: 0x7FFE883C0ED0
    }

    public class UInt32Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883C0F40
        public void WriteValue(){} // RVA: 0x7FFE883C1C10
        public void .ctor(){} // RVA: 0x7FFE883C1C80
    }

    public class UInt64Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883C1CF0
        public void WriteValue(){} // RVA: 0x7FFE883C29B0
        public void .ctor(){} // RVA: 0x7FFE883C2A20
    }

    public class UIntPtrSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883C2A90
        public void WriteValue(){} // RVA: 0x7FFE883C3750
        public void .ctor(){} // RVA: 0x7FFE883C37C0
    }

    public class UnityReferenceResolver : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE883CF970 | overloaded x2
        public void GetReferencedUnityObjects(){} // RVA: 0x7FFE810FE7C0
        public void SetReferencedUnityObjects(){} // RVA: 0x7FFE883CFB10
        public void CanReference(){} // RVA: 0x7FFE883CFD50
        public void TryResolveReference(){} // RVA: 0x7FFE883CFFD0
        public void Reset(){} // RVA: 0x7FFE883D00E0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7FFE883D00E0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7FFE810FB310
    }

    public class UnitySerializationInitializer : Object
    {
        public object LOCK;
        public bool initialized; // 0x8

        // ── Methods ──
        public void get_Initialized(){} // RVA: 0x7FFE883D0190
        public void get_CurrentPlatform(){} // RVA: 0x7FFE883D01F0
        public void set_CurrentPlatform(){} // RVA: 0x7FFE883D0250
        public void Initialize(){} // RVA: 0x7FFE883D02B0
        public void InitializeRuntime(){} // RVA: 0x7FFE883D06C0
        public void .cctor(){} // RVA: 0x7FFE883D0710
    }

    public class UnitySerializationUtility : Object
    {
        // ── Methods ──
        public void OdinWillSerialize(){} // RVA: 0x7FFE883D07D0
        public void CalculateOdinWillSerialize(){} // RVA: 0x7FFE883D1050
        public void GuessIfUnityWillSerialize(){} // RVA: 0x7FFE883D19C0 | overloaded x2
        public void GuessIfUnityWillSerializePrivate(){} // RVA: 0x7FFE883D1D10 | overloaded x2
        public void SerializeUnityObject(){} // RVA: 0x7FFE883D3BF0 | overloaded x4
        public void DeserializeUnityObject(){} // RVA: 0x7FFE883D5FE0 | overloaded x5
        public void SerializePrefabModifications(){} // RVA: 0x7FFE883D6C70
        public void GetStringFromStreamAndReset(){} // RVA: 0x7FFE883D78E0
        public void DeserializePrefabModifications(){} // RVA: 0x7FFE883D79F0
        public void CreateDefaultUnityInitializedObject(){} // RVA: 0x7FFE883D8F00 | overloaded x2
        public void ApplyPrefabModifications(){} // RVA: 0x7FFE883D9680
        public void GetCachedUnityMemberGetter(){} // RVA: 0x7FFE883D9960
        public void GetCachedUnityMemberSetter(){} // RVA: 0x7FFE883D9EB0
        public void GetCachedUnityWriter(){} // RVA: 0x7FFE883DA400
        public void GetCachedUnityReader(){} // RVA: 0x7FFE883DA630
        public void .cctor(){} // RVA: 0x7FFE883DA860
    }

}