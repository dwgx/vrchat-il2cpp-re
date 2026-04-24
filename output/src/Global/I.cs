// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 71
// Methods: 284

public class IAllocator
{
    public object Handle;

    // ── Methods ──
    public void Try(){} // RVA: 0x7FFD4E07E6B0
    public void get_Handle(){} // RVA: 0x7FFD4E2ADC40
}

public class IConstraintSubstituteCreator
{
    // ── Methods ──
    public void CreateSubstituteComponent(){} // RVA: 0x7FFD4E2ADC40
}

public class IEncryption
{
    // ── Methods ──
    public void Encrypt(){} // RVA: 0x7FFD4E08A6F0
    public void TryDecrypt(){}
}

public class IInputAxisProvider
{
    // ── Methods ──
    public void GetAxisValue(){} // RVA: 0x7FFD4E08DC30
}

public class IJobSortable
{
    public object SortingBaseTransform;
    public object MaximumExecutionGroups;
    public object ExecutionGroup;

    // ── Methods ──
    public void get_SortingBaseTransform(){} // RVA: 0x7FFD4E078E90
    public void get_MaximumExecutionGroups(){} // RVA: 0x7FFD4E079960
    public void GetKnownDependencies(){} // RVA: 0x7FFD4E090A40
    public void get_ExecutionGroup(){} // RVA: 0x7FFD4E079960
    public void set_ExecutionGroup(){} // RVA: 0x7FFD4E090ED0
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

public class IListWrapper : ArrayList
{
    public System.Collections.IList Capacity; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD539BDA70
    public void set_Capacity(){} // RVA: 0x7FFD539BDAF0
    public void get_Count(){} // RVA: 0x7FFD539BDB80
    public void get_IsReadOnly(){} // RVA: 0x7FFD539BDBD0
    public void get_IsFixedSize(){} // RVA: 0x7FFD539BDC20
    public void get_IsSynchronized(){} // RVA: 0x7FFD539BDC70
    public void get_Item(){} // RVA: 0x7FFD539BDCC0
    public void set_Item(){} // RVA: 0x7FFD539BDD20
    public void get_SyncRoot(){} // RVA: 0x7FFD539BDDA0
    public void Add(){} // RVA: 0x7FFD539BDDF0
    public void AddRange(){} // RVA: 0x7FFD539BDE60
    public void Clear(){} // RVA: 0x7FFD539BDEB0
    public void Clone(){} // RVA: 0x7FFD539BDF70
    public void Contains(){} // RVA: 0x7FFD539BDFD0
    public void CopyTo(){} // RVA: 0x7FFD539BE0A0 | overloaded x2
    public void GetEnumerator(){} // RVA: 0x7FFD539BE3D0
    public void IndexOf(){} // RVA: 0x7FFD539BE420
    public void Insert(){} // RVA: 0x7FFD539BE480
    public void InsertRange(){} // RVA: 0x7FFD539BE500
    public void Remove(){} // RVA: 0x7FFD539BD240
    public void RemoveAt(){} // RVA: 0x7FFD539BE880
    public void RemoveRange(){} // RVA: 0x7FFD539BE8F0
    public void Reverse(){} // RVA: 0x7FFD539BEAF0
    public void Sort(){} // RVA: 0x7FFD539BEED0
    public void ToArray(){} // RVA: 0x7FFD539BF250 | overloaded x2
}

public class IMDrawBuffer`1 : Object
{
    public UnityEngine.Mesh mesh; // 0x10
    public UnityEngine.Material material; // 0x18
    public int subMeshIndex; // 0x20
    public Unity.Collections.NativeArray`1<ÎÏÏÏÏÎÌÌÏÏÍÍÎÎÍÏÏ> meshProps; // 0x28
    public UnityEngine.GraphicsBuffer meshPropsBuffer; // 0x38
    public int instanceCount; // 0x40
    public int maxCapacity; // 0x44
    public UnityEngine.Bounds bounds; // 0x48
    public int layer; // 0x60
    public 0x664DADE8 _renderParams; // 0x68
    public UnityEngine.GraphicsBuffer bufferWithArgs; // 0xC8
    public IndirectDrawIndexedArgs[] bufferWithArgsData; // 0xD0
    public int propertiesId;

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFD4E092E60
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void Clear(){} // RVA: 0x7FFD4E090980
    public void Draw(){} // RVA: 0x7FFD4E090980
    public void UpdateCommandBuffers(){} // RVA: 0x7FFD4E090980
    public void UpdateInstanceData(){} // RVA: 0x7FFD4E090980
    public void BuildCommandBuffer(){} // RVA: 0x7FFD4E090A40
    public void Add(){} // RVA: 0x7FFD4E2ADC40
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class IMDrawLine : IMDrawBuffer`1
{
    // ── Methods ──
    public void Add(){} // RVA: 0x7FFD55279F60
    public void .ctor(){} // RVA: 0x7FFD5527A090
}

public class IMDrawShape : IMDrawBuffer`1
{
    // ── Methods ──
    public void Add(){} // RVA: 0x7FFD5527A0F0
    public void .ctor(){} // RVA: 0x7FFD5527A2A0
}

public class IMGUISendQueuedEvents : ValueType
{
}

public class IOVRMeshDataProvider
{
    // ── Methods ──
    public void GetMeshType(){} // RVA: 0x7FFD4E079960
}

public class IOVRMeshRendererDataProvider
{
    // ── Methods ──
    public void GetMeshRendererData(){}
}

public class IOVRSceneComponent
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFD4E090980
}

public class IOVRSkeletonDataProvider
{
    public object enabled;

    // ── Methods ──
    public void GetSkeletonType(){} // RVA: 0x7FFD4E079960
    public void GetSkeletonPoseData(){}
    public void get_enabled(){} // RVA: 0x7FFD4E079D00
}

public class IOVRSkeletonRendererDataProvider
{
    // ── Methods ──
    public void GetSkeletonRendererData(){}
}

public class IPLGainNudgeData : ValueType
{
    public float NearFieldILDNudgeEarRadius; // 0x10
    public float NearFieldILDNudgeEarTranslate; // 0x14
    public float NearFieldILDNudgeDistance; // 0x18
    public float NearFieldILDMaxNudge; // 0x1C
    public ÏÏÍÍÏÎÏÍ NearFieldGlobalBoostGain; // 0x20
    public ÏÌÍÍÍÎÍÏÌÎÎÏÎÏÌ NearFieldILDNudgeOnEarBoost; // 0x820
    public Xs NearFieldILDNudgeOffEarDuck; // 0x1020
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

public class ISealedAllowReference
{
}

public class ITypeConstructor`1
{
    // ── Methods ──
    public void Instantiate(){} // RVA: 0x7FFD4E2ADC40
    public void SetExplicitConstructor(){} // RVA: 0x7FFD4E090A40
}

public class IWebSocketReceiveResultGetter`1
{
    // ── Methods ──
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
}

public class Icons : ValueType
{
    public UnityEngine.Sprite sticker; // 0x10
    public UnityEngine.Sprite takePhoto; // 0x18
    public UnityEngine.Sprite gallery; // 0x20
    public UnityEngine.Sprite upload; // 0x28
}

public class IdManager : Object
{
    public int m_nextIdToTry; // 0x10
    public System.Collections.Generic.List`1<bool> m_freeIds; // 0x18

    // ── Methods ──
    public void GetId(){} // RVA: 0x7FFD4E079960
    public void ReturnId(){} // RVA: 0x7FFD4E090ED0
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class IdentityTokenChanged : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39CB80
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class IgnoreDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EF032D0
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4EF03450
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
    public 0x665C2940 UdonBehaviour; // 0x1C
    public 0x665C28E8 TextureInfo; // 0x20
    public string <ErrorMessage>k__BackingField; // 0x28
    public UnityEngine.Texture2D <Result>k__BackingField; // 0x30
    public float <Progress>k__BackingField; // 0x38
    public VRC.SDKBase.VRCUrl <Url>k__BackingField; // 0x40
    public UnityEngine.Material <Material>k__BackingField; // 0x48
    public VRC.Udon.Common.Interfaces.IUdonEventReceiver <UdonBehaviour>k__BackingField; // 0x50
    public 0x665C2418 <TextureInfo>k__BackingField; // 0x58

    // ── Methods ──
    public void get_State(){} // RVA: 0x7FFD4F8557F0
    public void set_State(){} // RVA: 0x7FFD4F8674D0
    public void get_Error(){} // RVA: 0x7FFD4E4FBBE0
    public void set_Error(){} // RVA: 0x7FFD4E9FB7A0
    public void get_ErrorMessage(){} // RVA: 0x7FFD4E36F130
    public void set_ErrorMessage(){} // RVA: 0x7FFD4E342E90
    public void get_Result(){} // RVA: 0x7FFD4E5F95E0
    public void set_Result(){} // RVA: 0x7FFD4E36F890
    public void get_SizeInMemoryBytes(){} // RVA: 0x7FFD57423650
    public void get_Progress(){} // RVA: 0x7FFD4EB36E90
    public void set_Progress(){} // RVA: 0x7FFD4EB37190
    public void get_Url(){} // RVA: 0x7FFD4E3BE740
    public void set_Url(){} // RVA: 0x7FFD4E369200
    public void get_Material(){} // RVA: 0x7FFD4E3BC730
    public void set_Material(){} // RVA: 0x7FFD4E3BC740
    public void get_UdonBehaviour(){} // RVA: 0x7FFD4E3E20E0
    public void set_UdonBehaviour(){} // RVA: 0x7FFD4E4994D0
    public void get_TextureInfo(){} // RVA: 0x7FFD4E409500
    public void set_TextureInfo(){} // RVA: 0x7FFD4E409510
    public void LoadImage(){} // RVA: 0x7FFD57423FA0 | overloaded x2
    public void DownloadImage(){} // RVA: 0x7FFD57424080 | overloaded x2
    public void .ctor(){} // RVA: 0x7FFD57423870
    public void StartDownload(){} // RVA: 0x7FFD57423AB0
    public void SetProgress(){} // RVA: 0x7FFD4EB37190
    public void RunUdonEventOnMainThreadAndRemoveFromQueue(){} // RVA: 0x7FFD57424290
    public void Dispose(){} // RVA: 0x7FFD574244B0
    public void CancelDownload(){} // RVA: 0x7FFD57424790
    public void Finalize(){} // RVA: 0x7FFD57424800
    public void <DownloadImage>g__SlicedTextureUpload|52_0(){} // RVA: 0x7FFD57424840
    public void <Dispose>g__DestroyAsync|54_0(){} // RVA: 0x7FFD57424A00
}

public class ImageInfo : ValueType
{
    public uint width; // 0x10
    public uint height; // 0x14
    public 0x665C24C8 format; // 0x18
}

public class ImageLoadSettings : ValueType
{
    public 0x665C25D0 _flags; // 0x10
    public uint _allocationLimit; // 0x14
    public uint _resolutionLimit; // 0x18
    public uint _targetWidth; // 0x1C
    public uint _targetHeight; // 0x20
    public 0x665C24C8 _outputFormatOverride; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FD09520
    public void GetAllocationLimit(){} // RVA: 0x7FFD57424B30
    public void SetAllocationLimit(){} // RVA: 0x7FFD57424B90
    public void GetResolutionLimit(){} // RVA: 0x7FFD57424C30
    public void SetResolutionLimit(){} // RVA: 0x7FFD57424C90
    public void GetVerticalFlip(){} // RVA: 0x7FFD4FD09270
    public void SetVerticalFlip(){} // RVA: 0x7FFD4FD092D0
    public void GetResizeResolution(){} // RVA: 0x7FFD57424D30
    public void SetResizeResolution(){} // RVA: 0x7FFD57424DD0
    public void SetFastResize(){} // RVA: 0x7FFD4FD09800
    public void GetFastResize(){} // RVA: 0x7FFD4FD097F0
    public void GetOutputFormatOverride(){} // RVA: 0x7FFD57424E70
    public void SetOutputFormatOverride(){} // RVA: 0x7FFD57424EC0
    public void SetGenerateMipMaps(){} // RVA: 0x7FFD4FD09960
    public void GetGenerateMipMaps(){} // RVA: 0x7FFD4FD09950
    public void HasFlag(){} // RVA: 0x7FFD4FD09320
}

public class ImageResult : ValueType
{
    public byte success; // 0x10
    public ImageInfo info; // 0x14
    public 0x665C2470 error; // 0x20
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
    public void .ctor(){} // RVA: 0x7FFD4F5E1290
}

public class ImpulseEvent : Object
{
    public float Expired; // 0x10
    public EnvelopeDefinition m_Envelope; // 0x18
    public Cinemachine.ISignalSource6D m_SignalSource; // 0x38
    public UnityEngine.Vector3 m_Position; // 0x40
    public float m_Radius; // 0x4C
    public 0x6658C020 m_DirectionMode; // 0x50
    public int m_Channel; // 0x54
    public 0x6658C078 m_DissipationMode; // 0x58
    public float m_DissipationDistance; // 0x5C
    public float m_CustomDissipation; // 0x60
    public float m_PropagationSpeed; // 0x64

    // ── Methods ──
    public void get_Expired(){} // RVA: 0x7FFD4FC79CE0
    public void Cancel(){} // RVA: 0x7FFD4FC79D90
    public void DistanceDecay(){} // RVA: 0x7FFD4FC79DD0
    public void GetDecayedSignal(){} // RVA: 0x7FFD4FC79F40
    public void Clear(){} // RVA: 0x7FFD4FC7A700
    public void .ctor(){} // RVA: 0x7FFD4E341310
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
    public void ReSeed(){} // RVA: 0x7FFD4FC787D0
    public void GetReaction(){} // RVA: 0x7FFD4FC78900
}

public class IndexedConverter`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
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
    public void set_indexCountPerInstance(){} // RVA: 0x7FFD4E78D8B0
    public void set_instanceCount(){} // RVA: 0x7FFD4F840230
    public void set_startIndex(){} // RVA: 0x7FFD4FDE7510
    public void set_baseVertexIndex(){} // RVA: 0x7FFD4FDE7530
    public void set_startInstance(){} // RVA: 0x7FFD4E3440C0
}

public class InheritVelocityModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D74AD0
    public void set_enabled(){} // RVA: 0x7FFD54D74B20
    public void get_mode(){} // RVA: 0x7FFD54D74B80
    public void set_mode(){} // RVA: 0x7FFD54D74BD0
    public void get_curve(){} // RVA: 0x7FFD54D74C30
    public void set_curve(){} // RVA: 0x7FFD54D74CA0
    public void get_curveMultiplier(){} // RVA: 0x7FFD54D74D00
    public void set_curveMultiplier(){} // RVA: 0x7FFD54D74D50
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D74AD0
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D74B20
    public void get_mode_Injected(){} // RVA: 0x7FFD54D74B80
    public void set_mode_Injected(){} // RVA: 0x7FFD54D74BD0
    public void get_curve_Injected(){} // RVA: 0x7FFD54D74DB0
    public void set_curve_Injected(){} // RVA: 0x7FFD54D74E10
    public void get_curveMultiplier_Injected(){} // RVA: 0x7FFD54D74D00
    public void set_curveMultiplier_Injected(){} // RVA: 0x7FFD54D74D50
}

public class InitializationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3C1190
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class InitializeDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3C1190
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class InputActionReferenceState : ValueType
{
    public int refCount; // 0x10
    public bool enabledByInputModule; // 0x14
}

public class InputEndFrame : ValueType
{
}

public class InputMerger : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E099B30
}

public class InputPairing : Object
{
    public string name; // 0x10
    public 0x664DD1A8[] unityKeys; // 0x18
    public string[] cInputKeys; // 0x20
    public bool value; // 0x28
    public bool lastValue; // 0x29

    // ── Methods ──
    public void GetKeyDown(){} // RVA: 0x7FFD574058D0
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class InputParameter : Object
{
    public string address; // 0x10
    public string type; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EFE01C0
}

public class InstanceRefMethodCaller`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E090A40
    public void BeginInvoke(){} // RVA: 0x7FFD4E08AE80
    public void EndInvoke(){} // RVA: 0x7FFD4E099B30
}

public class InstanceRefMethodCaller`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    public void BeginInvoke(){} // RVA: 0x7FFD4E2ADC40
    public void EndInvoke(){} // RVA: 0x7FFD4E099B30
}

public class InstantiateMrcCameraDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53CF39E0
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD53CF3AC0
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class InstantiationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EEF0660
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class Instruction : ValueType
{
    public int m_FullHash; // 0x10
    public Cinemachine.CinemachineVirtualCameraBase m_VirtualCamera; // 0x18
    public float m_ActivateAfter; // 0x20
    public float m_MinDuration; // 0x24
}

public class Int128 : ValueType
{
    public long hi; // 0x10
    public ulong lo; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC7BDA0 | overloaded x3
    public void IsNegative(){} // RVA: 0x7FFD4FC7C530
    public void op_Equality(){} // RVA: 0x7FFD4FC7C540
    public void op_Inequality(){} // RVA: 0x7FFD4FC7C600
    public void Equals(){} // RVA: 0x7FFD4FC7C6C0
    public void GetHashCode(){} // RVA: 0x7FFD4FC7C750
    public void op_GreaterThan(){} // RVA: 0x7FFD4FC7C770
    public void op_LessThan(){} // RVA: 0x7FFD4FC7C790
    public void op_Addition(){} // RVA: 0x7FFD4FC7C7B0
    public void op_Subtraction(){} // RVA: 0x7FFD4FC7C7E0
    public void op_UnaryNegation(){} // RVA: 0x7FFD4FC7C850
    public void op_Explicit(){} // RVA: 0x7FFD4FC7C890
    public void Int128Mul(){} // RVA: 0x7FFD4FC7C950
}

public class IntChildrenSection : ChildrenSection`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD56CF2290
}

public class IntPoint : ValueType
{
    public long X; // 0x10
    public long Y; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC7BDA0 | overloaded x3
    public void op_Equality(){} // RVA: 0x7FFD4FC7CA30
    public void op_Inequality(){} // RVA: 0x7FFD4FC7CA50
    public void Equals(){} // RVA: 0x7FFD4FC7CA70
    public void GetHashCode(){} // RVA: 0x7FFD4FC7CB00
}

public class IntRect : ValueType
{
    public long left; // 0x10
    public long top; // 0x18
    public long right; // 0x20
    public long bottom; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC7CB80 | overloaded x2
}

public class Internal : Object
{
    public int hash_code_of_ptr_seed;
}

public class InternalEnumerator`1 : ValueType
{
    public System.Array Current; // 0x10
    public int System.Collections.IEnumerator.Current; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class InternalPartitionEnumerable : Object
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.HashSet`1<VRC.Udon.UdonBehaviour>> _sharedReader; // 0x10
    public SharedLong _sharedIndex; // 0x18
    public System.Collections.Generic.KeyValuePair`2<long,System.Collections.Generic.HashSet`1<VRC.Udon.UdonBehaviour>>[] _fillBuffer; // 0x20
    public int _fillBufferSize; // 0x28
    public int _fillBufferCurrentPosition; // 0x2C
    public int _activeCopiers; // 0x30
    public SharedBool _hasNoElementsLeft; // 0x38
    public SharedBool _sourceDepleted; // 0x40
    public object _sharedLock; // 0x48
    public bool _disposed; // 0x50
    public SharedInt _activePartitionCount; // 0x58
    public bool _useSingleChunking; // 0x60

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E096590
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void TryCopyFromFillBuffer(){} // RVA: 0x7FFD4E0986D0
    public void GrabChunk(){}
    public void GrabChunk_Single(){}
    public void GrabChunk_Buffered(){}
    public void Dispose(){} // RVA: 0x7FFD4E090980
}

public class InternalPartitionEnumerator : DynamicPartitionEnumerator_Abstract`2
{
    public System.Collections.Generic.KeyValuePair`2<long,System.Collections.Generic.HashSet`1<VRC.Udon.UdonBehaviour>>[] HasNoElementsLeft; // 0x38
    public SharedBool Current; // 0x40
    public SharedInt _activePartitionCount; // 0x48
    public InternalPartitionEnumerable<System.Collections.Generic.HashSet`1<VRC.Udon.UdonBehaviour>> _enumerable; // 0x50

    // ── Methods ──
    public void .ctor(){}
    public void GrabNextChunk(){} // RVA: 0x7FFD4E07A310
    public void get_HasNoElementsLeft(){} // RVA: 0x7FFD4E079D00
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void Dispose(){} // RVA: 0x7FFD4E090980
}

public class Interop : Object
{
    // ── Methods ──
    public void GetRandomBytes(){} // RVA: 0x7FFD537A7590
    public void MemAlloc(){} // RVA: 0x7FFD537A76A0
}

public class IntersectNode : Object
{
    public TEdge Edge1; // 0x10
    public TEdge Edge2; // 0x18
    public IntPoint Pt; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class IntializationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3C1190
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class InvocationContext : Object
{
    public System.Threading.SendOrPostCallback m_Delegate; // 0x10
    public object m_State; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E90C240
    public void Invoke(){} // RVA: 0x7FFD52D143D0
}

public class InvocationEntryDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FD9DFD0
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class IsBurstEnabledDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD510CAD40
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
}

public class IsBurstEnabled_00000145$BurstDirectCall : Object
{
    public UIntPtr Pointer;
    public UIntPtr DeferredCompilation; // 0x8

    // ── Methods ──
    public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD54926840
    public void GetFunctionPointer(){} // RVA: 0x7FFD54926980
    public void Constructor(){} // RVA: 0x7FFD54926AF0
    public void Initialize(){} // RVA: 0x7FFD4E341310
    public void .cctor(){} // RVA: 0x7FFD54926AF0
    public void Invoke(){} // RVA: 0x7FFD54926BB0
}

public class IsBurstEnabled_00000145$PostfixBurstDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD510CAD40
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
}

public class IsCanceledSource : Object
{
    public Cysharp.Threading.Tasks.IUniTaskSource`1<System.Collections.Generic.IList`1<ÌÏÌÏÏÏÎÌÍÌÍÍÌÌÌÍÌÌÌÎÍÍÍ>> source; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class IsLocalDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EF032D0
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4EF03450
}

public class IsOfType`1 : Object
{
    public IsOfType`1<T> s_Instance;

    // ── Methods ──
    public void Predicate(){} // RVA: 0x7FFD4E079F60
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class IsRegistered`1 : Object
{
    public bool Value;
}

public class Item : ValueType
{
    public UnityEngine.Vector3 Empty; // 0x10
    public float weight; // 0x1C
    public float time; // 0x20

    // ── Methods ──
    public void Lerp(){} // RVA: 0x7FFD4FC70980
    public void get_Empty(){} // RVA: 0x7FFD4FC70AE0
}

public class Iterator`1 : Object
{
    public int Current; // 0x10
    public int System.Collections.IEnumerator.Current; // 0x14
    public VRC.SDKBase.Network.VRCNetworkBehaviour current; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD51359810
    public void get_Current(){} // RVA: 0x7FFD4E9F3330
    public void Clone(){} // RVA: 0x7FFD4E078E90
    public void Dispose(){} // RVA: 0x7FFD51359A90
    public void GetEnumerator(){} // RVA: 0x7FFD513598B0
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void Select(){} // RVA: 0x7FFD4E078F40
    public void Where(){} // RVA: 0x7FFD4E078F40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD51359AA0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD513599C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD510A5BA0
}

public class iOSInfo : Object
{
    public bool CacheDir;
    public long FreeDiskSpaceBytes;
    public System.Threading.Thread _pollMemoryStatusThread; // 0x8
    public long _cachedMemoryAvailable; // 0x10
    public string _cacheDir; // 0x18

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD53648480
    public void FetchInfo(){} // RVA: 0x7FFD53648490
    public void get_CacheDir(){} // RVA: 0x7FFD53648550
    public void CheckMemoryStatusThread(){} // RVA: 0x7FFD53648690
    public void PollMemoryStatus(){} // RVA: 0x7FFD53648950
    public void GetMemoryStatus(){} // RVA: 0x7FFD53648AC0
    public void FetchMemoryStatus(){} // RVA: 0x7FFD53648C30
    public void get_FreeDiskSpaceBytes(){} // RVA: 0x7FFD53648C40
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class iOSVibration : Object
{
    public System.Lazy`1<bool> SupportsVibration;

    // ── Methods ──
    public void Vibrate(){} // RVA: 0x7FFD4E341000
    public void VibrateSimple(){} // RVA: 0x7FFD4E341080
    public void .cctor(){} // RVA: 0x7FFD4E341100
}
