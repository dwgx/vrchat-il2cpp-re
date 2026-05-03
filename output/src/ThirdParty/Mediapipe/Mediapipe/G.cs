// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 10
// Methods: 54

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class GlCalculatorHelper : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8661B8B0
        public void DeleteMpPtr(){} // RVA: 0x7FFE8661B9F0
        public void InitializeForTest(){} // RVA: 0x7FFE8661BAB0
        public void GetGlContext(){} // RVA: 0x7FFE8661BBD0
    }

    public class GlContext : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8661BDD0
        public void DisposeManaged(){} // RVA: 0x7FFE8661BF20
        public void DeleteMpPtr(){} // RVA: 0x7FFE810FB310
    }

    public class GlSyncPoint : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8661C0E0
        public void DisposeManaged(){} // RVA: 0x7FFE8661BF20
        public void DeleteMpPtr(){} // RVA: 0x7FFE810FB310
        public void Wait(){} // RVA: 0x7FFE8661C210
    }

    public class GlTextureBuffer : MpResourceHandle
    {
        // ── Methods ──
        public void DeleteMpPtr(){} // RVA: 0x7FFE810FB310
    }

    public class GlobalInstanceTable`2 : Object
    {
        public System.Threading.ReaderWriterLockSlim _tableLock;

        // ── Methods ──
        public void get_maxSize(){} // RVA: 0x7FFE80E2EDB0
        public void set_maxSize(){} // RVA: 0x7FFE80E46530
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void Add(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void ClearUnusedKeys(){} // RVA: 0x7FFE80E45FE0
    }

    public class Glog : Object
    {
        public bool _Logtostderr;
        public int _Stderrthreshold; // 0x4
        public int _Minloglevel; // 0x8
        public int _V; // 0xC

        // ── Methods ──
        public void set_Logtostderr(){} // RVA: 0x7FFE86614D10
        public void get_Stderrthreshold(){} // RVA: 0x7FFE86614E10
        public void set_Stderrthreshold(){} // RVA: 0x7FFE86614E70
        public void get_Minloglevel(){} // RVA: 0x7FFE86614F70
        public void set_Minloglevel(){} // RVA: 0x7FFE86614FD0
        public void get_V(){} // RVA: 0x7FFE866150D0
        public void set_V(){} // RVA: 0x7FFE86615130
        public void Initialize(){} // RVA: 0x7FFE86615230
        public void Shutdown(){} // RVA: 0x7FFE86615310
        public void .cctor(){} // RVA: 0x7FFE866153B0
    }

    public class GpuBuffer : MpResourceHandle
    {
        // ── Methods ──
        public void DeleteMpPtr(){} // RVA: 0x7FFE8661C420
    }

    public class GpuOrigin : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.GpuOrigin> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public object field_2; // 0x210

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8666FAF0
        public void get_Descriptor(){} // RVA: 0x7FFE8666FB50
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8666FC10
        public void .ctor(){} // RVA: 0x7FFE8657D850 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8666FD00
        public void Equals(){} // RVA: 0x7FFE8657DAE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657DB20
        public void ToString(){} // RVA: 0x7FFE8666FEB0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8657DBB0
        public void CalculateSize(){} // RVA: 0x7FFE8657DBD0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8657DCD0
        public void .cctor(){} // RVA: 0x7FFE8666FF00
    }

    public class GpuOriginReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE8666F580
        public void .cctor(){} // RVA: 0x7FFE8666F5E0
    }

    public class GpuResources : MpResourceHandle
    {
        public Mediapipe.SharedPtrHandle _sharedPtrHandle; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8661C4E0
        public void DisposeManaged(){} // RVA: 0x7FFE8661BF20
        public void DeleteMpPtr(){} // RVA: 0x7FFE810FB310
        public void get_sharedPtr(){} // RVA: 0x7FFE8661C610
        public void Create(){} // RVA: 0x7FFE8661C630
    }

}