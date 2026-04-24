// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 22
// Methods: 672

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class DataStorage : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void VerifyDataStorage(){} // RVA: 0x7ffaaf7c9a70
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void EntriesType(){} // RVA: 0x7ffaaf7c8ef0
        public void get_EntriesTypeLength(){} // RVA: 0x7ffaaf7c8f70
        public void Entries(){} // RVA: 0x7ffaa887e5c0
        public void get_EntriesLength(){} // RVA: 0x7ffaaf7c9d00
        public void CreateDataStorage(){} // RVA: 0x7ffaaf7c9d70
        public void StartDataStorage(){} // RVA: 0x7ffaaf7c9e20
        public void AddEntriesType(){} // RVA: 0x7ffaaf7c8bb0
        public void CreateEntriesTypeVector(){} // RVA: 0x7ffaaf7c91b0
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7ffaaf7c9ff0
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7ffaaf7c9ff0
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7ffaaf7c9ff0
        public void StartEntriesTypeVector(){} // RVA: 0x7ffaaf7c9500
        public void AddEntries(){} // RVA: 0x7ffaaf7ca0b0
        public void CreateEntriesVector(){} // RVA: 0x7ffaaf7c00b0
        public void CreateEntriesVectorBlock(){} // RVA: 0x7ffaaf7ca290
        public void CreateEntriesVectorBlock(){} // RVA: 0x7ffaaf7ca290
        public void CreateEntriesVectorBlock(){} // RVA: 0x7ffaaf7ca290
        public void StartEntriesVector(){} // RVA: 0x7ffaaf7c0470
        public void EndDataStorage(){} // RVA: 0x7ffaaf7ca350
        public void FinishDataStorageBuffer(){} // RVA: 0x7ffaaf7ca3a0
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x7ffaaf7ca400
        public void UnPack(){} // RVA: 0x7ffaaf7ca420
        public void UnPackTo(){} // RVA: 0x7ffaaf7ca4d0
        public void Pack(){} // RVA: 0x7ffaaf7cac00
        // ── Binary Analysis Named ──
        public void GetRootAsDataStorage(){} // RVA: 0x7ffaaf7bf5b0
        public void GetRootAsDataStorage(){} // RVA: 0x7ffaaf7bf5b0
        public void GetEntriesTypeBytes(){} // RVA: 0x7ffaaf7c9b60
        public void GetEntriesTypeArray(){} // RVA: 0x7ffaaf7c9bd0
    }

    public class DataStorageEntryUnion : Object
    {
        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaa89fc5e0
        public void set_Type(){} // RVA: 0x7ffaa89fc5f0
        public void get_Value(){} // RVA: 0x7ffaa89357c0
        public void set_Value(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaaf796e90
        public void As(){} // RVA: 0x7ffaa887e5c0
        public void AsDataStorageBool(){} // RVA: 0x7ffaaf7c7730
        public void FromDataStorageBool(){} // RVA: 0x7ffaaf7c7770
        public void AsDataStorageInt(){} // RVA: 0x7ffaaf7c7870
        public void FromDataStorageInt(){} // RVA: 0x7ffaaf7c78b0
        public void AsDataStorageFloat(){} // RVA: 0x7ffaaf7c79b0
        public void FromDataStorageFloat(){} // RVA: 0x7ffaaf7c79f0
        public void AsDataStorageString(){} // RVA: 0x7ffaaf7c7af0
        public void FromDataStorageString(){} // RVA: 0x7ffaaf7c7b30
        public void AsDataStorageBytes(){} // RVA: 0x7ffaaf7c7c30
        public void FromDataStorageBytes(){} // RVA: 0x7ffaaf7c7c70
        public void Pack(){} // RVA: 0x7ffaaf7c7d70
    }

    public class ObjectMetadata : ValueType
    {
        // ── Original Methods ──
        public void ComputeHash(){} // RVA: 0x7ffaaf7beac0
        public void AreCompatible(){} // RVA: 0x7ffaaf7bf0b0
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_Is8Bit(){} // RVA: 0x7ffaaf7bf610
        public void MutateIs8Bit(){} // RVA: 0x7ffaaf7bf660
        public void get_DoNotPersist(){} // RVA: 0x7ffaaf7bf6c0
        public void MutateDoNotPersist(){} // RVA: 0x7ffaaf7bf710
        public void get_Code(){} // RVA: 0x7ffaaf7bf770
        public void MutateCode(){} // RVA: 0x7ffaaf7bf7c0
        public void ComponentInfo(){} // RVA: 0x7ffaaf7bf820
        public void get_ComponentInfoLength(){} // RVA: 0x7ffaaf7bf990
        public void Payload(){} // RVA: 0x7ffaaf7bfa00
        public void get_PayloadLength(){} // RVA: 0x7ffaaf7bfb70
        public void get_InitialPath(){} // RVA: 0x7ffaaf7bfbe0
        public void CreateObjectMetadata(){} // RVA: 0x7ffaaf7bfd30
        public void StartObjectMetadata(){} // RVA: 0x7ffaaf7bff00
        public void AddIs8Bit(){} // RVA: 0x7ffaaf7bff20
        public void AddDoNotPersist(){} // RVA: 0x7ffaaf7bff90
        public void AddCode(){} // RVA: 0x7ffaaf7c0000
        public void AddComponentInfo(){} // RVA: 0x7ffaaf7c0070
        public void CreateComponentInfoVector(){} // RVA: 0x7ffaaf7c00b0
        public void CreateComponentInfoVectorBlock(){} // RVA: 0x7ffaaf7c03b0
        public void CreateComponentInfoVectorBlock(){} // RVA: 0x7ffaaf7c03b0
        public void CreateComponentInfoVectorBlock(){} // RVA: 0x7ffaaf7c03b0
        public void StartComponentInfoVector(){} // RVA: 0x7ffaaf7c0470
        public void AddPayload(){} // RVA: 0x7ffaaf7c04a0
        public void CreatePayloadVector(){} // RVA: 0x7ffaaf7c00b0
        public void CreatePayloadVectorBlock(){} // RVA: 0x7ffaaf7c0720
        public void CreatePayloadVectorBlock(){} // RVA: 0x7ffaaf7c0720
        public void CreatePayloadVectorBlock(){} // RVA: 0x7ffaaf7c0720
        public void StartPayloadVector(){} // RVA: 0x7ffaaf7c0470
        public void AddInitialPath(){} // RVA: 0x7ffaaf7c07e0
        public void EndObjectMetadata(){} // RVA: 0x7ffaaf7c0820
        public void UnPack(){} // RVA: 0x7ffaaf7c0870
        public void UnPackTo(){} // RVA: 0x7ffaaf7c08e0
        public void Pack(){} // RVA: 0x7ffaaf7c0e70
        // ── Binary Analysis Named ──
        public void GetRootAsObjectMetadata(){} // RVA: 0x7ffaaf7bf5b0
        public void GetRootAsObjectMetadata(){} // RVA: 0x7ffaaf7bf5b0
        public void GetInitialPathBytes(){} // RVA: 0x7ffaaf7bfc70
        public void GetInitialPathArray(){} // RVA: 0x7ffaaf7bfce0
    }

    public class ObjectMetadataT : Object
    {
        public object _code; // 0x3357CD60, was: <Code>k__BackingField
        public object _initialPath; // 0x3357CD60, was: <InitialPath>k__BackingField
        public object Is8Bit; // 0x170001C5
        public object DoNotPersist; // 0x170001C6

        // ── Original Methods ──
        public void ComputeHash(){} // RVA: 0x7ffaaf7c11e0
        public void AreCompatible(){} // RVA: 0x7ffaaf7c16c0
        public void get_Is8Bit(){} // RVA: 0x7ffaa89fc5e0
        public void set_Is8Bit(){} // RVA: 0x7ffaa89fc5f0
        public void get_DoNotPersist(){} // RVA: 0x7ffaa8b37c40
        public void set_DoNotPersist(){} // RVA: 0x7ffaa919b040
        public void get_Code(){} // RVA: 0x7ffaa950f430
        public void set_Code(){} // RVA: 0x7ffaa9e38fe0
        public void get_ComponentInfo(){} // RVA: 0x7ffaa89357c0
        public void set_ComponentInfo(){} // RVA: 0x7ffaa8998e80
        public void get_Payload(){} // RVA: 0x7ffaa89600c0
        public void set_Payload(){} // RVA: 0x7ffaa89600d0
        public void get_InitialPath(){} // RVA: 0x7ffaa8960130
        public void set_InitialPath(){} // RVA: 0x7ffaa8933e90
        public void .ctor(){} // RVA: 0x7ffaaf7c1990
    }

    public class ObjectPool : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void VerifyObjectPool(){} // RVA: 0x7ffaaf7cb160
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void Data(){} // RVA: 0x7ffaaf7c8ef0
        public void get_DataLength(){} // RVA: 0x7ffaaf7c8f70
        public void MutateData(){} // RVA: 0x7ffaaf7c90a0
        public void CreateObjectPool(){} // RVA: 0x7ffaaf7cb310
        public void StartObjectPool(){} // RVA: 0x7ffaaf7c8b90
        public void AddData(){} // RVA: 0x7ffaaf7c8bb0
        public void CreateDataVector(){} // RVA: 0x7ffaaf7c91b0
        public void CreateDataVectorBlock(){} // RVA: 0x7ffaaf7cb530
        public void CreateDataVectorBlock(){} // RVA: 0x7ffaaf7cb530
        public void CreateDataVectorBlock(){} // RVA: 0x7ffaaf7cb530
        public void StartDataVector(){} // RVA: 0x7ffaaf7c9500
        public void EndObjectPool(){} // RVA: 0x7ffaaf7cb5f0
        public void FinishObjectPoolBuffer(){} // RVA: 0x7ffaaf7ca3a0
        public void FinishSizePrefixedObjectPoolBuffer(){} // RVA: 0x7ffaaf7ca400
        public void UnPack(){} // RVA: 0x7ffaaf7cb640
        public void UnPackTo(){} // RVA: 0x7ffaaf7cb6f0
        public void Pack(){} // RVA: 0x7ffaaf7cb900
        // ── Binary Analysis Named ──
        public void GetRootAsObjectPool(){} // RVA: 0x7ffaaf7bf5b0
        public void GetRootAsObjectPool(){} // RVA: 0x7ffaaf7bf5b0
        public void GetDataBytes(){} // RVA: 0x7ffaaf7cb250
        public void GetDataArray(){} // RVA: 0x7ffaaf7cb2c0
    }

    public class PhysBoneGrab : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_ChainIdA(){} // RVA: 0x7ffaaf7d17e0
        public void MutateChainIdA(){} // RVA: 0x7ffaaf7d1810
        public void get_ChainIdB(){} // RVA: 0x7ffaaf7d1840
        public void MutateChainIdB(){} // RVA: 0x7ffaaf7d1870
        public void get_Bone(){} // RVA: 0x7ffaaf7d18a0
        public void MutateBone(){} // RVA: 0x7ffaaf7d18d0
        public void get_Offset(){} // RVA: 0x7ffaaf7d1900
        public void CreatePhysBoneGrab(){} // RVA: 0x7ffaaf7d1940
        public void UnPack(){} // RVA: 0x7ffaaf7d1ac0
        public void UnPackTo(){} // RVA: 0x7ffaaf7d1b30
        public void Pack(){} // RVA: 0x7ffaaf7d1c40
    }

    public class PlayerDataPair : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_Key(){} // RVA: 0x7ffaaf7c89c0
        public void get_ValueType(){} // RVA: 0x7ffaaf7d65d0
        public void Value(){} // RVA: 0x7ffaa887e5c0
        public void ValueAsVector2(){} // RVA: 0x7ffaaf7d6620
        public void ValueAsVector3(){} // RVA: 0x7ffaaf7d66b0
        public void ValueAsVector4(){} // RVA: 0x7ffaaf7d6740
        public void ValueAsQuaternion(){} // RVA: 0x7ffaaf7d67d0
        public void ValueAsColor(){} // RVA: 0x7ffaaf7d6860
        public void ValueAsColor32(){} // RVA: 0x7ffaaf7d68f0
        public void ValueAsWrappedString(){} // RVA: 0x7ffaaf7d6980
        public void ValueAsWrappedShort(){} // RVA: 0x7ffaaf7d6a10
        public void ValueAsWrappedInt(){} // RVA: 0x7ffaaf7d6aa0
        public void ValueAsWrappedFloat(){} // RVA: 0x7ffaaf7d6b30
        public void ValueAsWrappedBool(){} // RVA: 0x7ffaaf7d6bc0
        public void ValueAsWrappedByte(){} // RVA: 0x7ffaaf7d6c50
        public void ValueAsWrappedBytes(){} // RVA: 0x7ffaaf7d6ce0
        public void ValueAsWrappedUShort(){} // RVA: 0x7ffaaf7d6d70
        public void ValueAsWrappedUByte(){} // RVA: 0x7ffaaf7d6e00
        public void ValueAsWrappedUInt(){} // RVA: 0x7ffaaf7d6e90
        public void ValueAsWrappedULong(){} // RVA: 0x7ffaaf7d6f20
        public void ValueAsWrappedDouble(){} // RVA: 0x7ffaaf7d6fb0
        public void ValueAsWrappedLong(){} // RVA: 0x7ffaaf7d7040
        public void CreatePlayerDataPair(){} // RVA: 0x7ffaaf7d70d0
        public void StartPlayerDataPair(){} // RVA: 0x7ffaaf7cfc00
        public void AddKey(){} // RVA: 0x7ffaaf7c8bb0
        public void AddValueType(){} // RVA: 0x7ffaaf7d71e0
        public void AddValue(){} // RVA: 0x7ffaaf7c50c0
        public void EndPlayerDataPair(){} // RVA: 0x7ffaaf7d7250
        public void UnPack(){} // RVA: 0x7ffaaf7d72a0
        public void UnPackTo(){} // RVA: 0x7ffaaf7d7310
        public void Pack(){} // RVA: 0x7ffaaf7d83a0
        // ── Binary Analysis Named ──
        public void GetRootAsPlayerDataPair(){} // RVA: 0x7ffaaf7bf5b0
        public void GetRootAsPlayerDataPair(){} // RVA: 0x7ffaaf7bf5b0
        public void GetKeyBytes(){} // RVA: 0x7ffaaf7d6510
        public void GetKeyArray(){} // RVA: 0x7ffaaf7d6580
    }

    public class PlayerDataTypeUnion : Object
    {
        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaa89fc5e0
        public void set_Type(){} // RVA: 0x7ffaa89fc5f0
        public void get_Value(){} // RVA: 0x7ffaa89357c0
        public void set_Value(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaaf796e90
        public void As(){} // RVA: 0x7ffaa887e5c0
        public void AsVector2(){} // RVA: 0x7ffaaf7d4080
        public void FromVector2(){} // RVA: 0x7ffaaf7d40c0
        public void AsVector3(){} // RVA: 0x7ffaaf7d41c0
        public void FromVector3(){} // RVA: 0x7ffaaf7d4200
        public void AsVector4(){} // RVA: 0x7ffaaf7d4300
        public void FromVector4(){} // RVA: 0x7ffaaf7d4340
        public void AsQuaternion(){} // RVA: 0x7ffaaf7d4440
        public void FromQuaternion(){} // RVA: 0x7ffaaf7d4480
        public void AsColor(){} // RVA: 0x7ffaaf7d4580
        public void FromColor(){} // RVA: 0x7ffaaf7d45c0
        public void AsColor32(){} // RVA: 0x7ffaaf7d46c0
        public void FromColor32(){} // RVA: 0x7ffaaf7d4700
        public void AsWrappedString(){} // RVA: 0x7ffaaf7d4800
        public void FromWrappedString(){} // RVA: 0x7ffaaf7d4840
        public void AsWrappedShort(){} // RVA: 0x7ffaaf7d4940
        public void FromWrappedShort(){} // RVA: 0x7ffaaf7d4980
        public void AsWrappedInt(){} // RVA: 0x7ffaaf7d4a80
        public void FromWrappedInt(){} // RVA: 0x7ffaaf7d4ac0
        public void AsWrappedFloat(){} // RVA: 0x7ffaaf7d4bc0
        public void FromWrappedFloat(){} // RVA: 0x7ffaaf7d4c00
        public void AsWrappedBool(){} // RVA: 0x7ffaaf7d4d00
        public void FromWrappedBool(){} // RVA: 0x7ffaaf7d4d40
        public void AsWrappedByte(){} // RVA: 0x7ffaaf7d4e40
        public void FromWrappedByte(){} // RVA: 0x7ffaaf7d4e80
        public void AsWrappedBytes(){} // RVA: 0x7ffaaf7d4f80
        public void FromWrappedBytes(){} // RVA: 0x7ffaaf7d4fc0
        public void AsWrappedUShort(){} // RVA: 0x7ffaaf7d50c0
        public void FromWrappedUShort(){} // RVA: 0x7ffaaf7d5100
        public void AsWrappedUByte(){} // RVA: 0x7ffaaf7d5200
        public void FromWrappedUByte(){} // RVA: 0x7ffaaf7d5240
        public void AsWrappedUInt(){} // RVA: 0x7ffaaf7d5340
        public void FromWrappedUInt(){} // RVA: 0x7ffaaf7d5380
        public void AsWrappedULong(){} // RVA: 0x7ffaaf7d5480
        public void FromWrappedULong(){} // RVA: 0x7ffaaf7d54c0
        public void AsWrappedDouble(){} // RVA: 0x7ffaaf7d55c0
        public void FromWrappedDouble(){} // RVA: 0x7ffaaf7d5600
        public void AsWrappedLong(){} // RVA: 0x7ffaaf7d5700
        public void FromWrappedLong(){} // RVA: 0x7ffaaf7d5740
        public void Pack(){} // RVA: 0x7ffaaf7d5840
    }

    public class PlayerStationStateData : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void ActiveStations(){} // RVA: 0x7ffaaf7d9290
        public void get_ActiveStationsLength(){} // RVA: 0x7ffaaf7c8f70
        public void MutateActiveStations(){} // RVA: 0x7ffaaf7d93d0
        public void CreatePlayerStationStateData(){} // RVA: 0x7ffaaf7d9460
        public void StartPlayerStationStateData(){} // RVA: 0x7ffaaf7c8b90
        public void AddActiveStations(){} // RVA: 0x7ffaaf7c8bb0
        public void CreateActiveStationsVector(){} // RVA: 0x7ffaaf7cd230
        public void CreateActiveStationsVectorBlock(){} // RVA: 0x7ffaaf7d9680
        public void CreateActiveStationsVectorBlock(){} // RVA: 0x7ffaaf7d9680
        public void CreateActiveStationsVectorBlock(){} // RVA: 0x7ffaaf7d9680
        public void StartActiveStationsVector(){} // RVA: 0x7ffaaf7c0470
        public void EndPlayerStationStateData(){} // RVA: 0x7ffaaf7d9740
        public void UnPack(){} // RVA: 0x7ffaaf7d9790
        public void UnPackTo(){} // RVA: 0x7ffaaf7d9840
        public void Pack(){} // RVA: 0x7ffaaf7d9a60
        // ── Binary Analysis Named ──
        public void GetRootAsPlayerStationStateData(){} // RVA: 0x7ffaaf7bf5b0
        public void GetRootAsPlayerStationStateData(){} // RVA: 0x7ffaaf7bf5b0
        public void GetActiveStationsBytes(){} // RVA: 0x7ffaaf7d9310
        public void GetActiveStationsArray(){} // RVA: 0x7ffaaf7d9380
    }

    public class QuaternionT : Object
    {
        public object _z; // 0x33735950, was: <Z>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf795680
        public void CopyFrom(){} // RVA: 0x7ffaaf794d00
        public void ToNumerics(){} // RVA: 0x7ffaaf794d30
        public void get_identity(){} // RVA: 0x7ffaaf7c1aa0
        public void get_magnitude(){} // RVA: 0x7ffaaf7c1af0
        public void get_sqrMagnitude(){} // RVA: 0x7ffaaf794e50
        public void Slerp(){} // RVA: 0x7ffaaf7c1ba0
        public void op_Multiply(){} // RVA: 0x7ffaaf7c1c80
        public void IsBad(){} // RVA: 0x7ffaaf7952b0
        public void Normalize(){} // RVA: 0x7ffaaf7c1e30
        public void get_X(){} // RVA: 0x7ffaa8a5c320
        public void set_X(){} // RVA: 0x7ffaa8a5c330
        public void get_Y(){} // RVA: 0x7ffaa8a5c340
        public void set_Y(){} // RVA: 0x7ffaa8a5c350
        public void get_Z(){} // RVA: 0x7ffaa8936cf0
        public void set_Z(){} // RVA: 0x7ffaa894d4d0
        public void get_W(){} // RVA: 0x7ffaa89ff570
        public void set_W(){} // RVA: 0x7ffaa89ff580
        public void .ctor(){} // RVA: 0x7ffaaf795680
    }

    public class SerializedObjects : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void VerifySerializedObjects(){} // RVA: 0x7ffaaf7dab20
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void ObjectsType(){} // RVA: 0x7ffaaf7c8ef0
        public void get_ObjectsTypeLength(){} // RVA: 0x7ffaaf7c8f70
        public void Objects(){} // RVA: 0x7ffaa887e5c0
        public void get_ObjectsLength(){} // RVA: 0x7ffaaf7c9d00
        public void CreateSerializedObjects(){} // RVA: 0x7ffaaf7dadb0
        public void StartSerializedObjects(){} // RVA: 0x7ffaaf7c9e20
        public void AddObjectsType(){} // RVA: 0x7ffaaf7c8bb0
        public void CreateObjectsTypeVector(){} // RVA: 0x7ffaaf7c91b0
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7ffaaf7db010
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7ffaaf7db010
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7ffaaf7db010
        public void StartObjectsTypeVector(){} // RVA: 0x7ffaaf7c9500
        public void AddObjects(){} // RVA: 0x7ffaaf7ca0b0
        public void CreateObjectsVector(){} // RVA: 0x7ffaaf7c00b0
        public void CreateObjectsVectorBlock(){} // RVA: 0x7ffaaf7db270
        public void CreateObjectsVectorBlock(){} // RVA: 0x7ffaaf7db270
        public void CreateObjectsVectorBlock(){} // RVA: 0x7ffaaf7db270
        public void StartObjectsVector(){} // RVA: 0x7ffaaf7c0470
        public void EndSerializedObjects(){} // RVA: 0x7ffaaf7db330
        public void FinishSerializedObjectsBuffer(){} // RVA: 0x7ffaaf7ca3a0
        public void FinishSizePrefixedSerializedObjectsBuffer(){} // RVA: 0x7ffaaf7ca400
        public void UnPack(){} // RVA: 0x7ffaaf7db380
        public void UnPackTo(){} // RVA: 0x7ffaaf7db430
        public void Pack(){} // RVA: 0x7ffaaf7dbc60
        // ── Binary Analysis Named ──
        public void GetRootAsSerializedObjects(){} // RVA: 0x7ffaaf7bf5b0
        public void GetRootAsSerializedObjects(){} // RVA: 0x7ffaaf7bf5b0
        public void GetObjectsTypeBytes(){} // RVA: 0x7ffaaf7dac10
        public void GetObjectsTypeArray(){} // RVA: 0x7ffaaf7dac80
    }

    public class SerializedTypeUnion : Object
    {
        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaa89fc5e0
        public void set_Type(){} // RVA: 0x7ffaa89fc5f0
        public void get_Value(){} // RVA: 0x7ffaa89357c0
        public void set_Value(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaaf796e90
        public void As(){} // RVA: 0x7ffaa887e5c0
        public void AsSyncPlayable(){} // RVA: 0x7ffaaf7d9bc0
        public void FromSyncPlayable(){} // RVA: 0x7ffaaf7d9c00
        public void AsDataStorage(){} // RVA: 0x7ffaaf7d9d00
        public void FromDataStorage(){} // RVA: 0x7ffaaf7d9d40
        public void AsUdon(){} // RVA: 0x7ffaaf7d9e40
        public void FromUdon(){} // RVA: 0x7ffaaf7d9e80
        public void AsObjectPool(){} // RVA: 0x7ffaaf7d9f80
        public void FromObjectPool(){} // RVA: 0x7ffaaf7d9fc0
        public void AsPlayerStationStateData(){} // RVA: 0x7ffaaf7da0c0
        public void FromPlayerStationStateData(){} // RVA: 0x7ffaaf7da100
        public void AsPhysBoneRecorder(){} // RVA: 0x7ffaaf7da200
        public void FromPhysBoneRecorder(){} // RVA: 0x7ffaaf7da240
        public void AsPlayerData(){} // RVA: 0x7ffaaf7da340
        public void FromPlayerData(){} // RVA: 0x7ffaaf7da380
        public void Pack(){} // RVA: 0x7ffaaf7da480
    }

    public class SparseSerializedObjects : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void VerifySparseSerializedObjects(){} // RVA: 0x7ffaaf7e13c0
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_Objects(){} // RVA: 0x7ffaaf7e14b0
        public void Bitmap(){} // RVA: 0x7ffaaf7e15e0
        public void get_BitmapLength(){} // RVA: 0x7ffaaf7c9d00
        public void MutateBitmap(){} // RVA: 0x7ffaaf7e1720
        public void CreateSparseSerializedObjects(){} // RVA: 0x7ffaaf7e17b0
        public void StartSparseSerializedObjects(){} // RVA: 0x7ffaaf7c9e20
        public void AddObjects(){} // RVA: 0x7ffaaf7c8bb0
        public void AddBitmap(){} // RVA: 0x7ffaaf7ca0b0
        public void CreateBitmapVector(){} // RVA: 0x7ffaaf7c91b0
        public void CreateBitmapVectorBlock(){} // RVA: 0x7ffaaf7e1a00
        public void CreateBitmapVectorBlock(){} // RVA: 0x7ffaaf7e1a00
        public void CreateBitmapVectorBlock(){} // RVA: 0x7ffaaf7e1a00
        public void StartBitmapVector(){} // RVA: 0x7ffaaf7c9500
        public void EndSparseSerializedObjects(){} // RVA: 0x7ffaaf7e1ac0
        public void FinishSparseSerializedObjectsBuffer(){} // RVA: 0x7ffaaf7ca3a0
        public void FinishSizePrefixedSparseSerializedObjectsBuffer(){} // RVA: 0x7ffaaf7ca400
        public void UnPack(){} // RVA: 0x7ffaaf7e1b10
        public void UnPackTo(){} // RVA: 0x7ffaaf7e1c20
        public void Pack(){} // RVA: 0x7ffaaf7e1f40
        // ── Binary Analysis Named ──
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x7ffaaf7bf5b0
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x7ffaaf7bf5b0
        public void GetBitmapBytes(){} // RVA: 0x7ffaaf7e1660
        public void GetBitmapArray(){} // RVA: 0x7ffaaf7e16d0
    }

    public class SyncPlayable : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void VerifySyncPlayable(){} // RVA: 0x7ffaaf7e2360
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_StageParamsOffset(){} // RVA: 0x7ffaaf7cca70
        public void MutateStageParamsOffset(){} // RVA: 0x7ffaaf7ccac0
        public void get_Puppet(){} // RVA: 0x7ffaaf7e2450
        public void get_AvatarDiscriminator(){} // RVA: 0x7ffaaf7e2560
        public void MutateAvatarDiscriminator(){} // RVA: 0x7ffaaf7e25b0
        public void CreateSyncPlayable(){} // RVA: 0x7ffaaf7e2610
        public void StartSyncPlayable(){} // RVA: 0x7ffaaf7cfc00
        public void AddStageParamsOffset(){} // RVA: 0x7ffaaf7cd150
        public void AddPuppet(){} // RVA: 0x7ffaaf7c5090
        public void AddAvatarDiscriminator(){} // RVA: 0x7ffaaf7e2760
        public void EndSyncPlayable(){} // RVA: 0x7ffaaf7e27d0
        public void FinishSyncPlayableBuffer(){} // RVA: 0x7ffaaf7ca3a0
        public void FinishSizePrefixedSyncPlayableBuffer(){} // RVA: 0x7ffaaf7ca400
        public void UnPack(){} // RVA: 0x7ffaaf7e2820
        public void UnPackTo(){} // RVA: 0x7ffaaf7e2920
        public void Pack(){} // RVA: 0x7ffaaf7e2b00
        // ── Binary Analysis Named ──
        public void GetRootAsSyncPlayable(){} // RVA: 0x7ffaaf7bf5b0
        public void GetRootAsSyncPlayable(){} // RVA: 0x7ffaaf7bf5b0
    }

    public class Udon : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void VerifyUdon(){} // RVA: 0x7ffaaf7f2560
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void DataType(){} // RVA: 0x7ffaaf7c8ef0
        public void get_DataTypeLength(){} // RVA: 0x7ffaaf7c8f70
        public void Data(){} // RVA: 0x7ffaa887e5c0
        public void get_DataLength(){} // RVA: 0x7ffaaf7c9d00
        public void CreateUdon(){} // RVA: 0x7ffaaf7f27f0
        public void StartUdon(){} // RVA: 0x7ffaaf7c9e20
        public void AddDataType(){} // RVA: 0x7ffaaf7c8bb0
        public void CreateDataTypeVector(){} // RVA: 0x7ffaaf7c91b0
        public void CreateDataTypeVectorBlock(){} // RVA: 0x7ffaaf7f2a50
        public void CreateDataTypeVectorBlock(){} // RVA: 0x7ffaaf7f2a50
        public void CreateDataTypeVectorBlock(){} // RVA: 0x7ffaaf7f2a50
        public void StartDataTypeVector(){} // RVA: 0x7ffaaf7c9500
        public void AddData(){} // RVA: 0x7ffaaf7ca0b0
        public void CreateDataVector(){} // RVA: 0x7ffaaf7c00b0
        public void CreateDataVectorBlock(){} // RVA: 0x7ffaaf7f2cb0
        public void CreateDataVectorBlock(){} // RVA: 0x7ffaaf7f2cb0
        public void CreateDataVectorBlock(){} // RVA: 0x7ffaaf7f2cb0
        public void StartDataVector(){} // RVA: 0x7ffaaf7c0470
        public void EndUdon(){} // RVA: 0x7ffaaf7f2d70
        public void FinishUdonBuffer(){} // RVA: 0x7ffaaf7ca3a0
        public void FinishSizePrefixedUdonBuffer(){} // RVA: 0x7ffaaf7ca400
        public void UnPack(){} // RVA: 0x7ffaaf7f2dc0
        public void UnPackTo(){} // RVA: 0x7ffaaf7f2e70
        public void Pack(){} // RVA: 0x7ffaaf7f4e30
        // ── Binary Analysis Named ──
        public void GetRootAsUdon(){} // RVA: 0x7ffaaf7bf5b0
        public void GetRootAsUdon(){} // RVA: 0x7ffaaf7bf5b0
        public void GetDataTypeBytes(){} // RVA: 0x7ffaaf7f2650
        public void GetDataTypeArray(){} // RVA: 0x7ffaaf7f26c0
    }

    public class UdonInfo : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void Names(){} // RVA: 0x7ffaaf7cbba0
        public void get_NamesLength(){} // RVA: 0x7ffaaf7c8f70
        public void Types(){} // RVA: 0x7ffaaf7cbc70
        public void get_TypesLength(){} // RVA: 0x7ffaaf7c9d00
        public void CreateUdonInfo(){} // RVA: 0x7ffaaf7cbd40
        public void StartUdonInfo(){} // RVA: 0x7ffaaf7c9e20
        public void AddNames(){} // RVA: 0x7ffaaf7c8bb0
        public void CreateNamesVector(){} // RVA: 0x7ffaaf7c00b0
        public void CreateNamesVectorBlock(){} // RVA: 0x7ffaaf7cbf90
        public void CreateNamesVectorBlock(){} // RVA: 0x7ffaaf7cbf90
        public void CreateNamesVectorBlock(){} // RVA: 0x7ffaaf7cbf90
        public void StartNamesVector(){} // RVA: 0x7ffaaf7c0470
        public void AddTypes(){} // RVA: 0x7ffaaf7ca0b0
        public void CreateTypesVector(){} // RVA: 0x7ffaaf7c00b0
        public void CreateTypesVectorBlock(){} // RVA: 0x7ffaaf7cc1f0
        public void CreateTypesVectorBlock(){} // RVA: 0x7ffaaf7cc1f0
        public void CreateTypesVectorBlock(){} // RVA: 0x7ffaaf7cc1f0
        public void StartTypesVector(){} // RVA: 0x7ffaaf7c0470
        public void EndUdonInfo(){} // RVA: 0x7ffaaf7cc2b0
        public void UnPack(){} // RVA: 0x7ffaaf7cc300
        public void UnPackTo(){} // RVA: 0x7ffaaf7cc370
        public void Pack(){} // RVA: 0x7ffaaf7cc660
        // ── Binary Analysis Named ──
        public void GetRootAsUdonInfo(){} // RVA: 0x7ffaaf7bf5b0
        public void GetRootAsUdonInfo(){} // RVA: 0x7ffaaf7bf5b0
    }

    public class UdonValueUnion : Object
    {
        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaa89fc5e0
        public void set_Type(){} // RVA: 0x7ffaa89fc5f0
        public void get_Value(){} // RVA: 0x7ffaa89357c0
        public void set_Value(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaaf796e90
        public void As(){} // RVA: 0x7ffaa887e5c0
        public void AsUdonShort(){} // RVA: 0x7ffaaf7e2fe0
        public void FromUdonShort(){} // RVA: 0x7ffaaf7e3020
        public void AsUdonUShort(){} // RVA: 0x7ffaaf7e3120
        public void FromUdonUShort(){} // RVA: 0x7ffaaf7e3160
        public void AsUdonChar(){} // RVA: 0x7ffaaf7e3260
        public void FromUdonChar(){} // RVA: 0x7ffaaf7e32a0
        public void AsUdonByte(){} // RVA: 0x7ffaaf7e33a0
        public void FromUdonByte(){} // RVA: 0x7ffaaf7e33e0
        public void AsUdonUByte(){} // RVA: 0x7ffaaf7e34e0
        public void FromUdonUByte(){} // RVA: 0x7ffaaf7e3520
        public void AsUdonLong(){} // RVA: 0x7ffaaf7e3620
        public void FromUdonLong(){} // RVA: 0x7ffaaf7e3660
        public void AsUdonULong(){} // RVA: 0x7ffaaf7e3760
        public void FromUdonULong(){} // RVA: 0x7ffaaf7e37a0
        public void AsUdonDouble(){} // RVA: 0x7ffaaf7e38a0
        public void FromUdonDouble(){} // RVA: 0x7ffaaf7e38e0
        public void AsUdonBool(){} // RVA: 0x7ffaaf7e39e0
        public void FromUdonBool(){} // RVA: 0x7ffaaf7e3a20
        public void AsUdonFloat(){} // RVA: 0x7ffaaf7e3b20
        public void FromUdonFloat(){} // RVA: 0x7ffaaf7e3b60
        public void AsUdonInt(){} // RVA: 0x7ffaaf7e3c60
        public void FromUdonInt(){} // RVA: 0x7ffaaf7e3ca0
        public void AsUdonUInt(){} // RVA: 0x7ffaaf7e3da0
        public void FromUdonUInt(){} // RVA: 0x7ffaaf7e3de0
        public void AsVector2(){} // RVA: 0x7ffaaf7e3ee0
        public void FromVector2(){} // RVA: 0x7ffaaf7e3f20
        public void AsVector3(){} // RVA: 0x7ffaaf7e4020
        public void FromVector3(){} // RVA: 0x7ffaaf7e4060
        public void AsVector4(){} // RVA: 0x7ffaaf7e4160
        public void FromVector4(){} // RVA: 0x7ffaaf7e41a0
        public void AsQuaternion(){} // RVA: 0x7ffaaf7e42a0
        public void FromQuaternion(){} // RVA: 0x7ffaaf7e42e0
        public void AsColor(){} // RVA: 0x7ffaaf7e43e0
        public void FromColor(){} // RVA: 0x7ffaaf7e4420
        public void AsColor32(){} // RVA: 0x7ffaaf7e4520
        public void FromColor32(){} // RVA: 0x7ffaaf7e4560
        public void AsUdonShortArray(){} // RVA: 0x7ffaaf7e4660
        public void FromUdonShortArray(){} // RVA: 0x7ffaaf7e46a0
        public void AsUdonUShortArray(){} // RVA: 0x7ffaaf7e47a0
        public void FromUdonUShortArray(){} // RVA: 0x7ffaaf7e47e0
        public void AsUdonCharArray(){} // RVA: 0x7ffaaf7e48e0
        public void FromUdonCharArray(){} // RVA: 0x7ffaaf7e4920
        public void AsUdonByteArray(){} // RVA: 0x7ffaaf7e4a20
        public void FromUdonByteArray(){} // RVA: 0x7ffaaf7e4a60
        public void AsUdonUByteArray(){} // RVA: 0x7ffaaf7e4b60
        public void FromUdonUByteArray(){} // RVA: 0x7ffaaf7e4ba0
        public void AsUdonLongArray(){} // RVA: 0x7ffaaf7e4ca0
        public void FromUdonLongArray(){} // RVA: 0x7ffaaf7e4ce0
        public void AsUdonULongArray(){} // RVA: 0x7ffaaf7e4de0
        public void FromUdonULongArray(){} // RVA: 0x7ffaaf7e4e20
        public void AsUdonDoubleArray(){} // RVA: 0x7ffaaf7e4f20
        public void FromUdonDoubleArray(){} // RVA: 0x7ffaaf7e4f60
        public void AsUdonBoolArray(){} // RVA: 0x7ffaaf7e5060
        public void FromUdonBoolArray(){} // RVA: 0x7ffaaf7e50a0
        public void AsUdonFloatArray(){} // RVA: 0x7ffaaf7e51a0
        public void FromUdonFloatArray(){} // RVA: 0x7ffaaf7e51e0
        public void AsUdonIntArray(){} // RVA: 0x7ffaaf7e52e0
        public void FromUdonIntArray(){} // RVA: 0x7ffaaf7e5320
        public void AsUdonUIntArray(){} // RVA: 0x7ffaaf7e5420
        public void FromUdonUIntArray(){} // RVA: 0x7ffaaf7e5460
        public void AsVector2Array(){} // RVA: 0x7ffaaf7e5560
        public void FromVector2Array(){} // RVA: 0x7ffaaf7e55a0
        public void AsVector3Array(){} // RVA: 0x7ffaaf7e56a0
        public void FromVector3Array(){} // RVA: 0x7ffaaf7e56e0
        public void AsVector4Array(){} // RVA: 0x7ffaaf7e57e0
        public void FromVector4Array(){} // RVA: 0x7ffaaf7e5820
        public void AsQuaternionArray(){} // RVA: 0x7ffaaf7e5920
        public void FromQuaternionArray(){} // RVA: 0x7ffaaf7e5960
        public void AsColorArray(){} // RVA: 0x7ffaaf7e5a60
        public void FromColorArray(){} // RVA: 0x7ffaaf7e5aa0
        public void AsColor32Array(){} // RVA: 0x7ffaaf7e5ba0
        public void FromColor32Array(){} // RVA: 0x7ffaaf7e5be0
        public void AsUdonString(){} // RVA: 0x7ffaaf7e5ce0
        public void FromUdonString(){} // RVA: 0x7ffaaf7e5d20
        public void Pack(){} // RVA: 0x7ffaaf7e5e20
    }

    public class Vector2T : Object
    {
        // ── Original Methods ──
        public void ToNumerics(){} // RVA: 0x7ffaab27e3b0
        public void get_zero(){} // RVA: 0x7ffaaf7c1fc0
        public void .ctor(){} // RVA: 0x7ffaae3fc660
        public void CopyFrom(){} // RVA: 0x7ffaaf7956d0
        public void op_UnaryNegation(){} // RVA: 0x7ffaaf7c2000
        public void get_magnitude(){} // RVA: 0x7ffaaf7c2070
        public void get_sqrMagnitude(){} // RVA: 0x7ffaaf795800
        public void op_Multiply(){} // RVA: 0x7ffaaf7c2280
        public void op_Multiply(){} // RVA: 0x7ffaaf7c2280
        public void op_Multiply(){} // RVA: 0x7ffaaf7c2280
        public void op_Multiply(){} // RVA: 0x7ffaaf7c2280
        public void op_Division(){} // RVA: 0x7ffaaf7c2380
        public void op_Division(){} // RVA: 0x7ffaaf7c2380
        public void op_Addition(){} // RVA: 0x7ffaaf7c2500
        public void op_Addition(){} // RVA: 0x7ffaaf7c2500
        public void op_Addition(){} // RVA: 0x7ffaaf7c2500
        public void op_Subtraction(){} // RVA: 0x7ffaaf7c2680
        public void op_Subtraction(){} // RVA: 0x7ffaaf7c2680
        public void op_Subtraction(){} // RVA: 0x7ffaaf7c2680
        public void LerpUnclamped(){} // RVA: 0x7ffaaf7c2700
        public void Lerp(){} // RVA: 0x7ffaaf7c2800
        public void IsBad(){} // RVA: 0x7ffaaf796100
        public void get_X(){} // RVA: 0x7ffaa8a5c320
        public void set_X(){} // RVA: 0x7ffaa8a5c330
        public void get_Y(){} // RVA: 0x7ffaa8a5c340
        public void set_Y(){} // RVA: 0x7ffaa8a5c350
        public void .ctor(){} // RVA: 0x7ffaae3fc660
    }

    public class Vector3T : Object
    {
        public object _y; // 0x33994C70, was: <Y>k__BackingField

        // ── Original Methods ──
        public void ToNumerics(){} // RVA: 0x7ffaa91687f0
        public void .ctor(){} // RVA: 0x7ffaae49ef80
        public void CopyFrom(){} // RVA: 0x7ffaaf7961b0
        public void get_magnitude(){} // RVA: 0x7ffaaf7c29e0
        public void get_sqrMagnitude(){} // RVA: 0x7ffaaf796280
        public void op_Multiply(){} // RVA: 0x7ffaaf7c2e70
        public void op_UnaryNegation(){} // RVA: 0x7ffaaf7c2b10
        public void op_Multiply(){} // RVA: 0x7ffaaf7c2e70
        public void op_Multiply(){} // RVA: 0x7ffaaf7c2e70
        public void op_Division(){} // RVA: 0x7ffaaf7c2da0
        public void op_Division(){} // RVA: 0x7ffaaf7c2da0
        public void op_Multiply(){} // RVA: 0x7ffaaf7c2e70
        public void op_Addition(){} // RVA: 0x7ffaaf7c30a0
        public void op_Addition(){} // RVA: 0x7ffaaf7c30a0
        public void op_Addition(){} // RVA: 0x7ffaaf7c30a0
        public void op_Subtraction(){} // RVA: 0x7ffaaf7c32e0
        public void op_Subtraction(){} // RVA: 0x7ffaaf7c32e0
        public void op_Subtraction(){} // RVA: 0x7ffaaf7c32e0
        public void LerpUnclamped(){} // RVA: 0x7ffaaf7c3370
        public void Lerp(){} // RVA: 0x7ffaaf7c34a0
        public void IsBad(){} // RVA: 0x7ffaaf796d10
        public void get_X(){} // RVA: 0x7ffaa8a5c320
        public void set_X(){} // RVA: 0x7ffaa8a5c330
        public void get_Y(){} // RVA: 0x7ffaa8a5c340
        public void set_Y(){} // RVA: 0x7ffaa8a5c350
        public void get_Z(){} // RVA: 0x7ffaa8936cf0
        public void set_Z(){} // RVA: 0x7ffaa894d4d0
        public void .ctor(){} // RVA: 0x7ffaae49ef80
        public void .cctor(){} // RVA: 0x7ffaaf7c36f0
    }

    public class WorldMetadata : ValueType
    {
        // ── Original Methods ──
        public void CompareHash(){} // RVA: 0x7ffaaf7c3790
        public void ComputeHash(){} // RVA: 0x7ffaaf7c3900
        public void CollateObjectMetadata(){} // RVA: 0x7ffaaf7c3d40
        public void AreCompatible(){} // RVA: 0x7ffaaf7c3ee0
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_Hash(){} // RVA: 0x7ffaaf7c4260
        public void get_PlayerPersistenceGuid(){} // RVA: 0x7ffaaf7c4370
        public void PlayerPersistenceMetadatas(){} // RVA: 0x7ffaaf7c4480
        public void get_PlayerPersistenceMetadatasLength(){} // RVA: 0x7ffaaf7c45f0
        public void ObjectMetadatas(){} // RVA: 0x7ffaaf7c4660
        public void get_ObjectMetadatasLength(){} // RVA: 0x7ffaaf7bf990
        public void get_MaximumViewIDs(){} // RVA: 0x7ffaaf7c47d0
        public void MutateMaximumViewIDs(){} // RVA: 0x7ffaaf7c4820
        public void get_MinimumViewID(){} // RVA: 0x7ffaaf7c4880
        public void MutateMinimumViewID(){} // RVA: 0x7ffaaf7c48d0
        public void get_FirstPlayerPersistenceID(){} // RVA: 0x7ffaaf7c4930
        public void MutateFirstPlayerPersistenceID(){} // RVA: 0x7ffaaf7c4980
        public void get_MaxPlayerPersistenceID(){} // RVA: 0x7ffaaf7c49e0
        public void MutateMaxPlayerPersistenceID(){} // RVA: 0x7ffaaf7c4a30
        public void NetworkCallingViews(){} // RVA: 0x7ffaaf7c4a90
        public void get_NetworkCallingViewsLength(){} // RVA: 0x7ffaaf7c4c00
        public void CreateWorldMetadata(){} // RVA: 0x7ffaaf7c4c70
        public void StartWorldMetadata(){} // RVA: 0x7ffaaf7c5040
        public void AddHash(){} // RVA: 0x7ffaaf7c5060
        public void AddPlayerPersistenceGuid(){} // RVA: 0x7ffaaf7c5090
        public void AddPlayerPersistenceMetadatas(){} // RVA: 0x7ffaaf7c50c0
        public void CreatePlayerPersistenceMetadatasVector(){} // RVA: 0x7ffaaf7c00b0
        public void CreatePlayerPersistenceMetadatasVectorBlock(){} // RVA: 0x7ffaaf7c52a0
        public void CreatePlayerPersistenceMetadatasVectorBlock(){} // RVA: 0x7ffaaf7c52a0
        public void CreatePlayerPersistenceMetadatasVectorBlock(){} // RVA: 0x7ffaaf7c52a0
        public void StartPlayerPersistenceMetadatasVector(){} // RVA: 0x7ffaaf7c0470
        public void AddObjectMetadatas(){} // RVA: 0x7ffaaf7c0070
        public void CreateObjectMetadatasVector(){} // RVA: 0x7ffaaf7c00b0
        public void CreateObjectMetadatasVectorBlock(){} // RVA: 0x7ffaaf7c5500
        public void CreateObjectMetadatasVectorBlock(){} // RVA: 0x7ffaaf7c5500
        public void CreateObjectMetadatasVectorBlock(){} // RVA: 0x7ffaaf7c5500
        public void StartObjectMetadatasVector(){} // RVA: 0x7ffaaf7c0470
        public void AddMaximumViewIDs(){} // RVA: 0x7ffaaf7c55c0
        public void AddMinimumViewID(){} // RVA: 0x7ffaaf7c5630
        public void AddFirstPlayerPersistenceID(){} // RVA: 0x7ffaaf7c56a0
        public void AddMaxPlayerPersistenceID(){} // RVA: 0x7ffaaf7c5710
        public void AddNetworkCallingViews(){} // RVA: 0x7ffaaf7c5780
        public void CreateNetworkCallingViewsVector(){} // RVA: 0x7ffaaf7c00b0
        public void CreateNetworkCallingViewsVectorBlock(){} // RVA: 0x7ffaaf7c5a00
        public void CreateNetworkCallingViewsVectorBlock(){} // RVA: 0x7ffaaf7c5a00
        public void CreateNetworkCallingViewsVectorBlock(){} // RVA: 0x7ffaaf7c5a00
        public void StartNetworkCallingViewsVector(){} // RVA: 0x7ffaaf7c0470
        public void EndWorldMetadata(){} // RVA: 0x7ffaaf7c5ac0
        public void UnPack(){} // RVA: 0x7ffaaf7c5b10
        public void UnPackTo(){} // RVA: 0x7ffaaf7c5b80
        public void Pack(){} // RVA: 0x7ffaaf7c6390
        // ── Binary Analysis Named ──
        public void GetRootAsWorldMetadata(){} // RVA: 0x7ffaaf7bf5b0
        public void GetRootAsWorldMetadata(){} // RVA: 0x7ffaaf7bf5b0
    }

    public class WorldMetadataT : Object
    {
        public object _playerPersistenceMetadatas; // 0x33522250, was: <PlayerPersistenceMetadatas>k_
        public object _minimumViewID; // 0x33522250, was: <MinimumViewID>k__BackingField
        public object _networkCallingViews; // 0x33522250, was: <NetworkCallingViews>k__Backin
        public object Hash; // 0x170001E6
        public object PlayerPersistenceGuid; // 0x170001E7
        public object PlayerPersistenceMetadatas; // 0x170001E8

        // ── Original Methods ──
        public void CompareHash(){} // RVA: 0x7ffaaf7c6830
        public void ComputeHash(){} // RVA: 0x7ffaaf7c6a20
        public void CollateObjectMetadata(){} // RVA: 0x7ffaaf7c6f80
        public void AreCompatible(){} // RVA: 0x7ffaaf7c7000
        public void get_Hash(){} // RVA: 0x7ffaa894d380
        public void set_Hash(){} // RVA: 0x7ffaa8933e30
        public void get_PlayerPersistenceGuid(){} // RVA: 0x7ffaa89357c0
        public void set_PlayerPersistenceGuid(){} // RVA: 0x7ffaa8998e80
        public void get_PlayerPersistenceMetadatas(){} // RVA: 0x7ffaa89600c0
        public void set_PlayerPersistenceMetadatas(){} // RVA: 0x7ffaa89600d0
        public void get_ObjectMetadatas(){} // RVA: 0x7ffaa8960130
        public void set_ObjectMetadatas(){} // RVA: 0x7ffaa8933e90
        public void get_MaximumViewIDs(){} // RVA: 0x7ffaa898dcd0
        public void set_MaximumViewIDs(){} // RVA: 0x7ffaa898dce0
        public void get_MinimumViewID(){} // RVA: 0x7ffaa950c6d0
        public void set_MinimumViewID(){} // RVA: 0x7ffaa9b8cba0
        public void get_FirstPlayerPersistenceID(){} // RVA: 0x7ffaa8fb82b0
        public void set_FirstPlayerPersistenceID(){} // RVA: 0x7ffaa8fb82c0
        public void get_MaxPlayerPersistenceID(){} // RVA: 0x7ffaa8de7460
        public void set_MaxPlayerPersistenceID(){} // RVA: 0x7ffaaa1eabc0
        public void get_NetworkCallingViews(){} // RVA: 0x7ffaa89af740
        public void set_NetworkCallingViews(){} // RVA: 0x7ffaa895a200
        public void .ctor(){} // RVA: 0x7ffaaf7c7350
        public void <AreCompatible>g__MetadataCompatible|3_0(){} // RVA: 0x7ffaaf7c7580
    }

    public class WrappedLong : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_L(){} // RVA: 0x7ffaaf7dc1c0
        public void MutateL(){} // RVA: 0x7ffaaf7dc210
        public void CreateWrappedLong(){} // RVA: 0x7ffaaf7dc270
        public void StartWrappedLong(){} // RVA: 0x7ffaaf7c8b90
        public void AddL(){} // RVA: 0x7ffaaf7dc320
        public void EndWrappedLong(){} // RVA: 0x7ffaaf7dc390
        public void UnPack(){} // RVA: 0x7ffaaf7dc3e0
        public void UnPackTo(){} // RVA: 0x7ffaaf7dc480
        public void Pack(){} // RVA: 0x7ffaaf7dc4e0
        // ── Binary Analysis Named ──
        public void GetRootAsWrappedLong(){} // RVA: 0x7ffaaf7bf5b0
        public void GetRootAsWrappedLong(){} // RVA: 0x7ffaaf7bf5b0
    }

}