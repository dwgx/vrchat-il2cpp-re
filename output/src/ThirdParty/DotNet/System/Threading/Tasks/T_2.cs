// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 70
// Methods: 246

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class TaskAsyncEnumerableExtensions : Object
    {
        // ── Methods ──
        public void ConfigureAwait(){} // RVA: 0x6D293E0
    }

    public class TaskAwaiters : Object
    {
        // ── Methods ──
        public void ForceAsync(){} // RVA: 0x18D7680
    }

    public class TaskCanceledException : OperationCanceledException
    {
        public object _canceledTask;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class TaskCompletionSource`1 : Object
    {
        public object _task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BB8050
        public void get_Task(){} // RVA: 0xB5DBF0
        public void SpinUntilCompleted(){} // RVA: 0x4BB8110
        public void TrySetException(){} // RVA: 0x4BB8220
        public void SetException(){} // RVA: 0x4BB8280
        public void TrySetResult(){} // RVA: 0x4BB82F0
        public void SetResult(){} // RVA: 0x4BB8330
        public void TrySetCanceled(){} // RVA: 0x4BB8400
        public void SetCanceled(){} // RVA: 0x4BB8490
    }

    public class TaskCompletionSource`1 : Object
    {
        public object _task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BB9F90
        public void get_Task(){} // RVA: 0xB5DBF0
        public void SpinUntilCompleted(){} // RVA: 0x4BBA060
        public void TrySetException(){} // RVA: 0x4BBA170
        public void SetException(){} // RVA: 0x4BBA1F0
        public void TrySetResult(){} // RVA: 0x4BBA240
        public void SetResult(){} // RVA: 0x4BBA350
        public void TrySetCanceled(){} // RVA: 0x4BBA460
        public void SetCanceled(){} // RVA: 0x4BBA510
    }

    public class TaskCompletionSource`1 : Object
    {
        public object _task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BB9080
        public void get_Task(){} // RVA: 0xB5DBF0
        public void TrySetResult(){} // RVA: 0x4BB9360
    }

    public class TaskCompletionSource`1 : Object
    {
        public object _task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BB9F90
        public void get_Task(){} // RVA: 0xB5DBF0
        public void SpinUntilCompleted(){} // RVA: 0x4BBA060
        public void TrySetException(){} // RVA: 0x4BBA170
        public void SetException(){} // RVA: 0x4BBA1F0
        public void TrySetResult(){} // RVA: 0x4BBA240
        public void SetResult(){} // RVA: 0x4BBA350
        public void TrySetCanceled(){} // RVA: 0x4BBA460
        public void SetCanceled(){} // RVA: 0x4BBA510
    }

    public class TaskCompletionSource`1 : Object
    {
        public object _task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BB9B60
        public void get_Task(){} // RVA: 0xB5DBF0
        public void SpinUntilCompleted(){} // RVA: 0x4BB9C20
        public void TrySetException(){} // RVA: 0x4BB9D30
        public void SetException(){} // RVA: 0x4BB9D90
        public void TrySetResult(){} // RVA: 0x4BB9E00
        public void SetResult(){} // RVA: 0x4BB9E40
        public void TrySetCanceled(){} // RVA: 0x4BB9E90
        public void SetCanceled(){} // RVA: 0x4BB9F20
    }

    public class TaskCompletionSource`1 : Object
    {
        public object _task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BB8BC0
        public void get_Task(){} // RVA: 0xB5DBF0
        public void SpinUntilCompleted(){} // RVA: 0x4BB8C80
        public void TrySetException(){} // RVA: 0x4BB8D90
        public void SetException(){} // RVA: 0x4BB8DF0
        public void TrySetResult(){} // RVA: 0x4BB8E60
        public void SetResult(){} // RVA: 0x4BB8EA0
        public void TrySetCanceled(){} // RVA: 0x4BB8EF0
        public void SetCanceled(){} // RVA: 0x4BB8F80
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void StartNew(){} // RVA: 0x4BBBE50
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskSchedulerException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69B9650
    }

    public class TaskToApm : Object
    {
        // ── Methods ──
        public void Begin(){} // RVA: 0x69B96D0
        public void End(){} // RVA: 0x2A35200
        public void InvokeCallbackWhenTaskCompletes(){} // RVA: 0x69B9980
    }

    public class TaskToApm : Object
    {
        // ── Methods ──
        public void Begin(){} // RVA: 0x7248810
        public void End(){} // RVA: 0xA94080
        public void InvokeCallbackWhenTaskCompletes(){} // RVA: 0x7248AC0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void .ctor(){} // RVA: 0x4CBFFE0
        public void StartNew(){} // RVA: 0x4CC02C0
        public void TrySetResult(){} // RVA: 0x4CBD950
        public void DangerousSetResult(){} // RVA: 0x4CBDAA0
        public void get_Result(){} // RVA: 0x4CBDB30
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
        public void GetResultCore(){} // RVA: 0x4CBDC90
        public void InnerInvoke(){} // RVA: 0x4CBE000
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CD0AB0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4CD6C30
        public void TrySetResult(){} // RVA: 0x4CD7580
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E54BE0
        public void TrySetResult(){} // RVA: 0x4CBD950
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4CCD7C0
        public void TrySetResult(){} // RVA: 0x4CCE070
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4CCECB0
        public void TrySetResult(){} // RVA: 0x4CCF560
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4CCFF50
        public void TrySetResult(){} // RVA: 0x4CD0800
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4CD14D0
        public void TrySetResult(){} // RVA: 0x4CD0800
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4CD2570
        public void TrySetResult(){} // RVA: 0x4CCF560
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E3A820
        public void TrySetResult(){} // RVA: 0x4E3B0D0
        public void get_ResultOnSuccess(){} // RVA: 0x4CCE2D0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
        public void .ctor(){} // RVA: 0x4CBD020
        public void TrySetResult(){} // RVA: 0x4CBD950
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E587E0
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void get_Result(){} // RVA: 0x4E58E40
        public void StartNew(){} // RVA: 0x4E58AC0
        public void DangerousSetResult(){} // RVA: 0x4E58DA0
        public void GetResultCore(){} // RVA: 0x4CD4120
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4E58E80
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E587E0
        public void StartNew(){} // RVA: 0x4E58AC0
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void DangerousSetResult(){} // RVA: 0x4E58DA0
        public void get_Result(){} // RVA: 0x4E58E40
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void GetResultCore(){} // RVA: 0x4CD4120
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4E58E80
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
        public void .ctor(){} // RVA: 0x4E5D670
        public void TrySetResult(){} // RVA: 0x4CBD950
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E6BD90
        public void StartNew(){} // RVA: 0x4E6C0A0
        public void TrySetResult(){} // RVA: 0x4E6C270
        public void DangerousSetResult(){} // RVA: 0x4E6C3F0
        public void get_Result(){} // RVA: 0xAD0950
        public void get_ResultOnSuccess(){} // RVA: 0xAD0950
        public void GetResultCore(){} // RVA: 0xAD0950
        public void get_Factory(){} // RVA: 0x4E6C7E0
        public void InnerInvoke(){} // RVA: 0x4E6C9B0
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E6BD90
        public void StartNew(){} // RVA: 0x4E6C0A0
        public void TrySetResult(){} // RVA: 0x4E6C270
        public void DangerousSetResult(){} // RVA: 0x4E6C3F0
        public void get_Result(){} // RVA: 0xAD0950
        public void get_ResultOnSuccess(){} // RVA: 0xAD0950
        public void GetResultCore(){} // RVA: 0xAD0950
        public void get_Factory(){} // RVA: 0x4E6C7E0
        public void InnerInvoke(){} // RVA: 0x4E6C9B0
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CDD1E0
        public void .ctor(){} // RVA: 0x4E29030
        public void TrySetResult(){} // RVA: 0x4CDCE90
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_Result(){} // RVA: 0x4E58E40
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CD0AB0
        public void .ctor(){} // RVA: 0x4E22EA0
        public void TrySetResult(){} // RVA: 0x4E237F0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E5B490
        public void TrySetResult(){} // RVA: 0x4E237F0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E696F0
        public void TrySetResult(){} // RVA: 0x4E368F0
    }

}