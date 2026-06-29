// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 20
// Methods: 565

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class ElementInit : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3D9E20
        public void get_AddMethod(){} // RVA: 0x7A80F2570
        public void get_Arguments(){} // RVA: 0x7A80DA7B0
        public void GetArgument(){} // RVA: 0x7AE3D9C00
        public void get_ArgumentCount(){} // RVA: 0x7AE3D9C90
        public void ToString(){} // RVA: 0x7AE3D9D10
        public void Update(){} // RVA: 0x7AE3D9DA0
    }

    public class Error : Object
    {
        // ── Methods ──
        public void ReducibleMustOverrideReduce(){} // RVA: 0x7AE3D9E50
        public void ArgCntMustBeGreaterThanNameCnt(){} // RVA: 0x7AE3D9EE0
        public void InvalidMetaObjectCreated(){} // RVA: 0x7AE3D9F70
        public void AmbiguousMatchInExpandoObject(){} // RVA: 0x7AE3DA010
        public void SameKeyExistsInExpando(){} // RVA: 0x7AE3DA0B0
        public void KeyDoesNotExistInExpando(){} // RVA: 0x7AE3DA160
        public void CollectionModifiedWhileEnumerating(){} // RVA: 0x7AE3DA200
        public void CollectionReadOnly(){} // RVA: 0x7AE3DA290
        public void MustReduceToDifferent(){} // RVA: 0x7AE3DA320
        public void BinderNotCompatibleWithCallSite(){} // RVA: 0x7AE3DA3B0
        public void DynamicBindingNeedsRestrictions(){} // RVA: 0x7AE3DA470
        public void DynamicObjectResultNotAssignable(){} // RVA: 0x7AE3DA510
        public void DynamicBinderResultNotAssignable(){} // RVA: 0x7AE3DA5B0
        public void BindingCannotBeNull(){} // RVA: 0x7AE3DA670
        public void ReducedNotCompatible(){} // RVA: 0x7AE3DA700
        public void SetterHasNoParams(){} // RVA: 0x7AE3DA790
        public void PropertyCannotHaveRefType(){} // RVA: 0x7AE3DA820
        public void IndexesOfSetGetMustMatch(){} // RVA: 0x7AE3DA8B0
        public void TypeParameterIsNotDelegate(){} // RVA: 0x7AE3DA940
        public void FirstArgumentMustBeCallSite(){} // RVA: 0x7AE3DA9E0
        public void AccessorsCannotHaveVarArgs(){} // RVA: 0x7AE3DAA70
        public void AccessorsCannotHaveByRefArgs(){} // RVA: 0x7AE3DAB90
        public void TypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x7AE3DAC30
        public void NoOrInvalidRuleProduced(){} // RVA: 0x7AE3DACC0
        public void BoundsCannotBeLessThanOne(){} // RVA: 0x7AE3DAD50
        public void TypeMustNotBeByRef(){} // RVA: 0x7AE3DADE0
        public void TypeMustNotBePointer(){} // RVA: 0x7AE3DAE70
        public void SetterMustBeVoid(){} // RVA: 0x7AE3DAF00
        public void PropertyTypeMustMatchGetter(){} // RVA: 0x7AE3DAF90
        public void PropertyTypeMustMatchSetter(){} // RVA: 0x7AE3DB020
        public void BothAccessorsMustBeStatic(){} // RVA: 0x7AE3DB0B0
        public void OnlyStaticFieldsHaveNullInstance(){} // RVA: 0x7AE3DB140
        public void OnlyStaticPropertiesHaveNullInstance(){} // RVA: 0x7AE3DB1D0
        public void OnlyStaticMethodsHaveNullInstance(){} // RVA: 0x7AE3DB260
        public void PropertyTypeCannotBeVoid(){} // RVA: 0x7AE3DB2F0
        public void InvalidUnboxType(){} // RVA: 0x7AE3DB380
        public void ExpressionMustBeWriteable(){} // RVA: 0x7AE3DB410
        public void ArgumentMustNotHaveValueType(){} // RVA: 0x7AE3DB4A0
        public void MustBeReducible(){} // RVA: 0x7AE3DB530
        public void AllTestValuesMustHaveSameType(){} // RVA: 0x7AE3DB5C0
        public void AllCaseBodiesMustHaveSameType(){} // RVA: 0x7AE3DB650
        public void DefaultBodyMustBeSupplied(){} // RVA: 0x7AE3DB6E0
        public void LabelMustBeVoidOrHaveExpression(){} // RVA: 0x7AE3DB770
        public void LabelTypeMustBeVoid(){} // RVA: 0x7AE3DB800
        public void QuotedExpressionMustBeLambda(){} // RVA: 0x7AE3DB890
        public void VariableMustNotBeByRef(){} // RVA: 0x7AE3DB9D0
        public void DuplicateVariable(){} // RVA: 0x7AE3DBAB0
        public void StartEndMustBeOrdered(){} // RVA: 0x7AE3DBB70
        public void FaultCannotHaveCatchOrFinally(){} // RVA: 0x7AE3DBC00
        public void TryMustHaveCatchFinallyOrFault(){} // RVA: 0x7AE3DBC90
        public void BodyOfCatchMustHaveSameTypeAsBodyOfTry(){} // RVA: 0x7AE3DBD20
        public void ExtensionNodeMustOverrideProperty(){} // RVA: 0x7AE3DBDB0
        public void UserDefinedOperatorMustBeStatic(){} // RVA: 0x7AE3DBE50
        public void UserDefinedOperatorMustNotBeVoid(){} // RVA: 0x7AE3DBEF0
        public void CoercionOperatorNotDefined(){} // RVA: 0x7AE3DBF90
        public void UnaryOperatorNotDefined(){} // RVA: 0x7AE3DC030
        public void BinaryOperatorNotDefined(){} // RVA: 0x7AE3DC0D0
        public void ReferenceEqualityNotDefined(){} // RVA: 0x7AE3DC190
        public void OperandTypesDoNotMatchParameters(){} // RVA: 0x7AE3DC230
        public void OverloadOperatorTypeDoesNotMatchConversionType(){} // RVA: 0x7AE3DC2D0
        public void ConversionIsNotSupportedForArithmeticTypes(){} // RVA: 0x7AE3DC370
        public void ArgumentTypeCannotBeVoid(){} // RVA: 0x7AE3DC400
        public void ArgumentMustBeArray(){} // RVA: 0x7AE3DC490
        public void ArgumentMustBeBoolean(){} // RVA: 0x7AE3DC520
        public void EqualityMustReturnBoolean(){} // RVA: 0x7AE3DC5B0
        public void ArgumentMustBeFieldInfoOrPropertyInfo(){} // RVA: 0x7AE3DC650
        public void ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(){} // RVA: 0x7AE3DC770
        public void ArgumentMustBeInstanceMember(){} // RVA: 0x7AE3DC8A0
        public void ArgumentMustBeInteger(){} // RVA: 0x7AE3DC9D0
        public void ArgumentMustBeArrayIndexType(){} // RVA: 0x7AE3DCB00
        public void ArgumentMustBeSingleDimensionalArrayType(){} // RVA: 0x7AE3DCB20
        public void ArgumentTypesMustMatch(){} // RVA: 0x7AE3DCC40
        public void CannotAutoInitializeValueTypeElementThroughProperty(){} // RVA: 0x7AE3DCCD0
        public void CannotAutoInitializeValueTypeMemberThroughProperty(){} // RVA: 0x7AE3DCD70
        public void IncorrectTypeForTypeAs(){} // RVA: 0x7AE3DCE10
        public void CoalesceUsedOnNonNullType(){} // RVA: 0x7AE3DCEB0
        public void ExpressionTypeCannotInitializeArrayType(){} // RVA: 0x7AE3DCF40
        public void ArgumentTypeDoesNotMatchMember(){} // RVA: 0x7AE3DD090
        public void ArgumentMemberNotDeclOnType(){} // RVA: 0x7AE3DD200
        public void ExpressionTypeDoesNotMatchReturn(){} // RVA: 0x7AE3DD2C0
        public void ExpressionTypeDoesNotMatchAssignment(){} // RVA: 0x7AE3DD360
        public void ExpressionTypeDoesNotMatchLabel(){} // RVA: 0x7AE3DD400
        public void ExpressionTypeNotInvocable(){} // RVA: 0x7AE3DD4A0
        public void FieldNotDefinedForType(){} // RVA: 0x7AE3DD540
        public void InstanceFieldNotDefinedForType(){} // RVA: 0x7AE3DD5E0
        public void FieldInfoNotDefinedForType(){} // RVA: 0x7AE3DD680
        public void IncorrectNumberOfIndexes(){} // RVA: 0x7AE3DD740
        public void IncorrectNumberOfLambdaDeclarationParameters(){} // RVA: 0x7AE3DD7D0
        public void IncorrectNumberOfMembersForGivenConstructor(){} // RVA: 0x7AE3DD860
        public void IncorrectNumberOfArgumentsForMembers(){} // RVA: 0x7AE3DD8F0
        public void LambdaTypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x7AE3DD980
        public void MemberNotFieldOrProperty(){} // RVA: 0x7AE3DDA10
        public void MethodContainsGenericParameters(){} // RVA: 0x7AE3DDAB0
        public void MethodIsGeneric(){} // RVA: 0x7AE3DDB50
        public void MethodNotPropertyAccessor(){} // RVA: 0x7AE3DDCA0
        public void PropertyDoesNotHaveGetter(){} // RVA: 0x7AE3DDE00
        public void PropertyDoesNotHaveSetter(){} // RVA: 0x7AE3DDE30
        public void PropertyDoesNotHaveAccessor(){} // RVA: 0x7AE3DDED0
        public void NotAMemberOfType(){} // RVA: 0x7AE3DE020
        public void NotAMemberOfAnyType(){} // RVA: 0x7AE3DE060
        public void ParameterExpressionNotValidAsDelegate(){} // RVA: 0x7AE3DE100
        public void PropertyNotDefinedForType(){} // RVA: 0x7AE3DE1A0
        public void InstancePropertyNotDefinedForType(){} // RVA: 0x7AE3DE250
        public void InstancePropertyWithoutParameterNotDefinedForType(){} // RVA: 0x7AE3DE300
        public void InstancePropertyWithSpecifiedParametersNotDefinedForType(){} // RVA: 0x7AE3DE3A0
        public void InstanceAndMethodTypeMismatch(){} // RVA: 0x7AE3DE460
        public void TypeMissingDefaultConstructor(){} // RVA: 0x7AE3DE520
        public void ElementInitializerMethodNotAdd(){} // RVA: 0x7AE3DE5C0
        public void ElementInitializerMethodNoRefOutParam(){} // RVA: 0x7AE3DE650
        public void ElementInitializerMethodWithZeroArgs(){} // RVA: 0x7AE3DE700
        public void ElementInitializerMethodStatic(){} // RVA: 0x7AE3DE790
        public void TypeNotIEnumerable(){} // RVA: 0x7AE3DE820
        public void UnhandledBinary(){} // RVA: 0x7AE3DE8C0
        public void UnhandledBinding(){} // RVA: 0x7AE3DE960
        public void UnhandledBindingType(){} // RVA: 0x7AE3DE9F0
        public void UnhandledUnary(){} // RVA: 0x7AE3DEA90
        public void UnknownBindingType(){} // RVA: 0x7AE3DEB30
        public void UserDefinedOpMustHaveConsistentTypes(){} // RVA: 0x7AE3DEC50
        public void UserDefinedOpMustHaveValidReturnType(){} // RVA: 0x7AE3DECF0
        public void LogicalOperatorMustHaveBooleanOperators(){} // RVA: 0x7AE3DED90
        public void MethodWithArgsDoesNotExistOnType(){} // RVA: 0x7AE3DEE30
        public void GenericMethodWithArgsDoesNotExistOnType(){} // RVA: 0x7AE3DEED0
        public void MethodWithMoreThanOneMatch(){} // RVA: 0x7AE3DEF70
        public void PropertyWithMoreThanOneMatch(){} // RVA: 0x7AE3DF010
        public void IncorrectNumberOfTypeArgsForFunc(){} // RVA: 0x7AE3DF0B0
        public void IncorrectNumberOfTypeArgsForAction(){} // RVA: 0x7AE3DF140
        public void ArgumentCannotBeOfTypeVoid(){} // RVA: 0x7AE3DF1D0
        public void OutOfRange(){} // RVA: 0x7AE3DF260
        public void LabelTargetAlreadyDefined(){} // RVA: 0x7AE3DF310
        public void LabelTargetUndefined(){} // RVA: 0x7AE3DF3B0
        public void ControlCannotLeaveFinally(){} // RVA: 0x7AE3DF450
        public void ControlCannotLeaveFilterTest(){} // RVA: 0x7AE3DF4E0
        public void AmbiguousJump(){} // RVA: 0x7AE3DF570
        public void ControlCannotEnterTry(){} // RVA: 0x7AE3DF610
        public void ControlCannotEnterExpression(){} // RVA: 0x7AE3DF6A0
        public void NonLocalJumpWithValue(){} // RVA: 0x7AE3DF730
        public void InvalidLvalue(){} // RVA: 0x7AE3DF7D0
        public void UndefinedVariable(){} // RVA: 0x7AE3DF890
        public void CannotCloseOverByRef(){} // RVA: 0x7AE3DF950
        public void UnexpectedVarArgsCall(){} // RVA: 0x7AE3DF9F0
        public void RethrowRequiresCatch(){} // RVA: 0x7AE3DFA90
        public void TryNotAllowedInFilter(){} // RVA: 0x7AE3DFB20
        public void MustRewriteToSameNode(){} // RVA: 0x7AE3DFBB0
        public void MustRewriteChildToSameType(){} // RVA: 0x7AE3DFC70
        public void MustRewriteWithoutMethod(){} // RVA: 0x7AE3DFD30
        public void TryNotSupportedForMethodsWithRefArgs(){} // RVA: 0x7AE3DFDD0
        public void TryNotSupportedForValueTypeInstances(){} // RVA: 0x7AE3DFE70
        public void TestValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7AE3DFF10
        public void SwitchValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7AE3DFFB0
        public void ArgumentOutOfRange(){} // RVA: 0x7AE3E0050
        public void NotSupported(){} // RVA: 0x7AE3E00E0
        public void NonStaticConstructorRequired(){} // RVA: 0x7AE3E0160
        public void NonAbstractConstructorRequired(){} // RVA: 0x7AE3E01F0
        public void InvalidProgram(){} // RVA: 0x7AE3E0280
        public void EnumerationIsDone(){} // RVA: 0x7AE3E0300
        public void TypeContainsGenericParameters(){} // RVA: 0x7AE3E0430
        public void TypeIsGeneric(){} // RVA: 0x7AE3E0590
        public void IncorrectNumberOfConstructorArguments(){} // RVA: 0x7AE3E0650
        public void ExpressionTypeDoesNotMatchMethodParameter(){} // RVA: 0x7AE3E07A0
        public void ExpressionTypeDoesNotMatchParameter(){} // RVA: 0x7AE3E0920
        public void IncorrectNumberOfLambdaArguments(){} // RVA: 0x7AE3E09E0
        public void IncorrectNumberOfMethodCallArguments(){} // RVA: 0x7AE3E0A70
        public void ExpressionTypeDoesNotMatchConstructorParameter(){} // RVA: 0x7AE3E0BC0
        public void ExpressionMustBeReadable(){} // RVA: 0x7AE3E0D10
        public void InvalidArgumentValue(){} // RVA: 0x7AE3E0DB0
        public void NonEmptyCollectionRequired(){} // RVA: 0x7AE3E0E40
        public void InvalidNullValue(){} // RVA: 0x7AE3E0ED0
        public void InvalidTypeException(){} // RVA: 0x7AE3E0F70
        public void GetParamName(){} // RVA: 0x7AE3E1050
    }

    public class Expression : Object
    {
        // ── Methods ──
        public void Assign(){} // RVA: 0x7AE39F750
        public void GetUserDefinedBinaryOperator(){} // RVA: 0x7AE3A0C70
        public void GetMethodBasedBinaryOperator(){} // RVA: 0x7AE39FDC0
        public void GetMethodBasedAssignOperator(){} // RVA: 0x7AE3A0460
        public void GetUserDefinedBinaryOperatorOrThrow(){} // RVA: 0x7AE3A0730
        public void GetUserDefinedAssignOperatorOrThrow(){} // RVA: 0x7AE3A09A0
        public void IsLiftingConditionalLogicalOperator(){} // RVA: 0x7AE3A1050
        public void ParameterIsAssignable(){} // RVA: 0x7AE3A1110
        public void ValidateParamswithOperandsOrThrow(){} // RVA: 0x7AE3A11D0
        public void ValidateOperator(){} // RVA: 0x7AE3A12C0
        public void ValidateMethodInfo(){} // RVA: 0x7AE3A14A0
        public void IsNullComparison(){} // RVA: 0x7AE3A1530
        public void IsNullConstant(){} // RVA: 0x7AE3A1770
        public void ValidateUserDefinedConditionalLogicOperator(){} // RVA: 0x7AE3A17E0
        public void VerifyOpTrueFalse(){} // RVA: 0x7AE3A20E0
        public void IsValidLiftedConditionalLogicalOperator(){} // RVA: 0x7AE3A22D0
        public void MakeBinary(){} // RVA: 0x7AE3A25A0
        public void Equal(){} // RVA: 0x7AE3A2F70
        public void ReferenceEqual(){} // RVA: 0x7AE3A30A0
        public void NotEqual(){} // RVA: 0x7AE3A32C0
        public void ReferenceNotEqual(){} // RVA: 0x7AE3A33F0
        public void GetEqualityComparisonOperator(){} // RVA: 0x7AE3A35A0
        public void GreaterThan(){} // RVA: 0x7AE3A3AA0
        public void LessThan(){} // RVA: 0x7AE3A3C40
        public void GreaterThanOrEqual(){} // RVA: 0x7AE3A3DE0
        public void LessThanOrEqual(){} // RVA: 0x7AE3A3F80
        public void GetComparisonOperator(){} // RVA: 0x7AE3A40B0
        public void AndAlso(){} // RVA: 0x7AE3A4380
        public void OrElse(){} // RVA: 0x7AE3A4B10
        public void Coalesce(){} // RVA: 0x7AE3A5260
        public void ValidateCoalesceArgTypes(){} // RVA: 0x7AE3A5800
        public void Add(){} // RVA: 0x7AE3A5AB0
        public void AddAssign(){} // RVA: 0x7AE3A5E00
        public void ValidateOpAssignConversionLambda(){} // RVA: 0x7AE3A60D0
        public void AddAssignChecked(){} // RVA: 0x7AE3A6570
        public void AddChecked(){} // RVA: 0x7AE3A68B0
        public void Subtract(){} // RVA: 0x7AE3A6B90
        public void SubtractAssign(){} // RVA: 0x7AE3A6EF0
        public void SubtractAssignChecked(){} // RVA: 0x7AE3A72F0
        public void SubtractChecked(){} // RVA: 0x7AE3A7630
        public void Divide(){} // RVA: 0x7AE3A7910
        public void DivideAssign(){} // RVA: 0x7AE3A7C70
        public void Modulo(){} // RVA: 0x7AE3A7FB0
        public void ModuloAssign(){} // RVA: 0x7AE3A8310
        public void Multiply(){} // RVA: 0x7AE3A8650
        public void MultiplyAssign(){} // RVA: 0x7AE3A89B0
        public void MultiplyAssignChecked(){} // RVA: 0x7AE3A8DB0
        public void MultiplyChecked(){} // RVA: 0x7AE3A90F0
        public void IsSimpleShift(){} // RVA: 0x7AE3A9360
        public void GetResultTypeOfShift(){} // RVA: 0x7AE3A9440
        public void LeftShift(){} // RVA: 0x7AE3A9630
        public void LeftShiftAssign(){} // RVA: 0x7AE3A9980
        public void RightShift(){} // RVA: 0x7AE3A9CA0
        public void RightShiftAssign(){} // RVA: 0x7AE3A9FF0
        public void And(){} // RVA: 0x7AE3AA310
        public void AndAssign(){} // RVA: 0x7AE3AA670
        public void Or(){} // RVA: 0x7AE3AA9B0
        public void OrAssign(){} // RVA: 0x7AE3AAD10
        public void ExclusiveOr(){} // RVA: 0x7AE3AB050
        public void ExclusiveOrAssign(){} // RVA: 0x7AE3AB3B0
        public void Power(){} // RVA: 0x7AE3AB6F0
        public void PowerAssign(){} // RVA: 0x7AE3ABC00
        public void ArrayIndex(){} // RVA: 0x7AE3BF260
        public void Block(){} // RVA: 0x7AE3ACA70
        public void BlockCore(){} // RVA: 0x7AE3ACD90
        public void ValidateVariables(){} // RVA: 0x7AE3AD200
        public void GetOptimizedBlockExpression(){} // RVA: 0x7AE3AD4A0
        public void Catch(){} // RVA: 0x7AE3ADB70
        public void MakeCatchBlock(){} // RVA: 0x7AE3ADC70
        public void Condition(){} // RVA: 0x7AE3AE3D0
        public void IfThen(){} // RVA: 0x7AE3AE710
        public void IfThenElse(){} // RVA: 0x7AE3AE830
        public void Constant(){} // RVA: 0x7AE3AE9B0
        public void DebugInfo(){} // RVA: 0x7AE3AEC30
        public void ClearDebugInfo(){} // RVA: 0x7AE3AEDB0
        public void ValidateSpan(){} // RVA: 0x7AE3AEE70
        public void Empty(){} // RVA: 0x7AE3AF060
        public void Default(){} // RVA: 0x7AE3AF150
        public void ElementInit(){} // RVA: 0x7AE3AF2B0
        public void ValidateElementInitAddMethodInfo(){} // RVA: 0x7AE3AF520
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_NodeType(){} // RVA: 0x7AE3AFAB0
        public void get_Type(){} // RVA: 0x7AE3AFBB0
        public void get_CanReduce(){} // RVA: 0x7A80D7320
        public void Reduce(){} // RVA: 0x7AE3AFCB0
        public void VisitChildren(){} // RVA: 0x7AE3AFD00
        public void Accept(){} // RVA: 0x7AE3AFD90
        public void ReduceAndCheck(){} // RVA: 0x7AE3AFDC0
        public void ReduceExtensions(){} // RVA: 0x7AE3AFF20
        public void ToString(){} // RVA: 0x7AE3AFF80
        public void get_DebugView(){} // RVA: 0x7AE3B0010
        public void RequiresCanRead(){} // RVA: 0x7AE3B01A0
        public void RequiresCanWrite(){} // RVA: 0x7AE3B02D0
        public void Dynamic(){} // RVA: 0x7AE3B0550
        public void MakeDynamic(){} // RVA: 0x7AE3B05F0
        public void Break(){} // RVA: 0x7AE3B08E0
        public void Continue(){} // RVA: 0x7AE3B0A60
        public void Return(){} // RVA: 0x7AE3B0D50
        public void Goto(){} // RVA: 0x7AE3B1050
        public void MakeGoto(){} // RVA: 0x7AE3B10D0
        public void ValidateGoto(){} // RVA: 0x7AE3B12E0
        public void ValidateGotoType(){} // RVA: 0x7AE3B14A0
        public void MakeIndex(){} // RVA: 0x7AE3B1660
        public void ArrayAccess(){} // RVA: 0x7AE3B1760
        public void Property(){} // RVA: 0x7AE3B9AF0
        public void FindInstanceProperty(){} // RVA: 0x7AE3B1E20
        public void GetArgTypesString(){} // RVA: 0x7AE3B1F70
        public void FindProperty(){} // RVA: 0x7AE3B2140
        public void IsCompatible(){} // RVA: 0x7AE3BEE80
        public void MakeIndexProperty(){} // RVA: 0x7AE3B2690
        public void ValidateIndexedProperty(){} // RVA: 0x7AE3B2760
        public void ValidateAccessor(){} // RVA: 0x7AE3B2E00
        public void ValidateAccessorArgumentTypes(){} // RVA: 0x7AE3B30D0
        public void Invoke(){} // RVA: 0x7AE3B4930
        public void GetInvokeMethod(){} // RVA: 0x7AE3B4DE0
        public void Label(){} // RVA: 0x7AE3B5480
        public void CreateLambda(){} // RVA: 0x7AE3B5620
        public void Lambda(){} // RVA: 0x7AE3B66D0
        public void ValidateLambdaArgs(){} // RVA: 0x7AE3B67C0
        public void ValidateTryGetFuncActionArgs(){} // RVA: 0x7AE3B70C0
        public void GetFuncType(){} // RVA: 0x7AE3B71F0
        public void TryGetFuncType(){} // RVA: 0x7AE3B7360
        public void GetActionType(){} // RVA: 0x7AE3B74D0
        public void TryGetActionType(){} // RVA: 0x7AE3B7640
        public void GetDelegateType(){} // RVA: 0x7AE3B77B0
        public void ListInit(){} // RVA: 0x7AE3B8290
        public void Loop(){} // RVA: 0x7AE3B8530
        public void Bind(){} // RVA: 0x7AE3B89E0
        public void ValidateSettableFieldOrPropertyMember(){} // RVA: 0x7AE3B8B90
        public void Field(){} // RVA: 0x7AE3B91D0
        public void GetProperty(){} // RVA: 0x7AE3B9C40
        public void CheckMethod(){} // RVA: 0x7AE3B9EB0
        public void PropertyOrField(){} // RVA: 0x7AE3BA090
        public void MakeMemberAccess(){} // RVA: 0x7AE3BA360
        public void MemberInit(){} // RVA: 0x7AE3BA570
        public void ListBind(){} // RVA: 0x7AE3BAC00
        public void ValidateListInitArgs(){} // RVA: 0x7AE3BAD50
        public void MemberBind(){} // RVA: 0x7AE3BB3B0
        public void ValidateGettableFieldOrPropertyMember(){} // RVA: 0x7AE3BB490
        public void ValidateMemberInitArgs(){} // RVA: 0x7AE3BB6F0
        public void Call(){} // RVA: 0x7AE3BDFD0
        public void ValidateMethodAndGetParameters(){} // RVA: 0x7AE3BE600
        public void ValidateStaticOrInstanceMethod(){} // RVA: 0x7AE3BE840
        public void ValidateCallInstanceType(){} // RVA: 0x7AE3BE960
        public void ValidateArgumentTypes(){} // RVA: 0x7AE3BEA10
        public void GetParametersForValidation(){} // RVA: 0x7AE3BEA20
        public void ValidateArgumentCount(){} // RVA: 0x7AE3BEA30
        public void ValidateOneArgument(){} // RVA: 0x7AE3BEA40
        public void TryQuote(){} // RVA: 0x7AE3BEA80
        public void FindMethod(){} // RVA: 0x7AE3BEA90
        public void ApplyTypeArgs(){} // RVA: 0x7AE3BF130
        public void NewArrayInit(){} // RVA: 0x7AE3BF760
        public void NewArrayBounds(){} // RVA: 0x7AE3BFD80
        public void New(){} // RVA: 0x7AE3C0880
        public void ValidateNewArgs(){} // RVA: 0x7AE3C0CF0
        public void ValidateAnonymousTypeMember(){} // RVA: 0x7AE3C1810
        public void ValidateConstructor(){} // RVA: 0x7AE3C1B80
        public void Parameter(){} // RVA: 0x7AE3C1CA0
        public void Variable(){} // RVA: 0x7AE3C1D60
        public void Validate(){} // RVA: 0x7AE3C1DD0
        public void RuntimeVariables(){} // RVA: 0x7AE3C1FC0
        public void SwitchCase(){} // RVA: 0x7AE3C22B0
        public void Switch(){} // RVA: 0x7AE3C27B0
        public void ValidateSwitchCaseType(){} // RVA: 0x7AE3C3580
        public void SymbolDocument(){} // RVA: 0x7AE3C3B90
        public void TryFault(){} // RVA: 0x7AE3C3D10
        public void TryFinally(){} // RVA: 0x7AE3C3D80
        public void TryCatch(){} // RVA: 0x7AE3C3DF0
        public void TryCatchFinally(){} // RVA: 0x7AE3C3E60
        public void MakeTry(){} // RVA: 0x7AE3C3EE0
        public void ValidateTryAndCatchHaveSameType(){} // RVA: 0x7AE3C4160
        public void TypeIs(){} // RVA: 0x7AE3C47F0
        public void TypeEqual(){} // RVA: 0x7AE3C4950
        public void MakeUnary(){} // RVA: 0x7AE3C4B30
        public void GetUserDefinedUnaryOperatorOrThrow(){} // RVA: 0x7AE3C5230
        public void GetUserDefinedUnaryOperator(){} // RVA: 0x7AE3C53D0
        public void GetMethodBasedUnaryOperator(){} // RVA: 0x7AE3C5770
        public void GetUserDefinedCoercionOrThrow(){} // RVA: 0x7AE3C5BC0
        public void GetUserDefinedCoercion(){} // RVA: 0x7AE3C5D30
        public void GetMethodBasedCoercionOperator(){} // RVA: 0x7AE3C5E30
        public void Negate(){} // RVA: 0x7AE3C6340
        public void UnaryPlus(){} // RVA: 0x7AE3C6590
        public void NegateChecked(){} // RVA: 0x7AE3C67A0
        public void Not(){} // RVA: 0x7AE3C69F0
        public void IsFalse(){} // RVA: 0x7AE3C6C40
        public void IsTrue(){} // RVA: 0x7AE3C6E50
        public void OnesComplement(){} // RVA: 0x7AE3C7060
        public void TypeAs(){} // RVA: 0x7AE3C7210
        public void Unbox(){} // RVA: 0x7AE3C73D0
        public void Convert(){} // RVA: 0x7AE3C76B0
        public void ConvertChecked(){} // RVA: 0x7AE3C7970
        public void ArrayLength(){} // RVA: 0x7AE3C7BF0
        public void Quote(){} // RVA: 0x7AE3C7E40
        public void Rethrow(){} // RVA: 0x7AE3C8090
        public void Throw(){} // RVA: 0x7AE3C81E0
        public void Increment(){} // RVA: 0x7AE3C8400
        public void Decrement(){} // RVA: 0x7AE3C8610
        public void PreIncrementAssign(){} // RVA: 0x7AE3C8820
        public void PreDecrementAssign(){} // RVA: 0x7AE3C88F0
        public void PostIncrementAssign(){} // RVA: 0x7AE3C89C0
        public void PostDecrementAssign(){} // RVA: 0x7AE3C8A90
        public void MakeOpAssignUnary(){} // RVA: 0x7AE3C8B00
        public void .cctor(){} // RVA: 0x7AE3C8DC0
    }

    public class Expression0`1 : Expression`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void get_ParameterCount(){} // RVA: 0x7A7E00710
        public void SameParameters(){} // RVA: 0x7A7E019D0
        public void GetParameter(){} // RVA: 0x7A7E00740
        public void GetOrMakeParameters(){} // RVA: 0x7A7E00680
        public void Rewrite(){} // RVA: 0x7A7E00BD0
    }

    public class Expression1`1 : Expression`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18890
        public void get_ParameterCount(){} // RVA: 0x7A7E00710
        public void GetParameter(){} // RVA: 0x7A7E00740
        public void SameParameters(){} // RVA: 0x7A7E019D0
        public void GetOrMakeParameters(){} // RVA: 0x7A7E00680
        public void Rewrite(){} // RVA: 0x7A7E00BD0
    }

    public class Expression2`1 : Expression`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1DDC0
        public void get_ParameterCount(){} // RVA: 0x7A7E00710
        public void GetParameter(){} // RVA: 0x7A7E00740
        public void SameParameters(){} // RVA: 0x7A7E019D0
        public void GetOrMakeParameters(){} // RVA: 0x7A7E00680
        public void Rewrite(){} // RVA: 0x7A7E00BD0
    }

    public class Expression3`1 : Expression`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1DB70
        public void get_ParameterCount(){} // RVA: 0x7A7E00710
        public void GetParameter(){} // RVA: 0x7A7E00740
        public void SameParameters(){} // RVA: 0x7A7E019D0
        public void GetOrMakeParameters(){} // RVA: 0x7A7E00680
        public void Rewrite(){} // RVA: 0x7A7E00BD0
    }

    public class ExpressionCreator`1 : Object
    {
        // ── Methods ──
        public void CreateExpressionFunc(){} // RVA: 0x7A7E12660
    }

    public class ExpressionExtension : Object
    {
        // ── Methods ──
        public void MakeDynamic(){} // RVA: 0x7AE3D9430
        public void GetValidMethodForDynamic(){} // RVA: 0x7AE3D8300
        public void Dynamic(){} // RVA: 0x7AE3D9240
        public void ValidateDynamicArgument(){} // RVA: 0x7AE3D99B0
    }

    public class ExpressionN`1 : Expression`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18890
        public void get_ParameterCount(){} // RVA: 0x7A7E00710
        public void GetParameter(){} // RVA: 0x7A7E00740
        public void SameParameters(){} // RVA: 0x7A7E019D0
        public void GetOrMakeParameters(){} // RVA: 0x7A7E00680
        public void Rewrite(){} // RVA: 0x7A7E00BD0
    }

    public class ExpressionN`1 : Expression`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB1131E0
        public void get_ParameterCount(){} // RVA: 0x7AB114700
        public void GetParameter(){} // RVA: 0x7AB114750
        public void SameParameters(){} // RVA: 0x7AB1147B0
        public void GetOrMakeParameters(){} // RVA: 0x7AB114890
        public void Rewrite(){} // RVA: 0x7AB1148D0
    }

    public class ExpressionStringBuilder : ExpressionVisitor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3E1110
        public void ToString(){} // RVA: 0x7A8E1FCB0
        public void GetLabelId(){} // RVA: 0x7AE3E11B0
        public void GetParamId(){} // RVA: 0x7AE3E11B0
        public void GetId(){} // RVA: 0x7AE3E11C0
        public void Out(){} // RVA: 0x7AE3E1390
        public void ExpressionToString(){} // RVA: 0x7AE3AFF80
        public void CatchBlockToString(){} // RVA: 0x7AE3CDEF0
        public void SwitchCaseToString(){} // RVA: 0x7AE3E13B0
        public void MemberBindingToString(){} // RVA: 0x7AE3E1440
        public void ElementInitBindingToString(){} // RVA: 0x7AE3D9D10
        public void VisitExpressions(){} // RVA: 0x7A8051B10
        public void VisitBinary(){} // RVA: 0x7AE3E14D0
        public void VisitParameter(){} // RVA: 0x7AE3E1D80
        public void VisitLambda(){} // RVA: 0x7A7E00B20
        public void VisitListInit(){} // RVA: 0x7AE3E1EF0
        public void VisitConditional(){} // RVA: 0x7AE3E20C0
        public void VisitConstant(){} // RVA: 0x7AE3E2240
        public void VisitDebugInfo(){} // RVA: 0x7AE3E2520
        public void VisitRuntimeVariables(){} // RVA: 0x7AE3E28A0
        public void OutMember(){} // RVA: 0x7AE3E2910
        public void VisitMember(){} // RVA: 0x7AE3E2A30
        public void VisitMemberInit(){} // RVA: 0x7AE3E2BA0
        public void VisitMemberAssignment(){} // RVA: 0x7AE3E2EC0
        public void VisitMemberListBinding(){} // RVA: 0x7AE3E2F70
        public void VisitMemberMemberBinding(){} // RVA: 0x7AE3E3160
        public void VisitElementInit(){} // RVA: 0x7AE3E3350
        public void VisitInvocation(){} // RVA: 0x7AE3E3580
        public void VisitMethodCall(){} // RVA: 0x7AE3E3710
        public void VisitNewArray(){} // RVA: 0x7AE3E3A50
        public void VisitNew(){} // RVA: 0x7AE3E3BA0
        public void VisitTypeBinary(){} // RVA: 0x7AE3E3E60
        public void VisitUnary(){} // RVA: 0x7AE3E4030
        public void VisitBlock(){} // RVA: 0x7AE3E4790
        public void VisitDefault(){} // RVA: 0x7AE3E4B20
        public void VisitLabel(){} // RVA: 0x7AE3E4C40
        public void VisitGoto(){} // RVA: 0x7AE3E4D20
        public void VisitLoop(){} // RVA: 0x7AE3E4F20
        public void VisitSwitchCase(){} // RVA: 0x7AE3E4F80
        public void VisitSwitch(){} // RVA: 0x7AE3E5040
        public void VisitCatchBlock(){} // RVA: 0x7AE3E5150
        public void VisitTry(){} // RVA: 0x7AE3E52C0
        public void VisitIndex(){} // RVA: 0x7AE3E5320
        public void VisitExtension(){} // RVA: 0x7AE3E55F0
        public void DumpLabel(){} // RVA: 0x7AE3E5940
        public void IsBool(){} // RVA: 0x7AE3E5A70
    }

    public class ExpressionVisitor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Visit(){} // RVA: 0x7A7E00C10
        public void VisitArguments(){} // RVA: 0x7AE3E5F50
        public void VisitParameters(){} // RVA: 0x7AE3E5F60
        public void VisitAndConvert(){} // RVA: 0x7A7E00BD0
        public void VisitBinary(){} // RVA: 0x7AE3E5F70
        public void VisitBlock(){} // RVA: 0x7AE3E6080
        public void VisitConditional(){} // RVA: 0x7AE3E6180
        public void VisitConstant(){} // RVA: 0x7A9194610
        public void VisitDebugInfo(){} // RVA: 0x7A9194610
        public void VisitDefault(){} // RVA: 0x7A9194610
        public void VisitExtension(){} // RVA: 0x7AE3CEB30
        public void VisitGoto(){} // RVA: 0x7AE3E62D0
        public void VisitInvocation(){} // RVA: 0x7AE3E63D0
        public void VisitLabelTarget(){} // RVA: 0x7A9194610
        public void VisitLabel(){} // RVA: 0x7AE3E6470
        public void VisitLambda(){} // RVA: 0x7A7E00B20
        public void VisitLoop(){} // RVA: 0x7AE3E6540
        public void VisitMember(){} // RVA: 0x7AE3E6640
        public void VisitIndex(){} // RVA: 0x7AE3E66F0
        public void VisitMethodCall(){} // RVA: 0x7AE3E6830
        public void VisitNewArray(){} // RVA: 0x7AE3E6900
        public void VisitNew(){} // RVA: 0x7AE3E6940
        public void VisitParameter(){} // RVA: 0x7A9194610
        public void VisitRuntimeVariables(){} // RVA: 0x7AE3E6A70
        public void VisitSwitchCase(){} // RVA: 0x7AE3E6B70
        public void VisitSwitch(){} // RVA: 0x7AE3E6C70
        public void VisitCatchBlock(){} // RVA: 0x7AE3E6EA0
        public void VisitTry(){} // RVA: 0x7AE3E6FF0
        public void VisitTypeBinary(){} // RVA: 0x7AE3E71D0
        public void VisitUnary(){} // RVA: 0x7AE3E72B0
        public void VisitMemberInit(){} // RVA: 0x7AE3E7490
        public void VisitListInit(){} // RVA: 0x7AE3E7630
        public void VisitElementInit(){} // RVA: 0x7AE3E77D0
        public void VisitMemberBinding(){} // RVA: 0x7AE3E7860
        public void VisitMemberAssignment(){} // RVA: 0x7AE3E7A00
        public void VisitMemberMemberBinding(){} // RVA: 0x7AE3E7AA0
        public void VisitMemberListBinding(){} // RVA: 0x7AE3E7BF0
        public void ValidateUnary(){} // RVA: 0x7AE3E7D40
        public void ValidateBinary(){} // RVA: 0x7AE3E7E50
        public void ValidateSwitch(){} // RVA: 0x7AE3E7FF0
        public void ValidateChildType(){} // RVA: 0x7AE3E8070
        public void VisitDynamic(){} // RVA: 0x7AE3D9BB0
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18770
        public void get_TypeCore(){} // RVA: 0x7A7E00680
        public void get_PublicType(){} // RVA: 0x7A7E00680
        public void Compile(){} // RVA: 0x7A8051B10
        public void Update(){} // RVA: 0x7A7E00BD0
        public void SameParameters(){} // RVA: 0x7A7E019D0
        public void Rewrite(){} // RVA: 0x7A7E00BD0
        public void Accept(){} // RVA: 0x7A7E00B20
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB114F50
        public void get_TypeCore(){} // RVA: 0x7AB114F60
        public void get_PublicType(){} // RVA: 0x7AB115010
        public void Compile(){} // RVA: 0x7A80804D0
        public void Update(){} // RVA: 0x7AB115370
        public void SameParameters(){} // RVA: 0x7AB114E60
        public void Rewrite(){} // RVA: 0x7AB114E80
        public void Accept(){} // RVA: 0x7AB114EA0
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB114F50
        public void get_TypeCore(){} // RVA: 0x7AB114F60
        public void get_PublicType(){} // RVA: 0x7AB115010
        public void Compile(){} // RVA: 0x7A80804D0
        public void Update(){} // RVA: 0x7AB115370
        public void SameParameters(){} // RVA: 0x7AB114E60
        public void Rewrite(){} // RVA: 0x7AB114E80
        public void Accept(){} // RVA: 0x7AB114EA0
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB114F50
        public void get_TypeCore(){} // RVA: 0x7AB114F60
        public void get_PublicType(){} // RVA: 0x7AB115010
        public void Compile(){} // RVA: 0x7A80804D0
        public void Update(){} // RVA: 0x7AB115370
        public void SameParameters(){} // RVA: 0x7AB114E60
        public void Rewrite(){} // RVA: 0x7AB114E80
        public void Accept(){} // RVA: 0x7AB114EA0
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB114F50
        public void get_TypeCore(){} // RVA: 0x7AB114F60
        public void get_PublicType(){} // RVA: 0x7AB115010
        public void Compile(){} // RVA: 0x7A80804D0
        public void Update(){} // RVA: 0x7AB115370
        public void SameParameters(){} // RVA: 0x7AB114E60
        public void Rewrite(){} // RVA: 0x7AB114E80
        public void Accept(){} // RVA: 0x7AB114EA0
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB114F50
        public void get_TypeCore(){} // RVA: 0x7AB114F60
        public void get_PublicType(){} // RVA: 0x7AB115010
        public void Compile(){} // RVA: 0x7A80804D0
        public void Update(){} // RVA: 0x7AB115370
        public void SameParameters(){} // RVA: 0x7AB114E60
        public void Rewrite(){} // RVA: 0x7AB114E80
        public void Accept(){} // RVA: 0x7AB114EA0
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB114F50
        public void get_TypeCore(){} // RVA: 0x7AB114F60
        public void get_PublicType(){} // RVA: 0x7AB115010
        public void Compile(){} // RVA: 0x7A80804D0
        public void Update(){} // RVA: 0x7AB115370
        public void SameParameters(){} // RVA: 0x7AB114E60
        public void Rewrite(){} // RVA: 0x7AB114E80
        public void Accept(){} // RVA: 0x7AB114EA0
    }

}