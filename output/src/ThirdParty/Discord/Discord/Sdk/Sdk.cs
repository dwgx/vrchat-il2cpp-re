// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Discord.Discord.Sdk
// Classes: 11
// Methods: 88

namespace ThirdParty.Discord.Discord.Sdk
{
    public class Activity
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFAF490C0A0
        public void .ctor(){} // RVA: 0x7FFAF490C1A0
        public void Dispose(){} // RVA: 0x7FFAF490C250
        public void SetState(){} // RVA: 0x7FFAF490C320
        public void Assets(){} // RVA: 0x7FFAF490C540
        public void SetAssets(){} // RVA: 0x7FFAF490C670
        public void Timestamps(){} // RVA: 0x7FFAF490C790
        public void SetTimestamps(){} // RVA: 0x7FFAF490C8C0
        public void Party(){} // RVA: 0x7FFAF490C9E0
        public void SetParty(){} // RVA: 0x7FFAF490CB10
        public void Secrets(){} // RVA: 0x7FFAF490CC30
        public void SetSecrets(){} // RVA: 0x7FFAF490CD60
    }

    public class ActivityAssets
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF490A8E0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF490A7E0
        public void Dispose(){} // RVA: 0x7FFAF490A990
        public void SetLargeImage(){} // RVA: 0x7FFAF490AA60
        public void SetLargeText(){} // RVA: 0x7FFAF490AC80
        public void SetSmallImage(){} // RVA: 0x7FFAF490AEA0
        public void SetSmallText(){} // RVA: 0x7FFAF490B0C0
    }

    public class ActivityParty
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF490B740 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF490B640
        public void Dispose(){} // RVA: 0x7FFAF490B7F0
        public void SetId(){} // RVA: 0x7FFAF490B8C0
        public void SetCurrentSize(){} // RVA: 0x7FFAF490BA90
        public void SetMaxSize(){} // RVA: 0x7FFAF490BB70
    }

    public class ActivitySecrets
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF490BD50 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF490BC50
        public void Dispose(){} // RVA: 0x7FFAF490BE00
        public void SetJoin(){} // RVA: 0x7FFAF490BED0
    }

    public class ActivityTimestamps
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF490B3E0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF490B2E0
        public void Dispose(){} // RVA: 0x7FFAF490B490
        public void SetStart(){} // RVA: 0x7FFAF490B560
    }

    public class AuthorizationArgs
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFAF490D5A0
        public void .ctor(){} // RVA: 0x7FFAF490D6A0
        public void Dispose(){} // RVA: 0x7FFAF490D750
        public void SetClientId(){} // RVA: 0x7FFAF490D820
        public void SetScopes(){} // RVA: 0x7FFAF490D900
    }

    public class Client
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFAF490E380
        public void .ctor(){} // RVA: 0x7FFAF490E3C0
        public void Dispose(){} // RVA: 0x7FFAF490E470
        public void GetDefaultPresenceScopes(){} // RVA: 0x7FFAF490E540
        public void Authorize(){} // RVA: 0x7FFAF490E650
        public void UpdateToken(){} // RVA: 0x7FFAF490E8D0
        public void AddLogCallback(){} // RVA: 0x7FFAF490EC40
        public void Connect(){} // RVA: 0x7FFAF490EEB0
        public void Disconnect(){} // RVA: 0x7FFAF490EF80
        public void SetApplicationId(){} // RVA: 0x7FFAF490F050
        public void SetStatusChangedCallback(){} // RVA: 0x7FFAF490F130
        public void ClearRichPresence(){} // RVA: 0x7FFAF490F380
        public void SendActivityInvite(){} // RVA: 0x7FFAF490F450
        public void SetActivityJoinCallback(){} // RVA: 0x7FFAF490F7C0
        public void UpdateRichPresence(){} // RVA: 0x7FFAF490FA10
        public void GetRelationships(){} // RVA: 0x7FFAF490FC90
        public void SetUserUpdatedCallback(){} // RVA: 0x7FFAF490FF70
    }

    public class ClientResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4419380
        public void Finalize(){} // RVA: 0x7FFAF490CE80
        public void Dispose(){} // RVA: 0x7FFAF490CF80
        public void ToString(){} // RVA: 0x7FFAF490D050
        public void Type(){} // RVA: 0x7FFAF490D1C0
        public void Error(){} // RVA: 0x7FFAF490D290
        public void ErrorCode(){} // RVA: 0x7FFAF490D400
        public void Successful(){} // RVA: 0x7FFAF490D4D0
    }

    public class NativeMethods
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF4906A20
        public void __Init(){} // RVA: 0x7FFAF2D8D310
        public void __ReportUnhandledException(){} // RVA: 0x7FFAF4906E60
        public void __OnPostConstruct(){} // RVA: 0x7FFAF2D8D310
        public void __InitStringLocal(){} // RVA: 0x7FFAF4906F10
        public void __InitNullableStringLocal(){} // RVA: 0x7FFAF4907100
        public void __FreeLocalString(){} // RVA: 0x7FFAF49071B0
        public void Discord_Free(){} // RVA: 0x7FFAF4907220
        public void Discord_RunCallbacks(){} // RVA: 0x7FFAF49072A0
        public void Discord_ResetCallbacks(){} // RVA: 0x7FFAF4907310
    }

    public class RelationshipHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4419380
        public void Finalize(){} // RVA: 0x7FFAF490DAD0
        public void Dispose(){} // RVA: 0x7FFAF490DBD0
        public void DiscordRelationshipType(){} // RVA: 0x7FFAF490DCA0
        public void User(){} // RVA: 0x7FFAF490DD70
    }

    public class UserHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4419380
        public void Finalize(){} // RVA: 0x7FFAF490DEA0
        public void Dispose(){} // RVA: 0x7FFAF490DFA0
        public void DisplayName(){} // RVA: 0x7FFAF490E070
        public void Id(){} // RVA: 0x7FFAF490E1E0
        public void Status(){} // RVA: 0x7FFAF490E2B0
    }

}