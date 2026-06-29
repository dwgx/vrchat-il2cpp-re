// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Klak.Klak.Spout
// Classes: 13
// Methods: 64

namespace ThirdParty.Klak.Klak.Spout
{
    public class Blitter : Object
    {
        // ── Methods ──
        public void Blit(){} // RVA: 0x650D910
        public void BlitVFlip(){} // RVA: 0x650D870
        public void BlitFromSrgb(){} // RVA: 0x650D9C0
        public void GetMaterial(){} // RVA: 0x650DA50
    }

    public class EventData : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8A3D80
    }

    public class EventKicker : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x650BE10
        public void Dispose(){} // RVA: 0x650BE80
        public void IssuePluginEvent(){} // RVA: 0x650BF80
    }

    public class MemoryPool : Object
    {
        // ── Methods ──
        public void FreeOnEndOfFrame(){} // RVA: 0x650C200
        public void OnEndOfFrame(){} // RVA: 0x650C2C0
        public void .cctor(){} // RVA: 0x650C450
        public void InsertPlayerLoopSystem(){} // RVA: 0x650C5F0
    }

    public class Plugin : Object
    {
        // ── Methods ──
        public void GetRenderEventCallback(){} // RVA: 0x650CA10
        public void CreateSender(){} // RVA: 0x650CA80
        public void CreateReceiver(){} // RVA: 0x650CB40
        public void GetReceiverData(){} // RVA: 0x650CBF0
        public void GetSenderNames(){} // RVA: 0x650CC90
    }

    public class Receiver : Object
    {
        // ── Methods ──
        public void get_Texture(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0x650CDF0
        public void Dispose(){} // RVA: 0x650CFC0
        public void Update(){} // RVA: 0x650D060
    }

    public class RendererOverride : Object
    {
        // ── Methods ──
        public void SetTexture(){} // RVA: 0x650D5A0
    }

    public class Sender : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x650D310
        public void Dispose(){} // RVA: 0x650D530
        public void Update(){} // RVA: 0x650D580
    }

    public class SpoutManager : Object
    {
        // ── Methods ──
        public void GetSourceNames(){} // RVA: 0x650DE10
    }

    public class SpoutReceiver : MonoBehaviour
    {
        // ── Methods ──
        public void ReleaseReceiver(){} // RVA: 0x650E0D0
        public void PrepareBuffer(){} // RVA: 0x650E210
        public void OnDisable(){} // RVA: 0x650E850
        public void OnDestroy(){} // RVA: 0x650E860
        public void Update(){} // RVA: 0x650E8D0
        public void get_sourceName(){} // RVA: 0xD33E60
        public void set_sourceName(){} // RVA: 0x650ED60
        public void ChangeSourceName(){} // RVA: 0x650ED60
        public void get_targetTexture(){} // RVA: 0xD05CA0
        public void set_targetTexture(){} // RVA: 0xD09D70
        public void get_targetRenderer(){} // RVA: 0xBC1B30
        public void set_targetRenderer(){} // RVA: 0xB6A8C0
        public void get_targetMaterialProperty(){} // RVA: 0xBBF8F0
        public void set_targetMaterialProperty(){} // RVA: 0xBBF900
        public void get_receivedTexture(){} // RVA: 0x650EE10
        public void SetResources(){} // RVA: 0xCA4DF0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SpoutResources : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class SpoutSender : MonoBehaviour
    {
        // ── Methods ──
        public void ReleaseSender(){} // RVA: 0x650EEF0
        public void PrepareBuffer(){} // RVA: 0x650EFB0
        public void OnCameraCapture(){} // RVA: 0x650F380
        public void PrepareCameraCapture(){} // RVA: 0x650F530
        public void OnDisable(){} // RVA: 0x650F8F0
        public void Update(){} // RVA: 0x650F930
        public void get_spoutName(){} // RVA: 0xD05CA0
        public void set_spoutName(){} // RVA: 0x650FF50
        public void ChangeSpoutName(){} // RVA: 0x650FF50
        public void get_keepAlpha(){} // RVA: 0xC02470
        public void set_keepAlpha(){} // RVA: 0xC02480
        public void get_captureMethod(){} // RVA: 0xBE5870
        public void set_captureMethod(){} // RVA: 0xBE5880
        public void get_sourceCamera(){} // RVA: 0xBBF8F0
        public void set_sourceCamera(){} // RVA: 0xBBF900
        public void get_sourceTexture(){} // RVA: 0xBE58B0
        public void set_sourceTexture(){} // RVA: 0xCA4DF0
        public void SetResources(){} // RVA: 0xC0FFD0
        public void .ctor(){} // RVA: 0x6510000
    }

    public class Utility : Object
    {
        // ── Methods ──
        public void Destroy(){} // RVA: 0x650DC20
    }

}