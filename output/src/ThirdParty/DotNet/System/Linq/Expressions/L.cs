// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 6
// Methods: 58

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class LabelExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90AB990 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAF35DEEA0
        public void get_NodeType(){} // RVA: 0x7FFAF4BC1880
        public void get_Target(){} // RVA: 0x7FFAF2DA8380
        public void get_DefaultValue(){} // RVA: 0x7FFAF2D907C0
        public void Accept(){} // RVA: 0x7FFAF90AB8D0
        public void Update(){} // RVA: 0x7FFAF90AB900
    }

    public class LabelTarget
    {
        public object NodeType;
        public object Type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90ABA10 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void get_Type(){} // RVA: 0x7FFAF2D907C0
        public void ToString(){} // RVA: 0x7FFAF90AB9C0
    }

    public class LambdaExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90ABC90 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAF369E7B0
        public void get_TypeCore(){} // RVA: 0x7FFAF2ABCD60
        public void get_PublicType(){} // RVA: 0x7FFAF2ABCD60
        public void get_NodeType(){} // RVA: 0x7FFAF41303D0
        public void get_Parameters(){} // RVA: 0x7FFAF3F5EF80
        public void get_Name(){} // RVA: 0x7FFAF4304D10
        public void get_NameCore(){} // RVA: 0x7FFAF2FC9240
        public void get_Body(){} // RVA: 0x7FFAF2DA8380
        public void get_ReturnType(){} // RVA: 0x7FFAF90ABAE0
        public void get_TailCall(){} // RVA: 0x7FFAF35950F0
        public void get_TailCallCore(){} // RVA: 0x7FFAF2D8D320
        public void GetOrMakeParameters(){} // RVA: 0x7FFAF90ABB70
        public void System.Linq.Expressions.IParameterProvider.GetParameter(){} // RVA: 0x7FFAF8AF5A70
        public void GetParameter(){} // RVA: 0x7FFAF90ABBA0
        public void System.Linq.Expressions.IParameterProvider.get_ParameterCount(){} // RVA: 0x7FFAF4304290
        public void get_ParameterCount(){} // RVA: 0x7FFAF90ABBD0
        public void Compile(){} // RVA: 0x7FFAF90ABC80 | overloaded x3
        public void CompileToMethod(){} // RVA: 0x7FFAF90ABCF0 | overloaded x2
    }

    public class ListInitExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90ABF50 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFAF3085200
        public void get_Type(){} // RVA: 0x7FFAF32A0250
        public void get_CanReduce(){} // RVA: 0x7FFAF2E72850
        public void get_NewExpression(){} // RVA: 0x7FFAF2DA8380
        public void get_Initializers(){} // RVA: 0x7FFAF2D907C0
        public void Accept(){} // RVA: 0x7FFAF90ABE30
        public void Reduce(){} // RVA: 0x7FFAF90ABE60
        public void Update(){} // RVA: 0x7FFAF90ABE80
    }

    public class LogicalBinaryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9060E30
        public void get_Type(){} // RVA: 0x7FFAF9060E70
        public void get_NodeType(){} // RVA: 0x7FFAF3210030
    }

    public class LoopExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90AC240 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAF90AC0E0
        public void get_NodeType(){} // RVA: 0x7FFAF89115F0
        public void get_Body(){} // RVA: 0x7FFAF2DA8380
        public void get_BreakLabel(){} // RVA: 0x7FFAF2D907C0
        public void get_ContinueLabel(){} // RVA: 0x7FFAF2DBB0C0
        public void Accept(){} // RVA: 0x7FFAF90AC170
        public void Update(){} // RVA: 0x7FFAF90AC1A0
    }

}