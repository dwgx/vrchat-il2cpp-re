// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 7
// Methods: 94

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class CachedReflectionInfo
    {
        public System.Reflection.MethodInfo CanReduce;
        public System.Reflection.ConstructorInfo Right; // 0x8
        public System.Reflection.MethodInfo Left; // 0x10
        public System.Reflection.MethodInfo Method; // 0x18
        public System.Reflection.MethodInfo Conversion; // 0x20
        public System.Reflection.MethodInfo IsLifted; // 0x28
        public System.Reflection.MethodInfo IsLiftedToNull; // 0x30
        public System.Reflection.MethodInfo IsLiftedLogical; // 0x38
        public System.Reflection.MethodInfo IsReferenceComparison; // 0x40
        public System.Reflection.MethodInfo _nodeType; // 0x48
        public System.Reflection.MethodInfo .ctor; // 0x50
        public System.Reflection.MethodInfo g5T; // 0x58
        public System.Reflection.MethodInfo .ctor; // 0x60
        public System.Reflection.MethodInfo get_Type; // 0x68
        public System.Reflection.MethodInfo get_NodeType; // 0x70
        public System.Reflection.MethodInfo s_DynamicObject_TryDeleteMember; // 0x78
        public System.Reflection.MethodInfo s_DynamicObject_TryGetIndex; // 0x80
        public System.Reflection.MethodInfo s_DynamicObject_TrySetIndex; // 0x88
        public System.Reflection.MethodInfo s_DynamicObject_TryDeleteIndex; // 0x90
        public System.Reflection.MethodInfo s_DynamicObject_TryConvert; // 0x98
        public System.Reflection.MethodInfo s_DynamicObject_TryInvoke; // 0xA0
        public System.Reflection.MethodInfo s_DynamicObject_TryInvokeMember; // 0xA8
        public System.Reflection.MethodInfo s_DynamicObject_TryBinaryOperation; // 0xB0
        public System.Reflection.MethodInfo s_DynamicObject_TryUnaryOperation; // 0xB8
        public System.Reflection.MethodInfo s_DynamicObject_TryCreateInstance; // 0xC0
        public System.Reflection.ConstructorInfo s_Nullable_Boolean_Ctor; // 0xC8
        public System.Reflection.ConstructorInfo s_Decimal_Ctor_Int32; // 0xD0
        public System.Reflection.ConstructorInfo s_Decimal_Ctor_UInt32; // 0xD8
        public System.Reflection.ConstructorInfo s_Decimal_Ctor_Int64; // 0xE0
        public System.Reflection.ConstructorInfo s_Decimal_Ctor_UInt64; // 0xE8
        public System.Reflection.ConstructorInfo s_Decimal_Ctor_Int32_Int32_Int32_Bool_Byte; // 0xF0
        public System.Reflection.FieldInfo s_Decimal_One; // 0xF8
        public System.Reflection.FieldInfo s_Decimal_MinusOne; // 0x100
        public System.Reflection.FieldInfo s_Decimal_MinValue; // 0x108
        public System.Reflection.FieldInfo s_Decimal_MaxValue; // 0x110
        public System.Reflection.FieldInfo s_Decimal_Zero; // 0x118
        public System.Reflection.FieldInfo s_DateTime_MinValue; // 0x120
        public System.Reflection.MethodInfo s_MethodBase_GetMethodFromHandle_RuntimeMethodHandle; // 0x128
        public System.Reflection.MethodInfo s_MethodBase_GetMethodFromHandle_RuntimeMethodHandle_RuntimeTypeHandle; // 0x130
        public System.Reflection.MethodInfo s_MethodInfo_CreateDelegate_Type_Object; // 0x138
        public System.Reflection.MethodInfo s_String_op_Equality_String_String; // 0x140
        public System.Reflection.MethodInfo s_String_Equals_String_String; // 0x148
        public System.Reflection.MethodInfo s_DictionaryOfStringInt32_Add_String_Int32; // 0x150
        public System.Reflection.ConstructorInfo s_DictionaryOfStringInt32_Ctor_Int32; // 0x158
        public System.Reflection.MethodInfo s_Type_GetTypeFromHandle; // 0x160
        public System.Reflection.MethodInfo s_Object_GetType; // 0x168
        public System.Reflection.MethodInfo s_Decimal_op_Implicit_Byte; // 0x170
        public System.Reflection.MethodInfo s_Decimal_op_Implicit_SByte; // 0x178
        public System.Reflection.MethodInfo s_Decimal_op_Implicit_Int16; // 0x180
        public System.Reflection.MethodInfo s_Decimal_op_Implicit_UInt16; // 0x188
        public System.Reflection.MethodInfo s_Decimal_op_Implicit_Int32; // 0x190
        public System.Reflection.MethodInfo s_Decimal_op_Implicit_UInt32; // 0x198
        public System.Reflection.MethodInfo s_Decimal_op_Implicit_Int64; // 0x1A0
        public System.Reflection.MethodInfo s_Decimal_op_Implicit_UInt64; // 0x1A8
        public System.Reflection.MethodInfo s_Decimal_op_Implicit_Char; // 0x1B0
        public System.Reflection.MethodInfo s_Math_Pow_Double_Double; // 0x1B8

        // ── Methods ──
        public void get_String_Format_String_ObjectArray(){} // RVA: 0x65A7E30
        public void get_InvalidCastException_Ctor_String(){} // RVA: 0x65A8070
        public void get_CallSiteOps_SetNotMatched(){} // RVA: 0x65A8250
        public void get_CallSiteOps_CreateMatchmaker(){} // RVA: 0x65A8410
        public void get_CallSiteOps_GetMatch(){} // RVA: 0x65A85D0
        public void get_CallSiteOps_ClearMatch(){} // RVA: 0x65A8790
        public void get_CallSiteOps_UpdateRules(){} // RVA: 0x65A8950
        public void get_CallSiteOps_GetRules(){} // RVA: 0x65A8B10
        public void get_CallSiteOps_GetRuleCache(){} // RVA: 0x65A8CD0
        public void get_CallSiteOps_GetCachedRules(){} // RVA: 0x65A8E90
        public void get_CallSiteOps_AddRule(){} // RVA: 0x65A9050
        public void get_CallSiteOps_MoveRule(){} // RVA: 0x65A9210
        public void get_CallSiteOps_Bind(){} // RVA: 0x65A93D0
        public void get_DynamicObject_TryGetMember(){} // RVA: 0x65A9590
        public void get_DynamicObject_TrySetMember(){} // RVA: 0x65A9750
        public void get_DynamicObject_TryDeleteMember(){} // RVA: 0x65A9910
        public void get_DynamicObject_TryGetIndex(){} // RVA: 0x65A9AD0
        public void get_DynamicObject_TrySetIndex(){} // RVA: 0x65A9C90
        public void get_DynamicObject_TryDeleteIndex(){} // RVA: 0x65A9E50
        public void get_DynamicObject_TryConvert(){} // RVA: 0x65AA010
        public void get_DynamicObject_TryInvoke(){} // RVA: 0x65AA1D0
        public void get_DynamicObject_TryInvokeMember(){} // RVA: 0x65AA390
        public void get_DynamicObject_TryBinaryOperation(){} // RVA: 0x65AA550
        public void get_DynamicObject_TryUnaryOperation(){} // RVA: 0x65AA710
        public void get_DynamicObject_TryCreateInstance(){} // RVA: 0x65AA8D0
        public void get_Nullable_Boolean_Ctor(){} // RVA: 0x65AAA90
        public void get_Decimal_Ctor_Int32(){} // RVA: 0x65AAC70
        public void get_Decimal_Ctor_UInt32(){} // RVA: 0x65AAE50
        public void get_Decimal_Ctor_Int64(){} // RVA: 0x65AB030
        public void get_Decimal_Ctor_UInt64(){} // RVA: 0x65AB210
        public void get_Decimal_Ctor_Int32_Int32_Int32_Bool_Byte(){} // RVA: 0x65AB3F0
        public void get_Decimal_One(){} // RVA: 0x65AB730
        public void get_Decimal_MinusOne(){} // RVA: 0x65AB880
        public void get_Decimal_MinValue(){} // RVA: 0x65AB9D0
        public void get_Decimal_MaxValue(){} // RVA: 0x65ABB20
        public void get_Decimal_Zero(){} // RVA: 0x65ABC70
        public void get_DateTime_MinValue(){} // RVA: 0x65ABDC0
        public void get_MethodBase_GetMethodFromHandle_RuntimeMethodHandle(){} // RVA: 0x65ABF10
        public void get_MethodBase_GetMethodFromHandle_RuntimeMethodHandle_RuntimeTypeHandle(){} // RVA: 0x65AC110
        public void get_MethodInfo_CreateDelegate_Type_Object(){} // RVA: 0x65AC370
        public void get_String_op_Equality_String_String(){} // RVA: 0x65AC5D0
        public void get_String_Equals_String_String(){} // RVA: 0x65AC810
        public void get_DictionaryOfStringInt32_Add_String_Int32(){} // RVA: 0x65ACA50
        public void get_DictionaryOfStringInt32_Ctor_Int32(){} // RVA: 0x65ACCB0
        public void get_Type_GetTypeFromHandle(){} // RVA: 0x65ACE90
        public void get_Object_GetType(){} // RVA: 0x65AD050
        public void get_Decimal_op_Implicit_Byte(){} // RVA: 0x65AD210
        public void get_Decimal_op_Implicit_SByte(){} // RVA: 0x65AD410
        public void get_Decimal_op_Implicit_Int16(){} // RVA: 0x65AD610
        public void get_Decimal_op_Implicit_UInt16(){} // RVA: 0x65AD810
        public void get_Decimal_op_Implicit_Int32(){} // RVA: 0x65ADA10
        public void get_Decimal_op_Implicit_UInt32(){} // RVA: 0x65ADC10
        public void get_Decimal_op_Implicit_Int64(){} // RVA: 0x65ADE10
        public void get_Decimal_op_Implicit_UInt64(){} // RVA: 0x65AE010
        public void get_Decimal_op_Implicit_Char(){} // RVA: 0x65AE210
        public void get_Math_Pow_Double_Double(){} // RVA: 0x65AE410
    }

    public class CatchBlock
    {
        public System.Linq.Expressions.ParameterExpression <Variable>k__BackingField; // 0x10
        public System.Type <Test>k__BackingField; // 0x18
        public System.Linq.Expressions.Expression <Body>k__BackingField; // 0x20
        public System.Linq.Expressions.Expression <Filter>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65DF800 | overloaded x2
        public void get_Variable(){} // RVA: 0x2F8380
        public void get_Test(){} // RVA: 0x2E07C0
        public void get_Body(){} // RVA: 0x30B0C0
        public void get_Filter(){} // RVA: 0x30B130
        public void ToString(){} // RVA: 0x65DF6D0
        public void Update(){} // RVA: 0x65DF760
    }

    public class ClearDebugInfoExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65E06C0
        public void get_IsClear(){} // RVA: 0x3C2850
        public void get_StartLine(){} // RVA: 0x65E06D0
        public void get_StartColumn(){} // RVA: 0x519240
        public void get_EndLine(){} // RVA: 0x65E06D0
        public void get_EndColumn(){} // RVA: 0x519240
    }

    public class CoalesceConversionBinaryExpression
    {
        public System.Linq.Expressions.LambdaExpression _conversion; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65B1000
        public void GetConversion(){} // RVA: 0x30B0C0
        public void get_NodeType(){} // RVA: 0xA67BB0
        public void get_Type(){} // RVA: 0x7F0250
    }

    public class ConditionalExpression
    {
        public System.Linq.Expressions.Expression <Test>k__BackingField; // 0x10
        public System.Linq.Expressions.Expression <IfTrue>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65E00C0 | overloaded x2
        public void Make(){} // RVA: 0x65DFD10
        public void get_NodeType(){} // RVA: 0xA63AE0
        public void get_Type(){} // RVA: 0x65B0FC0
        public void get_Test(){} // RVA: 0x2F8380
        public void get_IfTrue(){} // RVA: 0x2E07C0
        public void get_IfFalse(){} // RVA: 0x37EF790
        public void GetFalse(){} // RVA: 0x65DFF60
        public void Accept(){} // RVA: 0x65DFFC0
        public void Update(){} // RVA: 0x65DFFF0
    }

    public class ConstantCheck
    {
        // ── Methods ──
        public void IsNull(){} // RVA: 0x65DF830
        public void AnalyzeTypeIs(){} // RVA: 0x65DF9C0 | overloaded x2
    }

    public class ConstantExpression
    {
        public object <Value>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65E0330 | overloaded x2
        public void get_Type(){} // RVA: 0x65E0270
        public void get_NodeType(){} // RVA: 0x1730F70
        public void get_Value(){} // RVA: 0x2F8380
        public void Accept(){} // RVA: 0x65E0300
    }

}