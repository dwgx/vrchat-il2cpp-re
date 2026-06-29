// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting
// Classes: 28
// Methods: 203

namespace ThirdParty.DotNet.System.Runtime.Remoting
{
    public class ActivatedClientTypeEntry : TypeEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAB9DF0
        public void get_ApplicationUrl(){} // RVA: 0x7A81052C0
        public void get_ContextAttributes(){} // RVA: 0x7A82D1450
        public void get_ObjectType(){} // RVA: 0x7A8105330
        public void ToString(){} // RVA: 0x7ADABA090
    }

    public class ActivatedServiceTypeEntry : TypeEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADABA0B0
        public void get_ObjectType(){} // RVA: 0x7A81052C0
        public void ToString(){} // RVA: 0x7ADABA300
    }

    public class ChannelData : Object
    {
        // ── Methods ──
        public void get_ServerProviders(){} // RVA: 0x7ADAC3D30
        public void get_ClientProviders(){} // RVA: 0x7ADAC3DE0
        public void get_CustomProperties(){} // RVA: 0x7ADAC3E90
        public void CopyFrom(){} // RVA: 0x7ADAC3F40
        public void .ctor(){} // RVA: 0x7ADAC4860
    }

    public class ChannelInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAB9D00
        public void get_ChannelData(){} // RVA: 0x7A80F2570
    }

    public class ClientActivatedIdentity : ServerIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADACADC0
        public void GetServerObject(){} // RVA: 0x7A8178B90
        public void SetClientProxy(){} // RVA: 0x7A81A00F0
        public void OnLifetimeExpired(){} // RVA: 0x7ADACADE0
        public void SyncObjectProcessMessage(){} // RVA: 0x7ADACAE70
        public void AsyncObjectProcessMessage(){} // RVA: 0x7ADACAF50
    }

    public class ClientIdentity : Identity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADABA550
        public void get_ClientProxy(){} // RVA: 0x7ADABA700
        public void set_ClientProxy(){} // RVA: 0x7ADABA790
        public void CreateObjRef(){} // RVA: 0x7A8292C30
        public void get_TargetUri(){} // RVA: 0x7ADABA850
    }

    public class ConfigHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADABF7E0
        public void ValidatePath(){} // RVA: 0x7ADABF9A0
        public void CheckPath(){} // RVA: 0x7ADABFA90
        public void OnStartParsing(){} // RVA: 0x7A80D7310
        public void OnProcessingInstruction(){} // RVA: 0x7A80D7310
        public void OnIgnorableWhitespace(){} // RVA: 0x7A80D7310
        public void OnStartElement(){} // RVA: 0x7ADABFC30
        public void ParseElement(){} // RVA: 0x7ADABFDD0
        public void OnEndElement(){} // RVA: 0x7ADAC11C0
        public void ReadCustomProviderData(){} // RVA: 0x7ADAC1310
        public void ReadLifetine(){} // RVA: 0x7ADAC1710
        public void ParseTime(){} // RVA: 0x7ADAC1BF0
        public void ReadChannel(){} // RVA: 0x7ADAC20A0
        public void ReadProvider(){} // RVA: 0x7ADAC2860
        public void ReadClientActivated(){} // RVA: 0x7ADAC2E80
        public void ReadServiceActivated(){} // RVA: 0x7ADAC3020
        public void ReadClientWellKnown(){} // RVA: 0x7ADAC3110
        public void ReadServiceWellKnown(){} // RVA: 0x7ADAC3230
        public void ReadInteropXml(){} // RVA: 0x7ADAC34A0
        public void ReadPreload(){} // RVA: 0x7ADAC36C0
        public void GetNotNull(){} // RVA: 0x7ADAC3970
        public void ExtractAssembly(){} // RVA: 0x7ADAC3A80
        public void OnChars(){} // RVA: 0x7A80D7310
        public void OnEndParsing(){} // RVA: 0x7ADAC3BD0
    }

    public class DisposerReplySink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void SyncProcessMessage(){} // RVA: 0x7ADACB680
        public void AsyncProcessMessage(){} // RVA: 0x7ADACB710
    }

    public class EnvoyInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_EnvoySinks(){} // RVA: 0x7A80F2570
    }

    public class FormatterData : ProviderData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAC5200
    }

    public class IChannelInfo
    {
        // ── Methods ──
        public void get_ChannelData(){} // RVA: 0x7A7E00680
    }

    public class IEnvoyInfo
    {
        // ── Methods ──
        public void get_EnvoySinks(){} // RVA: 0x7A7E00680
    }

    public class IRemotingTypeInfo
    {
        // ── Methods ──
        public void get_TypeName(){} // RVA: 0x7A7E00680
        public void CanCastTo(){} // RVA: 0x7A7E01A40
    }

    public class Identity : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void CreateObjRef(){} // RVA: 0x7A7E00B20
        public void get_ChannelSink(){} // RVA: 0x7A80DA7B0
        public void set_ChannelSink(){} // RVA: 0x7A813E420
        public void get_EnvoySink(){} // RVA: 0x7A81052C0
        public void get_ObjectUri(){} // RVA: 0x7A80F2570
        public void set_ObjectUri(){} // RVA: 0x7A80D8E20
        public void get_IsConnected(){} // RVA: 0x7A8CCB4F0
        public void get_Disposed(){} // RVA: 0x7A8193790
        public void set_Disposed(){} // RVA: 0x7A81937A0
        public void get_ClientDynamicProperties(){} // RVA: 0x7ADABA310
        public void get_HasServerDynamicSinks(){} // RVA: 0x7ADABA3C0
        public void NotifyClientDynamicSinks(){} // RVA: 0x7ADABA410
        public void NotifyServerDynamicSinks(){} // RVA: 0x7ADABA4B0
    }

    public class InternalRemotingServices : Object
    {
        // ── Methods ──
        public void GetCachedSoapAttribute(){} // RVA: 0x7ADABA880
        public void .cctor(){} // RVA: 0x7ADABAE30
    }

    public class ObjRef : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADABB500
        public void DeserializeInTheCurrentDomain(){} // RVA: 0x7ADABAFC0
        public void SerializeType(){} // RVA: 0x7ADABB280
        public void get_IsReferenceToWellKnow(){} // RVA: 0x7ADABBE00
        public void get_ChannelInfo(){} // RVA: 0x7A80F2570
        public void get_EnvoyInfo(){} // RVA: 0x7A8105330
        public void set_EnvoyInfo(){} // RVA: 0x7A80D8E80
        public void get_TypeInfo(){} // RVA: 0x7A81052C0
        public void set_TypeInfo(){} // RVA: 0x7A81052D0
        public void get_URI(){} // RVA: 0x7A80DA7B0
        public void set_URI(){} // RVA: 0x7A813E420
        public void GetObjectData(){} // RVA: 0x7ADABBE60
        public void GetRealObject(){} // RVA: 0x7ADABC4D0
        public void UpdateChannelInfo(){} // RVA: 0x7ADABC5B0
        public void get_ServerType(){} // RVA: 0x7ADABC6F0
        public void .cctor(){} // RVA: 0x7ADABC820
    }

    public class ProviderData : Object
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x7ADAC4A10
        public void .ctor(){} // RVA: 0x7ADAC5150
    }

    public class RemotingConfiguration : Object
    {
        // ── Methods ──
        public void get_ApplicationName(){} // RVA: 0x7ADABC880
        public void set_ApplicationName(){} // RVA: 0x7ADABC8E0
        public void get_ProcessId(){} // RVA: 0x7ADABC9A0
        public void LoadDefaultDelayedChannels(){} // RVA: 0x7ADABCB20
        public void IsActivationAllowed(){} // RVA: 0x7ADABD000
        public void IsRemotelyActivatedClientType(){} // RVA: 0x7ADABD1B0
        public void IsWellKnownClientType(){} // RVA: 0x7ADABD3C0
        public void RegisterActivatedClientType(){} // RVA: 0x7ADABD5D0
        public void RegisterActivatedServiceType(){} // RVA: 0x7ADABD8C0
        public void RegisterWellKnownClientType(){} // RVA: 0x7ADABDA70
        public void RegisterWellKnownServiceType(){} // RVA: 0x7ADABDD60
        public void RegisterChannelTemplate(){} // RVA: 0x7ADABDF70
        public void RegisterClientProviderTemplate(){} // RVA: 0x7ADABE000
        public void RegisterServerProviderTemplate(){} // RVA: 0x7ADABE090
        public void RegisterChannels(){} // RVA: 0x7ADABE120
        public void RegisterTypes(){} // RVA: 0x7ADABEA00
        public void CustomErrorsEnabled(){} // RVA: 0x7ADABEE90
        public void SetCustomErrorsMode(){} // RVA: 0x7ADABEF20
        public void .cctor(){} // RVA: 0x7ADABF210
    }

    public class RemotingException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F78F0
    }

    public class RemotingServices : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADAC5210
        public void InternalExecute(){} // RVA: 0x7ADAC5990
        public void GetVirtualMethod(){} // RVA: 0x7ADAC59A0
        public void IsTransparentProxy(){} // RVA: 0x7ADAC59B0
        public void InternalExecuteMessage(){} // RVA: 0x7ADAC59F0
        public void Connect(){} // RVA: 0x7ADAC5E20
        public void GetServerTypeForUri(){} // RVA: 0x7ADAC5ED0
        public void Unmarshal(){} // RVA: 0x7ADAC5FD0
        public void Marshal(){} // RVA: 0x7ADAC6410
        public void NewUri(){} // RVA: 0x7ADAC6490
        public void GetRealProxy(){} // RVA: 0x7ADAC69F0
        public void GetMethodBaseFromMethodMessage(){} // RVA: 0x7ADAC6A40
        public void GetMethodBaseFromName(){} // RVA: 0x7ADAC6C50
        public void FindInterfaceMethod(){} // RVA: 0x7ADAC6F80
        public void GetObjectData(){} // RVA: 0x7ADAC71B0
        public void IsOneWay(){} // RVA: 0x7ADAC7260
        public void CreateClientProxy(){} // RVA: 0x7ADAC76A0
        public void CreateClientProxyForContextBound(){} // RVA: 0x7ADAC7790
        public void GetIdentityForUri(){} // RVA: 0x7ADAC7960
        public void RemoveAppNameFromUri(){} // RVA: 0x7ADAC7D60
        public void GetOrCreateClientIdentity(){} // RVA: 0x7ADAC7E70
        public void GetClientChannelSinkChain(){} // RVA: 0x7ADAC8860
        public void CreateContextBoundObjectIdentity(){} // RVA: 0x7ADAC8990
        public void CreateClientActivatedServerIdentity(){} // RVA: 0x7ADAC8AC0
        public void CreateWellKnownServerIdentity(){} // RVA: 0x7ADAC8B70
        public void RegisterServerIdentity(){} // RVA: 0x7ADAC8CC0
        public void GetProxyForRemoteObject(){} // RVA: 0x7ADAC8F50
        public void GetRemoteObject(){} // RVA: 0x7ADAC9050
        public void SerializeCallData(){} // RVA: 0x7ADAC90D0
        public void DeserializeCallData(){} // RVA: 0x7ADAC9520
        public void SerializeExceptionData(){} // RVA: 0x7ADAC9850
        public void RegisterInternalChannels(){} // RVA: 0x7ADAC9B50
        public void DisposeIdentity(){} // RVA: 0x7ADAC9BA0
        public void GetMessageTargetIdentity(){} // RVA: 0x7ADAC9E90
        public void SetMessageTargetIdentity(){} // RVA: 0x7ADACA270
        public void UpdateOutArgObject(){} // RVA: 0x7ADACA330
        public void GetNormalizedUri(){} // RVA: 0x7ADACA550
    }

    public class ServerIdentity : Identity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADACA5C0
        public void get_ObjectType(){} // RVA: 0x7A8152D80
        public void StartTrackingLifetime(){} // RVA: 0x7ADACA6E0
        public void OnLifetimeExpired(){} // RVA: 0x7ADACAA70
        public void CreateObjRef(){} // RVA: 0x7ADACAAD0
        public void AttachServerObject(){} // RVA: 0x7ADACAD50
        public void get_Lease(){} // RVA: 0x7A8153390
        public void get_Context(){} // RVA: 0x7A8175DF0
        public void set_Context(){} // RVA: 0x7A8175E00
        public void SyncObjectProcessMessage(){} // RVA: 0x7A7E00B20
        public void AsyncObjectProcessMessage(){} // RVA: 0x7A7E00BD0
        public void DisposeServerObject(){} // RVA: 0x7ADACAA70
    }

    public class SingleCallIdentity : ServerIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADACB050
        public void SyncObjectProcessMessage(){} // RVA: 0x7ADACB3D0
        public void AsyncObjectProcessMessage(){} // RVA: 0x7ADACB440
    }

    public class SingletonIdentity : ServerIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADACB050
        public void GetServerObject(){} // RVA: 0x7ADACB060
        public void SyncObjectProcessMessage(){} // RVA: 0x7ADACB210
        public void AsyncObjectProcessMessage(){} // RVA: 0x7ADACB2E0
    }

    public class SoapServices : Object
    {
        // ── Methods ──
        public void get_XmlNsForClrTypeWithAssembly(){} // RVA: 0x7ADACB750
        public void get_XmlNsForClrTypeWithNs(){} // RVA: 0x7ADACB790
        public void get_XmlNsForClrTypeWithNsAndAssembly(){} // RVA: 0x7ADACB7D0
        public void CodeXmlNamespaceForClrTypeNamespace(){} // RVA: 0x7ADACB810
        public void GetNameKey(){} // RVA: 0x7ADACBA20
        public void GetAssemblyName(){} // RVA: 0x7ADACBA90
        public void GetXmlElementForInteropType(){} // RVA: 0x7ADACBC90
        public void GetXmlNamespaceForMethodCall(){} // RVA: 0x7ADACBEB0
        public void GetXmlNamespaceForMethodResponse(){} // RVA: 0x7ADACBF60
        public void GetXmlTypeForInteropType(){} // RVA: 0x7ADACC010
        public void PreLoad(){} // RVA: 0x7ADACC2E0
        public void RegisterInteropXmlElement(){} // RVA: 0x7ADACC8A0
        public void RegisterInteropXmlType(){} // RVA: 0x7ADACCAB0
        public void EncodeNs(){} // RVA: 0x7ADACCCC0
        public void .cctor(){} // RVA: 0x7ADACCDB0
    }

    public class TypeEntry : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_AssemblyName(){} // RVA: 0x7A80F2570
        public void set_AssemblyName(){} // RVA: 0x7A80D8E20
        public void get_TypeName(){} // RVA: 0x7A80DA7B0
        public void set_TypeName(){} // RVA: 0x7A813E420
    }

    public class TypeInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADACD0E0
        public void get_TypeName(){} // RVA: 0x7A80F2570
        public void CanCastTo(){} // RVA: 0x7ADACD800
    }

    public class WellKnownClientTypeEntry : TypeEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADACDAB0
        public void get_ApplicationUrl(){} // RVA: 0x7A83F69F0
        public void get_ObjectType(){} // RVA: 0x7A81052C0
        public void get_ObjectUrl(){} // RVA: 0x7A8105330
        public void ToString(){} // RVA: 0x7ADACDD50
    }

    public class WellKnownServiceTypeEntry : TypeEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADACDD90
        public void get_Mode(){} // RVA: 0x7A8133100
        public void get_ObjectType(){} // RVA: 0x7A81052C0
        public void get_ObjectUri(){} // RVA: 0x7A8105330
        public void ToString(){} // RVA: 0x7ADACE040
    }

}