// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 22
// Methods: 248

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class PhysBoneChain : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x247
        public object field_2; // 0x248
        public object field_3; // 0x249
        public object field_4; // 0x24A

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_ChainIdA(){} // RVA: 0x7FFE88154C80
        public void get_ChainIdB(){} // RVA: 0x7FFE88154CB0
        public void get_BoneOffset(){} // RVA: 0x7FFE88155920
        public void get_BoneCount(){} // RVA: 0x7FFE88155950
        public void CreatePhysBoneChain(){} // RVA: 0x7FFE88155980
        public void UnPack(){} // RVA: 0x7FFE88155AA0
        public void UnPackTo(){} // RVA: 0x7FFE88155B70
        public void Pack(){} // RVA: 0x7FFE88155C00
    }

    public class PhysBoneChainT : Object
    {
        public ulong _chainIdA; // 0x10
        public ulong _chainIdB; // 0x18
        public ushort _boneOffset; // 0x20
        public byte _boneCount; // 0x22

        // ── Methods ──
        public void get_ChainIdA(){} // RVA: 0x7FFE81116380
        public void set_ChainIdA(){} // RVA: 0x7FFE826F2ED0
        public void get_ChainIdB(){} // RVA: 0x7FFE810FE7C0
        public void set_ChainIdB(){} // RVA: 0x7FFE819EA910
        public void get_BoneOffset(){} // RVA: 0x7FFE850EF1D0
        public void set_BoneOffset(){} // RVA: 0x7FFE86601D50
        public void get_BoneCount(){} // RVA: 0x7FFE8292F1A0
        public void set_BoneCount(){} // RVA: 0x7FFE822131E0
        public void .ctor(){} // RVA: 0x7FFE88155C40
    }

    public class PhysBoneGrab : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x237
        public object field_2; // 0x238
        public object field_3; // 0x239
        public object field_4; // 0x23A

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_ChainIdA(){} // RVA: 0x7FFE88154C80
        public void get_ChainIdB(){} // RVA: 0x7FFE88154CB0
        public void get_Bone(){} // RVA: 0x7FFE88154CE0
        public void get_Offset(){} // RVA: 0x7FFE88154D10
        public void CreatePhysBoneGrab(){} // RVA: 0x7FFE88154D50
        public void UnPack(){} // RVA: 0x7FFE88154EA0
        public void UnPackTo(){} // RVA: 0x7FFE88154F10
        public void Pack(){} // RVA: 0x7FFE88155020
    }

    public class PhysBoneGrabT : Object
    {
        public ulong _chainIdA; // 0x10
        public ulong _chainIdB; // 0x18
        public byte _bone; // 0x20
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.Vector3T _offset; // 0x28

        // ── Methods ──
        public void get_ChainIdA(){} // RVA: 0x7FFE81116380
        public void set_ChainIdA(){} // RVA: 0x7FFE826F2ED0
        public void get_ChainIdB(){} // RVA: 0x7FFE810FE7C0
        public void set_ChainIdB(){} // RVA: 0x7FFE819EA910
        public void get_Bone(){} // RVA: 0x7FFE811E99D0
        public void set_Bone(){} // RVA: 0x7FFE811E99E0
        public void get_Offset(){} // RVA: 0x7FFE81129130
        public void set_Offset(){} // RVA: 0x7FFE810FCE90
        public void .ctor(){} // RVA: 0x7FFE88155090
    }

    public class PhysBoneRecorder : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x250
        public object field_2; // 0x251
        public object field_3; // 0x252
        public object field_4; // 0x253

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsPhysBoneRecorder(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void VerifyPhysBoneRecorder(){} // RVA: 0x7FFE88155C60
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Chains(){} // RVA: 0x7FFE88155D50
        public void get_ChainsLength(){} // RVA: 0x7FFE8814C740
        public void Bones(){} // RVA: 0x7FFE88155EB0
        public void get_BonesLength(){} // RVA: 0x7FFE8814D440
        public void get_GrabL(){} // RVA: 0x7FFE88156000
        public void get_GrabR(){} // RVA: 0x7FFE88156110
        public void CreatePhysBoneRecorder(){} // RVA: 0x7FFE88156220
        public void StartPhysBoneRecorder(){} // RVA: 0x7FFE88151750
        public void AddChains(){} // RVA: 0x7FFE8814C380
        public void StartChainsVector(){} // RVA: 0x7FFE881563D0
        public void AddBones(){} // RVA: 0x7FFE8814D7F0
        public void StartBonesVector(){} // RVA: 0x7FFE88156400
        public void AddGrabL(){} // RVA: 0x7FFE88156430
        public void AddGrabR(){} // RVA: 0x7FFE88156460
        public void EndPhysBoneRecorder(){} // RVA: 0x7FFE88156490
        public void FinishPhysBoneRecorderBuffer(){} // RVA: 0x7FFE8814DAE0
        public void FinishSizePrefixedPhysBoneRecorderBuffer(){} // RVA: 0x7FFE8814DB40
        public void UnPack(){} // RVA: 0x7FFE881564E0
        public void UnPackTo(){} // RVA: 0x7FFE88156550
        public void Pack(){} // RVA: 0x7FFE88156B40
    }

    public class PhysBoneRecorderT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.PhysBoneChainT> _chains; // 0x10
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.PhysBoneTransformT> _bones; // 0x18
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.PhysBoneGrabT _grabL; // 0x20
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.PhysBoneGrabT _grabR; // 0x28

        // ── Methods ──
        public void get_Chains(){} // RVA: 0x7FFE81116380
        public void set_Chains(){} // RVA: 0x7FFE810FCE30
        public void get_Bones(){} // RVA: 0x7FFE810FE7C0
        public void set_Bones(){} // RVA: 0x7FFE81161E80
        public void get_GrabL(){} // RVA: 0x7FFE811290C0
        public void set_GrabL(){} // RVA: 0x7FFE811290D0
        public void get_GrabR(){} // RVA: 0x7FFE81129130
        public void set_GrabR(){} // RVA: 0x7FFE810FCE90
        public void .ctor(){} // RVA: 0x7FFE88156F20
        public void DeserializeFromBinary(){} // RVA: 0x7FFE881570F0
        public void SerializeToBinary(){} // RVA: 0x7FFE881571E0
    }

    public class PhysBoneRecorderVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE881572E0
    }

    public class PhysBoneTransform : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x240
        public object field_2; // 0x241
        public object field_3; // 0x242

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_BoneId(){} // RVA: 0x7FFE88155130
        public void get_Position(){} // RVA: 0x7FFE88130740
        public void get_Rotation(){} // RVA: 0x7FFE88155160
        public void CreatePhysBoneTransform(){} // RVA: 0x7FFE881551A0
        public void UnPack(){} // RVA: 0x7FFE88155320
        public void UnPackTo(){} // RVA: 0x7FFE881554B0
        public void Pack(){} // RVA: 0x7FFE881556A0
    }

    public class PhysBoneTransformT : Object
    {
        public byte _boneId; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.FloatHalfT _position; // 0x18
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.QuaternionTenBitT _rotation; // 0x20

        // ── Methods ──
        public void get_BoneId(){} // RVA: 0x7FFE811C55E0
        public void set_BoneId(){} // RVA: 0x7FFE811C55F0
        public void get_Position(){} // RVA: 0x7FFE810FE7C0
        public void set_Position(){} // RVA: 0x7FFE81161E80
        public void get_Rotation(){} // RVA: 0x7FFE811290C0
        public void set_Rotation(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE881557E0
    }

    public class PlayerData : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x260

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsPlayerData(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Pairs(){} // RVA: 0x7FFE8815BAA0
        public void get_PairsLength(){} // RVA: 0x7FFE8814C740
        public void CreatePlayerData(){} // RVA: 0x7FFE8815BC10
        public void StartPlayerData(){} // RVA: 0x7FFE8814C360
        public void AddPairs(){} // RVA: 0x7FFE8814C380
        public void CreatePairsVector(){} // RVA: 0x7FFE88144E80
        public void CreatePairsVectorBlock(){} // RVA: 0x7FFE8815BED0 | overloaded x3
        public void StartPairsVector(){} // RVA: 0x7FFE88145240
        public void EndPlayerData(){} // RVA: 0x7FFE8815BF90
        public void UnPack(){} // RVA: 0x7FFE8815BFE0
        public void UnPackTo(){} // RVA: 0x7FFE8815C090
        public void Pack(){} // RVA: 0x7FFE8815C2F0
    }

    public class PlayerDataPair : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x25B
        public object field_2; // 0x25C

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsPlayerDataPair(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Key(){} // RVA: 0x7FFE8814C190
        public void GetKeyBytes(){} // RVA: 0x7FFE88159870
        public void GetKeyArray(){} // RVA: 0x7FFE881598E0
        public void get_ValueType(){} // RVA: 0x7FFE88159930
        public void Value(){} // RVA: 0x7FFE810A1420
        public void ValueAsVector2(){} // RVA: 0x7FFE88159980
        public void ValueAsVector3(){} // RVA: 0x7FFE88159A10
        public void ValueAsVector4(){} // RVA: 0x7FFE88159AA0
        public void ValueAsQuaternion(){} // RVA: 0x7FFE88159B30
        public void ValueAsColor(){} // RVA: 0x7FFE88159BC0
        public void ValueAsColor32(){} // RVA: 0x7FFE88159C50
        public void ValueAsWrappedString(){} // RVA: 0x7FFE88159CE0
        public void ValueAsWrappedShort(){} // RVA: 0x7FFE88159D70
        public void ValueAsWrappedInt(){} // RVA: 0x7FFE88159E00
        public void ValueAsWrappedFloat(){} // RVA: 0x7FFE88159E90
        public void ValueAsWrappedBool(){} // RVA: 0x7FFE88159F20
        public void ValueAsWrappedByte(){} // RVA: 0x7FFE88159FB0
        public void ValueAsWrappedBytes(){} // RVA: 0x7FFE8815A040
        public void ValueAsWrappedUShort(){} // RVA: 0x7FFE8815A0D0
        public void ValueAsWrappedUByte(){} // RVA: 0x7FFE8815A160
        public void ValueAsWrappedUInt(){} // RVA: 0x7FFE8815A1F0
        public void ValueAsWrappedULong(){} // RVA: 0x7FFE8815A280
        public void ValueAsWrappedDouble(){} // RVA: 0x7FFE8815A310
        public void ValueAsWrappedLong(){} // RVA: 0x7FFE8815A3A0
        public void CreatePlayerDataPair(){} // RVA: 0x7FFE8815A430
        public void StartPlayerDataPair(){} // RVA: 0x7FFE881530A0
        public void AddKey(){} // RVA: 0x7FFE8814C380
        public void AddValueType(){} // RVA: 0x7FFE8815A540
        public void AddValue(){} // RVA: 0x7FFE88148950
        public void EndPlayerDataPair(){} // RVA: 0x7FFE8815A5B0
        public void UnPack(){} // RVA: 0x7FFE8815A600
        public void UnPackTo(){} // RVA: 0x7FFE8815A670
        public void Pack(){} // RVA: 0x7FFE8815B700
    }

    public class PlayerDataPairT : Object
    {
        public string _key; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.PlayerDataTypeUnion _value; // 0x18

        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFE81116380
        public void set_Key(){} // RVA: 0x7FFE810FCE30
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8812BFA0
    }

    public class PlayerDataPairVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8815B870
    }

    public class PlayerDataT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.PlayerDataPairT> _pairs; // 0x10

        // ── Methods ──
        public void get_Pairs(){} // RVA: 0x7FFE81116380
        public void set_Pairs(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class PlayerDataTypeUnion : Object
    {
        public 0x665FA38C _type; // 0x10
        public object _value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE811C55E0
        public void set_Type(){} // RVA: 0x7FFE811C55F0
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8811CB20
        public void As(){} // RVA: 0x7FFE810A1420
        public void AsVector2(){} // RVA: 0x7FFE88157400
        public void FromVector2(){} // RVA: 0x7FFE88157440
        public void AsVector3(){} // RVA: 0x7FFE88157540
        public void FromVector3(){} // RVA: 0x7FFE88157580
        public void AsVector4(){} // RVA: 0x7FFE88157680
        public void FromVector4(){} // RVA: 0x7FFE881576C0
        public void AsQuaternion(){} // RVA: 0x7FFE881577C0
        public void FromQuaternion(){} // RVA: 0x7FFE88157800
        public void AsColor(){} // RVA: 0x7FFE88157900
        public void FromColor(){} // RVA: 0x7FFE88157940
        public void AsColor32(){} // RVA: 0x7FFE88157A40
        public void FromColor32(){} // RVA: 0x7FFE88157A80
        public void AsWrappedString(){} // RVA: 0x7FFE88157B80
        public void FromWrappedString(){} // RVA: 0x7FFE88157BC0
        public void AsWrappedShort(){} // RVA: 0x7FFE88157CC0
        public void FromWrappedShort(){} // RVA: 0x7FFE88157D00
        public void AsWrappedInt(){} // RVA: 0x7FFE88157E00
        public void FromWrappedInt(){} // RVA: 0x7FFE88157E40
        public void AsWrappedFloat(){} // RVA: 0x7FFE88157F40
        public void FromWrappedFloat(){} // RVA: 0x7FFE88157F80
        public void AsWrappedBool(){} // RVA: 0x7FFE88158080
        public void FromWrappedBool(){} // RVA: 0x7FFE881580C0
        public void AsWrappedByte(){} // RVA: 0x7FFE881581C0
        public void FromWrappedByte(){} // RVA: 0x7FFE88158200
        public void AsWrappedBytes(){} // RVA: 0x7FFE88158300
        public void FromWrappedBytes(){} // RVA: 0x7FFE88158340
        public void AsWrappedUShort(){} // RVA: 0x7FFE88158440
        public void FromWrappedUShort(){} // RVA: 0x7FFE88158480
        public void AsWrappedUByte(){} // RVA: 0x7FFE88158580
        public void FromWrappedUByte(){} // RVA: 0x7FFE881585C0
        public void AsWrappedUInt(){} // RVA: 0x7FFE881586C0
        public void FromWrappedUInt(){} // RVA: 0x7FFE88158700
        public void AsWrappedULong(){} // RVA: 0x7FFE88158800
        public void FromWrappedULong(){} // RVA: 0x7FFE88158840
        public void AsWrappedDouble(){} // RVA: 0x7FFE88158940
        public void FromWrappedDouble(){} // RVA: 0x7FFE88158980
        public void AsWrappedLong(){} // RVA: 0x7FFE88158A80
        public void FromWrappedLong(){} // RVA: 0x7FFE88158AC0
        public void Pack(){} // RVA: 0x7FFE88158BC0
    }

    public class PlayerDataTypeVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE881594D0
    }

    public class PlayerDataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8815C520
    }

    public class PlayerStationStateData : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x263

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsPlayerStationStateData(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void ActiveStations(){} // RVA: 0x7FFE8815C5F0
        public void get_ActiveStationsLength(){} // RVA: 0x7FFE8814C740
        public void GetActiveStationsBytes(){} // RVA: 0x7FFE8815C670
        public void GetActiveStationsArray(){} // RVA: 0x7FFE8815C6E0
        public void CreatePlayerStationStateData(){} // RVA: 0x7FFE8815C730
        public void StartPlayerStationStateData(){} // RVA: 0x7FFE8814C360
        public void AddActiveStations(){} // RVA: 0x7FFE8814C380
        public void CreateActiveStationsVector(){} // RVA: 0x7FFE881507C0
        public void CreateActiveStationsVectorBlock(){} // RVA: 0x7FFE8815C950 | overloaded x3
        public void StartActiveStationsVector(){} // RVA: 0x7FFE88145240
        public void EndPlayerStationStateData(){} // RVA: 0x7FFE8815CA10
        public void UnPack(){} // RVA: 0x7FFE8815CA60
        public void UnPackTo(){} // RVA: 0x7FFE8815CB10
        public void Pack(){} // RVA: 0x7FFE8815CD30
    }

    public class PlayerStationStateDataT : Object
    {
        public System.Collections.Generic.List`1<uint> _activeStations; // 0x10

        // ── Methods ──
        public void get_ActiveStations(){} // RVA: 0x7FFE81116380
        public void set_ActiveStations(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class PlayerStationStateDataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8815CE20
    }

    public class PuppetData : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Channels(){} // RVA: 0x7FFE88161FD0
        public void CreatePuppetData(){} // RVA: 0x7FFE881638E0
        public void UnPack(){} // RVA: 0x7FFE881639B0
        public void UnPackTo(){} // RVA: 0x7FFE88163A20
        public void Pack(){} // RVA: 0x7FFE88163B20
    }

    public class PuppetDataT : Object
    {
        public byte[] _channels; // 0x10

        // ── Methods ──
        public void get_Channels(){} // RVA: 0x7FFE81116380
        public void set_Channels(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE88163B40
    }

}