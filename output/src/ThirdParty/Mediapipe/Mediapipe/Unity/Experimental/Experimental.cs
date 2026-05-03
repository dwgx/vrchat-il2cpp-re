// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
// Classes: 2
// Methods: 25

namespace ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
{
    public class TextureFrame : Object
    {
        public string _TAG;

        // ── Methods ──
        public void get_imageFormat(){} // RVA: 0x7FFE86693E90
        public void .ctor(){} // RVA: 0x7FFE86694220 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE86694300
        public void GetOrCreateRenderTexture(){} // RVA: 0x7FFE866945D0
        public void ReadTextureAsync(){} // RVA: 0x7FFE866949C0
        public void OnReadBackRenderTexture(){} // RVA: 0x7FFE86694BD0
        public void GetNativeTexturePtr(){} // RVA: 0x7FFE86694E40
        public void GetTextureName(){} // RVA: 0x7FFE866951E0
        public void GetInstanceID(){} // RVA: 0x7FFE81E90600
        public void BuildCPUImage(){} // RVA: 0x7FFE866951F0
        public void RemoveAllReleaseListeners(){} // RVA: 0x7FFE86695270
        public void Release(){} // RVA: 0x7FFE86695290
        public void WaitUntilReleased(){} // RVA: 0x7FFE826F8E00
        public void AcquireName(){} // RVA: 0x7FFE86695350
        public void RevokeNativeTexturePtr(){} // RVA: 0x7FFE86695540
        public void .cctor(){} // RVA: 0x7FFE86695610
    }

    public class TextureFramePool : Object
    {
        public string _TAG;
        public int textureWidth; // 0x10

        // ── Methods ──
        public void get_poolSize(){} // RVA: 0x7FFE82707EE0
        public void set_poolSize(){} // RVA: 0x7FFE82717690
        public void get_frameCount(){} // RVA: 0x7FFE86695830
        public void .ctor(){} // RVA: 0x7FFE866958A0
        public void Dispose(){} // RVA: 0x7FFE86695B80
        public void TryGetTextureFrame(){} // RVA: 0x7FFE866960C0
        public void OnTextureFrameRelease(){} // RVA: 0x7FFE86696770
        public void CreateNewTextureFrame(){} // RVA: 0x7FFE866968D0
    }

}