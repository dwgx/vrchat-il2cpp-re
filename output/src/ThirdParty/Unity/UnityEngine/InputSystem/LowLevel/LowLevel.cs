// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
// Classes: 73
// Methods: 530

namespace ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
{
    public class AccelerometerState
    {
        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFAF998B7C0
        public void get_format(){} // RVA: 0x7FFAF998B7C0
    }

    public class ActionEvent
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998BD80
        public void get_startTime(){} // RVA: 0x7FFAF9892810
        public void set_startTime(){} // RVA: 0x7FFAF998BD90
        public void get_phase(){} // RVA: 0x7FFAF31690C0
        public void set_phase(){} // RVA: 0x7FFAF4648350
        public void get_valueData(){} // RVA: 0x7FFAF998BDA0
        public void get_valueSizeInBytes(){} // RVA: 0x7FFAF998BDB0
        public void get_stateIndex(){} // RVA: 0x7FFAF4648340
        public void set_stateIndex(){} // RVA: 0x7FFAF998BDC0
        public void get_controlIndex(){} // RVA: 0x7FFAF5992FD0
        public void set_controlIndex(){} // RVA: 0x7FFAF998BE30
        public void get_bindingIndex(){} // RVA: 0x7FFAF998BEA0
        public void set_bindingIndex(){} // RVA: 0x7FFAF998BEB0
        public void get_interactionIndex(){} // RVA: 0x7FFAF998BF20
        public void set_interactionIndex(){} // RVA: 0x7FFAF998BF40
        public void ToEventPtr(){} // RVA: 0x7FFAF44EF520
        public void get_typeStatic(){} // RVA: 0x7FFAF998BD80
        public void GetEventSizeWithValueSize(){} // RVA: 0x7FFAF998BFC0
        public void From(){} // RVA: 0x7FFAF998BFD0
    }

    public class AttitudeState
    {
        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFAF998B7F0
        public void get_format(){} // RVA: 0x7FFAF998B7F0
    }

    public class DeltaStateEvent
    {
        // ── Methods ──
        public void get_deltaStateSizeInBytes(){} // RVA: 0x7FFAF998C100
        public void get_deltaState(){} // RVA: 0x7FFAF998C110
        public void get_typeStatic(){} // RVA: 0x7FFAF998C120
        public void ToEventPtr(){} // RVA: 0x7FFAF44EF520
        public void From(){} // RVA: 0x7FFAF998C260 | overloaded x2
        public void FromUnchecked(){} // RVA: 0x7FFAF44EF520
    }

    public class DeviceConfigurationEvent
    {
        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFAF998C5E0
        public void ToEventPtr(){} // RVA: 0x7FFAF44EF520
        public void Create(){} // RVA: 0x7FFAF998C5F0
    }

    public class DeviceRemoveEvent
    {
        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFAF998C6C0
        public void ToEventPtr(){} // RVA: 0x7FFAF44EF520
        public void Create(){} // RVA: 0x7FFAF998C6D0
    }

    public class DeviceResetEvent
    {
        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFAF998C7A0
        public void Create(){} // RVA: 0x7FFAF998C7B0
    }

    public class DisableDeviceCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998AA10
        public void get_typeStatic(){} // RVA: 0x7FFAF998AA10
        public void Create(){} // RVA: 0x7FFAF998AA20
    }

    public class DualMotorRumbleCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998B440
        public void get_typeStatic(){} // RVA: 0x7FFAF998B440
        public void Create(){} // RVA: 0x7FFAF998B450
    }

    public class EnableDeviceCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998AA40
        public void get_typeStatic(){} // RVA: 0x7FFAF998AA40
        public void Create(){} // RVA: 0x7FFAF998AA50
    }

    public class EnableIMECompositionCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998AA70
        public void get_imeEnabled(){} // RVA: 0x7FFAF998AA80
        public void get_typeStatic(){} // RVA: 0x7FFAF998AA70
        public void Create(){} // RVA: 0x7FFAF998AA90
    }

    public class GamepadState
    {
        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFAF998B340
        public void get_format(){} // RVA: 0x7FFAF998B340
        public void .ctor(){} // RVA: 0x7FFAF998B350
        public void WithButton(){} // RVA: 0x7FFAF998B3F0
    }

    public class GravityState
    {
        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFAF998B7E0
        public void get_format(){} // RVA: 0x7FFAF998B7E0
    }

    public class GyroscopeState
    {
        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFAF998B7D0
        public void get_format(){} // RVA: 0x7FFAF998B7D0
    }

    public class ICustomDeviceReset
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IEventMerger
    {
        // ── Methods ──
        public void MergeForward(){}
    }

    public class IEventPreProcessor
    {
        // ── Methods ──
        public void PreProcessEvent(){} // RVA: 0x7FFAF2ABE6C0
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
        public void AllocateDeviceId(){} // RVA: 0x7FFAF2ABD840
        public void Update(){} // RVA: 0x7FFAF2AD4FA0
        public void QueueEvent(){} // RVA: 0x7FFAF2D33FA0
        public void DeviceCommand(){} // RVA: 0x7FFAF2D33FA0
        public void get_onUpdate(){} // RVA: 0x7FFAF2ABCD60
        public void set_onUpdate(){} // RVA: 0x7FFAF2AD4B10
        public void get_onBeforeUpdate(){} // RVA: 0x7FFAF2ABCD60
        public void set_onBeforeUpdate(){} // RVA: 0x7FFAF2AD4B10
        public void get_onShouldRunUpdate(){} // RVA: 0x7FFAF2ABCD60
        public void set_onShouldRunUpdate(){} // RVA: 0x7FFAF2AD4B10
        public void get_onDeviceDiscovered(){} // RVA: 0x7FFAF2ABCD60
        public void set_onDeviceDiscovered(){} // RVA: 0x7FFAF2AD4B10
        public void get_onPlayerFocusChanged(){} // RVA: 0x7FFAF2ABCD60
        public void set_onPlayerFocusChanged(){} // RVA: 0x7FFAF2AD4B10
        public void get_isPlayerFocused(){} // RVA: 0x7FFAF2ABDBE0
        public void get_onShutdown(){} // RVA: 0x7FFAF2ABCD60
        public void set_onShutdown(){} // RVA: 0x7FFAF2AD4B10
        public void get_pollingFrequency(){} // RVA: 0x7FFAF2AD1890
        public void set_pollingFrequency(){} // RVA: 0x7FFAF2AE25B0
        public void get_currentTime(){} // RVA: 0x7FFAF2AC2A40
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x7FFAF2AC2A40
        public void get_unscaledGameTime(){} // RVA: 0x7FFAF2AD1890
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7FFAF2AC2A40
        public void get_runInBackground(){} // RVA: 0x7FFAF2ABDBE0
        public void set_runInBackground(){} // RVA: 0x7FFAF2AD5130
        public void get_screenSize(){} // RVA: 0x7FFAF2ABCD60
        public void get_screenOrientation(){} // RVA: 0x7FFAF2ABD840
        public void get_isInBatchMode(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class IInputStateCallbackReceiver
    {
        // ── Methods ──
        public void OnNextUpdate(){} // RVA: 0x7FFAF2AD4A50
        public void OnStateEvent(){} // RVA: 0x7FFAF2AD4CC0
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
        public void OnUpdate(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IMECompositionEvent
    {
        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFAF998C890
        public void Create(){} // RVA: 0x7FFAF998C8A0
    }

    public class IMECompositionString
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAF44189B0
        public void get_Item(){} // RVA: 0x7FFAF998CAA0
        public void .ctor(){} // RVA: 0x7FFAF998CB10
        public void ToString(){} // RVA: 0x7FFAF998CB80
        public void GetEnumerator(){} // RVA: 0x7FFAF998CBA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF998CC70
    }

    public class ITextInputReceiver
    {
        // ── Methods ──
        public void OnTextInput(){} // RVA: 0x7FFAF2AD4C40
        public void OnIMECompositionChanged(){}
    }

    public class InitiateUserAccountPairingCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998AAC0
        public void get_typeStatic(){} // RVA: 0x7FFAF998AAC0
        public void Create(){} // RVA: 0x7FFAF998AAD0
    }

    public class InputDeviceCommand
    {
        // ── Methods ──
        public void get_payloadSizeInBytes(){} // RVA: 0x7FFAF998AB80
        public void get_payloadPtr(){} // RVA: 0x7FFAF998AB90
        public void .ctor(){} // RVA: 0x7FFAF335E010
        public void AllocateNative(){} // RVA: 0x7FFAF998ABA0
        public void get_typeStatic(){} // RVA: 0x7FFAF2FC9240
    }

    public class InputDeviceCommandDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5E5F4F0
        public void Invoke(){} // RVA: 0x7FFAF5E5D460
        public void BeginInvoke(){} // RVA: 0x7FFAF45AE3C0
        public void EndInvoke(){} // RVA: 0x7FFAF47CDE50
    }

    public class InputDeviceExecuteCommandDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5DEC9B0
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
        public void BeginInvoke(){} // RVA: 0x7FFAF998AAF0
        public void EndInvoke(){} // RVA: 0x7FFAF70E50F0
    }

    public class InputEvent
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFAF44189B0
        public void set_type(){} // RVA: 0x7FFAF32E3580
        public void get_sizeInBytes(){} // RVA: 0x7FFAF62764C0
        public void set_sizeInBytes(){} // RVA: 0x7FFAF998CD70
        public void get_eventId(){} // RVA: 0x7FFAF998CE20
        public void set_eventId(){} // RVA: 0x7FFAF998CE30
        public void get_deviceId(){} // RVA: 0x7FFAF8D84F60
        public void set_deviceId(){} // RVA: 0x7FFAF998CE40
        public void get_time(){} // RVA: 0x7FFAF998CE50
        public void set_time(){} // RVA: 0x7FFAF998CEA0
        public void get_internalTime(){} // RVA: 0x7FFAF47583E0
        public void set_internalTime(){} // RVA: 0x7FFAF4A401F0
        public void .ctor(){} // RVA: 0x7FFAF998CF00
        public void get_handled(){} // RVA: 0x7FFAF998CFC0
        public void set_handled(){} // RVA: 0x7FFAF998CFD0
        public void ToString(){} // RVA: 0x7FFAF998CFF0
        public void GetNextInMemory(){} // RVA: 0x7FFAF998D2F0
        public void GetNextInMemoryChecked(){} // RVA: 0x7FFAF998D310
        public void Equals(){} // RVA: 0x7FFAF998D460
    }

    public class InputEventBuffer
    {
        // ── Methods ──
        public void get_eventCount(){} // RVA: 0x7FFAF306ED50
        public void get_sizeInBytes(){} // RVA: 0x7FFAF2DA8380
        public void get_capacityInBytes(){} // RVA: 0x7FFAF998D4B0
        public void get_data(){} // RVA: 0x7FFAF320E7E0
        public void get_bufferPtr(){} // RVA: 0x7FFAF998D500
        public void .ctor(){} // RVA: 0x7FFAF998D710 | overloaded x2
        public void AppendEvent(){} // RVA: 0x7FFAF998D840
        public void AllocateEvent(){} // RVA: 0x7FFAF998D8D0
        public void Contains(){} // RVA: 0x7FFAF998DBB0
        public void Reset(){} // RVA: 0x7FFAF998DC20
        public void AdvanceToNextEvent(){} // RVA: 0x7FFAF998DC40
        public void GetEnumerator(){} // RVA: 0x7FFAF998DD30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF998DDF0
        public void Dispose(){} // RVA: 0x7FFAF998DE00
        public void Clone(){} // RVA: 0x7FFAF998DE60
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAF998DFF0
    }

    public class InputEventListener
    {
        // ── Methods ──
        public void op_Addition(){} // RVA: 0x7FFAF998E160
        public void op_Subtraction(){} // RVA: 0x7FFAF998E3B0
        public void Subscribe(){} // RVA: 0x7FFAF998E600
    }

    public class InputEventPtr
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45C2320
        public void get_valid(){} // RVA: 0x7FFAF5F71790
        public void get_handled(){} // RVA: 0x7FFAF998ED00
        public void set_handled(){} // RVA: 0x7FFAF998ED20
        public void get_id(){} // RVA: 0x7FFAF998EDA0
        public void set_id(){} // RVA: 0x7FFAF998EDC0
        public void get_type(){} // RVA: 0x7FFAF998EE40
        public void get_sizeInBytes(){} // RVA: 0x7FFAF998EE50
        public void get_deviceId(){} // RVA: 0x7FFAF998EE70
        public void set_deviceId(){} // RVA: 0x7FFAF998EE90
        public void get_time(){} // RVA: 0x7FFAF998EF00
        public void set_time(){} // RVA: 0x7FFAF998EF60
        public void get_internalTime(){} // RVA: 0x7FFAF998F010
        public void set_internalTime(){} // RVA: 0x7FFAF998F030
        public void get_data(){} // RVA: 0x7FFAF4584690
        public void get_stateFormat(){} // RVA: 0x7FFAF998F0A0
        public void get_stateSizeInBytes(){} // RVA: 0x7FFAF998F150
        public void get_stateOffset(){} // RVA: 0x7FFAF998F280
        public void IsA(){} // RVA: 0x7FFAF2ABDBE0
        public void Next(){} // RVA: 0x7FFAF998F370
        public void ToString(){} // RVA: 0x7FFAF998F390
        public void ToPointer(){} // RVA: 0x7FFAF4584690
        public void Equals(){} // RVA: 0x7FFAF998F450 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF44189B0
        public void op_Equality(){} // RVA: 0x7FFAF5328D00
        public void op_Inequality(){} // RVA: 0x7FFAF89694A0
        public void op_Implicit(){} // RVA: 0x7FFAF44EF520 | overloaded x2
        public void From(){} // RVA: 0x7FFAF44EF520
        public void FromInputEventPtr(){} // RVA: 0x7FFAF44EF520
    }

    public class InputEventStream
    {
        // ── Methods ──
        public void get_isOpen(){} // RVA: 0x7FFAF2E09320
        public void get_remainingEventCount(){} // RVA: 0x7FFAF998F510
        public void get_numEventsRetainedInBuffer(){} // RVA: 0x7FFAF4741460
        public void get_currentEventPtr(){} // RVA: 0x7FFAF998F520
        public void get_numBytesRetainedInBuffer(){} // RVA: 0x7FFAF998F540
        public void .ctor(){} // RVA: 0x7FFAF998F580
        public void Close(){} // RVA: 0x7FFAF998F610
        public void CleanUpAfterException(){} // RVA: 0x7FFAF998F780
        public void Write(){} // RVA: 0x7FFAF998F830
        public void Advance(){} // RVA: 0x7FFAF998FAB0
        public void Peek(){} // RVA: 0x7FFAF998FB50
    }

    public class InputEventTrace
    {
        // ── Methods ──
        public void get_FrameMarkerEvent(){} // RVA: 0x7FFAF998FB90
        public void get_deviceId(){} // RVA: 0x7FFAF3210030
        public void set_deviceId(){} // RVA: 0x7FFAF344E0D0
        public void get_enabled(){} // RVA: 0x7FFAF2EDCBD0
        public void get_recordFrameMarkers(){} // RVA: 0x7FFAF639ED40
        public void set_recordFrameMarkers(){} // RVA: 0x7FFAF998FBA0
        public void get_eventCount(){} // RVA: 0x7FFAF3246DE0
        public void get_totalEventSizeInBytes(){} // RVA: 0x7FFAF34CC8C0
        public void get_allocatedSizeInBytes(){} // RVA: 0x7FFAF998FC90
        public void get_maxSizeInBytes(){} // RVA: 0x7FFAF2F12D00
        public void get_deviceInfos(){} // RVA: 0x7FFAF998FCB0
        public void get_onFilterEvent(){} // RVA: 0x7FFAF2D907C0
        public void set_onFilterEvent(){} // RVA: 0x7FFAF2DF3E80
        public void add_onEvent(){} // RVA: 0x7FFAF998FD90
        public void remove_onEvent(){} // RVA: 0x7FFAF998FDE0
        public void .ctor(){} // RVA: 0x7FFAF998FEF0 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFAF9990050 | overloaded x2
        public void ReadFrom(){} // RVA: 0x7FFAF9990840 | overloaded x2
        public void LoadFrom(){} // RVA: 0x7FFAF9991320 | overloaded x2
        public void Replay(){} // RVA: 0x7FFAF9991460
        public void Resize(){} // RVA: 0x7FFAF9991550
        public void Clear(){} // RVA: 0x7FFAF9991810
        public void Enable(){} // RVA: 0x7FFAF9991890
        public void Disable(){} // RVA: 0x7FFAF9991A10
        public void GetNextEvent(){} // RVA: 0x7FFAF9991B10
        public void GetEnumerator(){} // RVA: 0x7FFAF9991B90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF9991B90
        public void Dispose(){} // RVA: 0x7FFAF9991C30
        public void get_m_EventBuffer(){} // RVA: 0x7FFAF34B85E0
        public void set_m_EventBuffer(){} // RVA: 0x7FFAF8AA62E0
        public void get_m_EventBufferHead(){} // RVA: 0x7FFAF34CC130
        public void set_m_EventBufferHead(){} // RVA: 0x7FFAF461C650
        public void get_m_EventBufferTail(){} // RVA: 0x7FFAF2DF8040
        public void set_m_EventBufferTail(){} // RVA: 0x7FFAF461CD00
        public void Allocate(){} // RVA: 0x7FFAF9991D30
        public void Release(){} // RVA: 0x7FFAF9991DA0
        public void OnBeforeUpdate(){} // RVA: 0x7FFAF9991EA0
        public void OnInputEvent(){} // RVA: 0x7FFAF9991FA0
        public void get_kFileFormat(){} // RVA: 0x7FFAF99925B0
        public void .cctor(){} // RVA: 0x7FFAF99925C0
    }

    public class InputMetrics
    {
        // ── Methods ──
        public void get_maxNumDevices(){} // RVA: 0x7FFAF44189B0
        public void set_maxNumDevices(){} // RVA: 0x7FFAF32E3580
        public void get_currentNumDevices(){} // RVA: 0x7FFAF44189E0
        public void set_currentNumDevices(){} // RVA: 0x7FFAF44189D0
        public void get_maxStateSizeInBytes(){} // RVA: 0x7FFAF4959890
        public void set_maxStateSizeInBytes(){} // RVA: 0x7FFAF49598A0
        public void get_currentStateSizeInBytes(){} // RVA: 0x7FFAF49598B0
        public void set_currentStateSizeInBytes(){} // RVA: 0x7FFAF49598C0
        public void get_currentControlCount(){} // RVA: 0x7FFAF2DDA5C0
        public void set_currentControlCount(){} // RVA: 0x7FFAF2D900C0
        public void get_currentLayoutCount(){} // RVA: 0x7FFAF335BED0
        public void set_currentLayoutCount(){} // RVA: 0x7FFAF335C660
        public void get_totalEventBytes(){} // RVA: 0x7FFAF306ED50
        public void set_totalEventBytes(){} // RVA: 0x7FFAF30E74E0
        public void get_totalEventCount(){} // RVA: 0x7FFAF442C3B0
        public void set_totalEventCount(){} // RVA: 0x7FFAF4439FD0
        public void get_totalUpdateCount(){} // RVA: 0x7FFAF3210030
        public void set_totalUpdateCount(){} // RVA: 0x7FFAF344E0D0
        public void get_totalEventProcessingTime(){} // RVA: 0x7FFAF9995020
        public void set_totalEventProcessingTime(){} // RVA: 0x7FFAF9995030
        public void get_totalEventLagTime(){} // RVA: 0x7FFAF9995040
        public void set_totalEventLagTime(){} // RVA: 0x7FFAF9995050
        public void get_averageEventBytesPerFrame(){} // RVA: 0x7FFAF9995060
        public void get_averageProcessingTimePerEvent(){} // RVA: 0x7FFAF9995080
        public void get_averageLagTimePerEvent(){} // RVA: 0x7FFAF99950A0
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
        public void get_currentUpdateType(){} // RVA: 0x7FFAF9996DF0
        public void get_updateCount(){} // RVA: 0x7FFAF9996E30
        public void get_currentTime(){} // RVA: 0x7FFAF9996E70
        public void add_onChange(){} // RVA: 0x7FFAF9996EF0
        public void remove_onChange(){} // RVA: 0x7FFAF9996FA0
        public void Change(){} // RVA: 0x7FFAF2D33FA0 | overloaded x3
        public void IsIntegerFormat(){} // RVA: 0x7FFAF9997340
        public void AddChangeMonitor(){} // RVA: 0x7FFAF9997690 | overloaded x2
        public void RemoveChangeMonitor(){} // RVA: 0x7FFAF9997820
        public void AddChangeMonitorTimeout(){} // RVA: 0x7FFAF9997960
        public void RemoveChangeMonitorTimeout(){} // RVA: 0x7FFAF9997A70
    }

    public class InputStateBlock
    {
        public object useTransactionLog;
        public object products;

        // ── Methods ──
        public void GetSizeOfPrimitiveFormatInBits(){} // RVA: 0x7FFAF9997BB0
        public void GetPrimitiveFormatFromType(){} // RVA: 0x7FFAF9997F00
        public void get_format(){} // RVA: 0x7FFAF44189B0
        public void set_format(){} // RVA: 0x7FFAF32E3580
        public void get_byteOffset(){} // RVA: 0x7FFAF44189E0
        public void set_byteOffset(){} // RVA: 0x7FFAF44189D0
        public void get_bitOffset(){} // RVA: 0x7FFAF4959890
        public void set_bitOffset(){} // RVA: 0x7FFAF49598A0
        public void get_sizeInBits(){} // RVA: 0x7FFAF49598B0
        public void set_sizeInBits(){} // RVA: 0x7FFAF49598C0
        public void get_alignedSizeInBytes(){} // RVA: 0x7FFAF9998580
        public void get_effectiveByteOffset(){} // RVA: 0x7FFAF99985D0
        public void get_effectiveBitOffset(){} // RVA: 0x7FFAF9998620
        public void ReadInt(){} // RVA: 0x7FFAF9998670
        public void WriteInt(){} // RVA: 0x7FFAF9998960
        public void ReadFloat(){} // RVA: 0x7FFAF9998BE0
        public void WriteFloat(){} // RVA: 0x7FFAF9998FC0
        public void FloatToPrimitiveValue(){} // RVA: 0x7FFAF9999340
        public void ReadDouble(){} // RVA: 0x7FFAF9999700
        public void WriteDouble(){} // RVA: 0x7FFAF9999B00
        public void Write(){} // RVA: 0x7FFAF9999EA0
        public void CopyToFrom(){} // RVA: 0x7FFAF999A1B0
        public void .cctor(){} // RVA: 0x7FFAF999A310
    }

    public class InputStateBuffers
    {
        // ── Methods ──
        public void GetDoubleBuffersFor(){} // RVA: 0x7FFAF999A500
        public void GetFrontBufferForDevice(){} // RVA: 0x7FFAF999A5E0
        public void GetBackBufferForDevice(){} // RVA: 0x7FFAF999A640
        public void SwitchTo(){} // RVA: 0x7FFAF999A6A0
        public void AllocateAll(){} // RVA: 0x7FFAF999A710
        public void SetUpDeviceToBufferMappings(){} // RVA: 0x7FFAF999A890
        public void FreeAll(){} // RVA: 0x7FFAF999A920
        public void MigrateAll(){} // RVA: 0x7FFAF999AA40
        public void MigrateDoubleBuffer(){} // RVA: 0x7FFAF999AC00
        public void MigrateSingleBuffer(){} // RVA: 0x7FFAF999ADD0
        public void ComputeSizeOfSingleStateBuffer(){} // RVA: 0x7FFAF999AF00
        public void NextDeviceOffset(){} // RVA: 0x7FFAF999B080
    }

    public class InputStateHistory
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAF2E2E0A0
        public void get_version(){} // RVA: 0x7FFAF370BE80
        public void get_historyDepth(){} // RVA: 0x7FFAF2E2E0C0
        public void set_historyDepth(){} // RVA: 0x7FFAF999B280
        public void get_extraMemoryPerRecord(){} // RVA: 0x7FFAF3F29960
        public void set_extraMemoryPerRecord(){} // RVA: 0x7FFAF999B360
        public void get_updateMask(){} // RVA: 0x7FFAF999B440
        public void set_updateMask(){} // RVA: 0x7FFAF999B4F0
        public void get_controls(){} // RVA: 0x7FFAF999B5B0
        public void get_Item(){} // RVA: 0x7FFAF999B660
        public void set_Item(){} // RVA: 0x7FFAF999B7E0
        public void get_onRecordAdded(){} // RVA: 0x7FFAF2DA8380
        public void set_onRecordAdded(){} // RVA: 0x7FFAF2D8EE30
        public void get_onShouldRecordStateChange(){} // RVA: 0x7FFAF2D907C0
        public void set_onShouldRecordStateChange(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAF999BD60 | overloaded x4
        public void Finalize(){} // RVA: 0x7FFAF999BE70
        public void Clear(){} // RVA: 0x7FFAF999BEB0
        public void AddRecord(){} // RVA: 0x7FFAF999BEC0
        public void StartRecording(){} // RVA: 0x7FFAF999BF90
        public void StopRecording(){} // RVA: 0x7FFAF999C150
        public void RecordStateChange(){} // RVA: 0x7FFAF999C670 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAF999CAF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF999CAF0
        public void Dispose(){} // RVA: 0x7FFAF999CBA0
        public void Destroy(){} // RVA: 0x7FFAF999CC50
        public void Allocate(){} // RVA: 0x7FFAF999CCB0
        public void RecordIndexToUserIndex(){} // RVA: 0x7FFAF999D040
        public void UserIndexToRecordIndex(){} // RVA: 0x7FFAF999D060
        public void GetRecord(){} // RVA: 0x7FFAF999D070
        public void GetRecordUnchecked(){} // RVA: 0x7FFAF999D160
        public void AllocateRecord(){} // RVA: 0x7FFAF999D1F0
        public void ReadValue(){} // RVA: 0x7FFAF2D33FA0
        public void ReadValueAsObject(){} // RVA: 0x7FFAF999D2C0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7FFAF999D490
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7FFAF2D8D310
        public void get_bytesPerRecord(){} // RVA: 0x7FFAF999D600
    }

    public class InputStateHistory`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFAF2AD4A50
        public void AddRecord(){} // RVA: 0x7FFAF2D33FA0
        public void RecordStateChange(){} // RVA: 0x7FFAF2D33FA0
        public void GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void get_Item(){} // RVA: 0x7FFAF2D33FA0
        public void set_Item(){} // RVA: 0x7FFAF2D33FA0
    }

    public class InputStateHistory`1
    {
    }

    public class InputUpdate
    {
        // ── Methods ──
        public void OnBeforeUpdate(){} // RVA: 0x7FFAF99950C0
        public void OnUpdate(){} // RVA: 0x7FFAF9995140
        public void Save(){} // RVA: 0x7FFAF99951C0
        public void Restore(){} // RVA: 0x7FFAF9995210
        public void GetUpdateTypeForPlayer(){} // RVA: 0x7FFAF99952B0
        public void IsPlayerUpdate(){} // RVA: 0x7FFAF99952D0
    }

    public class InputUpdateDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2EE92A0
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
        public void BeginInvoke(){} // RVA: 0x7FFAF9994F70
        public void EndInvoke(){} // RVA: 0x7FFAF498D9F0
    }

    public class JoystickState
    {
        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFAF998B480
        public void get_format(){} // RVA: 0x7FFAF998B480
    }

    public class KeyboardState
    {
        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFAF998B490
        public void .ctor(){} // RVA: 0x7FFAF998B590 | overloaded x2
        public void Set(){} // RVA: 0x7FFAF9881020
        public void Get(){} // RVA: 0x7FFAF9881050
        public void Press(){} // RVA: 0x7FFAF998B6A0
        public void Release(){} // RVA: 0x7FFAF998B6C0
        public void get_format(){} // RVA: 0x7FFAF998B490
    }

    public class LinearAccelerationState
    {
        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFAF998B800
        public void get_format(){} // RVA: 0x7FFAF998B800
    }

    public class MouseState
    {
        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFAF998B6E0
        public void WithButton(){} // RVA: 0x7FFAF998B6F0
        public void get_format(){} // RVA: 0x7FFAF998B6E0
    }

    public class NativeInputRuntime
    {
        // ── Methods ──
        public void AllocateDeviceId(){} // RVA: 0x7FFAF9995300
        public void Update(){} // RVA: 0x7FFAF9995380
        public void QueueEvent(){} // RVA: 0x7FFAF9995410
        public void DeviceCommand(){} // RVA: 0x7FFAF99954A0
        public void get_onUpdate(){} // RVA: 0x7FFAF2DBB0C0
        public void set_onUpdate(){} // RVA: 0x7FFAF99955B0
        public void get_onBeforeUpdate(){} // RVA: 0x7FFAF2DBB130
        public void set_onBeforeUpdate(){} // RVA: 0x7FFAF9995910
        public void get_onShouldRunUpdate(){} // RVA: 0x7FFAF30E74D0
        public void set_onShouldRunUpdate(){} // RVA: 0x7FFAF9995BD0
        public void get_onDeviceDiscovered(){} // RVA: 0x7FFAF9995E90
        public void set_onDeviceDiscovered(){} // RVA: 0x7FFAF9995F30
        public void get_onShutdown(){} // RVA: 0x7FFAF2D907C0
        public void set_onShutdown(){} // RVA: 0x7FFAF9996070
        public void get_onPlayerFocusChanged(){} // RVA: 0x7FFAF2E0A740
        public void set_onPlayerFocusChanged(){} // RVA: 0x7FFAF99961C0
        public void get_isPlayerFocused(){} // RVA: 0x7FFAF99965C0
        public void get_pollingFrequency(){} // RVA: 0x7FFAF2FAE250
        public void set_pollingFrequency(){} // RVA: 0x7FFAF9996640
        public void get_currentTime(){} // RVA: 0x7FFAF99966E0
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x7FFAF9996760
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7FFAF9996840
        public void get_unscaledGameTime(){} // RVA: 0x7FFAF99968C0
        public void get_runInBackground(){} // RVA: 0x7FFAF9996910
        public void set_runInBackground(){} // RVA: 0x7FFAF2E575F0
        public void OnShutdown(){} // RVA: 0x7FFAF6841AE0
        public void OnWantsToShutdown(){} // RVA: 0x7FFAF99969A0
        public void OnFocusChanged(){} // RVA: 0x7FFAF8C99590
        public void get_screenSize(){} // RVA: 0x7FFAF99969E0
        public void get_screenOrientation(){} // RVA: 0x7FFAF9996A90
        public void get_isInBatchMode(){} // RVA: 0x7FFAF9996AE0
        public void .ctor(){} // RVA: 0x7FFAF9996B60
        public void .cctor(){} // RVA: 0x7FFAF9996B70
    }

    public class PenState
    {
        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFAF998B750
        public void WithButton(){} // RVA: 0x7FFAF998B760
        public void get_format(){} // RVA: 0x7FFAF998B750
    }

    public class PointerState
    {
        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7FFAF998B7B0
        public void get_format(){} // RVA: 0x7FFAF998B7B0
    }

    public class QueryCanRunInBackground
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998ACF0
        public void get_typeStatic(){} // RVA: 0x7FFAF998ACF0
        public void Create(){} // RVA: 0x7FFAF998AD00
    }

    public class QueryDimensionsCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998AD20
        public void get_typeStatic(){} // RVA: 0x7FFAF998AD20
        public void Create(){} // RVA: 0x7FFAF998AD30
    }

    public class QueryEnabledStateCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998AD60
        public void get_typeStatic(){} // RVA: 0x7FFAF998AD60
        public void Create(){} // RVA: 0x7FFAF998AD70
    }

    public class QueryKeyNameCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998AE40
        public void ReadKeyName(){} // RVA: 0x7FFAF998AE50
        public void get_typeStatic(){} // RVA: 0x7FFAF998AE40
        public void Create(){} // RVA: 0x7FFAF998AE70
    }

    public class QueryKeyboardLayoutCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998AD90
        public void ReadLayoutName(){} // RVA: 0x7FFAF998ADA0
        public void WriteLayoutName(){} // RVA: 0x7FFAF998ADC0
        public void get_typeStatic(){} // RVA: 0x7FFAF998AD90
        public void Create(){} // RVA: 0x7FFAF998AE00
    }

    public class QueryPairedUserAccountCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998AEC0
        public void get_id(){} // RVA: 0x7FFAF998AED0
        public void set_id(){} // RVA: 0x7FFAF998AEF0
        public void get_name(){} // RVA: 0x7FFAF998B020
        public void set_name(){} // RVA: 0x7FFAF998B040
        public void get_typeStatic(){} // RVA: 0x7FFAF998AEC0
        public void Create(){} // RVA: 0x7FFAF998B170
    }

    public class QuerySamplingFrequencyCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998B1B0
        public void get_typeStatic(){} // RVA: 0x7FFAF998B1B0
        public void Create(){} // RVA: 0x7FFAF998B1C0
    }

    public class QueryUserIdCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998B1F0
        public void ReadId(){} // RVA: 0x7FFAF998ADA0
        public void get_typeStatic(){} // RVA: 0x7FFAF998B1F0
        public void Create(){} // RVA: 0x7FFAF998B200
    }

    public class RequestResetCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998B240
        public void get_typeStatic(){} // RVA: 0x7FFAF998B240
        public void Create(){} // RVA: 0x7FFAF998B250
    }

    public class RequestSyncCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998B270
        public void get_typeStatic(){} // RVA: 0x7FFAF998B270
        public void Create(){} // RVA: 0x7FFAF998B280
    }

    public class SelectObservable`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2ADDC60
        public void Subscribe(){} // RVA: 0x7FFAF2ABCE10
    }

    public class SetIMECursorPositionCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998B2A0
        public void get_position(){} // RVA: 0x7FFAF627A1B0
        public void get_typeStatic(){} // RVA: 0x7FFAF998B2A0
        public void Create(){} // RVA: 0x7FFAF998B2B0
    }

    public class SetSamplingFrequencyCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998B2D0
        public void get_typeStatic(){} // RVA: 0x7FFAF998B2D0
        public void Create(){} // RVA: 0x7FFAF998B2E0
    }

    public class StateEvent
    {
        // ── Methods ──
        public void get_stateSizeInBytes(){} // RVA: 0x7FFAF9994780
        public void get_state(){} // RVA: 0x7FFAF9994790
        public void ToEventPtr(){} // RVA: 0x7FFAF44EF520
        public void get_typeStatic(){} // RVA: 0x7FFAF99947A0
        public void GetState(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetEventSizeWithPayload(){} // RVA: 0x7FFAF2ABD870
        public void From(){} // RVA: 0x7FFAF9994940 | overloaded x3
        public void FromUnchecked(){} // RVA: 0x7FFAF44EF520
        public void FromDefaultStateFor(){} // RVA: 0x7FFAF9994910
    }

    public class TextEvent
    {
        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7FFAF9994C70
        public void From(){} // RVA: 0x7FFAF9994C80
        public void Create(){} // RVA: 0x7FFAF9994E90 | overloaded x2
    }

    public class TouchState
    {
        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFAF998B810
        public void get_phase(){} // RVA: 0x7FFAF2E7B9D0
        public void set_phase(){} // RVA: 0x7FFAF2E7B9E0
        public void get_isNoneEndedOrCanceled(){} // RVA: 0x7FFAF998B820
        public void get_isInProgress(){} // RVA: 0x7FFAF998B840
        public void get_isPrimaryTouch(){} // RVA: 0x7FFAF998B860
        public void set_isPrimaryTouch(){} // RVA: 0x7FFAF998B870
        public void get_isOrphanedPrimaryTouch(){} // RVA: 0x7FFAF998B8A0
        public void set_isOrphanedPrimaryTouch(){} // RVA: 0x7FFAF998B8B0
        public void get_isIndirectTouch(){} // RVA: 0x7FFAF998B8E0
        public void set_isIndirectTouch(){} // RVA: 0x7FFAF998B8F0
        public void get_isTap(){} // RVA: 0x7FFAF998B920
        public void set_isTap(){} // RVA: 0x7FFAF998B930
        public void get_isTapPress(){} // RVA: 0x7FFAF998B920
        public void set_isTapPress(){} // RVA: 0x7FFAF998B930
        public void get_isTapRelease(){} // RVA: 0x7FFAF998B960
        public void set_isTapRelease(){} // RVA: 0x7FFAF998B970
        public void get_beganInSameFrame(){} // RVA: 0x7FFAF998B9A0
        public void set_beganInSameFrame(){} // RVA: 0x7FFAF998B9B0
        public void get_format(){} // RVA: 0x7FFAF998B810
        public void ToString(){} // RVA: 0x7FFAF998B9E0
    }

    public class TouchscreenState
    {
        // ── Methods ──
        public void get_Format(){} // RVA: 0x7FFAF998BD70
        public void get_primaryTouch(){} // RVA: 0x7FFAF44EF520
        public void get_touches(){} // RVA: 0x7FFAF7E0CA10
        public void get_format(){} // RVA: 0x7FFAF998BD70
    }

    public class WarpMousePositionCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF998B310
        public void get_typeStatic(){} // RVA: 0x7FFAF998B310
        public void Create(){} // RVA: 0x7FFAF998B320
    }

}