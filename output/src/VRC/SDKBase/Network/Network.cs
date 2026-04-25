// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Network
// Classes: 3
// Methods: 8

namespace VRC.SDKBase.Network
{
    public class NetworkIDAssignment : Object
    {
        public int MinID;
        public int MaxID;

        // ── Methods ──
        public void GetNetworkIDGameObjectPath(){} // RVA: 0x7FFACC09C570
        public void GetSerializedTypes(){} // RVA: 0x7FFACC09C910 | overloaded x2
        public void ConfigureNetworkIDs(){} // RVA: 0x7FFACC09CB40
        public void <ConfigureNetworkIDs>g__DoTypesMatch|7_7(){} // RVA: 0x7FFACC09E0D0
    }

    public class NetworkIDPair : Object
    {
        public UnityEngine.GameObject gameObject; // 0x10
        public int ID; // 0x18
        public System.Collections.Generic.List`1<string> SerializedTypeNames; // 0x20

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFACC09C2B0
        public void .ctor(){} // RVA: 0x7FFACC09C4B0
    }

    public class VRCNetworkBehaviour : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

}