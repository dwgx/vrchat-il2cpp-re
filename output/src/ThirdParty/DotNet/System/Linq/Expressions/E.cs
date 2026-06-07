// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 13
// Methods: 751

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class ElementInit
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65EB610 | overloaded x2
        public void get_AddMethod(){} // RVA: 0x2F8380
        public void get_Arguments(){} // RVA: 0x2E07C0
        public void GetArgument(){} // RVA: 0x65EB3F0
        public void get_ArgumentCount(){} // RVA: 0x65EB480
        public void ToString(){} // RVA: 0x65EB500
        public void Update(){} // RVA: 0x65EB590
    }

    public class Error
    {
        // ── Methods ──
        public void ReducibleMustOverrideReduce(){} // RVA: 0x65EB640
        public void ArgCntMustBeGreaterThanNameCnt(){} // RVA: 0x65EB6D0
        public void InvalidMetaObjectCreated(){} // RVA: 0x65EB760
        public void AmbiguousMatchInExpandoObject(){} // RVA: 0x65EB800
        public void SameKeyExistsInExpando(){} // RVA: 0x65EB8A0
        public void KeyDoesNotExistInExpando(){} // RVA: 0x65EB950
        public void CollectionModifiedWhileEnumerating(){} // RVA: 0x65EB9F0
        public void CollectionReadOnly(){} // RVA: 0x65EBA80
        public void MustReduceToDifferent(){} // RVA: 0x65EBB10
        public void BinderNotCompatibleWithCallSite(){} // RVA: 0x65EBBA0
        public void DynamicBindingNeedsRestrictions(){} // RVA: 0x65EBC60
        public void DynamicObjectResultNotAssignable(){} // RVA: 0x65EBD00
        public void DynamicBinderResultNotAssignable(){} // RVA: 0x65EBDA0
        public void BindingCannotBeNull(){} // RVA: 0x65EBE60
        public void ReducedNotCompatible(){} // RVA: 0x65EBEF0
        public void SetterHasNoParams(){} // RVA: 0x65EBF80
        public void PropertyCannotHaveRefType(){} // RVA: 0x65EC010
        public void IndexesOfSetGetMustMatch(){} // RVA: 0x65EC0A0
        public void TypeParameterIsNotDelegate(){} // RVA: 0x65EC130
        public void FirstArgumentMustBeCallSite(){} // RVA: 0x65EC1D0
        public void AccessorsCannotHaveVarArgs(){} // RVA: 0x65EC260
        public void AccessorsCannotHaveByRefArgs(){} // RVA: 0x65EC380 | overloaded x2
        public void TypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x65EC420
        public void NoOrInvalidRuleProduced(){} // RVA: 0x65EC4B0
        public void BoundsCannotBeLessThanOne(){} // RVA: 0x65EC540
        public void TypeMustNotBeByRef(){} // RVA: 0x65EC5D0
        public void TypeMustNotBePointer(){} // RVA: 0x65EC660
        public void SetterMustBeVoid(){} // RVA: 0x65EC6F0
        public void PropertyTypeMustMatchGetter(){} // RVA: 0x65EC780
        public void PropertyTypeMustMatchSetter(){} // RVA: 0x65EC810
        public void BothAccessorsMustBeStatic(){} // RVA: 0x65EC8A0
        public void OnlyStaticFieldsHaveNullInstance(){} // RVA: 0x65EC930
        public void OnlyStaticPropertiesHaveNullInstance(){} // RVA: 0x65EC9C0
        public void OnlyStaticMethodsHaveNullInstance(){} // RVA: 0x65ECA50
        public void PropertyTypeCannotBeVoid(){} // RVA: 0x65ECAE0
        public void InvalidUnboxType(){} // RVA: 0x65ECB70
        public void ExpressionMustBeWriteable(){} // RVA: 0x65ECC00
        public void ArgumentMustNotHaveValueType(){} // RVA: 0x65ECC90
        public void MustBeReducible(){} // RVA: 0x65ECD20
        public void AllTestValuesMustHaveSameType(){} // RVA: 0x65ECDB0
        public void AllCaseBodiesMustHaveSameType(){} // RVA: 0x65ECE40
        public void DefaultBodyMustBeSupplied(){} // RVA: 0x65ECED0
        public void LabelMustBeVoidOrHaveExpression(){} // RVA: 0x65ECF60
        public void LabelTypeMustBeVoid(){} // RVA: 0x65ECFF0
        public void QuotedExpressionMustBeLambda(){} // RVA: 0x65ED080
        public void VariableMustNotBeByRef(){} // RVA: 0x65ED1C0 | overloaded x2
        public void DuplicateVariable(){} // RVA: 0x65ED2A0 | overloaded x2
        public void StartEndMustBeOrdered(){} // RVA: 0x65ED360
        public void FaultCannotHaveCatchOrFinally(){} // RVA: 0x65ED3F0
        public void TryMustHaveCatchFinallyOrFault(){} // RVA: 0x65ED480
        public void BodyOfCatchMustHaveSameTypeAsBodyOfTry(){} // RVA: 0x65ED510
        public void ExtensionNodeMustOverrideProperty(){} // RVA: 0x65ED5A0
        public void UserDefinedOperatorMustBeStatic(){} // RVA: 0x65ED640
        public void UserDefinedOperatorMustNotBeVoid(){} // RVA: 0x65ED6E0
        public void CoercionOperatorNotDefined(){} // RVA: 0x65ED780
        public void UnaryOperatorNotDefined(){} // RVA: 0x65ED820
        public void BinaryOperatorNotDefined(){} // RVA: 0x65ED8C0
        public void ReferenceEqualityNotDefined(){} // RVA: 0x65ED980
        public void OperandTypesDoNotMatchParameters(){} // RVA: 0x65EDA20
        public void OverloadOperatorTypeDoesNotMatchConversionType(){} // RVA: 0x65EDAC0
        public void ConversionIsNotSupportedForArithmeticTypes(){} // RVA: 0x65EDB60
        public void ArgumentTypeCannotBeVoid(){} // RVA: 0x65EDBF0
        public void ArgumentMustBeArray(){} // RVA: 0x65EDC80
        public void ArgumentMustBeBoolean(){} // RVA: 0x65EDD10
        public void EqualityMustReturnBoolean(){} // RVA: 0x65EDDA0
        public void ArgumentMustBeFieldInfoOrPropertyInfo(){} // RVA: 0x65EDE40
        public void ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(){} // RVA: 0x65EDF60 | overloaded x2
        public void ArgumentMustBeInstanceMember(){} // RVA: 0x65EE090 | overloaded x2
        public void ArgumentMustBeInteger(){} // RVA: 0x65EE1C0 | overloaded x2
        public void ArgumentMustBeArrayIndexType(){} // RVA: 0x65EE2F0 | overloaded x2
        public void ArgumentMustBeSingleDimensionalArrayType(){} // RVA: 0x65EE310
        public void ArgumentTypesMustMatch(){} // RVA: 0x65EE430 | overloaded x2
        public void CannotAutoInitializeValueTypeElementThroughProperty(){} // RVA: 0x65EE4C0
        public void CannotAutoInitializeValueTypeMemberThroughProperty(){} // RVA: 0x65EE560
        public void IncorrectTypeForTypeAs(){} // RVA: 0x65EE600
        public void CoalesceUsedOnNonNullType(){} // RVA: 0x65EE6A0
        public void ExpressionTypeCannotInitializeArrayType(){} // RVA: 0x65EE730
        public void ArgumentTypeDoesNotMatchMember(){} // RVA: 0x65EE880 | overloaded x2
        public void ArgumentMemberNotDeclOnType(){} // RVA: 0x65EE9F0 | overloaded x2
        public void ExpressionTypeDoesNotMatchReturn(){} // RVA: 0x65EEAB0
        public void ExpressionTypeDoesNotMatchAssignment(){} // RVA: 0x65EEB50
        public void ExpressionTypeDoesNotMatchLabel(){} // RVA: 0x65EEBF0
        public void ExpressionTypeNotInvocable(){} // RVA: 0x65EEC90
        public void FieldNotDefinedForType(){} // RVA: 0x65EED30
        public void InstanceFieldNotDefinedForType(){} // RVA: 0x65EEDD0
        public void FieldInfoNotDefinedForType(){} // RVA: 0x65EEE70
        public void IncorrectNumberOfIndexes(){} // RVA: 0x65EEF30
        public void IncorrectNumberOfLambdaDeclarationParameters(){} // RVA: 0x65EEFC0
        public void IncorrectNumberOfMembersForGivenConstructor(){} // RVA: 0x65EF050
        public void IncorrectNumberOfArgumentsForMembers(){} // RVA: 0x65EF0E0
        public void LambdaTypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x65EF170
        public void MemberNotFieldOrProperty(){} // RVA: 0x65EF200
        public void MethodContainsGenericParameters(){} // RVA: 0x65EF2A0
        public void MethodIsGeneric(){} // RVA: 0x65EF340
        public void MethodNotPropertyAccessor(){} // RVA: 0x65EF490 | overloaded x2
        public void PropertyDoesNotHaveGetter(){} // RVA: 0x65EF5F0 | overloaded x2
        public void PropertyDoesNotHaveSetter(){} // RVA: 0x65EF620
        public void PropertyDoesNotHaveAccessor(){} // RVA: 0x65EF6C0
        public void NotAMemberOfType(){} // RVA: 0x65EF810 | overloaded x2
        public void NotAMemberOfAnyType(){} // RVA: 0x65EF850
        public void ParameterExpressionNotValidAsDelegate(){} // RVA: 0x65EF8F0
        public void PropertyNotDefinedForType(){} // RVA: 0x65EF990
        public void InstancePropertyNotDefinedForType(){} // RVA: 0x65EFA40
        public void InstancePropertyWithoutParameterNotDefinedForType(){} // RVA: 0x65EFAF0
        public void InstancePropertyWithSpecifiedParametersNotDefinedForType(){} // RVA: 0x65EFB90
        public void InstanceAndMethodTypeMismatch(){} // RVA: 0x65EFC50
        public void TypeMissingDefaultConstructor(){} // RVA: 0x65EFD10
        public void ElementInitializerMethodNotAdd(){} // RVA: 0x65EFDB0
        public void ElementInitializerMethodNoRefOutParam(){} // RVA: 0x65EFE40
        public void ElementInitializerMethodWithZeroArgs(){} // RVA: 0x65EFEF0
        public void ElementInitializerMethodStatic(){} // RVA: 0x65EFF80
        public void TypeNotIEnumerable(){} // RVA: 0x65F0010
        public void UnhandledBinary(){} // RVA: 0x65F00B0
        public void UnhandledBinding(){} // RVA: 0x65F0150
        public void UnhandledBindingType(){} // RVA: 0x65F01E0
        public void UnhandledUnary(){} // RVA: 0x65F0280
        public void UnknownBindingType(){} // RVA: 0x65F0320
        public void UserDefinedOpMustHaveConsistentTypes(){} // RVA: 0x65F0440
        public void UserDefinedOpMustHaveValidReturnType(){} // RVA: 0x65F04E0
        public void LogicalOperatorMustHaveBooleanOperators(){} // RVA: 0x65F0580
        public void MethodWithArgsDoesNotExistOnType(){} // RVA: 0x65F0620
        public void GenericMethodWithArgsDoesNotExistOnType(){} // RVA: 0x65F06C0
        public void MethodWithMoreThanOneMatch(){} // RVA: 0x65F0760
        public void PropertyWithMoreThanOneMatch(){} // RVA: 0x65F0800
        public void IncorrectNumberOfTypeArgsForFunc(){} // RVA: 0x65F08A0
        public void IncorrectNumberOfTypeArgsForAction(){} // RVA: 0x65F0930
        public void ArgumentCannotBeOfTypeVoid(){} // RVA: 0x65F09C0
        public void OutOfRange(){} // RVA: 0x65F0A50
        public void LabelTargetAlreadyDefined(){} // RVA: 0x65F0B00
        public void LabelTargetUndefined(){} // RVA: 0x65F0BA0
        public void ControlCannotLeaveFinally(){} // RVA: 0x65F0C40
        public void ControlCannotLeaveFilterTest(){} // RVA: 0x65F0CD0
        public void AmbiguousJump(){} // RVA: 0x65F0D60
        public void ControlCannotEnterTry(){} // RVA: 0x65F0E00
        public void ControlCannotEnterExpression(){} // RVA: 0x65F0E90
        public void NonLocalJumpWithValue(){} // RVA: 0x65F0F20
        public void InvalidLvalue(){} // RVA: 0x65F0FC0
        public void UndefinedVariable(){} // RVA: 0x65F1080
        public void CannotCloseOverByRef(){} // RVA: 0x65F1140
        public void UnexpectedVarArgsCall(){} // RVA: 0x65F11E0
        public void RethrowRequiresCatch(){} // RVA: 0x65F1280
        public void TryNotAllowedInFilter(){} // RVA: 0x65F1310
        public void MustRewriteToSameNode(){} // RVA: 0x65F13A0
        public void MustRewriteChildToSameType(){} // RVA: 0x65F1460
        public void MustRewriteWithoutMethod(){} // RVA: 0x65F1520
        public void TryNotSupportedForMethodsWithRefArgs(){} // RVA: 0x65F15C0
        public void TryNotSupportedForValueTypeInstances(){} // RVA: 0x65F1660
        public void TestValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x65F1700
        public void SwitchValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x65F17A0
        public void ArgumentOutOfRange(){} // RVA: 0x65F1840
        public void NotSupported(){} // RVA: 0x65F18D0
        public void NonStaticConstructorRequired(){} // RVA: 0x65F1950
        public void NonAbstractConstructorRequired(){} // RVA: 0x65F19E0
        public void InvalidProgram(){} // RVA: 0x65F1A70
        public void EnumerationIsDone(){} // RVA: 0x65F1AF0
        public void TypeContainsGenericParameters(){} // RVA: 0x65F1C20 | overloaded x2
        public void TypeIsGeneric(){} // RVA: 0x65F1D80 | overloaded x2
        public void IncorrectNumberOfConstructorArguments(){} // RVA: 0x65F1E40
        public void ExpressionTypeDoesNotMatchMethodParameter(){} // RVA: 0x65F1F90 | overloaded x2
        public void ExpressionTypeDoesNotMatchParameter(){} // RVA: 0x65F2110 | overloaded x2
        public void IncorrectNumberOfLambdaArguments(){} // RVA: 0x65F21D0
        public void IncorrectNumberOfMethodCallArguments(){} // RVA: 0x65F2260
        public void ExpressionTypeDoesNotMatchConstructorParameter(){} // RVA: 0x65F23B0 | overloaded x2
        public void ExpressionMustBeReadable(){} // RVA: 0x65F2500 | overloaded x2
        public void InvalidArgumentValue(){} // RVA: 0x65F25A0
        public void NonEmptyCollectionRequired(){} // RVA: 0x65F2630
        public void InvalidNullValue(){} // RVA: 0x65F26C0
        public void InvalidTypeException(){} // RVA: 0x65F2760
        public void GetParamName(){} // RVA: 0x65F2840
    }

    public class Expression
    {
        // ── Methods ──
        public void Assign(){} // RVA: 0x65B1240
        public void GetUserDefinedBinaryOperator(){} // RVA: 0x65B2760 | overloaded x2
        public void GetMethodBasedBinaryOperator(){} // RVA: 0x65B18B0
        public void GetMethodBasedAssignOperator(){} // RVA: 0x65B1F50
        public void GetUserDefinedBinaryOperatorOrThrow(){} // RVA: 0x65B2220
        public void GetUserDefinedAssignOperatorOrThrow(){} // RVA: 0x65B2490
        public void IsLiftingConditionalLogicalOperator(){} // RVA: 0x65B2B40
        public void ParameterIsAssignable(){} // RVA: 0x65B2C00
        public void ValidateParamswithOperandsOrThrow(){} // RVA: 0x65B2CC0
        public void ValidateOperator(){} // RVA: 0x65B2DB0
        public void ValidateMethodInfo(){} // RVA: 0x65B2F90
        public void IsNullComparison(){} // RVA: 0x65B3020
        public void IsNullConstant(){} // RVA: 0x65B32A0
        public void ValidateUserDefinedConditionalLogicOperator(){} // RVA: 0x65B3330
        public void VerifyOpTrueFalse(){} // RVA: 0x65B3AE0
        public void IsValidLiftedConditionalLogicalOperator(){} // RVA: 0x65B3CD0
        public void MakeBinary(){} // RVA: 0x65B3FA0 | overloaded x3
        public void Equal(){} // RVA: 0x65B4970 | overloaded x2
        public void ReferenceEqual(){} // RVA: 0x65B4AA0
        public void NotEqual(){} // RVA: 0x65B4CC0 | overloaded x2
        public void ReferenceNotEqual(){} // RVA: 0x65B4DF0
        public void GetEqualityComparisonOperator(){} // RVA: 0x65B4FA0
        public void GreaterThan(){} // RVA: 0x65B54A0 | overloaded x2
        public void LessThan(){} // RVA: 0x65B5640 | overloaded x2
        public void GreaterThanOrEqual(){} // RVA: 0x65B57E0 | overloaded x2
        public void LessThanOrEqual(){} // RVA: 0x65B5980 | overloaded x2
        public void GetComparisonOperator(){} // RVA: 0x65B5AB0
        public void AndAlso(){} // RVA: 0x65B5D80 | overloaded x2
        public void OrElse(){} // RVA: 0x65B6510 | overloaded x2
        public void Coalesce(){} // RVA: 0x65B6C60 | overloaded x2
        public void ValidateCoalesceArgTypes(){} // RVA: 0x65B7200
        public void Add(){} // RVA: 0x65B74B0 | overloaded x2
        public void AddAssign(){} // RVA: 0x65B7800 | overloaded x3
        public void ValidateOpAssignConversionLambda(){} // RVA: 0x65B7AD0
        public void AddAssignChecked(){} // RVA: 0x65B7F70 | overloaded x3
        public void AddChecked(){} // RVA: 0x65B82B0 | overloaded x2
        public void Subtract(){} // RVA: 0x65B8590 | overloaded x2
        public void SubtractAssign(){} // RVA: 0x65B88F0 | overloaded x3
        public void SubtractAssignChecked(){} // RVA: 0x65B8CF0 | overloaded x3
        public void SubtractChecked(){} // RVA: 0x65B9030 | overloaded x2
        public void Divide(){} // RVA: 0x65B9310 | overloaded x2
        public void DivideAssign(){} // RVA: 0x65B9670 | overloaded x3
        public void Modulo(){} // RVA: 0x65B99B0 | overloaded x2
        public void ModuloAssign(){} // RVA: 0x65B9D10 | overloaded x3
        public void Multiply(){} // RVA: 0x65BA050 | overloaded x2
        public void MultiplyAssign(){} // RVA: 0x65BA3B0 | overloaded x3
        public void MultiplyAssignChecked(){} // RVA: 0x65BA7B0 | overloaded x3
        public void MultiplyChecked(){} // RVA: 0x65BAAF0 | overloaded x2
        public void IsSimpleShift(){} // RVA: 0x65BAD60
        public void GetResultTypeOfShift(){} // RVA: 0x65BAE40
        public void LeftShift(){} // RVA: 0x65BB030 | overloaded x2
        public void LeftShiftAssign(){} // RVA: 0x65BB380 | overloaded x3
        public void RightShift(){} // RVA: 0x65BB6A0 | overloaded x2
        public void RightShiftAssign(){} // RVA: 0x65BB9F0 | overloaded x3
        public void And(){} // RVA: 0x65BBD10 | overloaded x2
        public void AndAssign(){} // RVA: 0x65BC070 | overloaded x3
        public void Or(){} // RVA: 0x65BC3B0 | overloaded x2
        public void OrAssign(){} // RVA: 0x65BC710 | overloaded x3
        public void ExclusiveOr(){} // RVA: 0x65BCA50 | overloaded x2
        public void ExclusiveOrAssign(){} // RVA: 0x65BCDB0 | overloaded x3
        public void Power(){} // RVA: 0x65BD0F0 | overloaded x2
        public void PowerAssign(){} // RVA: 0x65BD600 | overloaded x3
        public void ArrayIndex(){} // RVA: 0x65D0B10 | overloaded x3
        public void Block(){} // RVA: 0x65BE470 | overloaded x12
        public void BlockCore(){} // RVA: 0x65BE790
        public void ValidateVariables(){} // RVA: 0x65BEC00
        public void GetOptimizedBlockExpression(){} // RVA: 0x65BEEA0
        public void Catch(){} // RVA: 0x65BF570 | overloaded x4
        public void MakeCatchBlock(){} // RVA: 0x65BF670
        public void Condition(){} // RVA: 0x65BFDD0 | overloaded x2
        public void IfThen(){} // RVA: 0x65C0110
        public void IfThenElse(){} // RVA: 0x65C0230
        public void Constant(){} // RVA: 0x65C03B0 | overloaded x2
        public void DebugInfo(){} // RVA: 0x65C0630
        public void ClearDebugInfo(){} // RVA: 0x65C07B0
        public void ValidateSpan(){} // RVA: 0x65C0870
        public void Empty(){} // RVA: 0x65C0A60
        public void Default(){} // RVA: 0x65C0B50
        public void ElementInit(){} // RVA: 0x65C0CB0 | overloaded x2
        public void ValidateElementInitAddMethodInfo(){} // RVA: 0x65C0F10
        public void .ctor(){} // RVA: 0x2DD310 | overloaded x2
        public void get_NodeType(){} // RVA: 0x65C1490
        public void get_Type(){} // RVA: 0x65C1590
        public void get_CanReduce(){} // RVA: 0x2DD320
        public void Reduce(){} // RVA: 0x65C1690
        public void VisitChildren(){} // RVA: 0x65C16E0
        public void Accept(){} // RVA: 0x65C1770
        public void ReduceAndCheck(){} // RVA: 0x65C17A0
        public void ReduceExtensions(){} // RVA: 0x65C1900
        public void ToString(){} // RVA: 0x65C1960
        public void get_DebugView(){} // RVA: 0x65C19F0
        public void RequiresCanRead(){} // RVA: 0x65C1B80
        public void RequiresCanWrite(){} // RVA: 0x65C1CB0
        public void Dynamic(){} // RVA: 0x65C1F40 | overloaded x6
        public void MakeDynamic(){} // RVA: 0x65C1FE0 | overloaded x6
        public void Break(){} // RVA: 0x65C22D0 | overloaded x4
        public void Continue(){} // RVA: 0x65C2450 | overloaded x2
        public void Return(){} // RVA: 0x65C2740 | overloaded x4
        public void Goto(){} // RVA: 0x65C2A40 | overloaded x4
        public void MakeGoto(){} // RVA: 0x65C2AC0
        public void ValidateGoto(){} // RVA: 0x65C2CD0
        public void ValidateGotoType(){} // RVA: 0x65C2E90
        public void MakeIndex(){} // RVA: 0x65C3050
        public void ArrayAccess(){} // RVA: 0x65C3150 | overloaded x2
        public void Property(){} // RVA: 0x65CB460 | overloaded x7
        public void FindInstanceProperty(){} // RVA: 0x65C3810
        public void GetArgTypesString(){} // RVA: 0x65C3960
        public void FindProperty(){} // RVA: 0x65C3B20
        public void IsCompatible(){} // RVA: 0x65D0740 | overloaded x2
        public void MakeIndexProperty(){} // RVA: 0x65C4060
        public void ValidateIndexedProperty(){} // RVA: 0x65C4130
        public void ValidateAccessor(){} // RVA: 0x65C47C0
        public void ValidateAccessorArgumentTypes(){} // RVA: 0x65C4A90
        public void Invoke(){} // RVA: 0x65C62D0 | overloaded x8
        public void GetInvokeMethod(){} // RVA: 0x65C6780
        public void Label(){} // RVA: 0x65C6E20 | overloaded x6
        public void CreateLambda(){} // RVA: 0x65C6FC0
        public void Lambda(){} // RVA: 0x65C8070 | overloaded x18
        public void ValidateLambdaArgs(){} // RVA: 0x65C8160
        public void ValidateTryGetFuncActionArgs(){} // RVA: 0x65C8A40
        public void GetFuncType(){} // RVA: 0x65C8B70
        public void TryGetFuncType(){} // RVA: 0x65C8CE0
        public void GetActionType(){} // RVA: 0x65C8E50
        public void TryGetActionType(){} // RVA: 0x65C8FC0
        public void GetDelegateType(){} // RVA: 0x65C9130
        public void ListInit(){} // RVA: 0x65C9C10 | overloaded x6
        public void Loop(){} // RVA: 0x65C9EB0 | overloaded x3
        public void Bind(){} // RVA: 0x65CA350 | overloaded x2
        public void ValidateSettableFieldOrPropertyMember(){} // RVA: 0x65CA500
        public void Field(){} // RVA: 0x65CAB40 | overloaded x3
        public void GetProperty(){} // RVA: 0x65CB5B0
        public void CheckMethod(){} // RVA: 0x65CB810
        public void PropertyOrField(){} // RVA: 0x65CB9F0
        public void MakeMemberAccess(){} // RVA: 0x65CBCC0
        public void MemberInit(){} // RVA: 0x65CBED0 | overloaded x2
        public void ListBind(){} // RVA: 0x65CC560 | overloaded x4
        public void ValidateListInitArgs(){} // RVA: 0x65CC6B0
        public void MemberBind(){} // RVA: 0x65CCD10 | overloaded x4
        public void ValidateGettableFieldOrPropertyMember(){} // RVA: 0x65CCDF0
        public void ValidateMemberInitArgs(){} // RVA: 0x65CD050
        public void Call(){} // RVA: 0x65CF930 | overloaded x16
        public void ValidateMethodAndGetParameters(){} // RVA: 0x65CFF40
        public void ValidateStaticOrInstanceMethod(){} // RVA: 0x65D0180
        public void ValidateCallInstanceType(){} // RVA: 0x65D02A0
        public void ValidateArgumentTypes(){} // RVA: 0x65D0350
        public void GetParametersForValidation(){} // RVA: 0x65D0360
        public void ValidateArgumentCount(){} // RVA: 0x65D0370
        public void ValidateOneArgument(){} // RVA: 0x65D0380
        public void TryQuote(){} // RVA: 0x65D03C0
        public void FindMethod(){} // RVA: 0x65D03D0
        public void ApplyTypeArgs(){} // RVA: 0x65D09E0
        public void NewArrayInit(){} // RVA: 0x65D1010 | overloaded x2
        public void NewArrayBounds(){} // RVA: 0x65D1630 | overloaded x2
        public void New(){} // RVA: 0x65D2110 | overloaded x6
        public void ValidateNewArgs(){} // RVA: 0x65D2580
        public void ValidateAnonymousTypeMember(){} // RVA: 0x65D3080
        public void ValidateConstructor(){} // RVA: 0x65D3430
        public void Parameter(){} // RVA: 0x65D3550 | overloaded x2
        public void Variable(){} // RVA: 0x65D3610 | overloaded x2
        public void Validate(){} // RVA: 0x65D3680
        public void RuntimeVariables(){} // RVA: 0x65D3870 | overloaded x2
        public void SwitchCase(){} // RVA: 0x65D3B60 | overloaded x2
        public void Switch(){} // RVA: 0x65D4060 | overloaded x6
        public void ValidateSwitchCaseType(){} // RVA: 0x65D4DF0
        public void SymbolDocument(){} // RVA: 0x65D51C0 | overloaded x4
        public void TryFault(){} // RVA: 0x65D5290
        public void TryFinally(){} // RVA: 0x65D5300
        public void TryCatch(){} // RVA: 0x65D5370
        public void TryCatchFinally(){} // RVA: 0x65D53E0
        public void MakeTry(){} // RVA: 0x65D5460
        public void ValidateTryAndCatchHaveSameType(){} // RVA: 0x65D56E0
        public void TypeIs(){} // RVA: 0x65D5D50
        public void TypeEqual(){} // RVA: 0x65D5EB0
        public void MakeUnary(){} // RVA: 0x65D6090 | overloaded x2
        public void GetUserDefinedUnaryOperatorOrThrow(){} // RVA: 0x65D6780
        public void GetUserDefinedUnaryOperator(){} // RVA: 0x65D6920
        public void GetMethodBasedUnaryOperator(){} // RVA: 0x65D6CC0
        public void GetUserDefinedCoercionOrThrow(){} // RVA: 0x65D7110
        public void GetUserDefinedCoercion(){} // RVA: 0x65D7280
        public void GetMethodBasedCoercionOperator(){} // RVA: 0x65D7380
        public void Negate(){} // RVA: 0x65D7890 | overloaded x2
        public void UnaryPlus(){} // RVA: 0x65D7AE0 | overloaded x2
        public void NegateChecked(){} // RVA: 0x65D7CF0 | overloaded x2
        public void Not(){} // RVA: 0x65D7F40 | overloaded x2
        public void IsFalse(){} // RVA: 0x65D8190 | overloaded x2
        public void IsTrue(){} // RVA: 0x65D83A0 | overloaded x2
        public void OnesComplement(){} // RVA: 0x65D85B0 | overloaded x2
        public void TypeAs(){} // RVA: 0x65D8760
        public void Unbox(){} // RVA: 0x65D8920
        public void Convert(){} // RVA: 0x65D8C00 | overloaded x2
        public void ConvertChecked(){} // RVA: 0x65D8EC0 | overloaded x2
        public void ArrayLength(){} // RVA: 0x65D9140
        public void Quote(){} // RVA: 0x65D9390
        public void Rethrow(){} // RVA: 0x65D9700 | overloaded x2
        public void Throw(){} // RVA: 0x65D9940 | overloaded x2
        public void Increment(){} // RVA: 0x65D9B60 | overloaded x2
        public void Decrement(){} // RVA: 0x65D9D70 | overloaded x2
        public void PreIncrementAssign(){} // RVA: 0x65D9F80 | overloaded x2
        public void PreDecrementAssign(){} // RVA: 0x65DA050 | overloaded x2
        public void PostIncrementAssign(){} // RVA: 0x65DA120 | overloaded x2
        public void PostDecrementAssign(){} // RVA: 0x65DA1F0 | overloaded x2
        public void MakeOpAssignUnary(){} // RVA: 0x65DA260
        public void .cctor(){} // RVA: 0x65DA520
    }

    public class Expression0`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void get_ParameterCount(){} // RVA: 0xD840
        public void SameParameters(){} // RVA: 0xDE40
        public void GetParameter(){} // RVA: 0x1BCC0
        public void GetOrMakeParameters(){} // RVA: 0xCD60
        public void Rewrite(){} // RVA: 0x1E6A0
    }

    public class Expression1`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DC60
        public void get_ParameterCount(){} // RVA: 0xD840
        public void GetParameter(){} // RVA: 0x1BCC0
        public void SameParameters(){} // RVA: 0xDE40
        public void GetOrMakeParameters(){} // RVA: 0xCD60
        public void Rewrite(){} // RVA: 0x1E6A0
    }

    public class Expression2`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2F090
        public void get_ParameterCount(){} // RVA: 0xD840
        public void GetParameter(){} // RVA: 0x1BCC0
        public void SameParameters(){} // RVA: 0xDE40
        public void GetOrMakeParameters(){} // RVA: 0xCD60
        public void Rewrite(){} // RVA: 0x1E6A0
    }

    public class Expression3`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2F9F0
        public void get_ParameterCount(){} // RVA: 0xD840
        public void GetParameter(){} // RVA: 0x1BCC0
        public void SameParameters(){} // RVA: 0xDE40
        public void GetOrMakeParameters(){} // RVA: 0xCD60
        public void Rewrite(){} // RVA: 0x1E6A0
    }

    public class ExpressionCreator`1
    {
        // ── Methods ──
        public void CreateExpressionFunc(){} // RVA: 0x1E910
    }

    public class ExpressionExtension
    {
        // ── Methods ──
        public void MakeDynamic(){} // RVA: 0x65EAC20 | overloaded x7
        public void GetValidMethodForDynamic(){} // RVA: 0x65E9AF0
        public void Dynamic(){} // RVA: 0x65EAA30 | overloaded x6
        public void ValidateDynamicArgument(){} // RVA: 0x65EB1A0 | overloaded x2
    }

    public class ExpressionN`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DC60
        public void get_ParameterCount(){} // RVA: 0xD840
        public void GetParameter(){} // RVA: 0x1BCC0
        public void SameParameters(){} // RVA: 0xDE40
        public void GetOrMakeParameters(){} // RVA: 0xCD60
        public void Rewrite(){} // RVA: 0x1E6A0
    }

    public class ExpressionStringBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65F2900
        public void ToString(){} // RVA: 0x104C4B0
        public void GetLabelId(){} // RVA: 0x65F29A0
        public void GetParamId(){} // RVA: 0x65F29A0
        public void GetId(){} // RVA: 0x65F29B0
        public void Out(){} // RVA: 0x65F2B80 | overloaded x2
        public void ExpressionToString(){} // RVA: 0x65C1960
        public void CatchBlockToString(){} // RVA: 0x65DF6D0
        public void SwitchCaseToString(){} // RVA: 0x65F2BA0
        public void MemberBindingToString(){} // RVA: 0x65F2C30
        public void ElementInitBindingToString(){} // RVA: 0x65EB500
        public void VisitExpressions(){} // RVA: 0x283FA0 | overloaded x2
        public void VisitBinary(){} // RVA: 0x65F2CC0
        public void VisitParameter(){} // RVA: 0x65F3560
        public void VisitLambda(){} // RVA: 0xCE10
        public void VisitListInit(){} // RVA: 0x65F36D0
        public void VisitConditional(){} // RVA: 0x65F38A0
        public void VisitConstant(){} // RVA: 0x65F3A20
        public void VisitDebugInfo(){} // RVA: 0x65F3D00
        public void VisitRuntimeVariables(){} // RVA: 0x65F4080
        public void OutMember(){} // RVA: 0x65F40F0
        public void VisitMember(){} // RVA: 0x65F4210
        public void VisitMemberInit(){} // RVA: 0x65F4380
        public void VisitMemberAssignment(){} // RVA: 0x65F46A0
        public void VisitMemberListBinding(){} // RVA: 0x65F4750
        public void VisitMemberMemberBinding(){} // RVA: 0x65F4940
        public void VisitElementInit(){} // RVA: 0x65F4B30
        public void VisitInvocation(){} // RVA: 0x65F4D60
        public void VisitMethodCall(){} // RVA: 0x65F4EF0
        public void VisitNewArray(){} // RVA: 0x65F5230
        public void VisitNew(){} // RVA: 0x65F5380
        public void VisitTypeBinary(){} // RVA: 0x65F5640
        public void VisitUnary(){} // RVA: 0x65F5810
        public void VisitBlock(){} // RVA: 0x65F5F70
        public void VisitDefault(){} // RVA: 0x65F62F0
        public void VisitLabel(){} // RVA: 0x65F6410
        public void VisitGoto(){} // RVA: 0x65F64F0
        public void VisitLoop(){} // RVA: 0x65F66F0
        public void VisitSwitchCase(){} // RVA: 0x65F6750
        public void VisitSwitch(){} // RVA: 0x65F6810
        public void VisitCatchBlock(){} // RVA: 0x65F6920
        public void VisitTry(){} // RVA: 0x65F6A90
        public void VisitIndex(){} // RVA: 0x65F6AF0
        public void VisitExtension(){} // RVA: 0x65F6DC0
        public void DumpLabel(){} // RVA: 0x65F7110
        public void IsBool(){} // RVA: 0x65F7240
    }

    public class ExpressionVisitor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Visit(){} // RVA: 0xCEC0 | overloaded x3
        public void VisitArguments(){} // RVA: 0x65F7720
        public void VisitParameters(){} // RVA: 0x65F7730
        public void VisitAndConvert(){} // RVA: 0x1E6A0 | overloaded x2
        public void VisitBinary(){} // RVA: 0x65F7740
        public void VisitBlock(){} // RVA: 0x65F7850
        public void VisitConditional(){} // RVA: 0x65F7950
        public void VisitConstant(){} // RVA: 0x13DCE00
        public void VisitDebugInfo(){} // RVA: 0x13DCE00
        public void VisitDefault(){} // RVA: 0x13DCE00
        public void VisitExtension(){} // RVA: 0x65E0300
        public void VisitGoto(){} // RVA: 0x65F7AA0
        public void VisitInvocation(){} // RVA: 0x65F7BA0
        public void VisitLabelTarget(){} // RVA: 0x13DCE00
        public void VisitLabel(){} // RVA: 0x65F7C40
        public void VisitLambda(){} // RVA: 0xCE10
        public void VisitLoop(){} // RVA: 0x65F7D10
        public void VisitMember(){} // RVA: 0x65F7E10
        public void VisitIndex(){} // RVA: 0x65F7EC0
        public void VisitMethodCall(){} // RVA: 0x65F8010
        public void VisitNewArray(){} // RVA: 0x65F80E0
        public void VisitNew(){} // RVA: 0x65F8120
        public void VisitParameter(){} // RVA: 0x13DCE00
        public void VisitRuntimeVariables(){} // RVA: 0x65F8250
        public void VisitSwitchCase(){} // RVA: 0x65F8350
        public void VisitSwitch(){} // RVA: 0x65F8450
        public void VisitCatchBlock(){} // RVA: 0x65F8680
        public void VisitTry(){} // RVA: 0x65F87D0
        public void VisitTypeBinary(){} // RVA: 0x65F89B0
        public void VisitUnary(){} // RVA: 0x65F8A90
        public void VisitMemberInit(){} // RVA: 0x65F8C70
        public void VisitListInit(){} // RVA: 0x65F8E10
        public void VisitElementInit(){} // RVA: 0x65F8FB0
        public void VisitMemberBinding(){} // RVA: 0x65F9040
        public void VisitMemberAssignment(){} // RVA: 0x65F91E0
        public void VisitMemberMemberBinding(){} // RVA: 0x65F9280
        public void VisitMemberListBinding(){} // RVA: 0x65F93D0
        public void ValidateUnary(){} // RVA: 0x65F9520
        public void ValidateBinary(){} // RVA: 0x65F9630
        public void ValidateSwitch(){} // RVA: 0x65F97D0
        public void ValidateChildType(){} // RVA: 0x65F9850
        public void VisitDynamic(){} // RVA: 0x65EB3A0
    }

    public class Expression`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x331D400 | overloaded x2
        public void get_TypeCore(){} // RVA: 0x331D410
        public void get_PublicType(){} // RVA: 0x331D4C0
        public void Compile(){} // RVA: 0x263BC0 | overloaded x3
        public void Update(){} // RVA: 0x331D820
        public void SameParameters(){} // RVA: 0x331D310
        public void Rewrite(){} // RVA: 0x331D330
        public void Accept(){} // RVA: 0x331D350
    }

}