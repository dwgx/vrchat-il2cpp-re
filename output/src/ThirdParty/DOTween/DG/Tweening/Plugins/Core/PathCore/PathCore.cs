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
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CatmullRomDecoder : ABSPathDecoder
    {
        public DG.Tweening.Plugins.Core.PathCore.ControlPoint[] _PartialControlPs;
        public UnityEngine.Vector3[] _PartialWps; // 0x8

        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x7FFAC49BFB00
        public void GetPoint(){} // RVA: 0x7FFAC49BFEA0
        public void SetTimeToLengthTables(){} // RVA: 0x7FFAC49C0320
        public void SetWaypointsLengths(){} // RVA: 0x7FFAC49C06C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC49C0BD0
    }

    public class ControlPoint : ValueType
    {
        public UnityEngine.Vector3 a; // 0x10
        public UnityEngine.Vector3 b; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F2ADF0
        public void op_Addition(){} // RVA: 0x7FFAC49BF960
        public void ToString(){} // RVA: 0x7FFAC49BF9F0
    }

    public class CubicBezierDecoder : ABSPathDecoder
    {
        public DG.Tweening.Plugins.Core.PathCore.ControlPoint[] _PartialControlPs;
        public UnityEngine.Vector3[] _PartialWps; // 0x8

        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x7FFAC49BE770
        public void GetPoint(){} // RVA: 0x7FFAC49BEDD0
        public void SetTimeToLengthTables(){} // RVA: 0x7FFAC49BF050
        public void SetWaypointsLengths(){} // RVA: 0x7FFAC49BF3F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC49BF810
    }

    public class LinearDecoder : ABSPathDecoder
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x7FFAC49C0D20
        public void GetPoint(){} // RVA: 0x7FFAC49C0DB0
        public void SetTimeToLengthTables(){} // RVA: 0x7FFAC49C0F90
        public void SetWaypointsLengths(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Path : Object
    {
        public DG.Tweening.Plugins.Core.PathCore.CatmullRomDecoder _catmullRomDecoder;
        public DG.Tweening.Plugins.Core.PathCore.LinearDecoder _linearDecoder; // 0x8
        public DG.Tweening.Plugins.Core.PathCore.CubicBezierDecoder _cubicBezierDecoder; // 0x10
        public float[] wpLengths; // 0x10
        public UnityEngine.Vector3[] wps; // 0x18
        public 0x6B26C658 type; // 0x20
        public int subdivisionsXSegment; // 0x24
        public int subdivisions; // 0x28
        public DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints; // 0x30
        public float length; // 0x38
        public bool isFinalized; // 0x3C
        public float[] timesTable; // 0x40
        public float[] lengthsTable; // 0x48
        public int linearWPIndex; // 0x50
        public bool addedExtraStartWp; // 0x54
        public bool addedExtraEndWp; // 0x55
        public DG.Tweening.Plugins.Core.PathCore.Path _incrementalClone; // 0x58
        public int _incrementalIndex; // 0x60
        public DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder _decoder; // 0x68
        public bool _changed; // 0x70
        public UnityEngine.Vector3[] nonLinearDrawWps; // 0x78
        public UnityEngine.Vector3 targetPosition; // 0x80
        public System.Nullable`1<UnityEngine.Vector3> lookAtPosition; // 0x8C
        public UnityEngine.Color gizmoColor; // 0x9C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC49C1580 | overloaded x2
        public void FinalizePath(){} // RVA: 0x7FFAC49C15A0
        public void GetPoint(){} // RVA: 0x7FFAC49C16E0
        public void ConvertToConstantPathPerc(){} // RVA: 0x7FFAC49C1770
        public void GetWaypointIndexFromPerc(){} // RVA: 0x7FFAC49C18B0
        public void GetDrawPoints(){} // RVA: 0x7FFAC49C1950
        public void RefreshNonLinearDrawWps(){} // RVA: 0x7FFAC49C1A80
        public void Destroy(){} // RVA: 0x7FFAC49C1BF0
        public void CloneIncremental(){} // RVA: 0x7FFAC49C1EC0
        public void AssignWaypoints(){} // RVA: 0x7FFAC49C2840
        public void AssignDecoder(){} // RVA: 0x7FFAC49C29D0
        public void Draw(){} // RVA: 0x7FFAC49C2CE0 | overloaded x2
    }

}