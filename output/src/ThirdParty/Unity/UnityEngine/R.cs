// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 57
// Methods: 1618

namespace ThirdParty.Unity.UnityEngine
{
    public class Random : Object
    {
        // ── Methods ──
        public void InitState(){} // RVA: 0x7BF2770
        public void Range(){} // RVA: 0x7BF2830
        public void RandomRangeInt(){} // RVA: 0x7BF2830
        public void get_value(){} // RVA: 0x1FFC590
        public void get_insideUnitSphere(){} // RVA: 0x7BF2890
        public void GetRandomUnitCircle(){} // RVA: 0x7BF28F0
        public void get_insideUnitCircle(){} // RVA: 0x7BF2940
        public void get_onUnitSphere(){} // RVA: 0x7BF29A0
        public void get_rotation(){} // RVA: 0x7BF2A00
        public void get_rotationUniform(){} // RVA: 0x7BF2A60
        public void ColorHSV(){} // RVA: 0x7BF2C60
        public void get_insideUnitSphere_Injected(){} // RVA: 0x7BF2ED0
        public void get_onUnitSphere_Injected(){} // RVA: 0x7BF2F20
        public void get_rotation_Injected(){} // RVA: 0x7BF2F70
        public void get_rotationUniform_Injected(){} // RVA: 0x7BF2FC0
    }

    public class RangeAttribute : PropertyAttribute
    {
        public object min;
        public object max;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7BF2390
    }

    public class RangeInt : ValueType
    {
        public object start;
        public object length;

        // ── Methods ──
        public void get_end(){} // RVA: 0x9662B0
        public void .ctor(){} // RVA: 0x2B100
    }

    public class RangeInt[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7D9E0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3CA0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E33ED0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Ray : ValueType
    {
        public object m_Origin;
        public object m_Direction;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x961820
        public void get_origin(){} // RVA: 0x45A590
        public void set_origin(){} // RVA: 0x45A580
        public void get_direction(){} // RVA: 0x959B90
        public void set_direction(){} // RVA: 0x9618F0
        public void GetPoint(){} // RVA: 0x9619B0
        public void ToString(){} // RVA: 0x961A20
    }

    public class RaycastCommand : ValueType
    {
        public object _from;
        public object _direction;
        public object _physicsScene;
        public object _distance;
        public object queryParameters;

        // ── Methods ──
        public void set_from(){} // RVA: 0x45A580
        public void set_direction(){} // RVA: 0x9582E0
        public void set_physicsScene(){} // RVA: 0xC3AF0
        public void set_distance(){} // RVA: 0x9B0A0
        public void ScheduleBatch(){} // RVA: 0x7D36330
        public void ScheduleRaycastBatch(){} // RVA: 0x7D36560
        public void ScheduleRaycastBatch_Injected(){} // RVA: 0x7D36610
    }

    public class RaycastHit : ValueType
    {
        public object m_Point;
        public object m_Normal;
        public object m_FaceID;
        public object m_Distance;
        public object m_UV;
        public object m_Collider;

        // ── Methods ──
        public void get_collider(){} // RVA: 0x986560
        public void get_colliderInstanceID(){} // RVA: 0x53FAD0
        public void get_point(){} // RVA: 0x45A590
        public void set_point(){} // RVA: 0x45A580
        public void get_normal(){} // RVA: 0x959B90
        public void set_normal(){} // RVA: 0x9582E0
        public void get_barycentricCoordinate(){} // RVA: 0x986570
        public void set_barycentricCoordinate(){} // RVA: 0x9865A0
        public void get_distance(){} // RVA: 0x958990
        public void set_distance(){} // RVA: 0x9B110
        public void get_triangleIndex(){} // RVA: 0x53FA00
        public void CalculateRaycastTexCoord(){} // RVA: 0x7D367A0
        public void get_textureCoord(){} // RVA: 0x9865C0
        public void get_textureCoord2(){} // RVA: 0x9865D0
        public void get_transform(){} // RVA: 0x9865E0
        public void get_rigidbody(){} // RVA: 0x9865F0
        public void get_articulationBody(){} // RVA: 0x986600
        public void get_lightmapCoord(){} // RVA: 0x986610
        public void CalculateRaycastTexCoord_Injected(){} // RVA: 0x7D37010
    }

    public class RaycastHit2D : ValueType
    {
        public object m_Centroid;
        public object m_Point;
        public object m_Normal;
        public object m_Distance;
        public object m_Fraction;
        public object m_Collider;

        // ── Methods ──
        public void get_centroid(){} // RVA: 0x961A70
        public void set_centroid(){} // RVA: 0x93050
        public void get_point(){} // RVA: 0x961BE0
        public void set_point(){} // RVA: 0x990A0
        public void get_normal(){} // RVA: 0x984800
        public void set_normal(){} // RVA: 0xE1E10
        public void get_distance(){} // RVA: 0x958980
        public void set_distance(){} // RVA: 0x9B0C0
        public void get_fraction(){} // RVA: 0x958990
        public void set_fraction(){} // RVA: 0x9B110
        public void get_collider(){} // RVA: 0x984F90
        public void get_rigidbody(){} // RVA: 0x984FA0
        public void get_transform(){} // RVA: 0x984FB0
        public void op_Implicit(){} // RVA: 0x7CF59E0
        public void CompareTo(){} // RVA: 0x984FC0
    }

    public class RaycastHit2D[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7F2C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7AE10
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4AF0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E35240
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7AE10
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RaycastHit[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB05B0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7C800
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC82F0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6BFE0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7C800
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Rect : ValueType
    {
        public object m_XMin;
        public object m_YMin;
        public object m_Width;
        public object m_Height;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9440D0
        public void get_zero(){} // RVA: 0x7B73550
        public void MinMaxRect(){} // RVA: 0x7B73560
        public void Set(){} // RVA: 0x4FE0
        public void get_x(){} // RVA: 0x459690
        public void set_x(){} // RVA: 0xD1B20
        public void get_y(){} // RVA: 0x958940
        public void set_y(){} // RVA: 0xD1B40
        public void get_position(){} // RVA: 0x961A70
        public void set_position(){} // RVA: 0x961A90
        public void get_center(){} // RVA: 0x961AB0
        public void set_center(){} // RVA: 0x961AE0
        public void get_min(){} // RVA: 0x961B20
        public void set_min(){} // RVA: 0x961B40
        public void get_max(){} // RVA: 0x961B90
        public void set_max(){} // RVA: 0x961BB0
        public void get_width(){} // RVA: 0x958950
        public void set_width(){} // RVA: 0xD1B50
        public void get_height(){} // RVA: 0x958960
        public void set_height(){} // RVA: 0xD1B10
        public void get_size(){} // RVA: 0x961BE0
        public void set_size(){} // RVA: 0x961C00
        public void get_xMin(){} // RVA: 0x459690
        public void set_xMin(){} // RVA: 0x961C20
        public void get_yMin(){} // RVA: 0x958940
        public void set_yMin(){} // RVA: 0x961C40
        public void get_xMax(){} // RVA: 0x961C60
        public void set_xMax(){} // RVA: 0x961C70
        public void get_yMax(){} // RVA: 0x961C80
        public void set_yMax(){} // RVA: 0x961C90
        public void Contains(){} // RVA: 0x961D30
        public void OrderMinMax(){} // RVA: 0x7B73960
        public void Overlaps(){} // RVA: 0x961DC0
        public void NormalizedToPoint(){} // RVA: 0x7B73B80
        public void PointToNormalized(){} // RVA: 0x7B73C00
        public void op_Inequality(){} // RVA: 0x7B73CA0
        public void op_Equality(){} // RVA: 0x7B73CF0
        public void GetHashCode(){} // RVA: 0x961DE0
        public void Equals(){} // RVA: 0x961E80
        public void ToString(){} // RVA: 0x961EE0
    }

    public class RectInt : ValueType
    {
        public object m_XMin;
        public object m_YMin;
        public object m_Width;
        public object m_Height;

        // ── Methods ──
        public void get_x(){} // RVA: 0x454FE0
        public void set_x(){} // RVA: 0x29580
        public void get_y(){} // RVA: 0x4A8D60
        public void set_y(){} // RVA: 0x77EE0
        public void get_width(){} // RVA: 0x438050
        public void set_width(){} // RVA: 0x92DD0
        public void get_height(){} // RVA: 0x448F30
        public void set_height(){} // RVA: 0x92DF0
        public void get_xMin(){} // RVA: 0x961EF0
        public void get_yMin(){} // RVA: 0x961F00
        public void get_xMax(){} // RVA: 0x961F10
        public void get_yMax(){} // RVA: 0x961F20
        public void .ctor(){} // RVA: 0x8A8000
        public void Overlaps(){} // RVA: 0x961F30
        public void ToString(){} // RVA: 0x9620E0
        public void GetHashCode(){} // RVA: 0x9620F0
        public void Equals(){} // RVA: 0x962130
    }

    public class RectInt[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB67D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E70410
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RectOffset : Object
    {
        public object m_Ptr;
        public object m_SourceStyle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B74B10
        public void Finalize(){} // RVA: 0x7B74A70
        public void ToString(){} // RVA: 0x7B74D00
        public void Destroy(){} // RVA: 0x7B752A0
        public void InternalCreate(){} // RVA: 0x7B75310
        public void InternalDestroy(){} // RVA: 0x7B75360
        public void get_left(){} // RVA: 0x7B753B0
        public void set_left(){} // RVA: 0x7B75420
        public void get_right(){} // RVA: 0x7B754A0
        public void set_right(){} // RVA: 0x7B75510
        public void get_top(){} // RVA: 0x7B75590
        public void set_top(){} // RVA: 0x7B75600
        public void get_bottom(){} // RVA: 0x7B75680
        public void set_bottom(){} // RVA: 0x7B756F0
        public void get_horizontal(){} // RVA: 0x7B75770
        public void get_vertical(){} // RVA: 0x7B757E0
        public void Remove(){} // RVA: 0x7B75850
        public void get_left_Injected(){} // RVA: 0x7B758F0
        public void set_left_Injected(){} // RVA: 0x7B75940
        public void get_right_Injected(){} // RVA: 0x7B759A0
        public void set_right_Injected(){} // RVA: 0x7B759F0
        public void get_top_Injected(){} // RVA: 0x7B75A50
        public void set_top_Injected(){} // RVA: 0x7B75AA0
        public void get_bottom_Injected(){} // RVA: 0x7B75B00
        public void set_bottom_Injected(){} // RVA: 0x7B75B50
        public void get_horizontal_Injected(){} // RVA: 0x7B75BB0
        public void get_vertical_Injected(){} // RVA: 0x7B75C00
        public void Remove_Injected(){} // RVA: 0x7B75C50
    }

    public class RectOffset[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RectTransform : Transform
    {
        public object reapplyDrivenProperties;

        // ── Methods ──
        public void add_reapplyDrivenProperties(){} // RVA: 0x7C15030
        public void remove_reapplyDrivenProperties(){} // RVA: 0x7C15140
        public void get_rect(){} // RVA: 0x7C15250
        public void get_anchorMin(){} // RVA: 0x7C15310
        public void set_anchorMin(){} // RVA: 0x7C153C0
        public void get_anchorMax(){} // RVA: 0x7C15470
        public void set_anchorMax(){} // RVA: 0x7C15520
        public void get_anchoredPosition(){} // RVA: 0x7C155D0
        public void set_anchoredPosition(){} // RVA: 0x7C15680
        public void get_sizeDelta(){} // RVA: 0x7C15730
        public void set_sizeDelta(){} // RVA: 0x7C157E0
        public void get_pivot(){} // RVA: 0x7C15890
        public void set_pivot(){} // RVA: 0x7C15940
        public void get_anchoredPosition3D(){} // RVA: 0x7C159F0
        public void set_anchoredPosition3D(){} // RVA: 0x7C15AE0
        public void get_offsetMin(){} // RVA: 0x7C15C60
        public void set_offsetMin(){} // RVA: 0x7C15CD0
        public void get_offsetMax(){} // RVA: 0x7C15E70
        public void set_offsetMax(){} // RVA: 0x7C15F30
        public void get_drivenByObject(){} // RVA: 0x7C160A0
        public void set_drivenByObject(){} // RVA: 0x7C16160
        public void get_drivenProperties(){} // RVA: 0x7C16240
        public void set_drivenProperties(){} // RVA: 0x7C162E0
        public void get_sendChildDimensionsChange(){} // RVA: 0x7C16390
        public void set_sendChildDimensionsChange(){} // RVA: 0x7C16430
        public void ForceUpdateRectTransforms(){} // RVA: 0x7C164E0
        public void GetLocalCorners(){} // RVA: 0x7C16580
        public void GetWorldCorners(){} // RVA: 0x7C16740
        public void SetInsetAndSizeFromParentEdge(){} // RVA: 0x7C16AA0
        public void SetSizeWithCurrentAnchors(){} // RVA: 0x7C16E00
        public void SendReapplyDrivenProperties(){} // RVA: 0x7C16FD0
        public void GetRectInParentSpace(){} // RVA: 0x7C17030
        public void GetParentSize(){} // RVA: 0x7C17400
        public void .ctor(){} // RVA: 0xB43D60
        public void get_rect_Injected(){} // RVA: 0x7C175F0
        public void get_anchorMin_Injected(){} // RVA: 0x7C17650
        public void set_anchorMin_Injected(){} // RVA: 0x7C176B0
        public void get_anchorMax_Injected(){} // RVA: 0x7C17710
        public void set_anchorMax_Injected(){} // RVA: 0x7C17770
        public void get_anchoredPosition_Injected(){} // RVA: 0x7C177D0
        public void set_anchoredPosition_Injected(){} // RVA: 0x7C17830
        public void get_sizeDelta_Injected(){} // RVA: 0x7C17890
        public void set_sizeDelta_Injected(){} // RVA: 0x7C178F0
        public void get_pivot_Injected(){} // RVA: 0x7C17950
        public void set_pivot_Injected(){} // RVA: 0x7C179B0
        public void get_drivenByObject_Injected(){} // RVA: 0x7C17A10
        public void set_drivenByObject_Injected(){} // RVA: 0x7C17A60
        public void get_drivenProperties_Injected(){} // RVA: 0x7C17AC0
        public void set_drivenProperties_Injected(){} // RVA: 0x7C17B10
        public void get_sendChildDimensionsChange_Injected(){} // RVA: 0x7C17B70
        public void set_sendChildDimensionsChange_Injected(){} // RVA: 0x7C17BC0
        public void ForceUpdateRectTransforms_Injected(){} // RVA: 0x7C17C20
    }

    public class RectTransformUtility : Object
    {
        public object s_Corners;

        // ── Methods ──
        public void PixelAdjustPoint(){} // RVA: 0x80C8F30
        public void PixelAdjustRect(){} // RVA: 0x80C9050
        public void PointInRectangle(){} // RVA: 0x80C9170
        public void RectangleContainsScreenPoint(){} // RVA: 0x80C93C0
        public void ScreenPointToWorldPointInRectangle(){} // RVA: 0x80C9520
        public void ScreenPointToLocalPointInRectangle(){} // RVA: 0x80C9CC0
        public void ScreenPointToRay(){} // RVA: 0x80C9E60
        public void WorldToScreenPoint(){} // RVA: 0x80CA140
        public void FlipLayoutOnAxis(){} // RVA: 0x80CA2F0
        public void FlipLayoutAxes(){} // RVA: 0x80CAC10
        public void GetTransposed(){} // RVA: 0x80CB460
        public void .cctor(){} // RVA: 0x80CB480
        public void PixelAdjustPoint_Injected(){} // RVA: 0x80CB540
        public void PixelAdjustRect_Injected(){} // RVA: 0x80CB5C0
        public void PointInRectangle_Injected(){} // RVA: 0x80CB630
    }

    public class RectTransform[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Rect[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB65E0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E70300
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ReflectionProbe : Behaviour
    {
        public object reflectionProbeChanged;
        public object registeredDefaultReflectionSetActions;
        public object registeredDefaultReflectionTextureActions;

        // ── Methods ──
        public void get_type(){} // RVA: 0x7B66050
        public void set_type(){} // RVA: 0x7B66110
        public void get_size(){} // RVA: 0x7B661E0
        public void set_size(){} // RVA: 0x7B662C0
        public void get_center(){} // RVA: 0x7B66390
        public void set_center(){} // RVA: 0x7B66470
        public void get_nearClipPlane(){} // RVA: 0x7B66540
        public void set_nearClipPlane(){} // RVA: 0x7B66600
        public void get_farClipPlane(){} // RVA: 0x7B666D0
        public void set_farClipPlane(){} // RVA: 0x7B66790
        public void get_intensity(){} // RVA: 0x7B66860
        public void set_intensity(){} // RVA: 0x7B66920
        public void get_bounds(){} // RVA: 0x7B669F0
        public void get_hdr(){} // RVA: 0x7B66AD0
        public void set_hdr(){} // RVA: 0x7B66B90
        public void get_renderDynamicObjects(){} // RVA: 0x7B66C60
        public void set_renderDynamicObjects(){} // RVA: 0x7B66D20
        public void get_shadowDistance(){} // RVA: 0x7B66DF0
        public void set_shadowDistance(){} // RVA: 0x7B66EB0
        public void get_resolution(){} // RVA: 0x7B66F80
        public void set_resolution(){} // RVA: 0x7B67040
        public void get_cullingMask(){} // RVA: 0x7B67110
        public void set_cullingMask(){} // RVA: 0x7B671D0
        public void get_clearFlags(){} // RVA: 0x7B672A0
        public void set_clearFlags(){} // RVA: 0x7B67360
        public void get_backgroundColor(){} // RVA: 0x7B67430
        public void set_backgroundColor(){} // RVA: 0x7B67510
        public void get_blendDistance(){} // RVA: 0x7B675E0
        public void set_blendDistance(){} // RVA: 0x7B676A0
        public void get_boxProjection(){} // RVA: 0x7B67770
        public void set_boxProjection(){} // RVA: 0x7B67830
        public void get_mode(){} // RVA: 0x7B67900
        public void set_mode(){} // RVA: 0x7B679C0
        public void get_importance(){} // RVA: 0x7B67A90
        public void set_importance(){} // RVA: 0x7B67B50
        public void get_refreshMode(){} // RVA: 0x7B67C20
        public void set_refreshMode(){} // RVA: 0x7B67CE0
        public void get_timeSlicingMode(){} // RVA: 0x7B67DB0
        public void set_timeSlicingMode(){} // RVA: 0x7B67E70
        public void get_bakedTexture(){} // RVA: 0x7B67F40
        public void set_bakedTexture(){} // RVA: 0x7B68020
        public void get_customBakedTexture(){} // RVA: 0x7B68130
        public void set_customBakedTexture(){} // RVA: 0x7B68210
        public void get_realtimeTexture(){} // RVA: 0x7B68320
        public void set_realtimeTexture(){} // RVA: 0x7B68400
        public void get_texture(){} // RVA: 0x7B68510
        public void get_textureHDRDecodeValues(){} // RVA: 0x7B685F0
        public void Reset(){} // RVA: 0x7B686D0
        public void RenderProbe(){} // RVA: 0x7B687A0
        public void IsFinishedRendering(){} // RVA: 0x7B688C0
        public void ScheduleRender(){} // RVA: 0x7B68990
        public void BlendCubemap(){} // RVA: 0x7B68AB0
        public void UpdateCachedState(){} // RVA: 0x7B68C00
        public void get_minBakedCubemapResolution(){} // RVA: 0x7B68C50
        public void get_maxBakedCubemapResolution(){} // RVA: 0x7B68CA0
        public void get_defaultTextureHDRDecodeValues(){} // RVA: 0x7B68CF0
        public void get_defaultTexture(){} // RVA: 0x7B68D80
        public void add_reflectionProbeChanged(){} // RVA: 0x7B68E20
        public void remove_reflectionProbeChanged(){} // RVA: 0x7B68F80
        public void CallReflectionProbeEvent(){} // RVA: 0x7B690E0
        public void add_defaultReflectionSet(){} // RVA: 0x7B69160
        public void remove_defaultReflectionSet(){} // RVA: 0x7B693B0
        public void add_defaultReflectionTexture(){} // RVA: 0x7B69590
        public void remove_defaultReflectionTexture(){} // RVA: 0x7B69840
        public void CallSetDefaultReflection(){} // RVA: 0x7B698D0
        public void .ctor(){} // RVA: 0xB43D60
        public void .cctor(){} // RVA: 0x7B69A70
        public void get_type_Injected(){} // RVA: 0x7B69C10
        public void set_type_Injected(){} // RVA: 0x7B69C60
        public void get_size_Injected(){} // RVA: 0x7B69CC0
        public void set_size_Injected(){} // RVA: 0x7B69D20
        public void get_center_Injected(){} // RVA: 0x7B69D80
        public void set_center_Injected(){} // RVA: 0x7B69DE0
        public void get_nearClipPlane_Injected(){} // RVA: 0x7B69E40
        public void set_nearClipPlane_Injected(){} // RVA: 0x7B69E90
        public void get_farClipPlane_Injected(){} // RVA: 0x7B69EF0
        public void set_farClipPlane_Injected(){} // RVA: 0x7B69F40
        public void get_intensity_Injected(){} // RVA: 0x7B69FA0
        public void set_intensity_Injected(){} // RVA: 0x7B69FF0
        public void get_bounds_Injected(){} // RVA: 0x7B6A050
        public void get_hdr_Injected(){} // RVA: 0x7B6A0B0
        public void set_hdr_Injected(){} // RVA: 0x7B6A100
        public void get_renderDynamicObjects_Injected(){} // RVA: 0x7B6A160
        public void set_renderDynamicObjects_Injected(){} // RVA: 0x7B6A1B0
        public void get_shadowDistance_Injected(){} // RVA: 0x7B6A210
        public void set_shadowDistance_Injected(){} // RVA: 0x7B6A260
        public void get_resolution_Injected(){} // RVA: 0x7B6A2C0
        public void set_resolution_Injected(){} // RVA: 0x7B6A310
        public void get_cullingMask_Injected(){} // RVA: 0x7B6A370
        public void set_cullingMask_Injected(){} // RVA: 0x7B6A3C0
        public void get_clearFlags_Injected(){} // RVA: 0x7B6A420
        public void set_clearFlags_Injected(){} // RVA: 0x7B6A470
        public void get_backgroundColor_Injected(){} // RVA: 0x7B6A4D0
        public void set_backgroundColor_Injected(){} // RVA: 0x7B6A530
        public void get_blendDistance_Injected(){} // RVA: 0x7B6A590
        public void set_blendDistance_Injected(){} // RVA: 0x7B6A5E0
        public void get_boxProjection_Injected(){} // RVA: 0x7B6A640
        public void set_boxProjection_Injected(){} // RVA: 0x7B6A690
        public void get_mode_Injected(){} // RVA: 0x7B6A6F0
        public void set_mode_Injected(){} // RVA: 0x7B6A740
        public void get_importance_Injected(){} // RVA: 0x7B6A7A0
        public void set_importance_Injected(){} // RVA: 0x7B6A7F0
        public void get_refreshMode_Injected(){} // RVA: 0x7B6A850
        public void set_refreshMode_Injected(){} // RVA: 0x7B6A8A0
        public void get_timeSlicingMode_Injected(){} // RVA: 0x7B6A900
        public void set_timeSlicingMode_Injected(){} // RVA: 0x7B6A950
        public void get_bakedTexture_Injected(){} // RVA: 0x7B6A9B0
        public void set_bakedTexture_Injected(){} // RVA: 0x7B6AA00
        public void get_customBakedTexture_Injected(){} // RVA: 0x7B6AA60
        public void set_customBakedTexture_Injected(){} // RVA: 0x7B6AAB0
        public void get_realtimeTexture_Injected(){} // RVA: 0x7B6AB10
        public void set_realtimeTexture_Injected(){} // RVA: 0x7B6AB60
        public void get_texture_Injected(){} // RVA: 0x7B6ABC0
        public void get_textureHDRDecodeValues_Injected(){} // RVA: 0x7B6AC10
        public void Reset_Injected(){} // RVA: 0x7B6AC70
        public void IsFinishedRendering_Injected(){} // RVA: 0x7B6ACC0
        public void ScheduleRender_Injected(){} // RVA: 0x7B6AD20
        public void BlendCubemap_Injected(){} // RVA: 0x7B6AD90
        public void get_defaultTextureHDRDecodeValues_Injected(){} // RVA: 0x7B6AE10
        public void get_defaultTexture_Injected(){} // RVA: 0x7B6AE60
    }

    public class ReflectionProbe[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RefreshRate : ValueType
    {
        public object numerator;
        public object denominator;

        // ── Methods ──
        public void get_value(){} // RVA: 0x962420
        public void Equals(){} // RVA: 0x962440
        public void CompareTo(){} // RVA: 0x962480
        public void ToString(){} // RVA: 0x9624D0
    }

    public class RejectDragAndDropMaterial : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RelativeJoint2D : Joint2D
    {
        // ── Methods ──
        public void get_maxForce(){} // RVA: 0x7D0E600
        public void set_maxForce(){} // RVA: 0x7D0E6A0
        public void get_maxTorque(){} // RVA: 0x7D0E750
        public void set_maxTorque(){} // RVA: 0x7D0E7F0
        public void get_correctionScale(){} // RVA: 0x7D0E8A0
        public void set_correctionScale(){} // RVA: 0x7D0E940
        public void get_autoConfigureOffset(){} // RVA: 0x7D0E9F0
        public void set_autoConfigureOffset(){} // RVA: 0x7D0EA90
        public void get_linearOffset(){} // RVA: 0x7D0EB40
        public void set_linearOffset(){} // RVA: 0x7D0EBF0
        public void get_angularOffset(){} // RVA: 0x7D0ECA0
        public void set_angularOffset(){} // RVA: 0x7D0ED40
        public void get_target(){} // RVA: 0x7D0EDF0
        public void .ctor(){} // RVA: 0xB43D60
        public void get_maxForce_Injected(){} // RVA: 0x7D0EEA0
        public void set_maxForce_Injected(){} // RVA: 0x7D0EEF0
        public void get_maxTorque_Injected(){} // RVA: 0x7D0EF50
        public void set_maxTorque_Injected(){} // RVA: 0x7D0EFA0
        public void get_correctionScale_Injected(){} // RVA: 0x7D0F000
        public void set_correctionScale_Injected(){} // RVA: 0x7D0F050
        public void get_autoConfigureOffset_Injected(){} // RVA: 0x7D0F0B0
        public void set_autoConfigureOffset_Injected(){} // RVA: 0x7D0F100
        public void get_linearOffset_Injected(){} // RVA: 0x7D0F160
        public void set_linearOffset_Injected(){} // RVA: 0x7D0F1C0
        public void get_angularOffset_Injected(){} // RVA: 0x7D0F220
        public void set_angularOffset_Injected(){} // RVA: 0x7D0F270
        public void get_target_Injected(){} // RVA: 0x7D0F2D0
    }

    public class RemoteConfigSettings : Object
    {
        public object m_Ptr;
        public object Updated;

        // ── Methods ──
        public void RemoteConfigSettingsUpdated(){} // RVA: 0x8125C00
    }

    public class RemoteConfigSettings[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RemoteSettings : Object
    {
        public object Updated;
        public object BeforeFetchFromServer;
        public object Completed;

        // ── Methods ──
        public void RemoteSettingsUpdated(){} // RVA: 0x8125AC0
        public void RemoteSettingsBeforeFetchFromServer(){} // RVA: 0x8125B20
        public void RemoteSettingsUpdateCompleted(){} // RVA: 0x8125B80
    }

    public class RemoteSettings[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RenderParams : ValueType
    {
        public object _layer;
        public object _renderingLayerMask;
        public object _rendererPriority;
        public object _instanceID;
        public object _worldBounds;
        public object _camera;
        public object _motionVectorMode;
        public object _reflectionProbeUsage;
        public object _material;
        public object _matProps;
        public object _shadowCastingMode;
        public object _receiveShadows;
        public object _lightProbeUsage;
        public object _lightProbeProxyVolume;
        public object _overrideSceneCullingMask;
        public object _sceneCullingMask;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x962960
        public void set_layer(){} // RVA: 0x29580
        public void set_renderingLayerMask(){} // RVA: 0x77EE0
        public void set_rendererPriority(){} // RVA: 0x92DD0
        public void set_instanceID(){} // RVA: 0x92DF0
        public void set_worldBounds(){} // RVA: 0xDA180
        public void set_camera(){} // RVA: 0x8C5A0
        public void set_motionVectorMode(){} // RVA: 0xC5EF0
        public void set_reflectionProbeUsage(){} // RVA: 0xCFD80
        public void set_material(){} // RVA: 0x24B80
        public void get_matProps(){} // RVA: 0xA3290
        public void set_matProps(){} // RVA: 0x63E40
        public void set_shadowCastingMode(){} // RVA: 0xA6C10
        public void set_receiveShadows(){} // RVA: 0xA6BF0
        public void set_lightProbeUsage(){} // RVA: 0x9588C0
        public void set_lightProbeProxyVolume(){} // RVA: 0xB5F0
        public void set_overrideSceneCullingMask(){} // RVA: 0xA6A90
        public void set_sceneCullingMask(){} // RVA: 0xA6AB0
    }

    public class RenderSettings : Object
    {
        // ── Methods ──
        public void get_fog(){} // RVA: 0x7B97200
        public void set_fog(){} // RVA: 0x7B97250
        public void get_fogStartDistance(){} // RVA: 0x7B972A0
        public void set_fogStartDistance(){} // RVA: 0x7B972F0
        public void get_fogEndDistance(){} // RVA: 0x7B97350
        public void set_fogEndDistance(){} // RVA: 0x7B973A0
        public void get_fogMode(){} // RVA: 0x7B97400
        public void set_fogMode(){} // RVA: 0x7B97450
        public void get_fogColor(){} // RVA: 0x7B974A0
        public void set_fogColor(){} // RVA: 0x7B97500
        public void get_fogDensity(){} // RVA: 0x7B97550
        public void set_fogDensity(){} // RVA: 0x7B975A0
        public void get_ambientMode(){} // RVA: 0x7B97600
        public void set_ambientMode(){} // RVA: 0x7B97650
        public void get_ambientSkyColor(){} // RVA: 0x7B976A0
        public void set_ambientSkyColor(){} // RVA: 0x7B97700
        public void get_ambientEquatorColor(){} // RVA: 0x7B97750
        public void set_ambientEquatorColor(){} // RVA: 0x7B977B0
        public void get_ambientGroundColor(){} // RVA: 0x7B97800
        public void set_ambientGroundColor(){} // RVA: 0x7B97860
        public void get_ambientIntensity(){} // RVA: 0x7B978B0
        public void set_ambientIntensity(){} // RVA: 0x7B97900
        public void get_ambientLight(){} // RVA: 0x7B97960
        public void set_ambientLight(){} // RVA: 0x7B979C0
        public void get_subtractiveShadowColor(){} // RVA: 0x7B97A10
        public void set_subtractiveShadowColor(){} // RVA: 0x7B97A70
        public void get_skybox(){} // RVA: 0x7B97AC0
        public void set_skybox(){} // RVA: 0x7B97B40
        public void get_sun(){} // RVA: 0x7B97BD0
        public void set_sun(){} // RVA: 0x7B97C50
        public void get_ambientProbe(){} // RVA: 0x7B97CE0
        public void set_ambientProbe(){} // RVA: 0x7B97D60
        public void get_customReflectionTexture(){} // RVA: 0x7B97DB0
        public void set_customReflectionTexture(){} // RVA: 0x7B97E30
        public void get_reflectionIntensity(){} // RVA: 0x7B97EC0
        public void set_reflectionIntensity(){} // RVA: 0x7B97F10
        public void get_reflectionBounces(){} // RVA: 0x7B97F70
        public void set_reflectionBounces(){} // RVA: 0x7B97FC0
        public void get_defaultReflectionMode(){} // RVA: 0x7B98010
        public void set_defaultReflectionMode(){} // RVA: 0x7B98060
        public void get_defaultReflectionResolution(){} // RVA: 0x7B980B0
        public void set_defaultReflectionResolution(){} // RVA: 0x7B98100
        public void get_haloStrength(){} // RVA: 0x7B98150
        public void set_haloStrength(){} // RVA: 0x7B981A0
        public void get_flareStrength(){} // RVA: 0x7B98200
        public void set_flareStrength(){} // RVA: 0x7B98250
        public void get_flareFadeSpeed(){} // RVA: 0x7B982B0
        public void set_flareFadeSpeed(){} // RVA: 0x7B98300
        public void get_fogColor_Injected(){} // RVA: 0x7B98360
        public void set_fogColor_Injected(){} // RVA: 0x7B983B0
        public void get_ambientSkyColor_Injected(){} // RVA: 0x7B98400
        public void set_ambientSkyColor_Injected(){} // RVA: 0x7B98450
        public void get_ambientEquatorColor_Injected(){} // RVA: 0x7B984A0
        public void set_ambientEquatorColor_Injected(){} // RVA: 0x7B984F0
        public void get_ambientGroundColor_Injected(){} // RVA: 0x7B98540
        public void set_ambientGroundColor_Injected(){} // RVA: 0x7B98590
        public void get_ambientLight_Injected(){} // RVA: 0x7B985E0
        public void set_ambientLight_Injected(){} // RVA: 0x7B98630
        public void get_subtractiveShadowColor_Injected(){} // RVA: 0x7B98680
        public void set_subtractiveShadowColor_Injected(){} // RVA: 0x7B986D0
        public void get_skybox_Injected(){} // RVA: 0x7B98720
        public void set_skybox_Injected(){} // RVA: 0x7B98770
        public void get_sun_Injected(){} // RVA: 0x7B987C0
        public void set_sun_Injected(){} // RVA: 0x7B98810
        public void get_ambientProbe_Injected(){} // RVA: 0x7B98860
        public void set_ambientProbe_Injected(){} // RVA: 0x7B988B0
        public void get_customReflectionTexture_Injected(){} // RVA: 0x7B98900
        public void set_customReflectionTexture_Injected(){} // RVA: 0x7B98950
    }

    public class RenderTexture : Texture
    {
        // ── Methods ──
        public void get_width(){} // RVA: 0x7BD50C0
        public void set_width(){} // RVA: 0x7BD5160
        public void get_height(){} // RVA: 0x7BD5210
        public void set_height(){} // RVA: 0x7BD52B0
        public void get_dimension(){} // RVA: 0x7BD5360
        public void set_dimension(){} // RVA: 0x7BD5400
        public void GetColorFormat(){} // RVA: 0x7BD54B0
        public void SetColorFormat(){} // RVA: 0x7BD5560
        public void get_graphicsFormat(){} // RVA: 0x7BD5610
        public void set_graphicsFormat(){} // RVA: 0x7BD5560
        public void get_useMipMap(){} // RVA: 0x7BD56B0
        public void set_useMipMap(){} // RVA: 0x7BD5750
        public void get_sRGB(){} // RVA: 0x7BD5800
        public void get_vrUsage(){} // RVA: 0x7BD58A0
        public void set_vrUsage(){} // RVA: 0x7BD5940
        public void get_memorylessMode(){} // RVA: 0x7BD59F0
        public void set_memorylessMode(){} // RVA: 0x7BD5A90
        public void get_format(){} // RVA: 0x7BD5B40
        public void set_format(){} // RVA: 0x7BD5D30
        public void get_stencilFormat(){} // RVA: 0x7BD5E70
        public void set_stencilFormat(){} // RVA: 0x7BD5F10
        public void get_depthStencilFormat(){} // RVA: 0x7BD5FC0
        public void set_depthStencilFormat(){} // RVA: 0x7BD6060
        public void get_autoGenerateMips(){} // RVA: 0x7BD6110
        public void set_autoGenerateMips(){} // RVA: 0x7BD61B0
        public void get_volumeDepth(){} // RVA: 0x7BD6260
        public void set_volumeDepth(){} // RVA: 0x7BD6300
        public void get_antiAliasing(){} // RVA: 0x7BD63B0
        public void set_antiAliasing(){} // RVA: 0x7BD6450
        public void get_bindTextureMS(){} // RVA: 0x7BD6500
        public void set_bindTextureMS(){} // RVA: 0x7BD65A0
        public void get_enableRandomWrite(){} // RVA: 0x7BD6650
        public void set_enableRandomWrite(){} // RVA: 0x7BD66F0
        public void get_useDynamicScale(){} // RVA: 0x7BD67A0
        public void set_useDynamicScale(){} // RVA: 0x7BD6840
        public void get_useDynamicScaleExplicit(){} // RVA: 0x7BD68F0
        public void set_useDynamicScaleExplicit(){} // RVA: 0x7BD6990
        public void ApplyDynamicScale(){} // RVA: 0x7BD6A40
        public void GetIsPowerOfTwo(){} // RVA: 0x7BD6AE0
        public void get_isPowerOfTwo(){} // RVA: 0x7BD6AE0
        public void set_isPowerOfTwo(){} // RVA: 0xB43310
        public void GetActive(){} // RVA: 0x7BD6B80
        public void SetActive(){} // RVA: 0x7BD6C00
        public void get_active(){} // RVA: 0x7BD6B80
        public void set_active(){} // RVA: 0x7BD6C00
        public void GetColorBuffer(){} // RVA: 0x7BD6C90
        public void GetDepthBuffer(){} // RVA: 0x7BD6D50
        public void SetMipMapCount(){} // RVA: 0x7BD6E10
        public void SetShadowSamplingMode(){} // RVA: 0x7BD6EC0
        public void get_colorBuffer(){} // RVA: 0x7BD6F70
        public void get_depthBuffer(){} // RVA: 0x7BD7040
        public void GetNativeDepthBufferPtr(){} // RVA: 0x7BD7110
        public void DiscardContents(){} // RVA: 0x7BD7310
        public void MarkRestoreExpected(){} // RVA: 0x7BD7270
        public void ResolveAA(){} // RVA: 0x7BD7320
        public void ResolveAATo(){} // RVA: 0x7BD73C0
        public void ResolveAntiAliasedSurface(){} // RVA: 0x7BD73C0
        public void SetGlobalShaderProperty(){} // RVA: 0x7BD74A0
        public void Create(){} // RVA: 0x7BD7630
        public void Release(){} // RVA: 0x7BD76D0
        public void IsCreated(){} // RVA: 0x7BD7770
        public void GenerateMips(){} // RVA: 0x7BD7810
        public void ConvertToEquirect(){} // RVA: 0x7BD78B0
        public void SetSRGBReadWrite(){} // RVA: 0x7BD79A0
        public void Internal_Create(){} // RVA: 0x7BD7A50
        public void SupportsStencil(){} // RVA: 0x7BD7AA0
        public void SetRenderTextureDescriptor(){} // RVA: 0x7BD7B30
        public void GetDescriptor(){} // RVA: 0x7BD7BE0
        public void GetTemporary_Internal(){} // RVA: 0x7BD7CA0
        public void ReleaseTemporary(){} // RVA: 0x7BD7D20
        public void get_depth(){} // RVA: 0x7BD7DB0
        public void set_depth(){} // RVA: 0x7BD7E50
        public void .ctor(){} // RVA: 0x7BD8D20
        public void Initialize(){} // RVA: 0x7BD8DF0
        public void GetDepthStencilFormatLegacy(){} // RVA: 0x7BD9040
        public void get_descriptor(){} // RVA: 0x7BD91F0
        public void set_descriptor(){} // RVA: 0x7BD92F0
        public void ValidateRenderTextureDesc(){} // RVA: 0x7BD93C0
        public void GetDefaultColorFormat(){} // RVA: 0x7BD9950
        public void GetDefaultDepthStencilFormat(){} // RVA: 0x7BD99B0
        public void GetShadowSamplingModeForFormat(){} // RVA: 0x7BD9A20
        public void WarnAboutFallbackTo16BitsDepth(){} // RVA: 0x7BD9A30
        public void GetCompatibleFormat(){} // RVA: 0x7BD9B10
        public void GetTemporary(){} // RVA: 0x7BDA520
        public void GetTemporaryImpl(){} // RVA: 0x7BD9D80
        public void get_isCubemap(){} // RVA: 0x7BDA530
        public void set_isCubemap(){} // RVA: 0x7BDA560
        public void get_isVolume(){} // RVA: 0x7BDA5A0
        public void set_isVolume(){} // RVA: 0x7BDA5D0
        public void get_enabled(){} // RVA: 0x295D5B0
        public void set_enabled(){} // RVA: 0xB43310
        public void GetTexelOffset(){} // RVA: 0xB67B00
        public void get_width_Injected(){} // RVA: 0x7BDA600
        public void set_width_Injected(){} // RVA: 0x7BDA650
        public void get_height_Injected(){} // RVA: 0x7BDA6B0
        public void set_height_Injected(){} // RVA: 0x7BDA700
        public void get_dimension_Injected(){} // RVA: 0x7BDA760
        public void set_dimension_Injected(){} // RVA: 0x7BDA7B0
        public void GetColorFormat_Injected(){} // RVA: 0x7BDA810
        public void SetColorFormat_Injected(){} // RVA: 0x7BDA870
        public void get_useMipMap_Injected(){} // RVA: 0x7BDA8D0
        public void set_useMipMap_Injected(){} // RVA: 0x7BDA920
        public void get_sRGB_Injected(){} // RVA: 0x7BDA980
        public void get_vrUsage_Injected(){} // RVA: 0x7BDA9D0
        public void set_vrUsage_Injected(){} // RVA: 0x7BDAA20
        public void get_memorylessMode_Injected(){} // RVA: 0x7BDAA80
        public void set_memorylessMode_Injected(){} // RVA: 0x7BDAAD0
        public void get_stencilFormat_Injected(){} // RVA: 0x7BDAB30
        public void set_stencilFormat_Injected(){} // RVA: 0x7BDAB80
        public void get_depthStencilFormat_Injected(){} // RVA: 0x7BDABE0
        public void set_depthStencilFormat_Injected(){} // RVA: 0x7BDAC30
        public void get_autoGenerateMips_Injected(){} // RVA: 0x7BDAC90
        public void set_autoGenerateMips_Injected(){} // RVA: 0x7BDACE0
        public void get_volumeDepth_Injected(){} // RVA: 0x7BDAD40
        public void set_volumeDepth_Injected(){} // RVA: 0x7BDAD90
        public void get_antiAliasing_Injected(){} // RVA: 0x7BDADF0
        public void set_antiAliasing_Injected(){} // RVA: 0x7BDAE40
        public void get_bindTextureMS_Injected(){} // RVA: 0x7BDAEA0
        public void set_bindTextureMS_Injected(){} // RVA: 0x7BDAEF0
        public void get_enableRandomWrite_Injected(){} // RVA: 0x7BDAF50
        public void set_enableRandomWrite_Injected(){} // RVA: 0x7BDAFA0
        public void get_useDynamicScale_Injected(){} // RVA: 0x7BDB000
        public void set_useDynamicScale_Injected(){} // RVA: 0x7BDB050
        public void get_useDynamicScaleExplicit_Injected(){} // RVA: 0x7BDB0B0
        public void set_useDynamicScaleExplicit_Injected(){} // RVA: 0x7BDB100
        public void ApplyDynamicScale_Injected(){} // RVA: 0x7BDB160
        public void GetIsPowerOfTwo_Injected(){} // RVA: 0x7BDB1B0
        public void GetActive_Injected(){} // RVA: 0x7BDB200
        public void SetActive_Injected(){} // RVA: 0x7BDB250
        public void GetColorBuffer_Injected(){} // RVA: 0x7BDB2A0
        public void GetDepthBuffer_Injected(){} // RVA: 0x7BDB300
        public void SetMipMapCount_Injected(){} // RVA: 0x7BDB360
        public void SetShadowSamplingMode_Injected(){} // RVA: 0x7BDB3C0
        public void GetNativeDepthBufferPtr_Injected(){} // RVA: 0x7BDB420
        public void DiscardContents_Injected(){} // RVA: 0x7BDB470
        public void MarkRestoreExpected_Injected(){} // RVA: 0x7BDB4F0
        public void ResolveAA_Injected(){} // RVA: 0x7BDB540
        public void ResolveAATo_Injected(){} // RVA: 0x7BDB590
        public void SetGlobalShaderProperty_Injected(){} // RVA: 0x7BDB5F0
        public void Create_Injected(){} // RVA: 0x7BDB650
        public void Release_Injected(){} // RVA: 0x7BDB6A0
        public void IsCreated_Injected(){} // RVA: 0x7BDB6F0
        public void GenerateMips_Injected(){} // RVA: 0x7BDB740
        public void ConvertToEquirect_Injected(){} // RVA: 0x7BDB790
        public void SetSRGBReadWrite_Injected(){} // RVA: 0x7BDB800
        public void SupportsStencil_Injected(){} // RVA: 0x7BDB860
        public void SetRenderTextureDescriptor_Injected(){} // RVA: 0x7BDB8B0
        public void GetDescriptor_Injected(){} // RVA: 0x7BDB910
        public void GetTemporary_Internal_Injected(){} // RVA: 0x7BDB970
        public void ReleaseTemporary_Injected(){} // RVA: 0x7BDB9C0
        public void get_depth_Injected(){} // RVA: 0x7BDBA10
        public void set_depth_Injected(){} // RVA: 0x7BDBA60
    }

    public class RenderTextureDescriptor : ValueType
    {
        public object _width;
        public object _height;
        public object _msaaSamples;
        public object _volumeDepth;
        public object _mipCount;
        public object _graphicsFormat;
        public object _stencilFormat;
        public object _depthStencilFormat;
        public object _dimension;
        public object _shadowSamplingMode;
        public object _vrUsage;
        public object _flags;
        public object _memoryless;

        // ── Methods ──
        public void get_width(){} // RVA: 0x77E60
        public void set_width(){} // RVA: 0x29580
        public void get_height(){} // RVA: 0x77E50
        public void set_height(){} // RVA: 0x77EE0
        public void get_msaaSamples(){} // RVA: 0x14790
        public void set_msaaSamples(){} // RVA: 0x92DD0
        public void get_volumeDepth(){} // RVA: 0x92DE0
        public void set_volumeDepth(){} // RVA: 0x92DF0
        public void get_mipCount(){} // RVA: 0x8C7E0
        public void set_mipCount(){} // RVA: 0x8C7F0
        public void get_graphicsFormat(){} // RVA: 0x26A910
        public void set_graphicsFormat(){} // RVA: 0x963610
        public void get_depthStencilFormat(){} // RVA: 0x9F5A0
        public void set_depthStencilFormat(){} // RVA: 0x9F5B0
        public void get_colorFormat(){} // RVA: 0x963620
        public void set_colorFormat(){} // RVA: 0x963630
        public void get_sRGB(){} // RVA: 0x963640
        public void set_sRGB(){} // RVA: 0x963650
        public void get_depthBufferBits(){} // RVA: 0x963660
        public void set_depthBufferBits(){} // RVA: 0x963670
        public void get_dimension(){} // RVA: 0x93180
        public void set_dimension(){} // RVA: 0x93190
        public void get_shadowSamplingMode(){} // RVA: 0xE1E20
        public void set_shadowSamplingMode(){} // RVA: 0xE1E00
        public void get_vrUsage(){} // RVA: 0x77D20
        public void set_vrUsage(){} // RVA: 0x77CF0
        public void get_flags(){} // RVA: 0x9589E0
        public void get_memoryless(){} // RVA: 0xA50D0
        public void set_memoryless(){} // RVA: 0xC5EF0
        public void .ctor(){} // RVA: 0x963780
        public void SetOrClearRenderTextureCreationFlag(){} // RVA: 0x963800
        public void get_useMipMap(){} // RVA: 0x963820
        public void set_useMipMap(){} // RVA: 0x963830
        public void get_autoGenerateMips(){} // RVA: 0x963850
        public void set_autoGenerateMips(){} // RVA: 0x963860
        public void get_enableRandomWrite(){} // RVA: 0x963880
        public void set_enableRandomWrite(){} // RVA: 0x963890
        public void get_bindMS(){} // RVA: 0x9638B0
        public void set_bindMS(){} // RVA: 0x9638C0
        public void set_createdFromScript(){} // RVA: 0x9638E0
        public void get_useDynamicScale(){} // RVA: 0x963900
        public void set_useDynamicScale(){} // RVA: 0x963910
    }

    public class RenderTexture[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RenderTexture[][] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Renderer : Component
    {
        // ── Methods ──
        public void get_castShadows(){} // RVA: 0x7B908B0
        public void set_castShadows(){} // RVA: 0x7B90950
        public void get_motionVectors(){} // RVA: 0x7B90970
        public void set_motionVectors(){} // RVA: 0x7B90A10
        public void get_useLightProbes(){} // RVA: 0x7B90A30
        public void set_useLightProbes(){} // RVA: 0x7B90AD0
        public void get_bounds(){} // RVA: 0x7B90AF0
        public void set_bounds(){} // RVA: 0x7B90BB0
        public void get_localBounds(){} // RVA: 0x7B90C60
        public void set_localBounds(){} // RVA: 0x7B90D20
        public void ResetBounds(){} // RVA: 0x7B90DD0
        public void ResetLocalBounds(){} // RVA: 0x7B90E70
        public void Internal_HasCustomBounds(){} // RVA: 0x7B90F10
        public void Internal_HasCustomLocalBounds(){} // RVA: 0x7B90FB0
        public void SetStaticLightmapST(){} // RVA: 0x7B91050
        public void GetMaterial(){} // RVA: 0x7B91100
        public void GetSharedMaterial(){} // RVA: 0x7B911C0
        public void SetMaterial(){} // RVA: 0x7B91280
        public void GetMaterialArray(){} // RVA: 0x7B91360
        public void CopyMaterialArray(){} // RVA: 0x7B91400
        public void CopySharedMaterialArray(){} // RVA: 0x7B914B0
        public void SetMaterialArray(){} // RVA: 0x7B91650
        public void Internal_SetPropertyBlock(){} // RVA: 0x7B91750
        public void Internal_GetPropertyBlock(){} // RVA: 0x7B91810
        public void Internal_SetPropertyBlockMaterialIndex(){} // RVA: 0x7B91910
        public void Internal_GetPropertyBlockMaterialIndex(){} // RVA: 0x7B919E0
        public void HasPropertyBlock(){} // RVA: 0x7B91AF0
        public void SetPropertyBlock(){} // RVA: 0x7B91910
        public void GetPropertyBlock(){} // RVA: 0x7B919E0
        public void GetClosestReflectionProbesInternal(){} // RVA: 0x7B91B90
        public void get_enabled(){} // RVA: 0x7B91C40
        public void set_enabled(){} // RVA: 0x7B91CE0
        public void get_isVisible(){} // RVA: 0x7B91D90
        public void get_shadowCastingMode(){} // RVA: 0x7B91E30
        public void set_shadowCastingMode(){} // RVA: 0x7B91ED0
        public void get_receiveShadows(){} // RVA: 0x7B91F80
        public void set_receiveShadows(){} // RVA: 0x7B92020
        public void get_forceRenderingOff(){} // RVA: 0x7B920D0
        public void set_forceRenderingOff(){} // RVA: 0x7B92170
        public void get_allowGPUDrivenRendering(){} // RVA: 0x7B92220
        public void set_allowGPUDrivenRendering(){} // RVA: 0x7B922C0
        public void get_smallMeshCulling(){} // RVA: 0x7B92370
        public void set_smallMeshCulling(){} // RVA: 0x7B92410
        public void GetIsStaticShadowCaster(){} // RVA: 0x7B924C0
        public void SetIsStaticShadowCaster(){} // RVA: 0x7B92560
        public void get_staticShadowCaster(){} // RVA: 0x7B924C0
        public void set_staticShadowCaster(){} // RVA: 0x7B92560
        public void get_motionVectorGenerationMode(){} // RVA: 0x7B92610
        public void set_motionVectorGenerationMode(){} // RVA: 0x7B926B0
        public void get_lightProbeUsage(){} // RVA: 0x7B92760
        public void set_lightProbeUsage(){} // RVA: 0x7B92800
        public void get_reflectionProbeUsage(){} // RVA: 0x7B928B0
        public void set_reflectionProbeUsage(){} // RVA: 0x7B92950
        public void get_renderingLayerMask(){} // RVA: 0x7B92A00
        public void set_renderingLayerMask(){} // RVA: 0x7B92AA0
        public void get_rendererPriority(){} // RVA: 0x7B92B50
        public void set_rendererPriority(){} // RVA: 0x7B92BF0
        public void get_rayTracingMode(){} // RVA: 0x7B92CA0
        public void set_rayTracingMode(){} // RVA: 0x7B92D40
        public void get_rayTracingAccelerationStructureBuildFlags(){} // RVA: 0x7B92DF0
        public void set_rayTracingAccelerationStructureBuildFlags(){} // RVA: 0x7B92E90
        public void get_rayTracingAccelerationStructureBuildFlagsOverride(){} // RVA: 0x7B92F40
        public void set_rayTracingAccelerationStructureBuildFlagsOverride(){} // RVA: 0x7B92FE0
        public void get_sortingLayerName(){} // RVA: 0x7B93090
        public void set_sortingLayerName(){} // RVA: 0x7B931C0
        public void get_sortingLayerID(){} // RVA: 0x7B93350
        public void set_sortingLayerID(){} // RVA: 0x7B933F0
        public void get_sortingOrder(){} // RVA: 0x7B934A0
        public void set_sortingOrder(){} // RVA: 0x7B93540
        public void get_sortingKey(){} // RVA: 0x7B935F0
        public void get_sortingGroupID(){} // RVA: 0x7B93690
        public void set_sortingGroupID(){} // RVA: 0x7B93730
        public void get_sortingGroupOrder(){} // RVA: 0x7B937E0
        public void set_sortingGroupOrder(){} // RVA: 0x7B93880
        public void get_sortingGroupKey(){} // RVA: 0x7B93930
        public void get_isLOD0(){} // RVA: 0x7B939D0
        public void get_allowOcclusionWhenDynamic(){} // RVA: 0x7B93A70
        public void set_allowOcclusionWhenDynamic(){} // RVA: 0x7B93B10
        public void get_staticBatchRootTransform(){} // RVA: 0x7B93BC0
        public void set_staticBatchRootTransform(){} // RVA: 0x7B93C80
        public void get_staticBatchIndex(){} // RVA: 0x7B93D60
        public void SetStaticBatchInfo(){} // RVA: 0x7B93E00
        public void get_isPartOfStaticBatch(){} // RVA: 0x7B93EC0
        public void get_worldToLocalMatrix(){} // RVA: 0x7B93F60
        public void get_localToWorldMatrix(){} // RVA: 0x7B94020
        public void get_lightProbeProxyVolumeOverride(){} // RVA: 0x7B940E0
        public void set_lightProbeProxyVolumeOverride(){} // RVA: 0x7B941A0
        public void get_probeAnchor(){} // RVA: 0x7B94280
        public void set_probeAnchor(){} // RVA: 0x7B94340
        public void GetLightmapIndex(){} // RVA: 0x7B94420
        public void SetLightmapIndex(){} // RVA: 0x7B944D0
        public void GetLightmapST(){} // RVA: 0x7B94590
        public void SetLightmapST(){} // RVA: 0x7B94650
        public void get_lightmapIndex(){} // RVA: 0x7B94710
        public void set_lightmapIndex(){} // RVA: 0x7B947B0
        public void get_realtimeLightmapIndex(){} // RVA: 0x7B947C0
        public void set_realtimeLightmapIndex(){} // RVA: 0x7B94860
        public void get_lightmapScaleOffset(){} // RVA: 0x7B94870
        public void set_lightmapScaleOffset(){} // RVA: 0x7B94940
        public void get_realtimeLightmapScaleOffset(){} // RVA: 0x7B949F0
        public void set_realtimeLightmapScaleOffset(){} // RVA: 0x7B94AC0
        public void GetMaterialCount(){} // RVA: 0x7B94B70
        public void GetSharedMaterialArray(){} // RVA: 0x7B94C10
        public void get_materials(){} // RVA: 0x7B91360
        public void set_materials(){} // RVA: 0x7B94CB0
        public void get_material(){} // RVA: 0x7B91100
        public void set_material(){} // RVA: 0x7B94CC0
        public void get_sharedMaterial(){} // RVA: 0x7B911C0
        public void set_sharedMaterial(){} // RVA: 0x7B94CC0
        public void get_sharedMaterials(){} // RVA: 0x7B94C10
        public void set_sharedMaterials(){} // RVA: 0x7B94CB0
        public void GetMaterials(){} // RVA: 0x7B94CD0
        public void SetSharedMaterials(){} // RVA: 0x7B94E50
        public void SetMaterials(){} // RVA: 0x7B94FF0
        public void GetSharedMaterials(){} // RVA: 0x7B95190
        public void GetClosestReflectionProbes(){} // RVA: 0x7B91B90
        public void get_LODGroup(){} // RVA: 0x7B95310
        public void .ctor(){} // RVA: 0xB43D60
        public void get_bounds_Injected(){} // RVA: 0x7B953D0
        public void set_bounds_Injected(){} // RVA: 0x7B95430
        public void get_localBounds_Injected(){} // RVA: 0x7B95490
        public void set_localBounds_Injected(){} // RVA: 0x7B954F0
        public void ResetBounds_Injected(){} // RVA: 0x7B95550
        public void ResetLocalBounds_Injected(){} // RVA: 0x7B955A0
        public void Internal_HasCustomBounds_Injected(){} // RVA: 0x7B955F0
        public void Internal_HasCustomLocalBounds_Injected(){} // RVA: 0x7B95640
        public void SetStaticLightmapST_Injected(){} // RVA: 0x7B95690
        public void GetMaterial_Injected(){} // RVA: 0x7B956F0
        public void GetSharedMaterial_Injected(){} // RVA: 0x7B95740
        public void SetMaterial_Injected(){} // RVA: 0x7B95790
        public void GetMaterialArray_Injected(){} // RVA: 0x7B957F0
        public void CopyMaterialArray_Injected(){} // RVA: 0x7B95840
        public void CopySharedMaterialArray_Injected(){} // RVA: 0x7B958A0
        public void SetMaterialArray_Injected(){} // RVA: 0x7B95900
        public void Internal_SetPropertyBlock_Injected(){} // RVA: 0x7B95970
        public void Internal_GetPropertyBlock_Injected(){} // RVA: 0x7B959D0
        public void Internal_SetPropertyBlockMaterialIndex_Injected(){} // RVA: 0x7B95A30
        public void Internal_GetPropertyBlockMaterialIndex_Injected(){} // RVA: 0x7B95AA0
        public void HasPropertyBlock_Injected(){} // RVA: 0x7B95B10
        public void GetClosestReflectionProbesInternal_Injected(){} // RVA: 0x7B95B60
        public void get_enabled_Injected(){} // RVA: 0x7B95BC0
        public void set_enabled_Injected(){} // RVA: 0x7B95C10
        public void get_isVisible_Injected(){} // RVA: 0x7B95C70
        public void get_shadowCastingMode_Injected(){} // RVA: 0x7B95CC0
        public void set_shadowCastingMode_Injected(){} // RVA: 0x7B95D10
        public void get_receiveShadows_Injected(){} // RVA: 0x7B95D70
        public void set_receiveShadows_Injected(){} // RVA: 0x7B95DC0
        public void get_forceRenderingOff_Injected(){} // RVA: 0x7B95E20
        public void set_forceRenderingOff_Injected(){} // RVA: 0x7B95E70
        public void get_allowGPUDrivenRendering_Injected(){} // RVA: 0x7B95ED0
        public void set_allowGPUDrivenRendering_Injected(){} // RVA: 0x7B95F20
        public void get_smallMeshCulling_Injected(){} // RVA: 0x7B95F80
        public void set_smallMeshCulling_Injected(){} // RVA: 0x7B95FD0
        public void GetIsStaticShadowCaster_Injected(){} // RVA: 0x7B96030
        public void SetIsStaticShadowCaster_Injected(){} // RVA: 0x7B96080
        public void get_motionVectorGenerationMode_Injected(){} // RVA: 0x7B960E0
        public void set_motionVectorGenerationMode_Injected(){} // RVA: 0x7B96130
        public void get_lightProbeUsage_Injected(){} // RVA: 0x7B96190
        public void set_lightProbeUsage_Injected(){} // RVA: 0x7B961E0
        public void get_reflectionProbeUsage_Injected(){} // RVA: 0x7B96240
        public void set_reflectionProbeUsage_Injected(){} // RVA: 0x7B96290
        public void get_renderingLayerMask_Injected(){} // RVA: 0x7B962F0
        public void set_renderingLayerMask_Injected(){} // RVA: 0x7B96340
        public void get_rendererPriority_Injected(){} // RVA: 0x7B963A0
        public void set_rendererPriority_Injected(){} // RVA: 0x7B963F0
        public void get_rayTracingMode_Injected(){} // RVA: 0x7B96450
        public void set_rayTracingMode_Injected(){} // RVA: 0x7B964A0
        public void get_rayTracingAccelerationStructureBuildFlags_Injected(){} // RVA: 0x7B96500
        public void set_rayTracingAccelerationStructureBuildFlags_Injected(){} // RVA: 0x7B96550
        public void get_rayTracingAccelerationStructureBuildFlagsOverride_Injected(){} // RVA: 0x7B965B0
        public void set_rayTracingAccelerationStructureBuildFlagsOverride_Injected(){} // RVA: 0x7B96600
        public void get_sortingLayerName_Injected(){} // RVA: 0x7B96660
        public void set_sortingLayerName_Injected(){} // RVA: 0x7B966C0
        public void get_sortingLayerID_Injected(){} // RVA: 0x7B96720
        public void set_sortingLayerID_Injected(){} // RVA: 0x7B96770
        public void get_sortingOrder_Injected(){} // RVA: 0x7B967D0
        public void set_sortingOrder_Injected(){} // RVA: 0x7B96820
        public void get_sortingKey_Injected(){} // RVA: 0x7B96880
        public void get_sortingGroupID_Injected(){} // RVA: 0x7B968D0
        public void set_sortingGroupID_Injected(){} // RVA: 0x7B96920
        public void get_sortingGroupOrder_Injected(){} // RVA: 0x7B96980
        public void set_sortingGroupOrder_Injected(){} // RVA: 0x7B969D0
        public void get_sortingGroupKey_Injected(){} // RVA: 0x7B96A30
        public void get_isLOD0_Injected(){} // RVA: 0x7B96A80
        public void get_allowOcclusionWhenDynamic_Injected(){} // RVA: 0x7B96AD0
        public void set_allowOcclusionWhenDynamic_Injected(){} // RVA: 0x7B96B20
        public void get_staticBatchRootTransform_Injected(){} // RVA: 0x7B96B80
        public void set_staticBatchRootTransform_Injected(){} // RVA: 0x7B96BD0
        public void get_staticBatchIndex_Injected(){} // RVA: 0x7B96C30
        public void SetStaticBatchInfo_Injected(){} // RVA: 0x7B96C80
        public void get_isPartOfStaticBatch_Injected(){} // RVA: 0x7B96CF0
        public void get_worldToLocalMatrix_Injected(){} // RVA: 0x7B96D40
        public void get_localToWorldMatrix_Injected(){} // RVA: 0x7B96DA0
        public void get_lightProbeProxyVolumeOverride_Injected(){} // RVA: 0x7B96E00
        public void set_lightProbeProxyVolumeOverride_Injected(){} // RVA: 0x7B96E50
        public void get_probeAnchor_Injected(){} // RVA: 0x7B96EB0
        public void set_probeAnchor_Injected(){} // RVA: 0x7B96F00
        public void GetLightmapIndex_Injected(){} // RVA: 0x7B96F60
        public void SetLightmapIndex_Injected(){} // RVA: 0x7B96FC0
        public void GetLightmapST_Injected(){} // RVA: 0x7B97030
        public void SetLightmapST_Injected(){} // RVA: 0x7B970A0
        public void GetMaterialCount_Injected(){} // RVA: 0x7B97110
        public void GetSharedMaterialArray_Injected(){} // RVA: 0x7B97160
        public void get_LODGroup_Injected(){} // RVA: 0x7B971B0
    }

    public class RendererExtensions : Object
    {
        // ── Methods ──
        public void UpdateGIMaterials(){} // RVA: 0x7B83390
        public void UpdateGIMaterialsForRenderer(){} // RVA: 0x7B83390
        public void UpdateGIMaterialsForRenderer_Injected(){} // RVA: 0x7B83420
    }

    public class Renderer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RenderingLayerMask : ValueType
    {
        public object m_Bits;
        public object _defaultRenderingLayerMask;

        // ── Methods ──
        public void get_defaultRenderingLayerMask(){} // RVA: 0x7BF3010
        public void op_Implicit(){} // RVA: 0x2996070
        public void .cctor(){} // RVA: 0x7BF3070
    }

    public class RenderingLayerMask[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RequireComponent : Attribute
    {
        public object m_Type0;
        public object m_Type1;
        public object m_Type2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
    }

    public class RequireComponent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Resolution : ValueType
    {
        public object m_Width;
        public object m_Height;
        public object m_RefreshRate;

        // ── Methods ──
        public void get_width(){} // RVA: 0x454FE0
        public void set_width(){} // RVA: 0x29580
        public void get_height(){} // RVA: 0x4A8D60
        public void set_height(){} // RVA: 0x77EE0
        public void get_refreshRateRatio(){} // RVA: 0x8C0C50
        public void get_refreshRate(){} // RVA: 0x9626E0
        public void set_refreshRate(){} // RVA: 0x9626F0
        public void ToString(){} // RVA: 0x962700
    }

    public class Resolution[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ResourceRequest : AsyncOperation
    {
        public object m_Path;
        public object m_Type;

        // ── Methods ──
        public void GetResult(){} // RVA: 0x7BF30B0
        public void get_asset(){} // RVA: 0xBFA210
        public void .ctor(){} // RVA: 0x7B30300
    }

    public class ResourceRequest[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Resources : Object
    {
        // ── Methods ──
        public void ConvertObjects(){} // RVA: 0x29A4240
        public void FindObjectsOfTypeAll(){} // RVA: 0x29A43D0
        public void Load(){} // RVA: 0x29A4550
        public void LoadAsync(){} // RVA: 0x29A4640
        public void GetBuiltinResource(){} // RVA: 0xA94080
        public void UnloadAsset(){} // RVA: 0x7BF4200
        public void UnloadUnusedAssets(){} // RVA: 0x7BF4270
        public void GetBuiltinResource_Injected(){} // RVA: 0x7BF4330
        public void UnloadUnusedAssets_Injected(){} // RVA: 0x7BF4390
    }

    public class ResourcesAPI : Object
    {
        public object s_DefaultAPI;
        public object _overrideAPI;

        // ── Methods ──
        public void get_ActiveAPI(){} // RVA: 0x7BF39C0
        public void get_overrideAPI(){} // RVA: 0x7BF3A80
        public void .ctor(){} // RVA: 0xB43310
        public void FindObjectsOfTypeAll(){} // RVA: 0x7BF3AE0
        public void FindShaderByName(){} // RVA: 0x7BF3B30
        public void Load(){} // RVA: 0x7BF3B40
        public void LoadAsync(){} // RVA: 0x7BF3B60
        public void UnloadAsset(){} // RVA: 0x7BF3C50
        public void .cctor(){} // RVA: 0x7BF3CE0
    }

    public class ResourcesAPIInternal : Object
    {
        // ── Methods ──
        public void FindObjectsOfTypeAll(){} // RVA: 0x7BF3130
        public void FindShaderByName(){} // RVA: 0x7BF3180
        public void Load(){} // RVA: 0x7BF3360
        public void LoadAsyncInternal(){} // RVA: 0x7BF3530
        public void UnloadAsset(){} // RVA: 0x7BF37D0
        public void FindShaderByName_Injected(){} // RVA: 0x7BF3860
        public void Load_Injected(){} // RVA: 0x7BF38B0
        public void LoadAsyncInternal_Injected(){} // RVA: 0x7BF3910
        public void UnloadAsset_Injected(){} // RVA: 0x7BF3970
    }

    public class Rigidbody : Component
    {
        // ── Methods ──
        public void get_linearVelocity(){} // RVA: 0x7D37090
        public void set_linearVelocity(){} // RVA: 0x7D37150
        public void get_angularVelocity(){} // RVA: 0x7D37200
        public void set_angularVelocity(){} // RVA: 0x7D372C0
        public void get_linearDamping(){} // RVA: 0x7D37370
        public void set_linearDamping(){} // RVA: 0x7D37410
        public void get_angularDamping(){} // RVA: 0x7D374C0
        public void set_angularDamping(){} // RVA: 0x7D37560
        public void get_mass(){} // RVA: 0x7D37610
        public void set_mass(){} // RVA: 0x7D376B0
        public void SetDensity(){} // RVA: 0x7D37760
        public void get_useGravity(){} // RVA: 0x7D37810
        public void set_useGravity(){} // RVA: 0x7D378B0
        public void get_maxDepenetrationVelocity(){} // RVA: 0x7D37960
        public void set_maxDepenetrationVelocity(){} // RVA: 0x7D37A00
        public void get_isKinematic(){} // RVA: 0x7D37AB0
        public void set_isKinematic(){} // RVA: 0x7D37B50
        public void get_freezeRotation(){} // RVA: 0x7D37C00
        public void set_freezeRotation(){} // RVA: 0x7D37CB0
        public void get_constraints(){} // RVA: 0x7D37D00
        public void set_constraints(){} // RVA: 0x7D37DA0
        public void get_collisionDetectionMode(){} // RVA: 0x7D37E50
        public void set_collisionDetectionMode(){} // RVA: 0x7D37EF0
        public void get_automaticCenterOfMass(){} // RVA: 0x7D37FA0
        public void set_automaticCenterOfMass(){} // RVA: 0x7D38040
        public void get_centerOfMass(){} // RVA: 0x7D380F0
        public void set_centerOfMass(){} // RVA: 0x7D381B0
        public void get_worldCenterOfMass(){} // RVA: 0x7D38260
        public void get_automaticInertiaTensor(){} // RVA: 0x7D38320
        public void set_automaticInertiaTensor(){} // RVA: 0x7D383C0
        public void get_inertiaTensorRotation(){} // RVA: 0x7D38470
        public void set_inertiaTensorRotation(){} // RVA: 0x7D38530
        public void get_inertiaTensor(){} // RVA: 0x7D385E0
        public void set_inertiaTensor(){} // RVA: 0x7D386A0
        public void get_worldInertiaTensorMatrix(){} // RVA: 0x7D38750
        public void get_detectCollisions(){} // RVA: 0x7D38810
        public void set_detectCollisions(){} // RVA: 0x7D388B0
        public void get_position(){} // RVA: 0x7D38960
        public void set_position(){} // RVA: 0x7D38A20
        public void get_rotation(){} // RVA: 0x7D38AD0
        public void set_rotation(){} // RVA: 0x7D38B90
        public void get_interpolation(){} // RVA: 0x7D38C40
        public void set_interpolation(){} // RVA: 0x7D38CE0
        public void get_solverIterations(){} // RVA: 0x7D38D90
        public void set_solverIterations(){} // RVA: 0x7D38E30
        public void get_sleepThreshold(){} // RVA: 0x7D38EE0
        public void set_sleepThreshold(){} // RVA: 0x7D38F80
        public void get_maxAngularVelocity(){} // RVA: 0x7D39030
        public void set_maxAngularVelocity(){} // RVA: 0x7D390D0
        public void get_maxLinearVelocity(){} // RVA: 0x7D39180
        public void set_maxLinearVelocity(){} // RVA: 0x7D39220
        public void MovePosition(){} // RVA: 0x7D392D0
        public void MoveRotation(){} // RVA: 0x7D39380
        public void Move(){} // RVA: 0x7D39430
        public void Sleep(){} // RVA: 0x7D394F0
        public void IsSleeping(){} // RVA: 0x7D39590
        public void WakeUp(){} // RVA: 0x7D39630
        public void ResetCenterOfMass(){} // RVA: 0x7D396D0
        public void ResetInertiaTensor(){} // RVA: 0x7D39770
        public void GetRelativePointVelocity(){} // RVA: 0x7D39810
        public void GetPointVelocity(){} // RVA: 0x7D398E0
        public void get_solverVelocityIterations(){} // RVA: 0x7D399B0
        public void set_solverVelocityIterations(){} // RVA: 0x7D39A50
        public void PublishTransform(){} // RVA: 0x7D39B00
        public void get_excludeLayers(){} // RVA: 0x7D39BA0
        public void set_excludeLayers(){} // RVA: 0x7D39C50
        public void get_includeLayers(){} // RVA: 0x7D39D00
        public void set_includeLayers(){} // RVA: 0x7D39DB0
        public void GetAccumulatedForce(){} // RVA: 0x7D39F30
        public void GetAccumulatedTorque(){} // RVA: 0x7D3A130
        public void AddForce(){} // RVA: 0x7D3A4A0
        public void AddRelativeForce(){} // RVA: 0x7D3A790
        public void AddTorque(){} // RVA: 0x7D3AA80
        public void AddRelativeTorque(){} // RVA: 0x7D3AD70
        public void AddForceAtPosition(){} // RVA: 0x7D3AEF0
        public void AddExplosionForce(){} // RVA: 0x7D3B1A0
        public void Internal_ClosestPointOnBounds(){} // RVA: 0x7D3B290
        public void ClosestPointOnBounds(){} // RVA: 0x7D3B360
        public void SweepTest(){} // RVA: 0x7D3B760
        public void Internal_SweepTestAll(){} // RVA: 0x7D3B7A0
        public void SweepTestAll(){} // RVA: 0x7D3BA30
        public void get_drag(){} // RVA: 0x7D37370
        public void set_drag(){} // RVA: 0x7D3BA70
        public void get_angularDrag(){} // RVA: 0x7D374C0
        public void set_angularDrag(){} // RVA: 0x7D3BA80
        public void get_velocity(){} // RVA: 0x7D3BA90
        public void set_velocity(){} // RVA: 0x7D3BB60
        public void get_sleepVelocity(){} // RVA: 0x7BAE850
        public void set_sleepVelocity(){} // RVA: 0xB43310
        public void get_sleepAngularVelocity(){} // RVA: 0x7BAE850
        public void set_sleepAngularVelocity(){} // RVA: 0xB43310
        public void SetMaxAngularVelocity(){} // RVA: 0x7D3BC10
        public void get_useConeFriction(){} // RVA: 0x263B110
        public void set_useConeFriction(){} // RVA: 0xB43310
        public void get_solverIterationCount(){} // RVA: 0x7D38D90
        public void set_solverIterationCount(){} // RVA: 0x7D3BC20
        public void get_solverVelocityIterationCount(){} // RVA: 0x7D399B0
        public void set_solverVelocityIterationCount(){} // RVA: 0x7D3BC30
        public void .ctor(){} // RVA: 0xB43D60
        public void get_linearVelocity_Injected(){} // RVA: 0x7D3BC40
        public void set_linearVelocity_Injected(){} // RVA: 0x7D3BCA0
        public void get_angularVelocity_Injected(){} // RVA: 0x7D3BD00
        public void set_angularVelocity_Injected(){} // RVA: 0x7D3BD60
        public void get_linearDamping_Injected(){} // RVA: 0x7D3BDC0
        public void set_linearDamping_Injected(){} // RVA: 0x7D3BE10
        public void get_angularDamping_Injected(){} // RVA: 0x7D3BE70
        public void set_angularDamping_Injected(){} // RVA: 0x7D3BEC0
        public void get_mass_Injected(){} // RVA: 0x7D3BF20
        public void set_mass_Injected(){} // RVA: 0x7D3BF70
        public void SetDensity_Injected(){} // RVA: 0x7D3BFD0
        public void get_useGravity_Injected(){} // RVA: 0x7D3C030
        public void set_useGravity_Injected(){} // RVA: 0x7D3C080
        public void get_maxDepenetrationVelocity_Injected(){} // RVA: 0x7D3C0E0
        public void set_maxDepenetrationVelocity_Injected(){} // RVA: 0x7D3C130
        public void get_isKinematic_Injected(){} // RVA: 0x7D3C190
        public void set_isKinematic_Injected(){} // RVA: 0x7D3C1E0
        public void get_constraints_Injected(){} // RVA: 0x7D3C240
        public void set_constraints_Injected(){} // RVA: 0x7D3C290
        public void get_collisionDetectionMode_Injected(){} // RVA: 0x7D3C2F0
        public void set_collisionDetectionMode_Injected(){} // RVA: 0x7D3C340
        public void get_automaticCenterOfMass_Injected(){} // RVA: 0x7D3C3A0
        public void set_automaticCenterOfMass_Injected(){} // RVA: 0x7D3C3F0
        public void get_centerOfMass_Injected(){} // RVA: 0x7D3C450
        public void set_centerOfMass_Injected(){} // RVA: 0x7D3C4B0
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x7D3C510
        public void get_automaticInertiaTensor_Injected(){} // RVA: 0x7D3C570
        public void set_automaticInertiaTensor_Injected(){} // RVA: 0x7D3C5C0
        public void get_inertiaTensorRotation_Injected(){} // RVA: 0x7D3C620
        public void set_inertiaTensorRotation_Injected(){} // RVA: 0x7D3C680
        public void get_inertiaTensor_Injected(){} // RVA: 0x7D3C6E0
        public void set_inertiaTensor_Injected(){} // RVA: 0x7D3C740
        public void get_worldInertiaTensorMatrix_Injected(){} // RVA: 0x7D3C7A0
        public void get_detectCollisions_Injected(){} // RVA: 0x7D3C800
        public void set_detectCollisions_Injected(){} // RVA: 0x7D3C850
        public void get_position_Injected(){} // RVA: 0x7D3C8B0
        public void set_position_Injected(){} // RVA: 0x7D3C910
        public void get_rotation_Injected(){} // RVA: 0x7D3C970
        public void set_rotation_Injected(){} // RVA: 0x7D3C9D0
        public void get_interpolation_Injected(){} // RVA: 0x7D3CA30
        public void set_interpolation_Injected(){} // RVA: 0x7D3CA80
        public void get_solverIterations_Injected(){} // RVA: 0x7D3CAE0
        public void set_solverIterations_Injected(){} // RVA: 0x7D3CB30
        public void get_sleepThreshold_Injected(){} // RVA: 0x7D3CB90
        public void set_sleepThreshold_Injected(){} // RVA: 0x7D3CBE0
        public void get_maxAngularVelocity_Injected(){} // RVA: 0x7D3CC40
        public void set_maxAngularVelocity_Injected(){} // RVA: 0x7D3CC90
        public void get_maxLinearVelocity_Injected(){} // RVA: 0x7D3CCF0
        public void set_maxLinearVelocity_Injected(){} // RVA: 0x7D3CD40
        public void MovePosition_Injected(){} // RVA: 0x7D3CDA0
        public void MoveRotation_Injected(){} // RVA: 0x7D3CE00
        public void Move_Injected(){} // RVA: 0x7D3CE60
        public void Sleep_Injected(){} // RVA: 0x7D3CED0
        public void IsSleeping_Injected(){} // RVA: 0x7D3CF20
        public void WakeUp_Injected(){} // RVA: 0x7D3CF70
        public void ResetCenterOfMass_Injected(){} // RVA: 0x7D3CFC0
        public void ResetInertiaTensor_Injected(){} // RVA: 0x7D3D010
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x7D3D060
        public void GetPointVelocity_Injected(){} // RVA: 0x7D3D0D0
        public void get_solverVelocityIterations_Injected(){} // RVA: 0x7D3D140
        public void set_solverVelocityIterations_Injected(){} // RVA: 0x7D3D190
        public void PublishTransform_Injected(){} // RVA: 0x7D3D1F0
        public void get_excludeLayers_Injected(){} // RVA: 0x7D3D240
        public void set_excludeLayers_Injected(){} // RVA: 0x7D3D2A0
        public void get_includeLayers_Injected(){} // RVA: 0x7D3D300
        public void set_includeLayers_Injected(){} // RVA: 0x7D3D360
        public void GetAccumulatedForce_Injected(){} // RVA: 0x7D3D3C0
        public void GetAccumulatedTorque_Injected(){} // RVA: 0x7D3D430
        public void AddForce_Injected(){} // RVA: 0x7D3D4A0
        public void AddRelativeForce_Injected(){} // RVA: 0x7D3D510
        public void AddTorque_Injected(){} // RVA: 0x7D3D580
        public void AddRelativeTorque_Injected(){} // RVA: 0x7D3D5F0
        public void AddForceAtPosition_Injected(){} // RVA: 0x7D3D660
        public void AddExplosionForce_Injected(){} // RVA: 0x7D3D6E0
        public void Internal_ClosestPointOnBounds_Injected(){} // RVA: 0x7D3D770
        public void SweepTest_Injected(){} // RVA: 0x7D3D7F0
        public void Internal_SweepTestAll_Injected(){} // RVA: 0x7D3D880
    }

    public class Rigidbody2D : Component
    {
        // ── Methods ──
        public void get_position(){} // RVA: 0x7CF5D00
        public void set_position(){} // RVA: 0x7CF5DB0
        public void get_rotation(){} // RVA: 0x7CF5E60
        public void set_rotation(){} // RVA: 0x7CF5F00
        public void SetRotation(){} // RVA: 0x7CF6060
        public void SetRotation_Angle(){} // RVA: 0x7CF5FB0
        public void SetRotation_Quaternion(){} // RVA: 0x7CF6110
        public void MovePosition(){} // RVA: 0x7CF61C0
        public void MoveRotation(){} // RVA: 0x7CF6320
        public void MoveRotation_Angle(){} // RVA: 0x7CF6270
        public void MoveRotation_Quaternion(){} // RVA: 0x7CF63D0
        public void MovePositionAndRotation(){} // RVA: 0x7CF6540
        public void MovePositionAndRotation_Quaternion(){} // RVA: 0x7CF6600
        public void Slide(){} // RVA: 0x7CF66C0
        public void Slide_Internal(){} // RVA: 0x7CF7150
        public void get_linearVelocity(){} // RVA: 0x7CF7240
        public void set_linearVelocity(){} // RVA: 0x7CF72F0
        public void get_linearVelocityX(){} // RVA: 0x7CF73A0
        public void set_linearVelocityX(){} // RVA: 0x7CF7440
        public void get_linearVelocityY(){} // RVA: 0x7CF74F0
        public void set_linearVelocityY(){} // RVA: 0x7CF7590
        public void get_angularVelocity(){} // RVA: 0x7CF7640
        public void set_angularVelocity(){} // RVA: 0x7CF76E0
        public void get_useAutoMass(){} // RVA: 0x7CF7790
        public void set_useAutoMass(){} // RVA: 0x7CF7830
        public void get_mass(){} // RVA: 0x7CF78E0
        public void set_mass(){} // RVA: 0x7CF7980
        public void get_sharedMaterial(){} // RVA: 0x7CF7A30
        public void set_sharedMaterial(){} // RVA: 0x7CF7AF0
        public void get_centerOfMass(){} // RVA: 0x7CF7BD0
        public void set_centerOfMass(){} // RVA: 0x7CF7C80
        public void get_worldCenterOfMass(){} // RVA: 0x7CF7D30
        public void get_inertia(){} // RVA: 0x7CF7DE0
        public void set_inertia(){} // RVA: 0x7CF7E80
        public void get_linearDamping(){} // RVA: 0x7CF7F30
        public void set_linearDamping(){} // RVA: 0x7CF7FD0
        public void get_angularDamping(){} // RVA: 0x7CF8080
        public void set_angularDamping(){} // RVA: 0x7CF8120
        public void get_gravityScale(){} // RVA: 0x7CF81D0
        public void set_gravityScale(){} // RVA: 0x7CF8270
        public void get_bodyType(){} // RVA: 0x7CF8320
        public void set_bodyType(){} // RVA: 0x7CF83C0
        public void get_useFullKinematicContacts(){} // RVA: 0x7CF8470
        public void set_useFullKinematicContacts(){} // RVA: 0x7CF8510
        public void get_freezeRotation(){} // RVA: 0x7CF85C0
        public void set_freezeRotation(){} // RVA: 0x7CF8660
        public void get_constraints(){} // RVA: 0x7CF8710
        public void set_constraints(){} // RVA: 0x7CF87B0
        public void IsSleeping(){} // RVA: 0x7CF8860
        public void IsAwake(){} // RVA: 0x7CF8900
        public void Sleep(){} // RVA: 0x7CF89A0
        public void WakeUp(){} // RVA: 0x7CF8A40
        public void get_simulated(){} // RVA: 0x7CF8AE0
        public void set_simulated(){} // RVA: 0x7CF8B80
        public void get_interpolation(){} // RVA: 0x7CF8C30
        public void set_interpolation(){} // RVA: 0x7CF8CD0
        public void get_sleepMode(){} // RVA: 0x7CF8D80
        public void set_sleepMode(){} // RVA: 0x7CF8E20
        public void get_collisionDetectionMode(){} // RVA: 0x7CF8ED0
        public void set_collisionDetectionMode(){} // RVA: 0x7CF8F70
        public void get_attachedColliderCount(){} // RVA: 0x7CF9020
        public void GetAttachedColliderCount_Internal(){} // RVA: 0x7CF90C0
        public void get_totalForce(){} // RVA: 0x7CF9170
        public void set_totalForce(){} // RVA: 0x7CF9220
        public void get_totalTorque(){} // RVA: 0x7CF92D0
        public void set_totalTorque(){} // RVA: 0x7CF9370
        public void get_excludeLayers(){} // RVA: 0x7CF9420
        public void set_excludeLayers(){} // RVA: 0x7CF94D0
        public void get_includeLayers(){} // RVA: 0x7CF9580
        public void set_includeLayers(){} // RVA: 0x7CF9630
        public void get_localToWorldMatrix(){} // RVA: 0x7CF96E0
        public void IsTouching(){} // RVA: 0x7CF9B00
        public void IsTouching_OtherColliderWithFilter_Internal(){} // RVA: 0x7CF99E0
        public void IsTouching_AnyColliderWithFilter_Internal(){} // RVA: 0x7CF9BC0
        public void IsTouchingLayers(){} // RVA: 0x7CF9C80
        public void OverlapPoint(){} // RVA: 0x7CF9DE0
        public void Distance(){} // RVA: 0x7CFA200
        public void Distance_Internal(){} // RVA: 0x7CFA4D0
        public void DistanceFrom_Internal(){} // RVA: 0x7CFA600
        public void ClosestPoint(){} // RVA: 0x7CFA760
        public void AddForce(){} // RVA: 0x7CFA7E0
        public void AddForceX(){} // RVA: 0x7CFA7F0
        public void AddForceY(){} // RVA: 0x7CFA810
        public void AddForce_Internal(){} // RVA: 0x7CFA830
        public void AddRelativeForce(){} // RVA: 0x7CFA900
        public void AddRelativeForceX(){} // RVA: 0x7CFA910
        public void AddRelativeForceY(){} // RVA: 0x7CFA930
        public void AddRelativeForce_Internal(){} // RVA: 0x7CFA950
        public void AddForceAtPosition(){} // RVA: 0x7CFAA30
        public void AddTorque(){} // RVA: 0x7CFAB00
        public void GetPoint(){} // RVA: 0x7CFABC0
        public void GetRelativePoint(){} // RVA: 0x7CFAC80
        public void GetVector(){} // RVA: 0x7CFAD40
        public void GetRelativeVector(){} // RVA: 0x7CFAE00
        public void GetPointVelocity(){} // RVA: 0x7CFAEC0
        public void GetRelativePointVelocity(){} // RVA: 0x7CFAF80
        public void GetContacts(){} // RVA: 0x7CFB5F0
        public void GetAttachedColliders(){} // RVA: 0x7CFB930
        public void GetShapes(){} // RVA: 0x7CFBA20
        public void Cast(){} // RVA: 0x7CFBC90
        public void Overlap(){} // RVA: 0x7CFC0C0
        public void GetAttachedCollidersArray_Internal(){} // RVA: 0x7CFB840
        public void GetAttachedCollidersList_Internal(){} // RVA: 0x7CFB930
        public void GetShapes_Internal(){} // RVA: 0x7CFC1E0
        public void CastArray_Internal(){} // RVA: 0x7CFC290
        public void CastList_Internal(){} // RVA: 0x7CFC3F0
        public void CastFilteredArray_Internal(){} // RVA: 0x7CFC640
        public void CastFilteredList_Internal(){} // RVA: 0x7CFC7B0
        public void CastFrom_Internal(){} // RVA: 0x7CFCA10
        public void CastFromFiltered_Internal(){} // RVA: 0x7CFCC80
        public void OverlapArray_Internal(){} // RVA: 0x7CFCEF0
        public void OverlapList_Internal(){} // RVA: 0x7CFBE00
        public void OverlapFilteredList_Internal(){} // RVA: 0x7CFCFE0
        public void OverlapFromList_Internal(){} // RVA: 0x7CFD0D0
        public void OverlapFromFilteredList_Internal(){} // RVA: 0x7CFD1C0
        public void get_isKinematic(){} // RVA: 0x7CFD2D0
        public void set_isKinematic(){} // RVA: 0x7CFD370
        public void .ctor(){} // RVA: 0xB43D60
        public void get_position_Injected(){} // RVA: 0x7CFD390
        public void set_position_Injected(){} // RVA: 0x7CFD3F0
        public void get_rotation_Injected(){} // RVA: 0x7CFD450
        public void set_rotation_Injected(){} // RVA: 0x7CFD4A0
        public void SetRotation_Angle_Injected(){} // RVA: 0x7CFD500
        public void SetRotation_Quaternion_Injected(){} // RVA: 0x7CFD560
        public void MovePosition_Injected(){} // RVA: 0x7CFD5C0
        public void MoveRotation_Angle_Injected(){} // RVA: 0x7CFD620
        public void MoveRotation_Quaternion_Injected(){} // RVA: 0x7CFD680
        public void MovePositionAndRotation_Injected(){} // RVA: 0x7CFD6E0
        public void MovePositionAndRotation_Quaternion_Injected(){} // RVA: 0x7CFD750
        public void Slide_Internal_Injected(){} // RVA: 0x7CFD7C0
        public void get_linearVelocity_Injected(){} // RVA: 0x7CFD850
        public void set_linearVelocity_Injected(){} // RVA: 0x7CFD8B0
        public void get_linearVelocityX_Injected(){} // RVA: 0x7CFD910
        public void set_linearVelocityX_Injected(){} // RVA: 0x7CFD960
        public void get_linearVelocityY_Injected(){} // RVA: 0x7CFD9C0
        public void set_linearVelocityY_Injected(){} // RVA: 0x7CFDA10
        public void get_angularVelocity_Injected(){} // RVA: 0x7CFDA70
        public void set_angularVelocity_Injected(){} // RVA: 0x7CFDAC0
        public void get_useAutoMass_Injected(){} // RVA: 0x7CFDB20
        public void set_useAutoMass_Injected(){} // RVA: 0x7CFDB70
        public void get_mass_Injected(){} // RVA: 0x7CFDBD0
        public void set_mass_Injected(){} // RVA: 0x7CFDC20
        public void get_sharedMaterial_Injected(){} // RVA: 0x7CFDC80
        public void set_sharedMaterial_Injected(){} // RVA: 0x7CFDCD0
        public void get_centerOfMass_Injected(){} // RVA: 0x7CFDD30
        public void set_centerOfMass_Injected(){} // RVA: 0x7CFDD90
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x7CFDDF0
        public void get_inertia_Injected(){} // RVA: 0x7CFDE50
        public void set_inertia_Injected(){} // RVA: 0x7CFDEA0
        public void get_linearDamping_Injected(){} // RVA: 0x7CFDF00
        public void set_linearDamping_Injected(){} // RVA: 0x7CFDF50
        public void get_angularDamping_Injected(){} // RVA: 0x7CFDFB0
        public void set_angularDamping_Injected(){} // RVA: 0x7CFE000
        public void get_gravityScale_Injected(){} // RVA: 0x7CFE060
        public void set_gravityScale_Injected(){} // RVA: 0x7CFE0B0
        public void get_bodyType_Injected(){} // RVA: 0x7CFE110
        public void set_bodyType_Injected(){} // RVA: 0x7CFE160
        public void get_useFullKinematicContacts_Injected(){} // RVA: 0x7CFE1C0
        public void set_useFullKinematicContacts_Injected(){} // RVA: 0x7CFE210
        public void get_freezeRotation_Injected(){} // RVA: 0x7CFE270
        public void set_freezeRotation_Injected(){} // RVA: 0x7CFE2C0
        public void get_constraints_Injected(){} // RVA: 0x7CFE320
        public void set_constraints_Injected(){} // RVA: 0x7CFE370
        public void IsSleeping_Injected(){} // RVA: 0x7CFE3D0
        public void IsAwake_Injected(){} // RVA: 0x7CFE420
        public void Sleep_Injected(){} // RVA: 0x7CFE470
        public void WakeUp_Injected(){} // RVA: 0x7CFE4C0
        public void get_simulated_Injected(){} // RVA: 0x7CFE510
        public void set_simulated_Injected(){} // RVA: 0x7CFE560
        public void get_interpolation_Injected(){} // RVA: 0x7CFE5C0
        public void set_interpolation_Injected(){} // RVA: 0x7CFE610
        public void get_sleepMode_Injected(){} // RVA: 0x7CFE670
        public void set_sleepMode_Injected(){} // RVA: 0x7CFE6C0
        public void get_collisionDetectionMode_Injected(){} // RVA: 0x7CFE720
        public void set_collisionDetectionMode_Injected(){} // RVA: 0x7CFE770
        public void GetAttachedColliderCount_Internal_Injected(){} // RVA: 0x7CFE7D0
        public void get_totalForce_Injected(){} // RVA: 0x7CFE830
        public void set_totalForce_Injected(){} // RVA: 0x7CFE890
        public void get_totalTorque_Injected(){} // RVA: 0x7CFE8F0
        public void set_totalTorque_Injected(){} // RVA: 0x7CFE940
        public void get_excludeLayers_Injected(){} // RVA: 0x7CFE9A0
        public void set_excludeLayers_Injected(){} // RVA: 0x7CFEA00
        public void get_includeLayers_Injected(){} // RVA: 0x7CFEA60
        public void set_includeLayers_Injected(){} // RVA: 0x7CFEAC0
        public void get_localToWorldMatrix_Injected(){} // RVA: 0x7CFEB20
        public void IsTouching_Injected(){} // RVA: 0x7CFEB80
        public void IsTouching_OtherColliderWithFilter_Internal_Injected(){} // RVA: 0x7CFEBE0
        public void IsTouching_AnyColliderWithFilter_Internal_Injected(){} // RVA: 0x7CFEC50
        public void OverlapPoint_Injected(){} // RVA: 0x7CFECB0
        public void Distance_Internal_Injected(){} // RVA: 0x7CFED10
        public void DistanceFrom_Internal_Injected(){} // RVA: 0x7CFED80
        public void AddForce_Internal_Injected(){} // RVA: 0x7CFEE10
        public void AddRelativeForce_Internal_Injected(){} // RVA: 0x7CFEE80
        public void AddForceAtPosition_Injected(){} // RVA: 0x7CFEEF0
        public void AddTorque_Injected(){} // RVA: 0x7CFEF70
        public void GetPoint_Injected(){} // RVA: 0x7CFEFE0
        public void GetRelativePoint_Injected(){} // RVA: 0x7CFF050
        public void GetVector_Injected(){} // RVA: 0x7CFF0C0
        public void GetRelativeVector_Injected(){} // RVA: 0x7CFF130
        public void GetPointVelocity_Injected(){} // RVA: 0x7CFF1A0
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x7CFF210
        public void GetAttachedCollidersArray_Internal_Injected(){} // RVA: 0x7CFF280
        public void GetAttachedCollidersList_Internal_Injected(){} // RVA: 0x7CFF2F0
        public void GetShapes_Internal_Injected(){} // RVA: 0x7CFF360
        public void CastArray_Internal_Injected(){} // RVA: 0x7CFF3C0
        public void CastList_Internal_Injected(){} // RVA: 0x7CFF450
        public void CastFilteredArray_Internal_Injected(){} // RVA: 0x7CFF4E0
        public void CastFilteredList_Internal_Injected(){} // RVA: 0x7CFF570
        public void CastFrom_Internal_Injected(){} // RVA: 0x7CFF600
        public void CastFromFiltered_Internal_Injected(){} // RVA: 0x7CFF690
        public void OverlapArray_Internal_Injected(){} // RVA: 0x7CFF720
        public void OverlapList_Internal_Injected(){} // RVA: 0x7CFF790
        public void OverlapFilteredList_Internal_Injected(){} // RVA: 0x7CFF7F0
        public void OverlapFromList_Internal_Injected(){} // RVA: 0x7CFF860
        public void OverlapFromFilteredList_Internal_Injected(){} // RVA: 0x7CFF8E0
    }

    public class Rigidbody2D[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Rigidbody[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RuntimeAnimatorController : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B18410
        public void get_animationClips(){} // RVA: 0x7B18460
        public void get_animationClips_Injected(){} // RVA: 0x7B18500
    }

    public class RuntimeAnimatorController[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
    {
        public object m_LoadType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void set_loadType(){} // RVA: 0xB460A0
    }

    public class RuntimeInitializeOnLoadMethodAttribute[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RuntimeTextSettings : TextSettings
    {
        public object s_DefaultTextSettings;
        public object s_FallbackOSFontAssetIMGUIInternal;

        // ── Methods ──
        public void get_defaultTextSettings(){} // RVA: 0x7C91770
        public void GetStaticFallbackOSFontAsset(){} // RVA: 0x7C918E0
        public void SetStaticFallbackOSFontAsset(){} // RVA: 0x7C91920
        public void .ctor(){} // RVA: 0x7C919C0
    }

}