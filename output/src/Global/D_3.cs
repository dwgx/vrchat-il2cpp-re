// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 56
// Methods: 270

public class DSRowDiffIdUsageSection : ValueType
{
    public object _targetDS;

    // ── Methods ──
    public void Prepare(){} // RVA: 0x902BD0
}

public class DS[] : Array
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

public class DS[][] : Array
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

public class DataRowReferenceComparer : Object
{
    public object s_default;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void Equals(){} // RVA: 0x3F12D40
    public void GetHashCode(){} // RVA: 0x71778D0
    public void .cctor(){} // RVA: 0x71778F0
}

public class DataRowTree : RBTree`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x716D5E0
    public void CompareNode(){} // RVA: 0x716D640
    public void CompareSateliteTreeNode(){} // RVA: 0x716D670
}

public class DataSetRelationCollection : DataRelationCollection
{
    public object _dataSet;
    public object _relations;
    public object _delayLoadingRelations;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7166D30
    public void get_List(){} // RVA: 0xBC1B30
    public void Clear(){} // RVA: 0x7166E70
    public void GetDataSet(){} // RVA: 0xD05CA0
    public void get_Item(){} // RVA: 0x7167000
    public void AddCore(){} // RVA: 0x7167100
    public void RemoveCore(){} // RVA: 0x71677A0
    public void FinishInitRelations(){} // RVA: 0x7167B50
}

public class DataTableRelationCollection : DataRelationCollection
{
    public object _table;
    public object _relations;
    public object _fParentCollection;
    public object RelationPropertyChanged;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7166270
    public void get_List(){} // RVA: 0xBC1B30
    public void EnsureDataSet(){} // RVA: 0x71663D0
    public void GetDataSet(){} // RVA: 0x7166420
    public void get_Item(){} // RVA: 0x7166580
    public void add_RelationPropertyChanged(){} // RVA: 0x7166680
    public void remove_RelationPropertyChanged(){} // RVA: 0x7166770
    public void AddCache(){} // RVA: 0x7166860
    public void AddCore(){} // RVA: 0x7166900
    public void RemoveCache(){} // RVA: 0x7166A80
    public void RemoveCore(){} // RVA: 0x7166B70
}

public class DataViewSettingsEnumerator : Object
{
    public object _dataViewSettings;
    public object _tableEnumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x717B150
    public void MoveNext(){} // RVA: 0x717B360
    public void Reset(){} // RVA: 0x717B3B0
    public void get_Current(){} // RVA: 0x717B400
}

public class DateTime : Object
{
    public object ToString;

    // ── Methods ──
    public void TryParse(){} // RVA: 0x727EF00
    public void .cctor(){} // RVA: 0x727EF60
}

public class DateTimeParseData : ValueType
{
    public object Year;
    public object Month;
    public object Day;
    public object IsCalendarDateOnly;
    public object Hour;
    public object Minute;
    public object Second;
    public object Fraction;
    public object OffsetHours;
    public object OffsetMinutes;
    public object OffsetToken;

    // ── Methods ──
    public void get_OffsetNegative(){} // RVA: 0x90CAB0
}

public class DbRow : ValueType
{
    public object Size;
    public object _location;
    public object _sizeOrLengthUnion;
    public object _numberOfRowsAndTypeUnion;
    public object UnknownSize;

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

public class DebugInfoComparer : Object
{
    // ── Methods ──
    public void System.Collections.Generic.IComparer<System.Linq.Expressions.Interpreter.DebugInfo>.Compare(){} // RVA: 0x7099C70
    public void .ctor(){} // RVA: 0xB43310
}

public class DebugInfoExpressionProxy : Object
{
    public object _node;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7048F00
    public void get_CanReduce(){} // RVA: 0x10AD460
    public void get_DebugView(){} // RVA: 0x7048AD0
    public void get_Document(){} // RVA: 0x13F9340
    public void get_EndColumn(){} // RVA: 0x10ADE70
    public void get_EndLine(){} // RVA: 0x7048FE0
    public void get_IsClear(){} // RVA: 0x10AD020
    public void get_NodeType(){} // RVA: 0x10AD380
    public void get_StartColumn(){} // RVA: 0x22368C0
    public void get_StartLine(){} // RVA: 0x678C250
    public void get_Type(){} // RVA: 0x10ACB60
}

public class DebugView : Object
{
    public object _node;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void get_Json(){} // RVA: 0x35AA9C0
    public void get_Path(){} // RVA: 0x35AA9F0
    public void get_Items(){} // RVA: 0x731E4D0
}

public class DebugView : Object
{
    public object _node;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void get_Json(){} // RVA: 0x35AA9C0
    public void get_Path(){} // RVA: 0x35AA9F0
    public void get_Items(){} // RVA: 0x73255A0
}

public class DebugView : Object
{
    public object _node;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void get_Json(){} // RVA: 0x87C0A0
    public void get_Path(){} // RVA: 0x87C0A0
    public void get_Value(){} // RVA: 0xA94080
}

public class DebugView : Object
{
    public object _array;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x708AA60
    public void get_A0(){} // RVA: 0x708AB90
    public void GetInstructionViews(){} // RVA: 0x708ABA0
    public void <GetInstructionViews>b__4_0(){} // RVA: 0x708AC60
}

public class DebugView : Object
{
    public object _list;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7090760
    public void get_A0(){} // RVA: 0x7090840
    public void GetInstructionViews(){} // RVA: 0x70909E0
    public void <GetInstructionViews>b__4_0(){} // RVA: 0x7090E10
}

public class DebugViewItem : ValueType
{
    public object Value;

    // ── Methods ──
    public void get_Display(){} // RVA: 0x912230
}

public class DebugViewPrinter : Object
{
    public object _interpreter;
    public object _tryStart;
    public object _handlerEnter;
    public object _handlerExit;
    public object _indent;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x70B0450
    public void Analyze(){} // RVA: 0x70B0710
    public void AddTryStart(){} // RVA: 0x70B0AB0
    public void AddHandlerExit(){} // RVA: 0x70B0BE0
    public void Indent(){} // RVA: 0x70B0CD0
    public void Dedent(){} // RVA: 0x70B0D50
    public void ToString(){} // RVA: 0x70B0DD0
    public void EmitExits(){} // RVA: 0x70B1750
}

public class DebugViewProperty : ValueType
{
    public object Value;
    public object PropertyName;

    // ── Methods ──
    public void get_Display(){} // RVA: 0x912380
}

public class DecimalStruct : Object
{
    public object isDecimal;
    public object dvalue;

    // ── Methods ──
    public void get_IsDecimal(){} // RVA: 0xC120A0
    public void set_IsDecimal(){} // RVA: 0xC120B0
    public void get_Dvalue(){} // RVA: 0xB465B0
    public void .ctor(){} // RVA: 0x753C790
}

public class DeclBaseInfo : Object
{
    public object _Name;
    public object _Prefix;
    public object _TypeName;
    public object _TypePrefix;
    public object _Default;
    public object _Revises;
    public object _MaxOccurs;
    public object _MinOccurs;
    public object _Checking;
    public object _ElementDecl;
    public object _Attdef;
    public object _Next;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x73FE380
    public void Reset(){} // RVA: 0x73FE390
}

public class DecrementDouble : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7081B30
    public void .ctor(){} // RVA: 0xB43310
}

public class DecrementInt16 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7081500
    public void .ctor(){} // RVA: 0xB43310
}

public class DecrementInt32 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70815A0
    public void .ctor(){} // RVA: 0xB43310
}

public class DecrementInt64 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7081640
    public void .ctor(){} // RVA: 0xB43310
}

public class DecrementSingle : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7081A10
    public void .ctor(){} // RVA: 0xB43310
}

public class DecrementUInt16 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7081750
    public void .ctor(){} // RVA: 0xB43310
}

public class DecrementUInt32 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70817F0
    public void .ctor(){} // RVA: 0xB43310
}

public class DecrementUInt64 : DecrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7081900
    public void .ctor(){} // RVA: 0xB43310
}

public class DefaultExpressionProxy : Object
{
    public object _node;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7049010
    public void get_CanReduce(){} // RVA: 0x10AD460
    public void get_DebugView(){} // RVA: 0x7048AD0
    public void get_NodeType(){} // RVA: 0x10AD380
    public void get_Type(){} // RVA: 0x10ACB60
}

public class DefaultExtendedTypeDescriptor : ValueType
{
    public object _node;
    public object _instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x76310
    public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x91EF00
    public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x91EF10
    public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x91EF20
    public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x91EF30
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x91EF40
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x91EF50
    public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x91EF60
    public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x91EF80
    public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x91EFA0
    public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x91EFB0
}

public class DefaultTypeDescriptor : ValueType
{
    public object _node;
    public object _objectType;
    public object _instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x79C50
    public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x91F080
    public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x91F090
    public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x91F0A0
    public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x91F0B0
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x91F0C0
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x91F0D0
    public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x91F0E0
    public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x91F100
    public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x91F120
    public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x91F130
}

public class DefaultWebProxy : Object
{
    public object _instance;

    // ── Methods ──
    public void get_Instance(){} // RVA: 0x7626660
    public void get_Credentials(){} // RVA: 0x76266C0
    public void GetProxy(){} // RVA: 0x7626700
    public void IsBypassed(){} // RVA: 0x7626740
    public void .ctor(){} // RVA: 0xB43310
    public void .cctor(){} // RVA: 0x7626780
}

public class DelegateEnumerator : FileSystemEnumerator`1
{
    public object _enumerable;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35B1B10
    public void TransformEntry(){} // RVA: 0x35B1BB0
    public void ShouldRecurseIntoEntry(){} // RVA: 0x35B1BE0
    public void ShouldIncludeEntry(){} // RVA: 0x35B1C20
}

public class DerivedJsonTypeInfo : Object
{
    public object _jsonTypeInfo;
    public object _derivedType;
    public object _typeDiscriminator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6E796B0
    public void get_DerivedType(){} // RVA: 0xB465B0
    public void get_TypeDiscriminator(){} // RVA: 0xB700F0
    public void GetJsonTypeInfo(){} // RVA: 0x7342B40
}

public class DerivedTypeList : ConfigurationList`1
{
    public object _parent;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x73336F0
    public void get_IsReadOnly(){} // RVA: 0x7333850
    public void OnCollectionModifying(){} // RVA: 0x7333880
}

public class DesignerOptionCollection : Object
{
    public object _service;
    public object _name;
    public object _value;
    public object _children;
    public object _properties;

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7711050
    public void get_Name(){} // RVA: 0xB465B0
    public void get_Properties(){} // RVA: 0x7711090
    public void CopyTo(){} // RVA: 0x7711870
    public void EnsurePopulated(){} // RVA: 0x77118D0
    public void GetEnumerator(){} // RVA: 0x77119B0
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2303260
}

public class DesignerOptionConverter : TypeConverter
{
    // ── Methods ──
    public void GetPropertiesSupported(){} // RVA: 0xC2E4C0
    public void GetProperties(){} // RVA: 0x7711D10
    public void ConvertTo(){} // RVA: 0x7712290
    public void .ctor(){} // RVA: 0xB43310
}

public class DesignerWebRequestCreate : Object
{
    // ── Methods ──
    public void Create(){} // RVA: 0x758CAD0
    public void .ctor(){} // RVA: 0xB43310
}

public class DictionaryEnumerator : ValueType
{
    public object _dictionary;
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void get_Entry(){} // RVA: 0x87BEB0
    public void get_Key(){} // RVA: 0x87C0A0
    public void get_Value(){} // RVA: 0x87C0A0
    public void get_Current(){} // RVA: 0x87C0A0
    public void MoveNext(){} // RVA: 0x87D280
    public void Reset(){} // RVA: 0x894290
}

public class DictionaryEnumerator : Object
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x35BEA30
}

public class DictionaryNode : Object
{
    public object key;
    public object value;
    public object next;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class DictionaryNode : Object
{
    public object key;
    public object value;
    public object next;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class DirectToArchiveWriterStream : Stream
{
    public object _position;
    public object _crcSizeStream;
    public object _everWritten;
    public object _isDisposed;
    public object _entry;
    public object _usedZip64inLH;
    public object _canWrite;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7257C30
    public void get_Length(){} // RVA: 0x7257D50
    public void get_Position(){} // RVA: 0x7257DB0
    public void set_Position(){} // RVA: 0x7257DD0
    public void get_CanRead(){} // RVA: 0xB43320
    public void get_CanSeek(){} // RVA: 0xB43320
    public void get_CanWrite(){} // RVA: 0x1C58C80
    public void ThrowIfDisposed(){} // RVA: 0x7257E30
    public void Read(){} // RVA: 0x7257EC0
    public void Seek(){} // RVA: 0x7257F20
    public void SetLength(){} // RVA: 0x7257F80
    public void Write(){} // RVA: 0x7257FE0
    public void Flush(){} // RVA: 0x72581E0
    public void Dispose(){} // RVA: 0x7258220
}

public class DivDouble : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7082B30
    public void .ctor(){} // RVA: 0xB43310
}

public class DivInt16 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70822F0
    public void .ctor(){} // RVA: 0xB43310
}

public class DivInt32 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7082420
    public void .ctor(){} // RVA: 0xB43310
}

public class DivInt64 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7082550
    public void .ctor(){} // RVA: 0xB43310
}

public class DivSingle : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7082A00
    public void .ctor(){} // RVA: 0xB43310
}

public class DivUInt16 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7082680
    public void .ctor(){} // RVA: 0xB43310
}

public class DivUInt32 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70827B0
    public void .ctor(){} // RVA: 0xB43310
}

public class DivUInt64 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70828D0
    public void .ctor(){} // RVA: 0xB43310
}

public class DtdDefaultAttributeInfoToNodeDataComparer : Object
{
    public object s_instance;

    // ── Methods ──
    public void get_Instance(){} // RVA: 0x748EFE0
    public void Compare(){} // RVA: 0x748F040
    public void .ctor(){} // RVA: 0xB43310
    public void .cctor(){} // RVA: 0x748F3A0
}

public class DtdParserProxy : Object
{
    public object reader;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void System.Xml.IDtdParserAdapter.get_NameTable(){} // RVA: 0x1805370
    public void System.Xml.IDtdParserAdapter.get_NamespaceResolver(){} // RVA: 0x17B17E0
    public void System.Xml.IDtdParserAdapter.get_BaseUri(){} // RVA: 0x748D4E0
    public void System.Xml.IDtdParserAdapter.get_IsEof(){} // RVA: 0x2512FB0
    public void System.Xml.IDtdParserAdapter.get_ParsingBuffer(){} // RVA: 0x13F92F0
    public void System.Xml.IDtdParserAdapter.get_ParsingBufferLength(){} // RVA: 0x748D5A0
    public void System.Xml.IDtdParserAdapter.get_CurrentPosition(){} // RVA: 0x748D5C0
    public void System.Xml.IDtdParserAdapter.set_CurrentPosition(){} // RVA: 0x748D5E0
    public void System.Xml.IDtdParserAdapter.get_EntityStackLength(){} // RVA: 0x748D600
    public void System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized(){} // RVA: 0x748D620
    public void System.Xml.IDtdParserAdapter.OnNewLine(){} // RVA: 0x748D640
    public void System.Xml.IDtdParserAdapter.get_LineNo(){} // RVA: 0x2668E40
    public void System.Xml.IDtdParserAdapter.get_LineStartPosition(){} // RVA: 0x1807C50
    public void System.Xml.IDtdParserAdapter.ReadData(){} // RVA: 0x748D670
    public void System.Xml.IDtdParserAdapter.ParseNumericCharRef(){} // RVA: 0x748D690
    public void System.Xml.IDtdParserAdapter.ParseNamedCharRef(){} // RVA: 0x748D760
    public void System.Xml.IDtdParserAdapter.ParsePI(){} // RVA: 0x748D780
    public void System.Xml.IDtdParserAdapter.ParseComment(){} // RVA: 0x748D7E0
    public void System.Xml.IDtdParserAdapter.PushEntity(){} // RVA: 0x748D800
    public void System.Xml.IDtdParserAdapter.PopEntity(){} // RVA: 0x748D8E0
    public void System.Xml.IDtdParserAdapter.PushExternalSubset(){} // RVA: 0x748D9F0
    public void System.Xml.IDtdParserAdapter.PushInternalDtd(){} // RVA: 0x748DB80
    public void System.Xml.IDtdParserAdapter.Throw(){} // RVA: 0x748DC70
    public void System.Xml.IDtdParserAdapter.OnSystemId(){} // RVA: 0x748DCA0
    public void System.Xml.IDtdParserAdapter.OnPublicId(){} // RVA: 0x748DD90
    public void System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation(){} // RVA: 0x748DE80
    public void System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling(){} // RVA: 0x748DEB0
    public void System.Xml.IDtdParserAdapterV1.get_Normalization(){} // RVA: 0x748CBE0
    public void System.Xml.IDtdParserAdapterV1.get_Namespaces(){} // RVA: 0x1890380
    public void System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode(){} // RVA: 0x748DED0
}
