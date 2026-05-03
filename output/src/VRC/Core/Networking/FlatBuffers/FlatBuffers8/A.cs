// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 14
// Methods: 101

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class AnimationState : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x11D
        public object field_2; // 0x11E
        public object field_3; // 0x11F

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsAnimationState(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Weight(){} // RVA: 0x7FFE88120470
        public void get_Time(){} // RVA: 0x7FFE8812C930
        public void get_Name(){} // RVA: 0x7FFE8812C980
        public void GetNameBytes(){} // RVA: 0x7FFE8812CA10
        public void GetNameArray(){} // RVA: 0x7FFE8812CA80
        public void CreateAnimationState(){} // RVA: 0x7FFE8812CAD0
        public void StartAnimationState(){} // RVA: 0x7FFE8812CD10
        public void AddWeight(){} // RVA: 0x7FFE881205B0
        public void AddTime(){} // RVA: 0x7FFE8812CD30
        public void AddName(){} // RVA: 0x7FFE8812CDA0
        public void EndAnimationState(){} // RVA: 0x7FFE8812CDE0
        public void UnPack(){} // RVA: 0x7FFE8812CF40
        public void UnPackTo(){} // RVA: 0x7FFE8812CFF0
        public void Pack(){} // RVA: 0x7FFE8812D0E0
    }

    public class AnimationStateT : Object
    {
        public float _weight; // 0x10
        public float _time; // 0x14
        public string _name; // 0x18

        // ── Methods ──
        public void get_Weight(){} // RVA: 0x7FFE81225320
        public void set_Weight(){} // RVA: 0x7FFE81225330
        public void get_Time(){} // RVA: 0x7FFE81225340
        public void set_Time(){} // RVA: 0x7FFE81225350
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void set_Name(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8812D150
    }

    public class AnimationStateVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8812D1B0
    }

    public class AnimatorBool : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x12B

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8811D6C0
        public void CreateAnimatorBool(){} // RVA: 0x7FFE8812D8E0
        public void UnPack(){} // RVA: 0x7FFE8812D9B0
        public void UnPackTo(){} // RVA: 0x7FFE8811D830
        public void Pack(){} // RVA: 0x7FFE8812DA20
    }

    public class AnimatorBoolT : Object
    {
        public bool _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE811C55E0
        public void set_Value(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE81FCAC70
    }

    public class AnimatorFloat : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x131

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8811DA60
        public void CreateAnimatorFloat(){} // RVA: 0x7FFE8812DBA0
        public void UnPack(){} // RVA: 0x7FFE8812DC70
        public void UnPackTo(){} // RVA: 0x7FFE8811DBD0
        public void Pack(){} // RVA: 0x7FFE8812DCE0
    }

    public class AnimatorFloatT : Object
    {
        public float _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81225320
        public void set_Value(){} // RVA: 0x7FFE81225330
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
    }

    public class AnimatorInt : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x12E

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8811D890
        public void CreateAnimatorInt(){} // RVA: 0x7FFE8812DA40
        public void UnPack(){} // RVA: 0x7FFE8812DB10
        public void UnPackTo(){} // RVA: 0x7FFE8811DA00
        public void Pack(){} // RVA: 0x7FFE8812DB80
    }

    public class AnimatorIntT : Object
    {
        public int _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE811485C0
        public void set_Value(){} // RVA: 0x7FFE810FE0C0
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
    }

    public class AnimatorLayer : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x124
        public object field_2; // 0x125
        public object field_3; // 0x126

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsAnimatorLayer(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Hash(){} // RVA: 0x7FFE8812D2B0
        public void get_Weight(){} // RVA: 0x7FFE8812C930
        public void get_Time(){} // RVA: 0x7FFE8812D300
        public void CreateAnimatorLayer(){} // RVA: 0x7FFE8812D350
        public void StartAnimatorLayer(){} // RVA: 0x7FFE8812CD10
        public void AddHash(){} // RVA: 0x7FFE8812D4E0
        public void AddWeight(){} // RVA: 0x7FFE8812CD30
        public void AddTime(){} // RVA: 0x7FFE8812D550
        public void EndAnimatorLayer(){} // RVA: 0x7FFE8812D5C0
        public void UnPack(){} // RVA: 0x7FFE8812D650
        public void UnPackTo(){} // RVA: 0x7FFE8812D6C0
        public void Pack(){} // RVA: 0x7FFE8812D790
    }

    public class AnimatorLayerT : Object
    {
        public int _hash; // 0x10
        public float _weight; // 0x14
        public float _time; // 0x18

        // ── Methods ──
        public void get_Hash(){} // RVA: 0x7FFE811485C0
        public void set_Hash(){} // RVA: 0x7FFE810FE0C0
        public void get_Weight(){} // RVA: 0x7FFE81225340
        public void set_Weight(){} // RVA: 0x7FFE81225350
        public void get_Time(){} // RVA: 0x7FFE810FFCF0
        public void set_Time(){} // RVA: 0x7FFE811164D0
        public void .ctor(){} // RVA: 0x7FFE86E273F0
    }

    public class AnimatorLayerVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8812D7C0
    }

    public class AnimatorParameterUnion : Object
    {
        public 0x665F6814 _type; // 0x10
        public object _value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE811C55E0
        public void set_Type(){} // RVA: 0x7FFE811C55F0
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8811CB20
        public void As(){} // RVA: 0x7FFE810A1420
        public void AsAnimatorBool(){} // RVA: 0x7FFE8812C3B0
        public void FromAnimatorBool(){} // RVA: 0x7FFE8812C3F0
        public void AsAnimatorInt(){} // RVA: 0x7FFE8812C4F0
        public void FromAnimatorInt(){} // RVA: 0x7FFE8812C530
        public void AsAnimatorFloat(){} // RVA: 0x7FFE8812C630
        public void FromAnimatorFloat(){} // RVA: 0x7FFE8812C670
        public void Pack(){} // RVA: 0x7FFE8812C770
    }

    public class AnimatorParameterVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8812C8B0
    }

}