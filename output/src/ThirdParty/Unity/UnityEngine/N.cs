// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 4
// Methods: 20

namespace ThirdParty.Unity.UnityEngine
{
    public class NativeClassAttribute : Attribute
    {
        public string QualifiedNativeName; // 0x10
        public string Declaration; // 0x18

        // ── Methods ──
        public void set_QualifiedNativeName(){} // RVA: 0x7FFAC2F22E30
        public void set_Declaration(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
    }

    public class NoAllocHelpers : Object
    {
        // ── Methods ──
        public void ResizeList(){} // RVA: 0x7FFAC2C76370
        public void EnsureListElemCount(){} // RVA: 0x7FFAC2C76370
        public void SafeLength(){} // RVA: 0x7FFAC2C59A40 | overloaded x2
        public void ExtractArrayFromListT(){} // RVA: 0x7FFAC2C58F80
        public void Internal_ResizeList(){} // RVA: 0x7FFAC98C31E0
        public void ExtractArrayFromList(){} // RVA: 0x7FFAC98C3240
    }

    public class NonReorderableAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NumericFieldDraggerUtility : Object
    {
        public bool s_UseYSign;

        // ── Methods ──
        public void Acceleration(){} // RVA: 0x7FFAC98B6BD0
        public void NiceDelta(){} // RVA: 0x7FFAC98B6C10
        public void CalculateFloatDragSensitivity(){} // RVA: 0x7FFAC98B6E00 | overloaded x2
        public void CalculateIntDragSensitivity(){} // RVA: 0x7FFAC98B7010 | overloaded x4
    }

}