// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 685

public class Clipper : ClipperBase
{
    public int ReverseSolution;
    public int StrictlySimple;
    public int ioPreserveCollinear;
    public 0x6B22C440 m_ClipType; // 0x48
    public Maxima m_Maxima; // 0x50
    public TEdge m_SortedEdges; // 0x58
    public System.Collections.Generic.List`1<IntersectNode> m_IntersectList; // 0x60
    public System.Collections.Generic.IComparer`1<IntersectNode> m_IntersectNodeComparer; // 0x68
    public bool m_ExecuteLocked; // 0x70
    public 0x6B22C4F0 m_ClipFillType; // 0x74
    public 0x6B22C4F0 m_SubjFillType; // 0x78
    public System.Collections.Generic.List`1<Join> m_Joins; // 0x80
    public System.Collections.Generic.List`1<Join> m_GhostJoins; // 0x88
    public bool m_UsingPolyTree; // 0x90
    public bool <ReverseSolution>k__BackingField; // 0x91
    public bool <StrictlySimple>k__BackingField; // 0x92

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4861750
    public void InsertMaxima(){} // RVA: 0x7FFAC4861D70
    public void get_ReverseSolution(){} // RVA: 0x7FFAC4862190
    public void set_ReverseSolution(){} // RVA: 0x7FFAC48621A0
    public void get_StrictlySimple(){} // RVA: 0x7FFAC3F3F160
    public void set_StrictlySimple(){} // RVA: 0x7FFAC48621B0
    public void Execute(){} // RVA: 0x7FFAC48623B0 | overloaded x4
    public void FixHoleLinkage(){} // RVA: 0x7FFAC4862490
    public void ExecuteInternal(){} // RVA: 0x7FFAC4862530
    public void DisposeAllPolyPts(){} // RVA: 0x7FFAC4862BE0
    public void AddJoin(){} // RVA: 0x7FFAC4862D90
    public void AddGhostJoin(){} // RVA: 0x7FFAC4862EE0
    public void InsertLocalMinimaIntoAEL(){} // RVA: 0x7FFAC4862FD0
    public void InsertEdgeIntoAEL(){} // RVA: 0x7FFAC48635F0
    public void E2InsertsBeforeE1(){} // RVA: 0x7FFAC48639B0
    public void IsEvenOddFillType(){} // RVA: 0x7FFAC4863AC0
    public void IsEvenOddAltFillType(){} // RVA: 0x7FFAC4863AF0
    public void IsContributing(){} // RVA: 0x7FFAC4863B20
    public void SetWindingCount(){} // RVA: 0x7FFAC4863CC0
    public void AddEdgeToSEL(){} // RVA: 0x7FFAC4863F00
    public void PopEdgeFromSEL(){} // RVA: 0x7FFAC48641C0
    public void CopyAELToSEL(){} // RVA: 0x7FFAC48643D0
    public void SwapPositionsInSEL(){} // RVA: 0x7FFAC4864500
    public void AddLocalMaxPoly(){} // RVA: 0x7FFAC4864930
    public void AddLocalMinPoly(){} // RVA: 0x7FFAC48649F0
    public void AddOutPt(){} // RVA: 0x7FFAC4864C90
    public void GetLastOutPt(){} // RVA: 0x7FFAC48650B0
    public void SwapPoints(){} // RVA: 0x7FFAC4865150
    public void HorzSegmentsOverlap(){} // RVA: 0x7FFAC4865180
    public void SetHoleState(){} // RVA: 0x7FFAC48651C0
    public void GetDx(){} // RVA: 0x7FFAC4865390
    public void FirstIsBottomPt(){} // RVA: 0x7FFAC48653D0
    public void GetBottomPt(){} // RVA: 0x7FFAC4865810
    public void GetLowermostRec(){} // RVA: 0x7FFAC4865930
    public void OutRec1RightOfOutRec2(){} // RVA: 0x7FFAC4865AB0
    public void GetOutRec(){} // RVA: 0x7FFAC4865AE0
    public void AppendPolygon(){} // RVA: 0x7FFAC4865B90
    public void ReversePolyPtLinks(){} // RVA: 0x7FFAC4866BC0
    public void SwapSides(){} // RVA: 0x7FFAC4866CC0
    public void SwapPolyIndexes(){} // RVA: 0x7FFAC4866CF0
    public void IntersectEdges(){} // RVA: 0x7FFAC4866D20
    public void DeleteFromSEL(){} // RVA: 0x7FFAC4867340
    public void ProcessHorizontals(){} // RVA: 0x7FFAC4867560
    public void GetHorzDirection(){} // RVA: 0x7FFAC48677B0
    public void ProcessHorizontal(){} // RVA: 0x7FFAC4867810
    public void GetNextInAEL(){} // RVA: 0x7FFAC48681F0
    public void IsMinima(){} // RVA: 0x7FFAC4868220
    public void IsMaxima(){} // RVA: 0x7FFAC4868260
    public void IsIntermediate(){} // RVA: 0x7FFAC4868290
    public void GetMaximaPair(){} // RVA: 0x7FFAC48682D0
    public void GetMaximaPairEx(){} // RVA: 0x7FFAC4868350
    public void ProcessIntersections(){} // RVA: 0x7FFAC4868410
    public void BuildIntersectList(){} // RVA: 0x7FFAC4868690
    public void EdgesAdjacent(){} // RVA: 0x7FFAC4868A60
    public void IntersectNodeSort(){} // RVA: 0x7FFAC4868AA0
    public void FixupIntersectionOrder(){} // RVA: 0x7FFAC4868AC0
    public void ProcessIntersectList(){} // RVA: 0x7FFAC4868E70
    public void Round(){} // RVA: 0x7FFAC4868FC0
    public void TopX(){} // RVA: 0x7FFAC4868FF0
    public void IntersectPoint(){} // RVA: 0x7FFAC4869060
    public void ProcessEdgesAtTopOfScanbeam(){} // RVA: 0x7FFAC48694C0
    public void DoMaxima(){} // RVA: 0x7FFAC4869A50
    public void ReversePaths(){} // RVA: 0x7FFAC4869CB0
    public void Orientation(){} // RVA: 0x7FFAC4869F30
    public void PointCount(){} // RVA: 0x7FFAC4869F50
    public void BuildResult(){} // RVA: 0x7FFAC4869F80
    public void BuildResult2(){} // RVA: 0x7FFAC486A1D0
    public void FixupOutPolyline(){} // RVA: 0x7FFAC486A560
    public void FixupOutPolygon(){} // RVA: 0x7FFAC486A670
    public void DupOutPt(){} // RVA: 0x7FFAC486AB70
    public void GetOverlap(){} // RVA: 0x7FFAC486AEB0
    public void JoinHorz(){} // RVA: 0x7FFAC486AFD0
    public void JoinPoints(){} // RVA: 0x7FFAC486B5E0
    public void PointInPolygon(){} // RVA: 0x7FFAC486CA10 | overloaded x2
    public void Poly2ContainsPoly1(){} // RVA: 0x7FFAC486CB60
    public void FixupFirstLefts1(){} // RVA: 0x7FFAC486CCF0
    public void FixupFirstLefts2(){} // RVA: 0x7FFAC486CEB0
    public void FixupFirstLefts3(){} // RVA: 0x7FFAC486D100
    public void ParseFirstLeft(){} // RVA: 0x7FFAC486D2A0
    public void JoinCommonEdges(){} // RVA: 0x7FFAC486D2C0
    public void UpdateOutPtIdxs(){} // RVA: 0x7FFAC486DC90
    public void DoSimplePolygons(){} // RVA: 0x7FFAC486DCC0
    public void Area(){} // RVA: 0x7FFAC486E1D0 | overloaded x3
    public void SimplifyPolygon(){} // RVA: 0x7FFAC486E240
    public void SimplifyPolygons(){} // RVA: 0x7FFAC486E340
    public void DistanceSqrd(){} // RVA: 0x7FFAC486E440
    public void DistanceFromLineSqrd(){} // RVA: 0x7FFAC486E480
    public void SlopesNearCollinear(){} // RVA: 0x7FFAC486E500
    public void PointsAreClose(){} // RVA: 0x7FFAC486E730
    public void ExcludeOp(){} // RVA: 0x7FFAC486E770
    public void CleanPolygon(){} // RVA: 0x7FFAC486E860
    public void CleanPolygons(){} // RVA: 0x7FFAC486EEA0
    public void Minkowski(){} // RVA: 0x7FFAC486F010
    public void MinkowskiSum(){} // RVA: 0x7FFAC486FB80 | overloaded x2
    public void TranslatePath(){} // RVA: 0x7FFAC486F9A0
    public void MinkowskiDiff(){} // RVA: 0x7FFAC486FDB0
    public void PolyTreeToPaths(){} // RVA: 0x7FFAC486FE80
    public void AddPolyNodeToPaths(){} // RVA: 0x7FFAC486FF40
    public void OpenPathsFromPolyTree(){} // RVA: 0x7FFAC4870130
    public void ClosedPathsFromPolyTree(){} // RVA: 0x7FFAC48702D0
}

public class ClipperBase : Object
{
    public double PreserveCollinear;
    public int Skip;
    public int Unassigned;
    public double tolerance;
    public long loRange;
    public long hiRange;
    public LocalMinima m_MinimaList; // 0x10
    public LocalMinima m_CurrentLM; // 0x18
    public System.Collections.Generic.List`1<System.Collections.Generic.List`1<TEdge>> m_edges; // 0x20
    public Scanbeam m_Scanbeam; // 0x28
    public System.Collections.Generic.List`1<OutRec> m_PolyOuts; // 0x30
    public TEdge m_ActiveEdges; // 0x38
    public bool m_UseFullRange; // 0x40
    public bool m_HasOpenPaths; // 0x41
    public bool <PreserveCollinear>k__BackingField; // 0x42

    // ── Methods ──
    public void near_zero(){} // RVA: 0x7FFAC485CBE0
    public void get_PreserveCollinear(){} // RVA: 0x7FFAC31D90A0
    public void set_PreserveCollinear(){} // RVA: 0x7FFAC31D9200
    public void Swap(){} // RVA: 0x7FFAC485CC00
    public void IsHorizontal(){} // RVA: 0x7FFAC485CC10
    public void PointIsVertex(){} // RVA: 0x7FFAC485CC30
    public void PointOnLineSegment(){} // RVA: 0x7FFAC485CC80
    public void PointOnPolygon(){} // RVA: 0x7FFAC485CE40
    public void SlopesEqual(){} // RVA: 0x7FFAC485D2F0 | overloaded x3
    public void .ctor(){} // RVA: 0x7FFAC485D440
    public void Clear(){} // RVA: 0x7FFAC485D5B0
    public void DisposeLocalMinimaList(){} // RVA: 0x7FFAC485D8A0
    public void RangeTest(){} // RVA: 0x7FFAC485D9E0
    public void InitEdge(){} // RVA: 0x7FFAC485DAC0
    public void InitEdge2(){} // RVA: 0x7FFAC485DBA0
    public void FindNextLocMin(){} // RVA: 0x7FFAC485DC50
    public void ProcessBound(){} // RVA: 0x7FFAC485DD60
    public void AddPath(){} // RVA: 0x7FFAC485E430
    public void AddPaths(){} // RVA: 0x7FFAC485F860
    public void Pt2IsBetweenPt1AndPt3(){} // RVA: 0x7FFAC485F950
    public void RemoveEdge(){} // RVA: 0x7FFAC485F9D0
    public void SetDx(){} // RVA: 0x7FFAC485FB20
    public void InsertLocalMinima(){} // RVA: 0x7FFAC485FB80
    public void PopLocalMinima(){} // RVA: 0x7FFAC485FDA0
    public void ReverseHorizontal(){} // RVA: 0x7FFAC485FE90
    public void Reset(){} // RVA: 0x7FFAC485FEC0
    public void GetBounds(){} // RVA: 0x7FFAC4860330
    public void InsertScanbeam(){} // RVA: 0x7FFAC48607B0
    public void PopScanbeam(){} // RVA: 0x7FFAC4860AB0
    public void LocalMinimaPending(){} // RVA: 0x7FFAC4860B40
    public void CreateOutRec(){} // RVA: 0x7FFAC4860B50
    public void DisposeOutRec(){} // RVA: 0x7FFAC4860D80
    public void UpdateEdgeIntoAEL(){} // RVA: 0x7FFAC4860E90
    public void SwapPositionsInAEL(){} // RVA: 0x7FFAC4861270
    public void DeleteFromAEL(){} // RVA: 0x7FFAC4861530
}

public class ClipperException : Exception
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4874CE0
}

public class ClipperOffset : Object
{
    public System.Collections.Generic.List`1<System.Collections.Generic.List`1<IntPoint>> ArcTolerance; // 0x10
    public System.Collections.Generic.List`1<IntPoint> MiterLimit; // 0x18
    public System.Collections.Generic.List`1<IntPoint> m_destPoly; // 0x20
    public System.Collections.Generic.List`1<DoublePoint> m_normals; // 0x28
    public double m_delta; // 0x30
    public double m_sinA; // 0x38
    public double m_sin; // 0x40
    public double m_cos; // 0x48
    public double m_miterLim; // 0x50
    public double m_StepsPerRad; // 0x58
    public IntPoint m_lowest; // 0x60
    public PolyNode m_polyNodes; // 0x70
    public double <ArcTolerance>k__BackingField; // 0x78
    public double <MiterLimit>k__BackingField; // 0x80
    public double two_pi;
    public double def_arc_tolerance;

    // ── Methods ──
    public void get_ArcTolerance(){} // RVA: 0x7FFAC4870390
    public void set_ArcTolerance(){} // RVA: 0x7FFAC48703A0
    public void get_MiterLimit(){} // RVA: 0x7FFAC48703B0
    public void set_MiterLimit(){} // RVA: 0x7FFAC48703C0
    public void .ctor(){} // RVA: 0x7FFAC48703D0
    public void Clear(){} // RVA: 0x7FFAC4870550
    public void Round(){} // RVA: 0x7FFAC4868FC0
    public void AddPath(){} // RVA: 0x7FFAC48705D0
    public void AddPaths(){} // RVA: 0x7FFAC4870C60
    public void FixOrientations(){} // RVA: 0x7FFAC4870DD0
    public void GetUnitNormal(){} // RVA: 0x7FFAC4871050
    public void DoOffset(){} // RVA: 0x7FFAC4871150
    public void Execute(){} // RVA: 0x7FFAC4872CA0 | overloaded x2
    public void OffsetPoint(){} // RVA: 0x7FFAC48733E0
    public void DoSquare(){} // RVA: 0x7FFAC4873E00
    public void DoMiter(){} // RVA: 0x7FFAC4874440
    public void DoRound(){} // RVA: 0x7FFAC4874700
}

public class ClosingInfo : ValueType
{
    public bool needsClosing; // 0x10
    public bool popViewMatrix; // 0x11
    public bool popScissorClip; // 0x12
    public bool blitAndPopRenderTexture; // 0x13
    public bool PopDefaultMaterial; // 0x14
    public UnityEngine.UIElements.UIR.RenderChainCommand clipUnregisterDrawCommand; // 0x18
    public Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex> clipperRegisterVertices; // 0x20
    public Unity.Collections.NativeSlice`1<ushort> clipperRegisterIndices; // 0x30
    public int clipperRegisterIndexOffset; // 0x40
    public int maskStencilRef; // 0x44
}

public class CmsAuthenticatedDataOutputStream : BaseOutputStream
{
    public System.IO.Stream macStream; // 0x30
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac mac; // 0x38
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerSequenceGenerator cGen; // 0x40
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerSequenceGenerator authGen; // 0x48
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerSequenceGenerator eiGen; // 0x50

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBC9AE20
    public void WriteByte(){} // RVA: 0x7FFACBC9B020
    public void Write(){} // RVA: 0x7FFAC92B2D70
    public void Close(){} // RVA: 0x7FFACBC9B050
}

public class CmsAuthenticatedSecureReadable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Algorithm; // 0x10
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac CryptoObject; // 0x18
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsReadable readable; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8BF0300
    public void get_Algorithm(){} // RVA: 0x7FFAC2F3C380
    public void get_CryptoObject(){} // RVA: 0x7FFAC2F247C0
    public void GetReadable(){} // RVA: 0x7FFACBCA4850
}

public class CmsCompressedOutputStream : BaseOutputStream
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZOutputStream _out; // 0x30
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerSequenceGenerator _sGen; // 0x38
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerSequenceGenerator _cGen; // 0x40
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerSequenceGenerator _eiGen; // 0x48

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBC9D180
    public void WriteByte(){} // RVA: 0x7FFACBC9B020
    public void Write(){} // RVA: 0x7FFAC92B2D70
    public void Close(){} // RVA: 0x7FFACBC9D330
}

public class CmsEnvelopedDataOutputStream : BaseOutputStream
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsEnvelopedGenerator _outer; // 0x30
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO.CipherStream _out; // 0x38
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerSequenceGenerator _cGen; // 0x40
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerSequenceGenerator _envGen; // 0x48
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerSequenceGenerator _eiGen; // 0x50

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBC9AE20
    public void WriteByte(){} // RVA: 0x7FFACBCA1480
    public void Write(){} // RVA: 0x7FFACBCA14B0
    public void Close(){} // RVA: 0x7FFACBCA14E0
}

public class CmsEnvelopedSecureReadable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Algorithm; // 0x10
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBufferedCipher CryptoObject; // 0x18
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsReadable readable; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8BF0300
    public void get_Algorithm(){} // RVA: 0x7FFAC2F3C380
    public void get_CryptoObject(){} // RVA: 0x7FFAC2F247C0
    public void GetReadable(){} // RVA: 0x7FFACBCA4C00
}

public class CmsSignedDataOutputStream : BaseOutputStream
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator outer; // 0x30
    public System.IO.Stream _out; // 0x38
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier _contentOID; // 0x40
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerSequenceGenerator _sGen; // 0x48
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerSequenceGenerator _sigGen; // 0x50
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerSequenceGenerator _eiGen; // 0x58

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBCB2220
    public void WriteByte(){} // RVA: 0x7FFACBCA1480
    public void Write(){} // RVA: 0x7FFACBCA14B0
    public void Close(){} // RVA: 0x7FFACBCB24C0
    public void DoClose(){} // RVA: 0x7FFACBCB24F0
    public void WriteToGenerator(){} // RVA: 0x7FFACBCB3790
}

public class Codec : Object
{
    public Google.Protobuf.FieldCodec`1<U> KeyCodec;
    public Google.Protobuf.FieldCodec`1<T> ValueCodec;
    public uint MapTag;

    // ── Methods ──
    public void .ctor(){}
    public void get_KeyCodec(){} // RVA: 0x7FFAC2C58E90
    public void get_ValueCodec(){} // RVA: 0x7FFAC2C58E90
    public void get_MapTag(){} // RVA: 0x7FFAC2C59960
}

public class Collection : ValueType
{
    public float kBaseScoreForNonGeneratedLayouts;
    public System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,System.Type> layoutTypes; // 0x10
    public System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,string> layoutStrings; // 0x18
    public System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,System.Func`1<UnityEngine.InputSystem.Layouts.InputControlLayout>> layoutBuilders; // 0x20
    public System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString> baseLayoutTable; // 0x28
    public System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString[]> layoutOverrides; // 0x30
    public System.Collections.Generic.HashSet`1<UnityEngine.InputSystem.Utilities.InternedString> layoutOverrideNames; // 0x38
    public System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,PrecompiledLayout> precompiledLayouts; // 0x40
    public System.Collections.Generic.List`1<LayoutMatcher> layoutMatchers; // 0x48

    // ── Methods ──
    public void Allocate(){} // RVA: 0x7FFAC9694AD0
    public void TryFindLayoutForType(){} // RVA: 0x7FFAC9695150
    public void TryFindMatchingLayout(){} // RVA: 0x7FFAC9695350
    public void HasLayout(){} // RVA: 0x7FFAC9695600
    public void TryLoadLayoutInternal(){} // RVA: 0x7FFAC9695730
    public void TryLoadLayout(){} // RVA: 0x7FFAC9695E50
    public void GetBaseLayoutName(){} // RVA: 0x7FFAC9696520
    public void GetRootLayoutName(){} // RVA: 0x7FFAC9696640
    public void ComputeDistanceInInheritanceHierarchy(){} // RVA: 0x7FFAC9696780
    public void FindLayoutThatIntroducesControl(){} // RVA: 0x7FFAC9696890
    public void GetControlTypeForLayout(){} // RVA: 0x7FFAC9696B50
    public void ValueTypeIsAssignableFrom(){} // RVA: 0x7FFAC9696E20
    public void IsGeneratedLayout(){} // RVA: 0x7FFAC9696F30
    public void GetBaseLayouts(){} // RVA: 0x7FFAC9696FB0
    public void IsBasedOn(){} // RVA: 0x7FFAC9697110
    public void AddMatcher(){} // RVA: 0x7FFAC9697260
}

public class CollectionFixup : Object
{
    public System.Xml.Serialization.XmlSerializationCollectionFixupCallback Callback; // 0x10
    public object Collection; // 0x18
    public object Id; // 0x20
    public string CollectionItems; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC924BAB0
    public void get_Callback(){} // RVA: 0x7FFAC2F3C380
    public void get_Collection(){} // RVA: 0x7FFAC2F247C0
    public void get_Id(){} // RVA: 0x7FFAC2F4F130
    public void get_CollectionItems(){} // RVA: 0x7FFAC2F4F0C0
    public void set_CollectionItems(){} // RVA: 0x7FFAC2F4F0D0
}

public class CollectionHeaderTypeInfo`2 : HeaderTypeInfo`2
{
    public int Separator;
    public string separator;
    public System.Net.Http.Headers.TryParseListDelegate`1<T> parser;

    // ── Methods ──
    public void .ctor(){}
    public void get_Separator(){} // RVA: 0x7FFAC2C58E90
    public void TryParse(){} // RVA: 0x7FFAC2C5D200
}

public class CollectionItemFixup : Object
{
    public System.Array Collection; // 0x10
    public int Index; // 0x18
    public string Id; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC86E9F50
    public void get_Collection(){} // RVA: 0x7FFAC2F3C380
    public void get_Index(){} // RVA: 0x7FFAC3157800
    public void get_Id(){} // RVA: 0x7FFAC2F4F0C0
}

public class Collider : ValueType
{
    public int shapeId; // 0x10
    public bool hasUpdated; // 0x14
    public Unity.Mathematics.float3 prevPos0; // 0x18
    public Unity.Mathematics.float3 prevPos1; // 0x24
    public Unity.Mathematics.float3 nextPos0; // 0x30
    public Unity.Mathematics.float3 nextPos1; // 0x3C
    public 0x6B260108 shapeType; // 0x48
    public Unity.Mathematics.float3 pos0; // 0x4C
    public Unity.Mathematics.float3 pos1; // 0x58
    public float radius; // 0x64
    public bool insideBounds; // 0x68
    public bool bonesAsSpheres; // 0x69

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9E4E710
    public void Lerp(){} // RVA: 0x7FFAC9E4E840
}

public class ColliderConfig : ValueType
{
    public bool axis; // 0x10
    public 0x6B2D4148 state; // 0x14
    public UnityEngine.Transform transform; // 0x18
    public float radius; // 0x20
    public float height; // 0x24
    public UnityEngine.Vector3 position; // 0x28
    public UnityEngine.Quaternion rotation; // 0x34

    // ── Methods ──
    public void Create(){} // RVA: 0x7FFACC01BE10
    public void get_axis(){} // RVA: 0x7FFACC01BE70
}

public class ColliderToRemoveData : ValueType
{
    public VRC.Dynamics.VRCPhysBoneColliderBase comp; // 0x10
    public int executionGroup; // 0x18
    public Shape shape; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9E43C20
}

public class Collision : ValueType
{
    public Seed4 m_Random; // 0x10
}

public class CollisionDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7FC20
    public void Invoke(){} // RVA: 0x7FFAC2F7FCF0
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FD20
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class CollisionEnterDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5C4D540
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class CollisionEvent : ValueType
{
    public bool found; // 0x10
    public int receiver; // 0x14
    public int collider; // 0x18
}

public class CollisionEventsJob : ValueType
{
    public Unity.Collections.NativeList`1<Pair> prevCollisionPairs; // 0x10
    public Unity.Collections.NativeQueue`1<CollisionEvent> collisionEvents; // 0x18
    public Unity.Collections.NativeList`1<GridCell> gridCells; // 0x20

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC9DF7950
}

public class CollisionExitDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5C4D540
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class CollisionImpulseDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F87BB0
    public void Invoke(){} // RVA: 0x7FFAC2F87C80
    public void BeginInvoke(){} // RVA: 0x7FFAC2F87CB0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class CollisionModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC994D1D0
    public void set_enabled(){} // RVA: 0x7FFAC994D220
    public void get_type(){} // RVA: 0x7FFAC994D280
    public void set_type(){} // RVA: 0x7FFAC994D2D0
    public void get_mode(){} // RVA: 0x7FFAC994D330
    public void set_mode(){} // RVA: 0x7FFAC994D380
    public void get_dampen(){} // RVA: 0x7FFAC994D3E0
    public void set_dampen(){} // RVA: 0x7FFAC994D450
    public void get_dampenMultiplier(){} // RVA: 0x7FFAC994D4B0
    public void set_dampenMultiplier(){} // RVA: 0x7FFAC994D500
    public void get_bounce(){} // RVA: 0x7FFAC994D560
    public void set_bounce(){} // RVA: 0x7FFAC994D5D0
    public void get_bounceMultiplier(){} // RVA: 0x7FFAC994D630
    public void set_bounceMultiplier(){} // RVA: 0x7FFAC994D680
    public void get_lifetimeLoss(){} // RVA: 0x7FFAC994D6E0
    public void set_lifetimeLoss(){} // RVA: 0x7FFAC994D750
    public void get_lifetimeLossMultiplier(){} // RVA: 0x7FFAC994D7B0
    public void set_lifetimeLossMultiplier(){} // RVA: 0x7FFAC994D800
    public void get_minKillSpeed(){} // RVA: 0x7FFAC994D860
    public void set_minKillSpeed(){} // RVA: 0x7FFAC994D8B0
    public void get_maxKillSpeed(){} // RVA: 0x7FFAC994D910
    public void set_maxKillSpeed(){} // RVA: 0x7FFAC994D960
    public void get_collidesWith(){} // RVA: 0x7FFAC994D9C0
    public void set_collidesWith(){} // RVA: 0x7FFAC994DA20
    public void get_enableDynamicColliders(){} // RVA: 0x7FFAC994DA80
    public void set_enableDynamicColliders(){} // RVA: 0x7FFAC994DAD0
    public void get_maxCollisionShapes(){} // RVA: 0x7FFAC994DB30
    public void set_maxCollisionShapes(){} // RVA: 0x7FFAC994DB80
    public void get_quality(){} // RVA: 0x7FFAC994DBE0
    public void set_quality(){} // RVA: 0x7FFAC994DC30
    public void get_voxelSize(){} // RVA: 0x7FFAC994DC90
    public void set_voxelSize(){} // RVA: 0x7FFAC994DCE0
    public void get_radiusScale(){} // RVA: 0x7FFAC994DD40
    public void set_radiusScale(){} // RVA: 0x7FFAC994DD90
    public void get_sendCollisionMessages(){} // RVA: 0x7FFAC994DDF0
    public void set_sendCollisionMessages(){} // RVA: 0x7FFAC994DE40
    public void get_colliderForce(){} // RVA: 0x7FFAC994DEA0
    public void set_colliderForce(){} // RVA: 0x7FFAC994DEF0
    public void get_multiplyColliderForceByCollisionAngle(){} // RVA: 0x7FFAC994DF50
    public void set_multiplyColliderForceByCollisionAngle(){} // RVA: 0x7FFAC994DFA0
    public void get_multiplyColliderForceByParticleSpeed(){} // RVA: 0x7FFAC994E000
    public void set_multiplyColliderForceByParticleSpeed(){} // RVA: 0x7FFAC994E050
    public void get_multiplyColliderForceByParticleSize(){} // RVA: 0x7FFAC994E0B0
    public void set_multiplyColliderForceByParticleSize(){} // RVA: 0x7FFAC994E100
    public void AddPlane(){} // RVA: 0x7FFAC994E160
    public void RemovePlane(){} // RVA: 0x7FFAC994E220 | overloaded x2
    public void RemovePlaneObject(){} // RVA: 0x7FFAC994E220
    public void SetPlane(){} // RVA: 0x7FFAC994E280
    public void GetPlane(){} // RVA: 0x7FFAC994E2F0
    public void get_planeCount(){} // RVA: 0x7FFAC994E350
    public void get_enabled_Injected(){} // RVA: 0x7FFAC994D1D0
    public void set_enabled_Injected(){} // RVA: 0x7FFAC994D220
    public void get_type_Injected(){} // RVA: 0x7FFAC994D280
    public void set_type_Injected(){} // RVA: 0x7FFAC994D2D0
    public void get_mode_Injected(){} // RVA: 0x7FFAC994D330
    public void set_mode_Injected(){} // RVA: 0x7FFAC994D380
    public void get_dampen_Injected(){} // RVA: 0x7FFAC994E3A0
    public void set_dampen_Injected(){} // RVA: 0x7FFAC994E400
    public void get_dampenMultiplier_Injected(){} // RVA: 0x7FFAC994D4B0
    public void set_dampenMultiplier_Injected(){} // RVA: 0x7FFAC994D500
    public void get_bounce_Injected(){} // RVA: 0x7FFAC994E460
    public void set_bounce_Injected(){} // RVA: 0x7FFAC994E4C0
    public void get_bounceMultiplier_Injected(){} // RVA: 0x7FFAC994D630
    public void set_bounceMultiplier_Injected(){} // RVA: 0x7FFAC994D680
    public void get_lifetimeLoss_Injected(){} // RVA: 0x7FFAC994E520
    public void set_lifetimeLoss_Injected(){} // RVA: 0x7FFAC994E580
    public void get_lifetimeLossMultiplier_Injected(){} // RVA: 0x7FFAC994D7B0
    public void set_lifetimeLossMultiplier_Injected(){} // RVA: 0x7FFAC994D800
    public void get_minKillSpeed_Injected(){} // RVA: 0x7FFAC994D860
    public void set_minKillSpeed_Injected(){} // RVA: 0x7FFAC994D8B0
    public void get_maxKillSpeed_Injected(){} // RVA: 0x7FFAC994D910
    public void set_maxKillSpeed_Injected(){} // RVA: 0x7FFAC994D960
    public void get_collidesWith_Injected(){} // RVA: 0x7FFAC994E5E0
    public void set_collidesWith_Injected(){} // RVA: 0x7FFAC994E640
    public void get_enableDynamicColliders_Injected(){} // RVA: 0x7FFAC994DA80
    public void set_enableDynamicColliders_Injected(){} // RVA: 0x7FFAC994DAD0
    public void get_maxCollisionShapes_Injected(){} // RVA: 0x7FFAC994DB30
    public void set_maxCollisionShapes_Injected(){} // RVA: 0x7FFAC994DB80
    public void get_quality_Injected(){} // RVA: 0x7FFAC994DBE0
    public void set_quality_Injected(){} // RVA: 0x7FFAC994DC30
    public void get_voxelSize_Injected(){} // RVA: 0x7FFAC994DC90
    public void set_voxelSize_Injected(){} // RVA: 0x7FFAC994DCE0
    public void get_radiusScale_Injected(){} // RVA: 0x7FFAC994DD40
    public void set_radiusScale_Injected(){} // RVA: 0x7FFAC994DD90
    public void get_sendCollisionMessages_Injected(){} // RVA: 0x7FFAC994DDF0
    public void set_sendCollisionMessages_Injected(){} // RVA: 0x7FFAC994DE40
    public void get_colliderForce_Injected(){} // RVA: 0x7FFAC994DEA0
    public void set_colliderForce_Injected(){} // RVA: 0x7FFAC994DEF0
    public void get_multiplyColliderForceByCollisionAngle_Injected(){} // RVA: 0x7FFAC994DF50
    public void set_multiplyColliderForceByCollisionAngle_Injected(){} // RVA: 0x7FFAC994DFA0
    public void get_multiplyColliderForceByParticleSpeed_Injected(){} // RVA: 0x7FFAC994E000
    public void set_multiplyColliderForceByParticleSpeed_Injected(){} // RVA: 0x7FFAC994E050
    public void get_multiplyColliderForceByParticleSize_Injected(){} // RVA: 0x7FFAC994E0B0
    public void set_multiplyColliderForceByParticleSize_Injected(){} // RVA: 0x7FFAC994E100
    public void AddPlane_Injected(){} // RVA: 0x7FFAC994E160
    public void RemovePlane_Injected(){} // RVA: 0x7FFAC994E1C0
    public void RemovePlaneObject_Injected(){} // RVA: 0x7FFAC994E220
    public void SetPlane_Injected(){} // RVA: 0x7FFAC994E280
    public void GetPlane_Injected(){} // RVA: 0x7FFAC994E2F0
    public void get_planeCount_Injected(){} // RVA: 0x7FFAC994E350
}

public class CollisionRecord : ValueType
{
    public Shape shape; // 0x10
    public VRC.Dynamics.ContactSender trigger; // 0x18
    public VRC.Dynamics.ContactSenderProxy triggerProxy; // 0x20
    public VRC.Dynamics.ContactReceiverProxy receiverProxy; // 0x28
}

public class CollisionResistanceMultiplier : ValueType
{
    public UnityEngine.LayerMask layers; // 0x10
    public float multiplier; // 0x14
    public float collisionThreshold; // 0x18
}

public class CollisionShape : ValueType
{
    public 0x6B25D508 shapeType; // 0x10
    public Unity.Mathematics.float3 pos0; // 0x14
    public Unity.Mathematics.float3 pos1; // 0x20
    public float radius; // 0x2C

    // ── Methods ──
    public void ToAABB(){} // RVA: 0x7FFAC9DFE6D0
    public void ToSphere(){} // RVA: 0x7FFAC9DFE700
    public void ToCapsule(){} // RVA: 0x7FFAC9DFE720
    public void ToPlane(){} // RVA: 0x7FFAC9DFE6D0
}

public class CollisionsJob : ValueType
{
    public Unity.Collections.NativeParallelMultiHashMap`2<UnityEngine.Vector3Int,int> shapeMap; // 0x10
    public Unity.Collections.NativeList`1<ushort> activeShapes; // 0x20
    public Unity.Collections.NativeArray`1<ShapeData> shapeData; // 0x28
    public Unity.Collections.NativeArray`1<int> collisions; // 0x38
    public ParallelWriter<CollisionEvent> collisionEvents; // 0x48

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC9DF1F50
    public void GetCollision(){} // RVA: 0x7FFAC9DF2D90
    public void SetCollision(){} // RVA: 0x7FFAC9DF2DB0
    public void FindCollision(){} // RVA: 0x7FFAC9DF2DD0
}

public class Color32EqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC94FD340
    public void GetHashCode(){} // RVA: 0x7FFAC94FD380
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Color32Surrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFACC07B720
    public void SetObjectData(){} // RVA: 0x7FFACC07B840
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ColorBySpeedModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC9955990
    public void set_enabled(){} // RVA: 0x7FFAC99559E0
    public void get_color(){} // RVA: 0x7FFAC9955A40
    public void set_color(){} // RVA: 0x7FFAC9955AC0
    public void get_range(){} // RVA: 0x7FFAC9955B20
    public void set_range(){} // RVA: 0x7FFAC9955B80
    public void get_enabled_Injected(){} // RVA: 0x7FFAC9955990
    public void set_enabled_Injected(){} // RVA: 0x7FFAC99559E0
    public void get_color_Injected(){} // RVA: 0x7FFAC9955BE0
    public void set_color_Injected(){} // RVA: 0x7FFAC9955C40
    public void get_range_Injected(){} // RVA: 0x7FFAC9955CA0
    public void set_range_Injected(){} // RVA: 0x7FFAC9955D00
}

public class ColorEqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC94FCF40
    public void GetHashCode(){} // RVA: 0x7FFAC94FD000
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ColorOverLifetimeModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC9955740
    public void set_enabled(){} // RVA: 0x7FFAC9955790
    public void get_color(){} // RVA: 0x7FFAC99557F0
    public void set_color(){} // RVA: 0x7FFAC9955870
    public void get_enabled_Injected(){} // RVA: 0x7FFAC9955740
    public void set_enabled_Injected(){} // RVA: 0x7FFAC9955790
    public void get_color_Injected(){} // RVA: 0x7FFAC99558D0
    public void set_color_Injected(){} // RVA: 0x7FFAC9955930
}

public class ColorPaletteData : Object
{
    public string name; // 0x10
    public string id; // 0x18
    public string highlights; // 0x20
    public string icons; // 0x28
    public string buttons; // 0x30
    public string backgrounds; // 0x38
    public string text; // 0x40
    public string subtext; // 0x48

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ColorSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFACC07B4A0
    public void SetObjectData(){} // RVA: 0x7FFACC07B5C0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ColorTweenCallback : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C76570
}

public class Colorf : ValueType
{
    public float r; // 0x10
    public float g; // 0x14
    public float b; // 0x18
    public float a; // 0x1C

    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFAC8907F40
}

public class ColumnData : Object
{
    public UnityEngine.UIElements.Internal.MultiColumnHeaderColumn control; // 0x10
    public UnityEngine.UIElements.Internal.MultiColumnHeaderColumnResizeHandle resizeHandle; // 0x18

    // ── Methods ──
    public void get_control(){} // RVA: 0x7FFAC2F3C380
    public void set_control(){} // RVA: 0x7FFAC2F22E30
    public void get_resizeHandle(){} // RVA: 0x7FFAC2F247C0
    public void set_resizeHandle(){} // RVA: 0x7FFAC2F87E80
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ColumnError : ValueType
{
    public System.Data.DataColumn _column; // 0x10
    public string _error; // 0x18
}

public class ColumnState : ValueType
{
    public int index; // 0x10
    public string name; // 0x18
    public float actualWidth; // 0x20
    public float width; // 0x24
    public bool visible; // 0x28
}

public class ComNativeDescriptionProvider : TypeDescriptionProvider
{
    public System.ComponentModel.IComNativeDescriptorHandler Handler; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F4F0D0
    public void get_Handler(){} // RVA: 0x7FFAC2F4F0C0
    public void set_Handler(){} // RVA: 0x7FFAC2F4F0D0
    public void GetTypeDescriptor(){} // RVA: 0x7FFAC9442940
}

public class ComNativeTypeDescriptor : Object
{
    public System.ComponentModel.IComNativeDescriptorHandler _handler; // 0x10
    public object _instance; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
    public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7FFAC9442B40
    public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x7FFAC9442C00
    public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x7FFAC34F9180
    public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7FFAC9442C60
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x7FFAC9442D30
    public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x7FFAC9442E00
    public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7FFAC9442ED0
    public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x7FFAC9443010 | overloaded x2
    public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7FFAC9443150 | overloaded x2
    public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x7FFAC2F247C0
}

public class CommonName : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8368860
}

public class CompareDevicesByUserAccount : ValueType
{
    public UnityEngine.InputSystem.Users.InputUserAccountHandle platformUserAccountHandle; // 0x10

    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFAC96452E0
    public void GetUserAccountHandleForDevice(){} // RVA: 0x7FFAC684A7D0
}

public class ComparePerformanceStatsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACC08ECF0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
    public void EndInvoke(){} // RVA: 0x7FFAC4034000
}

public class Comparers : Object
{
    public Comparers<U,T> KeyComparer;
    public System.Collections.Generic.IEqualityComparer`1<U> KeyOnlyComparer;
    public System.Collections.Generic.IEqualityComparer`1<T> ValueComparer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C79B30
    public void get_KeyComparer(){} // RVA: 0x7FFAC2C58E90
    public void get_KeyOnlyComparer(){} // RVA: 0x7FFAC2C58E90
    public void get_ValueComparer(){} // RVA: 0x7FFAC2C58E90
    public void Equals(){} // RVA: 0x7FFAC2E8DC40
    public void GetHashCode(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Equals(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetHashCode(){} // RVA: 0x7FFAC2E8DC40
    public void Get(){} // RVA: 0x7FFAC2C58FF0
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class CompleteOnInvokePromise : Task`1
{
    public System.Collections.Generic.IList`1<System.Threading.Tasks.Task> InvokeMayRunArbitraryCode; // 0x58

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83CABF0
    public void Invoke(){} // RVA: 0x7FFAC83CAD10
    public void get_InvokeMayRunArbitraryCode(){} // RVA: 0x7FFAC3006850
}

public class CompositeSyntax : ValueType
{
    public UnityEngine.InputSystem.InputAction bindingIndex; // 0x10
    public UnityEngine.InputSystem.InputActionMap m_ActionMap; // 0x18
    public int m_BindingIndexInMap; // 0x20

    // ── Methods ──
    public void get_bindingIndex(){} // RVA: 0x7FFAC9541A20
    public void .ctor(){} // RVA: 0x7FFAC9541A50
    public void With(){} // RVA: 0x7FFAC9541B20
}

public class CompressFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB0280
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFACBE26CB0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class ComputeShaders : Object
{
    public UnityEngine.ComputeShader autoExposure; // 0x10
    public UnityEngine.ComputeShader exposureHistogram; // 0x18
    public UnityEngine.ComputeShader lut3DBaker; // 0x20
    public UnityEngine.ComputeShader texture3dLerp; // 0x28
    public UnityEngine.ComputeShader gammaHistogram; // 0x30
    public UnityEngine.ComputeShader waveform; // 0x38
    public UnityEngine.ComputeShader vectorscope; // 0x40
    public UnityEngine.ComputeShader multiScaleAODownsample1; // 0x48
    public UnityEngine.ComputeShader multiScaleAODownsample2; // 0x50
    public UnityEngine.ComputeShader multiScaleAORender; // 0x58
    public UnityEngine.ComputeShader multiScaleAOUpsample; // 0x60
    public UnityEngine.ComputeShader gaussianDownsample; // 0x68

    // ── Methods ──
    public void Clone(){} // RVA: 0x7FFAC96DC420
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ConcreteFormattableString : FormattableString
{
    public string Format; // 0x10
    public object[] ArgumentCount; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
    public void get_Format(){} // RVA: 0x7FFAC2F3C380
    public void GetArguments(){} // RVA: 0x7FFAC2F247C0
    public void get_ArgumentCount(){} // RVA: 0x7FFAC5CC4BA0
    public void GetArgument(){} // RVA: 0x7FFAC849C850
    public void ToString(){} // RVA: 0x7FFAC84DC480
}

public class ConditionalExpressionProxy : Object
{
    public System.Linq.Expressions.ConditionalExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D71380
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_IfFalse(){} // RVA: 0x7FFAC84AA530
    public void get_IfTrue(){} // RVA: 0x7FFAC356B610
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Test(){} // RVA: 0x7FFAC3511350
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
}

public class Config : ValueType
{
    public float x; // 0x10
    public float y; // 0x14
    public float z; // 0x18
    public float rx; // 0x1C
    public float ry; // 0x20
    public float rz; // 0x24
    public float fov; // 0x28
    public float near; // 0x2C
    public float far; // 0x30
    public float sceneResolutionScale; // 0x34
    public float frameSkip; // 0x38
    public float nearOffset; // 0x3C
    public float farOffset; // 0x40
    public float hmdOffset; // 0x44
    public float r; // 0x48
    public float g; // 0x4C
    public float b; // 0x50
    public float a; // 0x54
    public bool disableStandardAssets; // 0x58
}

public class Configuration : Object
{
    public byte[] Bytes; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBC7F520
    public void get_Bytes(){} // RVA: 0x7FFAC2F3C380
}

public class ConfigurationListDebugView : Object
{
    public System.Text.Json.Serialization.ConfigurationList`1<T> Items;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void get_Items(){} // RVA: 0x7FFAC2C58E90
}

public class ConfigureBasepointCallback : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve m_curve; // 0x10
    public int m_confWidth; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC488C310
    public void Precompute(){} // RVA: 0x7FFACBA7F160
}

public class ConfiguredTaskAwaiter : ValueType
{
    public System.Threading.Tasks.Task`1<T> IsCompleted;
    public bool m_continueOnCapturedContext;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C76500
    public void get_IsCompleted(){} // RVA: 0x7FFAC2C59D00
    public void OnCompleted(){} // RVA: 0x7FFAC2C70A40
    public void UnsafeOnCompleted(){} // RVA: 0x7FFAC2C70A40
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
}

public class ConfiguredValueTaskAwaiter : ValueType
{
    public System.Threading.Tasks.ValueTask`1<T> IsCompleted;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_IsCompleted(){} // RVA: 0x7FFAC2C59D00
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void OnCompleted(){} // RVA: 0x7FFAC2C70A40
    public void UnsafeOnCompleted(){} // RVA: 0x7FFAC2C70A40
}

public class ConnectDisposable : Object
{
    public System.Threading.CancellationTokenSource cancellationTokenSource;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void Dispose(){} // RVA: 0x7FFAC2C70980
}

public class ConnectMsg : Object
{
    // ── Methods ──
    public void Process(){} // RVA: 0x7FFAC9602080
}

public class ConnectionChangeEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC98E67E0
}

public class ConnectionGroup : Object
{
    public System.Net.ServicePointScheduler Scheduler; // 0x10
    public string <Name>k__BackingField; // 0x18
    public int nextId;
    public int ID; // 0x20
    public System.Collections.Generic.LinkedList`1<System.Net.WebConnection> connections; // 0x28
    public System.Collections.Generic.LinkedList`1<System.Net.WebOperation> queue; // 0x30

    // ── Methods ──
    public void get_Scheduler(){} // RVA: 0x7FFAC2F3C380
    public void .ctor(){} // RVA: 0x7FFAC930B740
    public void IsEmpty(){} // RVA: 0x7FFAC930B950
    public void RemoveConnection(){} // RVA: 0x7FFAC930B9C0
    public void Cleanup(){} // RVA: 0x7FFAC930BA60
    public void Close(){} // RVA: 0x7FFAC930BB70
    public void EnqueueOperation(){} // RVA: 0x7FFAC930C010
    public void GetNextOperation(){} // RVA: 0x7FFAC930C070
    public void FindIdleConnection(){} // RVA: 0x7FFAC930C1C0
    public void CreateOrReuseConnection(){} // RVA: 0x7FFAC930C620
}

public class ConstantExpressionProxy : Object
{
    public System.Linq.Expressions.ConstantExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D71460
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
    public void get_Value(){} // RVA: 0x7FFAC3511350
}

public class ConstraintConfigurationData : ValueType
{
    public Unity.Mathematics.float3 AtRest; // 0x10
    public Unity.Mathematics.float3 Offset; // 0x1C
    public 0x6B25E480 Axes; // 0x28
}

public class ConstraintManagerUpdate : ValueType
{
}

public class ConstraintSourceData : ValueType
{
    public int SourceIndex; // 0x10
    public bool SourceExists; // 0x14
    public float Weight; // 0x18
    public Unity.Mathematics.float3 ParentPositionOffset; // 0x1C
    public Unity.Mathematics.float3 ParentRotationOffset; // 0x28
}

public class ConstructJob : ValueType
{
    public Unity.Collections.NativeStream Container; // 0x10
    public Unity.Collections.NativeArray`1<int> Length; // 0x30

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC9511900
}

public class ConstructJobList : ValueType
{
    public Unity.Collections.NativeStream Container; // 0x10
    public Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList* List; // 0x30

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC95118D0
}

public class ConstructorContext : Object
{
    public System.Type _type; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void CreateInstance(){} // RVA: 0x7FFAC8AF7D40
}

public class ConstructorDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3AD07E0
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
}

public class ContactEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6057520
    public void Invoke(){} // RVA: 0x7FFAC5C4DBE0
}

public class ContainerContext : Object
{
    public 0x6B1CD1C8 Type; // 0x10
    public int Length; // 0x14
    public int Position; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
}

public class ContainerHeight : Object
{
    public UnityEngine.Transform Height; // 0x10
    public UnityEngine.Transform _containerBottom; // 0x18

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFACB5FC000
    public void Equals(){} // RVA: 0x7FFACB5FC000
    public void GetHashCode(){} // RVA: 0x7FFACB5FC000
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Initialize(){} // RVA: 0x7FFACB5FC000
    public void IsNativeObjectAlive(){} // RVA: 0x7FFACB5FC000
    public void set_Height(){} // RVA: 0x7FFACB5FC000
    public void get_Height(){} // RVA: 0x7FFACB5FC000
}

public class Content : ValueType
{
    public ÎÍÏÏÏÏÍÍÏÍÎÏÏÌÏÏÎÌÏÍÏÎÍ<UnityEngine.Vector2> ScrollPosition; // 0x10
    public System.Collections.Generic.List`1<string> Items; // 0x18
}

public class ContentBlock : ApiModel
{
    public string type; // 0x68
    public VRC.Core.ApiLocalizableString value; // 0x70
    public string capturedValue; // 0x78
    public string textAlignment; // 0x80
    public int fontSize; // 0x88
    public bool allowTextWrapping; // 0x8C
    public System.Collections.Generic.List`1<System.Collections.Generic.List`1<VRC.Core.ApiLocalizableString>> points; // 0x90
    public string imageUrl; // 0x98
    public string aspectMode; // 0xA0
    public int height; // 0xA8
    public int imageSize; // 0xAC
    public System.Collections.Generic.List`1<PopupButtonData> buttons; // 0xB0
    public string capture; // 0xB8
    public RequiredValue requiredFormat; // 0xC0

    // ── Methods ──
    public void get_type(){} // RVA: 0x7FFAC2F9CD50
    public void set_type(){} // RVA: 0x7FFAC2F9CD60
    public void get_value(){} // RVA: 0x7FFAC2FE9590
    public void set_value(){} // RVA: 0x7FFAC2FE95A0
    public void get_capturedValue(){} // RVA: 0x7FFAC30E5600
    public void set_capturedValue(){} // RVA: 0x7FFAC30E06F0
    public void get_textAlignment(){} // RVA: 0x7FFAC32EF410
    public void set_textAlignment(){} // RVA: 0x7FFAC34D4AA0
    public void get_fontSize(){} // RVA: 0x7FFAC37EE8C0
    public void set_fontSize(){} // RVA: 0x7FFAC37F9DE0
    public void get_allowTextWrapping(){} // RVA: 0x7FFAC2F89520
    public void set_allowTextWrapping(){} // RVA: 0x7FFAC2F89530
    public void get_points(){} // RVA: 0x7FFAC32EF640
    public void set_points(){} // RVA: 0x7FFAC354E360
    public void get_imageUrl(){} // RVA: 0x7FFAC354DFB0
    public void set_imageUrl(){} // RVA: 0x7FFAC354E3C0
    public void get_aspectMode(){} // RVA: 0x7FFAC3543900
    public void set_aspectMode(){} // RVA: 0x7FFAC354E420
    public void get_height(){} // RVA: 0x7FFAC39055C0
    public void set_height(){} // RVA: 0x7FFAC38FD010
    public void get_imageSize(){} // RVA: 0x7FFAC6539490
    public void set_imageSize(){} // RVA: 0x7FFAC65394A0
    public void get_buttons(){} // RVA: 0x7FFAC2F8C040
    public void set_buttons(){} // RVA: 0x7FFAC2F8C050
    public void get_capture(){} // RVA: 0x7FFAC2F8C0B0
    public void set_capture(){} // RVA: 0x7FFAC2F8C0C0
    public void get_requiredFormat(){} // RVA: 0x7FFAC2F8C120
    public void set_requiredFormat(){} // RVA: 0x7FFAC2F8C130
    public void .ctor(){} // RVA: 0x7FFACBE79870
}

public class ContentHeightCacheInfo : ValueType
{
    public float sum;
    public int count;

    // ── Methods ──
    public void .ctor(){}
}

public class ContentInfo : Object
{
    public string ASN1; // 0x10
    public Mono.Security.ASN1 Content; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8350CC0 | overloaded x4
    public void get_ASN1(){} // RVA: 0x7FFAC8350F00
    public void get_Content(){} // RVA: 0x7FFAC2F247C0
    public void set_Content(){} // RVA: 0x7FFAC2F87E80
    public void get_ContentType(){} // RVA: 0x7FFAC2F3C380
    public void set_ContentType(){} // RVA: 0x7FFAC2F22E30
    public void GetASN1(){} // RVA: 0x7FFAC8350F10
}

public class ContentList : ApiModel
{
    public VRC.Core.ApiLocalizableString name; // 0x68
    public VRC.Core.ApiLocalizableString shortName; // 0x70
    public string sortHeading; // 0x78
    public string sortOwnership; // 0x80
    public string sortOrder; // 0x88
    public string platform; // 0x90
    public System.Nullable`1<bool> avatarSpecific; // 0x98
    public string tag; // 0xA0
    public string type; // 0xA8
    public string bannersTag; // 0xB0
    public string marketplace; // 0xB8
    public System.Collections.Generic.IReadOnlyDictionary`2<string,Token> queryParams; // 0xC0

    // ── Methods ──
    public void get_name(){} // RVA: 0x7FFAC2F9CD50
    public void set_name(){} // RVA: 0x7FFAC2F9CD60
    public void get_shortName(){} // RVA: 0x7FFAC2FE9590
    public void set_shortName(){} // RVA: 0x7FFAC2FE95A0
    public void get_sortHeading(){} // RVA: 0x7FFAC30E5600
    public void set_sortHeading(){} // RVA: 0x7FFAC30E06F0
    public void get_sortOwnership(){} // RVA: 0x7FFAC32EF410
    public void set_sortOwnership(){} // RVA: 0x7FFAC34D4AA0
    public void get_sortOrder(){} // RVA: 0x7FFAC2F60010
    public void set_sortOrder(){} // RVA: 0x7FFAC354E300
    public void get_platform(){} // RVA: 0x7FFAC32EF640
    public void set_platform(){} // RVA: 0x7FFAC354E360
    public void get_avatarSpecific(){} // RVA: 0x7FFAC8B66F50
    public void set_avatarSpecific(){} // RVA: 0x7FFAC8B66F60
    public void get_tag(){} // RVA: 0x7FFAC3543900
    public void set_tag(){} // RVA: 0x7FFAC354E420
    public void get_type(){} // RVA: 0x7FFAC354B1A0
    public void set_type(){} // RVA: 0x7FFAC334B370
    public void get_bannersTag(){} // RVA: 0x7FFAC2F8C040
    public void set_bannersTag(){} // RVA: 0x7FFAC2F8C050
    public void get_marketplace(){} // RVA: 0x7FFAC2F8C0B0
    public void set_marketplace(){} // RVA: 0x7FFAC2F8C0C0
    public void get_queryParams(){} // RVA: 0x7FFAC2F8C120
    public void set_queryParams(){} // RVA: 0x7FFAC2F8C130
    public void WriteField(){} // RVA: 0x7FFACBE792A0
    public void .ctor(){} // RVA: 0x7FFACBE79430
}

public class ContentReader : Object
{
    public System.Xml.Linq.NamespaceCache _eCache; // 0x10
    public System.Xml.Linq.NamespaceCache _aCache; // 0x20
    public System.Xml.IXmlLineInfo _lineInfo; // 0x30
    public System.Xml.Linq.XContainer _currentContainer; // 0x38
    public string _baseUri; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC909DDD0 | overloaded x2
    public void ReadContentFrom(){} // RVA: 0x7FFAC909E720 | overloaded x2
}

public class ContentSectionElementSet : ValueType
{
    public ÏÏÎÎÍÎÎÌÏÍÏÍÍÎÎÍÍÍÎÌÍÍÍ contentListUiBinding; // 0x10
    public UnityEngine.GameObject contentListHeaderContainer; // 0x18
    public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ contentListHeaderLabel; // 0x20
    public UnityEngine.GameObject trailingSeparator; // 0x28
}

public class Context : ValueType
{
    public 0x6B0DB010 Option; // 0x10
    public byte* NeverMatchFlags; // 0x18
    public byte* AlwaysMatchFlags; // 0x20
    public byte* Buffer1; // 0x28
    public byte* Buffer2; // 0x30
    public int PrevCode; // 0x38
    public byte* PrevSortKey; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC839B2E0
}

public class ContextRestoreSink : Object
{
    public System.Runtime.Remoting.Messaging.IMessageSink _next; // 0x10
    public System.Runtime.Remoting.Contexts.Context _context; // 0x18
    public System.Runtime.Remoting.Messaging.IMessage _call; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3000E00
    public void SyncProcessMessage(){} // RVA: 0x7FFAC8481BA0
    public void AsyncProcessMessage(){} // RVA: 0x7FFAC8481DE0
}

public class ContingentProperties : Object
{
    public System.Threading.ExecutionContext m_capturedContext; // 0x10
    public System.Threading.ManualResetEventSlim m_completionEvent; // 0x18
    public System.Threading.Tasks.TaskExceptionHolder m_exceptionsHolder; // 0x20
    public System.Threading.CancellationToken m_cancellationToken; // 0x28
    public object m_cancellationRegistration; // 0x30
    public int m_internalCancellationRequested; // 0x38
    public int m_completionCountdown; // 0x3C
    public System.Collections.Generic.LowLevelListWithIList`1<System.Threading.Tasks.Task> m_exceptionalChildren; // 0x40

    // ── Methods ──
    public void SetCompleted(){} // RVA: 0x7FFAC86E6980
    public void UnregisterCancellationCallback(){} // RVA: 0x7FFAC86E69B0
    public void .ctor(){} // RVA: 0x7FFAC86E6AA0
}

public class ContinuationWrapper : Object
{
    public System.Action m_continuation; // 0x10
    public System.Action m_invokeAction; // 0x18
    public System.Threading.Tasks.Task m_innerTask; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC84DF550
    public void Invoke(){} // RVA: 0x7FFAC669D470
}

public class Control : Object
{
    public string name; // 0x10
    public UnityEngine.Texture2D icon; // 0x18
    public 0x6B2D3908 type; // 0x20
    public Parameter parameter; // 0x28
    public float value; // 0x30
    public 0x6B2D39B8 style; // 0x34
    public VRC.SDK3.Avatars.ScriptableObjects.VRCExpressionsMenu subMenu; // 0x38
    public Parameter[] subParameters; // 0x40
    public Label[] labels; // 0x48

    // ── Methods ──
    public void GetSubParameter(){} // RVA: 0x7FFACC014E30
    public void GetLabel(){} // RVA: 0x7FFACC014E70
    public void .ctor(){} // RVA: 0x7FFAC3E8DE70
}

public class ControlBitRangeNode : ValueType
{
    public ushort endBitOffset; // 0x10
    public short leftChildIndex; // 0x12
    public ushort controlStartIndex; // 0x14
    public byte controlCount; // 0x16

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC95944E0
}

public class ControlBuilder : ValueType
{
    public UnityEngine.InputSystem.InputControl control; // 0x10

    // ── Methods ──
    public void get_control(){} // RVA: 0x7FFAC3AD9F60
    public void set_control(){} // RVA: 0x7FFAC38DFE40
    public void At(){} // RVA: 0x7FFAC9589560
    public void WithParent(){} // RVA: 0x7FFAC9589640
    public void WithName(){} // RVA: 0x7FFAC95896B0
    public void WithDisplayName(){} // RVA: 0x7FFAC9589750
    public void WithShortDisplayName(){} // RVA: 0x7FFAC9589830
    public void WithLayout(){} // RVA: 0x7FFAC9589910
    public void WithUsages(){} // RVA: 0x7FFAC9589980
    public void WithAliases(){} // RVA: 0x7FFAC95899B0
    public void WithChildren(){} // RVA: 0x7FFAC95899E0
    public void WithStateBlock(){} // RVA: 0x7FFAC9589A10
    public void WithDefaultState(){} // RVA: 0x7FFAC9589A40
    public void WithMinAndMax(){} // RVA: 0x7FFAC9589A80
    public void WithProcessor(){} // RVA: 0x7FFAC2E8DC40
    public void IsNoisy(){} // RVA: 0x7FFAC9589AC0
    public void IsSynthetic(){} // RVA: 0x7FFAC9589AF0
    public void DontReset(){} // RVA: 0x7FFAC9589B30
    public void IsButton(){} // RVA: 0x7FFAC9589B90
    public void Finish(){} // RVA: 0x7FFAC9589BD0
}

public class ControlDataForExport : Object
{
    public 0x6B014F08 eyeControl; // 0x10
    public 0x6B014FB8 eyelidBoneMode; // 0x14
    public string leftEyePath; // 0x18
    public string rightEyePath; // 0x20
    public float maxEyeUpBoneAngle; // 0x28
    public float maxEyeDownBoneAngle; // 0x2C
    public float maxEyeUpEyeballAngle; // 0x30
    public float maxEyeDownEyeballAngle; // 0x34
    public bool isEyeBallDefaultSet; // 0x38
    public bool isEyeBoneDefaultSet; // 0x39
    public bool isEyeBallLookUpSet; // 0x3A
    public bool isEyeBoneLookUpSet; // 0x3B
    public bool isEyeBallLookDownSet; // 0x3C
    public bool isEyeBoneLookDownSet; // 0x3D
    public EyeRotationLimiterForExport leftBoneEyeRotationLimiter; // 0x40
    public EyeRotationLimiterForExport rightBoneEyeRotationLimiter; // 0x48
    public EyeRotationLimiterForExport leftEyeballEyeRotationLimiter; // 0x50
    public EyeRotationLimiterForExport rightEyeballEyeRotationLimiter; // 0x58
    public 0x6B014F60 eyelidControl; // 0x60
    public bool eyelidsFollowEyesVertically; // 0x64
    public string upperEyeLidLeftPath; // 0x68
    public string upperEyeLidRightPath; // 0x70
    public string lowerEyeLidLeftPath; // 0x78
    public string lowerEyeLidRightPath; // 0x80
    public bool isEyelidBonesDefaultSet; // 0x88
    public bool isEyelidBonesClosedSet; // 0x89
    public bool isEyelidBonesLookUpSet; // 0x8A
    public bool isEyelidBonesLookDownSet; // 0x8B
    public EyelidRotationLimiterForExport upperLeftLimiter; // 0x90
    public EyelidRotationLimiterForExport upperRightLimiter; // 0x98
    public EyelidRotationLimiterForExport lowerLeftLimiter; // 0xA0
    public EyelidRotationLimiterForExport lowerRightLimiter; // 0xA8
    public float eyeWidenOrSquint; // 0xB0
    public EyelidPositionBlendshapeForExport[] blendshapesForBlinking; // 0xB8
    public EyelidPositionBlendshapeForExport[] blendshapesForLookingUp; // 0xC0
    public EyelidPositionBlendshapeForExport[] blendshapesForLookingDown; // 0xC8
    public BlendshapesConfigForExport[] blendshapesConfigs; // 0xD0
    public bool isEyelidBlendshapeDefaultSet; // 0xD8
    public bool isEyelidBlendshapeClosedSet; // 0xD9
    public bool isEyelidBlendshapeLookUpSet; // 0xDA
    public bool isEyelidBlendshapeLookDownSet; // 0xDB

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ControlItem : ValueType
{
    public UnityEngine.InputSystem.Utilities.InternedString name; // 0x10
    public UnityEngine.InputSystem.Utilities.InternedString layout; // 0x20
    public UnityEngine.InputSystem.Utilities.InternedString variants; // 0x30
    public string useStateFrom; // 0x40
    public string displayName; // 0x48
    public string shortDisplayName; // 0x50
    public UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.InternedString> usages; // 0x58
    public UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.InternedString> aliases; // 0x68
    public UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.NamedValue> parameters; // 0x78
    public UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.NameAndParameters> processors; // 0x88
    public uint offset; // 0x98
    public uint bit; // 0x9C
    public uint sizeInBits; // 0xA0
    public UnityEngine.InputSystem.Utilities.FourCC format; // 0xA4
    public 0x6B14F8E8 flags; // 0xA8
    public int arraySize; // 0xAC
    public UnityEngine.InputSystem.Utilities.PrimitiveValue defaultState; // 0xB0
    public UnityEngine.InputSystem.Utilities.PrimitiveValue minValue; // 0xC0
    public UnityEngine.InputSystem.Utilities.PrimitiveValue maxValue; // 0xD0

    // ── Methods ──
    public void get_name(){} // RVA: 0x7FFAC32C0590
    public void set_name(){} // RVA: 0x7FFAC4AA1C40
    public void get_layout(){} // RVA: 0x7FFAC4422E80
    public void set_layout(){} // RVA: 0x7FFAC4A9B120
    public void get_variants(){} // RVA: 0x7FFAC4A19630
    public void set_variants(){} // RVA: 0x7FFAC4A19640
    public void get_useStateFrom(){} // RVA: 0x7FFAC31D95E0
    public void set_useStateFrom(){} // RVA: 0x7FFAC2F4F890
    public void get_displayName(){} // RVA: 0x7FFAC31D0140
    public void set_displayName(){} // RVA: 0x7FFAC31D0C20
    public void get_shortDisplayName(){} // RVA: 0x7FFAC2F9E740
    public void set_shortDisplayName(){} // RVA: 0x7FFAC2F49200
    public void get_usages(){} // RVA: 0x7FFAC4A7F120
    public void set_usages(){} // RVA: 0x7FFAC968F350
    public void get_aliases(){} // RVA: 0x7FFAC3BCB4D0
    public void set_aliases(){} // RVA: 0x7FFAC968F3B0
    public void get_parameters(){} // RVA: 0x7FFAC5FD87B0
    public void set_parameters(){} // RVA: 0x7FFAC5FD87C0
    public void get_processors(){} // RVA: 0x7FFAC8A33E20
    public void set_processors(){} // RVA: 0x7FFAC968F410
    public void get_offset(){} // RVA: 0x7FFAC37EE8C0
    public void set_offset(){} // RVA: 0x7FFAC37F9DE0
    public void get_bit(){} // RVA: 0x7FFAC5F56E80
    public void set_bit(){} // RVA: 0x7FFAC65A0990
    public void get_sizeInBits(){} // RVA: 0x7FFAC3220660
    public void set_sizeInBits(){} // RVA: 0x7FFAC34D2750
    public void get_format(){} // RVA: 0x7FFAC3220670
    public void set_format(){} // RVA: 0x7FFAC342B670
    public void get_flags(){} // RVA: 0x7FFAC489E530
    public void set_flags(){} // RVA: 0x7FFAC489E540
    public void get_arraySize(){} // RVA: 0x7FFAC489E520
    public void set_arraySize(){} // RVA: 0x7FFAC489EAA0
    public void get_defaultState(){} // RVA: 0x7FFAC88C7180
    public void set_defaultState(){} // RVA: 0x7FFAC88C7190
    public void get_minValue(){} // RVA: 0x7FFAC3695970
    public void set_minValue(){} // RVA: 0x7FFAC3693CA0
    public void get_maxValue(){} // RVA: 0x7FFAC8B4E0D0
    public void set_maxValue(){} // RVA: 0x7FFAC8B4E0E0
    public void get_isModifyingExistingControl(){} // RVA: 0x7FFAC968F470
    public void set_isModifyingExistingControl(){} // RVA: 0x7FFAC968F480
    public void get_isNoisy(){} // RVA: 0x7FFAC968F4A0
    public void set_isNoisy(){} // RVA: 0x7FFAC968F4B0
    public void get_isSynthetic(){} // RVA: 0x7FFAC968F4D0
    public void set_isSynthetic(){} // RVA: 0x7FFAC968F4E0
    public void get_dontReset(){} // RVA: 0x7FFAC968F500
    public void set_dontReset(){} // RVA: 0x7FFAC968F510
    public void get_isFirstDefinedInThisLayout(){} // RVA: 0x7FFAC968F530
    public void set_isFirstDefinedInThisLayout(){} // RVA: 0x7FFAC968F540
    public void get_isArray(){} // RVA: 0x7FFAC968F560
    public void Merge(){} // RVA: 0x7FFAC968F570
}

public class ControlItemJson : Object
{
    public string name; // 0x10
    public string layout; // 0x18
    public string variants; // 0x20
    public string usage; // 0x28
    public string alias; // 0x30
    public string useStateFrom; // 0x38
    public uint offset; // 0x40
    public uint bit; // 0x44
    public uint sizeInBits; // 0x48
    public string format; // 0x50
    public int arraySize; // 0x58
    public string[] usages; // 0x60
    public string[] aliases; // 0x68
    public string parameters; // 0x70
    public string processors; // 0x78
    public string displayName; // 0x80
    public string shortDisplayName; // 0x88
    public bool noisy; // 0x90
    public bool dontReset; // 0x91
    public bool synthetic; // 0x92
    public string defaultState; // 0x98
    public string minValue; // 0xA0
    public string maxValue; // 0xA8

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9693060
    public void ToLayout(){} // RVA: 0x7FFAC9693070
    public void FromControlItems(){} // RVA: 0x7FFAC9693E50
}

public class ControlSchemeChangeSyntax : ValueType
{
    public int m_UserIndex; // 0x10

    // ── Methods ──
    public void AndPairRemainingDevices(){} // RVA: 0x7FFAC9645280
}

public class ControlSchemeSyntax : ValueType
{
    public UnityEngine.InputSystem.InputActionAsset m_Asset; // 0x10
    public int m_ControlSchemeIndex; // 0x18
    public UnityEngine.InputSystem.InputControlScheme m_ControlScheme; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9541DC0 | overloaded x2
    public void WithBindingGroup(){} // RVA: 0x7FFAC9541E90
    public void WithRequiredDevice(){} // RVA: 0x7FFAC9542090 | overloaded x2
    public void WithOptionalDevice(){} // RVA: 0x7FFAC95420E0 | overloaded x2
    public void OrWithRequiredDevice(){} // RVA: 0x7FFAC9542130 | overloaded x2
    public void OrWithOptionalDevice(){} // RVA: 0x7FFAC9542180 | overloaded x2
    public void DeviceTypeToControlPath(){} // RVA: 0x7FFAC2C58E90
    public void Done(){} // RVA: 0x7FFAC95421D0
    public void AddDeviceEntry(){} // RVA: 0x7FFAC9542300
}

public class ControlSurface : Object
{
    public UnityEngine.Transform transform; // 0x10
    public float amount; // 0x18
    public 0x6B1BBA50 type; // 0x1C
    public UnityEngine.Quaternion originalLocalRotation; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ControllerState : ValueType
{
    public uint ConnectedControllers; // 0x10
    public uint Buttons; // 0x14
    public uint Touches; // 0x18
    public uint NearTouches; // 0x1C
    public float LIndexTrigger; // 0x20
    public float RIndexTrigger; // 0x24
    public float LHandTrigger; // 0x28
    public float RHandTrigger; // 0x2C
    public Vector2f LThumbstick; // 0x30
    public Vector2f RThumbstick; // 0x38
}

public class ControllerState2 : ValueType
{
    public uint ConnectedControllers; // 0x10
    public uint Buttons; // 0x14
    public uint Touches; // 0x18
    public uint NearTouches; // 0x1C
    public float LIndexTrigger; // 0x20
    public float RIndexTrigger; // 0x24
    public float LHandTrigger; // 0x28
    public float RHandTrigger; // 0x2C
    public Vector2f LThumbstick; // 0x30
    public Vector2f RThumbstick; // 0x38
    public Vector2f LTouchpad; // 0x40
    public Vector2f RTouchpad; // 0x48

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8907D10
}

public class ControllerState4 : ValueType
{
    public uint ConnectedControllers; // 0x10
    public uint Buttons; // 0x14
    public uint Touches; // 0x18
    public uint NearTouches; // 0x1C
    public float LIndexTrigger; // 0x20
    public float RIndexTrigger; // 0x24
    public float LHandTrigger; // 0x28
    public float RHandTrigger; // 0x2C
    public Vector2f LThumbstick; // 0x30
    public Vector2f RThumbstick; // 0x38
    public Vector2f LTouchpad; // 0x40
    public Vector2f RTouchpad; // 0x48
    public byte LBatteryPercentRemaining; // 0x50
    public byte RBatteryPercentRemaining; // 0x51
    public byte LRecenterCount; // 0x52
    public byte RRecenterCount; // 0x53
    public byte Reserved_27; // 0x54
    public byte Reserved_26; // 0x55
    public byte Reserved_25; // 0x56
    public byte Reserved_24; // 0x57
    public byte Reserved_23; // 0x58
    public byte Reserved_22; // 0x59
    public byte Reserved_21; // 0x5A
    public byte Reserved_20; // 0x5B
    public byte Reserved_19; // 0x5C
    public byte Reserved_18; // 0x5D
    public byte Reserved_17; // 0x5E
    public byte Reserved_16; // 0x5F
    public byte Reserved_15; // 0x60
    public byte Reserved_14; // 0x61
    public byte Reserved_13; // 0x62
    public byte Reserved_12; // 0x63
    public byte Reserved_11; // 0x64
    public byte Reserved_10; // 0x65
    public byte Reserved_09; // 0x66
    public byte Reserved_08; // 0x67
    public byte Reserved_07; // 0x68
    public byte Reserved_06; // 0x69
    public byte Reserved_05; // 0x6A
    public byte Reserved_04; // 0x6B
    public byte Reserved_03; // 0x6C
    public byte Reserved_02; // 0x6D
    public byte Reserved_01; // 0x6E
    public byte Reserved_00; // 0x6F

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8907CC0
}

public class ControllerState5 : ValueType
{
    public uint ConnectedControllers; // 0x10
    public uint Buttons; // 0x14
    public uint Touches; // 0x18
    public uint NearTouches; // 0x1C
    public float LIndexTrigger; // 0x20
    public float RIndexTrigger; // 0x24
    public float LHandTrigger; // 0x28
    public float RHandTrigger; // 0x2C
    public Vector2f LThumbstick; // 0x30
    public Vector2f RThumbstick; // 0x38
    public Vector2f LTouchpad; // 0x40
    public Vector2f RTouchpad; // 0x48
    public byte LBatteryPercentRemaining; // 0x50
    public byte RBatteryPercentRemaining; // 0x51
    public byte LRecenterCount; // 0x52
    public byte RRecenterCount; // 0x53
    public float LTouchpadForce; // 0x54
    public float RTouchpadForce; // 0x58
    public float LStylusForce; // 0x5C
    public float RStylusForce; // 0x60
    public float LIndexTriggerCurl; // 0x64
    public float RIndexTriggerCurl; // 0x68
    public float LIndexTriggerSlide; // 0x6C
    public float RIndexTriggerSlide; // 0x70

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8907C60
}
