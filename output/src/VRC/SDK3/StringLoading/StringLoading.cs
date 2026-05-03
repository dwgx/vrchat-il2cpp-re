// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.StringLoading
// Classes: 4
// Methods: 39

namespace VRC.SDK3.StringLoading
{
    public class IVRCStringDownload
    {
        // ── Methods ──
        public void get_Result(){} // RVA: 0x7FFE80E2E2E0
        public void get_ResultBytes(){} // RVA: 0x7FFE80E2E2E0
        public void get_Error(){} // RVA: 0x7FFE80E2E2E0
        public void get_ErrorCode(){} // RVA: 0x7FFE80E2EDB0
        public void get_Url(){} // RVA: 0x7FFE80E2E2E0
        public void get_UdonBehaviour(){} // RVA: 0x7FFE80E2E2E0
        public void StartDownload(){} // RVA: 0x7FFE80E45FE0
        public void CancelDownload(){} // RVA: 0x7FFE80E45FE0
    }

    public class MaxBufferDownloadHandler : DownloadHandlerScript
    {
        public int _max; // 0x18

        // ── Methods ──
        public void get_downloadedBytes(){} // RVA: 0x7FFE8A4657B0
        public void .ctor(){} // RVA: 0x7FFE8A465910 | overloaded x2
        public void ReceiveContentLengthHeader(){} // RVA: 0x7FFE8A465A80
        public void ReceiveData(){} // RVA: 0x7FFE8A465AF0
    }

    public class VRCStringDownload : Object
    {
        public float MINIMUM_DELAY_BETWEEN_REQUESTS;
        public int MAXIMUM_DOWNLOAD_SIZE_MB;
        public float _lastStringRequest;
        public string _result; // 0x10
        public byte[] _resultBytes; // 0x18
        public string _error; // 0x20

        // ── Methods ──
        public void get_Result(){} // RVA: 0x7FFE8A465C00
        public void get_ResultBytes(){} // RVA: 0x7FFE810FE7C0
        public void set_ResultBytes(){} // RVA: 0x7FFE81161E80
        public void get_Error(){} // RVA: 0x7FFE811290C0
        public void set_Error(){} // RVA: 0x7FFE811290D0
        public void get_ErrorCode(){} // RVA: 0x7FFE81549710
        public void set_ErrorCode(){} // RVA: 0x7FFE817E4800
        public void get_Url(){} // RVA: 0x7FFE8144E200
        public void set_Url(){} // RVA: 0x7FFE81129890
        public void get_UdonBehaviour(){} // RVA: 0x7FFE8143BA80
        public void set_UdonBehaviour(){} // RVA: 0x7FFE81437330
        public void .ctor(){} // RVA: 0x7FFE8A465CB0
        public void StartDownload(){} // RVA: 0x7FFE8A465E20
        public void StartAtCorrectTime(){} // RVA: 0x7FFE8A4664C0
        public void CompletedRequest(){} // RVA: 0x7FFE8A466670
        public void CancelDownload(){} // RVA: 0x7FFE8A466AD0
        public void .cctor(){} // RVA: 0x7FFE8A466D20
        public void <StartAtCorrectTime>b__32_1(){} // RVA: 0x7FFE8A466D60
    }

    public class VRCStringDownloader : Object
    {
        public System.Collections.Generic.List`1<VRC.SDK3.StringLoading.IVRCStringDownload> _stringDownloads;

        // ── Methods ──
        public void get_StartDownload(){} // RVA: 0x7FFE8A467510
        public void set_StartDownload(){} // RVA: 0x7FFE8A467570
        public void LoadUrl(){} // RVA: 0x7FFE8A467630
        public void LoadUrlInternal(){} // RVA: 0x7FFE8A4676F0
        public void AddToManager(){} // RVA: 0x7FFE8A467890
        public void RemoveFromManager(){} // RVA: 0x7FFE8A4679A0
        public void ClearQueue(){} // RVA: 0x7FFE8A467A30
        public void .cctor(){} // RVA: 0x7FFE8A467C70
    }

}