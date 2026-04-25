// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.PhysSound
// Classes: 7
// Methods: 96

namespace ThirdParty.Other.PhysSound
{
    public class PhysSoundAudioContainer : Object
    {
        public int KeyIndex; // 0x10
        public UnityEngine.AudioSource SlideAudio; // 0x18
        public PhysSound.PhysSoundMaterial mat; // 0x20
        public float targetVolume; // 0x28
        public float baseVol; // 0x2C
        public float basePitch; // 0x30
        public float basePitchRand; // 0x34

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC45319D0
        public void Equals(){} // RVA: 0x7FFAC4531B80
        public void GetHashCode(){} // RVA: 0x7FFAC4531D30
        public void op_Implicit(){} // RVA: 0x7FFAC4531EA0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC4531FC0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC45321F0
        public void GetCachedPtr(){} // RVA: 0x7FFAC45323A0
        public void get_name(){} // RVA: 0x7FFAC4532AC0
        public void set_name(){} // RVA: 0x7FFAC32C57A0
        public void Instantiate(){} // RVA: 0x7FFAC4532CF0
        public void ToString(){} // RVA: 0x7FFAC32C57A0
        public void Instantiate_8DDB758F14C8(){} // RVA: 0x7FFAC4532EA0
        public void GetHashCode_A8F6820E4A0E(){} // RVA: 0x7FFAC45330D0
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void Initialize(){} // RVA: 0x7FFAC32C57A0
        public void Stop(){} // RVA: 0x7FFAC45333D0
    }

    public class PhysSoundAudioSet : Object
    {
        public int Key; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.AudioClip> Impacts; // 0x18
        public UnityEngine.AudioClip Slide; // 0x20

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC452BC40
        public void Equals(){} // RVA: 0x7FFAC452BC50
        public void GetHashCode(){} // RVA: 0x7FFAC452BC40
        public void op_Implicit(){} // RVA: 0x7FFAC452BC40
        public void CompareBaseObjects(){} // RVA: 0x7FFAC452BD60
        public void .ctor(){} // RVA: 0x7FFAC452BE70
        public void Initialize(){} // RVA: 0x7FFAC452BF30
        public void get_name(){} // RVA: 0x7FFAC452C040
        public void set_name(){} // RVA: 0x7FFAC452C150
    }

    public class PhysSoundBase : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){}
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class PhysSoundMaterial : ScriptableObject
    {
        public int MaterialTypeKey; // 0x18
        public int FallbackTypeIndex; // 0x1C
        public int FallbackTypeKey; // 0x20
        public PhysSound.Range RelativeVelocityThreshold; // 0x24
        public float PitchRandomness; // 0x2C
        public float SlidePitchMod; // 0x30
        public float SlideVolMultiplier; // 0x34
        public float ImpactNormalBias; // 0x38
        public UnityEngine.LayerMask CollisionMask; // 0x3C
        public bool UseCollisionVelocity; // 0x40
        public bool ScaleImpactVolume; // 0x41
        public System.Collections.Generic.List`1<PhysSound.PhysSoundAudioSet> AudioSets; // 0x48
        public System.Collections.Generic.Dictionary`2<int,PhysSound.PhysSoundAudioSet> audioSetDic; // 0x50

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4529E90
        public void .ctor(){} // RVA: 0x7FFAC452A310
        public void Initialize(){} // RVA: 0x7FFAC452A400
        public void CreateScriptableObject(){} // RVA: 0x7FFAC452A4D0
        public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFAC452A840
        public void GetHashCode(){} // RVA: 0x7FFAC452A9A0
        public void ToString(){} // RVA: 0x7FFAC452AAA0
        public void CalculateCollisionMagnitude(){} // RVA: 0x7FFAC452AB70
        public void Accesslayer(){} // RVA: 0x7FFAC452ACA0
        public void OnEnable(){} // RVA: 0x7FFAC452AE00
        public void OnDisable(){} // RVA: 0x7FFAC452B2B0
        public void Computenormalized(){} // RVA: 0x7FFAC452B490
        public void InitializeSoundProperty(){} // RVA: 0x7FFAC452B560
        public void ProcessCollisionParameters(){} // RVA: 0x7FFAC452B720
        public void Getlayer(){} // RVA: 0x7FFAC452B880
        public void Getlayer_6DF3440D811F(){} // RVA: 0x7FFAC452B9E0
        public void Nnnoiseless(){} // RVA: 0x7FFAC452BB10
    }

    public class PhysSoundObject : PhysSoundBase
    {
        public PhysSound.PhysSoundMaterial SoundMaterial; // 0x20
        public UnityEngine.AudioSource ImpactAudio; // 0x28
        public float ÌÏÌÏÌÏÍÎÏÌÍÎÎÏÌÍÍÌÌÌÍÏÎ; // 0x30
        public float ÌÍÌÏÎÌÏÌÎÎÍÏÍÍÎÌÌÌÌÍÎÎÎ; // 0x34
        public bool AutoCreateSources; // 0x38
        public bool PlayClipAtPoint; // 0x39
        public System.Collections.Generic.List`1<PhysSound.PhysSoundAudioContainer> AudioContainers; // 0x40
        public System.Collections.Generic.Dictionary`2<int,PhysSound.PhysSoundAudioContainer> ÎÍÌÎÏÍÎÎÏÌÌÌÌÍÎÏÎÏÏÍÍÎÏ; // 0x48
        public UnityEngine.Vector3 ÏÍÏÍÍÌÎÎÌÍÎÏÎÏÌÏÏÎÌÎÎÌÍ; // 0x50
        public bool ÎÍÎÍÏÍÎÌÌÍÏÌÌÍÌÍÍÏÌÍÍÍÍ; // 0x5C
        public UnityEngine.Rigidbody ÎÎÎÍÏÌÏÌÍÎÌÏÎÎÏÎÎÍÍÍÏÌÎ; // 0x60
        public UnityEngine.Rigidbody2D ÎÍÍÍÌÌÏÌÍÏÏÍÎÏÍÌÌÌÏÍÍÌÏ; // 0x68
        public bool ÍÏÏÌÏÍÌÎÎÌÏÌÏÌÎÏÌÌÏÍÌÌÍ; // 0x70
        public float ÍÏÏÍÏÎÍÍÌÏÍÎÏÍÎÏÎÏÏÌÎÍÏ; // 0x74
        public float ÏÌÏÎÌÌÍÏÎÎÌÏÌÌÏÌÏÏÎÍÍÏÌ;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC452C260
        public void OnCollisionEnter2D(){} // RVA: 0x7FFAC452C3A0
        public void LateUpdate(){} // RVA: 0x7FFAC452C650
        public void IsInvoking(){} // RVA: 0x7FFAC452C720
        public void OnCollisionEnter(){} // RVA: 0x7FFAC452C9D0
        public void SetPhysSoundParameter(){} // RVA: 0x7FFAC452CE30
        public void StopCoroutine(){} // RVA: 0x7FFAC452D000
        public void ProcessCollisionParameters(){} // RVA: 0x7FFAC452D0C0
        public void UpdateCollisionAudio(){} // RVA: 0x7FFAC452D550
        public void ProcessArticleStatus(){} // RVA: 0x7FFAC452D5E0
        public void Start(){} // RVA: 0x7FFAC452DA90
        public void _SetTargetVolumeAndPitch(){} // RVA: 0x7FFAC452E6D0
        public void OnCollisionStay2D(){} // RVA: 0x7FFAC452E8A0
        public void ComputeCollisionSoundProperties(){} // RVA: 0x7FFAC452ECD0
        public void Stop(){} // RVA: 0x7FFAC452F1C0
        public void OnCollisionExit2D(){} // RVA: 0x7FFAC452F320
        public void OnCollisionStay(){} // RVA: 0x7FFAC452F650
        public void DoRemoveAt(){} // RVA: 0x7FFAC452FDE0
        public void StopCoroutine_AD111D03B6F8(){} // RVA: 0x7FFAC452FE60
        public void SetPosition(){} // RVA: 0x7FFAC45305F0
        public void OnCollisionExit(){} // RVA: 0x7FFAC4530750
        public void HandleCollisionPhysics(){} // RVA: 0x7FFAC2F4F0C0
        public void _playImpactSound(){} // RVA: 0x7FFAC4530A80
        public void Update(){} // RVA: 0x7FFAC4531110
        public void LateUpdate_1AAF3D48C6F3(){} // RVA: 0x7FFAC4531440
    }

    public class PhysSoundTerrain : PhysSoundBase
    {
        public UnityEngine.Terrain Terrain; // 0x20
        public System.Collections.Generic.List`1<PhysSound.PhysSoundMaterial> SoundMaterials; // 0x28
        public System.Collections.Generic.Dictionary`2<int,ÎÏÌÎÌÏÏÎÎÌÏÎÌÎÏÍÌÍÍÎÍÌÏ> ÍÏÌÍÌÌÍÏÎÍÎÎÏÎÏÍÏÎÏÎÌÌÍ; // 0x30
        public UnityEngine.TerrainData ÎÍÎÌÍÍÏÏÍÎÏÌÎÎÌÌÌÏÌÌÌÌÌ; // 0x38
        public UnityEngine.Vector3 ÌÏÌÍÌÏÎÌÌÎÍÎÏÎÌÏÏÏÍÏÏÍÎ; // 0x40

        // ── Methods ──
        public void Computetransform(){} // RVA: 0x7FFAC4536B80
        public void CalculateMaxTerrainParameter(){} // RVA: 0x7FFAC4536E80
        public void .ctor(){} // RVA: 0x7FFAC4537060
        public void Initialize(){} // RVA: 0x7FFAC45371F0
        public void DoGetEnumerator(){} // RVA: 0x7FFAC45374F0
        public void Start(){} // RVA: 0x7FFAC4537570
        public void GetMaxParameterIndex(){} // RVA: 0x7FFAC4537920
        public void FindMaxParameterIndexWithThreshold(){} // RVA: 0x7FFAC4537C10
        public void ProcessTerrainPhysicsData(){} // RVA: 0x7FFAC4537F10
        public void ComputeInternal_a(){} // RVA: 0x7FFAC4538200
        public void DoGetAlphamaps(){} // RVA: 0x7FFAC4538280
        public void op_Implicit(){} // RVA: 0x7FFAC4538560
        public void RaiseCancellation(){} // RVA: 0x7FFAC45385E0
    }

    public class Range : ValueType
    {
        public float Min; // 0x10
        public float Max; // 0x14

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4538F60
        public void InternalEquals(){} // RVA: 0x7FFAC4538F80
        public void DefaultEquals(){} // RVA: 0x7FFAC4538F80
        public void GetHashCode(){} // RVA: 0x7FFAC4538FA0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4538FD0
        public void ToString(){} // RVA: 0x7FFAC4538FF0
        public void Contains(){} // RVA: 0x7FFAC4539010
        public void EvaluateRangeValue(){} // RVA: 0x7FFAC4539030
        public void Lerp(){} // RVA: 0x7FFAC4538F80
        public void Clamp(){} // RVA: 0x7FFAC4539060
        public void InternalGetHashCode_C0F1DDBB83A6(){} // RVA: 0x7FFAC4538FD0
        public void ResetNetworkBehaviour(){} // RVA: 0x7FFAC4538F80
        public void .ctor_C45BF15F9403(){} // RVA: 0x7FFAC45390A0
        public void .ctor(){} // RVA: 0x7FFAC2F44D10
    }

}