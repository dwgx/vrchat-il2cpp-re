// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 2
// Methods: 20

namespace ThirdParty.DotNet.System.Net
{
    public class MonoChunkParser
    {
        public System.Net.WebHeaderCollection headers; // 0x10
        public int chunkSize; // 0x18
        public int chunkRead; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B6B490
        public void Read(){} // RVA: 0x6B6B630
        public void ReadFromChunks(){} // RVA: 0x6B6B640
        public void Write(){} // RVA: 0x6B6B990
        public void InternalWrite(){} // RVA: 0x6B6B9C0
        public void get_WantMore(){} // RVA: 0x6B6BCD0
        public void get_DataAvailable(){} // RVA: 0x6B6BCF0
        public void get_ChunkLeft(){} // RVA: 0x6B6BE00
        public void ReadBody(){} // RVA: 0x6B6BE10
        public void GetChunkSize(){} // RVA: 0x6B6BF80
        public void RemoveChunkExtension(){} // RVA: 0x6B6C260
        public void ReadCRLF(){} // RVA: 0x6B6C2B0
        public void ReadTrailer(){} // RVA: 0x6B6C390
        public void ThrowProtocolViolation(){} // RVA: 0x6B6C8E0
    }

    public class MonoChunkStream
    {
        public System.Net.WebHeaderCollection <Headers>k__BackingField; // 0x40

        // ── Methods ──
        public void get_Decoder(){} // RVA: 0x358730
        public void .ctor(){} // RVA: 0x6B6C9B0
        public void ProcessReadAsync(){} // RVA: 0x6B6CAE0
        public void FinishReading(){} // RVA: 0x6B6CD60
        public void ThrowExpectingChunkTrailer(){} // RVA: 0x6B6CF80
        public void <>n__0(){} // RVA: 0x6B6CFF0
    }

}