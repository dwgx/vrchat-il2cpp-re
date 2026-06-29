// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 14
// Methods: 165

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class ObjectBunch : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsObjectBunch(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Time(){} // RVA: 0x9BD010
        public void get_Sender(){} // RVA: 0x9BD060
        public void get_Index(){} // RVA: 0x9BB7D0
        public void Data(){} // RVA: 0x9BD2E0
        public void get_DataLength(){} // RVA: 0x9BB850
        public void GetDataBytes(){} // RVA: 0x9BD2F0
        public void GetDataArray(){} // RVA: 0x9BD360
        public void CreateObjectBunch(){} // RVA: 0x824CA40
        public void StartObjectBunch(){} // RVA: 0x824CBD0
        public void AddTime(){} // RVA: 0x824BB30
        public void AddSender(){} // RVA: 0x824BBA0
        public void AddIndex(){} // RVA: 0x823FE30
        public void AddData(){} // RVA: 0x823FEA0
        public void CreateDataVector(){} // RVA: 0x8247C50
        public void CreateDataVectorBlock(){} // RVA: 0x824CD90
        public void StartDataVector(){} // RVA: 0x8247FC0
        public void EndObjectBunch(){} // RVA: 0x824CE50
        public void UnPack(){} // RVA: 0x9BD3B0
        public void UnPackTo(){} // RVA: 0x9BD3C0
        public void Pack(){} // RVA: 0x824D200
    }

    public class ObjectBunchT : Object
    {
        public object _time;
        public object _sender;
        public object _index;
        public object _data;

        // ── Methods ──
        public void get_Time(){} // RVA: 0xB8F8F0
        public void set_Time(){} // RVA: 0xB460A0
        public void get_Sender(){} // RVA: 0x116A650
        public void set_Sender(){} // RVA: 0x116BB10
        public void get_Index(){} // RVA: 0xB5DD50
        public void set_Index(){} // RVA: 0xB5DD60
        public void get_Data(){} // RVA: 0xB700F0
        public void set_Data(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0x824D380
    }

    public class ObjectBunchT[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ObjectBunchVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x824D3E0
    }

    public class ObjectMetadata : ValueType
    {
        public object __p;

        // ── Methods ──
        public void ComputeHash(){} // RVA: 0x9BB700
        public void AreCompatible(){} // RVA: 0x9BB710
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsObjectMetadata(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Is8Bit(){} // RVA: 0x9BB730
        public void get_DoNotPersist(){} // RVA: 0x9BB780
        public void get_Code(){} // RVA: 0x9BB7D0
        public void ComponentInfo(){} // RVA: 0x9BB820
        public void get_ComponentInfoLength(){} // RVA: 0x9BB850
        public void Payload(){} // RVA: 0x9BB860
        public void get_PayloadLength(){} // RVA: 0x9BB890
        public void get_InitialPath(){} // RVA: 0x9BB8A0
        public void GetInitialPathBytes(){} // RVA: 0x9BB8B0
        public void GetInitialPathArray(){} // RVA: 0x9BB920
        public void CreateObjectMetadata(){} // RVA: 0x823FB60
        public void StartObjectMetadata(){} // RVA: 0x823FD30
        public void AddIs8Bit(){} // RVA: 0x823FD50
        public void AddDoNotPersist(){} // RVA: 0x823FDC0
        public void AddCode(){} // RVA: 0x823FE30
        public void AddComponentInfo(){} // RVA: 0x823FEA0
        public void CreateComponentInfoVector(){} // RVA: 0x823FEE0
        public void CreateComponentInfoVectorBlock(){} // RVA: 0x8240200
        public void StartComponentInfoVector(){} // RVA: 0x82402C0
        public void AddPayload(){} // RVA: 0x82402F0
        public void CreatePayloadVector(){} // RVA: 0x823FEE0
        public void CreatePayloadVectorBlock(){} // RVA: 0x8240570
        public void StartPayloadVector(){} // RVA: 0x82402C0
        public void AddInitialPath(){} // RVA: 0x8240630
        public void EndObjectMetadata(){} // RVA: 0x8240670
        public void UnPack(){} // RVA: 0x9BB970
        public void UnPackTo(){} // RVA: 0x9BB980
        public void Pack(){} // RVA: 0x8240CC0
    }

    public class ObjectMetadataPair : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsObjectMetadataPair(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_ViewId(){} // RVA: 0x9BD010
        public void get_Metadata(){} // RVA: 0x9BD490
        public void CreateObjectMetadataPair(){} // RVA: 0x824D850
        public void StartObjectMetadataPair(){} // RVA: 0x82488F0
        public void AddViewId(){} // RVA: 0x824BB30
        public void AddMetadata(){} // RVA: 0x8248B80
        public void EndObjectMetadataPair(){} // RVA: 0x824D930
        public void UnPack(){} // RVA: 0x9BD4C0
        public void UnPackTo(){} // RVA: 0x9BD4D0
        public void Pack(){} // RVA: 0x824DBD0
    }

    public class ObjectMetadataPairT : Object
    {
        public object _viewId;
        public object _metadata;

        // ── Methods ──
        public void get_ViewId(){} // RVA: 0xB8F8F0
        public void set_ViewId(){} // RVA: 0xB460A0
        public void get_Metadata(){} // RVA: 0xB465B0
        public void set_Metadata(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x824DCE0
    }

    public class ObjectMetadataPairT[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ObjectMetadataPairVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x824DD40
    }

    public class ObjectMetadataT : Object
    {
        public object _is8Bit;
        public object _doNotPersist;
        public object _code;
        public object _componentInfo;
        public object _payload;
        public object _initialPath;

        // ── Methods ──
        public void ComputeHash(){} // RVA: 0x8241060
        public void AreCompatible(){} // RVA: 0x8241550
        public void get_Is8Bit(){} // RVA: 0xC120A0
        public void set_Is8Bit(){} // RVA: 0xC120B0
        public void get_DoNotPersist(){} // RVA: 0xDD5C50
        public void set_DoNotPersist(){} // RVA: 0xDD7A00
        public void get_Code(){} // RVA: 0x22201E0
        public void set_Code(){} // RVA: 0x22201F0
        public void get_ComponentInfo(){} // RVA: 0xB465B0
        public void set_ComponentInfo(){} // RVA: 0xBA9BA0
        public void get_Payload(){} // RVA: 0xB700F0
        public void set_Payload(){} // RVA: 0xB70100
        public void get_InitialPath(){} // RVA: 0xB70160
        public void set_InitialPath(){} // RVA: 0xB44DC0
        public void .ctor(){} // RVA: 0x8241830
    }

    public class ObjectMetadataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x824D520
    }

    public class ObjectPool : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsObjectPool(){} // RVA: 0x823F500
        public void VerifyObjectPool(){} // RVA: 0x8249C80
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Data(){} // RVA: 0x9BC8B0
        public void get_DataLength(){} // RVA: 0x9BC8C0
        public void GetDataBytes(){} // RVA: 0x9BCD70
        public void GetDataArray(){} // RVA: 0x9BCDE0
        public void CreateObjectPool(){} // RVA: 0x8249E30
        public void StartObjectPool(){} // RVA: 0x82476C0
        public void AddData(){} // RVA: 0x82476E0
        public void CreateDataVector(){} // RVA: 0x8247C50
        public void CreateDataVectorBlock(){} // RVA: 0x824A050
        public void StartDataVector(){} // RVA: 0x8247FC0
        public void EndObjectPool(){} // RVA: 0x824A110
        public void FinishObjectPoolBuffer(){} // RVA: 0x8248E70
        public void FinishSizePrefixedObjectPoolBuffer(){} // RVA: 0x8248ED0
        public void UnPack(){} // RVA: 0x9BCE30
        public void UnPackTo(){} // RVA: 0x9BCE40
        public void Pack(){} // RVA: 0x824A420
    }

    public class ObjectPoolT : Object
    {
        public object _data;

        // ── Methods ──
        public void get_Data(){} // RVA: 0xB5DBF0
        public void set_Data(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
        public void DeserializeFromBinary(){} // RVA: 0x824A510
        public void SerializeToBinary(){} // RVA: 0x824A5C0
    }

    public class ObjectPoolVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82484D0
    }

}