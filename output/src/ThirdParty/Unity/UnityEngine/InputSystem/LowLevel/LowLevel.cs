// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
// Classes: 58
// Methods: 484

namespace ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
{
    public class ActionEvent : ValueType
    {
        public UnityEngine.InputSystem.LowLevel.InputEvent Type; // 0x10
        public ushort startTime; // 0x24
        public ushort phase; // 0x26
        public ushort valueData; // 0x28
        public byte valueSizeInBytes; // 0x2A
        public byte stateIndex; // 0x2B
        public double controlIndex; // 0x2C
        public 0x664ADE18 bindingIndex; // 0x34

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A944B0
        public void get_startTime(){} // RVA: 0x7FFD5499AF60
        public void set_startTime(){} // RVA: 0x7FFD54A944C0
        public void get_phase(){} // RVA: 0x7FFD4E648BF0
        public void set_phase(){} // RVA: 0x7FFD4FA1ACF0
        public void get_valueData(){} // RVA: 0x7FFD54A944D0
        public void get_valueSizeInBytes(){} // RVA: 0x7FFD54A944E0
        public void get_stateIndex(){} // RVA: 0x7FFD4FA1A190
        public void set_stateIndex(){} // RVA: 0x7FFD54A944F0
        public void get_controlIndex(){} // RVA: 0x7FFD50C950C0
        public void set_controlIndex(){} // RVA: 0x7FFD54A94560
        public void get_bindingIndex(){} // RVA: 0x7FFD54A945D0
        public void set_bindingIndex(){} // RVA: 0x7FFD54A945E0
        public void get_interactionIndex(){} // RVA: 0x7FFD54A94650
        public void set_interactionIndex(){} // RVA: 0x7FFD54A94670
        public void ToEventPtr(){} // RVA: 0x7FFD4F9181E0
        public void get_typeStatic(){} // RVA: 0x7FFD54A944B0
        public void GetEventSizeWithValueSize(){} // RVA: 0x7FFD54A946F0
        public void From(){} // RVA: 0x7FFD54A94700
    }

    public class DeltaStateEvent : ValueType
    {
        public int deltaStateSizeInBytes;
        public UnityEngine.InputSystem.LowLevel.InputEvent deltaState; // 0x10
        public UnityEngine.InputSystem.Utilities.FourCC typeStatic; // 0x24
        public uint stateOffset; // 0x28
        public 0x664ADEC8 stateData; // 0x2C

        // ── Methods ──
        public void get_deltaStateSizeInBytes(){} // RVA: 0x7FFD54A94830
        public void get_deltaState(){} // RVA: 0x7FFD54A94840
        public void get_typeStatic(){} // RVA: 0x7FFD54A94850
        public void ToEventPtr(){} // RVA: 0x7FFD4F9181E0
        public void From(){} // RVA: 0x7FFD54A94990 | overloaded x2
        public void FromUnchecked(){} // RVA: 0x7FFD4F9181E0
    }

    public class DeviceConfigurationEvent : ValueType
    {
        public int typeStatic;
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFD54A94D10
        public void ToEventPtr(){} // RVA: 0x7FFD4F9181E0
        public void Create(){} // RVA: 0x7FFD54A94D20
    }

    public class DeviceRemoveEvent : ValueType
    {
        public int typeStatic;
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFD54A94DF0
        public void ToEventPtr(){} // RVA: 0x7FFD4F9181E0
        public void Create(){} // RVA: 0x7FFD54A94E00
    }

    public class DeviceResetEvent : ValueType
    {
        public int typeStatic;
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10
        public bool hardReset; // 0x18

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFD54A94ED0
        public void Create(){} // RVA: 0x7FFD54A94EE0
    }

    public class DisableDeviceCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93140
        public void get_typeStatic(){} // RVA: 0x7FFD54A93140
        public void Create(){} // RVA: 0x7FFD54A93150
    }

    public class DualMotorRumbleCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public float lowFrequencyMotorSpeed; // 0x18
        public float highFrequencyMotorSpeed; // 0x1C

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93B70
        public void get_typeStatic(){} // RVA: 0x7FFD54A93B70
        public void Create(){} // RVA: 0x7FFD54A93B80
    }

    public class EnableDeviceCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93170
        public void get_typeStatic(){} // RVA: 0x7FFD54A93170
        public void Create(){} // RVA: 0x7FFD54A93180
    }

    public class EnableIMECompositionCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand imeEnabled; // 0x10
        public byte typeStatic; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A931A0
        public void get_imeEnabled(){} // RVA: 0x7FFD54A931B0
        public void get_typeStatic(){} // RVA: 0x7FFD54A931A0
        public void Create(){} // RVA: 0x7FFD54A931C0
    }

    public class ICustomDeviceReset
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4E090980
    }

    public class IEventMerger
    {
        // ── Methods ──
        public void MergeForward(){}
    }

    public class IEventPreProcessor
    {
        // ── Methods ──
        public void PreProcessEvent(){} // RVA: 0x7FFD4E07A7E0
    }

    public class IInputDeviceCommandInfo
    {
        public object typeStatic;

        // ── Methods ──
        public void get_typeStatic(){}
    }

    public class IInputEventTypeInfo
    {
        public object typeStatic;

        // ── Methods ──
        public void get_typeStatic(){}
    }

    public class IInputRuntime
    {
        public object onUpdate;
        public object onBeforeUpdate;
        public object onShouldRunUpdate;
        public object onDeviceDiscovered;
        public object onPlayerFocusChanged;
        public object isPlayerFocused;
        public object onShutdown;
        public object pollingFrequency;
        public object currentTime;
        public object currentTimeForFixedUpdate;
        public object unscaledGameTime;
        public object currentTimeOffsetToRealtimeSinceStartup;
        public object runInBackground;
        public object screenSize;
        public object screenOrientation;
        public object isInBatchMode;

        // ── Methods ──
        public void AllocateDeviceId(){} // RVA: 0x7FFD4E079960
        public void Update(){} // RVA: 0x7FFD4E090ED0
        public void QueueEvent(){} // RVA: 0x7FFD4E2ADC40
        public void DeviceCommand(){} // RVA: 0x7FFD4E2ADC40
        public void get_onUpdate(){} // RVA: 0x7FFD4E078E90
        public void set_onUpdate(){} // RVA: 0x7FFD4E090A40
        public void get_onBeforeUpdate(){} // RVA: 0x7FFD4E078E90
        public void set_onBeforeUpdate(){} // RVA: 0x7FFD4E090A40
        public void get_onShouldRunUpdate(){} // RVA: 0x7FFD4E078E90
        public void set_onShouldRunUpdate(){} // RVA: 0x7FFD4E090A40
        public void get_onDeviceDiscovered(){} // RVA: 0x7FFD4E078E90
        public void set_onDeviceDiscovered(){} // RVA: 0x7FFD4E090A40
        public void get_onPlayerFocusChanged(){} // RVA: 0x7FFD4E078E90
        public void set_onPlayerFocusChanged(){} // RVA: 0x7FFD4E090A40
        public void get_isPlayerFocused(){} // RVA: 0x7FFD4E079D00
        public void get_onShutdown(){} // RVA: 0x7FFD4E078E90
        public void set_onShutdown(){} // RVA: 0x7FFD4E090A40
        public void get_pollingFrequency(){} // RVA: 0x7FFD4E08D880
        public void set_pollingFrequency(){} // RVA: 0x7FFD4E09E480
        public void get_currentTime(){} // RVA: 0x7FFD4E07EB60
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x7FFD4E07EB60
        public void get_unscaledGameTime(){} // RVA: 0x7FFD4E08D880
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7FFD4E07EB60
        public void get_runInBackground(){} // RVA: 0x7FFD4E079D00
        public void set_runInBackground(){} // RVA: 0x7FFD4E091060
        public void get_screenSize(){} // RVA: 0x7FFD4E078E90
        public void get_screenOrientation(){} // RVA: 0x7FFD4E079960
        public void get_isInBatchMode(){} // RVA: 0x7FFD4E079D00
    }

    public class IInputStateCallbackReceiver
    {
        // ── Methods ──
        public void OnNextUpdate(){} // RVA: 0x7FFD4E090980
        public void OnStateEvent(){} // RVA: 0x7FFD4E090BF0
        public void GetStateOffsetForEvent(){}
    }

    public class IInputStateChangeMonitor
    {
        // ── Methods ──
        public void NotifyControlStateChanged(){}
        public void NotifyTimerExpired(){}
    }

    public class IInputStateTypeInfo
    {
        public object format;

        // ── Methods ──
        public void get_format(){}
    }

    public class IInputUpdateCallbackReceiver
    {
        // ── Methods ──
        public void OnUpdate(){} // RVA: 0x7FFD4E090980
    }

    public class IMECompositionEvent : ValueType
    {
        public int typeStatic;
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10
        public 0x664AE1E0 compositionString; // 0x24

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFD54A94FC0
        public void Create(){} // RVA: 0x7FFD54A94FD0
    }

    public class ITextInputReceiver
    {
        // ── Methods ──
        public void OnTextInput(){} // RVA: 0x7FFD4E090B70
        public void OnIMECompositionChanged(){}
    }

    public class InitiateUserAccountPairingCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A931F0
        public void get_typeStatic(){} // RVA: 0x7FFD54A931F0
        public void Create(){} // RVA: 0x7FFD54A93200
    }

    public class InputDeviceCommand : ValueType
    {
        public int payloadSizeInBytes;
        public int payloadPtr;
        public long typeStatic;
        public long GenericSuccess;
        public UnityEngine.InputSystem.Utilities.FourCC type; // 0x10
        public int sizeInBytes; // 0x14

        // ── Methods ──
        public void get_payloadSizeInBytes(){} // RVA: 0x7FFD54A932B0
        public void get_payloadPtr(){} // RVA: 0x7FFD54A932C0
        public void .ctor(){} // RVA: 0x7FFD4E7F6D50
        public void AllocateNative(){} // RVA: 0x7FFD54A932D0
        public void get_typeStatic(){} // RVA: 0x7FFD4E919180
    }

    public class InputDeviceCommandDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD510DD010
        public void Invoke(){} // RVA: 0x7FFD510DAF80
        public void BeginInvoke(){} // RVA: 0x7FFD4EEF0620
        public void EndInvoke(){} // RVA: 0x7FFD4FC63930
    }

    public class InputEvent : ValueType
    {
        public uint type;
        public uint sizeInBytes;
        public int eventId;
        public int deviceId;
        public int time;
        public ÎÌÍÌÎÍÏÍÍÎÌÍÍÏÏÎÌÌÍÏ internalTime; // 0x10

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFD4F840210
        public void set_type(){} // RVA: 0x7FFD4E78D8B0
        public void get_sizeInBytes(){} // RVA: 0x7FFD51511D10
        public void set_sizeInBytes(){} // RVA: 0x7FFD54A954A0
        public void get_eventId(){} // RVA: 0x7FFD54A95550
        public void set_eventId(){} // RVA: 0x7FFD54A95560
        public void get_deviceId(){} // RVA: 0x7FFD53E8C300
        public void set_deviceId(){} // RVA: 0x7FFD54A95570
        public void get_time(){} // RVA: 0x7FFD54A95580
        public void set_time(){} // RVA: 0x7FFD54A955D0
        public void get_internalTime(){} // RVA: 0x7FFD4FBF1AE0
        public void set_internalTime(){} // RVA: 0x7FFD4FED3ED0
        public void .ctor(){} // RVA: 0x7FFD54A95630
        public void get_handled(){} // RVA: 0x7FFD54A956F0
        public void set_handled(){} // RVA: 0x7FFD54A95700
        public void ToString(){} // RVA: 0x7FFD54A95720
        public void GetNextInMemory(){} // RVA: 0x7FFD54A95A20
        public void GetNextInMemoryChecked(){} // RVA: 0x7FFD54A95A40
        public void Equals(){} // RVA: 0x7FFD54A95B90
    }

    public class InputEventBuffer : ValueType
    {
        public long eventCount;
        public Unity.Collections.NativeArray`1<byte> sizeInBytes; // 0x10
        public long capacityInBytes; // 0x20
        public int data; // 0x28
        public bool bufferPtr; // 0x2C

        // ── Methods ──
        public void get_eventCount(){} // RVA: 0x7FFD4E577800
        public void get_sizeInBytes(){} // RVA: 0x7FFD4E35C380
        public void get_capacityInBytes(){} // RVA: 0x7FFD54A95BE0
        public void get_data(){} // RVA: 0x7FFD4E6E0590
        public void get_bufferPtr(){} // RVA: 0x7FFD54A95C30
        public void .ctor(){} // RVA: 0x7FFD54A95E40 | overloaded x2
        public void AppendEvent(){} // RVA: 0x7FFD54A95F70
        public void AllocateEvent(){} // RVA: 0x7FFD54A96000
        public void Contains(){} // RVA: 0x7FFD54A962E0
        public void Reset(){} // RVA: 0x7FFD54A96350
        public void AdvanceToNextEvent(){} // RVA: 0x7FFD54A96370
        public void GetEnumerator(){} // RVA: 0x7FFD54A96460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD54A96520
        public void Dispose(){} // RVA: 0x7FFD54A96530
        public void Clone(){} // RVA: 0x7FFD54A96590
        public void System.ICloneable.Clone(){} // RVA: 0x7FFD54A96720
    }

    public class InputEventListener : ValueType
    {
        public 0x664AE340 s_ObserverState;

        // ── Methods ──
        public void op_Addition(){} // RVA: 0x7FFD54A96890
        public void op_Subtraction(){} // RVA: 0x7FFD54A96AE0
        public void Subscribe(){} // RVA: 0x7FFD54A96D30
    }

    public class InputEventPtr : ValueType
    {
        public UnityEngine.InputSystem.LowLevel.InputEvent* valid; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F9DB120
        public void get_valid(){} // RVA: 0x7FFD511E6CA0
        public void get_handled(){} // RVA: 0x7FFD54A97430
        public void set_handled(){} // RVA: 0x7FFD54A97450
        public void get_id(){} // RVA: 0x7FFD54A974D0
        public void set_id(){} // RVA: 0x7FFD54A974F0
        public void get_type(){} // RVA: 0x7FFD54A97570
        public void get_sizeInBytes(){} // RVA: 0x7FFD54A97580
        public void get_deviceId(){} // RVA: 0x7FFD54A975A0
        public void set_deviceId(){} // RVA: 0x7FFD54A975C0
        public void get_time(){} // RVA: 0x7FFD54A97630
        public void set_time(){} // RVA: 0x7FFD54A97690
        public void get_internalTime(){} // RVA: 0x7FFD54A97740
        public void set_internalTime(){} // RVA: 0x7FFD54A97760
        public void get_data(){} // RVA: 0x7FFD4EEF9F60
        public void get_stateFormat(){} // RVA: 0x7FFD54A977D0
        public void get_stateSizeInBytes(){} // RVA: 0x7FFD54A97880
        public void get_stateOffset(){} // RVA: 0x7FFD54A979B0
        public void IsA(){} // RVA: 0x7FFD4E079D00
        public void Next(){} // RVA: 0x7FFD54A97AA0
        public void ToString(){} // RVA: 0x7FFD54A97AC0
        public void ToPointer(){} // RVA: 0x7FFD4EEF9F60
        public void Equals(){} // RVA: 0x7FFD54A97B80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
        public void op_Equality(){} // RVA: 0x7FFD5072B460
        public void op_Inequality(){} // RVA: 0x7FFD53A70B50
        public void op_Implicit(){} // RVA: 0x7FFD4F9181E0 | overloaded x2
        public void From(){} // RVA: 0x7FFD4F9181E0
        public void FromInputEventPtr(){} // RVA: 0x7FFD4F9181E0
    }

    public class InputEventStream : ValueType
    {
        public UnityEngine.InputSystem.LowLevel.InputEventBuffer isOpen; // 0x10
        public UnityEngine.InputSystem.LowLevel.InputEvent* remainingEventCount; // 0x30
        public UnityEngine.InputSystem.LowLevel.InputEvent* numEventsRetainedInBuffer; // 0x38
        public int currentEventPtr; // 0x40
        public int numBytesRetainedInBuffer; // 0x44
        public UnityEngine.InputSystem.LowLevel.InputEventBuffer m_AppendBuffer; // 0x48
        public UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentAppendEventReadPtr; // 0x68
        public UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentAppendEventWritePtr; // 0x70
        public int m_RemainingAppendEventCount; // 0x78
        public int m_NumEventsRetainedInBuffer; // 0x7C
        public bool m_IsOpen; // 0x80

        // ── Methods ──
        public void get_isOpen(){} // RVA: 0x7FFD4E3BD320
        public void get_remainingEventCount(){} // RVA: 0x7FFD54A97C40
        public void get_numEventsRetainedInBuffer(){} // RVA: 0x7FFD4FBDAB70
        public void get_currentEventPtr(){} // RVA: 0x7FFD54A97C50
        public void get_numBytesRetainedInBuffer(){} // RVA: 0x7FFD54A97C70
        public void .ctor(){} // RVA: 0x7FFD54A97CB0
        public void Close(){} // RVA: 0x7FFD54A97D40
        public void CleanUpAfterException(){} // RVA: 0x7FFD54A97EB0
        public void Write(){} // RVA: 0x7FFD54A97F60
        public void Advance(){} // RVA: 0x7FFD54A981E0
        public void Peek(){} // RVA: 0x7FFD54A98280
    }

    public class InputEventTrace : Object
    {
        public int FrameMarkerEvent;
        public Unity.Profiling.ProfilerMarker deviceId;
        public int enabled; // 0x10
        public bool recordFrameMarkers; // 0x14
        public System.Func`3<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,bool> eventCount; // 0x18
        public int totalEventSizeInBytes; // 0x20
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<UnityEngine.InputSystem.LowLevel.InputEventPtr>> allocatedSizeInBytes; // 0x28
        public long maxSizeInBytes; // 0x78
        public long deviceInfos; // 0x80
        public long onFilterEvent; // 0x88
        public long m_EventBuffer; // 0x90
        public long m_EventBufferHead; // 0x98
        public ulong m_EventBufferTail; // 0xA0
        public ulong kFileFormat; // 0xA8
        public ulong m_EventBufferTailStorage; // 0xB0
        public bool m_HasWrapped; // 0xB8
        public bool m_RecordFrameMarkers; // 0xB9
        public 0x664AE6B0[] m_DeviceInfos; // 0xC0
        public int kFileVersion; // 0x8

        // ── Methods ──
        public void get_FrameMarkerEvent(){} // RVA: 0x7FFD54A982C0
        public void get_deviceId(){} // RVA: 0x7FFD4E4FBBE0
        public void set_deviceId(){} // RVA: 0x7FFD4E9FB7A0
        public void get_enabled(){} // RVA: 0x7FFD4E490BD0
        public void get_recordFrameMarkers(){} // RVA: 0x7FFD5165E950
        public void set_recordFrameMarkers(){} // RVA: 0x7FFD54A982D0
        public void get_eventCount(){} // RVA: 0x7FFD4E70F640
        public void get_totalEventSizeInBytes(){} // RVA: 0x7FFD4E96DFB0
        public void get_allocatedSizeInBytes(){} // RVA: 0x7FFD54A983C0
        public void get_maxSizeInBytes(){} // RVA: 0x7FFD4E70F410
        public void get_deviceInfos(){} // RVA: 0x7FFD54A983E0
        public void get_onFilterEvent(){} // RVA: 0x7FFD4E3447C0
        public void set_onFilterEvent(){} // RVA: 0x7FFD4E3A7E80
        public void add_onEvent(){} // RVA: 0x7FFD54A984C0
        public void remove_onEvent(){} // RVA: 0x7FFD54A98510
        public void .ctor(){} // RVA: 0x7FFD54A98620 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFD54A98780 | overloaded x2
        public void ReadFrom(){} // RVA: 0x7FFD54A98F70 | overloaded x2
        public void LoadFrom(){} // RVA: 0x7FFD54A99A50 | overloaded x2
        public void Replay(){} // RVA: 0x7FFD54A99B90
        public void Resize(){} // RVA: 0x7FFD54A99C80
        public void Clear(){} // RVA: 0x7FFD54A99F40
        public void Enable(){} // RVA: 0x7FFD54A99FC0
        public void Disable(){} // RVA: 0x7FFD54A9A140
        public void GetNextEvent(){} // RVA: 0x7FFD54A9A240
        public void GetEnumerator(){} // RVA: 0x7FFD54A9A2C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD54A9A2C0
        public void Dispose(){} // RVA: 0x7FFD54A9A360
        public void get_m_EventBuffer(){} // RVA: 0x7FFD4E963900
        public void set_m_EventBuffer(){} // RVA: 0x7FFD53BAD950
        public void get_m_EventBufferHead(){} // RVA: 0x7FFD4E96B1A0
        public void set_m_EventBufferHead(){} // RVA: 0x7FFD4F9E9F60
        public void get_m_EventBufferTail(){} // RVA: 0x7FFD4E3AC040
        public void set_m_EventBufferTail(){} // RVA: 0x7FFD4F9EA6B0
        public void Allocate(){} // RVA: 0x7FFD54A9A460
        public void Release(){} // RVA: 0x7FFD54A9A4D0
        public void OnBeforeUpdate(){} // RVA: 0x7FFD54A9A5D0
        public void OnInputEvent(){} // RVA: 0x7FFD54A9A6D0
        public void get_kFileFormat(){} // RVA: 0x7FFD54A9ACE0
        public void .cctor(){} // RVA: 0x7FFD54A9ACF0
    }

    public class InputMetrics : ValueType
    {
        public int maxNumDevices; // 0x10
        public int currentNumDevices; // 0x14
        public int maxStateSizeInBytes; // 0x18
        public int currentStateSizeInBytes; // 0x1C
        public int currentControlCount; // 0x20
        public int currentLayoutCount; // 0x24
        public int totalEventBytes; // 0x28
        public int totalEventCount; // 0x2C
        public int totalUpdateCount; // 0x30
        public double totalEventProcessingTime; // 0x38
        public double totalEventLagTime; // 0x40

        // ── Methods ──
        public void get_maxNumDevices(){} // RVA: 0x7FFD4F840210
        public void set_maxNumDevices(){} // RVA: 0x7FFD4E78D8B0
        public void get_currentNumDevices(){} // RVA: 0x7FFD4F8402A0
        public void set_currentNumDevices(){} // RVA: 0x7FFD4F840230
        public void get_maxStateSizeInBytes(){} // RVA: 0x7FFD4FDE7500
        public void set_maxStateSizeInBytes(){} // RVA: 0x7FFD4FDE7510
        public void get_currentStateSizeInBytes(){} // RVA: 0x7FFD4FDE7520
        public void set_currentStateSizeInBytes(){} // RVA: 0x7FFD4FDE7530
        public void get_currentControlCount(){} // RVA: 0x7FFD4E38E5C0
        public void set_currentControlCount(){} // RVA: 0x7FFD4E3440C0
        public void get_currentLayoutCount(){} // RVA: 0x7FFD4E7F5A20
        public void set_currentLayoutCount(){} // RVA: 0x7FFD4E7F4990
        public void get_totalEventBytes(){} // RVA: 0x7FFD4E577800
        public void set_totalEventBytes(){} // RVA: 0x7FFD4ED4CD10
        public void get_totalEventCount(){} // RVA: 0x7FFD4F8557F0
        public void set_totalEventCount(){} // RVA: 0x7FFD4F8674D0
        public void get_totalUpdateCount(){} // RVA: 0x7FFD4E4FBBE0
        public void set_totalUpdateCount(){} // RVA: 0x7FFD4E9FB7A0
        public void get_totalEventProcessingTime(){} // RVA: 0x7FFD54A9D750
        public void set_totalEventProcessingTime(){} // RVA: 0x7FFD54A9D760
        public void get_totalEventLagTime(){} // RVA: 0x7FFD54A9D770
        public void set_totalEventLagTime(){} // RVA: 0x7FFD54A9D780
        public void get_averageEventBytesPerFrame(){} // RVA: 0x7FFD54A9D790
        public void get_averageProcessingTimePerEvent(){} // RVA: 0x7FFD54A9D7B0
        public void get_averageLagTimePerEvent(){} // RVA: 0x7FFD54A9D7D0
    }

    public class InputRuntime : Object
    {
        public UnityEngine.InputSystem.LowLevel.IInputRuntime s_Instance;
        public double s_CurrentTimeOffsetToRealtimeSinceStartup; // 0x8
    }

    public class InputRuntimeExtensions : Object
    {
        // ── Methods ──
        public void DeviceCommand(){}
    }

    public class InputState : Object
    {
        public object currentUpdateType;
        public object updateCount;
        public object currentTime;

        // ── Methods ──
        public void get_currentUpdateType(){} // RVA: 0x7FFD54A9F520
        public void get_updateCount(){} // RVA: 0x7FFD54A9F560
        public void get_currentTime(){} // RVA: 0x7FFD54A9F5A0
        public void add_onChange(){} // RVA: 0x7FFD54A9F620
        public void remove_onChange(){} // RVA: 0x7FFD54A9F6D0
        public void Change(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void IsIntegerFormat(){} // RVA: 0x7FFD54A9FA70
        public void AddChangeMonitor(){} // RVA: 0x7FFD54A9FDC0 | overloaded x2
        public void RemoveChangeMonitor(){} // RVA: 0x7FFD54A9FF50
        public void AddChangeMonitorTimeout(){} // RVA: 0x7FFD54AA0090
        public void RemoveChangeMonitorTimeout(){} // RVA: 0x7FFD54AA01A0
    }

    public class InputStateBlock : ValueType
    {
        public uint format;
        public uint byteOffset;
        public UnityEngine.InputSystem.Utilities.FourCC bitOffset;
        public int sizeInBits;
        public UnityEngine.InputSystem.Utilities.FourCC alignedSizeInBytes; // 0x4
        public int effectiveByteOffset;
        public UnityEngine.InputSystem.Utilities.FourCC effectiveBitOffset; // 0x8
        public int kFormatSBit;
        public UnityEngine.InputSystem.Utilities.FourCC FormatInt; // 0xC
        public int kFormatInt;
        public UnityEngine.InputSystem.Utilities.FourCC FormatUInt; // 0x10
        public int kFormatUInt;
        public UnityEngine.InputSystem.Utilities.FourCC FormatShort; // 0x14
        public int kFormatShort;
        public UnityEngine.InputSystem.Utilities.FourCC FormatUShort; // 0x18
        public int kFormatUShort;
        public UnityEngine.InputSystem.Utilities.FourCC FormatByte; // 0x1C
        public int kFormatByte;
        public UnityEngine.InputSystem.Utilities.FourCC FormatSByte; // 0x20
        public int kFormatSByte;
        public UnityEngine.InputSystem.Utilities.FourCC FormatLong; // 0x24
        public int kFormatLong;
        public UnityEngine.InputSystem.Utilities.FourCC FormatULong; // 0x28
        public int kFormatULong;
        public UnityEngine.InputSystem.Utilities.FourCC FormatFloat; // 0x2C
        public int kFormatFloat;
        public UnityEngine.InputSystem.Utilities.FourCC FormatDouble; // 0x30
        public int kFormatDouble;
        public UnityEngine.InputSystem.Utilities.FourCC FormatVector2; // 0x34
        public int kFormatVector2;
        public UnityEngine.InputSystem.Utilities.FourCC FormatVector3; // 0x38
        public int kFormatVector3;
        public UnityEngine.InputSystem.Utilities.FourCC FormatQuaternion; // 0x3C
        public int kFormatQuaternion;
        public UnityEngine.InputSystem.Utilities.FourCC FormatVector2Short; // 0x40
        public UnityEngine.InputSystem.Utilities.FourCC FormatVector3Short; // 0x44
        public UnityEngine.InputSystem.Utilities.FourCC FormatVector2Byte; // 0x48
        public UnityEngine.InputSystem.Utilities.FourCC FormatVector3Byte; // 0x4C
        public UnityEngine.InputSystem.Utilities.FourCC FormatPose; // 0x50
        public int kFormatPose;
        public UnityEngine.InputSystem.Utilities.FourCC <format>k__BackingField; // 0x10
        public uint m_ByteOffset; // 0x14
        public uint <bitOffset>k__BackingField; // 0x18
        public uint <sizeInBits>k__BackingField; // 0x1C

        // ── Methods ──
        public void GetSizeOfPrimitiveFormatInBits(){} // RVA: 0x7FFD54AA02E0
        public void GetPrimitiveFormatFromType(){} // RVA: 0x7FFD54AA0630
        public void get_format(){} // RVA: 0x7FFD4F840210
        public void set_format(){} // RVA: 0x7FFD4E78D8B0
        public void get_byteOffset(){} // RVA: 0x7FFD4F8402A0
        public void set_byteOffset(){} // RVA: 0x7FFD4F840230
        public void get_bitOffset(){} // RVA: 0x7FFD4FDE7500
        public void set_bitOffset(){} // RVA: 0x7FFD4FDE7510
        public void get_sizeInBits(){} // RVA: 0x7FFD4FDE7520
        public void set_sizeInBits(){} // RVA: 0x7FFD4FDE7530
        public void get_alignedSizeInBytes(){} // RVA: 0x7FFD54AA0CB0
        public void get_effectiveByteOffset(){} // RVA: 0x7FFD54AA0D00
        public void get_effectiveBitOffset(){} // RVA: 0x7FFD54AA0D50
        public void ReadInt(){} // RVA: 0x7FFD54AA0DA0
        public void WriteInt(){} // RVA: 0x7FFD54AA1090
        public void ReadFloat(){} // RVA: 0x7FFD54AA1310
        public void WriteFloat(){} // RVA: 0x7FFD54AA16F0
        public void FloatToPrimitiveValue(){} // RVA: 0x7FFD54AA1A70
        public void ReadDouble(){} // RVA: 0x7FFD54AA1E30
        public void WriteDouble(){} // RVA: 0x7FFD54AA2230
        public void Write(){} // RVA: 0x7FFD54AA25D0
        public void CopyToFrom(){} // RVA: 0x7FFD54AA28E0
        public void .cctor(){} // RVA: 0x7FFD54AA2A40
    }

    public class InputStateBuffers : ValueType
    {
        public uint sizePerBuffer; // 0x10
        public uint totalSize; // 0x14
        public void* defaultStateBuffer; // 0x18
        public void* noiseMaskBuffer; // 0x20
        public void* resetMaskBuffer; // 0x28
        public void* m_AllBuffers; // 0x30
        public DoubleBuffers m_PlayerStateBuffers; // 0x38
        public void* s_DefaultStateBuffer;
        public void* s_NoiseMaskBuffer; // 0x8
        public void* s_ResetMaskBuffer; // 0x10
        public DoubleBuffers s_CurrentBuffers; // 0x18

        // ── Methods ──
        public void GetDoubleBuffersFor(){} // RVA: 0x7FFD54AA2C30
        public void GetFrontBufferForDevice(){} // RVA: 0x7FFD54AA2D10
        public void GetBackBufferForDevice(){} // RVA: 0x7FFD54AA2D70
        public void SwitchTo(){} // RVA: 0x7FFD54AA2DD0
        public void AllocateAll(){} // RVA: 0x7FFD54AA2E40
        public void SetUpDeviceToBufferMappings(){} // RVA: 0x7FFD54AA2FC0
        public void FreeAll(){} // RVA: 0x7FFD54AA3050
        public void MigrateAll(){} // RVA: 0x7FFD54AA3170
        public void MigrateDoubleBuffer(){} // RVA: 0x7FFD54AA3330
        public void MigrateSingleBuffer(){} // RVA: 0x7FFD54AA3500
        public void ComputeSizeOfSingleStateBuffer(){} // RVA: 0x7FFD54AA3630
        public void NextDeviceOffset(){} // RVA: 0x7FFD54AA37B0
    }

    public class InputStateHistory : Object
    {
        public int Count;
        public System.Action`1<Record> version; // 0x10
        public System.Func`4<UnityEngine.InputSystem.InputControl,double,UnityEngine.InputSystem.LowLevel.InputEventPtr,bool> historyDepth; // 0x18
        public UnityEngine.InputSystem.InputControl[] extraMemoryPerRecord; // 0x20
        public int updateMask; // 0x28
        public Unity.Collections.NativeArray`1<byte> controls; // 0x30
        public int Item; // 0x40
        public int onRecordAdded; // 0x44
        public int onShouldRecordStateChange; // 0x48
        public int bytesPerRecord; // 0x4C
        public int m_HeadIndex; // 0x50
        public uint m_CurrentVersion; // 0x54
        public System.Nullable`1<0x664AEA20> m_UpdateMask; // 0x58
        public bool m_AddNewControls; // 0x60

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFD4E3E20A0
        public void get_version(){} // RVA: 0x7FFD4ECB13D0
        public void get_historyDepth(){} // RVA: 0x7FFD4E3E20C0
        public void set_historyDepth(){} // RVA: 0x7FFD54AA39B0
        public void get_extraMemoryPerRecord(){} // RVA: 0x7FFD4F34D3C0
        public void set_extraMemoryPerRecord(){} // RVA: 0x7FFD54AA3A90
        public void get_updateMask(){} // RVA: 0x7FFD54AA3B70
        public void set_updateMask(){} // RVA: 0x7FFD54AA3C20
        public void get_controls(){} // RVA: 0x7FFD54AA3CE0
        public void get_Item(){} // RVA: 0x7FFD54AA3D90
        public void set_Item(){} // RVA: 0x7FFD54AA3F10
        public void get_onRecordAdded(){} // RVA: 0x7FFD4E35C380
        public void set_onRecordAdded(){} // RVA: 0x7FFD4E342E30
        public void get_onShouldRecordStateChange(){} // RVA: 0x7FFD4E3447C0
        public void set_onShouldRecordStateChange(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD54AA4490 | overloaded x4
        public void Finalize(){} // RVA: 0x7FFD54AA45A0
        public void Clear(){} // RVA: 0x7FFD54AA45E0
        public void AddRecord(){} // RVA: 0x7FFD54AA45F0
        public void StartRecording(){} // RVA: 0x7FFD54AA46C0
        public void StopRecording(){} // RVA: 0x7FFD54AA4880
        public void RecordStateChange(){} // RVA: 0x7FFD54AA4DA0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFD54AA5220
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD54AA5220
        public void Dispose(){} // RVA: 0x7FFD54AA52D0
        public void Destroy(){} // RVA: 0x7FFD54AA5380
        public void Allocate(){} // RVA: 0x7FFD54AA53E0
        public void RecordIndexToUserIndex(){} // RVA: 0x7FFD54AA5770
        public void UserIndexToRecordIndex(){} // RVA: 0x7FFD54AA5790
        public void GetRecord(){} // RVA: 0x7FFD54AA57A0
        public void GetRecordUnchecked(){} // RVA: 0x7FFD54AA5890
        public void AllocateRecord(){} // RVA: 0x7FFD54AA5920
        public void ReadValue(){} // RVA: 0x7FFD4E2ADC40
        public void ReadValueAsObject(){} // RVA: 0x7FFD54AA59F0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7FFD54AA5BC0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7FFD4E341310
        public void get_bytesPerRecord(){} // RVA: 0x7FFD54AA5D30
    }

    public class InputStateHistory`1 : InputStateHistory
    {
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFD4E090980
        public void AddRecord(){} // RVA: 0x7FFD4E2ADC40
        public void RecordStateChange(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
    }

    public class InputUpdate : Object
    {
        public uint s_UpdateStepCount;
        public 0x664AEA20 s_LatestUpdateType; // 0x4
        public UpdateStepCount s_PlayerUpdateStepCount; // 0x8

        // ── Methods ──
        public void OnBeforeUpdate(){} // RVA: 0x7FFD54A9D7F0
        public void OnUpdate(){} // RVA: 0x7FFD54A9D870
        public void Save(){} // RVA: 0x7FFD54A9D8F0
        public void Restore(){} // RVA: 0x7FFD54A9D940
        public void GetUpdateTypeForPlayer(){} // RVA: 0x7FFD54A9D9E0
        public void IsPlayerUpdate(){} // RVA: 0x7FFD54A9DA00
    }

    public class InputUpdateDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E49D2A0
        public void Invoke(){} // RVA: 0x7FFD4E49D370
        public void BeginInvoke(){} // RVA: 0x7FFD54A9D6A0
        public void EndInvoke(){} // RVA: 0x7FFD4FE1C700
    }

    public class NativeInputRuntime : Object
    {
        public UnityEngine.InputSystem.LowLevel.NativeInputRuntime onUpdate;
        public bool onBeforeUpdate; // 0x10
        public System.Action onShouldRunUpdate; // 0x18
        public UnityEngine.InputSystem.LowLevel.InputUpdateDelegate onDeviceDiscovered; // 0x20
        public System.Action`1<0x664AEA20> onShutdown; // 0x28
        public System.Func`2<0x664AEA20,bool> onPlayerFocusChanged; // 0x30
        public float isPlayerFocused; // 0x38
        public bool pollingFrequency; // 0x3C
        public System.Action`1<bool> currentTime; // 0x40

        // ── Methods ──
        public void AllocateDeviceId(){} // RVA: 0x7FFD54A9DA30
        public void Update(){} // RVA: 0x7FFD54A9DAB0
        public void QueueEvent(){} // RVA: 0x7FFD54A9DB40
        public void DeviceCommand(){} // RVA: 0x7FFD54A9DBD0
        public void get_onUpdate(){} // RVA: 0x7FFD4E36F0C0
        public void set_onUpdate(){} // RVA: 0x7FFD54A9DCE0
        public void get_onBeforeUpdate(){} // RVA: 0x7FFD4E36F130
        public void set_onBeforeUpdate(){} // RVA: 0x7FFD54A9E040
        public void get_onShouldRunUpdate(){} // RVA: 0x7FFD4E5F95E0
        public void set_onShouldRunUpdate(){} // RVA: 0x7FFD54A9E300
        public void get_onDeviceDiscovered(){} // RVA: 0x7FFD54A9E5C0
        public void set_onDeviceDiscovered(){} // RVA: 0x7FFD54A9E660
        public void get_onShutdown(){} // RVA: 0x7FFD4E3447C0
        public void set_onShutdown(){} // RVA: 0x7FFD54A9E7A0
        public void get_onPlayerFocusChanged(){} // RVA: 0x7FFD4E3BE740
        public void set_onPlayerFocusChanged(){} // RVA: 0x7FFD54A9E8F0
        public void get_isPlayerFocused(){} // RVA: 0x7FFD54A9ECF0
        public void get_pollingFrequency(){} // RVA: 0x7FFD4EB36E90
        public void set_pollingFrequency(){} // RVA: 0x7FFD54A9ED70
        public void get_currentTime(){} // RVA: 0x7FFD54A9EE10
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x7FFD54A9EE90
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7FFD54A9EF70
        public void get_unscaledGameTime(){} // RVA: 0x7FFD54A9EFF0
        public void get_runInBackground(){} // RVA: 0x7FFD54A9F040
        public void set_runInBackground(){} // RVA: 0x7FFD4E40B5F0
        public void OnShutdown(){} // RVA: 0x7FFD51ABD470
        public void OnWantsToShutdown(){} // RVA: 0x7FFD54A9F0D0
        public void OnFocusChanged(){} // RVA: 0x7FFD53DA0DA0
        public void get_screenSize(){} // RVA: 0x7FFD54A9F110
        public void get_screenOrientation(){} // RVA: 0x7FFD54A9F1C0
        public void get_isInBatchMode(){} // RVA: 0x7FFD54A9F210
        public void .ctor(){} // RVA: 0x7FFD54A9F290
        public void .cctor(){} // RVA: 0x7FFD54A9F2A0
    }

    public class QueryCanRunInBackground : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public bool canRunInBackground; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93420
        public void get_typeStatic(){} // RVA: 0x7FFD54A93420
        public void Create(){} // RVA: 0x7FFD54A93430
    }

    public class QueryDimensionsCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public UnityEngine.Vector2 outDimensions; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93450
        public void get_typeStatic(){} // RVA: 0x7FFD54A93450
        public void Create(){} // RVA: 0x7FFD54A93460
    }

    public class QueryEnabledStateCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public bool isEnabled; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93490
        public void get_typeStatic(){} // RVA: 0x7FFD54A93490
        public void Create(){} // RVA: 0x7FFD54A934A0
    }

    public class QueryKeyNameCommand : ValueType
    {
        public int Type;
        public int typeStatic;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10
        public int scanOrKeyCode; // 0x18
        public 0x664AD058 nameBuffer; // 0x1C

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93570
        public void ReadKeyName(){} // RVA: 0x7FFD54A93580
        public void get_typeStatic(){} // RVA: 0x7FFD54A93570
        public void Create(){} // RVA: 0x7FFD54A935A0
    }

    public class QueryKeyboardLayoutCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public 0x664ACFA8 nameBuffer; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A934C0
        public void ReadLayoutName(){} // RVA: 0x7FFD54A934D0
        public void WriteLayoutName(){} // RVA: 0x7FFD54A934F0
        public void get_typeStatic(){} // RVA: 0x7FFD54A934C0
        public void Create(){} // RVA: 0x7FFD54A93530
    }

    public class QueryPairedUserAccountCommand : ValueType
    {
        public int Type;
        public int id;
        public int name;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public ulong handle; // 0x18
        public 0x664AD1B8 nameBuffer; // 0x20
        public 0x664AD160 idBuffer; // 0x220

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A935F0
        public void get_id(){} // RVA: 0x7FFD54A93600
        public void set_id(){} // RVA: 0x7FFD54A93620
        public void get_name(){} // RVA: 0x7FFD54A93750
        public void set_name(){} // RVA: 0x7FFD54A93770
        public void get_typeStatic(){} // RVA: 0x7FFD54A935F0
        public void Create(){} // RVA: 0x7FFD54A938A0
    }

    public class QuerySamplingFrequencyCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public float frequency; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A938E0
        public void get_typeStatic(){} // RVA: 0x7FFD54A938E0
        public void Create(){} // RVA: 0x7FFD54A938F0
    }

    public class QueryUserIdCommand : ValueType
    {
        public int Type;
        public int typeStatic;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10
        public 0x664AD2C0 idBuffer; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93920
        public void ReadId(){} // RVA: 0x7FFD54A934D0
        public void get_typeStatic(){} // RVA: 0x7FFD54A93920
        public void Create(){} // RVA: 0x7FFD54A93930
    }

    public class RequestResetCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93970
        public void get_typeStatic(){} // RVA: 0x7FFD54A93970
        public void Create(){} // RVA: 0x7FFD54A93980
    }

    public class RequestSyncCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A939A0
        public void get_typeStatic(){} // RVA: 0x7FFD54A939A0
        public void Create(){} // RVA: 0x7FFD54A939B0
    }

    public class SelectObservable`2 : Object
    {
        public System.IObservable`1<U> m_Source;
        public System.Func`2<U,T> m_Filter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void Subscribe(){} // RVA: 0x7FFD4E078F40
    }

    public class SetIMECursorPositionCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand position; // 0x10
        public UnityEngine.Vector2 typeStatic; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A939D0
        public void get_position(){} // RVA: 0x7FFD51515860
        public void get_typeStatic(){} // RVA: 0x7FFD54A939D0
        public void Create(){} // RVA: 0x7FFD54A939E0
    }

    public class SetSamplingFrequencyCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public float frequency; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93A00
        public void get_typeStatic(){} // RVA: 0x7FFD54A93A00
        public void Create(){} // RVA: 0x7FFD54A93A10
    }

    public class StateEvent : ValueType
    {
        public int stateSizeInBytes;
        public int state;
        public UnityEngine.InputSystem.LowLevel.InputEvent typeStatic; // 0x10
        public UnityEngine.InputSystem.Utilities.FourCC stateFormat; // 0x24
        public 0x664AE760 stateData; // 0x28

        // ── Methods ──
        public void get_stateSizeInBytes(){} // RVA: 0x7FFD54A9CEB0
        public void get_state(){} // RVA: 0x7FFD54A9CEC0
        public void ToEventPtr(){} // RVA: 0x7FFD4F9181E0
        public void get_typeStatic(){} // RVA: 0x7FFD54A9CED0
        public void GetState(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetEventSizeWithPayload(){} // RVA: 0x7FFD4E079990
        public void From(){} // RVA: 0x7FFD54A9D070 | overloaded x3
        public void FromUnchecked(){} // RVA: 0x7FFD4F9181E0
        public void FromDefaultStateFor(){} // RVA: 0x7FFD54A9D040
    }

    public class TextEvent : ValueType
    {
        public int typeStatic;
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10
        public int character; // 0x24

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFD54A9D3A0
        public void From(){} // RVA: 0x7FFD54A9D3B0
        public void Create(){} // RVA: 0x7FFD54A9D5C0 | overloaded x2
    }

    public class TouchState : ValueType
    {
        public int Format;
        public int phase; // 0x10
        public UnityEngine.Vector2 isNoneEndedOrCanceled; // 0x14
        public UnityEngine.Vector2 isInProgress; // 0x1C
        public float isPrimaryTouch; // 0x24
        public UnityEngine.Vector2 isOrphanedPrimaryTouch; // 0x28
        public byte isIndirectTouch; // 0x30
        public byte isTap; // 0x31
        public byte isTapPress; // 0x32
        public byte isTapRelease; // 0x33
        public uint beganInSameFrame; // 0x34
        public double format; // 0x38
        public UnityEngine.Vector2 startPosition; // 0x40

        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFD54A93F40
        public void get_phase(){} // RVA: 0x7FFD4E42F9D0
        public void set_phase(){} // RVA: 0x7FFD4E42F9E0
        public void get_isNoneEndedOrCanceled(){} // RVA: 0x7FFD54A93F50
        public void get_isInProgress(){} // RVA: 0x7FFD54A93F70
        public void get_isPrimaryTouch(){} // RVA: 0x7FFD54A93F90
        public void set_isPrimaryTouch(){} // RVA: 0x7FFD54A93FA0
        public void get_isOrphanedPrimaryTouch(){} // RVA: 0x7FFD54A93FD0
        public void set_isOrphanedPrimaryTouch(){} // RVA: 0x7FFD54A93FE0
        public void get_isIndirectTouch(){} // RVA: 0x7FFD54A94010
        public void set_isIndirectTouch(){} // RVA: 0x7FFD54A94020
        public void get_isTap(){} // RVA: 0x7FFD54A94050
        public void set_isTap(){} // RVA: 0x7FFD54A94060
        public void get_isTapPress(){} // RVA: 0x7FFD54A94050
        public void set_isTapPress(){} // RVA: 0x7FFD54A94060
        public void get_isTapRelease(){} // RVA: 0x7FFD54A94090
        public void set_isTapRelease(){} // RVA: 0x7FFD54A940A0
        public void get_beganInSameFrame(){} // RVA: 0x7FFD54A940D0
        public void set_beganInSameFrame(){} // RVA: 0x7FFD54A940E0
        public void get_format(){} // RVA: 0x7FFD54A93F40
        public void ToString(){} // RVA: 0x7FFD54A94110
    }

    public class WarpMousePositionCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public UnityEngine.Vector2 warpPositionInPlayerDisplaySpace; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93A40
        public void get_typeStatic(){} // RVA: 0x7FFD54A93A40
        public void Create(){} // RVA: 0x7FFD54A93A50
    }

}