// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 37
// Methods: 1037

namespace ThirdParty.Unity.UnityEngine
{
    public class Random
    {
        // ── Methods ──
        public void InitState(){} // RVA: 0x711FB50
        public void Range(){} // RVA: 0x711FC10 | overloaded x2
        public void RandomRangeInt(){} // RVA: 0x711FC10
        public void get_value(){} // RVA: 0x17260C0
        public void get_insideUnitSphere(){} // RVA: 0x711FC70
        public void GetRandomUnitCircle(){} // RVA: 0x711FCD0
        public void get_insideUnitCircle(){} // RVA: 0x711FD20
        public void get_onUnitSphere(){} // RVA: 0x711FD80
        public void get_rotation(){} // RVA: 0x711FDE0
        public void get_rotationUniform(){} // RVA: 0x711FE40
        public void ColorHSV(){} // RVA: 0x7120040 | overloaded x5
        public void get_insideUnitSphere_Injected(){} // RVA: 0x71202B0
        public void get_onUnitSphere_Injected(){} // RVA: 0x7120300
        public void get_rotation_Injected(){} // RVA: 0x7120350
        public void get_rotationUniform_Injected(){} // RVA: 0x71203A0
    }

    public class RangeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x10A1C60
    }

    public class RangeInt
    {
        public int start; // 0x10

        // ── Methods ──
        public void get_end(){} // RVA: 0x712AD00
        public void .ctor(){} // RVA: 0x8AE010
    }

    public class Ray
    {
        public UnityEngine.Vector3 m_Origin; // 0x10
        public UnityEngine.Vector3 m_Direction; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70CD9D0
        public void get_origin(){} // RVA: 0x7079450
        public void set_origin(){} // RVA: 0x210E450
        public void get_direction(){} // RVA: 0x7079470
        public void set_direction(){} // RVA: 0x70CDA10
        public void GetPoint(){} // RVA: 0x70CDA40
        public void ToString(){} // RVA: 0x70CDAB0 | overloaded x3
    }

    public class RaycastCommand
    {
        public UnityEngine.Vector3 <from>k__BackingField; // 0x10
        public UnityEngine.Vector3 <direction>k__BackingField; // 0x1C
        public UnityEngine.PhysicsScene <physicsScene>k__BackingField; // 0x28
        public float <distance>k__BackingField; // 0x2C

        // ── Methods ──
        public void set_from(){} // RVA: 0x210E450
        public void set_direction(){} // RVA: 0x7079490
        public void set_physicsScene(){} // RVA: 0x6374E0
        public void set_distance(){} // RVA: 0x3AA580
        public void ScheduleBatch(){} // RVA: 0x720B880
        public void ScheduleRaycastBatch(){} // RVA: 0x720BAB0
        public void ScheduleRaycastBatch_Injected(){} // RVA: 0x720BB60
    }

    public class RaycastHit
    {
        public UnityEngine.Vector3 m_Point; // 0x10
        public UnityEngine.Vector3 m_Normal; // 0x1C
        public uint m_FaceID; // 0x28
        public float m_Distance; // 0x2C
        public UnityEngine.Vector2 m_UV; // 0x30
        public int m_Collider; // 0x38

        // ── Methods ──
        public void get_collider(){} // RVA: 0x71FC440
        public void get_colliderInstanceID(){} // RVA: 0x43DB8C0
        public void get_point(){} // RVA: 0x7079450
        public void set_point(){} // RVA: 0x210E450
        public void get_normal(){} // RVA: 0x7079470
        public void set_normal(){} // RVA: 0x7079490
        public void get_barycentricCoordinate(){} // RVA: 0x71FC530
        public void set_barycentricCoordinate(){} // RVA: 0x71FC560
        public void get_distance(){} // RVA: 0x707C4B0
        public void set_distance(){} // RVA: 0x3AA580
        public void get_triangleIndex(){} // RVA: 0x3D92310
        public void CalculateRaycastTexCoord(){} // RVA: 0x71FC580
        public void get_textureCoord(){} // RVA: 0x71FC620
        public void get_textureCoord2(){} // RVA: 0x71FC6D0
        public void get_transform(){} // RVA: 0x71FC780
        public void get_rigidbody(){} // RVA: 0x71FC9A0
        public void get_articulationBody(){} // RVA: 0x71FCAE0
        public void get_lightmapCoord(){} // RVA: 0x71FCC20
        public void CalculateRaycastTexCoord_Injected(){} // RVA: 0x71FCEA0
    }

    public class RaycastHit2D
    {
        public UnityEngine.Vector2 m_Centroid; // 0x10
        public UnityEngine.Vector2 m_Point; // 0x18
        public UnityEngine.Vector2 m_Normal; // 0x20
        public float m_Distance; // 0x28
        public float m_Fraction; // 0x2C
        public int m_Collider; // 0x30

        // ── Methods ──
        public void get_centroid(){} // RVA: 0x2738C50
        public void set_centroid(){} // RVA: 0x1B12320
        public void get_point(){} // RVA: 0x70CDE50
        public void set_point(){} // RVA: 0x1EE8D20
        public void get_normal(){} // RVA: 0x71E0000
        public void set_normal(){} // RVA: 0x1967700
        public void get_distance(){} // RVA: 0x70794A0
        public void set_distance(){} // RVA: 0x2F84D0
        public void get_fraction(){} // RVA: 0x707C4B0
        public void set_fraction(){} // RVA: 0x3AA580
        public void get_collider(){} // RVA: 0x71E16A0
        public void get_rigidbody(){} // RVA: 0x71E1790
        public void get_transform(){} // RVA: 0x71E18D0
        public void op_Implicit(){} // RVA: 0x71E1AF0
        public void CompareTo(){} // RVA: 0x71E1BD0
    }

    public class Rect
    {
        public float m_XMin; // 0x10
        public float m_YMin; // 0x14
        public float m_Width; // 0x18
        public float m_Height; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1F783A0 | overloaded x3
        public void get_zero(){} // RVA: 0x70CDCA0
        public void MinMaxRect(){} // RVA: 0x70CDCB0
        public void Set(){} // RVA: 0x301570
        public void get_x(){} // RVA: 0x300D20
        public void set_x(){} // RVA: 0x1F78330
        public void get_y(){} // RVA: 0x300D30
        public void set_y(){} // RVA: 0x1F78350
        public void get_position(){} // RVA: 0x70CDCF0
        public void set_position(){} // RVA: 0x70CDD10
        public void get_center(){} // RVA: 0x70CDD30
        public void set_center(){} // RVA: 0x70CDD60
        public void get_min(){} // RVA: 0x70CDDA0
        public void set_min(){} // RVA: 0x70CDDC0
        public void get_max(){} // RVA: 0x70CDE00
        public void set_max(){} // RVA: 0x70CDE20
        public void get_width(){} // RVA: 0x300CF0
        public void set_width(){} // RVA: 0x1F78340
        public void get_height(){} // RVA: 0x300D00
        public void set_height(){} // RVA: 0x1F78380
        public void get_size(){} // RVA: 0x70CDE50
        public void set_size(){} // RVA: 0x70CDE70
        public void get_xMin(){} // RVA: 0x300D20
        public void set_xMin(){} // RVA: 0x70CDE90
        public void get_yMin(){} // RVA: 0x300D30
        public void set_yMin(){} // RVA: 0x70CDEB0
        public void get_xMax(){} // RVA: 0x70CDED0
        public void set_xMax(){} // RVA: 0x70CDEE0
        public void get_yMax(){} // RVA: 0x70CDEF0
        public void set_yMax(){} // RVA: 0x70CDF00
        public void Contains(){} // RVA: 0x70CDF90 | overloaded x3
        public void OrderMinMax(){} // RVA: 0x70CE0B0
        public void Overlaps(){} // RVA: 0x70CE170 | overloaded x2
        public void NormalizedToPoint(){} // RVA: 0x70CE2D0
        public void PointToNormalized(){} // RVA: 0x70CE350
        public void op_Inequality(){} // RVA: 0x70CE3F0
        public void op_Equality(){} // RVA: 0x70CE440
        public void GetHashCode(){} // RVA: 0x70CE480
        public void Equals(){} // RVA: 0x2473580 | overloaded x2
        public void ToString(){} // RVA: 0x70CE5B0 | overloaded x3
    }

    public class RectInt
    {
        public int m_XMin; // 0x10
        public int m_YMin; // 0x14
        public int m_Width; // 0x18
        public int m_Height; // 0x1C

        // ── Methods ──
        public void get_x(){} // RVA: 0x67FD0D0
        public void set_x(){} // RVA: 0x833580
        public void get_y(){} // RVA: 0x40B7110
        public void set_y(){} // RVA: 0x19689D0
        public void get_width(){} // RVA: 0x3C4E030
        public void set_width(){} // RVA: 0x1EA98A0
        public void get_height(){} // RVA: 0x3C78200
        public void set_height(){} // RVA: 0x1EA98C0
        public void get_xMin(){} // RVA: 0x70CE940
        public void get_yMin(){} // RVA: 0x70CE9B0
        public void get_xMax(){} // RVA: 0x70CEA20
        public void get_yMax(){} // RVA: 0x70CEA90
        public void .ctor(){} // RVA: 0x5B88150
        public void Overlaps(){} // RVA: 0x70CEB00
        public void ToString(){} // RVA: 0x70CEBB0 | overloaded x2
        public void Equals(){} // RVA: 0x70CF000
    }

    public class RectOffset
    {
        public UIntPtr m_Ptr; // 0x10
        public object m_SourceStyle; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70CF180 | overloaded x3
        public void Finalize(){} // RVA: 0x70CF0E0
        public void ToString(){} // RVA: 0x70CF330 | overloaded x2
        public void Destroy(){} // RVA: 0x70CF890
        public void InternalCreate(){} // RVA: 0x70CF900
        public void InternalDestroy(){} // RVA: 0x70CF950
        public void get_left(){} // RVA: 0x70CF9A0
        public void set_left(){} // RVA: 0x70CF9F0
        public void get_right(){} // RVA: 0x70CFA50
        public void set_right(){} // RVA: 0x70CFAA0
        public void get_top(){} // RVA: 0x70CFB00
        public void set_top(){} // RVA: 0x70CFB50
        public void get_bottom(){} // RVA: 0x70CFBB0
        public void set_bottom(){} // RVA: 0x70CFC00
        public void get_horizontal(){} // RVA: 0x70CFC60
        public void get_vertical(){} // RVA: 0x70CFCB0
        public void Remove(){} // RVA: 0x70CFD00
        public void Remove_Injected(){} // RVA: 0x70CFD80
    }

    public class RectTransform
    {
        public ReapplyDrivenProperties reapplyDrivenProperties;

        // ── Methods ──
        public void add_reapplyDrivenProperties(){} // RVA: 0x7135E50
        public void remove_reapplyDrivenProperties(){} // RVA: 0x7135F60
        public void get_rect(){} // RVA: 0x7136070
        public void get_anchorMin(){} // RVA: 0x71360E0
        public void set_anchorMin(){} // RVA: 0x7136140
        public void get_anchorMax(){} // RVA: 0x71361A0
        public void set_anchorMax(){} // RVA: 0x7136200
        public void get_anchoredPosition(){} // RVA: 0x7136260
        public void set_anchoredPosition(){} // RVA: 0x71362C0
        public void get_sizeDelta(){} // RVA: 0x7136320
        public void set_sizeDelta(){} // RVA: 0x7136380
        public void get_pivot(){} // RVA: 0x71363E0
        public void set_pivot(){} // RVA: 0x7136440
        public void get_anchoredPosition3D(){} // RVA: 0x71364A0
        public void set_anchoredPosition3D(){} // RVA: 0x7136580
        public void get_offsetMin(){} // RVA: 0x71366B0
        public void set_offsetMin(){} // RVA: 0x71367E0
        public void get_offsetMax(){} // RVA: 0x7136B60
        public void set_offsetMax(){} // RVA: 0x7136CF0
        public void get_drivenByObject(){} // RVA: 0x7137050
        public void set_drivenByObject(){} // RVA: 0x71370A0
        public void get_drivenProperties(){} // RVA: 0x7137100
        public void set_drivenProperties(){} // RVA: 0x7137150
        public void ForceUpdateRectTransforms(){} // RVA: 0x71371B0
        public void GetLocalCorners(){} // RVA: 0x7137200
        public void GetWorldCorners(){} // RVA: 0x7137380
        public void SetInsetAndSizeFromParentEdge(){} // RVA: 0x71376F0
        public void SetSizeWithCurrentAnchors(){} // RVA: 0x7137C40
        public void SendReapplyDrivenProperties(){} // RVA: 0x7137FA0
        public void GetRectInParentSpace(){} // RVA: 0x7138000
        public void GetParentSize(){} // RVA: 0x71384C0
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_rect_Injected(){} // RVA: 0x71386A0
        public void get_anchorMin_Injected(){} // RVA: 0x7138700
        public void set_anchorMin_Injected(){} // RVA: 0x7138760
        public void get_anchorMax_Injected(){} // RVA: 0x71387C0
        public void set_anchorMax_Injected(){} // RVA: 0x7138820
        public void get_anchoredPosition_Injected(){} // RVA: 0x7138880
        public void set_anchoredPosition_Injected(){} // RVA: 0x71388E0
        public void get_sizeDelta_Injected(){} // RVA: 0x7138940
        public void set_sizeDelta_Injected(){} // RVA: 0x71389A0
        public void get_pivot_Injected(){} // RVA: 0x7138A00
        public void set_pivot_Injected(){} // RVA: 0x7138A60
    }

    public class RectTransformUtility
    {
        // ── Methods ──
        public void PixelAdjustPoint(){} // RVA: 0x749DDB0
        public void PixelAdjustRect(){} // RVA: 0x749DE60
        public void PointInRectangle(){} // RVA: 0x749DF10
        public void RectangleContainsScreenPoint(){} // RVA: 0x749E0F0 | overloaded x3
        public void ScreenPointToWorldPointInRectangle(){} // RVA: 0x749E1F0
        public void ScreenPointToLocalPointInRectangle(){} // RVA: 0x749E8F0
        public void ScreenPointToRay(){} // RVA: 0x749EA60
        public void WorldToScreenPoint(){} // RVA: 0x749ECF0
        public void FlipLayoutOnAxis(){} // RVA: 0x749EE60
        public void FlipLayoutAxes(){} // RVA: 0x749F550
        public void GetTransposed(){} // RVA: 0x749FB50
        public void .cctor(){} // RVA: 0x749FB70
        public void PixelAdjustPoint_Injected(){} // RVA: 0x749FC30
        public void PixelAdjustRect_Injected(){} // RVA: 0x749FCB0
        public void PointInRectangle_Injected(){} // RVA: 0x749FD20
    }

    public class ReflectionProbe
    {
        public System.Action`2<UnityEngine.ReflectionProbe,0x65895D68> reflectionProbeChanged;
        public System.Collections.Generic.Dictionary`2<int,System.Action`1<UnityEngine.Texture>> registeredDefaultReflectionSetActions; // 0x8
        public System.Collections.Generic.List`1<System.Action`1<UnityEngine.Texture>> registeredDefaultReflectionTextureActions; // 0x10

        // ── Methods ──
        public void get_type(){} // RVA: 0x70C4240
        public void set_type(){} // RVA: 0x70C4290
        public void get_size(){} // RVA: 0x70C42F0
        public void set_size(){} // RVA: 0x70C4360
        public void get_center(){} // RVA: 0x70C43C0
        public void set_center(){} // RVA: 0x70C4430
        public void get_nearClipPlane(){} // RVA: 0x70C4490
        public void set_nearClipPlane(){} // RVA: 0x70C44E0
        public void get_farClipPlane(){} // RVA: 0x70C4540
        public void set_farClipPlane(){} // RVA: 0x70C4590
        public void get_intensity(){} // RVA: 0x70C45F0
        public void set_intensity(){} // RVA: 0x70C4640
        public void get_bounds(){} // RVA: 0x70C46A0
        public void get_hdr(){} // RVA: 0x70C4710
        public void set_hdr(){} // RVA: 0x70C4760
        public void get_renderDynamicObjects(){} // RVA: 0x70C47C0
        public void set_renderDynamicObjects(){} // RVA: 0x70C4810
        public void get_shadowDistance(){} // RVA: 0x70C4870
        public void set_shadowDistance(){} // RVA: 0x70C48C0
        public void get_resolution(){} // RVA: 0x70C4920
        public void set_resolution(){} // RVA: 0x70C4970
        public void get_cullingMask(){} // RVA: 0x70C49D0
        public void set_cullingMask(){} // RVA: 0x70C4A20
        public void get_clearFlags(){} // RVA: 0x70C4A80
        public void set_clearFlags(){} // RVA: 0x70C4AD0
        public void get_backgroundColor(){} // RVA: 0x70C4B30
        public void set_backgroundColor(){} // RVA: 0x70C4BA0
        public void get_blendDistance(){} // RVA: 0x70C4C00
        public void set_blendDistance(){} // RVA: 0x70C4C50
        public void get_boxProjection(){} // RVA: 0x70C4CB0
        public void set_boxProjection(){} // RVA: 0x70C4D00
        public void get_mode(){} // RVA: 0x70C4D60
        public void set_mode(){} // RVA: 0x70C4DB0
        public void get_importance(){} // RVA: 0x70C4E10
        public void set_importance(){} // RVA: 0x70C4E60
        public void get_refreshMode(){} // RVA: 0x70C4EC0
        public void set_refreshMode(){} // RVA: 0x70C4F10
        public void get_timeSlicingMode(){} // RVA: 0x70C4F70
        public void set_timeSlicingMode(){} // RVA: 0x70C4FC0
        public void get_bakedTexture(){} // RVA: 0x70C5020
        public void set_bakedTexture(){} // RVA: 0x70C5070
        public void get_customBakedTexture(){} // RVA: 0x70C50D0
        public void set_customBakedTexture(){} // RVA: 0x70C5120
        public void get_realtimeTexture(){} // RVA: 0x70C5180
        public void set_realtimeTexture(){} // RVA: 0x70C51D0
        public void get_texture(){} // RVA: 0x70C5230
        public void get_textureHDRDecodeValues(){} // RVA: 0x70C5280
        public void Reset(){} // RVA: 0x70C52F0
        public void RenderProbe(){} // RVA: 0x70C5350 | overloaded x2
        public void IsFinishedRendering(){} // RVA: 0x70C5400
        public void ScheduleRender(){} // RVA: 0x70C5460
        public void BlendCubemap(){} // RVA: 0x70C54D0
        public void UpdateCachedState(){} // RVA: 0x70C5550
        public void get_minBakedCubemapResolution(){} // RVA: 0x70C55A0
        public void get_maxBakedCubemapResolution(){} // RVA: 0x70C55F0
        public void get_defaultTextureHDRDecodeValues(){} // RVA: 0x70C5640
        public void get_defaultTexture(){} // RVA: 0x70C56D0
        public void add_reflectionProbeChanged(){} // RVA: 0x70C5720
        public void remove_reflectionProbeChanged(){} // RVA: 0x70C5880
        public void CallReflectionProbeEvent(){} // RVA: 0x70C59E0
        public void add_defaultReflectionSet(){} // RVA: 0x70C5A60
        public void remove_defaultReflectionSet(){} // RVA: 0x70C5CB0
        public void add_defaultReflectionTexture(){} // RVA: 0x70C5E90
        public void remove_defaultReflectionTexture(){} // RVA: 0x70C6140
        public void CallSetDefaultReflection(){} // RVA: 0x70C61D0
        public void .ctor(){} // RVA: 0x2DDD50
        public void .cctor(){} // RVA: 0x70C6360
        public void get_size_Injected(){} // RVA: 0x70C6500
        public void set_size_Injected(){} // RVA: 0x70C6560
        public void get_center_Injected(){} // RVA: 0x70C65C0
        public void set_center_Injected(){} // RVA: 0x70C6620
        public void get_bounds_Injected(){} // RVA: 0x70C6680
        public void get_backgroundColor_Injected(){} // RVA: 0x70C66E0
        public void set_backgroundColor_Injected(){} // RVA: 0x70C6740
        public void get_textureHDRDecodeValues_Injected(){} // RVA: 0x70C67A0
        public void get_defaultTextureHDRDecodeValues_Injected(){} // RVA: 0x70C6800
    }

    public class RefreshRate
    {
        public uint numerator; // 0x10

        // ── Methods ──
        public void get_value(){} // RVA: 0x70D3620
        public void Equals(){} // RVA: 0x70D3640
        public void CompareTo(){} // RVA: 0x70D3680
        public void ToString(){} // RVA: 0x70D36D0
    }

    public class RejectDragAndDropMaterial
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class RelativeJoint2D
    {
        public object anchor;
        public object target;
        public object autoConfigureTarget;
        public object maxForce;
        public object dampingRatio;
        public object frequency;

        // ── Methods ──
        public void get_maxForce(){} // RVA: 0x71EC720
        public void set_maxForce(){} // RVA: 0x71EC770
        public void get_maxTorque(){} // RVA: 0x71EC7D0
        public void set_maxTorque(){} // RVA: 0x71EC820
        public void get_correctionScale(){} // RVA: 0x71EC880
        public void set_correctionScale(){} // RVA: 0x71EC8D0
        public void get_autoConfigureOffset(){} // RVA: 0x71EC930
        public void set_autoConfigureOffset(){} // RVA: 0x71EC980
        public void get_linearOffset(){} // RVA: 0x71EC9E0
        public void set_linearOffset(){} // RVA: 0x71ECA40
        public void get_angularOffset(){} // RVA: 0x71ECAA0
        public void set_angularOffset(){} // RVA: 0x71ECAF0
        public void get_target(){} // RVA: 0x71ECB50
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_linearOffset_Injected(){} // RVA: 0x71ECBB0
        public void set_linearOffset_Injected(){} // RVA: 0x71ECC10
        public void get_target_Injected(){} // RVA: 0x71ECC70
    }

    public class RemoteConfigSettings
    {
        // ── Methods ──
        public void RemoteConfigSettingsUpdated(){} // RVA: 0x74F67D0
    }

    public class RemoteConfigSettingsHelper
    {
    }

    public class RemoteSettings
    {
        // ── Methods ──
        public void RemoteSettingsUpdated(){} // RVA: 0x74F6690
        public void RemoteSettingsBeforeFetchFromServer(){} // RVA: 0x74F66F0
        public void RemoteSettingsUpdateCompleted(){} // RVA: 0x74F6750
    }

    public class RenderBuffer
    {
    }

    public class RenderInstancedDataLayout
    {
    }

    public class RenderParams
    {
        public int <layer>k__BackingField; // 0x10
        public uint <renderingLayerMask>k__BackingField; // 0x14
        public int <rendererPriority>k__BackingField; // 0x18
        public UnityEngine.Bounds <worldBounds>k__BackingField; // 0x1C
        public UnityEngine.Camera <camera>k__BackingField; // 0x38
        public 0x65898758 <motionVectorMode>k__BackingField; // 0x40
        public 0x658A2C00 <reflectionProbeUsage>k__BackingField; // 0x44
        public UnityEngine.Material <material>k__BackingField; // 0x48
        public UnityEngine.MaterialPropertyBlock <matProps>k__BackingField; // 0x50
        public 0x658A2998 <shadowCastingMode>k__BackingField; // 0x58
        public bool <receiveShadows>k__BackingField; // 0x5C
        public 0x658A2EC0 <lightProbeUsage>k__BackingField; // 0x60
        public UnityEngine.LightProbeProxyVolume <lightProbeProxyVolume>k__BackingField; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70D9BE0
        public void set_layer(){} // RVA: 0x833580
        public void set_renderingLayerMask(){} // RVA: 0x19689D0
        public void set_rendererPriority(){} // RVA: 0x1EA98A0
        public void set_worldBounds(){} // RVA: 0x70D9E70
        public void set_camera(){} // RVA: 0x2DEE90
        public void set_motionVectorMode(){} // RVA: 0x338CE0
        public void set_reflectionProbeUsage(){} // RVA: 0x4C5F20
        public void set_material(){} // RVA: 0x49B830
        public void get_matProps(){} // RVA: 0x35A740
        public void set_matProps(){} // RVA: 0x305200
        public void set_shadowCastingMode(){} // RVA: 0x37E0D0
        public void set_receiveShadows(){} // RVA: 0x16E0A80
        public void set_lightProbeUsage(){} // RVA: 0x65F570
        public void set_lightProbeProxyVolume(){} // RVA: 0x3A5510
    }

    public class RenderSettings
    {
        public object impulse;
        public object relativeVelocity;
        public object rigidbody;
        public object articulationBody;
        public object body;
        public object collider;
        public object transform;
        public object gameObject;
        public object Flipped;
        public object contactCount;
        public object contacts;
        public object get_OtherBody;

        // ── Methods ──
        public void get_fog(){} // RVA: 0x70E63C0
        public void set_fog(){} // RVA: 0x70E6410
        public void get_fogStartDistance(){} // RVA: 0x70E6460
        public void set_fogStartDistance(){} // RVA: 0x70E64B0
        public void get_fogEndDistance(){} // RVA: 0x70E6510
        public void set_fogEndDistance(){} // RVA: 0x70E6560
        public void get_fogMode(){} // RVA: 0x70E65C0
        public void set_fogMode(){} // RVA: 0x70E6610
        public void get_fogColor(){} // RVA: 0x70E6660
        public void set_fogColor(){} // RVA: 0x70E66C0
        public void get_fogDensity(){} // RVA: 0x70E6710
        public void set_fogDensity(){} // RVA: 0x70E6760
        public void get_ambientMode(){} // RVA: 0x70E67C0
        public void set_ambientMode(){} // RVA: 0x70E6810
        public void get_ambientSkyColor(){} // RVA: 0x70E6860
        public void set_ambientSkyColor(){} // RVA: 0x70E68C0
        public void get_ambientEquatorColor(){} // RVA: 0x70E6910
        public void set_ambientEquatorColor(){} // RVA: 0x70E6970
        public void get_ambientGroundColor(){} // RVA: 0x70E69C0
        public void set_ambientGroundColor(){} // RVA: 0x70E6A20
        public void get_ambientIntensity(){} // RVA: 0x70E6A70
        public void set_ambientIntensity(){} // RVA: 0x70E6AC0
        public void get_ambientLight(){} // RVA: 0x70E6B20
        public void set_ambientLight(){} // RVA: 0x70E6B80
        public void get_subtractiveShadowColor(){} // RVA: 0x70E6BD0
        public void set_subtractiveShadowColor(){} // RVA: 0x70E6C30
        public void get_skybox(){} // RVA: 0x70E6C80
        public void set_skybox(){} // RVA: 0x70E6CD0
        public void get_sun(){} // RVA: 0x70E6D20
        public void set_sun(){} // RVA: 0x70E6D70
        public void get_ambientProbe(){} // RVA: 0x70E6DC0
        public void set_ambientProbe(){} // RVA: 0x70E6E40
        public void get_customReflectionTexture(){} // RVA: 0x70E6E90
        public void set_customReflectionTexture(){} // RVA: 0x70E6EE0
        public void get_reflectionIntensity(){} // RVA: 0x70E6F30
        public void set_reflectionIntensity(){} // RVA: 0x70E6F80
        public void get_reflectionBounces(){} // RVA: 0x70E6FE0
        public void set_reflectionBounces(){} // RVA: 0x70E7030
        public void get_defaultReflectionMode(){} // RVA: 0x70E7080
        public void set_defaultReflectionMode(){} // RVA: 0x70E70D0
        public void get_defaultReflectionResolution(){} // RVA: 0x70E7120
        public void set_defaultReflectionResolution(){} // RVA: 0x70E7170
        public void get_haloStrength(){} // RVA: 0x70E71C0
        public void set_haloStrength(){} // RVA: 0x70E7210
        public void get_flareStrength(){} // RVA: 0x70E7270
        public void set_flareStrength(){} // RVA: 0x70E72C0
        public void get_flareFadeSpeed(){} // RVA: 0x70E7320
        public void set_flareFadeSpeed(){} // RVA: 0x70E7370
        public void get_fogColor_Injected(){} // RVA: 0x70E73D0
        public void set_fogColor_Injected(){} // RVA: 0x70E7420
        public void get_ambientSkyColor_Injected(){} // RVA: 0x70E7470
        public void set_ambientSkyColor_Injected(){} // RVA: 0x70E74C0
        public void get_ambientEquatorColor_Injected(){} // RVA: 0x70E7510
        public void set_ambientEquatorColor_Injected(){} // RVA: 0x70E7560
        public void get_ambientGroundColor_Injected(){} // RVA: 0x70E75B0
        public void set_ambientGroundColor_Injected(){} // RVA: 0x70E7600
        public void get_ambientLight_Injected(){} // RVA: 0x70E7650
        public void set_ambientLight_Injected(){} // RVA: 0x70E76A0
        public void get_subtractiveShadowColor_Injected(){} // RVA: 0x70E76F0
        public void set_subtractiveShadowColor_Injected(){} // RVA: 0x70E7740
        public void get_ambientProbe_Injected(){} // RVA: 0x70E7790
        public void set_ambientProbe_Injected(){} // RVA: 0x70E77E0
    }

    public class RenderTexture
    {
        // ── Methods ──
        public void get_width(){} // RVA: 0x7108C10
        public void set_width(){} // RVA: 0x7108C60
        public void get_height(){} // RVA: 0x7108CC0
        public void set_height(){} // RVA: 0x7108D10
        public void get_dimension(){} // RVA: 0x7108D70
        public void set_dimension(){} // RVA: 0x7108DC0
        public void GetColorFormat(){} // RVA: 0x7108E20
        public void SetColorFormat(){} // RVA: 0x7108E80
        public void get_graphicsFormat(){} // RVA: 0x7108EE0
        public void set_graphicsFormat(){} // RVA: 0x7108E80
        public void get_useMipMap(){} // RVA: 0x7108F40
        public void set_useMipMap(){} // RVA: 0x7108F90
        public void get_sRGB(){} // RVA: 0x7108FF0
        public void get_vrUsage(){} // RVA: 0x7109040
        public void set_vrUsage(){} // RVA: 0x7109090
        public void get_memorylessMode(){} // RVA: 0x71090F0
        public void set_memorylessMode(){} // RVA: 0x7109140
        public void get_format(){} // RVA: 0x71091A0
        public void set_format(){} // RVA: 0x7109330
        public void get_stencilFormat(){} // RVA: 0x7109420
        public void set_stencilFormat(){} // RVA: 0x7109470
        public void get_depthStencilFormat(){} // RVA: 0x71094D0
        public void set_depthStencilFormat(){} // RVA: 0x7109520
        public void get_autoGenerateMips(){} // RVA: 0x7109580
        public void set_autoGenerateMips(){} // RVA: 0x71095D0
        public void get_volumeDepth(){} // RVA: 0x7109630
        public void set_volumeDepth(){} // RVA: 0x7109680
        public void get_antiAliasing(){} // RVA: 0x71096E0
        public void set_antiAliasing(){} // RVA: 0x7109730
        public void get_bindTextureMS(){} // RVA: 0x7109790
        public void set_bindTextureMS(){} // RVA: 0x71097E0
        public void get_enableRandomWrite(){} // RVA: 0x7109840
        public void set_enableRandomWrite(){} // RVA: 0x7109890
        public void get_useDynamicScale(){} // RVA: 0x71098F0
        public void set_useDynamicScale(){} // RVA: 0x7109940
        public void GetIsPowerOfTwo(){} // RVA: 0x71099A0
        public void get_isPowerOfTwo(){} // RVA: 0x71099A0
        public void set_isPowerOfTwo(){} // RVA: 0x2DD310
        public void GetActive(){} // RVA: 0x71099F0
        public void SetActive(){} // RVA: 0x7109A40
        public void get_active(){} // RVA: 0x71099F0
        public void set_active(){} // RVA: 0x7109A40
        public void GetColorBuffer(){} // RVA: 0x7109A90
        public void GetDepthBuffer(){} // RVA: 0x7109B00
        public void SetMipMapCount(){} // RVA: 0x7109B70
        public void SetShadowSamplingMode(){} // RVA: 0x7109BD0
        public void get_colorBuffer(){} // RVA: 0x7109C30
        public void get_depthBuffer(){} // RVA: 0x7109CB0
        public void GetNativeDepthBufferPtr(){} // RVA: 0x7109D30
        public void DiscardContents(){} // RVA: 0x7109E50 | overloaded x2
        public void MarkRestoreExpected(){} // RVA: 0x7109E00
        public void ResolveAA(){} // RVA: 0x7109EB0
        public void ResolveAATo(){} // RVA: 0x7109F00
        public void ResolveAntiAliasedSurface(){} // RVA: 0x7109F00 | overloaded x2
        public void SetGlobalShaderProperty(){} // RVA: 0x7109F60
        public void Create(){} // RVA: 0x7109FC0
        public void Release(){} // RVA: 0x710A010
        public void IsCreated(){} // RVA: 0x710A060
        public void GenerateMips(){} // RVA: 0x710A0B0
        public void ConvertToEquirect(){} // RVA: 0x710A100
        public void SetSRGBReadWrite(){} // RVA: 0x710A170
        public void Internal_Create(){} // RVA: 0x710A1D0
        public void SupportsStencil(){} // RVA: 0x710A220
        public void SetRenderTextureDescriptor(){} // RVA: 0x710A270
        public void GetDescriptor(){} // RVA: 0x710A2D0
        public void GetTemporary_Internal(){} // RVA: 0x710A350
        public void ReleaseTemporary(){} // RVA: 0x710A3A0
        public void get_depth(){} // RVA: 0x710A3F0
        public void set_depth(){} // RVA: 0x710A440
        public void .ctor(){} // RVA: 0x710B340 | overloaded x12
        public void Initialize(){} // RVA: 0x710B410
        public void GetDepthStencilFormatLegacy(){} // RVA: 0x710B740 | overloaded x4
        public void get_descriptor(){} // RVA: 0x710B7D0
        public void set_descriptor(){} // RVA: 0x710B880
        public void ValidateRenderTextureDesc(){} // RVA: 0x710B940
        public void GetDefaultColorFormat(){} // RVA: 0x710BED0
        public void GetDefaultDepthStencilFormat(){} // RVA: 0x710BF40
        public void GetCompatibleFormat(){} // RVA: 0x710BFB0
        public void GetTemporary(){} // RVA: 0x710C950 | overloaded x14
        public void GetTemporaryImpl(){} // RVA: 0x710C220
        public void get_isCubemap(){} // RVA: 0x710C980
        public void set_isCubemap(){} // RVA: 0x710C9B0
        public void get_isVolume(){} // RVA: 0x710C9F0
        public void set_isVolume(){} // RVA: 0x710CA20
        public void get_enabled(){} // RVA: 0x20D68C0
        public void set_enabled(){} // RVA: 0x2DD310
        public void GetTexelOffset(){} // RVA: 0x3020A0
        public void GetColorBuffer_Injected(){} // RVA: 0x710CA50
        public void GetDepthBuffer_Injected(){} // RVA: 0x710CAB0
        public void SetRenderTextureDescriptor_Injected(){} // RVA: 0x710CB10
        public void GetDescriptor_Injected(){} // RVA: 0x710CB70
        public void GetTemporary_Internal_Injected(){} // RVA: 0x710CBD0
    }

    public class RenderTextureDescriptor
    {
        public int <width>k__BackingField; // 0x10
        public int <height>k__BackingField; // 0x14
        public int <msaaSamples>k__BackingField; // 0x18
        public int <volumeDepth>k__BackingField; // 0x1C
        public int <mipCount>k__BackingField; // 0x20
        public 0x658A5800 _graphicsFormat; // 0x24
        public 0x658A5800 <stencilFormat>k__BackingField; // 0x28
        public 0x658A5800 <depthStencilFormat>k__BackingField; // 0x2C
        public 0x658A2FC8 <dimension>k__BackingField; // 0x30
        public 0x658A2E68 <shadowSamplingMode>k__BackingField; // 0x34
        public 0x658981D8 <vrUsage>k__BackingField; // 0x38
        public 0x65898230 _flags; // 0x3C
        public 0x658982E0 <memoryless>k__BackingField; // 0x40

        // ── Methods ──
        public void get_width(){} // RVA: 0x19689B0
        public void set_width(){} // RVA: 0x833580
        public void get_height(){} // RVA: 0x19689E0
        public void set_height(){} // RVA: 0x19689D0
        public void get_msaaSamples(){} // RVA: 0x1EA9890
        public void set_msaaSamples(){} // RVA: 0x1EA98A0
        public void get_volumeDepth(){} // RVA: 0x1EA98B0
        public void set_volumeDepth(){} // RVA: 0x1EA98C0
        public void get_mipCount(){} // RVA: 0x32A5C0
        public void set_mipCount(){} // RVA: 0x2E00C0
        public void get_graphicsFormat(){} // RVA: 0x2EE0010
        public void set_graphicsFormat(){} // RVA: 0x710DF00
        public void get_depthStencilFormat(){} // RVA: 0x197C3B0
        public void set_depthStencilFormat(){} // RVA: 0x1989FD0
        public void get_colorFormat(){} // RVA: 0x710DFC0
        public void set_colorFormat(){} // RVA: 0x710E070
        public void get_sRGB(){} // RVA: 0x710E140
        public void set_sRGB(){} // RVA: 0x710E1D0
        public void get_depthBufferBits(){} // RVA: 0x710E340
        public void set_depthBufferBits(){} // RVA: 0x710E3D0
        public void get_dimension(){} // RVA: 0x760030
        public void set_dimension(){} // RVA: 0x99E0D0
        public void get_shadowSamplingMode(){} // RVA: 0xCEF5B0
        public void set_shadowSamplingMode(){} // RVA: 0x16E1F00
        public void get_vrUsage(){} // RVA: 0x791DC0
        public void set_vrUsage(){} // RVA: 0xA53440
        public void get_flags(){} // RVA: 0x707C4F0
        public void get_memoryless(){} // RVA: 0x338CD0
        public void set_memoryless(){} // RVA: 0x338CE0
        public void .ctor(){} // RVA: 0x710E8C0 | overloaded x9
        public void SetOrClearRenderTextureCreationFlag(){} // RVA: 0x710E930
        public void get_useMipMap(){} // RVA: 0x710E950
        public void set_useMipMap(){} // RVA: 0x710E960
        public void get_autoGenerateMips(){} // RVA: 0x710E980
        public void set_autoGenerateMips(){} // RVA: 0x710E990
        public void get_enableRandomWrite(){} // RVA: 0x710E9B0
        public void set_enableRandomWrite(){} // RVA: 0x710E9C0
        public void get_bindMS(){} // RVA: 0x710E9E0
        public void set_bindMS(){} // RVA: 0x710E9F0
        public void set_createdFromScript(){} // RVA: 0x710EA10
        public void get_useDynamicScale(){} // RVA: 0x710EA30
        public void set_useDynamicScale(){} // RVA: 0x710EA40
    }

    public class Renderer
    {
        public object instance;
        public object isConnected;

        // ── Methods ──
        public void get_castShadows(){} // RVA: 0x70E3B70
        public void set_castShadows(){} // RVA: 0x70E3BD0
        public void get_motionVectors(){} // RVA: 0x70E3C40
        public void set_motionVectors(){} // RVA: 0x70E3CA0
        public void get_useLightProbes(){} // RVA: 0x70E3D10
        public void set_useLightProbes(){} // RVA: 0x70E3D70
        public void get_bounds(){} // RVA: 0x70E3DE0
        public void set_bounds(){} // RVA: 0x70E3E50
        public void get_localBounds(){} // RVA: 0x70E3EB0
        public void set_localBounds(){} // RVA: 0x70E3F20
        public void ResetBounds(){} // RVA: 0x70E3F80
        public void ResetLocalBounds(){} // RVA: 0x70E3FD0
        public void SetStaticLightmapST(){} // RVA: 0x70E4020
        public void GetMaterial(){} // RVA: 0x70E4080
        public void GetSharedMaterial(){} // RVA: 0x70E40D0
        public void SetMaterial(){} // RVA: 0x70E4120
        public void GetMaterialArray(){} // RVA: 0x70E4180
        public void CopyMaterialArray(){} // RVA: 0x70E41D0
        public void CopySharedMaterialArray(){} // RVA: 0x70E4230
        public void SetMaterialArray(){} // RVA: 0x70E4300 | overloaded x2
        public void Internal_SetPropertyBlock(){} // RVA: 0x70E4330
        public void Internal_GetPropertyBlock(){} // RVA: 0x70E4390
        public void Internal_SetPropertyBlockMaterialIndex(){} // RVA: 0x70E43F0
        public void Internal_GetPropertyBlockMaterialIndex(){} // RVA: 0x70E4460
        public void HasPropertyBlock(){} // RVA: 0x70E44D0
        public void SetPropertyBlock(){} // RVA: 0x70E43F0 | overloaded x2
        public void GetPropertyBlock(){} // RVA: 0x70E4460 | overloaded x2
        public void GetClosestReflectionProbesInternal(){} // RVA: 0x70E4520
        public void get_enabled(){} // RVA: 0x70E4580
        public void set_enabled(){} // RVA: 0x70E45D0
        public void get_isVisible(){} // RVA: 0x70E4630
        public void get_shadowCastingMode(){} // RVA: 0x70E4680
        public void set_shadowCastingMode(){} // RVA: 0x70E46D0
        public void get_receiveShadows(){} // RVA: 0x70E4730
        public void set_receiveShadows(){} // RVA: 0x70E4780
        public void get_forceRenderingOff(){} // RVA: 0x70E47E0
        public void set_forceRenderingOff(){} // RVA: 0x70E4830
        public void GetIsStaticShadowCaster(){} // RVA: 0x70E4890
        public void SetIsStaticShadowCaster(){} // RVA: 0x70E48E0
        public void get_staticShadowCaster(){} // RVA: 0x70E4890
        public void set_staticShadowCaster(){} // RVA: 0x70E48E0
        public void get_motionVectorGenerationMode(){} // RVA: 0x70E4940
        public void set_motionVectorGenerationMode(){} // RVA: 0x70E4990
        public void get_lightProbeUsage(){} // RVA: 0x70E49F0
        public void set_lightProbeUsage(){} // RVA: 0x70E4A40
        public void get_reflectionProbeUsage(){} // RVA: 0x70E4AA0
        public void set_reflectionProbeUsage(){} // RVA: 0x70E4AF0
        public void get_renderingLayerMask(){} // RVA: 0x70E4B50
        public void set_renderingLayerMask(){} // RVA: 0x70E4BA0
        public void get_rendererPriority(){} // RVA: 0x70E4C00
        public void set_rendererPriority(){} // RVA: 0x70E4C50
        public void get_rayTracingMode(){} // RVA: 0x70E4CB0
        public void set_rayTracingMode(){} // RVA: 0x70E4D00
        public void get_sortingLayerName(){} // RVA: 0x70E4D60
        public void set_sortingLayerName(){} // RVA: 0x70E4DB0
        public void get_sortingLayerID(){} // RVA: 0x70E4E10
        public void set_sortingLayerID(){} // RVA: 0x70E4E60
        public void get_sortingOrder(){} // RVA: 0x70E4EC0
        public void set_sortingOrder(){} // RVA: 0x70E4F10
        public void get_sortingKey(){} // RVA: 0x70E4F70
        public void get_sortingGroupID(){} // RVA: 0x70E4FC0
        public void set_sortingGroupID(){} // RVA: 0x70E5010
        public void get_sortingGroupOrder(){} // RVA: 0x70E5070
        public void set_sortingGroupOrder(){} // RVA: 0x70E50C0
        public void get_sortingGroupKey(){} // RVA: 0x70E5120
        public void get_allowOcclusionWhenDynamic(){} // RVA: 0x70E5170
        public void set_allowOcclusionWhenDynamic(){} // RVA: 0x70E51C0
        public void get_staticBatchRootTransform(){} // RVA: 0x70E5220
        public void set_staticBatchRootTransform(){} // RVA: 0x70E5270
        public void get_staticBatchIndex(){} // RVA: 0x70E52D0
        public void SetStaticBatchInfo(){} // RVA: 0x70E5320
        public void get_isPartOfStaticBatch(){} // RVA: 0x70E5390
        public void get_worldToLocalMatrix(){} // RVA: 0x70E53E0
        public void get_localToWorldMatrix(){} // RVA: 0x70E5460
        public void get_lightProbeProxyVolumeOverride(){} // RVA: 0x70E54E0
        public void set_lightProbeProxyVolumeOverride(){} // RVA: 0x70E5530
        public void get_probeAnchor(){} // RVA: 0x70E5590
        public void set_probeAnchor(){} // RVA: 0x70E55E0
        public void GetLightmapIndex(){} // RVA: 0x70E5640
        public void SetLightmapIndex(){} // RVA: 0x70E56A0
        public void GetLightmapST(){} // RVA: 0x70E5710
        public void SetLightmapST(){} // RVA: 0x70E5790
        public void get_lightmapIndex(){} // RVA: 0x70E5800
        public void set_lightmapIndex(){} // RVA: 0x70E5860
        public void get_realtimeLightmapIndex(){} // RVA: 0x70E58C0
        public void set_realtimeLightmapIndex(){} // RVA: 0x70E5920
        public void get_lightmapScaleOffset(){} // RVA: 0x70E5990
        public void set_lightmapScaleOffset(){} // RVA: 0x70E5A10
        public void get_realtimeLightmapScaleOffset(){} // RVA: 0x70E5A70
        public void set_realtimeLightmapScaleOffset(){} // RVA: 0x70E5AF0
        public void GetMaterialCount(){} // RVA: 0x70E5B60
        public void GetSharedMaterialArray(){} // RVA: 0x70E5BB0
        public void get_materials(){} // RVA: 0x70E4180
        public void set_materials(){} // RVA: 0x70E4300
        public void get_material(){} // RVA: 0x70E4080
        public void set_material(){} // RVA: 0x70E4120
        public void get_sharedMaterial(){} // RVA: 0x70E40D0
        public void set_sharedMaterial(){} // RVA: 0x70E4120
        public void get_sharedMaterials(){} // RVA: 0x70E5BB0
        public void set_sharedMaterials(){} // RVA: 0x70E4300
        public void GetMaterials(){} // RVA: 0x70E5C00
        public void SetSharedMaterials(){} // RVA: 0x70E5D50
        public void SetMaterials(){} // RVA: 0x70E5E20
        public void GetSharedMaterials(){} // RVA: 0x70E5EF0
        public void GetClosestReflectionProbes(){} // RVA: 0x70E4520
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_bounds_Injected(){} // RVA: 0x70E6040
        public void set_bounds_Injected(){} // RVA: 0x70E60A0
        public void get_localBounds_Injected(){} // RVA: 0x70E6100
        public void set_localBounds_Injected(){} // RVA: 0x70E6160
        public void SetStaticLightmapST_Injected(){} // RVA: 0x70E61C0
        public void get_worldToLocalMatrix_Injected(){} // RVA: 0x70E6220
        public void get_localToWorldMatrix_Injected(){} // RVA: 0x70E6280
        public void GetLightmapST_Injected(){} // RVA: 0x70E62E0
        public void SetLightmapST_Injected(){} // RVA: 0x70E6350
    }

    public class RendererExtensions
    {
        // ── Methods ──
        public void UpdateGIMaterials(){} // RVA: 0x70DAE30
        public void UpdateGIMaterialsForRenderer(){} // RVA: 0x70DAE30
    }

    public class RequireComponent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
    }

    public class Resolution
    {
        public int asset; // 0x10
        public int GetResult; // 0x14
        public UnityEngine.RefreshRate m_RefreshRate; // 0x18

        // ── Methods ──
        public void get_width(){} // RVA: 0x67FD0D0
        public void set_width(){} // RVA: 0x833580
        public void get_height(){} // RVA: 0x40B7110
        public void set_height(){} // RVA: 0x19689D0
        public void get_refreshRateRatio(){} // RVA: 0x5F1D510
        public void get_refreshRate(){} // RVA: 0x70D99A0
        public void set_refreshRate(){} // RVA: 0x70D9A20
        public void ToString(){} // RVA: 0x70D9A30
    }

    public class ResourceRequest
    {
        public string m_Path; // 0x20

        // ── Methods ──
        public void GetResult(){} // RVA: 0x71203F0
        public void get_asset(){} // RVA: 0x391BC0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Resources
    {
        // ── Methods ──
        public void ConvertObjects(){} // RVA: 0xCE50
        public void FindObjectsOfTypeAll(){} // RVA: 0xC960 | overloaded x2
        public void Load(){} // RVA: 0x7120B40 | overloaded x3
        public void LoadAsync(){} // RVA: 0x7120C90 | overloaded x3
        public void GetBuiltinResource(){} // RVA: 0x283FA0 | overloaded x2
        public void UnloadAsset(){} // RVA: 0x7120D70
        public void UnloadUnusedAssets(){} // RVA: 0x7120DE0
    }

    public class ResourcesAPI
    {
        public UnityEngine.ResourcesAPI s_DefaultAPI;
        public UnityEngine.ResourcesAPI <overrideAPI>k__BackingField; // 0x8

        // ── Methods ──
        public void get_ActiveAPI(){} // RVA: 0x71205C0
        public void get_overrideAPI(){} // RVA: 0x7120680
        public void .ctor(){} // RVA: 0x2DD310
        public void FindObjectsOfTypeAll(){} // RVA: 0x71206E0
        public void FindShaderByName(){} // RVA: 0x7120730
        public void Load(){} // RVA: 0x7120780
        public void LoadAsync(){} // RVA: 0x71207E0
        public void UnloadAsset(){} // RVA: 0x7120910
        public void .cctor(){} // RVA: 0x7120960
    }

    public class ResourcesAPIInternal
    {
        // ── Methods ──
        public void FindObjectsOfTypeAll(){} // RVA: 0x7120410
        public void FindShaderByName(){} // RVA: 0x7120460
        public void Load(){} // RVA: 0x71204B0
        public void LoadAsyncInternal(){} // RVA: 0x7120510
        public void UnloadAsset(){} // RVA: 0x7120570
    }

    public class Rigidbody
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
        public void get_velocity(){} // RVA: 0x71FCF20
        public void set_velocity(){} // RVA: 0x71FCF90
        public void get_angularVelocity(){} // RVA: 0x71FCFF0
        public void set_angularVelocity(){} // RVA: 0x71FD060
        public void get_drag(){} // RVA: 0x71FD0C0
        public void set_drag(){} // RVA: 0x71FD110
        public void get_angularDrag(){} // RVA: 0x71FD170
        public void set_angularDrag(){} // RVA: 0x71FD1C0
        public void get_mass(){} // RVA: 0x71FD220
        public void set_mass(){} // RVA: 0x71FD270
        public void SetDensity(){} // RVA: 0x71FD2D0
        public void get_useGravity(){} // RVA: 0x71FD330
        public void set_useGravity(){} // RVA: 0x71FD380
        public void get_maxDepenetrationVelocity(){} // RVA: 0x71FD3E0
        public void set_maxDepenetrationVelocity(){} // RVA: 0x71FD430
        public void get_isKinematic(){} // RVA: 0x71FD490
        public void set_isKinematic(){} // RVA: 0x71FD4E0
        public void get_freezeRotation(){} // RVA: 0x71FD540
        public void set_freezeRotation(){} // RVA: 0x71FD590
        public void get_constraints(){} // RVA: 0x71FD5F0
        public void set_constraints(){} // RVA: 0x71FD640
        public void get_collisionDetectionMode(){} // RVA: 0x71FD6A0
        public void set_collisionDetectionMode(){} // RVA: 0x71FD6F0
        public void get_automaticCenterOfMass(){} // RVA: 0x71FD750
        public void set_automaticCenterOfMass(){} // RVA: 0x71FD7A0
        public void get_centerOfMass(){} // RVA: 0x71FD800
        public void set_centerOfMass(){} // RVA: 0x71FD870
        public void get_worldCenterOfMass(){} // RVA: 0x71FD8D0
        public void get_automaticInertiaTensor(){} // RVA: 0x71FD940
        public void set_automaticInertiaTensor(){} // RVA: 0x71FD990
        public void get_inertiaTensorRotation(){} // RVA: 0x71FD9F0
        public void set_inertiaTensorRotation(){} // RVA: 0x71FDA60
        public void get_inertiaTensor(){} // RVA: 0x71FDAC0
        public void set_inertiaTensor(){} // RVA: 0x71FDB30
        public void get_detectCollisions(){} // RVA: 0x71FDB90
        public void set_detectCollisions(){} // RVA: 0x71FDBE0
        public void get_position(){} // RVA: 0x71FDC40
        public void set_position(){} // RVA: 0x71FDCB0
        public void get_rotation(){} // RVA: 0x71FDD10
        public void set_rotation(){} // RVA: 0x71FDD80
        public void get_interpolation(){} // RVA: 0x71FDDE0
        public void set_interpolation(){} // RVA: 0x71FDE30
        public void get_solverIterations(){} // RVA: 0x71FDE90
        public void set_solverIterations(){} // RVA: 0x71FDEE0
        public void get_sleepThreshold(){} // RVA: 0x71FDF40
        public void set_sleepThreshold(){} // RVA: 0x71FDF90
        public void get_maxAngularVelocity(){} // RVA: 0x71FDFF0
        public void set_maxAngularVelocity(){} // RVA: 0x71FE040
        public void get_maxLinearVelocity(){} // RVA: 0x71FE0A0
        public void set_maxLinearVelocity(){} // RVA: 0x71FE0F0
        public void MovePosition(){} // RVA: 0x71FE150
        public void MoveRotation(){} // RVA: 0x71FE1B0
        public void Move(){} // RVA: 0x71FE210
        public void Sleep(){} // RVA: 0x71FE280
        public void IsSleeping(){} // RVA: 0x71FE2D0
        public void WakeUp(){} // RVA: 0x71FE320
        public void ResetCenterOfMass(){} // RVA: 0x71FE370
        public void ResetInertiaTensor(){} // RVA: 0x71FE3C0
        public void GetRelativePointVelocity(){} // RVA: 0x71FE410
        public void GetPointVelocity(){} // RVA: 0x71FE490
        public void get_solverVelocityIterations(){} // RVA: 0x71FE510
        public void set_solverVelocityIterations(){} // RVA: 0x71FE560
        public void get_excludeLayers(){} // RVA: 0x71FE5C0
        public void set_excludeLayers(){} // RVA: 0x71FE620
        public void get_includeLayers(){} // RVA: 0x71FE680
        public void set_includeLayers(){} // RVA: 0x71FE6E0
        public void GetAccumulatedForce(){} // RVA: 0x71FE7C0 | overloaded x2
        public void GetAccumulatedTorque(){} // RVA: 0x71FE920 | overloaded x2
        public void AddForce(){} // RVA: 0x71FEB50 | overloaded x4
        public void AddRelativeForce(){} // RVA: 0x71FED10 | overloaded x4
        public void AddTorque(){} // RVA: 0x71FEED0 | overloaded x4
        public void AddRelativeTorque(){} // RVA: 0x71FF090 | overloaded x4
        public void AddForceAtPosition(){} // RVA: 0x71FF180 | overloaded x2
        public void AddExplosionForce(){} // RVA: 0x71FF340 | overloaded x3
        public void Internal_ClosestPointOnBounds(){} // RVA: 0x71FF3E0
        public void ClosestPointOnBounds(){} // RVA: 0x71FF460
        public void SweepTest(){} // RVA: 0x71FF780 | overloaded x4
        public void Internal_SweepTestAll(){} // RVA: 0x71FF7C0
        public void SweepTestAll(){} // RVA: 0x71FF970 | overloaded x3
        public void get_sleepVelocity(){} // RVA: 0x70F2A70
        public void set_sleepVelocity(){} // RVA: 0x2DD310
        public void get_sleepAngularVelocity(){} // RVA: 0x70F2A70
        public void set_sleepAngularVelocity(){} // RVA: 0x2DD310
        public void SetMaxAngularVelocity(){} // RVA: 0x71FE040
        public void get_useConeFriction(){} // RVA: 0x27694F0
        public void set_useConeFriction(){} // RVA: 0x2DD310
        public void get_solverIterationCount(){} // RVA: 0x71FDE90
        public void set_solverIterationCount(){} // RVA: 0x71FDEE0
        public void get_solverVelocityIterationCount(){} // RVA: 0x71FE510
        public void set_solverVelocityIterationCount(){} // RVA: 0x71FE560
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_velocity_Injected(){} // RVA: 0x71FF9B0
        public void set_velocity_Injected(){} // RVA: 0x71FFA10
        public void get_angularVelocity_Injected(){} // RVA: 0x71FFA70
        public void set_angularVelocity_Injected(){} // RVA: 0x71FFAD0
        public void get_centerOfMass_Injected(){} // RVA: 0x71FFB30
        public void set_centerOfMass_Injected(){} // RVA: 0x71FFB90
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x71FFBF0
        public void get_inertiaTensorRotation_Injected(){} // RVA: 0x71FFC50
        public void set_inertiaTensorRotation_Injected(){} // RVA: 0x71FFCB0
        public void get_inertiaTensor_Injected(){} // RVA: 0x71FFD10
        public void set_inertiaTensor_Injected(){} // RVA: 0x71FFD70
        public void get_position_Injected(){} // RVA: 0x71FFDD0
        public void set_position_Injected(){} // RVA: 0x71FFE30
        public void get_rotation_Injected(){} // RVA: 0x71FFE90
        public void set_rotation_Injected(){} // RVA: 0x71FFEF0
        public void MovePosition_Injected(){} // RVA: 0x71FFF50
        public void MoveRotation_Injected(){} // RVA: 0x71FFFB0
        public void Move_Injected(){} // RVA: 0x7200010
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x7200080
        public void GetPointVelocity_Injected(){} // RVA: 0x72000F0
        public void get_excludeLayers_Injected(){} // RVA: 0x7200160
        public void set_excludeLayers_Injected(){} // RVA: 0x72001C0
        public void get_includeLayers_Injected(){} // RVA: 0x7200220
        public void set_includeLayers_Injected(){} // RVA: 0x7200280
        public void GetAccumulatedForce_Injected(){} // RVA: 0x72002E0
        public void GetAccumulatedTorque_Injected(){} // RVA: 0x7200350
        public void AddForce_Injected(){} // RVA: 0x72003C0
        public void AddRelativeForce_Injected(){} // RVA: 0x7200430
        public void AddTorque_Injected(){} // RVA: 0x72004A0
        public void AddRelativeTorque_Injected(){} // RVA: 0x7200510
        public void AddForceAtPosition_Injected(){} // RVA: 0x7200580
        public void AddExplosionForce_Injected(){} // RVA: 0x7200600
        public void Internal_ClosestPointOnBounds_Injected(){} // RVA: 0x7200690
        public void SweepTest_Injected(){} // RVA: 0x7200710
        public void Internal_SweepTestAll_Injected(){} // RVA: 0x72007A0
    }

    public class Rigidbody2D
    {
        public object text;
        public object font;
        public object fontSize;
        public object fontStyle;
        public object offsetZ;
        public object alignment;
        public object anchor;
        public object characterSize;
        public object lineSpacing;
        public object tabSize;
        public object richText;
        public object color;

        // ── Methods ──
        public void get_position(){} // RVA: 0x71E1E10
        public void set_position(){} // RVA: 0x71E1E70
        public void get_rotation(){} // RVA: 0x71E1ED0
        public void set_rotation(){} // RVA: 0x71E1F20
        public void SetRotation(){} // RVA: 0x71E1FE0 | overloaded x2
        public void SetRotation_Angle(){} // RVA: 0x71E1F80
        public void SetRotation_Quaternion(){} // RVA: 0x71E2040
        public void MovePosition(){} // RVA: 0x71E20A0
        public void MoveRotation(){} // RVA: 0x71E2160 | overloaded x2
        public void MoveRotation_Angle(){} // RVA: 0x71E2100
        public void MoveRotation_Quaternion(){} // RVA: 0x71E21C0
        public void get_velocity(){} // RVA: 0x71E2220
        public void set_velocity(){} // RVA: 0x71E2280
        public void get_angularVelocity(){} // RVA: 0x71E22E0
        public void set_angularVelocity(){} // RVA: 0x71E2330
        public void get_useAutoMass(){} // RVA: 0x71E2390
        public void set_useAutoMass(){} // RVA: 0x71E23E0
        public void get_mass(){} // RVA: 0x71E2440
        public void set_mass(){} // RVA: 0x71E2490
        public void get_sharedMaterial(){} // RVA: 0x71E24F0
        public void set_sharedMaterial(){} // RVA: 0x71E2540
        public void get_centerOfMass(){} // RVA: 0x71E25A0
        public void set_centerOfMass(){} // RVA: 0x71E2600
        public void get_worldCenterOfMass(){} // RVA: 0x71E2660
        public void get_inertia(){} // RVA: 0x71E26C0
        public void set_inertia(){} // RVA: 0x71E2710
        public void get_drag(){} // RVA: 0x71E2770
        public void set_drag(){} // RVA: 0x71E27C0
        public void get_angularDrag(){} // RVA: 0x71E2820
        public void set_angularDrag(){} // RVA: 0x71E2870
        public void get_gravityScale(){} // RVA: 0x71E28D0
        public void set_gravityScale(){} // RVA: 0x71E2920
        public void get_bodyType(){} // RVA: 0x71E2980
        public void set_bodyType(){} // RVA: 0x71E29D0
        public void get_useFullKinematicContacts(){} // RVA: 0x71E2A30
        public void set_useFullKinematicContacts(){} // RVA: 0x71E2A80
        public void get_isKinematic(){} // RVA: 0x71E2AE0
        public void set_isKinematic(){} // RVA: 0x71E2B40
        public void get_freezeRotation(){} // RVA: 0x71E2BB0
        public void set_freezeRotation(){} // RVA: 0x71E2C00
        public void get_constraints(){} // RVA: 0x71E2C60
        public void set_constraints(){} // RVA: 0x71E2CB0
        public void IsSleeping(){} // RVA: 0x71E2D10
        public void IsAwake(){} // RVA: 0x71E2D60
        public void Sleep(){} // RVA: 0x71E2DB0
        public void WakeUp(){} // RVA: 0x71E2E00
        public void get_simulated(){} // RVA: 0x71E2E50
        public void set_simulated(){} // RVA: 0x71E2EA0
        public void get_interpolation(){} // RVA: 0x71E2F00
        public void set_interpolation(){} // RVA: 0x71E2F50
        public void get_sleepMode(){} // RVA: 0x71E2FB0
        public void set_sleepMode(){} // RVA: 0x71E3000
        public void get_collisionDetectionMode(){} // RVA: 0x71E3060
        public void set_collisionDetectionMode(){} // RVA: 0x71E30B0
        public void get_attachedColliderCount(){} // RVA: 0x71E3110
        public void get_totalForce(){} // RVA: 0x71E3160
        public void set_totalForce(){} // RVA: 0x71E31C0
        public void get_totalTorque(){} // RVA: 0x71E3220
        public void set_totalTorque(){} // RVA: 0x71E3270
        public void get_excludeLayers(){} // RVA: 0x71E32D0
        public void set_excludeLayers(){} // RVA: 0x71E3330
        public void get_includeLayers(){} // RVA: 0x71E3390
        public void set_includeLayers(){} // RVA: 0x71E33F0
        public void IsTouching(){} // RVA: 0x71E35A0 | overloaded x3
        public void IsTouching_OtherColliderWithFilter_Internal(){} // RVA: 0x71E3530
        public void IsTouching_AnyColliderWithFilter_Internal(){} // RVA: 0x71E3610
        public void IsTouchingLayers(){} // RVA: 0x71E36D0 | overloaded x2
        public void OverlapPoint(){} // RVA: 0x71E3730
        public void Distance(){} // RVA: 0x71E3790
        public void Distance_Internal(){} // RVA: 0x71E3AB0
        public void ClosestPoint(){} // RVA: 0x71E3B30
        public void AddForce(){} // RVA: 0x71E3C00 | overloaded x2
        public void AddRelativeForce(){} // RVA: 0x71E3CD0 | overloaded x2
        public void AddForceAtPosition(){} // RVA: 0x71E3DB0 | overloaded x2
        public void AddTorque(){} // RVA: 0x71E3EA0 | overloaded x2
        public void GetPoint(){} // RVA: 0x71E3F10
        public void GetRelativePoint(){} // RVA: 0x71E3F80
        public void GetVector(){} // RVA: 0x71E3FF0
        public void GetRelativeVector(){} // RVA: 0x71E4060
        public void GetPointVelocity(){} // RVA: 0x71E40D0
        public void GetRelativePointVelocity(){} // RVA: 0x71E4140
        public void OverlapCollider(){} // RVA: 0x71E42A0 | overloaded x2
        public void OverlapColliderArray_Internal(){} // RVA: 0x71E4230
        public void OverlapColliderList_Internal(){} // RVA: 0x71E4320
        public void GetContacts(){} // RVA: 0x71E4840 | overloaded x8
        public void GetAttachedColliders(){} // RVA: 0x71E4930 | overloaded x2
        public void GetAttachedCollidersArray_Internal(){} // RVA: 0x71E48D0
        public void GetAttachedCollidersList_Internal(){} // RVA: 0x71E4930
        public void Cast(){} // RVA: 0x71E4D30 | overloaded x6
        public void CastArray_Internal(){} // RVA: 0x71E49E0
        public void CastList_Internal(){} // RVA: 0x71E4AE0
        public void CastFilteredArray_Internal(){} // RVA: 0x71E4CA0
        public void CastFilteredList_Internal(){} // RVA: 0x71E4DD0
        public void GetShapes(){} // RVA: 0x71E4E60
        public void GetShapes_Internal(){} // RVA: 0x71E4ED0
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_position_Injected(){} // RVA: 0x71E4F30
        public void set_position_Injected(){} // RVA: 0x71E4F90
        public void SetRotation_Quaternion_Injected(){} // RVA: 0x71E4FF0
        public void MovePosition_Injected(){} // RVA: 0x71E5050
        public void MoveRotation_Quaternion_Injected(){} // RVA: 0x71E50B0
        public void get_velocity_Injected(){} // RVA: 0x71E5110
        public void set_velocity_Injected(){} // RVA: 0x71E5170
        public void get_centerOfMass_Injected(){} // RVA: 0x71E51D0
        public void set_centerOfMass_Injected(){} // RVA: 0x71E5230
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x71E5290
        public void get_totalForce_Injected(){} // RVA: 0x71E52F0
        public void set_totalForce_Injected(){} // RVA: 0x71E5350
        public void get_excludeLayers_Injected(){} // RVA: 0x71E53B0
        public void set_excludeLayers_Injected(){} // RVA: 0x71E5410
        public void get_includeLayers_Injected(){} // RVA: 0x71E5470
        public void set_includeLayers_Injected(){} // RVA: 0x71E54D0
        public void IsTouching_OtherColliderWithFilter_Internal_Injected(){} // RVA: 0x71E5530
        public void IsTouching_AnyColliderWithFilter_Internal_Injected(){} // RVA: 0x71E55A0
        public void OverlapPoint_Injected(){} // RVA: 0x71E5600
        public void Distance_Internal_Injected(){} // RVA: 0x71E5660
        public void AddForce_Injected(){} // RVA: 0x71E56D0
        public void AddRelativeForce_Injected(){} // RVA: 0x71E5740
        public void AddForceAtPosition_Injected(){} // RVA: 0x71E57B0
        public void GetPoint_Injected(){} // RVA: 0x71E5830
        public void GetRelativePoint_Injected(){} // RVA: 0x71E58A0
        public void GetVector_Injected(){} // RVA: 0x71E5910
        public void GetRelativeVector_Injected(){} // RVA: 0x71E5980
        public void GetPointVelocity_Injected(){} // RVA: 0x71E59F0
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x71E5A60
        public void OverlapColliderArray_Internal_Injected(){} // RVA: 0x71E5AD0
        public void OverlapColliderList_Internal_Injected(){} // RVA: 0x71E5B40
        public void CastArray_Internal_Injected(){} // RVA: 0x71E5BB0
        public void CastList_Internal_Injected(){} // RVA: 0x71E5C30
        public void CastFilteredArray_Internal_Injected(){} // RVA: 0x71E5CB0
        public void CastFilteredList_Internal_Injected(){} // RVA: 0x71E5D40
    }

    public class RuntimeAnimatorController
    {
        public object runtimeAnimatorController;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x709A690
        public void get_animationClips(){} // RVA: 0x709A6E0
    }

    public class RuntimeInitializeOnLoadMethodAttribute
    {
        public 0x6589B300 m_LoadType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0 | overloaded x2
        public void set_loadType(){} // RVA: 0x2E00C0
    }

}