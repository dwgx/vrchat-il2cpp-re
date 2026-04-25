// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 14
// Methods: 109

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class AnimationState : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsAnimationState(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Weight(){} // RVA: 0x7FFAC9D77EE0
        public void MutateWeight(){} // RVA: 0x7FFAC9D77F30
        public void get_Time(){} // RVA: 0x7FFAC9D84A00
        public void MutateTime(){} // RVA: 0x7FFAC9D84A50
        public void get_Name(){} // RVA: 0x7FFAC9D84AB0
        public void GetNameBytes(){} // RVA: 0x7FFAC9D84B40
        public void GetNameArray(){} // RVA: 0x7FFAC9D84BB0
        public void CreateAnimationState(){} // RVA: 0x7FFAC9D84C00
        public void StartAnimationState(){} // RVA: 0x7FFAC9D84E60
        public void AddWeight(){} // RVA: 0x7FFAC9D78090
        public void AddTime(){} // RVA: 0x7FFAC9D84E80
        public void AddName(){} // RVA: 0x7FFAC9D84F00
        public void EndAnimationState(){} // RVA: 0x7FFAC9D84F40
        public void UnPack(){} // RVA: 0x7FFAC9D850A0
        public void UnPackTo(){} // RVA: 0x7FFAC9D85150
        public void Pack(){} // RVA: 0x7FFAC9D85240
    }

    public class AnimationStateT : Object
    {
        public float Weight; // 0x10
        public float Time; // 0x14
        public string Name; // 0x18

        // ── Methods ──
        public void get_Weight(){} // RVA: 0x7FFAC304B320
        public void set_Weight(){} // RVA: 0x7FFAC304B330
        public void get_Time(){} // RVA: 0x7FFAC304B340
        public void set_Time(){} // RVA: 0x7FFAC304B350
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void set_Name(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9D852B0
    }

    public class AnimationStateVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D85310
    }

    public class AnimatorBool : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D75000
        public void MutateValue(){} // RVA: 0x7FFAC9D75030
        public void CreateAnimatorBool(){} // RVA: 0x7FFAC9D85B40
        public void UnPack(){} // RVA: 0x7FFAC9D85C10
        public void UnPackTo(){} // RVA: 0x7FFAC9D751A0
        public void Pack(){} // RVA: 0x7FFAC9D85C80
    }

    public class AnimatorBoolT : Object
    {
        public bool Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Value(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC322C880
    }

    public class AnimatorFloat : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D75400
        public void MutateValue(){} // RVA: 0x7FFAC9D75430
        public void CreateAnimatorFloat(){} // RVA: 0x7FFAC9D85E00
        public void UnPack(){} // RVA: 0x7FFAC9D85EE0
        public void UnPackTo(){} // RVA: 0x7FFAC9D755B0
        public void Pack(){} // RVA: 0x7FFAC9D85F50
    }

    public class AnimatorFloatT : Object
    {
        public float Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC304B320
        public void set_Value(){} // RVA: 0x7FFAC304B330
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
    }

    public class AnimatorInt : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D75200
        public void MutateValue(){} // RVA: 0x7FFAC9D75230
        public void CreateAnimatorInt(){} // RVA: 0x7FFAC9D85CA0
        public void UnPack(){} // RVA: 0x7FFAC9D85D70
        public void UnPackTo(){} // RVA: 0x7FFAC9D753A0
        public void Pack(){} // RVA: 0x7FFAC9D85DE0
    }

    public class AnimatorIntT : Object
    {
        public int Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Value(){} // RVA: 0x7FFAC2F240C0
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
    }

    public class AnimatorLayer : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsAnimatorLayer(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Hash(){} // RVA: 0x7FFAC9D85410
        public void MutateHash(){} // RVA: 0x7FFAC9D85460
        public void get_Weight(){} // RVA: 0x7FFAC9D84A00
        public void MutateWeight(){} // RVA: 0x7FFAC9D84A50
        public void get_Time(){} // RVA: 0x7FFAC9D854C0
        public void MutateTime(){} // RVA: 0x7FFAC9D85510
        public void CreateAnimatorLayer(){} // RVA: 0x7FFAC9D85570
        public void StartAnimatorLayer(){} // RVA: 0x7FFAC9D84E60
        public void AddHash(){} // RVA: 0x7FFAC9D85730
        public void AddWeight(){} // RVA: 0x7FFAC9D84E80
        public void AddTime(){} // RVA: 0x7FFAC9D857A0
        public void EndAnimatorLayer(){} // RVA: 0x7FFAC9D85820
        public void UnPack(){} // RVA: 0x7FFAC9D858B0
        public void UnPackTo(){} // RVA: 0x7FFAC9D85920
        public void Pack(){} // RVA: 0x7FFAC9D859F0
    }

    public class AnimatorLayerT : Object
    {
        public int Hash; // 0x10
        public float Weight; // 0x14
        public float Time; // 0x18

        // ── Methods ──
        public void get_Hash(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Hash(){} // RVA: 0x7FFAC2F240C0
        public void get_Weight(){} // RVA: 0x7FFAC304B340
        public void set_Weight(){} // RVA: 0x7FFAC304B350
        public void get_Time(){} // RVA: 0x7FFAC2F25CF0
        public void set_Time(){} // RVA: 0x7FFAC2F3C4D0
        public void .ctor(){} // RVA: 0x7FFAC8A7DD60
    }

    public class AnimatorLayerVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D85A20
    }

    public class AnimatorParameterUnion : Object
    {
        public 0x6B1FCF50 Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Type(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9D74460
        public void As(){} // RVA: 0x7FFAC2E8DC40
        public void AsAnimatorBool(){} // RVA: 0x7FFAC9D84480
        public void FromAnimatorBool(){} // RVA: 0x7FFAC9D844C0
        public void AsAnimatorInt(){} // RVA: 0x7FFAC9D845C0
        public void FromAnimatorInt(){} // RVA: 0x7FFAC9D84600
        public void AsAnimatorFloat(){} // RVA: 0x7FFAC9D84700
        public void FromAnimatorFloat(){} // RVA: 0x7FFAC9D84740
        public void Pack(){} // RVA: 0x7FFAC9D84840
    }

    public class AnimatorParameterVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D84980
    }

}