// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.OscCore.OscCore.Demo
// Classes: 1
// Methods: 6

namespace ThirdParty.OscCore.OscCore.Demo
{
    public class MonitorToDebugText : MonoBehaviour
    {
        public int k_LineCount;
        public int k_LastIndex;
        public System.Text.StringBuilder k_StringBuilder;
        public OscCore.OscReceiver Receiver; // 0x20
        public UnityEngine.TextMesh IpAddressText; // 0x28
        public UnityEngine.TextMesh RecentValueText; // 0x30
        public int m_ReplaceLineIndex; // 0x38
        public bool m_Dirty; // 0x3C
        public string[] m_ReceivedAsString; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD53DBE690
        public void Update(){} // RVA: 0x7FFD53DBE8F0
        public void Monitor(){} // RVA: 0x7FFD53DBEAE0
        public void BuildMultiLine(){} // RVA: 0x7FFD53DBEC40
        public void .ctor(){} // RVA: 0x7FFD53DBEDD0
        public void .cctor(){} // RVA: 0x7FFD53DBEEA0
    }

}