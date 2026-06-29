// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 26
// Methods: 108

public class ParallelWriter : ValueType
{
    public object m_Buffer;
    public object m_AllocatorLabel;
    public object m_ThreadIndex;

    // ── Methods ──
    public void Enqueue(){} // RVA: 0xA94080
}

public class ParamInfo : Object
{
    public object _ftype;
    public object _minargs;
    public object _maxargs;
    public object _argTypes;

    // ── Methods ──
    public void get_FType(){} // RVA: 0xB8F8F0
    public void get_Minargs(){} // RVA: 0x116A650
    public void get_Maxargs(){} // RVA: 0xE62D00
    public void get_ArgTypes(){} // RVA: 0xB700F0
    public void .ctor(){} // RVA: 0x74762D0
}

public class Parameter : InitializeLocalInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB460A0
    public void Run(){} // RVA: 0xC3CCE0
    public void BoxIfIndexMatches(){} // RVA: 0x70B2D80
    public void get_InstructionName(){} // RVA: 0x70B2E20
}

public class ParameterBox : InitializeLocalInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB460A0
    public void Run(){} // RVA: 0x70B2C10
    public void get_InstructionName(){} // RVA: 0x70B2D40
}

public class ParameterExpressionProxy : Object
{
    public object _node;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7049C30
    public void get_CanReduce(){} // RVA: 0x10AD460
    public void get_DebugView(){} // RVA: 0x7048AD0
    public void get_IsByRef(){} // RVA: 0x678C250
    public void get_Name(){} // RVA: 0x13F9340
    public void get_NodeType(){} // RVA: 0x10AD380
    public void get_Type(){} // RVA: 0x10ACB60
}

public class ParameterLookupKey : Object
{
    public object _name;
    public object _type;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x17C92C0
    public void get_Name(){} // RVA: 0xB5DBF0
    public void get_Type(){} // RVA: 0xB465B0
    public void GetHashCode(){} // RVA: 0x7340210
    public void Equals(){} // RVA: 0x73402C0
}

public class ParameterLookupValue : Object
{
    public object _duplicateName;
    public object _jsonPropertyInfo;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA9BA0
    public void get_DuplicateName(){} // RVA: 0xB5DBF0
    public void set_DuplicateName(){} // RVA: 0xB44D60
    public void get_JsonPropertyInfo(){} // RVA: 0xB465B0
}

public class ParameterizedConstructorDelegate`5 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
    public void Invoke(){} // RVA: 0xA94080
    public void BeginInvoke(){} // RVA: 0xA94080
    public void EndInvoke(){} // RVA: 0xA94080
}

public class Parser : Object
{
    public object json;

    // ── Methods ──
    public void IsWordBreak(){} // RVA: 0x6CBE7B0
    public void .ctor(){} // RVA: 0x6CBE840
    public void Parse(){} // RVA: 0x6CBE900
    public void Dispose(){} // RVA: 0x6CBEAA0
    public void ParseObject(){} // RVA: 0x6CBEB20
    public void ParseArray(){} // RVA: 0x6CBECB0
    public void ParseValue(){} // RVA: 0x6CBEDA0
    public void ParseByToken(){} // RVA: 0x6CBEDD0
    public void ParseString(){} // RVA: 0x6CBF1A0
    public void ParseNumber(){} // RVA: 0x6CBF4C0
    public void EatWhitespace(){} // RVA: 0x6CBF790
    public void get_PeekChar(){} // RVA: 0x6CBF820
    public void get_NextChar(){} // RVA: 0x6CBF8D0
    public void get_NextWord(){} // RVA: 0x6CBF980
    public void get_NextToken(){} // RVA: 0x6CBFAC0
}

public class Parser : ValueType
{
    public object typeCode;
    public object year;
    public object month;
    public object day;
    public object hour;
    public object minute;
    public object second;
    public object fraction;
    public object kind;
    public object zoneHour;
    public object zoneMinute;
    public object text;
    public object length;
    public object Power10;

    // ── Methods ──
    public void Parse(){} // RVA: 0x914860
    public void ParseDate(){} // RVA: 0x914870
    public void ParseTimeAndZoneAndWhitespace(){} // RVA: 0x914880
    public void ParseTimeAndWhitespace(){} // RVA: 0x914890
    public void ParseTime(){} // RVA: 0x9148A0
    public void ParseZoneAndWhitespace(){} // RVA: 0x9148B0
    public void Parse4Dig(){} // RVA: 0x9148C0
    public void Parse2Dig(){} // RVA: 0x9148D0
    public void ParseChar(){} // RVA: 0x9148E0
    public void Test(){} // RVA: 0x7467AD0
    public void .cctor(){} // RVA: 0x7467AE0
}

public class ParsingState : ValueType
{
    public object chars;
    public object charPos;
    public object charsUsed;
    public object encoding;
    public object appendMode;
    public object stream;
    public object decoder;
    public object bytes;
    public object bytePos;
    public object bytesUsed;
    public object textReader;
    public object lineNo;
    public object lineStartPos;
    public object baseUriStr;
    public object baseUri;
    public object isEof;
    public object isStreamEof;
    public object entity;
    public object entityId;
    public object eolNormalized;
    public object entityResolvedManually;

    // ── Methods ──
    public void Clear(){} // RVA: 0x915420
    public void Close(){} // RVA: 0x915430
    public void get_LineNo(){} // RVA: 0xA6B80
    public void get_LinePos(){} // RVA: 0x915440
}

public class PartialStateForRollback : ValueType
{
    public object _prevTotalConsumed;
    public object _prevBytePositionInLine;
    public object _prevConsumed;
    public object _prevCurrentPosition;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8F1370
    public void GetStartPosition(){} // RVA: 0x8F13E0
}

public class PathListComparer : Object
{
    public object StaticInstance;

    // ── Methods ──
    public void System.Collections.IComparer.Compare(){} // RVA: 0x75A0AC0
    public void .ctor(){} // RVA: 0xB43310
    public void .cctor(){} // RVA: 0x75A0CB0
}

public class PipelineEntry : Object
{
    public object Command;
    public object Flags;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2615F10
    public void HasFlag(){} // RVA: 0x7731690
}

public class PlayableSystemDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
}

public class PopupButtonData[] : Array
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

public class PowerOvfl : ValueType
{
    public object Hi;
    public object MidLo;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8C0C60
}

public class Predicate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6C4EFF0
    public void Invoke(){} // RVA: 0xCA8BF0
}

public class PreserveAttribute : Attribute
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class PreserveAttribute : Attribute
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class PreserveAttribute : Attribute
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class PreviousInfo : ValueType
{
    public object Code;
    public object SortKey;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8AB990
}

public class PrintErrorsCallbackFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6C50EA0
    public void Invoke(){} // RVA: 0xCA8D60
}

public class PropertyDescriptorEnumerator : Object
{
    public object _owner;
    public object _index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x39EC7C0
    public void get_Current(){} // RVA: 0x76D75A0
    public void get_Entry(){} // RVA: 0x76D7700
    public void get_Key(){} // RVA: 0x76D7780
    public void get_Value(){} // RVA: 0x76D7780
    public void MoveNext(){} // RVA: 0x76D77D0
    public void Reset(){} // RVA: 0x2576860
}

public class PropertyHierarchyResolutionState : ValueType
{
    public object AddedProperties;
    public object IgnoredProperties;
    public object IsPropertyOrderSpecified;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x912D80
}

public class Props : Object
{
    // ── Methods ──
    public void get__GetPropFromGameObject(){} // RVA: 0x83317D0
    public void set__GetPropFromGameObject(){} // RVA: 0x8331810
    public void get__GetPropApi(){} // RVA: 0x83318B0
    public void set__GetPropApi(){} // RVA: 0x83318F0
}
