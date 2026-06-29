// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MS.Internal.Xml.XPath
// Classes: 11
// Methods: 86

namespace ThirdParty.Other.MS.Internal.Xml.XPath
{
    public class AstNode : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A7E00710
        public void get_ReturnType(){} // RVA: 0x7A7E00710
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Axis : AstNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7FB0F0
        public void get_Type(){} // RVA: 0x7A82D1450
        public void get_ReturnType(){} // RVA: 0x7A87EE0F0
        public void get_Input(){} // RVA: 0x7A80DA7B0
        public void set_Input(){} // RVA: 0x7A813E420
        public void get_Prefix(){} // RVA: 0x7A81052C0
        public void get_Name(){} // RVA: 0x7A8105330
        public void get_NodeType(){} // RVA: 0x7A8133100
        public void get_TypeOfAxis(){} // RVA: 0x7A8124910
        public void get_AbbrAxis(){} // RVA: 0x7A810DDD0
        public void get_Urn(){} // RVA: 0x7A8292C30
        public void set_Urn(){} // RVA: 0x7A8296DE0
    }

    public class Filter : AstNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_Type(){} // RVA: 0x7A81DDCC0
        public void get_ReturnType(){} // RVA: 0x7A87EE0F0
    }

    public class Function : AstNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7FB3F0
        public void get_Type(){} // RVA: 0x7A883BE70
        public void get_ReturnType(){} // RVA: 0x7AE7FB4E0
        public void .cctor(){} // RVA: 0x7AE7FB560
    }

    public class Group : AstNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Type(){} // RVA: 0x7A8401A30
        public void get_ReturnType(){} // RVA: 0x7A87EE0F0
    }

    public class Operand : AstNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7FB6A0
        public void get_Type(){} // RVA: 0x7A87EE0F0
        public void get_ReturnType(){} // RVA: 0x7A8124910
    }

    public class Operator : AstNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAC6DFD0
        public void get_Type(){} // RVA: 0x7A81CA9D0
        public void get_ReturnType(){} // RVA: 0x7AE7FB750
        public void .cctor(){} // RVA: 0x7AE7FB770
    }

    public class Root : AstNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Type(){} // RVA: 0x7A8842E60
        public void get_ReturnType(){} // RVA: 0x7A87EE0F0
    }

    public class Variable : AstNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_Type(){} // RVA: 0x7A88258F0
        public void get_ReturnType(){} // RVA: 0x7A8401A30
    }

    public class XPathParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ParseXPathExpression(){} // RVA: 0x7AE7FB850
        public void ParseExpression(){} // RVA: 0x7AE7FBAA0
        public void ParseOrExpr(){} // RVA: 0x7AE7FBC60
        public void ParseAndExpr(){} // RVA: 0x7AE7FBDD0
        public void ParseEqualityExpr(){} // RVA: 0x7AE7FBF40
        public void ParseRelationalExpr(){} // RVA: 0x7AE7FC050
        public void ParseAdditiveExpr(){} // RVA: 0x7AE7FC180
        public void ParseMultiplicativeExpr(){} // RVA: 0x7AE7FC290
        public void ParseUnaryExpr(){} // RVA: 0x7AE7FC490
        public void ParseUnionExpr(){} // RVA: 0x7AE7FC5A0
        public void IsNodeType(){} // RVA: 0x7AE7FC780
        public void ParsePathExpr(){} // RVA: 0x7AE7FC920
        public void ParseFilterExpr(){} // RVA: 0x7AE7FCCA0
        public void ParsePredicate(){} // RVA: 0x7AE7FCDE0
        public void ParseLocationPath(){} // RVA: 0x7AE7FCE90
        public void ParseRelativeLocationPath(){} // RVA: 0x7AE7FCFF0
        public void IsStep(){} // RVA: 0x7AE7FD130
        public void ParseStep(){} // RVA: 0x7AE7FD160
        public void ParseNodeTest(){} // RVA: 0x7AE7FD480
        public void IsPrimaryExpr(){} // RVA: 0x7AE7FD8E0
        public void ParsePrimaryExpr(){} // RVA: 0x7AE7FD970
        public void ParseMethod(){} // RVA: 0x7AE7FDD40
        public void CheckToken(){} // RVA: 0x7AE7FE670
        public void PassToken(){} // RVA: 0x7AE7FE6F0
        public void NextLex(){} // RVA: 0x7AE7FE720
        public void TestOp(){} // RVA: 0x7AE7FE740
        public void CheckNodeSet(){} // RVA: 0x7AE7FE7B0
        public void CreateFunctionTable(){} // RVA: 0x7AE7FE820
        public void CreateAxesTable(){} // RVA: 0x7AE7FFEE0
        public void GetAxis(){} // RVA: 0x7AE800390
        public void .cctor(){} // RVA: 0x7AE8004B0
    }

    public class XPathScanner : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE800BB0
        public void get_SourceText(){} // RVA: 0x7A80F2570
        public void get_CurrentChar(){} // RVA: 0x7AC2A24B0
        public void NextChar(){} // RVA: 0x7AE800CF0
        public void get_Kind(){} // RVA: 0x7A9739200
        public void get_Name(){} // RVA: 0x7A8105330
        public void get_Prefix(){} // RVA: 0x7A83F69F0
        public void get_StringValue(){} // RVA: 0x7A8292C30
        public void get_NumberValue(){} // RVA: 0x7A9D70440
        public void get_CanBeFunction(){} // RVA: 0x7A818F850
        public void SkipSpace(){} // RVA: 0x7AE800D60
        public void NextLex(){} // RVA: 0x7AE800DE0
        public void ScanNumber(){} // RVA: 0x7AE801430
        public void ScanFraction(){} // RVA: 0x7AE8015C0
        public void ScanString(){} // RVA: 0x7AE8016A0
        public void ScanName(){} // RVA: 0x7AE8017F0
    }

}