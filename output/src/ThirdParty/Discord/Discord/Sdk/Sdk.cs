// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Discord.Discord.Sdk
// Classes: 3
// Methods: 28

namespace ThirdParty.Discord.Discord.Sdk
{
    public class Activity : Object
    {
        public Activity self; // 0x10
        public int disposed_; // 0x18

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFD4FD99B80
        public void .ctor(){} // RVA: 0x7FFD4FD99C80
        public void Dispose(){} // RVA: 0x7FFD4FD99D30
        public void SetState(){} // RVA: 0x7FFD4FD99E00
        public void Assets(){} // RVA: 0x7FFD4FD9A020
        public void SetAssets(){} // RVA: 0x7FFD4FD9A150
        public void Timestamps(){} // RVA: 0x7FFD4FD9A270
        public void SetTimestamps(){} // RVA: 0x7FFD4FD9A3A0
        public void Party(){} // RVA: 0x7FFD4FD9A4C0
        public void SetParty(){} // RVA: 0x7FFD4FD9A5F0
        public void Secrets(){} // RVA: 0x7FFD4FD9A710
        public void SetSecrets(){} // RVA: 0x7FFD4FD9A840
    }

    public class NativeMethods : Object
    {
        public System.Action`1<System.Exception> UnhandledException;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4FD94500
        public void __Init(){} // RVA: 0x7FFD4E341310
        public void __ReportUnhandledException(){} // RVA: 0x7FFD4FD94940
        public void __OnPostConstruct(){} // RVA: 0x7FFD4E341310
        public void __InitStringLocal(){} // RVA: 0x7FFD4FD949F0
        public void __InitNullableStringLocal(){} // RVA: 0x7FFD4FD94BE0
        public void __FreeLocalString(){} // RVA: 0x7FFD4FD94C90
        public void Discord_Free(){} // RVA: 0x7FFD4FD94D00
        public void Discord_RunCallbacks(){} // RVA: 0x7FFD4FD94D80
        public void Discord_ResetCallbacks(){} // RVA: 0x7FFD4FD94DF0
    }

    public class UserHandle : Object
    {
        public UserHandle self; // 0x10
        public int disposed_; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F840710
        public void Finalize(){} // RVA: 0x7FFD4FD9B980
        public void Dispose(){} // RVA: 0x7FFD4FD9BA80
        public void DisplayName(){} // RVA: 0x7FFD4FD9BB50
        public void Id(){} // RVA: 0x7FFD4FD9BCC0
        public void Status(){} // RVA: 0x7FFD4FD9BD90
    }

}