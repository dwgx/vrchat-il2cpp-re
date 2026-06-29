// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 2
// Methods: 20

namespace ThirdParty.DotNet.System.Net
{
    public class MonoChunkParser : Object
    {
        public object headers;
        public object chunkSize;
        public object chunkRead;
        public object totalWritten;
        public object state;
        public object saved;
        public object sawCR;
        public object gotit;
        public object trailerState;
        public object chunks;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75CD870
        public void Read(){} // RVA: 0x75CDA10
        public void ReadFromChunks(){} // RVA: 0x75CDA20
        public void Write(){} // RVA: 0x75CDD70
        public void InternalWrite(){} // RVA: 0x75CDDA0
        public void get_WantMore(){} // RVA: 0x75CE0B0
        public void get_DataAvailable(){} // RVA: 0x75CE0D0
        public void get_ChunkLeft(){} // RVA: 0x75CE1E0
        public void ReadBody(){} // RVA: 0x75CE1F0
        public void GetChunkSize(){} // RVA: 0x75CE360
        public void RemoveChunkExtension(){} // RVA: 0x75CE650
        public void ReadCRLF(){} // RVA: 0x75CE6A0
        public void ReadTrailer(){} // RVA: 0x75CE780
        public void ThrowProtocolViolation(){} // RVA: 0x75CECC0
    }

    public class MonoChunkStream : WebReadStream
    {
        public object _headers;
        public object _decoder;

        // ── Methods ──
        public void get_Decoder(){} // RVA: 0xBBF8F0
        public void .ctor(){} // RVA: 0x75CED90
        public void ProcessReadAsync(){} // RVA: 0x75CEEC0
        public void FinishReading(){} // RVA: 0x75CF140
        public void ThrowExpectingChunkTrailer(){} // RVA: 0x75CF360
        public void <>n__0(){} // RVA: 0x75CF3D0
    }

}