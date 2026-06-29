// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 575

public class LabelExpressionProxy : Object
{
    public object _node;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x70493E0
    public void get_CanReduce(){} // RVA: 0x10AD460
    public void get_DebugView(){} // RVA: 0x7048AD0
    public void get_DefaultValue(){} // RVA: 0x13F9400
    public void get_NodeType(){} // RVA: 0x10AD380
    public void get_Target(){} // RVA: 0x13F9340
    public void get_Type(){} // RVA: 0x10ACB60
}

public class LambdaExpressionProxy : Object
{
    public object _node;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x70494C0
    public void get_Body(){} // RVA: 0x13F9340
    public void get_CanReduce(){} // RVA: 0x10AD460
    public void get_DebugView(){} // RVA: 0x7048AD0
    public void get_Name(){} // RVA: 0x10AD020
    public void get_NodeType(){} // RVA: 0x10AD380
    public void get_Parameters(){} // RVA: 0x10AD890
    public void get_ReturnType(){} // RVA: 0x70495A0
    public void get_TailCall(){} // RVA: 0x10AE060
    public void get_Type(){} // RVA: 0x10ACB60
}

public class LambdaSignature`1 : Object
{
    public object s_instance;
    public object Parameters;
    public object ReturnLabel;

    // ── Methods ──
    public void get_Instance(){} // RVA: 0x87C0D0
    public void .ctor(){} // RVA: 0x894290
}

public class LastActiveSpanTracker : Object
{
    public object _lock;
    public object _trackedSpans;

    // ── Methods ──
    public void get_TrackedSpans(){} // RVA: 0x6E3A420
    public void Push(){} // RVA: 0x6E3A470
    public void PeekActive(){} // RVA: 0x6E3A5F0
    public void Clear(){} // RVA: 0x6E3A880
    public void .ctor(){} // RVA: 0x6E3AA00
}

public class LaterInitParam : Object
{
    public object useAsync;
    public object inputStream;
    public object inputBytes;
    public object inputByteCount;
    public object inputbaseUri;
    public object inputUriStr;
    public object inputUriResolver;
    public object inputContext;
    public object inputTextReader;
    public object initType;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x748CF20
}

public class Layer : Object
{
    public object Weight;
    public object Hash;
    public object NormalizedTime;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class LayerDesc : ValueType
{
    public object Shape;
    public object Layout;
    public object TextureSize;
    public object MipLevels;
    public object SampleCount;
    public object Format;
    public object LayerFlags;
    public object Fov;
    public object VisibleRect;
    public object MaxViewportSize;
    public object DepthFormat;
    public object MotionVectorFormat;
    public object MotionVectorDepthFormat;
    public object MotionVectorTextureSize;

    // ── Methods ──
    public void ToString(){} // RVA: 0x8CB300
}

public class LayerDescInternal : ValueType
{
    public object Shape;
    public object Layout;
    public object TextureSize;
    public object MipLevels;
    public object SampleCount;
    public object Format;
    public object LayerFlags;
    public object Fov0;
    public object Fov1;
    public object VisibleRect0;
    public object VisibleRect1;
    public object MaxViewportSize;
    public object DepthFormat;
    public object MotionVectorFormat;
    public object MotionVectorDepthFormat;
    public object MotionVectorTextureSize;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8CB310
    public void ToLayerDesc(){} // RVA: 0x8CB360
}

public class LayerTexture[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E320
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A900
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4160
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E345E0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A900
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Layer[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class LayoutJson : ValueType
{
    public object name;
    public object extend;
    public object extendMultiple;
    public object format;
    public object beforeRender;
    public object runInBackground;
    public object commonUsages;
    public object displayName;
    public object description;
    public object type;
    public object variant;
    public object isGenericTypeOfDevice;
    public object hideInUI;
    public object controls;

    // ── Methods ──
    public void ToLayout(){} // RVA: 0x93E410
    public void FromLayout(){} // RVA: 0x7945CC0
}

public class LayoutLogData : Object
{
    public object node;
    public object eventType;
    public object message;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class LayoutNotFoundException : Exception
{
    public object _layout;

    // ── Methods ──
    public void get_layout(){} // RVA: 0x1069350
    public void .ctor(){} // RVA: 0x7815D80
}

public class LeftShiftByte : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7095230
    public void .ctor(){} // RVA: 0xB43310
}

public class LeftShiftInt16 : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7094ED0
    public void .ctor(){} // RVA: 0xB43310
}

public class LeftShiftInt32 : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7094FD0
    public void .ctor(){} // RVA: 0xB43310
}

public class LeftShiftInt64 : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70950C0
    public void .ctor(){} // RVA: 0xB43310
}

public class LeftShiftSByte : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7094DD0
    public void .ctor(){} // RVA: 0xB43310
}

public class LeftShiftUInt16 : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7095330
    public void .ctor(){} // RVA: 0xB43310
}

public class LeftShiftUInt32 : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7095430
    public void .ctor(){} // RVA: 0xB43310
}

public class LeftShiftUInt64 : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70955A0
    public void .ctor(){} // RVA: 0xB43310
}

public class Leg : BodyPart
{
    public object target;
    public object bendGoal;
    public object positionWeight;
    public object rotationWeight;
    public object bendGoalWeight;
    public object swivelOffset;
    public object bendToTargetWeight;
    public object legLengthMlp;
    public object stretchCurve;
    public object IKPosition;
    public object IKRotation;
    public object footPositionOffset;
    public object heelPositionOffset;
    public object footRotationOffset;
    public object currentMag;
    public object useAnimatedBendNormal;
    public object _position;
    public object _rotation;
    public object _hasToes;
    public object VrcAllowToes;
    public object _thighRelativeToPelvis;
    public object vrcUseKneeTarget;
    public object vrcUseForcedBendNormal;
    public object vrcForcedBendNormal;
    public object footPosition;
    public object footRotation;
    public object bendNormal;
    public object calfRelToThigh;
    public object thighRelToFoot;
    public object bendNormalRelToPelvis;
    public object bendNormalRelToTarget;
    public object vrcBendNormalRelToFoot;
    public object vrcLegTwistFromBendDir;

    // ── Methods ──
    public void get_position(){} // RVA: 0xC77DF0
    public void set_position(){} // RVA: 0xC77E10
    public void get_rotation(){} // RVA: 0xC77E30
    public void set_rotation(){} // RVA: 0xC77E40
    public void get_hasToes(){} // RVA: 0xC77E50
    public void set_hasToes(){} // RVA: 0xC77E60
    public void get_thigh(){} // RVA: 0xC6A3E0
    public void get_calf(){} // RVA: 0xC77E70
    public void get_foot(){} // RVA: 0xC77EA0
    public void get_toes(){} // RVA: 0xC77ED0
    public void get_lastBone(){} // RVA: 0xC77F00
    public void get_thighRelativeToPelvis(){} // RVA: 0xBAE560
    public void set_thighRelativeToPelvis(){} // RVA: 0xBAE580
    public void OnRead(){} // RVA: 0xC77F40
    public void PreSolve(){} // RVA: 0xC78CC0
    public void ApplyOffsets(){} // RVA: 0xC79C00
    public void ApplyPositionOffset(){} // RVA: 0xC7AAA0
    public void ApplyRotationOffset(){} // RVA: 0xC7AB50
    public void Solve(){} // RVA: 0xC7B1D0
    public void VrcFindKneeTargetBend(){} // RVA: 0xC7B4C0
    public void FixTwistRotations(){} // RVA: 0xC7B770
    public void Stretching(){} // RVA: 0xC7C290
    public void Write(){} // RVA: 0xC7C900
    public void ResetOffsets(){} // RVA: 0xC7CBC0
    public void .ctor(){} // RVA: 0xC7CCA0
}

public class Leg : Object
{
    public object _isGrounded;
    public object _iKPosition;
    public object rotationOffset;
    public object _initiated;
    public object _heightFromGround;
    public object _velocity;
    public object _transform;
    public object _iKOffset;
    public object invertFootCenter;
    public object _heelHit;
    public object _capsuleHit;
    public object grounding;
    public object lastTime;
    public object deltaTime;
    public object lastPosition;
    public object toHitNormal;
    public object r;
    public object up;
    public object doOverrideFootPosition;
    public object overrideFootPosition;
    public object transformPosition;

    // ── Methods ──
    public void get_isGrounded(){} // RVA: 0xC120A0
    public void set_isGrounded(){} // RVA: 0xC120B0
    public void get_IKPosition(){} // RVA: 0xC120C0
    public void set_IKPosition(){} // RVA: 0xC120E0
    public void get_initiated(){} // RVA: 0xB68DF0
    public void set_initiated(){} // RVA: 0xB68E00
    public void get_heightFromGround(){} // RVA: 0xC120F0
    public void set_heightFromGround(){} // RVA: 0xC12100
    public void get_velocity(){} // RVA: 0xBA9C60
    public void set_velocity(){} // RVA: 0xBA9C80
    public void get_transform(){} // RVA: 0xBBF8F0
    public void set_transform(){} // RVA: 0xBBF900
    public void get_IKOffset(){} // RVA: 0xBAB430
    public void set_IKOffset(){} // RVA: 0xBAB440
    public void get_heelHit(){} // RVA: 0xC12110
    public void set_heelHit(){} // RVA: 0xC12140
    public void get_capsuleHit(){} // RVA: 0xC12170
    public void set_capsuleHit(){} // RVA: 0xC121A0
    public void get_GetHitPoint(){} // RVA: 0xC121D0
    public void SetFootPosition(){} // RVA: 0xC12250
    public void Initiate(){} // RVA: 0xC12270
    public void OnEnable(){} // RVA: 0xC12580
    public void Reset(){} // RVA: 0xC126B0
    public void Process(){} // RVA: 0xC128C0
    public void get_stepHeightFromGround(){} // RVA: 0xC138F0
    public void GetCapsuleHit(){} // RVA: 0xC13930
    public void GetRaycastHit(){} // RVA: 0xC140A0
    public void RotateNormal(){} // RVA: 0xC14600
    public void SetFootToPoint(){} // RVA: 0xC14720
    public void SetFootToPlane(){} // RVA: 0xC14830
    public void GetHeightFromGround(){} // RVA: 0xC14C10
    public void RotateFoot(){} // RVA: 0xC14E00
    public void GetRotationOffsetTarget(){} // RVA: 0xC14F90
    public void get_rootYOffset(){} // RVA: 0xC150B0
    public void .ctor(){} // RVA: 0xC15240
}

public class Leg[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Leg[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class LegacyInputProcessor : Object
{
    public object m_SendingTouchEvents;
    public object m_SendingPenEvent;
    public object m_CurrentModifiers;
    public object m_LastMousePressButton;
    public object m_NextMousePressTime;
    public object m_LastMouseClickCount;
    public object m_LastMousePosition;
    public object m_MouseProcessedAtLeastOnce;
    public object m_Input;
    public object m_Event;
    public object m_EventSystem;
    public object m_ConsecutiveMoveCount;
    public object m_LastMoveVector;
    public object m_PrevActionTime;
    public object m_IsMoveFromKeyboard;

    // ── Methods ──
    public void get_m_CurrentPointerModifiers(){} // RVA: 0x8043000
    public void get_input(){} // RVA: 0x8043010
    public void .ctor(){} // RVA: 0x8043080
    public void GetDefaultInput(){} // RVA: 0x8043220
    public void ProcessLegacyInputEvents(){} // RVA: 0x8043300
    public void SendIMGUIEvents(){} // RVA: 0x80433E0
    public void ProcessMouseEvents(){} // RVA: 0x8043D00
    public void SendInputEvents(){} // RVA: 0x8044740
    public void ProcessTouchEvents(){} // RVA: 0x8044BB0
    public void ProcessPenEvents(){} // RVA: 0x8045230
    public void GetRawMoveVector(){} // RVA: 0x8045650
    public void ShouldSendMoveFromInput(){} // RVA: 0x80457F0
    public void ProcessTabEvent(){} // RVA: 0x8045A70
}

public class LessThanByte : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x7096BC0
}

public class LessThanChar : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x7096820
}

public class LessThanDouble : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x70971D0
}

public class LessThanInt16 : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x70966E0
}

public class LessThanInt32 : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x7096960
}

public class LessThanInt64 : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x7096A90
}

public class LessThanOrEqualByte : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x70987C0
}

public class LessThanOrEqualChar : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x7098420
}

public class LessThanOrEqualDouble : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x7098DD0
}

public class LessThanOrEqualInt16 : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x70982E0
}

public class LessThanOrEqualInt32 : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x7098560
}

public class LessThanOrEqualInt64 : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x7098690
}

public class LessThanOrEqualSByte : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x70981B0
}

public class LessThanOrEqualSingle : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x7098C90
}

public class LessThanOrEqualUInt16 : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x70988F0
}

public class LessThanOrEqualUInt32 : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x7098A30
}

public class LessThanOrEqualUInt64 : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x7098B60
}

public class LessThanSByte : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x70965B0
}

public class LessThanSingle : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x7097090
}

public class LessThanUInt16 : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x7096CF0
}

public class LessThanUInt32 : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x7096E30
}

public class LessThanUInt64 : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Run(){} // RVA: 0x7096F60
}

public class LicFileLicense : License
{
    public object _owner;
    public object _licenseKey;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x17C92C0
    public void get_LicenseKey(){} // RVA: 0xB465B0
    public void Dispose(){} // RVA: 0x76C69E0
}

public class LifetimeByEmitterSpeedModule : ValueType
{
    public object m_ParticleSystem;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
}

public class LightsModule : ValueType
{
    public object m_ParticleSystem;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_enabled(){} // RVA: 0x980C50
    public void set_enabled(){} // RVA: 0x980CA0
    public void get_ratio(){} // RVA: 0x980CB0
    public void set_ratio(){} // RVA: 0x980D00
    public void get_useRandomDistribution(){} // RVA: 0x980D10
    public void set_useRandomDistribution(){} // RVA: 0x980D60
    public void get_light(){} // RVA: 0x980D70
    public void set_light(){} // RVA: 0x980D80
    public void get_useParticleColor(){} // RVA: 0x980D90
    public void set_useParticleColor(){} // RVA: 0x980DE0
    public void get_sizeAffectsRange(){} // RVA: 0x980DF0
    public void set_sizeAffectsRange(){} // RVA: 0x980E40
    public void get_alphaAffectsIntensity(){} // RVA: 0x980E50
    public void set_alphaAffectsIntensity(){} // RVA: 0x980EA0
    public void get_range(){} // RVA: 0x980EB0
    public void set_range(){} // RVA: 0x980EE0
    public void get_rangeBlittable(){} // RVA: 0x980F10
    public void set_rangeBlittable(){} // RVA: 0x980FA0
    public void get_rangeMultiplier(){} // RVA: 0x981010
    public void set_rangeMultiplier(){} // RVA: 0x981060
    public void get_intensity(){} // RVA: 0x981070
    public void set_intensity(){} // RVA: 0x9810A0
    public void get_intensityBlittable(){} // RVA: 0x9810D0
    public void set_intensityBlittable(){} // RVA: 0x981160
    public void get_intensityMultiplier(){} // RVA: 0x9811D0
    public void set_intensityMultiplier(){} // RVA: 0x981220
    public void get_maxLights(){} // RVA: 0x981230
    public void set_maxLights(){} // RVA: 0x981280
    public void get_light_Injected(){} // RVA: 0x7CD3250
    public void set_light_Injected(){} // RVA: 0x7CD32A0
    public void get_rangeBlittable_Injected(){} // RVA: 0x7CD3300
    public void set_rangeBlittable_Injected(){} // RVA: 0x7CD3360
    public void get_intensityBlittable_Injected(){} // RVA: 0x7CD33C0
    public void set_intensityBlittable_Injected(){} // RVA: 0x7CD3420
}

public class LimbOrientation : Object
{
    public object upperBoneForwardAxis;
    public object lowerBoneForwardAxis;
    public object lastBoneLeftAxis;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB8B840
}

public class LimitPoint : Object
{
    public object point;
    public object tangentWeight;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xCB6C90
}

public class LimitPoint[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class LimitVelocityOverLifetimeModule : ValueType
{
    public object m_ParticleSystem;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_enabled(){} // RVA: 0x97B120
    public void set_enabled(){} // RVA: 0x97B170
    public void get_limitX(){} // RVA: 0x97B180
    public void set_limitX(){} // RVA: 0x97B1B0
    public void get_limitXBlittable(){} // RVA: 0x97B1E0
    public void set_limitXBlittable(){} // RVA: 0x97B270
    public void get_limitXMultiplier(){} // RVA: 0x97B2E0
    public void set_limitXMultiplier(){} // RVA: 0x97B330
    public void get_limitY(){} // RVA: 0x97B340
    public void set_limitY(){} // RVA: 0x97B370
    public void get_limitYBlittable(){} // RVA: 0x97B3A0
    public void set_limitYBlittable(){} // RVA: 0x97B430
    public void get_limitYMultiplier(){} // RVA: 0x97B4A0
    public void set_limitYMultiplier(){} // RVA: 0x97B4F0
    public void get_limitZ(){} // RVA: 0x97B500
    public void set_limitZ(){} // RVA: 0x97B530
    public void get_limitZBlittable(){} // RVA: 0x97B560
    public void set_limitZBlittable(){} // RVA: 0x97B5F0
    public void get_limitZMultiplier(){} // RVA: 0x97B660
    public void set_limitZMultiplier(){} // RVA: 0x97B6B0
    public void get_limit(){} // RVA: 0x97B6C0
    public void set_limit(){} // RVA: 0x97B6F0
    public void get_limitBlittable(){} // RVA: 0x97B720
    public void set_limitBlittable(){} // RVA: 0x97B7B0
    public void get_limitMultiplier(){} // RVA: 0x97B820
    public void set_limitMultiplier(){} // RVA: 0x97B870
    public void get_dampen(){} // RVA: 0x97B880
    public void set_dampen(){} // RVA: 0x97B8D0
    public void get_separateAxes(){} // RVA: 0x97B8E0
    public void set_separateAxes(){} // RVA: 0x97B930
    public void get_space(){} // RVA: 0x97B940
    public void set_space(){} // RVA: 0x97B990
    public void get_drag(){} // RVA: 0x97B9F0
    public void set_drag(){} // RVA: 0x97BA20
    public void get_dragBlittable(){} // RVA: 0x97BA50
    public void set_dragBlittable(){} // RVA: 0x97BAE0
    public void get_dragMultiplier(){} // RVA: 0x97BB50
    public void set_dragMultiplier(){} // RVA: 0x97BBA0
    public void get_multiplyDragByParticleSize(){} // RVA: 0x97BBB0
    public void set_multiplyDragByParticleSize(){} // RVA: 0x97BC00
    public void get_multiplyDragByParticleVelocity(){} // RVA: 0x97BC10
    public void set_multiplyDragByParticleVelocity(){} // RVA: 0x97BC60
    public void get_limitXBlittable_Injected(){} // RVA: 0x7CC7C20
    public void set_limitXBlittable_Injected(){} // RVA: 0x7CC7C80
    public void get_limitYBlittable_Injected(){} // RVA: 0x7CC7CE0
    public void set_limitYBlittable_Injected(){} // RVA: 0x7CC7D40
    public void get_limitZBlittable_Injected(){} // RVA: 0x7CC7DA0
    public void set_limitZBlittable_Injected(){} // RVA: 0x7CC7E00
    public void get_limitBlittable_Injected(){} // RVA: 0x7CC7E60
    public void set_limitBlittable_Injected(){} // RVA: 0x7CC7EC0
    public void get_dragBlittable_Injected(){} // RVA: 0x7CC7F20
    public void set_dragBlittable_Injected(){} // RVA: 0x7CC7F80
}

public class Limits : ValueType
{
    public object minSwing;
    public object maxSwing;
    public object swing2;
    public object twist;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x4FE0
}

public class LineBreakingTable : Object
{
    public object leadingCharacters;
    public object followingCharacters;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class LineInfoAnnotation : Object
{
    public object LineNumber;
    public object LinePosition;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x4F358F0
}

public class LineInfoAnnotation : Object
{
    public object LineNumber;
    public object LinePosition;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x4F358F0
}

public class LineSegment : ValueType
{
    public object Point1;
    public object Point2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x30D0
}

public class LinkImage[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Linked1CancellationTokenSource : CancellationTokenSource
{
    public object _reg1;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x699F330
    public void Dispose(){} // RVA: 0x699F4B0
}

public class Linked2CancellationTokenSource : CancellationTokenSource
{
    public object _reg1;
    public object _reg2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x699F4F0
    public void Dispose(){} // RVA: 0x699F760
}

public class LinkedNCancellationTokenSource : CancellationTokenSource
{
    public object s_linkedTokenCancelDelegate;
    public object _linkingRegistrations;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x699F7B0
    public void Dispose(){} // RVA: 0x699F9E0
    public void .cctor(){} // RVA: 0x699FA70
}

public class LinqEnumerator : Object
{
    public object m_Node;
    public object m_Enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6C45660
    public void get_Current(){} // RVA: 0x6C45790
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x6C457C0
    public void MoveNext(){} // RVA: 0x6C45820
    public void Dispose(){} // RVA: 0x6C45830
    public void GetEnumerator(){} // RVA: 0x6C458A0
    public void Reset(){} // RVA: 0x6C45900
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6C459C0
}

public class ListBuffer16 : MemoryStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xA1BB7E0
    public void EncodeTo(){} // RVA: 0xA1BB870
}

public class ListEntry : Object
{
    public object _next;
    public object _key;
    public object _handler;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x76AFAA0
}

public class ListInitExpressionProxy : Object
{
    public object _node;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x70495C0
    public void get_CanReduce(){} // RVA: 0x10AD460
    public void get_DebugView(){} // RVA: 0x7048AD0
    public void get_Initializers(){} // RVA: 0x13F9400
    public void get_NewExpression(){} // RVA: 0x13F9340
    public void get_NodeType(){} // RVA: 0x10AD380
    public void get_Type(){} // RVA: 0x10ACB60
}

public class ListIterator`1 : ValueType
{
    public object isNull;
    public object list;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void GetEnumerator(){} // RVA: 0xA94080
    public void get_Current(){} // RVA: 0xA94080
    public void MoveNext(){} // RVA: 0x87D280
    public void Dispose(){} // RVA: 0x894290
}

public class ListOfTWrapper`1 : Object
{
    public object _collection;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void get_Count(){} // RVA: 0x87C130
    public void get_Item(){} // RVA: 0xA94080
    public void GetEnumerator(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
}

public class ListPlayersDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1BA0
    public void Invoke(){} // RVA: 0xBA10B0
    public void BeginInvoke(){} // RVA: 0xBA10C0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ListPoolImpl`1 : Object
{
    public object Pool;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x35CF860
}

public class ListQueryMatcher`1 : UQueryMatcher
{
    public object _matches;

    // ── Methods ──
    public void get_matches(){} // RVA: 0x87C0A0
    public void set_matches(){} // RVA: 0x894320
    public void OnRuleMatchedElement(){} // RVA: 0x87D3C0
    public void Reset(){} // RVA: 0x894290
    public void .ctor(){} // RVA: 0x894290
}

public class LoadOptions : ValueType
{
    public object _storageLocation;
    public object _maxAnchorCount;
    public object _timeout;
    public object _uuids;

    // ── Methods ──
    public void get_StorageLocation(){} // RVA: 0x77E60
    public void set_StorageLocation(){} // RVA: 0x29580
    public void get_MaxAnchorCount(){} // RVA: 0x77E50
    public void set_MaxAnchorCount(){} // RVA: 0x77EE0
    public void get_Timeout(){} // RVA: 0x85010
    public void set_Timeout(){} // RVA: 0xDA1A0
    public void get_Uuids(){} // RVA: 0x7E450
    public void set_Uuids(){} // RVA: 0x7E3E0
    public void ToQueryOptions(){} // RVA: 0x8CFBF0
}

public class LocalTextureResource : BaseTextureResource
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26500E0
    public void Unload(){} // RVA: 0x26504B0
}

public class Locale : Object
{
    // ── Methods ──
    public void GetText(){} // RVA: 0x662F4E0
}

public class Locale : Object
{
    // ── Methods ──
    public void GetText(){} // RVA: 0x662F4E0
}

public class LocalityName : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6649DF0
}

public class Location : Object
{
    public object _parser;
    public object _unknownFields;
    public object _repeated_path_codec;
    public object path_;
    public object _repeated_span_codec;
    public object span_;
    public object LeadingCommentsDefaultValue;
    public object leadingComments_;
    public object TrailingCommentsDefaultValue;
    public object trailingComments_;
    public object _repeated_leadingDetachedComments_codec;
    public object leadingDetachedComments_;

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x64F3B30
    public void get_Descriptor(){} // RVA: 0x64F3B90
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64F3C10
    public void .ctor(){} // RVA: 0x64F3E90
    public void Clone(){} // RVA: 0x64F41E0
    public void get_Path(){} // RVA: 0xB465B0
    public void get_Span(){} // RVA: 0xB700F0
    public void get_LeadingComments(){} // RVA: 0x64F4240
    public void set_LeadingComments(){} // RVA: 0x64F42B0
    public void get_HasLeadingComments(){} // RVA: 0x64E22A0
    public void ClearLeadingComments(){} // RVA: 0x34243A0
    public void get_TrailingComments(){} // RVA: 0x64F43B0
    public void set_TrailingComments(){} // RVA: 0x64F4420
    public void get_HasTrailingComments(){} // RVA: 0x5BC22D0
    public void ClearTrailingComments(){} // RVA: 0x64E2420
    public void get_LeadingDetachedComments(){} // RVA: 0xD05CA0
    public void Equals(){} // RVA: 0x64F4580
    public void GetHashCode(){} // RVA: 0x64F4760
    public void ToString(){} // RVA: 0x64F4880
    public void WriteTo(){} // RVA: 0x64B3910
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64F48D0
    public void CalculateSize(){} // RVA: 0x64F4A60
    public void MergeFrom(){} // RVA: 0x64B3C50
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64F4E00
    public void .cctor(){} // RVA: 0x64F5040
}

public class LockedScope : Object
{
    public object _scope;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6D16A10
    public void Dispose(){} // RVA: 0x6D16C30
}

public class Locomotion : Object
{
    public object weight;
    public object footDistance;
    public object stepThreshold;
    public object angleThreshold;
    public object comAngleMlp;
    public object maxVelocity;
    public object velocityFactor;
    public object maxLegStretch;
    public object rootSpeed;
    public object stepSpeed;
    public object stepHeight;
    public object heelHeight;
    public object relaxLegTwistMinAngle;
    public object relaxLegTwistSpeed;
    public object stepInterpolation;
    public object offset;
    public object blockingEnabled;
    public object blockingLayers;
    public object raycastRadius;
    public object raycastHeight;
    public object onLeftFootstep;
    public object onRightFootstep;
    public object _centerOfMass;
    public object footsteps;
    public object lastComPosition;
    public object comVelocity;
    public object leftFootIndex;
    public object rightFootIndex;

    // ── Methods ──
    public void get_centerOfMass(){} // RVA: 0xC7CEC0
    public void set_centerOfMass(){} // RVA: 0xC7CEE0
    public void Initiate(){} // RVA: 0xC7CF00
    public void Reset(){} // RVA: 0xC7D330
    public void VrcSetLeftFoot(){} // RVA: 0xC7D740
    public void VrcSetRightFoot(){} // RVA: 0xC7D7C0
    public void AddDeltaRotation(){} // RVA: 0xC7D840
    public void AddDeltaPosition(){} // RVA: 0xC7E340
    public void Solve(){} // RVA: 0xC7E490
    public void get_leftFootstepPosition(){} // RVA: 0xC80770
    public void get_rightFootstepPosition(){} // RVA: 0xC807C0
    public void get_leftFootstepRotation(){} // RVA: 0xC80810
    public void get_rightFootstepRotation(){} // RVA: 0xC80850
    public void StepBlocked(){} // RVA: 0xC80890
    public void CanStep(){} // RVA: 0xC80B10
    public void GetLineSphereCollision(){} // RVA: 0xC80B90
    public void .ctor(){} // RVA: 0xC80EE0
}

public class LogCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26DB440
    public void Invoke(){} // RVA: 0x26DB510
}

public class LogCallback2DelegateType : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6BE2340
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x6BE2410
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class LogDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB9DF20
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class LogForwarder : ValueType
{
    // ── Methods ──
    public void Log(){} // RVA: 0x8CF6F0
    public void LogWarning(){} // RVA: 0x8CF700
    public void LogError(){} // RVA: 0x8CF710
}

public class LogHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x654F3B0
    public void Invoke(){} // RVA: 0x14CC9D0
}

public class LogValues : ValueType
{
    public object Callback;
    public object _formatter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_Item(){} // RVA: 0x8AA430
    public void get_Count(){} // RVA: 0x65FD60
    public void GetEnumerator(){} // RVA: 0x8AA460
    public void ToString(){} // RVA: 0x4FA80
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x8AA470
    public void .cctor(){} // RVA: 0x6624490
}

public class LogValues`1 : ValueType
{
    public object Callback;
    public object _formatter;
    public object _value0;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void get_Item(){} // RVA: 0x87BF40
    public void get_Count(){} // RVA: 0x87C130
    public void GetEnumerator(){} // RVA: 0x87C0A0
    public void ToString(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    public void .cctor(){} // RVA: 0x8942F0
}

public class LogValues`2 : ValueType
{
    public object Callback;
    public object _formatter;
    public object _value0;
    public object _value1;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void get_Item(){} // RVA: 0x87BF40
    public void get_Count(){} // RVA: 0x87C130
    public void GetEnumerator(){} // RVA: 0x87C0A0
    public void ToString(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    public void .cctor(){} // RVA: 0x8942F0
}

public class LogValues`3 : ValueType
{
    public object Callback;
    public object _formatter;
    public object _value0;
    public object _value1;
    public object _value2;

    // ── Methods ──
    public void get_Count(){} // RVA: 0x87C130
    public void get_Item(){} // RVA: 0x87BF40
    public void .ctor(){} // RVA: 0xA94080
    public void ToString(){} // RVA: 0x87C0A0
    public void GetEnumerator(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    public void .cctor(){} // RVA: 0x8942F0
}

public class LogValues`4 : ValueType
{
    public object Callback;
    public object _formatter;
    public object _value0;
    public object _value1;
    public object _value2;
    public object _value3;

    // ── Methods ──
    public void get_Count(){} // RVA: 0x87C130
    public void get_Item(){} // RVA: 0x87BF40
    public void .ctor(){} // RVA: 0xA94080
    public void ToArray(){} // RVA: 0x87C0A0
    public void ToString(){} // RVA: 0x87C0A0
    public void GetEnumerator(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    public void .cctor(){} // RVA: 0x8942F0
}

public class LogValues`5 : ValueType
{
    public object Callback;
    public object _formatter;
    public object _value0;
    public object _value1;
    public object _value2;
    public object _value3;
    public object _value4;

    // ── Methods ──
    public void get_Count(){} // RVA: 0x87C130
    public void get_Item(){} // RVA: 0x87BF40
    public void .ctor(){} // RVA: 0xA94080
    public void ToArray(){} // RVA: 0x87C0A0
    public void ToString(){} // RVA: 0x87C0A0
    public void GetEnumerator(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    public void .cctor(){} // RVA: 0x8942F0
}

public class LogValues`6 : ValueType
{
    public object Callback;
    public object _formatter;
    public object _value0;
    public object _value1;
    public object _value2;
    public object _value3;
    public object _value4;
    public object _value5;

    // ── Methods ──
    public void get_Count(){} // RVA: 0x87C130
    public void get_Item(){} // RVA: 0x87BF40
    public void .ctor(){} // RVA: 0xA94080
    public void ToArray(){} // RVA: 0x87C0A0
    public void ToString(){} // RVA: 0x87C0A0
    public void GetEnumerator(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    public void .cctor(){} // RVA: 0x8942F0
}

public class Logger : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB9DF20
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class LongInput : TextValueInput
{
    // ── Methods ──
    public void get_parentLongField(){} // RVA: 0x7FF56F0
    public void .ctor(){} // RVA: 0x7FF5770
    public void get_allowedCharacters(){} // RVA: 0x7FF5930
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FF5990
    public void ClampMinMaxLongValue(){} // RVA: 0x7FF5C10
    public void ValueToString(){} // RVA: 0x7FF5CC0
    public void StringToValue(){} // RVA: 0x7FF5DB0
}

public class LookAtBone[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class LookCommonShaderIds : Object
{
    public object _LocalTransformInverse;
    public object _LocalTransform;
    public object _DebugKeyword;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x26BE300
}

public class Lookup`2 : Object
{
    public object empty;
    public object dict;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void CreateEmpty(){} // RVA: 0x87C0D0
    public void Create(){} // RVA: 0xA94080
    public void CreateAsync(){} // RVA: 0xA94080
    public void get_Item(){} // RVA: 0xA94080
    public void get_Count(){} // RVA: 0x87C130
    public void Contains(){} // RVA: 0xA94080
    public void GetEnumerator(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    public void .cctor(){} // RVA: 0x8942F0
}

public class LoopExpressionProxy : Object
{
    public object _node;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x70496A0
    public void get_Body(){} // RVA: 0x13F9340
    public void get_BreakLabel(){} // RVA: 0x13F9400
    public void get_CanReduce(){} // RVA: 0x10AD460
    public void get_ContinueLabel(){} // RVA: 0x13F92B0
    public void get_DebugView(){} // RVA: 0x7048AD0
    public void get_NodeType(){} // RVA: 0x10AD380
    public void get_Type(){} // RVA: 0x10ACB60
}

public class LowLevelStack : Object
{
    public object _arr;
    public object _count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x698B690
    public void Pop(){} // RVA: 0x698B720
    public void Push(){} // RVA: 0x698B7F0
    public void Clear(){} // RVA: 0x698B9A0
}
