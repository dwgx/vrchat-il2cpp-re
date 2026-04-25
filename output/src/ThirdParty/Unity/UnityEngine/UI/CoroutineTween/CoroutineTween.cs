// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UI.CoroutineTween
// Classes: 4
// Methods: 37

namespace ThirdParty.Unity.UnityEngine.UI.CoroutineTween
{
    public class ColorTween : ValueType
    {
        public ColorTweenCallback startColor; // 0x10
        public UnityEngine.Color targetColor; // 0x18
        public UnityEngine.Color tweenMode; // 0x28
        public 0x6B24B9C8 duration; // 0x38
        public float ignoreTimeScale; // 0x3C
        public bool m_IgnoreTimeScale; // 0x40

        // ── Methods ──
        public void get_startColor(){} // RVA: 0x7FFAC4A927D0
        public void set_startColor(){} // RVA: 0x7FFAC4A98120
        public void get_targetColor(){} // RVA: 0x7FFAC35D3330
        public void set_targetColor(){} // RVA: 0x7FFAC35D34F0
        public void get_tweenMode(){} // RVA: 0x7FFAC32EC4C0
        public void set_tweenMode(){} // RVA: 0x7FFAC369A6E0
        public void get_duration(){} // RVA: 0x7FFAC33EAB80
        public void set_duration(){} // RVA: 0x7FFAC33EA9D0
        public void get_ignoreTimeScale(){} // RVA: 0x7FFAC2F47450
        public void set_ignoreTimeScale(){} // RVA: 0x7FFAC2F47460
        public void TweenValue(){} // RVA: 0x7FFAC9C76330
        public void AddOnChangedCallback(){} // RVA: 0x7FFAC9C76460
        public void GetIgnoreTimescale(){} // RVA: 0x7FFAC2F47450
        public void GetDuration(){} // RVA: 0x7FFAC33EAB80
        public void ValidTarget(){} // RVA: 0x7FFAC3BB0800
    }

    public class FloatTween : ValueType
    {
        public FloatTweenCallback startValue; // 0x10
        public float targetValue; // 0x18
        public float duration; // 0x1C
        public float ignoreTimeScale; // 0x20
        public bool m_IgnoreTimeScale; // 0x24

        // ── Methods ──
        public void get_startValue(){} // RVA: 0x7FFAC4A9B8E0
        public void set_startValue(){} // RVA: 0x7FFAC4A9B920
        public void get_targetValue(){} // RVA: 0x7FFAC4A9B8D0
        public void set_targetValue(){} // RVA: 0x7FFAC4A9B8C0
        public void get_duration(){} // RVA: 0x7FFAC304B320
        public void set_duration(){} // RVA: 0x7FFAC304B330
        public void get_ignoreTimeScale(){} // RVA: 0x7FFAC3070BD0
        public void set_ignoreTimeScale(){} // RVA: 0x7FFAC3070BE0
        public void TweenValue(){} // RVA: 0x7FFAC9C765B0
        public void AddOnChangedCallback(){} // RVA: 0x7FFAC9C76640
        public void GetIgnoreTimescale(){} // RVA: 0x7FFAC3070BD0
        public void GetDuration(){} // RVA: 0x7FFAC304B320
        public void ValidTarget(){} // RVA: 0x7FFAC3BB0800
    }

    public class ITweenValue
    {
        public object ignoreTimeScale;
        public object duration;

        // ── Methods ──
        public void TweenValue(){} // RVA: 0x7FFAC2C7E480
        public void get_ignoreTimeScale(){} // RVA: 0x7FFAC2C59D00
        public void get_duration(){} // RVA: 0x7FFAC2C6D880
        public void ValidTarget(){} // RVA: 0x7FFAC2C59D00
    }

    public class TweenRunner`1 : Object
    {
        public UnityEngine.MonoBehaviour m_CoroutineContainer;
        public System.Collections.IEnumerator m_Tween;

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2E8DC40
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void StartTween(){} // RVA: 0x7FFAC2E8DC40
        public void StopTween(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

}