// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 14
// Methods: 162

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Image : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6550A70
        public void DeleteMpPtr(){} // RVA: 0x6550D30
        public void Width(){} // RVA: 0x6550DF0
        public void Height(){} // RVA: 0x6550EB0
        public void Step(){} // RVA: 0x6550F70
        public void ImageFormat(){} // RVA: 0x6551030
        public void .cctor(){} // RVA: 0x65510F0
    }

    public class ImageArray : ValueType
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x8A5BB0
    }

    public class ImageFormat : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x65890A0
        public void get_Descriptor(){} // RVA: 0x6589100
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x65891C0
        public void .ctor(){} // RVA: 0x64B6C30
        public void Clone(){} // RVA: 0x65892B0
        public void Equals(){} // RVA: 0x64B6EC0
        public void GetHashCode(){} // RVA: 0x64B6F00
        public void ToString(){} // RVA: 0x6589460
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64B6F90
        public void CalculateSize(){} // RVA: 0x64B6FB0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64B70B0
        public void .cctor(){} // RVA: 0x65894B0
    }

    public class ImageFormatExtension : Object
    {
        // ── Methods ──
        public void NumberOfChannels(){} // RVA: 0x654E330
        public void ByteDepth(){} // RVA: 0x654E3A0
    }

    public class ImageFormatReflection : Object
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x6588A80
        public void .cctor(){} // RVA: 0x6588AE0
    }

    public class ImageFrame : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6551920
        public void DeleteMpPtr(){} // RVA: 0x6551B40
        public void VoidDeleter(){} // RVA: 0xB43310
        public void Format(){} // RVA: 0x6551C00
        public void Width(){} // RVA: 0x6551C80
        public void Height(){} // RVA: 0x6551D00
        public void ByteDepth(){} // RVA: 0x6551D80
        public void WidthStep(){} // RVA: 0x6551DA0
        public void MutablePixelData(){} // RVA: 0x6551E20
        public void PixelDataSize(){} // RVA: 0x6551EA0
        public void .cctor(){} // RVA: 0x6551ED0
    }

    public class Image[] : Array
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

    public class InferenceCalculatorOptions : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x655DBC0
        public void get_Descriptor(){} // RVA: 0x655DC20
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x655DCE0
        public void .ctor(){} // RVA: 0x655DD30
        public void Clone(){} // RVA: 0x655DF30
        public void get_ModelPath(){} // RVA: 0x655DF90
        public void set_ModelPath(){} // RVA: 0x655E000
        public void get_HasModelPath(){} // RVA: 0x26C1120
        public void ClearModelPath(){} // RVA: 0x64D1270
        public void get_UseGpu(){} // RVA: 0x655E100
        public void set_UseGpu(){} // RVA: 0x64F2300
        public void get_HasUseGpu(){} // RVA: 0x64D65D0
        public void ClearUseGpu(){} // RVA: 0x64D65E0
        public void get_UseNnapi(){} // RVA: 0x655E170
        public void set_UseNnapi(){} // RVA: 0x655E1E0
        public void get_HasUseNnapi(){} // RVA: 0x64D6670
        public void ClearUseNnapi(){} // RVA: 0x64D6680
        public void get_CpuNumThread(){} // RVA: 0x655E1F0
        public void set_CpuNumThread(){} // RVA: 0x655E260
        public void get_HasCpuNumThread(){} // RVA: 0x64D9870
        public void ClearCpuNumThread(){} // RVA: 0x64D9880
        public void get_Delegate(){} // RVA: 0xD33E60
        public void set_Delegate(){} // RVA: 0xB708C0
        public void Equals(){} // RVA: 0x655E2D0
        public void GetHashCode(){} // RVA: 0x655E440
        public void ToString(){} // RVA: 0x655E550
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x655E5A0
        public void CalculateSize(){} // RVA: 0x655E6A0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x655E9D0
        public void .cctor(){} // RVA: 0x655EB40
    }

    public class InferenceCalculatorReflection : Object
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x655C530
        public void .cctor(){} // RVA: 0x655C590
    }

    public class InputCollection : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x656FF70
        public void get_Descriptor(){} // RVA: 0x656FFD0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x6570090
        public void .ctor(){} // RVA: 0x6570390
        public void Clone(){} // RVA: 0x6570650
        public void get_Name(){} // RVA: 0xB465B0
        public void set_Name(){} // RVA: 0x65706B0
        public void get_SidePacketName(){} // RVA: 0xB700F0
        public void get_ExternalInputName(){} // RVA: 0xB70160
        public void get_InputType(){} // RVA: 0xB9E080
        public void set_InputType(){} // RVA: 0xB9E090
        public void get_FileName(){} // RVA: 0xD05CA0
        public void set_FileName(){} // RVA: 0x65707B0
        public void Equals(){} // RVA: 0x6570910
        public void GetHashCode(){} // RVA: 0x6570A80
        public void ToString(){} // RVA: 0x6570B80
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x6570BD0
        public void CalculateSize(){} // RVA: 0x6570D60
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x65710E0
        public void .cctor(){} // RVA: 0x65712D0
    }

    public class InputCollectionSet : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x6571690
        public void get_Descriptor(){} // RVA: 0x65716F0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x65717B0
        public void .ctor(){} // RVA: 0x6571960
        public void Clone(){} // RVA: 0x6571B00
        public void get_InputCollection(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0x6571DD0
        public void GetHashCode(){} // RVA: 0x64B8050
        public void ToString(){} // RVA: 0x6571E80
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x6571ED0
        public void CalculateSize(){} // RVA: 0x6571F90
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x6572180
        public void .cctor(){} // RVA: 0x6572280
    }

    public class InputStreamHandlerConfig : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x65A5E40
        public void get_Descriptor(){} // RVA: 0x65A5EA0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x65A5F60
        public void .ctor(){} // RVA: 0x65A6050
        public void Clone(){} // RVA: 0x65A6220
        public void get_InputStreamHandler(){} // RVA: 0x65A6420
        public void set_InputStreamHandler(){} // RVA: 0x65A6490
        public void get_HasInputStreamHandler(){} // RVA: 0x25E9250
        public void ClearInputStreamHandler(){} // RVA: 0x30FBB60
        public void get_Options(){} // RVA: 0xB700F0
        public void set_Options(){} // RVA: 0xB70100
        public void Equals(){} // RVA: 0x65A66E0
        public void GetHashCode(){} // RVA: 0x65A6800
        public void ToString(){} // RVA: 0x65A68A0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x65A68F0
        public void CalculateSize(){} // RVA: 0x65A6970
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x65A6C00
        public void .cctor(){} // RVA: 0x65A6D00
    }

    public class InputStreamInfo : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x6572600
        public void get_Descriptor(){} // RVA: 0x6572660
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x6572720
        public void .ctor(){} // RVA: 0x65728A0
        public void Clone(){} // RVA: 0x6572A10
        public void get_TagIndex(){} // RVA: 0xB465B0
        public void set_TagIndex(){} // RVA: 0x6572BB0
        public void get_BackEdge(){} // RVA: 0xC38360
        public void set_BackEdge(){} // RVA: 0xC38370
        public void Equals(){} // RVA: 0x6572DB0
        public void GetHashCode(){} // RVA: 0x6572E60
        public void ToString(){} // RVA: 0x6572EF0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x6572F40
        public void CalculateSize(){} // RVA: 0x6572FD0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x6573180
        public void .cctor(){} // RVA: 0x6573240
    }

    public class InternalException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x654DD10
    }

}