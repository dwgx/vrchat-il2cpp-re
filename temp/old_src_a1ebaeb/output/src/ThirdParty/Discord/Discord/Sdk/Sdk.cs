// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Discord.Discord.Sdk
// Classes: 3
// Methods: 33

namespace ThirdParty.Discord.Discord.Sdk
{
    public class Client : Object
    {
        public object Handle; // 0x35CC9DC0

        // ── Original Methods ──
        public void Finalize(){} // RVA: 0x7ffaaa3838e0
        public void .ctor(){} // RVA: 0x7ffaaa383920
        public void Dispose(){} // RVA: 0x7ffaaa3839d0
        public void Authorize(){} // RVA: 0x7ffaaa383bb0
        public void UpdateToken(){} // RVA: 0x7ffaaa383e30
        public void AddLogCallback(){} // RVA: 0x7ffaaa3841a0
        public void Connect(){} // RVA: 0x7ffaaa384410
        public void Disconnect(){} // RVA: 0x7ffaaa3844e0
        public void ClearRichPresence(){} // RVA: 0x7ffaaa3848e0
        public void SendActivityInvite(){} // RVA: 0x7ffaaa3849b0
        public void UpdateRichPresence(){} // RVA: 0x7ffaaa384f70
        // ── Binary Analysis Named ──
        public void GetDefaultPresenceScopes(){} // RVA: 0x7ffaaa383aa0
        public void SetApplicationId(){} // RVA: 0x7ffaaa3845b0
        public void SetStatusChangedCallback(){} // RVA: 0x7ffaaa384690
        public void SetActivityJoinCallback(){} // RVA: 0x7ffaaa384d20
        public void GetRelationships(){} // RVA: 0x7ffaaa3851f0
        public void SetUserUpdatedCallback(){} // RVA: 0x7ffaaa3854d0
    }

    public class NativeMethods : Object
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaa37bf80
        public void __Init(){} // RVA: 0x7ffaa8932310
        public void __ReportUnhandledException(){} // RVA: 0x7ffaaa37c3c0
        public void __OnPostConstruct(){} // RVA: 0x7ffaa8932310
        public void __InitStringLocal(){} // RVA: 0x7ffaaa37c470
        public void __InitNullableStringLocal(){} // RVA: 0x7ffaaa37c660
        public void __FreeLocalString(){} // RVA: 0x7ffaaa37c710
        public void Discord_Free(){} // RVA: 0x7ffaaa37c780
        public void Discord_RunCallbacks(){} // RVA: 0x7ffaaa37c800
        public void Discord_ResetCallbacks(){} // RVA: 0x7ffaaa37c870
    }

    public class UserHandle : Object
    {
        public object Handle; // 0x35CC9AB0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9e47b30
        public void Finalize(){} // RVA: 0x7ffaaa383400
        public void Dispose(){} // RVA: 0x7ffaaa383500
        public void DisplayName(){} // RVA: 0x7ffaaa3835d0
        public void Id(){} // RVA: 0x7ffaaa383740
        public void Status(){} // RVA: 0x7ffaaa383810
    }

}