// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Discord.Discord.Sdk
// Classes: 11
// Methods: 88

namespace ThirdParty.Discord.Discord.Sdk
{
    public class Activity
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x1E5C0A0
        public void .ctor(){} // RVA: 0x1E5C1A0
        public void Dispose(){} // RVA: 0x1E5C250
        public void SetState(){} // RVA: 0x1E5C320
        public void Assets(){} // RVA: 0x1E5C540
        public void SetAssets(){} // RVA: 0x1E5C670
        public void Timestamps(){} // RVA: 0x1E5C790
        public void SetTimestamps(){} // RVA: 0x1E5C8C0
        public void Party(){} // RVA: 0x1E5C9E0
        public void SetParty(){} // RVA: 0x1E5CB10
        public void Secrets(){} // RVA: 0x1E5CC30
        public void SetSecrets(){} // RVA: 0x1E5CD60
    }

    public class ActivityAssets
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1E5A8E0 | overloaded x2
        public void Finalize(){} // RVA: 0x1E5A7E0
        public void Dispose(){} // RVA: 0x1E5A990
        public void SetLargeImage(){} // RVA: 0x1E5AA60
        public void SetLargeText(){} // RVA: 0x1E5AC80
        public void SetSmallImage(){} // RVA: 0x1E5AEA0
        public void SetSmallText(){} // RVA: 0x1E5B0C0
    }

    public class ActivityParty
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1E5B740 | overloaded x2
        public void Finalize(){} // RVA: 0x1E5B640
        public void Dispose(){} // RVA: 0x1E5B7F0
        public void SetId(){} // RVA: 0x1E5B8C0
        public void SetCurrentSize(){} // RVA: 0x1E5BA90
        public void SetMaxSize(){} // RVA: 0x1E5BB70
    }

    public class ActivitySecrets
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1E5BD50 | overloaded x2
        public void Finalize(){} // RVA: 0x1E5BC50
        public void Dispose(){} // RVA: 0x1E5BE00
        public void SetJoin(){} // RVA: 0x1E5BED0
    }

    public class ActivityTimestamps
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1E5B3E0 | overloaded x2
        public void Finalize(){} // RVA: 0x1E5B2E0
        public void Dispose(){} // RVA: 0x1E5B490
        public void SetStart(){} // RVA: 0x1E5B560
    }

    public class AuthorizationArgs
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x1E5D5A0
        public void .ctor(){} // RVA: 0x1E5D6A0
        public void Dispose(){} // RVA: 0x1E5D750
        public void SetClientId(){} // RVA: 0x1E5D820
        public void SetScopes(){} // RVA: 0x1E5D900
    }

    public class Client
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x1E5E380
        public void .ctor(){} // RVA: 0x1E5E3C0
        public void Dispose(){} // RVA: 0x1E5E470
        public void GetDefaultPresenceScopes(){} // RVA: 0x1E5E540
        public void Authorize(){} // RVA: 0x1E5E650
        public void UpdateToken(){} // RVA: 0x1E5E8D0
        public void AddLogCallback(){} // RVA: 0x1E5EC40
        public void Connect(){} // RVA: 0x1E5EEB0
        public void Disconnect(){} // RVA: 0x1E5EF80
        public void SetApplicationId(){} // RVA: 0x1E5F050
        public void SetStatusChangedCallback(){} // RVA: 0x1E5F130
        public void ClearRichPresence(){} // RVA: 0x1E5F380
        public void SendActivityInvite(){} // RVA: 0x1E5F450
        public void SetActivityJoinCallback(){} // RVA: 0x1E5F7C0
        public void UpdateRichPresence(){} // RVA: 0x1E5FA10
        public void GetRelationships(){} // RVA: 0x1E5FC90
        public void SetUserUpdatedCallback(){} // RVA: 0x1E5FF70
    }

    public class ClientResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1969380
        public void Finalize(){} // RVA: 0x1E5CE80
        public void Dispose(){} // RVA: 0x1E5CF80
        public void ToString(){} // RVA: 0x1E5D050
        public void Type(){} // RVA: 0x1E5D1C0
        public void Error(){} // RVA: 0x1E5D290
        public void ErrorCode(){} // RVA: 0x1E5D400
        public void Successful(){} // RVA: 0x1E5D4D0
    }

    public class NativeMethods
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x1E56A20
        public void __Init(){} // RVA: 0x2DD310
        public void __ReportUnhandledException(){} // RVA: 0x1E56E60
        public void __OnPostConstruct(){} // RVA: 0x2DD310
        public void __InitStringLocal(){} // RVA: 0x1E56F10
        public void __InitNullableStringLocal(){} // RVA: 0x1E57100
        public void __FreeLocalString(){} // RVA: 0x1E571B0
        public void Discord_Free(){} // RVA: 0x1E57220
        public void Discord_RunCallbacks(){} // RVA: 0x1E572A0
        public void Discord_ResetCallbacks(){} // RVA: 0x1E57310
    }

    public class RelationshipHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1969380
        public void Finalize(){} // RVA: 0x1E5DAD0
        public void Dispose(){} // RVA: 0x1E5DBD0
        public void DiscordRelationshipType(){} // RVA: 0x1E5DCA0
        public void User(){} // RVA: 0x1E5DD70
    }

    public class UserHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1969380
        public void Finalize(){} // RVA: 0x1E5DEA0
        public void Dispose(){} // RVA: 0x1E5DFA0
        public void DisplayName(){} // RVA: 0x1E5E070
        public void Id(){} // RVA: 0x1E5E1E0
        public void Status(){} // RVA: 0x1E5E2B0
    }

}