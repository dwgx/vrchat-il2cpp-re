// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Discord.Discord.Sdk
// Classes: 11
// Methods: 88

namespace ThirdParty.Discord.Discord.Sdk
{
    public class Activity : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFE82BE5680
        public void .ctor(){} // RVA: 0x7FFE82BE5780
        public void Dispose(){} // RVA: 0x7FFE82BE5830
        public void SetState(){} // RVA: 0x7FFE82BE5900
        public void Assets(){} // RVA: 0x7FFE82BE5B20
        public void SetAssets(){} // RVA: 0x7FFE82BE5C50
        public void Timestamps(){} // RVA: 0x7FFE82BE5D70
        public void SetTimestamps(){} // RVA: 0x7FFE82BE5EA0
        public void Party(){} // RVA: 0x7FFE82BE5FC0
        public void SetParty(){} // RVA: 0x7FFE82BE60F0
        public void Secrets(){} // RVA: 0x7FFE82BE6210
        public void SetSecrets(){} // RVA: 0x7FFE82BE6340
    }

    public class ActivityAssets : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BE3EC0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE82BE3DC0
        public void Dispose(){} // RVA: 0x7FFE82BE3F70
        public void SetLargeImage(){} // RVA: 0x7FFE82BE4040
        public void SetLargeText(){} // RVA: 0x7FFE82BE4260
        public void SetSmallImage(){} // RVA: 0x7FFE82BE4480
        public void SetSmallText(){} // RVA: 0x7FFE82BE46A0
    }

    public class ActivityParty : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BE4D20 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE82BE4C20
        public void Dispose(){} // RVA: 0x7FFE82BE4DD0
        public void SetId(){} // RVA: 0x7FFE82BE4EA0
        public void SetCurrentSize(){} // RVA: 0x7FFE82BE5070
        public void SetMaxSize(){} // RVA: 0x7FFE82BE5150
    }

    public class ActivitySecrets : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BE5330 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE82BE5230
        public void Dispose(){} // RVA: 0x7FFE82BE53E0
        public void SetJoin(){} // RVA: 0x7FFE82BE54B0
    }

    public class ActivityTimestamps : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BE49C0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE82BE48C0
        public void Dispose(){} // RVA: 0x7FFE82BE4A70
        public void SetStart(){} // RVA: 0x7FFE82BE4B40
    }

    public class AuthorizationArgs : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFE82BE6B80
        public void .ctor(){} // RVA: 0x7FFE82BE6C80
        public void Dispose(){} // RVA: 0x7FFE82BE6D30
        public void SetClientId(){} // RVA: 0x7FFE82BE6E00
        public void SetScopes(){} // RVA: 0x7FFE82BE6EE0
    }

    public class Client : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFE82BE7960
        public void .ctor(){} // RVA: 0x7FFE82BE79A0
        public void Dispose(){} // RVA: 0x7FFE82BE7A50
        public void GetDefaultPresenceScopes(){} // RVA: 0x7FFE82BE7B20
        public void Authorize(){} // RVA: 0x7FFE82BE7C30
        public void UpdateToken(){} // RVA: 0x7FFE82BE7EB0
        public void AddLogCallback(){} // RVA: 0x7FFE82BE8220
        public void Connect(){} // RVA: 0x7FFE82BE8490
        public void Disconnect(){} // RVA: 0x7FFE82BE8560
        public void SetApplicationId(){} // RVA: 0x7FFE82BE8630
        public void SetStatusChangedCallback(){} // RVA: 0x7FFE82BE8710
        public void ClearRichPresence(){} // RVA: 0x7FFE82BE8960
        public void SendActivityInvite(){} // RVA: 0x7FFE82BE8A30
        public void SetActivityJoinCallback(){} // RVA: 0x7FFE82BE8DA0
        public void UpdateRichPresence(){} // RVA: 0x7FFE82BE8FF0
        public void GetRelationships(){} // RVA: 0x7FFE82BE9270
        public void SetUserUpdatedCallback(){} // RVA: 0x7FFE82BE9550
    }

    public class ClientResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE826F4900
        public void Finalize(){} // RVA: 0x7FFE82BE6460
        public void Dispose(){} // RVA: 0x7FFE82BE6560
        public void ToString(){} // RVA: 0x7FFE82BE6630
        public void Type(){} // RVA: 0x7FFE82BE67A0
        public void Error(){} // RVA: 0x7FFE82BE6870
        public void ErrorCode(){} // RVA: 0x7FFE82BE69E0
        public void Successful(){} // RVA: 0x7FFE82BE6AB0
    }

    public class NativeMethods : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE82BE0000
        public void __Init(){} // RVA: 0x7FFE810FB310
        public void __ReportUnhandledException(){} // RVA: 0x7FFE82BE0440
        public void __OnPostConstruct(){} // RVA: 0x7FFE810FB310
        public void __InitStringLocal(){} // RVA: 0x7FFE82BE04F0
        public void __InitNullableStringLocal(){} // RVA: 0x7FFE82BE06E0
        public void __FreeLocalString(){} // RVA: 0x7FFE82BE0790
        public void Discord_Free(){} // RVA: 0x7FFE82BE0800
        public void Discord_RunCallbacks(){} // RVA: 0x7FFE82BE0880
        public void Discord_ResetCallbacks(){} // RVA: 0x7FFE82BE08F0
    }

    public class RelationshipHandle : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE826F4900
        public void Finalize(){} // RVA: 0x7FFE82BE70B0
        public void Dispose(){} // RVA: 0x7FFE82BE71B0
        public void DiscordRelationshipType(){} // RVA: 0x7FFE82BE7280
        public void User(){} // RVA: 0x7FFE82BE7350
    }

    public class UserHandle : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE826F4900
        public void Finalize(){} // RVA: 0x7FFE82BE7480
        public void Dispose(){} // RVA: 0x7FFE82BE7580
        public void DisplayName(){} // RVA: 0x7FFE82BE7650
        public void Id(){} // RVA: 0x7FFE82BE77C0
        public void Status(){} // RVA: 0x7FFE82BE7890
    }

}