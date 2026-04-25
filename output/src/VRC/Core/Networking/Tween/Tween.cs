// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Tween
// Classes: 5
// Methods: 34

namespace VRC.Core.Networking.Tween
{
    public class AnimationEvent : TweenableValue`1
    {
        public bool IsPlaying; // 0x40
        public 0x665644E0[] States; // 0x48

        // ── Methods ──
        public void DeepCopy(){} // RVA: 0x7FFD551F2970
        public void Interpolate(){} // RVA: 0x7FFD551F2D60
        public void Extrapolate(){} // RVA: 0x7FFD551F3680
        public void .ctor(){} // RVA: 0x7FFD551F3700
    }

    public class AnimatorEvent : TweenableValue`1
    {
        public 0x66564590[] Layers; // 0x40
        public 0x665645E8[] Parameters; // 0x48

        // ── Methods ──
        public void DeepCopy(){} // RVA: 0x7FFD551F3730
        public void Interpolate(){} // RVA: 0x7FFD551F3D40
        public void Extrapolate(){} // RVA: 0x7FFD551F4BF0
        public void .ctor(){} // RVA: 0x7FFD551F4C70
    }

    public class BadTweenException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD551F75D0
    }

    public class TweenFunctions : Object
    {
        public bool TolerateOutOfBounds;

        // ── Methods ──
        public void PoseTween(){} // RVA: 0x7FFD551F4CA0
        public void CubicBezierTween(){} // RVA: 0x7FFD551F6F00 | overloaded x2
        public void CatMullRomTween(){} // RVA: 0x7FFD551F6E20 | overloaded x4
        public void LinearTween(){} // RVA: 0x7FFD551F7160
        public void Clamp(){} // RVA: 0x7FFD4E2ADC40
        public void PushValue(){} // RVA: 0x7FFD4E2ADC40
        public void NarrowDelta(){} // RVA: 0x7FFD4E2ADC40
        public void FindNextIndex(){} // RVA: 0x7FFD4E0823C0
        public void FindPreviousIndex(){} // RVA: 0x7FFD4E0823C0
        public void FindCurrentSimulationIndex(){} // RVA: 0x7FFD4E2ADC40
        public void LerpUnclamped(){} // RVA: 0x7FFD53E293C0
        public void Lerp(){} // RVA: 0x7FFD551F75A0
    }

    public class TweenableValue`1 : Object
    {
        public float Time; // 0x10
        public float Delta; // 0x14
        public ÏÎÌÍÍÎÎÎÍÍÏÌÌÌÏÏÍÌÏÎÏÌÏ A; // 0x18
        public ÏÎÌÍÍÎÎÎÍÍÏÌÌÌÏÏÍÌÏÎÏÌÏ B; // 0x20
        public ÏÎÌÍÍÎÎÎÍÍÏÌÌÌÏÏÍÌÏÎÏÌÏ C; // 0x28
        public ÏÎÌÍÍÎÎÎÍÍÏÌÌÌÏÏÍÌÏÎÏÌÏ D; // 0x30
        public bool tweenSuccess; // 0x38

        // ── Methods ──
        public void get_Time(){} // RVA: 0x7FFD4E08D880
        public void set_Time(){} // RVA: 0x7FFD4E09E480
        public void Copy(){} // RVA: 0x7FFD4E090A40
        public void Interpolate(){} // RVA: 0x7FFD4E07DFB0
        public void Extrapolate(){} // RVA: 0x7FFD4E07DFB0
        public void BaseCopy(){} // RVA: 0x7FFD4E090A40
        public void DeepCopy(){} // RVA: 0x7FFD4E090A40
        public void Tween(){}
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

}