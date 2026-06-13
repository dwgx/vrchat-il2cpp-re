// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.OscCore.OscCore
// Classes: 46
// Methods: 224

namespace ThirdParty.OscCore.OscCore
{
    public class BlobUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61FCAF0
    }

    public class BoolUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61FC760
    }

    public class ColorUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61FCA20
    }

    public class Constant
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61FCB80
    }

    public class DoubleUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61FC950
    }

    public class ExtensionMethods
    {
        // ── Methods ──
        public void SafeFree(){} // RVA: 0x6205470
        public void ClampPort(){} // RVA: 0x62054F0
    }

    public class FloatUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61FC8C0
    }

    public class IntUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61FC7F0
    }

    public class LongUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61FC830
    }

    public class MessageHandlerBase
    {
        public OscCore.OscReceiver m_Receiver; // 0x20
        public string m_Address; // 0x28

        // ── Methods ──
        public void get_Receiver(){} // RVA: 0x30B0C0
        public void get_Address(){} // RVA: 0x30B130
        public void OnEnable(){} // RVA: 0x61F9B10
        public void OnDisable(){} // RVA: 0x61F9E20
        public void OnValidate(){} // RVA: 0x61F9F30
        public void InvokeEvent(){} // RVA: 0x24A50
        public void ValueRead(){} // RVA: 0x24B10
        public void Update(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x61F9F80
    }

    public class MidiMessage
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x6205140
        public void Equals(){} // RVA: 0x62053B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6205450
    }

    public class MonitorCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61FCCC0
        public void Invoke(){} // RVA: 0x61FCD90
    }

    public class OscActionPair
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61FEB50
        public void op_Addition(){} // RVA: 0x61FECA0
        public void op_Subtraction(){} // RVA: 0x61FEDE0
    }

    public class OscAddressMethods
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6205510
        public void Add(){} // RVA: 0x6205990 | overloaded x2
        public void Remove(){} // RVA: 0x6205A80
        public void RemoveAddress(){} // RVA: 0x6205DA0
        public void TryGetValueFromBytes(){} // RVA: 0x6205F10
        public void Dispose(){} // RVA: 0x6205FA0
    }

    public class OscAddressSpace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61FEF20
        public void TryAddMethod(){} // RVA: 0x61FF4B0
        public void RemoveAddressMethod(){} // RVA: 0x61FF870
        public void RemoveMethod(){} // RVA: 0x61FFA10
        public void TryMatchPatternHandler(){} // RVA: 0x61FFC60
        public void EscapeRegexSpecialCharacters(){} // RVA: 0x61FFE30
    }

    public class OscBlobMessageHandler
    {
        public OscCore.BlobUnityEvent OnMessageReceived; // 0x40
        public byte[] m_Buffer; // 0x48

        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x358730
        public void get_LastReceivedBlobLength(){} // RVA: 0x59C540
        public void set_LastReceivedBlobLength(){} // RVA: 0x65F570
        public void ValueRead(){} // RVA: 0x61F9330
        public void InvokeEvent(){} // RVA: 0x61F9430
        public void .ctor(){} // RVA: 0x61F9490
    }

    public class OscBooleanMessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x61F9520
        public void .ctor(){} // RVA: 0x61F9590
    }

    public class OscClient
    {
        public System.Net.Sockets.Socket _writer; // 0x10
        public OscCore.OscWriter m_Writer; // 0x18

        // ── Methods ──
        public void get_Writer(){} // RVA: 0x2E07C0
        public void get_Destination(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x6200110
        public void Send(){} // RVA: 0x6200C80 | overloaded x10
        public void ForceSendBuffer(){} // RVA: 0x6200CF0
    }

    public class OscColorMessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x61F95D0
        public void .ctor(){} // RVA: 0x61F9790
    }

    public class OscFloat64MessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x61F97D0
        public void .ctor(){} // RVA: 0x61F9800
    }

    public class OscFloatMessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x61F9840
        public void .ctor(){} // RVA: 0x61F9870
    }

    public class OscInt64MessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x61F98B0
        public void .ctor(){} // RVA: 0x61F98E0
    }

    public class OscIntMessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x61F9920
        public void .ctor(){} // RVA: 0x61F9950
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x24A50
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x3DD6C30
        public void .ctor(){} // RVA: 0x3DD6BA0
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x3DD6CB0
        public void .ctor(){} // RVA: 0x3DD6BA0
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x3DD6BB0
        public void .ctor(){} // RVA: 0x3DD6BA0
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x3DD6BF0
        public void .ctor(){} // RVA: 0x3DD6BA0
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x3DD6CF0
        public void .ctor(){} // RVA: 0x3DD6BA0
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x3DD6D30
        public void .ctor(){} // RVA: 0x3DD6BA0
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x3DD6C70
        public void .ctor(){} // RVA: 0x3DD6BA0
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x3DD6B60
        public void .ctor(){} // RVA: 0x3DD6BA0
    }

    public class OscMessageValues
    {
        public int instance;

        // ── Methods ──
        public void ReadBlobElement(){} // RVA: 0x61FCE60
        public void ReadBooleanElement(){} // RVA: 0x13FCFC0
        public void ReadColor32Element(){} // RVA: 0x61FCF60
        public void get_ElementCount(){} // RVA: 0x10E5CF0
        public void set_ElementCount(){} // RVA: 0x475080
        public void .ctor(){} // RVA: 0x61FD080
        public void Finalize(){} // RVA: 0x61FD380
        public void ForEachElement(){} // RVA: 0x61FD4A0
        public void ReadFloatElement(){} // RVA: 0x61FD520
        public void ReadFloat64Element(){} // RVA: 0x61FD660
        public void ReadIntElement(){} // RVA: 0x61FDAB0
        public void ReadIntElementUnchecked(){} // RVA: 0x13FD190
        public void ReadUIntIndex(){} // RVA: 0x61FDC70
        public void ReadIntIndex(){} // RVA: 0x61FDD60
        public void ReadInt64Element(){} // RVA: 0x61FDDF0
        public void ReadStringElement(){} // RVA: 0x61FE240
        public void ReadTimestampIndex(){} // RVA: 0x61FEB30
    }

    public class OscParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6200D30
        public void Parse(){} // RVA: 0x6200F20 | overloaded x2
        public void AddressIsValid(){} // RVA: 0x6200FB0
        public void CharacterIsValidInAddress(){} // RVA: 0x6201040
        public void GetAddressType(){} // RVA: 0x6201090
        public void ParseTags(){} // RVA: 0x62011B0
        public void FindUnalignedAddressLength(){} // RVA: 0x6201340 | overloaded x2
        public void GetStringLength(){} // RVA: 0x6201380
        public void FindOffsets(){} // RVA: 0x62013E0
        public void IsBundleTagAtIndex(){} // RVA: 0x6201560
    }

    public class OscReceiver
    {
        public int m_Port; // 0x20
        public bool <Running>k__BackingField; // 0x24
        public OscCore.OscServer <Server>k__BackingField; // 0x28

        // ── Methods ──
        public void get_Port(){} // RVA: 0x760030
        public void set_Port(){} // RVA: 0x61FA050
        public void get_Running(){} // RVA: 0x2F87C0
        public void set_Running(){} // RVA: 0x4D7670
        public void get_Server(){} // RVA: 0x30B130
        public void set_Server(){} // RVA: 0x2DEE90
        public void OnEnable(){} // RVA: 0x61FA060
        public void Awake(){} // RVA: 0x61FA060
        public void OnStart(){} // RVA: 0x61FA070
        public void OnValidate(){} // RVA: 0x61FA120
        public void Update(){} // RVA: 0x61FA140
        public void OnDestroy(){} // RVA: 0x61FA160
        public void SetPort(){} // RVA: 0x61FA1E0
        public void .ctor(){} // RVA: 0x61FA320
    }

    public class OscSender
    {
        public string captureButton; // 0x20
        public int homeButton; // 0x28
        public OscCore.OscClient <Client>k__BackingField; // 0x30

        // ── Methods ──
        public void get_IpAddress(){} // RVA: 0x30B0C0
        public void set_IpAddress(){} // RVA: 0x61FA370
        public void get_Port(){} // RVA: 0x791DC0
        public void set_Port(){} // RVA: 0x61FA5A0
        public void get_Client(){} // RVA: 0x6374D0
        public void set_Client(){} // RVA: 0x30B890
        public void OnEnable(){} // RVA: 0x61FA600
        public void Awake(){} // RVA: 0x61FA600
        public void OnValidate(){} // RVA: 0x61FA610
        public void Setup(){} // RVA: 0x61FA630
        public void ReInitialize(){} // RVA: 0x61FA700
        public void .ctor(){} // RVA: 0x61FA760
    }

    public class OscServer
    {
        public System.Collections.Generic.Dictionary`2<System.Action`1<OscCore.OscMessageValues>,OscCore.OscActionPair> k_SingleCallbackToPair;
        public OscCore.OscSocket m_Socket; // 0x10
        public bool m_Disposed; // 0x18
        public bool m_Started; // 0x19
        public byte[] m_ReadBuffer; // 0x20

        // ── Methods ──
        public void set_Running(){} // RVA: 0x306030
        public void get_Port(){} // RVA: 0x59C4F0
        public void get_AddressSpace(){} // RVA: 0x358D50
        public void set_AddressSpace(){} // RVA: 0x358D60
        public void get_Parser(){} // RVA: 0x3A5590
        public void set_LastBundleTimestamp(){} // RVA: 0x5AAF010
        public void .ctor(){} // RVA: 0x62015E0
        public void Start(){} // RVA: 0x6201F00
        public void GetOrCreate(){} // RVA: 0x62020C0
        public void TryAddMethod(){} // RVA: 0x6202210
        public void RemoveMethod(){} // RVA: 0x6202320
        public void RemoveAddress(){} // RVA: 0x6202660
        public void TryAddMethodPair(){} // RVA: 0x6202810
        public void RemoveMethodPair(){} // RVA: 0x6202830
        public void AddMonitorCallback(){} // RVA: 0x6202850
        public void RemoveMonitorCallback(){} // RVA: 0x62028C0
        public void Update(){} // RVA: 0x6202920
        public void ParseBuffer(){} // RVA: 0x6202990
        public void HandleCallbacks(){} // RVA: 0x6202FA0
        public void HandleMonitorCallbacks(){} // RVA: 0x6203060
        public void TryMatchPatterns(){} // RVA: 0x6203280
        public void OverwriteAsciiString(){} // RVA: 0x62038B0
        public void Dispose(){} // RVA: 0x6203900
        public void Finalize(){} // RVA: 0x6203A80
        public void .cctor(){} // RVA: 0x6203AC0
    }

    public class OscSocket
    {
        public System.Net.Sockets.Socket m_Socket; // 0x10
        public System.Threading.Thread m_Thread; // 0x18

        // ── Methods ──
        public void get_Port(){} // RVA: 0x4C6670
        public void get_Server(){} // RVA: 0x4976A0
        public void set_Server(){} // RVA: 0x49B830
        public void .ctor(){} // RVA: 0x6203C60
        public void Start(){} // RVA: 0x6203E80
        public void Serve(){} // RVA: 0x6204010
        public void Dispose(){} // RVA: 0x6204360
    }

    public class OscStringMessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x61F9990
        public void .ctor(){} // RVA: 0x61F9A10
    }

    public class OscVector3MessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x61F9A50
        public void .ctor(){} // RVA: 0x61F9AD0
    }

    public class OscWriter
    {
        public byte[] Buffer; // 0x10

        // ── Methods ──
        public void get_Length(){} // RVA: 0x1AE3800
        public void .ctor(){} // RVA: 0x6204550
        public void Finalize(){} // RVA: 0x6204860
        public void Reset(){} // RVA: 0x62048D0
        public void Write(){} // RVA: 0x6204E20 | overloaded x8
        public void WriteCurrentTimestamp(){} // RVA: 0x6204F00
        public void WriteBundlePrefix(){} // RVA: 0x6204F90
        public void WriteAddressAndTags(){} // RVA: 0x6205010
        public void Dispose(){} // RVA: 0x6205100
    }

    public class PropertyOutput
    {
        public OscCore.OscSender m_Sender; // 0x20
        public string m_Address; // 0x28
        public UnityEngine.GameObject m_Object; // 0x30
        public UnityEngine.Component m_SourceComponent; // 0x38

        // ── Methods ──
        public void get_Sender(){} // RVA: 0x30B0C0
        public void set_Sender(){} // RVA: 0x61FA830
        public void get_SourceComponent(){} // RVA: 0x4976A0
        public void set_SourceComponent(){} // RVA: 0x61FA960
        public void get_Property(){} // RVA: 0x348040
        public void set_Property(){} // RVA: 0x61FAA90
        public void get_Field(){} // RVA: 0x3480B0
        public void set_Field(){} // RVA: 0x61FABB0
        public void OnEnable(){} // RVA: 0x61FACD0
        public void OnValidate(){} // RVA: 0x61FAED0
        public void Update(){} // RVA: 0x61FB150
        public void SendVector2(){} // RVA: 0x61FBDD0
        public void SendVector3(){} // RVA: 0x61FBF60
        public void ValueChanged(){} // RVA: 0x114C0
        public void GetObjectComponents(){} // RVA: 0x61FC190
        public void SetPropertyFromSerialized(){} // RVA: 0x61FC2A0
        public void .ctor(){} // RVA: 0x61FC690
    }

    public class StringUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61FC9E0
    }

    public class TypeTagMethods
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x61FCDC0
    }

    public class Utils
    {
        // ── Methods ──
        public void ValidateAddress(){} // RVA: 0x6206180
        public void ReplaceInvalidAddressCharacters(){} // RVA: 0x62063F0
        public void PinPtr(){} // RVA: 0x283FA0
        public void GetLocalIpAddress(){} // RVA: 0x6206630
        public void MonitorMessageToString(){} // RVA: 0x62066E0
        public void .cctor(){} // RVA: 0x6206B10
    }

    public class Vector3UnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61FCA60
    }

}