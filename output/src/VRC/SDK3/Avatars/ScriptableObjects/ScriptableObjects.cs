// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Avatars.ScriptableObjects
// Classes: 2
// Methods: 7

namespace VRC.SDK3.Avatars.ScriptableObjects
{
    public class VRCExpressionParameters : ScriptableObject
    {
        public object isEmpty;
        public object parameters;
        public object MAX_PARAMETER_COST;
        public object MAX_PARAMETER_COUNT;

        // ── Methods ──
        public void GetParameter(){} // RVA: 0xA6C8030
        public void FindParameter(){} // RVA: 0xA6C8070
        public void CalcTotalCost(){} // RVA: 0xA6C8120
        public void TypeCost(){} // RVA: 0xA6C8190
        public void IsWithinBudget(){} // RVA: 0xA6C81D0
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class VRCExpressionsMenu : ScriptableObject
    {
        public object Parameters;
        public object MAX_CONTROLS;
        public object controls;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6C83C0
    }

}