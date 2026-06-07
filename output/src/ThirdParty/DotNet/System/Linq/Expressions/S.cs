// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 12
// Methods: 234

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class Scope1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65DE340 | overloaded x2
        public void SameExpressions(){} // RVA: 0x65DE3B0
        public void GetExpression(){} // RVA: 0x65DE610
        public void get_ExpressionCount(){} // RVA: 0x3CFAF0
        public void GetOrMakeExpressions(){} // RVA: 0x65DE690
        public void Rewrite(){} // RVA: 0x65DE6A0
    }

    public class ScopeExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65DDEB0
        public void SameVariables(){} // RVA: 0x65DE180
        public void GetOrMakeVariables(){} // RVA: 0x65DE260
        public void get_VariablesList(){} // RVA: 0x2F8380
        public void ReuseOrValidateVariables(){} // RVA: 0x65DE2A0
    }

    public class ScopeN
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65DE340
        public void SameExpressions(){} // RVA: 0x65DE820
        public void get_Body(){} // RVA: 0x2E07C0
        public void GetExpression(){} // RVA: 0x65DE900
        public void get_ExpressionCount(){} // RVA: 0x65DE960
        public void GetOrMakeExpressions(){} // RVA: 0x65DE9B0
        public void Rewrite(){} // RVA: 0x65DE9F0
    }

    public class ScopeWithType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65DEB50
        public void get_Type(){} // RVA: 0x30B0C0
        public void Rewrite(){} // RVA: 0x65DEC30
    }

    public class SimpleBinaryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65B1140
        public void get_NodeType(){} // RVA: 0x760030
        public void get_Type(){} // RVA: 0x30B130
    }

    public class SpanDebugInfoExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65E0670
        public void get_StartLine(){} // RVA: 0x5BED50
        public void get_StartColumn(){} // RVA: 0x197C3B0
        public void get_EndLine(){} // RVA: 0x760030
        public void get_EndColumn(){} // RVA: 0xCEF5B0
        public void get_IsClear(){} // RVA: 0x2DD320
        public void Accept(){} // RVA: 0x65E0610
    }

    public class StackGuard
    {
        // ── Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0x3C2850
        public void RunOnEmptyStack(){} // RVA: 0x283FA0 | overloaded x4
        public void RunOnEmptyStackCore(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x2DD310
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
        public void get_ReducibleMustOverrideReduce(){} // RVA: 0x6601F80
        public void get_MustReduceToDifferent(){} // RVA: 0x6601FC0
        public void get_ReducedNotCompatible(){} // RVA: 0x6602000
        public void get_SetterHasNoParams(){} // RVA: 0x6602040
        public void get_PropertyCannotHaveRefType(){} // RVA: 0x6602080
        public void get_IndexesOfSetGetMustMatch(){} // RVA: 0x66020C0
        public void get_AccessorsCannotHaveVarArgs(){} // RVA: 0x6602100
        public void get_AccessorsCannotHaveByRefArgs(){} // RVA: 0x6602140
        public void get_BoundsCannotBeLessThanOne(){} // RVA: 0x6602180
        public void get_TypeMustNotBeByRef(){} // RVA: 0x66021C0
        public void get_TypeMustNotBePointer(){} // RVA: 0x6602200
        public void get_SetterMustBeVoid(){} // RVA: 0x6602240
        public void get_PropertyTypeMustMatchGetter(){} // RVA: 0x6602280
        public void get_PropertyTypeMustMatchSetter(){} // RVA: 0x66022C0
        public void get_BothAccessorsMustBeStatic(){} // RVA: 0x6602300
        public void get_OnlyStaticFieldsHaveNullInstance(){} // RVA: 0x6602340
        public void get_OnlyStaticPropertiesHaveNullInstance(){} // RVA: 0x6602380
        public void get_OnlyStaticMethodsHaveNullInstance(){} // RVA: 0x66023C0
        public void get_PropertyTypeCannotBeVoid(){} // RVA: 0x6602400
        public void get_InvalidUnboxType(){} // RVA: 0x6602440
        public void get_ExpressionMustBeWriteable(){} // RVA: 0x6602480
        public void get_ArgumentMustNotHaveValueType(){} // RVA: 0x66024C0
        public void get_MustBeReducible(){} // RVA: 0x6602500
        public void get_AllTestValuesMustHaveSameType(){} // RVA: 0x6602540
        public void get_AllCaseBodiesMustHaveSameType(){} // RVA: 0x6602580
        public void get_DefaultBodyMustBeSupplied(){} // RVA: 0x66025C0
        public void get_LabelMustBeVoidOrHaveExpression(){} // RVA: 0x6602600
        public void get_LabelTypeMustBeVoid(){} // RVA: 0x6602640
        public void get_QuotedExpressionMustBeLambda(){} // RVA: 0x6602680
        public void get_CollectionModifiedWhileEnumerating(){} // RVA: 0x66026C0
        public void VariableMustNotBeByRef(){} // RVA: 0x6602700
        public void get_CollectionReadOnly(){} // RVA: 0x6602750
        public void AmbiguousMatchInExpandoObject(){} // RVA: 0x6602790
        public void SameKeyExistsInExpando(){} // RVA: 0x66027E0
        public void KeyDoesNotExistInExpando(){} // RVA: 0x6602830
        public void get_ArgCntMustBeGreaterThanNameCnt(){} // RVA: 0x6602880
        public void InvalidMetaObjectCreated(){} // RVA: 0x66028C0
        public void BinderNotCompatibleWithCallSite(){} // RVA: 0x6602910
        public void DynamicBindingNeedsRestrictions(){} // RVA: 0x6602980
        public void DynamicObjectResultNotAssignable(){} // RVA: 0x66029D0
        public void DynamicBinderResultNotAssignable(){} // RVA: 0x6602BF0
        public void get_BindingCannotBeNull(){} // RVA: 0x6602C60
        public void DuplicateVariable(){} // RVA: 0x6602CA0
        public void get_ArgumentTypeCannotBeVoid(){} // RVA: 0x6602CF0
        public void TypeParameterIsNotDelegate(){} // RVA: 0x6602D30
        public void get_NoOrInvalidRuleProduced(){} // RVA: 0x6602D80
        public void get_TypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x6602DC0
        public void get_FirstArgumentMustBeCallSite(){} // RVA: 0x6602E00
        public void get_StartEndMustBeOrdered(){} // RVA: 0x6602E40
        public void get_FaultCannotHaveCatchOrFinally(){} // RVA: 0x6602E80
        public void get_TryMustHaveCatchFinallyOrFault(){} // RVA: 0x6602EC0
        public void get_BodyOfCatchMustHaveSameTypeAsBodyOfTry(){} // RVA: 0x6602F00
        public void ExtensionNodeMustOverrideProperty(){} // RVA: 0x6602F40
        public void UserDefinedOperatorMustBeStatic(){} // RVA: 0x6602F90
        public void UserDefinedOperatorMustNotBeVoid(){} // RVA: 0x6602FE0
        public void CoercionOperatorNotDefined(){} // RVA: 0x6603030
        public void UnaryOperatorNotDefined(){} // RVA: 0x6603080
        public void BinaryOperatorNotDefined(){} // RVA: 0x66030D0
        public void ReferenceEqualityNotDefined(){} // RVA: 0x6603140
        public void OperandTypesDoNotMatchParameters(){} // RVA: 0x6603190
        public void OverloadOperatorTypeDoesNotMatchConversionType(){} // RVA: 0x66031E0
        public void get_ConversionIsNotSupportedForArithmeticTypes(){} // RVA: 0x6603230
        public void get_ArgumentMustBeArray(){} // RVA: 0x6603270
        public void get_ArgumentMustBeBoolean(){} // RVA: 0x66032B0
        public void EqualityMustReturnBoolean(){} // RVA: 0x66032F0
        public void get_ArgumentMustBeFieldInfoOrPropertyInfo(){} // RVA: 0x6603340
        public void get_ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(){} // RVA: 0x6603380
        public void get_ArgumentMustBeInstanceMember(){} // RVA: 0x66033C0
        public void get_ArgumentMustBeInteger(){} // RVA: 0x6603400
        public void get_ArgumentMustBeArrayIndexType(){} // RVA: 0x6603440
        public void get_ArgumentMustBeSingleDimensionalArrayType(){} // RVA: 0x6603480
        public void get_ArgumentTypesMustMatch(){} // RVA: 0x66034C0
        public void CannotAutoInitializeValueTypeElementThroughProperty(){} // RVA: 0x6603500
        public void CannotAutoInitializeValueTypeMemberThroughProperty(){} // RVA: 0x6603550
        public void IncorrectTypeForTypeAs(){} // RVA: 0x66035A0
        public void get_CoalesceUsedOnNonNullType(){} // RVA: 0x66035F0
        public void ExpressionTypeCannotInitializeArrayType(){} // RVA: 0x6603630
        public void ArgumentTypeDoesNotMatchMember(){} // RVA: 0x6603680
        public void ArgumentMemberNotDeclOnType(){} // RVA: 0x66036D0
        public void ExpressionTypeDoesNotMatchReturn(){} // RVA: 0x6603720
        public void ExpressionTypeDoesNotMatchAssignment(){} // RVA: 0x6603770
        public void ExpressionTypeDoesNotMatchLabel(){} // RVA: 0x66037C0
        public void ExpressionTypeNotInvocable(){} // RVA: 0x6603810
        public void FieldNotDefinedForType(){} // RVA: 0x6603860
        public void InstanceFieldNotDefinedForType(){} // RVA: 0x66038B0
        public void FieldInfoNotDefinedForType(){} // RVA: 0x6603900
        public void get_IncorrectNumberOfIndexes(){} // RVA: 0x6603970
        public void get_IncorrectNumberOfLambdaDeclarationParameters(){} // RVA: 0x66039B0
        public void get_IncorrectNumberOfMembersForGivenConstructor(){} // RVA: 0x66039F0
        public void get_IncorrectNumberOfArgumentsForMembers(){} // RVA: 0x6603A30
        public void get_LambdaTypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x6603A70
        public void MemberNotFieldOrProperty(){} // RVA: 0x6603AB0
        public void MethodContainsGenericParameters(){} // RVA: 0x6603B00
        public void MethodIsGeneric(){} // RVA: 0x6603B50
        public void MethodNotPropertyAccessor(){} // RVA: 0x6603BA0
        public void PropertyDoesNotHaveGetter(){} // RVA: 0x6603BF0
        public void PropertyDoesNotHaveSetter(){} // RVA: 0x6603C40
        public void PropertyDoesNotHaveAccessor(){} // RVA: 0x6603C90
        public void NotAMemberOfType(){} // RVA: 0x6603CE0
        public void NotAMemberOfAnyType(){} // RVA: 0x6603D30
        public void ParameterExpressionNotValidAsDelegate(){} // RVA: 0x6603D80
        public void PropertyNotDefinedForType(){} // RVA: 0x6603DD0
        public void InstancePropertyNotDefinedForType(){} // RVA: 0x6603E20
        public void InstancePropertyWithoutParameterNotDefinedForType(){} // RVA: 0x6603E70
        public void InstancePropertyWithSpecifiedParametersNotDefinedForType(){} // RVA: 0x6603EC0
        public void InstanceAndMethodTypeMismatch(){} // RVA: 0x6603F30
        public void TypeMissingDefaultConstructor(){} // RVA: 0x6603FA0
        public void get_ElementInitializerMethodNotAdd(){} // RVA: 0x6603FF0
        public void ElementInitializerMethodNoRefOutParam(){} // RVA: 0x6604030
        public void get_ElementInitializerMethodWithZeroArgs(){} // RVA: 0x6604080
        public void get_ElementInitializerMethodStatic(){} // RVA: 0x66040C0
        public void TypeNotIEnumerable(){} // RVA: 0x6604100
        public void UnhandledBinary(){} // RVA: 0x6604150
        public void get_UnhandledBinding(){} // RVA: 0x66041A0
        public void UnhandledBindingType(){} // RVA: 0x66041E0
        public void UnhandledUnary(){} // RVA: 0x6604230
        public void get_UnknownBindingType(){} // RVA: 0x6604280
        public void UserDefinedOpMustHaveConsistentTypes(){} // RVA: 0x66042C0
        public void UserDefinedOpMustHaveValidReturnType(){} // RVA: 0x6604310
        public void LogicalOperatorMustHaveBooleanOperators(){} // RVA: 0x6604360
        public void MethodWithArgsDoesNotExistOnType(){} // RVA: 0x66043B0
        public void GenericMethodWithArgsDoesNotExistOnType(){} // RVA: 0x6604400
        public void MethodWithMoreThanOneMatch(){} // RVA: 0x6604450
        public void PropertyWithMoreThanOneMatch(){} // RVA: 0x66044A0
        public void get_IncorrectNumberOfTypeArgsForFunc(){} // RVA: 0x66044F0
        public void get_IncorrectNumberOfTypeArgsForAction(){} // RVA: 0x6604530
        public void get_ArgumentCannotBeOfTypeVoid(){} // RVA: 0x6604570
        public void OutOfRange(){} // RVA: 0x66045B0
        public void LabelTargetAlreadyDefined(){} // RVA: 0x6604600
        public void LabelTargetUndefined(){} // RVA: 0x6604650
        public void get_ControlCannotLeaveFinally(){} // RVA: 0x66046A0
        public void get_ControlCannotLeaveFilterTest(){} // RVA: 0x66046E0
        public void AmbiguousJump(){} // RVA: 0x6604720
        public void get_ControlCannotEnterTry(){} // RVA: 0x6604770
        public void get_ControlCannotEnterExpression(){} // RVA: 0x66047B0
        public void NonLocalJumpWithValue(){} // RVA: 0x66047F0
        public void InvalidLvalue(){} // RVA: 0x6604840
        public void UndefinedVariable(){} // RVA: 0x6604890
        public void CannotCloseOverByRef(){} // RVA: 0x6604900
        public void UnexpectedVarArgsCall(){} // RVA: 0x6604950
        public void get_RethrowRequiresCatch(){} // RVA: 0x66049A0
        public void get_TryNotAllowedInFilter(){} // RVA: 0x66049E0
        public void MustRewriteToSameNode(){} // RVA: 0x6604A20
        public void MustRewriteChildToSameType(){} // RVA: 0x6604A90
        public void MustRewriteWithoutMethod(){} // RVA: 0x6604B00
        public void TryNotSupportedForMethodsWithRefArgs(){} // RVA: 0x6604B50
        public void TryNotSupportedForValueTypeInstances(){} // RVA: 0x6604BA0
        public void TestValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x6604BF0
        public void SwitchValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x6604C40
        public void get_NonStaticConstructorRequired(){} // RVA: 0x6604C90
        public void get_NonAbstractConstructorRequired(){} // RVA: 0x6604CD0
        public void get_ExpressionMustBeReadable(){} // RVA: 0x6604D10
        public void ExpressionTypeDoesNotMatchConstructorParameter(){} // RVA: 0x6604D50
        public void get_EnumerationIsDone(){} // RVA: 0x6604DA0
        public void TypeContainsGenericParameters(){} // RVA: 0x6604DE0
        public void TypeIsGeneric(){} // RVA: 0x6604E30
        public void get_InvalidArgumentValue(){} // RVA: 0x6604E80
        public void get_NonEmptyCollectionRequired(){} // RVA: 0x6604EC0
        public void InvalidNullValue(){} // RVA: 0x6604F00
        public void InvalidObjectType(){} // RVA: 0x6604F50
        public void ExpressionTypeDoesNotMatchMethodParameter(){} // RVA: 0x6604FA0
        public void ExpressionTypeDoesNotMatchParameter(){} // RVA: 0x6605010
        public void IncorrectNumberOfMethodCallArguments(){} // RVA: 0x6605060
        public void get_IncorrectNumberOfLambdaArguments(){} // RVA: 0x66050B0
        public void get_IncorrectNumberOfConstructorArguments(){} // RVA: 0x66050F0
    }

    public class SwitchCase
    {
        public object Type;
        public object NodeType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6605200 | overloaded x2
        public void get_TestValues(){} // RVA: 0x2F8380
        public void get_Body(){} // RVA: 0x2E07C0
        public void ToString(){} // RVA: 0x65F2BA0
        public void Update(){} // RVA: 0x6605130
    }

    public class SwitchExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6605760 | overloaded x2
        public void get_Type(){} // RVA: 0x2F8380
        public void get_NodeType(){} // RVA: 0x5E61610
        public void get_SwitchValue(){} // RVA: 0x2E07C0
        public void get_Cases(){} // RVA: 0x30B0C0
        public void get_DefaultBody(){} // RVA: 0x30B130
        public void get_Comparison(){} // RVA: 0x6374D0
        public void Accept(){} // RVA: 0x6605430
        public void get_IsLifted(){} // RVA: 0x6605460
        public void Update(){} // RVA: 0x6605650
    }

    public class SymbolDocumentInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66059D0 | overloaded x2
        public void get_FileName(){} // RVA: 0x2F8380
        public void get_Language(){} // RVA: 0x6605870
        public void get_LanguageVendor(){} // RVA: 0x66058C0
        public void get_DocumentType(){} // RVA: 0x6605910
        public void .cctor(){} // RVA: 0x6605970
    }

    public class SymbolDocumentWithGuids
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6605B30 | overloaded x3
        public void get_Language(){} // RVA: 0x994EE0
        public void get_LanguageVendor(){} // RVA: 0x111F520
        public void get_DocumentType(){} // RVA: 0x196F080
    }

}