// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Messaging
// Classes: 3
// Methods: 57

namespace ThirdParty.DotNet.System.Runtime.Remoting.Messaging
{
    public class AsyncResult : Object
    {
        public object async_delegate; // 0x3030E120
        public object sync_completed; // 0x3030E120
        public object async_callback; // 0x3030E120
        public object add_time; // 0x3030E120
        public object reply_message; // 0x3030E120

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_AsyncState(){} // RVA: 0x7ffaa894d380
        public void get_AsyncWaitHandle(){} // RVA: 0x7ffaadead0e0
        public void get_CompletedSynchronously(){} // RVA: 0x7ffaa8bfcc70
        public void get_IsCompleted(){} // RVA: 0x7ffaa8de79d0
        public void get_EndInvokeCalled(){} // RVA: 0x7ffaa99a3bf0
        public void set_EndInvokeCalled(){} // RVA: 0x7ffaadead300
        public void get_AsyncDelegate(){} // RVA: 0x7ffaa89600c0
        public void get_NextSink(){} // RVA: 0x7ffaa8f22da0
        public void AsyncProcessMessage(){} // RVA: 0x7ffaadead310
        public void EndInvoke(){} // RVA: 0x7ffaadead350
        public void SyncProcessMessage(){} // RVA: 0x7ffaadead500
        public void get_CallMessage(){} // RVA: 0x7ffaa89d0370
        public void set_CallMessage(){} // RVA: 0x7ffaa89d0380
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7ffaadead770
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7ffaa8932310
        public void Invoke(){} // RVA: 0x7ffaadead8b0
        // ── Binary Analysis Named ──
        public void GetReplyMessage(){} // RVA: 0x7ffaa89fa590
        public void SetMessageCtrl(){} // RVA: 0x7ffaa89add60
        public void SetCompletedSynchronously(){} // RVA: 0x7ffaa8bfbbe0
    }

    public class LogicalCallContext : Object
    {
        public object m_Datastore; // 0x3509C9B0
        public object m_HostContext; // 0x3509C9B0
        public object _recvHeaders; // 0x3509C9B0
        public object HasInfo; // 0x1700044A
        public object HasUserData; // 0x1700044B
        public object Datastore; // 0x1700044C

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadeaae20
        public void .ctor(){} // RVA: 0x7ffaadeaae20
        public void Clone(){} // RVA: 0x7ffaadeabb90
        public void Merge(){} // RVA: 0x7ffaadeac4a0
        public void get_HasInfo(){} // RVA: 0x7ffaadeac790
        public void get_HasUserData(){} // RVA: 0x7ffaadeaaa60
        public void get_Datastore(){} // RVA: 0x7ffaadeac7f0
        public void .cctor(){} // RVA: 0x7ffaadeac9a0
        // ── Binary Analysis Named ──
        public void GetObjectData(){} // RVA: 0x7ffaadeab5d0
        public void GetData(){} // RVA: 0x7ffaadeac8a0
        public void SetData(){} // RVA: 0x7ffaadeac8e0
    }

    public class MonoMethodMessage : Object
    {
        public object names; // 0x3031FAD0
        public object rval; // 0x3031FAD0
        public object call_type; // 0x3031FAD0
        public object identity; // 0x3031FAD0

        // ── Original Methods ──
        public void InitMessage(){} // RVA: 0x7ffaadebb770
        public void .ctor(){} // RVA: 0x7ffaadebbfc0
        public void .ctor(){} // RVA: 0x7ffaadebbfc0
        public void .ctor(){} // RVA: 0x7ffaadebbfc0
        public void get_Properties(){} // RVA: 0x7ffaadebc120
        public void get_ArgCount(){} // RVA: 0x7ffaadebc1d0
        public void get_Args(){} // RVA: 0x7ffaa89357c0
        public void get_LogicalCallContext(){} // RVA: 0x7ffaa8bfcc80
        public void set_LogicalCallContext(){} // RVA: 0x7ffaa8960890
        public void get_MethodBase(){} // RVA: 0x7ffaa894d380
        public void get_MethodName(){} // RVA: 0x7ffaadebc210
        public void get_MethodSignature(){} // RVA: 0x7ffaadebc280
        public void get_TypeName(){} // RVA: 0x7ffaadebc470
        public void get_Uri(){} // RVA: 0x7ffaa89fa500
        public void set_Uri(){} // RVA: 0x7ffaa89fa510
        public void get_Exception(){} // RVA: 0x7ffaa89af740
        public void get_OutArgCount(){} // RVA: 0x7ffaadebc530
        public void get_OutArgs(){} // RVA: 0x7ffaadebc590
        public void get_ReturnValue(){} // RVA: 0x7ffaa8bf45b0
        public void System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity(){} // RVA: 0x7ffaa89add50
        public void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(){} // RVA: 0x7ffaa89add60
        public void get_AsyncResult(){} // RVA: 0x7ffaa89ad730
        public void get_CallType(){} // RVA: 0x7ffaadebc710
        public void NeedsOutProcessing(){} // RVA: 0x7ffaadebc850
        // ── Binary Analysis Named ──
        public void GetMethodInfo(){} // RVA: 0x7ffaadebbe90
        public void GetArg(){} // RVA: 0x7ffaadebc500
    }

}