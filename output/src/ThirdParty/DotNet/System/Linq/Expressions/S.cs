// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 12
// Methods: 225

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class Scope1 : ScopeExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3CCB60
        public void SameExpressions(){} // RVA: 0x7AE3CCBD0
        public void GetExpression(){} // RVA: 0x7AE3CCE20
        public void get_ExpressionCount(){} // RVA: 0x7A81CA9D0
        public void GetOrMakeExpressions(){} // RVA: 0x7AE3CCEA0
        public void Rewrite(){} // RVA: 0x7AE3CCEB0
    }

    public class ScopeExpression : BlockExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3CC6D0
        public void SameVariables(){} // RVA: 0x7AE3CC9A0
        public void GetOrMakeVariables(){} // RVA: 0x7AE3CCA80
        public void get_VariablesList(){} // RVA: 0x7A80F2570
        public void ReuseOrValidateVariables(){} // RVA: 0x7AE3CCAC0
    }

    public class ScopeN : ScopeExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3CCB60
        public void SameExpressions(){} // RVA: 0x7AE3CD030
        public void get_Body(){} // RVA: 0x7A80DA7B0
        public void GetExpression(){} // RVA: 0x7AE3CD110
        public void get_ExpressionCount(){} // RVA: 0x7AE3CD170
        public void GetOrMakeExpressions(){} // RVA: 0x7AE3CD1C0
        public void Rewrite(){} // RVA: 0x7AE3CD200
    }

    public class ScopeWithType : ScopeN
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3CD360
        public void get_Type(){} // RVA: 0x7A81052C0
        public void Rewrite(){} // RVA: 0x7AE3CD440
    }

    public class SimpleBinaryExpression : BinaryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE39F650
        public void get_NodeType(){} // RVA: 0x7A851DB90
        public void get_Type(){} // RVA: 0x7A8105330
    }

    public class SpanDebugInfoExpression : DebugInfoExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3CEEA0
        public void get_StartLine(){} // RVA: 0x7A83782A0
        public void get_StartColumn(){} // RVA: 0x7A9739200
        public void get_EndLine(){} // RVA: 0x7A851DB90
        public void get_EndColumn(){} // RVA: 0x7A8AB15F0
        public void get_IsClear(){} // RVA: 0x7A80D7320
        public void Accept(){} // RVA: 0x7AE3CEE40
    }

    public class StackGuard : Object
    {
        // ── Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0x7A81BD750
        public void RunOnEmptyStack(){} // RVA: 0x7A8051B10
        public void RunOnEmptyStackCore(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Strings : Object
    {
        // ── Methods ──
        public void get_ReducibleMustOverrideReduce(){} // RVA: 0x7AE3F0770
        public void get_MustReduceToDifferent(){} // RVA: 0x7AE3F07B0
        public void get_ReducedNotCompatible(){} // RVA: 0x7AE3F07F0
        public void get_SetterHasNoParams(){} // RVA: 0x7AE3F0830
        public void get_PropertyCannotHaveRefType(){} // RVA: 0x7AE3F0870
        public void get_IndexesOfSetGetMustMatch(){} // RVA: 0x7AE3F08B0
        public void get_AccessorsCannotHaveVarArgs(){} // RVA: 0x7AE3F08F0
        public void get_AccessorsCannotHaveByRefArgs(){} // RVA: 0x7AE3F0930
        public void get_BoundsCannotBeLessThanOne(){} // RVA: 0x7AE3F0970
        public void get_TypeMustNotBeByRef(){} // RVA: 0x7AE3F09B0
        public void get_TypeMustNotBePointer(){} // RVA: 0x7AE3F09F0
        public void get_SetterMustBeVoid(){} // RVA: 0x7AE3F0A30
        public void get_PropertyTypeMustMatchGetter(){} // RVA: 0x7AE3F0A70
        public void get_PropertyTypeMustMatchSetter(){} // RVA: 0x7AE3F0AB0
        public void get_BothAccessorsMustBeStatic(){} // RVA: 0x7AE3F0AF0
        public void get_OnlyStaticFieldsHaveNullInstance(){} // RVA: 0x7AE3F0B30
        public void get_OnlyStaticPropertiesHaveNullInstance(){} // RVA: 0x7AE3F0B70
        public void get_OnlyStaticMethodsHaveNullInstance(){} // RVA: 0x7AE3F0BB0
        public void get_PropertyTypeCannotBeVoid(){} // RVA: 0x7AE3F0BF0
        public void get_InvalidUnboxType(){} // RVA: 0x7AE3F0C30
        public void get_ExpressionMustBeWriteable(){} // RVA: 0x7AE3F0C70
        public void get_ArgumentMustNotHaveValueType(){} // RVA: 0x7AE3F0CB0
        public void get_MustBeReducible(){} // RVA: 0x7AE3F0CF0
        public void get_AllTestValuesMustHaveSameType(){} // RVA: 0x7AE3F0D30
        public void get_AllCaseBodiesMustHaveSameType(){} // RVA: 0x7AE3F0D70
        public void get_DefaultBodyMustBeSupplied(){} // RVA: 0x7AE3F0DB0
        public void get_LabelMustBeVoidOrHaveExpression(){} // RVA: 0x7AE3F0DF0
        public void get_LabelTypeMustBeVoid(){} // RVA: 0x7AE3F0E30
        public void get_QuotedExpressionMustBeLambda(){} // RVA: 0x7AE3F0E70
        public void get_CollectionModifiedWhileEnumerating(){} // RVA: 0x7AE3F0EB0
        public void VariableMustNotBeByRef(){} // RVA: 0x7AE3F0EF0
        public void get_CollectionReadOnly(){} // RVA: 0x7AE3F0F40
        public void AmbiguousMatchInExpandoObject(){} // RVA: 0x7AE3F0F80
        public void SameKeyExistsInExpando(){} // RVA: 0x7AE3F0FD0
        public void KeyDoesNotExistInExpando(){} // RVA: 0x7AE3F1020
        public void get_ArgCntMustBeGreaterThanNameCnt(){} // RVA: 0x7AE3F1070
        public void InvalidMetaObjectCreated(){} // RVA: 0x7AE3F10B0
        public void BinderNotCompatibleWithCallSite(){} // RVA: 0x7AE3F1100
        public void DynamicBindingNeedsRestrictions(){} // RVA: 0x7AE3F1170
        public void DynamicObjectResultNotAssignable(){} // RVA: 0x7AE3F11C0
        public void DynamicBinderResultNotAssignable(){} // RVA: 0x7AE3F13E0
        public void get_BindingCannotBeNull(){} // RVA: 0x7AE3F1450
        public void DuplicateVariable(){} // RVA: 0x7AE3F1490
        public void get_ArgumentTypeCannotBeVoid(){} // RVA: 0x7AE3F14E0
        public void TypeParameterIsNotDelegate(){} // RVA: 0x7AE3F1520
        public void get_NoOrInvalidRuleProduced(){} // RVA: 0x7AE3F1570
        public void get_TypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x7AE3F15B0
        public void get_FirstArgumentMustBeCallSite(){} // RVA: 0x7AE3F15F0
        public void get_StartEndMustBeOrdered(){} // RVA: 0x7AE3F1630
        public void get_FaultCannotHaveCatchOrFinally(){} // RVA: 0x7AE3F1670
        public void get_TryMustHaveCatchFinallyOrFault(){} // RVA: 0x7AE3F16B0
        public void get_BodyOfCatchMustHaveSameTypeAsBodyOfTry(){} // RVA: 0x7AE3F16F0
        public void ExtensionNodeMustOverrideProperty(){} // RVA: 0x7AE3F1730
        public void UserDefinedOperatorMustBeStatic(){} // RVA: 0x7AE3F1780
        public void UserDefinedOperatorMustNotBeVoid(){} // RVA: 0x7AE3F17D0
        public void CoercionOperatorNotDefined(){} // RVA: 0x7AE3F1820
        public void UnaryOperatorNotDefined(){} // RVA: 0x7AE3F1870
        public void BinaryOperatorNotDefined(){} // RVA: 0x7AE3F18C0
        public void ReferenceEqualityNotDefined(){} // RVA: 0x7AE3F1930
        public void OperandTypesDoNotMatchParameters(){} // RVA: 0x7AE3F1980
        public void OverloadOperatorTypeDoesNotMatchConversionType(){} // RVA: 0x7AE3F19D0
        public void get_ConversionIsNotSupportedForArithmeticTypes(){} // RVA: 0x7AE3F1A20
        public void get_ArgumentMustBeArray(){} // RVA: 0x7AE3F1A60
        public void get_ArgumentMustBeBoolean(){} // RVA: 0x7AE3F1AA0
        public void EqualityMustReturnBoolean(){} // RVA: 0x7AE3F1AE0
        public void get_ArgumentMustBeFieldInfoOrPropertyInfo(){} // RVA: 0x7AE3F1B30
        public void get_ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(){} // RVA: 0x7AE3F1B70
        public void get_ArgumentMustBeInstanceMember(){} // RVA: 0x7AE3F1BB0
        public void get_ArgumentMustBeInteger(){} // RVA: 0x7AE3F1BF0
        public void get_ArgumentMustBeArrayIndexType(){} // RVA: 0x7AE3F1C30
        public void get_ArgumentMustBeSingleDimensionalArrayType(){} // RVA: 0x7AE3F1C70
        public void get_ArgumentTypesMustMatch(){} // RVA: 0x7AE3F1CB0
        public void CannotAutoInitializeValueTypeElementThroughProperty(){} // RVA: 0x7AE3F1CF0
        public void CannotAutoInitializeValueTypeMemberThroughProperty(){} // RVA: 0x7AE3F1D40
        public void IncorrectTypeForTypeAs(){} // RVA: 0x7AE3F1D90
        public void get_CoalesceUsedOnNonNullType(){} // RVA: 0x7AE3F1DE0
        public void ExpressionTypeCannotInitializeArrayType(){} // RVA: 0x7AE3F1E20
        public void ArgumentTypeDoesNotMatchMember(){} // RVA: 0x7AE3F1E70
        public void ArgumentMemberNotDeclOnType(){} // RVA: 0x7AE3F1EC0
        public void ExpressionTypeDoesNotMatchReturn(){} // RVA: 0x7AE3F1F10
        public void ExpressionTypeDoesNotMatchAssignment(){} // RVA: 0x7AE3F1F60
        public void ExpressionTypeDoesNotMatchLabel(){} // RVA: 0x7AE3F1FB0
        public void ExpressionTypeNotInvocable(){} // RVA: 0x7AE3F2000
        public void FieldNotDefinedForType(){} // RVA: 0x7AE3F2050
        public void InstanceFieldNotDefinedForType(){} // RVA: 0x7AE3F20A0
        public void FieldInfoNotDefinedForType(){} // RVA: 0x7AE3F20F0
        public void get_IncorrectNumberOfIndexes(){} // RVA: 0x7AE3F2160
        public void get_IncorrectNumberOfLambdaDeclarationParameters(){} // RVA: 0x7AE3F21A0
        public void get_IncorrectNumberOfMembersForGivenConstructor(){} // RVA: 0x7AE3F21E0
        public void get_IncorrectNumberOfArgumentsForMembers(){} // RVA: 0x7AE3F2220
        public void get_LambdaTypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x7AE3F2260
        public void MemberNotFieldOrProperty(){} // RVA: 0x7AE3F22A0
        public void MethodContainsGenericParameters(){} // RVA: 0x7AE3F22F0
        public void MethodIsGeneric(){} // RVA: 0x7AE3F2340
        public void MethodNotPropertyAccessor(){} // RVA: 0x7AE3F2390
        public void PropertyDoesNotHaveGetter(){} // RVA: 0x7AE3F23E0
        public void PropertyDoesNotHaveSetter(){} // RVA: 0x7AE3F2430
        public void PropertyDoesNotHaveAccessor(){} // RVA: 0x7AE3F2480
        public void NotAMemberOfType(){} // RVA: 0x7AE3F24D0
        public void NotAMemberOfAnyType(){} // RVA: 0x7AE3F2520
        public void ParameterExpressionNotValidAsDelegate(){} // RVA: 0x7AE3F2570
        public void PropertyNotDefinedForType(){} // RVA: 0x7AE3F25C0
        public void InstancePropertyNotDefinedForType(){} // RVA: 0x7AE3F2610
        public void InstancePropertyWithoutParameterNotDefinedForType(){} // RVA: 0x7AE3F2660
        public void InstancePropertyWithSpecifiedParametersNotDefinedForType(){} // RVA: 0x7AE3F26B0
        public void InstanceAndMethodTypeMismatch(){} // RVA: 0x7AE3F2720
        public void TypeMissingDefaultConstructor(){} // RVA: 0x7AE3F2790
        public void get_ElementInitializerMethodNotAdd(){} // RVA: 0x7AE3F27E0
        public void ElementInitializerMethodNoRefOutParam(){} // RVA: 0x7AE3F2820
        public void get_ElementInitializerMethodWithZeroArgs(){} // RVA: 0x7AE3F2870
        public void get_ElementInitializerMethodStatic(){} // RVA: 0x7AE3F28B0
        public void TypeNotIEnumerable(){} // RVA: 0x7AE3F28F0
        public void UnhandledBinary(){} // RVA: 0x7AE3F2940
        public void get_UnhandledBinding(){} // RVA: 0x7AE3F2990
        public void UnhandledBindingType(){} // RVA: 0x7AE3F29D0
        public void UnhandledUnary(){} // RVA: 0x7AE3F2A20
        public void get_UnknownBindingType(){} // RVA: 0x7AE3F2A70
        public void UserDefinedOpMustHaveConsistentTypes(){} // RVA: 0x7AE3F2AB0
        public void UserDefinedOpMustHaveValidReturnType(){} // RVA: 0x7AE3F2B00
        public void LogicalOperatorMustHaveBooleanOperators(){} // RVA: 0x7AE3F2B50
        public void MethodWithArgsDoesNotExistOnType(){} // RVA: 0x7AE3F2BA0
        public void GenericMethodWithArgsDoesNotExistOnType(){} // RVA: 0x7AE3F2BF0
        public void MethodWithMoreThanOneMatch(){} // RVA: 0x7AE3F2C40
        public void PropertyWithMoreThanOneMatch(){} // RVA: 0x7AE3F2C90
        public void get_IncorrectNumberOfTypeArgsForFunc(){} // RVA: 0x7AE3F2CE0
        public void get_IncorrectNumberOfTypeArgsForAction(){} // RVA: 0x7AE3F2D20
        public void get_ArgumentCannotBeOfTypeVoid(){} // RVA: 0x7AE3F2D60
        public void OutOfRange(){} // RVA: 0x7AE3F2DA0
        public void LabelTargetAlreadyDefined(){} // RVA: 0x7AE3F2DF0
        public void LabelTargetUndefined(){} // RVA: 0x7AE3F2E40
        public void get_ControlCannotLeaveFinally(){} // RVA: 0x7AE3F2E90
        public void get_ControlCannotLeaveFilterTest(){} // RVA: 0x7AE3F2ED0
        public void AmbiguousJump(){} // RVA: 0x7AE3F2F10
        public void get_ControlCannotEnterTry(){} // RVA: 0x7AE3F2F60
        public void get_ControlCannotEnterExpression(){} // RVA: 0x7AE3F2FA0
        public void NonLocalJumpWithValue(){} // RVA: 0x7AE3F2FE0
        public void InvalidLvalue(){} // RVA: 0x7AE3F3030
        public void UndefinedVariable(){} // RVA: 0x7AE3F3080
        public void CannotCloseOverByRef(){} // RVA: 0x7AE3F30F0
        public void UnexpectedVarArgsCall(){} // RVA: 0x7AE3F3140
        public void get_RethrowRequiresCatch(){} // RVA: 0x7AE3F3190
        public void get_TryNotAllowedInFilter(){} // RVA: 0x7AE3F31D0
        public void MustRewriteToSameNode(){} // RVA: 0x7AE3F3210
        public void MustRewriteChildToSameType(){} // RVA: 0x7AE3F3280
        public void MustRewriteWithoutMethod(){} // RVA: 0x7AE3F32F0
        public void TryNotSupportedForMethodsWithRefArgs(){} // RVA: 0x7AE3F3340
        public void TryNotSupportedForValueTypeInstances(){} // RVA: 0x7AE3F3390
        public void TestValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7AE3F33E0
        public void SwitchValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7AE3F3430
        public void get_NonStaticConstructorRequired(){} // RVA: 0x7AE3F3480
        public void get_NonAbstractConstructorRequired(){} // RVA: 0x7AE3F34C0
        public void get_ExpressionMustBeReadable(){} // RVA: 0x7AE3F3500
        public void ExpressionTypeDoesNotMatchConstructorParameter(){} // RVA: 0x7AE3F3540
        public void get_EnumerationIsDone(){} // RVA: 0x7AE3F3590
        public void TypeContainsGenericParameters(){} // RVA: 0x7AE3F35D0
        public void TypeIsGeneric(){} // RVA: 0x7AE3F3620
        public void get_InvalidArgumentValue(){} // RVA: 0x7AE3F3670
        public void get_NonEmptyCollectionRequired(){} // RVA: 0x7AE3F36B0
        public void InvalidNullValue(){} // RVA: 0x7AE3F36F0
        public void InvalidObjectType(){} // RVA: 0x7AE3F3740
        public void ExpressionTypeDoesNotMatchMethodParameter(){} // RVA: 0x7AE3F3790
        public void ExpressionTypeDoesNotMatchParameter(){} // RVA: 0x7AE3F3800
        public void IncorrectNumberOfMethodCallArguments(){} // RVA: 0x7AE3F3850
        public void get_IncorrectNumberOfLambdaArguments(){} // RVA: 0x7AE3F38A0
        public void get_IncorrectNumberOfConstructorArguments(){} // RVA: 0x7AE3F38E0
    }

    public class SwitchCase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3F39F0
        public void get_TestValues(){} // RVA: 0x7A80F2570
        public void get_Body(){} // RVA: 0x7A80DA7B0
        public void ToString(){} // RVA: 0x7AE3E13B0
        public void Update(){} // RVA: 0x7AE3F3920
    }

    public class SwitchExpression : Expression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3F3F50
        public void get_Type(){} // RVA: 0x7A80F2570
        public void get_NodeType(){} // RVA: 0x7ADC500D0
        public void get_SwitchValue(){} // RVA: 0x7A80DA7B0
        public void get_Cases(){} // RVA: 0x7A81052C0
        public void get_DefaultBody(){} // RVA: 0x7A8105330
        public void get_Comparison(){} // RVA: 0x7A83F69F0
        public void Accept(){} // RVA: 0x7AE3F3C20
        public void get_IsLifted(){} // RVA: 0x7AE3F3C50
        public void Update(){} // RVA: 0x7AE3F3E40
    }

    public class SymbolDocumentInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3F41C0
        public void get_FileName(){} // RVA: 0x7A80F2570
        public void get_Language(){} // RVA: 0x7AE3F4060
        public void get_LanguageVendor(){} // RVA: 0x7AE3F40B0
        public void get_DocumentType(){} // RVA: 0x7AE3F4100
        public void .cctor(){} // RVA: 0x7AE3F4160
    }

    public class SymbolDocumentWithGuids : SymbolDocumentInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3F4490
        public void get_Language(){} // RVA: 0x7A872EEF0
        public void get_LanguageVendor(){} // RVA: 0x7A8EDF360
        public void get_DocumentType(){} // RVA: 0x7A972BD20
    }

}