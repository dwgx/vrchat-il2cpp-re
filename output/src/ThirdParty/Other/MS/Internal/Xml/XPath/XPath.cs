// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MS.Internal.Xml.XPath
// Classes: 11
// Methods: 86

namespace ThirdParty.Other.MS.Internal.Xml.XPath
{
    public class AstNode : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x87C130
        public void get_ReturnType(){} // RVA: 0x87C130
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Axis : AstNode
    {
        public object _axisType;
        public object _input;
        public object _prefix;
        public object _name;
        public object _nodeType;
        public object abbrAxis;
        public object _urn;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7470840
        public void get_Type(){} // RVA: 0xDAC980
        public void get_ReturnType(){} // RVA: 0x12FC4A0
        public void get_Input(){} // RVA: 0xB465B0
        public void set_Input(){} // RVA: 0xBA9BA0
        public void get_Prefix(){} // RVA: 0xB700F0
        public void get_Name(){} // RVA: 0xB70160
        public void get_NodeType(){} // RVA: 0xB9E080
        public void get_TypeOfAxis(){} // RVA: 0xB8F8F0
        public void get_AbbrAxis(){} // RVA: 0xB78D60
        public void get_Urn(){} // RVA: 0xD05CA0
        public void set_Urn(){} // RVA: 0xD09D70
    }

    public class Filter : AstNode
    {
        public object _input;
        public object _condition;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_Type(){} // RVA: 0xC50A80
        public void get_ReturnType(){} // RVA: 0x12FC4A0
    }

    public class Function : AstNode
    {
        public object _functionType;
        public object _argumentList;
        public object _name;
        public object _prefix;
        public object ReturnTypes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7470B00
        public void get_Type(){} // RVA: 0x1347420
        public void get_ReturnType(){} // RVA: 0x7470BF0
        public void .cctor(){} // RVA: 0x7470C70
    }

    public class Group : AstNode
    {
        public object _groupNode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Type(){} // RVA: 0xEF4110
        public void get_ReturnType(){} // RVA: 0x12FC4A0
    }

    public class Operand : AstNode
    {
        public object _type;
        public object _val;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7470DB0
        public void get_Type(){} // RVA: 0x12FC4A0
        public void get_ReturnType(){} // RVA: 0xB8F8F0
    }

    public class Operator : AstNode
    {
        public object s_invertOp;
        public object _opType;
        public object _opnd1;
        public object _opnd2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x38BA2E0
        public void get_Type(){} // RVA: 0xC3CCE0
        public void get_ReturnType(){} // RVA: 0x7470E30
        public void .cctor(){} // RVA: 0x7470E50
    }

    public class Root : AstNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Type(){} // RVA: 0x13510C0
        public void get_ReturnType(){} // RVA: 0x12FC4A0
    }

    public class Variable : AstNode
    {
        public object _localname;
        public object _prefix;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_Type(){} // RVA: 0x132D270
        public void get_ReturnType(){} // RVA: 0xEF4110
    }

    public class XPathParser : Object
    {
        public object _scanner;
        public object _parseDepth;
        public object s_temparray1;
        public object s_temparray2;
        public object s_temparray3;
        public object s_temparray4;
        public object s_temparray5;
        public object s_temparray6;
        public object s_temparray7;
        public object s_temparray8;
        public object s_temparray9;
        public object s_functionTable;
        public object s_AxesTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ParseXPathExpression(){} // RVA: 0x7470F30
        public void ParseExpression(){} // RVA: 0x7471170
        public void ParseOrExpr(){} // RVA: 0x7471330
        public void ParseAndExpr(){} // RVA: 0x74714A0
        public void ParseEqualityExpr(){} // RVA: 0x7471610
        public void ParseRelationalExpr(){} // RVA: 0x7471720
        public void ParseAdditiveExpr(){} // RVA: 0x7471850
        public void ParseMultiplicativeExpr(){} // RVA: 0x7471960
        public void ParseUnaryExpr(){} // RVA: 0x7471B60
        public void ParseUnionExpr(){} // RVA: 0x7471CD0
        public void IsNodeType(){} // RVA: 0x7471EB0
        public void ParsePathExpr(){} // RVA: 0x7472050
        public void ParseFilterExpr(){} // RVA: 0x7472420
        public void ParsePredicate(){} // RVA: 0x7472560
        public void ParseLocationPath(){} // RVA: 0x7472610
        public void ParseRelativeLocationPath(){} // RVA: 0x74727A0
        public void IsStep(){} // RVA: 0x74728C0
        public void ParseStep(){} // RVA: 0x74728F0
        public void ParseNodeTest(){} // RVA: 0x7472C30
        public void IsPrimaryExpr(){} // RVA: 0x7473070
        public void ParsePrimaryExpr(){} // RVA: 0x7473100
        public void ParseMethod(){} // RVA: 0x74734D0
        public void CheckToken(){} // RVA: 0x7473E00
        public void PassToken(){} // RVA: 0x7473E80
        public void NextLex(){} // RVA: 0x7473EB0
        public void TestOp(){} // RVA: 0x7473ED0
        public void CheckNodeSet(){} // RVA: 0x7473F40
        public void CreateFunctionTable(){} // RVA: 0x7473FB0
        public void CreateAxesTable(){} // RVA: 0x7475670
        public void GetAxis(){} // RVA: 0x7475B20
        public void .cctor(){} // RVA: 0x7475C40
    }

    public class XPathScanner : Object
    {
        public object _xpathExpr;
        public object _xpathExprIndex;
        public object _kind;
        public object _currentChar;
        public object _name;
        public object _prefix;
        public object _stringValue;
        public object _numberValue;
        public object _canBeFunction;
        public object _xmlCharType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7476340
        public void get_SourceText(){} // RVA: 0xB5DBF0
        public void get_CurrentChar(){} // RVA: 0x4FEF950
        public void NextChar(){} // RVA: 0x7476470
        public void get_Kind(){} // RVA: 0x2244FB0
        public void get_Name(){} // RVA: 0xB70160
        public void get_Prefix(){} // RVA: 0xD33E60
        public void get_StringValue(){} // RVA: 0xD05CA0
        public void get_NumberValue(){} // RVA: 0x27EAE50
        public void get_CanBeFunction(){} // RVA: 0xBFDA40
        public void SkipSpace(){} // RVA: 0x74764E0
        public void NextLex(){} // RVA: 0x7476560
        public void ScanNumber(){} // RVA: 0x7476B80
        public void ScanFraction(){} // RVA: 0x7476D10
        public void ScanString(){} // RVA: 0x7476DF0
        public void ScanName(){} // RVA: 0x7476F40
    }

}