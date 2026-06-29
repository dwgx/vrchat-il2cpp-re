// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Messaging
// Classes: 41
// Methods: 304

namespace ThirdParty.DotNet.System.Runtime.Remoting.Messaging
{
    public class ArgInfo : Object
    {
        public object _paramMap;
        public object _inoutArgCount;
        public object _method;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x676CFF0
        public void GetInOutArgs(){} // RVA: 0x676D280
    }

    public class AsyncResult : Object
    {
        public object async_state;
        public object handle;
        public object async_delegate;
        public object data;
        public object object_data;
        public object sync_completed;
        public object completed;
        public object endinvoke_called;
        public object async_callback;
        public object current;
        public object original;
        public object add_time;
        public object call_message;
        public object message_ctrl;
        public object reply_message;
        public object orig_cb;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_AsyncState(){} // RVA: 0xB5DBF0
        public void get_AsyncWaitHandle(){} // RVA: 0x676D410
        public void get_CompletedSynchronously(){} // RVA: 0xD16660
        public void get_IsCompleted(){} // RVA: 0xD15320
        public void get_EndInvokeCalled(){} // RVA: 0x1DC2880
        public void set_EndInvokeCalled(){} // RVA: 0x676D5E0
        public void get_AsyncDelegate(){} // RVA: 0xB700F0
        public void get_NextSink(){} // RVA: 0xDAC980
        public void AsyncProcessMessage(){} // RVA: 0x676D5F0
        public void GetReplyMessage(){} // RVA: 0xC10050
        public void SetMessageCtrl(){} // RVA: 0xBBFFA0
        public void SetCompletedSynchronously(){} // RVA: 0xD14C10
        public void EndInvoke(){} // RVA: 0x676D630
        public void SyncProcessMessage(){} // RVA: 0x676D7B0
        public void get_CallMessage(){} // RVA: 0xBE2C60
        public void set_CallMessage(){} // RVA: 0xBE2C70
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x676D9F0
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0xB43310
        public void Invoke(){} // RVA: 0x676DB40
    }

    public class CADArgHolder : Object
    {
        public object index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
    }

    public class CADMessageBase : Object
    {
        public object _args;
        public object _serializedArgs;
        public object _propertyCount;
        public object _callContext;
        public object serializedMethod;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x676EA50
        public void GetMethod(){} // RVA: 0x676EB30
        public void GetSignature(){} // RVA: 0x676EBC0
        public void MarshalProperties(){} // RVA: 0x676EDD0
        public void UnmarshalProperties(){} // RVA: 0x676F2C0
        public void IsPossibleToIgnoreMarshal(){} // RVA: 0x676F440
        public void MarshalArgument(){} // RVA: 0x676F620
        public void UnmarshalArgument(){} // RVA: 0x676F7B0
        public void MarshalArguments(){} // RVA: 0x6770210
        public void UnmarshalArguments(){} // RVA: 0x67703A0
        public void SaveLogicalCallContext(){} // RVA: 0x6770530
        public void GetLogicalCallContext(){} // RVA: 0x67706C0
    }

    public class CADMethodCallMessage : CADMessageBase
    {
        public object _uri;

        // ── Methods ──
        public void get_Uri(){} // RVA: 0xD05CA0
        public void Create(){} // RVA: 0x6770760
        public void .ctor(){} // RVA: 0x67707F0
        public void GetArguments(){} // RVA: 0x6770B90
        public void GetArgs(){} // RVA: 0x6770DF0
        public void get_PropertiesCount(){} // RVA: 0xFEAE90
    }

    public class CADMethodRef : Object
    {
        public object ctor;
        public object typeName;
        public object methodName;
        public object param_names;
        public object generic_arg_names;

        // ── Methods ──
        public void GetTypes(){} // RVA: 0x676DE00
        public void Resolve(){} // RVA: 0x676DFB0
        public void .ctor(){} // RVA: 0x676E5C0
    }

    public class CADMethodReturnMessage : CADMessageBase
    {
        public object _returnValue;
        public object _exception;
        public object _sig;

        // ── Methods ──
        public void Create(){} // RVA: 0x6770E00
        public void .ctor(){} // RVA: 0x6770E90
        public void GetArguments(){} // RVA: 0x67713B0
        public void GetArgs(){} // RVA: 0x6770DF0
        public void GetReturnValue(){} // RVA: 0x6771610
        public void GetException(){} // RVA: 0x6771620
        public void get_PropertiesCount(){} // RVA: 0xFEAE90
    }

    public class CADObjRef : Object
    {
        public object objref;
        public object SourceDomain;
        public object TypeInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x676DCA0
    }

    public class CallContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void SetCurrentCallContext(){} // RVA: 0xDAC980
        public void SetLogicalCallContext(){} // RVA: 0x676A800
        public void LogicalGetData(){} // RVA: 0x676A8A0
        public void LogicalSetData(){} // RVA: 0x676A9E0
    }

    public class CallContextRemotingData : Object
    {
        public object _logicalCallID;

        // ── Methods ──
        public void get_LogicalCallID(){} // RVA: 0xB5DBF0
        public void set_LogicalCallID(){} // RVA: 0xB44D60
        public void get_HasInfo(){} // RVA: 0x17B0810
        public void Clone(){} // RVA: 0x676CF50
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CallContextSecurityData : Object
    {
        public object _principal;

        // ── Methods ──
        public void get_HasInfo(){} // RVA: 0x17B0810
        public void Clone(){} // RVA: 0x676CEB0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ClientContextReplySink : Object
    {
        public object _replySink;
        public object _context;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xD5EFE0
        public void SyncProcessMessage(){} // RVA: 0x6771BA0
        public void AsyncProcessMessage(){} // RVA: 0x6771C60
    }

    public class ClientContextTerminatorSink : Object
    {
        public object _context;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void SyncProcessMessage(){} // RVA: 0x67716D0
        public void AsyncProcessMessage(){} // RVA: 0x6771890
    }

    public class ConstructionCall : MethodCall
    {
        public object _activator;
        public object _activationAttributes;
        public object _contextProperties;
        public object _activationType;
        public object _activationTypeName;
        public object _isContextOk;
        public object _sourceProxy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6771DA0
        public void InitDictionary(){} // RVA: 0x6771E50
        public void get_IsContextOk(){} // RVA: 0x1C4D9A0
        public void set_IsContextOk(){} // RVA: 0x1C4DB10
        public void get_ActivationType(){} // RVA: 0x6772050
        public void get_ActivationTypeName(){} // RVA: 0xB813B0
        public void get_Activator(){} // RVA: 0xBBFF90
        public void set_Activator(){} // RVA: 0xBBFFA0
        public void get_CallSiteActivationAttributes(){} // RVA: 0xC10050
        public void SetActivationAttributes(){} // RVA: 0xC10060
        public void get_ContextProperties(){} // RVA: 0x6772150
        public void InitMethodProperty(){} // RVA: 0x6772200
        public void GetObjectData(){} // RVA: 0x6772710
        public void get_Properties(){} // RVA: 0x6772F80
        public void get_SourceProxy(){} // RVA: 0x106A7D0
        public void set_SourceProxy(){} // RVA: 0xD5CC70
    }

    public class ConstructionCallDictionary : MessageDictionary
    {
        public object InternalKeys;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6772FC0
        public void GetMethodProperty(){} // RVA: 0x67730E0
        public void SetMethodProperty(){} // RVA: 0x67734F0
        public void .cctor(){} // RVA: 0x6773800
    }

    public class ConstructionResponse : MethodResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6773AA0
        public void get_Properties(){} // RVA: 0x6773B30
    }

    public class EnvoyTerminatorSink : Object
    {
        public object Instance;

        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x6773C70
        public void AsyncProcessMessage(){} // RVA: 0x6773D00
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6773DA0
    }

    public class ErrorMessage : Object
    {
        public object _uri;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6773E40
        public void get_ArgCount(){} // RVA: 0xDAC980
        public void get_Args(){} // RVA: 0xDAC980
        public void get_MethodBase(){} // RVA: 0xDAC980
        public void get_MethodName(){} // RVA: 0x6773ED0
        public void get_MethodSignature(){} // RVA: 0xDAC980
        public void get_Properties(){} // RVA: 0xDAC980
        public void get_TypeName(){} // RVA: 0x6773F10
        public void get_Uri(){} // RVA: 0xB5DBF0
        public void GetArg(){} // RVA: 0xDAC980
        public void get_LogicalCallContext(){} // RVA: 0xDAC980
    }

    public class HeaderHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23F1A30
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class Header[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IInternalMessage
    {
        // ── Methods ──
        public void get_TargetIdentity(){} // RVA: 0x87C0A0
        public void set_TargetIdentity(){} // RVA: 0x894320
        public void get_Uri(){} // RVA: 0x87C0A0
        public void set_Uri(){} // RVA: 0x894320
    }

    public class IMessage
    {
        // ── Methods ──
        public void get_Properties(){} // RVA: 0x87C0A0
    }

    public class IMessageSink
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x87C540
        public void AsyncProcessMessage(){} // RVA: 0x87C5F0
    }

    public class IMethodMessage
    {
        // ── Methods ──
        public void get_ArgCount(){} // RVA: 0x87C130
        public void get_Args(){} // RVA: 0x87C0A0
        public void get_LogicalCallContext(){} // RVA: 0x87C0A0
        public void get_MethodBase(){} // RVA: 0x87C0A0
        public void get_MethodName(){} // RVA: 0x87C0A0
        public void get_MethodSignature(){} // RVA: 0x87C0A0
        public void get_TypeName(){} // RVA: 0x87C0A0
        public void get_Uri(){} // RVA: 0x87C0A0
        public void GetArg(){} // RVA: 0x87C160
    }

    public class IMethodReturnMessage
    {
        // ── Methods ──
        public void get_Exception(){} // RVA: 0x87C0A0
        public void get_OutArgs(){} // RVA: 0x87C0A0
        public void get_ReturnValue(){} // RVA: 0x87C0A0
    }

    public class IllogicalCallContext : Object
    {
        public object m_Datastore;
        public object m_HostContext;

        // ── Methods ──
        public void get_Datastore(){} // RVA: 0x676AB20
        public void get_HostContext(){} // RVA: 0xB465B0
        public void set_HostContext(){} // RVA: 0xBA9BA0
        public void get_HasUserData(){} // RVA: 0x676ABD0
        public void FreeNamedDataSlot(){} // RVA: 0x676AC10
        public void CreateCopy(){} // RVA: 0x676AC50
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LogicalCallContext : Object
    {
        public object s_callContextType;
        public object m_Datastore;
        public object m_RemotingData;
        public object m_SecurityData;
        public object m_HostContext;
        public object m_IsCorrelationMgr;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x676AF80
        public void GetObjectData(){} // RVA: 0x676B720
        public void Clone(){} // RVA: 0x676BEF0
        public void Merge(){} // RVA: 0x676C7E0
        public void get_HasInfo(){} // RVA: 0x676CAC0
        public void get_HasUserData(){} // RVA: 0x676ABD0
        public void get_Datastore(){} // RVA: 0x676CB20
        public void GetData(){} // RVA: 0x676CBD0
        public void SetData(){} // RVA: 0x676CC10
        public void .cctor(){} // RVA: 0x676CCD0
    }

    public class MCMDictionary : MessageDictionary
    {
        public object InternalKeys;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6776F90
        public void .cctor(){} // RVA: 0x67770B0
    }

    public class MessageDictionary : Object
    {
        public object _internalProperties;
        public object _message;
        public object _methodKeys;
        public object _ownProperties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA9BA0
        public void HasUserData(){} // RVA: 0x6777250
        public void get_InternalDictionary(){} // RVA: 0x6777340
        public void set_MethodKeys(){} // RVA: 0xB70100
        public void AllocInternalProperties(){} // RVA: 0x67773F0
        public void GetInternalProperties(){} // RVA: 0x6777450
        public void IsOverridenKey(){} // RVA: 0x67774E0
        public void get_IsFixedSize(){} // RVA: 0xB43320
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void get_Item(){} // RVA: 0x6777590
        public void set_Item(){} // RVA: 0x67776F0
        public void GetMethodProperty(){} // RVA: 0x6777700
        public void SetMethodProperty(){} // RVA: 0x6777C60
        public void get_Keys(){} // RVA: 0x6777E80
        public void get_Values(){} // RVA: 0x67782A0
        public void Add(){} // RVA: 0x6778700
        public void Clear(){} // RVA: 0x67788D0
        public void Contains(){} // RVA: 0x6778930
        public void Remove(){} // RVA: 0x6778A70
        public void get_Count(){} // RVA: 0x6778BF0
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void get_SyncRoot(){} // RVA: 0x2303260
        public void CopyTo(){} // RVA: 0x6778C60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6778CD0
        public void GetEnumerator(){} // RVA: 0x6778D30
    }

    public class MethodCall : Object
    {
        public object _uri;
        public object _typeName;
        public object _methodName;
        public object _args;
        public object _methodSignature;
        public object _methodBase;
        public object _callContext;
        public object _targetIdentity;
        public object _genericArguments;
        public object ExternalProperties;
        public object InternalProperties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CopyFrom(){} // RVA: 0x6774310
        public void InitMethodProperty(){} // RVA: 0x67746C0
        public void GetObjectData(){} // RVA: 0x6774D10
        public void get_ArgCount(){} // RVA: 0x6775E80
        public void get_Args(){} // RVA: 0xB70160
        public void get_LogicalCallContext(){} // RVA: 0x6775EA0
        public void get_MethodBase(){} // RVA: 0x6775F40
        public void get_MethodName(){} // RVA: 0x6775FB0
        public void get_MethodSignature(){} // RVA: 0x6776040
        public void get_Properties(){} // RVA: 0x6772F80
        public void InitDictionary(){} // RVA: 0x6776290
        public void get_TypeName(){} // RVA: 0x67763B0
        public void get_Uri(){} // RVA: 0xB5DBF0
        public void set_Uri(){} // RVA: 0xB44D60
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0xB5DBF0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0xB44D60
        public void GetArg(){} // RVA: 0x6776470
        public void Init(){} // RVA: 0xB43310
        public void ResolveMethod(){} // RVA: 0x67764A0
        public void CastTo(){} // RVA: 0x6776BB0
        public void GetTypeNameFromAssemblyQualifiedName(){} // RVA: 0x6776E30
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0xBBF8F0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0xBBF900
        public void get_GenericArguments(){} // RVA: 0x6776EF0
    }

    public class MethodResponse : Object
    {
        public object _methodName;
        public object _uri;
        public object _typeName;
        public object _methodBase;
        public object _returnValue;
        public object _exception;
        public object _methodSignature;
        public object _inArgInfo;
        public object _args;
        public object _outArgs;
        public object _callMsg;
        public object _callContext;
        public object _targetIdentity;
        public object ExternalProperties;
        public object InternalProperties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6773AA0
        public void InitMethodProperty(){} // RVA: 0x6779D50
        public void get_ArgCount(){} // RVA: 0x677A440
        public void get_Args(){} // RVA: 0xBE58B0
        public void get_Exception(){} // RVA: 0xD05CA0
        public void get_LogicalCallContext(){} // RVA: 0x677A460
        public void get_MethodBase(){} // RVA: 0x677A500
        public void get_MethodName(){} // RVA: 0x677A790
        public void get_MethodSignature(){} // RVA: 0x677A840
        public void get_OutArgs(){} // RVA: 0x677A960
        public void get_Properties(){} // RVA: 0x6773B30
        public void get_ReturnValue(){} // RVA: 0xD33E60
        public void get_TypeName(){} // RVA: 0x677AA70
        public void get_Uri(){} // RVA: 0x677AB20
        public void set_Uri(){} // RVA: 0xBA9BA0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x677AB20
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0xBA9BA0
        public void GetArg(){} // RVA: 0x677ABD0
        public void GetObjectData(){} // RVA: 0x677AC00
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0xC10050
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0xC10060
    }

    public class MethodReturnDictionary : MessageDictionary
    {
        public object InternalReturnKeys;
        public object InternalExceptionKeys;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x677BE70
        public void .cctor(){} // RVA: 0x677C040
    }

    public class MonoMethodMessage : Object
    {
        public object method;
        public object args;
        public object names;
        public object arg_types;
        public object ctx;
        public object rval;
        public object exc;
        public object asyncResult;
        public object call_type;
        public object uri;
        public object properties;
        public object identity;
        public object methodSignature;

        // ── Methods ──
        public void InitMessage(){} // RVA: 0x677C2C0
        public void .ctor(){} // RVA: 0x677CBA0
        public void GetMethodInfo(){} // RVA: 0x677CA70
        public void get_Properties(){} // RVA: 0x677CD00
        public void get_ArgCount(){} // RVA: 0x677CDB0
        public void get_Args(){} // RVA: 0xB465B0
        public void get_LogicalCallContext(){} // RVA: 0xD33E60
        public void set_LogicalCallContext(){} // RVA: 0xB708C0
        public void get_MethodBase(){} // RVA: 0xB5DBF0
        public void get_MethodName(){} // RVA: 0x677CDF0
        public void get_MethodSignature(){} // RVA: 0x677CE30
        public void get_TypeName(){} // RVA: 0x677D040
        public void get_Uri(){} // RVA: 0xC0FFC0
        public void set_Uri(){} // RVA: 0xC0FFD0
        public void GetArg(){} // RVA: 0x677D0A0
        public void get_Exception(){} // RVA: 0xBC1B30
        public void get_OutArgCount(){} // RVA: 0x677D0D0
        public void get_OutArgs(){} // RVA: 0x677D130
        public void get_ReturnValue(){} // RVA: 0xD05CA0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0xBBFF90
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0xBBFFA0
        public void get_AsyncResult(){} // RVA: 0xBBF8F0
        public void get_CallType(){} // RVA: 0x677D2D0
        public void NeedsOutProcessing(){} // RVA: 0x677D3E0
    }

    public class ObjRefSurrogate : Object
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x677D530
        public void SetObjectData(){} // RVA: 0x677D640
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RemotingSurrogate : Object
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x677D460
        public void SetObjectData(){} // RVA: 0x677D4F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RemotingSurrogateSelector : Object
    {
        public object s_cachedTypeObjRef;
        public object _objRefSurrogate;
        public object _objRemotingSurrogate;
        public object _next;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void ChainSelector(){} // RVA: 0x677D690
        public void GetSurrogate(){} // RVA: 0x677D750
        public void .cctor(){} // RVA: 0x677D970
    }

    public class ReturnMessage : Object
    {
        public object _outArgs;
        public object _args;
        public object _callCtx;
        public object _returnValue;
        public object _uri;
        public object _exception;
        public object _methodBase;
        public object _methodName;
        public object _methodSignature;
        public object _typeName;
        public object _properties;
        public object _targetIdentity;
        public object _inArgInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x677DE30
        public void get_ArgCount(){} // RVA: 0x3E42680
        public void get_Args(){} // RVA: 0xB465B0
        public void get_LogicalCallContext(){} // RVA: 0x677E020
        public void get_MethodBase(){} // RVA: 0xBC1B30
        public void get_MethodName(){} // RVA: 0x677E0C0
        public void get_MethodSignature(){} // RVA: 0x677E190
        public void get_Properties(){} // RVA: 0x677E3E0
        public void get_TypeName(){} // RVA: 0x677E490
        public void get_Uri(){} // RVA: 0xD33E60
        public void set_Uri(){} // RVA: 0xB708C0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0xD33E60
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0xB708C0
        public void GetArg(){} // RVA: 0x677E590
        public void get_Exception(){} // RVA: 0xD05CA0
        public void get_OutArgs(){} // RVA: 0x677E5C0
        public void get_ReturnValue(){} // RVA: 0xB70160
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0xBBFF90
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0xBBFFA0
    }

    public class ServerContextTerminatorSink : Object
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x677E6D0
        public void AsyncProcessMessage(){} // RVA: 0x677E7D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ServerObjectReplySink : Object
    {
        public object _replySink;
        public object _identity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xD5EFE0
        public void SyncProcessMessage(){} // RVA: 0x677EC30
        public void AsyncProcessMessage(){} // RVA: 0x677ECB0
    }

    public class ServerObjectTerminatorSink : Object
    {
        public object _nextSink;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void SyncProcessMessage(){} // RVA: 0x677E8A0
        public void AsyncProcessMessage(){} // RVA: 0x677E9D0
    }

    public class StackBuilderSink : Object
    {
        public object _target;
        public object _rp;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x677ECF0
        public void SyncProcessMessage(){} // RVA: 0x677EDA0
        public void AsyncProcessMessage(){} // RVA: 0x677EE90
        public void ExecuteAsyncMessage(){} // RVA: 0x677EFD0
        public void CheckParameters(){} // RVA: 0x677F1B0
        public void <AsyncProcessMessage>b__4_0(){} // RVA: 0x677F530
    }

}