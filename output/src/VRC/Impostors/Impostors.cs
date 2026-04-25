// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Impostors
// Classes: 2
// Methods: 44

namespace VRC.Impostors
{
    public class Impostor : MonoBehaviour
    {
        public System.Collections.Generic.List`1<UnityEngine.Mesh> _impostor; // 0x20
        public UnityEngine.MeshFilter meshFilter; // 0x28
        public UnityEngine.Material material; // 0x30
        public UnityEngine.MeshRenderer meshRenderer; // 0x38
        public UnityEngine.Quaternion initialRotation; // 0x40
        public UnityEngine.Transform childTransform; // 0x50
        public UnityEngine.Vector3 projectedChildPoint; // 0x58
        public VRC.Impostors.ImpostorAvatar impostorAvatar; // 0x68
        public ImposterData Data; // 0x70
        public UnityEngine.MaterialPropertyBlock ÌÎÌÎÍÌÌÍÌÎÍÎÏÏÌÎÌÏÍÍÏÎÍ; // 0x78
        public UnityEngine.Bounds <ÍÏÍÍÌÌÌÍÎÏÌÍÍÏÌÎÌÏÌÌÏÌÌ>k__BackingField; // 0x80
        public int ÌÏÎÏÌÍÎÍÍÎÍÍÏÍÍÏÍÍÏÌÌÍÏ; // 0x98
        public int ÌÏÎÍÌÏÌÏÍÍÎÎÏÏÏÏÍÍÏÌÍÎÌ; // 0x9C
        public System.Collections.Generic.List`1<System.ValueTuple`2<float,System.Collections.Generic.List`1<int>>> ÌÎÏÎÏÎÍÎÍÌÏÌÎÏÍÌÌÌÏÎÌÎÏ; // 0xA0
        public int ÎÎÌÏÏÌÌÌÎÏÍÍÍÎÏÍÍÍÏÎÎÏÌ; // 0xA8
        public System.Collections.Generic.Dictionary`2<int,System.Collections.Generic.List`1<System.ValueTuple`2<float,System.Collections.Generic.List`1<int>>>> ÏÎÍÏÌÌÌÎÍÎÍÍÏÌÎÎÎÍÌÌÍÏÏ;
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<int,System.Collections.Generic.List`1<System.Collections.Generic.List`1<int>>>> ÏÎÌÍÌÏÍÏÎÌÎÏÍÎÎÍÎÎÍÌÌÌÍ; // 0x8
        public int[] ÏÎÏÌÏÏÌÏÎÍÎÌÌÎÎÍÍÎÏÏÎÏÌ; // 0x10
        public VRC.Profiling.ProfilerMarker ÏÎÏÏÏÌÎÎÏÌÎÍÍÎÎÌÎÌÌÏÎÏÎ; // 0x18
        public int ÏÎÍÍÌÎÎÍÏÎÍÌÍÎÌÍÌÍÌÏÌÍÍ; // 0xAC
        public int ÍÏÏÏÏÌÍÏÌÌÎÏÎÌÌÌÍÎÏÏÍÌÍ; // 0xB0
        public System.Collections.Generic.Dictionary`2<UnityEngine.Transform,System.ValueTuple`3<int,UnityEngine.Vector3,float>> ÎÌÎÏÎÎÏÍÌÏÎÏÏÎÍÍÌÎÏÌÍÏÏ; // 0xB8
        public System.Collections.Generic.Dictionary`2<int,string> ÌÌÌÏÎÌÍÎÍÍÎÌÎÌÎÌÌÌÍÌÌÍÎ; // 0x28
        public System.Collections.Generic.Dictionary`2<int,System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<int,UnityEngine.Vector3>>> ÏÌÏÍÍÎÏÎÌÍÏÎÍÏÍÍÌÍÌÌÌÎÌ; // 0x30
        public System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<int,UnityEngine.Vector3>> ÏÌÎÏÌÌÌÍÌÌÎÎÍÏÍÌÌÌÌÍÌÌÏ; // 0xC0

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3A8DB80
        public void RaiseCancellation(){} // RVA: 0x7FFAC3A8DDD0
        public void Awake(){} // RVA: 0x7FFAC3A8E280
        public void .ctor(){} // RVA: 0x7FFAC3A8E500
        public void Initialize(){} // RVA: 0x7FFAC3A8E680
        public void InvokeRepeating(){} // RVA: 0x7FFAC3A8E940
        public void CancelInvoke(){} // RVA: 0x7FFAC3A8EDF0
        public void IsInvoking(){} // RVA: 0x7FFAC3A8F660
        public void StartCoroutine(){} // RVA: 0x7FFAC3A8F6F0
        public void FixedUpdate(){} // RVA: 0x7FFAC3A900E0
        public void OnApplicationPause(){} // RVA: 0x7FFAC3A90AC0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC3A90F70
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC3A91210
        public void OnDestroy(){} // RVA: 0x7FFAC3A91410
        public void StopCoroutine(){} // RVA: 0x7FFAC3A91610
        public void StopAllCoroutines(){} // RVA: 0x7FFAC3A91800
        public void get_useGUILayout(){} // RVA: 0x7FFAC3A91CB0
        public void set_useGUILayout(){} // RVA: 0x7FFAC3A91CD0
        public void print(){} // RVA: 0x7FFAC3A91CF0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC3A91E40
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC3A920E0
        public void InvokeDelayed(){} // RVA: 0x7FFAC3A92940
        public void OnTriggerStay(){} // RVA: 0x7FFAC3A92BE0
        public void OnTriggerExit(){} // RVA: 0x7FFAC3A91CD0
        public void .cctor(){} // RVA: 0x7FFAC3A93150
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC3A93710
    }

    public class ImpostorAvatar : MonoBehaviour
    {
        public UnityEngine.Animator _impostorAvatar; // 0x20
        public UnityEngine.Bounds ÎÏÍÎÎÌÎÏÍÎÏÍÌÍÌÌÏÍÌÌÌÍÍ; // 0x28
        public System.Action`2<VRC.Impostors.ImpostorAvatar,int> ÏÌÏÎÏÏÌÍÌÎÍÍÌÍÎÍÏÏÌÎÏÎÎ; // 0x40
        public int ÍÏÏÏÌÍÏÏÎÍÏÌÍÍÌÎÏÏÌÎÏÏÎ;
        public int ÏÎÏÏÏÍÏÎÎÍÏÎÍÎÌÎÎÍÎÎÎÎÍ; // 0x48
        public int ÍÌÏÏÎÎÏÏÏÎÍÎÏÍÎÏÍÏÎÎÎÏÍ; // 0x4C
        public VRC.Impostors.Impostor[] ÏÌÌÎÍÏÍÎÎÍÍÏÍÏÍÍÍÏÌÏÏÏÎ; // 0x50

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3A93C80
        public void RaiseCancellation(){} // RVA: 0x7FFAC3A93E00
        public void IsInvoking(){} // RVA: 0x7FFAC3A94000
        public void OnEnable(){} // RVA: 0x7FFAC3A945F0
        public void Awake(){} // RVA: 0x7FFAC3A94770
        public void OnDestroy(){} // RVA: 0x7FFAC3A94780
        public void CancelInvoke(){} // RVA: 0x7FFAC3A94A50
        public void LateUpdate(){} // RVA: 0x7FFAC3A94AF0
        public void StartCoroutine(){} // RVA: 0x7FFAC3A95070
        public void OnApplicationPause(){} // RVA: 0x7FFAC3A95110
        public void AccesscullingMask(){} // RVA: 0x7FFAC3A95520
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC3A95930
        public void StopCoroutine(){} // RVA: 0x7FFAC3A95960
        public void .ctor(){} // RVA: 0x7FFAC3A95B50
        public void Initialize(){} // RVA: 0x7FFAC3A95BA0
        public void OnDisable(){} // RVA: 0x7FFAC3A95E60
        public void Start(){} // RVA: 0x7FFAC3A95FE0
        public void set_useGUILayout(){} // RVA: 0x7FFAC3A96630
    }

}