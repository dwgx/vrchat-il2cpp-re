// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Klak.Klak.Spout
// Classes: 13
// Methods: 66

namespace ThirdParty.Klak.Klak.Spout
{
    public class Blitter
    {
        // ── Methods ──
        public void Blit(){} // RVA: 0x5A93790 | overloaded x2
        public void BlitVFlip(){} // RVA: 0x5A936F0
        public void BlitFromSrgb(){} // RVA: 0x5A93840
        public void GetMaterial(){} // RVA: 0x5A938D0
    }

    public class EventData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A91B90 | overloaded x2
    }

    public class EventKicker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A91BA0
        public void Dispose(){} // RVA: 0x5A91C10
        public void IssuePluginEvent(){} // RVA: 0x5A91D10
    }

    public class MemoryPool
    {
        // ── Methods ──
        public void FreeOnEndOfFrame(){} // RVA: 0x5A91FB0
        public void OnEndOfFrame(){} // RVA: 0x5A92070
        public void .cctor(){} // RVA: 0x5A92200
        public void InsertPlayerLoopSystem(){} // RVA: 0x5A923A0
    }

    public class Plugin
    {
        // ── Methods ──
        public void GetRenderEventCallback(){} // RVA: 0x5A92820
        public void CreateSender(){} // RVA: 0x5A92890
        public void CreateReceiver(){} // RVA: 0x5A92950
        public void GetReceiverData(){} // RVA: 0x5A92A00
        public void GetSenderNames(){} // RVA: 0x5A92AA0
    }

    public class Receiver
    {
        public UIntPtr _plugin; // 0x10

        // ── Methods ──
        public void get_Texture(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x5A92C00
        public void Dispose(){} // RVA: 0x5A92DD0
        public void Update(){} // RVA: 0x5A92E70
    }

    public class RendererOverride
    {
        // ── Methods ──
        public void SetTexture(){} // RVA: 0x5A93440
    }

    public class Sender
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A93160
        public void Dispose(){} // RVA: 0x5A933D0
        public void Update(){} // RVA: 0x5A93420
    }

    public class SpoutManager
    {
        // ── Methods ──
        public void GetSourceNames(){} // RVA: 0x5A93C40
    }

    public class SpoutReceiver
    {
        public Klak.Spout.Receiver _receiver; // 0x20
        public UnityEngine.RenderTexture _buffer; // 0x28
        public string _sourceName; // 0x30
        public UnityEngine.RenderTexture _targetTexture; // 0x38
        public UnityEngine.Renderer _targetRenderer; // 0x40

        // ── Methods ──
        public void ReleaseReceiver(){} // RVA: 0x5A93EE0
        public void PrepareBuffer(){} // RVA: 0x5A94020
        public void OnDisable(){} // RVA: 0x5A945C0
        public void OnDestroy(){} // RVA: 0x5A945D0
        public void Update(){} // RVA: 0x5A94640
        public void get_sourceName(){} // RVA: 0x6374D0
        public void set_sourceName(){} // RVA: 0x5A94AD0
        public void ChangeSourceName(){} // RVA: 0x5A94AD0
        public void get_targetTexture(){} // RVA: 0x4976A0
        public void set_targetTexture(){} // RVA: 0x49B830
        public void get_targetRenderer(){} // RVA: 0x35A740
        public void set_targetRenderer(){} // RVA: 0x305200
        public void get_targetMaterialProperty(){} // RVA: 0x358730
        public void set_targetMaterialProperty(){} // RVA: 0x358740
        public void get_receivedTexture(){} // RVA: 0x5A94B80
        public void SetResources(){} // RVA: 0x4354D0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SpoutResources
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class SpoutSender
    {
        public Klak.Spout.Sender _sender; // 0x20
        public UnityEngine.RenderTexture _buffer; // 0x28
        public UnityEngine.Camera _attachedCamera; // 0x30
        public string _spoutName; // 0x38
        public bool _keepAlpha; // 0x40

        // ── Methods ──
        public void ReleaseSender(){} // RVA: 0x5A94C60
        public void PrepareBuffer(){} // RVA: 0x5A94D20
        public void OnCameraCapture(){} // RVA: 0x5A94FD0
        public void PrepareCameraCapture(){} // RVA: 0x5A95180
        public void OnDisable(){} // RVA: 0x5A95530
        public void Update(){} // RVA: 0x5A95570
        public void get_spoutName(){} // RVA: 0x4976A0
        public void set_spoutName(){} // RVA: 0x5A95B20
        public void ChangeSpoutName(){} // RVA: 0x5A95B20
        public void get_keepAlpha(){} // RVA: 0x398C00
        public void set_keepAlpha(){} // RVA: 0x398C10
        public void get_captureMethod(){} // RVA: 0x37E0A0
        public void set_captureMethod(){} // RVA: 0x37E0B0
        public void get_sourceCamera(){} // RVA: 0x358730
        public void set_sourceCamera(){} // RVA: 0x358740
        public void get_sourceTexture(){} // RVA: 0x37E0E0
        public void set_sourceTexture(){} // RVA: 0x4354D0
        public void SetResources(){} // RVA: 0x3A5510
        public void .ctor(){} // RVA: 0x5A95BD0
    }

    public class Utility
    {
        // ── Methods ──
        public void Destroy(){} // RVA: 0x5A93AD0
    }

}