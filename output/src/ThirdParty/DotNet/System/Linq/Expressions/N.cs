// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 5
// Methods: 24

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class NewArrayBoundsExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66010F0
        public void get_NodeType(){} // RVA: 0x6601100
    }

    public class NewArrayExpression
    {
        public System.Type <Type>k__BackingField; // 0x10
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression> <Expressions>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66010C0 | overloaded x2
        public void Make(){} // RVA: 0x6600E40
        public void get_Type(){} // RVA: 0x2F8380
        public void get_Expressions(){} // RVA: 0x2E07C0
        public void Accept(){} // RVA: 0x6600ED0
        public void Update(){} // RVA: 0x6600F00
    }

    public class NewArrayInitExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66010F0
        public void get_NodeType(){} // RVA: 0x210E300
    }

    public class NewExpression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> _arguments; // 0x10
        public System.Reflection.ConstructorInfo <Constructor>k__BackingField; // 0x18
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Reflection.MemberInfo> <Members>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66014C0 | overloaded x2
        public void get_Type(){} // RVA: 0x5BF76F0
        public void get_NodeType(){} // RVA: 0x6601270
        public void get_Constructor(){} // RVA: 0x2E07C0
        public void get_Arguments(){} // RVA: 0x6601280
        public void GetArgument(){} // RVA: 0x66012C0
        public void get_ArgumentCount(){} // RVA: 0x6601320
        public void get_Members(){} // RVA: 0x30B0C0
        public void Accept(){} // RVA: 0x6601370
        public void Update(){} // RVA: 0x66013A0
    }

    public class NewValueTypeExpression
    {
        public System.Type <Type>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66014F0
        public void get_Type(){} // RVA: 0x30B130
    }

}