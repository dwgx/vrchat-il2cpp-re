// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 37
// Methods: 1037

namespace ThirdParty.Unity.UnityEngine
{
    public class Random
    {
        // ── Methods ──
        public void InitState(){} // RVA: 0x7FFAF9BCFB50
        public void Range(){} // RVA: 0x7FFAF9BCFC10 | overloaded x2
        public void RandomRangeInt(){} // RVA: 0x7FFAF9BCFC10
        public void get_value(){} // RVA: 0x7FFAF41D60C0
        public void get_insideUnitSphere(){} // RVA: 0x7FFAF9BCFC70
        public void GetRandomUnitCircle(){} // RVA: 0x7FFAF9BCFCD0
        public void get_insideUnitCircle(){} // RVA: 0x7FFAF9BCFD20
        public void get_onUnitSphere(){} // RVA: 0x7FFAF9BCFD80
        public void get_rotation(){} // RVA: 0x7FFAF9BCFDE0
        public void get_rotationUniform(){} // RVA: 0x7FFAF9BCFE40
        public void ColorHSV(){} // RVA: 0x7FFAF9BD0040 | overloaded x5
        public void get_insideUnitSphere_Injected(){} // RVA: 0x7FFAF9BD02B0
        public void get_onUnitSphere_Injected(){} // RVA: 0x7FFAF9BD0300
        public void get_rotation_Injected(){} // RVA: 0x7FFAF9BD0350
        public void get_rotationUniform_Injected(){} // RVA: 0x7FFAF9BD03A0
    }

    public class RangeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF3B51C60
    }

    public class RangeInt
    {
        // ── Methods ──
        public void get_end(){} // RVA: 0x7FFAF9BDAD00
        public void .ctor(){} // RVA: 0x7FFAF335E010
    }

    public class Ray
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B7D9D0
        public void get_origin(){} // RVA: 0x7FFAF9B29450
        public void set_origin(){} // RVA: 0x7FFAF4BBE450
        public void get_direction(){} // RVA: 0x7FFAF9B29470
        public void set_direction(){} // RVA: 0x7FFAF9B7DA10
        public void GetPoint(){} // RVA: 0x7FFAF9B7DA40
        public void ToString(){} // RVA: 0x7FFAF9B7DAB0 | overloaded x3
    }

    public class RaycastCommand
    {
        // ── Methods ──
        public void set_from(){} // RVA: 0x7FFAF4BBE450
        public void set_direction(){} // RVA: 0x7FFAF9B29490
        public void set_physicsScene(){} // RVA: 0x7FFAF30E74E0
        public void set_distance(){} // RVA: 0x7FFAF2E5A580
        public void ScheduleBatch(){} // RVA: 0x7FFAF9CBB880
        public void ScheduleRaycastBatch(){} // RVA: 0x7FFAF9CBBAB0
        public void ScheduleRaycastBatch_Injected(){} // RVA: 0x7FFAF9CBBB60
    }

    public class RaycastHit
    {
        // ── Methods ──
        public void get_collider(){} // RVA: 0x7FFAF9CAC440
        public void get_colliderInstanceID(){} // RVA: 0x7FFAF6E8B8C0
        public void get_point(){} // RVA: 0x7FFAF9B29450
        public void set_point(){} // RVA: 0x7FFAF4BBE450
        public void get_normal(){} // RVA: 0x7FFAF9B29470
        public void set_normal(){} // RVA: 0x7FFAF9B29490
        public void get_barycentricCoordinate(){} // RVA: 0x7FFAF9CAC530
        public void set_barycentricCoordinate(){} // RVA: 0x7FFAF9CAC560
        public void get_distance(){} // RVA: 0x7FFAF9B2C4B0
        public void set_distance(){} // RVA: 0x7FFAF2E5A580
        public void get_triangleIndex(){} // RVA: 0x7FFAF6842310
        public void CalculateRaycastTexCoord(){} // RVA: 0x7FFAF9CAC580
        public void get_textureCoord(){} // RVA: 0x7FFAF9CAC620
        public void get_textureCoord2(){} // RVA: 0x7FFAF9CAC6D0
        public void get_transform(){} // RVA: 0x7FFAF9CAC780
        public void get_rigidbody(){} // RVA: 0x7FFAF9CAC9A0
        public void get_articulationBody(){} // RVA: 0x7FFAF9CACAE0
        public void get_lightmapCoord(){} // RVA: 0x7FFAF9CACC20
        public void CalculateRaycastTexCoord_Injected(){} // RVA: 0x7FFAF9CACEA0
    }

    public class RaycastHit2D
    {
        // ── Methods ──
        public void get_centroid(){} // RVA: 0x7FFAF51E8C50
        public void set_centroid(){} // RVA: 0x7FFAF45C2320
        public void get_point(){} // RVA: 0x7FFAF9B7DE50
        public void set_point(){} // RVA: 0x7FFAF4998D20
        public void get_normal(){} // RVA: 0x7FFAF9C90000
        public void set_normal(){} // RVA: 0x7FFAF4417700
        public void get_distance(){} // RVA: 0x7FFAF9B294A0
        public void set_distance(){} // RVA: 0x7FFAF2DA84D0
        public void get_fraction(){} // RVA: 0x7FFAF9B2C4B0
        public void set_fraction(){} // RVA: 0x7FFAF2E5A580
        public void get_collider(){} // RVA: 0x7FFAF9C916A0
        public void get_rigidbody(){} // RVA: 0x7FFAF9C91790
        public void get_transform(){} // RVA: 0x7FFAF9C918D0
        public void op_Implicit(){} // RVA: 0x7FFAF9C91AF0
        public void CompareTo(){} // RVA: 0x7FFAF9C91BD0
    }

    public class Rect
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4A283A0 | overloaded x3
        public void get_zero(){} // RVA: 0x7FFAF9B7DCA0
        public void MinMaxRect(){} // RVA: 0x7FFAF9B7DCB0
        public void Set(){} // RVA: 0x7FFAF2DB1570
        public void get_x(){} // RVA: 0x7FFAF2DB0D20
        public void set_x(){} // RVA: 0x7FFAF4A28330
        public void get_y(){} // RVA: 0x7FFAF2DB0D30
        public void set_y(){} // RVA: 0x7FFAF4A28350
        public void get_position(){} // RVA: 0x7FFAF9B7DCF0
        public void set_position(){} // RVA: 0x7FFAF9B7DD10
        public void get_center(){} // RVA: 0x7FFAF9B7DD30
        public void set_center(){} // RVA: 0x7FFAF9B7DD60
        public void get_min(){} // RVA: 0x7FFAF9B7DDA0
        public void set_min(){} // RVA: 0x7FFAF9B7DDC0
        public void get_max(){} // RVA: 0x7FFAF9B7DE00
        public void set_max(){} // RVA: 0x7FFAF9B7DE20
        public void get_width(){} // RVA: 0x7FFAF2DB0CF0
        public void set_width(){} // RVA: 0x7FFAF4A28340
        public void get_height(){} // RVA: 0x7FFAF2DB0D00
        public void set_height(){} // RVA: 0x7FFAF4A28380
        public void get_size(){} // RVA: 0x7FFAF9B7DE50
        public void set_size(){} // RVA: 0x7FFAF9B7DE70
        public void get_xMin(){} // RVA: 0x7FFAF2DB0D20
        public void set_xMin(){} // RVA: 0x7FFAF9B7DE90
        public void get_yMin(){} // RVA: 0x7FFAF2DB0D30
        public void set_yMin(){} // RVA: 0x7FFAF9B7DEB0
        public void get_xMax(){} // RVA: 0x7FFAF9B7DED0
        public void set_xMax(){} // RVA: 0x7FFAF9B7DEE0
        public void get_yMax(){} // RVA: 0x7FFAF9B7DEF0
        public void set_yMax(){} // RVA: 0x7FFAF9B7DF00
        public void Contains(){} // RVA: 0x7FFAF9B7DF90 | overloaded x3
        public void OrderMinMax(){} // RVA: 0x7FFAF9B7E0B0
        public void Overlaps(){} // RVA: 0x7FFAF9B7E170 | overloaded x2
        public void NormalizedToPoint(){} // RVA: 0x7FFAF9B7E2D0
        public void PointToNormalized(){} // RVA: 0x7FFAF9B7E350
        public void op_Inequality(){} // RVA: 0x7FFAF9B7E3F0
        public void op_Equality(){} // RVA: 0x7FFAF9B7E440
        public void GetHashCode(){} // RVA: 0x7FFAF9B7E480
        public void Equals(){} // RVA: 0x7FFAF4F23580 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF9B7E5B0 | overloaded x3
    }

    public class RectInt
    {
        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFAF92AD0D0
        public void set_x(){} // RVA: 0x7FFAF32E3580
        public void get_y(){} // RVA: 0x7FFAF6B67110
        public void set_y(){} // RVA: 0x7FFAF44189D0
        public void get_width(){} // RVA: 0x7FFAF66FE030
        public void set_width(){} // RVA: 0x7FFAF49598A0
        public void get_height(){} // RVA: 0x7FFAF6728200
        public void set_height(){} // RVA: 0x7FFAF49598C0
        public void get_xMin(){} // RVA: 0x7FFAF9B7E940
        public void get_yMin(){} // RVA: 0x7FFAF9B7E9B0
        public void get_xMax(){} // RVA: 0x7FFAF9B7EA20
        public void get_yMax(){} // RVA: 0x7FFAF9B7EA90
        public void .ctor(){} // RVA: 0x7FFAF8638150
        public void Overlaps(){} // RVA: 0x7FFAF9B7EB00
        public void ToString(){} // RVA: 0x7FFAF9B7EBB0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAF9B7F000
    }

    public class RectOffset
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B7F180 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFAF9B7F0E0
        public void ToString(){} // RVA: 0x7FFAF9B7F330 | overloaded x2
        public void Destroy(){} // RVA: 0x7FFAF9B7F890
        public void InternalCreate(){} // RVA: 0x7FFAF9B7F900
        public void InternalDestroy(){} // RVA: 0x7FFAF9B7F950
        public void get_left(){} // RVA: 0x7FFAF9B7F9A0
        public void set_left(){} // RVA: 0x7FFAF9B7F9F0
        public void get_right(){} // RVA: 0x7FFAF9B7FA50
        public void set_right(){} // RVA: 0x7FFAF9B7FAA0
        public void get_top(){} // RVA: 0x7FFAF9B7FB00
        public void set_top(){} // RVA: 0x7FFAF9B7FB50
        public void get_bottom(){} // RVA: 0x7FFAF9B7FBB0
        public void set_bottom(){} // RVA: 0x7FFAF9B7FC00
        public void get_horizontal(){} // RVA: 0x7FFAF9B7FC60
        public void get_vertical(){} // RVA: 0x7FFAF9B7FCB0
        public void Remove(){} // RVA: 0x7FFAF9B7FD00
        public void Remove_Injected(){} // RVA: 0x7FFAF9B7FD80
    }

    public class RectTransform
    {
        // ── Methods ──
        public void add_reapplyDrivenProperties(){} // RVA: 0x7FFAF9BE5E50
        public void remove_reapplyDrivenProperties(){} // RVA: 0x7FFAF9BE5F60
        public void get_rect(){} // RVA: 0x7FFAF9BE6070
        public void get_anchorMin(){} // RVA: 0x7FFAF9BE60E0
        public void set_anchorMin(){} // RVA: 0x7FFAF9BE6140
        public void get_anchorMax(){} // RVA: 0x7FFAF9BE61A0
        public void set_anchorMax(){} // RVA: 0x7FFAF9BE6200
        public void get_anchoredPosition(){} // RVA: 0x7FFAF9BE6260
        public void set_anchoredPosition(){} // RVA: 0x7FFAF9BE62C0
        public void get_sizeDelta(){} // RVA: 0x7FFAF9BE6320
        public void set_sizeDelta(){} // RVA: 0x7FFAF9BE6380
        public void get_pivot(){} // RVA: 0x7FFAF9BE63E0
        public void set_pivot(){} // RVA: 0x7FFAF9BE6440
        public void get_anchoredPosition3D(){} // RVA: 0x7FFAF9BE64A0
        public void set_anchoredPosition3D(){} // RVA: 0x7FFAF9BE6580
        public void get_offsetMin(){} // RVA: 0x7FFAF9BE66B0
        public void set_offsetMin(){} // RVA: 0x7FFAF9BE67E0
        public void get_offsetMax(){} // RVA: 0x7FFAF9BE6B60
        public void set_offsetMax(){} // RVA: 0x7FFAF9BE6CF0
        public void get_drivenByObject(){} // RVA: 0x7FFAF9BE7050
        public void set_drivenByObject(){} // RVA: 0x7FFAF9BE70A0
        public void get_drivenProperties(){} // RVA: 0x7FFAF9BE7100
        public void set_drivenProperties(){} // RVA: 0x7FFAF9BE7150
        public void ForceUpdateRectTransforms(){} // RVA: 0x7FFAF9BE71B0
        public void GetLocalCorners(){} // RVA: 0x7FFAF9BE7200
        public void GetWorldCorners(){} // RVA: 0x7FFAF9BE7380
        public void SetInsetAndSizeFromParentEdge(){} // RVA: 0x7FFAF9BE76F0
        public void SetSizeWithCurrentAnchors(){} // RVA: 0x7FFAF9BE7C40
        public void SendReapplyDrivenProperties(){} // RVA: 0x7FFAF9BE7FA0
        public void GetRectInParentSpace(){} // RVA: 0x7FFAF9BE8000
        public void GetParentSize(){} // RVA: 0x7FFAF9BE84C0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_rect_Injected(){} // RVA: 0x7FFAF9BE86A0
        public void get_anchorMin_Injected(){} // RVA: 0x7FFAF9BE8700
        public void set_anchorMin_Injected(){} // RVA: 0x7FFAF9BE8760
        public void get_anchorMax_Injected(){} // RVA: 0x7FFAF9BE87C0
        public void set_anchorMax_Injected(){} // RVA: 0x7FFAF9BE8820
        public void get_anchoredPosition_Injected(){} // RVA: 0x7FFAF9BE8880
        public void set_anchoredPosition_Injected(){} // RVA: 0x7FFAF9BE88E0
        public void get_sizeDelta_Injected(){} // RVA: 0x7FFAF9BE8940
        public void set_sizeDelta_Injected(){} // RVA: 0x7FFAF9BE89A0
        public void get_pivot_Injected(){} // RVA: 0x7FFAF9BE8A00
        public void set_pivot_Injected(){} // RVA: 0x7FFAF9BE8A60
    }

    public class RectTransformUtility
    {
        // ── Methods ──
        public void PixelAdjustPoint(){} // RVA: 0x7FFAF9F4DDB0
        public void PixelAdjustRect(){} // RVA: 0x7FFAF9F4DE60
        public void PointInRectangle(){} // RVA: 0x7FFAF9F4DF10
        public void RectangleContainsScreenPoint(){} // RVA: 0x7FFAF9F4E0F0 | overloaded x3
        public void ScreenPointToWorldPointInRectangle(){} // RVA: 0x7FFAF9F4E1F0
        public void ScreenPointToLocalPointInRectangle(){} // RVA: 0x7FFAF9F4E8F0
        public void ScreenPointToRay(){} // RVA: 0x7FFAF9F4EA60
        public void WorldToScreenPoint(){} // RVA: 0x7FFAF9F4ECF0
        public void FlipLayoutOnAxis(){} // RVA: 0x7FFAF9F4EE60
        public void FlipLayoutAxes(){} // RVA: 0x7FFAF9F4F550
        public void GetTransposed(){} // RVA: 0x7FFAF9F4FB50
        public void .cctor(){} // RVA: 0x7FFAF9F4FB70
        public void PixelAdjustPoint_Injected(){} // RVA: 0x7FFAF9F4FC30
        public void PixelAdjustRect_Injected(){} // RVA: 0x7FFAF9F4FCB0
        public void PointInRectangle_Injected(){} // RVA: 0x7FFAF9F4FD20
    }

    public class ReflectionProbe
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFAF9B74240
        public void set_type(){} // RVA: 0x7FFAF9B74290
        public void get_size(){} // RVA: 0x7FFAF9B742F0
        public void set_size(){} // RVA: 0x7FFAF9B74360
        public void get_center(){} // RVA: 0x7FFAF9B743C0
        public void set_center(){} // RVA: 0x7FFAF9B74430
        public void get_nearClipPlane(){} // RVA: 0x7FFAF9B74490
        public void set_nearClipPlane(){} // RVA: 0x7FFAF9B744E0
        public void get_farClipPlane(){} // RVA: 0x7FFAF9B74540
        public void set_farClipPlane(){} // RVA: 0x7FFAF9B74590
        public void get_intensity(){} // RVA: 0x7FFAF9B745F0
        public void set_intensity(){} // RVA: 0x7FFAF9B74640
        public void get_bounds(){} // RVA: 0x7FFAF9B746A0
        public void get_hdr(){} // RVA: 0x7FFAF9B74710
        public void set_hdr(){} // RVA: 0x7FFAF9B74760
        public void get_renderDynamicObjects(){} // RVA: 0x7FFAF9B747C0
        public void set_renderDynamicObjects(){} // RVA: 0x7FFAF9B74810
        public void get_shadowDistance(){} // RVA: 0x7FFAF9B74870
        public void set_shadowDistance(){} // RVA: 0x7FFAF9B748C0
        public void get_resolution(){} // RVA: 0x7FFAF9B74920
        public void set_resolution(){} // RVA: 0x7FFAF9B74970
        public void get_cullingMask(){} // RVA: 0x7FFAF9B749D0
        public void set_cullingMask(){} // RVA: 0x7FFAF9B74A20
        public void get_clearFlags(){} // RVA: 0x7FFAF9B74A80
        public void set_clearFlags(){} // RVA: 0x7FFAF9B74AD0
        public void get_backgroundColor(){} // RVA: 0x7FFAF9B74B30
        public void set_backgroundColor(){} // RVA: 0x7FFAF9B74BA0
        public void get_blendDistance(){} // RVA: 0x7FFAF9B74C00
        public void set_blendDistance(){} // RVA: 0x7FFAF9B74C50
        public void get_boxProjection(){} // RVA: 0x7FFAF9B74CB0
        public void set_boxProjection(){} // RVA: 0x7FFAF9B74D00
        public void get_mode(){} // RVA: 0x7FFAF9B74D60
        public void set_mode(){} // RVA: 0x7FFAF9B74DB0
        public void get_importance(){} // RVA: 0x7FFAF9B74E10
        public void set_importance(){} // RVA: 0x7FFAF9B74E60
        public void get_refreshMode(){} // RVA: 0x7FFAF9B74EC0
        public void set_refreshMode(){} // RVA: 0x7FFAF9B74F10
        public void get_timeSlicingMode(){} // RVA: 0x7FFAF9B74F70
        public void set_timeSlicingMode(){} // RVA: 0x7FFAF9B74FC0
        public void get_bakedTexture(){} // RVA: 0x7FFAF9B75020
        public void set_bakedTexture(){} // RVA: 0x7FFAF9B75070
        public void get_customBakedTexture(){} // RVA: 0x7FFAF9B750D0
        public void set_customBakedTexture(){} // RVA: 0x7FFAF9B75120
        public void get_realtimeTexture(){} // RVA: 0x7FFAF9B75180
        public void set_realtimeTexture(){} // RVA: 0x7FFAF9B751D0
        public void get_texture(){} // RVA: 0x7FFAF9B75230
        public void get_textureHDRDecodeValues(){} // RVA: 0x7FFAF9B75280
        public void Reset(){} // RVA: 0x7FFAF9B752F0
        public void RenderProbe(){} // RVA: 0x7FFAF9B75350 | overloaded x2
        public void IsFinishedRendering(){} // RVA: 0x7FFAF9B75400
        public void ScheduleRender(){} // RVA: 0x7FFAF9B75460
        public void BlendCubemap(){} // RVA: 0x7FFAF9B754D0
        public void UpdateCachedState(){} // RVA: 0x7FFAF9B75550
        public void get_minBakedCubemapResolution(){} // RVA: 0x7FFAF9B755A0
        public void get_maxBakedCubemapResolution(){} // RVA: 0x7FFAF9B755F0
        public void get_defaultTextureHDRDecodeValues(){} // RVA: 0x7FFAF9B75640
        public void get_defaultTexture(){} // RVA: 0x7FFAF9B756D0
        public void add_reflectionProbeChanged(){} // RVA: 0x7FFAF9B75720
        public void remove_reflectionProbeChanged(){} // RVA: 0x7FFAF9B75880
        public void CallReflectionProbeEvent(){} // RVA: 0x7FFAF9B759E0
        public void add_defaultReflectionSet(){} // RVA: 0x7FFAF9B75A60
        public void remove_defaultReflectionSet(){} // RVA: 0x7FFAF9B75CB0
        public void add_defaultReflectionTexture(){} // RVA: 0x7FFAF9B75E90
        public void remove_defaultReflectionTexture(){} // RVA: 0x7FFAF9B76140
        public void CallSetDefaultReflection(){} // RVA: 0x7FFAF9B761D0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void .cctor(){} // RVA: 0x7FFAF9B76360
        public void get_size_Injected(){} // RVA: 0x7FFAF9B76500
        public void set_size_Injected(){} // RVA: 0x7FFAF9B76560
        public void get_center_Injected(){} // RVA: 0x7FFAF9B765C0
        public void set_center_Injected(){} // RVA: 0x7FFAF9B76620
        public void get_bounds_Injected(){} // RVA: 0x7FFAF9B76680
        public void get_backgroundColor_Injected(){} // RVA: 0x7FFAF9B766E0
        public void set_backgroundColor_Injected(){} // RVA: 0x7FFAF9B76740
        public void get_textureHDRDecodeValues_Injected(){} // RVA: 0x7FFAF9B767A0
        public void get_defaultTextureHDRDecodeValues_Injected(){} // RVA: 0x7FFAF9B76800
    }

    public class RefreshRate
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAF9B83620
        public void Equals(){} // RVA: 0x7FFAF9B83640
        public void CompareTo(){} // RVA: 0x7FFAF9B83680
        public void ToString(){} // RVA: 0x7FFAF9B836D0
    }

    public class RejectDragAndDropMaterial
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
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
        public void get_maxForce(){} // RVA: 0x7FFAF9C9C720
        public void set_maxForce(){} // RVA: 0x7FFAF9C9C770
        public void get_maxTorque(){} // RVA: 0x7FFAF9C9C7D0
        public void set_maxTorque(){} // RVA: 0x7FFAF9C9C820
        public void get_correctionScale(){} // RVA: 0x7FFAF9C9C880
        public void set_correctionScale(){} // RVA: 0x7FFAF9C9C8D0
        public void get_autoConfigureOffset(){} // RVA: 0x7FFAF9C9C930
        public void set_autoConfigureOffset(){} // RVA: 0x7FFAF9C9C980
        public void get_linearOffset(){} // RVA: 0x7FFAF9C9C9E0
        public void set_linearOffset(){} // RVA: 0x7FFAF9C9CA40
        public void get_angularOffset(){} // RVA: 0x7FFAF9C9CAA0
        public void set_angularOffset(){} // RVA: 0x7FFAF9C9CAF0
        public void get_target(){} // RVA: 0x7FFAF9C9CB50
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_linearOffset_Injected(){} // RVA: 0x7FFAF9C9CBB0
        public void set_linearOffset_Injected(){} // RVA: 0x7FFAF9C9CC10
        public void get_target_Injected(){} // RVA: 0x7FFAF9C9CC70
    }

    public class RemoteConfigSettings
    {
        // ── Methods ──
        public void RemoteConfigSettingsUpdated(){} // RVA: 0x7FFAF9FA67D0
    }

    public class RemoteConfigSettingsHelper
    {
    }

    public class RemoteSettings
    {
        // ── Methods ──
        public void RemoteSettingsUpdated(){} // RVA: 0x7FFAF9FA6690
        public void RemoteSettingsBeforeFetchFromServer(){} // RVA: 0x7FFAF9FA66F0
        public void RemoteSettingsUpdateCompleted(){} // RVA: 0x7FFAF9FA6750
    }

    public class RenderBuffer
    {
    }

    public class RenderInstancedDataLayout
    {
    }

    public class RenderParams
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B89BE0
        public void set_layer(){} // RVA: 0x7FFAF32E3580
        public void set_renderingLayerMask(){} // RVA: 0x7FFAF44189D0
        public void set_rendererPriority(){} // RVA: 0x7FFAF49598A0
        public void set_worldBounds(){} // RVA: 0x7FFAF9B89E70
        public void set_camera(){} // RVA: 0x7FFAF2D8EE90
        public void set_motionVectorMode(){} // RVA: 0x7FFAF2DE8CE0
        public void set_reflectionProbeUsage(){} // RVA: 0x7FFAF2F75F20
        public void set_material(){} // RVA: 0x7FFAF2F4B830
        public void get_matProps(){} // RVA: 0x7FFAF2E0A740
        public void set_matProps(){} // RVA: 0x7FFAF2DB5200
        public void set_shadowCastingMode(){} // RVA: 0x7FFAF2E2E0D0
        public void set_receiveShadows(){} // RVA: 0x7FFAF4190A80
        public void set_lightProbeUsage(){} // RVA: 0x7FFAF310F570
        public void set_lightProbeProxyVolume(){} // RVA: 0x7FFAF2E55510
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
        public void get_fog(){} // RVA: 0x7FFAF9B963C0
        public void set_fog(){} // RVA: 0x7FFAF9B96410
        public void get_fogStartDistance(){} // RVA: 0x7FFAF9B96460
        public void set_fogStartDistance(){} // RVA: 0x7FFAF9B964B0
        public void get_fogEndDistance(){} // RVA: 0x7FFAF9B96510
        public void set_fogEndDistance(){} // RVA: 0x7FFAF9B96560
        public void get_fogMode(){} // RVA: 0x7FFAF9B965C0
        public void set_fogMode(){} // RVA: 0x7FFAF9B96610
        public void get_fogColor(){} // RVA: 0x7FFAF9B96660
        public void set_fogColor(){} // RVA: 0x7FFAF9B966C0
        public void get_fogDensity(){} // RVA: 0x7FFAF9B96710
        public void set_fogDensity(){} // RVA: 0x7FFAF9B96760
        public void get_ambientMode(){} // RVA: 0x7FFAF9B967C0
        public void set_ambientMode(){} // RVA: 0x7FFAF9B96810
        public void get_ambientSkyColor(){} // RVA: 0x7FFAF9B96860
        public void set_ambientSkyColor(){} // RVA: 0x7FFAF9B968C0
        public void get_ambientEquatorColor(){} // RVA: 0x7FFAF9B96910
        public void set_ambientEquatorColor(){} // RVA: 0x7FFAF9B96970
        public void get_ambientGroundColor(){} // RVA: 0x7FFAF9B969C0
        public void set_ambientGroundColor(){} // RVA: 0x7FFAF9B96A20
        public void get_ambientIntensity(){} // RVA: 0x7FFAF9B96A70
        public void set_ambientIntensity(){} // RVA: 0x7FFAF9B96AC0
        public void get_ambientLight(){} // RVA: 0x7FFAF9B96B20
        public void set_ambientLight(){} // RVA: 0x7FFAF9B96B80
        public void get_subtractiveShadowColor(){} // RVA: 0x7FFAF9B96BD0
        public void set_subtractiveShadowColor(){} // RVA: 0x7FFAF9B96C30
        public void get_skybox(){} // RVA: 0x7FFAF9B96C80
        public void set_skybox(){} // RVA: 0x7FFAF9B96CD0
        public void get_sun(){} // RVA: 0x7FFAF9B96D20
        public void set_sun(){} // RVA: 0x7FFAF9B96D70
        public void get_ambientProbe(){} // RVA: 0x7FFAF9B96DC0
        public void set_ambientProbe(){} // RVA: 0x7FFAF9B96E40
        public void get_customReflectionTexture(){} // RVA: 0x7FFAF9B96E90
        public void set_customReflectionTexture(){} // RVA: 0x7FFAF9B96EE0
        public void get_reflectionIntensity(){} // RVA: 0x7FFAF9B96F30
        public void set_reflectionIntensity(){} // RVA: 0x7FFAF9B96F80
        public void get_reflectionBounces(){} // RVA: 0x7FFAF9B96FE0
        public void set_reflectionBounces(){} // RVA: 0x7FFAF9B97030
        public void get_defaultReflectionMode(){} // RVA: 0x7FFAF9B97080
        public void set_defaultReflectionMode(){} // RVA: 0x7FFAF9B970D0
        public void get_defaultReflectionResolution(){} // RVA: 0x7FFAF9B97120
        public void set_defaultReflectionResolution(){} // RVA: 0x7FFAF9B97170
        public void get_haloStrength(){} // RVA: 0x7FFAF9B971C0
        public void set_haloStrength(){} // RVA: 0x7FFAF9B97210
        public void get_flareStrength(){} // RVA: 0x7FFAF9B97270
        public void set_flareStrength(){} // RVA: 0x7FFAF9B972C0
        public void get_flareFadeSpeed(){} // RVA: 0x7FFAF9B97320
        public void set_flareFadeSpeed(){} // RVA: 0x7FFAF9B97370
        public void get_fogColor_Injected(){} // RVA: 0x7FFAF9B973D0
        public void set_fogColor_Injected(){} // RVA: 0x7FFAF9B97420
        public void get_ambientSkyColor_Injected(){} // RVA: 0x7FFAF9B97470
        public void set_ambientSkyColor_Injected(){} // RVA: 0x7FFAF9B974C0
        public void get_ambientEquatorColor_Injected(){} // RVA: 0x7FFAF9B97510
        public void set_ambientEquatorColor_Injected(){} // RVA: 0x7FFAF9B97560
        public void get_ambientGroundColor_Injected(){} // RVA: 0x7FFAF9B975B0
        public void set_ambientGroundColor_Injected(){} // RVA: 0x7FFAF9B97600
        public void get_ambientLight_Injected(){} // RVA: 0x7FFAF9B97650
        public void set_ambientLight_Injected(){} // RVA: 0x7FFAF9B976A0
        public void get_subtractiveShadowColor_Injected(){} // RVA: 0x7FFAF9B976F0
        public void set_subtractiveShadowColor_Injected(){} // RVA: 0x7FFAF9B97740
        public void get_ambientProbe_Injected(){} // RVA: 0x7FFAF9B97790
        public void set_ambientProbe_Injected(){} // RVA: 0x7FFAF9B977E0
    }

    public class RenderTexture
    {
        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFAF9BB8C10
        public void set_width(){} // RVA: 0x7FFAF9BB8C60
        public void get_height(){} // RVA: 0x7FFAF9BB8CC0
        public void set_height(){} // RVA: 0x7FFAF9BB8D10
        public void get_dimension(){} // RVA: 0x7FFAF9BB8D70
        public void set_dimension(){} // RVA: 0x7FFAF9BB8DC0
        public void GetColorFormat(){} // RVA: 0x7FFAF9BB8E20
        public void SetColorFormat(){} // RVA: 0x7FFAF9BB8E80
        public void get_graphicsFormat(){} // RVA: 0x7FFAF9BB8EE0
        public void set_graphicsFormat(){} // RVA: 0x7FFAF9BB8E80
        public void get_useMipMap(){} // RVA: 0x7FFAF9BB8F40
        public void set_useMipMap(){} // RVA: 0x7FFAF9BB8F90
        public void get_sRGB(){} // RVA: 0x7FFAF9BB8FF0
        public void get_vrUsage(){} // RVA: 0x7FFAF9BB9040
        public void set_vrUsage(){} // RVA: 0x7FFAF9BB9090
        public void get_memorylessMode(){} // RVA: 0x7FFAF9BB90F0
        public void set_memorylessMode(){} // RVA: 0x7FFAF9BB9140
        public void get_format(){} // RVA: 0x7FFAF9BB91A0
        public void set_format(){} // RVA: 0x7FFAF9BB9330
        public void get_stencilFormat(){} // RVA: 0x7FFAF9BB9420
        public void set_stencilFormat(){} // RVA: 0x7FFAF9BB9470
        public void get_depthStencilFormat(){} // RVA: 0x7FFAF9BB94D0
        public void set_depthStencilFormat(){} // RVA: 0x7FFAF9BB9520
        public void get_autoGenerateMips(){} // RVA: 0x7FFAF9BB9580
        public void set_autoGenerateMips(){} // RVA: 0x7FFAF9BB95D0
        public void get_volumeDepth(){} // RVA: 0x7FFAF9BB9630
        public void set_volumeDepth(){} // RVA: 0x7FFAF9BB9680
        public void get_antiAliasing(){} // RVA: 0x7FFAF9BB96E0
        public void set_antiAliasing(){} // RVA: 0x7FFAF9BB9730
        public void get_bindTextureMS(){} // RVA: 0x7FFAF9BB9790
        public void set_bindTextureMS(){} // RVA: 0x7FFAF9BB97E0
        public void get_enableRandomWrite(){} // RVA: 0x7FFAF9BB9840
        public void set_enableRandomWrite(){} // RVA: 0x7FFAF9BB9890
        public void get_useDynamicScale(){} // RVA: 0x7FFAF9BB98F0
        public void set_useDynamicScale(){} // RVA: 0x7FFAF9BB9940
        public void GetIsPowerOfTwo(){} // RVA: 0x7FFAF9BB99A0
        public void get_isPowerOfTwo(){} // RVA: 0x7FFAF9BB99A0
        public void set_isPowerOfTwo(){} // RVA: 0x7FFAF2D8D310
        public void GetActive(){} // RVA: 0x7FFAF9BB99F0
        public void SetActive(){} // RVA: 0x7FFAF9BB9A40
        public void get_active(){} // RVA: 0x7FFAF9BB99F0
        public void set_active(){} // RVA: 0x7FFAF9BB9A40
        public void GetColorBuffer(){} // RVA: 0x7FFAF9BB9A90
        public void GetDepthBuffer(){} // RVA: 0x7FFAF9BB9B00
        public void SetMipMapCount(){} // RVA: 0x7FFAF9BB9B70
        public void SetShadowSamplingMode(){} // RVA: 0x7FFAF9BB9BD0
        public void get_colorBuffer(){} // RVA: 0x7FFAF9BB9C30
        public void get_depthBuffer(){} // RVA: 0x7FFAF9BB9CB0
        public void GetNativeDepthBufferPtr(){} // RVA: 0x7FFAF9BB9D30
        public void DiscardContents(){} // RVA: 0x7FFAF9BB9E50 | overloaded x2
        public void MarkRestoreExpected(){} // RVA: 0x7FFAF9BB9E00
        public void ResolveAA(){} // RVA: 0x7FFAF9BB9EB0
        public void ResolveAATo(){} // RVA: 0x7FFAF9BB9F00
        public void ResolveAntiAliasedSurface(){} // RVA: 0x7FFAF9BB9F00 | overloaded x2
        public void SetGlobalShaderProperty(){} // RVA: 0x7FFAF9BB9F60
        public void Create(){} // RVA: 0x7FFAF9BB9FC0
        public void Release(){} // RVA: 0x7FFAF9BBA010
        public void IsCreated(){} // RVA: 0x7FFAF9BBA060
        public void GenerateMips(){} // RVA: 0x7FFAF9BBA0B0
        public void ConvertToEquirect(){} // RVA: 0x7FFAF9BBA100
        public void SetSRGBReadWrite(){} // RVA: 0x7FFAF9BBA170
        public void Internal_Create(){} // RVA: 0x7FFAF9BBA1D0
        public void SupportsStencil(){} // RVA: 0x7FFAF9BBA220
        public void SetRenderTextureDescriptor(){} // RVA: 0x7FFAF9BBA270
        public void GetDescriptor(){} // RVA: 0x7FFAF9BBA2D0
        public void GetTemporary_Internal(){} // RVA: 0x7FFAF9BBA350
        public void ReleaseTemporary(){} // RVA: 0x7FFAF9BBA3A0
        public void get_depth(){} // RVA: 0x7FFAF9BBA3F0
        public void set_depth(){} // RVA: 0x7FFAF9BBA440
        public void .ctor(){} // RVA: 0x7FFAF9BBB340 | overloaded x12
        public void Initialize(){} // RVA: 0x7FFAF9BBB410
        public void GetDepthStencilFormatLegacy(){} // RVA: 0x7FFAF9BBB740 | overloaded x4
        public void get_descriptor(){} // RVA: 0x7FFAF9BBB7D0
        public void set_descriptor(){} // RVA: 0x7FFAF9BBB880
        public void ValidateRenderTextureDesc(){} // RVA: 0x7FFAF9BBB940
        public void GetDefaultColorFormat(){} // RVA: 0x7FFAF9BBBED0
        public void GetDefaultDepthStencilFormat(){} // RVA: 0x7FFAF9BBBF40
        public void GetCompatibleFormat(){} // RVA: 0x7FFAF9BBBFB0
        public void GetTemporary(){} // RVA: 0x7FFAF9BBC950 | overloaded x14
        public void GetTemporaryImpl(){} // RVA: 0x7FFAF9BBC220
        public void get_isCubemap(){} // RVA: 0x7FFAF9BBC980
        public void set_isCubemap(){} // RVA: 0x7FFAF9BBC9B0
        public void get_isVolume(){} // RVA: 0x7FFAF9BBC9F0
        public void set_isVolume(){} // RVA: 0x7FFAF9BBCA20
        public void get_enabled(){} // RVA: 0x7FFAF4B868C0
        public void set_enabled(){} // RVA: 0x7FFAF2D8D310
        public void GetTexelOffset(){} // RVA: 0x7FFAF2DB20A0
        public void GetColorBuffer_Injected(){} // RVA: 0x7FFAF9BBCA50
        public void GetDepthBuffer_Injected(){} // RVA: 0x7FFAF9BBCAB0
        public void SetRenderTextureDescriptor_Injected(){} // RVA: 0x7FFAF9BBCB10
        public void GetDescriptor_Injected(){} // RVA: 0x7FFAF9BBCB70
        public void GetTemporary_Internal_Injected(){} // RVA: 0x7FFAF9BBCBD0
    }

    public class RenderTextureDescriptor
    {
        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFAF44189B0
        public void set_width(){} // RVA: 0x7FFAF32E3580
        public void get_height(){} // RVA: 0x7FFAF44189E0
        public void set_height(){} // RVA: 0x7FFAF44189D0
        public void get_msaaSamples(){} // RVA: 0x7FFAF4959890
        public void set_msaaSamples(){} // RVA: 0x7FFAF49598A0
        public void get_volumeDepth(){} // RVA: 0x7FFAF49598B0
        public void set_volumeDepth(){} // RVA: 0x7FFAF49598C0
        public void get_mipCount(){} // RVA: 0x7FFAF2DDA5C0
        public void set_mipCount(){} // RVA: 0x7FFAF2D900C0
        public void get_graphicsFormat(){} // RVA: 0x7FFAF5990010
        public void set_graphicsFormat(){} // RVA: 0x7FFAF9BBDF00
        public void get_depthStencilFormat(){} // RVA: 0x7FFAF442C3B0
        public void set_depthStencilFormat(){} // RVA: 0x7FFAF4439FD0
        public void get_colorFormat(){} // RVA: 0x7FFAF9BBDFC0
        public void set_colorFormat(){} // RVA: 0x7FFAF9BBE070
        public void get_sRGB(){} // RVA: 0x7FFAF9BBE140
        public void set_sRGB(){} // RVA: 0x7FFAF9BBE1D0
        public void get_depthBufferBits(){} // RVA: 0x7FFAF9BBE340
        public void set_depthBufferBits(){} // RVA: 0x7FFAF9BBE3D0
        public void get_dimension(){} // RVA: 0x7FFAF3210030
        public void set_dimension(){} // RVA: 0x7FFAF344E0D0
        public void get_shadowSamplingMode(){} // RVA: 0x7FFAF379F5B0
        public void set_shadowSamplingMode(){} // RVA: 0x7FFAF4191F00
        public void get_vrUsage(){} // RVA: 0x7FFAF3241DC0
        public void set_vrUsage(){} // RVA: 0x7FFAF3503440
        public void get_flags(){} // RVA: 0x7FFAF9B2C4F0
        public void get_memoryless(){} // RVA: 0x7FFAF2DE8CD0
        public void set_memoryless(){} // RVA: 0x7FFAF2DE8CE0
        public void .ctor(){} // RVA: 0x7FFAF9BBE8C0 | overloaded x9
        public void SetOrClearRenderTextureCreationFlag(){} // RVA: 0x7FFAF9BBE930
        public void get_useMipMap(){} // RVA: 0x7FFAF9BBE950
        public void set_useMipMap(){} // RVA: 0x7FFAF9BBE960
        public void get_autoGenerateMips(){} // RVA: 0x7FFAF9BBE980
        public void set_autoGenerateMips(){} // RVA: 0x7FFAF9BBE990
        public void get_enableRandomWrite(){} // RVA: 0x7FFAF9BBE9B0
        public void set_enableRandomWrite(){} // RVA: 0x7FFAF9BBE9C0
        public void get_bindMS(){} // RVA: 0x7FFAF9BBE9E0
        public void set_bindMS(){} // RVA: 0x7FFAF9BBE9F0
        public void set_createdFromScript(){} // RVA: 0x7FFAF9BBEA10
        public void get_useDynamicScale(){} // RVA: 0x7FFAF9BBEA30
        public void set_useDynamicScale(){} // RVA: 0x7FFAF9BBEA40
    }

    public class Renderer
    {
        public object instance;
        public object isConnected;

        // ── Methods ──
        public void get_castShadows(){} // RVA: 0x7FFAF9B93B70
        public void set_castShadows(){} // RVA: 0x7FFAF9B93BD0
        public void get_motionVectors(){} // RVA: 0x7FFAF9B93C40
        public void set_motionVectors(){} // RVA: 0x7FFAF9B93CA0
        public void get_useLightProbes(){} // RVA: 0x7FFAF9B93D10
        public void set_useLightProbes(){} // RVA: 0x7FFAF9B93D70
        public void get_bounds(){} // RVA: 0x7FFAF9B93DE0
        public void set_bounds(){} // RVA: 0x7FFAF9B93E50
        public void get_localBounds(){} // RVA: 0x7FFAF9B93EB0
        public void set_localBounds(){} // RVA: 0x7FFAF9B93F20
        public void ResetBounds(){} // RVA: 0x7FFAF9B93F80
        public void ResetLocalBounds(){} // RVA: 0x7FFAF9B93FD0
        public void SetStaticLightmapST(){} // RVA: 0x7FFAF9B94020
        public void GetMaterial(){} // RVA: 0x7FFAF9B94080
        public void GetSharedMaterial(){} // RVA: 0x7FFAF9B940D0
        public void SetMaterial(){} // RVA: 0x7FFAF9B94120
        public void GetMaterialArray(){} // RVA: 0x7FFAF9B94180
        public void CopyMaterialArray(){} // RVA: 0x7FFAF9B941D0
        public void CopySharedMaterialArray(){} // RVA: 0x7FFAF9B94230
        public void SetMaterialArray(){} // RVA: 0x7FFAF9B94300 | overloaded x2
        public void Internal_SetPropertyBlock(){} // RVA: 0x7FFAF9B94330
        public void Internal_GetPropertyBlock(){} // RVA: 0x7FFAF9B94390
        public void Internal_SetPropertyBlockMaterialIndex(){} // RVA: 0x7FFAF9B943F0
        public void Internal_GetPropertyBlockMaterialIndex(){} // RVA: 0x7FFAF9B94460
        public void HasPropertyBlock(){} // RVA: 0x7FFAF9B944D0
        public void SetPropertyBlock(){} // RVA: 0x7FFAF9B943F0 | overloaded x2
        public void GetPropertyBlock(){} // RVA: 0x7FFAF9B94460 | overloaded x2
        public void GetClosestReflectionProbesInternal(){} // RVA: 0x7FFAF9B94520
        public void get_enabled(){} // RVA: 0x7FFAF9B94580
        public void set_enabled(){} // RVA: 0x7FFAF9B945D0
        public void get_isVisible(){} // RVA: 0x7FFAF9B94630
        public void get_shadowCastingMode(){} // RVA: 0x7FFAF9B94680
        public void set_shadowCastingMode(){} // RVA: 0x7FFAF9B946D0
        public void get_receiveShadows(){} // RVA: 0x7FFAF9B94730
        public void set_receiveShadows(){} // RVA: 0x7FFAF9B94780
        public void get_forceRenderingOff(){} // RVA: 0x7FFAF9B947E0
        public void set_forceRenderingOff(){} // RVA: 0x7FFAF9B94830
        public void GetIsStaticShadowCaster(){} // RVA: 0x7FFAF9B94890
        public void SetIsStaticShadowCaster(){} // RVA: 0x7FFAF9B948E0
        public void get_staticShadowCaster(){} // RVA: 0x7FFAF9B94890
        public void set_staticShadowCaster(){} // RVA: 0x7FFAF9B948E0
        public void get_motionVectorGenerationMode(){} // RVA: 0x7FFAF9B94940
        public void set_motionVectorGenerationMode(){} // RVA: 0x7FFAF9B94990
        public void get_lightProbeUsage(){} // RVA: 0x7FFAF9B949F0
        public void set_lightProbeUsage(){} // RVA: 0x7FFAF9B94A40
        public void get_reflectionProbeUsage(){} // RVA: 0x7FFAF9B94AA0
        public void set_reflectionProbeUsage(){} // RVA: 0x7FFAF9B94AF0
        public void get_renderingLayerMask(){} // RVA: 0x7FFAF9B94B50
        public void set_renderingLayerMask(){} // RVA: 0x7FFAF9B94BA0
        public void get_rendererPriority(){} // RVA: 0x7FFAF9B94C00
        public void set_rendererPriority(){} // RVA: 0x7FFAF9B94C50
        public void get_rayTracingMode(){} // RVA: 0x7FFAF9B94CB0
        public void set_rayTracingMode(){} // RVA: 0x7FFAF9B94D00
        public void get_sortingLayerName(){} // RVA: 0x7FFAF9B94D60
        public void set_sortingLayerName(){} // RVA: 0x7FFAF9B94DB0
        public void get_sortingLayerID(){} // RVA: 0x7FFAF9B94E10
        public void set_sortingLayerID(){} // RVA: 0x7FFAF9B94E60
        public void get_sortingOrder(){} // RVA: 0x7FFAF9B94EC0
        public void set_sortingOrder(){} // RVA: 0x7FFAF9B94F10
        public void get_sortingKey(){} // RVA: 0x7FFAF9B94F70
        public void get_sortingGroupID(){} // RVA: 0x7FFAF9B94FC0
        public void set_sortingGroupID(){} // RVA: 0x7FFAF9B95010
        public void get_sortingGroupOrder(){} // RVA: 0x7FFAF9B95070
        public void set_sortingGroupOrder(){} // RVA: 0x7FFAF9B950C0
        public void get_sortingGroupKey(){} // RVA: 0x7FFAF9B95120
        public void get_allowOcclusionWhenDynamic(){} // RVA: 0x7FFAF9B95170
        public void set_allowOcclusionWhenDynamic(){} // RVA: 0x7FFAF9B951C0
        public void get_staticBatchRootTransform(){} // RVA: 0x7FFAF9B95220
        public void set_staticBatchRootTransform(){} // RVA: 0x7FFAF9B95270
        public void get_staticBatchIndex(){} // RVA: 0x7FFAF9B952D0
        public void SetStaticBatchInfo(){} // RVA: 0x7FFAF9B95320
        public void get_isPartOfStaticBatch(){} // RVA: 0x7FFAF9B95390
        public void get_worldToLocalMatrix(){} // RVA: 0x7FFAF9B953E0
        public void get_localToWorldMatrix(){} // RVA: 0x7FFAF9B95460
        public void get_lightProbeProxyVolumeOverride(){} // RVA: 0x7FFAF9B954E0
        public void set_lightProbeProxyVolumeOverride(){} // RVA: 0x7FFAF9B95530
        public void get_probeAnchor(){} // RVA: 0x7FFAF9B95590
        public void set_probeAnchor(){} // RVA: 0x7FFAF9B955E0
        public void GetLightmapIndex(){} // RVA: 0x7FFAF9B95640
        public void SetLightmapIndex(){} // RVA: 0x7FFAF9B956A0
        public void GetLightmapST(){} // RVA: 0x7FFAF9B95710
        public void SetLightmapST(){} // RVA: 0x7FFAF9B95790
        public void get_lightmapIndex(){} // RVA: 0x7FFAF9B95800
        public void set_lightmapIndex(){} // RVA: 0x7FFAF9B95860
        public void get_realtimeLightmapIndex(){} // RVA: 0x7FFAF9B958C0
        public void set_realtimeLightmapIndex(){} // RVA: 0x7FFAF9B95920
        public void get_lightmapScaleOffset(){} // RVA: 0x7FFAF9B95990
        public void set_lightmapScaleOffset(){} // RVA: 0x7FFAF9B95A10
        public void get_realtimeLightmapScaleOffset(){} // RVA: 0x7FFAF9B95A70
        public void set_realtimeLightmapScaleOffset(){} // RVA: 0x7FFAF9B95AF0
        public void GetMaterialCount(){} // RVA: 0x7FFAF9B95B60
        public void GetSharedMaterialArray(){} // RVA: 0x7FFAF9B95BB0
        public void get_materials(){} // RVA: 0x7FFAF9B94180
        public void set_materials(){} // RVA: 0x7FFAF9B94300
        public void get_material(){} // RVA: 0x7FFAF9B94080
        public void set_material(){} // RVA: 0x7FFAF9B94120
        public void get_sharedMaterial(){} // RVA: 0x7FFAF9B940D0
        public void set_sharedMaterial(){} // RVA: 0x7FFAF9B94120
        public void get_sharedMaterials(){} // RVA: 0x7FFAF9B95BB0
        public void set_sharedMaterials(){} // RVA: 0x7FFAF9B94300
        public void GetMaterials(){} // RVA: 0x7FFAF9B95C00
        public void SetSharedMaterials(){} // RVA: 0x7FFAF9B95D50
        public void SetMaterials(){} // RVA: 0x7FFAF9B95E20
        public void GetSharedMaterials(){} // RVA: 0x7FFAF9B95EF0
        public void GetClosestReflectionProbes(){} // RVA: 0x7FFAF9B94520
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_bounds_Injected(){} // RVA: 0x7FFAF9B96040
        public void set_bounds_Injected(){} // RVA: 0x7FFAF9B960A0
        public void get_localBounds_Injected(){} // RVA: 0x7FFAF9B96100
        public void set_localBounds_Injected(){} // RVA: 0x7FFAF9B96160
        public void SetStaticLightmapST_Injected(){} // RVA: 0x7FFAF9B961C0
        public void get_worldToLocalMatrix_Injected(){} // RVA: 0x7FFAF9B96220
        public void get_localToWorldMatrix_Injected(){} // RVA: 0x7FFAF9B96280
        public void GetLightmapST_Injected(){} // RVA: 0x7FFAF9B962E0
        public void SetLightmapST_Injected(){} // RVA: 0x7FFAF9B96350
    }

    public class RendererExtensions
    {
        // ── Methods ──
        public void UpdateGIMaterials(){} // RVA: 0x7FFAF9B8AE30
        public void UpdateGIMaterialsForRenderer(){} // RVA: 0x7FFAF9B8AE30
    }

    public class RequireComponent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x2
    }

    public class Resolution
    {
        public object asset;
        public object GetResult;

        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFAF92AD0D0
        public void set_width(){} // RVA: 0x7FFAF32E3580
        public void get_height(){} // RVA: 0x7FFAF6B67110
        public void set_height(){} // RVA: 0x7FFAF44189D0
        public void get_refreshRateRatio(){} // RVA: 0x7FFAF89CD510
        public void get_refreshRate(){} // RVA: 0x7FFAF9B899A0
        public void set_refreshRate(){} // RVA: 0x7FFAF9B89A20
        public void ToString(){} // RVA: 0x7FFAF9B89A30
    }

    public class ResourceRequest
    {
        // ── Methods ──
        public void GetResult(){} // RVA: 0x7FFAF9BD03F0
        public void get_asset(){} // RVA: 0x7FFAF2E41BC0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Resources
    {
        // ── Methods ──
        public void ConvertObjects(){} // RVA: 0x7FFAF2ABCE50
        public void FindObjectsOfTypeAll(){} // RVA: 0x7FFAF2ABC960 | overloaded x2
        public void Load(){} // RVA: 0x7FFAF9BD0B40 | overloaded x3
        public void LoadAsync(){} // RVA: 0x7FFAF9BD0C90 | overloaded x3
        public void GetBuiltinResource(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void UnloadAsset(){} // RVA: 0x7FFAF9BD0D70
        public void UnloadUnusedAssets(){} // RVA: 0x7FFAF9BD0DE0
    }

    public class ResourcesAPI
    {
        // ── Methods ──
        public void get_ActiveAPI(){} // RVA: 0x7FFAF9BD05C0
        public void get_overrideAPI(){} // RVA: 0x7FFAF9BD0680
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void FindObjectsOfTypeAll(){} // RVA: 0x7FFAF9BD06E0
        public void FindShaderByName(){} // RVA: 0x7FFAF9BD0730
        public void Load(){} // RVA: 0x7FFAF9BD0780
        public void LoadAsync(){} // RVA: 0x7FFAF9BD07E0
        public void UnloadAsset(){} // RVA: 0x7FFAF9BD0910
        public void .cctor(){} // RVA: 0x7FFAF9BD0960
    }

    public class ResourcesAPIInternal
    {
        // ── Methods ──
        public void FindObjectsOfTypeAll(){} // RVA: 0x7FFAF9BD0410
        public void FindShaderByName(){} // RVA: 0x7FFAF9BD0460
        public void Load(){} // RVA: 0x7FFAF9BD04B0
        public void LoadAsyncInternal(){} // RVA: 0x7FFAF9BD0510
        public void UnloadAsset(){} // RVA: 0x7FFAF9BD0570
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
        public void get_velocity(){} // RVA: 0x7FFAF9CACF20
        public void set_velocity(){} // RVA: 0x7FFAF9CACF90
        public void get_angularVelocity(){} // RVA: 0x7FFAF9CACFF0
        public void set_angularVelocity(){} // RVA: 0x7FFAF9CAD060
        public void get_drag(){} // RVA: 0x7FFAF9CAD0C0
        public void set_drag(){} // RVA: 0x7FFAF9CAD110
        public void get_angularDrag(){} // RVA: 0x7FFAF9CAD170
        public void set_angularDrag(){} // RVA: 0x7FFAF9CAD1C0
        public void get_mass(){} // RVA: 0x7FFAF9CAD220
        public void set_mass(){} // RVA: 0x7FFAF9CAD270
        public void SetDensity(){} // RVA: 0x7FFAF9CAD2D0
        public void get_useGravity(){} // RVA: 0x7FFAF9CAD330
        public void set_useGravity(){} // RVA: 0x7FFAF9CAD380
        public void get_maxDepenetrationVelocity(){} // RVA: 0x7FFAF9CAD3E0
        public void set_maxDepenetrationVelocity(){} // RVA: 0x7FFAF9CAD430
        public void get_isKinematic(){} // RVA: 0x7FFAF9CAD490
        public void set_isKinematic(){} // RVA: 0x7FFAF9CAD4E0
        public void get_freezeRotation(){} // RVA: 0x7FFAF9CAD540
        public void set_freezeRotation(){} // RVA: 0x7FFAF9CAD590
        public void get_constraints(){} // RVA: 0x7FFAF9CAD5F0
        public void set_constraints(){} // RVA: 0x7FFAF9CAD640
        public void get_collisionDetectionMode(){} // RVA: 0x7FFAF9CAD6A0
        public void set_collisionDetectionMode(){} // RVA: 0x7FFAF9CAD6F0
        public void get_automaticCenterOfMass(){} // RVA: 0x7FFAF9CAD750
        public void set_automaticCenterOfMass(){} // RVA: 0x7FFAF9CAD7A0
        public void get_centerOfMass(){} // RVA: 0x7FFAF9CAD800
        public void set_centerOfMass(){} // RVA: 0x7FFAF9CAD870
        public void get_worldCenterOfMass(){} // RVA: 0x7FFAF9CAD8D0
        public void get_automaticInertiaTensor(){} // RVA: 0x7FFAF9CAD940
        public void set_automaticInertiaTensor(){} // RVA: 0x7FFAF9CAD990
        public void get_inertiaTensorRotation(){} // RVA: 0x7FFAF9CAD9F0
        public void set_inertiaTensorRotation(){} // RVA: 0x7FFAF9CADA60
        public void get_inertiaTensor(){} // RVA: 0x7FFAF9CADAC0
        public void set_inertiaTensor(){} // RVA: 0x7FFAF9CADB30
        public void get_detectCollisions(){} // RVA: 0x7FFAF9CADB90
        public void set_detectCollisions(){} // RVA: 0x7FFAF9CADBE0
        public void get_position(){} // RVA: 0x7FFAF9CADC40
        public void set_position(){} // RVA: 0x7FFAF9CADCB0
        public void get_rotation(){} // RVA: 0x7FFAF9CADD10
        public void set_rotation(){} // RVA: 0x7FFAF9CADD80
        public void get_interpolation(){} // RVA: 0x7FFAF9CADDE0
        public void set_interpolation(){} // RVA: 0x7FFAF9CADE30
        public void get_solverIterations(){} // RVA: 0x7FFAF9CADE90
        public void set_solverIterations(){} // RVA: 0x7FFAF9CADEE0
        public void get_sleepThreshold(){} // RVA: 0x7FFAF9CADF40
        public void set_sleepThreshold(){} // RVA: 0x7FFAF9CADF90
        public void get_maxAngularVelocity(){} // RVA: 0x7FFAF9CADFF0
        public void set_maxAngularVelocity(){} // RVA: 0x7FFAF9CAE040
        public void get_maxLinearVelocity(){} // RVA: 0x7FFAF9CAE0A0
        public void set_maxLinearVelocity(){} // RVA: 0x7FFAF9CAE0F0
        public void MovePosition(){} // RVA: 0x7FFAF9CAE150
        public void MoveRotation(){} // RVA: 0x7FFAF9CAE1B0
        public void Move(){} // RVA: 0x7FFAF9CAE210
        public void Sleep(){} // RVA: 0x7FFAF9CAE280
        public void IsSleeping(){} // RVA: 0x7FFAF9CAE2D0
        public void WakeUp(){} // RVA: 0x7FFAF9CAE320
        public void ResetCenterOfMass(){} // RVA: 0x7FFAF9CAE370
        public void ResetInertiaTensor(){} // RVA: 0x7FFAF9CAE3C0
        public void GetRelativePointVelocity(){} // RVA: 0x7FFAF9CAE410
        public void GetPointVelocity(){} // RVA: 0x7FFAF9CAE490
        public void get_solverVelocityIterations(){} // RVA: 0x7FFAF9CAE510
        public void set_solverVelocityIterations(){} // RVA: 0x7FFAF9CAE560
        public void get_excludeLayers(){} // RVA: 0x7FFAF9CAE5C0
        public void set_excludeLayers(){} // RVA: 0x7FFAF9CAE620
        public void get_includeLayers(){} // RVA: 0x7FFAF9CAE680
        public void set_includeLayers(){} // RVA: 0x7FFAF9CAE6E0
        public void GetAccumulatedForce(){} // RVA: 0x7FFAF9CAE7C0 | overloaded x2
        public void GetAccumulatedTorque(){} // RVA: 0x7FFAF9CAE920 | overloaded x2
        public void AddForce(){} // RVA: 0x7FFAF9CAEB50 | overloaded x4
        public void AddRelativeForce(){} // RVA: 0x7FFAF9CAED10 | overloaded x4
        public void AddTorque(){} // RVA: 0x7FFAF9CAEED0 | overloaded x4
        public void AddRelativeTorque(){} // RVA: 0x7FFAF9CAF090 | overloaded x4
        public void AddForceAtPosition(){} // RVA: 0x7FFAF9CAF180 | overloaded x2
        public void AddExplosionForce(){} // RVA: 0x7FFAF9CAF340 | overloaded x3
        public void Internal_ClosestPointOnBounds(){} // RVA: 0x7FFAF9CAF3E0
        public void ClosestPointOnBounds(){} // RVA: 0x7FFAF9CAF460
        public void SweepTest(){} // RVA: 0x7FFAF9CAF780 | overloaded x4
        public void Internal_SweepTestAll(){} // RVA: 0x7FFAF9CAF7C0
        public void SweepTestAll(){} // RVA: 0x7FFAF9CAF970 | overloaded x3
        public void get_sleepVelocity(){} // RVA: 0x7FFAF9BA2A70
        public void set_sleepVelocity(){} // RVA: 0x7FFAF2D8D310
        public void get_sleepAngularVelocity(){} // RVA: 0x7FFAF9BA2A70
        public void set_sleepAngularVelocity(){} // RVA: 0x7FFAF2D8D310
        public void SetMaxAngularVelocity(){} // RVA: 0x7FFAF9CAE040
        public void get_useConeFriction(){} // RVA: 0x7FFAF52194F0
        public void set_useConeFriction(){} // RVA: 0x7FFAF2D8D310
        public void get_solverIterationCount(){} // RVA: 0x7FFAF9CADE90
        public void set_solverIterationCount(){} // RVA: 0x7FFAF9CADEE0
        public void get_solverVelocityIterationCount(){} // RVA: 0x7FFAF9CAE510
        public void set_solverVelocityIterationCount(){} // RVA: 0x7FFAF9CAE560
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_velocity_Injected(){} // RVA: 0x7FFAF9CAF9B0
        public void set_velocity_Injected(){} // RVA: 0x7FFAF9CAFA10
        public void get_angularVelocity_Injected(){} // RVA: 0x7FFAF9CAFA70
        public void set_angularVelocity_Injected(){} // RVA: 0x7FFAF9CAFAD0
        public void get_centerOfMass_Injected(){} // RVA: 0x7FFAF9CAFB30
        public void set_centerOfMass_Injected(){} // RVA: 0x7FFAF9CAFB90
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x7FFAF9CAFBF0
        public void get_inertiaTensorRotation_Injected(){} // RVA: 0x7FFAF9CAFC50
        public void set_inertiaTensorRotation_Injected(){} // RVA: 0x7FFAF9CAFCB0
        public void get_inertiaTensor_Injected(){} // RVA: 0x7FFAF9CAFD10
        public void set_inertiaTensor_Injected(){} // RVA: 0x7FFAF9CAFD70
        public void get_position_Injected(){} // RVA: 0x7FFAF9CAFDD0
        public void set_position_Injected(){} // RVA: 0x7FFAF9CAFE30
        public void get_rotation_Injected(){} // RVA: 0x7FFAF9CAFE90
        public void set_rotation_Injected(){} // RVA: 0x7FFAF9CAFEF0
        public void MovePosition_Injected(){} // RVA: 0x7FFAF9CAFF50
        public void MoveRotation_Injected(){} // RVA: 0x7FFAF9CAFFB0
        public void Move_Injected(){} // RVA: 0x7FFAF9CB0010
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x7FFAF9CB0080
        public void GetPointVelocity_Injected(){} // RVA: 0x7FFAF9CB00F0
        public void get_excludeLayers_Injected(){} // RVA: 0x7FFAF9CB0160
        public void set_excludeLayers_Injected(){} // RVA: 0x7FFAF9CB01C0
        public void get_includeLayers_Injected(){} // RVA: 0x7FFAF9CB0220
        public void set_includeLayers_Injected(){} // RVA: 0x7FFAF9CB0280
        public void GetAccumulatedForce_Injected(){} // RVA: 0x7FFAF9CB02E0
        public void GetAccumulatedTorque_Injected(){} // RVA: 0x7FFAF9CB0350
        public void AddForce_Injected(){} // RVA: 0x7FFAF9CB03C0
        public void AddRelativeForce_Injected(){} // RVA: 0x7FFAF9CB0430
        public void AddTorque_Injected(){} // RVA: 0x7FFAF9CB04A0
        public void AddRelativeTorque_Injected(){} // RVA: 0x7FFAF9CB0510
        public void AddForceAtPosition_Injected(){} // RVA: 0x7FFAF9CB0580
        public void AddExplosionForce_Injected(){} // RVA: 0x7FFAF9CB0600
        public void Internal_ClosestPointOnBounds_Injected(){} // RVA: 0x7FFAF9CB0690
        public void SweepTest_Injected(){} // RVA: 0x7FFAF9CB0710
        public void Internal_SweepTestAll_Injected(){} // RVA: 0x7FFAF9CB07A0
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
        public void get_position(){} // RVA: 0x7FFAF9C91E10
        public void set_position(){} // RVA: 0x7FFAF9C91E70
        public void get_rotation(){} // RVA: 0x7FFAF9C91ED0
        public void set_rotation(){} // RVA: 0x7FFAF9C91F20
        public void SetRotation(){} // RVA: 0x7FFAF9C91FE0 | overloaded x2
        public void SetRotation_Angle(){} // RVA: 0x7FFAF9C91F80
        public void SetRotation_Quaternion(){} // RVA: 0x7FFAF9C92040
        public void MovePosition(){} // RVA: 0x7FFAF9C920A0
        public void MoveRotation(){} // RVA: 0x7FFAF9C92160 | overloaded x2
        public void MoveRotation_Angle(){} // RVA: 0x7FFAF9C92100
        public void MoveRotation_Quaternion(){} // RVA: 0x7FFAF9C921C0
        public void get_velocity(){} // RVA: 0x7FFAF9C92220
        public void set_velocity(){} // RVA: 0x7FFAF9C92280
        public void get_angularVelocity(){} // RVA: 0x7FFAF9C922E0
        public void set_angularVelocity(){} // RVA: 0x7FFAF9C92330
        public void get_useAutoMass(){} // RVA: 0x7FFAF9C92390
        public void set_useAutoMass(){} // RVA: 0x7FFAF9C923E0
        public void get_mass(){} // RVA: 0x7FFAF9C92440
        public void set_mass(){} // RVA: 0x7FFAF9C92490
        public void get_sharedMaterial(){} // RVA: 0x7FFAF9C924F0
        public void set_sharedMaterial(){} // RVA: 0x7FFAF9C92540
        public void get_centerOfMass(){} // RVA: 0x7FFAF9C925A0
        public void set_centerOfMass(){} // RVA: 0x7FFAF9C92600
        public void get_worldCenterOfMass(){} // RVA: 0x7FFAF9C92660
        public void get_inertia(){} // RVA: 0x7FFAF9C926C0
        public void set_inertia(){} // RVA: 0x7FFAF9C92710
        public void get_drag(){} // RVA: 0x7FFAF9C92770
        public void set_drag(){} // RVA: 0x7FFAF9C927C0
        public void get_angularDrag(){} // RVA: 0x7FFAF9C92820
        public void set_angularDrag(){} // RVA: 0x7FFAF9C92870
        public void get_gravityScale(){} // RVA: 0x7FFAF9C928D0
        public void set_gravityScale(){} // RVA: 0x7FFAF9C92920
        public void get_bodyType(){} // RVA: 0x7FFAF9C92980
        public void set_bodyType(){} // RVA: 0x7FFAF9C929D0
        public void get_useFullKinematicContacts(){} // RVA: 0x7FFAF9C92A30
        public void set_useFullKinematicContacts(){} // RVA: 0x7FFAF9C92A80
        public void get_isKinematic(){} // RVA: 0x7FFAF9C92AE0
        public void set_isKinematic(){} // RVA: 0x7FFAF9C92B40
        public void get_freezeRotation(){} // RVA: 0x7FFAF9C92BB0
        public void set_freezeRotation(){} // RVA: 0x7FFAF9C92C00
        public void get_constraints(){} // RVA: 0x7FFAF9C92C60
        public void set_constraints(){} // RVA: 0x7FFAF9C92CB0
        public void IsSleeping(){} // RVA: 0x7FFAF9C92D10
        public void IsAwake(){} // RVA: 0x7FFAF9C92D60
        public void Sleep(){} // RVA: 0x7FFAF9C92DB0
        public void WakeUp(){} // RVA: 0x7FFAF9C92E00
        public void get_simulated(){} // RVA: 0x7FFAF9C92E50
        public void set_simulated(){} // RVA: 0x7FFAF9C92EA0
        public void get_interpolation(){} // RVA: 0x7FFAF9C92F00
        public void set_interpolation(){} // RVA: 0x7FFAF9C92F50
        public void get_sleepMode(){} // RVA: 0x7FFAF9C92FB0
        public void set_sleepMode(){} // RVA: 0x7FFAF9C93000
        public void get_collisionDetectionMode(){} // RVA: 0x7FFAF9C93060
        public void set_collisionDetectionMode(){} // RVA: 0x7FFAF9C930B0
        public void get_attachedColliderCount(){} // RVA: 0x7FFAF9C93110
        public void get_totalForce(){} // RVA: 0x7FFAF9C93160
        public void set_totalForce(){} // RVA: 0x7FFAF9C931C0
        public void get_totalTorque(){} // RVA: 0x7FFAF9C93220
        public void set_totalTorque(){} // RVA: 0x7FFAF9C93270
        public void get_excludeLayers(){} // RVA: 0x7FFAF9C932D0
        public void set_excludeLayers(){} // RVA: 0x7FFAF9C93330
        public void get_includeLayers(){} // RVA: 0x7FFAF9C93390
        public void set_includeLayers(){} // RVA: 0x7FFAF9C933F0
        public void IsTouching(){} // RVA: 0x7FFAF9C935A0 | overloaded x3
        public void IsTouching_OtherColliderWithFilter_Internal(){} // RVA: 0x7FFAF9C93530
        public void IsTouching_AnyColliderWithFilter_Internal(){} // RVA: 0x7FFAF9C93610
        public void IsTouchingLayers(){} // RVA: 0x7FFAF9C936D0 | overloaded x2
        public void OverlapPoint(){} // RVA: 0x7FFAF9C93730
        public void Distance(){} // RVA: 0x7FFAF9C93790
        public void Distance_Internal(){} // RVA: 0x7FFAF9C93AB0
        public void ClosestPoint(){} // RVA: 0x7FFAF9C93B30
        public void AddForce(){} // RVA: 0x7FFAF9C93C00 | overloaded x2
        public void AddRelativeForce(){} // RVA: 0x7FFAF9C93CD0 | overloaded x2
        public void AddForceAtPosition(){} // RVA: 0x7FFAF9C93DB0 | overloaded x2
        public void AddTorque(){} // RVA: 0x7FFAF9C93EA0 | overloaded x2
        public void GetPoint(){} // RVA: 0x7FFAF9C93F10
        public void GetRelativePoint(){} // RVA: 0x7FFAF9C93F80
        public void GetVector(){} // RVA: 0x7FFAF9C93FF0
        public void GetRelativeVector(){} // RVA: 0x7FFAF9C94060
        public void GetPointVelocity(){} // RVA: 0x7FFAF9C940D0
        public void GetRelativePointVelocity(){} // RVA: 0x7FFAF9C94140
        public void OverlapCollider(){} // RVA: 0x7FFAF9C942A0 | overloaded x2
        public void OverlapColliderArray_Internal(){} // RVA: 0x7FFAF9C94230
        public void OverlapColliderList_Internal(){} // RVA: 0x7FFAF9C94320
        public void GetContacts(){} // RVA: 0x7FFAF9C94840 | overloaded x8
        public void GetAttachedColliders(){} // RVA: 0x7FFAF9C94930 | overloaded x2
        public void GetAttachedCollidersArray_Internal(){} // RVA: 0x7FFAF9C948D0
        public void GetAttachedCollidersList_Internal(){} // RVA: 0x7FFAF9C94930
        public void Cast(){} // RVA: 0x7FFAF9C94D30 | overloaded x6
        public void CastArray_Internal(){} // RVA: 0x7FFAF9C949E0
        public void CastList_Internal(){} // RVA: 0x7FFAF9C94AE0
        public void CastFilteredArray_Internal(){} // RVA: 0x7FFAF9C94CA0
        public void CastFilteredList_Internal(){} // RVA: 0x7FFAF9C94DD0
        public void GetShapes(){} // RVA: 0x7FFAF9C94E60
        public void GetShapes_Internal(){} // RVA: 0x7FFAF9C94ED0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_position_Injected(){} // RVA: 0x7FFAF9C94F30
        public void set_position_Injected(){} // RVA: 0x7FFAF9C94F90
        public void SetRotation_Quaternion_Injected(){} // RVA: 0x7FFAF9C94FF0
        public void MovePosition_Injected(){} // RVA: 0x7FFAF9C95050
        public void MoveRotation_Quaternion_Injected(){} // RVA: 0x7FFAF9C950B0
        public void get_velocity_Injected(){} // RVA: 0x7FFAF9C95110
        public void set_velocity_Injected(){} // RVA: 0x7FFAF9C95170
        public void get_centerOfMass_Injected(){} // RVA: 0x7FFAF9C951D0
        public void set_centerOfMass_Injected(){} // RVA: 0x7FFAF9C95230
        public void get_worldCenterOfMass_Injected(){} // RVA: 0x7FFAF9C95290
        public void get_totalForce_Injected(){} // RVA: 0x7FFAF9C952F0
        public void set_totalForce_Injected(){} // RVA: 0x7FFAF9C95350
        public void get_excludeLayers_Injected(){} // RVA: 0x7FFAF9C953B0
        public void set_excludeLayers_Injected(){} // RVA: 0x7FFAF9C95410
        public void get_includeLayers_Injected(){} // RVA: 0x7FFAF9C95470
        public void set_includeLayers_Injected(){} // RVA: 0x7FFAF9C954D0
        public void IsTouching_OtherColliderWithFilter_Internal_Injected(){} // RVA: 0x7FFAF9C95530
        public void IsTouching_AnyColliderWithFilter_Internal_Injected(){} // RVA: 0x7FFAF9C955A0
        public void OverlapPoint_Injected(){} // RVA: 0x7FFAF9C95600
        public void Distance_Internal_Injected(){} // RVA: 0x7FFAF9C95660
        public void AddForce_Injected(){} // RVA: 0x7FFAF9C956D0
        public void AddRelativeForce_Injected(){} // RVA: 0x7FFAF9C95740
        public void AddForceAtPosition_Injected(){} // RVA: 0x7FFAF9C957B0
        public void GetPoint_Injected(){} // RVA: 0x7FFAF9C95830
        public void GetRelativePoint_Injected(){} // RVA: 0x7FFAF9C958A0
        public void GetVector_Injected(){} // RVA: 0x7FFAF9C95910
        public void GetRelativeVector_Injected(){} // RVA: 0x7FFAF9C95980
        public void GetPointVelocity_Injected(){} // RVA: 0x7FFAF9C959F0
        public void GetRelativePointVelocity_Injected(){} // RVA: 0x7FFAF9C95A60
        public void OverlapColliderArray_Internal_Injected(){} // RVA: 0x7FFAF9C95AD0
        public void OverlapColliderList_Internal_Injected(){} // RVA: 0x7FFAF9C95B40
        public void CastArray_Internal_Injected(){} // RVA: 0x7FFAF9C95BB0
        public void CastList_Internal_Injected(){} // RVA: 0x7FFAF9C95C30
        public void CastFilteredArray_Internal_Injected(){} // RVA: 0x7FFAF9C95CB0
        public void CastFilteredList_Internal_Injected(){} // RVA: 0x7FFAF9C95D40
    }

    public class RuntimeAnimatorController
    {
        public object runtimeAnimatorController;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B4A690
        public void get_animationClips(){} // RVA: 0x7FFAF9B4A6E0
    }

    public class RuntimeInitializeOnLoadMethodAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0 | overloaded x2
        public void set_loadType(){} // RVA: 0x7FFAF2D900C0
    }

}