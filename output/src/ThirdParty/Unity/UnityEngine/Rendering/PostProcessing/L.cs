// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 4
// Methods: 13

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class LensDistortion : PostProcessEffectSettings
    {
        public object intensity;
        public object intensityX;
        public object intensityY;
        public object centerX;
        public object centerY;
        public object scale;

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7969700
        public void .ctor(){} // RVA: 0x79697C0
    }

    public class LensDistortionRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x7969B80
        public void .ctor(){} // RVA: 0x7969F60
    }

    public class LightMeterMonitor : Monitor
    {
        public object width;
        public object height;
        public object showCurves;

        // ── Methods ──
        public void ShaderResourcesAvailable(){} // RVA: 0x797A310
        public void Render(){} // RVA: 0x797A440
        public void .ctor(){} // RVA: 0x797AC00
    }

    public class LogHistogram : Object
    {
        public object rangeMin;
        public object rangeMax;
        public object k_Bins;
        public object _data;

        // ── Methods ──
        public void get_data(){} // RVA: 0xB5DBF0
        public void set_data(){} // RVA: 0xB44D60
        public void Generate(){} // RVA: 0x7992CF0
        public void GetHistogramScaleOffsetRes(){} // RVA: 0x7993380
        public void Release(){} // RVA: 0x79933D0
        public void .ctor(){} // RVA: 0xB43310
    }

}