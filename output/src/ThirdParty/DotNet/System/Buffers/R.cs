// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Buffers
// Classes: 13
// Methods: 114

namespace ThirdParty.DotNet.System.Buffers
{
    public class ReadOnlySequence
    {
        // ── Methods ──
        public void ArrayToSequenceStart(){} // RVA: 0x20C5210
        public void ArrayToSequenceEnd(){} // RVA: 0x5E0F630
    }

    public class ReadOnlySequence
    {
        // ── Methods ──
        public void ArrayToSequenceStart(){} // RVA: 0x20C5210
        public void ArrayToSequenceEnd(){} // RVA: 0x5E0F630
    }

    public class ReadOnlySequenceDebugView`1
    {
    }

    public class ReadOnlySequenceDebugView`1
    {
    }

    public class ReadOnlySequenceSegment`1
    {
        public System.ReadOnlyMemory`1<T> Memory;
        public System.Buffers.ReadOnlySequenceSegment`1<T> Next;
        public long RunningIndex;

        // ── Methods ──
        public void get_Memory(){} // RVA: 0x283FA0
        public void get_Next(){} // RVA: 0xCD60
        public void get_RunningIndex(){} // RVA: 0xCD60
    }

    public class ReadOnlySequenceSegment`1
    {
        public System.ReadOnlyMemory`1<T> Length;
        public System.Buffers.ReadOnlySequenceSegment`1<T> IsEmpty;
        public long IsSingleSegment;

        // ── Methods ──
        public void get_Memory(){} // RVA: 0x283FA0
        public void get_Next(){} // RVA: 0xCD60
        public void get_RunningIndex(){} // RVA: 0xCD60
    }

    public class ReadOnlySequenceSegment`1
    {
        public System.ReadOnlyMemory`1<byte> <Memory>k__BackingField; // 0x10
        public System.Buffers.ReadOnlySequenceSegment`1<byte> <Next>k__BackingField; // 0x20
        public long <RunningIndex>k__BackingField; // 0x28
    }

    public class ReadOnlySequenceSegment`1
    {
        public System.ReadOnlyMemory`1<byte> <Memory>k__BackingField; // 0x10
        public System.Buffers.ReadOnlySequenceSegment`1<byte> <Next>k__BackingField; // 0x20
        public long <RunningIndex>k__BackingField; // 0x28
    }

    public class ReadOnlySequence`1
    {
        public object System.Threading.Tasks; // 0x10
        public object _endObject; // 0x18
        public int _startInteger; // 0x20
        public int _endInteger; // 0x24
        public System.Buffers.ReadOnlySequence`1<byte> Empty;
    }

    public class ReadOnlySequence`1
    {
        public object Item;
        public object Length;
        public int IsEmpty;
        public int _endInteger;
        public System.Buffers.ReadOnlySequence`1<T> Empty;

        // ── Methods ──
        public void get_Length(){} // RVA: 0xCD60
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void get_IsSingleSegment(){} // RVA: 0xDBE0
        public void get_First(){} // RVA: 0x283FA0
        public void get_Start(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24B10 | overloaded x2
        public void Slice(){} // RVA: 0x283FA0 | overloaded x3
        public void ToString(){} // RVA: 0xCD60
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void GetPosition(){} // RVA: 0x283FA0
        public void TryGet(){}
        public void TryGetBuffer(){}
        public void GetFirstBuffer(){} // RVA: 0x283FA0
        public void GetFirstBufferSlow(){} // RVA: 0x283FA0
        public void Seek(){} // RVA: 0x283FA0 | overloaded x2
        public void SeekMultiSegment(){} // RVA: 0x283FA0
        public void BoundsCheck(){} // RVA: 0x283FA0
        public void GetEndPosition(){} // RVA: 0x283FA0
        public void GetSequenceType(){} // RVA: 0x283FA0
        public void GetIndex(){} // RVA: 0x13FF0 | overloaded x2
        public void SliceImpl(){} // RVA: 0x283FA0 | overloaded x2
        public void GetLength(){} // RVA: 0xCD60
        public void TryGetString(){}
        public void .cctor(){} // RVA: 0x24A80
    }

    public class ReadOnlySequence`1
    {
        public System.SequencePosition _sequenceStart;
        public System.SequencePosition _sequenceEnd;
        public System.Buffers.ReadOnlySequence`1<T> Empty;

        // ── Methods ──
        public void get_Length(){} // RVA: 0xCD60
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void get_IsSingleSegment(){} // RVA: 0xDBE0
        public void get_First(){} // RVA: 0x283FA0
        public void get_Start(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24B10 | overloaded x2
        public void Slice(){} // RVA: 0x283FA0 | overloaded x2
        public void ToString(){} // RVA: 0xCD60
        public void TryGet(){}
        public void TryGetBuffer(){}
        public void GetFirstBuffer(){} // RVA: 0x283FA0
        public void SeekMultiSegment(){} // RVA: 0x283FA0
        public void BoundsCheck(){} // RVA: 0x283FA0
        public void GetEndPosition(){} // RVA: 0x283FA0
        public void GetSequenceType(){} // RVA: 0x283FA0
        public void GetIndex(){} // RVA: 0xD920
        public void SliceImpl(){} // RVA: 0x283FA0
        public void GetLength(){} // RVA: 0xCD60
        public void TryGetString(){}
        public void .cctor(){} // RVA: 0x24A80
    }

    public class ReadOnlySequence`1
    {
        public System.SequencePosition _sequenceStart; // 0x10
        public System.SequencePosition _sequenceEnd; // 0x20
        public System.Buffers.ReadOnlySequence`1<byte> Empty;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x3F214E0
        public void get_IsEmpty(){} // RVA: 0x3F21570
        public void get_IsSingleSegment(){} // RVA: 0x3F21600
        public void get_First(){} // RVA: 0x3F21610
        public void get_Start(){} // RVA: 0x75E7E0
        public void .ctor(){} // RVA: 0x3F21850 | overloaded x2
        public void Slice(){} // RVA: 0x3F220C0 | overloaded x2
        public void ToString(){} // RVA: 0x3F22220
        public void TryGet(){} // RVA: 0x3F22610
        public void TryGetBuffer(){} // RVA: 0x3F22730
        public void GetFirstBuffer(){} // RVA: 0x3F22FC0
        public void SeekMultiSegment(){} // RVA: 0x3F23780
        public void BoundsCheck(){} // RVA: 0x3F23880
        public void GetEndPosition(){} // RVA: 0x3F23D60
        public void GetSequenceType(){} // RVA: 0x3F23F40
        public void GetIndex(){} // RVA: 0x3F23F60
        public void SliceImpl(){} // RVA: 0x3F23F70
        public void GetLength(){} // RVA: 0x3F24090
        public void TryGetString(){} // RVA: 0x3F24270
        public void .cctor(){} // RVA: 0x3F245F0
    }

    public class ReadOnlySequence`1
    {
        public object _startObject; // 0x10
        public object _endObject; // 0x18
        public int _startInteger; // 0x20
        public int _endInteger; // 0x24
        public System.Buffers.ReadOnlySequence`1<byte> Empty;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x3F247A0
        public void get_IsEmpty(){} // RVA: 0x3F24830
        public void get_IsSingleSegment(){} // RVA: 0x3F248C0
        public void get_First(){} // RVA: 0x3F248D0
        public void get_Start(){} // RVA: 0x3F24980
        public void .ctor(){} // RVA: 0x3F24AD0 | overloaded x2
        public void Slice(){} // RVA: 0x3F253D0 | overloaded x3
        public void ToString(){} // RVA: 0x3F25510
        public void GetEnumerator(){} // RVA: 0x3F25B70
        public void GetPosition(){} // RVA: 0x3F25BD0
        public void TryGet(){} // RVA: 0x3F25CB0
        public void TryGetBuffer(){} // RVA: 0x3F25DD0
        public void GetFirstBuffer(){} // RVA: 0x3F26630
        public void GetFirstBufferSlow(){} // RVA: 0x3F26A20
        public void Seek(){} // RVA: 0x3F271E0 | overloaded x2
        public void SeekMultiSegment(){} // RVA: 0x3F274C0
        public void BoundsCheck(){} // RVA: 0x3F275C0
        public void GetEndPosition(){} // RVA: 0x3F27AB0
        public void GetSequenceType(){} // RVA: 0x3F27C90
        public void GetIndex(){} // RVA: 0x3F27CB0 | overloaded x2
        public void SliceImpl(){} // RVA: 0x3F27DE0 | overloaded x2
        public void GetLength(){} // RVA: 0x3F27ED0
        public void TryGetString(){} // RVA: 0x3F28120
        public void .cctor(){} // RVA: 0x3F284A0
    }

}