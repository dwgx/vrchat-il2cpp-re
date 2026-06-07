// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Messaging
// Classes: 44
// Methods: 301

namespace ThirdParty.DotNet.System.Runtime.Remoting.Messaging
{
    public class ArgInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CF4540
        public void GetInOutArgs(){} // RVA: 0x5CF47D0
    }

    public class AsyncResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_AsyncState(){} // RVA: 0x2F8380
        public void get_AsyncWaitHandle(){} // RVA: 0x5CF4930
        public void get_CompletedSynchronously(){} // RVA: 0x4A6500
        public void get_IsCompleted(){} // RVA: 0x4A7410
        public void get_EndInvokeCalled(){} // RVA: 0x14CEB40
        public void set_EndInvokeCalled(){} // RVA: 0x5CF4B50
        public void get_AsyncDelegate(){} // RVA: 0x30B0C0
        public void get_NextSink(){} // RVA: 0x519240
        public void AsyncProcessMessage(){} // RVA: 0x5CF4B60
        public void GetReplyMessage(){} // RVA: 0x3A5590
        public void SetMessageCtrl(){} // RVA: 0x358D60
        public void SetCompletedSynchronously(){} // RVA: 0x4A78C0
        public void EndInvoke(){} // RVA: 0x5CF4BA0
        public void SyncProcessMessage(){} // RVA: 0x5CF4D50
        public void get_CallMessage(){} // RVA: 0x37B370
        public void set_CallMessage(){} // RVA: 0x37B380
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x5CF4FC0
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x2DD310
        public void Invoke(){} // RVA: 0x5CF5100
    }

    public class CADArgHolder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
    }

    public class CADMessageBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CF5FA0
        public void GetMethod(){} // RVA: 0x5CF6080
        public void GetSignature(){} // RVA: 0x5CF6110
        public void MarshalProperties(){} // RVA: 0x5CF6320
        public void UnmarshalProperties(){} // RVA: 0x5CF6850
        public void IsPossibleToIgnoreMarshal(){} // RVA: 0x5CF69D0
        public void MarshalArgument(){} // RVA: 0x5CF6BC0
        public void UnmarshalArgument(){} // RVA: 0x5CF6D50
        public void MarshalArguments(){} // RVA: 0x5CF78F0
        public void UnmarshalArguments(){} // RVA: 0x5CF7A70
        public void SaveLogicalCallContext(){} // RVA: 0x5CF7BF0
        public void GetLogicalCallContext(){} // RVA: 0x5CF7D80
    }

    public class CADMethodCallMessage
    {
        public object PropertiesCount;

        // ── Methods ──
        public void get_Uri(){} // RVA: 0x4976A0
        public void Create(){} // RVA: 0x5CF7E20
        public void .ctor(){} // RVA: 0x5CF7EB0
        public void GetArguments(){} // RVA: 0x5CF8250
        public void GetArgs(){} // RVA: 0x5CF84B0
        public void get_PropertiesCount(){} // RVA: 0x760030
    }

    public class CADMethodRef
    {
        // ── Methods ──
        public void GetTypes(){} // RVA: 0x5CF53B0
        public void Resolve(){} // RVA: 0x5CF5550
        public void .ctor(){} // RVA: 0x5CF5B50
    }

    public class CADMethodReturnMessage
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x5CF84C0
        public void .ctor(){} // RVA: 0x5CF8550
        public void GetArguments(){} // RVA: 0x5CF8A70
        public void GetArgs(){} // RVA: 0x5CF84B0
        public void GetReturnValue(){} // RVA: 0x5CF8CD0
        public void GetException(){} // RVA: 0x5CF8CE0
        public void get_PropertiesCount(){} // RVA: 0x760030
    }

    public class CADObjRef
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CF5250
    }

    public class CallContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void SetCurrentCallContext(){} // RVA: 0x519240
        public void SetLogicalCallContext(){} // RVA: 0x5CF1EE0
        public void LogicalGetData(){} // RVA: 0x5CF1F80
        public void LogicalSetData(){} // RVA: 0x5CF20C0
    }

    public class CallContextRemotingData : ؄}e
    {
        // ── Methods ──
        public void get_LogicalCallID(){} // RVA: 0x2F8380
        public void set_LogicalCallID(){} // RVA: 0x2DEE30
        public void get_HasInfo(){} // RVA: 0xF01170
        public void Clone(){} // RVA: 0x5CF44A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CallContextSecurityData
    {
        // ── Methods ──
        public void get_HasInfo(){} // RVA: 0xF01170
        public void Clone(){} // RVA: 0x5CF4400
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ClientContextReplySink
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4CF2A0
        public void SyncProcessMessage(){} // RVA: 0x5CF9260
        public void AsyncProcessMessage(){} // RVA: 0x5CF9320
    }

    public class ClientContextTerminatorSink
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void SyncProcessMessage(){} // RVA: 0x5CF8D90
        public void AsyncProcessMessage(){} // RVA: 0x5CF8F50
    }

    public class ConstructionCall
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CF9460 | overloaded x2
        public void InitDictionary(){} // RVA: 0x5CF9520
        public void get_IsContextOk(){} // RVA: 0x134A670
        public void set_IsContextOk(){} // RVA: 0x1348E00
        public void get_ActivationType(){} // RVA: 0x5CF9720
        public void get_ActivationTypeName(){} // RVA: 0x31C010
        public void get_Activator(){} // RVA: 0x358D50
        public void set_Activator(){} // RVA: 0x358D60
        public void get_CallSiteActivationAttributes(){} // RVA: 0x3A5590
        public void SetActivationAttributes(){} // RVA: 0x3A55A0
        public void get_ContextProperties(){} // RVA: 0x5CF9830
        public void InitMethodProperty(){} // RVA: 0x5CF98E0
        public void GetObjectData(){} // RVA: 0x5CF9E10
        public void get_Properties(){} // RVA: 0x5CFA690
        public void get_SourceProxy(){} // RVA: 0xA1C8C0
        public void set_SourceProxy(){} // RVA: 0x9AA650
    }

    public class ConstructionCallDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CFA6D0
        public void GetMethodProperty(){} // RVA: 0x5CFA7F0
        public void SetMethodProperty(){} // RVA: 0x5CFAC00
        public void .cctor(){} // RVA: 0x5CFAF10
    }

    public class ConstructionResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CFB1B0 | overloaded x3
        public void get_Properties(){} // RVA: 0x5CFB240
    }

    public class EnvoyTerminatorSink
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x5CFB380
        public void AsyncProcessMessage(){} // RVA: 0x5CFB410
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5CFB4B0
    }

    public class ErrorMessage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CFB550
        public void get_ArgCount(){} // RVA: 0x519240
        public void get_Args(){} // RVA: 0x519240
        public void get_MethodBase(){} // RVA: 0x519240
        public void get_MethodName(){} // RVA: 0x5CFB5E0
        public void get_MethodSignature(){} // RVA: 0x519240
        public void get_Properties(){} // RVA: 0x519240
        public void get_TypeName(){} // RVA: 0x5CFB620
        public void get_Uri(){} // RVA: 0x2F8380
        public void GetArg(){} // RVA: 0x519240
        public void get_LogicalCallContext(){} // RVA: 0x519240
    }

    public class Header
    {
    }

    public class HeaderHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1B07170
        public void Invoke(){} // RVA: 0x338C60
    }

    public class IInternalMessage
    {
        // ── Methods ──
        public void get_TargetIdentity(){} // RVA: 0xCD60
        public void set_TargetIdentity(){} // RVA: 0x24B10
        public void get_Uri(){} // RVA: 0xCD60
        public void set_Uri(){} // RVA: 0x24B10
    }

    public class IMessage
    {
        // ── Methods ──
        public void get_Properties(){} // RVA: 0xCD60
    }

    public class IMessageCtrl
    {
    }

    public class IMessageSink
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0xCE10
        public void AsyncProcessMessage(){} // RVA: 0x1E6A0
    }

    public class IMethodCallMessage
    {
    }

    public class IMethodMessage
    {
        // ── Methods ──
        public void get_ArgCount(){} // RVA: 0xD840
        public void get_Args(){} // RVA: 0xCD60
        public void get_LogicalCallContext(){} // RVA: 0xCD60
        public void get_MethodBase(){} // RVA: 0xCD60
        public void get_MethodName(){} // RVA: 0xCD60
        public void get_MethodSignature(){} // RVA: 0xCD60
        public void get_TypeName(){} // RVA: 0xCD60
        public void get_Uri(){} // RVA: 0xCD60
        public void GetArg(){} // RVA: 0x1BCC0
    }

    public class IMethodReturnMessage
    {
        // ── Methods ──
        public void get_Exception(){} // RVA: 0xCD60
        public void get_OutArgs(){} // RVA: 0xCD60
        public void get_ReturnValue(){} // RVA: 0xCD60
    }

    public class IllogicalCallContext
    {
        // ── Methods ──
        public void get_Datastore(){} // RVA: 0x5CF2200
        public void get_HostContext(){} // RVA: 0x2E07C0
        public void set_HostContext(){} // RVA: 0x343E80
        public void get_HasUserData(){} // RVA: 0x5CF22B0
        public void FreeNamedDataSlot(){} // RVA: 0x5CF22F0
        public void CreateCopy(){} // RVA: 0x5CF2330
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LogicalCallContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CF2670 | overloaded x2
        public void GetObjectData(){} // RVA: 0x5CF2E20
        public void Clone(){} // RVA: 0x5CF33E0
        public void Merge(){} // RVA: 0x5CF3CF0
        public void get_HasInfo(){} // RVA: 0x5CF3FE0
        public void get_HasUserData(){} // RVA: 0x5CF22B0
        public void get_Datastore(){} // RVA: 0x5CF4040
        public void GetData(){} // RVA: 0x5CF40F0
        public void SetData(){} // RVA: 0x5CF4130
        public void .cctor(){} // RVA: 0x5CF41F0
    }

    public class MCMDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CFE720
        public void .cctor(){} // RVA: 0x5CFE840
    }

    public class MessageDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x343E80
        public void HasUserData(){} // RVA: 0x5CFE9E0
        public void get_InternalDictionary(){} // RVA: 0x5CFEAD0
        public void set_MethodKeys(){} // RVA: 0x30B0D0
        public void AllocInternalProperties(){} // RVA: 0x5CFEB80
        public void GetInternalProperties(){} // RVA: 0x5CFEBE0
        public void IsOverridenKey(){} // RVA: 0x5CFEC70
        public void get_IsFixedSize(){} // RVA: 0x2DD320
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void get_Item(){} // RVA: 0x5CFED10
        public void set_Item(){} // RVA: 0x5CFEE70
        public void GetMethodProperty(){} // RVA: 0x5CFEE80
        public void SetMethodProperty(){} // RVA: 0x5CFF3E0
        public void get_Keys(){} // RVA: 0x5CFF610
        public void get_Values(){} // RVA: 0x5CFFA50
        public void Add(){} // RVA: 0x5CFFED0
        public void Clear(){} // RVA: 0x5D000A0
        public void Contains(){} // RVA: 0x5D00100
        public void Remove(){} // RVA: 0x5D00240
        public void get_Count(){} // RVA: 0x5D003C0
        public void get_IsSynchronized(){} // RVA: 0x2DD320
        public void get_SyncRoot(){} // RVA: 0x1A3F520
        public void CopyTo(){} // RVA: 0x5D00430
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5D004A0
        public void GetEnumerator(){} // RVA: 0x5D00500
    }

    public class MethodCall
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310 | overloaded x3
        public void CopyFrom(){} // RVA: 0x5CFBA20
        public void InitMethodProperty(){} // RVA: 0x5CFBDC0
        public void GetObjectData(){} // RVA: 0x5CFC420
        public void get_ArgCount(){} // RVA: 0x5CFD5F0
        public void get_Args(){} // RVA: 0x30B130
        public void get_LogicalCallContext(){} // RVA: 0x5CFD610
        public void get_MethodBase(){} // RVA: 0x5CFD6B0
        public void get_MethodName(){} // RVA: 0x5CFD720
        public void get_MethodSignature(){} // RVA: 0x5CFD7B0
        public void get_Properties(){} // RVA: 0x5CFA690
        public void InitDictionary(){} // RVA: 0x5CFD9E0
        public void get_TypeName(){} // RVA: 0x5CFDB00
        public void get_Uri(){} // RVA: 0x2F8380
        public void set_Uri(){} // RVA: 0x2DEE30
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x2F8380
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0x2DEE30
        public void GetArg(){} // RVA: 0x5CFDBC0
        public void Init(){} // RVA: 0x2DD310
        public void ResolveMethod(){} // RVA: 0x5CFDBF0
        public void CastTo(){} // RVA: 0x5CFE320
        public void GetTypeNameFromAssemblyQualifiedName(){} // RVA: 0x5CFE5C0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x358730
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x358740
        public void get_GenericArguments(){} // RVA: 0x5CFE680
    }

    public class MethodResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CFB1B0 | overloaded x4
        public void InitMethodProperty(){} // RVA: 0x5D01510
        public void get_ArgCount(){} // RVA: 0x5D01C10
        public void get_Args(){} // RVA: 0x37E0E0
        public void get_Exception(){} // RVA: 0x4976A0
        public void get_LogicalCallContext(){} // RVA: 0x5D01C30
        public void get_MethodBase(){} // RVA: 0x5D01CD0
        public void get_MethodName(){} // RVA: 0x5D01F60
        public void get_MethodSignature(){} // RVA: 0x5D02010
        public void get_OutArgs(){} // RVA: 0x5D02130
        public void get_Properties(){} // RVA: 0x5CFB240
        public void get_ReturnValue(){} // RVA: 0x6374D0
        public void get_TypeName(){} // RVA: 0x5D02240
        public void get_Uri(){} // RVA: 0x5D022F0
        public void set_Uri(){} // RVA: 0x343E80
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x5D022F0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0x343E80
        public void GetArg(){} // RVA: 0x5D023A0
        public void GetObjectData(){} // RVA: 0x5D023D0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x3A5590
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x3A55A0
    }

    public class MethodReturnDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D02B70
        public void .cctor(){} // RVA: 0x5D02D40
    }

    public class MonoMethodMessage
    {
        // ── Methods ──
        public void InitMessage(){} // RVA: 0x5D02FC0
        public void .ctor(){} // RVA: 0x5D03810 | overloaded x3
        public void GetMethodInfo(){} // RVA: 0x5D036E0
        public void get_Properties(){} // RVA: 0x5D03970
        public void get_ArgCount(){} // RVA: 0x5D03A20
        public void get_Args(){} // RVA: 0x2E07C0
        public void get_LogicalCallContext(){} // RVA: 0x6374D0
        public void set_LogicalCallContext(){} // RVA: 0x30B890
        public void get_MethodBase(){} // RVA: 0x2F8380
        public void get_MethodName(){} // RVA: 0x5D03A60
        public void get_MethodSignature(){} // RVA: 0x5D03AD0
        public void get_TypeName(){} // RVA: 0x5D03CC0
        public void get_Uri(){} // RVA: 0x3A5500
        public void set_Uri(){} // RVA: 0x3A5510
        public void GetArg(){} // RVA: 0x5D03D50
        public void get_Exception(){} // RVA: 0x35A740
        public void get_OutArgCount(){} // RVA: 0x5D03D80
        public void get_OutArgs(){} // RVA: 0x5D03DE0
        public void get_ReturnValue(){} // RVA: 0x4976A0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x358D50
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x358D60
        public void get_AsyncResult(){} // RVA: 0x358730
        public void get_CallType(){} // RVA: 0x5D03F60
        public void NeedsOutProcessing(){} // RVA: 0x5D040A0
    }

    public class ObjRefSurrogate
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x5D041F0
        public void SetObjectData(){} // RVA: 0x5D04300
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class OneWayAttribute
    {
    }

    public class RemotingSurrogate
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x5D04120
        public void SetObjectData(){} // RVA: 0x5D041B0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class RemotingSurrogateSelector
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void ChainSelector(){} // RVA: 0x5D04350
        public void GetSurrogate(){} // RVA: 0x5D04410
        public void .cctor(){} // RVA: 0x5D04630
    }

    public class ReturnMessage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D04B10 | overloaded x2
        public void get_ArgCount(){} // RVA: 0x33B7190
        public void get_Args(){} // RVA: 0x2E07C0
        public void get_LogicalCallContext(){} // RVA: 0x5D04D00
        public void get_MethodBase(){} // RVA: 0x35A740
        public void get_MethodName(){} // RVA: 0x5D04DA0
        public void get_MethodSignature(){} // RVA: 0x5D04E70
        public void get_Properties(){} // RVA: 0x5D050A0
        public void get_TypeName(){} // RVA: 0x5D05150
        public void get_Uri(){} // RVA: 0x6374D0
        public void set_Uri(){} // RVA: 0x30B890
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x6374D0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0x30B890
        public void GetArg(){} // RVA: 0x5D05250
        public void get_Exception(){} // RVA: 0x4976A0
        public void get_OutArgs(){} // RVA: 0x5D05280
        public void get_ReturnValue(){} // RVA: 0x30B130
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x358D50
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x358D60
    }

    public class ServerContextTerminatorSink
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x5D05390
        public void AsyncProcessMessage(){} // RVA: 0x5D05490
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ServerObjectReplySink
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4CF2A0
        public void SyncProcessMessage(){} // RVA: 0x5D058F0
        public void AsyncProcessMessage(){} // RVA: 0x5D05970
    }

    public class ServerObjectTerminatorSink
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void SyncProcessMessage(){} // RVA: 0x5D05560
        public void AsyncProcessMessage(){} // RVA: 0x5D05690
    }

    public class StackBuilderSink : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D059B0
        public void SyncProcessMessage(){} // RVA: 0x5D05A60
        public void AsyncProcessMessage(){} // RVA: 0x5D05B50
        public void ExecuteAsyncMessage(){} // RVA: 0x5D05C90
        public void CheckParameters(){} // RVA: 0x5D05E70
        public void <AsyncProcessMessage>b__4_0(){} // RVA: 0x5D061E0
    }

}