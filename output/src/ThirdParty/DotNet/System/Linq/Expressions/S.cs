// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 12
// Methods: 234

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class Scope1 : ScopeExpression
    {
        public object ExpressionCount; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D74DA0 | overloaded x2
        public void SameExpressions(){} // RVA: 0x7FFAC8D74E10
        public void GetExpression(){} // RVA: 0x7FFAC8D75070
        public void get_ExpressionCount(){} // RVA: 0x7FFAC3013AF0
        public void GetOrMakeExpressions(){} // RVA: 0x7FFAC8D750F0
        public void Rewrite(){} // RVA: 0x7FFAC8D75100
    }

    public class ScopeExpression : BlockExpression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.ParameterExpression> VariablesList; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D74910
        public void SameVariables(){} // RVA: 0x7FFAC8D74BE0
        public void GetOrMakeVariables(){} // RVA: 0x7FFAC8D74CC0
        public void get_VariablesList(){} // RVA: 0x7FFAC2F3C380
        public void ReuseOrValidateVariables(){} // RVA: 0x7FFAC8D74D00
    }

    public class ScopeN : ScopeExpression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> Body; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D74DA0
        public void SameExpressions(){} // RVA: 0x7FFAC8D75280
        public void get_Body(){} // RVA: 0x7FFAC2F247C0
        public void GetExpression(){} // RVA: 0x7FFAC8D75360
        public void get_ExpressionCount(){} // RVA: 0x7FFAC8D753C0
        public void GetOrMakeExpressions(){} // RVA: 0x7FFAC8D75410
        public void Rewrite(){} // RVA: 0x7FFAC8D75450
    }

    public class ScopeWithType : ScopeN
    {
        public System.Type Type; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D755B0
        public void get_Type(){} // RVA: 0x7FFAC2F4F0C0
        public void Rewrite(){} // RVA: 0x7FFAC8D75690
    }

    public class SimpleBinaryExpression : BinaryExpression
    {
        public 0x6B1EC490 NodeType; // 0x20
        public System.Type Type; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D47B10
        public void get_NodeType(){} // RVA: 0x7FFAC30DBBE0
        public void get_Type(){} // RVA: 0x7FFAC2F4F130
    }

    public class SpanDebugInfoExpression : DebugInfoExpression
    {
        public int StartLine; // 0x18
        public int StartColumn; // 0x1C
        public int EndLine; // 0x20
        public int EndColumn; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D770D0
        public void get_StartLine(){} // RVA: 0x7FFAC3157800
        public void get_StartColumn(){} // RVA: 0x7FFAC44357F0
        public void get_EndLine(){} // RVA: 0x7FFAC30DBBE0
        public void get_EndColumn(){} // RVA: 0x7FFAC3921980
        public void get_IsClear(){} // RVA: 0x7FFAC2F21320
        public void Accept(){} // RVA: 0x7FFAC8D77070
    }

    public class StackGuard : Object
    {
        public int MaxExecutionStackCount;
        public int _executionStackCount; // 0x10

        // ── Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0x7FFAC3006850
        public void RunOnEmptyStack(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void RunOnEmptyStackCore(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Strings : Object
    {
        public object ReducibleMustOverrideReduce;
        public object MustReduceToDifferent;
        public object ReducedNotCompatible;
        public object SetterHasNoParams;
        public object PropertyCannotHaveRefType;
        public object IndexesOfSetGetMustMatch;
        public object AccessorsCannotHaveVarArgs;
        public object AccessorsCannotHaveByRefArgs;
        public object BoundsCannotBeLessThanOne;
        public object TypeMustNotBeByRef;
        public object TypeMustNotBePointer;
        public object SetterMustBeVoid;
        public object PropertyTypeMustMatchGetter;
        public object PropertyTypeMustMatchSetter;
        public object BothAccessorsMustBeStatic;
        public object OnlyStaticFieldsHaveNullInstance;
        public object OnlyStaticPropertiesHaveNullInstance;
        public object OnlyStaticMethodsHaveNullInstance;
        public object PropertyTypeCannotBeVoid;
        public object InvalidUnboxType;
        public object ExpressionMustBeWriteable;
        public object ArgumentMustNotHaveValueType;
        public object MustBeReducible;
        public object AllTestValuesMustHaveSameType;
        public object AllCaseBodiesMustHaveSameType;
        public object DefaultBodyMustBeSupplied;
        public object LabelMustBeVoidOrHaveExpression;
        public object LabelTypeMustBeVoid;
        public object QuotedExpressionMustBeLambda;
        public object CollectionModifiedWhileEnumerating;
        public object CollectionReadOnly;
        public object ArgCntMustBeGreaterThanNameCnt;
        public object BindingCannotBeNull;
        public object ArgumentTypeCannotBeVoid;
        public object NoOrInvalidRuleProduced;
        public object TypeMustBeDerivedFromSystemDelegate;
        public object FirstArgumentMustBeCallSite;
        public object StartEndMustBeOrdered;
        public object FaultCannotHaveCatchOrFinally;
        public object TryMustHaveCatchFinallyOrFault;
        public object BodyOfCatchMustHaveSameTypeAsBodyOfTry;
        public object ConversionIsNotSupportedForArithmeticTypes;
        public object ArgumentMustBeArray;
        public object ArgumentMustBeBoolean;
        public object ArgumentMustBeFieldInfoOrPropertyInfo;
        public object ArgumentMustBeFieldInfoOrPropertyInfoOrMethod;
        public object ArgumentMustBeInstanceMember;
        public object ArgumentMustBeInteger;
        public object ArgumentMustBeArrayIndexType;
        public object ArgumentMustBeSingleDimensionalArrayType;
        public object ArgumentTypesMustMatch;
        public object CoalesceUsedOnNonNullType;
        public object IncorrectNumberOfIndexes;
        public object IncorrectNumberOfLambdaDeclarationParameters;
        public object IncorrectNumberOfMembersForGivenConstructor;
        public object IncorrectNumberOfArgumentsForMembers;
        public object LambdaTypeMustBeDerivedFromSystemDelegate;
        public object ElementInitializerMethodNotAdd;
        public object ElementInitializerMethodWithZeroArgs;
        public object ElementInitializerMethodStatic;
        public object UnhandledBinding;
        public object UnknownBindingType;
        public object IncorrectNumberOfTypeArgsForFunc;
        public object IncorrectNumberOfTypeArgsForAction;
        public object ArgumentCannotBeOfTypeVoid;
        public object ControlCannotLeaveFinally;
        public object ControlCannotLeaveFilterTest;
        public object ControlCannotEnterTry;
        public object ControlCannotEnterExpression;
        public object RethrowRequiresCatch;
        public object TryNotAllowedInFilter;
        public object NonStaticConstructorRequired;
        public object NonAbstractConstructorRequired;
        public object ExpressionMustBeReadable;
        public object EnumerationIsDone;
        public object InvalidArgumentValue;
        public object NonEmptyCollectionRequired;
        public object IncorrectNumberOfLambdaArguments;
        public object IncorrectNumberOfConstructorArguments;

        // ── Methods ──
        public void get_ReducibleMustOverrideReduce(){} // RVA: 0x7FFAC8D98A20
        public void get_MustReduceToDifferent(){} // RVA: 0x7FFAC8D98A60
        public void get_ReducedNotCompatible(){} // RVA: 0x7FFAC8D98AA0
        public void get_SetterHasNoParams(){} // RVA: 0x7FFAC8D98AE0
        public void get_PropertyCannotHaveRefType(){} // RVA: 0x7FFAC8D98B20
        public void get_IndexesOfSetGetMustMatch(){} // RVA: 0x7FFAC8D98B60
        public void get_AccessorsCannotHaveVarArgs(){} // RVA: 0x7FFAC8D98BA0
        public void get_AccessorsCannotHaveByRefArgs(){} // RVA: 0x7FFAC8D98BE0
        public void get_BoundsCannotBeLessThanOne(){} // RVA: 0x7FFAC8D98C20
        public void get_TypeMustNotBeByRef(){} // RVA: 0x7FFAC8D98C60
        public void get_TypeMustNotBePointer(){} // RVA: 0x7FFAC8D98CA0
        public void get_SetterMustBeVoid(){} // RVA: 0x7FFAC8D98CE0
        public void get_PropertyTypeMustMatchGetter(){} // RVA: 0x7FFAC8D98D20
        public void get_PropertyTypeMustMatchSetter(){} // RVA: 0x7FFAC8D98D60
        public void get_BothAccessorsMustBeStatic(){} // RVA: 0x7FFAC8D98DA0
        public void get_OnlyStaticFieldsHaveNullInstance(){} // RVA: 0x7FFAC8D98DE0
        public void get_OnlyStaticPropertiesHaveNullInstance(){} // RVA: 0x7FFAC8D98E20
        public void get_OnlyStaticMethodsHaveNullInstance(){} // RVA: 0x7FFAC8D98E60
        public void get_PropertyTypeCannotBeVoid(){} // RVA: 0x7FFAC8D98EA0
        public void get_InvalidUnboxType(){} // RVA: 0x7FFAC8D98EE0
        public void get_ExpressionMustBeWriteable(){} // RVA: 0x7FFAC8D98F20
        public void get_ArgumentMustNotHaveValueType(){} // RVA: 0x7FFAC8D98F60
        public void get_MustBeReducible(){} // RVA: 0x7FFAC8D98FA0
        public void get_AllTestValuesMustHaveSameType(){} // RVA: 0x7FFAC8D98FE0
        public void get_AllCaseBodiesMustHaveSameType(){} // RVA: 0x7FFAC8D99020
        public void get_DefaultBodyMustBeSupplied(){} // RVA: 0x7FFAC8D99060
        public void get_LabelMustBeVoidOrHaveExpression(){} // RVA: 0x7FFAC8D990A0
        public void get_LabelTypeMustBeVoid(){} // RVA: 0x7FFAC8D990E0
        public void get_QuotedExpressionMustBeLambda(){} // RVA: 0x7FFAC8D99120
        public void get_CollectionModifiedWhileEnumerating(){} // RVA: 0x7FFAC8D99160
        public void VariableMustNotBeByRef(){} // RVA: 0x7FFAC8D991A0
        public void get_CollectionReadOnly(){} // RVA: 0x7FFAC8D991F0
        public void AmbiguousMatchInExpandoObject(){} // RVA: 0x7FFAC8D99230
        public void SameKeyExistsInExpando(){} // RVA: 0x7FFAC8D99280
        public void KeyDoesNotExistInExpando(){} // RVA: 0x7FFAC8D992D0
        public void get_ArgCntMustBeGreaterThanNameCnt(){} // RVA: 0x7FFAC8D99320
        public void InvalidMetaObjectCreated(){} // RVA: 0x7FFAC8D99360
        public void BinderNotCompatibleWithCallSite(){} // RVA: 0x7FFAC8D993B0
        public void DynamicBindingNeedsRestrictions(){} // RVA: 0x7FFAC8D99420
        public void DynamicObjectResultNotAssignable(){} // RVA: 0x7FFAC8D99470
        public void DynamicBinderResultNotAssignable(){} // RVA: 0x7FFAC8D99690
        public void get_BindingCannotBeNull(){} // RVA: 0x7FFAC8D99700
        public void DuplicateVariable(){} // RVA: 0x7FFAC8D99740
        public void get_ArgumentTypeCannotBeVoid(){} // RVA: 0x7FFAC8D99790
        public void TypeParameterIsNotDelegate(){} // RVA: 0x7FFAC8D997D0
        public void get_NoOrInvalidRuleProduced(){} // RVA: 0x7FFAC8D99820
        public void get_TypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x7FFAC8D99860
        public void get_FirstArgumentMustBeCallSite(){} // RVA: 0x7FFAC8D998A0
        public void get_StartEndMustBeOrdered(){} // RVA: 0x7FFAC8D998E0
        public void get_FaultCannotHaveCatchOrFinally(){} // RVA: 0x7FFAC8D99920
        public void get_TryMustHaveCatchFinallyOrFault(){} // RVA: 0x7FFAC8D99960
        public void get_BodyOfCatchMustHaveSameTypeAsBodyOfTry(){} // RVA: 0x7FFAC8D999A0
        public void ExtensionNodeMustOverrideProperty(){} // RVA: 0x7FFAC8D999E0
        public void UserDefinedOperatorMustBeStatic(){} // RVA: 0x7FFAC8D99A30
        public void UserDefinedOperatorMustNotBeVoid(){} // RVA: 0x7FFAC8D99A80
        public void CoercionOperatorNotDefined(){} // RVA: 0x7FFAC8D99AD0
        public void UnaryOperatorNotDefined(){} // RVA: 0x7FFAC8D99B20
        public void BinaryOperatorNotDefined(){} // RVA: 0x7FFAC8D99B70
        public void ReferenceEqualityNotDefined(){} // RVA: 0x7FFAC8D99BE0
        public void OperandTypesDoNotMatchParameters(){} // RVA: 0x7FFAC8D99C30
        public void OverloadOperatorTypeDoesNotMatchConversionType(){} // RVA: 0x7FFAC8D99C80
        public void get_ConversionIsNotSupportedForArithmeticTypes(){} // RVA: 0x7FFAC8D99CD0
        public void get_ArgumentMustBeArray(){} // RVA: 0x7FFAC8D99D10
        public void get_ArgumentMustBeBoolean(){} // RVA: 0x7FFAC8D99D50
        public void EqualityMustReturnBoolean(){} // RVA: 0x7FFAC8D99D90
        public void get_ArgumentMustBeFieldInfoOrPropertyInfo(){} // RVA: 0x7FFAC8D99DE0
        public void get_ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(){} // RVA: 0x7FFAC8D99E20
        public void get_ArgumentMustBeInstanceMember(){} // RVA: 0x7FFAC8D99E60
        public void get_ArgumentMustBeInteger(){} // RVA: 0x7FFAC8D99EA0
        public void get_ArgumentMustBeArrayIndexType(){} // RVA: 0x7FFAC8D99EE0
        public void get_ArgumentMustBeSingleDimensionalArrayType(){} // RVA: 0x7FFAC8D99F20
        public void get_ArgumentTypesMustMatch(){} // RVA: 0x7FFAC8D99F60
        public void CannotAutoInitializeValueTypeElementThroughProperty(){} // RVA: 0x7FFAC8D99FA0
        public void CannotAutoInitializeValueTypeMemberThroughProperty(){} // RVA: 0x7FFAC8D99FF0
        public void IncorrectTypeForTypeAs(){} // RVA: 0x7FFAC8D9A040
        public void get_CoalesceUsedOnNonNullType(){} // RVA: 0x7FFAC8D9A090
        public void ExpressionTypeCannotInitializeArrayType(){} // RVA: 0x7FFAC8D9A0D0
        public void ArgumentTypeDoesNotMatchMember(){} // RVA: 0x7FFAC8D9A120
        public void ArgumentMemberNotDeclOnType(){} // RVA: 0x7FFAC8D9A170
        public void ExpressionTypeDoesNotMatchReturn(){} // RVA: 0x7FFAC8D9A1C0
        public void ExpressionTypeDoesNotMatchAssignment(){} // RVA: 0x7FFAC8D9A210
        public void ExpressionTypeDoesNotMatchLabel(){} // RVA: 0x7FFAC8D9A260
        public void ExpressionTypeNotInvocable(){} // RVA: 0x7FFAC8D9A2B0
        public void FieldNotDefinedForType(){} // RVA: 0x7FFAC8D9A300
        public void InstanceFieldNotDefinedForType(){} // RVA: 0x7FFAC8D9A350
        public void FieldInfoNotDefinedForType(){} // RVA: 0x7FFAC8D9A3A0
        public void get_IncorrectNumberOfIndexes(){} // RVA: 0x7FFAC8D9A410
        public void get_IncorrectNumberOfLambdaDeclarationParameters(){} // RVA: 0x7FFAC8D9A450
        public void get_IncorrectNumberOfMembersForGivenConstructor(){} // RVA: 0x7FFAC8D9A490
        public void get_IncorrectNumberOfArgumentsForMembers(){} // RVA: 0x7FFAC8D9A4D0
        public void get_LambdaTypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x7FFAC8D9A510
        public void MemberNotFieldOrProperty(){} // RVA: 0x7FFAC8D9A550
        public void MethodContainsGenericParameters(){} // RVA: 0x7FFAC8D9A5A0
        public void MethodIsGeneric(){} // RVA: 0x7FFAC8D9A5F0
        public void MethodNotPropertyAccessor(){} // RVA: 0x7FFAC8D9A640
        public void PropertyDoesNotHaveGetter(){} // RVA: 0x7FFAC8D9A690
        public void PropertyDoesNotHaveSetter(){} // RVA: 0x7FFAC8D9A6E0
        public void PropertyDoesNotHaveAccessor(){} // RVA: 0x7FFAC8D9A730
        public void NotAMemberOfType(){} // RVA: 0x7FFAC8D9A780
        public void NotAMemberOfAnyType(){} // RVA: 0x7FFAC8D9A7D0
        public void ParameterExpressionNotValidAsDelegate(){} // RVA: 0x7FFAC8D9A820
        public void PropertyNotDefinedForType(){} // RVA: 0x7FFAC8D9A870
        public void InstancePropertyNotDefinedForType(){} // RVA: 0x7FFAC8D9A8C0
        public void InstancePropertyWithoutParameterNotDefinedForType(){} // RVA: 0x7FFAC8D9A910
        public void InstancePropertyWithSpecifiedParametersNotDefinedForType(){} // RVA: 0x7FFAC8D9A960
        public void InstanceAndMethodTypeMismatch(){} // RVA: 0x7FFAC8D9A9D0
        public void TypeMissingDefaultConstructor(){} // RVA: 0x7FFAC8D9AA40
        public void get_ElementInitializerMethodNotAdd(){} // RVA: 0x7FFAC8D9AA90
        public void ElementInitializerMethodNoRefOutParam(){} // RVA: 0x7FFAC8D9AAD0
        public void get_ElementInitializerMethodWithZeroArgs(){} // RVA: 0x7FFAC8D9AB20
        public void get_ElementInitializerMethodStatic(){} // RVA: 0x7FFAC8D9AB60
        public void TypeNotIEnumerable(){} // RVA: 0x7FFAC8D9ABA0
        public void UnhandledBinary(){} // RVA: 0x7FFAC8D9ABF0
        public void get_UnhandledBinding(){} // RVA: 0x7FFAC8D9AC40
        public void UnhandledBindingType(){} // RVA: 0x7FFAC8D9AC80
        public void UnhandledUnary(){} // RVA: 0x7FFAC8D9ACD0
        public void get_UnknownBindingType(){} // RVA: 0x7FFAC8D9AD20
        public void UserDefinedOpMustHaveConsistentTypes(){} // RVA: 0x7FFAC8D9AD60
        public void UserDefinedOpMustHaveValidReturnType(){} // RVA: 0x7FFAC8D9ADB0
        public void LogicalOperatorMustHaveBooleanOperators(){} // RVA: 0x7FFAC8D9AE00
        public void MethodWithArgsDoesNotExistOnType(){} // RVA: 0x7FFAC8D9AE50
        public void GenericMethodWithArgsDoesNotExistOnType(){} // RVA: 0x7FFAC8D9AEA0
        public void MethodWithMoreThanOneMatch(){} // RVA: 0x7FFAC8D9AEF0
        public void PropertyWithMoreThanOneMatch(){} // RVA: 0x7FFAC8D9AF40
        public void get_IncorrectNumberOfTypeArgsForFunc(){} // RVA: 0x7FFAC8D9AF90
        public void get_IncorrectNumberOfTypeArgsForAction(){} // RVA: 0x7FFAC8D9AFD0
        public void get_ArgumentCannotBeOfTypeVoid(){} // RVA: 0x7FFAC8D9B010
        public void OutOfRange(){} // RVA: 0x7FFAC8D9B050
        public void LabelTargetAlreadyDefined(){} // RVA: 0x7FFAC8D9B0A0
        public void LabelTargetUndefined(){} // RVA: 0x7FFAC8D9B0F0
        public void get_ControlCannotLeaveFinally(){} // RVA: 0x7FFAC8D9B140
        public void get_ControlCannotLeaveFilterTest(){} // RVA: 0x7FFAC8D9B180
        public void AmbiguousJump(){} // RVA: 0x7FFAC8D9B1C0
        public void get_ControlCannotEnterTry(){} // RVA: 0x7FFAC8D9B210
        public void get_ControlCannotEnterExpression(){} // RVA: 0x7FFAC8D9B250
        public void NonLocalJumpWithValue(){} // RVA: 0x7FFAC8D9B290
        public void InvalidLvalue(){} // RVA: 0x7FFAC8D9B2E0
        public void UndefinedVariable(){} // RVA: 0x7FFAC8D9B330
        public void CannotCloseOverByRef(){} // RVA: 0x7FFAC8D9B3A0
        public void UnexpectedVarArgsCall(){} // RVA: 0x7FFAC8D9B3F0
        public void get_RethrowRequiresCatch(){} // RVA: 0x7FFAC8D9B440
        public void get_TryNotAllowedInFilter(){} // RVA: 0x7FFAC8D9B480
        public void MustRewriteToSameNode(){} // RVA: 0x7FFAC8D9B4C0
        public void MustRewriteChildToSameType(){} // RVA: 0x7FFAC8D9B530
        public void MustRewriteWithoutMethod(){} // RVA: 0x7FFAC8D9B5A0
        public void TryNotSupportedForMethodsWithRefArgs(){} // RVA: 0x7FFAC8D9B5F0
        public void TryNotSupportedForValueTypeInstances(){} // RVA: 0x7FFAC8D9B640
        public void TestValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7FFAC8D9B690
        public void SwitchValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7FFAC8D9B6E0
        public void get_NonStaticConstructorRequired(){} // RVA: 0x7FFAC8D9B730
        public void get_NonAbstractConstructorRequired(){} // RVA: 0x7FFAC8D9B770
        public void get_ExpressionMustBeReadable(){} // RVA: 0x7FFAC8D9B7B0
        public void ExpressionTypeDoesNotMatchConstructorParameter(){} // RVA: 0x7FFAC8D9B7F0
        public void get_EnumerationIsDone(){} // RVA: 0x7FFAC8D9B840
        public void TypeContainsGenericParameters(){} // RVA: 0x7FFAC8D9B880
        public void TypeIsGeneric(){} // RVA: 0x7FFAC8D9B8D0
        public void get_InvalidArgumentValue(){} // RVA: 0x7FFAC8D9B920
        public void get_NonEmptyCollectionRequired(){} // RVA: 0x7FFAC8D9B960
        public void InvalidNullValue(){} // RVA: 0x7FFAC8D9B9A0
        public void InvalidObjectType(){} // RVA: 0x7FFAC8D9B9F0
        public void ExpressionTypeDoesNotMatchMethodParameter(){} // RVA: 0x7FFAC8D9BA40
        public void ExpressionTypeDoesNotMatchParameter(){} // RVA: 0x7FFAC8D9BAB0
        public void IncorrectNumberOfMethodCallArguments(){} // RVA: 0x7FFAC8D9BB00
        public void get_IncorrectNumberOfLambdaArguments(){} // RVA: 0x7FFAC8D9BB50
        public void get_IncorrectNumberOfConstructorArguments(){} // RVA: 0x7FFAC8D9BB90
    }

    public class SwitchCase : Object
    {
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression> TestValues; // 0x10
        public System.Linq.Expressions.Expression Body; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D9BCA0 | overloaded x2
        public void get_TestValues(){} // RVA: 0x7FFAC2F3C380
        public void get_Body(){} // RVA: 0x7FFAC2F247C0
        public void ToString(){} // RVA: 0x7FFAC8D89600
        public void Update(){} // RVA: 0x7FFAC8D9BBD0
    }

    public class SwitchExpression : Expression
    {
        public System.Type Type; // 0x10
        public System.Linq.Expressions.Expression NodeType; // 0x18
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.SwitchCase> SwitchValue; // 0x20
        public System.Linq.Expressions.Expression Cases; // 0x28
        public System.Reflection.MethodInfo DefaultBody; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D9C200 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void get_NodeType(){} // RVA: 0x7FFAC85F8C80
        public void get_SwitchValue(){} // RVA: 0x7FFAC2F247C0
        public void get_Cases(){} // RVA: 0x7FFAC2F4F0C0
        public void get_DefaultBody(){} // RVA: 0x7FFAC2F4F130
        public void get_Comparison(){} // RVA: 0x7FFAC31D95E0
        public void Accept(){} // RVA: 0x7FFAC8D9BED0
        public void get_IsLifted(){} // RVA: 0x7FFAC8D9BF00
        public void Update(){} // RVA: 0x7FFAC8D9C0F0
    }

    public class SymbolDocumentInfo : Object
    {
        public string FileName; // 0x10
        public System.Guid Language;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D9C470 | overloaded x2
        public void get_FileName(){} // RVA: 0x7FFAC2F3C380
        public void get_Language(){} // RVA: 0x7FFAC8D9C310
        public void get_LanguageVendor(){} // RVA: 0x7FFAC8D9C360
        public void get_DocumentType(){} // RVA: 0x7FFAC8D9C3B0
        public void .cctor(){} // RVA: 0x7FFAC8D9C410
    }

    public class SymbolDocumentWithGuids : SymbolDocumentInfo
    {
        public System.Guid Language; // 0x18
        public System.Guid LanguageVendor; // 0x28
        public System.Guid DocumentType; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D9C5D0 | overloaded x3
        public void get_Language(){} // RVA: 0x7FFAC35D3330
        public void get_LanguageVendor(){} // RVA: 0x7FFAC3BCF020
        public void get_DocumentType(){} // RVA: 0x7FFAC4426F60
    }

}