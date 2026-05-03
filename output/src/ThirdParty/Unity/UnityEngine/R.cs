// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 37
// Methods: 1037

namespace ThirdParty.Unity.UnityEngine
{
    public class Random : Object
    {
        // ── Methods ──
        public void InitState(){} // RVA: 0x7FFE87C60810
        public void Range(){} // RVA: 0x7FFE87C608D0 | overloaded x2
        public void RandomRangeInt(){} // RVA: 0x7FFE87C608D0
        public void get_value(){} // RVA: 0x7FFE82493810
        public void get_insideUnitSphere(){} // RVA: 0x7FFE87C60930
        public void GetRandomUnitCircle(){} // RVA: 0x7FFE87C60990
        public void get_insideUnitCircle(){} // RVA: 0x7FFE87C609E0
        public void get_onUnitSphere(){} // RVA: 0x7FFE87C60A40
        public void get_rotation(){} // RVA: 0x7FFE87C60AA0
        public void get_rotationUniform(){} // RVA: 0x7FFE87C60B00
        public void ColorHSV(){} // RVA: 0x7FFE87C60D00 | overloaded x5
        public void get_insideUnitSphere_Injected(){} // RVA: 0x7FFE87C60F70
        public void get_onUnitSphere_Injected(){} // RVA: 0x7FFE87C60FC0
        public void get_rotation_Injected(){} // RVA: 0x7FFE87C61010
        public void get_rotationUniform_Injected(){} // RVA: 0x7FFE87C61060
    }

    public class RangeAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81E156F0
    }

    public class RangeInt : ValueType
    {
        public int start; // 0x10

        // ── Methods ──
        public void get_end(){} // RVA: 0x7FFE87C6B9C0
        public void .ctor(){} // RVA: 0x7FFE8164E250
    }

    public class Ray : ValueType
    {
        public UnityEngine.Vector3 m_Origin; // 0x10
        public UnityEngine.Vector3 m_Direction; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C0E8F0
        public void get_origin(){} // RVA: 0x7FFE87BBA310
        public void set_origin(){} // RVA: 0x7FFE835C1F00
        public void get_direction(){} // RVA: 0x7FFE87BBA330
        public void set_direction(){} // RVA: 0x7FFE87C0E930
        public void GetPoint(){} // RVA: 0x7FFE87C0E960
        public void ToString(){} // RVA: 0x7FFE87C0E9D0 | overloaded x3
    }

    public class RaycastCommand : ValueType
    {
        public UnityEngine.Vector3 _from; // 0x10
        public UnityEngine.Vector3 _direction; // 0x1C
        public UnityEngine.PhysicsScene _physicsScene; // 0x28
        public float _distance; // 0x2C

        // ── Methods ──
        public void set_from(){} // RVA: 0x7FFE835C1F00
        public void set_direction(){} // RVA: 0x7FFE87BBA350
        public void set_physicsScene(){} // RVA: 0x7FFE8144DF00
        public void set_distance(){} // RVA: 0x7FFE811C8580
        public void ScheduleBatch(){} // RVA: 0x7FFE87D4BA20
        public void ScheduleRaycastBatch(){} // RVA: 0x7FFE87D4BC50
        public void ScheduleRaycastBatch_Injected(){} // RVA: 0x7FFE87D4BD00
    }

    public class RaycastHit : ValueType
    {
        public UnityEngine.Vector3 m_Point; // 0x10
        public UnityEngine.Vector3 m_Normal; // 0x1C
        public uint m_FaceID; // 0x28
        public float m_Distance; // 0x2C
        public UnityEngine.Vector2 m_UV; // 0x30
        public int m_Collider; // 0x38
        public object field_6; // 0xDA30
        public object field_7; // 0xDBE8
        public object field_8; // 0xDDA0
        public object field_9;
        public object field_10;
        public object field_11;
        public object field_12;

        // ── Methods ──
        public void get_collider(){} // RVA: 0x7FFE87D3C5E0
        public void get_colliderInstanceID(){} // RVA: 0x7FFE850164C0
        public void get_point(){} // RVA: 0x7FFE87BBA310
        public void set_point(){} // RVA: 0x7FFE835C1F00
        public void get_normal(){} // RVA: 0x7FFE87BBA330
        public void set_normal(){} // RVA: 0x7FFE87BBA350
        public void get_barycentricCoordinate(){} // RVA: 0x7FFE87D3C6D0
        public void set_barycentricCoordinate(){} // RVA: 0x7FFE87D3C700
        public void get_distance(){} // RVA: 0x7FFE87BBD370
        public void set_distance(){} // RVA: 0x7FFE811C8580
        public void get_triangleIndex(){} // RVA: 0x7FFE84A02990
        public void CalculateRaycastTexCoord(){} // RVA: 0x7FFE87D3C720
        public void get_textureCoord(){} // RVA: 0x7FFE87D3C7C0
        public void get_textureCoord2(){} // RVA: 0x7FFE87D3C870
        public void get_transform(){} // RVA: 0x7FFE87D3C920
        public void get_rigidbody(){} // RVA: 0x7FFE87D3CB40
        public void get_articulationBody(){} // RVA: 0x7FFE87D3CC80
        public void get_lightmapCoord(){} // RVA: 0x7FFE87D3CDC0
        public void CalculateRaycastTexCoord_Injected(){} // RVA: 0x7FFE87D3D040
    }

    public class RaycastHit2D : ValueType
    {
        public UnityEngine.Vector2 m_Centroid; // 0x10
        public UnityEngine.Vector2 m_Point; // 0x18
        public UnityEngine.Vector2 m_Normal; // 0x20
        public float m_Distance; // 0x28
        public float m_Fraction; // 0x2C
        public int m_Collider; // 0x30
        public object field_6; // 0x85C8
        public object field_7; // 0x8780

        // ── Methods ──
        public void get_centroid(){} // RVA: 0x7FFE8348B260
        public void set_centroid(){} // RVA: 0x7FFE82889220
        public void get_point(){} // RVA: 0x7FFE87C0ED70
        public void set_point(){} // RVA: 0x7FFE82C72B10
        public void get_normal(){} // RVA: 0x7FFE87D201A0
        public void set_normal(){} // RVA: 0x7FFE826F2ED0
        public void get_distance(){} // RVA: 0x7FFE87BBA360
        public void set_distance(){} // RVA: 0x7FFE811164D0
        public void get_fraction(){} // RVA: 0x7FFE87BBD370
        public void set_fraction(){} // RVA: 0x7FFE811C8580
        public void get_collider(){} // RVA: 0x7FFE87D21840
        public void get_rigidbody(){} // RVA: 0x7FFE87D21930
        public void get_transform(){} // RVA: 0x7FFE87D21A70
        public void op_Implicit(){} // RVA: 0x7FFE87D21C90
        public void CompareTo(){} // RVA: 0x7FFE87D21D70
    }

    public class Rect : ValueType
    {
        public float m_XMin; // 0x10
        public float m_YMin; // 0x14
        public float m_Width; // 0x18
        public float m_Height; // 0x1C
        public object field_4; // 0x92E8
        public object field_5; // 0x94A0
        public object field_6; // 0x9658
        public object field_7; // 0x9810
        public object field_8; // 0x99C8
        public object field_9; // 0x9B80
        public object field_10; // 0x9D38
        public object field_11; // 0x9EF0
        public object field_12; // 0xA0A8
        public object field_13; // 0xA260

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82D03BE0 | overloaded x3
        public void get_zero(){} // RVA: 0x7FFE87C0EBC0
        public void MinMaxRect(){} // RVA: 0x7FFE87C0EBD0
        public void Set(){} // RVA: 0x7FFE8111F570
        public void get_x(){} // RVA: 0x7FFE8111ED20
        public void set_x(){} // RVA: 0x7FFE82D03BB0
        public void get_y(){} // RVA: 0x7FFE8111ED30
        public void set_y(){} // RVA: 0x7FFE82D03BD0
        public void get_position(){} // RVA: 0x7FFE87C0EC10
        public void set_position(){} // RVA: 0x7FFE87C0EC30
        public void get_center(){} // RVA: 0x7FFE87C0EC50
        public void set_center(){} // RVA: 0x7FFE87C0EC80
        public void get_min(){} // RVA: 0x7FFE87C0ECC0
        public void set_min(){} // RVA: 0x7FFE87C0ECE0
        public void get_max(){} // RVA: 0x7FFE87C0ED20
        public void set_max(){} // RVA: 0x7FFE87C0ED40
        public void get_width(){} // RVA: 0x7FFE8111ECF0
        public void set_width(){} // RVA: 0x7FFE82D03BC0
        public void get_height(){} // RVA: 0x7FFE8111ED00
        public void set_height(){} // RVA: 0x7FFE82D03B80
        public void get_size(){} // RVA: 0x7FFE87C0ED70
        public void set_size(){} // RVA: 0x7FFE87C0ED90
        public void get_xMin(){} // RVA: 0x7FFE8111ED20
        public void set_xMin(){} // RVA: 0x7FFE87C0EDB0
        public void get_yMin(){} // RVA: 0x7FFE8111ED30
        public void set_yMin(){} // RVA: 0x7FFE87C0EDD0
        public void get_xMax(){} // RVA: 0x7FFE87C0EDF0
        public void set_xMax(){} // RVA: 0x7FFE87C0EE00
        public void get_yMax(){} // RVA: 0x7FFE87C0EE10
        public void set_yMax(){} // RVA: 0x7FFE87C0EE20
        public void Contains(){} // RVA: 0x7FFE87C0EEB0 | overloaded x3
        public void OrderMinMax(){} // RVA: 0x7FFE87C0EFD0
        public void Overlaps(){} // RVA: 0x7FFE87C0F090 | overloaded x2
        public void NormalizedToPoint(){} // RVA: 0x7FFE87C0F1F0
        public void PointToNormalized(){} // RVA: 0x7FFE87C0F270
        public void op_Inequality(){} // RVA: 0x7FFE87C0F310
        public void op_Equality(){} // RVA: 0x7FFE87C0F360
        public void GetHashCode(){} // RVA: 0x7FFE87C0F3A0
        public void Equals(){} // RVA: 0x7FFE831D21D0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE87C0F4D0 | overloaded x3
    }

    public class RectInt : ValueType
    {
        public int m_XMin; // 0x10
        public int m_YMin; // 0x14
        public int m_Width; // 0x18
        public int m_Height; // 0x1C
        public object System;
        public object System;
        public object field_6; // 0x13D0
        public object field_7;

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFE8733C3B0
        public void set_x(){} // RVA: 0x7FFE815BF990
        public void get_y(){} // RVA: 0x7FFE84D2D330
        public void set_y(){} // RVA: 0x7FFE826F4290
        public void get_width(){} // RVA: 0x7FFE848C3400
        public void set_width(){} // RVA: 0x7FFE82C33010
        public void get_height(){} // RVA: 0x7FFE848EDA00
        public void set_height(){} // RVA: 0x7FFE82C33030
        public void get_xMin(){} // RVA: 0x7FFE87C0F860
        public void get_yMin(){} // RVA: 0x7FFE87C0F8D0
        public void get_xMax(){} // RVA: 0x7FFE87C0F940
        public void get_yMax(){} // RVA: 0x7FFE87C0F9B0
        public void .ctor(){} // RVA: 0x7FFE866C8F80
        public void Overlaps(){} // RVA: 0x7FFE87C0FA20
        public void ToString(){} // RVA: 0x7FFE87C0FAD0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE87C0FF20
    }

    public class RectOffset : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public object m_SourceStyle; // 0x18
        public object field_2; // 0x2CD0
        public object field_3; // 0x2E88
        public object field_4; // 0x3040
        public object field_5; // 0x31F8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C100A0 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFE87C10000
        public void ToString(){} // RVA: 0x7FFE87C10250 | overloaded x2
        public void Destroy(){} // RVA: 0x7FFE87C107B0
        public void InternalCreate(){} // RVA: 0x7FFE87C10820
        public void InternalDestroy(){} // RVA: 0x7FFE87C10870
        public void get_left(){} // RVA: 0x7FFE87C108C0
        public void set_left(){} // RVA: 0x7FFE87C10910
        public void get_right(){} // RVA: 0x7FFE87C10970
        public void set_right(){} // RVA: 0x7FFE87C109C0
        public void get_top(){} // RVA: 0x7FFE87C10A20
        public void set_top(){} // RVA: 0x7FFE87C10A70
        public void get_bottom(){} // RVA: 0x7FFE87C10AD0
        public void set_bottom(){} // RVA: 0x7FFE87C10B20
        public void get_horizontal(){} // RVA: 0x7FFE87C10B80
        public void get_vertical(){} // RVA: 0x7FFE87C10BD0
        public void Remove(){} // RVA: 0x7FFE87C10C20
        public void Remove_Injected(){} // RVA: 0x7FFE87C10CA0
    }

    public class RectTransform : Transform
    {
        public ReapplyDrivenProperties reapplyDrivenProperties;
        public object field_1; // 0xBB20
        public ReapplyDrivenProperties field_2; // 0x1898
        public object field_3; // 0xBB20
        public object field_4; // 0xBB20
        public object field_5; // 0xBB20
        public object field_6; // 0xBB20
        public object field_7; // 0xBB20
        public object field_8; // 0xBB20
        public object field_9; // 0xBB20
        public object field_10; // 0xBB20

        // ── Methods ──
        public void add_reapplyDrivenProperties(){} // RVA: 0x7FFE87C76AC0
        public void remove_reapplyDrivenProperties(){} // RVA: 0x7FFE87C76BD0
        public void get_rect(){} // RVA: 0x7FFE87C76CE0
        public void get_anchorMin(){} // RVA: 0x7FFE87C76D50
        public void set_anchorMin(){} // RVA: 0x7FFE87C76DB0
        public void get_anchorMax(){} // RVA: 0x7FFE87C76E10
        public void set_anchorMax(){} // RVA: 0x7FFE87C76E70
        public void get_anchoredPosition(){} // RVA: 0x7FFE87C76ED0
        public void set_anchoredPosition(){} // RVA: 0x7FFE87C76F30
        public void get_sizeDelta(){} // RVA: 0x7FFE87C76F90
        public void set_sizeDelta(){} // RVA: 0x7FFE87C76FF0
        public void get_pivot(){} // RVA: 0x7FFE87C77050
        public void set_pivot(){} // RVA: 0x7FFE87C770B0
        public void get_anchoredPosition3D(){} // RVA: 0x7FFE87C77110
        public void set_anchoredPosition3D(){} // RVA: 0x7FFE87C771F0
        public void get_offsetMin(){} // RVA: 0x7FFE87C77320
        public void set_offsetMin(){} // RVA: 0x7FFE87C77450
        public void get_offsetMax(){} // RVA: 0x7FFE87C777D0
        public void set_offsetMax(){} // RVA: 0x7FFE87C77960
        public void get_drivenByObject(){} // RVA: 0x7FFE87C77CC0
        public void set_drivenByObject(){} // RVA: 0x7FFE87C77D10
        public void get_drivenProperties(){} // RVA: 0x7FFE87C77D70
        public void set_drivenProperties(){} // RVA: 0x7FFE87C77DC0
        public void ForceUpdateRectTransforms(){} // RVA: 0x7FFE87C77E20
        public void GetLocalCorners(){} // RVA: 0x7FFE87C77E70
        public void GetWorldCorners(){} // RVA: 0x7FFE87C77FF0
        public void SetInsetAndSizeFromParentEdge(){} // RVA: 0x7FFE87C78360
        public void SetSizeWithCurrentAnchors(){} // RVA: 0x7FFE87C788B0
        public void SendReapplyDrivenProperties(){} // RVA: 0x7FFE87C78C10
        public void GetRectInParentSpace(){} // RVA: 0x7FFE87C78C70
        public void GetParentSize(){} // RVA: 0x7FFE87C79130
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_rect_Injected(){} // RVA: 0x7FFE87C79310
        public void get_anchorMin_Injected(){} // RVA: 0x7FFE87C79370
        public void set_anchorMin_Injected(){} // RVA: 0x7FFE87C793D0
        public void get_anchorMax_Injected(){} // RVA: 0x7FFE87C79430
        public void set_anchorMax_Injected(){} // RVA: 0x7FFE87C79490
        public void get_anchoredPosition_Injected(){} // RVA: 0x7FFE87C794F0
        public void set_anchoredPosition_Injected(){} // RVA: 0x7FFE87C79550
        public void get_sizeDelta_Injected(){} // RVA: 0x7FFE87C795B0
        public void set_sizeDelta_Injected(){} // RVA: 0x7FFE87C79610
        public void get_pivot_Injected(){} // RVA: 0x7FFE87C79670
        public void set_pivot_Injected(){} // RVA: 0x7FFE87C796D0
    }

    public class RectTransformUtility : Object
    {
        // ── Methods ──
        public void PixelAdjustPoint(){} // RVA: 0x7FFE87FDDF50
        public void PixelAdjustRect(){} // RVA: 0x7FFE87FDE000
        public void PointInRectangle(){} // RVA: 0x7FFE87FDE0B0
        public void RectangleContainsScreenPoint(){} // RVA: 0x7FFE87FDE290 | overloaded x3
        public void ScreenPointToWorldPointInRectangle(){} // RVA: 0x7FFE87FDE390
        public void ScreenPointToLocalPointInRectangle(){} // RVA: 0x7FFE87FDEA90
        public void ScreenPointToRay(){} // RVA: 0x7FFE87FDEC00
        public void WorldToScreenPoint(){} // RVA: 0x7FFE87FDEE90
        public void FlipLayoutOnAxis(){} // RVA: 0x7FFE87FDF000
        public void FlipLayoutAxes(){} // RVA: 0x7FFE87FDF6F0
        public void GetTransposed(){} // RVA: 0x7FFE87FDFCF0
        public void .cctor(){} // RVA: 0x7FFE87FDFD10
        public void PixelAdjustPoint_Injected(){} // RVA: 0x7FFE87FDFDD0
        public void PixelAdjustRect_Injected(){} // RVA: 0x7FFE87FDFE50
        public void PointInRectangle_Injected(){} // RVA: 0x7FFE87FDFEC0
    }

    public class ReflectionProbe : Behaviour
    {
        public System.Action`2<UnityEngine.ReflectionProbe,0x66573684> reflectionProbeChanged;
        public System.Collections.Generic.Dictionary`2<int,System.Action`1<UnityEngine.Texture>> registeredDefaultReflectionSetActions; // 0x8
        public System.Collections.Generic.List`1<System.Action`1<UnityEngine.Texture>> registeredDefaultReflectionTextureActions; // 0x10
        public object reflectionProbeChanged; // 0xBE40
        public object field_4; // 0x8
        public System.Action`1<UnityEngine.Cubemap> reflectionProbeChanged; // 0x6AB0
        public object field_6;
        public object field_7; // 0xD946
        public object field_8; // 0xE104
        public object field_9; // 0xF5A7
        public object field_10; // 0x8D69
        public object field_11; // 0xD4C2
        public object field_12; // 0xD4D0
        public object field_13; // 0xD824
        public object field_14; // 0x360D
        public object field_15; // 0xD82E
        public object field_16; // 0xD832
        public object field_17; // 0xD847
        public object field_18; // 0x4F30
        public object field_19; // 0xD506
        public object field_20; // 0xD4FB
        public object field_21; // 0xD4DD
        public object field_22; // 0xD856
        public object field_23; // 0xD864
        public object field_24; // 0x48C2
        public object field_25; // 0xD872
        public object field_26; // 0xD87D
        public object field_27; // 0xD552
        public object field_28; // 0xD889

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFE87C05160
        public void set_type(){} // RVA: 0x7FFE87C051B0
        public void get_size(){} // RVA: 0x7FFE87C05210
        public void set_size(){} // RVA: 0x7FFE87C05280
        public void get_center(){} // RVA: 0x7FFE87C052E0
        public void set_center(){} // RVA: 0x7FFE87C05350
        public void get_nearClipPlane(){} // RVA: 0x7FFE87C053B0
        public void set_nearClipPlane(){} // RVA: 0x7FFE87C05400
        public void get_farClipPlane(){} // RVA: 0x7FFE87C05460
        public void set_farClipPlane(){} // RVA: 0x7FFE87C054B0
        public void get_intensity(){} // RVA: 0x7FFE87C05510
        public void set_intensity(){} // RVA: 0x7FFE87C05560
        public void get_bounds(){} // RVA: 0x7FFE87C055C0
        public void get_hdr(){} // RVA: 0x7FFE87C05630
        public void set_hdr(){} // RVA: 0x7FFE87C05680
        public void get_renderDynamicObjects(){} // RVA: 0x7FFE87C056E0
        public void set_renderDynamicObjects(){} // RVA: 0x7FFE87C05730
        public void get_shadowDistance(){} // RVA: 0x7FFE87C05790
        public void set_shadowDistance(){} // RVA: 0x7FFE87C057E0
        public void get_resolution(){} // RVA: 0x7FFE87C05840
        public void set_resolution(){} // RVA: 0x7FFE87C05890
        public void get_cullingMask(){} // RVA: 0x7FFE87C058F0
        public void set_cullingMask(){} // RVA: 0x7FFE87C05940
        public void get_clearFlags(){} // RVA: 0x7FFE87C059A0
        public void set_clearFlags(){} // RVA: 0x7FFE87C059F0
        public void get_backgroundColor(){} // RVA: 0x7FFE87C05A50
        public void set_backgroundColor(){} // RVA: 0x7FFE87C05AC0
        public void get_blendDistance(){} // RVA: 0x7FFE87C05B20
        public void set_blendDistance(){} // RVA: 0x7FFE87C05B70
        public void get_boxProjection(){} // RVA: 0x7FFE87C05BD0
        public void set_boxProjection(){} // RVA: 0x7FFE87C05C20
        public void get_mode(){} // RVA: 0x7FFE87C05C80
        public void set_mode(){} // RVA: 0x7FFE87C05CD0
        public void get_importance(){} // RVA: 0x7FFE87C05D30
        public void set_importance(){} // RVA: 0x7FFE87C05D80
        public void get_refreshMode(){} // RVA: 0x7FFE87C05DE0
        public void set_refreshMode(){} // RVA: 0x7FFE87C05E30
        public void get_timeSlicingMode(){} // RVA: 0x7FFE87C05E90
        public void set_timeSlicingMode(){} // RVA: 0x7FFE87C05EE0
        public void get_bakedTexture(){} // RVA: 0x7FFE87C05F40
        public void set_bakedTexture(){} // RVA: 0x7FFE87C05F90
        public void get_customBakedTexture(){} // RVA: 0x7FFE87C05FF0
        public void set_customBakedTexture(){} // RVA: 0x7FFE87C06040
        public void get_realtimeTexture(){} // RVA: 0x7FFE87C060A0
        public void set_realtimeTexture(){} // RVA: 0x7FFE87C060F0
        public void get_texture(){} // RVA: 0x7FFE87C06150
        public void get_textureHDRDecodeValues(){} // RVA: 0x7FFE87C061A0
        public void Reset(){} // RVA: 0x7FFE87C06210
        public void RenderProbe(){} // RVA: 0x7FFE87C06270 | overloaded x2
        public void IsFinishedRendering(){} // RVA: 0x7FFE87C06320
        public void ScheduleRender(){} // RVA: 0x7FFE87C06380
        public void BlendCubemap(){} // RVA: 0x7FFE87C063F0
        public void UpdateCachedState(){} // RVA: 0x7FFE87C06470
        public void get_minBakedCubemapResolution(){} // RVA: 0x7FFE87C064C0
        public void get_maxBakedCubemapResolution(){} // RVA: 0x7FFE87C06510
        public void get_defaultTextureHDRDecodeValues(){} // RVA: 0x7FFE87C06560
        public void get_defaultTexture(){} // RVA: 0x7FFE87C065F0
        public void add_reflectionProbeChanged(){} // RVA: 0x7FFE87C06640
        public void remove_reflectionProbeChanged(){} // RVA: 0x7FFE87C067A0
        public void CallReflectionProbeEvent(){} // RVA: 0x7FFE87C06900
        public void add_defaultReflectionSet(){} // RVA: 0x7FFE87C06980
        public void remove_defaultReflectionSet(){} // RVA: 0x7FFE87C06BD0
        public void add_defaultReflectionTexture(){} // RVA: 0x7FFE87C06DB0
        public void remove_defaultReflectionTexture(){} // RVA: 0x7FFE87C07060
        public void CallSetDefaultReflection(){} // RVA: 0x7FFE87C070F0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void .cctor(){} // RVA: 0x7FFE87C07280
        public void get_size_Injected(){} // RVA: 0x7FFE87C07420
        public void set_size_Injected(){} // RVA: 0x7FFE87C07480
        public void get_center_Injected(){} // RVA: 0x7FFE87C074E0
        public void set_center_Injected(){} // RVA: 0x7FFE87C07540
        public void get_bounds_Injected(){} // RVA: 0x7FFE87C075A0
        public void get_backgroundColor_Injected(){} // RVA: 0x7FFE87C07600
        public void set_backgroundColor_Injected(){} // RVA: 0x7FFE87C07660
        public void get_textureHDRDecodeValues_Injected(){} // RVA: 0x7FFE87C076C0
        public void get_defaultTextureHDRDecodeValues_Injected(){} // RVA: 0x7FFE87C07720
    }

    public class RefreshRate : ValueType
    {
        public uint numerator; // 0x10

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE87C144F0
        public void Equals(){} // RVA: 0x7FFE87C14510
        public void CompareTo(){} // RVA: 0x7FFE87C14550
        public void ToString(){} // RVA: 0x7FFE87C145A0
    }

    public class RejectDragAndDropMaterial : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RelativeJoint2D : Joint2D
    {
        // ── Methods ──
        public void get_maxForce(){} // RVA: 0x7FFE87D2C8C0
        public void set_maxForce(){} // RVA: 0x7FFE87D2C910
        public void get_maxTorque(){} // RVA: 0x7FFE87D2C970
        public void set_maxTorque(){} // RVA: 0x7FFE87D2C9C0
        public void get_correctionScale(){} // RVA: 0x7FFE87D2CA20
        public void set_correctionScale(){} // RVA: 0x7FFE87D2CA70
        public void get_autoConfigureOffset(){} // RVA: 0x7FFE87D2CAD0
        public void set_autoConfigureOffset(){} // RVA: 0x7FFE87D2CB20
        public void get_linearOffset(){} // RVA: 0x7FFE87D2CB80
        public void set_linearOffset(){} // RVA: 0x7FFE87D2CBE0
        public void get_angularOffset(){} // RVA: 0x7FFE87D2CC40
        public void set_angularOffset(){} // RVA: 0x7FFE87D2CC90
        public void get_target(){} // RVA: 0x7FFE87D2CCF0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_linearOffset_Injected(){} // RVA: 0x7FFE87D2CD50
        public void set_linearOffset_Injected(){} // RVA: 0x7FFE87D2CDB0
        public void get_target_Injected(){} // RVA: 0x7FFE87D2CE10
    }

    public class RemoteConfigSettings : Object
    {
        // ── Methods ──
        public void RemoteConfigSettingsUpdated(){} // RVA: 0x7FFE880369A0
    }

    public class RemoteConfigSettingsHelper : Object
    {
    }

    public class RemoteSettings : Object
    {
        // ── Methods ──
        public void RemoteSettingsUpdated(){} // RVA: 0x7FFE88036860
        public void RemoteSettingsBeforeFetchFromServer(){} // RVA: 0x7FFE880368C0
        public void RemoteSettingsUpdateCompleted(){} // RVA: 0x7FFE88036920
    }

    public class RenderBuffer : ValueType
    {
    }

    public class RenderInstancedDataLayout : ValueType
    {
    }

    public class RenderParams : ValueType
    {
        public int _layer; // 0x10
        public uint _renderingLayerMask; // 0x14
        public int _rendererPriority; // 0x18
        public UnityEngine.Bounds _worldBounds; // 0x1C
        public UnityEngine.Camera _camera; // 0x38
        public 0x66575FC4 _motionVectorMode; // 0x40
        public 0x66580414 _reflectionProbeUsage; // 0x44
        public UnityEngine.Material _material; // 0x48
        public UnityEngine.MaterialPropertyBlock _matProps; // 0x50
        public 0x665801AC _shadowCastingMode; // 0x58
        public bool _receiveShadows; // 0x5C
        public 0x665806D4 _lightProbeUsage; // 0x60
        public UnityEngine.LightProbeProxyVolume _lightProbeProxyVolume; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C1A880
        public void set_layer(){} // RVA: 0x7FFE815BF990
        public void set_renderingLayerMask(){} // RVA: 0x7FFE826F4290
        public void set_rendererPriority(){} // RVA: 0x7FFE82C33010
        public void set_worldBounds(){} // RVA: 0x7FFE87C1AB10
        public void set_camera(){} // RVA: 0x7FFE810FCE90
        public void set_motionVectorMode(){} // RVA: 0x7FFE81156CE0
        public void set_reflectionProbeUsage(){} // RVA: 0x7FFE82443340
        public void set_material(){} // RVA: 0x7FFE81437330
        public void get_matProps(){} // RVA: 0x7FFE81178740
        public void set_matProps(){} // RVA: 0x7FFE81123200
        public void set_shadowCastingMode(){} // RVA: 0x7FFE8119C0D0
        public void set_receiveShadows(){} // RVA: 0x7FFE824479E0
        public void set_lightProbeUsage(){} // RVA: 0x7FFE81463B00
        public void set_lightProbeProxyVolume(){} // RVA: 0x7FFE811C3510
    }

    public class RenderSettings : Object
    {
        // ── Methods ──
        public void get_fog(){} // RVA: 0x7FFE87C27060
        public void set_fog(){} // RVA: 0x7FFE87C270B0
        public void get_fogStartDistance(){} // RVA: 0x7FFE87C27100
        public void set_fogStartDistance(){} // RVA: 0x7FFE87C27150
        public void get_fogEndDistance(){} // RVA: 0x7FFE87C271B0
        public void set_fogEndDistance(){} // RVA: 0x7FFE87C27200
        public void get_fogMode(){} // RVA: 0x7FFE87C27260
        public void set_fogMode(){} // RVA: 0x7FFE87C272B0
        public void get_fogColor(){} // RVA: 0x7FFE87C27300
        public void set_fogColor(){} // RVA: 0x7FFE87C27360
        public void get_fogDensity(){} // RVA: 0x7FFE87C273B0
        public void set_fogDensity(){} // RVA: 0x7FFE87C27400
        public void get_ambientMode(){} // RVA: 0x7FFE87C27460
        public void set_ambientMode(){} // RVA: 0x7FFE87C274B0
        public void get_ambientSkyColor(){} // RVA: 0x7FFE87C27500
        public void set_ambientSkyColor(){} // RVA: 0x7FFE87C27560
        public void get_ambientEquatorColor(){} // RVA: 0x7FFE87C275B0
        public void set_ambientEquatorColor(){} // RVA: 0x7FFE87C27610
        public void get_ambientGroundColor(){} // RVA: 0x7FFE87C27660
        public void set_ambientGroundColor(){} // RVA: 0x7FFE87C276C0
        public void get_ambientIntensity(){} // RVA: 0x7FFE87C27710
        public void set_ambientIntensity(){} // RVA: 0x7FFE87C27760
        public void get_ambientLight(){} // RVA: 0x7FFE87C277C0
        public void set_ambientLight(){} // RVA: 0x7FFE87C27820
        public void get_subtractiveShadowColor(){} // RVA: 0x7FFE87C27870
        public void set_subtractiveShadowColor(){} // RVA: 0x7FFE87C278D0
        public void get_skybox(){} // RVA: 0x7FFE87C27920
        public void set_skybox(){} // RVA: 0x7FFE87C27970
        public void get_sun(){} // RVA: 0x7FFE87C279C0
        public void set_sun(){} // RVA: 0x7FFE87C27A10
        public void get_ambientProbe(){} // RVA: 0x7FFE87C27A60
        public void set_ambientProbe(){} // RVA: 0x7FFE87C27AE0
        public void get_customReflectionTexture(){} // RVA: 0x7FFE87C27B30
        public void set_customReflectionTexture(){} // RVA: 0x7FFE87C27B80
        public void get_reflectionIntensity(){} // RVA: 0x7FFE87C27BD0
        public void set_reflectionIntensity(){} // RVA: 0x7FFE87C27C20
        public void get_reflectionBounces(){} // RVA: 0x7FFE87C27C80
        public void set_reflectionBounces(){} // RVA: 0x7FFE87C27CD0
        public void get_defaultReflectionMode(){} // RVA: 0x7FFE87C27D20
        public void set_defaultReflectionMode(){} // RVA: 0x7FFE87C27D70
        public void get_defaultReflectionResolution(){} // RVA: 0x7FFE87C27DC0
        public void set_defaultReflectionResolution(){} // RVA: 0x7FFE87C27E10
        public void get_haloStrength(){} // RVA: 0x7FFE87C27E60
        public void set_haloStrength(){} // RVA: 0x7FFE87C27EB0
        public void get_flareStrength(){} // RVA: 0x7FFE87C27F10
        public void set_flareStrength(){} // RVA: 0x7FFE87C27F60
        public void get_flareFadeSpeed(){} // RVA: 0x7FFE87C27FC0
        public void set_flareFadeSpeed(){} // RVA: 0x7FFE87C28010
        public void get_fogColor_Injected(){} // RVA: 0x7FFE87C28070
        public void set_fogColor_Injected(){} // RVA: 0x7FFE87C280C0
        public void get_ambientSkyColor_Injected(){} // RVA: 0x7FFE87C28110
        public void set_ambientSkyColor_Injected(){} // RVA: 0x7FFE87C28160
        public void get_ambientEquatorColor_Injected(){} // RVA: 0x7FFE87C281B0
        public void set_ambientEquatorColor_Injected(){} // RVA: 0x7FFE87C28200
        public void get_ambientGroundColor_Injected(){} // RVA: 0x7FFE87C28250
        public void set_ambientGroundColor_Injected(){} // RVA: 0x7FFE87C282A0
        public void get_ambientLight_Injected(){} // RVA: 0x7FFE87C282F0
        public void set_ambientLight_Injected(){} // RVA: 0x7FFE87C28340
        public void get_subtractiveShadowColor_Injected(){} // RVA: 0x7FFE87C28390
        public void set_subtractiveShadowColor_Injected(){} // RVA: 0x7FFE87C283E0
        public void get_ambientProbe_Injected(){} // RVA: 0x7FFE87C28430
        public void set_ambientProbe_Injected(){} // RVA: 0x7FFE87C28480
    }

    public class RenderTexture : Texture
    {
        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFE87C498D0
        public void set_width(){} // RVA: 0x7FFE87C49920
        public void get_height(){} // RVA: 0x7FFE87C49980
        public void set_height(){} // RVA: 0x7FFE87C499D0
        public void get_dimension(){} // RVA: 0x7FFE87C49A30
        public void set_dimension(){} // RVA: 0x7FFE87C49A80
        public void GetColorFormat(){} // RVA: 0x7FFE87C49AE0
        public void SetColorFormat(){} // RVA: 0x7FFE87C49B40
        public void get_graphicsFormat(){} // RVA: 0x7FFE87C49BA0
        public void set_graphicsFormat(){} // RVA: 0x7FFE87C49B40
        public void get_useMipMap(){} // RVA: 0x7FFE87C49C00
        public void set_useMipMap(){} // RVA: 0x7FFE87C49C50
        public void get_sRGB(){} // RVA: 0x7FFE87C49CB0
        public void get_vrUsage(){} // RVA: 0x7FFE87C49D00
        public void set_vrUsage(){} // RVA: 0x7FFE87C49D50
        public void get_memorylessMode(){} // RVA: 0x7FFE87C49DB0
        public void set_memorylessMode(){} // RVA: 0x7FFE87C49E00
        public void get_format(){} // RVA: 0x7FFE87C49E60
        public void set_format(){} // RVA: 0x7FFE87C49FF0
        public void get_stencilFormat(){} // RVA: 0x7FFE87C4A0E0
        public void set_stencilFormat(){} // RVA: 0x7FFE87C4A130
        public void get_depthStencilFormat(){} // RVA: 0x7FFE87C4A190
        public void set_depthStencilFormat(){} // RVA: 0x7FFE87C4A1E0
        public void get_autoGenerateMips(){} // RVA: 0x7FFE87C4A240
        public void set_autoGenerateMips(){} // RVA: 0x7FFE87C4A290
        public void get_volumeDepth(){} // RVA: 0x7FFE87C4A2F0
        public void set_volumeDepth(){} // RVA: 0x7FFE87C4A340
        public void get_antiAliasing(){} // RVA: 0x7FFE87C4A3A0
        public void set_antiAliasing(){} // RVA: 0x7FFE87C4A3F0
        public void get_bindTextureMS(){} // RVA: 0x7FFE87C4A450
        public void set_bindTextureMS(){} // RVA: 0x7FFE87C4A4A0
        public void get_enableRandomWrite(){} // RVA: 0x7FFE87C4A500
        public void set_enableRandomWrite(){} // RVA: 0x7FFE87C4A550
        public void get_useDynamicScale(){} // RVA: 0x7FFE87C4A5B0
        public void set_useDynamicScale(){} // RVA: 0x7FFE87C4A600
        public void GetIsPowerOfTwo(){} // RVA: 0x7FFE87C4A660
        public void get_isPowerOfTwo(){} // RVA: 0x7FFE87C4A660
        public void set_isPowerOfTwo(){} // RVA: 0x7FFE810FB310
        public void GetActive(){} // RVA: 0x7FFE87C4A6B0
        public void SetActive(){} // RVA: 0x7FFE87C4A700
        public void get_active(){} // RVA: 0x7FFE87C4A6B0
        public void set_active(){} // RVA: 0x7FFE87C4A700
        public void GetColorBuffer(){} // RVA: 0x7FFE87C4A750
        public void GetDepthBuffer(){} // RVA: 0x7FFE87C4A7C0
        public void SetMipMapCount(){} // RVA: 0x7FFE87C4A830
        public void SetShadowSamplingMode(){} // RVA: 0x7FFE87C4A890
        public void get_colorBuffer(){} // RVA: 0x7FFE87C4A8F0
        public void get_depthBuffer(){} // RVA: 0x7FFE87C4A970
        public void GetNativeDepthBufferPtr(){} // RVA: 0x7FFE87C4A9F0
        public void DiscardContents(){} // RVA: 0x7FFE87C4AB10 | overloaded x2
        public void MarkRestoreExpected(){} // RVA: 0x7FFE87C4AAC0
        public void ResolveAA(){} // RVA: 0x7FFE87C4AB70
        public void ResolveAATo(){} // RVA: 0x7FFE87C4ABC0
        public void ResolveAntiAliasedSurface(){} // RVA: 0x7FFE87C4ABC0 | overloaded x2
        public void SetGlobalShaderProperty(){} // RVA: 0x7FFE87C4AC20
        public void Create(){} // RVA: 0x7FFE87C4AC80
        public void Release(){} // RVA: 0x7FFE87C4ACD0
        public void IsCreated(){} // RVA: 0x7FFE87C4AD20
        public void GenerateMips(){} // RVA: 0x7FFE87C4AD70
        public void ConvertToEquirect(){} // RVA: 0x7FFE87C4ADC0
        public void SetSRGBReadWrite(){} // RVA: 0x7FFE87C4AE30
        public void Internal_Create(){} // RVA: 0x7FFE87C4AE90
        public void SupportsStencil(){} // RVA: 0x7FFE87C4AEE0
        public void SetRenderTextureDescriptor(){} // RVA: 0x7FFE87C4AF30
        public void GetDescriptor(){} // RVA: 0x7FFE87C4AF90
        public void GetTemporary_Internal(){} // RVA: 0x7FFE87C4B010
        public void ReleaseTemporary(){} // RVA: 0x7FFE87C4B060
        public void get_depth(){} // RVA: 0x7FFE87C4B0B0
        public void set_depth(){} // RVA: 0x7FFE87C4B100
        public void .ctor(){} // RVA: 0x7FFE87C4C000 | overloaded x12
        public void Initialize(){} // RVA: 0x7FFE87C4C0D0
        public void GetDepthStencilFormatLegacy(){} // RVA: 0x7FFE87C4C400 | overloaded x4
        public void get_descriptor(){} // RVA: 0x7FFE87C4C490
        public void set_descriptor(){} // RVA: 0x7FFE87C4C540
        public void ValidateRenderTextureDesc(){} // RVA: 0x7FFE87C4C600
        public void GetDefaultColorFormat(){} // RVA: 0x7FFE87C4CB90
        public void GetDefaultDepthStencilFormat(){} // RVA: 0x7FFE87C4CC00
        public void GetCompatibleFormat(){} // RVA: 0x7FFE87C4CC70
        public void GetTemporary(){} // RVA: 0x7FFE87C4D610 | overloaded x14
        public void GetTemporaryImpl(){} // RVA: 0x7FFE87C4CEE0
        public void get_isCubemap(){} // RVA: 0x7FFE87C4D640
        public void set_isCubemap(){} // RVA: 0x7FFE87C4D670
        public void get_isVolume(){} // RVA: 0x7FFE87C4D6B0
        public void set_isVolume(){} // RVA: 0x7FFE87C4D6E0
        public void get_enabled(){} // RVA: 0x7FFE82E64CC0
        public void set_enabled(){} // RVA: 0x7FFE810FB310
        public void GetTexelOffset(){} // RVA: 0x7FFE811200A0
        public void GetColorBuffer_Injected(){} // RVA: 0x7FFE87C4D710
        public void GetDepthBuffer_Injected(){} // RVA: 0x7FFE87C4D770
        public void SetRenderTextureDescriptor_Injected(){} // RVA: 0x7FFE87C4D7D0
        public void GetDescriptor_Injected(){} // RVA: 0x7FFE87C4D830
        public void GetTemporary_Internal_Injected(){} // RVA: 0x7FFE87C4D890
    }

    public class RenderTextureDescriptor : ValueType
    {
        public int _width; // 0x10
        public int _height; // 0x14
        public int _msaaSamples; // 0x18
        public int _volumeDepth; // 0x1C
        public int _mipCount; // 0x20
        public 0x66582F0C _graphicsFormat; // 0x24
        public 0x66582F0C _stencilFormat; // 0x28
        public 0x66582F0C _depthStencilFormat; // 0x2C
        public 0x665807DC _dimension; // 0x30
        public 0x6658067C _shadowSamplingMode; // 0x34
        public . _vrUsage; // 0x38
        public 0x66575A9C _flags; // 0x3C
        public 0x66575B4C _memoryless; // 0x40
        public object field_13; // 0x296
        public object field_14; // 0x297
        public object field_15; // 0x298
        public object field_16; // 0x299
        public object field_17; // 0x29A
        public object field_18; // 0x29B
        public object field_19; // 0x29C
        public object field_20; // 0x29D

        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFE826F4220
        public void set_width(){} // RVA: 0x7FFE815BF990
        public void get_height(){} // RVA: 0x7FFE826F42A0
        public void set_height(){} // RVA: 0x7FFE826F4290
        public void get_msaaSamples(){} // RVA: 0x7FFE82C33000
        public void set_msaaSamples(){} // RVA: 0x7FFE82C33010
        public void get_volumeDepth(){} // RVA: 0x7FFE82C33020
        public void set_volumeDepth(){} // RVA: 0x7FFE82C33030
        public void get_mipCount(){} // RVA: 0x7FFE811485C0
        public void set_mipCount(){} // RVA: 0x7FFE810FE0C0
        public void get_graphicsFormat(){} // RVA: 0x7FFE83BAF260
        public void set_graphicsFormat(){} // RVA: 0x7FFE87C4EBC0
        public void get_depthStencilFormat(){} // RVA: 0x7FFE82707EE0
        public void set_depthStencilFormat(){} // RVA: 0x7FFE82717690
        public void get_colorFormat(){} // RVA: 0x7FFE87C4EC80
        public void set_colorFormat(){} // RVA: 0x7FFE87C4ED30
        public void get_sRGB(){} // RVA: 0x7FFE87C4EE00
        public void set_sRGB(){} // RVA: 0x7FFE87C4EE90
        public void get_depthBufferBits(){} // RVA: 0x7FFE87C4F000
        public void set_depthBufferBits(){} // RVA: 0x7FFE87C4F090
        public void get_dimension(){} // RVA: 0x7FFE8151D690
        public void set_dimension(){} // RVA: 0x7FFE8170B670
        public void get_shadowSamplingMode(){} // RVA: 0x7FFE81A56130
        public void set_shadowSamplingMode(){} // RVA: 0x7FFE82447980
        public void get_vrUsage(){} // RVA: 0x7FFE81549710
        public void set_vrUsage(){} // RVA: 0x7FFE817E4800
        public void get_flags(){} // RVA: 0x7FFE87BBD3B0
        public void get_memoryless(){} // RVA: 0x7FFE81156CD0
        public void set_memoryless(){} // RVA: 0x7FFE81156CE0
        public void .ctor(){} // RVA: 0x7FFE87C4F580 | overloaded x9
        public void SetOrClearRenderTextureCreationFlag(){} // RVA: 0x7FFE87C4F5F0
        public void get_useMipMap(){} // RVA: 0x7FFE87C4F610
        public void set_useMipMap(){} // RVA: 0x7FFE87C4F620
        public void get_autoGenerateMips(){} // RVA: 0x7FFE87C4F640
        public void set_autoGenerateMips(){} // RVA: 0x7FFE87C4F650
        public void get_enableRandomWrite(){} // RVA: 0x7FFE87C4F670
        public void set_enableRandomWrite(){} // RVA: 0x7FFE87C4F680
        public void get_bindMS(){} // RVA: 0x7FFE87C4F6A0
        public void set_bindMS(){} // RVA: 0x7FFE87C4F6B0
        public void set_createdFromScript(){} // RVA: 0x7FFE87C4F6D0
        public void get_useDynamicScale(){} // RVA: 0x7FFE87C4F6F0
        public void set_useDynamicScale(){} // RVA: 0x7FFE87C4F700
    }

    public class Renderer : Component
    {
        // ── Methods ──
        public void get_castShadows(){} // RVA: 0x7FFE87C24810
        public void set_castShadows(){} // RVA: 0x7FFE87C24870
        public void get_motionVectors(){} // RVA: 0x7FFE87C248E0
        public void set_motionVectors(){} // RVA: 0x7FFE87C24940
        public void get_useLightProbes(){} // RVA: 0x7FFE87C249B0
        public void set_useLightProbes(){} // RVA: 0x7FFE87C24A10
        public void get_bounds(){} // RVA: 0x7FFE87C24A80
        public void set_bounds(){} // RVA: 0x7FFE87C24AF0
        public void get_localBounds(){} // RVA: 0x7FFE87C24B50
        public void set_localBounds(){} // RVA: 0x7FFE87C24BC0
        public void ResetBounds(){} // RVA: 0x7FFE87C24C20
        public void ResetLocalBounds(){} // RVA: 0x7FFE87C24C70
        public void SetStaticLightmapST(){} // RVA: 0x7FFE87C24CC0
        public void GetMaterial(){} // RVA: 0x7FFE87C24D20
        public void GetSharedMaterial(){} // RVA: 0x7FFE87C24D70
        public void SetMaterial(){} // RVA: 0x7FFE87C24DC0
        public void GetMaterialArray(){} // RVA: 0x7FFE87C24E20
        public void CopyMaterialArray(){} // RVA: 0x7FFE87C24E70
        public void CopySharedMaterialArray(){} // RVA: 0x7FFE87C24ED0
        public void SetMaterialArray(){} // RVA: 0x7FFE87C24FA0 | overloaded x2
        public void Internal_SetPropertyBlock(){} // RVA: 0x7FFE87C24FD0
        public void Internal_GetPropertyBlock(){} // RVA: 0x7FFE87C25030
        public void Internal_SetPropertyBlockMaterialIndex(){} // RVA: 0x7FFE87C25090
        public void Internal_GetPropertyBlockMaterialIndex(){} // RVA: 0x7FFE87C25100
        public void HasPropertyBlock(){} // RVA: 0x7FFE87C25170
        public void SetPropertyBlock(){} // RVA: 0x7FFE87C25090 | overloaded x2
        public void GetPropertyBlock(){} // RVA: 0x7FFE87C25100 | overloaded x2
        public void GetClosestReflectionProbesInternal(){} // RVA: 0x7FFE87C251C0
        public void get_enabled(){} // RVA: 0x7FFE87C25220
        public void set_enabled(){} // RVA: 0x7FFE87C25270
        public void get_isVisible(){} // RVA: 0x7FFE87C252D0
        public void get_shadowCastingMode(){} // RVA: 0x7FFE87C25320
        public void set_shadowCastingMode(){} // RVA: 0x7FFE87C25370
        public void get_receiveShadows(){} // RVA: 0x7FFE87C253D0
        public void set_receiveShadows(){} // RVA: 0x7FFE87C25420
        public void get_forceRenderingOff(){} // RVA: 0x7FFE87C25480
        public void set_forceRenderingOff(){} // RVA: 0x7FFE87C254D0
        public void GetIsStaticShadowCaster(){} // RVA: 0x7FFE87C25530
        public void SetIsStaticShadowCaster(){} // RVA: 0x7FFE87C25580
        public void get_staticShadowCaster(){} // RVA: 0x7FFE87C25530
        public void set_staticShadowCaster(){} // RVA: 0x7FFE87C25580
        public void get_motionVectorGenerationMode(){} // RVA: 0x7FFE87C255E0
        public void set_motionVectorGenerationMode(){} // RVA: 0x7FFE87C25630
        public void get_lightProbeUsage(){} // RVA: 0x7FFE87C25690
        public void set_lightProbeUsage(){} // RVA: 0x7FFE87C256E0
        public void get_reflectionProbeUsage(){} // RVA: 0x7FFE87C25740
        public void set_reflectionProbeUsage(){} // RVA: 0x7FFE87C25790
        public void get_renderingLayerMask(){} // RVA: 0x7FFE87C257F0
        public void set_renderingLayerMask(){} // RVA: 0x7FFE87C25840
        public void get_rendererPriority(){} // RVA: 0x7FFE87C258A0
        public void set_rendererPriority(){} // RVA: 0x7FFE87C258F0
        public void get_rayTracingMode(){} // RVA: 0x7FFE87C25950
        public void set_rayTracingMode(){} // RVA: 0x7FFE87C259A0
        public void get_sortingLayerName(){} // RVA: 0x7FFE87C25A00
        public void set_sortingLayerName(){} // RVA: 0x7FFE87C25A50
        public void get_sortingLayerID(){} // RVA: 0x7FFE87C25AB0
        public void set_sortingLayerID(){} // RVA: 0x7FFE87C25B00
        public void get_sortingOrder(){} // RVA: 0x7FFE87C25B60
        public void set_sortingOrder(){} // RVA: 0x7FFE87C25BB0
        public void get_sortingKey(){} // RVA: 0x7FFE87C25C10
        public void get_sortingGroupID(){} // RVA: 0x7FFE87C25C60
        public void set_sortingGroupID(){} // RVA: 0x7FFE87C25CB0
        public void get_sortingGroupOrder(){} // RVA: 0x7FFE87C25D10
        public void set_sortingGroupOrder(){} // RVA: 0x7FFE87C25D60
        public void get_sortingGroupKey(){} // RVA: 0x7FFE87C25DC0
        public void get_allowOcclusionWhenDynamic(){} // RVA: 0x7FFE87C25E10
        public void set_allowOcclusionWhenDynamic(){} // RVA: 0x7FFE87C25E60
        public void get_staticBatchRootTransform(){} // RVA: 0x7FFE87C25EC0
        public void set_staticBatchRootTransform(){} // RVA: 0x7FFE87C25F10
        public void get_staticBatchIndex(){} // RVA: 0x7FFE87C25F70
        public void SetStaticBatchInfo(){} // RVA: 0x7FFE87C25FC0
        public void get_isPartOfStaticBatch(){} // RVA: 0x7FFE87C26030
        public void get_worldToLocalMatrix(){} // RVA: 0x7FFE87C26080
        public void get_localToWorldMatrix(){} // RVA: 0x7FFE87C26100
        public void get_lightProbeProxyVolumeOverride(){} // RVA: 0x7FFE87C26180
        public void set_lightProbeProxyVolumeOverride(){} // RVA: 0x7FFE87C261D0
        public void get_probeAnchor(){} // RVA: 0x7FFE87C26230
        public void set_probeAnchor(){} // RVA: 0x7FFE87C26280
        public void GetLightmapIndex(){} // RVA: 0x7FFE87C262E0
        public void SetLightmapIndex(){} // RVA: 0x7FFE87C26340
        public void GetLightmapST(){} // RVA: 0x7FFE87C263B0
        public void SetLightmapST(){} // RVA: 0x7FFE87C26430
        public void get_lightmapIndex(){} // RVA: 0x7FFE87C264A0
        public void set_lightmapIndex(){} // RVA: 0x7FFE87C26500
        public void get_realtimeLightmapIndex(){} // RVA: 0x7FFE87C26560
        public void set_realtimeLightmapIndex(){} // RVA: 0x7FFE87C265C0
        public void get_lightmapScaleOffset(){} // RVA: 0x7FFE87C26630
        public void set_lightmapScaleOffset(){} // RVA: 0x7FFE87C266B0
        public void get_realtimeLightmapScaleOffset(){} // RVA: 0x7FFE87C26710
        public void set_realtimeLightmapScaleOffset(){} // RVA: 0x7FFE87C26790
        public void GetMaterialCount(){} // RVA: 0x7FFE87C26800
        public void GetSharedMaterialArray(){} // RVA: 0x7FFE87C26850
        public void get_materials(){} // RVA: 0x7FFE87C24E20
        public void set_materials(){} // RVA: 0x7FFE87C24FA0
        public void get_material(){} // RVA: 0x7FFE87C24D20
        public void set_material(){} // RVA: 0x7FFE87C24DC0
        public void get_sharedMaterial(){} // RVA: 0x7FFE87C24D70
        public void set_sharedMaterial(){} // RVA: 0x7FFE87C24DC0
        public void get_sharedMaterials(){} // RVA: 0x7FFE87C26850
        public void set_sharedMaterials(){} // RVA: 0x7FFE87C24FA0
        public void GetMaterials(){} // RVA: 0x7FFE87C268A0
        public void SetSharedMaterials(){} // RVA: 0x7FFE87C269F0
        public void SetMaterials(){} // RVA: 0x7FFE87C26AC0
        public void GetSharedMaterials(){} // RVA: 0x7FFE87C26B90
        public void GetClosestReflectionProbes(){} // RVA: 0x7FFE87C251C0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_bounds_Injected(){} // RVA: 0x7FFE87C26CE0
        public void set_bounds_Injected(){} // RVA: 0x7FFE87C26D40
        public void get_localBounds_Injected(){} // RVA: 0x7FFE87C26DA0
        public void set_localBounds_Injected(){} // RVA: 0x7FFE87C26E00
        public void SetStaticLightmapST_Injected(){} // RVA: 0x7FFE87C26E60
        public void get_worldToLocalMatrix_Injected(){} // RVA: 0x7FFE87C26EC0
        public void get_localToWorldMatrix_Injected(){} // RVA: 0x7FFE87C26F20
        public void GetLightmapST_Injected(){} // RVA: 0x7FFE87C26F80
        public void SetLightmapST_Injected(){} // RVA: 0x7FFE87C26FF0
    }

    public class RendererExtensions : Object
    {
        // ── Methods ──
        public void UpdateGIMaterials(){} // RVA: 0x7FFE87C1BAD0
        public void UpdateGIMaterialsForRenderer(){} // RVA: 0x7FFE87C1BAD0
    }

    public class RequireComponent : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
    }

    public class Resolution : ValueType
    {
        public int m_Width; // 0x10
        public int m_Height; // 0x14
        public UnityEngine.RefreshRate m_RefreshRate; // 0x18
        public uint numerator; // 0x10

        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFE8733C3B0
        public void set_width(){} // RVA: 0x7FFE815BF990
        public void get_height(){} // RVA: 0x7FFE84D2D330
        public void set_height(){} // RVA: 0x7FFE826F4290
        public void get_refreshRateRatio(){} // RVA: 0x7FFE86A5E330
        public void get_refreshRate(){} // RVA: 0x7FFE87C1A640
        public void set_refreshRate(){} // RVA: 0x7FFE87C1A6C0
        public void ToString(){} // RVA: 0x7FFE87C1A6D0
    }

    public class ResourceRequest : AsyncOperation
    {
        public string m_Path; // 0x20

        // ── Methods ──
        public void GetResult(){} // RVA: 0x7FFE87C610B0
        public void get_asset(){} // RVA: 0x7FFE811AFBC0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Resources : Object
    {
        // ── Methods ──
        public void ConvertObjects(){} // RVA: 0x7FFE80E2E3D0
        public void FindObjectsOfTypeAll(){} // RVA: 0x7FFE80E2DEE0 | overloaded x2
        public void Load(){} // RVA: 0x7FFE87C61800 | overloaded x3
        public void LoadAsync(){} // RVA: 0x7FFE87C61950 | overloaded x3
        public void GetBuiltinResource(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void UnloadAsset(){} // RVA: 0x7FFE87C61A30
        public void UnloadUnusedAssets(){} // RVA: 0x7FFE87C61AA0
    }

    public class ResourcesAPI : Object
    {
        public UnityEngine.ResourcesAPI s_DefaultAPI;
        public UnityEngine.ResourcesAPI _overrideAPI; // 0x8

        // ── Methods ──
        public void get_ActiveAPI(){} // RVA: 0x7FFE87C61280
        public void get_overrideAPI(){} // RVA: 0x7FFE87C61340
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void FindObjectsOfTypeAll(){} // RVA: 0x7FFE87C613A0
        public void FindShaderByName(){} // RVA: 0x7FFE87C613F0
        public void Load(){} // RVA: 0x7FFE87C61440
        public void LoadAsync(){} // RVA: 0x7FFE87C614A0
        public void UnloadAsset(){} // RVA: 0x7FFE87C615D0
        public void .cctor(){} // RVA: 0x7FFE87C61620
    }

    public class ResourcesAPIInternal : Object
    {
        // ── Methods ──
        public void FindObjectsOfTypeAll(){} // RVA: 0x7FFE87C610D0
        public void FindShaderByName(){} // RVA: 0x7FFE87C61120
        public void Load(){} // RVA: 0x7FFE87C61170
        public void LoadAsyncInternal(){} // RVA: 0x7FFE87C611D0
        public void UnloadAsset(){} // RVA: 0x7FFE87C61230
    }

    public class Rigidbody : Component
    {
        // ── Methods ──
        public void get_velocity(){} // RVA: 0x7FFE87D3D0C0
        public void set_velocity(){} // RVA: 0x7FFE87D3D130
        public void get_angularVelocity(){} // RVA: 0x7FFE87D3D190
        public void set_angularVelocity(){} // RVA: 0x7FFE87D3D200
        public void get_drag(){} // RVA: 0x7FFE87D3D260
        public void set_drag(){} // RVA: 0x7FFE87D3D2B0
        public void get_angularDrag(){} // RVA: 0x7FFE87D3D310
        public void set_angularDrag(){} // RVA: 0x7FFE87D3D360
        public void get_mass(){} // RVA: 0x7FFE87D3D3C0
        public void set_mass(){} // RVA: 0x7FFE87D3D410
        public void SetDensity(){} // RVA: 0x7FFE87D3D470
        public void get_useGravity(){} // RVA: 0x7FFE87D3D4D0
        public void set_useGravity(){} // RVA: 0x7FFE87D3D520
        public void get_maxDepenetrationVelocity(){} // RVA: 0x7FFE87D3D580
        public void set_maxDepenetrationVelocity(){} // RVA: 0x7FFE87D3D5D0
        public void get_isKinematic(){} // RVA: 0x7FFE87D3D630
        public void set_isKinematic(){} // RVA: 0x7FFE87D3D680
        public void get_freezeRotation(){} // RVA: 0x7FFE87D3D6E0
        public void set_freezeRotation(){} // RVA: 0x7FFE87D3D730
        public void get_constraints(){} // RVA: 0x7FFE87D3D790
        public void set_constraints(){} // RVA: 0x7FFE87D3D7E0
        public void get_collisionDetectionMode(){} // RVA: 0x7FFE87D3D840
        public void set_collisionDetectionMode(){} // RVA: 0x7FFE87D3D890
        public void get_automaticCenterOfMass(){} // RVA: 0x7FFE87D3D8F0
        public void set_automaticCenterOfMass(){} // RVA: 0x7FFE87D3D940
        public void get_centerOfMass(){} // RVA: 0x7FFE87D3D9A0
        public void set_centerOfMass(){} // RVA: 0x7FFE87D3DA10
        public void get_worldCenterOfMass(){} // RVA: 0x7FFE87D3DA70
        public void get_automaticInertiaTensor(){} // RVA: 0x7FFE87D3DAE0
        public void set_automaticInertiaTensor(){} // RVA: 0x7FFE87D3DB30
        public void get_inertiaTensorRotation(){} // RVA: 0x7FFE87D3DB90
        public void set_inertiaTensorRotation(){} // RVA: 0x7FFE87D3DC00
        public void get_inertiaTensor(){} // RVA: 0x7FFE87D3DC60
        public void set_inertiaTensor(){} // RVA: 0x7FFE87D3DCD0
        public void get_detectCollisions(){} // RVA: 0x7FFE87D3DD30
        public void set_detectCollisions(){} // RVA: 0x7FFE87D3DD80
        public void get_position(){} // RVA: 0x7FFE87D3DDE0
        public void set_position(){} // RVA: 0x7FFE87D3DE50
        public void get_rotation(){} // RVA: 0x7FFE87D3DEB0
        public void set_rotation(){} // RVA: 0x7FFE87D3DF20
        public void get_interpolation(){} // RVA: 0x7FFE87D3DF80
        public void set_interpolation(){} // RVA: 0x7FFE87D3DFD0
        public void get_solverIterations(){} // RVA: 0x7FFE87D3E030
        public void set_solverIterations(){} // RVA: 0x7FFE87D3E080
        public void get_sleepThreshold(){} // RVA: 0x7FFE87D3E0E0
        public void set_sleepThreshold(){} // RVA: 0x7FFE87D3E130
        public void get_maxAngularVelocity(){} // RVA: 0x7FFE87D3E190
        public void set_maxAngularVelocity(){} // RVA: 0x7FFE87D3E1E0
        public void get_maxLinearVelocity(){} // RVA: 0x7FFE87D3E240
        public void set_maxLinearVelocity(){} // RVA: 0x7FFE87D3E290
        public void MovePosition(){} // RVA: 0x7FFE87D3E2F0
        public void MoveRotation(){} // RVA: 0x7FFE87D3E350
        public void Move(){} // RVA: 0x7FFE87D3E3B0
        public void Sleep(){} // RVA: 0x7FFE87D3E420
        public void IsSleeping(){} // RVA: 0x7FFE87D3E470
        public void WakeUp(){} // RVA: 0x7FFE87D3E4C0
        public void ResetCenterOfMass(){} // RVA: 0x7FFE87D3E510
        public void ResetInertiaTensor(){} // RVA: 0x7FFE87D3E560
        public void GetRelativePointVelocity(){} // RVA: 0x7FFE87D3E5B0
        public void GetPointVelocity(){} // RVA: 0x7FFE87D3E630
        public void get_solverVelocityIterations(){} // RVA: 0x7FFE87D3E6B0
        public void set_solverVelocityIterations(){} // RVA: 0x7FFE87D3E700
        public void get_excludeLayers(){} // RVA: 0x7FFE87D3E760
        public void set_excludeLayers(){} // RVA: 0x7FFE87D3E7C0
        public void get_includeLayers(){} // RVA: 0x7FFE87D3E820
        public void set_includeLayers(){} // RVA: 0x7FFE87D3E880
        public void GetAccumulatedForce(){} // RVA: 0x7FFE87D3E960 | overloaded x2
        public void GetAccumulatedTorque(){} // RVA: 0x7FFE87D3EAC0 | overloaded x2
        public void AddForce(){} // RVA: 0x7FFE87D3ECF0 | overloaded x4
        public void AddRelativeForce(){} // RVA: 0x7FFE87D3EEB0 | overloaded x4
        public void AddTorque(){} // RVA: 0x7FFE87D3F070 | overloaded x4
        public void AddRelativeTorque(){} // RVA: 0x7FFE87D3F230 | overloaded x4
        public void AddForceAtPosition(){} // RVA: 0x7FFE87D3F320 | overloaded x2
        public void AddExplosionForce(){} // RVA: 0x7FFE87D3F4E0 | overloaded x3
        public void Internal_ClosestPointOnBounds(){} // RVA: 0x7FFE87D3F580
        public void ClosestPointOnBounds(){} // RVA: 0x7FFE87D3F600
        public void SweepTest(){} // RVA: 0x7FFE87D3F920 | overloaded x4
        public void Internal_SweepTestAll(){} // RVA: 0x7FFE87D3F960
        public void SweepTestAll(){} // RVA: 0x7FFE87D3FB10 | overloaded x3
        public void get_sleepVelocity(){} // RVA: 0x7FFE87C336C0
        public void set_sleepVelocity(){} // RVA: 0x7FFE810FB310
        public void get_sleepAngularVelocity(){} // RVA: 0x7FFE87C336C0
        public void set_sleepAngularVelocity(){} // RVA: 0x7FFE810FB310
        public void SetMaxAngularVelocity(){} // RVA: 0x7FFE87D3E1E0
        public void get_useConeFriction(){} // RVA: 0x7FFE834BA0A0
        public void set_useConeFriction(){} // RVA: 0x7FFE810FB310
        public void get_solverIterationCount(){} // RVA: 0x7FFE87D3E030
        public void set_solverIterationCount(){} // RVA: 0x7FFE87D3E080
        public void get_solverVelocityIterationCount(){} // RVA: 0x7FFE87D3E6B0
        public void set_solverVelocityIterationCount(){} // RVA: 0x7FFE87D3E700
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_velocity_Injected(){} // RVA: 0x7FFE87D3FB50
        public void set_velocity_Injected(){} // RVA: 0x7FFE87D3FBB0
        public void get_angularVelocity_Injected(){} // RVA: 0x7FFE87D3FC10
        public void set_angularVelocity_Injected(){} // RVA: 0x7FFE87D3FC70
        public void get_centerOfMass_Injected(){} // RVA: 0x7FFE87D3FCD0
        public void set_centerOfMass_Injected(){} // RVA: 0x7FFE87D3FD30
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x7FFE87D3FD90
        public void get_inertiaTensorRotation_Injected(){} // RVA: 0x7FFE87D3FDF0
        public void set_inertiaTensorRotation_Injected(){} // RVA: 0x7FFE87D3FE50
        public void get_inertiaTensor_Injected(){} // RVA: 0x7FFE87D3FEB0
        public void set_inertiaTensor_Injected(){} // RVA: 0x7FFE87D3FF10
        public void get_position_Injected(){} // RVA: 0x7FFE87D3FF70
        public void set_position_Injected(){} // RVA: 0x7FFE87D3FFD0
        public void get_rotation_Injected(){} // RVA: 0x7FFE87D40030
        public void set_rotation_Injected(){} // RVA: 0x7FFE87D40090
        public void MovePosition_Injected(){} // RVA: 0x7FFE87D400F0
        public void MoveRotation_Injected(){} // RVA: 0x7FFE87D40150
        public void Move_Injected(){} // RVA: 0x7FFE87D401B0
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x7FFE87D40220
        public void GetPointVelocity_Injected(){} // RVA: 0x7FFE87D40290
        public void get_excludeLayers_Injected(){} // RVA: 0x7FFE87D40300
        public void set_excludeLayers_Injected(){} // RVA: 0x7FFE87D40360
        public void get_includeLayers_Injected(){} // RVA: 0x7FFE87D403C0
        public void set_includeLayers_Injected(){} // RVA: 0x7FFE87D40420
        public void GetAccumulatedForce_Injected(){} // RVA: 0x7FFE87D40480
        public void GetAccumulatedTorque_Injected(){} // RVA: 0x7FFE87D404F0
        public void AddForce_Injected(){} // RVA: 0x7FFE87D40560
        public void AddRelativeForce_Injected(){} // RVA: 0x7FFE87D405D0
        public void AddTorque_Injected(){} // RVA: 0x7FFE87D40640
        public void AddRelativeTorque_Injected(){} // RVA: 0x7FFE87D406B0
        public void AddForceAtPosition_Injected(){} // RVA: 0x7FFE87D40720
        public void AddExplosionForce_Injected(){} // RVA: 0x7FFE87D407A0
        public void Internal_ClosestPointOnBounds_Injected(){} // RVA: 0x7FFE87D40830
        public void SweepTest_Injected(){} // RVA: 0x7FFE87D408B0
        public void Internal_SweepTestAll_Injected(){} // RVA: 0x7FFE87D40940
    }

    public class Rigidbody2D : Component
    {
        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFE87D21FB0
        public void set_position(){} // RVA: 0x7FFE87D22010
        public void get_rotation(){} // RVA: 0x7FFE87D22070
        public void set_rotation(){} // RVA: 0x7FFE87D220C0
        public void SetRotation(){} // RVA: 0x7FFE87D22180 | overloaded x2
        public void SetRotation_Angle(){} // RVA: 0x7FFE87D22120
        public void SetRotation_Quaternion(){} // RVA: 0x7FFE87D221E0
        public void MovePosition(){} // RVA: 0x7FFE87D22240
        public void MoveRotation(){} // RVA: 0x7FFE87D22300 | overloaded x2
        public void MoveRotation_Angle(){} // RVA: 0x7FFE87D222A0
        public void MoveRotation_Quaternion(){} // RVA: 0x7FFE87D22360
        public void get_velocity(){} // RVA: 0x7FFE87D223C0
        public void set_velocity(){} // RVA: 0x7FFE87D22420
        public void get_angularVelocity(){} // RVA: 0x7FFE87D22480
        public void set_angularVelocity(){} // RVA: 0x7FFE87D224D0
        public void get_useAutoMass(){} // RVA: 0x7FFE87D22530
        public void set_useAutoMass(){} // RVA: 0x7FFE87D22580
        public void get_mass(){} // RVA: 0x7FFE87D225E0
        public void set_mass(){} // RVA: 0x7FFE87D22630
        public void get_sharedMaterial(){} // RVA: 0x7FFE87D22690
        public void set_sharedMaterial(){} // RVA: 0x7FFE87D226E0
        public void get_centerOfMass(){} // RVA: 0x7FFE87D22740
        public void set_centerOfMass(){} // RVA: 0x7FFE87D227A0
        public void get_worldCenterOfMass(){} // RVA: 0x7FFE87D22800
        public void get_inertia(){} // RVA: 0x7FFE87D22860
        public void set_inertia(){} // RVA: 0x7FFE87D228B0
        public void get_drag(){} // RVA: 0x7FFE87D22910
        public void set_drag(){} // RVA: 0x7FFE87D22960
        public void get_angularDrag(){} // RVA: 0x7FFE87D229C0
        public void set_angularDrag(){} // RVA: 0x7FFE87D22A10
        public void get_gravityScale(){} // RVA: 0x7FFE87D22A70
        public void set_gravityScale(){} // RVA: 0x7FFE87D22AC0
        public void get_bodyType(){} // RVA: 0x7FFE87D22B20
        public void set_bodyType(){} // RVA: 0x7FFE87D22B70
        public void get_useFullKinematicContacts(){} // RVA: 0x7FFE87D22BD0
        public void set_useFullKinematicContacts(){} // RVA: 0x7FFE87D22C20
        public void get_isKinematic(){} // RVA: 0x7FFE87D22C80
        public void set_isKinematic(){} // RVA: 0x7FFE87D22CE0
        public void get_freezeRotation(){} // RVA: 0x7FFE87D22D50
        public void set_freezeRotation(){} // RVA: 0x7FFE87D22DA0
        public void get_constraints(){} // RVA: 0x7FFE87D22E00
        public void set_constraints(){} // RVA: 0x7FFE87D22E50
        public void IsSleeping(){} // RVA: 0x7FFE87D22EB0
        public void IsAwake(){} // RVA: 0x7FFE87D22F00
        public void Sleep(){} // RVA: 0x7FFE87D22F50
        public void WakeUp(){} // RVA: 0x7FFE87D22FA0
        public void get_simulated(){} // RVA: 0x7FFE87D22FF0
        public void set_simulated(){} // RVA: 0x7FFE87D23040
        public void get_interpolation(){} // RVA: 0x7FFE87D230A0
        public void set_interpolation(){} // RVA: 0x7FFE87D230F0
        public void get_sleepMode(){} // RVA: 0x7FFE87D23150
        public void set_sleepMode(){} // RVA: 0x7FFE87D231A0
        public void get_collisionDetectionMode(){} // RVA: 0x7FFE87D23200
        public void set_collisionDetectionMode(){} // RVA: 0x7FFE87D23250
        public void get_attachedColliderCount(){} // RVA: 0x7FFE87D232B0
        public void get_totalForce(){} // RVA: 0x7FFE87D23300
        public void set_totalForce(){} // RVA: 0x7FFE87D23360
        public void get_totalTorque(){} // RVA: 0x7FFE87D233C0
        public void set_totalTorque(){} // RVA: 0x7FFE87D23410
        public void get_excludeLayers(){} // RVA: 0x7FFE87D23470
        public void set_excludeLayers(){} // RVA: 0x7FFE87D234D0
        public void get_includeLayers(){} // RVA: 0x7FFE87D23530
        public void set_includeLayers(){} // RVA: 0x7FFE87D23590
        public void IsTouching(){} // RVA: 0x7FFE87D23740 | overloaded x3
        public void IsTouching_OtherColliderWithFilter_Internal(){} // RVA: 0x7FFE87D236D0
        public void IsTouching_AnyColliderWithFilter_Internal(){} // RVA: 0x7FFE87D237B0
        public void IsTouchingLayers(){} // RVA: 0x7FFE87D23870 | overloaded x2
        public void OverlapPoint(){} // RVA: 0x7FFE87D238D0
        public void Distance(){} // RVA: 0x7FFE87D23930
        public void Distance_Internal(){} // RVA: 0x7FFE87D23C50
        public void ClosestPoint(){} // RVA: 0x7FFE87D23CD0
        public void AddForce(){} // RVA: 0x7FFE87D23DA0 | overloaded x2
        public void AddRelativeForce(){} // RVA: 0x7FFE87D23E70 | overloaded x2
        public void AddForceAtPosition(){} // RVA: 0x7FFE87D23F50 | overloaded x2
        public void AddTorque(){} // RVA: 0x7FFE87D24040 | overloaded x2
        public void GetPoint(){} // RVA: 0x7FFE87D240B0
        public void GetRelativePoint(){} // RVA: 0x7FFE87D24120
        public void GetVector(){} // RVA: 0x7FFE87D24190
        public void GetRelativeVector(){} // RVA: 0x7FFE87D24200
        public void GetPointVelocity(){} // RVA: 0x7FFE87D24270
        public void GetRelativePointVelocity(){} // RVA: 0x7FFE87D242E0
        public void OverlapCollider(){} // RVA: 0x7FFE87D24440 | overloaded x2
        public void OverlapColliderArray_Internal(){} // RVA: 0x7FFE87D243D0
        public void OverlapColliderList_Internal(){} // RVA: 0x7FFE87D244C0
        public void GetContacts(){} // RVA: 0x7FFE87D249E0 | overloaded x8
        public void GetAttachedColliders(){} // RVA: 0x7FFE87D24AD0 | overloaded x2
        public void GetAttachedCollidersArray_Internal(){} // RVA: 0x7FFE87D24A70
        public void GetAttachedCollidersList_Internal(){} // RVA: 0x7FFE87D24AD0
        public void Cast(){} // RVA: 0x7FFE87D24ED0 | overloaded x6
        public void CastArray_Internal(){} // RVA: 0x7FFE87D24B80
        public void CastList_Internal(){} // RVA: 0x7FFE87D24C80
        public void CastFilteredArray_Internal(){} // RVA: 0x7FFE87D24E40
        public void CastFilteredList_Internal(){} // RVA: 0x7FFE87D24F70
        public void GetShapes(){} // RVA: 0x7FFE87D25000
        public void GetShapes_Internal(){} // RVA: 0x7FFE87D25070
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_position_Injected(){} // RVA: 0x7FFE87D250D0
        public void set_position_Injected(){} // RVA: 0x7FFE87D25130
        public void SetRotation_Quaternion_Injected(){} // RVA: 0x7FFE87D25190
        public void MovePosition_Injected(){} // RVA: 0x7FFE87D251F0
        public void MoveRotation_Quaternion_Injected(){} // RVA: 0x7FFE87D25250
        public void get_velocity_Injected(){} // RVA: 0x7FFE87D252B0
        public void set_velocity_Injected(){} // RVA: 0x7FFE87D25310
        public void get_centerOfMass_Injected(){} // RVA: 0x7FFE87D25370
        public void set_centerOfMass_Injected(){} // RVA: 0x7FFE87D253D0
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x7FFE87D25430
        public void get_totalForce_Injected(){} // RVA: 0x7FFE87D25490
        public void set_totalForce_Injected(){} // RVA: 0x7FFE87D254F0
        public void get_excludeLayers_Injected(){} // RVA: 0x7FFE87D25550
        public void set_excludeLayers_Injected(){} // RVA: 0x7FFE87D255B0
        public void get_includeLayers_Injected(){} // RVA: 0x7FFE87D25610
        public void set_includeLayers_Injected(){} // RVA: 0x7FFE87D25670
        public void IsTouching_OtherColliderWithFilter_Internal_Injected(){} // RVA: 0x7FFE87D256D0
        public void IsTouching_AnyColliderWithFilter_Internal_Injected(){} // RVA: 0x7FFE87D25740
        public void OverlapPoint_Injected(){} // RVA: 0x7FFE87D257A0
        public void Distance_Internal_Injected(){} // RVA: 0x7FFE87D25800
        public void AddForce_Injected(){} // RVA: 0x7FFE87D25870
        public void AddRelativeForce_Injected(){} // RVA: 0x7FFE87D258E0
        public void AddForceAtPosition_Injected(){} // RVA: 0x7FFE87D25950
        public void GetPoint_Injected(){} // RVA: 0x7FFE87D259D0
        public void GetRelativePoint_Injected(){} // RVA: 0x7FFE87D25A40
        public void GetVector_Injected(){} // RVA: 0x7FFE87D25AB0
        public void GetRelativeVector_Injected(){} // RVA: 0x7FFE87D25B20
        public void GetPointVelocity_Injected(){} // RVA: 0x7FFE87D25B90
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x7FFE87D25C00
        public void OverlapColliderArray_Internal_Injected(){} // RVA: 0x7FFE87D25C70
        public void OverlapColliderList_Internal_Injected(){} // RVA: 0x7FFE87D25CE0
        public void CastArray_Internal_Injected(){} // RVA: 0x7FFE87D25D50
        public void CastList_Internal_Injected(){} // RVA: 0x7FFE87D25DD0
        public void CastFilteredArray_Internal_Injected(){} // RVA: 0x7FFE87D25E50
        public void CastFilteredList_Internal_Injected(){} // RVA: 0x7FFE87D25EE0
    }

    public class RuntimeAnimatorController : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BDB550
        public void get_animationClips(){} // RVA: 0x7FFE87BDB5A0
    }

    public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
    {
        public 0x66578B6C m_LoadType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0 | overloaded x2
        public void set_loadType(){} // RVA: 0x7FFE810FE0C0
    }

}