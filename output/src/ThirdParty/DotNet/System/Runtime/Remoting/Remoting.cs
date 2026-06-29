// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting
// Classes: 28
// Methods: 203

namespace ThirdParty.DotNet.System.Runtime.Remoting
{
    public class ActivatedClientTypeEntry : TypeEntry
    {
        public object applicationUrl;
        public object obj_type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67451F0
        public void get_ApplicationUrl(){} // RVA: 0xB700F0
        public void get_ContextAttributes(){} // RVA: 0xDAC980
        public void get_ObjectType(){} // RVA: 0xB70160
        public void ToString(){} // RVA: 0x6745470
    }

    public class ActivatedServiceTypeEntry : TypeEntry
    {
        public object obj_type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6745490
        public void get_ObjectType(){} // RVA: 0xB700F0
        public void ToString(){} // RVA: 0x67456C0
    }

    public class ChannelData : Object
    {
        public object Ref;
        public object Type;
        public object Id;
        public object DelayLoadAsClientChannel;
        public object _serverProviders;
        public object _clientProviders;
        public object _customProperties;

        // ── Methods ──
        public void get_ServerProviders(){} // RVA: 0x674F020
        public void get_ClientProviders(){} // RVA: 0x674F0D0
        public void get_CustomProperties(){} // RVA: 0x674F180
        public void CopyFrom(){} // RVA: 0x674F230
        public void .ctor(){} // RVA: 0x674FB50
    }

    public class ChannelInfo : Object
    {
        public object channelData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6745100
        public void get_ChannelData(){} // RVA: 0xB5DBF0
    }

    public class ClientActivatedIdentity : ServerIdentity
    {
        public object _targetThis;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6755FC0
        public void GetServerObject(){} // RVA: 0xBE58B0
        public void SetClientProxy(){} // RVA: 0xC10060
        public void OnLifetimeExpired(){} // RVA: 0x6755FE0
        public void SyncObjectProcessMessage(){} // RVA: 0x6756070
        public void AsyncObjectProcessMessage(){} // RVA: 0x6756150
    }

    public class ClientIdentity : Identity
    {
        public object _proxyReference;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6745910
        public void get_ClientProxy(){} // RVA: 0x6745AC0
        public void set_ClientProxy(){} // RVA: 0x6745B50
        public void CreateObjRef(){} // RVA: 0xD05CA0
        public void get_TargetUri(){} // RVA: 0x6745C10
    }

    public class ConfigHandler : Object
    {
        public object typeEntries;
        public object channelInstances;
        public object currentChannel;
        public object currentProviderData;
        public object currentClientUrl;
        public object appName;
        public object currentXmlPath;
        public object onlyDelayedChannels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x674AAF0
        public void ValidatePath(){} // RVA: 0x674ACB0
        public void CheckPath(){} // RVA: 0x674ADA0
        public void OnStartParsing(){} // RVA: 0xB43310
        public void OnProcessingInstruction(){} // RVA: 0xB43310
        public void OnIgnorableWhitespace(){} // RVA: 0xB43310
        public void OnStartElement(){} // RVA: 0x674AF40
        public void ParseElement(){} // RVA: 0x674B0E0
        public void OnEndElement(){} // RVA: 0x674C4D0
        public void ReadCustomProviderData(){} // RVA: 0x674C620
        public void ReadLifetine(){} // RVA: 0x674CA20
        public void ParseTime(){} // RVA: 0x674CF00
        public void ReadChannel(){} // RVA: 0x674D3B0
        public void ReadProvider(){} // RVA: 0x674DB70
        public void ReadClientActivated(){} // RVA: 0x674E190
        public void ReadServiceActivated(){} // RVA: 0x674E330
        public void ReadClientWellKnown(){} // RVA: 0x674E420
        public void ReadServiceWellKnown(){} // RVA: 0x674E540
        public void ReadInteropXml(){} // RVA: 0x674E7B0
        public void ReadPreload(){} // RVA: 0x674E9C0
        public void GetNotNull(){} // RVA: 0x674EC60
        public void ExtractAssembly(){} // RVA: 0x674ED70
        public void OnChars(){} // RVA: 0xB43310
        public void OnEndParsing(){} // RVA: 0x674EEC0
    }

    public class DisposerReplySink : Object
    {
        public object _next;
        public object _disposable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void SyncProcessMessage(){} // RVA: 0x6756880
        public void AsyncProcessMessage(){} // RVA: 0x6756910
    }

    public class EnvoyInfo : Object
    {
        public object envoySinks;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_EnvoySinks(){} // RVA: 0xB5DBF0
    }

    public class FormatterData : ProviderData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67504F0
    }

    public class IChannelInfo
    {
        // ── Methods ──
        public void get_ChannelData(){} // RVA: 0x87C0A0
    }

    public class IEnvoyInfo
    {
        // ── Methods ──
        public void get_EnvoySinks(){} // RVA: 0x87C0A0
    }

    public class IRemotingTypeInfo
    {
        // ── Methods ──
        public void get_TypeName(){} // RVA: 0x87C0A0
        public void CanCastTo(){} // RVA: 0x87D3C0
    }

    public class Identity : Object
    {
        public object _objectUri;
        public object _channelSink;
        public object _envoySink;
        public object _clientDynamicProperties;
        public object _serverDynamicProperties;
        public object _objRef;
        public object _disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void CreateObjRef(){} // RVA: 0x87C540
        public void get_ChannelSink(){} // RVA: 0xB465B0
        public void set_ChannelSink(){} // RVA: 0xBA9BA0
        public void get_EnvoySink(){} // RVA: 0xB700F0
        public void get_ObjectUri(){} // RVA: 0xB5DBF0
        public void set_ObjectUri(){} // RVA: 0xB44D60
        public void get_IsConnected(){} // RVA: 0x17B0810
        public void get_Disposed(){} // RVA: 0xC02470
        public void set_Disposed(){} // RVA: 0xC02480
        public void get_ClientDynamicProperties(){} // RVA: 0x67456D0
        public void get_HasServerDynamicSinks(){} // RVA: 0x6745780
        public void NotifyClientDynamicSinks(){} // RVA: 0x67457D0
        public void NotifyServerDynamicSinks(){} // RVA: 0x6745870
    }

    public class InternalRemotingServices : Object
    {
        public object _soapAttributes;

        // ── Methods ──
        public void GetCachedSoapAttribute(){} // RVA: 0x6745C40
        public void .cctor(){} // RVA: 0x6746200
    }

    public class ObjRef : Object
    {
        public object channel_info;
        public object uri;
        public object typeInfo;
        public object envoyInfo;
        public object flags;
        public object _serverType;
        public object MarshalledObjectRef;
        public object WellKnowObjectRef;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67468D0
        public void DeserializeInTheCurrentDomain(){} // RVA: 0x6746390
        public void SerializeType(){} // RVA: 0x6746650
        public void get_IsReferenceToWellKnow(){} // RVA: 0x67471B0
        public void get_ChannelInfo(){} // RVA: 0xB5DBF0
        public void get_EnvoyInfo(){} // RVA: 0xB70160
        public void set_EnvoyInfo(){} // RVA: 0xB44DC0
        public void get_TypeInfo(){} // RVA: 0xB700F0
        public void set_TypeInfo(){} // RVA: 0xB70100
        public void get_URI(){} // RVA: 0xB465B0
        public void set_URI(){} // RVA: 0xBA9BA0
        public void GetObjectData(){} // RVA: 0x6747210
        public void GetRealObject(){} // RVA: 0x6747800
        public void UpdateChannelInfo(){} // RVA: 0x67478E0
        public void get_ServerType(){} // RVA: 0x6747A20
        public void .cctor(){} // RVA: 0x6747B40
    }

    public class ProviderData : Object
    {
        public object Ref;
        public object Type;
        public object Id;
        public object CustomProperties;
        public object CustomData;

        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x674FD00
        public void .ctor(){} // RVA: 0x6750440
    }

    public class RemotingConfiguration : Object
    {
        public object applicationID;
        public object applicationName;
        public object processGuid;
        public object defaultConfigRead;
        public object defaultDelayedConfigRead;
        public object _errorMode;
        public object wellKnownClientEntries;
        public object activatedClientEntries;
        public object wellKnownServiceEntries;
        public object activatedServiceEntries;
        public object channelTemplates;
        public object clientProviderTemplates;
        public object serverProviderTemplates;

        // ── Methods ──
        public void get_ApplicationName(){} // RVA: 0x6747BA0
        public void set_ApplicationName(){} // RVA: 0x6747C00
        public void get_ProcessId(){} // RVA: 0x6747CC0
        public void LoadDefaultDelayedChannels(){} // RVA: 0x6747E40
        public void IsActivationAllowed(){} // RVA: 0x6748320
        public void IsRemotelyActivatedClientType(){} // RVA: 0x67484D0
        public void IsWellKnownClientType(){} // RVA: 0x67486E0
        public void RegisterActivatedClientType(){} // RVA: 0x67488F0
        public void RegisterActivatedServiceType(){} // RVA: 0x6748BE0
        public void RegisterWellKnownClientType(){} // RVA: 0x6748D90
        public void RegisterWellKnownServiceType(){} // RVA: 0x6749080
        public void RegisterChannelTemplate(){} // RVA: 0x6749290
        public void RegisterClientProviderTemplate(){} // RVA: 0x6749320
        public void RegisterServerProviderTemplate(){} // RVA: 0x67493B0
        public void RegisterChannels(){} // RVA: 0x6749440
        public void RegisterTypes(){} // RVA: 0x6749D20
        public void CustomErrorsEnabled(){} // RVA: 0x674A1B0
        public void SetCustomErrorsMode(){} // RVA: 0x674A240
        public void .cctor(){} // RVA: 0x674A520
    }

    public class RemotingException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022E0
    }

    public class RemotingServices : Object
    {
        public object uri_hash;
        public object _serializationFormatter;
        public object _deserializationFormatter;
        public object app_id;
        public object app_id_lock;
        public object next_id;
        public object FieldSetterMethod;
        public object FieldGetterMethod;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6750500
        public void InternalExecute(){} // RVA: 0x6750C00
        public void GetVirtualMethod(){} // RVA: 0x6750C10
        public void IsTransparentProxy(){} // RVA: 0x6750C20
        public void InternalExecuteMessage(){} // RVA: 0x6750C60
        public void Connect(){} // RVA: 0x6751080
        public void GetServerTypeForUri(){} // RVA: 0x6751130
        public void Unmarshal(){} // RVA: 0x6751230
        public void Marshal(){} // RVA: 0x67516C0
        public void NewUri(){} // RVA: 0x6751730
        public void GetRealProxy(){} // RVA: 0x6751C90
        public void GetMethodBaseFromMethodMessage(){} // RVA: 0x6751CE0
        public void GetMethodBaseFromName(){} // RVA: 0x6751EE0
        public void FindInterfaceMethod(){} // RVA: 0x6752200
        public void GetObjectData(){} // RVA: 0x6752430
        public void IsOneWay(){} // RVA: 0x67524E0
        public void CreateClientProxy(){} // RVA: 0x67528F0
        public void CreateClientProxyForContextBound(){} // RVA: 0x67529E0
        public void GetIdentityForUri(){} // RVA: 0x6752BC0
        public void RemoveAppNameFromUri(){} // RVA: 0x6752FC0
        public void GetOrCreateClientIdentity(){} // RVA: 0x67530D0
        public void GetClientChannelSinkChain(){} // RVA: 0x6753AB0
        public void CreateContextBoundObjectIdentity(){} // RVA: 0x6753BE0
        public void CreateClientActivatedServerIdentity(){} // RVA: 0x6753D10
        public void CreateWellKnownServerIdentity(){} // RVA: 0x6753DC0
        public void RegisterServerIdentity(){} // RVA: 0x6753F10
        public void GetProxyForRemoteObject(){} // RVA: 0x67541A0
        public void GetRemoteObject(){} // RVA: 0x67542A0
        public void SerializeCallData(){} // RVA: 0x6754320
        public void DeserializeCallData(){} // RVA: 0x6754770
        public void SerializeExceptionData(){} // RVA: 0x6754AA0
        public void RegisterInternalChannels(){} // RVA: 0x6754DA0
        public void DisposeIdentity(){} // RVA: 0x6754DF0
        public void GetMessageTargetIdentity(){} // RVA: 0x67550E0
        public void SetMessageTargetIdentity(){} // RVA: 0x67554C0
        public void UpdateOutArgObject(){} // RVA: 0x6755580
        public void GetNormalizedUri(){} // RVA: 0x6755760
    }

    public class ServerIdentity : Identity
    {
        public object _objectType;
        public object _serverObject;
        public object _serverSink;
        public object _context;
        public object _lease;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67557D0
        public void get_ObjectType(){} // RVA: 0xBBF8F0
        public void StartTrackingLifetime(){} // RVA: 0x67558F0
        public void OnLifetimeExpired(){} // RVA: 0x6755C80
        public void CreateObjRef(){} // RVA: 0x6755CE0
        public void AttachServerObject(){} // RVA: 0x6755F50
        public void get_Lease(){} // RVA: 0xBBFF90
        public void get_Context(){} // RVA: 0xBE2C60
        public void set_Context(){} // RVA: 0xBE2C70
        public void SyncObjectProcessMessage(){} // RVA: 0x87C540
        public void AsyncObjectProcessMessage(){} // RVA: 0x87C5F0
        public void DisposeServerObject(){} // RVA: 0x6755C80
    }

    public class SingleCallIdentity : ServerIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6756250
        public void SyncObjectProcessMessage(){} // RVA: 0x67565D0
        public void AsyncObjectProcessMessage(){} // RVA: 0x6756640
    }

    public class SingletonIdentity : ServerIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6756250
        public void GetServerObject(){} // RVA: 0x6756260
        public void SyncObjectProcessMessage(){} // RVA: 0x6756410
        public void AsyncObjectProcessMessage(){} // RVA: 0x67564E0
    }

    public class SoapServices : Object
    {
        public object _xmlTypes;
        public object _xmlElements;
        public object _soapActions;
        public object _soapActionsMethods;
        public object _typeInfos;

        // ── Methods ──
        public void get_XmlNsForClrTypeWithAssembly(){} // RVA: 0x6756950
        public void get_XmlNsForClrTypeWithNs(){} // RVA: 0x6756990
        public void get_XmlNsForClrTypeWithNsAndAssembly(){} // RVA: 0x67569D0
        public void CodeXmlNamespaceForClrTypeNamespace(){} // RVA: 0x6756A10
        public void GetNameKey(){} // RVA: 0x6756C10
        public void GetAssemblyName(){} // RVA: 0x6756C80
        public void GetXmlElementForInteropType(){} // RVA: 0x6756E20
        public void GetXmlNamespaceForMethodCall(){} // RVA: 0x6757040
        public void GetXmlNamespaceForMethodResponse(){} // RVA: 0x67570F0
        public void GetXmlTypeForInteropType(){} // RVA: 0x67571A0
        public void PreLoad(){} // RVA: 0x6757470
        public void RegisterInteropXmlElement(){} // RVA: 0x6757A30
        public void RegisterInteropXmlType(){} // RVA: 0x6757C40
        public void EncodeNs(){} // RVA: 0x6757E50
        public void .cctor(){} // RVA: 0x6757F40
    }

    public class TypeEntry : Object
    {
        public object assembly_name;
        public object type_name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_AssemblyName(){} // RVA: 0xB5DBF0
        public void set_AssemblyName(){} // RVA: 0xB44D60
        public void get_TypeName(){} // RVA: 0xB465B0
        public void set_TypeName(){} // RVA: 0xBA9BA0
    }

    public class TypeInfo : Object
    {
        public object serverType;
        public object serverHierarchy;
        public object interfacesImplemented;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6758270
        public void get_TypeName(){} // RVA: 0xB5DBF0
        public void CanCastTo(){} // RVA: 0x67589C0
    }

    public class WellKnownClientTypeEntry : TypeEntry
    {
        public object obj_type;
        public object obj_url;
        public object app_url;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6758C50
        public void get_ApplicationUrl(){} // RVA: 0xD33E60
        public void get_ObjectType(){} // RVA: 0xB700F0
        public void get_ObjectUrl(){} // RVA: 0xB70160
        public void ToString(){} // RVA: 0x6758ED0
    }

    public class WellKnownServiceTypeEntry : TypeEntry
    {
        public object obj_type;
        public object obj_uri;
        public object obj_mode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6758F10
        public void get_Mode(){} // RVA: 0xB9E080
        public void get_ObjectType(){} // RVA: 0xB700F0
        public void get_ObjectUri(){} // RVA: 0xB70160
        public void ToString(){} // RVA: 0x67591A0
    }

}