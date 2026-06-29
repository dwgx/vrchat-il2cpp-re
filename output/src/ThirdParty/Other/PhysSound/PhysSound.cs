// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.PhysSound
// Classes: 10
// Methods: 141

namespace ThirdParty.Other.PhysSound
{
    public class PhysSoundAudioContainer : Object
    {
        public object KeyIndex;
        public object SlideAudio;
        public object mat;
        public object targetVolume;
        public object baseVol;
        public object basePitch;
        public object basePitchRand;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x233C590
        public void Equals(){} // RVA: 0x233C710
        public void GetHashCode(){} // RVA: 0x233C8D0
        public void op_Implicit(){} // RVA: 0x233CA00
        public void CompareBaseObjects(){} // RVA: 0x233CB30
        public void IsNativeObjectAlive(){} // RVA: 0xFEE6E0
        public void ToString(){} // RVA: 0x233CC30
        public void get_name(){} // RVA: 0x233CDB0
        public void set_name(){} // RVA: 0x233CEA0
        public void .ctor(){} // RVA: 0xB460A0
        public void Initialize(){} // RVA: 0x233D420
        public void DestroyImmediate(){} // RVA: 0x233D5F0
        public void FindObjectsOfType(){} // RVA: 0x233DC30
        public void FindObjectsByType(){} // RVA: 0x233DD20
        public void DontDestroyOnLoad(){} // RVA: 0x233DEA0
        public void get_hideFlags(){} // RVA: 0x233DF90
    }

    public class PhysSoundAudioContainer[] : Array
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

    public class PhysSoundAudioSet : Object
    {
        public object Key;
        public object Impacts;
        public object Slide;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x2335D40
        public void Equals(){} // RVA: 0x2335D40
        public void GetHashCode(){} // RVA: 0x2335D50
        public void op_Implicit(){} // RVA: 0x2335D40
        public void CompareBaseObjects(){} // RVA: 0x2335E60
        public void .ctor(){} // RVA: 0x2335F60
        public void Initialize(){} // RVA: 0x2335D40
        public void get_name(){} // RVA: 0x2336020
        public void set_name(){} // RVA: 0x2335D40
    }

    public class PhysSoundAudioSet[] : Array
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

    public class PhysSoundBase : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class PhysSoundMaterial : ScriptableObject
    {
        public object MaterialTypeKey;
        public object FallbackTypeIndex;
        public object FallbackTypeKey;
        public object RelativeVelocityThreshold;
        public object PitchRandomness;
        public object SlidePitchMod;
        public object SlideVolMultiplier;
        public object ImpactNormalBias;
        public object CollisionMask;
        public object UseCollisionVelocity;
        public object ScaleImpactVolume;
        public object AudioSets;
        public object audioSetDic;

        // ── Methods ──
        public void Equals(){} // RVA: 0x2333EB0
        public void CreateInstance(){} // RVA: 0x2334020
        public void CreateScriptableObject(){} // RVA: 0x23340F0
        public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x2334460
        public void OnEnable(){} // RVA: 0x2334660
        public void OnDisable(){} // RVA: 0x2334B00
        public void GetHashCode(){} // RVA: 0x2334BE0
        public void .ctor(){} // RVA: 0x2334CF0
        public void Initialize(){} // RVA: 0x2334DE0
        public void ToString(){} // RVA: 0x2334EF0
        // ── Unresolved (hash) ──
        public void m_354(){} // RVA: 0x2335000
        public void m_FD9(){} // RVA: 0x2335100
        public void m_29E(){} // RVA: 0x2335270
        public void m_851(){} // RVA: 0x2335370
        public void m_FBF(){} // RVA: 0x23354E0
        public void m_526(){} // RVA: 0x23355E0
    }

    public class PhysSoundMaterial[] : Array
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

    public class PhysSoundObject : PhysSoundBase
    {
        public object SoundMaterial;
        public object ImpactAudio;
        public object f_9F5;
        public object f_8E9;
        public object AutoCreateSources;
        public object PlayClipAtPoint;
        public object AudioContainers;
        public object f_7E9;
        public object f_D41;
        public object f_A58;
        public object f_12D;
        public object f_F9C;
        public object f_BA9;
        public object f_E30;
        public object f_245;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2336C00
        public void OnCollisionEnter2D(){} // RVA: 0x2336D40
        public void Start(){} // RVA: 0x2336F80
        public void _playImpactSound(){} // RVA: 0x23387A0
        public void OnCollisionEnter(){} // RVA: 0x2338AD0
        public void OnCollisionStay(){} // RVA: 0x23391F0
        public void OnCollisionExit2D(){} // RVA: 0x23398C0
        public void OnCollisionStay2D(){} // RVA: 0x2339FD0
        public void Update(){} // RVA: 0x233AE80
        public void _SetTargetVolumeAndPitch(){} // RVA: 0x233BA90
        public void OnCollisionExit(){} // RVA: 0x233BCF0
        // ── 16 unresolved (hash) ──
        public void m_F6F(){} // RVA: 0x2336130
        public void m_30F(){} // RVA: 0xB700F0
        public void m_8AB(){} // RVA: 0x23365F0
        public void m_E06(){} // RVA: 0x2336920
        public void m_951(){} // RVA: 0x2336A00
        // ... 11 more unresolved methods
    }

    public class PhysSoundTerrain : PhysSoundBase
    {
        public object Terrain;
        public object SoundMaterials;
        public object f_CFE;
        public object f_AA9;
        public object f_E96;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2341F10
        public void Initialize(){} // RVA: 0x23420A0
        public void Start(){} // RVA: 0x2342B20
        // ── Unresolved (hash) ──
        public void m_57C(){} // RVA: 0x2341B40
        public void m_ED3(){} // RVA: 0x2341EB0
        public void m_9C4(){} // RVA: 0x23423F0
        public void m_409(){} // RVA: 0x2342710
        public void m_4B0(){} // RVA: 0x2342E90
        public void m_88D(){} // RVA: 0x23431D0
        public void m_30F(){} // RVA: 0x2343230
        public void m_080(){} // RVA: 0x2343410
        public void m_145(){} // RVA: 0x2343490
    }

    public class Range : ValueType
    {
        public object Min;
        public object Max;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7C400
        public void InternalEquals(){} // RVA: 0x7C420
        public void DefaultEquals(){} // RVA: 0x7C440
        public void GetHashCode(){} // RVA: 0x7C470
        public void InternalGetHashCode(){} // RVA: 0x7C420
        public void ToString(){} // RVA: 0x7C4A0
        public void GetHashCodeOfPtr(){} // RVA: 0x7C4C0
        public void x(){} // RVA: 0x7C520
        public void .ctor(){} // RVA: 0x7C540
        public void Initialize(){} // RVA: 0x7C420
        // ── Unresolved (hash) ──
        public void m_A02(){} // RVA: 0x7C4F0
        public void m_49F(){} // RVA: 0x7C400
        public void m_730(){} // RVA: 0x7C550
        public void m_696(){} // RVA: 0x7C570
    }

}