// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.OscCore.OscCore
// Classes: 48
// Methods: 234

namespace ThirdParty.OscCore.OscCore
{
    public class BlobUnityEvent : UnityEvent`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C6B490
    }

    public class BoolUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C6B100
    }

    public class ColorUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C6B3C0
    }

    public class Constant : Object
    {
        public object BundlePrefixBytes;
        public object BundlePrefixLong;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6C6B520
    }

    public class DoubleUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C6B2F0
    }

    public class ExtensionMethods : Object
    {
        // ── Methods ──
        public void SafeFree(){} // RVA: 0x6C73DA0
        public void ClampPort(){} // RVA: 0x6C73E20
    }

    public class FloatUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C6B260
    }

    public class IntUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C6B190
    }

    public class LongUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C6B1D0
    }

    public class MessageHandlerBase : MonoBehaviour
    {
        public object m_Receiver;
        public object m_Address;
        public object m_ActionPair;
        public object m_Registered;

        // ── Methods ──
        public void get_Receiver(){} // RVA: 0xB700F0
        public void get_Address(){} // RVA: 0xB70160
        public void OnEnable(){} // RVA: 0x6C68630
        public void OnDisable(){} // RVA: 0x6C68940
        public void OnValidate(){} // RVA: 0x6C68A50
        public void InvokeEvent(){} // RVA: 0x894290
        public void ValueRead(){} // RVA: 0x894320
        public void Update(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x6C68AA0
    }

    public class MidiMessage : ValueType
    {
        public object data;
        public object PortId;
        public object Status;
        public object Data1;
        public object Data2;

        // ── Methods ──
        public void ToString(){} // RVA: 0x8E3F10
        public void Equals(){} // RVA: 0x8E3F50
        public void GetHashCode(){} // RVA: 0x8E3FF0
    }

    public class MonitorCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C6B660
        public void Invoke(){} // RVA: 0x6C6B730
    }

    public class OscActionPair : Object
    {
        public object ValueRead;
        public object MainThreadQueued;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C6D4E0
        public void op_Addition(){} // RVA: 0x6C6D630
        public void op_Subtraction(){} // RVA: 0x6C6D770
    }

    public class OscActionPair[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class OscAddressMethods : Object
    {
        public object defaultSize;
        public object HandleToValue;
        public object SourceToBlob;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C73E40
        public void Add(){} // RVA: 0x6C742C0
        public void Remove(){} // RVA: 0x6C743C0
        public void RemoveAddress(){} // RVA: 0x6C74740
        public void TryGetValueFromBytes(){} // RVA: 0x6C74900
        public void Dispose(){} // RVA: 0x6C74990
    }

    public class OscAddressSpace : Object
    {
        public object k_DefaultPatternCapacity;
        public object k_DefaultCapacity;
        public object escapedStringBuilder;
        public object specialRegexCharacters;
        public object AddressToMethod;
        public object PatternCount;
        public object Patterns;
        public object PatternMethods;
        public object FreedPatternIndices;
        public object PatternStringToIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C6D8B0
        public void TryAddMethod(){} // RVA: 0x6C6DE40
        public void RemoveAddressMethod(){} // RVA: 0x6C6E200
        public void RemoveMethod(){} // RVA: 0x6C6E3F0
        public void TryMatchPatternHandler(){} // RVA: 0x6C6E660
        public void EscapeRegexSpecialCharacters(){} // RVA: 0x6C6E830
    }

    public class OscBlobMessageHandler : MessageHandlerBase
    {
        public object OnMessageReceived;
        public object m_Buffer;
        public object _lastReceivedBlobLength;

        // ── Methods ──
        public void get_Buffer(){} // RVA: 0xBBF8F0
        public void get_LastReceivedBlobLength(){} // RVA: 0xE32C80
        public void set_LastReceivedBlobLength(){} // RVA: 0xEEA060
        public void ValueRead(){} // RVA: 0x6C67E50
        public void InvokeEvent(){} // RVA: 0x6C67F50
        public void .ctor(){} // RVA: 0x6C67FB0
    }

    public class OscBooleanMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x6C68040
        public void .ctor(){} // RVA: 0x6C680B0
    }

    public class OscClient : Object
    {
        public object m_Socket;
        public object m_Writer;
        public object _destination;
        public object k_Int32TypeTagBytes;
        public object k_Float32TypeTagBytes;
        public object k_StringTypeTagBytes;
        public object k_BlobTypeTagBytes;
        public object k_Int64TypeTagBytes;
        public object k_Float64TypeTagBytes;
        public object k_Color32TypeTagBytes;
        public object k_MidiTypeTagBytes;
        public object k_CharTypeTagBytes;
        public object k_TrueTypeTagBytes;
        public object k_FalseTypeTagBytes;
        public object k_NilTypeTagBytes;
        public object k_InfinitumTypeTagBytes;

        // ── Methods ──
        public void get_Writer(){} // RVA: 0xB465B0
        public void get_Destination(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0x6C6E960
        public void Send(){} // RVA: 0x6C6F4E0
        public void ForceSendBuffer(){} // RVA: 0x6C6F550
    }

    public class OscColorMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x6C680F0
        public void .ctor(){} // RVA: 0x6C682B0
    }

    public class OscFloat64MessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x6C682F0
        public void .ctor(){} // RVA: 0x6C68320
    }

    public class OscFloatMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x6C68360
        public void .ctor(){} // RVA: 0x6C68390
    }

    public class OscInt64MessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x6C683D0
        public void .ctor(){} // RVA: 0x6C68400
    }

    public class OscIntMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x6C68440
        public void .ctor(){} // RVA: 0x6C68470
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public object OnMessageReceived;
        public object m_Value;

        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0x894290
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public object OnMessageReceived;
        public object m_Value;

        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x4843A60
        public void .ctor(){} // RVA: 0x48439D0
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public object OnMessageReceived;
        public object m_Value;

        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x4843AE0
        public void .ctor(){} // RVA: 0x48439D0
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public object OnMessageReceived;
        public object m_Value;

        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x48439E0
        public void .ctor(){} // RVA: 0x48439D0
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public object OnMessageReceived;
        public object m_Value;

        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x4843A20
        public void .ctor(){} // RVA: 0x48439D0
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public object OnMessageReceived;
        public object m_Value;

        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x4843B20
        public void .ctor(){} // RVA: 0x48439D0
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public object OnMessageReceived;
        public object m_Value;

        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x4843B60
        public void .ctor(){} // RVA: 0x48439D0
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public object OnMessageReceived;
        public object m_Value;

        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x4843AA0
        public void .ctor(){} // RVA: 0x48439D0
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public object OnMessageReceived;
        public object m_Value;

        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x4843990
        public void .ctor(){} // RVA: 0x48439D0
    }

    public class OscMessageValues : Object
    {
        public object k_ResizeByteHeadroom;
        public object m_SharedBuffer;
        public object SharedBufferPtr;
        public object m_SwapBuffer32;
        public object SwapBuffer32Ptr;
        public object SwapBuffer32UintPtr;
        public object SwapBufferColor32Ptr;
        public object m_Swap32Handle;
        public object m_SwapBuffer64;
        public object SwapBuffer64Ptr;
        public object m_Swap64Handle;
        public object Tags;
        public object Offsets;
        public object _elementCount;

        // ── Methods ──
        public void ReadBlobElement(){} // RVA: 0x6C6B800
        public void ReadBooleanElement(){} // RVA: 0x1CD70A0
        public void ReadColor32Element(){} // RVA: 0x6C6B900
        public void get_ElementCount(){} // RVA: 0x19C6270
        public void set_ElementCount(){} // RVA: 0xCE5450
        public void .ctor(){} // RVA: 0x6C6BA20
        public void Finalize(){} // RVA: 0x6C6BD20
        public void ForEachElement(){} // RVA: 0x6C6BE40
        public void ReadFloatElement(){} // RVA: 0x6C6BEC0
        public void ReadFloat64Element(){} // RVA: 0x6C6C000
        public void ReadIntElement(){} // RVA: 0x6C6C460
        public void ReadIntElementUnchecked(){} // RVA: 0x1CD7270
        public void ReadUIntIndex(){} // RVA: 0x6C6C630
        public void ReadIntIndex(){} // RVA: 0x6C6C720
        public void ReadInt64Element(){} // RVA: 0x6C6C7B0
        public void ReadStringElement(){} // RVA: 0x6C6CC00
        public void ReadTimestampIndex(){} // RVA: 0x6C6D4C0
    }

    public class OscParser : Object
    {
        public object MaxElementsPerMessage;
        public object MaxBlobSize;
        public object Buffer;
        public object BufferPtr;
        public object BufferLongPtr;
        public object MessageValues;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C6F590
        public void Parse(){} // RVA: 0x6C6F780
        public void AddressIsValid(){} // RVA: 0x6C6F820
        public void CharacterIsValidInAddress(){} // RVA: 0x6C6F8C0
        public void GetAddressType(){} // RVA: 0x6C6F910
        public void ParseTags(){} // RVA: 0x6C6FA60
        public void FindUnalignedAddressLength(){} // RVA: 0x6C6FC00
        public void GetStringLength(){} // RVA: 0x6C6FC40
        public void FindOffsets(){} // RVA: 0x6C6FCA0
        public void IsBundleTagAtIndex(){} // RVA: 0x6C6FE40
    }

    public class OscReceiver : MonoBehaviour
    {
        public object m_Port;
        public object _running;
        public object _server;

        // ── Methods ──
        public void get_Port(){} // RVA: 0xFEAE90
        public void set_Port(){} // RVA: 0x6C68B70
        public void get_Running(){} // RVA: 0xB5E030
        public void set_Running(){} // RVA: 0xD72F80
        public void get_Server(){} // RVA: 0xB70160
        public void set_Server(){} // RVA: 0xB44DC0
        public void OnEnable(){} // RVA: 0x6C68B80
        public void Awake(){} // RVA: 0x6C68B80
        public void OnStart(){} // RVA: 0x6C68B90
        public void OnValidate(){} // RVA: 0x6C68C40
        public void Update(){} // RVA: 0x6C68C60
        public void OnDestroy(){} // RVA: 0x6C68C80
        public void SetPort(){} // RVA: 0x6C68D00
        public void .ctor(){} // RVA: 0x6C68E40
    }

    public class OscSender : MonoBehaviour
    {
        public object m_IpAddress;
        public object m_Port;
        public object _client;

        // ── Methods ──
        public void get_IpAddress(){} // RVA: 0xB700F0
        public void set_IpAddress(){} // RVA: 0x6C68E90
        public void get_Port(){} // RVA: 0x1065D50
        public void set_Port(){} // RVA: 0x6C690D0
        public void get_Client(){} // RVA: 0xD33E60
        public void set_Client(){} // RVA: 0xB708C0
        public void OnEnable(){} // RVA: 0x6C69130
        public void Awake(){} // RVA: 0x6C69130
        public void OnValidate(){} // RVA: 0x6C69140
        public void Setup(){} // RVA: 0x6C69160
        public void ReInitialize(){} // RVA: 0x6C69230
        public void .ctor(){} // RVA: 0x6C69290
    }

    public class OscServer : Object
    {
        public object k_SingleCallbackToPair;
        public object m_Socket;
        public object m_Disposed;
        public object m_Started;
        public object m_ReadBuffer;
        public object m_BufferHandle;
        public object m_BufferPtr;
        public object m_MainThreadQueue;
        public object m_MainThreadCount;
        public object m_ByteLengthToStringBuffer;
        public object m_MonitorCallbacks;
        public object m_PatternMatchedMethods;
        public object _running;
        public object PortToServer;
        public object _port;
        public object _addressSpace;
        public object _parser;
        public object _lastBundleTimestamp;

        // ── Methods ──
        public void set_Running(){} // RVA: 0xB6B1B0
        public void get_Port(){} // RVA: 0xD34720
        public void get_AddressSpace(){} // RVA: 0xBBFF90
        public void set_AddressSpace(){} // RVA: 0xBBFFA0
        public void get_Parser(){} // RVA: 0xC10050
        public void set_LastBundleTimestamp(){} // RVA: 0x6529A50
        public void .ctor(){} // RVA: 0x6C6FF20
        public void Start(){} // RVA: 0x6C70830
        public void GetOrCreate(){} // RVA: 0x6C709F0
        public void TryAddMethod(){} // RVA: 0x6C70B40
        public void RemoveMethod(){} // RVA: 0x6C70D60
        public void RemoveAddress(){} // RVA: 0x6C710A0
        public void TryAddMethodPair(){} // RVA: 0x6C710C0
        public void RemoveMethodPair(){} // RVA: 0x6C710E0
        public void AddMonitorCallback(){} // RVA: 0x6C71100
        public void RemoveMonitorCallback(){} // RVA: 0x6C71170
        public void Update(){} // RVA: 0x6C711D0
        public void ParseBuffer(){} // RVA: 0x6C71250
        public void HandleCallbacks(){} // RVA: 0x6C718F0
        public void HandleMonitorCallbacks(){} // RVA: 0x6C719B0
        public void TryMatchPatterns(){} // RVA: 0x6C71BE0
        public void OverwriteAsciiString(){} // RVA: 0x6C721F0
        public void Dispose(){} // RVA: 0x6C72240
        public void Finalize(){} // RVA: 0x6C723C0
        public void .cctor(){} // RVA: 0x6C72400
    }

    public class OscSocket : Object
    {
        public object m_Socket;
        public object m_Thread;
        public object m_Disposed;
        public object m_Started;
        public object m_ThreadWakeup;
        public object m_CloseRequested;
        public object _port;
        public object _server;

        // ── Methods ──
        public void get_Port(){} // RVA: 0xE9CE60
        public void get_Server(){} // RVA: 0xD05CA0
        public void set_Server(){} // RVA: 0xD09D70
        public void .ctor(){} // RVA: 0x6C725A0
        public void Start(){} // RVA: 0x6C727C0
        public void Serve(){} // RVA: 0x6C72950
        public void Dispose(){} // RVA: 0x6C72CA0
    }

    public class OscStringMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x6C684B0
        public void .ctor(){} // RVA: 0x6C68530
    }

    public class OscVector3MessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x6C68570
        public void .ctor(){} // RVA: 0x6C685F0
    }

    public class OscWriter : Object
    {
        public object Buffer;
        public object m_BufferPtr;
        public object m_BufferHandle;
        public object m_BufferMidiPtr;
        public object m_FloatSwap;
        public object m_FloatSwapPtr;
        public object m_FloatSwapHandle;
        public object m_DoubleSwap;
        public object m_DoubleSwapPtr;
        public object m_DoubleSwapHandle;
        public object m_Color32Swap;
        public object m_Color32SwapPtr;
        public object m_Color32SwapHandle;
        public object m_Length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x23ADD10
        public void .ctor(){} // RVA: 0x6C72E90
        public void Finalize(){} // RVA: 0x6C731A0
        public void Reset(){} // RVA: 0x6C73210
        public void Write(){} // RVA: 0x6C73760
        public void WriteCurrentTimestamp(){} // RVA: 0x6C73840
        public void WriteBundlePrefix(){} // RVA: 0x6C738D0
        public void WriteAddressAndTags(){} // RVA: 0x6C73950
        public void Dispose(){} // RVA: 0x6C73A40
    }

    public class PropertyOutput : MonoBehaviour
    {
        public object m_Sender;
        public object m_Address;
        public object m_Object;
        public object m_SourceComponent;
        public object m_MemberIsProperty;
        public object m_PropertyName;
        public object m_PropertyTypeName;
        public object m_SendVector2Elements;
        public object m_SendVector3Elements;
        public object m_PreviousBooleanValue;
        public object m_PreviousIntValue;
        public object m_PreviousLongValue;
        public object m_PreviousDoubleValue;
        public object m_PreviousSingleValue;
        public object m_PreviousStringValue;
        public object m_PreviousColorValue;
        public object m_PreviousVec2Value;
        public object m_PreviousVec3Value;
        public object m_HasSender;
        public object m_MemberInfo;
        public object m_Property;
        public object m_Field;

        // ── Methods ──
        public void get_Sender(){} // RVA: 0xB700F0
        public void set_Sender(){} // RVA: 0x6C69360
        public void get_SourceComponent(){} // RVA: 0xD05CA0
        public void set_SourceComponent(){} // RVA: 0x6C69490
        public void get_Property(){} // RVA: 0xBAE340
        public void set_Property(){} // RVA: 0x6C695C0
        public void get_Field(){} // RVA: 0xBAE3B0
        public void set_Field(){} // RVA: 0x6C696E0
        public void OnEnable(){} // RVA: 0x6C69800
        public void OnValidate(){} // RVA: 0x6C699D0
        public void Update(){} // RVA: 0x6C69C20
        public void SendVector2(){} // RVA: 0x6C6A770
        public void SendVector3(){} // RVA: 0x6C6A900
        public void ValueChanged(){} // RVA: 0x880B90
        public void GetObjectComponents(){} // RVA: 0x6C6AB30
        public void SetPropertyFromSerialized(){} // RVA: 0x6C6AC40
        public void .ctor(){} // RVA: 0x6C6B030
    }

    public class StringUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C6B380
    }

    public class TypeTagMethods : Object
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x6C6B760
    }

    public class TypeTag[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EABED0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A700
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC7990
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E573C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A700
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Utils : Object
    {
        public object k_TempChars;
        public object k_Builder;

        // ── Methods ──
        public void PinPtr(){} // RVA: 0xA94080
        public void ValidateAddress(){} // RVA: 0x6C74BE0
        public void ReplaceInvalidAddressCharacters(){} // RVA: 0x6C74E50
        public void GetLocalIpAddress(){} // RVA: 0x6C75090
        public void MonitorMessageToString(){} // RVA: 0x6C753D0
        public void .cctor(){} // RVA: 0x6C75810
    }

    public class Vector3UnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C6B400
    }

}