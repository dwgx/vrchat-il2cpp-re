// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 542

public class CACD : Object
{
    public object d;
    public object c;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class Cache`1 : Object
{
    public object Comparer;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x8942F0
}

public class CachedUdonExternDelegate : Object
{
    public object externSignature;
    public object externDelegate;
    public object parameterCount;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x31D5D40
    public void ToString(){} // RVA: 0xB5DBF0
}

public class CalcProximity_000001DA$BurstDirectCall : Object
{
    public object Pointer;

    // ── Methods ──
    public void GetFunctionPointerDiscard(){} // RVA: 0x82CFD80
    public void GetFunctionPointer(){} // RVA: 0x82CFF50
    public void Invoke(){} // RVA: 0x82CFF80
}

public class CalcProximity_000001DA$PostfixBurstDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x82CFBE0
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x82CFCD0
    public void EndInvoke(){} // RVA: 0x25B7E60
}

public class CalibrationData : Object
{
    public object scale;
    public object head;
    public object leftHand;
    public object rightHand;
    public object pelvis;
    public object leftFoot;
    public object rightFoot;
    public object leftLegGoal;
    public object rightLegGoal;
    public object pelvisTargetRight;
    public object pelvisPositionWeight;
    public object pelvisRotationWeight;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class CallSiteFormatterContext : ValueType
{
    public object _processedCallSites;
    public object _firstItem;
    public object _offset;
    public object _builder;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8A8410
    public void get_Offset(){} // RVA: 0x92DE0
    public void get_Builder(){} // RVA: 0x7E450
    public void ShouldFormat(){} // RVA: 0x8A8420
    public void IncrementOffset(){} // RVA: 0x8A8430
    public void StartObject(){} // RVA: 0x8A8490
    public void EndObject(){} // RVA: 0x8A84C0
    public void StartProperty(){} // RVA: 0x8A84D0
    public void StartArrayItem(){} // RVA: 0x8A84E0
    public void WriteProperty(){} // RVA: 0x8A8520
    public void StartArray(){} // RVA: 0x8A8530
    public void EndArray(){} // RVA: 0x8A8560
}

public class CallSiteValidatorState : ValueType
{
    public object _singleton;

    // ── Methods ──
    public void get_Singleton(){} // RVA: 0x77900
    public void set_Singleton(){} // RVA: 0x47F10
}

public class Callback : ValueType
{
    public object callback;
    public object state;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x76310
    public void Invoke(){} // RVA: 0x922CD0
}

public class Callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
    public void Invoke(){} // RVA: 0x894320
    public void BeginInvoke(){} // RVA: 0x882090
    public void EndInvoke(){} // RVA: 0x894320
}

public class Callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class Callback[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class CameraPosition : Object
{
    public object lookAtTarget;
    public object direction;
    public object maxDistance;
    public object maxAngle;
    public object fixYAxis;

    // ── Methods ──
    public void GetRotation(){} // RVA: 0xCAB270
    public void IsInRange(){} // RVA: 0xCAB4C0
    public void .ctor(){} // RVA: 0xCABA80
}

public class CanceledResultSource`1 : Object
{
    public object cancellationToken;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8943F0
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class CanceledUniTaskCache`1 : Object
{
    public object Task;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x8942F0
}

public class CanvasInfo[] : Array
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

public class Capsule : ValueType
{
    public object pos0;
    public object pos1;
    public object radius;

    // ── Methods ──
    public void ClosestPoint(){} // RVA: 0x9C69C0
}

public class Category : Object
{
    public object id;
    public object name;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class Category[] : Array
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

public class Chain : ValueType
{
    public object rootIndex;
    public object boneOffset;
    public object boneCount;
    public object spanCount;
    public object hasInitialized;
    public object version;
    public object isAnimated;
    public object integrationType;
    public object colliders;
    public object grabBone;
    public object grabGlobalPosition;
    public object grabMovement;
    public object paramStretch;
    public object paramSquish;
    public object grabIkSolved;
    public object limitType;
    public object staticFreezeAxis;
    public object immobileType;
    public object shapeId;
    public object renderBounds;
    public object collisionBounds;
    public object paramAngle;
    public object lastRootParentState;
    public object lastSceneRootState;

    // ── Methods ──
    public void Init(){} // RVA: 0x9C9E30
    public void Dispose(){} // RVA: 0x9C9E40
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x40E2370
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x6F15870
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1F62250
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x6F18FB0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5095CF0
    public void Invoke(){} // RVA: 0x40E51E0
    public void BeginInvoke(){} // RVA: 0x6F1D530
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5095E60
    public void Invoke(){} // RVA: 0x5095FD0
    public void BeginInvoke(){} // RVA: 0x6F3E0D0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5095FF0
    public void Invoke(){} // RVA: 0x5096160
    public void BeginInvoke(){} // RVA: 0x6F40C40
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x40E2370
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x6F45B00
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1F62250
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x6F47C30
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5095CF0
    public void Invoke(){} // RVA: 0x40E51E0
    public void BeginInvoke(){} // RVA: 0x6F48980
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5095E60
    public void Invoke(){} // RVA: 0x5095FD0
    public void BeginInvoke(){} // RVA: 0x6F51210
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5095FF0
    public void Invoke(){} // RVA: 0x5096160
    public void BeginInvoke(){} // RVA: 0x6F51E10
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeTokenRegistration`1 : Object
{
    public object _changeTokenProducer;
    public object _changeTokenConsumer;
    public object _state;
    public object _disposable;
    public object _disposedSentinel;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void OnChangeTokenFired(){} // RVA: 0x894290
    public void RegisterChangeTokenCallback(){} // RVA: 0x894320
    public void SetDisposable(){} // RVA: 0x894320
    public void Dispose(){} // RVA: 0x894290
    public void .cctor(){} // RVA: 0x8942F0
}

public class ChannelTransformer`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
    public void Invoke(){} // RVA: 0xA94080
}

public class CharDescriptor : Object
{
    public object MaskPosition;
    public object CaseConversion;
    public object CharType;
    public object IsAssigned;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x76D12D0
    public void ToString(){} // RVA: 0x76D12E0
}

public class CharacterPosition : Object
{
    public object use;
    public object offset;
    public object angleOffset;
    public object maxAngle;
    public object radius;
    public object orbit;
    public object fixYAxis;

    // ── Methods ──
    public void get_offset3D(){} // RVA: 0xCAA540
    public void get_direction3D(){} // RVA: 0xCAA560
    public void IsInRange(){} // RVA: 0xCAA820
    public void .ctor(){} // RVA: 0xCAB260
}

public class CharacterSubstitution : ValueType
{
    public object index;
    public object unicode;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2B100
}

public class Child : Object
{
    public object t;
    public object localPosition;
    public object localRotation;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xCB1010
    public void FixTransform(){} // RVA: 0xCB11D0
    public void StoreLocalState(){} // RVA: 0xCB16B0
}

public class ChildConstraint : Object
{
    public object pushElasticity;
    public object pullElasticity;
    public object bone1;
    public object bone2;
    public object _nominalDistance;
    public object _isRigid;
    public object crossFade;
    public object inverseCrossFade;
    public object chain1Index;
    public object chain2Index;

    // ── Methods ──
    public void get_nominalDistance(){} // RVA: 0xC27360
    public void set_nominalDistance(){} // RVA: 0xC27370
    public void get_isRigid(){} // RVA: 0xC27380
    public void set_isRigid(){} // RVA: 0xC27390
    public void .ctor(){} // RVA: 0xC273A0
    public void Initiate(){} // RVA: 0xC27460
    public void OnPreSolve(){} // RVA: 0xC274C0
    public void Solve(){} // RVA: 0xC27820
}

public class Child[] : Array
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

public class Chunk : Object
{
    public object id;
    public object size;
    public object offset;
    public object headerSize;
    public object writeOffset;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class ClientResult : ValueType
{
    public object Handle;

    // ── Methods ──
    public void Drop(){} // RVA: 0x26D95B0
    public void ToString(){} // RVA: 0x26D9630
    public void Type(){} // RVA: 0x26D96C0
    public void Error(){} // RVA: 0x26D9740
    public void ErrorCode(){} // RVA: 0x26D97D0
    public void Successful(){} // RVA: 0x26D9850
}

public class Codec : Object
{
    public object keyCodec;
    public object valueCodec;
    public object mapTag;

    // ── Methods ──
    public void get_KeyCodec(){} // RVA: 0x87C0A0
    public void get_ValueCodec(){} // RVA: 0x87C0A0
    public void get_MapTag(){} // RVA: 0x87C130
}

public class Collider : ValueType
{
    public object shapeId;
    public object hasUpdated;
    public object prevPos0;
    public object prevPos1;
    public object nextPos0;
    public object nextPos1;
    public object shapeType;
    public object pos0;
    public object pos1;
    public object radius;
    public object insideBounds;
    public object bonesAsSpheres;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x9CA6D0
    public void Lerp(){} // RVA: 0x9CA6E0
}

public class CollisionImpulseDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA9890
    public void Invoke(){} // RVA: 0xBA9960
    public void BeginInvoke(){} // RVA: 0xBA9990
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class CollisionModule : ValueType
{
    public object m_ParticleSystem;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_enabled(){} // RVA: 0x976700
    public void set_enabled(){} // RVA: 0x976750
    public void get_type(){} // RVA: 0x976760
    public void set_type(){} // RVA: 0x9767B0
    public void get_mode(){} // RVA: 0x976810
    public void set_mode(){} // RVA: 0x976860
    public void get_dampen(){} // RVA: 0x9768C0
    public void set_dampen(){} // RVA: 0x9768F0
    public void get_dampenBlittable(){} // RVA: 0x976920
    public void set_dampenBlittable(){} // RVA: 0x9769B0
    public void get_dampenMultiplier(){} // RVA: 0x976A20
    public void set_dampenMultiplier(){} // RVA: 0x976A70
    public void get_bounce(){} // RVA: 0x976A80
    public void set_bounce(){} // RVA: 0x976AB0
    public void get_bounceBlittable(){} // RVA: 0x976AE0
    public void set_bounceBlittable(){} // RVA: 0x976B70
    public void get_bounceMultiplier(){} // RVA: 0x976BE0
    public void set_bounceMultiplier(){} // RVA: 0x976C30
    public void get_lifetimeLoss(){} // RVA: 0x976C40
    public void set_lifetimeLoss(){} // RVA: 0x976C70
    public void get_lifetimeLossBlittable(){} // RVA: 0x976CA0
    public void set_lifetimeLossBlittable(){} // RVA: 0x976D30
    public void get_lifetimeLossMultiplier(){} // RVA: 0x976DA0
    public void set_lifetimeLossMultiplier(){} // RVA: 0x976DF0
    public void get_minKillSpeed(){} // RVA: 0x976E00
    public void set_minKillSpeed(){} // RVA: 0x976E50
    public void get_maxKillSpeed(){} // RVA: 0x976E60
    public void set_maxKillSpeed(){} // RVA: 0x976EB0
    public void get_collidesWith(){} // RVA: 0x976EC0
    public void set_collidesWith(){} // RVA: 0x976ED0
    public void get_enableDynamicColliders(){} // RVA: 0x976F30
    public void set_enableDynamicColliders(){} // RVA: 0x976F80
    public void get_maxCollisionShapes(){} // RVA: 0x976F90
    public void set_maxCollisionShapes(){} // RVA: 0x976FE0
    public void get_quality(){} // RVA: 0x977040
    public void set_quality(){} // RVA: 0x977090
    public void get_voxelSize(){} // RVA: 0x9770F0
    public void set_voxelSize(){} // RVA: 0x977140
    public void get_radiusScale(){} // RVA: 0x977150
    public void set_radiusScale(){} // RVA: 0x9771A0
    public void get_sendCollisionMessages(){} // RVA: 0x9771B0
    public void set_sendCollisionMessages(){} // RVA: 0x977200
    public void get_colliderForce(){} // RVA: 0x977210
    public void set_colliderForce(){} // RVA: 0x977260
    public void get_multiplyColliderForceByCollisionAngle(){} // RVA: 0x977270
    public void set_multiplyColliderForceByCollisionAngle(){} // RVA: 0x9772C0
    public void get_multiplyColliderForceByParticleSpeed(){} // RVA: 0x9772D0
    public void set_multiplyColliderForceByParticleSpeed(){} // RVA: 0x977320
    public void get_multiplyColliderForceByParticleSize(){} // RVA: 0x977330
    public void set_multiplyColliderForceByParticleSize(){} // RVA: 0x977380
    public void AddPlane(){} // RVA: 0x977390
    public void RemovePlane(){} // RVA: 0x977400
    public void RemovePlaneObject(){} // RVA: 0x977410
    public void SetPlane(){} // RVA: 0x977420
    public void GetPlane(){} // RVA: 0x977430
    public void get_planeCount(){} // RVA: 0x977440
    public void get_dampenBlittable_Injected(){} // RVA: 0x7CBE1E0
    public void set_dampenBlittable_Injected(){} // RVA: 0x7CBE240
    public void get_bounceBlittable_Injected(){} // RVA: 0x7CBE2A0
    public void set_bounceBlittable_Injected(){} // RVA: 0x7CBE300
    public void get_lifetimeLossBlittable_Injected(){} // RVA: 0x7CBE360
    public void set_lifetimeLossBlittable_Injected(){} // RVA: 0x7CBE3C0
    public void get_collidesWith_Injected(){} // RVA: 0x7CBE420
    public void set_collidesWith_Injected(){} // RVA: 0x7CBE480
    public void AddPlane_Injected(){} // RVA: 0x7CBE4E0
    public void RemovePlaneObject_Injected(){} // RVA: 0x7CBE540
    public void SetPlane_Injected(){} // RVA: 0x7CBE5A0
    public void GetPlane_Injected(){} // RVA: 0x7CBE610
}

public class CollisionRecord[] : Array
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

public class CollisionRecord[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class CollisionResistanceMultiplier[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E130
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A850
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4020
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34460
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A850
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class CollisionShape : ValueType
{
    public object shapeType;
    public object pos0;
    public object pos1;
    public object radius;
    public object rotation;

    // ── Methods ──
    public void ToAABB(){} // RVA: 0x9C67A0
    public void ToSphere(){} // RVA: 0x9C67F0
    public void ToCapsule(){} // RVA: 0x9C6830
    public void ToBox(){} // RVA: 0x9C6890
    public void ToPlane(){} // RVA: 0x9C67A0
}

public class Color32EqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x77C0940
    public void GetHashCode(){} // RVA: 0x77C0980
    public void .ctor(){} // RVA: 0xB43310
}

public class Color32Surrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0xA74DFC0
    public void SetObjectData(){} // RVA: 0xA74E0E0
    public void .ctor(){} // RVA: 0xB43310
}

public class ColorBySpeedModule : ValueType
{
    public object m_ParticleSystem;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_enabled(){} // RVA: 0x97CBC0
    public void set_enabled(){} // RVA: 0x97CC10
    public void get_color(){} // RVA: 0x97CC20
    public void set_color(){} // RVA: 0x97CC60
    public void get_colorBlittable(){} // RVA: 0x97CCA0
    public void set_colorBlittable(){} // RVA: 0x97CD50
    public void get_range(){} // RVA: 0x97CDD0
    public void set_range(){} // RVA: 0x97CDE0
    public void get_colorBlittable_Injected(){} // RVA: 0x7CC9CD0
    public void set_colorBlittable_Injected(){} // RVA: 0x7CC9D30
    public void get_range_Injected(){} // RVA: 0x7CC9D90
    public void set_range_Injected(){} // RVA: 0x7CC9DF0
}

public class ColorEqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x77C0540
    public void GetHashCode(){} // RVA: 0x77C0600
    public void .ctor(){} // RVA: 0xB43310
}

public class ColorOverLifetimeModule : ValueType
{
    public object m_ParticleSystem;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_enabled(){} // RVA: 0x97C8F0
    public void set_enabled(){} // RVA: 0x97C940
    public void get_color(){} // RVA: 0x97C950
    public void set_color(){} // RVA: 0x97C990
    public void get_colorBlittable(){} // RVA: 0x97C9D0
    public void set_colorBlittable(){} // RVA: 0x97CA80
    public void get_colorBlittable_Injected(){} // RVA: 0x7CC97B0
    public void set_colorBlittable_Injected(){} // RVA: 0x7CC9810
}

public class ColorSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0xA74DD40
    public void SetObjectData(){} // RVA: 0xA74DE60
    public void .ctor(){} // RVA: 0xB43310
}

public class ColorTweenCallback : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x79EE8A0
}

public class ColorTweenCallback : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x810B8F0
}

public class ComNativeTypeDescriptor : Object
{
    public object _handler;
    public object _instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x17C92C0
    public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7708FF0
    public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x77090B0
    public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0xDAC980
    public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7709110
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x77091E0
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x77092B0
    public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7709380
    public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x77094C0
    public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7709600
    public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0xB465B0
}

public class CommonName : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6649CB0
}

public class Companions : Object
{
    // ── Methods ──
    public void get__GetCompanionApi(){} // RVA: 0x8331990
    public void set__GetCompanionApi(){} // RVA: 0x83319D0
}

public class ComparePerformanceStatsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xA761C70
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x23E7ED0
    public void EndInvoke(){} // RVA: 0x25B7E60
}

public class Comparers : Object
{
    public object Default;
    public object _keyComparer;
    public object _valueComparer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8943B0
    public void get_KeyComparer(){} // RVA: 0x87C0A0
    public void get_KeyOnlyComparer(){} // RVA: 0x87C0A0
    public void get_ValueComparer(){} // RVA: 0x87C0A0
    public void Equals(){} // RVA: 0xA94080
    public void GetHashCode(){} // RVA: 0xA94080
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Equals(){} // RVA: 0xA94080
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetHashCode(){} // RVA: 0xA94080
    public void Get(){} // RVA: 0x87C630
    public void .cctor(){} // RVA: 0x8942F0
}

public class ComputeShaders : Object
{
    public object autoExposure;
    public object exposureHistogram;
    public object lut3DBaker;
    public object texture3dLerp;
    public object gammaHistogram;
    public object waveform;
    public object vectorscope;
    public object multiScaleAODownsample1;
    public object multiScaleAODownsample2;
    public object multiScaleAORender;
    public object multiScaleAOUpsample;
    public object gaussianDownsample;

    // ── Methods ──
    public void Clone(){} // RVA: 0x79901D0
    public void .ctor(){} // RVA: 0xB43310
}

public class ConcreteFormattableString : FormattableString
{
    public object _format;
    public object _arguments;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x17C92C0
    public void get_Format(){} // RVA: 0xB5DBF0
    public void GetArguments(){} // RVA: 0xB465B0
    public void get_ArgumentCount(){} // RVA: 0x3E42680
    public void GetArgument(){} // RVA: 0x677E590
    public void ToString(){} // RVA: 0x67BD830
}

public class ConfiguredTaskAwaiter : ValueType
{
    public object m_task;
    public object m_continueOnCapturedContext;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x214480
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x216780
}

public class ConfiguredTaskAwaiter : ValueType
{
    public object m_task;
    public object m_continueOnCapturedContext;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x212FA0
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x2145E0
}

public class ConfiguredTaskAwaiter : ValueType
{
    public object m_task;
    public object m_continueOnCapturedContext;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x214480
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x216780
}

public class ConfiguredTaskAwaiter : ValueType
{
    public object m_task;
    public object m_continueOnCapturedContext;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x214480
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x216780
}

public class ConfiguredTaskAwaiter : ValueType
{
    public object m_task;
    public object m_continueOnCapturedContext;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x214480
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x216780
}

public class ConfiguredTaskAwaiter : ValueType
{
    public object m_task;
    public object m_continueOnCapturedContext;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x214480
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x216780
}

public class ConfiguredTaskAwaiter : ValueType
{
    public object m_task;
    public object m_continueOnCapturedContext;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x212FA0
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x213130
}

public class ConfiguredTaskAwaiter : ValueType
{
    public object m_task;
    public object m_continueOnCapturedContext;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x212FA0
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x213130
}

public class ConfiguredTaskAwaiter : ValueType
{
    public object m_task;
    public object m_continueOnCapturedContext;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x212FA0
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x213130
}

public class ConfiguredTaskAwaiter : ValueType
{
    public object m_task;
    public object m_continueOnCapturedContext;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x214480
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x216780
}

public class ConfiguredTaskAwaiter : ValueType
{
    public object m_task;
    public object m_continueOnCapturedContext;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x214480
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x216780
}

public class ConfiguredValueTaskAwaiter : ValueType
{
    public object _value;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xD3E60
    public void get_IsCompleted(){} // RVA: 0x8AEFB0
    public void GetResult(){} // RVA: 0x8AF000
    public void OnCompleted(){} // RVA: 0x8AF050
    public void UnsafeOnCompleted(){} // RVA: 0x8AF060
}

public class ConfiguredValueTaskAwaiter : ValueType
{
    public object _value;

    // ── Methods ──
    public void OnCompleted(){} // RVA: 0x894320
    public void UnsafeOnCompleted(){} // RVA: 0x894320
}

public class ConfiguredValueTaskAwaiter : ValueType
{
    public object _value;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xD3E60
    public void get_IsCompleted(){} // RVA: 0x228030
    public void GetResult(){} // RVA: 0x228070
    public void OnCompleted(){} // RVA: 0x22B590
    public void UnsafeOnCompleted(){} // RVA: 0x22B5A0
}

public class ConstructorContext : Object
{
    public object _type;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void CreateInstance(){} // RVA: 0x6DCE010
}

public class ConstructorDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1BA0
    public void Invoke(){} // RVA: 0xBA10B0
}

public class ConstructorScope : ValueType
{
    public object m_Ptr;
    public object m_Hierarchy;
    public object m_CommandList;

    // ── Methods ──
    public void set_Ptr(){} // RVA: 0x7C59730
    public void set_Hierarchy(){} // RVA: 0x7C597C0
    public void set_CommandList(){} // RVA: 0x7C598D0
    public void .ctor(){} // RVA: 0x96E6C0
    public void Dispose(){} // RVA: 0x96E700
}

public class ContactEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x40E11E0
    public void Invoke(){} // RVA: 0x3DB9B10
}

public class ContainerContext : Object
{
    public object Type;
    public object Length;
    public object Position;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xC120B0
}

public class ContentInfo : Object
{
    public object contentType;
    public object content;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x66321F0
    public void get_ASN1(){} // RVA: 0x6632430
    public void get_Content(){} // RVA: 0xB465B0
    public void set_Content(){} // RVA: 0xBA9BA0
    public void get_ContentType(){} // RVA: 0xB5DBF0
    public void set_ContentType(){} // RVA: 0xB44D60
    public void GetASN1(){} // RVA: 0x6632440
}

public class Context : ValueType
{
    public object Option;
    public object NeverMatchFlags;
    public object AlwaysMatchFlags;
    public object Buffer1;
    public object Buffer2;
    public object PrevCode;
    public object PrevSortKey;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8AB960
}

public class ContextRestoreSink : Object
{
    public object _next;
    public object _context;
    public object _call;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xC27FD0
    public void SyncProcessMessage(){} // RVA: 0x6763230
    public void AsyncProcessMessage(){} // RVA: 0x6763470
}

public class ContinuationWrapper : Object
{
    public object m_continuation;
    public object m_invokeAction;
    public object m_innerTask;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x67C0870
    public void Invoke(){} // RVA: 0x47FD7F0
}

public class CoreShaderIds : Object
{
    public object _EdgeChoke;
    public object _VertexBuffer;
    public object _NormalHeight;
    public object _LatticeSize;
    public object _PerspectiveTextureSize;
    public object _DitherEdgeKW;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x26B4140
}

public class CountryName : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x664A360
}

public class CreateJointParams : ValueType
{
    public object rigidbody;
    public object connectedBody;
    public object child;
    public object worldSwingAxis;
    public object limits;
    public object type;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x4F70
}

public class CreatorPropertyContext : Object
{
    public object Name;
    public object Property;
    public object ConstructorProperty;
    public object Presence;
    public object Value;
    public object Used;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class CreatorPropertyContext : Object
{
    public object Name;
    public object Property;
    public object ConstructorProperty;
    public object Presence;
    public object Value;
    public object Used;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class Criterion : ValueType
{
    public object key;
    public object importance;
    public object parameters;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8C9190
}

public class CultureComparer : Object
{
    public object _converter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Compare(){} // RVA: 0x76B70A0
}

public class CultureInfoMapper : Object
{
    public object s_cultureInfoNameMap;

    // ── Methods ──
    public void CreateMap(){} // RVA: 0x76B7270
    public void GetCultureInfoName(){} // RVA: 0x76BD2D0
    public void .cctor(){} // RVA: 0x76BD370
}

public class CultureNameResourceSetPair : Object
{
    public object lastCultureName;
    public object lastResourceSet;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class CustomBlend[] : Array
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

public class CustomBlendable[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class CustomDataModule : ValueType
{
    public object m_ParticleSystem;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_enabled(){} // RVA: 0x982240
    public void set_enabled(){} // RVA: 0x982290
    public void SetMode(){} // RVA: 0x9822A0
    public void GetMode(){} // RVA: 0x9822B0
    public void SetVectorComponentCount(){} // RVA: 0x982310
    public void GetVectorComponentCount(){} // RVA: 0x982320
    public void SetVector(){} // RVA: 0x982380
    public void SetVectorInternal(){} // RVA: 0x9823C0
    public void GetVector(){} // RVA: 0x982450
    public void GetVectorInternal(){} // RVA: 0x982490
    public void SetColor(){} // RVA: 0x982540
    public void SetColorInternal(){} // RVA: 0x982670
    public void GetColor(){} // RVA: 0x982700
    public void GetColorInternal(){} // RVA: 0x982740
    public void SetVectorInternal_Injected(){} // RVA: 0x7CD5850
    public void GetVectorInternal_Injected(){} // RVA: 0x7CD58D0
    public void SetColorInternal_Injected(){} // RVA: 0x7CD5950
    public void GetColorInternal_Injected(){} // RVA: 0x7CD59C0
}

public class CustomQuery : Object
{
    public object data;
    public object criteria;

    // ── Methods ──
    public void ToUnmanaged(){} // RVA: 0x6B3CFD0
    public void .ctor(){} // RVA: 0xB43310
}
