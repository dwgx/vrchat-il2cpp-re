// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.OscCore.OscCore
// Classes: 38
// Methods: 208

namespace ThirdParty.OscCore.OscCore
{
    public class BlobUnityEvent : UnityEvent`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8994300
    }

    public class BoolUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8993F70
    }

    public class ColorUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8994230
    }

    public class Constant : Object
    {
        public byte[] BundlePrefixBytes;
        public long BundlePrefixLong; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8994390
    }

    public class DoubleUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8994160
    }

    public class ExtensionMethods : Object
    {
        // ── Methods ──
        public void SafeFree(){} // RVA: 0x7FFAC899CC80
        public void ClampPort(){} // RVA: 0x7FFAC899CD00
    }

    public class FloatUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89940D0
    }

    public class IntUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8994000
    }

    public class LongUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8994040
    }

    public class MessageHandlerBase : MonoBehaviour
    {
        public OscCore.OscReceiver Receiver; // 0x20
        public string Address; // 0x28
        public OscCore.OscActionPair m_ActionPair; // 0x30
        public bool m_Registered; // 0x38

        // ── Methods ──
        public void get_Receiver(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Address(){} // RVA: 0x7FFAC2F4F130
        public void OnEnable(){} // RVA: 0x7FFAC8991320
        public void OnDisable(){} // RVA: 0x7FFAC8991630
        public void OnValidate(){} // RVA: 0x7FFAC8991740
        public void InvokeEvent(){} // RVA: 0x7FFAC2C70980
        public void ValueRead(){} // RVA: 0x7FFAC2C70A40
        public void Update(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC8991790
    }

    public class MidiMessage : ValueType
    {
        public int data; // 0x10
        public byte PortId; // 0x10
        public byte Status; // 0x11
        public byte Data1; // 0x12
        public byte Data2; // 0x13

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC899C950
        public void Equals(){} // RVA: 0x7FFAC899CBC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC899CC60
    }

    public class MonitorCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89944D0
        public void Invoke(){} // RVA: 0x7FFAC89945A0
    }

    public class OscActionPair : Object
    {
        public System.Action`1<OscCore.OscMessageValues> ValueRead; // 0x10
        public System.Action MainThreadQueued; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8996360
        public void op_Addition(){} // RVA: 0x7FFAC89964B0
        public void op_Subtraction(){} // RVA: 0x7FFAC89965F0
    }

    public class OscAddressMethods : Object
    {
        public int defaultSize;
        public System.Collections.Generic.Dictionary`2<BlobHandles.BlobHandle,OscCore.OscActionPair> HandleToValue; // 0x10
        public System.Collections.Generic.Dictionary`2<string,BlobHandles.BlobString> SourceToBlob; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC899CD20
        public void Add(){} // RVA: 0x7FFAC899D1A0 | overloaded x2
        public void Remove(){} // RVA: 0x7FFAC899D290
        public void RemoveAddress(){} // RVA: 0x7FFAC899D5B0
        public void TryGetValueFromBytes(){} // RVA: 0x7FFAC899D720
        public void Dispose(){} // RVA: 0x7FFAC899D7B0
    }

    public class OscAddressSpace : Object
    {
        public int k_DefaultPatternCapacity;
        public int k_DefaultCapacity;
        public System.Text.StringBuilder escapedStringBuilder; // 0x10
        public System.Collections.Generic.HashSet`1<char> specialRegexCharacters; // 0x18
        public OscCore.OscAddressMethods AddressToMethod; // 0x20
        public int PatternCount; // 0x28
        public System.Text.RegularExpressions.Regex[] Patterns; // 0x30
        public OscCore.OscActionPair[] PatternMethods; // 0x38
        public System.Collections.Generic.Queue`1<int> FreedPatternIndices; // 0x40
        public System.Collections.Generic.Dictionary`2<string,int> PatternStringToIndex; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8996730
        public void TryAddMethod(){} // RVA: 0x7FFAC8996CC0
        public void RemoveAddressMethod(){} // RVA: 0x7FFAC8997080
        public void RemoveMethod(){} // RVA: 0x7FFAC8997220
        public void TryMatchPatternHandler(){} // RVA: 0x7FFAC8997470
        public void EscapeRegexSpecialCharacters(){} // RVA: 0x7FFAC8997640
    }

    public class OscBlobMessageHandler : MessageHandlerBase
    {
        public OscCore.BlobUnityEvent Buffer; // 0x40
        public byte[] LastReceivedBlobLength; // 0x48
        public int <LastReceivedBlobLength>k__BackingField; // 0x50

        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x7FFAC2F9C730
        public void get_LastReceivedBlobLength(){} // RVA: 0x7FFAC30F10E0
        public void set_LastReceivedBlobLength(){} // RVA: 0x7FFAC31D9010
        public void ValueRead(){} // RVA: 0x7FFAC8990B40
        public void InvokeEvent(){} // RVA: 0x7FFAC8990C40
        public void .ctor(){} // RVA: 0x7FFAC8990CA0
    }

    public class OscBooleanMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAC8990D30
        public void .ctor(){} // RVA: 0x7FFAC8990DA0
    }

    public class OscClient : Object
    {
        public System.Net.Sockets.Socket Writer; // 0x10
        public OscCore.OscWriter Destination; // 0x18
        public System.Net.IPEndPoint <Destination>k__BackingField; // 0x20
        public uint k_Int32TypeTagBytes;
        public uint k_Float32TypeTagBytes;
        public uint k_StringTypeTagBytes;
        public uint k_BlobTypeTagBytes;
        public uint k_Int64TypeTagBytes;
        public uint k_Float64TypeTagBytes;
        public uint k_Color32TypeTagBytes;
        public uint k_MidiTypeTagBytes;
        public uint k_CharTypeTagBytes;
        public uint k_TrueTypeTagBytes;
        public uint k_FalseTypeTagBytes;
        public uint k_NilTypeTagBytes;
        public uint k_InfinitumTypeTagBytes;

        // ── Methods ──
        public void get_Writer(){} // RVA: 0x7FFAC2F247C0
        public void get_Destination(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFAC8997920
        public void Send(){} // RVA: 0x7FFAC8998490 | overloaded x10
        public void ForceSendBuffer(){} // RVA: 0x7FFAC8998500
    }

    public class OscColorMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAC8990DE0
        public void .ctor(){} // RVA: 0x7FFAC8990FA0
    }

    public class OscFloat64MessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAC8990FE0
        public void .ctor(){} // RVA: 0x7FFAC8991010
    }

    public class OscFloatMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAC8991050
        public void .ctor(){} // RVA: 0x7FFAC8991080
    }

    public class OscInt64MessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAC89910C0
        public void .ctor(){} // RVA: 0x7FFAC89910F0
    }

    public class OscIntMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAC8991130
        public void .ctor(){} // RVA: 0x7FFAC8991160
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public T OnMessageReceived;
        public U m_Value;

        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class OscMessageValues : Object
    {
        public int ElementCount;
        public byte[] m_SharedBuffer; // 0x10
        public byte* SharedBufferPtr; // 0x18
        public byte[] m_SwapBuffer32; // 0x20
        public float* SwapBuffer32Ptr; // 0x28
        public uint* SwapBuffer32UintPtr; // 0x30
        public UnityEngine.Color32* SwapBufferColor32Ptr; // 0x38
        public System.Runtime.InteropServices.GCHandle m_Swap32Handle; // 0x40
        public byte[] m_SwapBuffer64; // 0x48
        public double* SwapBuffer64Ptr; // 0x50
        public System.Runtime.InteropServices.GCHandle m_Swap64Handle; // 0x58
        public 0x6B2C1110[] Tags; // 0x60
        public int[] Offsets; // 0x68
        public int <ElementCount>k__BackingField; // 0x70

        // ── Methods ──
        public void ReadBlobElement(){} // RVA: 0x7FFAC8994670
        public void ReadBooleanElement(){} // RVA: 0x7FFAC3EB1DB0
        public void ReadColor32Element(){} // RVA: 0x7FFAC8994770
        public void get_ElementCount(){} // RVA: 0x7FFAC3B99E80
        public void set_ElementCount(){} // RVA: 0x7FFAC30B6520
        public void .ctor(){} // RVA: 0x7FFAC8994890
        public void Finalize(){} // RVA: 0x7FFAC8994B90
        public void ForEachElement(){} // RVA: 0x7FFAC8994CB0
        public void ReadFloatElement(){} // RVA: 0x7FFAC8994D30
        public void ReadFloat64Element(){} // RVA: 0x7FFAC8994E70
        public void ReadIntElement(){} // RVA: 0x7FFAC89952C0
        public void ReadIntElementUnchecked(){} // RVA: 0x7FFAC3EB1F80
        public void ReadUIntIndex(){} // RVA: 0x7FFAC8995480
        public void ReadIntIndex(){} // RVA: 0x7FFAC8995570
        public void ReadInt64Element(){} // RVA: 0x7FFAC8995600
        public void ReadStringElement(){} // RVA: 0x7FFAC8995A50
        public void ReadTimestampIndex(){} // RVA: 0x7FFAC8996340
    }

    public class OscParser : Object
    {
        public int MaxElementsPerMessage;
        public int MaxBlobSize;
        public byte[] Buffer; // 0x10
        public byte* BufferPtr; // 0x18
        public long* BufferLongPtr; // 0x20
        public OscCore.OscMessageValues MessageValues; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8998540
        public void Parse(){} // RVA: 0x7FFAC8998730 | overloaded x2
        public void AddressIsValid(){} // RVA: 0x7FFAC89987C0
        public void CharacterIsValidInAddress(){} // RVA: 0x7FFAC8998850
        public void GetAddressType(){} // RVA: 0x7FFAC89988A0
        public void ParseTags(){} // RVA: 0x7FFAC89989C0
        public void FindUnalignedAddressLength(){} // RVA: 0x7FFAC8998B50 | overloaded x2
        public void GetStringLength(){} // RVA: 0x7FFAC8998B90
        public void FindOffsets(){} // RVA: 0x7FFAC8998BF0
        public void IsBundleTagAtIndex(){} // RVA: 0x7FFAC8998D70
    }

    public class OscReceiver : MonoBehaviour
    {
        public int Port; // 0x20
        public bool Running; // 0x24
        public OscCore.OscServer Server; // 0x28

        // ── Methods ──
        public void get_Port(){} // RVA: 0x7FFAC30DBBE0
        public void set_Port(){} // RVA: 0x7FFAC8991860
        public void get_Running(){} // RVA: 0x7FFAC2F3C7C0
        public void set_Running(){} // RVA: 0x7FFAC4422FB0
        public void get_Server(){} // RVA: 0x7FFAC2F4F130
        public void set_Server(){} // RVA: 0x7FFAC2F22E90
        public void OnEnable(){} // RVA: 0x7FFAC8991870
        public void Awake(){} // RVA: 0x7FFAC8991870
        public void OnStart(){} // RVA: 0x7FFAC8991880
        public void OnValidate(){} // RVA: 0x7FFAC8991930
        public void Update(){} // RVA: 0x7FFAC8991950
        public void OnDestroy(){} // RVA: 0x7FFAC8991970
        public void SetPort(){} // RVA: 0x7FFAC89919F0
        public void .ctor(){} // RVA: 0x7FFAC8991B30
    }

    public class OscSender : MonoBehaviour
    {
        public string IpAddress; // 0x20
        public int Port; // 0x28
        public OscCore.OscClient Client; // 0x30

        // ── Methods ──
        public void get_IpAddress(){} // RVA: 0x7FFAC2F4F0C0
        public void set_IpAddress(){} // RVA: 0x7FFAC8991B80
        public void get_Port(){} // RVA: 0x7FFAC32EC4C0
        public void set_Port(){} // RVA: 0x7FFAC8991DB0
        public void get_Client(){} // RVA: 0x7FFAC31D95E0
        public void set_Client(){} // RVA: 0x7FFAC2F4F890
        public void OnEnable(){} // RVA: 0x7FFAC8991E10
        public void Awake(){} // RVA: 0x7FFAC8991E10
        public void OnValidate(){} // RVA: 0x7FFAC8991E20
        public void Setup(){} // RVA: 0x7FFAC8991E40
        public void ReInitialize(){} // RVA: 0x7FFAC8991F10
        public void .ctor(){} // RVA: 0x7FFAC8991F70
    }

    public class OscServer : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Action`1<OscCore.OscMessageValues>,OscCore.OscActionPair> Running;
        public OscCore.OscSocket Port; // 0x10
        public bool AddressSpace; // 0x18
        public bool Parser; // 0x19
        public byte[] LastBundleTimestamp; // 0x20
        public System.Runtime.InteropServices.GCHandle m_BufferHandle; // 0x28
        public byte* m_BufferPtr; // 0x30
        public System.Action[] m_MainThreadQueue; // 0x38
        public int m_MainThreadCount; // 0x40
        public System.Collections.Generic.Dictionary`2<int,string> m_ByteLengthToStringBuffer; // 0x48
        public System.Collections.Generic.HashSet`1<OscCore.MonitorCallback> m_MonitorCallbacks; // 0x50
        public System.Collections.Generic.List`1<OscCore.OscActionPair> m_PatternMatchedMethods; // 0x58
        public bool <Running>k__BackingField; // 0x60
        public System.Collections.Generic.Dictionary`2<int,OscCore.OscServer> PortToServer; // 0x8
        public int <Port>k__BackingField; // 0x64
        public OscCore.OscAddressSpace <AddressSpace>k__BackingField; // 0x68
        public OscCore.OscParser <Parser>k__BackingField; // 0x70
        public MiniNtp.NtpTimestamp <LastBundleTimestamp>k__BackingField; // 0x78

        // ── Methods ──
        public void set_Running(){} // RVA: 0x7FFAC2F4A030
        public void get_Port(){} // RVA: 0x7FFAC3138CA0
        public void get_AddressSpace(){} // RVA: 0x7FFAC2F9CD50
        public void set_AddressSpace(){} // RVA: 0x7FFAC2F9CD60
        public void get_Parser(){} // RVA: 0x7FFAC2FE9590
        public void set_LastBundleTimestamp(){} // RVA: 0x7FFAC8246500
        public void .ctor(){} // RVA: 0x7FFAC8998DF0
        public void Start(){} // RVA: 0x7FFAC8999710
        public void GetOrCreate(){} // RVA: 0x7FFAC89998D0
        public void TryAddMethod(){} // RVA: 0x7FFAC8999A20
        public void RemoveMethod(){} // RVA: 0x7FFAC8999B30
        public void RemoveAddress(){} // RVA: 0x7FFAC8999E70
        public void TryAddMethodPair(){} // RVA: 0x7FFAC899A020
        public void RemoveMethodPair(){} // RVA: 0x7FFAC899A040
        public void AddMonitorCallback(){} // RVA: 0x7FFAC899A060
        public void RemoveMonitorCallback(){} // RVA: 0x7FFAC899A0D0
        public void Update(){} // RVA: 0x7FFAC899A130
        public void ParseBuffer(){} // RVA: 0x7FFAC899A1A0
        public void HandleCallbacks(){} // RVA: 0x7FFAC899A7B0
        public void HandleMonitorCallbacks(){} // RVA: 0x7FFAC899A870
        public void TryMatchPatterns(){} // RVA: 0x7FFAC899AA90
        public void OverwriteAsciiString(){} // RVA: 0x7FFAC899B0C0
        public void Dispose(){} // RVA: 0x7FFAC899B110
        public void Finalize(){} // RVA: 0x7FFAC899B290
        public void .cctor(){} // RVA: 0x7FFAC899B2D0
    }

    public class OscSocket : Object
    {
        public System.Net.Sockets.Socket Port; // 0x10
        public System.Threading.Thread Server; // 0x18
        public bool m_Disposed; // 0x20
        public bool m_Started; // 0x21
        public System.Threading.AutoResetEvent m_ThreadWakeup; // 0x28
        public bool m_CloseRequested; // 0x30
        public int <Port>k__BackingField; // 0x34
        public OscCore.OscServer <Server>k__BackingField; // 0x38

        // ── Methods ──
        public void get_Port(){} // RVA: 0x7FFAC3ADEDC0
        public void get_Server(){} // RVA: 0x7FFAC31D0140
        public void set_Server(){} // RVA: 0x7FFAC31D0C20
        public void .ctor(){} // RVA: 0x7FFAC899B470
        public void Start(){} // RVA: 0x7FFAC899B690
        public void Serve(){} // RVA: 0x7FFAC899B820
        public void Dispose(){} // RVA: 0x7FFAC899BB70
    }

    public class OscStringMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAC89911A0
        public void .ctor(){} // RVA: 0x7FFAC8991220
    }

    public class OscVector3MessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFAC8991260
        public void .ctor(){} // RVA: 0x7FFAC89912E0
    }

    public class OscWriter : Object
    {
        public byte[] Length; // 0x10
        public byte* m_BufferPtr; // 0x18
        public System.Runtime.InteropServices.GCHandle m_BufferHandle; // 0x20
        public OscCore.MidiMessage* m_BufferMidiPtr; // 0x28
        public float[] m_FloatSwap; // 0x30
        public byte* m_FloatSwapPtr; // 0x38
        public System.Runtime.InteropServices.GCHandle m_FloatSwapHandle; // 0x40
        public double[] m_DoubleSwap; // 0x48
        public byte* m_DoubleSwapPtr; // 0x50
        public System.Runtime.InteropServices.GCHandle m_DoubleSwapHandle; // 0x58
        public UnityEngine.Color32[] m_Color32Swap; // 0x60
        public byte* m_Color32SwapPtr; // 0x68
        public System.Runtime.InteropServices.GCHandle m_Color32SwapHandle; // 0x70
        public int m_Length; // 0x78

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFAC4596EF0
        public void .ctor(){} // RVA: 0x7FFAC899BD60
        public void Finalize(){} // RVA: 0x7FFAC899C070
        public void Reset(){} // RVA: 0x7FFAC899C0E0
        public void Write(){} // RVA: 0x7FFAC899C630 | overloaded x8
        public void WriteCurrentTimestamp(){} // RVA: 0x7FFAC899C710
        public void WriteBundlePrefix(){} // RVA: 0x7FFAC899C7A0
        public void WriteAddressAndTags(){} // RVA: 0x7FFAC899C820
        public void Dispose(){} // RVA: 0x7FFAC899C910
    }

    public class PropertyOutput : MonoBehaviour
    {
        public OscCore.OscSender Sender; // 0x20
        public string SourceComponent; // 0x28
        public UnityEngine.GameObject Property; // 0x30
        public UnityEngine.Component Field; // 0x38
        public bool m_MemberIsProperty; // 0x40
        public string m_PropertyName; // 0x48
        public string m_PropertyTypeName; // 0x50
        public 0x6B2C1218 m_SendVector2Elements; // 0x58
        public 0x6B2C11C0 m_SendVector3Elements; // 0x59
        public bool m_PreviousBooleanValue; // 0x5A
        public int m_PreviousIntValue; // 0x5C
        public long m_PreviousLongValue; // 0x60
        public double m_PreviousDoubleValue; // 0x68
        public float m_PreviousSingleValue; // 0x70
        public string m_PreviousStringValue; // 0x78
        public UnityEngine.Color m_PreviousColorValue; // 0x80
        public UnityEngine.Vector2 m_PreviousVec2Value; // 0x90
        public UnityEngine.Vector3 m_PreviousVec3Value; // 0x98
        public bool m_HasSender; // 0xA4
        public System.Reflection.MemberInfo m_MemberInfo; // 0xA8
        public System.Reflection.PropertyInfo m_Property; // 0xB0
        public System.Reflection.FieldInfo m_Field; // 0xB8

        // ── Methods ──
        public void get_Sender(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Sender(){} // RVA: 0x7FFAC8992040
        public void get_SourceComponent(){} // RVA: 0x7FFAC31D0140
        public void set_SourceComponent(){} // RVA: 0x7FFAC8992170
        public void get_Property(){} // RVA: 0x7FFAC2F8C040
        public void set_Property(){} // RVA: 0x7FFAC89922A0
        public void get_Field(){} // RVA: 0x7FFAC2F8C0B0
        public void set_Field(){} // RVA: 0x7FFAC89923C0
        public void OnEnable(){} // RVA: 0x7FFAC89924E0
        public void OnValidate(){} // RVA: 0x7FFAC89926E0
        public void Update(){} // RVA: 0x7FFAC8992960
        public void SendVector2(){} // RVA: 0x7FFAC89935E0
        public void SendVector3(){} // RVA: 0x7FFAC8993770
        public void ValueChanged(){} // RVA: 0x7FFAC2C5D5A0
        public void GetObjectComponents(){} // RVA: 0x7FFAC89939A0
        public void SetPropertyFromSerialized(){} // RVA: 0x7FFAC8993AB0
        public void .ctor(){} // RVA: 0x7FFAC8993EA0
    }

    public class StringUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89941F0
    }

    public class TypeTagMethods : Object
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7FFAC89945D0
    }

    public class Utils : Object
    {
        public System.Collections.Generic.List`1<char> k_TempChars;
        public System.Text.StringBuilder k_Builder; // 0x8

        // ── Methods ──
        public void ValidateAddress(){} // RVA: 0x7FFAC899D990
        public void ReplaceInvalidAddressCharacters(){} // RVA: 0x7FFAC899DC00
        public void PinPtr(){} // RVA: 0x7FFAC2E8DC40
        public void GetLocalIpAddress(){} // RVA: 0x7FFAC899DE40
        public void MonitorMessageToString(){} // RVA: 0x7FFAC899DEF0
        public void .cctor(){} // RVA: 0x7FFAC899E320
    }

    public class Vector3UnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8994270
    }

}