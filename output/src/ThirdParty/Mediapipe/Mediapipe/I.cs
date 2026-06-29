// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 14
// Methods: 162

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Image : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8C38C0
        public void DeleteMpPtr(){} // RVA: 0x7AD8C3B80
        public void Width(){} // RVA: 0x7AD8C3C40
        public void Height(){} // RVA: 0x7AD8C3D00
        public void Step(){} // RVA: 0x7AD8C3DC0
        public void ImageFormat(){} // RVA: 0x7AD8C3E80
        public void .cctor(){} // RVA: 0x7AD8C3F40
    }

    public class ImageArray : ValueType
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7A7E2A170
    }

    public class ImageFormat : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD8FC340
        public void get_Descriptor(){} // RVA: 0x7AD8FC3A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD8FC460
        public void .ctor(){} // RVA: 0x7AD828FE0
        public void Clone(){} // RVA: 0x7AD8FC550
        public void Equals(){} // RVA: 0x7AD829270
        public void GetHashCode(){} // RVA: 0x7AD8292B0
        public void ToString(){} // RVA: 0x7AD8FC700
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD829340
        public void CalculateSize(){} // RVA: 0x7AD829360
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD829460
        public void .cctor(){} // RVA: 0x7AD8FC750
    }

    public class ImageFormatExtension : Object
    {
        // ── Methods ──
        public void NumberOfChannels(){} // RVA: 0x7AD8C1170
        public void ByteDepth(){} // RVA: 0x7AD8C11E0
    }

    public class ImageFormatReflection : Object
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7AD8FBCD0
        public void .cctor(){} // RVA: 0x7AD8FBD30
    }

    public class ImageFrame : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8C4630
        public void DeleteMpPtr(){} // RVA: 0x7AD8C4850
        public void VoidDeleter(){} // RVA: 0x7A80D7310
        public void Format(){} // RVA: 0x7AD8C4910
        public void Width(){} // RVA: 0x7AD8C4990
        public void Height(){} // RVA: 0x7AD8C4A10
        public void ByteDepth(){} // RVA: 0x7AD8C4A90
        public void WidthStep(){} // RVA: 0x7AD8C4AB0
        public void MutablePixelData(){} // RVA: 0x7AD8C4B30
        public void PixelDataSize(){} // RVA: 0x7AD8C4BB0
        public void .cctor(){} // RVA: 0x7AD8C4BE0
    }

    public class Image[] : Array
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

    public class InferenceCalculatorOptions : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD8D09E0
        public void get_Descriptor(){} // RVA: 0x7AD8D0A40
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD8D0B00
        public void .ctor(){} // RVA: 0x7AD8D0B50
        public void Clone(){} // RVA: 0x7AD8D0D50
        public void get_ModelPath(){} // RVA: 0x7AD8D0DB0
        public void set_ModelPath(){} // RVA: 0x7AD8D0E20
        public void get_HasModelPath(){} // RVA: 0x7A9C435A0
        public void ClearModelPath(){} // RVA: 0x7AD8439E0
        public void get_UseGpu(){} // RVA: 0x7AD8D0F20
        public void set_UseGpu(){} // RVA: 0x7AD864C80
        public void get_HasUseGpu(){} // RVA: 0x7AD848D40
        public void ClearUseGpu(){} // RVA: 0x7AD848D50
        public void get_UseNnapi(){} // RVA: 0x7AD8D0F90
        public void set_UseNnapi(){} // RVA: 0x7AD8D1000
        public void get_HasUseNnapi(){} // RVA: 0x7AD848DE0
        public void ClearUseNnapi(){} // RVA: 0x7AD848DF0
        public void get_CpuNumThread(){} // RVA: 0x7AD8D1010
        public void set_CpuNumThread(){} // RVA: 0x7AD8D1080
        public void get_HasCpuNumThread(){} // RVA: 0x7AD84BFE0
        public void ClearCpuNumThread(){} // RVA: 0x7AD84BFF0
        public void get_Delegate(){} // RVA: 0x7A83F69F0
        public void set_Delegate(){} // RVA: 0x7A8105A90
        public void Equals(){} // RVA: 0x7AD8D10F0
        public void GetHashCode(){} // RVA: 0x7AD8D1260
        public void ToString(){} // RVA: 0x7AD8D1390
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD8D13E0
        public void CalculateSize(){} // RVA: 0x7AD8D14E0
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8D1810
        public void .cctor(){} // RVA: 0x7AD8D1980
    }

    public class InferenceCalculatorReflection : Object
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7AD8CF210
        public void .cctor(){} // RVA: 0x7AD8CF270
    }

    public class InputCollection : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD8E2FC0
        public void get_Descriptor(){} // RVA: 0x7AD8E3020
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD8E30E0
        public void .ctor(){} // RVA: 0x7AD8E33E0
        public void Clone(){} // RVA: 0x7AD8E36A0
        public void get_Name(){} // RVA: 0x7A80DA7B0
        public void set_Name(){} // RVA: 0x7AD8E3700
        public void get_SidePacketName(){} // RVA: 0x7A81052C0
        public void get_ExternalInputName(){} // RVA: 0x7A8105330
        public void get_InputType(){} // RVA: 0x7A8133100
        public void set_InputType(){} // RVA: 0x7A8133110
        public void get_FileName(){} // RVA: 0x7A8292C30
        public void set_FileName(){} // RVA: 0x7AD8E3800
        public void Equals(){} // RVA: 0x7AD8E3960
        public void GetHashCode(){} // RVA: 0x7AD8E3AD0
        public void ToString(){} // RVA: 0x7AD8E3BD0
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD8E3C20
        public void CalculateSize(){} // RVA: 0x7AD8E3DB0
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8E4130
        public void .cctor(){} // RVA: 0x7AD8E4320
    }

    public class InputCollectionSet : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD8E46E0
        public void get_Descriptor(){} // RVA: 0x7AD8E4740
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD8E4800
        public void .ctor(){} // RVA: 0x7AD8E49B0
        public void Clone(){} // RVA: 0x7AD8E4B50
        public void get_InputCollection(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7AD8E4E20
        public void GetHashCode(){} // RVA: 0x7AD82A430
        public void ToString(){} // RVA: 0x7AD8E4ED0
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD8E4F20
        public void CalculateSize(){} // RVA: 0x7AD8E4FE0
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8E51D0
        public void .cctor(){} // RVA: 0x7AD8E52D0
    }

    public class InputStreamHandlerConfig : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD9194E0
        public void get_Descriptor(){} // RVA: 0x7AD919540
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD919600
        public void .ctor(){} // RVA: 0x7AD9196F0
        public void Clone(){} // RVA: 0x7AD9198C0
        public void get_InputStreamHandler(){} // RVA: 0x7AD919AC0
        public void set_InputStreamHandler(){} // RVA: 0x7AD919B30
        public void get_HasInputStreamHandler(){} // RVA: 0x7A9B3D890
        public void ClearInputStreamHandler(){} // RVA: 0x7AA4BE520
        public void get_Options(){} // RVA: 0x7A81052C0
        public void set_Options(){} // RVA: 0x7A81052D0
        public void Equals(){} // RVA: 0x7AD919D80
        public void GetHashCode(){} // RVA: 0x7AD919EA0
        public void ToString(){} // RVA: 0x7AD919F40
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD919F90
        public void CalculateSize(){} // RVA: 0x7AD91A010
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD91A2A0
        public void .cctor(){} // RVA: 0x7AD91A3A0
    }

    public class InputStreamInfo : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD8E5650
        public void get_Descriptor(){} // RVA: 0x7AD8E56B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD8E5770
        public void .ctor(){} // RVA: 0x7AD8E58F0
        public void Clone(){} // RVA: 0x7AD8E5A60
        public void get_TagIndex(){} // RVA: 0x7A80DA7B0
        public void set_TagIndex(){} // RVA: 0x7AD8E5C00
        public void get_BackEdge(){} // RVA: 0x7A81C68D0
        public void set_BackEdge(){} // RVA: 0x7A81C68E0
        public void Equals(){} // RVA: 0x7AD8E5E00
        public void GetHashCode(){} // RVA: 0x7AD8E5EB0
        public void ToString(){} // RVA: 0x7AD8E5F60
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD8E5FB0
        public void CalculateSize(){} // RVA: 0x7AD8E6040
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8E61F0
        public void .cctor(){} // RVA: 0x7AD8E62B0
    }

    public class InternalException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8C0B50
    }

}