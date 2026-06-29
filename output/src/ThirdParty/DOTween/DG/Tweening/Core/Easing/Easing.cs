// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening.Core.Easing
// Classes: 4
// Methods: 13

namespace ThirdParty.DOTween.DG.Tweening.Core.Easing
{
    public class Bounce : Object
    {
        // ── Methods ──
        public void EaseIn(){} // RVA: 0x27325B0
        public void EaseOut(){} // RVA: 0x2732690
        public void EaseInOut(){} // RVA: 0x2732730
    }

    public class EaseCurve : Object
    {
        public object _animCurve;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Evaluate(){} // RVA: 0x2736460
    }

    public class EaseManager : Object
    {
        public object _PiOver2;
        public object _TwoPi;

        // ── Methods ──
        public void Evaluate(){} // RVA: 0x27328C0
        public void ToEaseFunction(){} // RVA: 0x2733650
        public void IsFlashEase(){} // RVA: 0x2735320
    }

    public class Flash : Object
    {
        // ── Methods ──
        public void Ease(){} // RVA: 0x2736600
        public void EaseIn(){} // RVA: 0x27366D0
        public void EaseOut(){} // RVA: 0x27367A0
        public void EaseInOut(){} // RVA: 0x2736890
        public void WeightedEase(){} // RVA: 0x27369B0
    }

}