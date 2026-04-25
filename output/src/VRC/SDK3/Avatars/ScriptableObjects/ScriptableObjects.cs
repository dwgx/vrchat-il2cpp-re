// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Avatars.ScriptableObjects
// Classes: 2
// Methods: 8

namespace VRC.SDK3.Avatars.ScriptableObjects
{
    public class VRCExpressionParameters : ScriptableObject
    {
        public bool isEmpty; // 0x18
        public 0x66633800[] parameters; // 0x20
        public int MAX_PARAMETER_COST;
        public int MAX_PARAMETER_COUNT;

        // ── Methods ──
        public void GetParameter(){} // RVA: 0x7FFD574349D0
        public void FindParameter(){} // RVA: 0x7FFD57434A10
        public void CalcTotalCost(){} // RVA: 0x7FFD57434AC0
        public void TypeCost(){} // RVA: 0x7FFD57434B30
        public void IsWithinBudget(){} // RVA: 0x7FFD57434B70 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class VRCExpressionsMenu : ScriptableObject
    {
        public VRC.SDK3.Avatars.ScriptableObjects.VRCExpressionParameters Parameters; // 0x18
        public int MAX_CONTROLS;
        public System.Collections.Generic.List`1<Control> controls; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57434D60
    }

}