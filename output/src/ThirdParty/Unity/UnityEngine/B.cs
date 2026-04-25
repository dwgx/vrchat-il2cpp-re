// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 11
// Methods: 102

namespace ThirdParty.Unity.UnityEngine
{
    public class Behaviour : Component
    {
        public object enabled;
        public object isActiveAndEnabled;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFD4E3A7DE0
        public void set_enabled(){} // RVA: 0x7FFD4F117970
        public void get_isActiveAndEnabled(){} // RVA: 0x7FFD54CDACF0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class BillboardAsset : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C8B090
        public void Internal_Create(){} // RVA: 0x7FFD54C8B120
    }

    public class BillboardRenderer : Renderer
    {
        public object billboard;

        // ── Methods ──
        public void get_billboard(){} // RVA: 0x7FFD54C8B170
        public void set_billboard(){} // RVA: 0x7FFD54C8B1C0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class BlendShape : ValueType
    {
        public uint firstVertex; // 0x10
        public uint vertexCount; // 0x14
        public bool m_HasNormals; // 0x18
        public bool m_HasTangents; // 0x19

        // ── Methods ──
        public void get_firstVertex(){} // RVA: 0x7FFD543B3F90
        public void get_vertexCount(){} // RVA: 0x7FFD51DEBEA0
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
        public void get_weight0(){} // RVA: 0x7FFD4E364D20
        public void set_weight0(){} // RVA: 0x7FFD4FEBB910
        public void get_weight1(){} // RVA: 0x7FFD4E364D30
        public void set_weight1(){} // RVA: 0x7FFD4FEBB8F0
        public void get_weight2(){} // RVA: 0x7FFD4E364CF0
        public void set_weight2(){} // RVA: 0x7FFD4FEBB920
        public void get_weight3(){} // RVA: 0x7FFD4E364D00
        public void set_weight3(){} // RVA: 0x7FFD4FEBB8C0
        public void get_boneIndex0(){} // RVA: 0x7FFD54C71CE0
        public void set_boneIndex0(){} // RVA: 0x7FFD4E3440C0
        public void get_boneIndex1(){} // RVA: 0x7FFD50C92100
        public void set_boneIndex1(){} // RVA: 0x7FFD4E7F4990
        public void get_boneIndex2(){} // RVA: 0x7FFD51ABDCA0
        public void set_boneIndex2(){} // RVA: 0x7FFD4ED4CD10
        public void get_boneIndex3(){} // RVA: 0x7FFD510E4740
        public void set_boneIndex3(){} // RVA: 0x7FFD4F8674D0
        public void GetHashCode(){} // RVA: 0x7FFD54CB74D0
        public void Equals(){} // RVA: 0x7FFD54CB7680 | overloaded x2
    }

    public class BootConfigData : Object
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void WrapBootConfigData(){} // RVA: 0x7FFD54C750E0
        public void .ctor(){} // RVA: 0x7FFD54C75170
    }

    public class BoundingSphere : ValueType
    {
        public UnityEngine.Vector3 position; // 0x10
        public float radius; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C48D90
    }

    public class Bounds : ValueType
    {
        public UnityEngine.Vector3 center; // 0x10
        public UnityEngine.Vector3 size; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C83E50
        public void GetHashCode(){} // RVA: 0x7FFD511C2780
        public void Equals(){} // RVA: 0x7FFD54C83FB0 | overloaded x2
        public void get_center(){} // RVA: 0x7FFD54C31DA0
        public void set_center(){} // RVA: 0x7FFD5072B6C0
        public void get_size(){} // RVA: 0x7FFD54C84040
        public void set_size(){} // RVA: 0x7FFD54C84080
        public void get_extents(){} // RVA: 0x7FFD54C31DC0
        public void set_extents(){} // RVA: 0x7FFD54C31DE0
        public void get_min(){} // RVA: 0x7FFD54C840C0
        public void set_min(){} // RVA: 0x7FFD54C84100
        public void get_max(){} // RVA: 0x7FFD54C84190
        public void set_max(){} // RVA: 0x7FFD54C841D0
        public void op_Equality(){} // RVA: 0x7FFD54C84270
        public void op_Inequality(){} // RVA: 0x7FFD54C84310
        public void SetMinMax(){} // RVA: 0x7FFD54C843D0
        public void Encapsulate(){} // RVA: 0x7FFD4E38E270 | overloaded x2
        public void Expand(){} // RVA: 0x7FFD54C84490 | overloaded x2
        public void Intersects(){} // RVA: 0x7FFD4F23D8C0
        public void IntersectRay(){} // RVA: 0x7FFD54C84580 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD54C84620 | overloaded x3
        public void Contains(){} // RVA: 0x7FFD54C847D0
        public void SqrDistance(){} // RVA: 0x7FFD54C84830
        public void IntersectRayAABB(){} // RVA: 0x7FFD54C84890
        public void ClosestPoint(){} // RVA: 0x7FFD54C84900
        public void Contains_Injected(){} // RVA: 0x7FFD54C84980
        public void SqrDistance_Injected(){} // RVA: 0x7FFD54C849E0
        public void IntersectRayAABB_Injected(){} // RVA: 0x7FFD54C84A40
        public void ClosestPoint_Injected(){} // RVA: 0x7FFD54C84AB0
    }

    public class BoundsInt : ValueType
    {
        public UnityEngine.Vector3Int min; // 0x10
        public UnityEngine.Vector3Int xMin; // 0x1C

        // ── Methods ──
        public void get_min(){} // RVA: 0x7FFD54C84B20
        public void get_xMin(){} // RVA: 0x7FFD54C84B80
        public void get_yMin(){} // RVA: 0x7FFD54C84BF0
        public void get_zMin(){} // RVA: 0x7FFD54C84C60
        public void get_position(){} // RVA: 0x7FFD54C31DA0
        public void set_position(){} // RVA: 0x7FFD5072B6C0
        public void get_size(){} // RVA: 0x7FFD54C31DC0
        public void set_size(){} // RVA: 0x7FFD54C31DE0
        public void .ctor(){} // RVA: 0x7FFD4E34ADF0
        public void ToString(){} // RVA: 0x7FFD54C84CE0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD54C84F10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54C84FC0
    }

    public class BoxCollider : Collider
    {
        public object center;
        public object size;
        public object extents;

        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFD54DBA160
        public void set_center(){} // RVA: 0x7FFD54DBA1D0
        public void get_size(){} // RVA: 0x7FFD54DBA230
        public void set_size(){} // RVA: 0x7FFD54DBA2A0
        public void get_extents(){} // RVA: 0x7FFD54DBA300
        public void set_extents(){} // RVA: 0x7FFD54DBA3B0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_center_Injected(){} // RVA: 0x7FFD54DBA440
        public void set_center_Injected(){} // RVA: 0x7FFD54DBA4A0
        public void get_size_Injected(){} // RVA: 0x7FFD54DBA500
        public void set_size_Injected(){} // RVA: 0x7FFD54DBA560
    }

    public class BoxCollider2D : Collider2D
    {
        public object size;
        public object edgeRadius;
        public object autoTiling;

        // ── Methods ──
        public void get_size(){} // RVA: 0x7FFD54DA1490
        public void set_size(){} // RVA: 0x7FFD54DA14F0
        public void get_edgeRadius(){} // RVA: 0x7FFD54DA1550
        public void set_edgeRadius(){} // RVA: 0x7FFD54DA15A0
        public void get_autoTiling(){} // RVA: 0x7FFD54DA1600
        public void set_autoTiling(){} // RVA: 0x7FFD54DA1650
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_size_Injected(){} // RVA: 0x7FFD54DA16B0
        public void set_size_Injected(){} // RVA: 0x7FFD54DA1710
    }

}