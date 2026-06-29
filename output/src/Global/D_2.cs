// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 546

public class DESEncryption : Object
{
    public object Iterations;

    // ── Methods ──
    public void Encrypt(){} // RVA: 0xA0C5590
    public void TryDecrypt(){} // RVA: 0xA0C5A60
    public void .ctor(){} // RVA: 0xB43310
}

public class Data : ApiModel
{
    public object _name;
    public object _shortName;
    public object _template;
    public object _thumbnailImageUrl;
    public object _imageUrl;
    public object _iconImageUrl;
    public object _description;
    public object _tooltipDescription;
    public object _taglineText;
    public object _version;
    public object _isNew;
    public object _onPressed;
    public object _disclaimerText;
    public object _worldTag;
    public object _hoverToJoin;
    public object _contentList;
    public object _domainList;
    public object _search;
    public object _ipsQuery;
    public object _article;
    public object _categories;
    public object _promotion;
    public object _featuredAvatarCategoryId;
    public object _listingIds;
    public object _weight;
    public object _category;

    // ── Methods ──
    public void get_name(){} // RVA: 0xBBFF90
    public void set_name(){} // RVA: 0xBBFFA0
    public void get_shortName(){} // RVA: 0xC10050
    public void set_shortName(){} // RVA: 0xC10060
    public void get_template(){} // RVA: 0xCD3320
    public void set_template(){} // RVA: 0xCD4740
    public void get_thumbnailImageUrl(){} // RVA: 0xCD48B0
    public void set_thumbnailImageUrl(){} // RVA: 0xCD3600
    public void get_imageUrl(){} // RVA: 0xB813B0
    public void set_imageUrl(){} // RVA: 0xD5CBB0
    public void get_iconImageUrl(){} // RVA: 0x1069350
    public void set_iconImageUrl(){} // RVA: 0xD5CC10
    public void get_description(){} // RVA: 0x106A7D0
    public void set_description(){} // RVA: 0xD5CC70
    public void get_tooltipDescription(){} // RVA: 0x106A050
    public void set_tooltipDescription(){} // RVA: 0xD5CCD0
    public void get_taglineText(){} // RVA: 0x12EB090
    public void set_taglineText(){} // RVA: 0x13B1040
    public void get_version(){} // RVA: 0xBAE340
    public void set_version(){} // RVA: 0xBAE350
    public void get_isNew(){} // RVA: 0x20119F0
    public void set_isNew(){} // RVA: 0x2013510
    public void get_onPressed(){} // RVA: 0xBAE420
    public void set_onPressed(){} // RVA: 0xBAE430
    public void get_disclaimerText(){} // RVA: 0xCA4D80
    public void set_disclaimerText(){} // RVA: 0xCA4D90
    public void get_worldTag(){} // RVA: 0xC68EB0
    public void set_worldTag(){} // RVA: 0xC68EC0
    public void get_hoverToJoin(){} // RVA: 0x11629E0
    public void set_hoverToJoin(){} // RVA: 0x1AE6E90
    public void get_contentList(){} // RVA: 0xBC5B30
    public void set_contentList(){} // RVA: 0xBC5B40
    public void get_domainList(){} // RVA: 0xBC5BA0
    public void set_domainList(){} // RVA: 0xBC5BB0
    public void get_search(){} // RVA: 0xBAE5A0
    public void set_search(){} // RVA: 0xBAE5B0
    public void get_ipsQuery(){} // RVA: 0x135A7B0
    public void set_ipsQuery(){} // RVA: 0xEC0BB0
    public void get_article(){} // RVA: 0x10B4170
    public void set_article(){} // RVA: 0x15B42C0
    public void .ctor(){} // RVA: 0xA51BD10
    public void get_categories(){} // RVA: 0x10B9D50
    public void set_categories(){} // RVA: 0x15B7570
    public void get_promotion(){} // RVA: 0xD9E3D0
    public void set_promotion(){} // RVA: 0xD9D290
    public void get_featuredAvatarCategoryId(){} // RVA: 0xDA0520
    public void set_featuredAvatarCategoryId(){} // RVA: 0xD9D570
    public void get_listingIds(){} // RVA: 0x114AC20
    public void set_listingIds(){} // RVA: 0x1149C90
    public void get_weight(){} // RVA: 0x6CE7E30
    public void set_weight(){} // RVA: 0x6CE7E40
    public void get_category(){} // RVA: 0x135EDB0
    public void set_category(){} // RVA: 0x1658000
}

public class DataElementDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1F62250
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x6C551C0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class DataPlayableOutputEnumerator : Object
{
    public object m_List;
    public object m_Index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x67F4370
    public void get_Current(){} // RVA: 0x7C556F0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7C558B0
    public void Dispose(){} // RVA: 0x627C9E0
    public void MoveNext(){} // RVA: 0x7C55910
    public void Reset(){} // RVA: 0x2576860
}

public class DataPlayableOutputList : Object
{
    public object m_Outputs;
    public object m_Count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2232610
    public void get_Item(){} // RVA: 0x7C55500
    public void get_Count(){} // RVA: 0xE62D00
    public void GetEnumerator(){} // RVA: 0x7C55650
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7C55650
}

public class DataSet`1 : Object
{
    public object _disposed;
    public object gpuData;
    public object cpuData;
    public object updateRanges;
    public object allocator;
    public object m_UpdateRangePoolSize;
    public object m_ElemStride;
    public object m_UpdateRangeMin;
    public object m_UpdateRangeMax;
    public object m_UpdateRangesEnqueued;
    public object m_UpdateRangesBatchStart;
    public object m_UpdateRangesSaturated;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void get_disposed(){} // RVA: 0x87D280
    public void set_disposed(){} // RVA: 0x894750
    public void Dispose(){} // RVA: 0x894750
    public void RegisterUpdate(){} // RVA: 0x8965E0
    public void HasMappedBufferRange(){} // RVA: 0x87D280
    public void SendUpdates(){} // RVA: 0x894290
    public void SendFullRange(){} // RVA: 0x894290
    public void SendPartialRanges(){} // RVA: 0x894290
    public void ResetUpdateState(){} // RVA: 0x894290
}

public class DataSet`1 : Object
{
    public object _disposed;
    public object gpuData;
    public object cpuData;
    public object updateRanges;
    public object allocator;
    public object m_UpdateRangePoolSize;
    public object m_ElemStride;
    public object m_UpdateRangeMin;
    public object m_UpdateRangeMax;
    public object m_UpdateRangesEnqueued;
    public object m_UpdateRangesBatchStart;
    public object m_UpdateRangesSaturated;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A9090
    public void get_disposed(){} // RVA: 0xC120A0
    public void set_disposed(){} // RVA: 0xC120B0
    public void Dispose(){} // RVA: 0x35A9580
    public void RegisterUpdate(){} // RVA: 0x35A9690
    public void HasMappedBufferRange(){} // RVA: 0x35A9880
    public void SendUpdates(){} // RVA: 0x35A9900
    public void SendFullRange(){} // RVA: 0x35A9AF0
    public void SendPartialRanges(){} // RVA: 0x35A9C40
    public void ResetUpdateState(){} // RVA: 0x35A9060
}

public class DataSet`1 : Object
{
    public object _disposed;
    public object gpuData;
    public object cpuData;
    public object updateRanges;
    public object allocator;
    public object m_UpdateRangePoolSize;
    public object m_ElemStride;
    public object m_UpdateRangeMin;
    public object m_UpdateRangeMax;
    public object m_UpdateRangesEnqueued;
    public object m_UpdateRangesBatchStart;
    public object m_UpdateRangesSaturated;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A8260
    public void get_disposed(){} // RVA: 0xC120A0
    public void set_disposed(){} // RVA: 0xC120B0
    public void Dispose(){} // RVA: 0x35A8760
    public void RegisterUpdate(){} // RVA: 0x35A8870
    public void HasMappedBufferRange(){} // RVA: 0x35A8A60
    public void SendUpdates(){} // RVA: 0x35A8AE0
    public void SendFullRange(){} // RVA: 0x35A8CD0
    public void SendPartialRanges(){} // RVA: 0x35A8E20
    public void ResetUpdateState(){} // RVA: 0x35A9060
}

public class DataStorageShadow : Object
{
    public object ParameterString;
    public object ParameterBoolOp;
    public object ParameterFloat;
    public object ParameterInt;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class DataTokenFormatter : BaseFormatter`1
{
    public object _referenceReaderWriter;

    // ── Methods ──
    public void DeserializeImplementation(){} // RVA: 0x833C5C0
    public void SerializeImplementation(){} // RVA: 0x833CD10
    public void .ctor(){} // RVA: 0x833D240
    public void .cctor(){} // RVA: 0x833D2A0
}

public class DateMapping : ValueType
{
    public object HijriMonthsLengthFlags;
    public object GregorianDate;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8B3CC0
}

public class DateTimeParseData : ValueType
{
    public object Year;
    public object Month;
    public object Day;
    public object Hour;
    public object Minute;
    public object Second;
    public object Fraction;
    public object OffsetHours;
    public object OffsetMinutes;
    public object OffsetToken;

    // ── Methods ──
    public void get_OffsetNegative(){} // RVA: 0x8ED310
}

public class DbRow : ValueType
{
    public object _location;
    public object _sizeOrLengthUnion;
    public object _numberOfRowsAndTypeUnion;

    // ── Methods ──
    public void get_Location(){} // RVA: 0x77E60
    public void get_SizeOrLength(){} // RVA: 0x8ED510
    public void get_IsUnknownSize(){} // RVA: 0x8ED520
    public void get_HasComplexChildren(){} // RVA: 0x8ED530
    public void get_NumberOfRows(){} // RVA: 0x8ED540
    public void get_TokenType(){} // RVA: 0x8ED550
    public void .ctor(){} // RVA: 0x8ED560
    public void get_IsSimpleValue(){} // RVA: 0x8ED580
}

public class DebugImageInfo : Object
{
    public object Image;
    public object StartAddress;
    public object EndAddress;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6DDB830
    public void ContainsAddress(){} // RVA: 0x6DDB970
}

public class DecCalc : ValueType
{
    public object uflags;
    public object uhi;
    public object ulo;
    public object umid;
    public object ulomidLE;
    public object s_powers10;
    public object s_ulongPowers10;
    public object s_doublePowers10;
    public object PowerOvflValues;

    // ── Methods ──
    public void get_High(){} // RVA: 0x77E50
    public void set_High(){} // RVA: 0x77EE0
    public void get_Low(){} // RVA: 0x14790
    public void set_Low(){} // RVA: 0x92DD0
    public void get_Mid(){} // RVA: 0x92DE0
    public void set_Mid(){} // RVA: 0x92DF0
    public void get_IsNegative(){} // RVA: 0x8B93C0
    public void get_Scale(){} // RVA: 0x90550
    public void get_Low64(){} // RVA: 0x8C0C50
    public void set_Low64(){} // RVA: 0x990A0
    public void GetExponent(){} // RVA: 0x6994FF0
    public void UInt32x32To64(){} // RVA: 0x6898710
    public void UInt64x64To128(){} // RVA: 0x6995000
    public void Div96By32(){} // RVA: 0x6995170
    public void Div96ByConst(){} // RVA: 0x69951E0
    public void Unscale(){} // RVA: 0x6995240
    public void Div96By64(){} // RVA: 0x6995450
    public void Div128By96(){} // RVA: 0x69955A0
    public void IncreaseScale(){} // RVA: 0x69956C0
    public void IncreaseScale64(){} // RVA: 0x6995750
    public void ScaleResult(){} // RVA: 0x69957D0
    public void DivByConst(){} // RVA: 0x6995F60
    public void LeadingZeroCount(){} // RVA: 0x6995FE0
    public void OverflowUnscale(){} // RVA: 0x6996040
    public void SearchScale(){} // RVA: 0x6996170
    public void Add32To96(){} // RVA: 0x6996350
    public void DecAddSub(){} // RVA: 0x6996370
    public void VarCyFromDec(){} // RVA: 0x6996AB0
    public void VarDecCmp(){} // RVA: 0x6996CD0
    public void VarDecCmpSub(){} // RVA: 0x6996DF0
    public void VarDecMul(){} // RVA: 0x6997000
    public void VarDecFromR4(){} // RVA: 0x6997530
    public void VarDecFromR8(){} // RVA: 0x6997930
    public void VarR4FromDec(){} // RVA: 0x6997D20
    public void VarR8FromDec(){} // RVA: 0x6997D80
    public void GetHashCode(){} // RVA: 0x6997EA0
    public void VarDecDiv(){} // RVA: 0x6997FF0
    public void VarDecMod(){} // RVA: 0x6998A50
    public void VarDecModFull(){} // RVA: 0x6998E50
    public void InternalRound(){} // RVA: 0x6999290
    public void DecDivMod1E9(){} // RVA: 0x69995A0
    public void .cctor(){} // RVA: 0x6999620
}

public class DefaultComparer`1 : ValueType
{
    // ── Methods ──
    public void Compare(){} // RVA: 0xA94080
}

public class DefaultDecoder : Decoder
{
    public object m_encoding;
    public object m_hasInitializedEncoding;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x66D68B0
    public void GetRealObject(){} // RVA: 0x66D6C40
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x66D6CF0
    public void GetCharCount(){} // RVA: 0x66D6FA0
    public void GetChars(){} // RVA: 0x66D7010
}

public class DefaultEncoder : Encoder
{
    public object m_encoding;
    public object m_hasInitializedEncoding;
    public object charLeftOver;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x66D6030
    public void GetRealObject(){} // RVA: 0x66D6450
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x66D6560
    public void GetByteCount(){} // RVA: 0x66D6810
    public void GetBytes(){} // RVA: 0x66D6880
}

public class DefaultF2mLookupTable : Object
{
    public object m_outer;
    public object m_table;
    public object m_size;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x31D5D40
    public void get_Size(){} // RVA: 0xFEAE90
    public void Lookup(){} // RVA: 0xA667D20
}

public class DefaultLookupTable : Object
{
    public object m_outer;
    public object m_table;
    public object m_size;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x31D5D40
    public void get_Size(){} // RVA: 0xFEAE90
    public void Lookup(){} // RVA: 0xA664BB0
}

public class DefaultRuntimeFactory : Object
{
    public object Default;

    // ── Methods ──
    public void CreateGameObject(){} // RVA: 0x7E36320
    public void .ctor(){} // RVA: 0xB43310
    public void .cctor(){} // RVA: 0x7E36390
}

public class DeferPromise : Object
{
    public object factory;
    public object task;
    public object awaiter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void GetResult(){} // RVA: 0x7756C20
    public void GetStatus(){} // RVA: 0x7756C80
    public void OnCompleted(){} // RVA: 0x7756E60
    public void UnsafeGetStatus(){} // RVA: 0x7756F10
}

public class DeferPromiseWithState`1 : Object
{
    public object factory;
    public object argument;
    public object task;
    public object awaiter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
}

public class DeferPromiseWithState`2 : Object
{
    public object factory;
    public object argument;
    public object task;
    public object awaiter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
}

public class DeferPromise`1 : Object
{
    public object factory;
    public object task;
    public object awaiter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
}

public class DeferredPassthroughMeshAddition[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class DeflateOutputStream : ZOutputStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xA1DF0D0
    public void Flush(){} // RVA: 0xB43310
}

public class Delegate : Object
{
    public object _parser;
    public object _unknownFields;
    public object delegate_;
    public object delegateCase_;

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x655ED80
    public void get_Descriptor(){} // RVA: 0x655EDE0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x655EE60
    public void .ctor(){} // RVA: 0x655EEB0
    public void Clone(){} // RVA: 0x655F1D0
    public void get_Tflite(){} // RVA: 0x655F230
    public void set_Tflite(){} // RVA: 0x655F290
    public void get_Gpu(){} // RVA: 0x655F2F0
    public void set_Gpu(){} // RVA: 0x655F350
    public void get_Nnapi(){} // RVA: 0x655F3B0
    public void set_Nnapi(){} // RVA: 0x655F410
    public void get_Xnnpack(){} // RVA: 0x655F470
    public void set_Xnnpack(){} // RVA: 0x655F4D0
    public void get_DelegateCase(){} // RVA: 0xFEAE90
    public void ClearDelegate(){} // RVA: 0x64BD500
    public void Equals(){} // RVA: 0x655F590
    public void GetHashCode(){} // RVA: 0x655F750
    public void ToString(){} // RVA: 0x655F980
    public void WriteTo(){} // RVA: 0x64B3910
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x655F9D0
    public void CalculateSize(){} // RVA: 0x655FBD0
    public void MergeFrom(){} // RVA: 0x64B3C50
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x65603F0
    public void .cctor(){} // RVA: 0x6560660
}

public class DelegateEntry : Object
{
    public object type;
    public object assembly;
    public object target;
    public object targetTypeAssembly;
    public object targetTypeName;
    public object methodName;
    public object delegateEntry;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x697D190
    public void DeserializeDelegate(){} // RVA: 0x697D570
}

public class Deleter : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26E1500
    public void Invoke(){} // RVA: 0xB9E010
}

public class DeletionCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xCA8B20
    public void Invoke(){} // RVA: 0xCA8BF0
}

public class DepthOrderedDirtyTracking : ValueType
{
    public object heads;
    public object tails;
    public object minDepths;
    public object maxDepths;
    public object dirtyID;

    // ── Methods ──
    public void EnsureFits(){} // RVA: 0x99DE90
    public void RegisterDirty(){} // RVA: 0x99DEA0
    public void ClearDirty(){} // RVA: 0x99DEB0
    public void Reset(){} // RVA: 0x99DEC0
}

public class DerComparer : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0xA372360
    public void .ctor(){} // RVA: 0xB43310
}

public class DeriveBytes : Object
{
    public object keyDiversifier;
    public object ivDiversifier;
    public object macDiversifier;
    public object _hashName;
    public object _iterations;
    public object _password;
    public object _salt;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void set_HashName(){} // RVA: 0xB44D60
    public void set_IterationCount(){} // RVA: 0x1033F40
    public void set_Password(){} // RVA: 0x663CE90
    public void set_Salt(){} // RVA: 0x663D010
    public void Adjust(){} // RVA: 0x663D170
    public void Derive(){} // RVA: 0x663D270
    public void DeriveKey(){} // RVA: 0x663D720
    public void DeriveIV(){} // RVA: 0x663D7A0
    public void DeriveMAC(){} // RVA: 0x663D820
    public void .cctor(){} // RVA: 0x663D8A0
}

public class Deserialize32QuaternionDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2697880
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x8210800
    public void EndInvoke(){} // RVA: 0x275FED0
}

public class Deserialize32Vector3Delegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2697880
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x8210800
    public void EndInvoke(){} // RVA: 0x275FED0
}

public class DeserializeFloatDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2697880
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x82108B0
    public void EndInvoke(){} // RVA: 0x275FED0
}

public class DeserializeFloatsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2697880
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x8210800
    public void EndInvoke(){} // RVA: 0x275FED0
}

public class DeserializeQuaternionDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2697880
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x8210800
    public void EndInvoke(){} // RVA: 0x275FED0
}

public class DeserializeVector3Delegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2697880
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x8210800
    public void EndInvoke(){} // RVA: 0x275FED0
}

public class Destination[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Development : Object
{
    // ── Methods ──
    public void Log(){} // RVA: 0x6BFFDD0
    public void LogWarning(){} // RVA: 0x6BFFE80
    public void LogError(){} // RVA: 0x6BFFF30
}

public class Development : Object
{
    // ── Methods ──
    public void Log(){} // RVA: 0x6C08190
    public void LogWarning(){} // RVA: 0x6C08210
    public void LogError(){} // RVA: 0x6C08290
    public void LogRequest(){} // RVA: 0xB43310
    public void LogRequestResult(){} // RVA: 0xB43310
}

public class DeviceBuilder : ValueType
{
    public object _device;

    // ── Methods ──
    public void get_device(){} // RVA: 0x77900
    public void set_device(){} // RVA: 0x47F10
    public void WithName(){} // RVA: 0x932310
    public void WithDisplayName(){} // RVA: 0x932320
    public void WithShortDisplayName(){} // RVA: 0x9326D0
    public void WithLayout(){} // RVA: 0x932340
    public void WithChildren(){} // RVA: 0x932430
    public void WithStateBlock(){} // RVA: 0x932470
    public void IsNoisy(){} // RVA: 0x932530
    public void WithControlUsage(){} // RVA: 0x932780
    public void WithControlAlias(){} // RVA: 0x9327A0
    public void WithStateOffsetToControlIndexMap(){} // RVA: 0x932840
    public void WithControlTree(){} // RVA: 0x932850
    public void Finish(){} // RVA: 0x932860
}

public class DeviceConnectedChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x40E2370
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x6F19220
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class DeviceConnectedChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x40E01E0
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x6C4D960
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class DeviceConnectedChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x40E2370
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x6F47EA0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class DeviceIndexChangedHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x40E2AD0
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x6F47F40
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class DeviceInfo : ValueType
{
    public object m_DeviceId;
    public object m_Layout;
    public object m_StateFormat;
    public object m_StateSizeInBytes;
    public object m_FullLayoutJson;

    // ── Methods ──
    public void get_deviceId(){} // RVA: 0x77E60
    public void set_deviceId(){} // RVA: 0x29580
    public void get_layout(){} // RVA: 0x77ED0
    public void set_layout(){} // RVA: 0x77E70
    public void get_stateFormat(){} // RVA: 0x8C7E0
    public void set_stateFormat(){} // RVA: 0x8C7F0
    public void get_stateSizeInBytes(){} // RVA: 0xAFF50
    public void set_stateSizeInBytes(){} // RVA: 0xAFF60
}

public class DeviceLostEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x78E3130
}

public class DeviceRegainedEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x78E3170
}

public class DeviceToFree : ValueType
{
    public object handle;
    public object page;
    public object commandLists;

    // ── Methods ──
    public void Dispose(){} // RVA: 0x99CB30
}

public class DictationCompletedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xC3B2D0
    public void Invoke(){} // RVA: 0xB9E010
}

public class DictationErrorHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26E1340
    public void Invoke(){} // RVA: 0xCA8BF0
}

public class DictationHypothesisDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB9DF20
    public void Invoke(){} // RVA: 0xB9E010
}

public class DictationResultDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26E1340
    public void Invoke(){} // RVA: 0xCA8BF0
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEF40
}

public class DictionaryEnumerator : Object
{
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void MoveNext(){} // RVA: 0x87D280
    public void Reset(){} // RVA: 0x894290
    public void get_Current(){} // RVA: 0x87C0A0
    public void get_Entry(){} // RVA: 0x87BEB0
    public void get_Key(){} // RVA: 0x87C0A0
    public void get_Value(){} // RVA: 0x87C0A0
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryEnumerator : Object
{
    public object _methodDictionary;
    public object _hashtableEnum;
    public object _posMethod;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6778D90
    public void get_Current(){} // RVA: 0x6778EC0
    public void MoveNext(){} // RVA: 0x6778F20
    public void Reset(){} // RVA: 0x67790D0
    public void get_Entry(){} // RVA: 0x6779130
    public void get_Key(){} // RVA: 0x6779280
    public void get_Value(){} // RVA: 0x67792A0
}

public class DictionaryEnumerator`2 : ValueType
{
    public object _e;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void get_Entry(){} // RVA: 0x87BEB0
    public void get_Key(){} // RVA: 0x87C0A0
    public void get_Value(){} // RVA: 0x87C0A0
    public void get_Current(){} // RVA: 0x87C0A0
    public void MoveNext(){} // RVA: 0x87D280
    public void Reset(){} // RVA: 0x894290
}

public class DictionaryEnumerator`2 : ValueType
{
    public object _e;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void get_Entry(){} // RVA: 0x87BEB0
    public void get_Key(){} // RVA: 0x87C0A0
    public void get_Value(){} // RVA: 0x87C0A0
    public void get_Current(){} // RVA: 0x87C0A0
    public void MoveNext(){} // RVA: 0x87D280
    public void Reset(){} // RVA: 0x894290
}

public class DictionaryIterator`2 : ValueType
{
    public object dictionary;
    public object enumerator;
    public object isNull;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void GetEnumerator(){} // RVA: 0xA94080
    public void get_Current(){} // RVA: 0xA94080
    public void MoveNext(){} // RVA: 0x87D280
    public void Dispose(){} // RVA: 0x894290
}

public class DictionaryPoolImpl`2 : Object
{
    public object Pool;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x8942F0
}

public class DictionaryValueIterator`2 : ValueType
{
    public object dictionary;
    public object enumerator;
    public object isNull;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void GetEnumerator(){} // RVA: 0xA94080
    public void get_Current(){} // RVA: 0xA94080
    public void MoveNext(){} // RVA: 0x87D280
    public void Dispose(){} // RVA: 0x894290
}

public class DigStream : BaseOutputStream
{
    public object d;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA1C37F0
    public void WriteByte(){} // RVA: 0xA1C3890
    public void Write(){} // RVA: 0xA1C38F0
}

public class DigestAndSignerInfoGeneratorHolder : Object
{
    public object signerInf;
    public object digestOID;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x17C92C0
    public void get_DigestAlgorithm(){} // RVA: 0xA34C9E0
}

public class DisconnectMsg : Object
{
    // ── Methods ──
    public void Process(){} // RVA: 0x78B6BD0
}

public class Display : ATypeName
{
    public object displayName;
    public object internal_name;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x4708100
    public void get_DisplayName(){} // RVA: 0xB5DBF0
    public void get_InternalName(){} // RVA: 0x698CFB0
    public void GetInternalName(){} // RVA: 0x698D130
}

public class DisplayNameOptions : ValueType
{
    public object _fullName;
    public object _includeGenericParameterNames;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3FD0
    public void get_FullName(){} // RVA: 0x90520
    public void get_IncludeGenericParameterNames(){} // RVA: 0x90540
}

public class DisplayNameOptions : ValueType
{
    public object _fullName;
    public object _includeGenericParameters;
    public object _includeGenericParameterNames;
    public object _nestedTypeDelimiter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8A9030
    public void get_FullName(){} // RVA: 0x90520
    public void get_IncludeGenericParameters(){} // RVA: 0x90540
    public void get_IncludeGenericParameterNames(){} // RVA: 0x90550
    public void get_NestedTypeDelimiter(){} // RVA: 0x360EF0
}

public class DisplayNameOptions : ValueType
{
    public object _fullName;
    public object _includeGenericParameters;
    public object _includeGenericParameterNames;
    public object _nestedTypeDelimiter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8A9030
    public void get_FullName(){} // RVA: 0x90520
    public void get_IncludeGenericParameters(){} // RVA: 0x90540
    public void get_IncludeGenericParameterNames(){} // RVA: 0x90550
    public void get_NestedTypeDelimiter(){} // RVA: 0x360EF0
}

public class DisplaysUpdatedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA0FE0
    public void Invoke(){} // RVA: 0xBA10B0
}

public class DisposableData : CriticalDisposableObject
{
    public object _accessor;
    public object _safeBuffer;
    public object _pointer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6D53A90
    public void Release(){} // RVA: 0x6D53C50
    public void get_Pointer(){} // RVA: 0xB700F0
}

public class DisposableData : CriticalDisposableObject
{
    public object _pointer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6D53F50
    public void Release(){} // RVA: 0x6D54050
    public void get_Pointer(){} // RVA: 0xB5DBF0
}

public class DisposableObserver : Object
{
    public object observer;

    // ── Methods ──
    public void Dispose(){} // RVA: 0x792AF10
    public void .ctor(){} // RVA: 0xB43310
}

public class DisposeHandle : Object
{
    public object _localHub;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Dispose(){} // RVA: 0x6E219C0
}

public class DnQualifier : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x664A400
}

public class Domain : ApiModel
{
    public object _domain;

    // ── Methods ──
    public void get_domain(){} // RVA: 0xBBFF90
    public void set_domain(){} // RVA: 0xBBFFA0
    public void .ctor(){} // RVA: 0xA51BFE0
}

public class DomainComponent : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x664A110
}

public class DoubleBuffers : ValueType
{
    public object deviceToBufferMapping;
    public object deviceCount;

    // ── Methods ──
    public void get_valid(){} // RVA: 0x311760
    public void SetFrontBuffer(){} // RVA: 0x93CB00
    public void SetBackBuffer(){} // RVA: 0x93CB20
    public void GetFrontBuffer(){} // RVA: 0x93CB40
    public void GetBackBuffer(){} // RVA: 0x93CB60
    public void SwapBuffers(){} // RVA: 0x93CB80
}

public class DoubleHelper : Object
{
    // ── Methods ──
    public void Exponent(){} // RVA: 0x6D2CB30
    public void Mantissa(){} // RVA: 0x6D2CB50
}

public class DoubleInput : TextValueInput
{
    // ── Methods ──
    public void get_parentDoubleField(){} // RVA: 0x7FDBA00
    public void .ctor(){} // RVA: 0x7FDBA80
    public void get_allowedCharacters(){} // RVA: 0x7FDBC40
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FDBCA0
    public void ValueToString(){} // RVA: 0x7FDBE70
    public void StringToValue(){} // RVA: 0x7FDBF10
}

public class DoublePoint[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E74810
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class DownloadContext : Object
{
    public object OnSuccess;
    public object OnError;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x17C92C0
}

public class DragPosition : ValueType
{
    public object insertAtIndex;
    public object parentId;
    public object childIndex;
    public object recycledItem;
    public object dropPosition;

    // ── Methods ──
    public void Equals(){} // RVA: 0x9A4E80
    public void GetHashCode(){} // RVA: 0x9A4F80
}

public class Drone : Object
{
    // ── Methods ──
    public void get__GetDroneFromGameObject(){} // RVA: 0x83316F0
    public void set__GetDroneFromGameObject(){} // RVA: 0x8331730
}

public class DropData : Object
{
    public object expandedIdsBeforeDrag;
    public object draggedIds;
    public object lastItemId;
    public object expandItemBeginTimerMs;
    public object expandItemBeginPosition;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3928BD0
}

public class DropdownEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x79F9210
}

public class DropdownItem : MonoBehaviour
{
    public object m_Text;
    public object m_Image;
    public object m_RectTransform;
    public object m_Toggle;

    // ── Methods ──
    public void get_text(){} // RVA: 0xB700F0
    public void set_text(){} // RVA: 0xB70100
    public void get_image(){} // RVA: 0xB70160
    public void set_image(){} // RVA: 0xB44DC0
    public void get_rectTransform(){} // RVA: 0xD33E60
    public void set_rectTransform(){} // RVA: 0xB708C0
    public void get_toggle(){} // RVA: 0xD05CA0
    public void set_toggle(){} // RVA: 0xD09D70
    public void OnPointerEnter(){} // RVA: 0x7E3BF00
    public void OnCancel(){} // RVA: 0x7E3BF80
    public void .ctor(){} // RVA: 0xB43D60
}

public class DropdownItem : MonoBehaviour
{
    public object m_Text;
    public object m_Image;
    public object m_RectTransform;
    public object m_Toggle;

    // ── Methods ──
    public void get_text(){} // RVA: 0xB700F0
    public void set_text(){} // RVA: 0xB70100
    public void get_image(){} // RVA: 0xB70160
    public void set_image(){} // RVA: 0xB44DC0
    public void get_rectTransform(){} // RVA: 0xD33E60
    public void set_rectTransform(){} // RVA: 0xB708C0
    public void get_toggle(){} // RVA: 0xD05CA0
    public void set_toggle(){} // RVA: 0xD09D70
    public void OnPointerEnter(){} // RVA: 0x79F8E40
    public void OnCancel(){} // RVA: 0x79F8EC0
    public void .ctor(){} // RVA: 0xB43D60
}

public class DropdownItem[] : Array
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

public class DropdownItem[] : Array
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

public class DualSenseHIDBluetoothInputReport : ValueType
{
    public object ExpectedReportId;
    public object reportId;
    public object leftStickX;
    public object leftStickY;
    public object rightStickX;
    public object rightStickY;
    public object leftTrigger;
    public object rightTrigger;
    public object buttons0;
    public object buttons1;
    public object buttons2;

    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x939E30
}

public class DualSenseHIDGenericInputReport : ValueType
{
    public object reportId;

    // ── Methods ──
    public void get_Format(){} // RVA: 0x790C340
}

public class DualSenseHIDMinimalInputReport : ValueType
{
    public object ExpectedSize1;
    public object ExpectedSize2;
    public object reportId;
    public object leftStickX;
    public object leftStickY;
    public object rightStickX;
    public object rightStickY;
    public object buttons0;
    public object buttons1;
    public object buttons2;
    public object leftTrigger;
    public object rightTrigger;

    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x939E90
    public void .cctor(){} // RVA: 0x7924D10
}

public class DualSenseHIDUSBInputReport : ValueType
{
    public object ExpectedReportId;
    public object reportId;
    public object leftStickX;
    public object leftStickY;
    public object rightStickX;
    public object rightStickY;
    public object leftTrigger;
    public object rightTrigger;
    public object buttons0;
    public object buttons1;
    public object buttons2;

    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x939DD0
}

public class DualShock4HIDGenericInputReport : ValueType
{
    public object leftStickX;
    public object leftStickY;
    public object rightStickX;
    public object rightStickY;
    public object buttons0;
    public object buttons1;
    public object buttons2;
    public object leftTrigger;
    public object rightTrigger;

    // ── Methods ──
    public void get_Format(){} // RVA: 0x790C340
    public void ToHIDInputReport(){} // RVA: 0x939EF0
}

public class DynamicCallbackList : ValueType
{
    public object m_UseTrickleDown;
    public object m_Callbacks;
    public object m_TemporaryCallbacks;
    public object m_UnregisteredCallbacksDuringInvoke;
    public object m_IsInvoking;

    // ── Methods ──
    public void Create(){} // RVA: 0x80596E0
    public void GetCallbackListForWriting(){} // RVA: 0x9A53F0
    public void GetCallbackListForReading(){} // RVA: 0x9A5400
    public void UnregisterCallback(){} // RVA: 0x9A5410
    public void Invoke(){} // RVA: 0x9A5420
    public void BeginInvoke(){} // RVA: 0x9A5430
    public void EndInvoke(){} // RVA: 0x9A5440
}

public class DynamicPropertyReg : Object
{
    public object Property;
    public object Sink;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}
