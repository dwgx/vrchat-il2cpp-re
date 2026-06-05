// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Klak.Klak.Spout
// Classes: 13
// Methods: 66

namespace ThirdParty.Klak.Klak.Spout
{
    public class Blitter
    {
        // ── Methods ──
        public void Blit(){} // RVA: 0x7FFAF8543790 | overloaded x2
        public void BlitVFlip(){} // RVA: 0x7FFAF85436F0
        public void BlitFromSrgb(){} // RVA: 0x7FFAF8543840
        public void GetMaterial(){} // RVA: 0x7FFAF85438D0
    }

    public class EventData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8541B90 | overloaded x2
    }

    public class EventKicker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8541BA0
        public void Dispose(){} // RVA: 0x7FFAF8541C10
        public void IssuePluginEvent(){} // RVA: 0x7FFAF8541D10
    }

    public class MemoryPool
    {
        // ── Methods ──
        public void FreeOnEndOfFrame(){} // RVA: 0x7FFAF8541FB0
        public void OnEndOfFrame(){} // RVA: 0x7FFAF8542070
        public void .cctor(){} // RVA: 0x7FFAF8542200
        public void InsertPlayerLoopSystem(){} // RVA: 0x7FFAF85423A0
    }

    public class Plugin
    {
        // ── Methods ──
        public void GetRenderEventCallback(){} // RVA: 0x7FFAF8542820
        public void CreateSender(){} // RVA: 0x7FFAF8542890
        public void CreateReceiver(){} // RVA: 0x7FFAF8542950
        public void GetReceiverData(){} // RVA: 0x7FFAF8542A00
        public void GetSenderNames(){} // RVA: 0x7FFAF8542AA0
    }

    public class Receiver
    {
        // ── Methods ──
        public void get_Texture(){} // RVA: 0x7FFAF2DBB0C0
        public void .ctor(){} // RVA: 0x7FFAF8542C00
        public void Dispose(){} // RVA: 0x7FFAF8542DD0
        public void Update(){} // RVA: 0x7FFAF8542E70
    }

    public class RendererOverride
    {
        // ── Methods ──
        public void SetTexture(){} // RVA: 0x7FFAF8543440
    }

    public class Sender
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8543160
        public void Dispose(){} // RVA: 0x7FFAF85433D0
        public void Update(){} // RVA: 0x7FFAF8543420
    }

    public class SpoutManager
    {
        // ── Methods ──
        public void GetSourceNames(){} // RVA: 0x7FFAF8543C40
    }

    public class SpoutReceiver
    {
        // ── Methods ──
        public void ReleaseReceiver(){} // RVA: 0x7FFAF8543EE0
        public void PrepareBuffer(){} // RVA: 0x7FFAF8544020
        public void OnDisable(){} // RVA: 0x7FFAF85445C0
        public void OnDestroy(){} // RVA: 0x7FFAF85445D0
        public void Update(){} // RVA: 0x7FFAF8544640
        public void get_sourceName(){} // RVA: 0x7FFAF30E74D0
        public void set_sourceName(){} // RVA: 0x7FFAF8544AD0
        public void ChangeSourceName(){} // RVA: 0x7FFAF8544AD0
        public void get_targetTexture(){} // RVA: 0x7FFAF2F476A0
        public void set_targetTexture(){} // RVA: 0x7FFAF2F4B830
        public void get_targetRenderer(){} // RVA: 0x7FFAF2E0A740
        public void set_targetRenderer(){} // RVA: 0x7FFAF2DB5200
        public void get_targetMaterialProperty(){} // RVA: 0x7FFAF2E08730
        public void set_targetMaterialProperty(){} // RVA: 0x7FFAF2E08740
        public void get_receivedTexture(){} // RVA: 0x7FFAF8544B80
        public void SetResources(){} // RVA: 0x7FFAF2EE54D0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SpoutResources
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class SpoutSender
    {
        // ── Methods ──
        public void ReleaseSender(){} // RVA: 0x7FFAF8544C60
        public void PrepareBuffer(){} // RVA: 0x7FFAF8544D20
        public void OnCameraCapture(){} // RVA: 0x7FFAF8544FD0
        public void PrepareCameraCapture(){} // RVA: 0x7FFAF8545180
        public void OnDisable(){} // RVA: 0x7FFAF8545530
        public void Update(){} // RVA: 0x7FFAF8545570
        public void get_spoutName(){} // RVA: 0x7FFAF2F476A0
        public void set_spoutName(){} // RVA: 0x7FFAF8545B20
        public void ChangeSpoutName(){} // RVA: 0x7FFAF8545B20
        public void get_keepAlpha(){} // RVA: 0x7FFAF2E48C00
        public void set_keepAlpha(){} // RVA: 0x7FFAF2E48C10
        public void get_captureMethod(){} // RVA: 0x7FFAF2E2E0A0
        public void set_captureMethod(){} // RVA: 0x7FFAF2E2E0B0
        public void get_sourceCamera(){} // RVA: 0x7FFAF2E08730
        public void set_sourceCamera(){} // RVA: 0x7FFAF2E08740
        public void get_sourceTexture(){} // RVA: 0x7FFAF2E2E0E0
        public void set_sourceTexture(){} // RVA: 0x7FFAF2EE54D0
        public void SetResources(){} // RVA: 0x7FFAF2E55510
        public void .ctor(){} // RVA: 0x7FFAF8545BD0
    }

    public class Utility
    {
        // ── Methods ──
        public void Destroy(){} // RVA: 0x7FFAF8543AD0
    }

}