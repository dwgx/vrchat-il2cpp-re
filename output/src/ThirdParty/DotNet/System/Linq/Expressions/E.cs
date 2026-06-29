// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 20
// Methods: 565

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class ElementInit : Object
    {
        public object _addMethod;
        public object _arguments;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70594E0
        public void get_AddMethod(){} // RVA: 0xB5DBF0
        public void get_Arguments(){} // RVA: 0xB465B0
        public void GetArgument(){} // RVA: 0x70592C0
        public void get_ArgumentCount(){} // RVA: 0x7059350
        public void ToString(){} // RVA: 0x70593D0
        public void Update(){} // RVA: 0x7059460
    }

    public class Error : Object
    {
        // ── Methods ──
        public void ReducibleMustOverrideReduce(){} // RVA: 0x7059510
        public void ArgCntMustBeGreaterThanNameCnt(){} // RVA: 0x70595A0
        public void InvalidMetaObjectCreated(){} // RVA: 0x7059630
        public void AmbiguousMatchInExpandoObject(){} // RVA: 0x70596D0
        public void SameKeyExistsInExpando(){} // RVA: 0x7059770
        public void KeyDoesNotExistInExpando(){} // RVA: 0x7059820
        public void CollectionModifiedWhileEnumerating(){} // RVA: 0x70598C0
        public void CollectionReadOnly(){} // RVA: 0x7059950
        public void MustReduceToDifferent(){} // RVA: 0x70599E0
        public void BinderNotCompatibleWithCallSite(){} // RVA: 0x7059A70
        public void DynamicBindingNeedsRestrictions(){} // RVA: 0x7059B30
        public void DynamicObjectResultNotAssignable(){} // RVA: 0x7059BD0
        public void DynamicBinderResultNotAssignable(){} // RVA: 0x7059C70
        public void BindingCannotBeNull(){} // RVA: 0x7059D30
        public void ReducedNotCompatible(){} // RVA: 0x7059DC0
        public void SetterHasNoParams(){} // RVA: 0x7059E50
        public void PropertyCannotHaveRefType(){} // RVA: 0x7059EE0
        public void IndexesOfSetGetMustMatch(){} // RVA: 0x7059F70
        public void TypeParameterIsNotDelegate(){} // RVA: 0x705A000
        public void FirstArgumentMustBeCallSite(){} // RVA: 0x705A0A0
        public void AccessorsCannotHaveVarArgs(){} // RVA: 0x705A130
        public void AccessorsCannotHaveByRefArgs(){} // RVA: 0x705A250
        public void TypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x705A2F0
        public void NoOrInvalidRuleProduced(){} // RVA: 0x705A380
        public void BoundsCannotBeLessThanOne(){} // RVA: 0x705A410
        public void TypeMustNotBeByRef(){} // RVA: 0x705A4A0
        public void TypeMustNotBePointer(){} // RVA: 0x705A530
        public void SetterMustBeVoid(){} // RVA: 0x705A5C0
        public void PropertyTypeMustMatchGetter(){} // RVA: 0x705A650
        public void PropertyTypeMustMatchSetter(){} // RVA: 0x705A6E0
        public void BothAccessorsMustBeStatic(){} // RVA: 0x705A770
        public void OnlyStaticFieldsHaveNullInstance(){} // RVA: 0x705A800
        public void OnlyStaticPropertiesHaveNullInstance(){} // RVA: 0x705A890
        public void OnlyStaticMethodsHaveNullInstance(){} // RVA: 0x705A920
        public void PropertyTypeCannotBeVoid(){} // RVA: 0x705A9B0
        public void InvalidUnboxType(){} // RVA: 0x705AA40
        public void ExpressionMustBeWriteable(){} // RVA: 0x705AAD0
        public void ArgumentMustNotHaveValueType(){} // RVA: 0x705AB60
        public void MustBeReducible(){} // RVA: 0x705ABF0
        public void AllTestValuesMustHaveSameType(){} // RVA: 0x705AC80
        public void AllCaseBodiesMustHaveSameType(){} // RVA: 0x705AD10
        public void DefaultBodyMustBeSupplied(){} // RVA: 0x705ADA0
        public void LabelMustBeVoidOrHaveExpression(){} // RVA: 0x705AE30
        public void LabelTypeMustBeVoid(){} // RVA: 0x705AEC0
        public void QuotedExpressionMustBeLambda(){} // RVA: 0x705AF50
        public void VariableMustNotBeByRef(){} // RVA: 0x705B090
        public void DuplicateVariable(){} // RVA: 0x705B170
        public void StartEndMustBeOrdered(){} // RVA: 0x705B230
        public void FaultCannotHaveCatchOrFinally(){} // RVA: 0x705B2C0
        public void TryMustHaveCatchFinallyOrFault(){} // RVA: 0x705B350
        public void BodyOfCatchMustHaveSameTypeAsBodyOfTry(){} // RVA: 0x705B3E0
        public void ExtensionNodeMustOverrideProperty(){} // RVA: 0x705B470
        public void UserDefinedOperatorMustBeStatic(){} // RVA: 0x705B510
        public void UserDefinedOperatorMustNotBeVoid(){} // RVA: 0x705B5B0
        public void CoercionOperatorNotDefined(){} // RVA: 0x705B650
        public void UnaryOperatorNotDefined(){} // RVA: 0x705B6F0
        public void BinaryOperatorNotDefined(){} // RVA: 0x705B790
        public void ReferenceEqualityNotDefined(){} // RVA: 0x705B850
        public void OperandTypesDoNotMatchParameters(){} // RVA: 0x705B8F0
        public void OverloadOperatorTypeDoesNotMatchConversionType(){} // RVA: 0x705B990
        public void ConversionIsNotSupportedForArithmeticTypes(){} // RVA: 0x705BA30
        public void ArgumentTypeCannotBeVoid(){} // RVA: 0x705BAC0
        public void ArgumentMustBeArray(){} // RVA: 0x705BB50
        public void ArgumentMustBeBoolean(){} // RVA: 0x705BBE0
        public void EqualityMustReturnBoolean(){} // RVA: 0x705BC70
        public void ArgumentMustBeFieldInfoOrPropertyInfo(){} // RVA: 0x705BD10
        public void ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(){} // RVA: 0x705BE30
        public void ArgumentMustBeInstanceMember(){} // RVA: 0x705BF60
        public void ArgumentMustBeInteger(){} // RVA: 0x705C090
        public void ArgumentMustBeArrayIndexType(){} // RVA: 0x705C1C0
        public void ArgumentMustBeSingleDimensionalArrayType(){} // RVA: 0x705C1E0
        public void ArgumentTypesMustMatch(){} // RVA: 0x705C300
        public void CannotAutoInitializeValueTypeElementThroughProperty(){} // RVA: 0x705C390
        public void CannotAutoInitializeValueTypeMemberThroughProperty(){} // RVA: 0x705C430
        public void IncorrectTypeForTypeAs(){} // RVA: 0x705C4D0
        public void CoalesceUsedOnNonNullType(){} // RVA: 0x705C570
        public void ExpressionTypeCannotInitializeArrayType(){} // RVA: 0x705C600
        public void ArgumentTypeDoesNotMatchMember(){} // RVA: 0x705C750
        public void ArgumentMemberNotDeclOnType(){} // RVA: 0x705C8C0
        public void ExpressionTypeDoesNotMatchReturn(){} // RVA: 0x705C980
        public void ExpressionTypeDoesNotMatchAssignment(){} // RVA: 0x705CA20
        public void ExpressionTypeDoesNotMatchLabel(){} // RVA: 0x705CAC0
        public void ExpressionTypeNotInvocable(){} // RVA: 0x705CB60
        public void FieldNotDefinedForType(){} // RVA: 0x705CC00
        public void InstanceFieldNotDefinedForType(){} // RVA: 0x705CCA0
        public void FieldInfoNotDefinedForType(){} // RVA: 0x705CD40
        public void IncorrectNumberOfIndexes(){} // RVA: 0x705CE00
        public void IncorrectNumberOfLambdaDeclarationParameters(){} // RVA: 0x705CE90
        public void IncorrectNumberOfMembersForGivenConstructor(){} // RVA: 0x705CF20
        public void IncorrectNumberOfArgumentsForMembers(){} // RVA: 0x705CFB0
        public void LambdaTypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x705D040
        public void MemberNotFieldOrProperty(){} // RVA: 0x705D0D0
        public void MethodContainsGenericParameters(){} // RVA: 0x705D170
        public void MethodIsGeneric(){} // RVA: 0x705D210
        public void MethodNotPropertyAccessor(){} // RVA: 0x705D360
        public void PropertyDoesNotHaveGetter(){} // RVA: 0x705D4C0
        public void PropertyDoesNotHaveSetter(){} // RVA: 0x705D4F0
        public void PropertyDoesNotHaveAccessor(){} // RVA: 0x705D590
        public void NotAMemberOfType(){} // RVA: 0x705D6E0
        public void NotAMemberOfAnyType(){} // RVA: 0x705D720
        public void ParameterExpressionNotValidAsDelegate(){} // RVA: 0x705D7C0
        public void PropertyNotDefinedForType(){} // RVA: 0x705D860
        public void InstancePropertyNotDefinedForType(){} // RVA: 0x705D910
        public void InstancePropertyWithoutParameterNotDefinedForType(){} // RVA: 0x705D9C0
        public void InstancePropertyWithSpecifiedParametersNotDefinedForType(){} // RVA: 0x705DA60
        public void InstanceAndMethodTypeMismatch(){} // RVA: 0x705DB20
        public void TypeMissingDefaultConstructor(){} // RVA: 0x705DBE0
        public void ElementInitializerMethodNotAdd(){} // RVA: 0x705DC80
        public void ElementInitializerMethodNoRefOutParam(){} // RVA: 0x705DD10
        public void ElementInitializerMethodWithZeroArgs(){} // RVA: 0x705DDC0
        public void ElementInitializerMethodStatic(){} // RVA: 0x705DE50
        public void TypeNotIEnumerable(){} // RVA: 0x705DEE0
        public void UnhandledBinary(){} // RVA: 0x705DF80
        public void UnhandledBinding(){} // RVA: 0x705E020
        public void UnhandledBindingType(){} // RVA: 0x705E0B0
        public void UnhandledUnary(){} // RVA: 0x705E150
        public void UnknownBindingType(){} // RVA: 0x705E1F0
        public void UserDefinedOpMustHaveConsistentTypes(){} // RVA: 0x705E300
        public void UserDefinedOpMustHaveValidReturnType(){} // RVA: 0x705E3A0
        public void LogicalOperatorMustHaveBooleanOperators(){} // RVA: 0x705E440
        public void MethodWithArgsDoesNotExistOnType(){} // RVA: 0x705E4E0
        public void GenericMethodWithArgsDoesNotExistOnType(){} // RVA: 0x705E580
        public void MethodWithMoreThanOneMatch(){} // RVA: 0x705E620
        public void PropertyWithMoreThanOneMatch(){} // RVA: 0x705E6C0
        public void IncorrectNumberOfTypeArgsForFunc(){} // RVA: 0x705E760
        public void IncorrectNumberOfTypeArgsForAction(){} // RVA: 0x705E7F0
        public void ArgumentCannotBeOfTypeVoid(){} // RVA: 0x705E880
        public void OutOfRange(){} // RVA: 0x705E910
        public void LabelTargetAlreadyDefined(){} // RVA: 0x705E9C0
        public void LabelTargetUndefined(){} // RVA: 0x705EA60
        public void ControlCannotLeaveFinally(){} // RVA: 0x705EB00
        public void ControlCannotLeaveFilterTest(){} // RVA: 0x705EB90
        public void AmbiguousJump(){} // RVA: 0x705EC20
        public void ControlCannotEnterTry(){} // RVA: 0x705ECC0
        public void ControlCannotEnterExpression(){} // RVA: 0x705ED50
        public void NonLocalJumpWithValue(){} // RVA: 0x705EDE0
        public void InvalidLvalue(){} // RVA: 0x705EE80
        public void UndefinedVariable(){} // RVA: 0x705EF40
        public void CannotCloseOverByRef(){} // RVA: 0x705F000
        public void UnexpectedVarArgsCall(){} // RVA: 0x705F0A0
        public void RethrowRequiresCatch(){} // RVA: 0x705F140
        public void TryNotAllowedInFilter(){} // RVA: 0x705F1D0
        public void MustRewriteToSameNode(){} // RVA: 0x705F260
        public void MustRewriteChildToSameType(){} // RVA: 0x705F320
        public void MustRewriteWithoutMethod(){} // RVA: 0x705F3E0
        public void TryNotSupportedForMethodsWithRefArgs(){} // RVA: 0x705F480
        public void TryNotSupportedForValueTypeInstances(){} // RVA: 0x705F520
        public void TestValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x705F5C0
        public void SwitchValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x705F660
        public void ArgumentOutOfRange(){} // RVA: 0x705F700
        public void NotSupported(){} // RVA: 0x705F790
        public void NonStaticConstructorRequired(){} // RVA: 0x705F810
        public void NonAbstractConstructorRequired(){} // RVA: 0x705F8A0
        public void InvalidProgram(){} // RVA: 0x705F930
        public void EnumerationIsDone(){} // RVA: 0x705F9B0
        public void TypeContainsGenericParameters(){} // RVA: 0x705FAE0
        public void TypeIsGeneric(){} // RVA: 0x705FC40
        public void IncorrectNumberOfConstructorArguments(){} // RVA: 0x705FD00
        public void ExpressionTypeDoesNotMatchMethodParameter(){} // RVA: 0x705FE50
        public void ExpressionTypeDoesNotMatchParameter(){} // RVA: 0x705FFD0
        public void IncorrectNumberOfLambdaArguments(){} // RVA: 0x7060090
        public void IncorrectNumberOfMethodCallArguments(){} // RVA: 0x7060120
        public void ExpressionTypeDoesNotMatchConstructorParameter(){} // RVA: 0x7060270
        public void ExpressionMustBeReadable(){} // RVA: 0x70603C0
        public void InvalidArgumentValue(){} // RVA: 0x7060460
        public void NonEmptyCollectionRequired(){} // RVA: 0x70604F0
        public void InvalidNullValue(){} // RVA: 0x7060580
        public void InvalidTypeException(){} // RVA: 0x7060620
        public void GetParamName(){} // RVA: 0x7060700
    }

    public class Expression : Object
    {
        public object s_lambdaDelegateCache;
        public object s_lambdaFactories;
        public object s_legacyCtorSupportTable;

        // ── Methods ──
        public void Assign(){} // RVA: 0x701F950
        public void GetUserDefinedBinaryOperator(){} // RVA: 0x7020E30
        public void GetMethodBasedBinaryOperator(){} // RVA: 0x701FFA0
        public void GetMethodBasedAssignOperator(){} // RVA: 0x7020620
        public void GetUserDefinedBinaryOperatorOrThrow(){} // RVA: 0x70208F0
        public void GetUserDefinedAssignOperatorOrThrow(){} // RVA: 0x7020B60
        public void IsLiftingConditionalLogicalOperator(){} // RVA: 0x70211E0
        public void ParameterIsAssignable(){} // RVA: 0x70212A0
        public void ValidateParamswithOperandsOrThrow(){} // RVA: 0x7021360
        public void ValidateOperator(){} // RVA: 0x7021450
        public void ValidateMethodInfo(){} // RVA: 0x7021630
        public void IsNullComparison(){} // RVA: 0x70216C0
        public void IsNullConstant(){} // RVA: 0x7021900
        public void ValidateUserDefinedConditionalLogicOperator(){} // RVA: 0x7021970
        public void VerifyOpTrueFalse(){} // RVA: 0x7022210
        public void IsValidLiftedConditionalLogicalOperator(){} // RVA: 0x7022400
        public void MakeBinary(){} // RVA: 0x7022690
        public void Equal(){} // RVA: 0x7023060
        public void ReferenceEqual(){} // RVA: 0x7023190
        public void NotEqual(){} // RVA: 0x70233B0
        public void ReferenceNotEqual(){} // RVA: 0x70234E0
        public void GetEqualityComparisonOperator(){} // RVA: 0x7023690
        public void GreaterThan(){} // RVA: 0x7023C20
        public void LessThan(){} // RVA: 0x7023DC0
        public void GreaterThanOrEqual(){} // RVA: 0x7023F60
        public void LessThanOrEqual(){} // RVA: 0x7024100
        public void GetComparisonOperator(){} // RVA: 0x7024230
        public void AndAlso(){} // RVA: 0x70244F0
        public void OrElse(){} // RVA: 0x7024C90
        public void Coalesce(){} // RVA: 0x70253F0
        public void ValidateCoalesceArgTypes(){} // RVA: 0x70259C0
        public void Add(){} // RVA: 0x7025C70
        public void AddAssign(){} // RVA: 0x7025FB0
        public void ValidateOpAssignConversionLambda(){} // RVA: 0x7026270
        public void AddAssignChecked(){} // RVA: 0x70266D0
        public void AddChecked(){} // RVA: 0x7026A00
        public void Subtract(){} // RVA: 0x7026CD0
        public void SubtractAssign(){} // RVA: 0x7027020
        public void SubtractAssignChecked(){} // RVA: 0x7027410
        public void SubtractChecked(){} // RVA: 0x7027740
        public void Divide(){} // RVA: 0x7027A10
        public void DivideAssign(){} // RVA: 0x7027D60
        public void Modulo(){} // RVA: 0x7028090
        public void ModuloAssign(){} // RVA: 0x70283E0
        public void Multiply(){} // RVA: 0x7028710
        public void MultiplyAssign(){} // RVA: 0x7028A60
        public void MultiplyAssignChecked(){} // RVA: 0x7028E50
        public void MultiplyChecked(){} // RVA: 0x7029180
        public void IsSimpleShift(){} // RVA: 0x70293E0
        public void GetResultTypeOfShift(){} // RVA: 0x70294E0
        public void LeftShift(){} // RVA: 0x70296E0
        public void LeftShiftAssign(){} // RVA: 0x7029A30
        public void RightShift(){} // RVA: 0x7029D50
        public void RightShiftAssign(){} // RVA: 0x702A0A0
        public void And(){} // RVA: 0x702A3C0
        public void AndAssign(){} // RVA: 0x702A710
        public void Or(){} // RVA: 0x702AA40
        public void OrAssign(){} // RVA: 0x702AD90
        public void ExclusiveOr(){} // RVA: 0x702B0C0
        public void ExclusiveOrAssign(){} // RVA: 0x702B410
        public void Power(){} // RVA: 0x702B740
        public void PowerAssign(){} // RVA: 0x702BC40
        public void ArrayIndex(){} // RVA: 0x703EF00
        public void Block(){} // RVA: 0x702CA70
        public void BlockCore(){} // RVA: 0x702CD80
        public void ValidateVariables(){} // RVA: 0x702D230
        public void GetOptimizedBlockExpression(){} // RVA: 0x702D4D0
        public void Catch(){} // RVA: 0x702DB80
        public void MakeCatchBlock(){} // RVA: 0x702DC80
        public void Condition(){} // RVA: 0x702E370
        public void IfThen(){} // RVA: 0x702E690
        public void IfThenElse(){} // RVA: 0x702E770
        public void Constant(){} // RVA: 0x702E8B0
        public void DebugInfo(){} // RVA: 0x702EB30
        public void ClearDebugInfo(){} // RVA: 0x702ECB0
        public void ValidateSpan(){} // RVA: 0x702ED70
        public void Empty(){} // RVA: 0x702EF40
        public void Default(){} // RVA: 0x702EFF0
        public void ElementInit(){} // RVA: 0x702F150
        public void ValidateElementInitAddMethodInfo(){} // RVA: 0x702F3C0
        public void .ctor(){} // RVA: 0xB43310
        public void get_NodeType(){} // RVA: 0x702F950
        public void get_Type(){} // RVA: 0x702FA50
        public void get_CanReduce(){} // RVA: 0xB43320
        public void Reduce(){} // RVA: 0x702FB50
        public void VisitChildren(){} // RVA: 0x702FBA0
        public void Accept(){} // RVA: 0x702FC30
        public void ReduceAndCheck(){} // RVA: 0x702FC60
        public void ReduceExtensions(){} // RVA: 0x702FDC0
        public void ToString(){} // RVA: 0x702FE20
        public void get_DebugView(){} // RVA: 0x702FEB0
        public void RequiresCanRead(){} // RVA: 0x7030040
        public void RequiresCanWrite(){} // RVA: 0x7030170
        public void Dynamic(){} // RVA: 0x70303F0
        public void MakeDynamic(){} // RVA: 0x7030490
        public void Break(){} // RVA: 0x7030700
        public void Continue(){} // RVA: 0x7030840
        public void Return(){} // RVA: 0x7030AB0
        public void Goto(){} // RVA: 0x7030D30
        public void MakeGoto(){} // RVA: 0x7030DB0
        public void ValidateGoto(){} // RVA: 0x7030FC0
        public void ValidateGotoType(){} // RVA: 0x70312E0
        public void MakeIndex(){} // RVA: 0x7031460
        public void ArrayAccess(){} // RVA: 0x7031560
        public void Property(){} // RVA: 0x70397F0
        public void FindInstanceProperty(){} // RVA: 0x7031BE0
        public void GetArgTypesString(){} // RVA: 0x7031D30
        public void FindProperty(){} // RVA: 0x7031F00
        public void IsCompatible(){} // RVA: 0x703EB30
        public void MakeIndexProperty(){} // RVA: 0x7032450
        public void ValidateIndexedProperty(){} // RVA: 0x7032520
        public void ValidateAccessor(){} // RVA: 0x7032BD0
        public void ValidateAccessorArgumentTypes(){} // RVA: 0x7032EA0
        public void Invoke(){} // RVA: 0x7034700
        public void GetInvokeMethod(){} // RVA: 0x7034BB0
        public void Label(){} // RVA: 0x70351D0
        public void CreateLambda(){} // RVA: 0x7035370
        public void Lambda(){} // RVA: 0x7036450
        public void ValidateLambdaArgs(){} // RVA: 0x7036540
        public void ValidateTryGetFuncActionArgs(){} // RVA: 0x7036E20
        public void GetFuncType(){} // RVA: 0x7036F30
        public void TryGetFuncType(){} // RVA: 0x7037090
        public void GetActionType(){} // RVA: 0x70371F0
        public void TryGetActionType(){} // RVA: 0x7037350
        public void GetDelegateType(){} // RVA: 0x70374B0
        public void ListInit(){} // RVA: 0x7037F90
        public void Loop(){} // RVA: 0x7038230
        public void Bind(){} // RVA: 0x70386F0
        public void ValidateSettableFieldOrPropertyMember(){} // RVA: 0x70388A0
        public void Field(){} // RVA: 0x7038ED0
        public void GetProperty(){} // RVA: 0x7039940
        public void CheckMethod(){} // RVA: 0x7039BA0
        public void PropertyOrField(){} // RVA: 0x7039D80
        public void MakeMemberAccess(){} // RVA: 0x703A050
        public void MemberInit(){} // RVA: 0x703A260
        public void ListBind(){} // RVA: 0x703A8F0
        public void ValidateListInitArgs(){} // RVA: 0x703AA40
        public void MemberBind(){} // RVA: 0x703B070
        public void ValidateGettableFieldOrPropertyMember(){} // RVA: 0x703B150
        public void ValidateMemberInitArgs(){} // RVA: 0x703B3A0
        public void Call(){} // RVA: 0x703DC80
        public void ValidateMethodAndGetParameters(){} // RVA: 0x703E2B0
        public void ValidateStaticOrInstanceMethod(){} // RVA: 0x703E4F0
        public void ValidateCallInstanceType(){} // RVA: 0x703E610
        public void ValidateArgumentTypes(){} // RVA: 0x703E6C0
        public void GetParametersForValidation(){} // RVA: 0x703E6D0
        public void ValidateArgumentCount(){} // RVA: 0x703E6E0
        public void ValidateOneArgument(){} // RVA: 0x703E6F0
        public void TryQuote(){} // RVA: 0x703E730
        public void FindMethod(){} // RVA: 0x703E740
        public void ApplyTypeArgs(){} // RVA: 0x703EDD0
        public void NewArrayInit(){} // RVA: 0x703F3C0
        public void NewArrayBounds(){} // RVA: 0x703F9A0
        public void New(){} // RVA: 0x7040460
        public void ValidateNewArgs(){} // RVA: 0x7040890
        public void ValidateAnonymousTypeMember(){} // RVA: 0x7041450
        public void ValidateConstructor(){} // RVA: 0x70417C0
        public void Parameter(){} // RVA: 0x70418E0
        public void Variable(){} // RVA: 0x70419A0
        public void Validate(){} // RVA: 0x7041A10
        public void RuntimeVariables(){} // RVA: 0x7041BC0
        public void SwitchCase(){} // RVA: 0x7041EB0
        public void Switch(){} // RVA: 0x70423B0
        public void ValidateSwitchCaseType(){} // RVA: 0x7043130
        public void SymbolDocument(){} // RVA: 0x7043730
        public void TryFault(){} // RVA: 0x70438B0
        public void TryFinally(){} // RVA: 0x7043920
        public void TryCatch(){} // RVA: 0x7043990
        public void TryCatchFinally(){} // RVA: 0x7043A00
        public void MakeTry(){} // RVA: 0x7043A80
        public void ValidateTryAndCatchHaveSameType(){} // RVA: 0x7043D00
        public void TypeIs(){} // RVA: 0x7044390
        public void TypeEqual(){} // RVA: 0x70444F0
        public void MakeUnary(){} // RVA: 0x70446D0
        public void GetUserDefinedUnaryOperatorOrThrow(){} // RVA: 0x7044DD0
        public void GetUserDefinedUnaryOperator(){} // RVA: 0x7044F70
        public void GetMethodBasedUnaryOperator(){} // RVA: 0x7045310
        public void GetUserDefinedCoercionOrThrow(){} // RVA: 0x7045760
        public void GetUserDefinedCoercion(){} // RVA: 0x70458D0
        public void GetMethodBasedCoercionOperator(){} // RVA: 0x70459D0
        public void Negate(){} // RVA: 0x7045EC0
        public void UnaryPlus(){} // RVA: 0x7046110
        public void NegateChecked(){} // RVA: 0x7046320
        public void Not(){} // RVA: 0x7046570
        public void IsFalse(){} // RVA: 0x70467C0
        public void IsTrue(){} // RVA: 0x70469D0
        public void OnesComplement(){} // RVA: 0x7046BE0
        public void TypeAs(){} // RVA: 0x7046D90
        public void Unbox(){} // RVA: 0x7046F50
        public void Convert(){} // RVA: 0x7047240
        public void ConvertChecked(){} // RVA: 0x7047500
        public void ArrayLength(){} // RVA: 0x7047780
        public void Quote(){} // RVA: 0x7047A10
        public void Rethrow(){} // RVA: 0x7047C20
        public void Throw(){} // RVA: 0x7047D30
        public void Increment(){} // RVA: 0x7047F50
        public void Decrement(){} // RVA: 0x7048160
        public void PreIncrementAssign(){} // RVA: 0x7048370
        public void PreDecrementAssign(){} // RVA: 0x7048440
        public void PostIncrementAssign(){} // RVA: 0x7048510
        public void PostDecrementAssign(){} // RVA: 0x70485E0
        public void MakeOpAssignUnary(){} // RVA: 0x7048650
        public void .cctor(){} // RVA: 0x7048910
    }

    public class Expression0`1 : Expression`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void get_ParameterCount(){} // RVA: 0x87C130
        public void SameParameters(){} // RVA: 0x87D350
        public void GetParameter(){} // RVA: 0x87C160
        public void GetOrMakeParameters(){} // RVA: 0x87C0A0
        public void Rewrite(){} // RVA: 0x87C5F0
    }

    public class Expression1`1 : Expression`1
    {
        public object _par0;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8943B0
        public void get_ParameterCount(){} // RVA: 0x87C130
        public void GetParameter(){} // RVA: 0x87C160
        public void SameParameters(){} // RVA: 0x87D350
        public void GetOrMakeParameters(){} // RVA: 0x87C0A0
        public void Rewrite(){} // RVA: 0x87C5F0
    }

    public class Expression2`1 : Expression`1
    {
        public object _par0;
        public object _par1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8954D0
        public void get_ParameterCount(){} // RVA: 0x87C130
        public void GetParameter(){} // RVA: 0x87C160
        public void SameParameters(){} // RVA: 0x87D350
        public void GetOrMakeParameters(){} // RVA: 0x87C0A0
        public void Rewrite(){} // RVA: 0x87C5F0
    }

    public class Expression3`1 : Expression`1
    {
        public object _par0;
        public object _par1;
        public object _par2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x899870
        public void get_ParameterCount(){} // RVA: 0x87C130
        public void GetParameter(){} // RVA: 0x87C160
        public void SameParameters(){} // RVA: 0x87D350
        public void GetOrMakeParameters(){} // RVA: 0x87C0A0
        public void Rewrite(){} // RVA: 0x87C5F0
    }

    public class ExpressionCreator`1 : Object
    {
        // ── Methods ──
        public void CreateExpressionFunc(){} // RVA: 0x88E0F0
    }

    public class ExpressionExtension : Object
    {
        // ── Methods ──
        public void MakeDynamic(){} // RVA: 0x7058B30
        public void GetValidMethodForDynamic(){} // RVA: 0x7057AA0
        public void Dynamic(){} // RVA: 0x7058940
        public void ValidateDynamicArgument(){} // RVA: 0x70590B0
    }

    public class ExpressionN`1 : Expression`1
    {
        public object _parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8943B0
        public void get_ParameterCount(){} // RVA: 0x87C130
        public void GetParameter(){} // RVA: 0x87C160
        public void SameParameters(){} // RVA: 0x87D350
        public void GetOrMakeParameters(){} // RVA: 0x87C0A0
        public void Rewrite(){} // RVA: 0x87C5F0
    }

    public class ExpressionN`1 : Expression`1
    {
        public object _parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DCCD50
        public void get_ParameterCount(){} // RVA: 0x3DCE270
        public void GetParameter(){} // RVA: 0x3DCE2C0
        public void SameParameters(){} // RVA: 0x3DCE320
        public void GetOrMakeParameters(){} // RVA: 0x3DCE400
        public void Rewrite(){} // RVA: 0x3DCE440
    }

    public class ExpressionStringBuilder : ExpressionVisitor
    {
        public object _out;
        public object _ids;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70607B0
        public void ToString(){} // RVA: 0x1910690
        public void GetLabelId(){} // RVA: 0x7060850
        public void GetParamId(){} // RVA: 0x7060850
        public void GetId(){} // RVA: 0x7060860
        public void Out(){} // RVA: 0x7060A30
        public void ExpressionToString(){} // RVA: 0x702FE20
        public void CatchBlockToString(){} // RVA: 0x704DA40
        public void SwitchCaseToString(){} // RVA: 0x7060A50
        public void MemberBindingToString(){} // RVA: 0x7060AE0
        public void ElementInitBindingToString(){} // RVA: 0x70593D0
        public void VisitExpressions(){} // RVA: 0xA94080
        public void VisitBinary(){} // RVA: 0x7060B70
        public void VisitParameter(){} // RVA: 0x7061420
        public void VisitLambda(){} // RVA: 0x87C540
        public void VisitListInit(){} // RVA: 0x7061590
        public void VisitConditional(){} // RVA: 0x7061760
        public void VisitConstant(){} // RVA: 0x70618E0
        public void VisitDebugInfo(){} // RVA: 0x7061BB0
        public void VisitRuntimeVariables(){} // RVA: 0x7061F20
        public void OutMember(){} // RVA: 0x7061F90
        public void VisitMember(){} // RVA: 0x70620B0
        public void VisitMemberInit(){} // RVA: 0x7062220
        public void VisitMemberAssignment(){} // RVA: 0x7062540
        public void VisitMemberListBinding(){} // RVA: 0x70625F0
        public void VisitMemberMemberBinding(){} // RVA: 0x70627E0
        public void VisitElementInit(){} // RVA: 0x70629D0
        public void VisitInvocation(){} // RVA: 0x7062C00
        public void VisitMethodCall(){} // RVA: 0x7062D90
        public void VisitNewArray(){} // RVA: 0x7063090
        public void VisitNew(){} // RVA: 0x70631E0
        public void VisitTypeBinary(){} // RVA: 0x70634A0
        public void VisitUnary(){} // RVA: 0x7063670
        public void VisitBlock(){} // RVA: 0x7063DD0
        public void VisitDefault(){} // RVA: 0x7064160
        public void VisitLabel(){} // RVA: 0x7064280
        public void VisitGoto(){} // RVA: 0x7064360
        public void VisitLoop(){} // RVA: 0x7064560
        public void VisitSwitchCase(){} // RVA: 0x70645C0
        public void VisitSwitch(){} // RVA: 0x7064680
        public void VisitCatchBlock(){} // RVA: 0x7064790
        public void VisitTry(){} // RVA: 0x7064900
        public void VisitIndex(){} // RVA: 0x7064960
        public void VisitExtension(){} // RVA: 0x7064C30
        public void DumpLabel(){} // RVA: 0x7064F50
        public void IsBool(){} // RVA: 0x7065080
    }

    public class ExpressionVisitor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Visit(){} // RVA: 0x87C630
        public void VisitArguments(){} // RVA: 0x7065550
        public void VisitParameters(){} // RVA: 0x7065560
        public void VisitAndConvert(){} // RVA: 0x87C5F0
        public void VisitBinary(){} // RVA: 0x7065570
        public void VisitBlock(){} // RVA: 0x7065680
        public void VisitConditional(){} // RVA: 0x7065780
        public void VisitConstant(){} // RVA: 0x1CB3B00
        public void VisitDebugInfo(){} // RVA: 0x1CB3B00
        public void VisitDefault(){} // RVA: 0x1CB3B00
        public void VisitExtension(){} // RVA: 0x704E690
        public void VisitGoto(){} // RVA: 0x70658D0
        public void VisitInvocation(){} // RVA: 0x70659D0
        public void VisitLabelTarget(){} // RVA: 0x1CB3B00
        public void VisitLabel(){} // RVA: 0x7065A70
        public void VisitLambda(){} // RVA: 0x87C540
        public void VisitLoop(){} // RVA: 0x7065B40
        public void VisitMember(){} // RVA: 0x7065C40
        public void VisitIndex(){} // RVA: 0x7065CF0
        public void VisitMethodCall(){} // RVA: 0x7065E30
        public void VisitNewArray(){} // RVA: 0x7065F00
        public void VisitNew(){} // RVA: 0x7065F40
        public void VisitParameter(){} // RVA: 0x1CB3B00
        public void VisitRuntimeVariables(){} // RVA: 0x7066070
        public void VisitSwitchCase(){} // RVA: 0x7066170
        public void VisitSwitch(){} // RVA: 0x7066270
        public void VisitCatchBlock(){} // RVA: 0x70664A0
        public void VisitTry(){} // RVA: 0x70665F0
        public void VisitTypeBinary(){} // RVA: 0x70667D0
        public void VisitUnary(){} // RVA: 0x70668B0
        public void VisitMemberInit(){} // RVA: 0x7066A90
        public void VisitListInit(){} // RVA: 0x7066C30
        public void VisitElementInit(){} // RVA: 0x7066DD0
        public void VisitMemberBinding(){} // RVA: 0x7066E60
        public void VisitMemberAssignment(){} // RVA: 0x7067000
        public void VisitMemberMemberBinding(){} // RVA: 0x70670A0
        public void VisitMemberListBinding(){} // RVA: 0x70671F0
        public void ValidateUnary(){} // RVA: 0x7067340
        public void ValidateBinary(){} // RVA: 0x7067450
        public void ValidateSwitch(){} // RVA: 0x70675F0
        public void ValidateChildType(){} // RVA: 0x7067670
        public void VisitDynamic(){} // RVA: 0x7059270
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void get_TypeCore(){} // RVA: 0x87C0A0
        public void get_PublicType(){} // RVA: 0x87C0A0
        public void Compile(){} // RVA: 0xA94080
        public void Update(){} // RVA: 0x87C5F0
        public void SameParameters(){} // RVA: 0x87D350
        public void Rewrite(){} // RVA: 0x87C5F0
        public void Accept(){} // RVA: 0x87C540
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DCEA40
        public void get_TypeCore(){} // RVA: 0x3DCE540
        public void get_PublicType(){} // RVA: 0x3DCE5B0
        public void Compile(){} // RVA: 0xAD0950
        public void Update(){} // RVA: 0x3DCED00
        public void SameParameters(){} // RVA: 0x3DCE950
        public void Rewrite(){} // RVA: 0x3DCE970
        public void Accept(){} // RVA: 0x3DCE990
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DCEA40
        public void get_TypeCore(){} // RVA: 0x3DCE540
        public void get_PublicType(){} // RVA: 0x3DCE5B0
        public void Compile(){} // RVA: 0xAD0950
        public void Update(){} // RVA: 0x3DCED00
        public void SameParameters(){} // RVA: 0x3DCE950
        public void Rewrite(){} // RVA: 0x3DCE970
        public void Accept(){} // RVA: 0x3DCE990
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DCEA40
        public void get_TypeCore(){} // RVA: 0x3DCE540
        public void get_PublicType(){} // RVA: 0x3DCE5B0
        public void Compile(){} // RVA: 0xAD0950
        public void Update(){} // RVA: 0x3DCED00
        public void SameParameters(){} // RVA: 0x3DCE950
        public void Rewrite(){} // RVA: 0x3DCE970
        public void Accept(){} // RVA: 0x3DCE990
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DCEA40
        public void get_TypeCore(){} // RVA: 0x3DCE540
        public void get_PublicType(){} // RVA: 0x3DCE5B0
        public void Compile(){} // RVA: 0xAD0950
        public void Update(){} // RVA: 0x3DCED00
        public void SameParameters(){} // RVA: 0x3DCE950
        public void Rewrite(){} // RVA: 0x3DCE970
        public void Accept(){} // RVA: 0x3DCE990
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DCEA40
        public void get_TypeCore(){} // RVA: 0x3DCE540
        public void get_PublicType(){} // RVA: 0x3DCE5B0
        public void Compile(){} // RVA: 0xAD0950
        public void Update(){} // RVA: 0x3DCED00
        public void SameParameters(){} // RVA: 0x3DCE950
        public void Rewrite(){} // RVA: 0x3DCE970
        public void Accept(){} // RVA: 0x3DCE990
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DCEA40
        public void get_TypeCore(){} // RVA: 0x3DCE540
        public void get_PublicType(){} // RVA: 0x3DCE5B0
        public void Compile(){} // RVA: 0xAD0950
        public void Update(){} // RVA: 0x3DCED00
        public void SameParameters(){} // RVA: 0x3DCE950
        public void Rewrite(){} // RVA: 0x3DCE970
        public void Accept(){} // RVA: 0x3DCE990
    }

}