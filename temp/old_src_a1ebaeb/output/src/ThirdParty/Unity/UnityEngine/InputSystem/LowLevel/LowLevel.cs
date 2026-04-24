// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
// Classes: 58
// Methods: 484

namespace ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
{
    public class ActionEvent : ValueType
    {
        public object m_BindingIndex; // 0x337BD430
        public object m_Phase; // 0x337BD430

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf096490
        public void get_startTime(){} // RVA: 0x7ffaaef9cf40
        public void set_startTime(){} // RVA: 0x7ffaaf0964a0
        public void get_phase(){} // RVA: 0x7ffaa8c53430
        public void set_phase(){} // RVA: 0x7ffaaa0188e0
        public void get_valueData(){} // RVA: 0x7ffaaf0964b0
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaaf0964c0
        public void get_stateIndex(){} // RVA: 0x7ffaaa01a540
        public void set_stateIndex(){} // RVA: 0x7ffaaf0964d0
        public void get_controlIndex(){} // RVA: 0x7ffaab27f0a0
        public void set_controlIndex(){} // RVA: 0x7ffaaf096540
        public void get_bindingIndex(){} // RVA: 0x7ffaaf0965b0
        public void set_bindingIndex(){} // RVA: 0x7ffaaf0965c0
        public void get_interactionIndex(){} // RVA: 0x7ffaaf096630
        public void set_interactionIndex(){} // RVA: 0x7ffaaf096650
        public void ToEventPtr(){} // RVA: 0x7ffaa9f19100
        public void get_typeStatic(){} // RVA: 0x7ffaaf096490
        public void From(){} // RVA: 0x7ffaaf0966e0
        // ── Binary Analysis Named ──
        public void GetEventSizeWithValueSize(){} // RVA: 0x7ffaaf0966d0
    }

    public class DeltaStateEvent : ValueType
    {
        public object stateFormat; // 0x33ACF1A0
        public object FixedElementField; // 0x83E6B090

        // ── Original Methods ──
        public void get_deltaStateSizeInBytes(){} // RVA: 0x7ffaaf096810
        public void get_deltaState(){} // RVA: 0x7ffaaf096820
        public void get_typeStatic(){} // RVA: 0x7ffaaf096830
        public void ToEventPtr(){} // RVA: 0x7ffaa9f19100
        public void From(){} // RVA: 0x7ffaaf096970
        public void FromUnchecked(){} // RVA: 0x7ffaa9f19100
        public void From(){} // RVA: 0x7ffaaf096970
    }

    public class DeviceConfigurationEvent : ValueType
    {
        // ── Original Methods ──
        public void get_typeStatic(){} // RVA: 0x7ffaaf096cf0
        public void ToEventPtr(){} // RVA: 0x7ffaa9f19100
        public void Create(){} // RVA: 0x7ffaaf096d00
    }

    public class DeviceRemoveEvent : ValueType
    {
        // ── Original Methods ──
        public void get_typeStatic(){} // RVA: 0x7ffaaf096dd0
        public void ToEventPtr(){} // RVA: 0x7ffaa9f19100
        public void Create(){} // RVA: 0x7ffaaf096de0
    }

    public class DeviceResetEvent : ValueType
    {
        public object hardReset; // 0x3383C750
        public object typeStatic; // 0x17000496

        // ── Original Methods ──
        public void get_typeStatic(){} // RVA: 0x7ffaaf096eb0
        public void Create(){} // RVA: 0x7ffaaf096ec0
    }

    public class DisableDeviceCommand : ValueType
    {
        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf095120
        public void get_typeStatic(){} // RVA: 0x7ffaaf095120
        public void Create(){} // RVA: 0x7ffaaf095130
    }

    public class DualMotorRumbleCommand : ValueType
    {
        public object lowFrequencyMotorSpeed; // 0x33C7D930

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf095b50
        public void get_typeStatic(){} // RVA: 0x7ffaaf095b50
        public void Create(){} // RVA: 0x7ffaaf095b60
    }

    public class EnableDeviceCommand : ValueType
    {
        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf095150
        public void get_typeStatic(){} // RVA: 0x7ffaaf095150
        public void Create(){} // RVA: 0x7ffaaf095160
    }

    public class EnableIMECompositionCommand : ValueType
    {
        public object m_ImeEnabled; // 0x339B73A0
        public object Type; // 0x17000439

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf095180
        public void get_imeEnabled(){} // RVA: 0x7ffaaf095190
        public void get_typeStatic(){} // RVA: 0x7ffaaf095180
        public void Create(){} // RVA: 0x7ffaaf0951a0
    }

    public class ICustomDeviceReset
    {
        // ── Original Methods ──
        public void Reset(){} // RVA: 0x7ffaa8660cc0
    }

    public class IEventMerger
    {
        // ── Original Methods ──
        public void MergeForward(){}
    }

    public class IEventPreProcessor
    {
        // ── Original Methods ──
        public void PreProcessEvent(){} // RVA: 0x7ffaa864ab20
    }

    public class IInputDeviceCommandInfo
    {
        // ── Original Methods ──
        public void get_typeStatic(){}
    }

    public class IInputEventTypeInfo
    {
        // ── Original Methods ──
        public void get_typeStatic(){}
    }

    public class IInputRuntime
    {
        // ── Original Methods ──
        public void AllocateDeviceId(){} // RVA: 0x7ffaa8649ca0
        public void Update(){} // RVA: 0x7ffaa8661210
        public void QueueEvent(){} // RVA: 0x7ffaa887e5c0
        public void DeviceCommand(){} // RVA: 0x7ffaa887e5c0
        public void get_onUpdate(){} // RVA: 0x7ffaa86491d0
        public void set_onUpdate(){} // RVA: 0x7ffaa8660d80
        public void get_onBeforeUpdate(){} // RVA: 0x7ffaa86491d0
        public void set_onBeforeUpdate(){} // RVA: 0x7ffaa8660d80
        public void get_onShouldRunUpdate(){} // RVA: 0x7ffaa86491d0
        public void set_onShouldRunUpdate(){} // RVA: 0x7ffaa8660d80
        public void get_onDeviceDiscovered(){} // RVA: 0x7ffaa86491d0
        public void set_onDeviceDiscovered(){} // RVA: 0x7ffaa8660d80
        public void get_onPlayerFocusChanged(){} // RVA: 0x7ffaa86491d0
        public void set_onPlayerFocusChanged(){} // RVA: 0x7ffaa8660d80
        public void get_isPlayerFocused(){} // RVA: 0x7ffaa864a040
        public void get_onShutdown(){} // RVA: 0x7ffaa86491d0
        public void set_onShutdown(){} // RVA: 0x7ffaa8660d80
        public void get_pollingFrequency(){} // RVA: 0x7ffaa865dbc0
        public void set_pollingFrequency(){} // RVA: 0x7ffaa866e7c0
        public void get_currentTime(){} // RVA: 0x7ffaa864eea0
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x7ffaa864eea0
        public void get_unscaledGameTime(){} // RVA: 0x7ffaa865dbc0
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7ffaa864eea0
        public void get_runInBackground(){} // RVA: 0x7ffaa864a040
        public void set_runInBackground(){} // RVA: 0x7ffaa86613a0
        public void get_screenSize(){} // RVA: 0x7ffaa86491d0
        public void get_screenOrientation(){} // RVA: 0x7ffaa8649ca0
        public void get_isInBatchMode(){} // RVA: 0x7ffaa864a040
    }

    public class IInputStateCallbackReceiver
    {
        // ── Original Methods ──
        public void OnNextUpdate(){} // RVA: 0x7ffaa8660cc0
        public void OnStateEvent(){} // RVA: 0x7ffaa8660f30
        // ── Binary Analysis Named ──
        public void GetStateOffsetForEvent(){}
    }

    public class IInputStateChangeMonitor
    {
        // ── Original Methods ──
        public void NotifyControlStateChanged(){}
        public void NotifyTimerExpired(){}
    }

    public class IInputStateTypeInfo
    {
        // ── Original Methods ──
        public void get_format(){}
    }

    public class IInputUpdateCallbackReceiver
    {
        // ── Original Methods ──
        public void OnUpdate(){} // RVA: 0x7ffaa8660cc0
    }

    public class IMECompositionEvent : ValueType
    {
        public object baseEvent; // 0x33A77D70
        public object buffer; // 0x8191B400

        // ── Original Methods ──
        public void get_typeStatic(){} // RVA: 0x7ffaaf096fa0
        public void Create(){} // RVA: 0x7ffaaf096fb0
    }

    public class ITextInputReceiver
    {
        // ── Original Methods ──
        public void OnTextInput(){} // RVA: 0x7ffaa8660eb0
        public void OnIMECompositionChanged(){}
    }

    public class InitiateUserAccountPairingCommand : ValueType
    {
        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf0951d0
        public void get_typeStatic(){} // RVA: 0x7ffaaf0951d0
        public void Create(){} // RVA: 0x7ffaaf0951e0
    }

    public class InputDeviceCommand : ValueType
    {
        public object GenericFailure; // 0x334E95A0
        public object sizeInBytes; // 0x334E95A0
        public object Type; // 0x17000346
        public object typeStatic; // 0x17000347

        // ── Original Methods ──
        public void get_payloadSizeInBytes(){} // RVA: 0x7ffaaf095290
        public void get_payloadPtr(){} // RVA: 0x7ffaaf0952a0
        public void .ctor(){} // RVA: 0x7ffaa8e055a0
        public void AllocateNative(){} // RVA: 0x7ffaaf0952b0
        public void get_typeStatic(){} // RVA: 0x7ffaa8f22da0
    }

    public class InputDeviceCommandDelegate : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab6c5040
        public void Invoke(){} // RVA: 0x7ffaab6c2fb0
        public void EndInvoke(){} // RVA: 0x7ffaaa24b840
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaa94f9e30
    }

    public class InputEvent : ValueType
    {
        public object kBaseEventSize; // 0x3385F760
        public object m_Event; // 0x3385F760
        public object sizeInBytes; // 0x83E73370

        // ── Original Methods ──
        public void get_type(){} // RVA: 0x7ffaa9e47550
        public void set_type(){} // RVA: 0x7ffaa8d92880
        public void get_sizeInBytes(){} // RVA: 0x7ffaabb032c0
        public void set_sizeInBytes(){} // RVA: 0x7ffaaf097480
        public void get_eventId(){} // RVA: 0x7ffaaf097530
        public void set_eventId(){} // RVA: 0x7ffaaf097540
        public void get_deviceId(){} // RVA: 0x7ffaae48d520
        public void set_deviceId(){} // RVA: 0x7ffaaf097550
        public void get_time(){} // RVA: 0x7ffaaf097560
        public void set_time(){} // RVA: 0x7ffaaf0975b0
        public void get_internalTime(){} // RVA: 0x7ffaaa1d99d0
        public void set_internalTime(){} // RVA: 0x7ffaaa4b5770
        public void .ctor(){} // RVA: 0x7ffaaf097610
        public void get_handled(){} // RVA: 0x7ffaaf0976d0
        public void set_handled(){} // RVA: 0x7ffaaf0976e0
        public void ToString(){} // RVA: 0x7ffaaf097700
        public void Equals(){} // RVA: 0x7ffaaf097b70
        // ── Binary Analysis Named ──
        public void GetNextInMemory(){} // RVA: 0x7ffaaf097a00
        public void GetNextInMemoryChecked(){} // RVA: 0x7ffaaf097a20
    }

    public class InputEventBuffer : ValueType
    {
        public object m_SizeInBytes; // 0x33CD3430
        public object m_Buffer; // 0x317BCC80

        // ── Original Methods ──
        public void get_eventCount(){} // RVA: 0x7ffaa8b945a0
        public void get_sizeInBytes(){} // RVA: 0x7ffaa894d380
        public void get_capacityInBytes(){} // RVA: 0x7ffaaf097bc0
        public void get_data(){} // RVA: 0x7ffaa8ce3e60
        public void get_bufferPtr(){} // RVA: 0x7ffaaf097c10
        public void .ctor(){} // RVA: 0x7ffaaf097e20
        public void .ctor(){} // RVA: 0x7ffaaf097e20
        public void AppendEvent(){} // RVA: 0x7ffaaf097f50
        public void AllocateEvent(){} // RVA: 0x7ffaaf097fe0
        public void Contains(){} // RVA: 0x7ffaaf0982c0
        public void Reset(){} // RVA: 0x7ffaaf098330
        public void AdvanceToNextEvent(){} // RVA: 0x7ffaaf098350
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaf098500
        public void Dispose(){} // RVA: 0x7ffaaf098510
        public void Clone(){} // RVA: 0x7ffaaf098570
        public void System.ICloneable.Clone(){} // RVA: 0x7ffaaf098700
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaf098440
    }

    public class InputEventListener : ValueType
    {
        // ── Original Methods ──
        public void op_Addition(){} // RVA: 0x7ffaaf098870
        public void op_Subtraction(){} // RVA: 0x7ffaaf098ac0
        public void Subscribe(){} // RVA: 0x7ffaaf098d10
    }

    public class InputEventPtr : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9fe08a0
        public void get_valid(){} // RVA: 0x7ffaab7cf5a0
        public void get_handled(){} // RVA: 0x7ffaaf099410
        public void set_handled(){} // RVA: 0x7ffaaf099430
        public void get_id(){} // RVA: 0x7ffaaf0994b0
        public void set_id(){} // RVA: 0x7ffaaf0994d0
        public void get_type(){} // RVA: 0x7ffaaf099550
        public void get_sizeInBytes(){} // RVA: 0x7ffaaf099560
        public void get_deviceId(){} // RVA: 0x7ffaaf099580
        public void set_deviceId(){} // RVA: 0x7ffaaf0995a0
        public void get_time(){} // RVA: 0x7ffaaf099610
        public void set_time(){} // RVA: 0x7ffaaf099670
        public void get_internalTime(){} // RVA: 0x7ffaaf099720
        public void set_internalTime(){} // RVA: 0x7ffaaf099740
        public void get_data(){} // RVA: 0x7ffaa950bda0
        public void get_stateFormat(){} // RVA: 0x7ffaaf0997b0
        public void get_stateSizeInBytes(){} // RVA: 0x7ffaaf099860
        public void get_stateOffset(){} // RVA: 0x7ffaaf099990
        public void IsA(){} // RVA: 0x7ffaa864a040
        public void Next(){} // RVA: 0x7ffaaf099a80
        public void ToString(){} // RVA: 0x7ffaaf099aa0
        public void ToPointer(){} // RVA: 0x7ffaa950bda0
        public void Equals(){} // RVA: 0x7ffaaf099b60
        public void Equals(){} // RVA: 0x7ffaaf099b60
        public void op_Equality(){} // RVA: 0x7ffaaad0d3c0
        public void op_Inequality(){} // RVA: 0x7ffaae071d60
        public void op_Implicit(){} // RVA: 0x7ffaa9f19100
        public void From(){} // RVA: 0x7ffaa9f19100
        public void op_Implicit(){} // RVA: 0x7ffaa9f19100
        public void FromInputEventPtr(){} // RVA: 0x7ffaa9f19100
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa9e47550
    }

    public class InputEventStream : ValueType
    {
        public object m_CurrentNativeEventWritePtr; // 0x33915FD0
        public object m_AppendBuffer; // 0x33915FD0
        public object m_RemainingAppendEventCount; // 0x33915FD0
        public object BufferSizeUnknown; // 0x33CD3430
        public object m_EventCount; // 0x33CD3430

        // ── Original Methods ──
        public void get_isOpen(){} // RVA: 0x7ffaa89ae320
        public void get_remainingEventCount(){} // RVA: 0x7ffaaf099c20
        public void get_numEventsRetainedInBuffer(){} // RVA: 0x7ffaaa1c2a60
        public void get_currentEventPtr(){} // RVA: 0x7ffaaf099c30
        public void get_numBytesRetainedInBuffer(){} // RVA: 0x7ffaaf099c50
        public void .ctor(){} // RVA: 0x7ffaaf099c90
        public void Close(){} // RVA: 0x7ffaaf099d20
        public void CleanUpAfterException(){} // RVA: 0x7ffaaf099e90
        public void Write(){} // RVA: 0x7ffaaf099f40
        public void Advance(){} // RVA: 0x7ffaaf09a1c0
        public void Peek(){} // RVA: 0x7ffaaf09a260
    }

    public class InputEventTrace : Object
    {
        public object m_ChangeCounter; // 0x33736BE0
        public object m_DeviceId; // 0x33736BE0
        public object m_MaxEventBufferSize; // 0x33736BE0
        public object m_EventSizeInBytes; // 0x33736BE0
        public object m_EventBufferTailStorage; // 0x33736BE0
        public object m_DeviceInfos; // 0x33736BE0

        // ── Original Methods ──
        public void get_FrameMarkerEvent(){} // RVA: 0x7ffaaf09a2a0
        public void get_deviceId(){} // RVA: 0x7ffaa8aeced0
        public void set_deviceId(){} // RVA: 0x7ffaa900aa90
        public void get_enabled(){} // RVA: 0x7ffaa8a81bd0
        public void get_recordFrameMarkers(){} // RVA: 0x7ffaabc50470
        public void set_recordFrameMarkers(){} // RVA: 0x7ffaaf09a2b0
        public void get_eventCount(){} // RVA: 0x7ffaa8d1b980
        public void get_totalEventSizeInBytes(){} // RVA: 0x7ffaa8f75d20
        public void get_allocatedSizeInBytes(){} // RVA: 0x7ffaaf09a3a0
        public void get_maxSizeInBytes(){} // RVA: 0x7ffaa8d1a3b0
        public void get_deviceInfos(){} // RVA: 0x7ffaaf09a3c0
        public void get_onFilterEvent(){} // RVA: 0x7ffaa89357c0
        public void set_onFilterEvent(){} // RVA: 0x7ffaa8998e80
        public void add_onEvent(){} // RVA: 0x7ffaaf09a4a0
        public void remove_onEvent(){} // RVA: 0x7ffaaf09a4f0
        public void .ctor(){} // RVA: 0x7ffaaf09a600
        public void .ctor(){} // RVA: 0x7ffaaf09a600
        public void WriteTo(){} // RVA: 0x7ffaaf09a760
        public void WriteTo(){} // RVA: 0x7ffaaf09a760
        public void ReadFrom(){} // RVA: 0x7ffaaf09af50
        public void ReadFrom(){} // RVA: 0x7ffaaf09af50
        public void LoadFrom(){} // RVA: 0x7ffaaf09ba30
        public void LoadFrom(){} // RVA: 0x7ffaaf09ba30
        public void Replay(){} // RVA: 0x7ffaaf09bb70
        public void Resize(){} // RVA: 0x7ffaaf09bc60
        public void Clear(){} // RVA: 0x7ffaaf09bf20
        public void Enable(){} // RVA: 0x7ffaaf09bfa0
        public void Disable(){} // RVA: 0x7ffaaf09c120
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaf09c2a0
        public void Dispose(){} // RVA: 0x7ffaaf09c340
        public void get_m_EventBuffer(){} // RVA: 0x7ffaa8f78170
        public void set_m_EventBuffer(){} // RVA: 0x7ffaae1aeb60
        public void get_m_EventBufferHead(){} // RVA: 0x7ffaa8f74720
        public void set_m_EventBufferHead(){} // RVA: 0x7ffaa9fee770
        public void get_m_EventBufferTail(){} // RVA: 0x7ffaa899d040
        public void set_m_EventBufferTail(){} // RVA: 0x7ffaa9feeaa0
        public void Allocate(){} // RVA: 0x7ffaaf09c440
        public void Release(){} // RVA: 0x7ffaaf09c4b0
        public void OnBeforeUpdate(){} // RVA: 0x7ffaaf09c5b0
        public void OnInputEvent(){} // RVA: 0x7ffaaf09c6b0
        public void get_kFileFormat(){} // RVA: 0x7ffaaf09ccc0
        public void .cctor(){} // RVA: 0x7ffaaf09ccd0
        // ── Binary Analysis Named ──
        public void GetNextEvent(){} // RVA: 0x7ffaaf09c220
        public void GetEnumerator(){} // RVA: 0x7ffaaf09c2a0
    }

    public class InputMetrics : ValueType
    {
        public object _maxStateSizeInBytes; // 0x33A4F930, was: <maxStateSizeInBytes>k__Backin
        public object _currentLayoutCount; // 0x33A4F930, was: <currentLayoutCount>k__Backing
        public object _totalUpdateCount; // 0x33A4F930, was: <totalUpdateCount>k__BackingFi
        public object j; // 0x3024ED20

        // ── Original Methods ──
        public void get_maxNumDevices(){} // RVA: 0x7ffaa9e47550
        public void set_maxNumDevices(){} // RVA: 0x7ffaa8d92880
        public void get_currentNumDevices(){} // RVA: 0x7ffaa9e47530
        public void set_currentNumDevices(){} // RVA: 0x7ffaa9e475c0
        public void get_maxStateSizeInBytes(){} // RVA: 0x7ffaaa3cef80
        public void set_maxStateSizeInBytes(){} // RVA: 0x7ffaaa3cef90
        public void get_currentStateSizeInBytes(){} // RVA: 0x7ffaaa3cefa0
        public void set_currentStateSizeInBytes(){} // RVA: 0x7ffaaa3cefb0
        public void get_currentControlCount(){} // RVA: 0x7ffaa897f5c0
        public void set_currentControlCount(){} // RVA: 0x7ffaa89350c0
        public void get_currentLayoutCount(){} // RVA: 0x7ffaa8e046c0
        public void set_currentLayoutCount(){} // RVA: 0x7ffaa8e03640
        public void get_totalEventBytes(){} // RVA: 0x7ffaa8b945a0
        public void set_totalEventBytes(){} // RVA: 0x7ffaa9357830
        public void get_totalEventCount(){} // RVA: 0x7ffaa9e5ac10
        public void set_totalEventCount(){} // RVA: 0x7ffaa9e6a2e0
        public void get_totalUpdateCount(){} // RVA: 0x7ffaa8aeced0
        public void set_totalUpdateCount(){} // RVA: 0x7ffaa900aa90
        public void get_totalEventProcessingTime(){} // RVA: 0x7ffaaf09f730
        public void set_totalEventProcessingTime(){} // RVA: 0x7ffaaf09f740
        public void get_totalEventLagTime(){} // RVA: 0x7ffaaf09f750
        public void set_totalEventLagTime(){} // RVA: 0x7ffaaf09f760
        public void get_averageEventBytesPerFrame(){} // RVA: 0x7ffaaf09f770
        public void get_averageProcessingTimePerEvent(){} // RVA: 0x7ffaaf09f790
        public void get_averageLagTimePerEvent(){} // RVA: 0x7ffaaf09f7b0
    }

    public class InputRuntime : Object
    {
    }

    public class InputRuntimeExtensions : Object
    {
        // ── Original Methods ──
        public void DeviceCommand(){}
    }

    public class InputState : Object
    {
        // ── Original Methods ──
        public void get_currentUpdateType(){} // RVA: 0x7ffaaf0a1500
        public void get_updateCount(){} // RVA: 0x7ffaaf0a1540
        public void get_currentTime(){} // RVA: 0x7ffaaf0a1580
        public void add_onChange(){} // RVA: 0x7ffaaf0a1600
        public void remove_onChange(){} // RVA: 0x7ffaaf0a16b0
        public void Change(){} // RVA: 0x7ffaa887e5c0
        public void Change(){} // RVA: 0x7ffaa887e5c0
        public void Change(){} // RVA: 0x7ffaa887e5c0
        public void IsIntegerFormat(){} // RVA: 0x7ffaaf0a1a50
        public void AddChangeMonitor(){} // RVA: 0x7ffaaf0a1da0
        public void AddChangeMonitor(){} // RVA: 0x7ffaaf0a1da0
        public void RemoveChangeMonitor(){} // RVA: 0x7ffaaf0a1f30
        public void AddChangeMonitorTimeout(){} // RVA: 0x7ffaaf0a2070
        public void RemoveChangeMonitorTimeout(){} // RVA: 0x7ffaaf0a2180
    }

    public class InputStateBlock : ValueType
    {
        public object FormatInvalid; // 0x33C7ED20
        public object kFormatBit; // 0x33C7ED20
        public object FormatInt; // 0x33C7ED20
        public object kFormatUInt; // 0x33C7ED20
        public object FormatUShort; // 0x33C7ED20
        public object kFormatByte; // 0x33C7ED20
        public object FormatLong; // 0x33C7ED20
        public object kFormatULong; // 0x33C7ED20
        public object FormatDouble; // 0x33C7ED20
        public object kFormatVector2; // 0x33C7ED20
        public object FormatQuaternion; // 0x33C7ED20
        public object FormatVector3Short; // 0x33C7ED20
        public object FormatPose; // 0x33C7ED20
        public object m_ByteOffset; // 0x33C7ED20
        public object m_Code; // 0x33D046C0
        public object m_Type; // 0x317BA050
        public object m_ByteValue; // 0x317BA050
        public object m_UShortValue; // 0x317BA050
        public object m_LongValue; // 0x317BA050
        public object m_DoubleValue; // 0x317BA050
        public object kInvalidDeviceIndex; // 0x317BB110
        public object m_ParticipantId; // 0x317BB110

        // ── Original Methods ──
        public void get_format(){} // RVA: 0x7ffaa9e47550
        public void set_format(){} // RVA: 0x7ffaa8d92880
        public void get_byteOffset(){} // RVA: 0x7ffaa9e47530
        public void set_byteOffset(){} // RVA: 0x7ffaa9e475c0
        public void get_bitOffset(){} // RVA: 0x7ffaaa3cef80
        public void set_bitOffset(){} // RVA: 0x7ffaaa3cef90
        public void get_sizeInBits(){} // RVA: 0x7ffaaa3cefa0
        public void set_sizeInBits(){} // RVA: 0x7ffaaa3cefb0
        public void get_alignedSizeInBytes(){} // RVA: 0x7ffaaf0a2c90
        public void get_effectiveByteOffset(){} // RVA: 0x7ffaaf0a2ce0
        public void get_effectiveBitOffset(){} // RVA: 0x7ffaaf0a2d30
        public void ReadInt(){} // RVA: 0x7ffaaf0a2d80
        public void WriteInt(){} // RVA: 0x7ffaaf0a3070
        public void ReadFloat(){} // RVA: 0x7ffaaf0a32f0
        public void WriteFloat(){} // RVA: 0x7ffaaf0a36d0
        public void FloatToPrimitiveValue(){} // RVA: 0x7ffaaf0a3a50
        public void ReadDouble(){} // RVA: 0x7ffaaf0a3e10
        public void WriteDouble(){} // RVA: 0x7ffaaf0a4210
        public void Write(){} // RVA: 0x7ffaaf0a45b0
        public void CopyToFrom(){} // RVA: 0x7ffaaf0a48c0
        public void .cctor(){} // RVA: 0x7ffaaf0a4a20
        // ── Binary Analysis Named ──
        public void GetSizeOfPrimitiveFormatInBits(){} // RVA: 0x7ffaaf0a22c0
        public void GetPrimitiveFormatFromType(){} // RVA: 0x7ffaaf0a2610
    }

    public class InputStateBuffers : ValueType
    {
        public object defaultStateBuffer; // 0x3379FB50
        public object m_AllBuffers; // 0x3379FB50
        public object s_NoiseMaskBuffer; // 0x3379FB50
        public object deviceToBufferMapping; // 0x33B3C9D0

        // ── Original Methods ──
        public void SwitchTo(){} // RVA: 0x7ffaaf0a4db0
        public void AllocateAll(){} // RVA: 0x7ffaaf0a4e20
        public void FreeAll(){} // RVA: 0x7ffaaf0a5030
        public void MigrateAll(){} // RVA: 0x7ffaaf0a5150
        public void MigrateDoubleBuffer(){} // RVA: 0x7ffaaf0a5310
        public void MigrateSingleBuffer(){} // RVA: 0x7ffaaf0a54e0
        public void ComputeSizeOfSingleStateBuffer(){} // RVA: 0x7ffaaf0a5610
        public void NextDeviceOffset(){} // RVA: 0x7ffaaf0a5790
        // ── Binary Analysis Named ──
        public void GetDoubleBuffersFor(){} // RVA: 0x7ffaaf0a4c10
        public void GetFrontBufferForDevice(){} // RVA: 0x7ffaaf0a4cf0
        public void GetBackBufferForDevice(){} // RVA: 0x7ffaaf0a4d50
        public void SetUpDeviceToBufferMappings(){} // RVA: 0x7ffaaf0a4fa0
    }

    public class InputStateHistory : Object
    {
        public object _onShouldRecordStateChange; // 0x30F3F860, was: <onShouldRecordStateChange>k__
        public object m_RecordBuffer; // 0x30F3F860
        public object m_HistoryDepth; // 0x30F3F860
        public object m_CurrentVersion; // 0x30F3F860
        public object Z; // 0x3024ED20

        // ── Original Methods ──
        public void get_Count(){} // RVA: 0x7ffaa89d30a0
        public void get_version(){} // RVA: 0x7ffaa92bf840
        public void get_historyDepth(){} // RVA: 0x7ffaa89d30c0
        public void set_historyDepth(){} // RVA: 0x7ffaaf0a5990
        public void get_extraMemoryPerRecord(){} // RVA: 0x7ffaa99531a0
        public void set_extraMemoryPerRecord(){} // RVA: 0x7ffaaf0a5a70
        public void get_updateMask(){} // RVA: 0x7ffaaf0a5b50
        public void set_updateMask(){} // RVA: 0x7ffaaf0a5c00
        public void get_controls(){} // RVA: 0x7ffaaf0a5cc0
        public void get_Item(){} // RVA: 0x7ffaaf0a5d70
        public void set_Item(){} // RVA: 0x7ffaaf0a5ef0
        public void get_onRecordAdded(){} // RVA: 0x7ffaa894d380
        public void set_onRecordAdded(){} // RVA: 0x7ffaa8933e30
        public void get_onShouldRecordStateChange(){} // RVA: 0x7ffaa89357c0
        public void set_onShouldRecordStateChange(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaaf0a6470
        public void .ctor(){} // RVA: 0x7ffaaf0a6470
        public void .ctor(){} // RVA: 0x7ffaaf0a6470
        public void .ctor(){} // RVA: 0x7ffaaf0a6470
        public void Finalize(){} // RVA: 0x7ffaaf0a6580
        public void Clear(){} // RVA: 0x7ffaaf0a65c0
        public void AddRecord(){} // RVA: 0x7ffaaf0a65d0
        public void StartRecording(){} // RVA: 0x7ffaaf0a66a0
        public void StopRecording(){} // RVA: 0x7ffaaf0a6860
        public void RecordStateChange(){} // RVA: 0x7ffaaf0a6d80
        public void RecordStateChange(){} // RVA: 0x7ffaaf0a6d80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaf0a7200
        public void Dispose(){} // RVA: 0x7ffaaf0a72b0
        public void Destroy(){} // RVA: 0x7ffaaf0a7360
        public void Allocate(){} // RVA: 0x7ffaaf0a73c0
        public void RecordIndexToUserIndex(){} // RVA: 0x7ffaaf0a7750
        public void UserIndexToRecordIndex(){} // RVA: 0x7ffaaf0a7770
        public void AllocateRecord(){} // RVA: 0x7ffaaf0a7900
        public void ReadValue(){} // RVA: 0x7ffaa887e5c0
        public void ReadValueAsObject(){} // RVA: 0x7ffaaf0a79d0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7ffaaf0a7ba0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7ffaa8932310
        public void get_bytesPerRecord(){} // RVA: 0x7ffaaf0a7d10
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaf0a7200
        public void GetRecord(){} // RVA: 0x7ffaaf0a7780
        public void GetRecordUnchecked(){} // RVA: 0x7ffaaf0a7870
    }

    public class InputStateHistory`1 : InputStateHistory
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void Finalize(){} // RVA: 0x7ffaa8660cc0
        public void AddRecord(){} // RVA: 0x7ffaa887e5c0
        public void RecordStateChange(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void get_Item(){} // RVA: 0x7ffaa887e5c0
        public void set_Item(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa86491d0
    }

    public class InputUpdate : Object
    {
        public object s_PlayerUpdateStepCount; // 0x33BEEFA0

        // ── Original Methods ──
        public void OnBeforeUpdate(){} // RVA: 0x7ffaaf09f7d0
        public void OnUpdate(){} // RVA: 0x7ffaaf09f850
        public void Save(){} // RVA: 0x7ffaaf09f8d0
        public void Restore(){} // RVA: 0x7ffaaf09f920
        public void IsPlayerUpdate(){} // RVA: 0x7ffaaf09f9e0
        // ── Binary Analysis Named ──
        public void GetUpdateTypeForPlayer(){} // RVA: 0x7ffaaf09f9c0
    }

    public class InputUpdateDelegate : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8a8e2a0
        public void Invoke(){} // RVA: 0x7ffaa8a8e370
        public void EndInvoke(){} // RVA: 0x7ffaaa403b40
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaaf09f680
    }

    public class NativeInputRuntime : Object
    {
        public object m_ShutdownMethod; // 0x3372E770
        public object m_OnShouldRunUpdate; // 0x3372E770
        public object m_FocusChangedMethod; // 0x3372E770
        public object onUpdate; // 0x170004F8
        public object onBeforeUpdate; // 0x170004F9
        public object onShouldRunUpdate; // 0x170004FA

        // ── Original Methods ──
        public void AllocateDeviceId(){} // RVA: 0x7ffaaf09fa10
        public void Update(){} // RVA: 0x7ffaaf09fa90
        public void QueueEvent(){} // RVA: 0x7ffaaf09fb20
        public void DeviceCommand(){} // RVA: 0x7ffaaf09fbb0
        public void get_onUpdate(){} // RVA: 0x7ffaa89600c0
        public void set_onUpdate(){} // RVA: 0x7ffaaf09fcc0
        public void get_onBeforeUpdate(){} // RVA: 0x7ffaa8960130
        public void set_onBeforeUpdate(){} // RVA: 0x7ffaaf0a0020
        public void get_onShouldRunUpdate(){} // RVA: 0x7ffaa8bfcc80
        public void set_onShouldRunUpdate(){} // RVA: 0x7ffaaf0a02e0
        public void get_onDeviceDiscovered(){} // RVA: 0x7ffaaf0a05a0
        public void set_onDeviceDiscovered(){} // RVA: 0x7ffaaf0a0640
        public void get_onShutdown(){} // RVA: 0x7ffaa89357c0
        public void set_onShutdown(){} // RVA: 0x7ffaaf0a0780
        public void get_onPlayerFocusChanged(){} // RVA: 0x7ffaa89af740
        public void set_onPlayerFocusChanged(){} // RVA: 0x7ffaaf0a08d0
        public void get_isPlayerFocused(){} // RVA: 0x7ffaaf0a0cd0
        public void get_pollingFrequency(){} // RVA: 0x7ffaa9144a40
        public void set_pollingFrequency(){} // RVA: 0x7ffaaf0a0d50
        public void get_currentTime(){} // RVA: 0x7ffaaf0a0df0
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x7ffaaf0a0e70
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7ffaaf0a0f50
        public void get_unscaledGameTime(){} // RVA: 0x7ffaaf0a0fd0
        public void get_runInBackground(){} // RVA: 0x7ffaaf0a1020
        public void set_runInBackground(){} // RVA: 0x7ffaa89fc5f0
        public void OnShutdown(){} // RVA: 0x7ffaac0ad2d0
        public void OnWantsToShutdown(){} // RVA: 0x7ffaaf0a10b0
        public void OnFocusChanged(){} // RVA: 0x7ffaae3a1fb0
        public void get_screenSize(){} // RVA: 0x7ffaaf0a10f0
        public void get_screenOrientation(){} // RVA: 0x7ffaaf0a11a0
        public void get_isInBatchMode(){} // RVA: 0x7ffaaf0a11f0
        public void .ctor(){} // RVA: 0x7ffaaf0a1270
        public void .cctor(){} // RVA: 0x7ffaaf0a1280
    }

    public class QueryCanRunInBackground : ValueType
    {
        public object canRunInBackground; // 0x339BF200
        public object Type; // 0x17000442

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf095400
        public void get_typeStatic(){} // RVA: 0x7ffaaf095400
        public void Create(){} // RVA: 0x7ffaaf095410
    }

    public class QueryDimensionsCommand : ValueType
    {
        public object outDimensions; // 0x337E6490
        public object Type; // 0x17000444

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf095430
        public void get_typeStatic(){} // RVA: 0x7ffaaf095430
        public void Create(){} // RVA: 0x7ffaaf095440
    }

    public class QueryEnabledStateCommand : ValueType
    {
        public object isEnabled; // 0x338175D0
        public object Type; // 0x17000446

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf095470
        public void get_typeStatic(){} // RVA: 0x7ffaaf095470
        public void Create(){} // RVA: 0x7ffaaf095480
    }

    public class QueryKeyNameCommand : ValueType
    {
        public object baseCommand; // 0x336D41B0

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf095550
        public void ReadKeyName(){} // RVA: 0x7ffaaf095560
        public void get_typeStatic(){} // RVA: 0x7ffaaf095550
        public void Create(){} // RVA: 0x7ffaaf095580
    }

    public class QueryKeyboardLayoutCommand : ValueType
    {
        public object nameBuffer; // 0x3376D9A0
        public object Type; // 0x17000448

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf0954a0
        public void ReadLayoutName(){} // RVA: 0x7ffaaf0954b0
        public void WriteLayoutName(){} // RVA: 0x7ffaaf0954d0
        public void get_typeStatic(){} // RVA: 0x7ffaaf0954a0
        public void Create(){} // RVA: 0x7ffaaf095510
    }

    public class QueryPairedUserAccountCommand : ValueType
    {
        public object kSize; // 0x33737AE0
        public object nameBuffer; // 0x33737AE0

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf0955d0
        public void get_id(){} // RVA: 0x7ffaaf0955e0
        public void set_id(){} // RVA: 0x7ffaaf095600
        public void get_name(){} // RVA: 0x7ffaaf095730
        public void set_name(){} // RVA: 0x7ffaaf095750
        public void get_typeStatic(){} // RVA: 0x7ffaaf0955d0
        public void Create(){} // RVA: 0x7ffaaf095880
    }

    public class QuerySamplingFrequencyCommand : ValueType
    {
        public object frequency; // 0x3345D6C0
        public object Type; // 0x17000450

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf0958c0
        public void get_typeStatic(){} // RVA: 0x7ffaaf0958c0
        public void Create(){} // RVA: 0x7ffaaf0958d0
    }

    public class QueryUserIdCommand : ValueType
    {
        public object baseCommand; // 0x33814030

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf095900
        public void ReadId(){} // RVA: 0x7ffaaf0954b0
        public void get_typeStatic(){} // RVA: 0x7ffaaf095900
        public void Create(){} // RVA: 0x7ffaaf095910
    }

    public class RequestResetCommand : ValueType
    {
        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf095950
        public void get_typeStatic(){} // RVA: 0x7ffaaf095950
        public void Create(){} // RVA: 0x7ffaaf095960
    }

    public class RequestSyncCommand : ValueType
    {
        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf095980
        public void get_typeStatic(){} // RVA: 0x7ffaaf095980
        public void Create(){} // RVA: 0x7ffaaf095990
    }

    public class SelectObservable`2 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8669e70
        public void Subscribe(){} // RVA: 0x7ffaa8649280
    }

    public class SetIMECursorPositionCommand : ValueType
    {
        public object m_Position; // 0x3358B630
        public object Type; // 0x17000458

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf0959b0
        public void get_position(){} // RVA: 0x7ffaabb06e10
        public void get_typeStatic(){} // RVA: 0x7ffaaf0959b0
        public void Create(){} // RVA: 0x7ffaaf0959c0
    }

    public class SetSamplingFrequencyCommand : ValueType
    {
        public object frequency; // 0x33610660
        public object Type; // 0x1700045B

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf0959e0
        public void get_typeStatic(){} // RVA: 0x7ffaaf0959e0
        public void Create(){} // RVA: 0x7ffaaf0959f0
    }

    public class StateEvent : ValueType
    {
        public object baseEvent; // 0x318A9A60
        public object kHandledMask; // 0x3385F760

        // ── Original Methods ──
        public void get_stateSizeInBytes(){} // RVA: 0x7ffaaf09ee90
        public void get_state(){} // RVA: 0x7ffaaf09eea0
        public void ToEventPtr(){} // RVA: 0x7ffaa9f19100
        public void get_typeStatic(){} // RVA: 0x7ffaaf09eeb0
        public void From(){} // RVA: 0x7ffaaf09f050
        public void FromUnchecked(){} // RVA: 0x7ffaa9f19100
        public void From(){} // RVA: 0x7ffaaf09f050
        public void FromDefaultStateFor(){} // RVA: 0x7ffaaf09f020
        public void From(){} // RVA: 0x7ffaaf09f050
        // ── Binary Analysis Named ──
        public void GetState(){} // RVA: 0x7ffaa887e5c0
        public void GetState(){} // RVA: 0x7ffaa887e5c0
        public void GetEventSizeWithPayload(){} // RVA: 0x7ffaa8649cd0
    }

    public class TextEvent : ValueType
    {
        public object character; // 0x33BEC1C0
        public object typeStatic; // 0x170004D8

        // ── Original Methods ──
        public void get_typeStatic(){} // RVA: 0x7ffaaf09f380
        public void From(){} // RVA: 0x7ffaaf09f390
        public void Create(){} // RVA: 0x7ffaaf09f5a0
        public void Create(){} // RVA: 0x7ffaaf09f5a0
    }

    public class TouchState : ValueType
    {
        public object position; // 0x33BBF950
        public object radius; // 0x33BBF950
        public object displayIndex; // 0x33BBF950
        public object startTime; // 0x33BBF950

        // ── Original Methods ──
        public void get_Format(){} // RVA: 0x7ffaaf095f20
        public void get_phase(){} // RVA: 0x7ffaa8a209d0
        public void set_phase(){} // RVA: 0x7ffaa8a209e0
        public void get_isNoneEndedOrCanceled(){} // RVA: 0x7ffaaf095f30
        public void get_isInProgress(){} // RVA: 0x7ffaaf095f50
        public void get_isPrimaryTouch(){} // RVA: 0x7ffaaf095f70
        public void set_isPrimaryTouch(){} // RVA: 0x7ffaaf095f80
        public void get_isOrphanedPrimaryTouch(){} // RVA: 0x7ffaaf095fb0
        public void set_isOrphanedPrimaryTouch(){} // RVA: 0x7ffaaf095fc0
        public void get_isIndirectTouch(){} // RVA: 0x7ffaaf095ff0
        public void set_isIndirectTouch(){} // RVA: 0x7ffaaf096000
        public void get_isTap(){} // RVA: 0x7ffaaf096030
        public void set_isTap(){} // RVA: 0x7ffaaf096040
        public void get_isTapPress(){} // RVA: 0x7ffaaf096030
        public void set_isTapPress(){} // RVA: 0x7ffaaf096040
        public void get_isTapRelease(){} // RVA: 0x7ffaaf096070
        public void set_isTapRelease(){} // RVA: 0x7ffaaf096080
        public void get_beganInSameFrame(){} // RVA: 0x7ffaaf0960b0
        public void set_beganInSameFrame(){} // RVA: 0x7ffaaf0960c0
        public void get_format(){} // RVA: 0x7ffaaf095f20
        public void ToString(){} // RVA: 0x7ffaaf0960f0
    }

    public class WarpMousePositionCommand : ValueType
    {
        public object warpPositionInPlayerDisplaySpace; // 0x33C84580
        public object Type; // 0x1700045D

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf095a20
        public void get_typeStatic(){} // RVA: 0x7ffaaf095a20
        public void Create(){} // RVA: 0x7ffaaf095a30
    }

}