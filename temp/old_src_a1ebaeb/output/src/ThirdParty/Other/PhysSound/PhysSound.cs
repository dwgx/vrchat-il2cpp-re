// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.PhysSound
// Classes: 7
// Methods: 90

namespace ThirdParty.Other.PhysSound
{
    public class PhysSoundAudioContainer : Object
    {
        public object mat; // 0x33FA4030
        public object basePitch; // 0x33FA4030

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89350c0
        public void Updateenabled(){} // RVA: 0x7ffaa9f4f470
        public void Configurevolume(){} // RVA: 0x7ffaa9f4f590
        public void Updatevolume(){} // RVA: 0x7ffaa9f4f7c0
        public void get_name(){} // RVA: 0x7ffaa9f50060
        public void set_name(){} // RVA: 0x7ffaa9f50600
        public void Instantiate(){} // RVA: 0x7ffaa9f50720
        public void Equals(){} // RVA: 0x7ffaa9f50890
        public void Configurepitch(){} // RVA: 0x7ffaa9f51120
        public void ToString(){} // RVA: 0x7ffaa9f512d0
        public void Stop(){} // RVA: 0x7ffaa9f51440
        // ── Binary Analysis Named ──
        public void DoPlayHelper(){} // RVA: 0x7ffaa9f4f150
        public void DoStop(){} // RVA: 0x7ffaa9f4f300
        public void DoFloatToHalf(){} // RVA: 0x7ffaa9f4fac0
        public void DoHalfToFloat(){} // RVA: 0x7ffaa9f50a00
        public void GetHashCode(){} // RVA: 0x7ffaa8ce8da0
    }

    public class PhysSoundAudioSet : Object
    {
        public object Slide; // 0x33F9FD10

        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa9f498d0
        public void .ctor(){} // RVA: 0x7ffaa9f499f0
        public void Initialize(){} // RVA: 0x7ffaa9f498d0
        public void IsNativeObjectAlive(){} // RVA: 0x7ffaa9f498d0
        public void get_name(){} // RVA: 0x7ffaa9f49bc0
        public void set_name(){} // RVA: 0x7ffaa9f498d0
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaa9f498d0
        public void DoRandomRangeInt(){} // RVA: 0x7ffaa9f498e0
        public void GetCachedPtr(){} // RVA: 0x7ffaa9f49ab0
    }

    public class PhysSoundBase : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_destroyCancellationToken(){}
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class PhysSoundMaterial : ScriptableObject
    {
        public object FallbackTypeKey; // 0x337BE500
        public object SlidePitchMod; // 0x337BE500
        public object CollisionMask; // 0x337BE500
        public object AudioSets; // 0x337BE500
        public object Max; // 0x338CF9A0
        public object `Ǐf; // 0x338CF9A0

        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa9f47650
        public void CreateInstance(){} // RVA: 0x7ffaa9f478c0
        public void CreateScriptableObject(){} // RVA: 0x7ffaa9f47c00
        public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7ffaa9f47cd0
        public void ToString(){} // RVA: 0x7ffaa9f480a0
        public void Computelayer(){} // RVA: 0x7ffaa9f48410
        public void CalculateCollisionMagnitude(){} // RVA: 0x7ffaa9f48540
        public void Accesslayer(){} // RVA: 0x7ffaa9f48610
        public void ProcessAudioSetData(){} // RVA: 0x7ffaa9f48740
        public void OnEnable(){} // RVA: 0x7ffaa9f48920
        public void Computenormalized(){} // RVA: 0x7ffaa9f48dd0
        public void InitializeSoundProperty(){} // RVA: 0x7ffaa9f48ed0
        public void ProcessCollisionParameters(){} // RVA: 0x7ffaa9f49030
        public void .ctor(){} // RVA: 0x7ffaa9f49520
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa9f47a20
        public void Getlayer(){} // RVA: 0x7ffaa9f49410
    }

    public class PhysSoundObject : PhysSoundBase
    {
        public object f_045; // 0x33BEC350, was: ÎÎÍÎÏÌÌÏÌÍÌÍÌÎÌÌÏÌÍÍÏÍÍ
        public object PlayClipAtPoint; // 0x33BEC350
        public object f_F84; // 0x33BEC350, was: ÎÌÏÍÍÎÏÌÎÍÎÏÎÏÏÎÍÍÌÏÎÌÌ
        public object f_DF1; // 0x33BEC350, was: ÌÌÍÏÏÍÎÌÌÎÌÌÏÌÎÌÎÌÏÏÍÏÎ
        public object f_244; // 0x33BEC350, was: ÏÎÎÌÌÍÌÌÍÌÏÌÎÌÌÏÎÎÎÎÎÌÏ

        // ── Original Methods ──
        public void _SetTargetVolumeAndPitch(){} // RVA: 0x7ffaa9f49cd0
        public void UpdatePhysicsSoundProperty(){} // RVA: 0x7ffaa9f49ea0
        public void OnCollisionStay(){} // RVA: 0x7ffaa9f4a000
        public void OnCollisionExit2D(){} // RVA: 0x7ffaa9f4a790
        public void OnCollisionEnter2D(){} // RVA: 0x7ffaa9f4ab40
        public void ProcessCollisionParameters(){} // RVA: 0x7ffaa9f4adf0
        public void OnCollisionStay2D(){} // RVA: 0x7ffaa9f4ae80
        public void _playImpactSound(){} // RVA: 0x7ffaa9f4b2b0
        public void OnCollisionEnter(){} // RVA: 0x7ffaa9f4b940
        public void Update(){} // RVA: 0x7ffaa9f4bda0
        public void ComputeCollisionSoundProperties(){} // RVA: 0x7ffaa9f4c540
        public void Stop(){} // RVA: 0x7ffaa9f4ca30
        public void Start(){} // RVA: 0x7ffaa9f4d020
        public void .ctor(){} // RVA: 0x7ffaa9f4dd30
        public void OnCollisionExit(){} // RVA: 0x7ffaa9f4de70
        public void ComputegameObject(){} // RVA: 0x7ffaa9f4e1a0
        public void HandleCollisionPhysics(){} // RVA: 0x7ffaa9f4e690
        public void Computeenabled(){} // RVA: 0x7ffaa9f4ecf0
        // ── Binary Analysis Named ──
        public void SetPhysSoundParameter(){} // RVA: 0x7ffaa9f4aac0
        public void DoStop(){} // RVA: 0x7ffaa9f4c0d0
        public void DoRemoveAt(){} // RVA: 0x7ffaa9f4dc60
        public void DoHalfToFloat(){} // RVA: 0x7ffaa9f4eb20
        // ── Obfuscated Methods ──
        public void m_FF9(){} // RVA: 0x7ffaa89600c0
        public void m_4AE(){} // RVA: 0x7ffaa9f4cec0
    }

    public class PhysSoundTerrain : PhysSoundBase
    {
        public object _physSoundTerrain; // 0x3354A450, was: ÏÏÏÏÍÎÍÏÌÎÏÍÌÌÏÍÌÍÍÎÎÍÌ

        // ── Original Methods ──
        public void Computetransform(){} // RVA: 0x7ffaa9f55570
        public void CalculateMaxTerrainParameter(){} // RVA: 0x7ffaa9f55920
        public void Start(){} // RVA: 0x7ffaa9f55990
        public void CalculateTerrainPhysicsProperties(){} // RVA: 0x7ffaa9f55d40
        public void .ctor(){} // RVA: 0x7ffaa9f55f20
        public void Initialize(){} // RVA: 0x7ffaa9f560b0
        public void FindMaxParameterIndexWithThreshold(){} // RVA: 0x7ffaa9f564e0
        public void ProcessTerrainPhysicsData(){} // RVA: 0x7ffaa9f56560
        public void ComputeInternal_a(){} // RVA: 0x7ffaa9f56960
        // ── Binary Analysis Named ──
        public void GetMaxParameterIndex(){} // RVA: 0x7ffaa9f56460
        public void DoGetAlphamaps(){} // RVA: 0x7ffaa9f56c40
    }

    public class Range : ValueType
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa9f57780
        public void InternalEquals(){} // RVA: 0x7ffaa9f577b0
        public void DefaultEquals(){} // RVA: 0x7ffaa9f577f0
        public void InternalGetHashCode(){} // RVA: 0x7ffaa9f57850
        public void ToString(){} // RVA: 0x7ffaa9f57880
        public void EvaluateRangeValue(){} // RVA: 0x7ffaa9f578b0
        public void Lerp(){} // RVA: 0x7ffaa9f578d0
        public void .ctor(){} // RVA: 0x7ffaa8955d10
        public void Contains(){} // RVA: 0x7ffaa9f578f0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa9f57810
        public void GetHashCodeOfPtr(){} // RVA: 0x7ffaa9f578b0
        // ── Obfuscated Methods ──
        public void m_905(){} // RVA: 0x7ffaa9f578b0
    }

}