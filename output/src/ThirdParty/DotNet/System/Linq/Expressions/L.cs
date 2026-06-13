// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 6
// Methods: 58

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class LabelExpression
    {
        public System.Linq.Expressions.LabelTarget <Target>k__BackingField; // 0x10
        public System.Linq.Expressions.Expression <DefaultValue>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65FB990 | overloaded x2
        public void get_Type(){} // RVA: 0xB2EEA0
        public void get_NodeType(){} // RVA: 0x2111880
        public void get_Target(){} // RVA: 0x2F8380
        public void get_DefaultValue(){} // RVA: 0x2E07C0
        public void Accept(){} // RVA: 0x65FB8D0
        public void Update(){} // RVA: 0x65FB900
    }

    public class LabelTarget
    {
        public string NodeType; // 0x10
        public System.Type Type; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65FBA10 | overloaded x2
        public void get_Name(){} // RVA: 0x2F8380
        public void get_Type(){} // RVA: 0x2E07C0
        public void ToString(){} // RVA: 0x65FB9C0
    }

    public class LambdaExpression
    {
        public System.Linq.Expressions.Expression _body; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65FBC90 | overloaded x2
        public void get_Type(){} // RVA: 0xBEE7B0
        public void get_TypeCore(){} // RVA: 0xCD60
        public void get_PublicType(){} // RVA: 0xCD60
        public void get_NodeType(){} // RVA: 0x16803D0
        public void get_Parameters(){} // RVA: 0x14AEF80
        public void get_Name(){} // RVA: 0x1854D10
        public void get_NameCore(){} // RVA: 0x519240
        public void get_Body(){} // RVA: 0x2F8380
        public void get_ReturnType(){} // RVA: 0x65FBAE0
        public void get_TailCall(){} // RVA: 0xAE50F0
        public void get_TailCallCore(){} // RVA: 0x2DD320
        public void GetOrMakeParameters(){} // RVA: 0x65FBB70
        public void System.Linq.Expressions.IParameterProvider.GetParameter(){} // RVA: 0x6045A70
        public void GetParameter(){} // RVA: 0x65FBBA0
        public void System.Linq.Expressions.IParameterProvider.get_ParameterCount(){} // RVA: 0x1854290
        public void get_ParameterCount(){} // RVA: 0x65FBBD0
        public void Compile(){} // RVA: 0x65FBC80 | overloaded x3
        public void CompileToMethod(){} // RVA: 0x65FBCF0 | overloaded x2
    }

    public class ListInitExpression
    {
        public System.Linq.Expressions.NewExpression <NewExpression>k__BackingField; // 0x10
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ElementInit> <Initializers>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65FBF50 | overloaded x2
        public void get_NodeType(){} // RVA: 0x5D5200
        public void get_Type(){} // RVA: 0x7F0250
        public void get_CanReduce(){} // RVA: 0x3C2850
        public void get_NewExpression(){} // RVA: 0x2F8380
        public void get_Initializers(){} // RVA: 0x2E07C0
        public void Accept(){} // RVA: 0x65FBE30
        public void Reduce(){} // RVA: 0x65FBE60
        public void Update(){} // RVA: 0x65FBE80
    }

    public class LogicalBinaryExpression
    {
        public 0x65908648 <NodeType>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65B0E30
        public void get_Type(){} // RVA: 0x65B0E70
        public void get_NodeType(){} // RVA: 0x760030
    }

    public class LoopExpression
    {
        public System.Linq.Expressions.Expression <Body>k__BackingField; // 0x10
        public System.Linq.Expressions.LabelTarget <BreakLabel>k__BackingField; // 0x18
        public System.Linq.Expressions.LabelTarget <ContinueLabel>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65FC240 | overloaded x2
        public void get_Type(){} // RVA: 0x65FC0E0
        public void get_NodeType(){} // RVA: 0x5E615F0
        public void get_Body(){} // RVA: 0x2F8380
        public void get_BreakLabel(){} // RVA: 0x2E07C0
        public void get_ContinueLabel(){} // RVA: 0x30B0C0
        public void Accept(){} // RVA: 0x65FC170
        public void Update(){} // RVA: 0x65FC1A0
    }

}