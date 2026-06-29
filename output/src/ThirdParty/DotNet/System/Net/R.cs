// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 46

namespace ThirdParty.DotNet.System.Net
{
    public class ReceiveState : Object
    {
        public object Resp;
        public object ValidThrough;
        public object Buffer;
        public object Connection;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x77317F0
    }

    public class RequestStream : Stream
    {
        public object buffer;
        public object offset;
        public object length;
        public object remaining_body;
        public object disposed;
        public object stream;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75D0300
        public void get_CanRead(){} // RVA: 0xC2E4C0
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0xB43320
        public void get_Length(){} // RVA: 0x75D0430
        public void get_Position(){} // RVA: 0x75D0470
        public void set_Position(){} // RVA: 0x75D04B0
        public void Close(){} // RVA: 0x26B4710
        public void Flush(){} // RVA: 0xB43310
        public void FillFromBuffer(){} // RVA: 0x75D04F0
        public void Read(){} // RVA: 0x75D0800
        public void BeginRead(){} // RVA: 0x75D0910
        public void EndRead(){} // RVA: 0x75D0C10
        public void Seek(){} // RVA: 0x75D0E60
        public void SetLength(){} // RVA: 0x75D0EA0
        public void Write(){} // RVA: 0x75D0EE0
        public void BeginWrite(){} // RVA: 0x75D0F20
        public void EndWrite(){} // RVA: 0x75D0F60
    }

    public class ResponseDescription : Object
    {
        public object Multiline;
        public object Status;
        public object StatusDescription;
        public object StatusBuffer;
        public object StatusCodeString;

        // ── Methods ──
        public void get_PositiveIntermediate(){} // RVA: 0x77316A0
        public void get_PositiveCompletion(){} // RVA: 0x77316C0
        public void get_TransientFailure(){} // RVA: 0x77316E0
        public void get_PermanentFailure(){} // RVA: 0x7731700
        public void get_InvalidStatusCode(){} // RVA: 0x7731720
        public void .ctor(){} // RVA: 0x7731740
    }

    public class ResponseStream : Stream
    {
        public object response;
        public object ignore_errors;
        public object disposed;
        public object trailer_sent;
        public object stream;
        public object crlf;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75D0FA0
        public void get_CanRead(){} // RVA: 0xB43320
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0xC2E4C0
        public void get_Length(){} // RVA: 0x75D10B0
        public void get_Position(){} // RVA: 0x75D10F0
        public void set_Position(){} // RVA: 0x75D1130
        public void Close(){} // RVA: 0x75D1170
        public void GetHeaders(){} // RVA: 0x75D13C0
        public void Flush(){} // RVA: 0xB43310
        public void GetChunkSizeBytes(){} // RVA: 0x75D15B0
        public void InternalWrite(){} // RVA: 0x75D16B0
        public void Write(){} // RVA: 0x75D1720
        public void BeginWrite(){} // RVA: 0x75D1A60
        public void EndWrite(){} // RVA: 0x75D1CE0
        public void Read(){} // RVA: 0x75D1EE0
        public void BeginRead(){} // RVA: 0x75D1F20
        public void EndRead(){} // RVA: 0x75D1F60
        public void Seek(){} // RVA: 0x75D1FA0
        public void SetLength(){} // RVA: 0x75D1FE0
        public void .cctor(){} // RVA: 0x75D2020
    }

}