// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 25
// Methods: 919

namespace ThirdParty.Unity.UnityEngine
{
    public class RangeInt : ValueType
    {
        // ── Original Methods ──
        public void get_end(){} // RVA: 0x7ffaaf2e51f0
        public void .ctor(){} // RVA: 0x7ffaa8e055a0
    }

    public class Ray : ValueType
    {
        public object position; // 0x3444D6B0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf288300
        public void get_origin(){} // RVA: 0x7ffaaf233d00
        public void set_origin(){} // RVA: 0x7ffaaad0d620
        public void get_direction(){} // RVA: 0x7ffaaf233d20
        public void set_direction(){} // RVA: 0x7ffaaf288340
        public void ToString(){} // RVA: 0x7ffaaf2883e0
        public void ToString(){} // RVA: 0x7ffaaf2883e0
        public void ToString(){} // RVA: 0x7ffaaf2883e0
        // ── Binary Analysis Named ──
        public void GetPoint(){} // RVA: 0x7ffaaf288370
    }

    public class RaycastHit : ValueType
    {
        public object m_FaceID; // 0x32D99850
        public object m_Collider; // 0x32D99850

        // ── Original Methods ──
        public void get_collider(){} // RVA: 0x7ffaaf3b5ca0
        public void get_colliderInstanceID(){} // RVA: 0x7ffaac6a0e00
        public void get_point(){} // RVA: 0x7ffaaf233d00
        public void set_point(){} // RVA: 0x7ffaaad0d620
        public void get_normal(){} // RVA: 0x7ffaaf233d20
        public void set_normal(){} // RVA: 0x7ffaaf233d40
        public void get_barycentricCoordinate(){} // RVA: 0x7ffaaf3b5d90
        public void set_barycentricCoordinate(){} // RVA: 0x7ffaaf3b5dc0
        public void get_distance(){} // RVA: 0x7ffaaf236d60
        public void set_distance(){} // RVA: 0x7ffaa89ff580
        public void get_triangleIndex(){} // RVA: 0x7ffaac0adb00
        public void CalculateRaycastTexCoord(){} // RVA: 0x7ffaaf3b5de0
        public void get_textureCoord(){} // RVA: 0x7ffaaf3b5e80
        public void get_textureCoord2(){} // RVA: 0x7ffaaf3b5f30
        public void get_transform(){} // RVA: 0x7ffaaf3b5fe0
        public void get_rigidbody(){} // RVA: 0x7ffaaf3b6200
        public void get_articulationBody(){} // RVA: 0x7ffaaf3b6340
        public void get_lightmapCoord(){} // RVA: 0x7ffaaf3b6480
        public void CalculateRaycastTexCoord_Injected(){} // RVA: 0x7ffaaf3b6700
    }

    public class RaycastHit2D : ValueType
    {
        public object m_Normal; // 0x32F385E0
        public object m_Collider; // 0x32F385E0

        // ── Original Methods ──
        public void get_centroid(){} // RVA: 0x7ffaaabdb990
        public void set_centroid(){} // RVA: 0x7ffaa9fe08a0
        public void get_point(){} // RVA: 0x7ffaaf288780
        public void set_point(){} // RVA: 0x7ffaaa40d8d0
        public void get_normal(){} // RVA: 0x7ffaaf399860
        public void set_normal(){} // RVA: 0x7ffaa9e463c0
        public void get_distance(){} // RVA: 0x7ffaaf233d50
        public void set_distance(){} // RVA: 0x7ffaa894d4d0
        public void get_fraction(){} // RVA: 0x7ffaaf236d60
        public void set_fraction(){} // RVA: 0x7ffaa89ff580
        public void get_collider(){} // RVA: 0x7ffaaf39af00
        public void get_rigidbody(){} // RVA: 0x7ffaaf39aff0
        public void get_transform(){} // RVA: 0x7ffaaf39b130
        public void op_Implicit(){} // RVA: 0x7ffaaf39b350
        public void CompareTo(){} // RVA: 0x7ffaaf39b430
    }

    public class Rect : ValueType
    {
        public object m_Width; // 0x30D43AA0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa49db10
        public void .ctor(){} // RVA: 0x7ffaaa49db10
        public void .ctor(){} // RVA: 0x7ffaaa49db10
        public void get_zero(){} // RVA: 0x7ffaaf2885d0
        public void MinMaxRect(){} // RVA: 0x7ffaaf2885e0
        public void get_x(){} // RVA: 0x7ffaa8955d20
        public void set_x(){} // RVA: 0x7ffaaa49daf0
        public void get_y(){} // RVA: 0x7ffaa8955d30
        public void set_y(){} // RVA: 0x7ffaaa49db00
        public void get_position(){} // RVA: 0x7ffaaf288620
        public void set_position(){} // RVA: 0x7ffaaf288640
        public void get_center(){} // RVA: 0x7ffaaf288660
        public void set_center(){} // RVA: 0x7ffaaf288690
        public void get_min(){} // RVA: 0x7ffaaf2886d0
        public void set_min(){} // RVA: 0x7ffaaf2886f0
        public void get_max(){} // RVA: 0x7ffaaf288730
        public void set_max(){} // RVA: 0x7ffaaf288750
        public void get_width(){} // RVA: 0x7ffaa8955cf0
        public void set_width(){} // RVA: 0x7ffaaa49dae0
        public void get_height(){} // RVA: 0x7ffaa8955d00
        public void set_height(){} // RVA: 0x7ffaaa49dad0
        public void get_size(){} // RVA: 0x7ffaaf288780
        public void set_size(){} // RVA: 0x7ffaaf2887a0
        public void get_xMin(){} // RVA: 0x7ffaa8955d20
        public void set_xMin(){} // RVA: 0x7ffaaf2887c0
        public void get_yMin(){} // RVA: 0x7ffaa8955d30
        public void set_yMin(){} // RVA: 0x7ffaaf2887e0
        public void get_xMax(){} // RVA: 0x7ffaaf288800
        public void set_xMax(){} // RVA: 0x7ffaaf288810
        public void get_yMax(){} // RVA: 0x7ffaaf288820
        public void set_yMax(){} // RVA: 0x7ffaaf288830
        public void Contains(){} // RVA: 0x7ffaaf2888c0
        public void Contains(){} // RVA: 0x7ffaaf2888c0
        public void Contains(){} // RVA: 0x7ffaaf2888c0
        public void OrderMinMax(){} // RVA: 0x7ffaaf2889e0
        public void Overlaps(){} // RVA: 0x7ffaaf288aa0
        public void Overlaps(){} // RVA: 0x7ffaaf288aa0
        public void NormalizedToPoint(){} // RVA: 0x7ffaaf288c00
        public void PointToNormalized(){} // RVA: 0x7ffaaf288c80
        public void op_Inequality(){} // RVA: 0x7ffaaf288d20
        public void op_Equality(){} // RVA: 0x7ffaaf288d70
        public void Equals(){} // RVA: 0x7ffaaa931020
        public void Equals(){} // RVA: 0x7ffaaa931020
        public void ToString(){} // RVA: 0x7ffaaf288ee0
        public void ToString(){} // RVA: 0x7ffaaf288ee0
        public void ToString(){} // RVA: 0x7ffaaf288ee0
        // ── Binary Analysis Named ──
        public void Set(){} // RVA: 0x7ffaa8956570
        public void GetHashCode(){} // RVA: 0x7ffaaf288db0
    }

    public class RectInt : ValueType
    {
        public object m_Width; // 0x32CD9FF0

        // ── Original Methods ──
        public void get_x(){} // RVA: 0x7ffaae9b5f60
        public void set_x(){} // RVA: 0x7ffaa8d92880
        public void get_y(){} // RVA: 0x7ffaac3dc380
        public void set_y(){} // RVA: 0x7ffaa9e475c0
        public void get_width(){} // RVA: 0x7ffaabf4ae50
        public void set_width(){} // RVA: 0x7ffaaa3cef90
        public void get_height(){} // RVA: 0x7ffaabfb0760
        public void set_height(){} // RVA: 0x7ffaaa3cefb0
        public void get_xMin(){} // RVA: 0x7ffaaf289270
        public void get_yMin(){} // RVA: 0x7ffaaf2892e0
        public void get_xMax(){} // RVA: 0x7ffaaf289350
        public void get_yMax(){} // RVA: 0x7ffaaf2893c0
        public void .ctor(){} // RVA: 0x7ffaadd40830
        public void Overlaps(){} // RVA: 0x7ffaaf289430
        public void ToString(){} // RVA: 0x7ffaaf2894e0
        public void ToString(){} // RVA: 0x7ffaaf2894e0
        public void Equals(){} // RVA: 0x7ffaaf289930
    }

    public class RectOffset : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf289ab0
        public void .ctor(){} // RVA: 0x7ffaaf289ab0
        public void Finalize(){} // RVA: 0x7ffaaf289a10
        public void .ctor(){} // RVA: 0x7ffaaf289ab0
        public void ToString(){} // RVA: 0x7ffaaf289c60
        public void ToString(){} // RVA: 0x7ffaaf289c60
        public void Destroy(){} // RVA: 0x7ffaaf28a1c0
        public void InternalCreate(){} // RVA: 0x7ffaaf28a230
        public void InternalDestroy(){} // RVA: 0x7ffaaf28a280
        public void get_left(){} // RVA: 0x7ffaaf28a2d0
        public void set_left(){} // RVA: 0x7ffaaf28a320
        public void get_right(){} // RVA: 0x7ffaaf28a380
        public void set_right(){} // RVA: 0x7ffaaf28a3d0
        public void get_top(){} // RVA: 0x7ffaaf28a430
        public void set_top(){} // RVA: 0x7ffaaf28a480
        public void get_bottom(){} // RVA: 0x7ffaaf28a4e0
        public void set_bottom(){} // RVA: 0x7ffaaf28a530
        public void get_horizontal(){} // RVA: 0x7ffaaf28a590
        public void get_vertical(){} // RVA: 0x7ffaaf28a5e0
        public void Remove(){} // RVA: 0x7ffaaf28a630
        public void Remove_Injected(){} // RVA: 0x7ffaaf28a6b0
    }

    public class RectTransform : Transform
    {
        // ── Original Methods ──
        public void add_reapplyDrivenProperties(){} // RVA: 0x7ffaaf2f02f0
        public void remove_reapplyDrivenProperties(){} // RVA: 0x7ffaaf2f0400
        public void get_rect(){} // RVA: 0x7ffaaf2f0510
        public void get_anchorMin(){} // RVA: 0x7ffaaf2f0580
        public void set_anchorMin(){} // RVA: 0x7ffaaf2f05e0
        public void get_anchorMax(){} // RVA: 0x7ffaaf2f0640
        public void set_anchorMax(){} // RVA: 0x7ffaaf2f06a0
        public void get_anchoredPosition(){} // RVA: 0x7ffaaf2f0700
        public void set_anchoredPosition(){} // RVA: 0x7ffaaf2f0760
        public void get_sizeDelta(){} // RVA: 0x7ffaaf2f07c0
        public void set_sizeDelta(){} // RVA: 0x7ffaaf2f0820
        public void get_pivot(){} // RVA: 0x7ffaaf2f0880
        public void set_pivot(){} // RVA: 0x7ffaaf2f08e0
        public void get_anchoredPosition3D(){} // RVA: 0x7ffaaf2f0940
        public void set_anchoredPosition3D(){} // RVA: 0x7ffaaf2f0a20
        public void get_offsetMin(){} // RVA: 0x7ffaaf2f0b50
        public void set_offsetMin(){} // RVA: 0x7ffaaf2f0c80
        public void get_offsetMax(){} // RVA: 0x7ffaaf2f1000
        public void set_offsetMax(){} // RVA: 0x7ffaaf2f1190
        public void get_drivenByObject(){} // RVA: 0x7ffaaf2f14f0
        public void set_drivenByObject(){} // RVA: 0x7ffaaf2f1540
        public void get_drivenProperties(){} // RVA: 0x7ffaaf2f15a0
        public void set_drivenProperties(){} // RVA: 0x7ffaaf2f15f0
        public void ForceUpdateRectTransforms(){} // RVA: 0x7ffaaf2f1650
        public void SendReapplyDrivenProperties(){} // RVA: 0x7ffaaf2f2440
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_rect_Injected(){} // RVA: 0x7ffaaf2f2b40
        public void get_anchorMin_Injected(){} // RVA: 0x7ffaaf2f2ba0
        public void set_anchorMin_Injected(){} // RVA: 0x7ffaaf2f2c00
        public void get_anchorMax_Injected(){} // RVA: 0x7ffaaf2f2c60
        public void set_anchorMax_Injected(){} // RVA: 0x7ffaaf2f2cc0
        public void get_anchoredPosition_Injected(){} // RVA: 0x7ffaaf2f2d20
        public void set_anchoredPosition_Injected(){} // RVA: 0x7ffaaf2f2d80
        public void get_sizeDelta_Injected(){} // RVA: 0x7ffaaf2f2de0
        public void set_sizeDelta_Injected(){} // RVA: 0x7ffaaf2f2e40
        public void get_pivot_Injected(){} // RVA: 0x7ffaaf2f2ea0
        public void set_pivot_Injected(){} // RVA: 0x7ffaaf2f2f00
        // ── Binary Analysis Named ──
        public void GetLocalCorners(){} // RVA: 0x7ffaaf2f16a0
        public void GetWorldCorners(){} // RVA: 0x7ffaaf2f1820
        public void SetInsetAndSizeFromParentEdge(){} // RVA: 0x7ffaaf2f1b90
        public void SetSizeWithCurrentAnchors(){} // RVA: 0x7ffaaf2f20e0
        public void GetRectInParentSpace(){} // RVA: 0x7ffaaf2f24a0
        public void GetParentSize(){} // RVA: 0x7ffaaf2f2960
    }

    public class ReflectionProbe : Behaviour
    {
        public object registeredDefaultReflectionTextureActions; // 0x32CDA640

        // ── Original Methods ──
        public void get_type(){} // RVA: 0x7ffaaf27eb70
        public void set_type(){} // RVA: 0x7ffaaf27ebc0
        public void get_size(){} // RVA: 0x7ffaaf27ec20
        public void set_size(){} // RVA: 0x7ffaaf27ec90
        public void get_center(){} // RVA: 0x7ffaaf27ecf0
        public void set_center(){} // RVA: 0x7ffaaf27ed60
        public void get_nearClipPlane(){} // RVA: 0x7ffaaf27edc0
        public void set_nearClipPlane(){} // RVA: 0x7ffaaf27ee10
        public void get_farClipPlane(){} // RVA: 0x7ffaaf27ee70
        public void set_farClipPlane(){} // RVA: 0x7ffaaf27eec0
        public void get_intensity(){} // RVA: 0x7ffaaf27ef20
        public void set_intensity(){} // RVA: 0x7ffaaf27ef70
        public void get_bounds(){} // RVA: 0x7ffaaf27efd0
        public void get_hdr(){} // RVA: 0x7ffaaf27f040
        public void set_hdr(){} // RVA: 0x7ffaaf27f090
        public void get_renderDynamicObjects(){} // RVA: 0x7ffaaf27f0f0
        public void set_renderDynamicObjects(){} // RVA: 0x7ffaaf27f140
        public void get_shadowDistance(){} // RVA: 0x7ffaaf27f1a0
        public void set_shadowDistance(){} // RVA: 0x7ffaaf27f1f0
        public void get_resolution(){} // RVA: 0x7ffaaf27f250
        public void set_resolution(){} // RVA: 0x7ffaaf27f2a0
        public void get_cullingMask(){} // RVA: 0x7ffaaf27f300
        public void set_cullingMask(){} // RVA: 0x7ffaaf27f350
        public void get_clearFlags(){} // RVA: 0x7ffaaf27f3b0
        public void set_clearFlags(){} // RVA: 0x7ffaaf27f400
        public void get_backgroundColor(){} // RVA: 0x7ffaaf27f460
        public void set_backgroundColor(){} // RVA: 0x7ffaaf27f4d0
        public void get_blendDistance(){} // RVA: 0x7ffaaf27f530
        public void set_blendDistance(){} // RVA: 0x7ffaaf27f580
        public void get_boxProjection(){} // RVA: 0x7ffaaf27f5e0
        public void set_boxProjection(){} // RVA: 0x7ffaaf27f630
        public void get_mode(){} // RVA: 0x7ffaaf27f690
        public void set_mode(){} // RVA: 0x7ffaaf27f6e0
        public void get_importance(){} // RVA: 0x7ffaaf27f740
        public void set_importance(){} // RVA: 0x7ffaaf27f790
        public void get_refreshMode(){} // RVA: 0x7ffaaf27f7f0
        public void set_refreshMode(){} // RVA: 0x7ffaaf27f840
        public void get_timeSlicingMode(){} // RVA: 0x7ffaaf27f8a0
        public void set_timeSlicingMode(){} // RVA: 0x7ffaaf27f8f0
        public void get_bakedTexture(){} // RVA: 0x7ffaaf27f950
        public void set_bakedTexture(){} // RVA: 0x7ffaaf27f9a0
        public void get_customBakedTexture(){} // RVA: 0x7ffaaf27fa00
        public void set_customBakedTexture(){} // RVA: 0x7ffaaf27fa50
        public void get_realtimeTexture(){} // RVA: 0x7ffaaf27fab0
        public void set_realtimeTexture(){} // RVA: 0x7ffaaf27fb00
        public void get_texture(){} // RVA: 0x7ffaaf27fb60
        public void get_textureHDRDecodeValues(){} // RVA: 0x7ffaaf27fbb0
        public void Reset(){} // RVA: 0x7ffaaf27fc20
        public void RenderProbe(){} // RVA: 0x7ffaaf27fc80
        public void RenderProbe(){} // RVA: 0x7ffaaf27fc80
        public void IsFinishedRendering(){} // RVA: 0x7ffaaf27fd30
        public void ScheduleRender(){} // RVA: 0x7ffaaf27fd90
        public void BlendCubemap(){} // RVA: 0x7ffaaf27fe00
        public void UpdateCachedState(){} // RVA: 0x7ffaaf27fe80
        public void get_minBakedCubemapResolution(){} // RVA: 0x7ffaaf27fed0
        public void get_maxBakedCubemapResolution(){} // RVA: 0x7ffaaf27ff20
        public void get_defaultTextureHDRDecodeValues(){} // RVA: 0x7ffaaf27ff70
        public void get_defaultTexture(){} // RVA: 0x7ffaaf280000
        public void add_reflectionProbeChanged(){} // RVA: 0x7ffaaf280050
        public void remove_reflectionProbeChanged(){} // RVA: 0x7ffaaf2801b0
        public void CallReflectionProbeEvent(){} // RVA: 0x7ffaaf280310
        public void add_defaultReflectionSet(){} // RVA: 0x7ffaaf280390
        public void remove_defaultReflectionSet(){} // RVA: 0x7ffaaf2805e0
        public void add_defaultReflectionTexture(){} // RVA: 0x7ffaaf2807c0
        public void remove_defaultReflectionTexture(){} // RVA: 0x7ffaaf280a70
        public void CallSetDefaultReflection(){} // RVA: 0x7ffaaf280b00
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void .cctor(){} // RVA: 0x7ffaaf280c90
        public void get_size_Injected(){} // RVA: 0x7ffaaf280e30
        public void set_size_Injected(){} // RVA: 0x7ffaaf280e90
        public void get_center_Injected(){} // RVA: 0x7ffaaf280ef0
        public void set_center_Injected(){} // RVA: 0x7ffaaf280f50
        public void get_bounds_Injected(){} // RVA: 0x7ffaaf280fb0
        public void get_backgroundColor_Injected(){} // RVA: 0x7ffaaf281010
        public void set_backgroundColor_Injected(){} // RVA: 0x7ffaaf281070
        public void get_textureHDRDecodeValues_Injected(){} // RVA: 0x7ffaaf2810d0
        public void get_defaultTextureHDRDecodeValues_Injected(){} // RVA: 0x7ffaaf281130
    }

    public class RefreshRate : ValueType
    {
        // ── Original Methods ──
        public void get_value(){} // RVA: 0x7ffaaf28df00
        public void Equals(){} // RVA: 0x7ffaaf28df20
        public void CompareTo(){} // RVA: 0x7ffaaf28df60
        public void ToString(){} // RVA: 0x7ffaaf28dfb0
    }

    public class RelativeJoint2D : Joint2D
    {
        // ── Original Methods ──
        public void get_maxForce(){} // RVA: 0x7ffaaf3a5f80
        public void set_maxForce(){} // RVA: 0x7ffaaf3a5fd0
        public void get_maxTorque(){} // RVA: 0x7ffaaf3a6030
        public void set_maxTorque(){} // RVA: 0x7ffaaf3a6080
        public void get_correctionScale(){} // RVA: 0x7ffaaf3a60e0
        public void set_correctionScale(){} // RVA: 0x7ffaaf3a6130
        public void get_autoConfigureOffset(){} // RVA: 0x7ffaaf3a6190
        public void set_autoConfigureOffset(){} // RVA: 0x7ffaaf3a61e0
        public void get_linearOffset(){} // RVA: 0x7ffaaf3a6240
        public void set_linearOffset(){} // RVA: 0x7ffaaf3a62a0
        public void get_angularOffset(){} // RVA: 0x7ffaaf3a6300
        public void set_angularOffset(){} // RVA: 0x7ffaaf3a6350
        public void get_target(){} // RVA: 0x7ffaaf3a63b0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_linearOffset_Injected(){} // RVA: 0x7ffaaf3a6410
        public void set_linearOffset_Injected(){} // RVA: 0x7ffaaf3a6470
        public void get_target_Injected(){} // RVA: 0x7ffaaf3a64d0
    }

    public class RemoteConfigSettings : Object
    {
        // ── Original Methods ──
        public void RemoteConfigSettingsUpdated(){} // RVA: 0x7ffaaf6b00c0
    }

    public class RemoteSettings : Object
    {
        public object Completed; // 0x32DF3000

        // ── Original Methods ──
        public void RemoteSettingsUpdated(){} // RVA: 0x7ffaaf6aff80
        public void RemoteSettingsBeforeFetchFromServer(){} // RVA: 0x7ffaaf6affe0
        public void RemoteSettingsUpdateCompleted(){} // RVA: 0x7ffaaf6b0040
    }

    public class RenderSettings : Object
    {
        // ── Original Methods ──
        public void get_fog(){} // RVA: 0x7ffaaf2a0970
        public void set_fog(){} // RVA: 0x7ffaaf2a09c0
        public void get_fogStartDistance(){} // RVA: 0x7ffaaf2a0a10
        public void set_fogStartDistance(){} // RVA: 0x7ffaaf2a0a60
        public void get_fogEndDistance(){} // RVA: 0x7ffaaf2a0ac0
        public void set_fogEndDistance(){} // RVA: 0x7ffaaf2a0b10
        public void get_fogMode(){} // RVA: 0x7ffaaf2a0b70
        public void set_fogMode(){} // RVA: 0x7ffaaf2a0bc0
        public void get_fogColor(){} // RVA: 0x7ffaaf2a0c10
        public void set_fogColor(){} // RVA: 0x7ffaaf2a0c70
        public void get_fogDensity(){} // RVA: 0x7ffaaf2a0cc0
        public void set_fogDensity(){} // RVA: 0x7ffaaf2a0d10
        public void get_ambientMode(){} // RVA: 0x7ffaaf2a0d70
        public void set_ambientMode(){} // RVA: 0x7ffaaf2a0dc0
        public void get_ambientSkyColor(){} // RVA: 0x7ffaaf2a0e10
        public void set_ambientSkyColor(){} // RVA: 0x7ffaaf2a0e70
        public void get_ambientEquatorColor(){} // RVA: 0x7ffaaf2a0ec0
        public void set_ambientEquatorColor(){} // RVA: 0x7ffaaf2a0f20
        public void get_ambientGroundColor(){} // RVA: 0x7ffaaf2a0f70
        public void set_ambientGroundColor(){} // RVA: 0x7ffaaf2a0fd0
        public void get_ambientIntensity(){} // RVA: 0x7ffaaf2a1020
        public void set_ambientIntensity(){} // RVA: 0x7ffaaf2a1070
        public void get_ambientLight(){} // RVA: 0x7ffaaf2a10d0
        public void set_ambientLight(){} // RVA: 0x7ffaaf2a1130
        public void get_subtractiveShadowColor(){} // RVA: 0x7ffaaf2a1180
        public void set_subtractiveShadowColor(){} // RVA: 0x7ffaaf2a11e0
        public void get_skybox(){} // RVA: 0x7ffaaf2a1230
        public void set_skybox(){} // RVA: 0x7ffaaf2a1280
        public void get_sun(){} // RVA: 0x7ffaaf2a12d0
        public void set_sun(){} // RVA: 0x7ffaaf2a1320
        public void get_ambientProbe(){} // RVA: 0x7ffaaf2a1370
        public void set_ambientProbe(){} // RVA: 0x7ffaaf2a13f0
        public void get_customReflectionTexture(){} // RVA: 0x7ffaaf2a1440
        public void set_customReflectionTexture(){} // RVA: 0x7ffaaf2a1490
        public void get_reflectionIntensity(){} // RVA: 0x7ffaaf2a14e0
        public void set_reflectionIntensity(){} // RVA: 0x7ffaaf2a1530
        public void get_reflectionBounces(){} // RVA: 0x7ffaaf2a1590
        public void set_reflectionBounces(){} // RVA: 0x7ffaaf2a15e0
        public void get_defaultReflectionMode(){} // RVA: 0x7ffaaf2a1630
        public void set_defaultReflectionMode(){} // RVA: 0x7ffaaf2a1680
        public void get_defaultReflectionResolution(){} // RVA: 0x7ffaaf2a16d0
        public void set_defaultReflectionResolution(){} // RVA: 0x7ffaaf2a1720
        public void get_haloStrength(){} // RVA: 0x7ffaaf2a1770
        public void set_haloStrength(){} // RVA: 0x7ffaaf2a17c0
        public void get_flareStrength(){} // RVA: 0x7ffaaf2a1820
        public void set_flareStrength(){} // RVA: 0x7ffaaf2a1870
        public void get_flareFadeSpeed(){} // RVA: 0x7ffaaf2a18d0
        public void set_flareFadeSpeed(){} // RVA: 0x7ffaaf2a1920
        public void get_fogColor_Injected(){} // RVA: 0x7ffaaf2a1980
        public void set_fogColor_Injected(){} // RVA: 0x7ffaaf2a19d0
        public void get_ambientSkyColor_Injected(){} // RVA: 0x7ffaaf2a1a20
        public void set_ambientSkyColor_Injected(){} // RVA: 0x7ffaaf2a1a70
        public void get_ambientEquatorColor_Injected(){} // RVA: 0x7ffaaf2a1ac0
        public void set_ambientEquatorColor_Injected(){} // RVA: 0x7ffaaf2a1b10
        public void get_ambientGroundColor_Injected(){} // RVA: 0x7ffaaf2a1b60
        public void set_ambientGroundColor_Injected(){} // RVA: 0x7ffaaf2a1bb0
        public void get_ambientLight_Injected(){} // RVA: 0x7ffaaf2a1c00
        public void set_ambientLight_Injected(){} // RVA: 0x7ffaaf2a1c50
        public void get_subtractiveShadowColor_Injected(){} // RVA: 0x7ffaaf2a1ca0
        public void set_subtractiveShadowColor_Injected(){} // RVA: 0x7ffaaf2a1cf0
        public void get_ambientProbe_Injected(){} // RVA: 0x7ffaaf2a1d40
        public void set_ambientProbe_Injected(){} // RVA: 0x7ffaaf2a1d90
    }

    public class RenderTexture : Texture
    {
        // ── Original Methods ──
        public void get_width(){} // RVA: 0x7ffaaf2c2f30
        public void set_width(){} // RVA: 0x7ffaaf2c2f80
        public void get_height(){} // RVA: 0x7ffaaf2c2fe0
        public void set_height(){} // RVA: 0x7ffaaf2c3030
        public void get_dimension(){} // RVA: 0x7ffaaf2c3090
        public void set_dimension(){} // RVA: 0x7ffaaf2c30e0
        public void get_graphicsFormat(){} // RVA: 0x7ffaaf2c3200
        public void set_graphicsFormat(){} // RVA: 0x7ffaaf2c31a0
        public void get_useMipMap(){} // RVA: 0x7ffaaf2c3260
        public void set_useMipMap(){} // RVA: 0x7ffaaf2c32b0
        public void get_sRGB(){} // RVA: 0x7ffaaf2c3310
        public void get_vrUsage(){} // RVA: 0x7ffaaf2c3360
        public void set_vrUsage(){} // RVA: 0x7ffaaf2c33b0
        public void get_memorylessMode(){} // RVA: 0x7ffaaf2c3410
        public void set_memorylessMode(){} // RVA: 0x7ffaaf2c3460
        public void get_format(){} // RVA: 0x7ffaaf2c34c0
        public void set_format(){} // RVA: 0x7ffaaf2c3650
        public void get_stencilFormat(){} // RVA: 0x7ffaaf2c3740
        public void set_stencilFormat(){} // RVA: 0x7ffaaf2c3790
        public void get_depthStencilFormat(){} // RVA: 0x7ffaaf2c37f0
        public void set_depthStencilFormat(){} // RVA: 0x7ffaaf2c3840
        public void get_autoGenerateMips(){} // RVA: 0x7ffaaf2c38a0
        public void set_autoGenerateMips(){} // RVA: 0x7ffaaf2c38f0
        public void get_volumeDepth(){} // RVA: 0x7ffaaf2c3950
        public void set_volumeDepth(){} // RVA: 0x7ffaaf2c39a0
        public void get_antiAliasing(){} // RVA: 0x7ffaaf2c3a00
        public void set_antiAliasing(){} // RVA: 0x7ffaaf2c3a50
        public void get_bindTextureMS(){} // RVA: 0x7ffaaf2c3ab0
        public void set_bindTextureMS(){} // RVA: 0x7ffaaf2c3b00
        public void get_enableRandomWrite(){} // RVA: 0x7ffaaf2c3b60
        public void set_enableRandomWrite(){} // RVA: 0x7ffaaf2c3bb0
        public void get_useDynamicScale(){} // RVA: 0x7ffaaf2c3c10
        public void set_useDynamicScale(){} // RVA: 0x7ffaaf2c3c60
        public void get_isPowerOfTwo(){} // RVA: 0x7ffaaf2c3cc0
        public void set_isPowerOfTwo(){} // RVA: 0x7ffaa8932310
        public void get_active(){} // RVA: 0x7ffaaf2c3d10
        public void set_active(){} // RVA: 0x7ffaaf2c3d60
        public void get_colorBuffer(){} // RVA: 0x7ffaaf2c3f50
        public void get_depthBuffer(){} // RVA: 0x7ffaaf2c3fd0
        public void DiscardContents(){} // RVA: 0x7ffaaf2c4170
        public void MarkRestoreExpected(){} // RVA: 0x7ffaaf2c4120
        public void DiscardContents(){} // RVA: 0x7ffaaf2c4170
        public void ResolveAA(){} // RVA: 0x7ffaaf2c41d0
        public void ResolveAATo(){} // RVA: 0x7ffaaf2c4220
        public void ResolveAntiAliasedSurface(){} // RVA: 0x7ffaaf2c4220
        public void ResolveAntiAliasedSurface(){} // RVA: 0x7ffaaf2c4220
        public void Create(){} // RVA: 0x7ffaaf2c42e0
        public void Release(){} // RVA: 0x7ffaaf2c4330
        public void IsCreated(){} // RVA: 0x7ffaaf2c4380
        public void GenerateMips(){} // RVA: 0x7ffaaf2c43d0
        public void ConvertToEquirect(){} // RVA: 0x7ffaaf2c4420
        public void Internal_Create(){} // RVA: 0x7ffaaf2c44f0
        public void SupportsStencil(){} // RVA: 0x7ffaaf2c4540
        public void ReleaseTemporary(){} // RVA: 0x7ffaaf2c46c0
        public void get_depth(){} // RVA: 0x7ffaaf2c4710
        public void set_depth(){} // RVA: 0x7ffaaf2c4760
        public void .ctor(){} // RVA: 0x7ffaaf2c5660
        public void .ctor(){} // RVA: 0x7ffaaf2c5660
        public void .ctor(){} // RVA: 0x7ffaaf2c5660
        public void .ctor(){} // RVA: 0x7ffaaf2c5660
        public void .ctor(){} // RVA: 0x7ffaaf2c5660
        public void .ctor(){} // RVA: 0x7ffaaf2c5660
        public void .ctor(){} // RVA: 0x7ffaaf2c5660
        public void .ctor(){} // RVA: 0x7ffaaf2c5660
        public void .ctor(){} // RVA: 0x7ffaaf2c5660
        public void .ctor(){} // RVA: 0x7ffaaf2c5660
        public void .ctor(){} // RVA: 0x7ffaaf2c5660
        public void .ctor(){} // RVA: 0x7ffaaf2c5660
        public void Initialize(){} // RVA: 0x7ffaaf2c5730
        public void get_descriptor(){} // RVA: 0x7ffaaf2c5af0
        public void set_descriptor(){} // RVA: 0x7ffaaf2c5ba0
        public void ValidateRenderTextureDesc(){} // RVA: 0x7ffaaf2c5c60
        public void get_isCubemap(){} // RVA: 0x7ffaaf2c6ca0
        public void set_isCubemap(){} // RVA: 0x7ffaaf2c6cd0
        public void get_isVolume(){} // RVA: 0x7ffaaf2c6d10
        public void set_isVolume(){} // RVA: 0x7ffaaf2c6d40
        public void get_enabled(){} // RVA: 0x7ffaaa5f9770
        public void set_enabled(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetColorFormat(){} // RVA: 0x7ffaaf2c3140
        public void SetColorFormat(){} // RVA: 0x7ffaaf2c31a0
        public void GetIsPowerOfTwo(){} // RVA: 0x7ffaaf2c3cc0
        public void GetActive(){} // RVA: 0x7ffaaf2c3d10
        public void SetActive(){} // RVA: 0x7ffaaf2c3d60
        public void GetColorBuffer(){} // RVA: 0x7ffaaf2c3db0
        public void GetDepthBuffer(){} // RVA: 0x7ffaaf2c3e20
        public void SetMipMapCount(){} // RVA: 0x7ffaaf2c3e90
        public void SetShadowSamplingMode(){} // RVA: 0x7ffaaf2c3ef0
        public void GetNativeDepthBufferPtr(){} // RVA: 0x7ffaaf2c4050
        public void SetGlobalShaderProperty(){} // RVA: 0x7ffaaf2c4280
        public void SetSRGBReadWrite(){} // RVA: 0x7ffaaf2c4490
        public void SetRenderTextureDescriptor(){} // RVA: 0x7ffaaf2c4590
        public void GetDescriptor(){} // RVA: 0x7ffaaf2c45f0
        public void GetTemporary_Internal(){} // RVA: 0x7ffaaf2c4670
        public void GetDepthStencilFormatLegacy(){} // RVA: 0x7ffaaf2c5a60
        public void GetDepthStencilFormatLegacy(){} // RVA: 0x7ffaaf2c5a60
        public void GetDepthStencilFormatLegacy(){} // RVA: 0x7ffaaf2c5a60
        public void GetDepthStencilFormatLegacy(){} // RVA: 0x7ffaaf2c5a60
        public void GetDefaultColorFormat(){} // RVA: 0x7ffaaf2c61f0
        public void GetDefaultDepthStencilFormat(){} // RVA: 0x7ffaaf2c6260
        public void GetCompatibleFormat(){} // RVA: 0x7ffaaf2c62d0
        public void GetTemporary(){} // RVA: 0x7ffaaf2c6c70
        public void GetTemporaryImpl(){} // RVA: 0x7ffaaf2c6540
        public void GetTemporary(){} // RVA: 0x7ffaaf2c6c70
        public void GetTemporary(){} // RVA: 0x7ffaaf2c6c70
        public void GetTemporary(){} // RVA: 0x7ffaaf2c6c70
        public void GetTemporary(){} // RVA: 0x7ffaaf2c6c70
        public void GetTemporary(){} // RVA: 0x7ffaaf2c6c70
        public void GetTemporary(){} // RVA: 0x7ffaaf2c6c70
        public void GetTemporary(){} // RVA: 0x7ffaaf2c6c70
        public void GetTemporary(){} // RVA: 0x7ffaaf2c6c70
        public void GetTemporary(){} // RVA: 0x7ffaaf2c6c70
        public void GetTemporary(){} // RVA: 0x7ffaaf2c6c70
        public void GetTemporary(){} // RVA: 0x7ffaaf2c6c70
        public void GetTemporary(){} // RVA: 0x7ffaaf2c6c70
        public void GetTemporary(){} // RVA: 0x7ffaaf2c6c70
        public void GetTexelOffset(){} // RVA: 0x7ffaa89570a0
        public void GetColorBuffer_Injected(){} // RVA: 0x7ffaaf2c6d70
        public void GetDepthBuffer_Injected(){} // RVA: 0x7ffaaf2c6dd0
        public void SetRenderTextureDescriptor_Injected(){} // RVA: 0x7ffaaf2c6e30
        public void GetDescriptor_Injected(){} // RVA: 0x7ffaaf2c6e90
        public void GetTemporary_Internal_Injected(){} // RVA: 0x7ffaaf2c6ef0
    }

    public class Renderer : Component
    {
        // ── Original Methods ──
        public void get_castShadows(){} // RVA: 0x7ffaaf29e120
        public void set_castShadows(){} // RVA: 0x7ffaaf29e180
        public void get_motionVectors(){} // RVA: 0x7ffaaf29e1f0
        public void set_motionVectors(){} // RVA: 0x7ffaaf29e250
        public void get_useLightProbes(){} // RVA: 0x7ffaaf29e2c0
        public void set_useLightProbes(){} // RVA: 0x7ffaaf29e320
        public void get_bounds(){} // RVA: 0x7ffaaf29e390
        public void set_bounds(){} // RVA: 0x7ffaaf29e400
        public void get_localBounds(){} // RVA: 0x7ffaaf29e460
        public void set_localBounds(){} // RVA: 0x7ffaaf29e4d0
        public void ResetBounds(){} // RVA: 0x7ffaaf29e530
        public void ResetLocalBounds(){} // RVA: 0x7ffaaf29e580
        public void CopyMaterialArray(){} // RVA: 0x7ffaaf29e780
        public void CopySharedMaterialArray(){} // RVA: 0x7ffaaf29e7e0
        public void Internal_SetPropertyBlock(){} // RVA: 0x7ffaaf29e8e0
        public void Internal_GetPropertyBlock(){} // RVA: 0x7ffaaf29e940
        public void Internal_SetPropertyBlockMaterialIndex(){} // RVA: 0x7ffaaf29e9a0
        public void Internal_GetPropertyBlockMaterialIndex(){} // RVA: 0x7ffaaf29ea10
        public void HasPropertyBlock(){} // RVA: 0x7ffaaf29ea80
        public void get_enabled(){} // RVA: 0x7ffaaf29eb30
        public void set_enabled(){} // RVA: 0x7ffaaf29eb80
        public void get_isVisible(){} // RVA: 0x7ffaaf29ebe0
        public void get_shadowCastingMode(){} // RVA: 0x7ffaaf29ec30
        public void set_shadowCastingMode(){} // RVA: 0x7ffaaf29ec80
        public void get_receiveShadows(){} // RVA: 0x7ffaaf29ece0
        public void set_receiveShadows(){} // RVA: 0x7ffaaf29ed30
        public void get_forceRenderingOff(){} // RVA: 0x7ffaaf29ed90
        public void set_forceRenderingOff(){} // RVA: 0x7ffaaf29ede0
        public void get_staticShadowCaster(){} // RVA: 0x7ffaaf29ee40
        public void set_staticShadowCaster(){} // RVA: 0x7ffaaf29ee90
        public void get_motionVectorGenerationMode(){} // RVA: 0x7ffaaf29eef0
        public void set_motionVectorGenerationMode(){} // RVA: 0x7ffaaf29ef40
        public void get_lightProbeUsage(){} // RVA: 0x7ffaaf29efa0
        public void set_lightProbeUsage(){} // RVA: 0x7ffaaf29eff0
        public void get_reflectionProbeUsage(){} // RVA: 0x7ffaaf29f050
        public void set_reflectionProbeUsage(){} // RVA: 0x7ffaaf29f0a0
        public void get_renderingLayerMask(){} // RVA: 0x7ffaaf29f100
        public void set_renderingLayerMask(){} // RVA: 0x7ffaaf29f150
        public void get_rendererPriority(){} // RVA: 0x7ffaaf29f1b0
        public void set_rendererPriority(){} // RVA: 0x7ffaaf29f200
        public void get_rayTracingMode(){} // RVA: 0x7ffaaf29f260
        public void set_rayTracingMode(){} // RVA: 0x7ffaaf29f2b0
        public void get_sortingLayerName(){} // RVA: 0x7ffaaf29f310
        public void set_sortingLayerName(){} // RVA: 0x7ffaaf29f360
        public void get_sortingLayerID(){} // RVA: 0x7ffaaf29f3c0
        public void set_sortingLayerID(){} // RVA: 0x7ffaaf29f410
        public void get_sortingOrder(){} // RVA: 0x7ffaaf29f470
        public void set_sortingOrder(){} // RVA: 0x7ffaaf29f4c0
        public void get_sortingKey(){} // RVA: 0x7ffaaf29f520
        public void get_sortingGroupID(){} // RVA: 0x7ffaaf29f570
        public void set_sortingGroupID(){} // RVA: 0x7ffaaf29f5c0
        public void get_sortingGroupOrder(){} // RVA: 0x7ffaaf29f620
        public void set_sortingGroupOrder(){} // RVA: 0x7ffaaf29f670
        public void get_sortingGroupKey(){} // RVA: 0x7ffaaf29f6d0
        public void get_allowOcclusionWhenDynamic(){} // RVA: 0x7ffaaf29f720
        public void set_allowOcclusionWhenDynamic(){} // RVA: 0x7ffaaf29f770
        public void get_staticBatchRootTransform(){} // RVA: 0x7ffaaf29f7d0
        public void set_staticBatchRootTransform(){} // RVA: 0x7ffaaf29f820
        public void get_staticBatchIndex(){} // RVA: 0x7ffaaf29f880
        public void get_isPartOfStaticBatch(){} // RVA: 0x7ffaaf29f940
        public void get_worldToLocalMatrix(){} // RVA: 0x7ffaaf29f990
        public void get_localToWorldMatrix(){} // RVA: 0x7ffaaf29fa10
        public void get_lightProbeProxyVolumeOverride(){} // RVA: 0x7ffaaf29fa90
        public void set_lightProbeProxyVolumeOverride(){} // RVA: 0x7ffaaf29fae0
        public void get_probeAnchor(){} // RVA: 0x7ffaaf29fb40
        public void set_probeAnchor(){} // RVA: 0x7ffaaf29fb90
        public void get_lightmapIndex(){} // RVA: 0x7ffaaf29fdb0
        public void set_lightmapIndex(){} // RVA: 0x7ffaaf29fe10
        public void get_realtimeLightmapIndex(){} // RVA: 0x7ffaaf29fe70
        public void set_realtimeLightmapIndex(){} // RVA: 0x7ffaaf29fed0
        public void get_lightmapScaleOffset(){} // RVA: 0x7ffaaf29ff40
        public void set_lightmapScaleOffset(){} // RVA: 0x7ffaaf29ffc0
        public void get_realtimeLightmapScaleOffset(){} // RVA: 0x7ffaaf2a0020
        public void set_realtimeLightmapScaleOffset(){} // RVA: 0x7ffaaf2a00a0
        public void get_materials(){} // RVA: 0x7ffaaf29e730
        public void set_materials(){} // RVA: 0x7ffaaf29e8b0
        public void get_material(){} // RVA: 0x7ffaaf29e630
        public void set_material(){} // RVA: 0x7ffaaf29e6d0
        public void get_sharedMaterial(){} // RVA: 0x7ffaaf29e680
        public void set_sharedMaterial(){} // RVA: 0x7ffaaf29e6d0
        public void get_sharedMaterials(){} // RVA: 0x7ffaaf2a0160
        public void set_sharedMaterials(){} // RVA: 0x7ffaaf29e8b0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_bounds_Injected(){} // RVA: 0x7ffaaf2a05f0
        public void set_bounds_Injected(){} // RVA: 0x7ffaaf2a0650
        public void get_localBounds_Injected(){} // RVA: 0x7ffaaf2a06b0
        public void set_localBounds_Injected(){} // RVA: 0x7ffaaf2a0710
        public void get_worldToLocalMatrix_Injected(){} // RVA: 0x7ffaaf2a07d0
        public void get_localToWorldMatrix_Injected(){} // RVA: 0x7ffaaf2a0830
        // ── Binary Analysis Named ──
        public void SetStaticLightmapST(){} // RVA: 0x7ffaaf29e5d0
        public void GetMaterial(){} // RVA: 0x7ffaaf29e630
        public void GetSharedMaterial(){} // RVA: 0x7ffaaf29e680
        public void SetMaterial(){} // RVA: 0x7ffaaf29e6d0
        public void GetMaterialArray(){} // RVA: 0x7ffaaf29e730
        public void SetMaterialArray(){} // RVA: 0x7ffaaf29e8b0
        public void SetMaterialArray(){} // RVA: 0x7ffaaf29e8b0
        public void SetPropertyBlock(){} // RVA: 0x7ffaaf29e9a0
        public void SetPropertyBlock(){} // RVA: 0x7ffaaf29e9a0
        public void GetPropertyBlock(){} // RVA: 0x7ffaaf29ea10
        public void GetPropertyBlock(){} // RVA: 0x7ffaaf29ea10
        public void GetClosestReflectionProbesInternal(){} // RVA: 0x7ffaaf29ead0
        public void GetIsStaticShadowCaster(){} // RVA: 0x7ffaaf29ee40
        public void SetIsStaticShadowCaster(){} // RVA: 0x7ffaaf29ee90
        public void SetStaticBatchInfo(){} // RVA: 0x7ffaaf29f8d0
        public void GetLightmapIndex(){} // RVA: 0x7ffaaf29fbf0
        public void SetLightmapIndex(){} // RVA: 0x7ffaaf29fc50
        public void GetLightmapST(){} // RVA: 0x7ffaaf29fcc0
        public void SetLightmapST(){} // RVA: 0x7ffaaf29fd40
        public void GetMaterialCount(){} // RVA: 0x7ffaaf2a0110
        public void GetSharedMaterialArray(){} // RVA: 0x7ffaaf2a0160
        public void GetMaterials(){} // RVA: 0x7ffaaf2a01b0
        public void SetSharedMaterials(){} // RVA: 0x7ffaaf2a0300
        public void SetMaterials(){} // RVA: 0x7ffaaf2a03d0
        public void GetSharedMaterials(){} // RVA: 0x7ffaaf2a04a0
        public void GetClosestReflectionProbes(){} // RVA: 0x7ffaaf29ead0
        public void SetStaticLightmapST_Injected(){} // RVA: 0x7ffaaf2a0770
        public void GetLightmapST_Injected(){} // RVA: 0x7ffaaf2a0890
        public void SetLightmapST_Injected(){} // RVA: 0x7ffaaf2a0900
    }

    public class RequireComponent : Attribute
    {
        public object m_Type2; // 0x32CE0960

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8f15e70
        public void .ctor(){} // RVA: 0x7ffaa8f15e70
    }

    public class Resolution : ValueType
    {
        public object m_RefreshRate; // 0x32CE0B10

        // ── Original Methods ──
        public void get_width(){} // RVA: 0x7ffaae9b5f60
        public void set_width(){} // RVA: 0x7ffaa8d92880
        public void get_height(){} // RVA: 0x7ffaac3dc380
        public void set_height(){} // RVA: 0x7ffaa9e475c0
        public void get_refreshRateRatio(){} // RVA: 0x7ffaae0d5d90
        public void get_refreshRate(){} // RVA: 0x7ffaaf293f50
        public void set_refreshRate(){} // RVA: 0x7ffaaf293fd0
        public void ToString(){} // RVA: 0x7ffaaf293fe0
    }

    public class ResourceRequest : AsyncOperation
    {
        // ── Original Methods ──
        public void get_asset(){} // RVA: 0x7ffaa89e6bc0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetResult(){} // RVA: 0x7ffaaf2da8e0
    }

    public class Resources : Object
    {
        // ── Original Methods ──
        public void ConvertObjects(){} // RVA: 0x7ffaa86492c0
        public void FindObjectsOfTypeAll(){} // RVA: 0x7ffaa8648dd0
        public void FindObjectsOfTypeAll(){} // RVA: 0x7ffaa8648dd0
        public void Load(){} // RVA: 0x7ffaaf2db030
        public void Load(){} // RVA: 0x7ffaaf2db030
        public void Load(){} // RVA: 0x7ffaaf2db030
        public void LoadAsync(){} // RVA: 0x7ffaaf2db180
        public void LoadAsync(){} // RVA: 0x7ffaaf2db180
        public void LoadAsync(){} // RVA: 0x7ffaaf2db180
        public void UnloadAsset(){} // RVA: 0x7ffaaf2db260
        public void UnloadUnusedAssets(){} // RVA: 0x7ffaaf2db2d0
        // ── Binary Analysis Named ──
        public void GetBuiltinResource(){} // RVA: 0x7ffaa887e5c0
        public void GetBuiltinResource(){} // RVA: 0x7ffaa887e5c0
    }

    public class ResourcesAPI : Object
    {
        // ── Original Methods ──
        public void get_ActiveAPI(){} // RVA: 0x7ffaaf2daab0
        public void get_overrideAPI(){} // RVA: 0x7ffaaf2dab70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void FindObjectsOfTypeAll(){} // RVA: 0x7ffaaf2dabd0
        public void FindShaderByName(){} // RVA: 0x7ffaaf2dac20
        public void Load(){} // RVA: 0x7ffaaf2dac70
        public void LoadAsync(){} // RVA: 0x7ffaaf2dacd0
        public void UnloadAsset(){} // RVA: 0x7ffaaf2dae00
        public void .cctor(){} // RVA: 0x7ffaaf2dae50
    }

    public class Rigidbody : Component
    {
        // ── Original Methods ──
        public void get_velocity(){} // RVA: 0x7ffaaf3b6780
        public void set_velocity(){} // RVA: 0x7ffaaf3b67f0
        public void get_angularVelocity(){} // RVA: 0x7ffaaf3b6850
        public void set_angularVelocity(){} // RVA: 0x7ffaaf3b68c0
        public void get_drag(){} // RVA: 0x7ffaaf3b6920
        public void set_drag(){} // RVA: 0x7ffaaf3b6970
        public void get_angularDrag(){} // RVA: 0x7ffaaf3b69d0
        public void set_angularDrag(){} // RVA: 0x7ffaaf3b6a20
        public void get_mass(){} // RVA: 0x7ffaaf3b6a80
        public void set_mass(){} // RVA: 0x7ffaaf3b6ad0
        public void get_useGravity(){} // RVA: 0x7ffaaf3b6b90
        public void set_useGravity(){} // RVA: 0x7ffaaf3b6be0
        public void get_maxDepenetrationVelocity(){} // RVA: 0x7ffaaf3b6c40
        public void set_maxDepenetrationVelocity(){} // RVA: 0x7ffaaf3b6c90
        public void get_isKinematic(){} // RVA: 0x7ffaaf3b6cf0
        public void set_isKinematic(){} // RVA: 0x7ffaaf3b6d40
        public void get_freezeRotation(){} // RVA: 0x7ffaaf3b6da0
        public void set_freezeRotation(){} // RVA: 0x7ffaaf3b6df0
        public void get_constraints(){} // RVA: 0x7ffaaf3b6e50
        public void set_constraints(){} // RVA: 0x7ffaaf3b6ea0
        public void get_collisionDetectionMode(){} // RVA: 0x7ffaaf3b6f00
        public void set_collisionDetectionMode(){} // RVA: 0x7ffaaf3b6f50
        public void get_automaticCenterOfMass(){} // RVA: 0x7ffaaf3b6fb0
        public void set_automaticCenterOfMass(){} // RVA: 0x7ffaaf3b7000
        public void get_centerOfMass(){} // RVA: 0x7ffaaf3b7060
        public void set_centerOfMass(){} // RVA: 0x7ffaaf3b70d0
        public void get_worldCenterOfMass(){} // RVA: 0x7ffaaf3b7130
        public void get_automaticInertiaTensor(){} // RVA: 0x7ffaaf3b71a0
        public void set_automaticInertiaTensor(){} // RVA: 0x7ffaaf3b71f0
        public void get_inertiaTensorRotation(){} // RVA: 0x7ffaaf3b7250
        public void set_inertiaTensorRotation(){} // RVA: 0x7ffaaf3b72c0
        public void get_inertiaTensor(){} // RVA: 0x7ffaaf3b7320
        public void set_inertiaTensor(){} // RVA: 0x7ffaaf3b7390
        public void get_detectCollisions(){} // RVA: 0x7ffaaf3b73f0
        public void set_detectCollisions(){} // RVA: 0x7ffaaf3b7440
        public void get_position(){} // RVA: 0x7ffaaf3b74a0
        public void set_position(){} // RVA: 0x7ffaaf3b7510
        public void get_rotation(){} // RVA: 0x7ffaaf3b7570
        public void set_rotation(){} // RVA: 0x7ffaaf3b75e0
        public void get_interpolation(){} // RVA: 0x7ffaaf3b7640
        public void set_interpolation(){} // RVA: 0x7ffaaf3b7690
        public void get_solverIterations(){} // RVA: 0x7ffaaf3b76f0
        public void set_solverIterations(){} // RVA: 0x7ffaaf3b7740
        public void get_sleepThreshold(){} // RVA: 0x7ffaaf3b77a0
        public void set_sleepThreshold(){} // RVA: 0x7ffaaf3b77f0
        public void get_maxAngularVelocity(){} // RVA: 0x7ffaaf3b7850
        public void set_maxAngularVelocity(){} // RVA: 0x7ffaaf3b78a0
        public void get_maxLinearVelocity(){} // RVA: 0x7ffaaf3b7900
        public void set_maxLinearVelocity(){} // RVA: 0x7ffaaf3b7950
        public void MovePosition(){} // RVA: 0x7ffaaf3b79b0
        public void MoveRotation(){} // RVA: 0x7ffaaf3b7a10
        public void Move(){} // RVA: 0x7ffaaf3b7a70
        public void Sleep(){} // RVA: 0x7ffaaf3b7ae0
        public void IsSleeping(){} // RVA: 0x7ffaaf3b7b30
        public void WakeUp(){} // RVA: 0x7ffaaf3b7b80
        public void ResetCenterOfMass(){} // RVA: 0x7ffaaf3b7bd0
        public void ResetInertiaTensor(){} // RVA: 0x7ffaaf3b7c20
        public void get_solverVelocityIterations(){} // RVA: 0x7ffaaf3b7d70
        public void set_solverVelocityIterations(){} // RVA: 0x7ffaaf3b7dc0
        public void get_excludeLayers(){} // RVA: 0x7ffaaf3b7e20
        public void set_excludeLayers(){} // RVA: 0x7ffaaf3b7e80
        public void get_includeLayers(){} // RVA: 0x7ffaaf3b7ee0
        public void set_includeLayers(){} // RVA: 0x7ffaaf3b7f40
        public void AddForce(){} // RVA: 0x7ffaaf3b83b0
        public void AddForce(){} // RVA: 0x7ffaaf3b83b0
        public void AddForce(){} // RVA: 0x7ffaaf3b83b0
        public void AddForce(){} // RVA: 0x7ffaaf3b83b0
        public void AddRelativeForce(){} // RVA: 0x7ffaaf3b8570
        public void AddRelativeForce(){} // RVA: 0x7ffaaf3b8570
        public void AddRelativeForce(){} // RVA: 0x7ffaaf3b8570
        public void AddRelativeForce(){} // RVA: 0x7ffaaf3b8570
        public void AddTorque(){} // RVA: 0x7ffaaf3b8730
        public void AddTorque(){} // RVA: 0x7ffaaf3b8730
        public void AddTorque(){} // RVA: 0x7ffaaf3b8730
        public void AddTorque(){} // RVA: 0x7ffaaf3b8730
        public void AddRelativeTorque(){} // RVA: 0x7ffaaf3b88f0
        public void AddRelativeTorque(){} // RVA: 0x7ffaaf3b88f0
        public void AddRelativeTorque(){} // RVA: 0x7ffaaf3b88f0
        public void AddRelativeTorque(){} // RVA: 0x7ffaaf3b88f0
        public void AddForceAtPosition(){} // RVA: 0x7ffaaf3b89e0
        public void AddForceAtPosition(){} // RVA: 0x7ffaaf3b89e0
        public void AddExplosionForce(){} // RVA: 0x7ffaaf3b8ba0
        public void AddExplosionForce(){} // RVA: 0x7ffaaf3b8ba0
        public void AddExplosionForce(){} // RVA: 0x7ffaaf3b8ba0
        public void Internal_ClosestPointOnBounds(){} // RVA: 0x7ffaaf3b8c40
        public void ClosestPointOnBounds(){} // RVA: 0x7ffaaf3b8cc0
        public void SweepTest(){} // RVA: 0x7ffaaf3b8fe0
        public void SweepTest(){} // RVA: 0x7ffaaf3b8fe0
        public void SweepTest(){} // RVA: 0x7ffaaf3b8fe0
        public void SweepTest(){} // RVA: 0x7ffaaf3b8fe0
        public void Internal_SweepTestAll(){} // RVA: 0x7ffaaf3b9020
        public void SweepTestAll(){} // RVA: 0x7ffaaf3b91d0
        public void SweepTestAll(){} // RVA: 0x7ffaaf3b91d0
        public void SweepTestAll(){} // RVA: 0x7ffaaf3b91d0
        public void get_sleepVelocity(){} // RVA: 0x7ffaaf2acd20
        public void set_sleepVelocity(){} // RVA: 0x7ffaa8932310
        public void get_sleepAngularVelocity(){} // RVA: 0x7ffaaf2acd20
        public void set_sleepAngularVelocity(){} // RVA: 0x7ffaa8932310
        public void get_useConeFriction(){} // RVA: 0x7ffaaac0a810
        public void set_useConeFriction(){} // RVA: 0x7ffaa8932310
        public void get_solverIterationCount(){} // RVA: 0x7ffaaf3b76f0
        public void set_solverIterationCount(){} // RVA: 0x7ffaaf3b7740
        public void get_solverVelocityIterationCount(){} // RVA: 0x7ffaaf3b7d70
        public void set_solverVelocityIterationCount(){} // RVA: 0x7ffaaf3b7dc0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_velocity_Injected(){} // RVA: 0x7ffaaf3b9210
        public void set_velocity_Injected(){} // RVA: 0x7ffaaf3b9270
        public void get_angularVelocity_Injected(){} // RVA: 0x7ffaaf3b92d0
        public void set_angularVelocity_Injected(){} // RVA: 0x7ffaaf3b9330
        public void get_centerOfMass_Injected(){} // RVA: 0x7ffaaf3b9390
        public void set_centerOfMass_Injected(){} // RVA: 0x7ffaaf3b93f0
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x7ffaaf3b9450
        public void get_inertiaTensorRotation_Injected(){} // RVA: 0x7ffaaf3b94b0
        public void set_inertiaTensorRotation_Injected(){} // RVA: 0x7ffaaf3b9510
        public void get_inertiaTensor_Injected(){} // RVA: 0x7ffaaf3b9570
        public void set_inertiaTensor_Injected(){} // RVA: 0x7ffaaf3b95d0
        public void get_position_Injected(){} // RVA: 0x7ffaaf3b9630
        public void set_position_Injected(){} // RVA: 0x7ffaaf3b9690
        public void get_rotation_Injected(){} // RVA: 0x7ffaaf3b96f0
        public void set_rotation_Injected(){} // RVA: 0x7ffaaf3b9750
        public void MovePosition_Injected(){} // RVA: 0x7ffaaf3b97b0
        public void MoveRotation_Injected(){} // RVA: 0x7ffaaf3b9810
        public void Move_Injected(){} // RVA: 0x7ffaaf3b9870
        public void get_excludeLayers_Injected(){} // RVA: 0x7ffaaf3b99c0
        public void set_excludeLayers_Injected(){} // RVA: 0x7ffaaf3b9a20
        public void get_includeLayers_Injected(){} // RVA: 0x7ffaaf3b9a80
        public void set_includeLayers_Injected(){} // RVA: 0x7ffaaf3b9ae0
        public void AddForce_Injected(){} // RVA: 0x7ffaaf3b9c20
        public void AddRelativeForce_Injected(){} // RVA: 0x7ffaaf3b9c90
        public void AddTorque_Injected(){} // RVA: 0x7ffaaf3b9d00
        public void AddRelativeTorque_Injected(){} // RVA: 0x7ffaaf3b9d70
        public void AddForceAtPosition_Injected(){} // RVA: 0x7ffaaf3b9de0
        public void AddExplosionForce_Injected(){} // RVA: 0x7ffaaf3b9e60
        public void Internal_ClosestPointOnBounds_Injected(){} // RVA: 0x7ffaaf3b9ef0
        public void SweepTest_Injected(){} // RVA: 0x7ffaaf3b9f70
        public void Internal_SweepTestAll_Injected(){} // RVA: 0x7ffaaf3ba000
        // ── Binary Analysis Named ──
        public void SetDensity(){} // RVA: 0x7ffaaf3b6b30
        public void GetRelativePointVelocity(){} // RVA: 0x7ffaaf3b7c70
        public void GetPointVelocity(){} // RVA: 0x7ffaaf3b7cf0
        public void GetAccumulatedForce(){} // RVA: 0x7ffaaf3b8020
        public void GetAccumulatedForce(){} // RVA: 0x7ffaaf3b8020
        public void GetAccumulatedTorque(){} // RVA: 0x7ffaaf3b8180
        public void GetAccumulatedTorque(){} // RVA: 0x7ffaaf3b8180
        public void SetMaxAngularVelocity(){} // RVA: 0x7ffaaf3b78a0
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x7ffaaf3b98e0
        public void GetPointVelocity_Injected(){} // RVA: 0x7ffaaf3b9950
        public void GetAccumulatedForce_Injected(){} // RVA: 0x7ffaaf3b9b40
        public void GetAccumulatedTorque_Injected(){} // RVA: 0x7ffaaf3b9bb0
    }

    public class Rigidbody2D : Component
    {
        // ── Original Methods ──
        public void get_position(){} // RVA: 0x7ffaaf39b670
        public void set_position(){} // RVA: 0x7ffaaf39b6d0
        public void get_rotation(){} // RVA: 0x7ffaaf39b730
        public void set_rotation(){} // RVA: 0x7ffaaf39b780
        public void MovePosition(){} // RVA: 0x7ffaaf39b900
        public void MoveRotation(){} // RVA: 0x7ffaaf39b9c0
        public void MoveRotation_Angle(){} // RVA: 0x7ffaaf39b960
        public void MoveRotation(){} // RVA: 0x7ffaaf39b9c0
        public void MoveRotation_Quaternion(){} // RVA: 0x7ffaaf39ba20
        public void get_velocity(){} // RVA: 0x7ffaaf39ba80
        public void set_velocity(){} // RVA: 0x7ffaaf39bae0
        public void get_angularVelocity(){} // RVA: 0x7ffaaf39bb40
        public void set_angularVelocity(){} // RVA: 0x7ffaaf39bb90
        public void get_useAutoMass(){} // RVA: 0x7ffaaf39bbf0
        public void set_useAutoMass(){} // RVA: 0x7ffaaf39bc40
        public void get_mass(){} // RVA: 0x7ffaaf39bca0
        public void set_mass(){} // RVA: 0x7ffaaf39bcf0
        public void get_sharedMaterial(){} // RVA: 0x7ffaaf39bd50
        public void set_sharedMaterial(){} // RVA: 0x7ffaaf39bda0
        public void get_centerOfMass(){} // RVA: 0x7ffaaf39be00
        public void set_centerOfMass(){} // RVA: 0x7ffaaf39be60
        public void get_worldCenterOfMass(){} // RVA: 0x7ffaaf39bec0
        public void get_inertia(){} // RVA: 0x7ffaaf39bf20
        public void set_inertia(){} // RVA: 0x7ffaaf39bf70
        public void get_drag(){} // RVA: 0x7ffaaf39bfd0
        public void set_drag(){} // RVA: 0x7ffaaf39c020
        public void get_angularDrag(){} // RVA: 0x7ffaaf39c080
        public void set_angularDrag(){} // RVA: 0x7ffaaf39c0d0
        public void get_gravityScale(){} // RVA: 0x7ffaaf39c130
        public void set_gravityScale(){} // RVA: 0x7ffaaf39c180
        public void get_bodyType(){} // RVA: 0x7ffaaf39c1e0
        public void set_bodyType(){} // RVA: 0x7ffaaf39c230
        public void get_useFullKinematicContacts(){} // RVA: 0x7ffaaf39c290
        public void set_useFullKinematicContacts(){} // RVA: 0x7ffaaf39c2e0
        public void get_isKinematic(){} // RVA: 0x7ffaaf39c340
        public void set_isKinematic(){} // RVA: 0x7ffaaf39c3a0
        public void get_freezeRotation(){} // RVA: 0x7ffaaf39c410
        public void set_freezeRotation(){} // RVA: 0x7ffaaf39c460
        public void get_constraints(){} // RVA: 0x7ffaaf39c4c0
        public void set_constraints(){} // RVA: 0x7ffaaf39c510
        public void IsSleeping(){} // RVA: 0x7ffaaf39c570
        public void IsAwake(){} // RVA: 0x7ffaaf39c5c0
        public void Sleep(){} // RVA: 0x7ffaaf39c610
        public void WakeUp(){} // RVA: 0x7ffaaf39c660
        public void get_simulated(){} // RVA: 0x7ffaaf39c6b0
        public void set_simulated(){} // RVA: 0x7ffaaf39c700
        public void get_interpolation(){} // RVA: 0x7ffaaf39c760
        public void set_interpolation(){} // RVA: 0x7ffaaf39c7b0
        public void get_sleepMode(){} // RVA: 0x7ffaaf39c810
        public void set_sleepMode(){} // RVA: 0x7ffaaf39c860
        public void get_collisionDetectionMode(){} // RVA: 0x7ffaaf39c8c0
        public void set_collisionDetectionMode(){} // RVA: 0x7ffaaf39c910
        public void get_attachedColliderCount(){} // RVA: 0x7ffaaf39c970
        public void get_totalForce(){} // RVA: 0x7ffaaf39c9c0
        public void set_totalForce(){} // RVA: 0x7ffaaf39ca20
        public void get_totalTorque(){} // RVA: 0x7ffaaf39ca80
        public void set_totalTorque(){} // RVA: 0x7ffaaf39cad0
        public void get_excludeLayers(){} // RVA: 0x7ffaaf39cb30
        public void set_excludeLayers(){} // RVA: 0x7ffaaf39cb90
        public void get_includeLayers(){} // RVA: 0x7ffaaf39cbf0
        public void set_includeLayers(){} // RVA: 0x7ffaaf39cc50
        public void IsTouching(){} // RVA: 0x7ffaaf39ce00
        public void IsTouching(){} // RVA: 0x7ffaaf39ce00
        public void IsTouching_OtherColliderWithFilter_Internal(){} // RVA: 0x7ffaaf39cd90
        public void IsTouching(){} // RVA: 0x7ffaaf39ce00
        public void IsTouching_AnyColliderWithFilter_Internal(){} // RVA: 0x7ffaaf39ce70
        public void IsTouchingLayers(){} // RVA: 0x7ffaaf39cf30
        public void IsTouchingLayers(){} // RVA: 0x7ffaaf39cf30
        public void OverlapPoint(){} // RVA: 0x7ffaaf39cf90
        public void Distance(){} // RVA: 0x7ffaaf39cff0
        public void Distance_Internal(){} // RVA: 0x7ffaaf39d310
        public void ClosestPoint(){} // RVA: 0x7ffaaf39d390
        public void AddForce(){} // RVA: 0x7ffaaf39d460
        public void AddForce(){} // RVA: 0x7ffaaf39d460
        public void AddRelativeForce(){} // RVA: 0x7ffaaf39d530
        public void AddRelativeForce(){} // RVA: 0x7ffaaf39d530
        public void AddForceAtPosition(){} // RVA: 0x7ffaaf39d610
        public void AddForceAtPosition(){} // RVA: 0x7ffaaf39d610
        public void AddTorque(){} // RVA: 0x7ffaaf39d700
        public void AddTorque(){} // RVA: 0x7ffaaf39d700
        public void OverlapCollider(){} // RVA: 0x7ffaaf39db00
        public void OverlapColliderArray_Internal(){} // RVA: 0x7ffaaf39da90
        public void OverlapCollider(){} // RVA: 0x7ffaaf39db00
        public void OverlapColliderList_Internal(){} // RVA: 0x7ffaaf39db80
        public void Cast(){} // RVA: 0x7ffaaf39e590
        public void Cast(){} // RVA: 0x7ffaaf39e590
        public void CastArray_Internal(){} // RVA: 0x7ffaaf39e240
        public void Cast(){} // RVA: 0x7ffaaf39e590
        public void CastList_Internal(){} // RVA: 0x7ffaaf39e340
        public void Cast(){} // RVA: 0x7ffaaf39e590
        public void Cast(){} // RVA: 0x7ffaaf39e590
        public void CastFilteredArray_Internal(){} // RVA: 0x7ffaaf39e500
        public void Cast(){} // RVA: 0x7ffaaf39e590
        public void CastFilteredList_Internal(){} // RVA: 0x7ffaaf39e630
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_position_Injected(){} // RVA: 0x7ffaaf39e790
        public void set_position_Injected(){} // RVA: 0x7ffaaf39e7f0
        public void MovePosition_Injected(){} // RVA: 0x7ffaaf39e8b0
        public void MoveRotation_Quaternion_Injected(){} // RVA: 0x7ffaaf39e910
        public void get_velocity_Injected(){} // RVA: 0x7ffaaf39e970
        public void set_velocity_Injected(){} // RVA: 0x7ffaaf39e9d0
        public void get_centerOfMass_Injected(){} // RVA: 0x7ffaaf39ea30
        public void set_centerOfMass_Injected(){} // RVA: 0x7ffaaf39ea90
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x7ffaaf39eaf0
        public void get_totalForce_Injected(){} // RVA: 0x7ffaaf39eb50
        public void set_totalForce_Injected(){} // RVA: 0x7ffaaf39ebb0
        public void get_excludeLayers_Injected(){} // RVA: 0x7ffaaf39ec10
        public void set_excludeLayers_Injected(){} // RVA: 0x7ffaaf39ec70
        public void get_includeLayers_Injected(){} // RVA: 0x7ffaaf39ecd0
        public void set_includeLayers_Injected(){} // RVA: 0x7ffaaf39ed30
        public void IsTouching_OtherColliderWithFilter_Internal_Injected(){} // RVA: 0x7ffaaf39ed90
        public void IsTouching_AnyColliderWithFilter_Internal_Injected(){} // RVA: 0x7ffaaf39ee00
        public void OverlapPoint_Injected(){} // RVA: 0x7ffaaf39ee60
        public void Distance_Internal_Injected(){} // RVA: 0x7ffaaf39eec0
        public void AddForce_Injected(){} // RVA: 0x7ffaaf39ef30
        public void AddRelativeForce_Injected(){} // RVA: 0x7ffaaf39efa0
        public void AddForceAtPosition_Injected(){} // RVA: 0x7ffaaf39f010
        public void OverlapColliderArray_Internal_Injected(){} // RVA: 0x7ffaaf39f330
        public void OverlapColliderList_Internal_Injected(){} // RVA: 0x7ffaaf39f3a0
        public void CastArray_Internal_Injected(){} // RVA: 0x7ffaaf39f410
        public void CastList_Internal_Injected(){} // RVA: 0x7ffaaf39f490
        public void CastFilteredArray_Internal_Injected(){} // RVA: 0x7ffaaf39f510
        public void CastFilteredList_Internal_Injected(){} // RVA: 0x7ffaaf39f5a0
        // ── Binary Analysis Named ──
        public void SetRotation(){} // RVA: 0x7ffaaf39b840
        public void SetRotation_Angle(){} // RVA: 0x7ffaaf39b7e0
        public void SetRotation(){} // RVA: 0x7ffaaf39b840
        public void SetRotation_Quaternion(){} // RVA: 0x7ffaaf39b8a0
        public void GetPoint(){} // RVA: 0x7ffaaf39d770
        public void GetRelativePoint(){} // RVA: 0x7ffaaf39d7e0
        public void GetVector(){} // RVA: 0x7ffaaf39d850
        public void GetRelativeVector(){} // RVA: 0x7ffaaf39d8c0
        public void GetPointVelocity(){} // RVA: 0x7ffaaf39d930
        public void GetRelativePointVelocity(){} // RVA: 0x7ffaaf39d9a0
        public void GetContacts(){} // RVA: 0x7ffaaf39e0a0
        public void GetContacts(){} // RVA: 0x7ffaaf39e0a0
        public void GetContacts(){} // RVA: 0x7ffaaf39e0a0
        public void GetContacts(){} // RVA: 0x7ffaaf39e0a0
        public void GetContacts(){} // RVA: 0x7ffaaf39e0a0
        public void GetContacts(){} // RVA: 0x7ffaaf39e0a0
        public void GetContacts(){} // RVA: 0x7ffaaf39e0a0
        public void GetContacts(){} // RVA: 0x7ffaaf39e0a0
        public void GetAttachedColliders(){} // RVA: 0x7ffaaf39e190
        public void GetAttachedCollidersArray_Internal(){} // RVA: 0x7ffaaf39e130
        public void GetAttachedColliders(){} // RVA: 0x7ffaaf39e190
        public void GetAttachedCollidersList_Internal(){} // RVA: 0x7ffaaf39e190
        public void GetShapes(){} // RVA: 0x7ffaaf39e6c0
        public void GetShapes_Internal(){} // RVA: 0x7ffaaf39e730
        public void SetRotation_Quaternion_Injected(){} // RVA: 0x7ffaaf39e850
        public void GetPoint_Injected(){} // RVA: 0x7ffaaf39f090
        public void GetRelativePoint_Injected(){} // RVA: 0x7ffaaf39f100
        public void GetVector_Injected(){} // RVA: 0x7ffaaf39f170
        public void GetRelativeVector_Injected(){} // RVA: 0x7ffaaf39f1e0
        public void GetPointVelocity_Injected(){} // RVA: 0x7ffaaf39f250
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x7ffaaf39f2c0
    }

    public class RuntimeAnimatorController : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf254f60
        public void get_animationClips(){} // RVA: 0x7ffaaf254fb0
    }

    public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89350c0
        public void .ctor(){} // RVA: 0x7ffaa89350c0
        public void set_loadType(){} // RVA: 0x7ffaa89350c0
    }

}