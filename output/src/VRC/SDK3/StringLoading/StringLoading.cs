// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.StringLoading
// Classes: 5
// Methods: 53

namespace VRC.SDK3.StringLoading
{
    public class IVRCStringDownload
    {
        // ── Methods ──
        public void get_Result(){} // RVA: 0x7A7E00680
        public void get_ResultBytes(){} // RVA: 0x7A7E00680
        public void get_Error(){} // RVA: 0x7A7E00680
        public void get_ErrorCode(){} // RVA: 0x7A7E00710
        public void get_Url(){} // RVA: 0x7A7E00680
        public void get_UdonBehaviour(){} // RVA: 0x7A7E00680
        public void StartDownload(){} // RVA: 0x7A7E18770
        public void CancelDownload(){} // RVA: 0x7A7E18770
    }

    public class IVRCStringDownload[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class MaxBufferDownloadHandler : DownloadHandlerScript
    {
        // ── Methods ──
        public void get_downloadedBytes(){} // RVA: 0x7B1848920
        public void .ctor(){} // RVA: 0x7B1848A80
        public void ReceiveContentLengthHeader(){} // RVA: 0x7B1848BF0
        public void ReceiveData(){} // RVA: 0x7B1848C60
    }

    public class VRCStringDownload : Object
    {
        // ── Methods ──
        public void get_Result(){} // RVA: 0x7B1848D80
        public void get_ResultBytes(){} // RVA: 0x7A80DA7B0
        public void set_ResultBytes(){} // RVA: 0x7A813E420
        public void get_Error(){} // RVA: 0x7A81052C0
        public void set_Error(){} // RVA: 0x7A81052D0
        public void get_ErrorCode(){} // RVA: 0x7A854FDE0
        public void set_ErrorCode(){} // RVA: 0x7A8810F60
        public void get_Url(){} // RVA: 0x7A83F69F0
        public void set_Url(){} // RVA: 0x7A8105A90
        public void get_UdonBehaviour(){} // RVA: 0x7A8292C30
        public void set_UdonBehaviour(){} // RVA: 0x7A8296DE0
        public void .ctor(){} // RVA: 0x7B1848E30
        public void StartDownload(){} // RVA: 0x7B1848FA0
        public void StartAtCorrectTime(){} // RVA: 0x7B18497C0
        public void CompletedRequest(){} // RVA: 0x7B1849970
        public void CancelDownload(){} // RVA: 0x7B1849DD0
        public void .cctor(){} // RVA: 0x7B184A020
        public void <StartAtCorrectTime>b__32_1(){} // RVA: 0x7B184A060
    }

    public class VRCStringDownloader : Object
    {
        // ── Methods ──
        public void get_StartDownload(){} // RVA: 0x7B184A810
        public void set_StartDownload(){} // RVA: 0x7B184A870
        public void LoadUrl(){} // RVA: 0x7B184A930
        public void LoadUrlInternal(){} // RVA: 0x7B184A9F0
        public void AddToManager(){} // RVA: 0x7B184AB90
        public void RemoveFromManager(){} // RVA: 0x7B184ACA0
        public void ClearQueue(){} // RVA: 0x7B184AD30
        public void .cctor(){} // RVA: 0x7B184AFA0
    }

}