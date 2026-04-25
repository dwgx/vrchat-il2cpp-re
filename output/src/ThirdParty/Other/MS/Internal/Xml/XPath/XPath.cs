// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MS.Internal.Xml.XPath
// Classes: 11
// Methods: 90

namespace ThirdParty.Other.MS.Internal.Xml.XPath
{
    public class AstNode : Object
    {
        public object Type;
        public object ReturnType;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2C59960
        public void get_ReturnType(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Axis : AstNode
    {
        public 0x6B166128 Type; // 0x10
        public MS.Internal.Xml.XPath.AstNode ReturnType; // 0x18
        public string Input; // 0x20
        public string Prefix; // 0x28
        public 0x6B15DB18 Name; // 0x30
        public bool NodeType; // 0x34
        public string TypeOfAxis; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91A1AE0 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC34F9180
        public void get_ReturnType(){} // RVA: 0x7FFAC366FE20
        public void get_Input(){} // RVA: 0x7FFAC2F247C0
        public void set_Input(){} // RVA: 0x7FFAC2F87E80
        public void get_Prefix(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Name(){} // RVA: 0x7FFAC2F4F130
        public void get_NodeType(){} // RVA: 0x7FFAC2F7CCD0
        public void get_TypeOfAxis(){} // RVA: 0x7FFAC2F6E5C0
        public void get_AbbrAxis(){} // RVA: 0x7FFAC2F57C20
        public void get_Urn(){} // RVA: 0x7FFAC31D0140
        public void set_Urn(){} // RVA: 0x7FFAC31D0C20
    }

    public class Filter : AstNode
    {
        public MS.Internal.Xml.XPath.AstNode Type; // 0x10
        public MS.Internal.Xml.XPath.AstNode ReturnType; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_Type(){} // RVA: 0x7FFAC3026CB0
        public void get_ReturnType(){} // RVA: 0x7FFAC366FE20
    }

    public class Function : AstNode
    {
        public 0x6B166230 Type; // 0x10
        public System.Collections.Generic.List`1<MS.Internal.Xml.XPath.AstNode> ReturnType; // 0x18
        public string _name; // 0x20
        public string _prefix; // 0x28
        public 0x6B15D960[] ReturnTypes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91A1DC0 | overloaded x3
        public void get_Type(){} // RVA: 0x7FFAC36C3910
        public void get_ReturnType(){} // RVA: 0x7FFAC91A1EB0
        public void .cctor(){} // RVA: 0x7FFAC91A1F30
    }

    public class Group : AstNode
    {
        public MS.Internal.Xml.XPath.AstNode Type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Type(){} // RVA: 0x7FFAC31E48B0
        public void get_ReturnType(){} // RVA: 0x7FFAC366FE20
    }

    public class Operand : AstNode
    {
        public 0x6B15D960 Type; // 0x10
        public object ReturnType; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91A2070 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC366FE20
        public void get_ReturnType(){} // RVA: 0x7FFAC2F6E5C0
    }

    public class Operator : AstNode
    {
        public 0x6B166390[] Type;
        public 0x6B166390 ReturnType; // 0x10
        public MS.Internal.Xml.XPath.AstNode _opnd1; // 0x18
        public MS.Internal.Xml.XPath.AstNode _opnd2; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5808D30
        public void get_Type(){} // RVA: 0x7FFAC3013AF0
        public void get_ReturnType(){} // RVA: 0x7FFAC91A2120
        public void .cctor(){} // RVA: 0x7FFAC91A2140
    }

    public class Root : AstNode
    {
        public object Type;
        public object ReturnType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Type(){} // RVA: 0x7FFAC36A9850
        public void get_ReturnType(){} // RVA: 0x7FFAC366FE20
    }

    public class Variable : AstNode
    {
        public string Type; // 0x10
        public string ReturnType; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_Type(){} // RVA: 0x7FFAC36AE2C0
        public void get_ReturnType(){} // RVA: 0x7FFAC31E48B0
    }

    public class XPathParser : Object
    {
        public MS.Internal.Xml.XPath.XPathScanner _scanner; // 0x10
        public int _parseDepth; // 0x18
        public 0x6B15D960[] s_temparray1;
        public 0x6B15D960[] s_temparray2; // 0x8
        public 0x6B15D960[] s_temparray3; // 0x10
        public 0x6B15D960[] s_temparray4; // 0x18
        public 0x6B15D960[] s_temparray5; // 0x20
        public 0x6B15D960[] s_temparray6; // 0x28
        public 0x6B15D960[] s_temparray7; // 0x30
        public 0x6B15D960[] s_temparray8; // 0x38
        public 0x6B15D960[] s_temparray9; // 0x40
        public System.Collections.Generic.Dictionary`2<string,ParamInfo> s_functionTable; // 0x48
        public System.Collections.Generic.Dictionary`2<string,0x6B166128> s_AxesTable; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ParseXPathExpression(){} // RVA: 0x7FFAC91A2220
        public void ParseExpression(){} // RVA: 0x7FFAC91A2470
        public void ParseOrExpr(){} // RVA: 0x7FFAC91A2630
        public void ParseAndExpr(){} // RVA: 0x7FFAC91A27A0
        public void ParseEqualityExpr(){} // RVA: 0x7FFAC91A2910
        public void ParseRelationalExpr(){} // RVA: 0x7FFAC91A2A20
        public void ParseAdditiveExpr(){} // RVA: 0x7FFAC91A2B50
        public void ParseMultiplicativeExpr(){} // RVA: 0x7FFAC91A2C60
        public void ParseUnaryExpr(){} // RVA: 0x7FFAC91A2E70
        public void ParseUnionExpr(){} // RVA: 0x7FFAC91A2F80
        public void IsNodeType(){} // RVA: 0x7FFAC91A3160
        public void ParsePathExpr(){} // RVA: 0x7FFAC91A3300
        public void ParseFilterExpr(){} // RVA: 0x7FFAC91A3680
        public void ParsePredicate(){} // RVA: 0x7FFAC91A37C0
        public void ParseLocationPath(){} // RVA: 0x7FFAC91A3870
        public void ParseRelativeLocationPath(){} // RVA: 0x7FFAC91A39D0
        public void IsStep(){} // RVA: 0x7FFAC91A3B10
        public void ParseStep(){} // RVA: 0x7FFAC91A3B40
        public void ParseNodeTest(){} // RVA: 0x7FFAC91A3E60
        public void IsPrimaryExpr(){} // RVA: 0x7FFAC91A42C0
        public void ParsePrimaryExpr(){} // RVA: 0x7FFAC91A4350
        public void ParseMethod(){} // RVA: 0x7FFAC91A4720
        public void CheckToken(){} // RVA: 0x7FFAC91A5010
        public void PassToken(){} // RVA: 0x7FFAC91A5090
        public void NextLex(){} // RVA: 0x7FFAC91A50C0
        public void TestOp(){} // RVA: 0x7FFAC91A50E0
        public void CheckNodeSet(){} // RVA: 0x7FFAC91A5150
        public void CreateFunctionTable(){} // RVA: 0x7FFAC91A51C0
        public void CreateAxesTable(){} // RVA: 0x7FFAC91A6880
        public void GetAxis(){} // RVA: 0x7FFAC91A6D30
        public void .cctor(){} // RVA: 0x7FFAC91A6E50
    }

    public class XPathScanner : Object
    {
        public string SourceText; // 0x10
        public int CurrentChar; // 0x18
        public 0x6B1665A0 Kind; // 0x1C
        public char Name; // 0x20
        public string Prefix; // 0x28
        public string StringValue; // 0x30
        public string NumberValue; // 0x38
        public double CanBeFunction; // 0x40
        public bool _canBeFunction; // 0x48
        public System.Xml.XmlCharType _xmlCharType; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91A7550
        public void get_SourceText(){} // RVA: 0x7FFAC2F3C380
        public void get_CurrentChar(){} // RVA: 0x7FFAC6D68C80
        public void NextChar(){} // RVA: 0x7FFAC91A7690
        public void get_Kind(){} // RVA: 0x7FFAC44357F0
        public void get_Name(){} // RVA: 0x7FFAC2F4F130
        public void get_Prefix(){} // RVA: 0x7FFAC31D95E0
        public void get_StringValue(){} // RVA: 0x7FFAC31D0140
        public void get_NumberValue(){} // RVA: 0x7FFAC4A87CB0
        public void get_CanBeFunction(){} // RVA: 0x7FFAC2FD8D30
        public void SkipSpace(){} // RVA: 0x7FFAC91A7700
        public void NextLex(){} // RVA: 0x7FFAC91A7780
        public void ScanNumber(){} // RVA: 0x7FFAC91A7DC0
        public void ScanFraction(){} // RVA: 0x7FFAC91A7F60
        public void ScanString(){} // RVA: 0x7FFAC91A8040
        public void ScanName(){} // RVA: 0x7FFAC91A8190
    }

}