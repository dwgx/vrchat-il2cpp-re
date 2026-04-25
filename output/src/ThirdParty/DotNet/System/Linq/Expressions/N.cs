// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 5
// Methods: 24

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class NewArrayBoundsExpression : NewArrayExpression
    {
        public object NodeType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D97B80
        public void get_NodeType(){} // RVA: 0x7FFAC8D97B90
    }

    public class NewArrayExpression : Expression
    {
        public System.Type Type; // 0x10
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression> Expressions; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D97B50 | overloaded x2
        public void Make(){} // RVA: 0x7FFAC8D978D0
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void get_Expressions(){} // RVA: 0x7FFAC2F247C0
        public void Accept(){} // RVA: 0x7FFAC8D97960
        public void Update(){} // RVA: 0x7FFAC8D97990
    }

    public class NewArrayInitExpression : NewArrayExpression
    {
        public object NodeType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D97B80
        public void get_NodeType(){} // RVA: 0x7FFAC530BFF0
    }

    public class NewExpression : Expression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> Type; // 0x10
        public System.Reflection.ConstructorInfo NodeType; // 0x18
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Reflection.MemberInfo> Constructor; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D97F50 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC838EC40
        public void get_NodeType(){} // RVA: 0x7FFAC8D97D00
        public void get_Constructor(){} // RVA: 0x7FFAC2F247C0
        public void get_Arguments(){} // RVA: 0x7FFAC8D97D10
        public void GetArgument(){} // RVA: 0x7FFAC8D97D50
        public void get_ArgumentCount(){} // RVA: 0x7FFAC8D97DB0
        public void get_Members(){} // RVA: 0x7FFAC2F4F0C0
        public void Accept(){} // RVA: 0x7FFAC8D97E00
        public void Update(){} // RVA: 0x7FFAC8D97E30
    }

    public class NewValueTypeExpression : NewExpression
    {
        public System.Type Type; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D97F80
        public void get_Type(){} // RVA: 0x7FFAC2F4F130
    }

}