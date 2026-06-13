// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
// Classes: 2
// Methods: 25

namespace ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
{
    public class TextureFrame
    {
        public string _TAG;

        // ── Methods ──
        public void get_imageFormat(){} // RVA: 0x5B53060
        public void .ctor(){} // RVA: 0x5B533F0 | overloaded x2
        public void Dispose(){} // RVA: 0x5B534D0
        public void GetOrCreateRenderTexture(){} // RVA: 0x5B537A0
        public void ReadTextureAsync(){} // RVA: 0x5B53B90
        public void OnReadBackRenderTexture(){} // RVA: 0x5B53DA0
        public void GetNativeTexturePtr(){} // RVA: 0x5B54010
        public void GetTextureName(){} // RVA: 0x5B543B0
        public void GetInstanceID(){} // RVA: 0x111F520
        public void BuildCPUImage(){} // RVA: 0x5B543C0
        public void RemoveAllReleaseListeners(){} // RVA: 0x5B54440
        public void Release(){} // RVA: 0x5B54460
        public void WaitUntilReleased(){} // RVA: 0x196DD20
        public void AcquireName(){} // RVA: 0x5B54520
        public void RevokeNativeTexturePtr(){} // RVA: 0x5B54710
        public void .cctor(){} // RVA: 0x5B547E0
    }

    public class TextureFramePool
    {
        public string _TAG;
        public int textureWidth; // 0x10

        // ── Methods ──
        public void get_poolSize(){} // RVA: 0x197C3B0
        public void set_poolSize(){} // RVA: 0x1989FD0
        public void get_frameCount(){} // RVA: 0x5B54A00
        public void .ctor(){} // RVA: 0x5B54A70
        public void Dispose(){} // RVA: 0x5B54D50
        public void TryGetTextureFrame(){} // RVA: 0x5B55290
        public void OnTextureFrameRelease(){} // RVA: 0x5B55940
        public void CreateNewTextureFrame(){} // RVA: 0x5B55AA0
    }

}