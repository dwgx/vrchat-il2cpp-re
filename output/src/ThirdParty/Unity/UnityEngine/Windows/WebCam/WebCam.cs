// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Windows.WebCam
// Classes: 3
// Methods: 34

namespace ThirdParty.Unity.UnityEngine.Windows.WebCam
{
    public class PhotoCapture : Object
    {
        // ── Methods ──
        public void MakeCaptureResult(){} // RVA: 0x7FFE87C852F0
        public void InvokeOnCreatedResourceDelegate(){} // RVA: 0x7FFE87C85360
        public void .ctor(){} // RVA: 0x7FFE826F2ED0
        public void InvokeOnPhotoModeStartedDelegate(){} // RVA: 0x7FFE87C853F0
        public void InvokeOnPhotoModeStoppedDelegate(){} // RVA: 0x7FFE87C853F0
        public void InvokeOnCapturedPhotoToDiskDelegate(){} // RVA: 0x7FFE87C853F0
        public void InvokeOnCapturedPhotoToMemoryDelegate(){} // RVA: 0x7FFE87C85490
        public void Dispose(){} // RVA: 0x7FFE87C855A0
        public void Dispose_Internal(){} // RVA: 0x7FFE87C85640
        public void Finalize(){} // RVA: 0x7FFE87C85690
        public void DisposeThreaded_Internal(){} // RVA: 0x7FFE87C85720
    }

    public class PhotoCaptureFrame : Object
    {
        public UIntPtr m_NativePtr; // 0x10
        public int _dataLength; // 0x18
        public bool _hasLocationData; // 0x1C

        // ── Methods ──
        public void get_dataLength(){} // RVA: 0x7FFE813DB630
        public void set_dataLength(){} // RVA: 0x7FFE8144DF00
        public void set_hasLocationData(){} // RVA: 0x7FFE811163A0
        public void set_pixelFormat(){} // RVA: 0x7FFE8170B670
        public void GetDataLength(){} // RVA: 0x7FFE87C85770
        public void GetHasLocationData(){} // RVA: 0x7FFE87C857C0
        public void GetCapturePixelFormat(){} // RVA: 0x7FFE87C85810
        public void .ctor(){} // RVA: 0x7FFE87C85860
        public void Cleanup(){} // RVA: 0x7FFE87C85A30
        public void Dispose_Internal(){} // RVA: 0x7FFE87C85B80
        public void Dispose(){} // RVA: 0x7FFE87C85BD0
        public void Finalize(){} // RVA: 0x7FFE87C85C30
    }

    public class VideoCapture : Object
    {
        // ── Methods ──
        public void MakeCaptureResult(){} // RVA: 0x7FFE87C85C70
        public void InvokeOnCreatedVideoCaptureResourceDelegate(){} // RVA: 0x7FFE87C85CE0
        public void .ctor(){} // RVA: 0x7FFE826F2ED0
        public void InvokeOnVideoModeStartedDelegate(){} // RVA: 0x7FFE87C85D70
        public void InvokeOnVideoModeStoppedDelegate(){} // RVA: 0x7FFE87C85D70
        public void InvokeOnStartedRecordingVideoToDiskDelegate(){} // RVA: 0x7FFE87C85D70
        public void InvokeOnStoppedRecordingVideoToDiskDelegate(){} // RVA: 0x7FFE87C85D70
        public void Dispose(){} // RVA: 0x7FFE87C85E10
        public void Dispose_Internal(){} // RVA: 0x7FFE87C85EB0
        public void Finalize(){} // RVA: 0x7FFE87C85F00
        public void DisposeThreaded_Internal(){} // RVA: 0x7FFE87C85F90
    }

}