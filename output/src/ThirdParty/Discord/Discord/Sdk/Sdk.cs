// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Discord.Discord.Sdk
// Classes: 12
// Methods: 99

namespace ThirdParty.Discord.Discord.Sdk
{
    public class Activity : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7A9C60980
        public void .ctor(){} // RVA: 0x7A9C60A80
        public void Dispose(){} // RVA: 0x7A9C60B30
        public void SetState(){} // RVA: 0x7A9C60C00
        public void Assets(){} // RVA: 0x7A9C60E30
        public void SetAssets(){} // RVA: 0x7A9C60F60
        public void Timestamps(){} // RVA: 0x7A9C61080
        public void SetTimestamps(){} // RVA: 0x7A9C611B0
        public void Party(){} // RVA: 0x7A9C612D0
        public void SetParty(){} // RVA: 0x7A9C61400
        public void Secrets(){} // RVA: 0x7A9C61520
        public void SetSecrets(){} // RVA: 0x7A9C61650
    }

    public class ActivityAssets : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9C5F180
        public void Finalize(){} // RVA: 0x7A9C5F080
        public void Dispose(){} // RVA: 0x7A9C5F230
        public void SetLargeImage(){} // RVA: 0x7A9C5F300
        public void SetLargeText(){} // RVA: 0x7A9C5F530
        public void SetSmallImage(){} // RVA: 0x7A9C5F760
        public void SetSmallText(){} // RVA: 0x7A9C5F990
    }

    public class ActivityParty : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9C60020
        public void Finalize(){} // RVA: 0x7A9C5FF20
        public void Dispose(){} // RVA: 0x7A9C600D0
        public void SetId(){} // RVA: 0x7A9C601A0
        public void SetCurrentSize(){} // RVA: 0x7A9C60370
        public void SetMaxSize(){} // RVA: 0x7A9C60450
    }

    public class ActivitySecrets : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9C60630
        public void Finalize(){} // RVA: 0x7A9C60530
        public void Dispose(){} // RVA: 0x7A9C606E0
        public void SetJoin(){} // RVA: 0x7A9C607B0
    }

    public class ActivityTimestamps : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9C5FCC0
        public void Finalize(){} // RVA: 0x7A9C5FBC0
        public void Dispose(){} // RVA: 0x7A9C5FD70
        public void SetStart(){} // RVA: 0x7A9C5FE40
    }

    public class AuthorizationArgs : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7A9C61E90
        public void .ctor(){} // RVA: 0x7A9C61F90
        public void Dispose(){} // RVA: 0x7A9C62040
        public void SetClientId(){} // RVA: 0x7A9C62110
        public void SetScopes(){} // RVA: 0x7A9C621F0
    }

    public class Client : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7A9C62C70
        public void .ctor(){} // RVA: 0x7A9C62CB0
        public void Dispose(){} // RVA: 0x7A9C62D60
        public void GetDefaultPresenceScopes(){} // RVA: 0x7A9C62E30
        public void Authorize(){} // RVA: 0x7A9C62F40
        public void UpdateToken(){} // RVA: 0x7A9C631D0
        public void AddLogCallback(){} // RVA: 0x7A9C63530
        public void Connect(){} // RVA: 0x7A9C63790
        public void Disconnect(){} // RVA: 0x7A9C63860
        public void SetApplicationId(){} // RVA: 0x7A9C63930
        public void SetStatusChangedCallback(){} // RVA: 0x7A9C63A10
        public void ClearRichPresence(){} // RVA: 0x7A9C63C50
        public void SendActivityInvite(){} // RVA: 0x7A9C63D20
        public void SetActivityJoinCallback(){} // RVA: 0x7A9C64080
        public void UpdateRichPresence(){} // RVA: 0x7A9C642C0
        public void GetRelationships(){} // RVA: 0x7A9C64550
        public void SetUserUpdatedCallback(){} // RVA: 0x7A9C64830
    }

    public class ClientResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9725F90
        public void Finalize(){} // RVA: 0x7A9C61770
        public void Dispose(){} // RVA: 0x7A9C61870
        public void ToString(){} // RVA: 0x7A9C61940
        public void Type(){} // RVA: 0x7A9C61AB0
        public void Error(){} // RVA: 0x7A9C61B80
        public void ErrorCode(){} // RVA: 0x7A9C61CF0
        public void Successful(){} // RVA: 0x7A9C61DC0
    }

    public class NativeMethods : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A9C5B2B0
        public void __Init(){} // RVA: 0x7A80D7310
        public void __ReportUnhandledException(){} // RVA: 0x7A9C5B700
        public void __OnPostConstruct(){} // RVA: 0x7A80D7310
        public void __InitStringLocal(){} // RVA: 0x7A9C5B7B0
        public void __InitNullableStringLocal(){} // RVA: 0x7A9C5B9A0
        public void __FreeLocalString(){} // RVA: 0x7A9C5BA50
        public void Discord_Free(){} // RVA: 0x7A9C5BAC0
        public void Discord_RunCallbacks(){} // RVA: 0x7A9C5BB40
        public void Discord_ResetCallbacks(){} // RVA: 0x7A9C5BBB0
    }

    public class RelationshipHandle : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9725F90
        public void Finalize(){} // RVA: 0x7A9C623C0
        public void Dispose(){} // RVA: 0x7A9C624C0
        public void DiscordRelationshipType(){} // RVA: 0x7A9C62590
        public void User(){} // RVA: 0x7A9C62660
    }

    public class UserHandle : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9725F90
        public void Finalize(){} // RVA: 0x7A9C62790
        public void Dispose(){} // RVA: 0x7A9C62890
        public void DisplayName(){} // RVA: 0x7A9C62960
        public void Id(){} // RVA: 0x7A9C62AD0
        public void Status(){} // RVA: 0x7A9C62BA0
    }

    public class UserHandle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

}