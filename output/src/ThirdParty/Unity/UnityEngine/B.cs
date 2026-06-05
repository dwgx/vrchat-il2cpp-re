// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 14
// Methods: 112

namespace ThirdParty.Unity.UnityEngine
{
    public class BeforeRenderHelper
    {
        // ── Methods ──
        public void GetUpdateOrder(){} // RVA: 0x7FFAF9B817D0
        public void RegisterCallback(){} // RVA: 0x7FFAF9B81960
        public void UnregisterCallback(){} // RVA: 0x7FFAF9B81EF0
        public void Invoke(){} // RVA: 0x7FFAF9B823B0
        public void .cctor(){} // RVA: 0x7FFAF9B82630
    }

    public class BeforeRenderOrderAttribute
    {
        // ── Methods ──
        public void get_order(){} // RVA: 0x7FFAF2DDA5C0
        public void set_order(){} // RVA: 0x7FFAF2D900C0
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
    }

    public class Behaviour
    {
        public object transform;
        public object gameObject;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFAF2DF3DE0
        public void set_enabled(){} // RVA: 0x7FFAF3C895B0
        public void get_isActiveAndEnabled(){} // RVA: 0x7FFAF9BD2760
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class BillboardAsset
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B82710
        public void Internal_Create(){} // RVA: 0x7FFAF9B827A0
    }

    public class BillboardRenderer
    {
        // ── Methods ──
        public void get_billboard(){} // RVA: 0x7FFAF9B827F0
        public void set_billboard(){} // RVA: 0x7FFAF9B82840
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class BlendShape
    {
        public object weight0;
        public object weight1;

        // ── Methods ──
        public void get_firstVertex(){} // RVA: 0x7FFAF92AD0D0
        public void get_vertexCount(){} // RVA: 0x7FFAF6B67110
    }

    public class BlendShapeBufferRange
    {
        public object mesh;
        public object subMeshIndex;

        // ── Methods ──
        public void set_startIndex(){} // RVA: 0x7FFAF32E3580
        public void set_endIndex(){} // RVA: 0x7FFAF44189D0
    }

    public class BoneWeight
    {
        // ── Methods ──
        public void get_weight0(){} // RVA: 0x7FFAF2DB0D20
        public void set_weight0(){} // RVA: 0x7FFAF4A28330
        public void get_weight1(){} // RVA: 0x7FFAF2DB0D30
        public void set_weight1(){} // RVA: 0x7FFAF4A28350
        public void get_weight2(){} // RVA: 0x7FFAF2DB0CF0
        public void set_weight2(){} // RVA: 0x7FFAF4A28340
        public void get_weight3(){} // RVA: 0x7FFAF2DB0D00
        public void set_weight3(){} // RVA: 0x7FFAF4A28380
        public void get_boneIndex0(){} // RVA: 0x7FFAF9B692A0
        public void set_boneIndex0(){} // RVA: 0x7FFAF2D900C0
        public void get_boneIndex1(){} // RVA: 0x7FFAF5990010
        public void set_boneIndex1(){} // RVA: 0x7FFAF335C660
        public void get_boneIndex2(){} // RVA: 0x7FFAF6842310
        public void set_boneIndex2(){} // RVA: 0x7FFAF30E74E0
        public void get_boneIndex3(){} // RVA: 0x7FFAF5E66D30
        public void set_boneIndex3(){} // RVA: 0x7FFAF4439FD0
        public void GetHashCode(){} // RVA: 0x7FFAF9BAF180
        public void Equals(){} // RVA: 0x7FFAF9BAF330 | overloaded x2
    }

    public class BootConfigData
    {
        // ── Methods ──
        public void WrapBootConfigData(){} // RVA: 0x7FFAF9B6C650
        public void .ctor(){} // RVA: 0x7FFAF9B6C6E0
    }

    public class BoundingSphere
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF74763E0
    }

    public class Bounds
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B7B480
        public void GetHashCode(){} // RVA: 0x7FFAF5F27800
        public void Equals(){} // RVA: 0x7FFAF9B7B5E0 | overloaded x2
        public void get_center(){} // RVA: 0x7FFAF9B29450
        public void set_center(){} // RVA: 0x7FFAF4BBE450
        public void get_size(){} // RVA: 0x7FFAF9B7B670
        public void set_size(){} // RVA: 0x7FFAF9B7B6B0
        public void get_extents(){} // RVA: 0x7FFAF9B29470
        public void set_extents(){} // RVA: 0x7FFAF9B29490
        public void get_min(){} // RVA: 0x7FFAF9B7B6F0
        public void set_min(){} // RVA: 0x7FFAF9B7B730
        public void get_max(){} // RVA: 0x7FFAF9B7B7C0
        public void set_max(){} // RVA: 0x7FFAF9B7B800
        public void op_Equality(){} // RVA: 0x7FFAF9B7B8A0
        public void op_Inequality(){} // RVA: 0x7FFAF9B7B940
        public void SetMinMax(){} // RVA: 0x7FFAF9B7BA00
        public void Encapsulate(){} // RVA: 0x7FFAF2DDA270 | overloaded x2
        public void Expand(){} // RVA: 0x7FFAF9B7BAC0 | overloaded x2
        public void Intersects(){} // RVA: 0x7FFAF3DFE4C0
        public void IntersectRay(){} // RVA: 0x7FFAF9B7BBB0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF9B7BC50 | overloaded x3
        public void Contains(){} // RVA: 0x7FFAF9B7BE00
        public void SqrDistance(){} // RVA: 0x7FFAF9B7BE60
        public void IntersectRayAABB(){} // RVA: 0x7FFAF9B7BEC0
        public void ClosestPoint(){} // RVA: 0x7FFAF9B7BF30
        public void Contains_Injected(){} // RVA: 0x7FFAF9B7BFB0
        public void SqrDistance_Injected(){} // RVA: 0x7FFAF9B7C010
        public void IntersectRayAABB_Injected(){} // RVA: 0x7FFAF9B7C070
        public void ClosestPoint_Injected(){} // RVA: 0x7FFAF9B7C0E0
    }

    public class BoundsInt
    {
        // ── Methods ──
        public void get_min(){} // RVA: 0x7FFAF9B7C150
        public void get_xMin(){} // RVA: 0x7FFAF9B7C1B0
        public void get_yMin(){} // RVA: 0x7FFAF9B7C220
        public void get_zMin(){} // RVA: 0x7FFAF9B7C290
        public void get_position(){} // RVA: 0x7FFAF9B29450
        public void set_position(){} // RVA: 0x7FFAF4BBE450
        public void get_size(){} // RVA: 0x7FFAF9B29470
        public void set_size(){} // RVA: 0x7FFAF9B29490
        public void .ctor(){} // RVA: 0x7FFAF2D96DF0
        public void ToString(){} // RVA: 0x7FFAF9B7C310 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAF9B7C540 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF9B7C5F0
    }

    public class BoxCollider
    {
        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFAF9CB2860
        public void set_center(){} // RVA: 0x7FFAF9CB28D0
        public void get_size(){} // RVA: 0x7FFAF9CB2930
        public void set_size(){} // RVA: 0x7FFAF9CB29A0
        public void get_extents(){} // RVA: 0x7FFAF9CB2A00
        public void set_extents(){} // RVA: 0x7FFAF9CB2AB0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_center_Injected(){} // RVA: 0x7FFAF9CB2B40
        public void set_center_Injected(){} // RVA: 0x7FFAF9CB2BA0
        public void get_size_Injected(){} // RVA: 0x7FFAF9CB2C00
        public void set_size_Injected(){} // RVA: 0x7FFAF9CB2C60
    }

    public class BoxCollider2D
    {
        public object size;
        public object direction;

        // ── Methods ──
        public void get_size(){} // RVA: 0x7FFAF9C99B90
        public void set_size(){} // RVA: 0x7FFAF9C99BF0
        public void get_edgeRadius(){} // RVA: 0x7FFAF9C99C50
        public void set_edgeRadius(){} // RVA: 0x7FFAF9C99CA0
        public void get_autoTiling(){} // RVA: 0x7FFAF9C99D00
        public void set_autoTiling(){} // RVA: 0x7FFAF9C99D50
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_size_Injected(){} // RVA: 0x7FFAF9C99DB0
        public void set_size_Injected(){} // RVA: 0x7FFAF9C99E10
    }

}