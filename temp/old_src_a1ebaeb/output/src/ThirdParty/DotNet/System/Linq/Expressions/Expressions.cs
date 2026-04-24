// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 24
// Methods: 731

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class ArrayBuilderExtensions : Object
    {
        // ── Original Methods ──
        public void ToReadOnly(){} // RVA: 0x7ffaa887e5c0
    }

    public class DebugViewWriter : ExpressionVisitor
    {
        public object _out; // 0x31738F60
        public object _delta; // 0x31738F60
        public object _lambdaIds; // 0x31738F60

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae7990a0
        public void get_Base(){} // RVA: 0x7ffaae7991c0
        public void get_Delta(){} // RVA: 0x7ffaa8d14570
        public void get_Depth(){} // RVA: 0x7ffaae799230
        public void Indent(){} // RVA: 0x7ffaae7992b0
        public void Dedent(){} // RVA: 0x7ffaae7992c0
        public void NewLine(){} // RVA: 0x7ffaae7992d0
        public void WriteTo(){} // RVA: 0x7ffaae799660
        public void WriteTo(){} // RVA: 0x7ffaae799660
        public void Out(){} // RVA: 0x7ffaae799820
        public void Out(){} // RVA: 0x7ffaae799820
        public void Out(){} // RVA: 0x7ffaae799820
        public void Out(){} // RVA: 0x7ffaae799820
        public void WriteLine(){} // RVA: 0x7ffaae7999f0
        public void Write(){} // RVA: 0x7ffaae799a30
        public void VisitExpressions(){} // RVA: 0x7ffaa887e5c0
        public void VisitExpressions(){} // RVA: 0x7ffaa887e5c0
        public void VisitDeclarations(){} // RVA: 0x7ffaae799b80
        public void VisitExpressions(){} // RVA: 0x7ffaa887e5c0
        public void VisitBinary(){} // RVA: 0x7ffaae799c40
        public void VisitParameter(){} // RVA: 0x7ffaae79a410
        public void VisitLambda(){} // RVA: 0x7ffaa8649280
        public void IsSimpleExpression(){} // RVA: 0x7ffaae79a5a0
        public void VisitConditional(){} // RVA: 0x7ffaae79a6b0
        public void VisitConstant(){} // RVA: 0x7ffaae79a960
        public void VisitRuntimeVariables(){} // RVA: 0x7ffaae79b090
        public void OutMember(){} // RVA: 0x7ffaae79b160
        public void VisitMember(){} // RVA: 0x7ffaae79b290
        public void VisitInvocation(){} // RVA: 0x7ffaae79b3e0
        public void NeedsParentheses(){} // RVA: 0x7ffaae79b490
        public void ParenthesizedVisit(){} // RVA: 0x7ffaae79b7e0
        public void VisitMethodCall(){} // RVA: 0x7ffaae79b8c0
        public void VisitNewArray(){} // RVA: 0x7ffaae79baf0
        public void VisitNew(){} // RVA: 0x7ffaae79bc50
        public void VisitElementInit(){} // RVA: 0x7ffaae79bd60
        public void VisitListInit(){} // RVA: 0x7ffaae79bec0
        public void VisitMemberAssignment(){} // RVA: 0x7ffaae79bfb0
        public void VisitMemberListBinding(){} // RVA: 0x7ffaae79c070
        public void VisitMemberMemberBinding(){} // RVA: 0x7ffaae79c1b0
        public void VisitMemberInit(){} // RVA: 0x7ffaae79c2f0
        public void VisitTypeBinary(){} // RVA: 0x7ffaae79c3e0
        public void VisitUnary(){} // RVA: 0x7ffaae79c4d0
        public void VisitBlock(){} // RVA: 0x7ffaae79ca10
        public void VisitDefault(){} // RVA: 0x7ffaae79ccf0
        public void VisitLabel(){} // RVA: 0x7ffaae79cdb0
        public void VisitGoto(){} // RVA: 0x7ffaae79ce60
        public void VisitLoop(){} // RVA: 0x7ffaae79cfc0
        public void VisitSwitchCase(){} // RVA: 0x7ffaae79d110
        public void VisitSwitch(){} // RVA: 0x7ffaae79d3d0
        public void VisitCatchBlock(){} // RVA: 0x7ffaae79d5b0
        public void VisitTry(){} // RVA: 0x7ffaae79d740
        public void VisitIndex(){} // RVA: 0x7ffaae79d910
        public void VisitExtension(){} // RVA: 0x7ffaae79dad0
        public void VisitDebugInfo(){} // RVA: 0x7ffaae79dce0
        public void DumpLabel(){} // RVA: 0x7ffaae79e070
        public void WriteLambda(){} // RVA: 0x7ffaae79e2f0
        public void ContainsWhiteSpace(){} // RVA: 0x7ffaae79e690
        public void QuoteName(){} // RVA: 0x7ffaae79e740
        public void <VisitExpressions>b__37_0(){} // RVA: 0x7ffaa887e5c0
        public void <VisitDeclarations>b__38_0(){} // RVA: 0x7ffaae79e9e0
        public void <VisitListInit>b__58_0(){} // RVA: 0x7ffaae79eb00
        public void <VisitMemberListBinding>b__60_0(){} // RVA: 0x7ffaae79eb00
        public void <VisitMemberMemberBinding>b__61_0(){} // RVA: 0x7ffaae79eb20
        public void <VisitMemberInit>b__62_0(){} // RVA: 0x7ffaae79eb20
        // ── Binary Analysis Named ──
        public void GetId(){} // RVA: 0x7ffaa887e5c0
        public void GetLambdaId(){} // RVA: 0x7ffaae7992e0
        public void GetParamId(){} // RVA: 0x7ffaae799330
        public void GetLabelTargetId(){} // RVA: 0x7ffaae799380
        public void GetFlow(){} // RVA: 0x7ffaae799a80
        public void CheckBreak(){} // RVA: 0x7ffaae799b40
        public void GetConstantValueSuffix(){} // RVA: 0x7ffaae79ada0
        public void GetOperatorPrecedence(){} // RVA: 0x7ffaae79b660
        public void GetLabelTargetName(){} // RVA: 0x7ffaae79e1b0
        public void GetLambdaName(){} // RVA: 0x7ffaae79e520
        public void GetDisplayName(){} // RVA: 0x7ffaae79e840
    }

    public class Expression : Object
    {
        public object s_legacyCtorSupportTable; // 0x30F9E730
        public object NodeType; // 0x1700008E

        // ── Original Methods ──
        public void Assign(){} // RVA: 0x7ffaae769b70
        public void IsLiftingConditionalLogicalOperator(){} // RVA: 0x7ffaae76b470
        public void ParameterIsAssignable(){} // RVA: 0x7ffaae76b530
        public void ValidateParamswithOperandsOrThrow(){} // RVA: 0x7ffaae76b5f0
        public void ValidateOperator(){} // RVA: 0x7ffaae76b6e0
        public void ValidateMethodInfo(){} // RVA: 0x7ffaae76b8c0
        public void IsNullComparison(){} // RVA: 0x7ffaae76b950
        public void IsNullConstant(){} // RVA: 0x7ffaae76bbd0
        public void ValidateUserDefinedConditionalLogicOperator(){} // RVA: 0x7ffaae76bc60
        public void VerifyOpTrueFalse(){} // RVA: 0x7ffaae76c410
        public void IsValidLiftedConditionalLogicalOperator(){} // RVA: 0x7ffaae76c600
        public void MakeBinary(){} // RVA: 0x7ffaae76c8d0
        public void MakeBinary(){} // RVA: 0x7ffaae76c8d0
        public void MakeBinary(){} // RVA: 0x7ffaae76c8d0
        public void Equal(){} // RVA: 0x7ffaae76d2a0
        public void Equal(){} // RVA: 0x7ffaae76d2a0
        public void ReferenceEqual(){} // RVA: 0x7ffaae76d3d0
        public void NotEqual(){} // RVA: 0x7ffaae76d5f0
        public void NotEqual(){} // RVA: 0x7ffaae76d5f0
        public void ReferenceNotEqual(){} // RVA: 0x7ffaae76d720
        public void GreaterThan(){} // RVA: 0x7ffaae76ddd0
        public void GreaterThan(){} // RVA: 0x7ffaae76ddd0
        public void LessThan(){} // RVA: 0x7ffaae76df70
        public void LessThan(){} // RVA: 0x7ffaae76df70
        public void GreaterThanOrEqual(){} // RVA: 0x7ffaae76e110
        public void GreaterThanOrEqual(){} // RVA: 0x7ffaae76e110
        public void LessThanOrEqual(){} // RVA: 0x7ffaae76e2b0
        public void LessThanOrEqual(){} // RVA: 0x7ffaae76e2b0
        public void AndAlso(){} // RVA: 0x7ffaae76e6b0
        public void AndAlso(){} // RVA: 0x7ffaae76e6b0
        public void OrElse(){} // RVA: 0x7ffaae76ee40
        public void OrElse(){} // RVA: 0x7ffaae76ee40
        public void Coalesce(){} // RVA: 0x7ffaae76f590
        public void Coalesce(){} // RVA: 0x7ffaae76f590
        public void ValidateCoalesceArgTypes(){} // RVA: 0x7ffaae76fb30
        public void Add(){} // RVA: 0x7ffaae76fde0
        public void Add(){} // RVA: 0x7ffaae76fde0
        public void AddAssign(){} // RVA: 0x7ffaae770130
        public void AddAssign(){} // RVA: 0x7ffaae770130
        public void AddAssign(){} // RVA: 0x7ffaae770130
        public void ValidateOpAssignConversionLambda(){} // RVA: 0x7ffaae770400
        public void AddAssignChecked(){} // RVA: 0x7ffaae7708a0
        public void AddAssignChecked(){} // RVA: 0x7ffaae7708a0
        public void AddAssignChecked(){} // RVA: 0x7ffaae7708a0
        public void AddChecked(){} // RVA: 0x7ffaae770be0
        public void AddChecked(){} // RVA: 0x7ffaae770be0
        public void Subtract(){} // RVA: 0x7ffaae770ec0
        public void Subtract(){} // RVA: 0x7ffaae770ec0
        public void SubtractAssign(){} // RVA: 0x7ffaae771220
        public void SubtractAssign(){} // RVA: 0x7ffaae771220
        public void SubtractAssign(){} // RVA: 0x7ffaae771220
        public void SubtractAssignChecked(){} // RVA: 0x7ffaae771620
        public void SubtractAssignChecked(){} // RVA: 0x7ffaae771620
        public void SubtractAssignChecked(){} // RVA: 0x7ffaae771620
        public void SubtractChecked(){} // RVA: 0x7ffaae771960
        public void SubtractChecked(){} // RVA: 0x7ffaae771960
        public void Divide(){} // RVA: 0x7ffaae771c40
        public void Divide(){} // RVA: 0x7ffaae771c40
        public void DivideAssign(){} // RVA: 0x7ffaae771fa0
        public void DivideAssign(){} // RVA: 0x7ffaae771fa0
        public void DivideAssign(){} // RVA: 0x7ffaae771fa0
        public void Modulo(){} // RVA: 0x7ffaae7722e0
        public void Modulo(){} // RVA: 0x7ffaae7722e0
        public void ModuloAssign(){} // RVA: 0x7ffaae772640
        public void ModuloAssign(){} // RVA: 0x7ffaae772640
        public void ModuloAssign(){} // RVA: 0x7ffaae772640
        public void Multiply(){} // RVA: 0x7ffaae772980
        public void Multiply(){} // RVA: 0x7ffaae772980
        public void MultiplyAssign(){} // RVA: 0x7ffaae772ce0
        public void MultiplyAssign(){} // RVA: 0x7ffaae772ce0
        public void MultiplyAssign(){} // RVA: 0x7ffaae772ce0
        public void MultiplyAssignChecked(){} // RVA: 0x7ffaae7730e0
        public void MultiplyAssignChecked(){} // RVA: 0x7ffaae7730e0
        public void MultiplyAssignChecked(){} // RVA: 0x7ffaae7730e0
        public void MultiplyChecked(){} // RVA: 0x7ffaae773420
        public void MultiplyChecked(){} // RVA: 0x7ffaae773420
        public void IsSimpleShift(){} // RVA: 0x7ffaae773690
        public void LeftShift(){} // RVA: 0x7ffaae773960
        public void LeftShift(){} // RVA: 0x7ffaae773960
        public void LeftShiftAssign(){} // RVA: 0x7ffaae773cb0
        public void LeftShiftAssign(){} // RVA: 0x7ffaae773cb0
        public void LeftShiftAssign(){} // RVA: 0x7ffaae773cb0
        public void RightShift(){} // RVA: 0x7ffaae773fd0
        public void RightShift(){} // RVA: 0x7ffaae773fd0
        public void RightShiftAssign(){} // RVA: 0x7ffaae774320
        public void RightShiftAssign(){} // RVA: 0x7ffaae774320
        public void RightShiftAssign(){} // RVA: 0x7ffaae774320
        public void And(){} // RVA: 0x7ffaae774640
        public void And(){} // RVA: 0x7ffaae774640
        public void AndAssign(){} // RVA: 0x7ffaae7749a0
        public void AndAssign(){} // RVA: 0x7ffaae7749a0
        public void AndAssign(){} // RVA: 0x7ffaae7749a0
        public void Or(){} // RVA: 0x7ffaae774ce0
        public void Or(){} // RVA: 0x7ffaae774ce0
        public void OrAssign(){} // RVA: 0x7ffaae775040
        public void OrAssign(){} // RVA: 0x7ffaae775040
        public void OrAssign(){} // RVA: 0x7ffaae775040
        public void ExclusiveOr(){} // RVA: 0x7ffaae775380
        public void ExclusiveOr(){} // RVA: 0x7ffaae775380
        public void ExclusiveOrAssign(){} // RVA: 0x7ffaae7756e0
        public void ExclusiveOrAssign(){} // RVA: 0x7ffaae7756e0
        public void ExclusiveOrAssign(){} // RVA: 0x7ffaae7756e0
        public void Power(){} // RVA: 0x7ffaae775a20
        public void Power(){} // RVA: 0x7ffaae775a20
        public void PowerAssign(){} // RVA: 0x7ffaae775f30
        public void PowerAssign(){} // RVA: 0x7ffaae775f30
        public void PowerAssign(){} // RVA: 0x7ffaae775f30
        public void ArrayIndex(){} // RVA: 0x7ffaae789440
        public void Block(){} // RVA: 0x7ffaae776da0
        public void Block(){} // RVA: 0x7ffaae776da0
        public void Block(){} // RVA: 0x7ffaae776da0
        public void Block(){} // RVA: 0x7ffaae776da0
        public void Block(){} // RVA: 0x7ffaae776da0
        public void Block(){} // RVA: 0x7ffaae776da0
        public void Block(){} // RVA: 0x7ffaae776da0
        public void Block(){} // RVA: 0x7ffaae776da0
        public void Block(){} // RVA: 0x7ffaae776da0
        public void Block(){} // RVA: 0x7ffaae776da0
        public void Block(){} // RVA: 0x7ffaae776da0
        public void Block(){} // RVA: 0x7ffaae776da0
        public void BlockCore(){} // RVA: 0x7ffaae7770c0
        public void ValidateVariables(){} // RVA: 0x7ffaae777530
        public void Catch(){} // RVA: 0x7ffaae777ea0
        public void Catch(){} // RVA: 0x7ffaae777ea0
        public void Catch(){} // RVA: 0x7ffaae777ea0
        public void Catch(){} // RVA: 0x7ffaae777ea0
        public void MakeCatchBlock(){} // RVA: 0x7ffaae777fa0
        public void Condition(){} // RVA: 0x7ffaae778700
        public void Condition(){} // RVA: 0x7ffaae778700
        public void IfThen(){} // RVA: 0x7ffaae778a40
        public void IfThenElse(){} // RVA: 0x7ffaae778b60
        public void Constant(){} // RVA: 0x7ffaae778ce0
        public void Constant(){} // RVA: 0x7ffaae778ce0
        public void DebugInfo(){} // RVA: 0x7ffaae778f60
        public void ClearDebugInfo(){} // RVA: 0x7ffaae7790e0
        public void ValidateSpan(){} // RVA: 0x7ffaae7791a0
        public void Empty(){} // RVA: 0x7ffaae779390
        public void Default(){} // RVA: 0x7ffaae779480
        public void ElementInit(){} // RVA: 0x7ffaae7795e0
        public void ElementInit(){} // RVA: 0x7ffaae7795e0
        public void ValidateElementInitAddMethodInfo(){} // RVA: 0x7ffaae779840
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_NodeType(){} // RVA: 0x7ffaae779dc0
        public void get_Type(){} // RVA: 0x7ffaae779ec0
        public void get_CanReduce(){} // RVA: 0x7ffaa8932320
        public void Reduce(){} // RVA: 0x7ffaae779fc0
        public void VisitChildren(){} // RVA: 0x7ffaae77a010
        public void Accept(){} // RVA: 0x7ffaae77a0a0
        public void ReduceAndCheck(){} // RVA: 0x7ffaae77a0d0
        public void ReduceExtensions(){} // RVA: 0x7ffaae77a230
        public void ToString(){} // RVA: 0x7ffaae77a290
        public void get_DebugView(){} // RVA: 0x7ffaae77a320
        public void RequiresCanRead(){} // RVA: 0x7ffaae77a4b0
        public void RequiresCanWrite(){} // RVA: 0x7ffaae77a5e0
        public void Dynamic(){} // RVA: 0x7ffaae77a870
        public void Dynamic(){} // RVA: 0x7ffaae77a870
        public void Dynamic(){} // RVA: 0x7ffaae77a870
        public void Dynamic(){} // RVA: 0x7ffaae77a870
        public void Dynamic(){} // RVA: 0x7ffaae77a870
        public void Dynamic(){} // RVA: 0x7ffaae77a870
        public void MakeDynamic(){} // RVA: 0x7ffaae77a910
        public void MakeDynamic(){} // RVA: 0x7ffaae77a910
        public void MakeDynamic(){} // RVA: 0x7ffaae77a910
        public void MakeDynamic(){} // RVA: 0x7ffaae77a910
        public void MakeDynamic(){} // RVA: 0x7ffaae77a910
        public void MakeDynamic(){} // RVA: 0x7ffaae77a910
        public void Break(){} // RVA: 0x7ffaae77ac00
        public void Break(){} // RVA: 0x7ffaae77ac00
        public void Break(){} // RVA: 0x7ffaae77ac00
        public void Break(){} // RVA: 0x7ffaae77ac00
        public void Continue(){} // RVA: 0x7ffaae77ad80
        public void Continue(){} // RVA: 0x7ffaae77ad80
        public void Return(){} // RVA: 0x7ffaae77b070
        public void Return(){} // RVA: 0x7ffaae77b070
        public void Return(){} // RVA: 0x7ffaae77b070
        public void Return(){} // RVA: 0x7ffaae77b070
        public void Goto(){} // RVA: 0x7ffaae77b370
        public void Goto(){} // RVA: 0x7ffaae77b370
        public void Goto(){} // RVA: 0x7ffaae77b370
        public void Goto(){} // RVA: 0x7ffaae77b370
        public void MakeGoto(){} // RVA: 0x7ffaae77b3f0
        public void ValidateGoto(){} // RVA: 0x7ffaae77b600
        public void ValidateGotoType(){} // RVA: 0x7ffaae77b7c0
        public void MakeIndex(){} // RVA: 0x7ffaae77b980
        public void ArrayAccess(){} // RVA: 0x7ffaae77ba80
        public void ArrayAccess(){} // RVA: 0x7ffaae77ba80
        public void Property(){} // RVA: 0x7ffaae783d90
        public void FindInstanceProperty(){} // RVA: 0x7ffaae77c140
        public void FindProperty(){} // RVA: 0x7ffaae77c450
        public void IsCompatible(){} // RVA: 0x7ffaae789070
        public void Property(){} // RVA: 0x7ffaae783d90
        public void Property(){} // RVA: 0x7ffaae783d90
        public void MakeIndexProperty(){} // RVA: 0x7ffaae77c990
        public void ValidateIndexedProperty(){} // RVA: 0x7ffaae77ca60
        public void ValidateAccessor(){} // RVA: 0x7ffaae77d0f0
        public void ValidateAccessorArgumentTypes(){} // RVA: 0x7ffaae77d3c0
        public void Invoke(){} // RVA: 0x7ffaae77ec00
        public void Invoke(){} // RVA: 0x7ffaae77ec00
        public void Invoke(){} // RVA: 0x7ffaae77ec00
        public void Invoke(){} // RVA: 0x7ffaae77ec00
        public void Invoke(){} // RVA: 0x7ffaae77ec00
        public void Invoke(){} // RVA: 0x7ffaae77ec00
        public void Invoke(){} // RVA: 0x7ffaae77ec00
        public void Invoke(){} // RVA: 0x7ffaae77ec00
        public void Label(){} // RVA: 0x7ffaae77f750
        public void Label(){} // RVA: 0x7ffaae77f750
        public void Label(){} // RVA: 0x7ffaae77f750
        public void Label(){} // RVA: 0x7ffaae77f750
        public void Label(){} // RVA: 0x7ffaae77f750
        public void Label(){} // RVA: 0x7ffaae77f750
        public void CreateLambda(){} // RVA: 0x7ffaae77f8f0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void Lambda(){} // RVA: 0x7ffaae7809a0
        public void ValidateLambdaArgs(){} // RVA: 0x7ffaae780a90
        public void ValidateTryGetFuncActionArgs(){} // RVA: 0x7ffaae781370
        public void TryGetFuncType(){} // RVA: 0x7ffaae781610
        public void TryGetActionType(){} // RVA: 0x7ffaae7818f0
        public void ListInit(){} // RVA: 0x7ffaae782540
        public void ListInit(){} // RVA: 0x7ffaae782540
        public void ListInit(){} // RVA: 0x7ffaae782540
        public void ListInit(){} // RVA: 0x7ffaae782540
        public void ListInit(){} // RVA: 0x7ffaae782540
        public void ListInit(){} // RVA: 0x7ffaae782540
        public void Loop(){} // RVA: 0x7ffaae7827e0
        public void Loop(){} // RVA: 0x7ffaae7827e0
        public void Loop(){} // RVA: 0x7ffaae7827e0
        public void Bind(){} // RVA: 0x7ffaae782c80
        public void Bind(){} // RVA: 0x7ffaae782c80
        public void ValidateSettableFieldOrPropertyMember(){} // RVA: 0x7ffaae782e30
        public void Field(){} // RVA: 0x7ffaae783470
        public void Field(){} // RVA: 0x7ffaae783470
        public void Field(){} // RVA: 0x7ffaae783470
        public void Property(){} // RVA: 0x7ffaae783d90
        public void Property(){} // RVA: 0x7ffaae783d90
        public void Property(){} // RVA: 0x7ffaae783d90
        public void Property(){} // RVA: 0x7ffaae783d90
        public void PropertyOrField(){} // RVA: 0x7ffaae784320
        public void MakeMemberAccess(){} // RVA: 0x7ffaae7845f0
        public void MemberInit(){} // RVA: 0x7ffaae784800
        public void MemberInit(){} // RVA: 0x7ffaae784800
        public void ListBind(){} // RVA: 0x7ffaae784e90
        public void ListBind(){} // RVA: 0x7ffaae784e90
        public void ListBind(){} // RVA: 0x7ffaae784e90
        public void ListBind(){} // RVA: 0x7ffaae784e90
        public void ValidateListInitArgs(){} // RVA: 0x7ffaae784fe0
        public void MemberBind(){} // RVA: 0x7ffaae785640
        public void MemberBind(){} // RVA: 0x7ffaae785640
        public void MemberBind(){} // RVA: 0x7ffaae785640
        public void MemberBind(){} // RVA: 0x7ffaae785640
        public void ValidateGettableFieldOrPropertyMember(){} // RVA: 0x7ffaae785720
        public void ValidateMemberInitArgs(){} // RVA: 0x7ffaae785980
        public void Call(){} // RVA: 0x7ffaae788260
        public void Call(){} // RVA: 0x7ffaae788260
        public void Call(){} // RVA: 0x7ffaae788260
        public void Call(){} // RVA: 0x7ffaae788260
        public void Call(){} // RVA: 0x7ffaae788260
        public void Call(){} // RVA: 0x7ffaae788260
        public void Call(){} // RVA: 0x7ffaae788260
        public void Call(){} // RVA: 0x7ffaae788260
        public void Call(){} // RVA: 0x7ffaae788260
        public void Call(){} // RVA: 0x7ffaae788260
        public void Call(){} // RVA: 0x7ffaae788260
        public void Call(){} // RVA: 0x7ffaae788260
        public void Call(){} // RVA: 0x7ffaae788260
        public void Call(){} // RVA: 0x7ffaae788260
        public void Call(){} // RVA: 0x7ffaae788260
        public void Call(){} // RVA: 0x7ffaae788260
        public void ValidateMethodAndGetParameters(){} // RVA: 0x7ffaae788870
        public void ValidateStaticOrInstanceMethod(){} // RVA: 0x7ffaae788ab0
        public void ValidateCallInstanceType(){} // RVA: 0x7ffaae788bd0
        public void ValidateArgumentTypes(){} // RVA: 0x7ffaae788c80
        public void ValidateArgumentCount(){} // RVA: 0x7ffaae788ca0
        public void ValidateOneArgument(){} // RVA: 0x7ffaae788cb0
        public void TryQuote(){} // RVA: 0x7ffaae788cf0
        public void FindMethod(){} // RVA: 0x7ffaae788d00
        public void IsCompatible(){} // RVA: 0x7ffaae789070
        public void ApplyTypeArgs(){} // RVA: 0x7ffaae789310
        public void ArrayIndex(){} // RVA: 0x7ffaae789440
        public void ArrayIndex(){} // RVA: 0x7ffaae789440
        public void NewArrayInit(){} // RVA: 0x7ffaae789940
        public void NewArrayInit(){} // RVA: 0x7ffaae789940
        public void NewArrayBounds(){} // RVA: 0x7ffaae789f60
        public void NewArrayBounds(){} // RVA: 0x7ffaae789f60
        public void New(){} // RVA: 0x7ffaae78aa40
        public void New(){} // RVA: 0x7ffaae78aa40
        public void New(){} // RVA: 0x7ffaae78aa40
        public void New(){} // RVA: 0x7ffaae78aa40
        public void New(){} // RVA: 0x7ffaae78aa40
        public void New(){} // RVA: 0x7ffaae78aa40
        public void ValidateNewArgs(){} // RVA: 0x7ffaae78aeb0
        public void ValidateAnonymousTypeMember(){} // RVA: 0x7ffaae78b9b0
        public void ValidateConstructor(){} // RVA: 0x7ffaae78bd60
        public void Parameter(){} // RVA: 0x7ffaae78be80
        public void Variable(){} // RVA: 0x7ffaae78bf40
        public void Parameter(){} // RVA: 0x7ffaae78be80
        public void Variable(){} // RVA: 0x7ffaae78bf40
        public void Validate(){} // RVA: 0x7ffaae78bfb0
        public void RuntimeVariables(){} // RVA: 0x7ffaae78c1a0
        public void RuntimeVariables(){} // RVA: 0x7ffaae78c1a0
        public void SwitchCase(){} // RVA: 0x7ffaae78c490
        public void SwitchCase(){} // RVA: 0x7ffaae78c490
        public void Switch(){} // RVA: 0x7ffaae78c990
        public void Switch(){} // RVA: 0x7ffaae78c990
        public void Switch(){} // RVA: 0x7ffaae78c990
        public void Switch(){} // RVA: 0x7ffaae78c990
        public void Switch(){} // RVA: 0x7ffaae78c990
        public void Switch(){} // RVA: 0x7ffaae78c990
        public void ValidateSwitchCaseType(){} // RVA: 0x7ffaae78d720
        public void SymbolDocument(){} // RVA: 0x7ffaae78daf0
        public void SymbolDocument(){} // RVA: 0x7ffaae78daf0
        public void SymbolDocument(){} // RVA: 0x7ffaae78daf0
        public void SymbolDocument(){} // RVA: 0x7ffaae78daf0
        public void TryFault(){} // RVA: 0x7ffaae78dbc0
        public void TryFinally(){} // RVA: 0x7ffaae78dc30
        public void TryCatch(){} // RVA: 0x7ffaae78dca0
        public void TryCatchFinally(){} // RVA: 0x7ffaae78dd10
        public void MakeTry(){} // RVA: 0x7ffaae78dd90
        public void ValidateTryAndCatchHaveSameType(){} // RVA: 0x7ffaae78e010
        public void TypeIs(){} // RVA: 0x7ffaae78e680
        public void TypeEqual(){} // RVA: 0x7ffaae78e7e0
        public void MakeUnary(){} // RVA: 0x7ffaae78e9c0
        public void MakeUnary(){} // RVA: 0x7ffaae78e9c0
        public void Negate(){} // RVA: 0x7ffaae7901c0
        public void Negate(){} // RVA: 0x7ffaae7901c0
        public void UnaryPlus(){} // RVA: 0x7ffaae790410
        public void UnaryPlus(){} // RVA: 0x7ffaae790410
        public void NegateChecked(){} // RVA: 0x7ffaae790620
        public void NegateChecked(){} // RVA: 0x7ffaae790620
        public void Not(){} // RVA: 0x7ffaae790870
        public void Not(){} // RVA: 0x7ffaae790870
        public void IsFalse(){} // RVA: 0x7ffaae790ac0
        public void IsFalse(){} // RVA: 0x7ffaae790ac0
        public void IsTrue(){} // RVA: 0x7ffaae790cd0
        public void IsTrue(){} // RVA: 0x7ffaae790cd0
        public void OnesComplement(){} // RVA: 0x7ffaae790ee0
        public void OnesComplement(){} // RVA: 0x7ffaae790ee0
        public void TypeAs(){} // RVA: 0x7ffaae791090
        public void Unbox(){} // RVA: 0x7ffaae791250
        public void Convert(){} // RVA: 0x7ffaae791530
        public void Convert(){} // RVA: 0x7ffaae791530
        public void ConvertChecked(){} // RVA: 0x7ffaae7917f0
        public void ConvertChecked(){} // RVA: 0x7ffaae7917f0
        public void ArrayLength(){} // RVA: 0x7ffaae791a70
        public void Quote(){} // RVA: 0x7ffaae791cc0
        public void Rethrow(){} // RVA: 0x7ffaae792030
        public void Rethrow(){} // RVA: 0x7ffaae792030
        public void Throw(){} // RVA: 0x7ffaae792270
        public void Throw(){} // RVA: 0x7ffaae792270
        public void Increment(){} // RVA: 0x7ffaae792490
        public void Increment(){} // RVA: 0x7ffaae792490
        public void Decrement(){} // RVA: 0x7ffaae7926a0
        public void Decrement(){} // RVA: 0x7ffaae7926a0
        public void PreIncrementAssign(){} // RVA: 0x7ffaae7928b0
        public void PreIncrementAssign(){} // RVA: 0x7ffaae7928b0
        public void PreDecrementAssign(){} // RVA: 0x7ffaae792980
        public void PreDecrementAssign(){} // RVA: 0x7ffaae792980
        public void PostIncrementAssign(){} // RVA: 0x7ffaae792a50
        public void PostIncrementAssign(){} // RVA: 0x7ffaae792a50
        public void PostDecrementAssign(){} // RVA: 0x7ffaae792b20
        public void PostDecrementAssign(){} // RVA: 0x7ffaae792b20
        public void MakeOpAssignUnary(){} // RVA: 0x7ffaae792b90
        public void .cctor(){} // RVA: 0x7ffaae792e50
        // ── Binary Analysis Named ──
        public void GetUserDefinedBinaryOperator(){} // RVA: 0x7ffaae76b090
        public void GetMethodBasedBinaryOperator(){} // RVA: 0x7ffaae76a1e0
        public void GetMethodBasedAssignOperator(){} // RVA: 0x7ffaae76a880
        public void GetUserDefinedBinaryOperatorOrThrow(){} // RVA: 0x7ffaae76ab50
        public void GetUserDefinedAssignOperatorOrThrow(){} // RVA: 0x7ffaae76adc0
        public void GetUserDefinedBinaryOperator(){} // RVA: 0x7ffaae76b090
        public void GetEqualityComparisonOperator(){} // RVA: 0x7ffaae76d8d0
        public void GetComparisonOperator(){} // RVA: 0x7ffaae76e3e0
        public void GetResultTypeOfShift(){} // RVA: 0x7ffaae773770
        public void GetOptimizedBlockExpression(){} // RVA: 0x7ffaae7777d0
        public void GetArgTypesString(){} // RVA: 0x7ffaae77c290
        public void GetInvokeMethod(){} // RVA: 0x7ffaae77f0b0
        public void GetFuncType(){} // RVA: 0x7ffaae7814a0
        public void GetActionType(){} // RVA: 0x7ffaae781780
        public void GetDelegateType(){} // RVA: 0x7ffaae781a60
        public void GetProperty(){} // RVA: 0x7ffaae783ee0
        public void CheckMethod(){} // RVA: 0x7ffaae784140
        public void GetParametersForValidation(){} // RVA: 0x7ffaae788c90
        public void GetUserDefinedUnaryOperatorOrThrow(){} // RVA: 0x7ffaae78f0b0
        public void GetUserDefinedUnaryOperator(){} // RVA: 0x7ffaae78f250
        public void GetMethodBasedUnaryOperator(){} // RVA: 0x7ffaae78f5f0
        public void GetUserDefinedCoercionOrThrow(){} // RVA: 0x7ffaae78fa40
        public void GetUserDefinedCoercion(){} // RVA: 0x7ffaae78fbb0
        public void GetMethodBasedCoercionOperator(){} // RVA: 0x7ffaae78fcb0
    }

    public class Expression0`1 : Expression`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void get_ParameterCount(){} // RVA: 0x7ffaa8649ca0
        public void SameParameters(){} // RVA: 0x7ffaa864a2a0
        public void Rewrite(){} // RVA: 0x7ffaa865aa30
        // ── Binary Analysis Named ──
        public void GetParameter(){} // RVA: 0x7ffaa8658120
        public void GetOrMakeParameters(){} // RVA: 0x7ffaa86491d0
    }

    public class Expression1`1 : Expression`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8669e70
        public void get_ParameterCount(){} // RVA: 0x7ffaa8649ca0
        public void SameParameters(){} // RVA: 0x7ffaa864a2a0
        public void Rewrite(){} // RVA: 0x7ffaa865aa30
        // ── Binary Analysis Named ──
        public void GetParameter(){} // RVA: 0x7ffaa8658120
        public void GetOrMakeParameters(){} // RVA: 0x7ffaa86491d0
    }

    public class Expression2`1 : Expression`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa866b2a0
        public void get_ParameterCount(){} // RVA: 0x7ffaa8649ca0
        public void SameParameters(){} // RVA: 0x7ffaa864a2a0
        public void Rewrite(){} // RVA: 0x7ffaa865aa30
        // ── Binary Analysis Named ──
        public void GetParameter(){} // RVA: 0x7ffaa8658120
        public void GetOrMakeParameters(){} // RVA: 0x7ffaa86491d0
    }

    public class Expression3`1 : Expression`1
    {
        public object _par2; // 0x30F9EE30
        public object ParameterCount; // 0x170001BC

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa866bc00
        public void get_ParameterCount(){} // RVA: 0x7ffaa8649ca0
        public void SameParameters(){} // RVA: 0x7ffaa864a2a0
        public void Rewrite(){} // RVA: 0x7ffaa865aa30
        // ── Binary Analysis Named ──
        public void GetParameter(){} // RVA: 0x7ffaa8658120
        public void GetOrMakeParameters(){} // RVA: 0x7ffaa86491d0
    }

    public class ExpressionCreator`1 : Object
    {
        // ── Original Methods ──
        public void CreateExpressionFunc(){} // RVA: 0x7ffaa865aca0
    }

    public class ExpressionN`1 : Expression`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8669e70
        public void get_ParameterCount(){} // RVA: 0x7ffaa8649ca0
        public void SameParameters(){} // RVA: 0x7ffaa864a2a0
        public void Rewrite(){} // RVA: 0x7ffaa865aa30
        // ── Binary Analysis Named ──
        public void GetParameter(){} // RVA: 0x7ffaa8658120
        public void GetOrMakeParameters(){} // RVA: 0x7ffaa86491d0
    }

    public class ExpressionN`1 : Expression`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab669240
        public void get_ParameterCount(){} // RVA: 0x7ffaab66a790
        public void SameParameters(){} // RVA: 0x7ffaab66a840
        public void Rewrite(){} // RVA: 0x7ffaab66a960
        // ── Binary Analysis Named ──
        public void GetParameter(){} // RVA: 0x7ffaab66a7e0
        public void GetOrMakeParameters(){} // RVA: 0x7ffaab66a920
    }

    public class ExpressionStringBuilder : ExpressionVisitor
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae7ab2c0
        public void ToString(){} // RVA: 0x7ffaa9706a00
        public void Out(){} // RVA: 0x7ffaae7ab540
        public void Out(){} // RVA: 0x7ffaae7ab540
        public void ExpressionToString(){} // RVA: 0x7ffaae77a290
        public void CatchBlockToString(){} // RVA: 0x7ffaae798090
        public void SwitchCaseToString(){} // RVA: 0x7ffaae7ab560
        public void MemberBindingToString(){} // RVA: 0x7ffaae7ab5f0
        public void ElementInitBindingToString(){} // RVA: 0x7ffaae7a3ec0
        public void VisitExpressions(){} // RVA: 0x7ffaa887e5c0
        public void VisitExpressions(){} // RVA: 0x7ffaa887e5c0
        public void VisitBinary(){} // RVA: 0x7ffaae7ab680
        public void VisitParameter(){} // RVA: 0x7ffaae7abf20
        public void VisitLambda(){} // RVA: 0x7ffaa8649280
        public void VisitListInit(){} // RVA: 0x7ffaae7ac090
        public void VisitConditional(){} // RVA: 0x7ffaae7ac260
        public void VisitConstant(){} // RVA: 0x7ffaae7ac3e0
        public void VisitDebugInfo(){} // RVA: 0x7ffaae7ac6c0
        public void VisitRuntimeVariables(){} // RVA: 0x7ffaae7aca40
        public void OutMember(){} // RVA: 0x7ffaae7acab0
        public void VisitMember(){} // RVA: 0x7ffaae7acbd0
        public void VisitMemberInit(){} // RVA: 0x7ffaae7acd40
        public void VisitMemberAssignment(){} // RVA: 0x7ffaae7ad060
        public void VisitMemberListBinding(){} // RVA: 0x7ffaae7ad110
        public void VisitMemberMemberBinding(){} // RVA: 0x7ffaae7ad300
        public void VisitElementInit(){} // RVA: 0x7ffaae7ad4f0
        public void VisitInvocation(){} // RVA: 0x7ffaae7ad720
        public void VisitMethodCall(){} // RVA: 0x7ffaae7ad8b0
        public void VisitNewArray(){} // RVA: 0x7ffaae7adbf0
        public void VisitNew(){} // RVA: 0x7ffaae7add40
        public void VisitTypeBinary(){} // RVA: 0x7ffaae7ae000
        public void VisitUnary(){} // RVA: 0x7ffaae7ae1d0
        public void VisitBlock(){} // RVA: 0x7ffaae7ae930
        public void VisitDefault(){} // RVA: 0x7ffaae7aecb0
        public void VisitLabel(){} // RVA: 0x7ffaae7aedd0
        public void VisitGoto(){} // RVA: 0x7ffaae7aeeb0
        public void VisitLoop(){} // RVA: 0x7ffaae7af0b0
        public void VisitSwitchCase(){} // RVA: 0x7ffaae7af110
        public void VisitSwitch(){} // RVA: 0x7ffaae7af1d0
        public void VisitCatchBlock(){} // RVA: 0x7ffaae7af2e0
        public void VisitTry(){} // RVA: 0x7ffaae7af450
        public void VisitIndex(){} // RVA: 0x7ffaae7af4b0
        public void VisitExtension(){} // RVA: 0x7ffaae7af780
        public void DumpLabel(){} // RVA: 0x7ffaae7afad0
        public void IsBool(){} // RVA: 0x7ffaae7afc00
        // ── Binary Analysis Named ──
        public void GetLabelId(){} // RVA: 0x7ffaae7ab360
        public void GetParamId(){} // RVA: 0x7ffaae7ab360
        public void GetId(){} // RVA: 0x7ffaae7ab370
    }

    public class ExpressionVisitor : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void Visit(){} // RVA: 0x7ffaa8649330
        public void Visit(){} // RVA: 0x7ffaa8649330
        public void VisitArguments(){} // RVA: 0x7ffaae7b00e0
        public void VisitParameters(){} // RVA: 0x7ffaae7b00f0
        public void Visit(){} // RVA: 0x7ffaa8649330
        public void VisitAndConvert(){} // RVA: 0x7ffaa865aa30
        public void VisitAndConvert(){} // RVA: 0x7ffaa865aa30
        public void VisitBinary(){} // RVA: 0x7ffaae7b0100
        public void VisitBlock(){} // RVA: 0x7ffaae7b0210
        public void VisitConditional(){} // RVA: 0x7ffaae7b0310
        public void VisitConstant(){} // RVA: 0x7ffaa98c2840
        public void VisitDebugInfo(){} // RVA: 0x7ffaa98c2840
        public void VisitDefault(){} // RVA: 0x7ffaa98c2840
        public void VisitExtension(){} // RVA: 0x7ffaae798cc0
        public void VisitGoto(){} // RVA: 0x7ffaae7b0460
        public void VisitInvocation(){} // RVA: 0x7ffaae7b0560
        public void VisitLabelTarget(){} // RVA: 0x7ffaa98c2840
        public void VisitLabel(){} // RVA: 0x7ffaae7b0600
        public void VisitLambda(){} // RVA: 0x7ffaa8649280
        public void VisitLoop(){} // RVA: 0x7ffaae7b06d0
        public void VisitMember(){} // RVA: 0x7ffaae7b07d0
        public void VisitIndex(){} // RVA: 0x7ffaae7b0880
        public void VisitMethodCall(){} // RVA: 0x7ffaae7b09d0
        public void VisitNewArray(){} // RVA: 0x7ffaae7b0aa0
        public void VisitNew(){} // RVA: 0x7ffaae7b0ae0
        public void VisitParameter(){} // RVA: 0x7ffaa98c2840
        public void VisitRuntimeVariables(){} // RVA: 0x7ffaae7b0c10
        public void VisitSwitchCase(){} // RVA: 0x7ffaae7b0d10
        public void VisitSwitch(){} // RVA: 0x7ffaae7b0e10
        public void VisitCatchBlock(){} // RVA: 0x7ffaae7b1040
        public void VisitTry(){} // RVA: 0x7ffaae7b1190
        public void VisitTypeBinary(){} // RVA: 0x7ffaae7b1370
        public void VisitUnary(){} // RVA: 0x7ffaae7b1450
        public void VisitMemberInit(){} // RVA: 0x7ffaae7b1630
        public void VisitListInit(){} // RVA: 0x7ffaae7b17d0
        public void VisitElementInit(){} // RVA: 0x7ffaae7b1970
        public void VisitMemberBinding(){} // RVA: 0x7ffaae7b1a00
        public void VisitMemberAssignment(){} // RVA: 0x7ffaae7b1ba0
        public void VisitMemberMemberBinding(){} // RVA: 0x7ffaae7b1c40
        public void VisitMemberListBinding(){} // RVA: 0x7ffaae7b1d90
        public void ValidateUnary(){} // RVA: 0x7ffaae7b1ee0
        public void ValidateBinary(){} // RVA: 0x7ffaae7b1ff0
        public void ValidateSwitch(){} // RVA: 0x7ffaae7b2190
        public void ValidateChildType(){} // RVA: 0x7ffaae7b2210
        public void VisitDynamic(){} // RVA: 0x7ffaae7a3d60
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void get_TypeCore(){} // RVA: 0x7ffaa86491d0
        public void get_PublicType(){} // RVA: 0x7ffaa86491d0
        public void Compile(){} // RVA: 0x7ffaa887e5c0
        public void Compile(){} // RVA: 0x7ffaa887e5c0
        public void Update(){} // RVA: 0x7ffaa865aa30
        public void SameParameters(){} // RVA: 0x7ffaa864a2a0
        public void Rewrite(){} // RVA: 0x7ffaa865aa30
        public void Accept(){} // RVA: 0x7ffaa8649280
        public void Compile(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab66aff0
        public void get_TypeCore(){} // RVA: 0x7ffaab66b000
        public void get_PublicType(){} // RVA: 0x7ffaab66b0b0
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void Update(){} // RVA: 0x7ffaab66b410
        public void SameParameters(){} // RVA: 0x7ffaab66af00
        public void Rewrite(){} // RVA: 0x7ffaab66af20
        public void Accept(){} // RVA: 0x7ffaab66af40
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void .ctor(){} // RVA: 0x7ffaab66aff0
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab66aff0
        public void get_TypeCore(){} // RVA: 0x7ffaab66b000
        public void get_PublicType(){} // RVA: 0x7ffaab66b0b0
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void Update(){} // RVA: 0x7ffaab66b410
        public void SameParameters(){} // RVA: 0x7ffaab66af00
        public void Rewrite(){} // RVA: 0x7ffaab66af20
        public void Accept(){} // RVA: 0x7ffaab66af40
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void .ctor(){} // RVA: 0x7ffaab66aff0
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab66aff0
        public void get_TypeCore(){} // RVA: 0x7ffaab66b000
        public void get_PublicType(){} // RVA: 0x7ffaab66b0b0
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void Update(){} // RVA: 0x7ffaab66b410
        public void SameParameters(){} // RVA: 0x7ffaab66af00
        public void Rewrite(){} // RVA: 0x7ffaab66af20
        public void Accept(){} // RVA: 0x7ffaab66af40
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void .ctor(){} // RVA: 0x7ffaab66aff0
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab66aff0
        public void get_TypeCore(){} // RVA: 0x7ffaab66b000
        public void get_PublicType(){} // RVA: 0x7ffaab66b0b0
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void Update(){} // RVA: 0x7ffaab66b410
        public void SameParameters(){} // RVA: 0x7ffaab66af00
        public void Rewrite(){} // RVA: 0x7ffaab66af20
        public void Accept(){} // RVA: 0x7ffaab66af40
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void .ctor(){} // RVA: 0x7ffaab66aff0
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab66aff0
        public void get_TypeCore(){} // RVA: 0x7ffaab66b000
        public void get_PublicType(){} // RVA: 0x7ffaab66b0b0
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void Update(){} // RVA: 0x7ffaab66b410
        public void SameParameters(){} // RVA: 0x7ffaab66af00
        public void Rewrite(){} // RVA: 0x7ffaab66af20
        public void Accept(){} // RVA: 0x7ffaab66af40
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void .ctor(){} // RVA: 0x7ffaab66aff0
    }

    public class Expression`1 : LambdaExpression
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab66aff0
        public void get_TypeCore(){} // RVA: 0x7ffaab66b000
        public void get_PublicType(){} // RVA: 0x7ffaab66b0b0
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void Update(){} // RVA: 0x7ffaab66b410
        public void SameParameters(){} // RVA: 0x7ffaab66af00
        public void Rewrite(){} // RVA: 0x7ffaab66af20
        public void Accept(){} // RVA: 0x7ffaab66af40
        public void Compile(){} // RVA: 0x7ffaa884bb60
        public void .ctor(){} // RVA: 0x7ffaab66aff0
    }

    public class FullExpression`1 : ExpressionN`1
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void get_NameCore(){} // RVA: 0x7ffaa86491d0
        public void get_TailCallCore(){} // RVA: 0x7ffaa864a040
    }

    public class LambdaExpression : Expression
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae7b46a0
        public void get_Type(){} // RVA: 0x7ffaa92518f0
        public void get_TypeCore(){} // RVA: 0x7ffaa86491d0
        public void get_PublicType(){} // RVA: 0x7ffaa86491d0
        public void get_NodeType(){} // RVA: 0x7ffaa9b5af40
        public void get_Parameters(){} // RVA: 0x7ffaae7b44b0
        public void get_Name(){} // RVA: 0x7ffaa9cf9d80
        public void get_NameCore(){} // RVA: 0x7ffaa8f22da0
        public void get_Body(){} // RVA: 0x7ffaa894d380
        public void get_ReturnType(){} // RVA: 0x7ffaae7b44d0
        public void get_TailCall(){} // RVA: 0x7ffaa9134e10
        public void get_TailCallCore(){} // RVA: 0x7ffaa8932320
        public void System.Linq.Expressions.IParameterProvider.GetParameter(){} // RVA: 0x7ffaae1fe330
        public void System.Linq.Expressions.IParameterProvider.get_ParameterCount(){} // RVA: 0x7ffaae7b45c0
        public void get_ParameterCount(){} // RVA: 0x7ffaae7b45e0
        public void Compile(){} // RVA: 0x7ffaae7b4690
        public void Compile(){} // RVA: 0x7ffaae7b4690
        public void Compile(){} // RVA: 0x7ffaae7b4690
        public void .ctor(){} // RVA: 0x7ffaae7b46a0
        public void CompileToMethod(){} // RVA: 0x7ffaae7b4700
        public void CompileToMethod(){} // RVA: 0x7ffaae7b4700
        // ── Binary Analysis Named ──
        public void GetOrMakeParameters(){} // RVA: 0x7ffaae7b4560
        public void GetParameter(){} // RVA: 0x7ffaae7b4590
    }

    public class ParameterExpression : Expression
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae7ba670
        public void Make(){} // RVA: 0x7ffaae7ba020
        public void get_Type(){} // RVA: 0x7ffaae7ba580
        public void get_NodeType(){} // RVA: 0x7ffaae7ba630
        public void get_Name(){} // RVA: 0x7ffaa894d380
        public void get_IsByRef(){} // RVA: 0x7ffaabb2c2c0
        public void Accept(){} // RVA: 0x7ffaae7ba640
        public void .ctor(){} // RVA: 0x7ffaae7ba670
        // ── Binary Analysis Named ──
        public void GetIsByRef(){} // RVA: 0x7ffaa8932320
    }

    public class PrimitiveParameterExpression`1 : ParameterExpression
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void get_Type(){} // RVA: 0x7ffaa86491d0
    }

    public class StackGuard : Object
    {
        public object  ; // 0x30BAB290

        // ── Original Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0x7ffaa8a17850
        public void RunOnEmptyStack(){} // RVA: 0x7ffaa887e5c0
        public void RunOnEmptyStack(){} // RVA: 0x7ffaa887e5c0
        public void RunOnEmptyStack(){} // RVA: 0x7ffaa887e5c0
        public void RunOnEmptyStack(){} // RVA: 0x7ffaa887e5c0
        public void RunOnEmptyStackCore(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

}