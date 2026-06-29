// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 3
// Methods: 7

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class GradingModeParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x795E730
    }

    public class Grain : PostProcessEffectSettings
    {
        public object colored;
        public object intensity;
        public object size;
        public object lumContrib;

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x795DE40
        public void .ctor(){} // RVA: 0x7968840
    }

    public class GrainRenderer : PostProcessEffectRenderer`1
    {
        public object m_GrainLookupRT;
        public object k_SampleCount;
        public object m_SampleIndex;

        // ── Methods ──
        public void Render(){} // RVA: 0x7968AF0
        public void GetLookupFormat(){} // RVA: 0x79695B0
        public void Release(){} // RVA: 0x7969610
        public void .ctor(){} // RVA: 0x79696C0
    }

}