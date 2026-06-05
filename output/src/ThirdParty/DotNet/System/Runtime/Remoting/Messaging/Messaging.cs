// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Messaging
// Classes: 44
// Methods: 301

namespace ThirdParty.DotNet.System.Runtime.Remoting.Messaging
{
    public class ArgInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87A4540
        public void GetInOutArgs(){} // RVA: 0x7FFAF87A47D0
    }

    public class AsyncResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_AsyncState(){} // RVA: 0x7FFAF2DA8380
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFAF87A4930
        public void get_CompletedSynchronously(){} // RVA: 0x7FFAF2F56500
        public void get_IsCompleted(){} // RVA: 0x7FFAF2F57410
        public void get_EndInvokeCalled(){} // RVA: 0x7FFAF3F7EB40
        public void set_EndInvokeCalled(){} // RVA: 0x7FFAF87A4B50
        public void get_AsyncDelegate(){} // RVA: 0x7FFAF2DBB0C0
        public void get_NextSink(){} // RVA: 0x7FFAF2FC9240
        public void AsyncProcessMessage(){} // RVA: 0x7FFAF87A4B60
        public void GetReplyMessage(){} // RVA: 0x7FFAF2E55590
        public void SetMessageCtrl(){} // RVA: 0x7FFAF2E08D60
        public void SetCompletedSynchronously(){} // RVA: 0x7FFAF2F578C0
        public void EndInvoke(){} // RVA: 0x7FFAF87A4BA0
        public void SyncProcessMessage(){} // RVA: 0x7FFAF87A4D50
        public void get_CallMessage(){} // RVA: 0x7FFAF2E2B370
        public void set_CallMessage(){} // RVA: 0x7FFAF2E2B380
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFAF87A4FC0
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7FFAF2D8D310
        public void Invoke(){} // RVA: 0x7FFAF87A5100
    }

    public class CADArgHolder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
    }

    public class CADMessageBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87A5FA0
        public void GetMethod(){} // RVA: 0x7FFAF87A6080
        public void GetSignature(){} // RVA: 0x7FFAF87A6110
        public void MarshalProperties(){} // RVA: 0x7FFAF87A6320
        public void UnmarshalProperties(){} // RVA: 0x7FFAF87A6850
        public void IsPossibleToIgnoreMarshal(){} // RVA: 0x7FFAF87A69D0
        public void MarshalArgument(){} // RVA: 0x7FFAF87A6BC0
        public void UnmarshalArgument(){} // RVA: 0x7FFAF87A6D50
        public void MarshalArguments(){} // RVA: 0x7FFAF87A78F0
        public void UnmarshalArguments(){} // RVA: 0x7FFAF87A7A70
        public void SaveLogicalCallContext(){} // RVA: 0x7FFAF87A7BF0
        public void GetLogicalCallContext(){} // RVA: 0x7FFAF87A7D80
    }

    public class CADMethodCallMessage
    {
        public object PropertiesCount;

        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7FFAF2F476A0
        public void Create(){} // RVA: 0x7FFAF87A7E20
        public void .ctor(){} // RVA: 0x7FFAF87A7EB0
        public void GetArguments(){} // RVA: 0x7FFAF87A8250
        public void GetArgs(){} // RVA: 0x7FFAF87A84B0
        public void get_PropertiesCount(){} // RVA: 0x7FFAF3210030
    }

    public class CADMethodRef
    {
        // ── Methods ──
        public void GetTypes(){} // RVA: 0x7FFAF87A53B0
        public void Resolve(){} // RVA: 0x7FFAF87A5550
        public void .ctor(){} // RVA: 0x7FFAF87A5B50
    }

    public class CADMethodReturnMessage
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF87A84C0
        public void .ctor(){} // RVA: 0x7FFAF87A8550
        public void GetArguments(){} // RVA: 0x7FFAF87A8A70
        public void GetArgs(){} // RVA: 0x7FFAF87A84B0
        public void GetReturnValue(){} // RVA: 0x7FFAF87A8CD0
        public void GetException(){} // RVA: 0x7FFAF87A8CE0
        public void get_PropertiesCount(){} // RVA: 0x7FFAF3210030
    }

    public class CADObjRef
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87A5250
    }

    public class CallContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void SetCurrentCallContext(){} // RVA: 0x7FFAF2FC9240
        public void SetLogicalCallContext(){} // RVA: 0x7FFAF87A1EE0
        public void LogicalGetData(){} // RVA: 0x7FFAF87A1F80
        public void LogicalSetData(){} // RVA: 0x7FFAF87A20C0
    }

    public class CallContextRemotingData : ؄}e
    {
        // ── Methods ──
        public void get_LogicalCallID(){} // RVA: 0x7FFAF2DA8380
        public void set_LogicalCallID(){} // RVA: 0x7FFAF2D8EE30
        public void get_HasInfo(){} // RVA: 0x7FFAF39B1170
        public void Clone(){} // RVA: 0x7FFAF87A44A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CallContextSecurityData
    {
        // ── Methods ──
        public void get_HasInfo(){} // RVA: 0x7FFAF39B1170
        public void Clone(){} // RVA: 0x7FFAF87A4400
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ClientContextReplySink
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2F7F2A0
        public void SyncProcessMessage(){} // RVA: 0x7FFAF87A9260
        public void AsyncProcessMessage(){} // RVA: 0x7FFAF87A9320
    }

    public class ClientContextTerminatorSink
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void SyncProcessMessage(){} // RVA: 0x7FFAF87A8D90
        public void AsyncProcessMessage(){} // RVA: 0x7FFAF87A8F50
    }

    public class ConstructionCall
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87A9460 | overloaded x2
        public void InitDictionary(){} // RVA: 0x7FFAF87A9520
        public void get_IsContextOk(){} // RVA: 0x7FFAF3DFA670
        public void set_IsContextOk(){} // RVA: 0x7FFAF3DF8E00
        public void get_ActivationType(){} // RVA: 0x7FFAF87A9720
        public void get_ActivationTypeName(){} // RVA: 0x7FFAF2DCC010
        public void get_Activator(){} // RVA: 0x7FFAF2E08D50
        public void set_Activator(){} // RVA: 0x7FFAF2E08D60
        public void get_CallSiteActivationAttributes(){} // RVA: 0x7FFAF2E55590
        public void SetActivationAttributes(){} // RVA: 0x7FFAF2E555A0
        public void get_ContextProperties(){} // RVA: 0x7FFAF87A9830
        public void InitMethodProperty(){} // RVA: 0x7FFAF87A98E0
        public void GetObjectData(){} // RVA: 0x7FFAF87A9E10
        public void get_Properties(){} // RVA: 0x7FFAF87AA690
        public void get_SourceProxy(){} // RVA: 0x7FFAF34CC8C0
        public void set_SourceProxy(){} // RVA: 0x7FFAF345A650
    }

    public class ConstructionCallDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87AA6D0
        public void GetMethodProperty(){} // RVA: 0x7FFAF87AA7F0
        public void SetMethodProperty(){} // RVA: 0x7FFAF87AAC00
        public void .cctor(){} // RVA: 0x7FFAF87AAF10
    }

    public class ConstructionResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87AB1B0 | overloaded x3
        public void get_Properties(){} // RVA: 0x7FFAF87AB240
    }

    public class EnvoyTerminatorSink
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7FFAF87AB380
        public void AsyncProcessMessage(){} // RVA: 0x7FFAF87AB410
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF87AB4B0
    }

    public class ErrorMessage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87AB550
        public void get_ArgCount(){} // RVA: 0x7FFAF2FC9240
        public void get_Args(){} // RVA: 0x7FFAF2FC9240
        public void get_MethodBase(){} // RVA: 0x7FFAF2FC9240
        public void get_MethodName(){} // RVA: 0x7FFAF87AB5E0
        public void get_MethodSignature(){} // RVA: 0x7FFAF2FC9240
        public void get_Properties(){} // RVA: 0x7FFAF2FC9240
        public void get_TypeName(){} // RVA: 0x7FFAF87AB620
        public void get_Uri(){} // RVA: 0x7FFAF2DA8380
        public void GetArg(){} // RVA: 0x7FFAF2FC9240
        public void get_LogicalCallContext(){} // RVA: 0x7FFAF2FC9240
    }

    public class Header
    {
    }

    public class HeaderHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45B7170
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    }

    public class IInternalMessage
    {
        // ── Methods ──
        public void get_TargetIdentity(){} // RVA: 0x7FFAF2ABCD60
        public void set_TargetIdentity(){} // RVA: 0x7FFAF2AD4B10
        public void get_Uri(){} // RVA: 0x7FFAF2ABCD60
        public void set_Uri(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IMessage
    {
        // ── Methods ──
        public void get_Properties(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IMessageCtrl
    {
    }

    public class IMessageSink
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7FFAF2ABCE10
        public void AsyncProcessMessage(){} // RVA: 0x7FFAF2ACE6A0
    }

    public class IMethodCallMessage
    {
    }

    public class IMethodMessage
    {
        // ── Methods ──
        public void get_ArgCount(){} // RVA: 0x7FFAF2ABD840
        public void get_Args(){} // RVA: 0x7FFAF2ABCD60
        public void get_LogicalCallContext(){} // RVA: 0x7FFAF2ABCD60
        public void get_MethodBase(){} // RVA: 0x7FFAF2ABCD60
        public void get_MethodName(){} // RVA: 0x7FFAF2ABCD60
        public void get_MethodSignature(){} // RVA: 0x7FFAF2ABCD60
        public void get_TypeName(){} // RVA: 0x7FFAF2ABCD60
        public void get_Uri(){} // RVA: 0x7FFAF2ABCD60
        public void GetArg(){} // RVA: 0x7FFAF2ACBCC0
    }

    public class IMethodReturnMessage
    {
        // ── Methods ──
        public void get_Exception(){} // RVA: 0x7FFAF2ABCD60
        public void get_OutArgs(){} // RVA: 0x7FFAF2ABCD60
        public void get_ReturnValue(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IllogicalCallContext
    {
        // ── Methods ──
        public void get_Datastore(){} // RVA: 0x7FFAF87A2200
        public void get_HostContext(){} // RVA: 0x7FFAF2D907C0
        public void set_HostContext(){} // RVA: 0x7FFAF2DF3E80
        public void get_HasUserData(){} // RVA: 0x7FFAF87A22B0
        public void FreeNamedDataSlot(){} // RVA: 0x7FFAF87A22F0
        public void CreateCopy(){} // RVA: 0x7FFAF87A2330
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class LogicalCallContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87A2670 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFAF87A2E20
        public void Clone(){} // RVA: 0x7FFAF87A33E0
        public void Merge(){} // RVA: 0x7FFAF87A3CF0
        public void get_HasInfo(){} // RVA: 0x7FFAF87A3FE0
        public void get_HasUserData(){} // RVA: 0x7FFAF87A22B0
        public void get_Datastore(){} // RVA: 0x7FFAF87A4040
        public void GetData(){} // RVA: 0x7FFAF87A40F0
        public void SetData(){} // RVA: 0x7FFAF87A4130
        public void .cctor(){} // RVA: 0x7FFAF87A41F0
    }

    public class MCMDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87AE720
        public void .cctor(){} // RVA: 0x7FFAF87AE840
    }

    public class MessageDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DF3E80
        public void HasUserData(){} // RVA: 0x7FFAF87AE9E0
        public void get_InternalDictionary(){} // RVA: 0x7FFAF87AEAD0
        public void set_MethodKeys(){} // RVA: 0x7FFAF2DBB0D0
        public void AllocInternalProperties(){} // RVA: 0x7FFAF87AEB80
        public void GetInternalProperties(){} // RVA: 0x7FFAF87AEBE0
        public void IsOverridenKey(){} // RVA: 0x7FFAF87AEC70
        public void get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void get_Item(){} // RVA: 0x7FFAF87AED10
        public void set_Item(){} // RVA: 0x7FFAF87AEE70
        public void GetMethodProperty(){} // RVA: 0x7FFAF87AEE80
        public void SetMethodProperty(){} // RVA: 0x7FFAF87AF3E0
        public void get_Keys(){} // RVA: 0x7FFAF87AF610
        public void get_Values(){} // RVA: 0x7FFAF87AFA50
        public void Add(){} // RVA: 0x7FFAF87AFED0
        public void Clear(){} // RVA: 0x7FFAF87B00A0
        public void Contains(){} // RVA: 0x7FFAF87B0100
        public void Remove(){} // RVA: 0x7FFAF87B0240
        public void get_Count(){} // RVA: 0x7FFAF87B03C0
        public void get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void get_SyncRoot(){} // RVA: 0x7FFAF44EF520
        public void CopyTo(){} // RVA: 0x7FFAF87B0430
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF87B04A0
        public void GetEnumerator(){} // RVA: 0x7FFAF87B0500
    }

    public class MethodCall
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310 | overloaded x3
        public void CopyFrom(){} // RVA: 0x7FFAF87ABA20
        public void InitMethodProperty(){} // RVA: 0x7FFAF87ABDC0
        public void GetObjectData(){} // RVA: 0x7FFAF87AC420
        public void get_ArgCount(){} // RVA: 0x7FFAF87AD5F0
        public void get_Args(){} // RVA: 0x7FFAF2DBB130
        public void get_LogicalCallContext(){} // RVA: 0x7FFAF87AD610
        public void get_MethodBase(){} // RVA: 0x7FFAF87AD6B0
        public void get_MethodName(){} // RVA: 0x7FFAF87AD720
        public void get_MethodSignature(){} // RVA: 0x7FFAF87AD7B0
        public void get_Properties(){} // RVA: 0x7FFAF87AA690
        public void InitDictionary(){} // RVA: 0x7FFAF87AD9E0
        public void get_TypeName(){} // RVA: 0x7FFAF87ADB00
        public void get_Uri(){} // RVA: 0x7FFAF2DA8380
        public void set_Uri(){} // RVA: 0x7FFAF2D8EE30
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x7FFAF2DA8380
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0x7FFAF2D8EE30
        public void GetArg(){} // RVA: 0x7FFAF87ADBC0
        public void Init(){} // RVA: 0x7FFAF2D8D310
        public void ResolveMethod(){} // RVA: 0x7FFAF87ADBF0
        public void CastTo(){} // RVA: 0x7FFAF87AE320
        public void GetTypeNameFromAssemblyQualifiedName(){} // RVA: 0x7FFAF87AE5C0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7FFAF2E08730
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7FFAF2E08740
        public void get_GenericArguments(){} // RVA: 0x7FFAF87AE680
    }

    public class MethodResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87AB1B0 | overloaded x4
        public void InitMethodProperty(){} // RVA: 0x7FFAF87B1510
        public void get_ArgCount(){} // RVA: 0x7FFAF87B1C10
        public void get_Args(){} // RVA: 0x7FFAF2E2E0E0
        public void get_Exception(){} // RVA: 0x7FFAF2F476A0
        public void get_LogicalCallContext(){} // RVA: 0x7FFAF87B1C30
        public void get_MethodBase(){} // RVA: 0x7FFAF87B1CD0
        public void get_MethodName(){} // RVA: 0x7FFAF87B1F60
        public void get_MethodSignature(){} // RVA: 0x7FFAF87B2010
        public void get_OutArgs(){} // RVA: 0x7FFAF87B2130
        public void get_Properties(){} // RVA: 0x7FFAF87AB240
        public void get_ReturnValue(){} // RVA: 0x7FFAF30E74D0
        public void get_TypeName(){} // RVA: 0x7FFAF87B2240
        public void get_Uri(){} // RVA: 0x7FFAF87B22F0
        public void set_Uri(){} // RVA: 0x7FFAF2DF3E80
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x7FFAF87B22F0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0x7FFAF2DF3E80
        public void GetArg(){} // RVA: 0x7FFAF87B23A0
        public void GetObjectData(){} // RVA: 0x7FFAF87B23D0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7FFAF2E55590
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7FFAF2E555A0
    }

    public class MethodReturnDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87B2B70
        public void .cctor(){} // RVA: 0x7FFAF87B2D40
    }

    public class MonoMethodMessage
    {
        // ── Methods ──
        public void InitMessage(){} // RVA: 0x7FFAF87B2FC0
        public void .ctor(){} // RVA: 0x7FFAF87B3810 | overloaded x3
        public void GetMethodInfo(){} // RVA: 0x7FFAF87B36E0
        public void get_Properties(){} // RVA: 0x7FFAF87B3970
        public void get_ArgCount(){} // RVA: 0x7FFAF87B3A20
        public void get_Args(){} // RVA: 0x7FFAF2D907C0
        public void get_LogicalCallContext(){} // RVA: 0x7FFAF30E74D0
        public void set_LogicalCallContext(){} // RVA: 0x7FFAF2DBB890
        public void get_MethodBase(){} // RVA: 0x7FFAF2DA8380
        public void get_MethodName(){} // RVA: 0x7FFAF87B3A60
        public void get_MethodSignature(){} // RVA: 0x7FFAF87B3AD0
        public void get_TypeName(){} // RVA: 0x7FFAF87B3CC0
        public void get_Uri(){} // RVA: 0x7FFAF2E55500
        public void set_Uri(){} // RVA: 0x7FFAF2E55510
        public void GetArg(){} // RVA: 0x7FFAF87B3D50
        public void get_Exception(){} // RVA: 0x7FFAF2E0A740
        public void get_OutArgCount(){} // RVA: 0x7FFAF87B3D80
        public void get_OutArgs(){} // RVA: 0x7FFAF87B3DE0
        public void get_ReturnValue(){} // RVA: 0x7FFAF2F476A0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7FFAF2E08D50
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7FFAF2E08D60
        public void get_AsyncResult(){} // RVA: 0x7FFAF2E08730
        public void get_CallType(){} // RVA: 0x7FFAF87B3F60
        public void NeedsOutProcessing(){} // RVA: 0x7FFAF87B40A0
    }

    public class ObjRefSurrogate
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x7FFAF87B41F0
        public void SetObjectData(){} // RVA: 0x7FFAF87B4300
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class OneWayAttribute
    {
    }

    public class RemotingSurrogate
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x7FFAF87B4120
        public void SetObjectData(){} // RVA: 0x7FFAF87B41B0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class RemotingSurrogateSelector
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void ChainSelector(){} // RVA: 0x7FFAF87B4350
        public void GetSurrogate(){} // RVA: 0x7FFAF87B4410
        public void .cctor(){} // RVA: 0x7FFAF87B4630
    }

    public class ReturnMessage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87B4B10 | overloaded x2
        public void get_ArgCount(){} // RVA: 0x7FFAF5E67190
        public void get_Args(){} // RVA: 0x7FFAF2D907C0
        public void get_LogicalCallContext(){} // RVA: 0x7FFAF87B4D00
        public void get_MethodBase(){} // RVA: 0x7FFAF2E0A740
        public void get_MethodName(){} // RVA: 0x7FFAF87B4DA0
        public void get_MethodSignature(){} // RVA: 0x7FFAF87B4E70
        public void get_Properties(){} // RVA: 0x7FFAF87B50A0
        public void get_TypeName(){} // RVA: 0x7FFAF87B5150
        public void get_Uri(){} // RVA: 0x7FFAF30E74D0
        public void set_Uri(){} // RVA: 0x7FFAF2DBB890
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x7FFAF30E74D0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0x7FFAF2DBB890
        public void GetArg(){} // RVA: 0x7FFAF87B5250
        public void get_Exception(){} // RVA: 0x7FFAF2F476A0
        public void get_OutArgs(){} // RVA: 0x7FFAF87B5280
        public void get_ReturnValue(){} // RVA: 0x7FFAF2DBB130
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7FFAF2E08D50
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7FFAF2E08D60
    }

    public class ServerContextTerminatorSink
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7FFAF87B5390
        public void AsyncProcessMessage(){} // RVA: 0x7FFAF87B5490
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ServerObjectReplySink
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2F7F2A0
        public void SyncProcessMessage(){} // RVA: 0x7FFAF87B58F0
        public void AsyncProcessMessage(){} // RVA: 0x7FFAF87B5970
    }

    public class ServerObjectTerminatorSink
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void SyncProcessMessage(){} // RVA: 0x7FFAF87B5560
        public void AsyncProcessMessage(){} // RVA: 0x7FFAF87B5690
    }

    public class StackBuilderSink : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87B59B0
        public void SyncProcessMessage(){} // RVA: 0x7FFAF87B5A60
        public void AsyncProcessMessage(){} // RVA: 0x7FFAF87B5B50
        public void ExecuteAsyncMessage(){} // RVA: 0x7FFAF87B5C90
        public void CheckParameters(){} // RVA: 0x7FFAF87B5E70
        public void <AsyncProcessMessage>b__4_0(){} // RVA: 0x7FFAF87B61E0
    }

}