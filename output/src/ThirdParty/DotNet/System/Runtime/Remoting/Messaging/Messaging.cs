// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Messaging
// Classes: 41
// Methods: 304

namespace ThirdParty.DotNet.System.Runtime.Remoting.Messaging
{
    public class ArgInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAE20E0
        public void GetInOutArgs(){} // RVA: 0x7ADAE2370
    }

    public class AsyncResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_AsyncState(){} // RVA: 0x7A80F2570
        public void get_AsyncWaitHandle(){} // RVA: 0x7ADAE2500
        public void get_CompletedSynchronously(){} // RVA: 0x7A82A20A0
        public void get_IsCompleted(){} // RVA: 0x7A82A3DE0
        public void get_EndInvokeCalled(){} // RVA: 0x7A9286CF0
        public void set_EndInvokeCalled(){} // RVA: 0x7ADAE26D0
        public void get_AsyncDelegate(){} // RVA: 0x7A81052C0
        public void get_NextSink(){} // RVA: 0x7A82D1450
        public void AsyncProcessMessage(){} // RVA: 0x7ADAE26E0
        public void GetReplyMessage(){} // RVA: 0x7A81A00E0
        public void SetMessageCtrl(){} // RVA: 0x7A81533A0
        public void SetCompletedSynchronously(){} // RVA: 0x7A82A2C90
        public void EndInvoke(){} // RVA: 0x7ADAE2720
        public void SyncProcessMessage(){} // RVA: 0x7ADAE28A0
        public void get_CallMessage(){} // RVA: 0x7A8175DF0
        public void set_CallMessage(){} // RVA: 0x7A8175E00
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7ADAE2AE0
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7A80D7310
        public void Invoke(){} // RVA: 0x7ADAE2C30
    }

    public class CADArgHolder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
    }

    public class CADMessageBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAE3B60
        public void GetMethod(){} // RVA: 0x7ADAE3C40
        public void GetSignature(){} // RVA: 0x7ADAE3CD0
        public void MarshalProperties(){} // RVA: 0x7ADAE3EF0
        public void UnmarshalProperties(){} // RVA: 0x7ADAE43E0
        public void IsPossibleToIgnoreMarshal(){} // RVA: 0x7ADAE4560
        public void MarshalArgument(){} // RVA: 0x7ADAE4750
        public void UnmarshalArgument(){} // RVA: 0x7ADAE48E0
        public void MarshalArguments(){} // RVA: 0x7ADAE5490
        public void UnmarshalArguments(){} // RVA: 0x7ADAE5620
        public void SaveLogicalCallContext(){} // RVA: 0x7ADAE57B0
        public void GetLogicalCallContext(){} // RVA: 0x7ADAE5940
    }

    public class CADMethodCallMessage : CADMessageBase
    {
        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7A8292C30
        public void Create(){} // RVA: 0x7ADAE59E0
        public void .ctor(){} // RVA: 0x7ADAE5A70
        public void GetArguments(){} // RVA: 0x7ADAE5E10
        public void GetArgs(){} // RVA: 0x7ADAE6070
        public void get_PropertiesCount(){} // RVA: 0x7A851DB90
    }

    public class CADMethodRef : Object
    {
        // ── Methods ──
        public void GetTypes(){} // RVA: 0x7ADAE2EF0
        public void Resolve(){} // RVA: 0x7ADAE30B0
        public void .ctor(){} // RVA: 0x7ADAE36D0
    }

    public class CADMethodReturnMessage : CADMessageBase
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7ADAE6080
        public void .ctor(){} // RVA: 0x7ADAE6110
        public void GetArguments(){} // RVA: 0x7ADAE6630
        public void GetArgs(){} // RVA: 0x7ADAE6070
        public void GetReturnValue(){} // RVA: 0x7ADAE6890
        public void GetException(){} // RVA: 0x7ADAE68A0
        public void get_PropertiesCount(){} // RVA: 0x7A851DB90
    }

    public class CADObjRef : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAE2D90
    }

    public class CallContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void SetCurrentCallContext(){} // RVA: 0x7A82D1450
        public void SetLogicalCallContext(){} // RVA: 0x7ADADFA90
        public void LogicalGetData(){} // RVA: 0x7ADADFB30
        public void LogicalSetData(){} // RVA: 0x7ADADFC70
    }

    public class CallContextRemotingData : Object
    {
        // ── Methods ──
        public void get_LogicalCallID(){} // RVA: 0x7A80F2570
        public void set_LogicalCallID(){} // RVA: 0x7A80D8E20
        public void get_HasInfo(){} // RVA: 0x7A8CCB4F0
        public void Clone(){} // RVA: 0x7ADAE2040
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CallContextSecurityData : Object
    {
        // ── Methods ──
        public void get_HasInfo(){} // RVA: 0x7A8CCB4F0
        public void Clone(){} // RVA: 0x7ADAE1FA0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ClientContextReplySink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9A41AA0
        public void SyncProcessMessage(){} // RVA: 0x7ADAE6E20
        public void AsyncProcessMessage(){} // RVA: 0x7ADAE6EE0
    }

    public class ClientContextTerminatorSink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void SyncProcessMessage(){} // RVA: 0x7ADAE6950
        public void AsyncProcessMessage(){} // RVA: 0x7ADAE6B10
    }

    public class ConstructionCall : MethodCall
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAE7020
        public void InitDictionary(){} // RVA: 0x7ADAE70D0
        public void get_IsContextOk(){} // RVA: 0x7A9101D40
        public void set_IsContextOk(){} // RVA: 0x7A91004C0
        public void get_ActivationType(){} // RVA: 0x7ADAE72D0
        public void get_ActivationTypeName(){} // RVA: 0x7A81163D0
        public void get_Activator(){} // RVA: 0x7A8153390
        public void set_Activator(){} // RVA: 0x7A81533A0
        public void get_CallSiteActivationAttributes(){} // RVA: 0x7A81A00E0
        public void SetActivationAttributes(){} // RVA: 0x7A81A00F0
        public void get_ContextProperties(){} // RVA: 0x7ADAE73E0
        public void InitMethodProperty(){} // RVA: 0x7ADAE7490
        public void GetObjectData(){} // RVA: 0x7ADAE79C0
        public void get_Properties(){} // RVA: 0x7ADAE8240
        public void get_SourceProxy(){} // RVA: 0x7A87D9C10
        public void set_SourceProxy(){} // RVA: 0x7A8744720
    }

    public class ConstructionCallDictionary : MessageDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAE8280
        public void GetMethodProperty(){} // RVA: 0x7ADAE83A0
        public void SetMethodProperty(){} // RVA: 0x7ADAE87B0
        public void .cctor(){} // RVA: 0x7ADAE8AC0
    }

    public class ConstructionResponse : MethodResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAE8D60
        public void get_Properties(){} // RVA: 0x7ADAE8DF0
    }

    public class EnvoyTerminatorSink : Object
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7ADAE8F30
        public void AsyncProcessMessage(){} // RVA: 0x7ADAE8FC0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7ADAE9060
    }

    public class ErrorMessage : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAE9100
        public void get_ArgCount(){} // RVA: 0x7A82D1450
        public void get_Args(){} // RVA: 0x7A82D1450
        public void get_MethodBase(){} // RVA: 0x7A82D1450
        public void get_MethodName(){} // RVA: 0x7ADAE9190
        public void get_MethodSignature(){} // RVA: 0x7A82D1450
        public void get_Properties(){} // RVA: 0x7A82D1450
        public void get_TypeName(){} // RVA: 0x7ADAE91D0
        public void get_Uri(){} // RVA: 0x7A80F2570
        public void GetArg(){} // RVA: 0x7A82D1450
        public void get_LogicalCallContext(){} // RVA: 0x7A82D1450
    }

    public class HeaderHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98C1360
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class Header[] : Array
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

    public class IInternalMessage
    {
        // ── Methods ──
        public void get_TargetIdentity(){} // RVA: 0x7A7E00680
        public void set_TargetIdentity(){} // RVA: 0x7A7E18800
        public void get_Uri(){} // RVA: 0x7A7E00680
        public void set_Uri(){} // RVA: 0x7A7E18800
    }

    public class IMessage
    {
        // ── Methods ──
        public void get_Properties(){} // RVA: 0x7A7E00680
    }

    public class IMessageSink
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7A7E00B20
        public void AsyncProcessMessage(){} // RVA: 0x7A7E00BD0
    }

    public class IMethodMessage
    {
        // ── Methods ──
        public void get_ArgCount(){} // RVA: 0x7A7E00710
        public void get_Args(){} // RVA: 0x7A7E00680
        public void get_LogicalCallContext(){} // RVA: 0x7A7E00680
        public void get_MethodBase(){} // RVA: 0x7A7E00680
        public void get_MethodName(){} // RVA: 0x7A7E00680
        public void get_MethodSignature(){} // RVA: 0x7A7E00680
        public void get_TypeName(){} // RVA: 0x7A7E00680
        public void get_Uri(){} // RVA: 0x7A7E00680
        public void GetArg(){} // RVA: 0x7A7E00740
    }

    public class IMethodReturnMessage
    {
        // ── Methods ──
        public void get_Exception(){} // RVA: 0x7A7E00680
        public void get_OutArgs(){} // RVA: 0x7A7E00680
        public void get_ReturnValue(){} // RVA: 0x7A7E00680
    }

    public class IllogicalCallContext : Object
    {
        // ── Methods ──
        public void get_Datastore(){} // RVA: 0x7ADADFDB0
        public void get_HostContext(){} // RVA: 0x7A80DA7B0
        public void set_HostContext(){} // RVA: 0x7A813E420
        public void get_HasUserData(){} // RVA: 0x7ADADFE60
        public void FreeNamedDataSlot(){} // RVA: 0x7ADADFEA0
        public void CreateCopy(){} // RVA: 0x7ADADFEE0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LogicalCallContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAE0220
        public void GetObjectData(){} // RVA: 0x7ADAE09D0
        public void Clone(){} // RVA: 0x7ADAE0F90
        public void Merge(){} // RVA: 0x7ADAE1890
        public void get_HasInfo(){} // RVA: 0x7ADAE1B80
        public void get_HasUserData(){} // RVA: 0x7ADADFE60
        public void get_Datastore(){} // RVA: 0x7ADAE1BE0
        public void GetData(){} // RVA: 0x7ADAE1C90
        public void SetData(){} // RVA: 0x7ADAE1CD0
        public void .cctor(){} // RVA: 0x7ADAE1D90
    }

    public class MCMDictionary : MessageDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAEC2E0
        public void .cctor(){} // RVA: 0x7ADAEC400
    }

    public class MessageDictionary : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A813E420
        public void HasUserData(){} // RVA: 0x7ADAEC5A0
        public void get_InternalDictionary(){} // RVA: 0x7ADAEC690
        public void set_MethodKeys(){} // RVA: 0x7A81052D0
        public void AllocInternalProperties(){} // RVA: 0x7ADAEC740
        public void GetInternalProperties(){} // RVA: 0x7ADAEC7A0
        public void IsOverridenKey(){} // RVA: 0x7ADAEC830
        public void get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void get_Item(){} // RVA: 0x7ADAEC8E0
        public void set_Item(){} // RVA: 0x7ADAECA50
        public void GetMethodProperty(){} // RVA: 0x7ADAECA60
        public void SetMethodProperty(){} // RVA: 0x7ADAECFC0
        public void get_Keys(){} // RVA: 0x7ADAED1F0
        public void get_Values(){} // RVA: 0x7ADAED620
        public void Add(){} // RVA: 0x7ADAEDA90
        public void Clear(){} // RVA: 0x7ADAEDC70
        public void Contains(){} // RVA: 0x7ADAEDCD0
        public void Remove(){} // RVA: 0x7ADAEDE20
        public void get_Count(){} // RVA: 0x7ADAEDFC0
        public void get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void get_SyncRoot(){} // RVA: 0x7A97F8BA0
        public void CopyTo(){} // RVA: 0x7ADAEE030
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ADAEE0A0
        public void GetEnumerator(){} // RVA: 0x7ADAEE100
    }

    public class MethodCall : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void CopyFrom(){} // RVA: 0x7ADAE95D0
        public void InitMethodProperty(){} // RVA: 0x7ADAE9980
        public void GetObjectData(){} // RVA: 0x7ADAE9FE0
        public void get_ArgCount(){} // RVA: 0x7ADAEB1A0
        public void get_Args(){} // RVA: 0x7A8105330
        public void get_LogicalCallContext(){} // RVA: 0x7ADAEB1C0
        public void get_MethodBase(){} // RVA: 0x7ADAEB260
        public void get_MethodName(){} // RVA: 0x7ADAEB2D0
        public void get_MethodSignature(){} // RVA: 0x7ADAEB360
        public void get_Properties(){} // RVA: 0x7ADAE8240
        public void InitDictionary(){} // RVA: 0x7ADAEB5B0
        public void get_TypeName(){} // RVA: 0x7ADAEB6D0
        public void get_Uri(){} // RVA: 0x7A80F2570
        public void set_Uri(){} // RVA: 0x7A80D8E20
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x7A80F2570
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0x7A80D8E20
        public void GetArg(){} // RVA: 0x7ADAEB790
        public void Init(){} // RVA: 0x7A80D7310
        public void ResolveMethod(){} // RVA: 0x7ADAEB7C0
        public void CastTo(){} // RVA: 0x7ADAEBEE0
        public void GetTypeNameFromAssemblyQualifiedName(){} // RVA: 0x7ADAEC180
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7A8152D80
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7A8152D90
        public void get_GenericArguments(){} // RVA: 0x7ADAEC240
    }

    public class MethodResponse : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAE8D60
        public void InitMethodProperty(){} // RVA: 0x7ADAEF140
        public void get_ArgCount(){} // RVA: 0x7ADAEF840
        public void get_Args(){} // RVA: 0x7A8178B90
        public void get_Exception(){} // RVA: 0x7A8292C30
        public void get_LogicalCallContext(){} // RVA: 0x7ADAEF860
        public void get_MethodBase(){} // RVA: 0x7ADAEF900
        public void get_MethodName(){} // RVA: 0x7ADAEFB90
        public void get_MethodSignature(){} // RVA: 0x7ADAEFC40
        public void get_OutArgs(){} // RVA: 0x7ADAEFD60
        public void get_Properties(){} // RVA: 0x7ADAE8DF0
        public void get_ReturnValue(){} // RVA: 0x7A83F69F0
        public void get_TypeName(){} // RVA: 0x7ADAEFE70
        public void get_Uri(){} // RVA: 0x7ADAEFF20
        public void set_Uri(){} // RVA: 0x7A813E420
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x7ADAEFF20
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0x7A813E420
        public void GetArg(){} // RVA: 0x7ADAEFFD0
        public void GetObjectData(){} // RVA: 0x7ADAF0000
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7A81A00E0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7A81A00F0
    }

    public class MethodReturnDictionary : MessageDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAF0780
        public void .cctor(){} // RVA: 0x7ADAF0950
    }

    public class MonoMethodMessage : Object
    {
        // ── Methods ──
        public void InitMessage(){} // RVA: 0x7ADAF0BD0
        public void .ctor(){} // RVA: 0x7ADAF14B0
        public void GetMethodInfo(){} // RVA: 0x7ADAF1380
        public void get_Properties(){} // RVA: 0x7ADAF1610
        public void get_ArgCount(){} // RVA: 0x7ADAF16C0
        public void get_Args(){} // RVA: 0x7A80DA7B0
        public void get_LogicalCallContext(){} // RVA: 0x7A83F69F0
        public void set_LogicalCallContext(){} // RVA: 0x7A8105A90
        public void get_MethodBase(){} // RVA: 0x7A80F2570
        public void get_MethodName(){} // RVA: 0x7ADAF1700
        public void get_MethodSignature(){} // RVA: 0x7ADAF1770
        public void get_TypeName(){} // RVA: 0x7ADAF1980
        public void get_Uri(){} // RVA: 0x7A81A0050
        public void set_Uri(){} // RVA: 0x7A81A0060
        public void GetArg(){} // RVA: 0x7ADAF1A10
        public void get_Exception(){} // RVA: 0x7A8154D80
        public void get_OutArgCount(){} // RVA: 0x7ADAF1A40
        public void get_OutArgs(){} // RVA: 0x7ADAF1AA0
        public void get_ReturnValue(){} // RVA: 0x7A8292C30
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7A8153390
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7A81533A0
        public void get_AsyncResult(){} // RVA: 0x7A8152D80
        public void get_CallType(){} // RVA: 0x7ADAF1C40
        public void NeedsOutProcessing(){} // RVA: 0x7ADAF1D80
    }

    public class ObjRefSurrogate : Object
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x7ADAF1ED0
        public void SetObjectData(){} // RVA: 0x7ADAF1FE0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class RemotingSurrogate : Object
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x7ADAF1E00
        public void SetObjectData(){} // RVA: 0x7ADAF1E90
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class RemotingSurrogateSelector : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void ChainSelector(){} // RVA: 0x7ADAF2030
        public void GetSurrogate(){} // RVA: 0x7ADAF20F0
        public void .cctor(){} // RVA: 0x7ADAF2310
    }

    public class ReturnMessage : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAF2800
        public void get_ArgCount(){} // RVA: 0x7AB1ACB90
        public void get_Args(){} // RVA: 0x7A80DA7B0
        public void get_LogicalCallContext(){} // RVA: 0x7ADAF29F0
        public void get_MethodBase(){} // RVA: 0x7A8154D80
        public void get_MethodName(){} // RVA: 0x7ADAF2A90
        public void get_MethodSignature(){} // RVA: 0x7ADAF2B60
        public void get_Properties(){} // RVA: 0x7ADAF2DB0
        public void get_TypeName(){} // RVA: 0x7ADAF2E60
        public void get_Uri(){} // RVA: 0x7A83F69F0
        public void set_Uri(){} // RVA: 0x7A8105A90
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x7A83F69F0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0x7A8105A90
        public void GetArg(){} // RVA: 0x7ADAF2F60
        public void get_Exception(){} // RVA: 0x7A8292C30
        public void get_OutArgs(){} // RVA: 0x7ADAF2F90
        public void get_ReturnValue(){} // RVA: 0x7A8105330
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7A8153390
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7A81533A0
    }

    public class ServerContextTerminatorSink : Object
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7ADAF30A0
        public void AsyncProcessMessage(){} // RVA: 0x7ADAF31A0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ServerObjectReplySink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9A41AA0
        public void SyncProcessMessage(){} // RVA: 0x7ADAF3600
        public void AsyncProcessMessage(){} // RVA: 0x7ADAF3680
    }

    public class ServerObjectTerminatorSink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void SyncProcessMessage(){} // RVA: 0x7ADAF3270
        public void AsyncProcessMessage(){} // RVA: 0x7ADAF33A0
    }

    public class StackBuilderSink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAF36C0
        public void SyncProcessMessage(){} // RVA: 0x7ADAF3770
        public void AsyncProcessMessage(){} // RVA: 0x7ADAF3860
        public void ExecuteAsyncMessage(){} // RVA: 0x7ADAF39A0
        public void CheckParameters(){} // RVA: 0x7ADAF3B80
        public void <AsyncProcessMessage>b__4_0(){} // RVA: 0x7ADAF3F00
    }

}