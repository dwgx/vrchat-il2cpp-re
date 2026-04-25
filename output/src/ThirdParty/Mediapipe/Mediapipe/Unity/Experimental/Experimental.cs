// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
// Classes: 2
// Methods: 25

namespace ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
{
    public class TextureFrame : Object
    {
        public string imageFormat;
        public int MaxTotalCount;
        public Mediapipe.GlobalInstanceTable`2<System.Guid,Mediapipe.Unity.Experimental.TextureFrame> _InstanceTable;
        public System.Collections.Generic.Dictionary`2<uint,System.Guid> _NameTable; // 0x8
        public UnityEngine.Texture2D _texture; // 0x10
        public UIntPtr _nativeTexturePtr; // 0x18
        public Mediapipe.GlSyncPoint _glSyncToken; // 0x20
        public System.Guid _instanceId; // 0x28
        public int width; // 0x38
        public int height; // 0x3C
        public 0x6B17C078 format; // 0x40
        public ReleaseEvent OnRelease; // 0x48
        public UnityEngine.RenderTexture _tmpRenderTexture; // 0x50
        public UnityEngine.RenderTexture _internalRenderTexture; // 0x58
        public System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest> _onReadBackRenderTexture; // 0x60

        // ── Methods ──
        public void get_imageFormat(){} // RVA: 0x7FFAC82EA590
        public void .ctor(){} // RVA: 0x7FFAC82EA920 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC82EAA00
        public void GetOrCreateRenderTexture(){} // RVA: 0x7FFAC82EACD0
        public void ReadTextureAsync(){} // RVA: 0x7FFAC82EB0C0
        public void OnReadBackRenderTexture(){} // RVA: 0x7FFAC82EB2D0
        public void GetNativeTexturePtr(){} // RVA: 0x7FFAC82EB540
        public void GetTextureName(){} // RVA: 0x7FFAC82EB8E0
        public void GetInstanceID(){} // RVA: 0x7FFAC3BCF020
        public void BuildCPUImage(){} // RVA: 0x7FFAC82EB8F0
        public void RemoveAllReleaseListeners(){} // RVA: 0x7FFAC82EB970
        public void Release(){} // RVA: 0x7FFAC82EB990
        public void WaitUntilReleased(){} // RVA: 0x7FFAC4428010
        public void AcquireName(){} // RVA: 0x7FFAC82EBA50
        public void RevokeNativeTexturePtr(){} // RVA: 0x7FFAC82EBC40
        public void .cctor(){} // RVA: 0x7FFAC82EBD10
    }

    public class TextureFramePool : Object
    {
        public string poolSize;
        public int frameCount; // 0x10
        public int textureHeight; // 0x14
        public 0x6B17C078 textureFormat; // 0x18
        public int <poolSize>k__BackingField; // 0x1C
        public System.Threading.ReaderWriterLockSlim _textureFramesLock; // 0x20
        public System.Collections.Generic.Queue`1<Mediapipe.Unity.Experimental.TextureFrame> _availableTextureFrames; // 0x28
        public System.Collections.Generic.Dictionary`2<System.Guid,Mediapipe.Unity.Experimental.TextureFrame> _textureFramesInUse; // 0x30

        // ── Methods ──
        public void get_poolSize(){} // RVA: 0x7FFAC44357F0
        public void set_poolSize(){} // RVA: 0x7FFAC44474D0
        public void get_frameCount(){} // RVA: 0x7FFAC82EBF30
        public void .ctor(){} // RVA: 0x7FFAC82EBFA0
        public void Dispose(){} // RVA: 0x7FFAC82EC280
        public void TryGetTextureFrame(){} // RVA: 0x7FFAC82EC7C0
        public void OnTextureFrameRelease(){} // RVA: 0x7FFAC82ECE70
        public void CreateNewTextureFrame(){} // RVA: 0x7FFAC82ECFD0
    }

}