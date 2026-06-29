// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Klak.Klak.Spout
// Classes: 13
// Methods: 65

namespace ThirdParty.Klak.Klak.Spout
{
    public class Blitter : Object
    {
        // ── Methods ──
        public void Blit(){} // RVA: 0x7AD880530
        public void BlitVFlip(){} // RVA: 0x7AD880490
        public void BlitFromSrgb(){} // RVA: 0x7AD8805E0
        public void GetMaterial(){} // RVA: 0x7AD880670
    }

    public class EventData : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E27F10
        public void instancePointer(){} // RVA: 0x7B41F3B08
    }

    public class EventKicker : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD87E940
        public void Dispose(){} // RVA: 0x7AD87E9B0
        public void IssuePluginEvent(){} // RVA: 0x7AD87EAB0
    }

    public class MemoryPool : Object
    {
        // ── Methods ──
        public void FreeOnEndOfFrame(){} // RVA: 0x7AD87ED50
        public void OnEndOfFrame(){} // RVA: 0x7AD87EE10
        public void .cctor(){} // RVA: 0x7AD87EFA0
        public void InsertPlayerLoopSystem(){} // RVA: 0x7AD87F140
    }

    public class Plugin : Object
    {
        // ── Methods ──
        public void GetRenderEventCallback(){} // RVA: 0x7AD87F5C0
        public void CreateSender(){} // RVA: 0x7AD87F630
        public void CreateReceiver(){} // RVA: 0x7AD87F6F0
        public void GetReceiverData(){} // RVA: 0x7AD87F7A0
        public void GetSenderNames(){} // RVA: 0x7AD87F840
    }

    public class Receiver : Object
    {
        // ── Methods ──
        public void get_Texture(){} // RVA: 0x7A81052C0
        public void .ctor(){} // RVA: 0x7AD87F9A0
        public void Dispose(){} // RVA: 0x7AD87FB70
        public void Update(){} // RVA: 0x7AD87FC10
    }

    public class RendererOverride : Object
    {
        // ── Methods ──
        public void SetTexture(){} // RVA: 0x7AD8801E0
    }

    public class Sender : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD87FF00
        public void Dispose(){} // RVA: 0x7AD880170
        public void Update(){} // RVA: 0x7AD8801C0
    }

    public class SpoutManager : Object
    {
        // ── Methods ──
        public void GetSourceNames(){} // RVA: 0x7AD8809E0
    }

    public class SpoutReceiver : MonoBehaviour
    {
        // ── Methods ──
        public void ReleaseReceiver(){} // RVA: 0x7AD880CA0
        public void PrepareBuffer(){} // RVA: 0x7AD880DE0
        public void OnDisable(){} // RVA: 0x7AD881380
        public void OnDestroy(){} // RVA: 0x7AD881390
        public void Update(){} // RVA: 0x7AD881400
        public void get_sourceName(){} // RVA: 0x7A83F69F0
        public void set_sourceName(){} // RVA: 0x7AD881890
        public void ChangeSourceName(){} // RVA: 0x7AD881890
        public void get_targetTexture(){} // RVA: 0x7A8292C30
        public void set_targetTexture(){} // RVA: 0x7A8296DE0
        public void get_targetRenderer(){} // RVA: 0x7A8154D80
        public void set_targetRenderer(){} // RVA: 0x7A80FF440
        public void get_targetMaterialProperty(){} // RVA: 0x7A8152D80
        public void set_targetMaterialProperty(){} // RVA: 0x7A8152D90
        public void get_receivedTexture(){} // RVA: 0x7AD881940
        public void SetResources(){} // RVA: 0x7A8230620
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class SpoutResources : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class SpoutSender : MonoBehaviour
    {
        // ── Methods ──
        public void ReleaseSender(){} // RVA: 0x7AD881A20
        public void PrepareBuffer(){} // RVA: 0x7AD881AE0
        public void OnCameraCapture(){} // RVA: 0x7AD881D90
        public void PrepareCameraCapture(){} // RVA: 0x7AD881F40
        public void OnDisable(){} // RVA: 0x7AD882300
        public void Update(){} // RVA: 0x7AD882340
        public void get_spoutName(){} // RVA: 0x7A8292C30
        public void set_spoutName(){} // RVA: 0x7AD8828F0
        public void ChangeSpoutName(){} // RVA: 0x7AD8828F0
        public void get_keepAlpha(){} // RVA: 0x7A8193790
        public void set_keepAlpha(){} // RVA: 0x7A81937A0
        public void get_captureMethod(){} // RVA: 0x7A8178B50
        public void set_captureMethod(){} // RVA: 0x7A8178B60
        public void get_sourceCamera(){} // RVA: 0x7A8152D80
        public void set_sourceCamera(){} // RVA: 0x7A8152D90
        public void get_sourceTexture(){} // RVA: 0x7A8178B90
        public void set_sourceTexture(){} // RVA: 0x7A8230620
        public void SetResources(){} // RVA: 0x7A81A0060
        public void .ctor(){} // RVA: 0x7AD8829A0
    }

    public class Utility : Object
    {
        // ── Methods ──
        public void Destroy(){} // RVA: 0x7AD880870
    }

}