// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
// Classes: 2
// Methods: 25

namespace ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
{
    public class TextureFrame
    {
        // ── Methods ──
        public void get_imageFormat(){} // RVA: 0x7FFAF8603060
        public void .ctor(){} // RVA: 0x7FFAF86033F0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF86034D0
        public void GetOrCreateRenderTexture(){} // RVA: 0x7FFAF86037A0
        public void ReadTextureAsync(){} // RVA: 0x7FFAF8603B90
        public void OnReadBackRenderTexture(){} // RVA: 0x7FFAF8603DA0
        public void GetNativeTexturePtr(){} // RVA: 0x7FFAF8604010
        public void GetTextureName(){} // RVA: 0x7FFAF86043B0
        public void GetInstanceID(){} // RVA: 0x7FFAF3BCF520
        public void BuildCPUImage(){} // RVA: 0x7FFAF86043C0
        public void RemoveAllReleaseListeners(){} // RVA: 0x7FFAF8604440
        public void Release(){} // RVA: 0x7FFAF8604460
        public void WaitUntilReleased(){} // RVA: 0x7FFAF441DD20
        public void AcquireName(){} // RVA: 0x7FFAF8604520
        public void RevokeNativeTexturePtr(){} // RVA: 0x7FFAF8604710
        public void .cctor(){} // RVA: 0x7FFAF86047E0
    }

    public class TextureFramePool
    {
        // ── Methods ──
        public void get_poolSize(){} // RVA: 0x7FFAF442C3B0
        public void set_poolSize(){} // RVA: 0x7FFAF4439FD0
        public void get_frameCount(){} // RVA: 0x7FFAF8604A00
        public void .ctor(){} // RVA: 0x7FFAF8604A70
        public void Dispose(){} // RVA: 0x7FFAF8604D50
        public void TryGetTextureFrame(){} // RVA: 0x7FFAF8605290
        public void OnTextureFrameRelease(){} // RVA: 0x7FFAF8605940
        public void CreateNewTextureFrame(){} // RVA: 0x7FFAF8605AA0
    }

}