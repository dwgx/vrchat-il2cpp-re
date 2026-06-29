// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening.Plugins.Core.PathCore
// Classes: 6
// Methods: 35

namespace ThirdParty.DOTween.DG.Tweening.Plugins.Core.PathCore
{
    public class ABSPathDecoder : Object
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x89AA50
        public void GetPoint(){} // RVA: 0x8941A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CatmullRomDecoder : ABSPathDecoder
    {
        public object _PartialControlPs;
        public object _PartialWps;

        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x2723D60
        public void GetPoint(){} // RVA: 0x2724100
        public void SetTimeToLengthTables(){} // RVA: 0x2724570
        public void SetWaypointsLengths(){} // RVA: 0x2724930
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x2724E80
    }

    public class ControlPoint : ValueType
    {
        public object a;
        public object b;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x30D0
        public void op_Addition(){} // RVA: 0x2723BC0
        public void ToString(){} // RVA: 0x92CC0
    }

    public class CubicBezierDecoder : ABSPathDecoder
    {
        public object _PartialControlPs;
        public object _PartialWps;

        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x2722920
        public void GetPoint(){} // RVA: 0x2722FB0
        public void SetTimeToLengthTables(){} // RVA: 0x2723210
        public void SetWaypointsLengths(){} // RVA: 0x27235D0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x2723A70
    }

    public class LinearDecoder : ABSPathDecoder
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x2724FD0
        public void GetPoint(){} // RVA: 0x2725060
        public void SetTimeToLengthTables(){} // RVA: 0x2725260
        public void SetWaypointsLengths(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Path : Object
    {
        public object _catmullRomDecoder;
        public object _linearDecoder;
        public object _cubicBezierDecoder;
        public object wpLengths;
        public object wps;
        public object type;
        public object subdivisionsXSegment;
        public object subdivisions;
        public object controlPoints;
        public object length;
        public object isFinalized;
        public object timesTable;
        public object lengthsTable;
        public object linearWPIndex;
        public object addedExtraStartWp;
        public object addedExtraEndWp;
        public object _incrementalClone;
        public object _incrementalIndex;
        public object _decoder;
        public object _changed;
        public object nonLinearDrawWps;
        public object targetPosition;
        public object lookAtPosition;
        public object gizmoColor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x27258A0
        public void FinalizePath(){} // RVA: 0x27258C0
        public void GetPoint(){} // RVA: 0x2725A00
        public void ConvertToConstantPathPerc(){} // RVA: 0x2725A90
        public void GetWaypointIndexFromPerc(){} // RVA: 0x2725BE0
        public void GetDrawPoints(){} // RVA: 0x2725CA0
        public void RefreshNonLinearDrawWps(){} // RVA: 0x2725DE0
        public void Destroy(){} // RVA: 0x2725F60
        public void CloneIncremental(){} // RVA: 0x2726230
        public void AssignWaypoints(){} // RVA: 0x2726BA0
        public void AssignDecoder(){} // RVA: 0x2726D30
        public void Draw(){} // RVA: 0x2727040
    }

}