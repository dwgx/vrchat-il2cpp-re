// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 20
// Methods: 54

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class GlCalculatorHelper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5ADAA80
        public void DeleteMpPtr(){} // RVA: 0x5ADABC0
        public void InitializeForTest(){} // RVA: 0x5ADAC80
        public void GetGlContext(){} // RVA: 0x5ADADA0
    }

    public class GlContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5ADAFA0
        public void DisposeManaged(){} // RVA: 0x5ADB0F0
        public void DeleteMpPtr(){} // RVA: 0x2DD310
    }

    public class GlSyncPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5ADB2B0
        public void DisposeManaged(){} // RVA: 0x5ADB0F0
        public void DeleteMpPtr(){} // RVA: 0x2DD310
        public void Wait(){} // RVA: 0x5ADB3E0
    }

    public class GlTextureBuffer
    {
        // ── Methods ──
        public void DeleteMpPtr(){} // RVA: 0x2DD310
    }

    public class GlobalInstanceTable`2
    {
        public System.Threading.ReaderWriterLockSlim _tableLock;

        // ── Methods ──
        public void get_maxSize(){} // RVA: 0xD840
        public void set_maxSize(){} // RVA: 0x24FA0
        public void .ctor(){} // RVA: 0x24FA0
        public void Add(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0x283FA0
        public void Remove(){} // RVA: 0x283FA0
        public void ClearUnusedKeys(){} // RVA: 0x24A50
    }

    public class GlobalInstanceTable`2
    {
        public System.Threading.ReaderWriterLockSlim _tableLock; // 0x10
    }

    public class GlobalInstanceTable`2
    {
        public System.Threading.ReaderWriterLockSlim _tableLock; // 0x10
    }

    public class GlobalInstanceTable`2
    {
        public System.Threading.ReaderWriterLockSlim _tableLock; // 0x10
    }

    public class GlobalInstanceTable`2
    {
        public System.Threading.ReaderWriterLockSlim _tableLock; // 0x10
    }

    public class GlobalInstanceTable`2
    {
        public System.Threading.ReaderWriterLockSlim _tableLock; // 0x10
    }

    public class GlobalInstanceTable`2
    {
        public System.Threading.ReaderWriterLockSlim _tableLock; // 0x10
    }

    public class GlobalInstanceTable`2
    {
        public System.Threading.ReaderWriterLockSlim _tableLock; // 0x10
    }

    public class GlobalInstanceTable`2
    {
        public System.Threading.ReaderWriterLockSlim _tableLock; // 0x10
    }

    public class GlobalInstanceTable`2
    {
        public System.Threading.ReaderWriterLockSlim _tableLock; // 0x10
    }

    public class GlobalInstanceTable`2
    {
        public System.Threading.ReaderWriterLockSlim _tableLock; // 0x10
    }

    public class Glog
    {
        public bool _Logtostderr;
        public int _Stderrthreshold; // 0x4
        public int _Minloglevel; // 0x8
        public int _V; // 0xC

        // ── Methods ──
        public void set_Logtostderr(){} // RVA: 0x5AD3EE0
        public void get_Stderrthreshold(){} // RVA: 0x5AD3FE0
        public void set_Stderrthreshold(){} // RVA: 0x5AD4040
        public void get_Minloglevel(){} // RVA: 0x5AD4140
        public void set_Minloglevel(){} // RVA: 0x5AD41A0
        public void get_V(){} // RVA: 0x5AD42A0
        public void set_V(){} // RVA: 0x5AD4300
        public void Initialize(){} // RVA: 0x5AD4400
        public void Shutdown(){} // RVA: 0x5AD44E0
        public void .cctor(){} // RVA: 0x5AD4580
    }

    public class GpuBuffer
    {
        // ── Methods ──
        public void DeleteMpPtr(){} // RVA: 0x5ADB5F0
    }

    public class GpuOrigin
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.GpuOrigin> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B2ECC0
        public void get_Descriptor(){} // RVA: 0x5B2ED20
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B2EDE0
        public void .ctor(){} // RVA: 0x5A3CAF0 | overloaded x2
        public void Clone(){} // RVA: 0x5B2EED0
        public void Equals(){} // RVA: 0x5A3CD80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3CDC0
        public void ToString(){} // RVA: 0x5B2F080
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A3CE50
        public void CalculateSize(){} // RVA: 0x5A3CE70
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A3CF70
        public void .cctor(){} // RVA: 0x5B2F0D0
    }

    public class GpuOriginReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B2E750
        public void .cctor(){} // RVA: 0x5B2E7B0
    }

    public class GpuResources
    {
        public Mediapipe.SharedPtrHandle _sharedPtrHandle; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5ADB6B0
        public void DisposeManaged(){} // RVA: 0x5ADB0F0
        public void DeleteMpPtr(){} // RVA: 0x2DD310
        public void get_sharedPtr(){} // RVA: 0x5ADB7E0
        public void Create(){} // RVA: 0x5ADB800
    }

}