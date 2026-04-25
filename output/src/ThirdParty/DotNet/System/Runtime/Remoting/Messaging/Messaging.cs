// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Messaging
// Classes: 44
// Methods: 301

namespace ThirdParty.DotNet.System.Runtime.Remoting.Messaging
{
    public class ArgInfo : Object
    {
        public int[] _paramMap; // 0x10
        public int _inoutArgCount; // 0x18
        public System.Reflection.MethodBase _method; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC848BB40
        public void GetInOutArgs(){} // RVA: 0x7FFAC848BDD0
    }

    public class AsyncResult : Object
    {
        public object AsyncState; // 0x10
        public System.Threading.WaitHandle AsyncWaitHandle; // 0x18
        public object CompletedSynchronously; // 0x20
        public UIntPtr IsCompleted; // 0x28
        public object EndInvokeCalled; // 0x30
        public bool AsyncDelegate; // 0x38
        public bool NextSink; // 0x39
        public bool CallMessage; // 0x3A
        public object async_callback; // 0x40
        public System.Threading.ExecutionContext current; // 0x48
        public System.Threading.ExecutionContext original; // 0x50
        public long add_time; // 0x58
        public System.Runtime.Remoting.Messaging.MonoMethodMessage call_message; // 0x60
        public System.Runtime.Remoting.Messaging.IMessageCtrl message_ctrl; // 0x68
        public System.Runtime.Remoting.Messaging.IMessage reply_message; // 0x70
        public System.Threading.WaitCallback orig_cb; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_AsyncState(){} // RVA: 0x7FFAC2F3C380
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFAC848BF30
        public void get_CompletedSynchronously(){} // RVA: 0x7FFAC31D95D0
        public void get_IsCompleted(){} // RVA: 0x7FFAC33BCE50
        public void get_EndInvokeCalled(){} // RVA: 0x7FFAC3F7B7C0
        public void set_EndInvokeCalled(){} // RVA: 0x7FFAC848C150
        public void get_AsyncDelegate(){} // RVA: 0x7FFAC2F4F0C0
        public void get_NextSink(){} // RVA: 0x7FFAC34F9180
        public void AsyncProcessMessage(){} // RVA: 0x7FFAC848C160
        public void GetReplyMessage(){} // RVA: 0x7FFAC2FE9590
        public void SetMessageCtrl(){} // RVA: 0x7FFAC2F9CD60
        public void SetCompletedSynchronously(){} // RVA: 0x7FFAC31D95C0
        public void EndInvoke(){} // RVA: 0x7FFAC848C1A0
        public void SyncProcessMessage(){} // RVA: 0x7FFAC848C350
        public void get_CallMessage(){} // RVA: 0x7FFAC2FBF370
        public void set_CallMessage(){} // RVA: 0x7FFAC2FBF380
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFAC848C5C0
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7FFAC2F21310
        public void Invoke(){} // RVA: 0x7FFAC848C700
    }

    public class CADArgHolder : Object
    {
        public int index; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class CADMessageBase : Object
    {
        public object[] _args; // 0x10
        public byte[] _serializedArgs; // 0x18
        public int _propertyCount; // 0x20
        public System.Runtime.Remoting.Messaging.CADArgHolder _callContext; // 0x28
        public byte[] serializedMethod; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC848D5A0
        public void GetMethod(){} // RVA: 0x7FFAC848D680
        public void GetSignature(){} // RVA: 0x7FFAC848D710
        public void MarshalProperties(){} // RVA: 0x7FFAC848D920
        public void UnmarshalProperties(){} // RVA: 0x7FFAC848DE50
        public void IsPossibleToIgnoreMarshal(){} // RVA: 0x7FFAC848DFD0
        public void MarshalArgument(){} // RVA: 0x7FFAC848E1C0
        public void UnmarshalArgument(){} // RVA: 0x7FFAC848E350
        public void MarshalArguments(){} // RVA: 0x7FFAC848EEF0
        public void UnmarshalArguments(){} // RVA: 0x7FFAC848F070
        public void SaveLogicalCallContext(){} // RVA: 0x7FFAC848F1F0
        public void GetLogicalCallContext(){} // RVA: 0x7FFAC848F380
    }

    public class CADMethodCallMessage : CADMessageBase
    {
        public string Uri; // 0x38

        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7FFAC31D0140
        public void Create(){} // RVA: 0x7FFAC848F420
        public void .ctor(){} // RVA: 0x7FFAC848F4B0
        public void GetArguments(){} // RVA: 0x7FFAC848F850
        public void GetArgs(){} // RVA: 0x7FFAC848FAB0
        public void get_PropertiesCount(){} // RVA: 0x7FFAC30DBBE0
    }

    public class CADMethodRef : Object
    {
        public bool ctor; // 0x10
        public string typeName; // 0x18
        public string methodName; // 0x20
        public string[] param_names; // 0x28
        public string[] generic_arg_names; // 0x30

        // ── Methods ──
        public void GetTypes(){} // RVA: 0x7FFAC848C9B0
        public void Resolve(){} // RVA: 0x7FFAC848CB50
        public void .ctor(){} // RVA: 0x7FFAC848D150
    }

    public class CADMethodReturnMessage : CADMessageBase
    {
        public object PropertiesCount; // 0x38
        public System.Runtime.Remoting.Messaging.CADArgHolder _exception; // 0x40
        public System.Type[] _sig; // 0x48

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC848FAC0
        public void .ctor(){} // RVA: 0x7FFAC848FB50
        public void GetArguments(){} // RVA: 0x7FFAC8490070
        public void GetArgs(){} // RVA: 0x7FFAC848FAB0
        public void GetReturnValue(){} // RVA: 0x7FFAC84902D0
        public void GetException(){} // RVA: 0x7FFAC84902E0
        public void get_PropertiesCount(){} // RVA: 0x7FFAC30DBBE0
    }

    public class CADObjRef : Object
    {
        public System.Runtime.Remoting.ObjRef objref; // 0x10
        public int SourceDomain; // 0x18
        public byte[] TypeInfo; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC848C850
    }

    public class CallContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void SetCurrentCallContext(){} // RVA: 0x7FFAC34F9180
        public void SetLogicalCallContext(){} // RVA: 0x7FFAC84894E0
        public void LogicalGetData(){} // RVA: 0x7FFAC8489580
        public void LogicalSetData(){} // RVA: 0x7FFAC84896C0
    }

    public class CallContextRemotingData : Object
    {
        public string LogicalCallID; // 0x10

        // ── Methods ──
        public void get_LogicalCallID(){} // RVA: 0x7FFAC2F3C380
        public void set_LogicalCallID(){} // RVA: 0x7FFAC2F22E30
        public void get_HasInfo(){} // RVA: 0x7FFAC34D2B40
        public void Clone(){} // RVA: 0x7FFAC848BAA0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CallContextSecurityData : Object
    {
        public System.Security.Principal.IPrincipal HasInfo; // 0x10

        // ── Methods ──
        public void get_HasInfo(){} // RVA: 0x7FFAC34D2B40
        public void Clone(){} // RVA: 0x7FFAC848BA00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ClientContextReplySink : Object
    {
        public System.Runtime.Remoting.Messaging.IMessageSink _replySink; // 0x10
        public System.Runtime.Remoting.Contexts.Context _context; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC46FBCC0
        public void SyncProcessMessage(){} // RVA: 0x7FFAC8490860
        public void AsyncProcessMessage(){} // RVA: 0x7FFAC8490920
    }

    public class ClientContextTerminatorSink : Object
    {
        public System.Runtime.Remoting.Contexts.Context _context; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void SyncProcessMessage(){} // RVA: 0x7FFAC8490390
        public void AsyncProcessMessage(){} // RVA: 0x7FFAC8490550
    }

    public class ConstructionCall : MethodCall
    {
        public System.Runtime.Remoting.Activation.IActivator IsContextOk; // 0x68
        public object[] ActivationType; // 0x70
        public System.Collections.IList ActivationTypeName; // 0x78
        public System.Type Activator; // 0x80
        public string CallSiteActivationAttributes; // 0x88
        public bool ContextProperties; // 0x90
        public System.Runtime.Remoting.Proxies.RemotingProxy Properties; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8490A60 | overloaded x2
        public void InitDictionary(){} // RVA: 0x7FFAC8490B20
        public void get_IsContextOk(){} // RVA: 0x7FFAC3E0D160
        public void set_IsContextOk(){} // RVA: 0x7FFAC3E089B0
        public void get_ActivationType(){} // RVA: 0x7FFAC8490D20
        public void get_ActivationTypeName(){} // RVA: 0x7FFAC2F60010
        public void get_Activator(){} // RVA: 0x7FFAC2F9CD50
        public void set_Activator(){} // RVA: 0x7FFAC2F9CD60
        public void get_CallSiteActivationAttributes(){} // RVA: 0x7FFAC2FE9590
        public void SetActivationAttributes(){} // RVA: 0x7FFAC2FE95A0
        public void get_ContextProperties(){} // RVA: 0x7FFAC8490E30
        public void InitMethodProperty(){} // RVA: 0x7FFAC8490EE0
        public void GetObjectData(){} // RVA: 0x7FFAC8491410
        public void get_Properties(){} // RVA: 0x7FFAC8491C90
        public void get_SourceProxy(){} // RVA: 0x7FFAC354DFB0
        public void set_SourceProxy(){} // RVA: 0x7FFAC354E3C0
    }

    public class ConstructionCallDictionary : MessageDictionary
    {
        public string[] InternalKeys;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8491CD0
        public void GetMethodProperty(){} // RVA: 0x7FFAC8491DF0
        public void SetMethodProperty(){} // RVA: 0x7FFAC8492200
        public void .cctor(){} // RVA: 0x7FFAC8492510
    }

    public class ConstructionResponse : MethodResponse
    {
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84927B0 | overloaded x3
        public void get_Properties(){} // RVA: 0x7FFAC8492840
    }

    public class EnvoyTerminatorSink : Object
    {
        public System.Runtime.Remoting.Messaging.EnvoyTerminatorSink Instance;

        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7FFAC8492980
        public void AsyncProcessMessage(){} // RVA: 0x7FFAC8492A10
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8492AB0
    }

    public class ErrorMessage : Object
    {
        public string ArgCount; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8492B50
        public void get_ArgCount(){} // RVA: 0x7FFAC34F9180
        public void get_Args(){} // RVA: 0x7FFAC34F9180
        public void get_MethodBase(){} // RVA: 0x7FFAC34F9180
        public void get_MethodName(){} // RVA: 0x7FFAC8492BE0
        public void get_MethodSignature(){} // RVA: 0x7FFAC34F9180
        public void get_Properties(){} // RVA: 0x7FFAC34F9180
        public void get_TypeName(){} // RVA: 0x7FFAC8492C20
        public void get_Uri(){} // RVA: 0x7FFAC2F3C380
        public void GetArg(){} // RVA: 0x7FFAC34F9180
        public void get_LogicalCallContext(){} // RVA: 0x7FFAC34F9180
    }

    public class Header : Object
    {
        public string HeaderNamespace; // 0x10
        public bool MustUnderstand; // 0x18
        public string Name; // 0x20
        public object Value; // 0x28
    }

    public class HeaderHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3AD0660
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class IInternalMessage
    {
        public object TargetIdentity;
        public object Uri;

        // ── Methods ──
        public void get_TargetIdentity(){} // RVA: 0x7FFAC2C58E90
        public void set_TargetIdentity(){} // RVA: 0x7FFAC2C70A40
        public void get_Uri(){} // RVA: 0x7FFAC2C58E90
        public void set_Uri(){} // RVA: 0x7FFAC2C70A40
    }

    public class IMessage
    {
        public object Properties;

        // ── Methods ──
        public void get_Properties(){} // RVA: 0x7FFAC2C58E90
    }

    public class IMessageCtrl
    {
    }

    public class IMessageSink
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7FFAC2C58F40
        public void AsyncProcessMessage(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class IMethodCallMessage
    {
    }

    public class IMethodMessage
    {
        public object ArgCount;
        public object Args;
        public object LogicalCallContext;
        public object MethodBase;
        public object MethodName;
        public object MethodSignature;
        public object TypeName;
        public object Uri;

        // ── Methods ──
        public void get_ArgCount(){} // RVA: 0x7FFAC2C59960
        public void get_Args(){} // RVA: 0x7FFAC2C58E90
        public void get_LogicalCallContext(){} // RVA: 0x7FFAC2C58E90
        public void get_MethodBase(){} // RVA: 0x7FFAC2C58E90
        public void get_MethodName(){} // RVA: 0x7FFAC2C58E90
        public void get_MethodSignature(){} // RVA: 0x7FFAC2C58E90
        public void get_TypeName(){} // RVA: 0x7FFAC2C58E90
        public void get_Uri(){} // RVA: 0x7FFAC2C58E90
        public void GetArg(){} // RVA: 0x7FFAC2C67DE0
    }

    public class IMethodReturnMessage
    {
        public object Exception;
        public object OutArgs;
        public object ReturnValue;

        // ── Methods ──
        public void get_Exception(){} // RVA: 0x7FFAC2C58E90
        public void get_OutArgs(){} // RVA: 0x7FFAC2C58E90
        public void get_ReturnValue(){} // RVA: 0x7FFAC2C58E90
    }

    public class IllogicalCallContext : Object
    {
        public System.Collections.Hashtable Datastore; // 0x10
        public object HostContext; // 0x18

        // ── Methods ──
        public void get_Datastore(){} // RVA: 0x7FFAC8489800
        public void get_HostContext(){} // RVA: 0x7FFAC2F247C0
        public void set_HostContext(){} // RVA: 0x7FFAC2F87E80
        public void get_HasUserData(){} // RVA: 0x7FFAC84898B0
        public void FreeNamedDataSlot(){} // RVA: 0x7FFAC84898F0
        public void CreateCopy(){} // RVA: 0x7FFAC8489930
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class LogicalCallContext : Object
    {
        public System.Type HasInfo;
        public string HasUserData;
        public System.Collections.Hashtable Datastore; // 0x10
        public System.Runtime.Remoting.Messaging.CallContextRemotingData m_RemotingData; // 0x18
        public System.Runtime.Remoting.Messaging.CallContextSecurityData m_SecurityData; // 0x20
        public object m_HostContext; // 0x28
        public bool m_IsCorrelationMgr; // 0x30
        public System.Runtime.Remoting.Messaging.Header[] _sendHeaders; // 0x38
        public System.Runtime.Remoting.Messaging.Header[] _recvHeaders; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8489C70 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFAC848A420
        public void Clone(){} // RVA: 0x7FFAC848A9E0
        public void Merge(){} // RVA: 0x7FFAC848B2F0
        public void get_HasInfo(){} // RVA: 0x7FFAC848B5E0
        public void get_HasUserData(){} // RVA: 0x7FFAC84898B0
        public void get_Datastore(){} // RVA: 0x7FFAC848B640
        public void GetData(){} // RVA: 0x7FFAC848B6F0
        public void SetData(){} // RVA: 0x7FFAC848B730
        public void .cctor(){} // RVA: 0x7FFAC848B7F0
    }

    public class MCMDictionary : MessageDictionary
    {
        public string[] InternalKeys;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8495D20
        public void .cctor(){} // RVA: 0x7FFAC8495E40
    }

    public class MessageDictionary : Object
    {
        public System.Collections.IDictionary InternalDictionary; // 0x10
        public System.Runtime.Remoting.Messaging.IMethodMessage MethodKeys; // 0x18
        public string[] IsFixedSize; // 0x20
        public bool IsReadOnly; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F87E80
        public void HasUserData(){} // RVA: 0x7FFAC8495FE0
        public void get_InternalDictionary(){} // RVA: 0x7FFAC84960D0
        public void set_MethodKeys(){} // RVA: 0x7FFAC2F4F0D0
        public void AllocInternalProperties(){} // RVA: 0x7FFAC8496180
        public void GetInternalProperties(){} // RVA: 0x7FFAC84961E0
        public void IsOverridenKey(){} // RVA: 0x7FFAC8496270
        public void get_IsFixedSize(){} // RVA: 0x7FFAC2F21320
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void get_Item(){} // RVA: 0x7FFAC8496310
        public void set_Item(){} // RVA: 0x7FFAC8496470
        public void GetMethodProperty(){} // RVA: 0x7FFAC8496480
        public void SetMethodProperty(){} // RVA: 0x7FFAC84969E0
        public void get_Keys(){} // RVA: 0x7FFAC8496C10
        public void get_Values(){} // RVA: 0x7FFAC8497050
        public void Add(){} // RVA: 0x7FFAC84974D0
        public void Clear(){} // RVA: 0x7FFAC84976A0
        public void Contains(){} // RVA: 0x7FFAC8497700
        public void Remove(){} // RVA: 0x7FFAC8497840
        public void get_Count(){} // RVA: 0x7FFAC84979C0
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
        public void CopyTo(){} // RVA: 0x7FFAC8497A30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8497AA0
        public void GetEnumerator(){} // RVA: 0x7FFAC8497B00
    }

    public class MethodCall : Object
    {
        public string ArgCount; // 0x10
        public string Args; // 0x18
        public string LogicalCallContext; // 0x20
        public object[] MethodBase; // 0x28
        public System.Type[] MethodName; // 0x30
        public System.Reflection.MethodBase MethodSignature; // 0x38
        public System.Runtime.Remoting.Messaging.LogicalCallContext Properties; // 0x40
        public System.Runtime.Remoting.Identity TypeName; // 0x48
        public System.Type[] Uri; // 0x50
        public System.Collections.IDictionary System.Runtime.Remoting.Messaging.IInternalMessage.Uri; // 0x58
        public System.Collections.IDictionary System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x3
        public void CopyFrom(){} // RVA: 0x7FFAC8493020
        public void InitMethodProperty(){} // RVA: 0x7FFAC84933C0
        public void GetObjectData(){} // RVA: 0x7FFAC8493A20
        public void get_ArgCount(){} // RVA: 0x7FFAC8494BF0
        public void get_Args(){} // RVA: 0x7FFAC2F4F130
        public void get_LogicalCallContext(){} // RVA: 0x7FFAC8494C10
        public void get_MethodBase(){} // RVA: 0x7FFAC8494CB0
        public void get_MethodName(){} // RVA: 0x7FFAC8494D20
        public void get_MethodSignature(){} // RVA: 0x7FFAC8494DB0
        public void get_Properties(){} // RVA: 0x7FFAC8491C90
        public void InitDictionary(){} // RVA: 0x7FFAC8494FE0
        public void get_TypeName(){} // RVA: 0x7FFAC8495100
        public void get_Uri(){} // RVA: 0x7FFAC2F3C380
        public void set_Uri(){} // RVA: 0x7FFAC2F22E30
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x7FFAC2F3C380
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0x7FFAC2F22E30
        public void GetArg(){} // RVA: 0x7FFAC84951C0
        public void Init(){} // RVA: 0x7FFAC2F21310
        public void ResolveMethod(){} // RVA: 0x7FFAC84951F0
        public void CastTo(){} // RVA: 0x7FFAC8495920
        public void GetTypeNameFromAssemblyQualifiedName(){} // RVA: 0x7FFAC8495BC0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7FFAC2F9C730
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7FFAC2F9C740
        public void get_GenericArguments(){} // RVA: 0x7FFAC8495C80
    }

    public class MethodResponse : Object
    {
        public string ArgCount; // 0x10
        public string Args; // 0x18
        public string Exception; // 0x20
        public System.Reflection.MethodBase LogicalCallContext; // 0x28
        public object MethodBase; // 0x30
        public System.Exception MethodName; // 0x38
        public System.Type[] MethodSignature; // 0x40
        public System.Runtime.Remoting.Messaging.ArgInfo OutArgs; // 0x48
        public object[] Properties; // 0x50
        public object[] ReturnValue; // 0x58
        public System.Runtime.Remoting.Messaging.IMethodCallMessage TypeName; // 0x60
        public System.Runtime.Remoting.Messaging.LogicalCallContext Uri; // 0x68
        public System.Runtime.Remoting.Identity System.Runtime.Remoting.Messaging.IInternalMessage.Uri; // 0x70
        public System.Collections.IDictionary System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity; // 0x78
        public System.Collections.IDictionary InternalProperties; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84927B0 | overloaded x4
        public void InitMethodProperty(){} // RVA: 0x7FFAC8498B10
        public void get_ArgCount(){} // RVA: 0x7FFAC8499210
        public void get_Args(){} // RVA: 0x7FFAC2FC20E0
        public void get_Exception(){} // RVA: 0x7FFAC31D0140
        public void get_LogicalCallContext(){} // RVA: 0x7FFAC8499230
        public void get_MethodBase(){} // RVA: 0x7FFAC84992D0
        public void get_MethodName(){} // RVA: 0x7FFAC8499560
        public void get_MethodSignature(){} // RVA: 0x7FFAC8499610
        public void get_OutArgs(){} // RVA: 0x7FFAC8499730
        public void get_Properties(){} // RVA: 0x7FFAC8492840
        public void get_ReturnValue(){} // RVA: 0x7FFAC31D95E0
        public void get_TypeName(){} // RVA: 0x7FFAC8499840
        public void get_Uri(){} // RVA: 0x7FFAC84998F0
        public void set_Uri(){} // RVA: 0x7FFAC2F87E80
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x7FFAC84998F0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0x7FFAC2F87E80
        public void GetArg(){} // RVA: 0x7FFAC84999A0
        public void GetObjectData(){} // RVA: 0x7FFAC84999D0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7FFAC2FE9590
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7FFAC2FE95A0
    }

    public class MethodReturnDictionary : MessageDictionary
    {
        public string[] InternalReturnKeys;
        public string[] InternalExceptionKeys; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC849A170
        public void .cctor(){} // RVA: 0x7FFAC849A340
    }

    public class MonoMethodMessage : Object
    {
        public System.Reflection.RuntimeMethodInfo Properties; // 0x10
        public object[] ArgCount; // 0x18
        public string[] Args; // 0x20
        public byte[] LogicalCallContext; // 0x28
        public System.Runtime.Remoting.Messaging.LogicalCallContext MethodBase; // 0x30
        public object MethodName; // 0x38
        public System.Exception MethodSignature; // 0x40
        public System.Runtime.Remoting.Messaging.AsyncResult TypeName; // 0x48
        public 0x6B0D21C0 Uri; // 0x50
        public string Exception; // 0x58
        public System.Runtime.Remoting.Messaging.MCMDictionary OutArgCount; // 0x60
        public System.Runtime.Remoting.Identity OutArgs; // 0x68
        public System.Type[] ReturnValue; // 0x70

        // ── Methods ──
        public void InitMessage(){} // RVA: 0x7FFAC849A5C0
        public void .ctor(){} // RVA: 0x7FFAC849AE10 | overloaded x3
        public void GetMethodInfo(){} // RVA: 0x7FFAC849ACE0
        public void get_Properties(){} // RVA: 0x7FFAC849AF70
        public void get_ArgCount(){} // RVA: 0x7FFAC849B020
        public void get_Args(){} // RVA: 0x7FFAC2F247C0
        public void get_LogicalCallContext(){} // RVA: 0x7FFAC31D95E0
        public void set_LogicalCallContext(){} // RVA: 0x7FFAC2F4F890
        public void get_MethodBase(){} // RVA: 0x7FFAC2F3C380
        public void get_MethodName(){} // RVA: 0x7FFAC849B060
        public void get_MethodSignature(){} // RVA: 0x7FFAC849B0D0
        public void get_TypeName(){} // RVA: 0x7FFAC849B2C0
        public void get_Uri(){} // RVA: 0x7FFAC2FE9500
        public void set_Uri(){} // RVA: 0x7FFAC2FE9510
        public void GetArg(){} // RVA: 0x7FFAC849B350
        public void get_Exception(){} // RVA: 0x7FFAC2F9E740
        public void get_OutArgCount(){} // RVA: 0x7FFAC849B380
        public void get_OutArgs(){} // RVA: 0x7FFAC849B3E0
        public void get_ReturnValue(){} // RVA: 0x7FFAC31D0140
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7FFAC2F9CD50
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7FFAC2F9CD60
        public void get_AsyncResult(){} // RVA: 0x7FFAC2F9C730
        public void get_CallType(){} // RVA: 0x7FFAC849B560
        public void NeedsOutProcessing(){} // RVA: 0x7FFAC849B6A0
    }

    public class ObjRefSurrogate : Object
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x7FFAC849B7F0
        public void SetObjectData(){} // RVA: 0x7FFAC849B900
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OneWayAttribute : Attribute
    {
    }

    public class RemotingSurrogate : Object
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x7FFAC849B720
        public void SetObjectData(){} // RVA: 0x7FFAC849B7B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RemotingSurrogateSelector : Object
    {
        public System.Type s_cachedTypeObjRef;
        public System.Runtime.Remoting.Messaging.ObjRefSurrogate _objRefSurrogate; // 0x8
        public System.Runtime.Remoting.Messaging.RemotingSurrogate _objRemotingSurrogate; // 0x10
        public System.Runtime.Serialization.ISurrogateSelector _next; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void ChainSelector(){} // RVA: 0x7FFAC849B950
        public void GetSurrogate(){} // RVA: 0x7FFAC849BA10
        public void .cctor(){} // RVA: 0x7FFAC849BC30
    }

    public class ReturnMessage : Object
    {
        public object[] ArgCount; // 0x10
        public object[] Args; // 0x18
        public System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext; // 0x20
        public object MethodBase; // 0x28
        public string MethodName; // 0x30
        public System.Exception MethodSignature; // 0x38
        public System.Reflection.MethodBase Properties; // 0x40
        public string TypeName; // 0x48
        public System.Type[] Uri; // 0x50
        public string System.Runtime.Remoting.Messaging.IInternalMessage.Uri; // 0x58
        public System.Runtime.Remoting.Messaging.MethodReturnDictionary Exception; // 0x60
        public System.Runtime.Remoting.Identity OutArgs; // 0x68
        public System.Runtime.Remoting.Messaging.ArgInfo ReturnValue; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC849C110 | overloaded x2
        public void get_ArgCount(){} // RVA: 0x7FFAC5CC4BA0
        public void get_Args(){} // RVA: 0x7FFAC2F247C0
        public void get_LogicalCallContext(){} // RVA: 0x7FFAC849C300
        public void get_MethodBase(){} // RVA: 0x7FFAC2F9E740
        public void get_MethodName(){} // RVA: 0x7FFAC849C3A0
        public void get_MethodSignature(){} // RVA: 0x7FFAC849C470
        public void get_Properties(){} // RVA: 0x7FFAC849C6A0
        public void get_TypeName(){} // RVA: 0x7FFAC849C750
        public void get_Uri(){} // RVA: 0x7FFAC31D95E0
        public void set_Uri(){} // RVA: 0x7FFAC2F4F890
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri(){} // RVA: 0x7FFAC31D95E0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(){} // RVA: 0x7FFAC2F4F890
        public void GetArg(){} // RVA: 0x7FFAC849C850
        public void get_Exception(){} // RVA: 0x7FFAC31D0140
        public void get_OutArgs(){} // RVA: 0x7FFAC849C880
        public void get_ReturnValue(){} // RVA: 0x7FFAC2F4F130
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7FFAC2F9CD50
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7FFAC2F9CD60
    }

    public class ServerContextTerminatorSink : Object
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7FFAC849C990
        public void AsyncProcessMessage(){} // RVA: 0x7FFAC849CA90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ServerObjectReplySink : Object
    {
        public System.Runtime.Remoting.Messaging.IMessageSink _replySink; // 0x10
        public System.Runtime.Remoting.ServerIdentity _identity; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC46FBCC0
        public void SyncProcessMessage(){} // RVA: 0x7FFAC849CEF0
        public void AsyncProcessMessage(){} // RVA: 0x7FFAC849CF70
    }

    public class ServerObjectTerminatorSink : Object
    {
        public System.Runtime.Remoting.Messaging.IMessageSink _nextSink; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void SyncProcessMessage(){} // RVA: 0x7FFAC849CB60
        public void AsyncProcessMessage(){} // RVA: 0x7FFAC849CC90
    }

    public class StackBuilderSink : Object
    {
        public System.MarshalByRefObject _target; // 0x10
        public System.Runtime.Remoting.Proxies.RealProxy _rp; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC849CFB0
        public void SyncProcessMessage(){} // RVA: 0x7FFAC849D060
        public void AsyncProcessMessage(){} // RVA: 0x7FFAC849D150
        public void ExecuteAsyncMessage(){} // RVA: 0x7FFAC849D290
        public void CheckParameters(){} // RVA: 0x7FFAC849D470
        public void <AsyncProcessMessage>b__4_0(){} // RVA: 0x7FFAC849D7E0
    }

}