// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Klak.Klak.Spout
// Classes: 13
// Methods: 66

namespace ThirdParty.Klak.Klak.Spout
{
    public class Blitter : Object
    {
        // ── Methods ──
        public void Blit(){} // RVA: 0x7FFE865D45C0 | overloaded x2
        public void BlitVFlip(){} // RVA: 0x7FFE865D4520
        public void BlitFromSrgb(){} // RVA: 0x7FFE865D4670
        public void GetMaterial(){} // RVA: 0x7FFE865D4700
    }

    public class EventData : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865D28F0 | overloaded x2
    }

    public class EventKicker : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865D2900
        public void Dispose(){} // RVA: 0x7FFE865D2970
        public void IssuePluginEvent(){} // RVA: 0x7FFE865D2A70
    }

    public class MemoryPool : Object
    {
        // ── Methods ──
        public void FreeOnEndOfFrame(){} // RVA: 0x7FFE865D2DE0
        public void OnEndOfFrame(){} // RVA: 0x7FFE865D2EA0
        public void .cctor(){} // RVA: 0x7FFE865D3030
        public void InsertPlayerLoopSystem(){} // RVA: 0x7FFE865D31D0
    }

    public class Plugin : Object
    {
        // ── Methods ──
        public void GetRenderEventCallback(){} // RVA: 0x7FFE865D3650
        public void CreateSender(){} // RVA: 0x7FFE865D36C0
        public void CreateReceiver(){} // RVA: 0x7FFE865D3780
        public void GetReceiverData(){} // RVA: 0x7FFE865D3830
        public void GetSenderNames(){} // RVA: 0x7FFE865D38D0
    }

    public class Receiver : Object
    {
        public UIntPtr _plugin; // 0x10

        // ── Methods ──
        public void get_Texture(){} // RVA: 0x7FFE811290C0
        public void .ctor(){} // RVA: 0x7FFE865D3A30
        public void Dispose(){} // RVA: 0x7FFE865D3C00
        public void Update(){} // RVA: 0x7FFE865D3CA0
    }

    public class RendererOverride : Object
    {
        // ── Methods ──
        public void SetTexture(){} // RVA: 0x7FFE865D4270
    }

    public class Sender : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865D3F90
        public void Dispose(){} // RVA: 0x7FFE865D4200
        public void Update(){} // RVA: 0x7FFE865D4250
    }

    public class SpoutManager : Object
    {
        // ── Methods ──
        public void GetSourceNames(){} // RVA: 0x7FFE865D4A70
    }

    public class SpoutReceiver : MonoBehaviour
    {
        public Klak.Spout.Receiver _receiver; // 0x20
        public UnityEngine.RenderTexture _buffer; // 0x28
        public string _sourceName; // 0x30
        public UnityEngine.RenderTexture _targetTexture; // 0x38
        public UnityEngine.Renderer _targetRenderer; // 0x40

        // ── Methods ──
        public void ReleaseReceiver(){} // RVA: 0x7FFE865D4D10
        public void PrepareBuffer(){} // RVA: 0x7FFE865D4E50
        public void OnDisable(){} // RVA: 0x7FFE865D53F0
        public void OnDestroy(){} // RVA: 0x7FFE865D5400
        public void Update(){} // RVA: 0x7FFE865D5470
        public void get_sourceName(){} // RVA: 0x7FFE8144E200
        public void set_sourceName(){} // RVA: 0x7FFE865D5900
        public void ChangeSourceName(){} // RVA: 0x7FFE865D5900
        public void get_targetTexture(){} // RVA: 0x7FFE8143BA80
        public void set_targetTexture(){} // RVA: 0x7FFE81437330
        public void get_targetRenderer(){} // RVA: 0x7FFE81178740
        public void set_targetRenderer(){} // RVA: 0x7FFE81123200
        public void get_targetMaterialProperty(){} // RVA: 0x7FFE81176730
        public void set_targetMaterialProperty(){} // RVA: 0x7FFE81176740
        public void get_receivedTexture(){} // RVA: 0x7FFE865D59B0
        public void SetResources(){} // RVA: 0x7FFE812534D0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SpoutResources : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class SpoutSender : MonoBehaviour
    {
        public Klak.Spout.Sender _sender; // 0x20
        public UnityEngine.RenderTexture _buffer; // 0x28
        public UnityEngine.Camera _attachedCamera; // 0x30
        public string _spoutName; // 0x38
        public bool _keepAlpha; // 0x40

        // ── Methods ──
        public void ReleaseSender(){} // RVA: 0x7FFE865D5A90
        public void PrepareBuffer(){} // RVA: 0x7FFE865D5B50
        public void OnCameraCapture(){} // RVA: 0x7FFE865D5E00
        public void PrepareCameraCapture(){} // RVA: 0x7FFE865D5FB0
        public void OnDisable(){} // RVA: 0x7FFE865D6360
        public void Update(){} // RVA: 0x7FFE865D63A0
        public void get_spoutName(){} // RVA: 0x7FFE8143BA80
        public void set_spoutName(){} // RVA: 0x7FFE865D6950
        public void ChangeSpoutName(){} // RVA: 0x7FFE865D6950
        public void get_keepAlpha(){} // RVA: 0x7FFE811B6C00
        public void set_keepAlpha(){} // RVA: 0x7FFE811B6C10
        public void get_captureMethod(){} // RVA: 0x7FFE8119C0A0
        public void set_captureMethod(){} // RVA: 0x7FFE8119C0B0
        public void get_sourceCamera(){} // RVA: 0x7FFE81176730
        public void set_sourceCamera(){} // RVA: 0x7FFE81176740
        public void get_sourceTexture(){} // RVA: 0x7FFE8119C0E0
        public void set_sourceTexture(){} // RVA: 0x7FFE812534D0
        public void SetResources(){} // RVA: 0x7FFE811C3510
        public void .ctor(){} // RVA: 0x7FFE865D6A00
    }

    public class Utility : Object
    {
        // ── Methods ──
        public void Destroy(){} // RVA: 0x7FFE865D4900
    }

}