// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Messaging
// Classes: 3
// Methods: 57

namespace ThirdParty.DotNet.System.Runtime.Remoting.Messaging
{
    public class AsyncResult : Object
    {
        public object AsyncState; // 0x10
        public sageKind.arameter AsyncWaitHandle; // 0x18
        public object CompletedSynchronously; // 0x20
        public UIntPtr IsCompleted; // 0x28
        public object EndInvokeCalled; // 0x30
        public bool AsyncDelegate; // 0x38
        public bool NextSink; // 0x39
        public bool CallMessage; // 0x3A
        public object async_callback; // 0x40
        public sageKind.d current; // 0x48
        public sageKind.d original; // 0x50
        public long add_time; // 0x58
        public _HasPrivateKey.tyRemovableStorageSid call_message; // 0x60
        public _HasPrivateKey.nSid message_ctrl; // 0x68
        public _HasPrivateKey.ganizationSid reply_message; // 0x70
        public sageKind.legate_internal orig_cb; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_AsyncState(){} // RVA: 0x7FFD4E35C380
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFD538ABF30
        public void get_CompletedSynchronously(){} // RVA: 0x7FFD4E5F95D0
        public void get_IsCompleted(){} // RVA: 0x7FFD4E7DCE50
        public void get_EndInvokeCalled(){} // RVA: 0x7FFD4F39B7C0
        public void set_EndInvokeCalled(){} // RVA: 0x7FFD538AC150
        public void get_AsyncDelegate(){} // RVA: 0x7FFD4E36F0C0
        public void get_NextSink(){} // RVA: 0x7FFD4E919180
        public void AsyncProcessMessage(){} // RVA: 0x7FFD538AC160
        public void GetReplyMessage(){} // RVA: 0x7FFD4E409590
        public void SetMessageCtrl(){} // RVA: 0x7FFD4E3BCD60
        public void SetCompletedSynchronously(){} // RVA: 0x7FFD4E5F95C0
        public void EndInvoke(){} // RVA: 0x7FFD538AC1A0
        public void SyncProcessMessage(){} // RVA: 0x7FFD538AC350
        public void get_CallMessage(){} // RVA: 0x7FFD4E3DF370
        public void set_CallMessage(){} // RVA: 0x7FFD4E3DF380
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFD538AC5C0
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7FFD4E341310
        public void Invoke(){} // RVA: 0x7FFD538AC700
    }

    public class LogicalCallContext : Object
    {
        public object HasInfo;
        public string HasUserData;
        public mePatterns.MES_SIZE Datastore; // 0x10
        public _HasPrivateKey.ricPrincipal m_RemotingData; // 0x18
        public _HasPrivateKey.ation m_SecurityData; // 0x20
        public object m_HostContext; // 0x28
        public bool m_IsCorrelationMgr; // 0x30
        public _HasPrivateKey.tributes[] _sendHeaders; // 0x38
        public _HasPrivateKey.tributes[] _recvHeaders; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD538A9C70 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFD538AA420
        public void Clone(){} // RVA: 0x7FFD538AA9E0
        public void Merge(){} // RVA: 0x7FFD538AB2F0
        public void get_HasInfo(){} // RVA: 0x7FFD538AB5E0
        public void get_HasUserData(){} // RVA: 0x7FFD538A98B0
        public void get_Datastore(){} // RVA: 0x7FFD538AB640
        public void GetData(){} // RVA: 0x7FFD538AB6F0
        public void SetData(){} // RVA: 0x7FFD538AB730
        public void .cctor(){} // RVA: 0x7FFD538AB7F0
    }

    public class MonoMethodMessage : Object
    {
        public m.cessArchitecture Properties; // 0x10
        public object[] ArgCount; // 0x18
        public string[] Args; // 0x20
        public byte[] LogicalCallContext; // 0x28
        public _HasPrivateKey.iables MethodBase; // 0x30
        public object MethodName; // 0x38
        public ÏÏÍÍÎÎ MethodSignature; // 0x40
        public _HasPrivateKey.m TypeName; // 0x48
        public _HasPrivateKey.oken Uri; // 0x50
        public string Exception; // 0x58
        public _HasPrivateKey.isOrganizationCertificateSid OutArgCount; // 0x60
        public Arguments.eliver>5__2 OutArgs; // 0x68
        public ?[] ReturnValue; // 0x70

        // ── Methods ──
        public void InitMessage(){} // RVA: 0x7FFD538BA5C0
        public void .ctor(){} // RVA: 0x7FFD538BAE10 | overloaded x3
        public void GetMethodInfo(){} // RVA: 0x7FFD538BACE0
        public void get_Properties(){} // RVA: 0x7FFD538BAF70
        public void get_ArgCount(){} // RVA: 0x7FFD538BB020
        public void get_Args(){} // RVA: 0x7FFD4E3447C0
        public void get_LogicalCallContext(){} // RVA: 0x7FFD4E5F95E0
        public void set_LogicalCallContext(){} // RVA: 0x7FFD4E36F890
        public void get_MethodBase(){} // RVA: 0x7FFD4E35C380
        public void get_MethodName(){} // RVA: 0x7FFD538BB060
        public void get_MethodSignature(){} // RVA: 0x7FFD538BB0D0
        public void get_TypeName(){} // RVA: 0x7FFD538BB2C0
        public void get_Uri(){} // RVA: 0x7FFD4E409500
        public void set_Uri(){} // RVA: 0x7FFD4E409510
        public void GetArg(){} // RVA: 0x7FFD538BB350
        public void get_Exception(){} // RVA: 0x7FFD4E3BE740
        public void get_OutArgCount(){} // RVA: 0x7FFD538BB380
        public void get_OutArgs(){} // RVA: 0x7FFD538BB3E0
        public void get_ReturnValue(){} // RVA: 0x7FFD4E5F0140
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7FFD4E3BCD50
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7FFD4E3BCD60
        public void get_AsyncResult(){} // RVA: 0x7FFD4E3BC730
        public void get_CallType(){} // RVA: 0x7FFD538BB560
        public void NeedsOutProcessing(){} // RVA: 0x7FFD538BB6A0
    }

}