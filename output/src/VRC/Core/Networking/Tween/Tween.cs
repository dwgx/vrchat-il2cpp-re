// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Tween
// Classes: 5
// Methods: 35

namespace VRC.Core.Networking.Tween
{
    public class AnimationEvent : TweenableValue`1
    {
        // ── Methods ──
        public void DeepCopy(){} // RVA: 0x7FFE88178020
        public void Interpolate(){} // RVA: 0x7FFE88178410
        public void Extrapolate(){} // RVA: 0x7FFE88178D30
        public void .ctor(){} // RVA: 0x7FFE88178DB0
    }

    public class AnimatorEvent : TweenableValue`1
    {
        // ── Methods ──
        public void DeepCopy(){} // RVA: 0x7FFE88178DE0
        public void Interpolate(){} // RVA: 0x7FFE881793F0
        public void Extrapolate(){} // RVA: 0x7FFE8817A2A0
        public void .ctor(){} // RVA: 0x7FFE8817A320
    }

    public class BadTweenException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8817C380
    }

    public class TweenFunctions : Object
    {
        // ── Methods ──
        public void PoseTween(){} // RVA: 0x7FFE8817A350
        public void CubicBezierTween(){} // RVA: 0x7FFE8817BAD0 | overloaded x2
        public void CatMullRomTween(){} // RVA: 0x7FFE8817B9F0 | overloaded x4
        public void LinearTween(){} // RVA: 0x7FFE8817C010
        public void LerpUnclamped(){} // RVA: 0x7FFE86DB2A40 | overloaded x2
        public void Clamp(){} // RVA: 0x7FFE810A1420
        public void PushValue(){} // RVA: 0x7FFE810A1420
        public void NarrowDelta(){} // RVA: 0x7FFE810A1420
        public void FindNextIndex(){} // RVA: 0x7FFE80E37810
        public void FindPreviousIndex(){} // RVA: 0x7FFE80E37810
        public void FindCurrentSimulationIndex(){} // RVA: 0x7FFE810A1420
        public void Lerp(){} // RVA: 0x7FFE8817C350
    }

    public class TweenableValue`1 : Object
    {
        public float _time;

        // ── Methods ──
        public void get_Time(){} // RVA: 0x7FFE80E42E10
        public void set_Time(){} // RVA: 0x7FFE80E53B80
        public void Copy(){} // RVA: 0x7FFE80E460A0
        public void Interpolate(){} // RVA: 0x7FFE80E33400
        public void Extrapolate(){} // RVA: 0x7FFE80E33400
        public void BaseCopy(){} // RVA: 0x7FFE80E460A0
        public void DeepCopy(){} // RVA: 0x7FFE80E460A0
        public void Tween(){}
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

}