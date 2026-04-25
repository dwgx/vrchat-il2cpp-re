// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Tween
// Classes: 5
// Methods: 34

namespace VRC.Core.Networking.Tween
{
    public class AnimationEvent : TweenableValue`1
    {
        public bool IsPlaying; // 0x40
        public State[] States; // 0x48

        // ── Methods ──
        public void DeepCopy(){} // RVA: 0x7FFAC9DD2970
        public void Interpolate(){} // RVA: 0x7FFAC9DD2D60
        public void Extrapolate(){} // RVA: 0x7FFAC9DD3680
        public void .ctor(){} // RVA: 0x7FFAC9DD3700
    }

    public class AnimatorEvent : TweenableValue`1
    {
        public Layer[] Layers; // 0x40
        public Parameter[] Parameters; // 0x48

        // ── Methods ──
        public void DeepCopy(){} // RVA: 0x7FFAC9DD3730
        public void Interpolate(){} // RVA: 0x7FFAC9DD3D40
        public void Extrapolate(){} // RVA: 0x7FFAC9DD4BF0
        public void .ctor(){} // RVA: 0x7FFAC9DD4C70
    }

    public class BadTweenException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9DD75D0
    }

    public class TweenFunctions : Object
    {
        public bool TolerateOutOfBounds;

        // ── Methods ──
        public void PoseTween(){} // RVA: 0x7FFAC9DD4CA0
        public void CubicBezierTween(){} // RVA: 0x7FFAC9DD6F00 | overloaded x2
        public void CatMullRomTween(){} // RVA: 0x7FFAC9DD6E20 | overloaded x4
        public void LinearTween(){} // RVA: 0x7FFAC9DD7160
        public void Clamp(){} // RVA: 0x7FFAC2E8DC40
        public void PushValue(){} // RVA: 0x7FFAC2E8DC40
        public void NarrowDelta(){} // RVA: 0x7FFAC2E8DC40
        public void FindNextIndex(){} // RVA: 0x7FFAC2C623C0
        public void FindPreviousIndex(){} // RVA: 0x7FFAC2C623C0
        public void FindCurrentSimulationIndex(){} // RVA: 0x7FFAC2E8DC40
        public void LerpUnclamped(){} // RVA: 0x7FFAC8A093C0
        public void Lerp(){} // RVA: 0x7FFAC9DD75A0
    }

    public class TweenableValue`1 : Object
    {
        public float Time;
        public float Delta;
        public T A;
        public T B;
        public T C;
        public T D;
        public bool tweenSuccess;

        // ── Methods ──
        public void get_Time(){} // RVA: 0x7FFAC2C6D880
        public void set_Time(){} // RVA: 0x7FFAC2C7E480
        public void Copy(){} // RVA: 0x7FFAC2C70A40
        public void Interpolate(){} // RVA: 0x7FFAC2C5DFB0
        public void Extrapolate(){} // RVA: 0x7FFAC2C5DFB0
        public void BaseCopy(){} // RVA: 0x7FFAC2C70A40
        public void DeepCopy(){} // RVA: 0x7FFAC2C70A40
        public void Tween(){}
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

}