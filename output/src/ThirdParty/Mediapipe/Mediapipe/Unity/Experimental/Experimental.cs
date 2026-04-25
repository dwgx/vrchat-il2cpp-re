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
        public 0x664DC078 format; // 0x40
        public 0x66575C58 OnRelease; // 0x48
        public UnityEngine.RenderTexture _tmpRenderTexture; // 0x50
        public UnityEngine.RenderTexture _internalRenderTexture; // 0x58
        public System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest> _onReadBackRenderTexture; // 0x60

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
        public string poolSize;
        public int frameCount; // 0x10
        public int textureHeight; // 0x14
        public 0x664DC078 textureFormat; // 0x18
        public int <poolSize>k__BackingField; // 0x1C
        public 0x66559068 _textureFramesLock; // 0x20
        public System.Collections.Generic.Queue`1<Mediapipe.Unity.Experimental.TextureFrame> _availableTextureFrames; // 0x28
        public System.Collections.Generic.Dictionary`2<System.Guid,Mediapipe.Unity.Experimental.TextureFrame> _textureFramesInUse; // 0x30

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