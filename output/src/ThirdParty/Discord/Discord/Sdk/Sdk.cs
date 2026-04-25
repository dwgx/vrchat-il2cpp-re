// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Discord.Discord.Sdk
// Classes: 11
// Methods: 88

namespace ThirdParty.Discord.Discord.Sdk
{
    public class Activity : Object
    {
        public Activity self; // 0x10
        public int disposed_; // 0x18

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFAC4979B80
        public void .ctor(){} // RVA: 0x7FFAC4979C80
        public void Dispose(){} // RVA: 0x7FFAC4979D30
        public void SetState(){} // RVA: 0x7FFAC4979E00
        public void Assets(){} // RVA: 0x7FFAC497A020
        public void SetAssets(){} // RVA: 0x7FFAC497A150
        public void Timestamps(){} // RVA: 0x7FFAC497A270
        public void SetTimestamps(){} // RVA: 0x7FFAC497A3A0
        public void Party(){} // RVA: 0x7FFAC497A4C0
        public void SetParty(){} // RVA: 0x7FFAC497A5F0
        public void Secrets(){} // RVA: 0x7FFAC497A710
        public void SetSecrets(){} // RVA: 0x7FFAC497A840
    }

    public class ActivityAssets : Object
    {
        public ActivityAssets self; // 0x10
        public int disposed_; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC49783C0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC49782C0
        public void Dispose(){} // RVA: 0x7FFAC4978470
        public void SetLargeImage(){} // RVA: 0x7FFAC4978540
        public void SetLargeText(){} // RVA: 0x7FFAC4978760
        public void SetSmallImage(){} // RVA: 0x7FFAC4978980
        public void SetSmallText(){} // RVA: 0x7FFAC4978BA0
    }

    public class ActivityParty : Object
    {
        public ActivityParty self; // 0x10
        public int disposed_; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4979220 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC4979120
        public void Dispose(){} // RVA: 0x7FFAC49792D0
        public void SetId(){} // RVA: 0x7FFAC49793A0
        public void SetCurrentSize(){} // RVA: 0x7FFAC4979570
        public void SetMaxSize(){} // RVA: 0x7FFAC4979650
    }

    public class ActivitySecrets : Object
    {
        public ActivitySecrets self; // 0x10
        public int disposed_; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4979830 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC4979730
        public void Dispose(){} // RVA: 0x7FFAC49798E0
        public void SetJoin(){} // RVA: 0x7FFAC49799B0
    }

    public class ActivityTimestamps : Object
    {
        public ActivityTimestamps self; // 0x10
        public int disposed_; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4978EC0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC4978DC0
        public void Dispose(){} // RVA: 0x7FFAC4978F70
        public void SetStart(){} // RVA: 0x7FFAC4979040
    }

    public class AuthorizationArgs : Object
    {
        public AuthorizationArgs self; // 0x10
        public int disposed_; // 0x18

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFAC497B080
        public void .ctor(){} // RVA: 0x7FFAC497B180
        public void Dispose(){} // RVA: 0x7FFAC497B230
        public void SetClientId(){} // RVA: 0x7FFAC497B300
        public void SetScopes(){} // RVA: 0x7FFAC497B3E0
    }

    public class Client : Object
    {
        public Client self; // 0x10
        public int disposed_; // 0x18

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFAC497BE60
        public void .ctor(){} // RVA: 0x7FFAC497BEA0
        public void Dispose(){} // RVA: 0x7FFAC497BF50
        public void GetDefaultPresenceScopes(){} // RVA: 0x7FFAC497C020
        public void Authorize(){} // RVA: 0x7FFAC497C130
        public void UpdateToken(){} // RVA: 0x7FFAC497C3B0
        public void AddLogCallback(){} // RVA: 0x7FFAC497C720
        public void Connect(){} // RVA: 0x7FFAC497C990
        public void Disconnect(){} // RVA: 0x7FFAC497CA60
        public void SetApplicationId(){} // RVA: 0x7FFAC497CB30
        public void SetStatusChangedCallback(){} // RVA: 0x7FFAC497CC10
        public void ClearRichPresence(){} // RVA: 0x7FFAC497CE60
        public void SendActivityInvite(){} // RVA: 0x7FFAC497CF30
        public void SetActivityJoinCallback(){} // RVA: 0x7FFAC497D2A0
        public void UpdateRichPresence(){} // RVA: 0x7FFAC497D4F0
        public void GetRelationships(){} // RVA: 0x7FFAC497D770
        public void SetUserUpdatedCallback(){} // RVA: 0x7FFAC497DA50
    }

    public class ClientResult : Object
    {
        public ClientResult self; // 0x10
        public int disposed_; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4420710
        public void Finalize(){} // RVA: 0x7FFAC497A960
        public void Dispose(){} // RVA: 0x7FFAC497AA60
        public void ToString(){} // RVA: 0x7FFAC497AB30
        public void Type(){} // RVA: 0x7FFAC497ACA0
        public void Error(){} // RVA: 0x7FFAC497AD70
        public void ErrorCode(){} // RVA: 0x7FFAC497AEE0
        public void Successful(){} // RVA: 0x7FFAC497AFB0
    }

    public class NativeMethods : Object
    {
        public System.Action`1<System.Exception> UnhandledException;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC4974500
        public void __Init(){} // RVA: 0x7FFAC2F21310
        public void __ReportUnhandledException(){} // RVA: 0x7FFAC4974940
        public void __OnPostConstruct(){} // RVA: 0x7FFAC2F21310
        public void __InitStringLocal(){} // RVA: 0x7FFAC49749F0
        public void __InitNullableStringLocal(){} // RVA: 0x7FFAC4974BE0
        public void __FreeLocalString(){} // RVA: 0x7FFAC4974C90
        public void Discord_Free(){} // RVA: 0x7FFAC4974D00
        public void Discord_RunCallbacks(){} // RVA: 0x7FFAC4974D80
        public void Discord_ResetCallbacks(){} // RVA: 0x7FFAC4974DF0
    }

    public class RelationshipHandle : Object
    {
        public RelationshipHandle self; // 0x10
        public int disposed_; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4420710
        public void Finalize(){} // RVA: 0x7FFAC497B5B0
        public void Dispose(){} // RVA: 0x7FFAC497B6B0
        public void DiscordRelationshipType(){} // RVA: 0x7FFAC497B780
        public void User(){} // RVA: 0x7FFAC497B850
    }

    public class UserHandle : Object
    {
        public UserHandle self; // 0x10
        public int disposed_; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4420710
        public void Finalize(){} // RVA: 0x7FFAC497B980
        public void Dispose(){} // RVA: 0x7FFAC497BA80
        public void DisplayName(){} // RVA: 0x7FFAC497BB50
        public void Id(){} // RVA: 0x7FFAC497BCC0
        public void Status(){} // RVA: 0x7FFAC497BD90
    }

}