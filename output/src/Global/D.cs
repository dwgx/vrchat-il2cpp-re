// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 428

public class DPIDMipmapper : Object
{
    public object _instance;
    public object computeShader;
    public object kernelDownsampling;
    public object kernelGuidance;
    public object THREADS;
    public object TmpGuidanceProperty;
    public object OutputProperty;

    // ── Methods ──
    public void get_Instance(){} // RVA: 0xA709720
    public void get_ComputeShaderReady(){} // RVA: 0xA709810
    public void .ctor(){} // RVA: 0xA709920
    public void GenerateDPIDMipmaps(){} // RVA: 0xA709B90
    public void GenerateDPIDMipmapsQuality(){} // RVA: 0xA709C80
    public void GenerateDPIDMipmapsFast(){} // RVA: 0xA709DF0
    public void ExecuteComputeShader(){} // RVA: 0xA709EC0
    public void .cctor(){} // RVA: 0xA70B9F0
}

public class DeactivateControllerLabelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x406F470
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0xA745690
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class DeactivateObjectLabelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class DebugHash[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Decoder : DecoderNLS
{
    public object bits;
    public object bitCount;
    public object firstByte;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x66C5480
    public void Reset(){} // RVA: 0x66C78F0
    public void get_HasState(){} // RVA: 0x66C7930
}

public class Decoder : DecoderNLS
{
    public object lastByte;
    public object lastChar;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x66D0100
    public void Reset(){} // RVA: 0x66D0110
    public void get_HasState(){} // RVA: 0x66D0140
}

public class DecoderUTF7Fallback : DecoderFallback
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateFallbackBuffer(){} // RVA: 0x66C79A0
    public void get_MaxCharCount(){} // RVA: 0xC3CCE0
    public void Equals(){} // RVA: 0x66C79E0
    public void GetHashCode(){} // RVA: 0x66C7A40
}

public class DecoderUTF7FallbackBuffer : DecoderFallbackBuffer
{
    public object cFallback;
    public object iCount;
    public object iSize;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x66C7A50
    public void Fallback(){} // RVA: 0x66C7A60
    public void GetNextChar(){} // RVA: 0x66C7AB0
    public void get_Remaining(){} // RVA: 0x66B1470
    public void Reset(){} // RVA: 0x66B1480
    public void InternalFallback(){} // RVA: 0x66C7AD0
}

public class DefaultComparer`1 : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0xA94080
    public void GetHashCode(){} // RVA: 0xA94080
    public void .ctor(){} // RVA: 0x894290
}

public class DefaultComparer`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void Equals(){} // RVA: 0x35AD9C0
    public void GetHashCode(){} // RVA: 0x35ADAA0
}

public class DefaultCursorIdProperty : Property`2
{
    public object _name;
    public object _isReadOnly;

    // ── Methods ──
    public void get_Name(){} // RVA: 0xB465B0
    public void get_IsReadOnly(){} // RVA: 0xC38360
    public void GetValue(){} // RVA: 0xD467F0
    public void SetValue(){} // RVA: 0x426C6F0
    public void .ctor(){} // RVA: 0x803E240
}

public class DefaultGroupInstanceSetting : Object
{
    public object GroupID;
    public object Roles;
    public object Region;
    public object InstanceType;
    public object QueueEnabled;
    public object AgeGated;
    public object AvatarPerformanceLimit;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x9D9F800
}

public class DeferBindingResolutionWrapper : Object
{
    // ── Methods ──
    public void Acquire(){} // RVA: 0x77FDF90
    public void Dispose(){} // RVA: 0x77FDFF0
    public void .ctor(){} // RVA: 0xB43310
}

public class DelayFramePromise : Object
{
    public object pool;
    public object nextNode;
    public object initialFrame;
    public object delayFrameCount;
    public object cancellationToken;
    public object cancellationTokenRegistration;
    public object cancelImmediately;
    public object currentFrameCount;
    public object core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x4865E00
    public void .cctor(){} // RVA: 0x7753B50
    public void .ctor(){} // RVA: 0xB43310
    public void Create(){} // RVA: 0x7753C90
    public void GetResult(){} // RVA: 0x77540B0
    public void GetStatus(){} // RVA: 0x7754250
    public void UnsafeGetStatus(){} // RVA: 0x77542A0
    public void OnCompleted(){} // RVA: 0x77542E0
    public void MoveNext(){} // RVA: 0x7754360
    public void TryReturn(){} // RVA: 0x7754480
}

public class DelayIgnoreTimeScalePromise : Object
{
    public object pool;
    public object nextNode;
    public object delayFrameTimeSpan;
    public object elapsed;
    public object initialFrame;
    public object cancellationToken;
    public object cancellationTokenRegistration;
    public object cancelImmediately;
    public object core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x4865E00
    public void .cctor(){} // RVA: 0x77552F0
    public void .ctor(){} // RVA: 0xB43310
    public void Create(){} // RVA: 0x7755430
    public void GetResult(){} // RVA: 0x77558A0
    public void GetStatus(){} // RVA: 0x7755A40
    public void UnsafeGetStatus(){} // RVA: 0x7755A90
    public void OnCompleted(){} // RVA: 0x7755AD0
    public void MoveNext(){} // RVA: 0x7755B50
    public void TryReturn(){} // RVA: 0x7755CE0
}

public class DelayPromise : Task`1
{
    public object Token;
    public object Registration;
    public object Timer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x69C6A70
    public void Complete(){} // RVA: 0x69C6B90
}

public class DelayPromise : Object
{
    public object pool;
    public object nextNode;
    public object initialFrame;
    public object delayTimeSpan;
    public object elapsed;
    public object cancellationToken;
    public object cancellationTokenRegistration;
    public object cancelImmediately;
    public object core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x4865E00
    public void .cctor(){} // RVA: 0x77546C0
    public void .ctor(){} // RVA: 0xB43310
    public void Create(){} // RVA: 0x7754800
    public void GetResult(){} // RVA: 0x7754C70
    public void GetStatus(){} // RVA: 0x7754E10
    public void UnsafeGetStatus(){} // RVA: 0x7754E60
    public void OnCompleted(){} // RVA: 0x7754EA0
    public void MoveNext(){} // RVA: 0x7754F20
    public void TryReturn(){} // RVA: 0x77550B0
}

public class DelayRealtimePromise : Object
{
    public object pool;
    public object nextNode;
    public object delayTimeSpanTicks;
    public object stopwatch;
    public object cancellationToken;
    public object cancellationTokenRegistration;
    public object cancelImmediately;
    public object core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x4865E00
    public void .cctor(){} // RVA: 0x7755F20
    public void .ctor(){} // RVA: 0xB43310
    public void Create(){} // RVA: 0x7756060
    public void GetResult(){} // RVA: 0x77564A0
    public void GetStatus(){} // RVA: 0x7756640
    public void UnsafeGetStatus(){} // RVA: 0x7756690
    public void OnCompleted(){} // RVA: 0x77566D0
    public void MoveNext(){} // RVA: 0x7756750
    public void TryReturn(){} // RVA: 0x7756890
}

public class DelegateEnumerator : FileSystemEnumerator`1
{
    public object _enumerable;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void TransformEntry(){} // RVA: 0xA94080
    public void ShouldRecurseIntoEntry(){} // RVA: 0x87D350
    public void ShouldIncludeEntry(){} // RVA: 0x87D350
}

public class DelegateEnumerator : FileSystemEnumerator`1
{
    public object _enumerable;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35B1B10
    public void TransformEntry(){} // RVA: 0x35B1BB0
    public void ShouldRecurseIntoEntry(){} // RVA: 0x35B1BE0
    public void ShouldIncludeEntry(){} // RVA: 0x35B1C20
}

public class DeserializationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3E3B830
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x8210800
    public void EndInvoke(){} // RVA: 0x6C4A640
}

public class DestroyPipelineDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB9DF20
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class DestroyRigDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB9DF20
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class DeviceArray : ValueType
{
    public object m_HaveValue;
    public object m_DeviceCount;
    public object m_DeviceArray;

    // ── Methods ──
    public void IndexOf(){} // RVA: 0x926060
    public void Remove(){} // RVA: 0x926070
    public void Get(){} // RVA: 0x926080
    public void Set(){} // RVA: 0x9260B0
}

public class DeviceConnectedChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x40E2370
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x6F4F010
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class DeviceJson : ValueType
{
    public object devicePath;
    public object isOptional;
    public object isOR;

    // ── Methods ──
    public void ToDeviceEntry(){} // RVA: 0x931860
    public void From(){} // RVA: 0x78404A0
}

public class DeviceJson[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class DeviceRequirement : ValueType
{
    public object m_ControlPath;
    public object m_Flags;

    // ── Methods ──
    public void get_controlPath(){} // RVA: 0x77900
    public void set_controlPath(){} // RVA: 0x47F10
    public void get_isOptional(){} // RVA: 0x930FF0
    public void set_isOptional(){} // RVA: 0x931000
    public void get_isAND(){} // RVA: 0x931020
    public void set_isAND(){} // RVA: 0x931030
    public void get_isOR(){} // RVA: 0x931050
    public void set_isOR(){} // RVA: 0x931060
    public void ToString(){} // RVA: 0x931080
    public void Equals(){} // RVA: 0x931180
    public void GetHashCode(){} // RVA: 0x931220
    public void op_Equality(){} // RVA: 0x783FA60
    public void op_Inequality(){} // RVA: 0x783FA80
}

public class DeviceRequirement[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EC0D10
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E77FA0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void get_Entry(){} // RVA: 0x87BEB0
    public void get_Key(){} // RVA: 0x87C0A0
    public void get_Value(){} // RVA: 0x87C0A0
    public void get_Current(){} // RVA: 0x87C0A0
    public void MoveNext(){} // RVA: 0x87D280
    public void Reset(){} // RVA: 0x894290
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BD800
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BD800
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35C16D0
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEF40
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BD800
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEF40
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BDD20
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BDD20
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEF40
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEF40
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BD800
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BD800
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEF40
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryPoolImpl`2 : Object
{
    public object Pool;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x35CF860
}

public class DictionaryPoolImpl`2 : Object
{
    public object Pool;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x35CF860
}

public class DictionaryWrapper`1 : ValueType
{
    public object Dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x22FFE0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x230090
    public void GetEnumerator(){} // RVA: 0x2300D0
}

public class DictionaryWrapper`1 : ValueType
{
    public object Dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    public void GetEnumerator(){} // RVA: 0x87C0A0
}

public class DictionaryWrapper`1 : ValueType
{
    public object Dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x22FFE0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x230090
    public void GetEnumerator(){} // RVA: 0x2300D0
}

public class DigestAlgorithm[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Discord_FreeFn : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB9DF20
    public void Invoke(){} // RVA: 0xB9E010
}

public class DisplayProperty : InlineStyleEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7E9F850
    public void get_ussName(){} // RVA: 0x7E9F890
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7E9F8D0
    public void SetValue(){} // RVA: 0x7E9F920
    public void .ctor(){} // RVA: 0x7E9F980
}

public class DisplayProperty : ResolvedEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECAA10
    public void get_ussName(){} // RVA: 0x7ECAA50
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECAA90
    public void SetValue(){} // RVA: 0x7ECAAE0
    public void .ctor(){} // RVA: 0x7ECAB20
}

public class DisposeJob : ValueType
{
    public object Container;

    // ── Methods ──
    public void Execute(){} // RVA: 0x924600
}

public class DisposingLoggerFactory : Object
{
    public object _loggerFactory;
    public object _serviceProvider;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x17C92C0
    public void Dispose(){} // RVA: 0x662B490
    public void CreateLogger(){} // RVA: 0x662B4D0
    public void AddProvider(){} // RVA: 0x662B530
}

public class DoubleBufferedAwaitableList : Object
{
    public object _awaitables;
    public object _scratch;

    // ── Methods ──
    public void SwapAndComplete(){} // RVA: 0x7BF8E90
    public void Add(){} // RVA: 0x7BF9230
    public void Remove(){} // RVA: 0x7BF9300
    public void Clear(){} // RVA: 0x7BF94E0
    public void .ctor(){} // RVA: 0x7BF9550
}

public class DoublePoint : ValueType
{
    public object X;
    public object Y;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x89C80
}

public class DpadAxisControl : AxisControl
{
    public object _component;

    // ── Methods ──
    public void get_component(){} // RVA: 0x114AC30
    public void set_component(){} // RVA: 0x1AE2D20
    public void FinishSetup(){} // RVA: 0x7822980
    public void ReadUnprocessedValueFromState(){} // RVA: 0x7822A40
    public void .ctor(){} // RVA: 0x7822B60
}

public class DroneSkinMap : DroneSkinMapCore
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43D60
}

public class DropdownEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7E3C130
}

public class DummyJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x3FC0
}

public class DynamicBone : MonoBehaviour
{
    public object _m_CancellationTokenSource;
    public object f_7CB;
    public object m_Root;
    public object m_UpdateRate;
    public object m_Damping;
    public object m_DampingDistrib;
    public object m_Elasticity;
    public object m_ElasticityDistrib;
    public object m_Stiffness;
    public object m_StiffnessDistrib;
    public object m_Inert;
    public object m_InertDistrib;
    public object m_Radius;
    public object m_RadiusDistrib;
    public object m_EndLength;
    public object m_EndOffset;
    public object m_Gravity;
    public object m_Force;
    public object m_Colliders;
    public object m_Exclusions;
    public object m_FreezeAxis;
    public object m_DistantDisable;
    public object m_ReferenceObject;
    public object m_DistanceToObject;
    public object f_1F5;
    public object f_257;
    public object f_367;
    public object f_61B;
    public object f_97F;
    public object f_3EF;
    public object f_1CC;
    public object f_79C;
    public object f_20A;
    public object f_478;
    public object f_766;

    // ── Methods ──
    public void get_destroyCancellationToken(){} // RVA: 0xCD6B80
    public void .ctor(){} // RVA: 0xCD7BD0
    public void Initialize(){} // RVA: 0xCD7E90
    public void CancelInvoke(){} // RVA: 0xCD7EC0
    public void Invoke(){} // RVA: 0xCD81C0
    public void InvokeRepeating(){} // RVA: 0xCD8240
    public void StartCoroutine(){} // RVA: 0xCD8290
    public void StartCoroutine_Auto(){} // RVA: 0xCD87B0
    public void StopCoroutine(){} // RVA: 0xCD8B70
    public void StopAllCoroutines(){} // RVA: 0xCD8FB0
    public void get_useGUILayout(){} // RVA: 0xCD9780
    public void set_useGUILayout(){} // RVA: 0xCD9F10
    public void OnDrawGizmosSelected(){} // RVA: 0xCDAF70
    public void get_didAwake(){} // RVA: 0xCDB3E0
    public void print(){} // RVA: 0xCDB480
    public void OnValidate(){} // RVA: 0xCDB810
    public void Internal_IsInvokingAll(){} // RVA: 0xCDB8F0
    public void InvokeDelayed(){} // RVA: 0xCDBD70
    public void IsObjectMonoBehaviour(){} // RVA: 0xCDCA70
    public void StartCoroutineManaged(){} // RVA: 0xCDCDE0
    public void StartCoroutineManaged2(){} // RVA: 0xCDD170
    public void OnDisable(){} // RVA: 0xCDDE70
    public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0xCDDEB0
    public void Start(){} // RVA: 0xCDE270
    public void OnEnable(){} // RVA: 0xCDEB40
    public void OnBecameVisible(){} // RVA: 0xCDEB80
}

public class DynamicBoneCollider : MonoBehaviour
{
    public object m_Center;
    public object m_Radius;
    public object m_Height;
    public object m_Direction;
    public object m_Bound;

    // ── Methods ──
    public void OnValidate(){} // RVA: 0xCDFA80
    public void RaiseCancellation(){} // RVA: 0xCDFAB0
    public void IsInvoking(){} // RVA: 0xCDFBC0
    public void CancelInvoke(){} // RVA: 0xCDFEE0
    public void Invoke(){} // RVA: 0xCE01F0
    public void InvokeRepeating(){} // RVA: 0xCE0510
    public void OnDrawGizmosSelected(){} // RVA: 0xCE0D20
    public void StartCoroutine_Auto(){} // RVA: 0xCE1340
    public void StopCoroutine(){} // RVA: 0xCE1450
    public void .ctor(){} // RVA: 0xCE1480
    public void Initialize(){} // RVA: 0xCE1340
    public void set_useGUILayout(){} // RVA: 0xCE1340
    public void get_didStart(){} // RVA: 0xCE1510
}

public class DynamicBoneColliderData[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7EC40
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7ABD0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4700
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34D20
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7ABD0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class DynamicBoneCollider[] : Array
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

public class DynamicBoneData[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E970
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7AB20
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4550
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34AC0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7AB20
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class DynamicBone[] : Array
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

public class DynamicPartitionEnumerator_Abstract`2 : Object
{
    public object _sharedReader;
    public object s_defaultMaxChunkSize;
    public object _currentChunkSize;
    public object _localOffset;
    public object _doublingCountdown;
    public object _maxChunkSize;
    public object _sharedIndex;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void GrabNextChunk(){} // RVA: 0x87DD20
    public void get_HasNoElementsLeft(){} // RVA: 0x87D280
    public void get_Current(){} // RVA: 0xA94080
    public void Dispose(){} // RVA: 0x894290
    public void Reset(){} // RVA: 0x894290
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
    public void MoveNext(){} // RVA: 0x87D280
    public void .cctor(){} // RVA: 0x8942F0
}

public class DynamicPartitionEnumerator_Abstract`2 : Object
{
    public object _sharedReader;
    public object s_defaultMaxChunkSize;
    public object _currentChunkSize;
    public object _localOffset;
    public object _doublingCountdown;
    public object _maxChunkSize;
    public object _sharedIndex;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x388D670
    public void GrabNextChunk(){} // RVA: 0x87DD20
    public void get_HasNoElementsLeft(){} // RVA: 0x87D280
    public void get_Current(){} // RVA: 0xA94080
    public void Dispose(){} // RVA: 0x894290
    public void Reset(){} // RVA: 0x31EA210
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x388D8C0
    public void MoveNext(){} // RVA: 0x388D960
    public void .cctor(){} // RVA: 0x388DE00
}

public class DynamicPartitionEnumerator_Abstract`2 : Object
{
    public object _sharedReader;
    public object s_defaultMaxChunkSize;
    public object _currentChunkSize;
    public object _localOffset;
    public object _doublingCountdown;
    public object _maxChunkSize;
    public object _sharedIndex;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x388D1F0
    public void GrabNextChunk(){} // RVA: 0x87DD20
    public void get_HasNoElementsLeft(){} // RVA: 0x87D280
    public void get_Current(){} // RVA: 0x87BEB0
    public void Dispose(){} // RVA: 0x894290
    public void Reset(){} // RVA: 0x31EA210
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x388D330
    public void MoveNext(){} // RVA: 0x388D380
    public void .cctor(){} // RVA: 0x388D5E0
}

public class DynamicPartitionEnumerator_Abstract`2 : Object
{
    public object _sharedReader;
    public object s_defaultMaxChunkSize;
    public object _currentChunkSize;
    public object _localOffset;
    public object _doublingCountdown;
    public object _maxChunkSize;
    public object _sharedIndex;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x388D1F0
    public void GrabNextChunk(){} // RVA: 0x87DD20
    public void get_HasNoElementsLeft(){} // RVA: 0x87D280
    public void get_Current(){} // RVA: 0x87BEB0
    public void Dispose(){} // RVA: 0x894290
    public void Reset(){} // RVA: 0x31EA210
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x388D330
    public void MoveNext(){} // RVA: 0x388D380
    public void .cctor(){} // RVA: 0x388D5E0
}

public class DynamicPartitionerForIEnumerable`1 : OrderablePartitioner`1
{
    public object _source;
    public object _useSingleChunking;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x899290
    public void GetOrderableDynamicPartitions(){} // RVA: 0x87C0A0
    public void get_SupportsDynamicPartitions(){} // RVA: 0x87D280
}

public class DynamicPartitionerForIEnumerable`1 : OrderablePartitioner`1
{
    public object _source;
    public object _useSingleChunking;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x388DEB0
    public void GetOrderableDynamicPartitions(){} // RVA: 0x388DF20
    public void get_SupportsDynamicPartitions(){} // RVA: 0xC2E4C0
}

public class DynamicPartitionerForIEnumerable`1 : OrderablePartitioner`1
{
    public object _source;
    public object _useSingleChunking;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x388DEB0
    public void GetOrderableDynamicPartitions(){} // RVA: 0x388DF20
    public void get_SupportsDynamicPartitions(){} // RVA: 0xC2E4C0
}
