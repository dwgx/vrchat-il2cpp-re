// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
// Classes: 2
// Methods: 25

namespace ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
{
    public class TextureFrame : Object
    {
        public object imageFormat;

        // ── Methods ──
        public void get_imageFormat(){} // RVA: 0x7FFD5370A590
        public void .ctor(){} // RVA: 0x7FFD5370A920 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFD5370AA00
        public void GetOrCreateRenderTexture(){} // RVA: 0x7FFD5370ACD0
        public void ReadTextureAsync(){} // RVA: 0x7FFD5370B0C0
        public void OnReadBackRenderTexture(){} // RVA: 0x7FFD5370B2D0
        public void GetNativeTexturePtr(){} // RVA: 0x7FFD5370B540
        public void GetTextureName(){} // RVA: 0x7FFD5370B8E0
        public void GetInstanceID(){} // RVA: 0x7FFD4EFEF020
        public void BuildCPUImage(){} // RVA: 0x7FFD5370B8F0
        public void RemoveAllReleaseListeners(){} // RVA: 0x7FFD5370B970
        public void Release(){} // RVA: 0x7FFD5370B990
        public void WaitUntilReleased(){} // RVA: 0x7FFD4F848010
        public void AcquireName(){} // RVA: 0x7FFD5370BA50
        public void RevokeNativeTexturePtr(){} // RVA: 0x7FFD5370BC40
        public void .cctor(){} // RVA: 0x7FFD5370BD10
    }

    public class TextureFramePool : Object
    {
        public object poolSize;
        public object frameCount;

        // ── Methods ──
        public void get_poolSize(){} // RVA: 0x7FFD4F8557F0
        public void set_poolSize(){} // RVA: 0x7FFD4F8674D0
        public void get_frameCount(){} // RVA: 0x7FFD5370BF30
        public void .ctor(){} // RVA: 0x7FFD5370BFA0
        public void Dispose(){} // RVA: 0x7FFD5370C280
        public void TryGetTextureFrame(){} // RVA: 0x7FFD5370C7C0
        public void OnTextureFrameRelease(){} // RVA: 0x7FFD5370CE70
        public void CreateNewTextureFrame(){} // RVA: 0x7FFD5370CFD0
    }

}