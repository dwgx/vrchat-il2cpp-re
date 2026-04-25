// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Dynamic.Utils
// Classes: 11
// Methods: 112

namespace ThirdParty.DotNet.System.Dynamic.Utils
{
    public class CacheDict`2 : Object
    {
        public int Item;
        public Entry<U,T>[] _entries;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0
        public void AlignSize(){} // RVA: 0x7FFAC2C60110
        public void TryGetValue(){} // RVA: 0x7FFAC2E8DC40
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
    }

    public class CollectionExtensions : Object
    {
        // ── Methods ──
        public void AddFirst(){} // RVA: 0x7FFAC2E8DC40
        public void AddLast(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveFirst(){} // RVA: 0x7FFAC2C58F80
        public void RemoveLast(){} // RVA: 0x7FFAC2C58F80
        public void ToReadOnly(){} // RVA: 0x7FFAC2C58F80
    }

    public class ContractUtils : Object
    {
        public object Unreachable;

        // ── Methods ──
        public void get_Unreachable(){} // RVA: 0x7FFAC8E05850
        public void Requires(){} // RVA: 0x7FFAC8E058C0
        public void RequiresNotNull(){} // RVA: 0x7FFAC8E05960 | overloaded x2
        public void RequiresNotEmpty(){} // RVA: 0x7FFAC2C70C80
        public void RequiresNotNullItems(){} // RVA: 0x7FFAC2C70C80
        public void GetParamName(){} // RVA: 0x7FFAC8E059E0
        public void RequiresArrayRange(){} // RVA: 0x7FFAC2C783C0
    }

    public class EmptyReadOnlyCollection`1 : Object
    {
        public System.Collections.ObjectModel.ReadOnlyCollection`1<T> Instance;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class ExpressionUtils : Object
    {
        // ── Methods ──
        public void ReturnReadOnly(){} // RVA: 0x7FFAC8E05D90 | overloaded x3
        public void ReturnObject(){} // RVA: 0x7FFAC2E8DC40
        public void ValidateArgumentTypes(){} // RVA: 0x7FFAC8E06080
        public void ValidateArgumentCount(){} // RVA: 0x7FFAC8E06CA0 | overloaded x2
        public void ValidateOneArgument(){} // RVA: 0x7FFAC8E06550
        public void RequiresCanRead(){} // RVA: 0x7FFAC8E06830 | overloaded x2
        public void TryQuote(){} // RVA: 0x7FFAC8E06A60
        public void GetParametersForValidation(){} // RVA: 0x7FFAC8E06C20
        public void SameElements(){} // RVA: 0x7FFAC2C5A350 | overloaded x2
        public void SameElementsInCollection(){} // RVA: 0x7FFAC2C5A350
    }

    public class ExpressionVisitorUtils : Object
    {
        // ── Methods ──
        public void VisitBlockExpressions(){} // RVA: 0x7FFAC8E06D20
        public void VisitParameters(){} // RVA: 0x7FFAC8E06F10
        public void VisitArguments(){} // RVA: 0x7FFAC8E07130
    }

    public class ListArgumentProvider : ListProvider`1
    {
        public System.Linq.Expressions.IArgumentProvider First; // 0x10
        public System.Linq.Expressions.Expression ElementCount; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E07350
        public void get_First(){} // RVA: 0x7FFAC2F247C0
        public void get_ElementCount(){} // RVA: 0x7FFAC8E07450
        public void GetElement(){} // RVA: 0x7FFAC8E074A0
    }

    public class ListParameterProvider : ListProvider`1
    {
        public System.Linq.Expressions.IParameterProvider First; // 0x10
        public System.Linq.Expressions.ParameterExpression ElementCount; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E07500
        public void get_First(){} // RVA: 0x7FFAC2F247C0
        public void get_ElementCount(){} // RVA: 0x7FFAC8E07600
        public void GetElement(){} // RVA: 0x7FFAC8E07650
    }

    public class ListProvider`1 : Object
    {
        public object First;
        public object ElementCount;
        public object Item;
        public object Count;
        public object IsReadOnly;

        // ── Methods ──
        public void get_First(){} // RVA: 0x7FFAC2E8DC40
        public void get_ElementCount(){} // RVA: 0x7FFAC2C59960
        public void GetElement(){} // RVA: 0x7FFAC2E8DC40
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void Insert(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class TypeExtensions : Object
    {
        public System.Dynamic.Utils.CacheDict`2<System.Reflection.MethodBase,System.Reflection.ParameterInfo[]> s_paramInfoCache;

        // ── Methods ──
        public void GetAnyStaticMethodValidated(){} // RVA: 0x7FFAC8E076B0
        public void MatchesArgumentTypes(){} // RVA: 0x7FFAC8E07850
        public void GetReturnType(){} // RVA: 0x7FFAC8E07990
        public void GetTypeCode(){} // RVA: 0x7FFAC8E07A40
        public void GetParametersCached(){} // RVA: 0x7FFAC8E07AE0
        public void .cctor(){} // RVA: 0x7FFAC8E07C90
    }

    public class TypeUtils : Object
    {
        public System.Type[] s_arrayAssignableInterfaces;

        // ── Methods ──
        public void GetNonNullableType(){} // RVA: 0x7FFAC8E07D70
        public void GetNullableType(){} // RVA: 0x7FFAC8E07E10
        public void IsNullableType(){} // RVA: 0x7FFAC8E07F80
        public void IsNullableOrReferenceType(){} // RVA: 0x7FFAC8E08040
        public void IsBool(){} // RVA: 0x7FFAC8E080C0
        public void IsNumeric(){} // RVA: 0x7FFAC8E08240
        public void IsInteger(){} // RVA: 0x7FFAC8E08360
        public void IsArithmetic(){} // RVA: 0x7FFAC8E08480
        public void IsUnsignedInt(){} // RVA: 0x7FFAC8E085A0
        public void IsIntegerOrBool(){} // RVA: 0x7FFAC8E086E0
        public void IsNumericOrBool(){} // RVA: 0x7FFAC8E08810
        public void IsValidInstanceType(){} // RVA: 0x7FFAC8E08890
        public void HasIdentityPrimitiveOrNullableConversionTo(){} // RVA: 0x7FFAC8E08C70
        public void HasReferenceConversionTo(){} // RVA: 0x7FFAC8E08FC0
        public void StrictHasReferenceConversionTo(){} // RVA: 0x7FFAC8E09240
        public void HasArrayToInterfaceConversion(){} // RVA: 0x7FFAC8E096F0
        public void HasInterfaceToArrayConversion(){} // RVA: 0x7FFAC8E09920
        public void IsCovariant(){} // RVA: 0x7FFAC8E09B50
        public void IsContravariant(){} // RVA: 0x7FFAC8E09B80
        public void IsInvariant(){} // RVA: 0x7FFAC8E09BB0
        public void IsDelegate(){} // RVA: 0x7FFAC8E09BE0
        public void IsLegalExplicitVariantDelegateConversion(){} // RVA: 0x7FFAC8E09CC0
        public void IsConvertible(){} // RVA: 0x7FFAC8E0A080
        public void HasReferenceEquality(){} // RVA: 0x7FFAC8E0A1A0
        public void HasBuiltInEqualityOperator(){} // RVA: 0x7FFAC8E0A2B0
        public void IsImplicitlyConvertibleTo(){} // RVA: 0x7FFAC8E0A530
        public void GetUserDefinedCoercionMethod(){} // RVA: 0x7FFAC8E0A960
        public void FindConversionOperator(){} // RVA: 0x7FFAC8E0ACB0
        public void IsImplicitNumericConversion(){} // RVA: 0x7FFAC8E0AF00
        public void IsImplicitReferenceConversion(){} // RVA: 0x7FFAC8D986C0
        public void IsImplicitBoxingConversion(){} // RVA: 0x7FFAC8E0B080
        public void IsImplicitNullableConversion(){} // RVA: 0x7FFAC8E0B1E0
        public void FindGenericType(){} // RVA: 0x7FFAC8E0B290
        public void GetBooleanOperator(){} // RVA: 0x7FFAC8E0B5F0
        public void GetNonRefType(){} // RVA: 0x7FFAC8E0B7D0
        public void AreEquivalent(){} // RVA: 0x7FFAC8E0B820
        public void AreReferenceAssignable(){} // RVA: 0x7FFAC8E0B8A0
        public void IsSameOrSubclass(){} // RVA: 0x7FFAC8E0B9C0
        public void ValidateType(){} // RVA: 0x7FFAC8E0BD00 | overloaded x3
        public void GetInvokeMethod(){} // RVA: 0x7FFAC8E0BE60
        public void .cctor(){} // RVA: 0x7FFAC8E0BF30
    }

}