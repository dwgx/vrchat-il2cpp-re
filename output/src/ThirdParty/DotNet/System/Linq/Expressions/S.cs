// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 12
// Methods: 234

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class Scope1 : ScopeExpression
    {
        public object _body; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8711D1D0 | overloaded x2
        public void SameExpressions(){} // RVA: 0x7FFE8711D240
        public void GetExpression(){} // RVA: 0x7FFE8711D4A0
        public void get_ExpressionCount(){} // RVA: 0x7FFE811EDAF0
        public void GetOrMakeExpressions(){} // RVA: 0x7FFE8711D520
        public void Rewrite(){} // RVA: 0x7FFE8711D530
    }

    public class ScopeExpression : BlockExpression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.ParameterExpression> _variables; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8711CD40
        public void SameVariables(){} // RVA: 0x7FFE8711D010
        public void GetOrMakeVariables(){} // RVA: 0x7FFE8711D0F0
        public void get_VariablesList(){} // RVA: 0x7FFE81116380
        public void ReuseOrValidateVariables(){} // RVA: 0x7FFE8711D130
    }

    public class ScopeN : ScopeExpression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> _body; // 0x18
        public object field_1; // 0x148

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8711D1D0
        public void SameExpressions(){} // RVA: 0x7FFE8711D6B0
        public void get_Body(){} // RVA: 0x7FFE810FE7C0
        public void GetExpression(){} // RVA: 0x7FFE8711D790
        public void get_ExpressionCount(){} // RVA: 0x7FFE8711D7F0
        public void GetOrMakeExpressions(){} // RVA: 0x7FFE8711D840
        public void Rewrite(){} // RVA: 0x7FFE8711D880
    }

    public class ScopeWithType : ScopeN
    {
        public System.Type _type; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8711D9E0
        public void get_Type(){} // RVA: 0x7FFE811290C0
        public void Rewrite(){} // RVA: 0x7FFE8711DAC0
    }

    public class SimpleBinaryExpression : BinaryExpression
    {
        public 0x665E5D54 _nodeType; // 0x20
        public System.Type _type; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE870EFFD0
        public void get_NodeType(){} // RVA: 0x7FFE8151D690
        public void get_Type(){} // RVA: 0x7FFE81129130
    }

    public class SpanDebugInfoExpression : DebugInfoExpression
    {
        public int _startLine; // 0x18
        public int _startColumn; // 0x1C
        public int _endLine; // 0x20
        public int _endColumn; // 0x24
        public object field_4; // 0x166

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8711F500
        public void get_StartLine(){} // RVA: 0x7FFE813DB630
        public void get_StartColumn(){} // RVA: 0x7FFE82707EE0
        public void get_EndLine(){} // RVA: 0x7FFE8151D690
        public void get_EndColumn(){} // RVA: 0x7FFE81A56130
        public void get_IsClear(){} // RVA: 0x7FFE810FB320
        public void Accept(){} // RVA: 0x7FFE8711F4A0
    }

    public class StackGuard : Object
    {
        // ── Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0x7FFE811E0850
        public void RunOnEmptyStack(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void RunOnEmptyStackCore(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Strings : Object
    {
        // ── Methods ──
        public void get_ReducibleMustOverrideReduce(){} // RVA: 0x7FFE87140E50
        public void get_MustReduceToDifferent(){} // RVA: 0x7FFE87140E90
        public void get_ReducedNotCompatible(){} // RVA: 0x7FFE87140ED0
        public void get_SetterHasNoParams(){} // RVA: 0x7FFE87140F10
        public void get_PropertyCannotHaveRefType(){} // RVA: 0x7FFE87140F50
        public void get_IndexesOfSetGetMustMatch(){} // RVA: 0x7FFE87140F90
        public void get_AccessorsCannotHaveVarArgs(){} // RVA: 0x7FFE87140FD0
        public void get_AccessorsCannotHaveByRefArgs(){} // RVA: 0x7FFE87141010
        public void get_BoundsCannotBeLessThanOne(){} // RVA: 0x7FFE87141050
        public void get_TypeMustNotBeByRef(){} // RVA: 0x7FFE87141090
        public void get_TypeMustNotBePointer(){} // RVA: 0x7FFE871410D0
        public void get_SetterMustBeVoid(){} // RVA: 0x7FFE87141110
        public void get_PropertyTypeMustMatchGetter(){} // RVA: 0x7FFE87141150
        public void get_PropertyTypeMustMatchSetter(){} // RVA: 0x7FFE87141190
        public void get_BothAccessorsMustBeStatic(){} // RVA: 0x7FFE871411D0
        public void get_OnlyStaticFieldsHaveNullInstance(){} // RVA: 0x7FFE87141210
        public void get_OnlyStaticPropertiesHaveNullInstance(){} // RVA: 0x7FFE87141250
        public void get_OnlyStaticMethodsHaveNullInstance(){} // RVA: 0x7FFE87141290
        public void get_PropertyTypeCannotBeVoid(){} // RVA: 0x7FFE871412D0
        public void get_InvalidUnboxType(){} // RVA: 0x7FFE87141310
        public void get_ExpressionMustBeWriteable(){} // RVA: 0x7FFE87141350
        public void get_ArgumentMustNotHaveValueType(){} // RVA: 0x7FFE87141390
        public void get_MustBeReducible(){} // RVA: 0x7FFE871413D0
        public void get_AllTestValuesMustHaveSameType(){} // RVA: 0x7FFE87141410
        public void get_AllCaseBodiesMustHaveSameType(){} // RVA: 0x7FFE87141450
        public void get_DefaultBodyMustBeSupplied(){} // RVA: 0x7FFE87141490
        public void get_LabelMustBeVoidOrHaveExpression(){} // RVA: 0x7FFE871414D0
        public void get_LabelTypeMustBeVoid(){} // RVA: 0x7FFE87141510
        public void get_QuotedExpressionMustBeLambda(){} // RVA: 0x7FFE87141550
        public void get_CollectionModifiedWhileEnumerating(){} // RVA: 0x7FFE87141590
        public void VariableMustNotBeByRef(){} // RVA: 0x7FFE871415D0
        public void get_CollectionReadOnly(){} // RVA: 0x7FFE87141620
        public void AmbiguousMatchInExpandoObject(){} // RVA: 0x7FFE87141660
        public void SameKeyExistsInExpando(){} // RVA: 0x7FFE871416B0
        public void KeyDoesNotExistInExpando(){} // RVA: 0x7FFE87141700
        public void get_ArgCntMustBeGreaterThanNameCnt(){} // RVA: 0x7FFE87141750
        public void InvalidMetaObjectCreated(){} // RVA: 0x7FFE87141790
        public void BinderNotCompatibleWithCallSite(){} // RVA: 0x7FFE871417E0
        public void DynamicBindingNeedsRestrictions(){} // RVA: 0x7FFE87141850
        public void DynamicObjectResultNotAssignable(){} // RVA: 0x7FFE871418A0
        public void DynamicBinderResultNotAssignable(){} // RVA: 0x7FFE87141AC0
        public void get_BindingCannotBeNull(){} // RVA: 0x7FFE87141B30
        public void DuplicateVariable(){} // RVA: 0x7FFE87141B70
        public void get_ArgumentTypeCannotBeVoid(){} // RVA: 0x7FFE87141BC0
        public void TypeParameterIsNotDelegate(){} // RVA: 0x7FFE87141C00
        public void get_NoOrInvalidRuleProduced(){} // RVA: 0x7FFE87141C50
        public void get_TypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x7FFE87141C90
        public void get_FirstArgumentMustBeCallSite(){} // RVA: 0x7FFE87141CD0
        public void get_StartEndMustBeOrdered(){} // RVA: 0x7FFE87141D10
        public void get_FaultCannotHaveCatchOrFinally(){} // RVA: 0x7FFE87141D50
        public void get_TryMustHaveCatchFinallyOrFault(){} // RVA: 0x7FFE87141D90
        public void get_BodyOfCatchMustHaveSameTypeAsBodyOfTry(){} // RVA: 0x7FFE87141DD0
        public void ExtensionNodeMustOverrideProperty(){} // RVA: 0x7FFE87141E10
        public void UserDefinedOperatorMustBeStatic(){} // RVA: 0x7FFE87141E60
        public void UserDefinedOperatorMustNotBeVoid(){} // RVA: 0x7FFE87141EB0
        public void CoercionOperatorNotDefined(){} // RVA: 0x7FFE87141F00
        public void UnaryOperatorNotDefined(){} // RVA: 0x7FFE87141F50
        public void BinaryOperatorNotDefined(){} // RVA: 0x7FFE87141FA0
        public void ReferenceEqualityNotDefined(){} // RVA: 0x7FFE87142010
        public void OperandTypesDoNotMatchParameters(){} // RVA: 0x7FFE87142060
        public void OverloadOperatorTypeDoesNotMatchConversionType(){} // RVA: 0x7FFE871420B0
        public void get_ConversionIsNotSupportedForArithmeticTypes(){} // RVA: 0x7FFE87142100
        public void get_ArgumentMustBeArray(){} // RVA: 0x7FFE87142140
        public void get_ArgumentMustBeBoolean(){} // RVA: 0x7FFE87142180
        public void EqualityMustReturnBoolean(){} // RVA: 0x7FFE871421C0
        public void get_ArgumentMustBeFieldInfoOrPropertyInfo(){} // RVA: 0x7FFE87142210
        public void get_ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(){} // RVA: 0x7FFE87142250
        public void get_ArgumentMustBeInstanceMember(){} // RVA: 0x7FFE87142290
        public void get_ArgumentMustBeInteger(){} // RVA: 0x7FFE871422D0
        public void get_ArgumentMustBeArrayIndexType(){} // RVA: 0x7FFE87142310
        public void get_ArgumentMustBeSingleDimensionalArrayType(){} // RVA: 0x7FFE87142350
        public void get_ArgumentTypesMustMatch(){} // RVA: 0x7FFE87142390
        public void CannotAutoInitializeValueTypeElementThroughProperty(){} // RVA: 0x7FFE871423D0
        public void CannotAutoInitializeValueTypeMemberThroughProperty(){} // RVA: 0x7FFE87142420
        public void IncorrectTypeForTypeAs(){} // RVA: 0x7FFE87142470
        public void get_CoalesceUsedOnNonNullType(){} // RVA: 0x7FFE871424C0
        public void ExpressionTypeCannotInitializeArrayType(){} // RVA: 0x7FFE87142500
        public void ArgumentTypeDoesNotMatchMember(){} // RVA: 0x7FFE87142550
        public void ArgumentMemberNotDeclOnType(){} // RVA: 0x7FFE871425A0
        public void ExpressionTypeDoesNotMatchReturn(){} // RVA: 0x7FFE871425F0
        public void ExpressionTypeDoesNotMatchAssignment(){} // RVA: 0x7FFE87142640
        public void ExpressionTypeDoesNotMatchLabel(){} // RVA: 0x7FFE87142690
        public void ExpressionTypeNotInvocable(){} // RVA: 0x7FFE871426E0
        public void FieldNotDefinedForType(){} // RVA: 0x7FFE87142730
        public void InstanceFieldNotDefinedForType(){} // RVA: 0x7FFE87142780
        public void FieldInfoNotDefinedForType(){} // RVA: 0x7FFE871427D0
        public void get_IncorrectNumberOfIndexes(){} // RVA: 0x7FFE87142840
        public void get_IncorrectNumberOfLambdaDeclarationParameters(){} // RVA: 0x7FFE87142880
        public void get_IncorrectNumberOfMembersForGivenConstructor(){} // RVA: 0x7FFE871428C0
        public void get_IncorrectNumberOfArgumentsForMembers(){} // RVA: 0x7FFE87142900
        public void get_LambdaTypeMustBeDerivedFromSystemDelegate(){} // RVA: 0x7FFE87142940
        public void MemberNotFieldOrProperty(){} // RVA: 0x7FFE87142980
        public void MethodContainsGenericParameters(){} // RVA: 0x7FFE871429D0
        public void MethodIsGeneric(){} // RVA: 0x7FFE87142A20
        public void MethodNotPropertyAccessor(){} // RVA: 0x7FFE87142A70
        public void PropertyDoesNotHaveGetter(){} // RVA: 0x7FFE87142AC0
        public void PropertyDoesNotHaveSetter(){} // RVA: 0x7FFE87142B10
        public void PropertyDoesNotHaveAccessor(){} // RVA: 0x7FFE87142B60
        public void NotAMemberOfType(){} // RVA: 0x7FFE87142BB0
        public void NotAMemberOfAnyType(){} // RVA: 0x7FFE87142C00
        public void ParameterExpressionNotValidAsDelegate(){} // RVA: 0x7FFE87142C50
        public void PropertyNotDefinedForType(){} // RVA: 0x7FFE87142CA0
        public void InstancePropertyNotDefinedForType(){} // RVA: 0x7FFE87142CF0
        public void InstancePropertyWithoutParameterNotDefinedForType(){} // RVA: 0x7FFE87142D40
        public void InstancePropertyWithSpecifiedParametersNotDefinedForType(){} // RVA: 0x7FFE87142D90
        public void InstanceAndMethodTypeMismatch(){} // RVA: 0x7FFE87142E00
        public void TypeMissingDefaultConstructor(){} // RVA: 0x7FFE87142E70
        public void get_ElementInitializerMethodNotAdd(){} // RVA: 0x7FFE87142EC0
        public void ElementInitializerMethodNoRefOutParam(){} // RVA: 0x7FFE87142F00
        public void get_ElementInitializerMethodWithZeroArgs(){} // RVA: 0x7FFE87142F50
        public void get_ElementInitializerMethodStatic(){} // RVA: 0x7FFE87142F90
        public void TypeNotIEnumerable(){} // RVA: 0x7FFE87142FD0
        public void UnhandledBinary(){} // RVA: 0x7FFE87143020
        public void get_UnhandledBinding(){} // RVA: 0x7FFE87143070
        public void UnhandledBindingType(){} // RVA: 0x7FFE871430B0
        public void UnhandledUnary(){} // RVA: 0x7FFE87143100
        public void get_UnknownBindingType(){} // RVA: 0x7FFE87143150
        public void UserDefinedOpMustHaveConsistentTypes(){} // RVA: 0x7FFE87143190
        public void UserDefinedOpMustHaveValidReturnType(){} // RVA: 0x7FFE871431E0
        public void LogicalOperatorMustHaveBooleanOperators(){} // RVA: 0x7FFE87143230
        public void MethodWithArgsDoesNotExistOnType(){} // RVA: 0x7FFE87143280
        public void GenericMethodWithArgsDoesNotExistOnType(){} // RVA: 0x7FFE871432D0
        public void MethodWithMoreThanOneMatch(){} // RVA: 0x7FFE87143320
        public void PropertyWithMoreThanOneMatch(){} // RVA: 0x7FFE87143370
        public void get_IncorrectNumberOfTypeArgsForFunc(){} // RVA: 0x7FFE871433C0
        public void get_IncorrectNumberOfTypeArgsForAction(){} // RVA: 0x7FFE87143400
        public void get_ArgumentCannotBeOfTypeVoid(){} // RVA: 0x7FFE87143440
        public void OutOfRange(){} // RVA: 0x7FFE87143480
        public void LabelTargetAlreadyDefined(){} // RVA: 0x7FFE871434D0
        public void LabelTargetUndefined(){} // RVA: 0x7FFE87143520
        public void get_ControlCannotLeaveFinally(){} // RVA: 0x7FFE87143570
        public void get_ControlCannotLeaveFilterTest(){} // RVA: 0x7FFE871435B0
        public void AmbiguousJump(){} // RVA: 0x7FFE871435F0
        public void get_ControlCannotEnterTry(){} // RVA: 0x7FFE87143640
        public void get_ControlCannotEnterExpression(){} // RVA: 0x7FFE87143680
        public void NonLocalJumpWithValue(){} // RVA: 0x7FFE871436C0
        public void InvalidLvalue(){} // RVA: 0x7FFE87143710
        public void UndefinedVariable(){} // RVA: 0x7FFE87143760
        public void CannotCloseOverByRef(){} // RVA: 0x7FFE871437D0
        public void UnexpectedVarArgsCall(){} // RVA: 0x7FFE87143820
        public void get_RethrowRequiresCatch(){} // RVA: 0x7FFE87143870
        public void get_TryNotAllowedInFilter(){} // RVA: 0x7FFE871438B0
        public void MustRewriteToSameNode(){} // RVA: 0x7FFE871438F0
        public void MustRewriteChildToSameType(){} // RVA: 0x7FFE87143960
        public void MustRewriteWithoutMethod(){} // RVA: 0x7FFE871439D0
        public void TryNotSupportedForMethodsWithRefArgs(){} // RVA: 0x7FFE87143A20
        public void TryNotSupportedForValueTypeInstances(){} // RVA: 0x7FFE87143A70
        public void TestValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7FFE87143AC0
        public void SwitchValueTypeDoesNotMatchComparisonMethodParameter(){} // RVA: 0x7FFE87143B10
        public void get_NonStaticConstructorRequired(){} // RVA: 0x7FFE87143B60
        public void get_NonAbstractConstructorRequired(){} // RVA: 0x7FFE87143BA0
        public void get_ExpressionMustBeReadable(){} // RVA: 0x7FFE87143BE0
        public void ExpressionTypeDoesNotMatchConstructorParameter(){} // RVA: 0x7FFE87143C20
        public void get_EnumerationIsDone(){} // RVA: 0x7FFE87143C70
        public void TypeContainsGenericParameters(){} // RVA: 0x7FFE87143CB0
        public void TypeIsGeneric(){} // RVA: 0x7FFE87143D00
        public void get_InvalidArgumentValue(){} // RVA: 0x7FFE87143D50
        public void get_NonEmptyCollectionRequired(){} // RVA: 0x7FFE87143D90
        public void InvalidNullValue(){} // RVA: 0x7FFE87143DD0
        public void InvalidObjectType(){} // RVA: 0x7FFE87143E20
        public void ExpressionTypeDoesNotMatchMethodParameter(){} // RVA: 0x7FFE87143E70
        public void ExpressionTypeDoesNotMatchParameter(){} // RVA: 0x7FFE87143EE0
        public void IncorrectNumberOfMethodCallArguments(){} // RVA: 0x7FFE87143F30
        public void get_IncorrectNumberOfLambdaArguments(){} // RVA: 0x7FFE87143F80
        public void get_IncorrectNumberOfConstructorArguments(){} // RVA: 0x7FFE87143FC0
    }

    public class SwitchCase : Object
    {
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression> _testValues; // 0x10
        public System.Linq.Expressions.Expression _body; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871440D0 | overloaded x2
        public void get_TestValues(){} // RVA: 0x7FFE81116380
        public void get_Body(){} // RVA: 0x7FFE810FE7C0
        public void ToString(){} // RVA: 0x7FFE87131A30
        public void Update(){} // RVA: 0x7FFE87144000
    }

    public class SwitchExpression : Expression
    {
        public System.Type _type; // 0x10
        public System.Linq.Expressions.Expression _switchValue; // 0x18
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.SwitchCase> _cases; // 0x20
        public System.Linq.Expressions.Expression _defaultBody; // 0x28
        public System.Reflection.MethodInfo _comparison; // 0x30
        public object field_5; // 0x250
        public object field_6; // 0x251

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87144630 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void get_NodeType(){} // RVA: 0x7FFE869A2450
        public void get_SwitchValue(){} // RVA: 0x7FFE810FE7C0
        public void get_Cases(){} // RVA: 0x7FFE811290C0
        public void get_DefaultBody(){} // RVA: 0x7FFE81129130
        public void get_Comparison(){} // RVA: 0x7FFE8144E200
        public void Accept(){} // RVA: 0x7FFE87144300
        public void get_IsLifted(){} // RVA: 0x7FFE87144330
        public void Update(){} // RVA: 0x7FFE87144520
    }

    public class SymbolDocumentInfo : Object
    {
        public string _fileName; // 0x10
        public System.Guid DocumentType_Text;
        public object field_2; // 0x257
        public object field_3; // 0x258

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871448A0 | overloaded x2
        public void get_FileName(){} // RVA: 0x7FFE81116380
        public void get_Language(){} // RVA: 0x7FFE87144740
        public void get_LanguageVendor(){} // RVA: 0x7FFE87144790
        public void get_DocumentType(){} // RVA: 0x7FFE871447E0
        public void .cctor(){} // RVA: 0x7FFE87144840
    }

    public class SymbolDocumentWithGuids : SymbolDocumentInfo
    {
        public System.Guid _language; // 0x18
        public System.Guid _languageVendor; // 0x28
        public System.Guid _documentType; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87144A00 | overloaded x3
        public void get_Language(){} // RVA: 0x7FFE81703940
        public void get_LanguageVendor(){} // RVA: 0x7FFE81E90600
        public void get_DocumentType(){} // RVA: 0x7FFE826F9FB0
    }

}