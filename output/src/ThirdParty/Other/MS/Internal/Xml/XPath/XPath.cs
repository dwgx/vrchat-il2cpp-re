// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MS.Internal.Xml.XPath
// Classes: 11
// Methods: 90

namespace ThirdParty.Other.MS.Internal.Xml.XPath
{
    public class AstNode
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF2ABD840
        public void get_ReturnType(){} // RVA: 0x7FFAF2ABD840
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Axis
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF94BAF90 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAF2FC9240
        public void get_ReturnType(){} // RVA: 0x7FFAF34E08B0
        public void get_Input(){} // RVA: 0x7FFAF2D907C0
        public void set_Input(){} // RVA: 0x7FFAF2DF3E80
        public void get_Prefix(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Name(){} // RVA: 0x7FFAF2DBB130
        public void get_NodeType(){} // RVA: 0x7FFAF2DE8CD0
        public void get_TypeOfAxis(){} // RVA: 0x7FFAF2DDA5C0
        public void get_AbbrAxis(){} // RVA: 0x7FFAF2DC3C20
        public void get_Urn(){} // RVA: 0x7FFAF2F476A0
        public void set_Urn(){} // RVA: 0x7FFAF2F4B830
    }

    public class Filter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void get_Type(){} // RVA: 0x7FFAF2E92CB0
        public void get_ReturnType(){} // RVA: 0x7FFAF34E08B0
    }

    public class Function
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF94BB270 | overloaded x3
        public void get_Type(){} // RVA: 0x7FFAF352E130
        public void get_ReturnType(){} // RVA: 0x7FFAF94BB360
        public void .cctor(){} // RVA: 0x7FFAF94BB3E0
    }

    public class Group
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_Type(){} // RVA: 0x7FFAF311CCC0
        public void get_ReturnType(){} // RVA: 0x7FFAF34E08B0
    }

    public class Operand
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF94BB520 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAF34E08B0
        public void get_ReturnType(){} // RVA: 0x7FFAF2DDA5C0
    }

    public class Operator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF59266D0
        public void get_Type(){} // RVA: 0x7FFAF2E7FAF0
        public void get_ReturnType(){} // RVA: 0x7FFAF94BB5D0
        public void .cctor(){} // RVA: 0x7FFAF94BB5F0
    }

    public class Root
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Type(){} // RVA: 0x7FFAF35350E0
        public void get_ReturnType(){} // RVA: 0x7FFAF34E08B0
    }

    public class Variable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void get_Type(){} // RVA: 0x7FFAF3517BB0
        public void get_ReturnType(){} // RVA: 0x7FFAF311CCC0
    }

    public class XPathParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void ParseXPathExpression(){} // RVA: 0x7FFAF94BB6D0
        public void ParseExpression(){} // RVA: 0x7FFAF94BB920
        public void ParseOrExpr(){} // RVA: 0x7FFAF94BBAE0
        public void ParseAndExpr(){} // RVA: 0x7FFAF94BBC50
        public void ParseEqualityExpr(){} // RVA: 0x7FFAF94BBDC0
        public void ParseRelationalExpr(){} // RVA: 0x7FFAF94BBED0
        public void ParseAdditiveExpr(){} // RVA: 0x7FFAF94BC000
        public void ParseMultiplicativeExpr(){} // RVA: 0x7FFAF94BC110
        public void ParseUnaryExpr(){} // RVA: 0x7FFAF94BC320
        public void ParseUnionExpr(){} // RVA: 0x7FFAF94BC430
        public void IsNodeType(){} // RVA: 0x7FFAF94BC610
        public void ParsePathExpr(){} // RVA: 0x7FFAF94BC7B0
        public void ParseFilterExpr(){} // RVA: 0x7FFAF94BCB30
        public void ParsePredicate(){} // RVA: 0x7FFAF94BCC70
        public void ParseLocationPath(){} // RVA: 0x7FFAF94BCD20
        public void ParseRelativeLocationPath(){} // RVA: 0x7FFAF94BCE80
        public void IsStep(){} // RVA: 0x7FFAF94BCFC0
        public void ParseStep(){} // RVA: 0x7FFAF94BCFF0
        public void ParseNodeTest(){} // RVA: 0x7FFAF94BD310
        public void IsPrimaryExpr(){} // RVA: 0x7FFAF94BD770
        public void ParsePrimaryExpr(){} // RVA: 0x7FFAF94BD800
        public void ParseMethod(){} // RVA: 0x7FFAF94BDBD0
        public void CheckToken(){} // RVA: 0x7FFAF94BE4C0
        public void PassToken(){} // RVA: 0x7FFAF94BE540
        public void NextLex(){} // RVA: 0x7FFAF94BE570
        public void TestOp(){} // RVA: 0x7FFAF94BE590
        public void CheckNodeSet(){} // RVA: 0x7FFAF94BE600
        public void CreateFunctionTable(){} // RVA: 0x7FFAF94BE670
        public void CreateAxesTable(){} // RVA: 0x7FFAF94BFD30
        public void GetAxis(){} // RVA: 0x7FFAF94C01E0
        public void .cctor(){} // RVA: 0x7FFAF94C0300
    }

    public class XPathScanner
    {
        public object Value;
        public object NodeType;
        public object LocalName;
        public object NamespaceURI;
        public object Prefix;
        public object NameTable;
        public object UnderlyingObject;
        public object LineNumber;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF94C0A00
        public void get_SourceText(){} // RVA: 0x7FFAF2DA8380
        public void get_CurrentChar(){} // RVA: 0x7FFAF6F64370
        public void NextChar(){} // RVA: 0x7FFAF94C0B40
        public void get_Kind(){} // RVA: 0x7FFAF442C3B0
        public void get_Name(){} // RVA: 0x7FFAF2DBB130
        public void get_Prefix(){} // RVA: 0x7FFAF30E74D0
        public void get_StringValue(){} // RVA: 0x7FFAF2F476A0
        public void get_NumberValue(){} // RVA: 0x7FFAF4A15E70
        public void get_CanBeFunction(){} // RVA: 0x7FFAF2E44D30
        public void SkipSpace(){} // RVA: 0x7FFAF94C0BB0
        public void NextLex(){} // RVA: 0x7FFAF94C0C30
        public void ScanNumber(){} // RVA: 0x7FFAF94C1270
        public void ScanFraction(){} // RVA: 0x7FFAF94C1410
        public void ScanString(){} // RVA: 0x7FFAF94C14F0
        public void ScanName(){} // RVA: 0x7FFAF94C1640
    }

}