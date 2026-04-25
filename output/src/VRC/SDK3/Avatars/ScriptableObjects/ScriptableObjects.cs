// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Avatars.ScriptableObjects
// Classes: 2
// Methods: 8

namespace VRC.SDK3.Avatars.ScriptableObjects
{
    public class VRCExpressionParameters : ScriptableObject
    {
        public bool isEmpty; // 0x18
        public Parameter[] parameters; // 0x20
        public int MAX_PARAMETER_COST;
        public int MAX_PARAMETER_COUNT;

        // ── Methods ──
        public void GetParameter(){} // RVA: 0x7FFACC0149D0
        public void FindParameter(){} // RVA: 0x7FFACC014A10
        public void CalcTotalCost(){} // RVA: 0x7FFACC014AC0
        public void TypeCost(){} // RVA: 0x7FFACC014B30
        public void IsWithinBudget(){} // RVA: 0x7FFACC014B70 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class VRCExpressionsMenu : ScriptableObject
    {
        public VRC.SDK3.Avatars.ScriptableObjects.VRCExpressionParameters Parameters; // 0x18
        public int MAX_CONTROLS;
        public System.Collections.Generic.List`1<Control> controls; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC014D60
    }

}