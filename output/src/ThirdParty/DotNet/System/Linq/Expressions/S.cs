// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 12
// Methods: 234

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class Scope1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF908E340 | overloaded x2
        public void SameExpressions(){} // RVA: 0x7FFAF908E3B0
        public void GetExpression(){} // RVA: 0x7FFAF908E610
        public void get_ExpressionCount(){} // RVA: 0x7FFAF2E7FAF0
        public void GetOrMakeExpressions(){} // RVA: 0x7FFAF908E690
        public void Rewrite(){} // RVA: 0x7FFAF908E6A0
    }

    public class ScopeExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF908DEB0
        public void SameVariables(){} // RVA: 0x7FFAF908E180
        public void GetOrMakeVariables(){} // RVA: 0x7FFAF908E260
        public void get_VariablesList(){} // RVA: 0x7FFAF2DA8380
        public void ReuseOrValidateVariables(){} // RVA: 0x7FFAF908E2A0
    }

    public class ScopeN
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF908E340
        public void SameExpressions(){} // RVA: 0x7FFAF908E820
        public void get_Body(){} // RVA: 0x7FFAF2D907C0
        public void GetExpression(){} // RVA: 0x7FFAF908E900
        public void get_ExpressionCount(){} // RVA: 0x7FFAF908E960
        public void GetOrMakeExpressions(){} // RVA: 0x7FFAF908E9B0
        public void Rewrite(){} // RVA: 0x7FFAF908E9F0
    }

    public class ScopeWithType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF908EB50
        public void get_Type(){} // RVA: 0x7FFAF2DBB0C0
        public void Rewrite(){} // RVA: 0x7FFAF908EC30
    }

    public class SimpleBinaryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9061140
        public void get_NodeType(){} // RVA: 0x7FFAF3210030
        public void get_Type(){} // RVA: 0x7FFAF2DBB130
    }

    public class SpanDebugInfoExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9090670
        public void get_StartLine(){} // RVA: 0x7FFAF306ED50
        public void get_StartColumn(){} // RVA: 0x7FFAF442C3B0
        public void get_EndLine(){} // RVA: 0x7FFAF3210030
        public void get_EndColumn(){} // RVA: 0x7FFAF379F5B0
        public void get_IsClear(){} // RVA: 0x7FFAF2D8D320
        public void Accept(){} // RVA: 0x7FFAF9090610
    }

    public class StackGuard
    {
        // ── Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0x7FFAF2E72850
        public void RunOnEmptyStack(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void RunOnEmptyStackCore(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Strings
    {
        public object TestValues;
        public object Body;
        public object get_Type;
        public object Accept;
        public object ]Cb;
        public object .cctor;
        public object `;
        public object get_Language;
        public object _language;

        // ── Methods ──
        public void get_ReducibleMustOverrideReduce(){} // RVA: 0x7FFAF90B1F80
        public void get_MustReduceToDifferent(){} // RVA: 0x7FFAF90B1FC0
        public void get_ReducedNotCompatible(){} // RVA: 0x7FFAF90B2000
        public void get_SetterHasNoParams(){} // RVA: 0x7FFAF90B2040
        public void get_PropertyCannotHaveRefType(){} // RVA: 0x7FFAF90B2080
        public void get_IndexesOfSetGetMustMatch(){} // RVA: 0x7FFAF90B20C0
        public void get_AccessorsCannotHaveVarArgs(){} // RVA: 0x7FFAF90B2100
        public void get_AccessorsCannotHaveByRefArgs(){} // RVA: 0x7FFAF90B2140
        public void get_BoundsCannotBeLessThanOne(){} // RVA: 0x7FFAF90B2180
        public void get_TypeMustNotBeByRef(){} // RVA: 0x7FFAF90B21C0
        public void get_TypeMustNotBePointer(){} // RVA: 0x7FFAF90B2200
        public void get_SetterMustBeVoid(){} // RVA: 0x7FFAF90B2240
        public void get_PropertyTypeMustMatchGetter(){} // RVA: 0x7FFAF90B2280
        public void get_PropertyTypeMustMatchSetter(){} // RVA: 0x7FFAF90B22C0
        public void get_BothAccessorsMustBeStatic(){} // RVA: 0x7FFAF90B2300
        public void get_OnlyStaticFieldsHaveNullInstance(){} // RVA: 0x7FFAF90B2340
        public void get_OnlyStaticPropertiesHaveNullInstance(){} // RVA: 0x7FFAF90B2380
        public void get_OnlyStaticMethodsHaveNullInstance(){} // RVA: 0x7FFAF90B23C0
        public void get_PropertyTypeCannotBeVoid(){} // RVA: 0x7FFAF90B2400
        public void get_InvalidUnboxType(){} // RVA: 0x7FFAF90B2440
        public void get_ExpressionMustBeWriteable(){} // RVA: 0x7FFAF90B2480
        public void get_ArgumentMustNotHaveValueType(){} // RVA: 0x7FFAF90B24C0
        public void get_MustBeReducible(){} // RVA: 0x7FFAF90B2500
        public void get_AllTestValuesMustHaveSameType(){} // RVA: 0x7FFAF90B2540
        public void get_AllCaseBodiesMustHaveSameType(){} // RVA: 0x7FFAF90B2580
        public void get_DefaultBodyMustBeSupplied(){} // RVA: 0x7FFAF90B25C0
        public void get_LabelMustBeVoidOrHaveExpression(){} // RVA: 0x7FFAF90B2600
        public void get_LabelTypeMustBeVoid(){} // RVA: 0x7FFAF90B2640
        public void get_QuotedExpressionMustBeLambda(){} // RVA: 0x7FFAF90B2680
        public void get_CollectionModifiedWhileEnumerating(){} // RVA: 0x7FFAF90B26C0
        public void VariableMustNotBeByRef(){} // RVA: 0x7FFAF90B2700
        public void get_CollectionReadOnly(){} // RVA: 0x7FFAF90B2750
        public void AmbiguousMatchInExpandoObject(){} // RVA: 0x7FFAF90B2790
        public void SameKeyExistsInExpando(){} // RVA: 0x7FFAF90B27E0
        public void KeyDoesNotExistInExpando(){} // RVA: 0x7FFAF90B2830
        public void get_ArgCntMustBeGreaterThanNameCnt(){} // RVA: 0x7FFAF90B2880
        public void InvalidMetaObjectCreated(){} // RVA: 0x7FFAF90B28C0
        public void BinderNotCompatibleWithCallSite(){} // RVA: 0x7FFAF90B2910
        public void DynamicBindingNeedsRestrictions(){} // RVA: 0x7FFAF90B2980
        public void DynamicObjectResultNotAssignable(){} // RVA: 0x7FFAF90B29D0
        public void DynamicBinderResultNotAssignable(){} // RVA: 0x7FFAF90B2BF0
        public void get_BindingCannotBeNull(){} // RVA: 0x7FFAF90B2C60
        public void DuplicateVariable(){} // RVA: 0x7FFAF90B2CA0
        public void get_ArgumentTypeCannotBeVoid(){} // RVA: 0x7FFAF90B2CF0
        public void TypeParameterIsNotDelegate(){} // RVA: 0x7FFAF90B2D30
        public void get_NoOrInvalidRuleProduced(){} // RVA: 0x7FFAF90B2D80
        public void get_TypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x7FFAF90B2DC0
        public void get_FirstArgumentMustBeCallSite(){} // RVA: 0x7FFAF90B2E00
        public void get_StartEndMustBeOrdered(){} // RVA: 0x7FFAF90B2E40
        public void get_FaultCannotHaveCatchOrFinally(){} // RVA: 0x7FFAF90B2E80
        public void get_TryMustHaveCatchFinallyOrFault(){} // RVA: 0x7FFAF90B2EC0
        public void get_BodyOfCatchMustHaveSameTypeAsBodyOfTry(){} // RVA: 0x7FFAF90B2F00
        public void ExtensionNodeMustOverrideProperty(){} // RVA: 0x7FFAF90B2F40
        public void UserDefinedOperatorMustBeStatic(){} // RVA: 0x7FFAF90B2F90
        public void UserDefinedOperatorMustNotBeVoid(){} // RVA: 0x7FFAF90B2FE0
        public void CoercionOperatorNotDefined(){} // RVA: 0x7FFAF90B3030
        public void UnaryOperatorNotDefined(){} // RVA: 0x7FFAF90B3080
        public void BinaryOperatorNotDefined(){} // RVA: 0x7FFAF90B30D0
        public void ReferenceEqualityNotDefined(){} // RVA: 0x7FFAF90B3140
        public void OperandTypesDoNotMatchParameters(){} // RVA: 0x7FFAF90B3190
        public void OverloadOperatorTypeDoesNotMatchConversionType(){} // RVA: 0x7FFAF90B31E0
        public void get_ConversionIsNotSupportedForArithmeticTypes(){} // RVA: 0x7FFAF90B3230
        public void get_ArgumentMustBeArray(){} // RVA: 0x7FFAF90B3270
        public void get_ArgumentMustBeBoolean(){} // RVA: 0x7FFAF90B32B0
        public void EqualityMustReturnBoolean(){} // RVA: 0x7FFAF90B32F0
        public void get_ArgumentMustBeFieldInfoOrPropertyInfo(){} // RVA: 0x7FFAF90B3340
        public void get_ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(){} // RVA: 0x7FFAF90B3380
        public void get_ArgumentMustBeInstanceMember(){} // RVA: 0x7FFAF90B33C0
        public void get_ArgumentMustBeInteger(){} // RVA: 0x7FFAF90B3400
        public void get_ArgumentMustBeArrayIndexType(){} // RVA: 0x7FFAF90B3440
        public void get_ArgumentMustBeSingleDimensionalArrayType(){} // RVA: 0x7FFAF90B3480
        public void get_ArgumentTypesMustMatch(){} // RVA: 0x7FFAF90B34C0
        public void CannotAutoInitializeValueTypeElementThroughProperty(){} // RVA: 0x7FFAF90B3500
        public void CannotAutoInitializeValueTypeMemberThroughProperty(){} // RVA: 0x7FFAF90B3550
        public void IncorrectTypeForTypeAs(){} // RVA: 0x7FFAF90B35A0
        public void get_CoalesceUsedOnNonNullType(){} // RVA: 0x7FFAF90B35F0
        public void ExpressionTypeCannotInitializeArrayType(){} // RVA: 0x7FFAF90B3630
        public void ArgumentTypeDoesNotMatchMember(){} // RVA: 0x7FFAF90B3680
        public void ArgumentMemberNotDeclOnType(){} // RVA: 0x7FFAF90B36D0
        public void ExpressionTypeDoesNotMatchReturn(){} // RVA: 0x7FFAF90B3720
        public void ExpressionTypeDoesNotMatchAssignment(){} // RVA: 0x7FFAF90B3770
        public void ExpressionTypeDoesNotMatchLabel(){} // RVA: 0x7FFAF90B37C0
        public void ExpressionTypeNotInvocable(){} // RVA: 0x7FFAF90B3810
        public void FieldNotDefinedForType(){} // RVA: 0x7FFAF90B3860
        public void InstanceFieldNotDefinedForType(){} // RVA: 0x7FFAF90B38B0
        public void FieldInfoNotDefinedForType(){} // RVA: 0x7FFAF90B3900
        public void get_IncorrectNumberOfIndexes(){} // RVA: 0x7FFAF90B3970
        public void get_IncorrectNumberOfLambdaDeclarationParameters(){} // RVA: 0x7FFAF90B39B0
        public void get_IncorrectNumberOfMembersForGivenConstructor(){} // RVA: 0x7FFAF90B39F0
        public void get_IncorrectNumberOfArgumentsForMembers(){} // RVA: 0x7FFAF90B3A30
        public void get_LambdaTypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x7FFAF90B3A70
        public void MemberNotFieldOrProperty(){} // RVA: 0x7FFAF90B3AB0
        public void MethodContainsGenericParameters(){} // RVA: 0x7FFAF90B3B00
        public void MethodIsGeneric(){} // RVA: 0x7FFAF90B3B50
        public void MethodNotPropertyAccessor(){} // RVA: 0x7FFAF90B3BA0
        public void PropertyDoesNotHaveGetter(){} // RVA: 0x7FFAF90B3BF0
        public void PropertyDoesNotHaveSetter(){} // RVA: 0x7FFAF90B3C40
        public void PropertyDoesNotHaveAccessor(){} // RVA: 0x7FFAF90B3C90
        public void NotAMemberOfType(){} // RVA: 0x7FFAF90B3CE0
        public void NotAMemberOfAnyType(){} // RVA: 0x7FFAF90B3D30
        public void ParameterExpressionNotValidAsDelegate(){} // RVA: 0x7FFAF90B3D80
        public void PropertyNotDefinedForType(){} // RVA: 0x7FFAF90B3DD0
        public void InstancePropertyNotDefinedForType(){} // RVA: 0x7FFAF90B3E20
        public void InstancePropertyWithoutParameterNotDefinedForType(){} // RVA: 0x7FFAF90B3E70
        public void InstancePropertyWithSpecifiedParametersNotDefinedForType(){} // RVA: 0x7FFAF90B3EC0
        public void InstanceAndMethodTypeMismatch(){} // RVA: 0x7FFAF90B3F30
        public void TypeMissingDefaultConstructor(){} // RVA: 0x7FFAF90B3FA0
        public void get_ElementInitializerMethodNotAdd(){} // RVA: 0x7FFAF90B3FF0
        public void ElementInitializerMethodNoRefOutParam(){} // RVA: 0x7FFAF90B4030
        public void get_ElementInitializerMethodWithZeroArgs(){} // RVA: 0x7FFAF90B4080
        public void get_ElementInitializerMethodStatic(){} // RVA: 0x7FFAF90B40C0
        public void TypeNotIEnumerable(){} // RVA: 0x7FFAF90B4100
        public void UnhandledBinary(){} // RVA: 0x7FFAF90B4150
        public void get_UnhandledBinding(){} // RVA: 0x7FFAF90B41A0
        public void UnhandledBindingType(){} // RVA: 0x7FFAF90B41E0
        public void UnhandledUnary(){} // RVA: 0x7FFAF90B4230
        public void get_UnknownBindingType(){} // RVA: 0x7FFAF90B4280
        public void UserDefinedOpMustHaveConsistentTypes(){} // RVA: 0x7FFAF90B42C0
        public void UserDefinedOpMustHaveValidReturnType(){} // RVA: 0x7FFAF90B4310
        public void LogicalOperatorMustHaveBooleanOperators(){} // RVA: 0x7FFAF90B4360
        public void MethodWithArgsDoesNotExistOnType(){} // RVA: 0x7FFAF90B43B0
        public void GenericMethodWithArgsDoesNotExistOnType(){} // RVA: 0x7FFAF90B4400
        public void MethodWithMoreThanOneMatch(){} // RVA: 0x7FFAF90B4450
        public void PropertyWithMoreThanOneMatch(){} // RVA: 0x7FFAF90B44A0
        public void get_IncorrectNumberOfTypeArgsForFunc(){} // RVA: 0x7FFAF90B44F0
        public void get_IncorrectNumberOfTypeArgsForAction(){} // RVA: 0x7FFAF90B4530
        public void get_ArgumentCannotBeOfTypeVoid(){} // RVA: 0x7FFAF90B4570
        public void OutOfRange(){} // RVA: 0x7FFAF90B45B0
        public void LabelTargetAlreadyDefined(){} // RVA: 0x7FFAF90B4600
        public void LabelTargetUndefined(){} // RVA: 0x7FFAF90B4650
        public void get_ControlCannotLeaveFinally(){} // RVA: 0x7FFAF90B46A0
        public void get_ControlCannotLeaveFilterTest(){} // RVA: 0x7FFAF90B46E0
        public void AmbiguousJump(){} // RVA: 0x7FFAF90B4720
        public void get_ControlCannotEnterTry(){} // RVA: 0x7FFAF90B4770
        public void get_ControlCannotEnterExpression(){} // RVA: 0x7FFAF90B47B0
        public void NonLocalJumpWithValue(){} // RVA: 0x7FFAF90B47F0
        public void InvalidLvalue(){} // RVA: 0x7FFAF90B4840
        public void UndefinedVariable(){} // RVA: 0x7FFAF90B4890
        public void CannotCloseOverByRef(){} // RVA: 0x7FFAF90B4900
        public void UnexpectedVarArgsCall(){} // RVA: 0x7FFAF90B4950
        public void get_RethrowRequiresCatch(){} // RVA: 0x7FFAF90B49A0
        public void get_TryNotAllowedInFilter(){} // RVA: 0x7FFAF90B49E0
        public void MustRewriteToSameNode(){} // RVA: 0x7FFAF90B4A20
        public void MustRewriteChildToSameType(){} // RVA: 0x7FFAF90B4A90
        public void MustRewriteWithoutMethod(){} // RVA: 0x7FFAF90B4B00
        public void TryNotSupportedForMethodsWithRefArgs(){} // RVA: 0x7FFAF90B4B50
        public void TryNotSupportedForValueTypeInstances(){} // RVA: 0x7FFAF90B4BA0
        public void TestValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7FFAF90B4BF0
        public void SwitchValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7FFAF90B4C40
        public void get_NonStaticConstructorRequired(){} // RVA: 0x7FFAF90B4C90
        public void get_NonAbstractConstructorRequired(){} // RVA: 0x7FFAF90B4CD0
        public void get_ExpressionMustBeReadable(){} // RVA: 0x7FFAF90B4D10
        public void ExpressionTypeDoesNotMatchConstructorParameter(){} // RVA: 0x7FFAF90B4D50
        public void get_EnumerationIsDone(){} // RVA: 0x7FFAF90B4DA0
        public void TypeContainsGenericParameters(){} // RVA: 0x7FFAF90B4DE0
        public void TypeIsGeneric(){} // RVA: 0x7FFAF90B4E30
        public void get_InvalidArgumentValue(){} // RVA: 0x7FFAF90B4E80
        public void get_NonEmptyCollectionRequired(){} // RVA: 0x7FFAF90B4EC0
        public void InvalidNullValue(){} // RVA: 0x7FFAF90B4F00
        public void InvalidObjectType(){} // RVA: 0x7FFAF90B4F50
        public void ExpressionTypeDoesNotMatchMethodParameter(){} // RVA: 0x7FFAF90B4FA0
        public void ExpressionTypeDoesNotMatchParameter(){} // RVA: 0x7FFAF90B5010
        public void IncorrectNumberOfMethodCallArguments(){} // RVA: 0x7FFAF90B5060
        public void get_IncorrectNumberOfLambdaArguments(){} // RVA: 0x7FFAF90B50B0
        public void get_IncorrectNumberOfConstructorArguments(){} // RVA: 0x7FFAF90B50F0
    }

    public class SwitchCase
    {
        public object Type;
        public object NodeType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90B5200 | overloaded x2
        public void get_TestValues(){} // RVA: 0x7FFAF2DA8380
        public void get_Body(){} // RVA: 0x7FFAF2D907C0
        public void ToString(){} // RVA: 0x7FFAF90A2BA0
        public void Update(){} // RVA: 0x7FFAF90B5130
    }

    public class SwitchExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90B5760 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAF2DA8380
        public void get_NodeType(){} // RVA: 0x7FFAF8911610
        public void get_SwitchValue(){} // RVA: 0x7FFAF2D907C0
        public void get_Cases(){} // RVA: 0x7FFAF2DBB0C0
        public void get_DefaultBody(){} // RVA: 0x7FFAF2DBB130
        public void get_Comparison(){} // RVA: 0x7FFAF30E74D0
        public void Accept(){} // RVA: 0x7FFAF90B5430
        public void get_IsLifted(){} // RVA: 0x7FFAF90B5460
        public void Update(){} // RVA: 0x7FFAF90B5650
    }

    public class SymbolDocumentInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90B59D0 | overloaded x2
        public void get_FileName(){} // RVA: 0x7FFAF2DA8380
        public void get_Language(){} // RVA: 0x7FFAF90B5870
        public void get_LanguageVendor(){} // RVA: 0x7FFAF90B58C0
        public void get_DocumentType(){} // RVA: 0x7FFAF90B5910
        public void .cctor(){} // RVA: 0x7FFAF90B5970
    }

    public class SymbolDocumentWithGuids
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90B5B30 | overloaded x3
        public void get_Language(){} // RVA: 0x7FFAF3444EE0
        public void get_LanguageVendor(){} // RVA: 0x7FFAF3BCF520
        public void get_DocumentType(){} // RVA: 0x7FFAF441F080
    }

}