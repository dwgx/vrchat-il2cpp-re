// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening.Plugins.Core.PathCore
// Classes: 6
// Methods: 37

namespace ThirdParty.DOTween.DG.Tweening.Plugins.Core.PathCore
{
    public class ABSPathDecoder : Object
    {
        // ── Methods ──
        public void FinalizePath(){}
        public void GetPoint(){}
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CatmullRomDecoder : ABSPathDecoder
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x7FFE82C2B600
        public void GetPoint(){} // RVA: 0x7FFE82C2B9A0
        public void SetTimeToLengthTables(){} // RVA: 0x7FFE82C2BE20
        public void SetWaypointsLengths(){} // RVA: 0x7FFE82C2C1C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE82C2C6D0
    }

    public class ControlPoint : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81104DF0
        public void op_Addition(){} // RVA: 0x7FFE82C2B460
        public void ToString(){} // RVA: 0x7FFE82C2B4F0
    }

    public class CubicBezierDecoder : ABSPathDecoder
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x7FFE82C2A270
        public void GetPoint(){} // RVA: 0x7FFE82C2A8D0
        public void SetTimeToLengthTables(){} // RVA: 0x7FFE82C2AB50
        public void SetWaypointsLengths(){} // RVA: 0x7FFE82C2AEF0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE82C2B310
    }

    public class LinearDecoder : ABSPathDecoder
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x7FFE82C2C820
        public void GetPoint(){} // RVA: 0x7FFE82C2C8B0
        public void SetTimeToLengthTables(){} // RVA: 0x7FFE82C2CA90
        public void SetWaypointsLengths(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Path : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82C2D080 | overloaded x2
        public void FinalizePath(){} // RVA: 0x7FFE82C2D0A0
        public void GetPoint(){} // RVA: 0x7FFE82C2D1E0
        public void ConvertToConstantPathPerc(){} // RVA: 0x7FFE82C2D270
        public void GetWaypointIndexFromPerc(){} // RVA: 0x7FFE82C2D3B0
        public void GetDrawPoints(){} // RVA: 0x7FFE82C2D450
        public void RefreshNonLinearDrawWps(){} // RVA: 0x7FFE82C2D580
        public void Destroy(){} // RVA: 0x7FFE82C2D6F0
        public void CloneIncremental(){} // RVA: 0x7FFE82C2D9C0
        public void AssignWaypoints(){} // RVA: 0x7FFE82C2E340
        public void AssignDecoder(){} // RVA: 0x7FFE82C2E4D0
        public void Draw(){} // RVA: 0x7FFE82C2E7E0 | overloaded x2
    }

}