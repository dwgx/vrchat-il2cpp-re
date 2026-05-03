// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 47

namespace ThirdParty.DotNet.System.Net
{
    public class ReceiveState : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87813DF0
    }

    public class RequestStream : Stream
    {
        public byte[] buffer; // 0x28
        public int offset; // 0x30
        public int length; // 0x34
        public long remaining_body; // 0x38
        public bool disposed; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876AD1E0 | overloaded x2
        public void get_CanRead(){} // RVA: 0x7FFE811E0850
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE810FB320
        public void get_Length(){} // RVA: 0x7FFE876AD310
        public void get_Position(){} // RVA: 0x7FFE876AD350
        public void set_Position(){} // RVA: 0x7FFE876AD390
        public void Close(){} // RVA: 0x7FFE82BBB440
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void FillFromBuffer(){} // RVA: 0x7FFE876AD3D0
        public void Read(){} // RVA: 0x7FFE876AD6E0
        public void BeginRead(){} // RVA: 0x7FFE876AD800
        public void EndRead(){} // RVA: 0x7FFE876ADB10
        public void Seek(){} // RVA: 0x7FFE876ADD70
        public void SetLength(){} // RVA: 0x7FFE876ADDB0
        public void Write(){} // RVA: 0x7FFE876ADDF0
        public void BeginWrite(){} // RVA: 0x7FFE876ADE30
        public void EndWrite(){} // RVA: 0x7FFE876ADE70
    }

    public class ResponseDescription : Object
    {
        public bool Multiline; // 0x10
        public int Status; // 0x14
        public string StatusDescription; // 0x18
        public System.Text.StringBuilder StatusBuffer; // 0x20
        public string StatusCodeString; // 0x28

        // ── Methods ──
        public void get_PositiveIntermediate(){} // RVA: 0x7FFE87813CA0
        public void get_PositiveCompletion(){} // RVA: 0x7FFE87813CC0
        public void get_TransientFailure(){} // RVA: 0x7FFE87813CE0
        public void get_PermanentFailure(){} // RVA: 0x7FFE87813D00
        public void get_InvalidStatusCode(){} // RVA: 0x7FFE87813D20
        public void .ctor(){} // RVA: 0x7FFE87813D40
    }

    public class ResponseStream : Stream
    {
        public System.Net.HttpListenerResponse response; // 0x28
        public bool ignore_errors; // 0x30
        public bool disposed; // 0x31
        public bool trailer_sent; // 0x32
        public System.IO.Stream stream; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876ADEB0
        public void get_CanRead(){} // RVA: 0x7FFE810FB320
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE811E0850
        public void get_Length(){} // RVA: 0x7FFE876ADFC0
        public void get_Position(){} // RVA: 0x7FFE876AE000
        public void set_Position(){} // RVA: 0x7FFE876AE040
        public void Close(){} // RVA: 0x7FFE876AE080
        public void GetHeaders(){} // RVA: 0x7FFE876AE2D0
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void GetChunkSizeBytes(){} // RVA: 0x7FFE876AE500
        public void InternalWrite(){} // RVA: 0x7FFE876AE610
        public void Write(){} // RVA: 0x7FFE876AE680
        public void BeginWrite(){} // RVA: 0x7FFE876AE9C0
        public void EndWrite(){} // RVA: 0x7FFE876AEC40
        public void Read(){} // RVA: 0x7FFE876AEE40
        public void BeginRead(){} // RVA: 0x7FFE876AEE80
        public void EndRead(){} // RVA: 0x7FFE876AEEC0
        public void Seek(){} // RVA: 0x7FFE876AEF00
        public void SetLength(){} // RVA: 0x7FFE876AEF40
        public void .cctor(){} // RVA: 0x7FFE876AEF80
    }

}