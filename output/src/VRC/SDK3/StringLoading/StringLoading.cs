// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.StringLoading
// Classes: 4
// Methods: 39

namespace VRC.SDK3.StringLoading
{
    public class IVRCStringDownload
    {
        // ── Methods ──
        public void get_Result(){} // RVA: 0x7FFAF2ABCD60
        public void get_ResultBytes(){} // RVA: 0x7FFAF2ABCD60
        public void get_Error(){} // RVA: 0x7FFAF2ABCD60
        public void get_ErrorCode(){} // RVA: 0x7FFAF2ABD840
        public void get_Url(){} // RVA: 0x7FFAF2ABCD60
        public void get_UdonBehaviour(){} // RVA: 0x7FFAF2ABCD60
        public void StartDownload(){} // RVA: 0x7FFAF2AD4A50
        public void CancelDownload(){} // RVA: 0x7FFAF2AD4A50
    }

    public class MaxBufferDownloadHandler
    {
        // ── Methods ──
        public void get_downloadedBytes(){} // RVA: 0x7FFAFC4B9D80
        public void .ctor(){} // RVA: 0x7FFAFC4B9EE0 | overloaded x2
        public void ReceiveContentLengthHeader(){} // RVA: 0x7FFAFC4BA050
        public void ReceiveData(){} // RVA: 0x7FFAFC4BA0C0
    }

    public class VRCStringDownload
    {
        // ── Methods ──
        public void get_Result(){} // RVA: 0x7FFAFC4BA1D0
        public void get_ResultBytes(){} // RVA: 0x7FFAF2D907C0
        public void set_ResultBytes(){} // RVA: 0x7FFAF2DF3E80
        public void get_Error(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Error(){} // RVA: 0x7FFAF2DBB0D0
        public void get_ErrorCode(){} // RVA: 0x7FFAF3241DC0
        public void set_ErrorCode(){} // RVA: 0x7FFAF3503440
        public void get_Url(){} // RVA: 0x7FFAF30E74D0
        public void set_Url(){} // RVA: 0x7FFAF2DBB890
        public void get_UdonBehaviour(){} // RVA: 0x7FFAF2F476A0
        public void set_UdonBehaviour(){} // RVA: 0x7FFAF2F4B830
        public void .ctor(){} // RVA: 0x7FFAFC4BA280
        public void StartDownload(){} // RVA: 0x7FFAFC4BA3F0
        public void StartAtCorrectTime(){} // RVA: 0x7FFAFC4BAA90
        public void CompletedRequest(){} // RVA: 0x7FFAFC4BAC40
        public void CancelDownload(){} // RVA: 0x7FFAFC4BB0A0
        public void .cctor(){} // RVA: 0x7FFAFC4BB2F0
        public void <StartAtCorrectTime>b__32_1(){} // RVA: 0x7FFAFC4BB330
    }

    public class VRCStringDownloader
    {
        // ── Methods ──
        public void get_StartDownload(){} // RVA: 0x7FFAFC4BBAE0
        public void set_StartDownload(){} // RVA: 0x7FFAFC4BBB40
        public void LoadUrl(){} // RVA: 0x7FFAFC4BBC00
        public void LoadUrlInternal(){} // RVA: 0x7FFAFC4BBCC0
        public void AddToManager(){} // RVA: 0x7FFAFC4BBE60
        public void RemoveFromManager(){} // RVA: 0x7FFAFC4BBF70
        public void ClearQueue(){} // RVA: 0x7FFAFC4BC000
        public void .cctor(){} // RVA: 0x7FFAFC4BC240
    }

}