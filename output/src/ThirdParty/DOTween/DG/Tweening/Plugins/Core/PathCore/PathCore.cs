// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening.Plugins.Core.PathCore
// Classes: 6
// Methods: 37

namespace ThirdParty.DOTween.DG.Tweening.Plugins.Core.PathCore
{
    public class ABSPathDecoder
    {
        // ── Methods ──
        public void FinalizePath(){}
        public void GetPoint(){}
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CatmullRomDecoder
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x1EA1EA0
        public void GetPoint(){} // RVA: 0x1EA2240
        public void SetTimeToLengthTables(){} // RVA: 0x1EA26C0
        public void SetWaypointsLengths(){} // RVA: 0x1EA2A60
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x1EA2F70
    }

    public class ControlPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E6DF0
        public void op_Addition(){} // RVA: 0x1EA1D00
        public void ToString(){} // RVA: 0x1EA1D90
    }

    public class CubicBezierDecoder
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x1EA0B10
        public void GetPoint(){} // RVA: 0x1EA1170
        public void SetTimeToLengthTables(){} // RVA: 0x1EA13F0
        public void SetWaypointsLengths(){} // RVA: 0x1EA1790
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x1EA1BB0
    }

    public class LinearDecoder
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x1EA30C0
        public void GetPoint(){} // RVA: 0x1EA3150
        public void SetTimeToLengthTables(){} // RVA: 0x1EA3330
        public void SetWaypointsLengths(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Path
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1EA3920 | overloaded x2
        public void FinalizePath(){} // RVA: 0x1EA3940
        public void GetPoint(){} // RVA: 0x1EA3A80
        public void ConvertToConstantPathPerc(){} // RVA: 0x1EA3B10
        public void GetWaypointIndexFromPerc(){} // RVA: 0x1EA3C50
        public void GetDrawPoints(){} // RVA: 0x1EA3CF0
        public void RefreshNonLinearDrawWps(){} // RVA: 0x1EA3E20
        public void Destroy(){} // RVA: 0x1EA3F90
        public void CloneIncremental(){} // RVA: 0x1EA4260
        public void AssignWaypoints(){} // RVA: 0x1EA4BE0
        public void AssignDecoder(){} // RVA: 0x1EA4D70
        public void Draw(){} // RVA: 0x1EA5080 | overloaded x2
    }

}