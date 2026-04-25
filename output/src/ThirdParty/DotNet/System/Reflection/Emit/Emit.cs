// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection.Emit
// Classes: 20
// Methods: 210

namespace ThirdParty.DotNet.System.Reflection.Emit
{
    public class AssemblyBuilder : Assembly
    {
    }

    public class ConstructorBuilder : ConstructorInfo
    {
        public object Attributes;
        public object DeclaringType;
        public object Name;
        public object MethodHandle;
        public object ReflectedType;

        // ── Methods ──
        public void get_Attributes(){} // RVA: 0x7FFAC853B4E0
        public void get_DeclaringType(){} // RVA: 0x7FFAC853B520
        public void get_Name(){} // RVA: 0x7FFAC853B560
        public void GetParameters(){} // RVA: 0x7FFAC853B5A0
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFAC853B5E0
        public void get_MethodHandle(){} // RVA: 0x7FFAC853B620
        public void Invoke(){} // RVA: 0x7FFAC853B7A0 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFAC853B6A0
        public void GetCustomAttributes(){} // RVA: 0x7FFAC853B720 | overloaded x2
        public void get_ReflectedType(){} // RVA: 0x7FFAC853B760
    }

    public class DynamicMethod : MethodInfo
    {
        public object Attributes;
        public object CallingConvention;
        public object DeclaringType;
        public object Module;
        public object Name;
        public object ReturnParameter;
        public object ReturnType;
        public object MethodHandle;
        public object ReflectedType;
        public object ReturnTypeCustomAttributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC853B7E0
        public void get_Attributes(){} // RVA: 0x7FFAC853B820
        public void get_CallingConvention(){} // RVA: 0x7FFAC853B860
        public void get_DeclaringType(){} // RVA: 0x7FFAC853B8A0
        public void get_Module(){} // RVA: 0x7FFAC853B8E0
        public void get_Name(){} // RVA: 0x7FFAC853B920
        public void get_ReturnParameter(){} // RVA: 0x7FFAC853B960
        public void get_ReturnType(){} // RVA: 0x7FFAC853B9A0
        public void GetILGenerator(){} // RVA: 0x7FFAC853B9E0
        public void GetParameters(){} // RVA: 0x7FFAC853BA20
        public void get_MethodHandle(){} // RVA: 0x7FFAC853BA60
        public void get_ReflectedType(){} // RVA: 0x7FFAC853BAA0
        public void get_ReturnTypeCustomAttributes(){} // RVA: 0x7FFAC853BAE0
        public void CreateDelegate(){} // RVA: 0x7FFAC853BB60 | overloaded x2
        public void GetCustomAttributes(){} // RVA: 0x7FFAC853BBE0 | overloaded x2
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFAC853BC20
        public void GetBaseDefinition(){} // RVA: 0x7FFAC853BC60
        public void Invoke(){} // RVA: 0x7FFAC853BCA0
        public void IsDefined(){} // RVA: 0x7FFAC853BCE0
        public void ToString(){} // RVA: 0x7FFAC853BD20
    }

    public class EnumBuilder : TypeInfo
    {
        public object Assembly;
        public object AssemblyQualifiedName;
        public object BaseType;
        public object FullName;
        public object GUID;
        public object Module;
        public object Name;
        public object Namespace;
        public object UnderlyingSystemType;

        // ── Methods ──
        public void get_Assembly(){} // RVA: 0x7FFAC853BD60
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFAC853BDA0
        public void get_BaseType(){} // RVA: 0x7FFAC853BDE0
        public void get_FullName(){} // RVA: 0x7FFAC853BE20
        public void get_GUID(){} // RVA: 0x7FFAC853BE60
        public void get_Module(){} // RVA: 0x7FFAC853BEA0
        public void get_Name(){} // RVA: 0x7FFAC853BEE0
        public void get_Namespace(){} // RVA: 0x7FFAC853BF20
        public void get_UnderlyingSystemType(){} // RVA: 0x7FFAC853BF60
        public void GetAttributeFlagsImpl(){} // RVA: 0x7FFAC853BFA0
        public void GetConstructorImpl(){} // RVA: 0x7FFAC853BFE0
        public void GetConstructors(){} // RVA: 0x7FFAC853C020
        public void GetCustomAttributes(){} // RVA: 0x7FFAC853C0A0 | overloaded x2
        public void GetElementType(){} // RVA: 0x7FFAC853C0E0
        public void GetEvent(){} // RVA: 0x7FFAC853C120
        public void GetEvents(){} // RVA: 0x7FFAC853C160
        public void GetField(){} // RVA: 0x7FFAC853C1A0
        public void GetFields(){} // RVA: 0x7FFAC853C1E0
        public void GetInterface(){} // RVA: 0x7FFAC853C220
        public void GetInterfaces(){} // RVA: 0x7FFAC853C260
        public void GetMembers(){} // RVA: 0x7FFAC853C2A0
        public void GetMethodImpl(){} // RVA: 0x7FFAC853C2E0
        public void GetMethods(){} // RVA: 0x7FFAC853C320
        public void GetNestedType(){} // RVA: 0x7FFAC853C360
        public void GetProperties(){} // RVA: 0x7FFAC853C3A0
        public void GetPropertyImpl(){} // RVA: 0x7FFAC853C3E0
        public void HasElementTypeImpl(){} // RVA: 0x7FFAC853C420
        public void InvokeMember(){} // RVA: 0x7FFAC853C460
        public void IsArrayImpl(){} // RVA: 0x7FFAC853C4A0
        public void IsByRefImpl(){} // RVA: 0x7FFAC853C4E0
        public void IsCOMObjectImpl(){} // RVA: 0x7FFAC853C520
        public void IsDefined(){} // RVA: 0x7FFAC853C560
        public void IsPointerImpl(){} // RVA: 0x7FFAC853C5A0
        public void IsPrimitiveImpl(){} // RVA: 0x7FFAC853C5E0
    }

    public class EventBuilder : Object
    {
    }

    public class FieldBuilder : FieldInfo
    {
        public object Attributes;
        public object DeclaringType;
        public object FieldHandle;
        public object FieldType;
        public object Name;
        public object ReflectedType;

        // ── Methods ──
        public void get_Attributes(){} // RVA: 0x7FFAC853C620
        public void get_DeclaringType(){} // RVA: 0x7FFAC853C620
        public void get_FieldHandle(){} // RVA: 0x7FFAC853C620
        public void get_FieldType(){} // RVA: 0x7FFAC853C620
        public void get_Name(){} // RVA: 0x7FFAC853C620
        public void get_ReflectedType(){} // RVA: 0x7FFAC853C620
        public void GetCustomAttributes(){} // RVA: 0x7FFAC853C620 | overloaded x2
        public void GetValue(){} // RVA: 0x7FFAC853C620
        public void IsDefined(){} // RVA: 0x7FFAC853C620
        public void SetValue(){} // RVA: 0x7FFAC853C630
    }

    public class GenericTypeParameterBuilder : TypeInfo
    {
        public object Assembly;
        public object AssemblyQualifiedName;
        public object BaseType;
        public object FullName;
        public object GUID;
        public object Module;
        public object Name;
        public object Namespace;
        public object UnderlyingSystemType;

        // ── Methods ──
        public void get_Assembly(){} // RVA: 0x7FFAC853C670
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFAC853C6B0
        public void get_BaseType(){} // RVA: 0x7FFAC853C6F0
        public void get_FullName(){} // RVA: 0x7FFAC853C730
        public void get_GUID(){} // RVA: 0x7FFAC853C770
        public void get_Module(){} // RVA: 0x7FFAC853C7B0
        public void get_Name(){} // RVA: 0x7FFAC853C7F0
        public void get_Namespace(){} // RVA: 0x7FFAC853C830
        public void get_UnderlyingSystemType(){} // RVA: 0x7FFAC853C870
        public void GetAttributeFlagsImpl(){} // RVA: 0x7FFAC853C8B0
        public void GetConstructorImpl(){} // RVA: 0x7FFAC853C8F0
        public void GetConstructors(){} // RVA: 0x7FFAC853C930
        public void GetCustomAttributes(){} // RVA: 0x7FFAC853C9B0 | overloaded x2
        public void GetElementType(){} // RVA: 0x7FFAC853C9F0
        public void GetEvent(){} // RVA: 0x7FFAC853CA30
        public void GetEvents(){} // RVA: 0x7FFAC853CA70
        public void GetField(){} // RVA: 0x7FFAC853CAB0
        public void GetFields(){} // RVA: 0x7FFAC853CAF0
        public void GetInterface(){} // RVA: 0x7FFAC853CB30
        public void GetInterfaces(){} // RVA: 0x7FFAC853CB70
        public void GetMembers(){} // RVA: 0x7FFAC853CBB0
        public void GetMethodImpl(){} // RVA: 0x7FFAC853CBF0
        public void GetMethods(){} // RVA: 0x7FFAC853CC30
        public void GetNestedType(){} // RVA: 0x7FFAC853CC70
        public void GetProperties(){} // RVA: 0x7FFAC853CCB0
        public void GetPropertyImpl(){} // RVA: 0x7FFAC853CCF0
        public void HasElementTypeImpl(){} // RVA: 0x7FFAC853CD30
        public void InvokeMember(){} // RVA: 0x7FFAC853CD70
        public void IsArrayImpl(){} // RVA: 0x7FFAC853CDB0
        public void IsByRefImpl(){} // RVA: 0x7FFAC853CDF0
        public void IsCOMObjectImpl(){} // RVA: 0x7FFAC853CE30
        public void IsDefined(){} // RVA: 0x7FFAC853CE70
        public void IsPointerImpl(){} // RVA: 0x7FFAC853CEB0
        public void IsPrimitiveImpl(){} // RVA: 0x7FFAC853CEF0
    }

    public class ILGenerator : Object
    {
        public object ILOffset;

        // ── Methods ──
        public void get_ILOffset(){} // RVA: 0x7FFAC853CF30
        public void BeginExceptionBlock(){} // RVA: 0x7FFAC853CF70
        public void BeginFinallyBlock(){} // RVA: 0x7FFAC853CFB0
        public void DeclareLocal(){} // RVA: 0x7FFAC853CFF0
        public void DefineLabel(){} // RVA: 0x7FFAC853D030
        public void Emit(){} // RVA: 0x7FFAC853D230 | overloaded x8
        public void EndExceptionBlock(){} // RVA: 0x7FFAC853D270
        public void MarkLabel(){} // RVA: 0x7FFAC853D2B0
    }

    public class Label : ValueType
    {
        public int label; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4BF7E90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
    }

    public class LocalBuilder : LocalVariableInfo
    {
        public string name; // 0x20
        public System.Reflection.Emit.ILGenerator ilgen; // 0x28
        public int startOffset; // 0x30
        public int endOffset; // 0x34
    }

    public class MethodBuilder : MethodInfo
    {
        public object Attributes;
        public object DeclaringType;
        public object MethodHandle;
        public object Name;
        public object ReflectedType;
        public object ReturnTypeCustomAttributes;

        // ── Methods ──
        public void get_Attributes(){} // RVA: 0x7FFAC853D380
        public void get_DeclaringType(){} // RVA: 0x7FFAC853D3C0
        public void get_MethodHandle(){} // RVA: 0x7FFAC853D400
        public void get_Name(){} // RVA: 0x7FFAC853D440
        public void get_ReflectedType(){} // RVA: 0x7FFAC853D480
        public void get_ReturnTypeCustomAttributes(){} // RVA: 0x7FFAC853D4C0
        public void GetBaseDefinition(){} // RVA: 0x7FFAC853D500
        public void GetCustomAttributes(){} // RVA: 0x7FFAC853D580 | overloaded x2
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFAC853D5C0
        public void GetParameters(){} // RVA: 0x7FFAC853D600
        public void Invoke(){} // RVA: 0x7FFAC853D640
        public void IsDefined(){} // RVA: 0x7FFAC853D680
    }

    public class ModuleBuilder : Module
    {
    }

    public class OpCode : ValueType
    {
        public byte Name; // 0x10
        public byte Size; // 0x11
        public byte OpCodeType; // 0x12
        public byte OperandType; // 0x13
        public byte Value; // 0x14
        public byte type; // 0x15
        public byte args; // 0x16
        public byte flow; // 0x17

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC853D6C0
        public void GetHashCode(){} // RVA: 0x7FFAC853D700
        public void Equals(){} // RVA: 0x7FFAC853D7D0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC853D7F0
        public void get_Name(){} // RVA: 0x7FFAC853D800
        public void get_Size(){} // RVA: 0x7FFAC4A0B160
        public void get_OpCodeType(){} // RVA: 0x7FFAC4A0B150
        public void get_OperandType(){} // RVA: 0x7FFAC4B96900
        public void get_Value(){} // RVA: 0x7FFAC853D8C0
    }

    public class OpCodeNames : Object
    {
        public string[] names;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC853D8E0
    }

    public class OpCodes : Object
    {
        public System.Reflection.Emit.OpCode Nop;
        public System.Reflection.Emit.OpCode Break; // 0x8
        public System.Reflection.Emit.OpCode Ldarg_0; // 0x10
        public System.Reflection.Emit.OpCode Ldarg_1; // 0x18
        public System.Reflection.Emit.OpCode Ldarg_2; // 0x20
        public System.Reflection.Emit.OpCode Ldarg_3; // 0x28
        public System.Reflection.Emit.OpCode Ldloc_0; // 0x30
        public System.Reflection.Emit.OpCode Ldloc_1; // 0x38
        public System.Reflection.Emit.OpCode Ldloc_2; // 0x40
        public System.Reflection.Emit.OpCode Ldloc_3; // 0x48
        public System.Reflection.Emit.OpCode Stloc_0; // 0x50
        public System.Reflection.Emit.OpCode Stloc_1; // 0x58
        public System.Reflection.Emit.OpCode Stloc_2; // 0x60
        public System.Reflection.Emit.OpCode Stloc_3; // 0x68
        public System.Reflection.Emit.OpCode Ldarg_S; // 0x70
        public System.Reflection.Emit.OpCode Ldarga_S; // 0x78
        public System.Reflection.Emit.OpCode Starg_S; // 0x80
        public System.Reflection.Emit.OpCode Ldloc_S; // 0x88
        public System.Reflection.Emit.OpCode Ldloca_S; // 0x90
        public System.Reflection.Emit.OpCode Stloc_S; // 0x98
        public System.Reflection.Emit.OpCode Ldnull; // 0xA0
        public System.Reflection.Emit.OpCode Ldc_I4_M1; // 0xA8
        public System.Reflection.Emit.OpCode Ldc_I4_0; // 0xB0
        public System.Reflection.Emit.OpCode Ldc_I4_1; // 0xB8
        public System.Reflection.Emit.OpCode Ldc_I4_2; // 0xC0
        public System.Reflection.Emit.OpCode Ldc_I4_3; // 0xC8
        public System.Reflection.Emit.OpCode Ldc_I4_4; // 0xD0
        public System.Reflection.Emit.OpCode Ldc_I4_5; // 0xD8
        public System.Reflection.Emit.OpCode Ldc_I4_6; // 0xE0
        public System.Reflection.Emit.OpCode Ldc_I4_7; // 0xE8
        public System.Reflection.Emit.OpCode Ldc_I4_8; // 0xF0
        public System.Reflection.Emit.OpCode Ldc_I4_S; // 0xF8
        public System.Reflection.Emit.OpCode Ldc_I4; // 0x100
        public System.Reflection.Emit.OpCode Ldc_I8; // 0x108
        public System.Reflection.Emit.OpCode Ldc_R4; // 0x110
        public System.Reflection.Emit.OpCode Ldc_R8; // 0x118
        public System.Reflection.Emit.OpCode Dup; // 0x120
        public System.Reflection.Emit.OpCode Pop; // 0x128
        public System.Reflection.Emit.OpCode Jmp; // 0x130
        public System.Reflection.Emit.OpCode Call; // 0x138
        public System.Reflection.Emit.OpCode Calli; // 0x140
        public System.Reflection.Emit.OpCode Ret; // 0x148
        public System.Reflection.Emit.OpCode Br_S; // 0x150
        public System.Reflection.Emit.OpCode Brfalse_S; // 0x158
        public System.Reflection.Emit.OpCode Brtrue_S; // 0x160
        public System.Reflection.Emit.OpCode Beq_S; // 0x168
        public System.Reflection.Emit.OpCode Bge_S; // 0x170
        public System.Reflection.Emit.OpCode Bgt_S; // 0x178
        public System.Reflection.Emit.OpCode Ble_S; // 0x180
        public System.Reflection.Emit.OpCode Blt_S; // 0x188
        public System.Reflection.Emit.OpCode Bne_Un_S; // 0x190
        public System.Reflection.Emit.OpCode Bge_Un_S; // 0x198
        public System.Reflection.Emit.OpCode Bgt_Un_S; // 0x1A0
        public System.Reflection.Emit.OpCode Ble_Un_S; // 0x1A8
        public System.Reflection.Emit.OpCode Blt_Un_S; // 0x1B0
        public System.Reflection.Emit.OpCode Br; // 0x1B8
        public System.Reflection.Emit.OpCode Brfalse; // 0x1C0
        public System.Reflection.Emit.OpCode Brtrue; // 0x1C8
        public System.Reflection.Emit.OpCode Beq; // 0x1D0
        public System.Reflection.Emit.OpCode Bge; // 0x1D8
        public System.Reflection.Emit.OpCode Bgt; // 0x1E0
        public System.Reflection.Emit.OpCode Ble; // 0x1E8
        public System.Reflection.Emit.OpCode Blt; // 0x1F0
        public System.Reflection.Emit.OpCode Bne_Un; // 0x1F8
        public System.Reflection.Emit.OpCode Bge_Un; // 0x200
        public System.Reflection.Emit.OpCode Bgt_Un; // 0x208
        public System.Reflection.Emit.OpCode Ble_Un; // 0x210
        public System.Reflection.Emit.OpCode Blt_Un; // 0x218
        public System.Reflection.Emit.OpCode Switch; // 0x220
        public System.Reflection.Emit.OpCode Ldind_I1; // 0x228
        public System.Reflection.Emit.OpCode Ldind_U1; // 0x230
        public System.Reflection.Emit.OpCode Ldind_I2; // 0x238
        public System.Reflection.Emit.OpCode Ldind_U2; // 0x240
        public System.Reflection.Emit.OpCode Ldind_I4; // 0x248
        public System.Reflection.Emit.OpCode Ldind_U4; // 0x250
        public System.Reflection.Emit.OpCode Ldind_I8; // 0x258
        public System.Reflection.Emit.OpCode Ldind_I; // 0x260
        public System.Reflection.Emit.OpCode Ldind_R4; // 0x268
        public System.Reflection.Emit.OpCode Ldind_R8; // 0x270
        public System.Reflection.Emit.OpCode Ldind_Ref; // 0x278
        public System.Reflection.Emit.OpCode Stind_Ref; // 0x280
        public System.Reflection.Emit.OpCode Stind_I1; // 0x288
        public System.Reflection.Emit.OpCode Stind_I2; // 0x290
        public System.Reflection.Emit.OpCode Stind_I4; // 0x298
        public System.Reflection.Emit.OpCode Stind_I8; // 0x2A0
        public System.Reflection.Emit.OpCode Stind_R4; // 0x2A8
        public System.Reflection.Emit.OpCode Stind_R8; // 0x2B0
        public System.Reflection.Emit.OpCode Add; // 0x2B8
        public System.Reflection.Emit.OpCode Sub; // 0x2C0
        public System.Reflection.Emit.OpCode Mul; // 0x2C8
        public System.Reflection.Emit.OpCode Div; // 0x2D0
        public System.Reflection.Emit.OpCode Div_Un; // 0x2D8
        public System.Reflection.Emit.OpCode Rem; // 0x2E0
        public System.Reflection.Emit.OpCode Rem_Un; // 0x2E8
        public System.Reflection.Emit.OpCode And; // 0x2F0
        public System.Reflection.Emit.OpCode Or; // 0x2F8
        public System.Reflection.Emit.OpCode Xor; // 0x300
        public System.Reflection.Emit.OpCode Shl; // 0x308
        public System.Reflection.Emit.OpCode Shr; // 0x310
        public System.Reflection.Emit.OpCode Shr_Un; // 0x318
        public System.Reflection.Emit.OpCode Neg; // 0x320
        public System.Reflection.Emit.OpCode Not; // 0x328
        public System.Reflection.Emit.OpCode Conv_I1; // 0x330
        public System.Reflection.Emit.OpCode Conv_I2; // 0x338
        public System.Reflection.Emit.OpCode Conv_I4; // 0x340
        public System.Reflection.Emit.OpCode Conv_I8; // 0x348
        public System.Reflection.Emit.OpCode Conv_R4; // 0x350
        public System.Reflection.Emit.OpCode Conv_R8; // 0x358
        public System.Reflection.Emit.OpCode Conv_U4; // 0x360
        public System.Reflection.Emit.OpCode Conv_U8; // 0x368
        public System.Reflection.Emit.OpCode Callvirt; // 0x370
        public System.Reflection.Emit.OpCode Cpobj; // 0x378
        public System.Reflection.Emit.OpCode Ldobj; // 0x380
        public System.Reflection.Emit.OpCode Ldstr; // 0x388
        public System.Reflection.Emit.OpCode Newobj; // 0x390
        public System.Reflection.Emit.OpCode Castclass; // 0x398
        public System.Reflection.Emit.OpCode Isinst; // 0x3A0
        public System.Reflection.Emit.OpCode Conv_R_Un; // 0x3A8
        public System.Reflection.Emit.OpCode Unbox; // 0x3B0
        public System.Reflection.Emit.OpCode Throw; // 0x3B8
        public System.Reflection.Emit.OpCode Ldfld; // 0x3C0
        public System.Reflection.Emit.OpCode Ldflda; // 0x3C8
        public System.Reflection.Emit.OpCode Stfld; // 0x3D0
        public System.Reflection.Emit.OpCode Ldsfld; // 0x3D8
        public System.Reflection.Emit.OpCode Ldsflda; // 0x3E0
        public System.Reflection.Emit.OpCode Stsfld; // 0x3E8
        public System.Reflection.Emit.OpCode Stobj; // 0x3F0
        public System.Reflection.Emit.OpCode Conv_Ovf_I1_Un; // 0x3F8
        public System.Reflection.Emit.OpCode Conv_Ovf_I2_Un; // 0x400
        public System.Reflection.Emit.OpCode Conv_Ovf_I4_Un; // 0x408
        public System.Reflection.Emit.OpCode Conv_Ovf_I8_Un; // 0x410
        public System.Reflection.Emit.OpCode Conv_Ovf_U1_Un; // 0x418
        public System.Reflection.Emit.OpCode Conv_Ovf_U2_Un; // 0x420
        public System.Reflection.Emit.OpCode Conv_Ovf_U4_Un; // 0x428
        public System.Reflection.Emit.OpCode Conv_Ovf_U8_Un; // 0x430
        public System.Reflection.Emit.OpCode Conv_Ovf_I_Un; // 0x438
        public System.Reflection.Emit.OpCode Conv_Ovf_U_Un; // 0x440
        public System.Reflection.Emit.OpCode Box; // 0x448
        public System.Reflection.Emit.OpCode Newarr; // 0x450
        public System.Reflection.Emit.OpCode Ldlen; // 0x458
        public System.Reflection.Emit.OpCode Ldelema; // 0x460
        public System.Reflection.Emit.OpCode Ldelem_I1; // 0x468
        public System.Reflection.Emit.OpCode Ldelem_U1; // 0x470
        public System.Reflection.Emit.OpCode Ldelem_I2; // 0x478
        public System.Reflection.Emit.OpCode Ldelem_U2; // 0x480
        public System.Reflection.Emit.OpCode Ldelem_I4; // 0x488
        public System.Reflection.Emit.OpCode Ldelem_U4; // 0x490
        public System.Reflection.Emit.OpCode Ldelem_I8; // 0x498
        public System.Reflection.Emit.OpCode Ldelem_I; // 0x4A0
        public System.Reflection.Emit.OpCode Ldelem_R4; // 0x4A8
        public System.Reflection.Emit.OpCode Ldelem_R8; // 0x4B0
        public System.Reflection.Emit.OpCode Ldelem_Ref; // 0x4B8
        public System.Reflection.Emit.OpCode Stelem_I; // 0x4C0
        public System.Reflection.Emit.OpCode Stelem_I1; // 0x4C8
        public System.Reflection.Emit.OpCode Stelem_I2; // 0x4D0
        public System.Reflection.Emit.OpCode Stelem_I4; // 0x4D8
        public System.Reflection.Emit.OpCode Stelem_I8; // 0x4E0
        public System.Reflection.Emit.OpCode Stelem_R4; // 0x4E8
        public System.Reflection.Emit.OpCode Stelem_R8; // 0x4F0
        public System.Reflection.Emit.OpCode Stelem_Ref; // 0x4F8
        public System.Reflection.Emit.OpCode Ldelem; // 0x500
        public System.Reflection.Emit.OpCode Stelem; // 0x508
        public System.Reflection.Emit.OpCode Unbox_Any; // 0x510
        public System.Reflection.Emit.OpCode Conv_Ovf_I1; // 0x518
        public System.Reflection.Emit.OpCode Conv_Ovf_U1; // 0x520
        public System.Reflection.Emit.OpCode Conv_Ovf_I2; // 0x528
        public System.Reflection.Emit.OpCode Conv_Ovf_U2; // 0x530
        public System.Reflection.Emit.OpCode Conv_Ovf_I4; // 0x538
        public System.Reflection.Emit.OpCode Conv_Ovf_U4; // 0x540
        public System.Reflection.Emit.OpCode Conv_Ovf_I8; // 0x548
        public System.Reflection.Emit.OpCode Conv_Ovf_U8; // 0x550
        public System.Reflection.Emit.OpCode Refanyval; // 0x558
        public System.Reflection.Emit.OpCode Ckfinite; // 0x560
        public System.Reflection.Emit.OpCode Mkrefany; // 0x568
        public System.Reflection.Emit.OpCode Ldtoken; // 0x570
        public System.Reflection.Emit.OpCode Conv_U2; // 0x578
        public System.Reflection.Emit.OpCode Conv_U1; // 0x580
        public System.Reflection.Emit.OpCode Conv_I; // 0x588
        public System.Reflection.Emit.OpCode Conv_Ovf_I; // 0x590
        public System.Reflection.Emit.OpCode Conv_Ovf_U; // 0x598
        public System.Reflection.Emit.OpCode Add_Ovf; // 0x5A0
        public System.Reflection.Emit.OpCode Add_Ovf_Un; // 0x5A8
        public System.Reflection.Emit.OpCode Mul_Ovf; // 0x5B0
        public System.Reflection.Emit.OpCode Mul_Ovf_Un; // 0x5B8
        public System.Reflection.Emit.OpCode Sub_Ovf; // 0x5C0
        public System.Reflection.Emit.OpCode Sub_Ovf_Un; // 0x5C8
        public System.Reflection.Emit.OpCode Endfinally; // 0x5D0
        public System.Reflection.Emit.OpCode Leave; // 0x5D8
        public System.Reflection.Emit.OpCode Leave_S; // 0x5E0
        public System.Reflection.Emit.OpCode Stind_I; // 0x5E8
        public System.Reflection.Emit.OpCode Conv_U; // 0x5F0
        public System.Reflection.Emit.OpCode Prefix7; // 0x5F8
        public System.Reflection.Emit.OpCode Prefix6; // 0x600
        public System.Reflection.Emit.OpCode Prefix5; // 0x608
        public System.Reflection.Emit.OpCode Prefix4; // 0x610
        public System.Reflection.Emit.OpCode Prefix3; // 0x618
        public System.Reflection.Emit.OpCode Prefix2; // 0x620
        public System.Reflection.Emit.OpCode Prefix1; // 0x628
        public System.Reflection.Emit.OpCode Prefixref; // 0x630
        public System.Reflection.Emit.OpCode Arglist; // 0x638
        public System.Reflection.Emit.OpCode Ceq; // 0x640
        public System.Reflection.Emit.OpCode Cgt; // 0x648
        public System.Reflection.Emit.OpCode Cgt_Un; // 0x650
        public System.Reflection.Emit.OpCode Clt; // 0x658
        public System.Reflection.Emit.OpCode Clt_Un; // 0x660
        public System.Reflection.Emit.OpCode Ldftn; // 0x668
        public System.Reflection.Emit.OpCode Ldvirtftn; // 0x670
        public System.Reflection.Emit.OpCode Ldarg; // 0x678
        public System.Reflection.Emit.OpCode Ldarga; // 0x680
        public System.Reflection.Emit.OpCode Starg; // 0x688
        public System.Reflection.Emit.OpCode Ldloc; // 0x690
        public System.Reflection.Emit.OpCode Ldloca; // 0x698
        public System.Reflection.Emit.OpCode Stloc; // 0x6A0
        public System.Reflection.Emit.OpCode Localloc; // 0x6A8
        public System.Reflection.Emit.OpCode Endfilter; // 0x6B0
        public System.Reflection.Emit.OpCode Unaligned; // 0x6B8
        public System.Reflection.Emit.OpCode Volatile; // 0x6C0
        public System.Reflection.Emit.OpCode Tailcall; // 0x6C8
        public System.Reflection.Emit.OpCode Initobj; // 0x6D0
        public System.Reflection.Emit.OpCode Constrained; // 0x6D8
        public System.Reflection.Emit.OpCode Cpblk; // 0x6E0
        public System.Reflection.Emit.OpCode Initblk; // 0x6E8
        public System.Reflection.Emit.OpCode Rethrow; // 0x6F0
        public System.Reflection.Emit.OpCode Sizeof; // 0x6F8
        public System.Reflection.Emit.OpCode Refanytype; // 0x700
        public System.Reflection.Emit.OpCode Readonly; // 0x708

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC853FA50
    }

    public class ParameterBuilder : Object
    {
    }

    public class PropertyBuilder : PropertyInfo
    {
        public object Attributes;
        public object CanRead;
        public object CanWrite;
        public object DeclaringType;
        public object Name;
        public object PropertyType;
        public object ReflectedType;

        // ── Methods ──
        public void get_Attributes(){} // RVA: 0x7FFAC8541D20
        public void get_CanRead(){} // RVA: 0x7FFAC8541D60
        public void get_CanWrite(){} // RVA: 0x7FFAC8541DA0
        public void get_DeclaringType(){} // RVA: 0x7FFAC8541DE0
        public void get_Name(){} // RVA: 0x7FFAC8541E20
        public void get_PropertyType(){} // RVA: 0x7FFAC8541E60
        public void get_ReflectedType(){} // RVA: 0x7FFAC8541EA0
        public void GetAccessors(){} // RVA: 0x7FFAC8541EE0
        public void GetCustomAttributes(){} // RVA: 0x7FFAC8541F60 | overloaded x2
        public void GetGetMethod(){} // RVA: 0x7FFAC8541FA0
        public void GetIndexParameters(){} // RVA: 0x7FFAC8541FE0
        public void GetSetMethod(){} // RVA: 0x7FFAC8542020
        public void GetValue(){} // RVA: 0x7FFAC8542060
        public void IsDefined(){} // RVA: 0x7FFAC85420A0
        public void SetValue(){} // RVA: 0x7FFAC85420E0
    }

    public class SignatureHelper : Object
    {
    }

    public class TypeBuilder : TypeInfo
    {
        public int Assembly;

        // ── Methods ──
        public void get_Assembly(){} // RVA: 0x7FFAC8542120
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFAC8542160
        public void get_BaseType(){} // RVA: 0x7FFAC85421A0
        public void get_FullName(){} // RVA: 0x7FFAC85421E0
        public void get_GUID(){} // RVA: 0x7FFAC8542220
        public void get_Module(){} // RVA: 0x7FFAC8542260
        public void get_Name(){} // RVA: 0x7FFAC85422A0
        public void get_Namespace(){} // RVA: 0x7FFAC85422E0
        public void get_UnderlyingSystemType(){} // RVA: 0x7FFAC8542320
        public void GetAttributeFlagsImpl(){} // RVA: 0x7FFAC8542360
        public void GetConstructorImpl(){} // RVA: 0x7FFAC85423A0
        public void GetConstructors(){} // RVA: 0x7FFAC85423E0
        public void GetCustomAttributes(){} // RVA: 0x7FFAC8542460 | overloaded x2
        public void GetElementType(){} // RVA: 0x7FFAC85424A0
        public void GetEvent(){} // RVA: 0x7FFAC85424E0
        public void GetEvents(){} // RVA: 0x7FFAC8542520
        public void GetField(){} // RVA: 0x7FFAC8542560
        public void GetFields(){} // RVA: 0x7FFAC85425A0
        public void GetInterface(){} // RVA: 0x7FFAC85425E0
        public void GetInterfaces(){} // RVA: 0x7FFAC8542620
        public void GetMembers(){} // RVA: 0x7FFAC8542660
        public void GetMethodImpl(){} // RVA: 0x7FFAC85426A0
        public void GetMethods(){} // RVA: 0x7FFAC85426E0
        public void GetNestedType(){} // RVA: 0x7FFAC8542720
        public void GetProperties(){} // RVA: 0x7FFAC8542760
        public void GetPropertyImpl(){} // RVA: 0x7FFAC85427A0
        public void HasElementTypeImpl(){} // RVA: 0x7FFAC85427E0
        public void InvokeMember(){} // RVA: 0x7FFAC8542820
        public void IsArrayImpl(){} // RVA: 0x7FFAC8542860
        public void IsByRefImpl(){} // RVA: 0x7FFAC85428A0
        public void IsCOMObjectImpl(){} // RVA: 0x7FFAC85428E0
        public void IsDefined(){} // RVA: 0x7FFAC8542920
        public void IsPointerImpl(){} // RVA: 0x7FFAC8542960
        public void IsPrimitiveImpl(){} // RVA: 0x7FFAC85429A0
    }

    public class UnmanagedMarshal : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}