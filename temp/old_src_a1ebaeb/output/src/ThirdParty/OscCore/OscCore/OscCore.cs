// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.OscCore.OscCore
// Classes: 37
// Methods: 214

namespace ThirdParty.OscCore.OscCore
{
    public class BoolUnityEvent : UnityEvent`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3b5180
    }

    public class Constant : Object
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaae3b55a0
    }

    public class ExtensionMethods : Object
    {
        // ── Original Methods ──
        public void SafeFree(){} // RVA: 0x7ffaae3bde90
        public void ClampPort(){} // RVA: 0x7ffaae3bdf10
    }

    public class MessageHandlerBase : MonoBehaviour
    {
        public object m_ActionPair; // 0x312CA790

        // ── Original Methods ──
        public void get_Receiver(){} // RVA: 0x7ffaa89600c0
        public void get_Address(){} // RVA: 0x7ffaa8960130
        public void OnEnable(){} // RVA: 0x7ffaae3b2530
        public void OnDisable(){} // RVA: 0x7ffaae3b2840
        public void OnValidate(){} // RVA: 0x7ffaae3b2950
        public void InvokeEvent(){} // RVA: 0x7ffaa8660cc0
        public void ValueRead(){} // RVA: 0x7ffaa8660d80
        public void Update(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaae3b29a0
    }

    public class MidiMessage : ValueType
    {
        public object Status; // 0x33AAFA50

        // ── Original Methods ──
        public void ToString(){} // RVA: 0x7ffaae3bdb60
        public void Equals(){} // RVA: 0x7ffaae3bddd0
        public void Equals(){} // RVA: 0x7ffaae3bddd0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaae3bde70
    }

    public class OscActionPair : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3b7570
        public void op_Addition(){} // RVA: 0x7ffaae3b76c0
        public void op_Subtraction(){} // RVA: 0x7ffaae3b7800
    }

    public class OscAddressMethods : Object
    {
        public object SourceToBlob; // 0x3372D530

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3bdf30
        public void Add(){} // RVA: 0x7ffaae3be3b0
        public void Add(){} // RVA: 0x7ffaae3be3b0
        public void Remove(){} // RVA: 0x7ffaae3be4a0
        public void RemoveAddress(){} // RVA: 0x7ffaae3be7c0
        public void TryGetValueFromBytes(){} // RVA: 0x7ffaae3be930
        public void Dispose(){} // RVA: 0x7ffaae3be9c0
    }

    public class OscAddressSpace : Object
    {
        public object escapedStringBuilder; // 0x33BED710
        public object PatternCount; // 0x33BED710
        public object FreedPatternIndices; // 0x33BED710
        public object Ԏ=g; // 0x1

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3b7940
        public void TryAddMethod(){} // RVA: 0x7ffaae3b7ed0
        public void RemoveAddressMethod(){} // RVA: 0x7ffaae3b8290
        public void RemoveMethod(){} // RVA: 0x7ffaae3b8430
        public void TryMatchPatternHandler(){} // RVA: 0x7ffaae3b8680
        public void EscapeRegexSpecialCharacters(){} // RVA: 0x7ffaae3b8850
    }

    public class OscBlobMessageHandler : MessageHandlerBase
    {
        public object _lastReceivedBlobLength; // 0x337250D0, was: <LastReceivedBlobLength>k__Bac
        public object Buffer; // 0x17000001

        // ── Original Methods ──
        public void get_Buffer(){} // RVA: 0x7ffaa89ad730
        public void get_LastReceivedBlobLength(){} // RVA: 0x7ffaa8b023d0
        public void set_LastReceivedBlobLength(){} // RVA: 0x7ffaa8bfb270
        public void ValueRead(){} // RVA: 0x7ffaae3b1d50
        public void InvokeEvent(){} // RVA: 0x7ffaae3b1e50
        public void .ctor(){} // RVA: 0x7ffaae3b1eb0
    }

    public class OscBooleanMessageHandler : OscMessageHandler`2
    {
        // ── Original Methods ──
        public void ValueRead(){} // RVA: 0x7ffaae3b1f40
        public void .ctor(){} // RVA: 0x7ffaae3b1fb0
    }

    public class OscClient : Object
    {
        public object _destination; // 0x336D4FE0, was: <Destination>k__BackingField
        public object k_StringTypeTagBytes; // 0x336D4FE0
        public object k_Float64TypeTagBytes; // 0x336D4FE0
        public object k_CharTypeTagBytes; // 0x336D4FE0
        public object k_NilTypeTagBytes; // 0x336D4FE0

        // ── Original Methods ──
        public void get_Writer(){} // RVA: 0x7ffaa89357c0
        public void get_Destination(){} // RVA: 0x7ffaa89600c0
        public void .ctor(){} // RVA: 0x7ffaae3b8b30
        public void Send(){} // RVA: 0x7ffaae3b96a0
        public void Send(){} // RVA: 0x7ffaae3b96a0
        public void Send(){} // RVA: 0x7ffaae3b96a0
        public void Send(){} // RVA: 0x7ffaae3b96a0
        public void Send(){} // RVA: 0x7ffaae3b96a0
        public void Send(){} // RVA: 0x7ffaae3b96a0
        public void Send(){} // RVA: 0x7ffaae3b96a0
        public void Send(){} // RVA: 0x7ffaae3b96a0
        public void Send(){} // RVA: 0x7ffaae3b96a0
        public void Send(){} // RVA: 0x7ffaae3b96a0
        public void ForceSendBuffer(){} // RVA: 0x7ffaae3b9710
    }

    public class OscColorMessageHandler : OscMessageHandler`2
    {
        // ── Original Methods ──
        public void ValueRead(){} // RVA: 0x7ffaae3b1ff0
        public void .ctor(){} // RVA: 0x7ffaae3b21b0
    }

    public class OscFloat64MessageHandler : OscMessageHandler`2
    {
        // ── Original Methods ──
        public void ValueRead(){} // RVA: 0x7ffaae3b21f0
        public void .ctor(){} // RVA: 0x7ffaae3b2220
    }

    public class OscFloatMessageHandler : OscMessageHandler`2
    {
        // ── Original Methods ──
        public void ValueRead(){} // RVA: 0x7ffaae3b2260
        public void .ctor(){} // RVA: 0x7ffaae3b2290
    }

    public class OscInt64MessageHandler : OscMessageHandler`2
    {
        // ── Original Methods ──
        public void ValueRead(){} // RVA: 0x7ffaae3b22d0
        public void .ctor(){} // RVA: 0x7ffaae3b2300
    }

    public class OscIntMessageHandler : OscMessageHandler`2
    {
        // ── Original Methods ──
        public void ValueRead(){} // RVA: 0x7ffaae3b2340
        public void .ctor(){} // RVA: 0x7ffaae3b2370
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        // ── Original Methods ──
        public void InvokeEvent(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        // ── Original Methods ──
        public void InvokeEvent(){} // RVA: 0x7ffaac0f2420
        public void .ctor(){} // RVA: 0x7ffaac0f2390
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public object C8; // 0xE0004

        // ── Original Methods ──
        public void InvokeEvent(){} // RVA: 0x7ffaac0f24a0
        public void .ctor(){} // RVA: 0x7ffaac0f2390
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public object "7; // 0x80110004

        // ── Original Methods ──
        public void InvokeEvent(){} // RVA: 0x7ffaac0f23a0
        public void .ctor(){} // RVA: 0x7ffaac0f2390
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public object ); // 0x800D0004

        // ── Original Methods ──
        public void InvokeEvent(){} // RVA: 0x7ffaac0f23e0
        public void .ctor(){} // RVA: 0x7ffaac0f2390
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public object ā@; // 0x800C0004

        // ── Original Methods ──
        public void InvokeEvent(){} // RVA: 0x7ffaac0f24e0
        public void .ctor(){} // RVA: 0x7ffaac0f2390
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        // ── Original Methods ──
        public void InvokeEvent(){} // RVA: 0x7ffaac0f2520
        public void .ctor(){} // RVA: 0x7ffaac0f2390
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        // ── Original Methods ──
        public void InvokeEvent(){} // RVA: 0x7ffaac0f2460
        public void .ctor(){} // RVA: 0x7ffaac0f2390
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public object ); // 0x80020004

        // ── Original Methods ──
        public void InvokeEvent(){} // RVA: 0x7ffaac0f2350
        public void .ctor(){} // RVA: 0x7ffaac0f2390
    }

    public class OscMessageValues : Object
    {
        public object SharedBufferPtr; // 0x333DE130
        public object SwapBuffer32UintPtr; // 0x333DE130
        public object m_SwapBuffer64; // 0x333DE130
        public object Tags; // 0x333DE130

        // ── Original Methods ──
        public void ReadBlobElement(){} // RVA: 0x7ffaae3b5880
        public void ReadBooleanElement(){} // RVA: 0x7ffaa98e7540
        public void ReadColor32Element(){} // RVA: 0x7ffaae3b5980
        public void get_ElementCount(){} // RVA: 0x7ffaa95c5a20
        public void set_ElementCount(){} // RVA: 0x7ffaa8ac7670
        public void .ctor(){} // RVA: 0x7ffaae3b5aa0
        public void Finalize(){} // RVA: 0x7ffaae3b5da0
        public void ForEachElement(){} // RVA: 0x7ffaae3b5ec0
        public void ReadFloatElement(){} // RVA: 0x7ffaae3b5f40
        public void ReadFloat64Element(){} // RVA: 0x7ffaae3b6080
        public void ReadIntElement(){} // RVA: 0x7ffaae3b64d0
        public void ReadIntElementUnchecked(){} // RVA: 0x7ffaa98e7710
        public void ReadUIntIndex(){} // RVA: 0x7ffaae3b6690
        public void ReadIntIndex(){} // RVA: 0x7ffaae3b6780
        public void ReadInt64Element(){} // RVA: 0x7ffaae3b6810
        public void ReadStringElement(){} // RVA: 0x7ffaae3b6c60
        public void ReadTimestampIndex(){} // RVA: 0x7ffaae3b7550
    }

    public class OscParser : Object
    {
        public object Buffer; // 0x33684330
        public object MessageValues; // 0x33684330

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3b9750
        public void Parse(){} // RVA: 0x7ffaae3b9940
        public void Parse(){} // RVA: 0x7ffaae3b9940
        public void AddressIsValid(){} // RVA: 0x7ffaae3b99d0
        public void CharacterIsValidInAddress(){} // RVA: 0x7ffaae3b9a60
        public void ParseTags(){} // RVA: 0x7ffaae3b9bd0
        public void FindUnalignedAddressLength(){} // RVA: 0x7ffaae3b9d60
        public void FindUnalignedAddressLength(){} // RVA: 0x7ffaae3b9d60
        public void FindOffsets(){} // RVA: 0x7ffaae3b9e00
        public void IsBundleTagAtIndex(){} // RVA: 0x7ffaae3b9f80
        // ── Binary Analysis Named ──
        public void GetAddressType(){} // RVA: 0x7ffaae3b9ab0
        public void GetStringLength(){} // RVA: 0x7ffaae3b9da0
    }

    public class OscReceiver : MonoBehaviour
    {
        public object _server; // 0x3376E9D0, was: <Server>k__BackingField
        public object Port; // 0x17000005

        // ── Original Methods ──
        public void get_Port(){} // RVA: 0x7ffaa8aeced0
        public void set_Port(){} // RVA: 0x7ffaae3b2a70
        public void get_Running(){} // RVA: 0x7ffaa894d7c0
        public void set_Running(){} // RVA: 0x7ffaa9e49c50
        public void get_Server(){} // RVA: 0x7ffaa8960130
        public void set_Server(){} // RVA: 0x7ffaa8933e90
        public void OnEnable(){} // RVA: 0x7ffaae3b2a80
        public void Awake(){} // RVA: 0x7ffaae3b2a80
        public void OnStart(){} // RVA: 0x7ffaae3b2a90
        public void OnValidate(){} // RVA: 0x7ffaae3b2b40
        public void Update(){} // RVA: 0x7ffaae3b2b60
        public void OnDestroy(){} // RVA: 0x7ffaae3b2b80
        public void .ctor(){} // RVA: 0x7ffaae3b2d40
        // ── Binary Analysis Named ──
        public void SetPort(){} // RVA: 0x7ffaae3b2c00
    }

    public class OscSender : MonoBehaviour
    {
        public object _client; // 0x336308F0, was: <Client>k__BackingField
        public object IpAddress; // 0x17000008

        // ── Original Methods ──
        public void get_IpAddress(){} // RVA: 0x7ffaa89600c0
        public void set_IpAddress(){} // RVA: 0x7ffaae3b2d90
        public void get_Port(){} // RVA: 0x7ffaa8d14570
        public void set_Port(){} // RVA: 0x7ffaae3b2fc0
        public void get_Client(){} // RVA: 0x7ffaa8bfcc80
        public void set_Client(){} // RVA: 0x7ffaa8960890
        public void OnEnable(){} // RVA: 0x7ffaae3b3020
        public void Awake(){} // RVA: 0x7ffaae3b3020
        public void OnValidate(){} // RVA: 0x7ffaae3b3030
        public void ReInitialize(){} // RVA: 0x7ffaae3b3120
        public void .ctor(){} // RVA: 0x7ffaae3b3180
        // ── Binary Analysis Named ──
        public void Setup(){} // RVA: 0x7ffaae3b3050
    }

    public class OscServer : Object
    {
        public object m_Disposed; // 0x33CFB6A0
        public object m_BufferHandle; // 0x33CFB6A0
        public object m_MainThreadCount; // 0x33CFB6A0
        public object m_PatternMatchedMethods; // 0x33CFB6A0
        public object _port; // 0x33CFB6A0, was: <Port>k__BackingField
        public object _lastBundleTimestamp; // 0x33CFB6A0, was: <LastBundleTimestamp>k__Backin

        // ── Original Methods ──
        public void set_Running(){} // RVA: 0x7ffaa895b030
        public void get_Port(){} // RVA: 0x7ffaa8b64610
        public void get_AddressSpace(){} // RVA: 0x7ffaa89add50
        public void set_AddressSpace(){} // RVA: 0x7ffaa89add60
        public void get_Parser(){} // RVA: 0x7ffaa89fa590
        public void set_LastBundleTimestamp(){} // RVA: 0x7ffaadc676b0
        public void .ctor(){} // RVA: 0x7ffaae3ba000
        public void Start(){} // RVA: 0x7ffaae3ba920
        public void TryAddMethod(){} // RVA: 0x7ffaae3bac30
        public void RemoveMethod(){} // RVA: 0x7ffaae3bad40
        public void RemoveAddress(){} // RVA: 0x7ffaae3bb080
        public void TryAddMethodPair(){} // RVA: 0x7ffaae3bb230
        public void RemoveMethodPair(){} // RVA: 0x7ffaae3bb250
        public void AddMonitorCallback(){} // RVA: 0x7ffaae3bb270
        public void RemoveMonitorCallback(){} // RVA: 0x7ffaae3bb2e0
        public void Update(){} // RVA: 0x7ffaae3bb340
        public void ParseBuffer(){} // RVA: 0x7ffaae3bb3b0
        public void HandleCallbacks(){} // RVA: 0x7ffaae3bb9c0
        public void HandleMonitorCallbacks(){} // RVA: 0x7ffaae3bba80
        public void TryMatchPatterns(){} // RVA: 0x7ffaae3bbca0
        public void OverwriteAsciiString(){} // RVA: 0x7ffaae3bc2d0
        public void Dispose(){} // RVA: 0x7ffaae3bc320
        public void Finalize(){} // RVA: 0x7ffaae3bc4a0
        public void .cctor(){} // RVA: 0x7ffaae3bc4e0
        // ── Binary Analysis Named ──
        public void GetOrCreate(){} // RVA: 0x7ffaae3baae0
    }

    public class OscSocket : Object
    {
        public object m_Disposed; // 0x33363630
        public object m_CloseRequested; // 0x33363630

        // ── Original Methods ──
        public void get_Port(){} // RVA: 0x7ffaa950c6d0
        public void get_Server(){} // RVA: 0x7ffaa8bf45b0
        public void set_Server(){} // RVA: 0x7ffaa8bf45c0
        public void .ctor(){} // RVA: 0x7ffaae3bc680
        public void Start(){} // RVA: 0x7ffaae3bc8a0
        public void Serve(){} // RVA: 0x7ffaae3bca30
        public void Dispose(){} // RVA: 0x7ffaae3bcd80
    }

    public class OscStringMessageHandler : OscMessageHandler`2
    {
        // ── Original Methods ──
        public void ValueRead(){} // RVA: 0x7ffaae3b23b0
        public void .ctor(){} // RVA: 0x7ffaae3b2430
    }

    public class OscVector3MessageHandler : OscMessageHandler`2
    {
        // ── Original Methods ──
        public void ValueRead(){} // RVA: 0x7ffaae3b2470
        public void .ctor(){} // RVA: 0x7ffaae3b24f0
    }

    public class OscWriter : Object
    {
        public object m_BufferHandle; // 0x33AE7CA0
        public object m_FloatSwapPtr; // 0x33AE7CA0
        public object m_DoubleSwapPtr; // 0x33AE7CA0
        public object m_Color32SwapPtr; // 0x33AE7CA0
        public object @00; // 0x33AAFA50

        // ── Original Methods ──
        public void get_Length(){} // RVA: 0x7ffaa9fb1a70
        public void .ctor(){} // RVA: 0x7ffaae3bcf70
        public void Finalize(){} // RVA: 0x7ffaae3bd280
        public void Reset(){} // RVA: 0x7ffaae3bd2f0
        public void Write(){} // RVA: 0x7ffaae3bd840
        public void Write(){} // RVA: 0x7ffaae3bd840
        public void Write(){} // RVA: 0x7ffaae3bd840
        public void Write(){} // RVA: 0x7ffaae3bd840
        public void Write(){} // RVA: 0x7ffaae3bd840
        public void Write(){} // RVA: 0x7ffaae3bd840
        public void Write(){} // RVA: 0x7ffaae3bd840
        public void Write(){} // RVA: 0x7ffaae3bd840
        public void WriteCurrentTimestamp(){} // RVA: 0x7ffaae3bd920
        public void WriteBundlePrefix(){} // RVA: 0x7ffaae3bd9b0
        public void WriteAddressAndTags(){} // RVA: 0x7ffaae3bda30
        public void Dispose(){} // RVA: 0x7ffaae3bdb20
    }

    public class PropertyOutput : MonoBehaviour
    {
        public object m_Object; // 0x31870470
        public object m_PropertyName; // 0x31870470
        public object m_SendVector3Elements; // 0x31870470
        public object m_PreviousLongValue; // 0x31870470
        public object m_PreviousStringValue; // 0x31870470
        public object m_PreviousVec3Value; // 0x31870470
        public object m_Property; // 0x31870470
        public object value__; // 0x853F2390

        // ── Original Methods ──
        public void get_Sender(){} // RVA: 0x7ffaa89600c0
        public void set_Sender(){} // RVA: 0x7ffaae3b3250
        public void get_SourceComponent(){} // RVA: 0x7ffaa8bf45b0
        public void set_SourceComponent(){} // RVA: 0x7ffaae3b3380
        public void get_Property(){} // RVA: 0x7ffaa899d040
        public void set_Property(){} // RVA: 0x7ffaae3b34b0
        public void get_Field(){} // RVA: 0x7ffaa899d0b0
        public void set_Field(){} // RVA: 0x7ffaae3b35d0
        public void OnEnable(){} // RVA: 0x7ffaae3b36f0
        public void OnValidate(){} // RVA: 0x7ffaae3b38f0
        public void Update(){} // RVA: 0x7ffaae3b3b70
        public void SendVector2(){} // RVA: 0x7ffaae3b47f0
        public void SendVector3(){} // RVA: 0x7ffaae3b4980
        public void ValueChanged(){} // RVA: 0x7ffaa864d8e0
        public void .ctor(){} // RVA: 0x7ffaae3b50b0
        // ── Binary Analysis Named ──
        public void GetObjectComponents(){} // RVA: 0x7ffaae3b4bb0
        public void SetPropertyFromSerialized(){} // RVA: 0x7ffaae3b4cc0
    }

    public class TypeTagMethods : Object
    {
        // ── Original Methods ──
        public void IsSupported(){} // RVA: 0x7ffaae3b57e0
    }

    public class Utils : Object
    {
        // ── Original Methods ──
        public void ValidateAddress(){} // RVA: 0x7ffaae3beba0
        public void ReplaceInvalidAddressCharacters(){} // RVA: 0x7ffaae3bee10
        public void PinPtr(){} // RVA: 0x7ffaa887e5c0
        public void MonitorMessageToString(){} // RVA: 0x7ffaae3bf100
        public void .cctor(){} // RVA: 0x7ffaae3bf530
        // ── Binary Analysis Named ──
        public void GetLocalIpAddress(){} // RVA: 0x7ffaae3bf050
    }

}