// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 50
// Methods: 191

public class ExceptionResultSource : Object
{
    public System.Runtime.ExceptionServices.ExceptionDispatchInfo exception; // 0x10
    public bool calledGet; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5C5C7A0
    public void GetResult(){} // RVA: 0x7FFAC9491310
    public void GetStatus(){} // RVA: 0x7FFAC3026CB0
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC3026CB0
    public void OnCompleted(){} // RVA: 0x7FFAC5C5C990
    public void Finalize(){} // RVA: 0x7FFAC9491370
}

public class ExceptionResultSource`1 : Object
{
    public System.Runtime.ExceptionServices.ExceptionDispatchInfo exception;
    public bool calledGet;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
    public void Finalize(){} // RVA: 0x7FFAC2C70980
}

public class ExclusiveOrBoolean : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAF490
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ExclusiveOrByte : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAEF50
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ExclusiveOrInt16 : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAEBA0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ExclusiveOrInt32 : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAECB0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ExclusiveOrInt64 : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAEDC0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ExclusiveOrSByte : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAEA90
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ExclusiveOrUInt16 : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAF060
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ExclusiveOrUInt32 : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAF170
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ExclusiveOrUInt64 : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAF300
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ExecuteGameCenterCallbacks : ValueType
{
}

public class ExecuteHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8C6D8C0
    public void Invoke(){} // RVA: 0x7FFAC897DA00
    public void BeginInvoke(){} // RVA: 0x7FFAC8C6DA40
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class ExecuteHelper : Object
{
    public System.IO.Pipes.PipeStreamImpersonationWorker _userCode; // 0x10
    public Microsoft.Win32.SafeHandles.SafePipeHandle _handle; // 0x18
    public bool _mustRevert; // 0x20
    public int _impersonateErrorCode; // 0x24
    public int _revertImpersonateErrorCode; // 0x28
}

public class ExecuteJobFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){}
}

public class ExecuteMainThreadJobs : ValueType
{
}

public class ExecutionContextCallbackArgs : Object
{
    public uint _errorCode; // 0x10
    public uint _bytesWritten; // 0x14
    public System.Threading.Win32ThreadPoolNativeOverlapped* _overlapped; // 0x18
    public OverlappedData _data; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ExitStateDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5C4D540
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class ExpandoData : Object
{
    public ExpandoData Item;
    public System.Dynamic.ExpandoClass Version; // 0x10
    public object[] Length; // 0x18
    public int _version; // 0x20

    // ── Methods ──
    public void get_Item(){} // RVA: 0x7FFAC849C850
    public void set_Item(){} // RVA: 0x7FFAC8E04380
    public void get_Version(){} // RVA: 0x7FFAC30DBBE0
    public void get_Length(){} // RVA: 0x7FFAC5CC4BA0
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0 | overloaded x2
    public void UpdateClass(){} // RVA: 0x7FFAC8E04520
    public void GetAlignedSize(){} // RVA: 0x7FFAC8E047A0
    public void .cctor(){} // RVA: 0x7FFAC8E047B0
}

public class ExpectedPluginVersion : Object
{
    public string Windows;
    public string WinRT;
    public string Android;
    public string Apple;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ExperimentSegment : Object
{
    public string Key; // 0x10
    public System.Collections.Generic.Dictionary`2<string,string> Payload; // 0x18
    public string RawPayload; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3000E00
    public void get_Key(){} // RVA: 0x7FFAC2F3C380
    public void set_Key(){} // RVA: 0x7FFAC2F22E30
    public void get_Payload(){} // RVA: 0x7FFAC2F247C0
    public void set_Payload(){} // RVA: 0x7FFAC2F87E80
    public void get_RawPayload(){} // RVA: 0x7FFAC2F4F0C0
    public void set_RawPayload(){} // RVA: 0x7FFAC2F4F0D0
}

public class ExperimentsManager : Object
{
    public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> _name; // 0x10
    public ÌÌÎÍÎÍÌÏÌÍÏÏÏÏÏÌÍÏÏÎÎÏÍ _hideFlags; // 0x18
    public ÌÌÎÍÎÍÌÏÌÍÏÏÏÏÏÌÍÏÏÎÎÏÍ f_F9A; // 0x20

    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFAC2F22E30
    public void Equals(){} // RVA: 0x7FFAC2F4F0C0
    public void GetHashCode(){} // RVA: 0x7FFAC2F3C380
    public void op_Implicit(){} // RVA: 0x7FFAC2F4F0C0
    public void CompareBaseObjects(){} // RVA: 0x7FFAC2F22E30
    public void StaticInitialize(){} // RVA: 0x7FFAC3C81730
    public void GetCachedPtr(){} // RVA: 0x7FFAC2F247C0
    public void get_name(){} // RVA: 0x7FFAC3C81810
    public void set_name(){} // RVA: 0x7FFAC2F22E30
    public void .ctor(){} // RVA: 0x7FFAC3C818F0
    public void Instantiate(){} // RVA: 0x7FFAC2F247C0
}

public class Expression : Object
{
    public string[] rpnTokens; // 0x10
    public bool hasVariables; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9863B40
    public void Evaluate(){}
}

public class ExpressionIcons : ValueType
{
    public UnityEngine.Texture2D typeToggleOn; // 0x10
    public UnityEngine.Texture2D typeToggleOff; // 0x18
    public UnityEngine.Texture2D typeFolder; // 0x20
    public UnityEngine.Texture2D typeAxis; // 0x28
    public UnityEngine.Texture2D typeRadial; // 0x30
    public UnityEngine.Texture2D typePlayOn; // 0x38
    public UnityEngine.Texture2D typePlayOff; // 0x40
}

public class ExpressionQuoter : ExpressionVisitor
{
    public System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> _variables; // 0x10
    public System.Linq.Expressions.Interpreter.InterpretedFrame _frame; // 0x18
    public System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>> _shadowedVars; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8DF01A0
    public void VisitLambda(){} // RVA: 0x7FFAC2C58F40
    public void VisitBlock(){} // RVA: 0x7FFAC8DF0320
    public void VisitCatchBlock(){} // RVA: 0x7FFAC8DF0580
    public void VisitRuntimeVariables(){} // RVA: 0x7FFAC8DF0750
    public void MergeRuntimeVariables(){} // RVA: 0x7FFAC8DF0D50
    public void VisitParameter(){} // RVA: 0x7FFAC8DF0EA0
    public void GetBox(){} // RVA: 0x7FFAC8DF0FC0
}

public class ExtendedProtectionSelector : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6EA1B30
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class ExtensionComparer : Object
{
    public ExtensionComparer Instance;

    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC81B96D0
    public void GetHashCode(){} // RVA: 0x7FFAC81B9880
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFAC81B9980
}

public class ExtensionInfo : Object
{
    public 0x6B1EC490 NodeType; // 0x10
    public System.Type Type; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC47EB5F0
}

public class ExtensionRange : Object
{
    public Google.Protobuf.MessageParser`1<ExtensionRange> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public int Start; // 0x8
    public int HasStart; // 0x1C
    public int End; // 0xC
    public int HasEnd; // 0x20
    public Google.Protobuf.Reflection.ExtensionRangeOptions Options; // 0x28

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC81F31C0
    public void get_Descriptor(){} // RVA: 0x7FFAC81F3220
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81F32A0
    public void .ctor(){} // RVA: 0x7FFAC81F3350 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC81F3500
    public void get_Start(){} // RVA: 0x7FFAC81F36F0
    public void set_Start(){} // RVA: 0x7FFAC81F3760
    public void get_HasStart(){} // RVA: 0x7FFAC81F3770
    public void ClearStart(){} // RVA: 0x7FFAC81F3780
    public void get_End(){} // RVA: 0x7FFAC81F3790
    public void set_End(){} // RVA: 0x7FFAC81F3800
    public void get_HasEnd(){} // RVA: 0x7FFAC81F3810
    public void ClearEnd(){} // RVA: 0x7FFAC81F3820
    public void get_Options(){} // RVA: 0x7FFAC2F4F130
    public void set_Options(){} // RVA: 0x7FFAC2F22E90
    public void Equals(){} // RVA: 0x7FFAC81F3960 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC81F3A50
    public void ToString(){} // RVA: 0x7FFAC81F3AE0
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81F3B30
    public void CalculateSize(){} // RVA: 0x7FFAC81F3BE0
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81F4010
    public void .cctor(){} // RVA: 0x7FFAC81F4130
}

public class ExtensionReflectionHelper`2 : Object
{
    public Google.Protobuf.Extension extension;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void GetExtension(){} // RVA: 0x7FFAC2C58F40
    public void HasExtension(){} // RVA: 0x7FFAC2C59F60
    public void SetExtension(){} // RVA: 0x7FFAC2C79B30
    public void ClearExtension(){} // RVA: 0x7FFAC2C70A40
}

public class Extensions : Object
{
    public Google.Protobuf.Extension`2<Mediapipe.CalculatorOptions,Mediapipe.FlowLimiterCalculatorOptions> Ext;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC8278E00
}

public class ExtentsProperty : Property`2
{
    public object Name;

    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFAC99A6D60
    public void .ctor(){} // RVA: 0x7FFAC99A6DA0
}

public class ExternalForcesModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC9958560
    public void set_enabled(){} // RVA: 0x7FFAC99585B0
    public void get_multiplier(){} // RVA: 0x7FFAC9958610
    public void set_multiplier(){} // RVA: 0x7FFAC9958660
    public void get_multiplierCurve(){} // RVA: 0x7FFAC99586C0
    public void set_multiplierCurve(){} // RVA: 0x7FFAC9958730
    public void get_influenceFilter(){} // RVA: 0x7FFAC9958790
    public void set_influenceFilter(){} // RVA: 0x7FFAC99587E0
    public void get_influenceMask(){} // RVA: 0x7FFAC9958840
    public void set_influenceMask(){} // RVA: 0x7FFAC99588A0
    public void get_influenceCount(){} // RVA: 0x7FFAC9958900
    public void IsAffectedBy(){} // RVA: 0x7FFAC9958950
    public void AddInfluence(){} // RVA: 0x7FFAC99589B0
    public void RemoveInfluenceAtIndex(){} // RVA: 0x7FFAC9958A10
    public void RemoveInfluence(){} // RVA: 0x7FFAC9958A70 | overloaded x2
    public void RemoveAllInfluences(){} // RVA: 0x7FFAC9958AD0
    public void SetInfluence(){} // RVA: 0x7FFAC9958B20
    public void GetInfluence(){} // RVA: 0x7FFAC9958B90
    public void get_enabled_Injected(){} // RVA: 0x7FFAC9958560
    public void set_enabled_Injected(){} // RVA: 0x7FFAC99585B0
    public void get_multiplier_Injected(){} // RVA: 0x7FFAC9958610
    public void set_multiplier_Injected(){} // RVA: 0x7FFAC9958660
    public void get_multiplierCurve_Injected(){} // RVA: 0x7FFAC9958BF0
    public void set_multiplierCurve_Injected(){} // RVA: 0x7FFAC9958C50
    public void get_influenceFilter_Injected(){} // RVA: 0x7FFAC9958790
    public void set_influenceFilter_Injected(){} // RVA: 0x7FFAC99587E0
    public void get_influenceMask_Injected(){} // RVA: 0x7FFAC9958CB0
    public void set_influenceMask_Injected(){} // RVA: 0x7FFAC9958D10
    public void get_influenceCount_Injected(){} // RVA: 0x7FFAC9958900
    public void IsAffectedBy_Injected(){} // RVA: 0x7FFAC9958950
    public void AddInfluence_Injected(){} // RVA: 0x7FFAC99589B0
    public void RemoveInfluenceAtIndex_Injected(){} // RVA: 0x7FFAC9958A10
    public void RemoveInfluence_Injected(){} // RVA: 0x7FFAC9958A70
    public void RemoveAllInfluences_Injected(){} // RVA: 0x7FFAC9958AD0
    public void SetInfluence_Injected(){} // RVA: 0x7FFAC9958B20
    public void GetInfluence_Injected(){} // RVA: 0x7FFAC9958B90
}

public class ExternalSurfaceObjectCreated : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class ExtraDataPerTouchState : ValueType
{
    public UnityEngine.Vector2 accumulatedDelta; // 0x10
    public uint uniqueId; // 0x18
}

public class ExtraMessageTypesHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC884F730
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC884F800
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class ExtractKeyDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
}

public class EyeFov : ValueType
{
    public float UpFov; // 0x10
    public float DownFov; // 0x14
    public float LeftFov; // 0x18
    public float RightFov; // 0x1C
}

public class EyeGazeState : ValueType
{
    public Posef IsValid; // 0x10
    public float Confidence; // 0x2C
    public 0x6B1A5C08 _isValid; // 0x30

    // ── Methods ──
    public void get_IsValid(){} // RVA: 0x7FFAC89086E0
}

public class EyeGazesState : ValueType
{
    public EyeGazeState[] EyeGazes; // 0x10
    public double Time; // 0x18
}

public class EyeGazesStateInternal : ValueType
{
    public EyeGazeState EyeGazes_0; // 0x10
    public EyeGazeState EyeGazes_1; // 0x34
    public double Time; // 0x58
}

public class EyeMovements : Object
{
    public float confidence; // 0x10
    public float excitement; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACC01BE00
}

public class EyeRenderDesc : ValueType
{
    public UnityEngine.Vector2 resolution; // 0x10
    public UnityEngine.Vector2 fov; // 0x18
    public EyeFov fullFov; // 0x20
}

public class EyeRotationLimiterForExport : Object
{
    public string transformPath; // 0x10
    public RealisticEyeMovements.SerializableQuaternion defaultQ; // 0x18
    public RealisticEyeMovements.SerializableQuaternion lookUpQ; // 0x28
    public RealisticEyeMovements.SerializableQuaternion lookDownQ; // 0x38
    public bool isLookUpSet; // 0x48
    public bool isLookDownSet; // 0x49

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EyeRotations : Object
{
    public bool linked; // 0x10
    public UnityEngine.Quaternion left; // 0x14
    public UnityEngine.Quaternion right; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC322C870
}

public class EyeTexture : Object
{
    public UnityEngine.Texture2D texture; // 0x10
    public UIntPtr nativePointer; // 0x18

    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFAC47E25F0
    public void .ctor(){} // RVA: 0x7FFAC47E27C0
}

public class EyelidPositionBlendshape : Object
{
    public UnityEngine.SkinnedMeshRenderer skinnedMeshRenderer; // 0x10
    public float defaultWeight; // 0x18
    public float positionWeight; // 0x1C
    public int index; // 0x20
    public string name; // 0x28
    public bool isUsedInEalierConfig; // 0x30

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC4508030
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Initialize(){} // RVA: 0x7FFAC45084A0
    public void op_Implicit(){} // RVA: 0x7FFAC4508670
    public void CompareBaseObjects(){} // RVA: 0x7FFAC4508840
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC4508BD0
    public void GetCachedPtr(){} // RVA: 0x7FFAC4508DA0
    public void get_name(){} // RVA: 0x7FFAC4508F70
    public void set_name(){} // RVA: 0x7FFAC45093E0
    public void Instantiate(){} // RVA: 0x7FFAC4509770
    public void Equals(){} // RVA: 0x7FFAC4509BF0
    public void GetHashCode(){} // RVA: 0x7FFAC450A060
}

public class EyelidPositionBlendshapeForExport : Object
{
    public string skinnedMeshRendererPath; // 0x10
    public float defaultWeight; // 0x18
    public float positionWeight; // 0x1C
    public int index; // 0x20
    public string name; // 0x28
    public bool isUsedInEalierConfig; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EyelidRotationLimiterForExport : Object
{
    public string transformPath; // 0x10
    public RealisticEyeMovements.SerializableQuaternion defaultQ; // 0x18
    public RealisticEyeMovements.SerializableQuaternion closedQ; // 0x28
    public RealisticEyeMovements.SerializableQuaternion lookUpQ; // 0x38
    public RealisticEyeMovements.SerializableQuaternion lookDownQ; // 0x48
    public float eyeMaxDownAngle; // 0x58
    public float eyeMaxUpAngle; // 0x5C
    public RealisticEyeMovements.SerializableVector3 defaultPos; // 0x60
    public RealisticEyeMovements.SerializableVector3 closedPos; // 0x6C
    public RealisticEyeMovements.SerializableVector3 lookUpPos; // 0x78
    public RealisticEyeMovements.SerializableVector3 lookDownPos; // 0x84
    public bool isLookUpSet; // 0x90
    public bool isLookDownSet; // 0x91
    public bool isDefaultPosSet; // 0x92
    public bool isClosedPosSet; // 0x93
    public bool isLookUpPosSet; // 0x94
    public bool isLookDownPosSet; // 0x95

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EyelidRotations : Object
{
    public EyeRotations upper; // 0x10
    public EyeRotations lower; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}
