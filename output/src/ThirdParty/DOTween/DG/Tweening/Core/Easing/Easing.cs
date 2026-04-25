// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening.Core.Easing
// Classes: 4
// Methods: 14

namespace ThirdParty.DOTween.DG.Tweening.Core.Easing
{
    public class Bounce : Object
    {
        // ── Methods ──
        public void EaseIn(){} // RVA: 0x7FFAC49CE100
        public void EaseOut(){} // RVA: 0x7FFAC49CE1E0
        public void EaseInOut(){} // RVA: 0x7FFAC49CE280
    }

    public class EaseCurve : Object
    {
        public UnityEngine.AnimationCurve _animCurve; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Evaluate(){} // RVA: 0x7FFAC49D1FB0
    }

    public class EaseManager : Object
    {
        public float _PiOver2;
        public float _TwoPi;

        // ── Methods ──
        public void Evaluate(){} // RVA: 0x7FFAC49CE410 | overloaded x2
        public void ToEaseFunction(){} // RVA: 0x7FFAC49CF1A0
        public void IsFlashEase(){} // RVA: 0x7FFAC49D0E70
    }

    public class Flash : Object
    {
        // ── Methods ──
        public void Ease(){} // RVA: 0x7FFAC49D2100
        public void EaseIn(){} // RVA: 0x7FFAC49D21C0
        public void EaseOut(){} // RVA: 0x7FFAC49D2290
        public void EaseInOut(){} // RVA: 0x7FFAC49D2370
        public void WeightedEase(){} // RVA: 0x7FFAC49D2480
    }

}