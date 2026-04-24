// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Utilities
// Classes: 36
// Methods: 410

namespace ThirdParty.Unity.UnityEngine.InputSystem.Utilities
{
    public class ArrayHelpers : Object
    {
        // ── Methods ──
        public void LengthSafe(){} // RVA: 0x7FFD4E079A40
        public void Clear(){} // RVA: 0x7FFD4E090C80 | overloaded x3
        public void EnsureCapacity(){} // RVA: 0x7FFD4E097FD0
        public void DuplicateWithCapacity(){} // RVA: 0x7FFD4E097FD0
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void ContainsReference(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void HaveDuplicateReferences(){} // RVA: 0x7FFD4E07CAC0
        public void HaveEqualElements(){} // RVA: 0x7FFD4E07D420
        public void IndexOf(){} // RVA: 0x7FFD4E083990 | overloaded x3
        public void IndexOfReference(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void IndexOfValue(){} // RVA: 0x7FFD4E2ADC40
        public void Resize(){} // RVA: 0x7FFD4E097EC0
        public void Append(){} // RVA: 0x7FFD4E07E730 | overloaded x2
        public void AppendToImmutable(){} // RVA: 0x7FFD4E07E730
        public void AppendWithCapacity(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void AppendListWithCapacity(){} // RVA: 0x7FFD4E2ADC40
        public void InsertAt(){} // RVA: 0x7FFD4E2ADC40
        public void InsertAtWithCapacity(){} // RVA: 0x7FFD4E2ADC40
        public void PutAtIfNotSet(){} // RVA: 0x7FFD4E090D10
        public void GrowBy(){} // RVA: 0x7FFD4E082120 | overloaded x2
        public void GrowWithCapacity(){} // RVA: 0x7FFD4E083990 | overloaded x2
        public void Join(){} // RVA: 0x7FFD4E2ADC40
        public void Merge(){} // RVA: 0x7FFD4E089600 | overloaded x2
        public void EraseAt(){} // RVA: 0x7FFD4E096370
        public void EraseAtWithCapacity(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Erase(){} // RVA: 0x7FFD4E2ADC40
        public void EraseAtByMovingTail(){} // RVA: 0x7FFD4E099C70
        public void Copy(){} // RVA: 0x7FFD4E078F80
        public void Clone(){} // RVA: 0x7FFD4E078F80
        public void Select(){} // RVA: 0x7FFD4E078FF0
        public void Swap(){} // RVA: 0x7FFD4E090C80
        public void MoveSlice(){} // RVA: 0x7FFD4E097FD0
        public void EraseSliceWithCapacity(){} // RVA: 0x7FFD4E09A460
        public void SwapElements(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    }

    public class CSharpCodeHelpers : Object
    {
        // ── Methods ──
        public void IsProperIdentifier(){} // RVA: 0x7FFD54983760
        public void IsEmptyOrProperIdentifier(){} // RVA: 0x7FFD54983850
        public void IsEmptyOrProperNamespaceName(){} // RVA: 0x7FFD54983950
        public void MakeIdentifier(){} // RVA: 0x7FFD54983A10
        public void MakeTypeName(){} // RVA: 0x7FFD54983C60
    }

    public class CallbackArray`1 : ValueType
    {
        public bool length; // 0x10
        public 2.and<ÎÌÍÏÏÌÍÏ> Item; // 0x18
        public 2.and<ÎÌÍÏÏÌÍÏ> m_CallbacksToAdd; // 0x30
        public 2.and<ÎÌÍÏÏÌÍÏ> m_CallbacksToRemove; // 0x48

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFD4E079960
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void AddCallback(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveCallback(){} // RVA: 0x7FFD4E2ADC40
        public void LockForChanges(){} // RVA: 0x7FFD4E090980
        public void UnlockForChanges(){} // RVA: 0x7FFD4E090980
    }

    public class DelegateHelpers : Object
    {
        // ── Methods ──
        public void InvokeCallbacksSafe(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void InvokeCallbacksSafe_AnyCallbackReturnsTrue(){} // RVA: 0x7FFD4E2ADC40
        public void InvokeCallbacksSafe_AndInvokeReturnedActions(){} // RVA: 0x7FFD4E2ADC40
        public void InvokeCallbacksSafe_AnyCallbackReturnsObject(){} // RVA: 0x7FFD4E2ADC40
    }

    public class DisplayStringFormatAttribute : Attribute
    {
        public string formatString; // 0x10

        // ── Methods ──
        public void get_formatString(){} // RVA: 0x7FFD4E35C380
        public void set_formatString(){} // RVA: 0x7FFD4E342E30
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class ExceptionHelpers : Object
    {
        // ── Methods ──
        public void IsExceptionIndicatingBugInCode(){} // RVA: 0x7FFD54983FF0
    }

    public class ForDeviceEventObservable : Object
    {
        public subkeyWritable<Device.ckingField> m_Source; // 0x10
        public ilAddress.ActionProperty m_Device; // 0x18
        public object m_DeviceType; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5498C5B0
        public void Subscribe(){} // RVA: 0x7FFD5498C6B0
    }

    public class FourCC : ValueType
    {
        public int m_Code; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54984120 | overloaded x3
        public void op_Implicit(){} // RVA: 0x7FFD50006C10 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD54984260
        public void Equals(){} // RVA: 0x7FFD549844C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
        public void op_Equality(){} // RVA: 0x7FFD5072E660
        public void op_Inequality(){} // RVA: 0x7FFD54984550
        public void FromInt32(){} // RVA: 0x7FFD50006C10
        public void ToInt32(){} // RVA: 0x7FFD50006C10
    }

    public class ISavedState
    {
        // ── Methods ──
        public void StaticDisposeCurrentState(){} // RVA: 0x7FFD4E090980
        public void RestoreSavedState(){} // RVA: 0x7FFD4E090980
    }

    public class InlinedArray`1 : ValueType
    {
        public int Capacity; // 0x10
        public ilAddress.hBindingMask<deltaleft.?> Item; // 0x18
        public ilAddress.hBindingMask<deltaleft.?>[] additionalValues; // 0x20

        // ── Methods ──
        public void get_Capacity(){} // RVA: 0x7FFD4E079960
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x3
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void ClearWithCapacity(){} // RVA: 0x7FFD4E090980
        public void Clone(){} // RVA: 0x7FFD4E2ADC40
        public void SetLength(){} // RVA: 0x7FFD4E090ED0
        public void ToArray(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void Append(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void AppendWithCapacity(){} // RVA: 0x7FFD4E2ADC40
        public void AssignWithCapacity(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveAtWithCapacity(){} // RVA: 0x7FFD4E090ED0
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void RemoveAtByMovingTailWithCapacity(){} // RVA: 0x7FFD4E090ED0
        public void RemoveByMovingTailWithCapacity(){} // RVA: 0x7FFD4E2ADC40
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void Merge(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class InputActionTrace : Object
    {
        public bool buffer; // 0x10
        public bool count; // 0x11
        public 2.and<ilAddress.s> m_SubscribedActions; // 0x18
        public 2.and<ilAddress.epAliveInterval> m_SubscribedActionMaps; // 0x30
        public Device.__BackingField m_EventBuffer; // 0x48
        public 2.and<ilAddress.icate> m_ActionMapStates; // 0x68
        public 2.and<ilAddress.icate> m_ActionMapStateClones; // 0x80
        public ileFullDirectoryInformation<et> m_CallbackDelegate; // 0x98
        public rectoryInformation<object,ilAddress.get_RequestedSubProtocols> m_ActionChangeDelegate; // 0xA0

        // ── Methods ──
        public void get_buffer(){} // RVA: 0x7FFD54980D60
        public void get_count(){} // RVA: 0x7FFD4E558C20
        public void .ctor(){} // RVA: 0x7FFD54980DF0 | overloaded x3
        public void SubscribeToAll(){} // RVA: 0x7FFD54980F80
        public void UnsubscribeFromAll(){} // RVA: 0x7FFD54981050
        public void SubscribeTo(){} // RVA: 0x7FFD54981430 | overloaded x2
        public void UnsubscribeFrom(){} // RVA: 0x7FFD549817C0 | overloaded x2
        public void RecordAction(){} // RVA: 0x7FFD54981940
        public void Clear(){} // RVA: 0x7FFD54981B50
        public void Finalize(){} // RVA: 0x7FFD54981BA0
        public void ToString(){} // RVA: 0x7FFD54981BE0
        public void Dispose(){} // RVA: 0x7FFD54981EC0
        public void DisposeInternal(){} // RVA: 0x7FFD54981EE0
        public void GetEnumerator(){} // RVA: 0x7FFD54982190
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD549822A0
        public void HookOnActionChange(){} // RVA: 0x7FFD549822B0
        public void UnhookOnActionChange(){} // RVA: 0x7FFD54982480
        public void OnActionChange(){} // RVA: 0x7FFD549825A0
        public void CloneActionStateBeforeBindingsChange(){} // RVA: 0x7FFD54982930
    }

    public class InputArrayExtensions : Object
    {
        // ── Methods ──
        public void IndexOfReference(){} // RVA: 0x7FFD4E2ADC40
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void ContainsReference(){} // RVA: 0x7FFD4E2ADC40
    }

    public class InternedString : ValueType
    {
        public string length; // 0x10
        public string m_StringLowerCase; // 0x18

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFD54984560
        public void .ctor(){} // RVA: 0x7FFD54984570
        public void IsEmpty(){} // RVA: 0x7FFD511DB670
        public void ToLower(){} // RVA: 0x7FFD4F840220
        public void Equals(){} // RVA: 0x7FFD54984A50 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFD54984A60
        public void GetHashCode(){} // RVA: 0x7FFD54984B40
        public void ToString(){} // RVA: 0x7FFD54984B70
        public void op_Equality(){} // RVA: 0x7FFD54984FF0 | overloaded x3
        public void op_Inequality(){} // RVA: 0x7FFD54985200 | overloaded x3
        public void op_LessThan(){} // RVA: 0x7FFD54985410
        public void op_GreaterThan(){} // RVA: 0x7FFD549854F0
        public void op_Implicit(){} // RVA: 0x7FFD54984B70
    }

    public class JsonParser : ValueType
    {
        public string isAtEnd; // 0x10
        public int m_Length; // 0x18
        public int m_Position; // 0x1C
        public bool m_MatchAnyElementInArray; // 0x20
        public bool m_DryRun; // 0x21

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD549855E0
        public void Reset(){} // RVA: 0x7FFD549856A0
        public void ToString(){} // RVA: 0x7FFD549856B0
        public void NavigateToProperty(){} // RVA: 0x7FFD54985800
        public void CurrentPropertyHasValueEqualTo(){} // RVA: 0x7FFD54985D10
        public void ParseToken(){} // RVA: 0x7FFD54985F20
        public void ParseValue(){} // RVA: 0x7FFD54985FE0 | overloaded x2
        public void ParseStringValue(){} // RVA: 0x7FFD54986100
        public void ParseArrayValue(){} // RVA: 0x7FFD54986340
        public void ParseObjectValue(){} // RVA: 0x7FFD54986640
        public void ParseNumber(){} // RVA: 0x7FFD549868D0
        public void ParseBooleanValue(){} // RVA: 0x7FFD54986E70
        public void ParseNullValue(){} // RVA: 0x7FFD54987050
        public void SkipToValue(){} // RVA: 0x7FFD549870C0
        public void SkipString(){} // RVA: 0x7FFD54987130
        public void SkipWhitespace(){} // RVA: 0x7FFD54987200
        public void get_isAtEnd(){} // RVA: 0x7FFD549872A0
    }

    public class MemoryHelpers : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFD549896D0
        public void ComputeFollowingByteOffset(){} // RVA: 0x7FFD54989750
        public void WriteSingleBit(){} // RVA: 0x7FFD54989770
        public void ReadSingleBit(){} // RVA: 0x7FFD549897A0
        public void MemCpyBitRegion(){} // RVA: 0x7FFD549897D0
        public void MemCmpBitRegion(){} // RVA: 0x7FFD549898D0
        public void MemSet(){} // RVA: 0x7FFD54989A50
        public void MemCpyMasked(){} // RVA: 0x7FFD54989B20
        public void ReadMultipleBitsAsUInt(){} // RVA: 0x7FFD54989C30
        public void WriteUIntAsMultipleBits(){} // RVA: 0x7FFD54989E00
        public void ReadTwosComplementMultipleBitsAsInt(){} // RVA: 0x7FFD5498A000
        public void WriteIntAsTwosComplementMultipleBits(){} // RVA: 0x7FFD5498A010
        public void ReadExcessKMultipleBitsAsInt(){} // RVA: 0x7FFD5498A020
        public void WriteIntAsExcessKMultipleBits(){} // RVA: 0x7FFD5498A050
        public void ReadMultipleBitsAsNormalizedUInt(){} // RVA: 0x7FFD5498A080
        public void WriteNormalizedUIntAsMultipleBits(){} // RVA: 0x7FFD5498A0F0
        public void SetBitsInBuffer(){} // RVA: 0x7FFD5498A160
        public void Swap(){} // RVA: 0x7FFD4E090C80
        public void AlignNatural(){} // RVA: 0x7FFD5498A3F0
    }

    public class MiscHelpers : Object
    {
        // ── Methods ──
        public void GetValueOrDefault(){} // RVA: 0x7FFD4E2ADC40
        public void EveryNth(){} // RVA: 0x7FFD4E089F10
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NameAndParameters : ValueType
    {
        public string name; // 0x10
        public 2.ntReadPos<2.sOrphanedPrimaryTouch> parameters; // 0x18

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4EEF9F60
        public void set_name(){} // RVA: 0x7FFD4ECFFE40
        public void get_parameters(){} // RVA: 0x7FFD4FEB27D0
        public void set_parameters(){} // RVA: 0x7FFD4FEB27E0
        public void ToString(){} // RVA: 0x7FFD5498A530
        public void ParseMultiple(){} // RVA: 0x7FFD5498ABC0 | overloaded x2
        public void ParseName(){} // RVA: 0x7FFD5498AE50
        public void Parse(){} // RVA: 0x7FFD5498AEE0
        public void ParseNameAndParameters(){} // RVA: 0x7FFD5498AF70
    }

    public class NamedValue : ValueType
    {
        public string name;
        public string value; // 0x10
        public 2.me type; // 0x18

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4EEF9F60
        public void set_name(){} // RVA: 0x7FFD4ECFFE40
        public void get_value(){} // RVA: 0x7FFD4FEB27D0
        public void set_value(){} // RVA: 0x7FFD4FEB8120
        public void get_type(){} // RVA: 0x7FFD4FDE7500
        public void ConvertTo(){} // RVA: 0x7FFD5498B580
        public void From(){} // RVA: 0x7FFD4E2ADC40
        public void ToString(){} // RVA: 0x7FFD5498B610
        public void Equals(){} // RVA: 0x7FFD5498B820 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD5498B8C0
        public void op_Equality(){} // RVA: 0x7FFD5498B950
        public void op_Inequality(){} // RVA: 0x7FFD5498B980
        public void ParseMultiple(){} // RVA: 0x7FFD5498B9B0
        public void Parse(){} // RVA: 0x7FFD5498BBE0
        public void ParseParameter(){} // RVA: 0x7FFD5498BC20
        public void ApplyToObject(){} // RVA: 0x7FFD5498BF80
        public void ApplyAllToObject(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NumberHelpers : Object
    {
        // ── Methods ──
        public void AlignToMultipleOf(){} // RVA: 0x7FFD5498C2B0 | overloaded x3
        public void Approximately(){} // RVA: 0x7FFD5498C2D0
        public void IntToNormalizedFloat(){} // RVA: 0x7FFD5498C3A0
        public void NormalizedFloatToInt(){} // RVA: 0x7FFD5498C3F0
        public void UIntToNormalizedFloat(){} // RVA: 0x7FFD5498C440
        public void NormalizedFloatToUInt(){} // RVA: 0x7FFD5498C490
        public void RemapUIntBitsToNormalizeFloatToUIntBits(){} // RVA: 0x7FFD5498C500
    }

    public class Observable : Object
    {
        // ── Methods ──
        public void Where(){} // RVA: 0x7FFD4E078FF0
        public void Select(){} // RVA: 0x7FFD4E078FF0
        public void SelectMany(){} // RVA: 0x7FFD4E078FF0
        public void Take(){} // RVA: 0x7FFD4E088090
        public void ForDevice(){} // RVA: 0x7FFD4E078F80 | overloaded x2
        public void CallOnce(){} // RVA: 0x7FFD4E078FF0
        public void Call(){} // RVA: 0x7FFD4E078FF0
    }

    public class Observer`1 : Object
    {
        public ileFullDirectoryInformation<T1717602096> m_OnNext;
        public ÎÌÍÏÏÌÍÏ m_OnCompleted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void OnCompleted(){} // RVA: 0x7FFD4E090980
        public void OnError(){} // RVA: 0x7FFD4E090A40
        public void OnNext(){} // RVA: 0x7FFD4E2ADC40
    }

    public class OneOrMore`2 : ValueType
    {
        public bool Count;
        public T1717602272 Item;
        public T1717602288 m_Multiple;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class PredictiveParser : ValueType
    {
        public int m_Position; // 0x10

        // ── Methods ──
        public void ExpectSingleChar(){} // RVA: 0x7FFD5498CB80
        public void ExpectInt(){} // RVA: 0x7FFD5498CCA0
        public void ExpectString(){} // RVA: 0x7FFD5498CE00
        public void AcceptSingleChar(){} // RVA: 0x7FFD5498D090
        public void AcceptString(){} // RVA: 0x7FFD5498D0D0
        public void AcceptInt(){} // RVA: 0x7FFD5498D240
    }

    public class PrimitiveValue : ValueType
    {
        public t_AllowMultiple valuePtr; // 0x10
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
        public void get_valuePtr(){} // RVA: 0x7FFD5498D2A0
        public void get_type(){} // RVA: 0x7FFD4F840210
        public void get_isEmpty(){} // RVA: 0x7FFD53E98820
        public void .ctor(){} // RVA: 0x7FFD5498D3E0 | overloaded x12
        public void ConvertTo(){} // RVA: 0x7FFD5498D400
        public void Equals(){} // RVA: 0x7FFD5498D7C0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD5498DAF0
        public void op_Inequality(){} // RVA: 0x7FFD5498DB70
        public void GetHashCode(){} // RVA: 0x7FFD5498DBF0
        public void ToString(){} // RVA: 0x7FFD5498EBB0 | overloaded x2
        public void FromString(){} // RVA: 0x7FFD5498E090
        public void GetTypeCode(){} // RVA: 0x7FFD4F840210
        public void ToBoolean(){} // RVA: 0x7FFD5498E880
        public void ToByte(){} // RVA: 0x7FFD5498E940
        public void ToChar(){} // RVA: 0x7FFD5498E950
        public void ToDateTime(){} // RVA: 0x7FFD5498E970
        public void ToDecimal(){} // RVA: 0x7FFD5498E9C0
        public void ToDouble(){} // RVA: 0x7FFD5498EA00
        public void ToInt16(){} // RVA: 0x7FFD5498E940
        public void ToInt32(){} // RVA: 0x7FFD5498E940
        public void ToInt64(){} // RVA: 0x7FFD5498EB00
        public void ToSByte(){} // RVA: 0x7FFD5498E940
        public void ToSingle(){} // RVA: 0x7FFD5498EB90
        public void ToType(){} // RVA: 0x7FFD5498EBC0
        public void ToUInt16(){} // RVA: 0x7FFD5498EC00
        public void ToUInt32(){} // RVA: 0x7FFD5498EC00
        public void ToUInt64(){} // RVA: 0x7FFD5498EC10
        public void ToObject(){} // RVA: 0x7FFD5498ECB0
        public void From(){} // RVA: 0x7FFD4E2ADC40
        public void FromObject(){} // RVA: 0x7FFD5498EFB0
        public void op_Implicit(){} // RVA: 0x7FFD5498F9F0 | overloaded x12
        public void FromBoolean(){} // RVA: 0x7FFD5498F890
        public void FromChar(){} // RVA: 0x7FFD5498F8B0
        public void FromByte(){} // RVA: 0x7FFD5498F8D0
        public void FromSByte(){} // RVA: 0x7FFD5498F8F0
        public void FromInt16(){} // RVA: 0x7FFD5498F910
        public void FromUInt16(){} // RVA: 0x7FFD5498F930
        public void FromInt32(){} // RVA: 0x7FFD5498F950
        public void FromUInt32(){} // RVA: 0x7FFD5498F970
        public void FromInt64(){} // RVA: 0x7FFD5498F990
        public void FromUInt64(){} // RVA: 0x7FFD5498F9B0
        public void FromSingle(){} // RVA: 0x7FFD5498F9D0
        public void FromDouble(){} // RVA: 0x7FFD5498F9F0
    }

    public class ReadOnlyArrayExtensions : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void ContainsReference(){} // RVA: 0x7FFD4E2ADC40
        public void IndexOfReference(){} // RVA: 0x7FFD4E2ADC40
        public void HaveEqualReferences(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ReadOnlyArray`1 : ValueType
    {
        public object Count;
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFD4E078E90
        public void IndexOf(){} // RVA: 0x7FFD4E07E6B0
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<TValue>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
    }

    public class SavedStructState`1 : Object
    {
        public T1717602432 m_State;
        public servers<T1717602432> m_RestoreAction;
        public ÎÌÍÏÏÌÍÏ m_StaticDisposeCurrentState;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09AF60
        public void StaticDisposeCurrentState(){} // RVA: 0x7FFD4E090980
        public void RestoreSavedState(){} // RVA: 0x7FFD4E090980
    }

    public class SelectManyObservable`2 : Object
    {
        public subkeyWritable<T1717602144> m_Source;
        public n<T1717602144,URA.bbrevEraNames<T1717602160>> m_Filter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void Subscribe(){} // RVA: 0x7FFD4E078F40
    }

    public class SpriteUtilities : Object
    {
        // ── Methods ──
        public void CreateCircleSprite(){} // RVA: 0x7FFD5498FA10
    }

    public class StringHelpers : Object
    {
        // ── Methods ──
        public void Escape(){} // RVA: 0x7FFD5498FDD0
        public void Unescape(){} // RVA: 0x7FFD5498FF80
        public void Contains(){} // RVA: 0x7FFD54990150 | overloaded x2
        public void GetPlural(){} // RVA: 0x7FFD54990190
        public void NicifyMemorySize(){} // RVA: 0x7FFD549903D0
        public void FromNicifiedMemorySize(){} // RVA: 0x7FFD549905C0
        public void CountOccurrences(){} // RVA: 0x7FFD54990B30
        public void Tokenize(){} // RVA: 0x7FFD54990BC0
        public void Split(){} // RVA: 0x7FFD54990C70
        public void Join(){} // RVA: 0x7FFD4E078FF0 | overloaded x2
        public void MakeUniqueName(){} // RVA: 0x7FFD4E089600
        public void CharacterSeparatedListsHaveAtLeastOneCommonElement(){} // RVA: 0x7FFD54990D80
        public void ParseInt(){} // RVA: 0x7FFD54991140
        public void WriteStringToBuffer(){} // RVA: 0x7FFD549911F0 | overloaded x2
        public void ReadStringFromBuffer(){} // RVA: 0x7FFD549914B0 | overloaded x2
        public void IsPrintable(){} // RVA: 0x7FFD549915F0
        public void WithAllWhitespaceStripped(){} // RVA: 0x7FFD54991670
        public void InvariantEqualsIgnoreCase(){} // RVA: 0x7FFD54991790
        public void ExpandTemplateString(){} // RVA: 0x7FFD54991870
    }

    public class Substring : ValueType
    {
        public string isEmpty; // 0x10
        public int length; // 0x18
        public int index; // 0x1C

        // ── Methods ──
        public void get_isEmpty(){} // RVA: 0x7FFD54992170
        public void .ctor(){} // RVA: 0x7FFD549921F0 | overloaded x3
        public void Equals(){} // RVA: 0x7FFD549924F0 | overloaded x4
        public void CompareTo(){} // RVA: 0x7FFD549927E0
        public void Compare(){} // RVA: 0x7FFD54992860
        public void StartsWith(){} // RVA: 0x7FFD549928B0
        public void Substr(){} // RVA: 0x7FFD54992950
        public void ToString(){} // RVA: 0x7FFD54992980
        public void GetHashCode(){} // RVA: 0x7FFD549929E0
        public void op_Equality(){} // RVA: 0x7FFD54992B20 | overloaded x3
        public void op_Inequality(){} // RVA: 0x7FFD54992B50 | overloaded x3
        public void op_Implicit(){} // RVA: 0x7FFD54992B80
        public void get_length(){} // RVA: 0x7FFD4FDE7520
        public void get_index(){} // RVA: 0x7FFD4FDE7500
        public void get_Item(){} // RVA: 0x7FFD54992BF0
    }

    public class TakeNObservable`1 : Object
    {
        public subkeyWritable<T1717602192> m_Source;
        public int m_Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E097970
        public void Subscribe(){} // RVA: 0x7FFD4E078F40
    }

    public class TypeHelpers : Object
    {
        // ── Methods ──
        public void As(){} // RVA: 0x7FFD4E2ADC40
        public void IsInt(){} // RVA: 0x7FFD54992C90
        public void GetValueType(){} // RVA: 0x7FFD54992CE0
        public void GetNiceTypeName(){} // RVA: 0x7FFD54992E50
        public void GetGenericTypeArgumentFromHierarchy(){} // RVA: 0x7FFD54993310
    }

    public class TypeTable : ValueType
    {
        public URA.DateTime<2.uestResetCommand,?> names; // 0x10

        // ── Methods ──
        public void get_names(){} // RVA: 0x7FFD54993780
        public void get_internedNames(){} // RVA: 0x7FFD54993920
        public void Initialize(){} // RVA: 0x7FFD54993970
        public void FindNameForType(){} // RVA: 0x7FFD54993A20
        public void AddTypeRegistration(){} // RVA: 0x7FFD54993C80
        public void LookupTypeRegistration(){} // RVA: 0x7FFD54993E20
    }

    public class Vector2MagnitudeComparer : ValueType
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFD549836A0
    }

    public class WhereObservable`1 : Object
    {
        public subkeyWritable<T1717602224> m_Source;
        public n<T1717602224,bool> m_Predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void Subscribe(){} // RVA: 0x7FFD4E078F40
    }

}