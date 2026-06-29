// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 14
// Methods: 166

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class ObjectBunch : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsObjectBunch(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Time(){} // RVA: 0x7A7F16B80
        public void get_Sender(){} // RVA: 0x7A7F16BD0
        public void get_Index(){} // RVA: 0x7A7F15A60
        public void Data(){} // RVA: 0x7A7F16DB0
        public void get_DataLength(){} // RVA: 0x7A7F15AE0
        public void GetDataBytes(){} // RVA: 0x7A7F16DC0
        public void GetDataArray(){} // RVA: 0x7A7F16E30
        public void CreateObjectBunch(){} // RVA: 0x7AF3F2F70
        public void StartObjectBunch(){} // RVA: 0x7AF3F3100
        public void AddTime(){} // RVA: 0x7AF3F2060
        public void AddSender(){} // RVA: 0x7AF3F20D0
        public void AddIndex(){} // RVA: 0x7AF3E6530
        public void AddData(){} // RVA: 0x7AF3E65A0
        public void CreateDataVector(){} // RVA: 0x7AF3EE180
        public void CreateDataVectorBlock(){} // RVA: 0x7AF3F32C0
        public void StartDataVector(){} // RVA: 0x7AF3EE4F0
        public void EndObjectBunch(){} // RVA: 0x7AF3F3380
        public void UnPack(){} // RVA: 0x7A7F16E80
        public void UnPackTo(){} // RVA: 0x7A7F16E90
        public void Pack(){} // RVA: 0x7AF3F3730
    }

    public class ObjectBunchT : Object
    {
        // ── Methods ──
        public void get_Time(){} // RVA: 0x7A8124910
        public void set_Time(){} // RVA: 0x7A80DA0C0
        public void get_Sender(){} // RVA: 0x7A8668BC0
        public void set_Sender(){} // RVA: 0x7A8669360
        public void get_Index(){} // RVA: 0x7A80F26D0
        public void set_Index(){} // RVA: 0x7A80F26E0
        public void get_Data(){} // RVA: 0x7A81052C0
        public void set_Data(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7AF3F38B0
    }

    public class ObjectBunchT[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ObjectBunchVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3F3910
    }

    public class ObjectMetadata : ValueType
    {
        // ── Methods ──
        public void ComputeHash(){} // RVA: 0x7A7F15990
        public void AreCompatible(){} // RVA: 0x7A7F159A0
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsObjectMetadata(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Is8Bit(){} // RVA: 0x7A7F159C0
        public void get_DoNotPersist(){} // RVA: 0x7A7F15A10
        public void get_Code(){} // RVA: 0x7A7F15A60
        public void ComponentInfo(){} // RVA: 0x7A7F15AB0
        public void get_ComponentInfoLength(){} // RVA: 0x7A7F15AE0
        public void Payload(){} // RVA: 0x7A7F15AF0
        public void get_PayloadLength(){} // RVA: 0x7A7F15B20
        public void get_InitialPath(){} // RVA: 0x7A7F15B30
        public void GetInitialPathBytes(){} // RVA: 0x7A7F15B40
        public void GetInitialPathArray(){} // RVA: 0x7A7F15BB0
        public void CreateObjectMetadata(){} // RVA: 0x7AF3E6260
        public void StartObjectMetadata(){} // RVA: 0x7AF3E6430
        public void AddIs8Bit(){} // RVA: 0x7AF3E6450
        public void AddDoNotPersist(){} // RVA: 0x7AF3E64C0
        public void AddCode(){} // RVA: 0x7AF3E6530
        public void AddComponentInfo(){} // RVA: 0x7AF3E65A0
        public void CreateComponentInfoVector(){} // RVA: 0x7AF3E65E0
        public void CreateComponentInfoVectorBlock(){} // RVA: 0x7AF3E6900
        public void StartComponentInfoVector(){} // RVA: 0x7AF3E69C0
        public void AddPayload(){} // RVA: 0x7AF3E69F0
        public void CreatePayloadVector(){} // RVA: 0x7AF3E65E0
        public void CreatePayloadVectorBlock(){} // RVA: 0x7AF3E6C70
        public void StartPayloadVector(){} // RVA: 0x7AF3E69C0
        public void AddInitialPath(){} // RVA: 0x7AF3E6D30
        public void EndObjectMetadata(){} // RVA: 0x7AF3E6D70
        public void UnPack(){} // RVA: 0x7A7F15C00
        public void UnPackTo(){} // RVA: 0x7A7F15C10
        public void Pack(){} // RVA: 0x7AF3E73C0
    }

    public class ObjectMetadataPair : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsObjectMetadataPair(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_ViewId(){} // RVA: 0x7A7F16B80
        public void get_Metadata(){} // RVA: 0x7A7F16EC0
        public void CreateObjectMetadataPair(){} // RVA: 0x7AF3F3D80
        public void StartObjectMetadataPair(){} // RVA: 0x7AF3EEE20
        public void AddViewId(){} // RVA: 0x7AF3F2060
        public void AddMetadata(){} // RVA: 0x7AF3EF0B0
        public void EndObjectMetadataPair(){} // RVA: 0x7AF3F3E60
        public void UnPack(){} // RVA: 0x7A7F16EF0
        public void UnPackTo(){} // RVA: 0x7A7F16F00
        public void Pack(){} // RVA: 0x7AF3F4100
    }

    public class ObjectMetadataPairT : Object
    {
        // ── Methods ──
        public void get_ViewId(){} // RVA: 0x7A8124910
        public void set_ViewId(){} // RVA: 0x7A80DA0C0
        public void get_Metadata(){} // RVA: 0x7A80DA7B0
        public void set_Metadata(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF3F4210
    }

    public class ObjectMetadataPairT[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ObjectMetadataPairVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3F4270
    }

    public class ObjectMetadataT : Object
    {
        // ── Methods ──
        public void ComputeHash(){} // RVA: 0x7AF3E7760
        public void AreCompatible(){} // RVA: 0x7AF3E7C50
        public void get_Is8Bit(){} // RVA: 0x7A81A2200
        public void set_Is8Bit(){} // RVA: 0x7A81A2210
        public void get_DoNotPersist(){} // RVA: 0x7A82FBFB0
        public void set_DoNotPersist(){} // RVA: 0x7A82FBFC0
        public void get_Code(){} // RVA: 0x7A9716B70
        public void set_Code(){} // RVA: 0x7A9716BD0
        public void get_ComponentInfo(){} // RVA: 0x7A80DA7B0
        public void set_ComponentInfo(){} // RVA: 0x7A813E420
        public void get_Payload(){} // RVA: 0x7A81052C0
        public void set_Payload(){} // RVA: 0x7A81052D0
        public void get_InitialPath(){} // RVA: 0x7A8105330
        public void set_InitialPath(){} // RVA: 0x7A80D8E80
        public void .ctor(){} // RVA: 0x7AF3E7F30
        public void <Is8Bit>k__BackingField(){} // RVA: 0x7B2EA2AB0
    }

    public class ObjectMetadataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3F3A50
    }

    public class ObjectPool : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsObjectPool(){} // RVA: 0x7AF3E5C00
        public void VerifyObjectPool(){} // RVA: 0x7AF3F01B0
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void Data(){} // RVA: 0x7A7F166E0
        public void get_DataLength(){} // RVA: 0x7A7F166F0
        public void GetDataBytes(){} // RVA: 0x7A7F16A20
        public void GetDataArray(){} // RVA: 0x7A7F16A90
        public void CreateObjectPool(){} // RVA: 0x7AF3F0360
        public void StartObjectPool(){} // RVA: 0x7AF3EDBF0
        public void AddData(){} // RVA: 0x7AF3EDC10
        public void CreateDataVector(){} // RVA: 0x7AF3EE180
        public void CreateDataVectorBlock(){} // RVA: 0x7AF3F0580
        public void StartDataVector(){} // RVA: 0x7AF3EE4F0
        public void EndObjectPool(){} // RVA: 0x7AF3F0640
        public void FinishObjectPoolBuffer(){} // RVA: 0x7AF3EF3A0
        public void FinishSizePrefixedObjectPoolBuffer(){} // RVA: 0x7AF3EF400
        public void UnPack(){} // RVA: 0x7A7F16AE0
        public void UnPackTo(){} // RVA: 0x7A7F16AF0
        public void Pack(){} // RVA: 0x7AF3F0950
    }

    public class ObjectPoolT : Object
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0x7A80F2570
        public void set_Data(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AD51EC30
        public void DeserializeFromBinary(){} // RVA: 0x7AF3F0A40
        public void SerializeToBinary(){} // RVA: 0x7AF3F0AF0
    }

    public class ObjectPoolVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3EEA00
    }

}