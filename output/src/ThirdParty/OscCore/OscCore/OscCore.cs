// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.OscCore.OscCore
// Classes: 29
// Methods: 198

namespace ThirdParty.OscCore.OscCore
{
    public class BoolUnityEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53DB3F70
    }

    public class Constant : Object
    {
        public byte[] BundlePrefixBytes;
        public long BundlePrefixLong; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD53DB4390
    }

    public class ExtensionMethods : Object
    {
        // ── Methods ──
        public void SafeFree(){} // RVA: 0x7FFD53DBCC80
        public void ClampPort(){} // RVA: 0x7FFD53DBCD00
    }

    public class MessageHandlerBase : MonoBehaviour
    {
        public OscCore.OscReceiver Receiver; // 0x20
        public string Address; // 0x28
        public OscCore.OscActionPair m_ActionPair; // 0x30
        public bool m_Registered; // 0x38

        // ── Methods ──
        public void get_Receiver(){} // RVA: 0x7FFD4E36F0C0
        public void get_Address(){} // RVA: 0x7FFD4E36F130
        public void OnEnable(){} // RVA: 0x7FFD53DB1320
        public void OnDisable(){} // RVA: 0x7FFD53DB1630
        public void OnValidate(){} // RVA: 0x7FFD53DB1740
        public void InvokeEvent(){} // RVA: 0x7FFD4E090980
        public void ValueRead(){} // RVA: 0x7FFD4E090A40
        public void Update(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD53DB1790
    }

    public class MidiMessage : ValueType
    {
        public int data; // 0x10
        public byte PortId; // 0x10
        public byte Status; // 0x11
        public byte Data1; // 0x12
        public byte Data2; // 0x13

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD53DBC950
        public void Equals(){} // RVA: 0x7FFD53DBCBC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53DBCC60
    }

    public class OscActionPair : Object
    {
        public System.Action`1<OscCore.OscMessageValues> ValueRead; // 0x10
        public System.Action MainThreadQueued; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53DB6360
        public void op_Addition(){} // RVA: 0x7FFD53DB64B0
        public void op_Subtraction(){} // RVA: 0x7FFD53DB65F0
    }

    public class OscAddressMethods : Object
    {
        public int defaultSize;
        public System.Collections.Generic.Dictionary`2<BlobHandles.BlobHandle,OscCore.OscActionPair> HandleToValue; // 0x10
        public System.Collections.Generic.Dictionary`2<string,BlobHandles.BlobString> SourceToBlob; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53DBCD20
        public void Add(){} // RVA: 0x7FFD53DBD1A0 | overloaded x2
        public void Remove(){} // RVA: 0x7FFD53DBD290
        public void RemoveAddress(){} // RVA: 0x7FFD53DBD5B0
        public void TryGetValueFromBytes(){} // RVA: 0x7FFD53DBD720
        public void Dispose(){} // RVA: 0x7FFD53DBD7B0
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
        public void .ctor(){} // RVA: 0x7FFD53DB6730
        public void TryAddMethod(){} // RVA: 0x7FFD53DB6CC0
        public void RemoveAddressMethod(){} // RVA: 0x7FFD53DB7080
        public void RemoveMethod(){} // RVA: 0x7FFD53DB7220
        public void TryMatchPatternHandler(){} // RVA: 0x7FFD53DB7470
        public void EscapeRegexSpecialCharacters(){} // RVA: 0x7FFD53DB7640
    }

    public class OscBlobMessageHandler : MessageHandlerBase
    {
        public Í Buffer; // 0x40
        public byte[] LastReceivedBlobLength; // 0x48
        public int <LastReceivedBlobLength>k__BackingField; // 0x50

        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x7FFD4E3BC730
        public void get_LastReceivedBlobLength(){} // RVA: 0x7FFD4E5110E0
        public void set_LastReceivedBlobLength(){} // RVA: 0x7FFD4E5F9010
        public void ValueRead(){} // RVA: 0x7FFD53DB0B40
        public void InvokeEvent(){} // RVA: 0x7FFD53DB0C40
        public void .ctor(){} // RVA: 0x7FFD53DB0CA0
    }

    public class OscBooleanMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFD53DB0D30
        public void .ctor(){} // RVA: 0x7FFD53DB0DA0
    }

    public class OscClient : Object
    {
        public System.Net.Sockets.Socket Writer; // 0x10
        public OscCore.OscWriter Destination; // 0x18
        public 0x66499F70 <Destination>k__BackingField; // 0x20
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
        public void get_Writer(){} // RVA: 0x7FFD4E3447C0
        public void get_Destination(){} // RVA: 0x7FFD4E36F0C0
        public void .ctor(){} // RVA: 0x7FFD53DB7920
        public void Send(){} // RVA: 0x7FFD53DB8490 | overloaded x10
        public void ForceSendBuffer(){} // RVA: 0x7FFD53DB8500
    }

    public class OscColorMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFD53DB0DE0
        public void .ctor(){} // RVA: 0x7FFD53DB0FA0
    }

    public class OscFloat64MessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFD53DB0FE0
        public void .ctor(){} // RVA: 0x7FFD53DB1010
    }

    public class OscFloatMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFD53DB1050
        public void .ctor(){} // RVA: 0x7FFD53DB1080
    }

    public class OscInt64MessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFD53DB10C0
        public void .ctor(){} // RVA: 0x7FFD53DB10F0
    }

    public class OscIntMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFD53DB1130
        public void .ctor(){} // RVA: 0x7FFD53DB1160
    }

    public class OscMessageHandler`2 : MessageHandlerBase
    {
        public OscCore.BoolUnityEvent OnMessageReceived; // 0x40
        public bool m_Value; // 0x48

        // ── Methods ──
        public void InvokeEvent(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E090980
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
        public ÌÍÏÎÍÎÏÍÎ[] Tags; // 0x60
        public int[] Offsets; // 0x68
        public int <ElementCount>k__BackingField; // 0x70

        // ── Methods ──
        public void ReadBlobElement(){} // RVA: 0x7FFD53DB4670
        public void ReadBooleanElement(){} // RVA: 0x7FFD4F2D1DB0
        public void ReadColor32Element(){} // RVA: 0x7FFD53DB4770
        public void get_ElementCount(){} // RVA: 0x7FFD4EFB9E80
        public void set_ElementCount(){} // RVA: 0x7FFD4E4D6520
        public void .ctor(){} // RVA: 0x7FFD53DB4890
        public void Finalize(){} // RVA: 0x7FFD53DB4B90
        public void ForEachElement(){} // RVA: 0x7FFD53DB4CB0
        public void ReadFloatElement(){} // RVA: 0x7FFD53DB4D30
        public void ReadFloat64Element(){} // RVA: 0x7FFD53DB4E70
        public void ReadIntElement(){} // RVA: 0x7FFD53DB52C0
        public void ReadIntElementUnchecked(){} // RVA: 0x7FFD4F2D1F80
        public void ReadUIntIndex(){} // RVA: 0x7FFD53DB5480
        public void ReadIntIndex(){} // RVA: 0x7FFD53DB5570
        public void ReadInt64Element(){} // RVA: 0x7FFD53DB5600
        public void ReadStringElement(){} // RVA: 0x7FFD53DB5A50
        public void ReadTimestampIndex(){} // RVA: 0x7FFD53DB6340
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
        public void .ctor(){} // RVA: 0x7FFD53DB8540
        public void Parse(){} // RVA: 0x7FFD53DB8730 | overloaded x2
        public void AddressIsValid(){} // RVA: 0x7FFD53DB87C0
        public void CharacterIsValidInAddress(){} // RVA: 0x7FFD53DB8850
        public void GetAddressType(){} // RVA: 0x7FFD53DB88A0
        public void ParseTags(){} // RVA: 0x7FFD53DB89C0
        public void FindUnalignedAddressLength(){} // RVA: 0x7FFD53DB8B50 | overloaded x2
        public void GetStringLength(){} // RVA: 0x7FFD53DB8B90
        public void FindOffsets(){} // RVA: 0x7FFD53DB8BF0
        public void IsBundleTagAtIndex(){} // RVA: 0x7FFD53DB8D70
    }

    public class OscReceiver : MonoBehaviour
    {
        public int Port; // 0x20
        public bool Running; // 0x24
        public OscCore.OscServer Server; // 0x28

        // ── Methods ──
        public void get_Port(){} // RVA: 0x7FFD4E4FBBE0
        public void set_Port(){} // RVA: 0x7FFD53DB1860
        public void get_Running(){} // RVA: 0x7FFD4E35C7C0
        public void set_Running(){} // RVA: 0x7FFD4F842FB0
        public void get_Server(){} // RVA: 0x7FFD4E36F130
        public void set_Server(){} // RVA: 0x7FFD4E342E90
        public void OnEnable(){} // RVA: 0x7FFD53DB1870
        public void Awake(){} // RVA: 0x7FFD53DB1870
        public void OnStart(){} // RVA: 0x7FFD53DB1880
        public void OnValidate(){} // RVA: 0x7FFD53DB1930
        public void Update(){} // RVA: 0x7FFD53DB1950
        public void OnDestroy(){} // RVA: 0x7FFD53DB1970
        public void SetPort(){} // RVA: 0x7FFD53DB19F0
        public void .ctor(){} // RVA: 0x7FFD53DB1B30
    }

    public class OscSender : MonoBehaviour
    {
        public string IpAddress; // 0x20
        public int Port; // 0x28
        public OscCore.OscClient Client; // 0x30

        // ── Methods ──
        public void get_IpAddress(){} // RVA: 0x7FFD4E36F0C0
        public void set_IpAddress(){} // RVA: 0x7FFD53DB1B80
        public void get_Port(){} // RVA: 0x7FFD4E70C4C0
        public void set_Port(){} // RVA: 0x7FFD53DB1DB0
        public void get_Client(){} // RVA: 0x7FFD4E5F95E0
        public void set_Client(){} // RVA: 0x7FFD4E36F890
        public void OnEnable(){} // RVA: 0x7FFD53DB1E10
        public void Awake(){} // RVA: 0x7FFD53DB1E10
        public void OnValidate(){} // RVA: 0x7FFD53DB1E20
        public void Setup(){} // RVA: 0x7FFD53DB1E40
        public void ReInitialize(){} // RVA: 0x7FFD53DB1F10
        public void .ctor(){} // RVA: 0x7FFD53DB1F70
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
        public System.Collections.Generic.HashSet`1<ÏÍÌÏÍÏÎÏÍÍÍÍÌÎÌÍÏÎÍÎÏÍÎ> m_MonitorCallbacks; // 0x50
        public System.Collections.Generic.List`1<OscCore.OscActionPair> m_PatternMatchedMethods; // 0x58
        public bool <Running>k__BackingField; // 0x60
        public System.Collections.Generic.Dictionary`2<int,OscCore.OscServer> PortToServer; // 0x8
        public int <Port>k__BackingField; // 0x64
        public OscCore.OscAddressSpace <AddressSpace>k__BackingField; // 0x68
        public OscCore.OscParser <Parser>k__BackingField; // 0x70
        public MiniNtp.NtpTimestamp <LastBundleTimestamp>k__BackingField; // 0x78

        // ── Methods ──
        public void set_Running(){} // RVA: 0x7FFD4E36A030
        public void get_Port(){} // RVA: 0x7FFD4E558CA0
        public void get_AddressSpace(){} // RVA: 0x7FFD4E3BCD50
        public void set_AddressSpace(){} // RVA: 0x7FFD4E3BCD60
        public void get_Parser(){} // RVA: 0x7FFD4E409590
        public void set_LastBundleTimestamp(){} // RVA: 0x7FFD53666500
        public void .ctor(){} // RVA: 0x7FFD53DB8DF0
        public void Start(){} // RVA: 0x7FFD53DB9710
        public void GetOrCreate(){} // RVA: 0x7FFD53DB98D0
        public void TryAddMethod(){} // RVA: 0x7FFD53DB9A20
        public void RemoveMethod(){} // RVA: 0x7FFD53DB9B30
        public void RemoveAddress(){} // RVA: 0x7FFD53DB9E70
        public void TryAddMethodPair(){} // RVA: 0x7FFD53DBA020
        public void RemoveMethodPair(){} // RVA: 0x7FFD53DBA040
        public void AddMonitorCallback(){} // RVA: 0x7FFD53DBA060
        public void RemoveMonitorCallback(){} // RVA: 0x7FFD53DBA0D0
        public void Update(){} // RVA: 0x7FFD53DBA130
        public void ParseBuffer(){} // RVA: 0x7FFD53DBA1A0
        public void HandleCallbacks(){} // RVA: 0x7FFD53DBA7B0
        public void HandleMonitorCallbacks(){} // RVA: 0x7FFD53DBA870
        public void TryMatchPatterns(){} // RVA: 0x7FFD53DBAA90
        public void OverwriteAsciiString(){} // RVA: 0x7FFD53DBB0C0
        public void Dispose(){} // RVA: 0x7FFD53DBB110
        public void Finalize(){} // RVA: 0x7FFD53DBB290
        public void .cctor(){} // RVA: 0x7FFD53DBB2D0
    }

    public class OscSocket : Object
    {
        public System.Net.Sockets.Socket Port; // 0x10
        public System.Threading.Thread Server; // 0x18
        public bool m_Disposed; // 0x20
        public bool m_Started; // 0x21
        public 0x664254E0 m_ThreadWakeup; // 0x28
        public bool m_CloseRequested; // 0x30
        public int <Port>k__BackingField; // 0x34
        public OscCore.OscServer <Server>k__BackingField; // 0x38

        // ── Methods ──
        public void get_Port(){} // RVA: 0x7FFD4EEFEDC0
        public void get_Server(){} // RVA: 0x7FFD4E5F0140
        public void set_Server(){} // RVA: 0x7FFD4E5F0C20
        public void .ctor(){} // RVA: 0x7FFD53DBB470
        public void Start(){} // RVA: 0x7FFD53DBB690
        public void Serve(){} // RVA: 0x7FFD53DBB820
        public void Dispose(){} // RVA: 0x7FFD53DBBB70
    }

    public class OscStringMessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFD53DB11A0
        public void .ctor(){} // RVA: 0x7FFD53DB1220
    }

    public class OscVector3MessageHandler : OscMessageHandler`2
    {
        // ── Methods ──
        public void ValueRead(){} // RVA: 0x7FFD53DB1260
        public void .ctor(){} // RVA: 0x7FFD53DB12E0
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
        public void get_Length(){} // RVA: 0x7FFD4F9B6EF0
        public void .ctor(){} // RVA: 0x7FFD53DBBD60
        public void Finalize(){} // RVA: 0x7FFD53DBC070
        public void Reset(){} // RVA: 0x7FFD53DBC0E0
        public void Write(){} // RVA: 0x7FFD53DBC630 | overloaded x8
        public void WriteCurrentTimestamp(){} // RVA: 0x7FFD53DBC710
        public void WriteBundlePrefix(){} // RVA: 0x7FFD53DBC7A0
        public void WriteAddressAndTags(){} // RVA: 0x7FFD53DBC820
        public void Dispose(){} // RVA: 0x7FFD53DBC910
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
        public 0x66621218 m_SendVector2Elements; // 0x58
        public ÎÌÎÍÍÏÏÌÏÏÌÏÌÏÏÏÏÏÌÍ m_SendVector3Elements; // 0x59
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
        public void get_Sender(){} // RVA: 0x7FFD4E36F0C0
        public void set_Sender(){} // RVA: 0x7FFD53DB2040
        public void get_SourceComponent(){} // RVA: 0x7FFD4E5F0140
        public void set_SourceComponent(){} // RVA: 0x7FFD53DB2170
        public void get_Property(){} // RVA: 0x7FFD4E3AC040
        public void set_Property(){} // RVA: 0x7FFD53DB22A0
        public void get_Field(){} // RVA: 0x7FFD4E3AC0B0
        public void set_Field(){} // RVA: 0x7FFD53DB23C0
        public void OnEnable(){} // RVA: 0x7FFD53DB24E0
        public void OnValidate(){} // RVA: 0x7FFD53DB26E0
        public void Update(){} // RVA: 0x7FFD53DB2960
        public void SendVector2(){} // RVA: 0x7FFD53DB35E0
        public void SendVector3(){} // RVA: 0x7FFD53DB3770
        public void ValueChanged(){} // RVA: 0x7FFD4E07D5A0
        public void GetObjectComponents(){} // RVA: 0x7FFD53DB39A0
        public void SetPropertyFromSerialized(){} // RVA: 0x7FFD53DB3AB0
        public void .ctor(){} // RVA: 0x7FFD53DB3EA0
    }

    public class TypeTagMethods : Object
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7FFD53DB45D0
    }

    public class Utils : Object
    {
        public System.Collections.Generic.List`1<char> k_TempChars;
        public System.Text.StringBuilder k_Builder; // 0x8

        // ── Methods ──
        public void ValidateAddress(){} // RVA: 0x7FFD53DBD990
        public void ReplaceInvalidAddressCharacters(){} // RVA: 0x7FFD53DBDC00
        public void PinPtr(){} // RVA: 0x7FFD4E2ADC40
        public void GetLocalIpAddress(){} // RVA: 0x7FFD53DBDE40
        public void MonitorMessageToString(){} // RVA: 0x7FFD53DBDEF0
        public void .cctor(){} // RVA: 0x7FFD53DBE320
    }

}