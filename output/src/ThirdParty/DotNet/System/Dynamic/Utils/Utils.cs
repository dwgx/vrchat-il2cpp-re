// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Dynamic.Utils
// Classes: 11
// Methods: 112

namespace ThirdParty.DotNet.System.Dynamic.Utils
{
    public class CacheDict`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0
        public void AlignSize(){} // RVA: 0x13FF0
        public void TryGetValue(){} // RVA: 0x283FA0
        public void Add(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
    }

    public class CollectionExtensions
    {
        // ── Methods ──
        public void AddFirst(){} // RVA: 0x283FA0
        public void AddLast(){} // RVA: 0x283FA0
        public void RemoveFirst(){} // RVA: 0xCE50
        public void RemoveLast(){} // RVA: 0xCE50
        public void ToReadOnly(){} // RVA: 0xCE50
    }

    public class ContractUtils
    {
        public object controllingDirectors;

        // ── Methods ──
        public void get_Unreachable(){} // RVA: 0x666ED90
        public void Requires(){} // RVA: 0x666EE00
        public void RequiresNotNull(){} // RVA: 0x666EEA0 | overloaded x2
        public void RequiresNotEmpty(){} // RVA: 0x24D50
        public void RequiresNotNullItems(){} // RVA: 0x24D50
        public void GetParamName(){} // RVA: 0x666EF20
        public void RequiresArrayRange(){} // RVA: 0x2C4F0
    }

    public class EmptyReadOnlyCollection`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x24A80
    }

    public class ExpressionUtils
    {
        // ── Methods ──
        public void ReturnReadOnly(){} // RVA: 0x666F2D0 | overloaded x3
        public void ReturnObject(){} // RVA: 0x283FA0
        public void ValidateArgumentTypes(){} // RVA: 0x666F5C0
        public void ValidateArgumentCount(){} // RVA: 0x66701E0 | overloaded x2
        public void ValidateOneArgument(){} // RVA: 0x666FA90
        public void RequiresCanRead(){} // RVA: 0x666FD70 | overloaded x2
        public void TryQuote(){} // RVA: 0x666FFA0
        public void GetParametersForValidation(){} // RVA: 0x6670160
        public void SameElements(){} // RVA: 0xE230 | overloaded x2
        public void SameElementsInCollection(){} // RVA: 0xE230
    }

    public class ExpressionVisitorUtils
    {
        // ── Methods ──
        public void VisitBlockExpressions(){} // RVA: 0x6670260
        public void VisitParameters(){} // RVA: 0x6670450
        public void VisitArguments(){} // RVA: 0x6670670
    }

    public class ListArgumentProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6670890
        public void get_First(){} // RVA: 0x2E07C0
        public void get_ElementCount(){} // RVA: 0x6670990
        public void GetElement(){} // RVA: 0x66709E0
    }

    public class ListParameterProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6670A40
        public void get_First(){} // RVA: 0x2E07C0
        public void get_ElementCount(){} // RVA: 0x6670B40
        public void GetElement(){} // RVA: 0x6670B90
    }

    public class ListProvider`1
    {
        // ── Methods ──
        public void get_First(){} // RVA: 0x283FA0
        public void get_ElementCount(){} // RVA: 0xD840
        public void GetElement(){} // RVA: 0x283FA0
        public void IndexOf(){} // RVA: 0x283FA0
        public void Insert(){} // RVA: 0x283FA0
        public void RemoveAt(){} // RVA: 0x24FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void Add(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
        public void get_Count(){} // RVA: 0xD840
        public void get_IsReadOnly(){} // RVA: 0xDBE0
        public void Remove(){} // RVA: 0x283FA0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x24A50
    }

    public class TypeExtensions
    {
        // ── Methods ──
        public void GetAnyStaticMethodValidated(){} // RVA: 0x6670BF0
        public void MatchesArgumentTypes(){} // RVA: 0x6670D90
        public void GetReturnType(){} // RVA: 0x6670ED0
        public void GetTypeCode(){} // RVA: 0x6670F80
        public void GetParametersCached(){} // RVA: 0x6671020
        public void .cctor(){} // RVA: 0x66711D0
    }

    public class TypeUtils
    {
        // ── Methods ──
        public void GetNonNullableType(){} // RVA: 0x66712B0
        public void GetNullableType(){} // RVA: 0x6671350
        public void IsNullableType(){} // RVA: 0x66714C0
        public void IsNullableOrReferenceType(){} // RVA: 0x6671580
        public void IsBool(){} // RVA: 0x6671600
        public void IsNumeric(){} // RVA: 0x6671780
        public void IsInteger(){} // RVA: 0x66718A0
        public void IsArithmetic(){} // RVA: 0x66719C0
        public void IsUnsignedInt(){} // RVA: 0x6671AE0
        public void IsIntegerOrBool(){} // RVA: 0x6671C20
        public void IsNumericOrBool(){} // RVA: 0x6671D50
        public void IsValidInstanceType(){} // RVA: 0x6671DD0
        public void HasIdentityPrimitiveOrNullableConversionTo(){} // RVA: 0x66721B0
        public void HasReferenceConversionTo(){} // RVA: 0x6672500
        public void StrictHasReferenceConversionTo(){} // RVA: 0x6672780
        public void HasArrayToInterfaceConversion(){} // RVA: 0x6672C30
        public void HasInterfaceToArrayConversion(){} // RVA: 0x6672E60
        public void IsCovariant(){} // RVA: 0x6673090
        public void IsContravariant(){} // RVA: 0x66730C0
        public void IsInvariant(){} // RVA: 0x66730F0
        public void IsDelegate(){} // RVA: 0x6673120
        public void IsLegalExplicitVariantDelegateConversion(){} // RVA: 0x6673200
        public void IsConvertible(){} // RVA: 0x66735C0
        public void HasReferenceEquality(){} // RVA: 0x66736E0
        public void HasBuiltInEqualityOperator(){} // RVA: 0x66737F0
        public void IsImplicitlyConvertibleTo(){} // RVA: 0x6673A70
        public void GetUserDefinedCoercionMethod(){} // RVA: 0x6673EA0
        public void FindConversionOperator(){} // RVA: 0x66741F0
        public void IsImplicitNumericConversion(){} // RVA: 0x6674440
        public void IsImplicitReferenceConversion(){} // RVA: 0x6601C30
        public void IsImplicitBoxingConversion(){} // RVA: 0x66745C0
        public void IsImplicitNullableConversion(){} // RVA: 0x6674720
        public void FindGenericType(){} // RVA: 0x66747D0
        public void GetBooleanOperator(){} // RVA: 0x6674B30
        public void GetNonRefType(){} // RVA: 0x6674D10
        public void AreEquivalent(){} // RVA: 0x6674D60
        public void AreReferenceAssignable(){} // RVA: 0x6674DE0
        public void IsSameOrSubclass(){} // RVA: 0x6674F00
        public void ValidateType(){} // RVA: 0x6675240 | overloaded x3
        public void GetInvokeMethod(){} // RVA: 0x66753A0
        public void .cctor(){} // RVA: 0x6675470
    }

}