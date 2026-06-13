// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Buffers
// Classes: 35
// Methods: 179

namespace ThirdParty.DotNet.System.Buffers
{
    public class ArrayBufferWriter`1
    {
        public T[] _buffer;
        public int _index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void get_WrittenMemory(){} // RVA: 0x283FA0
        public void get_WrittenCount(){} // RVA: 0xD840
        public void get_FreeCapacity(){} // RVA: 0xD840
        public void Clear(){} // RVA: 0x24A50
        public void Advance(){} // RVA: 0x24FA0
        public void GetMemory(){} // RVA: 0x283FA0
        public void CheckAndResizeBuffer(){} // RVA: 0x24FA0
        public void ThrowInvalidOperationException_AdvancedTooFar(){} // RVA: 0x25E50
        public void ThrowOutOfMemoryException(){} // RVA: 0x25E50
    }

    public class ArrayBufferWriter`1
    {
        public int ArrayMaxLength;
        public int DefaultInitialBufferSize;
        public T[] _buffer;
        public int _index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0 | overloaded x2
        public void get_WrittenMemory(){} // RVA: 0x283FA0
        public void get_WrittenSpan(){} // RVA: 0x283FA0
        public void get_WrittenCount(){} // RVA: 0xD840
        public void get_Capacity(){} // RVA: 0xD840
        public void get_FreeCapacity(){} // RVA: 0xD840
        public void Clear(){} // RVA: 0x24A50
        public void ResetWrittenCount(){} // RVA: 0x24A50
        public void Advance(){} // RVA: 0x24FA0
        public void GetMemory(){} // RVA: 0x283FA0
        public void GetSpan(){} // RVA: 0x283FA0
        public void CheckAndResizeBuffer(){} // RVA: 0x24FA0
        public void ThrowInvalidOperationException_AdvancedTooFar(){} // RVA: 0x25E50
        public void ThrowOutOfMemoryException(){} // RVA: 0x25E50
    }

    public class ArrayBufferWriter`1
    {
        public T[] _buffer;
        public int _index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0 | overloaded x2
        public void get_WrittenSpan(){} // RVA: 0x283FA0
        public void get_WrittenCount(){} // RVA: 0xD840
        public void get_FreeCapacity(){} // RVA: 0xD840
        public void Clear(){} // RVA: 0x24A50
        public void Advance(){} // RVA: 0x24FA0
        public void GetMemory(){} // RVA: 0x283FA0
        public void GetSpan(){} // RVA: 0x283FA0
        public void CheckAndResizeBuffer(){} // RVA: 0x24FA0
        public void ThrowInvalidOperationException_AdvancedTooFar(){} // RVA: 0x25E50
    }

    public class ArrayBufferWriter`1
    {
        public byte[] _buffer; // 0x10
        public int _index; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x38F5AE0 | overloaded x2
        public void get_WrittenSpan(){} // RVA: 0x38F5BD0
        public void get_WrittenCount(){} // RVA: 0x5BED50
        public void get_FreeCapacity(){} // RVA: 0x1A3E400
        public void Clear(){} // RVA: 0x38F5C90
        public void Advance(){} // RVA: 0x38F5D20
        public void GetMemory(){} // RVA: 0x38F5DD0
        public void GetSpan(){} // RVA: 0x38F5ED0
        public void CheckAndResizeBuffer(){} // RVA: 0x38F5F90
        public void ThrowInvalidOperationException_AdvancedTooFar(){} // RVA: 0x38F6110
    }

    public class ArrayPoolEventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E0F040
        public void BufferRented(){} // RVA: 0x5E0F0D0
        public void BufferAllocated(){} // RVA: 0x5E0F160
        public void BufferReturned(){} // RVA: 0x5E0F200
        public void BufferTrimmed(){} // RVA: 0x5E0F230
        public void BufferTrimPoll(){} // RVA: 0x5E0F260
        public void .cctor(){} // RVA: 0x5E0F380
    }

    public class ArrayPoolEventSource
    {
        // ── Methods ──
        public void BufferRented(){} // RVA: 0x62BCA20
        public void BufferAllocated(){} // RVA: 0x62BCAC0
        public void BufferReturned(){} // RVA: 0x5E0F200
        public void .ctor(){} // RVA: 0x5E0E7D0
        public void .cctor(){} // RVA: 0x62BCB70
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<T> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0xC960
        public void Create(){}
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<T> s_sharedInstance;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0xC960
        public void EnsureSharedCreated(){} // RVA: 0xC960
        public void Create(){} // RVA: 0xC960
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x24A50
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<T> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A3D5D0
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A3D6A0
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<T> s_sharedInstance;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x3A3D340
        public void EnsureSharedCreated(){} // RVA: 0x3A3D3F0
        public void Create(){} // RVA: 0x3A3D520
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<T> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A3D5D0
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A3D6A0
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<UnityEngine.GameObject> <Shared>k__BackingField;
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<Entry<UnityEngine.GameObject>> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A38B80
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A38C20
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<int> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A3C030
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A3C0D0
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<Cysharp.Threading.Tasks.UniTask`1<ÏÏÍÏÌÎÏÎÏÍÌÌÍÍÌÎÌÌÌÏÎÌÌ>> <Shared>k__BackingField;
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<System.ValueTuple`3<ÏÌÍÌÍÎÏÏÎÏÏÎÏÏÍÏÏÍÏÌÌÏÎ,ÌÍÏÏÍÎÎÌÎÏÎÌÌÍÍÍÌÏÍÎÌÍÎ,int>> <Shared>k__BackingField;
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<Cysharp.Threading.Tasks.UniTask`1<System.ValueTuple`3<ÏÌÍÌÍÎÏÏÎÏÏÎÏÏÍÏÏÍÏÌÌÏÎ,ÌÎÌÍÍÏÍÎÌÍÌÎÎÍÌÏÎÎÏÏÏÎÍ,int>>> <Shared>k__BackingField;
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<char> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A3BC90
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A3BD30
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<string> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A3C860
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A3C900
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<byte> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A3B800
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A3B8A0
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<System.ValueTuple`2<UnityEngine.Object,bool>> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A3A4E0
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A3A580
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<Slot<string>> <5;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A39DA0
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A39E40
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<ÎÌÏÏÍÎÍÎÌÍÎÌÍÌÌÎÎÎÍÎÏÏÏ> <Shared>k__BackingField;
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<System.DateTime> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A3BE60
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A3BF00
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<ÌÏÌÌÎÏÎÏÏÎÌÏÎÎÌÎÍÌÎÎÌÏÎ> <Shared>k__BackingField;
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<Entry<string>> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A38B80
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A38C20
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<ÏÌÎÌÌÌÎÍÌÎÎÌÍÍÌÎÍÎÎÏÎÌÏ> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A3C860
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A3C900
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<VRC.Core.Networking.IVRC_FlatBufferSerializer> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A3C860
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A3C900
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<Transmtn.DTO.Notifications.Notification> <Shared>k__BackingField;
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<long> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A3C3D0
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A3C470
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<Entry<Transmtn.DTO.Notifications.Notification>> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A38B80
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A38C20
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.ComponentInfoT> <Shared>k__BackingField;
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<byte> s_sharedInstance;
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<ÍÎÌÏÏÌÍÌÌÌÌÍÌÌÏÍÏÌÎÏÏÌÍ> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A3C860
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A3C900
    }

    public class ArrayPool`1
    {
        public System.Buffers.ArrayPool`1<uint> <Shared>k__BackingField;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x2174660
        public void Create(){} // RVA: 0x3A3CDD0
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x3A3CE70
    }

}