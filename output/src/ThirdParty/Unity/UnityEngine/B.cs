// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 14
// Methods: 112

namespace ThirdParty.Unity.UnityEngine
{
    public class BeforeRenderHelper : Object
    {
        public System.Collections.Generic.List`1<OrderBlock> s_OrderBlocks;

        // ── Methods ──
        public void GetUpdateOrder(){} // RVA: 0x7FFAC986A150
        public void RegisterCallback(){} // RVA: 0x7FFAC986A2E0
        public void UnregisterCallback(){} // RVA: 0x7FFAC986A870
        public void Invoke(){} // RVA: 0x7FFAC986AD30
        public void .cctor(){} // RVA: 0x7FFAC986AFB0
    }

    public class BeforeRenderOrderAttribute : Attribute
    {
        public int order; // 0x10

        // ── Methods ──
        public void get_order(){} // RVA: 0x7FFAC2F6E5C0
        public void set_order(){} // RVA: 0x7FFAC2F240C0
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class Behaviour : Component
    {
        public object enabled;
        public object isActiveAndEnabled;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFAC2F87DE0
        public void set_enabled(){} // RVA: 0x7FFAC3CF7970
        public void get_isActiveAndEnabled(){} // RVA: 0x7FFAC98BACF0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class BillboardAsset : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC986B090
        public void Internal_Create(){} // RVA: 0x7FFAC986B120
    }

    public class BillboardRenderer : Renderer
    {
        public object billboard;

        // ── Methods ──
        public void get_billboard(){} // RVA: 0x7FFAC986B170
        public void set_billboard(){} // RVA: 0x7FFAC986B1C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class BlendShape : ValueType
    {
        public uint firstVertex; // 0x10
        public uint vertexCount; // 0x14
        public bool m_HasNormals; // 0x18
        public bool m_HasTangents; // 0x19

        // ── Methods ──
        public void get_firstVertex(){} // RVA: 0x7FFAC8F93F90
        public void get_vertexCount(){} // RVA: 0x7FFAC69CBEA0
    }

    public class BlendShapeBufferRange : ValueType
    {
        public uint startIndex; // 0x10
        public uint endIndex; // 0x14

        // ── Methods ──
        public void set_startIndex(){} // RVA: 0x7FFAC336D8B0
        public void set_endIndex(){} // RVA: 0x7FFAC4420230
    }

    public class BoneWeight : ValueType
    {
        public float weight0; // 0x10
        public float weight1; // 0x14
        public float weight2; // 0x18
        public float weight3; // 0x1C
        public int boneIndex0; // 0x20
        public int boneIndex1; // 0x24
        public int boneIndex2; // 0x28
        public int boneIndex3; // 0x2C

        // ── Methods ──
        public void get_weight0(){} // RVA: 0x7FFAC2F44D20
        public void set_weight0(){} // RVA: 0x7FFAC4A9B910
        public void get_weight1(){} // RVA: 0x7FFAC2F44D30
        public void set_weight1(){} // RVA: 0x7FFAC4A9B8F0
        public void get_weight2(){} // RVA: 0x7FFAC2F44CF0
        public void set_weight2(){} // RVA: 0x7FFAC4A9B920
        public void get_weight3(){} // RVA: 0x7FFAC2F44D00
        public void set_weight3(){} // RVA: 0x7FFAC4A9B8C0
        public void get_boneIndex0(){} // RVA: 0x7FFAC9851CE0
        public void set_boneIndex0(){} // RVA: 0x7FFAC2F240C0
        public void get_boneIndex1(){} // RVA: 0x7FFAC5872100
        public void set_boneIndex1(){} // RVA: 0x7FFAC33D4990
        public void get_boneIndex2(){} // RVA: 0x7FFAC669DCA0
        public void set_boneIndex2(){} // RVA: 0x7FFAC392CD10
        public void get_boneIndex3(){} // RVA: 0x7FFAC5CC4740
        public void set_boneIndex3(){} // RVA: 0x7FFAC44474D0
        public void GetHashCode(){} // RVA: 0x7FFAC98974D0
        public void Equals(){} // RVA: 0x7FFAC9897680 | overloaded x2
    }

    public class BootConfigData : Object
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void WrapBootConfigData(){} // RVA: 0x7FFAC98550E0
        public void .ctor(){} // RVA: 0x7FFAC9855170
    }

    public class BoundingSphere : ValueType
    {
        public UnityEngine.Vector3 position; // 0x10
        public float radius; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9828D90
    }

    public class Bounds : ValueType
    {
        public UnityEngine.Vector3 center; // 0x10
        public UnityEngine.Vector3 size; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9863E50
        public void GetHashCode(){} // RVA: 0x7FFAC5DA2780
        public void Equals(){} // RVA: 0x7FFAC9863FB0 | overloaded x2
        public void get_center(){} // RVA: 0x7FFAC9811DA0
        public void set_center(){} // RVA: 0x7FFAC530B6C0
        public void get_size(){} // RVA: 0x7FFAC9864040
        public void set_size(){} // RVA: 0x7FFAC9864080
        public void get_extents(){} // RVA: 0x7FFAC9811DC0
        public void set_extents(){} // RVA: 0x7FFAC9811DE0
        public void get_min(){} // RVA: 0x7FFAC98640C0
        public void set_min(){} // RVA: 0x7FFAC9864100
        public void get_max(){} // RVA: 0x7FFAC9864190
        public void set_max(){} // RVA: 0x7FFAC98641D0
        public void op_Equality(){} // RVA: 0x7FFAC9864270
        public void op_Inequality(){} // RVA: 0x7FFAC9864310
        public void SetMinMax(){} // RVA: 0x7FFAC98643D0
        public void Encapsulate(){} // RVA: 0x7FFAC2F6E270 | overloaded x2
        public void Expand(){} // RVA: 0x7FFAC9864490 | overloaded x2
        public void Intersects(){} // RVA: 0x7FFAC3E1D8C0
        public void IntersectRay(){} // RVA: 0x7FFAC9864580 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC9864620 | overloaded x3
        public void Contains(){} // RVA: 0x7FFAC98647D0
        public void SqrDistance(){} // RVA: 0x7FFAC9864830
        public void IntersectRayAABB(){} // RVA: 0x7FFAC9864890
        public void ClosestPoint(){} // RVA: 0x7FFAC9864900
        public void Contains_Injected(){} // RVA: 0x7FFAC9864980
        public void SqrDistance_Injected(){} // RVA: 0x7FFAC98649E0
        public void IntersectRayAABB_Injected(){} // RVA: 0x7FFAC9864A40
        public void ClosestPoint_Injected(){} // RVA: 0x7FFAC9864AB0
    }

    public class BoundsInt : ValueType
    {
        public UnityEngine.Vector3Int min; // 0x10
        public UnityEngine.Vector3Int xMin; // 0x1C

        // ── Methods ──
        public void get_min(){} // RVA: 0x7FFAC9864B20
        public void get_xMin(){} // RVA: 0x7FFAC9864B80
        public void get_yMin(){} // RVA: 0x7FFAC9864BF0
        public void get_zMin(){} // RVA: 0x7FFAC9864C60
        public void get_position(){} // RVA: 0x7FFAC9811DA0
        public void set_position(){} // RVA: 0x7FFAC530B6C0
        public void get_size(){} // RVA: 0x7FFAC9811DC0
        public void set_size(){} // RVA: 0x7FFAC9811DE0
        public void .ctor(){} // RVA: 0x7FFAC2F2ADF0
        public void ToString(){} // RVA: 0x7FFAC9864CE0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC9864F10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9864FC0
    }

    public class BoxCollider : Collider
    {
        public object center;
        public object size;
        public object extents;

        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFAC999A160
        public void set_center(){} // RVA: 0x7FFAC999A1D0
        public void get_size(){} // RVA: 0x7FFAC999A230
        public void set_size(){} // RVA: 0x7FFAC999A2A0
        public void get_extents(){} // RVA: 0x7FFAC999A300
        public void set_extents(){} // RVA: 0x7FFAC999A3B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_center_Injected(){} // RVA: 0x7FFAC999A440
        public void set_center_Injected(){} // RVA: 0x7FFAC999A4A0
        public void get_size_Injected(){} // RVA: 0x7FFAC999A500
        public void set_size_Injected(){} // RVA: 0x7FFAC999A560
    }

    public class BoxCollider2D : Collider2D
    {
        public object size;
        public object edgeRadius;
        public object autoTiling;

        // ── Methods ──
        public void get_size(){} // RVA: 0x7FFAC9981490
        public void set_size(){} // RVA: 0x7FFAC99814F0
        public void get_edgeRadius(){} // RVA: 0x7FFAC9981550
        public void set_edgeRadius(){} // RVA: 0x7FFAC99815A0
        public void get_autoTiling(){} // RVA: 0x7FFAC9981600
        public void set_autoTiling(){} // RVA: 0x7FFAC9981650
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_size_Injected(){} // RVA: 0x7FFAC99816B0
        public void set_size_Injected(){} // RVA: 0x7FFAC9981710
    }

}