// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.OscCore.OscCore
// Classes: 48
// Methods: 238

namespace ThirdParty.OscCore.OscCore
{
    public class BlobUnityEvent : UnityEvent`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFE98B0
    }

    public class BoolUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFE9520
    }

    public class ColorUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFE97E0
    }

    public class Constant : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADFE9940
    }

    public class DoubleUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFE9710
    }

    public class ExtensionMethods : Object
    {
        // ── Methods ──
        public void SafeFree(){} // RVA: 0x7ADFF2280
        public void ClampPort(){} // RVA: 0x7ADFF2300
    }

    public class FloatUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFE9680
    }

    public class IntUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFE95B0
    }

    public class LongUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFE95F0
    }

    public class MessageHandlerBase : MonoBehaviour
    {
        // ── Methods ──
        public void get_Receiver(){} // RVA: 0x7A81052C0
        public void get_Address(){} // RVA: 0x7A8105330
        public void OnEnable(){} // RVA: 0x7ADFE69D0
        public void OnDisable(){} // RVA: 0x7ADFE6CE0
        public void OnValidate(){} // RVA: 0x7ADFE6DF0
        public void InvokeEvent(){} // RVA: 0x7A7E18770
        public void ValueRead(){} // RVA: 0x7A7E18800
        public void Update(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ADFE6E40
    }

    public class MidiMessage : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7A7E652A0
        public void Equals(){} // RVA: 0x7A7E652E0
        public void GetHashCode(){} // RVA: 0x7A7E65380
    }

    public class MonitorCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFE9A80
        public void Invoke(){} // RVA: 0x7ADFE9B50
    }

    public class OscActionPair : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFEB940
        public void op_Addition(){} // RVA: 0x7ADFEBA90
        public void op_Subtraction(){} // RVA: 0x7ADFEBBD0
    }

    public class OscActionPair[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class OscAddressMethods : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFF2320
        public void Add(){} // RVA: 0x7ADFF27A0
        public void Remove(){} // RVA: 0x7ADFF28A0
        public void RemoveAddress(){} // RVA: 0x7ADFF2BE0
        public void TryGetValueFromBytes(){} // RVA: 0x7ADFF2D50
        public void Dispose(){} // RVA: 0x7ADFF2DE0
    }

    public class OscAddressSpace : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFEBD10
        public void TryAddMethod(){} // RVA: 0x7ADFEC2A0
        public void RemoveAddressMethod(){} // RVA: 0x7ADFEC660
        public void RemoveMethod(){} // RVA: 0x7ADFEC800
        public void TryMatchPatternHandler(){} // RVA: 0x7ADFECA70
        public void EscapeRegexSpecialCharacters(){} // RVA: 0x7ADFECC40
        public void k_DefaultPatternCapacity(){} // RVA: 0x7B2EA2A30
    }

    public class OscBlobMessageHandler : MessageHandlerBase
    {
        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x7A8152D80
        public void get_LastReceivedBlobLength(){} // RVA: 0x7A8355950
        public void set_LastReceivedBlobLength(){} // RVA: 0x7A83F4180
        public void ValueRead(){} // RVA: 0x7ADFE61F0
        public void InvokeEvent(){} // RVA: 0x7ADFE62F0
        public void .ctor(){} // RVA: 0x7ADFE6350
    }

    public class OscBooleanMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7ADFE63E0
        public void .ctor(){} // RVA: 0x7ADFE6450
    }

    public class OscClient : Object
    {
        // ── Methods ──
        public void get_Writer(){} // RVA: 0x7A80DA7B0
        public void get_Destination(){} // RVA: 0x7A81052C0
        public void .ctor(){} // RVA: 0x7ADFECD70
        public void Send(){} // RVA: 0x7ADFED8F0
        public void ForceSendBuffer(){} // RVA: 0x7ADFED960
        // ── Unresolved (hash) ──
        public void m_Socket(){} // RVA: 0x7B3FB4428
    }

    public class OscColorMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7ADFE6490
        public void .ctor(){} // RVA: 0x7ADFE6650
    }

    public class OscFloat64MessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7ADFE6690
        public void .ctor(){} // RVA: 0x7ADFE66C0
    }

    public class OscFloatMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7ADFE6700
        public void .ctor(){} // RVA: 0x7ADFE6730
    }

    public class OscInt64MessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7ADFE6770
        public void .ctor(){} // RVA: 0x7ADFE67A0
    }

    public class OscIntMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7ADFE67E0
        public void .ctor(){} // RVA: 0x7ADFE6810
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7A7E18770
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7ABBD13B0
        public void .ctor(){} // RVA: 0x7ABBD1320
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7ABBD1430
        public void .ctor(){} // RVA: 0x7ABBD1320
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7ABBD1330
        public void .ctor(){} // RVA: 0x7ABBD1320
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7ABBD1370
        public void .ctor(){} // RVA: 0x7ABBD1320
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7ABBD1470
        public void .ctor(){} // RVA: 0x7ABBD1320
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7ABBD14B0
        public void .ctor(){} // RVA: 0x7ABBD1320
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7ABBD13F0
        public void .ctor(){} // RVA: 0x7ABBD1320
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7ABBD12E0
        public void .ctor(){} // RVA: 0x7ABBD1320
    }

    public class OscMessageValues : Object
    {
        // ── Methods ──
        public void ReadBlobElement(){} // RVA: 0x7ADFE9C20
        public void ReadBooleanElement(){} // RVA: 0x7A91B4B30
        public void ReadColor32Element(){} // RVA: 0x7ADFE9D20
        public void get_ElementCount(){} // RVA: 0x7A8EA8210
        public void set_ElementCount(){} // RVA: 0x7A8270510
        public void .ctor(){} // RVA: 0x7ADFE9E40
        public void Finalize(){} // RVA: 0x7ADFEA140
        public void ForEachElement(){} // RVA: 0x7ADFEA260
        public void ReadFloatElement(){} // RVA: 0x7ADFEA2E0
        public void ReadFloat64Element(){} // RVA: 0x7ADFEA420
        public void ReadIntElement(){} // RVA: 0x7ADFEA880
        public void ReadIntElementUnchecked(){} // RVA: 0x7A91B4D00
        public void ReadUIntIndex(){} // RVA: 0x7ADFEAA50
        public void ReadIntIndex(){} // RVA: 0x7ADFEAB40
        public void ReadInt64Element(){} // RVA: 0x7ADFEABD0
        public void ReadStringElement(){} // RVA: 0x7ADFEB020
        public void ReadTimestampIndex(){} // RVA: 0x7ADFEB920
        public void k_ResizeByteHeadroom(){} // RVA: 0x7B3FB4328
    }

    public class OscParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFED9A0
        public void Parse(){} // RVA: 0x7ADFEDB90
        public void AddressIsValid(){} // RVA: 0x7ADFEDC30
        public void CharacterIsValidInAddress(){} // RVA: 0x7ADFEDCD0
        public void GetAddressType(){} // RVA: 0x7ADFEDD20
        public void ParseTags(){} // RVA: 0x7ADFEDE70
        public void FindUnalignedAddressLength(){} // RVA: 0x7ADFEE010
        public void GetStringLength(){} // RVA: 0x7ADFEE050
        public void FindOffsets(){} // RVA: 0x7ADFEE0B0
        public void IsBundleTagAtIndex(){} // RVA: 0x7ADFEE250
        public void MaxElementsPerMessage(){} // RVA: 0x7B3FB4328
    }

    public class OscReceiver : MonoBehaviour
    {
        // ── Methods ──
        public void get_Port(){} // RVA: 0x7A851DB90
        public void set_Port(){} // RVA: 0x7ADFE6F10
        public void get_Running(){} // RVA: 0x7A80F29B0
        public void set_Running(){} // RVA: 0x7A9727920
        public void get_Server(){} // RVA: 0x7A8105330
        public void set_Server(){} // RVA: 0x7A80D8E80
        public void OnEnable(){} // RVA: 0x7ADFE6F20
        public void Awake(){} // RVA: 0x7ADFE6F20
        public void OnStart(){} // RVA: 0x7ADFE6F30
        public void OnValidate(){} // RVA: 0x7ADFE6FE0
        public void Update(){} // RVA: 0x7ADFE7000
        public void OnDestroy(){} // RVA: 0x7ADFE7020
        public void SetPort(){} // RVA: 0x7ADFE70A0
        public void .ctor(){} // RVA: 0x7ADFE71E0
    }

    public class OscSender : MonoBehaviour
    {
        // ── Methods ──
        public void get_IpAddress(){} // RVA: 0x7A81052C0
        public void set_IpAddress(){} // RVA: 0x7ADFE7230
        public void get_Port(){} // RVA: 0x7A854FDE0
        public void set_Port(){} // RVA: 0x7ADFE7470
        public void get_Client(){} // RVA: 0x7A83F69F0
        public void set_Client(){} // RVA: 0x7A8105A90
        public void OnEnable(){} // RVA: 0x7ADFE74D0
        public void Awake(){} // RVA: 0x7ADFE74D0
        public void OnValidate(){} // RVA: 0x7ADFE74E0
        public void Setup(){} // RVA: 0x7ADFE7500
        public void ReInitialize(){} // RVA: 0x7ADFE75D0
        public void .ctor(){} // RVA: 0x7ADFE7630
    }

    public class OscServer : Object
    {
        // ── Methods ──
        public void set_Running(){} // RVA: 0x7A8100270
        public void get_Port(){} // RVA: 0x7A8355900
        public void get_AddressSpace(){} // RVA: 0x7A8153390
        public void set_AddressSpace(){} // RVA: 0x7A81533A0
        public void get_Parser(){} // RVA: 0x7A81A00E0
        public void set_LastBundleTimestamp(){} // RVA: 0x7AD89C580
        public void .ctor(){} // RVA: 0x7ADFEE2D0
        public void Start(){} // RVA: 0x7ADFEEBF0
        public void GetOrCreate(){} // RVA: 0x7ADFEEDB0
        public void TryAddMethod(){} // RVA: 0x7ADFEEF00
        public void RemoveMethod(){} // RVA: 0x7ADFEF120
        public void RemoveAddress(){} // RVA: 0x7ADFEF460
        public void TryAddMethodPair(){} // RVA: 0x7ADFEF610
        public void RemoveMethodPair(){} // RVA: 0x7ADFEF630
        public void AddMonitorCallback(){} // RVA: 0x7ADFEF650
        public void RemoveMonitorCallback(){} // RVA: 0x7ADFEF6C0
        public void Update(){} // RVA: 0x7ADFEF720
        public void ParseBuffer(){} // RVA: 0x7ADFEF7A0
        public void HandleCallbacks(){} // RVA: 0x7ADFEFDC0
        public void HandleMonitorCallbacks(){} // RVA: 0x7ADFEFE80
        public void TryMatchPatterns(){} // RVA: 0x7ADFF00B0
        public void OverwriteAsciiString(){} // RVA: 0x7ADFF06C0
        public void Dispose(){} // RVA: 0x7ADFF0710
        public void Finalize(){} // RVA: 0x7ADFF0890
        public void .cctor(){} // RVA: 0x7ADFF08D0
    }

    public class OscSocket : Object
    {
        // ── Methods ──
        public void get_Port(){} // RVA: 0x7A82C2070
        public void get_Server(){} // RVA: 0x7A8292C30
        public void set_Server(){} // RVA: 0x7A8296DE0
        public void .ctor(){} // RVA: 0x7ADFF0A70
        public void Start(){} // RVA: 0x7ADFF0C90
        public void Serve(){} // RVA: 0x7ADFF0E20
        public void Dispose(){} // RVA: 0x7ADFF1170
    }

    public class OscStringMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7ADFE6850
        public void .ctor(){} // RVA: 0x7ADFE68D0
    }

    public class OscVector3MessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7ADFE6910
        public void .ctor(){} // RVA: 0x7ADFE6990
    }

    public class OscWriter : Object
    {
        // ── Methods ──
        public void get_Length(){} // RVA: 0x7A989D5C0
        public void .ctor(){} // RVA: 0x7ADFF1360
        public void Finalize(){} // RVA: 0x7ADFF1670
        public void Reset(){} // RVA: 0x7ADFF16E0
        public void Write(){} // RVA: 0x7ADFF1C30
        public void WriteCurrentTimestamp(){} // RVA: 0x7ADFF1D10
        public void WriteBundlePrefix(){} // RVA: 0x7ADFF1DA0
        public void WriteAddressAndTags(){} // RVA: 0x7ADFF1E20
        public void Dispose(){} // RVA: 0x7ADFF1F10
    }

    public class PropertyOutput : MonoBehaviour
    {
        // ── Methods ──
        public void get_Sender(){} // RVA: 0x7A81052C0
        public void set_Sender(){} // RVA: 0x7ADFE7700
        public void get_SourceComponent(){} // RVA: 0x7A8292C30
        public void set_SourceComponent(){} // RVA: 0x7ADFE7830
        public void get_Property(){} // RVA: 0x7A8142610
        public void set_Property(){} // RVA: 0x7ADFE7960
        public void get_Field(){} // RVA: 0x7A8142680
        public void set_Field(){} // RVA: 0x7ADFE7A80
        public void OnEnable(){} // RVA: 0x7ADFE7BA0
        public void OnValidate(){} // RVA: 0x7ADFE7DA0
        public void Update(){} // RVA: 0x7ADFE8020
        public void SendVector2(){} // RVA: 0x7ADFE8B90
        public void SendVector3(){} // RVA: 0x7ADFE8D20
        public void ValueChanged(){} // RVA: 0x7A7E05210
        public void GetObjectComponents(){} // RVA: 0x7ADFE8F50
        public void SetPropertyFromSerialized(){} // RVA: 0x7ADFE9060
        public void .ctor(){} // RVA: 0x7ADFE9450
    }

    public class StringUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFE97A0
    }

    public class TypeTagMethods : Object
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7ADFE9B80
    }

    public class TypeTag[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2CE030
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DEE0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E5EE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA27D930
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DEE0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Utils : Object
    {
        // ── Methods ──
        public void ValidateAddress(){} // RVA: 0x7ADFF2FE0
        public void ReplaceInvalidAddressCharacters(){} // RVA: 0x7ADFF3250
        public void PinPtr(){} // RVA: 0x7A8051B10
        public void GetLocalIpAddress(){} // RVA: 0x7ADFF3490
        public void MonitorMessageToString(){} // RVA: 0x7ADFF37D0
        public void .cctor(){} // RVA: 0x7ADFF3C10
    }

    public class Vector3UnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFE9820
    }

}