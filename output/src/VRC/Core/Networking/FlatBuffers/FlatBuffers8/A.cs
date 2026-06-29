// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 14
// Methods: 99

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class AnimationState : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsAnimationState(){} // RVA: 0x7AF3BF190
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Weight(){} // RVA: 0x7A7F12A70
        public void get_Time(){} // RVA: 0x7A7F13B80
        public void get_Name(){} // RVA: 0x7A7F13BD0
        public void GetNameBytes(){} // RVA: 0x7A7F13BE0
        public void GetNameArray(){} // RVA: 0x7A7F13C50
        public void CreateAnimationState(){} // RVA: 0x7AF3CE0A0
        public void StartAnimationState(){} // RVA: 0x7AF3CE2E0
        public void AddWeight(){} // RVA: 0x7AF3C1AF0
        public void AddTime(){} // RVA: 0x7AF3CE300
        public void AddName(){} // RVA: 0x7AF3CE370
        public void EndAnimationState(){} // RVA: 0x7AF3CE3B0
        public void UnPack(){} // RVA: 0x7A7F13CA0
        public void UnPackTo(){} // RVA: 0x7A7F13CB0
        public void Pack(){} // RVA: 0x7AF3CE6B0
    }

    public class AnimationStateT : Object
    {
        // ── Methods ──
        public void get_Weight(){} // RVA: 0x7A82023C0
        public void set_Weight(){} // RVA: 0x7A82023D0
        public void get_Time(){} // RVA: 0x7A82023E0
        public void set_Time(){} // RVA: 0x7A82023F0
        public void get_Name(){} // RVA: 0x7A80DA7B0
        public void set_Name(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF3CE720
    }

    public class AnimationStateVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3CE780
    }

    public class AnimatorBool : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Value(){} // RVA: 0x7A7F124C0
        public void CreateAnimatorBool(){} // RVA: 0x7AF3CEEB0
        public void UnPack(){} // RVA: 0x7A7F13DC0
        public void UnPackTo(){} // RVA: 0x7A7F12500
        public void Pack(){} // RVA: 0x7AF3CEFF0
    }

    public class AnimatorBoolT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A81A2200
        public void set_Value(){} // RVA: 0x7A81A2210
        public void .ctor(){} // RVA: 0x7A847A460
    }

    public class AnimatorFloat : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Value(){} // RVA: 0x7A7F12600
        public void CreateAnimatorFloat(){} // RVA: 0x7AF3CF170
        public void UnPack(){} // RVA: 0x7A7F13E20
        public void UnPackTo(){} // RVA: 0x7A7F12640
        public void Pack(){} // RVA: 0x7AF3CF2B0
    }

    public class AnimatorFloatT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A82023C0
        public void set_Value(){} // RVA: 0x7A82023D0
        public void .ctor(){} // RVA: 0x7A881ACE0
    }

    public class AnimatorInt : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Value(){} // RVA: 0x7A7F12560
        public void CreateAnimatorInt(){} // RVA: 0x7AF3CF010
        public void UnPack(){} // RVA: 0x7A7F13DF0
        public void UnPackTo(){} // RVA: 0x7A7F125A0
        public void Pack(){} // RVA: 0x7AF3CF150
    }

    public class AnimatorIntT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A8124910
        public void set_Value(){} // RVA: 0x7A80DA0C0
        public void .ctor(){} // RVA: 0x7A881ACE0
    }

    public class AnimatorLayer : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsAnimatorLayer(){} // RVA: 0x7AF3BF190
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Hash(){} // RVA: 0x7A7F13CE0
        public void get_Weight(){} // RVA: 0x7A7F13B80
        public void get_Time(){} // RVA: 0x7A7F13D30
        public void CreateAnimatorLayer(){} // RVA: 0x7AF3CE920
        public void StartAnimatorLayer(){} // RVA: 0x7AF3CE2E0
        public void AddHash(){} // RVA: 0x7AF3CEAB0
        public void AddWeight(){} // RVA: 0x7AF3CE300
        public void AddTime(){} // RVA: 0x7AF3CEB20
        public void EndAnimatorLayer(){} // RVA: 0x7AF3CEB90
        public void UnPack(){} // RVA: 0x7A7F13D80
        public void UnPackTo(){} // RVA: 0x7A7F13D90
        public void Pack(){} // RVA: 0x7AF3CED60
    }

    public class AnimatorLayerT : Object
    {
        // ── Methods ──
        public void get_Hash(){} // RVA: 0x7A8124910
        public void set_Hash(){} // RVA: 0x7A80DA0C0
        public void get_Weight(){} // RVA: 0x7A82023E0
        public void set_Weight(){} // RVA: 0x7A82023F0
        public void get_Time(){} // RVA: 0x7A80DBCE0
        public void set_Time(){} // RVA: 0x7A80F26C0
        public void .ctor(){} // RVA: 0x7AE0D27F0
    }

    public class AnimatorLayerVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3CED90
    }

    public class AnimatorParameterUnion : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A81A2200
        public void set_Type(){} // RVA: 0x7A81A2210
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void set_Value(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF3BE020
        public void As(){} // RVA: 0x7A8051B10
        public void AsAnimatorBool(){} // RVA: 0x7AF3CD980
        public void FromAnimatorBool(){} // RVA: 0x7AF3CD9C0
        public void AsAnimatorInt(){} // RVA: 0x7AF3CDAC0
        public void FromAnimatorInt(){} // RVA: 0x7AF3CDB00
        public void AsAnimatorFloat(){} // RVA: 0x7AF3CDC00
        public void FromAnimatorFloat(){} // RVA: 0x7AF3CDC40
        public void Pack(){} // RVA: 0x7AF3CDD40
    }

    public class AnimatorParameterVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3CDE80
    }

}