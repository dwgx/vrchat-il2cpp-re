// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MS.Internal.Xml.XPath
// Classes: 11
// Methods: 90

namespace ThirdParty.Other.MS.Internal.Xml.XPath
{
    public class AstNode : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE80E2EDB0
        public void get_ReturnType(){} // RVA: 0x7FFE80E2EDB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Axis : AstNode
    {
        public 0x6655F1AC _axisType; // 0x10
        public MS.Internal.Xml.XPath.AstNode _input; // 0x18
        public string _prefix; // 0x20
        public string _name; // 0x28
        public 0x66556B9C _nodeType; // 0x30
        public bool abbrAxis; // 0x34
        public string _urn; // 0x38
        public object field_7; // 0x695
        public object field_8; // 0x696

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8754A290 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE813240E0
        public void get_ReturnType(){} // RVA: 0x7FFE817BF630
        public void get_Input(){} // RVA: 0x7FFE810FE7C0
        public void set_Input(){} // RVA: 0x7FFE81161E80
        public void get_Prefix(){} // RVA: 0x7FFE811290C0
        public void get_Name(){} // RVA: 0x7FFE81129130
        public void get_NodeType(){} // RVA: 0x7FFE81156CD0
        public void get_TypeOfAxis(){} // RVA: 0x7FFE811485C0
        public void get_AbbrAxis(){} // RVA: 0x7FFE81131C20
        public void get_Urn(){} // RVA: 0x7FFE8143BA80
        public void set_Urn(){} // RVA: 0x7FFE81437330
    }

    public class Filter : AstNode
    {
        public MS.Internal.Xml.XPath.AstNode _input; // 0x10
        public MS.Internal.Xml.XPath.AstNode _condition; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_Type(){} // RVA: 0x7FFE81200CB0
        public void get_ReturnType(){} // RVA: 0x7FFE817BF630
    }

    public class Function : AstNode
    {
        public 0x6655F2B4 _functionType; // 0x10
        public System.Collections.Generic.List`1<MS.Internal.Xml.XPath.AstNode> _argumentList; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8754A570 | overloaded x3
        public void get_Type(){} // RVA: 0x7FFE8180E590
        public void get_ReturnType(){} // RVA: 0x7FFE8754A660
        public void .cctor(){} // RVA: 0x7FFE8754A6E0
    }

    public class Group : AstNode
    {
        public MS.Internal.Xml.XPath.AstNode _groupNode; // 0x10
        public object field_1; // 0x6A2

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Type(){} // RVA: 0x7FFE81474A10
        public void get_ReturnType(){} // RVA: 0x7FFE817BF630
    }

    public class Operand : AstNode
    {
        public 0x665569E4 _type; // 0x10
        public object _val; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8754A820 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE817BF630
        public void get_ReturnType(){} // RVA: 0x7FFE811485C0
    }

    public class Operator : AstNode
    {
        public 0x6655F414[] s_invertOp;
        public 0x6655F414 _opType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83B45810
        public void get_Type(){} // RVA: 0x7FFE811EDAF0
        public void get_ReturnType(){} // RVA: 0x7FFE8754A8D0
        public void .cctor(){} // RVA: 0x7FFE8754A8F0
    }

    public class Root : AstNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Type(){} // RVA: 0x7FFE81815210
        public void get_ReturnType(){} // RVA: 0x7FFE817BF630
    }

    public class Variable : AstNode
    {
        public string _localname; // 0x10
        public string _prefix; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_Type(){} // RVA: 0x7FFE817F39D0
        public void get_ReturnType(){} // RVA: 0x7FFE81474A10
    }

    public class XPathParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ParseXPathExpression(){} // RVA: 0x7FFE8754A9D0
        public void ParseExpression(){} // RVA: 0x7FFE8754AC20
        public void ParseOrExpr(){} // RVA: 0x7FFE8754ADE0
        public void ParseAndExpr(){} // RVA: 0x7FFE8754AF50
        public void ParseEqualityExpr(){} // RVA: 0x7FFE8754B0C0
        public void ParseRelationalExpr(){} // RVA: 0x7FFE8754B1D0
        public void ParseAdditiveExpr(){} // RVA: 0x7FFE8754B300
        public void ParseMultiplicativeExpr(){} // RVA: 0x7FFE8754B410
        public void ParseUnaryExpr(){} // RVA: 0x7FFE8754B620
        public void ParseUnionExpr(){} // RVA: 0x7FFE8754B730
        public void IsNodeType(){} // RVA: 0x7FFE8754B910
        public void ParsePathExpr(){} // RVA: 0x7FFE8754BAB0
        public void ParseFilterExpr(){} // RVA: 0x7FFE8754BE30
        public void ParsePredicate(){} // RVA: 0x7FFE8754BF70
        public void ParseLocationPath(){} // RVA: 0x7FFE8754C020
        public void ParseRelativeLocationPath(){} // RVA: 0x7FFE8754C180
        public void IsStep(){} // RVA: 0x7FFE8754C2C0
        public void ParseStep(){} // RVA: 0x7FFE8754C2F0
        public void ParseNodeTest(){} // RVA: 0x7FFE8754C610
        public void IsPrimaryExpr(){} // RVA: 0x7FFE8754CA70
        public void ParsePrimaryExpr(){} // RVA: 0x7FFE8754CB00
        public void ParseMethod(){} // RVA: 0x7FFE8754CED0
        public void CheckToken(){} // RVA: 0x7FFE8754D7C0
        public void PassToken(){} // RVA: 0x7FFE8754D840
        public void NextLex(){} // RVA: 0x7FFE8754D870
        public void TestOp(){} // RVA: 0x7FFE8754D890
        public void CheckNodeSet(){} // RVA: 0x7FFE8754D900
        public void CreateFunctionTable(){} // RVA: 0x7FFE8754D970
        public void CreateAxesTable(){} // RVA: 0x7FFE8754F030
        public void GetAxis(){} // RVA: 0x7FFE8754F4E0
        public void .cctor(){} // RVA: 0x7FFE8754F600
    }

    public class XPathScanner : Object
    {
        public string _xpathExpr; // 0x10
        public int _xpathExprIndex; // 0x18
        public 0x6655F624 _kind; // 0x1C
        public char _currentChar; // 0x20
        public string _name; // 0x28
        public string _prefix; // 0x30
        public string _stringValue; // 0x38
        public double _numberValue; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8754FD00
        public void get_SourceText(){} // RVA: 0x7FFE81116380
        public void get_CurrentChar(){} // RVA: 0x7FFE850EF1D0
        public void NextChar(){} // RVA: 0x7FFE8754FE40
        public void get_Kind(){} // RVA: 0x7FFE82707EE0
        public void get_Name(){} // RVA: 0x7FFE81129130
        public void get_Prefix(){} // RVA: 0x7FFE8144E200
        public void get_StringValue(){} // RVA: 0x7FFE8143BA80
        public void get_NumberValue(){} // RVA: 0x7FFE82CF0830
        public void get_CanBeFunction(){} // RVA: 0x7FFE811B2D30
        public void SkipSpace(){} // RVA: 0x7FFE8754FEB0
        public void NextLex(){} // RVA: 0x7FFE8754FF30
        public void ScanNumber(){} // RVA: 0x7FFE87550570
        public void ScanFraction(){} // RVA: 0x7FFE87550710
        public void ScanString(){} // RVA: 0x7FFE875507F0
        public void ScanName(){} // RVA: 0x7FFE87550940
    }

}