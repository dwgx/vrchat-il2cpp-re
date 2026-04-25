// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening.Plugins.Core
// Classes: 4
// Methods: 16

namespace ThirdParty.DOTween.DG.Tweening.Plugins.Core
{
    public class ABSTweenPlugin`3 : Object
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4E090A40
        public void SetFrom(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ConvertToStartValue(){} // RVA: 0x7FFD4E2ADC40
        public void SetRelativeEndValue(){} // RVA: 0x7FFD4E090A40
        public void SetChangeValue(){} // RVA: 0x7FFD4E090A40
        public void GetSpeedBasedDuration(){} // RVA: 0x7FFD4E2ADC40
        public void EvaluateAndApply(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class IPlugSetter`4
    {
        // ── Methods ──
        public void Getter(){} // RVA: 0x7FFD4E078E90
        public void Setter(){} // RVA: 0x7FFD4E078E90
        public void EndValue(){} // RVA: 0x7FFD4E2ADC40
        public void GetOptions(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ITweenPlugin
    {
    }

    public class PluginsManager : Object
    {
        public DG.Tweening.Plugins.Core.ITweenPlugin _floatPlugin;
        public DG.Tweening.Plugins.Core.ITweenPlugin _doublePlugin; // 0x8
        public DG.Tweening.Plugins.Core.ITweenPlugin _intPlugin; // 0x10
        public DG.Tweening.Plugins.Core.ITweenPlugin _uintPlugin; // 0x18
        public DG.Tweening.Plugins.Core.ITweenPlugin _longPlugin; // 0x20
        public DG.Tweening.Plugins.Core.ITweenPlugin _ulongPlugin; // 0x28
        public DG.Tweening.Plugins.Core.ITweenPlugin _vector2Plugin; // 0x30
        public DG.Tweening.Plugins.Core.ITweenPlugin _vector3Plugin; // 0x38
        public DG.Tweening.Plugins.Core.ITweenPlugin _vector4Plugin; // 0x40
        public DG.Tweening.Plugins.Core.ITweenPlugin _quaternionPlugin; // 0x48
        public DG.Tweening.Plugins.Core.ITweenPlugin _colorPlugin; // 0x50
        public DG.Tweening.Plugins.Core.ITweenPlugin _rectPlugin; // 0x58
        public DG.Tweening.Plugins.Core.ITweenPlugin _rectOffsetPlugin; // 0x60
        public DG.Tweening.Plugins.Core.ITweenPlugin _stringPlugin; // 0x68
        public DG.Tweening.Plugins.Core.ITweenPlugin _vector3ArrayPlugin; // 0x70
        public DG.Tweening.Plugins.Core.ITweenPlugin _color2Plugin; // 0x78
        public int _MaxCustomPlugins;
        public System.Collections.Generic.Dictionary`2<System.Type,DG.Tweening.Plugins.Core.ITweenPlugin> _customPlugins; // 0x80

        // ── Methods ──
        public void GetDefaultPlugin(){} // RVA: 0x7FFD4E078A90
        public void GetCustomPlugin(){} // RVA: 0x7FFD4E078A90
        public void PurgeAll(){} // RVA: 0x7FFD4FDDE070
    }

}