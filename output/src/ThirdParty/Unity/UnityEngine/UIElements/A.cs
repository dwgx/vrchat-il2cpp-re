// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 8
// Methods: 73

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class ATGTextEventHandler : Object
    {
        public object m_TextElement;
        public object m_LinkTagOnPointerDown;
        public object m_LinkTagOnPointerUp;
        public object m_LinkTagOnPointerMove;
        public object m_LinkTagOnPointerOut;
        public object m_HyperlinkOnPointerUp;
        public object m_HyperlinkOnPointerMove;
        public object m_HyperlinkOnPointerOver;
        public object m_HyperlinkOnPointerOut;
        public object isOverridingCursor;
        public object currentLinkIDHash;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7EED2D0
        public void OnDestroy(){} // RVA: 0x7EED3D0
        public void HasAllocatedLinkCallbacks(){} // RVA: 0x7EED3F0
        public void AllocateLinkCallbacks(){} // RVA: 0x7EED400
        public void HasAllocatedHyperlinkCallbacks(){} // RVA: 0x7EED6B0
        public void AllocateHyperlinkCallbacks(){} // RVA: 0x7EED6C0
        public void HyperlinkOnPointerUp(){} // RVA: 0x7EED970
        public void HyperlinkOnPointerOver(){} // RVA: 0x1D98510
        public void HyperlinkOnPointerMove(){} // RVA: 0x7EEDAD0
        public void HyperlinkOnPointerOut(){} // RVA: 0x1D98510
        public void LinkTagOnPointerDown(){} // RVA: 0x7EEDD20
        public void LinkTagOnPointerUp(){} // RVA: 0x7EEDF90
        public void LinkTagOnPointerMove(){} // RVA: 0x7EEE200
        public void LinkTagOnPointerOut(){} // RVA: 0x7EEE660
        public void RegisterLinkTagCallbacks(){} // RVA: 0x7EEE800
        public void UnRegisterLinkTagCallbacks(){} // RVA: 0x7EEE910
        public void RegisterHyperlinkCallbacks(){} // RVA: 0x7EEECB0
        public void UnRegisterHyperlinkCallbacks(){} // RVA: 0x7EEEE00
    }

    public class ATGTextJobSystem : Object
    {
        public object textJobDatasHandle;
        public object textJobDatas;
        public object hasPendingTextWork;
        public object s_JobDataPool;
        public object m_GenerateTextJobifiedCallback;
        public object m_AddDrawEntriesCallback;
        public object k_GenerateTextMarker;
        public object k_ATGTextJobMarker;
        public object k_IsMultiThreaded;
        public object atlases;
        public object sdfScalesArray;
        public object verticesArray;
        public object indicesArray;
        public object renderModes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7EF31B0
        public void GenerateText(){} // RVA: 0x7EF3670
        public void GenerateTextJobified(){} // RVA: 0x7EF38D0
        public void AddDrawEntries(){} // RVA: 0x7EF3EC0
        public void ConvertMeshInfoToUIRVertex(){} // RVA: 0x7EF43D0
        public void .cctor(){} // RVA: 0x7EF4F40
    }

    public class AbstractProgressBar : BindableElement
    {
        public object titleProperty;
        public object lowValueProperty;
        public object highValueProperty;
        public object valueProperty;
        public object ussClassName;
        public object containerUssClassName;
        public object titleUssClassName;
        public object titleContainerUssClassName;
        public object progressUssClassName;
        public object backgroundUssClassName;
        public object m_Background;
        public object m_Progress;
        public object m_Title;
        public object m_LowValue;
        public object m_HighValue;
        public object m_Value;

        // ── Methods ──
        public void get_title(){} // RVA: 0x800E990
        public void set_title(){} // RVA: 0x800E9C0
        public void get_lowValue(){} // RVA: 0x800EAF0
        public void set_lowValue(){} // RVA: 0x800EB00
        public void get_highValue(){} // RVA: 0x800EBC0
        public void set_highValue(){} // RVA: 0x800EBD0
        public void .ctor(){} // RVA: 0x800EC90
        public void OnGeometryChanged(){} // RVA: 0x800F140
        public void get_value(){} // RVA: 0x800F170
        public void set_value(){} // RVA: 0x800F180
        public void SetValueWithoutNotify(){} // RVA: 0x800F3C0
        public void SetProgress(){} // RVA: 0x800F400
        public void CalculateOppositeProgressWidth(){} // RVA: 0x800F6E0
        public void .cctor(){} // RVA: 0x800F880
    }

    public class AlignmentUtils : Object
    {
        // ── Methods ──
        public void RoundToPixelGrid(){} // RVA: 0x7E4E9E0
        public void CeilToPixelGrid(){} // RVA: 0x7E4EA10
        public void RoundToPanelPixelSize(){} // RVA: 0x7E4EA40
    }

    public class AncestorFilter : Object
    {
        public object m_CountingBloomFilter;
        public object m_HashStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x803D2D0
        public void AddHash(){} // RVA: 0x803D390
        public void IsCandidate(){} // RVA: 0x803D450
        public void PushElement(){} // RVA: 0x803D4C0
        public void PopElement(){} // RVA: 0x803D6B0
    }

    public class Angle : ValueType
    {
        public object m_Value;
        public object m_Unit;

        // ── Methods ──
        public void None(){} // RVA: 0x80B14E0
        public void get_value(){} // RVA: 0x88D10
        public void set_value(){} // RVA: 0xD1B20
        public void get_unit(){} // RVA: 0x77E50
        public void set_unit(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x22C190
        public void ToDegrees(){} // RVA: 0x9AA0A0
        public void op_Implicit(){} // RVA: 0x7ED9E70
        public void op_Equality(){} // RVA: 0x7ED69E0
        public void op_Inequality(){} // RVA: 0x7ED6A10
        public void Equals(){} // RVA: 0x9AA100
        public void GetHashCode(){} // RVA: 0x996F20
        public void ToString(){} // RVA: 0x9AA110
    }

    public class AtlasBase : Object
    {
        public object textureRegistry;

        // ── Methods ──
        public void TryGetAtlas(){} // RVA: 0x7E4EAA0
        public void ReturnAtlas(){} // RVA: 0xB43310
        public void Reset(){} // RVA: 0xB43310
        public void OnAssignedToPanel(){} // RVA: 0xB43310
        public void OnRemovedFromPanel(){} // RVA: 0xB43310
        public void OnUpdateDynamicTextures(){} // RVA: 0xB43310
        public void InvokeAssignedToPanel(){} // RVA: 0x5BA5570
        public void InvokeRemovedFromPanel(){} // RVA: 0x4B52F00
        public void InvokeUpdateDynamicTextures(){} // RVA: 0x7659E80
        public void RepaintTexturedElements(){} // RVA: 0x7E4EB10
        public void SetDynamicTexture(){} // RVA: 0x7E4ED30
        public void .ctor(){} // RVA: 0x7E4ED50
    }

    public class AttachToPanelEvent : PanelChangedEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8065380
        public void .ctor(){} // RVA: 0x8065470
    }

}