// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 686

public class Clipper : ClipperBase
{
    public int ioReverseSolution;
    public int ioStrictlySimple;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82AC9AF0
    public void InsertMaxima(){} // RVA: 0x7FFE82ACA110
    public void get_ReverseSolution(){} // RVA: 0x7FFE82975460
    public void set_ReverseSolution(){} // RVA: 0x7FFE82976780
    public void get_StrictlySimple(){} // RVA: 0x7FFE821F9410
    public void set_StrictlySimple(){} // RVA: 0x7FFE82ACA530
    public void Execute(){} // RVA: 0x7FFE82ACA730 | overloaded x4
    public void FixHoleLinkage(){} // RVA: 0x7FFE82ACA810
    public void ExecuteInternal(){} // RVA: 0x7FFE82ACA8B0
    public void DisposeAllPolyPts(){} // RVA: 0x7FFE82ACAF60
    public void AddJoin(){} // RVA: 0x7FFE82ACB110
    public void AddGhostJoin(){} // RVA: 0x7FFE82ACB260
    public void InsertLocalMinimaIntoAEL(){} // RVA: 0x7FFE82ACB350
    public void InsertEdgeIntoAEL(){} // RVA: 0x7FFE82ACB970
    public void E2InsertsBeforeE1(){} // RVA: 0x7FFE82ACBD30
    public void IsEvenOddFillType(){} // RVA: 0x7FFE82ACBE40
    public void IsEvenOddAltFillType(){} // RVA: 0x7FFE82ACBE70
    public void IsContributing(){} // RVA: 0x7FFE82ACBEA0
    public void SetWindingCount(){} // RVA: 0x7FFE82ACC040
    public void AddEdgeToSEL(){} // RVA: 0x7FFE82ACC280
    public void PopEdgeFromSEL(){} // RVA: 0x7FFE82ACC540
    public void CopyAELToSEL(){} // RVA: 0x7FFE82ACC750
    public void SwapPositionsInSEL(){} // RVA: 0x7FFE82ACC880
    public void AddLocalMaxPoly(){} // RVA: 0x7FFE82ACCCB0
    public void AddLocalMinPoly(){} // RVA: 0x7FFE82ACCD70
    public void AddOutPt(){} // RVA: 0x7FFE82ACD010
    public void GetLastOutPt(){} // RVA: 0x7FFE82ACD430
    public void SwapPoints(){} // RVA: 0x7FFE82ACD4D0
    public void HorzSegmentsOverlap(){} // RVA: 0x7FFE82ACD500
    public void SetHoleState(){} // RVA: 0x7FFE82ACD540
    public void GetDx(){} // RVA: 0x7FFE82ACD710
    public void FirstIsBottomPt(){} // RVA: 0x7FFE82ACD750
    public void GetBottomPt(){} // RVA: 0x7FFE82ACDB90
    public void GetLowermostRec(){} // RVA: 0x7FFE82ACDCB0
    public void OutRec1RightOfOutRec2(){} // RVA: 0x7FFE82ACDE30
    public void GetOutRec(){} // RVA: 0x7FFE82ACDE60
    public void AppendPolygon(){} // RVA: 0x7FFE82ACDF10
    public void ReversePolyPtLinks(){} // RVA: 0x7FFE82ACEF40
    public void SwapSides(){} // RVA: 0x7FFE82ACF040
    public void SwapPolyIndexes(){} // RVA: 0x7FFE82ACF070
    public void IntersectEdges(){} // RVA: 0x7FFE82ACF0A0
    public void DeleteFromSEL(){} // RVA: 0x7FFE82ACF6C0
    public void ProcessHorizontals(){} // RVA: 0x7FFE82ACF8E0
    public void GetHorzDirection(){} // RVA: 0x7FFE82ACFB30
    public void ProcessHorizontal(){} // RVA: 0x7FFE82ACFB90
    public void GetNextInAEL(){} // RVA: 0x7FFE82AD0570
    public void IsMinima(){} // RVA: 0x7FFE82AD05A0
    public void IsMaxima(){} // RVA: 0x7FFE82AD05E0
    public void IsIntermediate(){} // RVA: 0x7FFE82AD0610
    public void GetMaximaPair(){} // RVA: 0x7FFE82AD0650
    public void GetMaximaPairEx(){} // RVA: 0x7FFE82AD06D0
    public void ProcessIntersections(){} // RVA: 0x7FFE82AD0790
    public void BuildIntersectList(){} // RVA: 0x7FFE82AD0A10
    public void EdgesAdjacent(){} // RVA: 0x7FFE82AD0DE0
    public void IntersectNodeSort(){} // RVA: 0x7FFE82AD0E20
    public void FixupIntersectionOrder(){} // RVA: 0x7FFE82AD0E40
    public void ProcessIntersectList(){} // RVA: 0x7FFE82AD11F0
    public void Round(){} // RVA: 0x7FFE82AD1340
    public void TopX(){} // RVA: 0x7FFE82AD1370
    public void IntersectPoint(){} // RVA: 0x7FFE82AD13E0
    public void ProcessEdgesAtTopOfScanbeam(){} // RVA: 0x7FFE82AD1840
    public void DoMaxima(){} // RVA: 0x7FFE82AD1DD0
    public void ReversePaths(){} // RVA: 0x7FFE82AD2030
    public void Orientation(){} // RVA: 0x7FFE82AD22B0
    public void PointCount(){} // RVA: 0x7FFE82AD22D0
    public void BuildResult(){} // RVA: 0x7FFE82AD2300
    public void BuildResult2(){} // RVA: 0x7FFE82AD2550
    public void FixupOutPolyline(){} // RVA: 0x7FFE82AD28E0
    public void FixupOutPolygon(){} // RVA: 0x7FFE82AD29F0
    public void DupOutPt(){} // RVA: 0x7FFE82AD2EF0
    public void GetOverlap(){} // RVA: 0x7FFE82AD3230
    public void JoinHorz(){} // RVA: 0x7FFE82AD3350
    public void JoinPoints(){} // RVA: 0x7FFE82AD3960
    public void PointInPolygon(){} // RVA: 0x7FFE82AD4D90 | overloaded x2
    public void Poly2ContainsPoly1(){} // RVA: 0x7FFE82AD4EE0
    public void FixupFirstLefts1(){} // RVA: 0x7FFE82AD5070
    public void FixupFirstLefts2(){} // RVA: 0x7FFE82AD5230
    public void FixupFirstLefts3(){} // RVA: 0x7FFE82AD5480
    public void ParseFirstLeft(){} // RVA: 0x7FFE82AD5620
    public void JoinCommonEdges(){} // RVA: 0x7FFE82AD5640
    public void UpdateOutPtIdxs(){} // RVA: 0x7FFE82AD6010
    public void DoSimplePolygons(){} // RVA: 0x7FFE82AD6040
    public void Area(){} // RVA: 0x7FFE82AD6550 | overloaded x3
    public void SimplifyPolygon(){} // RVA: 0x7FFE82AD65C0
    public void SimplifyPolygons(){} // RVA: 0x7FFE82AD66C0
    public void DistanceSqrd(){} // RVA: 0x7FFE82AD67C0
    public void DistanceFromLineSqrd(){} // RVA: 0x7FFE82AD6800
    public void SlopesNearCollinear(){} // RVA: 0x7FFE82AD6880
    public void PointsAreClose(){} // RVA: 0x7FFE82AD6AB0
    public void ExcludeOp(){} // RVA: 0x7FFE82AD6AF0
    public void CleanPolygon(){} // RVA: 0x7FFE82AD6BE0
    public void CleanPolygons(){} // RVA: 0x7FFE82AD7220
    public void Minkowski(){} // RVA: 0x7FFE82AD7390
    public void MinkowskiSum(){} // RVA: 0x7FFE82AD7F00 | overloaded x2
    public void TranslatePath(){} // RVA: 0x7FFE82AD7D20
    public void MinkowskiDiff(){} // RVA: 0x7FFE82AD8130
    public void PolyTreeToPaths(){} // RVA: 0x7FFE82AD8200
    public void AddPolyNodeToPaths(){} // RVA: 0x7FFE82AD82C0
    public void OpenPathsFromPolyTree(){} // RVA: 0x7FFE82AD84B0
    public void ClosedPathsFromPolyTree(){} // RVA: 0x7FFE82AD8650
}

public class ClipperBase : Object
{
    public double horizontal;

    // ── Methods ──
    public void near_zero(){} // RVA: 0x7FFE82AC4F80
    public void get_PreserveCollinear(){} // RVA: 0x7FFE81463AF0
    public void set_PreserveCollinear(){} // RVA: 0x7FFE81463C10
    public void Swap(){} // RVA: 0x7FFE82AC4FA0
    public void IsHorizontal(){} // RVA: 0x7FFE82AC4FB0
    public void PointIsVertex(){} // RVA: 0x7FFE82AC4FD0
    public void PointOnLineSegment(){} // RVA: 0x7FFE82AC5020
    public void PointOnPolygon(){} // RVA: 0x7FFE82AC51E0
    public void SlopesEqual(){} // RVA: 0x7FFE82AC5690 | overloaded x3
    public void .ctor(){} // RVA: 0x7FFE82AC57E0
    public void Clear(){} // RVA: 0x7FFE82AC5950
    public void DisposeLocalMinimaList(){} // RVA: 0x7FFE82AC5C40
    public void RangeTest(){} // RVA: 0x7FFE82AC5D80
    public void InitEdge(){} // RVA: 0x7FFE82AC5E60
    public void InitEdge2(){} // RVA: 0x7FFE82AC5F40
    public void FindNextLocMin(){} // RVA: 0x7FFE82AC5FF0
    public void ProcessBound(){} // RVA: 0x7FFE82AC6100
    public void AddPath(){} // RVA: 0x7FFE82AC67D0
    public void AddPaths(){} // RVA: 0x7FFE82AC7C00
    public void Pt2IsBetweenPt1AndPt3(){} // RVA: 0x7FFE82AC7CF0
    public void RemoveEdge(){} // RVA: 0x7FFE82AC7D70
    public void SetDx(){} // RVA: 0x7FFE82AC7EC0
    public void InsertLocalMinima(){} // RVA: 0x7FFE82AC7F20
    public void PopLocalMinima(){} // RVA: 0x7FFE82AC8140
    public void ReverseHorizontal(){} // RVA: 0x7FFE82AC8230
    public void Reset(){} // RVA: 0x7FFE82AC8260
    public void GetBounds(){} // RVA: 0x7FFE82AC86D0
    public void InsertScanbeam(){} // RVA: 0x7FFE82AC8B50
    public void PopScanbeam(){} // RVA: 0x7FFE82AC8E50
    public void LocalMinimaPending(){} // RVA: 0x7FFE82AC8EE0
    public void CreateOutRec(){} // RVA: 0x7FFE82AC8EF0
    public void DisposeOutRec(){} // RVA: 0x7FFE82AC9120
    public void UpdateEdgeIntoAEL(){} // RVA: 0x7FFE82AC9230
    public void SwapPositionsInAEL(){} // RVA: 0x7FFE82AC9610
    public void DeleteFromAEL(){} // RVA: 0x7FFE82AC98D0
}

public class ClipperException : Exception
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82ADD060
}

public class ClipperOffset : Object
{
    public System.Collections.Generic.List`1<System.Collections.Generic.List`1<IntPoint>> m_destPolys; // 0x10
    public System.Collections.Generic.List`1<IntPoint> m_srcPoly; // 0x18

    // ── Methods ──
    public void get_ArcTolerance(){} // RVA: 0x7FFE82AD8710
    public void set_ArcTolerance(){} // RVA: 0x7FFE82AD8720
    public void get_MiterLimit(){} // RVA: 0x7FFE82AD8730
    public void set_MiterLimit(){} // RVA: 0x7FFE82AD8740
    public void .ctor(){} // RVA: 0x7FFE82AD8750
    public void Clear(){} // RVA: 0x7FFE82AD88D0
    public void Round(){} // RVA: 0x7FFE82AD1340
    public void AddPath(){} // RVA: 0x7FFE82AD8950
    public void AddPaths(){} // RVA: 0x7FFE82AD8FE0
    public void FixOrientations(){} // RVA: 0x7FFE82AD9150
    public void GetUnitNormal(){} // RVA: 0x7FFE82AD93D0
    public void DoOffset(){} // RVA: 0x7FFE82AD94D0
    public void Execute(){} // RVA: 0x7FFE82ADB020 | overloaded x2
    public void OffsetPoint(){} // RVA: 0x7FFE82ADB760
    public void DoSquare(){} // RVA: 0x7FFE82ADC180
    public void DoMiter(){} // RVA: 0x7FFE82ADC7C0
    public void DoRound(){} // RVA: 0x7FFE82ADCA80
}

public class ClosingInfo : ValueType
{
}

public class CmsAuthenticatedDataOutputStream : BaseOutputStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A0F4440
    public void WriteByte(){} // RVA: 0x7FFE8A0F4640
    public void Write(){} // RVA: 0x7FFE8765B4B0
    public void Close(){} // RVA: 0x7FFE8A0F4670
}

public class CmsAuthenticatedSecureReadable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithm; // 0x10
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac mac; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86F99960
    public void get_Algorithm(){} // RVA: 0x7FFE81116380
    public void get_CryptoObject(){} // RVA: 0x7FFE810FE7C0
    public void GetReadable(){} // RVA: 0x7FFE8A0FDE70
}

public class CmsCompressedOutputStream : BaseOutputStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A0F67A0
    public void WriteByte(){} // RVA: 0x7FFE8A0F4640
    public void Write(){} // RVA: 0x7FFE8765B4B0
    public void Close(){} // RVA: 0x7FFE8A0F6950
}

public class CmsEnvelopedDataOutputStream : BaseOutputStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A0F4440
    public void WriteByte(){} // RVA: 0x7FFE8A0FAAA0
    public void Write(){} // RVA: 0x7FFE8A0FAAD0
    public void Close(){} // RVA: 0x7FFE8A0FAB00
}

public class CmsEnvelopedSecureReadable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithm; // 0x10
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBufferedCipher cipher; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86F99960
    public void get_Algorithm(){} // RVA: 0x7FFE81116380
    public void get_CryptoObject(){} // RVA: 0x7FFE810FE7C0
    public void GetReadable(){} // RVA: 0x7FFE8A0FE220
}

public class CmsSignedDataOutputStream : BaseOutputStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A10B840
    public void WriteByte(){} // RVA: 0x7FFE8A0FAAA0
    public void Write(){} // RVA: 0x7FFE8A0FAAD0
    public void Close(){} // RVA: 0x7FFE8A10BAE0
    public void DoClose(){} // RVA: 0x7FFE8A10BB10
    public void WriteToGenerator(){} // RVA: 0x7FFE8A10CDB0
}

public class Codec : Object
{
    public Google.Protobuf.FieldCodec`1<U> keyCodec;
    public Google.Protobuf.FieldCodec`1<T> valueCodec;
    public uint mapTag;

    // ── Methods ──
    public void .ctor(){}
    public void get_KeyCodec(){} // RVA: 0x7FFE80E2E2E0
    public void get_ValueCodec(){} // RVA: 0x7FFE80E2E2E0
    public void get_MapTag(){} // RVA: 0x7FFE80E2EDB0
}

public class Collection : ValueType
{
    // ── Methods ──
    public void Allocate(){} // RVA: 0x7FFE87A3D230
    public void TryFindLayoutForType(){} // RVA: 0x7FFE87A3D8B0
    public void TryFindMatchingLayout(){} // RVA: 0x7FFE87A3DAB0
    public void HasLayout(){} // RVA: 0x7FFE87A3DD60
    public void TryLoadLayoutInternal(){} // RVA: 0x7FFE87A3DE90
    public void TryLoadLayout(){} // RVA: 0x7FFE87A3E5B0
    public void GetBaseLayoutName(){} // RVA: 0x7FFE87A3EC80
    public void GetRootLayoutName(){} // RVA: 0x7FFE87A3EDA0
    public void ComputeDistanceInInheritanceHierarchy(){} // RVA: 0x7FFE87A3EEE0
    public void FindLayoutThatIntroducesControl(){} // RVA: 0x7FFE87A3EFF0
    public void GetControlTypeForLayout(){} // RVA: 0x7FFE87A3F2B0
    public void ValueTypeIsAssignableFrom(){} // RVA: 0x7FFE87A3F580
    public void IsGeneratedLayout(){} // RVA: 0x7FFE87A3F690
    public void GetBaseLayouts(){} // RVA: 0x7FFE87A3F710
    public void IsBasedOn(){} // RVA: 0x7FFE87A3F870
    public void AddMatcher(){} // RVA: 0x7FFE87A3F9C0
}

public class CollectionFixup : Object
{
    public System.Xml.Serialization.XmlSerializationCollectionFixupCallback callback; // 0x10
    public object collection; // 0x18
    public object collectionItems; // 0x20
    public string id; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE875F4220
    public void get_Callback(){} // RVA: 0x7FFE81116380
    public void get_Collection(){} // RVA: 0x7FFE810FE7C0
    public void get_Id(){} // RVA: 0x7FFE81129130
    public void get_CollectionItems(){} // RVA: 0x7FFE811290C0
    public void set_CollectionItems(){} // RVA: 0x7FFE811290D0
}

public class CollectionHeaderTypeInfo`2 : HeaderTypeInfo`2
{
    public int minimalCount;

    // ── Methods ──
    public void .ctor(){}
    public void get_Separator(){} // RVA: 0x7FFE80E2E2E0
    public void TryParse(){} // RVA: 0x7FFE80E32650
}

public class CollectionItemFixup : Object
{
    public System.Array list; // 0x10
    public int index; // 0x18
    public string id; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86A93700
    public void get_Collection(){} // RVA: 0x7FFE81116380
    public void get_Index(){} // RVA: 0x7FFE813DB630
    public void get_Id(){} // RVA: 0x7FFE811290C0
}

public class Collider : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE881FF1F0
    public void Lerp(){} // RVA: 0x7FFE881FF320
}

public class ColliderConfig : ValueType
{
    public bool isMirrored; // 0x10

    // ── Methods ──
    public void Create(){} // RVA: 0x7FFE8A4818F0
    public void get_axis(){} // RVA: 0x7FFE8A481950
}

public class ColliderToRemoveData : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE881F4650
}

public class Collision : ValueType
{
}

public class CollisionDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81159C20
    public void Invoke(){} // RVA: 0x7FFE81159CF0
    public void BeginInvoke(){} // RVA: 0x7FFE81159D20
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class CollisionEnterDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE83F84C40
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE82886970
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class CollisionEvent : ValueType
{
}

public class CollisionEventsJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFE881A04A0
}

public class CollisionExitDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE83F84C40
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE82886970
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class CollisionImpulseDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81161BB0
    public void Invoke(){} // RVA: 0x7FFE81161C80
    public void BeginInvoke(){} // RVA: 0x7FFE81161CB0
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class CollisionModule : ValueType
{
    public UnityEngine.ParticleSystem m_ParticleSystem; // 0x10
    public object field_1; // 0x96
    public object field_2; // 0x97
    public object field_3; // 0x98
    public object field_4; // 0x99
    public object field_5; // 0x9A
    public object field_6; // 0x9B
    public object field_7; // 0x9C
    public object field_8; // 0x9D
    public object field_9; // 0x9E
    public object field_10; // 0x9F
    public object field_11; // 0xA0
    public object field_12; // 0xA1
    public object field_13; // 0xA2
    public object field_14; // 0xA3
    public object field_15; // 0xA4
    public object field_16; // 0xA5
    public object field_17; // 0xA6
    public object field_18; // 0xA7
    public object field_19; // 0xA8
    public object field_20; // 0xA9
    public object field_21; // 0xAA
    public object field_22; // 0xAB

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void get_enabled(){} // RVA: 0x7FFE87CF5A70
    public void set_enabled(){} // RVA: 0x7FFE87CF5AC0
    public void get_type(){} // RVA: 0x7FFE87CF5B20
    public void set_type(){} // RVA: 0x7FFE87CF5B70
    public void get_mode(){} // RVA: 0x7FFE87CF5BD0
    public void set_mode(){} // RVA: 0x7FFE87CF5C20
    public void get_dampen(){} // RVA: 0x7FFE87CF5C80
    public void set_dampen(){} // RVA: 0x7FFE87CF5CF0
    public void get_dampenMultiplier(){} // RVA: 0x7FFE87CF5D50
    public void set_dampenMultiplier(){} // RVA: 0x7FFE87CF5DA0
    public void get_bounce(){} // RVA: 0x7FFE87CF5E00
    public void set_bounce(){} // RVA: 0x7FFE87CF5E70
    public void get_bounceMultiplier(){} // RVA: 0x7FFE87CF5ED0
    public void set_bounceMultiplier(){} // RVA: 0x7FFE87CF5F20
    public void get_lifetimeLoss(){} // RVA: 0x7FFE87CF5F80
    public void set_lifetimeLoss(){} // RVA: 0x7FFE87CF5FF0
    public void get_lifetimeLossMultiplier(){} // RVA: 0x7FFE87CF6050
    public void set_lifetimeLossMultiplier(){} // RVA: 0x7FFE87CF60A0
    public void get_minKillSpeed(){} // RVA: 0x7FFE87CF6100
    public void set_minKillSpeed(){} // RVA: 0x7FFE87CF6150
    public void get_maxKillSpeed(){} // RVA: 0x7FFE87CF61B0
    public void set_maxKillSpeed(){} // RVA: 0x7FFE87CF6200
    public void get_collidesWith(){} // RVA: 0x7FFE87CF6260
    public void set_collidesWith(){} // RVA: 0x7FFE87CF62C0
    public void get_enableDynamicColliders(){} // RVA: 0x7FFE87CF6320
    public void set_enableDynamicColliders(){} // RVA: 0x7FFE87CF6370
    public void get_maxCollisionShapes(){} // RVA: 0x7FFE87CF63D0
    public void set_maxCollisionShapes(){} // RVA: 0x7FFE87CF6420
    public void get_quality(){} // RVA: 0x7FFE87CF6480
    public void set_quality(){} // RVA: 0x7FFE87CF64D0
    public void get_voxelSize(){} // RVA: 0x7FFE87CF6530
    public void set_voxelSize(){} // RVA: 0x7FFE87CF6580
    public void get_radiusScale(){} // RVA: 0x7FFE87CF65E0
    public void set_radiusScale(){} // RVA: 0x7FFE87CF6630
    public void get_sendCollisionMessages(){} // RVA: 0x7FFE87CF6690
    public void set_sendCollisionMessages(){} // RVA: 0x7FFE87CF66E0
    public void get_colliderForce(){} // RVA: 0x7FFE87CF6740
    public void set_colliderForce(){} // RVA: 0x7FFE87CF6790
    public void get_multiplyColliderForceByCollisionAngle(){} // RVA: 0x7FFE87CF67F0
    public void set_multiplyColliderForceByCollisionAngle(){} // RVA: 0x7FFE87CF6840
    public void get_multiplyColliderForceByParticleSpeed(){} // RVA: 0x7FFE87CF68A0
    public void set_multiplyColliderForceByParticleSpeed(){} // RVA: 0x7FFE87CF68F0
    public void get_multiplyColliderForceByParticleSize(){} // RVA: 0x7FFE87CF6950
    public void set_multiplyColliderForceByParticleSize(){} // RVA: 0x7FFE87CF69A0
    public void AddPlane(){} // RVA: 0x7FFE87CF6A00
    public void RemovePlane(){} // RVA: 0x7FFE87CF6AC0 | overloaded x2
    public void RemovePlaneObject(){} // RVA: 0x7FFE87CF6AC0
    public void SetPlane(){} // RVA: 0x7FFE87CF6B20
    public void GetPlane(){} // RVA: 0x7FFE87CF6B90
    public void get_planeCount(){} // RVA: 0x7FFE87CF6BF0
    public void get_enabled_Injected(){} // RVA: 0x7FFE87CF5A70
    public void set_enabled_Injected(){} // RVA: 0x7FFE87CF5AC0
    public void get_type_Injected(){} // RVA: 0x7FFE87CF5B20
    public void set_type_Injected(){} // RVA: 0x7FFE87CF5B70
    public void get_mode_Injected(){} // RVA: 0x7FFE87CF5BD0
    public void set_mode_Injected(){} // RVA: 0x7FFE87CF5C20
    public void get_dampen_Injected(){} // RVA: 0x7FFE87CF6C40
    public void set_dampen_Injected(){} // RVA: 0x7FFE87CF6CA0
    public void get_dampenMultiplier_Injected(){} // RVA: 0x7FFE87CF5D50
    public void set_dampenMultiplier_Injected(){} // RVA: 0x7FFE87CF5DA0
    public void get_bounce_Injected(){} // RVA: 0x7FFE87CF6D00
    public void set_bounce_Injected(){} // RVA: 0x7FFE87CF6D60
    public void get_bounceMultiplier_Injected(){} // RVA: 0x7FFE87CF5ED0
    public void set_bounceMultiplier_Injected(){} // RVA: 0x7FFE87CF5F20
    public void get_lifetimeLoss_Injected(){} // RVA: 0x7FFE87CF6DC0
    public void set_lifetimeLoss_Injected(){} // RVA: 0x7FFE87CF6E20
    public void get_lifetimeLossMultiplier_Injected(){} // RVA: 0x7FFE87CF6050
    public void set_lifetimeLossMultiplier_Injected(){} // RVA: 0x7FFE87CF60A0
    public void get_minKillSpeed_Injected(){} // RVA: 0x7FFE87CF6100
    public void set_minKillSpeed_Injected(){} // RVA: 0x7FFE87CF6150
    public void get_maxKillSpeed_Injected(){} // RVA: 0x7FFE87CF61B0
    public void set_maxKillSpeed_Injected(){} // RVA: 0x7FFE87CF6200
    public void get_collidesWith_Injected(){} // RVA: 0x7FFE87CF6E80
    public void set_collidesWith_Injected(){} // RVA: 0x7FFE87CF6EE0
    public void get_enableDynamicColliders_Injected(){} // RVA: 0x7FFE87CF6320
    public void set_enableDynamicColliders_Injected(){} // RVA: 0x7FFE87CF6370
    public void get_maxCollisionShapes_Injected(){} // RVA: 0x7FFE87CF63D0
    public void set_maxCollisionShapes_Injected(){} // RVA: 0x7FFE87CF6420
    public void get_quality_Injected(){} // RVA: 0x7FFE87CF6480
    public void set_quality_Injected(){} // RVA: 0x7FFE87CF64D0
    public void get_voxelSize_Injected(){} // RVA: 0x7FFE87CF6530
    public void set_voxelSize_Injected(){} // RVA: 0x7FFE87CF6580
    public void get_radiusScale_Injected(){} // RVA: 0x7FFE87CF65E0
    public void set_radiusScale_Injected(){} // RVA: 0x7FFE87CF6630
    public void get_sendCollisionMessages_Injected(){} // RVA: 0x7FFE87CF6690
    public void set_sendCollisionMessages_Injected(){} // RVA: 0x7FFE87CF66E0
    public void get_colliderForce_Injected(){} // RVA: 0x7FFE87CF6740
    public void set_colliderForce_Injected(){} // RVA: 0x7FFE87CF6790
    public void get_multiplyColliderForceByCollisionAngle_Injected(){} // RVA: 0x7FFE87CF67F0
    public void set_multiplyColliderForceByCollisionAngle_Injected(){} // RVA: 0x7FFE87CF6840
    public void get_multiplyColliderForceByParticleSpeed_Injected(){} // RVA: 0x7FFE87CF68A0
    public void set_multiplyColliderForceByParticleSpeed_Injected(){} // RVA: 0x7FFE87CF68F0
    public void get_multiplyColliderForceByParticleSize_Injected(){} // RVA: 0x7FFE87CF6950
    public void set_multiplyColliderForceByParticleSize_Injected(){} // RVA: 0x7FFE87CF69A0
    public void AddPlane_Injected(){} // RVA: 0x7FFE87CF6A00
    public void RemovePlane_Injected(){} // RVA: 0x7FFE87CF6A60
    public void RemovePlaneObject_Injected(){} // RVA: 0x7FFE87CF6AC0
    public void SetPlane_Injected(){} // RVA: 0x7FFE87CF6B20
    public void GetPlane_Injected(){} // RVA: 0x7FFE87CF6B90
    public void get_planeCount_Injected(){} // RVA: 0x7FFE87CF6BF0
}

public class CollisionRecord : ValueType
{
}

public class CollisionResistanceMultiplier : ValueType
{
}

public class CollisionShape : ValueType
{
    // ── Methods ──
    public void ToAABB(){} // RVA: 0x7FFE881A9CA0
    public void ToSphere(){} // RVA: 0x7FFE881A9CD0
    public void ToCapsule(){} // RVA: 0x7FFE881A9CF0
    public void ToBox(){} // RVA: 0x7FFE881A9D20
    public void ToPlane(){} // RVA: 0x7FFE881A9CA0
}

public class CollisionsJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFE8819A810
    public void GetCollision(){} // RVA: 0x7FFE8819B6F0
    public void SetCollision(){} // RVA: 0x7FFE8819B710
    public void FindCollision(){} // RVA: 0x7FFE8819B730
}

public class Color32EqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE878A5A80
    public void GetHashCode(){} // RVA: 0x7FFE878A5AC0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class Color32Surrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFE8A4E16F0
    public void SetObjectData(){} // RVA: 0x7FFE8A4E1810
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ColorBySpeedModule : ValueType
{
    public UnityEngine.ParticleSystem m_ParticleSystem; // 0x10
    public object field_1; // 0x134
    public object field_2; // 0x135

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void get_enabled(){} // RVA: 0x7FFE87CFE230
    public void set_enabled(){} // RVA: 0x7FFE87CFE280
    public void get_color(){} // RVA: 0x7FFE87CFE2E0
    public void set_color(){} // RVA: 0x7FFE87CFE360
    public void get_range(){} // RVA: 0x7FFE87CFE3C0
    public void set_range(){} // RVA: 0x7FFE87CFE420
    public void get_enabled_Injected(){} // RVA: 0x7FFE87CFE230
    public void set_enabled_Injected(){} // RVA: 0x7FFE87CFE280
    public void get_color_Injected(){} // RVA: 0x7FFE87CFE480
    public void set_color_Injected(){} // RVA: 0x7FFE87CFE4E0
    public void get_range_Injected(){} // RVA: 0x7FFE87CFE540
    public void set_range_Injected(){} // RVA: 0x7FFE87CFE5A0
}

public class ColorEqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE878A5680
    public void GetHashCode(){} // RVA: 0x7FFE878A5740
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ColorOverLifetimeModule : ValueType
{
    public UnityEngine.ParticleSystem m_ParticleSystem; // 0x10
    public object field_1; // 0x132

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void get_enabled(){} // RVA: 0x7FFE87CFDFE0
    public void set_enabled(){} // RVA: 0x7FFE87CFE030
    public void get_color(){} // RVA: 0x7FFE87CFE090
    public void set_color(){} // RVA: 0x7FFE87CFE110
    public void get_enabled_Injected(){} // RVA: 0x7FFE87CFDFE0
    public void set_enabled_Injected(){} // RVA: 0x7FFE87CFE030
    public void get_color_Injected(){} // RVA: 0x7FFE87CFE170
    public void set_color_Injected(){} // RVA: 0x7FFE87CFE1D0
}

public class ColorPaletteData : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ColorPaletteRoot : MonoBehaviour
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FBD50
}

public class ColorSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFE8A4E1470
    public void SetObjectData(){} // RVA: 0x7FFE8A4E1590
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ColorTweenCallback : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8801EDC0
}

public class Colorf : ValueType
{
    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFE86CB1630
}

public class ColumnData : Object
{
    public UnityEngine.UIElements.Internal.MultiColumnHeaderColumn _control; // 0x10
    public UnityEngine.UIElements.Internal.MultiColumnHeaderColumnResizeHandle _resizeHandle; // 0x18

    // ── Methods ──
    public void get_control(){} // RVA: 0x7FFE81116380
    public void set_control(){} // RVA: 0x7FFE810FCE30
    public void get_resizeHandle(){} // RVA: 0x7FFE810FE7C0
    public void set_resizeHandle(){} // RVA: 0x7FFE81161E80
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ColumnError : ValueType
{
}

public class ColumnState : ValueType
{
}

public class ComNativeDescriptionProvider : TypeDescriptionProvider
{
    public System.ComponentModel.IComNativeDescriptorHandler _handler; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE811290D0
    public void get_Handler(){} // RVA: 0x7FFE811290C0
    public void set_Handler(){} // RVA: 0x7FFE811290D0
    public void GetTypeDescriptor(){} // RVA: 0x7FFE877EB090
}

public class ComNativeTypeDescriptor : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
    public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7FFE877EB290
    public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x7FFE877EB350
    public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x7FFE813240E0
    public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7FFE877EB3B0
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x7FFE877EB480
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x7FFE877EB550
    public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7FFE877EB620
    public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x7FFE877EB760 | overloaded x2
    public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7FFE877EB8A0 | overloaded x2
    public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x7FFE810FE7C0
}

public class CommonName : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86712160
}

public class CompareDevicesByUserAccount : ValueType
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFE879EDA20
    public void GetUserAccountHandleForDevice(){} // RVA: 0x7FFE84BAB710
}

public class ComparePerformanceStatsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A4F4CC0
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE82886970
    public void EndInvoke(){} // RVA: 0x7FFE82268F40
}

public class Comparers : Object
{
    public Comparers<U,T> Default;
    public System.Collections.Generic.IEqualityComparer`1<U> _keyComparer;
    public System.Collections.Generic.IEqualityComparer`1<T> _valueComparer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4F230
    public void get_KeyComparer(){} // RVA: 0x7FFE80E2E2E0
    public void get_KeyOnlyComparer(){} // RVA: 0x7FFE80E2E2E0
    public void get_ValueComparer(){} // RVA: 0x7FFE80E2E2E0
    public void Equals(){} // RVA: 0x7FFE810A1420
    public void GetHashCode(){} // RVA: 0x7FFE810A1420
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Equals(){} // RVA: 0x7FFE810A1420
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetHashCode(){} // RVA: 0x7FFE810A1420
    public void Get(){} // RVA: 0x7FFE80E2E440
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class CompleteOnInvokePromise : Task`1
{
    public System.Collections.Generic.IList`1<System.Threading.Tasks.Task> _tasks; // 0x58

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE867744F0
    public void Invoke(){} // RVA: 0x7FFE86774610
    public void get_InvokeMayRunArbitraryCode(){} // RVA: 0x7FFE811E0850
}

public class CompositeSyntax : ValueType
{
    public UnityEngine.InputSystem.InputAction m_Action; // 0x10

    // ── Methods ──
    public void get_bindingIndex(){} // RVA: 0x7FFE878EA160
    public void .ctor(){} // RVA: 0x7FFE878EA190
    public void With(){} // RVA: 0x7FFE878EA260
}

public class CompressFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8400E500
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE8A2802D0
    public void EndInvoke(){} // RVA: 0x7FFE826F5E00
}

public class ComputeShaders : Object
{
    // ── Methods ──
    public void Clone(){} // RVA: 0x7FFE87A84990
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ConcreteFormattableString : FormattableString
{
    public string _format; // 0x10
    public object[] _arguments; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
    public void get_Format(){} // RVA: 0x7FFE81116380
    public void GetArguments(){} // RVA: 0x7FFE810FE7C0
    public void get_ArgumentCount(){} // RVA: 0x7FFE84023030
    public void GetArgument(){} // RVA: 0x7FFE86846150
    public void ToString(){} // RVA: 0x7FFE86885CB0
}

public class ConditionalExpressionProxy : Object
{
    public System.Linq.Expressions.ConditionalExpression _node; // 0x10
    public object field_1; // 0xA7
    public object field_2; // 0xA8
    public object field_3; // 0xA9
    public object field_4; // 0xAA
    public object field_5; // 0xAB
    public object field_6; // 0xAC

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871197E0
    public void get_CanReduce(){} // RVA: 0x7FFE81588760
    public void get_DebugView(){} // RVA: 0x7FFE87119570
    public void get_IfFalse(){} // RVA: 0x7FFE86853DF0
    public void get_IfTrue(){} // RVA: 0x7FFE8189C080
    public void get_NodeType(){} // RVA: 0x7FFE81588A80
    public void get_Test(){} // RVA: 0x7FFE8189BB90
    public void get_Type(){} // RVA: 0x7FFE815888E0
}

public class Config : ValueType
{
}

public class Configuration : Object
{
    public byte[] bytes; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A0D8B40
    public void get_Bytes(){} // RVA: 0x7FFE81116380
}

public class ConfigurationListDebugView : Object
{
    public System.Text.Json.Serialization.ConfigurationList`1<T> <collection>P;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void get_Items(){} // RVA: 0x7FFE80E2E2E0
}

public class ConfigureBasepointCallback : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82AF3A20
    public void Precompute(){} // RVA: 0x7FFE89ED8780
}

public class ConfiguredTaskAwaiter : ValueType
{
    public System.Threading.Tasks.Task`1<T> m_task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4BC00
    public void get_IsCompleted(){} // RVA: 0x7FFE80E2F150
    public void OnCompleted(){} // RVA: 0x7FFE80E460A0
    public void UnsafeOnCompleted(){} // RVA: 0x7FFE80E460A0
    public void GetResult(){} // RVA: 0x7FFE810A1420
}

public class ConfiguredValueTaskAwaiter : ValueType
{
    public System.Threading.Tasks.ValueTask`1<T> _value;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void get_IsCompleted(){} // RVA: 0x7FFE80E2F150
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void OnCompleted(){} // RVA: 0x7FFE80E460A0
    public void UnsafeOnCompleted(){} // RVA: 0x7FFE80E460A0
}

public class ConnectDisposable : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
}

public class ConnectMsg : Object
{
    // ── Methods ──
    public void Process(){} // RVA: 0x7FFE879AA7C0
}

public class ConnectionChangeEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87C8EF10
}

public class ConnectionGroup : Object
{
    public System.Net.ServicePointScheduler _scheduler; // 0x10

    // ── Methods ──
    public void get_Scheduler(){} // RVA: 0x7FFE81116380
    public void .ctor(){} // RVA: 0x7FFE876B3E70
    public void IsEmpty(){} // RVA: 0x7FFE876B4080
    public void RemoveConnection(){} // RVA: 0x7FFE876B40F0
    public void Cleanup(){} // RVA: 0x7FFE876B4190
    public void Close(){} // RVA: 0x7FFE876B42A0
    public void EnqueueOperation(){} // RVA: 0x7FFE876B4740
    public void GetNextOperation(){} // RVA: 0x7FFE876B47A0
    public void FindIdleConnection(){} // RVA: 0x7FFE876B48F0
    public void CreateOrReuseConnection(){} // RVA: 0x7FFE876B4D50
}

public class ConstantExpressionProxy : Object
{
    public System.Linq.Expressions.ConstantExpression _node; // 0x10
    public object field_1; // 0xAE
    public object field_2; // 0xAF
    public object field_3; // 0xB0
    public object field_4; // 0xB1

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871198C0
    public void get_CanReduce(){} // RVA: 0x7FFE81588760
    public void get_DebugView(){} // RVA: 0x7FFE87119570
    public void get_NodeType(){} // RVA: 0x7FFE81588A80
    public void get_Type(){} // RVA: 0x7FFE815888E0
    public void get_Value(){} // RVA: 0x7FFE8189BB90
}

public class ConstraintConfigurationData : ValueType
{
}

public class ConstraintManagerUpdate : ValueType
{
}

public class ConstraintSourceData : ValueType
{
}

public class ConstructJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFE878BA040
}

public class ConstructJobList : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFE878BA010
}

public class ConstructorContext : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void CreateInstance(){} // RVA: 0x7FFE86EA13A0
}

public class ConstructorDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE828B3700
    public void Invoke(){} // RVA: 0x7FFE81159A50
}

public class ContactEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84420600
    public void Invoke(){} // RVA: 0x7FFE83F852E0
}

public class ContainerContext : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE811C55F0
}

public class ContainerHeight : Object
{
    public UnityEngine.Transform _containerTop; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Initialize(){} // RVA: 0x7FFE899C76A0
    public void set_Height(){} // RVA: 0x7FFE899C76A0
    public void op_Implicit(){} // RVA: 0x7FFE899C76A0
    public void CompareBaseObjects(){} // RVA: 0x7FFE899C76A0
    public void IsNativeObjectAlive(){} // RVA: 0x7FFE899C76A0
    public void get_Height(){} // RVA: 0x7FFE899C76A0
    public void get_name(){} // RVA: 0x7FFE899C76A0
}

public class Content : ValueType
{
}

public class ContentBlock : ApiModel
{
    public string _type; // 0x68
    public VRC.Core.ApiLocalizableString _value; // 0x70
    public string _capturedValue; // 0x78
    public string _textAlignment; // 0x80
    public int _fontSize; // 0x88
    public bool _allowTextWrapping; // 0x8C
    public System.Collections.Generic.List`1<System.Collections.Generic.List`1<VRC.Core.ApiLocalizableString>> _points; // 0x90
    public string _imageUrl; // 0x98
    public string _aspectMode; // 0xA0
    public int _height; // 0xA8
    public int _imageSize; // 0xAC
    public System.Collections.Generic.List`1<PopupButtonData> _buttons; // 0xB0
    public string _capture; // 0xB8
    public RequiredValue _requiredFormat; // 0xC0

    // ── Methods ──
    public void get_type(){} // RVA: 0x7FFE81176D50
    public void set_type(){} // RVA: 0x7FFE81176D60
    public void get_value(){} // RVA: 0x7FFE811C3590
    public void set_value(){} // RVA: 0x7FFE811C35A0
    public void get_capturedValue(){} // RVA: 0x7FFE81463AE0
    public void set_capturedValue(){} // RVA: 0x7FFE81464570
    public void get_textAlignment(){} // RVA: 0x7FFE81280C30
    public void set_textAlignment(){} // RVA: 0x7FFE81282380
    public void get_fontSize(){} // RVA: 0x7FFE8194AD00
    public void set_fontSize(){} // RVA: 0x7FFE8194A400
    public void get_allowTextWrapping(){} // RVA: 0x7FFE81163520
    public void set_allowTextWrapping(){} // RVA: 0x7FFE81163530
    public void get_points(){} // RVA: 0x7FFE8154EB60
    public void set_points(){} // RVA: 0x7FFE818CE320
    public void get_imageUrl(){} // RVA: 0x7FFE817AE360
    public void set_imageUrl(){} // RVA: 0x7FFE8171B470
    public void get_aspectMode(){} // RVA: 0x7FFE8179C860
    public void set_aspectMode(){} // RVA: 0x7FFE8171B4D0
    public void get_height(){} // RVA: 0x7FFE81A338E0
    public void set_height(){} // RVA: 0x7FFE81A34770
    public void get_imageSize(){} // RVA: 0x7FFE848BEEF0
    public void set_imageSize(){} // RVA: 0x7FFE848BEF00
    public void get_buttons(){} // RVA: 0x7FFE81166040
    public void set_buttons(){} // RVA: 0x7FFE81166050
    public void get_capture(){} // RVA: 0x7FFE811660B0
    public void set_capture(){} // RVA: 0x7FFE811660C0
    public void get_requiredFormat(){} // RVA: 0x7FFE81166120
    public void set_requiredFormat(){} // RVA: 0x7FFE81166130
    public void .ctor(){} // RVA: 0x7FFE8A2D86C0
}

public class ContentHeightCacheInfo : ValueType
{
    // ── Methods ──
    public void .ctor(){}
}

public class ContentInfo : Object
{
    public string contentType; // 0x10
    public Mono.Security.ASN1 content; // 0x18
    public object field_2; // 0x6

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE866FA5C0 | overloaded x4
    public void get_ASN1(){} // RVA: 0x7FFE866FA800
    public void get_Content(){} // RVA: 0x7FFE810FE7C0
    public void set_Content(){} // RVA: 0x7FFE81161E80
    public void get_ContentType(){} // RVA: 0x7FFE81116380
    public void set_ContentType(){} // RVA: 0x7FFE810FCE30
    public void GetASN1(){} // RVA: 0x7FFE866FA810
}

public class ContentList : ApiModel
{
    public VRC.Core.ApiLocalizableString _name; // 0x68
    public VRC.Core.ApiLocalizableString _shortName; // 0x70
    public string _sortHeading; // 0x78
    public string _sortOwnership; // 0x80
    public string _sortOrder; // 0x88
    public string _platform; // 0x90
    public System.Nullable`1<bool> _avatarSpecific; // 0x98
    public string _tag; // 0xA0
    public string _type; // 0xA8
    public string _bannersTag; // 0xB0
    public string _marketplace; // 0xB8
    public System.Collections.Generic.IReadOnlyDictionary`2<string,Token> _queryParams; // 0xC0

    // ── Methods ──
    public void get_name(){} // RVA: 0x7FFE81176D50
    public void set_name(){} // RVA: 0x7FFE81176D60
    public void get_shortName(){} // RVA: 0x7FFE811C3590
    public void set_shortName(){} // RVA: 0x7FFE811C35A0
    public void get_sortHeading(){} // RVA: 0x7FFE81463AE0
    public void set_sortHeading(){} // RVA: 0x7FFE81464570
    public void get_sortOwnership(){} // RVA: 0x7FFE81280C30
    public void set_sortOwnership(){} // RVA: 0x7FFE81282380
    public void get_sortOrder(){} // RVA: 0x7FFE8113A010
    public void set_sortOrder(){} // RVA: 0x7FFE81280F90
    public void get_platform(){} // RVA: 0x7FFE8154EB60
    public void set_platform(){} // RVA: 0x7FFE818CE320
    public void get_avatarSpecific(){} // RVA: 0x7FFE86F105C0
    public void set_avatarSpecific(){} // RVA: 0x7FFE86F105D0
    public void get_tag(){} // RVA: 0x7FFE8179C860
    public void set_tag(){} // RVA: 0x7FFE8171B4D0
    public void get_type(){} // RVA: 0x7FFE817AB5E0
    public void set_type(){} // RVA: 0x7FFE81857260
    public void get_bannersTag(){} // RVA: 0x7FFE81166040
    public void set_bannersTag(){} // RVA: 0x7FFE81166050
    public void get_marketplace(){} // RVA: 0x7FFE811660B0
    public void set_marketplace(){} // RVA: 0x7FFE811660C0
    public void get_queryParams(){} // RVA: 0x7FFE81166120
    public void set_queryParams(){} // RVA: 0x7FFE81166130
    public void WriteField(){} // RVA: 0x7FFE8A2D80F0
    public void .ctor(){} // RVA: 0x7FFE8A2D8280
}

public class ContentReader : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87446580 | overloaded x2
    public void ReadContentFrom(){} // RVA: 0x7FFE87446ED0 | overloaded x2
}

public class ContentSectionElementSet : ValueType
{
}

public class Context : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86744BE0
}

public class ContextRestoreSink : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE811DAE00
    public void SyncProcessMessage(){} // RVA: 0x7FFE8682B4B0
    public void AsyncProcessMessage(){} // RVA: 0x7FFE8682B6F0
}

public class ContingentProperties : Object
{
    // ── Methods ──
    public void SetCompleted(){} // RVA: 0x7FFE86A90130
    public void UnregisterCancellationCallback(){} // RVA: 0x7FFE86A90160
    public void .ctor(){} // RVA: 0x7FFE86A90250
}

public class ContinuationWrapper : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86888D80
    public void Invoke(){} // RVA: 0x7FFE84A02160
}

public class Control : Object
{
    // ── Methods ──
    public void GetSubParameter(){} // RVA: 0x7FFE8A47A6E0
    public void GetLabel(){} // RVA: 0x7FFE8A47A720
    public void .ctor(){} // RVA: 0x7FFE820E6240
}

public class ControlBitRangeNode : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8793CC20
}

public class ControlBuilder : ValueType
{
    public UnityEngine.InputSystem.InputControl _control; // 0x10

    // ── Methods ──
    public void get_control(){} // RVA: 0x7FFE8284EF60
    public void set_control(){} // RVA: 0x7FFE81D7E9E0
    public void At(){} // RVA: 0x7FFE87931CA0
    public void WithParent(){} // RVA: 0x7FFE87931D80
    public void WithName(){} // RVA: 0x7FFE87931DF0
    public void WithDisplayName(){} // RVA: 0x7FFE87931E90
    public void WithShortDisplayName(){} // RVA: 0x7FFE87931F70
    public void WithLayout(){} // RVA: 0x7FFE87932050
    public void WithUsages(){} // RVA: 0x7FFE879320C0
    public void WithAliases(){} // RVA: 0x7FFE879320F0
    public void WithChildren(){} // RVA: 0x7FFE87932120
    public void WithStateBlock(){} // RVA: 0x7FFE87932150
    public void WithDefaultState(){} // RVA: 0x7FFE87932180
    public void WithMinAndMax(){} // RVA: 0x7FFE879321C0
    public void WithProcessor(){} // RVA: 0x7FFE810A1420
    public void IsNoisy(){} // RVA: 0x7FFE87932200
    public void IsSynthetic(){} // RVA: 0x7FFE87932230
    public void DontReset(){} // RVA: 0x7FFE87932270
    public void IsButton(){} // RVA: 0x7FFE879322D0
    public void Finish(){} // RVA: 0x7FFE87932310
}

public class ControlDataForExport : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ControlItem : ValueType
{
    public UnityEngine.InputSystem.Utilities.InternedString _name; // 0x10
    public UnityEngine.InputSystem.Utilities.InternedString _layout; // 0x20
    public UnityEngine.InputSystem.Utilities.InternedString _variants; // 0x30
    public string _useStateFrom; // 0x40
    public string _displayName; // 0x48
    public string _shortDisplayName; // 0x50
    public UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.InternedString> _usages; // 0x58
    public UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.InternedString> _aliases; // 0x68
    public UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.NamedValue> _parameters; // 0x78
    public UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.NameAndParameters> _processors; // 0x88
    public uint _offset; // 0x98
    public uint _bit; // 0x9C
    public uint _sizeInBits; // 0xA0
    public UnityEngine.InputSystem.Utilities.FourCC _format; // 0xA4
    public 0x6654880C _flags; // 0xA8
    public int _arraySize; // 0xAC
    public UnityEngine.InputSystem.Utilities.PrimitiveValue _defaultState; // 0xB0
    public UnityEngine.InputSystem.Utilities.PrimitiveValue _minValue; // 0xC0
    public UnityEngine.InputSystem.Utilities.PrimitiveValue _maxValue; // 0xD0
    public UnityEngine.InputSystem.Utilities.InternedString[] m_Array; // 0x10
    public int m_StartIndex; // 0x18
    public int m_Length; // 0x1C
    public object ԡTf; // 0xCB90
    public object UnityEngine.InputSystem.Utilities;
    public object field_24; // 0xCCB0

    // ── Methods ──
    public void get_name(){} // RVA: 0x7FFE8151C410
    public void set_name(){} // RVA: 0x7FFE82D0A490
    public void get_layout(){} // RVA: 0x7FFE826F6B90
    public void set_layout(){} // RVA: 0x7FFE82D033D0
    public void get_variants(){} // RVA: 0x7FFE82C84C90
    public void set_variants(){} // RVA: 0x7FFE82C84CA0
    public void get_useStateFrom(){} // RVA: 0x7FFE8144E200
    public void set_useStateFrom(){} // RVA: 0x7FFE81129890
    public void get_displayName(){} // RVA: 0x7FFE8143BA80
    public void set_displayName(){} // RVA: 0x7FFE81437330
    public void get_shortDisplayName(){} // RVA: 0x7FFE81178740
    public void set_shortDisplayName(){} // RVA: 0x7FFE81123200
    public void get_usages(){} // RVA: 0x7FFE81C1C440
    public void set_usages(){} // RVA: 0x7FFE87A37AB0
    public void get_aliases(){} // RVA: 0x7FFE81E90B10
    public void set_aliases(){} // RVA: 0x7FFE87A37B10
    public void get_parameters(){} // RVA: 0x7FFE8432FD10
    public void set_parameters(){} // RVA: 0x7FFE8432FD20
    public void get_processors(){} // RVA: 0x7FFE86DDD4A0
    public void set_processors(){} // RVA: 0x7FFE87A37B70
    public void get_offset(){} // RVA: 0x7FFE8194AD00
    public void set_offset(){} // RVA: 0x7FFE8194A400
    public void get_bit(){} // RVA: 0x7FFE842B66B0
    public void set_bit(){} // RVA: 0x7FFE848F07E0
    public void get_sizeInBits(){} // RVA: 0x7FFE814AA220
    public void set_sizeInBits(){} // RVA: 0x7FFE81C8DB30
    public void get_format(){} // RVA: 0x7FFE814AA230
    public void set_format(){} // RVA: 0x7FFE81680470
    public void get_flags(){} // RVA: 0x7FFE82B06A40
    public void set_flags(){} // RVA: 0x7FFE82B06FA0
    public void get_arraySize(){} // RVA: 0x7FFE82B06F90
    public void set_arraySize(){} // RVA: 0x7FFE82B06A30
    public void get_defaultState(){} // RVA: 0x7FFE86C70870
    public void set_defaultState(){} // RVA: 0x7FFE86C70880
    public void get_minValue(){} // RVA: 0x7FFE817DEEA0
    public void set_minValue(){} // RVA: 0x7FFE817DD430
    public void get_maxValue(){} // RVA: 0x7FFE86EF7740
    public void set_maxValue(){} // RVA: 0x7FFE86EF7750
    public void get_isModifyingExistingControl(){} // RVA: 0x7FFE87A37BD0
    public void set_isModifyingExistingControl(){} // RVA: 0x7FFE87A37BE0
    public void get_isNoisy(){} // RVA: 0x7FFE87A37C00
    public void set_isNoisy(){} // RVA: 0x7FFE87A37C10
    public void get_isSynthetic(){} // RVA: 0x7FFE87A37C30
    public void set_isSynthetic(){} // RVA: 0x7FFE87A37C40
    public void get_dontReset(){} // RVA: 0x7FFE87A37C60
    public void set_dontReset(){} // RVA: 0x7FFE87A37C70
    public void get_isFirstDefinedInThisLayout(){} // RVA: 0x7FFE87A37C90
    public void set_isFirstDefinedInThisLayout(){} // RVA: 0x7FFE87A37CA0
    public void get_isArray(){} // RVA: 0x7FFE87A37CC0
    public void Merge(){} // RVA: 0x7FFE87A37CD0
}

public class ControlItemJson : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87A3B7C0
    public void ToLayout(){} // RVA: 0x7FFE87A3B7D0
    public void FromControlItems(){} // RVA: 0x7FFE87A3C5B0
}

public class ControlSchemeChangeSyntax : ValueType
{
    // ── Methods ──
    public void AndPairRemainingDevices(){} // RVA: 0x7FFE879ED9C0
}

public class ControlSchemeSyntax : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE878EA500 | overloaded x2
    public void WithBindingGroup(){} // RVA: 0x7FFE878EA5D0
    public void WithRequiredDevice(){} // RVA: 0x7FFE878EA7D0 | overloaded x2
    public void WithOptionalDevice(){} // RVA: 0x7FFE878EA820 | overloaded x2
    public void OrWithRequiredDevice(){} // RVA: 0x7FFE878EA870 | overloaded x2
    public void OrWithOptionalDevice(){} // RVA: 0x7FFE878EA8C0 | overloaded x2
    public void DeviceTypeToControlPath(){} // RVA: 0x7FFE80E2E2E0
    public void Done(){} // RVA: 0x7FFE878EA910
    public void AddDeviceEntry(){} // RVA: 0x7FFE878EAA40
}

public class ControlSurface : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ControllerState : ValueType
{
}

public class ControllerState2 : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86CB1400
}

public class ControllerState4 : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86CB13B0
}
