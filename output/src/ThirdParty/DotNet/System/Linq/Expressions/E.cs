// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 13
// Methods: 751

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class ElementInit : Object
    {
        public System.Reflection.MethodInfo AddMethod; // 0x10
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression> Arguments; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D82070 | overloaded x2
        public void get_AddMethod(){} // RVA: 0x7FFAC2F3C380
        public void get_Arguments(){} // RVA: 0x7FFAC2F247C0
        public void GetArgument(){} // RVA: 0x7FFAC8D81E50
        public void get_ArgumentCount(){} // RVA: 0x7FFAC8D81EE0
        public void ToString(){} // RVA: 0x7FFAC8D81F60
        public void Update(){} // RVA: 0x7FFAC8D81FF0
    }

    public class Error : Object
    {
        // ── Methods ──
        public void ReducibleMustOverrideReduce(){} // RVA: 0x7FFAC8D820A0
        public void ArgCntMustBeGreaterThanNameCnt(){} // RVA: 0x7FFAC8D82130
        public void InvalidMetaObjectCreated(){} // RVA: 0x7FFAC8D821C0
        public void AmbiguousMatchInExpandoObject(){} // RVA: 0x7FFAC8D82260
        public void SameKeyExistsInExpando(){} // RVA: 0x7FFAC8D82300
        public void KeyDoesNotExistInExpando(){} // RVA: 0x7FFAC8D823B0
        public void CollectionModifiedWhileEnumerating(){} // RVA: 0x7FFAC8D82450
        public void CollectionReadOnly(){} // RVA: 0x7FFAC8D824E0
        public void MustReduceToDifferent(){} // RVA: 0x7FFAC8D82570
        public void BinderNotCompatibleWithCallSite(){} // RVA: 0x7FFAC8D82600
        public void DynamicBindingNeedsRestrictions(){} // RVA: 0x7FFAC8D826C0
        public void DynamicObjectResultNotAssignable(){} // RVA: 0x7FFAC8D82760
        public void DynamicBinderResultNotAssignable(){} // RVA: 0x7FFAC8D82800
        public void BindingCannotBeNull(){} // RVA: 0x7FFAC8D828C0
        public void ReducedNotCompatible(){} // RVA: 0x7FFAC8D82950
        public void SetterHasNoParams(){} // RVA: 0x7FFAC8D829E0
        public void PropertyCannotHaveRefType(){} // RVA: 0x7FFAC8D82A70
        public void IndexesOfSetGetMustMatch(){} // RVA: 0x7FFAC8D82B00
        public void TypeParameterIsNotDelegate(){} // RVA: 0x7FFAC8D82B90
        public void FirstArgumentMustBeCallSite(){} // RVA: 0x7FFAC8D82C30
        public void AccessorsCannotHaveVarArgs(){} // RVA: 0x7FFAC8D82CC0
        public void AccessorsCannotHaveByRefArgs(){} // RVA: 0x7FFAC8D82DE0 | overloaded x2
        public void TypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x7FFAC8D82E80
        public void NoOrInvalidRuleProduced(){} // RVA: 0x7FFAC8D82F10
        public void BoundsCannotBeLessThanOne(){} // RVA: 0x7FFAC8D82FA0
        public void TypeMustNotBeByRef(){} // RVA: 0x7FFAC8D83030
        public void TypeMustNotBePointer(){} // RVA: 0x7FFAC8D830C0
        public void SetterMustBeVoid(){} // RVA: 0x7FFAC8D83150
        public void PropertyTypeMustMatchGetter(){} // RVA: 0x7FFAC8D831E0
        public void PropertyTypeMustMatchSetter(){} // RVA: 0x7FFAC8D83270
        public void BothAccessorsMustBeStatic(){} // RVA: 0x7FFAC8D83300
        public void OnlyStaticFieldsHaveNullInstance(){} // RVA: 0x7FFAC8D83390
        public void OnlyStaticPropertiesHaveNullInstance(){} // RVA: 0x7FFAC8D83420
        public void OnlyStaticMethodsHaveNullInstance(){} // RVA: 0x7FFAC8D834B0
        public void PropertyTypeCannotBeVoid(){} // RVA: 0x7FFAC8D83540
        public void InvalidUnboxType(){} // RVA: 0x7FFAC8D835D0
        public void ExpressionMustBeWriteable(){} // RVA: 0x7FFAC8D83660
        public void ArgumentMustNotHaveValueType(){} // RVA: 0x7FFAC8D836F0
        public void MustBeReducible(){} // RVA: 0x7FFAC8D83780
        public void AllTestValuesMustHaveSameType(){} // RVA: 0x7FFAC8D83810
        public void AllCaseBodiesMustHaveSameType(){} // RVA: 0x7FFAC8D838A0
        public void DefaultBodyMustBeSupplied(){} // RVA: 0x7FFAC8D83930
        public void LabelMustBeVoidOrHaveExpression(){} // RVA: 0x7FFAC8D839C0
        public void LabelTypeMustBeVoid(){} // RVA: 0x7FFAC8D83A50
        public void QuotedExpressionMustBeLambda(){} // RVA: 0x7FFAC8D83AE0
        public void VariableMustNotBeByRef(){} // RVA: 0x7FFAC8D83C20 | overloaded x2
        public void DuplicateVariable(){} // RVA: 0x7FFAC8D83D00 | overloaded x2
        public void StartEndMustBeOrdered(){} // RVA: 0x7FFAC8D83DC0
        public void FaultCannotHaveCatchOrFinally(){} // RVA: 0x7FFAC8D83E50
        public void TryMustHaveCatchFinallyOrFault(){} // RVA: 0x7FFAC8D83EE0
        public void BodyOfCatchMustHaveSameTypeAsBodyOfTry(){} // RVA: 0x7FFAC8D83F70
        public void ExtensionNodeMustOverrideProperty(){} // RVA: 0x7FFAC8D84000
        public void UserDefinedOperatorMustBeStatic(){} // RVA: 0x7FFAC8D840A0
        public void UserDefinedOperatorMustNotBeVoid(){} // RVA: 0x7FFAC8D84140
        public void CoercionOperatorNotDefined(){} // RVA: 0x7FFAC8D841E0
        public void UnaryOperatorNotDefined(){} // RVA: 0x7FFAC8D84280
        public void BinaryOperatorNotDefined(){} // RVA: 0x7FFAC8D84320
        public void ReferenceEqualityNotDefined(){} // RVA: 0x7FFAC8D843E0
        public void OperandTypesDoNotMatchParameters(){} // RVA: 0x7FFAC8D84480
        public void OverloadOperatorTypeDoesNotMatchConversionType(){} // RVA: 0x7FFAC8D84520
        public void ConversionIsNotSupportedForArithmeticTypes(){} // RVA: 0x7FFAC8D845C0
        public void ArgumentTypeCannotBeVoid(){} // RVA: 0x7FFAC8D84650
        public void ArgumentMustBeArray(){} // RVA: 0x7FFAC8D846E0
        public void ArgumentMustBeBoolean(){} // RVA: 0x7FFAC8D84770
        public void EqualityMustReturnBoolean(){} // RVA: 0x7FFAC8D84800
        public void ArgumentMustBeFieldInfoOrPropertyInfo(){} // RVA: 0x7FFAC8D848A0
        public void ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(){} // RVA: 0x7FFAC8D849C0 | overloaded x2
        public void ArgumentMustBeInstanceMember(){} // RVA: 0x7FFAC8D84AF0 | overloaded x2
        public void ArgumentMustBeInteger(){} // RVA: 0x7FFAC8D84C20 | overloaded x2
        public void ArgumentMustBeArrayIndexType(){} // RVA: 0x7FFAC8D84D50 | overloaded x2
        public void ArgumentMustBeSingleDimensionalArrayType(){} // RVA: 0x7FFAC8D84D70
        public void ArgumentTypesMustMatch(){} // RVA: 0x7FFAC8D84E90 | overloaded x2
        public void CannotAutoInitializeValueTypeElementThroughProperty(){} // RVA: 0x7FFAC8D84F20
        public void CannotAutoInitializeValueTypeMemberThroughProperty(){} // RVA: 0x7FFAC8D84FC0
        public void IncorrectTypeForTypeAs(){} // RVA: 0x7FFAC8D85060
        public void CoalesceUsedOnNonNullType(){} // RVA: 0x7FFAC8D85100
        public void ExpressionTypeCannotInitializeArrayType(){} // RVA: 0x7FFAC8D85190
        public void ArgumentTypeDoesNotMatchMember(){} // RVA: 0x7FFAC8D852E0 | overloaded x2
        public void ArgumentMemberNotDeclOnType(){} // RVA: 0x7FFAC8D85450 | overloaded x2
        public void ExpressionTypeDoesNotMatchReturn(){} // RVA: 0x7FFAC8D85510
        public void ExpressionTypeDoesNotMatchAssignment(){} // RVA: 0x7FFAC8D855B0
        public void ExpressionTypeDoesNotMatchLabel(){} // RVA: 0x7FFAC8D85650
        public void ExpressionTypeNotInvocable(){} // RVA: 0x7FFAC8D856F0
        public void FieldNotDefinedForType(){} // RVA: 0x7FFAC8D85790
        public void InstanceFieldNotDefinedForType(){} // RVA: 0x7FFAC8D85830
        public void FieldInfoNotDefinedForType(){} // RVA: 0x7FFAC8D858D0
        public void IncorrectNumberOfIndexes(){} // RVA: 0x7FFAC8D85990
        public void IncorrectNumberOfLambdaDeclarationParameters(){} // RVA: 0x7FFAC8D85A20
        public void IncorrectNumberOfMembersForGivenConstructor(){} // RVA: 0x7FFAC8D85AB0
        public void IncorrectNumberOfArgumentsForMembers(){} // RVA: 0x7FFAC8D85B40
        public void LambdaTypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x7FFAC8D85BD0
        public void MemberNotFieldOrProperty(){} // RVA: 0x7FFAC8D85C60
        public void MethodContainsGenericParameters(){} // RVA: 0x7FFAC8D85D00
        public void MethodIsGeneric(){} // RVA: 0x7FFAC8D85DA0
        public void MethodNotPropertyAccessor(){} // RVA: 0x7FFAC8D85EF0 | overloaded x2
        public void PropertyDoesNotHaveGetter(){} // RVA: 0x7FFAC8D86050 | overloaded x2
        public void PropertyDoesNotHaveSetter(){} // RVA: 0x7FFAC8D86080
        public void PropertyDoesNotHaveAccessor(){} // RVA: 0x7FFAC8D86120
        public void NotAMemberOfType(){} // RVA: 0x7FFAC8D86270 | overloaded x2
        public void NotAMemberOfAnyType(){} // RVA: 0x7FFAC8D862B0
        public void ParameterExpressionNotValidAsDelegate(){} // RVA: 0x7FFAC8D86350
        public void PropertyNotDefinedForType(){} // RVA: 0x7FFAC8D863F0
        public void InstancePropertyNotDefinedForType(){} // RVA: 0x7FFAC8D864A0
        public void InstancePropertyWithoutParameterNotDefinedForType(){} // RVA: 0x7FFAC8D86550
        public void InstancePropertyWithSpecifiedParametersNotDefinedForType(){} // RVA: 0x7FFAC8D865F0
        public void InstanceAndMethodTypeMismatch(){} // RVA: 0x7FFAC8D866B0
        public void TypeMissingDefaultConstructor(){} // RVA: 0x7FFAC8D86770
        public void ElementInitializerMethodNotAdd(){} // RVA: 0x7FFAC8D86810
        public void ElementInitializerMethodNoRefOutParam(){} // RVA: 0x7FFAC8D868A0
        public void ElementInitializerMethodWithZeroArgs(){} // RVA: 0x7FFAC8D86950
        public void ElementInitializerMethodStatic(){} // RVA: 0x7FFAC8D869E0
        public void TypeNotIEnumerable(){} // RVA: 0x7FFAC8D86A70
        public void UnhandledBinary(){} // RVA: 0x7FFAC8D86B10
        public void UnhandledBinding(){} // RVA: 0x7FFAC8D86BB0
        public void UnhandledBindingType(){} // RVA: 0x7FFAC8D86C40
        public void UnhandledUnary(){} // RVA: 0x7FFAC8D86CE0
        public void UnknownBindingType(){} // RVA: 0x7FFAC8D86D80
        public void UserDefinedOpMustHaveConsistentTypes(){} // RVA: 0x7FFAC8D86EA0
        public void UserDefinedOpMustHaveValidReturnType(){} // RVA: 0x7FFAC8D86F40
        public void LogicalOperatorMustHaveBooleanOperators(){} // RVA: 0x7FFAC8D86FE0
        public void MethodWithArgsDoesNotExistOnType(){} // RVA: 0x7FFAC8D87080
        public void GenericMethodWithArgsDoesNotExistOnType(){} // RVA: 0x7FFAC8D87120
        public void MethodWithMoreThanOneMatch(){} // RVA: 0x7FFAC8D871C0
        public void PropertyWithMoreThanOneMatch(){} // RVA: 0x7FFAC8D87260
        public void IncorrectNumberOfTypeArgsForFunc(){} // RVA: 0x7FFAC8D87300
        public void IncorrectNumberOfTypeArgsForAction(){} // RVA: 0x7FFAC8D87390
        public void ArgumentCannotBeOfTypeVoid(){} // RVA: 0x7FFAC8D87420
        public void OutOfRange(){} // RVA: 0x7FFAC8D874B0
        public void LabelTargetAlreadyDefined(){} // RVA: 0x7FFAC8D87560
        public void LabelTargetUndefined(){} // RVA: 0x7FFAC8D87600
        public void ControlCannotLeaveFinally(){} // RVA: 0x7FFAC8D876A0
        public void ControlCannotLeaveFilterTest(){} // RVA: 0x7FFAC8D87730
        public void AmbiguousJump(){} // RVA: 0x7FFAC8D877C0
        public void ControlCannotEnterTry(){} // RVA: 0x7FFAC8D87860
        public void ControlCannotEnterExpression(){} // RVA: 0x7FFAC8D878F0
        public void NonLocalJumpWithValue(){} // RVA: 0x7FFAC8D87980
        public void InvalidLvalue(){} // RVA: 0x7FFAC8D87A20
        public void UndefinedVariable(){} // RVA: 0x7FFAC8D87AE0
        public void CannotCloseOverByRef(){} // RVA: 0x7FFAC8D87BA0
        public void UnexpectedVarArgsCall(){} // RVA: 0x7FFAC8D87C40
        public void RethrowRequiresCatch(){} // RVA: 0x7FFAC8D87CE0
        public void TryNotAllowedInFilter(){} // RVA: 0x7FFAC8D87D70
        public void MustRewriteToSameNode(){} // RVA: 0x7FFAC8D87E00
        public void MustRewriteChildToSameType(){} // RVA: 0x7FFAC8D87EC0
        public void MustRewriteWithoutMethod(){} // RVA: 0x7FFAC8D87F80
        public void TryNotSupportedForMethodsWithRefArgs(){} // RVA: 0x7FFAC8D88020
        public void TryNotSupportedForValueTypeInstances(){} // RVA: 0x7FFAC8D880C0
        public void TestValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7FFAC8D88160
        public void SwitchValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7FFAC8D88200
        public void ArgumentOutOfRange(){} // RVA: 0x7FFAC8D882A0
        public void NotSupported(){} // RVA: 0x7FFAC8D88330
        public void NonStaticConstructorRequired(){} // RVA: 0x7FFAC8D883B0
        public void NonAbstractConstructorRequired(){} // RVA: 0x7FFAC8D88440
        public void InvalidProgram(){} // RVA: 0x7FFAC8D884D0
        public void EnumerationIsDone(){} // RVA: 0x7FFAC8D88550
        public void TypeContainsGenericParameters(){} // RVA: 0x7FFAC8D88680 | overloaded x2
        public void TypeIsGeneric(){} // RVA: 0x7FFAC8D887E0 | overloaded x2
        public void IncorrectNumberOfConstructorArguments(){} // RVA: 0x7FFAC8D888A0
        public void ExpressionTypeDoesNotMatchMethodParameter(){} // RVA: 0x7FFAC8D889F0 | overloaded x2
        public void ExpressionTypeDoesNotMatchParameter(){} // RVA: 0x7FFAC8D88B70 | overloaded x2
        public void IncorrectNumberOfLambdaArguments(){} // RVA: 0x7FFAC8D88C30
        public void IncorrectNumberOfMethodCallArguments(){} // RVA: 0x7FFAC8D88CC0
        public void ExpressionTypeDoesNotMatchConstructorParameter(){} // RVA: 0x7FFAC8D88E10 | overloaded x2
        public void ExpressionMustBeReadable(){} // RVA: 0x7FFAC8D88F60 | overloaded x2
        public void InvalidArgumentValue(){} // RVA: 0x7FFAC8D89000
        public void NonEmptyCollectionRequired(){} // RVA: 0x7FFAC8D89090
        public void InvalidNullValue(){} // RVA: 0x7FFAC8D89120
        public void InvalidTypeException(){} // RVA: 0x7FFAC8D891C0
        public void GetParamName(){} // RVA: 0x7FFAC8D892A0
    }

    public class Expression : Object
    {
        public System.Dynamic.Utils.CacheDict`2<System.Type,System.Reflection.MethodInfo> NodeType;
        public System.Dynamic.Utils.CacheDict`2<System.Type,System.Func`5<System.Linq.Expressions.Expression,string,bool,System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>,System.Linq.Expressions.LambdaExpression>> Type; // 0x8
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Linq.Expressions.Expression,ExtensionInfo> CanReduce; // 0x10

        // ── Methods ──
        public void Assign(){} // RVA: 0x7FFAC8D47C10
        public void GetUserDefinedBinaryOperator(){} // RVA: 0x7FFAC8D49130 | overloaded x2
        public void GetMethodBasedBinaryOperator(){} // RVA: 0x7FFAC8D48280
        public void GetMethodBasedAssignOperator(){} // RVA: 0x7FFAC8D48920
        public void GetUserDefinedBinaryOperatorOrThrow(){} // RVA: 0x7FFAC8D48BF0
        public void GetUserDefinedAssignOperatorOrThrow(){} // RVA: 0x7FFAC8D48E60
        public void IsLiftingConditionalLogicalOperator(){} // RVA: 0x7FFAC8D49510
        public void ParameterIsAssignable(){} // RVA: 0x7FFAC8D495D0
        public void ValidateParamswithOperandsOrThrow(){} // RVA: 0x7FFAC8D49690
        public void ValidateOperator(){} // RVA: 0x7FFAC8D49780
        public void ValidateMethodInfo(){} // RVA: 0x7FFAC8D49960
        public void IsNullComparison(){} // RVA: 0x7FFAC8D499F0
        public void IsNullConstant(){} // RVA: 0x7FFAC8D49C70
        public void ValidateUserDefinedConditionalLogicOperator(){} // RVA: 0x7FFAC8D49D00
        public void VerifyOpTrueFalse(){} // RVA: 0x7FFAC8D4A4B0
        public void IsValidLiftedConditionalLogicalOperator(){} // RVA: 0x7FFAC8D4A6A0
        public void MakeBinary(){} // RVA: 0x7FFAC8D4A970 | overloaded x3
        public void Equal(){} // RVA: 0x7FFAC8D4B340 | overloaded x2
        public void ReferenceEqual(){} // RVA: 0x7FFAC8D4B470
        public void NotEqual(){} // RVA: 0x7FFAC8D4B690 | overloaded x2
        public void ReferenceNotEqual(){} // RVA: 0x7FFAC8D4B7C0
        public void GetEqualityComparisonOperator(){} // RVA: 0x7FFAC8D4B970
        public void GreaterThan(){} // RVA: 0x7FFAC8D4BE70 | overloaded x2
        public void LessThan(){} // RVA: 0x7FFAC8D4C010 | overloaded x2
        public void GreaterThanOrEqual(){} // RVA: 0x7FFAC8D4C1B0 | overloaded x2
        public void LessThanOrEqual(){} // RVA: 0x7FFAC8D4C350 | overloaded x2
        public void GetComparisonOperator(){} // RVA: 0x7FFAC8D4C480
        public void AndAlso(){} // RVA: 0x7FFAC8D4C750 | overloaded x2
        public void OrElse(){} // RVA: 0x7FFAC8D4CEE0 | overloaded x2
        public void Coalesce(){} // RVA: 0x7FFAC8D4D630 | overloaded x2
        public void ValidateCoalesceArgTypes(){} // RVA: 0x7FFAC8D4DBD0
        public void Add(){} // RVA: 0x7FFAC8D4DE80 | overloaded x2
        public void AddAssign(){} // RVA: 0x7FFAC8D4E1D0 | overloaded x3
        public void ValidateOpAssignConversionLambda(){} // RVA: 0x7FFAC8D4E4A0
        public void AddAssignChecked(){} // RVA: 0x7FFAC8D4E940 | overloaded x3
        public void AddChecked(){} // RVA: 0x7FFAC8D4EC80 | overloaded x2
        public void Subtract(){} // RVA: 0x7FFAC8D4EF60 | overloaded x2
        public void SubtractAssign(){} // RVA: 0x7FFAC8D4F2C0 | overloaded x3
        public void SubtractAssignChecked(){} // RVA: 0x7FFAC8D4F6C0 | overloaded x3
        public void SubtractChecked(){} // RVA: 0x7FFAC8D4FA00 | overloaded x2
        public void Divide(){} // RVA: 0x7FFAC8D4FCE0 | overloaded x2
        public void DivideAssign(){} // RVA: 0x7FFAC8D50040 | overloaded x3
        public void Modulo(){} // RVA: 0x7FFAC8D50380 | overloaded x2
        public void ModuloAssign(){} // RVA: 0x7FFAC8D506E0 | overloaded x3
        public void Multiply(){} // RVA: 0x7FFAC8D50A20 | overloaded x2
        public void MultiplyAssign(){} // RVA: 0x7FFAC8D50D80 | overloaded x3
        public void MultiplyAssignChecked(){} // RVA: 0x7FFAC8D51180 | overloaded x3
        public void MultiplyChecked(){} // RVA: 0x7FFAC8D514C0 | overloaded x2
        public void IsSimpleShift(){} // RVA: 0x7FFAC8D51730
        public void GetResultTypeOfShift(){} // RVA: 0x7FFAC8D51810
        public void LeftShift(){} // RVA: 0x7FFAC8D51A00 | overloaded x2
        public void LeftShiftAssign(){} // RVA: 0x7FFAC8D51D50 | overloaded x3
        public void RightShift(){} // RVA: 0x7FFAC8D52070 | overloaded x2
        public void RightShiftAssign(){} // RVA: 0x7FFAC8D523C0 | overloaded x3
        public void And(){} // RVA: 0x7FFAC8D526E0 | overloaded x2
        public void AndAssign(){} // RVA: 0x7FFAC8D52A40 | overloaded x3
        public void Or(){} // RVA: 0x7FFAC8D52D80 | overloaded x2
        public void OrAssign(){} // RVA: 0x7FFAC8D530E0 | overloaded x3
        public void ExclusiveOr(){} // RVA: 0x7FFAC8D53420 | overloaded x2
        public void ExclusiveOrAssign(){} // RVA: 0x7FFAC8D53780 | overloaded x3
        public void Power(){} // RVA: 0x7FFAC8D53AC0 | overloaded x2
        public void PowerAssign(){} // RVA: 0x7FFAC8D53FD0 | overloaded x3
        public void ArrayIndex(){} // RVA: 0x7FFAC8D674E0 | overloaded x3
        public void Block(){} // RVA: 0x7FFAC8D54E40 | overloaded x12
        public void BlockCore(){} // RVA: 0x7FFAC8D55160
        public void ValidateVariables(){} // RVA: 0x7FFAC8D555D0
        public void GetOptimizedBlockExpression(){} // RVA: 0x7FFAC8D55870
        public void Catch(){} // RVA: 0x7FFAC8D55F40 | overloaded x4
        public void MakeCatchBlock(){} // RVA: 0x7FFAC8D56040
        public void Condition(){} // RVA: 0x7FFAC8D567A0 | overloaded x2
        public void IfThen(){} // RVA: 0x7FFAC8D56AE0
        public void IfThenElse(){} // RVA: 0x7FFAC8D56C00
        public void Constant(){} // RVA: 0x7FFAC8D56D80 | overloaded x2
        public void DebugInfo(){} // RVA: 0x7FFAC8D57000
        public void ClearDebugInfo(){} // RVA: 0x7FFAC8D57180
        public void ValidateSpan(){} // RVA: 0x7FFAC8D57240
        public void Empty(){} // RVA: 0x7FFAC8D57430
        public void Default(){} // RVA: 0x7FFAC8D57520
        public void ElementInit(){} // RVA: 0x7FFAC8D57680 | overloaded x2
        public void ValidateElementInitAddMethodInfo(){} // RVA: 0x7FFAC8D578E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFAC8D57E60
        public void get_Type(){} // RVA: 0x7FFAC8D57F60
        public void get_CanReduce(){} // RVA: 0x7FFAC2F21320
        public void Reduce(){} // RVA: 0x7FFAC8D58060
        public void VisitChildren(){} // RVA: 0x7FFAC8D580B0
        public void Accept(){} // RVA: 0x7FFAC8D58140
        public void ReduceAndCheck(){} // RVA: 0x7FFAC8D58170
        public void ReduceExtensions(){} // RVA: 0x7FFAC8D582D0
        public void ToString(){} // RVA: 0x7FFAC8D58330
        public void get_DebugView(){} // RVA: 0x7FFAC8D583C0
        public void RequiresCanRead(){} // RVA: 0x7FFAC8D58550
        public void RequiresCanWrite(){} // RVA: 0x7FFAC8D58680
        public void Dynamic(){} // RVA: 0x7FFAC8D58910 | overloaded x6
        public void MakeDynamic(){} // RVA: 0x7FFAC8D589B0 | overloaded x6
        public void Break(){} // RVA: 0x7FFAC8D58CA0 | overloaded x4
        public void Continue(){} // RVA: 0x7FFAC8D58E20 | overloaded x2
        public void Return(){} // RVA: 0x7FFAC8D59110 | overloaded x4
        public void Goto(){} // RVA: 0x7FFAC8D59410 | overloaded x4
        public void MakeGoto(){} // RVA: 0x7FFAC8D59490
        public void ValidateGoto(){} // RVA: 0x7FFAC8D596A0
        public void ValidateGotoType(){} // RVA: 0x7FFAC8D59860
        public void MakeIndex(){} // RVA: 0x7FFAC8D59A20
        public void ArrayAccess(){} // RVA: 0x7FFAC8D59B20 | overloaded x2
        public void Property(){} // RVA: 0x7FFAC8D61E30 | overloaded x7
        public void FindInstanceProperty(){} // RVA: 0x7FFAC8D5A1E0
        public void GetArgTypesString(){} // RVA: 0x7FFAC8D5A330
        public void FindProperty(){} // RVA: 0x7FFAC8D5A4F0
        public void IsCompatible(){} // RVA: 0x7FFAC8D67110 | overloaded x2
        public void MakeIndexProperty(){} // RVA: 0x7FFAC8D5AA30
        public void ValidateIndexedProperty(){} // RVA: 0x7FFAC8D5AB00
        public void ValidateAccessor(){} // RVA: 0x7FFAC8D5B190
        public void ValidateAccessorArgumentTypes(){} // RVA: 0x7FFAC8D5B460
        public void Invoke(){} // RVA: 0x7FFAC8D5CCA0 | overloaded x8
        public void GetInvokeMethod(){} // RVA: 0x7FFAC8D5D150
        public void Label(){} // RVA: 0x7FFAC8D5D7F0 | overloaded x6
        public void CreateLambda(){} // RVA: 0x7FFAC8D5D990
        public void Lambda(){} // RVA: 0x7FFAC8D5EA40 | overloaded x18
        public void ValidateLambdaArgs(){} // RVA: 0x7FFAC8D5EB30
        public void ValidateTryGetFuncActionArgs(){} // RVA: 0x7FFAC8D5F410
        public void GetFuncType(){} // RVA: 0x7FFAC8D5F540
        public void TryGetFuncType(){} // RVA: 0x7FFAC8D5F6B0
        public void GetActionType(){} // RVA: 0x7FFAC8D5F820
        public void TryGetActionType(){} // RVA: 0x7FFAC8D5F990
        public void GetDelegateType(){} // RVA: 0x7FFAC8D5FB00
        public void ListInit(){} // RVA: 0x7FFAC8D605E0 | overloaded x6
        public void Loop(){} // RVA: 0x7FFAC8D60880 | overloaded x3
        public void Bind(){} // RVA: 0x7FFAC8D60D20 | overloaded x2
        public void ValidateSettableFieldOrPropertyMember(){} // RVA: 0x7FFAC8D60ED0
        public void Field(){} // RVA: 0x7FFAC8D61510 | overloaded x3
        public void GetProperty(){} // RVA: 0x7FFAC8D61F80
        public void CheckMethod(){} // RVA: 0x7FFAC8D621E0
        public void PropertyOrField(){} // RVA: 0x7FFAC8D623C0
        public void MakeMemberAccess(){} // RVA: 0x7FFAC8D62690
        public void MemberInit(){} // RVA: 0x7FFAC8D628A0 | overloaded x2
        public void ListBind(){} // RVA: 0x7FFAC8D62F30 | overloaded x4
        public void ValidateListInitArgs(){} // RVA: 0x7FFAC8D63080
        public void MemberBind(){} // RVA: 0x7FFAC8D636E0 | overloaded x4
        public void ValidateGettableFieldOrPropertyMember(){} // RVA: 0x7FFAC8D637C0
        public void ValidateMemberInitArgs(){} // RVA: 0x7FFAC8D63A20
        public void Call(){} // RVA: 0x7FFAC8D66300 | overloaded x16
        public void ValidateMethodAndGetParameters(){} // RVA: 0x7FFAC8D66910
        public void ValidateStaticOrInstanceMethod(){} // RVA: 0x7FFAC8D66B50
        public void ValidateCallInstanceType(){} // RVA: 0x7FFAC8D66C70
        public void ValidateArgumentTypes(){} // RVA: 0x7FFAC8D66D20
        public void GetParametersForValidation(){} // RVA: 0x7FFAC8D66D30
        public void ValidateArgumentCount(){} // RVA: 0x7FFAC8D66D40
        public void ValidateOneArgument(){} // RVA: 0x7FFAC8D66D50
        public void TryQuote(){} // RVA: 0x7FFAC8D66D90
        public void FindMethod(){} // RVA: 0x7FFAC8D66DA0
        public void ApplyTypeArgs(){} // RVA: 0x7FFAC8D673B0
        public void NewArrayInit(){} // RVA: 0x7FFAC8D679E0 | overloaded x2
        public void NewArrayBounds(){} // RVA: 0x7FFAC8D68000 | overloaded x2
        public void New(){} // RVA: 0x7FFAC8D68AE0 | overloaded x6
        public void ValidateNewArgs(){} // RVA: 0x7FFAC8D68F50
        public void ValidateAnonymousTypeMember(){} // RVA: 0x7FFAC8D69A50
        public void ValidateConstructor(){} // RVA: 0x7FFAC8D69E00
        public void Parameter(){} // RVA: 0x7FFAC8D69F20 | overloaded x2
        public void Variable(){} // RVA: 0x7FFAC8D69FE0 | overloaded x2
        public void Validate(){} // RVA: 0x7FFAC8D6A050
        public void RuntimeVariables(){} // RVA: 0x7FFAC8D6A240 | overloaded x2
        public void SwitchCase(){} // RVA: 0x7FFAC8D6A530 | overloaded x2
        public void Switch(){} // RVA: 0x7FFAC8D6AA30 | overloaded x6
        public void ValidateSwitchCaseType(){} // RVA: 0x7FFAC8D6B7C0
        public void SymbolDocument(){} // RVA: 0x7FFAC8D6BB90 | overloaded x4
        public void TryFault(){} // RVA: 0x7FFAC8D6BC60
        public void TryFinally(){} // RVA: 0x7FFAC8D6BCD0
        public void TryCatch(){} // RVA: 0x7FFAC8D6BD40
        public void TryCatchFinally(){} // RVA: 0x7FFAC8D6BDB0
        public void MakeTry(){} // RVA: 0x7FFAC8D6BE30
        public void ValidateTryAndCatchHaveSameType(){} // RVA: 0x7FFAC8D6C0B0
        public void TypeIs(){} // RVA: 0x7FFAC8D6C720
        public void TypeEqual(){} // RVA: 0x7FFAC8D6C880
        public void MakeUnary(){} // RVA: 0x7FFAC8D6CA60 | overloaded x2
        public void GetUserDefinedUnaryOperatorOrThrow(){} // RVA: 0x7FFAC8D6D150
        public void GetUserDefinedUnaryOperator(){} // RVA: 0x7FFAC8D6D2F0
        public void GetMethodBasedUnaryOperator(){} // RVA: 0x7FFAC8D6D690
        public void GetUserDefinedCoercionOrThrow(){} // RVA: 0x7FFAC8D6DAE0
        public void GetUserDefinedCoercion(){} // RVA: 0x7FFAC8D6DC50
        public void GetMethodBasedCoercionOperator(){} // RVA: 0x7FFAC8D6DD50
        public void Negate(){} // RVA: 0x7FFAC8D6E260 | overloaded x2
        public void UnaryPlus(){} // RVA: 0x7FFAC8D6E4B0 | overloaded x2
        public void NegateChecked(){} // RVA: 0x7FFAC8D6E6C0 | overloaded x2
        public void Not(){} // RVA: 0x7FFAC8D6E910 | overloaded x2
        public void IsFalse(){} // RVA: 0x7FFAC8D6EB60 | overloaded x2
        public void IsTrue(){} // RVA: 0x7FFAC8D6ED70 | overloaded x2
        public void OnesComplement(){} // RVA: 0x7FFAC8D6EF80 | overloaded x2
        public void TypeAs(){} // RVA: 0x7FFAC8D6F130
        public void Unbox(){} // RVA: 0x7FFAC8D6F2F0
        public void Convert(){} // RVA: 0x7FFAC8D6F5D0 | overloaded x2
        public void ConvertChecked(){} // RVA: 0x7FFAC8D6F890 | overloaded x2
        public void ArrayLength(){} // RVA: 0x7FFAC8D6FB10
        public void Quote(){} // RVA: 0x7FFAC8D6FD60
        public void Rethrow(){} // RVA: 0x7FFAC8D700D0 | overloaded x2
        public void Throw(){} // RVA: 0x7FFAC8D70310 | overloaded x2
        public void Increment(){} // RVA: 0x7FFAC8D70530 | overloaded x2
        public void Decrement(){} // RVA: 0x7FFAC8D70740 | overloaded x2
        public void PreIncrementAssign(){} // RVA: 0x7FFAC8D70950 | overloaded x2
        public void PreDecrementAssign(){} // RVA: 0x7FFAC8D70A20 | overloaded x2
        public void PostIncrementAssign(){} // RVA: 0x7FFAC8D70AF0 | overloaded x2
        public void PostDecrementAssign(){} // RVA: 0x7FFAC8D70BC0 | overloaded x2
        public void MakeOpAssignUnary(){} // RVA: 0x7FFAC8D70C30
        public void .cctor(){} // RVA: 0x7FFAC8D70EF0
    }

    public class Expression0`1 : Expression`1
    {
        public object ParameterCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void get_ParameterCount(){} // RVA: 0x7FFAC2C59960
        public void SameParameters(){} // RVA: 0x7FFAC2C59F60
        public void GetParameter(){} // RVA: 0x7FFAC2C67DE0
        public void GetOrMakeParameters(){} // RVA: 0x7FFAC2C58E90
        public void Rewrite(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class Expression1`1 : Expression`1
    {
        public object ParameterCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void get_ParameterCount(){} // RVA: 0x7FFAC2C59960
        public void GetParameter(){} // RVA: 0x7FFAC2C67DE0
        public void SameParameters(){} // RVA: 0x7FFAC2C59F60
        public void GetOrMakeParameters(){} // RVA: 0x7FFAC2C58E90
        public void Rewrite(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class Expression2`1 : Expression`1
    {
        public object ParameterCount;
        public System.Linq.Expressions.ParameterExpression _par1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
        public void get_ParameterCount(){} // RVA: 0x7FFAC2C59960
        public void GetParameter(){} // RVA: 0x7FFAC2C67DE0
        public void SameParameters(){} // RVA: 0x7FFAC2C59F60
        public void GetOrMakeParameters(){} // RVA: 0x7FFAC2C58E90
        public void Rewrite(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class Expression3`1 : Expression`1
    {
        public object ParameterCount;
        public System.Linq.Expressions.ParameterExpression _par1;
        public System.Linq.Expressions.ParameterExpression _par2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7B8C0
        public void get_ParameterCount(){} // RVA: 0x7FFAC2C59960
        public void GetParameter(){} // RVA: 0x7FFAC2C67DE0
        public void SameParameters(){} // RVA: 0x7FFAC2C59F60
        public void GetOrMakeParameters(){} // RVA: 0x7FFAC2C58E90
        public void Rewrite(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class ExpressionCreator`1 : Object
    {
        // ── Methods ──
        public void CreateExpressionFunc(){} // RVA: 0x7FFAC2C6A960
    }

    public class ExpressionExtension : Object
    {
        // ── Methods ──
        public void MakeDynamic(){} // RVA: 0x7FFAC8D81680 | overloaded x7
        public void GetValidMethodForDynamic(){} // RVA: 0x7FFAC8D80550
        public void Dynamic(){} // RVA: 0x7FFAC8D81490 | overloaded x6
        public void ValidateDynamicArgument(){} // RVA: 0x7FFAC8D81C00 | overloaded x2
    }

    public class ExpressionN`1 : Expression`1
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.ParameterExpression> ParameterCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void get_ParameterCount(){} // RVA: 0x7FFAC2C59960
        public void GetParameter(){} // RVA: 0x7FFAC2C67DE0
        public void SameParameters(){} // RVA: 0x7FFAC2C59F60
        public void GetOrMakeParameters(){} // RVA: 0x7FFAC2C58E90
        public void Rewrite(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class ExpressionStringBuilder : ExpressionVisitor
    {
        public System.Text.StringBuilder _out; // 0x10
        public System.Collections.Generic.Dictionary`2<object,int> _ids; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D89360
        public void ToString(){} // RVA: 0x7FFAC3CE8330
        public void GetLabelId(){} // RVA: 0x7FFAC8D89400
        public void GetParamId(){} // RVA: 0x7FFAC8D89400
        public void GetId(){} // RVA: 0x7FFAC8D89410
        public void Out(){} // RVA: 0x7FFAC8D895E0 | overloaded x2
        public void ExpressionToString(){} // RVA: 0x7FFAC8D58330
        public void CatchBlockToString(){} // RVA: 0x7FFAC8D76130
        public void SwitchCaseToString(){} // RVA: 0x7FFAC8D89600
        public void MemberBindingToString(){} // RVA: 0x7FFAC8D89690
        public void ElementInitBindingToString(){} // RVA: 0x7FFAC8D81F60
        public void VisitExpressions(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void VisitBinary(){} // RVA: 0x7FFAC8D89720
        public void VisitParameter(){} // RVA: 0x7FFAC8D89FC0
        public void VisitLambda(){} // RVA: 0x7FFAC2C58F40
        public void VisitListInit(){} // RVA: 0x7FFAC8D8A130
        public void VisitConditional(){} // RVA: 0x7FFAC8D8A300
        public void VisitConstant(){} // RVA: 0x7FFAC8D8A480
        public void VisitDebugInfo(){} // RVA: 0x7FFAC8D8A760
        public void VisitRuntimeVariables(){} // RVA: 0x7FFAC8D8AAE0
        public void OutMember(){} // RVA: 0x7FFAC8D8AB50
        public void VisitMember(){} // RVA: 0x7FFAC8D8AC70
        public void VisitMemberInit(){} // RVA: 0x7FFAC8D8ADE0
        public void VisitMemberAssignment(){} // RVA: 0x7FFAC8D8B100
        public void VisitMemberListBinding(){} // RVA: 0x7FFAC8D8B1B0
        public void VisitMemberMemberBinding(){} // RVA: 0x7FFAC8D8B3A0
        public void VisitElementInit(){} // RVA: 0x7FFAC8D8B590
        public void VisitInvocation(){} // RVA: 0x7FFAC8D8B7C0
        public void VisitMethodCall(){} // RVA: 0x7FFAC8D8B950
        public void VisitNewArray(){} // RVA: 0x7FFAC8D8BC90
        public void VisitNew(){} // RVA: 0x7FFAC8D8BDE0
        public void VisitTypeBinary(){} // RVA: 0x7FFAC8D8C0A0
        public void VisitUnary(){} // RVA: 0x7FFAC8D8C270
        public void VisitBlock(){} // RVA: 0x7FFAC8D8C9D0
        public void VisitDefault(){} // RVA: 0x7FFAC8D8CD50
        public void VisitLabel(){} // RVA: 0x7FFAC8D8CE70
        public void VisitGoto(){} // RVA: 0x7FFAC8D8CF50
        public void VisitLoop(){} // RVA: 0x7FFAC8D8D150
        public void VisitSwitchCase(){} // RVA: 0x7FFAC8D8D1B0
        public void VisitSwitch(){} // RVA: 0x7FFAC8D8D270
        public void VisitCatchBlock(){} // RVA: 0x7FFAC8D8D380
        public void VisitTry(){} // RVA: 0x7FFAC8D8D4F0
        public void VisitIndex(){} // RVA: 0x7FFAC8D8D550
        public void VisitExtension(){} // RVA: 0x7FFAC8D8D820
        public void DumpLabel(){} // RVA: 0x7FFAC8D8DB70
        public void IsBool(){} // RVA: 0x7FFAC8D8DCA0
    }

    public class ExpressionVisitor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Visit(){} // RVA: 0x7FFAC2C58FF0 | overloaded x3
        public void VisitArguments(){} // RVA: 0x7FFAC8D8E180
        public void VisitParameters(){} // RVA: 0x7FFAC8D8E190
        public void VisitAndConvert(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void VisitBinary(){} // RVA: 0x7FFAC8D8E1A0
        public void VisitBlock(){} // RVA: 0x7FFAC8D8E2B0
        public void VisitConditional(){} // RVA: 0x7FFAC8D8E3B0
        public void VisitConstant(){} // RVA: 0x7FFAC3E92FB0
        public void VisitDebugInfo(){} // RVA: 0x7FFAC3E92FB0
        public void VisitDefault(){} // RVA: 0x7FFAC3E92FB0
        public void VisitExtension(){} // RVA: 0x7FFAC8D76D60
        public void VisitGoto(){} // RVA: 0x7FFAC8D8E500
        public void VisitInvocation(){} // RVA: 0x7FFAC8D8E600
        public void VisitLabelTarget(){} // RVA: 0x7FFAC3E92FB0
        public void VisitLabel(){} // RVA: 0x7FFAC8D8E6A0
        public void VisitLambda(){} // RVA: 0x7FFAC2C58F40
        public void VisitLoop(){} // RVA: 0x7FFAC8D8E770
        public void VisitMember(){} // RVA: 0x7FFAC8D8E870
        public void VisitIndex(){} // RVA: 0x7FFAC8D8E920
        public void VisitMethodCall(){} // RVA: 0x7FFAC8D8EA70
        public void VisitNewArray(){} // RVA: 0x7FFAC8D8EB40
        public void VisitNew(){} // RVA: 0x7FFAC8D8EB80
        public void VisitParameter(){} // RVA: 0x7FFAC3E92FB0
        public void VisitRuntimeVariables(){} // RVA: 0x7FFAC8D8ECB0
        public void VisitSwitchCase(){} // RVA: 0x7FFAC8D8EDB0
        public void VisitSwitch(){} // RVA: 0x7FFAC8D8EEB0
        public void VisitCatchBlock(){} // RVA: 0x7FFAC8D8F0E0
        public void VisitTry(){} // RVA: 0x7FFAC8D8F230
        public void VisitTypeBinary(){} // RVA: 0x7FFAC8D8F410
        public void VisitUnary(){} // RVA: 0x7FFAC8D8F4F0
        public void VisitMemberInit(){} // RVA: 0x7FFAC8D8F6D0
        public void VisitListInit(){} // RVA: 0x7FFAC8D8F870
        public void VisitElementInit(){} // RVA: 0x7FFAC8D8FA10
        public void VisitMemberBinding(){} // RVA: 0x7FFAC8D8FAA0
        public void VisitMemberAssignment(){} // RVA: 0x7FFAC8D8FC40
        public void VisitMemberMemberBinding(){} // RVA: 0x7FFAC8D8FCE0
        public void VisitMemberListBinding(){} // RVA: 0x7FFAC8D8FE30
        public void ValidateUnary(){} // RVA: 0x7FFAC8D8FF80
        public void ValidateBinary(){} // RVA: 0x7FFAC8D90090
        public void ValidateSwitch(){} // RVA: 0x7FFAC8D90230
        public void ValidateChildType(){} // RVA: 0x7FFAC8D902B0
        public void VisitDynamic(){} // RVA: 0x7FFAC8D81E00
    }

    public class Expression`1 : LambdaExpression
    {
        public object TypeCore;
        public object PublicType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980 | overloaded x2
        public void get_TypeCore(){} // RVA: 0x7FFAC2C58E90
        public void get_PublicType(){} // RVA: 0x7FFAC2C58E90
        public void Compile(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void Update(){} // RVA: 0x7FFAC2C6A6F0
        public void SameParameters(){} // RVA: 0x7FFAC2C59F60
        public void Rewrite(){} // RVA: 0x7FFAC2C6A6F0
        public void Accept(){} // RVA: 0x7FFAC2C58F40
    }

}