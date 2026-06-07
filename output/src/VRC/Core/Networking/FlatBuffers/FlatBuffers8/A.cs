// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 14
// Methods: 101

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class AnimationState
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsAnimationState(){} // RVA: 0x75E0C40 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Weight(){} // RVA: 0x75E3420
        public void get_Time(){} // RVA: 0x75EF8E0
        public void get_Name(){} // RVA: 0x75EF930
        public void GetNameBytes(){} // RVA: 0x75EF9C0
        public void GetNameArray(){} // RVA: 0x75EFA30
        public void CreateAnimationState(){} // RVA: 0x75EFA80
        public void StartAnimationState(){} // RVA: 0x75EFCC0
        public void AddWeight(){} // RVA: 0x75E3560
        public void AddTime(){} // RVA: 0x75EFCE0
        public void AddName(){} // RVA: 0x75EFD50
        public void EndAnimationState(){} // RVA: 0x75EFD90
        public void UnPack(){} // RVA: 0x75EFEF0
        public void UnPackTo(){} // RVA: 0x75EFFA0
        public void Pack(){} // RVA: 0x75F0090
    }

    public class AnimationStateT
    {
        // ── Methods ──
        public void get_Weight(){} // RVA: 0x407320
        public void set_Weight(){} // RVA: 0x407330
        public void get_Time(){} // RVA: 0x407340
        public void set_Time(){} // RVA: 0x407350
        public void get_Name(){} // RVA: 0x2E07C0
        public void set_Name(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x75F0100
    }

    public class AnimationStateVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75F0160
    }

    public class AnimatorBool
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x75E0670
        public void CreateAnimatorBool(){} // RVA: 0x75F0890
        public void UnPack(){} // RVA: 0x75F0960
        public void UnPackTo(){} // RVA: 0x75E07E0
        public void Pack(){} // RVA: 0x75F09D0
    }

    public class AnimatorBoolT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x3A75E0
        public void set_Value(){} // RVA: 0x3A75F0
        public void .ctor(){} // RVA: 0x6BDA00
    }

    public class AnimatorFloat
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x75E0A10
        public void CreateAnimatorFloat(){} // RVA: 0x75F0B50
        public void UnPack(){} // RVA: 0x75F0C20
        public void UnPackTo(){} // RVA: 0x75E0B80
        public void Pack(){} // RVA: 0x75F0C90
    }

    public class AnimatorFloatT
    {
        public object AnimationIsPlaying;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x407320
        public void set_Value(){} // RVA: 0x407330
        public void .ctor(){} // RVA: 0xA5D070
    }

    public class AnimatorInt
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x75E0840
        public void CreateAnimatorInt(){} // RVA: 0x75F09F0
        public void UnPack(){} // RVA: 0x75F0AC0
        public void UnPackTo(){} // RVA: 0x75E09B0
        public void Pack(){} // RVA: 0x75F0B30
    }

    public class AnimatorIntT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x32A5C0
        public void set_Value(){} // RVA: 0x2E00C0
        public void .ctor(){} // RVA: 0xA5D070
    }

    public class AnimatorLayer
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsAnimatorLayer(){} // RVA: 0x75E0C40 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Hash(){} // RVA: 0x75F0260
        public void get_Weight(){} // RVA: 0x75EF8E0
        public void get_Time(){} // RVA: 0x75F02B0
        public void CreateAnimatorLayer(){} // RVA: 0x75F0300
        public void StartAnimatorLayer(){} // RVA: 0x75EFCC0
        public void AddHash(){} // RVA: 0x75F0490
        public void AddWeight(){} // RVA: 0x75EFCE0
        public void AddTime(){} // RVA: 0x75F0500
        public void EndAnimatorLayer(){} // RVA: 0x75F0570
        public void UnPack(){} // RVA: 0x75F0600
        public void UnPackTo(){} // RVA: 0x75F0670
        public void Pack(){} // RVA: 0x75F0740
    }

    public class AnimatorLayerT
    {
        // ── Methods ──
        public void get_Hash(){} // RVA: 0x32A5C0
        public void set_Hash(){} // RVA: 0x2E00C0
        public void get_Weight(){} // RVA: 0x407340
        public void set_Weight(){} // RVA: 0x407350
        public void get_Time(){} // RVA: 0x2E1CF0
        public void set_Time(){} // RVA: 0x2F84D0
        public void .ctor(){} // RVA: 0x62E69C0
    }

    public class AnimatorLayerVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75F0770
    }

    public class AnimatorParameterUnion
    {
        public object Parser;
        public object Descriptor;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x3A75E0
        public void set_Type(){} // RVA: 0x3A75F0
        public void get_Value(){} // RVA: 0x2E07C0
        public void set_Value(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x75DFAD0
        public void As(){} // RVA: 0x283FA0
        public void AsAnimatorBool(){} // RVA: 0x75EF360
        public void FromAnimatorBool(){} // RVA: 0x75EF3A0
        public void AsAnimatorInt(){} // RVA: 0x75EF4A0
        public void FromAnimatorInt(){} // RVA: 0x75EF4E0
        public void AsAnimatorFloat(){} // RVA: 0x75EF5E0
        public void FromAnimatorFloat(){} // RVA: 0x75EF620
        public void Pack(){} // RVA: 0x75EF720
    }

    public class AnimatorParameterVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75EF860
    }

}