// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 47

namespace ThirdParty.DotNet.System.Net
{
    public class ReceiveState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CD2F50
    }

    public class RequestStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B6DF30 | overloaded x2
        public void get_CanRead(){} // RVA: 0x3C2850
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x2DD320
        public void get_Length(){} // RVA: 0x6B6E060
        public void get_Position(){} // RVA: 0x6B6E0A0
        public void set_Position(){} // RVA: 0x6B6E0E0
        public void Close(){} // RVA: 0xB04010
        public void Flush(){} // RVA: 0x2DD310
        public void FillFromBuffer(){} // RVA: 0x6B6E120
        public void Read(){} // RVA: 0x6B6E430
        public void BeginRead(){} // RVA: 0x6B6E550
        public void EndRead(){} // RVA: 0x6B6E860
        public void Seek(){} // RVA: 0x6B6EAC0
        public void SetLength(){} // RVA: 0x6B6EB00
        public void Write(){} // RVA: 0x6B6EB40
        public void BeginWrite(){} // RVA: 0x6B6EB80
        public void EndWrite(){} // RVA: 0x6B6EBC0
    }

    public class ResponseDescription
    {
        // ── Methods ──
        public void get_PositiveIntermediate(){} // RVA: 0x6CD2E00
        public void get_PositiveCompletion(){} // RVA: 0x6CD2E20
        public void get_TransientFailure(){} // RVA: 0x6CD2E40
        public void get_PermanentFailure(){} // RVA: 0x6CD2E60
        public void get_InvalidStatusCode(){} // RVA: 0x6CD2E80
        public void .ctor(){} // RVA: 0x6CD2EA0
    }

    public class ResponseStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B6EC00
        public void get_CanRead(){} // RVA: 0x2DD320
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x3C2850
        public void get_Length(){} // RVA: 0x6B6ED10
        public void get_Position(){} // RVA: 0x6B6ED50
        public void set_Position(){} // RVA: 0x6B6ED90
        public void Close(){} // RVA: 0x6B6EDD0
        public void GetHeaders(){} // RVA: 0x6B6F020
        public void Flush(){} // RVA: 0x2DD310
        public void GetChunkSizeBytes(){} // RVA: 0x6B6F250
        public void InternalWrite(){} // RVA: 0x6B6F360
        public void Write(){} // RVA: 0x6B6F3D0
        public void BeginWrite(){} // RVA: 0x6B6F710
        public void EndWrite(){} // RVA: 0x6B6F990
        public void Read(){} // RVA: 0x6B6FB90
        public void BeginRead(){} // RVA: 0x6B6FBD0
        public void EndRead(){} // RVA: 0x6B6FC10
        public void Seek(){} // RVA: 0x6B6FC50
        public void SetLength(){} // RVA: 0x6B6FC90
        public void .cctor(){} // RVA: 0x6B6FCD0
    }

}