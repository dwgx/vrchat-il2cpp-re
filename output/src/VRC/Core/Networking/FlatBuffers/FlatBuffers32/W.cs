// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 33
// Methods: 274

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class WorldMetadata : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void CompareHash(){} // RVA: 0x7FFAC9DA0D70
        public void ComputeHash(){} // RVA: 0x7FFAC9DA0EE0
        public void CollateObjectMetadata(){} // RVA: 0x7FFAC9DA1320
        public void AreCompatible(){} // RVA: 0x7FFAC9DA14C0
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsWorldMetadata(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Hash(){} // RVA: 0x7FFAC9DA1840
        public void get_PlayerPersistenceGuid(){} // RVA: 0x7FFAC9DA1950
        public void PlayerPersistenceMetadatas(){} // RVA: 0x7FFAC9DA1A60
        public void get_PlayerPersistenceMetadatasLength(){} // RVA: 0x7FFAC9DA1BD0
        public void ObjectMetadatas(){} // RVA: 0x7FFAC9DA1C40
        public void get_ObjectMetadatasLength(){} // RVA: 0x7FFAC9D9CF70
        public void get_MaximumViewIDs(){} // RVA: 0x7FFAC9DA1DB0
        public void MutateMaximumViewIDs(){} // RVA: 0x7FFAC9DA1E00
        public void get_MinimumViewID(){} // RVA: 0x7FFAC9DA1E60
        public void MutateMinimumViewID(){} // RVA: 0x7FFAC9DA1EB0
        public void get_FirstPlayerPersistenceID(){} // RVA: 0x7FFAC9DA1F10
        public void MutateFirstPlayerPersistenceID(){} // RVA: 0x7FFAC9DA1F60
        public void get_MaxPlayerPersistenceID(){} // RVA: 0x7FFAC9DA1FC0
        public void MutateMaxPlayerPersistenceID(){} // RVA: 0x7FFAC9DA2010
        public void NetworkCallingViews(){} // RVA: 0x7FFAC9DA2070
        public void get_NetworkCallingViewsLength(){} // RVA: 0x7FFAC9DA21E0
        public void CreateWorldMetadata(){} // RVA: 0x7FFAC9DA2250
        public void StartWorldMetadata(){} // RVA: 0x7FFAC9DA2620
        public void AddHash(){} // RVA: 0x7FFAC9DA2640
        public void AddPlayerPersistenceGuid(){} // RVA: 0x7FFAC9DA2670
        public void AddPlayerPersistenceMetadatas(){} // RVA: 0x7FFAC9DA26A0
        public void CreatePlayerPersistenceMetadatasVector(){} // RVA: 0x7FFAC9D9D690
        public void CreatePlayerPersistenceMetadatasVectorBlock(){} // RVA: 0x7FFAC9DA2880 | overloaded x3
        public void StartPlayerPersistenceMetadatasVector(){} // RVA: 0x7FFAC9D9DA50
        public void AddObjectMetadatas(){} // RVA: 0x7FFAC9D9D650
        public void CreateObjectMetadatasVector(){} // RVA: 0x7FFAC9D9D690
        public void CreateObjectMetadatasVectorBlock(){} // RVA: 0x7FFAC9DA2AE0 | overloaded x3
        public void StartObjectMetadatasVector(){} // RVA: 0x7FFAC9D9DA50
        public void AddMaximumViewIDs(){} // RVA: 0x7FFAC9DA2BA0
        public void AddMinimumViewID(){} // RVA: 0x7FFAC9DA2C10
        public void AddFirstPlayerPersistenceID(){} // RVA: 0x7FFAC9DA2C80
        public void AddMaxPlayerPersistenceID(){} // RVA: 0x7FFAC9DA2CF0
        public void AddNetworkCallingViews(){} // RVA: 0x7FFAC9DA2D60
        public void CreateNetworkCallingViewsVector(){} // RVA: 0x7FFAC9D9D690
        public void CreateNetworkCallingViewsVectorBlock(){} // RVA: 0x7FFAC9DA2FE0 | overloaded x3
        public void StartNetworkCallingViewsVector(){} // RVA: 0x7FFAC9D9DA50
        public void EndWorldMetadata(){} // RVA: 0x7FFAC9DA30A0
        public void UnPack(){} // RVA: 0x7FFAC9DA30F0
        public void UnPackTo(){} // RVA: 0x7FFAC9DA3160
        public void Pack(){} // RVA: 0x7FFAC9DA3970
    }

    public class WorldMetadataT : Object
    {
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.SHA256T Hash; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.GuidT PlayerPersistenceGuid; // 0x18
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataPairT> PlayerPersistenceMetadatas; // 0x20
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataPairT> ObjectMetadatas; // 0x28
        public int MaximumViewIDs; // 0x30
        public int MinimumViewID; // 0x34
        public int FirstPlayerPersistenceID; // 0x38
        public int MaxPlayerPersistenceID; // 0x3C
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.NetworkCallingViewT> NetworkCallingViews; // 0x40

        // ── Methods ──
        public void CompareHash(){} // RVA: 0x7FFAC9DA3E10
        public void ComputeHash(){} // RVA: 0x7FFAC9DA4000
        public void CollateObjectMetadata(){} // RVA: 0x7FFAC9DA4560
        public void AreCompatible(){} // RVA: 0x7FFAC9DA45E0
        public void get_Hash(){} // RVA: 0x7FFAC2F3C380
        public void set_Hash(){} // RVA: 0x7FFAC2F22E30
        public void get_PlayerPersistenceGuid(){} // RVA: 0x7FFAC2F247C0
        public void set_PlayerPersistenceGuid(){} // RVA: 0x7FFAC2F87E80
        public void get_PlayerPersistenceMetadatas(){} // RVA: 0x7FFAC2F4F0C0
        public void set_PlayerPersistenceMetadatas(){} // RVA: 0x7FFAC2F4F0D0
        public void get_ObjectMetadatas(){} // RVA: 0x7FFAC2F4F130
        public void set_ObjectMetadatas(){} // RVA: 0x7FFAC2F22E90
        public void get_MaximumViewIDs(){} // RVA: 0x7FFAC2F7CCD0
        public void set_MaximumViewIDs(){} // RVA: 0x7FFAC2F7CCE0
        public void get_MinimumViewID(){} // RVA: 0x7FFAC3ADEDC0
        public void set_MinimumViewID(){} // RVA: 0x7FFAC416A6E0
        public void get_FirstPlayerPersistenceID(){} // RVA: 0x7FFAC358A870
        public void set_FirstPlayerPersistenceID(){} // RVA: 0x7FFAC3588350
        public void get_MaxPlayerPersistenceID(){} // RVA: 0x7FFAC33BD4A0
        public void set_MaxPlayerPersistenceID(){} // RVA: 0x7FFAC47E2CD0
        public void get_NetworkCallingViews(){} // RVA: 0x7FFAC2F9E740
        public void set_NetworkCallingViews(){} // RVA: 0x7FFAC2F49200
        public void .ctor(){} // RVA: 0x7FFAC9DA4930
        public void <AreCompatible>g__MetadataCompatible|3_0(){} // RVA: 0x7FFAC9DA4B60
    }

    public class WorldMetadataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DAEB20
    }

    public class WrappedBool : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_B(){} // RVA: 0x7FFAC9DA58B0
        public void MutateB(){} // RVA: 0x7FFAC9DA58E0
        public void CreateWrappedBool(){} // RVA: 0x7FFAC9DBAD40
        public void UnPack(){} // RVA: 0x7FFAC9DBADD0
        public void UnPackTo(){} // RVA: 0x7FFAC9DA5A10
        public void Pack(){} // RVA: 0x7FFAC9DBAE40
    }

    public class WrappedBoolT : Object
    {
        public bool B; // 0x10

        // ── Methods ──
        public void get_B(){} // RVA: 0x7FFAC2FEB5E0
        public void set_B(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC322C880
    }

    public class WrappedByte : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_B(){} // RVA: 0x7FFAC9DAF330
        public void MutateB(){} // RVA: 0x7FFAC9DA58E0
        public void CreateWrappedByte(){} // RVA: 0x7FFAC9DBAEF0
        public void UnPack(){} // RVA: 0x7FFAC9DBAF80
        public void UnPackTo(){} // RVA: 0x7FFAC9DBAFF0
        public void Pack(){} // RVA: 0x7FFAC9DBB030
    }

    public class WrappedByteT : Object
    {
        public byte B; // 0x10

        // ── Methods ──
        public void get_B(){} // RVA: 0x7FFAC2FEB5E0
        public void set_B(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC322C880
    }

    public class WrappedBytes : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsWrappedBytes(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void B(){} // RVA: 0x7FFAC9DA64D0
        public void get_BLength(){} // RVA: 0x7FFAC9DA6550
        public void GetBBytes(){} // RVA: 0x7FFAC9DBB290
        public void GetBArray(){} // RVA: 0x7FFAC9DBB300
        public void MutateB(){} // RVA: 0x7FFAC9DA6680
        public void CreateWrappedBytes(){} // RVA: 0x7FFAC9DBB350
        public void StartWrappedBytes(){} // RVA: 0x7FFAC9DA6170
        public void AddB(){} // RVA: 0x7FFAC9DA6190
        public void CreateBVector(){} // RVA: 0x7FFAC9DA6790
        public void CreateBVectorBlock(){} // RVA: 0x7FFAC9DBB570 | overloaded x3
        public void StartBVector(){} // RVA: 0x7FFAC9DA6AE0
        public void EndWrappedBytes(){} // RVA: 0x7FFAC9DBB630
        public void UnPack(){} // RVA: 0x7FFAC9DBB680
        public void UnPackTo(){} // RVA: 0x7FFAC9DBB730
        public void Pack(){} // RVA: 0x7FFAC9DBB940
    }

    public class WrappedBytesT : Object
    {
        public System.Collections.Generic.List`1<byte> B; // 0x10

        // ── Methods ──
        public void get_B(){} // RVA: 0x7FFAC2F3C380
        public void set_B(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class WrappedBytesVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DA6FE0
    }

    public class WrappedDouble : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_D(){} // RVA: 0x7FFAC9DBAAE0
        public void MutateD(){} // RVA: 0x7FFAC9DBAB10
        public void CreateWrappedDouble(){} // RVA: 0x7FFAC9DBAB40
        public void UnPack(){} // RVA: 0x7FFAC9DBABD0
        public void UnPackTo(){} // RVA: 0x7FFAC9DBAC50
        public void Pack(){} // RVA: 0x7FFAC9DBAC90
    }

    public class WrappedDoubleT : Object
    {
        public double D; // 0x10

        // ── Methods ──
        public void get_D(){} // RVA: 0x7FFAC5873C20
        public void set_D(){} // RVA: 0x7FFAC69C0110
        public void .ctor(){} // RVA: 0x7FFAC3B206B0
    }

    public class WrappedFloat : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_F(){} // RVA: 0x7FFAC9DA5D50
        public void MutateF(){} // RVA: 0x7FFAC9DA5D80
        public void CreateWrappedFloat(){} // RVA: 0x7FFAC9DBA930
        public void UnPack(){} // RVA: 0x7FFAC9DBA9C0
        public void UnPackTo(){} // RVA: 0x7FFAC9DA5EB0
        public void Pack(){} // RVA: 0x7FFAC9DBAA30
    }

    public class WrappedFloatT : Object
    {
        public float F; // 0x10

        // ── Methods ──
        public void get_F(){} // RVA: 0x7FFAC304B320
        public void set_F(){} // RVA: 0x7FFAC304B330
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
    }

    public class WrappedInt : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_I(){} // RVA: 0x7FFAC9DA5B00
        public void MutateI(){} // RVA: 0x7FFAC9DA5B30
        public void CreateWrappedInt(){} // RVA: 0x7FFAC9DBA5D0
        public void UnPack(){} // RVA: 0x7FFAC9DBA660
        public void UnPackTo(){} // RVA: 0x7FFAC9DA5C60
        public void Pack(){} // RVA: 0x7FFAC9DBA6D0
    }

    public class WrappedIntT : Object
    {
        public int I; // 0x10

        // ── Methods ──
        public void get_I(){} // RVA: 0x7FFAC2F6E5C0
        public void set_I(){} // RVA: 0x7FFAC2F240C0
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
    }

    public class WrappedLong : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsWrappedLong(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_L(){} // RVA: 0x7FFAC9DB97A0
        public void MutateL(){} // RVA: 0x7FFAC9DB97F0
        public void CreateWrappedLong(){} // RVA: 0x7FFAC9DB9850
        public void StartWrappedLong(){} // RVA: 0x7FFAC9DA6170
        public void AddL(){} // RVA: 0x7FFAC9DB9900
        public void EndWrappedLong(){} // RVA: 0x7FFAC9DB9970
        public void UnPack(){} // RVA: 0x7FFAC9DB99C0
        public void UnPackTo(){} // RVA: 0x7FFAC9DB9A60
        public void Pack(){} // RVA: 0x7FFAC9DB9AC0
    }

    public class WrappedLongT : Object
    {
        public long L; // 0x10

        // ── Methods ──
        public void get_L(){} // RVA: 0x7FFAC2F3C380
        public void set_L(){} // RVA: 0x7FFAC441EFB0
        public void .ctor(){} // RVA: 0x7FFAC3B206B0
    }

    public class WrappedLongVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DB9B80
    }

    public class WrappedShort : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_S(){} // RVA: 0x7FFAC9DBA1D0
        public void MutateS(){} // RVA: 0x7FFAC9DBA200
        public void CreateWrappedShort(){} // RVA: 0x7FFAC9DBA230
        public void UnPack(){} // RVA: 0x7FFAC9DBA2C0
        public void UnPackTo(){} // RVA: 0x7FFAC9DBA330
        public void Pack(){} // RVA: 0x7FFAC9DBA370
    }

    public class WrappedShortT : Object
    {
        public short S; // 0x10

        // ── Methods ──
        public void get_S(){} // RVA: 0x7FFAC469AEC0
        public void set_S(){} // RVA: 0x7FFAC469BCA0
        public void .ctor(){} // RVA: 0x7FFAC489A870
    }

    public class WrappedString : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsWrappedString(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_S(){} // RVA: 0x7FFAC9DA5FA0
        public void GetSBytes(){} // RVA: 0x7FFAC9DB9E70
        public void GetSArray(){} // RVA: 0x7FFAC9DB9EE0
        public void CreateWrappedString(){} // RVA: 0x7FFAC9DB9F30
        public void StartWrappedString(){} // RVA: 0x7FFAC9DA6170
        public void AddS(){} // RVA: 0x7FFAC9DA6190
        public void EndWrappedString(){} // RVA: 0x7FFAC9DB9FB0
        public void UnPack(){} // RVA: 0x7FFAC9DBA000
        public void UnPackTo(){} // RVA: 0x7FFAC9DA6330
        public void Pack(){} // RVA: 0x7FFAC9DBA110
    }

    public class WrappedStringT : Object
    {
        public string S; // 0x10

        // ── Methods ──
        public void get_S(){} // RVA: 0x7FFAC2F3C380
        public void set_S(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class WrappedStringVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DA6460
    }

    public class WrappedUByte : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_U(){} // RVA: 0x7FFAC9DAF330
        public void MutateU(){} // RVA: 0x7FFAC9DA58E0
        public void CreateWrappedUByte(){} // RVA: 0x7FFAC9DBB0E0
        public void UnPack(){} // RVA: 0x7FFAC9DBB170
        public void UnPackTo(){} // RVA: 0x7FFAC9DBAFF0
        public void Pack(){} // RVA: 0x7FFAC9DBB1E0
    }

    public class WrappedUByteT : Object
    {
        public byte U; // 0x10

        // ── Methods ──
        public void get_U(){} // RVA: 0x7FFAC2FEB5E0
        public void set_U(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC322C880
    }

    public class WrappedUInt : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_U(){} // RVA: 0x7FFAC9DA5B00
        public void MutateU(){} // RVA: 0x7FFAC9DA5B30
        public void CreateWrappedUInt(){} // RVA: 0x7FFAC9DBA780
        public void UnPack(){} // RVA: 0x7FFAC9DBA810
        public void UnPackTo(){} // RVA: 0x7FFAC9DA5C60
        public void Pack(){} // RVA: 0x7FFAC9DBA880
    }

    public class WrappedUIntT : Object
    {
        public uint U; // 0x10

        // ── Methods ──
        public void get_U(){} // RVA: 0x7FFAC2F6E5C0
        public void set_U(){} // RVA: 0x7FFAC2F240C0
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
    }

    public class WrappedULong : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsWrappedULong(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_U(){} // RVA: 0x7FFAC9DB97A0
        public void MutateU(){} // RVA: 0x7FFAC9DB97F0
        public void CreateWrappedULong(){} // RVA: 0x7FFAC9DB9C10
        public void StartWrappedULong(){} // RVA: 0x7FFAC9DA6170
        public void AddU(){} // RVA: 0x7FFAC9DB9900
        public void EndWrappedULong(){} // RVA: 0x7FFAC9DB9CC0
        public void UnPack(){} // RVA: 0x7FFAC9DB9D10
        public void UnPackTo(){} // RVA: 0x7FFAC9DB9A60
        public void Pack(){} // RVA: 0x7FFAC9DB9DB0
    }

    public class WrappedULongT : Object
    {
        public ulong U; // 0x10

        // ── Methods ──
        public void get_U(){} // RVA: 0x7FFAC2F3C380
        public void set_U(){} // RVA: 0x7FFAC441EFB0
        public void .ctor(){} // RVA: 0x7FFAC3B206B0
    }

    public class WrappedULongVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DB9B80
    }

    public class WrappedUShort : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_U(){} // RVA: 0x7FFAC9DBA1D0
        public void MutateU(){} // RVA: 0x7FFAC9DBA200
        public void CreateWrappedUShort(){} // RVA: 0x7FFAC9DBA420
        public void UnPack(){} // RVA: 0x7FFAC9DBA4B0
        public void UnPackTo(){} // RVA: 0x7FFAC9DBA330
        public void Pack(){} // RVA: 0x7FFAC9DBA520
    }

    public class WrappedUShortT : Object
    {
        public ushort U; // 0x10

        // ── Methods ──
        public void get_U(){} // RVA: 0x7FFAC469AEC0
        public void set_U(){} // RVA: 0x7FFAC469BCA0
        public void .ctor(){} // RVA: 0x7FFAC489A870
    }

}