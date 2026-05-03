// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 373

public class IActivationFactory : Object
{
    // ── Methods ──
    public void ActivateInstance(){} // RVA: 0x7FFE80E2E2E0
}

public class IAllocator
{
    // ── Methods ──
    public void Try(){} // RVA: 0x7FFE80E33B00
    public void get_Handle(){} // RVA: 0x7FFE810A1420
}

public class IAttrList
{
    // ── Methods ──
    public void get_Length(){} // RVA: 0x7FFE80E2EDB0
    public void GetName(){} // RVA: 0x7FFE80E3D230
    public void GetValue(){} // RVA: 0x7FFE80E2E390 | overloaded x2
    public void get_Names(){} // RVA: 0x7FFE80E2E2E0
    public void get_Values(){} // RVA: 0x7FFE80E2E2E0
}

public class IConstraintSubstituteCreator
{
    // ── Methods ──
    public void CreateSubstituteComponent(){} // RVA: 0x7FFE810A1420
}

public class IContentHandler
{
    // ── Methods ──
    public void OnStartParsing(){} // RVA: 0x7FFE80E460A0
    public void OnEndParsing(){} // RVA: 0x7FFE80E460A0
    public void OnStartElement(){} // RVA: 0x7FFE80E4F230
    public void OnEndElement(){} // RVA: 0x7FFE80E460A0
    public void OnProcessingInstruction(){} // RVA: 0x7FFE80E4F230
    public void OnChars(){} // RVA: 0x7FFE80E460A0
    public void OnIgnorableWhitespace(){} // RVA: 0x7FFE80E460A0
}

public class IEncryption
{
    // ── Methods ──
    public void Encrypt(){} // RVA: 0x7FFE80E3FC10
    public void TryDecrypt(){}
}

public class IExtensionReflectionHelper
{
    // ── Methods ──
    public void GetExtension(){} // RVA: 0x7FFE80E2E390
    public void SetExtension(){} // RVA: 0x7FFE80E4F230
    public void HasExtension(){} // RVA: 0x7FFE80E2F3B0
    public void ClearExtension(){} // RVA: 0x7FFE80E460A0
}

public class IFactoryControls
{
    // ── Methods ──
    public void CreateGameObject(){} // RVA: 0x7FFE80E3FC10
}

public class IInput
{
    // ── Methods ──
    public void GetButtonDown(){} // RVA: 0x7FFE80E2F3B0
    public void GetAxisRaw(){} // RVA: 0x7FFE80E43520
    public void ClearLastPenContactEvent(){} // RVA: 0x7FFE80E45FE0
    public void GetLastPenContactEvent(){}
    public void get_touchCount(){} // RVA: 0x7FFE80E2EDB0
    public void GetTouch(){}
    public void get_mousePresent(){} // RVA: 0x7FFE80E2F150
    public void GetMouseButtonDown(){} // RVA: 0x7FFE80E2F760
    public void GetMouseButtonUp(){} // RVA: 0x7FFE80E2F760
    public void get_mousePosition(){} // RVA: 0x7FFE80E2DCF0
    public void get_mouseButtonCount(){} // RVA: 0x7FFE80E2EDB0
    public void get_anyKey(){} // RVA: 0x7FFE80E2F150
    public void get_unscaledTime(){} // RVA: 0x7FFE80E42E10
    public void get_doubleClickTime(){} // RVA: 0x7FFE80E42E10
}

public class IInputAxisProvider
{
    // ── Methods ──
    public void GetAxisValue(){} // RVA: 0x7FFE80E431C0
}

public class IJobSortable
{
    // ── Methods ──
    public void get_SortingBaseTransform(){} // RVA: 0x7FFE80E2E2E0
    public void get_MaximumExecutionGroups(){} // RVA: 0x7FFE80E2EDB0
    public void GetKnownDependencies(){} // RVA: 0x7FFE80E460A0
    public void get_ExecutionGroup(){} // RVA: 0x7FFE80E2EDB0
    public void set_ExecutionGroup(){} // RVA: 0x7FFE80E46530
}

public class IKBone : ValueType
{
}

public class ILEmitResolverBuilderRuntimeContext : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class IListWrapper : ArrayList
{
    public System.Collections.IList _list; // 0x28
    public object field_1; // 0x811
    public object field_2; // 0x812
    public object field_3; // 0x813
    public object field_4; // 0x814
    public object field_5; // 0x815
    public object field_6; // 0x816

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86947250
    public void set_Capacity(){} // RVA: 0x7FFE869472D0
    public void get_Count(){} // RVA: 0x7FFE86947360
    public void get_IsReadOnly(){} // RVA: 0x7FFE869473B0
    public void get_IsFixedSize(){} // RVA: 0x7FFE86947400
    public void get_IsSynchronized(){} // RVA: 0x7FFE86947450
    public void get_Item(){} // RVA: 0x7FFE869474A0
    public void set_Item(){} // RVA: 0x7FFE86947500
    public void get_SyncRoot(){} // RVA: 0x7FFE86947580
    public void Add(){} // RVA: 0x7FFE869475D0
    public void AddRange(){} // RVA: 0x7FFE86947640
    public void Clear(){} // RVA: 0x7FFE86947690
    public void Clone(){} // RVA: 0x7FFE86947750
    public void Contains(){} // RVA: 0x7FFE869477B0
    public void CopyTo(){} // RVA: 0x7FFE86947880 | overloaded x2
    public void GetEnumerator(){} // RVA: 0x7FFE86947BB0
    public void IndexOf(){} // RVA: 0x7FFE86947C00
    public void Insert(){} // RVA: 0x7FFE86947C60
    public void InsertRange(){} // RVA: 0x7FFE86947CE0
    public void Remove(){} // RVA: 0x7FFE86946A20
    public void RemoveAt(){} // RVA: 0x7FFE86948060
    public void RemoveRange(){} // RVA: 0x7FFE869480D0
    public void Reverse(){} // RVA: 0x7FFE869482D0
    public void Sort(){} // RVA: 0x7FFE869486B0
    public void ToArray(){} // RVA: 0x7FFE86948A30 | overloaded x2
}

public class IMDrawBuffer`1 : Object
{
    public UnityEngine.Mesh mesh;

    // ── Methods ──
    public void get_UseStructuredBuffers(){} // RVA: 0x7FFE80E2F180
    public void set_UseStructuredBuffers(){} // RVA: 0x7FFE80E464B0
    public void Init(){} // RVA: 0x7FFE80E484C0
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void Clear(){} // RVA: 0x7FFE80E45FE0
    public void Draw(){} // RVA: 0x7FFE80E45FE0
    public void DrawFallback(){} // RVA: 0x7FFE80E45FE0
    public void BuildFallbackCommandBuffer(){} // RVA: 0x7FFE80E460A0
    public void UpdateCommandBuffers(){} // RVA: 0x7FFE80E45FE0
    public void UpdateInstanceData(){} // RVA: 0x7FFE80E45FE0
    public void BuildCommandBuffer(){} // RVA: 0x7FFE80E460A0
    public void Add(){} // RVA: 0x7FFE810A1420
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class IMDrawLine : IMDrawBuffer`1
{
    // ── Methods ──
    public void Add(){} // RVA: 0x7FFE8820B030
    public void SetLineProperties(){} // RVA: 0x7FFE8820B160
    public void DrawFallback(){} // RVA: 0x7FFE8820B4A0
    public void BuildFallbackCommandBuffer(){} // RVA: 0x7FFE8820B650
    public void .ctor(){} // RVA: 0x7FFE8820B770
    public void .cctor(){} // RVA: 0x7FFE8820B7D0
}

public class IMDrawShape : IMDrawBuffer`1
{
    // ── Methods ──
    public void Add(){} // RVA: 0x7FFE8820BA20
    public void DrawFallback(){} // RVA: 0x7FFE8820BBD0
    public void BuildFallbackCommandBuffer(){} // RVA: 0x7FFE8820BE60
    public void .ctor(){} // RVA: 0x7FFE8820C070
    public void .cctor(){} // RVA: 0x7FFE8820C0D0
}

public class IMGUISendQueuedEvents : ValueType
{
}

public class IOVRMeshDataProvider
{
    // ── Methods ──
    public void GetMeshType(){} // RVA: 0x7FFE80E2EDB0
}

public class IOVRMeshRendererDataProvider
{
    // ── Methods ──
    public void GetMeshRendererData(){}
}

public class IOVRSceneComponent
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFE80E45FE0
}

public class IOVRSkeletonDataProvider
{
    // ── Methods ──
    public void GetSkeletonType(){} // RVA: 0x7FFE80E2EDB0
    public void GetSkeletonPoseData(){}
    public void get_enabled(){} // RVA: 0x7FFE80E2F150
}

public class IOVRSkeletonRendererDataProvider
{
    // ── Methods ──
    public void GetSkeletonRendererData(){}
}

public class IO_STATUS : ValueType
{
}

public class IO_STATUS_BLOCK : ValueType
{
}

public class IPLGainNudgeData : ValueType
{
}

public class IPSQuery : ApiModel
{
    public string _require; // 0x68
    public string _include; // 0x70

    // ── Methods ──
    public void get_require(){} // RVA: 0x7FFE81176D50
    public void set_require(){} // RVA: 0x7FFE81176D60
    public void get_include(){} // RVA: 0x7FFE811C3590
    public void set_include(){} // RVA: 0x7FFE811C35A0
    public void .ctor(){} // RVA: 0x7FFE8A2D8410
}

public class IPV4 : ValueType
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
    public void CreateFuncIMessageInt32(){} // RVA: 0x7FFE80E2E390
    public void CreateActionIMessage(){} // RVA: 0x7FFE80E2E390
    public void CreateFuncIMessageObject(){} // RVA: 0x7FFE80E2E390
    public void CreateActionIMessageObject(){} // RVA: 0x7FFE80E2E390
    public void CreateFuncIMessageBool(){} // RVA: 0x7FFE80E2E390
}

public class ISealedAllowReference
{
}

public class ITokenReader
{
    // ── Methods ──
    public void Read(){} // RVA: 0x7FFE80E2EDB0
}

public class ITypeConstructor
{
    // ── Methods ──
    public void get_CanBeInstantiated(){} // RVA: 0x7FFE80E2F150
    public void Instantiate(){} // RVA: 0x7FFE80E2E2E0
}

public class ITypeConstructor`1
{
    // ── Methods ──
    public void Instantiate(){} // RVA: 0x7FFE810A1420
    public void SetExplicitConstructor(){} // RVA: 0x7FFE80E460A0
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
    public void get_name(){} // RVA: 0x7FFE80E2E2E0
}

public class IUnimplemented
{
}

public class IVisualPredicateWrapper
{
    // ── Methods ──
    public void Predicate(){} // RVA: 0x7FFE80E2F3B0
}

public class IWebSocketReceiveResultGetter`1
{
    // ── Methods ──
    public void GetResult(){} // RVA: 0x7FFE810A1420
}

public class Icons : ValueType
{
}

public class IdManager : Object
{
    // ── Methods ──
    public void GetId(){} // RVA: 0x7FFE80E2EDB0
    public void ReturnId(){} // RVA: 0x7FFE80E46530
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class IdentityTokenChanged : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class IgnoreDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE828C6D10
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE828C6E90
}

public class IgnoresCaseHashtable : Object
{
    public System.Collections.IDictionary orig; // 0x10
    public System.Collections.IDictionary keys; // 0x18
    public object field_2; // 0x195

    // ── Methods ──
    public void Clear(){} // RVA: 0x7FFE8A318370
    public void GetEnumerator(){} // RVA: 0x7FFE8A3183E0
    public void get_Keys(){} // RVA: 0x7FFE8A318430
    public void Remove(){} // RVA: 0x7FFE8A318480
    public void get_Item(){} // RVA: 0x7FFE8A3185C0
    public void set_Item(){} // RVA: 0x7FFE8A3186B0
    public void get_Values(){} // RVA: 0x7FFE8A3187F0
    public void .ctor(){} // RVA: 0x7FFE8A318840
}

public class ImageDownloader : Object
{
    public string NATIVE_LIB;
    public float MINIMUM_DELAY_BETWEEN_REQUESTS;
    public int MAXIMUM_DIMENSION;
    public int MAX_BUFFER_SIZE;
    public int SLICE_SIZE_BYTES;
    public float _lastImageRequest;
    public System.Threading.CancellationTokenSource _cancellationTokenSource; // 0x10
    public int _sizeInMemoryBytes; // 0x18
    public 0x6665C51C _state; // 0x1C
    public 0x6665C4C4 _error; // 0x20

    // ── Methods ──
    public void get_State(){} // RVA: 0x7FFE82707EE0
    public void set_State(){} // RVA: 0x7FFE82717690
    public void get_Error(){} // RVA: 0x7FFE8151D690
    public void set_Error(){} // RVA: 0x7FFE8170B670
    public void get_ErrorMessage(){} // RVA: 0x7FFE81129130
    public void set_ErrorMessage(){} // RVA: 0x7FFE810FCE90
    public void get_Result(){} // RVA: 0x7FFE8144E200
    public void set_Result(){} // RVA: 0x7FFE81129890
    public void get_SizeInMemoryBytes(){} // RVA: 0x7FFE8A468F00
    public void get_Progress(){} // RVA: 0x7FFE8130ACF0
    public void set_Progress(){} // RVA: 0x7FFE8130A000
    public void get_Url(){} // RVA: 0x7FFE81178740
    public void set_Url(){} // RVA: 0x7FFE81123200
    public void get_Material(){} // RVA: 0x7FFE81176730
    public void set_Material(){} // RVA: 0x7FFE81176740
    public void get_UdonBehaviour(){} // RVA: 0x7FFE8119C0E0
    public void set_UdonBehaviour(){} // RVA: 0x7FFE812534D0
    public void get_TextureInfo(){} // RVA: 0x7FFE811C3500
    public void set_TextureInfo(){} // RVA: 0x7FFE811C3510
    public void LoadImage(){} // RVA: 0x7FFE8A469850 | overloaded x2
    public void DownloadImage(){} // RVA: 0x7FFE8A469930 | overloaded x2
    public void .ctor(){} // RVA: 0x7FFE8A469120
    public void StartDownload(){} // RVA: 0x7FFE8A469360
    public void SetProgress(){} // RVA: 0x7FFE8130A000
    public void RunUdonEventOnMainThreadAndRemoveFromQueue(){} // RVA: 0x7FFE8A469B40
    public void Dispose(){} // RVA: 0x7FFE8A469D60
    public void CancelDownload(){} // RVA: 0x7FFE8A46A040
    public void Finalize(){} // RVA: 0x7FFE8A46A0B0
    public void <DownloadImage>g__SlicedTextureUpload|52_0(){} // RVA: 0x7FFE8A46A0F0
    public void <Dispose>g__DestroyAsync|54_0(){} // RVA: 0x7FFE8A46A2B0
}

public class ImageInfo : ValueType
{
}

public class ImageLoadSettings : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B4E7F0
    public void GetAllocationLimit(){} // RVA: 0x7FFE8A46A3E0
    public void SetAllocationLimit(){} // RVA: 0x7FFE8A46A440
    public void GetResolutionLimit(){} // RVA: 0x7FFE8A46A4E0
    public void SetResolutionLimit(){} // RVA: 0x7FFE8A46A540
    public void GetVerticalFlip(){} // RVA: 0x7FFE82B4E590
    public void SetVerticalFlip(){} // RVA: 0x7FFE82B4E2E0
    public void GetResizeResolution(){} // RVA: 0x7FFE8A46A5E0
    public void SetResizeResolution(){} // RVA: 0x7FFE8A46A680
    public void SetFastResize(){} // RVA: 0x7FFE82B4E640
    public void GetFastResize(){} // RVA: 0x7FFE82B4E7E0
    public void GetOutputFormatOverride(){} // RVA: 0x7FFE8A46A720
    public void SetOutputFormatOverride(){} // RVA: 0x7FFE8A46A770
    public void SetGenerateMipMaps(){} // RVA: 0x7FFE82B4E8E0
    public void GetGenerateMipMaps(){} // RVA: 0x7FFE82B4E8D0
    public void HasFlag(){} // RVA: 0x7FFE82B4E8C0
}

public class ImageResult : ValueType
{
}

public class ImmutableBox : InitializeLocalInstruction
{
    public object _defaultValue; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82A53990
    public void Run(){} // RVA: 0x7FFE871852B0
    public void get_InstructionName(){} // RVA: 0x7FFE871853D0
}

public class ImmutableCollectionTypeInfo : Object
{
    public string _contractTypeName; // 0x10
    public string _createdTypeName; // 0x18
    public string _builderTypeName; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE811DAE00
    public void get_ContractTypeName(){} // RVA: 0x7FFE81116380
    public void set_ContractTypeName(){} // RVA: 0x7FFE810FCE30
    public void get_CreatedTypeName(){} // RVA: 0x7FFE810FE7C0
    public void set_CreatedTypeName(){} // RVA: 0x7FFE81161E80
    public void get_BuilderTypeName(){} // RVA: 0x7FFE811290C0
    public void set_BuilderTypeName(){} // RVA: 0x7FFE811290D0
}

public class ImmutableRefBox : InitializeLocalInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FE0C0
    public void Run(){} // RVA: 0x7FFE87185410
    public void get_InstructionName(){} // RVA: 0x7FFE871854D0
}

public class ImmutableValue : InitializeLocalInstruction
{
    public object _defaultValue; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82A53990
    public void Run(){} // RVA: 0x7FFE87185140
    public void BoxIfIndexMatches(){} // RVA: 0x7FFE871851C0
    public void get_InstructionName(){} // RVA: 0x7FFE87185270
}

public class ImportStruct : ValueType
{
}

public class ImposterData : ScriptableObject
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82889230
}

public class ImpulseEvent : Object
{
    public float m_StartTime; // 0x10

    // ── Methods ──
    public void get_Expired(){} // RVA: 0x7FFE82AC2080
    public void Cancel(){} // RVA: 0x7FFE82AC2130
    public void DistanceDecay(){} // RVA: 0x7FFE82AC2170
    public void GetDecayedSignal(){} // RVA: 0x7FFE82AC22E0
    public void Clear(){} // RVA: 0x7FFE82AC2AA0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ImpulseReaction : ValueType
{
    // ── Methods ──
    public void ReSeed(){} // RVA: 0x7FFE82AC0B70
    public void GetReaction(){} // RVA: 0x7FFE82AC0CA0
}

public class IncrementDouble : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8715C530
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class IncrementInt16 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8715BD80
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class IncrementInt32 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8715BE50
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class IncrementInt64 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8715BF70
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class IncrementSingle : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8715C3F0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class IncrementUInt16 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8715C0B0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class IncrementUInt32 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8715C180
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class IncrementUInt64 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8715C2B0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class IndexExpressionProxy : Object
{
    public System.Linq.Expressions.IndexExpression _node; // 0x10
    public object field_1; // 0xC8
    public object field_2; // 0xC9
    public object field_3; // 0xCA
    public object field_4; // 0xCB
    public object field_5; // 0xCC
    public object field_6; // 0xCD

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87119C70
    public void get_Arguments(){} // RVA: 0x7FFE87119D50
    public void get_CanReduce(){} // RVA: 0x7FFE81588760
    public void get_DebugView(){} // RVA: 0x7FFE87119570
    public void get_Indexer(){} // RVA: 0x7FFE8189B810
    public void get_NodeType(){} // RVA: 0x7FFE81588A80
    public void get_Object(){} // RVA: 0x7FFE8189C080
    public void get_Type(){} // RVA: 0x7FFE815888E0
}

public class IndexTree : RBTree`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87272DC0
    public void CompareNode(){} // RVA: 0x7FFE87272E70
    public void CompareSateliteTreeNode(){} // RVA: 0x7FFE87272E90
}

public class IndexedConverter`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
}

public class IndirectDrawIndexedArgs : ValueType
{
    public int size;
    public uint _indexCountPerInstance; // 0x10
    public uint _instanceCount; // 0x14
    public uint _startIndex; // 0x18
    public uint _baseVertexIndex; // 0x1C

    // ── Methods ──
    public void set_indexCountPerInstance(){} // RVA: 0x7FFE815BF990
    public void set_instanceCount(){} // RVA: 0x7FFE826F4290
    public void set_startIndex(){} // RVA: 0x7FFE82C33010
    public void set_baseVertexIndex(){} // RVA: 0x7FFE82C33030
    public void set_startInstance(){} // RVA: 0x7FFE810FE0C0
}

public class InfiniteTimer : Timer
{
    public int cancelled; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87670390
    public void get_HasExpired(){} // RVA: 0x7FFE810FB320
    public void Cancel(){} // RVA: 0x7FFE876703B0
}

public class InfiniteTimerQueue : Queue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81B44AE0
    public void CreateTimer(){} // RVA: 0x7FFE8766FC40
}

public class Info : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84A014A0
}

public class InheritVelocityModule : ValueType
{
    public UnityEngine.ParticleSystem m_ParticleSystem; // 0x10
    public object field_1; // 0x125
    public object field_2; // 0x126
    public object field_3; // 0x127

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void get_enabled(){} // RVA: 0x7FFE87CFD370
    public void set_enabled(){} // RVA: 0x7FFE87CFD3C0
    public void get_mode(){} // RVA: 0x7FFE87CFD420
    public void set_mode(){} // RVA: 0x7FFE87CFD470
    public void get_curve(){} // RVA: 0x7FFE87CFD4D0
    public void set_curve(){} // RVA: 0x7FFE87CFD540
    public void get_curveMultiplier(){} // RVA: 0x7FFE87CFD5A0
    public void set_curveMultiplier(){} // RVA: 0x7FFE87CFD5F0
    public void get_enabled_Injected(){} // RVA: 0x7FFE87CFD370
    public void set_enabled_Injected(){} // RVA: 0x7FFE87CFD3C0
    public void get_mode_Injected(){} // RVA: 0x7FFE87CFD420
    public void set_mode_Injected(){} // RVA: 0x7FFE87CFD470
    public void get_curve_Injected(){} // RVA: 0x7FFE87CFD650
    public void set_curve_Injected(){} // RVA: 0x7FFE87CFD6B0
    public void get_curveMultiplier_Injected(){} // RVA: 0x7FFE87CFD5A0
    public void set_curveMultiplier_Injected(){} // RVA: 0x7FFE87CFD5F0
}

public class InitConfig : ValueType
{
}

public class Initial : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86712A90
}

public class InitializationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8117B190
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class InitializeDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8117B190
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class InlineRule : ValueType
{
}

public class Input : Object
{
    // ── Methods ──
    public void GetButtonDown(){} // RVA: 0x7FFE8111A020
    public void GetAxisRaw(){} // RVA: 0x7FFE87F16A60
    public void ClearLastPenContactEvent(){} // RVA: 0x7FFE87CE8AA0
    public void GetLastPenContactEvent(){} // RVA: 0x7FFE87F16AB0
    public void get_touchCount(){} // RVA: 0x7FFE87CE8FD0
    public void GetTouch(){} // RVA: 0x7FFE87F16B40
    public void get_mousePresent(){} // RVA: 0x7FFE87CE8F80
    public void GetMouseButtonDown(){} // RVA: 0x7FFE87F16BF0
    public void GetMouseButtonUp(){} // RVA: 0x7FFE87F16C40
    public void get_mousePosition(){} // RVA: 0x7FFE8111A2A0
    public void get_mouseButtonCount(){} // RVA: 0x7FFE817BF630
    public void get_anyKey(){} // RVA: 0x7FFE87CE8BE0
    public void get_unscaledTime(){} // RVA: 0x7FFE87A27750
    public void get_doubleClickTime(){} // RVA: 0x7FFE87F16C90
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class InputActionReferenceState : ValueType
{
}

public class InputEndFrame : ValueType
{
}

public class InputEventControlCollection : ValueType
{
    public UnityEngine.InputSystem.InputDevice m_Device; // 0x10

    // ── Methods ──
    public void get_eventPtr(){} // RVA: 0x7FFE826F4210
    public void GetEnumerator(){} // RVA: 0x7FFE87930DB0
    public void System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator(){} // RVA: 0x7FFE87930E10
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87930F10
}

public class InputEventControlEnumerator : ValueType
{
    public 0x6654014C m_Flags; // 0x10
    public UnityEngine.InputSystem.InputDevice m_Device; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87931010
    public void CheckDefault(){} // RVA: 0x7FFE87931320
    public void CheckCurrent(){} // RVA: 0x7FFE87931350
    public void MoveNext(){} // RVA: 0x7FFE87931380
    public void Reset(){} // RVA: 0x7FFE87931820
    public void Dispose(){} // RVA: 0x7FFE87931C90
    public void get_Current(){} // RVA: 0x7FFE81176730
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE81176730
}

public class InputMerger : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE80E4F230
}

public class InputNodeState : ValueType
{
}

public class InputPairing : Object
{
    // ── Methods ──
    public void GetKeyDown(){} // RVA: 0x7FFE8A446440
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class InputParameter : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81E853D0
}

public class InputState : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8164E250
}

public class InsightPassthroughKeyboardHandsIntensity : ValueType
{
}

public class InsightPassthroughStyle : ValueType
{
}

public class InstanceRefMethodCaller`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE80E460A0
    public void BeginInvoke(){} // RVA: 0x7FFE80E403A0
    public void EndInvoke(){} // RVA: 0x7FFE80E4F230
}

public class InstanceRefMethodCaller`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
    public void BeginInvoke(){} // RVA: 0x7FFE810A1420
    public void EndInvoke(){} // RVA: 0x7FFE80E4F230
}

public class InstanceRestoredDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE88190370
    public void Invoke(){} // RVA: 0x7FFE812574E0
    public void BeginInvoke(){} // RVA: 0x7FFE88190450
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class InstanceRestriction : BindingRestrictions
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8719F8B0
    public void Equals(){} // RVA: 0x7FFE8719F9C0
    public void GetHashCode(){} // RVA: 0x7FFE8719FA50
    public void GetExpression(){} // RVA: 0x7FFE8719FAA0
}

public class InstanceStorageIdDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE828B3700
    public void Invoke(){} // RVA: 0x7FFE81159A50
    public void BeginInvoke(){} // RVA: 0x7FFE81159A60
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class InstantiateMrcCameraDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86C7D0D0
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE86C7D1B0
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class InstantiationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE828B3580
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class Instruction : ValueType
{
}

public class InstructionView : ValueType
{
    // ── Methods ──
    public void GetName(){} // RVA: 0x7FFE87162E80
    public void GetValue(){} // RVA: 0x7FFE81116380
    public void GetDisplayType(){} // RVA: 0x7FFE87162F80
    public void .ctor(){} // RVA: 0x7FFE87163160
}

public class Int : Object
{
    // ── Methods ──
    public void TryParse(){} // RVA: 0x7FFE87359100
}

public class Int128 : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82AC4140 | overloaded x3
    public void IsNegative(){} // RVA: 0x7FFE82AC48D0
    public void op_Equality(){} // RVA: 0x7FFE82AC48E0
    public void op_Inequality(){} // RVA: 0x7FFE82AC49A0
    public void Equals(){} // RVA: 0x7FFE82AC4A60
    public void GetHashCode(){} // RVA: 0x7FFE82AC4AF0
    public void op_GreaterThan(){} // RVA: 0x7FFE82AC4B10
    public void op_LessThan(){} // RVA: 0x7FFE82AC4B30
    public void op_Addition(){} // RVA: 0x7FFE82AC4B50
    public void op_Subtraction(){} // RVA: 0x7FFE82AC4B80
    public void op_UnaryNegation(){} // RVA: 0x7FFE82AC4BF0
    public void op_Explicit(){} // RVA: 0x7FFE82AC4C30
    public void Int128Mul(){} // RVA: 0x7FFE82AC4CF0
}
