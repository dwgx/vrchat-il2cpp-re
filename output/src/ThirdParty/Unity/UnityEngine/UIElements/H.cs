// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 5
// Methods: 21

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class HandleDragAndDropArgs : ValueType
    {
        public UnityEngine.UIElements.DragAndDropArgs m_DragAndDropArgs; // 0x10
        public UnityEngine.Vector2 <position>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B71DC0
    }

    public class Hash128Field : TextInputBaseField`1
    {
        public bool value; // 0x460
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9AB6900 | overloaded x2
        public void get_value(){} // RVA: 0x7FFAC9AB6B80
        public void set_value(){} // RVA: 0x7FFAC9AB6BD0
        public void UpdateValueFromText(){} // RVA: 0x7FFAC9AB6CB0
        public void UpdateTextFromValue(){} // RVA: 0x7FFAC9AB6DC0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC9AB6E40
        public void ValueToString(){} // RVA: 0x7FFAC9AB6FB0
        public void StringToValue(){} // RVA: 0x7FFAC9AB7010
        public void ExecuteDefaultAction(){} // RVA: 0x7FFAC9AB7040
        public void .cctor(){} // RVA: 0x7FFAC9AB7320
    }

    public class Hashes : ValueType
    {
        public int kSize;
        public <hashes>e__FixedBuffer hashes; // 0x10
    }

    public class HelpBox : VisualElement
    {
        public string text;
        public string messageType; // 0x8
        public string iconUssClassName; // 0x10
        public string iconInfoUssClassName; // 0x18
        public string iconwarningUssClassName; // 0x20
        public string iconErrorUssClassName; // 0x28
        public 0x6B1171E0 m_HelpBoxMessageType; // 0x3C8
        public UnityEngine.UIElements.VisualElement m_Icon; // 0x3D0
        public string m_IconClass; // 0x3D8
        public UnityEngine.UIElements.Label m_Label; // 0x3E0

        // ── Methods ──
        public void set_text(){} // RVA: 0x7FFAC9AB7940
        public void set_messageType(){} // RVA: 0x7FFAC9AB7970
        public void .ctor(){} // RVA: 0x7FFAC9AB79E0 | overloaded x2
        public void GetIconClass(){} // RVA: 0x7FFAC9AB7C20
        public void UpdateIcon(){} // RVA: 0x7FFAC9AB7D00
        public void .cctor(){} // RVA: 0x7FFAC9AB7ED0
    }

    public class HierarchyEvent : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC411D4B0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

}