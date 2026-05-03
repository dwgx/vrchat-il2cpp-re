// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Utilities
// Classes: 37
// Methods: 411

namespace ThirdParty.Unity.UnityEngine.InputSystem.Utilities
{
    public class ArrayHelpers : Object
    {
        // ── Methods ──
        public void LengthSafe(){} // RVA: 0x7FFE80E2EE90
        public void Clear(){} // RVA: 0x7FFE80E462E0 | overloaded x3
        public void EnsureCapacity(){} // RVA: 0x7FFE80E4D6D0
        public void DuplicateWithCapacity(){} // RVA: 0x7FFE80E4D6D0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void ContainsReference(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void HaveDuplicateReferences(){} // RVA: 0x7FFE80E31F10
        public void HaveEqualElements(){} // RVA: 0x7FFE80E32870
        public void IndexOf(){} // RVA: 0x7FFE80E38DE0 | overloaded x3
        public void IndexOfReference(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void IndexOfValue(){} // RVA: 0x7FFE810A1420
        public void Resize(){} // RVA: 0x7FFE80E4D5C0
        public void Append(){} // RVA: 0x7FFE80E33B80 | overloaded x2
        public void AppendToImmutable(){} // RVA: 0x7FFE80E33B80
        public void AppendWithCapacity(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void AppendListWithCapacity(){} // RVA: 0x7FFE810A1420
        public void InsertAt(){} // RVA: 0x7FFE810A1420
        public void InsertAtWithCapacity(){} // RVA: 0x7FFE810A1420
        public void PutAtIfNotSet(){} // RVA: 0x7FFE80E46370
        public void GrowBy(){} // RVA: 0x7FFE80E37570 | overloaded x2
        public void GrowWithCapacity(){} // RVA: 0x7FFE80E38DE0 | overloaded x2
        public void Join(){} // RVA: 0x7FFE810A1420
        public void Merge(){} // RVA: 0x7FFE80E3EAC0 | overloaded x2
        public void EraseAt(){} // RVA: 0x7FFE80E4BA70
        public void EraseAtWithCapacity(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Erase(){} // RVA: 0x7FFE810A1420
        public void EraseAtByMovingTail(){} // RVA: 0x7FFE80E4F370
        public void Copy(){} // RVA: 0x7FFE80E2E3D0
        public void Clone(){} // RVA: 0x7FFE80E2E3D0
        public void Select(){} // RVA: 0x7FFE80E2E440
        public void Swap(){} // RVA: 0x7FFE80E462E0
        public void MoveSlice(){} // RVA: 0x7FFE80E4D6D0
        public void EraseSliceWithCapacity(){} // RVA: 0x7FFE80E4FB60
        public void SwapElements(){} // RVA: 0x7FFE810A1420 | overloaded x2
    }

    public class CSharpCodeHelpers : Object
    {
        // ── Methods ──
        public void IsProperIdentifier(){} // RVA: 0x7FFE8790BEA0
        public void IsEmptyOrProperIdentifier(){} // RVA: 0x7FFE8790BF90
        public void IsEmptyOrProperNamespaceName(){} // RVA: 0x7FFE8790C090
        public void MakeIdentifier(){} // RVA: 0x7FFE8790C150
        public void MakeTypeName(){} // RVA: 0x7FFE8790C3A0
    }

    public class CallbackArray`1 : ValueType
    {
        public bool m_CannotMutateCallbacksArray; // 0x10
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Action`2<object,0x6653E6D4>> m_Callbacks; // 0x18

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFE82C33000
        public void get_Item(){} // RVA: 0x7FFE86203C70
        public void Clear(){} // RVA: 0x7FFE86203CC0
        public void AddCallback(){} // RVA: 0x7FFE86203E50
        public void RemoveCallback(){} // RVA: 0x7FFE86203FF0
        public void LockForChanges(){} // RVA: 0x7FFE86204180
        public void UnlockForChanges(){} // RVA: 0x7FFE86204190
    }

    public class DelegateHelpers : Object
    {
        // ── Methods ──
        public void InvokeCallbacksSafe(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void InvokeCallbacksSafe_AnyCallbackReturnsTrue(){} // RVA: 0x7FFE810A1420
        public void InvokeCallbacksSafe_AndInvokeReturnedActions(){} // RVA: 0x7FFE810A1420
        public void InvokeCallbacksSafe_AnyCallbackReturnsObject(){} // RVA: 0x7FFE810A1420
    }

    public class DisplayStringFormatAttribute : Attribute
    {
        public string _formatString; // 0x10

        // ── Methods ──
        public void get_formatString(){} // RVA: 0x7FFE81116380
        public void set_formatString(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class ExceptionHelpers : Object
    {
        // ── Methods ──
        public void IsExceptionIndicatingBugInCode(){} // RVA: 0x7FFE8790C730
    }

    public class ForDeviceEventObservable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87914CF0
        public void Subscribe(){} // RVA: 0x7FFE87914DF0
    }

    public class FourCC : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8790C860 | overloaded x3
        public void op_Implicit(){} // RVA: 0x7FFE82E53610 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE8790C9A0
        public void Equals(){} // RVA: 0x7FFE8790CC00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void op_Equality(){} // RVA: 0x7FFE835C4F30
        public void op_Inequality(){} // RVA: 0x7FFE8790CC90
        public void FromInt32(){} // RVA: 0x7FFE82E53610
        public void ToInt32(){} // RVA: 0x7FFE82E53610
    }

    public class ISavedState
    {
        // ── Methods ──
        public void StaticDisposeCurrentState(){} // RVA: 0x7FFE80E45FE0
        public void RestoreSavedState(){} // RVA: 0x7FFE80E45FE0
    }

    public class InlinedArray`1 : ValueType
    {
        public int length; // 0x10
        public System.Runtime.InteropServices.GCHandle firstValue; // 0x18

        // ── Methods ──
        public void get_Capacity(){} // RVA: 0x7FFE84222320
        public void .ctor(){} // RVA: 0x7FFE84224480 | overloaded x3
        public void get_Item(){} // RVA: 0x7FFE842247F0
        public void set_Item(){} // RVA: 0x7FFE84224880
        public void Clear(){} // RVA: 0x7FFE84224910
        public void ClearWithCapacity(){} // RVA: 0x7FFE84224970
        public void Clone(){} // RVA: 0x7FFE842249D0
        public void SetLength(){} // RVA: 0x7FFE84224BB0
        public void ToArray(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFE84224DD0
        public void Append(){} // RVA: 0x7FFE84225400 | overloaded x2
        public void AppendWithCapacity(){} // RVA: 0x7FFE84225030
        public void AssignWithCapacity(){} // RVA: 0x7FFE842251A0
        public void Remove(){} // RVA: 0x7FFE84225760
        public void RemoveAtWithCapacity(){} // RVA: 0x7FFE84225900
        public void RemoveAt(){} // RVA: 0x7FFE84225AC0
        public void RemoveAtByMovingTailWithCapacity(){} // RVA: 0x7FFE84225D00
        public void RemoveByMovingTailWithCapacity(){} // RVA: 0x7FFE84225E50
        public void Contains(){} // RVA: 0x7FFE84225EF0
        public void Merge(){} // RVA: 0x7FFE84226050
        public void GetEnumerator(){} // RVA: 0x7FFE842242A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE84224360
    }

    public class InputActionTrace : Object
    {
        public bool m_SubscribedToAll; // 0x10
        public bool m_OnActionChangeHooked; // 0x11

        // ── Methods ──
        public void get_buffer(){} // RVA: 0x7FFE879094A0
        public void get_count(){} // RVA: 0x7FFE8139EA30
        public void .ctor(){} // RVA: 0x7FFE87909530 | overloaded x3
        public void SubscribeToAll(){} // RVA: 0x7FFE879096C0
        public void UnsubscribeFromAll(){} // RVA: 0x7FFE87909790
        public void SubscribeTo(){} // RVA: 0x7FFE87909B70 | overloaded x2
        public void UnsubscribeFrom(){} // RVA: 0x7FFE87909F00 | overloaded x2
        public void RecordAction(){} // RVA: 0x7FFE8790A080
        public void Clear(){} // RVA: 0x7FFE8790A290
        public void Finalize(){} // RVA: 0x7FFE8790A2E0
        public void ToString(){} // RVA: 0x7FFE8790A320
        public void Dispose(){} // RVA: 0x7FFE8790A600
        public void DisposeInternal(){} // RVA: 0x7FFE8790A620
        public void GetEnumerator(){} // RVA: 0x7FFE8790A8D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8790A9E0
        public void HookOnActionChange(){} // RVA: 0x7FFE8790A9F0
        public void UnhookOnActionChange(){} // RVA: 0x7FFE8790ABC0
        public void OnActionChange(){} // RVA: 0x7FFE8790ACE0
        public void CloneActionStateBeforeBindingsChange(){} // RVA: 0x7FFE8790B070
    }

    public class InputArrayExtensions : Object
    {
        // ── Methods ──
        public void IndexOfReference(){} // RVA: 0x7FFE810A1420
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void ContainsReference(){} // RVA: 0x7FFE810A1420
    }

    public class InternedString : ValueType
    {
        public string m_StringOriginalCase; // 0x10

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFE8790CCA0
        public void .ctor(){} // RVA: 0x7FFE8790CCB0
        public void IsEmpty(){} // RVA: 0x7FFE841236F0
        public void ToLower(){} // RVA: 0x7FFE826F4210
        public void Equals(){} // RVA: 0x7FFE8790D190 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFE8790D1A0
        public void GetHashCode(){} // RVA: 0x7FFE8790D280
        public void ToString(){} // RVA: 0x7FFE8790D2B0
        public void op_Equality(){} // RVA: 0x7FFE8790D730 | overloaded x3
        public void op_Inequality(){} // RVA: 0x7FFE8790D940 | overloaded x3
        public void op_LessThan(){} // RVA: 0x7FFE8790DB50
        public void op_GreaterThan(){} // RVA: 0x7FFE8790DC30
        public void op_Implicit(){} // RVA: 0x7FFE8790D2B0
    }

    public class JsonParser : ValueType
    {
        public string m_Text; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8790DD20
        public void Reset(){} // RVA: 0x7FFE8790DDE0
        public void ToString(){} // RVA: 0x7FFE8790DDF0
        public void NavigateToProperty(){} // RVA: 0x7FFE8790DF40
        public void CurrentPropertyHasValueEqualTo(){} // RVA: 0x7FFE8790E450
        public void ParseToken(){} // RVA: 0x7FFE8790E660
        public void ParseValue(){} // RVA: 0x7FFE8790E720 | overloaded x2
        public void ParseStringValue(){} // RVA: 0x7FFE8790E840
        public void ParseArrayValue(){} // RVA: 0x7FFE8790EA80
        public void ParseObjectValue(){} // RVA: 0x7FFE8790ED80
        public void ParseNumber(){} // RVA: 0x7FFE8790F010
        public void ParseBooleanValue(){} // RVA: 0x7FFE8790F5B0
        public void ParseNullValue(){} // RVA: 0x7FFE8790F790
        public void SkipToValue(){} // RVA: 0x7FFE8790F800
        public void SkipString(){} // RVA: 0x7FFE8790F870
        public void SkipWhitespace(){} // RVA: 0x7FFE8790F940
        public void get_isAtEnd(){} // RVA: 0x7FFE8790F9E0
    }

    public class MemoryHelpers : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFE87911E10
        public void ComputeFollowingByteOffset(){} // RVA: 0x7FFE87911E90
        public void WriteSingleBit(){} // RVA: 0x7FFE87911EB0
        public void ReadSingleBit(){} // RVA: 0x7FFE87911EE0
        public void MemCpyBitRegion(){} // RVA: 0x7FFE87911F10
        public void MemCmpBitRegion(){} // RVA: 0x7FFE87912010
        public void MemSet(){} // RVA: 0x7FFE87912190
        public void MemCpyMasked(){} // RVA: 0x7FFE87912260
        public void ReadMultipleBitsAsUInt(){} // RVA: 0x7FFE87912370
        public void WriteUIntAsMultipleBits(){} // RVA: 0x7FFE87912540
        public void ReadTwosComplementMultipleBitsAsInt(){} // RVA: 0x7FFE87912740
        public void WriteIntAsTwosComplementMultipleBits(){} // RVA: 0x7FFE87912750
        public void ReadExcessKMultipleBitsAsInt(){} // RVA: 0x7FFE87912760
        public void WriteIntAsExcessKMultipleBits(){} // RVA: 0x7FFE87912790
        public void ReadMultipleBitsAsNormalizedUInt(){} // RVA: 0x7FFE879127C0
        public void WriteNormalizedUIntAsMultipleBits(){} // RVA: 0x7FFE87912830
        public void SetBitsInBuffer(){} // RVA: 0x7FFE879128A0
        public void Swap(){} // RVA: 0x7FFE80E462E0
        public void AlignNatural(){} // RVA: 0x7FFE87912B30
    }

    public class MiscHelpers : Object
    {
        // ── Methods ──
        public void GetValueOrDefault(){} // RVA: 0x7FFE810A1420
        public void EveryNth(){} // RVA: 0x7FFE80E3F430
        public void IndexOf(){} // RVA: 0x7FFE810A1420
    }

    public class NameAndParameters : ValueType
    {
        public string _name; // 0x10
        public UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.NamedValue> _parameters; // 0x18

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE8284EF60
        public void set_name(){} // RVA: 0x7FFE81D7E9E0
        public void get_parameters(){} // RVA: 0x7FFE82CF9F60
        public void set_parameters(){} // RVA: 0x7FFE82CF9F00
        public void ToString(){} // RVA: 0x7FFE87912C70
        public void ParseMultiple(){} // RVA: 0x7FFE87913300 | overloaded x2
        public void ParseName(){} // RVA: 0x7FFE87913590
        public void Parse(){} // RVA: 0x7FFE87913620
        public void ParseNameAndParameters(){} // RVA: 0x7FFE879136B0
    }

    public class NamedValue : ValueType
    {
        public string Separator;
        public string _name; // 0x10
        public UnityEngine.InputSystem.Utilities.PrimitiveValue _value; // 0x18

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE8284EF60
        public void set_name(){} // RVA: 0x7FFE81D7E9E0
        public void get_value(){} // RVA: 0x7FFE82CF9F60
        public void set_value(){} // RVA: 0x7FFE82D00180
        public void get_type(){} // RVA: 0x7FFE82C33000
        public void ConvertTo(){} // RVA: 0x7FFE87913CC0
        public void From(){} // RVA: 0x7FFE810A1420
        public void ToString(){} // RVA: 0x7FFE87913D50
        public void Equals(){} // RVA: 0x7FFE87913F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87914000
        public void op_Equality(){} // RVA: 0x7FFE87914090
        public void op_Inequality(){} // RVA: 0x7FFE879140C0
        public void ParseMultiple(){} // RVA: 0x7FFE879140F0
        public void Parse(){} // RVA: 0x7FFE87914320
        public void ParseParameter(){} // RVA: 0x7FFE87914360
        public void ApplyToObject(){} // RVA: 0x7FFE879146C0
        public void ApplyAllToObject(){} // RVA: 0x7FFE810A1420
    }

    public class NumberHelpers : Object
    {
        // ── Methods ──
        public void AlignToMultipleOf(){} // RVA: 0x7FFE879149F0 | overloaded x3
        public void Approximately(){} // RVA: 0x7FFE87914A10
        public void IntToNormalizedFloat(){} // RVA: 0x7FFE87914AE0
        public void NormalizedFloatToInt(){} // RVA: 0x7FFE87914B30
        public void UIntToNormalizedFloat(){} // RVA: 0x7FFE87914B80
        public void NormalizedFloatToUInt(){} // RVA: 0x7FFE87914BD0
        public void RemapUIntBitsToNormalizeFloatToUIntBits(){} // RVA: 0x7FFE87914C40
    }

    public class Observable : Object
    {
        // ── Methods ──
        public void Where(){} // RVA: 0x7FFE80E2E440
        public void Select(){} // RVA: 0x7FFE80E2E440
        public void SelectMany(){} // RVA: 0x7FFE80E2E440
        public void Take(){} // RVA: 0x7FFE80E3D4E0
        public void ForDevice(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
        public void CallOnce(){} // RVA: 0x7FFE80E2E440
        public void Call(){} // RVA: 0x7FFE80E2E440
    }

    public class Observer`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4F230
        public void OnCompleted(){} // RVA: 0x7FFE80E45FE0
        public void OnError(){} // RVA: 0x7FFE80E460A0
        public void OnNext(){} // RVA: 0x7FFE810A1420
    }

    public class OneOrMore`2 : ValueType
    {
        public bool m_IsSingle;
        public U m_Single;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class PredictiveParser : ValueType
    {
        // ── Methods ──
        public void ExpectSingleChar(){} // RVA: 0x7FFE879152C0
        public void ExpectInt(){} // RVA: 0x7FFE879153E0
        public void ExpectString(){} // RVA: 0x7FFE87915540
        public void AcceptSingleChar(){} // RVA: 0x7FFE879157D0
        public void AcceptString(){} // RVA: 0x7FFE87915810
        public void AcceptInt(){} // RVA: 0x7FFE87915980
    }

    public class PrimitiveValue : ValueType
    {
        public 0x664BA72C m_Type; // 0x10
        public bool m_BoolValue; // 0x14
        public char m_CharValue; // 0x14

        // ── Methods ──
        public void get_valuePtr(){} // RVA: 0x7FFE879159E0
        public void get_type(){} // RVA: 0x7FFE826F4220
        public void get_isEmpty(){} // RVA: 0x7FFE86E21EB0
        public void .ctor(){} // RVA: 0x7FFE87915B20 | overloaded x12
        public void ConvertTo(){} // RVA: 0x7FFE87915B40
        public void Equals(){} // RVA: 0x7FFE87915F00 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87916230
        public void op_Inequality(){} // RVA: 0x7FFE879162B0
        public void GetHashCode(){} // RVA: 0x7FFE87916330
        public void ToString(){} // RVA: 0x7FFE879172F0 | overloaded x2
        public void FromString(){} // RVA: 0x7FFE879167D0
        public void GetTypeCode(){} // RVA: 0x7FFE826F4220
        public void ToBoolean(){} // RVA: 0x7FFE87916FC0
        public void ToByte(){} // RVA: 0x7FFE87917080
        public void ToChar(){} // RVA: 0x7FFE87917090
        public void ToDateTime(){} // RVA: 0x7FFE879170B0
        public void ToDecimal(){} // RVA: 0x7FFE87917100
        public void ToDouble(){} // RVA: 0x7FFE87917140
        public void ToInt16(){} // RVA: 0x7FFE87917080
        public void ToInt32(){} // RVA: 0x7FFE87917080
        public void ToInt64(){} // RVA: 0x7FFE87917240
        public void ToSByte(){} // RVA: 0x7FFE87917080
        public void ToSingle(){} // RVA: 0x7FFE879172D0
        public void ToType(){} // RVA: 0x7FFE87917300
        public void ToUInt16(){} // RVA: 0x7FFE87917340
        public void ToUInt32(){} // RVA: 0x7FFE87917340
        public void ToUInt64(){} // RVA: 0x7FFE87917350
        public void ToObject(){} // RVA: 0x7FFE879173F0
        public void From(){} // RVA: 0x7FFE810A1420
        public void FromObject(){} // RVA: 0x7FFE879176F0
        public void op_Implicit(){} // RVA: 0x7FFE87918130 | overloaded x12
        public void FromBoolean(){} // RVA: 0x7FFE87917FD0
        public void FromChar(){} // RVA: 0x7FFE87917FF0
        public void FromByte(){} // RVA: 0x7FFE87918010
        public void FromSByte(){} // RVA: 0x7FFE87918030
        public void FromInt16(){} // RVA: 0x7FFE87918050
        public void FromUInt16(){} // RVA: 0x7FFE87918070
        public void FromInt32(){} // RVA: 0x7FFE87918090
        public void FromUInt32(){} // RVA: 0x7FFE879180B0
        public void FromInt64(){} // RVA: 0x7FFE879180D0
        public void FromUInt64(){} // RVA: 0x7FFE879180F0
        public void FromSingle(){} // RVA: 0x7FFE87918110
        public void FromDouble(){} // RVA: 0x7FFE87918130
    }

    public class ReadOnlyArrayExtensions : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void ContainsReference(){} // RVA: 0x7FFE810A1420
        public void IndexOfReference(){} // RVA: 0x7FFE810A1420
        public void HaveEqualReferences(){} // RVA: 0x7FFE810A1420
    }

    public class ReadOnlyArray`1 : ValueType
    {
        public UnityEngine.InputSystem.InputControl[] m_Array; // 0x10
        public int m_StartIndex; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84896780 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFE84ABE2A0
        public void IndexOf(){} // RVA: 0x7FFE84ABECF0
        public void GetEnumerator(){} // RVA: 0x7FFE84ABE4C0
        public void System.Collections.Generic.IEnumerable<TValue>.GetEnumerator(){} // RVA: 0x7FFE84ABE530
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE84ABE530
        public void op_Implicit(){} // RVA: 0x7FFE84ABE650
        public void get_Count(){} // RVA: 0x7FFE82C33020
        public void get_Item(){} // RVA: 0x7FFE84ABEDE0
    }

    public class SavedStructState`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E50660
        public void StaticDisposeCurrentState(){} // RVA: 0x7FFE80E45FE0
        public void RestoreSavedState(){} // RVA: 0x7FFE80E45FE0
    }

    public class SelectManyObservable`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4F230
        public void Subscribe(){} // RVA: 0x7FFE80E2E390
    }

    public class SpriteUtilities : Object
    {
        // ── Methods ──
        public void CreateCircleSprite(){} // RVA: 0x7FFE87918150
    }

    public class StringHelpers : Object
    {
        // ── Methods ──
        public void Escape(){} // RVA: 0x7FFE87918510
        public void Unescape(){} // RVA: 0x7FFE879186C0
        public void Contains(){} // RVA: 0x7FFE87918890 | overloaded x2
        public void GetPlural(){} // RVA: 0x7FFE879188D0
        public void NicifyMemorySize(){} // RVA: 0x7FFE87918B10
        public void FromNicifiedMemorySize(){} // RVA: 0x7FFE87918D00
        public void CountOccurrences(){} // RVA: 0x7FFE87919270
        public void Tokenize(){} // RVA: 0x7FFE87919300
        public void Split(){} // RVA: 0x7FFE879193B0
        public void Join(){} // RVA: 0x7FFE80E2E440 | overloaded x2
        public void MakeUniqueName(){} // RVA: 0x7FFE80E3EAC0
        public void CharacterSeparatedListsHaveAtLeastOneCommonElement(){} // RVA: 0x7FFE879194C0
        public void ParseInt(){} // RVA: 0x7FFE87919880
        public void WriteStringToBuffer(){} // RVA: 0x7FFE87919930 | overloaded x2
        public void ReadStringFromBuffer(){} // RVA: 0x7FFE87919BF0 | overloaded x2
        public void IsPrintable(){} // RVA: 0x7FFE87919D30
        public void WithAllWhitespaceStripped(){} // RVA: 0x7FFE87919DB0
        public void InvariantEqualsIgnoreCase(){} // RVA: 0x7FFE87919ED0
        public void ExpandTemplateString(){} // RVA: 0x7FFE87919FB0
    }

    public class Substring : ValueType
    {
        public string m_String; // 0x10
        public int m_Index; // 0x18
        public int m_Length; // 0x1C
        public object field_3; // 0x76E0

        // ── Methods ──
        public void get_isEmpty(){} // RVA: 0x7FFE8791A8B0
        public void .ctor(){} // RVA: 0x7FFE8791A930 | overloaded x3
        public void Equals(){} // RVA: 0x7FFE8791AC30 | overloaded x4
        public void CompareTo(){} // RVA: 0x7FFE8791AF20
        public void Compare(){} // RVA: 0x7FFE8791AFA0
        public void StartsWith(){} // RVA: 0x7FFE8791AFF0
        public void Substr(){} // RVA: 0x7FFE8791B090
        public void ToString(){} // RVA: 0x7FFE8791B0C0
        public void GetHashCode(){} // RVA: 0x7FFE8791B120
        public void op_Equality(){} // RVA: 0x7FFE8791B260 | overloaded x3
        public void op_Inequality(){} // RVA: 0x7FFE8791B290 | overloaded x3
        public void op_Implicit(){} // RVA: 0x7FFE8791B2C0
        public void get_length(){} // RVA: 0x7FFE82C33020
        public void get_index(){} // RVA: 0x7FFE82C33000
        public void get_Item(){} // RVA: 0x7FFE8791B330
    }

    public class TakeNObservable`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4D070
        public void Subscribe(){} // RVA: 0x7FFE80E2E390
    }

    public class TypeHelpers : Object
    {
        // ── Methods ──
        public void As(){} // RVA: 0x7FFE810A1420
        public void IsInt(){} // RVA: 0x7FFE8791B3D0
        public void GetValueType(){} // RVA: 0x7FFE8791B420
        public void GetNiceTypeName(){} // RVA: 0x7FFE8791B590
        public void GetGenericTypeArgumentFromHierarchy(){} // RVA: 0x7FFE8791BA50
    }

    public class TypeTable : ValueType
    {
        public System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,System.Type> table; // 0x10
        public uint sizePerBuffer; // 0x10

        // ── Methods ──
        public void get_names(){} // RVA: 0x7FFE8791BEC0
        public void get_internedNames(){} // RVA: 0x7FFE8791C060
        public void Initialize(){} // RVA: 0x7FFE8791C0B0
        public void FindNameForType(){} // RVA: 0x7FFE8791C160
        public void AddTypeRegistration(){} // RVA: 0x7FFE8791C3C0
        public void LookupTypeRegistration(){} // RVA: 0x7FFE8791C560
    }

    public class Vector2MagnitudeComparer : ValueType
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFE8790BDE0
    }

    public class Vector3MagnitudeComparer : ValueType
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFE8790BE40
    }

    public class WhereObservable`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4F230
        public void Subscribe(){} // RVA: 0x7FFE80E2E390
    }

}