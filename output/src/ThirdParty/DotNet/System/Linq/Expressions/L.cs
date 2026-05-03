// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 6
// Methods: 58

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class LabelExpression : Expression
    {
        public System.Linq.Expressions.LabelTarget _target; // 0x10
        public System.Linq.Expressions.Expression _defaultValue; // 0x18
        public object field_2; // 0x1A4
        public object field_3; // 0x1A5

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713A830 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE8189C080
        public void get_NodeType(){} // RVA: 0x7FFE835C5CD0
        public void get_Target(){} // RVA: 0x7FFE81116380
        public void get_DefaultValue(){} // RVA: 0x7FFE810FE7C0
        public void Accept(){} // RVA: 0x7FFE8713A770
        public void Update(){} // RVA: 0x7FFE8713A7A0
    }

    public class LabelTarget : Object
    {
        public string _name; // 0x10
        public System.Type _type; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713A8B0 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_Type(){} // RVA: 0x7FFE810FE7C0
        public void ToString(){} // RVA: 0x7FFE8713A860
    }

    public class LambdaExpression : Expression
    {
        public System.Linq.Expressions.Expression _body; // 0x10
        public object field_1; // 0x1AA
        public object field_2; // 0x1AB
        public object field_3; // 0x1AC
        public object field_4; // 0x1AD
        public object field_5; // 0x1AE
        public object field_6; // 0x1AF
        public object field_7; // 0x1B0
        public object field_8; // 0x1B1
        public object field_9; // 0x1B2
        public object field_10; // 0x1B3
        public object field_11; // 0x1B4
        public object field_12; // 0x1B5

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713AB50 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE81980F70
        public void get_TypeCore(){} // RVA: 0x7FFE80E2E2E0
        public void get_PublicType(){} // RVA: 0x7FFE80E2E2E0
        public void get_NodeType(){} // RVA: 0x7FFE823EBAD0
        public void get_Parameters(){} // RVA: 0x7FFE81857330
        public void get_Name(){} // RVA: 0x7FFE82215450
        public void get_NameCore(){} // RVA: 0x7FFE813240E0
        public void get_Body(){} // RVA: 0x7FFE81116380
        public void get_ReturnType(){} // RVA: 0x7FFE8713A980
        public void get_TailCall(){} // RVA: 0x7FFE82BC3B70
        public void get_TailCallCore(){} // RVA: 0x7FFE810FB320
        public void GetOrMakeParameters(){} // RVA: 0x7FFE8713AA10
        public void System.Linq.Expressions.IParameterProvider.GetParameter(){} // RVA: 0x7FFE86B86850
        public void GetParameter(){} // RVA: 0x7FFE8713AA40
        public void System.Linq.Expressions.IParameterProvider.get_ParameterCount(){} // RVA: 0x7FFE8713AA70
        public void get_ParameterCount(){} // RVA: 0x7FFE8713AA90
        public void Compile(){} // RVA: 0x7FFE8713AB40 | overloaded x3
        public void CompileToMethod(){} // RVA: 0x7FFE8713ABB0 | overloaded x2
    }

    public class ListInitExpression : Expression
    {
        public System.Linq.Expressions.NewExpression _newExpression; // 0x10
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ElementInit> _initializers; // 0x18
        public object field_2; // 0x1C0
        public object field_3; // 0x1C1
        public object field_4; // 0x1C2

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713AE10 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFE813DA8C0
        public void get_Type(){} // RVA: 0x7FFE815888E0
        public void get_CanReduce(){} // RVA: 0x7FFE811E0850
        public void get_NewExpression(){} // RVA: 0x7FFE81116380
        public void get_Initializers(){} // RVA: 0x7FFE810FE7C0
        public void Accept(){} // RVA: 0x7FFE8713ACF0
        public void Reduce(){} // RVA: 0x7FFE8713AD20
        public void Update(){} // RVA: 0x7FFE8713AD40
    }

    public class LogicalBinaryExpression : BinaryExpression
    {
        public 0x665E5D54 _nodeType; // 0x20
        public object field_1; // 0x84

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE870EFCC0
        public void get_Type(){} // RVA: 0x7FFE870EFD00
        public void get_NodeType(){} // RVA: 0x7FFE8151D690
    }

    public class LoopExpression : Expression
    {
        public System.Linq.Expressions.Expression _body; // 0x10
        public System.Linq.Expressions.LabelTarget _breakLabel; // 0x18
        public System.Linq.Expressions.LabelTarget _continueLabel; // 0x20
        public object field_3; // 0x1C5
        public object field_4; // 0x1C6

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713B100 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE8713AFA0
        public void get_NodeType(){} // RVA: 0x7FFE869A2430
        public void get_Body(){} // RVA: 0x7FFE81116380
        public void get_BreakLabel(){} // RVA: 0x7FFE810FE7C0
        public void get_ContinueLabel(){} // RVA: 0x7FFE811290C0
        public void Accept(){} // RVA: 0x7FFE8713B030
        public void Update(){} // RVA: 0x7FFE8713B060
    }

}