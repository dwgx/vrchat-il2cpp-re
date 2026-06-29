// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Dynamic.Utils
// Classes: 13
// Methods: 140

namespace ThirdParty.DotNet.System.Dynamic.Utils
{
    public class CacheDict`2 : Object
    {
        public object _mask;
        public object _entries;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8944F0
        public void AlignSize(){} // RVA: 0x883700
        public void TryGetValue(){} // RVA: 0xA94080
        public void Add(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
    }

    public class CollectionExtensions : Object
    {
        // ── Methods ──
        public void AddFirst(){} // RVA: 0xA94080
        public void AddLast(){} // RVA: 0xA94080
        public void RemoveFirst(){} // RVA: 0x87C5C0
        public void RemoveLast(){} // RVA: 0x87C5C0
        public void ToReadOnly(){} // RVA: 0x87C5C0
    }

    public class ContractUtils : Object
    {
        // ── Methods ──
        public void get_Unreachable(){} // RVA: 0x70D96B0
        public void Requires(){} // RVA: 0x70D9720
        public void RequiresNotNull(){} // RVA: 0x70D97C0
        public void RequiresNotEmpty(){} // RVA: 0x8945C0
        public void RequiresNotNullItems(){} // RVA: 0x8945C0
        public void GetParamName(){} // RVA: 0x70D9840
        public void RequiresArrayRange(){} // RVA: 0x89BF00
    }

    public class EmptyReadOnlyCollection`1 : Object
    {
        public object Instance;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class ExpressionUtils : Object
    {
        // ── Methods ──
        public void ReturnReadOnly(){} // RVA: 0x70D9BA0
        public void ReturnObject(){} // RVA: 0xA94080
        public void ValidateArgumentTypes(){} // RVA: 0x70D9E50
        public void ValidateArgumentCount(){} // RVA: 0x70DAAC0
        public void ValidateOneArgument(){} // RVA: 0x70DA330
        public void RequiresCanRead(){} // RVA: 0x70DA610
        public void TryQuote(){} // RVA: 0x70DA830
        public void GetParametersForValidation(){} // RVA: 0x70DAA40
        public void SameElements(){} // RVA: 0x87D880
        public void SameElementsInCollection(){} // RVA: 0x87D880
    }

    public class ExpressionVisitorUtils : Object
    {
        // ── Methods ──
        public void VisitBlockExpressions(){} // RVA: 0x70DAB40
        public void VisitParameters(){} // RVA: 0x70DAD30
        public void VisitArguments(){} // RVA: 0x70DAF50
    }

    public class ListArgumentProvider : ListProvider`1
    {
        public object _provider;
        public object _arg0;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70DB170
        public void get_First(){} // RVA: 0xB465B0
        public void get_ElementCount(){} // RVA: 0x70DB270
        public void GetElement(){} // RVA: 0x70DB2C0
    }

    public class ListParameterProvider : ListProvider`1
    {
        public object _provider;
        public object _arg0;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70DB320
        public void get_First(){} // RVA: 0xB465B0
        public void get_ElementCount(){} // RVA: 0x70DB420
        public void GetElement(){} // RVA: 0x70DB470
    }

    public class ListProvider`1 : Object
    {
        // ── Methods ──
        public void get_First(){} // RVA: 0xA94080
        public void get_ElementCount(){} // RVA: 0x87C130
        public void GetElement(){} // RVA: 0xA94080
        public void IndexOf(){} // RVA: 0xA94080
        public void Insert(){} // RVA: 0xA94080
        public void RemoveAt(){} // RVA: 0x8944F0
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
        public void Add(){} // RVA: 0xA94080
        public void Clear(){} // RVA: 0x894290
        public void Contains(){} // RVA: 0xA94080
        public void CopyTo(){} // RVA: 0x899290
        public void get_Count(){} // RVA: 0x87C130
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void Remove(){} // RVA: 0xA94080
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x894290
    }

    public class ListProvider`1 : Object
    {
        // ── Methods ──
        public void get_First(){} // RVA: 0x87C0A0
        public void get_ElementCount(){} // RVA: 0x87C130
        public void GetElement(){} // RVA: 0x87C160
        public void IndexOf(){} // RVA: 0x42E7EF0
        public void Insert(){} // RVA: 0x3DCE970
        public void RemoveAt(){} // RVA: 0x3DCE950
        public void get_Item(){} // RVA: 0x42E7FA0
        public void set_Item(){} // RVA: 0x3DCE970
        public void Add(){} // RVA: 0x3DCE950
        public void Clear(){} // RVA: 0x42E7FD0
        public void Contains(){} // RVA: 0x42E7FF0
        public void CopyTo(){} // RVA: 0x42E80A0
        public void get_Count(){} // RVA: 0x42E82B0
        public void get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void Remove(){} // RVA: 0x3DCE950
        public void GetEnumerator(){} // RVA: 0x42E82D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42E8360
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ListProvider`1 : Object
    {
        // ── Methods ──
        public void get_First(){} // RVA: 0x87C0A0
        public void get_ElementCount(){} // RVA: 0x87C130
        public void GetElement(){} // RVA: 0x87C160
        public void IndexOf(){} // RVA: 0x42E7EF0
        public void Insert(){} // RVA: 0x3DCE970
        public void RemoveAt(){} // RVA: 0x3DCE950
        public void get_Item(){} // RVA: 0x42E7FA0
        public void set_Item(){} // RVA: 0x3DCE970
        public void Add(){} // RVA: 0x3DCE950
        public void Clear(){} // RVA: 0x42E7FD0
        public void Contains(){} // RVA: 0x42E7FF0
        public void CopyTo(){} // RVA: 0x42E80A0
        public void get_Count(){} // RVA: 0x42E82B0
        public void get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void Remove(){} // RVA: 0x3DCE950
        public void GetEnumerator(){} // RVA: 0x42E82D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42E8360
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TypeExtensions : Object
    {
        public object s_paramInfoCache;

        // ── Methods ──
        public void GetAnyStaticMethodValidated(){} // RVA: 0x70DB4D0
        public void MatchesArgumentTypes(){} // RVA: 0x70DB6B0
        public void GetReturnType(){} // RVA: 0x70DB820
        public void GetTypeCode(){} // RVA: 0x70DB8D0
        public void GetParametersCached(){} // RVA: 0x70DB930
        public void .cctor(){} // RVA: 0x70DBAF0
    }

    public class TypeUtils : Object
    {
        public object s_arrayAssignableInterfaces;

        // ── Methods ──
        public void GetNonNullableType(){} // RVA: 0x70DBBD0
        public void GetNullableType(){} // RVA: 0x70DBC70
        public void IsNullableType(){} // RVA: 0x70DBE00
        public void IsNullableOrReferenceType(){} // RVA: 0x70DBEF0
        public void IsBool(){} // RVA: 0x70DBF70
        public void IsNumeric(){} // RVA: 0x70DC0B0
        public void IsInteger(){} // RVA: 0x70DC220
        public void IsArithmetic(){} // RVA: 0x70DC390
        public void IsUnsignedInt(){} // RVA: 0x70DC500
        public void IsIntegerOrBool(){} // RVA: 0x70DC680
        public void IsNumericOrBool(){} // RVA: 0x70DC800
        public void IsValidInstanceType(){} // RVA: 0x70DC880
        public void HasIdentityPrimitiveOrNullableConversionTo(){} // RVA: 0x70DCC20
        public void HasReferenceConversionTo(){} // RVA: 0x70DCEF0
        public void StrictHasReferenceConversionTo(){} // RVA: 0x70DD150
        public void HasArrayToInterfaceConversion(){} // RVA: 0x70DD5F0
        public void HasInterfaceToArrayConversion(){} // RVA: 0x70DD800
        public void IsCovariant(){} // RVA: 0x70DDA10
        public void IsContravariant(){} // RVA: 0x70DDA40
        public void IsInvariant(){} // RVA: 0x70DDA70
        public void IsDelegate(){} // RVA: 0x70DDAA0
        public void IsLegalExplicitVariantDelegateConversion(){} // RVA: 0x70DDB50
        public void IsConvertible(){} // RVA: 0x70DDEF0
        public void HasReferenceEquality(){} // RVA: 0x70DE060
        public void HasBuiltInEqualityOperator(){} // RVA: 0x70DE170
        public void IsImplicitlyConvertibleTo(){} // RVA: 0x70DE3D0
        public void GetUserDefinedCoercionMethod(){} // RVA: 0x70DE750
        public void FindConversionOperator(){} // RVA: 0x70DEAA0
        public void IsImplicitNumericConversion(){} // RVA: 0x70DED50
        public void IsImplicitReferenceConversion(){} // RVA: 0x706F980
        public void IsImplicitBoxingConversion(){} // RVA: 0x70DEF70
        public void IsImplicitNullableConversion(){} // RVA: 0x70DF0F0
        public void FindGenericType(){} // RVA: 0x70DF1A0
        public void GetBooleanOperator(){} // RVA: 0x70DF4F0
        public void GetNonRefType(){} // RVA: 0x70DF6B0
        public void AreEquivalent(){} // RVA: 0x70DF700
        public void AreReferenceAssignable(){} // RVA: 0x70DF760
        public void IsSameOrSubclass(){} // RVA: 0x70DF860
        public void ValidateType(){} // RVA: 0x70DFB80
        public void GetInvokeMethod(){} // RVA: 0x70DFC90
        public void .cctor(){} // RVA: 0x70DFD60
    }

}