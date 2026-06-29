// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 33
// Methods: 246

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class WorldMetadata : ValueType
    {
        // ── Methods ──
        public void CompareHash(){} // RVA: 0x7A7F15C40
        public void ComputeHash(){} // RVA: 0x7A7F15DC0
        public void CollateObjectMetadata(){} // RVA: 0x7A7F15DD0
        public void AreCompatible(){} // RVA: 0x7A7F15E00
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsWorldMetadata(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Hash(){} // RVA: 0x7A7F15E20
        public void get_PlayerPersistenceGuid(){} // RVA: 0x7A7F15E50
        public void PlayerPersistenceMetadatas(){} // RVA: 0x7A7F15E80
        public void get_PlayerPersistenceMetadatasLength(){} // RVA: 0x7A7F15EB0
        public void ObjectMetadatas(){} // RVA: 0x7A7F15EC0
        public void get_ObjectMetadatasLength(){} // RVA: 0x7A7F15AE0
        public void get_MaximumViewIDs(){} // RVA: 0x7A7F15EF0
        public void get_MinimumViewID(){} // RVA: 0x7A7F15F40
        public void get_FirstPlayerPersistenceID(){} // RVA: 0x7A7F15F90
        public void get_MaxPlayerPersistenceID(){} // RVA: 0x7A7F15FE0
        public void NetworkCallingViews(){} // RVA: 0x7A7F16030
        public void get_NetworkCallingViewsLength(){} // RVA: 0x7A7F16060
        public void CreateWorldMetadata(){} // RVA: 0x7AF3E9D00
        public void StartWorldMetadata(){} // RVA: 0x7AF3EA0E0
        public void AddHash(){} // RVA: 0x7AF3EA100
        public void AddPlayerPersistenceGuid(){} // RVA: 0x7AF3EA130
        public void AddPlayerPersistenceMetadatas(){} // RVA: 0x7AF3EA160
        public void CreatePlayerPersistenceMetadatasVector(){} // RVA: 0x7AF3E65E0
        public void CreatePlayerPersistenceMetadatasVectorBlock(){} // RVA: 0x7AF3EA340
        public void StartPlayerPersistenceMetadatasVector(){} // RVA: 0x7AF3E69C0
        public void AddObjectMetadatas(){} // RVA: 0x7AF3E65A0
        public void CreateObjectMetadatasVector(){} // RVA: 0x7AF3E65E0
        public void CreateObjectMetadatasVectorBlock(){} // RVA: 0x7AF3EA5A0
        public void StartObjectMetadatasVector(){} // RVA: 0x7AF3E69C0
        public void AddMaximumViewIDs(){} // RVA: 0x7AF3EA660
        public void AddMinimumViewID(){} // RVA: 0x7AF3EA6D0
        public void AddFirstPlayerPersistenceID(){} // RVA: 0x7AF3EA740
        public void AddMaxPlayerPersistenceID(){} // RVA: 0x7AF3EA7B0
        public void AddNetworkCallingViews(){} // RVA: 0x7AF3EA820
        public void CreateNetworkCallingViewsVector(){} // RVA: 0x7AF3E65E0
        public void CreateNetworkCallingViewsVectorBlock(){} // RVA: 0x7AF3EAAA0
        public void StartNetworkCallingViewsVector(){} // RVA: 0x7AF3E69C0
        public void EndWorldMetadata(){} // RVA: 0x7AF3EAB60
        public void UnPack(){} // RVA: 0x7A7F16070
        public void UnPackTo(){} // RVA: 0x7A7F16080
        public void Pack(){} // RVA: 0x7AF3EB420
    }

    public class WorldMetadataT : Object
    {
        // ── Methods ──
        public void CompareHash(){} // RVA: 0x7AF3EB950
        public void ComputeHash(){} // RVA: 0x7AF3EBB40
        public void CollateObjectMetadata(){} // RVA: 0x7AF3EC080
        public void AreCompatible(){} // RVA: 0x7AF3EC100
        public void get_Hash(){} // RVA: 0x7A80F2570
        public void set_Hash(){} // RVA: 0x7A80D8E20
        public void get_PlayerPersistenceGuid(){} // RVA: 0x7A80DA7B0
        public void set_PlayerPersistenceGuid(){} // RVA: 0x7A813E420
        public void get_PlayerPersistenceMetadatas(){} // RVA: 0x7A81052C0
        public void set_PlayerPersistenceMetadatas(){} // RVA: 0x7A81052D0
        public void get_ObjectMetadatas(){} // RVA: 0x7A8105330
        public void set_ObjectMetadatas(){} // RVA: 0x7A80D8E80
        public void get_MaximumViewIDs(){} // RVA: 0x7A8133100
        public void set_MaximumViewIDs(){} // RVA: 0x7A8133110
        public void get_MinimumViewID(){} // RVA: 0x7A82C2070
        public void set_MinimumViewID(){} // RVA: 0x7A82C0430
        public void get_FirstPlayerPersistenceID(){} // RVA: 0x7A8D863F0
        public void set_FirstPlayerPersistenceID(){} // RVA: 0x7A8D870E0
        public void get_MaxPlayerPersistenceID(){} // RVA: 0x7A864E8D0
        public void set_MaxPlayerPersistenceID(){} // RVA: 0x7A9ABBD00
        public void get_NetworkCallingViews(){} // RVA: 0x7A8154D80
        public void set_NetworkCallingViews(){} // RVA: 0x7A80FF440
        public void .ctor(){} // RVA: 0x7AF3EC460
        public void <AreCompatible>g__MetadataCompatible|3_0(){} // RVA: 0x7AF3EC690
        public void <Hash>k__BackingField(){} // RVA: 0x7B2EA2AC0
    }

    public class WorldMetadataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3F6400
    }

    public class WrappedBool : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_B(){} // RVA: 0x7A7F16410
        public void CreateWrappedBool(){} // RVA: 0x7AF4024B0
        public void UnPack(){} // RVA: 0x7A7F18810
        public void UnPackTo(){} // RVA: 0x7A7F16450
        public void Pack(){} // RVA: 0x7AF4025B0
    }

    public class WrappedBoolT : Object
    {
        // ── Methods ──
        public void get_B(){} // RVA: 0x7A81A2200
        public void set_B(){} // RVA: 0x7A81A2210
        public void .ctor(){} // RVA: 0x7A847A460
    }

    public class WrappedByte : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_B(){} // RVA: 0x7A7F17200
        public void CreateWrappedByte(){} // RVA: 0x7AF402660
        public void UnPack(){} // RVA: 0x7A7F18840
        public void UnPackTo(){} // RVA: 0x7A7F18850
        public void Pack(){} // RVA: 0x7AF4027A0
    }

    public class WrappedByteT : Object
    {
        // ── Methods ──
        public void get_B(){} // RVA: 0x7A81A2200
        public void set_B(){} // RVA: 0x7A81A2210
        public void .ctor(){} // RVA: 0x7A847A460
    }

    public class WrappedBytes : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsWrappedBytes(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void B(){} // RVA: 0x7A7F166E0
        public void get_BLength(){} // RVA: 0x7A7F166F0
        public void GetBBytes(){} // RVA: 0x7A7F188E0
        public void GetBArray(){} // RVA: 0x7A7F18950
        public void CreateWrappedBytes(){} // RVA: 0x7AF402AC0
        public void StartWrappedBytes(){} // RVA: 0x7AF3EDBF0
        public void AddB(){} // RVA: 0x7AF3EDC10
        public void CreateBVector(){} // RVA: 0x7AF3EE180
        public void CreateBVectorBlock(){} // RVA: 0x7AF402CE0
        public void StartBVector(){} // RVA: 0x7AF3EE4F0
        public void EndWrappedBytes(){} // RVA: 0x7AF402DA0
        public void UnPack(){} // RVA: 0x7A7F189A0
        public void UnPackTo(){} // RVA: 0x7A7F189B0
        public void Pack(){} // RVA: 0x7AF4030B0
    }

    public class WrappedBytesT : Object
    {
        // ── Methods ──
        public void get_B(){} // RVA: 0x7A80F2570
        public void set_B(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AD51EC30
    }

    public class WrappedBytesVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3EEA00
    }

    public class WrappedDouble : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_D(){} // RVA: 0x7A7F18770
        public void CreateWrappedDouble(){} // RVA: 0x7AF4022D0
        public void UnPack(){} // RVA: 0x7A7F187A0
        public void UnPackTo(){} // RVA: 0x7A7F187B0
        public void Pack(){} // RVA: 0x7AF402420
    }

    public class WrappedDoubleT : Object
    {
        // ── Methods ──
        public void get_D(){} // RVA: 0x7AACD8650
        public void set_D(){} // RVA: 0x7ABEA0730
        public void .ctor(){} // RVA: 0x7A8DF9080
    }

    public class WrappedFloat : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_F(){} // RVA: 0x7A7F16510
        public void CreateWrappedFloat(){} // RVA: 0x7AF402110
        public void UnPack(){} // RVA: 0x7A7F18740
        public void UnPackTo(){} // RVA: 0x7A7F16550
        public void Pack(){} // RVA: 0x7AF402210
    }

    public class WrappedFloatT : Object
    {
        // ── Methods ──
        public void get_F(){} // RVA: 0x7A82023C0
        public void set_F(){} // RVA: 0x7A82023D0
        public void .ctor(){} // RVA: 0x7A881ACE0
    }

    public class WrappedInt : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_I(){} // RVA: 0x7A7F16490
        public void CreateWrappedInt(){} // RVA: 0x7AF401DB0
        public void UnPack(){} // RVA: 0x7A7F186E0
        public void UnPackTo(){} // RVA: 0x7A7F164D0
        public void Pack(){} // RVA: 0x7AF401EB0
    }

    public class WrappedIntT : Object
    {
        // ── Methods ──
        public void get_I(){} // RVA: 0x7A8124910
        public void set_I(){} // RVA: 0x7A80DA0C0
        public void .ctor(){} // RVA: 0x7A881ACE0
    }

    public class WrappedLong : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsWrappedLong(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_L(){} // RVA: 0x7A7F18410
        public void CreateWrappedLong(){} // RVA: 0x7AF401060
        public void StartWrappedLong(){} // RVA: 0x7AF3EDBF0
        public void AddL(){} // RVA: 0x7AF401110
        public void EndWrappedLong(){} // RVA: 0x7AF401180
        public void UnPack(){} // RVA: 0x7A7F18460
        public void UnPackTo(){} // RVA: 0x7A7F18470
        public void Pack(){} // RVA: 0x7AF4012D0
    }

    public class WrappedLongT : Object
    {
        // ── Methods ──
        public void get_L(){} // RVA: 0x7A80F2570
        public void set_L(){} // RVA: 0x7A97242F0
        public void .ctor(){} // RVA: 0x7A8DF9080
    }

    public class WrappedLongVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF401390
    }

    public class WrappedShort : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_S(){} // RVA: 0x7A7F18610
        public void CreateWrappedShort(){} // RVA: 0x7AF401A10
        public void UnPack(){} // RVA: 0x7A7F18640
        public void UnPackTo(){} // RVA: 0x7A7F18650
        public void Pack(){} // RVA: 0x7AF401B50
    }

    public class WrappedShortT : Object
    {
        // ── Methods ──
        public void get_S(){} // RVA: 0x7A99CD750
        public void set_S(){} // RVA: 0x7A99CDAA0
        public void .ctor(){} // RVA: 0x7A9B764C0
    }

    public class WrappedString : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsWrappedString(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_S(){} // RVA: 0x7A7F16590
        public void GetSBytes(){} // RVA: 0x7A7F18520
        public void GetSArray(){} // RVA: 0x7A7F18590
        public void CreateWrappedString(){} // RVA: 0x7AF401740
        public void StartWrappedString(){} // RVA: 0x7AF3EDBF0
        public void AddS(){} // RVA: 0x7AF3EDC10
        public void EndWrappedString(){} // RVA: 0x7AF4017C0
        public void UnPack(){} // RVA: 0x7A7F185E0
        public void UnPackTo(){} // RVA: 0x7A7F16670
        public void Pack(){} // RVA: 0x7AF401920
    }

    public class WrappedStringT : Object
    {
        // ── Methods ──
        public void get_S(){} // RVA: 0x7A80F2570
        public void set_S(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AD51EC30
    }

    public class WrappedStringVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3EDEE0
    }

    public class WrappedUByte : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_U(){} // RVA: 0x7A7F17200
        public void CreateWrappedUByte(){} // RVA: 0x7AF402850
        public void UnPack(){} // RVA: 0x7A7F188B0
        public void UnPackTo(){} // RVA: 0x7A7F18850
        public void Pack(){} // RVA: 0x7AF402950
    }

    public class WrappedUByteT : Object
    {
        // ── Methods ──
        public void get_U(){} // RVA: 0x7A81A2200
        public void set_U(){} // RVA: 0x7A81A2210
        public void .ctor(){} // RVA: 0x7A847A460
    }

    public class WrappedUInt : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_U(){} // RVA: 0x7A7F16490
        public void CreateWrappedUInt(){} // RVA: 0x7AF401F60
        public void UnPack(){} // RVA: 0x7A7F18710
        public void UnPackTo(){} // RVA: 0x7A7F164D0
        public void Pack(){} // RVA: 0x7AF402060
    }

    public class WrappedUIntT : Object
    {
        // ── Methods ──
        public void get_U(){} // RVA: 0x7A8124910
        public void set_U(){} // RVA: 0x7A80DA0C0
        public void .ctor(){} // RVA: 0x7A881ACE0
    }

    public class WrappedULong : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsWrappedULong(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_U(){} // RVA: 0x7A7F18410
        public void CreateWrappedULong(){} // RVA: 0x7AF401420
        public void StartWrappedULong(){} // RVA: 0x7AF3EDBF0
        public void AddU(){} // RVA: 0x7AF401110
        public void EndWrappedULong(){} // RVA: 0x7AF4014D0
        public void UnPack(){} // RVA: 0x7A7F184F0
        public void UnPackTo(){} // RVA: 0x7A7F18470
        public void Pack(){} // RVA: 0x7AF4015C0
    }

    public class WrappedULongT : Object
    {
        // ── Methods ──
        public void get_U(){} // RVA: 0x7A80F2570
        public void set_U(){} // RVA: 0x7A97242F0
        public void .ctor(){} // RVA: 0x7A8DF9080
    }

    public class WrappedULongVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF401390
    }

    public class WrappedUShort : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_U(){} // RVA: 0x7A7F18610
        public void CreateWrappedUShort(){} // RVA: 0x7AF401C00
        public void UnPack(){} // RVA: 0x7A7F186B0
        public void UnPackTo(){} // RVA: 0x7A7F18650
        public void Pack(){} // RVA: 0x7AF401D00
    }

    public class WrappedUShortT : Object
    {
        // ── Methods ──
        public void get_U(){} // RVA: 0x7A99CD750
        public void set_U(){} // RVA: 0x7A99CDAA0
        public void .ctor(){} // RVA: 0x7A9B764C0
    }

}