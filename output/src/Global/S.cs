// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 275

public class SCNetworkReachabilityCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC45B4250
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class SCNetworkReachabilityContext : ValueType
{
    public UIntPtr version; // 0x10
    public UIntPtr info; // 0x18
    public UIntPtr retain; // 0x20
    public UIntPtr release; // 0x28
    public UIntPtr copyDescription; // 0x30
}

public class SECURITY_ATTRIBUTES : ValueType
{
    public uint nLength; // 0x10
    public UIntPtr lpSecurityDescriptor; // 0x18
    public 0x6B0BAB68 bInheritHandle; // 0x20
}

public class SM2P256V1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC53FA0
    public void .cctor(){} // RVA: 0x7FFACBC540F0
}

public class SM2P256V1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Curve Size; // 0x10
    public uint[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBB02D70
}

public class SMAALuts : Object
{
    public UnityEngine.Texture2D area; // 0x10
    public UnityEngine.Texture2D search; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SPKey : Object
{
    public System.Uri UsesProxy; // 0x10
    public System.Uri proxy; // 0x18
    public bool use_connect; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC84C0F70
    public void get_UsesProxy(){} // RVA: 0x7FFAC9309730
    public void GetHashCode(){} // RVA: 0x7FFAC9309780
    public void Equals(){} // RVA: 0x7FFAC9309850
}

public class SR : Object
{
    // ── Methods ──
    public void GetString(){} // RVA: 0x7FFAC44F81E0 | overloaded x3
    public void Format(){} // RVA: 0x7FFAC838C340 | overloaded x4
    public void GetResourceString(){} // RVA: 0x7FFAC44F81E0
}

public class STOutput : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Prime; // 0x10
    public byte[] PrimeSeed; // 0x18
    public int PrimeGenCounter; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Prime(){} // RVA: 0x7FFAC2F3C380
    public void get_PrimeSeed(){} // RVA: 0x7FFAC2F247C0
    public void get_PrimeGenCounter(){} // RVA: 0x7FFAC30DBBE0
}

public class SYSTEMTIME : ValueType
{
    public ushort Year; // 0x10
    public ushort Month; // 0x12
    public ushort DayOfWeek; // 0x14
    public ushort Day; // 0x16
    public ushort Hour; // 0x18
    public ushort Minute; // 0x1A
    public ushort Second; // 0x1C
    public ushort Milliseconds; // 0x1E

    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC838A180
}

public class SafeDeflateStreamHandle : SafeHandle
{
    public object IsInvalid;

    // ── Methods ──
    public void get_IsInvalid(){} // RVA: 0x7FFAC353FA50
    public void .ctor(){} // RVA: 0x7FFAC83B9EF0
    public void ReleaseHandle(){} // RVA: 0x7FFAC9461820
}

public class SafeModeOptions : Object
{
    public 0x6B26FD00 nestedTweenFailureBehaviour; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Sample : Object
{
    public ulong Timestamp; // 0x10
    public int ThreadId; // 0x18
    public int StackId; // 0x1C

    // ── Methods ──
    public void WriteTo(){} // RVA: 0x7FFAC8B74850
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SampleFramesHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC411D4B0
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class SaveableInventoryGroupData : ValueType
{
    public string name;
    public string[] ids;
}

public class SavedSearches : Object
{
    public System.Collections.Generic.List`1<VRC.DataModel.SearchParameters> Searches; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Scanbeam : Object
{
    public long Y; // 0x10
    public Scanbeam Next; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SceneCaptureCompleteData : ValueType
{
    public ulong RequestId; // 0x10
    public int Result; // 0x18
}

public class SceneCaptureRequestInternal : ValueType
{
    public int requestByteCount; // 0x10
    public string request; // 0x18
}

public class ScheduledFrameEvent : ValueType
{
    public VRC.Udon.Common.Interfaces.IUdonEventReceiver udonEventReceiver; // 0x10
    public string eventName; // 0x18
    public long eventFrame; // 0x20
    public long eventId; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9E7F630
}

public class ScheduledFrameEventComparer : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFAC9E7F770
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ScheduledTimeEvent : ValueType
{
    public VRC.Udon.Common.Interfaces.IUdonEventReceiver udonEventReceiver; // 0x10
    public string eventName; // 0x18
    public double eventTime; // 0x20
    public long eventId; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9E7F570
}

public class ScheduledTimeEventComparer : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFAC9E7F6F0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Scheduler : Object
{
    public Scheduler Instance;
    public bool needReSort; // 0x10
    public System.Collections.Generic.List`1<System.Threading.Timer> list; // 0x18
    public long current_next_run; // 0x20
    public System.Threading.ManualResetEvent changed; // 0x28

    // ── Methods ──
    public void InitScheduler(){} // RVA: 0x7FFAC86D7F50
    public void WakeupScheduler(){} // RVA: 0x7FFAC86D8100
    public void SchedulerThread(){} // RVA: 0x7FFAC86D8170
    public void get_Instance(){} // RVA: 0x7FFAC86D83F0
    public void .ctor(){} // RVA: 0x7FFAC86D8450
    public void Remove(){} // RVA: 0x7FFAC86D8730
    public void Change(){} // RVA: 0x7FFAC86D8880
    public void Add(){} // RVA: 0x7FFAC86D8BB0
    public void InternalRemove(){} // RVA: 0x7FFAC86D8C90
    public void TimerCB(){} // RVA: 0x7FFAC86D8CC0
    public void FireTimer(){} // RVA: 0x7FFAC86D8D40
    public void RunSchedulerLoop(){} // RVA: 0x7FFAC86D8E10
    public void .cctor(){} // RVA: 0x7FFAC86D9210
}

public class SchemaDatatypeMap : Object
{
    public string Name; // 0x10
    public System.Xml.Schema.DatatypeImplementation ParentIndex; // 0x18
    public int parentIndex; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0 | overloaded x2
    public void op_Explicit(){} // RVA: 0x7FFAC38DFDA0
    public void get_Name(){} // RVA: 0x7FFAC2F3C380
    public void get_ParentIndex(){} // RVA: 0x7FFAC30DBBE0
    public void CompareTo(){} // RVA: 0x7FFAC92836A0
}

public class SchemaScope : Object
{
    public 0x6B1CB2D8 CurrentPropertyName; // 0x10
    public System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel> ArrayItemCount; // 0x18
    public System.Collections.Generic.Dictionary`2<string,bool> IsUniqueArray; // 0x20
    public string UniqueArrayItems; // 0x28
    public int CurrentItemWriter; // 0x30
    public bool Schemas; // 0x34
    public System.Collections.Generic.IList`1<Newtonsoft.Json.Linq.JToken> RequiredProperties; // 0x38
    public Newtonsoft.Json.Linq.JTokenWriter TokenType; // 0x40

    // ── Methods ──
    public void get_CurrentPropertyName(){} // RVA: 0x7FFAC2F4F130
    public void set_CurrentPropertyName(){} // RVA: 0x7FFAC2F22E90
    public void get_ArrayItemCount(){} // RVA: 0x7FFAC2F7CCD0
    public void set_ArrayItemCount(){} // RVA: 0x7FFAC2F7CCE0
    public void get_IsUniqueArray(){} // RVA: 0x7FFAC2F57C20
    public void get_UniqueArrayItems(){} // RVA: 0x7FFAC31D0140
    public void get_CurrentItemWriter(){} // RVA: 0x7FFAC2F9E740
    public void set_CurrentItemWriter(){} // RVA: 0x7FFAC2F49200
    public void get_Schemas(){} // RVA: 0x7FFAC2F247C0
    public void get_RequiredProperties(){} // RVA: 0x7FFAC2F4F0C0
    public void get_TokenType(){} // RVA: 0x7FFAC2F6E5C0
    public void .ctor(){} // RVA: 0x7FFAC8741830
    public void GetRequiredProperties(){} // RVA: 0x7FFAC8741E50
}

public class SchemeJson : ValueType
{
    public string name; // 0x10
    public string bindingGroup; // 0x18
    public DeviceJson[] devices; // 0x20

    // ── Methods ──
    public void ToScheme(){} // RVA: 0x7FFAC957A4E0
    public void ToJson(){} // RVA: 0x7FFAC957AAF0 | overloaded x2
    public void ToSchemes(){} // RVA: 0x7FFAC957AC60
}

public class Scope : Object
{
    public Microsoft.Extensions.Logging.LoggerFactoryScopeProvider Parent; // 0x10
    public bool State; // 0x18
    public Scope <Parent>k__BackingField; // 0x20
    public object <State>k__BackingField; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83423F0
    public void get_Parent(){} // RVA: 0x7FFAC2F4F0C0
    public void get_State(){} // RVA: 0x7FFAC2F4F130
    public void ToString(){} // RVA: 0x7FFAC83424F0
    public void Dispose(){} // RVA: 0x7FFAC834A1A0
}

public class ScopeSnapshot : Object
{
    public Sentry.SentryOptions _options; // 0x10
    public System.Collections.Generic.KeyValuePair`2<Sentry.Scope,Sentry.ISentryClient>[] _snapshot; // 0x18
    public Sentry.Internal.SentryScopeManager _scopeManager; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3000E00
    public void Dispose(){} // RVA: 0x7FFAC8BB2D40
}

public class ScopedProfile : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
}

public class ScriptRunBehaviourFixedUpdate : ValueType
{
}

public class ScriptRunBehaviourLateUpdate : ValueType
{
}

public class ScriptRunBehaviourUpdate : ValueType
{
}

public class ScriptRunDelayedDynamicFrameRate : ValueType
{
}

public class ScriptRunDelayedFixedFrameRate : ValueType
{
}

public class ScriptRunDelayedStartupFrame : ValueType
{
}

public class ScriptRunDelayedTasks : ValueType
{
}

public class ScrollEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C5CC80
}

public class ScrollRectEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C63780
}

public class ScrollerSlider : Slider
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9B56490
    public void SliderNormalizeValue(){} // RVA: 0x7FFAC9B56530
}

public class SealedPrefab : MonoBehaviour
{
    public UnityEngine.Object[] allowedToReference; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21D50
}

public class SealedPrefabAllowSerializeAttribute : Attribute
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SearchParams : ApiModel
{
    public string searchQuery; // 0x68
    public string searchTags; // 0x70
    public string searchContent; // 0x78
    public string searchInFields; // 0x80
    public string sortBy; // 0x88

    // ── Methods ──
    public void get_searchQuery(){} // RVA: 0x7FFAC2F9CD50
    public void set_searchQuery(){} // RVA: 0x7FFAC2F9CD60
    public void get_searchTags(){} // RVA: 0x7FFAC2FE9590
    public void set_searchTags(){} // RVA: 0x7FFAC2FE95A0
    public void get_searchContent(){} // RVA: 0x7FFAC30E5600
    public void set_searchContent(){} // RVA: 0x7FFAC30E06F0
    public void get_searchInFields(){} // RVA: 0x7FFAC32EF410
    public void set_searchInFields(){} // RVA: 0x7FFAC34D4AA0
    public void get_sortBy(){} // RVA: 0x7FFAC2F60010
    public void set_sortBy(){} // RVA: 0x7FFAC354E300
    public void .ctor(){} // RVA: 0x7FFACBE79520
}

public class SecP128R1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC4F240
    public void .cctor(){} // RVA: 0x7FFACBC4F3D0
}

public class SecP128R1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Curve Size; // 0x10
    public uint[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBA83D70
}

public class SecP160K1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC4F470
    public void .cctor(){} // RVA: 0x7FFACBC4F950
}

public class SecP160K1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve Size; // 0x10
    public uint[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBA89150
}

public class SecP160R1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC4F9F0
    public void .cctor(){} // RVA: 0x7FFACBC4FB80
}

public class SecP160R1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Curve Size; // 0x10
    public uint[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBA8B4E0
}

public class SecP160R2Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC4FC20
    public void .cctor(){} // RVA: 0x7FFACBC4FDB0
}

public class SecP160R2LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Curve Size; // 0x10
    public uint[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBA90480
}

public class SecP192K1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC4FE50
    public void .cctor(){} // RVA: 0x7FFACBC50330
}

public class SecP192K1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Curve Size; // 0x10
    public uint[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBA95260
}

public class SecP192R1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC503D0
    public void .cctor(){} // RVA: 0x7FFACBC50560
}

public class SecP192R1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Curve Size; // 0x10
    public uint[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBA9A200
}

public class SecP224K1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC50600
    public void .cctor(){} // RVA: 0x7FFACBC50AE0
}

public class SecP224K1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve Size; // 0x10
    public uint[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBA9EF40
}

public class SecP224R1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC50B80
    public void .cctor(){} // RVA: 0x7FFACBC50D10
}

public class SecP224R1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve Size; // 0x10
    public uint[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAA40C0
}

public class SecP256K1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC50DB0
    public void .cctor(){} // RVA: 0x7FFACBC51290
}

public class SecP256K1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Curve Size; // 0x10
    public uint[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAA9C40
}

public class SecP256R1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC51330
    public void .cctor(){} // RVA: 0x7FFACBC514C0
}

public class SecP256R1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Curve Size; // 0x10
    public uint[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAAEC80
}

public class SecP384R1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC51560
    public void .cctor(){} // RVA: 0x7FFACBC516F0
}

public class SecP384R1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Curve Size; // 0x10
    public uint[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAB3AF0
}

public class SecP521R1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC51790
    public void .cctor(){} // RVA: 0x7FFACBC51920
}

public class SecP521R1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Curve Size; // 0x10
    public uint[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAB9060
}

public class SecT113R1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC519C0
    public void .cctor(){} // RVA: 0x7FFACBC51B50
}

public class SecT113R1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAC0A80
}

public class SecT113R2Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC51BF0
    public void .cctor(){} // RVA: 0x7FFACBC51D80
}

public class SecT113R2LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAC3260
}

public class SecT131R1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC51E20
    public void .cctor(){} // RVA: 0x7FFACBC51FB0
}

public class SecT131R1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R1Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAC8A50
}

public class SecT131R2Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC52050
    public void .cctor(){} // RVA: 0x7FFACBC521E0
}

public class SecT131R2LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBACB100
}

public class SecT163K1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC52280
    public void .cctor(){} // RVA: 0x7FFACBC523D0
}

public class SecT163K1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAD0450
}

public class SecT163R1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC52470
    public void .cctor(){} // RVA: 0x7FFACBC52600
}

public class SecT163R1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R1Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAD29E0
}

public class SecT163R2Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC526A0
    public void .cctor(){} // RVA: 0x7FFACBC52830
}

public class SecT163R2LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R2Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAD5040
}

public class SecT193R1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC528D0
    public void .cctor(){} // RVA: 0x7FFACBC52A60
}

public class SecT193R1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBADA460
}

public class SecT193R2Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC52B00
    public void .cctor(){} // RVA: 0x7FFACBC52C90
}

public class SecT193R2LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBADCB30
}

public class SecT233K1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC52D30
    public void .cctor(){} // RVA: 0x7FFACBC52E80
}

public class SecT233K1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAE1DC0
}

public class SecT233R1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC52F20
    public void .cctor(){} // RVA: 0x7FFACBC530B0
}

public class SecT233R1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT233R1Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAE4360
}

public class SecT239K1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC53150
    public void .cctor(){} // RVA: 0x7FFACBC532A0
}

public class SecT239K1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAE93B0
}

public class SecT283K1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC53340
    public void .cctor(){} // RVA: 0x7FFACBC53490
}

public class SecT283K1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAEEDB0
}

public class SecT283R1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC53530
    public void .cctor(){} // RVA: 0x7FFACBC536C0
}

public class SecT283R1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT283R1Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAF13C0
}

public class SecT409K1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC53760
    public void .cctor(){} // RVA: 0x7FFACBC538B0
}

public class SecT409K1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAF64E0
}

public class SecT409R1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC53950
    public void .cctor(){} // RVA: 0x7FFACBC53AE0
}

public class SecT409R1LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Curve Size; // 0x10
    public ulong[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBAF8980
}

public class SecT571K1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC53B80
    public void .cctor(){} // RVA: 0x7FFACBC53CD0
}
