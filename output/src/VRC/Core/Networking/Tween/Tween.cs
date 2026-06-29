// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Tween
// Classes: 12
// Methods: 105

namespace VRC.Core.Networking.Tween
{
    public class AnimationEvent : TweenableValue`1
    {
        public object IsPlaying;
        public object States;

        // ── Methods ──
        public void DeepCopy(){} // RVA: 0x8274C20
        public void Interpolate(){} // RVA: 0x8274FF0
        public void Extrapolate(){} // RVA: 0x82758B0
        public void .ctor(){} // RVA: 0x8275930
    }

    public class AnimationEvent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class AnimatorEvent : TweenableValue`1
    {
        public object Layers;
        public object Parameters;

        // ── Methods ──
        public void DeepCopy(){} // RVA: 0x8275960
        public void Interpolate(){} // RVA: 0x8275F50
        public void Extrapolate(){} // RVA: 0x8276D60
        public void .ctor(){} // RVA: 0x8276DE0
    }

    public class AnimatorEvent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class BadTweenException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8278DE0
    }

    public class TweenFunctions : Object
    {
        public object TolerateOutOfBounds;

        // ── Methods ──
        public void PoseTween(){} // RVA: 0x8276E10
        public void CubicBezierTween(){} // RVA: 0x8278510
        public void CatMullRomTween(){} // RVA: 0x8278430
        public void LinearTween(){} // RVA: 0x8278A60
        public void LerpUnclamped(){} // RVA: 0x6CDF580
        public void Clamp(){} // RVA: 0xA94080
        public void PushValue(){} // RVA: 0x2A3EFF0
        public void NarrowDelta(){} // RVA: 0xA94080
        public void FindNextIndex(){} // RVA: 0x2A3E910
        public void FindPreviousIndex(){} // RVA: 0x2A3E9C0
        public void FindCurrentSimulationIndex(){} // RVA: 0x2A3E4E0
        public void Lerp(){} // RVA: 0x8278DB0
    }

    public class TweenableValue`1 : Object
    {
        public object _time;
        public object Delta;
        public object A;
        public object B;
        public object C;
        public object D;
        public object tweenSuccess;

        // ── Methods ──
        public void get_Time(){} // RVA: 0x890F90
        public void set_Time(){} // RVA: 0x8A23A0
        public void Copy(){} // RVA: 0x894320
        public void Interpolate(){} // RVA: 0x881520
        public void Extrapolate(){} // RVA: 0x881520
        public void BaseCopy(){} // RVA: 0x894320
        public void DeepCopy(){} // RVA: 0x894320
        public void Tween(){} // RVA: 0x881080
        public void .ctor(){} // RVA: 0x894290
    }

    public class TweenableValue`1 : Object
    {
        public object _time;
        public object Delta;
        public object A;
        public object B;
        public object C;
        public object D;
        public object tweenSuccess;

        // ── Methods ──
        public void get_Time(){} // RVA: 0xC763E0
        public void set_Time(){} // RVA: 0xC763F0
        public void Copy(){} // RVA: 0x4F40500
        public void Interpolate(){} // RVA: 0x881520
        public void Extrapolate(){} // RVA: 0x881520
        public void BaseCopy(){} // RVA: 0x4F40550
        public void DeepCopy(){} // RVA: 0x894320
        public void Tween(){} // RVA: 0x4F40730
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TweenableValue`1 : Object
    {
        public object _time;
        public object Delta;
        public object A;
        public object B;
        public object C;
        public object D;
        public object tweenSuccess;

        // ── Methods ──
        public void get_Time(){} // RVA: 0xC763E0
        public void set_Time(){} // RVA: 0xC763F0
        public void Copy(){} // RVA: 0x4F40500
        public void Interpolate(){} // RVA: 0x881520
        public void Extrapolate(){} // RVA: 0x881520
        public void BaseCopy(){} // RVA: 0x4F40550
        public void DeepCopy(){} // RVA: 0x894320
        public void Tween(){} // RVA: 0x4F40730
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TweenableValue`1 : Object
    {
        public object _time;
        public object Delta;
        public object A;
        public object B;
        public object C;
        public object D;
        public object tweenSuccess;

        // ── Methods ──
        public void get_Time(){} // RVA: 0xC763E0
        public void set_Time(){} // RVA: 0xC763F0
        public void Copy(){} // RVA: 0x4F40500
        public void Interpolate(){} // RVA: 0x881520
        public void Extrapolate(){} // RVA: 0x881520
        public void BaseCopy(){} // RVA: 0x4F40550
        public void DeepCopy(){} // RVA: 0x894320
        public void Tween(){} // RVA: 0x4F40730
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TweenableValue`1 : Object
    {
        public object _time;
        public object Delta;
        public object A;
        public object B;
        public object C;
        public object D;
        public object tweenSuccess;

        // ── Methods ──
        public void get_Time(){} // RVA: 0xC763E0
        public void set_Time(){} // RVA: 0xC763F0
        public void Copy(){} // RVA: 0x4F40500
        public void Interpolate(){} // RVA: 0x881520
        public void Extrapolate(){} // RVA: 0x881520
        public void BaseCopy(){} // RVA: 0x4F40550
        public void DeepCopy(){} // RVA: 0x894320
        public void Tween(){} // RVA: 0x4F40730
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TweenableValue`1 : Object
    {
        public object _time;
        public object Delta;
        public object A;
        public object B;
        public object C;
        public object D;
        public object tweenSuccess;

        // ── Methods ──
        public void get_Time(){} // RVA: 0xC763E0
        public void set_Time(){} // RVA: 0xC763F0
        public void Copy(){} // RVA: 0x4F40500
        public void Interpolate(){} // RVA: 0x881520
        public void Extrapolate(){} // RVA: 0x881520
        public void BaseCopy(){} // RVA: 0x4F40550
        public void DeepCopy(){} // RVA: 0x894320
        public void Tween(){} // RVA: 0x4F40730
        public void .ctor(){} // RVA: 0xB43310
    }

}