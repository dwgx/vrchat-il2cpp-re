// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting
// Classes: 28
// Methods: 216

namespace ThirdParty.DotNet.System.Runtime.Remoting
{
    public class ActivatedClientTypeEntry : TypeEntry
    {
        public string applicationUrl; // 0x20
        public System.Type obj_type; // 0x28
        public object field_2; // 0x3DC

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8680CAA0
        public void get_ApplicationUrl(){} // RVA: 0x7FFE811290C0
        public void get_ContextAttributes(){} // RVA: 0x7FFE813240E0
        public void get_ObjectType(){} // RVA: 0x7FFE81129130
        public void ToString(){} // RVA: 0x7FFE8680CD40
    }

    public class ActivatedServiceTypeEntry : TypeEntry
    {
        public System.Type obj_type; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8680CD60
        public void get_ObjectType(){} // RVA: 0x7FFE811290C0
        public void ToString(){} // RVA: 0x7FFE8680CFB0
    }

    public class ChannelData : Object
    {
        public string Ref; // 0x10
        public string Type; // 0x18
        public string Id; // 0x20

        // ── Methods ──
        public void get_ServerProviders(){} // RVA: 0x7FFE86816B30
        public void get_ClientProviders(){} // RVA: 0x7FFE86816BE0
        public void get_CustomProperties(){} // RVA: 0x7FFE86816C90
        public void CopyFrom(){} // RVA: 0x7FFE86816D40
        public void .ctor(){} // RVA: 0x7FFE868176A0
    }

    public class ChannelInfo : Object
    {
        public object[] channelData; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8680C9B0 | overloaded x2
        public void get_ChannelData(){} // RVA: 0x7FFE81116380
    }

    public class ClientActivatedIdentity : ServerIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8681DDE0
        public void GetServerObject(){} // RVA: 0x7FFE8119C0E0
        public void SetClientProxy(){} // RVA: 0x7FFE811C35A0
        public void OnLifetimeExpired(){} // RVA: 0x7FFE8681DE00
        public void SyncObjectProcessMessage(){} // RVA: 0x7FFE8681DE90
        public void AsyncObjectProcessMessage(){} // RVA: 0x7FFE8681DF70
    }

    public class ClientIdentity : Identity
    {
        public System.WeakReference _proxyReference; // 0x48
        public object field_1; // 0x3EB

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8680D200
        public void get_ClientProxy(){} // RVA: 0x7FFE8680D3B0
        public void set_ClientProxy(){} // RVA: 0x7FFE8680D440
        public void CreateObjRef(){} // RVA: 0x7FFE8143BA80
        public void get_TargetUri(){} // RVA: 0x7FFE8680D500
    }

    public class ConfigHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86812690
        public void ValidatePath(){} // RVA: 0x7FFE86812850
        public void CheckPath(){} // RVA: 0x7FFE86812940
        public void OnStartParsing(){} // RVA: 0x7FFE810FB310
        public void OnProcessingInstruction(){} // RVA: 0x7FFE810FB310
        public void OnIgnorableWhitespace(){} // RVA: 0x7FFE810FB310
        public void OnStartElement(){} // RVA: 0x7FFE86812AE0
        public void ParseElement(){} // RVA: 0x7FFE86812C80
        public void OnEndElement(){} // RVA: 0x7FFE86814060
        public void ReadCustomProviderData(){} // RVA: 0x7FFE868141B0
        public void ReadLifetine(){} // RVA: 0x7FFE868145B0
        public void ParseTime(){} // RVA: 0x7FFE86814A70
        public void ReadChannel(){} // RVA: 0x7FFE86814F20
        public void ReadProvider(){} // RVA: 0x7FFE868156D0
        public void ReadClientActivated(){} // RVA: 0x7FFE86815CD0
        public void ReadServiceActivated(){} // RVA: 0x7FFE86815E60
        public void ReadClientWellKnown(){} // RVA: 0x7FFE86815F40
        public void ReadServiceWellKnown(){} // RVA: 0x7FFE86816050
        public void ReadInteropXml(){} // RVA: 0x7FFE868162B0
        public void ReadPreload(){} // RVA: 0x7FFE868164D0
        public void GetNotNull(){} // RVA: 0x7FFE86816770
        public void ExtractAssembly(){} // RVA: 0x7FFE86816880
        public void OnChars(){} // RVA: 0x7FFE810FB310
        public void OnEndParsing(){} // RVA: 0x7FFE868169D0
    }

    public class DisposerReplySink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void SyncProcessMessage(){} // RVA: 0x7FFE8681E6B0
        public void AsyncProcessMessage(){} // RVA: 0x7FFE8681E740
    }

    public class EnvoyInfo : Object
    {
        public System.Runtime.Remoting.Messaging.IMessageSink envoySinks; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_EnvoySinks(){} // RVA: 0x7FFE81116380
    }

    public class FormatterData : ProviderData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86818060
    }

    public class IChannelInfo
    {
        // ── Methods ──
        public void get_ChannelData(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IEnvoyInfo
    {
        // ── Methods ──
        public void get_EnvoySinks(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IRemotingTypeInfo
    {
        // ── Methods ──
        public void get_TypeName(){} // RVA: 0x7FFE80E2E2E0
        public void CanCastTo(){} // RVA: 0x7FFE80E32650
    }

    public class Identity : Object
    {
        public string _objectUri; // 0x10
        public System.Runtime.Remoting.Messaging.IMessageSink _channelSink; // 0x18
        public System.Runtime.Remoting.Messaging.IMessageSink _envoySink; // 0x20
        public System.Runtime.Remoting.Contexts.DynamicPropertyCollection _clientDynamicProperties; // 0x28
        public System.Runtime.Remoting.Contexts.DynamicPropertyCollection _serverDynamicProperties; // 0x30
        public System.Runtime.Remoting.ObjRef _objRef; // 0x38
        public bool _disposed; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void CreateObjRef(){} // RVA: 0x7FFE80E2E390
        public void get_ChannelSink(){} // RVA: 0x7FFE810FE7C0
        public void set_ChannelSink(){} // RVA: 0x7FFE81161E80
        public void get_EnvoySink(){} // RVA: 0x7FFE811290C0
        public void get_ObjectUri(){} // RVA: 0x7FFE81116380
        public void set_ObjectUri(){} // RVA: 0x7FFE810FCE30
        public void get_IsConnected(){} // RVA: 0x7FFE81C8DC00
        public void get_Disposed(){} // RVA: 0x7FFE811B6C00
        public void set_Disposed(){} // RVA: 0x7FFE811B6C10
        public void get_ClientDynamicProperties(){} // RVA: 0x7FFE8680CFC0
        public void get_HasServerDynamicSinks(){} // RVA: 0x7FFE8680D070
        public void NotifyClientDynamicSinks(){} // RVA: 0x7FFE8680D0C0
        public void NotifyServerDynamicSinks(){} // RVA: 0x7FFE8680D160
    }

    public class InternalRemotingServices : Object
    {
        // ── Methods ──
        public void GetCachedSoapAttribute(){} // RVA: 0x7FFE8680D530
        public void .cctor(){} // RVA: 0x7FFE8680DB20
    }

    public class ObjRef : Object
    {
        public System.Runtime.Remoting.IChannelInfo channel_info; // 0x10
        public string uri; // 0x18
        public System.Runtime.Remoting.IRemotingTypeInfo typeInfo; // 0x20
        public System.Runtime.Remoting.IEnvoyInfo envoyInfo; // 0x28
        public int flags; // 0x30
        public System.Type _serverType; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8680E1D0 | overloaded x4
        public void DeserializeInTheCurrentDomain(){} // RVA: 0x7FFE8680DCB0
        public void SerializeType(){} // RVA: 0x7FFE8680DF60
        public void get_IsReferenceToWellKnow(){} // RVA: 0x7FFE8680EAD0
        public void get_ChannelInfo(){} // RVA: 0x7FFE81116380
        public void get_EnvoyInfo(){} // RVA: 0x7FFE81129130
        public void set_EnvoyInfo(){} // RVA: 0x7FFE810FCE90
        public void get_TypeInfo(){} // RVA: 0x7FFE811290C0
        public void set_TypeInfo(){} // RVA: 0x7FFE811290D0
        public void get_URI(){} // RVA: 0x7FFE810FE7C0
        public void set_URI(){} // RVA: 0x7FFE81161E80
        public void GetObjectData(){} // RVA: 0x7FFE8680EB30
        public void GetRealObject(){} // RVA: 0x7FFE8680F1A0
        public void UpdateChannelInfo(){} // RVA: 0x7FFE8680F280
        public void get_ServerType(){} // RVA: 0x7FFE8680F3C0
        public void .cctor(){} // RVA: 0x7FFE8680F4F0
    }

    public class ProviderData : Object
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x7FFE86817850
        public void .ctor(){} // RVA: 0x7FFE86817FB0
    }

    public class RemotingConfiguration : Object
    {
        public string applicationID;
        public string applicationName; // 0x8

        // ── Methods ──
        public void get_ApplicationName(){} // RVA: 0x7FFE8680F550
        public void set_ApplicationName(){} // RVA: 0x7FFE8680F5B0
        public void get_ProcessId(){} // RVA: 0x7FFE8680F670
        public void LoadDefaultDelayedChannels(){} // RVA: 0x7FFE8680F7F0
        public void IsActivationAllowed(){} // RVA: 0x7FFE8680FD00
        public void IsRemotelyActivatedClientType(){} // RVA: 0x7FFE8680FF00
        public void IsWellKnownClientType(){} // RVA: 0x7FFE86810150
        public void RegisterActivatedClientType(){} // RVA: 0x7FFE868103A0
        public void RegisterActivatedServiceType(){} // RVA: 0x7FFE868106C0
        public void RegisterWellKnownClientType(){} // RVA: 0x7FFE868108A0
        public void RegisterWellKnownServiceType(){} // RVA: 0x7FFE86810BC0
        public void RegisterChannelTemplate(){} // RVA: 0x7FFE86810DF0
        public void RegisterClientProviderTemplate(){} // RVA: 0x7FFE86810E80
        public void RegisterServerProviderTemplate(){} // RVA: 0x7FFE86810F10
        public void RegisterChannels(){} // RVA: 0x7FFE86810FA0
        public void RegisterTypes(){} // RVA: 0x7FFE86811890
        public void CustomErrorsEnabled(){} // RVA: 0x7FFE86811D40
        public void SetCustomErrorsMode(){} // RVA: 0x7FFE86811DD0
        public void .cctor(){} // RVA: 0x7FFE868120C0
    }

    public class RemotingException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3C80 | overloaded x4
    }

    public class RemotingServices : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86818070
        public void InternalExecute(){} // RVA: 0x7FFE868187E0
        public void GetVirtualMethod(){} // RVA: 0x7FFE868187F0
        public void IsTransparentProxy(){} // RVA: 0x7FFE86818800
        public void InternalExecuteMessage(){} // RVA: 0x7FFE86818840
        public void Connect(){} // RVA: 0x7FFE86818C70 | overloaded x2
        public void GetServerTypeForUri(){} // RVA: 0x7FFE86818D20
        public void Unmarshal(){} // RVA: 0x7FFE86818E40 | overloaded x2
        public void Marshal(){} // RVA: 0x7FFE86819280 | overloaded x2
        public void NewUri(){} // RVA: 0x7FFE86819300
        public void GetRealProxy(){} // RVA: 0x7FFE86819880
        public void GetMethodBaseFromMethodMessage(){} // RVA: 0x7FFE868198D0
        public void GetMethodBaseFromName(){} // RVA: 0x7FFE86819AE0
        public void FindInterfaceMethod(){} // RVA: 0x7FFE86819E10
        public void GetObjectData(){} // RVA: 0x7FFE8681A030
        public void IsOneWay(){} // RVA: 0x7FFE8681A0E0
        public void CreateClientProxy(){} // RVA: 0x7FFE8681A520 | overloaded x3
        public void CreateClientProxyForContextBound(){} // RVA: 0x7FFE8681A610
        public void GetIdentityForUri(){} // RVA: 0x7FFE8681A7E0
        public void RemoveAppNameFromUri(){} // RVA: 0x7FFE8681AC20
        public void GetOrCreateClientIdentity(){} // RVA: 0x7FFE8681AD30
        public void GetClientChannelSinkChain(){} // RVA: 0x7FFE8681B750
        public void CreateContextBoundObjectIdentity(){} // RVA: 0x7FFE8681B880
        public void CreateClientActivatedServerIdentity(){} // RVA: 0x7FFE8681B9B0
        public void CreateWellKnownServerIdentity(){} // RVA: 0x7FFE8681BA60
        public void RegisterServerIdentity(){} // RVA: 0x7FFE8681BBB0
        public void GetProxyForRemoteObject(){} // RVA: 0x7FFE8681BE70
        public void GetRemoteObject(){} // RVA: 0x7FFE8681BF90
        public void SerializeCallData(){} // RVA: 0x7FFE8681C010
        public void DeserializeCallData(){} // RVA: 0x7FFE8681C490
        public void SerializeExceptionData(){} // RVA: 0x7FFE8681C800
        public void RegisterInternalChannels(){} // RVA: 0x7FFE8681CB00
        public void DisposeIdentity(){} // RVA: 0x7FFE8681CB50
        public void GetMessageTargetIdentity(){} // RVA: 0x7FFE8681CE70
        public void SetMessageTargetIdentity(){} // RVA: 0x7FFE8681D290
        public void UpdateOutArgObject(){} // RVA: 0x7FFE8681D350
        public void GetNormalizedUri(){} // RVA: 0x7FFE8681D570
    }

    public class ServerIdentity : Identity
    {
        public System.Type _objectType; // 0x48
        public System.MarshalByRefObject _serverObject; // 0x50
        public System.Runtime.Remoting.Messaging.IMessageSink _serverSink; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8681D5E0
        public void get_ObjectType(){} // RVA: 0x7FFE81176730
        public void StartTrackingLifetime(){} // RVA: 0x7FFE8681D700
        public void OnLifetimeExpired(){} // RVA: 0x7FFE8681DA90
        public void CreateObjRef(){} // RVA: 0x7FFE8681DAF0
        public void AttachServerObject(){} // RVA: 0x7FFE8681DD70
        public void get_Lease(){} // RVA: 0x7FFE81176D50
        public void get_Context(){} // RVA: 0x7FFE81199370
        public void set_Context(){} // RVA: 0x7FFE81199380
        public void SyncObjectProcessMessage(){} // RVA: 0x7FFE80E2E390
        public void AsyncObjectProcessMessage(){} // RVA: 0x7FFE80E3FC10
        public void DisposeServerObject(){} // RVA: 0x7FFE8681DA90
    }

    public class SingleCallIdentity : ServerIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8681E060
        public void SyncObjectProcessMessage(){} // RVA: 0x7FFE8681E410
        public void AsyncObjectProcessMessage(){} // RVA: 0x7FFE8681E480
    }

    public class SingletonIdentity : ServerIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8681E060
        public void GetServerObject(){} // RVA: 0x7FFE8681E070
        public void SyncObjectProcessMessage(){} // RVA: 0x7FFE8681E250
        public void AsyncObjectProcessMessage(){} // RVA: 0x7FFE8681E320
    }

    public class SoapServices : Object
    {
        public System.Collections.Hashtable _xmlTypes;
        public System.Collections.Hashtable _xmlElements; // 0x8
        public System.Collections.Hashtable _soapActions; // 0x10

        // ── Methods ──
        public void get_XmlNsForClrTypeWithAssembly(){} // RVA: 0x7FFE8681E780
        public void get_XmlNsForClrTypeWithNs(){} // RVA: 0x7FFE8681E7C0
        public void get_XmlNsForClrTypeWithNsAndAssembly(){} // RVA: 0x7FFE8681E800
        public void CodeXmlNamespaceForClrTypeNamespace(){} // RVA: 0x7FFE8681E840
        public void GetNameKey(){} // RVA: 0x7FFE8681EA50
        public void GetAssemblyName(){} // RVA: 0x7FFE8681EAC0
        public void GetXmlElementForInteropType(){} // RVA: 0x7FFE8681ECC0
        public void GetXmlNamespaceForMethodCall(){} // RVA: 0x7FFE8681EEE0
        public void GetXmlNamespaceForMethodResponse(){} // RVA: 0x7FFE8681EF90
        public void GetXmlTypeForInteropType(){} // RVA: 0x7FFE8681F040
        public void PreLoad(){} // RVA: 0x7FFE8681F310 | overloaded x2
        public void RegisterInteropXmlElement(){} // RVA: 0x7FFE8681F910
        public void RegisterInteropXmlType(){} // RVA: 0x7FFE8681FB50
        public void EncodeNs(){} // RVA: 0x7FFE8681FD90
        public void .cctor(){} // RVA: 0x7FFE8681FE80
    }

    public class TypeEntry : Object
    {
        public string assembly_name; // 0x10
        public string type_name; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_AssemblyName(){} // RVA: 0x7FFE81116380
        public void set_AssemblyName(){} // RVA: 0x7FFE810FCE30
        public void get_TypeName(){} // RVA: 0x7FFE810FE7C0
        public void set_TypeName(){} // RVA: 0x7FFE81161E80
    }

    public class TypeInfo : Object
    {
        public string serverType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868201B0
        public void get_TypeName(){} // RVA: 0x7FFE81116380
        public void CanCastTo(){} // RVA: 0x7FFE868208B0
    }

    public class WellKnownClientTypeEntry : TypeEntry
    {
        public System.Type obj_type; // 0x20
        public string obj_url; // 0x28
        public string app_url; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86820B60
        public void get_ApplicationUrl(){} // RVA: 0x7FFE8144E200
        public void get_ObjectType(){} // RVA: 0x7FFE811290C0
        public void get_ObjectUrl(){} // RVA: 0x7FFE81129130
        public void ToString(){} // RVA: 0x7FFE86820E00
    }

    public class WellKnownServiceTypeEntry : TypeEntry
    {
        public System.Type obj_type; // 0x20
        public string obj_uri; // 0x28
        public 0x664C8EDC obj_mode; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86820E40
        public void get_Mode(){} // RVA: 0x7FFE81156CD0
        public void get_ObjectType(){} // RVA: 0x7FFE811290C0
        public void get_ObjectUri(){} // RVA: 0x7FFE81129130
        public void ToString(){} // RVA: 0x7FFE868210F0
    }

}