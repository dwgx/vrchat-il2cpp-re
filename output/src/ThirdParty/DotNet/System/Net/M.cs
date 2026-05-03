// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 2
// Methods: 20

namespace ThirdParty.DotNet.System.Net
{
    public class MonoChunkParser : Object
    {
        public System.Net.WebHeaderCollection headers; // 0x10
        public int chunkSize; // 0x18
        public int chunkRead; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876AA740
        public void Read(){} // RVA: 0x7FFE876AA8E0
        public void ReadFromChunks(){} // RVA: 0x7FFE876AA8F0
        public void Write(){} // RVA: 0x7FFE876AAC40
        public void InternalWrite(){} // RVA: 0x7FFE876AAC70
        public void get_WantMore(){} // RVA: 0x7FFE876AAF80
        public void get_DataAvailable(){} // RVA: 0x7FFE876AAFA0
        public void get_ChunkLeft(){} // RVA: 0x7FFE876AB0B0
        public void ReadBody(){} // RVA: 0x7FFE876AB0C0
        public void GetChunkSize(){} // RVA: 0x7FFE876AB230
        public void RemoveChunkExtension(){} // RVA: 0x7FFE876AB510
        public void ReadCRLF(){} // RVA: 0x7FFE876AB560
        public void ReadTrailer(){} // RVA: 0x7FFE876AB640
        public void ThrowProtocolViolation(){} // RVA: 0x7FFE876ABB90
    }

    public class MonoChunkStream : WebReadStream
    {
        public System.Net.WebHeaderCollection _headers; // 0x40

        // ── Methods ──
        public void get_Decoder(){} // RVA: 0x7FFE81176730
        public void .ctor(){} // RVA: 0x7FFE876ABC60
        public void ProcessReadAsync(){} // RVA: 0x7FFE876ABD90
        public void FinishReading(){} // RVA: 0x7FFE876AC010
        public void ThrowExpectingChunkTrailer(){} // RVA: 0x7FFE876AC230
        public void <>n__0(){} // RVA: 0x7FFE876AC2A0
    }

}