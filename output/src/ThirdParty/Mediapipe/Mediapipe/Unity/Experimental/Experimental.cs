// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
// Classes: 3
// Methods: 39

namespace ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
{
    public class TextureFrame : Object
    {
        public object _TAG;
        public object MaxTotalCount;
        public object _InstanceTable;
        public object _NameTable;
        public object _texture;
        public object _nativeTexturePtr;
        public object _glSyncToken;
        public object _instanceId;
        public object width;
        public object height;
        public object format;
        public object OnRelease;
        public object _tmpRenderTexture;
        public object _internalRenderTexture;
        public object _onReadBackRenderTexture;

        // ── Methods ──
        public void get_imageFormat(){} // RVA: 0x65CD380
        public void .ctor(){} // RVA: 0x65CD730
        public void Dispose(){} // RVA: 0x65CD810
        public void GetOrCreateRenderTexture(){} // RVA: 0x65CDA90
        public void ReadTextureAsync(){} // RVA: 0x65CDDD0
        public void OnReadBackRenderTexture(){} // RVA: 0x65CDFE0
        public void GetNativeTexturePtr(){} // RVA: 0x65CE210
        public void GetTextureName(){} // RVA: 0x65CE540
        public void GetInstanceID(){} // RVA: 0x19F92B0
        public void BuildCPUImage(){} // RVA: 0x65CE550
        public void RemoveAllReleaseListeners(){} // RVA: 0x65CE5D0
        public void Release(){} // RVA: 0x65CE5F0
        public void WaitUntilReleased(){} // RVA: 0x2238100
        public void AcquireName(){} // RVA: 0x65CE6B0
        public void RevokeNativeTexturePtr(){} // RVA: 0x65CE8A0
        public void .cctor(){} // RVA: 0x65CE970
    }

    public class TextureFramePool : Object
    {
        public object _TAG;
        public object textureWidth;
        public object textureHeight;
        public object textureFormat;
        public object _poolSize;
        public object _textureFramesLock;
        public object _availableTextureFrames;
        public object _textureFramesInUse;

        // ── Methods ──
        public void get_poolSize(){} // RVA: 0x2244FB0
        public void set_poolSize(){} // RVA: 0x22735B0
        public void get_frameCount(){} // RVA: 0x65CEB90
        public void .ctor(){} // RVA: 0x65CEC00
        public void Dispose(){} // RVA: 0x65CEEE0
        public void TryGetTextureFrame(){} // RVA: 0x65CF420
        public void OnTextureFrameRelease(){} // RVA: 0x65CFAF0
        public void CreateNewTextureFrame(){} // RVA: 0x65CFC50
    }

    public class TextureFrame[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}