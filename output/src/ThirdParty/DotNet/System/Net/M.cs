// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 2
// Methods: 20

namespace ThirdParty.DotNet.System.Net
{
    public class MonoChunkParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF961B490
        public void Read(){} // RVA: 0x7FFAF961B630
        public void ReadFromChunks(){} // RVA: 0x7FFAF961B640
        public void Write(){} // RVA: 0x7FFAF961B990
        public void InternalWrite(){} // RVA: 0x7FFAF961B9C0
        public void get_WantMore(){} // RVA: 0x7FFAF961BCD0
        public void get_DataAvailable(){} // RVA: 0x7FFAF961BCF0
        public void get_ChunkLeft(){} // RVA: 0x7FFAF961BE00
        public void ReadBody(){} // RVA: 0x7FFAF961BE10
        public void GetChunkSize(){} // RVA: 0x7FFAF961BF80
        public void RemoveChunkExtension(){} // RVA: 0x7FFAF961C260
        public void ReadCRLF(){} // RVA: 0x7FFAF961C2B0
        public void ReadTrailer(){} // RVA: 0x7FFAF961C390
        public void ThrowProtocolViolation(){} // RVA: 0x7FFAF961C8E0
    }

    public class MonoChunkStream
    {
        // ── Methods ──
        public void get_Decoder(){} // RVA: 0x7FFAF2E08730
        public void .ctor(){} // RVA: 0x7FFAF961C9B0
        public void ProcessReadAsync(){} // RVA: 0x7FFAF961CAE0
        public void FinishReading(){} // RVA: 0x7FFAF961CD60
        public void ThrowExpectingChunkTrailer(){} // RVA: 0x7FFAF961CF80
        public void <>n__0(){} // RVA: 0x7FFAF961CFF0
    }

}