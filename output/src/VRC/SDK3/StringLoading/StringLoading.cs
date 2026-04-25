// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.StringLoading
// Classes: 4
// Methods: 39

namespace VRC.SDK3.StringLoading
{
    public class IVRCStringDownload
    {
        public object Result;
        public object ResultBytes;
        public object Error;
        public object ErrorCode;
        public object Url;
        public object UdonBehaviour;

        // ── Methods ──
        public void get_Result(){} // RVA: 0x7FFAC2C58E90
        public void get_ResultBytes(){} // RVA: 0x7FFAC2C58E90
        public void get_Error(){} // RVA: 0x7FFAC2C58E90
        public void get_ErrorCode(){} // RVA: 0x7FFAC2C59960
        public void get_Url(){} // RVA: 0x7FFAC2C58E90
        public void get_UdonBehaviour(){} // RVA: 0x7FFAC2C58E90
        public void StartDownload(){} // RVA: 0x7FFAC2C70980
        public void CancelDownload(){} // RVA: 0x7FFAC2C70980
    }

    public class MaxBufferDownloadHandler : DownloadHandlerScript
    {
        public int downloadedBytes; // 0x18
        public int _current; // 0x1C
        public System.Collections.Generic.List`1<byte> _buffer; // 0x20
        public bool lengthFail; // 0x28

        // ── Methods ──
        public void get_downloadedBytes(){} // RVA: 0x7FFACBFFFFB0
        public void .ctor(){} // RVA: 0x7FFACC000110 | overloaded x2
        public void ReceiveContentLengthHeader(){} // RVA: 0x7FFACC000280
        public void ReceiveData(){} // RVA: 0x7FFACC0002F0
    }

    public class VRCStringDownload : Object
    {
        public float Result;
        public int ResultBytes;
        public float Error;
        public string ErrorCode; // 0x10
        public byte[] Url; // 0x18
        public string UdonBehaviour; // 0x20
        public int <ErrorCode>k__BackingField; // 0x28
        public VRC.SDKBase.VRCUrl <Url>k__BackingField; // 0x30
        public VRC.Udon.Common.Interfaces.IUdonEventReceiver <UdonBehaviour>k__BackingField; // 0x38
        public UnityEngine.Networking.UnityWebRequest _webRequest; // 0x40
        public VRC.SDK3.StringLoading.MaxBufferDownloadHandler _DownloadHandler; // 0x48
        public UnityEngine.Networking.UnityWebRequestAsyncOperation _asyncOperation; // 0x50
        public System.Threading.CancellationTokenSource _cancellationTokenSource; // 0x58

        // ── Methods ──
        public void get_Result(){} // RVA: 0x7FFACC000400
        public void get_ResultBytes(){} // RVA: 0x7FFAC2F247C0
        public void set_ResultBytes(){} // RVA: 0x7FFAC2F87E80
        public void get_Error(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Error(){} // RVA: 0x7FFAC2F4F0D0
        public void get_ErrorCode(){} // RVA: 0x7FFAC32EC4C0
        public void set_ErrorCode(){} // RVA: 0x7FFAC369A6E0
        public void get_Url(){} // RVA: 0x7FFAC31D95E0
        public void set_Url(){} // RVA: 0x7FFAC2F4F890
        public void get_UdonBehaviour(){} // RVA: 0x7FFAC31D0140
        public void set_UdonBehaviour(){} // RVA: 0x7FFAC31D0C20
        public void .ctor(){} // RVA: 0x7FFACC0004B0
        public void StartDownload(){} // RVA: 0x7FFACC000620
        public void StartAtCorrectTime(){} // RVA: 0x7FFACC000CC0
        public void CompletedRequest(){} // RVA: 0x7FFACC000E70
        public void CancelDownload(){} // RVA: 0x7FFACC0012D0
        public void .cctor(){} // RVA: 0x7FFACC001520
        public void <StartAtCorrectTime>b__32_1(){} // RVA: 0x7FFACC001560
    }

    public class VRCStringDownloader : Object
    {
        public System.Collections.Generic.List`1<VRC.SDK3.StringLoading.IVRCStringDownload> StartDownload;
        public System.Action`2<VRC.SDKBase.VRCUrl,VRC.Udon.Common.Interfaces.IUdonEventReceiver> <StartDownload>k__BackingField; // 0x8

        // ── Methods ──
        public void get_StartDownload(){} // RVA: 0x7FFACC001D10
        public void set_StartDownload(){} // RVA: 0x7FFACC001D70
        public void LoadUrl(){} // RVA: 0x7FFACC001E30
        public void LoadUrlInternal(){} // RVA: 0x7FFACC001EF0
        public void AddToManager(){} // RVA: 0x7FFACC002090
        public void RemoveFromManager(){} // RVA: 0x7FFACC0021A0
        public void ClearQueue(){} // RVA: 0x7FFACC002230
        public void .cctor(){} // RVA: 0x7FFACC002470
    }

}