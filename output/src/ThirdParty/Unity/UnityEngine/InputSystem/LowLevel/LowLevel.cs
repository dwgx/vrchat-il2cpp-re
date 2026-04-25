// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
// Classes: 72
// Methods: 530

namespace ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
{
    public class AccelerometerState : ValueType
    {
        public UnityEngine.Vector3 kFormat; // 0x10

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFAC9673EF0
        public void get_format(){} // RVA: 0x7FFAC9673EF0
    }

    public class ActionEvent : ValueType
    {
        public UnityEngine.InputSystem.LowLevel.InputEvent Type; // 0x10
        public ushort startTime; // 0x24
        public ushort phase; // 0x26
        public ushort valueData; // 0x28
        public byte valueSizeInBytes; // 0x2A
        public byte stateIndex; // 0x2B
        public double controlIndex; // 0x2C
        public <m_ValueData>e__FixedBuffer bindingIndex; // 0x34

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC96744B0
        public void get_startTime(){} // RVA: 0x7FFAC957AF60
        public void set_startTime(){} // RVA: 0x7FFAC96744C0
        public void get_phase(){} // RVA: 0x7FFAC3228BF0
        public void set_phase(){} // RVA: 0x7FFAC45FACF0
        public void get_valueData(){} // RVA: 0x7FFAC96744D0
        public void get_valueSizeInBytes(){} // RVA: 0x7FFAC96744E0
        public void get_stateIndex(){} // RVA: 0x7FFAC45FA190
        public void set_stateIndex(){} // RVA: 0x7FFAC96744F0
        public void get_controlIndex(){} // RVA: 0x7FFAC58750C0
        public void set_controlIndex(){} // RVA: 0x7FFAC9674560
        public void get_bindingIndex(){} // RVA: 0x7FFAC96745D0
        public void set_bindingIndex(){} // RVA: 0x7FFAC96745E0
        public void get_interactionIndex(){} // RVA: 0x7FFAC9674650
        public void set_interactionIndex(){} // RVA: 0x7FFAC9674670
        public void ToEventPtr(){} // RVA: 0x7FFAC44F81E0
        public void get_typeStatic(){} // RVA: 0x7FFAC96744B0
        public void GetEventSizeWithValueSize(){} // RVA: 0x7FFAC96746F0
        public void From(){} // RVA: 0x7FFAC9674700
    }

    public class AttitudeState : ValueType
    {
        public UnityEngine.Quaternion kFormat; // 0x10

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFAC9673F20
        public void get_format(){} // RVA: 0x7FFAC9673F20
    }

    public class DeltaStateEvent : ValueType
    {
        public int deltaStateSizeInBytes;
        public UnityEngine.InputSystem.LowLevel.InputEvent deltaState; // 0x10
        public UnityEngine.InputSystem.Utilities.FourCC typeStatic; // 0x24
        public uint stateOffset; // 0x28
        public <stateData>e__FixedBuffer stateData; // 0x2C

        // ── Methods ──
        public void get_deltaStateSizeInBytes(){} // RVA: 0x7FFAC9674830
        public void get_deltaState(){} // RVA: 0x7FFAC9674840
        public void get_typeStatic(){} // RVA: 0x7FFAC9674850
        public void ToEventPtr(){} // RVA: 0x7FFAC44F81E0
        public void From(){} // RVA: 0x7FFAC9674990 | overloaded x2
        public void FromUnchecked(){} // RVA: 0x7FFAC44F81E0
    }

    public class DeviceConfigurationEvent : ValueType
    {
        public int typeStatic;
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFAC9674D10
        public void ToEventPtr(){} // RVA: 0x7FFAC44F81E0
        public void Create(){} // RVA: 0x7FFAC9674D20
    }

    public class DeviceRemoveEvent : ValueType
    {
        public int typeStatic;
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFAC9674DF0
        public void ToEventPtr(){} // RVA: 0x7FFAC44F81E0
        public void Create(){} // RVA: 0x7FFAC9674E00
    }

    public class DeviceResetEvent : ValueType
    {
        public int typeStatic;
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10
        public bool hardReset; // 0x18

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFAC9674ED0
        public void Create(){} // RVA: 0x7FFAC9674EE0
    }

    public class DisableDeviceCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC9673140
        public void get_typeStatic(){} // RVA: 0x7FFAC9673140
        public void Create(){} // RVA: 0x7FFAC9673150
    }

    public class DualMotorRumbleCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public float lowFrequencyMotorSpeed; // 0x18
        public float highFrequencyMotorSpeed; // 0x1C

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC9673B70
        public void get_typeStatic(){} // RVA: 0x7FFAC9673B70
        public void Create(){} // RVA: 0x7FFAC9673B80
    }

    public class EnableDeviceCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC9673170
        public void get_typeStatic(){} // RVA: 0x7FFAC9673170
        public void Create(){} // RVA: 0x7FFAC9673180
    }

    public class EnableIMECompositionCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand imeEnabled; // 0x10
        public byte typeStatic; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC96731A0
        public void get_imeEnabled(){} // RVA: 0x7FFAC96731B0
        public void get_typeStatic(){} // RVA: 0x7FFAC96731A0
        public void Create(){} // RVA: 0x7FFAC96731C0
    }

    public class GamepadState : ValueType
    {
        public string Format;
        public string format;
        public string ButtonWestShortDisplayName;
        public string ButtonEastShortDisplayName;
        public uint buttons; // 0x10
        public UnityEngine.Vector2 leftStick; // 0x14
        public UnityEngine.Vector2 rightStick; // 0x1C
        public float leftTrigger; // 0x24
        public float rightTrigger; // 0x28

        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFAC9673A70
        public void get_format(){} // RVA: 0x7FFAC9673A70
        public void .ctor(){} // RVA: 0x7FFAC9673A80
        public void WithButton(){} // RVA: 0x7FFAC9673B20
    }

    public class GravityState : ValueType
    {
        public UnityEngine.Vector3 kFormat; // 0x10

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFAC9673F10
        public void get_format(){} // RVA: 0x7FFAC9673F10
    }

    public class GyroscopeState : ValueType
    {
        public UnityEngine.Vector3 kFormat; // 0x10

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFAC9673F00
        public void get_format(){} // RVA: 0x7FFAC9673F00
    }

    public class ICustomDeviceReset
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAC2C70980
    }

    public class IEventMerger
    {
        // ── Methods ──
        public void MergeForward(){}
    }

    public class IEventPreProcessor
    {
        // ── Methods ──
        public void PreProcessEvent(){} // RVA: 0x7FFAC2C5A7E0
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
        public void AllocateDeviceId(){} // RVA: 0x7FFAC2C59960
        public void Update(){} // RVA: 0x7FFAC2C70ED0
        public void QueueEvent(){} // RVA: 0x7FFAC2E8DC40
        public void DeviceCommand(){} // RVA: 0x7FFAC2E8DC40
        public void get_onUpdate(){} // RVA: 0x7FFAC2C58E90
        public void set_onUpdate(){} // RVA: 0x7FFAC2C70A40
        public void get_onBeforeUpdate(){} // RVA: 0x7FFAC2C58E90
        public void set_onBeforeUpdate(){} // RVA: 0x7FFAC2C70A40
        public void get_onShouldRunUpdate(){} // RVA: 0x7FFAC2C58E90
        public void set_onShouldRunUpdate(){} // RVA: 0x7FFAC2C70A40
        public void get_onDeviceDiscovered(){} // RVA: 0x7FFAC2C58E90
        public void set_onDeviceDiscovered(){} // RVA: 0x7FFAC2C70A40
        public void get_onPlayerFocusChanged(){} // RVA: 0x7FFAC2C58E90
        public void set_onPlayerFocusChanged(){} // RVA: 0x7FFAC2C70A40
        public void get_isPlayerFocused(){} // RVA: 0x7FFAC2C59D00
        public void get_onShutdown(){} // RVA: 0x7FFAC2C58E90
        public void set_onShutdown(){} // RVA: 0x7FFAC2C70A40
        public void get_pollingFrequency(){} // RVA: 0x7FFAC2C6D880
        public void set_pollingFrequency(){} // RVA: 0x7FFAC2C7E480
        public void get_currentTime(){} // RVA: 0x7FFAC2C5EB60
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x7FFAC2C5EB60
        public void get_unscaledGameTime(){} // RVA: 0x7FFAC2C6D880
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7FFAC2C5EB60
        public void get_runInBackground(){} // RVA: 0x7FFAC2C59D00
        public void set_runInBackground(){} // RVA: 0x7FFAC2C71060
        public void get_screenSize(){} // RVA: 0x7FFAC2C58E90
        public void get_screenOrientation(){} // RVA: 0x7FFAC2C59960
        public void get_isInBatchMode(){} // RVA: 0x7FFAC2C59D00
    }

    public class IInputStateCallbackReceiver
    {
        // ── Methods ──
        public void OnNextUpdate(){} // RVA: 0x7FFAC2C70980
        public void OnStateEvent(){} // RVA: 0x7FFAC2C70BF0
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
        public void OnUpdate(){} // RVA: 0x7FFAC2C70980
    }

    public class IMECompositionEvent : ValueType
    {
        public int typeStatic;
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10
        public UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString; // 0x24

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFAC9674FC0
        public void Create(){} // RVA: 0x7FFAC9674FD0
    }

    public class IMECompositionString : ValueType
    {
        public int Count; // 0x10
        public <buffer>e__FixedBuffer Item; // 0x14

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAC4420210
        public void get_Item(){} // RVA: 0x7FFAC96751D0
        public void .ctor(){} // RVA: 0x7FFAC9675240
        public void ToString(){} // RVA: 0x7FFAC96752B0
        public void GetEnumerator(){} // RVA: 0x7FFAC96752D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC96753A0
    }

    public class ITextInputReceiver
    {
        // ── Methods ──
        public void OnTextInput(){} // RVA: 0x7FFAC2C70B70
        public void OnIMECompositionChanged(){}
    }

    public class InitiateUserAccountPairingCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC96731F0
        public void get_typeStatic(){} // RVA: 0x7FFAC96731F0
        public void Create(){} // RVA: 0x7FFAC9673200
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
        public void get_payloadSizeInBytes(){} // RVA: 0x7FFAC96732B0
        public void get_payloadPtr(){} // RVA: 0x7FFAC96732C0
        public void .ctor(){} // RVA: 0x7FFAC33D6D50
        public void AllocateNative(){} // RVA: 0x7FFAC96732D0
        public void get_typeStatic(){} // RVA: 0x7FFAC34F9180
    }

    public class InputDeviceCommandDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5CBD010
        public void Invoke(){} // RVA: 0x7FFAC5CBAF80
        public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
        public void EndInvoke(){} // RVA: 0x7FFAC4843930
    }

    public class InputDeviceExecuteCommandDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5C826F0
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
        public void BeginInvoke(){} // RVA: 0x7FFAC9673220
        public void EndInvoke(){} // RVA: 0x7FFAC6EA1C40
    }

    public class InputEvent : ValueType
    {
        public uint type;
        public uint sizeInBytes;
        public int eventId;
        public int deviceId;
        public int time;
        public UnityEngineInternal.Input.NativeInputEvent internalTime; // 0x10

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFAC4420210
        public void set_type(){} // RVA: 0x7FFAC336D8B0
        public void get_sizeInBytes(){} // RVA: 0x7FFAC60F1D10
        public void set_sizeInBytes(){} // RVA: 0x7FFAC96754A0
        public void get_eventId(){} // RVA: 0x7FFAC9675550
        public void set_eventId(){} // RVA: 0x7FFAC9675560
        public void get_deviceId(){} // RVA: 0x7FFAC8A6C300
        public void set_deviceId(){} // RVA: 0x7FFAC9675570
        public void get_time(){} // RVA: 0x7FFAC9675580
        public void set_time(){} // RVA: 0x7FFAC96755D0
        public void get_internalTime(){} // RVA: 0x7FFAC47D1AE0
        public void set_internalTime(){} // RVA: 0x7FFAC4AB3ED0
        public void .ctor(){} // RVA: 0x7FFAC9675630
        public void get_handled(){} // RVA: 0x7FFAC96756F0
        public void set_handled(){} // RVA: 0x7FFAC9675700
        public void ToString(){} // RVA: 0x7FFAC9675720
        public void GetNextInMemory(){} // RVA: 0x7FFAC9675A20
        public void GetNextInMemoryChecked(){} // RVA: 0x7FFAC9675A40
        public void Equals(){} // RVA: 0x7FFAC9675B90
    }

    public class InputEventBuffer : ValueType
    {
        public long eventCount;
        public Unity.Collections.NativeArray`1<byte> sizeInBytes; // 0x10
        public long capacityInBytes; // 0x20
        public int data; // 0x28
        public bool bufferPtr; // 0x2C

        // ── Methods ──
        public void get_eventCount(){} // RVA: 0x7FFAC3157800
        public void get_sizeInBytes(){} // RVA: 0x7FFAC2F3C380
        public void get_capacityInBytes(){} // RVA: 0x7FFAC9675BE0
        public void get_data(){} // RVA: 0x7FFAC32C0590
        public void get_bufferPtr(){} // RVA: 0x7FFAC9675C30
        public void .ctor(){} // RVA: 0x7FFAC9675E40 | overloaded x2
        public void AppendEvent(){} // RVA: 0x7FFAC9675F70
        public void AllocateEvent(){} // RVA: 0x7FFAC9676000
        public void Contains(){} // RVA: 0x7FFAC96762E0
        public void Reset(){} // RVA: 0x7FFAC9676350
        public void AdvanceToNextEvent(){} // RVA: 0x7FFAC9676370
        public void GetEnumerator(){} // RVA: 0x7FFAC9676460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9676520
        public void Dispose(){} // RVA: 0x7FFAC9676530
        public void Clone(){} // RVA: 0x7FFAC9676590
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC9676720
    }

    public class InputEventListener : ValueType
    {
        public ObserverState s_ObserverState;

        // ── Methods ──
        public void op_Addition(){} // RVA: 0x7FFAC9676890
        public void op_Subtraction(){} // RVA: 0x7FFAC9676AE0
        public void Subscribe(){} // RVA: 0x7FFAC9676D30
    }

    public class InputEventPtr : ValueType
    {
        public UnityEngine.InputSystem.LowLevel.InputEvent* valid; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45BB120
        public void get_valid(){} // RVA: 0x7FFAC5DC6CA0
        public void get_handled(){} // RVA: 0x7FFAC9677430
        public void set_handled(){} // RVA: 0x7FFAC9677450
        public void get_id(){} // RVA: 0x7FFAC96774D0
        public void set_id(){} // RVA: 0x7FFAC96774F0
        public void get_type(){} // RVA: 0x7FFAC9677570
        public void get_sizeInBytes(){} // RVA: 0x7FFAC9677580
        public void get_deviceId(){} // RVA: 0x7FFAC96775A0
        public void set_deviceId(){} // RVA: 0x7FFAC96775C0
        public void get_time(){} // RVA: 0x7FFAC9677630
        public void set_time(){} // RVA: 0x7FFAC9677690
        public void get_internalTime(){} // RVA: 0x7FFAC9677740
        public void set_internalTime(){} // RVA: 0x7FFAC9677760
        public void get_data(){} // RVA: 0x7FFAC3AD9F60
        public void get_stateFormat(){} // RVA: 0x7FFAC96777D0
        public void get_stateSizeInBytes(){} // RVA: 0x7FFAC9677880
        public void get_stateOffset(){} // RVA: 0x7FFAC96779B0
        public void IsA(){} // RVA: 0x7FFAC2C59D00
        public void Next(){} // RVA: 0x7FFAC9677AA0
        public void ToString(){} // RVA: 0x7FFAC9677AC0
        public void ToPointer(){} // RVA: 0x7FFAC3AD9F60
        public void Equals(){} // RVA: 0x7FFAC9677B80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void op_Equality(){} // RVA: 0x7FFAC530B460
        public void op_Inequality(){} // RVA: 0x7FFAC8650B50
        public void op_Implicit(){} // RVA: 0x7FFAC44F81E0 | overloaded x2
        public void From(){} // RVA: 0x7FFAC44F81E0
        public void FromInputEventPtr(){} // RVA: 0x7FFAC44F81E0
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
        public void get_isOpen(){} // RVA: 0x7FFAC2F9D320
        public void get_remainingEventCount(){} // RVA: 0x7FFAC9677C40
        public void get_numEventsRetainedInBuffer(){} // RVA: 0x7FFAC47BAB70
        public void get_currentEventPtr(){} // RVA: 0x7FFAC9677C50
        public void get_numBytesRetainedInBuffer(){} // RVA: 0x7FFAC9677C70
        public void .ctor(){} // RVA: 0x7FFAC9677CB0
        public void Close(){} // RVA: 0x7FFAC9677D40
        public void CleanUpAfterException(){} // RVA: 0x7FFAC9677EB0
        public void Write(){} // RVA: 0x7FFAC9677F60
        public void Advance(){} // RVA: 0x7FFAC96781E0
        public void Peek(){} // RVA: 0x7FFAC9678280
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
        public DeviceInfo[] m_DeviceInfos; // 0xC0
        public int kFileVersion; // 0x8

        // ── Methods ──
        public void get_FrameMarkerEvent(){} // RVA: 0x7FFAC96782C0
        public void get_deviceId(){} // RVA: 0x7FFAC30DBBE0
        public void set_deviceId(){} // RVA: 0x7FFAC35DB7A0
        public void get_enabled(){} // RVA: 0x7FFAC3070BD0
        public void get_recordFrameMarkers(){} // RVA: 0x7FFAC623E950
        public void set_recordFrameMarkers(){} // RVA: 0x7FFAC96782D0
        public void get_eventCount(){} // RVA: 0x7FFAC32EF640
        public void get_totalEventSizeInBytes(){} // RVA: 0x7FFAC354DFB0
        public void get_allocatedSizeInBytes(){} // RVA: 0x7FFAC96783C0
        public void get_maxSizeInBytes(){} // RVA: 0x7FFAC32EF410
        public void get_deviceInfos(){} // RVA: 0x7FFAC96783E0
        public void get_onFilterEvent(){} // RVA: 0x7FFAC2F247C0
        public void set_onFilterEvent(){} // RVA: 0x7FFAC2F87E80
        public void add_onEvent(){} // RVA: 0x7FFAC96784C0
        public void remove_onEvent(){} // RVA: 0x7FFAC9678510
        public void .ctor(){} // RVA: 0x7FFAC9678620 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFAC9678780 | overloaded x2
        public void ReadFrom(){} // RVA: 0x7FFAC9678F70 | overloaded x2
        public void LoadFrom(){} // RVA: 0x7FFAC9679A50 | overloaded x2
        public void Replay(){} // RVA: 0x7FFAC9679B90
        public void Resize(){} // RVA: 0x7FFAC9679C80
        public void Clear(){} // RVA: 0x7FFAC9679F40
        public void Enable(){} // RVA: 0x7FFAC9679FC0
        public void Disable(){} // RVA: 0x7FFAC967A140
        public void GetNextEvent(){} // RVA: 0x7FFAC967A240
        public void GetEnumerator(){} // RVA: 0x7FFAC967A2C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC967A2C0
        public void Dispose(){} // RVA: 0x7FFAC967A360
        public void get_m_EventBuffer(){} // RVA: 0x7FFAC3543900
        public void set_m_EventBuffer(){} // RVA: 0x7FFAC878D950
        public void get_m_EventBufferHead(){} // RVA: 0x7FFAC354B1A0
        public void set_m_EventBufferHead(){} // RVA: 0x7FFAC45C9F60
        public void get_m_EventBufferTail(){} // RVA: 0x7FFAC2F8C040
        public void set_m_EventBufferTail(){} // RVA: 0x7FFAC45CA6B0
        public void Allocate(){} // RVA: 0x7FFAC967A460
        public void Release(){} // RVA: 0x7FFAC967A4D0
        public void OnBeforeUpdate(){} // RVA: 0x7FFAC967A5D0
        public void OnInputEvent(){} // RVA: 0x7FFAC967A6D0
        public void get_kFileFormat(){} // RVA: 0x7FFAC967ACE0
        public void .cctor(){} // RVA: 0x7FFAC967ACF0
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
        public void get_maxNumDevices(){} // RVA: 0x7FFAC4420210
        public void set_maxNumDevices(){} // RVA: 0x7FFAC336D8B0
        public void get_currentNumDevices(){} // RVA: 0x7FFAC44202A0
        public void set_currentNumDevices(){} // RVA: 0x7FFAC4420230
        public void get_maxStateSizeInBytes(){} // RVA: 0x7FFAC49C7500
        public void set_maxStateSizeInBytes(){} // RVA: 0x7FFAC49C7510
        public void get_currentStateSizeInBytes(){} // RVA: 0x7FFAC49C7520
        public void set_currentStateSizeInBytes(){} // RVA: 0x7FFAC49C7530
        public void get_currentControlCount(){} // RVA: 0x7FFAC2F6E5C0
        public void set_currentControlCount(){} // RVA: 0x7FFAC2F240C0
        public void get_currentLayoutCount(){} // RVA: 0x7FFAC33D5A20
        public void set_currentLayoutCount(){} // RVA: 0x7FFAC33D4990
        public void get_totalEventBytes(){} // RVA: 0x7FFAC3157800
        public void set_totalEventBytes(){} // RVA: 0x7FFAC392CD10
        public void get_totalEventCount(){} // RVA: 0x7FFAC44357F0
        public void set_totalEventCount(){} // RVA: 0x7FFAC44474D0
        public void get_totalUpdateCount(){} // RVA: 0x7FFAC30DBBE0
        public void set_totalUpdateCount(){} // RVA: 0x7FFAC35DB7A0
        public void get_totalEventProcessingTime(){} // RVA: 0x7FFAC967D750
        public void set_totalEventProcessingTime(){} // RVA: 0x7FFAC967D760
        public void get_totalEventLagTime(){} // RVA: 0x7FFAC967D770
        public void set_totalEventLagTime(){} // RVA: 0x7FFAC967D780
        public void get_averageEventBytesPerFrame(){} // RVA: 0x7FFAC967D790
        public void get_averageProcessingTimePerEvent(){} // RVA: 0x7FFAC967D7B0
        public void get_averageLagTimePerEvent(){} // RVA: 0x7FFAC967D7D0
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
        public void get_currentUpdateType(){} // RVA: 0x7FFAC967F520
        public void get_updateCount(){} // RVA: 0x7FFAC967F560
        public void get_currentTime(){} // RVA: 0x7FFAC967F5A0
        public void add_onChange(){} // RVA: 0x7FFAC967F620
        public void remove_onChange(){} // RVA: 0x7FFAC967F6D0
        public void Change(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void IsIntegerFormat(){} // RVA: 0x7FFAC967FA70
        public void AddChangeMonitor(){} // RVA: 0x7FFAC967FDC0 | overloaded x2
        public void RemoveChangeMonitor(){} // RVA: 0x7FFAC967FF50
        public void AddChangeMonitorTimeout(){} // RVA: 0x7FFAC9680090
        public void RemoveChangeMonitorTimeout(){} // RVA: 0x7FFAC96801A0
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
        public void GetSizeOfPrimitiveFormatInBits(){} // RVA: 0x7FFAC96802E0
        public void GetPrimitiveFormatFromType(){} // RVA: 0x7FFAC9680630
        public void get_format(){} // RVA: 0x7FFAC4420210
        public void set_format(){} // RVA: 0x7FFAC336D8B0
        public void get_byteOffset(){} // RVA: 0x7FFAC44202A0
        public void set_byteOffset(){} // RVA: 0x7FFAC4420230
        public void get_bitOffset(){} // RVA: 0x7FFAC49C7500
        public void set_bitOffset(){} // RVA: 0x7FFAC49C7510
        public void get_sizeInBits(){} // RVA: 0x7FFAC49C7520
        public void set_sizeInBits(){} // RVA: 0x7FFAC49C7530
        public void get_alignedSizeInBytes(){} // RVA: 0x7FFAC9680CB0
        public void get_effectiveByteOffset(){} // RVA: 0x7FFAC9680D00
        public void get_effectiveBitOffset(){} // RVA: 0x7FFAC9680D50
        public void ReadInt(){} // RVA: 0x7FFAC9680DA0
        public void WriteInt(){} // RVA: 0x7FFAC9681090
        public void ReadFloat(){} // RVA: 0x7FFAC9681310
        public void WriteFloat(){} // RVA: 0x7FFAC96816F0
        public void FloatToPrimitiveValue(){} // RVA: 0x7FFAC9681A70
        public void ReadDouble(){} // RVA: 0x7FFAC9681E30
        public void WriteDouble(){} // RVA: 0x7FFAC9682230
        public void Write(){} // RVA: 0x7FFAC96825D0
        public void CopyToFrom(){} // RVA: 0x7FFAC96828E0
        public void .cctor(){} // RVA: 0x7FFAC9682A40
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
        public void GetDoubleBuffersFor(){} // RVA: 0x7FFAC9682C30
        public void GetFrontBufferForDevice(){} // RVA: 0x7FFAC9682D10
        public void GetBackBufferForDevice(){} // RVA: 0x7FFAC9682D70
        public void SwitchTo(){} // RVA: 0x7FFAC9682DD0
        public void AllocateAll(){} // RVA: 0x7FFAC9682E40
        public void SetUpDeviceToBufferMappings(){} // RVA: 0x7FFAC9682FC0
        public void FreeAll(){} // RVA: 0x7FFAC9683050
        public void MigrateAll(){} // RVA: 0x7FFAC9683170
        public void MigrateDoubleBuffer(){} // RVA: 0x7FFAC9683330
        public void MigrateSingleBuffer(){} // RVA: 0x7FFAC9683500
        public void ComputeSizeOfSingleStateBuffer(){} // RVA: 0x7FFAC9683630
        public void NextDeviceOffset(){} // RVA: 0x7FFAC96837B0
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
        public System.Nullable`1<0x6B14EA20> m_UpdateMask; // 0x58
        public bool m_AddNewControls; // 0x60

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAC2FC20A0
        public void get_version(){} // RVA: 0x7FFAC38913D0
        public void get_historyDepth(){} // RVA: 0x7FFAC2FC20C0
        public void set_historyDepth(){} // RVA: 0x7FFAC96839B0
        public void get_extraMemoryPerRecord(){} // RVA: 0x7FFAC3F2D3C0
        public void set_extraMemoryPerRecord(){} // RVA: 0x7FFAC9683A90
        public void get_updateMask(){} // RVA: 0x7FFAC9683B70
        public void set_updateMask(){} // RVA: 0x7FFAC9683C20
        public void get_controls(){} // RVA: 0x7FFAC9683CE0
        public void get_Item(){} // RVA: 0x7FFAC9683D90
        public void set_Item(){} // RVA: 0x7FFAC9683F10
        public void get_onRecordAdded(){} // RVA: 0x7FFAC2F3C380
        public void set_onRecordAdded(){} // RVA: 0x7FFAC2F22E30
        public void get_onShouldRecordStateChange(){} // RVA: 0x7FFAC2F247C0
        public void set_onShouldRecordStateChange(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9684490 | overloaded x4
        public void Finalize(){} // RVA: 0x7FFAC96845A0
        public void Clear(){} // RVA: 0x7FFAC96845E0
        public void AddRecord(){} // RVA: 0x7FFAC96845F0
        public void StartRecording(){} // RVA: 0x7FFAC96846C0
        public void StopRecording(){} // RVA: 0x7FFAC9684880
        public void RecordStateChange(){} // RVA: 0x7FFAC9684DA0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAC9685220
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9685220
        public void Dispose(){} // RVA: 0x7FFAC96852D0
        public void Destroy(){} // RVA: 0x7FFAC9685380
        public void Allocate(){} // RVA: 0x7FFAC96853E0
        public void RecordIndexToUserIndex(){} // RVA: 0x7FFAC9685770
        public void UserIndexToRecordIndex(){} // RVA: 0x7FFAC9685790
        public void GetRecord(){} // RVA: 0x7FFAC96857A0
        public void GetRecordUnchecked(){} // RVA: 0x7FFAC9685890
        public void AllocateRecord(){} // RVA: 0x7FFAC9685920
        public void ReadValue(){} // RVA: 0x7FFAC2E8DC40
        public void ReadValueAsObject(){} // RVA: 0x7FFAC96859F0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7FFAC9685BC0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7FFAC2F21310
        public void get_bytesPerRecord(){} // RVA: 0x7FFAC9685D30
    }

    public class InputStateHistory`1 : InputStateHistory
    {
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFAC2C70980
        public void AddRecord(){} // RVA: 0x7FFAC2E8DC40
        public void RecordStateChange(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
    }

    public class InputUpdate : Object
    {
        public uint s_UpdateStepCount;
        public 0x6B14EA20 s_LatestUpdateType; // 0x4
        public UpdateStepCount s_PlayerUpdateStepCount; // 0x8

        // ── Methods ──
        public void OnBeforeUpdate(){} // RVA: 0x7FFAC967D7F0
        public void OnUpdate(){} // RVA: 0x7FFAC967D870
        public void Save(){} // RVA: 0x7FFAC967D8F0
        public void Restore(){} // RVA: 0x7FFAC967D940
        public void GetUpdateTypeForPlayer(){} // RVA: 0x7FFAC967D9E0
        public void IsPlayerUpdate(){} // RVA: 0x7FFAC967DA00
    }

    public class InputUpdateDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC307D2A0
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC967D6A0
        public void EndInvoke(){} // RVA: 0x7FFAC49FC700
    }

    public class JoystickState : ValueType
    {
        public int kFormat; // 0x10
        public UnityEngine.Vector2 format; // 0x14

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFAC9673BB0
        public void get_format(){} // RVA: 0x7FFAC9673BB0
    }

    public class KeyboardState : ValueType
    {
        public int Format;
        public int format;
        public <keys>e__FixedBuffer keys; // 0x10

        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFAC9673BC0
        public void .ctor(){} // RVA: 0x7FFAC9673CC0 | overloaded x2
        public void Set(){} // RVA: 0x7FFAC9569770
        public void Get(){} // RVA: 0x7FFAC95697A0
        public void Press(){} // RVA: 0x7FFAC9673DD0
        public void Release(){} // RVA: 0x7FFAC9673DF0
        public void get_format(){} // RVA: 0x7FFAC9673BC0
    }

    public class LinearAccelerationState : ValueType
    {
        public UnityEngine.Vector3 kFormat; // 0x10

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFAC9673F30
        public void get_format(){} // RVA: 0x7FFAC9673F30
    }

    public class MouseState : ValueType
    {
        public UnityEngine.Vector2 Format; // 0x10
        public UnityEngine.Vector2 format; // 0x18
        public UnityEngine.Vector2 scroll; // 0x20
        public ushort buttons; // 0x28
        public ushort displayIndex; // 0x2A
        public ushort clickCount; // 0x2C

        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFAC9673E10
        public void WithButton(){} // RVA: 0x7FFAC9673E20
        public void get_format(){} // RVA: 0x7FFAC9673E10
    }

    public class NativeInputRuntime : Object
    {
        public UnityEngine.InputSystem.LowLevel.NativeInputRuntime onUpdate;
        public bool onBeforeUpdate; // 0x10
        public System.Action onShouldRunUpdate; // 0x18
        public UnityEngine.InputSystem.LowLevel.InputUpdateDelegate onDeviceDiscovered; // 0x20
        public System.Action`1<0x6B14EA20> onShutdown; // 0x28
        public System.Func`2<0x6B14EA20,bool> onPlayerFocusChanged; // 0x30
        public float isPlayerFocused; // 0x38
        public bool pollingFrequency; // 0x3C
        public System.Action`1<bool> currentTime; // 0x40

        // ── Methods ──
        public void AllocateDeviceId(){} // RVA: 0x7FFAC967DA30
        public void Update(){} // RVA: 0x7FFAC967DAB0
        public void QueueEvent(){} // RVA: 0x7FFAC967DB40
        public void DeviceCommand(){} // RVA: 0x7FFAC967DBD0
        public void get_onUpdate(){} // RVA: 0x7FFAC2F4F0C0
        public void set_onUpdate(){} // RVA: 0x7FFAC967DCE0
        public void get_onBeforeUpdate(){} // RVA: 0x7FFAC2F4F130
        public void set_onBeforeUpdate(){} // RVA: 0x7FFAC967E040
        public void get_onShouldRunUpdate(){} // RVA: 0x7FFAC31D95E0
        public void set_onShouldRunUpdate(){} // RVA: 0x7FFAC967E300
        public void get_onDeviceDiscovered(){} // RVA: 0x7FFAC967E5C0
        public void set_onDeviceDiscovered(){} // RVA: 0x7FFAC967E660
        public void get_onShutdown(){} // RVA: 0x7FFAC2F247C0
        public void set_onShutdown(){} // RVA: 0x7FFAC967E7A0
        public void get_onPlayerFocusChanged(){} // RVA: 0x7FFAC2F9E740
        public void set_onPlayerFocusChanged(){} // RVA: 0x7FFAC967E8F0
        public void get_isPlayerFocused(){} // RVA: 0x7FFAC967ECF0
        public void get_pollingFrequency(){} // RVA: 0x7FFAC3716E90
        public void set_pollingFrequency(){} // RVA: 0x7FFAC967ED70
        public void get_currentTime(){} // RVA: 0x7FFAC967EE10
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x7FFAC967EE90
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7FFAC967EF70
        public void get_unscaledGameTime(){} // RVA: 0x7FFAC967EFF0
        public void get_runInBackground(){} // RVA: 0x7FFAC967F040
        public void set_runInBackground(){} // RVA: 0x7FFAC2FEB5F0
        public void OnShutdown(){} // RVA: 0x7FFAC669D470
        public void OnWantsToShutdown(){} // RVA: 0x7FFAC967F0D0
        public void OnFocusChanged(){} // RVA: 0x7FFAC8980DA0
        public void get_screenSize(){} // RVA: 0x7FFAC967F110
        public void get_screenOrientation(){} // RVA: 0x7FFAC967F1C0
        public void get_isInBatchMode(){} // RVA: 0x7FFAC967F210
        public void .ctor(){} // RVA: 0x7FFAC967F290
        public void .cctor(){} // RVA: 0x7FFAC967F2A0
    }

    public class PenState : ValueType
    {
        public UnityEngine.Vector2 Format; // 0x10
        public UnityEngine.Vector2 format; // 0x18
        public UnityEngine.Vector2 tilt; // 0x20
        public float pressure; // 0x28
        public float twist; // 0x2C
        public ushort buttons; // 0x30
        public ushort displayIndex; // 0x32

        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFAC9673E80
        public void WithButton(){} // RVA: 0x7FFAC9673E90
        public void get_format(){} // RVA: 0x7FFAC9673E80
    }

    public class PointerState : ValueType
    {
        public uint kFormat; // 0x10
        public UnityEngine.Vector2 format; // 0x14
        public UnityEngine.Vector2 delta; // 0x1C
        public float pressure; // 0x24
        public UnityEngine.Vector2 radius; // 0x28
        public ushort buttons; // 0x30
        public ushort displayIndex; // 0x32

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFAC9673EE0
        public void get_format(){} // RVA: 0x7FFAC9673EE0
    }

    public class QueryCanRunInBackground : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public bool canRunInBackground; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC9673420
        public void get_typeStatic(){} // RVA: 0x7FFAC9673420
        public void Create(){} // RVA: 0x7FFAC9673430
    }

    public class QueryDimensionsCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public UnityEngine.Vector2 outDimensions; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC9673450
        public void get_typeStatic(){} // RVA: 0x7FFAC9673450
        public void Create(){} // RVA: 0x7FFAC9673460
    }

    public class QueryEnabledStateCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public bool isEnabled; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC9673490
        public void get_typeStatic(){} // RVA: 0x7FFAC9673490
        public void Create(){} // RVA: 0x7FFAC96734A0
    }

    public class QueryKeyNameCommand : ValueType
    {
        public int Type;
        public int typeStatic;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10
        public int scanOrKeyCode; // 0x18
        public <nameBuffer>e__FixedBuffer nameBuffer; // 0x1C

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC9673570
        public void ReadKeyName(){} // RVA: 0x7FFAC9673580
        public void get_typeStatic(){} // RVA: 0x7FFAC9673570
        public void Create(){} // RVA: 0x7FFAC96735A0
    }

    public class QueryKeyboardLayoutCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public <nameBuffer>e__FixedBuffer nameBuffer; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC96734C0
        public void ReadLayoutName(){} // RVA: 0x7FFAC96734D0
        public void WriteLayoutName(){} // RVA: 0x7FFAC96734F0
        public void get_typeStatic(){} // RVA: 0x7FFAC96734C0
        public void Create(){} // RVA: 0x7FFAC9673530
    }

    public class QueryPairedUserAccountCommand : ValueType
    {
        public int Type;
        public int id;
        public int name;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public ulong handle; // 0x18
        public <nameBuffer>e__FixedBuffer nameBuffer; // 0x20
        public <idBuffer>e__FixedBuffer idBuffer; // 0x220

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC96735F0
        public void get_id(){} // RVA: 0x7FFAC9673600
        public void set_id(){} // RVA: 0x7FFAC9673620
        public void get_name(){} // RVA: 0x7FFAC9673750
        public void set_name(){} // RVA: 0x7FFAC9673770
        public void get_typeStatic(){} // RVA: 0x7FFAC96735F0
        public void Create(){} // RVA: 0x7FFAC96738A0
    }

    public class QuerySamplingFrequencyCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public float frequency; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC96738E0
        public void get_typeStatic(){} // RVA: 0x7FFAC96738E0
        public void Create(){} // RVA: 0x7FFAC96738F0
    }

    public class QueryUserIdCommand : ValueType
    {
        public int Type;
        public int typeStatic;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10
        public <idBuffer>e__FixedBuffer idBuffer; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC9673920
        public void ReadId(){} // RVA: 0x7FFAC96734D0
        public void get_typeStatic(){} // RVA: 0x7FFAC9673920
        public void Create(){} // RVA: 0x7FFAC9673930
    }

    public class RequestResetCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC9673970
        public void get_typeStatic(){} // RVA: 0x7FFAC9673970
        public void Create(){} // RVA: 0x7FFAC9673980
    }

    public class RequestSyncCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC96739A0
        public void get_typeStatic(){} // RVA: 0x7FFAC96739A0
        public void Create(){} // RVA: 0x7FFAC96739B0
    }

    public class SelectObservable`2 : Object
    {
        public System.IObservable`1<U> m_Source;
        public System.Func`2<U,T> m_Filter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void Subscribe(){} // RVA: 0x7FFAC2C58F40
    }

    public class SetIMECursorPositionCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand position; // 0x10
        public UnityEngine.Vector2 typeStatic; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC96739D0
        public void get_position(){} // RVA: 0x7FFAC60F5860
        public void get_typeStatic(){} // RVA: 0x7FFAC96739D0
        public void Create(){} // RVA: 0x7FFAC96739E0
    }

    public class SetSamplingFrequencyCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public float frequency; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC9673A00
        public void get_typeStatic(){} // RVA: 0x7FFAC9673A00
        public void Create(){} // RVA: 0x7FFAC9673A10
    }

    public class StateEvent : ValueType
    {
        public int stateSizeInBytes;
        public int state;
        public UnityEngine.InputSystem.LowLevel.InputEvent typeStatic; // 0x10
        public UnityEngine.InputSystem.Utilities.FourCC stateFormat; // 0x24
        public <stateData>e__FixedBuffer stateData; // 0x28

        // ── Methods ──
        public void get_stateSizeInBytes(){} // RVA: 0x7FFAC967CEB0
        public void get_state(){} // RVA: 0x7FFAC967CEC0
        public void ToEventPtr(){} // RVA: 0x7FFAC44F81E0
        public void get_typeStatic(){} // RVA: 0x7FFAC967CED0
        public void GetState(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetEventSizeWithPayload(){} // RVA: 0x7FFAC2C59990
        public void From(){} // RVA: 0x7FFAC967D070 | overloaded x3
        public void FromUnchecked(){} // RVA: 0x7FFAC44F81E0
        public void FromDefaultStateFor(){} // RVA: 0x7FFAC967D040
    }

    public class TextEvent : ValueType
    {
        public int typeStatic;
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10
        public int character; // 0x24

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFAC967D3A0
        public void From(){} // RVA: 0x7FFAC967D3B0
        public void Create(){} // RVA: 0x7FFAC967D5C0 | overloaded x2
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
        public void get_Format(){} // RVA: 0x7FFAC9673F40
        public void get_phase(){} // RVA: 0x7FFAC300F9D0
        public void set_phase(){} // RVA: 0x7FFAC300F9E0
        public void get_isNoneEndedOrCanceled(){} // RVA: 0x7FFAC9673F50
        public void get_isInProgress(){} // RVA: 0x7FFAC9673F70
        public void get_isPrimaryTouch(){} // RVA: 0x7FFAC9673F90
        public void set_isPrimaryTouch(){} // RVA: 0x7FFAC9673FA0
        public void get_isOrphanedPrimaryTouch(){} // RVA: 0x7FFAC9673FD0
        public void set_isOrphanedPrimaryTouch(){} // RVA: 0x7FFAC9673FE0
        public void get_isIndirectTouch(){} // RVA: 0x7FFAC9674010
        public void set_isIndirectTouch(){} // RVA: 0x7FFAC9674020
        public void get_isTap(){} // RVA: 0x7FFAC9674050
        public void set_isTap(){} // RVA: 0x7FFAC9674060
        public void get_isTapPress(){} // RVA: 0x7FFAC9674050
        public void set_isTapPress(){} // RVA: 0x7FFAC9674060
        public void get_isTapRelease(){} // RVA: 0x7FFAC9674090
        public void set_isTapRelease(){} // RVA: 0x7FFAC96740A0
        public void get_beganInSameFrame(){} // RVA: 0x7FFAC96740D0
        public void set_beganInSameFrame(){} // RVA: 0x7FFAC96740E0
        public void get_format(){} // RVA: 0x7FFAC9673F40
        public void ToString(){} // RVA: 0x7FFAC9674110
    }

    public class TouchscreenState : ValueType
    {
        public int Format;
        public <primaryTouchData>e__FixedBuffer primaryTouch; // 0x10
        public int touches;
        public <touchData>e__FixedBuffer format; // 0x48

        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFAC96744A0
        public void get_primaryTouch(){} // RVA: 0x7FFAC44F81E0
        public void get_touches(){} // RVA: 0x7FFAC7A451C0
        public void get_format(){} // RVA: 0x7FFAC96744A0
    }

    public class WarpMousePositionCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public UnityEngine.Vector2 warpPositionInPlayerDisplaySpace; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC9673A40
        public void get_typeStatic(){} // RVA: 0x7FFAC9673A40
        public void Create(){} // RVA: 0x7FFAC9673A50
    }

}