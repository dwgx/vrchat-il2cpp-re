// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
// Classes: 71
// Methods: 514

namespace ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
{
    public class AccelerometerState : ValueType
    {
        public object acceleration;

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7927C60
        public void get_format(){} // RVA: 0x93ABC0
    }

    public class ActionEvent : ValueType
    {
        public object baseEvent;
        public object m_ControlIndex;
        public object m_BindingIndex;
        public object m_InteractionIndex;
        public object m_StateIndex;
        public object m_Phase;
        public object m_StartTime;
        public object m_ValueData;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x79281F0
        public void get_startTime(){} // RVA: 0x931A60
        public void set_startTime(){} // RVA: 0x93AE20
        public void get_phase(){} // RVA: 0x8C600
        public void set_phase(){} // RVA: 0x8C620
        public void get_valueData(){} // RVA: 0x93AE30
        public void get_valueSizeInBytes(){} // RVA: 0x93AE40
        public void get_stateIndex(){} // RVA: 0x8C710
        public void set_stateIndex(){} // RVA: 0x93AE50
        public void get_controlIndex(){} // RVA: 0x26F890
        public void set_controlIndex(){} // RVA: 0x93AE60
        public void get_bindingIndex(){} // RVA: 0x93AE70
        public void set_bindingIndex(){} // RVA: 0x93AE80
        public void get_interactionIndex(){} // RVA: 0x93AE90
        public void set_interactionIndex(){} // RVA: 0x93AEB0
        public void ToEventPtr(){} // RVA: 0x93ADF0
        public void get_typeStatic(){} // RVA: 0x93AEC0
        public void GetEventSizeWithValueSize(){} // RVA: 0x7928430
        public void From(){} // RVA: 0x7928440
    }

    public class AttitudeState : ValueType
    {
        public object attitude;

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7927C90
        public void get_format(){} // RVA: 0x93ABF0
    }

    public class DeltaStateEvent : ValueType
    {
        public object Type;
        public object baseEvent;
        public object stateFormat;
        public object stateOffset;
        public object stateData;

        // ── Methods ──
        public void get_deltaStateSizeInBytes(){} // RVA: 0x93AED0
        public void get_deltaState(){} // RVA: 0x93AEE0
        public void get_typeStatic(){} // RVA: 0x93AEF0
        public void ToEventPtr(){} // RVA: 0x93ADF0
        public void From(){} // RVA: 0x79286D0
        public void FromUnchecked(){} // RVA: 0x2303260
    }

    public class DeviceConfigurationEvent : ValueType
    {
        public object Type;
        public object baseEvent;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x93AF00
        public void ToEventPtr(){} // RVA: 0x93ADF0
        public void Create(){} // RVA: 0x7928AC0
    }

    public class DeviceRemoveEvent : ValueType
    {
        public object Type;
        public object baseEvent;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x93AF10
        public void ToEventPtr(){} // RVA: 0x93ADF0
        public void Create(){} // RVA: 0x7928BA0
    }

    public class DeviceResetEvent : ValueType
    {
        public object Type;
        public object baseEvent;
        public object hardReset;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x93AF60
        public void Create(){} // RVA: 0x7928C80
    }

    public class DisableDeviceCommand : ValueType
    {
        public object kSize;
        public object baseCommand;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7926EC0
        public void get_typeStatic(){} // RVA: 0x93A3B0
        public void Create(){} // RVA: 0x7926ED0
    }

    public class DualMotorRumbleCommand : ValueType
    {
        public object kSize;
        public object baseCommand;
        public object lowFrequencyMotorSpeed;
        public object highFrequencyMotorSpeed;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x79278E0
        public void get_typeStatic(){} // RVA: 0x93A900
        public void Create(){} // RVA: 0x79278F0
    }

    public class EnableDeviceCommand : ValueType
    {
        public object kSize;
        public object baseCommand;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7926EF0
        public void get_typeStatic(){} // RVA: 0x93A3C0
        public void Create(){} // RVA: 0x7926F00
    }

    public class EnableIMECompositionCommand : ValueType
    {
        public object kSize;
        public object baseCommand;
        public object m_ImeEnabled;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7926F20
        public void get_imeEnabled(){} // RVA: 0x93A3D0
        public void get_typeStatic(){} // RVA: 0x93A3E0
        public void Create(){} // RVA: 0x7926F40
    }

    public class GamepadState : ValueType
    {
        public object ButtonSouthShortDisplayName;
        public object ButtonNorthShortDisplayName;
        public object ButtonWestShortDisplayName;
        public object ButtonEastShortDisplayName;
        public object buttons;
        public object leftStick;
        public object rightStick;
        public object leftTrigger;
        public object rightTrigger;

        // ── Methods ──
        public void get_Format(){} // RVA: 0x79277D0
        public void get_format(){} // RVA: 0x93A7F0
        public void .ctor(){} // RVA: 0x93A800
        public void WithButton(){} // RVA: 0x93A8B0
    }

    public class GravityState : ValueType
    {
        public object gravity;

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7927C80
        public void get_format(){} // RVA: 0x93ABE0
    }

    public class GyroscopeState : ValueType
    {
        public object angularVelocity;

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7927C70
        public void get_format(){} // RVA: 0x93ABD0
    }

    public class ICustomDeviceReset
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x894290
    }

    public class IEventMerger
    {
        // ── Methods ──
        public void MergeForward(){} // RVA: 0x87D400
    }

    public class IEventPreProcessor
    {
        // ── Methods ──
        public void PreProcessEvent(){} // RVA: 0x87D490
    }

    public class IInputDeviceCommandInfo
    {
        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x87C130
    }

    public class IInputEventTypeInfo
    {
        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x87C130
    }

    public class IInputRuntime
    {
        // ── Methods ──
        public void AllocateDeviceId(){} // RVA: 0x87C130
        public void Update(){} // RVA: 0x8944F0
        public void QueueEvent(){} // RVA: 0xA94080
        public void DeviceCommand(){} // RVA: 0xA94080
        public void get_onUpdate(){} // RVA: 0x87C0A0
        public void set_onUpdate(){} // RVA: 0x894320
        public void get_onBeforeUpdate(){} // RVA: 0x87C0A0
        public void set_onBeforeUpdate(){} // RVA: 0x894320
        public void get_onShouldRunUpdate(){} // RVA: 0x87C0A0
        public void set_onShouldRunUpdate(){} // RVA: 0x894320
        public void get_onDeviceDiscovered(){} // RVA: 0x87C0A0
        public void set_onDeviceDiscovered(){} // RVA: 0x894320
        public void get_onPlayerFocusChanged(){} // RVA: 0x87C0A0
        public void set_onPlayerFocusChanged(){} // RVA: 0x894320
        public void get_isPlayerFocused(){} // RVA: 0x87D280
        public void get_onShutdown(){} // RVA: 0x87C0A0
        public void set_onShutdown(){} // RVA: 0x894320
        public void get_pollingFrequency(){} // RVA: 0x890F90
        public void set_pollingFrequency(){} // RVA: 0x8A23A0
        public void get_currentTime(){} // RVA: 0x8820E0
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x8820E0
        public void get_unscaledGameTime(){} // RVA: 0x890F90
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x8820E0
        public void get_runInBackground(){} // RVA: 0x87D280
        public void set_runInBackground(){} // RVA: 0x894750
        public void get_screenSize(){} // RVA: 0x87C0A0
        public void get_screenOrientation(){} // RVA: 0x87C130
        public void get_normalizeScrollWheelDelta(){} // RVA: 0x87D280
        public void set_normalizeScrollWheelDelta(){} // RVA: 0x894750
        public void get_scrollWheelDeltaPerTick(){} // RVA: 0x890F90
        public void get_isInBatchMode(){} // RVA: 0x87D280
    }

    public class IInputStateCallbackReceiver
    {
        // ── Methods ──
        public void OnNextUpdate(){} // RVA: 0x894290
        public void OnStateEvent(){} // RVA: 0x8943F0
        public void GetStateOffsetForEvent(){} // RVA: 0x87FD20
    }

    public class IInputStateChangeMonitor
    {
        // ── Methods ──
        public void NotifyControlStateChanged(){} // RVA: 0x89ADC0
        public void NotifyTimerExpired(){} // RVA: 0x89ADC0
    }

    public class IInputStateTypeInfo
    {
        // ── Methods ──
        public void get_format(){} // RVA: 0x87C130
    }

    public class IInputUpdateCallbackReceiver
    {
        // ── Methods ──
        public void OnUpdate(){} // RVA: 0x894290
    }

    public class IMECompositionEvent : ValueType
    {
        public object kIMECharBufferSize;
        public object Type;
        public object baseEvent;
        public object compositionString;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x93B090
        public void Create(){} // RVA: 0x7928D70
    }

    public class IMECompositionString : ValueType
    {
        public object size;
        public object buffer;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x77E60
        public void get_Item(){} // RVA: 0x93B150
        public void .ctor(){} // RVA: 0x93B1C0
        public void ToString(){} // RVA: 0x93B230
        public void GetEnumerator(){} // RVA: 0x93B250
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x93B260
    }

    public class ITextInputReceiver
    {
        // ── Methods ──
        public void OnTextInput(){} // RVA: 0x894470
        public void OnIMECompositionChanged(){} // RVA: 0x894320
    }

    public class InitiateUserAccountPairingCommand : ValueType
    {
        public object kSize;
        public object baseCommand;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7926F70
        public void get_typeStatic(){} // RVA: 0x93A3F0
        public void Create(){} // RVA: 0x7926F80
    }

    public class InputDeviceCommand : ValueType
    {
        public object kBaseCommandSize;
        public object BaseCommandSize;
        public object GenericFailure;
        public object GenericSuccess;
        public object type;
        public object sizeInBytes;

        // ── Methods ──
        public void get_payloadSizeInBytes(){} // RVA: 0x93A400
        public void get_payloadPtr(){} // RVA: 0x93A410
        public void .ctor(){} // RVA: 0x2B100
        public void AllocateNative(){} // RVA: 0x7927050
        public void get_typeStatic(){} // RVA: 0x99090
    }

    public class InputDeviceCommandDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3A860
        public void Invoke(){} // RVA: 0x3E38920
        public void BeginInvoke(){} // RVA: 0x23E7ED0
        public void EndInvoke(){} // RVA: 0x25CC430
    }

    public class InputDeviceExecuteCommandDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DEEBF0
        public void Invoke(){} // RVA: 0xB9E010
        public void BeginInvoke(){} // RVA: 0x7926FA0
        public void EndInvoke(){} // RVA: 0x51390F0
    }

    public class InputEvent : ValueType
    {
        public object kHandledMask;
        public object kIdMask;
        public object kBaseEventSize;
        public object InvalidEventId;
        public object kAlignment;
        public object m_Event;

        // ── Methods ──
        public void get_type(){} // RVA: 0x77E60
        public void set_type(){} // RVA: 0x29580
        public void get_sizeInBytes(){} // RVA: 0x360EF0
        public void set_sizeInBytes(){} // RVA: 0x93B4C0
        public void get_eventId(){} // RVA: 0x93B4D0
        public void set_eventId(){} // RVA: 0x93B4E0
        public void get_deviceId(){} // RVA: 0x8E87F0
        public void set_deviceId(){} // RVA: 0x93B4F0
        public void get_time(){} // RVA: 0x93B500
        public void set_time(){} // RVA: 0x93B550
        public void get_internalTime(){} // RVA: 0x85010
        public void set_internalTime(){} // RVA: 0xDA1A0
        public void .ctor(){} // RVA: 0x93B5B0
        public void get_handled(){} // RVA: 0x938560
        public void set_handled(){} // RVA: 0x93B5C0
        public void ToString(){} // RVA: 0x93B5E0
        public void GetNextInMemory(){} // RVA: 0x7929760
        public void GetNextInMemoryChecked(){} // RVA: 0x7929780
        public void Equals(){} // RVA: 0x79298C0
    }

    public class InputEventBuffer : ValueType
    {
        public object BufferSizeUnknown;
        public object m_Buffer;
        public object m_SizeInBytes;
        public object m_EventCount;
        public object m_WeOwnTheBuffer;

        // ── Methods ──
        public void get_eventCount(){} // RVA: 0x8E1F0
        public void get_sizeInBytes(){} // RVA: 0x7E450
        public void get_capacityInBytes(){} // RVA: 0x93B630
        public void get_data(){} // RVA: 0x7BF80
        public void get_bufferPtr(){} // RVA: 0x93B680
        public void .ctor(){} // RVA: 0x93B6D0
        public void AppendEvent(){} // RVA: 0x93B820
        public void AllocateEvent(){} // RVA: 0x93B8B0
        public void Contains(){} // RVA: 0x93B8C0
        public void Reset(){} // RVA: 0x93B930
        public void AdvanceToNextEvent(){} // RVA: 0x93B950
        public void GetEnumerator(){} // RVA: 0x93B970
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x93B980
        public void Dispose(){} // RVA: 0x93B990
        public void Clone(){} // RVA: 0x93B9F0
        public void System.ICloneable.Clone(){} // RVA: 0x93BA20
    }

    public class InputEventListener : ValueType
    {
        public object s_ObserverState;

        // ── Methods ──
        public void op_Addition(){} // RVA: 0x792A5B0
        public void op_Subtraction(){} // RVA: 0x792A7D0
        public void Subscribe(){} // RVA: 0x93BBA0
    }

    public class InputEventPtr : ValueType
    {
        public object m_EventPtr;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x93050
        public void get_valid(){} // RVA: 0x311760
        public void get_handled(){} // RVA: 0x93BBB0
        public void set_handled(){} // RVA: 0x93BBD0
        public void get_id(){} // RVA: 0x93BBE0
        public void set_id(){} // RVA: 0x93BC00
        public void get_type(){} // RVA: 0x93BC10
        public void get_sizeInBytes(){} // RVA: 0x93BC30
        public void get_deviceId(){} // RVA: 0x93BC50
        public void set_deviceId(){} // RVA: 0x93BC70
        public void get_time(){} // RVA: 0x93BC80
        public void set_time(){} // RVA: 0x93BCE0
        public void get_internalTime(){} // RVA: 0x93BCF0
        public void set_internalTime(){} // RVA: 0x93BD10
        public void get_data(){} // RVA: 0x77900
        public void get_stateFormat(){} // RVA: 0x93BD20
        public void get_stateSizeInBytes(){} // RVA: 0x93BD30
        public void get_stateOffset(){} // RVA: 0x93BE60
        public void IsA(){} // RVA: 0x87D280
        public void Next(){} // RVA: 0x93BF50
        public void ToString(){} // RVA: 0x93BF80
        public void ToPointer(){} // RVA: 0x77900
        public void Equals(){} // RVA: 0x93BFE0
        public void GetHashCode(){} // RVA: 0x77E60
        public void op_Equality(){} // RVA: 0x2AFB5A0
        public void op_Inequality(){} // RVA: 0xD12240
        public void op_Implicit(){} // RVA: 0x2303260
        public void From(){} // RVA: 0x2303260
        public void FromInputEventPtr(){} // RVA: 0x2303260
    }

    public class InputEventStream : ValueType
    {
        public object m_NativeBuffer;
        public object m_CurrentNativeEventReadPtr;
        public object m_CurrentNativeEventWritePtr;
        public object m_RemainingNativeEventCount;
        public object m_MaxAppendedEvents;
        public object m_AppendBuffer;
        public object m_CurrentAppendEventReadPtr;
        public object m_CurrentAppendEventWritePtr;
        public object m_RemainingAppendEventCount;
        public object m_NumEventsRetainedInBuffer;
        public object m_IsOpen;

        // ── Methods ──
        public void get_isOpen(){} // RVA: 0x93C120
        public void get_remainingEventCount(){} // RVA: 0x93C130
        public void get_numEventsRetainedInBuffer(){} // RVA: 0xCFB20
        public void get_currentEventPtr(){} // RVA: 0x93C140
        public void get_numBytesRetainedInBuffer(){} // RVA: 0x93C160
        public void .ctor(){} // RVA: 0x93C1A0
        public void Close(){} // RVA: 0x93C1B0
        public void CleanUpAfterException(){} // RVA: 0x93C1C0
        public void Write(){} // RVA: 0x93C1D0
        public void Advance(){} // RVA: 0x93C1E0
        public void Peek(){} // RVA: 0x93C1F0
    }

    public class InputEventTrace : Object
    {
        public object kDefaultBufferSize;
        public object k_InputEvenTraceMarker;
        public object m_ChangeCounter;
        public object m_Enabled;
        public object m_OnFilterEvent;
        public object m_DeviceId;
        public object m_EventListeners;
        public object m_EventBufferSize;
        public object m_MaxEventBufferSize;
        public object m_GrowIncrementSize;
        public object m_EventCount;
        public object m_EventSizeInBytes;
        public object m_EventBufferStorage;
        public object m_EventBufferHeadStorage;
        public object m_EventBufferTailStorage;
        public object m_HasWrapped;
        public object m_RecordFrameMarkers;
        public object m_DeviceInfos;
        public object kFileVersion;

        // ── Methods ──
        public void get_FrameMarkerEvent(){} // RVA: 0x792BF70
        public void get_deviceId(){} // RVA: 0xFEAE90
        public void set_deviceId(){} // RVA: 0x1269760
        public void get_enabled(){} // RVA: 0xC9C250
        public void get_recordFrameMarkers(){} // RVA: 0x2558540
        public void set_recordFrameMarkers(){} // RVA: 0x792BF80
        public void get_eventCount(){} // RVA: 0x1069350
        public void get_totalEventSizeInBytes(){} // RVA: 0x106A7D0
        public void get_allocatedSizeInBytes(){} // RVA: 0x792C070
        public void get_maxSizeInBytes(){} // RVA: 0xCD48B0
        public void get_deviceInfos(){} // RVA: 0x792C090
        public void get_onFilterEvent(){} // RVA: 0xB465B0
        public void set_onFilterEvent(){} // RVA: 0xBA9BA0
        public void add_onEvent(){} // RVA: 0x792C160
        public void remove_onEvent(){} // RVA: 0x792C1B0
        public void .ctor(){} // RVA: 0x792C2C0
        public void WriteTo(){} // RVA: 0x792C430
        public void ReadFrom(){} // RVA: 0x792CC60
        public void LoadFrom(){} // RVA: 0x792D760
        public void Replay(){} // RVA: 0x792D8A0
        public void Resize(){} // RVA: 0x792D990
        public void Clear(){} // RVA: 0x792DC40
        public void Enable(){} // RVA: 0x792DCC0
        public void Disable(){} // RVA: 0x792DE40
        public void GetNextEvent(){} // RVA: 0x792DF40
        public void GetEnumerator(){} // RVA: 0x792DFC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x792DFC0
        public void Dispose(){} // RVA: 0x792E060
        public void get_m_EventBuffer(){} // RVA: 0x106A050
        public void set_m_EventBuffer(){} // RVA: 0x6A6A810
        public void get_m_EventBufferHead(){} // RVA: 0x12EB090
        public void set_m_EventBufferHead(){} // RVA: 0x24440F0
        public void get_m_EventBufferTail(){} // RVA: 0xBAE340
        public void set_m_EventBufferTail(){} // RVA: 0x2443FC0
        public void Allocate(){} // RVA: 0x792E160
        public void Release(){} // RVA: 0x792E1D0
        public void OnBeforeUpdate(){} // RVA: 0x792E2D0
        public void OnInputEvent(){} // RVA: 0x792E3E0
        public void get_kFileFormat(){} // RVA: 0x792EA10
        public void .cctor(){} // RVA: 0x792EA20
    }

    public class InputMetrics : ValueType
    {
        public object _maxNumDevices;
        public object _currentNumDevices;
        public object _maxStateSizeInBytes;
        public object _currentStateSizeInBytes;
        public object _currentControlCount;
        public object _currentLayoutCount;
        public object _totalEventBytes;
        public object _totalEventCount;
        public object _totalUpdateCount;
        public object _totalEventProcessingTime;
        public object _totalEventLagTime;

        // ── Methods ──
        public void get_maxNumDevices(){} // RVA: 0x77E60
        public void set_maxNumDevices(){} // RVA: 0x29580
        public void get_currentNumDevices(){} // RVA: 0x77E50
        public void set_currentNumDevices(){} // RVA: 0x77EE0
        public void get_maxStateSizeInBytes(){} // RVA: 0x14790
        public void set_maxStateSizeInBytes(){} // RVA: 0x92DD0
        public void get_currentStateSizeInBytes(){} // RVA: 0x92DE0
        public void set_currentStateSizeInBytes(){} // RVA: 0x92DF0
        public void get_currentControlCount(){} // RVA: 0x8C7E0
        public void set_currentControlCount(){} // RVA: 0x8C7F0
        public void get_currentLayoutCount(){} // RVA: 0xAFF50
        public void set_currentLayoutCount(){} // RVA: 0xAFF60
        public void get_totalEventBytes(){} // RVA: 0x8E1F0
        public void set_totalEventBytes(){} // RVA: 0x9E810
        public void get_totalEventCount(){} // RVA: 0x9F5A0
        public void set_totalEventCount(){} // RVA: 0x9F5B0
        public void get_totalUpdateCount(){} // RVA: 0x93180
        public void set_totalUpdateCount(){} // RVA: 0x93190
        public void get_totalEventProcessingTime(){} // RVA: 0x93C7A0
        public void set_totalEventProcessingTime(){} // RVA: 0x93C7B0
        public void get_totalEventLagTime(){} // RVA: 0x93C7C0
        public void set_totalEventLagTime(){} // RVA: 0x93C7D0
        public void get_averageEventBytesPerFrame(){} // RVA: 0x93C7E0
        public void get_averageProcessingTimePerEvent(){} // RVA: 0x93C800
        public void get_averageLagTimePerEvent(){} // RVA: 0x93C820
    }

    public class InputRuntimeExtensions : Object
    {
        // ── Methods ──
        public void DeviceCommand(){} // RVA: 0x310A2A0
    }

    public class InputState : Object
    {
        // ── Methods ──
        public void get_currentUpdateType(){} // RVA: 0x7933100
        public void get_updateCount(){} // RVA: 0x7933140
        public void get_currentTime(){} // RVA: 0x7933180
        public void add_onChange(){} // RVA: 0x7933200
        public void remove_onChange(){} // RVA: 0x79332B0
        public void Change(){} // RVA: 0x310AF70
        public void IsIntegerFormat(){} // RVA: 0x7933650
        public void AddChangeMonitor(){} // RVA: 0x79339A0
        public void RemoveChangeMonitor(){} // RVA: 0x7933B30
        public void AddChangeMonitorTimeout(){} // RVA: 0x7933C70
        public void RemoveChangeMonitorTimeout(){} // RVA: 0x7933D80
    }

    public class InputStateBlock : ValueType
    {
        public object InvalidOffset;
        public object AutomaticOffset;
        public object FormatInvalid;
        public object kFormatInvalid;
        public object FormatBit;
        public object kFormatBit;
        public object FormatSBit;
        public object kFormatSBit;
        public object FormatInt;
        public object kFormatInt;
        public object FormatUInt;
        public object kFormatUInt;
        public object FormatShort;
        public object kFormatShort;
        public object FormatUShort;
        public object kFormatUShort;
        public object FormatByte;
        public object kFormatByte;
        public object FormatSByte;
        public object kFormatSByte;
        public object FormatLong;
        public object kFormatLong;
        public object FormatULong;
        public object kFormatULong;
        public object FormatFloat;
        public object kFormatFloat;
        public object FormatDouble;
        public object kFormatDouble;
        public object FormatVector2;
        public object kFormatVector2;
        public object FormatVector3;
        public object kFormatVector3;
        public object FormatQuaternion;
        public object kFormatQuaternion;
        public object FormatVector2Short;
        public object FormatVector3Short;
        public object FormatVector2Byte;
        public object FormatVector3Byte;
        public object FormatPose;
        public object kFormatPose;
        public object _format;
        public object m_ByteOffset;
        public object _bitOffset;
        public object _sizeInBits;

        // ── Methods ──
        public void GetSizeOfPrimitiveFormatInBits(){} // RVA: 0x7933EC0
        public void GetPrimitiveFormatFromType(){} // RVA: 0x7934210
        public void get_format(){} // RVA: 0x77E60
        public void set_format(){} // RVA: 0x29580
        public void get_byteOffset(){} // RVA: 0x77E50
        public void set_byteOffset(){} // RVA: 0x77EE0
        public void get_bitOffset(){} // RVA: 0x14790
        public void set_bitOffset(){} // RVA: 0x92DD0
        public void get_sizeInBits(){} // RVA: 0x92DE0
        public void set_sizeInBits(){} // RVA: 0x92DF0
        public void get_alignedSizeInBytes(){} // RVA: 0x93C8B0
        public void get_effectiveByteOffset(){} // RVA: 0x93C900
        public void get_effectiveBitOffset(){} // RVA: 0x93C950
        public void ReadInt(){} // RVA: 0x93C9A0
        public void WriteInt(){} // RVA: 0x93C9B0
        public void ReadFloat(){} // RVA: 0x93C9C0
        public void WriteFloat(){} // RVA: 0x93C9D0
        public void FloatToPrimitiveValue(){} // RVA: 0x93C9E0
        public void ReadDouble(){} // RVA: 0x93CA10
        public void WriteDouble(){} // RVA: 0x93CA20
        public void Write(){} // RVA: 0x93CA30
        public void CopyToFrom(){} // RVA: 0x93CA50
        public void .cctor(){} // RVA: 0x79365C0
    }

    public class InputStateBuffers : ValueType
    {
        public object sizePerBuffer;
        public object totalSize;
        public object defaultStateBuffer;
        public object noiseMaskBuffer;
        public object resetMaskBuffer;
        public object m_AllBuffers;
        public object m_PlayerStateBuffers;
        public object s_DefaultStateBuffer;
        public object s_NoiseMaskBuffer;
        public object s_ResetMaskBuffer;
        public object s_CurrentBuffers;

        // ── Methods ──
        public void GetDoubleBuffersFor(){} // RVA: 0x93CA60
        public void GetFrontBufferForDevice(){} // RVA: 0x7936890
        public void GetBackBufferForDevice(){} // RVA: 0x79368F0
        public void SwitchTo(){} // RVA: 0x7936950
        public void AllocateAll(){} // RVA: 0x93CA90
        public void SetUpDeviceToBufferMappings(){} // RVA: 0x7936B60
        public void FreeAll(){} // RVA: 0x93CAA0
        public void MigrateAll(){} // RVA: 0x93CAB0
        public void MigrateDoubleBuffer(){} // RVA: 0x7936EF0
        public void MigrateSingleBuffer(){} // RVA: 0x79370D0
        public void ComputeSizeOfSingleStateBuffer(){} // RVA: 0x7937210
        public void NextDeviceOffset(){} // RVA: 0x79373A0
    }

    public class InputStateHistory : Object
    {
        public object kDefaultHistorySize;
        public object _onRecordAdded;
        public object _onShouldRecordStateChange;
        public object m_Controls;
        public object m_ControlCount;
        public object m_RecordBuffer;
        public object m_StateSizeInBytes;
        public object m_RecordCount;
        public object m_HistoryDepth;
        public object m_ExtraMemoryPerRecord;
        public object m_HeadIndex;
        public object m_CurrentVersion;
        public object m_UpdateMask;
        public object m_AddNewControls;

        // ── Methods ──
        public void get_Count(){} // RVA: 0xBE5870
        public void get_version(){} // RVA: 0x15443F0
        public void get_historyDepth(){} // RVA: 0xBE5890
        public void set_historyDepth(){} // RVA: 0x79375A0
        public void get_extraMemoryPerRecord(){} // RVA: 0x1D46130
        public void set_extraMemoryPerRecord(){} // RVA: 0x7937680
        public void get_updateMask(){} // RVA: 0x7937760
        public void set_updateMask(){} // RVA: 0x7937810
        public void get_controls(){} // RVA: 0x79378D0
        public void get_Item(){} // RVA: 0x7937980
        public void set_Item(){} // RVA: 0x7937AF0
        public void get_onRecordAdded(){} // RVA: 0xB5DBF0
        public void set_onRecordAdded(){} // RVA: 0xB44D60
        public void get_onShouldRecordStateChange(){} // RVA: 0xB465B0
        public void set_onShouldRecordStateChange(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x7938070
        public void Finalize(){} // RVA: 0x7938180
        public void Clear(){} // RVA: 0x79381C0
        public void AddRecord(){} // RVA: 0x79381D0
        public void StartRecording(){} // RVA: 0x79382A0
        public void StopRecording(){} // RVA: 0x7938480
        public void RecordStateChange(){} // RVA: 0x79389A0
        public void GetEnumerator(){} // RVA: 0x7938E30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7938E30
        public void Dispose(){} // RVA: 0x7938EE0
        public void Destroy(){} // RVA: 0x7938F90
        public void Allocate(){} // RVA: 0x7938FF0
        public void RecordIndexToUserIndex(){} // RVA: 0x7939390
        public void UserIndexToRecordIndex(){} // RVA: 0x79393B0
        public void GetRecord(){} // RVA: 0x79393C0
        public void GetRecordUnchecked(){} // RVA: 0x79394B0
        public void AllocateRecord(){} // RVA: 0x7939540
        public void ReadValue(){} // RVA: 0x310BD40
        public void ReadValueAsObject(){} // RVA: 0x7939610
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x79397E0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0xB43310
        public void get_bytesPerRecord(){} // RVA: 0x7939950
    }

    public class InputStateHistory`1 : InputStateHistory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void Finalize(){} // RVA: 0x894290
        public void AddRecord(){} // RVA: 0xA94080
        public void RecordStateChange(){} // RVA: 0xA94080
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
    }

    public class InputUpdate : Object
    {
        public object s_UpdateStepCount;
        public object s_LatestUpdateType;
        public object s_PlayerUpdateStepCount;

        // ── Methods ──
        public void OnBeforeUpdate(){} // RVA: 0x7931510
        public void OnUpdate(){} // RVA: 0x7931590
        public void Save(){} // RVA: 0x7931610
        public void Restore(){} // RVA: 0x7931660
        public void GetUpdateTypeForPlayer(){} // RVA: 0x7931700
        public void IsPlayerUpdate(){} // RVA: 0x7931720
    }

    public class InputUpdateDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xCA8B20
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x79313C0
        public void EndInvoke(){} // RVA: 0x275FED0
    }

    public class JoystickState : ValueType
    {
        public object buttons;
        public object stick;

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7927920
        public void get_format(){} // RVA: 0x93A910
    }

    public class KeyboardState : ValueType
    {
        public object kSizeInBits;
        public object kSizeInBytes;
        public object keys;

        // ── Methods ──
        public void get_Format(){} // RVA: 0x7927930
        public void .ctor(){} // RVA: 0x93AA20
        public void Set(){} // RVA: 0x93AA30
        public void Get(){} // RVA: 0x93AA60
        public void Press(){} // RVA: 0x93AA90
        public void Release(){} // RVA: 0x93AAB0
        public void get_format(){} // RVA: 0x93AAD0
    }

    public class LinearAccelerationState : ValueType
    {
        public object acceleration;

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7927CA0
        public void get_format(){} // RVA: 0x93AC00
    }

    public class MouseState : ValueType
    {
        public object position;
        public object delta;
        public object scroll;
        public object buttons;
        public object displayIndex;
        public object clickCount;

        // ── Methods ──
        public void get_Format(){} // RVA: 0x7927B80
        public void WithButton(){} // RVA: 0x93AAE0
        public void get_format(){} // RVA: 0x93AB40
    }

    public class NativeInputRuntime : Object
    {
        public object instance;
        public object m_RunInBackground;
        public object m_ShutdownMethod;
        public object m_OnUpdate;
        public object m_OnBeforeUpdate;
        public object m_OnShouldRunUpdate;
        public object m_PollingFrequency;
        public object m_DidCallOnShutdown;
        public object m_FocusChangedMethod;

        // ── Methods ──
        public void AllocateDeviceId(){} // RVA: 0x7931750
        public void Update(){} // RVA: 0x79317D0
        public void QueueEvent(){} // RVA: 0x7931860
        public void DeviceCommand(){} // RVA: 0x79318F0
        public void get_onUpdate(){} // RVA: 0xB700F0
        public void set_onUpdate(){} // RVA: 0x79319F0
        public void get_onBeforeUpdate(){} // RVA: 0xB70160
        public void set_onBeforeUpdate(){} // RVA: 0x7931D40
        public void get_onShouldRunUpdate(){} // RVA: 0xD33E60
        public void set_onShouldRunUpdate(){} // RVA: 0x7932000
        public void get_onDeviceDiscovered(){} // RVA: 0x79322C0
        public void set_onDeviceDiscovered(){} // RVA: 0x7932360
        public void get_onShutdown(){} // RVA: 0xB465B0
        public void set_onShutdown(){} // RVA: 0x79324A0
        public void get_onPlayerFocusChanged(){} // RVA: 0xBC1B30
        public void set_onPlayerFocusChanged(){} // RVA: 0x79325F0
        public void get_isPlayerFocused(){} // RVA: 0x7932740
        public void get_pollingFrequency(){} // RVA: 0x11E18C0
        public void set_pollingFrequency(){} // RVA: 0x79327C0
        public void get_currentTime(){} // RVA: 0x7932860
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x79328E0
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x79329C0
        public void get_unscaledGameTime(){} // RVA: 0x7932A40
        public void get_runInBackground(){} // RVA: 0x7932A90
        public void set_runInBackground(){} // RVA: 0xC120B0
        public void OnShutdown(){} // RVA: 0x47FD7F0
        public void OnWantsToShutdown(){} // RVA: 0x7932B20
        public void OnFocusChanged(){} // RVA: 0x6C587E0
        public void get_screenSize(){} // RVA: 0x7932B60
        public void get_screenOrientation(){} // RVA: 0x7932C10
        public void get_normalizeScrollWheelDelta(){} // RVA: 0x7932C60
        public void set_normalizeScrollWheelDelta(){} // RVA: 0x7932CE0
        public void get_scrollWheelDeltaPerTick(){} // RVA: 0x7932D70
        public void get_isInBatchMode(){} // RVA: 0x7932DF0
        public void .ctor(){} // RVA: 0x7932E70
        public void .cctor(){} // RVA: 0x7932E80
    }

    public class PenState : ValueType
    {
        public object position;
        public object delta;
        public object tilt;
        public object pressure;
        public object twist;
        public object buttons;
        public object displayIndex;

        // ── Methods ──
        public void get_Format(){} // RVA: 0x7927BF0
        public void WithButton(){} // RVA: 0x93AB50
        public void get_format(){} // RVA: 0x93ABA0
    }

    public class PointerState : ValueType
    {
        public object pointerId;
        public object position;
        public object delta;
        public object pressure;
        public object radius;
        public object buttons;
        public object displayIndex;

        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7927C50
        public void get_format(){} // RVA: 0x93ABB0
    }

    public class QueryCanRunInBackground : ValueType
    {
        public object kSize;
        public object baseCommand;
        public object canRunInBackground;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x79271A0
        public void get_typeStatic(){} // RVA: 0x93A420
        public void Create(){} // RVA: 0x79271B0
    }

    public class QueryDimensionsCommand : ValueType
    {
        public object kSize;
        public object baseCommand;
        public object outDimensions;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x79271D0
        public void get_typeStatic(){} // RVA: 0x93A430
        public void Create(){} // RVA: 0x79271E0
    }

    public class QueryEnabledStateCommand : ValueType
    {
        public object kSize;
        public object baseCommand;
        public object isEnabled;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7927210
        public void get_typeStatic(){} // RVA: 0x93A440
        public void Create(){} // RVA: 0x7927220
    }

    public class QueryKeyNameCommand : ValueType
    {
        public object kMaxNameLength;
        public object kSize;
        public object baseCommand;
        public object scanOrKeyCode;
        public object nameBuffer;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x79272F0
        public void ReadKeyName(){} // RVA: 0x93A4C0
        public void get_typeStatic(){} // RVA: 0x93A4E0
        public void Create(){} // RVA: 0x7927320
    }

    public class QueryKeyboardLayoutCommand : ValueType
    {
        public object kMaxNameLength;
        public object baseCommand;
        public object nameBuffer;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7927240
        public void ReadLayoutName(){} // RVA: 0x93A450
        public void WriteLayoutName(){} // RVA: 0x93A470
        public void get_typeStatic(){} // RVA: 0x93A4B0
        public void Create(){} // RVA: 0x79272B0
    }

    public class QueryPairedUserAccountCommand : ValueType
    {
        public object kMaxNameLength;
        public object kMaxIdLength;
        public object kSize;
        public object baseCommand;
        public object handle;
        public object nameBuffer;
        public object idBuffer;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7927370
        public void get_id(){} // RVA: 0x93A4F0
        public void set_id(){} // RVA: 0x93A510
        public void get_name(){} // RVA: 0x93A630
        public void set_name(){} // RVA: 0x93A650
        public void get_typeStatic(){} // RVA: 0x93A770
        public void Create(){} // RVA: 0x7927600
    }

    public class QuerySamplingFrequencyCommand : ValueType
    {
        public object kSize;
        public object baseCommand;
        public object frequency;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7927640
        public void get_typeStatic(){} // RVA: 0x93A780
        public void Create(){} // RVA: 0x7927650
    }

    public class QueryUserIdCommand : ValueType
    {
        public object kMaxIdLength;
        public object kSize;
        public object baseCommand;
        public object idBuffer;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7927680
        public void ReadId(){} // RVA: 0x93A450
        public void get_typeStatic(){} // RVA: 0x93A790
        public void Create(){} // RVA: 0x7927690
    }

    public class RequestResetCommand : ValueType
    {
        public object kSize;
        public object baseCommand;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x79276D0
        public void get_typeStatic(){} // RVA: 0x93A7A0
        public void Create(){} // RVA: 0x79276E0
    }

    public class RequestSyncCommand : ValueType
    {
        public object kSize;
        public object baseCommand;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7927700
        public void get_typeStatic(){} // RVA: 0x93A7B0
        public void Create(){} // RVA: 0x7927710
    }

    public class SelectObservable`2 : Object
    {
        public object m_Source;
        public object m_Filter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8943B0
        public void Subscribe(){} // RVA: 0x87C540
    }

    public class SetIMECursorPositionCommand : ValueType
    {
        public object kSize;
        public object baseCommand;
        public object m_Position;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7927730
        public void get_position(){} // RVA: 0x3647D0
        public void get_typeStatic(){} // RVA: 0x93A7C0
        public void Create(){} // RVA: 0x7927740
    }

    public class SetSamplingFrequencyCommand : ValueType
    {
        public object kSize;
        public object baseCommand;
        public object frequency;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7927760
        public void get_typeStatic(){} // RVA: 0x93A7D0
        public void Create(){} // RVA: 0x7927770
    }

    public class StateEvent : ValueType
    {
        public object Type;
        public object kStateDataSizeToSubtract;
        public object baseEvent;
        public object stateFormat;
        public object stateData;

        // ── Methods ──
        public void get_stateSizeInBytes(){} // RVA: 0x93C6D0
        public void get_state(){} // RVA: 0x93C6E0
        public void ToEventPtr(){} // RVA: 0x93ADF0
        public void get_typeStatic(){} // RVA: 0x93C6F0
        public void GetState(){} // RVA: 0xA94080
        public void GetEventSizeWithPayload(){} // RVA: 0x87CFE0
        public void From(){} // RVA: 0x7930D10
        public void FromUnchecked(){} // RVA: 0x2303260
        public void FromDefaultStateFor(){} // RVA: 0x7930CE0
    }

    public class TextEvent : ValueType
    {
        public object Type;
        public object baseEvent;
        public object character;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x93C700
        public void From(){} // RVA: 0x79310D0
        public void Create(){} // RVA: 0x79312E0
    }

    public class TouchState : ValueType
    {
        public object kSizeInBytes;
        public object touchId;
        public object position;
        public object delta;
        public object pressure;
        public object radius;
        public object phaseId;
        public object tapCount;
        public object displayIndex;
        public object flags;
        public object updateStepCount;
        public object startTime;
        public object startPosition;

        // ── Methods ──
        public void get_Format(){} // RVA: 0x7927CB0
        public void get_phase(){} // RVA: 0xA62B0
        public void set_phase(){} // RVA: 0xA62D0
        public void get_isNoneEndedOrCanceled(){} // RVA: 0x93AC10
        public void get_isInProgress(){} // RVA: 0x93AC30
        public void get_isPrimaryTouch(){} // RVA: 0x93AC50
        public void set_isPrimaryTouch(){} // RVA: 0x93AC60
        public void get_isOrphanedPrimaryTouch(){} // RVA: 0x93AC90
        public void set_isOrphanedPrimaryTouch(){} // RVA: 0x93ACA0
        public void get_isIndirectTouch(){} // RVA: 0x93ACD0
        public void set_isIndirectTouch(){} // RVA: 0x93ACE0
        public void get_isTap(){} // RVA: 0x93AD10
        public void set_isTap(){} // RVA: 0x93AD20
        public void get_isTapPress(){} // RVA: 0x93AD10
        public void set_isTapPress(){} // RVA: 0x93AD20
        public void get_isTapRelease(){} // RVA: 0x93AD50
        public void set_isTapRelease(){} // RVA: 0x93AD60
        public void get_beganInSameFrame(){} // RVA: 0x93AD90
        public void set_beganInSameFrame(){} // RVA: 0x93ADA0
        public void get_format(){} // RVA: 0x93ADD0
        public void ToString(){} // RVA: 0x93ADE0
    }

    public class TouchscreenState : ValueType
    {
        public object MaxTouches;
        public object primaryTouchData;
        public object kTouchDataOffset;
        public object touchData;

        // ── Methods ──
        public void get_Format(){} // RVA: 0x79281E0
        public void get_primaryTouch(){} // RVA: 0x93ADF0
        public void get_touches(){} // RVA: 0x93AE00
        public void get_format(){} // RVA: 0x93AE10
    }

    public class WarpMousePositionCommand : ValueType
    {
        public object kSize;
        public object baseCommand;
        public object warpPositionInPlayerDisplaySpace;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x79277A0
        public void get_typeStatic(){} // RVA: 0x93A7E0
        public void Create(){} // RVA: 0x79277B0
    }

}