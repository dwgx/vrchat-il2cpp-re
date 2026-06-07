// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.StringLoading
// Classes: 4
// Methods: 39

namespace VRC.SDK3.StringLoading
{
    public class IVRCStringDownload
    {
        // ── Methods ──
        public void get_Result(){} // RVA: 0xCD60
        public void get_ResultBytes(){} // RVA: 0xCD60
        public void get_Error(){} // RVA: 0xCD60
        public void get_ErrorCode(){} // RVA: 0xD840
        public void get_Url(){} // RVA: 0xCD60
        public void get_UdonBehaviour(){} // RVA: 0xCD60
        public void StartDownload(){} // RVA: 0x24A50
        public void CancelDownload(){} // RVA: 0x24A50
    }

    public class MaxBufferDownloadHandler
    {
        // ── Methods ──
        public void get_downloadedBytes(){} // RVA: 0x9A09D80
        public void .ctor(){} // RVA: 0x9A09EE0 | overloaded x2
        public void ReceiveContentLengthHeader(){} // RVA: 0x9A0A050
        public void ReceiveData(){} // RVA: 0x9A0A0C0
    }

    public class VRCStringDownload
    {
        // ── Methods ──
        public void get_Result(){} // RVA: 0x9A0A1D0
        public void get_ResultBytes(){} // RVA: 0x2E07C0
        public void set_ResultBytes(){} // RVA: 0x343E80
        public void get_Error(){} // RVA: 0x30B0C0
        public void set_Error(){} // RVA: 0x30B0D0
        public void get_ErrorCode(){} // RVA: 0x791DC0
        public void set_ErrorCode(){} // RVA: 0xA53440
        public void get_Url(){} // RVA: 0x6374D0
        public void set_Url(){} // RVA: 0x30B890
        public void get_UdonBehaviour(){} // RVA: 0x4976A0
        public void set_UdonBehaviour(){} // RVA: 0x49B830
        public void .ctor(){} // RVA: 0x9A0A280
        public void StartDownload(){} // RVA: 0x9A0A3F0
        public void StartAtCorrectTime(){} // RVA: 0x9A0AA90
        public void CompletedRequest(){} // RVA: 0x9A0AC40
        public void CancelDownload(){} // RVA: 0x9A0B0A0
        public void .cctor(){} // RVA: 0x9A0B2F0
        public void <StartAtCorrectTime>b__32_1(){} // RVA: 0x9A0B330
    }

    public class VRCStringDownloader
    {
        // ── Methods ──
        public void get_StartDownload(){} // RVA: 0x9A0BAE0
        public void set_StartDownload(){} // RVA: 0x9A0BB40
        public void LoadUrl(){} // RVA: 0x9A0BC00
        public void LoadUrlInternal(){} // RVA: 0x9A0BCC0
        public void AddToManager(){} // RVA: 0x9A0BE60
        public void RemoveFromManager(){} // RVA: 0x9A0BF70
        public void ClearQueue(){} // RVA: 0x9A0C000
        public void .cctor(){} // RVA: 0x9A0C240
    }

}