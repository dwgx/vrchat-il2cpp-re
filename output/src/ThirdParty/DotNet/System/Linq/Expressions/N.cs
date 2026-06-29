// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 5
// Methods: 22

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class NewArrayBoundsExpression : NewArrayExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x706EED0
        public void get_NodeType(){} // RVA: 0x706EEE0
    }

    public class NewArrayExpression : Expression
    {
        public object _type;
        public object _expressions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706EEA0
        public void Make(){} // RVA: 0x706EC20
        public void get_Type(){} // RVA: 0xB5DBF0
        public void get_Expressions(){} // RVA: 0xB465B0
        public void Accept(){} // RVA: 0x706ECB0
        public void Update(){} // RVA: 0x706ECE0
    }

    public class NewArrayInitExpression : NewArrayExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x706EED0
        public void get_NodeType(){} // RVA: 0x2AFBE90
    }

    public class NewExpression : Expression
    {
        public object _arguments;
        public object _constructor;
        public object _members;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706F2A0
        public void get_Type(){} // RVA: 0x6670120
        public void get_NodeType(){} // RVA: 0x706F050
        public void get_Constructor(){} // RVA: 0xB465B0
        public void get_Arguments(){} // RVA: 0x706F060
        public void GetArgument(){} // RVA: 0x706F0A0
        public void get_ArgumentCount(){} // RVA: 0x706F100
        public void get_Members(){} // RVA: 0xB700F0
        public void Accept(){} // RVA: 0x706F150
        public void Update(){} // RVA: 0x706F180
    }

    public class NewValueTypeExpression : NewExpression
    {
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706F2D0
        public void get_Type(){} // RVA: 0xB70160
    }

}