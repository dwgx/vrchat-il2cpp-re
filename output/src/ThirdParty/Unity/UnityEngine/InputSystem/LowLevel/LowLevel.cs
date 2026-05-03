// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
// Classes: 72
// Methods: 530

namespace ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
{
    public class AccelerometerState : ValueType
    {
        public UnityEngine.Vector3 acceleration; // 0x10
        public object field_1; // 0x46D

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFE87A1C650
        public void get_format(){} // RVA: 0x7FFE87A1C650
    }

    public class ActionEvent : ValueType
    {
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10
        public ushort m_ControlIndex; // 0x24
        public ushort m_BindingIndex; // 0x26
        public ushort m_InteractionIndex; // 0x28
        public byte m_StateIndex; // 0x2A
        public byte m_Phase; // 0x2B
        public double m_StartTime; // 0x2C
        public <m_ValueData>e__FixedBuffer m_ValueData; // 0x34
        public object field_8; // 0x487
        public object field_9; // 0x488

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1CC10
        public void get_startTime(){} // RVA: 0x7FFE879236A0
        public void set_startTime(){} // RVA: 0x7FFE87A1CC20
        public void get_phase(){} // RVA: 0x7FFE814B32C0
        public void set_phase(){} // RVA: 0x7FFE8292DD00
        public void get_valueData(){} // RVA: 0x7FFE87A1CC30
        public void get_valueSizeInBytes(){} // RVA: 0x7FFE87A1CC40
        public void get_stateIndex(){} // RVA: 0x7FFE82930110
        public void set_stateIndex(){} // RVA: 0x7FFE87A1CC50
        public void get_controlIndex(){} // RVA: 0x7FFE83BB2220
        public void set_controlIndex(){} // RVA: 0x7FFE87A1CCC0
        public void get_bindingIndex(){} // RVA: 0x7FFE87A1CD30
        public void set_bindingIndex(){} // RVA: 0x7FFE87A1CD40
        public void get_interactionIndex(){} // RVA: 0x7FFE87A1CDB0
        public void set_interactionIndex(){} // RVA: 0x7FFE87A1CDD0
        public void ToEventPtr(){} // RVA: 0x7FFE827C4A80
        public void get_typeStatic(){} // RVA: 0x7FFE87A1CC10
        public void GetEventSizeWithValueSize(){} // RVA: 0x7FFE87A1CE50
        public void From(){} // RVA: 0x7FFE87A1CE60
    }

    public class AttitudeState : ValueType
    {
        public UnityEngine.Quaternion attitude; // 0x10
        public object field_1; // 0x473

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFE87A1C680
        public void get_format(){} // RVA: 0x7FFE87A1C680
    }

    public class DeltaStateEvent : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10
        public UnityEngine.InputSystem.Utilities.FourCC stateFormat; // 0x24

        // ── Methods ──
        public void get_deltaStateSizeInBytes(){} // RVA: 0x7FFE87A1CF90
        public void get_deltaState(){} // RVA: 0x7FFE87A1CFA0
        public void get_typeStatic(){} // RVA: 0x7FFE87A1CFB0
        public void ToEventPtr(){} // RVA: 0x7FFE827C4A80
        public void From(){} // RVA: 0x7FFE87A1D0F0 | overloaded x2
        public void FromUnchecked(){} // RVA: 0x7FFE827C4A80
    }

    public class DeviceConfigurationEvent : ValueType
    {
        public int Type;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFE87A1D470
        public void ToEventPtr(){} // RVA: 0x7FFE827C4A80
        public void Create(){} // RVA: 0x7FFE87A1D480
    }

    public class DeviceRemoveEvent : ValueType
    {
        public int Type;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFE87A1D550
        public void ToEventPtr(){} // RVA: 0x7FFE827C4A80
        public void Create(){} // RVA: 0x7FFE87A1D560
    }

    public class DeviceResetEvent : ValueType
    {
        public int Type;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFE87A1D630
        public void Create(){} // RVA: 0x7FFE87A1D640
    }

    public class DisableDeviceCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1B8A0
        public void get_typeStatic(){} // RVA: 0x7FFE87A1B8A0
        public void Create(){} // RVA: 0x7FFE87A1B8B0
    }

    public class DualMotorRumbleCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1C2D0
        public void get_typeStatic(){} // RVA: 0x7FFE87A1C2D0
        public void Create(){} // RVA: 0x7FFE87A1C2E0
    }

    public class EnableDeviceCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1B8D0
        public void get_typeStatic(){} // RVA: 0x7FFE87A1B8D0
        public void Create(){} // RVA: 0x7FFE87A1B8E0
    }

    public class EnableIMECompositionCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10
        public byte m_ImeEnabled; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1B900
        public void get_imeEnabled(){} // RVA: 0x7FFE87A1B910
        public void get_typeStatic(){} // RVA: 0x7FFE87A1B900
        public void Create(){} // RVA: 0x7FFE87A1B920
    }

    public class GamepadState : ValueType
    {
        public string ButtonSouthShortDisplayName;
        public string ButtonNorthShortDisplayName;

        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFE87A1C1D0
        public void get_format(){} // RVA: 0x7FFE87A1C1D0
        public void .ctor(){} // RVA: 0x7FFE87A1C1E0
        public void WithButton(){} // RVA: 0x7FFE87A1C280
    }

    public class GravityState : ValueType
    {
        public UnityEngine.Vector3 gravity; // 0x10
        public object field_1; // 0x471

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFE87A1C670
        public void get_format(){} // RVA: 0x7FFE87A1C670
    }

    public class GyroscopeState : ValueType
    {
        public UnityEngine.Vector3 angularVelocity; // 0x10
        public object field_1; // 0x46F

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFE87A1C660
        public void get_format(){} // RVA: 0x7FFE87A1C660
    }

    public class ICustomDeviceReset
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE80E45FE0
    }

    public class IEventMerger
    {
        // ── Methods ──
        public void MergeForward(){}
    }

    public class IEventPreProcessor
    {
        // ── Methods ──
        public void PreProcessEvent(){} // RVA: 0x7FFE80E2FC30
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
        // ── Methods ──
        public void AllocateDeviceId(){} // RVA: 0x7FFE80E2EDB0
        public void Update(){} // RVA: 0x7FFE80E46530
        public void QueueEvent(){} // RVA: 0x7FFE810A1420
        public void DeviceCommand(){} // RVA: 0x7FFE810A1420
        public void get_onUpdate(){} // RVA: 0x7FFE80E2E2E0
        public void set_onUpdate(){} // RVA: 0x7FFE80E460A0
        public void get_onBeforeUpdate(){} // RVA: 0x7FFE80E2E2E0
        public void set_onBeforeUpdate(){} // RVA: 0x7FFE80E460A0
        public void get_onShouldRunUpdate(){} // RVA: 0x7FFE80E2E2E0
        public void set_onShouldRunUpdate(){} // RVA: 0x7FFE80E460A0
        public void get_onDeviceDiscovered(){} // RVA: 0x7FFE80E2E2E0
        public void set_onDeviceDiscovered(){} // RVA: 0x7FFE80E460A0
        public void get_onPlayerFocusChanged(){} // RVA: 0x7FFE80E2E2E0
        public void set_onPlayerFocusChanged(){} // RVA: 0x7FFE80E460A0
        public void get_isPlayerFocused(){} // RVA: 0x7FFE80E2F150
        public void get_onShutdown(){} // RVA: 0x7FFE80E2E2E0
        public void set_onShutdown(){} // RVA: 0x7FFE80E460A0
        public void get_pollingFrequency(){} // RVA: 0x7FFE80E42E10
        public void set_pollingFrequency(){} // RVA: 0x7FFE80E53B80
        public void get_currentTime(){} // RVA: 0x7FFE80E33FB0
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x7FFE80E33FB0
        public void get_unscaledGameTime(){} // RVA: 0x7FFE80E42E10
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7FFE80E33FB0
        public void get_runInBackground(){} // RVA: 0x7FFE80E2F150
        public void set_runInBackground(){} // RVA: 0x7FFE80E466C0
        public void get_screenSize(){} // RVA: 0x7FFE80E2E2E0
        public void get_screenOrientation(){} // RVA: 0x7FFE80E2EDB0
        public void get_isInBatchMode(){} // RVA: 0x7FFE80E2F150
    }

    public class IInputStateCallbackReceiver
    {
        // ── Methods ──
        public void OnNextUpdate(){} // RVA: 0x7FFE80E45FE0
        public void OnStateEvent(){} // RVA: 0x7FFE80E46250
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
        public void OnUpdate(){} // RVA: 0x7FFE80E45FE0
    }

    public class IMECompositionEvent : ValueType
    {
        public int kIMECharBufferSize;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFE87A1D720
        public void Create(){} // RVA: 0x7FFE87A1D730
    }

    public class IMECompositionString : ValueType
    {
        public int size; // 0x10
        public <buffer>e__FixedBuffer buffer; // 0x14

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE826F4220
        public void get_Item(){} // RVA: 0x7FFE87A1D930
        public void .ctor(){} // RVA: 0x7FFE87A1D9A0
        public void ToString(){} // RVA: 0x7FFE87A1DA10
        public void GetEnumerator(){} // RVA: 0x7FFE87A1DA30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87A1DB00
    }

    public class ITextInputReceiver
    {
        // ── Methods ──
        public void OnTextInput(){} // RVA: 0x7FFE80E461D0
        public void OnIMECompositionChanged(){}
    }

    public class InitiateUserAccountPairingCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1B950
        public void get_typeStatic(){} // RVA: 0x7FFE87A1B950
        public void Create(){} // RVA: 0x7FFE87A1B960
    }

    public class InputDeviceCommand : ValueType
    {
        public int kBaseCommandSize;
        public int BaseCommandSize;
        public long GenericFailure;

        // ── Methods ──
        public void get_payloadSizeInBytes(){} // RVA: 0x7FFE87A1BA10
        public void get_payloadPtr(){} // RVA: 0x7FFE87A1BA20
        public void .ctor(){} // RVA: 0x7FFE8164E250
        public void AllocateNative(){} // RVA: 0x7FFE87A1BA30
        public void get_typeStatic(){} // RVA: 0x7FFE813240E0
    }

    public class InputDeviceCommandDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8401B450
        public void Invoke(){} // RVA: 0x7FFE840193C0
        public void BeginInvoke(){} // RVA: 0x7FFE82886970
        public void EndInvoke(){} // RVA: 0x7FFE82AABCD0
    }

    public class InputDeviceExecuteCommandDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83FBB1A0
        public void Invoke(){} // RVA: 0x7FFE81156C60
        public void BeginInvoke(){} // RVA: 0x7FFE87A1B980
        public void EndInvoke(){} // RVA: 0x7FFE8526B8E0
    }

    public class InputEvent : ValueType
    {
        public uint kHandledMask;
        public uint kIdMask;
        public int kBaseEventSize;
        public int InvalidEventId;
        public int kAlignment;
        public UnityEngineInternal.Input.NativeInputEvent m_Event; // 0x10
        public int structSize;

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFE826F4220
        public void set_type(){} // RVA: 0x7FFE815BF990
        public void get_sizeInBytes(){} // RVA: 0x7FFE84456F00
        public void set_sizeInBytes(){} // RVA: 0x7FFE87A1DC00
        public void get_eventId(){} // RVA: 0x7FFE87A1DCB0
        public void set_eventId(){} // RVA: 0x7FFE87A1DCC0
        public void get_deviceId(){} // RVA: 0x7FFE86E15990
        public void set_deviceId(){} // RVA: 0x7FFE87A1DCD0
        public void get_time(){} // RVA: 0x7FFE87A1DCE0
        public void set_time(){} // RVA: 0x7FFE87A1DD30
        public void get_internalTime(){} // RVA: 0x7FFE82A39E80
        public void set_internalTime(){} // RVA: 0x7FFE82D1D7B0
        public void .ctor(){} // RVA: 0x7FFE87A1DD90
        public void get_handled(){} // RVA: 0x7FFE87A1DE50
        public void set_handled(){} // RVA: 0x7FFE87A1DE60
        public void ToString(){} // RVA: 0x7FFE87A1DE80
        public void GetNextInMemory(){} // RVA: 0x7FFE87A1E180
        public void GetNextInMemoryChecked(){} // RVA: 0x7FFE87A1E1A0
        public void Equals(){} // RVA: 0x7FFE87A1E2F0
    }

    public class InputEventBuffer : ValueType
    {
        public long BufferSizeUnknown;
        public Unity.Collections.NativeArray`1<byte> m_Buffer; // 0x10
        public long m_SizeInBytes; // 0x20
        public int m_EventCount; // 0x28
        public bool m_WeOwnTheBuffer; // 0x2C

        // ── Methods ──
        public void get_eventCount(){} // RVA: 0x7FFE813DB630
        public void get_sizeInBytes(){} // RVA: 0x7FFE81116380
        public void get_capacityInBytes(){} // RVA: 0x7FFE87A1E340
        public void get_data(){} // RVA: 0x7FFE8151C410
        public void get_bufferPtr(){} // RVA: 0x7FFE87A1E390
        public void .ctor(){} // RVA: 0x7FFE87A1E5A0 | overloaded x2
        public void AppendEvent(){} // RVA: 0x7FFE87A1E6D0
        public void AllocateEvent(){} // RVA: 0x7FFE87A1E760
        public void Contains(){} // RVA: 0x7FFE87A1EA40
        public void Reset(){} // RVA: 0x7FFE87A1EAB0
        public void AdvanceToNextEvent(){} // RVA: 0x7FFE87A1EAD0
        public void GetEnumerator(){} // RVA: 0x7FFE87A1EBC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87A1EC80
        public void Dispose(){} // RVA: 0x7FFE87A1EC90
        public void Clone(){} // RVA: 0x7FFE87A1ECF0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE87A1EE80
    }

    public class InputEventListener : ValueType
    {
        // ── Methods ──
        public void op_Addition(){} // RVA: 0x7FFE87A1EFF0
        public void op_Subtraction(){} // RVA: 0x7FFE87A1F240
        public void Subscribe(){} // RVA: 0x7FFE87A1F490
    }

    public class InputEventPtr : ValueType
    {
        public UnityEngine.InputSystem.LowLevel.InputEvent* m_EventPtr; // 0x10
        public object InlinedArray`1; // 0x75F0
        public object field_2;
        public object InlinedArray`1;
        public object field_4;
        public object field_5;
        public object field_6;
        public object field_7;
        public object field_8;
        public object field_9;
        public object field_10;
        public object field_11; // 0x62B0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82889220
        public void get_valid(){} // RVA: 0x7FFE8412EC80
        public void get_handled(){} // RVA: 0x7FFE87A1FB90
        public void set_handled(){} // RVA: 0x7FFE87A1FBB0
        public void get_id(){} // RVA: 0x7FFE87A1FC30
        public void set_id(){} // RVA: 0x7FFE87A1FC50
        public void get_type(){} // RVA: 0x7FFE87A1FCD0
        public void get_sizeInBytes(){} // RVA: 0x7FFE87A1FCE0
        public void get_deviceId(){} // RVA: 0x7FFE87A1FD00
        public void set_deviceId(){} // RVA: 0x7FFE87A1FD20
        public void get_time(){} // RVA: 0x7FFE87A1FD90
        public void set_time(){} // RVA: 0x7FFE87A1FDF0
        public void get_internalTime(){} // RVA: 0x7FFE87A1FEA0
        public void set_internalTime(){} // RVA: 0x7FFE87A1FEC0
        public void get_data(){} // RVA: 0x7FFE8284EF60
        public void get_stateFormat(){} // RVA: 0x7FFE87A1FF30
        public void get_stateSizeInBytes(){} // RVA: 0x7FFE87A1FFE0
        public void get_stateOffset(){} // RVA: 0x7FFE87A20110
        public void IsA(){} // RVA: 0x7FFE80E2F150
        public void Next(){} // RVA: 0x7FFE87A20200
        public void ToString(){} // RVA: 0x7FFE87A20220
        public void ToPointer(){} // RVA: 0x7FFE8284EF60
        public void Equals(){} // RVA: 0x7FFE87A202E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void op_Equality(){} // RVA: 0x7FFE835C1CA0
        public void op_Inequality(){} // RVA: 0x7FFE869FA340
        public void op_Implicit(){} // RVA: 0x7FFE827C4A80 | overloaded x2
        public void From(){} // RVA: 0x7FFE827C4A80
        public void FromInputEventPtr(){} // RVA: 0x7FFE827C4A80
    }

    public class InputEventStream : ValueType
    {
        public UnityEngine.InputSystem.LowLevel.InputEventBuffer m_NativeBuffer; // 0x10
        public UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentNativeEventReadPtr; // 0x30
        public UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentNativeEventWritePtr; // 0x38
        public int m_RemainingNativeEventCount; // 0x40
        public int m_MaxAppendedEvents; // 0x44

        // ── Methods ──
        public void get_isOpen(){} // RVA: 0x7FFE81177320
        public void get_remainingEventCount(){} // RVA: 0x7FFE87A203A0
        public void get_numEventsRetainedInBuffer(){} // RVA: 0x7FFE82A22F10
        public void get_currentEventPtr(){} // RVA: 0x7FFE87A203B0
        public void get_numBytesRetainedInBuffer(){} // RVA: 0x7FFE87A203D0
        public void .ctor(){} // RVA: 0x7FFE87A20410
        public void Close(){} // RVA: 0x7FFE87A204A0
        public void CleanUpAfterException(){} // RVA: 0x7FFE87A20610
        public void Write(){} // RVA: 0x7FFE87A206C0
        public void Advance(){} // RVA: 0x7FFE87A20940
        public void Peek(){} // RVA: 0x7FFE87A209E0
    }

    public class InputEventTrace : Object
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
        public void get_FrameMarkerEvent(){} // RVA: 0x7FFE87A20A20
        public void get_deviceId(){} // RVA: 0x7FFE8151D690
        public void set_deviceId(){} // RVA: 0x7FFE8170B670
        public void get_enabled(){} // RVA: 0x7FFE8124ABD0
        public void get_recordFrameMarkers(){} // RVA: 0x7FFE8453D820
        public void set_recordFrameMarkers(){} // RVA: 0x7FFE87A20A30
        public void get_eventCount(){} // RVA: 0x7FFE8154EB60
        public void get_totalEventSizeInBytes(){} // RVA: 0x7FFE817AE360
        public void get_allocatedSizeInBytes(){} // RVA: 0x7FFE87A20B20
        public void get_maxSizeInBytes(){} // RVA: 0x7FFE81280C30
        public void get_deviceInfos(){} // RVA: 0x7FFE87A20B40
        public void get_onFilterEvent(){} // RVA: 0x7FFE810FE7C0
        public void set_onFilterEvent(){} // RVA: 0x7FFE81161E80
        public void add_onEvent(){} // RVA: 0x7FFE87A20C20
        public void remove_onEvent(){} // RVA: 0x7FFE87A20C70
        public void .ctor(){} // RVA: 0x7FFE87A20D80 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFE87A20EE0 | overloaded x2
        public void ReadFrom(){} // RVA: 0x7FFE87A216D0 | overloaded x2
        public void LoadFrom(){} // RVA: 0x7FFE87A221B0 | overloaded x2
        public void Replay(){} // RVA: 0x7FFE87A222F0
        public void Resize(){} // RVA: 0x7FFE87A223E0
        public void Clear(){} // RVA: 0x7FFE87A226A0
        public void Enable(){} // RVA: 0x7FFE87A22720
        public void Disable(){} // RVA: 0x7FFE87A228A0
        public void GetNextEvent(){} // RVA: 0x7FFE87A229A0
        public void GetEnumerator(){} // RVA: 0x7FFE87A22A20
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87A22A20
        public void Dispose(){} // RVA: 0x7FFE87A22AC0
        public void get_m_EventBuffer(){} // RVA: 0x7FFE8179C860
        public void set_m_EventBuffer(){} // RVA: 0x7FFE86B370C0
        public void get_m_EventBufferHead(){} // RVA: 0x7FFE817AB5E0
        public void set_m_EventBufferHead(){} // RVA: 0x7FFE82904630
        public void get_m_EventBufferTail(){} // RVA: 0x7FFE81166040
        public void set_m_EventBufferTail(){} // RVA: 0x7FFE82904640
        public void Allocate(){} // RVA: 0x7FFE87A22BC0
        public void Release(){} // RVA: 0x7FFE87A22C30
        public void OnBeforeUpdate(){} // RVA: 0x7FFE87A22D30
        public void OnInputEvent(){} // RVA: 0x7FFE87A22E30
        public void get_kFileFormat(){} // RVA: 0x7FFE87A23440
        public void .cctor(){} // RVA: 0x7FFE87A23450
    }

    public class InputMetrics : ValueType
    {
        public int _maxNumDevices; // 0x10
        public int _currentNumDevices; // 0x14
        public int _maxStateSizeInBytes; // 0x18
        public int _currentStateSizeInBytes; // 0x1C
        public int _currentControlCount; // 0x20
        public int _currentLayoutCount; // 0x24
        public int _totalEventBytes; // 0x28
        public int _totalEventCount; // 0x2C
        public int _totalUpdateCount; // 0x30
        public double _totalEventProcessingTime; // 0x38
        public double _totalEventLagTime; // 0x40
        public object InlinedArray`1; // 0x7640
        public object field_12;
        public object InlinedArray`1;

        // ── Methods ──
        public void get_maxNumDevices(){} // RVA: 0x7FFE826F4220
        public void set_maxNumDevices(){} // RVA: 0x7FFE815BF990
        public void get_currentNumDevices(){} // RVA: 0x7FFE826F42A0
        public void set_currentNumDevices(){} // RVA: 0x7FFE826F4290
        public void get_maxStateSizeInBytes(){} // RVA: 0x7FFE82C33000
        public void set_maxStateSizeInBytes(){} // RVA: 0x7FFE82C33010
        public void get_currentStateSizeInBytes(){} // RVA: 0x7FFE82C33020
        public void set_currentStateSizeInBytes(){} // RVA: 0x7FFE82C33030
        public void get_currentControlCount(){} // RVA: 0x7FFE811485C0
        public void set_currentControlCount(){} // RVA: 0x7FFE810FE0C0
        public void get_currentLayoutCount(){} // RVA: 0x7FFE8164B230
        public void set_currentLayoutCount(){} // RVA: 0x7FFE8164E0F0
        public void get_totalEventBytes(){} // RVA: 0x7FFE813DB630
        public void set_totalEventBytes(){} // RVA: 0x7FFE8144DF00
        public void get_totalEventCount(){} // RVA: 0x7FFE82707EE0
        public void set_totalEventCount(){} // RVA: 0x7FFE82717690
        public void get_totalUpdateCount(){} // RVA: 0x7FFE8151D690
        public void set_totalUpdateCount(){} // RVA: 0x7FFE8170B670
        public void get_totalEventProcessingTime(){} // RVA: 0x7FFE87A25EB0
        public void set_totalEventProcessingTime(){} // RVA: 0x7FFE87A25EC0
        public void get_totalEventLagTime(){} // RVA: 0x7FFE87A25ED0
        public void set_totalEventLagTime(){} // RVA: 0x7FFE87A25EE0
        public void get_averageEventBytesPerFrame(){} // RVA: 0x7FFE87A25EF0
        public void get_averageProcessingTimePerEvent(){} // RVA: 0x7FFE87A25F10
        public void get_averageLagTimePerEvent(){} // RVA: 0x7FFE87A25F30
    }

    public class InputRuntime : Object
    {
    }

    public class InputRuntimeExtensions : Object
    {
        // ── Methods ──
        public void DeviceCommand(){}
    }

    public class InputState : Object
    {
        // ── Methods ──
        public void get_currentUpdateType(){} // RVA: 0x7FFE87A27C80
        public void get_updateCount(){} // RVA: 0x7FFE87A27CC0
        public void get_currentTime(){} // RVA: 0x7FFE87A27D00
        public void add_onChange(){} // RVA: 0x7FFE87A27D80
        public void remove_onChange(){} // RVA: 0x7FFE87A27E30
        public void Change(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void IsIntegerFormat(){} // RVA: 0x7FFE87A281D0
        public void AddChangeMonitor(){} // RVA: 0x7FFE87A28520 | overloaded x2
        public void RemoveChangeMonitor(){} // RVA: 0x7FFE87A286B0
        public void AddChangeMonitorTimeout(){} // RVA: 0x7FFE87A287F0
        public void RemoveChangeMonitorTimeout(){} // RVA: 0x7FFE87A28900
    }

    public class InputStateBlock : ValueType
    {
        public uint InvalidOffset;
        public uint AutomaticOffset;
        public UnityEngine.InputSystem.Utilities.FourCC FormatInvalid;
        public int kFormatInvalid;
        public UnityEngine.InputSystem.Utilities.FourCC FormatBit; // 0x4
        public int kFormatBit;
        public UnityEngine.InputSystem.Utilities.FourCC FormatSBit; // 0x8

        // ── Methods ──
        public void GetSizeOfPrimitiveFormatInBits(){} // RVA: 0x7FFE87A28A40
        public void GetPrimitiveFormatFromType(){} // RVA: 0x7FFE87A28D90
        public void get_format(){} // RVA: 0x7FFE826F4220
        public void set_format(){} // RVA: 0x7FFE815BF990
        public void get_byteOffset(){} // RVA: 0x7FFE826F42A0
        public void set_byteOffset(){} // RVA: 0x7FFE826F4290
        public void get_bitOffset(){} // RVA: 0x7FFE82C33000
        public void set_bitOffset(){} // RVA: 0x7FFE82C33010
        public void get_sizeInBits(){} // RVA: 0x7FFE82C33020
        public void set_sizeInBits(){} // RVA: 0x7FFE82C33030
        public void get_alignedSizeInBytes(){} // RVA: 0x7FFE87A29410
        public void get_effectiveByteOffset(){} // RVA: 0x7FFE87A29460
        public void get_effectiveBitOffset(){} // RVA: 0x7FFE87A294B0
        public void ReadInt(){} // RVA: 0x7FFE87A29500
        public void WriteInt(){} // RVA: 0x7FFE87A297F0
        public void ReadFloat(){} // RVA: 0x7FFE87A29A70
        public void WriteFloat(){} // RVA: 0x7FFE87A29E50
        public void FloatToPrimitiveValue(){} // RVA: 0x7FFE87A2A1D0
        public void ReadDouble(){} // RVA: 0x7FFE87A2A590
        public void WriteDouble(){} // RVA: 0x7FFE87A2A990
        public void Write(){} // RVA: 0x7FFE87A2AD30
        public void CopyToFrom(){} // RVA: 0x7FFE87A2B040
        public void .cctor(){} // RVA: 0x7FFE87A2B1A0
    }

    public class InputStateBuffers : ValueType
    {
        // ── Methods ──
        public void GetDoubleBuffersFor(){} // RVA: 0x7FFE87A2B390
        public void GetFrontBufferForDevice(){} // RVA: 0x7FFE87A2B470
        public void GetBackBufferForDevice(){} // RVA: 0x7FFE87A2B4D0
        public void SwitchTo(){} // RVA: 0x7FFE87A2B530
        public void AllocateAll(){} // RVA: 0x7FFE87A2B5A0
        public void SetUpDeviceToBufferMappings(){} // RVA: 0x7FFE87A2B720
        public void FreeAll(){} // RVA: 0x7FFE87A2B7B0
        public void MigrateAll(){} // RVA: 0x7FFE87A2B8D0
        public void MigrateDoubleBuffer(){} // RVA: 0x7FFE87A2BA90
        public void MigrateSingleBuffer(){} // RVA: 0x7FFE87A2BC60
        public void ComputeSizeOfSingleStateBuffer(){} // RVA: 0x7FFE87A2BD90
        public void NextDeviceOffset(){} // RVA: 0x7FFE87A2BF10
    }

    public class InputStateHistory : Object
    {
        public int kDefaultHistorySize;
        public System.Action`1<Record> _onRecordAdded; // 0x10
        public System.Func`4<UnityEngine.InputSystem.InputControl,double,UnityEngine.InputSystem.LowLevel.InputEventPtr,bool> _onShouldRecordStateChange; // 0x18
        public UnityEngine.InputSystem.InputControl[] m_Controls; // 0x20
        public int m_ControlCount; // 0x28
        public Unity.Collections.NativeArray`1<byte> m_RecordBuffer; // 0x30
        public int m_StateSizeInBytes; // 0x40
        public int m_RecordCount; // 0x44
        public int m_HistoryDepth; // 0x48
        public int m_ExtraMemoryPerRecord; // 0x4C

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE8119C0A0
        public void get_version(){} // RVA: 0x7FFE819EA920
        public void get_historyDepth(){} // RVA: 0x7FFE8119C0C0
        public void set_historyDepth(){} // RVA: 0x7FFE87A2C110
        public void get_extraMemoryPerRecord(){} // RVA: 0x7FFE821E0A40
        public void set_extraMemoryPerRecord(){} // RVA: 0x7FFE87A2C1F0
        public void get_updateMask(){} // RVA: 0x7FFE87A2C2D0
        public void set_updateMask(){} // RVA: 0x7FFE87A2C380
        public void get_controls(){} // RVA: 0x7FFE87A2C440
        public void get_Item(){} // RVA: 0x7FFE87A2C4F0
        public void set_Item(){} // RVA: 0x7FFE87A2C670
        public void get_onRecordAdded(){} // RVA: 0x7FFE81116380
        public void set_onRecordAdded(){} // RVA: 0x7FFE810FCE30
        public void get_onShouldRecordStateChange(){} // RVA: 0x7FFE810FE7C0
        public void set_onShouldRecordStateChange(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE87A2CBF0 | overloaded x4
        public void Finalize(){} // RVA: 0x7FFE87A2CD00
        public void Clear(){} // RVA: 0x7FFE87A2CD40
        public void AddRecord(){} // RVA: 0x7FFE87A2CD50
        public void StartRecording(){} // RVA: 0x7FFE87A2CE20
        public void StopRecording(){} // RVA: 0x7FFE87A2CFE0
        public void RecordStateChange(){} // RVA: 0x7FFE87A2D500 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFE87A2D980
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87A2D980
        public void Dispose(){} // RVA: 0x7FFE87A2DA30
        public void Destroy(){} // RVA: 0x7FFE87A2DAE0
        public void Allocate(){} // RVA: 0x7FFE87A2DB40
        public void RecordIndexToUserIndex(){} // RVA: 0x7FFE87A2DED0
        public void UserIndexToRecordIndex(){} // RVA: 0x7FFE87A2DEF0
        public void GetRecord(){} // RVA: 0x7FFE87A2DF00
        public void GetRecordUnchecked(){} // RVA: 0x7FFE87A2DFF0
        public void AllocateRecord(){} // RVA: 0x7FFE87A2E080
        public void ReadValue(){} // RVA: 0x7FFE810A1420
        public void ReadValueAsObject(){} // RVA: 0x7FFE87A2E150
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7FFE87A2E320
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7FFE810FB310
        public void get_bytesPerRecord(){} // RVA: 0x7FFE87A2E490
    }

    public class InputStateHistory`1 : InputStateHistory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFE80E45FE0
        public void AddRecord(){} // RVA: 0x7FFE810A1420
        public void RecordStateChange(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
    }

    public class InputUpdate : Object
    {
        // ── Methods ──
        public void OnBeforeUpdate(){} // RVA: 0x7FFE87A25F50
        public void OnUpdate(){} // RVA: 0x7FFE87A25FD0
        public void Save(){} // RVA: 0x7FFE87A26050
        public void Restore(){} // RVA: 0x7FFE87A260A0
        public void GetUpdateTypeForPlayer(){} // RVA: 0x7FFE87A26140
        public void IsPlayerUpdate(){} // RVA: 0x7FFE87A26160
    }

    public class InputUpdateDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE812572A0
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE87A25E00
        public void EndInvoke(){} // RVA: 0x7FFE82C67E40
    }

    public class JoystickState : ValueType
    {
        public int buttons; // 0x10
        public UnityEngine.Vector2 stick; // 0x14

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFE87A1C310
        public void get_format(){} // RVA: 0x7FFE87A1C310
    }

    public class KeyboardState : ValueType
    {
        public int kSizeInBits;
        public int kSizeInBytes;

        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFE87A1C320
        public void .ctor(){} // RVA: 0x7FFE87A1C420 | overloaded x2
        public void Set(){} // RVA: 0x7FFE87911EB0
        public void Get(){} // RVA: 0x7FFE87911EE0
        public void Press(){} // RVA: 0x7FFE87A1C530
        public void Release(){} // RVA: 0x7FFE87A1C550
        public void get_format(){} // RVA: 0x7FFE87A1C320
    }

    public class LinearAccelerationState : ValueType
    {
        public UnityEngine.Vector3 acceleration; // 0x10
        public object field_1; // 0x475

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFE87A1C690
        public void get_format(){} // RVA: 0x7FFE87A1C690
    }

    public class MouseState : ValueType
    {
        public UnityEngine.Vector2 position; // 0x10
        public UnityEngine.Vector2 delta; // 0x18

        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFE87A1C570
        public void WithButton(){} // RVA: 0x7FFE87A1C580
        public void get_format(){} // RVA: 0x7FFE87A1C570
    }

    public class NativeInputRuntime : Object
    {
        public UnityEngine.InputSystem.LowLevel.NativeInputRuntime instance;
        public bool m_RunInBackground; // 0x10
        public System.Action m_ShutdownMethod; // 0x18
        public UnityEngine.InputSystem.LowLevel.InputUpdateDelegate m_OnUpdate; // 0x20
        public System.Action`1<0x66547944> m_OnBeforeUpdate; // 0x28
        public System.Func`2<0x66547944,bool> m_OnShouldRunUpdate; // 0x30
        public float m_PollingFrequency; // 0x38
        public bool m_DidCallOnShutdown; // 0x3C
        public System.Action`1<bool> m_FocusChangedMethod; // 0x40
        public object field_9; // 0x4F8
        public object field_10; // 0x4F9
        public object field_11; // 0x4FA
        public object field_12; // 0x4FB
        public object field_13; // 0x4FC
        public object field_14; // 0x4FD
        public object field_15; // 0x4FE

        // ── Methods ──
        public void AllocateDeviceId(){} // RVA: 0x7FFE87A26190
        public void Update(){} // RVA: 0x7FFE87A26210
        public void QueueEvent(){} // RVA: 0x7FFE87A262A0
        public void DeviceCommand(){} // RVA: 0x7FFE87A26330
        public void get_onUpdate(){} // RVA: 0x7FFE811290C0
        public void set_onUpdate(){} // RVA: 0x7FFE87A26440
        public void get_onBeforeUpdate(){} // RVA: 0x7FFE81129130
        public void set_onBeforeUpdate(){} // RVA: 0x7FFE87A267A0
        public void get_onShouldRunUpdate(){} // RVA: 0x7FFE8144E200
        public void set_onShouldRunUpdate(){} // RVA: 0x7FFE87A26A60
        public void get_onDeviceDiscovered(){} // RVA: 0x7FFE87A26D20
        public void set_onDeviceDiscovered(){} // RVA: 0x7FFE87A26DC0
        public void get_onShutdown(){} // RVA: 0x7FFE810FE7C0
        public void set_onShutdown(){} // RVA: 0x7FFE87A26F00
        public void get_onPlayerFocusChanged(){} // RVA: 0x7FFE81178740
        public void set_onPlayerFocusChanged(){} // RVA: 0x7FFE87A27050
        public void get_isPlayerFocused(){} // RVA: 0x7FFE87A27450
        public void get_pollingFrequency(){} // RVA: 0x7FFE8130ACF0
        public void set_pollingFrequency(){} // RVA: 0x7FFE87A274D0
        public void get_currentTime(){} // RVA: 0x7FFE87A27570
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x7FFE87A275F0
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7FFE87A276D0
        public void get_unscaledGameTime(){} // RVA: 0x7FFE87A27750
        public void get_runInBackground(){} // RVA: 0x7FFE87A277A0
        public void set_runInBackground(){} // RVA: 0x7FFE811C55F0
        public void OnShutdown(){} // RVA: 0x7FFE84A02160
        public void OnWantsToShutdown(){} // RVA: 0x7FFE87A27830
        public void OnFocusChanged(){} // RVA: 0x7FFE86D2A430
        public void get_screenSize(){} // RVA: 0x7FFE87A27870
        public void get_screenOrientation(){} // RVA: 0x7FFE87A27920
        public void get_isInBatchMode(){} // RVA: 0x7FFE87A27970
        public void .ctor(){} // RVA: 0x7FFE87A279F0
        public void .cctor(){} // RVA: 0x7FFE87A27A00
    }

    public class PenState : ValueType
    {
        public UnityEngine.Vector2 position; // 0x10
        public UnityEngine.Vector2 delta; // 0x18

        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFE87A1C5E0
        public void WithButton(){} // RVA: 0x7FFE87A1C5F0
        public void get_format(){} // RVA: 0x7FFE87A1C5E0
    }

    public class PointerState : ValueType
    {
        public uint pointerId; // 0x10
        public UnityEngine.Vector2 position; // 0x14

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFE87A1C640
        public void get_format(){} // RVA: 0x7FFE87A1C640
    }

    public class QueryCanRunInBackground : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1BB80
        public void get_typeStatic(){} // RVA: 0x7FFE87A1BB80
        public void Create(){} // RVA: 0x7FFE87A1BB90
    }

    public class QueryDimensionsCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1BBB0
        public void get_typeStatic(){} // RVA: 0x7FFE87A1BBB0
        public void Create(){} // RVA: 0x7FFE87A1BBC0
    }

    public class QueryEnabledStateCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1BBF0
        public void get_typeStatic(){} // RVA: 0x7FFE87A1BBF0
        public void Create(){} // RVA: 0x7FFE87A1BC00
    }

    public class QueryKeyNameCommand : ValueType
    {
        public int kMaxNameLength;
        public int kSize;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1BCD0
        public void ReadKeyName(){} // RVA: 0x7FFE87A1BCE0
        public void get_typeStatic(){} // RVA: 0x7FFE87A1BCD0
        public void Create(){} // RVA: 0x7FFE87A1BD00
    }

    public class QueryKeyboardLayoutCommand : ValueType
    {
        public int kMaxNameLength;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1BC20
        public void ReadLayoutName(){} // RVA: 0x7FFE87A1BC30
        public void WriteLayoutName(){} // RVA: 0x7FFE87A1BC50
        public void get_typeStatic(){} // RVA: 0x7FFE87A1BC20
        public void Create(){} // RVA: 0x7FFE87A1BC90
    }

    public class QueryPairedUserAccountCommand : ValueType
    {
        public int kMaxNameLength;
        public int kMaxIdLength;
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1BD50
        public void get_id(){} // RVA: 0x7FFE87A1BD60
        public void set_id(){} // RVA: 0x7FFE87A1BD80
        public void get_name(){} // RVA: 0x7FFE87A1BEB0
        public void set_name(){} // RVA: 0x7FFE87A1BED0
        public void get_typeStatic(){} // RVA: 0x7FFE87A1BD50
        public void Create(){} // RVA: 0x7FFE87A1C000
    }

    public class QuerySamplingFrequencyCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1C040
        public void get_typeStatic(){} // RVA: 0x7FFE87A1C040
        public void Create(){} // RVA: 0x7FFE87A1C050
    }

    public class QueryUserIdCommand : ValueType
    {
        public int kMaxIdLength;
        public int kSize;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1C080
        public void ReadId(){} // RVA: 0x7FFE87A1BC30
        public void get_typeStatic(){} // RVA: 0x7FFE87A1C080
        public void Create(){} // RVA: 0x7FFE87A1C090
    }

    public class RequestResetCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1C0D0
        public void get_typeStatic(){} // RVA: 0x7FFE87A1C0D0
        public void Create(){} // RVA: 0x7FFE87A1C0E0
    }

    public class RequestSyncCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1C100
        public void get_typeStatic(){} // RVA: 0x7FFE87A1C100
        public void Create(){} // RVA: 0x7FFE87A1C110
    }

    public class SelectObservable`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4F230
        public void Subscribe(){} // RVA: 0x7FFE80E2E390
    }

    public class SetIMECursorPositionCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10
        public UnityEngine.Vector2 m_Position; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1C130
        public void get_position(){} // RVA: 0x7FFE8445ABF0
        public void get_typeStatic(){} // RVA: 0x7FFE87A1C130
        public void Create(){} // RVA: 0x7FFE87A1C140
    }

    public class SetSamplingFrequencyCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1C160
        public void get_typeStatic(){} // RVA: 0x7FFE87A1C160
        public void Create(){} // RVA: 0x7FFE87A1C170
    }

    public class StateEvent : ValueType
    {
        public int Type;
        public int kStateDataSizeToSubtract;
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent; // 0x10

        // ── Methods ──
        public void get_stateSizeInBytes(){} // RVA: 0x7FFE87A25610
        public void get_state(){} // RVA: 0x7FFE87A25620
        public void ToEventPtr(){} // RVA: 0x7FFE827C4A80
        public void get_typeStatic(){} // RVA: 0x7FFE87A25630
        public void GetState(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetEventSizeWithPayload(){} // RVA: 0x7FFE80E2EDE0
        public void From(){} // RVA: 0x7FFE87A257D0 | overloaded x3
        public void FromUnchecked(){} // RVA: 0x7FFE827C4A80
        public void FromDefaultStateFor(){} // RVA: 0x7FFE87A257A0
    }

    public class TextEvent : ValueType
    {
        public int Type;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFE87A25B00
        public void From(){} // RVA: 0x7FFE87A25B10
        public void Create(){} // RVA: 0x7FFE87A25D20 | overloaded x2
    }

    public class TouchState : ValueType
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
        public void get_Format(){} // RVA: 0x7FFE87A1C6A0
        public void get_phase(){} // RVA: 0x7FFE811E99D0
        public void set_phase(){} // RVA: 0x7FFE811E99E0
        public void get_isNoneEndedOrCanceled(){} // RVA: 0x7FFE87A1C6B0
        public void get_isInProgress(){} // RVA: 0x7FFE87A1C6D0
        public void get_isPrimaryTouch(){} // RVA: 0x7FFE87A1C6F0
        public void set_isPrimaryTouch(){} // RVA: 0x7FFE87A1C700
        public void get_isOrphanedPrimaryTouch(){} // RVA: 0x7FFE87A1C730
        public void set_isOrphanedPrimaryTouch(){} // RVA: 0x7FFE87A1C740
        public void get_isIndirectTouch(){} // RVA: 0x7FFE87A1C770
        public void set_isIndirectTouch(){} // RVA: 0x7FFE87A1C780
        public void get_isTap(){} // RVA: 0x7FFE87A1C7B0
        public void set_isTap(){} // RVA: 0x7FFE87A1C7C0
        public void get_isTapPress(){} // RVA: 0x7FFE87A1C7B0
        public void set_isTapPress(){} // RVA: 0x7FFE87A1C7C0
        public void get_isTapRelease(){} // RVA: 0x7FFE87A1C7F0
        public void set_isTapRelease(){} // RVA: 0x7FFE87A1C800
        public void get_beganInSameFrame(){} // RVA: 0x7FFE87A1C830
        public void set_beganInSameFrame(){} // RVA: 0x7FFE87A1C840
        public void get_format(){} // RVA: 0x7FFE87A1C6A0
        public void ToString(){} // RVA: 0x7FFE87A1C870
    }

    public class TouchscreenState : ValueType
    {
        public int MaxTouches;
        public <primaryTouchData>e__FixedBuffer primaryTouchData; // 0x10
        public int kTouchDataOffset;
        public <touchData>e__FixedBuffer touchData; // 0x48

        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFE87A1CC00
        public void get_primaryTouch(){} // RVA: 0x7FFE827C4A80
        public void get_touches(){} // RVA: 0x7FFE85E2BBD0
        public void get_format(){} // RVA: 0x7FFE87A1CC00
    }

    public class WarpMousePositionCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A1C1A0
        public void get_typeStatic(){} // RVA: 0x7FFE87A1C1A0
        public void Create(){} // RVA: 0x7FFE87A1C1B0
    }

}