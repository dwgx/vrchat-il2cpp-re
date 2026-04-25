// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Klak.Klak.Spout
// Classes: 13
// Methods: 66

namespace ThirdParty.Klak.Klak.Spout
{
    public class Blitter : Object
    {
        public UnityEngine.Material _material;

        // ── Methods ──
        public void Blit(){} // RVA: 0x7FFAC822AC80 | overloaded x2
        public void BlitVFlip(){} // RVA: 0x7FFAC822ABE0
        public void BlitFromSrgb(){} // RVA: 0x7FFAC822AD30
        public void GetMaterial(){} // RVA: 0x7FFAC822ADC0
    }

    public class EventData : ValueType
    {
        public UIntPtr instancePointer; // 0x10
        public UIntPtr texturePointer; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8228FB0 | overloaded x2
    }

    public class EventKicker : Object
    {
        public UnityEngine.Rendering.CommandBuffer _cmdBuffer;
        public System.Runtime.InteropServices.GCHandle _dataMem; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8228FC0
        public void Dispose(){} // RVA: 0x7FFAC8229030
        public void IssuePluginEvent(){} // RVA: 0x7FFAC8229130
    }

    public class MemoryPool : Object
    {
        public System.Collections.Generic.Stack`1<System.Runtime.InteropServices.GCHandle> _toBeFreed;

        // ── Methods ──
        public void FreeOnEndOfFrame(){} // RVA: 0x7FFAC82294A0
        public void OnEndOfFrame(){} // RVA: 0x7FFAC8229560
        public void .cctor(){} // RVA: 0x7FFAC82296F0
        public void InsertPlayerLoopSystem(){} // RVA: 0x7FFAC8229890
    }

    public class Plugin : Object
    {
        // ── Methods ──
        public void GetRenderEventCallback(){} // RVA: 0x7FFAC8229D10
        public void CreateSender(){} // RVA: 0x7FFAC8229D80
        public void CreateReceiver(){} // RVA: 0x7FFAC8229E40
        public void GetReceiverData(){} // RVA: 0x7FFAC8229EF0
        public void GetSenderNames(){} // RVA: 0x7FFAC8229F90
    }

    public class Receiver : Object
    {
        public UIntPtr Texture; // 0x10
        public Klak.Spout.EventKicker _event; // 0x18
        public UnityEngine.Texture2D _texture; // 0x20

        // ── Methods ──
        public void get_Texture(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFAC822A0F0
        public void Dispose(){} // RVA: 0x7FFAC822A2C0
        public void Update(){} // RVA: 0x7FFAC822A360
    }

    public class RendererOverride : Object
    {
        public UnityEngine.MaterialPropertyBlock _block;

        // ── Methods ──
        public void SetTexture(){} // RVA: 0x7FFAC822A930
    }

    public class Sender : Object
    {
        public UIntPtr _plugin; // 0x10
        public Klak.Spout.EventKicker _event; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC822A650
        public void Dispose(){} // RVA: 0x7FFAC822A8C0
        public void Update(){} // RVA: 0x7FFAC822A910
    }

    public class SpoutManager : Object
    {
        // ── Methods ──
        public void GetSourceNames(){} // RVA: 0x7FFAC822B130
    }

    public class SpoutReceiver : MonoBehaviour
    {
        public Klak.Spout.Receiver sourceName; // 0x20
        public UnityEngine.RenderTexture targetTexture; // 0x28
        public string targetRenderer; // 0x30
        public UnityEngine.RenderTexture targetMaterialProperty; // 0x38
        public UnityEngine.Renderer receivedTexture; // 0x40
        public string _targetMaterialProperty; // 0x48
        public Klak.Spout.SpoutResources _resources; // 0x50

        // ── Methods ──
        public void ReleaseReceiver(){} // RVA: 0x7FFAC822B3D0
        public void PrepareBuffer(){} // RVA: 0x7FFAC822B510
        public void OnDisable(){} // RVA: 0x7FFAC822BAB0
        public void OnDestroy(){} // RVA: 0x7FFAC822BAC0
        public void Update(){} // RVA: 0x7FFAC822BB30
        public void get_sourceName(){} // RVA: 0x7FFAC31D95E0
        public void set_sourceName(){} // RVA: 0x7FFAC822BFC0
        public void ChangeSourceName(){} // RVA: 0x7FFAC822BFC0
        public void get_targetTexture(){} // RVA: 0x7FFAC31D0140
        public void set_targetTexture(){} // RVA: 0x7FFAC31D0C20
        public void get_targetRenderer(){} // RVA: 0x7FFAC2F9E740
        public void set_targetRenderer(){} // RVA: 0x7FFAC2F49200
        public void get_targetMaterialProperty(){} // RVA: 0x7FFAC2F9C730
        public void set_targetMaterialProperty(){} // RVA: 0x7FFAC2F9C740
        public void get_receivedTexture(){} // RVA: 0x7FFAC822C070
        public void SetResources(){} // RVA: 0x7FFAC30794D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SpoutResources : ScriptableObject
    {
        public UnityEngine.Shader blitShader; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class SpoutSender : MonoBehaviour
    {
        public Klak.Spout.Sender spoutName; // 0x20
        public UnityEngine.RenderTexture keepAlpha; // 0x28
        public UnityEngine.Camera captureMethod; // 0x30
        public string sourceCamera; // 0x38
        public bool sourceTexture; // 0x40
        public 0x6B2DE8B0 _captureMethod; // 0x44
        public UnityEngine.Camera _sourceCamera; // 0x48
        public UnityEngine.Texture _sourceTexture; // 0x50
        public Klak.Spout.SpoutResources _resources; // 0x58

        // ── Methods ──
        public void ReleaseSender(){} // RVA: 0x7FFAC822C150
        public void PrepareBuffer(){} // RVA: 0x7FFAC822C210
        public void OnCameraCapture(){} // RVA: 0x7FFAC822C4C0
        public void PrepareCameraCapture(){} // RVA: 0x7FFAC822C670
        public void OnDisable(){} // RVA: 0x7FFAC822CA20
        public void Update(){} // RVA: 0x7FFAC822CA60
        public void get_spoutName(){} // RVA: 0x7FFAC31D0140
        public void set_spoutName(){} // RVA: 0x7FFAC822D010
        public void ChangeSpoutName(){} // RVA: 0x7FFAC822D010
        public void get_keepAlpha(){} // RVA: 0x7FFAC2FDCC00
        public void set_keepAlpha(){} // RVA: 0x7FFAC2FDCC10
        public void get_captureMethod(){} // RVA: 0x7FFAC2FC20A0
        public void set_captureMethod(){} // RVA: 0x7FFAC2FC20B0
        public void get_sourceCamera(){} // RVA: 0x7FFAC2F9C730
        public void set_sourceCamera(){} // RVA: 0x7FFAC2F9C740
        public void get_sourceTexture(){} // RVA: 0x7FFAC2FC20E0
        public void set_sourceTexture(){} // RVA: 0x7FFAC30794D0
        public void SetResources(){} // RVA: 0x7FFAC2FE9510
        public void .ctor(){} // RVA: 0x7FFAC822D0C0
    }

    public class Utility : Object
    {
        // ── Methods ──
        public void Destroy(){} // RVA: 0x7FFAC822AFC0
    }

}