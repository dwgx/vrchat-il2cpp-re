// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Discord.Discord.Sdk
// Classes: 12
// Methods: 99

namespace ThirdParty.Discord.Discord.Sdk
{
    public class Activity : Object
    {
        public object self;
        public object disposed_;

        // ── Methods ──
        public void Finalize(){} // RVA: 0x26DD0E0
        public void .ctor(){} // RVA: 0x26DD1E0
        public void Dispose(){} // RVA: 0x26DD290
        public void SetState(){} // RVA: 0x26DD360
        public void Assets(){} // RVA: 0x26DD590
        public void SetAssets(){} // RVA: 0x26DD6C0
        public void Timestamps(){} // RVA: 0x26DD7E0
        public void SetTimestamps(){} // RVA: 0x26DD910
        public void Party(){} // RVA: 0x26DDA30
        public void SetParty(){} // RVA: 0x26DDB60
        public void Secrets(){} // RVA: 0x26DDC80
        public void SetSecrets(){} // RVA: 0x26DDDB0
    }

    public class ActivityAssets : Object
    {
        public object self;
        public object disposed_;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x26DB8E0
        public void Finalize(){} // RVA: 0x26DB7E0
        public void Dispose(){} // RVA: 0x26DB990
        public void SetLargeImage(){} // RVA: 0x26DBA60
        public void SetLargeText(){} // RVA: 0x26DBC90
        public void SetSmallImage(){} // RVA: 0x26DBEC0
        public void SetSmallText(){} // RVA: 0x26DC0F0
    }

    public class ActivityParty : Object
    {
        public object self;
        public object disposed_;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x26DC780
        public void Finalize(){} // RVA: 0x26DC680
        public void Dispose(){} // RVA: 0x26DC830
        public void SetId(){} // RVA: 0x26DC900
        public void SetCurrentSize(){} // RVA: 0x26DCAD0
        public void SetMaxSize(){} // RVA: 0x26DCBB0
    }

    public class ActivitySecrets : Object
    {
        public object self;
        public object disposed_;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x26DCD90
        public void Finalize(){} // RVA: 0x26DCC90
        public void Dispose(){} // RVA: 0x26DCE40
        public void SetJoin(){} // RVA: 0x26DCF10
    }

    public class ActivityTimestamps : Object
    {
        public object self;
        public object disposed_;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x26DC420
        public void Finalize(){} // RVA: 0x26DC320
        public void Dispose(){} // RVA: 0x26DC4D0
        public void SetStart(){} // RVA: 0x26DC5A0
    }

    public class AuthorizationArgs : Object
    {
        public object self;
        public object disposed_;

        // ── Methods ──
        public void Finalize(){} // RVA: 0x26DE5F0
        public void .ctor(){} // RVA: 0x26DE6F0
        public void Dispose(){} // RVA: 0x26DE7A0
        public void SetClientId(){} // RVA: 0x26DE870
        public void SetScopes(){} // RVA: 0x26DE950
    }

    public class Client : Object
    {
        public object self;
        public object disposed_;

        // ── Methods ──
        public void Finalize(){} // RVA: 0x26DF3D0
        public void .ctor(){} // RVA: 0x26DF410
        public void Dispose(){} // RVA: 0x26DF4C0
        public void GetDefaultPresenceScopes(){} // RVA: 0x26DF590
        public void Authorize(){} // RVA: 0x26DF6A0
        public void UpdateToken(){} // RVA: 0x26DF930
        public void AddLogCallback(){} // RVA: 0x26DFC90
        public void Connect(){} // RVA: 0x26DFEF0
        public void Disconnect(){} // RVA: 0x26DFFC0
        public void SetApplicationId(){} // RVA: 0x26E0090
        public void SetStatusChangedCallback(){} // RVA: 0x26E0170
        public void ClearRichPresence(){} // RVA: 0x26E03B0
        public void SendActivityInvite(){} // RVA: 0x26E0480
        public void SetActivityJoinCallback(){} // RVA: 0x26E07E0
        public void UpdateRichPresence(){} // RVA: 0x26E0A20
        public void GetRelationships(){} // RVA: 0x26E0CB0
        public void SetUserUpdatedCallback(){} // RVA: 0x26E0F90
    }

    public class ClientResult : Object
    {
        public object self;
        public object disposed_;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2232610
        public void Finalize(){} // RVA: 0x26DDED0
        public void Dispose(){} // RVA: 0x26DDFD0
        public void ToString(){} // RVA: 0x26DE0A0
        public void Type(){} // RVA: 0x26DE210
        public void Error(){} // RVA: 0x26DE2E0
        public void ErrorCode(){} // RVA: 0x26DE450
        public void Successful(){} // RVA: 0x26DE520
    }

    public class NativeMethods : Object
    {
        public object UnhandledException;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x26D7A40
        public void __Init(){} // RVA: 0xB43310
        public void __ReportUnhandledException(){} // RVA: 0x26D7E60
        public void __OnPostConstruct(){} // RVA: 0xB43310
        public void __InitStringLocal(){} // RVA: 0x26D7F10
        public void __InitNullableStringLocal(){} // RVA: 0x26D8100
        public void __FreeLocalString(){} // RVA: 0x26D81B0
        public void Discord_Free(){} // RVA: 0x26D8220
        public void Discord_RunCallbacks(){} // RVA: 0x26D82A0
        public void Discord_ResetCallbacks(){} // RVA: 0x26D8310
    }

    public class RelationshipHandle : Object
    {
        public object self;
        public object disposed_;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2232610
        public void Finalize(){} // RVA: 0x26DEB20
        public void Dispose(){} // RVA: 0x26DEC20
        public void DiscordRelationshipType(){} // RVA: 0x26DECF0
        public void User(){} // RVA: 0x26DEDC0
    }

    public class UserHandle : Object
    {
        public object self;
        public object disposed_;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2232610
        public void Finalize(){} // RVA: 0x26DEEF0
        public void Dispose(){} // RVA: 0x26DEFF0
        public void DisplayName(){} // RVA: 0x26DF0C0
        public void Id(){} // RVA: 0x26DF230
        public void Status(){} // RVA: 0x26DF300
    }

    public class UserHandle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}