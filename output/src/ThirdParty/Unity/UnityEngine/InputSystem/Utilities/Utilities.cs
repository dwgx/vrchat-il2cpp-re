// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Utilities
// Classes: 37
// Methods: 411

namespace ThirdParty.Unity.UnityEngine.InputSystem.Utilities
{
    public class ArrayHelpers : Object
    {
        // ── Methods ──
        public void LengthSafe(){} // RVA: 0x7FFAC2C59A40
        public void Clear(){} // RVA: 0x7FFAC2C70C80 | overloaded x3
        public void EnsureCapacity(){} // RVA: 0x7FFAC2C77FD0
        public void DuplicateWithCapacity(){} // RVA: 0x7FFAC2C77FD0
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void ContainsReference(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void HaveDuplicateReferences(){} // RVA: 0x7FFAC2C5CAC0
        public void HaveEqualElements(){} // RVA: 0x7FFAC2C5D420
        public void IndexOf(){} // RVA: 0x7FFAC2C63990 | overloaded x3
        public void IndexOfReference(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void IndexOfValue(){} // RVA: 0x7FFAC2E8DC40
        public void Resize(){} // RVA: 0x7FFAC2C77EC0
        public void Append(){} // RVA: 0x7FFAC2C5E730 | overloaded x2
        public void AppendToImmutable(){} // RVA: 0x7FFAC2C5E730
        public void AppendWithCapacity(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void AppendListWithCapacity(){} // RVA: 0x7FFAC2E8DC40
        public void InsertAt(){} // RVA: 0x7FFAC2E8DC40
        public void InsertAtWithCapacity(){} // RVA: 0x7FFAC2E8DC40
        public void PutAtIfNotSet(){} // RVA: 0x7FFAC2C70D10
        public void GrowBy(){} // RVA: 0x7FFAC2C62120 | overloaded x2
        public void GrowWithCapacity(){} // RVA: 0x7FFAC2C63990 | overloaded x2
        public void Join(){} // RVA: 0x7FFAC2E8DC40
        public void Merge(){} // RVA: 0x7FFAC2C69600 | overloaded x2
        public void EraseAt(){} // RVA: 0x7FFAC2C76370
        public void EraseAtWithCapacity(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Erase(){} // RVA: 0x7FFAC2E8DC40
        public void EraseAtByMovingTail(){} // RVA: 0x7FFAC2C79C70
        public void Copy(){} // RVA: 0x7FFAC2C58F80
        public void Clone(){} // RVA: 0x7FFAC2C58F80
        public void Select(){} // RVA: 0x7FFAC2C58FF0
        public void Swap(){} // RVA: 0x7FFAC2C70C80
        public void MoveSlice(){} // RVA: 0x7FFAC2C77FD0
        public void EraseSliceWithCapacity(){} // RVA: 0x7FFAC2C7A460
        public void SwapElements(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    }

    public class CSharpCodeHelpers : Object
    {
        // ── Methods ──
        public void IsProperIdentifier(){} // RVA: 0x7FFAC9563760
        public void IsEmptyOrProperIdentifier(){} // RVA: 0x7FFAC9563850
        public void IsEmptyOrProperNamespaceName(){} // RVA: 0x7FFAC9563950
        public void MakeIdentifier(){} // RVA: 0x7FFAC9563A10
        public void MakeTypeName(){} // RVA: 0x7FFAC9563C60
    }

    public class CallbackArray`1 : ValueType
    {
        public bool length;
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<T> Item;
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<T> m_CallbacksToAdd;
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<T> m_CallbacksToRemove;

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFAC2C59960
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void AddCallback(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveCallback(){} // RVA: 0x7FFAC2E8DC40
        public void LockForChanges(){} // RVA: 0x7FFAC2C70980
        public void UnlockForChanges(){} // RVA: 0x7FFAC2C70980
    }

    public class DelegateHelpers : Object
    {
        // ── Methods ──
        public void InvokeCallbacksSafe(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void InvokeCallbacksSafe_AnyCallbackReturnsTrue(){} // RVA: 0x7FFAC2E8DC40
        public void InvokeCallbacksSafe_AndInvokeReturnedActions(){} // RVA: 0x7FFAC2E8DC40
        public void InvokeCallbacksSafe_AnyCallbackReturnsObject(){} // RVA: 0x7FFAC2E8DC40
    }

    public class DisplayStringFormatAttribute : Attribute
    {
        public string formatString; // 0x10

        // ── Methods ──
        public void get_formatString(){} // RVA: 0x7FFAC2F3C380
        public void set_formatString(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class ExceptionHelpers : Object
    {
        // ── Methods ──
        public void IsExceptionIndicatingBugInCode(){} // RVA: 0x7FFAC9563FF0
    }

    public class ForDeviceEventObservable : Object
    {
        public System.IObservable`1<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_Source; // 0x10
        public UnityEngine.InputSystem.InputDevice m_Device; // 0x18
        public System.Type m_DeviceType; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC956C5B0
        public void Subscribe(){} // RVA: 0x7FFAC956C6B0
    }

    public class FourCC : ValueType
    {
        public int m_Code; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9564120 | overloaded x3
        public void op_Implicit(){} // RVA: 0x7FFAC4BE6C10 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC9564260
        public void Equals(){} // RVA: 0x7FFAC95644C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void op_Equality(){} // RVA: 0x7FFAC530E660
        public void op_Inequality(){} // RVA: 0x7FFAC9564550
        public void FromInt32(){} // RVA: 0x7FFAC4BE6C10
        public void ToInt32(){} // RVA: 0x7FFAC4BE6C10
    }

    public class ISavedState
    {
        // ── Methods ──
        public void StaticDisposeCurrentState(){} // RVA: 0x7FFAC2C70980
        public void RestoreSavedState(){} // RVA: 0x7FFAC2C70980
    }

    public class InlinedArray`1 : ValueType
    {
        public int Capacity;
        public T Item;
        public T[] additionalValues;

        // ── Methods ──
        public void get_Capacity(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x3
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void ClearWithCapacity(){} // RVA: 0x7FFAC2C70980
        public void Clone(){} // RVA: 0x7FFAC2E8DC40
        public void SetLength(){} // RVA: 0x7FFAC2C70ED0
        public void ToArray(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void Append(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void AppendWithCapacity(){} // RVA: 0x7FFAC2E8DC40
        public void AssignWithCapacity(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveAtWithCapacity(){} // RVA: 0x7FFAC2C70ED0
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void RemoveAtByMovingTailWithCapacity(){} // RVA: 0x7FFAC2C70ED0
        public void RemoveByMovingTailWithCapacity(){} // RVA: 0x7FFAC2E8DC40
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void Merge(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class InputActionTrace : Object
    {
        public bool buffer; // 0x10
        public bool count; // 0x11
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.InputAction> m_SubscribedActions; // 0x18
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.InputActionMap> m_SubscribedActionMaps; // 0x30
        public UnityEngine.InputSystem.LowLevel.InputEventBuffer m_EventBuffer; // 0x48
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.InputActionState> m_ActionMapStates; // 0x68
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.InputActionState> m_ActionMapStateClones; // 0x80
        public System.Action`1<CallbackContext> m_CallbackDelegate; // 0x98
        public System.Action`2<object,0x6B1457B0> m_ActionChangeDelegate; // 0xA0

        // ── Methods ──
        public void get_buffer(){} // RVA: 0x7FFAC9560D60
        public void get_count(){} // RVA: 0x7FFAC3138C20
        public void .ctor(){} // RVA: 0x7FFAC9560DF0 | overloaded x3
        public void SubscribeToAll(){} // RVA: 0x7FFAC9560F80
        public void UnsubscribeFromAll(){} // RVA: 0x7FFAC9561050
        public void SubscribeTo(){} // RVA: 0x7FFAC9561430 | overloaded x2
        public void UnsubscribeFrom(){} // RVA: 0x7FFAC95617C0 | overloaded x2
        public void RecordAction(){} // RVA: 0x7FFAC9561940
        public void Clear(){} // RVA: 0x7FFAC9561B50
        public void Finalize(){} // RVA: 0x7FFAC9561BA0
        public void ToString(){} // RVA: 0x7FFAC9561BE0
        public void Dispose(){} // RVA: 0x7FFAC9561EC0
        public void DisposeInternal(){} // RVA: 0x7FFAC9561EE0
        public void GetEnumerator(){} // RVA: 0x7FFAC9562190
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC95622A0
        public void HookOnActionChange(){} // RVA: 0x7FFAC95622B0
        public void UnhookOnActionChange(){} // RVA: 0x7FFAC9562480
        public void OnActionChange(){} // RVA: 0x7FFAC95625A0
        public void CloneActionStateBeforeBindingsChange(){} // RVA: 0x7FFAC9562930
    }

    public class InputArrayExtensions : Object
    {
        // ── Methods ──
        public void IndexOfReference(){} // RVA: 0x7FFAC2E8DC40
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void ContainsReference(){} // RVA: 0x7FFAC2E8DC40
    }

    public class InternedString : ValueType
    {
        public string length; // 0x10
        public string m_StringLowerCase; // 0x18

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFAC9564560
        public void .ctor(){} // RVA: 0x7FFAC9564570
        public void IsEmpty(){} // RVA: 0x7FFAC5DBB670
        public void ToLower(){} // RVA: 0x7FFAC4420220
        public void Equals(){} // RVA: 0x7FFAC9564A50 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC9564A60
        public void GetHashCode(){} // RVA: 0x7FFAC9564B40
        public void ToString(){} // RVA: 0x7FFAC9564B70
        public void op_Equality(){} // RVA: 0x7FFAC9564FF0 | overloaded x3
        public void op_Inequality(){} // RVA: 0x7FFAC9565200 | overloaded x3
        public void op_LessThan(){} // RVA: 0x7FFAC9565410
        public void op_GreaterThan(){} // RVA: 0x7FFAC95654F0
        public void op_Implicit(){} // RVA: 0x7FFAC9564B70
    }

    public class JsonParser : ValueType
    {
        public string isAtEnd; // 0x10
        public int m_Length; // 0x18
        public int m_Position; // 0x1C
        public bool m_MatchAnyElementInArray; // 0x20
        public bool m_DryRun; // 0x21

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC95655E0
        public void Reset(){} // RVA: 0x7FFAC95656A0
        public void ToString(){} // RVA: 0x7FFAC95656B0
        public void NavigateToProperty(){} // RVA: 0x7FFAC9565800
        public void CurrentPropertyHasValueEqualTo(){} // RVA: 0x7FFAC9565D10
        public void ParseToken(){} // RVA: 0x7FFAC9565F20
        public void ParseValue(){} // RVA: 0x7FFAC9565FE0 | overloaded x2
        public void ParseStringValue(){} // RVA: 0x7FFAC9566100
        public void ParseArrayValue(){} // RVA: 0x7FFAC9566340
        public void ParseObjectValue(){} // RVA: 0x7FFAC9566640
        public void ParseNumber(){} // RVA: 0x7FFAC95668D0
        public void ParseBooleanValue(){} // RVA: 0x7FFAC9566E70
        public void ParseNullValue(){} // RVA: 0x7FFAC9567050
        public void SkipToValue(){} // RVA: 0x7FFAC95670C0
        public void SkipString(){} // RVA: 0x7FFAC9567130
        public void SkipWhitespace(){} // RVA: 0x7FFAC9567200
        public void get_isAtEnd(){} // RVA: 0x7FFAC95672A0
    }

    public class MemoryHelpers : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAC95696D0
        public void ComputeFollowingByteOffset(){} // RVA: 0x7FFAC9569750
        public void WriteSingleBit(){} // RVA: 0x7FFAC9569770
        public void ReadSingleBit(){} // RVA: 0x7FFAC95697A0
        public void MemCpyBitRegion(){} // RVA: 0x7FFAC95697D0
        public void MemCmpBitRegion(){} // RVA: 0x7FFAC95698D0
        public void MemSet(){} // RVA: 0x7FFAC9569A50
        public void MemCpyMasked(){} // RVA: 0x7FFAC9569B20
        public void ReadMultipleBitsAsUInt(){} // RVA: 0x7FFAC9569C30
        public void WriteUIntAsMultipleBits(){} // RVA: 0x7FFAC9569E00
        public void ReadTwosComplementMultipleBitsAsInt(){} // RVA: 0x7FFAC956A000
        public void WriteIntAsTwosComplementMultipleBits(){} // RVA: 0x7FFAC956A010
        public void ReadExcessKMultipleBitsAsInt(){} // RVA: 0x7FFAC956A020
        public void WriteIntAsExcessKMultipleBits(){} // RVA: 0x7FFAC956A050
        public void ReadMultipleBitsAsNormalizedUInt(){} // RVA: 0x7FFAC956A080
        public void WriteNormalizedUIntAsMultipleBits(){} // RVA: 0x7FFAC956A0F0
        public void SetBitsInBuffer(){} // RVA: 0x7FFAC956A160
        public void Swap(){} // RVA: 0x7FFAC2C70C80
        public void AlignNatural(){} // RVA: 0x7FFAC956A3F0
    }

    public class MiscHelpers : Object
    {
        // ── Methods ──
        public void GetValueOrDefault(){} // RVA: 0x7FFAC2E8DC40
        public void EveryNth(){} // RVA: 0x7FFAC2C69F10
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
    }

    public class NameAndParameters : ValueType
    {
        public string name; // 0x10
        public UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.NamedValue> parameters; // 0x18

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC3AD9F60
        public void set_name(){} // RVA: 0x7FFAC38DFE40
        public void get_parameters(){} // RVA: 0x7FFAC4A927D0
        public void set_parameters(){} // RVA: 0x7FFAC4A927E0
        public void ToString(){} // RVA: 0x7FFAC956A530
        public void ParseMultiple(){} // RVA: 0x7FFAC956ABC0 | overloaded x2
        public void ParseName(){} // RVA: 0x7FFAC956AE50
        public void Parse(){} // RVA: 0x7FFAC956AEE0
        public void ParseNameAndParameters(){} // RVA: 0x7FFAC956AF70
    }

    public class NamedValue : ValueType
    {
        public string name;
        public string value; // 0x10
        public UnityEngine.InputSystem.Utilities.PrimitiveValue type; // 0x18

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC3AD9F60
        public void set_name(){} // RVA: 0x7FFAC38DFE40
        public void get_value(){} // RVA: 0x7FFAC4A927D0
        public void set_value(){} // RVA: 0x7FFAC4A98120
        public void get_type(){} // RVA: 0x7FFAC49C7500
        public void ConvertTo(){} // RVA: 0x7FFAC956B580
        public void From(){} // RVA: 0x7FFAC2E8DC40
        public void ToString(){} // RVA: 0x7FFAC956B610
        public void Equals(){} // RVA: 0x7FFAC956B820 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC956B8C0
        public void op_Equality(){} // RVA: 0x7FFAC956B950
        public void op_Inequality(){} // RVA: 0x7FFAC956B980
        public void ParseMultiple(){} // RVA: 0x7FFAC956B9B0
        public void Parse(){} // RVA: 0x7FFAC956BBE0
        public void ParseParameter(){} // RVA: 0x7FFAC956BC20
        public void ApplyToObject(){} // RVA: 0x7FFAC956BF80
        public void ApplyAllToObject(){} // RVA: 0x7FFAC2E8DC40
    }

    public class NumberHelpers : Object
    {
        // ── Methods ──
        public void AlignToMultipleOf(){} // RVA: 0x7FFAC956C2B0 | overloaded x3
        public void Approximately(){} // RVA: 0x7FFAC956C2D0
        public void IntToNormalizedFloat(){} // RVA: 0x7FFAC956C3A0
        public void NormalizedFloatToInt(){} // RVA: 0x7FFAC956C3F0
        public void UIntToNormalizedFloat(){} // RVA: 0x7FFAC956C440
        public void NormalizedFloatToUInt(){} // RVA: 0x7FFAC956C490
        public void RemapUIntBitsToNormalizeFloatToUIntBits(){} // RVA: 0x7FFAC956C500
    }

    public class Observable : Object
    {
        // ── Methods ──
        public void Where(){} // RVA: 0x7FFAC2C58FF0
        public void Select(){} // RVA: 0x7FFAC2C58FF0
        public void SelectMany(){} // RVA: 0x7FFAC2C58FF0
        public void Take(){} // RVA: 0x7FFAC2C68090
        public void ForDevice(){} // RVA: 0x7FFAC2C58F80 | overloaded x2
        public void CallOnce(){} // RVA: 0x7FFAC2C58FF0
        public void Call(){} // RVA: 0x7FFAC2C58FF0
    }

    public class Observer`1 : Object
    {
        public System.Action`1<T> m_OnNext;
        public System.Action m_OnCompleted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void OnCompleted(){} // RVA: 0x7FFAC2C70980
        public void OnError(){} // RVA: 0x7FFAC2C70A40
        public void OnNext(){} // RVA: 0x7FFAC2E8DC40
    }

    public class OneOrMore`2 : ValueType
    {
        public bool Count;
        public U Item;
        public T m_Multiple;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class PredictiveParser : ValueType
    {
        public int m_Position; // 0x10

        // ── Methods ──
        public void ExpectSingleChar(){} // RVA: 0x7FFAC956CB80
        public void ExpectInt(){} // RVA: 0x7FFAC956CCA0
        public void ExpectString(){} // RVA: 0x7FFAC956CE00
        public void AcceptSingleChar(){} // RVA: 0x7FFAC956D090
        public void AcceptString(){} // RVA: 0x7FFAC956D0D0
        public void AcceptInt(){} // RVA: 0x7FFAC956D240
    }

    public class PrimitiveValue : ValueType
    {
        public 0x6B0C1808 valuePtr; // 0x10
        public bool type; // 0x14
        public char isEmpty; // 0x14
        public byte m_ByteValue; // 0x14
        public sbyte m_SByteValue; // 0x14
        public short m_ShortValue; // 0x14
        public ushort m_UShortValue; // 0x14
        public int m_IntValue; // 0x14
        public uint m_UIntValue; // 0x14
        public long m_LongValue; // 0x14
        public ulong m_ULongValue; // 0x14
        public float m_FloatValue; // 0x14
        public double m_DoubleValue; // 0x14

        // ── Methods ──
        public void get_valuePtr(){} // RVA: 0x7FFAC956D2A0
        public void get_type(){} // RVA: 0x7FFAC4420210
        public void get_isEmpty(){} // RVA: 0x7FFAC8A78820
        public void .ctor(){} // RVA: 0x7FFAC956D3E0 | overloaded x12
        public void ConvertTo(){} // RVA: 0x7FFAC956D400
        public void Equals(){} // RVA: 0x7FFAC956D7C0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC956DAF0
        public void op_Inequality(){} // RVA: 0x7FFAC956DB70
        public void GetHashCode(){} // RVA: 0x7FFAC956DBF0
        public void ToString(){} // RVA: 0x7FFAC956EBB0 | overloaded x2
        public void FromString(){} // RVA: 0x7FFAC956E090
        public void GetTypeCode(){} // RVA: 0x7FFAC4420210
        public void ToBoolean(){} // RVA: 0x7FFAC956E880
        public void ToByte(){} // RVA: 0x7FFAC956E940
        public void ToChar(){} // RVA: 0x7FFAC956E950
        public void ToDateTime(){} // RVA: 0x7FFAC956E970
        public void ToDecimal(){} // RVA: 0x7FFAC956E9C0
        public void ToDouble(){} // RVA: 0x7FFAC956EA00
        public void ToInt16(){} // RVA: 0x7FFAC956E940
        public void ToInt32(){} // RVA: 0x7FFAC956E940
        public void ToInt64(){} // RVA: 0x7FFAC956EB00
        public void ToSByte(){} // RVA: 0x7FFAC956E940
        public void ToSingle(){} // RVA: 0x7FFAC956EB90
        public void ToType(){} // RVA: 0x7FFAC956EBC0
        public void ToUInt16(){} // RVA: 0x7FFAC956EC00
        public void ToUInt32(){} // RVA: 0x7FFAC956EC00
        public void ToUInt64(){} // RVA: 0x7FFAC956EC10
        public void ToObject(){} // RVA: 0x7FFAC956ECB0
        public void From(){} // RVA: 0x7FFAC2E8DC40
        public void FromObject(){} // RVA: 0x7FFAC956EFB0
        public void op_Implicit(){} // RVA: 0x7FFAC956F9F0 | overloaded x12
        public void FromBoolean(){} // RVA: 0x7FFAC956F890
        public void FromChar(){} // RVA: 0x7FFAC956F8B0
        public void FromByte(){} // RVA: 0x7FFAC956F8D0
        public void FromSByte(){} // RVA: 0x7FFAC956F8F0
        public void FromInt16(){} // RVA: 0x7FFAC956F910
        public void FromUInt16(){} // RVA: 0x7FFAC956F930
        public void FromInt32(){} // RVA: 0x7FFAC956F950
        public void FromUInt32(){} // RVA: 0x7FFAC956F970
        public void FromInt64(){} // RVA: 0x7FFAC956F990
        public void FromUInt64(){} // RVA: 0x7FFAC956F9B0
        public void FromSingle(){} // RVA: 0x7FFAC956F9D0
        public void FromDouble(){} // RVA: 0x7FFAC956F9F0
    }

    public class ReadOnlyArrayExtensions : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void ContainsReference(){} // RVA: 0x7FFAC2E8DC40
        public void IndexOfReference(){} // RVA: 0x7FFAC2E8DC40
        public void HaveEqualReferences(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ReadOnlyArray`1 : ValueType
    {
        public T[] Count;
        public int Item;
        public int m_Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFAC2C58E90
        public void IndexOf(){} // RVA: 0x7FFAC2C5E6B0
        public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IEnumerable<TValue>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
    }

    public class SavedStructState`1 : Object
    {
        public T m_State;
        public TypedRestore<T> m_RestoreAction;
        public System.Action m_StaticDisposeCurrentState;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
        public void StaticDisposeCurrentState(){} // RVA: 0x7FFAC2C70980
        public void RestoreSavedState(){} // RVA: 0x7FFAC2C70980
    }

    public class SelectManyObservable`2 : Object
    {
        public System.IObservable`1<U> m_Source;
        public System.Func`2<U,System.Collections.Generic.IEnumerable`1<T>> m_Filter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void Subscribe(){} // RVA: 0x7FFAC2C58F40
    }

    public class SpriteUtilities : Object
    {
        // ── Methods ──
        public void CreateCircleSprite(){} // RVA: 0x7FFAC956FA10
    }

    public class StringHelpers : Object
    {
        // ── Methods ──
        public void Escape(){} // RVA: 0x7FFAC956FDD0
        public void Unescape(){} // RVA: 0x7FFAC956FF80
        public void Contains(){} // RVA: 0x7FFAC9570150 | overloaded x2
        public void GetPlural(){} // RVA: 0x7FFAC9570190
        public void NicifyMemorySize(){} // RVA: 0x7FFAC95703D0
        public void FromNicifiedMemorySize(){} // RVA: 0x7FFAC95705C0
        public void CountOccurrences(){} // RVA: 0x7FFAC9570B30
        public void Tokenize(){} // RVA: 0x7FFAC9570BC0
        public void Split(){} // RVA: 0x7FFAC9570C70
        public void Join(){} // RVA: 0x7FFAC2C58FF0 | overloaded x2
        public void MakeUniqueName(){} // RVA: 0x7FFAC2C69600
        public void CharacterSeparatedListsHaveAtLeastOneCommonElement(){} // RVA: 0x7FFAC9570D80
        public void ParseInt(){} // RVA: 0x7FFAC9571140
        public void WriteStringToBuffer(){} // RVA: 0x7FFAC95711F0 | overloaded x2
        public void ReadStringFromBuffer(){} // RVA: 0x7FFAC95714B0 | overloaded x2
        public void IsPrintable(){} // RVA: 0x7FFAC95715F0
        public void WithAllWhitespaceStripped(){} // RVA: 0x7FFAC9571670
        public void InvariantEqualsIgnoreCase(){} // RVA: 0x7FFAC9571790
        public void ExpandTemplateString(){} // RVA: 0x7FFAC9571870
    }

    public class Substring : ValueType
    {
        public string isEmpty; // 0x10
        public int length; // 0x18
        public int index; // 0x1C

        // ── Methods ──
        public void get_isEmpty(){} // RVA: 0x7FFAC9572170
        public void .ctor(){} // RVA: 0x7FFAC95721F0 | overloaded x3
        public void Equals(){} // RVA: 0x7FFAC95724F0 | overloaded x4
        public void CompareTo(){} // RVA: 0x7FFAC95727E0
        public void Compare(){} // RVA: 0x7FFAC9572860
        public void StartsWith(){} // RVA: 0x7FFAC95728B0
        public void Substr(){} // RVA: 0x7FFAC9572950
        public void ToString(){} // RVA: 0x7FFAC9572980
        public void GetHashCode(){} // RVA: 0x7FFAC95729E0
        public void op_Equality(){} // RVA: 0x7FFAC9572B20 | overloaded x3
        public void op_Inequality(){} // RVA: 0x7FFAC9572B50 | overloaded x3
        public void op_Implicit(){} // RVA: 0x7FFAC9572B80
        public void get_length(){} // RVA: 0x7FFAC49C7520
        public void get_index(){} // RVA: 0x7FFAC49C7500
        public void get_Item(){} // RVA: 0x7FFAC9572BF0
    }

    public class TakeNObservable`1 : Object
    {
        public System.IObservable`1<T> m_Source;
        public int m_Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C77970
        public void Subscribe(){} // RVA: 0x7FFAC2C58F40
    }

    public class TypeHelpers : Object
    {
        // ── Methods ──
        public void As(){} // RVA: 0x7FFAC2E8DC40
        public void IsInt(){} // RVA: 0x7FFAC9572C90
        public void GetValueType(){} // RVA: 0x7FFAC9572CE0
        public void GetNiceTypeName(){} // RVA: 0x7FFAC9572E50
        public void GetGenericTypeArgumentFromHierarchy(){} // RVA: 0x7FFAC9573310
    }

    public class TypeTable : ValueType
    {
        public System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,System.Type> names; // 0x10

        // ── Methods ──
        public void get_names(){} // RVA: 0x7FFAC9573780
        public void get_internedNames(){} // RVA: 0x7FFAC9573920
        public void Initialize(){} // RVA: 0x7FFAC9573970
        public void FindNameForType(){} // RVA: 0x7FFAC9573A20
        public void AddTypeRegistration(){} // RVA: 0x7FFAC9573C80
        public void LookupTypeRegistration(){} // RVA: 0x7FFAC9573E20
    }

    public class Vector2MagnitudeComparer : ValueType
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAC95636A0
    }

    public class Vector3MagnitudeComparer : ValueType
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAC9563700
    }

    public class WhereObservable`1 : Object
    {
        public System.IObservable`1<T> m_Source;
        public System.Func`2<T,bool> m_Predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void Subscribe(){} // RVA: 0x7FFAC2C58F40
    }

}