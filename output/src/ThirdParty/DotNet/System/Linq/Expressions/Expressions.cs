// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 17
// Methods: 659

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class ArrayBuilderExtensions : Object
    {
        // ── Methods ──
        public void ToReadOnly(){} // RVA: 0x7FFD4E2ADC40
    }

    public class DebugViewWriter : ExpressionVisitor
    {
        public int Base;
        public int Delta;
        public System.IO.TextWriter Depth; // 0x10
        public int _column; // 0x18
        public System.Collections.Generic.Stack`1<int> _stack; // 0x20
        public int _delta; // 0x28
        public 0x6654BE08 _flow; // 0x2C
        public System.Collections.Generic.Queue`1<System.Linq.Expressions.LambdaExpression> _lambdas; // 0x30
        public System.Collections.Generic.Dictionary`2<System.Linq.Expressions.LambdaExpression,int> _lambdaIds; // 0x38
        public System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,int> _paramIds; // 0x40
        public System.Collections.Generic.Dictionary`2<0x6654CA68,int> _labelIds; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54197140
        public void get_Base(){} // RVA: 0x7FFD54197260
        public void get_Delta(){} // RVA: 0x7FFD4E70C4C0
        public void get_Depth(){} // RVA: 0x7FFD541972D0
        public void Indent(){} // RVA: 0x7FFD54197350
        public void Dedent(){} // RVA: 0x7FFD54197360
        public void NewLine(){} // RVA: 0x7FFD54197370
        public void GetId(){} // RVA: 0x7FFD4E2ADC40
        public void GetLambdaId(){} // RVA: 0x7FFD54197380
        public void GetParamId(){} // RVA: 0x7FFD541973D0
        public void GetLabelTargetId(){} // RVA: 0x7FFD54197420
        public void WriteTo(){} // RVA: 0x7FFD54197700 | overloaded x2
        public void Out(){} // RVA: 0x7FFD541978C0 | overloaded x4
        public void WriteLine(){} // RVA: 0x7FFD54197A90
        public void Write(){} // RVA: 0x7FFD54197AD0
        public void GetFlow(){} // RVA: 0x7FFD54197B20
        public void CheckBreak(){} // RVA: 0x7FFD54197BE0
        public void VisitExpressions(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void VisitDeclarations(){} // RVA: 0x7FFD54197C20
        public void VisitBinary(){} // RVA: 0x7FFD54197CE0
        public void VisitParameter(){} // RVA: 0x7FFD541984B0
        public void VisitLambda(){} // RVA: 0x7FFD4E078F40
        public void IsSimpleExpression(){} // RVA: 0x7FFD54198640
        public void VisitConditional(){} // RVA: 0x7FFD54198750
        public void VisitConstant(){} // RVA: 0x7FFD54198A00
        public void GetConstantValueSuffix(){} // RVA: 0x7FFD54198E40
        public void VisitRuntimeVariables(){} // RVA: 0x7FFD54199130
        public void OutMember(){} // RVA: 0x7FFD54199200
        public void VisitMember(){} // RVA: 0x7FFD54199330
        public void VisitInvocation(){} // RVA: 0x7FFD54199480
        public void NeedsParentheses(){} // RVA: 0x7FFD54199530
        public void GetOperatorPrecedence(){} // RVA: 0x7FFD54199700
        public void ParenthesizedVisit(){} // RVA: 0x7FFD54199880
        public void VisitMethodCall(){} // RVA: 0x7FFD54199960
        public void VisitNewArray(){} // RVA: 0x7FFD54199B90
        public void VisitNew(){} // RVA: 0x7FFD54199CF0
        public void VisitElementInit(){} // RVA: 0x7FFD54199E00
        public void VisitListInit(){} // RVA: 0x7FFD54199F60
        public void VisitMemberAssignment(){} // RVA: 0x7FFD5419A050
        public void VisitMemberListBinding(){} // RVA: 0x7FFD5419A110
        public void VisitMemberMemberBinding(){} // RVA: 0x7FFD5419A250
        public void VisitMemberInit(){} // RVA: 0x7FFD5419A390
        public void VisitTypeBinary(){} // RVA: 0x7FFD5419A480
        public void VisitUnary(){} // RVA: 0x7FFD5419A570
        public void VisitBlock(){} // RVA: 0x7FFD5419AAB0
        public void VisitDefault(){} // RVA: 0x7FFD5419AD90
        public void VisitLabel(){} // RVA: 0x7FFD5419AE50
        public void VisitGoto(){} // RVA: 0x7FFD5419AF00
        public void VisitLoop(){} // RVA: 0x7FFD5419B060
        public void VisitSwitchCase(){} // RVA: 0x7FFD5419B1B0
        public void VisitSwitch(){} // RVA: 0x7FFD5419B470
        public void VisitCatchBlock(){} // RVA: 0x7FFD5419B650
        public void VisitTry(){} // RVA: 0x7FFD5419B7E0
        public void VisitIndex(){} // RVA: 0x7FFD5419B9B0
        public void VisitExtension(){} // RVA: 0x7FFD5419BB70
        public void VisitDebugInfo(){} // RVA: 0x7FFD5419BD80
        public void DumpLabel(){} // RVA: 0x7FFD5419C110
        public void GetLabelTargetName(){} // RVA: 0x7FFD5419C250
        public void WriteLambda(){} // RVA: 0x7FFD5419C390
        public void GetLambdaName(){} // RVA: 0x7FFD5419C5C0
        public void ContainsWhiteSpace(){} // RVA: 0x7FFD5419C730
        public void QuoteName(){} // RVA: 0x7FFD5419C7E0
        public void GetDisplayName(){} // RVA: 0x7FFD5419C8E0
        public void <VisitExpressions>b__37_0(){} // RVA: 0x7FFD4E2ADC40
        public void <VisitDeclarations>b__38_0(){} // RVA: 0x7FFD5419CA80
        public void <VisitListInit>b__58_0(){} // RVA: 0x7FFD5419CBA0
        public void <VisitMemberListBinding>b__60_0(){} // RVA: 0x7FFD5419CBA0
        public void <VisitMemberMemberBinding>b__61_0(){} // RVA: 0x7FFD5419CBC0
        public void <VisitMemberInit>b__62_0(){} // RVA: 0x7FFD5419CBC0
    }

    public class Expression : Object
    {
        public System.Dynamic.Utils.CacheDict`2<System.Type,System.Reflection.MethodInfo> NodeType;
        public System.Dynamic.Utils.CacheDict`2<System.Type,System.Func`5<System.Linq.Expressions.Expression,string,bool,System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>,System.Linq.Expressions.LambdaExpression>> Type; // 0x8
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Linq.Expressions.Expression,0x6654B468> CanReduce; // 0x10

        // ── Methods ──
        public void Assign(){} // RVA: 0x7FFD54167C10
        public void GetUserDefinedBinaryOperator(){} // RVA: 0x7FFD54169130 | overloaded x2
        public void GetMethodBasedBinaryOperator(){} // RVA: 0x7FFD54168280
        public void GetMethodBasedAssignOperator(){} // RVA: 0x7FFD54168920
        public void GetUserDefinedBinaryOperatorOrThrow(){} // RVA: 0x7FFD54168BF0
        public void GetUserDefinedAssignOperatorOrThrow(){} // RVA: 0x7FFD54168E60
        public void IsLiftingConditionalLogicalOperator(){} // RVA: 0x7FFD54169510
        public void ParameterIsAssignable(){} // RVA: 0x7FFD541695D0
        public void ValidateParamswithOperandsOrThrow(){} // RVA: 0x7FFD54169690
        public void ValidateOperator(){} // RVA: 0x7FFD54169780
        public void ValidateMethodInfo(){} // RVA: 0x7FFD54169960
        public void IsNullComparison(){} // RVA: 0x7FFD541699F0
        public void IsNullConstant(){} // RVA: 0x7FFD54169C70
        public void ValidateUserDefinedConditionalLogicOperator(){} // RVA: 0x7FFD54169D00
        public void VerifyOpTrueFalse(){} // RVA: 0x7FFD5416A4B0
        public void IsValidLiftedConditionalLogicalOperator(){} // RVA: 0x7FFD5416A6A0
        public void MakeBinary(){} // RVA: 0x7FFD5416A970 | overloaded x3
        public void Equal(){} // RVA: 0x7FFD5416B340 | overloaded x2
        public void ReferenceEqual(){} // RVA: 0x7FFD5416B470
        public void NotEqual(){} // RVA: 0x7FFD5416B690 | overloaded x2
        public void ReferenceNotEqual(){} // RVA: 0x7FFD5416B7C0
        public void GetEqualityComparisonOperator(){} // RVA: 0x7FFD5416B970
        public void GreaterThan(){} // RVA: 0x7FFD5416BE70 | overloaded x2
        public void LessThan(){} // RVA: 0x7FFD5416C010 | overloaded x2
        public void GreaterThanOrEqual(){} // RVA: 0x7FFD5416C1B0 | overloaded x2
        public void LessThanOrEqual(){} // RVA: 0x7FFD5416C350 | overloaded x2
        public void GetComparisonOperator(){} // RVA: 0x7FFD5416C480
        public void AndAlso(){} // RVA: 0x7FFD5416C750 | overloaded x2
        public void OrElse(){} // RVA: 0x7FFD5416CEE0 | overloaded x2
        public void Coalesce(){} // RVA: 0x7FFD5416D630 | overloaded x2
        public void ValidateCoalesceArgTypes(){} // RVA: 0x7FFD5416DBD0
        public void Add(){} // RVA: 0x7FFD5416DE80 | overloaded x2
        public void AddAssign(){} // RVA: 0x7FFD5416E1D0 | overloaded x3
        public void ValidateOpAssignConversionLambda(){} // RVA: 0x7FFD5416E4A0
        public void AddAssignChecked(){} // RVA: 0x7FFD5416E940 | overloaded x3
        public void AddChecked(){} // RVA: 0x7FFD5416EC80 | overloaded x2
        public void Subtract(){} // RVA: 0x7FFD5416EF60 | overloaded x2
        public void SubtractAssign(){} // RVA: 0x7FFD5416F2C0 | overloaded x3
        public void SubtractAssignChecked(){} // RVA: 0x7FFD5416F6C0 | overloaded x3
        public void SubtractChecked(){} // RVA: 0x7FFD5416FA00 | overloaded x2
        public void Divide(){} // RVA: 0x7FFD5416FCE0 | overloaded x2
        public void DivideAssign(){} // RVA: 0x7FFD54170040 | overloaded x3
        public void Modulo(){} // RVA: 0x7FFD54170380 | overloaded x2
        public void ModuloAssign(){} // RVA: 0x7FFD541706E0 | overloaded x3
        public void Multiply(){} // RVA: 0x7FFD54170A20 | overloaded x2
        public void MultiplyAssign(){} // RVA: 0x7FFD54170D80 | overloaded x3
        public void MultiplyAssignChecked(){} // RVA: 0x7FFD54171180 | overloaded x3
        public void MultiplyChecked(){} // RVA: 0x7FFD541714C0 | overloaded x2
        public void IsSimpleShift(){} // RVA: 0x7FFD54171730
        public void GetResultTypeOfShift(){} // RVA: 0x7FFD54171810
        public void LeftShift(){} // RVA: 0x7FFD54171A00 | overloaded x2
        public void LeftShiftAssign(){} // RVA: 0x7FFD54171D50 | overloaded x3
        public void RightShift(){} // RVA: 0x7FFD54172070 | overloaded x2
        public void RightShiftAssign(){} // RVA: 0x7FFD541723C0 | overloaded x3
        public void And(){} // RVA: 0x7FFD541726E0 | overloaded x2
        public void AndAssign(){} // RVA: 0x7FFD54172A40 | overloaded x3
        public void Or(){} // RVA: 0x7FFD54172D80 | overloaded x2
        public void OrAssign(){} // RVA: 0x7FFD541730E0 | overloaded x3
        public void ExclusiveOr(){} // RVA: 0x7FFD54173420 | overloaded x2
        public void ExclusiveOrAssign(){} // RVA: 0x7FFD54173780 | overloaded x3
        public void Power(){} // RVA: 0x7FFD54173AC0 | overloaded x2
        public void PowerAssign(){} // RVA: 0x7FFD54173FD0 | overloaded x3
        public void ArrayIndex(){} // RVA: 0x7FFD541874E0 | overloaded x3
        public void Block(){} // RVA: 0x7FFD54174E40 | overloaded x12
        public void BlockCore(){} // RVA: 0x7FFD54175160
        public void ValidateVariables(){} // RVA: 0x7FFD541755D0
        public void GetOptimizedBlockExpression(){} // RVA: 0x7FFD54175870
        public void Catch(){} // RVA: 0x7FFD54175F40 | overloaded x4
        public void MakeCatchBlock(){} // RVA: 0x7FFD54176040
        public void Condition(){} // RVA: 0x7FFD541767A0 | overloaded x2
        public void IfThen(){} // RVA: 0x7FFD54176AE0
        public void IfThenElse(){} // RVA: 0x7FFD54176C00
        public void Constant(){} // RVA: 0x7FFD54176D80 | overloaded x2
        public void DebugInfo(){} // RVA: 0x7FFD54177000
        public void ClearDebugInfo(){} // RVA: 0x7FFD54177180
        public void ValidateSpan(){} // RVA: 0x7FFD54177240
        public void Empty(){} // RVA: 0x7FFD54177430
        public void Default(){} // RVA: 0x7FFD54177520
        public void ElementInit(){} // RVA: 0x7FFD54177680 | overloaded x2
        public void ValidateElementInitAddMethodInfo(){} // RVA: 0x7FFD541778E0
        public void .ctor(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFD54177E60
        public void get_Type(){} // RVA: 0x7FFD54177F60
        public void get_CanReduce(){} // RVA: 0x7FFD4E341320
        public void Reduce(){} // RVA: 0x7FFD54178060
        public void VisitChildren(){} // RVA: 0x7FFD541780B0
        public void Accept(){} // RVA: 0x7FFD54178140
        public void ReduceAndCheck(){} // RVA: 0x7FFD54178170
        public void ReduceExtensions(){} // RVA: 0x7FFD541782D0
        public void ToString(){} // RVA: 0x7FFD54178330
        public void get_DebugView(){} // RVA: 0x7FFD541783C0
        public void RequiresCanRead(){} // RVA: 0x7FFD54178550
        public void RequiresCanWrite(){} // RVA: 0x7FFD54178680
        public void Dynamic(){} // RVA: 0x7FFD54178910 | overloaded x6
        public void MakeDynamic(){} // RVA: 0x7FFD541789B0 | overloaded x6
        public void Break(){} // RVA: 0x7FFD54178CA0 | overloaded x4
        public void Continue(){} // RVA: 0x7FFD54178E20 | overloaded x2
        public void Return(){} // RVA: 0x7FFD54179110 | overloaded x4
        public void Goto(){} // RVA: 0x7FFD54179410 | overloaded x4
        public void MakeGoto(){} // RVA: 0x7FFD54179490
        public void ValidateGoto(){} // RVA: 0x7FFD541796A0
        public void ValidateGotoType(){} // RVA: 0x7FFD54179860
        public void MakeIndex(){} // RVA: 0x7FFD54179A20
        public void ArrayAccess(){} // RVA: 0x7FFD54179B20 | overloaded x2
        public void Property(){} // RVA: 0x7FFD54181E30 | overloaded x7
        public void FindInstanceProperty(){} // RVA: 0x7FFD5417A1E0
        public void GetArgTypesString(){} // RVA: 0x7FFD5417A330
        public void FindProperty(){} // RVA: 0x7FFD5417A4F0
        public void IsCompatible(){} // RVA: 0x7FFD54187110 | overloaded x2
        public void MakeIndexProperty(){} // RVA: 0x7FFD5417AA30
        public void ValidateIndexedProperty(){} // RVA: 0x7FFD5417AB00
        public void ValidateAccessor(){} // RVA: 0x7FFD5417B190
        public void ValidateAccessorArgumentTypes(){} // RVA: 0x7FFD5417B460
        public void Invoke(){} // RVA: 0x7FFD5417CCA0 | overloaded x8
        public void GetInvokeMethod(){} // RVA: 0x7FFD5417D150
        public void Label(){} // RVA: 0x7FFD5417D7F0 | overloaded x6
        public void CreateLambda(){} // RVA: 0x7FFD5417D990
        public void Lambda(){} // RVA: 0x7FFD5417EA40 | overloaded x18
        public void ValidateLambdaArgs(){} // RVA: 0x7FFD5417EB30
        public void ValidateTryGetFuncActionArgs(){} // RVA: 0x7FFD5417F410
        public void GetFuncType(){} // RVA: 0x7FFD5417F540
        public void TryGetFuncType(){} // RVA: 0x7FFD5417F6B0
        public void GetActionType(){} // RVA: 0x7FFD5417F820
        public void TryGetActionType(){} // RVA: 0x7FFD5417F990
        public void GetDelegateType(){} // RVA: 0x7FFD5417FB00
        public void ListInit(){} // RVA: 0x7FFD541805E0 | overloaded x6
        public void Loop(){} // RVA: 0x7FFD54180880 | overloaded x3
        public void Bind(){} // RVA: 0x7FFD54180D20 | overloaded x2
        public void ValidateSettableFieldOrPropertyMember(){} // RVA: 0x7FFD54180ED0
        public void Field(){} // RVA: 0x7FFD54181510 | overloaded x3
        public void GetProperty(){} // RVA: 0x7FFD54181F80
        public void CheckMethod(){} // RVA: 0x7FFD541821E0
        public void PropertyOrField(){} // RVA: 0x7FFD541823C0
        public void MakeMemberAccess(){} // RVA: 0x7FFD54182690
        public void MemberInit(){} // RVA: 0x7FFD541828A0 | overloaded x2
        public void ListBind(){} // RVA: 0x7FFD54182F30 | overloaded x4
        public void ValidateListInitArgs(){} // RVA: 0x7FFD54183080
        public void MemberBind(){} // RVA: 0x7FFD541836E0 | overloaded x4
        public void ValidateGettableFieldOrPropertyMember(){} // RVA: 0x7FFD541837C0
        public void ValidateMemberInitArgs(){} // RVA: 0x7FFD54183A20
        public void Call(){} // RVA: 0x7FFD54186300 | overloaded x16
        public void ValidateMethodAndGetParameters(){} // RVA: 0x7FFD54186910
        public void ValidateStaticOrInstanceMethod(){} // RVA: 0x7FFD54186B50
        public void ValidateCallInstanceType(){} // RVA: 0x7FFD54186C70
        public void ValidateArgumentTypes(){} // RVA: 0x7FFD54186D20
        public void GetParametersForValidation(){} // RVA: 0x7FFD54186D30
        public void ValidateArgumentCount(){} // RVA: 0x7FFD54186D40
        public void ValidateOneArgument(){} // RVA: 0x7FFD54186D50
        public void TryQuote(){} // RVA: 0x7FFD54186D90
        public void FindMethod(){} // RVA: 0x7FFD54186DA0
        public void ApplyTypeArgs(){} // RVA: 0x7FFD541873B0
        public void NewArrayInit(){} // RVA: 0x7FFD541879E0 | overloaded x2
        public void NewArrayBounds(){} // RVA: 0x7FFD54188000 | overloaded x2
        public void New(){} // RVA: 0x7FFD54188AE0 | overloaded x6
        public void ValidateNewArgs(){} // RVA: 0x7FFD54188F50
        public void ValidateAnonymousTypeMember(){} // RVA: 0x7FFD54189A50
        public void ValidateConstructor(){} // RVA: 0x7FFD54189E00
        public void Parameter(){} // RVA: 0x7FFD54189F20 | overloaded x2
        public void Variable(){} // RVA: 0x7FFD54189FE0 | overloaded x2
        public void Validate(){} // RVA: 0x7FFD5418A050
        public void RuntimeVariables(){} // RVA: 0x7FFD5418A240 | overloaded x2
        public void SwitchCase(){} // RVA: 0x7FFD5418A530 | overloaded x2
        public void Switch(){} // RVA: 0x7FFD5418AA30 | overloaded x6
        public void ValidateSwitchCaseType(){} // RVA: 0x7FFD5418B7C0
        public void SymbolDocument(){} // RVA: 0x7FFD5418BB90 | overloaded x4
        public void TryFault(){} // RVA: 0x7FFD5418BC60
        public void TryFinally(){} // RVA: 0x7FFD5418BCD0
        public void TryCatch(){} // RVA: 0x7FFD5418BD40
        public void TryCatchFinally(){} // RVA: 0x7FFD5418BDB0
        public void MakeTry(){} // RVA: 0x7FFD5418BE30
        public void ValidateTryAndCatchHaveSameType(){} // RVA: 0x7FFD5418C0B0
        public void TypeIs(){} // RVA: 0x7FFD5418C720
        public void TypeEqual(){} // RVA: 0x7FFD5418C880
        public void MakeUnary(){} // RVA: 0x7FFD5418CA60 | overloaded x2
        public void GetUserDefinedUnaryOperatorOrThrow(){} // RVA: 0x7FFD5418D150
        public void GetUserDefinedUnaryOperator(){} // RVA: 0x7FFD5418D2F0
        public void GetMethodBasedUnaryOperator(){} // RVA: 0x7FFD5418D690
        public void GetUserDefinedCoercionOrThrow(){} // RVA: 0x7FFD5418DAE0
        public void GetUserDefinedCoercion(){} // RVA: 0x7FFD5418DC50
        public void GetMethodBasedCoercionOperator(){} // RVA: 0x7FFD5418DD50
        public void Negate(){} // RVA: 0x7FFD5418E260 | overloaded x2
        public void UnaryPlus(){} // RVA: 0x7FFD5418E4B0 | overloaded x2
        public void NegateChecked(){} // RVA: 0x7FFD5418E6C0 | overloaded x2
        public void Not(){} // RVA: 0x7FFD5418E910 | overloaded x2
        public void IsFalse(){} // RVA: 0x7FFD5418EB60 | overloaded x2
        public void IsTrue(){} // RVA: 0x7FFD5418ED70 | overloaded x2
        public void OnesComplement(){} // RVA: 0x7FFD5418EF80 | overloaded x2
        public void TypeAs(){} // RVA: 0x7FFD5418F130
        public void Unbox(){} // RVA: 0x7FFD5418F2F0
        public void Convert(){} // RVA: 0x7FFD5418F5D0 | overloaded x2
        public void ConvertChecked(){} // RVA: 0x7FFD5418F890 | overloaded x2
        public void ArrayLength(){} // RVA: 0x7FFD5418FB10
        public void Quote(){} // RVA: 0x7FFD5418FD60
        public void Rethrow(){} // RVA: 0x7FFD541900D0 | overloaded x2
        public void Throw(){} // RVA: 0x7FFD54190310 | overloaded x2
        public void Increment(){} // RVA: 0x7FFD54190530 | overloaded x2
        public void Decrement(){} // RVA: 0x7FFD54190740 | overloaded x2
        public void PreIncrementAssign(){} // RVA: 0x7FFD54190950 | overloaded x2
        public void PreDecrementAssign(){} // RVA: 0x7FFD54190A20 | overloaded x2
        public void PostIncrementAssign(){} // RVA: 0x7FFD54190AF0 | overloaded x2
        public void PostDecrementAssign(){} // RVA: 0x7FFD54190BC0 | overloaded x2
        public void MakeOpAssignUnary(){} // RVA: 0x7FFD54190C30
        public void .cctor(){} // RVA: 0x7FFD54190EF0
    }

    public class Expression0`1 : Expression`1
    {
        public object ParameterCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_ParameterCount(){} // RVA: 0x7FFD4E079960
        public void SameParameters(){} // RVA: 0x7FFD4E079F60
        public void GetParameter(){} // RVA: 0x7FFD4E087DE0
        public void GetOrMakeParameters(){} // RVA: 0x7FFD4E078E90
        public void Rewrite(){} // RVA: 0x7FFD4E08A6F0
    }

    public class Expression1`1 : Expression`1
    {
        public object ParameterCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void get_ParameterCount(){} // RVA: 0x7FFD4E079960
        public void GetParameter(){} // RVA: 0x7FFD4E087DE0
        public void SameParameters(){} // RVA: 0x7FFD4E079F60
        public void GetOrMakeParameters(){} // RVA: 0x7FFD4E078E90
        public void Rewrite(){} // RVA: 0x7FFD4E08A6F0
    }

    public class Expression2`1 : Expression`1
    {
        public object ParameterCount;
        public System.Linq.Expressions.ParameterExpression _par1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09AF60
        public void get_ParameterCount(){} // RVA: 0x7FFD4E079960
        public void GetParameter(){} // RVA: 0x7FFD4E087DE0
        public void SameParameters(){} // RVA: 0x7FFD4E079F60
        public void GetOrMakeParameters(){} // RVA: 0x7FFD4E078E90
        public void Rewrite(){} // RVA: 0x7FFD4E08A6F0
    }

    public class Expression3`1 : Expression`1
    {
        public object ParameterCount;
        public System.Linq.Expressions.ParameterExpression _par1;
        public System.Linq.Expressions.ParameterExpression _par2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09B8C0
        public void get_ParameterCount(){} // RVA: 0x7FFD4E079960
        public void GetParameter(){} // RVA: 0x7FFD4E087DE0
        public void SameParameters(){} // RVA: 0x7FFD4E079F60
        public void GetOrMakeParameters(){} // RVA: 0x7FFD4E078E90
        public void Rewrite(){} // RVA: 0x7FFD4E08A6F0
    }

    public class ExpressionCreator`1 : Object
    {
        // ── Methods ──
        public void CreateExpressionFunc(){} // RVA: 0x7FFD4E08A960
    }

    public class ExpressionN`1 : Expression`1
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.ParameterExpression> ParameterCount; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void get_ParameterCount(){} // RVA: 0x7FFD4E079960
        public void GetParameter(){} // RVA: 0x7FFD4E087DE0
        public void SameParameters(){} // RVA: 0x7FFD4E079F60
        public void GetOrMakeParameters(){} // RVA: 0x7FFD4E078E90
        public void Rewrite(){} // RVA: 0x7FFD4E08A6F0
    }

    public class ExpressionStringBuilder : ExpressionVisitor
    {
        public System.Text.StringBuilder _out; // 0x10
        public System.Collections.Generic.Dictionary`2<object,int> _ids; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD541A9360
        public void ToString(){} // RVA: 0x7FFD4F108330
        public void GetLabelId(){} // RVA: 0x7FFD541A9400
        public void GetParamId(){} // RVA: 0x7FFD541A9400
        public void GetId(){} // RVA: 0x7FFD541A9410
        public void Out(){} // RVA: 0x7FFD541A95E0 | overloaded x2
        public void ExpressionToString(){} // RVA: 0x7FFD54178330
        public void CatchBlockToString(){} // RVA: 0x7FFD54196130
        public void SwitchCaseToString(){} // RVA: 0x7FFD541A9600
        public void MemberBindingToString(){} // RVA: 0x7FFD541A9690
        public void ElementInitBindingToString(){} // RVA: 0x7FFD541A1F60
        public void VisitExpressions(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void VisitBinary(){} // RVA: 0x7FFD541A9720
        public void VisitParameter(){} // RVA: 0x7FFD541A9FC0
        public void VisitLambda(){} // RVA: 0x7FFD4E078F40
        public void VisitListInit(){} // RVA: 0x7FFD541AA130
        public void VisitConditional(){} // RVA: 0x7FFD541AA300
        public void VisitConstant(){} // RVA: 0x7FFD541AA480
        public void VisitDebugInfo(){} // RVA: 0x7FFD541AA760
        public void VisitRuntimeVariables(){} // RVA: 0x7FFD541AAAE0
        public void OutMember(){} // RVA: 0x7FFD541AAB50
        public void VisitMember(){} // RVA: 0x7FFD541AAC70
        public void VisitMemberInit(){} // RVA: 0x7FFD541AADE0
        public void VisitMemberAssignment(){} // RVA: 0x7FFD541AB100
        public void VisitMemberListBinding(){} // RVA: 0x7FFD541AB1B0
        public void VisitMemberMemberBinding(){} // RVA: 0x7FFD541AB3A0
        public void VisitElementInit(){} // RVA: 0x7FFD541AB590
        public void VisitInvocation(){} // RVA: 0x7FFD541AB7C0
        public void VisitMethodCall(){} // RVA: 0x7FFD541AB950
        public void VisitNewArray(){} // RVA: 0x7FFD541ABC90
        public void VisitNew(){} // RVA: 0x7FFD541ABDE0
        public void VisitTypeBinary(){} // RVA: 0x7FFD541AC0A0
        public void VisitUnary(){} // RVA: 0x7FFD541AC270
        public void VisitBlock(){} // RVA: 0x7FFD541AC9D0
        public void VisitDefault(){} // RVA: 0x7FFD541ACD50
        public void VisitLabel(){} // RVA: 0x7FFD541ACE70
        public void VisitGoto(){} // RVA: 0x7FFD541ACF50
        public void VisitLoop(){} // RVA: 0x7FFD541AD150
        public void VisitSwitchCase(){} // RVA: 0x7FFD541AD1B0
        public void VisitSwitch(){} // RVA: 0x7FFD541AD270
        public void VisitCatchBlock(){} // RVA: 0x7FFD541AD380
        public void VisitTry(){} // RVA: 0x7FFD541AD4F0
        public void VisitIndex(){} // RVA: 0x7FFD541AD550
        public void VisitExtension(){} // RVA: 0x7FFD541AD820
        public void DumpLabel(){} // RVA: 0x7FFD541ADB70
        public void IsBool(){} // RVA: 0x7FFD541ADCA0
    }

    public class ExpressionVisitor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Visit(){} // RVA: 0x7FFD4E078FF0 | overloaded x3
        public void VisitArguments(){} // RVA: 0x7FFD541AE180
        public void VisitParameters(){} // RVA: 0x7FFD541AE190
        public void VisitAndConvert(){} // RVA: 0x7FFD4E08A6F0 | overloaded x2
        public void VisitBinary(){} // RVA: 0x7FFD541AE1A0
        public void VisitBlock(){} // RVA: 0x7FFD541AE2B0
        public void VisitConditional(){} // RVA: 0x7FFD541AE3B0
        public void VisitConstant(){} // RVA: 0x7FFD4F2B2FB0
        public void VisitDebugInfo(){} // RVA: 0x7FFD4F2B2FB0
        public void VisitDefault(){} // RVA: 0x7FFD4F2B2FB0
        public void VisitExtension(){} // RVA: 0x7FFD54196D60
        public void VisitGoto(){} // RVA: 0x7FFD541AE500
        public void VisitInvocation(){} // RVA: 0x7FFD541AE600
        public void VisitLabelTarget(){} // RVA: 0x7FFD4F2B2FB0
        public void VisitLabel(){} // RVA: 0x7FFD541AE6A0
        public void VisitLambda(){} // RVA: 0x7FFD4E078F40
        public void VisitLoop(){} // RVA: 0x7FFD541AE770
        public void VisitMember(){} // RVA: 0x7FFD541AE870
        public void VisitIndex(){} // RVA: 0x7FFD541AE920
        public void VisitMethodCall(){} // RVA: 0x7FFD541AEA70
        public void VisitNewArray(){} // RVA: 0x7FFD541AEB40
        public void VisitNew(){} // RVA: 0x7FFD541AEB80
        public void VisitParameter(){} // RVA: 0x7FFD4F2B2FB0
        public void VisitRuntimeVariables(){} // RVA: 0x7FFD541AECB0
        public void VisitSwitchCase(){} // RVA: 0x7FFD541AEDB0
        public void VisitSwitch(){} // RVA: 0x7FFD541AEEB0
        public void VisitCatchBlock(){} // RVA: 0x7FFD541AF0E0
        public void VisitTry(){} // RVA: 0x7FFD541AF230
        public void VisitTypeBinary(){} // RVA: 0x7FFD541AF410
        public void VisitUnary(){} // RVA: 0x7FFD541AF4F0
        public void VisitMemberInit(){} // RVA: 0x7FFD541AF6D0
        public void VisitListInit(){} // RVA: 0x7FFD541AF870
        public void VisitElementInit(){} // RVA: 0x7FFD541AFA10
        public void VisitMemberBinding(){} // RVA: 0x7FFD541AFAA0
        public void VisitMemberAssignment(){} // RVA: 0x7FFD541AFC40
        public void VisitMemberMemberBinding(){} // RVA: 0x7FFD541AFCE0
        public void VisitMemberListBinding(){} // RVA: 0x7FFD541AFE30
        public void ValidateUnary(){} // RVA: 0x7FFD541AFF80
        public void ValidateBinary(){} // RVA: 0x7FFD541B0090
        public void ValidateSwitch(){} // RVA: 0x7FFD541B0230
        public void ValidateChildType(){} // RVA: 0x7FFD541B02B0
        public void VisitDynamic(){} // RVA: 0x7FFD541A1E00
    }

    public class Expression`1 : LambdaExpression
    {
        public System.Collections.Immutable.SecureObjectPool`2<System.Collections.Generic.Stack`1<System.Collections.Immutable.RefAsValueType`1<Node<T>>>,Enumerator<T>> TypeCore;
        public Builder<T> PublicType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void get_TypeCore(){} // RVA: 0x7FFD4E078E90
        public void get_PublicType(){} // RVA: 0x7FFD4E078E90
        public void Compile(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void Update(){} // RVA: 0x7FFD4E08A6F0
        public void SameParameters(){} // RVA: 0x7FFD4E079F60
        public void Rewrite(){} // RVA: 0x7FFD4E08A6F0
        public void Accept(){} // RVA: 0x7FFD4E078F40
    }

    public class FullExpression`1 : ExpressionN`1
    {
        public string NameCore;
        public bool TailCallCore;

        // ── Methods ──
        public void .ctor(){}
        public void get_NameCore(){} // RVA: 0x7FFD4E078E90
        public void get_TailCallCore(){} // RVA: 0x7FFD4E079D00
    }

    public class LambdaExpression : Expression
    {
        public System.Linq.Expressions.Expression Type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD541B2720 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFD4EC45740
        public void get_TypeCore(){} // RVA: 0x7FFD4E078E90
        public void get_PublicType(){} // RVA: 0x7FFD4E078E90
        public void get_NodeType(){} // RVA: 0x7FFD4F55E570
        public void get_Parameters(){} // RVA: 0x7FFD4F6F3560
        public void get_Name(){} // RVA: 0x7FFD53F0C8C0
        public void get_NameCore(){} // RVA: 0x7FFD4E919180
        public void get_Body(){} // RVA: 0x7FFD4E35C380
        public void get_ReturnType(){} // RVA: 0x7FFD541B2550
        public void get_TailCall(){} // RVA: 0x7FFD4EB28F90
        public void get_TailCallCore(){} // RVA: 0x7FFD4E341320
        public void GetOrMakeParameters(){} // RVA: 0x7FFD541B25E0
        public void System.Linq.Expressions.IParameterProvider.GetParameter(){} // RVA: 0x7FFD53BFD120
        public void GetParameter(){} // RVA: 0x7FFD541B2610
        public void System.Linq.Expressions.IParameterProvider.get_ParameterCount(){} // RVA: 0x7FFD541B2640
        public void get_ParameterCount(){} // RVA: 0x7FFD541B2660
        public void Compile(){} // RVA: 0x7FFD541B2710 | overloaded x3
        public void CompileToMethod(){} // RVA: 0x7FFD541B2780 | overloaded x2
    }

    public class ParameterExpression : Expression
    {
        public string Type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD541B86F0 | overloaded x2
        public void Make(){} // RVA: 0x7FFD541B80A0
        public void get_Type(){} // RVA: 0x7FFD541B8600
        public void get_NodeType(){} // RVA: 0x7FFD541B86B0
        public void get_Name(){} // RVA: 0x7FFD4E35C380
        public void get_IsByRef(){} // RVA: 0x7FFD4F37BE50
        public void GetIsByRef(){} // RVA: 0x7FFD4E341320
        public void Accept(){} // RVA: 0x7FFD541B86C0
    }

    public class PrimitiveParameterExpression`1 : ParameterExpression
    {
        public <>c<T> Type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_Type(){} // RVA: 0x7FFD4E078E90
    }

    public class StackGuard : Object
    {
        public int MaxExecutionStackCount;
        public int _executionStackCount; // 0x10

        // ── Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0x7FFD4E426850
        public void RunOnEmptyStack(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void RunOnEmptyStackCore(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}