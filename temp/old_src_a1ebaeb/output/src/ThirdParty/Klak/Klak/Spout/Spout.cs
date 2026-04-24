// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Klak.Klak.Spout
// Classes: 11
// Methods: 60

namespace ThirdParty.Klak.Klak.Spout
{
    public class EventData : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc4a160
        public void .ctor(){} // RVA: 0x7ffaadc4a160
    }

    public class EventKicker : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc4a170
        public void Dispose(){} // RVA: 0x7ffaadc4a1e0
        public void IssuePluginEvent(){} // RVA: 0x7ffaadc4a2e0
    }

    public class MemoryPool : Object
    {
        // ── Original Methods ──
        public void FreeOnEndOfFrame(){} // RVA: 0x7ffaadc4a650
        public void OnEndOfFrame(){} // RVA: 0x7ffaadc4a710
        public void .cctor(){} // RVA: 0x7ffaadc4a8a0
        public void InsertPlayerLoopSystem(){} // RVA: 0x7ffaadc4aa40
    }

    public class Plugin : Object
    {
        // ── Original Methods ──
        public void CreateSender(){} // RVA: 0x7ffaadc4af30
        public void CreateReceiver(){} // RVA: 0x7ffaadc4aff0
        // ── Binary Analysis Named ──
        public void GetRenderEventCallback(){} // RVA: 0x7ffaadc4aec0
        public void GetReceiverData(){} // RVA: 0x7ffaadc4b0a0
        public void GetSenderNames(){} // RVA: 0x7ffaadc4b140
    }

    public class Receiver : Object
    {
        public object _texture; // 0x338B6440
        public object Texture; // 0x17000001

        // ── Original Methods ──
        public void get_Texture(){} // RVA: 0x7ffaa89600c0
        public void .ctor(){} // RVA: 0x7ffaadc4b2a0
        public void Dispose(){} // RVA: 0x7ffaadc4b470
        public void Update(){} // RVA: 0x7ffaadc4b510
    }

    public class Sender : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc4b800
        public void Dispose(){} // RVA: 0x7ffaadc4ba70
        public void Update(){} // RVA: 0x7ffaadc4bac0
    }

    public class SpoutManager : Object
    {
        // ── Binary Analysis Named ──
        public void GetSourceNames(){} // RVA: 0x7ffaadc4c2e0
    }

    public class SpoutReceiver : MonoBehaviour
    {
        public object _sourceName; // 0x3376FB70
        public object _targetMaterialProperty; // 0x3376FB70

        // ── Original Methods ──
        public void ReleaseReceiver(){} // RVA: 0x7ffaadc4c580
        public void PrepareBuffer(){} // RVA: 0x7ffaadc4c6c0
        public void OnDisable(){} // RVA: 0x7ffaadc4cc60
        public void OnDestroy(){} // RVA: 0x7ffaadc4cc70
        public void Update(){} // RVA: 0x7ffaadc4cce0
        public void get_sourceName(){} // RVA: 0x7ffaa8bfcc80
        public void set_sourceName(){} // RVA: 0x7ffaadc4d170
        public void ChangeSourceName(){} // RVA: 0x7ffaadc4d170
        public void get_targetTexture(){} // RVA: 0x7ffaa8bf45b0
        public void set_targetTexture(){} // RVA: 0x7ffaa8bf45c0
        public void get_targetRenderer(){} // RVA: 0x7ffaa89af740
        public void set_targetRenderer(){} // RVA: 0x7ffaa895a200
        public void get_targetMaterialProperty(){} // RVA: 0x7ffaa89ad730
        public void set_targetMaterialProperty(){} // RVA: 0x7ffaa89ad740
        public void get_receivedTexture(){} // RVA: 0x7ffaadc4d220
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void SetResources(){} // RVA: 0x7ffaa8a8a4d0
    }

    public class SpoutResources : ScriptableObject
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class SpoutSender : MonoBehaviour
    {
        public object _attachedCamera; // 0x336846E0
        public object _captureMethod; // 0x336846E0
        public object _resources; // 0x336846E0
        public object spoutName; // 0x17000007
        public object keepAlpha; // 0x17000008
        public object captureMethod; // 0x17000009

        // ── Original Methods ──
        public void ReleaseSender(){} // RVA: 0x7ffaadc4d300
        public void PrepareBuffer(){} // RVA: 0x7ffaadc4d3c0
        public void OnCameraCapture(){} // RVA: 0x7ffaadc4d670
        public void PrepareCameraCapture(){} // RVA: 0x7ffaadc4d820
        public void OnDisable(){} // RVA: 0x7ffaadc4dbd0
        public void Update(){} // RVA: 0x7ffaadc4dc10
        public void get_spoutName(){} // RVA: 0x7ffaa8bf45b0
        public void set_spoutName(){} // RVA: 0x7ffaadc4e1c0
        public void ChangeSpoutName(){} // RVA: 0x7ffaadc4e1c0
        public void get_keepAlpha(){} // RVA: 0x7ffaa89edc00
        public void set_keepAlpha(){} // RVA: 0x7ffaa89edc10
        public void get_captureMethod(){} // RVA: 0x7ffaa89d30a0
        public void set_captureMethod(){} // RVA: 0x7ffaa89d30b0
        public void get_sourceCamera(){} // RVA: 0x7ffaa89ad730
        public void set_sourceCamera(){} // RVA: 0x7ffaa89ad740
        public void get_sourceTexture(){} // RVA: 0x7ffaa89d30e0
        public void set_sourceTexture(){} // RVA: 0x7ffaa8a8a4d0
        public void .ctor(){} // RVA: 0x7ffaadc4e270
        // ── Binary Analysis Named ──
        public void SetResources(){} // RVA: 0x7ffaa89fa510
    }

    public class Utility : Object
    {
        // ── Original Methods ──
        public void Destroy(){} // RVA: 0x7ffaadc4c170
    }

}