// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 397

public class IActivationFactory
{
    // ── Methods ──
    public void ActivateInstance(){} // RVA: 0xCD60
}

public class IAllocator
{
    // ── Methods ──
    public void Try(){} // RVA: 0x12590
    public void get_Handle(){} // RVA: 0x283FA0
}

public class IAttrList
{
    // ── Methods ──
    public void get_Length(){} // RVA: 0xD840
    public void GetName(){} // RVA: 0x1BCC0
    public void GetValue(){} // RVA: 0xCE10 | overloaded x2
    public void get_Names(){} // RVA: 0xCD60
    public void get_Values(){} // RVA: 0xCD60
}

public class IConstraintSubstituteCreator
{
    // ── Methods ──
    public void CreateSubstituteComponent(){} // RVA: 0x283FA0
}

public class IContentHandler
{
    // ── Methods ──
    public void OnStartParsing(){} // RVA: 0x24B10
    public void OnEndParsing(){} // RVA: 0x24B10
    public void OnStartElement(){} // RVA: 0x2DC60
    public void OnEndElement(){} // RVA: 0x24B10
    public void OnProcessingInstruction(){} // RVA: 0x2DC60
    public void OnChars(){} // RVA: 0x24B10
    public void OnIgnorableWhitespace(){} // RVA: 0x24B10
}

public class IEncryption
{
    // ── Methods ──
    public void Encrypt(){} // RVA: 0x1E6A0
    public void TryDecrypt(){}
}

public class IExtensionReflectionHelper
{
    // ── Methods ──
    public void GetExtension(){} // RVA: 0xCE10
    public void SetExtension(){} // RVA: 0x2DC60
    public void HasExtension(){} // RVA: 0xDE40
    public void ClearExtension(){} // RVA: 0x24B10
}

public class IFactoryControls
{
    // ── Methods ──
    public void CreateGameObject(){} // RVA: 0x1E6A0
}

public class IInput
{
    // ── Methods ──
    public void GetButtonDown(){} // RVA: 0xDE40
    public void GetAxisRaw(){} // RVA: 0x21FA0
    public void ClearLastPenContactEvent(){} // RVA: 0x24A50
    public void GetLastPenContactEvent(){}
    public void get_touchCount(){} // RVA: 0xD840
    public void GetTouch(){}
    public void get_mousePresent(){} // RVA: 0xDBE0
    public void GetMouseButtonDown(){} // RVA: 0xE1F0
    public void GetMouseButtonUp(){} // RVA: 0xE1F0
    public void get_mousePosition(){} // RVA: 0xC770
    public void get_mouseButtonCount(){} // RVA: 0xD840
    public void get_anyKey(){} // RVA: 0xDBE0
    public void get_unscaledTime(){} // RVA: 0x21890
    public void get_doubleClickTime(){} // RVA: 0x21890
}

public class IInputAxisProvider
{
    // ── Methods ──
    public void GetAxisValue(){} // RVA: 0x21C40
}

public class IJobSortable
{
    // ── Methods ──
    public void get_SortingBaseTransform(){} // RVA: 0xCD60
    public void get_MaximumExecutionGroups(){} // RVA: 0xD840
    public void GetKnownDependencies(){} // RVA: 0x24B10
    public void get_ExecutionGroup(){} // RVA: 0xD840
    public void set_ExecutionGroup(){} // RVA: 0x24FA0
}

public class IKBone
{
}

public class ILEmitResolverBuilderRuntimeContext
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DD310
}

public class IListWrapper
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5E06410
    public void set_Capacity(){} // RVA: 0x5E06490
    public void get_Count(){} // RVA: 0x5E06520
    public void get_IsReadOnly(){} // RVA: 0x5E06570
    public void get_IsFixedSize(){} // RVA: 0x5E065C0
    public void get_IsSynchronized(){} // RVA: 0x5E06610
    public void get_Item(){} // RVA: 0x5E06660
    public void set_Item(){} // RVA: 0x5E066C0
    public void get_SyncRoot(){} // RVA: 0x5E06740
    public void Add(){} // RVA: 0x5E06790
    public void AddRange(){} // RVA: 0x5E06800
    public void Clear(){} // RVA: 0x5E06850
    public void Clone(){} // RVA: 0x5E06910
    public void Contains(){} // RVA: 0x5E06970
    public void CopyTo(){} // RVA: 0x5E06A40 | overloaded x2
    public void GetEnumerator(){} // RVA: 0x5E06D70
    public void IndexOf(){} // RVA: 0x5E06DC0
    public void Insert(){} // RVA: 0x5E06E20
    public void InsertRange(){} // RVA: 0x5E06EA0
    public void Remove(){} // RVA: 0x5E05BE0
    public void RemoveAt(){} // RVA: 0x5E07220
    public void RemoveRange(){} // RVA: 0x5E07290
    public void Reverse(){} // RVA: 0x5E07490
    public void Sort(){} // RVA: 0x5E07870
    public void ToArray(){} // RVA: 0x5E07BF0 | overloaded x2
}

public class IMDrawBuffer`1
{
    // ── Methods ──
    public void get_UseStructuredBuffers(){} // RVA: 0xDC10
    public void set_UseStructuredBuffers(){} // RVA: 0x24F20
    public void Init(){} // RVA: 0x26EE0
    public void Dispose(){} // RVA: 0x24A50
    public void Clear(){} // RVA: 0x24A50
    public void Draw(){} // RVA: 0x24A50
    public void DrawFallback(){} // RVA: 0x24A50
    public void BuildFallbackCommandBuffer(){} // RVA: 0x24B10
    public void UpdateCommandBuffers(){} // RVA: 0x24A50
    public void UpdateInstanceData(){} // RVA: 0x24A50
    public void BuildCommandBuffer(){} // RVA: 0x24B10
    public void Add(){} // RVA: 0x283FA0
    public void .ctor(){} // RVA: 0x24A50
    public void .cctor(){} // RVA: 0x24A80
}

public class IMDrawBuffer`1
{
    // ── Methods ──
    public void get_UseStructuredBuffers(){} // RVA: 0x35250B0
    public void set_UseStructuredBuffers(){} // RVA: 0x3525150
    public void Init(){} // RVA: 0x3526290
    public void Dispose(){} // RVA: 0x3526C50
    public void Clear(){} // RVA: 0x1724E10
    public void Draw(){} // RVA: 0x3526CC0
    public void DrawFallback(){} // RVA: 0x24A50
    public void BuildFallbackCommandBuffer(){} // RVA: 0x24B10
    public void UpdateCommandBuffers(){} // RVA: 0x3526DE0
    public void UpdateInstanceData(){} // RVA: 0x3527010
    public void BuildCommandBuffer(){} // RVA: 0x3527230
    public void Add(){} // RVA: 0x3527370
    public void .ctor(){} // RVA: 0x2DD310
    public void .cctor(){} // RVA: 0x35273B0
}

public class IMDrawBuffer`1
{
    // ── Methods ──
    public void get_UseStructuredBuffers(){} // RVA: 0x35250B0
    public void set_UseStructuredBuffers(){} // RVA: 0x3525150
    public void Init(){} // RVA: 0x3527470
    public void Dispose(){} // RVA: 0x3526C50
    public void Clear(){} // RVA: 0x1724E10
    public void Draw(){} // RVA: 0x3527E40
    public void DrawFallback(){} // RVA: 0x24A50
    public void BuildFallbackCommandBuffer(){} // RVA: 0x24B10
    public void UpdateCommandBuffers(){} // RVA: 0x3527F60
    public void UpdateInstanceData(){} // RVA: 0x3528190
    public void BuildCommandBuffer(){} // RVA: 0x35283B0
    public void Add(){} // RVA: 0x35284F0
    public void .ctor(){} // RVA: 0x2DD310
    public void .cctor(){} // RVA: 0x3528540
}

public class IMDrawLine
{
    // ── Methods ──
    public void Add(){} // RVA: 0x76CDF10
    public void SetLineProperties(){} // RVA: 0x76CE040
    public void DrawFallback(){} // RVA: 0x76CE380
    public void BuildFallbackCommandBuffer(){} // RVA: 0x76CE530
    public void .ctor(){} // RVA: 0x76CE650
    public void .cctor(){} // RVA: 0x76CE6B0
}

public class IMDrawShape
{
    // ── Methods ──
    public void Add(){} // RVA: 0x76CE900
    public void DrawFallback(){} // RVA: 0x76CEAB0
    public void BuildFallbackCommandBuffer(){} // RVA: 0x76CED40
    public void .ctor(){} // RVA: 0x76CEF50
    public void .cctor(){} // RVA: 0x76CEFB0
}

public class IMGUISendQueuedEvents
{
}

public class IOVRMeshDataProvider
{
    // ── Methods ──
    public void GetMeshType(){} // RVA: 0xD840
}

public class IOVRMeshRendererDataProvider
{
    // ── Methods ──
    public void GetMeshRendererData(){}
}

public class IOVRSceneComponent
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x24A50
}

public class IOVRSkeletonDataProvider
{
    // ── Methods ──
    public void GetSkeletonType(){} // RVA: 0xD840
    public void GetSkeletonPoseData(){}
    public void get_enabled(){} // RVA: 0xDBE0
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
    public void get_require(){} // RVA: 0x358D50
    public void set_require(){} // RVA: 0x358D60
    public void get_include(){} // RVA: 0x3A5590
    public void set_include(){} // RVA: 0x3A55A0
    public void .ctor(){} // RVA: 0x9875FD0
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
    public void CreateFuncIMessageInt32(){} // RVA: 0xCE10
    public void CreateActionIMessage(){} // RVA: 0xCE10
    public void CreateFuncIMessageObject(){} // RVA: 0xCE10
    public void CreateActionIMessageObject(){} // RVA: 0xCE10
    public void CreateFuncIMessageBool(){} // RVA: 0xCE10
}

public class ISealedAllowReference
{
}

public class ITokenReader
{
    // ── Methods ──
    public void Read(){} // RVA: 0xD840
}

public class ITypeConstructor
{
    // ── Methods ──
    public void get_CanBeInstantiated(){} // RVA: 0xDBE0
    public void Instantiate(){} // RVA: 0xCD60
}

public class ITypeConstructor`1
{
    // ── Methods ──
    public void Instantiate(){} // RVA: 0x283FA0
    public void SetExplicitConstructor(){} // RVA: 0x24B10
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
    public void get_name(){} // RVA: 0xCD60
}

public class IUnimplemented
{
}

public class IVisualPredicateWrapper
{
    // ── Methods ──
    public void Predicate(){} // RVA: 0xDE40
}

public class IWebSocketReceiveResultGetter`1
{
    // ── Methods ──
    public void GetResult(){} // RVA: 0x283FA0
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
    public void .ctor_97D11E5DD8F5(){} // RVA: 0xD13810
    public void Initialize(){} // RVA: 0xD13930
    public void Equals(){} // RVA: 0xD13930
    public void op_Implicit(){} // RVA: 0xD13810
    public void CompareBaseObjects(){} // RVA: 0xD13A50
    public void IsNativeObjectAlive(){} // RVA: 0xD13810
    public void GetCachedPtr(){} // RVA: 0xD13B70
    public void .ctor(){} // RVA: 0x2DD310
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
    public void GetId(){} // RVA: 0xD840
    public void ReturnId(){} // RVA: 0x24FA0
    public void .ctor(){} // RVA: 0x24A50
}

public class IdManager
{
    // ── Methods ──
    public void GetId(){} // RVA: 0x3551FB0
    public void ReturnId(){} // RVA: 0x3552220
    public void .ctor(){} // RVA: 0x35523D0
}

public class IdentityTokenChanged
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x338B80
    public void Invoke(){} // RVA: 0x338C60
}

public class IgnoreDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1B3C7C0
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x1B3C940
}

public class IgnoresCaseHashtable
{
    // ── Methods ──
    public void Clear(){} // RVA: 0x98B6650
    public void GetEnumerator(){} // RVA: 0x98B66C0
    public void get_Keys(){} // RVA: 0x98B6710
    public void Remove(){} // RVA: 0x98B6760
    public void get_Item(){} // RVA: 0x98B68A0
    public void set_Item(){} // RVA: 0x98B6990
    public void get_Values(){} // RVA: 0x98B6AD0
    public void .ctor(){} // RVA: 0x98B6B20
}

public class ImageDownloader
{
    // ── Methods ──
    public void get_State(){} // RVA: 0x197C3B0
    public void set_State(){} // RVA: 0x1989FD0
    public void get_Error(){} // RVA: 0x760030
    public void set_Error(){} // RVA: 0x99E0D0
    public void get_ErrorMessage(){} // RVA: 0x30B130
    public void set_ErrorMessage(){} // RVA: 0x2DEE90
    public void get_Result(){} // RVA: 0x6374D0
    public void set_Result(){} // RVA: 0x30B890
    public void get_SizeInMemoryBytes(){} // RVA: 0x9A0D4D0
    public void get_Progress(){} // RVA: 0x4FE250
    public void set_Progress(){} // RVA: 0x4FB970
    public void get_Url(){} // RVA: 0x35A740
    public void set_Url(){} // RVA: 0x305200
    public void get_Material(){} // RVA: 0x358730
    public void set_Material(){} // RVA: 0x358740
    public void get_UdonBehaviour(){} // RVA: 0x37E0E0
    public void set_UdonBehaviour(){} // RVA: 0x4354D0
    public void get_TextureInfo(){} // RVA: 0x3A5500
    public void set_TextureInfo(){} // RVA: 0x3A5510
    public void LoadImage(){} // RVA: 0x9A0DE20 | overloaded x2
    public void DownloadImage(){} // RVA: 0x9A0DF00 | overloaded x2
    public void .ctor(){} // RVA: 0x9A0D6F0
    public void StartDownload(){} // RVA: 0x9A0D930
    public void SetProgress(){} // RVA: 0x4FB970
    public void RunUdonEventOnMainThreadAndRemoveFromQueue(){} // RVA: 0x9A0E110
    public void Dispose(){} // RVA: 0x9A0E330
    public void CancelDownload(){} // RVA: 0x9A0E610
    public void Finalize(){} // RVA: 0x9A0E680
    public void <DownloadImage>g__SlicedTextureUpload|52_0(){} // RVA: 0x9A0E6C0
    public void <Dispose>g__DestroyAsync|54_0(){} // RVA: 0x9A0E880
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
    public void .ctor(){} // RVA: 0x1DBE820
    public void GetAllocationLimit(){} // RVA: 0x9A0E9B0
    public void SetAllocationLimit(){} // RVA: 0x9A0EA10
    public void GetResolutionLimit(){} // RVA: 0x9A0EAB0
    public void SetResolutionLimit(){} // RVA: 0x9A0EB10
    public void GetVerticalFlip(){} // RVA: 0x1DBE770
    public void SetVerticalFlip(){} // RVA: 0x1DBE940
    public void GetResizeResolution(){} // RVA: 0x9A0EBB0
    public void SetResizeResolution(){} // RVA: 0x9A0EC50
    public void SetFastResize(){} // RVA: 0x1DBE630
    public void GetFastResize(){} // RVA: 0x1DBE570
    public void GetOutputFormatOverride(){} // RVA: 0x9A0ECF0
    public void SetOutputFormatOverride(){} // RVA: 0x9A0ED40
    public void SetGenerateMipMaps(){} // RVA: 0x1DBE370
    public void GetGenerateMipMaps(){} // RVA: 0x1DBE280
    public void HasFlag(){} // RVA: 0x1DBE270
}

public class ImageLoadSettings
{
    // ── Methods ──
    public void RefreshImageLoadSettings(){} // RVA: 0x1DBE260
    public void HasFlag(){} // RVA: 0x1DBE270
    public void HasFlag_C46487BE14C3(){} // RVA: 0x1DBE270
    public void GetGenerateMipMaps(){} // RVA: 0x1DBE280
    public void GetGlobalConfigurationRefV2(){} // RVA: 0x1DBE290
    public void GetGenerateMipMaps_26B27114E81F(){} // RVA: 0x1DBE330
    public void GetReadable(){} // RVA: 0x1DBE340
    public void SetGenerateMipMaps(){} // RVA: 0x1DBE370
    public void SetGenerateMipMaps_CCE1E83098B7(){} // RVA: 0x1DBE3C0
    public void GetTransform(){} // RVA: 0x1DBE3D0
    public void SetLinear(){} // RVA: 0x1DBE470
    public void GetMediaReferenceStatus(){} // RVA: 0x1DBE4D0
    public void GetFastResize(){} // RVA: 0x1DBE570
    public void SetPremultiplyAlpha(){} // RVA: 0x1DBE580
    public void HasFlagC46487BE14C3(){} // RVA: 0x1DBE5E0
    public void SetFastResize(){} // RVA: 0x1DBE630
    public void SetCompressTexture(){} // RVA: 0x1DBE680
    public void GetMaxTextureSize(){} // RVA: 0x1DBE770
    public void GetOrCreateNetworkSyncableValue(){} // RVA: 0x1DBE780
    public void .ctor(){} // RVA: 0x1DBE820
    public void GetName1237140DB784(){} // RVA: 0x1DBE850
    public void Setenabled(){} // RVA: 0x1DBE8A0
    public void SetVerticalFlip(){} // RVA: 0x1DBE940
    // ── Unresolved (hash) ──
    public void m_8B1(){} // RVA: 0x1DBE720
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
    public void .ctor(){} // RVA: 0x1CC5AF0
    public void Run(){} // RVA: 0x66463C0
    public void get_InstructionName(){} // RVA: 0x66464E0
}

public class ImmutableCollectionTypeInfo
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3BCE00
    public void get_ContractTypeName(){} // RVA: 0x2F8380
    public void set_ContractTypeName(){} // RVA: 0x2DEE30
    public void get_CreatedTypeName(){} // RVA: 0x2E07C0
    public void set_CreatedTypeName(){} // RVA: 0x343E80
    public void get_BuilderTypeName(){} // RVA: 0x30B0C0
    public void set_BuilderTypeName(){} // RVA: 0x30B0D0
}

public class ImmutableRefBox
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2E00C0
    public void Run(){} // RVA: 0x6646520
    public void get_InstructionName(){} // RVA: 0x66465E0
}

public class ImmutableValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1CC5AF0
    public void Run(){} // RVA: 0x6646250
    public void BoxIfIndexMatches(){} // RVA: 0x66462D0
    public void get_InstructionName(){} // RVA: 0x6646380
}

public class ImportStruct
{
}

public class ImposterData
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x19C52B0
}

public class ImpulseEvent
{
    // ── Methods ──
    public void get_Expired(){} // RVA: 0x1D34200
    public void Cancel(){} // RVA: 0x1D342B0
    public void DistanceDecay(){} // RVA: 0x1D342F0
    public void GetDecayedSignal(){} // RVA: 0x1D34460
    public void Clear(){} // RVA: 0x1D34C20
    public void .ctor(){} // RVA: 0x2DD310
}

public class ImpulseReaction
{
    // ── Methods ──
    public void ReSeed(){} // RVA: 0x1D32CF0
    public void GetReaction(){} // RVA: 0x1D32E20
}

public class IncrementDouble
{
    // ── Methods ──
    public void Run(){} // RVA: 0x661D660
    public void .ctor(){} // RVA: 0x2DD310
}

public class IncrementInt16
{
    // ── Methods ──
    public void Run(){} // RVA: 0x661CEB0
    public void .ctor(){} // RVA: 0x2DD310
}

public class IncrementInt32
{
    // ── Methods ──
    public void Run(){} // RVA: 0x661CF80
    public void .ctor(){} // RVA: 0x2DD310
}

public class IncrementInt64
{
    // ── Methods ──
    public void Run(){} // RVA: 0x661D0A0
    public void .ctor(){} // RVA: 0x2DD310
}

public class IncrementSingle
{
    // ── Methods ──
    public void Run(){} // RVA: 0x661D520
    public void .ctor(){} // RVA: 0x2DD310
}

public class IncrementUInt16
{
    // ── Methods ──
    public void Run(){} // RVA: 0x661D1E0
    public void .ctor(){} // RVA: 0x2DD310
}

public class IncrementUInt32
{
    // ── Methods ──
    public void Run(){} // RVA: 0x661D2B0
    public void .ctor(){} // RVA: 0x2DD310
}

public class IncrementUInt64
{
    // ── Methods ──
    public void Run(){} // RVA: 0x661D3E0
    public void .ctor(){} // RVA: 0x2DD310
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
    public void .ctor(){} // RVA: 0x65DADE0
    public void get_Arguments(){} // RVA: 0x65DAEC0
    public void get_CanReduce(){} // RVA: 0x7F02E0
    public void get_DebugView(){} // RVA: 0x65DA6E0
    public void get_Indexer(){} // RVA: 0xB2E530
    public void get_NodeType(){} // RVA: 0x7F01B0
    public void get_Object(){} // RVA: 0xB2EEA0
    public void get_Type(){} // RVA: 0x7F0250
}

public class IndexTree
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6733EC0
    public void CompareNode(){} // RVA: 0x6733F70
    public void CompareSateliteTreeNode(){} // RVA: 0x6733F90
}

public class IndexedConverter`2
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x283FA0
}

public class IndirectDrawIndexedArgs
{
    // ── Methods ──
    public void set_indexCountPerInstance(){} // RVA: 0x833580
    public void set_instanceCount(){} // RVA: 0x19689D0
    public void set_startIndex(){} // RVA: 0x1EA98A0
    public void set_baseVertexIndex(){} // RVA: 0x1EA98C0
    public void set_startInstance(){} // RVA: 0x2E00C0
}

public class InfiniteTimer
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B310E0
    public void get_HasExpired(){} // RVA: 0x2DD320
    public void Cancel(){} // RVA: 0x6B31100
}

public class InfiniteTimerQueue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xDBA4A0
    public void CreateTimer(){} // RVA: 0x6B30990
}

public class Info
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3D90E20
}

public class Info
{
    // ── Methods ──
    public void get_period(){} // RVA: 0x358D50
    public void set_period(){} // RVA: 0x358D60
    public void get_periodAmount(){} // RVA: 0x10E5CF0
    public void set_periodAmount(){} // RVA: 0x475080
    public void get_Period(){} // RVA: 0x98F32C0
    public void .ctor(){} // RVA: 0x98F33B0
}

public class InheritVelocityModule
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x100A2F0
    public void get_enabled(){} // RVA: 0x71BD1D0
    public void set_enabled(){} // RVA: 0x71BD220
    public void get_mode(){} // RVA: 0x71BD280
    public void set_mode(){} // RVA: 0x71BD2D0
    public void get_curve(){} // RVA: 0x71BD330
    public void set_curve(){} // RVA: 0x71BD3A0
    public void get_curveMultiplier(){} // RVA: 0x71BD400
    public void set_curveMultiplier(){} // RVA: 0x71BD450
    public void get_enabled_Injected(){} // RVA: 0x71BD1D0
    public void set_enabled_Injected(){} // RVA: 0x71BD220
    public void get_mode_Injected(){} // RVA: 0x71BD280
    public void set_mode_Injected(){} // RVA: 0x71BD2D0
    public void get_curve_Injected(){} // RVA: 0x71BD4B0
    public void set_curve_Injected(){} // RVA: 0x71BD510
    public void get_curveMultiplier_Injected(){} // RVA: 0x71BD400
    public void set_curveMultiplier_Injected(){} // RVA: 0x71BD450
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
    public void .ctor(){} // RVA: 0x5BD1C40
}

public class Initial
{
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35D190
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35D190
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35D190
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35D190
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35D190
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35D190
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35D190
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35D190
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35D190
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35D190
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class InitializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35D190
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}
