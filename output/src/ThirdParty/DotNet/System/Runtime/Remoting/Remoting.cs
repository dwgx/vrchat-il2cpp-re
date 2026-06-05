// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting
// Classes: 28
// Methods: 216

namespace ThirdParty.DotNet.System.Runtime.Remoting
{
    public class ActivatedClientTypeEntry
    {
        public object AssemblyName;
        public object TypeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF877BBA0
        public void get_ApplicationUrl(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ContextAttributes(){} // RVA: 0x7FFAF2FC9240
        public void get_ObjectType(){} // RVA: 0x7FFAF2DBB130
        public void ToString(){} // RVA: 0x7FFAF877BE40
    }

    public class ActivatedServiceTypeEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF877BE60
        public void get_ObjectType(){} // RVA: 0x7FFAF2DBB0C0
        public void ToString(){} // RVA: 0x7FFAF877C0B0
    }

    public class ChannelData
    {
        // ── Methods ──
        public void get_ServerProviders(){} // RVA: 0x7FFAF8785C30
        public void get_ClientProviders(){} // RVA: 0x7FFAF8785CE0
        public void get_CustomProperties(){} // RVA: 0x7FFAF8785D90
        public void CopyFrom(){} // RVA: 0x7FFAF8785E40
        public void .ctor(){} // RVA: 0x7FFAF87867A0
    }

    public class ChannelInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF877BAB0 | overloaded x2
        public void get_ChannelData(){} // RVA: 0x7FFAF2DA8380
    }

    public class ClientActivatedIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF878CEE0
        public void GetServerObject(){} // RVA: 0x7FFAF2E2E0E0
        public void SetClientProxy(){} // RVA: 0x7FFAF2E555A0
        public void OnLifetimeExpired(){} // RVA: 0x7FFAF878CF00
        public void SyncObjectProcessMessage(){} // RVA: 0x7FFAF878CF90
        public void AsyncObjectProcessMessage(){} // RVA: 0x7FFAF878D070
    }

    public class ClientIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF877C300
        public void get_ClientProxy(){} // RVA: 0x7FFAF877C4B0
        public void set_ClientProxy(){} // RVA: 0x7FFAF877C540
        public void CreateObjRef(){} // RVA: 0x7FFAF2F476A0
        public void get_TargetUri(){} // RVA: 0x7FFAF877C600
    }

    public class ConfigHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8781790
        public void ValidatePath(){} // RVA: 0x7FFAF8781950
        public void CheckPath(){} // RVA: 0x7FFAF8781A40
        public void OnStartParsing(){} // RVA: 0x7FFAF2D8D310
        public void OnProcessingInstruction(){} // RVA: 0x7FFAF2D8D310
        public void OnIgnorableWhitespace(){} // RVA: 0x7FFAF2D8D310
        public void OnStartElement(){} // RVA: 0x7FFAF8781BE0
        public void ParseElement(){} // RVA: 0x7FFAF8781D80
        public void OnEndElement(){} // RVA: 0x7FFAF8783160
        public void ReadCustomProviderData(){} // RVA: 0x7FFAF87832B0
        public void ReadLifetine(){} // RVA: 0x7FFAF87836B0
        public void ParseTime(){} // RVA: 0x7FFAF8783B70
        public void ReadChannel(){} // RVA: 0x7FFAF8784020
        public void ReadProvider(){} // RVA: 0x7FFAF87847D0
        public void ReadClientActivated(){} // RVA: 0x7FFAF8784DD0
        public void ReadServiceActivated(){} // RVA: 0x7FFAF8784F60
        public void ReadClientWellKnown(){} // RVA: 0x7FFAF8785040
        public void ReadServiceWellKnown(){} // RVA: 0x7FFAF8785150
        public void ReadInteropXml(){} // RVA: 0x7FFAF87853B0
        public void ReadPreload(){} // RVA: 0x7FFAF87855D0
        public void GetNotNull(){} // RVA: 0x7FFAF8785870
        public void ExtractAssembly(){} // RVA: 0x7FFAF8785980
        public void OnChars(){} // RVA: 0x7FFAF2D8D310
        public void OnEndParsing(){} // RVA: 0x7FFAF8785AD0
    }

    public class DisposerReplySink
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void SyncProcessMessage(){} // RVA: 0x7FFAF878D7B0
        public void AsyncProcessMessage(){} // RVA: 0x7FFAF878D840
    }

    public class EnvoyInfo : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_EnvoySinks(){} // RVA: 0x7FFAF2DA8380
    }

    public class FormatterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8787160
    }

    public class IChannelInfo
    {
        // ── Methods ──
        public void get_ChannelData(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IEnvoyInfo
    {
        // ── Methods ──
        public void get_EnvoySinks(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IRemotingTypeInfo
    {
        // ── Methods ──
        public void get_TypeName(){} // RVA: 0x7FFAF2ABCD60
        public void CanCastTo(){} // RVA: 0x7FFAF2AC1120
    }

    public class Identity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void CreateObjRef(){} // RVA: 0x7FFAF2ABCE10
        public void get_ChannelSink(){} // RVA: 0x7FFAF2D907C0
        public void set_ChannelSink(){} // RVA: 0x7FFAF2DF3E80
        public void get_EnvoySink(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ObjectUri(){} // RVA: 0x7FFAF2DA8380
        public void set_ObjectUri(){} // RVA: 0x7FFAF2D8EE30
        public void get_IsConnected(){} // RVA: 0x7FFAF39B1170
        public void get_Disposed(){} // RVA: 0x7FFAF2E48C00
        public void set_Disposed(){} // RVA: 0x7FFAF2E48C10
        public void get_ClientDynamicProperties(){} // RVA: 0x7FFAF877C0C0
        public void get_HasServerDynamicSinks(){} // RVA: 0x7FFAF877C170
        public void NotifyClientDynamicSinks(){} // RVA: 0x7FFAF877C1C0
        public void NotifyServerDynamicSinks(){} // RVA: 0x7FFAF877C260
    }

    public class InternalRemotingServices
    {
        // ── Methods ──
        public void GetCachedSoapAttribute(){} // RVA: 0x7FFAF877C630
        public void .cctor(){} // RVA: 0x7FFAF877CC20
    }

    public class ObjRef
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF877D2D0 | overloaded x4
        public void DeserializeInTheCurrentDomain(){} // RVA: 0x7FFAF877CDB0
        public void SerializeType(){} // RVA: 0x7FFAF877D060
        public void get_IsReferenceToWellKnow(){} // RVA: 0x7FFAF877DBD0
        public void get_ChannelInfo(){} // RVA: 0x7FFAF2DA8380
        public void get_EnvoyInfo(){} // RVA: 0x7FFAF2DBB130
        public void set_EnvoyInfo(){} // RVA: 0x7FFAF2D8EE90
        public void get_TypeInfo(){} // RVA: 0x7FFAF2DBB0C0
        public void set_TypeInfo(){} // RVA: 0x7FFAF2DBB0D0
        public void get_URI(){} // RVA: 0x7FFAF2D907C0
        public void set_URI(){} // RVA: 0x7FFAF2DF3E80
        public void GetObjectData(){} // RVA: 0x7FFAF877DC30
        public void GetRealObject(){} // RVA: 0x7FFAF877E2A0
        public void UpdateChannelInfo(){} // RVA: 0x7FFAF877E380
        public void get_ServerType(){} // RVA: 0x7FFAF877E4C0
        public void .cctor(){} // RVA: 0x7FFAF877E5F0
    }

    public class ProviderData
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x7FFAF8786950
        public void .ctor(){} // RVA: 0x7FFAF87870B0
    }

    public class RemotingConfiguration
    {
        // ── Methods ──
        public void get_ApplicationName(){} // RVA: 0x7FFAF877E650
        public void set_ApplicationName(){} // RVA: 0x7FFAF877E6B0
        public void get_ProcessId(){} // RVA: 0x7FFAF877E770
        public void LoadDefaultDelayedChannels(){} // RVA: 0x7FFAF877E8F0
        public void IsActivationAllowed(){} // RVA: 0x7FFAF877EE00
        public void IsRemotelyActivatedClientType(){} // RVA: 0x7FFAF877F000
        public void IsWellKnownClientType(){} // RVA: 0x7FFAF877F250
        public void RegisterActivatedClientType(){} // RVA: 0x7FFAF877F4A0
        public void RegisterActivatedServiceType(){} // RVA: 0x7FFAF877F7C0
        public void RegisterWellKnownClientType(){} // RVA: 0x7FFAF877F9A0
        public void RegisterWellKnownServiceType(){} // RVA: 0x7FFAF877FCC0
        public void RegisterChannelTemplate(){} // RVA: 0x7FFAF877FEF0
        public void RegisterClientProviderTemplate(){} // RVA: 0x7FFAF877FF80
        public void RegisterServerProviderTemplate(){} // RVA: 0x7FFAF8780010
        public void RegisterChannels(){} // RVA: 0x7FFAF87800A0
        public void RegisterTypes(){} // RVA: 0x7FFAF8780990
        public void CustomErrorsEnabled(){} // RVA: 0x7FFAF8780E40
        public void SetCustomErrorsMode(){} // RVA: 0x7FFAF8780ED0
        public void .cctor(){} // RVA: 0x7FFAF87811C0
    }

    public class RemotingException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE250 | overloaded x4
    }

    public class RemotingServices
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8787170
        public void InternalExecute(){} // RVA: 0x7FFAF87878E0
        public void GetVirtualMethod(){} // RVA: 0x7FFAF87878F0
        public void IsTransparentProxy(){} // RVA: 0x7FFAF8787900
        public void InternalExecuteMessage(){} // RVA: 0x7FFAF8787940
        public void Connect(){} // RVA: 0x7FFAF8787D70 | overloaded x2
        public void GetServerTypeForUri(){} // RVA: 0x7FFAF8787E20
        public void Unmarshal(){} // RVA: 0x7FFAF8787F40 | overloaded x2
        public void Marshal(){} // RVA: 0x7FFAF8788380 | overloaded x2
        public void NewUri(){} // RVA: 0x7FFAF8788400
        public void GetRealProxy(){} // RVA: 0x7FFAF8788980
        public void GetMethodBaseFromMethodMessage(){} // RVA: 0x7FFAF87889D0
        public void GetMethodBaseFromName(){} // RVA: 0x7FFAF8788BE0
        public void FindInterfaceMethod(){} // RVA: 0x7FFAF8788F10
        public void GetObjectData(){} // RVA: 0x7FFAF8789130
        public void IsOneWay(){} // RVA: 0x7FFAF87891E0
        public void CreateClientProxy(){} // RVA: 0x7FFAF8789620 | overloaded x3
        public void CreateClientProxyForContextBound(){} // RVA: 0x7FFAF8789710
        public void GetIdentityForUri(){} // RVA: 0x7FFAF87898E0
        public void RemoveAppNameFromUri(){} // RVA: 0x7FFAF8789D20
        public void GetOrCreateClientIdentity(){} // RVA: 0x7FFAF8789E30
        public void GetClientChannelSinkChain(){} // RVA: 0x7FFAF878A850
        public void CreateContextBoundObjectIdentity(){} // RVA: 0x7FFAF878A980
        public void CreateClientActivatedServerIdentity(){} // RVA: 0x7FFAF878AAB0
        public void CreateWellKnownServerIdentity(){} // RVA: 0x7FFAF878AB60
        public void RegisterServerIdentity(){} // RVA: 0x7FFAF878ACB0
        public void GetProxyForRemoteObject(){} // RVA: 0x7FFAF878AF70
        public void GetRemoteObject(){} // RVA: 0x7FFAF878B090
        public void SerializeCallData(){} // RVA: 0x7FFAF878B110
        public void DeserializeCallData(){} // RVA: 0x7FFAF878B590
        public void SerializeExceptionData(){} // RVA: 0x7FFAF878B900
        public void RegisterInternalChannels(){} // RVA: 0x7FFAF878BC00
        public void DisposeIdentity(){} // RVA: 0x7FFAF878BC50
        public void GetMessageTargetIdentity(){} // RVA: 0x7FFAF878BF70
        public void SetMessageTargetIdentity(){} // RVA: 0x7FFAF878C390
        public void UpdateOutArgObject(){} // RVA: 0x7FFAF878C450
        public void GetNormalizedUri(){} // RVA: 0x7FFAF878C670
    }

    public class ServerIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF878C6E0
        public void get_ObjectType(){} // RVA: 0x7FFAF2E08730
        public void StartTrackingLifetime(){} // RVA: 0x7FFAF878C800
        public void OnLifetimeExpired(){} // RVA: 0x7FFAF878CB90
        public void CreateObjRef(){} // RVA: 0x7FFAF878CBF0
        public void AttachServerObject(){} // RVA: 0x7FFAF878CE70
        public void get_Lease(){} // RVA: 0x7FFAF2E08D50
        public void get_Context(){} // RVA: 0x7FFAF2E2B370
        public void set_Context(){} // RVA: 0x7FFAF2E2B380
        public void SyncObjectProcessMessage(){} // RVA: 0x7FFAF2ABCE10
        public void AsyncObjectProcessMessage(){} // RVA: 0x7FFAF2ACE6A0
        public void DisposeServerObject(){} // RVA: 0x7FFAF878CB90
    }

    public class SingleCallIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF878D160
        public void SyncObjectProcessMessage(){} // RVA: 0x7FFAF878D510
        public void AsyncObjectProcessMessage(){} // RVA: 0x7FFAF878D580
    }

    public class SingletonIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF878D160
        public void GetServerObject(){} // RVA: 0x7FFAF878D170
        public void SyncObjectProcessMessage(){} // RVA: 0x7FFAF878D350
        public void AsyncObjectProcessMessage(){} // RVA: 0x7FFAF878D420
    }

    public class SoapServices
    {
        public object TypeName;

        // ── Methods ──
        public void get_XmlNsForClrTypeWithAssembly(){} // RVA: 0x7FFAF878D880
        public void get_XmlNsForClrTypeWithNs(){} // RVA: 0x7FFAF878D8C0
        public void get_XmlNsForClrTypeWithNsAndAssembly(){} // RVA: 0x7FFAF878D900
        public void CodeXmlNamespaceForClrTypeNamespace(){} // RVA: 0x7FFAF878D940
        public void GetNameKey(){} // RVA: 0x7FFAF878DB50
        public void GetAssemblyName(){} // RVA: 0x7FFAF878DBC0
        public void GetXmlElementForInteropType(){} // RVA: 0x7FFAF878DDC0
        public void GetXmlNamespaceForMethodCall(){} // RVA: 0x7FFAF878DFE0
        public void GetXmlNamespaceForMethodResponse(){} // RVA: 0x7FFAF878E090
        public void GetXmlTypeForInteropType(){} // RVA: 0x7FFAF878E140
        public void PreLoad(){} // RVA: 0x7FFAF878E410 | overloaded x2
        public void RegisterInteropXmlElement(){} // RVA: 0x7FFAF878EA10
        public void RegisterInteropXmlType(){} // RVA: 0x7FFAF878EC50
        public void EncodeNs(){} // RVA: 0x7FFAF878EE90
        public void .cctor(){} // RVA: 0x7FFAF878EF80
    }

    public class TypeEntry
    {
        public object ObjectType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_AssemblyName(){} // RVA: 0x7FFAF2DA8380
        public void set_AssemblyName(){} // RVA: 0x7FFAF2D8EE30
        public void get_TypeName(){} // RVA: 0x7FFAF2D907C0
        public void set_TypeName(){} // RVA: 0x7FFAF2DF3E80
    }

    public class TypeInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF878F2B0
        public void get_TypeName(){} // RVA: 0x7FFAF2DA8380
        public void CanCastTo(){} // RVA: 0x7FFAF878F9B0
    }

    public class WellKnownClientTypeEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF878FC60
        public void get_ApplicationUrl(){} // RVA: 0x7FFAF30E74D0
        public void get_ObjectType(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ObjectUrl(){} // RVA: 0x7FFAF2DBB130
        public void ToString(){} // RVA: 0x7FFAF878FF00
    }

    public class WellKnownServiceTypeEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF878FF40
        public void get_Mode(){} // RVA: 0x7FFAF2DE8CD0
        public void get_ObjectType(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ObjectUri(){} // RVA: 0x7FFAF2DBB130
        public void ToString(){} // RVA: 0x7FFAF87901F0
    }

}