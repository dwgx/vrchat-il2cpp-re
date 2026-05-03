// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 14
// Methods: 112

namespace ThirdParty.Unity.UnityEngine
{
    public class BeforeRenderHelper : Object
    {
        // ── Methods ──
        public void GetUpdateOrder(){} // RVA: 0x7FFE87C126A0
        public void RegisterCallback(){} // RVA: 0x7FFE87C12830
        public void UnregisterCallback(){} // RVA: 0x7FFE87C12DC0
        public void Invoke(){} // RVA: 0x7FFE87C13280
        public void .cctor(){} // RVA: 0x7FFE87C13500
    }

    public class BeforeRenderOrderAttribute : Attribute
    {
        public int _order; // 0x10

        // ── Methods ──
        public void get_order(){} // RVA: 0x7FFE811485C0
        public void set_order(){} // RVA: 0x7FFE810FE0C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class Behaviour : Component
    {
        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFE81161DE0
        public void set_enabled(){} // RVA: 0x7FFE81F63B50
        public void get_isActiveAndEnabled(){} // RVA: 0x7FFE87C63420
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class BillboardAsset : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C135E0
        public void Internal_Create(){} // RVA: 0x7FFE87C13670
    }

    public class BillboardRenderer : Renderer
    {
        // ── Methods ──
        public void get_billboard(){} // RVA: 0x7FFE87C136C0
        public void set_billboard(){} // RVA: 0x7FFE87C13710
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class BlendShape : ValueType
    {
        public uint m_FirstVertex; // 0x10
        public uint m_VertexCount; // 0x14

        // ── Methods ──
        public void get_firstVertex(){} // RVA: 0x7FFE8733C3B0
        public void get_vertexCount(){} // RVA: 0x7FFE84D2D330
    }

    public class BlendShapeBufferRange : ValueType
    {
        public uint m_StartIndex; // 0x10
        public uint m_EndIndex; // 0x14

        // ── Methods ──
        public void set_startIndex(){} // RVA: 0x7FFE815BF990
        public void set_endIndex(){} // RVA: 0x7FFE826F4290
    }

    public class BoneWeight : ValueType
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
        public void get_weight0(){} // RVA: 0x7FFE8111ED20
        public void set_weight0(){} // RVA: 0x7FFE82D03BB0
        public void get_weight1(){} // RVA: 0x7FFE8111ED30
        public void set_weight1(){} // RVA: 0x7FFE82D03BD0
        public void get_weight2(){} // RVA: 0x7FFE8111ECF0
        public void set_weight2(){} // RVA: 0x7FFE82D03BC0
        public void get_weight3(){} // RVA: 0x7FFE8111ED00
        public void set_weight3(){} // RVA: 0x7FFE82D03B80
        public void get_boneIndex0(){} // RVA: 0x7FFE87BFA280
        public void set_boneIndex0(){} // RVA: 0x7FFE810FE0C0
        public void get_boneIndex1(){} // RVA: 0x7FFE83BAF260
        public void set_boneIndex1(){} // RVA: 0x7FFE8164E0F0
        public void get_boneIndex2(){} // RVA: 0x7FFE84A02990
        public void set_boneIndex2(){} // RVA: 0x7FFE8144DF00
        public void get_boneIndex3(){} // RVA: 0x7FFE84022BD0
        public void set_boneIndex3(){} // RVA: 0x7FFE82717690
        public void GetHashCode(){} // RVA: 0x7FFE87C3FDD0
        public void Equals(){} // RVA: 0x7FFE87C3FF80 | overloaded x2
    }

    public class BootConfigData : Object
    {
        // ── Methods ──
        public void WrapBootConfigData(){} // RVA: 0x7FFE87BFD630
        public void .ctor(){} // RVA: 0x7FFE87BFD6C0
    }

    public class BoundingSphere : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE855C19C0
    }

    public class Bounds : ValueType
    {
        public UnityEngine.Vector3 m_Center; // 0x10
        public UnityEngine.Vector3 m_Extents; // 0x1C
        public object System;
        public object System;
        public object field_4; // 0x35D0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C0C3A0
        public void GetHashCode(){} // RVA: 0x7FFE84109E70
        public void Equals(){} // RVA: 0x7FFE87C0C500 | overloaded x2
        public void get_center(){} // RVA: 0x7FFE87BBA310
        public void set_center(){} // RVA: 0x7FFE835C1F00
        public void get_size(){} // RVA: 0x7FFE87C0C590
        public void set_size(){} // RVA: 0x7FFE87C0C5D0
        public void get_extents(){} // RVA: 0x7FFE87BBA330
        public void set_extents(){} // RVA: 0x7FFE87BBA350
        public void get_min(){} // RVA: 0x7FFE87C0C610
        public void set_min(){} // RVA: 0x7FFE87C0C650
        public void get_max(){} // RVA: 0x7FFE87C0C6E0
        public void set_max(){} // RVA: 0x7FFE87C0C720
        public void op_Equality(){} // RVA: 0x7FFE87C0C7C0
        public void op_Inequality(){} // RVA: 0x7FFE87C0C860
        public void SetMinMax(){} // RVA: 0x7FFE87C0C920
        public void Encapsulate(){} // RVA: 0x7FFE81148270 | overloaded x2
        public void Expand(){} // RVA: 0x7FFE87C0C9E0 | overloaded x2
        public void Intersects(){} // RVA: 0x7FFE820C83C0
        public void IntersectRay(){} // RVA: 0x7FFE87C0CAD0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE87C0CB70 | overloaded x3
        public void Contains(){} // RVA: 0x7FFE87C0CD20
        public void SqrDistance(){} // RVA: 0x7FFE87C0CD80
        public void IntersectRayAABB(){} // RVA: 0x7FFE87C0CDE0
        public void ClosestPoint(){} // RVA: 0x7FFE87C0CE50
        public void Contains_Injected(){} // RVA: 0x7FFE87C0CED0
        public void SqrDistance_Injected(){} // RVA: 0x7FFE87C0CF30
        public void IntersectRayAABB_Injected(){} // RVA: 0x7FFE87C0CF90
        public void ClosestPoint_Injected(){} // RVA: 0x7FFE87C0D000
    }

    public class BoundsInt : ValueType
    {
        public UnityEngine.Vector3Int m_Position; // 0x10
        public UnityEngine.Vector3Int m_Size; // 0x1C
        public object System;
        public object System;
        public object field_4; // 0x3810
        public object field_5;

        // ── Methods ──
        public void get_min(){} // RVA: 0x7FFE87C0D070
        public void get_xMin(){} // RVA: 0x7FFE87C0D0D0
        public void get_yMin(){} // RVA: 0x7FFE87C0D140
        public void get_zMin(){} // RVA: 0x7FFE87C0D1B0
        public void get_position(){} // RVA: 0x7FFE87BBA310
        public void set_position(){} // RVA: 0x7FFE835C1F00
        public void get_size(){} // RVA: 0x7FFE87BBA330
        public void set_size(){} // RVA: 0x7FFE87BBA350
        public void .ctor(){} // RVA: 0x7FFE81104DF0
        public void ToString(){} // RVA: 0x7FFE87C0D230 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE87C0D460 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87C0D510
    }

    public class BoxCollider : Collider
    {
        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFE87D42A00
        public void set_center(){} // RVA: 0x7FFE87D42A70
        public void get_size(){} // RVA: 0x7FFE87D42AD0
        public void set_size(){} // RVA: 0x7FFE87D42B40
        public void get_extents(){} // RVA: 0x7FFE87D42BA0
        public void set_extents(){} // RVA: 0x7FFE87D42C50
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_center_Injected(){} // RVA: 0x7FFE87D42CE0
        public void set_center_Injected(){} // RVA: 0x7FFE87D42D40
        public void get_size_Injected(){} // RVA: 0x7FFE87D42DA0
        public void set_size_Injected(){} // RVA: 0x7FFE87D42E00
    }

    public class BoxCollider2D : Collider2D
    {
        // ── Methods ──
        public void get_size(){} // RVA: 0x7FFE87D29D30
        public void set_size(){} // RVA: 0x7FFE87D29D90
        public void get_edgeRadius(){} // RVA: 0x7FFE87D29DF0
        public void set_edgeRadius(){} // RVA: 0x7FFE87D29E40
        public void get_autoTiling(){} // RVA: 0x7FFE87D29EA0
        public void set_autoTiling(){} // RVA: 0x7FFE87D29EF0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_size_Injected(){} // RVA: 0x7FFE87D29F50
        public void set_size_Injected(){} // RVA: 0x7FFE87D29FB0
    }

}