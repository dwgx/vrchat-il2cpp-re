// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.OscCore.OscCore
// Classes: 46
// Methods: 224

namespace ThirdParty.OscCore.OscCore
{
    public class BlobUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CACAF0
    }

    public class BoolUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CAC760
    }

    public class ColorUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CACA20
    }

    public class Constant
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8CACB80
    }

    public class DoubleUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CAC950
    }

    public class ExtensionMethods
    {
        // ── Methods ──
        public void SafeFree(){} // RVA: 0x7FFAF8CB5470
        public void ClampPort(){} // RVA: 0x7FFAF8CB54F0
    }

    public class FloatUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CAC8C0
    }

    public class IntUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CAC7F0
    }

    public class LongUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CAC830
    }

    public class MessageHandlerBase
    {
        // ── Methods ──
        public void get_Receiver(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Address(){} // RVA: 0x7FFAF2DBB130
        public void OnEnable(){} // RVA: 0x7FFAF8CA9B10
        public void OnDisable(){} // RVA: 0x7FFAF8CA9E20
        public void OnValidate(){} // RVA: 0x7FFAF8CA9F30
        public void InvokeEvent(){} // RVA: 0x7FFAF2AD4A50
        public void ValueRead(){} // RVA: 0x7FFAF2AD4B10
        public void Update(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF8CA9F80
    }

    public class MidiMessage
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAF8CB5140
        public void Equals(){} // RVA: 0x7FFAF8CB53B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8CB5450
    }

    public class MonitorCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CACCC0
        public void Invoke(){} // RVA: 0x7FFAF8CACD90
    }

    public class OscActionPair
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CAEB50
        public void op_Addition(){} // RVA: 0x7FFAF8CAECA0
        public void op_Subtraction(){} // RVA: 0x7FFAF8CAEDE0
    }

    public class OscAddressMethods
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CB5510
        public void Add(){} // RVA: 0x7FFAF8CB5990 | overloaded x2
        public void Remove(){} // RVA: 0x7FFAF8CB5A80
        public void RemoveAddress(){} // RVA: 0x7FFAF8CB5DA0
        public void TryGetValueFromBytes(){} // RVA: 0x7FFAF8CB5F10
        public void Dispose(){} // RVA: 0x7FFAF8CB5FA0
    }

    public class OscAddressSpace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CAEF20
        public void TryAddMethod(){} // RVA: 0x7FFAF8CAF4B0
        public void RemoveAddressMethod(){} // RVA: 0x7FFAF8CAF870
        public void RemoveMethod(){} // RVA: 0x7FFAF8CAFA10
        public void TryMatchPatternHandler(){} // RVA: 0x7FFAF8CAFC60
        public void EscapeRegexSpecialCharacters(){} // RVA: 0x7FFAF8CAFE30
    }

    public class OscBlobMessageHandler
    {
        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x7FFAF2E08730
        public void get_LastReceivedBlobLength(){} // RVA: 0x7FFAF304C540
        public void set_LastReceivedBlobLength(){} // RVA: 0x7FFAF310F570
        public void ValueRead(){} // RVA: 0x7FFAF8CA9330
        public void InvokeEvent(){} // RVA: 0x7FFAF8CA9430
        public void .ctor(){} // RVA: 0x7FFAF8CA9490
    }

    public class OscBooleanMessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAF8CA9520
        public void .ctor(){} // RVA: 0x7FFAF8CA9590
    }

    public class OscClient
    {
        public object _writer;

        // ── Methods ──
        public void get_Writer(){} // RVA: 0x7FFAF2D907C0
        public void get_Destination(){} // RVA: 0x7FFAF2DBB0C0
        public void .ctor(){} // RVA: 0x7FFAF8CB0110
        public void Send(){} // RVA: 0x7FFAF8CB0C80 | overloaded x10
        public void ForceSendBuffer(){} // RVA: 0x7FFAF8CB0CF0
    }

    public class OscColorMessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAF8CA95D0
        public void .ctor(){} // RVA: 0x7FFAF8CA9790
    }

    public class OscFloat64MessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAF8CA97D0
        public void .ctor(){} // RVA: 0x7FFAF8CA9800
    }

    public class OscFloatMessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAF8CA9840
        public void .ctor(){} // RVA: 0x7FFAF8CA9870
    }

    public class OscInt64MessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAF8CA98B0
        public void .ctor(){} // RVA: 0x7FFAF8CA98E0
    }

    public class OscIntMessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAF8CA9920
        public void .ctor(){} // RVA: 0x7FFAF8CA9950
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7FFAF2AD4A50
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7FFAF6886C30
        public void .ctor(){} // RVA: 0x7FFAF6886BA0
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7FFAF6886CB0
        public void .ctor(){} // RVA: 0x7FFAF6886BA0
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7FFAF6886BB0
        public void .ctor(){} // RVA: 0x7FFAF6886BA0
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7FFAF6886BF0
        public void .ctor(){} // RVA: 0x7FFAF6886BA0
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7FFAF6886CF0
        public void .ctor(){} // RVA: 0x7FFAF6886BA0
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7FFAF6886D30
        public void .ctor(){} // RVA: 0x7FFAF6886BA0
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7FFAF6886C70
        public void .ctor(){} // RVA: 0x7FFAF6886BA0
    }

    public class OscMessageHandler`2
    {
        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7FFAF6886B60
        public void .ctor(){} // RVA: 0x7FFAF6886BA0
    }

    public class OscMessageValues
    {
        public object instance;

        // ── Methods ──
        public void ReadBlobElement(){} // RVA: 0x7FFAF8CACE60
        public void ReadBooleanElement(){} // RVA: 0x7FFAF3EACFC0
        public void ReadColor32Element(){} // RVA: 0x7FFAF8CACF60
        public void get_ElementCount(){} // RVA: 0x7FFAF3B95CF0
        public void set_ElementCount(){} // RVA: 0x7FFAF2F25080
        public void .ctor(){} // RVA: 0x7FFAF8CAD080
        public void Finalize(){} // RVA: 0x7FFAF8CAD380
        public void ForEachElement(){} // RVA: 0x7FFAF8CAD4A0
        public void ReadFloatElement(){} // RVA: 0x7FFAF8CAD520
        public void ReadFloat64Element(){} // RVA: 0x7FFAF8CAD660
        public void ReadIntElement(){} // RVA: 0x7FFAF8CADAB0
        public void ReadIntElementUnchecked(){} // RVA: 0x7FFAF3EAD190
        public void ReadUIntIndex(){} // RVA: 0x7FFAF8CADC70
        public void ReadIntIndex(){} // RVA: 0x7FFAF8CADD60
        public void ReadInt64Element(){} // RVA: 0x7FFAF8CADDF0
        public void ReadStringElement(){} // RVA: 0x7FFAF8CAE240
        public void ReadTimestampIndex(){} // RVA: 0x7FFAF8CAEB30
    }

    public class OscParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CB0D30
        public void Parse(){} // RVA: 0x7FFAF8CB0F20 | overloaded x2
        public void AddressIsValid(){} // RVA: 0x7FFAF8CB0FB0
        public void CharacterIsValidInAddress(){} // RVA: 0x7FFAF8CB1040
        public void GetAddressType(){} // RVA: 0x7FFAF8CB1090
        public void ParseTags(){} // RVA: 0x7FFAF8CB11B0
        public void FindUnalignedAddressLength(){} // RVA: 0x7FFAF8CB1340 | overloaded x2
        public void GetStringLength(){} // RVA: 0x7FFAF8CB1380
        public void FindOffsets(){} // RVA: 0x7FFAF8CB13E0
        public void IsBundleTagAtIndex(){} // RVA: 0x7FFAF8CB1560
    }

    public class OscReceiver
    {
        // ── Methods ──
        public void get_Port(){} // RVA: 0x7FFAF3210030
        public void set_Port(){} // RVA: 0x7FFAF8CAA050
        public void get_Running(){} // RVA: 0x7FFAF2DA87C0
        public void set_Running(){} // RVA: 0x7FFAF2F87670
        public void get_Server(){} // RVA: 0x7FFAF2DBB130
        public void set_Server(){} // RVA: 0x7FFAF2D8EE90
        public void OnEnable(){} // RVA: 0x7FFAF8CAA060
        public void Awake(){} // RVA: 0x7FFAF8CAA060
        public void OnStart(){} // RVA: 0x7FFAF8CAA070
        public void OnValidate(){} // RVA: 0x7FFAF8CAA120
        public void Update(){} // RVA: 0x7FFAF8CAA140
        public void OnDestroy(){} // RVA: 0x7FFAF8CAA160
        public void SetPort(){} // RVA: 0x7FFAF8CAA1E0
        public void .ctor(){} // RVA: 0x7FFAF8CAA320
    }

    public class OscSender
    {
        public object captureButton;
        public object homeButton;

        // ── Methods ──
        public void get_IpAddress(){} // RVA: 0x7FFAF2DBB0C0
        public void set_IpAddress(){} // RVA: 0x7FFAF8CAA370
        public void get_Port(){} // RVA: 0x7FFAF3241DC0
        public void set_Port(){} // RVA: 0x7FFAF8CAA5A0
        public void get_Client(){} // RVA: 0x7FFAF30E74D0
        public void set_Client(){} // RVA: 0x7FFAF2DBB890
        public void OnEnable(){} // RVA: 0x7FFAF8CAA600
        public void Awake(){} // RVA: 0x7FFAF8CAA600
        public void OnValidate(){} // RVA: 0x7FFAF8CAA610
        public void Setup(){} // RVA: 0x7FFAF8CAA630
        public void ReInitialize(){} // RVA: 0x7FFAF8CAA700
        public void .ctor(){} // RVA: 0x7FFAF8CAA760
    }

    public class OscServer
    {
        // ── Methods ──
        public void set_Running(){} // RVA: 0x7FFAF2DB6030
        public void get_Port(){} // RVA: 0x7FFAF304C4F0
        public void get_AddressSpace(){} // RVA: 0x7FFAF2E08D50
        public void set_AddressSpace(){} // RVA: 0x7FFAF2E08D60
        public void get_Parser(){} // RVA: 0x7FFAF2E55590
        public void set_LastBundleTimestamp(){} // RVA: 0x7FFAF855F010
        public void .ctor(){} // RVA: 0x7FFAF8CB15E0
        public void Start(){} // RVA: 0x7FFAF8CB1F00
        public void GetOrCreate(){} // RVA: 0x7FFAF8CB20C0
        public void TryAddMethod(){} // RVA: 0x7FFAF8CB2210
        public void RemoveMethod(){} // RVA: 0x7FFAF8CB2320
        public void RemoveAddress(){} // RVA: 0x7FFAF8CB2660
        public void TryAddMethodPair(){} // RVA: 0x7FFAF8CB2810
        public void RemoveMethodPair(){} // RVA: 0x7FFAF8CB2830
        public void AddMonitorCallback(){} // RVA: 0x7FFAF8CB2850
        public void RemoveMonitorCallback(){} // RVA: 0x7FFAF8CB28C0
        public void Update(){} // RVA: 0x7FFAF8CB2920
        public void ParseBuffer(){} // RVA: 0x7FFAF8CB2990
        public void HandleCallbacks(){} // RVA: 0x7FFAF8CB2FA0
        public void HandleMonitorCallbacks(){} // RVA: 0x7FFAF8CB3060
        public void TryMatchPatterns(){} // RVA: 0x7FFAF8CB3280
        public void OverwriteAsciiString(){} // RVA: 0x7FFAF8CB38B0
        public void Dispose(){} // RVA: 0x7FFAF8CB3900
        public void Finalize(){} // RVA: 0x7FFAF8CB3A80
        public void .cctor(){} // RVA: 0x7FFAF8CB3AC0
    }

    public class OscSocket
    {
        // ── Methods ──
        public void get_Port(){} // RVA: 0x7FFAF2F76670
        public void get_Server(){} // RVA: 0x7FFAF2F476A0
        public void set_Server(){} // RVA: 0x7FFAF2F4B830
        public void .ctor(){} // RVA: 0x7FFAF8CB3C60
        public void Start(){} // RVA: 0x7FFAF8CB3E80
        public void Serve(){} // RVA: 0x7FFAF8CB4010
        public void Dispose(){} // RVA: 0x7FFAF8CB4360
    }

    public class OscStringMessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAF8CA9990
        public void .ctor(){} // RVA: 0x7FFAF8CA9A10
    }

    public class OscVector3MessageHandler
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAF8CA9A50
        public void .ctor(){} // RVA: 0x7FFAF8CA9AD0
    }

    public class OscWriter
    {
        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFAF4593800
        public void .ctor(){} // RVA: 0x7FFAF8CB4550
        public void Finalize(){} // RVA: 0x7FFAF8CB4860
        public void Reset(){} // RVA: 0x7FFAF8CB48D0
        public void Write(){} // RVA: 0x7FFAF8CB4E20 | overloaded x8
        public void WriteCurrentTimestamp(){} // RVA: 0x7FFAF8CB4F00
        public void WriteBundlePrefix(){} // RVA: 0x7FFAF8CB4F90
        public void WriteAddressAndTags(){} // RVA: 0x7FFAF8CB5010
        public void Dispose(){} // RVA: 0x7FFAF8CB5100
    }

    public class PropertyOutput
    {
        // ── Methods ──
        public void get_Sender(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Sender(){} // RVA: 0x7FFAF8CAA830
        public void get_SourceComponent(){} // RVA: 0x7FFAF2F476A0
        public void set_SourceComponent(){} // RVA: 0x7FFAF8CAA960
        public void get_Property(){} // RVA: 0x7FFAF2DF8040
        public void set_Property(){} // RVA: 0x7FFAF8CAAA90
        public void get_Field(){} // RVA: 0x7FFAF2DF80B0
        public void set_Field(){} // RVA: 0x7FFAF8CAABB0
        public void OnEnable(){} // RVA: 0x7FFAF8CAACD0
        public void OnValidate(){} // RVA: 0x7FFAF8CAAED0
        public void Update(){} // RVA: 0x7FFAF8CAB150
        public void SendVector2(){} // RVA: 0x7FFAF8CABDD0
        public void SendVector3(){} // RVA: 0x7FFAF8CABF60
        public void ValueChanged(){} // RVA: 0x7FFAF2AC14C0
        public void GetObjectComponents(){} // RVA: 0x7FFAF8CAC190
        public void SetPropertyFromSerialized(){} // RVA: 0x7FFAF8CAC2A0
        public void .ctor(){} // RVA: 0x7FFAF8CAC690
    }

    public class StringUnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CAC9E0
    }

    public class TypeTagMethods
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7FFAF8CACDC0
    }

    public class Utils
    {
        // ── Methods ──
        public void ValidateAddress(){} // RVA: 0x7FFAF8CB6180
        public void ReplaceInvalidAddressCharacters(){} // RVA: 0x7FFAF8CB63F0
        public void PinPtr(){} // RVA: 0x7FFAF2D33FA0
        public void GetLocalIpAddress(){} // RVA: 0x7FFAF8CB6630
        public void MonitorMessageToString(){} // RVA: 0x7FFAF8CB66E0
        public void .cctor(){} // RVA: 0x7FFAF8CB6B10
    }

    public class Vector3UnityEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CACA60
    }

}