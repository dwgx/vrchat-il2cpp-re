// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
// Classes: 2
// Methods: 25

namespace ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
{
    public class TextureFrame : Object
    {
        public object _InstanceTable; // 0x3330B6F0
        public object _nativeTexturePtr; // 0x3330B6F0
        public object width; // 0x3330B6F0
        public object OnRelease; // 0x3330B6F0
        public object _onReadBackRenderTexture; // 0x3330B6F0
        public object Count; // 0x170008DD
        public object System.Collections.ICollection.IsSynchronized; // 0x170008DE
        public object System.Collections.ICollection.SyncRoot; // 0x170008DF

        // ── Original Methods ──
        public void get_imageFormat(){} // RVA: 0x7ffaadd0b740
        public void .ctor(){} // RVA: 0x7ffaadd0bad0
        public void .ctor(){} // RVA: 0x7ffaadd0bad0
        public void Dispose(){} // RVA: 0x7ffaadd0bbb0
        public void ReadTextureAsync(){} // RVA: 0x7ffaadd0c270
        public void OnReadBackRenderTexture(){} // RVA: 0x7ffaadd0c480
        public void BuildCPUImage(){} // RVA: 0x7ffaadd0caa0
        public void RemoveAllReleaseListeners(){} // RVA: 0x7ffaadd0cb20
        public void Release(){} // RVA: 0x7ffaadd0cb40
        public void WaitUntilReleased(){} // RVA: 0x7ffaa9e4c930
        public void AcquireName(){} // RVA: 0x7ffaadd0cc00
        public void RevokeNativeTexturePtr(){} // RVA: 0x7ffaadd0cdf0
        public void .cctor(){} // RVA: 0x7ffaadd0cec0
        // ── Binary Analysis Named ──
        public void GetOrCreateRenderTexture(){} // RVA: 0x7ffaadd0be80
        public void GetNativeTexturePtr(){} // RVA: 0x7ffaadd0c6f0
        public void GetTextureName(){} // RVA: 0x7ffaadd0ca90
        public void GetInstanceID(){} // RVA: 0x7ffaa95ffd80
    }

    public class TextureFramePool : Object
    {
        public object textureHeight; // 0x33734DA0
        public object _textureFramesLock; // 0x33734DA0

        // ── Original Methods ──
        public void get_poolSize(){} // RVA: 0x7ffaa9e5ac10
        public void set_poolSize(){} // RVA: 0x7ffaa9e6a2e0
        public void get_frameCount(){} // RVA: 0x7ffaadd0d0e0
        public void .ctor(){} // RVA: 0x7ffaadd0d150
        public void Dispose(){} // RVA: 0x7ffaadd0d430
        public void TryGetTextureFrame(){} // RVA: 0x7ffaadd0d970
        public void OnTextureFrameRelease(){} // RVA: 0x7ffaadd0e020
        public void CreateNewTextureFrame(){} // RVA: 0x7ffaadd0e180
    }

}