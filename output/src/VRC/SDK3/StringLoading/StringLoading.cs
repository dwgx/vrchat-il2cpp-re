// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.StringLoading
// Classes: 5
// Methods: 53

namespace VRC.SDK3.StringLoading
{
    public class IVRCStringDownload
    {
        // ── Methods ──
        public void get_Result(){} // RVA: 0x87C0A0
        public void get_ResultBytes(){} // RVA: 0x87C0A0
        public void get_Error(){} // RVA: 0x87C0A0
        public void get_ErrorCode(){} // RVA: 0x87C130
        public void get_Url(){} // RVA: 0x87C0A0
        public void get_UdonBehaviour(){} // RVA: 0x87C0A0
        public void StartDownload(){} // RVA: 0x894290
        public void CancelDownload(){} // RVA: 0x894290
    }

    public class IVRCStringDownload[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class MaxBufferDownloadHandler : DownloadHandlerScript
    {
        public object _max;
        public object _current;
        public object _buffer;
        public object lengthFail;

        // ── Methods ──
        public void get_downloadedBytes(){} // RVA: 0xA6B33A0
        public void .ctor(){} // RVA: 0xA6B3500
        public void ReceiveContentLengthHeader(){} // RVA: 0xA6B3670
        public void ReceiveData(){} // RVA: 0xA6B36E0
    }

    public class VRCStringDownload : Object
    {
        public object MINIMUM_DELAY_BETWEEN_REQUESTS;
        public object MAXIMUM_DOWNLOAD_SIZE_MB;
        public object _lastStringRequest;
        public object _result;
        public object _resultBytes;
        public object _error;
        public object _errorCode;
        public object _url;
        public object _udonBehaviour;
        public object _webRequest;
        public object _DownloadHandler;
        public object _asyncOperation;
        public object _cancellationTokenSource;

        // ── Methods ──
        public void get_Result(){} // RVA: 0xA6B3800
        public void get_ResultBytes(){} // RVA: 0xB465B0
        public void set_ResultBytes(){} // RVA: 0xBA9BA0
        public void get_Error(){} // RVA: 0xB700F0
        public void set_Error(){} // RVA: 0xB70100
        public void get_ErrorCode(){} // RVA: 0x1065D50
        public void set_ErrorCode(){} // RVA: 0x13233D0
        public void get_Url(){} // RVA: 0xD33E60
        public void set_Url(){} // RVA: 0xB708C0
        public void get_UdonBehaviour(){} // RVA: 0xD05CA0
        public void set_UdonBehaviour(){} // RVA: 0xD09D70
        public void .ctor(){} // RVA: 0xA6B38B0
        public void StartDownload(){} // RVA: 0xA6B3A20
        public void StartAtCorrectTime(){} // RVA: 0xA6B4210
        public void CompletedRequest(){} // RVA: 0xA6B43C0
        public void CancelDownload(){} // RVA: 0xA6B4870
        public void .cctor(){} // RVA: 0xA6B4AD0
        public void <StartAtCorrectTime>b__32_1(){} // RVA: 0xA6B4B10
    }

    public class VRCStringDownloader : Object
    {
        public object _stringDownloads;
        public object _startDownload;

        // ── Methods ──
        public void get_StartDownload(){} // RVA: 0xA6B52C0
        public void set_StartDownload(){} // RVA: 0xA6B5320
        public void LoadUrl(){} // RVA: 0xA6B53E0
        public void LoadUrlInternal(){} // RVA: 0xA6B54A0
        public void AddToManager(){} // RVA: 0xA6B5640
        public void RemoveFromManager(){} // RVA: 0xA6B5750
        public void ClearQueue(){} // RVA: 0xA6B57E0
        public void .cctor(){} // RVA: 0xA6B5A50
    }

}