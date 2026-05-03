// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.OscCore.OscCore
// Classes: 38
// Methods: 208

namespace ThirdParty.OscCore.OscCore
{
    public class BlobUnityEvent : UnityEvent`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D3D990
    }

    public class BoolUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D3D600
    }

    public class ColorUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D3D8C0
    }

    public class Constant : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86D3DA20
    }

    public class DoubleUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D3D7F0
    }

    public class ExtensionMethods : Object
    {
        // ── Methods ──
        public void SafeFree(){} // RVA: 0x7FFE86D46310
        public void ClampPort(){} // RVA: 0x7FFE86D46390
    }

    public class FloatUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D3D760
    }

    public class IntUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D3D690
    }

    public class LongUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D3D6D0
    }

    public class MessageHandlerBase : MonoBehaviour
    {
        public OscCore.OscReceiver m_Receiver; // 0x20
        public string m_Address; // 0x28

        // ── Methods ──
        public void get_Receiver(){} // RVA: 0x7FFE811290C0
        public void get_Address(){} // RVA: 0x7FFE81129130
        public void OnEnable(){} // RVA: 0x7FFE86D3A9B0
        public void OnDisable(){} // RVA: 0x7FFE86D3ACC0
        public void OnValidate(){} // RVA: 0x7FFE86D3ADD0
        public void InvokeEvent(){} // RVA: 0x7FFE80E45FE0
        public void ValueRead(){} // RVA: 0x7FFE80E460A0
        public void Update(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE86D3AE20
    }

    public class MidiMessage : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE86D45FE0
        public void Equals(){} // RVA: 0x7FFE86D46250 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86D462F0
    }

    public class MonitorCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D3DB60
        public void Invoke(){} // RVA: 0x7FFE86D3DC30
    }

    public class OscActionPair : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D3F9F0
        public void op_Addition(){} // RVA: 0x7FFE86D3FB40
        public void op_Subtraction(){} // RVA: 0x7FFE86D3FC80
    }

    public class OscAddressMethods : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D463B0
        public void Add(){} // RVA: 0x7FFE86D46830 | overloaded x2
        public void Remove(){} // RVA: 0x7FFE86D46920
        public void RemoveAddress(){} // RVA: 0x7FFE86D46C40
        public void TryGetValueFromBytes(){} // RVA: 0x7FFE86D46DB0
        public void Dispose(){} // RVA: 0x7FFE86D46E40
    }

    public class OscAddressSpace : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D3FDC0
        public void TryAddMethod(){} // RVA: 0x7FFE86D40350
        public void RemoveAddressMethod(){} // RVA: 0x7FFE86D40710
        public void RemoveMethod(){} // RVA: 0x7FFE86D408B0
        public void TryMatchPatternHandler(){} // RVA: 0x7FFE86D40B00
        public void EscapeRegexSpecialCharacters(){} // RVA: 0x7FFE86D40CD0
    }

    public class OscBlobMessageHandler : MessageHandlerBase
    {
        public OscCore.BlobUnityEvent OnMessageReceived; // 0x40
        public byte[] m_Buffer; // 0x48

        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x7FFE81176730
        public void get_LastReceivedBlobLength(){} // RVA: 0x7FFE8139DAD0
        public void set_LastReceivedBlobLength(){} // RVA: 0x7FFE81463B00
        public void ValueRead(){} // RVA: 0x7FFE86D3A1D0
        public void InvokeEvent(){} // RVA: 0x7FFE86D3A2D0
        public void .ctor(){} // RVA: 0x7FFE86D3A330
    }

    public class OscBooleanMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFE86D3A3C0
        public void .ctor(){} // RVA: 0x7FFE86D3A430
    }

    public class OscClient : Object
    {
        public System.Net.Sockets.Socket m_Socket; // 0x10
        public OscCore.OscWriter m_Writer; // 0x18

        // ── Methods ──
        public void get_Writer(){} // RVA: 0x7FFE810FE7C0
        public void get_Destination(){} // RVA: 0x7FFE811290C0
        public void .ctor(){} // RVA: 0x7FFE86D40FB0
        public void Send(){} // RVA: 0x7FFE86D41B20 | overloaded x10
        public void ForceSendBuffer(){} // RVA: 0x7FFE86D41B90
    }

    public class OscColorMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFE86D3A470
        public void .ctor(){} // RVA: 0x7FFE86D3A630
    }

    public class OscFloat64MessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFE86D3A670
        public void .ctor(){} // RVA: 0x7FFE86D3A6A0
    }

    public class OscFloatMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFE86D3A6E0
        public void .ctor(){} // RVA: 0x7FFE86D3A710
    }

    public class OscInt64MessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFE86D3A750
        public void .ctor(){} // RVA: 0x7FFE86D3A780
    }

    public class OscIntMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFE86D3A7C0
        public void .ctor(){} // RVA: 0x7FFE86D3A7F0
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class OscMessageValues : Object
    {
        public int k_ResizeByteHeadroom;

        // ── Methods ──
        public void ReadBlobElement(){} // RVA: 0x7FFE86D3DD00
        public void ReadBooleanElement(){} // RVA: 0x7FFE82177CD0
        public void ReadColor32Element(){} // RVA: 0x7FFE86D3DE00
        public void get_ElementCount(){} // RVA: 0x7FFE81E60180
        public void set_ElementCount(){} // RVA: 0x7FFE81293CF0
        public void .ctor(){} // RVA: 0x7FFE86D3DF20
        public void Finalize(){} // RVA: 0x7FFE86D3E220
        public void ForEachElement(){} // RVA: 0x7FFE86D3E340
        public void ReadFloatElement(){} // RVA: 0x7FFE86D3E3C0
        public void ReadFloat64Element(){} // RVA: 0x7FFE86D3E500
        public void ReadIntElement(){} // RVA: 0x7FFE86D3E950
        public void ReadIntElementUnchecked(){} // RVA: 0x7FFE82177EA0
        public void ReadUIntIndex(){} // RVA: 0x7FFE86D3EB10
        public void ReadIntIndex(){} // RVA: 0x7FFE86D3EC00
        public void ReadInt64Element(){} // RVA: 0x7FFE86D3EC90
        public void ReadStringElement(){} // RVA: 0x7FFE86D3F0E0
        public void ReadTimestampIndex(){} // RVA: 0x7FFE86D3F9D0
    }

    public class OscParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D41BD0
        public void Parse(){} // RVA: 0x7FFE86D41DC0 | overloaded x2
        public void AddressIsValid(){} // RVA: 0x7FFE86D41E50
        public void CharacterIsValidInAddress(){} // RVA: 0x7FFE86D41EE0
        public void GetAddressType(){} // RVA: 0x7FFE86D41F30
        public void ParseTags(){} // RVA: 0x7FFE86D42050
        public void FindUnalignedAddressLength(){} // RVA: 0x7FFE86D421E0 | overloaded x2
        public void GetStringLength(){} // RVA: 0x7FFE86D42220
        public void FindOffsets(){} // RVA: 0x7FFE86D42280
        public void IsBundleTagAtIndex(){} // RVA: 0x7FFE86D42400
    }

    public class OscReceiver : MonoBehaviour
    {
        public int m_Port; // 0x20
        public bool _running; // 0x24
        public OscCore.OscServer _server; // 0x28

        // ── Methods ──
        public void get_Port(){} // RVA: 0x7FFE8151D690
        public void set_Port(){} // RVA: 0x7FFE86D3AEF0
        public void get_Running(){} // RVA: 0x7FFE811167C0
        public void set_Running(){} // RVA: 0x7FFE812EB1B0
        public void get_Server(){} // RVA: 0x7FFE81129130
        public void set_Server(){} // RVA: 0x7FFE810FCE90
        public void OnEnable(){} // RVA: 0x7FFE86D3AF00
        public void Awake(){} // RVA: 0x7FFE86D3AF00
        public void OnStart(){} // RVA: 0x7FFE86D3AF10
        public void OnValidate(){} // RVA: 0x7FFE86D3AFC0
        public void Update(){} // RVA: 0x7FFE86D3AFE0
        public void OnDestroy(){} // RVA: 0x7FFE86D3B000
        public void SetPort(){} // RVA: 0x7FFE86D3B080
        public void .ctor(){} // RVA: 0x7FFE86D3B1C0
    }

    public class OscSender : MonoBehaviour
    {
        public string m_IpAddress; // 0x20
        public int m_Port; // 0x28
        public OscCore.OscClient _client; // 0x30

        // ── Methods ──
        public void get_IpAddress(){} // RVA: 0x7FFE811290C0
        public void set_IpAddress(){} // RVA: 0x7FFE86D3B210
        public void get_Port(){} // RVA: 0x7FFE81549710
        public void set_Port(){} // RVA: 0x7FFE86D3B440
        public void get_Client(){} // RVA: 0x7FFE8144E200
        public void set_Client(){} // RVA: 0x7FFE81129890
        public void OnEnable(){} // RVA: 0x7FFE86D3B4A0
        public void Awake(){} // RVA: 0x7FFE86D3B4A0
        public void OnValidate(){} // RVA: 0x7FFE86D3B4B0
        public void Setup(){} // RVA: 0x7FFE86D3B4D0
        public void ReInitialize(){} // RVA: 0x7FFE86D3B5A0
        public void .ctor(){} // RVA: 0x7FFE86D3B600
    }

    public class OscServer : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Action`1<OscCore.OscMessageValues>,OscCore.OscActionPair> k_SingleCallbackToPair;
        public OscCore.OscSocket m_Socket; // 0x10
        public bool m_Disposed; // 0x18
        public bool m_Started; // 0x19
        public byte[] m_ReadBuffer; // 0x20

        // ── Methods ──
        public void set_Running(){} // RVA: 0x7FFE81124030
        public void get_Port(){} // RVA: 0x7FFE8139DA60
        public void get_AddressSpace(){} // RVA: 0x7FFE81176D50
        public void set_AddressSpace(){} // RVA: 0x7FFE81176D60
        public void get_Parser(){} // RVA: 0x7FFE811C3590
        public void set_LastBundleTimestamp(){} // RVA: 0x7FFE865EFE40
        public void .ctor(){} // RVA: 0x7FFE86D42480
        public void Start(){} // RVA: 0x7FFE86D42DA0
        public void GetOrCreate(){} // RVA: 0x7FFE86D42F60
        public void TryAddMethod(){} // RVA: 0x7FFE86D430B0
        public void RemoveMethod(){} // RVA: 0x7FFE86D431C0
        public void RemoveAddress(){} // RVA: 0x7FFE86D43500
        public void TryAddMethodPair(){} // RVA: 0x7FFE86D436B0
        public void RemoveMethodPair(){} // RVA: 0x7FFE86D436D0
        public void AddMonitorCallback(){} // RVA: 0x7FFE86D436F0
        public void RemoveMonitorCallback(){} // RVA: 0x7FFE86D43760
        public void Update(){} // RVA: 0x7FFE86D437C0
        public void ParseBuffer(){} // RVA: 0x7FFE86D43830
        public void HandleCallbacks(){} // RVA: 0x7FFE86D43E40
        public void HandleMonitorCallbacks(){} // RVA: 0x7FFE86D43F00
        public void TryMatchPatterns(){} // RVA: 0x7FFE86D44120
        public void OverwriteAsciiString(){} // RVA: 0x7FFE86D44750
        public void Dispose(){} // RVA: 0x7FFE86D447A0
        public void Finalize(){} // RVA: 0x7FFE86D44920
        public void .cctor(){} // RVA: 0x7FFE86D44960
    }

    public class OscSocket : Object
    {
        public System.Net.Sockets.Socket m_Socket; // 0x10
        public System.Threading.Thread m_Thread; // 0x18

        // ── Methods ──
        public void get_Port(){} // RVA: 0x7FFE82447220
        public void get_Server(){} // RVA: 0x7FFE8143BA80
        public void set_Server(){} // RVA: 0x7FFE81437330
        public void .ctor(){} // RVA: 0x7FFE86D44B00
        public void Start(){} // RVA: 0x7FFE86D44D20
        public void Serve(){} // RVA: 0x7FFE86D44EB0
        public void Dispose(){} // RVA: 0x7FFE86D45200
    }

    public class OscStringMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFE86D3A830
        public void .ctor(){} // RVA: 0x7FFE86D3A8B0
    }

    public class OscVector3MessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFE86D3A8F0
        public void .ctor(){} // RVA: 0x7FFE86D3A970
    }

    public class OscWriter : Object
    {
        public byte[] Buffer; // 0x10

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFE8286C0A0
        public void .ctor(){} // RVA: 0x7FFE86D453F0
        public void Finalize(){} // RVA: 0x7FFE86D45700
        public void Reset(){} // RVA: 0x7FFE86D45770
        public void Write(){} // RVA: 0x7FFE86D45CC0 | overloaded x8
        public void WriteCurrentTimestamp(){} // RVA: 0x7FFE86D45DA0
        public void WriteBundlePrefix(){} // RVA: 0x7FFE86D45E30
        public void WriteAddressAndTags(){} // RVA: 0x7FFE86D45EB0
        public void Dispose(){} // RVA: 0x7FFE86D45FA0
    }

    public class PropertyOutput : MonoBehaviour
    {
        public OscCore.OscSender m_Sender; // 0x20
        public string m_Address; // 0x28
        public UnityEngine.GameObject m_Object; // 0x30
        public UnityEngine.Component m_SourceComponent; // 0x38

        // ── Methods ──
        public void get_Sender(){} // RVA: 0x7FFE811290C0
        public void set_Sender(){} // RVA: 0x7FFE86D3B6D0
        public void get_SourceComponent(){} // RVA: 0x7FFE8143BA80
        public void set_SourceComponent(){} // RVA: 0x7FFE86D3B800
        public void get_Property(){} // RVA: 0x7FFE81166040
        public void set_Property(){} // RVA: 0x7FFE86D3B930
        public void get_Field(){} // RVA: 0x7FFE811660B0
        public void set_Field(){} // RVA: 0x7FFE86D3BA50
        public void OnEnable(){} // RVA: 0x7FFE86D3BB70
        public void OnValidate(){} // RVA: 0x7FFE86D3BD70
        public void Update(){} // RVA: 0x7FFE86D3BFF0
        public void SendVector2(){} // RVA: 0x7FFE86D3CC70
        public void SendVector3(){} // RVA: 0x7FFE86D3CE00
        public void ValueChanged(){} // RVA: 0x7FFE80E329F0
        public void GetObjectComponents(){} // RVA: 0x7FFE86D3D030
        public void SetPropertyFromSerialized(){} // RVA: 0x7FFE86D3D140
        public void .ctor(){} // RVA: 0x7FFE86D3D530
    }

    public class StringUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D3D880
    }

    public class TypeTagMethods : Object
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7FFE86D3DC60
    }

    public class Utils : Object
    {
        // ── Methods ──
        public void ValidateAddress(){} // RVA: 0x7FFE86D47020
        public void ReplaceInvalidAddressCharacters(){} // RVA: 0x7FFE86D47290
        public void PinPtr(){} // RVA: 0x7FFE810A1420
        public void GetLocalIpAddress(){} // RVA: 0x7FFE86D474D0
        public void MonitorMessageToString(){} // RVA: 0x7FFE86D47580
        public void .cctor(){} // RVA: 0x7FFE86D479B0
    }

    public class Vector3UnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D3D900
    }

}