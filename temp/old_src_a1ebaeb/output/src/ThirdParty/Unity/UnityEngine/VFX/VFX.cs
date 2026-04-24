// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.VFX
// Classes: 11
// Methods: 32

namespace ThirdParty.Unity.UnityEngine.VFX
{
    public class VFXBatchInfo : ValueType
    {
        public object x 00; // 0x32E13438
    }

    public class VFXBatchedEffectInfo : ValueType
    {
        public object inactiveBatchCount; // 0x32DF3560
        public object totalInstanceCapacity; // 0x32DF3560
        public object totalCPUSizeInBytes; // 0x32DF3560
    }

    public class VFXCameraXRSettings : ValueType
    {
        public object viewOffset; // 0x32DF38A0
    }

    public class VFXEventAttribute : Object
    {
        public object m_VfxAsset; // 0x32DF3A90

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf6b9e80
        public void CreateEventAttributeWrapper(){} // RVA: 0x7ffaaf6b9ee0
        public void Internal_Create(){} // RVA: 0x7ffaaf6b9ff0
        public void Internal_InstanciateVFXEventAttribute(){} // RVA: 0x7ffaaf6ba040
        public void Internal_InitFromAsset(){} // RVA: 0x7ffaaf6ba180
        public void Release(){} // RVA: 0x7ffaaf6ba1e0
        public void Finalize(){} // RVA: 0x7ffaaf6ba2a0
        public void Dispose(){} // RVA: 0x7ffaaf6ba2e0
        public void Internal_Destroy(){} // RVA: 0x7ffaaf6ba340
        // ── Binary Analysis Named ──
        public void SetWrapValue(){} // RVA: 0x7ffaaf6b9f80
    }

    public class VFXExpressionValues : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void CreateExpressionValuesWrapper(){} // RVA: 0x7ffaaf6ba390
    }

    public class VFXManager : Object
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaf6ba3e0
    }

    public class VFXSpawnerCallbacks : ScriptableObject
    {
        // ── Original Methods ──
        public void OnPlay(){} // RVA: 0x7ffaa866b2a0
        public void OnUpdate(){} // RVA: 0x7ffaa866b2a0
        public void OnStop(){} // RVA: 0x7ffaa866b2a0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class VFXSpawnerState : Object
    {
        public object m_WrapEventAttribute; // 0x32E281E0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf6ba440
        public void CreateSpawnerStateWrapper(){} // RVA: 0x7ffaaf6ba450
        public void PrepareWrapper(){} // RVA: 0x7ffaaf6ba630
        public void Release(){} // RVA: 0x7ffaaf6ba8f0
        public void Finalize(){} // RVA: 0x7ffaaf6ba9b0
        public void Dispose(){} // RVA: 0x7ffaaf6ba9f0
        public void Internal_Destroy(){} // RVA: 0x7ffaaf6baa50
        // ── Binary Analysis Named ──
        public void SetWrapValue(){} // RVA: 0x7ffaaf6ba7d0
    }

    public class VisualEffect : Behaviour
    {
        // ── Original Methods ──
        public void get_visualEffectAsset(){} // RVA: 0x7ffaaf6babf0
        public void CreateVFXEventAttribute(){} // RVA: 0x7ffaaf6bac40
        public void InvokeGetCachedEventAttributeForOutputEvent_Internal(){} // RVA: 0x7ffaaf6baed0
        public void InvokeOutputEventReceived_Internal(){} // RVA: 0x7ffaaf6baf60
    }

    public class VisualEffectAsset : VisualEffectObject
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf6baaa0
        public void .cctor(){} // RVA: 0x7ffaaf6baaf0
    }

    public class VisualEffectObject : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf6baaa0
    }

}