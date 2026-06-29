// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 58
// Methods: 336

public class TIME_DYNAMIC_ZONE_INFORMATION : ValueType
{
    public object Bias;
    public object StandardName;
    public object StandardDate;
    public object StandardBias;
    public object DaylightName;
    public object DaylightDate;
    public object DaylightBias;
    public object TimeZoneKeyName;
    public object DynamicDaylightTimeDisabled;

    // ── Methods ──
    public void GetTimeZoneKeyName(){} // RVA: 0x8AB060
}

public class TIME_ZONE_INFORMATION : ValueType
{
    public object Bias;
    public object StandardName;
    public object StandardDate;
    public object StandardBias;
    public object DaylightName;
    public object DaylightDate;
    public object DaylightBias;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8AB080
    public void GetStandardName(){} // RVA: 0x8AB190
    public void GetDaylightName(){} // RVA: 0x8AB1A0
}

public class TableEntry : Object
{
    public object Ref;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x77D2310
}

public class TableSchemaInfo : Object
{
    public object TableSchema;
    public object ColumnsSchemaMap;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x71C4EE0
}

public class Tables : Object
{
    public object _buckets;
    public object _locks;
    public object _countPerLock;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x4BAF640
}

public class Tables : Object
{
    public object _buckets;
    public object _locks;
    public object _countPerLock;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x4BAF640
}

public class TagInfo : ValueType
{
    public object name;
    public object prefix;
    public object defaultNs;
    public object defaultNsState;
    public object xmlSpace;
    public object xmlLang;
    public object prevNsTop;
    public object prefixCount;
    public object mixed;

    // ── Methods ──
    public void Init(){} // RVA: 0x915BC0
}

public class TagsLinkedList : Object
{
    public object _first;

    // ── Methods ──
    public void GetEnumerator(){} // RVA: 0x7241860
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator(){} // RVA: 0x72418C0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7241950
}

public class TaskWrapperAsyncResult : Object
{
    public object Task;
    public object _state;
    public object _completedSynchronously;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x67A2500
    public void System.IAsyncResult.get_AsyncState(){} // RVA: 0xB465B0
    public void System.IAsyncResult.get_CompletedSynchronously(){} // RVA: 0xC38360
    public void System.IAsyncResult.get_IsCompleted(){} // RVA: 0x2283E50
    public void System.IAsyncResult.get_AsyncWaitHandle(){} // RVA: 0x69B9B90
}

public class TaskWrapperAsyncResult : Object
{
    public object Task;
    public object _state;
    public object _completedSynchronously;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x67A2500
    public void System.IAsyncResult.get_AsyncState(){} // RVA: 0xB465B0
    public void System.IAsyncResult.get_CompletedSynchronously(){} // RVA: 0xC38360
    public void System.IAsyncResult.get_IsCompleted(){} // RVA: 0x2283E50
    public void System.IAsyncResult.get_AsyncWaitHandle(){} // RVA: 0x7248CD0
}

public class TempAssemblyComparer : Object
{
    public object s_default;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void Equals(){} // RVA: 0x72018B0
    public void GetHashCode(){} // RVA: 0x7201AE0
    public void .cctor(){} // RVA: 0x7201B90
}

public class TestBuilder : Object
{
    public object _unique;
    public object _tests;

    // ── Methods ──
    public void Append(){} // RVA: 0x70CAB80
    public void ToExpression(){} // RVA: 0x70CAC20
    public void Push(){} // RVA: 0x70CAE30
    public void .ctor(){} // RVA: 0x70CB230
}

public class TextureChangedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7DB5CF0
    public void Invoke(){} // RVA: 0x7DB5DE0
}

public class TextureSheetAnimationModule : ValueType
{
    public object m_ParticleSystem;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_enabled(){} // RVA: 0x977EE0
    public void set_enabled(){} // RVA: 0x977F30
    public void get_mode(){} // RVA: 0x977F40
    public void set_mode(){} // RVA: 0x977F90
    public void get_timeMode(){} // RVA: 0x977FF0
    public void set_timeMode(){} // RVA: 0x978040
    public void get_fps(){} // RVA: 0x9780A0
    public void set_fps(){} // RVA: 0x9780F0
    public void get_numTilesX(){} // RVA: 0x978100
    public void set_numTilesX(){} // RVA: 0x978150
    public void get_numTilesY(){} // RVA: 0x9781B0
    public void set_numTilesY(){} // RVA: 0x978200
    public void get_animation(){} // RVA: 0x978260
    public void set_animation(){} // RVA: 0x9782B0
    public void get_rowMode(){} // RVA: 0x978310
    public void set_rowMode(){} // RVA: 0x978360
    public void get_frameOverTime(){} // RVA: 0x9783C0
    public void set_frameOverTime(){} // RVA: 0x9783F0
    public void get_frameOverTimeBlittable(){} // RVA: 0x978420
    public void set_frameOverTimeBlittable(){} // RVA: 0x9784B0
    public void get_frameOverTimeMultiplier(){} // RVA: 0x978520
    public void set_frameOverTimeMultiplier(){} // RVA: 0x978570
    public void get_startFrame(){} // RVA: 0x978580
    public void set_startFrame(){} // RVA: 0x9785B0
    public void get_startFrameBlittable(){} // RVA: 0x9785E0
    public void set_startFrameBlittable(){} // RVA: 0x978670
    public void get_startFrameMultiplier(){} // RVA: 0x9786E0
    public void set_startFrameMultiplier(){} // RVA: 0x978730
    public void get_cycleCount(){} // RVA: 0x978740
    public void set_cycleCount(){} // RVA: 0x978790
    public void get_rowIndex(){} // RVA: 0x9787F0
    public void set_rowIndex(){} // RVA: 0x978840
    public void get_uvChannelMask(){} // RVA: 0x9788A0
    public void set_uvChannelMask(){} // RVA: 0x9788F0
    public void get_spriteCount(){} // RVA: 0x978950
    public void get_speedRange(){} // RVA: 0x9789A0
    public void set_speedRange(){} // RVA: 0x9789B0
    public void AddSprite(){} // RVA: 0x978A10
    public void RemoveSprite(){} // RVA: 0x978A20
    public void SetSprite(){} // RVA: 0x978A80
    public void GetSprite(){} // RVA: 0x978A90
    public void get_frameOverTimeBlittable_Injected(){} // RVA: 0x7CC0A30
    public void set_frameOverTimeBlittable_Injected(){} // RVA: 0x7CC0A90
    public void get_startFrameBlittable_Injected(){} // RVA: 0x7CC0AF0
    public void set_startFrameBlittable_Injected(){} // RVA: 0x7CC0B50
    public void get_speedRange_Injected(){} // RVA: 0x7CC0BB0
    public void set_speedRange_Injected(){} // RVA: 0x7CC0C10
    public void AddSprite_Injected(){} // RVA: 0x7CC0C70
    public void SetSprite_Injected(){} // RVA: 0x7CC0CD0
    public void GetSprite_Injected(){} // RVA: 0x7CC0D40
}

public class ThreadContext : Object
{
    public object m_NestedIOCount;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class ThreadLocalState : Object
{
    public object BufferWriter;
    public object Writer;
    public object RentedWriters;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x730ED00
}

public class TimeSpanRawInfo : ValueType
{
    public object _lastSeenTTT;
    public object _tokenCount;
    public object _sepCount;
    public object _numCount;
    public object _posLoc;
    public object _negLoc;
    public object _posLocInit;
    public object _negLocInit;
    public object _fullPosPattern;
    public object _fullNegPattern;
    public object _numbers0;
    public object _numbers1;
    public object _numbers2;
    public object _numbers3;
    public object _numbers4;
    public object _literals0;
    public object _literals1;
    public object _literals2;
    public object _literals3;
    public object _literals4;
    public object _literals5;

    // ── Methods ──
    public void get_PositiveInvariant(){} // RVA: 0x683F100
    public void get_NegativeInvariant(){} // RVA: 0x683F180
    public void get_PositiveLocalized(){} // RVA: 0x683F200
    public void get_NegativeLocalized(){} // RVA: 0x683F2D0
    public void FullAppCompatMatch(){} // RVA: 0x683F3A0
    public void PartialAppCompatMatch(){} // RVA: 0x683F690
    public void FullMatch(){} // RVA: 0x683F900
    public void FullDMatch(){} // RVA: 0x683FC70
    public void FullHMMatch(){} // RVA: 0x683FDF0
    public void FullDHMMatch(){} // RVA: 0x683FFD0
    public void FullHMSMatch(){} // RVA: 0x6840240
    public void FullDHMSMatch(){} // RVA: 0x68404B0
    public void FullHMSFMatch(){} // RVA: 0x68407A0
    public void Init(){} // RVA: 0x6840A90
    public void ProcessToken(){} // RVA: 0x6840AF0
    public void AddSep(){} // RVA: 0x6840D00
    public void AddNum(){} // RVA: 0x6840E50
}

public class TimeSpanResult : ValueType
{
    public object parsedTimeSpan;
    public object _throwOnFailure;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8B3AE0
    public void SetFailure(){} // RVA: 0x8B3AF0
}

public class TimeSpanSeconds : Object
{
    // ── Methods ──
    public void TryParse(){} // RVA: 0x727FA20
}

public class TimeSpanSplitter : ValueType
{
    public object V1;
    public object V2;
    public object V3;
    public object V4;
    public object V5;
    public object IsNegative;
    public object Separators;

    // ── Methods ──
    public void TrySplitTimeSpan(){} // RVA: 0x8E8590
    public void ParseComponent(){} // RVA: 0x6D3EC00
}

public class TimeSpanSplitter : ValueType
{
    public object V1;
    public object V2;
    public object V3;
    public object V4;
    public object V5;
    public object IsNegative;
    public object Separators;

    // ── Methods ──
    public void TrySplitTimeSpan(){} // RVA: 0x8B5AD0
    public void ParseComponent(){} // RVA: 0x6897DA0
}

public class TimeSpanToken : ValueType
{
    public object _ttt;
    public object _num;
    public object _zeroes;
    public object _sep;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x683ED90
    public void IsInvalidFraction(){} // RVA: 0x683EDB0
}

public class TimeSpanTokenizer : ValueType
{
    public object _value;
    public object _pos;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x425D090
    public void GetNextToken(){} // RVA: 0x683EE20
    public void get_EOL(){} // RVA: 0x683F060
    public void BackOne(){} // RVA: 0x683F0A0
    public void get_NextChar(){} // RVA: 0x683F0B0
}

public class TimeoutTracker : ValueType
{
    public object m_total;
    public object m_start;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8FEE00
    public void get_RemainingMilliseconds(){} // RVA: 0x8FEE10
    public void get_IsExpired(){} // RVA: 0x8FEE60
}

public class Timer : Object
{
    public object m_StartTimeMilliseconds;
    public object m_DurationMilliseconds;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7594300
    public void get_StartTime(){} // RVA: 0xB8F8F0
    public void get_Expiration(){} // RVA: 0x7594320
    public void Cancel(){} // RVA: 0x87D280
    public void get_HasExpired(){} // RVA: 0x87D280
    public void Dispose(){} // RVA: 0xBFA230
}

public class TimerNode : Timer
{
    public object m_TimerState;
    public object m_Callback;
    public object m_Context;
    public object m_QueueLock;
    public object next;
    public object prev;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7594DB0
    public void get_HasExpired(){} // RVA: 0x7594DE0
    public void get_Next(){} // RVA: 0xD05CA0
    public void set_Next(){} // RVA: 0xD09D70
    public void get_Prev(){} // RVA: 0xBC1B30
    public void set_Prev(){} // RVA: 0xB6A8C0
    public void Cancel(){} // RVA: 0x7594DF0
    public void Fire(){} // RVA: 0x7595030
}

public class TimerQueue : Queue
{
    public object m_ThisHandle;
    public object m_Timers;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7594330
    public void CreateTimer(){} // RVA: 0x75944B0
    public void Fire(){} // RVA: 0x7594980
}

public class Title : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x664A2C0
}

public class ToStringClass : NullableMethodCallInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70C31E0
    public void .ctor(){} // RVA: 0xB43310
}

public class ToUnderlying : NumericConvertInstruction
{
    // ── Methods ──
    public void get_InstructionName(){} // RVA: 0x70BD5A0
    public void .ctor(){} // RVA: 0x70BD5E0
    public void Convert(){} // RVA: 0x70BD5F0
}

public class Token : Object
{
    // ── Methods ──
    public void Check(){} // RVA: 0x727ED80
    public void TryCheck(){} // RVA: 0x727EEA0
}

public class TopLevelAssemblyTypeResolver : Object
{
    public object m_topLevelAssembly;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void ResolveType(){} // RVA: 0x67A7D50
}

public class TrackCacheManager : ValueType
{
    public object trackCache;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x947C80
    public void Dispose(){} // RVA: 0x947CE0
    public void GetTrackAssetsFromRuntimeElements(){} // RVA: 0x947CF0
}

public class TrackedCachingContexts : Object
{
    public object MaxTrackedContexts;
    public object s_trackedContexts;
    public object s_optionsComparer;

    // ── Methods ──
    public void GetOrCreate(){} // RVA: 0x7312DB0
    public void TryGetContext(){} // RVA: 0x7313180
    public void .cctor(){} // RVA: 0x7313370
}

public class TrackedOptionsInstances : Object
{
    public object _all;

    // ── Methods ──
    public void get_All(){} // RVA: 0x7313B50
    public void .cctor(){} // RVA: 0x7313BB0
}

public class TrailModule : ValueType
{
    public object m_ParticleSystem;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_enabled(){} // RVA: 0x9813A0
    public void set_enabled(){} // RVA: 0x9813F0
    public void get_mode(){} // RVA: 0x981400
    public void set_mode(){} // RVA: 0x981450
    public void get_ratio(){} // RVA: 0x9814B0
    public void set_ratio(){} // RVA: 0x981500
    public void get_lifetime(){} // RVA: 0x981510
    public void set_lifetime(){} // RVA: 0x981540
    public void get_lifetimeBlittable(){} // RVA: 0x981570
    public void set_lifetimeBlittable(){} // RVA: 0x981600
    public void get_lifetimeMultiplier(){} // RVA: 0x981670
    public void set_lifetimeMultiplier(){} // RVA: 0x9816C0
    public void get_minVertexDistance(){} // RVA: 0x9816D0
    public void set_minVertexDistance(){} // RVA: 0x981720
    public void get_textureMode(){} // RVA: 0x981730
    public void set_textureMode(){} // RVA: 0x981780
    public void get_textureScale(){} // RVA: 0x9817E0
    public void set_textureScale(){} // RVA: 0x9817F0
    public void get_worldSpace(){} // RVA: 0x981850
    public void set_worldSpace(){} // RVA: 0x9818A0
    public void get_dieWithParticles(){} // RVA: 0x9818B0
    public void set_dieWithParticles(){} // RVA: 0x981900
    public void get_sizeAffectsWidth(){} // RVA: 0x981910
    public void set_sizeAffectsWidth(){} // RVA: 0x981960
    public void get_sizeAffectsLifetime(){} // RVA: 0x981970
    public void set_sizeAffectsLifetime(){} // RVA: 0x9819C0
    public void get_inheritParticleColor(){} // RVA: 0x9819D0
    public void set_inheritParticleColor(){} // RVA: 0x981A20
    public void get_colorOverLifetime(){} // RVA: 0x981A30
    public void set_colorOverLifetime(){} // RVA: 0x981A70
    public void get_colorOverLifetimeBlittable(){} // RVA: 0x981AB0
    public void set_colorOverLifetimeBlittable(){} // RVA: 0x981B60
    public void get_widthOverTrail(){} // RVA: 0x981BE0
    public void set_widthOverTrail(){} // RVA: 0x981C10
    public void get_widthOverTrailBlittable(){} // RVA: 0x981C40
    public void set_widthOverTrailBlittable(){} // RVA: 0x981CD0
    public void get_widthOverTrailMultiplier(){} // RVA: 0x981D40
    public void set_widthOverTrailMultiplier(){} // RVA: 0x981D90
    public void get_colorOverTrail(){} // RVA: 0x981DA0
    public void set_colorOverTrail(){} // RVA: 0x981DE0
    public void get_colorOverTrailBlittable(){} // RVA: 0x981E20
    public void set_colorOverTrailBlittable(){} // RVA: 0x981ED0
    public void get_generateLightingData(){} // RVA: 0x981F50
    public void set_generateLightingData(){} // RVA: 0x981FA0
    public void get_ribbonCount(){} // RVA: 0x981FB0
    public void set_ribbonCount(){} // RVA: 0x982000
    public void get_shadowBias(){} // RVA: 0x982060
    public void set_shadowBias(){} // RVA: 0x9820B0
    public void get_splitSubEmitterRibbons(){} // RVA: 0x9820C0
    public void set_splitSubEmitterRibbons(){} // RVA: 0x982110
    public void get_attachRibbonsToTransform(){} // RVA: 0x982120
    public void set_attachRibbonsToTransform(){} // RVA: 0x982170
    public void get_lifetimeBlittable_Injected(){} // RVA: 0x7CD4C50
    public void set_lifetimeBlittable_Injected(){} // RVA: 0x7CD4CB0
    public void get_textureScale_Injected(){} // RVA: 0x7CD4D10
    public void set_textureScale_Injected(){} // RVA: 0x7CD4D70
    public void get_colorOverLifetimeBlittable_Injected(){} // RVA: 0x7CD4DD0
    public void set_colorOverLifetimeBlittable_Injected(){} // RVA: 0x7CD4E30
    public void get_widthOverTrailBlittable_Injected(){} // RVA: 0x7CD4E90
    public void set_widthOverTrailBlittable_Injected(){} // RVA: 0x7CD4EF0
    public void get_colorOverTrailBlittable_Injected(){} // RVA: 0x7CD4F50
    public void set_colorOverTrailBlittable_Injected(){} // RVA: 0x7CD4FB0
}

public class Trails : ValueType
{
    public object positions;
    public object frontPositions;
    public object backPositions;
    public object positionCounts;
    public object textureOffsets;
    public object maxTrailCount;
    public object maxPositionsPerTrailCount;

    // ── Methods ──
    public void Allocate(){} // RVA: 0x979B40
}

public class TransitionTime : ValueType
{
    public object _timeOfDay;
    public object _month;
    public object _week;
    public object _day;
    public object _dayOfWeek;
    public object _isFixedDateRule;

    // ── Methods ──
    public void get_TimeOfDay(){} // RVA: 0x77900
    public void get_Month(){} // RVA: 0x7E230
    public void get_Week(){} // RVA: 0x7E240
    public void get_Day(){} // RVA: 0x8B0740
    public void get_DayOfWeek(){} // RVA: 0x92DE0
    public void get_IsFixedDateRule(){} // RVA: 0xB1800
    public void Equals(){} // RVA: 0x8B07F0
    public void op_Inequality(){} // RVA: 0x67E92D0
    public void GetHashCode(){} // RVA: 0x8B0820
    public void .ctor(){} // RVA: 0x8B0880
    public void CreateFixedDateRule(){} // RVA: 0x67E94A0
    public void CreateFloatingDateRule(){} // RVA: 0x67E9520
    public void ValidateTransitionTime(){} // RVA: 0x67E95B0
    public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x8B0850
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x8B0860
}

public class TreePage : Object
{
    public object _slots;
    public object _slotMap;
    public object _inUseCount;
    public object _pageId;
    public object _nextFreeSlotLine;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8944F0
    public void AllocSlot(){} // RVA: 0x87D050
    public void get_InUseCount(){} // RVA: 0x87C130
    public void set_InUseCount(){} // RVA: 0x8944F0
    public void get_PageId(){} // RVA: 0x87C130
    public void set_PageId(){} // RVA: 0x8944F0
}

public class TreePage : Object
{
    public object _slots;
    public object _slotMap;
    public object _inUseCount;
    public object _pageId;
    public object _nextFreeSlotLine;

    // ── Methods ──
    public void set_InUseCount(){} // RVA: 0x1269760
    public void get_PageId(){} // RVA: 0x15AF000
    public void .ctor(){} // RVA: 0x4F2CCE0
    public void set_PageId(){} // RVA: 0x1FAA840
    public void get_InUseCount(){} // RVA: 0xFEAE90
    public void AllocSlot(){} // RVA: 0x4F2CB70
}

public class TreePage : Object
{
    public object _slots;
    public object _slotMap;
    public object _inUseCount;
    public object _pageId;
    public object _nextFreeSlotLine;

    // ── Methods ──
    public void set_InUseCount(){} // RVA: 0x1269760
    public void get_PageId(){} // RVA: 0x15AF000
    public void .ctor(){} // RVA: 0x4F2CA00
    public void set_PageId(){} // RVA: 0x1FAA840
    public void get_InUseCount(){} // RVA: 0xFEAE90
    public void AllocSlot(){} // RVA: 0x4F2CB70
}

public class TriangleDataShaderIds : Object
{
    public object _TriangleBuffer;
    public object _TrianglesDispatchIndirectArgs;
    public object _TrianglesCount;
    public object _TrianglesDrawIndirectArgs;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x26BC0E0
}

public class TriggerModule : ValueType
{
    public object m_ParticleSystem;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_enabled(){} // RVA: 0x977550
    public void set_enabled(){} // RVA: 0x9775A0
    public void get_inside(){} // RVA: 0x9775B0
    public void set_inside(){} // RVA: 0x977600
    public void get_outside(){} // RVA: 0x977660
    public void set_outside(){} // RVA: 0x9776B0
    public void get_enter(){} // RVA: 0x977710
    public void set_enter(){} // RVA: 0x977760
    public void get_exit(){} // RVA: 0x9777C0
    public void set_exit(){} // RVA: 0x977810
    public void get_colliderQueryMode(){} // RVA: 0x977870
    public void set_colliderQueryMode(){} // RVA: 0x9778C0
    public void get_radiusScale(){} // RVA: 0x977920
    public void set_radiusScale(){} // RVA: 0x977970
    public void AddCollider(){} // RVA: 0x977980
    public void RemoveCollider(){} // RVA: 0x9779F0
    public void RemoveColliderObject(){} // RVA: 0x977A00
    public void SetCollider(){} // RVA: 0x977A10
    public void GetCollider(){} // RVA: 0x977A20
    public void get_colliderCount(){} // RVA: 0x977A30
    public void AddCollider_Injected(){} // RVA: 0x7CBEE80
    public void RemoveColliderObject_Injected(){} // RVA: 0x7CBEEE0
    public void SetCollider_Injected(){} // RVA: 0x7CBEF40
    public void GetCollider_Injected(){} // RVA: 0x7CBEFB0
}

public class TryExpressionProxy : Object
{
    public object _node;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7049FB0
    public void get_Body(){} // RVA: 0x13F9400
    public void get_CanReduce(){} // RVA: 0x10AD460
    public void get_DebugView(){} // RVA: 0x7048AD0
    public void get_Fault(){} // RVA: 0x13F9420
    public void get_Finally(){} // RVA: 0x13F92F0
    public void get_Handlers(){} // RVA: 0x13F92B0
    public void get_NodeType(){} // RVA: 0x10AD380
    public void get_Type(){} // RVA: 0x10ACB60
}

public class TryFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6422C10
    public void Invoke(){} // RVA: 0xCA8BF0
}

public class TypeBinaryExpressionProxy : Object
{
    public object _node;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x704A090
    public void get_CanReduce(){} // RVA: 0x10AD460
    public void get_DebugView(){} // RVA: 0x7048AD0
    public void get_Expression(){} // RVA: 0x13F9400
    public void get_NodeType(){} // RVA: 0x10AD380
    public void get_Type(){} // RVA: 0x10ACB60
    public void get_TypeOperand(){} // RVA: 0x13F92B0
}

public class TypeConstructorVisitor : Object
{
    public object TypeConstructor;

    // ── Methods ──
    public void Visit(){} // RVA: 0x894290
    public void .ctor(){} // RVA: 0xB43310
}

public class TypeConstructor`1 : Object
{
    public object m_ExplicitConstructor;
    public object m_ImplicitConstructor;
    public object m_OverrideConstructor;

    // ── Methods ──
    public void Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated(){} // RVA: 0x87D280
    public void .ctor(){} // RVA: 0x894290
    public void SetImplicitConstructor(){} // RVA: 0x894290
    public void CreateValueTypeInstance(){} // RVA: 0xA94080
    public void CreateScriptableObjectInstance(){} // RVA: 0xA94080
    public void CreateClassInstance(){} // RVA: 0xA94080
    public void SetExplicitConstructor(){} // RVA: 0x894320
    public void Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate(){} // RVA: 0xA94080
    public void Unity.Properties.TypeUtility.ITypeConstructor.Instantiate(){} // RVA: 0x87C0A0
}

public class TypeDescriptionNode : TypeDescriptionProvider
{
    public object Next;
    public object Provider;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44DC0
    public void CreateInstance(){} // RVA: 0x7709EE0
    public void GetCache(){} // RVA: 0x770A070
    public void GetExtendedTypeDescriptor(){} // RVA: 0x770A100
    public void GetExtenderProviders(){} // RVA: 0x770A1D0
    public void GetFullComponentName(){} // RVA: 0x770A260
    public void GetReflectionType(){} // RVA: 0x770A2F0
    public void GetRuntimeType(){} // RVA: 0x770A3B0
    public void GetTypeDescriptor(){} // RVA: 0x770A460
    public void IsSupportedType(){} // RVA: 0x770A5D0
}

public class TypeDescriptorComObject : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class TypeDescriptorInterface : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class TypeInfo : Object
{
    public object Attributes;
    public object Elements;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class TypeInfo : Object
{
    public object DelegateType;
    public object TypeChain;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class TypeNAssembly : Object
{
    public object type;
    public object assemblyName;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class TypeRestriction : BindingRestrictions
{
    public object _expression;
    public object _type;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x70CB8A0
    public void Equals(){} // RVA: 0x70CB9B0
    public void GetHashCode(){} // RVA: 0x70CBA90
    public void GetExpression(){} // RVA: 0x70CBAF0
}

public class tBigInt : ValueType
{
    public object m_length;
    public object m_blocks;

    // ── Methods ──
    public void GetLength(){} // RVA: 0x77E60
    public void GetBlock(){} // RVA: 0x923F10
    public void IsZero(){} // RVA: 0x8E95B0
    public void SetU64(){} // RVA: 0x923F20
    public void SetU32(){} // RVA: 0x923F50
}

public class tFloatUnion32 : ValueType
{
    public object m_floatingPoint;
    public object m_integer;

    // ── Methods ──
    public void IsNegative(){} // RVA: 0x8BE0A0
    public void GetExponent(){} // RVA: 0x923F70
    public void GetMantissa(){} // RVA: 0x923F80
}

public class tFloatUnion64 : ValueType
{
    public object m_floatingPoint;
    public object m_integer;

    // ── Methods ──
    public void IsNegative(){} // RVA: 0x923F90
    public void GetExponent(){} // RVA: 0x923FB0
    public void GetMantissa(){} // RVA: 0x923FC0
}
