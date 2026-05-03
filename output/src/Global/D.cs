// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 476

public class DESEncryption : Object
{
    // ── Methods ──
    public void Encrypt(){} // RVA: 0x7FFE89E88060
    public void TryDecrypt(){} // RVA: 0x7FFE89E88520
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DPIDMipmapper : Object
{
    public DPIDMipmapper _instance;
    public UnityEngine.ComputeShader computeShader; // 0x10

    // ── Methods ──
    public void get_Instance(){} // RVA: 0x7FFE8A4A7DD0
    public void get_ComputeShaderReady(){} // RVA: 0x7FFE8A4A7EC0
    public void .ctor(){} // RVA: 0x7FFE8A4A7FD0
    public void GenerateDPIDMipmaps(){} // RVA: 0x7FFE8A4A8240
    public void GenerateDPIDMipmapsQuality(){} // RVA: 0x7FFE8A4A8330
    public void GenerateDPIDMipmapsFast(){} // RVA: 0x7FFE8A4A84A0
    public void ExecuteComputeShader(){} // RVA: 0x7FFE8A4A8570
    public void .cctor(){} // RVA: 0x7FFE8A4A9DA0
}

public class DSRowDiffIdUsageSection : ValueType
{
    // ── Methods ──
    public void Prepare(){} // RVA: 0x7FFE87220FE0
}

public class DYNAMIC_TIME_ZONE_INFORMATION : ValueType
{
}

public class Data : ValueType
{
}

public class DataElementDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE823D7070
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE8A4DAE30
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class DataRowReferenceComparer : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Equals(){} // RVA: 0x7FFE84108BE0
    public void GetHashCode(){} // RVA: 0x7FFE8724E640
    public void .cctor(){} // RVA: 0x7FFE8724E660
}

public class DataRowTree : RBTree`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE872441D0
    public void CompareNode(){} // RVA: 0x7FFE87244230
    public void CompareSateliteTreeNode(){} // RVA: 0x7FFE87244260
}

public class DataSetRelationCollection : DataRelationCollection
{
    public System.Data.DataSet _dataSet; // 0x38
    public System.Collections.ArrayList _relations; // 0x40
    public System.Data.DataRelation[] _delayLoadingRelations; // 0x48

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8723D5D0
    public void get_List(){} // RVA: 0x7FFE81178740
    public void Clear(){} // RVA: 0x7FFE8723D710
    public void GetDataSet(){} // RVA: 0x7FFE8143BA80
    public void get_Item(){} // RVA: 0x7FFE8723D8A0 | overloaded x2
    public void AddCore(){} // RVA: 0x7FFE8723D9A0
    public void RemoveCore(){} // RVA: 0x7FFE8723E0D0
    public void FinishInitRelations(){} // RVA: 0x7FFE8723E480
}

public class DataSet`1 : Object
{
    public bool _disposed;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void get_disposed(){} // RVA: 0x7FFE80E2F150
    public void set_disposed(){} // RVA: 0x7FFE80E466C0
    public void Dispose(){} // RVA: 0x7FFE80E466C0 | overloaded x2
    public void RegisterUpdate(){}
    public void HasMappedBufferRange(){} // RVA: 0x7FFE80E2F150
    public void SendUpdates(){} // RVA: 0x7FFE80E45FE0
    public void SendFullRange(){} // RVA: 0x7FFE80E45FE0
    public void SendPartialRanges(){} // RVA: 0x7FFE80E45FE0
    public void ResetUpdateState(){} // RVA: 0x7FFE80E45FE0
}

public class DataStorageShadow : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DataTableRelationCollection : DataRelationCollection
{
    public System.Data.DataTable _table; // 0x38
    public System.Collections.ArrayList _relations; // 0x40
    public bool _fParentCollection; // 0x48

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8723CB10
    public void get_List(){} // RVA: 0x7FFE81178740
    public void EnsureDataSet(){} // RVA: 0x7FFE8723CC70
    public void GetDataSet(){} // RVA: 0x7FFE8723CCC0
    public void get_Item(){} // RVA: 0x7FFE8723CE20 | overloaded x2
    public void add_RelationPropertyChanged(){} // RVA: 0x7FFE8723CF20
    public void remove_RelationPropertyChanged(){} // RVA: 0x7FFE8723D010
    public void AddCache(){} // RVA: 0x7FFE8723D100
    public void AddCore(){} // RVA: 0x7FFE8723D1A0
    public void RemoveCache(){} // RVA: 0x7FFE8723D320
    public void RemoveCore(){} // RVA: 0x7FFE8723D410
}

public class DataTokenFormatter : BaseFormatter`1
{
    // ── Methods ──
    public void DeserializeImplementation(){} // RVA: 0x7FFE8823A4F0
    public void SerializeImplementation(){} // RVA: 0x7FFE8823AC20
    public void .ctor(){} // RVA: 0x7FFE8823B140
    public void .cctor(){} // RVA: 0x7FFE8823B1A0
}

public class DataViewSettingsEnumerator : Object
{
    public System.Data.DataViewSettingCollection _dataViewSettings; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87252080
    public void MoveNext(){} // RVA: 0x7FFE87252290
    public void Reset(){} // RVA: 0x7FFE872522E0
    public void get_Current(){} // RVA: 0x7FFE87252330
}

public class DateMapping : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8691D7D0
}

public class DateTime : Object
{
    // ── Methods ──
    public void TryParse(){} // RVA: 0x7FFE87358BF0
    public void .cctor(){} // RVA: 0x7FFE87358C50
}

public class DateTimeParseData : ValueType
{
    public int Year; // 0x10

    // ── Methods ──
    public void get_OffsetNegative(){} // RVA: 0x7FFE86E412B0
}

public class DbRow : ValueType
{
    public int _location; // 0x10
    public int _sizeOrLengthUnion; // 0x14
    public int _numberOfRowsAndTypeUnion; // 0x18
    public object field_3; // 0xAE
    public object field_4; // 0xAF
    public object field_5; // 0xB0
    public object field_6; // 0xB1

    // ── Methods ──
    public void get_Location(){} // RVA: 0x7FFE826F4220
    public void get_SizeOrLength(){} // RVA: 0x7FFE86E49AB0
    public void get_IsUnknownSize(){} // RVA: 0x7FFE86E49AC0
    public void get_HasComplexChildren(){} // RVA: 0x7FFE86E49AD0
    public void get_NumberOfRows(){} // RVA: 0x7FFE86E49AE0
    public void get_TokenType(){} // RVA: 0x7FFE86E49AF0
    public void .ctor(){} // RVA: 0x7FFE86E49B00
    public void get_IsSimpleValue(){} // RVA: 0x7FFE86E49B20
}

public class DeactivateControllerLabelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8441ECB0
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE8A4D89B0
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class DeactivateObjectLabelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8117B190
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class DebugHash : ValueType
{
}

public class DebugImageInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86EAEF70
    public void ContainsAddress(){} // RVA: 0x7FFE86EAF0B0
}

public class DebugInfoComparer : Object
{
    // ── Methods ──
    public void System.Collections.Generic.IComparer<System.Linq.Expressions.Interpreter.DebugInfo>.Compare(){} // RVA: 0x7FFE8716C1C0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DebugInfoExpressionProxy : Object
{
    public System.Linq.Expressions.DebugInfoExpression _node; // 0x10
    public object field_1; // 0xB3
    public object field_2; // 0xB4
    public object field_3; // 0xB5
    public object field_4; // 0xB6
    public object field_5; // 0xB7
    public object field_6; // 0xB8
    public object field_7; // 0xB9
    public object field_8; // 0xBA
    public object field_9; // 0xBB

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871199A0
    public void get_CanReduce(){} // RVA: 0x7FFE81588760
    public void get_DebugView(){} // RVA: 0x7FFE87119570
    public void get_Document(){} // RVA: 0x7FFE8189BB90
    public void get_EndColumn(){} // RVA: 0x7FFE815889F0
    public void get_EndLine(){} // RVA: 0x7FFE87119A80
    public void get_IsClear(){} // RVA: 0x7FFE81588880
    public void get_NodeType(){} // RVA: 0x7FFE81588A80
    public void get_StartColumn(){} // RVA: 0x7FFE826F8E90
    public void get_StartLine(){} // RVA: 0x7FFE86853DF0
    public void get_Type(){} // RVA: 0x7FFE815888E0
}

public class DebugMessage : ValueType
{
}

public class DebugView : Object
{
    public System.Text.Json.Nodes.JsonValue`1<T> _node;
    public object 0; // 0x1AE
    public object 0; // 0x1AF

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void get_Json(){} // RVA: 0x7FFE80E2E2E0
    public void get_Path(){} // RVA: 0x7FFE80E2E2E0
    public void get_Value(){} // RVA: 0x7FFE810A1420
}

public class DebugViewItem : ValueType
{
    public System.Text.Json.Nodes.JsonNode Value; // 0x10

    // ── Methods ──
    public void get_Display(){} // RVA: 0x7FFE873F87D0
}

public class DebugViewPrinter : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87182D80
    public void Analyze(){} // RVA: 0x7FFE87183040
    public void AddTryStart(){} // RVA: 0x7FFE871833C0
    public void AddHandlerExit(){} // RVA: 0x7FFE871834F0
    public void Indent(){} // RVA: 0x7FFE871835E0
    public void Dedent(){} // RVA: 0x7FFE87183660
    public void ToString(){} // RVA: 0x7FFE871836E0
    public void EmitExits(){} // RVA: 0x7FFE87184050
}

public class DebugViewProperty : ValueType
{
    public System.Text.Json.Nodes.JsonNode Value; // 0x10

    // ── Methods ──
    public void get_Display(){} // RVA: 0x7FFE873FFA30
}

public class DebuggerProxy : Object
{
}

public class DecCalc : ValueType
{
    public uint uflags; // 0x10
    public uint uhi; // 0x14
    public uint ulo; // 0x18
    public uint umid; // 0x1C
    public ulong ulomidLE; // 0x18
    public uint[] s_powers10;

    // ── Methods ──
    public void get_High(){} // RVA: 0x7FFE826F42A0
    public void set_High(){} // RVA: 0x7FFE826F4290
    public void get_Low(){} // RVA: 0x7FFE82C33000
    public void set_Low(){} // RVA: 0x7FFE82C33010
    public void get_Mid(){} // RVA: 0x7FFE82C33020
    public void set_Mid(){} // RVA: 0x7FFE82C33030
    public void get_IsNegative(){} // RVA: 0x7FFE869D8370
    public void get_Scale(){} // RVA: 0x7FFE82BC9950
    public void get_Low64(){} // RVA: 0x7FFE86A5E330
    public void set_Low64(){} // RVA: 0x7FFE82C72B10
    public void GetExponent(){} // RVA: 0x7FFE86A5E350 | overloaded x2
    public void UInt32x32To64(){} // RVA: 0x7FFE8695FB20
    public void UInt64x64To128(){} // RVA: 0x7FFE86A5E360
    public void Div96By32(){} // RVA: 0x7FFE86A5E4D0
    public void Div96ByConst(){} // RVA: 0x7FFE86A5E540
    public void Unscale(){} // RVA: 0x7FFE86A5E5B0
    public void Div96By64(){} // RVA: 0x7FFE86A5E7C0
    public void Div128By96(){} // RVA: 0x7FFE86A5E910
    public void IncreaseScale(){} // RVA: 0x7FFE86A5EA30
    public void IncreaseScale64(){} // RVA: 0x7FFE86A5EAC0
    public void ScaleResult(){} // RVA: 0x7FFE86A5EB40
    public void DivByConst(){} // RVA: 0x7FFE86A5F230
    public void LeadingZeroCount(){} // RVA: 0x7FFE86A5F2B0
    public void OverflowUnscale(){} // RVA: 0x7FFE86A5F310
    public void SearchScale(){} // RVA: 0x7FFE86A5F440
    public void Add32To96(){} // RVA: 0x7FFE86A5F620
    public void DecAddSub(){} // RVA: 0x7FFE86A5F640
    public void VarCyFromDec(){} // RVA: 0x7FFE86A5FD10
    public void VarDecCmp(){} // RVA: 0x7FFE86A5FF20
    public void VarDecCmpSub(){} // RVA: 0x7FFE86A60040
    public void VarDecMul(){} // RVA: 0x7FFE86A60240
    public void VarDecFromR4(){} // RVA: 0x7FFE86A60720
    public void VarDecFromR8(){} // RVA: 0x7FFE86A60B20
    public void VarR4FromDec(){} // RVA: 0x7FFE86A60F10
    public void VarR8FromDec(){} // RVA: 0x7FFE86A60F70
    public void GetHashCode(){} // RVA: 0x7FFE86A61090
    public void VarDecDiv(){} // RVA: 0x7FFE86A611E0
    public void VarDecMod(){} // RVA: 0x7FFE86A61C10
    public void VarDecModFull(){} // RVA: 0x7FFE86A62000
    public void InternalRound(){} // RVA: 0x7FFE86A62440
    public void DecDivMod1E9(){} // RVA: 0x7FFE86A62750
    public void .cctor(){} // RVA: 0x7FFE86A627D0
}

public class DecimalByteUnion : ValueType
{
}

public class DecimalStruct : Object
{
    public bool isDecimal; // 0x10
    public System.Decimal[] dvalue; // 0x18

    // ── Methods ──
    public void get_IsDecimal(){} // RVA: 0x7FFE811C55E0
    public void set_IsDecimal(){} // RVA: 0x7FFE811C55F0
    public void get_Dvalue(){} // RVA: 0x7FFE810FE7C0
    public void .ctor(){} // RVA: 0x7FFE87617670 | overloaded x2
}

public class DeclBaseInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE874D7BF0
    public void Reset(){} // RVA: 0x7FFE874D7C00
}

public class Decoder : DecoderNLS
{
    public int lastByte; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86798EC0
    public void Reset(){} // RVA: 0x7FFE86798ED0
    public void get_HasState(){} // RVA: 0x7FFE86798F00
}

public class DecoderUTF7Fallback : DecoderFallback
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void CreateFallbackBuffer(){} // RVA: 0x7FFE86790660
    public void get_MaxCharCount(){} // RVA: 0x7FFE811EDAF0
    public void Equals(){} // RVA: 0x7FFE867906A0
    public void GetHashCode(){} // RVA: 0x7FFE86790700
}

public class DecoderUTF7FallbackBuffer : DecoderFallbackBuffer
{
    public char cFallback; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86790710
    public void Fallback(){} // RVA: 0x7FFE86790720
    public void GetNextChar(){} // RVA: 0x7FFE86790770
    public void get_Remaining(){} // RVA: 0x7FFE86779E90
    public void Reset(){} // RVA: 0x7FFE86779EA0
    public void InternalFallback(){} // RVA: 0x7FFE86790790
}

public class DecomposedGuid : ValueType
{
}

public class DecrementDouble : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87153280
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DecrementInt16 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87152B20
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DecrementInt32 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87152BF0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DecrementInt64 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87152CC0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DecrementSingle : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87153140
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DecrementUInt16 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87152E00
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DecrementUInt32 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87152ED0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DecrementUInt64 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87153000
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DefaultComparer`1 : ValueType
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFE810A1420
}

public class DefaultDecoder : Decoder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8679F0B0 | overloaded x2
    public void GetRealObject(){} // RVA: 0x7FFE8679F3F0
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE8679F4A0
    public void GetCharCount(){} // RVA: 0x7FFE8679F570 | overloaded x3
    public void GetChars(){} // RVA: 0x7FFE8679F5E0 | overloaded x3
}

public class DefaultEncoder : Encoder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8679EA50 | overloaded x2
    public void GetRealObject(){} // RVA: 0x7FFE8679EE20
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE8679EF40
    public void GetByteCount(){} // RVA: 0x7FFE8679F010 | overloaded x2
    public void GetBytes(){} // RVA: 0x7FFE8679F080 | overloaded x2
}

public class DefaultEventInterests : ValueType
{
}

public class DefaultExpressionProxy : Object
{
    public System.Linq.Expressions.DefaultExpression _node; // 0x10
    public object field_1; // 0xBD
    public object field_2; // 0xBE
    public object field_3; // 0xBF

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87119AB0
    public void get_CanReduce(){} // RVA: 0x7FFE81588760
    public void get_DebugView(){} // RVA: 0x7FFE87119570
    public void get_NodeType(){} // RVA: 0x7FFE81588A80
    public void get_Type(){} // RVA: 0x7FFE815888E0
}

public class DefaultExtendedTypeDescriptor : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8272BDB0
    public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7FFE877EC9D0
    public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x7FFE877ECCF0
    public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x7FFE877ECF40
    public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7FFE877ED140
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x7FFE877ED450
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x7FFE877ED600
    public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7FFE877ED7B0
    public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x7FFE877EDD70 | overloaded x2
    public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7FFE877EE370 | overloaded x2
    public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x7FFE877EE650
}

public class DefaultF2mLookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.F2mCurve m_outer; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE862265A0
    public void get_Size(){} // RVA: 0x7FFE8151D690
    public void Lookup(){} // RVA: 0x7FFE8A419CC0
}

public class DefaultGroupInstanceSetting : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE89C2EDC0
}

public class DefaultLookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve m_outer; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE862265A0
    public void get_Size(){} // RVA: 0x7FFE8151D690
    public void Lookup(){} // RVA: 0x7FFE8A416B80
}

public class DefaultRuntimeFactory : Object
{
    // ── Methods ──
    public void CreateGameObject(){} // RVA: 0x7FFE87E067F0
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void .cctor(){} // RVA: 0x7FFE87E06860
}

public class DefaultTypeDescriptor : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82760A10
    public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7FFE877EE880
    public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x7FFE877EEB70
    public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x7FFE877EED70
    public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7FFE877EEF40
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x7FFE877EF230
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x7FFE877EF410
    public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7FFE877EF5F0
    public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x7FFE877EFB70 | overloaded x2
    public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7FFE877F0150 | overloaded x2
    public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x7FFE877F0440
}

public class DefaultWebProxy : Object
{
    public DefaultWebProxy _instance;
    public object field_1; // 0x605

    // ── Methods ──
    public void get_Instance(){} // RVA: 0x7FFE87704B30
    public void get_Credentials(){} // RVA: 0x7FFE87704B90
    public void GetProxy(){} // RVA: 0x7FFE87704BD0
    public void IsBypassed(){} // RVA: 0x7FFE87704C10
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void .cctor(){} // RVA: 0x7FFE87704C50
}

public class DeferBindingResolutionWrapper : Object
{
    // ── Methods ──
    public void Acquire(){} // RVA: 0x7FFE878E0870
    public void Dispose(){} // RVA: 0x7FFE878E08D0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DeferPromise : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void GetResult(){} // RVA: 0x7FFE87839BA0
    public void GetStatus(){} // RVA: 0x7FFE87839C00
    public void OnCompleted(){} // RVA: 0x7FFE87839DE0
    public void UnsafeGetStatus(){} // RVA: 0x7FFE87839E90
}

public class DeferPromiseWithState`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
}

public class DeferPromiseWithState`2 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
}

public class DeferPromise`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
}

public class DeferredPassthroughMeshAddition : ValueType
{
}

public class DeflateOutputStream : ZOutputStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE89F9F820
    public void Flush(){} // RVA: 0x7FFE810FB310
}

public class DelayFramePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<DelayFramePromise> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE878369D0
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Create(){} // RVA: 0x7FFE87836B50
    public void GetResult(){} // RVA: 0x7FFE87836F70
    public void GetStatus(){} // RVA: 0x7FFE87837110
    public void UnsafeGetStatus(){} // RVA: 0x7FFE87837160
    public void OnCompleted(){} // RVA: 0x7FFE878371A0
    public void MoveNext(){} // RVA: 0x7FFE87837220
    public void TryReturn(){} // RVA: 0x7FFE87837340
}

public class DelayIgnoreTimeScalePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<DelayIgnoreTimeScalePromise> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE878381F0
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Create(){} // RVA: 0x7FFE87838370
    public void GetResult(){} // RVA: 0x7FFE878387E0
    public void GetStatus(){} // RVA: 0x7FFE87838980
    public void UnsafeGetStatus(){} // RVA: 0x7FFE878389D0
    public void OnCompleted(){} // RVA: 0x7FFE87838A10
    public void MoveNext(){} // RVA: 0x7FFE87838A90
    public void TryReturn(){} // RVA: 0x7FFE87838C20
}

public class DelayPromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<DelayPromise> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE87837580
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Create(){} // RVA: 0x7FFE87837700
    public void GetResult(){} // RVA: 0x7FFE87837B70
    public void GetStatus(){} // RVA: 0x7FFE87837D10
    public void UnsafeGetStatus(){} // RVA: 0x7FFE87837D60
    public void OnCompleted(){} // RVA: 0x7FFE87837DA0
    public void MoveNext(){} // RVA: 0x7FFE87837E20
    public void TryReturn(){} // RVA: 0x7FFE87837FB0
}

public class DelayRealtimePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<DelayRealtimePromise> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE87838E60
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Create(){} // RVA: 0x7FFE87838FE0
    public void GetResult(){} // RVA: 0x7FFE87839420
    public void GetStatus(){} // RVA: 0x7FFE878395C0
    public void UnsafeGetStatus(){} // RVA: 0x7FFE87839610
    public void OnCompleted(){} // RVA: 0x7FFE87839650
    public void MoveNext(){} // RVA: 0x7FFE878396D0
    public void TryReturn(){} // RVA: 0x7FFE87839810
}

public class Delegate : Object
{
    public Google.Protobuf.MessageParser`1<Delegate> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public object delegate_; // 0x18
    public 0x6660A08C delegateCase_; // 0x20
    public object field_4; // 0x2C
    public object field_5; // 0x2D
    public object field_6; // 0x2E
    public object field_7; // 0x2F

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFE86625370
    public void get_Descriptor(){} // RVA: 0x7FFE866253D0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86625450
    public void .ctor(){} // RVA: 0x7FFE866254A0 | overloaded x2
    public void Clone(){} // RVA: 0x7FFE866257C0
    public void get_Tflite(){} // RVA: 0x7FFE86625820
    public void set_Tflite(){} // RVA: 0x7FFE86625880
    public void get_Gpu(){} // RVA: 0x7FFE866258E0
    public void set_Gpu(){} // RVA: 0x7FFE86625940
    public void get_Nnapi(){} // RVA: 0x7FFE866259A0
    public void set_Nnapi(){} // RVA: 0x7FFE86625A00
    public void get_Xnnpack(){} // RVA: 0x7FFE86625A60
    public void set_Xnnpack(){} // RVA: 0x7FFE86625AC0
    public void get_DelegateCase(){} // RVA: 0x7FFE8151D690
    public void ClearDelegate(){} // RVA: 0x7FFE86583FE0
    public void Equals(){} // RVA: 0x7FFE86625B80 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE86625D40
    public void ToString(){} // RVA: 0x7FFE86625F70
    public void WriteTo(){} // RVA: 0x7FFE8657A4A0
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86625FC0
    public void CalculateSize(){} // RVA: 0x7FFE866261C0
    public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866269E0
    public void .cctor(){} // RVA: 0x7FFE86626C50
}

public class DelegateEntry : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86A46580
    public void DeserializeDelegate(){} // RVA: 0x7FFE86A46960
}

public class DelegateEnumerator : FileSystemEnumerator`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void TransformEntry(){} // RVA: 0x7FFE810A1420
    public void ShouldRecurseIntoEntry(){} // RVA: 0x7FFE80E2F3B0
    public void ShouldIncludeEntry(){} // RVA: 0x7FFE80E2F3B0
}

public class Deleter : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82BE9AD0
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class DeletionCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE812572A0
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class DeliverIosPlatformEvents : ValueType
{
}

public class DeltaStateEventBuffer : ValueType
{
}

public class DepthOrderedDirtyTracking : ValueType
{
    // ── Methods ──
    public void EnsureFits(){} // RVA: 0x7FFE87E8E210
    public void RegisterDirty(){} // RVA: 0x7FFE87E8E330
    public void ClearDirty(){} // RVA: 0x7FFE87E8E630
    public void Reset(){} // RVA: 0x7FFE87E8E9D0
}

public class DerComparer : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFE8A12FC10
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DeriveBytes : Object
{
    public byte[] keyDiversifier;
    public byte[] ivDiversifier; // 0x8
    public byte[] macDiversifier; // 0x10
    public string _hashName; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void set_HashName(){} // RVA: 0x7FFE810FCE30
    public void set_IterationCount(){} // RVA: 0x7FFE8144DF00
    public void set_Password(){} // RVA: 0x7FFE867053C0
    public void set_Salt(){} // RVA: 0x7FFE86705540
    public void Adjust(){} // RVA: 0x7FFE867056A0
    public void Derive(){} // RVA: 0x7FFE86705770
    public void DeriveKey(){} // RVA: 0x7FFE86705C20
    public void DeriveIV(){} // RVA: 0x7FFE86705CA0
    public void DeriveMAC(){} // RVA: 0x7FFE86705D20
    public void .cctor(){} // RVA: 0x7FFE86705DA0
}

public class DerivedJsonTypeInfo : Object
{
    public System.Text.Json.Serialization.Metadata.JsonTypeInfo _jsonTypeInfo; // 0x10
    public System.Type _derivedType; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86F49820
    public void get_DerivedType(){} // RVA: 0x7FFE810FE7C0
    public void get_TypeDiscriminator(){} // RVA: 0x7FFE811290C0
    public void GetJsonTypeInfo(){} // RVA: 0x7FFE8741D080
}

public class DerivedTypeList : ConfigurationList`1
{
    public System.Text.Json.Serialization.Metadata.JsonPolymorphismOptions _parent; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8740D8C0
    public void get_IsReadOnly(){} // RVA: 0x7FFE8740DA20
    public void OnCollectionModifying(){} // RVA: 0x7FFE8740DA50
}

public class DeserializationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8401C4D0
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE881169B0
    public void EndInvoke(){} // RVA: 0x7FFE86D18840
}

public class Deserialize32QuaternionDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B9EE00
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE881169B0
    public void EndInvoke(){} // RVA: 0x7FFE82C67E40
}

public class Deserialize32Vector3Delegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B9EE00
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE881169B0
    public void EndInvoke(){} // RVA: 0x7FFE82C67E40
}

public class DeserializeFloatDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B9EE00
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE88116A80
    public void EndInvoke(){} // RVA: 0x7FFE82C67E40
}

public class DeserializeFloatsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B9EE00
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE881169B0
    public void EndInvoke(){} // RVA: 0x7FFE82C67E40
}

public class DeserializeQuaternionDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B9EE00
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE881169B0
    public void EndInvoke(){} // RVA: 0x7FFE82C67E40
}

public class DeserializeVector3Delegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B9EE00
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE881169B0
    public void EndInvoke(){} // RVA: 0x7FFE82C67E40
}

public class DesignerOptionCollection : Object
{
    public System.ComponentModel.Design.DesignerOptionService _service; // 0x10
    public string _name; // 0x18
    public object _value; // 0x20
    public System.Collections.ArrayList _children; // 0x28
    public System.ComponentModel.PropertyDescriptorCollection _properties; // 0x30

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7FFE877F3440
    public void get_Name(){} // RVA: 0x7FFE810FE7C0
    public void get_Properties(){} // RVA: 0x7FFE877F3480
    public void CopyTo(){} // RVA: 0x7FFE877F3CB0
    public void EnsurePopulated(){} // RVA: 0x7FFE877F3D10
    public void GetEnumerator(){} // RVA: 0x7FFE877F3DF0
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE827C4A80
}

public class DesignerOptionConverter : TypeConverter
{
    // ── Methods ──
    public void GetPropertiesSupported(){} // RVA: 0x7FFE811E0850
    public void GetProperties(){} // RVA: 0x7FFE877F4150
    public void ConvertTo(){} // RVA: 0x7FFE877F4700
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DesignerWebRequestCreate : Object
{
    // ── Methods ──
    public void Create(){} // RVA: 0x7FFE876679A0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DestroyPipelineDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class DestroyRigDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class Development : Object
{
    // ── Methods ──
    public void Log(){} // RVA: 0x7FFE86CD5D40
    public void LogWarning(){} // RVA: 0x7FFE86CD5DC0
    public void LogError(){} // RVA: 0x7FFE86CD5E40
    public void LogRequest(){} // RVA: 0x7FFE810FB310
    public void LogRequestResult(){} // RVA: 0x7FFE810FB310
}

public class DeviceArray : ValueType
{
    // ── Methods ──
    public void IndexOf(){} // RVA: 0x7FFE878CF5D0
    public void Remove(){} // RVA: 0x7FFE878CF670
    public void Get(){} // RVA: 0x7FFE878CF730
    public void Set(){} // RVA: 0x7FFE878CF8A0
}

public class DeviceBuilder : ValueType
{
    public UnityEngine.InputSystem.InputDevice _device; // 0x10

    // ── Methods ──
    public void get_device(){} // RVA: 0x7FFE8284EF60
    public void set_device(){} // RVA: 0x7FFE81D7E9E0
    public void WithName(){} // RVA: 0x7FFE87931DF0
    public void WithDisplayName(){} // RVA: 0x7FFE87931E90
    public void WithShortDisplayName(){} // RVA: 0x7FFE87931F70
    public void WithLayout(){} // RVA: 0x7FFE87932050
    public void WithChildren(){} // RVA: 0x7FFE87932120
    public void WithStateBlock(){} // RVA: 0x7FFE87932150
    public void IsNoisy(){} // RVA: 0x7FFE87932200
    public void WithControlUsage(){} // RVA: 0x7FFE87932330
    public void WithControlAlias(){} // RVA: 0x7FFE87932460
    public void WithStateOffsetToControlIndexMap(){} // RVA: 0x7FFE87932500
    public void WithControlTree(){} // RVA: 0x7FFE87932570
    public void Finish(){} // RVA: 0x7FFE87932760
}

public class DeviceConnectedChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE844218E0
    public void Invoke(){} // RVA: 0x7FFE812574E0
    public void BeginInvoke(){} // RVA: 0x7FFE87021A00
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class DeviceDescriptionJson : ValueType
{
}

public class DeviceIndexChangedHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84422090
    public void Invoke(){} // RVA: 0x7FFE812574E0
    public void BeginInvoke(){} // RVA: 0x7FFE8701AAB0
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class DeviceInfo : ValueType
{
    public int m_DeviceId; // 0x10
    public string m_Layout; // 0x18
    public UnityEngine.InputSystem.Utilities.FourCC m_StateFormat; // 0x20
    public int m_StateSizeInBytes; // 0x24

    // ── Methods ──
    public void get_deviceId(){} // RVA: 0x7FFE826F4220
    public void set_deviceId(){} // RVA: 0x7FFE815BF990
    public void get_layout(){} // RVA: 0x7FFE826F4210
    public void set_layout(){} // RVA: 0x7FFE826F4230
    public void get_stateFormat(){} // RVA: 0x7FFE811485C0
    public void set_stateFormat(){} // RVA: 0x7FFE810FE0C0
    public void get_stateSizeInBytes(){} // RVA: 0x7FFE8164B230
    public void set_stateSizeInBytes(){} // RVA: 0x7FFE8164E0F0
}
