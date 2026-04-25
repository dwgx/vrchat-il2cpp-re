// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Windows.WebCam
// Classes: 3
// Methods: 34

namespace ThirdParty.Unity.UnityEngine.Windows.WebCam
{
    public class PhotoCapture : Object
    {
        public UIntPtr m_NativePtr; // 0x10
        public long HR_SUCCESS;

        // ── Methods ──
        public void MakeCaptureResult(){} // RVA: 0x7FFAC98DCBC0
        public void InvokeOnCreatedResourceDelegate(){} // RVA: 0x7FFAC98DCC30
        public void .ctor(){} // RVA: 0x7FFAC441EFB0
        public void InvokeOnPhotoModeStartedDelegate(){} // RVA: 0x7FFAC98DCCC0
        public void InvokeOnPhotoModeStoppedDelegate(){} // RVA: 0x7FFAC98DCCC0
        public void InvokeOnCapturedPhotoToDiskDelegate(){} // RVA: 0x7FFAC98DCCC0
        public void InvokeOnCapturedPhotoToMemoryDelegate(){} // RVA: 0x7FFAC98DCD60
        public void Dispose(){} // RVA: 0x7FFAC98DCE70
        public void Dispose_Internal(){} // RVA: 0x7FFAC98DCF10
        public void Finalize(){} // RVA: 0x7FFAC98DCF60
        public void DisposeThreaded_Internal(){} // RVA: 0x7FFAC98DCFF0
    }

    public class PhotoCaptureFrame : Object
    {
        public UIntPtr dataLength; // 0x10
        public int hasLocationData; // 0x18
        public bool pixelFormat; // 0x1C
        public 0x6B181C40 <pixelFormat>k__BackingField; // 0x20

        // ── Methods ──
        public void get_dataLength(){} // RVA: 0x7FFAC3157800
        public void set_dataLength(){} // RVA: 0x7FFAC392CD10
        public void set_hasLocationData(){} // RVA: 0x7FFAC2F3C3A0
        public void set_pixelFormat(){} // RVA: 0x7FFAC35DB7A0
        public void GetDataLength(){} // RVA: 0x7FFAC98DD040
        public void GetHasLocationData(){} // RVA: 0x7FFAC98DD090
        public void GetCapturePixelFormat(){} // RVA: 0x7FFAC98DD0E0
        public void .ctor(){} // RVA: 0x7FFAC98DD130
        public void Cleanup(){} // RVA: 0x7FFAC98DD300
        public void Dispose_Internal(){} // RVA: 0x7FFAC98DD450
        public void Dispose(){} // RVA: 0x7FFAC98DD4A0
        public void Finalize(){} // RVA: 0x7FFAC98DD500
    }

    public class VideoCapture : Object
    {
        public UIntPtr m_NativePtr; // 0x10
        public long HR_SUCCESS;

        // ── Methods ──
        public void MakeCaptureResult(){} // RVA: 0x7FFAC98DD540
        public void InvokeOnCreatedVideoCaptureResourceDelegate(){} // RVA: 0x7FFAC98DD5B0
        public void .ctor(){} // RVA: 0x7FFAC441EFB0
        public void InvokeOnVideoModeStartedDelegate(){} // RVA: 0x7FFAC98DD640
        public void InvokeOnVideoModeStoppedDelegate(){} // RVA: 0x7FFAC98DD640
        public void InvokeOnStartedRecordingVideoToDiskDelegate(){} // RVA: 0x7FFAC98DD640
        public void InvokeOnStoppedRecordingVideoToDiskDelegate(){} // RVA: 0x7FFAC98DD640
        public void Dispose(){} // RVA: 0x7FFAC98DD6E0
        public void Dispose_Internal(){} // RVA: 0x7FFAC98DD780
        public void Finalize(){} // RVA: 0x7FFAC98DD7D0
        public void DisposeThreaded_Internal(){} // RVA: 0x7FFAC98DD860
    }

}