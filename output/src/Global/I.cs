// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 347

public class I
{
}

public class IActivationFactory : Object
{
    // ── Methods ──
    public void ActivateInstance(){} // RVA: 0x7FFAC2C58E90
}

public class IAllocator
{
    public object Handle;

    // ── Methods ──
    public void Try(){} // RVA: 0x7FFAC2C5E6B0
    public void get_Handle(){} // RVA: 0x7FFAC2E8DC40
}

public class IAttrList
{
    public object Length;
    public object Names;
    public object Values;

    // ── Methods ──
    public void get_Length(){} // RVA: 0x7FFAC2C59960
    public void GetName(){} // RVA: 0x7FFAC2C67DE0
    public void GetValue(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
    public void get_Names(){} // RVA: 0x7FFAC2C58E90
    public void get_Values(){} // RVA: 0x7FFAC2C58E90
}

public class IConstraintSubstituteCreator
{
    // ── Methods ──
    public void CreateSubstituteComponent(){} // RVA: 0x7FFAC2E8DC40
}

public class IContentHandler
{
    // ── Methods ──
    public void OnStartParsing(){} // RVA: 0x7FFAC2C70A40
    public void OnEndParsing(){} // RVA: 0x7FFAC2C70A40
    public void OnStartElement(){} // RVA: 0x7FFAC2C79B30
    public void OnEndElement(){} // RVA: 0x7FFAC2C70A40
    public void OnProcessingInstruction(){} // RVA: 0x7FFAC2C79B30
    public void OnChars(){} // RVA: 0x7FFAC2C70A40
    public void OnIgnorableWhitespace(){} // RVA: 0x7FFAC2C70A40
}

public class IEncryption
{
    // ── Methods ──
    public void Encrypt(){} // RVA: 0x7FFAC2C6A6F0
    public void TryDecrypt(){}
}

public class IExtensionReflectionHelper
{
    // ── Methods ──
    public void GetExtension(){} // RVA: 0x7FFAC2C58F40
    public void SetExtension(){} // RVA: 0x7FFAC2C79B30
    public void HasExtension(){} // RVA: 0x7FFAC2C59F60
    public void ClearExtension(){} // RVA: 0x7FFAC2C70A40
}

public class IFactoryControls
{
    // ── Methods ──
    public void CreateGameObject(){} // RVA: 0x7FFAC2C6A6F0
}

public class IInput
{
    public object touchCount;
    public object mousePresent;
    public object mousePosition;
    public object mouseButtonCount;
    public object anyKey;
    public object unscaledTime;
    public object doubleClickTime;

    // ── Methods ──
    public void GetButtonDown(){} // RVA: 0x7FFAC2C59F60
    public void GetAxisRaw(){} // RVA: 0x7FFAC2C6DF90
    public void ClearLastPenContactEvent(){} // RVA: 0x7FFAC2C70980
    public void GetLastPenContactEvent(){}
    public void get_touchCount(){} // RVA: 0x7FFAC2C59960
    public void GetTouch(){}
    public void get_mousePresent(){} // RVA: 0x7FFAC2C59D00
    public void GetMouseButtonDown(){} // RVA: 0x7FFAC2C5A310
    public void GetMouseButtonUp(){} // RVA: 0x7FFAC2C5A310
    public void get_mousePosition(){} // RVA: 0x7FFAC2C588A0
    public void get_mouseButtonCount(){} // RVA: 0x7FFAC2C59960
    public void get_anyKey(){} // RVA: 0x7FFAC2C59D00
    public void get_unscaledTime(){} // RVA: 0x7FFAC2C6D880
    public void get_doubleClickTime(){} // RVA: 0x7FFAC2C6D880
}

public class IInputAxisProvider
{
    // ── Methods ──
    public void GetAxisValue(){} // RVA: 0x7FFAC2C6DC30
}

public class IJobSortable
{
    public object SortingBaseTransform;
    public object MaximumExecutionGroups;
    public object ExecutionGroup;

    // ── Methods ──
    public void get_SortingBaseTransform(){} // RVA: 0x7FFAC2C58E90
    public void get_MaximumExecutionGroups(){} // RVA: 0x7FFAC2C59960
    public void GetKnownDependencies(){} // RVA: 0x7FFAC2C70A40
    public void get_ExecutionGroup(){} // RVA: 0x7FFAC2C59960
    public void set_ExecutionGroup(){} // RVA: 0x7FFAC2C70ED0
}

public class IKBone : ValueType
{
    public bool isSimulated; // 0x10
    public int boneIndex; // 0x14
    public Unity.Mathematics.float3 position; // 0x18
    public Unity.Mathematics.float3 endPosition; // 0x24
    public float length; // 0x30
    public Unity.Mathematics.float3 localAxis; // 0x34
    public UnityEngine.Quaternion rotationOffset; // 0x40
}

public class ILEmitResolverBuilderRuntimeContext : Object
{
    public object[] Constants; // 0x10
    public System.Func`2<System.IServiceProvider,object>[] Factories; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class IListWrapper : ArrayList
{
    public System.Collections.IList Capacity; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC859DA70
    public void set_Capacity(){} // RVA: 0x7FFAC859DAF0
    public void get_Count(){} // RVA: 0x7FFAC859DB80
    public void get_IsReadOnly(){} // RVA: 0x7FFAC859DBD0
    public void get_IsFixedSize(){} // RVA: 0x7FFAC859DC20
    public void get_IsSynchronized(){} // RVA: 0x7FFAC859DC70
    public void get_Item(){} // RVA: 0x7FFAC859DCC0
    public void set_Item(){} // RVA: 0x7FFAC859DD20
    public void get_SyncRoot(){} // RVA: 0x7FFAC859DDA0
    public void Add(){} // RVA: 0x7FFAC859DDF0
    public void AddRange(){} // RVA: 0x7FFAC859DE60
    public void Clear(){} // RVA: 0x7FFAC859DEB0
    public void Clone(){} // RVA: 0x7FFAC859DF70
    public void Contains(){} // RVA: 0x7FFAC859DFD0
    public void CopyTo(){} // RVA: 0x7FFAC859E0A0 | overloaded x2
    public void GetEnumerator(){} // RVA: 0x7FFAC859E3D0
    public void IndexOf(){} // RVA: 0x7FFAC859E420
    public void Insert(){} // RVA: 0x7FFAC859E480
    public void InsertRange(){} // RVA: 0x7FFAC859E500
    public void Remove(){} // RVA: 0x7FFAC859D240
    public void RemoveAt(){} // RVA: 0x7FFAC859E880
    public void RemoveRange(){} // RVA: 0x7FFAC859E8F0
    public void Reverse(){} // RVA: 0x7FFAC859EAF0
    public void Sort(){} // RVA: 0x7FFAC859EED0
    public void ToArray(){} // RVA: 0x7FFAC859F250 | overloaded x2
}

public class IMDrawBuffer`1 : Object
{
    public UnityEngine.Mesh mesh;
    public UnityEngine.Material material;
    public int subMeshIndex;
    public Unity.Collections.NativeArray`1<T> meshProps;
    public UnityEngine.GraphicsBuffer meshPropsBuffer;
    public int instanceCount;
    public int maxCapacity;
    public UnityEngine.Bounds bounds;
    public int layer;
    public UnityEngine.RenderParams _renderParams;
    public UnityEngine.GraphicsBuffer bufferWithArgs;
    public IndirectDrawIndexedArgs[] bufferWithArgsData;
    public int propertiesId;

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFAC2C72E60
    public void Dispose(){} // RVA: 0x7FFAC2C70980
    public void Clear(){} // RVA: 0x7FFAC2C70980
    public void Draw(){} // RVA: 0x7FFAC2C70980
    public void UpdateCommandBuffers(){} // RVA: 0x7FFAC2C70980
    public void UpdateInstanceData(){} // RVA: 0x7FFAC2C70980
    public void BuildCommandBuffer(){} // RVA: 0x7FFAC2C70A40
    public void Add(){} // RVA: 0x7FFAC2E8DC40
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class IMDrawLine : IMDrawBuffer`1
{
    // ── Methods ──
    public void Add(){} // RVA: 0x7FFAC9E59F60
    public void .ctor(){} // RVA: 0x7FFAC9E5A090
}

public class IMDrawShape : IMDrawBuffer`1
{
    // ── Methods ──
    public void Add(){} // RVA: 0x7FFAC9E5A0F0
    public void .ctor(){} // RVA: 0x7FFAC9E5A2A0
}

public class IMGUISendQueuedEvents : ValueType
{
}

public class IOVRMeshDataProvider
{
    // ── Methods ──
    public void GetMeshType(){} // RVA: 0x7FFAC2C59960
}

public class IOVRMeshRendererDataProvider
{
    // ── Methods ──
    public void GetMeshRendererData(){}
}

public class IOVRSceneComponent
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFAC2C70980
}

public class IOVRSkeletonDataProvider
{
    public object enabled;

    // ── Methods ──
    public void GetSkeletonType(){} // RVA: 0x7FFAC2C59960
    public void GetSkeletonPoseData(){}
    public void get_enabled(){} // RVA: 0x7FFAC2C59D00
}

public class IOVRSkeletonRendererDataProvider
{
    // ── Methods ──
    public void GetSkeletonRendererData(){}
}

public class IO_STATUS : ValueType
{
    public uint Status; // 0x10
    public UIntPtr Pointer; // 0x10
}

public class IO_STATUS_BLOCK : ValueType
{
    public IO_STATUS Status; // 0x10
    public UIntPtr Information; // 0x18
}

public class IPLGainNudgeData : ValueType
{
    public float NearFieldILDNudgeEarRadius; // 0x10
    public float NearFieldILDNudgeEarTranslate; // 0x14
    public float NearFieldILDNudgeDistance; // 0x18
    public float NearFieldILDMaxNudge; // 0x1C
    public <NearFieldGlobalBoostGain>e__FixedBuffer NearFieldGlobalBoostGain; // 0x20
    public <NearFieldILDNudgeOnEarBoost>e__FixedBuffer NearFieldILDNudgeOnEarBoost; // 0x820
    public <NearFieldILDNudgeOffEarDuck>e__FixedBuffer NearFieldILDNudgeOffEarDuck; // 0x1020
}

public class IPSQuery : ApiModel
{
    public string require; // 0x68
    public string include; // 0x70

    // ── Methods ──
    public void get_require(){} // RVA: 0x7FFAC2F9CD50
    public void set_require(){} // RVA: 0x7FFAC2F9CD60
    public void get_include(){} // RVA: 0x7FFAC2FE9590
    public void set_include(){} // RVA: 0x7FFAC2FE95A0
    public void .ctor(){} // RVA: 0x7FFACBE795C0
}

public class IPV4 : ValueType
{
    public ulong m_8zeros; // 0x10
    public ushort m_0000; // 0x18
    public ushort m_ffff; // 0x1A
    public byte ip0; // 0x1C
    public byte ip1; // 0x1D
    public byte ip2; // 0x1E
    public byte ip3; // 0x1F
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
    public void CreateFuncIMessageInt32(){} // RVA: 0x7FFAC2C58F40
    public void CreateActionIMessage(){} // RVA: 0x7FFAC2C58F40
    public void CreateFuncIMessageObject(){} // RVA: 0x7FFAC2C58F40
    public void CreateActionIMessageObject(){} // RVA: 0x7FFAC2C58F40
    public void CreateFuncIMessageBool(){} // RVA: 0x7FFAC2C58F40
}

public class ISealedAllowReference
{
}

public class ITokenReader
{
    // ── Methods ──
    public void Read(){} // RVA: 0x7FFAC2C59960
}

public class ITypeConstructor
{
    public object CanBeInstantiated;

    // ── Methods ──
    public void get_CanBeInstantiated(){} // RVA: 0x7FFAC2C59D00
    public void Instantiate(){} // RVA: 0x7FFAC2C58E90
}

public class ITypeConstructor`1
{
    // ── Methods ──
    public void Instantiate(){} // RVA: 0x7FFAC2E8DC40
    public void SetExplicitConstructor(){} // RVA: 0x7FFAC2C70A40
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
    public object name;

    // ── Methods ──
    public void get_name(){} // RVA: 0x7FFAC2C58E90
}

public class IUnimplemented
{
}

public class IVisualPredicateWrapper
{
    // ── Methods ──
    public void Predicate(){} // RVA: 0x7FFAC2C59F60
}

public class IWebSocketReceiveResultGetter`1
{
    // ── Methods ──
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
}

public class Icons : ValueType
{
    public UnityEngine.Sprite perfExcellent; // 0x10
    public UnityEngine.Sprite perfGood; // 0x18
    public UnityEngine.Sprite perfMedium; // 0x20
    public UnityEngine.Sprite perfPoor; // 0x28
    public UnityEngine.Sprite perfVeryPoor; // 0x30
    public UnityEngine.Sprite trustIcon; // 0x38
    public UnityEngine.Sprite trustIconVerified; // 0x40
    public UnityEngine.Sprite reasonBlocked; // 0x48
    public UnityEngine.Sprite reasonError; // 0x50
    public UnityEngine.Sprite reasonFiltered; // 0x58
    public UnityEngine.Sprite reasonSize; // 0x60
    public UnityEngine.Sprite reasonPlatform; // 0x68
    public UnityEngine.Sprite impostor; // 0x70
    public UnityEngine.Sprite fallback; // 0x78
    public UnityEngine.Sprite incompatible; // 0x80
    public UnityEngine.Sprite voiceGlowFull; // 0x88
    public UnityEngine.Sprite voiceGlowHalf; // 0x90
    public UnityEngine.Sprite voiceGlowGroupsFull; // 0x98
    public UnityEngine.Sprite voiceGlowGroupsHalf; // 0xA0
    public UnityEngine.Sprite voicePulseFull; // 0xA8
    public UnityEngine.Sprite voicePulseLeft; // 0xB0
    public UnityEngine.Sprite voicePulseRight; // 0xB8
}

public class IdManager : Object
{
    public int m_nextIdToTry;
    public System.Collections.Generic.List`1<bool> m_freeIds;

    // ── Methods ──
    public void GetId(){} // RVA: 0x7FFAC2C59960
    public void ReturnId(){} // RVA: 0x7FFAC2C70ED0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class IdentityTokenChanged : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class IgnoreDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3AE32D0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
}

public class IgnoresCaseHashtable : Object
{
    public System.Collections.IDictionary Keys; // 0x10
    public System.Collections.IDictionary Item; // 0x18

    // ── Methods ──
    public void Clear(){} // RVA: 0x7FFACBEBA7D0
    public void GetEnumerator(){} // RVA: 0x7FFACBEBA840
    public void get_Keys(){} // RVA: 0x7FFACBEBA890
    public void Remove(){} // RVA: 0x7FFACBEBA8E0
    public void get_Item(){} // RVA: 0x7FFACBEBAA20
    public void set_Item(){} // RVA: 0x7FFACBEBAB10
    public void get_Values(){} // RVA: 0x7FFACBEBAC50
    public void .ctor(){} // RVA: 0x7FFACBEBACA0
}

public class ImageDownloader : Object
{
    public string State;
    public float Error;
    public int ErrorMessage;
    public int Result;
    public int SizeInMemoryBytes;
    public float Progress;
    public System.Threading.CancellationTokenSource Url; // 0x10
    public int Material; // 0x18
    public 0x6B262940 UdonBehaviour; // 0x1C
    public 0x6B2628E8 TextureInfo; // 0x20
    public string <ErrorMessage>k__BackingField; // 0x28
    public UnityEngine.Texture2D <Result>k__BackingField; // 0x30
    public float <Progress>k__BackingField; // 0x38
    public VRC.SDKBase.VRCUrl <Url>k__BackingField; // 0x40
    public UnityEngine.Material <Material>k__BackingField; // 0x48
    public VRC.Udon.Common.Interfaces.IUdonEventReceiver <UdonBehaviour>k__BackingField; // 0x50
    public VRC.SDK3.Image.TextureInfo <TextureInfo>k__BackingField; // 0x58

    // ── Methods ──
    public void get_State(){} // RVA: 0x7FFAC44357F0
    public void set_State(){} // RVA: 0x7FFAC44474D0
    public void get_Error(){} // RVA: 0x7FFAC30DBBE0
    public void set_Error(){} // RVA: 0x7FFAC35DB7A0
    public void get_ErrorMessage(){} // RVA: 0x7FFAC2F4F130
    public void set_ErrorMessage(){} // RVA: 0x7FFAC2F22E90
    public void get_Result(){} // RVA: 0x7FFAC31D95E0
    public void set_Result(){} // RVA: 0x7FFAC2F4F890
    public void get_SizeInMemoryBytes(){} // RVA: 0x7FFACC003650
    public void get_Progress(){} // RVA: 0x7FFAC3716E90
    public void set_Progress(){} // RVA: 0x7FFAC3717190
    public void get_Url(){} // RVA: 0x7FFAC2F9E740
    public void set_Url(){} // RVA: 0x7FFAC2F49200
    public void get_Material(){} // RVA: 0x7FFAC2F9C730
    public void set_Material(){} // RVA: 0x7FFAC2F9C740
    public void get_UdonBehaviour(){} // RVA: 0x7FFAC2FC20E0
    public void set_UdonBehaviour(){} // RVA: 0x7FFAC30794D0
    public void get_TextureInfo(){} // RVA: 0x7FFAC2FE9500
    public void set_TextureInfo(){} // RVA: 0x7FFAC2FE9510
    public void LoadImage(){} // RVA: 0x7FFACC003FA0 | overloaded x2
    public void DownloadImage(){} // RVA: 0x7FFACC004080 | overloaded x2
    public void .ctor(){} // RVA: 0x7FFACC003870
    public void StartDownload(){} // RVA: 0x7FFACC003AB0
    public void SetProgress(){} // RVA: 0x7FFAC3717190
    public void RunUdonEventOnMainThreadAndRemoveFromQueue(){} // RVA: 0x7FFACC004290
    public void Dispose(){} // RVA: 0x7FFACC0044B0
    public void CancelDownload(){} // RVA: 0x7FFACC004790
    public void Finalize(){} // RVA: 0x7FFACC004800
    public void <DownloadImage>g__SlicedTextureUpload|52_0(){} // RVA: 0x7FFACC004840
    public void <Dispose>g__DestroyAsync|54_0(){} // RVA: 0x7FFACC004A00
}

public class ImageInfo : ValueType
{
    public uint width; // 0x10
    public uint height; // 0x14
    public 0x6B2624C8 format; // 0x18
}

public class ImageLoadSettings : ValueType
{
    public 0x6B2625D0 _flags; // 0x10
    public uint _allocationLimit; // 0x14
    public uint _resolutionLimit; // 0x18
    public uint _targetWidth; // 0x1C
    public uint _targetHeight; // 0x20
    public 0x6B2624C8 _outputFormatOverride; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC48E9520
    public void GetAllocationLimit(){} // RVA: 0x7FFACC004B30
    public void SetAllocationLimit(){} // RVA: 0x7FFACC004B90
    public void GetResolutionLimit(){} // RVA: 0x7FFACC004C30
    public void SetResolutionLimit(){} // RVA: 0x7FFACC004C90
    public void GetVerticalFlip(){} // RVA: 0x7FFAC48E9270
    public void SetVerticalFlip(){} // RVA: 0x7FFAC48E92D0
    public void GetResizeResolution(){} // RVA: 0x7FFACC004D30
    public void SetResizeResolution(){} // RVA: 0x7FFACC004DD0
    public void SetFastResize(){} // RVA: 0x7FFAC48E9800
    public void GetFastResize(){} // RVA: 0x7FFAC48E97F0
    public void GetOutputFormatOverride(){} // RVA: 0x7FFACC004E70
    public void SetOutputFormatOverride(){} // RVA: 0x7FFACC004EC0
    public void SetGenerateMipMaps(){} // RVA: 0x7FFAC48E9960
    public void GetGenerateMipMaps(){} // RVA: 0x7FFAC48E9950
    public void HasFlag(){} // RVA: 0x7FFAC48E9320
}

public class ImageResult : ValueType
{
    public byte success; // 0x10
    public ImageInfo info; // 0x14
    public 0x6B262470 error; // 0x20
}

public class ImmutableBox : InitializeLocalInstruction
{
    public object InstructionName; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC47EB5F0
    public void Run(){} // RVA: 0x7FFAC8DDCE80
    public void get_InstructionName(){} // RVA: 0x7FFAC8DDCFA0
}

public class ImmutableCollectionTypeInfo : Object
{
    public string ContractTypeName; // 0x10
    public string CreatedTypeName; // 0x18
    public string BuilderTypeName; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3000E00
    public void get_ContractTypeName(){} // RVA: 0x7FFAC2F3C380
    public void set_ContractTypeName(){} // RVA: 0x7FFAC2F22E30
    public void get_CreatedTypeName(){} // RVA: 0x7FFAC2F247C0
    public void set_CreatedTypeName(){} // RVA: 0x7FFAC2F87E80
    public void get_BuilderTypeName(){} // RVA: 0x7FFAC2F4F0C0
    public void set_BuilderTypeName(){} // RVA: 0x7FFAC2F4F0D0
}

public class ImmutableRefBox : InitializeLocalInstruction
{
    public object InstructionName;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void Run(){} // RVA: 0x7FFAC8DDCFE0
    public void get_InstructionName(){} // RVA: 0x7FFAC8DDD0A0
}

public class ImmutableValue : InitializeLocalInstruction
{
    public object InstructionName; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC47EB5F0
    public void Run(){} // RVA: 0x7FFAC8DDCD10
    public void BoxIfIndexMatches(){} // RVA: 0x7FFAC8DDCD90
    public void get_InstructionName(){} // RVA: 0x7FFAC8DDCE40
}

public class ImportStruct : ValueType
{
    public UnityEngine.UIElements.StyleSheet styleSheet; // 0x10
    public string[] mediaQueries; // 0x18
}

public class ImposterData : ScriptableObject
{
    public int CapturedAngleCount; // 0x18
    public int DataChunkStart; // 0x1C
    public UnityEngine.Texture2D ColorAtlas; // 0x20
    public UnityEngine.Vector3 PositionOffset; // 0x28
    public UnityEngine.Vector4 BindPoseRotation; // 0x34
    public System.Collections.Generic.List`1<UnityEngine.Vector4> CameraOffsets; // 0x48
    public int CameraOffsetsHash; // 0x50
    public string CameraOffsetsAdjacencyMapJson; // 0x58
    public System.Collections.Generic.List`1<UnityEngine.Vector4> CameraRotations; // 0x60
    public System.Collections.Generic.List`1<UnityEngine.Vector4> AtlasPosition; // 0x68
    public System.Collections.Generic.List`1<UnityEngine.Vector4> DepthAtlasPositions; // 0x70
    public System.Collections.Generic.List`1<UnityEngine.Vector4> BoundsCenter; // 0x78
    public System.Collections.Generic.List`1<UnityEngine.Vector4> BoundsSize; // 0x80
    public System.Collections.Generic.List`1<UnityEngine.Bounds> BoundingVolume; // 0x88

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC41C1290
}

public class ImpulseEvent : Object
{
    public float Expired; // 0x10
    public EnvelopeDefinition m_Envelope; // 0x18
    public Cinemachine.ISignalSource6D m_SignalSource; // 0x38
    public UnityEngine.Vector3 m_Position; // 0x40
    public float m_Radius; // 0x4C
    public 0x6B22C020 m_DirectionMode; // 0x50
    public int m_Channel; // 0x54
    public 0x6B22C078 m_DissipationMode; // 0x58
    public float m_DissipationDistance; // 0x5C
    public float m_CustomDissipation; // 0x60
    public float m_PropagationSpeed; // 0x64

    // ── Methods ──
    public void get_Expired(){} // RVA: 0x7FFAC4859CE0
    public void Cancel(){} // RVA: 0x7FFAC4859D90
    public void DistanceDecay(){} // RVA: 0x7FFAC4859DD0
    public void GetDecayedSignal(){} // RVA: 0x7FFAC4859F40
    public void Clear(){} // RVA: 0x7FFAC485A700
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ImpulseReaction : ValueType
{
    public Cinemachine.NoiseSettings m_SecondaryNoise; // 0x10
    public float m_AmplitudeGain; // 0x18
    public float m_FrequencyGain; // 0x1C
    public float m_Duration; // 0x20
    public float m_CurrentAmount; // 0x24
    public float m_CurrentTime; // 0x28
    public float m_CurrentDamping; // 0x2C
    public bool m_Initialized; // 0x30
    public UnityEngine.Vector3 m_NoiseOffsets; // 0x34

    // ── Methods ──
    public void ReSeed(){} // RVA: 0x7FFAC48587D0
    public void GetReaction(){} // RVA: 0x7FFAC4858900
}

public class IncrementDouble : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DB4100
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class IncrementInt16 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DB3950
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class IncrementInt32 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DB3A20
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class IncrementInt64 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DB3B40
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class IncrementSingle : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DB3FC0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class IncrementUInt16 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DB3C80
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class IncrementUInt32 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DB3D50
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class IncrementUInt64 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DB3E80
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class IndexExpressionProxy : Object
{
    public System.Linq.Expressions.IndexExpression Arguments; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D71840
    public void get_Arguments(){} // RVA: 0x7FFAC8D71920
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_Indexer(){} // RVA: 0x7FFAC37735E0
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Object(){} // RVA: 0x7FFAC356B610
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
}

public class IndexTree : RBTree`1
{
    public System.Data.Index _index; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8ECA970
    public void CompareNode(){} // RVA: 0x7FFAC8ECAA20
    public void CompareSateliteTreeNode(){} // RVA: 0x7FFAC8ECAA40
}

public class IndexedConverter`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
}

public class IndirectDrawIndexedArgs : ValueType
{
    public int indexCountPerInstance;
    public uint instanceCount; // 0x10
    public uint startIndex; // 0x14
    public uint baseVertexIndex; // 0x18
    public uint startInstance; // 0x1C
    public uint <startInstance>k__BackingField; // 0x20

    // ── Methods ──
    public void set_indexCountPerInstance(){} // RVA: 0x7FFAC336D8B0
    public void set_instanceCount(){} // RVA: 0x7FFAC4420230
    public void set_startIndex(){} // RVA: 0x7FFAC49C7510
    public void set_baseVertexIndex(){} // RVA: 0x7FFAC49C7530
    public void set_startInstance(){} // RVA: 0x7FFAC2F240C0
}

public class InfiniteTimer : Timer
{
    public int HasExpired; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC92C7C60
    public void get_HasExpired(){} // RVA: 0x7FFAC2F21320
    public void Cancel(){} // RVA: 0x7FFAC92C7C80
}

public class InfiniteTimerQueue : Queue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC39E8330
    public void CreateTimer(){} // RVA: 0x7FFAC92C7510
}

public class Info : ValueType
{
    public 0x6B262D60 State; // 0x10
    public string Key; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC669C7B0
}

public class InheritVelocityModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC9954AD0
    public void set_enabled(){} // RVA: 0x7FFAC9954B20
    public void get_mode(){} // RVA: 0x7FFAC9954B80
    public void set_mode(){} // RVA: 0x7FFAC9954BD0
    public void get_curve(){} // RVA: 0x7FFAC9954C30
    public void set_curve(){} // RVA: 0x7FFAC9954CA0
    public void get_curveMultiplier(){} // RVA: 0x7FFAC9954D00
    public void set_curveMultiplier(){} // RVA: 0x7FFAC9954D50
    public void get_enabled_Injected(){} // RVA: 0x7FFAC9954AD0
    public void set_enabled_Injected(){} // RVA: 0x7FFAC9954B20
    public void get_mode_Injected(){} // RVA: 0x7FFAC9954B80
    public void set_mode_Injected(){} // RVA: 0x7FFAC9954BD0
    public void get_curve_Injected(){} // RVA: 0x7FFAC9954DB0
    public void set_curve_Injected(){} // RVA: 0x7FFAC9954E10
    public void get_curveMultiplier_Injected(){} // RVA: 0x7FFAC9954D00
    public void set_curveMultiplier_Injected(){} // RVA: 0x7FFAC9954D50
}

public class InitConfig : ValueType
{
    public int minimumViewID; // 0x10
    public int maximumViewID; // 0x14
    public SendEventToPlayerDelegate sendEventToPlayer; // 0x18
    public SendEventToAllPlayersDelegate sendEventToAllPlayers; // 0x20
    public SetOwnerDelegate setOwner; // 0x28
    public ListPlayersDelegate listPlayers; // 0x30
    public LogDelegate log; // 0x38
    public LogDelegate warn; // 0x40
    public LogDelegate error; // 0x48
    public System.Collections.Generic.HashSet`1<int> managedPlayerViews; // 0x50
}

public class Initial : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8369190
}

public class InitializationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class InitializeDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class InlineRule : ValueType
{
    public UnityEngine.UIElements.StyleSheet sheet; // 0x10
    public UnityEngine.UIElements.StyleRule rule; // 0x18
    public 0x6B129770[] propertyIds; // 0x20
}

public class Input : Object
{
    public object touchCount;
    public object mousePresent;
    public object mousePosition;
    public object mouseButtonCount;
    public object anyKey;
    public object unscaledTime;
    public object doubleClickTime;

    // ── Methods ──
    public void GetButtonDown(){} // RVA: 0x7FFAC2F40020
    public void GetAxisRaw(){} // RVA: 0x7FFAC9B6E1C0
    public void ClearLastPenContactEvent(){} // RVA: 0x7FFAC9940200
    public void GetLastPenContactEvent(){} // RVA: 0x7FFAC9B6E210
    public void get_touchCount(){} // RVA: 0x7FFAC9940730
    public void GetTouch(){} // RVA: 0x7FFAC9B6E2A0
    public void get_mousePresent(){} // RVA: 0x7FFAC99406E0
    public void GetMouseButtonDown(){} // RVA: 0x7FFAC9B6E350
    public void GetMouseButtonUp(){} // RVA: 0x7FFAC9B6E3A0
    public void get_mousePosition(){} // RVA: 0x7FFAC2F402A0
    public void get_mouseButtonCount(){} // RVA: 0x7FFAC366FE20
    public void get_anyKey(){} // RVA: 0x7FFAC9940340
    public void get_unscaledTime(){} // RVA: 0x7FFAC967EFF0
    public void get_doubleClickTime(){} // RVA: 0x7FFAC9B6E3F0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class InputActionReferenceState : ValueType
{
    public int refCount; // 0x10
    public bool enabledByInputModule; // 0x14
}

public class InputEndFrame : ValueType
{
}

public class InputEventControlCollection : ValueType
{
    public UnityEngine.InputSystem.InputDevice eventPtr; // 0x10
    public UnityEngine.InputSystem.LowLevel.InputEventPtr m_EventPtr; // 0x18
    public 0x6B147228 m_Flags; // 0x20
    public float m_MagnitudeThreshold; // 0x24

    // ── Methods ──
    public void get_eventPtr(){} // RVA: 0x7FFAC4420220
    public void GetEnumerator(){} // RVA: 0x7FFAC9588670
    public void System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator(){} // RVA: 0x7FFAC95886D0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC95887D0
}

public class InputEventControlEnumerator : ValueType
{
    public 0x6B147228 Current; // 0x10
    public UnityEngine.InputSystem.InputDevice System.Collections.IEnumerator.Current; // 0x18
    public uint[] m_StateOffsetToControlIndex; // 0x20
    public int m_StateOffsetToControlIndexLength; // 0x28
    public UnityEngine.InputSystem.InputControl[] m_AllControls; // 0x30
    public byte* m_DefaultState; // 0x38
    public byte* m_CurrentState; // 0x40
    public byte* m_NoiseMask; // 0x48
    public UnityEngine.InputSystem.LowLevel.InputEventPtr m_EventPtr; // 0x50
    public UnityEngine.InputSystem.InputControl m_CurrentControl; // 0x58
    public int m_CurrentIndexInStateOffsetToControlIndexMap; // 0x60
    public uint m_CurrentControlStateBitOffset; // 0x64
    public byte* m_EventState; // 0x68
    public uint m_CurrentBitOffset; // 0x70
    public uint m_EndBitOffset; // 0x74
    public float m_MagnitudeThreshold; // 0x78

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC95888D0
    public void CheckDefault(){} // RVA: 0x7FFAC9588BE0
    public void CheckCurrent(){} // RVA: 0x7FFAC9588C10
    public void MoveNext(){} // RVA: 0x7FFAC9588C40
    public void Reset(){} // RVA: 0x7FFAC95890E0
    public void Dispose(){} // RVA: 0x7FFAC9589550
    public void get_Current(){} // RVA: 0x7FFAC2F9C730
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F9C730
}

public class InputMerger : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2C79B30
}

public class InputNodeState : ValueType
{
    public bool down; // 0x10
    public float t; // 0x14
    public UnityEngine.Vector2 vecT; // 0x18
}

public class InputPairing : Object
{
    public string name; // 0x10
    public 0x6B17D1A8[] unityKeys; // 0x18
    public string[] cInputKeys; // 0x20
    public bool value; // 0x28
    public bool lastValue; // 0x29

    // ── Methods ──
    public void GetKeyDown(){} // RVA: 0x7FFACBFE58D0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class InputParameter : Object
{
    public string address; // 0x10
    public string type; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3BC01C0
}

public class InputState : ValueType
{
    public int _count; // 0x10
    public int _startIndex; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC33D6D50
}

public class InsightPassthroughKeyboardHandsIntensity : ValueType
{
    public float LeftHandIntensity; // 0x10
    public float RightHandIntensity; // 0x14
}

public class InsightPassthroughStyle : ValueType
{
    public 0x6B1A85F8 Flags; // 0x10
    public float TextureOpacityFactor; // 0x14
    public Colorf EdgeColor; // 0x18
    public 0x6B1A85A0 TextureColorMapType; // 0x28
    public uint TextureColorMapDataSize; // 0x2C
    public UIntPtr TextureColorMapData; // 0x30
}

public class InstanceRefMethodCaller`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2C70A40
    public void BeginInvoke(){} // RVA: 0x7FFAC2C6AE80
    public void EndInvoke(){} // RVA: 0x7FFAC2C79B30
}

public class InstanceRefMethodCaller`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    public void BeginInvoke(){} // RVA: 0x7FFAC2E8DC40
    public void EndInvoke(){} // RVA: 0x7FFAC2C79B30
}

public class InstanceRestoredDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9DEB5C0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC9DEB6A0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class InstanceRestriction : BindingRestrictions
{
    public System.Linq.Expressions.Expression _expression; // 0x10
    public object _instance; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8DF7480
    public void Equals(){} // RVA: 0x7FFAC8DF7590
    public void GetHashCode(){} // RVA: 0x7FFAC8DF7620
    public void GetExpression(){} // RVA: 0x7FFAC8DF7670
}

public class InstanceStorageIdDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3AD07E0
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class InstantiateMrcCameraDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC88D39E0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC88D3AC0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class InstantiationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3AD0660
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class Instruction : ValueType
{
    public Cinemachine.CinemachineVirtualCameraBase m_VirtualCamera; // 0x10
    public float m_Hold; // 0x18
    public Cinemachine.CinemachineBlendDefinition m_Blend; // 0x20
}

public class InstructionView : ValueType
{
    public int _index; // 0x10
    public int _stackDepth; // 0x14
    public int _continuationsDepth; // 0x18
    public string _name; // 0x20
    public System.Linq.Expressions.Interpreter.Instruction _instruction; // 0x28

    // ── Methods ──
    public void GetName(){} // RVA: 0x7FFAC8DBAA50
    public void GetValue(){} // RVA: 0x7FFAC2F3C380
    public void GetDisplayType(){} // RVA: 0x7FFAC8DBAB50
    public void .ctor(){} // RVA: 0x7FFAC8DBAD30
}

public class Int : Object
{
    // ── Methods ──
    public void TryParse(){} // RVA: 0x7FFAC8FB0CE0
}
