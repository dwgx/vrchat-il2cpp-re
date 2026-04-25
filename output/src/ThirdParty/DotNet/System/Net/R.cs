// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 47

namespace ThirdParty.DotNet.System.Net
{
    public class ReceiveState : Object
    {
        public System.Net.ResponseDescription Resp; // 0x10
        public int ValidThrough; // 0x18
        public byte[] Buffer; // 0x20
        public System.Net.CommandStream Connection; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC946B6B0
    }

    public class RequestStream : Stream
    {
        public byte[] CanRead; // 0x28
        public int CanSeek; // 0x30
        public int CanWrite; // 0x34
        public long Length; // 0x38
        public bool Position; // 0x40
        public System.IO.Stream stream; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9304AB0 | overloaded x2
        public void get_CanRead(){} // RVA: 0x7FFAC3006850
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC2F21320
        public void get_Length(){} // RVA: 0x7FFAC9304BE0
        public void get_Position(){} // RVA: 0x7FFAC9304C20
        public void set_Position(){} // RVA: 0x7FFAC9304C60
        public void Close(){} // RVA: 0x7FFAC37495E0
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void FillFromBuffer(){} // RVA: 0x7FFAC9304CA0
        public void Read(){} // RVA: 0x7FFAC9304FB0
        public void BeginRead(){} // RVA: 0x7FFAC93050D0
        public void EndRead(){} // RVA: 0x7FFAC93053E0
        public void Seek(){} // RVA: 0x7FFAC9305640
        public void SetLength(){} // RVA: 0x7FFAC9305680
        public void Write(){} // RVA: 0x7FFAC93056C0
        public void BeginWrite(){} // RVA: 0x7FFAC9305700
        public void EndWrite(){} // RVA: 0x7FFAC9305740
    }

    public class ResponseDescription : Object
    {
        public bool PositiveIntermediate; // 0x10
        public int PositiveCompletion; // 0x14
        public string TransientFailure; // 0x18
        public System.Text.StringBuilder PermanentFailure; // 0x20
        public string InvalidStatusCode; // 0x28

        // ── Methods ──
        public void get_PositiveIntermediate(){} // RVA: 0x7FFAC946B560
        public void get_PositiveCompletion(){} // RVA: 0x7FFAC946B580
        public void get_TransientFailure(){} // RVA: 0x7FFAC946B5A0
        public void get_PermanentFailure(){} // RVA: 0x7FFAC946B5C0
        public void get_InvalidStatusCode(){} // RVA: 0x7FFAC946B5E0
        public void .ctor(){} // RVA: 0x7FFAC946B600
    }

    public class ResponseStream : Stream
    {
        public System.Net.HttpListenerResponse CanRead; // 0x28
        public bool CanSeek; // 0x30
        public bool CanWrite; // 0x31
        public bool Length; // 0x32
        public System.IO.Stream Position; // 0x38
        public byte[] crlf;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9305780
        public void get_CanRead(){} // RVA: 0x7FFAC2F21320
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC3006850
        public void get_Length(){} // RVA: 0x7FFAC9305890
        public void get_Position(){} // RVA: 0x7FFAC93058D0
        public void set_Position(){} // RVA: 0x7FFAC9305910
        public void Close(){} // RVA: 0x7FFAC9305950
        public void GetHeaders(){} // RVA: 0x7FFAC9305BA0
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void GetChunkSizeBytes(){} // RVA: 0x7FFAC9305DD0
        public void InternalWrite(){} // RVA: 0x7FFAC9305EE0
        public void Write(){} // RVA: 0x7FFAC9305F50
        public void BeginWrite(){} // RVA: 0x7FFAC9306290
        public void EndWrite(){} // RVA: 0x7FFAC9306510
        public void Read(){} // RVA: 0x7FFAC9306710
        public void BeginRead(){} // RVA: 0x7FFAC9306750
        public void EndRead(){} // RVA: 0x7FFAC9306790
        public void Seek(){} // RVA: 0x7FFAC93067D0
        public void SetLength(){} // RVA: 0x7FFAC9306810
        public void .cctor(){} // RVA: 0x7FFAC9306850
    }

}