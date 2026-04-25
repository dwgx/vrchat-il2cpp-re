// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
// Classes: 58
// Methods: 484

namespace ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
{
    public class ActionEvent : ValueType
    {
        public object Type;
        public object startTime;
        public object phase;
        public object valueData;
        public object valueSizeInBytes;
        public object stateIndex;
        public object controlIndex;
        public object bindingIndex;
        public object interactionIndex;
        public object typeStatic;

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
        public object deltaStateSizeInBytes;
        public object deltaState;
        public object typeStatic;

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
        public object typeStatic;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFD54A94D10
        public void ToEventPtr(){} // RVA: 0x7FFD4F9181E0
        public void Create(){} // RVA: 0x7FFD54A94D20
    }

    public class DeviceRemoveEvent : ValueType
    {
        public object typeStatic;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFD54A94DF0
        public void ToEventPtr(){} // RVA: 0x7FFD4F9181E0
        public void Create(){} // RVA: 0x7FFD54A94E00
    }

    public class DeviceResetEvent : ValueType
    {
        public object typeStatic;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFD54A94ED0
        public void Create(){} // RVA: 0x7FFD54A94EE0
    }

    public class DisableDeviceCommand : ValueType
    {
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93140
        public void get_typeStatic(){} // RVA: 0x7FFD54A93140
        public void Create(){} // RVA: 0x7FFD54A93150
    }

    public class DualMotorRumbleCommand : ValueType
    {
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93B70
        public void get_typeStatic(){} // RVA: 0x7FFD54A93B70
        public void Create(){} // RVA: 0x7FFD54A93B80
    }

    public class EnableDeviceCommand : ValueType
    {
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93170
        public void get_typeStatic(){} // RVA: 0x7FFD54A93170
        public void Create(){} // RVA: 0x7FFD54A93180
    }

    public class EnableIMECompositionCommand : ValueType
    {
        public object Type;
        public object imeEnabled;
        public object typeStatic;

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
        public object typeStatic;

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
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A931F0
        public void get_typeStatic(){} // RVA: 0x7FFD54A931F0
        public void Create(){} // RVA: 0x7FFD54A93200
    }

    public class InputDeviceCommand : ValueType
    {
        public object payloadSizeInBytes;
        public object payloadPtr;
        public object typeStatic;

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
        public object type;
        public object sizeInBytes;
        public object eventId;
        public object deviceId;
        public object time;
        public object internalTime;
        public object handled;

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
        public object eventCount;
        public object sizeInBytes;
        public object capacityInBytes;
        public object data;
        public object bufferPtr;

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
        // ── Methods ──
        public void op_Addition(){} // RVA: 0x7FFD54A96890
        public void op_Subtraction(){} // RVA: 0x7FFD54A96AE0
        public void Subscribe(){} // RVA: 0x7FFD54A96D30
    }

    public class InputEventPtr : ValueType
    {
        public object valid;
        public object handled;
        public object id;
        public object type;
        public object sizeInBytes;
        public object deviceId;
        public object time;
        public object internalTime;
        public object data;
        public object stateFormat;
        public object stateSizeInBytes;
        public object stateOffset;

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
        public object isOpen;
        public object remainingEventCount;
        public object numEventsRetainedInBuffer;
        public object currentEventPtr;
        public object numBytesRetainedInBuffer;

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
        public object FrameMarkerEvent;
        public object deviceId;
        public object enabled;
        public object recordFrameMarkers;
        public object eventCount;
        public object totalEventSizeInBytes;
        public object allocatedSizeInBytes;
        public object maxSizeInBytes;
        public object deviceInfos;
        public object onFilterEvent;
        public object m_EventBuffer;
        public object m_EventBufferHead;
        public object m_EventBufferTail;
        public object kFileFormat;

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
        public object maxNumDevices;
        public object currentNumDevices;
        public object maxStateSizeInBytes;
        public object currentStateSizeInBytes;
        public object currentControlCount;
        public object currentLayoutCount;
        public object totalEventBytes;
        public object totalEventCount;
        public object totalUpdateCount;
        public object totalEventProcessingTime;
        public object totalEventLagTime;
        public object averageEventBytesPerFrame;
        public object averageProcessingTimePerEvent;
        public object averageLagTimePerEvent;

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
        public object format;
        public object byteOffset;
        public object bitOffset;
        public object sizeInBits;
        public object alignedSizeInBytes;
        public object effectiveByteOffset;
        public object effectiveBitOffset;

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
        public object Count;
        public object version;
        public object historyDepth;
        public object extraMemoryPerRecord;
        public object updateMask;
        public object controls;
        public object Item;
        public object onRecordAdded;
        public object onShouldRecordStateChange;
        public object bytesPerRecord;

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
        public object onUpdate;
        public object onBeforeUpdate;
        public object onShouldRunUpdate;
        public object onDeviceDiscovered;
        public object onShutdown;
        public object onPlayerFocusChanged;
        public object isPlayerFocused;
        public object pollingFrequency;
        public object currentTime;
        public object currentTimeForFixedUpdate;
        public object currentTimeOffsetToRealtimeSinceStartup;
        public object unscaledGameTime;
        public object runInBackground;
        public object screenSize;
        public object screenOrientation;
        public object isInBatchMode;

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
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93420
        public void get_typeStatic(){} // RVA: 0x7FFD54A93420
        public void Create(){} // RVA: 0x7FFD54A93430
    }

    public class QueryDimensionsCommand : ValueType
    {
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93450
        public void get_typeStatic(){} // RVA: 0x7FFD54A93450
        public void Create(){} // RVA: 0x7FFD54A93460
    }

    public class QueryEnabledStateCommand : ValueType
    {
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93490
        public void get_typeStatic(){} // RVA: 0x7FFD54A93490
        public void Create(){} // RVA: 0x7FFD54A934A0
    }

    public class QueryKeyNameCommand : ValueType
    {
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93570
        public void ReadKeyName(){} // RVA: 0x7FFD54A93580
        public void get_typeStatic(){} // RVA: 0x7FFD54A93570
        public void Create(){} // RVA: 0x7FFD54A935A0
    }

    public class QueryKeyboardLayoutCommand : ValueType
    {
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A934C0
        public void ReadLayoutName(){} // RVA: 0x7FFD54A934D0
        public void WriteLayoutName(){} // RVA: 0x7FFD54A934F0
        public void get_typeStatic(){} // RVA: 0x7FFD54A934C0
        public void Create(){} // RVA: 0x7FFD54A93530
    }

    public class QueryPairedUserAccountCommand : ValueType
    {
        public object Type;
        public object id;
        public object name;
        public object typeStatic;

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
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A938E0
        public void get_typeStatic(){} // RVA: 0x7FFD54A938E0
        public void Create(){} // RVA: 0x7FFD54A938F0
    }

    public class QueryUserIdCommand : ValueType
    {
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93920
        public void ReadId(){} // RVA: 0x7FFD54A934D0
        public void get_typeStatic(){} // RVA: 0x7FFD54A93920
        public void Create(){} // RVA: 0x7FFD54A93930
    }

    public class RequestResetCommand : ValueType
    {
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93970
        public void get_typeStatic(){} // RVA: 0x7FFD54A93970
        public void Create(){} // RVA: 0x7FFD54A93980
    }

    public class RequestSyncCommand : ValueType
    {
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A939A0
        public void get_typeStatic(){} // RVA: 0x7FFD54A939A0
        public void Create(){} // RVA: 0x7FFD54A939B0
    }

    public class SelectObservable`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void Subscribe(){} // RVA: 0x7FFD4E078F40
    }

    public class SetIMECursorPositionCommand : ValueType
    {
        public object Type;
        public object position;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A939D0
        public void get_position(){} // RVA: 0x7FFD51515860
        public void get_typeStatic(){} // RVA: 0x7FFD54A939D0
        public void Create(){} // RVA: 0x7FFD54A939E0
    }

    public class SetSamplingFrequencyCommand : ValueType
    {
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93A00
        public void get_typeStatic(){} // RVA: 0x7FFD54A93A00
        public void Create(){} // RVA: 0x7FFD54A93A10
    }

    public class StateEvent : ValueType
    {
        public object stateSizeInBytes;
        public object state;
        public object typeStatic;

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
        public object typeStatic;

        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFD54A9D3A0
        public void From(){} // RVA: 0x7FFD54A9D3B0
        public void Create(){} // RVA: 0x7FFD54A9D5C0 | overloaded x2
    }

    public class TouchState : ValueType
    {
        public object Format;
        public object phase;
        public object isNoneEndedOrCanceled;
        public object isInProgress;
        public object isPrimaryTouch;
        public object isOrphanedPrimaryTouch;
        public object isIndirectTouch;
        public object isTap;
        public object isTapPress;
        public object isTapRelease;
        public object beganInSameFrame;
        public object format;

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
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A93A40
        public void get_typeStatic(){} // RVA: 0x7FFD54A93A40
        public void Create(){} // RVA: 0x7FFD54A93A50
    }

}