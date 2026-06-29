// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.TMPro
// Classes: 4
// Methods: 20

namespace ThirdParty.Other.TMPro
{
    public class CaretInfo : ValueType
    {
        public object index;
        public object position;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2B100
    }

    public class CharacterElement : ValueType
    {
        public object m_Unicode;
        public object m_TextElement;

        // ── Methods ──
        public void get_Unicode(){} // RVA: 0x77E60
        public void set_Unicode(){} // RVA: 0x29580
        public void .ctor(){} // RVA: 0x944C60
    }

    public class ColorTween : ValueType
    {
        public object m_Target;
        public object m_StartColor;
        public object m_TargetColor;
        public object m_TweenMode;
        public object m_Duration;
        public object m_IgnoreTimeScale;

        // ── Methods ──
        public void get_startColor(){} // RVA: 0xCB720
        public void set_startColor(){} // RVA: 0xCFB00
        public void get_targetColor(){} // RVA: 0xF7220
        public void set_targetColor(){} // RVA: 0x942E30
        public void get_tweenMode(){} // RVA: 0x77D20
        public void set_tweenMode(){} // RVA: 0x77CF0
        public void get_duration(){} // RVA: 0x942E40
        public void set_duration(){} // RVA: 0x942E50
        public void get_ignoreTimeScale(){} // RVA: 0xA62E0
        public void set_ignoreTimeScale(){} // RVA: 0xA62C0
        public void TweenValue(){} // RVA: 0x942E60
        public void AddOnChangedCallback(){} // RVA: 0x942F90
        public void GetIgnoreTimescale(){} // RVA: 0xA62E0
        public void GetDuration(){} // RVA: 0x942E40
        public void ValidTarget(){} // RVA: 0x54A60
    }

    public class Compute_DT_EventArgs : Object
    {
        public object EventType;
        public object ProgressPercentage;
        public object Colors;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2574280
    }

}