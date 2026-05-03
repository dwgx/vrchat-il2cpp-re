// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Messaging
// Classes: 44
// Methods: 301

namespace ThirdParty.DotNet.System.Runtime.Remoting.Messaging
{
    public class ArgInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86835440
        public void GetInOutArgs(){} // RVA: 0x7FFE868356D0
    }

    public class AsyncResult : Object
    {
        public object async_state; // 0x10
        public System.Threading.WaitHandle handle; // 0x18
        public object async_delegate; // 0x20
        public UIntPtr data; // 0x28
        public object object_data; // 0x30
        public bool sync_completed; // 0x38
        public bool completed; // 0x39
        public bool endinvoke_called; // 0x3A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_AsyncState(){} // RVA: 0x7FFE81116380
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFE86835830
        public void get_CompletedSynchronously(){} // RVA: 0x7FFE812CF770
        public void get_IsCompleted(){} // RVA: 0x7FFE812CF7D0
        public void get_EndInvokeCalled(){} // RVA: 0x7FFE82230840
        public void set_EndInvokeCalled(){} // RVA: 0x7FFE86835A50
        public void get_AsyncDelegate(){} // RVA: 0x7FFE811290C0
        public void get_NextSink(){} // RVA: 0x7FFE813240E0
        public void AsyncProcessMessage(){} // RVA: 0x7FFE86835A60
        public void GetReplyMessage(){} // RVA: 0x7FFE811C3590
        public void SetMessageCtrl(){} // RVA: 0x7FFE81176D60
        public void SetCompletedSynchronously(){} // RVA: 0x7FFE812D0010
        public void EndInvoke(){} // RVA: 0x7FFE86835AA0
        public void SyncProcessMessage(){} // RVA: 0x7FFE86835C50
        public void get_CallMessage(){} // RVA: 0x7FFE81199370
        public void set_CallMessage(){} // RVA: 0x7FFE81199380
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFE86835EC0
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7FFE810FB310
        public void Invoke(){} // RVA: 0x7FFE86836000
    }

    public class CADArgHolder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class CADMessageBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86836EA0
        public void GetMethod(){} // RVA: 0x7FFE86836F80
        public void GetSignature(){} // RVA: 0x7FFE86837010
        public void MarshalProperties(){} // RVA: 0x7FFE86837220
        public void UnmarshalProperties(){} // RVA: 0x7FFE86837750
        public void IsPossibleToIgnoreMarshal(){} // RVA: 0x7FFE868378D0
        public void MarshalArgument(){} // RVA: 0x7FFE86837AC0
        public void UnmarshalArgument(){} // RVA: 0x7FFE86837C50
        public void MarshalArguments(){} // RVA: 0x7FFE868387F0
        public void UnmarshalArguments(){} // RVA: 0x7FFE86838970
        public void SaveLogicalCallContext(){} // RVA: 0x7FFE86838AF0
        public void GetLogicalCallContext(){} // RVA: 0x7FFE86838C80
    }

    public class CADMethodCallMessage : CADMessageBase
    {
        public string _uri; // 0x38
        public object field_1; // 0x45A

        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7FFE8143BA80
        public void Create(){} // RVA: 0x7FFE86838D20
        public void .ctor(){} // RVA: 0x7FFE86838DB0
        public void GetArguments(){} // RVA: 0x7FFE86839150
        public void GetArgs(){} // RVA: 0x7FFE868393B0
        public void get_PropertiesCount(){} // RVA: 0x7FFE8151D690
    }

    public class CADMethodRef : Object
    {
        // ── Methods ──
        public void GetTypes(){} // RVA: 0x7FFE868362B0
        public void Resolve(){} // RVA: 0x7FFE86836450
        public void .ctor(){} // RVA: 0x7FFE86836A50
    }

    public class CADMethodReturnMessage : CADMessageBase
    {
        public object _returnValue; // 0x38

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE868393C0
        public void .ctor(){} // RVA: 0x7FFE86839450
        public void GetArguments(){} // RVA: 0x7FFE86839970
        public void GetArgs(){} // RVA: 0x7FFE868393B0
        public void GetReturnValue(){} // RVA: 0x7FFE86839BD0
        public void GetException(){} // RVA: 0x7FFE86839BE0
        public void get_PropertiesCount(){} // RVA: 0x7FFE8151D690
    }

    public class CADObjRef : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86836150
    }

    public class CallContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void SetCurrentCallContext(){} // RVA: 0x7FFE813240E0
        public void SetLogicalCallContext(){} // RVA: 0x7FFE86832DE0
        public void LogicalGetData(){} // RVA: 0x7FFE86832E80
        public void LogicalSetData(){} // RVA: 0x7FFE86832FC0
    }

    public class CallContextRemotingData : Object
    {
        public string _logicalCallID; // 0x10
        public object field_1; // 0x450

        // ── Methods ──
        public void get_LogicalCallID(){} // RVA: 0x7FFE81116380
        public void set_LogicalCallID(){} // RVA: 0x7FFE810FCE30
        public void get_HasInfo(){} // RVA: 0x7FFE81C8DC00
        public void Clone(){} // RVA: 0x7FFE868353A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CallContextSecurityData : Object
    {
        public System.Security.Principal.IPrincipal _principal; // 0x10

        // ── Methods ──
        public void get_HasInfo(){} // RVA: 0x7FFE81C8DC00
        public void Clone(){} // RVA: 0x7FFE86835300
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ClientContextReplySink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A057B0
        public void SyncProcessMessage(){} // RVA: 0x7FFE8683A160
        public void AsyncProcessMessage(){} // RVA: 0x7FFE8683A220
    }

    public class ClientContextTerminatorSink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void SyncProcessMessage(){} // RVA: 0x7FFE86839C90
        public void AsyncProcessMessage(){} // RVA: 0x7FFE86839E50
    }

    public class ConstructionCall : MethodCall
    {
        public System.Runtime.Remoting.Activation.IActivator _activator; // 0x68
        public object[] _activationAttributes; // 0x70
        public System.Collections.IList _contextProperties; // 0x78
        public System.Type _activationType; // 0x80
        public string _activationTypeName; // 0x88
        public bool _isContextOk; // 0x90
        public System.Runtime.Remoting.Proxies.RemotingProxy _sourceProxy; // 0x98
        public object field_7; // 0x45D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8683A360 | overloaded x2
        public void InitDictionary(){} // RVA: 0x7FFE8683A420
        public void get_IsContextOk(){} // RVA: 0x7FFE820BF400
        public void set_IsContextOk(){} // RVA: 0x7FFE820BFEB0
        public void get_ActivationType(){} // RVA: 0x7FFE8683A620
        public void get_ActivationTypeName(){} // RVA: 0x7FFE8113A010
        public void get_Activator(){} // RVA: 0x7FFE81176D50
        public void set_Activator(){} // RVA: 0x7FFE81176D60
        public void get_CallSiteActivationAttributes(){} // RVA: 0x7FFE811C3590
        public void SetActivationAttributes(){} // RVA: 0x7FFE811C35A0
        public void get_ContextProperties(){} // RVA: 0x7FFE8683A730
        public void InitMethodProperty(){} // RVA: 0x7FFE8683A7E0
        public void GetObjectData(){} // RVA: 0x7FFE8683AD10
        public void get_Properties(){} // RVA: 0x7FFE8683B590
        public void get_SourceProxy(){} // RVA: 0x7FFE817AE360
        public void set_SourceProxy(){} // RVA: 0x7FFE8171B470
    }

    public class ConstructionCallDictionary : MessageDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8683B5D0
        public void GetMethodProperty(){} // RVA: 0x7FFE8683B6F0
        public void SetMethodProperty(){} // RVA: 0x7FFE8683BB00
        public void .cctor(){} // RVA: 0x7FFE8683BE10
    }

    public class ConstructionResponse : MethodResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8683C0B0 | overloaded x3
        public void get_Properties(){} // RVA: 0x7FFE8683C140
    }

    public class EnvoyTerminatorSink : Object
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7FFE8683C280
        public void AsyncProcessMessage(){} // RVA: 0x7FFE8683C310
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8683C3B0
    }

    public class ErrorMessage : Object
    {
        public string _uri; // 0x10
        public object field_1; // 0x466
        public object field_2; // 0x467
        public object field_3; // 0x468
        public object field_4; // 0x469
        public object field_5; // 0x46A
        public object field_6; // 0x46B
        public object field_7; // 0x46C
        public object field_8; // 0x46D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8683C450
        public void get_ArgCount(){} // RVA: 0x7FFE813240E0
        public void get_Args(){} // RVA: 0x7FFE813240E0
        public void get_MethodBase(){} // RVA: 0x7FFE813240E0
        public void get_MethodName(){} // RVA: 0x7FFE8683C4E0
        public void get_MethodSignature(){} // RVA: 0x7FFE813240E0
        public void get_Properties(){} // RVA: 0x7FFE813240E0
        public void get_TypeName(){} // RVA: 0x7FFE8683C520
        public void get_Uri(){} // RVA: 0x7FFE81116380
        public void GetArg(){} // RVA: 0x7FFE813240E0
        public void get_LogicalCallContext(){} // RVA: 0x7FFE813240E0
    }

    public class Header : Object
    {
    }

    public class HeaderHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828B3580
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class IInternalMessage
    {
        // ── Methods ──
        public void get_TargetIdentity(){} // RVA: 0x7FFE80E2E2E0
        public void set_TargetIdentity(){} // RVA: 0x7FFE80E460A0
        public void get_Uri(){} // RVA: 0x7FFE80E2E2E0
        public void set_Uri(){} // RVA: 0x7FFE80E460A0
    }

    public class IMessage
    {
        // ── Methods ──
        public void get_Properties(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IMessageCtrl
    {
    }

    public class IMessageSink
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7FFE80E2E390
        public void AsyncProcessMessage(){} // RVA: 0x7FFE80E3FC10
    }

    public class IMethodCallMessage
    {
    }

    public class IMethodMessage
    {
        // ── Methods ──
        public void get_ArgCount(){} // RVA: 0x7FFE80E2EDB0
        public void get_Args(){} // RVA: 0x7FFE80E2E2E0
        public void get_LogicalCallContext(){} // RVA: 0x7FFE80E2E2E0
        public void get_MethodBase(){} // RVA: 0x7FFE80E2E2E0
        public void get_MethodName(){} // RVA: 0x7FFE80E2E2E0
        public void get_MethodSignature(){} // RVA: 0x7FFE80E2E2E0
        public void get_TypeName(){} // RVA: 0x7FFE80E2E2E0
        public void get_Uri(){} // RVA: 0x7FFE80E2E2E0
        public void GetArg(){} // RVA: 0x7FFE80E3D230
    }

    public class IMethodReturnMessage
    {
        // ── Methods ──
        public void get_Exception(){} // RVA: 0x7FFE80E2E2E0
        public void get_OutArgs(){} // RVA: 0x7FFE80E2E2E0
        public void get_ReturnValue(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IllogicalCallContext : Object
    {
        public System.Collections.Hashtable m_Datastore; // 0x10
        public object m_HostContext; // 0x18
        public object field_2; // 0x447

        // ── Methods ──
        public void get_Datastore(){} // RVA: 0x7FFE86833100
        public void get_HostContext(){} // RVA: 0x7FFE810FE7C0
        public void set_HostContext(){} // RVA: 0x7FFE81161E80
        public void get_HasUserData(){} // RVA: 0x7FFE868331B0
        public void FreeNamedDataSlot(){} // RVA: 0x7FFE868331F0
        public void CreateCopy(){} // RVA: 0x7FFE86833230
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class LogicalCallContext : Object
    {
        public System.Type s_callContextType;
        public string s_CorrelationMgrSlotName;
        public System.Collections.Hashtable m_Datastore; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86833570 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFE86833D20
        public void Clone(){} // RVA: 0x7FFE868342E0
        public void Merge(){} // RVA: 0x7FFE86834BF0
        public void get_HasInfo(){} // RVA: 0x7FFE86834EE0
        public void get_HasUserData(){} // RVA: 0x7FFE868331B0
        public void get_Datastore(){} // RVA: 0x7FFE86834F40
        public void GetData(){} // RVA: 0x7FFE86834FF0
        public void SetData(){} // RVA: 0x7FFE86835030
        public void .cctor(){} // RVA: 0x7FFE868350F0
    }

    public class MCMDictionary : MessageDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8683F620
        public void .cctor(){} // RVA: 0x7FFE8683F740
    }

    public class MessageDictionary : Object
    {
        public System.Collections.IDictionary _internalProperties; // 0x10
        public System.Runtime.Remoting.Messaging.IMethodMessage _message; // 0x18
        public string[] _methodKeys; // 0x20
        public bool _ownProperties; // 0x28
        public object field_4; // 0x489
        public object field_5; // 0x48A
        public object field_6; // 0x48B
        public object field_7; // 0x48C
        public object field_8; // 0x48D
        public object field_9; // 0x48E

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81161E80
        public void HasUserData(){} // RVA: 0x7FFE8683F8E0
        public void get_InternalDictionary(){} // RVA: 0x7FFE8683F9D0
        public void set_MethodKeys(){} // RVA: 0x7FFE811290D0
        public void AllocInternalProperties(){} // RVA: 0x7FFE8683FA80
        public void GetInternalProperties(){} // RVA: 0x7FFE8683FAE0
        public void IsOverridenKey(){} // RVA: 0x7FFE8683FB70
        public void get_IsFixedSize(){} // RVA: 0x7FFE810FB320
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void get_Item(){} // RVA: 0x7FFE8683FC10
        public void set_Item(){} // RVA: 0x7FFE8683FD70
        public void GetMethodProperty(){} // RVA: 0x7FFE8683FD80
        public void SetMethodProperty(){} // RVA: 0x7FFE868402E0
        public void get_Keys(){} // RVA: 0x7FFE86840510
        public void get_Values(){} // RVA: 0x7FFE86840950
        public void Add(){} // RVA: 0x7FFE86840DD0
        public void Clear(){} // RVA: 0x7FFE86840FA0
        public void Contains(){} // RVA: 0x7FFE86841000
        public void Remove(){} // RVA: 0x7FFE86841140
        public void get_Count(){} // RVA: 0x7FFE868412C0
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_SyncRoot(){} // RVA: 0x7FFE827C4A80
        public void CopyTo(){} // RVA: 0x7FFE86841330
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE868413A0
        public void GetEnumerator(){} // RVA: 0x7FFE86841400
    }

    public class MethodCall : Object
    {
        public string _uri; // 0x10
        public string _typeName; // 0x18
        public string _methodName; // 0x20
        public object[] _args; // 0x28
        public System.Type[] _methodSignature; // 0x30
        public System.Reflection.MethodBase _methodBase; // 0x38
        public System.Runtime.Remoting.Messaging.LogicalCallContext _callContext; // 0x40
        public System.Runtime.Remoting.Identity _targetIdentity; // 0x48
        public System.Type[] _genericArguments; // 0x50
        public System.Collections.IDictionary ExternalProperties; // 0x58
        public System.Collections.IDictionary InternalProperties; // 0x60
        public object field_11; // 0x47D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x3
        public void CopyFrom(){} // RVA: 0x7FFE8683C920
        public void InitMethodProperty(){} // RVA: 0x7FFE8683CCC0
        public void GetObjectData(){} // RVA: 0x7FFE8683D320
        public void get_ArgCount(){} // RVA: 0x7FFE8683E4F0
        public void get_Args(){} // RVA: 0x7FFE81129130
        public void get_LogicalCallContext(){} // RVA: 0x7FFE8683E510
        public void get_MethodBase(){} // RVA: 0x7FFE8683E5B0
        public void get_MethodName(){} // RVA: 0x7FFE8683E620
        public void get_MethodSignature(){} // RVA: 0x7FFE8683E6B0
        public void get_Properties(){} // RVA: 0x7FFE8683B590
        public void InitDictionary(){} // RVA: 0x7FFE8683E8E0
        public void get_TypeName(){} // RVA: 0x7FFE8683EA00
        public void get_Uri(){} // RVA: 0x7FFE81116380
        public void set_Uri(){} // RVA: 0x7FFE810FCE30
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x7FFE81116380
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0x7FFE810FCE30
        public void GetArg(){} // RVA: 0x7FFE8683EAC0
        public void Init(){} // RVA: 0x7FFE810FB310
        public void ResolveMethod(){} // RVA: 0x7FFE8683EAF0
        public void CastTo(){} // RVA: 0x7FFE8683F220
        public void GetTypeNameFromAssemblyQualifiedName(){} // RVA: 0x7FFE8683F4C0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7FFE81176730
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7FFE81176740
        public void get_GenericArguments(){} // RVA: 0x7FFE8683F580
    }

    public class MethodResponse : Object
    {
        public string _methodName; // 0x10
        public string _uri; // 0x18
        public string _typeName; // 0x20
        public System.Reflection.MethodBase _methodBase; // 0x28
        public object _returnValue; // 0x30
        public System.Exception _exception; // 0x38
        public System.Type[] _methodSignature; // 0x40
        public System.Runtime.Remoting.Messaging.ArgInfo _inArgInfo; // 0x48
        public object[] _args; // 0x50
        public object[] _outArgs; // 0x58
        public System.Runtime.Remoting.Messaging.IMethodCallMessage _callMsg; // 0x60
        public System.Runtime.Remoting.Messaging.LogicalCallContext _callContext; // 0x68
        public System.Runtime.Remoting.Identity _targetIdentity; // 0x70
        public System.Collections.IDictionary ExternalProperties; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8683C0B0 | overloaded x4
        public void InitMethodProperty(){} // RVA: 0x7FFE86842410
        public void get_ArgCount(){} // RVA: 0x7FFE86842B10
        public void get_Args(){} // RVA: 0x7FFE8119C0E0
        public void get_Exception(){} // RVA: 0x7FFE8143BA80
        public void get_LogicalCallContext(){} // RVA: 0x7FFE86842B30
        public void get_MethodBase(){} // RVA: 0x7FFE86842BD0
        public void get_MethodName(){} // RVA: 0x7FFE86842E60
        public void get_MethodSignature(){} // RVA: 0x7FFE86842F10
        public void get_OutArgs(){} // RVA: 0x7FFE86843030
        public void get_Properties(){} // RVA: 0x7FFE8683C140
        public void get_ReturnValue(){} // RVA: 0x7FFE8144E200
        public void get_TypeName(){} // RVA: 0x7FFE86843140
        public void get_Uri(){} // RVA: 0x7FFE868431F0
        public void set_Uri(){} // RVA: 0x7FFE81161E80
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x7FFE868431F0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0x7FFE81161E80
        public void GetArg(){} // RVA: 0x7FFE868432A0
        public void GetObjectData(){} // RVA: 0x7FFE868432D0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7FFE811C3590
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7FFE811C35A0
    }

    public class MethodReturnDictionary : MessageDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86843A70
        public void .cctor(){} // RVA: 0x7FFE86843C40
    }

    public class MonoMethodMessage : Object
    {
        public System.Reflection.RuntimeMethodInfo method; // 0x10
        public object[] args; // 0x18
        public string[] names; // 0x20
        public byte[] arg_types; // 0x28
        public System.Runtime.Remoting.Messaging.LogicalCallContext ctx; // 0x30
        public object rval; // 0x38
        public System.Exception exc; // 0x40
        public System.Runtime.Remoting.Messaging.AsyncResult asyncResult; // 0x48
        public 0x664CB0E4 call_type; // 0x50
        public string uri; // 0x58
        public System.Runtime.Remoting.Messaging.MCMDictionary properties; // 0x60
        public System.Runtime.Remoting.Identity identity; // 0x68
        public System.Type[] methodSignature; // 0x70
        public object field_13; // 0x4A5
        public object field_14; // 0x4A6
        public object field_15; // 0x4A7

        // ── Methods ──
        public void InitMessage(){} // RVA: 0x7FFE86843EC0
        public void .ctor(){} // RVA: 0x7FFE86844710 | overloaded x3
        public void GetMethodInfo(){} // RVA: 0x7FFE868445E0
        public void get_Properties(){} // RVA: 0x7FFE86844870
        public void get_ArgCount(){} // RVA: 0x7FFE86844920
        public void get_Args(){} // RVA: 0x7FFE810FE7C0
        public void get_LogicalCallContext(){} // RVA: 0x7FFE8144E200
        public void set_LogicalCallContext(){} // RVA: 0x7FFE81129890
        public void get_MethodBase(){} // RVA: 0x7FFE81116380
        public void get_MethodName(){} // RVA: 0x7FFE86844960
        public void get_MethodSignature(){} // RVA: 0x7FFE868449D0
        public void get_TypeName(){} // RVA: 0x7FFE86844BC0
        public void get_Uri(){} // RVA: 0x7FFE811C3500
        public void set_Uri(){} // RVA: 0x7FFE811C3510
        public void GetArg(){} // RVA: 0x7FFE86844C50
        public void get_Exception(){} // RVA: 0x7FFE81178740
        public void get_OutArgCount(){} // RVA: 0x7FFE86844C80
        public void get_OutArgs(){} // RVA: 0x7FFE86844CE0
        public void get_ReturnValue(){} // RVA: 0x7FFE8143BA80
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7FFE81176D50
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7FFE81176D60
        public void get_AsyncResult(){} // RVA: 0x7FFE81176730
        public void get_CallType(){} // RVA: 0x7FFE86844E60
        public void NeedsOutProcessing(){} // RVA: 0x7FFE86844FA0
    }

    public class ObjRefSurrogate : Object
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x7FFE868450F0
        public void SetObjectData(){} // RVA: 0x7FFE86845200
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OneWayAttribute : Attribute
    {
    }

    public class RemotingSurrogate : Object
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x7FFE86845020
        public void SetObjectData(){} // RVA: 0x7FFE868450B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RemotingSurrogateSelector : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void ChainSelector(){} // RVA: 0x7FFE86845250
        public void GetSurrogate(){} // RVA: 0x7FFE86845310
        public void .cctor(){} // RVA: 0x7FFE86845530
    }

    public class ReturnMessage : Object
    {
        public object[] _outArgs; // 0x10
        public object[] _args; // 0x18
        public System.Runtime.Remoting.Messaging.LogicalCallContext _callCtx; // 0x20
        public object _returnValue; // 0x28
        public string _uri; // 0x30
        public System.Exception _exception; // 0x38
        public System.Reflection.MethodBase _methodBase; // 0x40
        public string _methodName; // 0x48
        public System.Type[] _methodSignature; // 0x50
        public string _typeName; // 0x58
        public System.Runtime.Remoting.Messaging.MethodReturnDictionary _properties; // 0x60
        public System.Runtime.Remoting.Identity _targetIdentity; // 0x68
        public System.Runtime.Remoting.Messaging.ArgInfo _inArgInfo; // 0x70
        public object field_13; // 0x4B5

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86845A10 | overloaded x2
        public void get_ArgCount(){} // RVA: 0x7FFE84023030
        public void get_Args(){} // RVA: 0x7FFE810FE7C0
        public void get_LogicalCallContext(){} // RVA: 0x7FFE86845C00
        public void get_MethodBase(){} // RVA: 0x7FFE81178740
        public void get_MethodName(){} // RVA: 0x7FFE86845CA0
        public void get_MethodSignature(){} // RVA: 0x7FFE86845D70
        public void get_Properties(){} // RVA: 0x7FFE86845FA0
        public void get_TypeName(){} // RVA: 0x7FFE86846050
        public void get_Uri(){} // RVA: 0x7FFE8144E200
        public void set_Uri(){} // RVA: 0x7FFE81129890
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x7FFE8144E200
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0x7FFE81129890
        public void GetArg(){} // RVA: 0x7FFE86846150
        public void get_Exception(){} // RVA: 0x7FFE8143BA80
        public void get_OutArgs(){} // RVA: 0x7FFE86846180
        public void get_ReturnValue(){} // RVA: 0x7FFE81129130
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7FFE81176D50
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7FFE81176D60
    }

    public class ServerContextTerminatorSink : Object
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7FFE86846290
        public void AsyncProcessMessage(){} // RVA: 0x7FFE86846390
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ServerObjectReplySink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A057B0
        public void SyncProcessMessage(){} // RVA: 0x7FFE868467F0
        public void AsyncProcessMessage(){} // RVA: 0x7FFE86846870
    }

    public class ServerObjectTerminatorSink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void SyncProcessMessage(){} // RVA: 0x7FFE86846460
        public void AsyncProcessMessage(){} // RVA: 0x7FFE86846590
    }

    public class StackBuilderSink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868468B0
        public void SyncProcessMessage(){} // RVA: 0x7FFE86846960
        public void AsyncProcessMessage(){} // RVA: 0x7FFE86846A50
        public void ExecuteAsyncMessage(){} // RVA: 0x7FFE86846B90
        public void CheckParameters(){} // RVA: 0x7FFE86846D70
        public void <AsyncProcessMessage>b__4_0(){} // RVA: 0x7FFE868470E0
    }

}