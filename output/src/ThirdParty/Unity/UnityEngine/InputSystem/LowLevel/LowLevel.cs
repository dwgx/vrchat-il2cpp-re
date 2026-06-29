// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
// Classes: 71
// Methods: 508

namespace ThirdParty.Unity.UnityEngine.InputSystem.LowLevel
{
    public class AccelerometerState : ValueType
    {
        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7AECBA000
        public void get_format(){} // RVA: 0x7A7EB8600
    }

    public class ActionEvent : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECBA5C0
        public void get_startTime(){} // RVA: 0x7A7EB0800
        public void set_startTime(){} // RVA: 0x7A7EB8860
        public void get_phase(){} // RVA: 0x7A7677970
        public void set_phase(){} // RVA: 0x7A7677AE0
        public void get_valueData(){} // RVA: 0x7A7EB8870
        public void get_valueSizeInBytes(){} // RVA: 0x7A7EB8880
        public void get_stateIndex(){} // RVA: 0x7A76779B0
        public void set_stateIndex(){} // RVA: 0x7A7EB8890
        public void get_controlIndex(){} // RVA: 0x7A782C430
        public void set_controlIndex(){} // RVA: 0x7A7EB88A0
        public void get_bindingIndex(){} // RVA: 0x7A7EB88B0
        public void set_bindingIndex(){} // RVA: 0x7A7EB88C0
        public void get_interactionIndex(){} // RVA: 0x7A7EB88D0
        public void set_interactionIndex(){} // RVA: 0x7A7EB88F0
        public void ToEventPtr(){} // RVA: 0x7A7EB8830
        public void get_typeStatic(){} // RVA: 0x7A7EB8900
        public void GetEventSizeWithValueSize(){} // RVA: 0x7AECBA800
        public void From(){} // RVA: 0x7AECBA810
    }

    public class AttitudeState : ValueType
    {
        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7AECBA030
        public void get_format(){} // RVA: 0x7A7EB8630
    }

    public class DeltaStateEvent : ValueType
    {
        // ── Methods ──
        public void get_deltaStateSizeInBytes(){} // RVA: 0x7A7EB8910
        public void get_deltaState(){} // RVA: 0x7A7EB8920
        public void get_typeStatic(){} // RVA: 0x7A7EB8930
        public void ToEventPtr(){} // RVA: 0x7A7EB8830
        public void From(){} // RVA: 0x7AECBAAA0
        public void FromUnchecked(){} // RVA: 0x7A97F8BA0
    }

    public class DeviceConfigurationEvent : ValueType
    {
        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7A7EB8940
        public void ToEventPtr(){} // RVA: 0x7A7EB8830
        public void Create(){} // RVA: 0x7AECBAE90
    }

    public class DeviceRemoveEvent : ValueType
    {
        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7A7EB8950
        public void ToEventPtr(){} // RVA: 0x7A7EB8830
        public void Create(){} // RVA: 0x7AECBAF70
    }

    public class DeviceResetEvent : ValueType
    {
        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7A7EB89A0
        public void Create(){} // RVA: 0x7AECBB050
    }

    public class DisableDeviceCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB9240
        public void get_typeStatic(){} // RVA: 0x7A7EB7DD0
        public void Create(){} // RVA: 0x7AECB9250
    }

    public class DualMotorRumbleCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB9C80
        public void get_typeStatic(){} // RVA: 0x7A7EB8340
        public void Create(){} // RVA: 0x7AECB9C90
    }

    public class EnableDeviceCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB9270
        public void get_typeStatic(){} // RVA: 0x7A7EB7DE0
        public void Create(){} // RVA: 0x7AECB9280
    }

    public class EnableIMECompositionCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB92A0
        public void get_imeEnabled(){} // RVA: 0x7A7EB7DF0
        public void get_typeStatic(){} // RVA: 0x7A7EB7E00
        public void Create(){} // RVA: 0x7AECB92C0
    }

    public class GamepadState : ValueType
    {
        // ── Methods ──
        public void get_Format(){} // RVA: 0x7AECB9B70
        public void get_format(){} // RVA: 0x7A7EB8230
        public void .ctor(){} // RVA: 0x7A7EB8240
        public void WithButton(){} // RVA: 0x7A7EB82F0
    }

    public class GravityState : ValueType
    {
        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7AECBA020
        public void get_format(){} // RVA: 0x7A7EB8620
    }

    public class GyroscopeState : ValueType
    {
        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7AECBA010
        public void get_format(){} // RVA: 0x7A7EB8610
    }

    public class ICustomDeviceReset
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7A7E18770
    }

    public class IEventMerger
    {
        // ── Methods ──
        public void MergeForward(){} // RVA: 0x7A7E01A80
    }

    public class IEventPreProcessor
    {
        // ── Methods ──
        public void PreProcessEvent(){} // RVA: 0x7A7E01B10
    }

    public class IInputDeviceCommandInfo
    {
        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7A7E00710
    }

    public class IInputEventTypeInfo
    {
        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7A7E00710
    }

    public class IInputRuntime
    {
        // ── Methods ──
        public void AllocateDeviceId(){} // RVA: 0x7A7E00710
        public void Update(){} // RVA: 0x7A7E189D0
        public void QueueEvent(){} // RVA: 0x7A8051B10
        public void DeviceCommand(){} // RVA: 0x7A8051B10
        public void get_onUpdate(){} // RVA: 0x7A7E00680
        public void set_onUpdate(){} // RVA: 0x7A7E18800
        public void get_onBeforeUpdate(){} // RVA: 0x7A7E00680
        public void set_onBeforeUpdate(){} // RVA: 0x7A7E18800
        public void get_onShouldRunUpdate(){} // RVA: 0x7A7E00680
        public void set_onShouldRunUpdate(){} // RVA: 0x7A7E18800
        public void get_onDeviceDiscovered(){} // RVA: 0x7A7E00680
        public void set_onDeviceDiscovered(){} // RVA: 0x7A7E18800
        public void get_onPlayerFocusChanged(){} // RVA: 0x7A7E00680
        public void set_onPlayerFocusChanged(){} // RVA: 0x7A7E18800
        public void get_isPlayerFocused(){} // RVA: 0x7A7E01900
        public void get_onShutdown(){} // RVA: 0x7A7E00680
        public void set_onShutdown(){} // RVA: 0x7A7E18800
        public void get_pollingFrequency(){} // RVA: 0x7A7E155B0
        public void set_pollingFrequency(){} // RVA: 0x7A7E262C0
        public void get_currentTime(){} // RVA: 0x7A7E06760
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x7A7E06760
        public void get_unscaledGameTime(){} // RVA: 0x7A7E155B0
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7A7E06760
        public void get_runInBackground(){} // RVA: 0x7A7E01900
        public void set_runInBackground(){} // RVA: 0x7A7E18C30
        public void get_screenSize(){} // RVA: 0x7A7E00680
        public void get_screenOrientation(){} // RVA: 0x7A7E00710
        public void get_isInBatchMode(){} // RVA: 0x7A7E01900
    }

    public class IInputStateCallbackReceiver
    {
        // ── Methods ──
        public void OnNextUpdate(){} // RVA: 0x7A7E18770
        public void OnStateEvent(){} // RVA: 0x7A7E188D0
        public void GetStateOffsetForEvent(){} // RVA: 0x7A7E04440
    }

    public class IInputStateChangeMonitor
    {
        // ── Methods ──
        public void NotifyControlStateChanged(){} // RVA: 0x7A7E1F150
        public void NotifyTimerExpired(){} // RVA: 0x7A7E1F150
    }

    public class IInputStateTypeInfo
    {
        // ── Methods ──
        public void get_format(){} // RVA: 0x7A7E00710
    }

    public class IInputUpdateCallbackReceiver
    {
        // ── Methods ──
        public void OnUpdate(){} // RVA: 0x7A7E18770
    }

    public class IMECompositionEvent : ValueType
    {
        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7A7EB8AD0
        public void Create(){} // RVA: 0x7AECBB140
    }

    public class IMECompositionString : ValueType
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7A765F070
        public void get_Item(){} // RVA: 0x7A7EB8B90
        public void .ctor(){} // RVA: 0x7A7EB8C00
        public void ToString(){} // RVA: 0x7A7EB8C70
        public void GetEnumerator(){} // RVA: 0x7A7EB8C90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7EB8CA0
    }

    public class ITextInputReceiver
    {
        // ── Methods ──
        public void OnTextInput(){} // RVA: 0x7A7E18950
        public void OnIMECompositionChanged(){} // RVA: 0x7A7E18800
    }

    public class InitiateUserAccountPairingCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB92F0
        public void get_typeStatic(){} // RVA: 0x7A7EB7E10
        public void Create(){} // RVA: 0x7AECB9300
    }

    public class InputDeviceCommand : ValueType
    {
        // ── Methods ──
        public void get_payloadSizeInBytes(){} // RVA: 0x7A7EB7E20
        public void get_payloadPtr(){} // RVA: 0x7A7EB7E30
        public void .ctor(){} // RVA: 0x7A7615330
        public void AllocateNative(){} // RVA: 0x7AECB93D0
        public void get_typeStatic(){} // RVA: 0x7A76850B0
    }

    public class InputDeviceCommandDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB1A5000
        public void Invoke(){} // RVA: 0x7AB1A30C0
        public void BeginInvoke(){} // RVA: 0x7A98B8490
        public void EndInvoke(){} // RVA: 0x7A9B20330
    }

    public class InputDeviceExecuteCommandDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB133B10
        public void Invoke(){} // RVA: 0x7A8133090
        public void BeginInvoke(){} // RVA: 0x7AECB9320
        public void EndInvoke(){} // RVA: 0x7AC426C10
    }

    public class InputEvent : ValueType
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0x7A765F070
        public void set_type(){} // RVA: 0x7A76134D0
        public void get_sizeInBytes(){} // RVA: 0x7A7909FD0
        public void set_sizeInBytes(){} // RVA: 0x7A7EB8F20
        public void get_eventId(){} // RVA: 0x7A7EB8F30
        public void set_eventId(){} // RVA: 0x7A7EB8F40
        public void get_deviceId(){} // RVA: 0x7A7E69CD0
        public void set_deviceId(){} // RVA: 0x7A7EB8F50
        public void get_time(){} // RVA: 0x7A7EB8F60
        public void set_time(){} // RVA: 0x7A7EB8FB0
        public void get_internalTime(){} // RVA: 0x7A766FF70
        public void set_internalTime(){} // RVA: 0x7A76BF780
        public void .ctor(){} // RVA: 0x7A7EB9010
        public void get_handled(){} // RVA: 0x7A7EB6480
        public void set_handled(){} // RVA: 0x7A7EB9020
        public void ToString(){} // RVA: 0x7A7EB9040
        public void GetNextInMemory(){} // RVA: 0x7AECBBB80
        public void GetNextInMemoryChecked(){} // RVA: 0x7AECBBBA0
        public void Equals(){} // RVA: 0x7AECBBCF0
    }

    public class InputEventBuffer : ValueType
    {
        // ── Methods ──
        public void get_eventCount(){} // RVA: 0x7A768A430
        public void get_sizeInBytes(){} // RVA: 0x7A7664CF0
        public void get_capacityInBytes(){} // RVA: 0x7A7EB9090
        public void get_data(){} // RVA: 0x7A7662BE0
        public void get_bufferPtr(){} // RVA: 0x7A7EB90E0
        public void .ctor(){} // RVA: 0x7A7EB9130
        public void AppendEvent(){} // RVA: 0x7A7EB9280
        public void AllocateEvent(){} // RVA: 0x7A7EB9310
        public void Contains(){} // RVA: 0x7A7EB9320
        public void Reset(){} // RVA: 0x7A7EB9390
        public void AdvanceToNextEvent(){} // RVA: 0x7A7EB93B0
        public void GetEnumerator(){} // RVA: 0x7A7EB93D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7EB93E0
        public void Dispose(){} // RVA: 0x7A7EB93F0
        public void Clone(){} // RVA: 0x7A7EB9450
        public void System.ICloneable.Clone(){} // RVA: 0x7A7EB9480
    }

    public class InputEventListener : ValueType
    {
        // ── Methods ──
        public void op_Addition(){} // RVA: 0x7AECBCA40
        public void op_Subtraction(){} // RVA: 0x7AECBCC60
        public void Subscribe(){} // RVA: 0x7A7EB9600
    }

    public class InputEventPtr : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A767FEF0
        public void get_valid(){} // RVA: 0x7A78CF330
        public void get_handled(){} // RVA: 0x7A7EB9610
        public void set_handled(){} // RVA: 0x7A7EB9630
        public void get_id(){} // RVA: 0x7A7EB9640
        public void set_id(){} // RVA: 0x7A7EB9660
        public void get_type(){} // RVA: 0x7A7EB9670
        public void get_sizeInBytes(){} // RVA: 0x7A7EB9690
        public void get_deviceId(){} // RVA: 0x7A7EB96B0
        public void set_deviceId(){} // RVA: 0x7A7EB96D0
        public void get_time(){} // RVA: 0x7A7EB96E0
        public void set_time(){} // RVA: 0x7A7EB9740
        public void get_internalTime(){} // RVA: 0x7A7EB9750
        public void set_internalTime(){} // RVA: 0x7A7EB9770
        public void get_data(){} // RVA: 0x7A765F710
        public void get_stateFormat(){} // RVA: 0x7A7EB9780
        public void get_stateSizeInBytes(){} // RVA: 0x7A7EB9790
        public void get_stateOffset(){} // RVA: 0x7A7EB98C0
        public void IsA(){} // RVA: 0x7A7E01900
        public void Next(){} // RVA: 0x7A7EB99B0
        public void ToString(){} // RVA: 0x7A7EB99E0
        public void ToPointer(){} // RVA: 0x7A765F710
        public void Equals(){} // RVA: 0x7A7EB9A40
        public void GetHashCode(){} // RVA: 0x7A765F070
        public void op_Equality(){} // RVA: 0x7AA68A530
        public void op_Inequality(){} // RVA: 0x7ADCA8000
        public void op_Implicit(){} // RVA: 0x7A97F8BA0
        public void From(){} // RVA: 0x7A97F8BA0
        public void FromInputEventPtr(){} // RVA: 0x7A97F8BA0
    }

    public class InputEventStream : ValueType
    {
        // ── Methods ──
        public void get_isOpen(){} // RVA: 0x7A7EB9B80
        public void get_remainingEventCount(){} // RVA: 0x7A7EB9B90
        public void get_numEventsRetainedInBuffer(){} // RVA: 0x7A76B6E00
        public void get_currentEventPtr(){} // RVA: 0x7A7EB9BA0
        public void get_numBytesRetainedInBuffer(){} // RVA: 0x7A7EB9BC0
        public void .ctor(){} // RVA: 0x7A7EB9C00
        public void Close(){} // RVA: 0x7A7EB9C10
        public void CleanUpAfterException(){} // RVA: 0x7A7EB9C20
        public void Write(){} // RVA: 0x7A7EB9C30
        public void Advance(){} // RVA: 0x7A7EB9C40
        public void Peek(){} // RVA: 0x7A7EB9C50
    }

    public class InputEventTrace : Object
    {
        // ── Methods ──
        public void get_FrameMarkerEvent(){} // RVA: 0x7AECBE410
        public void get_deviceId(){} // RVA: 0x7A851DB90
        public void set_deviceId(){} // RVA: 0x7A8738180
        public void get_enabled(){} // RVA: 0x7A8227C00
        public void get_recordFrameMarkers(){} // RVA: 0x7AB6D7240
        public void set_recordFrameMarkers(){} // RVA: 0x7AECBE420
        public void get_eventCount(){} // RVA: 0x7A8555100
        public void get_totalEventSizeInBytes(){} // RVA: 0x7A87D9C10
        public void get_allocatedSizeInBytes(){} // RVA: 0x7AECBE510
        public void get_maxSizeInBytes(){} // RVA: 0x7A825E100
        public void get_deviceInfos(){} // RVA: 0x7AECBE530
        public void get_onFilterEvent(){} // RVA: 0x7A80DA7B0
        public void set_onFilterEvent(){} // RVA: 0x7A813E420
        public void add_onEvent(){} // RVA: 0x7AECBE600
        public void remove_onEvent(){} // RVA: 0x7AECBE650
        public void .ctor(){} // RVA: 0x7AECBE760
        public void WriteTo(){} // RVA: 0x7AECBE8D0
        public void ReadFrom(){} // RVA: 0x7AECBF110
        public void LoadFrom(){} // RVA: 0x7AECBFC10
        public void Replay(){} // RVA: 0x7AECBFD50
        public void Resize(){} // RVA: 0x7AECBFE40
        public void Clear(){} // RVA: 0x7AECC00F0
        public void Enable(){} // RVA: 0x7AECC0170
        public void Disable(){} // RVA: 0x7AECC02F0
        public void GetNextEvent(){} // RVA: 0x7AECC03F0
        public void GetEnumerator(){} // RVA: 0x7AECC0470
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AECC0470
        public void Dispose(){} // RVA: 0x7AECC0510
        public void get_m_EventBuffer(){} // RVA: 0x7A87C5850
        public void set_m_EventBuffer(){} // RVA: 0x7ADDE2D30
        public void get_m_EventBufferHead(){} // RVA: 0x7A87D9480
        public void set_m_EventBufferHead(){} // RVA: 0x7A9905850
        public void get_m_EventBufferTail(){} // RVA: 0x7A8142610
        public void set_m_EventBufferTail(){} // RVA: 0x7A9905F10
        public void Allocate(){} // RVA: 0x7AECC0610
        public void Release(){} // RVA: 0x7AECC0680
        public void OnBeforeUpdate(){} // RVA: 0x7AECC0780
        public void OnInputEvent(){} // RVA: 0x7AECC0890
        public void get_kFileFormat(){} // RVA: 0x7AECC0EA0
        public void .cctor(){} // RVA: 0x7AECC0EB0
    }

    public class InputMetrics : ValueType
    {
        // ── Methods ──
        public void get_maxNumDevices(){} // RVA: 0x7A765F070
        public void set_maxNumDevices(){} // RVA: 0x7A76134D0
        public void get_currentNumDevices(){} // RVA: 0x7A765F0A0
        public void set_currentNumDevices(){} // RVA: 0x7A765F090
        public void get_maxStateSizeInBytes(){} // RVA: 0x7A75FEFA0
        public void set_maxStateSizeInBytes(){} // RVA: 0x7A767FBC0
        public void get_currentStateSizeInBytes(){} // RVA: 0x7A767FBD0
        public void set_currentStateSizeInBytes(){} // RVA: 0x7A767FBE0
        public void get_currentControlCount(){} // RVA: 0x7A7677B20
        public void set_currentControlCount(){} // RVA: 0x7A7677B10
        public void get_currentLayoutCount(){} // RVA: 0x7A7699630
        public void set_currentLayoutCount(){} // RVA: 0x7A7699640
        public void get_totalEventBytes(){} // RVA: 0x7A768A430
        public void set_totalEventBytes(){} // RVA: 0x7A768A440
        public void get_totalEventCount(){} // RVA: 0x7A768B130
        public void set_totalEventCount(){} // RVA: 0x7A768B140
        public void get_totalUpdateCount(){} // RVA: 0x7A767FF50
        public void set_totalUpdateCount(){} // RVA: 0x7A767FF30
        public void get_totalEventProcessingTime(){} // RVA: 0x7A7EBA200
        public void set_totalEventProcessingTime(){} // RVA: 0x7A7EBA210
        public void get_totalEventLagTime(){} // RVA: 0x7A7EBA220
        public void set_totalEventLagTime(){} // RVA: 0x7A7EBA230
        public void get_averageEventBytesPerFrame(){} // RVA: 0x7A7EBA240
        public void get_averageProcessingTimePerEvent(){} // RVA: 0x7A7EBA260
        public void get_averageLagTimePerEvent(){} // RVA: 0x7A7EBA280
    }

    public class InputRuntimeExtensions : Object
    {
        // ── Methods ──
        public void DeviceCommand(){} // RVA: 0x7AA4DA480
    }

    public class InputState : Object
    {
        // ── Methods ──
        public void get_currentUpdateType(){} // RVA: 0x7AECC56F0
        public void get_updateCount(){} // RVA: 0x7AECC5730
        public void get_currentTime(){} // RVA: 0x7AECC5770
        public void add_onChange(){} // RVA: 0x7AECC57F0
        public void remove_onChange(){} // RVA: 0x7AECC58A0
        public void Change(){} // RVA: 0x7AA4DB200
        public void IsIntegerFormat(){} // RVA: 0x7AECC5C40
        public void AddChangeMonitor(){} // RVA: 0x7AECC5F90
        public void RemoveChangeMonitor(){} // RVA: 0x7AECC6120
        public void AddChangeMonitorTimeout(){} // RVA: 0x7AECC6260
        public void RemoveChangeMonitorTimeout(){} // RVA: 0x7AECC6370
    }

    public class InputStateBlock : ValueType
    {
        // ── Methods ──
        public void GetSizeOfPrimitiveFormatInBits(){} // RVA: 0x7AECC64B0
        public void GetPrimitiveFormatFromType(){} // RVA: 0x7AECC6800
        public void get_format(){} // RVA: 0x7A765F070
        public void set_format(){} // RVA: 0x7A76134D0
        public void get_byteOffset(){} // RVA: 0x7A765F0A0
        public void set_byteOffset(){} // RVA: 0x7A765F090
        public void get_bitOffset(){} // RVA: 0x7A75FEFA0
        public void set_bitOffset(){} // RVA: 0x7A767FBC0
        public void get_sizeInBits(){} // RVA: 0x7A767FBD0
        public void set_sizeInBits(){} // RVA: 0x7A767FBE0
        public void get_alignedSizeInBytes(){} // RVA: 0x7A7EBA310
        public void get_effectiveByteOffset(){} // RVA: 0x7A7EBA360
        public void get_effectiveBitOffset(){} // RVA: 0x7A7EBA3B0
        public void ReadInt(){} // RVA: 0x7A7EBA400
        public void WriteInt(){} // RVA: 0x7A7EBA410
        public void ReadFloat(){} // RVA: 0x7A7EBA420
        public void WriteFloat(){} // RVA: 0x7A7EBA430
        public void FloatToPrimitiveValue(){} // RVA: 0x7A7EBA440
        public void ReadDouble(){} // RVA: 0x7A7EBA470
        public void WriteDouble(){} // RVA: 0x7A7EBA480
        public void Write(){} // RVA: 0x7A7EBA490
        public void CopyToFrom(){} // RVA: 0x7A7EBA4B0
        public void .cctor(){} // RVA: 0x7AECC8C30
    }

    public class InputStateBuffers : ValueType
    {
        // ── Methods ──
        public void GetDoubleBuffersFor(){} // RVA: 0x7A7EBA4C0
        public void GetFrontBufferForDevice(){} // RVA: 0x7AECC8F00
        public void GetBackBufferForDevice(){} // RVA: 0x7AECC8F60
        public void SwitchTo(){} // RVA: 0x7AECC8FC0
        public void AllocateAll(){} // RVA: 0x7A7EBA4F0
        public void SetUpDeviceToBufferMappings(){} // RVA: 0x7AECC91D0
        public void FreeAll(){} // RVA: 0x7A7EBA500
        public void MigrateAll(){} // RVA: 0x7A7EBA510
        public void MigrateDoubleBuffer(){} // RVA: 0x7AECC9560
        public void MigrateSingleBuffer(){} // RVA: 0x7AECC9740
        public void ComputeSizeOfSingleStateBuffer(){} // RVA: 0x7AECC9880
        public void NextDeviceOffset(){} // RVA: 0x7AECC9A10
    }

    public class InputStateHistory : Object
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7A8178B50
        public void get_version(){} // RVA: 0x7A8A22410
        public void get_historyDepth(){} // RVA: 0x7A8178B70
        public void set_historyDepth(){} // RVA: 0x7AECC9C10
        public void get_extraMemoryPerRecord(){} // RVA: 0x7A9231EA0
        public void set_extraMemoryPerRecord(){} // RVA: 0x7AECC9CF0
        public void get_updateMask(){} // RVA: 0x7AECC9DD0
        public void set_updateMask(){} // RVA: 0x7AECC9E80
        public void get_controls(){} // RVA: 0x7AECC9F40
        public void get_Item(){} // RVA: 0x7AECC9FF0
        public void set_Item(){} // RVA: 0x7AECCA170
        public void get_onRecordAdded(){} // RVA: 0x7A80F2570
        public void set_onRecordAdded(){} // RVA: 0x7A80D8E20
        public void get_onShouldRecordStateChange(){} // RVA: 0x7A80DA7B0
        public void set_onShouldRecordStateChange(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AECCA700
        public void Finalize(){} // RVA: 0x7AECCA810
        public void Clear(){} // RVA: 0x7AECCA850
        public void AddRecord(){} // RVA: 0x7AECCA860
        public void StartRecording(){} // RVA: 0x7AECCA930
        public void StopRecording(){} // RVA: 0x7AECCAB10
        public void RecordStateChange(){} // RVA: 0x7AECCB030
        public void GetEnumerator(){} // RVA: 0x7AECCB4C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AECCB4C0
        public void Dispose(){} // RVA: 0x7AECCB570
        public void Destroy(){} // RVA: 0x7AECCB620
        public void Allocate(){} // RVA: 0x7AECCB680
        public void RecordIndexToUserIndex(){} // RVA: 0x7AECCBA20
        public void UserIndexToRecordIndex(){} // RVA: 0x7AECCBA40
        public void GetRecord(){} // RVA: 0x7AECCBA50
        public void GetRecordUnchecked(){} // RVA: 0x7AECCBB40
        public void AllocateRecord(){} // RVA: 0x7AECCBBD0
        public void ReadValue(){} // RVA: 0x7AA4DBFD0
        public void ReadValueAsObject(){} // RVA: 0x7AECCBCA0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7AECCBE70
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7A80D7310
        public void get_bytesPerRecord(){} // RVA: 0x7AECCBFE0
    }

    public class InputStateHistory`1 : InputStateHistory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void Finalize(){} // RVA: 0x7A7E18770
        public void AddRecord(){} // RVA: 0x7A8051B10
        public void RecordStateChange(){} // RVA: 0x7A8051B10
        public void GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
        public void get_Item(){} // RVA: 0x7A8051B10
        public void set_Item(){} // RVA: 0x7A8051B10
    }

    public class InputUpdate : Object
    {
        // ── Methods ──
        public void OnBeforeUpdate(){} // RVA: 0x7AECC3A00
        public void OnUpdate(){} // RVA: 0x7AECC3A80
        public void Save(){} // RVA: 0x7AECC3B00
        public void Restore(){} // RVA: 0x7AECC3B50
        public void GetUpdateTypeForPlayer(){} // RVA: 0x7AECC3BF0
        public void IsPlayerUpdate(){} // RVA: 0x7AECC3C10
    }

    public class InputUpdateDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8234420
        public void Invoke(){} // RVA: 0x7A82344F0
        public void BeginInvoke(){} // RVA: 0x7AECC38B0
        public void EndInvoke(){} // RVA: 0x7A9CE2680
    }

    public class JoystickState : ValueType
    {
        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7AECB9CC0
        public void get_format(){} // RVA: 0x7A7EB8350
    }

    public class KeyboardState : ValueType
    {
        // ── Methods ──
        public void get_Format(){} // RVA: 0x7AECB9CD0
        public void .ctor(){} // RVA: 0x7A7EB8460
        public void Set(){} // RVA: 0x7A7EB8470
        public void Get(){} // RVA: 0x7A7EB84A0
        public void Press(){} // RVA: 0x7A7EB84D0
        public void Release(){} // RVA: 0x7A7EB84F0
        public void get_format(){} // RVA: 0x7A7EB8510
    }

    public class LinearAccelerationState : ValueType
    {
        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7AECBA040
        public void get_format(){} // RVA: 0x7A7EB8640
    }

    public class MouseState : ValueType
    {
        // ── Methods ──
        public void get_Format(){} // RVA: 0x7AECB9F20
        public void WithButton(){} // RVA: 0x7A7EB8520
        public void get_format(){} // RVA: 0x7A7EB8580
    }

    public class NativeInputRuntime : Object
    {
        // ── Methods ──
        public void AllocateDeviceId(){} // RVA: 0x7AECC3C40
        public void Update(){} // RVA: 0x7AECC3CC0
        public void QueueEvent(){} // RVA: 0x7AECC3D50
        public void DeviceCommand(){} // RVA: 0x7AECC3DE0
        public void get_onUpdate(){} // RVA: 0x7A81052C0
        public void set_onUpdate(){} // RVA: 0x7AECC3EE0
        public void get_onBeforeUpdate(){} // RVA: 0x7A8105330
        public void set_onBeforeUpdate(){} // RVA: 0x7AECC4230
        public void get_onShouldRunUpdate(){} // RVA: 0x7A83F69F0
        public void set_onShouldRunUpdate(){} // RVA: 0x7AECC44F0
        public void get_onDeviceDiscovered(){} // RVA: 0x7AECC47B0
        public void set_onDeviceDiscovered(){} // RVA: 0x7AECC4850
        public void get_onShutdown(){} // RVA: 0x7A80DA7B0
        public void set_onShutdown(){} // RVA: 0x7AECC4990
        public void get_onPlayerFocusChanged(){} // RVA: 0x7A8154D80
        public void set_onPlayerFocusChanged(){} // RVA: 0x7AECC4AE0
        public void get_isPlayerFocused(){} // RVA: 0x7AECC4EC0
        public void get_pollingFrequency(){} // RVA: 0x7A8891F60
        public void set_pollingFrequency(){} // RVA: 0x7AECC4F40
        public void get_currentTime(){} // RVA: 0x7AECC4FE0
        public void get_currentTimeForFixedUpdate(){} // RVA: 0x7AECC5060
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7AECC5140
        public void get_unscaledGameTime(){} // RVA: 0x7AECC51C0
        public void get_runInBackground(){} // RVA: 0x7AECC5210
        public void set_runInBackground(){} // RVA: 0x7A81A2210
        public void OnShutdown(){} // RVA: 0x7ABB8BE10
        public void OnWantsToShutdown(){} // RVA: 0x7AECC52A0
        public void OnFocusChanged(){} // RVA: 0x7ADFD63D0
        public void get_screenSize(){} // RVA: 0x7AECC52E0
        public void get_screenOrientation(){} // RVA: 0x7AECC5390
        public void get_isInBatchMode(){} // RVA: 0x7AECC53E0
        public void .ctor(){} // RVA: 0x7AECC5460
        public void .cctor(){} // RVA: 0x7AECC5470
    }

    public class PenState : ValueType
    {
        // ── Methods ──
        public void get_Format(){} // RVA: 0x7AECB9F90
        public void WithButton(){} // RVA: 0x7A7EB8590
        public void get_format(){} // RVA: 0x7A7EB85E0
    }

    public class PointerState : ValueType
    {
        // ── Methods ──
        public void get_kFormat(){} // RVA: 0x7AECB9FF0
        public void get_format(){} // RVA: 0x7A7EB85F0
    }

    public class QueryCanRunInBackground : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB9520
        public void get_typeStatic(){} // RVA: 0x7A7EB7E40
        public void Create(){} // RVA: 0x7AECB9530
    }

    public class QueryDimensionsCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB9550
        public void get_typeStatic(){} // RVA: 0x7A7EB7E50
        public void Create(){} // RVA: 0x7AECB9560
    }

    public class QueryEnabledStateCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB9590
        public void get_typeStatic(){} // RVA: 0x7A7EB7E60
        public void Create(){} // RVA: 0x7AECB95A0
    }

    public class QueryKeyNameCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB9670
        public void ReadKeyName(){} // RVA: 0x7A7EB7EE0
        public void get_typeStatic(){} // RVA: 0x7A7EB7F00
        public void Create(){} // RVA: 0x7AECB96A0
    }

    public class QueryKeyboardLayoutCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB95C0
        public void ReadLayoutName(){} // RVA: 0x7A7EB7E70
        public void WriteLayoutName(){} // RVA: 0x7A7EB7E90
        public void get_typeStatic(){} // RVA: 0x7A7EB7ED0
        public void Create(){} // RVA: 0x7AECB9630
    }

    public class QueryPairedUserAccountCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB96F0
        public void get_id(){} // RVA: 0x7A7EB7F10
        public void set_id(){} // RVA: 0x7A7EB7F30
        public void get_name(){} // RVA: 0x7A7EB8060
        public void set_name(){} // RVA: 0x7A7EB8080
        public void get_typeStatic(){} // RVA: 0x7A7EB81B0
        public void Create(){} // RVA: 0x7AECB99A0
    }

    public class QuerySamplingFrequencyCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB99E0
        public void get_typeStatic(){} // RVA: 0x7A7EB81C0
        public void Create(){} // RVA: 0x7AECB99F0
    }

    public class QueryUserIdCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB9A20
        public void ReadId(){} // RVA: 0x7A7EB7E70
        public void get_typeStatic(){} // RVA: 0x7A7EB81D0
        public void Create(){} // RVA: 0x7AECB9A30
    }

    public class RequestResetCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB9A70
        public void get_typeStatic(){} // RVA: 0x7A7EB81E0
        public void Create(){} // RVA: 0x7AECB9A80
    }

    public class RequestSyncCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB9AA0
        public void get_typeStatic(){} // RVA: 0x7A7EB81F0
        public void Create(){} // RVA: 0x7AECB9AB0
    }

    public class SelectObservable`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18890
        public void Subscribe(){} // RVA: 0x7A7E00B20
    }

    public class SetIMECursorPositionCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB9AD0
        public void get_position(){} // RVA: 0x7A790D9B0
        public void get_typeStatic(){} // RVA: 0x7A7EB8200
        public void Create(){} // RVA: 0x7AECB9AE0
    }

    public class SetSamplingFrequencyCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB9B00
        public void get_typeStatic(){} // RVA: 0x7A7EB8210
        public void Create(){} // RVA: 0x7AECB9B10
    }

    public class StateEvent : ValueType
    {
        // ── Methods ──
        public void get_stateSizeInBytes(){} // RVA: 0x7A7EBA130
        public void get_state(){} // RVA: 0x7A7EBA140
        public void ToEventPtr(){} // RVA: 0x7A7EB8830
        public void get_typeStatic(){} // RVA: 0x7A7EBA150
        public void GetState(){} // RVA: 0x7A8051B10
        public void GetEventSizeWithPayload(){} // RVA: 0x7A7E015C0
        public void From(){} // RVA: 0x7AECC3200
        public void FromUnchecked(){} // RVA: 0x7A97F8BA0
        public void FromDefaultStateFor(){} // RVA: 0x7AECC31D0
    }

    public class TextEvent : ValueType
    {
        // ── Methods ──
        public void get_typeStatic(){} // RVA: 0x7A7EBA160
        public void From(){} // RVA: 0x7AECC35C0
        public void Create(){} // RVA: 0x7AECC37D0
    }

    public class TouchState : ValueType
    {
        // ── Methods ──
        public void get_Format(){} // RVA: 0x7AECBA050
        public void get_phase(){} // RVA: 0x7A7690A70
        public void set_phase(){} // RVA: 0x7A7690A90
        public void get_isNoneEndedOrCanceled(){} // RVA: 0x7A7EB8650
        public void get_isInProgress(){} // RVA: 0x7A7EB8670
        public void get_isPrimaryTouch(){} // RVA: 0x7A7EB8690
        public void set_isPrimaryTouch(){} // RVA: 0x7A7EB86A0
        public void get_isOrphanedPrimaryTouch(){} // RVA: 0x7A7EB86D0
        public void set_isOrphanedPrimaryTouch(){} // RVA: 0x7A7EB86E0
        public void get_isIndirectTouch(){} // RVA: 0x7A7EB8710
        public void set_isIndirectTouch(){} // RVA: 0x7A7EB8720
        public void get_isTap(){} // RVA: 0x7A7EB8750
        public void set_isTap(){} // RVA: 0x7A7EB8760
        public void get_isTapPress(){} // RVA: 0x7A7EB8750
        public void set_isTapPress(){} // RVA: 0x7A7EB8760
        public void get_isTapRelease(){} // RVA: 0x7A7EB8790
        public void set_isTapRelease(){} // RVA: 0x7A7EB87A0
        public void get_beganInSameFrame(){} // RVA: 0x7A7EB87D0
        public void set_beganInSameFrame(){} // RVA: 0x7A7EB87E0
        public void get_format(){} // RVA: 0x7A7EB8810
        public void ToString(){} // RVA: 0x7A7EB8820
    }

    public class TouchscreenState : ValueType
    {
        // ── Methods ──
        public void get_Format(){} // RVA: 0x7AECBA5B0
        public void get_primaryTouch(){} // RVA: 0x7A7EB8830
        public void get_touches(){} // RVA: 0x7A7EB8840
        public void get_format(){} // RVA: 0x7A7EB8850
    }

    public class WarpMousePositionCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AECB9B40
        public void get_typeStatic(){} // RVA: 0x7A7EB8220
        public void Create(){} // RVA: 0x7AECB9B50
    }

}