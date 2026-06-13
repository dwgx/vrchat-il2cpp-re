// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
// Classes: 73
// Methods: 530

namespace ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
{
    public class AccelerometerState
    {
        public UnityEngine.Vector3 acceleration; // 0x10

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x6EDB7C0
        public void get_format(){} // RVA: 0x6EDB7C0
    }

    public class ActionEvent
    {
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10
        public ushort m_ControlIndex; // 0x24
        public ushort m_BindingIndex; // 0x26
        public ushort m_InteractionIndex; // 0x28
        public byte m_StateIndex; // 0x2A
        public byte m_Phase; // 0x2B
        public double m_StartTime; // 0x2C
        public <m_ValueData>e__FixedBuffer m_ValueData; // 0x34

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDBD80
        public void get_startTime(){} // RVA: 0x6DE2810
        public void set_startTime(){} // RVA: 0x6EDBD90
        public void get_phase(){} // RVA: 0x6B90C0
        public void set_phase(){} // RVA: 0x1B98350
        public void get_valueData(){} // RVA: 0x6EDBDA0
        public void get_valueSizeInBytes(){} // RVA: 0x6EDBDB0
        public void get_stateIndex(){} // RVA: 0x1B98340
        public void set_stateIndex(){} // RVA: 0x6EDBDC0
        public void get_controlIndex(){} // RVA: 0x2EE2FD0
        public void set_controlIndex(){} // RVA: 0x6EDBE30
        public void get_bindingIndex(){} // RVA: 0x6EDBEA0
        public void set_bindingIndex(){} // RVA: 0x6EDBEB0
        public void get_interactionIndex(){} // RVA: 0x6EDBF20
        public void set_interactionIndex(){} // RVA: 0x6EDBF40
        public void ToEventPtr(){} // RVA: 0x1A3F520
        public void get_typeStatic(){} // RVA: 0x6EDBD80
        public void GetEventSizeWithValueSize(){} // RVA: 0x6EDBFC0
        public void From(){} // RVA: 0x6EDBFD0
    }

    public class AttitudeState
    {
        public UnityEngine.Quaternion attitude; // 0x10

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x6EDB7F0
        public void get_format(){} // RVA: 0x6EDB7F0
    }

    public class DeltaStateEvent
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10
        public UnityEngine.InputSystem.Utilities.FourCC stateFormat; // 0x24

        // ── Methods ──
        public void get_deltaStateSizeInBytes(){} // RVA: 0x6EDC100
        public void get_deltaState(){} // RVA: 0x6EDC110
        public void get_typeStatic(){} // RVA: 0x6EDC120
        public void ToEventPtr(){} // RVA: 0x1A3F520
        public void From(){} // RVA: 0x6EDC260 | overloaded x2
        public void FromUnchecked(){} // RVA: 0x1A3F520
    }

    public class DeviceConfigurationEvent
    {
        public int Type;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x6EDC5E0
        public void ToEventPtr(){} // RVA: 0x1A3F520
        public void Create(){} // RVA: 0x6EDC5F0
    }

    public class DeviceRemoveEvent
    {
        public int Type;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x6EDC6C0
        public void ToEventPtr(){} // RVA: 0x1A3F520
        public void Create(){} // RVA: 0x6EDC6D0
    }

    public class DeviceResetEvent
    {
        public int Type;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x6EDC7A0
        public void Create(){} // RVA: 0x6EDC7B0
    }

    public class DisableDeviceCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDAA10
        public void get_typeStatic(){} // RVA: 0x6EDAA10
        public void Create(){} // RVA: 0x6EDAA20
    }

    public class DualMotorRumbleCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDB440
        public void get_typeStatic(){} // RVA: 0x6EDB440
        public void Create(){} // RVA: 0x6EDB450
    }

    public class EnableDeviceCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDAA40
        public void get_typeStatic(){} // RVA: 0x6EDAA40
        public void Create(){} // RVA: 0x6EDAA50
    }

    public class EnableIMECompositionCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10
        public byte m_ImeEnabled; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDAA70
        public void get_imeEnabled(){} // RVA: 0x6EDAA80
        public void get_typeStatic(){} // RVA: 0x6EDAA70
        public void Create(){} // RVA: 0x6EDAA90
    }

    public class GamepadState
    {
        public string ButtonSouthShortDisplayName;
        public string ButtonNorthShortDisplayName;

        // ── Methods ──
        public void get_Format(){} // RVA: 0x6EDB340
        public void get_format(){} // RVA: 0x6EDB340
        public void .ctor(){} // RVA: 0x6EDB350
        public void WithButton(){} // RVA: 0x6EDB3F0
    }

    public class GravityState
    {
        public UnityEngine.Vector3 gravity; // 0x10

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x6EDB7E0
        public void get_format(){} // RVA: 0x6EDB7E0
    }

    public class GyroscopeState
    {
        public UnityEngine.Vector3 angularVelocity; // 0x10

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x6EDB7D0
        public void get_format(){} // RVA: 0x6EDB7D0
    }

    public class ICustomDeviceReset
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x24A50
    }

    public class IEventMerger
    {
        // ── Methods ──
        public void MergeForward(){}
    }

    public class IEventPreProcessor
    {
        // ── Methods ──
        public void PreProcessEvent(){} // RVA: 0xE6C0
    }

    public class IInputDeviceCommandInfo
    {
        // ── Methods ──
        public void get_typeStatic(){}
    }

    public class IInputEventTypeInfo
    {
        // ── Methods ──
        public void get_typeStatic(){}
    }

    public class IInputRuntime
    {
        public object 螖e;

        // ── Methods ──
        public void AllocateDeviceId(){} // RVA: 0xD840
        public void Update(){} // RVA: 0x24FA0
        public void QueueEvent(){} // RVA: 0x283FA0
        public void DeviceCommand(){} // RVA: 0x283FA0
        public void get_onUpdate(){} // RVA: 0xCD60
        public void set_onUpdate(){} // RVA: 0x24B10
        public void get_onBeforeUpdate(){} // RVA: 0xCD60
        public void set_onBeforeUpdate(){} // RVA: 0x24B10
        public void get_onShouldRunUpdate(){} // RVA: 0xCD60
        public void set_onShouldRunUpdate(){} // RVA: 0x24B10
        public void get_onDeviceDiscovered(){} // RVA: 0xCD60
        public void set_onDeviceDiscovered(){} // RVA: 0x24B10
        public void get_onPlayerFocusChanged(){} // RVA: 0xCD60
        public void set_onPlayerFocusChanged(){} // RVA: 0x24B10
        public void get_isPlayerFocused(){} // RVA: 0xDBE0
        public void get_onShutdown(){} // RVA: 0xCD60
        public void set_onShutdown(){} // RVA: 0x24B10
        public void get_pollingFrequency(){} // RVA: 0x21890
        public void set_pollingFrequency(){} // RVA: 0x325B0
        public void get_currentTime(){} // RVA: 0x12A40
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x12A40
        public void get_unscaledGameTime(){} // RVA: 0x21890
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x12A40
        public void get_runInBackground(){} // RVA: 0xDBE0
        public void set_runInBackground(){} // RVA: 0x25130
        public void get_screenSize(){} // RVA: 0xCD60
        public void get_screenOrientation(){} // RVA: 0xD840
        public void get_isInBatchMode(){} // RVA: 0xDBE0
    }

    public class IInputStateCallbackReceiver
    {
        // ── Methods ──
        public void OnNextUpdate(){} // RVA: 0x24A50
        public void OnStateEvent(){} // RVA: 0x24CC0
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
        // ── Methods ──
        public void get_format(){}
    }

    public class IInputUpdateCallbackReceiver
    {
        // ── Methods ──
        public void OnUpdate(){} // RVA: 0x24A50
    }

    public class IMECompositionEvent
    {
        public int kIMECharBufferSize;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x6EDC890
        public void Create(){} // RVA: 0x6EDC8A0
    }

    public class IMECompositionString
    {
        public int size; // 0x10
        public <buffer>e__FixedBuffer buffer; // 0x14

        // ── Methods ──
        public void get_Count(){} // RVA: 0x19689B0
        public void get_Item(){} // RVA: 0x6EDCAA0
        public void .ctor(){} // RVA: 0x6EDCB10
        public void ToString(){} // RVA: 0x6EDCB80
        public void GetEnumerator(){} // RVA: 0x6EDCBA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6EDCC70
    }

    public class ITextInputReceiver
    {
        // ── Methods ──
        public void OnTextInput(){} // RVA: 0x24C40
        public void OnIMECompositionChanged(){}
    }

    public class InitiateUserAccountPairingCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDAAC0
        public void get_typeStatic(){} // RVA: 0x6EDAAC0
        public void Create(){} // RVA: 0x6EDAAD0
    }

    public class InputDeviceCommand
    {
        public int kBaseCommandSize;
        public int BaseCommandSize;
        public long GenericFailure;

        // ── Methods ──
        public void get_payloadSizeInBytes(){} // RVA: 0x6EDAB80
        public void get_payloadPtr(){} // RVA: 0x6EDAB90
        public void .ctor(){} // RVA: 0x8AE010
        public void AllocateNative(){} // RVA: 0x6EDABA0
        public void get_typeStatic(){} // RVA: 0x519240
    }

    public class InputDeviceCommandDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33AF4F0
        public void Invoke(){} // RVA: 0x33AD460
        public void BeginInvoke(){} // RVA: 0x1AFE3C0
        public void EndInvoke(){} // RVA: 0x1D1DE50
    }

    public class InputDeviceExecuteCommandDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x333C9B0
        public void Invoke(){} // RVA: 0x338C60
        public void BeginInvoke(){} // RVA: 0x6EDAAF0
        public void EndInvoke(){} // RVA: 0x46350F0
    }

    public class InputEvent
    {
        public uint kHandledMask;
        public uint kIdMask;
        public int kBaseEventSize;
        public int InvalidEventId;
        public int kAlignment;
        public UnityEngineInternal.Input.NativeInputEvent m_Event; // 0x10

        // ── Methods ──
        public void get_type(){} // RVA: 0x19689B0
        public void set_type(){} // RVA: 0x833580
        public void get_sizeInBytes(){} // RVA: 0x37C64C0
        public void set_sizeInBytes(){} // RVA: 0x6EDCD70
        public void get_eventId(){} // RVA: 0x6EDCE20
        public void set_eventId(){} // RVA: 0x6EDCE30
        public void get_deviceId(){} // RVA: 0x62D4F60
        public void set_deviceId(){} // RVA: 0x6EDCE40
        public void get_time(){} // RVA: 0x6EDCE50
        public void set_time(){} // RVA: 0x6EDCEA0
        public void get_internalTime(){} // RVA: 0x1CA83E0
        public void set_internalTime(){} // RVA: 0x1F901F0
        public void .ctor(){} // RVA: 0x6EDCF00
        public void get_handled(){} // RVA: 0x6EDCFC0
        public void set_handled(){} // RVA: 0x6EDCFD0
        public void ToString(){} // RVA: 0x6EDCFF0
        public void GetNextInMemory(){} // RVA: 0x6EDD2F0
        public void GetNextInMemoryChecked(){} // RVA: 0x6EDD310
        public void Equals(){} // RVA: 0x6EDD460
    }

    public class InputEventBuffer
    {
        public long BufferSizeUnknown;
        public Unity.Collections.NativeArray`1<byte> m_Buffer; // 0x10
        public long m_SizeInBytes; // 0x20
        public int m_EventCount; // 0x28
        public bool m_WeOwnTheBuffer; // 0x2C

        // ── Methods ──
        public void get_eventCount(){} // RVA: 0x5BED50
        public void get_sizeInBytes(){} // RVA: 0x2F8380
        public void get_capacityInBytes(){} // RVA: 0x6EDD4B0
        public void get_data(){} // RVA: 0x75E7E0
        public void get_bufferPtr(){} // RVA: 0x6EDD500
        public void .ctor(){} // RVA: 0x6EDD710 | overloaded x2
        public void AppendEvent(){} // RVA: 0x6EDD840
        public void AllocateEvent(){} // RVA: 0x6EDD8D0
        public void Contains(){} // RVA: 0x6EDDBB0
        public void Reset(){} // RVA: 0x6EDDC20
        public void AdvanceToNextEvent(){} // RVA: 0x6EDDC40
        public void GetEnumerator(){} // RVA: 0x6EDDD30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6EDDDF0
        public void Dispose(){} // RVA: 0x6EDDE00
        public void Clone(){} // RVA: 0x6EDDE60
        public void System.ICloneable.Clone(){} // RVA: 0x6EDDFF0
    }

    public class InputEventListener
    {
        // ── Methods ──
        public void op_Addition(){} // RVA: 0x6EDE160
        public void op_Subtraction(){} // RVA: 0x6EDE3B0
        public void Subscribe(){} // RVA: 0x6EDE600
    }

    public class InputEventPtr
    {
        public UnityEngine.InputSystem.LowLevel.InputEvent* m_EventPtr; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1B12320
        public void get_valid(){} // RVA: 0x34C1790
        public void get_handled(){} // RVA: 0x6EDED00
        public void set_handled(){} // RVA: 0x6EDED20
        public void get_id(){} // RVA: 0x6EDEDA0
        public void set_id(){} // RVA: 0x6EDEDC0
        public void get_type(){} // RVA: 0x6EDEE40
        public void get_sizeInBytes(){} // RVA: 0x6EDEE50
        public void get_deviceId(){} // RVA: 0x6EDEE70
        public void set_deviceId(){} // RVA: 0x6EDEE90
        public void get_time(){} // RVA: 0x6EDEF00
        public void set_time(){} // RVA: 0x6EDEF60
        public void get_internalTime(){} // RVA: 0x6EDF010
        public void set_internalTime(){} // RVA: 0x6EDF030
        public void get_data(){} // RVA: 0x1AD4690
        public void get_stateFormat(){} // RVA: 0x6EDF0A0
        public void get_stateSizeInBytes(){} // RVA: 0x6EDF150
        public void get_stateOffset(){} // RVA: 0x6EDF280
        public void IsA(){} // RVA: 0xDBE0
        public void Next(){} // RVA: 0x6EDF370
        public void ToString(){} // RVA: 0x6EDF390
        public void ToPointer(){} // RVA: 0x1AD4690
        public void Equals(){} // RVA: 0x6EDF450 | overloaded x2
        public void GetHashCode(){} // RVA: 0x19689B0
        public void op_Equality(){} // RVA: 0x2878D00
        public void op_Inequality(){} // RVA: 0x5EB94A0
        public void op_Implicit(){} // RVA: 0x1A3F520 | overloaded x2
        public void From(){} // RVA: 0x1A3F520
        public void FromInputEventPtr(){} // RVA: 0x1A3F520
    }

    public class InputEventStream
    {
        public UnityEngine.InputSystem.LowLevel.InputEventBuffer m_NativeBuffer; // 0x10
        public UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentNativeEventReadPtr; // 0x30
        public UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentNativeEventWritePtr; // 0x38
        public int m_RemainingNativeEventCount; // 0x40
        public int m_MaxAppendedEvents; // 0x44

        // ── Methods ──
        public void get_isOpen(){} // RVA: 0x359320
        public void get_remainingEventCount(){} // RVA: 0x6EDF510
        public void get_numEventsRetainedInBuffer(){} // RVA: 0x1C91460
        public void get_currentEventPtr(){} // RVA: 0x6EDF520
        public void get_numBytesRetainedInBuffer(){} // RVA: 0x6EDF540
        public void .ctor(){} // RVA: 0x6EDF580
        public void Close(){} // RVA: 0x6EDF610
        public void CleanUpAfterException(){} // RVA: 0x6EDF780
        public void Write(){} // RVA: 0x6EDF830
        public void Advance(){} // RVA: 0x6EDFAB0
        public void Peek(){} // RVA: 0x6EDFB50
    }

    public class InputEventTrace
    {
        public int kDefaultBufferSize;
        public Unity.Profiling.ProfilerMarker k_InputEvenTraceMarker;
        public int m_ChangeCounter; // 0x10
        public bool m_Enabled; // 0x14
        public System.Func`3<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,bool> m_OnFilterEvent; // 0x18
        public int m_DeviceId; // 0x20
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<UnityEngine.InputSystem.LowLevel.InputEventPtr>> m_EventListeners; // 0x28
        public long m_EventBufferSize; // 0x78
        public long m_MaxEventBufferSize; // 0x80
        public long m_GrowIncrementSize; // 0x88
        public long m_EventCount; // 0x90
        public long m_EventSizeInBytes; // 0x98
        public ulong m_EventBufferStorage; // 0xA0
        public ulong m_EventBufferHeadStorage; // 0xA8

        // ── Methods ──
        public void get_FrameMarkerEvent(){} // RVA: 0x6EDFB90
        public void get_deviceId(){} // RVA: 0x760030
        public void set_deviceId(){} // RVA: 0x99E0D0
        public void get_enabled(){} // RVA: 0x42CBD0
        public void get_recordFrameMarkers(){} // RVA: 0x38EED40
        public void set_recordFrameMarkers(){} // RVA: 0x6EDFBA0
        public void get_eventCount(){} // RVA: 0x796DE0
        public void get_totalEventSizeInBytes(){} // RVA: 0xA1C8C0
        public void get_allocatedSizeInBytes(){} // RVA: 0x6EDFC90
        public void get_maxSizeInBytes(){} // RVA: 0x462D00
        public void get_deviceInfos(){} // RVA: 0x6EDFCB0
        public void get_onFilterEvent(){} // RVA: 0x2E07C0
        public void set_onFilterEvent(){} // RVA: 0x343E80
        public void add_onEvent(){} // RVA: 0x6EDFD90
        public void remove_onEvent(){} // RVA: 0x6EDFDE0
        public void .ctor(){} // RVA: 0x6EDFEF0 | overloaded x2
        public void WriteTo(){} // RVA: 0x6EE0050 | overloaded x2
        public void ReadFrom(){} // RVA: 0x6EE0840 | overloaded x2
        public void LoadFrom(){} // RVA: 0x6EE1320 | overloaded x2
        public void Replay(){} // RVA: 0x6EE1460
        public void Resize(){} // RVA: 0x6EE1550
        public void Clear(){} // RVA: 0x6EE1810
        public void Enable(){} // RVA: 0x6EE1890
        public void Disable(){} // RVA: 0x6EE1A10
        public void GetNextEvent(){} // RVA: 0x6EE1B10
        public void GetEnumerator(){} // RVA: 0x6EE1B90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6EE1B90
        public void Dispose(){} // RVA: 0x6EE1C30
        public void get_m_EventBuffer(){} // RVA: 0xA085E0
        public void set_m_EventBuffer(){} // RVA: 0x5FF62E0
        public void get_m_EventBufferHead(){} // RVA: 0xA1C130
        public void set_m_EventBufferHead(){} // RVA: 0x1B6C650
        public void get_m_EventBufferTail(){} // RVA: 0x348040
        public void set_m_EventBufferTail(){} // RVA: 0x1B6CD00
        public void Allocate(){} // RVA: 0x6EE1D30
        public void Release(){} // RVA: 0x6EE1DA0
        public void OnBeforeUpdate(){} // RVA: 0x6EE1EA0
        public void OnInputEvent(){} // RVA: 0x6EE1FA0
        public void get_kFileFormat(){} // RVA: 0x6EE25B0
        public void .cctor(){} // RVA: 0x6EE25C0
    }

    public class InputMetrics
    {
        public int <maxNumDevices>k__BackingField; // 0x10
        public int <currentNumDevices>k__BackingField; // 0x14
        public int <maxStateSizeInBytes>k__BackingField; // 0x18
        public int <currentStateSizeInBytes>k__BackingField; // 0x1C
        public int <currentControlCount>k__BackingField; // 0x20
        public int <currentLayoutCount>k__BackingField; // 0x24
        public int <totalEventBytes>k__BackingField; // 0x28
        public int <totalEventCount>k__BackingField; // 0x2C
        public int <totalUpdateCount>k__BackingField; // 0x30
        public double <totalEventProcessingTime>k__BackingField; // 0x38
        public double <totalEventLagTime>k__BackingField; // 0x40

        // ── Methods ──
        public void get_maxNumDevices(){} // RVA: 0x19689B0
        public void set_maxNumDevices(){} // RVA: 0x833580
        public void get_currentNumDevices(){} // RVA: 0x19689E0
        public void set_currentNumDevices(){} // RVA: 0x19689D0
        public void get_maxStateSizeInBytes(){} // RVA: 0x1EA9890
        public void set_maxStateSizeInBytes(){} // RVA: 0x1EA98A0
        public void get_currentStateSizeInBytes(){} // RVA: 0x1EA98B0
        public void set_currentStateSizeInBytes(){} // RVA: 0x1EA98C0
        public void get_currentControlCount(){} // RVA: 0x32A5C0
        public void set_currentControlCount(){} // RVA: 0x2E00C0
        public void get_currentLayoutCount(){} // RVA: 0x8ABED0
        public void set_currentLayoutCount(){} // RVA: 0x8AC660
        public void get_totalEventBytes(){} // RVA: 0x5BED50
        public void set_totalEventBytes(){} // RVA: 0x6374E0
        public void get_totalEventCount(){} // RVA: 0x197C3B0
        public void set_totalEventCount(){} // RVA: 0x1989FD0
        public void get_totalUpdateCount(){} // RVA: 0x760030
        public void set_totalUpdateCount(){} // RVA: 0x99E0D0
        public void get_totalEventProcessingTime(){} // RVA: 0x6EE5020
        public void set_totalEventProcessingTime(){} // RVA: 0x6EE5030
        public void get_totalEventLagTime(){} // RVA: 0x6EE5040
        public void set_totalEventLagTime(){} // RVA: 0x6EE5050
        public void get_averageEventBytesPerFrame(){} // RVA: 0x6EE5060
        public void get_averageProcessingTimePerEvent(){} // RVA: 0x6EE5080
        public void get_averageLagTimePerEvent(){} // RVA: 0x6EE50A0
    }

    public class InputRuntime
    {
    }

    public class InputRuntimeExtensions
    {
        // ── Methods ──
        public void DeviceCommand(){}
    }

    public class InputState
    {
        // ── Methods ──
        public void get_currentUpdateType(){} // RVA: 0x6EE6DF0
        public void get_updateCount(){} // RVA: 0x6EE6E30
        public void get_currentTime(){} // RVA: 0x6EE6E70
        public void add_onChange(){} // RVA: 0x6EE6EF0
        public void remove_onChange(){} // RVA: 0x6EE6FA0
        public void Change(){} // RVA: 0x283FA0 | overloaded x3
        public void IsIntegerFormat(){} // RVA: 0x6EE7340
        public void AddChangeMonitor(){} // RVA: 0x6EE7690 | overloaded x2
        public void RemoveChangeMonitor(){} // RVA: 0x6EE7820
        public void AddChangeMonitorTimeout(){} // RVA: 0x6EE7960
        public void RemoveChangeMonitorTimeout(){} // RVA: 0x6EE7A70
    }

    public class InputStateBlock
    {
        public uint useTransactionLog;
        public uint products;
        public UnityEngine.InputSystem.Utilities.FourCC FormatInvalid;
        public int kFormatInvalid;
        public UnityEngine.InputSystem.Utilities.FourCC FormatBit; // 0x4
        public int kFormatBit;
        public UnityEngine.InputSystem.Utilities.FourCC FormatSBit; // 0x8

        // ── Methods ──
        public void GetSizeOfPrimitiveFormatInBits(){} // RVA: 0x6EE7BB0
        public void GetPrimitiveFormatFromType(){} // RVA: 0x6EE7F00
        public void get_format(){} // RVA: 0x19689B0
        public void set_format(){} // RVA: 0x833580
        public void get_byteOffset(){} // RVA: 0x19689E0
        public void set_byteOffset(){} // RVA: 0x19689D0
        public void get_bitOffset(){} // RVA: 0x1EA9890
        public void set_bitOffset(){} // RVA: 0x1EA98A0
        public void get_sizeInBits(){} // RVA: 0x1EA98B0
        public void set_sizeInBits(){} // RVA: 0x1EA98C0
        public void get_alignedSizeInBytes(){} // RVA: 0x6EE8580
        public void get_effectiveByteOffset(){} // RVA: 0x6EE85D0
        public void get_effectiveBitOffset(){} // RVA: 0x6EE8620
        public void ReadInt(){} // RVA: 0x6EE8670
        public void WriteInt(){} // RVA: 0x6EE8960
        public void ReadFloat(){} // RVA: 0x6EE8BE0
        public void WriteFloat(){} // RVA: 0x6EE8FC0
        public void FloatToPrimitiveValue(){} // RVA: 0x6EE9340
        public void ReadDouble(){} // RVA: 0x6EE9700
        public void WriteDouble(){} // RVA: 0x6EE9B00
        public void Write(){} // RVA: 0x6EE9EA0
        public void CopyToFrom(){} // RVA: 0x6EEA1B0
        public void .cctor(){} // RVA: 0x6EEA310
    }

    public class InputStateBuffers
    {
        // ── Methods ──
        public void GetDoubleBuffersFor(){} // RVA: 0x6EEA500
        public void GetFrontBufferForDevice(){} // RVA: 0x6EEA5E0
        public void GetBackBufferForDevice(){} // RVA: 0x6EEA640
        public void SwitchTo(){} // RVA: 0x6EEA6A0
        public void AllocateAll(){} // RVA: 0x6EEA710
        public void SetUpDeviceToBufferMappings(){} // RVA: 0x6EEA890
        public void FreeAll(){} // RVA: 0x6EEA920
        public void MigrateAll(){} // RVA: 0x6EEAA40
        public void MigrateDoubleBuffer(){} // RVA: 0x6EEAC00
        public void MigrateSingleBuffer(){} // RVA: 0x6EEADD0
        public void ComputeSizeOfSingleStateBuffer(){} // RVA: 0x6EEAF00
        public void NextDeviceOffset(){} // RVA: 0x6EEB080
    }

    public class InputStateHistory
    {
        public int kDefaultHistorySize;
        public System.Action`1<Record> <onRecordAdded>k__BackingField; // 0x10
        public System.Func`4<UnityEngine.InputSystem.InputControl,double,UnityEngine.InputSystem.LowLevel.InputEventPtr,bool> <onShouldRecordStateChange>k__BackingField; // 0x18
        public UnityEngine.InputSystem.InputControl[] m_Controls; // 0x20
        public int m_ControlCount; // 0x28
        public Unity.Collections.NativeArray`1<byte> m_RecordBuffer; // 0x30
        public int m_StateSizeInBytes; // 0x40
        public int m_RecordCount; // 0x44
        public int m_HistoryDepth; // 0x48
        public int m_ExtraMemoryPerRecord; // 0x4C

        // ── Methods ──
        public void get_Count(){} // RVA: 0x37E0A0
        public void get_version(){} // RVA: 0xC5BE80
        public void get_historyDepth(){} // RVA: 0x37E0C0
        public void set_historyDepth(){} // RVA: 0x6EEB280
        public void get_extraMemoryPerRecord(){} // RVA: 0x1479960
        public void set_extraMemoryPerRecord(){} // RVA: 0x6EEB360
        public void get_updateMask(){} // RVA: 0x6EEB440
        public void set_updateMask(){} // RVA: 0x6EEB4F0
        public void get_controls(){} // RVA: 0x6EEB5B0
        public void get_Item(){} // RVA: 0x6EEB660
        public void set_Item(){} // RVA: 0x6EEB7E0
        public void get_onRecordAdded(){} // RVA: 0x2F8380
        public void set_onRecordAdded(){} // RVA: 0x2DEE30
        public void get_onShouldRecordStateChange(){} // RVA: 0x2E07C0
        public void set_onShouldRecordStateChange(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x6EEBD60 | overloaded x4
        public void Finalize(){} // RVA: 0x6EEBE70
        public void Clear(){} // RVA: 0x6EEBEB0
        public void AddRecord(){} // RVA: 0x6EEBEC0
        public void StartRecording(){} // RVA: 0x6EEBF90
        public void StopRecording(){} // RVA: 0x6EEC150
        public void RecordStateChange(){} // RVA: 0x6EEC670 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x6EECAF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6EECAF0
        public void Dispose(){} // RVA: 0x6EECBA0
        public void Destroy(){} // RVA: 0x6EECC50
        public void Allocate(){} // RVA: 0x6EECCB0
        public void RecordIndexToUserIndex(){} // RVA: 0x6EED040
        public void UserIndexToRecordIndex(){} // RVA: 0x6EED060
        public void GetRecord(){} // RVA: 0x6EED070
        public void GetRecordUnchecked(){} // RVA: 0x6EED160
        public void AllocateRecord(){} // RVA: 0x6EED1F0
        public void ReadValue(){} // RVA: 0x283FA0
        public void ReadValueAsObject(){} // RVA: 0x6EED2C0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x6EED490
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x2DD310
        public void get_bytesPerRecord(){} // RVA: 0x6EED600
    }

    public class InputStateHistory`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x3
        public void Finalize(){} // RVA: 0x24A50
        public void AddRecord(){} // RVA: 0x283FA0
        public void RecordStateChange(){} // RVA: 0x283FA0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
    }

    public class InputStateHistory`1
    {
    }

    public class InputUpdate
    {
        // ── Methods ──
        public void OnBeforeUpdate(){} // RVA: 0x6EE50C0
        public void OnUpdate(){} // RVA: 0x6EE5140
        public void Save(){} // RVA: 0x6EE51C0
        public void Restore(){} // RVA: 0x6EE5210
        public void GetUpdateTypeForPlayer(){} // RVA: 0x6EE52B0
        public void IsPlayerUpdate(){} // RVA: 0x6EE52D0
    }

    public class InputUpdateDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4392A0
        public void Invoke(){} // RVA: 0x439370
        public void BeginInvoke(){} // RVA: 0x6EE4F70
        public void EndInvoke(){} // RVA: 0x1EDD9F0
    }

    public class JoystickState
    {
        public int buttons; // 0x10
        public UnityEngine.Vector2 stick; // 0x14

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x6EDB480
        public void get_format(){} // RVA: 0x6EDB480
    }

    public class KeyboardState
    {
        public int kSizeInBits;
        public int kSizeInBytes;

        // ── Methods ──
        public void get_Format(){} // RVA: 0x6EDB490
        public void .ctor(){} // RVA: 0x6EDB590 | overloaded x2
        public void Set(){} // RVA: 0x6DD1020
        public void Get(){} // RVA: 0x6DD1050
        public void Press(){} // RVA: 0x6EDB6A0
        public void Release(){} // RVA: 0x6EDB6C0
        public void get_format(){} // RVA: 0x6EDB490
    }

    public class LinearAccelerationState
    {
        public UnityEngine.Vector3 acceleration; // 0x10

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x6EDB800
        public void get_format(){} // RVA: 0x6EDB800
    }

    public class MouseState
    {
        public UnityEngine.Vector2 position; // 0x10
        public UnityEngine.Vector2 delta; // 0x18

        // ── Methods ──
        public void get_Format(){} // RVA: 0x6EDB6E0
        public void WithButton(){} // RVA: 0x6EDB6F0
        public void get_format(){} // RVA: 0x6EDB6E0
    }

    public class NativeInputRuntime
    {
        public UnityEngine.InputSystem.LowLevel.NativeInputRuntime instance;
        public bool m_RunInBackground; // 0x10
        public System.Action m_ShutdownMethod; // 0x18
        public UnityEngine.InputSystem.LowLevel.InputUpdateDelegate m_OnUpdate; // 0x20
        public System.Action`1<0x6586FA90> m_OnBeforeUpdate; // 0x28
        public System.Func`2<0x6586FA90,bool> m_OnShouldRunUpdate; // 0x30
        public float m_PollingFrequency; // 0x38
        public bool m_DidCallOnShutdown; // 0x3C
        public System.Action`1<bool> m_FocusChangedMethod; // 0x40

        // ── Methods ──
        public void AllocateDeviceId(){} // RVA: 0x6EE5300
        public void Update(){} // RVA: 0x6EE5380
        public void QueueEvent(){} // RVA: 0x6EE5410
        public void DeviceCommand(){} // RVA: 0x6EE54A0
        public void get_onUpdate(){} // RVA: 0x30B0C0
        public void set_onUpdate(){} // RVA: 0x6EE55B0
        public void get_onBeforeUpdate(){} // RVA: 0x30B130
        public void set_onBeforeUpdate(){} // RVA: 0x6EE5910
        public void get_onShouldRunUpdate(){} // RVA: 0x6374D0
        public void set_onShouldRunUpdate(){} // RVA: 0x6EE5BD0
        public void get_onDeviceDiscovered(){} // RVA: 0x6EE5E90
        public void set_onDeviceDiscovered(){} // RVA: 0x6EE5F30
        public void get_onShutdown(){} // RVA: 0x2E07C0
        public void set_onShutdown(){} // RVA: 0x6EE6070
        public void get_onPlayerFocusChanged(){} // RVA: 0x35A740
        public void set_onPlayerFocusChanged(){} // RVA: 0x6EE61C0
        public void get_isPlayerFocused(){} // RVA: 0x6EE65C0
        public void get_pollingFrequency(){} // RVA: 0x4FE250
        public void set_pollingFrequency(){} // RVA: 0x6EE6640
        public void get_currentTime(){} // RVA: 0x6EE66E0
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x6EE6760
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x6EE6840
        public void get_unscaledGameTime(){} // RVA: 0x6EE68C0
        public void get_runInBackground(){} // RVA: 0x6EE6910
        public void set_runInBackground(){} // RVA: 0x3A75F0
        public void OnShutdown(){} // RVA: 0x3D91AE0
        public void OnWantsToShutdown(){} // RVA: 0x6EE69A0
        public void OnFocusChanged(){} // RVA: 0x61E9590
        public void get_screenSize(){} // RVA: 0x6EE69E0
        public void get_screenOrientation(){} // RVA: 0x6EE6A90
        public void get_isInBatchMode(){} // RVA: 0x6EE6AE0
        public void .ctor(){} // RVA: 0x6EE6B60
        public void .cctor(){} // RVA: 0x6EE6B70
    }

    public class PenState
    {
        public UnityEngine.Vector2 position; // 0x10
        public UnityEngine.Vector2 delta; // 0x18

        // ── Methods ──
        public void get_Format(){} // RVA: 0x6EDB750
        public void WithButton(){} // RVA: 0x6EDB760
        public void get_format(){} // RVA: 0x6EDB750
    }

    public class PointerState
    {
        public uint pointerId; // 0x10
        public UnityEngine.Vector2 position; // 0x14

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x6EDB7B0
        public void get_format(){} // RVA: 0x6EDB7B0
    }

    public class QueryCanRunInBackground
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDACF0
        public void get_typeStatic(){} // RVA: 0x6EDACF0
        public void Create(){} // RVA: 0x6EDAD00
    }

    public class QueryDimensionsCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDAD20
        public void get_typeStatic(){} // RVA: 0x6EDAD20
        public void Create(){} // RVA: 0x6EDAD30
    }

    public class QueryEnabledStateCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDAD60
        public void get_typeStatic(){} // RVA: 0x6EDAD60
        public void Create(){} // RVA: 0x6EDAD70
    }

    public class QueryKeyNameCommand
    {
        public int kMaxNameLength;
        public int kSize;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDAE40
        public void ReadKeyName(){} // RVA: 0x6EDAE50
        public void get_typeStatic(){} // RVA: 0x6EDAE40
        public void Create(){} // RVA: 0x6EDAE70
    }

    public class QueryKeyboardLayoutCommand
    {
        public int kMaxNameLength;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDAD90
        public void ReadLayoutName(){} // RVA: 0x6EDADA0
        public void WriteLayoutName(){} // RVA: 0x6EDADC0
        public void get_typeStatic(){} // RVA: 0x6EDAD90
        public void Create(){} // RVA: 0x6EDAE00
    }

    public class QueryPairedUserAccountCommand
    {
        public int kMaxNameLength;
        public int kMaxIdLength;
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDAEC0
        public void get_id(){} // RVA: 0x6EDAED0
        public void set_id(){} // RVA: 0x6EDAEF0
        public void get_name(){} // RVA: 0x6EDB020
        public void set_name(){} // RVA: 0x6EDB040
        public void get_typeStatic(){} // RVA: 0x6EDAEC0
        public void Create(){} // RVA: 0x6EDB170
    }

    public class QuerySamplingFrequencyCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDB1B0
        public void get_typeStatic(){} // RVA: 0x6EDB1B0
        public void Create(){} // RVA: 0x6EDB1C0
    }

    public class QueryUserIdCommand
    {
        public int kMaxIdLength;
        public int kSize;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDB1F0
        public void ReadId(){} // RVA: 0x6EDADA0
        public void get_typeStatic(){} // RVA: 0x6EDB1F0
        public void Create(){} // RVA: 0x6EDB200
    }

    public class RequestResetCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDB240
        public void get_typeStatic(){} // RVA: 0x6EDB240
        public void Create(){} // RVA: 0x6EDB250
    }

    public class RequestSyncCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDB270
        public void get_typeStatic(){} // RVA: 0x6EDB270
        public void Create(){} // RVA: 0x6EDB280
    }

    public class SelectObservable`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DC60
        public void Subscribe(){} // RVA: 0xCE10
    }

    public class SetIMECursorPositionCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10
        public UnityEngine.Vector2 m_Position; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDB2A0
        public void get_position(){} // RVA: 0x37CA1B0
        public void get_typeStatic(){} // RVA: 0x6EDB2A0
        public void Create(){} // RVA: 0x6EDB2B0
    }

    public class SetSamplingFrequencyCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDB2D0
        public void get_typeStatic(){} // RVA: 0x6EDB2D0
        public void Create(){} // RVA: 0x6EDB2E0
    }

    public class StateEvent
    {
        public int Type;
        public int kStateDataSizeToSubtract;
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10

        // ── Methods ──
        public void get_stateSizeInBytes(){} // RVA: 0x6EE4780
        public void get_state(){} // RVA: 0x6EE4790
        public void ToEventPtr(){} // RVA: 0x1A3F520
        public void get_typeStatic(){} // RVA: 0x6EE47A0
        public void GetState(){} // RVA: 0x283FA0 | overloaded x2
        public void GetEventSizeWithPayload(){} // RVA: 0xD870
        public void From(){} // RVA: 0x6EE4940 | overloaded x3
        public void FromUnchecked(){} // RVA: 0x1A3F520
        public void FromDefaultStateFor(){} // RVA: 0x6EE4910
    }

    public class TextEvent
    {
        public int Type;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x6EE4C70
        public void From(){} // RVA: 0x6EE4C80
        public void Create(){} // RVA: 0x6EE4E90 | overloaded x2
    }

    public class TouchState
    {
        public int kSizeInBytes;
        public int touchId; // 0x10
        public UnityEngine.Vector2 position; // 0x14
        public UnityEngine.Vector2 delta; // 0x1C
        public float pressure; // 0x24
        public UnityEngine.Vector2 radius; // 0x28
        public byte phaseId; // 0x30
        public byte tapCount; // 0x31
        public byte displayIndex; // 0x32
        public byte flags; // 0x33
        public uint updateStepCount; // 0x34
        public double startTime; // 0x38

        // ── Methods ──
        public void get_Format(){} // RVA: 0x6EDB810
        public void get_phase(){} // RVA: 0x3CB9D0
        public void set_phase(){} // RVA: 0x3CB9E0
        public void get_isNoneEndedOrCanceled(){} // RVA: 0x6EDB820
        public void get_isInProgress(){} // RVA: 0x6EDB840
        public void get_isPrimaryTouch(){} // RVA: 0x6EDB860
        public void set_isPrimaryTouch(){} // RVA: 0x6EDB870
        public void get_isOrphanedPrimaryTouch(){} // RVA: 0x6EDB8A0
        public void set_isOrphanedPrimaryTouch(){} // RVA: 0x6EDB8B0
        public void get_isIndirectTouch(){} // RVA: 0x6EDB8E0
        public void set_isIndirectTouch(){} // RVA: 0x6EDB8F0
        public void get_isTap(){} // RVA: 0x6EDB920
        public void set_isTap(){} // RVA: 0x6EDB930
        public void get_isTapPress(){} // RVA: 0x6EDB920
        public void set_isTapPress(){} // RVA: 0x6EDB930
        public void get_isTapRelease(){} // RVA: 0x6EDB960
        public void set_isTapRelease(){} // RVA: 0x6EDB970
        public void get_beganInSameFrame(){} // RVA: 0x6EDB9A0
        public void set_beganInSameFrame(){} // RVA: 0x6EDB9B0
        public void get_format(){} // RVA: 0x6EDB810
        public void ToString(){} // RVA: 0x6EDB9E0
    }

    public class TouchscreenState
    {
        public int MaxTouches;
        public <primaryTouchData>e__FixedBuffer primaryTouchData; // 0x10
        public int kTouchDataOffset;
        public <touchData>e__FixedBuffer touchData; // 0x48

        // ── Methods ──
        public void get_Format(){} // RVA: 0x6EDBD70
        public void get_primaryTouch(){} // RVA: 0x1A3F520
        public void get_touches(){} // RVA: 0x535CA10
        public void get_format(){} // RVA: 0x6EDBD70
    }

    public class WarpMousePositionCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EDB310
        public void get_typeStatic(){} // RVA: 0x6EDB310
        public void Create(){} // RVA: 0x6EDB320
    }

}