// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Networking
// Classes: 4
// Methods: 37

namespace ThirdParty.Unity.UnityEngine.Networking
{
    public class CertificateHandler : Object
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaf6b4810
        public void Release(){} // RVA: 0x7ffaaf6b4860
        public void .ctor(){} // RVA: 0x7ffaaf6b48b0
        public void Finalize(){} // RVA: 0x7ffaaf6b4910
        public void ValidateCertificate(){} // RVA: 0x7ffaaac0a810
        public void ValidateCertificateNative(){} // RVA: 0x7ffaac13d2a0
        public void Dispose(){} // RVA: 0x7ffaaf6b49a0
    }

    public class DownloadHandler : Object
    {
        // ── Original Methods ──
        public void Release(){} // RVA: 0x7ffaaf6b4a00
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void Finalize(){} // RVA: 0x7ffaaf6b4a50
        public void Dispose(){} // RVA: 0x7ffaaf6b4aa0
        public void get_isDone(){} // RVA: 0x7ffaaf6b4b00
        public void IsDone(){} // RVA: 0x7ffaaf6b4b00
        public void get_error(){} // RVA: 0x7ffaaf6b4b50
        public void get_nativeData(){} // RVA: 0x7ffaaf6b4ba0
        public void get_data(){} // RVA: 0x7ffaaa1d31f0
        public void get_text(){} // RVA: 0x7ffaa8b17b80
        public void ReceiveData(){} // RVA: 0x7ffaaa5f9770
        public void ReceiveContentLengthHeader(){} // RVA: 0x7ffaaf6b5250
        public void ReceiveContentLength(){} // RVA: 0x7ffaa8932310
        public void CompleteContent(){} // RVA: 0x7ffaa8932310
        public void InternalGetByteArray(){} // RVA: 0x7ffaaf6b4c50
        public void InternalGetByteArray(){} // RVA: 0x7ffaaf6b4c50
        public void InternalGetNativeArray(){} // RVA: 0x7ffaaf6b52d0
        public void DisposeNativeArray(){} // RVA: 0x7ffaaf6b5410
        public void CreateNativeArrayForNativeData(){} // RVA: 0x7ffaaf6b5450
        // ── Binary Analysis Named ──
        public void GetErrorMsg(){} // RVA: 0x7ffaaf6b4b50
        public void GetNativeData(){} // RVA: 0x7ffaa8d99520
        public void GetData(){} // RVA: 0x7ffaaf6b4c50
        public void GetText(){} // RVA: 0x7ffaaf6b4ce0
        public void GetTextEncoder(){} // RVA: 0x7ffaaf6b4dc0
        public void GetContentType(){} // RVA: 0x7ffaaf6b5200
        public void GetProgress(){} // RVA: 0x7ffaaf2acd20
        public void GetCheckedDownloader(){} // RVA: 0x7ffaa887e5c0
    }

    public class EncryptionKey : ValueType
    {
        public object C; // 0x32DF33C0
    }

    public class UnityWebRequestAsyncOperation : AsyncOperation
    {
        // ── Original Methods ──
        public void get_webRequest(){} // RVA: 0x7ffaa89600c0
        public void set_webRequest(){} // RVA: 0x7ffaa89600d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

}