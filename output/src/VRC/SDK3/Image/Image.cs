// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Image
// Classes: 2
// Methods: 24

namespace VRC.SDK3.Image
{
    public class IVRCImageDownload
    {
        public object State;
        public object Error;
        public object ErrorMessage;
        public object Result;
        public object SizeInMemoryBytes;
        public object Progress;
        public object Url;
        public object Material;
        public object UdonBehaviour;
        public object TextureInfo;

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFD4E079960
        public void get_Error(){} // RVA: 0x7FFD4E079960
        public void get_ErrorMessage(){} // RVA: 0x7FFD4E078E90
        public void get_Result(){} // RVA: 0x7FFD4E078E90
        public void get_SizeInMemoryBytes(){} // RVA: 0x7FFD4E079960
        public void get_Progress(){} // RVA: 0x7FFD4E08D880
        public void get_Url(){} // RVA: 0x7FFD4E078E90
        public void get_Material(){} // RVA: 0x7FFD4E078E90
        public void get_UdonBehaviour(){} // RVA: 0x7FFD4E078E90
        public void get_TextureInfo(){} // RVA: 0x7FFD4E078E90
        public void StartDownload(){} // RVA: 0x7FFD4E090980
        public void CancelDownload(){} // RVA: 0x7FFD4E090980
    }

    public class VRCImageDownloader : Object
    {
        public bool StartDownload; // 0x10
        public System.Collections.Generic.List`1<VRC.SDK3.Image.IVRCImageDownload> HasAnyQueuedDownloads; // 0x18
        public System.Collections.Generic.List`1<VRC.SDK3.Image.IVRCImageDownload> _imageDownloadQueue;
        public System.Func`5<VRC.SDKBase.VRCUrl,UnityEngine.Material,VRC.Udon.Common.Interfaces.IUdonEventReceiver,0x665C2418,VRC.SDK3.Image.IVRCImageDownload> <StartDownload>k__BackingField; // 0x8
        public System.Func`1<bool> CanBypassDelay; // 0x10

        // ── Methods ──
        public void get_StartDownload(){} // RVA: 0x7FFD57422820
        public void set_StartDownload(){} // RVA: 0x7FFD57422880
        public void DownloadImage(){} // RVA: 0x7FFD57422940
        public void Dispose(){} // RVA: 0x7FFD57422AE0
        public void Finalize(){} // RVA: 0x7FFD57422B40
        public void DisposeInternal(){} // RVA: 0x7FFD57422B90
        public void AddImageDownloadToQueue(){} // RVA: 0x7FFD57422E70
        public void RemoveImageDownloadFromQueue(){} // RVA: 0x7FFD57422F40
        public void ClearQueue(){} // RVA: 0x7FFD57422FD0
        public void get_HasAnyQueuedDownloads(){} // RVA: 0x7FFD57423300
        public void .ctor(){} // RVA: 0x7FFD57423380
        public void .cctor(){} // RVA: 0x7FFD57423440
    }

}