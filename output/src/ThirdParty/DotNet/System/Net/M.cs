// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 2
// Methods: 20

namespace ThirdParty.DotNet.System.Net
{
    public class MonoChunkParser : Object
    {
        public System.Net.WebHeaderCollection WantMore; // 0x10
        public int DataAvailable; // 0x18
        public int ChunkLeft; // 0x1C
        public int totalWritten; // 0x20
        public 0x6B13D6C8 state; // 0x24
        public System.Text.StringBuilder saved; // 0x28
        public bool sawCR; // 0x30
        public bool gotit; // 0x31
        public int trailerState; // 0x34
        public System.Collections.ArrayList chunks; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9302010
        public void Read(){} // RVA: 0x7FFAC93021B0
        public void ReadFromChunks(){} // RVA: 0x7FFAC93021C0
        public void Write(){} // RVA: 0x7FFAC9302510
        public void InternalWrite(){} // RVA: 0x7FFAC9302540
        public void get_WantMore(){} // RVA: 0x7FFAC9302850
        public void get_DataAvailable(){} // RVA: 0x7FFAC9302870
        public void get_ChunkLeft(){} // RVA: 0x7FFAC9302980
        public void ReadBody(){} // RVA: 0x7FFAC9302990
        public void GetChunkSize(){} // RVA: 0x7FFAC9302B00
        public void RemoveChunkExtension(){} // RVA: 0x7FFAC9302DE0
        public void ReadCRLF(){} // RVA: 0x7FFAC9302E30
        public void ReadTrailer(){} // RVA: 0x7FFAC9302F10
        public void ThrowProtocolViolation(){} // RVA: 0x7FFAC9303460
    }

    public class MonoChunkStream : WebReadStream
    {
        public System.Net.WebHeaderCollection Decoder; // 0x40
        public System.Net.MonoChunkParser <Decoder>k__BackingField; // 0x48

        // ── Methods ──
        public void get_Decoder(){} // RVA: 0x7FFAC2F9C730
        public void .ctor(){} // RVA: 0x7FFAC9303530
        public void ProcessReadAsync(){} // RVA: 0x7FFAC9303660
        public void FinishReading(){} // RVA: 0x7FFAC93038E0
        public void ThrowExpectingChunkTrailer(){} // RVA: 0x7FFAC9303B00
        public void <>n__0(){} // RVA: 0x7FFAC9303B70
    }

}