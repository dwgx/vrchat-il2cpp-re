// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting
// Classes: 28
// Methods: 216

namespace ThirdParty.DotNet.System.Runtime.Remoting
{
    public class ActivatedClientTypeEntry : TypeEntry
    {
        public string ApplicationUrl; // 0x20
        public System.Type ContextAttributes; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8463190
        public void get_ApplicationUrl(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ContextAttributes(){} // RVA: 0x7FFAC34F9180
        public void get_ObjectType(){} // RVA: 0x7FFAC2F4F130
        public void ToString(){} // RVA: 0x7FFAC8463430
    }

    public class ActivatedServiceTypeEntry : TypeEntry
    {
        public System.Type ObjectType; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8463450
        public void get_ObjectType(){} // RVA: 0x7FFAC2F4F0C0
        public void ToString(){} // RVA: 0x7FFAC84636A0
    }

    public class ChannelData : Object
    {
        public string ServerProviders; // 0x10
        public string ClientProviders; // 0x18
        public string CustomProperties; // 0x20
        public string DelayLoadAsClientChannel; // 0x28
        public System.Collections.ArrayList _serverProviders; // 0x30
        public System.Collections.ArrayList _clientProviders; // 0x38
        public System.Collections.Hashtable _customProperties; // 0x40

        // ── Methods ──
        public void get_ServerProviders(){} // RVA: 0x7FFAC846D220
        public void get_ClientProviders(){} // RVA: 0x7FFAC846D2D0
        public void get_CustomProperties(){} // RVA: 0x7FFAC846D380
        public void CopyFrom(){} // RVA: 0x7FFAC846D430
        public void .ctor(){} // RVA: 0x7FFAC846DD90
    }

    public class ChannelInfo : Object
    {
        public object[] ChannelData; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84630A0 | overloaded x2
        public void get_ChannelData(){} // RVA: 0x7FFAC2F3C380
    }

    public class ClientActivatedIdentity : ServerIdentity
    {
        public System.MarshalByRefObject _targetThis; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84744D0
        public void GetServerObject(){} // RVA: 0x7FFAC2FC20E0
        public void SetClientProxy(){} // RVA: 0x7FFAC2FE95A0
        public void OnLifetimeExpired(){} // RVA: 0x7FFAC84744F0
        public void SyncObjectProcessMessage(){} // RVA: 0x7FFAC8474580
        public void AsyncObjectProcessMessage(){} // RVA: 0x7FFAC8474660
    }

    public class ClientIdentity : Identity
    {
        public System.WeakReference ClientProxy; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84638F0
        public void get_ClientProxy(){} // RVA: 0x7FFAC8463AA0
        public void set_ClientProxy(){} // RVA: 0x7FFAC8463B30
        public void CreateObjRef(){} // RVA: 0x7FFAC31D0140
        public void get_TargetUri(){} // RVA: 0x7FFAC8463BF0
    }

    public class ConfigHandler : Object
    {
        public System.Collections.ArrayList typeEntries; // 0x10
        public System.Collections.ArrayList channelInstances; // 0x18
        public System.Runtime.Remoting.ChannelData currentChannel; // 0x20
        public System.Collections.Stack currentProviderData; // 0x28
        public string currentClientUrl; // 0x30
        public string appName; // 0x38
        public string currentXmlPath; // 0x40
        public bool onlyDelayedChannels; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8468D80
        public void ValidatePath(){} // RVA: 0x7FFAC8468F40
        public void CheckPath(){} // RVA: 0x7FFAC8469030
        public void OnStartParsing(){} // RVA: 0x7FFAC2F21310
        public void OnProcessingInstruction(){} // RVA: 0x7FFAC2F21310
        public void OnIgnorableWhitespace(){} // RVA: 0x7FFAC2F21310
        public void OnStartElement(){} // RVA: 0x7FFAC84691D0
        public void ParseElement(){} // RVA: 0x7FFAC8469370
        public void OnEndElement(){} // RVA: 0x7FFAC846A750
        public void ReadCustomProviderData(){} // RVA: 0x7FFAC846A8A0
        public void ReadLifetine(){} // RVA: 0x7FFAC846ACA0
        public void ParseTime(){} // RVA: 0x7FFAC846B160
        public void ReadChannel(){} // RVA: 0x7FFAC846B610
        public void ReadProvider(){} // RVA: 0x7FFAC846BDC0
        public void ReadClientActivated(){} // RVA: 0x7FFAC846C3C0
        public void ReadServiceActivated(){} // RVA: 0x7FFAC846C550
        public void ReadClientWellKnown(){} // RVA: 0x7FFAC846C630
        public void ReadServiceWellKnown(){} // RVA: 0x7FFAC846C740
        public void ReadInteropXml(){} // RVA: 0x7FFAC846C9A0
        public void ReadPreload(){} // RVA: 0x7FFAC846CBC0
        public void GetNotNull(){} // RVA: 0x7FFAC846CE60
        public void ExtractAssembly(){} // RVA: 0x7FFAC846CF70
        public void OnChars(){} // RVA: 0x7FFAC2F21310
        public void OnEndParsing(){} // RVA: 0x7FFAC846D0C0
    }

    public class DisposerReplySink : Object
    {
        public System.Runtime.Remoting.Messaging.IMessageSink _next; // 0x10
        public System.IDisposable _disposable; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void SyncProcessMessage(){} // RVA: 0x7FFAC8474DA0
        public void AsyncProcessMessage(){} // RVA: 0x7FFAC8474E30
    }

    public class EnvoyInfo : Object
    {
        public System.Runtime.Remoting.Messaging.IMessageSink EnvoySinks; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_EnvoySinks(){} // RVA: 0x7FFAC2F3C380
    }

    public class FormatterData : ProviderData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC846E750
    }

    public class IChannelInfo
    {
        public object ChannelData;

        // ── Methods ──
        public void get_ChannelData(){} // RVA: 0x7FFAC2C58E90
    }

    public class IEnvoyInfo
    {
        public object EnvoySinks;

        // ── Methods ──
        public void get_EnvoySinks(){} // RVA: 0x7FFAC2C58E90
    }

    public class IRemotingTypeInfo
    {
        public object TypeName;

        // ── Methods ──
        public void get_TypeName(){} // RVA: 0x7FFAC2C58E90
        public void CanCastTo(){} // RVA: 0x7FFAC2C5D200
    }

    public class Identity : Object
    {
        public string ChannelSink; // 0x10
        public System.Runtime.Remoting.Messaging.IMessageSink EnvoySink; // 0x18
        public System.Runtime.Remoting.Messaging.IMessageSink ObjectUri; // 0x20
        public System.Runtime.Remoting.Contexts.DynamicPropertyCollection IsConnected; // 0x28
        public System.Runtime.Remoting.Contexts.DynamicPropertyCollection Disposed; // 0x30
        public System.Runtime.Remoting.ObjRef ClientDynamicProperties; // 0x38
        public bool HasServerDynamicSinks; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void CreateObjRef(){} // RVA: 0x7FFAC2C58F40
        public void get_ChannelSink(){} // RVA: 0x7FFAC2F247C0
        public void set_ChannelSink(){} // RVA: 0x7FFAC2F87E80
        public void get_EnvoySink(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ObjectUri(){} // RVA: 0x7FFAC2F3C380
        public void set_ObjectUri(){} // RVA: 0x7FFAC2F22E30
        public void get_IsConnected(){} // RVA: 0x7FFAC34D2B40
        public void get_Disposed(){} // RVA: 0x7FFAC2FDCC00
        public void set_Disposed(){} // RVA: 0x7FFAC2FDCC10
        public void get_ClientDynamicProperties(){} // RVA: 0x7FFAC84636B0
        public void get_HasServerDynamicSinks(){} // RVA: 0x7FFAC8463760
        public void NotifyClientDynamicSinks(){} // RVA: 0x7FFAC84637B0
        public void NotifyServerDynamicSinks(){} // RVA: 0x7FFAC8463850
    }

    public class InternalRemotingServices : Object
    {
        public System.Collections.Hashtable _soapAttributes;

        // ── Methods ──
        public void GetCachedSoapAttribute(){} // RVA: 0x7FFAC8463C20
        public void .cctor(){} // RVA: 0x7FFAC8464210
    }

    public class ObjRef : Object
    {
        public System.Runtime.Remoting.IChannelInfo IsReferenceToWellKnow; // 0x10
        public string ChannelInfo; // 0x18
        public System.Runtime.Remoting.IRemotingTypeInfo EnvoyInfo; // 0x20
        public System.Runtime.Remoting.IEnvoyInfo TypeInfo; // 0x28
        public int URI; // 0x30
        public System.Type ServerType; // 0x38
        public int MarshalledObjectRef;
        public int WellKnowObjectRef; // 0x4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84648C0 | overloaded x4
        public void DeserializeInTheCurrentDomain(){} // RVA: 0x7FFAC84643A0
        public void SerializeType(){} // RVA: 0x7FFAC8464650
        public void get_IsReferenceToWellKnow(){} // RVA: 0x7FFAC84651C0
        public void get_ChannelInfo(){} // RVA: 0x7FFAC2F3C380
        public void get_EnvoyInfo(){} // RVA: 0x7FFAC2F4F130
        public void set_EnvoyInfo(){} // RVA: 0x7FFAC2F22E90
        public void get_TypeInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void set_TypeInfo(){} // RVA: 0x7FFAC2F4F0D0
        public void get_URI(){} // RVA: 0x7FFAC2F247C0
        public void set_URI(){} // RVA: 0x7FFAC2F87E80
        public void GetObjectData(){} // RVA: 0x7FFAC8465220
        public void GetRealObject(){} // RVA: 0x7FFAC8465890
        public void UpdateChannelInfo(){} // RVA: 0x7FFAC8465970
        public void get_ServerType(){} // RVA: 0x7FFAC8465AB0
        public void .cctor(){} // RVA: 0x7FFAC8465BE0
    }

    public class ProviderData : Object
    {
        public string Ref; // 0x10
        public string Type; // 0x18
        public string Id; // 0x20
        public System.Collections.Hashtable CustomProperties; // 0x28
        public System.Collections.IList CustomData; // 0x30

        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x7FFAC846DF40
        public void .ctor(){} // RVA: 0x7FFAC846E6A0
    }

    public class RemotingConfiguration : Object
    {
        public string ApplicationName;
        public string ProcessId; // 0x8
        public string processGuid; // 0x10
        public bool defaultConfigRead; // 0x18
        public bool defaultDelayedConfigRead; // 0x19
        public 0x6B0CF670 _errorMode; // 0x1C
        public System.Collections.Hashtable wellKnownClientEntries; // 0x20
        public System.Collections.Hashtable activatedClientEntries; // 0x28
        public System.Collections.Hashtable wellKnownServiceEntries; // 0x30
        public System.Collections.Hashtable activatedServiceEntries; // 0x38
        public System.Collections.Hashtable channelTemplates; // 0x40
        public System.Collections.Hashtable clientProviderTemplates; // 0x48
        public System.Collections.Hashtable serverProviderTemplates; // 0x50

        // ── Methods ──
        public void get_ApplicationName(){} // RVA: 0x7FFAC8465C40
        public void set_ApplicationName(){} // RVA: 0x7FFAC8465CA0
        public void get_ProcessId(){} // RVA: 0x7FFAC8465D60
        public void LoadDefaultDelayedChannels(){} // RVA: 0x7FFAC8465EE0
        public void IsActivationAllowed(){} // RVA: 0x7FFAC84663F0
        public void IsRemotelyActivatedClientType(){} // RVA: 0x7FFAC84665F0
        public void IsWellKnownClientType(){} // RVA: 0x7FFAC8466840
        public void RegisterActivatedClientType(){} // RVA: 0x7FFAC8466A90
        public void RegisterActivatedServiceType(){} // RVA: 0x7FFAC8466DB0
        public void RegisterWellKnownClientType(){} // RVA: 0x7FFAC8466F90
        public void RegisterWellKnownServiceType(){} // RVA: 0x7FFAC84672B0
        public void RegisterChannelTemplate(){} // RVA: 0x7FFAC84674E0
        public void RegisterClientProviderTemplate(){} // RVA: 0x7FFAC8467570
        public void RegisterServerProviderTemplate(){} // RVA: 0x7FFAC8467600
        public void RegisterChannels(){} // RVA: 0x7FFAC8467690
        public void RegisterTypes(){} // RVA: 0x7FFAC8467F80
        public void CustomErrorsEnabled(){} // RVA: 0x7FFAC8468430
        public void SetCustomErrorsMode(){} // RVA: 0x7FFAC84684C0
        public void .cctor(){} // RVA: 0x7FFAC84687B0
    }

    public class RemotingException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F75C0 | overloaded x4
    }

    public class RemotingServices : Object
    {
        public System.Collections.Hashtable uri_hash;
        public System.Runtime.Serialization.Formatters.Binary.BinaryFormatter _serializationFormatter; // 0x8
        public System.Runtime.Serialization.Formatters.Binary.BinaryFormatter _deserializationFormatter; // 0x10
        public string app_id; // 0x18
        public object app_id_lock; // 0x20
        public int next_id; // 0x28
        public System.Reflection.MethodInfo FieldSetterMethod; // 0x30
        public System.Reflection.MethodInfo FieldGetterMethod; // 0x38

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC846E760
        public void InternalExecute(){} // RVA: 0x7FFAC846EED0
        public void GetVirtualMethod(){} // RVA: 0x7FFAC846EEE0
        public void IsTransparentProxy(){} // RVA: 0x7FFAC846EEF0
        public void InternalExecuteMessage(){} // RVA: 0x7FFAC846EF30
        public void Connect(){} // RVA: 0x7FFAC846F360 | overloaded x2
        public void GetServerTypeForUri(){} // RVA: 0x7FFAC846F410
        public void Unmarshal(){} // RVA: 0x7FFAC846F530 | overloaded x2
        public void Marshal(){} // RVA: 0x7FFAC846F970 | overloaded x2
        public void NewUri(){} // RVA: 0x7FFAC846F9F0
        public void GetRealProxy(){} // RVA: 0x7FFAC846FF70
        public void GetMethodBaseFromMethodMessage(){} // RVA: 0x7FFAC846FFC0
        public void GetMethodBaseFromName(){} // RVA: 0x7FFAC84701D0
        public void FindInterfaceMethod(){} // RVA: 0x7FFAC8470500
        public void GetObjectData(){} // RVA: 0x7FFAC8470720
        public void IsOneWay(){} // RVA: 0x7FFAC84707D0
        public void CreateClientProxy(){} // RVA: 0x7FFAC8470C10 | overloaded x3
        public void CreateClientProxyForContextBound(){} // RVA: 0x7FFAC8470D00
        public void GetIdentityForUri(){} // RVA: 0x7FFAC8470ED0
        public void RemoveAppNameFromUri(){} // RVA: 0x7FFAC8471310
        public void GetOrCreateClientIdentity(){} // RVA: 0x7FFAC8471420
        public void GetClientChannelSinkChain(){} // RVA: 0x7FFAC8471E40
        public void CreateContextBoundObjectIdentity(){} // RVA: 0x7FFAC8471F70
        public void CreateClientActivatedServerIdentity(){} // RVA: 0x7FFAC84720A0
        public void CreateWellKnownServerIdentity(){} // RVA: 0x7FFAC8472150
        public void RegisterServerIdentity(){} // RVA: 0x7FFAC84722A0
        public void GetProxyForRemoteObject(){} // RVA: 0x7FFAC8472560
        public void GetRemoteObject(){} // RVA: 0x7FFAC8472680
        public void SerializeCallData(){} // RVA: 0x7FFAC8472700
        public void DeserializeCallData(){} // RVA: 0x7FFAC8472B80
        public void SerializeExceptionData(){} // RVA: 0x7FFAC8472EF0
        public void RegisterInternalChannels(){} // RVA: 0x7FFAC84731F0
        public void DisposeIdentity(){} // RVA: 0x7FFAC8473240
        public void GetMessageTargetIdentity(){} // RVA: 0x7FFAC8473560
        public void SetMessageTargetIdentity(){} // RVA: 0x7FFAC8473980
        public void UpdateOutArgObject(){} // RVA: 0x7FFAC8473A40
        public void GetNormalizedUri(){} // RVA: 0x7FFAC8473C60
    }

    public class ServerIdentity : Identity
    {
        public System.Type ObjectType; // 0x48
        public System.MarshalByRefObject Lease; // 0x50
        public System.Runtime.Remoting.Messaging.IMessageSink Context; // 0x58
        public System.Runtime.Remoting.Contexts.Context _context; // 0x60
        public System.Runtime.Remoting.Lifetime.Lease _lease; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8473CD0
        public void get_ObjectType(){} // RVA: 0x7FFAC2F9C730
        public void StartTrackingLifetime(){} // RVA: 0x7FFAC8473DF0
        public void OnLifetimeExpired(){} // RVA: 0x7FFAC8474180
        public void CreateObjRef(){} // RVA: 0x7FFAC84741E0
        public void AttachServerObject(){} // RVA: 0x7FFAC8474460
        public void get_Lease(){} // RVA: 0x7FFAC2F9CD50
        public void get_Context(){} // RVA: 0x7FFAC2FBF370
        public void set_Context(){} // RVA: 0x7FFAC2FBF380
        public void SyncObjectProcessMessage(){} // RVA: 0x7FFAC2C58F40
        public void AsyncObjectProcessMessage(){} // RVA: 0x7FFAC2C6A6F0
        public void DisposeServerObject(){} // RVA: 0x7FFAC8474180
    }

    public class SingleCallIdentity : ServerIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8474750
        public void SyncObjectProcessMessage(){} // RVA: 0x7FFAC8474B00
        public void AsyncObjectProcessMessage(){} // RVA: 0x7FFAC8474B70
    }

    public class SingletonIdentity : ServerIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8474750
        public void GetServerObject(){} // RVA: 0x7FFAC8474760
        public void SyncObjectProcessMessage(){} // RVA: 0x7FFAC8474940
        public void AsyncObjectProcessMessage(){} // RVA: 0x7FFAC8474A10
    }

    public class SoapServices : Object
    {
        public System.Collections.Hashtable XmlNsForClrTypeWithAssembly;
        public System.Collections.Hashtable XmlNsForClrTypeWithNs; // 0x8
        public System.Collections.Hashtable XmlNsForClrTypeWithNsAndAssembly; // 0x10
        public System.Collections.Hashtable _soapActionsMethods; // 0x18
        public System.Collections.Hashtable _typeInfos; // 0x20

        // ── Methods ──
        public void get_XmlNsForClrTypeWithAssembly(){} // RVA: 0x7FFAC8474E70
        public void get_XmlNsForClrTypeWithNs(){} // RVA: 0x7FFAC8474EB0
        public void get_XmlNsForClrTypeWithNsAndAssembly(){} // RVA: 0x7FFAC8474EF0
        public void CodeXmlNamespaceForClrTypeNamespace(){} // RVA: 0x7FFAC8474F30
        public void GetNameKey(){} // RVA: 0x7FFAC8475140
        public void GetAssemblyName(){} // RVA: 0x7FFAC84751B0
        public void GetXmlElementForInteropType(){} // RVA: 0x7FFAC84753B0
        public void GetXmlNamespaceForMethodCall(){} // RVA: 0x7FFAC84755D0
        public void GetXmlNamespaceForMethodResponse(){} // RVA: 0x7FFAC8475680
        public void GetXmlTypeForInteropType(){} // RVA: 0x7FFAC8475730
        public void PreLoad(){} // RVA: 0x7FFAC8475A00 | overloaded x2
        public void RegisterInteropXmlElement(){} // RVA: 0x7FFAC8476000
        public void RegisterInteropXmlType(){} // RVA: 0x7FFAC8476240
        public void EncodeNs(){} // RVA: 0x7FFAC8476480
        public void .cctor(){} // RVA: 0x7FFAC8476570
    }

    public class TypeEntry : Object
    {
        public string AssemblyName; // 0x10
        public string TypeName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_AssemblyName(){} // RVA: 0x7FFAC2F3C380
        public void set_AssemblyName(){} // RVA: 0x7FFAC2F22E30
        public void get_TypeName(){} // RVA: 0x7FFAC2F247C0
        public void set_TypeName(){} // RVA: 0x7FFAC2F87E80
    }

    public class TypeInfo : Object
    {
        public string TypeName; // 0x10
        public string[] serverHierarchy; // 0x18
        public string[] interfacesImplemented; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84768A0
        public void get_TypeName(){} // RVA: 0x7FFAC2F3C380
        public void CanCastTo(){} // RVA: 0x7FFAC8476FA0
    }

    public class WellKnownClientTypeEntry : TypeEntry
    {
        public System.Type ApplicationUrl; // 0x20
        public string ObjectType; // 0x28
        public string ObjectUrl; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8477250
        public void get_ApplicationUrl(){} // RVA: 0x7FFAC31D95E0
        public void get_ObjectType(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ObjectUrl(){} // RVA: 0x7FFAC2F4F130
        public void ToString(){} // RVA: 0x7FFAC84774F0
    }

    public class WellKnownServiceTypeEntry : TypeEntry
    {
        public System.Type Mode; // 0x20
        public string ObjectType; // 0x28
        public 0x6B0CFFB8 ObjectUri; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8477530
        public void get_Mode(){} // RVA: 0x7FFAC2F7CCD0
        public void get_ObjectType(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ObjectUri(){} // RVA: 0x7FFAC2F4F130
        public void ToString(){} // RVA: 0x7FFAC84777E0
    }

}