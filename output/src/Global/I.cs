// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 397

public class IActivationFactory
{
    // ── Methods ──
    public void ActivateInstance(){} // RVA: 0x7FFAF2ABCD60
}

public class IAllocator
{
    // ── Methods ──
    public void Try(){} // RVA: 0x7FFAF2AC2590
    public void get_Handle(){} // RVA: 0x7FFAF2D33FA0
}

public class IAttrList
{
    // ── Methods ──
    public void get_Length(){} // RVA: 0x7FFAF2ABD840
    public void GetName(){} // RVA: 0x7FFAF2ACBCC0
    public void GetValue(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
    public void get_Names(){} // RVA: 0x7FFAF2ABCD60
    public void get_Values(){} // RVA: 0x7FFAF2ABCD60
}

public class IConstraintSubstituteCreator
{
    // ── Methods ──
    public void CreateSubstituteComponent(){} // RVA: 0x7FFAF2D33FA0
}

public class IContentHandler
{
    // ── Methods ──
    public void OnStartParsing(){} // RVA: 0x7FFAF2AD4B10
    public void OnEndParsing(){} // RVA: 0x7FFAF2AD4B10
    public void OnStartElement(){} // RVA: 0x7FFAF2ADDC60
    public void OnEndElement(){} // RVA: 0x7FFAF2AD4B10
    public void OnProcessingInstruction(){} // RVA: 0x7FFAF2ADDC60
    public void OnChars(){} // RVA: 0x7FFAF2AD4B10
    public void OnIgnorableWhitespace(){} // RVA: 0x7FFAF2AD4B10
}

public class IEncryption
{
    // ── Methods ──
    public void Encrypt(){} // RVA: 0x7FFAF2ACE6A0
    public void TryDecrypt(){}
}

public class IExtensionReflectionHelper
{
    // ── Methods ──
    public void GetExtension(){} // RVA: 0x7FFAF2ABCE10
    public void SetExtension(){} // RVA: 0x7FFAF2ADDC60
    public void HasExtension(){} // RVA: 0x7FFAF2ABDE40
    public void ClearExtension(){} // RVA: 0x7FFAF2AD4B10
}

public class IFactoryControls
{
    // ── Methods ──
    public void CreateGameObject(){} // RVA: 0x7FFAF2ACE6A0
}

public class IInput
{
    // ── Methods ──
    public void GetButtonDown(){} // RVA: 0x7FFAF2ABDE40
    public void GetAxisRaw(){} // RVA: 0x7FFAF2AD1FA0
    public void ClearLastPenContactEvent(){} // RVA: 0x7FFAF2AD4A50
    public void GetLastPenContactEvent(){}
    public void get_touchCount(){} // RVA: 0x7FFAF2ABD840
    public void GetTouch(){}
    public void get_mousePresent(){} // RVA: 0x7FFAF2ABDBE0
    public void GetMouseButtonDown(){} // RVA: 0x7FFAF2ABE1F0
    public void GetMouseButtonUp(){} // RVA: 0x7FFAF2ABE1F0
    public void get_mousePosition(){} // RVA: 0x7FFAF2ABC770
    public void get_mouseButtonCount(){} // RVA: 0x7FFAF2ABD840
    public void get_anyKey(){} // RVA: 0x7FFAF2ABDBE0
    public void get_unscaledTime(){} // RVA: 0x7FFAF2AD1890
    public void get_doubleClickTime(){} // RVA: 0x7FFAF2AD1890
}

public class IInputAxisProvider
{
    // ── Methods ──
    public void GetAxisValue(){} // RVA: 0x7FFAF2AD1C40
}

public class IJobSortable
{
    // ── Methods ──
    public void get_SortingBaseTransform(){} // RVA: 0x7FFAF2ABCD60
    public void get_MaximumExecutionGroups(){} // RVA: 0x7FFAF2ABD840
    public void GetKnownDependencies(){} // RVA: 0x7FFAF2AD4B10
    public void get_ExecutionGroup(){} // RVA: 0x7FFAF2ABD840
    public void set_ExecutionGroup(){} // RVA: 0x7FFAF2AD4FA0
}

public class IKBone
{
}

public class ILEmitResolverBuilderRuntimeContext
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF2D8D310
}

public class IListWrapper
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF88B6410
    public void set_Capacity(){} // RVA: 0x7FFAF88B6490
    public void get_Count(){} // RVA: 0x7FFAF88B6520
    public void get_IsReadOnly(){} // RVA: 0x7FFAF88B6570
    public void get_IsFixedSize(){} // RVA: 0x7FFAF88B65C0
    public void get_IsSynchronized(){} // RVA: 0x7FFAF88B6610
    public void get_Item(){} // RVA: 0x7FFAF88B6660
    public void set_Item(){} // RVA: 0x7FFAF88B66C0
    public void get_SyncRoot(){} // RVA: 0x7FFAF88B6740
    public void Add(){} // RVA: 0x7FFAF88B6790
    public void AddRange(){} // RVA: 0x7FFAF88B6800
    public void Clear(){} // RVA: 0x7FFAF88B6850
    public void Clone(){} // RVA: 0x7FFAF88B6910
    public void Contains(){} // RVA: 0x7FFAF88B6970
    public void CopyTo(){} // RVA: 0x7FFAF88B6A40 | overloaded x2
    public void GetEnumerator(){} // RVA: 0x7FFAF88B6D70
    public void IndexOf(){} // RVA: 0x7FFAF88B6DC0
    public void Insert(){} // RVA: 0x7FFAF88B6E20
    public void InsertRange(){} // RVA: 0x7FFAF88B6EA0
    public void Remove(){} // RVA: 0x7FFAF88B5BE0
    public void RemoveAt(){} // RVA: 0x7FFAF88B7220
    public void RemoveRange(){} // RVA: 0x7FFAF88B7290
    public void Reverse(){} // RVA: 0x7FFAF88B7490
    public void Sort(){} // RVA: 0x7FFAF88B7870
    public void ToArray(){} // RVA: 0x7FFAF88B7BF0 | overloaded x2
}

public class IMDrawBuffer`1
{
    // ── Methods ──
    public void get_UseStructuredBuffers(){} // RVA: 0x7FFAF2ABDC10
    public void set_UseStructuredBuffers(){} // RVA: 0x7FFAF2AD4F20
    public void Init(){} // RVA: 0x7FFAF2AD6EE0
    public void Dispose(){} // RVA: 0x7FFAF2AD4A50
    public void Clear(){} // RVA: 0x7FFAF2AD4A50
    public void Draw(){} // RVA: 0x7FFAF2AD4A50
    public void DrawFallback(){} // RVA: 0x7FFAF2AD4A50
    public void BuildFallbackCommandBuffer(){} // RVA: 0x7FFAF2AD4B10
    public void UpdateCommandBuffers(){} // RVA: 0x7FFAF2AD4A50
    public void UpdateInstanceData(){} // RVA: 0x7FFAF2AD4A50
    public void BuildCommandBuffer(){} // RVA: 0x7FFAF2AD4B10
    public void Add(){} // RVA: 0x7FFAF2D33FA0
    public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    public void .cctor(){} // RVA: 0x7FFAF2AD4A80
}

public class IMDrawBuffer`1
{
    // ── Methods ──
    public void get_UseStructuredBuffers(){} // RVA: 0x7FFAF5FD50B0
    public void set_UseStructuredBuffers(){} // RVA: 0x7FFAF5FD5150
    public void Init(){} // RVA: 0x7FFAF5FD6290
    public void Dispose(){} // RVA: 0x7FFAF5FD6C50
    public void Clear(){} // RVA: 0x7FFAF41D4E10
    public void Draw(){} // RVA: 0x7FFAF5FD6CC0
    public void DrawFallback(){} // RVA: 0x7FFAF2AD4A50
    public void BuildFallbackCommandBuffer(){} // RVA: 0x7FFAF2AD4B10
    public void UpdateCommandBuffers(){} // RVA: 0x7FFAF5FD6DE0
    public void UpdateInstanceData(){} // RVA: 0x7FFAF5FD7010
    public void BuildCommandBuffer(){} // RVA: 0x7FFAF5FD7230
    public void Add(){} // RVA: 0x7FFAF5FD7370
    public void .ctor(){} // RVA: 0x7FFAF2D8D310
    public void .cctor(){} // RVA: 0x7FFAF5FD73B0
}

public class IMDrawBuffer`1
{
    // ── Methods ──
    public void get_UseStructuredBuffers(){} // RVA: 0x7FFAF5FD50B0
    public void set_UseStructuredBuffers(){} // RVA: 0x7FFAF5FD5150
    public void Init(){} // RVA: 0x7FFAF5FD7470
    public void Dispose(){} // RVA: 0x7FFAF5FD6C50
    public void Clear(){} // RVA: 0x7FFAF41D4E10
    public void Draw(){} // RVA: 0x7FFAF5FD7E40
    public void DrawFallback(){} // RVA: 0x7FFAF2AD4A50
    public void BuildFallbackCommandBuffer(){} // RVA: 0x7FFAF2AD4B10
    public void UpdateCommandBuffers(){} // RVA: 0x7FFAF5FD7F60
    public void UpdateInstanceData(){} // RVA: 0x7FFAF5FD8190
    public void BuildCommandBuffer(){} // RVA: 0x7FFAF5FD83B0
    public void Add(){} // RVA: 0x7FFAF5FD84F0
    public void .ctor(){} // RVA: 0x7FFAF2D8D310
    public void .cctor(){} // RVA: 0x7FFAF5FD8540
}

public class IMDrawLine
{
    // ── Methods ──
    public void Add(){} // RVA: 0x7FFAFA17DF10
    public void SetLineProperties(){} // RVA: 0x7FFAFA17E040
    public void DrawFallback(){} // RVA: 0x7FFAFA17E380
    public void BuildFallbackCommandBuffer(){} // RVA: 0x7FFAFA17E530
    public void .ctor(){} // RVA: 0x7FFAFA17E650
    public void .cctor(){} // RVA: 0x7FFAFA17E6B0
}

public class IMDrawShape
{
    // ── Methods ──
    public void Add(){} // RVA: 0x7FFAFA17E900
    public void DrawFallback(){} // RVA: 0x7FFAFA17EAB0
    public void BuildFallbackCommandBuffer(){} // RVA: 0x7FFAFA17ED40
    public void .ctor(){} // RVA: 0x7FFAFA17EF50
    public void .cctor(){} // RVA: 0x7FFAFA17EFB0
}

public class IMGUISendQueuedEvents
{
}

public class IOVRMeshDataProvider
{
    // ── Methods ──
    public void GetMeshType(){} // RVA: 0x7FFAF2ABD840
}

public class IOVRMeshRendererDataProvider
{
    // ── Methods ──
    public void GetMeshRendererData(){}
}

public class IOVRSceneComponent
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFAF2AD4A50
}

public class IOVRSkeletonDataProvider
{
    // ── Methods ──
    public void GetSkeletonType(){} // RVA: 0x7FFAF2ABD840
    public void GetSkeletonPoseData(){}
    public void get_enabled(){} // RVA: 0x7FFAF2ABDBE0
}

public class IOVRSkeletonRendererDataProvider
{
    // ── Methods ──
    public void GetSkeletonRendererData(){}
}

public class IO_STATUS
{
}

public class IO_STATUS_BLOCK
{
}

public class IPLGainNudgeData
{
}

public class IPSQuery
{
    // ── Methods ──
    public void get_require(){} // RVA: 0x7FFAF2E08D50
    public void set_require(){} // RVA: 0x7FFAF2E08D60
    public void get_include(){} // RVA: 0x7FFAF2E55590
    public void set_include(){} // RVA: 0x7FFAF2E555A0
    public void .ctor(){} // RVA: 0x7FFAFC325FD0
}

public class IPV4
{
}

public class IPlayerActions
{
    // ── Methods ──
    public void OnMove(){}
    public void OnLook(){}
    public void OnFire(){}
}

public class IReflectionHelper
{
    // ── Methods ──
    public void CreateFuncIMessageInt32(){} // RVA: 0x7FFAF2ABCE10
    public void CreateActionIMessage(){} // RVA: 0x7FFAF2ABCE10
    public void CreateFuncIMessageObject(){} // RVA: 0x7FFAF2ABCE10
    public void CreateActionIMessageObject(){} // RVA: 0x7FFAF2ABCE10
    public void CreateFuncIMessageBool(){} // RVA: 0x7FFAF2ABCE10
}

public class ISealedAllowReference
{
}

public class ITokenReader
{
    // ── Methods ──
    public void Read(){} // RVA: 0x7FFAF2ABD840
}

public class ITypeConstructor
{
    // ── Methods ──
    public void get_CanBeInstantiated(){} // RVA: 0x7FFAF2ABDBE0
    public void Instantiate(){} // RVA: 0x7FFAF2ABCD60
}

public class ITypeConstructor`1
{
    // ── Methods ──
    public void Instantiate(){} // RVA: 0x7FFAF2D33FA0
    public void SetExplicitConstructor(){} // RVA: 0x7FFAF2AD4B10
}

public class ITypeConstructor`1
{
}

public class IUIActions
{
    // ── Methods ──
    public void OnNavigate(){}
    public void OnSubmit(){}
    public void OnCancel(){}
    public void OnPoint(){}
    public void OnClick(){}
    public void OnScrollWheel(){}
    public void OnMiddleClick(){}
    public void OnRightClick(){}
    public void OnTrackedDevicePosition(){}
    public void OnTrackedDeviceOrientation(){}
}

public class IUIGroupItemDatasource
{
    // ── Methods ──
    public void get_name(){} // RVA: 0x7FFAF2ABCD60
}

public class IUnimplemented
{
}

public class IVisualPredicateWrapper
{
    // ── Methods ──
    public void Predicate(){} // RVA: 0x7FFAF2ABDE40
}

public class IWebSocketReceiveResultGetter`1
{
    // ── Methods ──
    public void GetResult(){} // RVA: 0x7FFAF2D33FA0
}

public class IWebSocketReceiveResultGetter`1
{
}

public class Icons
{
}

public class Icons
{
    // ── Methods ──
    public void .ctor_97D11E5DD8F5(){} // RVA: 0x7FFAF37C3810
    public void Initialize(){} // RVA: 0x7FFAF37C3930
    public void Equals(){} // RVA: 0x7FFAF37C3930
    public void op_Implicit(){} // RVA: 0x7FFAF37C3810
    public void CompareBaseObjects(){} // RVA: 0x7FFAF37C3A50
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAF37C3810
    public void GetCachedPtr(){} // RVA: 0x7FFAF37C3B70
    public void .ctor(){} // RVA: 0x7FFAF2D8D310
}

public class Icons
{
}

public class Icons
{
}

public class Icons
{
}

public class IdManager
{
    // ── Methods ──
    public void GetId(){} // RVA: 0x7FFAF2ABD840
    public void ReturnId(){} // RVA: 0x7FFAF2AD4FA0
    public void .ctor(){} // RVA: 0x7FFAF2AD4A50
}

public class IdManager
{
    // ── Methods ──
    public void GetId(){} // RVA: 0x7FFAF6001FB0
    public void ReturnId(){} // RVA: 0x7FFAF6002220
    public void .ctor(){} // RVA: 0x7FFAF60023D0
}

public class IdentityTokenChanged
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF2DE8B80
    public void Invoke(){} // RVA: 0x7FFAF2DE8C60
}

public class IgnoreDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF45EC7C0
    public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    public void BeginInvoke(){} // RVA: 0x7FFAF2DE8C70
    public void EndInvoke(){} // RVA: 0x7FFAF45EC940
}

public class IgnoresCaseHashtable
{
    // ── Methods ──
    public void Clear(){} // RVA: 0x7FFAFC366650
    public void GetEnumerator(){} // RVA: 0x7FFAFC3666C0
    public void get_Keys(){} // RVA: 0x7FFAFC366710
    public void Remove(){} // RVA: 0x7FFAFC366760
    public void get_Item(){} // RVA: 0x7FFAFC3668A0
    public void set_Item(){} // RVA: 0x7FFAFC366990
    public void get_Values(){} // RVA: 0x7FFAFC366AD0
    public void .ctor(){} // RVA: 0x7FFAFC366B20
}

public class ImageDownloader
{
    // ── Methods ──
    public void get_State(){} // RVA: 0x7FFAF442C3B0
    public void set_State(){} // RVA: 0x7FFAF4439FD0
    public void get_Error(){} // RVA: 0x7FFAF3210030
    public void set_Error(){} // RVA: 0x7FFAF344E0D0
    public void get_ErrorMessage(){} // RVA: 0x7FFAF2DBB130
    public void set_ErrorMessage(){} // RVA: 0x7FFAF2D8EE90
    public void get_Result(){} // RVA: 0x7FFAF30E74D0
    public void set_Result(){} // RVA: 0x7FFAF2DBB890
    public void get_SizeInMemoryBytes(){} // RVA: 0x7FFAFC4BD4D0
    public void get_Progress(){} // RVA: 0x7FFAF2FAE250
    public void set_Progress(){} // RVA: 0x7FFAF2FAB970
    public void get_Url(){} // RVA: 0x7FFAF2E0A740
    public void set_Url(){} // RVA: 0x7FFAF2DB5200
    public void get_Material(){} // RVA: 0x7FFAF2E08730
    public void set_Material(){} // RVA: 0x7FFAF2E08740
    public void get_UdonBehaviour(){} // RVA: 0x7FFAF2E2E0E0
    public void set_UdonBehaviour(){} // RVA: 0x7FFAF2EE54D0
    public void get_TextureInfo(){} // RVA: 0x7FFAF2E55500
    public void set_TextureInfo(){} // RVA: 0x7FFAF2E55510
    public void LoadImage(){} // RVA: 0x7FFAFC4BDE20 | overloaded x2
    public void DownloadImage(){} // RVA: 0x7FFAFC4BDF00 | overloaded x2
    public void .ctor(){} // RVA: 0x7FFAFC4BD6F0
    public void StartDownload(){} // RVA: 0x7FFAFC4BD930
    public void SetProgress(){} // RVA: 0x7FFAF2FAB970
    public void RunUdonEventOnMainThreadAndRemoveFromQueue(){} // RVA: 0x7FFAFC4BE110
    public void Dispose(){} // RVA: 0x7FFAFC4BE330
    public void CancelDownload(){} // RVA: 0x7FFAFC4BE610
    public void Finalize(){} // RVA: 0x7FFAFC4BE680
    public void <DownloadImage>g__SlicedTextureUpload|52_0(){} // RVA: 0x7FFAFC4BE6C0
    public void <Dispose>g__DestroyAsync|54_0(){} // RVA: 0x7FFAFC4BE880
}

public class ImageInfo
{
}

public class ImageInfo
{
}

public class ImageLoadSettings
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF486E820
    public void GetAllocationLimit(){} // RVA: 0x7FFAFC4BE9B0
    public void SetAllocationLimit(){} // RVA: 0x7FFAFC4BEA10
    public void GetResolutionLimit(){} // RVA: 0x7FFAFC4BEAB0
    public void SetResolutionLimit(){} // RVA: 0x7FFAFC4BEB10
    public void GetVerticalFlip(){} // RVA: 0x7FFAF486E770
    public void SetVerticalFlip(){} // RVA: 0x7FFAF486E940
    public void GetResizeResolution(){} // RVA: 0x7FFAFC4BEBB0
    public void SetResizeResolution(){} // RVA: 0x7FFAFC4BEC50
    public void SetFastResize(){} // RVA: 0x7FFAF486E630
    public void GetFastResize(){} // RVA: 0x7FFAF486E570
    public void GetOutputFormatOverride(){} // RVA: 0x7FFAFC4BECF0
    public void SetOutputFormatOverride(){} // RVA: 0x7FFAFC4BED40
    public void SetGenerateMipMaps(){} // RVA: 0x7FFAF486E370
    public void GetGenerateMipMaps(){} // RVA: 0x7FFAF486E280
    public void HasFlag(){} // RVA: 0x7FFAF486E270
}

public class ImageLoadSettings
{
    // ── Methods ──
    public void RefreshImageLoadSettings(){} // RVA: 0x7FFAF486E260
    public void HasFlag(){} // RVA: 0x7FFAF486E270
    public void HasFlag_C46487BE14C3(){} // RVA: 0x7FFAF486E270
    public void GetGenerateMipMaps(){} // RVA: 0x7FFAF486E280
    public void GetGlobalConfigurationRefV2(){} // RVA: 0x7FFAF486E290
    public void GetGenerateMipMaps_26B27114E81F(){} // RVA: 0x7FFAF486E330
    public void GetReadable(){} // RVA: 0x7FFAF486E340
    public void SetGenerateMipMaps(){} // RVA: 0x7FFAF486E370
    public void SetGenerateMipMaps_CCE1E83098B7(){} // RVA: 0x7FFAF486E3C0
    public void GetTransform(){} // RVA: 0x7FFAF486E3D0
    public void SetLinear(){} // RVA: 0x7FFAF486E470
    public void GetMediaReferenceStatus(){} // RVA: 0x7FFAF486E4D0
    public void GetFastResize(){} // RVA: 0x7FFAF486E570
    public void SetPremultiplyAlpha(){} // RVA: 0x7FFAF486E580
    public void HasFlagC46487BE14C3(){} // RVA: 0x7FFAF486E5E0
    public void SetFastResize(){} // RVA: 0x7FFAF486E630
    public void SetCompressTexture(){} // RVA: 0x7FFAF486E680
    public void GetMaxTextureSize(){} // RVA: 0x7FFAF486E770
    public void GetOrCreateNetworkSyncableValue(){} // RVA: 0x7FFAF486E780
    public void .ctor(){} // RVA: 0x7FFAF486E820
    public void GetName1237140DB784(){} // RVA: 0x7FFAF486E850
    public void Setenabled(){} // RVA: 0x7FFAF486E8A0
    public void SetVerticalFlip(){} // RVA: 0x7FFAF486E940
    // ── Unresolved (hash) ──
    public void m_8B1(){} // RVA: 0x7FFAF486E720
}

public class ImageResult
{
}

public class ImageResult
{
}

public class ImmutableBox
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF4775AF0
    public void Run(){} // RVA: 0x7FFAF90F63C0
    public void get_InstructionName(){} // RVA: 0x7FFAF90F64E0
}

public class ImmutableCollectionTypeInfo
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF2E6CE00
    public void get_ContractTypeName(){} // RVA: 0x7FFAF2DA8380
    public void set_ContractTypeName(){} // RVA: 0x7FFAF2D8EE30
    public void get_CreatedTypeName(){} // RVA: 0x7FFAF2D907C0
    public void set_CreatedTypeName(){} // RVA: 0x7FFAF2DF3E80
    public void get_BuilderTypeName(){} // RVA: 0x7FFAF2DBB0C0
    public void set_BuilderTypeName(){} // RVA: 0x7FFAF2DBB0D0
}

public class ImmutableRefBox
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF2D900C0
    public void Run(){} // RVA: 0x7FFAF90F6520
    public void get_InstructionName(){} // RVA: 0x7FFAF90F65E0
}

public class ImmutableValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF4775AF0
    public void Run(){} // RVA: 0x7FFAF90F6250
    public void BoxIfIndexMatches(){} // RVA: 0x7FFAF90F62D0
    public void get_InstructionName(){} // RVA: 0x7FFAF90F6380
}

public class ImportStruct
{
}

public class ImposterData
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF44752B0
}

public class ImpulseEvent
{
    // ── Methods ──
    public void get_Expired(){} // RVA: 0x7FFAF47E4200
    public void Cancel(){} // RVA: 0x7FFAF47E42B0
    public void DistanceDecay(){} // RVA: 0x7FFAF47E42F0
    public void GetDecayedSignal(){} // RVA: 0x7FFAF47E4460
    public void Clear(){} // RVA: 0x7FFAF47E4C20
    public void .ctor(){} // RVA: 0x7FFAF2D8D310
}

public class ImpulseReaction
{
    // ── Methods ──
    public void ReSeed(){} // RVA: 0x7FFAF47E2CF0
    public void GetReaction(){} // RVA: 0x7FFAF47E2E20
}

public class IncrementDouble
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAF90CD660
    public void .ctor(){} // RVA: 0x7FFAF2D8D310
}

public class IncrementInt16
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAF90CCEB0
    public void .ctor(){} // RVA: 0x7FFAF2D8D310
}

public class IncrementInt32
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAF90CCF80
    public void .ctor(){} // RVA: 0x7FFAF2D8D310
}

public class IncrementInt64
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAF90CD0A0
    public void .ctor(){} // RVA: 0x7FFAF2D8D310
}

public class IncrementSingle
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAF90CD520
    public void .ctor(){} // RVA: 0x7FFAF2D8D310
}

public class IncrementUInt16
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAF90CD1E0
    public void .ctor(){} // RVA: 0x7FFAF2D8D310
}

public class IncrementUInt32
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAF90CD2B0
    public void .ctor(){} // RVA: 0x7FFAF2D8D310
}

public class IncrementUInt64
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAF90CD3E0
    public void .ctor(){} // RVA: 0x7FFAF2D8D310
}

public class IndexExpressionProxy
{
    public object Arguments;
    public object CanReduce;
    public object DebugView;
    public object Expression;
    public object NodeType;
    public object Type;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF908ADE0
    public void get_Arguments(){} // RVA: 0x7FFAF908AEC0
    public void get_CanReduce(){} // RVA: 0x7FFAF32A02E0
    public void get_DebugView(){} // RVA: 0x7FFAF908A6E0
    public void get_Indexer(){} // RVA: 0x7FFAF35DE530
    public void get_NodeType(){} // RVA: 0x7FFAF32A01B0
    public void get_Object(){} // RVA: 0x7FFAF35DEEA0
    public void get_Type(){} // RVA: 0x7FFAF32A0250
}

public class IndexTree
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF91E3EC0
    public void CompareNode(){} // RVA: 0x7FFAF91E3F70
    public void CompareSateliteTreeNode(){} // RVA: 0x7FFAF91E3F90
}

public class IndexedConverter`2
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAF2D33FA0
}

public class IndirectDrawIndexedArgs
{
    // ── Methods ──
    public void set_indexCountPerInstance(){} // RVA: 0x7FFAF32E3580
    public void set_instanceCount(){} // RVA: 0x7FFAF44189D0
    public void set_startIndex(){} // RVA: 0x7FFAF49598A0
    public void set_baseVertexIndex(){} // RVA: 0x7FFAF49598C0
    public void set_startInstance(){} // RVA: 0x7FFAF2D900C0
}

public class InfiniteTimer
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF95E10E0
    public void get_HasExpired(){} // RVA: 0x7FFAF2D8D320
    public void Cancel(){} // RVA: 0x7FFAF95E1100
}

public class InfiniteTimerQueue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF386A4A0
    public void CreateTimer(){} // RVA: 0x7FFAF95E0990
}

public class Info
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF6840E20
}

public class Info
{
    // ── Methods ──
    public void get_period(){} // RVA: 0x7FFAF2E08D50
    public void set_period(){} // RVA: 0x7FFAF2E08D60
    public void get_periodAmount(){} // RVA: 0x7FFAF3B95CF0
    public void set_periodAmount(){} // RVA: 0x7FFAF2F25080
    public void get_Period(){} // RVA: 0x7FFAFC3A32C0
    public void .ctor(){} // RVA: 0x7FFAFC3A33B0
}

public class InheritVelocityModule
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF3ABA2F0
    public void get_enabled(){} // RVA: 0x7FFAF9C6D1D0
    public void set_enabled(){} // RVA: 0x7FFAF9C6D220
    public void get_mode(){} // RVA: 0x7FFAF9C6D280
    public void set_mode(){} // RVA: 0x7FFAF9C6D2D0
    public void get_curve(){} // RVA: 0x7FFAF9C6D330
    public void set_curve(){} // RVA: 0x7FFAF9C6D3A0
    public void get_curveMultiplier(){} // RVA: 0x7FFAF9C6D400
    public void set_curveMultiplier(){} // RVA: 0x7FFAF9C6D450
    public void get_enabled_Injected(){} // RVA: 0x7FFAF9C6D1D0
    public void set_enabled_Injected(){} // RVA: 0x7FFAF9C6D220
    public void get_mode_Injected(){} // RVA: 0x7FFAF9C6D280
    public void set_mode_Injected(){} // RVA: 0x7FFAF9C6D2D0
    public void get_curve_Injected(){} // RVA: 0x7FFAF9C6D4B0
    public void set_curve_Injected(){} // RVA: 0x7FFAF9C6D510
    public void get_curveMultiplier_Injected(){} // RVA: 0x7FFAF9C6D400
    public void set_curveMultiplier_Injected(){} // RVA: 0x7FFAF9C6D450
}

public class InitConfig
{
}

public class InitConfig
{
}

public class Initial
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF8681C40
}

public class Initial
{
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF2E0D190
    public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    public void BeginInvoke(){} // RVA: 0x7FFAF2DE8C70
    public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF2E0D190
    public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    public void BeginInvoke(){} // RVA: 0x7FFAF2DE8C70
    public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF2E0D190
    public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    public void BeginInvoke(){} // RVA: 0x7FFAF2DE8C70
    public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF2E0D190
    public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    public void BeginInvoke(){} // RVA: 0x7FFAF2DE8C70
    public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF2E0D190
    public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    public void BeginInvoke(){} // RVA: 0x7FFAF2DE8C70
    public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF2E0D190
    public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    public void BeginInvoke(){} // RVA: 0x7FFAF2DE8C70
    public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF2E0D190
    public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    public void BeginInvoke(){} // RVA: 0x7FFAF2DE8C70
    public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF2E0D190
    public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    public void BeginInvoke(){} // RVA: 0x7FFAF2DE8C70
    public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF2E0D190
    public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    public void BeginInvoke(){} // RVA: 0x7FFAF2DE8C70
    public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF2E0D190
    public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    public void BeginInvoke(){} // RVA: 0x7FFAF2DE8C70
    public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAF2E0D190
    public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    public void BeginInvoke(){} // RVA: 0x7FFAF2DE8C70
    public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
}
