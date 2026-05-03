// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 13
// Methods: 751

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class ElementInit : Object
    {
        public System.Reflection.MethodInfo _addMethod; // 0x10
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression> _arguments; // 0x18
        public object field_2; // 0x186

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8712A4A0 | overloaded x2
        public void get_AddMethod(){} // RVA: 0x7FFE81116380
        public void get_Arguments(){} // RVA: 0x7FFE810FE7C0
        public void GetArgument(){} // RVA: 0x7FFE8712A280
        public void get_ArgumentCount(){} // RVA: 0x7FFE8712A310
        public void ToString(){} // RVA: 0x7FFE8712A390
        public void Update(){} // RVA: 0x7FFE8712A420
    }

    public class Error : Object
    {
        // ── Methods ──
        public void ReducibleMustOverrideReduce(){} // RVA: 0x7FFE8712A4D0
        public void ArgCntMustBeGreaterThanNameCnt(){} // RVA: 0x7FFE8712A560
        public void InvalidMetaObjectCreated(){} // RVA: 0x7FFE8712A5F0
        public void AmbiguousMatchInExpandoObject(){} // RVA: 0x7FFE8712A690
        public void SameKeyExistsInExpando(){} // RVA: 0x7FFE8712A730
        public void KeyDoesNotExistInExpando(){} // RVA: 0x7FFE8712A7E0
        public void CollectionModifiedWhileEnumerating(){} // RVA: 0x7FFE8712A880
        public void CollectionReadOnly(){} // RVA: 0x7FFE8712A910
        public void MustReduceToDifferent(){} // RVA: 0x7FFE8712A9A0
        public void BinderNotCompatibleWithCallSite(){} // RVA: 0x7FFE8712AA30
        public void DynamicBindingNeedsRestrictions(){} // RVA: 0x7FFE8712AAF0
        public void DynamicObjectResultNotAssignable(){} // RVA: 0x7FFE8712AB90
        public void DynamicBinderResultNotAssignable(){} // RVA: 0x7FFE8712AC30
        public void BindingCannotBeNull(){} // RVA: 0x7FFE8712ACF0
        public void ReducedNotCompatible(){} // RVA: 0x7FFE8712AD80
        public void SetterHasNoParams(){} // RVA: 0x7FFE8712AE10
        public void PropertyCannotHaveRefType(){} // RVA: 0x7FFE8712AEA0
        public void IndexesOfSetGetMustMatch(){} // RVA: 0x7FFE8712AF30
        public void TypeParameterIsNotDelegate(){} // RVA: 0x7FFE8712AFC0
        public void FirstArgumentMustBeCallSite(){} // RVA: 0x7FFE8712B060
        public void AccessorsCannotHaveVarArgs(){} // RVA: 0x7FFE8712B0F0
        public void AccessorsCannotHaveByRefArgs(){} // RVA: 0x7FFE8712B210 | overloaded x2
        public void TypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x7FFE8712B2B0
        public void NoOrInvalidRuleProduced(){} // RVA: 0x7FFE8712B340
        public void BoundsCannotBeLessThanOne(){} // RVA: 0x7FFE8712B3D0
        public void TypeMustNotBeByRef(){} // RVA: 0x7FFE8712B460
        public void TypeMustNotBePointer(){} // RVA: 0x7FFE8712B4F0
        public void SetterMustBeVoid(){} // RVA: 0x7FFE8712B580
        public void PropertyTypeMustMatchGetter(){} // RVA: 0x7FFE8712B610
        public void PropertyTypeMustMatchSetter(){} // RVA: 0x7FFE8712B6A0
        public void BothAccessorsMustBeStatic(){} // RVA: 0x7FFE8712B730
        public void OnlyStaticFieldsHaveNullInstance(){} // RVA: 0x7FFE8712B7C0
        public void OnlyStaticPropertiesHaveNullInstance(){} // RVA: 0x7FFE8712B850
        public void OnlyStaticMethodsHaveNullInstance(){} // RVA: 0x7FFE8712B8E0
        public void PropertyTypeCannotBeVoid(){} // RVA: 0x7FFE8712B970
        public void InvalidUnboxType(){} // RVA: 0x7FFE8712BA00
        public void ExpressionMustBeWriteable(){} // RVA: 0x7FFE8712BA90
        public void ArgumentMustNotHaveValueType(){} // RVA: 0x7FFE8712BB20
        public void MustBeReducible(){} // RVA: 0x7FFE8712BBB0
        public void AllTestValuesMustHaveSameType(){} // RVA: 0x7FFE8712BC40
        public void AllCaseBodiesMustHaveSameType(){} // RVA: 0x7FFE8712BCD0
        public void DefaultBodyMustBeSupplied(){} // RVA: 0x7FFE8712BD60
        public void LabelMustBeVoidOrHaveExpression(){} // RVA: 0x7FFE8712BDF0
        public void LabelTypeMustBeVoid(){} // RVA: 0x7FFE8712BE80
        public void QuotedExpressionMustBeLambda(){} // RVA: 0x7FFE8712BF10
        public void VariableMustNotBeByRef(){} // RVA: 0x7FFE8712C050 | overloaded x2
        public void DuplicateVariable(){} // RVA: 0x7FFE8712C130 | overloaded x2
        public void StartEndMustBeOrdered(){} // RVA: 0x7FFE8712C1F0
        public void FaultCannotHaveCatchOrFinally(){} // RVA: 0x7FFE8712C280
        public void TryMustHaveCatchFinallyOrFault(){} // RVA: 0x7FFE8712C310
        public void BodyOfCatchMustHaveSameTypeAsBodyOfTry(){} // RVA: 0x7FFE8712C3A0
        public void ExtensionNodeMustOverrideProperty(){} // RVA: 0x7FFE8712C430
        public void UserDefinedOperatorMustBeStatic(){} // RVA: 0x7FFE8712C4D0
        public void UserDefinedOperatorMustNotBeVoid(){} // RVA: 0x7FFE8712C570
        public void CoercionOperatorNotDefined(){} // RVA: 0x7FFE8712C610
        public void UnaryOperatorNotDefined(){} // RVA: 0x7FFE8712C6B0
        public void BinaryOperatorNotDefined(){} // RVA: 0x7FFE8712C750
        public void ReferenceEqualityNotDefined(){} // RVA: 0x7FFE8712C810
        public void OperandTypesDoNotMatchParameters(){} // RVA: 0x7FFE8712C8B0
        public void OverloadOperatorTypeDoesNotMatchConversionType(){} // RVA: 0x7FFE8712C950
        public void ConversionIsNotSupportedForArithmeticTypes(){} // RVA: 0x7FFE8712C9F0
        public void ArgumentTypeCannotBeVoid(){} // RVA: 0x7FFE8712CA80
        public void ArgumentMustBeArray(){} // RVA: 0x7FFE8712CB10
        public void ArgumentMustBeBoolean(){} // RVA: 0x7FFE8712CBA0
        public void EqualityMustReturnBoolean(){} // RVA: 0x7FFE8712CC30
        public void ArgumentMustBeFieldInfoOrPropertyInfo(){} // RVA: 0x7FFE8712CCD0
        public void ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(){} // RVA: 0x7FFE8712CDF0 | overloaded x2
        public void ArgumentMustBeInstanceMember(){} // RVA: 0x7FFE8712CF20 | overloaded x2
        public void ArgumentMustBeInteger(){} // RVA: 0x7FFE8712D050 | overloaded x2
        public void ArgumentMustBeArrayIndexType(){} // RVA: 0x7FFE8712D180 | overloaded x2
        public void ArgumentMustBeSingleDimensionalArrayType(){} // RVA: 0x7FFE8712D1A0
        public void ArgumentTypesMustMatch(){} // RVA: 0x7FFE8712D2C0 | overloaded x2
        public void CannotAutoInitializeValueTypeElementThroughProperty(){} // RVA: 0x7FFE8712D350
        public void CannotAutoInitializeValueTypeMemberThroughProperty(){} // RVA: 0x7FFE8712D3F0
        public void IncorrectTypeForTypeAs(){} // RVA: 0x7FFE8712D490
        public void CoalesceUsedOnNonNullType(){} // RVA: 0x7FFE8712D530
        public void ExpressionTypeCannotInitializeArrayType(){} // RVA: 0x7FFE8712D5C0
        public void ArgumentTypeDoesNotMatchMember(){} // RVA: 0x7FFE8712D710 | overloaded x2
        public void ArgumentMemberNotDeclOnType(){} // RVA: 0x7FFE8712D880 | overloaded x2
        public void ExpressionTypeDoesNotMatchReturn(){} // RVA: 0x7FFE8712D940
        public void ExpressionTypeDoesNotMatchAssignment(){} // RVA: 0x7FFE8712D9E0
        public void ExpressionTypeDoesNotMatchLabel(){} // RVA: 0x7FFE8712DA80
        public void ExpressionTypeNotInvocable(){} // RVA: 0x7FFE8712DB20
        public void FieldNotDefinedForType(){} // RVA: 0x7FFE8712DBC0
        public void InstanceFieldNotDefinedForType(){} // RVA: 0x7FFE8712DC60
        public void FieldInfoNotDefinedForType(){} // RVA: 0x7FFE8712DD00
        public void IncorrectNumberOfIndexes(){} // RVA: 0x7FFE8712DDC0
        public void IncorrectNumberOfLambdaDeclarationParameters(){} // RVA: 0x7FFE8712DE50
        public void IncorrectNumberOfMembersForGivenConstructor(){} // RVA: 0x7FFE8712DEE0
        public void IncorrectNumberOfArgumentsForMembers(){} // RVA: 0x7FFE8712DF70
        public void LambdaTypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x7FFE8712E000
        public void MemberNotFieldOrProperty(){} // RVA: 0x7FFE8712E090
        public void MethodContainsGenericParameters(){} // RVA: 0x7FFE8712E130
        public void MethodIsGeneric(){} // RVA: 0x7FFE8712E1D0
        public void MethodNotPropertyAccessor(){} // RVA: 0x7FFE8712E320 | overloaded x2
        public void PropertyDoesNotHaveGetter(){} // RVA: 0x7FFE8712E480 | overloaded x2
        public void PropertyDoesNotHaveSetter(){} // RVA: 0x7FFE8712E4B0
        public void PropertyDoesNotHaveAccessor(){} // RVA: 0x7FFE8712E550
        public void NotAMemberOfType(){} // RVA: 0x7FFE8712E6A0 | overloaded x2
        public void NotAMemberOfAnyType(){} // RVA: 0x7FFE8712E6E0
        public void ParameterExpressionNotValidAsDelegate(){} // RVA: 0x7FFE8712E780
        public void PropertyNotDefinedForType(){} // RVA: 0x7FFE8712E820
        public void InstancePropertyNotDefinedForType(){} // RVA: 0x7FFE8712E8D0
        public void InstancePropertyWithoutParameterNotDefinedForType(){} // RVA: 0x7FFE8712E980
        public void InstancePropertyWithSpecifiedParametersNotDefinedForType(){} // RVA: 0x7FFE8712EA20
        public void InstanceAndMethodTypeMismatch(){} // RVA: 0x7FFE8712EAE0
        public void TypeMissingDefaultConstructor(){} // RVA: 0x7FFE8712EBA0
        public void ElementInitializerMethodNotAdd(){} // RVA: 0x7FFE8712EC40
        public void ElementInitializerMethodNoRefOutParam(){} // RVA: 0x7FFE8712ECD0
        public void ElementInitializerMethodWithZeroArgs(){} // RVA: 0x7FFE8712ED80
        public void ElementInitializerMethodStatic(){} // RVA: 0x7FFE8712EE10
        public void TypeNotIEnumerable(){} // RVA: 0x7FFE8712EEA0
        public void UnhandledBinary(){} // RVA: 0x7FFE8712EF40
        public void UnhandledBinding(){} // RVA: 0x7FFE8712EFE0
        public void UnhandledBindingType(){} // RVA: 0x7FFE8712F070
        public void UnhandledUnary(){} // RVA: 0x7FFE8712F110
        public void UnknownBindingType(){} // RVA: 0x7FFE8712F1B0
        public void UserDefinedOpMustHaveConsistentTypes(){} // RVA: 0x7FFE8712F2D0
        public void UserDefinedOpMustHaveValidReturnType(){} // RVA: 0x7FFE8712F370
        public void LogicalOperatorMustHaveBooleanOperators(){} // RVA: 0x7FFE8712F410
        public void MethodWithArgsDoesNotExistOnType(){} // RVA: 0x7FFE8712F4B0
        public void GenericMethodWithArgsDoesNotExistOnType(){} // RVA: 0x7FFE8712F550
        public void MethodWithMoreThanOneMatch(){} // RVA: 0x7FFE8712F5F0
        public void PropertyWithMoreThanOneMatch(){} // RVA: 0x7FFE8712F690
        public void IncorrectNumberOfTypeArgsForFunc(){} // RVA: 0x7FFE8712F730
        public void IncorrectNumberOfTypeArgsForAction(){} // RVA: 0x7FFE8712F7C0
        public void ArgumentCannotBeOfTypeVoid(){} // RVA: 0x7FFE8712F850
        public void OutOfRange(){} // RVA: 0x7FFE8712F8E0
        public void LabelTargetAlreadyDefined(){} // RVA: 0x7FFE8712F990
        public void LabelTargetUndefined(){} // RVA: 0x7FFE8712FA30
        public void ControlCannotLeaveFinally(){} // RVA: 0x7FFE8712FAD0
        public void ControlCannotLeaveFilterTest(){} // RVA: 0x7FFE8712FB60
        public void AmbiguousJump(){} // RVA: 0x7FFE8712FBF0
        public void ControlCannotEnterTry(){} // RVA: 0x7FFE8712FC90
        public void ControlCannotEnterExpression(){} // RVA: 0x7FFE8712FD20
        public void NonLocalJumpWithValue(){} // RVA: 0x7FFE8712FDB0
        public void InvalidLvalue(){} // RVA: 0x7FFE8712FE50
        public void UndefinedVariable(){} // RVA: 0x7FFE8712FF10
        public void CannotCloseOverByRef(){} // RVA: 0x7FFE8712FFD0
        public void UnexpectedVarArgsCall(){} // RVA: 0x7FFE87130070
        public void RethrowRequiresCatch(){} // RVA: 0x7FFE87130110
        public void TryNotAllowedInFilter(){} // RVA: 0x7FFE871301A0
        public void MustRewriteToSameNode(){} // RVA: 0x7FFE87130230
        public void MustRewriteChildToSameType(){} // RVA: 0x7FFE871302F0
        public void MustRewriteWithoutMethod(){} // RVA: 0x7FFE871303B0
        public void TryNotSupportedForMethodsWithRefArgs(){} // RVA: 0x7FFE87130450
        public void TryNotSupportedForValueTypeInstances(){} // RVA: 0x7FFE871304F0
        public void TestValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7FFE87130590
        public void SwitchValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7FFE87130630
        public void ArgumentOutOfRange(){} // RVA: 0x7FFE871306D0
        public void NotSupported(){} // RVA: 0x7FFE87130760
        public void NonStaticConstructorRequired(){} // RVA: 0x7FFE871307E0
        public void NonAbstractConstructorRequired(){} // RVA: 0x7FFE87130870
        public void InvalidProgram(){} // RVA: 0x7FFE87130900
        public void EnumerationIsDone(){} // RVA: 0x7FFE87130980
        public void TypeContainsGenericParameters(){} // RVA: 0x7FFE87130AB0 | overloaded x2
        public void TypeIsGeneric(){} // RVA: 0x7FFE87130C10 | overloaded x2
        public void IncorrectNumberOfConstructorArguments(){} // RVA: 0x7FFE87130CD0
        public void ExpressionTypeDoesNotMatchMethodParameter(){} // RVA: 0x7FFE87130E20 | overloaded x2
        public void ExpressionTypeDoesNotMatchParameter(){} // RVA: 0x7FFE87130FA0 | overloaded x2
        public void IncorrectNumberOfLambdaArguments(){} // RVA: 0x7FFE87131060
        public void IncorrectNumberOfMethodCallArguments(){} // RVA: 0x7FFE871310F0
        public void ExpressionTypeDoesNotMatchConstructorParameter(){} // RVA: 0x7FFE87131240 | overloaded x2
        public void ExpressionMustBeReadable(){} // RVA: 0x7FFE87131390 | overloaded x2
        public void InvalidArgumentValue(){} // RVA: 0x7FFE87131430
        public void NonEmptyCollectionRequired(){} // RVA: 0x7FFE871314C0
        public void InvalidNullValue(){} // RVA: 0x7FFE87131550
        public void InvalidTypeException(){} // RVA: 0x7FFE871315F0
        public void GetParamName(){} // RVA: 0x7FFE871316D0
    }

    public class Expression : Object
    {
        public System.Dynamic.Utils.CacheDict`2<System.Type,System.Reflection.MethodInfo> s_lambdaDelegateCache;
        public System.Dynamic.Utils.CacheDict`2<System.Type,System.Func`5<System.Linq.Expressions.Expression,string,bool,System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>,System.Linq.Expressions.LambdaExpression>> s_lambdaFactories; // 0x8
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Linq.Expressions.Expression,ExtensionInfo> s_legacyCtorSupportTable; // 0x10
        public object field_3; // 0x8E

        // ── Methods ──
        public void Assign(){} // RVA: 0x7FFE870F00D0
        public void GetUserDefinedBinaryOperator(){} // RVA: 0x7FFE870F15F0 | overloaded x2
        public void GetMethodBasedBinaryOperator(){} // RVA: 0x7FFE870F0740
        public void GetMethodBasedAssignOperator(){} // RVA: 0x7FFE870F0DE0
        public void GetUserDefinedBinaryOperatorOrThrow(){} // RVA: 0x7FFE870F10B0
        public void GetUserDefinedAssignOperatorOrThrow(){} // RVA: 0x7FFE870F1320
        public void IsLiftingConditionalLogicalOperator(){} // RVA: 0x7FFE870F19D0
        public void ParameterIsAssignable(){} // RVA: 0x7FFE870F1A90
        public void ValidateParamswithOperandsOrThrow(){} // RVA: 0x7FFE870F1B50
        public void ValidateOperator(){} // RVA: 0x7FFE870F1C40
        public void ValidateMethodInfo(){} // RVA: 0x7FFE870F1E20
        public void IsNullComparison(){} // RVA: 0x7FFE870F1EB0
        public void IsNullConstant(){} // RVA: 0x7FFE870F2130
        public void ValidateUserDefinedConditionalLogicOperator(){} // RVA: 0x7FFE870F21C0
        public void VerifyOpTrueFalse(){} // RVA: 0x7FFE870F2970
        public void IsValidLiftedConditionalLogicalOperator(){} // RVA: 0x7FFE870F2B60
        public void MakeBinary(){} // RVA: 0x7FFE870F2E30 | overloaded x3
        public void Equal(){} // RVA: 0x7FFE870F3800 | overloaded x2
        public void ReferenceEqual(){} // RVA: 0x7FFE870F3930
        public void NotEqual(){} // RVA: 0x7FFE870F3B50 | overloaded x2
        public void ReferenceNotEqual(){} // RVA: 0x7FFE870F3C80
        public void GetEqualityComparisonOperator(){} // RVA: 0x7FFE870F3E30
        public void GreaterThan(){} // RVA: 0x7FFE870F4330 | overloaded x2
        public void LessThan(){} // RVA: 0x7FFE870F44D0 | overloaded x2
        public void GreaterThanOrEqual(){} // RVA: 0x7FFE870F4670 | overloaded x2
        public void LessThanOrEqual(){} // RVA: 0x7FFE870F4810 | overloaded x2
        public void GetComparisonOperator(){} // RVA: 0x7FFE870F4940
        public void AndAlso(){} // RVA: 0x7FFE870F4C10 | overloaded x2
        public void OrElse(){} // RVA: 0x7FFE870F53A0 | overloaded x2
        public void Coalesce(){} // RVA: 0x7FFE870F5AF0 | overloaded x2
        public void ValidateCoalesceArgTypes(){} // RVA: 0x7FFE870F6090
        public void Add(){} // RVA: 0x7FFE870F6340 | overloaded x2
        public void AddAssign(){} // RVA: 0x7FFE870F6690 | overloaded x3
        public void ValidateOpAssignConversionLambda(){} // RVA: 0x7FFE870F6960
        public void AddAssignChecked(){} // RVA: 0x7FFE870F6E00 | overloaded x3
        public void AddChecked(){} // RVA: 0x7FFE870F7140 | overloaded x2
        public void Subtract(){} // RVA: 0x7FFE870F7420 | overloaded x2
        public void SubtractAssign(){} // RVA: 0x7FFE870F7780 | overloaded x3
        public void SubtractAssignChecked(){} // RVA: 0x7FFE870F7B80 | overloaded x3
        public void SubtractChecked(){} // RVA: 0x7FFE870F7EC0 | overloaded x2
        public void Divide(){} // RVA: 0x7FFE870F81A0 | overloaded x2
        public void DivideAssign(){} // RVA: 0x7FFE870F8500 | overloaded x3
        public void Modulo(){} // RVA: 0x7FFE870F8840 | overloaded x2
        public void ModuloAssign(){} // RVA: 0x7FFE870F8BA0 | overloaded x3
        public void Multiply(){} // RVA: 0x7FFE870F8EE0 | overloaded x2
        public void MultiplyAssign(){} // RVA: 0x7FFE870F9240 | overloaded x3
        public void MultiplyAssignChecked(){} // RVA: 0x7FFE870F9640 | overloaded x3
        public void MultiplyChecked(){} // RVA: 0x7FFE870F9980 | overloaded x2
        public void IsSimpleShift(){} // RVA: 0x7FFE870F9BF0
        public void GetResultTypeOfShift(){} // RVA: 0x7FFE870F9CD0
        public void LeftShift(){} // RVA: 0x7FFE870F9EC0 | overloaded x2
        public void LeftShiftAssign(){} // RVA: 0x7FFE870FA210 | overloaded x3
        public void RightShift(){} // RVA: 0x7FFE870FA530 | overloaded x2
        public void RightShiftAssign(){} // RVA: 0x7FFE870FA880 | overloaded x3
        public void And(){} // RVA: 0x7FFE870FABA0 | overloaded x2
        public void AndAssign(){} // RVA: 0x7FFE870FAF00 | overloaded x3
        public void Or(){} // RVA: 0x7FFE870FB240 | overloaded x2
        public void OrAssign(){} // RVA: 0x7FFE870FB5A0 | overloaded x3
        public void ExclusiveOr(){} // RVA: 0x7FFE870FB8E0 | overloaded x2
        public void ExclusiveOrAssign(){} // RVA: 0x7FFE870FBC40 | overloaded x3
        public void Power(){} // RVA: 0x7FFE870FBF80 | overloaded x2
        public void PowerAssign(){} // RVA: 0x7FFE870FC490 | overloaded x3
        public void ArrayIndex(){} // RVA: 0x7FFE8710F9A0 | overloaded x3
        public void Block(){} // RVA: 0x7FFE870FD300 | overloaded x12
        public void BlockCore(){} // RVA: 0x7FFE870FD620
        public void ValidateVariables(){} // RVA: 0x7FFE870FDA90
        public void GetOptimizedBlockExpression(){} // RVA: 0x7FFE870FDD30
        public void Catch(){} // RVA: 0x7FFE870FE400 | overloaded x4
        public void MakeCatchBlock(){} // RVA: 0x7FFE870FE500
        public void Condition(){} // RVA: 0x7FFE870FEC60 | overloaded x2
        public void IfThen(){} // RVA: 0x7FFE870FEFA0
        public void IfThenElse(){} // RVA: 0x7FFE870FF0C0
        public void Constant(){} // RVA: 0x7FFE870FF240 | overloaded x2
        public void DebugInfo(){} // RVA: 0x7FFE870FF4C0
        public void ClearDebugInfo(){} // RVA: 0x7FFE870FF640
        public void ValidateSpan(){} // RVA: 0x7FFE870FF700
        public void Empty(){} // RVA: 0x7FFE870FF8F0
        public void Default(){} // RVA: 0x7FFE870FF9E0
        public void ElementInit(){} // RVA: 0x7FFE870FFB40 | overloaded x2
        public void ValidateElementInitAddMethodInfo(){} // RVA: 0x7FFE870FFDA0
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFE87100320
        public void get_Type(){} // RVA: 0x7FFE87100420
        public void get_CanReduce(){} // RVA: 0x7FFE810FB320
        public void Reduce(){} // RVA: 0x7FFE87100520
        public void VisitChildren(){} // RVA: 0x7FFE87100570
        public void Accept(){} // RVA: 0x7FFE87100600
        public void ReduceAndCheck(){} // RVA: 0x7FFE87100630
        public void ReduceExtensions(){} // RVA: 0x7FFE87100790
        public void ToString(){} // RVA: 0x7FFE871007F0
        public void get_DebugView(){} // RVA: 0x7FFE87100880
        public void RequiresCanRead(){} // RVA: 0x7FFE87100A10
        public void RequiresCanWrite(){} // RVA: 0x7FFE87100B40
        public void Dynamic(){} // RVA: 0x7FFE87100DD0 | overloaded x6
        public void MakeDynamic(){} // RVA: 0x7FFE87100E70 | overloaded x6
        public void Break(){} // RVA: 0x7FFE87101160 | overloaded x4
        public void Continue(){} // RVA: 0x7FFE871012E0 | overloaded x2
        public void Return(){} // RVA: 0x7FFE871015D0 | overloaded x4
        public void Goto(){} // RVA: 0x7FFE871018D0 | overloaded x4
        public void MakeGoto(){} // RVA: 0x7FFE87101950
        public void ValidateGoto(){} // RVA: 0x7FFE87101B60
        public void ValidateGotoType(){} // RVA: 0x7FFE87101D20
        public void MakeIndex(){} // RVA: 0x7FFE87101EE0
        public void ArrayAccess(){} // RVA: 0x7FFE87101FE0 | overloaded x2
        public void Property(){} // RVA: 0x7FFE8710A2F0 | overloaded x7
        public void FindInstanceProperty(){} // RVA: 0x7FFE871026A0
        public void GetArgTypesString(){} // RVA: 0x7FFE871027F0
        public void FindProperty(){} // RVA: 0x7FFE871029B0
        public void IsCompatible(){} // RVA: 0x7FFE8710F5D0 | overloaded x2
        public void MakeIndexProperty(){} // RVA: 0x7FFE87102EF0
        public void ValidateIndexedProperty(){} // RVA: 0x7FFE87102FC0
        public void ValidateAccessor(){} // RVA: 0x7FFE87103650
        public void ValidateAccessorArgumentTypes(){} // RVA: 0x7FFE87103920
        public void Invoke(){} // RVA: 0x7FFE87105160 | overloaded x8
        public void GetInvokeMethod(){} // RVA: 0x7FFE87105610
        public void Label(){} // RVA: 0x7FFE87105CB0 | overloaded x6
        public void CreateLambda(){} // RVA: 0x7FFE87105E50
        public void Lambda(){} // RVA: 0x7FFE87106F00 | overloaded x18
        public void ValidateLambdaArgs(){} // RVA: 0x7FFE87106FF0
        public void ValidateTryGetFuncActionArgs(){} // RVA: 0x7FFE871078D0
        public void GetFuncType(){} // RVA: 0x7FFE87107A00
        public void TryGetFuncType(){} // RVA: 0x7FFE87107B70
        public void GetActionType(){} // RVA: 0x7FFE87107CE0
        public void TryGetActionType(){} // RVA: 0x7FFE87107E50
        public void GetDelegateType(){} // RVA: 0x7FFE87107FC0
        public void ListInit(){} // RVA: 0x7FFE87108AA0 | overloaded x6
        public void Loop(){} // RVA: 0x7FFE87108D40 | overloaded x3
        public void Bind(){} // RVA: 0x7FFE871091E0 | overloaded x2
        public void ValidateSettableFieldOrPropertyMember(){} // RVA: 0x7FFE87109390
        public void Field(){} // RVA: 0x7FFE871099D0 | overloaded x3
        public void GetProperty(){} // RVA: 0x7FFE8710A440
        public void CheckMethod(){} // RVA: 0x7FFE8710A6A0
        public void PropertyOrField(){} // RVA: 0x7FFE8710A880
        public void MakeMemberAccess(){} // RVA: 0x7FFE8710AB50
        public void MemberInit(){} // RVA: 0x7FFE8710AD60 | overloaded x2
        public void ListBind(){} // RVA: 0x7FFE8710B3F0 | overloaded x4
        public void ValidateListInitArgs(){} // RVA: 0x7FFE8710B540
        public void MemberBind(){} // RVA: 0x7FFE8710BBA0 | overloaded x4
        public void ValidateGettableFieldOrPropertyMember(){} // RVA: 0x7FFE8710BC80
        public void ValidateMemberInitArgs(){} // RVA: 0x7FFE8710BEE0
        public void Call(){} // RVA: 0x7FFE8710E7C0 | overloaded x16
        public void ValidateMethodAndGetParameters(){} // RVA: 0x7FFE8710EDD0
        public void ValidateStaticOrInstanceMethod(){} // RVA: 0x7FFE8710F010
        public void ValidateCallInstanceType(){} // RVA: 0x7FFE8710F130
        public void ValidateArgumentTypes(){} // RVA: 0x7FFE8710F1E0
        public void GetParametersForValidation(){} // RVA: 0x7FFE8710F1F0
        public void ValidateArgumentCount(){} // RVA: 0x7FFE8710F200
        public void ValidateOneArgument(){} // RVA: 0x7FFE8710F210
        public void TryQuote(){} // RVA: 0x7FFE8710F250
        public void FindMethod(){} // RVA: 0x7FFE8710F260
        public void ApplyTypeArgs(){} // RVA: 0x7FFE8710F870
        public void NewArrayInit(){} // RVA: 0x7FFE8710FEA0 | overloaded x2
        public void NewArrayBounds(){} // RVA: 0x7FFE871104C0 | overloaded x2
        public void New(){} // RVA: 0x7FFE87110FA0 | overloaded x6
        public void ValidateNewArgs(){} // RVA: 0x7FFE87111410
        public void ValidateAnonymousTypeMember(){} // RVA: 0x7FFE87111F10
        public void ValidateConstructor(){} // RVA: 0x7FFE871122C0
        public void Parameter(){} // RVA: 0x7FFE871123E0 | overloaded x2
        public void Variable(){} // RVA: 0x7FFE871124A0 | overloaded x2
        public void Validate(){} // RVA: 0x7FFE87112510
        public void RuntimeVariables(){} // RVA: 0x7FFE87112700 | overloaded x2
        public void SwitchCase(){} // RVA: 0x7FFE871129F0 | overloaded x2
        public void Switch(){} // RVA: 0x7FFE87112EF0 | overloaded x6
        public void ValidateSwitchCaseType(){} // RVA: 0x7FFE87113C80
        public void SymbolDocument(){} // RVA: 0x7FFE87114050 | overloaded x4
        public void TryFault(){} // RVA: 0x7FFE87114120
        public void TryFinally(){} // RVA: 0x7FFE87114190
        public void TryCatch(){} // RVA: 0x7FFE87114200
        public void TryCatchFinally(){} // RVA: 0x7FFE87114270
        public void MakeTry(){} // RVA: 0x7FFE871142F0
        public void ValidateTryAndCatchHaveSameType(){} // RVA: 0x7FFE87114570
        public void TypeIs(){} // RVA: 0x7FFE87114BE0
        public void TypeEqual(){} // RVA: 0x7FFE87114D40
        public void MakeUnary(){} // RVA: 0x7FFE87114F20 | overloaded x2
        public void GetUserDefinedUnaryOperatorOrThrow(){} // RVA: 0x7FFE87115610
        public void GetUserDefinedUnaryOperator(){} // RVA: 0x7FFE871157B0
        public void GetMethodBasedUnaryOperator(){} // RVA: 0x7FFE87115B50
        public void GetUserDefinedCoercionOrThrow(){} // RVA: 0x7FFE87115FA0
        public void GetUserDefinedCoercion(){} // RVA: 0x7FFE87116110
        public void GetMethodBasedCoercionOperator(){} // RVA: 0x7FFE87116210
        public void Negate(){} // RVA: 0x7FFE87116720 | overloaded x2
        public void UnaryPlus(){} // RVA: 0x7FFE87116970 | overloaded x2
        public void NegateChecked(){} // RVA: 0x7FFE87116B80 | overloaded x2
        public void Not(){} // RVA: 0x7FFE87116DD0 | overloaded x2
        public void IsFalse(){} // RVA: 0x7FFE87117020 | overloaded x2
        public void IsTrue(){} // RVA: 0x7FFE87117230 | overloaded x2
        public void OnesComplement(){} // RVA: 0x7FFE87117440 | overloaded x2
        public void TypeAs(){} // RVA: 0x7FFE871175F0
        public void Unbox(){} // RVA: 0x7FFE871177B0
        public void Convert(){} // RVA: 0x7FFE87117A90 | overloaded x2
        public void ConvertChecked(){} // RVA: 0x7FFE87117D50 | overloaded x2
        public void ArrayLength(){} // RVA: 0x7FFE87117FD0
        public void Quote(){} // RVA: 0x7FFE87118220
        public void Rethrow(){} // RVA: 0x7FFE87118590 | overloaded x2
        public void Throw(){} // RVA: 0x7FFE871187D0 | overloaded x2
        public void Increment(){} // RVA: 0x7FFE871189F0 | overloaded x2
        public void Decrement(){} // RVA: 0x7FFE87118C00 | overloaded x2
        public void PreIncrementAssign(){} // RVA: 0x7FFE87118E10 | overloaded x2
        public void PreDecrementAssign(){} // RVA: 0x7FFE87118EE0 | overloaded x2
        public void PostIncrementAssign(){} // RVA: 0x7FFE87118FB0 | overloaded x2
        public void PostDecrementAssign(){} // RVA: 0x7FFE87119080 | overloaded x2
        public void MakeOpAssignUnary(){} // RVA: 0x7FFE871190F0
        public void .cctor(){} // RVA: 0x7FFE871193B0
    }

    public class Expression0`1 : Expression`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_ParameterCount(){} // RVA: 0x7FFE80E2EDB0
        public void SameParameters(){} // RVA: 0x7FFE80E2F3B0
        public void GetParameter(){} // RVA: 0x7FFE80E3D230
        public void GetOrMakeParameters(){} // RVA: 0x7FFE80E2E2E0
        public void Rewrite(){} // RVA: 0x7FFE80E3FC10
    }

    public class Expression1`1 : Expression`1
    {
        public object _par0;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4F230
        public void get_ParameterCount(){} // RVA: 0x7FFE80E2EDB0
        public void GetParameter(){} // RVA: 0x7FFE80E3D230
        public void SameParameters(){} // RVA: 0x7FFE80E2F3B0
        public void GetOrMakeParameters(){} // RVA: 0x7FFE80E2E2E0
        public void Rewrite(){} // RVA: 0x7FFE80E3FC10
    }

    public class Expression2`1 : Expression`1
    {
        public object _par0;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E50660
        public void get_ParameterCount(){} // RVA: 0x7FFE80E2EDB0
        public void GetParameter(){} // RVA: 0x7FFE80E3D230
        public void SameParameters(){} // RVA: 0x7FFE80E2F3B0
        public void GetOrMakeParameters(){} // RVA: 0x7FFE80E2E2E0
        public void Rewrite(){} // RVA: 0x7FFE80E3FC10
    }

    public class Expression3`1 : Expression`1
    {
        public object _par0;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E50FC0
        public void get_ParameterCount(){} // RVA: 0x7FFE80E2EDB0
        public void GetParameter(){} // RVA: 0x7FFE80E3D230
        public void SameParameters(){} // RVA: 0x7FFE80E2F3B0
        public void GetOrMakeParameters(){} // RVA: 0x7FFE80E2E2E0
        public void Rewrite(){} // RVA: 0x7FFE80E3FC10
    }

    public class ExpressionCreator`1 : Object
    {
        // ── Methods ──
        public void CreateExpressionFunc(){} // RVA: 0x7FFE80E3FE80
    }

    public class ExpressionExtension : Object
    {
        // ── Methods ──
        public void MakeDynamic(){} // RVA: 0x7FFE87129AB0 | overloaded x7
        public void GetValidMethodForDynamic(){} // RVA: 0x7FFE87128980
        public void Dynamic(){} // RVA: 0x7FFE871298C0 | overloaded x6
        public void ValidateDynamicArgument(){} // RVA: 0x7FFE8712A030 | overloaded x2
    }

    public class ExpressionN`1 : Expression`1
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.ParameterExpression> _parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4F230
        public void get_ParameterCount(){} // RVA: 0x7FFE80E2EDB0
        public void GetParameter(){} // RVA: 0x7FFE80E3D230
        public void SameParameters(){} // RVA: 0x7FFE80E2F3B0
        public void GetOrMakeParameters(){} // RVA: 0x7FFE80E2E2E0
        public void Rewrite(){} // RVA: 0x7FFE80E3FC10
    }

    public class ExpressionStringBuilder : ExpressionVisitor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87131790
        public void ToString(){} // RVA: 0x7FFE81DE31E0
        public void GetLabelId(){} // RVA: 0x7FFE87131830
        public void GetParamId(){} // RVA: 0x7FFE87131830
        public void GetId(){} // RVA: 0x7FFE87131840
        public void Out(){} // RVA: 0x7FFE87131A10 | overloaded x2
        public void ExpressionToString(){} // RVA: 0x7FFE871007F0
        public void CatchBlockToString(){} // RVA: 0x7FFE8711E560
        public void SwitchCaseToString(){} // RVA: 0x7FFE87131A30
        public void MemberBindingToString(){} // RVA: 0x7FFE87131AC0
        public void ElementInitBindingToString(){} // RVA: 0x7FFE8712A390
        public void VisitExpressions(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void VisitBinary(){} // RVA: 0x7FFE87131B50
        public void VisitParameter(){} // RVA: 0x7FFE871323F0
        public void VisitLambda(){} // RVA: 0x7FFE80E2E390
        public void VisitListInit(){} // RVA: 0x7FFE87132560
        public void VisitConditional(){} // RVA: 0x7FFE87132730
        public void VisitConstant(){} // RVA: 0x7FFE871328B0
        public void VisitDebugInfo(){} // RVA: 0x7FFE87132B90
        public void VisitRuntimeVariables(){} // RVA: 0x7FFE87132F10
        public void OutMember(){} // RVA: 0x7FFE87132F80
        public void VisitMember(){} // RVA: 0x7FFE871330A0
        public void VisitMemberInit(){} // RVA: 0x7FFE87133210
        public void VisitMemberAssignment(){} // RVA: 0x7FFE87133530
        public void VisitMemberListBinding(){} // RVA: 0x7FFE871335E0
        public void VisitMemberMemberBinding(){} // RVA: 0x7FFE871337D0
        public void VisitElementInit(){} // RVA: 0x7FFE871339C0
        public void VisitInvocation(){} // RVA: 0x7FFE87133BF0
        public void VisitMethodCall(){} // RVA: 0x7FFE87133D80
        public void VisitNewArray(){} // RVA: 0x7FFE871340C0
        public void VisitNew(){} // RVA: 0x7FFE87134210
        public void VisitTypeBinary(){} // RVA: 0x7FFE871344D0
        public void VisitUnary(){} // RVA: 0x7FFE871346A0
        public void VisitBlock(){} // RVA: 0x7FFE87134E00
        public void VisitDefault(){} // RVA: 0x7FFE87135180
        public void VisitLabel(){} // RVA: 0x7FFE871352A0
        public void VisitGoto(){} // RVA: 0x7FFE87135380
        public void VisitLoop(){} // RVA: 0x7FFE87135580
        public void VisitSwitchCase(){} // RVA: 0x7FFE871355E0
        public void VisitSwitch(){} // RVA: 0x7FFE871356A0
        public void VisitCatchBlock(){} // RVA: 0x7FFE871357B0
        public void VisitTry(){} // RVA: 0x7FFE87135920
        public void VisitIndex(){} // RVA: 0x7FFE87135980
        public void VisitExtension(){} // RVA: 0x7FFE87135C50
        public void DumpLabel(){} // RVA: 0x7FFE87135FA0
        public void IsBool(){} // RVA: 0x7FFE871360D0
    }

    public class ExpressionVisitor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Visit(){} // RVA: 0x7FFE80E2E440 | overloaded x3
        public void VisitArguments(){} // RVA: 0x7FFE871365B0
        public void VisitParameters(){} // RVA: 0x7FFE871365C0
        public void VisitAndConvert(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void VisitBinary(){} // RVA: 0x7FFE871365D0
        public void VisitBlock(){} // RVA: 0x7FFE871366E0
        public void VisitConditional(){} // RVA: 0x7FFE871367E0
        public void VisitConstant(){} // RVA: 0x7FFE82153650
        public void VisitDebugInfo(){} // RVA: 0x7FFE82153650
        public void VisitDefault(){} // RVA: 0x7FFE82153650
        public void VisitExtension(){} // RVA: 0x7FFE8711F190
        public void VisitGoto(){} // RVA: 0x7FFE87136930
        public void VisitInvocation(){} // RVA: 0x7FFE87136A30
        public void VisitLabelTarget(){} // RVA: 0x7FFE82153650
        public void VisitLabel(){} // RVA: 0x7FFE87136AD0
        public void VisitLambda(){} // RVA: 0x7FFE80E2E390
        public void VisitLoop(){} // RVA: 0x7FFE87136BA0
        public void VisitMember(){} // RVA: 0x7FFE87136CA0
        public void VisitIndex(){} // RVA: 0x7FFE87136D50
        public void VisitMethodCall(){} // RVA: 0x7FFE87136EA0
        public void VisitNewArray(){} // RVA: 0x7FFE87136F70
        public void VisitNew(){} // RVA: 0x7FFE87136FB0
        public void VisitParameter(){} // RVA: 0x7FFE82153650
        public void VisitRuntimeVariables(){} // RVA: 0x7FFE871370E0
        public void VisitSwitchCase(){} // RVA: 0x7FFE871371E0
        public void VisitSwitch(){} // RVA: 0x7FFE871372E0
        public void VisitCatchBlock(){} // RVA: 0x7FFE87137510
        public void VisitTry(){} // RVA: 0x7FFE87137660
        public void VisitTypeBinary(){} // RVA: 0x7FFE87137840
        public void VisitUnary(){} // RVA: 0x7FFE87137920
        public void VisitMemberInit(){} // RVA: 0x7FFE87137B00
        public void VisitListInit(){} // RVA: 0x7FFE87137CA0
        public void VisitElementInit(){} // RVA: 0x7FFE87137E40
        public void VisitMemberBinding(){} // RVA: 0x7FFE87137ED0
        public void VisitMemberAssignment(){} // RVA: 0x7FFE87138070
        public void VisitMemberMemberBinding(){} // RVA: 0x7FFE87138110
        public void VisitMemberListBinding(){} // RVA: 0x7FFE87138260
        public void ValidateUnary(){} // RVA: 0x7FFE871383B0
        public void ValidateBinary(){} // RVA: 0x7FFE871384C0
        public void ValidateSwitch(){} // RVA: 0x7FFE87138660
        public void ValidateChildType(){} // RVA: 0x7FFE871386E0
        public void VisitDynamic(){} // RVA: 0x7FFE8712A230
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83F9BDB0 | overloaded x2
        public void get_TypeCore(){} // RVA: 0x7FFE83F9BDC0
        public void get_PublicType(){} // RVA: 0x7FFE83F9BE70
        public void Compile(){} // RVA: 0x7FFE81081080 | overloaded x3
        public void Update(){} // RVA: 0x7FFE83F9C1D0
        public void SameParameters(){} // RVA: 0x7FFE83F9BCC0
        public void Rewrite(){} // RVA: 0x7FFE83F9BCE0
        public void Accept(){} // RVA: 0x7FFE83F9BD00
    }

}