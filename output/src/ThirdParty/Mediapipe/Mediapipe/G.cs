// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 10
// Methods: 54

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class GlCalculatorHelper : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8271F90
        public void DeleteMpPtr(){} // RVA: 0x7FFAC82720D0
        public void InitializeForTest(){} // RVA: 0x7FFAC8272190
        public void GetGlContext(){} // RVA: 0x7FFAC82722B0
    }

    public class GlContext : MpResourceHandle
    {
        public Mediapipe.SharedPtrHandle _sharedPtrHandle; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC82724B0
        public void DisposeManaged(){} // RVA: 0x7FFAC8272600
        public void DeleteMpPtr(){} // RVA: 0x7FFAC2F21310
    }

    public class GlSyncPoint : MpResourceHandle
    {
        public Mediapipe.SharedPtrHandle _sharedPtrHandle; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC82727C0
        public void DisposeManaged(){} // RVA: 0x7FFAC8272600
        public void DeleteMpPtr(){} // RVA: 0x7FFAC2F21310
        public void Wait(){} // RVA: 0x7FFAC82728F0
    }

    public class GlTextureBuffer : MpResourceHandle
    {
        // ── Methods ──
        public void DeleteMpPtr(){} // RVA: 0x7FFAC2F21310
    }

    public class GlobalInstanceTable`2 : Object
    {
        public System.Threading.ReaderWriterLockSlim maxSize;
        public System.Collections.Generic.Dictionary`2<T,System.WeakReference`1<T>> _table;
        public int _maxSize;

        // ── Methods ──
        public void get_maxSize(){} // RVA: 0x7FFAC2C59960
        public void set_maxSize(){} // RVA: 0x7FFAC2C70ED0
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetValue(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void ClearUnusedKeys(){} // RVA: 0x7FFAC2C70980
    }

    public class Glog : Object
    {
        public bool Logtostderr;
        public int Stderrthreshold; // 0x4
        public int Minloglevel; // 0x8
        public int V; // 0xC

        // ── Methods ──
        public void set_Logtostderr(){} // RVA: 0x7FFAC826B3F0
        public void get_Stderrthreshold(){} // RVA: 0x7FFAC826B4F0
        public void set_Stderrthreshold(){} // RVA: 0x7FFAC826B550
        public void get_Minloglevel(){} // RVA: 0x7FFAC826B650
        public void set_Minloglevel(){} // RVA: 0x7FFAC826B6B0
        public void get_V(){} // RVA: 0x7FFAC826B7B0
        public void set_V(){} // RVA: 0x7FFAC826B810
        public void Initialize(){} // RVA: 0x7FFAC826B910
        public void Shutdown(){} // RVA: 0x7FFAC826B9F0
        public void .cctor(){} // RVA: 0x7FFAC826BA90
    }

    public class GpuBuffer : MpResourceHandle
    {
        // ── Methods ──
        public void DeleteMpPtr(){} // RVA: 0x7FFAC8272B00
    }

    public class GpuOrigin : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.GpuOrigin> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82C61D0
        public void get_Descriptor(){} // RVA: 0x7FFAC82C6230
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82C62F0
        public void .ctor(){} // RVA: 0x7FFAC81D3F10 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82C63E0
        public void Equals(){} // RVA: 0x7FFAC81D41A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D41E0
        public void ToString(){} // RVA: 0x7FFAC82C6590
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81D4270
        public void CalculateSize(){} // RVA: 0x7FFAC81D4290
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81D4390
        public void .cctor(){} // RVA: 0x7FFAC82C65E0
    }

    public class GpuOriginReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82C5C60
        public void .cctor(){} // RVA: 0x7FFAC82C5CC0
    }

    public class GpuResources : MpResourceHandle
    {
        public Mediapipe.SharedPtrHandle sharedPtr; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8272BC0
        public void DisposeManaged(){} // RVA: 0x7FFAC8272600
        public void DeleteMpPtr(){} // RVA: 0x7FFAC2F21310
        public void get_sharedPtr(){} // RVA: 0x7FFAC8272CF0
        public void Create(){} // RVA: 0x7FFAC8272D10
    }

}