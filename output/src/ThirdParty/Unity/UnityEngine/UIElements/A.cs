// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 6
// Methods: 45

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class AbstractProgressBar : BindableElement
    {
        public string title;
        public string lowValue; // 0x8
        public string highValue; // 0x10
        public string value; // 0x18
        public string progressUssClassName; // 0x20
        public string backgroundUssClassName; // 0x28
        public UnityEngine.UIElements.VisualElement m_Background; // 0x3D8
        public UnityEngine.UIElements.VisualElement m_Progress; // 0x3E0
        public UnityEngine.UIElements.Label m_Title; // 0x3E8
        public float m_LowValue; // 0x3F0
        public float m_HighValue; // 0x3F4
        public float m_Value; // 0x3F8

        // ── Methods ──
        public void set_title(){} // RVA: 0x7FFAC9B50870
        public void get_lowValue(){} // RVA: 0x7FFAC9B508A0
        public void set_lowValue(){} // RVA: 0x7FFAC9B508B0
        public void get_highValue(){} // RVA: 0x7FFAC9B508D0
        public void set_highValue(){} // RVA: 0x7FFAC9B508E0
        public void .ctor(){} // RVA: 0x7FFAC9B50900
        public void OnGeometryChanged(){} // RVA: 0x7FFAC9B50DC0
        public void get_value(){} // RVA: 0x7FFAC9B50DF0
        public void set_value(){} // RVA: 0x7FFAC9B50E00
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC9B50FF0
        public void SetProgress(){} // RVA: 0x7FFAC9B51030
        public void CalculateProgressWidth(){} // RVA: 0x7FFAC9B51210
        public void .cctor(){} // RVA: 0x7FFAC9B512C0
    }

    public class AlignmentUtils : Object
    {
        // ── Methods ──
        public void RoundToPixelGrid(){} // RVA: 0x7FFAC9A7B0F0
        public void CeilToPixelGrid(){} // RVA: 0x7FFAC9A7B120
    }

    public class AncestorFilter : Object
    {
        public UnityEngine.UIElements.CountingBloomFilter m_CountingBloomFilter; // 0x10
        public System.Collections.Generic.Stack`1<int> m_HashStack; // 0x4010

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B6A080
        public void AddHash(){} // RVA: 0x7FFAC9B6A140
        public void IsCandidate(){} // RVA: 0x7FFAC9B6A200
        public void PushElement(){} // RVA: 0x7FFAC9B6A270
        public void PopElement(){} // RVA: 0x7FFAC9B6A540
    }

    public class Angle : ValueType
    {
        public float value; // 0x10
        public 0x6B121000 m_Unit; // 0x14

        // ── Methods ──
        public void None(){} // RVA: 0x7FFAC9BD3760
        public void get_value(){} // RVA: 0x7FFAC484C150
        public void .ctor(){} // RVA: 0x7FFAC553F750 | overloaded x2
        public void ToDegrees(){} // RVA: 0x7FFAC9BD3780
        public void op_Implicit(){} // RVA: 0x7FFAC9BD37E0
        public void op_Equality(){} // RVA: 0x7FFAC9BD3800
        public void Equals(){} // RVA: 0x7FFAC9BD3860 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BD3910
        public void ToString(){} // RVA: 0x7FFAC9BD3930
    }

    public class AtlasBase : Object
    {
        public UnityEngine.UIElements.TextureRegistry textureRegistry; // 0x10

        // ── Methods ──
        public void TryGetAtlas(){} // RVA: 0x7FFAC9A7B150
        public void ReturnAtlas(){} // RVA: 0x7FFAC2F21310
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void OnAssignedToPanel(){} // RVA: 0x7FFAC2F21310
        public void OnRemovedFromPanel(){} // RVA: 0x7FFAC2F21310
        public void OnUpdateDynamicTextures(){} // RVA: 0x7FFAC2F21310
        public void InvokeAssignedToPanel(){} // RVA: 0x7FFAC77C53C0
        public void InvokeRemovedFromPanel(){} // RVA: 0x7FFAC69A3D80
        public void InvokeUpdateDynamicTextures(){} // RVA: 0x7FFAC93914C0
        public void RepaintTexturedElements(){} // RVA: 0x7FFAC9A7B1C0
        public void SetDynamicTexture(){} // RVA: 0x7FFAC9A7B400
        public void .ctor(){} // RVA: 0x7FFAC9A7B420
    }

    public class AttachToPanelEvent : PanelChangedEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B8BF60
        public void .ctor(){} // RVA: 0x7FFAC9B8C050
    }

}