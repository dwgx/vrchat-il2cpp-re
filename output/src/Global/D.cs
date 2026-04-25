// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 477

public class DESEncryption : Object
{
    public int Iterations;

    // ── Methods ──
    public void Encrypt(){} // RVA: 0x7FFACBA2EA40
    public void TryDecrypt(){} // RVA: 0x7FFACBA2EF00
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DPIDMipmapper : Object
{
    public DPIDMipmapper Instance;
    public UnityEngine.ComputeShader ComputeShaderReady; // 0x10
    public int kernelDownsampling; // 0x18
    public int kernelGuidance; // 0x1C
    public int THREADS;
    public int TmpGuidanceProperty; // 0x8
    public int OutputProperty; // 0xC

    // ── Methods ──
    public void get_Instance(){} // RVA: 0x7FFACC0422F0
    public void get_ComputeShaderReady(){} // RVA: 0x7FFACC0423E0
    public void .ctor(){} // RVA: 0x7FFACC0424F0
    public void GenerateDPIDMipmaps(){} // RVA: 0x7FFACC042760
    public void GenerateDPIDMipmapsQuality(){} // RVA: 0x7FFACC042850
    public void GenerateDPIDMipmapsFast(){} // RVA: 0x7FFACC0429C0
    public void ExecuteComputeShader(){} // RVA: 0x7FFACC042A90
    public void .cctor(){} // RVA: 0x7FFACC0442C0
}

public class DSRowDiffIdUsageSection : ValueType
{
    public System.Data.DataSet _targetDS; // 0x10

    // ── Methods ──
    public void Prepare(){} // RVA: 0x7FFAC8E78BB0
}

public class DYNAMIC_TIME_ZONE_INFORMATION : ValueType
{
    public TIME_ZONE_INFORMATION TZI; // 0x10
    public string TimeZoneKeyName; // 0xC0
    public byte DynamicDaylightTimeDisabled; // 0xC8
}

public class Data : ValueType
{
    public int ansi; // 0x10
    public int ebcdic; // 0x14
    public int mac; // 0x18
    public int oem; // 0x1C
    public bool right_to_left; // 0x20
    public byte list_sep; // 0x21
}

public class DataElementDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC411D4B0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFACC074E60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class DataRowReferenceComparer : Object
{
    public DataRowReferenceComparer s_default;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Equals(){} // RVA: 0x7FFAC5DA0BF0
    public void GetHashCode(){} // RVA: 0x7FFAC8EA6210
    public void .cctor(){} // RVA: 0x7FFAC8EA6230
}

public class DataRowTree : RBTree`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E9BDA0
    public void CompareNode(){} // RVA: 0x7FFAC8E9BE00
    public void CompareSateliteTreeNode(){} // RVA: 0x7FFAC8E9BE30
}

public class DataSetRelationCollection : DataRelationCollection
{
    public System.Data.DataSet List; // 0x38
    public System.Collections.ArrayList Item; // 0x40
    public System.Data.DataRelation[] Item; // 0x48

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E951A0
    public void get_List(){} // RVA: 0x7FFAC2F9E740
    public void Clear(){} // RVA: 0x7FFAC8E952E0
    public void GetDataSet(){} // RVA: 0x7FFAC31D0140
    public void get_Item(){} // RVA: 0x7FFAC8E95470 | overloaded x2
    public void AddCore(){} // RVA: 0x7FFAC8E95570
    public void RemoveCore(){} // RVA: 0x7FFAC8E95CA0
    public void FinishInitRelations(){} // RVA: 0x7FFAC8E96050
}

public class DataSet`1 : Object
{
    public bool disposed;
    public GPUBuffer`1<T> gpuData;
    public Unity.Collections.NativeArray`1<T> cpuData;
    public Unity.Collections.NativeArray`1<UnityEngine.UIElements.UIR.GfxUpdateBufferRange> updateRanges;
    public UnityEngine.UIElements.UIR.GPUBufferAllocator allocator;
    public uint m_UpdateRangePoolSize;
    public uint m_ElemStride;
    public uint m_UpdateRangeMin;
    public uint m_UpdateRangeMax;
    public uint m_UpdateRangesEnqueued;
    public uint m_UpdateRangesBatchStart;
    public bool m_UpdateRangesSaturated;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_disposed(){} // RVA: 0x7FFAC2C59D00
    public void set_disposed(){} // RVA: 0x7FFAC2C71060
    public void Dispose(){} // RVA: 0x7FFAC2C71060 | overloaded x2
    public void RegisterUpdate(){}
    public void HasMappedBufferRange(){} // RVA: 0x7FFAC2C59D00
    public void SendUpdates(){} // RVA: 0x7FFAC2C70980
    public void SendFullRange(){} // RVA: 0x7FFAC2C70980
    public void SendPartialRanges(){} // RVA: 0x7FFAC2C70980
    public void ResetUpdateState(){} // RVA: 0x7FFAC2C70980
}

public class DataStorageShadow : Object
{
    public string ParameterString; // 0x10
    public string ParameterBoolOp; // 0x18
    public string ParameterFloat; // 0x20
    public string ParameterInt; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DataTableRelationCollection : DataRelationCollection
{
    public System.Data.DataTable List; // 0x38
    public System.Collections.ArrayList Item; // 0x40
    public bool Item; // 0x48
    public System.ComponentModel.CollectionChangeEventHandler RelationPropertyChanged; // 0x50

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E946E0
    public void get_List(){} // RVA: 0x7FFAC2F9E740
    public void EnsureDataSet(){} // RVA: 0x7FFAC8E94840
    public void GetDataSet(){} // RVA: 0x7FFAC8E94890
    public void get_Item(){} // RVA: 0x7FFAC8E949F0 | overloaded x2
    public void add_RelationPropertyChanged(){} // RVA: 0x7FFAC8E94AF0
    public void remove_RelationPropertyChanged(){} // RVA: 0x7FFAC8E94BE0
    public void AddCache(){} // RVA: 0x7FFAC8E94CD0
    public void AddCore(){} // RVA: 0x7FFAC8E94D70
    public void RemoveCache(){} // RVA: 0x7FFAC8E94EF0
    public void RemoveCore(){} // RVA: 0x7FFAC8E94FE0
}

public class DataTokenFormatter : BaseFormatter`1
{
    public VRC.Udon.Serialization.OdinSerializer.Serializer`1<object> _referenceReaderWriter;

    // ── Methods ──
    public void DeserializeImplementation(){} // RVA: 0x7FFAC9E87A60
    public void SerializeImplementation(){} // RVA: 0x7FFAC9E88190
    public void .ctor(){} // RVA: 0x7FFAC9E886B0
    public void .cctor(){} // RVA: 0x7FFAC9E88710
}

public class DataViewSettingsEnumerator : Object
{
    public System.Data.DataViewSettingCollection Current; // 0x10
    public System.Collections.IEnumerator _tableEnumerator; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8EA9C50
    public void MoveNext(){} // RVA: 0x7FFAC8EA9E60
    public void Reset(){} // RVA: 0x7FFAC8EA9EB0
    public void get_Current(){} // RVA: 0x7FFAC8EA9F00
}

public class DateMapping : ValueType
{
    public int HijriMonthsLengthFlags; // 0x10
    public System.DateTime GregorianDate; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8573FA0
}

public class DateTime : Object
{
    public System.Func`2<object,string> ToString;

    // ── Methods ──
    public void TryParse(){} // RVA: 0x7FFAC8FB07D0
    public void .cctor(){} // RVA: 0x7FFAC8FB0830
}

public class DateTimeParseData : ValueType
{
    public int OffsetNegative; // 0x10
    public int Month; // 0x14
    public int Day; // 0x18
    public int Hour; // 0x1C
    public int Minute; // 0x20
    public int Second; // 0x24
    public int Fraction; // 0x28
    public int OffsetHours; // 0x2C
    public int OffsetMinutes; // 0x30
    public byte OffsetToken; // 0x34

    // ── Methods ──
    public void get_OffsetNegative(){} // RVA: 0x7FFAC8A97C20
}

public class DbRow : ValueType
{
    public int Location; // 0x10
    public int SizeOrLength; // 0x14
    public int IsUnknownSize; // 0x18

    // ── Methods ──
    public void get_Location(){} // RVA: 0x7FFAC4420210
    public void get_SizeOrLength(){} // RVA: 0x7FFAC8AA0420
    public void get_IsUnknownSize(){} // RVA: 0x7FFAC8AA0430
    public void get_HasComplexChildren(){} // RVA: 0x7FFAC8AA0440
    public void get_NumberOfRows(){} // RVA: 0x7FFAC8AA0450
    public void get_TokenType(){} // RVA: 0x7FFAC8AA0460
    public void .ctor(){} // RVA: 0x7FFAC8AA0470
    public void get_IsSimpleValue(){} // RVA: 0x7FFAC8AA0490
}

public class DeactivateControllerLabelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6055BD0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFACC0729E0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class DeactivateObjectLabelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class DebugHash : ValueType
{
    public int hash; // 0x10
    public string name; // 0x18
}

public class DebugImageInfo : Object
{
    public Sentry.Protocol.DebugImage Image; // 0x10
    public System.Nullable`1<long> StartAddress; // 0x18
    public System.Nullable`1<long> EndAddress; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8B05910
    public void ContainsAddress(){} // RVA: 0x7FFAC8B05A50
}

public class DebugInfoComparer : Object
{
    // ── Methods ──
    public void System.Collections.Generic.IComparer<System.Linq.Expressions.Interpreter.DebugInfo>.Compare(){} // RVA: 0x7FFAC8DC3D90
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DebugInfoExpressionProxy : Object
{
    public System.Linq.Expressions.DebugInfoExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D71540
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_Document(){} // RVA: 0x7FFAC3511350
    public void get_EndColumn(){} // RVA: 0x7FFAC8D71620
    public void get_EndLine(){} // RVA: 0x7FFAC8D71650
    public void get_IsClear(){} // RVA: 0x7FFAC8D711F0
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_StartColumn(){} // RVA: 0x7FFAC4426B30
    public void get_StartLine(){} // RVA: 0x7FFAC84AA530
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
}

public class DebugMessage : ValueType
{
    public 0x6B28DCE0 Type; // 0x10
    public string Msg; // 0x18
}

public class DebugView : Object
{
    public System.Text.Json.Nodes.JsonValue`1<T> Json;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void get_Json(){} // RVA: 0x7FFAC2C58E90
    public void get_Path(){} // RVA: 0x7FFAC2C58E90
    public void get_Value(){} // RVA: 0x7FFAC2E8DC40
}

public class DebugViewItem : ValueType
{
    public System.Text.Json.Nodes.JsonNode Display; // 0x10

    // ── Methods ──
    public void get_Display(){} // RVA: 0x7FFAC9050020
}

public class DebugViewPrinter : Object
{
    public System.Linq.Expressions.Interpreter.Interpreter _interpreter; // 0x10
    public System.Collections.Generic.Dictionary`2<int,int> _tryStart; // 0x18
    public System.Collections.Generic.Dictionary`2<int,string> _handlerEnter; // 0x20
    public System.Collections.Generic.Dictionary`2<int,int> _handlerExit; // 0x28
    public string _indent; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8DDA950
    public void Analyze(){} // RVA: 0x7FFAC8DDAC10
    public void AddTryStart(){} // RVA: 0x7FFAC8DDAF90
    public void AddHandlerExit(){} // RVA: 0x7FFAC8DDB0C0
    public void Indent(){} // RVA: 0x7FFAC8DDB1B0
    public void Dedent(){} // RVA: 0x7FFAC8DDB230
    public void ToString(){} // RVA: 0x7FFAC8DDB2B0
    public void EmitExits(){} // RVA: 0x7FFAC8DDBC20
}

public class DebugViewProperty : ValueType
{
    public System.Text.Json.Nodes.JsonNode Display; // 0x10
    public string PropertyName; // 0x18

    // ── Methods ──
    public void get_Display(){} // RVA: 0x7FFAC9057280
}

public class DebuggerProxy : Object
{
}

public class DecCalc : ValueType
{
    public uint High; // 0x10
    public uint Low; // 0x14
    public uint Mid; // 0x18
    public uint IsNegative; // 0x1C
    public ulong Scale; // 0x18
    public uint[] Low64;
    public ulong[] s_ulongPowers10; // 0x8
    public double[] s_doublePowers10; // 0x10
    public PowerOvfl[] PowerOvflValues; // 0x18

    // ── Methods ──
    public void get_High(){} // RVA: 0x7FFAC44202A0
    public void set_High(){} // RVA: 0x7FFAC4420230
    public void get_Low(){} // RVA: 0x7FFAC49C7500
    public void set_Low(){} // RVA: 0x7FFAC49C7510
    public void get_Mid(){} // RVA: 0x7FFAC49C7520
    public void set_Mid(){} // RVA: 0x7FFAC49C7530
    public void get_IsNegative(){} // RVA: 0x7FFAC862EBA0
    public void get_Scale(){} // RVA: 0x7FFAC495DE20
    public void get_Low64(){} // RVA: 0x7FFAC86B4B80
    public void set_Low64(){} // RVA: 0x7FFAC4A068C0
    public void GetExponent(){} // RVA: 0x7FFAC86B4BA0 | overloaded x2
    public void UInt32x32To64(){} // RVA: 0x7FFAC85B6350
    public void UInt64x64To128(){} // RVA: 0x7FFAC86B4BB0
    public void Div96By32(){} // RVA: 0x7FFAC86B4D20
    public void Div96ByConst(){} // RVA: 0x7FFAC86B4D90
    public void Unscale(){} // RVA: 0x7FFAC86B4E00
    public void Div96By64(){} // RVA: 0x7FFAC86B5010
    public void Div128By96(){} // RVA: 0x7FFAC86B5160
    public void IncreaseScale(){} // RVA: 0x7FFAC86B5280
    public void IncreaseScale64(){} // RVA: 0x7FFAC86B5310
    public void ScaleResult(){} // RVA: 0x7FFAC86B5390
    public void DivByConst(){} // RVA: 0x7FFAC86B5A80
    public void LeadingZeroCount(){} // RVA: 0x7FFAC86B5B00
    public void OverflowUnscale(){} // RVA: 0x7FFAC86B5B60
    public void SearchScale(){} // RVA: 0x7FFAC86B5C90
    public void Add32To96(){} // RVA: 0x7FFAC86B5E70
    public void DecAddSub(){} // RVA: 0x7FFAC86B5E90
    public void VarCyFromDec(){} // RVA: 0x7FFAC86B6560
    public void VarDecCmp(){} // RVA: 0x7FFAC86B6770
    public void VarDecCmpSub(){} // RVA: 0x7FFAC86B6890
    public void VarDecMul(){} // RVA: 0x7FFAC86B6A90
    public void VarDecFromR4(){} // RVA: 0x7FFAC86B6F70
    public void VarDecFromR8(){} // RVA: 0x7FFAC86B7370
    public void VarR4FromDec(){} // RVA: 0x7FFAC86B7760
    public void VarR8FromDec(){} // RVA: 0x7FFAC86B77C0
    public void GetHashCode(){} // RVA: 0x7FFAC86B78E0
    public void VarDecDiv(){} // RVA: 0x7FFAC86B7A30
    public void VarDecMod(){} // RVA: 0x7FFAC86B8460
    public void VarDecModFull(){} // RVA: 0x7FFAC86B8850
    public void InternalRound(){} // RVA: 0x7FFAC86B8C90
    public void DecDivMod1E9(){} // RVA: 0x7FFAC86B8FA0
    public void .cctor(){} // RVA: 0x7FFAC86B9020
}

public class DecimalByteUnion : ValueType
{
    public byte Byte0; // 0x10
    public byte Byte1; // 0x11
    public byte Byte2; // 0x12
    public byte Byte3; // 0x13
    public byte Byte4; // 0x14
    public byte Byte5; // 0x15
    public byte Byte6; // 0x16
    public byte Byte7; // 0x17
    public byte Byte8; // 0x18
    public byte Byte9; // 0x19
    public byte Byte10; // 0x1A
    public byte Byte11; // 0x1B
    public byte Byte12; // 0x1C
    public byte Byte13; // 0x1D
    public byte Byte14; // 0x1E
    public byte Byte15; // 0x1F
    public System.Decimal Value; // 0x10
}

public class DecimalStruct : Object
{
    public bool IsDecimal; // 0x10
    public System.Decimal[] Dvalue; // 0x18

    // ── Methods ──
    public void get_IsDecimal(){} // RVA: 0x7FFAC2FEB5E0
    public void set_IsDecimal(){} // RVA: 0x7FFAC2FEB5F0
    public void get_Dvalue(){} // RVA: 0x7FFAC2F247C0
    public void .ctor(){} // RVA: 0x7FFAC926EF00 | overloaded x2
}

public class DeclBaseInfo : Object
{
    public System.Xml.XmlQualifiedName _Name; // 0x10
    public string _Prefix; // 0x18
    public System.Xml.XmlQualifiedName _TypeName; // 0x20
    public string _TypePrefix; // 0x28
    public object _Default; // 0x30
    public object _Revises; // 0x38
    public uint _MaxOccurs; // 0x40
    public uint _MinOccurs; // 0x44
    public bool _Checking; // 0x48
    public System.Xml.Schema.SchemaElementDecl _ElementDecl; // 0x50
    public System.Xml.Schema.SchemaAttDef _Attdef; // 0x58
    public DeclBaseInfo _Next; // 0x60

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC912F440
    public void Reset(){} // RVA: 0x7FFAC912F450
}

public class Decoder : DecoderNLS
{
    public int HasState; // 0x30
    public char lastChar; // 0x34

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83EF5C0
    public void Reset(){} // RVA: 0x7FFAC83EF5D0
    public void get_HasState(){} // RVA: 0x7FFAC83EF600
}

public class DecoderUTF7Fallback : DecoderFallback
{
    public object MaxCharCount;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateFallbackBuffer(){} // RVA: 0x7FFAC83E6D60
    public void get_MaxCharCount(){} // RVA: 0x7FFAC3013AF0
    public void Equals(){} // RVA: 0x7FFAC83E6DA0
    public void GetHashCode(){} // RVA: 0x7FFAC83E6E00
}

public class DecoderUTF7FallbackBuffer : DecoderFallbackBuffer
{
    public char Remaining; // 0x20
    public int iCount; // 0x24
    public int iSize; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83E6E10
    public void Fallback(){} // RVA: 0x7FFAC83E6E20
    public void GetNextChar(){} // RVA: 0x7FFAC83E6E70
    public void get_Remaining(){} // RVA: 0x7FFAC83D0590
    public void Reset(){} // RVA: 0x7FFAC83D05A0
    public void InternalFallback(){} // RVA: 0x7FFAC83E6E90
}

public class DecomposedGuid : ValueType
{
    public System.Guid Guid; // 0x10
    public byte Byte00; // 0x10
    public byte Byte01; // 0x11
    public byte Byte02; // 0x12
    public byte Byte03; // 0x13
    public byte Byte04; // 0x14
    public byte Byte05; // 0x15
    public byte Byte06; // 0x16
    public byte Byte07; // 0x17
    public byte Byte08; // 0x18
    public byte Byte09; // 0x19
    public byte Byte10; // 0x1A
    public byte Byte11; // 0x1B
    public byte Byte12; // 0x1C
    public byte Byte13; // 0x1D
    public byte Byte14; // 0x1E
    public byte Byte15; // 0x1F
}

public class DecrementDouble : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAAE50
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DecrementInt16 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAA6F0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DecrementInt32 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAA7C0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DecrementInt64 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAA890
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DecrementSingle : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAAD10
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DecrementUInt16 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAA9D0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DecrementUInt32 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAAAA0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DecrementUInt64 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAABD0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DefaultComparer`1 : ValueType
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFAC2E8DC40
}

public class DefaultDecoder : Decoder
{
    public System.Text.Encoding m_encoding; // 0x20
    public bool m_hasInitializedEncoding; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83F57B0 | overloaded x2
    public void GetRealObject(){} // RVA: 0x7FFAC83F5AF0
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC83F5BA0
    public void GetCharCount(){} // RVA: 0x7FFAC83F5C70 | overloaded x3
    public void GetChars(){} // RVA: 0x7FFAC83F5CE0 | overloaded x3
}

public class DefaultEncoder : Encoder
{
    public System.Text.Encoding m_encoding; // 0x20
    public bool m_hasInitializedEncoding; // 0x28
    public char charLeftOver; // 0x2A

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83F5150 | overloaded x2
    public void GetRealObject(){} // RVA: 0x7FFAC83F5520
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC83F5640
    public void GetByteCount(){} // RVA: 0x7FFAC83F5710 | overloaded x2
    public void GetBytes(){} // RVA: 0x7FFAC83F5780 | overloaded x2
}

public class DefaultEventInterests : ValueType
{
    public int DefaultActionCategories; // 0x10
    public int DefaultActionAtTargetCategories; // 0x14
}

public class DefaultExpressionProxy : Object
{
    public System.Linq.Expressions.DefaultExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D71680
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
}

public class DefaultExtendedTypeDescriptor : ValueType
{
    public TypeDescriptionNode _node; // 0x10
    public object _instance; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC41AE4B0
    public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7FFAC9444280
    public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x7FFAC94445A0
    public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x7FFAC94447F0
    public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7FFAC94449F0
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x7FFAC9444D00
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x7FFAC9444EB0
    public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7FFAC9445060
    public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x7FFAC9445620 | overloaded x2
    public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7FFAC9445C20 | overloaded x2
    public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x7FFAC9445F00
}

public class DefaultF2mLookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.F2mCurve Size; // 0x10
    public long[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBFB9150
}

public class DefaultLookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve Size; // 0x10
    public byte[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBFB6010
}

public class DefaultRuntimeFactory : Object
{
    public IFactoryControls Default;

    // ── Methods ──
    public void CreateGameObject(){} // RVA: 0x7FFAC9A5DF50
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFAC9A5DFC0
}

public class DefaultTypeDescriptor : ValueType
{
    public TypeDescriptionNode _node; // 0x10
    public System.Type _objectType; // 0x18
    public object _instance; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC446FCC0
    public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7FFAC9446130
    public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x7FFAC9446420
    public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x7FFAC9446620
    public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7FFAC94467F0
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x7FFAC9446AE0
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x7FFAC9446CC0
    public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7FFAC9446EA0
    public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x7FFAC9447420 | overloaded x2
    public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7FFAC9447A00 | overloaded x2
    public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x7FFAC9447CF0
}

public class DefaultWebProxy : Object
{
    public DefaultWebProxy Instance;

    // ── Methods ──
    public void get_Instance(){} // RVA: 0x7FFAC935C400
    public void get_Credentials(){} // RVA: 0x7FFAC935C460
    public void GetProxy(){} // RVA: 0x7FFAC935C4A0
    public void IsBypassed(){} // RVA: 0x7FFAC935C4E0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFAC935C520
}

public class DeferBindingResolutionWrapper : Object
{
    // ── Methods ──
    public void Acquire(){} // RVA: 0x7FFAC9538130
    public void Dispose(){} // RVA: 0x7FFAC9538190
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DeferPromise : Object
{
    public System.Func`1<Cysharp.Threading.Tasks.UniTask> factory; // 0x10
    public Cysharp.Threading.Tasks.UniTask task; // 0x18
    public Awaiter awaiter; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void GetResult(){} // RVA: 0x7FFAC9491460
    public void GetStatus(){} // RVA: 0x7FFAC94914C0
    public void OnCompleted(){} // RVA: 0x7FFAC94916A0
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC9491750
}

public class DeferPromiseWithState`1 : Object
{
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask> factory;
    public T argument;
    public Cysharp.Threading.Tasks.UniTask task;
    public Awaiter awaiter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
}

public class DeferPromiseWithState`2 : Object
{
    public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<T>> factory;
    public U argument;
    public Cysharp.Threading.Tasks.UniTask`1<T> task;
    public Awaiter<T> awaiter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
}

public class DeferPromise`1 : Object
{
    public System.Func`1<Cysharp.Threading.Tasks.UniTask`1<T>> factory;
    public Cysharp.Threading.Tasks.UniTask`1<T> task;
    public Awaiter<T> awaiter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
}

public class DeferredPassthroughMeshAddition : ValueType
{
    public UnityEngine.GameObject gameObject; // 0x10
    public bool updateTransform; // 0x18
}

public class DeflateOutputStream : ZOutputStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBB46200
    public void Flush(){} // RVA: 0x7FFAC2F21310
}

public class DelayFramePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<DelayFramePromise> NextNode;
    public DelayFramePromise nextNode; // 0x10
    public int initialFrame; // 0x18
    public int delayFrameCount; // 0x1C
    public System.Threading.CancellationToken cancellationToken; // 0x20
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x28
    public bool cancelImmediately; // 0x40
    public int currentFrameCount; // 0x44
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<Cysharp.Threading.Tasks.AsyncUnit> core; // 0x48

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC948E290
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Create(){} // RVA: 0x7FFAC948E410
    public void GetResult(){} // RVA: 0x7FFAC948E830
    public void GetStatus(){} // RVA: 0x7FFAC948E9D0
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC948EA20
    public void OnCompleted(){} // RVA: 0x7FFAC948EA60
    public void MoveNext(){} // RVA: 0x7FFAC948EAE0
    public void TryReturn(){} // RVA: 0x7FFAC948EC00
}

public class DelayIgnoreTimeScalePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<DelayIgnoreTimeScalePromise> NextNode;
    public DelayIgnoreTimeScalePromise nextNode; // 0x10
    public float delayFrameTimeSpan; // 0x18
    public float elapsed; // 0x1C
    public int initialFrame; // 0x20
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x30
    public bool cancelImmediately; // 0x48
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<object> core; // 0x50

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC948FAB0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Create(){} // RVA: 0x7FFAC948FC30
    public void GetResult(){} // RVA: 0x7FFAC94900A0
    public void GetStatus(){} // RVA: 0x7FFAC9490240
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC9490290
    public void OnCompleted(){} // RVA: 0x7FFAC94902D0
    public void MoveNext(){} // RVA: 0x7FFAC9490350
    public void TryReturn(){} // RVA: 0x7FFAC94904E0
}

public class DelayPromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<DelayPromise> NextNode;
    public DelayPromise nextNode; // 0x10
    public int initialFrame; // 0x18
    public float delayTimeSpan; // 0x1C
    public float elapsed; // 0x20
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x30
    public bool cancelImmediately; // 0x48
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<object> core; // 0x50

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC948EE40
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Create(){} // RVA: 0x7FFAC948EFC0
    public void GetResult(){} // RVA: 0x7FFAC948F430
    public void GetStatus(){} // RVA: 0x7FFAC948F5D0
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC948F620
    public void OnCompleted(){} // RVA: 0x7FFAC948F660
    public void MoveNext(){} // RVA: 0x7FFAC948F6E0
    public void TryReturn(){} // RVA: 0x7FFAC948F870
}

public class DelayRealtimePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<DelayRealtimePromise> NextNode;
    public DelayRealtimePromise nextNode; // 0x10
    public long delayTimeSpanTicks; // 0x18
    public Cysharp.Threading.Tasks.Internal.ValueStopwatch stopwatch; // 0x20
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x30
    public bool cancelImmediately; // 0x48
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<Cysharp.Threading.Tasks.AsyncUnit> core; // 0x50

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC9490720
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Create(){} // RVA: 0x7FFAC94908A0
    public void GetResult(){} // RVA: 0x7FFAC9490CE0
    public void GetStatus(){} // RVA: 0x7FFAC9490E80
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC9490ED0
    public void OnCompleted(){} // RVA: 0x7FFAC9490F10
    public void MoveNext(){} // RVA: 0x7FFAC9490F90
    public void TryReturn(){} // RVA: 0x7FFAC94910D0
}

public class Delegate : Object
{
    public Google.Protobuf.MessageParser`1<Delegate> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public object pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public 0x6B2107C8 Tflite; // 0x20

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC827BA50
    public void get_Descriptor(){} // RVA: 0x7FFAC827BAB0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC827BB30
    public void .ctor(){} // RVA: 0x7FFAC827BB80 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC827BEA0
    public void get_Tflite(){} // RVA: 0x7FFAC827BF00
    public void set_Tflite(){} // RVA: 0x7FFAC827BF60
    public void get_Gpu(){} // RVA: 0x7FFAC827BFC0
    public void set_Gpu(){} // RVA: 0x7FFAC827C020
    public void get_Nnapi(){} // RVA: 0x7FFAC827C080
    public void set_Nnapi(){} // RVA: 0x7FFAC827C0E0
    public void get_Xnnpack(){} // RVA: 0x7FFAC827C140
    public void set_Xnnpack(){} // RVA: 0x7FFAC827C1A0
    public void get_DelegateCase(){} // RVA: 0x7FFAC30DBBE0
    public void ClearDelegate(){} // RVA: 0x7FFAC81DA6A0
    public void Equals(){} // RVA: 0x7FFAC827C260 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC827C420
    public void ToString(){} // RVA: 0x7FFAC827C650
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC827C6A0
    public void CalculateSize(){} // RVA: 0x7FFAC827C8A0
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC827D0C0
    public void .cctor(){} // RVA: 0x7FFAC827D330
}

public class DelegateEntry : Object
{
    public string type; // 0x10
    public string assembly; // 0x18
    public object target; // 0x20
    public string targetTypeAssembly; // 0x28
    public string targetTypeName; // 0x30
    public string methodName; // 0x38
    public DelegateEntry delegateEntry; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC869CDA0
    public void DeserializeDelegate(){} // RVA: 0x7FFAC869D180
}

public class DelegateEnumerator : FileSystemEnumerator`1
{
    public System.IO.Enumeration.FileSystemEnumerable`1<T> _enumerable;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void TransformEntry(){} // RVA: 0x7FFAC2E8DC40
    public void ShouldRecurseIntoEntry(){} // RVA: 0x7FFAC2C59F60
    public void ShouldIncludeEntry(){} // RVA: 0x7FFAC2C59F60
}

public class Deleter : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC497DFD0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class DeletionCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC307D2A0
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class DeliverIosPlatformEvents : ValueType
{
}

public class DeltaStateEventBuffer : ValueType
{
    public UnityEngine.InputSystem.LowLevel.DeltaStateEvent stateEvent; // 0x10
    public int kMaxSize;
    public <data>e__FixedBuffer data; // 0x2D
}

public class DepthOrderedDirtyTracking : ValueType
{
    public System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement> heads; // 0x10
    public System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement> tails; // 0x18
    public int[] minDepths; // 0x20
    public int[] maxDepths; // 0x28
    public uint dirtyID; // 0x30

    // ── Methods ──
    public void EnsureFits(){} // RVA: 0x7FFAC9AE5970
    public void RegisterDirty(){} // RVA: 0x7FFAC9AE5A90
    public void ClearDirty(){} // RVA: 0x7FFAC9AE5D90
    public void Reset(){} // RVA: 0x7FFAC9AE6130
}

public class DerComparer : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFACBCD65F0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DeriveBytes : Object
{
    public byte[] HashName;
    public byte[] IterationCount; // 0x8
    public byte[] Password; // 0x10
    public string Salt; // 0x10
    public int _iterations; // 0x18
    public byte[] _password; // 0x20
    public byte[] _salt; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void set_HashName(){} // RVA: 0x7FFAC2F22E30
    public void set_IterationCount(){} // RVA: 0x7FFAC392CD10
    public void set_Password(){} // RVA: 0x7FFAC835BAC0
    public void set_Salt(){} // RVA: 0x7FFAC835BC40
    public void Adjust(){} // RVA: 0x7FFAC835BDA0
    public void Derive(){} // RVA: 0x7FFAC835BE70
    public void DeriveKey(){} // RVA: 0x7FFAC835C320
    public void DeriveIV(){} // RVA: 0x7FFAC835C3A0
    public void DeriveMAC(){} // RVA: 0x7FFAC835C420
    public void .cctor(){} // RVA: 0x7FFAC835C4A0
}

public class DerivedJsonTypeInfo : Object
{
    public System.Text.Json.Serialization.Metadata.JsonTypeInfo DerivedType; // 0x10
    public System.Type TypeDiscriminator; // 0x18
    public object <TypeDiscriminator>k__BackingField; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8BA01A0
    public void get_DerivedType(){} // RVA: 0x7FFAC2F247C0
    public void get_TypeDiscriminator(){} // RVA: 0x7FFAC2F4F0C0
    public void GetJsonTypeInfo(){} // RVA: 0x7FFAC90748D0
}

public class DerivedTypeList : ConfigurationList`1
{
    public System.Text.Json.Serialization.Metadata.JsonPolymorphismOptions IsReadOnly; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9065110
    public void get_IsReadOnly(){} // RVA: 0x7FFAC9065270
    public void OnCollectionModifying(){} // RVA: 0x7FFAC90652A0
}

public class DeserializationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CBE090
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC9D6CE60
    public void EndInvoke(){} // RVA: 0x7FFAC896F1B0
}

public class Deserialize32QuaternionDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4935D20
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC9D6CE60
    public void EndInvoke(){} // RVA: 0x7FFAC49FC700
}

public class Deserialize32Vector3Delegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4935D20
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC9D6CE60
    public void EndInvoke(){} // RVA: 0x7FFAC49FC700
}

public class DeserializeFloatDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4935D20
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC9D6CF30
    public void EndInvoke(){} // RVA: 0x7FFAC49FC700
}

public class DeserializeFloatsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4935D20
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC9D6CE60
    public void EndInvoke(){} // RVA: 0x7FFAC49FC700
}

public class DeserializeQuaternionDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4935D20
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC9D6CE60
    public void EndInvoke(){} // RVA: 0x7FFAC49FC700
}

public class DeserializeVector3Delegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4935D20
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC9D6CE60
    public void EndInvoke(){} // RVA: 0x7FFAC49FC700
}

public class DesignerOptionCollection : Object
{
    public System.ComponentModel.Design.DesignerOptionService Count; // 0x10
    public string Name; // 0x18
    public object Properties; // 0x20
    public System.Collections.ArrayList System.Collections.ICollection.IsSynchronized; // 0x28
    public System.ComponentModel.PropertyDescriptorCollection System.Collections.ICollection.SyncRoot; // 0x30

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7FFAC944AD00
    public void get_Name(){} // RVA: 0x7FFAC2F247C0
    public void get_Properties(){} // RVA: 0x7FFAC944AD40
    public void CopyTo(){} // RVA: 0x7FFAC944B570
    public void EnsurePopulated(){} // RVA: 0x7FFAC944B5D0
    public void GetEnumerator(){} // RVA: 0x7FFAC944B6B0
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
}

public class DesignerOptionConverter : TypeConverter
{
    // ── Methods ──
    public void GetPropertiesSupported(){} // RVA: 0x7FFAC3006850
    public void GetProperties(){} // RVA: 0x7FFAC944BA10
    public void ConvertTo(){} // RVA: 0x7FFAC944BFC0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DesignerWebRequestCreate : Object
{
    // ── Methods ──
    public void Create(){} // RVA: 0x7FFAC92BF260
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DestroyPipelineDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class DestroyRigDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class Development : Object
{
    // ── Methods ──
    public void Log(){} // RVA: 0x7FFAC892C6A0
    public void LogWarning(){} // RVA: 0x7FFAC892C720
    public void LogError(){} // RVA: 0x7FFAC892C7A0
    public void LogRequest(){} // RVA: 0x7FFAC2F21310
    public void LogRequestResult(){} // RVA: 0x7FFAC2F21310
}

public class DeviceArray : ValueType
{
    public bool m_HaveValue; // 0x10
    public int m_DeviceCount; // 0x14
    public UnityEngine.InputSystem.InputDevice[] m_DeviceArray; // 0x18

    // ── Methods ──
    public void IndexOf(){} // RVA: 0x7FFAC9526E90
    public void Remove(){} // RVA: 0x7FFAC9526F30
    public void Get(){} // RVA: 0x7FFAC9526FF0
    public void Set(){} // RVA: 0x7FFAC9527160
}

public class DeviceBuilder : ValueType
{
    public UnityEngine.InputSystem.InputDevice device; // 0x10

    // ── Methods ──
    public void get_device(){} // RVA: 0x7FFAC3AD9F60
    public void set_device(){} // RVA: 0x7FFAC38DFE40
    public void WithName(){} // RVA: 0x7FFAC95896B0
    public void WithDisplayName(){} // RVA: 0x7FFAC9589750
    public void WithShortDisplayName(){} // RVA: 0x7FFAC9589830
    public void WithLayout(){} // RVA: 0x7FFAC9589910
    public void WithChildren(){} // RVA: 0x7FFAC95899E0
    public void WithStateBlock(){} // RVA: 0x7FFAC9589A10
    public void IsNoisy(){} // RVA: 0x7FFAC9589AC0
    public void WithControlUsage(){} // RVA: 0x7FFAC9589BF0
    public void WithControlAlias(){} // RVA: 0x7FFAC9589D20
    public void WithStateOffsetToControlIndexMap(){} // RVA: 0x7FFAC9589DC0
    public void WithControlTree(){} // RVA: 0x7FFAC9589E30
    public void Finish(){} // RVA: 0x7FFAC958A020
}

public class DeviceConnectedChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6058800
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC8C79510
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class DeviceDescriptionJson : ValueType
{
    public string interface; // 0x10
    public string type; // 0x18
    public string product; // 0x20
    public string serial; // 0x28
    public string version; // 0x30
    public string manufacturer; // 0x38
    public string capabilities; // 0x40
}

public class DeviceIndexChangedHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6058FB0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC8C72590
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class DeviceInfo : ValueType
{
    public int deviceId; // 0x10
    public string layout; // 0x18
    public UnityEngine.InputSystem.Utilities.FourCC stateFormat; // 0x20
    public int stateSizeInBytes; // 0x24
    public string m_FullLayoutJson; // 0x28

    // ── Methods ──
    public void get_deviceId(){} // RVA: 0x7FFAC4420210
    public void set_deviceId(){} // RVA: 0x7FFAC336D8B0
    public void get_layout(){} // RVA: 0x7FFAC4420220
    public void set_layout(){} // RVA: 0x7FFAC4420240
    public void get_stateFormat(){} // RVA: 0x7FFAC2F6E5C0
    public void set_stateFormat(){} // RVA: 0x7FFAC2F240C0
    public void get_stateSizeInBytes(){} // RVA: 0x7FFAC33D5A20
    public void set_stateSizeInBytes(){} // RVA: 0x7FFAC33D4990
}

public class DeviceJson : ValueType
{
    public string devicePath; // 0x10
    public bool isOptional; // 0x18
    public bool isOR; // 0x19

    // ── Methods ──
    public void ToDeviceEntry(){} // RVA: 0x7FFAC957ADC0
    public void From(){} // RVA: 0x7FFAC957AE50
}
