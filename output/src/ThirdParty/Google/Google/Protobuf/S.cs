// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 1
// Methods: 13

namespace ThirdParty.Google.Google.Protobuf
{
    public class SegmentedBufferHelper
    {
        public System.Nullable`1<int> totalLength; // 0x10
        public Enumerator<byte> readOnlySequenceEnumerator; // 0x18

        // ── Methods ──
        public void Initialize(){} // RVA: 0x5A30E10 | overloaded x2
        public void RefillBuffer(){} // RVA: 0x5A31160
        public void get_TotalLength(){} // RVA: 0x1AD4690
        public void get_CodedInputStream(){} // RVA: 0x35A740
        public void PushLimit(){} // RVA: 0x5A31190
        public void PopLimit(){} // RVA: 0x5A31230
        public void IsReachedLimit(){} // RVA: 0x5A31260
        public void IsAtEnd(){} // RVA: 0x5A31280
        public void RefillFromReadOnlySequence(){} // RVA: 0x5A312D0
        public void RefillFromCodedInputStream(){} // RVA: 0x5A314F0
        public void RecomputeBufferSizeAfterLimit(){} // RVA: 0x5A31710
        public void CheckCurrentBufferIsEmpty(){} // RVA: 0x5A31740
    }

}