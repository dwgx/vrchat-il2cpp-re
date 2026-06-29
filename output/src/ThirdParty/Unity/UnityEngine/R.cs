// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 53
// Methods: 1207

namespace ThirdParty.Unity.UnityEngine
{
    public class Random : Object
    {
        // ── Methods ──
        public void InitState(){} // RVA: 0x7AEEFE940
        public void Range(){} // RVA: 0x7AEEFEA00
        public void RandomRangeInt(){} // RVA: 0x7AEEFEA00
        public void get_value(){} // RVA: 0x7A94E0BD0
        public void get_insideUnitSphere(){} // RVA: 0x7AEEFEA60
        public void GetRandomUnitCircle(){} // RVA: 0x7AEEFEAC0
        public void get_insideUnitCircle(){} // RVA: 0x7AEEFEB10
        public void get_onUnitSphere(){} // RVA: 0x7AEEFEB70
        public void get_rotation(){} // RVA: 0x7AEEFEBD0
        public void get_rotationUniform(){} // RVA: 0x7AEEFEC30
        public void ColorHSV(){} // RVA: 0x7AEEFEE30
        public void get_insideUnitSphere_Injected(){} // RVA: 0x7AEEFF0A0
        public void get_onUnitSphere_Injected(){} // RVA: 0x7AEEFF0F0
        public void get_rotation_Injected(){} // RVA: 0x7AEEFF140
        public void get_rotationUniform_Injected(){} // RVA: 0x7AEEFF190
    }

    public class RangeAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8E597B0
    }

    public class RangeInt : ValueType
    {
        // ── Methods ──
        public void get_end(){} // RVA: 0x7A7EDF960
        public void .ctor(){} // RVA: 0x7A7615330
    }

    public class RangeInt[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A0FB0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2A50
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2501E0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Ray : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7EDB7C0
        public void get_origin(){} // RVA: 0x7A79F03C0
        public void set_origin(){} // RVA: 0x7A79F03B0
        public void get_direction(){} // RVA: 0x7A7ED3A50
        public void set_direction(){} // RVA: 0x7A7EDB890
        public void GetPoint(){} // RVA: 0x7A7EDB950
        public void ToString(){} // RVA: 0x7A7EDB9C0
    }

    public class RaycastCommand : ValueType
    {
        // ── Methods ──
        public void set_from(){} // RVA: 0x7A79F03B0
        public void set_direction(){} // RVA: 0x7A7ED3A70
        public void set_physicsScene(){} // RVA: 0x7A768A440
        public void set_distance(){} // RVA: 0x7A76870E0
        public void ScheduleBatch(){} // RVA: 0x7AEFEADC0
        public void ScheduleRaycastBatch(){} // RVA: 0x7AEFEAFF0
        public void ScheduleRaycastBatch_Injected(){} // RVA: 0x7AEFEB0A0
    }

    public class RaycastHit : ValueType
    {
        // ── Methods ──
        public void get_collider(){} // RVA: 0x7A7EF5060
        public void get_colliderInstanceID(){} // RVA: 0x7A7AD20B0
        public void get_point(){} // RVA: 0x7A79F03C0
        public void set_point(){} // RVA: 0x7A79F03B0
        public void get_normal(){} // RVA: 0x7A7ED3A50
        public void set_normal(){} // RVA: 0x7A7ED3A70
        public void get_barycentricCoordinate(){} // RVA: 0x7A7EF5070
        public void set_barycentricCoordinate(){} // RVA: 0x7A7EF50A0
        public void get_distance(){} // RVA: 0x7A7ED43C0
        public void set_distance(){} // RVA: 0x7A76870E0
        public void get_triangleIndex(){} // RVA: 0x7A7AD1FC0
        public void CalculateRaycastTexCoord(){} // RVA: 0x7AEFDBAA0
        public void get_textureCoord(){} // RVA: 0x7A7EF50C0
        public void get_textureCoord2(){} // RVA: 0x7A7EF50D0
        public void get_transform(){} // RVA: 0x7A7EF50E0
        public void get_rigidbody(){} // RVA: 0x7A7EF50F0
        public void get_articulationBody(){} // RVA: 0x7A7EF5100
        public void get_lightmapCoord(){} // RVA: 0x7A7EF5110
        public void CalculateRaycastTexCoord_Injected(){} // RVA: 0x7AEFDC3C0
    }

    public class RaycastHit2D : ValueType
    {
        // ── Methods ──
        public void get_centroid(){} // RVA: 0x7A7EDBA10
        public void set_centroid(){} // RVA: 0x7A767FEF0
        public void get_point(){} // RVA: 0x7A7EDBB80
        public void set_point(){} // RVA: 0x7A76850C0
        public void get_normal(){} // RVA: 0x7A7EF4750
        public void set_normal(){} // RVA: 0x7A76C7400
        public void get_distance(){} // RVA: 0x7A7ED3A80
        public void set_distance(){} // RVA: 0x7A7687100
        public void get_fraction(){} // RVA: 0x7A7ED43C0
        public void set_fraction(){} // RVA: 0x7A76870E0
        public void get_collider(){} // RVA: 0x7A7EF4F80
        public void get_rigidbody(){} // RVA: 0x7A7EF4F90
        public void get_transform(){} // RVA: 0x7A7EF4FA0
        public void op_Implicit(){} // RVA: 0x7AEFC1080
        public void CompareTo(){} // RVA: 0x7A7EF4FB0
    }

    public class RaycastHit2D[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A25C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E540
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E36F0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA25C570
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E540
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class RaycastHit[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D20A0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29FC30
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6840
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA280640
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29FC30
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Rect : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7EC0C40
        public void get_zero(){} // RVA: 0x7AEEACB60
        public void MinMaxRect(){} // RVA: 0x7AEEACB70
        public void Set(){} // RVA: 0x7A75F5650
        public void get_x(){} // RVA: 0x7A79EF510
        public void set_x(){} // RVA: 0x7A76B8920
        public void get_y(){} // RVA: 0x7A7ED4380
        public void set_y(){} // RVA: 0x7A76B8940
        public void get_position(){} // RVA: 0x7A7EDBA10
        public void set_position(){} // RVA: 0x7A7EDBA30
        public void get_center(){} // RVA: 0x7A7EDBA50
        public void set_center(){} // RVA: 0x7A7EDBA80
        public void get_min(){} // RVA: 0x7A7EDBAC0
        public void set_min(){} // RVA: 0x7A7EDBAE0
        public void get_max(){} // RVA: 0x7A7EDBB30
        public void set_max(){} // RVA: 0x7A7EDBB50
        public void get_width(){} // RVA: 0x7A7ED4390
        public void set_width(){} // RVA: 0x7A76B8930
        public void get_height(){} // RVA: 0x7A7ED43A0
        public void set_height(){} // RVA: 0x7A76B8970
        public void get_size(){} // RVA: 0x7A7EDBB80
        public void set_size(){} // RVA: 0x7A7EDBBA0
        public void get_xMin(){} // RVA: 0x7A79EF510
        public void set_xMin(){} // RVA: 0x7A7EDBBC0
        public void get_yMin(){} // RVA: 0x7A7ED4380
        public void set_yMin(){} // RVA: 0x7A7EDBBE0
        public void get_xMax(){} // RVA: 0x7A7EDBC00
        public void set_xMax(){} // RVA: 0x7A7EDBC10
        public void get_yMax(){} // RVA: 0x7A7EDBC20
        public void set_yMax(){} // RVA: 0x7A7EDBC30
        public void Contains(){} // RVA: 0x7A7EDBCD0
        public void OrderMinMax(){} // RVA: 0x7AEEACF70
        public void Overlaps(){} // RVA: 0x7A7EDBD60
        public void NormalizedToPoint(){} // RVA: 0x7AEEAD190
        public void PointToNormalized(){} // RVA: 0x7AEEAD210
        public void op_Inequality(){} // RVA: 0x7AEEAD2B0
        public void op_Equality(){} // RVA: 0x7AEEAD300
        public void GetHashCode(){} // RVA: 0x7A7EDBD80
        public void Equals(){} // RVA: 0x7A7EDBDA0
        public void ToString(){} // RVA: 0x7A7EDBE00
    }

    public class RectInt : ValueType
    {
        // ── Methods ──
        public void get_x(){} // RVA: 0x7A79EAED0
        public void set_x(){} // RVA: 0x7A76134D0
        public void get_y(){} // RVA: 0x7A7A39F60
        public void set_y(){} // RVA: 0x7A765F090
        public void get_width(){} // RVA: 0x7A79D4850
        public void set_width(){} // RVA: 0x7A767FBC0
        public void get_height(){} // RVA: 0x7A79DED90
        public void set_height(){} // RVA: 0x7A767FBE0
        public void get_xMin(){} // RVA: 0x7A7EDBE10
        public void get_yMin(){} // RVA: 0x7A7EDBE20
        public void get_xMax(){} // RVA: 0x7A7EDBE30
        public void get_yMax(){} // RVA: 0x7A7EDBE40
        public void .ctor(){} // RVA: 0x7A7E2BDA0
        public void Overlaps(){} // RVA: 0x7A7EDBE50
        public void ToString(){} // RVA: 0x7A7EDC000
        public void Equals(){} // RVA: 0x7A7EDC010
    }

    public class RectInt[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class RectOffset : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEEAE040
        public void Finalize(){} // RVA: 0x7AEEADFA0
        public void ToString(){} // RVA: 0x7AEEAE1F0
        public void Destroy(){} // RVA: 0x7AEEAE750
        public void InternalCreate(){} // RVA: 0x7AEEAE7C0
        public void InternalDestroy(){} // RVA: 0x7AEEAE810
        public void get_left(){} // RVA: 0x7AEEAE860
        public void set_left(){} // RVA: 0x7AEEAE8B0
        public void get_right(){} // RVA: 0x7AEEAE910
        public void set_right(){} // RVA: 0x7AEEAE960
        public void get_top(){} // RVA: 0x7AEEAE9C0
        public void set_top(){} // RVA: 0x7AEEAEA10
        public void get_bottom(){} // RVA: 0x7AEEAEA70
        public void set_bottom(){} // RVA: 0x7AEEAEAC0
        public void get_horizontal(){} // RVA: 0x7AEEAEB20
        public void get_vertical(){} // RVA: 0x7AEEAEB70
        public void Remove(){} // RVA: 0x7AEEAEBC0
        public void Remove_Injected(){} // RVA: 0x7AEEAEC40
    }

    public class RectOffset[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class RectTransform : Transform
    {
        // ── Methods ──
        public void add_reapplyDrivenProperties(){} // RVA: 0x7AEF14D60
        public void remove_reapplyDrivenProperties(){} // RVA: 0x7AEF14E70
        public void get_rect(){} // RVA: 0x7AEF14F80
        public void get_anchorMin(){} // RVA: 0x7AEF14FF0
        public void set_anchorMin(){} // RVA: 0x7AEF15050
        public void get_anchorMax(){} // RVA: 0x7AEF150B0
        public void set_anchorMax(){} // RVA: 0x7AEF15110
        public void get_anchoredPosition(){} // RVA: 0x7AEF15170
        public void set_anchoredPosition(){} // RVA: 0x7AEF151D0
        public void get_sizeDelta(){} // RVA: 0x7AEF15230
        public void set_sizeDelta(){} // RVA: 0x7AEF15290
        public void get_pivot(){} // RVA: 0x7AEF152F0
        public void set_pivot(){} // RVA: 0x7AEF15350
        public void get_anchoredPosition3D(){} // RVA: 0x7AEF153B0
        public void set_anchoredPosition3D(){} // RVA: 0x7AEF15490
        public void get_offsetMin(){} // RVA: 0x7AEF155C0
        public void set_offsetMin(){} // RVA: 0x7AEF156F0
        public void get_offsetMax(){} // RVA: 0x7AEF15A60
        public void set_offsetMax(){} // RVA: 0x7AEF15BE0
        public void get_drivenByObject(){} // RVA: 0x7AEF15F40
        public void set_drivenByObject(){} // RVA: 0x7AEF15F90
        public void get_drivenProperties(){} // RVA: 0x7AEF15FF0
        public void set_drivenProperties(){} // RVA: 0x7AEF16040
        public void ForceUpdateRectTransforms(){} // RVA: 0x7AEF160A0
        public void GetLocalCorners(){} // RVA: 0x7AEF160F0
        public void GetWorldCorners(){} // RVA: 0x7AEF16260
        public void SetInsetAndSizeFromParentEdge(){} // RVA: 0x7AEF165C0
        public void SetSizeWithCurrentAnchors(){} // RVA: 0x7AEF16B10
        public void SendReapplyDrivenProperties(){} // RVA: 0x7AEF16E70
        public void GetRectInParentSpace(){} // RVA: 0x7AEF16ED0
        public void GetParentSize(){} // RVA: 0x7AEF17370
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_rect_Injected(){} // RVA: 0x7AEF17550
        public void get_anchorMin_Injected(){} // RVA: 0x7AEF175B0
        public void set_anchorMin_Injected(){} // RVA: 0x7AEF17610
        public void get_anchorMax_Injected(){} // RVA: 0x7AEF17670
        public void set_anchorMax_Injected(){} // RVA: 0x7AEF176D0
        public void get_anchoredPosition_Injected(){} // RVA: 0x7AEF17730
        public void set_anchoredPosition_Injected(){} // RVA: 0x7AEF17790
        public void get_sizeDelta_Injected(){} // RVA: 0x7AEF177F0
        public void set_sizeDelta_Injected(){} // RVA: 0x7AEF17850
        public void get_pivot_Injected(){} // RVA: 0x7AEF178B0
        public void set_pivot_Injected(){} // RVA: 0x7AEF17910
    }

    public class RectTransformUtility : Object
    {
        // ── Methods ──
        public void PixelAdjustPoint(){} // RVA: 0x7AF27DA10
        public void PixelAdjustRect(){} // RVA: 0x7AF27DAC0
        public void PointInRectangle(){} // RVA: 0x7AF27DB70
        public void RectangleContainsScreenPoint(){} // RVA: 0x7AF27DD50
        public void ScreenPointToWorldPointInRectangle(){} // RVA: 0x7AF27DE50
        public void ScreenPointToLocalPointInRectangle(){} // RVA: 0x7AF27E540
        public void ScreenPointToRay(){} // RVA: 0x7AF27E6B0
        public void WorldToScreenPoint(){} // RVA: 0x7AF27E940
        public void FlipLayoutOnAxis(){} // RVA: 0x7AF27EAB0
        public void FlipLayoutAxes(){} // RVA: 0x7AF27F1B0
        public void GetTransposed(){} // RVA: 0x7AF27F7B0
        public void .cctor(){} // RVA: 0x7AF27F7D0
        public void PixelAdjustPoint_Injected(){} // RVA: 0x7AF27F890
        public void PixelAdjustRect_Injected(){} // RVA: 0x7AF27F910
        public void PointInRectangle_Injected(){} // RVA: 0x7AF27F980
    }

    public class RectTransform[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Rect[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D73F0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA284010
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ReflectionProbe : Behaviour
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0x7AEEA30B0
        public void set_type(){} // RVA: 0x7AEEA3100
        public void get_size(){} // RVA: 0x7AEEA3160
        public void set_size(){} // RVA: 0x7AEEA31D0
        public void get_center(){} // RVA: 0x7AEEA3230
        public void set_center(){} // RVA: 0x7AEEA32A0
        public void get_nearClipPlane(){} // RVA: 0x7AEEA3300
        public void set_nearClipPlane(){} // RVA: 0x7AEEA3350
        public void get_farClipPlane(){} // RVA: 0x7AEEA33B0
        public void set_farClipPlane(){} // RVA: 0x7AEEA3400
        public void get_intensity(){} // RVA: 0x7AEEA3460
        public void set_intensity(){} // RVA: 0x7AEEA34B0
        public void get_bounds(){} // RVA: 0x7AEEA3510
        public void get_hdr(){} // RVA: 0x7AEEA3580
        public void set_hdr(){} // RVA: 0x7AEEA35D0
        public void get_renderDynamicObjects(){} // RVA: 0x7AEEA3630
        public void set_renderDynamicObjects(){} // RVA: 0x7AEEA3680
        public void get_shadowDistance(){} // RVA: 0x7AEEA36E0
        public void set_shadowDistance(){} // RVA: 0x7AEEA3730
        public void get_resolution(){} // RVA: 0x7AEEA3790
        public void set_resolution(){} // RVA: 0x7AEEA37E0
        public void get_cullingMask(){} // RVA: 0x7AEEA3840
        public void set_cullingMask(){} // RVA: 0x7AEEA3890
        public void get_clearFlags(){} // RVA: 0x7AEEA38F0
        public void set_clearFlags(){} // RVA: 0x7AEEA3940
        public void get_backgroundColor(){} // RVA: 0x7AEEA39A0
        public void set_backgroundColor(){} // RVA: 0x7AEEA3A10
        public void get_blendDistance(){} // RVA: 0x7AEEA3A70
        public void set_blendDistance(){} // RVA: 0x7AEEA3AC0
        public void get_boxProjection(){} // RVA: 0x7AEEA3B20
        public void set_boxProjection(){} // RVA: 0x7AEEA3B70
        public void get_mode(){} // RVA: 0x7AEEA3BD0
        public void set_mode(){} // RVA: 0x7AEEA3C20
        public void get_importance(){} // RVA: 0x7AEEA3C80
        public void set_importance(){} // RVA: 0x7AEEA3CD0
        public void get_refreshMode(){} // RVA: 0x7AEEA3D30
        public void set_refreshMode(){} // RVA: 0x7AEEA3D80
        public void get_timeSlicingMode(){} // RVA: 0x7AEEA3DE0
        public void set_timeSlicingMode(){} // RVA: 0x7AEEA3E30
        public void get_bakedTexture(){} // RVA: 0x7AEEA3E90
        public void set_bakedTexture(){} // RVA: 0x7AEEA3EE0
        public void get_customBakedTexture(){} // RVA: 0x7AEEA3F40
        public void set_customBakedTexture(){} // RVA: 0x7AEEA3F90
        public void get_realtimeTexture(){} // RVA: 0x7AEEA3FF0
        public void set_realtimeTexture(){} // RVA: 0x7AEEA4040
        public void get_texture(){} // RVA: 0x7AEEA40A0
        public void get_textureHDRDecodeValues(){} // RVA: 0x7AEEA40F0
        public void Reset(){} // RVA: 0x7AEEA4160
        public void RenderProbe(){} // RVA: 0x7AEEA41C0
        public void IsFinishedRendering(){} // RVA: 0x7AEEA4270
        public void ScheduleRender(){} // RVA: 0x7AEEA42D0
        public void BlendCubemap(){} // RVA: 0x7AEEA4340
        public void UpdateCachedState(){} // RVA: 0x7AEEA43C0
        public void get_minBakedCubemapResolution(){} // RVA: 0x7AEEA4410
        public void get_maxBakedCubemapResolution(){} // RVA: 0x7AEEA4460
        public void get_defaultTextureHDRDecodeValues(){} // RVA: 0x7AEEA44B0
        public void get_defaultTexture(){} // RVA: 0x7AEEA4540
        public void add_reflectionProbeChanged(){} // RVA: 0x7AEEA4590
        public void remove_reflectionProbeChanged(){} // RVA: 0x7AEEA46F0
        public void CallReflectionProbeEvent(){} // RVA: 0x7AEEA4850
        public void add_defaultReflectionSet(){} // RVA: 0x7AEEA48D0
        public void remove_defaultReflectionSet(){} // RVA: 0x7AEEA4B20
        public void add_defaultReflectionTexture(){} // RVA: 0x7AEEA4D00
        public void remove_defaultReflectionTexture(){} // RVA: 0x7AEEA4FB0
        public void CallSetDefaultReflection(){} // RVA: 0x7AEEA5040
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void .cctor(){} // RVA: 0x7AEEA51E0
        public void get_size_Injected(){} // RVA: 0x7AEEA5380
        public void set_size_Injected(){} // RVA: 0x7AEEA53E0
        public void get_center_Injected(){} // RVA: 0x7AEEA5440
        public void set_center_Injected(){} // RVA: 0x7AEEA54A0
        public void get_bounds_Injected(){} // RVA: 0x7AEEA5500
        public void get_backgroundColor_Injected(){} // RVA: 0x7AEEA5560
        public void set_backgroundColor_Injected(){} // RVA: 0x7AEEA55C0
        public void get_textureHDRDecodeValues_Injected(){} // RVA: 0x7AEEA5620
        public void get_defaultTextureHDRDecodeValues_Injected(){} // RVA: 0x7AEEA5680
    }

    public class ReflectionProbe[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class RefreshRate : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A7EDC300
        public void Equals(){} // RVA: 0x7A7EDC320
        public void CompareTo(){} // RVA: 0x7A7EDC360
        public void ToString(){} // RVA: 0x7A7EDC3B0
    }

    public class RejectDragAndDropMaterial : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class RelativeJoint2D : Joint2D
    {
        // ── Methods ──
        public void get_maxForce(){} // RVA: 0x7AEFCBCB0
        public void set_maxForce(){} // RVA: 0x7AEFCBD00
        public void get_maxTorque(){} // RVA: 0x7AEFCBD60
        public void set_maxTorque(){} // RVA: 0x7AEFCBDB0
        public void get_correctionScale(){} // RVA: 0x7AEFCBE10
        public void set_correctionScale(){} // RVA: 0x7AEFCBE60
        public void get_autoConfigureOffset(){} // RVA: 0x7AEFCBEC0
        public void set_autoConfigureOffset(){} // RVA: 0x7AEFCBF10
        public void get_linearOffset(){} // RVA: 0x7AEFCBF70
        public void set_linearOffset(){} // RVA: 0x7AEFCBFD0
        public void get_angularOffset(){} // RVA: 0x7AEFCC030
        public void set_angularOffset(){} // RVA: 0x7AEFCC080
        public void get_target(){} // RVA: 0x7AEFCC0E0
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_linearOffset_Injected(){} // RVA: 0x7AEFCC140
        public void set_linearOffset_Injected(){} // RVA: 0x7AEFCC1A0
        public void get_target_Injected(){} // RVA: 0x7AEFCC200
    }

    public class RemoteConfigSettings : Object
    {
        // ── Methods ──
        public void RemoteConfigSettingsUpdated(){} // RVA: 0x7AF2D68A0
    }

    public class RemoteConfigSettings[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class RemoteSettings : Object
    {
        // ── Methods ──
        public void RemoteSettingsUpdated(){} // RVA: 0x7AF2D6760
        public void RemoteSettingsBeforeFetchFromServer(){} // RVA: 0x7AF2D67C0
        public void RemoteSettingsUpdateCompleted(){} // RVA: 0x7AF2D6820
    }

    public class RemoteSettings[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class RenderParams : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7EDC550
        public void set_layer(){} // RVA: 0x7A76134D0
        public void set_renderingLayerMask(){} // RVA: 0x7A765F090
        public void set_rendererPriority(){} // RVA: 0x7A767FBC0
        public void set_worldBounds(){} // RVA: 0x7A7EDC560
        public void set_camera(){} // RVA: 0x7A76779C0
        public void set_motionVectorMode(){} // RVA: 0x7A76AD900
        public void set_reflectionProbeUsage(){} // RVA: 0x7A76B71E0
        public void set_material(){} // RVA: 0x7A760EF00
        public void get_matProps(){} // RVA: 0x7A768E520
        public void set_matProps(){} // RVA: 0x7A764C2F0
        public void set_shadowCastingMode(){} // RVA: 0x7A7690CF0
        public void set_receiveShadows(){} // RVA: 0x7A7690D50
        public void set_lightProbeUsage(){} // RVA: 0x7A7ED4280
        public void set_lightProbeProxyVolume(){} // RVA: 0x7A766E1F0
    }

    public class RenderSettings : Object
    {
        // ── Methods ──
        public void get_fog(){} // RVA: 0x7AEEC5280
        public void set_fog(){} // RVA: 0x7AEEC52D0
        public void get_fogStartDistance(){} // RVA: 0x7AEEC5320
        public void set_fogStartDistance(){} // RVA: 0x7AEEC5370
        public void get_fogEndDistance(){} // RVA: 0x7AEEC53D0
        public void set_fogEndDistance(){} // RVA: 0x7AEEC5420
        public void get_fogMode(){} // RVA: 0x7AEEC5480
        public void set_fogMode(){} // RVA: 0x7AEEC54D0
        public void get_fogColor(){} // RVA: 0x7AEEC5520
        public void set_fogColor(){} // RVA: 0x7AEEC5580
        public void get_fogDensity(){} // RVA: 0x7AEEC55D0
        public void set_fogDensity(){} // RVA: 0x7AEEC5620
        public void get_ambientMode(){} // RVA: 0x7AEEC5680
        public void set_ambientMode(){} // RVA: 0x7AEEC56D0
        public void get_ambientSkyColor(){} // RVA: 0x7AEEC5720
        public void set_ambientSkyColor(){} // RVA: 0x7AEEC5780
        public void get_ambientEquatorColor(){} // RVA: 0x7AEEC57D0
        public void set_ambientEquatorColor(){} // RVA: 0x7AEEC5830
        public void get_ambientGroundColor(){} // RVA: 0x7AEEC5880
        public void set_ambientGroundColor(){} // RVA: 0x7AEEC58E0
        public void get_ambientIntensity(){} // RVA: 0x7AEEC5930
        public void set_ambientIntensity(){} // RVA: 0x7AEEC5980
        public void get_ambientLight(){} // RVA: 0x7AEEC59E0
        public void set_ambientLight(){} // RVA: 0x7AEEC5A40
        public void get_subtractiveShadowColor(){} // RVA: 0x7AEEC5A90
        public void set_subtractiveShadowColor(){} // RVA: 0x7AEEC5AF0
        public void get_skybox(){} // RVA: 0x7AEEC5B40
        public void set_skybox(){} // RVA: 0x7AEEC5B90
        public void get_sun(){} // RVA: 0x7AEEC5BE0
        public void set_sun(){} // RVA: 0x7AEEC5C30
        public void get_ambientProbe(){} // RVA: 0x7AEEC5C80
        public void set_ambientProbe(){} // RVA: 0x7AEEC5D00
        public void get_customReflectionTexture(){} // RVA: 0x7AEEC5D50
        public void set_customReflectionTexture(){} // RVA: 0x7AEEC5DA0
        public void get_reflectionIntensity(){} // RVA: 0x7AEEC5DF0
        public void set_reflectionIntensity(){} // RVA: 0x7AEEC5E40
        public void get_reflectionBounces(){} // RVA: 0x7AEEC5EA0
        public void set_reflectionBounces(){} // RVA: 0x7AEEC5EF0
        public void get_defaultReflectionMode(){} // RVA: 0x7AEEC5F40
        public void set_defaultReflectionMode(){} // RVA: 0x7AEEC5F90
        public void get_defaultReflectionResolution(){} // RVA: 0x7AEEC5FE0
        public void set_defaultReflectionResolution(){} // RVA: 0x7AEEC6030
        public void get_haloStrength(){} // RVA: 0x7AEEC6080
        public void set_haloStrength(){} // RVA: 0x7AEEC60D0
        public void get_flareStrength(){} // RVA: 0x7AEEC6130
        public void set_flareStrength(){} // RVA: 0x7AEEC6180
        public void get_flareFadeSpeed(){} // RVA: 0x7AEEC61E0
        public void set_flareFadeSpeed(){} // RVA: 0x7AEEC6230
        public void get_fogColor_Injected(){} // RVA: 0x7AEEC6290
        public void set_fogColor_Injected(){} // RVA: 0x7AEEC62E0
        public void get_ambientSkyColor_Injected(){} // RVA: 0x7AEEC6330
        public void set_ambientSkyColor_Injected(){} // RVA: 0x7AEEC6380
        public void get_ambientEquatorColor_Injected(){} // RVA: 0x7AEEC63D0
        public void set_ambientEquatorColor_Injected(){} // RVA: 0x7AEEC6420
        public void get_ambientGroundColor_Injected(){} // RVA: 0x7AEEC6470
        public void set_ambientGroundColor_Injected(){} // RVA: 0x7AEEC64C0
        public void get_ambientLight_Injected(){} // RVA: 0x7AEEC6510
        public void set_ambientLight_Injected(){} // RVA: 0x7AEEC6560
        public void get_subtractiveShadowColor_Injected(){} // RVA: 0x7AEEC65B0
        public void set_subtractiveShadowColor_Injected(){} // RVA: 0x7AEEC6600
        public void get_ambientProbe_Injected(){} // RVA: 0x7AEEC6650
        public void set_ambientProbe_Injected(){} // RVA: 0x7AEEC66A0
    }

    public class RenderTexture : Texture
    {
        // ── Methods ──
        public void get_width(){} // RVA: 0x7AEEE7A80
        public void set_width(){} // RVA: 0x7AEEE7AD0
        public void get_height(){} // RVA: 0x7AEEE7B30
        public void set_height(){} // RVA: 0x7AEEE7B80
        public void get_dimension(){} // RVA: 0x7AEEE7BE0
        public void set_dimension(){} // RVA: 0x7AEEE7C30
        public void GetColorFormat(){} // RVA: 0x7AEEE7C90
        public void SetColorFormat(){} // RVA: 0x7AEEE7CF0
        public void get_graphicsFormat(){} // RVA: 0x7AEEE7D50
        public void set_graphicsFormat(){} // RVA: 0x7AEEE7CF0
        public void get_useMipMap(){} // RVA: 0x7AEEE7DB0
        public void set_useMipMap(){} // RVA: 0x7AEEE7E00
        public void get_sRGB(){} // RVA: 0x7AEEE7E60
        public void get_vrUsage(){} // RVA: 0x7AEEE7EB0
        public void set_vrUsage(){} // RVA: 0x7AEEE7F00
        public void get_memorylessMode(){} // RVA: 0x7AEEE7F60
        public void set_memorylessMode(){} // RVA: 0x7AEEE7FB0
        public void get_format(){} // RVA: 0x7AEEE8010
        public void set_format(){} // RVA: 0x7AEEE81A0
        public void get_stencilFormat(){} // RVA: 0x7AEEE8290
        public void set_stencilFormat(){} // RVA: 0x7AEEE82E0
        public void get_depthStencilFormat(){} // RVA: 0x7AEEE8340
        public void set_depthStencilFormat(){} // RVA: 0x7AEEE8390
        public void get_autoGenerateMips(){} // RVA: 0x7AEEE83F0
        public void set_autoGenerateMips(){} // RVA: 0x7AEEE8440
        public void get_volumeDepth(){} // RVA: 0x7AEEE84A0
        public void set_volumeDepth(){} // RVA: 0x7AEEE84F0
        public void get_antiAliasing(){} // RVA: 0x7AEEE8550
        public void set_antiAliasing(){} // RVA: 0x7AEEE85A0
        public void get_bindTextureMS(){} // RVA: 0x7AEEE8600
        public void set_bindTextureMS(){} // RVA: 0x7AEEE8650
        public void get_enableRandomWrite(){} // RVA: 0x7AEEE86B0
        public void set_enableRandomWrite(){} // RVA: 0x7AEEE8700
        public void get_useDynamicScale(){} // RVA: 0x7AEEE8760
        public void set_useDynamicScale(){} // RVA: 0x7AEEE87B0
        public void GetIsPowerOfTwo(){} // RVA: 0x7AEEE8810
        public void get_isPowerOfTwo(){} // RVA: 0x7AEEE8810
        public void set_isPowerOfTwo(){} // RVA: 0x7A80D7310
        public void GetActive(){} // RVA: 0x7AEEE8860
        public void SetActive(){} // RVA: 0x7AEEE88B0
        public void get_active(){} // RVA: 0x7AEEE8860
        public void set_active(){} // RVA: 0x7AEEE88B0
        public void GetColorBuffer(){} // RVA: 0x7AEEE8900
        public void GetDepthBuffer(){} // RVA: 0x7AEEE8970
        public void SetMipMapCount(){} // RVA: 0x7AEEE89E0
        public void SetShadowSamplingMode(){} // RVA: 0x7AEEE8A40
        public void get_colorBuffer(){} // RVA: 0x7AEEE8AA0
        public void get_depthBuffer(){} // RVA: 0x7AEEE8B20
        public void GetNativeDepthBufferPtr(){} // RVA: 0x7AEEE8BA0
        public void DiscardContents(){} // RVA: 0x7AEEE8CC0
        public void MarkRestoreExpected(){} // RVA: 0x7AEEE8C70
        public void ResolveAA(){} // RVA: 0x7AEEE8D20
        public void ResolveAATo(){} // RVA: 0x7AEEE8D70
        public void ResolveAntiAliasedSurface(){} // RVA: 0x7AEEE8D70
        public void SetGlobalShaderProperty(){} // RVA: 0x7AEEE8DD0
        public void Create(){} // RVA: 0x7AEEE8E30
        public void Release(){} // RVA: 0x7AEEE8E80
        public void IsCreated(){} // RVA: 0x7AEEE8ED0
        public void GenerateMips(){} // RVA: 0x7AEEE8F20
        public void ConvertToEquirect(){} // RVA: 0x7AEEE8F70
        public void SetSRGBReadWrite(){} // RVA: 0x7AEEE8FE0
        public void Internal_Create(){} // RVA: 0x7AEEE9040
        public void SupportsStencil(){} // RVA: 0x7AEEE9090
        public void SetRenderTextureDescriptor(){} // RVA: 0x7AEEE90E0
        public void GetDescriptor(){} // RVA: 0x7AEEE9140
        public void GetTemporary_Internal(){} // RVA: 0x7AEEE91C0
        public void ReleaseTemporary(){} // RVA: 0x7AEEE9210
        public void get_depth(){} // RVA: 0x7AEEE9260
        public void set_depth(){} // RVA: 0x7AEEE92B0
        public void .ctor(){} // RVA: 0x7AEEEA1B0
        public void Initialize(){} // RVA: 0x7AEEEA280
        public void GetDepthStencilFormatLegacy(){} // RVA: 0x7AEEEA5B0
        public void get_descriptor(){} // RVA: 0x7AEEEA640
        public void set_descriptor(){} // RVA: 0x7AEEEA6F0
        public void ValidateRenderTextureDesc(){} // RVA: 0x7AEEEA7B0
        public void GetDefaultColorFormat(){} // RVA: 0x7AEEEAD40
        public void GetDefaultDepthStencilFormat(){} // RVA: 0x7AEEEADB0
        public void GetCompatibleFormat(){} // RVA: 0x7AEEEAE20
        public void GetTemporary(){} // RVA: 0x7AEEEB7C0
        public void GetTemporaryImpl(){} // RVA: 0x7AEEEB090
        public void get_isCubemap(){} // RVA: 0x7AEEEB7F0
        public void set_isCubemap(){} // RVA: 0x7AEEEB820
        public void get_isVolume(){} // RVA: 0x7AEEEB860
        public void set_isVolume(){} // RVA: 0x7AEEEB890
        public void get_enabled(){} // RVA: 0x7A9EEB150
        public void set_enabled(){} // RVA: 0x7A80D7310
        public void GetTexelOffset(){} // RVA: 0x7A80FC2F0
        public void GetColorBuffer_Injected(){} // RVA: 0x7AEEEB8C0
        public void GetDepthBuffer_Injected(){} // RVA: 0x7AEEEB920
        public void SetRenderTextureDescriptor_Injected(){} // RVA: 0x7AEEEB980
        public void GetDescriptor_Injected(){} // RVA: 0x7AEEEB9E0
        public void GetTemporary_Internal_Injected(){} // RVA: 0x7AEEEBA40
    }

    public class RenderTextureDescriptor : ValueType
    {
        // ── Methods ──
        public void get_width(){} // RVA: 0x7A765F070
        public void set_width(){} // RVA: 0x7A76134D0
        public void get_height(){} // RVA: 0x7A765F0A0
        public void set_height(){} // RVA: 0x7A765F090
        public void get_msaaSamples(){} // RVA: 0x7A75FEFA0
        public void set_msaaSamples(){} // RVA: 0x7A767FBC0
        public void get_volumeDepth(){} // RVA: 0x7A767FBD0
        public void set_volumeDepth(){} // RVA: 0x7A767FBE0
        public void get_mipCount(){} // RVA: 0x7A7677B20
        public void set_mipCount(){} // RVA: 0x7A7677B10
        public void get_graphicsFormat(){} // RVA: 0x7A7829640
        public void set_graphicsFormat(){} // RVA: 0x7A7EDD090
        public void get_depthStencilFormat(){} // RVA: 0x7A768B130
        public void set_depthStencilFormat(){} // RVA: 0x7A768B140
        public void get_colorFormat(){} // RVA: 0x7A7EDD0A0
        public void set_colorFormat(){} // RVA: 0x7A7EDD0B0
        public void get_sRGB(){} // RVA: 0x7A7EDD0C0
        public void set_sRGB(){} // RVA: 0x7A7EDD0D0
        public void get_depthBufferBits(){} // RVA: 0x7A7EDD0E0
        public void set_depthBufferBits(){} // RVA: 0x7A7EDD0F0
        public void get_dimension(){} // RVA: 0x7A767FF50
        public void set_dimension(){} // RVA: 0x7A767FF30
        public void get_shadowSamplingMode(){} // RVA: 0x7A76C73F0
        public void set_shadowSamplingMode(){} // RVA: 0x7A76C73E0
        public void get_vrUsage(){} // RVA: 0x7A765EE70
        public void set_vrUsage(){} // RVA: 0x7A765EDE0
        public void get_flags(){} // RVA: 0x7A7ED4400
        public void get_memoryless(){} // RVA: 0x7A768FB50
        public void set_memoryless(){} // RVA: 0x7A76AD900
        public void .ctor(){} // RVA: 0x7A7EDD200
        public void SetOrClearRenderTextureCreationFlag(){} // RVA: 0x7A7EDD280
        public void get_useMipMap(){} // RVA: 0x7A7EDD2A0
        public void set_useMipMap(){} // RVA: 0x7A7EDD2B0
        public void get_autoGenerateMips(){} // RVA: 0x7A7EDD2D0
        public void set_autoGenerateMips(){} // RVA: 0x7A7EDD2E0
        public void get_enableRandomWrite(){} // RVA: 0x7A7EDD300
        public void set_enableRandomWrite(){} // RVA: 0x7A7EDD310
        public void get_bindMS(){} // RVA: 0x7A7EDD330
        public void set_bindMS(){} // RVA: 0x7A7EDD340
        public void set_createdFromScript(){} // RVA: 0x7A7EDD360
        public void get_useDynamicScale(){} // RVA: 0x7A7EDD380
        public void set_useDynamicScale(){} // RVA: 0x7A7EDD390
    }

    public class RenderTexture[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class RenderTexture[][] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Renderer : Component
    {
        // ── Methods ──
        public void get_castShadows(){} // RVA: 0x7AEEC2A20
        public void set_castShadows(){} // RVA: 0x7AEEC2A80
        public void get_motionVectors(){} // RVA: 0x7AEEC2AF0
        public void set_motionVectors(){} // RVA: 0x7AEEC2B50
        public void get_useLightProbes(){} // RVA: 0x7AEEC2BC0
        public void set_useLightProbes(){} // RVA: 0x7AEEC2C20
        public void get_bounds(){} // RVA: 0x7AEEC2C90
        public void set_bounds(){} // RVA: 0x7AEEC2D00
        public void get_localBounds(){} // RVA: 0x7AEEC2D60
        public void set_localBounds(){} // RVA: 0x7AEEC2DD0
        public void ResetBounds(){} // RVA: 0x7AEEC2E30
        public void ResetLocalBounds(){} // RVA: 0x7AEEC2E80
        public void SetStaticLightmapST(){} // RVA: 0x7AEEC2ED0
        public void GetMaterial(){} // RVA: 0x7AEEC2F30
        public void GetSharedMaterial(){} // RVA: 0x7AEEC2F80
        public void SetMaterial(){} // RVA: 0x7AEEC2FD0
        public void GetMaterialArray(){} // RVA: 0x7AEEC3030
        public void CopyMaterialArray(){} // RVA: 0x7AEEC3080
        public void CopySharedMaterialArray(){} // RVA: 0x7AEEC30E0
        public void SetMaterialArray(){} // RVA: 0x7AEEC31B0
        public void Internal_SetPropertyBlock(){} // RVA: 0x7AEEC31F0
        public void Internal_GetPropertyBlock(){} // RVA: 0x7AEEC3250
        public void Internal_SetPropertyBlockMaterialIndex(){} // RVA: 0x7AEEC32B0
        public void Internal_GetPropertyBlockMaterialIndex(){} // RVA: 0x7AEEC3320
        public void HasPropertyBlock(){} // RVA: 0x7AEEC3390
        public void SetPropertyBlock(){} // RVA: 0x7AEEC32B0
        public void GetPropertyBlock(){} // RVA: 0x7AEEC3320
        public void GetClosestReflectionProbesInternal(){} // RVA: 0x7AEEC33E0
        public void get_enabled(){} // RVA: 0x7AEEC3440
        public void set_enabled(){} // RVA: 0x7AEEC3490
        public void get_isVisible(){} // RVA: 0x7AEEC34F0
        public void get_shadowCastingMode(){} // RVA: 0x7AEEC3540
        public void set_shadowCastingMode(){} // RVA: 0x7AEEC3590
        public void get_receiveShadows(){} // RVA: 0x7AEEC35F0
        public void set_receiveShadows(){} // RVA: 0x7AEEC3640
        public void get_forceRenderingOff(){} // RVA: 0x7AEEC36A0
        public void set_forceRenderingOff(){} // RVA: 0x7AEEC36F0
        public void GetIsStaticShadowCaster(){} // RVA: 0x7AEEC3750
        public void SetIsStaticShadowCaster(){} // RVA: 0x7AEEC37A0
        public void get_staticShadowCaster(){} // RVA: 0x7AEEC3750
        public void set_staticShadowCaster(){} // RVA: 0x7AEEC37A0
        public void get_motionVectorGenerationMode(){} // RVA: 0x7AEEC3800
        public void set_motionVectorGenerationMode(){} // RVA: 0x7AEEC3850
        public void get_lightProbeUsage(){} // RVA: 0x7AEEC38B0
        public void set_lightProbeUsage(){} // RVA: 0x7AEEC3900
        public void get_reflectionProbeUsage(){} // RVA: 0x7AEEC3960
        public void set_reflectionProbeUsage(){} // RVA: 0x7AEEC39B0
        public void get_renderingLayerMask(){} // RVA: 0x7AEEC3A10
        public void set_renderingLayerMask(){} // RVA: 0x7AEEC3A60
        public void get_rendererPriority(){} // RVA: 0x7AEEC3AC0
        public void set_rendererPriority(){} // RVA: 0x7AEEC3B10
        public void get_rayTracingMode(){} // RVA: 0x7AEEC3B70
        public void set_rayTracingMode(){} // RVA: 0x7AEEC3BC0
        public void get_sortingLayerName(){} // RVA: 0x7AEEC3C20
        public void set_sortingLayerName(){} // RVA: 0x7AEEC3C70
        public void get_sortingLayerID(){} // RVA: 0x7AEEC3CD0
        public void set_sortingLayerID(){} // RVA: 0x7AEEC3D20
        public void get_sortingOrder(){} // RVA: 0x7AEEC3D80
        public void set_sortingOrder(){} // RVA: 0x7AEEC3DD0
        public void get_sortingKey(){} // RVA: 0x7AEEC3E30
        public void get_sortingGroupID(){} // RVA: 0x7AEEC3E80
        public void set_sortingGroupID(){} // RVA: 0x7AEEC3ED0
        public void get_sortingGroupOrder(){} // RVA: 0x7AEEC3F30
        public void set_sortingGroupOrder(){} // RVA: 0x7AEEC3F80
        public void get_sortingGroupKey(){} // RVA: 0x7AEEC3FE0
        public void get_allowOcclusionWhenDynamic(){} // RVA: 0x7AEEC4030
        public void set_allowOcclusionWhenDynamic(){} // RVA: 0x7AEEC4080
        public void get_staticBatchRootTransform(){} // RVA: 0x7AEEC40E0
        public void set_staticBatchRootTransform(){} // RVA: 0x7AEEC4130
        public void get_staticBatchIndex(){} // RVA: 0x7AEEC4190
        public void SetStaticBatchInfo(){} // RVA: 0x7AEEC41E0
        public void get_isPartOfStaticBatch(){} // RVA: 0x7AEEC4250
        public void get_worldToLocalMatrix(){} // RVA: 0x7AEEC42A0
        public void get_localToWorldMatrix(){} // RVA: 0x7AEEC4320
        public void get_lightProbeProxyVolumeOverride(){} // RVA: 0x7AEEC43A0
        public void set_lightProbeProxyVolumeOverride(){} // RVA: 0x7AEEC43F0
        public void get_probeAnchor(){} // RVA: 0x7AEEC4450
        public void set_probeAnchor(){} // RVA: 0x7AEEC44A0
        public void GetLightmapIndex(){} // RVA: 0x7AEEC4500
        public void SetLightmapIndex(){} // RVA: 0x7AEEC4560
        public void GetLightmapST(){} // RVA: 0x7AEEC45D0
        public void SetLightmapST(){} // RVA: 0x7AEEC4650
        public void get_lightmapIndex(){} // RVA: 0x7AEEC46C0
        public void set_lightmapIndex(){} // RVA: 0x7AEEC4720
        public void get_realtimeLightmapIndex(){} // RVA: 0x7AEEC4780
        public void set_realtimeLightmapIndex(){} // RVA: 0x7AEEC47E0
        public void get_lightmapScaleOffset(){} // RVA: 0x7AEEC4850
        public void set_lightmapScaleOffset(){} // RVA: 0x7AEEC48D0
        public void get_realtimeLightmapScaleOffset(){} // RVA: 0x7AEEC4930
        public void set_realtimeLightmapScaleOffset(){} // RVA: 0x7AEEC49B0
        public void GetMaterialCount(){} // RVA: 0x7AEEC4A20
        public void GetSharedMaterialArray(){} // RVA: 0x7AEEC4A70
        public void get_materials(){} // RVA: 0x7AEEC3030
        public void set_materials(){} // RVA: 0x7AEEC31B0
        public void get_material(){} // RVA: 0x7AEEC2F30
        public void set_material(){} // RVA: 0x7AEEC2FD0
        public void get_sharedMaterial(){} // RVA: 0x7AEEC2F80
        public void set_sharedMaterial(){} // RVA: 0x7AEEC2FD0
        public void get_sharedMaterials(){} // RVA: 0x7AEEC4A70
        public void set_sharedMaterials(){} // RVA: 0x7AEEC31B0
        public void GetMaterials(){} // RVA: 0x7AEEC4AC0
        public void SetSharedMaterials(){} // RVA: 0x7AEEC4C10
        public void SetMaterials(){} // RVA: 0x7AEEC4CE0
        public void GetSharedMaterials(){} // RVA: 0x7AEEC4DB0
        public void GetClosestReflectionProbes(){} // RVA: 0x7AEEC33E0
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_bounds_Injected(){} // RVA: 0x7AEEC4F00
        public void set_bounds_Injected(){} // RVA: 0x7AEEC4F60
        public void get_localBounds_Injected(){} // RVA: 0x7AEEC4FC0
        public void set_localBounds_Injected(){} // RVA: 0x7AEEC5020
        public void SetStaticLightmapST_Injected(){} // RVA: 0x7AEEC5080
        public void get_worldToLocalMatrix_Injected(){} // RVA: 0x7AEEC50E0
        public void get_localToWorldMatrix_Injected(){} // RVA: 0x7AEEC5140
        public void GetLightmapST_Injected(){} // RVA: 0x7AEEC51A0
        public void SetLightmapST_Injected(){} // RVA: 0x7AEEC5210
    }

    public class RendererExtensions : Object
    {
        // ── Methods ──
        public void UpdateGIMaterials(){} // RVA: 0x7AEEB9CE0
        public void UpdateGIMaterialsForRenderer(){} // RVA: 0x7AEEB9CE0
    }

    public class Renderer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class RequireComponent : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
    }

    public class RequireComponent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Resolution : ValueType
    {
        // ── Methods ──
        public void get_width(){} // RVA: 0x7A79EAED0
        public void set_width(){} // RVA: 0x7A76134D0
        public void get_height(){} // RVA: 0x7A7A39F60
        public void set_height(){} // RVA: 0x7A765F090
        public void get_refreshRateRatio(){} // RVA: 0x7A7E42C20
        public void get_refreshRate(){} // RVA: 0x7A7EDC500
        public void set_refreshRate(){} // RVA: 0x7A7EDC510
        public void ToString(){} // RVA: 0x7A7EDC520
    }

    public class Resolution[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ResourceRequest : AsyncOperation
    {
        // ── Methods ──
        public void GetResult(){} // RVA: 0x7AEEFF1E0
        public void get_asset(){} // RVA: 0x7A818C700
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ResourceRequest[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Resources : Object
    {
        // ── Methods ──
        public void ConvertObjects(){} // RVA: 0x7AA1AC5E0
        public void FindObjectsOfTypeAll(){} // RVA: 0x7AA57B3D0
        public void Load(){} // RVA: 0x7AA57B600
        public void LoadAsync(){} // RVA: 0x7AA57B720
        public void GetBuiltinResource(){} // RVA: 0x7A8051B10
        public void UnloadAsset(){} // RVA: 0x7AEEFFB60
        public void UnloadUnusedAssets(){} // RVA: 0x7AEEFFBD0
    }

    public class ResourcesAPI : Object
    {
        // ── Methods ──
        public void get_ActiveAPI(){} // RVA: 0x7AEEFF3B0
        public void get_overrideAPI(){} // RVA: 0x7AEEFF470
        public void .ctor(){} // RVA: 0x7A80D7310
        public void FindObjectsOfTypeAll(){} // RVA: 0x7AEEFF4D0
        public void FindShaderByName(){} // RVA: 0x7AEEFF520
        public void Load(){} // RVA: 0x7AEEFF570
        public void LoadAsync(){} // RVA: 0x7AEEFF5D0
        public void UnloadAsset(){} // RVA: 0x7AEEFF700
        public void .cctor(){} // RVA: 0x7AEEFF750
    }

    public class ResourcesAPIInternal : Object
    {
        // ── Methods ──
        public void FindObjectsOfTypeAll(){} // RVA: 0x7AEEFF200
        public void FindShaderByName(){} // RVA: 0x7AEEFF250
        public void Load(){} // RVA: 0x7AEEFF2A0
        public void LoadAsyncInternal(){} // RVA: 0x7AEEFF300
        public void UnloadAsset(){} // RVA: 0x7AEEFF360
    }

    public class Rigidbody : Component
    {
        // ── Methods ──
        public void get_velocity(){} // RVA: 0x7AEFDC440
        public void set_velocity(){} // RVA: 0x7AEFDC4B0
        public void get_angularVelocity(){} // RVA: 0x7AEFDC510
        public void set_angularVelocity(){} // RVA: 0x7AEFDC580
        public void get_drag(){} // RVA: 0x7AEFDC5E0
        public void set_drag(){} // RVA: 0x7AEFDC630
        public void get_angularDrag(){} // RVA: 0x7AEFDC690
        public void set_angularDrag(){} // RVA: 0x7AEFDC6E0
        public void get_mass(){} // RVA: 0x7AEFDC740
        public void set_mass(){} // RVA: 0x7AEFDC790
        public void SetDensity(){} // RVA: 0x7AEFDC7F0
        public void get_useGravity(){} // RVA: 0x7AEFDC850
        public void set_useGravity(){} // RVA: 0x7AEFDC8A0
        public void get_maxDepenetrationVelocity(){} // RVA: 0x7AEFDC900
        public void set_maxDepenetrationVelocity(){} // RVA: 0x7AEFDC950
        public void get_isKinematic(){} // RVA: 0x7AEFDC9B0
        public void set_isKinematic(){} // RVA: 0x7AEFDCA00
        public void get_freezeRotation(){} // RVA: 0x7AEFDCA60
        public void set_freezeRotation(){} // RVA: 0x7AEFDCAB0
        public void get_constraints(){} // RVA: 0x7AEFDCB10
        public void set_constraints(){} // RVA: 0x7AEFDCB60
        public void get_collisionDetectionMode(){} // RVA: 0x7AEFDCBC0
        public void set_collisionDetectionMode(){} // RVA: 0x7AEFDCC10
        public void get_automaticCenterOfMass(){} // RVA: 0x7AEFDCC70
        public void set_automaticCenterOfMass(){} // RVA: 0x7AEFDCCC0
        public void get_centerOfMass(){} // RVA: 0x7AEFDCD20
        public void set_centerOfMass(){} // RVA: 0x7AEFDCD90
        public void get_worldCenterOfMass(){} // RVA: 0x7AEFDCDF0
        public void get_automaticInertiaTensor(){} // RVA: 0x7AEFDCE60
        public void set_automaticInertiaTensor(){} // RVA: 0x7AEFDCEB0
        public void get_inertiaTensorRotation(){} // RVA: 0x7AEFDCF10
        public void set_inertiaTensorRotation(){} // RVA: 0x7AEFDCF80
        public void get_inertiaTensor(){} // RVA: 0x7AEFDCFE0
        public void set_inertiaTensor(){} // RVA: 0x7AEFDD050
        public void get_detectCollisions(){} // RVA: 0x7AEFDD0B0
        public void set_detectCollisions(){} // RVA: 0x7AEFDD100
        public void get_position(){} // RVA: 0x7AEFDD160
        public void set_position(){} // RVA: 0x7AEFDD1D0
        public void get_rotation(){} // RVA: 0x7AEFDD230
        public void set_rotation(){} // RVA: 0x7AEFDD2A0
        public void get_interpolation(){} // RVA: 0x7AEFDD300
        public void set_interpolation(){} // RVA: 0x7AEFDD350
        public void get_solverIterations(){} // RVA: 0x7AEFDD3B0
        public void set_solverIterations(){} // RVA: 0x7AEFDD400
        public void get_sleepThreshold(){} // RVA: 0x7AEFDD460
        public void set_sleepThreshold(){} // RVA: 0x7AEFDD4B0
        public void get_maxAngularVelocity(){} // RVA: 0x7AEFDD510
        public void set_maxAngularVelocity(){} // RVA: 0x7AEFDD560
        public void get_maxLinearVelocity(){} // RVA: 0x7AEFDD5C0
        public void set_maxLinearVelocity(){} // RVA: 0x7AEFDD610
        public void MovePosition(){} // RVA: 0x7AEFDD670
        public void MoveRotation(){} // RVA: 0x7AEFDD6D0
        public void Move(){} // RVA: 0x7AEFDD730
        public void Sleep(){} // RVA: 0x7AEFDD7A0
        public void IsSleeping(){} // RVA: 0x7AEFDD7F0
        public void WakeUp(){} // RVA: 0x7AEFDD840
        public void ResetCenterOfMass(){} // RVA: 0x7AEFDD890
        public void ResetInertiaTensor(){} // RVA: 0x7AEFDD8E0
        public void GetRelativePointVelocity(){} // RVA: 0x7AEFDD930
        public void GetPointVelocity(){} // RVA: 0x7AEFDD9B0
        public void get_solverVelocityIterations(){} // RVA: 0x7AEFDDA30
        public void set_solverVelocityIterations(){} // RVA: 0x7AEFDDA80
        public void get_excludeLayers(){} // RVA: 0x7AEFDDAE0
        public void set_excludeLayers(){} // RVA: 0x7AEFDDB40
        public void get_includeLayers(){} // RVA: 0x7AEFDDBA0
        public void set_includeLayers(){} // RVA: 0x7AEFDDC00
        public void GetAccumulatedForce(){} // RVA: 0x7AEFDDCE0
        public void GetAccumulatedTorque(){} // RVA: 0x7AEFDDE40
        public void AddForce(){} // RVA: 0x7AEFDE070
        public void AddRelativeForce(){} // RVA: 0x7AEFDE230
        public void AddTorque(){} // RVA: 0x7AEFDE3F0
        public void AddRelativeTorque(){} // RVA: 0x7AEFDE5B0
        public void AddForceAtPosition(){} // RVA: 0x7AEFDE6A0
        public void AddExplosionForce(){} // RVA: 0x7AEFDE860
        public void Internal_ClosestPointOnBounds(){} // RVA: 0x7AEFDE900
        public void ClosestPointOnBounds(){} // RVA: 0x7AEFDE980
        public void SweepTest(){} // RVA: 0x7AEFDECA0
        public void Internal_SweepTestAll(){} // RVA: 0x7AEFDECE0
        public void SweepTestAll(){} // RVA: 0x7AEFDEE90
        public void get_sleepVelocity(){} // RVA: 0x7AEED1930
        public void set_sleepVelocity(){} // RVA: 0x7A80D7310
        public void get_sleepAngularVelocity(){} // RVA: 0x7AEED1930
        public void set_sleepAngularVelocity(){} // RVA: 0x7A80D7310
        public void SetMaxAngularVelocity(){} // RVA: 0x7AEFDD560
        public void get_useConeFriction(){} // RVA: 0x7AA57AB40
        public void set_useConeFriction(){} // RVA: 0x7A80D7310
        public void get_solverIterationCount(){} // RVA: 0x7AEFDD3B0
        public void set_solverIterationCount(){} // RVA: 0x7AEFDD400
        public void get_solverVelocityIterationCount(){} // RVA: 0x7AEFDDA30
        public void set_solverVelocityIterationCount(){} // RVA: 0x7AEFDDA80
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_velocity_Injected(){} // RVA: 0x7AEFDEED0
        public void set_velocity_Injected(){} // RVA: 0x7AEFDEF30
        public void get_angularVelocity_Injected(){} // RVA: 0x7AEFDEF90
        public void set_angularVelocity_Injected(){} // RVA: 0x7AEFDEFF0
        public void get_centerOfMass_Injected(){} // RVA: 0x7AEFDF050
        public void set_centerOfMass_Injected(){} // RVA: 0x7AEFDF0B0
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x7AEFDF110
        public void get_inertiaTensorRotation_Injected(){} // RVA: 0x7AEFDF170
        public void set_inertiaTensorRotation_Injected(){} // RVA: 0x7AEFDF1D0
        public void get_inertiaTensor_Injected(){} // RVA: 0x7AEFDF230
        public void set_inertiaTensor_Injected(){} // RVA: 0x7AEFDF290
        public void get_position_Injected(){} // RVA: 0x7AEFDF2F0
        public void set_position_Injected(){} // RVA: 0x7AEFDF350
        public void get_rotation_Injected(){} // RVA: 0x7AEFDF3B0
        public void set_rotation_Injected(){} // RVA: 0x7AEFDF410
        public void MovePosition_Injected(){} // RVA: 0x7AEFDF470
        public void MoveRotation_Injected(){} // RVA: 0x7AEFDF4D0
        public void Move_Injected(){} // RVA: 0x7AEFDF530
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x7AEFDF5A0
        public void GetPointVelocity_Injected(){} // RVA: 0x7AEFDF610
        public void get_excludeLayers_Injected(){} // RVA: 0x7AEFDF680
        public void set_excludeLayers_Injected(){} // RVA: 0x7AEFDF6E0
        public void get_includeLayers_Injected(){} // RVA: 0x7AEFDF740
        public void set_includeLayers_Injected(){} // RVA: 0x7AEFDF7A0
        public void GetAccumulatedForce_Injected(){} // RVA: 0x7AEFDF800
        public void GetAccumulatedTorque_Injected(){} // RVA: 0x7AEFDF870
        public void AddForce_Injected(){} // RVA: 0x7AEFDF8E0
        public void AddRelativeForce_Injected(){} // RVA: 0x7AEFDF950
        public void AddTorque_Injected(){} // RVA: 0x7AEFDF9C0
        public void AddRelativeTorque_Injected(){} // RVA: 0x7AEFDFA30
        public void AddForceAtPosition_Injected(){} // RVA: 0x7AEFDFAA0
        public void AddExplosionForce_Injected(){} // RVA: 0x7AEFDFB20
        public void Internal_ClosestPointOnBounds_Injected(){} // RVA: 0x7AEFDFBB0
        public void SweepTest_Injected(){} // RVA: 0x7AEFDFC30
        public void Internal_SweepTestAll_Injected(){} // RVA: 0x7AEFDFCC0
    }

    public class Rigidbody2D : Component
    {
        // ── Methods ──
        public void get_position(){} // RVA: 0x7AEFC13A0
        public void set_position(){} // RVA: 0x7AEFC1400
        public void get_rotation(){} // RVA: 0x7AEFC1460
        public void set_rotation(){} // RVA: 0x7AEFC14B0
        public void SetRotation(){} // RVA: 0x7AEFC1570
        public void SetRotation_Angle(){} // RVA: 0x7AEFC1510
        public void SetRotation_Quaternion(){} // RVA: 0x7AEFC15D0
        public void MovePosition(){} // RVA: 0x7AEFC1630
        public void MoveRotation(){} // RVA: 0x7AEFC16F0
        public void MoveRotation_Angle(){} // RVA: 0x7AEFC1690
        public void MoveRotation_Quaternion(){} // RVA: 0x7AEFC1750
        public void get_velocity(){} // RVA: 0x7AEFC17B0
        public void set_velocity(){} // RVA: 0x7AEFC1810
        public void get_angularVelocity(){} // RVA: 0x7AEFC1870
        public void set_angularVelocity(){} // RVA: 0x7AEFC18C0
        public void get_useAutoMass(){} // RVA: 0x7AEFC1920
        public void set_useAutoMass(){} // RVA: 0x7AEFC1970
        public void get_mass(){} // RVA: 0x7AEFC19D0
        public void set_mass(){} // RVA: 0x7AEFC1A20
        public void get_sharedMaterial(){} // RVA: 0x7AEFC1A80
        public void set_sharedMaterial(){} // RVA: 0x7AEFC1AD0
        public void get_centerOfMass(){} // RVA: 0x7AEFC1B30
        public void set_centerOfMass(){} // RVA: 0x7AEFC1B90
        public void get_worldCenterOfMass(){} // RVA: 0x7AEFC1BF0
        public void get_inertia(){} // RVA: 0x7AEFC1C50
        public void set_inertia(){} // RVA: 0x7AEFC1CA0
        public void get_drag(){} // RVA: 0x7AEFC1D00
        public void set_drag(){} // RVA: 0x7AEFC1D50
        public void get_angularDrag(){} // RVA: 0x7AEFC1DB0
        public void set_angularDrag(){} // RVA: 0x7AEFC1E00
        public void get_gravityScale(){} // RVA: 0x7AEFC1E60
        public void set_gravityScale(){} // RVA: 0x7AEFC1EB0
        public void get_bodyType(){} // RVA: 0x7AEFC1F10
        public void set_bodyType(){} // RVA: 0x7AEFC1F60
        public void get_useFullKinematicContacts(){} // RVA: 0x7AEFC1FC0
        public void set_useFullKinematicContacts(){} // RVA: 0x7AEFC2010
        public void get_isKinematic(){} // RVA: 0x7AEFC2070
        public void set_isKinematic(){} // RVA: 0x7AEFC20D0
        public void get_freezeRotation(){} // RVA: 0x7AEFC2140
        public void set_freezeRotation(){} // RVA: 0x7AEFC2190
        public void get_constraints(){} // RVA: 0x7AEFC21F0
        public void set_constraints(){} // RVA: 0x7AEFC2240
        public void IsSleeping(){} // RVA: 0x7AEFC22A0
        public void IsAwake(){} // RVA: 0x7AEFC22F0
        public void Sleep(){} // RVA: 0x7AEFC2340
        public void WakeUp(){} // RVA: 0x7AEFC2390
        public void get_simulated(){} // RVA: 0x7AEFC23E0
        public void set_simulated(){} // RVA: 0x7AEFC2430
        public void get_interpolation(){} // RVA: 0x7AEFC2490
        public void set_interpolation(){} // RVA: 0x7AEFC24E0
        public void get_sleepMode(){} // RVA: 0x7AEFC2540
        public void set_sleepMode(){} // RVA: 0x7AEFC2590
        public void get_collisionDetectionMode(){} // RVA: 0x7AEFC25F0
        public void set_collisionDetectionMode(){} // RVA: 0x7AEFC2640
        public void get_attachedColliderCount(){} // RVA: 0x7AEFC26A0
        public void get_totalForce(){} // RVA: 0x7AEFC26F0
        public void set_totalForce(){} // RVA: 0x7AEFC2750
        public void get_totalTorque(){} // RVA: 0x7AEFC27B0
        public void set_totalTorque(){} // RVA: 0x7AEFC2800
        public void get_excludeLayers(){} // RVA: 0x7AEFC2860
        public void set_excludeLayers(){} // RVA: 0x7AEFC28C0
        public void get_includeLayers(){} // RVA: 0x7AEFC2920
        public void set_includeLayers(){} // RVA: 0x7AEFC2980
        public void IsTouching(){} // RVA: 0x7AEFC2B30
        public void IsTouching_OtherColliderWithFilter_Internal(){} // RVA: 0x7AEFC2AC0
        public void IsTouching_AnyColliderWithFilter_Internal(){} // RVA: 0x7AEFC2BA0
        public void IsTouchingLayers(){} // RVA: 0x7AEFC2C60
        public void OverlapPoint(){} // RVA: 0x7AEFC2CC0
        public void Distance(){} // RVA: 0x7AEFC2D20
        public void Distance_Internal(){} // RVA: 0x7AEFC3040
        public void ClosestPoint(){} // RVA: 0x7AEFC30C0
        public void AddForce(){} // RVA: 0x7AEFC3190
        public void AddRelativeForce(){} // RVA: 0x7AEFC3260
        public void AddForceAtPosition(){} // RVA: 0x7AEFC3340
        public void AddTorque(){} // RVA: 0x7AEFC3430
        public void GetPoint(){} // RVA: 0x7AEFC34A0
        public void GetRelativePoint(){} // RVA: 0x7AEFC3510
        public void GetVector(){} // RVA: 0x7AEFC3580
        public void GetRelativeVector(){} // RVA: 0x7AEFC35F0
        public void GetPointVelocity(){} // RVA: 0x7AEFC3660
        public void GetRelativePointVelocity(){} // RVA: 0x7AEFC36D0
        public void OverlapCollider(){} // RVA: 0x7AEFC3830
        public void OverlapColliderArray_Internal(){} // RVA: 0x7AEFC37C0
        public void OverlapColliderList_Internal(){} // RVA: 0x7AEFC38B0
        public void GetContacts(){} // RVA: 0x7AEFC3DD0
        public void GetAttachedColliders(){} // RVA: 0x7AEFC3EC0
        public void GetAttachedCollidersArray_Internal(){} // RVA: 0x7AEFC3E60
        public void GetAttachedCollidersList_Internal(){} // RVA: 0x7AEFC3EC0
        public void Cast(){} // RVA: 0x7AEFC42C0
        public void CastArray_Internal(){} // RVA: 0x7AEFC3F70
        public void CastList_Internal(){} // RVA: 0x7AEFC4070
        public void CastFilteredArray_Internal(){} // RVA: 0x7AEFC4230
        public void CastFilteredList_Internal(){} // RVA: 0x7AEFC4360
        public void GetShapes(){} // RVA: 0x7AEFC43F0
        public void GetShapes_Internal(){} // RVA: 0x7AEFC4460
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_position_Injected(){} // RVA: 0x7AEFC44C0
        public void set_position_Injected(){} // RVA: 0x7AEFC4520
        public void SetRotation_Quaternion_Injected(){} // RVA: 0x7AEFC4580
        public void MovePosition_Injected(){} // RVA: 0x7AEFC45E0
        public void MoveRotation_Quaternion_Injected(){} // RVA: 0x7AEFC4640
        public void get_velocity_Injected(){} // RVA: 0x7AEFC46A0
        public void set_velocity_Injected(){} // RVA: 0x7AEFC4700
        public void get_centerOfMass_Injected(){} // RVA: 0x7AEFC4760
        public void set_centerOfMass_Injected(){} // RVA: 0x7AEFC47C0
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x7AEFC4820
        public void get_totalForce_Injected(){} // RVA: 0x7AEFC4880
        public void set_totalForce_Injected(){} // RVA: 0x7AEFC48E0
        public void get_excludeLayers_Injected(){} // RVA: 0x7AEFC4940
        public void set_excludeLayers_Injected(){} // RVA: 0x7AEFC49A0
        public void get_includeLayers_Injected(){} // RVA: 0x7AEFC4A00
        public void set_includeLayers_Injected(){} // RVA: 0x7AEFC4A60
        public void IsTouching_OtherColliderWithFilter_Internal_Injected(){} // RVA: 0x7AEFC4AC0
        public void IsTouching_AnyColliderWithFilter_Internal_Injected(){} // RVA: 0x7AEFC4B30
        public void OverlapPoint_Injected(){} // RVA: 0x7AEFC4B90
        public void Distance_Internal_Injected(){} // RVA: 0x7AEFC4BF0
        public void AddForce_Injected(){} // RVA: 0x7AEFC4C60
        public void AddRelativeForce_Injected(){} // RVA: 0x7AEFC4CD0
        public void AddForceAtPosition_Injected(){} // RVA: 0x7AEFC4D40
        public void GetPoint_Injected(){} // RVA: 0x7AEFC4DC0
        public void GetRelativePoint_Injected(){} // RVA: 0x7AEFC4E30
        public void GetVector_Injected(){} // RVA: 0x7AEFC4EA0
        public void GetRelativeVector_Injected(){} // RVA: 0x7AEFC4F10
        public void GetPointVelocity_Injected(){} // RVA: 0x7AEFC4F80
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x7AEFC4FF0
        public void OverlapColliderArray_Internal_Injected(){} // RVA: 0x7AEFC5060
        public void OverlapColliderList_Internal_Injected(){} // RVA: 0x7AEFC50D0
        public void CastArray_Internal_Injected(){} // RVA: 0x7AEFC5140
        public void CastList_Internal_Injected(){} // RVA: 0x7AEFC51C0
        public void CastFilteredArray_Internal_Injected(){} // RVA: 0x7AEFC5240
        public void CastFilteredList_Internal_Injected(){} // RVA: 0x7AEFC52D0
    }

    public class Rigidbody[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class RuntimeAnimatorController : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE795F0
        public void get_animationClips(){} // RVA: 0x7AEE79640
    }

    public class RuntimeAnimatorController[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void set_loadType(){} // RVA: 0x7A80DA0C0
    }

    public class RuntimeInitializeOnLoadMethodAttribute[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

}