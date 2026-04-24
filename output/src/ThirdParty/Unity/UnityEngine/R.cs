// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 25
// Methods: 919

namespace ThirdParty.Unity.UnityEngine
{
    public class RangeInt : ValueType
    {
        public int end; // 0x10
        public int length; // 0x14

        // ── Methods ──
        public void get_end(){} // RVA: 0x7FFD54CE3290
        public void .ctor(){} // RVA: 0x7FFD4E7F6D50
    }

    public class Ray : ValueType
    {
        public UnityEngine.Vector3 origin; // 0x10
        public UnityEngine.Vector3 direction; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C863A0
        public void get_origin(){} // RVA: 0x7FFD54C31DA0
        public void set_origin(){} // RVA: 0x7FFD5072B6C0
        public void get_direction(){} // RVA: 0x7FFD54C31DC0
        public void set_direction(){} // RVA: 0x7FFD54C863E0
        public void GetPoint(){} // RVA: 0x7FFD54C86410
        public void ToString(){} // RVA: 0x7FFD54C86480 | overloaded x3
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
        public void get_collider(){} // RVA: 0x7FFD54DB3D40
        public void get_colliderInstanceID(){} // RVA: 0x7FFD520AFE60
        public void get_point(){} // RVA: 0x7FFD54C31DA0
        public void set_point(){} // RVA: 0x7FFD5072B6C0
        public void get_normal(){} // RVA: 0x7FFD54C31DC0
        public void set_normal(){} // RVA: 0x7FFD54C31DE0
        public void get_barycentricCoordinate(){} // RVA: 0x7FFD54DB3E30
        public void set_barycentricCoordinate(){} // RVA: 0x7FFD54DB3E60
        public void get_distance(){} // RVA: 0x7FFD54C34E00
        public void set_distance(){} // RVA: 0x7FFD4E40E580
        public void get_triangleIndex(){} // RVA: 0x7FFD51ABDCA0
        public void CalculateRaycastTexCoord(){} // RVA: 0x7FFD54DB3E80
        public void get_textureCoord(){} // RVA: 0x7FFD54DB3F20
        public void get_textureCoord2(){} // RVA: 0x7FFD54DB3FD0
        public void get_transform(){} // RVA: 0x7FFD54DB4080
        public void get_rigidbody(){} // RVA: 0x7FFD54DB42A0
        public void get_articulationBody(){} // RVA: 0x7FFD54DB43E0
        public void get_lightmapCoord(){} // RVA: 0x7FFD54DB4520
        public void CalculateRaycastTexCoord_Injected(){} // RVA: 0x7FFD54DB47A0
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
        public void get_centroid(){} // RVA: 0x7FFD505F9A30
        public void set_centroid(){} // RVA: 0x7FFD4F9DB120
        public void get_point(){} // RVA: 0x7FFD54C86820
        public void set_point(){} // RVA: 0x7FFD4FE268C0
        public void get_normal(){} // RVA: 0x7FFD54D97900
        public void set_normal(){} // RVA: 0x7FFD4F83EFB0
        public void get_distance(){} // RVA: 0x7FFD54C31DF0
        public void set_distance(){} // RVA: 0x7FFD4E35C4D0
        public void get_fraction(){} // RVA: 0x7FFD54C34E00
        public void set_fraction(){} // RVA: 0x7FFD4E40E580
        public void get_collider(){} // RVA: 0x7FFD54D98FA0
        public void get_rigidbody(){} // RVA: 0x7FFD54D99090
        public void get_transform(){} // RVA: 0x7FFD54D991D0
        public void op_Implicit(){} // RVA: 0x7FFD54D993F0
        public void CompareTo(){} // RVA: 0x7FFD54D994D0
    }

    public class Rect : ValueType
    {
        public float zero; // 0x10
        public float x; // 0x14
        public float y; // 0x18
        public float position; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FEBB930 | overloaded x3
        public void get_zero(){} // RVA: 0x7FFD54C86670
        public void MinMaxRect(){} // RVA: 0x7FFD54C86680
        public void Set(){} // RVA: 0x7FFD4E365570
        public void get_x(){} // RVA: 0x7FFD4E364D20
        public void set_x(){} // RVA: 0x7FFD4FEBB910
        public void get_y(){} // RVA: 0x7FFD4E364D30
        public void set_y(){} // RVA: 0x7FFD4FEBB8F0
        public void get_position(){} // RVA: 0x7FFD54C866C0
        public void set_position(){} // RVA: 0x7FFD54C866E0
        public void get_center(){} // RVA: 0x7FFD54C86700
        public void set_center(){} // RVA: 0x7FFD54C86730
        public void get_min(){} // RVA: 0x7FFD54C86770
        public void set_min(){} // RVA: 0x7FFD54C86790
        public void get_max(){} // RVA: 0x7FFD54C867D0
        public void set_max(){} // RVA: 0x7FFD54C867F0
        public void get_width(){} // RVA: 0x7FFD4E364CF0
        public void set_width(){} // RVA: 0x7FFD4FEBB920
        public void get_height(){} // RVA: 0x7FFD4E364D00
        public void set_height(){} // RVA: 0x7FFD4FEBB8C0
        public void get_size(){} // RVA: 0x7FFD54C86820
        public void set_size(){} // RVA: 0x7FFD54C86840
        public void get_xMin(){} // RVA: 0x7FFD4E364D20
        public void set_xMin(){} // RVA: 0x7FFD54C86860
        public void get_yMin(){} // RVA: 0x7FFD4E364D30
        public void set_yMin(){} // RVA: 0x7FFD54C86880
        public void get_xMax(){} // RVA: 0x7FFD54C868A0
        public void set_xMax(){} // RVA: 0x7FFD54C868B0
        public void get_yMax(){} // RVA: 0x7FFD54C868C0
        public void set_yMax(){} // RVA: 0x7FFD54C868D0
        public void Contains(){} // RVA: 0x7FFD54C86960 | overloaded x3
        public void OrderMinMax(){} // RVA: 0x7FFD54C86A80
        public void Overlaps(){} // RVA: 0x7FFD54C86B40 | overloaded x2
        public void NormalizedToPoint(){} // RVA: 0x7FFD54C86CA0
        public void PointToNormalized(){} // RVA: 0x7FFD54C86D20
        public void op_Inequality(){} // RVA: 0x7FFD54C86DC0
        public void op_Equality(){} // RVA: 0x7FFD54C86E10
        public void GetHashCode(){} // RVA: 0x7FFD54C86E50
        public void Equals(){} // RVA: 0x7FFD5034F240 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD54C86F80 | overloaded x3
    }

    public class RectInt : ValueType
    {
        public int x; // 0x10
        public int y; // 0x14
        public int width; // 0x18
        public int height; // 0x1C

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFD543B3F90
        public void set_x(){} // RVA: 0x7FFD4E78D8B0
        public void get_y(){} // RVA: 0x7FFD51DEBEA0
        public void set_y(){} // RVA: 0x7FFD4F840230
        public void get_width(){} // RVA: 0x7FFD5195D9A0
        public void set_width(){} // RVA: 0x7FFD4FDE7510
        public void get_height(){} // RVA: 0x7FFD519BDBB0
        public void set_height(){} // RVA: 0x7FFD4FDE7530
        public void get_xMin(){} // RVA: 0x7FFD54C87310
        public void get_yMin(){} // RVA: 0x7FFD54C87380
        public void get_xMax(){} // RVA: 0x7FFD54C873F0
        public void get_yMax(){} // RVA: 0x7FFD54C87460
        public void .ctor(){} // RVA: 0x7FFD5373F680
        public void Overlaps(){} // RVA: 0x7FFD54C874D0
        public void ToString(){} // RVA: 0x7FFD54C87580 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD54C879D0
    }

    public class RectOffset : Object
    {
        public UIntPtr left; // 0x10
        public object right; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C87B50 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFD54C87AB0
        public void ToString(){} // RVA: 0x7FFD54C87D00 | overloaded x2
        public void Destroy(){} // RVA: 0x7FFD54C88260
        public void InternalCreate(){} // RVA: 0x7FFD54C882D0
        public void InternalDestroy(){} // RVA: 0x7FFD54C88320
        public void get_left(){} // RVA: 0x7FFD54C88370
        public void set_left(){} // RVA: 0x7FFD54C883C0
        public void get_right(){} // RVA: 0x7FFD54C88420
        public void set_right(){} // RVA: 0x7FFD54C88470
        public void get_top(){} // RVA: 0x7FFD54C884D0
        public void set_top(){} // RVA: 0x7FFD54C88520
        public void get_bottom(){} // RVA: 0x7FFD54C88580
        public void set_bottom(){} // RVA: 0x7FFD54C885D0
        public void get_horizontal(){} // RVA: 0x7FFD54C88630
        public void get_vertical(){} // RVA: 0x7FFD54C88680
        public void Remove(){} // RVA: 0x7FFD54C886D0
        public void Remove_Injected(){} // RVA: 0x7FFD54C88750
    }

    public class RectTransform : Transform
    {
        public ReapplyDrivenProperties rect;

        // ── Methods ──
        public void add_reapplyDrivenProperties(){} // RVA: 0x7FFD54CEE390
        public void remove_reapplyDrivenProperties(){} // RVA: 0x7FFD54CEE4A0
        public void get_rect(){} // RVA: 0x7FFD54CEE5B0
        public void get_anchorMin(){} // RVA: 0x7FFD54CEE620
        public void set_anchorMin(){} // RVA: 0x7FFD54CEE680
        public void get_anchorMax(){} // RVA: 0x7FFD54CEE6E0
        public void set_anchorMax(){} // RVA: 0x7FFD54CEE740
        public void get_anchoredPosition(){} // RVA: 0x7FFD54CEE7A0
        public void set_anchoredPosition(){} // RVA: 0x7FFD54CEE800
        public void get_sizeDelta(){} // RVA: 0x7FFD54CEE860
        public void set_sizeDelta(){} // RVA: 0x7FFD54CEE8C0
        public void get_pivot(){} // RVA: 0x7FFD54CEE920
        public void set_pivot(){} // RVA: 0x7FFD54CEE980
        public void get_anchoredPosition3D(){} // RVA: 0x7FFD54CEE9E0
        public void set_anchoredPosition3D(){} // RVA: 0x7FFD54CEEAC0
        public void get_offsetMin(){} // RVA: 0x7FFD54CEEBF0
        public void set_offsetMin(){} // RVA: 0x7FFD54CEED20
        public void get_offsetMax(){} // RVA: 0x7FFD54CEF0A0
        public void set_offsetMax(){} // RVA: 0x7FFD54CEF230
        public void get_drivenByObject(){} // RVA: 0x7FFD54CEF590
        public void set_drivenByObject(){} // RVA: 0x7FFD54CEF5E0
        public void get_drivenProperties(){} // RVA: 0x7FFD54CEF640
        public void set_drivenProperties(){} // RVA: 0x7FFD54CEF690
        public void ForceUpdateRectTransforms(){} // RVA: 0x7FFD54CEF6F0
        public void GetLocalCorners(){} // RVA: 0x7FFD54CEF740
        public void GetWorldCorners(){} // RVA: 0x7FFD54CEF8C0
        public void SetInsetAndSizeFromParentEdge(){} // RVA: 0x7FFD54CEFC30
        public void SetSizeWithCurrentAnchors(){} // RVA: 0x7FFD54CF0180
        public void SendReapplyDrivenProperties(){} // RVA: 0x7FFD54CF04E0
        public void GetRectInParentSpace(){} // RVA: 0x7FFD54CF0540
        public void GetParentSize(){} // RVA: 0x7FFD54CF0A00
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_rect_Injected(){} // RVA: 0x7FFD54CF0BE0
        public void get_anchorMin_Injected(){} // RVA: 0x7FFD54CF0C40
        public void set_anchorMin_Injected(){} // RVA: 0x7FFD54CF0CA0
        public void get_anchorMax_Injected(){} // RVA: 0x7FFD54CF0D00
        public void set_anchorMax_Injected(){} // RVA: 0x7FFD54CF0D60
        public void get_anchoredPosition_Injected(){} // RVA: 0x7FFD54CF0DC0
        public void set_anchoredPosition_Injected(){} // RVA: 0x7FFD54CF0E20
        public void get_sizeDelta_Injected(){} // RVA: 0x7FFD54CF0E80
        public void set_sizeDelta_Injected(){} // RVA: 0x7FFD54CF0EE0
        public void get_pivot_Injected(){} // RVA: 0x7FFD54CF0F40
        public void set_pivot_Injected(){} // RVA: 0x7FFD54CF0FA0
    }

    public class ReflectionProbe : Behaviour
    {
        public System.Action`2<UnityEngine.ReflectionProbe,0x664D9E18> type;
        public System.Collections.Generic.Dictionary`2<int,System.Action`1<UnityEngine.Texture>> size; // 0x8
        public System.Collections.Generic.List`1<System.Action`1<UnityEngine.Texture>> center; // 0x10

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFD54C7CC10
        public void set_type(){} // RVA: 0x7FFD54C7CC60
        public void get_size(){} // RVA: 0x7FFD54C7CCC0
        public void set_size(){} // RVA: 0x7FFD54C7CD30
        public void get_center(){} // RVA: 0x7FFD54C7CD90
        public void set_center(){} // RVA: 0x7FFD54C7CE00
        public void get_nearClipPlane(){} // RVA: 0x7FFD54C7CE60
        public void set_nearClipPlane(){} // RVA: 0x7FFD54C7CEB0
        public void get_farClipPlane(){} // RVA: 0x7FFD54C7CF10
        public void set_farClipPlane(){} // RVA: 0x7FFD54C7CF60
        public void get_intensity(){} // RVA: 0x7FFD54C7CFC0
        public void set_intensity(){} // RVA: 0x7FFD54C7D010
        public void get_bounds(){} // RVA: 0x7FFD54C7D070
        public void get_hdr(){} // RVA: 0x7FFD54C7D0E0
        public void set_hdr(){} // RVA: 0x7FFD54C7D130
        public void get_renderDynamicObjects(){} // RVA: 0x7FFD54C7D190
        public void set_renderDynamicObjects(){} // RVA: 0x7FFD54C7D1E0
        public void get_shadowDistance(){} // RVA: 0x7FFD54C7D240
        public void set_shadowDistance(){} // RVA: 0x7FFD54C7D290
        public void get_resolution(){} // RVA: 0x7FFD54C7D2F0
        public void set_resolution(){} // RVA: 0x7FFD54C7D340
        public void get_cullingMask(){} // RVA: 0x7FFD54C7D3A0
        public void set_cullingMask(){} // RVA: 0x7FFD54C7D3F0
        public void get_clearFlags(){} // RVA: 0x7FFD54C7D450
        public void set_clearFlags(){} // RVA: 0x7FFD54C7D4A0
        public void get_backgroundColor(){} // RVA: 0x7FFD54C7D500
        public void set_backgroundColor(){} // RVA: 0x7FFD54C7D570
        public void get_blendDistance(){} // RVA: 0x7FFD54C7D5D0
        public void set_blendDistance(){} // RVA: 0x7FFD54C7D620
        public void get_boxProjection(){} // RVA: 0x7FFD54C7D680
        public void set_boxProjection(){} // RVA: 0x7FFD54C7D6D0
        public void get_mode(){} // RVA: 0x7FFD54C7D730
        public void set_mode(){} // RVA: 0x7FFD54C7D780
        public void get_importance(){} // RVA: 0x7FFD54C7D7E0
        public void set_importance(){} // RVA: 0x7FFD54C7D830
        public void get_refreshMode(){} // RVA: 0x7FFD54C7D890
        public void set_refreshMode(){} // RVA: 0x7FFD54C7D8E0
        public void get_timeSlicingMode(){} // RVA: 0x7FFD54C7D940
        public void set_timeSlicingMode(){} // RVA: 0x7FFD54C7D990
        public void get_bakedTexture(){} // RVA: 0x7FFD54C7D9F0
        public void set_bakedTexture(){} // RVA: 0x7FFD54C7DA40
        public void get_customBakedTexture(){} // RVA: 0x7FFD54C7DAA0
        public void set_customBakedTexture(){} // RVA: 0x7FFD54C7DAF0
        public void get_realtimeTexture(){} // RVA: 0x7FFD54C7DB50
        public void set_realtimeTexture(){} // RVA: 0x7FFD54C7DBA0
        public void get_texture(){} // RVA: 0x7FFD54C7DC00
        public void get_textureHDRDecodeValues(){} // RVA: 0x7FFD54C7DC50
        public void Reset(){} // RVA: 0x7FFD54C7DCC0
        public void RenderProbe(){} // RVA: 0x7FFD54C7DD20 | overloaded x2
        public void IsFinishedRendering(){} // RVA: 0x7FFD54C7DDD0
        public void ScheduleRender(){} // RVA: 0x7FFD54C7DE30
        public void BlendCubemap(){} // RVA: 0x7FFD54C7DEA0
        public void UpdateCachedState(){} // RVA: 0x7FFD54C7DF20
        public void get_minBakedCubemapResolution(){} // RVA: 0x7FFD54C7DF70
        public void get_maxBakedCubemapResolution(){} // RVA: 0x7FFD54C7DFC0
        public void get_defaultTextureHDRDecodeValues(){} // RVA: 0x7FFD54C7E010
        public void get_defaultTexture(){} // RVA: 0x7FFD54C7E0A0
        public void add_reflectionProbeChanged(){} // RVA: 0x7FFD54C7E0F0
        public void remove_reflectionProbeChanged(){} // RVA: 0x7FFD54C7E250
        public void CallReflectionProbeEvent(){} // RVA: 0x7FFD54C7E3B0
        public void add_defaultReflectionSet(){} // RVA: 0x7FFD54C7E430
        public void remove_defaultReflectionSet(){} // RVA: 0x7FFD54C7E680
        public void add_defaultReflectionTexture(){} // RVA: 0x7FFD54C7E860
        public void remove_defaultReflectionTexture(){} // RVA: 0x7FFD54C7EB10
        public void CallSetDefaultReflection(){} // RVA: 0x7FFD54C7EBA0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void .cctor(){} // RVA: 0x7FFD54C7ED30
        public void get_size_Injected(){} // RVA: 0x7FFD54C7EED0
        public void set_size_Injected(){} // RVA: 0x7FFD54C7EF30
        public void get_center_Injected(){} // RVA: 0x7FFD54C7EF90
        public void set_center_Injected(){} // RVA: 0x7FFD54C7EFF0
        public void get_bounds_Injected(){} // RVA: 0x7FFD54C7F050
        public void get_backgroundColor_Injected(){} // RVA: 0x7FFD54C7F0B0
        public void set_backgroundColor_Injected(){} // RVA: 0x7FFD54C7F110
        public void get_textureHDRDecodeValues_Injected(){} // RVA: 0x7FFD54C7F170
        public void get_defaultTextureHDRDecodeValues_Injected(){} // RVA: 0x7FFD54C7F1D0
    }

    public class RefreshRate : ValueType
    {
        public uint value; // 0x10
        public uint denominator; // 0x14

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFD54C8BFA0
        public void Equals(){} // RVA: 0x7FFD54C8BFC0
        public void CompareTo(){} // RVA: 0x7FFD54C8C000
        public void ToString(){} // RVA: 0x7FFD54C8C050
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
        public void get_maxForce(){} // RVA: 0x7FFD54DA4020
        public void set_maxForce(){} // RVA: 0x7FFD54DA4070
        public void get_maxTorque(){} // RVA: 0x7FFD54DA40D0
        public void set_maxTorque(){} // RVA: 0x7FFD54DA4120
        public void get_correctionScale(){} // RVA: 0x7FFD54DA4180
        public void set_correctionScale(){} // RVA: 0x7FFD54DA41D0
        public void get_autoConfigureOffset(){} // RVA: 0x7FFD54DA4230
        public void set_autoConfigureOffset(){} // RVA: 0x7FFD54DA4280
        public void get_linearOffset(){} // RVA: 0x7FFD54DA42E0
        public void set_linearOffset(){} // RVA: 0x7FFD54DA4340
        public void get_angularOffset(){} // RVA: 0x7FFD54DA43A0
        public void set_angularOffset(){} // RVA: 0x7FFD54DA43F0
        public void get_target(){} // RVA: 0x7FFD54DA4450
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_linearOffset_Injected(){} // RVA: 0x7FFD54DA44B0
        public void set_linearOffset_Injected(){} // RVA: 0x7FFD54DA4510
        public void get_target_Injected(){} // RVA: 0x7FFD54DA4570
    }

    public class RemoteConfigSettings : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public System.Action`1<bool> Updated; // 0x18

        // ── Methods ──
        public void RemoteConfigSettingsUpdated(){} // RVA: 0x7FFD550AE150
    }

    public class RemoteSettings : Object
    {
        public UpdatedEventHandler Updated;
        public System.Action BeforeFetchFromServer; // 0x8
        public System.Action`3<bool,bool,int> Completed; // 0x10

        // ── Methods ──
        public void RemoteSettingsUpdated(){} // RVA: 0x7FFD550AE010
        public void RemoteSettingsBeforeFetchFromServer(){} // RVA: 0x7FFD550AE070
        public void RemoteSettingsUpdateCompleted(){} // RVA: 0x7FFD550AE0D0
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
        public void get_fog(){} // RVA: 0x7FFD54C9EA10
        public void set_fog(){} // RVA: 0x7FFD54C9EA60
        public void get_fogStartDistance(){} // RVA: 0x7FFD54C9EAB0
        public void set_fogStartDistance(){} // RVA: 0x7FFD54C9EB00
        public void get_fogEndDistance(){} // RVA: 0x7FFD54C9EB60
        public void set_fogEndDistance(){} // RVA: 0x7FFD54C9EBB0
        public void get_fogMode(){} // RVA: 0x7FFD54C9EC10
        public void set_fogMode(){} // RVA: 0x7FFD54C9EC60
        public void get_fogColor(){} // RVA: 0x7FFD54C9ECB0
        public void set_fogColor(){} // RVA: 0x7FFD54C9ED10
        public void get_fogDensity(){} // RVA: 0x7FFD54C9ED60
        public void set_fogDensity(){} // RVA: 0x7FFD54C9EDB0
        public void get_ambientMode(){} // RVA: 0x7FFD54C9EE10
        public void set_ambientMode(){} // RVA: 0x7FFD54C9EE60
        public void get_ambientSkyColor(){} // RVA: 0x7FFD54C9EEB0
        public void set_ambientSkyColor(){} // RVA: 0x7FFD54C9EF10
        public void get_ambientEquatorColor(){} // RVA: 0x7FFD54C9EF60
        public void set_ambientEquatorColor(){} // RVA: 0x7FFD54C9EFC0
        public void get_ambientGroundColor(){} // RVA: 0x7FFD54C9F010
        public void set_ambientGroundColor(){} // RVA: 0x7FFD54C9F070
        public void get_ambientIntensity(){} // RVA: 0x7FFD54C9F0C0
        public void set_ambientIntensity(){} // RVA: 0x7FFD54C9F110
        public void get_ambientLight(){} // RVA: 0x7FFD54C9F170
        public void set_ambientLight(){} // RVA: 0x7FFD54C9F1D0
        public void get_subtractiveShadowColor(){} // RVA: 0x7FFD54C9F220
        public void set_subtractiveShadowColor(){} // RVA: 0x7FFD54C9F280
        public void get_skybox(){} // RVA: 0x7FFD54C9F2D0
        public void set_skybox(){} // RVA: 0x7FFD54C9F320
        public void get_sun(){} // RVA: 0x7FFD54C9F370
        public void set_sun(){} // RVA: 0x7FFD54C9F3C0
        public void get_ambientProbe(){} // RVA: 0x7FFD54C9F410
        public void set_ambientProbe(){} // RVA: 0x7FFD54C9F490
        public void get_customReflectionTexture(){} // RVA: 0x7FFD54C9F4E0
        public void set_customReflectionTexture(){} // RVA: 0x7FFD54C9F530
        public void get_reflectionIntensity(){} // RVA: 0x7FFD54C9F580
        public void set_reflectionIntensity(){} // RVA: 0x7FFD54C9F5D0
        public void get_reflectionBounces(){} // RVA: 0x7FFD54C9F630
        public void set_reflectionBounces(){} // RVA: 0x7FFD54C9F680
        public void get_defaultReflectionMode(){} // RVA: 0x7FFD54C9F6D0
        public void set_defaultReflectionMode(){} // RVA: 0x7FFD54C9F720
        public void get_defaultReflectionResolution(){} // RVA: 0x7FFD54C9F770
        public void set_defaultReflectionResolution(){} // RVA: 0x7FFD54C9F7C0
        public void get_haloStrength(){} // RVA: 0x7FFD54C9F810
        public void set_haloStrength(){} // RVA: 0x7FFD54C9F860
        public void get_flareStrength(){} // RVA: 0x7FFD54C9F8C0
        public void set_flareStrength(){} // RVA: 0x7FFD54C9F910
        public void get_flareFadeSpeed(){} // RVA: 0x7FFD54C9F970
        public void set_flareFadeSpeed(){} // RVA: 0x7FFD54C9F9C0
        public void get_fogColor_Injected(){} // RVA: 0x7FFD54C9FA20
        public void set_fogColor_Injected(){} // RVA: 0x7FFD54C9FA70
        public void get_ambientSkyColor_Injected(){} // RVA: 0x7FFD54C9FAC0
        public void set_ambientSkyColor_Injected(){} // RVA: 0x7FFD54C9FB10
        public void get_ambientEquatorColor_Injected(){} // RVA: 0x7FFD54C9FB60
        public void set_ambientEquatorColor_Injected(){} // RVA: 0x7FFD54C9FBB0
        public void get_ambientGroundColor_Injected(){} // RVA: 0x7FFD54C9FC00
        public void set_ambientGroundColor_Injected(){} // RVA: 0x7FFD54C9FC50
        public void get_ambientLight_Injected(){} // RVA: 0x7FFD54C9FCA0
        public void set_ambientLight_Injected(){} // RVA: 0x7FFD54C9FCF0
        public void get_subtractiveShadowColor_Injected(){} // RVA: 0x7FFD54C9FD40
        public void set_subtractiveShadowColor_Injected(){} // RVA: 0x7FFD54C9FD90
        public void get_ambientProbe_Injected(){} // RVA: 0x7FFD54C9FDE0
        public void set_ambientProbe_Injected(){} // RVA: 0x7FFD54C9FE30
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
        public void get_width(){} // RVA: 0x7FFD54CC0FD0
        public void set_width(){} // RVA: 0x7FFD54CC1020
        public void get_height(){} // RVA: 0x7FFD54CC1080
        public void set_height(){} // RVA: 0x7FFD54CC10D0
        public void get_dimension(){} // RVA: 0x7FFD54CC1130
        public void set_dimension(){} // RVA: 0x7FFD54CC1180
        public void GetColorFormat(){} // RVA: 0x7FFD54CC11E0
        public void SetColorFormat(){} // RVA: 0x7FFD54CC1240
        public void get_graphicsFormat(){} // RVA: 0x7FFD54CC12A0
        public void set_graphicsFormat(){} // RVA: 0x7FFD54CC1240
        public void get_useMipMap(){} // RVA: 0x7FFD54CC1300
        public void set_useMipMap(){} // RVA: 0x7FFD54CC1350
        public void get_sRGB(){} // RVA: 0x7FFD54CC13B0
        public void get_vrUsage(){} // RVA: 0x7FFD54CC1400
        public void set_vrUsage(){} // RVA: 0x7FFD54CC1450
        public void get_memorylessMode(){} // RVA: 0x7FFD54CC14B0
        public void set_memorylessMode(){} // RVA: 0x7FFD54CC1500
        public void get_format(){} // RVA: 0x7FFD54CC1560
        public void set_format(){} // RVA: 0x7FFD54CC16F0
        public void get_stencilFormat(){} // RVA: 0x7FFD54CC17E0
        public void set_stencilFormat(){} // RVA: 0x7FFD54CC1830
        public void get_depthStencilFormat(){} // RVA: 0x7FFD54CC1890
        public void set_depthStencilFormat(){} // RVA: 0x7FFD54CC18E0
        public void get_autoGenerateMips(){} // RVA: 0x7FFD54CC1940
        public void set_autoGenerateMips(){} // RVA: 0x7FFD54CC1990
        public void get_volumeDepth(){} // RVA: 0x7FFD54CC19F0
        public void set_volumeDepth(){} // RVA: 0x7FFD54CC1A40
        public void get_antiAliasing(){} // RVA: 0x7FFD54CC1AA0
        public void set_antiAliasing(){} // RVA: 0x7FFD54CC1AF0
        public void get_bindTextureMS(){} // RVA: 0x7FFD54CC1B50
        public void set_bindTextureMS(){} // RVA: 0x7FFD54CC1BA0
        public void get_enableRandomWrite(){} // RVA: 0x7FFD54CC1C00
        public void set_enableRandomWrite(){} // RVA: 0x7FFD54CC1C50
        public void get_useDynamicScale(){} // RVA: 0x7FFD54CC1CB0
        public void set_useDynamicScale(){} // RVA: 0x7FFD54CC1D00
        public void GetIsPowerOfTwo(){} // RVA: 0x7FFD54CC1D60
        public void get_isPowerOfTwo(){} // RVA: 0x7FFD54CC1D60
        public void set_isPowerOfTwo(){} // RVA: 0x7FFD4E341310
        public void GetActive(){} // RVA: 0x7FFD54CC1DB0
        public void SetActive(){} // RVA: 0x7FFD54CC1E00
        public void get_active(){} // RVA: 0x7FFD54CC1DB0
        public void set_active(){} // RVA: 0x7FFD54CC1E00
        public void GetColorBuffer(){} // RVA: 0x7FFD54CC1E50
        public void GetDepthBuffer(){} // RVA: 0x7FFD54CC1EC0
        public void SetMipMapCount(){} // RVA: 0x7FFD54CC1F30
        public void SetShadowSamplingMode(){} // RVA: 0x7FFD54CC1F90
        public void get_colorBuffer(){} // RVA: 0x7FFD54CC1FF0
        public void get_depthBuffer(){} // RVA: 0x7FFD54CC2070
        public void GetNativeDepthBufferPtr(){} // RVA: 0x7FFD54CC20F0
        public void DiscardContents(){} // RVA: 0x7FFD54CC2210 | overloaded x2
        public void MarkRestoreExpected(){} // RVA: 0x7FFD54CC21C0
        public void ResolveAA(){} // RVA: 0x7FFD54CC2270
        public void ResolveAATo(){} // RVA: 0x7FFD54CC22C0
        public void ResolveAntiAliasedSurface(){} // RVA: 0x7FFD54CC22C0 | overloaded x2
        public void SetGlobalShaderProperty(){} // RVA: 0x7FFD54CC2320
        public void Create(){} // RVA: 0x7FFD54CC2380
        public void Release(){} // RVA: 0x7FFD54CC23D0
        public void IsCreated(){} // RVA: 0x7FFD54CC2420
        public void GenerateMips(){} // RVA: 0x7FFD54CC2470
        public void ConvertToEquirect(){} // RVA: 0x7FFD54CC24C0
        public void SetSRGBReadWrite(){} // RVA: 0x7FFD54CC2530
        public void Internal_Create(){} // RVA: 0x7FFD54CC2590
        public void SupportsStencil(){} // RVA: 0x7FFD54CC25E0
        public void SetRenderTextureDescriptor(){} // RVA: 0x7FFD54CC2630
        public void GetDescriptor(){} // RVA: 0x7FFD54CC2690
        public void GetTemporary_Internal(){} // RVA: 0x7FFD54CC2710
        public void ReleaseTemporary(){} // RVA: 0x7FFD54CC2760
        public void get_depth(){} // RVA: 0x7FFD54CC27B0
        public void set_depth(){} // RVA: 0x7FFD54CC2800
        public void .ctor(){} // RVA: 0x7FFD54CC3700 | overloaded x12
        public void Initialize(){} // RVA: 0x7FFD54CC37D0
        public void GetDepthStencilFormatLegacy(){} // RVA: 0x7FFD54CC3B00 | overloaded x4
        public void get_descriptor(){} // RVA: 0x7FFD54CC3B90
        public void set_descriptor(){} // RVA: 0x7FFD54CC3C40
        public void ValidateRenderTextureDesc(){} // RVA: 0x7FFD54CC3D00
        public void GetDefaultColorFormat(){} // RVA: 0x7FFD54CC4290
        public void GetDefaultDepthStencilFormat(){} // RVA: 0x7FFD54CC4300
        public void GetCompatibleFormat(){} // RVA: 0x7FFD54CC4370
        public void GetTemporary(){} // RVA: 0x7FFD54CC4D10 | overloaded x14
        public void GetTemporaryImpl(){} // RVA: 0x7FFD54CC45E0
        public void get_isCubemap(){} // RVA: 0x7FFD54CC4D40
        public void set_isCubemap(){} // RVA: 0x7FFD54CC4D70
        public void get_isVolume(){} // RVA: 0x7FFD54CC4DB0
        public void set_isVolume(){} // RVA: 0x7FFD54CC4DE0
        public void get_enabled(){} // RVA: 0x7FFD500182C0
        public void set_enabled(){} // RVA: 0x7FFD4E341310
        public void GetTexelOffset(){} // RVA: 0x7FFD4E3660A0
        public void GetColorBuffer_Injected(){} // RVA: 0x7FFD54CC4E10
        public void GetDepthBuffer_Injected(){} // RVA: 0x7FFD54CC4E70
        public void SetRenderTextureDescriptor_Injected(){} // RVA: 0x7FFD54CC4ED0
        public void GetDescriptor_Injected(){} // RVA: 0x7FFD54CC4F30
        public void GetTemporary_Internal_Injected(){} // RVA: 0x7FFD54CC4F90
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
        public void get_castShadows(){} // RVA: 0x7FFD54C9C1C0
        public void set_castShadows(){} // RVA: 0x7FFD54C9C220
        public void get_motionVectors(){} // RVA: 0x7FFD54C9C290
        public void set_motionVectors(){} // RVA: 0x7FFD54C9C2F0
        public void get_useLightProbes(){} // RVA: 0x7FFD54C9C360
        public void set_useLightProbes(){} // RVA: 0x7FFD54C9C3C0
        public void get_bounds(){} // RVA: 0x7FFD54C9C430
        public void set_bounds(){} // RVA: 0x7FFD54C9C4A0
        public void get_localBounds(){} // RVA: 0x7FFD54C9C500
        public void set_localBounds(){} // RVA: 0x7FFD54C9C570
        public void ResetBounds(){} // RVA: 0x7FFD54C9C5D0
        public void ResetLocalBounds(){} // RVA: 0x7FFD54C9C620
        public void SetStaticLightmapST(){} // RVA: 0x7FFD54C9C670
        public void GetMaterial(){} // RVA: 0x7FFD54C9C6D0
        public void GetSharedMaterial(){} // RVA: 0x7FFD54C9C720
        public void SetMaterial(){} // RVA: 0x7FFD54C9C770
        public void GetMaterialArray(){} // RVA: 0x7FFD54C9C7D0
        public void CopyMaterialArray(){} // RVA: 0x7FFD54C9C820
        public void CopySharedMaterialArray(){} // RVA: 0x7FFD54C9C880
        public void SetMaterialArray(){} // RVA: 0x7FFD54C9C950 | overloaded x2
        public void Internal_SetPropertyBlock(){} // RVA: 0x7FFD54C9C980
        public void Internal_GetPropertyBlock(){} // RVA: 0x7FFD54C9C9E0
        public void Internal_SetPropertyBlockMaterialIndex(){} // RVA: 0x7FFD54C9CA40
        public void Internal_GetPropertyBlockMaterialIndex(){} // RVA: 0x7FFD54C9CAB0
        public void HasPropertyBlock(){} // RVA: 0x7FFD54C9CB20
        public void SetPropertyBlock(){} // RVA: 0x7FFD54C9CA40 | overloaded x2
        public void GetPropertyBlock(){} // RVA: 0x7FFD54C9CAB0 | overloaded x2
        public void GetClosestReflectionProbesInternal(){} // RVA: 0x7FFD54C9CB70
        public void get_enabled(){} // RVA: 0x7FFD54C9CBD0
        public void set_enabled(){} // RVA: 0x7FFD54C9CC20
        public void get_isVisible(){} // RVA: 0x7FFD54C9CC80
        public void get_shadowCastingMode(){} // RVA: 0x7FFD54C9CCD0
        public void set_shadowCastingMode(){} // RVA: 0x7FFD54C9CD20
        public void get_receiveShadows(){} // RVA: 0x7FFD54C9CD80
        public void set_receiveShadows(){} // RVA: 0x7FFD54C9CDD0
        public void get_forceRenderingOff(){} // RVA: 0x7FFD54C9CE30
        public void set_forceRenderingOff(){} // RVA: 0x7FFD54C9CE80
        public void GetIsStaticShadowCaster(){} // RVA: 0x7FFD54C9CEE0
        public void SetIsStaticShadowCaster(){} // RVA: 0x7FFD54C9CF30
        public void get_staticShadowCaster(){} // RVA: 0x7FFD54C9CEE0
        public void set_staticShadowCaster(){} // RVA: 0x7FFD54C9CF30
        public void get_motionVectorGenerationMode(){} // RVA: 0x7FFD54C9CF90
        public void set_motionVectorGenerationMode(){} // RVA: 0x7FFD54C9CFE0
        public void get_lightProbeUsage(){} // RVA: 0x7FFD54C9D040
        public void set_lightProbeUsage(){} // RVA: 0x7FFD54C9D090
        public void get_reflectionProbeUsage(){} // RVA: 0x7FFD54C9D0F0
        public void set_reflectionProbeUsage(){} // RVA: 0x7FFD54C9D140
        public void get_renderingLayerMask(){} // RVA: 0x7FFD54C9D1A0
        public void set_renderingLayerMask(){} // RVA: 0x7FFD54C9D1F0
        public void get_rendererPriority(){} // RVA: 0x7FFD54C9D250
        public void set_rendererPriority(){} // RVA: 0x7FFD54C9D2A0
        public void get_rayTracingMode(){} // RVA: 0x7FFD54C9D300
        public void set_rayTracingMode(){} // RVA: 0x7FFD54C9D350
        public void get_sortingLayerName(){} // RVA: 0x7FFD54C9D3B0
        public void set_sortingLayerName(){} // RVA: 0x7FFD54C9D400
        public void get_sortingLayerID(){} // RVA: 0x7FFD54C9D460
        public void set_sortingLayerID(){} // RVA: 0x7FFD54C9D4B0
        public void get_sortingOrder(){} // RVA: 0x7FFD54C9D510
        public void set_sortingOrder(){} // RVA: 0x7FFD54C9D560
        public void get_sortingKey(){} // RVA: 0x7FFD54C9D5C0
        public void get_sortingGroupID(){} // RVA: 0x7FFD54C9D610
        public void set_sortingGroupID(){} // RVA: 0x7FFD54C9D660
        public void get_sortingGroupOrder(){} // RVA: 0x7FFD54C9D6C0
        public void set_sortingGroupOrder(){} // RVA: 0x7FFD54C9D710
        public void get_sortingGroupKey(){} // RVA: 0x7FFD54C9D770
        public void get_allowOcclusionWhenDynamic(){} // RVA: 0x7FFD54C9D7C0
        public void set_allowOcclusionWhenDynamic(){} // RVA: 0x7FFD54C9D810
        public void get_staticBatchRootTransform(){} // RVA: 0x7FFD54C9D870
        public void set_staticBatchRootTransform(){} // RVA: 0x7FFD54C9D8C0
        public void get_staticBatchIndex(){} // RVA: 0x7FFD54C9D920
        public void SetStaticBatchInfo(){} // RVA: 0x7FFD54C9D970
        public void get_isPartOfStaticBatch(){} // RVA: 0x7FFD54C9D9E0
        public void get_worldToLocalMatrix(){} // RVA: 0x7FFD54C9DA30
        public void get_localToWorldMatrix(){} // RVA: 0x7FFD54C9DAB0
        public void get_lightProbeProxyVolumeOverride(){} // RVA: 0x7FFD54C9DB30
        public void set_lightProbeProxyVolumeOverride(){} // RVA: 0x7FFD54C9DB80
        public void get_probeAnchor(){} // RVA: 0x7FFD54C9DBE0
        public void set_probeAnchor(){} // RVA: 0x7FFD54C9DC30
        public void GetLightmapIndex(){} // RVA: 0x7FFD54C9DC90
        public void SetLightmapIndex(){} // RVA: 0x7FFD54C9DCF0
        public void GetLightmapST(){} // RVA: 0x7FFD54C9DD60
        public void SetLightmapST(){} // RVA: 0x7FFD54C9DDE0
        public void get_lightmapIndex(){} // RVA: 0x7FFD54C9DE50
        public void set_lightmapIndex(){} // RVA: 0x7FFD54C9DEB0
        public void get_realtimeLightmapIndex(){} // RVA: 0x7FFD54C9DF10
        public void set_realtimeLightmapIndex(){} // RVA: 0x7FFD54C9DF70
        public void get_lightmapScaleOffset(){} // RVA: 0x7FFD54C9DFE0
        public void set_lightmapScaleOffset(){} // RVA: 0x7FFD54C9E060
        public void get_realtimeLightmapScaleOffset(){} // RVA: 0x7FFD54C9E0C0
        public void set_realtimeLightmapScaleOffset(){} // RVA: 0x7FFD54C9E140
        public void GetMaterialCount(){} // RVA: 0x7FFD54C9E1B0
        public void GetSharedMaterialArray(){} // RVA: 0x7FFD54C9E200
        public void get_materials(){} // RVA: 0x7FFD54C9C7D0
        public void set_materials(){} // RVA: 0x7FFD54C9C950
        public void get_material(){} // RVA: 0x7FFD54C9C6D0
        public void set_material(){} // RVA: 0x7FFD54C9C770
        public void get_sharedMaterial(){} // RVA: 0x7FFD54C9C720
        public void set_sharedMaterial(){} // RVA: 0x7FFD54C9C770
        public void get_sharedMaterials(){} // RVA: 0x7FFD54C9E200
        public void set_sharedMaterials(){} // RVA: 0x7FFD54C9C950
        public void GetMaterials(){} // RVA: 0x7FFD54C9E250
        public void SetSharedMaterials(){} // RVA: 0x7FFD54C9E3A0
        public void SetMaterials(){} // RVA: 0x7FFD54C9E470
        public void GetSharedMaterials(){} // RVA: 0x7FFD54C9E540
        public void GetClosestReflectionProbes(){} // RVA: 0x7FFD54C9CB70
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_bounds_Injected(){} // RVA: 0x7FFD54C9E690
        public void set_bounds_Injected(){} // RVA: 0x7FFD54C9E6F0
        public void get_localBounds_Injected(){} // RVA: 0x7FFD54C9E750
        public void set_localBounds_Injected(){} // RVA: 0x7FFD54C9E7B0
        public void SetStaticLightmapST_Injected(){} // RVA: 0x7FFD54C9E810
        public void get_worldToLocalMatrix_Injected(){} // RVA: 0x7FFD54C9E870
        public void get_localToWorldMatrix_Injected(){} // RVA: 0x7FFD54C9E8D0
        public void GetLightmapST_Injected(){} // RVA: 0x7FFD54C9E930
        public void SetLightmapST_Injected(){} // RVA: 0x7FFD54C9E9A0
    }

    public class RequireComponent : Attribute
    {
        public System.Type m_Type0; // 0x10
        public System.Type m_Type1; // 0x18
        public System.Type m_Type2; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E90C240 | overloaded x2
    }

    public class Resolution : ValueType
    {
        public int width; // 0x10
        public int height; // 0x14
        public UnityEngine.RefreshRate refreshRateRatio; // 0x18

        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFD543B3F90
        public void set_width(){} // RVA: 0x7FFD4E78D8B0
        public void get_height(){} // RVA: 0x7FFD51DEBEA0
        public void set_height(){} // RVA: 0x7FFD4F840230
        public void get_refreshRateRatio(){} // RVA: 0x7FFD53AD4B80
        public void get_refreshRate(){} // RVA: 0x7FFD54C91FF0
        public void set_refreshRate(){} // RVA: 0x7FFD54C92070
        public void ToString(){} // RVA: 0x7FFD54C92080
    }

    public class ResourceRequest : AsyncOperation
    {
        public string asset; // 0x20
        public System.Type m_Type; // 0x28

        // ── Methods ──
        public void GetResult(){} // RVA: 0x7FFD54CD8980
        public void get_asset(){} // RVA: 0x7FFD4E3F5BC0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Resources : Object
    {
        // ── Methods ──
        public void ConvertObjects(){} // RVA: 0x7FFD4E078F80
        public void FindObjectsOfTypeAll(){} // RVA: 0x7FFD4E078A90 | overloaded x2
        public void Load(){} // RVA: 0x7FFD54CD90D0 | overloaded x3
        public void LoadAsync(){} // RVA: 0x7FFD54CD9220 | overloaded x3
        public void GetBuiltinResource(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void UnloadAsset(){} // RVA: 0x7FFD54CD9300
        public void UnloadUnusedAssets(){} // RVA: 0x7FFD54CD9370
    }

    public class ResourcesAPI : Object
    {
        public UnityEngine.ResourcesAPI ActiveAPI;
        public UnityEngine.ResourcesAPI overrideAPI; // 0x8

        // ── Methods ──
        public void get_ActiveAPI(){} // RVA: 0x7FFD54CD8B50
        public void get_overrideAPI(){} // RVA: 0x7FFD54CD8C10
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void FindObjectsOfTypeAll(){} // RVA: 0x7FFD54CD8C70
        public void FindShaderByName(){} // RVA: 0x7FFD54CD8CC0
        public void Load(){} // RVA: 0x7FFD54CD8D10
        public void LoadAsync(){} // RVA: 0x7FFD54CD8D70
        public void UnloadAsset(){} // RVA: 0x7FFD54CD8EA0
        public void .cctor(){} // RVA: 0x7FFD54CD8EF0
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
        public void get_velocity(){} // RVA: 0x7FFD54DB4820
        public void set_velocity(){} // RVA: 0x7FFD54DB4890
        public void get_angularVelocity(){} // RVA: 0x7FFD54DB48F0
        public void set_angularVelocity(){} // RVA: 0x7FFD54DB4960
        public void get_drag(){} // RVA: 0x7FFD54DB49C0
        public void set_drag(){} // RVA: 0x7FFD54DB4A10
        public void get_angularDrag(){} // RVA: 0x7FFD54DB4A70
        public void set_angularDrag(){} // RVA: 0x7FFD54DB4AC0
        public void get_mass(){} // RVA: 0x7FFD54DB4B20
        public void set_mass(){} // RVA: 0x7FFD54DB4B70
        public void SetDensity(){} // RVA: 0x7FFD54DB4BD0
        public void get_useGravity(){} // RVA: 0x7FFD54DB4C30
        public void set_useGravity(){} // RVA: 0x7FFD54DB4C80
        public void get_maxDepenetrationVelocity(){} // RVA: 0x7FFD54DB4CE0
        public void set_maxDepenetrationVelocity(){} // RVA: 0x7FFD54DB4D30
        public void get_isKinematic(){} // RVA: 0x7FFD54DB4D90
        public void set_isKinematic(){} // RVA: 0x7FFD54DB4DE0
        public void get_freezeRotation(){} // RVA: 0x7FFD54DB4E40
        public void set_freezeRotation(){} // RVA: 0x7FFD54DB4E90
        public void get_constraints(){} // RVA: 0x7FFD54DB4EF0
        public void set_constraints(){} // RVA: 0x7FFD54DB4F40
        public void get_collisionDetectionMode(){} // RVA: 0x7FFD54DB4FA0
        public void set_collisionDetectionMode(){} // RVA: 0x7FFD54DB4FF0
        public void get_automaticCenterOfMass(){} // RVA: 0x7FFD54DB5050
        public void set_automaticCenterOfMass(){} // RVA: 0x7FFD54DB50A0
        public void get_centerOfMass(){} // RVA: 0x7FFD54DB5100
        public void set_centerOfMass(){} // RVA: 0x7FFD54DB5170
        public void get_worldCenterOfMass(){} // RVA: 0x7FFD54DB51D0
        public void get_automaticInertiaTensor(){} // RVA: 0x7FFD54DB5240
        public void set_automaticInertiaTensor(){} // RVA: 0x7FFD54DB5290
        public void get_inertiaTensorRotation(){} // RVA: 0x7FFD54DB52F0
        public void set_inertiaTensorRotation(){} // RVA: 0x7FFD54DB5360
        public void get_inertiaTensor(){} // RVA: 0x7FFD54DB53C0
        public void set_inertiaTensor(){} // RVA: 0x7FFD54DB5430
        public void get_detectCollisions(){} // RVA: 0x7FFD54DB5490
        public void set_detectCollisions(){} // RVA: 0x7FFD54DB54E0
        public void get_position(){} // RVA: 0x7FFD54DB5540
        public void set_position(){} // RVA: 0x7FFD54DB55B0
        public void get_rotation(){} // RVA: 0x7FFD54DB5610
        public void set_rotation(){} // RVA: 0x7FFD54DB5680
        public void get_interpolation(){} // RVA: 0x7FFD54DB56E0
        public void set_interpolation(){} // RVA: 0x7FFD54DB5730
        public void get_solverIterations(){} // RVA: 0x7FFD54DB5790
        public void set_solverIterations(){} // RVA: 0x7FFD54DB57E0
        public void get_sleepThreshold(){} // RVA: 0x7FFD54DB5840
        public void set_sleepThreshold(){} // RVA: 0x7FFD54DB5890
        public void get_maxAngularVelocity(){} // RVA: 0x7FFD54DB58F0
        public void set_maxAngularVelocity(){} // RVA: 0x7FFD54DB5940
        public void get_maxLinearVelocity(){} // RVA: 0x7FFD54DB59A0
        public void set_maxLinearVelocity(){} // RVA: 0x7FFD54DB59F0
        public void MovePosition(){} // RVA: 0x7FFD54DB5A50
        public void MoveRotation(){} // RVA: 0x7FFD54DB5AB0
        public void Move(){} // RVA: 0x7FFD54DB5B10
        public void Sleep(){} // RVA: 0x7FFD54DB5B80
        public void IsSleeping(){} // RVA: 0x7FFD54DB5BD0
        public void WakeUp(){} // RVA: 0x7FFD54DB5C20
        public void ResetCenterOfMass(){} // RVA: 0x7FFD54DB5C70
        public void ResetInertiaTensor(){} // RVA: 0x7FFD54DB5CC0
        public void GetRelativePointVelocity(){} // RVA: 0x7FFD54DB5D10
        public void GetPointVelocity(){} // RVA: 0x7FFD54DB5D90
        public void get_solverVelocityIterations(){} // RVA: 0x7FFD54DB5E10
        public void set_solverVelocityIterations(){} // RVA: 0x7FFD54DB5E60
        public void get_excludeLayers(){} // RVA: 0x7FFD54DB5EC0
        public void set_excludeLayers(){} // RVA: 0x7FFD54DB5F20
        public void get_includeLayers(){} // RVA: 0x7FFD54DB5F80
        public void set_includeLayers(){} // RVA: 0x7FFD54DB5FE0
        public void GetAccumulatedForce(){} // RVA: 0x7FFD54DB60C0 | overloaded x2
        public void GetAccumulatedTorque(){} // RVA: 0x7FFD54DB6220 | overloaded x2
        public void AddForce(){} // RVA: 0x7FFD54DB6450 | overloaded x4
        public void AddRelativeForce(){} // RVA: 0x7FFD54DB6610 | overloaded x4
        public void AddTorque(){} // RVA: 0x7FFD54DB67D0 | overloaded x4
        public void AddRelativeTorque(){} // RVA: 0x7FFD54DB6990 | overloaded x4
        public void AddForceAtPosition(){} // RVA: 0x7FFD54DB6A80 | overloaded x2
        public void AddExplosionForce(){} // RVA: 0x7FFD54DB6C40 | overloaded x3
        public void Internal_ClosestPointOnBounds(){} // RVA: 0x7FFD54DB6CE0
        public void ClosestPointOnBounds(){} // RVA: 0x7FFD54DB6D60
        public void SweepTest(){} // RVA: 0x7FFD54DB7080 | overloaded x4
        public void Internal_SweepTestAll(){} // RVA: 0x7FFD54DB70C0
        public void SweepTestAll(){} // RVA: 0x7FFD54DB7270 | overloaded x3
        public void get_sleepVelocity(){} // RVA: 0x7FFD54CAADC0
        public void set_sleepVelocity(){} // RVA: 0x7FFD4E341310
        public void get_sleepAngularVelocity(){} // RVA: 0x7FFD54CAADC0
        public void set_sleepAngularVelocity(){} // RVA: 0x7FFD4E341310
        public void SetMaxAngularVelocity(){} // RVA: 0x7FFD54DB5940
        public void get_useConeFriction(){} // RVA: 0x7FFD506288B0
        public void set_useConeFriction(){} // RVA: 0x7FFD4E341310
        public void get_solverIterationCount(){} // RVA: 0x7FFD54DB5790
        public void set_solverIterationCount(){} // RVA: 0x7FFD54DB57E0
        public void get_solverVelocityIterationCount(){} // RVA: 0x7FFD54DB5E10
        public void set_solverVelocityIterationCount(){} // RVA: 0x7FFD54DB5E60
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_velocity_Injected(){} // RVA: 0x7FFD54DB72B0
        public void set_velocity_Injected(){} // RVA: 0x7FFD54DB7310
        public void get_angularVelocity_Injected(){} // RVA: 0x7FFD54DB7370
        public void set_angularVelocity_Injected(){} // RVA: 0x7FFD54DB73D0
        public void get_centerOfMass_Injected(){} // RVA: 0x7FFD54DB7430
        public void set_centerOfMass_Injected(){} // RVA: 0x7FFD54DB7490
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x7FFD54DB74F0
        public void get_inertiaTensorRotation_Injected(){} // RVA: 0x7FFD54DB7550
        public void set_inertiaTensorRotation_Injected(){} // RVA: 0x7FFD54DB75B0
        public void get_inertiaTensor_Injected(){} // RVA: 0x7FFD54DB7610
        public void set_inertiaTensor_Injected(){} // RVA: 0x7FFD54DB7670
        public void get_position_Injected(){} // RVA: 0x7FFD54DB76D0
        public void set_position_Injected(){} // RVA: 0x7FFD54DB7730
        public void get_rotation_Injected(){} // RVA: 0x7FFD54DB7790
        public void set_rotation_Injected(){} // RVA: 0x7FFD54DB77F0
        public void MovePosition_Injected(){} // RVA: 0x7FFD54DB7850
        public void MoveRotation_Injected(){} // RVA: 0x7FFD54DB78B0
        public void Move_Injected(){} // RVA: 0x7FFD54DB7910
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x7FFD54DB7980
        public void GetPointVelocity_Injected(){} // RVA: 0x7FFD54DB79F0
        public void get_excludeLayers_Injected(){} // RVA: 0x7FFD54DB7A60
        public void set_excludeLayers_Injected(){} // RVA: 0x7FFD54DB7AC0
        public void get_includeLayers_Injected(){} // RVA: 0x7FFD54DB7B20
        public void set_includeLayers_Injected(){} // RVA: 0x7FFD54DB7B80
        public void GetAccumulatedForce_Injected(){} // RVA: 0x7FFD54DB7BE0
        public void GetAccumulatedTorque_Injected(){} // RVA: 0x7FFD54DB7C50
        public void AddForce_Injected(){} // RVA: 0x7FFD54DB7CC0
        public void AddRelativeForce_Injected(){} // RVA: 0x7FFD54DB7D30
        public void AddTorque_Injected(){} // RVA: 0x7FFD54DB7DA0
        public void AddRelativeTorque_Injected(){} // RVA: 0x7FFD54DB7E10
        public void AddForceAtPosition_Injected(){} // RVA: 0x7FFD54DB7E80
        public void AddExplosionForce_Injected(){} // RVA: 0x7FFD54DB7F00
        public void Internal_ClosestPointOnBounds_Injected(){} // RVA: 0x7FFD54DB7F90
        public void SweepTest_Injected(){} // RVA: 0x7FFD54DB8010
        public void Internal_SweepTestAll_Injected(){} // RVA: 0x7FFD54DB80A0
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
        public void get_position(){} // RVA: 0x7FFD54D99710
        public void set_position(){} // RVA: 0x7FFD54D99770
        public void get_rotation(){} // RVA: 0x7FFD54D997D0
        public void set_rotation(){} // RVA: 0x7FFD54D99820
        public void SetRotation(){} // RVA: 0x7FFD54D998E0 | overloaded x2
        public void SetRotation_Angle(){} // RVA: 0x7FFD54D99880
        public void SetRotation_Quaternion(){} // RVA: 0x7FFD54D99940
        public void MovePosition(){} // RVA: 0x7FFD54D999A0
        public void MoveRotation(){} // RVA: 0x7FFD54D99A60 | overloaded x2
        public void MoveRotation_Angle(){} // RVA: 0x7FFD54D99A00
        public void MoveRotation_Quaternion(){} // RVA: 0x7FFD54D99AC0
        public void get_velocity(){} // RVA: 0x7FFD54D99B20
        public void set_velocity(){} // RVA: 0x7FFD54D99B80
        public void get_angularVelocity(){} // RVA: 0x7FFD54D99BE0
        public void set_angularVelocity(){} // RVA: 0x7FFD54D99C30
        public void get_useAutoMass(){} // RVA: 0x7FFD54D99C90
        public void set_useAutoMass(){} // RVA: 0x7FFD54D99CE0
        public void get_mass(){} // RVA: 0x7FFD54D99D40
        public void set_mass(){} // RVA: 0x7FFD54D99D90
        public void get_sharedMaterial(){} // RVA: 0x7FFD54D99DF0
        public void set_sharedMaterial(){} // RVA: 0x7FFD54D99E40
        public void get_centerOfMass(){} // RVA: 0x7FFD54D99EA0
        public void set_centerOfMass(){} // RVA: 0x7FFD54D99F00
        public void get_worldCenterOfMass(){} // RVA: 0x7FFD54D99F60
        public void get_inertia(){} // RVA: 0x7FFD54D99FC0
        public void set_inertia(){} // RVA: 0x7FFD54D9A010
        public void get_drag(){} // RVA: 0x7FFD54D9A070
        public void set_drag(){} // RVA: 0x7FFD54D9A0C0
        public void get_angularDrag(){} // RVA: 0x7FFD54D9A120
        public void set_angularDrag(){} // RVA: 0x7FFD54D9A170
        public void get_gravityScale(){} // RVA: 0x7FFD54D9A1D0
        public void set_gravityScale(){} // RVA: 0x7FFD54D9A220
        public void get_bodyType(){} // RVA: 0x7FFD54D9A280
        public void set_bodyType(){} // RVA: 0x7FFD54D9A2D0
        public void get_useFullKinematicContacts(){} // RVA: 0x7FFD54D9A330
        public void set_useFullKinematicContacts(){} // RVA: 0x7FFD54D9A380
        public void get_isKinematic(){} // RVA: 0x7FFD54D9A3E0
        public void set_isKinematic(){} // RVA: 0x7FFD54D9A440
        public void get_freezeRotation(){} // RVA: 0x7FFD54D9A4B0
        public void set_freezeRotation(){} // RVA: 0x7FFD54D9A500
        public void get_constraints(){} // RVA: 0x7FFD54D9A560
        public void set_constraints(){} // RVA: 0x7FFD54D9A5B0
        public void IsSleeping(){} // RVA: 0x7FFD54D9A610
        public void IsAwake(){} // RVA: 0x7FFD54D9A660
        public void Sleep(){} // RVA: 0x7FFD54D9A6B0
        public void WakeUp(){} // RVA: 0x7FFD54D9A700
        public void get_simulated(){} // RVA: 0x7FFD54D9A750
        public void set_simulated(){} // RVA: 0x7FFD54D9A7A0
        public void get_interpolation(){} // RVA: 0x7FFD54D9A800
        public void set_interpolation(){} // RVA: 0x7FFD54D9A850
        public void get_sleepMode(){} // RVA: 0x7FFD54D9A8B0
        public void set_sleepMode(){} // RVA: 0x7FFD54D9A900
        public void get_collisionDetectionMode(){} // RVA: 0x7FFD54D9A960
        public void set_collisionDetectionMode(){} // RVA: 0x7FFD54D9A9B0
        public void get_attachedColliderCount(){} // RVA: 0x7FFD54D9AA10
        public void get_totalForce(){} // RVA: 0x7FFD54D9AA60
        public void set_totalForce(){} // RVA: 0x7FFD54D9AAC0
        public void get_totalTorque(){} // RVA: 0x7FFD54D9AB20
        public void set_totalTorque(){} // RVA: 0x7FFD54D9AB70
        public void get_excludeLayers(){} // RVA: 0x7FFD54D9ABD0
        public void set_excludeLayers(){} // RVA: 0x7FFD54D9AC30
        public void get_includeLayers(){} // RVA: 0x7FFD54D9AC90
        public void set_includeLayers(){} // RVA: 0x7FFD54D9ACF0
        public void IsTouching(){} // RVA: 0x7FFD54D9AEA0 | overloaded x3
        public void IsTouching_OtherColliderWithFilter_Internal(){} // RVA: 0x7FFD54D9AE30
        public void IsTouching_AnyColliderWithFilter_Internal(){} // RVA: 0x7FFD54D9AF10
        public void IsTouchingLayers(){} // RVA: 0x7FFD54D9AFD0 | overloaded x2
        public void OverlapPoint(){} // RVA: 0x7FFD54D9B030
        public void Distance(){} // RVA: 0x7FFD54D9B090
        public void Distance_Internal(){} // RVA: 0x7FFD54D9B3B0
        public void ClosestPoint(){} // RVA: 0x7FFD54D9B430
        public void AddForce(){} // RVA: 0x7FFD54D9B500 | overloaded x2
        public void AddRelativeForce(){} // RVA: 0x7FFD54D9B5D0 | overloaded x2
        public void AddForceAtPosition(){} // RVA: 0x7FFD54D9B6B0 | overloaded x2
        public void AddTorque(){} // RVA: 0x7FFD54D9B7A0 | overloaded x2
        public void GetPoint(){} // RVA: 0x7FFD54D9B810
        public void GetRelativePoint(){} // RVA: 0x7FFD54D9B880
        public void GetVector(){} // RVA: 0x7FFD54D9B8F0
        public void GetRelativeVector(){} // RVA: 0x7FFD54D9B960
        public void GetPointVelocity(){} // RVA: 0x7FFD54D9B9D0
        public void GetRelativePointVelocity(){} // RVA: 0x7FFD54D9BA40
        public void OverlapCollider(){} // RVA: 0x7FFD54D9BBA0 | overloaded x2
        public void OverlapColliderArray_Internal(){} // RVA: 0x7FFD54D9BB30
        public void OverlapColliderList_Internal(){} // RVA: 0x7FFD54D9BC20
        public void GetContacts(){} // RVA: 0x7FFD54D9C140 | overloaded x8
        public void GetAttachedColliders(){} // RVA: 0x7FFD54D9C230 | overloaded x2
        public void GetAttachedCollidersArray_Internal(){} // RVA: 0x7FFD54D9C1D0
        public void GetAttachedCollidersList_Internal(){} // RVA: 0x7FFD54D9C230
        public void Cast(){} // RVA: 0x7FFD54D9C630 | overloaded x6
        public void CastArray_Internal(){} // RVA: 0x7FFD54D9C2E0
        public void CastList_Internal(){} // RVA: 0x7FFD54D9C3E0
        public void CastFilteredArray_Internal(){} // RVA: 0x7FFD54D9C5A0
        public void CastFilteredList_Internal(){} // RVA: 0x7FFD54D9C6D0
        public void GetShapes(){} // RVA: 0x7FFD54D9C760
        public void GetShapes_Internal(){} // RVA: 0x7FFD54D9C7D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_position_Injected(){} // RVA: 0x7FFD54D9C830
        public void set_position_Injected(){} // RVA: 0x7FFD54D9C890
        public void SetRotation_Quaternion_Injected(){} // RVA: 0x7FFD54D9C8F0
        public void MovePosition_Injected(){} // RVA: 0x7FFD54D9C950
        public void MoveRotation_Quaternion_Injected(){} // RVA: 0x7FFD54D9C9B0
        public void get_velocity_Injected(){} // RVA: 0x7FFD54D9CA10
        public void set_velocity_Injected(){} // RVA: 0x7FFD54D9CA70
        public void get_centerOfMass_Injected(){} // RVA: 0x7FFD54D9CAD0
        public void set_centerOfMass_Injected(){} // RVA: 0x7FFD54D9CB30
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x7FFD54D9CB90
        public void get_totalForce_Injected(){} // RVA: 0x7FFD54D9CBF0
        public void set_totalForce_Injected(){} // RVA: 0x7FFD54D9CC50
        public void get_excludeLayers_Injected(){} // RVA: 0x7FFD54D9CCB0
        public void set_excludeLayers_Injected(){} // RVA: 0x7FFD54D9CD10
        public void get_includeLayers_Injected(){} // RVA: 0x7FFD54D9CD70
        public void set_includeLayers_Injected(){} // RVA: 0x7FFD54D9CDD0
        public void IsTouching_OtherColliderWithFilter_Internal_Injected(){} // RVA: 0x7FFD54D9CE30
        public void IsTouching_AnyColliderWithFilter_Internal_Injected(){} // RVA: 0x7FFD54D9CEA0
        public void OverlapPoint_Injected(){} // RVA: 0x7FFD54D9CF00
        public void Distance_Internal_Injected(){} // RVA: 0x7FFD54D9CF60
        public void AddForce_Injected(){} // RVA: 0x7FFD54D9CFD0
        public void AddRelativeForce_Injected(){} // RVA: 0x7FFD54D9D040
        public void AddForceAtPosition_Injected(){} // RVA: 0x7FFD54D9D0B0
        public void GetPoint_Injected(){} // RVA: 0x7FFD54D9D130
        public void GetRelativePoint_Injected(){} // RVA: 0x7FFD54D9D1A0
        public void GetVector_Injected(){} // RVA: 0x7FFD54D9D210
        public void GetRelativeVector_Injected(){} // RVA: 0x7FFD54D9D280
        public void GetPointVelocity_Injected(){} // RVA: 0x7FFD54D9D2F0
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x7FFD54D9D360
        public void OverlapColliderArray_Internal_Injected(){} // RVA: 0x7FFD54D9D3D0
        public void OverlapColliderList_Internal_Injected(){} // RVA: 0x7FFD54D9D440
        public void CastArray_Internal_Injected(){} // RVA: 0x7FFD54D9D4B0
        public void CastList_Internal_Injected(){} // RVA: 0x7FFD54D9D530
        public void CastFilteredArray_Internal_Injected(){} // RVA: 0x7FFD54D9D5B0
        public void CastFilteredList_Internal_Injected(){} // RVA: 0x7FFD54D9D640
    }

    public class RuntimeAnimatorController : Object
    {
        public object animationClips;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C53000
        public void get_animationClips(){} // RVA: 0x7FFD54C53050
    }

    public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
    {
        public 0x664DF300 loadType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3440C0 | overloaded x2
        public void set_loadType(){} // RVA: 0x7FFD4E3440C0
    }

}