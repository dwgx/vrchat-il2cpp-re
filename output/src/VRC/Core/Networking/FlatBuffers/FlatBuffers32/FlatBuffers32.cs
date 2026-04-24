// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 22
// Methods: 672

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class DataStorage : ValueType
    {
        public AssignBinaryExpression.yptionAlgorithm ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsDataStorage(){} // RVA: 0x7FFD551BCB90 | overloaded x2
        public void VerifyDataStorage(){} // RVA: 0x7FFD551C7050
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void EntriesType(){} // RVA: 0x7FFD551C64D0
        public void get_EntriesTypeLength(){} // RVA: 0x7FFD551C6550
        public void GetEntriesTypeBytes(){} // RVA: 0x7FFD551C7140
        public void GetEntriesTypeArray(){} // RVA: 0x7FFD551C71B0
        public void Entries(){} // RVA: 0x7FFD4E2ADC40
        public void get_EntriesLength(){} // RVA: 0x7FFD551C72E0
        public void CreateDataStorage(){} // RVA: 0x7FFD551C7350
        public void StartDataStorage(){} // RVA: 0x7FFD551C7400
        public void AddEntriesType(){} // RVA: 0x7FFD551C6190
        public void CreateEntriesTypeVector(){} // RVA: 0x7FFD551C6790
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7FFD551C75D0 | overloaded x3
        public void StartEntriesTypeVector(){} // RVA: 0x7FFD551C6AE0
        public void AddEntries(){} // RVA: 0x7FFD551C7690
        public void CreateEntriesVector(){} // RVA: 0x7FFD551BD690
        public void CreateEntriesVectorBlock(){} // RVA: 0x7FFD551C7870 | overloaded x3
        public void StartEntriesVector(){} // RVA: 0x7FFD551BDA50
        public void EndDataStorage(){} // RVA: 0x7FFD551C7930
        public void FinishDataStorageBuffer(){} // RVA: 0x7FFD551C7980
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x7FFD551C79E0
        public void UnPack(){} // RVA: 0x7FFD551C7A00
        public void UnPackTo(){} // RVA: 0x7FFD551C7AB0
        public void Pack(){} // RVA: 0x7FFD551C81E0
    }

    public class DataStorageEntryUnion : Object
    {
        public h8.IsDeletedMember Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD4E40B5E0
        public void set_Type(){} // RVA: 0x7FFD4E40B5F0
        public void get_Value(){} // RVA: 0x7FFD4E3447C0
        public void set_Value(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD55194460
        public void As(){} // RVA: 0x7FFD4E2ADC40
        public void AsDataStorageBool(){} // RVA: 0x7FFD551C4D10
        public void FromDataStorageBool(){} // RVA: 0x7FFD551C4D50
        public void AsDataStorageInt(){} // RVA: 0x7FFD551C4E50
        public void FromDataStorageInt(){} // RVA: 0x7FFD551C4E90
        public void AsDataStorageFloat(){} // RVA: 0x7FFD551C4F90
        public void FromDataStorageFloat(){} // RVA: 0x7FFD551C4FD0
        public void AsDataStorageString(){} // RVA: 0x7FFD551C50D0
        public void FromDataStorageString(){} // RVA: 0x7FFD551C5110
        public void AsDataStorageBytes(){} // RVA: 0x7FFD551C5210
        public void FromDataStorageBytes(){} // RVA: 0x7FFD551C5250
        public void Pack(){} // RVA: 0x7FFD551C5350
    }

    public class ObjectMetadata : ValueType
    {
        public AssignBinaryExpression.yptionAlgorithm ByteBuffer; // 0x10

        // ── Methods ──
        public void ComputeHash(){} // RVA: 0x7FFD551BC0A0
        public void AreCompatible(){} // RVA: 0x7FFD551BC690
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsObjectMetadata(){} // RVA: 0x7FFD551BCB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_Is8Bit(){} // RVA: 0x7FFD551BCBF0
        public void MutateIs8Bit(){} // RVA: 0x7FFD551BCC40
        public void get_DoNotPersist(){} // RVA: 0x7FFD551BCCA0
        public void MutateDoNotPersist(){} // RVA: 0x7FFD551BCCF0
        public void get_Code(){} // RVA: 0x7FFD551BCD50
        public void MutateCode(){} // RVA: 0x7FFD551BCDA0
        public void ComponentInfo(){} // RVA: 0x7FFD551BCE00
        public void get_ComponentInfoLength(){} // RVA: 0x7FFD551BCF70
        public void Payload(){} // RVA: 0x7FFD551BCFE0
        public void get_PayloadLength(){} // RVA: 0x7FFD551BD150
        public void get_InitialPath(){} // RVA: 0x7FFD551BD1C0
        public void GetInitialPathBytes(){} // RVA: 0x7FFD551BD250
        public void GetInitialPathArray(){} // RVA: 0x7FFD551BD2C0
        public void CreateObjectMetadata(){} // RVA: 0x7FFD551BD310
        public void StartObjectMetadata(){} // RVA: 0x7FFD551BD4E0
        public void AddIs8Bit(){} // RVA: 0x7FFD551BD500
        public void AddDoNotPersist(){} // RVA: 0x7FFD551BD570
        public void AddCode(){} // RVA: 0x7FFD551BD5E0
        public void AddComponentInfo(){} // RVA: 0x7FFD551BD650
        public void CreateComponentInfoVector(){} // RVA: 0x7FFD551BD690
        public void CreateComponentInfoVectorBlock(){} // RVA: 0x7FFD551BD990 | overloaded x3
        public void StartComponentInfoVector(){} // RVA: 0x7FFD551BDA50
        public void AddPayload(){} // RVA: 0x7FFD551BDA80
        public void CreatePayloadVector(){} // RVA: 0x7FFD551BD690
        public void CreatePayloadVectorBlock(){} // RVA: 0x7FFD551BDD00 | overloaded x3
        public void StartPayloadVector(){} // RVA: 0x7FFD551BDA50
        public void AddInitialPath(){} // RVA: 0x7FFD551BDDC0
        public void EndObjectMetadata(){} // RVA: 0x7FFD551BDE00
        public void UnPack(){} // RVA: 0x7FFD551BDE50
        public void UnPackTo(){} // RVA: 0x7FFD551BDEC0
        public void Pack(){} // RVA: 0x7FFD551BE450
    }

    public class ObjectMetadataT : Object
    {
        public bool Is8Bit; // 0x10
        public bool DoNotPersist; // 0x11
        public byte Code; // 0x12
        public URA.woDigitYearMax<h8.<.cctor>b__7_10> ComponentInfo; // 0x18
        public URA.woDigitYearMax<h8.?> Payload; // 0x20
        public string InitialPath; // 0x28

        // ── Methods ──
        public void ComputeHash(){} // RVA: 0x7FFD551BE7C0
        public void AreCompatible(){} // RVA: 0x7FFD551BECA0
        public void get_Is8Bit(){} // RVA: 0x7FFD4E40B5E0
        public void set_Is8Bit(){} // RVA: 0x7FFD4E40B5F0
        public void get_DoNotPersist(){} // RVA: 0x7FFD4EB91DA0
        public void set_DoNotPersist(){} // RVA: 0x7FFD4EB91D90
        public void get_Code(){} // RVA: 0x7FFD4EF01A90
        public void set_Code(){} // RVA: 0x7FFD4F831DE0
        public void get_ComponentInfo(){} // RVA: 0x7FFD4E3447C0
        public void set_ComponentInfo(){} // RVA: 0x7FFD4E3A7E80
        public void get_Payload(){} // RVA: 0x7FFD4E36F0C0
        public void set_Payload(){} // RVA: 0x7FFD4E36F0D0
        public void get_InitialPath(){} // RVA: 0x7FFD4E36F130
        public void set_InitialPath(){} // RVA: 0x7FFD4E342E90
        public void .ctor(){} // RVA: 0x7FFD551BEF70
    }

    public class ObjectPool : ValueType
    {
        public AssignBinaryExpression.yptionAlgorithm ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsObjectPool(){} // RVA: 0x7FFD551BCB90 | overloaded x2
        public void VerifyObjectPool(){} // RVA: 0x7FFD551C8740
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void Data(){} // RVA: 0x7FFD551C64D0
        public void get_DataLength(){} // RVA: 0x7FFD551C6550
        public void GetDataBytes(){} // RVA: 0x7FFD551C8830
        public void GetDataArray(){} // RVA: 0x7FFD551C88A0
        public void MutateData(){} // RVA: 0x7FFD551C6680
        public void CreateObjectPool(){} // RVA: 0x7FFD551C88F0
        public void StartObjectPool(){} // RVA: 0x7FFD551C6170
        public void AddData(){} // RVA: 0x7FFD551C6190
        public void CreateDataVector(){} // RVA: 0x7FFD551C6790
        public void CreateDataVectorBlock(){} // RVA: 0x7FFD551C8B10 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFD551C6AE0
        public void EndObjectPool(){} // RVA: 0x7FFD551C8BD0
        public void FinishObjectPoolBuffer(){} // RVA: 0x7FFD551C7980
        public void FinishSizePrefixedObjectPoolBuffer(){} // RVA: 0x7FFD551C79E0
        public void UnPack(){} // RVA: 0x7FFD551C8C20
        public void UnPackTo(){} // RVA: 0x7FFD551C8CD0
        public void Pack(){} // RVA: 0x7FFD551C8EE0
    }

    public class PhysBoneGrab : ValueType
    {
        public AssignBinaryExpression.ectoryInformation ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_ChainIdA(){} // RVA: 0x7FFD551CEDC0
        public void MutateChainIdA(){} // RVA: 0x7FFD551CEDF0
        public void get_ChainIdB(){} // RVA: 0x7FFD551CEE20
        public void MutateChainIdB(){} // RVA: 0x7FFD551CEE50
        public void get_Bone(){} // RVA: 0x7FFD551CEE80
        public void MutateBone(){} // RVA: 0x7FFD551CEEB0
        public void get_Offset(){} // RVA: 0x7FFD551CEEE0
        public void CreatePhysBoneGrab(){} // RVA: 0x7FFD551CEF20
        public void UnPack(){} // RVA: 0x7FFD551CF0A0
        public void UnPackTo(){} // RVA: 0x7FFD551CF110
        public void Pack(){} // RVA: 0x7FFD551CF220
    }

    public class PlayerDataPair : ValueType
    {
        public AssignBinaryExpression.yptionAlgorithm ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsPlayerDataPair(){} // RVA: 0x7FFD551BCB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_Key(){} // RVA: 0x7FFD551C5FA0
        public void GetKeyBytes(){} // RVA: 0x7FFD551D3AF0
        public void GetKeyArray(){} // RVA: 0x7FFD551D3B60
        public void get_ValueType(){} // RVA: 0x7FFD551D3BB0
        public void Value(){} // RVA: 0x7FFD4E2ADC40
        public void ValueAsVector2(){} // RVA: 0x7FFD551D3C00
        public void ValueAsVector3(){} // RVA: 0x7FFD551D3C90
        public void ValueAsVector4(){} // RVA: 0x7FFD551D3D20
        public void ValueAsQuaternion(){} // RVA: 0x7FFD551D3DB0
        public void ValueAsColor(){} // RVA: 0x7FFD551D3E40
        public void ValueAsColor32(){} // RVA: 0x7FFD551D3ED0
        public void ValueAsWrappedString(){} // RVA: 0x7FFD551D3F60
        public void ValueAsWrappedShort(){} // RVA: 0x7FFD551D3FF0
        public void ValueAsWrappedInt(){} // RVA: 0x7FFD551D4080
        public void ValueAsWrappedFloat(){} // RVA: 0x7FFD551D4110
        public void ValueAsWrappedBool(){} // RVA: 0x7FFD551D41A0
        public void ValueAsWrappedByte(){} // RVA: 0x7FFD551D4230
        public void ValueAsWrappedBytes(){} // RVA: 0x7FFD551D42C0
        public void ValueAsWrappedUShort(){} // RVA: 0x7FFD551D4350
        public void ValueAsWrappedUByte(){} // RVA: 0x7FFD551D43E0
        public void ValueAsWrappedUInt(){} // RVA: 0x7FFD551D4470
        public void ValueAsWrappedULong(){} // RVA: 0x7FFD551D4500
        public void ValueAsWrappedDouble(){} // RVA: 0x7FFD551D4590
        public void ValueAsWrappedLong(){} // RVA: 0x7FFD551D4620
        public void CreatePlayerDataPair(){} // RVA: 0x7FFD551D46B0
        public void StartPlayerDataPair(){} // RVA: 0x7FFD551CD1E0
        public void AddKey(){} // RVA: 0x7FFD551C6190
        public void AddValueType(){} // RVA: 0x7FFD551D47C0
        public void AddValue(){} // RVA: 0x7FFD551C26A0
        public void EndPlayerDataPair(){} // RVA: 0x7FFD551D4830
        public void UnPack(){} // RVA: 0x7FFD551D4880
        public void UnPackTo(){} // RVA: 0x7FFD551D48F0
        public void Pack(){} // RVA: 0x7FFD551D5980
    }

    public class PlayerDataTypeUnion : Object
    {
        public h8.rDroneBuffer Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD4E40B5E0
        public void set_Type(){} // RVA: 0x7FFD4E40B5F0
        public void get_Value(){} // RVA: 0x7FFD4E3447C0
        public void set_Value(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD55194460
        public void As(){} // RVA: 0x7FFD4E2ADC40
        public void AsVector2(){} // RVA: 0x7FFD551D1660
        public void FromVector2(){} // RVA: 0x7FFD551D16A0
        public void AsVector3(){} // RVA: 0x7FFD551D17A0
        public void FromVector3(){} // RVA: 0x7FFD551D17E0
        public void AsVector4(){} // RVA: 0x7FFD551D18E0
        public void FromVector4(){} // RVA: 0x7FFD551D1920
        public void AsQuaternion(){} // RVA: 0x7FFD551D1A20
        public void FromQuaternion(){} // RVA: 0x7FFD551D1A60
        public void AsColor(){} // RVA: 0x7FFD551D1B60
        public void FromColor(){} // RVA: 0x7FFD551D1BA0
        public void AsColor32(){} // RVA: 0x7FFD551D1CA0
        public void FromColor32(){} // RVA: 0x7FFD551D1CE0
        public void AsWrappedString(){} // RVA: 0x7FFD551D1DE0
        public void FromWrappedString(){} // RVA: 0x7FFD551D1E20
        public void AsWrappedShort(){} // RVA: 0x7FFD551D1F20
        public void FromWrappedShort(){} // RVA: 0x7FFD551D1F60
        public void AsWrappedInt(){} // RVA: 0x7FFD551D2060
        public void FromWrappedInt(){} // RVA: 0x7FFD551D20A0
        public void AsWrappedFloat(){} // RVA: 0x7FFD551D21A0
        public void FromWrappedFloat(){} // RVA: 0x7FFD551D21E0
        public void AsWrappedBool(){} // RVA: 0x7FFD551D22E0
        public void FromWrappedBool(){} // RVA: 0x7FFD551D2320
        public void AsWrappedByte(){} // RVA: 0x7FFD551D2420
        public void FromWrappedByte(){} // RVA: 0x7FFD551D2460
        public void AsWrappedBytes(){} // RVA: 0x7FFD551D2560
        public void FromWrappedBytes(){} // RVA: 0x7FFD551D25A0
        public void AsWrappedUShort(){} // RVA: 0x7FFD551D26A0
        public void FromWrappedUShort(){} // RVA: 0x7FFD551D26E0
        public void AsWrappedUByte(){} // RVA: 0x7FFD551D27E0
        public void FromWrappedUByte(){} // RVA: 0x7FFD551D2820
        public void AsWrappedUInt(){} // RVA: 0x7FFD551D2920
        public void FromWrappedUInt(){} // RVA: 0x7FFD551D2960
        public void AsWrappedULong(){} // RVA: 0x7FFD551D2A60
        public void FromWrappedULong(){} // RVA: 0x7FFD551D2AA0
        public void AsWrappedDouble(){} // RVA: 0x7FFD551D2BA0
        public void FromWrappedDouble(){} // RVA: 0x7FFD551D2BE0
        public void AsWrappedLong(){} // RVA: 0x7FFD551D2CE0
        public void FromWrappedLong(){} // RVA: 0x7FFD551D2D20
        public void Pack(){} // RVA: 0x7FFD551D2E20
    }

    public class PlayerStationStateData : ValueType
    {
        public AssignBinaryExpression.yptionAlgorithm ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsPlayerStationStateData(){} // RVA: 0x7FFD551BCB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void ActiveStations(){} // RVA: 0x7FFD551D6870
        public void get_ActiveStationsLength(){} // RVA: 0x7FFD551C6550
        public void GetActiveStationsBytes(){} // RVA: 0x7FFD551D68F0
        public void GetActiveStationsArray(){} // RVA: 0x7FFD551D6960
        public void MutateActiveStations(){} // RVA: 0x7FFD551D69B0
        public void CreatePlayerStationStateData(){} // RVA: 0x7FFD551D6A40
        public void StartPlayerStationStateData(){} // RVA: 0x7FFD551C6170
        public void AddActiveStations(){} // RVA: 0x7FFD551C6190
        public void CreateActiveStationsVector(){} // RVA: 0x7FFD551CA810
        public void CreateActiveStationsVectorBlock(){} // RVA: 0x7FFD551D6C60 | overloaded x3
        public void StartActiveStationsVector(){} // RVA: 0x7FFD551BDA50
        public void EndPlayerStationStateData(){} // RVA: 0x7FFD551D6D20
        public void UnPack(){} // RVA: 0x7FFD551D6D70
        public void UnPackTo(){} // RVA: 0x7FFD551D6E20
        public void Pack(){} // RVA: 0x7FFD551D7040
    }

    public class QuaternionT : Object
    {
        public float identity; // 0x10
        public float magnitude; // 0x14
        public float sqrMagnitude; // 0x18
        public float X; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55192C50 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFD551922D0
        public void ToNumerics(){} // RVA: 0x7FFD55192300
        public void get_identity(){} // RVA: 0x7FFD551BF080
        public void get_magnitude(){} // RVA: 0x7FFD551BF0D0
        public void get_sqrMagnitude(){} // RVA: 0x7FFD55192420
        public void Slerp(){} // RVA: 0x7FFD551BF180
        public void op_Multiply(){} // RVA: 0x7FFD551BF260
        public void IsBad(){} // RVA: 0x7FFD55192880
        public void Normalize(){} // RVA: 0x7FFD551BF410
        public void get_X(){} // RVA: 0x7FFD4E46B320
        public void set_X(){} // RVA: 0x7FFD4E46B330
        public void get_Y(){} // RVA: 0x7FFD4E46B340
        public void set_Y(){} // RVA: 0x7FFD4E46B350
        public void get_Z(){} // RVA: 0x7FFD4E345CF0
        public void set_Z(){} // RVA: 0x7FFD4E35C4D0
        public void get_W(){} // RVA: 0x7FFD4E40E570
        public void set_W(){} // RVA: 0x7FFD4E40E580
    }

    public class SerializedObjects : ValueType
    {
        public AssignBinaryExpression.yptionAlgorithm ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsSerializedObjects(){} // RVA: 0x7FFD551BCB90 | overloaded x2
        public void VerifySerializedObjects(){} // RVA: 0x7FFD551D8100
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void ObjectsType(){} // RVA: 0x7FFD551C64D0
        public void get_ObjectsTypeLength(){} // RVA: 0x7FFD551C6550
        public void GetObjectsTypeBytes(){} // RVA: 0x7FFD551D81F0
        public void GetObjectsTypeArray(){} // RVA: 0x7FFD551D8260
        public void Objects(){} // RVA: 0x7FFD4E2ADC40
        public void get_ObjectsLength(){} // RVA: 0x7FFD551C72E0
        public void CreateSerializedObjects(){} // RVA: 0x7FFD551D8390
        public void StartSerializedObjects(){} // RVA: 0x7FFD551C7400
        public void AddObjectsType(){} // RVA: 0x7FFD551C6190
        public void CreateObjectsTypeVector(){} // RVA: 0x7FFD551C6790
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7FFD551D85F0 | overloaded x3
        public void StartObjectsTypeVector(){} // RVA: 0x7FFD551C6AE0
        public void AddObjects(){} // RVA: 0x7FFD551C7690
        public void CreateObjectsVector(){} // RVA: 0x7FFD551BD690
        public void CreateObjectsVectorBlock(){} // RVA: 0x7FFD551D8850 | overloaded x3
        public void StartObjectsVector(){} // RVA: 0x7FFD551BDA50
        public void EndSerializedObjects(){} // RVA: 0x7FFD551D8910
        public void FinishSerializedObjectsBuffer(){} // RVA: 0x7FFD551C7980
        public void FinishSizePrefixedSerializedObjectsBuffer(){} // RVA: 0x7FFD551C79E0
        public void UnPack(){} // RVA: 0x7FFD551D8960
        public void UnPackTo(){} // RVA: 0x7FFD551D8A10
        public void Pack(){} // RVA: 0x7FFD551D9240
    }

    public class SerializedTypeUnion : Object
    {
        public h8.serOnly Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD4E40B5E0
        public void set_Type(){} // RVA: 0x7FFD4E40B5F0
        public void get_Value(){} // RVA: 0x7FFD4E3447C0
        public void set_Value(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD55194460
        public void As(){} // RVA: 0x7FFD4E2ADC40
        public void AsSyncPlayable(){} // RVA: 0x7FFD551D71A0
        public void FromSyncPlayable(){} // RVA: 0x7FFD551D71E0
        public void AsDataStorage(){} // RVA: 0x7FFD551D72E0
        public void FromDataStorage(){} // RVA: 0x7FFD551D7320
        public void AsUdon(){} // RVA: 0x7FFD551D7420
        public void FromUdon(){} // RVA: 0x7FFD551D7460
        public void AsObjectPool(){} // RVA: 0x7FFD551D7560
        public void FromObjectPool(){} // RVA: 0x7FFD551D75A0
        public void AsPlayerStationStateData(){} // RVA: 0x7FFD551D76A0
        public void FromPlayerStationStateData(){} // RVA: 0x7FFD551D76E0
        public void AsPhysBoneRecorder(){} // RVA: 0x7FFD551D77E0
        public void FromPhysBoneRecorder(){} // RVA: 0x7FFD551D7820
        public void AsPlayerData(){} // RVA: 0x7FFD551D7920
        public void FromPlayerData(){} // RVA: 0x7FFD551D7960
        public void Pack(){} // RVA: 0x7FFD551D7A60
    }

    public class SparseSerializedObjects : ValueType
    {
        public AssignBinaryExpression.yptionAlgorithm ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x7FFD551BCB90 | overloaded x2
        public void VerifySparseSerializedObjects(){} // RVA: 0x7FFD551DE9A0
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_Objects(){} // RVA: 0x7FFD551DEA90
        public void Bitmap(){} // RVA: 0x7FFD551DEBC0
        public void get_BitmapLength(){} // RVA: 0x7FFD551C72E0
        public void GetBitmapBytes(){} // RVA: 0x7FFD551DEC40
        public void GetBitmapArray(){} // RVA: 0x7FFD551DECB0
        public void MutateBitmap(){} // RVA: 0x7FFD551DED00
        public void CreateSparseSerializedObjects(){} // RVA: 0x7FFD551DED90
        public void StartSparseSerializedObjects(){} // RVA: 0x7FFD551C7400
        public void AddObjects(){} // RVA: 0x7FFD551C6190
        public void AddBitmap(){} // RVA: 0x7FFD551C7690
        public void CreateBitmapVector(){} // RVA: 0x7FFD551C6790
        public void CreateBitmapVectorBlock(){} // RVA: 0x7FFD551DEFE0 | overloaded x3
        public void StartBitmapVector(){} // RVA: 0x7FFD551C6AE0
        public void EndSparseSerializedObjects(){} // RVA: 0x7FFD551DF0A0
        public void FinishSparseSerializedObjectsBuffer(){} // RVA: 0x7FFD551C7980
        public void FinishSizePrefixedSparseSerializedObjectsBuffer(){} // RVA: 0x7FFD551C79E0
        public void UnPack(){} // RVA: 0x7FFD551DF0F0
        public void UnPackTo(){} // RVA: 0x7FFD551DF200
        public void Pack(){} // RVA: 0x7FFD551DF520
    }

    public class SyncPlayable : ValueType
    {
        public AssignBinaryExpression.yptionAlgorithm ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsSyncPlayable(){} // RVA: 0x7FFD551BCB90 | overloaded x2
        public void VerifySyncPlayable(){} // RVA: 0x7FFD551DF940
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_StageParamsOffset(){} // RVA: 0x7FFD551CA050
        public void MutateStageParamsOffset(){} // RVA: 0x7FFD551CA0A0
        public void get_Puppet(){} // RVA: 0x7FFD551DFA30
        public void get_AvatarDiscriminator(){} // RVA: 0x7FFD551DFB40
        public void MutateAvatarDiscriminator(){} // RVA: 0x7FFD551DFB90
        public void CreateSyncPlayable(){} // RVA: 0x7FFD551DFBF0
        public void StartSyncPlayable(){} // RVA: 0x7FFD551CD1E0
        public void AddStageParamsOffset(){} // RVA: 0x7FFD551CA730
        public void AddPuppet(){} // RVA: 0x7FFD551C2670
        public void AddAvatarDiscriminator(){} // RVA: 0x7FFD551DFD40
        public void EndSyncPlayable(){} // RVA: 0x7FFD551DFDB0
        public void FinishSyncPlayableBuffer(){} // RVA: 0x7FFD551C7980
        public void FinishSizePrefixedSyncPlayableBuffer(){} // RVA: 0x7FFD551C79E0
        public void UnPack(){} // RVA: 0x7FFD551DFE00
        public void UnPackTo(){} // RVA: 0x7FFD551DFF00
        public void Pack(){} // RVA: 0x7FFD551E00E0
    }

    public class Udon : ValueType
    {
        public AssignBinaryExpression.yptionAlgorithm ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsUdon(){} // RVA: 0x7FFD551BCB90 | overloaded x2
        public void VerifyUdon(){} // RVA: 0x7FFD551EFB40
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void DataType(){} // RVA: 0x7FFD551C64D0
        public void get_DataTypeLength(){} // RVA: 0x7FFD551C6550
        public void GetDataTypeBytes(){} // RVA: 0x7FFD551EFC30
        public void GetDataTypeArray(){} // RVA: 0x7FFD551EFCA0
        public void Data(){} // RVA: 0x7FFD4E2ADC40
        public void get_DataLength(){} // RVA: 0x7FFD551C72E0
        public void CreateUdon(){} // RVA: 0x7FFD551EFDD0
        public void StartUdon(){} // RVA: 0x7FFD551C7400
        public void AddDataType(){} // RVA: 0x7FFD551C6190
        public void CreateDataTypeVector(){} // RVA: 0x7FFD551C6790
        public void CreateDataTypeVectorBlock(){} // RVA: 0x7FFD551F0030 | overloaded x3
        public void StartDataTypeVector(){} // RVA: 0x7FFD551C6AE0
        public void AddData(){} // RVA: 0x7FFD551C7690
        public void CreateDataVector(){} // RVA: 0x7FFD551BD690
        public void CreateDataVectorBlock(){} // RVA: 0x7FFD551F0290 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFD551BDA50
        public void EndUdon(){} // RVA: 0x7FFD551F0350
        public void FinishUdonBuffer(){} // RVA: 0x7FFD551C7980
        public void FinishSizePrefixedUdonBuffer(){} // RVA: 0x7FFD551C79E0
        public void UnPack(){} // RVA: 0x7FFD551F03A0
        public void UnPackTo(){} // RVA: 0x7FFD551F0450
        public void Pack(){} // RVA: 0x7FFD551F2410
    }

    public class UdonInfo : ValueType
    {
        public AssignBinaryExpression.yptionAlgorithm ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsUdonInfo(){} // RVA: 0x7FFD551BCB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void Names(){} // RVA: 0x7FFD551C9180
        public void get_NamesLength(){} // RVA: 0x7FFD551C6550
        public void Types(){} // RVA: 0x7FFD551C9250
        public void get_TypesLength(){} // RVA: 0x7FFD551C72E0
        public void CreateUdonInfo(){} // RVA: 0x7FFD551C9320
        public void StartUdonInfo(){} // RVA: 0x7FFD551C7400
        public void AddNames(){} // RVA: 0x7FFD551C6190
        public void CreateNamesVector(){} // RVA: 0x7FFD551BD690
        public void CreateNamesVectorBlock(){} // RVA: 0x7FFD551C9570 | overloaded x3
        public void StartNamesVector(){} // RVA: 0x7FFD551BDA50
        public void AddTypes(){} // RVA: 0x7FFD551C7690
        public void CreateTypesVector(){} // RVA: 0x7FFD551BD690
        public void CreateTypesVectorBlock(){} // RVA: 0x7FFD551C97D0 | overloaded x3
        public void StartTypesVector(){} // RVA: 0x7FFD551BDA50
        public void EndUdonInfo(){} // RVA: 0x7FFD551C9890
        public void UnPack(){} // RVA: 0x7FFD551C98E0
        public void UnPackTo(){} // RVA: 0x7FFD551C9950
        public void Pack(){} // RVA: 0x7FFD551C9C40
    }

    public class UdonValueUnion : Object
    {
        public h8.s Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD4E40B5E0
        public void set_Type(){} // RVA: 0x7FFD4E40B5F0
        public void get_Value(){} // RVA: 0x7FFD4E3447C0
        public void set_Value(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD55194460
        public void As(){} // RVA: 0x7FFD4E2ADC40
        public void AsUdonShort(){} // RVA: 0x7FFD551E05C0
        public void FromUdonShort(){} // RVA: 0x7FFD551E0600
        public void AsUdonUShort(){} // RVA: 0x7FFD551E0700
        public void FromUdonUShort(){} // RVA: 0x7FFD551E0740
        public void AsUdonChar(){} // RVA: 0x7FFD551E0840
        public void FromUdonChar(){} // RVA: 0x7FFD551E0880
        public void AsUdonByte(){} // RVA: 0x7FFD551E0980
        public void FromUdonByte(){} // RVA: 0x7FFD551E09C0
        public void AsUdonUByte(){} // RVA: 0x7FFD551E0AC0
        public void FromUdonUByte(){} // RVA: 0x7FFD551E0B00
        public void AsUdonLong(){} // RVA: 0x7FFD551E0C00
        public void FromUdonLong(){} // RVA: 0x7FFD551E0C40
        public void AsUdonULong(){} // RVA: 0x7FFD551E0D40
        public void FromUdonULong(){} // RVA: 0x7FFD551E0D80
        public void AsUdonDouble(){} // RVA: 0x7FFD551E0E80
        public void FromUdonDouble(){} // RVA: 0x7FFD551E0EC0
        public void AsUdonBool(){} // RVA: 0x7FFD551E0FC0
        public void FromUdonBool(){} // RVA: 0x7FFD551E1000
        public void AsUdonFloat(){} // RVA: 0x7FFD551E1100
        public void FromUdonFloat(){} // RVA: 0x7FFD551E1140
        public void AsUdonInt(){} // RVA: 0x7FFD551E1240
        public void FromUdonInt(){} // RVA: 0x7FFD551E1280
        public void AsUdonUInt(){} // RVA: 0x7FFD551E1380
        public void FromUdonUInt(){} // RVA: 0x7FFD551E13C0
        public void AsVector2(){} // RVA: 0x7FFD551E14C0
        public void FromVector2(){} // RVA: 0x7FFD551E1500
        public void AsVector3(){} // RVA: 0x7FFD551E1600
        public void FromVector3(){} // RVA: 0x7FFD551E1640
        public void AsVector4(){} // RVA: 0x7FFD551E1740
        public void FromVector4(){} // RVA: 0x7FFD551E1780
        public void AsQuaternion(){} // RVA: 0x7FFD551E1880
        public void FromQuaternion(){} // RVA: 0x7FFD551E18C0
        public void AsColor(){} // RVA: 0x7FFD551E19C0
        public void FromColor(){} // RVA: 0x7FFD551E1A00
        public void AsColor32(){} // RVA: 0x7FFD551E1B00
        public void FromColor32(){} // RVA: 0x7FFD551E1B40
        public void AsUdonShortArray(){} // RVA: 0x7FFD551E1C40
        public void FromUdonShortArray(){} // RVA: 0x7FFD551E1C80
        public void AsUdonUShortArray(){} // RVA: 0x7FFD551E1D80
        public void FromUdonUShortArray(){} // RVA: 0x7FFD551E1DC0
        public void AsUdonCharArray(){} // RVA: 0x7FFD551E1EC0
        public void FromUdonCharArray(){} // RVA: 0x7FFD551E1F00
        public void AsUdonByteArray(){} // RVA: 0x7FFD551E2000
        public void FromUdonByteArray(){} // RVA: 0x7FFD551E2040
        public void AsUdonUByteArray(){} // RVA: 0x7FFD551E2140
        public void FromUdonUByteArray(){} // RVA: 0x7FFD551E2180
        public void AsUdonLongArray(){} // RVA: 0x7FFD551E2280
        public void FromUdonLongArray(){} // RVA: 0x7FFD551E22C0
        public void AsUdonULongArray(){} // RVA: 0x7FFD551E23C0
        public void FromUdonULongArray(){} // RVA: 0x7FFD551E2400
        public void AsUdonDoubleArray(){} // RVA: 0x7FFD551E2500
        public void FromUdonDoubleArray(){} // RVA: 0x7FFD551E2540
        public void AsUdonBoolArray(){} // RVA: 0x7FFD551E2640
        public void FromUdonBoolArray(){} // RVA: 0x7FFD551E2680
        public void AsUdonFloatArray(){} // RVA: 0x7FFD551E2780
        public void FromUdonFloatArray(){} // RVA: 0x7FFD551E27C0
        public void AsUdonIntArray(){} // RVA: 0x7FFD551E28C0
        public void FromUdonIntArray(){} // RVA: 0x7FFD551E2900
        public void AsUdonUIntArray(){} // RVA: 0x7FFD551E2A00
        public void FromUdonUIntArray(){} // RVA: 0x7FFD551E2A40
        public void AsVector2Array(){} // RVA: 0x7FFD551E2B40
        public void FromVector2Array(){} // RVA: 0x7FFD551E2B80
        public void AsVector3Array(){} // RVA: 0x7FFD551E2C80
        public void FromVector3Array(){} // RVA: 0x7FFD551E2CC0
        public void AsVector4Array(){} // RVA: 0x7FFD551E2DC0
        public void FromVector4Array(){} // RVA: 0x7FFD551E2E00
        public void AsQuaternionArray(){} // RVA: 0x7FFD551E2F00
        public void FromQuaternionArray(){} // RVA: 0x7FFD551E2F40
        public void AsColorArray(){} // RVA: 0x7FFD551E3040
        public void FromColorArray(){} // RVA: 0x7FFD551E3080
        public void AsColor32Array(){} // RVA: 0x7FFD551E3180
        public void FromColor32Array(){} // RVA: 0x7FFD551E31C0
        public void AsUdonString(){} // RVA: 0x7FFD551E32C0
        public void FromUdonString(){} // RVA: 0x7FFD551E3300
        public void Pack(){} // RVA: 0x7FFD551E3400
    }

    public class Vector2T : Object
    {
        public float zero; // 0x10
        public float magnitude; // 0x14

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x7FFD50C943D0
        public void get_zero(){} // RVA: 0x7FFD551BF5A0
        public void .ctor(){} // RVA: 0x7FFD53DFB450 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFD55192CA0
        public void op_UnaryNegation(){} // RVA: 0x7FFD551BF5E0
        public void get_magnitude(){} // RVA: 0x7FFD551BF650
        public void get_sqrMagnitude(){} // RVA: 0x7FFD55192DD0
        public void op_Multiply(){} // RVA: 0x7FFD551BF860 | overloaded x4
        public void op_Division(){} // RVA: 0x7FFD551BF960 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFD551BFAE0 | overloaded x3
        public void op_Subtraction(){} // RVA: 0x7FFD551BFC60 | overloaded x3
        public void LerpUnclamped(){} // RVA: 0x7FFD551BFCE0
        public void Lerp(){} // RVA: 0x7FFD551BFDE0
        public void IsBad(){} // RVA: 0x7FFD551936D0
        public void get_X(){} // RVA: 0x7FFD4E46B320
        public void set_X(){} // RVA: 0x7FFD4E46B330
        public void get_Y(){} // RVA: 0x7FFD4E46B340
        public void set_Y(){} // RVA: 0x7FFD4E46B350
    }

    public class Vector3T : Object
    {
        public h8.eteValue magnitude;
        public float sqrMagnitude; // 0x10
        public float X; // 0x14
        public float Y; // 0x18

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x7FFD4EB56D20
        public void .ctor(){} // RVA: 0x7FFD53E9DD60 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFD55193780
        public void get_magnitude(){} // RVA: 0x7FFD551BFFC0
        public void get_sqrMagnitude(){} // RVA: 0x7FFD55193850
        public void op_Multiply(){} // RVA: 0x7FFD551C0450 | overloaded x4
        public void op_UnaryNegation(){} // RVA: 0x7FFD551C00F0
        public void op_Division(){} // RVA: 0x7FFD551C0380 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFD551C0680 | overloaded x3
        public void op_Subtraction(){} // RVA: 0x7FFD551C08C0 | overloaded x3
        public void LerpUnclamped(){} // RVA: 0x7FFD551C0950
        public void Lerp(){} // RVA: 0x7FFD551C0A80
        public void IsBad(){} // RVA: 0x7FFD551942E0
        public void get_X(){} // RVA: 0x7FFD4E46B320
        public void set_X(){} // RVA: 0x7FFD4E46B330
        public void get_Y(){} // RVA: 0x7FFD4E46B340
        public void set_Y(){} // RVA: 0x7FFD4E46B350
        public void get_Z(){} // RVA: 0x7FFD4E345CF0
        public void set_Z(){} // RVA: 0x7FFD4E35C4D0
        public void .cctor(){} // RVA: 0x7FFD551C0CD0
    }

    public class WorldMetadata : ValueType
    {
        public AssignBinaryExpression.yptionAlgorithm ByteBuffer; // 0x10

        // ── Methods ──
        public void CompareHash(){} // RVA: 0x7FFD551C0D70
        public void ComputeHash(){} // RVA: 0x7FFD551C0EE0
        public void CollateObjectMetadata(){} // RVA: 0x7FFD551C1320
        public void AreCompatible(){} // RVA: 0x7FFD551C14C0
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsWorldMetadata(){} // RVA: 0x7FFD551BCB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_Hash(){} // RVA: 0x7FFD551C1840
        public void get_PlayerPersistenceGuid(){} // RVA: 0x7FFD551C1950
        public void PlayerPersistenceMetadatas(){} // RVA: 0x7FFD551C1A60
        public void get_PlayerPersistenceMetadatasLength(){} // RVA: 0x7FFD551C1BD0
        public void ObjectMetadatas(){} // RVA: 0x7FFD551C1C40
        public void get_ObjectMetadatasLength(){} // RVA: 0x7FFD551BCF70
        public void get_MaximumViewIDs(){} // RVA: 0x7FFD551C1DB0
        public void MutateMaximumViewIDs(){} // RVA: 0x7FFD551C1E00
        public void get_MinimumViewID(){} // RVA: 0x7FFD551C1E60
        public void MutateMinimumViewID(){} // RVA: 0x7FFD551C1EB0
        public void get_FirstPlayerPersistenceID(){} // RVA: 0x7FFD551C1F10
        public void MutateFirstPlayerPersistenceID(){} // RVA: 0x7FFD551C1F60
        public void get_MaxPlayerPersistenceID(){} // RVA: 0x7FFD551C1FC0
        public void MutateMaxPlayerPersistenceID(){} // RVA: 0x7FFD551C2010
        public void NetworkCallingViews(){} // RVA: 0x7FFD551C2070
        public void get_NetworkCallingViewsLength(){} // RVA: 0x7FFD551C21E0
        public void CreateWorldMetadata(){} // RVA: 0x7FFD551C2250
        public void StartWorldMetadata(){} // RVA: 0x7FFD551C2620
        public void AddHash(){} // RVA: 0x7FFD551C2640
        public void AddPlayerPersistenceGuid(){} // RVA: 0x7FFD551C2670
        public void AddPlayerPersistenceMetadatas(){} // RVA: 0x7FFD551C26A0
        public void CreatePlayerPersistenceMetadatasVector(){} // RVA: 0x7FFD551BD690
        public void CreatePlayerPersistenceMetadatasVectorBlock(){} // RVA: 0x7FFD551C2880 | overloaded x3
        public void StartPlayerPersistenceMetadatasVector(){} // RVA: 0x7FFD551BDA50
        public void AddObjectMetadatas(){} // RVA: 0x7FFD551BD650
        public void CreateObjectMetadatasVector(){} // RVA: 0x7FFD551BD690
        public void CreateObjectMetadatasVectorBlock(){} // RVA: 0x7FFD551C2AE0 | overloaded x3
        public void StartObjectMetadatasVector(){} // RVA: 0x7FFD551BDA50
        public void AddMaximumViewIDs(){} // RVA: 0x7FFD551C2BA0
        public void AddMinimumViewID(){} // RVA: 0x7FFD551C2C10
        public void AddFirstPlayerPersistenceID(){} // RVA: 0x7FFD551C2C80
        public void AddMaxPlayerPersistenceID(){} // RVA: 0x7FFD551C2CF0
        public void AddNetworkCallingViews(){} // RVA: 0x7FFD551C2D60
        public void CreateNetworkCallingViewsVector(){} // RVA: 0x7FFD551BD690
        public void CreateNetworkCallingViewsVectorBlock(){} // RVA: 0x7FFD551C2FE0 | overloaded x3
        public void StartNetworkCallingViewsVector(){} // RVA: 0x7FFD551BDA50
        public void EndWorldMetadata(){} // RVA: 0x7FFD551C30A0
        public void UnPack(){} // RVA: 0x7FFD551C30F0
        public void UnPackTo(){} // RVA: 0x7FFD551C3160
        public void Pack(){} // RVA: 0x7FFD551C3970
    }

    public class WorldMetadataT : Object
    {
        public h8.omObjectPool Hash; // 0x10
        public h8.er PlayerPersistenceGuid; // 0x18
        public URA.woDigitYearMax<h8.ay8> PlayerPersistenceMetadatas; // 0x20
        public URA.woDigitYearMax<h8.ay8> ObjectMetadatas; // 0x28
        public int MaximumViewIDs; // 0x30
        public int MinimumViewID; // 0x34
        public int FirstPlayerPersistenceID; // 0x38
        public int MaxPlayerPersistenceID; // 0x3C
        public URA.woDigitYearMax<h8.otAsDataStorage> NetworkCallingViews; // 0x40

        // ── Methods ──
        public void CompareHash(){} // RVA: 0x7FFD551C3E10
        public void ComputeHash(){} // RVA: 0x7FFD551C4000
        public void CollateObjectMetadata(){} // RVA: 0x7FFD551C4560
        public void AreCompatible(){} // RVA: 0x7FFD551C45E0
        public void get_Hash(){} // RVA: 0x7FFD4E35C380
        public void set_Hash(){} // RVA: 0x7FFD4E342E30
        public void get_PlayerPersistenceGuid(){} // RVA: 0x7FFD4E3447C0
        public void set_PlayerPersistenceGuid(){} // RVA: 0x7FFD4E3A7E80
        public void get_PlayerPersistenceMetadatas(){} // RVA: 0x7FFD4E36F0C0
        public void set_PlayerPersistenceMetadatas(){} // RVA: 0x7FFD4E36F0D0
        public void get_ObjectMetadatas(){} // RVA: 0x7FFD4E36F130
        public void set_ObjectMetadatas(){} // RVA: 0x7FFD4E342E90
        public void get_MaximumViewIDs(){} // RVA: 0x7FFD4E39CCD0
        public void set_MaximumViewIDs(){} // RVA: 0x7FFD4E39CCE0
        public void get_MinimumViewID(){} // RVA: 0x7FFD4EEFEDC0
        public void set_MinimumViewID(){} // RVA: 0x7FFD4F58A6E0
        public void get_FirstPlayerPersistenceID(){} // RVA: 0x7FFD4E9AA870
        public void set_FirstPlayerPersistenceID(){} // RVA: 0x7FFD4E9A8350
        public void get_MaxPlayerPersistenceID(){} // RVA: 0x7FFD4E7DD4A0
        public void set_MaxPlayerPersistenceID(){} // RVA: 0x7FFD4FC02CD0
        public void get_NetworkCallingViews(){} // RVA: 0x7FFD4E3BE740
        public void set_NetworkCallingViews(){} // RVA: 0x7FFD4E369200
        public void .ctor(){} // RVA: 0x7FFD551C4930
        public void <AreCompatible>g__MetadataCompatible|3_0(){} // RVA: 0x7FFD551C4B60
    }

    public class WrappedLong : ValueType
    {
        public AssignBinaryExpression.yptionAlgorithm ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsWrappedLong(){} // RVA: 0x7FFD551BCB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_L(){} // RVA: 0x7FFD551D97A0
        public void MutateL(){} // RVA: 0x7FFD551D97F0
        public void CreateWrappedLong(){} // RVA: 0x7FFD551D9850
        public void StartWrappedLong(){} // RVA: 0x7FFD551C6170
        public void AddL(){} // RVA: 0x7FFD551D9900
        public void EndWrappedLong(){} // RVA: 0x7FFD551D9970
        public void UnPack(){} // RVA: 0x7FFD551D99C0
        public void UnPackTo(){} // RVA: 0x7FFD551D9A60
        public void Pack(){} // RVA: 0x7FFD551D9AC0
    }

}