// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 14
// Methods: 112

namespace ThirdParty.Unity.UnityEngine
{
    public class BeforeRenderHelper
    {
        // ── Methods ──
        public void GetUpdateOrder(){} // RVA: 0x70D17D0
        public void RegisterCallback(){} // RVA: 0x70D1960
        public void UnregisterCallback(){} // RVA: 0x70D1EF0
        public void Invoke(){} // RVA: 0x70D23B0
        public void .cctor(){} // RVA: 0x70D2630
    }

    public class BeforeRenderOrderAttribute
    {
        public int <order>k__BackingField; // 0x10

        // ── Methods ──
        public void get_order(){} // RVA: 0x32A5C0
        public void set_order(){} // RVA: 0x2E00C0
        public void .ctor(){} // RVA: 0x2E00C0
    }

    public class Behaviour
    {
        public object transform;
        public object gameObject;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x343DE0
        public void set_enabled(){} // RVA: 0x11D95B0
        public void get_isActiveAndEnabled(){} // RVA: 0x7122760
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class BillboardAsset
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70D2710
        public void Internal_Create(){} // RVA: 0x70D27A0
    }

    public class BillboardRenderer
    {
        // ── Methods ──
        public void get_billboard(){} // RVA: 0x70D27F0
        public void set_billboard(){} // RVA: 0x70D2840
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class BlendShape
    {
        public uint weight0; // 0x10
        public uint weight1; // 0x14

        // ── Methods ──
        public void get_firstVertex(){} // RVA: 0x67FD0D0
        public void get_vertexCount(){} // RVA: 0x40B7110
    }

    public class BlendShapeBufferRange
    {
        public uint mesh; // 0x10
        public uint subMeshIndex; // 0x14

        // ── Methods ──
        public void set_startIndex(){} // RVA: 0x833580
        public void set_endIndex(){} // RVA: 0x19689D0
    }

    public class BoneWeight
    {
        public float m_Weight0; // 0x10
        public float m_Weight1; // 0x14
        public float m_Weight2; // 0x18
        public float m_Weight3; // 0x1C
        public int m_BoneIndex0; // 0x20
        public int m_BoneIndex1; // 0x24
        public int m_BoneIndex2; // 0x28
        public int m_BoneIndex3; // 0x2C

        // ── Methods ──
        public void get_weight0(){} // RVA: 0x300D20
        public void set_weight0(){} // RVA: 0x1F78330
        public void get_weight1(){} // RVA: 0x300D30
        public void set_weight1(){} // RVA: 0x1F78350
        public void get_weight2(){} // RVA: 0x300CF0
        public void set_weight2(){} // RVA: 0x1F78340
        public void get_weight3(){} // RVA: 0x300D00
        public void set_weight3(){} // RVA: 0x1F78380
        public void get_boneIndex0(){} // RVA: 0x70B92A0
        public void set_boneIndex0(){} // RVA: 0x2E00C0
        public void get_boneIndex1(){} // RVA: 0x2EE0010
        public void set_boneIndex1(){} // RVA: 0x8AC660
        public void get_boneIndex2(){} // RVA: 0x3D92310
        public void set_boneIndex2(){} // RVA: 0x6374E0
        public void get_boneIndex3(){} // RVA: 0x33B6D30
        public void set_boneIndex3(){} // RVA: 0x1989FD0
        public void GetHashCode(){} // RVA: 0x70FF180
        public void Equals(){} // RVA: 0x70FF330 | overloaded x2
    }

    public class BootConfigData
    {
        // ── Methods ──
        public void WrapBootConfigData(){} // RVA: 0x70BC650
        public void .ctor(){} // RVA: 0x70BC6E0
    }

    public class BoundingSphere
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x49C63E0
    }

    public class Bounds
    {
        public UnityEngine.Vector3 m_Center; // 0x10
        public UnityEngine.Vector3 m_Extents; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70CB480
        public void GetHashCode(){} // RVA: 0x3477800
        public void Equals(){} // RVA: 0x70CB5E0 | overloaded x2
        public void get_center(){} // RVA: 0x7079450
        public void set_center(){} // RVA: 0x210E450
        public void get_size(){} // RVA: 0x70CB670
        public void set_size(){} // RVA: 0x70CB6B0
        public void get_extents(){} // RVA: 0x7079470
        public void set_extents(){} // RVA: 0x7079490
        public void get_min(){} // RVA: 0x70CB6F0
        public void set_min(){} // RVA: 0x70CB730
        public void get_max(){} // RVA: 0x70CB7C0
        public void set_max(){} // RVA: 0x70CB800
        public void op_Equality(){} // RVA: 0x70CB8A0
        public void op_Inequality(){} // RVA: 0x70CB940
        public void SetMinMax(){} // RVA: 0x70CBA00
        public void Encapsulate(){} // RVA: 0x32A270 | overloaded x2
        public void Expand(){} // RVA: 0x70CBAC0 | overloaded x2
        public void Intersects(){} // RVA: 0x134E4C0
        public void IntersectRay(){} // RVA: 0x70CBBB0 | overloaded x2
        public void ToString(){} // RVA: 0x70CBC50 | overloaded x3
        public void Contains(){} // RVA: 0x70CBE00
        public void SqrDistance(){} // RVA: 0x70CBE60
        public void IntersectRayAABB(){} // RVA: 0x70CBEC0
        public void ClosestPoint(){} // RVA: 0x70CBF30
        public void Contains_Injected(){} // RVA: 0x70CBFB0
        public void SqrDistance_Injected(){} // RVA: 0x70CC010
        public void IntersectRayAABB_Injected(){} // RVA: 0x70CC070
        public void ClosestPoint_Injected(){} // RVA: 0x70CC0E0
    }

    public class BoundsInt
    {
        public UnityEngine.Vector3Int m_Position; // 0x10
        public UnityEngine.Vector3Int m_Size; // 0x1C

        // ── Methods ──
        public void get_min(){} // RVA: 0x70CC150
        public void get_xMin(){} // RVA: 0x70CC1B0
        public void get_yMin(){} // RVA: 0x70CC220
        public void get_zMin(){} // RVA: 0x70CC290
        public void get_position(){} // RVA: 0x7079450
        public void set_position(){} // RVA: 0x210E450
        public void get_size(){} // RVA: 0x7079470
        public void set_size(){} // RVA: 0x7079490
        public void .ctor(){} // RVA: 0x2E6DF0
        public void ToString(){} // RVA: 0x70CC310 | overloaded x2
        public void Equals(){} // RVA: 0x70CC540 | overloaded x2
        public void GetHashCode(){} // RVA: 0x70CC5F0
    }

    public class BoxCollider
    {
        // ── Methods ──
        public void get_center(){} // RVA: 0x7202860
        public void set_center(){} // RVA: 0x72028D0
        public void get_size(){} // RVA: 0x7202930
        public void set_size(){} // RVA: 0x72029A0
        public void get_extents(){} // RVA: 0x7202A00
        public void set_extents(){} // RVA: 0x7202AB0
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_center_Injected(){} // RVA: 0x7202B40
        public void set_center_Injected(){} // RVA: 0x7202BA0
        public void get_size_Injected(){} // RVA: 0x7202C00
        public void set_size_Injected(){} // RVA: 0x7202C60
    }

    public class BoxCollider2D
    {
        public object size;
        public object direction;

        // ── Methods ──
        public void get_size(){} // RVA: 0x71E9B90
        public void set_size(){} // RVA: 0x71E9BF0
        public void get_edgeRadius(){} // RVA: 0x71E9C50
        public void set_edgeRadius(){} // RVA: 0x71E9CA0
        public void get_autoTiling(){} // RVA: 0x71E9D00
        public void set_autoTiling(){} // RVA: 0x71E9D50
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_size_Injected(){} // RVA: 0x71E9DB0
        public void set_size_Injected(){} // RVA: 0x71E9E10
    }

}