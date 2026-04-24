// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Klak.Klak.Spout
// Classes: 11
// Methods: 60

namespace ThirdParty.Klak.Klak.Spout
{
    public class EventData : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53648FB0 | overloaded x2
    }

    public class EventKicker : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53648FC0
        public void Dispose(){} // RVA: 0x7FFD53649030
        public void IssuePluginEvent(){} // RVA: 0x7FFD53649130
    }

    public class MemoryPool : Object
    {
        // ── Methods ──
        public void FreeOnEndOfFrame(){} // RVA: 0x7FFD536494A0
        public void OnEndOfFrame(){} // RVA: 0x7FFD53649560
        public void .cctor(){} // RVA: 0x7FFD536496F0
        public void InsertPlayerLoopSystem(){} // RVA: 0x7FFD53649890
    }

    public class Plugin : Object
    {
        // ── Methods ──
        public void GetRenderEventCallback(){} // RVA: 0x7FFD53649D10
        public void CreateSender(){} // RVA: 0x7FFD53649D80
        public void CreateReceiver(){} // RVA: 0x7FFD53649E40
        public void GetReceiverData(){} // RVA: 0x7FFD53649EF0
        public void GetSenderNames(){} // RVA: 0x7FFD53649F90
    }

    public class Receiver : Object
    {
        public object Texture;

        // ── Methods ──
        public void get_Texture(){} // RVA: 0x7FFD4E36F0C0
        public void .ctor(){} // RVA: 0x7FFD5364A0F0
        public void Dispose(){} // RVA: 0x7FFD5364A2C0
        public void Update(){} // RVA: 0x7FFD5364A360
    }

    public class Sender : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5364A650
        public void Dispose(){} // RVA: 0x7FFD5364A8C0
        public void Update(){} // RVA: 0x7FFD5364A910
    }

    public class SpoutManager : Object
    {
        // ── Methods ──
        public void GetSourceNames(){} // RVA: 0x7FFD5364B130
    }

    public class SpoutReceiver : MonoBehaviour
    {
        public object sourceName;
        public object targetTexture;
        public object targetRenderer;
        public object targetMaterialProperty;
        public object receivedTexture;

        // ── Methods ──
        public void ReleaseReceiver(){} // RVA: 0x7FFD5364B3D0
        public void PrepareBuffer(){} // RVA: 0x7FFD5364B510
        public void OnDisable(){} // RVA: 0x7FFD5364BAB0
        public void OnDestroy(){} // RVA: 0x7FFD5364BAC0
        public void Update(){} // RVA: 0x7FFD5364BB30
        public void get_sourceName(){} // RVA: 0x7FFD4E5F95E0
        public void set_sourceName(){} // RVA: 0x7FFD5364BFC0
        public void ChangeSourceName(){} // RVA: 0x7FFD5364BFC0
        public void get_targetTexture(){} // RVA: 0x7FFD4E5F0140
        public void set_targetTexture(){} // RVA: 0x7FFD4E5F0C20
        public void get_targetRenderer(){} // RVA: 0x7FFD4E3BE740
        public void set_targetRenderer(){} // RVA: 0x7FFD4E369200
        public void get_targetMaterialProperty(){} // RVA: 0x7FFD4E3BC730
        public void set_targetMaterialProperty(){} // RVA: 0x7FFD4E3BC740
        public void get_receivedTexture(){} // RVA: 0x7FFD5364C070
        public void SetResources(){} // RVA: 0x7FFD4E4994D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SpoutResources : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class SpoutSender : MonoBehaviour
    {
        public object spoutName;
        public object keepAlpha;
        public object captureMethod;
        public object sourceCamera;
        public object sourceTexture;

        // ── Methods ──
        public void ReleaseSender(){} // RVA: 0x7FFD5364C150
        public void PrepareBuffer(){} // RVA: 0x7FFD5364C210
        public void OnCameraCapture(){} // RVA: 0x7FFD5364C4C0
        public void PrepareCameraCapture(){} // RVA: 0x7FFD5364C670
        public void OnDisable(){} // RVA: 0x7FFD5364CA20
        public void Update(){} // RVA: 0x7FFD5364CA60
        public void get_spoutName(){} // RVA: 0x7FFD4E5F0140
        public void set_spoutName(){} // RVA: 0x7FFD5364D010
        public void ChangeSpoutName(){} // RVA: 0x7FFD5364D010
        public void get_keepAlpha(){} // RVA: 0x7FFD4E3FCC00
        public void set_keepAlpha(){} // RVA: 0x7FFD4E3FCC10
        public void get_captureMethod(){} // RVA: 0x7FFD4E3E20A0
        public void set_captureMethod(){} // RVA: 0x7FFD4E3E20B0
        public void get_sourceCamera(){} // RVA: 0x7FFD4E3BC730
        public void set_sourceCamera(){} // RVA: 0x7FFD4E3BC740
        public void get_sourceTexture(){} // RVA: 0x7FFD4E3E20E0
        public void set_sourceTexture(){} // RVA: 0x7FFD4E4994D0
        public void SetResources(){} // RVA: 0x7FFD4E409510
        public void .ctor(){} // RVA: 0x7FFD5364D0C0
    }

    public class Utility : Object
    {
        // ── Methods ──
        public void Destroy(){} // RVA: 0x7FFD5364AFC0
    }

}