// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 12
// Methods: 156

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class ObjectBunch : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsObjectBunch(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Time(){} // RVA: 0x7FFAC9DAA050
        public void MutateTime(){} // RVA: 0x7FFAC9DAA0A0
        public void get_Sender(){} // RVA: 0x7FFAC9DAA100
        public void MutateSender(){} // RVA: 0x7FFAC9DAA150
        public void get_Index(){} // RVA: 0x7FFAC9D9CD50
        public void MutateIndex(){} // RVA: 0x7FFAC9D9CDA0
        public void Data(){} // RVA: 0x7FFAC9DAB4D0
        public void get_DataLength(){} // RVA: 0x7FFAC9D9CF70
        public void GetDataBytes(){} // RVA: 0x7FFAC9DAB550
        public void GetDataArray(){} // RVA: 0x7FFAC9DAB5C0
        public void MutateData(){} // RVA: 0x7FFAC9DAB610
        public void CreateObjectBunch(){} // RVA: 0x7FFAC9DAB6A0
        public void StartObjectBunch(){} // RVA: 0x7FFAC9DAB830
        public void AddTime(){} // RVA: 0x7FFAC9DAA730
        public void AddSender(){} // RVA: 0x7FFAC9DAA7A0
        public void AddIndex(){} // RVA: 0x7FFAC9D9D5E0
        public void AddData(){} // RVA: 0x7FFAC9D9D650
        public void CreateDataVector(){} // RVA: 0x7FFAC9DA6790
        public void CreateDataVectorBlock(){} // RVA: 0x7FFAC9DAB9F0 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFAC9DA6AE0
        public void EndObjectBunch(){} // RVA: 0x7FFAC9DABAB0
        public void UnPack(){} // RVA: 0x7FFAC9DABB00
        public void UnPackTo(){} // RVA: 0x7FFAC9DABBB0
        public void Pack(){} // RVA: 0x7FFAC9DABE60
    }

    public class ObjectBunchT : Object
    {
        public int Time; // 0x10
        public int Sender; // 0x14
        public byte Index; // 0x18
        public System.Collections.Generic.List`1<byte> Data; // 0x20

        // ── Methods ──
        public void get_Time(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Time(){} // RVA: 0x7FFAC2F240C0
        public void get_Sender(){} // RVA: 0x7FFAC33D5A20
        public void set_Sender(){} // RVA: 0x7FFAC33D4990
        public void get_Index(){} // RVA: 0x7FFAC2F3C4E0
        public void set_Index(){} // RVA: 0x7FFAC2F3C4F0
        public void get_Data(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Data(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC9DABFD0
    }

    public class ObjectBunchVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DAC030
    }

    public class ObjectMetadata : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void ComputeHash(){} // RVA: 0x7FFAC9D9C0A0
        public void AreCompatible(){} // RVA: 0x7FFAC9D9C690
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsObjectMetadata(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Is8Bit(){} // RVA: 0x7FFAC9D9CBF0
        public void MutateIs8Bit(){} // RVA: 0x7FFAC9D9CC40
        public void get_DoNotPersist(){} // RVA: 0x7FFAC9D9CCA0
        public void MutateDoNotPersist(){} // RVA: 0x7FFAC9D9CCF0
        public void get_Code(){} // RVA: 0x7FFAC9D9CD50
        public void MutateCode(){} // RVA: 0x7FFAC9D9CDA0
        public void ComponentInfo(){} // RVA: 0x7FFAC9D9CE00
        public void get_ComponentInfoLength(){} // RVA: 0x7FFAC9D9CF70
        public void Payload(){} // RVA: 0x7FFAC9D9CFE0
        public void get_PayloadLength(){} // RVA: 0x7FFAC9D9D150
        public void get_InitialPath(){} // RVA: 0x7FFAC9D9D1C0
        public void GetInitialPathBytes(){} // RVA: 0x7FFAC9D9D250
        public void GetInitialPathArray(){} // RVA: 0x7FFAC9D9D2C0
        public void CreateObjectMetadata(){} // RVA: 0x7FFAC9D9D310
        public void StartObjectMetadata(){} // RVA: 0x7FFAC9D9D4E0
        public void AddIs8Bit(){} // RVA: 0x7FFAC9D9D500
        public void AddDoNotPersist(){} // RVA: 0x7FFAC9D9D570
        public void AddCode(){} // RVA: 0x7FFAC9D9D5E0
        public void AddComponentInfo(){} // RVA: 0x7FFAC9D9D650
        public void CreateComponentInfoVector(){} // RVA: 0x7FFAC9D9D690
        public void CreateComponentInfoVectorBlock(){} // RVA: 0x7FFAC9D9D990 | overloaded x3
        public void StartComponentInfoVector(){} // RVA: 0x7FFAC9D9DA50
        public void AddPayload(){} // RVA: 0x7FFAC9D9DA80
        public void CreatePayloadVector(){} // RVA: 0x7FFAC9D9D690
        public void CreatePayloadVectorBlock(){} // RVA: 0x7FFAC9D9DD00 | overloaded x3
        public void StartPayloadVector(){} // RVA: 0x7FFAC9D9DA50
        public void AddInitialPath(){} // RVA: 0x7FFAC9D9DDC0
        public void EndObjectMetadata(){} // RVA: 0x7FFAC9D9DE00
        public void UnPack(){} // RVA: 0x7FFAC9D9DE50
        public void UnPackTo(){} // RVA: 0x7FFAC9D9DEC0
        public void Pack(){} // RVA: 0x7FFAC9D9E450
    }

    public class ObjectMetadataPair : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsObjectMetadataPair(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_ViewId(){} // RVA: 0x7FFAC9DAA050
        public void MutateViewId(){} // RVA: 0x7FFAC9DAA0A0
        public void get_Metadata(){} // RVA: 0x7FFAC9DAC360
        public void CreateObjectMetadataPair(){} // RVA: 0x7FFAC9DAC490
        public void StartObjectMetadataPair(){} // RVA: 0x7FFAC9DA7400
        public void AddViewId(){} // RVA: 0x7FFAC9DAA730
        public void AddMetadata(){} // RVA: 0x7FFAC9DA7690
        public void EndObjectMetadataPair(){} // RVA: 0x7FFAC9DAC570
        public void UnPack(){} // RVA: 0x7FFAC9DAC5C0
        public void UnPackTo(){} // RVA: 0x7FFAC9DAC670
        public void Pack(){} // RVA: 0x7FFAC9DAC810
    }

    public class ObjectMetadataPairT : Object
    {
        public int ViewId; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataT Metadata; // 0x18

        // ── Methods ──
        public void get_ViewId(){} // RVA: 0x7FFAC2F6E5C0
        public void set_ViewId(){} // RVA: 0x7FFAC2F240C0
        public void get_Metadata(){} // RVA: 0x7FFAC2F247C0
        public void set_Metadata(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9DAC920
    }

    public class ObjectMetadataPairVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DAC980
    }

    public class ObjectMetadataT : Object
    {
        public bool Is8Bit; // 0x10
        public bool DoNotPersist; // 0x11
        public byte Code; // 0x12
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.ComponentInfoT> ComponentInfo; // 0x18
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectBunchT> Payload; // 0x20
        public string InitialPath; // 0x28

        // ── Methods ──
        public void ComputeHash(){} // RVA: 0x7FFAC9D9E7C0
        public void AreCompatible(){} // RVA: 0x7FFAC9D9ECA0
        public void get_Is8Bit(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Is8Bit(){} // RVA: 0x7FFAC2FEB5F0
        public void get_DoNotPersist(){} // RVA: 0x7FFAC3771DA0
        public void set_DoNotPersist(){} // RVA: 0x7FFAC3771D90
        public void get_Code(){} // RVA: 0x7FFAC3AE1A90
        public void set_Code(){} // RVA: 0x7FFAC4411DE0
        public void get_ComponentInfo(){} // RVA: 0x7FFAC2F247C0
        public void set_ComponentInfo(){} // RVA: 0x7FFAC2F87E80
        public void get_Payload(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Payload(){} // RVA: 0x7FFAC2F4F0D0
        public void get_InitialPath(){} // RVA: 0x7FFAC2F4F130
        public void set_InitialPath(){} // RVA: 0x7FFAC2F22E90
        public void .ctor(){} // RVA: 0x7FFAC9D9EF70
    }

    public class ObjectMetadataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DAC170
    }

    public class ObjectPool : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsObjectPool(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void VerifyObjectPool(){} // RVA: 0x7FFAC9DA8740
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Data(){} // RVA: 0x7FFAC9DA64D0
        public void get_DataLength(){} // RVA: 0x7FFAC9DA6550
        public void GetDataBytes(){} // RVA: 0x7FFAC9DA8830
        public void GetDataArray(){} // RVA: 0x7FFAC9DA88A0
        public void MutateData(){} // RVA: 0x7FFAC9DA6680
        public void CreateObjectPool(){} // RVA: 0x7FFAC9DA88F0
        public void StartObjectPool(){} // RVA: 0x7FFAC9DA6170
        public void AddData(){} // RVA: 0x7FFAC9DA6190
        public void CreateDataVector(){} // RVA: 0x7FFAC9DA6790
        public void CreateDataVectorBlock(){} // RVA: 0x7FFAC9DA8B10 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFAC9DA6AE0
        public void EndObjectPool(){} // RVA: 0x7FFAC9DA8BD0
        public void FinishObjectPoolBuffer(){} // RVA: 0x7FFAC9DA7980
        public void FinishSizePrefixedObjectPoolBuffer(){} // RVA: 0x7FFAC9DA79E0
        public void UnPack(){} // RVA: 0x7FFAC9DA8C20
        public void UnPackTo(){} // RVA: 0x7FFAC9DA8CD0
        public void Pack(){} // RVA: 0x7FFAC9DA8EE0
    }

    public class ObjectPoolT : Object
    {
        public System.Collections.Generic.List`1<byte> Data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2F3C380
        public void set_Data(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9DA8FD0
        public void SerializeToBinary(){} // RVA: 0x7FFAC9DA9080
    }

    public class ObjectPoolVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DA6FE0
    }

}