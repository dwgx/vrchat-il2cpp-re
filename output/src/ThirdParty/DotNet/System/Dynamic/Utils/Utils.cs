// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Dynamic.Utils
// Classes: 11
// Methods: 112

namespace ThirdParty.DotNet.System.Dynamic.Utils
{
    public class CacheDict`2 : Object
    {
        public int _mask;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void AlignSize(){} // RVA: 0x7FFE80E35560
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void Add(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
    }

    public class CollectionExtensions : Object
    {
        // ── Methods ──
        public void AddFirst(){} // RVA: 0x7FFE810A1420
        public void AddLast(){} // RVA: 0x7FFE810A1420
        public void RemoveFirst(){} // RVA: 0x7FFE80E2E3D0
        public void RemoveLast(){} // RVA: 0x7FFE80E2E3D0
        public void ToReadOnly(){} // RVA: 0x7FFE80E2E3D0
    }

    public class ContractUtils : Object
    {
        // ── Methods ──
        public void get_Unreachable(){} // RVA: 0x7FFE871ADC80
        public void Requires(){} // RVA: 0x7FFE871ADCF0
        public void RequiresNotNull(){} // RVA: 0x7FFE871ADD90 | overloaded x2
        public void RequiresNotEmpty(){} // RVA: 0x7FFE80E462E0
        public void RequiresNotNullItems(){} // RVA: 0x7FFE80E462E0
        public void GetParamName(){} // RVA: 0x7FFE871ADE10
        public void RequiresArrayRange(){} // RVA: 0x7FFE80E4DAC0
    }

    public class EmptyReadOnlyCollection`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ExpressionUtils : Object
    {
        // ── Methods ──
        public void ReturnReadOnly(){} // RVA: 0x7FFE871AE1C0 | overloaded x3
        public void ReturnObject(){} // RVA: 0x7FFE810A1420
        public void ValidateArgumentTypes(){} // RVA: 0x7FFE871AE4B0
        public void ValidateArgumentCount(){} // RVA: 0x7FFE871AF0D0 | overloaded x2
        public void ValidateOneArgument(){} // RVA: 0x7FFE871AE980
        public void RequiresCanRead(){} // RVA: 0x7FFE871AEC60 | overloaded x2
        public void TryQuote(){} // RVA: 0x7FFE871AEE90
        public void GetParametersForValidation(){} // RVA: 0x7FFE871AF050
        public void SameElements(){} // RVA: 0x7FFE80E2F7A0 | overloaded x2
        public void SameElementsInCollection(){} // RVA: 0x7FFE80E2F7A0
    }

    public class ExpressionVisitorUtils : Object
    {
        // ── Methods ──
        public void VisitBlockExpressions(){} // RVA: 0x7FFE871AF150
        public void VisitParameters(){} // RVA: 0x7FFE871AF340
        public void VisitArguments(){} // RVA: 0x7FFE871AF560
    }

    public class ListArgumentProvider : ListProvider`1
    {
        public System.Linq.Expressions.IArgumentProvider _provider; // 0x10
        public System.Linq.Expressions.Expression _arg0; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871AF780
        public void get_First(){} // RVA: 0x7FFE810FE7C0
        public void get_ElementCount(){} // RVA: 0x7FFE871AF880
        public void GetElement(){} // RVA: 0x7FFE871AF8D0
    }

    public class ListParameterProvider : ListProvider`1
    {
        public System.Linq.Expressions.IParameterProvider _provider; // 0x10
        public System.Linq.Expressions.ParameterExpression _arg0; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871AF930
        public void get_First(){} // RVA: 0x7FFE810FE7C0
        public void get_ElementCount(){} // RVA: 0x7FFE871AFA30
        public void GetElement(){} // RVA: 0x7FFE871AFA80
    }

    public class ListProvider`1 : Object
    {
        // ── Methods ──
        public void get_First(){} // RVA: 0x7FFE810A1420
        public void get_ElementCount(){} // RVA: 0x7FFE80E2EDB0
        public void GetElement(){} // RVA: 0x7FFE810A1420
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void Insert(){} // RVA: 0x7FFE810A1420
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class TypeExtensions : Object
    {
        // ── Methods ──
        public void GetAnyStaticMethodValidated(){} // RVA: 0x7FFE871AFAE0
        public void MatchesArgumentTypes(){} // RVA: 0x7FFE871AFC80
        public void GetReturnType(){} // RVA: 0x7FFE871AFDC0
        public void GetTypeCode(){} // RVA: 0x7FFE871AFE70
        public void GetParametersCached(){} // RVA: 0x7FFE871AFF10
        public void .cctor(){} // RVA: 0x7FFE871B00C0
    }

    public class TypeUtils : Object
    {
        // ── Methods ──
        public void GetNonNullableType(){} // RVA: 0x7FFE871B01A0
        public void GetNullableType(){} // RVA: 0x7FFE871B0240
        public void IsNullableType(){} // RVA: 0x7FFE871B03B0
        public void IsNullableOrReferenceType(){} // RVA: 0x7FFE871B0470
        public void IsBool(){} // RVA: 0x7FFE871B04F0
        public void IsNumeric(){} // RVA: 0x7FFE871B0670
        public void IsInteger(){} // RVA: 0x7FFE871B0790
        public void IsArithmetic(){} // RVA: 0x7FFE871B08B0
        public void IsUnsignedInt(){} // RVA: 0x7FFE871B09D0
        public void IsIntegerOrBool(){} // RVA: 0x7FFE871B0B10
        public void IsNumericOrBool(){} // RVA: 0x7FFE871B0C40
        public void IsValidInstanceType(){} // RVA: 0x7FFE871B0CC0
        public void HasIdentityPrimitiveOrNullableConversionTo(){} // RVA: 0x7FFE871B10A0
        public void HasReferenceConversionTo(){} // RVA: 0x7FFE871B13F0
        public void StrictHasReferenceConversionTo(){} // RVA: 0x7FFE871B1670
        public void HasArrayToInterfaceConversion(){} // RVA: 0x7FFE871B1B20
        public void HasInterfaceToArrayConversion(){} // RVA: 0x7FFE871B1D50
        public void IsCovariant(){} // RVA: 0x7FFE871B1F80
        public void IsContravariant(){} // RVA: 0x7FFE871B1FB0
        public void IsInvariant(){} // RVA: 0x7FFE871B1FE0
        public void IsDelegate(){} // RVA: 0x7FFE871B2010
        public void IsLegalExplicitVariantDelegateConversion(){} // RVA: 0x7FFE871B20F0
        public void IsConvertible(){} // RVA: 0x7FFE871B24B0
        public void HasReferenceEquality(){} // RVA: 0x7FFE871B25D0
        public void HasBuiltInEqualityOperator(){} // RVA: 0x7FFE871B26E0
        public void IsImplicitlyConvertibleTo(){} // RVA: 0x7FFE871B2960
        public void GetUserDefinedCoercionMethod(){} // RVA: 0x7FFE871B2D90
        public void FindConversionOperator(){} // RVA: 0x7FFE871B30E0
        public void IsImplicitNumericConversion(){} // RVA: 0x7FFE871B3330
        public void IsImplicitReferenceConversion(){} // RVA: 0x7FFE87140AF0
        public void IsImplicitBoxingConversion(){} // RVA: 0x7FFE871B34B0
        public void IsImplicitNullableConversion(){} // RVA: 0x7FFE871B3610
        public void FindGenericType(){} // RVA: 0x7FFE871B36C0
        public void GetBooleanOperator(){} // RVA: 0x7FFE871B3A20
        public void GetNonRefType(){} // RVA: 0x7FFE871B3C00
        public void AreEquivalent(){} // RVA: 0x7FFE871B3C50
        public void AreReferenceAssignable(){} // RVA: 0x7FFE871B3CD0
        public void IsSameOrSubclass(){} // RVA: 0x7FFE871B3DF0
        public void ValidateType(){} // RVA: 0x7FFE871B4130 | overloaded x3
        public void GetInvokeMethod(){} // RVA: 0x7FFE871B4290
        public void .cctor(){} // RVA: 0x7FFE871B4360
    }

}