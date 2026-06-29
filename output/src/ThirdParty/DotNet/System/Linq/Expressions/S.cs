// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 12
// Methods: 225

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class Scope1 : ScopeExpression
    {
        public object _body;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x704C6B0
        public void SameExpressions(){} // RVA: 0x704C720
        public void GetExpression(){} // RVA: 0x704C970
        public void get_ExpressionCount(){} // RVA: 0xC3CCE0
        public void GetOrMakeExpressions(){} // RVA: 0x704C9F0
        public void Rewrite(){} // RVA: 0x704CA00
    }

    public class ScopeExpression : BlockExpression
    {
        public object _variables;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x704C220
        public void SameVariables(){} // RVA: 0x704C4F0
        public void GetOrMakeVariables(){} // RVA: 0x704C5D0
        public void get_VariablesList(){} // RVA: 0xB5DBF0
        public void ReuseOrValidateVariables(){} // RVA: 0x704C610
    }

    public class ScopeN : ScopeExpression
    {
        public object _body;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x704C6B0
        public void SameExpressions(){} // RVA: 0x704CB80
        public void get_Body(){} // RVA: 0xB465B0
        public void GetExpression(){} // RVA: 0x704CC60
        public void get_ExpressionCount(){} // RVA: 0x704CCC0
        public void GetOrMakeExpressions(){} // RVA: 0x704CD10
        public void Rewrite(){} // RVA: 0x704CD50
    }

    public class ScopeWithType : ScopeN
    {
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x704CEB0
        public void get_Type(){} // RVA: 0xB700F0
        public void Rewrite(){} // RVA: 0x704CF90
    }

    public class SimpleBinaryExpression : BinaryExpression
    {
        public object _nodeType;
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x701F850
        public void get_NodeType(){} // RVA: 0xFEAE90
        public void get_Type(){} // RVA: 0xB70160
    }

    public class SpanDebugInfoExpression : DebugInfoExpression
    {
        public object _startLine;
        public object _startColumn;
        public object _endLine;
        public object _endColumn;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x704E9B0
        public void get_StartLine(){} // RVA: 0xE62D00
        public void get_StartColumn(){} // RVA: 0x2244FB0
        public void get_EndLine(){} // RVA: 0xFEAE90
        public void get_EndColumn(){} // RVA: 0x15AF000
        public void get_IsClear(){} // RVA: 0xB43320
        public void Accept(){} // RVA: 0x704E950
    }

    public class StackGuard : Object
    {
        public object MaxExecutionStackCount;
        public object _executionStackCount;

        // ── Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0xC2E4C0
        public void RunOnEmptyStack(){} // RVA: 0xA94080
        public void RunOnEmptyStackCore(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Strings : Object
    {
        // ── Methods ──
        public void get_ReducibleMustOverrideReduce(){} // RVA: 0x706FCB0
        public void get_MustReduceToDifferent(){} // RVA: 0x706FCF0
        public void get_ReducedNotCompatible(){} // RVA: 0x706FD30
        public void get_SetterHasNoParams(){} // RVA: 0x706FD70
        public void get_PropertyCannotHaveRefType(){} // RVA: 0x706FDB0
        public void get_IndexesOfSetGetMustMatch(){} // RVA: 0x706FDF0
        public void get_AccessorsCannotHaveVarArgs(){} // RVA: 0x706FE30
        public void get_AccessorsCannotHaveByRefArgs(){} // RVA: 0x706FE70
        public void get_BoundsCannotBeLessThanOne(){} // RVA: 0x706FEB0
        public void get_TypeMustNotBeByRef(){} // RVA: 0x706FEF0
        public void get_TypeMustNotBePointer(){} // RVA: 0x706FF30
        public void get_SetterMustBeVoid(){} // RVA: 0x706FF70
        public void get_PropertyTypeMustMatchGetter(){} // RVA: 0x706FFB0
        public void get_PropertyTypeMustMatchSetter(){} // RVA: 0x706FFF0
        public void get_BothAccessorsMustBeStatic(){} // RVA: 0x7070030
        public void get_OnlyStaticFieldsHaveNullInstance(){} // RVA: 0x7070070
        public void get_OnlyStaticPropertiesHaveNullInstance(){} // RVA: 0x70700B0
        public void get_OnlyStaticMethodsHaveNullInstance(){} // RVA: 0x70700F0
        public void get_PropertyTypeCannotBeVoid(){} // RVA: 0x7070130
        public void get_InvalidUnboxType(){} // RVA: 0x7070170
        public void get_ExpressionMustBeWriteable(){} // RVA: 0x70701B0
        public void get_ArgumentMustNotHaveValueType(){} // RVA: 0x70701F0
        public void get_MustBeReducible(){} // RVA: 0x7070230
        public void get_AllTestValuesMustHaveSameType(){} // RVA: 0x7070270
        public void get_AllCaseBodiesMustHaveSameType(){} // RVA: 0x70702B0
        public void get_DefaultBodyMustBeSupplied(){} // RVA: 0x70702F0
        public void get_LabelMustBeVoidOrHaveExpression(){} // RVA: 0x7070330
        public void get_LabelTypeMustBeVoid(){} // RVA: 0x7070370
        public void get_QuotedExpressionMustBeLambda(){} // RVA: 0x70703B0
        public void get_CollectionModifiedWhileEnumerating(){} // RVA: 0x70703F0
        public void VariableMustNotBeByRef(){} // RVA: 0x7070430
        public void get_CollectionReadOnly(){} // RVA: 0x7070480
        public void AmbiguousMatchInExpandoObject(){} // RVA: 0x70704C0
        public void SameKeyExistsInExpando(){} // RVA: 0x7070510
        public void KeyDoesNotExistInExpando(){} // RVA: 0x7070560
        public void get_ArgCntMustBeGreaterThanNameCnt(){} // RVA: 0x70705B0
        public void InvalidMetaObjectCreated(){} // RVA: 0x70705F0
        public void BinderNotCompatibleWithCallSite(){} // RVA: 0x7070640
        public void DynamicBindingNeedsRestrictions(){} // RVA: 0x70706B0
        public void DynamicObjectResultNotAssignable(){} // RVA: 0x7070700
        public void DynamicBinderResultNotAssignable(){} // RVA: 0x7070920
        public void get_BindingCannotBeNull(){} // RVA: 0x7070990
        public void DuplicateVariable(){} // RVA: 0x70709D0
        public void get_ArgumentTypeCannotBeVoid(){} // RVA: 0x7070A20
        public void TypeParameterIsNotDelegate(){} // RVA: 0x7070A60
        public void get_NoOrInvalidRuleProduced(){} // RVA: 0x7070AB0
        public void get_TypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x7070AF0
        public void get_FirstArgumentMustBeCallSite(){} // RVA: 0x7070B30
        public void get_StartEndMustBeOrdered(){} // RVA: 0x7070B70
        public void get_FaultCannotHaveCatchOrFinally(){} // RVA: 0x7070BB0
        public void get_TryMustHaveCatchFinallyOrFault(){} // RVA: 0x7070BF0
        public void get_BodyOfCatchMustHaveSameTypeAsBodyOfTry(){} // RVA: 0x7070C30
        public void ExtensionNodeMustOverrideProperty(){} // RVA: 0x7070C70
        public void UserDefinedOperatorMustBeStatic(){} // RVA: 0x7070CC0
        public void UserDefinedOperatorMustNotBeVoid(){} // RVA: 0x7070D10
        public void CoercionOperatorNotDefined(){} // RVA: 0x7070D60
        public void UnaryOperatorNotDefined(){} // RVA: 0x7070DB0
        public void BinaryOperatorNotDefined(){} // RVA: 0x7070E00
        public void ReferenceEqualityNotDefined(){} // RVA: 0x7070E70
        public void OperandTypesDoNotMatchParameters(){} // RVA: 0x7070EC0
        public void OverloadOperatorTypeDoesNotMatchConversionType(){} // RVA: 0x7070F10
        public void get_ConversionIsNotSupportedForArithmeticTypes(){} // RVA: 0x7070F60
        public void get_ArgumentMustBeArray(){} // RVA: 0x7070FA0
        public void get_ArgumentMustBeBoolean(){} // RVA: 0x7070FE0
        public void EqualityMustReturnBoolean(){} // RVA: 0x7071020
        public void get_ArgumentMustBeFieldInfoOrPropertyInfo(){} // RVA: 0x7071070
        public void get_ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(){} // RVA: 0x70710B0
        public void get_ArgumentMustBeInstanceMember(){} // RVA: 0x70710F0
        public void get_ArgumentMustBeInteger(){} // RVA: 0x7071130
        public void get_ArgumentMustBeArrayIndexType(){} // RVA: 0x7071170
        public void get_ArgumentMustBeSingleDimensionalArrayType(){} // RVA: 0x70711B0
        public void get_ArgumentTypesMustMatch(){} // RVA: 0x70711F0
        public void CannotAutoInitializeValueTypeElementThroughProperty(){} // RVA: 0x7071230
        public void CannotAutoInitializeValueTypeMemberThroughProperty(){} // RVA: 0x7071280
        public void IncorrectTypeForTypeAs(){} // RVA: 0x70712D0
        public void get_CoalesceUsedOnNonNullType(){} // RVA: 0x7071320
        public void ExpressionTypeCannotInitializeArrayType(){} // RVA: 0x7071360
        public void ArgumentTypeDoesNotMatchMember(){} // RVA: 0x70713B0
        public void ArgumentMemberNotDeclOnType(){} // RVA: 0x7071400
        public void ExpressionTypeDoesNotMatchReturn(){} // RVA: 0x7071450
        public void ExpressionTypeDoesNotMatchAssignment(){} // RVA: 0x70714A0
        public void ExpressionTypeDoesNotMatchLabel(){} // RVA: 0x70714F0
        public void ExpressionTypeNotInvocable(){} // RVA: 0x7071540
        public void FieldNotDefinedForType(){} // RVA: 0x7071590
        public void InstanceFieldNotDefinedForType(){} // RVA: 0x70715E0
        public void FieldInfoNotDefinedForType(){} // RVA: 0x7071630
        public void get_IncorrectNumberOfIndexes(){} // RVA: 0x70716A0
        public void get_IncorrectNumberOfLambdaDeclarationParameters(){} // RVA: 0x70716E0
        public void get_IncorrectNumberOfMembersForGivenConstructor(){} // RVA: 0x7071720
        public void get_IncorrectNumberOfArgumentsForMembers(){} // RVA: 0x7071760
        public void get_LambdaTypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x70717A0
        public void MemberNotFieldOrProperty(){} // RVA: 0x70717E0
        public void MethodContainsGenericParameters(){} // RVA: 0x7071830
        public void MethodIsGeneric(){} // RVA: 0x7071880
        public void MethodNotPropertyAccessor(){} // RVA: 0x70718D0
        public void PropertyDoesNotHaveGetter(){} // RVA: 0x7071920
        public void PropertyDoesNotHaveSetter(){} // RVA: 0x7071970
        public void PropertyDoesNotHaveAccessor(){} // RVA: 0x70719C0
        public void NotAMemberOfType(){} // RVA: 0x7071A10
        public void NotAMemberOfAnyType(){} // RVA: 0x7071A60
        public void ParameterExpressionNotValidAsDelegate(){} // RVA: 0x7071AB0
        public void PropertyNotDefinedForType(){} // RVA: 0x7071B00
        public void InstancePropertyNotDefinedForType(){} // RVA: 0x7071B50
        public void InstancePropertyWithoutParameterNotDefinedForType(){} // RVA: 0x7071BA0
        public void InstancePropertyWithSpecifiedParametersNotDefinedForType(){} // RVA: 0x7071BF0
        public void InstanceAndMethodTypeMismatch(){} // RVA: 0x7071C60
        public void TypeMissingDefaultConstructor(){} // RVA: 0x7071CD0
        public void get_ElementInitializerMethodNotAdd(){} // RVA: 0x7071D20
        public void ElementInitializerMethodNoRefOutParam(){} // RVA: 0x7071D60
        public void get_ElementInitializerMethodWithZeroArgs(){} // RVA: 0x7071DB0
        public void get_ElementInitializerMethodStatic(){} // RVA: 0x7071DF0
        public void TypeNotIEnumerable(){} // RVA: 0x7071E30
        public void UnhandledBinary(){} // RVA: 0x7071E80
        public void get_UnhandledBinding(){} // RVA: 0x7071ED0
        public void UnhandledBindingType(){} // RVA: 0x7071F10
        public void UnhandledUnary(){} // RVA: 0x7071F60
        public void get_UnknownBindingType(){} // RVA: 0x7071FB0
        public void UserDefinedOpMustHaveConsistentTypes(){} // RVA: 0x7071FF0
        public void UserDefinedOpMustHaveValidReturnType(){} // RVA: 0x7072040
        public void LogicalOperatorMustHaveBooleanOperators(){} // RVA: 0x7072090
        public void MethodWithArgsDoesNotExistOnType(){} // RVA: 0x70720E0
        public void GenericMethodWithArgsDoesNotExistOnType(){} // RVA: 0x7072130
        public void MethodWithMoreThanOneMatch(){} // RVA: 0x7072180
        public void PropertyWithMoreThanOneMatch(){} // RVA: 0x70721D0
        public void get_IncorrectNumberOfTypeArgsForFunc(){} // RVA: 0x7072220
        public void get_IncorrectNumberOfTypeArgsForAction(){} // RVA: 0x7072260
        public void get_ArgumentCannotBeOfTypeVoid(){} // RVA: 0x70722A0
        public void OutOfRange(){} // RVA: 0x70722E0
        public void LabelTargetAlreadyDefined(){} // RVA: 0x7072330
        public void LabelTargetUndefined(){} // RVA: 0x7072380
        public void get_ControlCannotLeaveFinally(){} // RVA: 0x70723D0
        public void get_ControlCannotLeaveFilterTest(){} // RVA: 0x7072410
        public void AmbiguousJump(){} // RVA: 0x7072450
        public void get_ControlCannotEnterTry(){} // RVA: 0x70724A0
        public void get_ControlCannotEnterExpression(){} // RVA: 0x70724E0
        public void NonLocalJumpWithValue(){} // RVA: 0x7072520
        public void InvalidLvalue(){} // RVA: 0x7072570
        public void UndefinedVariable(){} // RVA: 0x70725C0
        public void CannotCloseOverByRef(){} // RVA: 0x7072630
        public void UnexpectedVarArgsCall(){} // RVA: 0x7072680
        public void get_RethrowRequiresCatch(){} // RVA: 0x70726D0
        public void get_TryNotAllowedInFilter(){} // RVA: 0x7072710
        public void MustRewriteToSameNode(){} // RVA: 0x7072750
        public void MustRewriteChildToSameType(){} // RVA: 0x70727C0
        public void MustRewriteWithoutMethod(){} // RVA: 0x7072830
        public void TryNotSupportedForMethodsWithRefArgs(){} // RVA: 0x7072880
        public void TryNotSupportedForValueTypeInstances(){} // RVA: 0x70728D0
        public void TestValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7072920
        public void SwitchValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7072970
        public void get_NonStaticConstructorRequired(){} // RVA: 0x70729C0
        public void get_NonAbstractConstructorRequired(){} // RVA: 0x7072A00
        public void get_ExpressionMustBeReadable(){} // RVA: 0x7072A40
        public void ExpressionTypeDoesNotMatchConstructorParameter(){} // RVA: 0x7072A80
        public void get_EnumerationIsDone(){} // RVA: 0x7072AD0
        public void TypeContainsGenericParameters(){} // RVA: 0x7072B10
        public void TypeIsGeneric(){} // RVA: 0x7072B60
        public void get_InvalidArgumentValue(){} // RVA: 0x7072BB0
        public void get_NonEmptyCollectionRequired(){} // RVA: 0x7072BF0
        public void InvalidNullValue(){} // RVA: 0x7072C30
        public void InvalidObjectType(){} // RVA: 0x7072C80
        public void ExpressionTypeDoesNotMatchMethodParameter(){} // RVA: 0x7072CD0
        public void ExpressionTypeDoesNotMatchParameter(){} // RVA: 0x7072D40
        public void IncorrectNumberOfMethodCallArguments(){} // RVA: 0x7072D90
        public void get_IncorrectNumberOfLambdaArguments(){} // RVA: 0x7072DE0
        public void get_IncorrectNumberOfConstructorArguments(){} // RVA: 0x7072E20
    }

    public class SwitchCase : Object
    {
        public object _testValues;
        public object _body;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7072F30
        public void get_TestValues(){} // RVA: 0xB5DBF0
        public void get_Body(){} // RVA: 0xB465B0
        public void ToString(){} // RVA: 0x7060A50
        public void Update(){} // RVA: 0x7072E60
    }

    public class SwitchExpression : Expression
    {
        public object _type;
        public object _switchValue;
        public object _cases;
        public object _defaultBody;
        public object _comparison;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7073470
        public void get_Type(){} // RVA: 0xB5DBF0
        public void get_NodeType(){} // RVA: 0x68DAA20
        public void get_SwitchValue(){} // RVA: 0xB465B0
        public void get_Cases(){} // RVA: 0xB700F0
        public void get_DefaultBody(){} // RVA: 0xB70160
        public void get_Comparison(){} // RVA: 0xD33E60
        public void Accept(){} // RVA: 0x7073160
        public void get_IsLifted(){} // RVA: 0x7073190
        public void Update(){} // RVA: 0x7073360
    }

    public class SymbolDocumentInfo : Object
    {
        public object _fileName;
        public object DocumentType_Text;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70736E0
        public void get_FileName(){} // RVA: 0xB5DBF0
        public void get_Language(){} // RVA: 0x7073580
        public void get_LanguageVendor(){} // RVA: 0x70735D0
        public void get_DocumentType(){} // RVA: 0x7073620
        public void .cctor(){} // RVA: 0x7073680
    }

    public class SymbolDocumentWithGuids : SymbolDocumentInfo
    {
        public object _language;
        public object _languageVendor;
        public object _documentType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70739B0
        public void get_Language(){} // RVA: 0x125EE60
        public void get_LanguageVendor(){} // RVA: 0x19F92B0
        public void get_DocumentType(){} // RVA: 0x2237C00
    }

}