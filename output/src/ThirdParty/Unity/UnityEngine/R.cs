// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 37
// Methods: 1037

namespace ThirdParty.Unity.UnityEngine
{
    public class Random : Object
    {
        public object value;
        public object insideUnitSphere;
        public object insideUnitCircle;
        public object onUnitSphere;
        public object rotation;
        public object rotationUniform;

        // ── Methods ──
        public void InitState(){} // RVA: 0x7FFAC98B80E0
        public void Range(){} // RVA: 0x7FFAC98B81A0 | overloaded x2
        public void RandomRangeInt(){} // RVA: 0x7FFAC98B81A0
        public void get_value(){} // RVA: 0x7FFAC41D9090
        public void get_insideUnitSphere(){} // RVA: 0x7FFAC98B8200
        public void GetRandomUnitCircle(){} // RVA: 0x7FFAC98B8260
        public void get_insideUnitCircle(){} // RVA: 0x7FFAC98B82B0
        public void get_onUnitSphere(){} // RVA: 0x7FFAC98B8310
        public void get_rotation(){} // RVA: 0x7FFAC98B8370
        public void get_rotationUniform(){} // RVA: 0x7FFAC98B83D0
        public void ColorHSV(){} // RVA: 0x7FFAC98B85D0 | overloaded x5
        public void get_insideUnitSphere_Injected(){} // RVA: 0x7FFAC98B8840
        public void get_onUnitSphere_Injected(){} // RVA: 0x7FFAC98B8890
        public void get_rotation_Injected(){} // RVA: 0x7FFAC98B88E0
        public void get_rotationUniform_Injected(){} // RVA: 0x7FFAC98B8930
    }

    public class RangeAttribute : PropertyAttribute
    {
        public float min; // 0x10
        public float max; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3B2F3C0
    }

    public class RangeInt : ValueType
    {
        public int end; // 0x10
        public int length; // 0x14

        // ── Methods ──
        public void get_end(){} // RVA: 0x7FFAC98C3290
        public void .ctor(){} // RVA: 0x7FFAC33D6D50
    }

    public class Ray : ValueType
    {
        public UnityEngine.Vector3 origin; // 0x10
        public UnityEngine.Vector3 direction; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98663A0
        public void get_origin(){} // RVA: 0x7FFAC9811DA0
        public void set_origin(){} // RVA: 0x7FFAC530B6C0
        public void get_direction(){} // RVA: 0x7FFAC9811DC0
        public void set_direction(){} // RVA: 0x7FFAC98663E0
        public void GetPoint(){} // RVA: 0x7FFAC9866410
        public void ToString(){} // RVA: 0x7FFAC9866480 | overloaded x3
    }

    public class RaycastCommand : ValueType
    {
        public UnityEngine.Vector3 from; // 0x10
        public UnityEngine.Vector3 direction; // 0x1C
        public UnityEngine.PhysicsScene physicsScene; // 0x28
        public float distance; // 0x2C
        public UnityEngine.QueryParameters queryParameters; // 0x30

        // ── Methods ──
        public void set_from(){} // RVA: 0x7FFAC530B6C0
        public void set_direction(){} // RVA: 0x7FFAC9811DE0
        public void set_physicsScene(){} // RVA: 0x7FFAC392CD10
        public void set_distance(){} // RVA: 0x7FFAC2FEE580
        public void ScheduleBatch(){} // RVA: 0x7FFAC99A3180
        public void ScheduleRaycastBatch(){} // RVA: 0x7FFAC99A33B0
        public void ScheduleRaycastBatch_Injected(){} // RVA: 0x7FFAC99A3460
    }

    public class RaycastHit : ValueType
    {
        public UnityEngine.Vector3 collider; // 0x10
        public UnityEngine.Vector3 colliderInstanceID; // 0x1C
        public uint point; // 0x28
        public float normal; // 0x2C
        public UnityEngine.Vector2 barycentricCoordinate; // 0x30
        public int distance; // 0x38

        // ── Methods ──
        public void get_collider(){} // RVA: 0x7FFAC9993D40
        public void get_colliderInstanceID(){} // RVA: 0x7FFAC6C8FE60
        public void get_point(){} // RVA: 0x7FFAC9811DA0
        public void set_point(){} // RVA: 0x7FFAC530B6C0
        public void get_normal(){} // RVA: 0x7FFAC9811DC0
        public void set_normal(){} // RVA: 0x7FFAC9811DE0
        public void get_barycentricCoordinate(){} // RVA: 0x7FFAC9993E30
        public void set_barycentricCoordinate(){} // RVA: 0x7FFAC9993E60
        public void get_distance(){} // RVA: 0x7FFAC9814E00
        public void set_distance(){} // RVA: 0x7FFAC2FEE580
        public void get_triangleIndex(){} // RVA: 0x7FFAC669DCA0
        public void CalculateRaycastTexCoord(){} // RVA: 0x7FFAC9993E80
        public void get_textureCoord(){} // RVA: 0x7FFAC9993F20
        public void get_textureCoord2(){} // RVA: 0x7FFAC9993FD0
        public void get_transform(){} // RVA: 0x7FFAC9994080
        public void get_rigidbody(){} // RVA: 0x7FFAC99942A0
        public void get_articulationBody(){} // RVA: 0x7FFAC99943E0
        public void get_lightmapCoord(){} // RVA: 0x7FFAC9994520
        public void CalculateRaycastTexCoord_Injected(){} // RVA: 0x7FFAC99947A0
    }

    public class RaycastHit2D : ValueType
    {
        public UnityEngine.Vector2 centroid; // 0x10
        public UnityEngine.Vector2 point; // 0x18
        public UnityEngine.Vector2 normal; // 0x20
        public float distance; // 0x28
        public float fraction; // 0x2C
        public int collider; // 0x30

        // ── Methods ──
        public void get_centroid(){} // RVA: 0x7FFAC51D9A30
        public void set_centroid(){} // RVA: 0x7FFAC45BB120
        public void get_point(){} // RVA: 0x7FFAC9866820
        public void set_point(){} // RVA: 0x7FFAC4A068C0
        public void get_normal(){} // RVA: 0x7FFAC9977900
        public void set_normal(){} // RVA: 0x7FFAC441EFB0
        public void get_distance(){} // RVA: 0x7FFAC9811DF0
        public void set_distance(){} // RVA: 0x7FFAC2F3C4D0
        public void get_fraction(){} // RVA: 0x7FFAC9814E00
        public void set_fraction(){} // RVA: 0x7FFAC2FEE580
        public void get_collider(){} // RVA: 0x7FFAC9978FA0
        public void get_rigidbody(){} // RVA: 0x7FFAC9979090
        public void get_transform(){} // RVA: 0x7FFAC99791D0
        public void op_Implicit(){} // RVA: 0x7FFAC99793F0
        public void CompareTo(){} // RVA: 0x7FFAC99794D0
    }

    public class Rect : ValueType
    {
        public float zero; // 0x10
        public float x; // 0x14
        public float y; // 0x18
        public float position; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4A9B930 | overloaded x3
        public void get_zero(){} // RVA: 0x7FFAC9866670
        public void MinMaxRect(){} // RVA: 0x7FFAC9866680
        public void Set(){} // RVA: 0x7FFAC2F45570
        public void get_x(){} // RVA: 0x7FFAC2F44D20
        public void set_x(){} // RVA: 0x7FFAC4A9B910
        public void get_y(){} // RVA: 0x7FFAC2F44D30
        public void set_y(){} // RVA: 0x7FFAC4A9B8F0
        public void get_position(){} // RVA: 0x7FFAC98666C0
        public void set_position(){} // RVA: 0x7FFAC98666E0
        public void get_center(){} // RVA: 0x7FFAC9866700
        public void set_center(){} // RVA: 0x7FFAC9866730
        public void get_min(){} // RVA: 0x7FFAC9866770
        public void set_min(){} // RVA: 0x7FFAC9866790
        public void get_max(){} // RVA: 0x7FFAC98667D0
        public void set_max(){} // RVA: 0x7FFAC98667F0
        public void get_width(){} // RVA: 0x7FFAC2F44CF0
        public void set_width(){} // RVA: 0x7FFAC4A9B920
        public void get_height(){} // RVA: 0x7FFAC2F44D00
        public void set_height(){} // RVA: 0x7FFAC4A9B8C0
        public void get_size(){} // RVA: 0x7FFAC9866820
        public void set_size(){} // RVA: 0x7FFAC9866840
        public void get_xMin(){} // RVA: 0x7FFAC2F44D20
        public void set_xMin(){} // RVA: 0x7FFAC9866860
        public void get_yMin(){} // RVA: 0x7FFAC2F44D30
        public void set_yMin(){} // RVA: 0x7FFAC9866880
        public void get_xMax(){} // RVA: 0x7FFAC98668A0
        public void set_xMax(){} // RVA: 0x7FFAC98668B0
        public void get_yMax(){} // RVA: 0x7FFAC98668C0
        public void set_yMax(){} // RVA: 0x7FFAC98668D0
        public void Contains(){} // RVA: 0x7FFAC9866960 | overloaded x3
        public void OrderMinMax(){} // RVA: 0x7FFAC9866A80
        public void Overlaps(){} // RVA: 0x7FFAC9866B40 | overloaded x2
        public void NormalizedToPoint(){} // RVA: 0x7FFAC9866CA0
        public void PointToNormalized(){} // RVA: 0x7FFAC9866D20
        public void op_Inequality(){} // RVA: 0x7FFAC9866DC0
        public void op_Equality(){} // RVA: 0x7FFAC9866E10
        public void GetHashCode(){} // RVA: 0x7FFAC9866E50
        public void Equals(){} // RVA: 0x7FFAC4F2F240 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC9866F80 | overloaded x3
    }

    public class RectInt : ValueType
    {
        public int x; // 0x10
        public int y; // 0x14
        public int width; // 0x18
        public int height; // 0x1C

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFAC8F93F90
        public void set_x(){} // RVA: 0x7FFAC336D8B0
        public void get_y(){} // RVA: 0x7FFAC69CBEA0
        public void set_y(){} // RVA: 0x7FFAC4420230
        public void get_width(){} // RVA: 0x7FFAC653D9A0
        public void set_width(){} // RVA: 0x7FFAC49C7510
        public void get_height(){} // RVA: 0x7FFAC659DBB0
        public void set_height(){} // RVA: 0x7FFAC49C7530
        public void get_xMin(){} // RVA: 0x7FFAC9867310
        public void get_yMin(){} // RVA: 0x7FFAC9867380
        public void get_xMax(){} // RVA: 0x7FFAC98673F0
        public void get_yMax(){} // RVA: 0x7FFAC9867460
        public void .ctor(){} // RVA: 0x7FFAC831F680
        public void Overlaps(){} // RVA: 0x7FFAC98674D0
        public void ToString(){} // RVA: 0x7FFAC9867580 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC98679D0
    }

    public class RectOffset : Object
    {
        public UIntPtr left; // 0x10
        public object right; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9867B50 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFAC9867AB0
        public void ToString(){} // RVA: 0x7FFAC9867D00 | overloaded x2
        public void Destroy(){} // RVA: 0x7FFAC9868260
        public void InternalCreate(){} // RVA: 0x7FFAC98682D0
        public void InternalDestroy(){} // RVA: 0x7FFAC9868320
        public void get_left(){} // RVA: 0x7FFAC9868370
        public void set_left(){} // RVA: 0x7FFAC98683C0
        public void get_right(){} // RVA: 0x7FFAC9868420
        public void set_right(){} // RVA: 0x7FFAC9868470
        public void get_top(){} // RVA: 0x7FFAC98684D0
        public void set_top(){} // RVA: 0x7FFAC9868520
        public void get_bottom(){} // RVA: 0x7FFAC9868580
        public void set_bottom(){} // RVA: 0x7FFAC98685D0
        public void get_horizontal(){} // RVA: 0x7FFAC9868630
        public void get_vertical(){} // RVA: 0x7FFAC9868680
        public void Remove(){} // RVA: 0x7FFAC98686D0
        public void Remove_Injected(){} // RVA: 0x7FFAC9868750
    }

    public class RectTransform : Transform
    {
        public ReapplyDrivenProperties rect;

        // ── Methods ──
        public void add_reapplyDrivenProperties(){} // RVA: 0x7FFAC98CE390
        public void remove_reapplyDrivenProperties(){} // RVA: 0x7FFAC98CE4A0
        public void get_rect(){} // RVA: 0x7FFAC98CE5B0
        public void get_anchorMin(){} // RVA: 0x7FFAC98CE620
        public void set_anchorMin(){} // RVA: 0x7FFAC98CE680
        public void get_anchorMax(){} // RVA: 0x7FFAC98CE6E0
        public void set_anchorMax(){} // RVA: 0x7FFAC98CE740
        public void get_anchoredPosition(){} // RVA: 0x7FFAC98CE7A0
        public void set_anchoredPosition(){} // RVA: 0x7FFAC98CE800
        public void get_sizeDelta(){} // RVA: 0x7FFAC98CE860
        public void set_sizeDelta(){} // RVA: 0x7FFAC98CE8C0
        public void get_pivot(){} // RVA: 0x7FFAC98CE920
        public void set_pivot(){} // RVA: 0x7FFAC98CE980
        public void get_anchoredPosition3D(){} // RVA: 0x7FFAC98CE9E0
        public void set_anchoredPosition3D(){} // RVA: 0x7FFAC98CEAC0
        public void get_offsetMin(){} // RVA: 0x7FFAC98CEBF0
        public void set_offsetMin(){} // RVA: 0x7FFAC98CED20
        public void get_offsetMax(){} // RVA: 0x7FFAC98CF0A0
        public void set_offsetMax(){} // RVA: 0x7FFAC98CF230
        public void get_drivenByObject(){} // RVA: 0x7FFAC98CF590
        public void set_drivenByObject(){} // RVA: 0x7FFAC98CF5E0
        public void get_drivenProperties(){} // RVA: 0x7FFAC98CF640
        public void set_drivenProperties(){} // RVA: 0x7FFAC98CF690
        public void ForceUpdateRectTransforms(){} // RVA: 0x7FFAC98CF6F0
        public void GetLocalCorners(){} // RVA: 0x7FFAC98CF740
        public void GetWorldCorners(){} // RVA: 0x7FFAC98CF8C0
        public void SetInsetAndSizeFromParentEdge(){} // RVA: 0x7FFAC98CFC30
        public void SetSizeWithCurrentAnchors(){} // RVA: 0x7FFAC98D0180
        public void SendReapplyDrivenProperties(){} // RVA: 0x7FFAC98D04E0
        public void GetRectInParentSpace(){} // RVA: 0x7FFAC98D0540
        public void GetParentSize(){} // RVA: 0x7FFAC98D0A00
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_rect_Injected(){} // RVA: 0x7FFAC98D0BE0
        public void get_anchorMin_Injected(){} // RVA: 0x7FFAC98D0C40
        public void set_anchorMin_Injected(){} // RVA: 0x7FFAC98D0CA0
        public void get_anchorMax_Injected(){} // RVA: 0x7FFAC98D0D00
        public void set_anchorMax_Injected(){} // RVA: 0x7FFAC98D0D60
        public void get_anchoredPosition_Injected(){} // RVA: 0x7FFAC98D0DC0
        public void set_anchoredPosition_Injected(){} // RVA: 0x7FFAC98D0E20
        public void get_sizeDelta_Injected(){} // RVA: 0x7FFAC98D0E80
        public void set_sizeDelta_Injected(){} // RVA: 0x7FFAC98D0EE0
        public void get_pivot_Injected(){} // RVA: 0x7FFAC98D0F40
        public void set_pivot_Injected(){} // RVA: 0x7FFAC98D0FA0
    }

    public class RectTransformUtility : Object
    {
        public UnityEngine.Vector3[] s_Corners;

        // ── Methods ──
        public void PixelAdjustPoint(){} // RVA: 0x7FFAC9C35700
        public void PixelAdjustRect(){} // RVA: 0x7FFAC9C357B0
        public void PointInRectangle(){} // RVA: 0x7FFAC9C35860
        public void RectangleContainsScreenPoint(){} // RVA: 0x7FFAC9C35A40 | overloaded x3
        public void ScreenPointToWorldPointInRectangle(){} // RVA: 0x7FFAC9C35B40
        public void ScreenPointToLocalPointInRectangle(){} // RVA: 0x7FFAC9C36240
        public void ScreenPointToRay(){} // RVA: 0x7FFAC9C363B0
        public void WorldToScreenPoint(){} // RVA: 0x7FFAC9C36640
        public void FlipLayoutOnAxis(){} // RVA: 0x7FFAC9C367B0
        public void FlipLayoutAxes(){} // RVA: 0x7FFAC9C36EA0
        public void GetTransposed(){} // RVA: 0x7FFAC9C374A0
        public void .cctor(){} // RVA: 0x7FFAC9C374C0
        public void PixelAdjustPoint_Injected(){} // RVA: 0x7FFAC9C37580
        public void PixelAdjustRect_Injected(){} // RVA: 0x7FFAC9C37600
        public void PointInRectangle_Injected(){} // RVA: 0x7FFAC9C37670
    }

    public class ReflectionProbe : Behaviour
    {
        public System.Action`2<UnityEngine.ReflectionProbe,0x6B179E18> type;
        public System.Collections.Generic.Dictionary`2<int,System.Action`1<UnityEngine.Texture>> size; // 0x8
        public System.Collections.Generic.List`1<System.Action`1<UnityEngine.Texture>> center; // 0x10

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFAC985CC10
        public void set_type(){} // RVA: 0x7FFAC985CC60
        public void get_size(){} // RVA: 0x7FFAC985CCC0
        public void set_size(){} // RVA: 0x7FFAC985CD30
        public void get_center(){} // RVA: 0x7FFAC985CD90
        public void set_center(){} // RVA: 0x7FFAC985CE00
        public void get_nearClipPlane(){} // RVA: 0x7FFAC985CE60
        public void set_nearClipPlane(){} // RVA: 0x7FFAC985CEB0
        public void get_farClipPlane(){} // RVA: 0x7FFAC985CF10
        public void set_farClipPlane(){} // RVA: 0x7FFAC985CF60
        public void get_intensity(){} // RVA: 0x7FFAC985CFC0
        public void set_intensity(){} // RVA: 0x7FFAC985D010
        public void get_bounds(){} // RVA: 0x7FFAC985D070
        public void get_hdr(){} // RVA: 0x7FFAC985D0E0
        public void set_hdr(){} // RVA: 0x7FFAC985D130
        public void get_renderDynamicObjects(){} // RVA: 0x7FFAC985D190
        public void set_renderDynamicObjects(){} // RVA: 0x7FFAC985D1E0
        public void get_shadowDistance(){} // RVA: 0x7FFAC985D240
        public void set_shadowDistance(){} // RVA: 0x7FFAC985D290
        public void get_resolution(){} // RVA: 0x7FFAC985D2F0
        public void set_resolution(){} // RVA: 0x7FFAC985D340
        public void get_cullingMask(){} // RVA: 0x7FFAC985D3A0
        public void set_cullingMask(){} // RVA: 0x7FFAC985D3F0
        public void get_clearFlags(){} // RVA: 0x7FFAC985D450
        public void set_clearFlags(){} // RVA: 0x7FFAC985D4A0
        public void get_backgroundColor(){} // RVA: 0x7FFAC985D500
        public void set_backgroundColor(){} // RVA: 0x7FFAC985D570
        public void get_blendDistance(){} // RVA: 0x7FFAC985D5D0
        public void set_blendDistance(){} // RVA: 0x7FFAC985D620
        public void get_boxProjection(){} // RVA: 0x7FFAC985D680
        public void set_boxProjection(){} // RVA: 0x7FFAC985D6D0
        public void get_mode(){} // RVA: 0x7FFAC985D730
        public void set_mode(){} // RVA: 0x7FFAC985D780
        public void get_importance(){} // RVA: 0x7FFAC985D7E0
        public void set_importance(){} // RVA: 0x7FFAC985D830
        public void get_refreshMode(){} // RVA: 0x7FFAC985D890
        public void set_refreshMode(){} // RVA: 0x7FFAC985D8E0
        public void get_timeSlicingMode(){} // RVA: 0x7FFAC985D940
        public void set_timeSlicingMode(){} // RVA: 0x7FFAC985D990
        public void get_bakedTexture(){} // RVA: 0x7FFAC985D9F0
        public void set_bakedTexture(){} // RVA: 0x7FFAC985DA40
        public void get_customBakedTexture(){} // RVA: 0x7FFAC985DAA0
        public void set_customBakedTexture(){} // RVA: 0x7FFAC985DAF0
        public void get_realtimeTexture(){} // RVA: 0x7FFAC985DB50
        public void set_realtimeTexture(){} // RVA: 0x7FFAC985DBA0
        public void get_texture(){} // RVA: 0x7FFAC985DC00
        public void get_textureHDRDecodeValues(){} // RVA: 0x7FFAC985DC50
        public void Reset(){} // RVA: 0x7FFAC985DCC0
        public void RenderProbe(){} // RVA: 0x7FFAC985DD20 | overloaded x2
        public void IsFinishedRendering(){} // RVA: 0x7FFAC985DDD0
        public void ScheduleRender(){} // RVA: 0x7FFAC985DE30
        public void BlendCubemap(){} // RVA: 0x7FFAC985DEA0
        public void UpdateCachedState(){} // RVA: 0x7FFAC985DF20
        public void get_minBakedCubemapResolution(){} // RVA: 0x7FFAC985DF70
        public void get_maxBakedCubemapResolution(){} // RVA: 0x7FFAC985DFC0
        public void get_defaultTextureHDRDecodeValues(){} // RVA: 0x7FFAC985E010
        public void get_defaultTexture(){} // RVA: 0x7FFAC985E0A0
        public void add_reflectionProbeChanged(){} // RVA: 0x7FFAC985E0F0
        public void remove_reflectionProbeChanged(){} // RVA: 0x7FFAC985E250
        public void CallReflectionProbeEvent(){} // RVA: 0x7FFAC985E3B0
        public void add_defaultReflectionSet(){} // RVA: 0x7FFAC985E430
        public void remove_defaultReflectionSet(){} // RVA: 0x7FFAC985E680
        public void add_defaultReflectionTexture(){} // RVA: 0x7FFAC985E860
        public void remove_defaultReflectionTexture(){} // RVA: 0x7FFAC985EB10
        public void CallSetDefaultReflection(){} // RVA: 0x7FFAC985EBA0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void .cctor(){} // RVA: 0x7FFAC985ED30
        public void get_size_Injected(){} // RVA: 0x7FFAC985EED0
        public void set_size_Injected(){} // RVA: 0x7FFAC985EF30
        public void get_center_Injected(){} // RVA: 0x7FFAC985EF90
        public void set_center_Injected(){} // RVA: 0x7FFAC985EFF0
        public void get_bounds_Injected(){} // RVA: 0x7FFAC985F050
        public void get_backgroundColor_Injected(){} // RVA: 0x7FFAC985F0B0
        public void set_backgroundColor_Injected(){} // RVA: 0x7FFAC985F110
        public void get_textureHDRDecodeValues_Injected(){} // RVA: 0x7FFAC985F170
        public void get_defaultTextureHDRDecodeValues_Injected(){} // RVA: 0x7FFAC985F1D0
    }

    public class RefreshRate : ValueType
    {
        public uint value; // 0x10
        public uint denominator; // 0x14

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC986BFA0
        public void Equals(){} // RVA: 0x7FFAC986BFC0
        public void CompareTo(){} // RVA: 0x7FFAC986C000
        public void ToString(){} // RVA: 0x7FFAC986C050
    }

    public class RejectDragAndDropMaterial : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RelativeJoint2D : Joint2D
    {
        public object maxForce;
        public object maxTorque;
        public object correctionScale;
        public object autoConfigureOffset;
        public object linearOffset;
        public object angularOffset;
        public object target;

        // ── Methods ──
        public void get_maxForce(){} // RVA: 0x7FFAC9984020
        public void set_maxForce(){} // RVA: 0x7FFAC9984070
        public void get_maxTorque(){} // RVA: 0x7FFAC99840D0
        public void set_maxTorque(){} // RVA: 0x7FFAC9984120
        public void get_correctionScale(){} // RVA: 0x7FFAC9984180
        public void set_correctionScale(){} // RVA: 0x7FFAC99841D0
        public void get_autoConfigureOffset(){} // RVA: 0x7FFAC9984230
        public void set_autoConfigureOffset(){} // RVA: 0x7FFAC9984280
        public void get_linearOffset(){} // RVA: 0x7FFAC99842E0
        public void set_linearOffset(){} // RVA: 0x7FFAC9984340
        public void get_angularOffset(){} // RVA: 0x7FFAC99843A0
        public void set_angularOffset(){} // RVA: 0x7FFAC99843F0
        public void get_target(){} // RVA: 0x7FFAC9984450
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_linearOffset_Injected(){} // RVA: 0x7FFAC99844B0
        public void set_linearOffset_Injected(){} // RVA: 0x7FFAC9984510
        public void get_target_Injected(){} // RVA: 0x7FFAC9984570
    }

    public class RemoteConfigSettings : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public System.Action`1<bool> Updated; // 0x18

        // ── Methods ──
        public void RemoteConfigSettingsUpdated(){} // RVA: 0x7FFAC9C8E150
    }

    public class RemoteConfigSettingsHelper : Object
    {
    }

    public class RemoteSettings : Object
    {
        public UpdatedEventHandler Updated;
        public System.Action BeforeFetchFromServer; // 0x8
        public System.Action`3<bool,bool,int> Completed; // 0x10

        // ── Methods ──
        public void RemoteSettingsUpdated(){} // RVA: 0x7FFAC9C8E010
        public void RemoteSettingsBeforeFetchFromServer(){} // RVA: 0x7FFAC9C8E070
        public void RemoteSettingsUpdateCompleted(){} // RVA: 0x7FFAC9C8E0D0
    }

    public class RenderBuffer : ValueType
    {
        public int m_RenderTextureInstanceID; // 0x10
        public UIntPtr m_BufferPtr; // 0x18
    }

    public class RenderInstancedDataLayout : ValueType
    {
        public int <size>k__BackingField; // 0x10
        public int <offsetObjectToWorld>k__BackingField; // 0x14
        public int <offsetPrevObjectToWorld>k__BackingField; // 0x18
        public int <offsetRenderingLayerMask>k__BackingField; // 0x1C
    }

    public class RenderParams : ValueType
    {
        public int layer; // 0x10
        public uint renderingLayerMask; // 0x14
        public int rendererPriority; // 0x18
        public UnityEngine.Bounds worldBounds; // 0x1C
        public UnityEngine.Camera camera; // 0x38
        public 0x6B17C758 motionVectorMode; // 0x40
        public 0x6B186BA8 reflectionProbeUsage; // 0x44
        public UnityEngine.Material material; // 0x48
        public UnityEngine.MaterialPropertyBlock matProps; // 0x50
        public 0x6B186940 shadowCastingMode; // 0x58
        public bool receiveShadows; // 0x5C
        public 0x6B186E68 lightProbeUsage; // 0x60
        public UnityEngine.LightProbeProxyVolume lightProbeProxyVolume; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9872230
        public void set_layer(){} // RVA: 0x7FFAC336D8B0
        public void set_renderingLayerMask(){} // RVA: 0x7FFAC4420230
        public void set_rendererPriority(){} // RVA: 0x7FFAC49C7510
        public void set_worldBounds(){} // RVA: 0x7FFAC98724C0
        public void set_camera(){} // RVA: 0x7FFAC2F22E90
        public void set_motionVectorMode(){} // RVA: 0x7FFAC2F7CCE0
        public void set_reflectionProbeUsage(){} // RVA: 0x7FFAC416A6E0
        public void set_material(){} // RVA: 0x7FFAC31D0C20
        public void get_matProps(){} // RVA: 0x7FFAC2F9E740
        public void set_matProps(){} // RVA: 0x7FFAC2F49200
        public void set_shadowCastingMode(){} // RVA: 0x7FFAC2FC20D0
        public void set_receiveShadows(){} // RVA: 0x7FFAC416A6F0
        public void set_lightProbeUsage(){} // RVA: 0x7FFAC31D9010
        public void set_lightProbeProxyVolume(){} // RVA: 0x7FFAC2FE9510
    }

    public class RenderSettings : Object
    {
        public object fog;
        public object fogStartDistance;
        public object fogEndDistance;
        public object fogMode;
        public object fogColor;
        public object fogDensity;
        public object ambientMode;
        public object ambientSkyColor;
        public object ambientEquatorColor;
        public object ambientGroundColor;
        public object ambientIntensity;
        public object ambientLight;
        public object subtractiveShadowColor;
        public object skybox;
        public object sun;
        public object ambientProbe;
        public object customReflectionTexture;
        public object reflectionIntensity;
        public object reflectionBounces;
        public object defaultReflectionMode;
        public object defaultReflectionResolution;
        public object haloStrength;
        public object flareStrength;
        public object flareFadeSpeed;

        // ── Methods ──
        public void get_fog(){} // RVA: 0x7FFAC987EA10
        public void set_fog(){} // RVA: 0x7FFAC987EA60
        public void get_fogStartDistance(){} // RVA: 0x7FFAC987EAB0
        public void set_fogStartDistance(){} // RVA: 0x7FFAC987EB00
        public void get_fogEndDistance(){} // RVA: 0x7FFAC987EB60
        public void set_fogEndDistance(){} // RVA: 0x7FFAC987EBB0
        public void get_fogMode(){} // RVA: 0x7FFAC987EC10
        public void set_fogMode(){} // RVA: 0x7FFAC987EC60
        public void get_fogColor(){} // RVA: 0x7FFAC987ECB0
        public void set_fogColor(){} // RVA: 0x7FFAC987ED10
        public void get_fogDensity(){} // RVA: 0x7FFAC987ED60
        public void set_fogDensity(){} // RVA: 0x7FFAC987EDB0
        public void get_ambientMode(){} // RVA: 0x7FFAC987EE10
        public void set_ambientMode(){} // RVA: 0x7FFAC987EE60
        public void get_ambientSkyColor(){} // RVA: 0x7FFAC987EEB0
        public void set_ambientSkyColor(){} // RVA: 0x7FFAC987EF10
        public void get_ambientEquatorColor(){} // RVA: 0x7FFAC987EF60
        public void set_ambientEquatorColor(){} // RVA: 0x7FFAC987EFC0
        public void get_ambientGroundColor(){} // RVA: 0x7FFAC987F010
        public void set_ambientGroundColor(){} // RVA: 0x7FFAC987F070
        public void get_ambientIntensity(){} // RVA: 0x7FFAC987F0C0
        public void set_ambientIntensity(){} // RVA: 0x7FFAC987F110
        public void get_ambientLight(){} // RVA: 0x7FFAC987F170
        public void set_ambientLight(){} // RVA: 0x7FFAC987F1D0
        public void get_subtractiveShadowColor(){} // RVA: 0x7FFAC987F220
        public void set_subtractiveShadowColor(){} // RVA: 0x7FFAC987F280
        public void get_skybox(){} // RVA: 0x7FFAC987F2D0
        public void set_skybox(){} // RVA: 0x7FFAC987F320
        public void get_sun(){} // RVA: 0x7FFAC987F370
        public void set_sun(){} // RVA: 0x7FFAC987F3C0
        public void get_ambientProbe(){} // RVA: 0x7FFAC987F410
        public void set_ambientProbe(){} // RVA: 0x7FFAC987F490
        public void get_customReflectionTexture(){} // RVA: 0x7FFAC987F4E0
        public void set_customReflectionTexture(){} // RVA: 0x7FFAC987F530
        public void get_reflectionIntensity(){} // RVA: 0x7FFAC987F580
        public void set_reflectionIntensity(){} // RVA: 0x7FFAC987F5D0
        public void get_reflectionBounces(){} // RVA: 0x7FFAC987F630
        public void set_reflectionBounces(){} // RVA: 0x7FFAC987F680
        public void get_defaultReflectionMode(){} // RVA: 0x7FFAC987F6D0
        public void set_defaultReflectionMode(){} // RVA: 0x7FFAC987F720
        public void get_defaultReflectionResolution(){} // RVA: 0x7FFAC987F770
        public void set_defaultReflectionResolution(){} // RVA: 0x7FFAC987F7C0
        public void get_haloStrength(){} // RVA: 0x7FFAC987F810
        public void set_haloStrength(){} // RVA: 0x7FFAC987F860
        public void get_flareStrength(){} // RVA: 0x7FFAC987F8C0
        public void set_flareStrength(){} // RVA: 0x7FFAC987F910
        public void get_flareFadeSpeed(){} // RVA: 0x7FFAC987F970
        public void set_flareFadeSpeed(){} // RVA: 0x7FFAC987F9C0
        public void get_fogColor_Injected(){} // RVA: 0x7FFAC987FA20
        public void set_fogColor_Injected(){} // RVA: 0x7FFAC987FA70
        public void get_ambientSkyColor_Injected(){} // RVA: 0x7FFAC987FAC0
        public void set_ambientSkyColor_Injected(){} // RVA: 0x7FFAC987FB10
        public void get_ambientEquatorColor_Injected(){} // RVA: 0x7FFAC987FB60
        public void set_ambientEquatorColor_Injected(){} // RVA: 0x7FFAC987FBB0
        public void get_ambientGroundColor_Injected(){} // RVA: 0x7FFAC987FC00
        public void set_ambientGroundColor_Injected(){} // RVA: 0x7FFAC987FC50
        public void get_ambientLight_Injected(){} // RVA: 0x7FFAC987FCA0
        public void set_ambientLight_Injected(){} // RVA: 0x7FFAC987FCF0
        public void get_subtractiveShadowColor_Injected(){} // RVA: 0x7FFAC987FD40
        public void set_subtractiveShadowColor_Injected(){} // RVA: 0x7FFAC987FD90
        public void get_ambientProbe_Injected(){} // RVA: 0x7FFAC987FDE0
        public void set_ambientProbe_Injected(){} // RVA: 0x7FFAC987FE30
    }

    public class RenderTexture : Texture
    {
        public object width;
        public object height;
        public object dimension;
        public object graphicsFormat;
        public object useMipMap;
        public object sRGB;
        public object vrUsage;
        public object memorylessMode;
        public object format;
        public object stencilFormat;
        public object depthStencilFormat;
        public object autoGenerateMips;
        public object volumeDepth;
        public object antiAliasing;
        public object bindTextureMS;
        public object enableRandomWrite;
        public object useDynamicScale;
        public object isPowerOfTwo;
        public object active;
        public object colorBuffer;
        public object depthBuffer;
        public object depth;
        public object descriptor;
        public object isCubemap;
        public object isVolume;
        public object enabled;

        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFAC98A0FD0
        public void set_width(){} // RVA: 0x7FFAC98A1020
        public void get_height(){} // RVA: 0x7FFAC98A1080
        public void set_height(){} // RVA: 0x7FFAC98A10D0
        public void get_dimension(){} // RVA: 0x7FFAC98A1130
        public void set_dimension(){} // RVA: 0x7FFAC98A1180
        public void GetColorFormat(){} // RVA: 0x7FFAC98A11E0
        public void SetColorFormat(){} // RVA: 0x7FFAC98A1240
        public void get_graphicsFormat(){} // RVA: 0x7FFAC98A12A0
        public void set_graphicsFormat(){} // RVA: 0x7FFAC98A1240
        public void get_useMipMap(){} // RVA: 0x7FFAC98A1300
        public void set_useMipMap(){} // RVA: 0x7FFAC98A1350
        public void get_sRGB(){} // RVA: 0x7FFAC98A13B0
        public void get_vrUsage(){} // RVA: 0x7FFAC98A1400
        public void set_vrUsage(){} // RVA: 0x7FFAC98A1450
        public void get_memorylessMode(){} // RVA: 0x7FFAC98A14B0
        public void set_memorylessMode(){} // RVA: 0x7FFAC98A1500
        public void get_format(){} // RVA: 0x7FFAC98A1560
        public void set_format(){} // RVA: 0x7FFAC98A16F0
        public void get_stencilFormat(){} // RVA: 0x7FFAC98A17E0
        public void set_stencilFormat(){} // RVA: 0x7FFAC98A1830
        public void get_depthStencilFormat(){} // RVA: 0x7FFAC98A1890
        public void set_depthStencilFormat(){} // RVA: 0x7FFAC98A18E0
        public void get_autoGenerateMips(){} // RVA: 0x7FFAC98A1940
        public void set_autoGenerateMips(){} // RVA: 0x7FFAC98A1990
        public void get_volumeDepth(){} // RVA: 0x7FFAC98A19F0
        public void set_volumeDepth(){} // RVA: 0x7FFAC98A1A40
        public void get_antiAliasing(){} // RVA: 0x7FFAC98A1AA0
        public void set_antiAliasing(){} // RVA: 0x7FFAC98A1AF0
        public void get_bindTextureMS(){} // RVA: 0x7FFAC98A1B50
        public void set_bindTextureMS(){} // RVA: 0x7FFAC98A1BA0
        public void get_enableRandomWrite(){} // RVA: 0x7FFAC98A1C00
        public void set_enableRandomWrite(){} // RVA: 0x7FFAC98A1C50
        public void get_useDynamicScale(){} // RVA: 0x7FFAC98A1CB0
        public void set_useDynamicScale(){} // RVA: 0x7FFAC98A1D00
        public void GetIsPowerOfTwo(){} // RVA: 0x7FFAC98A1D60
        public void get_isPowerOfTwo(){} // RVA: 0x7FFAC98A1D60
        public void set_isPowerOfTwo(){} // RVA: 0x7FFAC2F21310
        public void GetActive(){} // RVA: 0x7FFAC98A1DB0
        public void SetActive(){} // RVA: 0x7FFAC98A1E00
        public void get_active(){} // RVA: 0x7FFAC98A1DB0
        public void set_active(){} // RVA: 0x7FFAC98A1E00
        public void GetColorBuffer(){} // RVA: 0x7FFAC98A1E50
        public void GetDepthBuffer(){} // RVA: 0x7FFAC98A1EC0
        public void SetMipMapCount(){} // RVA: 0x7FFAC98A1F30
        public void SetShadowSamplingMode(){} // RVA: 0x7FFAC98A1F90
        public void get_colorBuffer(){} // RVA: 0x7FFAC98A1FF0
        public void get_depthBuffer(){} // RVA: 0x7FFAC98A2070
        public void GetNativeDepthBufferPtr(){} // RVA: 0x7FFAC98A20F0
        public void DiscardContents(){} // RVA: 0x7FFAC98A2210 | overloaded x2
        public void MarkRestoreExpected(){} // RVA: 0x7FFAC98A21C0
        public void ResolveAA(){} // RVA: 0x7FFAC98A2270
        public void ResolveAATo(){} // RVA: 0x7FFAC98A22C0
        public void ResolveAntiAliasedSurface(){} // RVA: 0x7FFAC98A22C0 | overloaded x2
        public void SetGlobalShaderProperty(){} // RVA: 0x7FFAC98A2320
        public void Create(){} // RVA: 0x7FFAC98A2380
        public void Release(){} // RVA: 0x7FFAC98A23D0
        public void IsCreated(){} // RVA: 0x7FFAC98A2420
        public void GenerateMips(){} // RVA: 0x7FFAC98A2470
        public void ConvertToEquirect(){} // RVA: 0x7FFAC98A24C0
        public void SetSRGBReadWrite(){} // RVA: 0x7FFAC98A2530
        public void Internal_Create(){} // RVA: 0x7FFAC98A2590
        public void SupportsStencil(){} // RVA: 0x7FFAC98A25E0
        public void SetRenderTextureDescriptor(){} // RVA: 0x7FFAC98A2630
        public void GetDescriptor(){} // RVA: 0x7FFAC98A2690
        public void GetTemporary_Internal(){} // RVA: 0x7FFAC98A2710
        public void ReleaseTemporary(){} // RVA: 0x7FFAC98A2760
        public void get_depth(){} // RVA: 0x7FFAC98A27B0
        public void set_depth(){} // RVA: 0x7FFAC98A2800
        public void .ctor(){} // RVA: 0x7FFAC98A3700 | overloaded x12
        public void Initialize(){} // RVA: 0x7FFAC98A37D0
        public void GetDepthStencilFormatLegacy(){} // RVA: 0x7FFAC98A3B00 | overloaded x4
        public void get_descriptor(){} // RVA: 0x7FFAC98A3B90
        public void set_descriptor(){} // RVA: 0x7FFAC98A3C40
        public void ValidateRenderTextureDesc(){} // RVA: 0x7FFAC98A3D00
        public void GetDefaultColorFormat(){} // RVA: 0x7FFAC98A4290
        public void GetDefaultDepthStencilFormat(){} // RVA: 0x7FFAC98A4300
        public void GetCompatibleFormat(){} // RVA: 0x7FFAC98A4370
        public void GetTemporary(){} // RVA: 0x7FFAC98A4D10 | overloaded x14
        public void GetTemporaryImpl(){} // RVA: 0x7FFAC98A45E0
        public void get_isCubemap(){} // RVA: 0x7FFAC98A4D40
        public void set_isCubemap(){} // RVA: 0x7FFAC98A4D70
        public void get_isVolume(){} // RVA: 0x7FFAC98A4DB0
        public void set_isVolume(){} // RVA: 0x7FFAC98A4DE0
        public void get_enabled(){} // RVA: 0x7FFAC4BF82C0
        public void set_enabled(){} // RVA: 0x7FFAC2F21310
        public void GetTexelOffset(){} // RVA: 0x7FFAC2F460A0
        public void GetColorBuffer_Injected(){} // RVA: 0x7FFAC98A4E10
        public void GetDepthBuffer_Injected(){} // RVA: 0x7FFAC98A4E70
        public void SetRenderTextureDescriptor_Injected(){} // RVA: 0x7FFAC98A4ED0
        public void GetDescriptor_Injected(){} // RVA: 0x7FFAC98A4F30
        public void GetTemporary_Internal_Injected(){} // RVA: 0x7FFAC98A4F90
    }

    public class RenderTextureDescriptor : ValueType
    {
        public int width; // 0x10
        public int height; // 0x14
        public int msaaSamples; // 0x18
        public int volumeDepth; // 0x1C
        public int mipCount; // 0x20
        public 0x6B189648 graphicsFormat; // 0x24
        public 0x6B189648 depthStencilFormat; // 0x28
        public 0x6B189648 colorFormat; // 0x2C
        public 0x6B186F70 sRGB; // 0x30
        public 0x6B186E10 depthBufferBits; // 0x34
        public 0x6B17C1D8 dimension; // 0x38
        public 0x6B17C230 shadowSamplingMode; // 0x3C
        public 0x6B17C2E0 vrUsage; // 0x40

        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFAC4420210
        public void set_width(){} // RVA: 0x7FFAC336D8B0
        public void get_height(){} // RVA: 0x7FFAC44202A0
        public void set_height(){} // RVA: 0x7FFAC4420230
        public void get_msaaSamples(){} // RVA: 0x7FFAC49C7500
        public void set_msaaSamples(){} // RVA: 0x7FFAC49C7510
        public void get_volumeDepth(){} // RVA: 0x7FFAC49C7520
        public void set_volumeDepth(){} // RVA: 0x7FFAC49C7530
        public void get_mipCount(){} // RVA: 0x7FFAC2F6E5C0
        public void set_mipCount(){} // RVA: 0x7FFAC2F240C0
        public void get_graphicsFormat(){} // RVA: 0x7FFAC5872100
        public void set_graphicsFormat(){} // RVA: 0x7FFAC98A62C0
        public void get_depthStencilFormat(){} // RVA: 0x7FFAC44357F0
        public void set_depthStencilFormat(){} // RVA: 0x7FFAC44474D0
        public void get_colorFormat(){} // RVA: 0x7FFAC98A6380
        public void set_colorFormat(){} // RVA: 0x7FFAC98A6430
        public void get_sRGB(){} // RVA: 0x7FFAC98A6500
        public void set_sRGB(){} // RVA: 0x7FFAC98A6590
        public void get_depthBufferBits(){} // RVA: 0x7FFAC98A6700
        public void set_depthBufferBits(){} // RVA: 0x7FFAC98A6790
        public void get_dimension(){} // RVA: 0x7FFAC30DBBE0
        public void set_dimension(){} // RVA: 0x7FFAC35DB7A0
        public void get_shadowSamplingMode(){} // RVA: 0x7FFAC3921980
        public void set_shadowSamplingMode(){} // RVA: 0x7FFAC41674D0
        public void get_vrUsage(){} // RVA: 0x7FFAC32EC4C0
        public void set_vrUsage(){} // RVA: 0x7FFAC369A6E0
        public void get_flags(){} // RVA: 0x7FFAC9814E40
        public void get_memoryless(){} // RVA: 0x7FFAC2F7CCD0
        public void set_memoryless(){} // RVA: 0x7FFAC2F7CCE0
        public void .ctor(){} // RVA: 0x7FFAC98A6C80 | overloaded x9
        public void SetOrClearRenderTextureCreationFlag(){} // RVA: 0x7FFAC98A6CF0
        public void get_useMipMap(){} // RVA: 0x7FFAC98A6D10
        public void set_useMipMap(){} // RVA: 0x7FFAC98A6D20
        public void get_autoGenerateMips(){} // RVA: 0x7FFAC98A6D40
        public void set_autoGenerateMips(){} // RVA: 0x7FFAC98A6D50
        public void get_enableRandomWrite(){} // RVA: 0x7FFAC98A6D70
        public void set_enableRandomWrite(){} // RVA: 0x7FFAC98A6D80
        public void get_bindMS(){} // RVA: 0x7FFAC98A6DA0
        public void set_bindMS(){} // RVA: 0x7FFAC98A6DB0
        public void set_createdFromScript(){} // RVA: 0x7FFAC98A6DD0
        public void get_useDynamicScale(){} // RVA: 0x7FFAC98A6DF0
        public void set_useDynamicScale(){} // RVA: 0x7FFAC98A6E00
    }

    public class Renderer : Component
    {
        public object castShadows;
        public object motionVectors;
        public object useLightProbes;
        public object bounds;
        public object localBounds;
        public object enabled;
        public object isVisible;
        public object shadowCastingMode;
        public object receiveShadows;
        public object forceRenderingOff;
        public object staticShadowCaster;
        public object motionVectorGenerationMode;
        public object lightProbeUsage;
        public object reflectionProbeUsage;
        public object renderingLayerMask;
        public object rendererPriority;
        public object rayTracingMode;
        public object sortingLayerName;
        public object sortingLayerID;
        public object sortingOrder;
        public object sortingKey;
        public object sortingGroupID;
        public object sortingGroupOrder;
        public object sortingGroupKey;
        public object allowOcclusionWhenDynamic;
        public object staticBatchRootTransform;
        public object staticBatchIndex;
        public object isPartOfStaticBatch;
        public object worldToLocalMatrix;
        public object localToWorldMatrix;
        public object lightProbeProxyVolumeOverride;
        public object probeAnchor;
        public object lightmapIndex;
        public object realtimeLightmapIndex;
        public object lightmapScaleOffset;
        public object realtimeLightmapScaleOffset;
        public object materials;
        public object material;
        public object sharedMaterial;
        public object sharedMaterials;

        // ── Methods ──
        public void get_castShadows(){} // RVA: 0x7FFAC987C1C0
        public void set_castShadows(){} // RVA: 0x7FFAC987C220
        public void get_motionVectors(){} // RVA: 0x7FFAC987C290
        public void set_motionVectors(){} // RVA: 0x7FFAC987C2F0
        public void get_useLightProbes(){} // RVA: 0x7FFAC987C360
        public void set_useLightProbes(){} // RVA: 0x7FFAC987C3C0
        public void get_bounds(){} // RVA: 0x7FFAC987C430
        public void set_bounds(){} // RVA: 0x7FFAC987C4A0
        public void get_localBounds(){} // RVA: 0x7FFAC987C500
        public void set_localBounds(){} // RVA: 0x7FFAC987C570
        public void ResetBounds(){} // RVA: 0x7FFAC987C5D0
        public void ResetLocalBounds(){} // RVA: 0x7FFAC987C620
        public void SetStaticLightmapST(){} // RVA: 0x7FFAC987C670
        public void GetMaterial(){} // RVA: 0x7FFAC987C6D0
        public void GetSharedMaterial(){} // RVA: 0x7FFAC987C720
        public void SetMaterial(){} // RVA: 0x7FFAC987C770
        public void GetMaterialArray(){} // RVA: 0x7FFAC987C7D0
        public void CopyMaterialArray(){} // RVA: 0x7FFAC987C820
        public void CopySharedMaterialArray(){} // RVA: 0x7FFAC987C880
        public void SetMaterialArray(){} // RVA: 0x7FFAC987C950 | overloaded x2
        public void Internal_SetPropertyBlock(){} // RVA: 0x7FFAC987C980
        public void Internal_GetPropertyBlock(){} // RVA: 0x7FFAC987C9E0
        public void Internal_SetPropertyBlockMaterialIndex(){} // RVA: 0x7FFAC987CA40
        public void Internal_GetPropertyBlockMaterialIndex(){} // RVA: 0x7FFAC987CAB0
        public void HasPropertyBlock(){} // RVA: 0x7FFAC987CB20
        public void SetPropertyBlock(){} // RVA: 0x7FFAC987CA40 | overloaded x2
        public void GetPropertyBlock(){} // RVA: 0x7FFAC987CAB0 | overloaded x2
        public void GetClosestReflectionProbesInternal(){} // RVA: 0x7FFAC987CB70
        public void get_enabled(){} // RVA: 0x7FFAC987CBD0
        public void set_enabled(){} // RVA: 0x7FFAC987CC20
        public void get_isVisible(){} // RVA: 0x7FFAC987CC80
        public void get_shadowCastingMode(){} // RVA: 0x7FFAC987CCD0
        public void set_shadowCastingMode(){} // RVA: 0x7FFAC987CD20
        public void get_receiveShadows(){} // RVA: 0x7FFAC987CD80
        public void set_receiveShadows(){} // RVA: 0x7FFAC987CDD0
        public void get_forceRenderingOff(){} // RVA: 0x7FFAC987CE30
        public void set_forceRenderingOff(){} // RVA: 0x7FFAC987CE80
        public void GetIsStaticShadowCaster(){} // RVA: 0x7FFAC987CEE0
        public void SetIsStaticShadowCaster(){} // RVA: 0x7FFAC987CF30
        public void get_staticShadowCaster(){} // RVA: 0x7FFAC987CEE0
        public void set_staticShadowCaster(){} // RVA: 0x7FFAC987CF30
        public void get_motionVectorGenerationMode(){} // RVA: 0x7FFAC987CF90
        public void set_motionVectorGenerationMode(){} // RVA: 0x7FFAC987CFE0
        public void get_lightProbeUsage(){} // RVA: 0x7FFAC987D040
        public void set_lightProbeUsage(){} // RVA: 0x7FFAC987D090
        public void get_reflectionProbeUsage(){} // RVA: 0x7FFAC987D0F0
        public void set_reflectionProbeUsage(){} // RVA: 0x7FFAC987D140
        public void get_renderingLayerMask(){} // RVA: 0x7FFAC987D1A0
        public void set_renderingLayerMask(){} // RVA: 0x7FFAC987D1F0
        public void get_rendererPriority(){} // RVA: 0x7FFAC987D250
        public void set_rendererPriority(){} // RVA: 0x7FFAC987D2A0
        public void get_rayTracingMode(){} // RVA: 0x7FFAC987D300
        public void set_rayTracingMode(){} // RVA: 0x7FFAC987D350
        public void get_sortingLayerName(){} // RVA: 0x7FFAC987D3B0
        public void set_sortingLayerName(){} // RVA: 0x7FFAC987D400
        public void get_sortingLayerID(){} // RVA: 0x7FFAC987D460
        public void set_sortingLayerID(){} // RVA: 0x7FFAC987D4B0
        public void get_sortingOrder(){} // RVA: 0x7FFAC987D510
        public void set_sortingOrder(){} // RVA: 0x7FFAC987D560
        public void get_sortingKey(){} // RVA: 0x7FFAC987D5C0
        public void get_sortingGroupID(){} // RVA: 0x7FFAC987D610
        public void set_sortingGroupID(){} // RVA: 0x7FFAC987D660
        public void get_sortingGroupOrder(){} // RVA: 0x7FFAC987D6C0
        public void set_sortingGroupOrder(){} // RVA: 0x7FFAC987D710
        public void get_sortingGroupKey(){} // RVA: 0x7FFAC987D770
        public void get_allowOcclusionWhenDynamic(){} // RVA: 0x7FFAC987D7C0
        public void set_allowOcclusionWhenDynamic(){} // RVA: 0x7FFAC987D810
        public void get_staticBatchRootTransform(){} // RVA: 0x7FFAC987D870
        public void set_staticBatchRootTransform(){} // RVA: 0x7FFAC987D8C0
        public void get_staticBatchIndex(){} // RVA: 0x7FFAC987D920
        public void SetStaticBatchInfo(){} // RVA: 0x7FFAC987D970
        public void get_isPartOfStaticBatch(){} // RVA: 0x7FFAC987D9E0
        public void get_worldToLocalMatrix(){} // RVA: 0x7FFAC987DA30
        public void get_localToWorldMatrix(){} // RVA: 0x7FFAC987DAB0
        public void get_lightProbeProxyVolumeOverride(){} // RVA: 0x7FFAC987DB30
        public void set_lightProbeProxyVolumeOverride(){} // RVA: 0x7FFAC987DB80
        public void get_probeAnchor(){} // RVA: 0x7FFAC987DBE0
        public void set_probeAnchor(){} // RVA: 0x7FFAC987DC30
        public void GetLightmapIndex(){} // RVA: 0x7FFAC987DC90
        public void SetLightmapIndex(){} // RVA: 0x7FFAC987DCF0
        public void GetLightmapST(){} // RVA: 0x7FFAC987DD60
        public void SetLightmapST(){} // RVA: 0x7FFAC987DDE0
        public void get_lightmapIndex(){} // RVA: 0x7FFAC987DE50
        public void set_lightmapIndex(){} // RVA: 0x7FFAC987DEB0
        public void get_realtimeLightmapIndex(){} // RVA: 0x7FFAC987DF10
        public void set_realtimeLightmapIndex(){} // RVA: 0x7FFAC987DF70
        public void get_lightmapScaleOffset(){} // RVA: 0x7FFAC987DFE0
        public void set_lightmapScaleOffset(){} // RVA: 0x7FFAC987E060
        public void get_realtimeLightmapScaleOffset(){} // RVA: 0x7FFAC987E0C0
        public void set_realtimeLightmapScaleOffset(){} // RVA: 0x7FFAC987E140
        public void GetMaterialCount(){} // RVA: 0x7FFAC987E1B0
        public void GetSharedMaterialArray(){} // RVA: 0x7FFAC987E200
        public void get_materials(){} // RVA: 0x7FFAC987C7D0
        public void set_materials(){} // RVA: 0x7FFAC987C950
        public void get_material(){} // RVA: 0x7FFAC987C6D0
        public void set_material(){} // RVA: 0x7FFAC987C770
        public void get_sharedMaterial(){} // RVA: 0x7FFAC987C720
        public void set_sharedMaterial(){} // RVA: 0x7FFAC987C770
        public void get_sharedMaterials(){} // RVA: 0x7FFAC987E200
        public void set_sharedMaterials(){} // RVA: 0x7FFAC987C950
        public void GetMaterials(){} // RVA: 0x7FFAC987E250
        public void SetSharedMaterials(){} // RVA: 0x7FFAC987E3A0
        public void SetMaterials(){} // RVA: 0x7FFAC987E470
        public void GetSharedMaterials(){} // RVA: 0x7FFAC987E540
        public void GetClosestReflectionProbes(){} // RVA: 0x7FFAC987CB70
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_bounds_Injected(){} // RVA: 0x7FFAC987E690
        public void set_bounds_Injected(){} // RVA: 0x7FFAC987E6F0
        public void get_localBounds_Injected(){} // RVA: 0x7FFAC987E750
        public void set_localBounds_Injected(){} // RVA: 0x7FFAC987E7B0
        public void SetStaticLightmapST_Injected(){} // RVA: 0x7FFAC987E810
        public void get_worldToLocalMatrix_Injected(){} // RVA: 0x7FFAC987E870
        public void get_localToWorldMatrix_Injected(){} // RVA: 0x7FFAC987E8D0
        public void GetLightmapST_Injected(){} // RVA: 0x7FFAC987E930
        public void SetLightmapST_Injected(){} // RVA: 0x7FFAC987E9A0
    }

    public class RendererExtensions : Object
    {
        // ── Methods ──
        public void UpdateGIMaterials(){} // RVA: 0x7FFAC9873480
        public void UpdateGIMaterialsForRenderer(){} // RVA: 0x7FFAC9873480
    }

    public class RequireComponent : Attribute
    {
        public System.Type m_Type0; // 0x10
        public System.Type m_Type1; // 0x18
        public System.Type m_Type2; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
    }

    public class Resolution : ValueType
    {
        public int width; // 0x10
        public int height; // 0x14
        public UnityEngine.RefreshRate refreshRateRatio; // 0x18

        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFAC8F93F90
        public void set_width(){} // RVA: 0x7FFAC336D8B0
        public void get_height(){} // RVA: 0x7FFAC69CBEA0
        public void set_height(){} // RVA: 0x7FFAC4420230
        public void get_refreshRateRatio(){} // RVA: 0x7FFAC86B4B80
        public void get_refreshRate(){} // RVA: 0x7FFAC9871FF0
        public void set_refreshRate(){} // RVA: 0x7FFAC9872070
        public void ToString(){} // RVA: 0x7FFAC9872080
    }

    public class ResourceRequest : AsyncOperation
    {
        public string asset; // 0x20
        public System.Type m_Type; // 0x28

        // ── Methods ──
        public void GetResult(){} // RVA: 0x7FFAC98B8980
        public void get_asset(){} // RVA: 0x7FFAC2FD5BC0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Resources : Object
    {
        // ── Methods ──
        public void ConvertObjects(){} // RVA: 0x7FFAC2C58F80
        public void FindObjectsOfTypeAll(){} // RVA: 0x7FFAC2C58A90 | overloaded x2
        public void Load(){} // RVA: 0x7FFAC98B90D0 | overloaded x3
        public void LoadAsync(){} // RVA: 0x7FFAC98B9220 | overloaded x3
        public void GetBuiltinResource(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void UnloadAsset(){} // RVA: 0x7FFAC98B9300
        public void UnloadUnusedAssets(){} // RVA: 0x7FFAC98B9370
    }

    public class ResourcesAPI : Object
    {
        public UnityEngine.ResourcesAPI ActiveAPI;
        public UnityEngine.ResourcesAPI overrideAPI; // 0x8

        // ── Methods ──
        public void get_ActiveAPI(){} // RVA: 0x7FFAC98B8B50
        public void get_overrideAPI(){} // RVA: 0x7FFAC98B8C10
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void FindObjectsOfTypeAll(){} // RVA: 0x7FFAC98B8C70
        public void FindShaderByName(){} // RVA: 0x7FFAC98B8CC0
        public void Load(){} // RVA: 0x7FFAC98B8D10
        public void LoadAsync(){} // RVA: 0x7FFAC98B8D70
        public void UnloadAsset(){} // RVA: 0x7FFAC98B8EA0
        public void .cctor(){} // RVA: 0x7FFAC98B8EF0
    }

    public class ResourcesAPIInternal : Object
    {
        // ── Methods ──
        public void FindObjectsOfTypeAll(){} // RVA: 0x7FFAC98B89A0
        public void FindShaderByName(){} // RVA: 0x7FFAC98B89F0
        public void Load(){} // RVA: 0x7FFAC98B8A40
        public void LoadAsyncInternal(){} // RVA: 0x7FFAC98B8AA0
        public void UnloadAsset(){} // RVA: 0x7FFAC98B8B00
    }

    public class Rigidbody : Component
    {
        public object velocity;
        public object angularVelocity;
        public object drag;
        public object angularDrag;
        public object mass;
        public object useGravity;
        public object maxDepenetrationVelocity;
        public object isKinematic;
        public object freezeRotation;
        public object constraints;
        public object collisionDetectionMode;
        public object automaticCenterOfMass;
        public object centerOfMass;
        public object worldCenterOfMass;
        public object automaticInertiaTensor;
        public object inertiaTensorRotation;
        public object inertiaTensor;
        public object detectCollisions;
        public object position;
        public object rotation;
        public object interpolation;
        public object solverIterations;
        public object sleepThreshold;
        public object maxAngularVelocity;
        public object maxLinearVelocity;
        public object solverVelocityIterations;
        public object excludeLayers;
        public object includeLayers;
        public object sleepVelocity;
        public object sleepAngularVelocity;
        public object useConeFriction;
        public object solverIterationCount;
        public object solverVelocityIterationCount;

        // ── Methods ──
        public void get_velocity(){} // RVA: 0x7FFAC9994820
        public void set_velocity(){} // RVA: 0x7FFAC9994890
        public void get_angularVelocity(){} // RVA: 0x7FFAC99948F0
        public void set_angularVelocity(){} // RVA: 0x7FFAC9994960
        public void get_drag(){} // RVA: 0x7FFAC99949C0
        public void set_drag(){} // RVA: 0x7FFAC9994A10
        public void get_angularDrag(){} // RVA: 0x7FFAC9994A70
        public void set_angularDrag(){} // RVA: 0x7FFAC9994AC0
        public void get_mass(){} // RVA: 0x7FFAC9994B20
        public void set_mass(){} // RVA: 0x7FFAC9994B70
        public void SetDensity(){} // RVA: 0x7FFAC9994BD0
        public void get_useGravity(){} // RVA: 0x7FFAC9994C30
        public void set_useGravity(){} // RVA: 0x7FFAC9994C80
        public void get_maxDepenetrationVelocity(){} // RVA: 0x7FFAC9994CE0
        public void set_maxDepenetrationVelocity(){} // RVA: 0x7FFAC9994D30
        public void get_isKinematic(){} // RVA: 0x7FFAC9994D90
        public void set_isKinematic(){} // RVA: 0x7FFAC9994DE0
        public void get_freezeRotation(){} // RVA: 0x7FFAC9994E40
        public void set_freezeRotation(){} // RVA: 0x7FFAC9994E90
        public void get_constraints(){} // RVA: 0x7FFAC9994EF0
        public void set_constraints(){} // RVA: 0x7FFAC9994F40
        public void get_collisionDetectionMode(){} // RVA: 0x7FFAC9994FA0
        public void set_collisionDetectionMode(){} // RVA: 0x7FFAC9994FF0
        public void get_automaticCenterOfMass(){} // RVA: 0x7FFAC9995050
        public void set_automaticCenterOfMass(){} // RVA: 0x7FFAC99950A0
        public void get_centerOfMass(){} // RVA: 0x7FFAC9995100
        public void set_centerOfMass(){} // RVA: 0x7FFAC9995170
        public void get_worldCenterOfMass(){} // RVA: 0x7FFAC99951D0
        public void get_automaticInertiaTensor(){} // RVA: 0x7FFAC9995240
        public void set_automaticInertiaTensor(){} // RVA: 0x7FFAC9995290
        public void get_inertiaTensorRotation(){} // RVA: 0x7FFAC99952F0
        public void set_inertiaTensorRotation(){} // RVA: 0x7FFAC9995360
        public void get_inertiaTensor(){} // RVA: 0x7FFAC99953C0
        public void set_inertiaTensor(){} // RVA: 0x7FFAC9995430
        public void get_detectCollisions(){} // RVA: 0x7FFAC9995490
        public void set_detectCollisions(){} // RVA: 0x7FFAC99954E0
        public void get_position(){} // RVA: 0x7FFAC9995540
        public void set_position(){} // RVA: 0x7FFAC99955B0
        public void get_rotation(){} // RVA: 0x7FFAC9995610
        public void set_rotation(){} // RVA: 0x7FFAC9995680
        public void get_interpolation(){} // RVA: 0x7FFAC99956E0
        public void set_interpolation(){} // RVA: 0x7FFAC9995730
        public void get_solverIterations(){} // RVA: 0x7FFAC9995790
        public void set_solverIterations(){} // RVA: 0x7FFAC99957E0
        public void get_sleepThreshold(){} // RVA: 0x7FFAC9995840
        public void set_sleepThreshold(){} // RVA: 0x7FFAC9995890
        public void get_maxAngularVelocity(){} // RVA: 0x7FFAC99958F0
        public void set_maxAngularVelocity(){} // RVA: 0x7FFAC9995940
        public void get_maxLinearVelocity(){} // RVA: 0x7FFAC99959A0
        public void set_maxLinearVelocity(){} // RVA: 0x7FFAC99959F0
        public void MovePosition(){} // RVA: 0x7FFAC9995A50
        public void MoveRotation(){} // RVA: 0x7FFAC9995AB0
        public void Move(){} // RVA: 0x7FFAC9995B10
        public void Sleep(){} // RVA: 0x7FFAC9995B80
        public void IsSleeping(){} // RVA: 0x7FFAC9995BD0
        public void WakeUp(){} // RVA: 0x7FFAC9995C20
        public void ResetCenterOfMass(){} // RVA: 0x7FFAC9995C70
        public void ResetInertiaTensor(){} // RVA: 0x7FFAC9995CC0
        public void GetRelativePointVelocity(){} // RVA: 0x7FFAC9995D10
        public void GetPointVelocity(){} // RVA: 0x7FFAC9995D90
        public void get_solverVelocityIterations(){} // RVA: 0x7FFAC9995E10
        public void set_solverVelocityIterations(){} // RVA: 0x7FFAC9995E60
        public void get_excludeLayers(){} // RVA: 0x7FFAC9995EC0
        public void set_excludeLayers(){} // RVA: 0x7FFAC9995F20
        public void get_includeLayers(){} // RVA: 0x7FFAC9995F80
        public void set_includeLayers(){} // RVA: 0x7FFAC9995FE0
        public void GetAccumulatedForce(){} // RVA: 0x7FFAC99960C0 | overloaded x2
        public void GetAccumulatedTorque(){} // RVA: 0x7FFAC9996220 | overloaded x2
        public void AddForce(){} // RVA: 0x7FFAC9996450 | overloaded x4
        public void AddRelativeForce(){} // RVA: 0x7FFAC9996610 | overloaded x4
        public void AddTorque(){} // RVA: 0x7FFAC99967D0 | overloaded x4
        public void AddRelativeTorque(){} // RVA: 0x7FFAC9996990 | overloaded x4
        public void AddForceAtPosition(){} // RVA: 0x7FFAC9996A80 | overloaded x2
        public void AddExplosionForce(){} // RVA: 0x7FFAC9996C40 | overloaded x3
        public void Internal_ClosestPointOnBounds(){} // RVA: 0x7FFAC9996CE0
        public void ClosestPointOnBounds(){} // RVA: 0x7FFAC9996D60
        public void SweepTest(){} // RVA: 0x7FFAC9997080 | overloaded x4
        public void Internal_SweepTestAll(){} // RVA: 0x7FFAC99970C0
        public void SweepTestAll(){} // RVA: 0x7FFAC9997270 | overloaded x3
        public void get_sleepVelocity(){} // RVA: 0x7FFAC988ADC0
        public void set_sleepVelocity(){} // RVA: 0x7FFAC2F21310
        public void get_sleepAngularVelocity(){} // RVA: 0x7FFAC988ADC0
        public void set_sleepAngularVelocity(){} // RVA: 0x7FFAC2F21310
        public void SetMaxAngularVelocity(){} // RVA: 0x7FFAC9995940
        public void get_useConeFriction(){} // RVA: 0x7FFAC52088B0
        public void set_useConeFriction(){} // RVA: 0x7FFAC2F21310
        public void get_solverIterationCount(){} // RVA: 0x7FFAC9995790
        public void set_solverIterationCount(){} // RVA: 0x7FFAC99957E0
        public void get_solverVelocityIterationCount(){} // RVA: 0x7FFAC9995E10
        public void set_solverVelocityIterationCount(){} // RVA: 0x7FFAC9995E60
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_velocity_Injected(){} // RVA: 0x7FFAC99972B0
        public void set_velocity_Injected(){} // RVA: 0x7FFAC9997310
        public void get_angularVelocity_Injected(){} // RVA: 0x7FFAC9997370
        public void set_angularVelocity_Injected(){} // RVA: 0x7FFAC99973D0
        public void get_centerOfMass_Injected(){} // RVA: 0x7FFAC9997430
        public void set_centerOfMass_Injected(){} // RVA: 0x7FFAC9997490
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x7FFAC99974F0
        public void get_inertiaTensorRotation_Injected(){} // RVA: 0x7FFAC9997550
        public void set_inertiaTensorRotation_Injected(){} // RVA: 0x7FFAC99975B0
        public void get_inertiaTensor_Injected(){} // RVA: 0x7FFAC9997610
        public void set_inertiaTensor_Injected(){} // RVA: 0x7FFAC9997670
        public void get_position_Injected(){} // RVA: 0x7FFAC99976D0
        public void set_position_Injected(){} // RVA: 0x7FFAC9997730
        public void get_rotation_Injected(){} // RVA: 0x7FFAC9997790
        public void set_rotation_Injected(){} // RVA: 0x7FFAC99977F0
        public void MovePosition_Injected(){} // RVA: 0x7FFAC9997850
        public void MoveRotation_Injected(){} // RVA: 0x7FFAC99978B0
        public void Move_Injected(){} // RVA: 0x7FFAC9997910
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x7FFAC9997980
        public void GetPointVelocity_Injected(){} // RVA: 0x7FFAC99979F0
        public void get_excludeLayers_Injected(){} // RVA: 0x7FFAC9997A60
        public void set_excludeLayers_Injected(){} // RVA: 0x7FFAC9997AC0
        public void get_includeLayers_Injected(){} // RVA: 0x7FFAC9997B20
        public void set_includeLayers_Injected(){} // RVA: 0x7FFAC9997B80
        public void GetAccumulatedForce_Injected(){} // RVA: 0x7FFAC9997BE0
        public void GetAccumulatedTorque_Injected(){} // RVA: 0x7FFAC9997C50
        public void AddForce_Injected(){} // RVA: 0x7FFAC9997CC0
        public void AddRelativeForce_Injected(){} // RVA: 0x7FFAC9997D30
        public void AddTorque_Injected(){} // RVA: 0x7FFAC9997DA0
        public void AddRelativeTorque_Injected(){} // RVA: 0x7FFAC9997E10
        public void AddForceAtPosition_Injected(){} // RVA: 0x7FFAC9997E80
        public void AddExplosionForce_Injected(){} // RVA: 0x7FFAC9997F00
        public void Internal_ClosestPointOnBounds_Injected(){} // RVA: 0x7FFAC9997F90
        public void SweepTest_Injected(){} // RVA: 0x7FFAC9998010
        public void Internal_SweepTestAll_Injected(){} // RVA: 0x7FFAC99980A0
    }

    public class Rigidbody2D : Component
    {
        public object position;
        public object rotation;
        public object velocity;
        public object angularVelocity;
        public object useAutoMass;
        public object mass;
        public object sharedMaterial;
        public object centerOfMass;
        public object worldCenterOfMass;
        public object inertia;
        public object drag;
        public object angularDrag;
        public object gravityScale;
        public object bodyType;
        public object useFullKinematicContacts;
        public object isKinematic;
        public object freezeRotation;
        public object constraints;
        public object simulated;
        public object interpolation;
        public object sleepMode;
        public object collisionDetectionMode;
        public object attachedColliderCount;
        public object totalForce;
        public object totalTorque;
        public object excludeLayers;
        public object includeLayers;

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFAC9979710
        public void set_position(){} // RVA: 0x7FFAC9979770
        public void get_rotation(){} // RVA: 0x7FFAC99797D0
        public void set_rotation(){} // RVA: 0x7FFAC9979820
        public void SetRotation(){} // RVA: 0x7FFAC99798E0 | overloaded x2
        public void SetRotation_Angle(){} // RVA: 0x7FFAC9979880
        public void SetRotation_Quaternion(){} // RVA: 0x7FFAC9979940
        public void MovePosition(){} // RVA: 0x7FFAC99799A0
        public void MoveRotation(){} // RVA: 0x7FFAC9979A60 | overloaded x2
        public void MoveRotation_Angle(){} // RVA: 0x7FFAC9979A00
        public void MoveRotation_Quaternion(){} // RVA: 0x7FFAC9979AC0
        public void get_velocity(){} // RVA: 0x7FFAC9979B20
        public void set_velocity(){} // RVA: 0x7FFAC9979B80
        public void get_angularVelocity(){} // RVA: 0x7FFAC9979BE0
        public void set_angularVelocity(){} // RVA: 0x7FFAC9979C30
        public void get_useAutoMass(){} // RVA: 0x7FFAC9979C90
        public void set_useAutoMass(){} // RVA: 0x7FFAC9979CE0
        public void get_mass(){} // RVA: 0x7FFAC9979D40
        public void set_mass(){} // RVA: 0x7FFAC9979D90
        public void get_sharedMaterial(){} // RVA: 0x7FFAC9979DF0
        public void set_sharedMaterial(){} // RVA: 0x7FFAC9979E40
        public void get_centerOfMass(){} // RVA: 0x7FFAC9979EA0
        public void set_centerOfMass(){} // RVA: 0x7FFAC9979F00
        public void get_worldCenterOfMass(){} // RVA: 0x7FFAC9979F60
        public void get_inertia(){} // RVA: 0x7FFAC9979FC0
        public void set_inertia(){} // RVA: 0x7FFAC997A010
        public void get_drag(){} // RVA: 0x7FFAC997A070
        public void set_drag(){} // RVA: 0x7FFAC997A0C0
        public void get_angularDrag(){} // RVA: 0x7FFAC997A120
        public void set_angularDrag(){} // RVA: 0x7FFAC997A170
        public void get_gravityScale(){} // RVA: 0x7FFAC997A1D0
        public void set_gravityScale(){} // RVA: 0x7FFAC997A220
        public void get_bodyType(){} // RVA: 0x7FFAC997A280
        public void set_bodyType(){} // RVA: 0x7FFAC997A2D0
        public void get_useFullKinematicContacts(){} // RVA: 0x7FFAC997A330
        public void set_useFullKinematicContacts(){} // RVA: 0x7FFAC997A380
        public void get_isKinematic(){} // RVA: 0x7FFAC997A3E0
        public void set_isKinematic(){} // RVA: 0x7FFAC997A440
        public void get_freezeRotation(){} // RVA: 0x7FFAC997A4B0
        public void set_freezeRotation(){} // RVA: 0x7FFAC997A500
        public void get_constraints(){} // RVA: 0x7FFAC997A560
        public void set_constraints(){} // RVA: 0x7FFAC997A5B0
        public void IsSleeping(){} // RVA: 0x7FFAC997A610
        public void IsAwake(){} // RVA: 0x7FFAC997A660
        public void Sleep(){} // RVA: 0x7FFAC997A6B0
        public void WakeUp(){} // RVA: 0x7FFAC997A700
        public void get_simulated(){} // RVA: 0x7FFAC997A750
        public void set_simulated(){} // RVA: 0x7FFAC997A7A0
        public void get_interpolation(){} // RVA: 0x7FFAC997A800
        public void set_interpolation(){} // RVA: 0x7FFAC997A850
        public void get_sleepMode(){} // RVA: 0x7FFAC997A8B0
        public void set_sleepMode(){} // RVA: 0x7FFAC997A900
        public void get_collisionDetectionMode(){} // RVA: 0x7FFAC997A960
        public void set_collisionDetectionMode(){} // RVA: 0x7FFAC997A9B0
        public void get_attachedColliderCount(){} // RVA: 0x7FFAC997AA10
        public void get_totalForce(){} // RVA: 0x7FFAC997AA60
        public void set_totalForce(){} // RVA: 0x7FFAC997AAC0
        public void get_totalTorque(){} // RVA: 0x7FFAC997AB20
        public void set_totalTorque(){} // RVA: 0x7FFAC997AB70
        public void get_excludeLayers(){} // RVA: 0x7FFAC997ABD0
        public void set_excludeLayers(){} // RVA: 0x7FFAC997AC30
        public void get_includeLayers(){} // RVA: 0x7FFAC997AC90
        public void set_includeLayers(){} // RVA: 0x7FFAC997ACF0
        public void IsTouching(){} // RVA: 0x7FFAC997AEA0 | overloaded x3
        public void IsTouching_OtherColliderWithFilter_Internal(){} // RVA: 0x7FFAC997AE30
        public void IsTouching_AnyColliderWithFilter_Internal(){} // RVA: 0x7FFAC997AF10
        public void IsTouchingLayers(){} // RVA: 0x7FFAC997AFD0 | overloaded x2
        public void OverlapPoint(){} // RVA: 0x7FFAC997B030
        public void Distance(){} // RVA: 0x7FFAC997B090
        public void Distance_Internal(){} // RVA: 0x7FFAC997B3B0
        public void ClosestPoint(){} // RVA: 0x7FFAC997B430
        public void AddForce(){} // RVA: 0x7FFAC997B500 | overloaded x2
        public void AddRelativeForce(){} // RVA: 0x7FFAC997B5D0 | overloaded x2
        public void AddForceAtPosition(){} // RVA: 0x7FFAC997B6B0 | overloaded x2
        public void AddTorque(){} // RVA: 0x7FFAC997B7A0 | overloaded x2
        public void GetPoint(){} // RVA: 0x7FFAC997B810
        public void GetRelativePoint(){} // RVA: 0x7FFAC997B880
        public void GetVector(){} // RVA: 0x7FFAC997B8F0
        public void GetRelativeVector(){} // RVA: 0x7FFAC997B960
        public void GetPointVelocity(){} // RVA: 0x7FFAC997B9D0
        public void GetRelativePointVelocity(){} // RVA: 0x7FFAC997BA40
        public void OverlapCollider(){} // RVA: 0x7FFAC997BBA0 | overloaded x2
        public void OverlapColliderArray_Internal(){} // RVA: 0x7FFAC997BB30
        public void OverlapColliderList_Internal(){} // RVA: 0x7FFAC997BC20
        public void GetContacts(){} // RVA: 0x7FFAC997C140 | overloaded x8
        public void GetAttachedColliders(){} // RVA: 0x7FFAC997C230 | overloaded x2
        public void GetAttachedCollidersArray_Internal(){} // RVA: 0x7FFAC997C1D0
        public void GetAttachedCollidersList_Internal(){} // RVA: 0x7FFAC997C230
        public void Cast(){} // RVA: 0x7FFAC997C630 | overloaded x6
        public void CastArray_Internal(){} // RVA: 0x7FFAC997C2E0
        public void CastList_Internal(){} // RVA: 0x7FFAC997C3E0
        public void CastFilteredArray_Internal(){} // RVA: 0x7FFAC997C5A0
        public void CastFilteredList_Internal(){} // RVA: 0x7FFAC997C6D0
        public void GetShapes(){} // RVA: 0x7FFAC997C760
        public void GetShapes_Internal(){} // RVA: 0x7FFAC997C7D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_position_Injected(){} // RVA: 0x7FFAC997C830
        public void set_position_Injected(){} // RVA: 0x7FFAC997C890
        public void SetRotation_Quaternion_Injected(){} // RVA: 0x7FFAC997C8F0
        public void MovePosition_Injected(){} // RVA: 0x7FFAC997C950
        public void MoveRotation_Quaternion_Injected(){} // RVA: 0x7FFAC997C9B0
        public void get_velocity_Injected(){} // RVA: 0x7FFAC997CA10
        public void set_velocity_Injected(){} // RVA: 0x7FFAC997CA70
        public void get_centerOfMass_Injected(){} // RVA: 0x7FFAC997CAD0
        public void set_centerOfMass_Injected(){} // RVA: 0x7FFAC997CB30
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x7FFAC997CB90
        public void get_totalForce_Injected(){} // RVA: 0x7FFAC997CBF0
        public void set_totalForce_Injected(){} // RVA: 0x7FFAC997CC50
        public void get_excludeLayers_Injected(){} // RVA: 0x7FFAC997CCB0
        public void set_excludeLayers_Injected(){} // RVA: 0x7FFAC997CD10
        public void get_includeLayers_Injected(){} // RVA: 0x7FFAC997CD70
        public void set_includeLayers_Injected(){} // RVA: 0x7FFAC997CDD0
        public void IsTouching_OtherColliderWithFilter_Internal_Injected(){} // RVA: 0x7FFAC997CE30
        public void IsTouching_AnyColliderWithFilter_Internal_Injected(){} // RVA: 0x7FFAC997CEA0
        public void OverlapPoint_Injected(){} // RVA: 0x7FFAC997CF00
        public void Distance_Internal_Injected(){} // RVA: 0x7FFAC997CF60
        public void AddForce_Injected(){} // RVA: 0x7FFAC997CFD0
        public void AddRelativeForce_Injected(){} // RVA: 0x7FFAC997D040
        public void AddForceAtPosition_Injected(){} // RVA: 0x7FFAC997D0B0
        public void GetPoint_Injected(){} // RVA: 0x7FFAC997D130
        public void GetRelativePoint_Injected(){} // RVA: 0x7FFAC997D1A0
        public void GetVector_Injected(){} // RVA: 0x7FFAC997D210
        public void GetRelativeVector_Injected(){} // RVA: 0x7FFAC997D280
        public void GetPointVelocity_Injected(){} // RVA: 0x7FFAC997D2F0
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x7FFAC997D360
        public void OverlapColliderArray_Internal_Injected(){} // RVA: 0x7FFAC997D3D0
        public void OverlapColliderList_Internal_Injected(){} // RVA: 0x7FFAC997D440
        public void CastArray_Internal_Injected(){} // RVA: 0x7FFAC997D4B0
        public void CastList_Internal_Injected(){} // RVA: 0x7FFAC997D530
        public void CastFilteredArray_Internal_Injected(){} // RVA: 0x7FFAC997D5B0
        public void CastFilteredList_Internal_Injected(){} // RVA: 0x7FFAC997D640
    }

    public class RuntimeAnimatorController : Object
    {
        public object animationClips;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9833000
        public void get_animationClips(){} // RVA: 0x7FFAC9833050
    }

    public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
    {
        public 0x6B17F300 loadType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0 | overloaded x2
        public void set_loadType(){} // RVA: 0x7FFAC2F240C0
    }

}