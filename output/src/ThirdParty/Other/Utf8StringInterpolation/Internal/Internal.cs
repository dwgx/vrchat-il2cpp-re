// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Utf8StringInterpolation.Internal
// Classes: 1
// Methods: 3

namespace ThirdParty.Other.Utf8StringInterpolation.Internal
{
    public class ArrayBufferWriterPool : Object
    {
        public System.Collections.Concurrent.ConcurrentQueue`1<System.Buffers.ArrayBufferWriter`1<byte>> cache;

        // ── Methods ──
        public void Rent(){} // RVA: 0x7FFAC9CA4590
        public void Return(){} // RVA: 0x7FFAC9CA4750
        public void .cctor(){} // RVA: 0x7FFAC9CA4800
    }

}