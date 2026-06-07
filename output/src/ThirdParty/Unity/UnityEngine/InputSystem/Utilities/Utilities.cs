// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Utilities
// Classes: 37
// Methods: 411

namespace ThirdParty.Unity.UnityEngine.InputSystem.Utilities
{
    public class ArrayHelpers
    {
        // ── Methods ──
        public void LengthSafe(){} // RVA: 0xD920
        public void Clear(){} // RVA: 0x24D50 | overloaded x3
        public void EnsureCapacity(){} // RVA: 0x2C100
        public void DuplicateWithCapacity(){} // RVA: 0x2C100
        public void Contains(){} // RVA: 0x283FA0
        public void ContainsReference(){} // RVA: 0x283FA0 | overloaded x3
        public void HaveDuplicateReferences(){} // RVA: 0x109E0
        public void HaveEqualElements(){} // RVA: 0x11340
        public void IndexOf(){} // RVA: 0x17870 | overloaded x3
        public void IndexOfReference(){} // RVA: 0x283FA0 | overloaded x2
        public void IndexOfValue(){} // RVA: 0x283FA0
        public void Resize(){} // RVA: 0x2BFF0
        public void Append(){} // RVA: 0x12610 | overloaded x2
        public void AppendToImmutable(){} // RVA: 0x12610
        public void AppendWithCapacity(){} // RVA: 0x283FA0 | overloaded x2
        public void AppendListWithCapacity(){} // RVA: 0x283FA0
        public void InsertAt(){} // RVA: 0x283FA0
        public void InsertAtWithCapacity(){} // RVA: 0x283FA0
        public void PutAtIfNotSet(){} // RVA: 0x24DE0
        public void GrowBy(){} // RVA: 0x16000 | overloaded x2
        public void GrowWithCapacity(){} // RVA: 0x17870 | overloaded x2
        public void Join(){} // RVA: 0x283FA0
        public void Merge(){} // RVA: 0x1D550 | overloaded x2
        public void EraseAt(){} // RVA: 0x2A490
        public void EraseAtWithCapacity(){} // RVA: 0x283FA0 | overloaded x2
        public void Erase(){} // RVA: 0x283FA0
        public void EraseAtByMovingTail(){} // RVA: 0x2DDA0
        public void Copy(){} // RVA: 0xCE50
        public void Clone(){} // RVA: 0xCE50
        public void Select(){} // RVA: 0xCEC0
        public void Swap(){} // RVA: 0x24D50
        public void MoveSlice(){} // RVA: 0x2C100
        public void EraseSliceWithCapacity(){} // RVA: 0x2E590
        public void SwapElements(){} // RVA: 0x283FA0 | overloaded x2
    }

    public class CSharpCodeHelpers
    {
        // ── Methods ──
        public void IsProperIdentifier(){} // RVA: 0x6DCB010
        public void IsEmptyOrProperIdentifier(){} // RVA: 0x6DCB100
        public void IsEmptyOrProperNamespaceName(){} // RVA: 0x6DCB200
        public void MakeIdentifier(){} // RVA: 0x6DCB2C0
        public void MakeTypeName(){} // RVA: 0x6DCB510
    }

    public class CallbackArray`1
    {
        // ── Methods ──
        public void get_length(){} // RVA: 0xD840
        public void get_Item(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void AddCallback(){} // RVA: 0x283FA0
        public void RemoveCallback(){} // RVA: 0x283FA0
        public void LockForChanges(){} // RVA: 0x24A50
        public void UnlockForChanges(){} // RVA: 0x24A50
    }

    public class DelegateHelpers
    {
        // ── Methods ──
        public void InvokeCallbacksSafe(){} // RVA: 0x283FA0 | overloaded x3
        public void InvokeCallbacksSafe_AnyCallbackReturnsTrue(){} // RVA: 0x283FA0
        public void InvokeCallbacksSafe_AndInvokeReturnedActions(){} // RVA: 0x283FA0
        public void InvokeCallbacksSafe_AnyCallbackReturnsObject(){} // RVA: 0x283FA0
    }

    public class DisplayStringFormatAttribute
    {
        // ── Methods ──
        public void get_formatString(){} // RVA: 0x2F8380
        public void set_formatString(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class ExceptionHelpers
    {
        // ── Methods ──
        public void IsExceptionIndicatingBugInCode(){} // RVA: 0x6DCB8A0
    }

    public class ForDeviceEventObservable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DD3E60
        public void Subscribe(){} // RVA: 0x6DD3F60
    }

    public class FourCC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DCB9D0 | overloaded x3
        public void op_Implicit(){} // RVA: 0x20C5210 | overloaded x2
        public void ToString(){} // RVA: 0x6DCBB10
        public void Equals(){} // RVA: 0x6DCBD70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x19689B0
        public void op_Equality(){} // RVA: 0x2110AC0
        public void op_Inequality(){} // RVA: 0x6DCBE00
        public void FromInt32(){} // RVA: 0x20C5210
        public void ToInt32(){} // RVA: 0x20C5210
    }

    public class ISavedState
    {
        // ── Methods ──
        public void StaticDisposeCurrentState(){} // RVA: 0x24A50
        public void RestoreSavedState(){} // RVA: 0x24A50
    }

    public class InlinedArray`1
    {
        // ── Methods ──
        public void get_Capacity(){} // RVA: 0xD840
        public void .ctor(){} // RVA: 0x24B10 | overloaded x3
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void ClearWithCapacity(){} // RVA: 0x24A50
        public void Clone(){} // RVA: 0x283FA0
        public void SetLength(){} // RVA: 0x24FA0
        public void ToArray(){} // RVA: 0xCE10 | overloaded x2
        public void IndexOf(){} // RVA: 0x283FA0
        public void Append(){} // RVA: 0x24B10 | overloaded x2
        public void AppendWithCapacity(){} // RVA: 0x283FA0
        public void AssignWithCapacity(){} // RVA: 0x283FA0
        public void Remove(){} // RVA: 0x283FA0
        public void RemoveAtWithCapacity(){} // RVA: 0x24FA0
        public void RemoveAt(){} // RVA: 0x24FA0
        public void RemoveAtByMovingTailWithCapacity(){} // RVA: 0x24FA0
        public void RemoveByMovingTailWithCapacity(){} // RVA: 0x283FA0
        public void Contains(){} // RVA: 0x283FA0
        public void Merge(){} // RVA: 0x283FA0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class InputActionTrace
    {
        // ── Methods ──
        public void get_buffer(){} // RVA: 0x6DC8610
        public void get_count(){} // RVA: 0x59CEC0
        public void .ctor(){} // RVA: 0x6DC86A0 | overloaded x3
        public void SubscribeToAll(){} // RVA: 0x6DC8830
        public void UnsubscribeFromAll(){} // RVA: 0x6DC8900
        public void SubscribeTo(){} // RVA: 0x6DC8CE0 | overloaded x2
        public void UnsubscribeFrom(){} // RVA: 0x6DC9070 | overloaded x2
        public void RecordAction(){} // RVA: 0x6DC91F0
        public void Clear(){} // RVA: 0x6DC9400
        public void Finalize(){} // RVA: 0x6DC9450
        public void ToString(){} // RVA: 0x6DC9490
        public void Dispose(){} // RVA: 0x6DC9770
        public void DisposeInternal(){} // RVA: 0x6DC9790
        public void GetEnumerator(){} // RVA: 0x6DC9A40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6DC9B50
        public void HookOnActionChange(){} // RVA: 0x6DC9B60
        public void UnhookOnActionChange(){} // RVA: 0x6DC9D30
        public void OnActionChange(){} // RVA: 0x6DC9E50
        public void CloneActionStateBeforeBindingsChange(){} // RVA: 0x6DCA1E0
    }

    public class InputArrayExtensions
    {
        // ── Methods ──
        public void IndexOfReference(){} // RVA: 0x283FA0
        public void Contains(){} // RVA: 0x283FA0
        public void ContainsReference(){} // RVA: 0x283FA0
    }

    public class InternedString
    {
        // ── Methods ──
        public void get_length(){} // RVA: 0x6DCBE10
        public void .ctor(){} // RVA: 0x6DCBE20
        public void IsEmpty(){} // RVA: 0x34B6160
        public void ToLower(){} // RVA: 0x19689C0
        public void Equals(){} // RVA: 0x6DCC300 | overloaded x2
        public void CompareTo(){} // RVA: 0x6DCC310
        public void GetHashCode(){} // RVA: 0x6DCC3F0
        public void ToString(){} // RVA: 0x6DCC420
        public void op_Equality(){} // RVA: 0x6DCC8A0 | overloaded x3
        public void op_Inequality(){} // RVA: 0x6DCCAB0 | overloaded x3
        public void op_LessThan(){} // RVA: 0x6DCCCC0
        public void op_GreaterThan(){} // RVA: 0x6DCCDA0
        public void op_Implicit(){} // RVA: 0x6DCC420
    }

    public class JsonParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DCCE90
        public void Reset(){} // RVA: 0x6DCCF50
        public void ToString(){} // RVA: 0x6DCCF60
        public void NavigateToProperty(){} // RVA: 0x6DCD0B0
        public void CurrentPropertyHasValueEqualTo(){} // RVA: 0x6DCD5C0
        public void ParseToken(){} // RVA: 0x6DCD7D0
        public void ParseValue(){} // RVA: 0x6DCD890 | overloaded x2
        public void ParseStringValue(){} // RVA: 0x6DCD9B0
        public void ParseArrayValue(){} // RVA: 0x6DCDBF0
        public void ParseObjectValue(){} // RVA: 0x6DCDEF0
        public void ParseNumber(){} // RVA: 0x6DCE180
        public void ParseBooleanValue(){} // RVA: 0x6DCE720
        public void ParseNullValue(){} // RVA: 0x6DCE900
        public void SkipToValue(){} // RVA: 0x6DCE970
        public void SkipString(){} // RVA: 0x6DCE9E0
        public void SkipWhitespace(){} // RVA: 0x6DCEAB0
        public void get_isAtEnd(){} // RVA: 0x6DCEB50
    }

    public class MemoryHelpers
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x6DD0F80
        public void ComputeFollowingByteOffset(){} // RVA: 0x6DD1000
        public void WriteSingleBit(){} // RVA: 0x6DD1020
        public void ReadSingleBit(){} // RVA: 0x6DD1050
        public void MemCpyBitRegion(){} // RVA: 0x6DD1080
        public void MemCmpBitRegion(){} // RVA: 0x6DD1180
        public void MemSet(){} // RVA: 0x6DD1300
        public void MemCpyMasked(){} // RVA: 0x6DD13D0
        public void ReadMultipleBitsAsUInt(){} // RVA: 0x6DD14E0
        public void WriteUIntAsMultipleBits(){} // RVA: 0x6DD16B0
        public void ReadTwosComplementMultipleBitsAsInt(){} // RVA: 0x6DD18B0
        public void WriteIntAsTwosComplementMultipleBits(){} // RVA: 0x6DD18C0
        public void ReadExcessKMultipleBitsAsInt(){} // RVA: 0x6DD18D0
        public void WriteIntAsExcessKMultipleBits(){} // RVA: 0x6DD1900
        public void ReadMultipleBitsAsNormalizedUInt(){} // RVA: 0x6DD1930
        public void WriteNormalizedUIntAsMultipleBits(){} // RVA: 0x6DD19A0
        public void SetBitsInBuffer(){} // RVA: 0x6DD1A10
        public void Swap(){} // RVA: 0x24D50
        public void AlignNatural(){} // RVA: 0x6DD1CA0
    }

    public class MiscHelpers
    {
        // ── Methods ──
        public void GetValueOrDefault(){} // RVA: 0x283FA0
        public void EveryNth(){} // RVA: 0x1DEC0
        public void IndexOf(){} // RVA: 0x283FA0
    }

    public class NameAndParameters
    {
        public object _name;
        public object _shortCodeBtn;

        // ── Methods ──
        public void get_name(){} // RVA: 0x1AD4690
        public void set_name(){} // RVA: 0x100A2F0
        public void get_parameters(){} // RVA: 0x1F6F090
        public void set_parameters(){} // RVA: 0x1F6F0A0
        public void ToString(){} // RVA: 0x6DD1DE0
        public void ParseMultiple(){} // RVA: 0x6DD2470 | overloaded x2
        public void ParseName(){} // RVA: 0x6DD2700
        public void Parse(){} // RVA: 0x6DD2790
        public void ParseNameAndParameters(){} // RVA: 0x6DD2820
    }

    public class NamedValue
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x1AD4690
        public void set_name(){} // RVA: 0x100A2F0
        public void get_value(){} // RVA: 0x1F6F090
        public void set_value(){} // RVA: 0x1F74E00
        public void get_type(){} // RVA: 0x1EA9890
        public void ConvertTo(){} // RVA: 0x6DD2E30
        public void From(){} // RVA: 0x283FA0
        public void ToString(){} // RVA: 0x6DD2EC0
        public void Equals(){} // RVA: 0x6DD30D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6DD3170
        public void op_Equality(){} // RVA: 0x6DD3200
        public void op_Inequality(){} // RVA: 0x6DD3230
        public void ParseMultiple(){} // RVA: 0x6DD3260
        public void Parse(){} // RVA: 0x6DD3490
        public void ParseParameter(){} // RVA: 0x6DD34D0
        public void ApplyToObject(){} // RVA: 0x6DD3830
        public void ApplyAllToObject(){} // RVA: 0x283FA0
    }

    public class NumberHelpers
    {
        // ── Methods ──
        public void AlignToMultipleOf(){} // RVA: 0x6DD3B60 | overloaded x3
        public void Approximately(){} // RVA: 0x6DD3B80
        public void IntToNormalizedFloat(){} // RVA: 0x6DD3C50
        public void NormalizedFloatToInt(){} // RVA: 0x6DD3CA0
        public void UIntToNormalizedFloat(){} // RVA: 0x6DD3CF0
        public void NormalizedFloatToUInt(){} // RVA: 0x6DD3D40
        public void RemapUIntBitsToNormalizeFloatToUIntBits(){} // RVA: 0x6DD3DB0
    }

    public class Observable
    {
        // ── Methods ──
        public void Where(){} // RVA: 0xCEC0
        public void Select(){} // RVA: 0xCEC0
        public void SelectMany(){} // RVA: 0xCEC0
        public void Take(){} // RVA: 0x1BF70
        public void ForDevice(){} // RVA: 0xCE50 | overloaded x2
        public void CallOnce(){} // RVA: 0xCEC0
        public void Call(){} // RVA: 0xCEC0
    }

    public class Observer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DC60
        public void OnCompleted(){} // RVA: 0x24A50
        public void OnError(){} // RVA: 0x24B10
        public void OnNext(){} // RVA: 0x283FA0
    }

    public class OneOrMore`2
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0xD840
        public void get_Item(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x283FA0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class PredictiveParser
    {
        // ── Methods ──
        public void ExpectSingleChar(){} // RVA: 0x6DD4430
        public void ExpectInt(){} // RVA: 0x6DD4550
        public void ExpectString(){} // RVA: 0x6DD46B0
        public void AcceptSingleChar(){} // RVA: 0x6DD4940
        public void AcceptString(){} // RVA: 0x6DD4980
        public void AcceptInt(){} // RVA: 0x6DD4AF0
    }

    public class PrimitiveValue
    {
        // ── Methods ──
        public void get_valuePtr(){} // RVA: 0x6DD4B50
        public void get_type(){} // RVA: 0x19689B0
        public void get_isEmpty(){} // RVA: 0x62E1480
        public void .ctor(){} // RVA: 0x6DD4C90 | overloaded x12
        public void ConvertTo(){} // RVA: 0x6DD4CB0
        public void Equals(){} // RVA: 0x6DD5070 | overloaded x2
        public void op_Equality(){} // RVA: 0x6DD53A0
        public void op_Inequality(){} // RVA: 0x6DD5420
        public void GetHashCode(){} // RVA: 0x6DD54A0
        public void ToString(){} // RVA: 0x6DD6460 | overloaded x2
        public void FromString(){} // RVA: 0x6DD5940
        public void GetTypeCode(){} // RVA: 0x19689B0
        public void ToBoolean(){} // RVA: 0x6DD6130
        public void ToByte(){} // RVA: 0x6DD61F0
        public void ToChar(){} // RVA: 0x6DD6200
        public void ToDateTime(){} // RVA: 0x6DD6220
        public void ToDecimal(){} // RVA: 0x6DD6270
        public void ToDouble(){} // RVA: 0x6DD62B0
        public void ToInt16(){} // RVA: 0x6DD61F0
        public void ToInt32(){} // RVA: 0x6DD61F0
        public void ToInt64(){} // RVA: 0x6DD63B0
        public void ToSByte(){} // RVA: 0x6DD61F0
        public void ToSingle(){} // RVA: 0x6DD6440
        public void ToType(){} // RVA: 0x6DD6470
        public void ToUInt16(){} // RVA: 0x6DD64B0
        public void ToUInt32(){} // RVA: 0x6DD64B0
        public void ToUInt64(){} // RVA: 0x6DD64C0
        public void ToObject(){} // RVA: 0x6DD6560
        public void From(){} // RVA: 0x283FA0
        public void FromObject(){} // RVA: 0x6DD6860
        public void op_Implicit(){} // RVA: 0x6DD72A0 | overloaded x12
        public void FromBoolean(){} // RVA: 0x6DD7140
        public void FromChar(){} // RVA: 0x6DD7160
        public void FromByte(){} // RVA: 0x6DD7180
        public void FromSByte(){} // RVA: 0x6DD71A0
        public void FromInt16(){} // RVA: 0x6DD71C0
        public void FromUInt16(){} // RVA: 0x6DD71E0
        public void FromInt32(){} // RVA: 0x6DD7200
        public void FromUInt32(){} // RVA: 0x6DD7220
        public void FromInt64(){} // RVA: 0x6DD7240
        public void FromUInt64(){} // RVA: 0x6DD7260
        public void FromSingle(){} // RVA: 0x6DD7280
        public void FromDouble(){} // RVA: 0x6DD72A0
    }

    public class ReadOnlyArrayExtensions
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x283FA0
        public void ContainsReference(){} // RVA: 0x283FA0
        public void IndexOfReference(){} // RVA: 0x283FA0
        public void HaveEqualReferences(){} // RVA: 0x283FA0
    }

    public class ReadOnlyArray`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x2
        public void ToArray(){} // RVA: 0xCD60
        public void IndexOf(){} // RVA: 0x12590
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<TValue>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void op_Implicit(){} // RVA: 0x283FA0
        public void get_Count(){} // RVA: 0xD840
        public void get_Item(){} // RVA: 0x283FA0
    }

    public class SavedStructState`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2F090
        public void StaticDisposeCurrentState(){} // RVA: 0x24A50
        public void RestoreSavedState(){} // RVA: 0x24A50
    }

    public class SelectManyObservable`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DC60
        public void Subscribe(){} // RVA: 0xCE10
    }

    public class SpriteUtilities
    {
        // ── Methods ──
        public void CreateCircleSprite(){} // RVA: 0x6DD72C0
    }

    public class StringHelpers
    {
        // ── Methods ──
        public void Escape(){} // RVA: 0x6DD7680
        public void Unescape(){} // RVA: 0x6DD7830
        public void Contains(){} // RVA: 0x6DD7A00 | overloaded x2
        public void GetPlural(){} // RVA: 0x6DD7A40
        public void NicifyMemorySize(){} // RVA: 0x6DD7C80
        public void FromNicifiedMemorySize(){} // RVA: 0x6DD7E70
        public void CountOccurrences(){} // RVA: 0x6DD83E0
        public void Tokenize(){} // RVA: 0x6DD8470
        public void Split(){} // RVA: 0x6DD8520
        public void Join(){} // RVA: 0xCEC0 | overloaded x2
        public void MakeUniqueName(){} // RVA: 0x1D550
        public void CharacterSeparatedListsHaveAtLeastOneCommonElement(){} // RVA: 0x6DD8630
        public void ParseInt(){} // RVA: 0x6DD89F0
        public void WriteStringToBuffer(){} // RVA: 0x6DD8AA0 | overloaded x2
        public void ReadStringFromBuffer(){} // RVA: 0x6DD8D60 | overloaded x2
        public void IsPrintable(){} // RVA: 0x6DD8EA0
        public void WithAllWhitespaceStripped(){} // RVA: 0x6DD8F20
        public void InvariantEqualsIgnoreCase(){} // RVA: 0x6DD9040
        public void ExpandTemplateString(){} // RVA: 0x6DD9120
    }

    public class Substring
    {
        // ── Methods ──
        public void get_isEmpty(){} // RVA: 0x6DD9A20
        public void .ctor(){} // RVA: 0x6DD9AA0 | overloaded x3
        public void Equals(){} // RVA: 0x6DD9DA0 | overloaded x4
        public void CompareTo(){} // RVA: 0x6DDA090
        public void Compare(){} // RVA: 0x6DDA110
        public void StartsWith(){} // RVA: 0x6DDA160
        public void Substr(){} // RVA: 0x6DDA200
        public void ToString(){} // RVA: 0x6DDA230
        public void GetHashCode(){} // RVA: 0x6DDA290
        public void op_Equality(){} // RVA: 0x6DDA3D0 | overloaded x3
        public void op_Inequality(){} // RVA: 0x6DDA400 | overloaded x3
        public void op_Implicit(){} // RVA: 0x6DDA430
        public void get_length(){} // RVA: 0x1EA98B0
        public void get_index(){} // RVA: 0x1EA9890
        public void get_Item(){} // RVA: 0x6DDA4A0
    }

    public class TakeNObservable`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2BAA0
        public void Subscribe(){} // RVA: 0xCE10
    }

    public class TypeHelpers
    {
        // ── Methods ──
        public void As(){} // RVA: 0x283FA0
        public void IsInt(){} // RVA: 0x6DDA540
        public void GetValueType(){} // RVA: 0x6DDA590
        public void GetNiceTypeName(){} // RVA: 0x6DDA700
        public void GetGenericTypeArgumentFromHierarchy(){} // RVA: 0x6DDABC0
    }

    public class TypeTable
    {
        // ── Methods ──
        public void get_names(){} // RVA: 0x6DDB030
        public void get_internedNames(){} // RVA: 0x6DDB1D0
        public void Initialize(){} // RVA: 0x6DDB220
        public void FindNameForType(){} // RVA: 0x6DDB2D0
        public void AddTypeRegistration(){} // RVA: 0x6DDB530
        public void LookupTypeRegistration(){} // RVA: 0x6DDB6D0
    }

    public class Vector2MagnitudeComparer
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x6DCAF50
    }

    public class Vector3MagnitudeComparer
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x6DCAFB0
    }

    public class WhereObservable`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DC60
        public void Subscribe(){} // RVA: 0xCE10
    }

}