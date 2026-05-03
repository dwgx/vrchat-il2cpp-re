// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UI.CoroutineTween
// Classes: 4
// Methods: 37

namespace ThirdParty.Unity.UnityEngine.UI.CoroutineTween
{
    public class ColorTween : ValueType
    {
        public ColorTweenCallback m_Target; // 0x10
        public UnityEngine.Color m_StartColor; // 0x18
        public UnityEngine.Color m_TargetColor; // 0x28
        public 0x66645394 m_TweenMode; // 0x38
        public float m_Duration; // 0x3C

        // ── Methods ──
        public void get_startColor(){} // RVA: 0x7FFE82CF9F60
        public void set_startColor(){} // RVA: 0x7FFE82D00180
        public void get_targetColor(){} // RVA: 0x7FFE81703940
        public void set_targetColor(){} // RVA: 0x7FFE817036E0
        public void get_tweenMode(){} // RVA: 0x7FFE81549710
        public void set_tweenMode(){} // RVA: 0x7FFE817E4800
        public void get_duration(){} // RVA: 0x7FFE812846C0
        public void set_duration(){} // RVA: 0x7FFE81670820
        public void get_ignoreTimeScale(){} // RVA: 0x7FFE81121450
        public void set_ignoreTimeScale(){} // RVA: 0x7FFE81121460
        public void TweenValue(){} // RVA: 0x7FFE8801EB80
        public void AddOnChangedCallback(){} // RVA: 0x7FFE8801ECB0
        public void GetIgnoreTimescale(){} // RVA: 0x7FFE81121450
        public void GetDuration(){} // RVA: 0x7FFE812846C0
        public void ValidTarget(){} // RVA: 0x7FFE81E76100
    }

    public class FloatTween : ValueType
    {
        public FloatTweenCallback m_Target; // 0x10
        public float m_StartValue; // 0x18
        public float m_TargetValue; // 0x1C
        public float m_Duration; // 0x20

        // ── Methods ──
        public void get_startValue(){} // RVA: 0x7FFE82D03B90
        public void set_startValue(){} // RVA: 0x7FFE82D03BC0
        public void get_targetValue(){} // RVA: 0x7FFE82D03BA0
        public void set_targetValue(){} // RVA: 0x7FFE82D03B80
        public void get_duration(){} // RVA: 0x7FFE81225320
        public void set_duration(){} // RVA: 0x7FFE81225330
        public void get_ignoreTimeScale(){} // RVA: 0x7FFE8124ABD0
        public void set_ignoreTimeScale(){} // RVA: 0x7FFE8124ABE0
        public void TweenValue(){} // RVA: 0x7FFE8801EE00
        public void AddOnChangedCallback(){} // RVA: 0x7FFE8801EE90
        public void GetIgnoreTimescale(){} // RVA: 0x7FFE8124ABD0
        public void GetDuration(){} // RVA: 0x7FFE81225320
        public void ValidTarget(){} // RVA: 0x7FFE81E76100
    }

    public class ITweenValue
    {
        // ── Methods ──
        public void TweenValue(){} // RVA: 0x7FFE80E53B80
        public void get_ignoreTimeScale(){} // RVA: 0x7FFE80E2F150
        public void get_duration(){} // RVA: 0x7FFE80E42E10
        public void ValidTarget(){} // RVA: 0x7FFE80E2F150
    }

    public class TweenRunner`1 : Object
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE810A1420
        public void Init(){} // RVA: 0x7FFE80E460A0
        public void StartTween(){} // RVA: 0x7FFE810A1420
        public void StopTween(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

}