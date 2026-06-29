// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 14
// Methods: 99

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class AnimationState : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsAnimationState(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Weight(){} // RVA: 0x9B5DE0
        public void get_Time(){} // RVA: 0x9B7D50
        public void get_Name(){} // RVA: 0x9B7DA0
        public void GetNameBytes(){} // RVA: 0x9B7DB0
        public void GetNameArray(){} // RVA: 0x9B7E20
        public void CreateAnimationState(){} // RVA: 0x82266F0
        public void StartAnimationState(){} // RVA: 0x8226930
        public void AddWeight(){} // RVA: 0x8219C80
        public void AddTime(){} // RVA: 0x8226950
        public void AddName(){} // RVA: 0x82269C0
        public void EndAnimationState(){} // RVA: 0x8226A00
        public void UnPack(){} // RVA: 0x9B7E70
        public void UnPackTo(){} // RVA: 0x9B7E80
        public void Pack(){} // RVA: 0x8226D00
    }

    public class AnimationStateT : Object
    {
        public object _weight;
        public object _time;
        public object _name;

        // ── Methods ──
        public void get_Weight(){} // RVA: 0xC763E0
        public void set_Weight(){} // RVA: 0xC763F0
        public void get_Time(){} // RVA: 0xC76400
        public void set_Time(){} // RVA: 0xC76410
        public void get_Name(){} // RVA: 0xB465B0
        public void set_Name(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x8226D70
    }

    public class AnimationStateVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8226DD0
    }

    public class AnimatorBool : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B5470
        public void CreateAnimatorBool(){} // RVA: 0x8227500
        public void UnPack(){} // RVA: 0x9B80D0
        public void UnPackTo(){} // RVA: 0x9B54B0
        public void Pack(){} // RVA: 0x8227640
    }

    public class AnimatorBoolT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xC120A0
        public void set_Value(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xF48510
    }

    public class AnimatorFloat : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B56F0
        public void CreateAnimatorFloat(){} // RVA: 0x82277C0
        public void UnPack(){} // RVA: 0x9B8270
        public void UnPackTo(){} // RVA: 0x9B5730
        public void Pack(){} // RVA: 0x8227900
    }

    public class AnimatorFloatT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xC763E0
        public void set_Value(){} // RVA: 0xC763F0
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class AnimatorInt : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B55B0
        public void CreateAnimatorInt(){} // RVA: 0x8227660
        public void UnPack(){} // RVA: 0x9B81A0
        public void UnPackTo(){} // RVA: 0x9B55F0
        public void Pack(){} // RVA: 0x82277A0
    }

    public class AnimatorIntT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB8F8F0
        public void set_Value(){} // RVA: 0xB460A0
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class AnimatorLayer : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsAnimatorLayer(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Hash(){} // RVA: 0x9B7F50
        public void get_Weight(){} // RVA: 0x9B7D50
        public void get_Time(){} // RVA: 0x9B7FA0
        public void CreateAnimatorLayer(){} // RVA: 0x8226F70
        public void StartAnimatorLayer(){} // RVA: 0x8226930
        public void AddHash(){} // RVA: 0x8227100
        public void AddWeight(){} // RVA: 0x8226950
        public void AddTime(){} // RVA: 0x8227170
        public void EndAnimatorLayer(){} // RVA: 0x82271E0
        public void UnPack(){} // RVA: 0x9B7FF0
        public void UnPackTo(){} // RVA: 0x9B8000
        public void Pack(){} // RVA: 0x82273B0
    }

    public class AnimatorLayerT : Object
    {
        public object _hash;
        public object _weight;
        public object _time;

        // ── Methods ──
        public void get_Hash(){} // RVA: 0xB8F8F0
        public void set_Hash(){} // RVA: 0xB460A0
        public void get_Weight(){} // RVA: 0xC76400
        public void set_Weight(){} // RVA: 0xC76410
        public void get_Time(){} // RVA: 0xB47B50
        public void set_Time(){} // RVA: 0xB5DD40
        public void .ctor(){} // RVA: 0x6D53840
    }

    public class AnimatorLayerVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82273E0
    }

    public class AnimatorParameterUnion : Object
    {
        public object _type;
        public object _value;

        // ── Methods ──
        public void get_Type(){} // RVA: 0xC120A0
        public void set_Type(){} // RVA: 0xC120B0
        public void get_Value(){} // RVA: 0xB465B0
        public void set_Value(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x8215F60
        public void As(){} // RVA: 0xA94080
        public void AsAnimatorBool(){} // RVA: 0x8225E60
        public void FromAnimatorBool(){} // RVA: 0x8225EE0
        public void AsAnimatorInt(){} // RVA: 0x8225FE0
        public void FromAnimatorInt(){} // RVA: 0x8226060
        public void AsAnimatorFloat(){} // RVA: 0x8226160
        public void FromAnimatorFloat(){} // RVA: 0x82261E0
        public void Pack(){} // RVA: 0x82262E0
    }

    public class AnimatorParameterVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82264D0
    }

}