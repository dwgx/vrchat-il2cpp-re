// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MS.Internal.Xml.XPath
// Classes: 11
// Methods: 90

namespace ThirdParty.Other.MS.Internal.Xml.XPath
{
    public class AstNode
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0xD840
        public void get_ReturnType(){} // RVA: 0xD840
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Axis
    {
        public 0x65881310 _axisType; // 0x10
        public MS.Internal.Xml.XPath.AstNode _input; // 0x18
        public string _prefix; // 0x20
        public string _name; // 0x28
        public 0x65878D00 _nodeType; // 0x30
        public bool abbrAxis; // 0x34
        public string _urn; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A0AF90 | overloaded x2
        public void get_Type(){} // RVA: 0x519240
        public void get_ReturnType(){} // RVA: 0xA308B0
        public void get_Input(){} // RVA: 0x2E07C0
        public void set_Input(){} // RVA: 0x343E80
        public void get_Prefix(){} // RVA: 0x30B0C0
        public void get_Name(){} // RVA: 0x30B130
        public void get_NodeType(){} // RVA: 0x338CD0
        public void get_TypeOfAxis(){} // RVA: 0x32A5C0
        public void get_AbbrAxis(){} // RVA: 0x313C20
        public void get_Urn(){} // RVA: 0x4976A0
        public void set_Urn(){} // RVA: 0x49B830
    }

    public class Filter
    {
        public MS.Internal.Xml.XPath.AstNode _input; // 0x10
        public MS.Internal.Xml.XPath.AstNode _condition; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void get_Type(){} // RVA: 0x3E2CB0
        public void get_ReturnType(){} // RVA: 0xA308B0
    }

    public class Function
    {
        public 0x65881418 _functionType; // 0x10
        public System.Collections.Generic.List`1<MS.Internal.Xml.XPath.AstNode> _argumentList; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A0B270 | overloaded x3
        public void get_Type(){} // RVA: 0xA7E130
        public void get_ReturnType(){} // RVA: 0x6A0B360
        public void .cctor(){} // RVA: 0x6A0B3E0
    }

    public class Group
    {
        public MS.Internal.Xml.XPath.AstNode _groupNode; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Type(){} // RVA: 0x66CCC0
        public void get_ReturnType(){} // RVA: 0xA308B0
    }

    public class Operand
    {
        public 0x65878B48 _type; // 0x10
        public object _val; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A0B520 | overloaded x2
        public void get_Type(){} // RVA: 0xA308B0
        public void get_ReturnType(){} // RVA: 0x32A5C0
    }

    public class Operator
    {
        public 0x65881578[] s_invertOp;
        public 0x65881578 _opType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E766D0
        public void get_Type(){} // RVA: 0x3CFAF0
        public void get_ReturnType(){} // RVA: 0x6A0B5D0
        public void .cctor(){} // RVA: 0x6A0B5F0
    }

    public class Root
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Type(){} // RVA: 0xA850E0
        public void get_ReturnType(){} // RVA: 0xA308B0
    }

    public class Variable
    {
        public string _localname; // 0x10
        public string _prefix; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void get_Type(){} // RVA: 0xA67BB0
        public void get_ReturnType(){} // RVA: 0x66CCC0
    }

    public class XPathParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ParseXPathExpression(){} // RVA: 0x6A0B6D0
        public void ParseExpression(){} // RVA: 0x6A0B920
        public void ParseOrExpr(){} // RVA: 0x6A0BAE0
        public void ParseAndExpr(){} // RVA: 0x6A0BC50
        public void ParseEqualityExpr(){} // RVA: 0x6A0BDC0
        public void ParseRelationalExpr(){} // RVA: 0x6A0BED0
        public void ParseAdditiveExpr(){} // RVA: 0x6A0C000
        public void ParseMultiplicativeExpr(){} // RVA: 0x6A0C110
        public void ParseUnaryExpr(){} // RVA: 0x6A0C320
        public void ParseUnionExpr(){} // RVA: 0x6A0C430
        public void IsNodeType(){} // RVA: 0x6A0C610
        public void ParsePathExpr(){} // RVA: 0x6A0C7B0
        public void ParseFilterExpr(){} // RVA: 0x6A0CB30
        public void ParsePredicate(){} // RVA: 0x6A0CC70
        public void ParseLocationPath(){} // RVA: 0x6A0CD20
        public void ParseRelativeLocationPath(){} // RVA: 0x6A0CE80
        public void IsStep(){} // RVA: 0x6A0CFC0
        public void ParseStep(){} // RVA: 0x6A0CFF0
        public void ParseNodeTest(){} // RVA: 0x6A0D310
        public void IsPrimaryExpr(){} // RVA: 0x6A0D770
        public void ParsePrimaryExpr(){} // RVA: 0x6A0D800
        public void ParseMethod(){} // RVA: 0x6A0DBD0
        public void CheckToken(){} // RVA: 0x6A0E4C0
        public void PassToken(){} // RVA: 0x6A0E540
        public void NextLex(){} // RVA: 0x6A0E570
        public void TestOp(){} // RVA: 0x6A0E590
        public void CheckNodeSet(){} // RVA: 0x6A0E600
        public void CreateFunctionTable(){} // RVA: 0x6A0E670
        public void CreateAxesTable(){} // RVA: 0x6A0FD30
        public void GetAxis(){} // RVA: 0x6A101E0
        public void .cctor(){} // RVA: 0x6A10300
    }

    public class XPathScanner
    {
        public string Value; // 0x10
        public int NodeType; // 0x18
        public 0x65881788 LocalName; // 0x1C
        public char NamespaceURI; // 0x20
        public string Prefix; // 0x28
        public string NameTable; // 0x30
        public string UnderlyingObject; // 0x38
        public double LineNumber; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A10A00
        public void get_SourceText(){} // RVA: 0x2F8380
        public void get_CurrentChar(){} // RVA: 0x44B4370
        public void NextChar(){} // RVA: 0x6A10B40
        public void get_Kind(){} // RVA: 0x197C3B0
        public void get_Name(){} // RVA: 0x30B130
        public void get_Prefix(){} // RVA: 0x6374D0
        public void get_StringValue(){} // RVA: 0x4976A0
        public void get_NumberValue(){} // RVA: 0x1F65E70
        public void get_CanBeFunction(){} // RVA: 0x394D30
        public void SkipSpace(){} // RVA: 0x6A10BB0
        public void NextLex(){} // RVA: 0x6A10C30
        public void ScanNumber(){} // RVA: 0x6A11270
        public void ScanFraction(){} // RVA: 0x6A11410
        public void ScanString(){} // RVA: 0x6A114F0
        public void ScanName(){} // RVA: 0x6A11640
    }

}