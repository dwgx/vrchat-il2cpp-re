// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 6
// Methods: 58

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class LabelExpression : Expression
    {
        public System.Linq.Expressions.LabelTarget Type; // 0x10
        public System.Linq.Expressions.Expression NodeType; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D92400 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC356B610
        public void get_NodeType(){} // RVA: 0x7FFAC530F400
        public void get_Target(){} // RVA: 0x7FFAC2F3C380
        public void get_DefaultValue(){} // RVA: 0x7FFAC2F247C0
        public void Accept(){} // RVA: 0x7FFAC8D92340
        public void Update(){} // RVA: 0x7FFAC8D92370
    }

    public class LabelTarget : Object
    {
        public string Name; // 0x10
        public System.Type Type; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D92480 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_Type(){} // RVA: 0x7FFAC2F247C0
        public void ToString(){} // RVA: 0x7FFAC8D92430
    }

    public class LambdaExpression : Expression
    {
        public System.Linq.Expressions.Expression Type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D92720 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC3825740
        public void get_TypeCore(){} // RVA: 0x7FFAC2C58E90
        public void get_PublicType(){} // RVA: 0x7FFAC2C58E90
        public void get_NodeType(){} // RVA: 0x7FFAC413E570
        public void get_Parameters(){} // RVA: 0x7FFAC42D3560
        public void get_Name(){} // RVA: 0x7FFAC8AEC8C0
        public void get_NameCore(){} // RVA: 0x7FFAC34F9180
        public void get_Body(){} // RVA: 0x7FFAC2F3C380
        public void get_ReturnType(){} // RVA: 0x7FFAC8D92550
        public void get_TailCall(){} // RVA: 0x7FFAC3708F90
        public void get_TailCallCore(){} // RVA: 0x7FFAC2F21320
        public void GetOrMakeParameters(){} // RVA: 0x7FFAC8D925E0
        public void System.Linq.Expressions.IParameterProvider.GetParameter(){} // RVA: 0x7FFAC87DD120
        public void GetParameter(){} // RVA: 0x7FFAC8D92610
        public void System.Linq.Expressions.IParameterProvider.get_ParameterCount(){} // RVA: 0x7FFAC8D92640
        public void get_ParameterCount(){} // RVA: 0x7FFAC8D92660
        public void Compile(){} // RVA: 0x7FFAC8D92710 | overloaded x3
        public void CompileToMethod(){} // RVA: 0x7FFAC8D92780 | overloaded x2
    }

    public class ListInitExpression : Expression
    {
        public System.Linq.Expressions.NewExpression NodeType; // 0x10
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ElementInit> Type; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D929E0 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFAC31719D0
        public void get_Type(){} // RVA: 0x7FFAC87BB0A0
        public void get_CanReduce(){} // RVA: 0x7FFAC3006850
        public void get_NewExpression(){} // RVA: 0x7FFAC2F3C380
        public void get_Initializers(){} // RVA: 0x7FFAC2F247C0
        public void Accept(){} // RVA: 0x7FFAC8D928C0
        public void Reduce(){} // RVA: 0x7FFAC8D928F0
        public void Update(){} // RVA: 0x7FFAC8D92910
    }

    public class LogicalBinaryExpression : BinaryExpression
    {
        public 0x6B1EC490 Type; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D47800
        public void get_Type(){} // RVA: 0x7FFAC8D47840
        public void get_NodeType(){} // RVA: 0x7FFAC30DBBE0
    }

    public class LoopExpression : Expression
    {
        public System.Linq.Expressions.Expression Type; // 0x10
        public System.Linq.Expressions.LabelTarget NodeType; // 0x18
        public System.Linq.Expressions.LabelTarget Body; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D92CD0 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC8D92B70
        public void get_NodeType(){} // RVA: 0x7FFAC85F8C60
        public void get_Body(){} // RVA: 0x7FFAC2F3C380
        public void get_BreakLabel(){} // RVA: 0x7FFAC2F247C0
        public void get_ContinueLabel(){} // RVA: 0x7FFAC2F4F0C0
        public void Accept(){} // RVA: 0x7FFAC8D92C00
        public void Update(){} // RVA: 0x7FFAC8D92C30
    }

}