// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 2
// Methods: 20

namespace ThirdParty.DotNet.System.Net
{
    public class MonoChunkParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE95A9C0
        public void Read(){} // RVA: 0x7AE95AB60
        public void ReadFromChunks(){} // RVA: 0x7AE95AB70
        public void Write(){} // RVA: 0x7AE95AEC0
        public void InternalWrite(){} // RVA: 0x7AE95AEF0
        public void get_WantMore(){} // RVA: 0x7AE95B200
        public void get_DataAvailable(){} // RVA: 0x7AE95B220
        public void get_ChunkLeft(){} // RVA: 0x7AE95B330
        public void ReadBody(){} // RVA: 0x7AE95B340
        public void GetChunkSize(){} // RVA: 0x7AE95B4B0
        public void RemoveChunkExtension(){} // RVA: 0x7AE95B7A0
        public void ReadCRLF(){} // RVA: 0x7AE95B7F0
        public void ReadTrailer(){} // RVA: 0x7AE95B8D0
        public void ThrowProtocolViolation(){} // RVA: 0x7AE95BE20
    }

    public class MonoChunkStream : WebReadStream
    {
        // ── Methods ──
        public void get_Decoder(){} // RVA: 0x7A8152D80
        public void .ctor(){} // RVA: 0x7AE95BEF0
        public void ProcessReadAsync(){} // RVA: 0x7AE95C020
        public void FinishReading(){} // RVA: 0x7AE95C2A0
        public void ThrowExpectingChunkTrailer(){} // RVA: 0x7AE95C4C0
        public void <>n__0(){} // RVA: 0x7AE95C530
    }

}