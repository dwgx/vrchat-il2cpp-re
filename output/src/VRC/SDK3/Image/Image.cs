// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Image
// Classes: 5
// Methods: 48

namespace VRC.SDK3.Image
{
    public class IVRCImageDownload
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x7A7E00710
        public void get_Error(){} // RVA: 0x7A7E00710
        public void get_ErrorMessage(){} // RVA: 0x7A7E00680
        public void get_Result(){} // RVA: 0x7A7E00680
        public void get_SizeInMemoryBytes(){} // RVA: 0x7A7E00710
        public void get_Progress(){} // RVA: 0x7A7E155B0
        public void get_Url(){} // RVA: 0x7A7E00680
        public void get_Material(){} // RVA: 0x7A7E00680
        public void get_UdonBehaviour(){} // RVA: 0x7A7E00680
        public void get_TextureInfo(){} // RVA: 0x7A7E00680
        public void StartDownload(){} // RVA: 0x7A7E18770
        public void CancelDownload(){} // RVA: 0x7A7E18770
    }

    public class IVRCImageDownload[] : Array
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

    public class ImageDownloader : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7B18A0360
        public void TrimCache(){} // RVA: 0x7B18A0440
        public void DownloadImage(){} // RVA: 0x7B18A0470
        public void TrimCacheInternal(){} // RVA: 0x7B18A04F0
        public void DownloadImageInternal(){} // RVA: 0x7B18A0760
        public void CacheTexture(){} // RVA: 0x7B18A0E70
        public void DownloadFallbackOrUseErrorImage(){} // RVA: 0x7B18A1070
        public void .ctor(){} // RVA: 0x7B18A11B0
    }

    public class TextureInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B184B2A0
    }

    public class VRCImageDownloader : Object
    {
        // ── Methods ──
        public void get_StartDownload(){} // RVA: 0x7B184B340
        public void set_StartDownload(){} // RVA: 0x7B184B3A0
        public void DownloadImage(){} // RVA: 0x7B184B460
        public void Dispose(){} // RVA: 0x7B184B600
        public void Finalize(){} // RVA: 0x7B184B7E0
        public void DisposeInternal(){} // RVA: 0x7B184B830
        public void AddImageDownloadToQueue(){} // RVA: 0x7B184B9C0
        public void RemoveImageDownloadFromQueue(){} // RVA: 0x7B184BA90
        public void ClearQueue(){} // RVA: 0x7B184BB20
        public void get_HasAnyQueuedDownloads(){} // RVA: 0x7B184BE50
        public void .ctor(){} // RVA: 0x7B184BED0
        public void .cctor(){} // RVA: 0x7B184BF90
    }

}