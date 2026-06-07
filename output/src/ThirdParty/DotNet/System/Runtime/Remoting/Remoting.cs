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
        public void .ctor(){} // RVA: 0x5CCBBA0
        public void get_ApplicationUrl(){} // RVA: 0x30B0C0
        public void get_ContextAttributes(){} // RVA: 0x519240
        public void get_ObjectType(){} // RVA: 0x30B130
        public void ToString(){} // RVA: 0x5CCBE40
    }

    public class ActivatedServiceTypeEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CCBE60
        public void get_ObjectType(){} // RVA: 0x30B0C0
        public void ToString(){} // RVA: 0x5CCC0B0
    }

    public class ChannelData
    {
        // ── Methods ──
        public void get_ServerProviders(){} // RVA: 0x5CD5C30
        public void get_ClientProviders(){} // RVA: 0x5CD5CE0
        public void get_CustomProperties(){} // RVA: 0x5CD5D90
        public void CopyFrom(){} // RVA: 0x5CD5E40
        public void .ctor(){} // RVA: 0x5CD67A0
    }

    public class ChannelInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CCBAB0 | overloaded x2
        public void get_ChannelData(){} // RVA: 0x2F8380
    }

    public class ClientActivatedIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CDCEE0
        public void GetServerObject(){} // RVA: 0x37E0E0
        public void SetClientProxy(){} // RVA: 0x3A55A0
        public void OnLifetimeExpired(){} // RVA: 0x5CDCF00
        public void SyncObjectProcessMessage(){} // RVA: 0x5CDCF90
        public void AsyncObjectProcessMessage(){} // RVA: 0x5CDD070
    }

    public class ClientIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CCC300
        public void get_ClientProxy(){} // RVA: 0x5CCC4B0
        public void set_ClientProxy(){} // RVA: 0x5CCC540
        public void CreateObjRef(){} // RVA: 0x4976A0
        public void get_TargetUri(){} // RVA: 0x5CCC600
    }

    public class ConfigHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CD1790
        public void ValidatePath(){} // RVA: 0x5CD1950
        public void CheckPath(){} // RVA: 0x5CD1A40
        public void OnStartParsing(){} // RVA: 0x2DD310
        public void OnProcessingInstruction(){} // RVA: 0x2DD310
        public void OnIgnorableWhitespace(){} // RVA: 0x2DD310
        public void OnStartElement(){} // RVA: 0x5CD1BE0
        public void ParseElement(){} // RVA: 0x5CD1D80
        public void OnEndElement(){} // RVA: 0x5CD3160
        public void ReadCustomProviderData(){} // RVA: 0x5CD32B0
        public void ReadLifetine(){} // RVA: 0x5CD36B0
        public void ParseTime(){} // RVA: 0x5CD3B70
        public void ReadChannel(){} // RVA: 0x5CD4020
        public void ReadProvider(){} // RVA: 0x5CD47D0
        public void ReadClientActivated(){} // RVA: 0x5CD4DD0
        public void ReadServiceActivated(){} // RVA: 0x5CD4F60
        public void ReadClientWellKnown(){} // RVA: 0x5CD5040
        public void ReadServiceWellKnown(){} // RVA: 0x5CD5150
        public void ReadInteropXml(){} // RVA: 0x5CD53B0
        public void ReadPreload(){} // RVA: 0x5CD55D0
        public void GetNotNull(){} // RVA: 0x5CD5870
        public void ExtractAssembly(){} // RVA: 0x5CD5980
        public void OnChars(){} // RVA: 0x2DD310
        public void OnEndParsing(){} // RVA: 0x5CD5AD0
    }

    public class DisposerReplySink
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void SyncProcessMessage(){} // RVA: 0x5CDD7B0
        public void AsyncProcessMessage(){} // RVA: 0x5CDD840
    }

    public class EnvoyInfo : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_EnvoySinks(){} // RVA: 0x2F8380
    }

    public class FormatterData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CD7160
    }

    public class IChannelInfo
    {
        // ── Methods ──
        public void get_ChannelData(){} // RVA: 0xCD60
    }

    public class IEnvoyInfo
    {
        // ── Methods ──
        public void get_EnvoySinks(){} // RVA: 0xCD60
    }

    public class IRemotingTypeInfo
    {
        // ── Methods ──
        public void get_TypeName(){} // RVA: 0xCD60
        public void CanCastTo(){} // RVA: 0x11120
    }

    public class Identity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void CreateObjRef(){} // RVA: 0xCE10
        public void get_ChannelSink(){} // RVA: 0x2E07C0
        public void set_ChannelSink(){} // RVA: 0x343E80
        public void get_EnvoySink(){} // RVA: 0x30B0C0
        public void get_ObjectUri(){} // RVA: 0x2F8380
        public void set_ObjectUri(){} // RVA: 0x2DEE30
        public void get_IsConnected(){} // RVA: 0xF01170
        public void get_Disposed(){} // RVA: 0x398C00
        public void set_Disposed(){} // RVA: 0x398C10
        public void get_ClientDynamicProperties(){} // RVA: 0x5CCC0C0
        public void get_HasServerDynamicSinks(){} // RVA: 0x5CCC170
        public void NotifyClientDynamicSinks(){} // RVA: 0x5CCC1C0
        public void NotifyServerDynamicSinks(){} // RVA: 0x5CCC260
    }

    public class InternalRemotingServices
    {
        // ── Methods ──
        public void GetCachedSoapAttribute(){} // RVA: 0x5CCC630
        public void .cctor(){} // RVA: 0x5CCCC20
    }

    public class ObjRef
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CCD2D0 | overloaded x4
        public void DeserializeInTheCurrentDomain(){} // RVA: 0x5CCCDB0
        public void SerializeType(){} // RVA: 0x5CCD060
        public void get_IsReferenceToWellKnow(){} // RVA: 0x5CCDBD0
        public void get_ChannelInfo(){} // RVA: 0x2F8380
        public void get_EnvoyInfo(){} // RVA: 0x30B130
        public void set_EnvoyInfo(){} // RVA: 0x2DEE90
        public void get_TypeInfo(){} // RVA: 0x30B0C0
        public void set_TypeInfo(){} // RVA: 0x30B0D0
        public void get_URI(){} // RVA: 0x2E07C0
        public void set_URI(){} // RVA: 0x343E80
        public void GetObjectData(){} // RVA: 0x5CCDC30
        public void GetRealObject(){} // RVA: 0x5CCE2A0
        public void UpdateChannelInfo(){} // RVA: 0x5CCE380
        public void get_ServerType(){} // RVA: 0x5CCE4C0
        public void .cctor(){} // RVA: 0x5CCE5F0
    }

    public class ProviderData
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x5CD6950
        public void .ctor(){} // RVA: 0x5CD70B0
    }

    public class RemotingConfiguration
    {
        // ── Methods ──
        public void get_ApplicationName(){} // RVA: 0x5CCE650
        public void set_ApplicationName(){} // RVA: 0x5CCE6B0
        public void get_ProcessId(){} // RVA: 0x5CCE770
        public void LoadDefaultDelayedChannels(){} // RVA: 0x5CCE8F0
        public void IsActivationAllowed(){} // RVA: 0x5CCEE00
        public void IsRemotelyActivatedClientType(){} // RVA: 0x5CCF000
        public void IsWellKnownClientType(){} // RVA: 0x5CCF250
        public void RegisterActivatedClientType(){} // RVA: 0x5CCF4A0
        public void RegisterActivatedServiceType(){} // RVA: 0x5CCF7C0
        public void RegisterWellKnownClientType(){} // RVA: 0x5CCF9A0
        public void RegisterWellKnownServiceType(){} // RVA: 0x5CCFCC0
        public void RegisterChannelTemplate(){} // RVA: 0x5CCFEF0
        public void RegisterClientProviderTemplate(){} // RVA: 0x5CCFF80
        public void RegisterServerProviderTemplate(){} // RVA: 0x5CD0010
        public void RegisterChannels(){} // RVA: 0x5CD00A0
        public void RegisterTypes(){} // RVA: 0x5CD0990
        public void CustomErrorsEnabled(){} // RVA: 0x5CD0E40
        public void SetCustomErrorsMode(){} // RVA: 0x5CD0ED0
        public void .cctor(){} // RVA: 0x5CD11C0
    }

    public class RemotingException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E250 | overloaded x4
    }

    public class RemotingServices
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5CD7170
        public void InternalExecute(){} // RVA: 0x5CD78E0
        public void GetVirtualMethod(){} // RVA: 0x5CD78F0
        public void IsTransparentProxy(){} // RVA: 0x5CD7900
        public void InternalExecuteMessage(){} // RVA: 0x5CD7940
        public void Connect(){} // RVA: 0x5CD7D70 | overloaded x2
        public void GetServerTypeForUri(){} // RVA: 0x5CD7E20
        public void Unmarshal(){} // RVA: 0x5CD7F40 | overloaded x2
        public void Marshal(){} // RVA: 0x5CD8380 | overloaded x2
        public void NewUri(){} // RVA: 0x5CD8400
        public void GetRealProxy(){} // RVA: 0x5CD8980
        public void GetMethodBaseFromMethodMessage(){} // RVA: 0x5CD89D0
        public void GetMethodBaseFromName(){} // RVA: 0x5CD8BE0
        public void FindInterfaceMethod(){} // RVA: 0x5CD8F10
        public void GetObjectData(){} // RVA: 0x5CD9130
        public void IsOneWay(){} // RVA: 0x5CD91E0
        public void CreateClientProxy(){} // RVA: 0x5CD9620 | overloaded x3
        public void CreateClientProxyForContextBound(){} // RVA: 0x5CD9710
        public void GetIdentityForUri(){} // RVA: 0x5CD98E0
        public void RemoveAppNameFromUri(){} // RVA: 0x5CD9D20
        public void GetOrCreateClientIdentity(){} // RVA: 0x5CD9E30
        public void GetClientChannelSinkChain(){} // RVA: 0x5CDA850
        public void CreateContextBoundObjectIdentity(){} // RVA: 0x5CDA980
        public void CreateClientActivatedServerIdentity(){} // RVA: 0x5CDAAB0
        public void CreateWellKnownServerIdentity(){} // RVA: 0x5CDAB60
        public void RegisterServerIdentity(){} // RVA: 0x5CDACB0
        public void GetProxyForRemoteObject(){} // RVA: 0x5CDAF70
        public void GetRemoteObject(){} // RVA: 0x5CDB090
        public void SerializeCallData(){} // RVA: 0x5CDB110
        public void DeserializeCallData(){} // RVA: 0x5CDB590
        public void SerializeExceptionData(){} // RVA: 0x5CDB900
        public void RegisterInternalChannels(){} // RVA: 0x5CDBC00
        public void DisposeIdentity(){} // RVA: 0x5CDBC50
        public void GetMessageTargetIdentity(){} // RVA: 0x5CDBF70
        public void SetMessageTargetIdentity(){} // RVA: 0x5CDC390
        public void UpdateOutArgObject(){} // RVA: 0x5CDC450
        public void GetNormalizedUri(){} // RVA: 0x5CDC670
    }

    public class ServerIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CDC6E0
        public void get_ObjectType(){} // RVA: 0x358730
        public void StartTrackingLifetime(){} // RVA: 0x5CDC800
        public void OnLifetimeExpired(){} // RVA: 0x5CDCB90
        public void CreateObjRef(){} // RVA: 0x5CDCBF0
        public void AttachServerObject(){} // RVA: 0x5CDCE70
        public void get_Lease(){} // RVA: 0x358D50
        public void get_Context(){} // RVA: 0x37B370
        public void set_Context(){} // RVA: 0x37B380
        public void SyncObjectProcessMessage(){} // RVA: 0xCE10
        public void AsyncObjectProcessMessage(){} // RVA: 0x1E6A0
        public void DisposeServerObject(){} // RVA: 0x5CDCB90
    }

    public class SingleCallIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CDD160
        public void SyncObjectProcessMessage(){} // RVA: 0x5CDD510
        public void AsyncObjectProcessMessage(){} // RVA: 0x5CDD580
    }

    public class SingletonIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CDD160
        public void GetServerObject(){} // RVA: 0x5CDD170
        public void SyncObjectProcessMessage(){} // RVA: 0x5CDD350
        public void AsyncObjectProcessMessage(){} // RVA: 0x5CDD420
    }

    public class SoapServices
    {
        public object TypeName;

        // ── Methods ──
        public void get_XmlNsForClrTypeWithAssembly(){} // RVA: 0x5CDD880
        public void get_XmlNsForClrTypeWithNs(){} // RVA: 0x5CDD8C0
        public void get_XmlNsForClrTypeWithNsAndAssembly(){} // RVA: 0x5CDD900
        public void CodeXmlNamespaceForClrTypeNamespace(){} // RVA: 0x5CDD940
        public void GetNameKey(){} // RVA: 0x5CDDB50
        public void GetAssemblyName(){} // RVA: 0x5CDDBC0
        public void GetXmlElementForInteropType(){} // RVA: 0x5CDDDC0
        public void GetXmlNamespaceForMethodCall(){} // RVA: 0x5CDDFE0
        public void GetXmlNamespaceForMethodResponse(){} // RVA: 0x5CDE090
        public void GetXmlTypeForInteropType(){} // RVA: 0x5CDE140
        public void PreLoad(){} // RVA: 0x5CDE410 | overloaded x2
        public void RegisterInteropXmlElement(){} // RVA: 0x5CDEA10
        public void RegisterInteropXmlType(){} // RVA: 0x5CDEC50
        public void EncodeNs(){} // RVA: 0x5CDEE90
        public void .cctor(){} // RVA: 0x5CDEF80
    }

    public class TypeEntry
    {
        public object ObjectType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_AssemblyName(){} // RVA: 0x2F8380
        public void set_AssemblyName(){} // RVA: 0x2DEE30
        public void get_TypeName(){} // RVA: 0x2E07C0
        public void set_TypeName(){} // RVA: 0x343E80
    }

    public class TypeInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CDF2B0
        public void get_TypeName(){} // RVA: 0x2F8380
        public void CanCastTo(){} // RVA: 0x5CDF9B0
    }

    public class WellKnownClientTypeEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CDFC60
        public void get_ApplicationUrl(){} // RVA: 0x6374D0
        public void get_ObjectType(){} // RVA: 0x30B0C0
        public void get_ObjectUrl(){} // RVA: 0x30B130
        public void ToString(){} // RVA: 0x5CDFF00
    }

    public class WellKnownServiceTypeEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CDFF40
        public void get_Mode(){} // RVA: 0x338CD0
        public void get_ObjectType(){} // RVA: 0x30B0C0
        public void get_ObjectUri(){} // RVA: 0x30B130
        public void ToString(){} // RVA: 0x5CE01F0
    }

}