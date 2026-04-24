// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.VFX
// Classes: 11
// Methods: 32

namespace ThirdParty.Unity.UnityEngine.VFX
{
    public class VFXBatchInfo : ValueType
    {
        public uint capacity; // 0x10
        public uint activeInstanceCount; // 0x14
    }

    public class VFXBatchedEffectInfo : ValueType
    {
        public UnityEngine.VFX.VisualEffectAsset vfxAsset; // 0x10
        public uint activeBatchCount; // 0x18
        public uint inactiveBatchCount; // 0x1C
        public uint activeInstanceCount; // 0x20
        public uint unbatchedInstanceCount; // 0x24
        public uint totalInstanceCapacity; // 0x28
        public uint maxInstancePerBatchCapacity; // 0x2C
        public ulong totalGPUSizeInBytes; // 0x30
        public ulong totalCPUSizeInBytes; // 0x38
    }

    public class VFXCameraXRSettings : ValueType
    {
        public uint viewTotal; // 0x10
        public uint viewCount; // 0x14
        public uint viewOffset; // 0x18
    }

    public class VFXEventAttribute : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public bool m_Owner; // 0x18
        public UnityEngine.VFX.VisualEffectAsset m_VfxAsset; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD550B7F10
        public void CreateEventAttributeWrapper(){} // RVA: 0x7FFD550B7F70
        public void SetWrapValue(){} // RVA: 0x7FFD550B8010
        public void Internal_Create(){} // RVA: 0x7FFD550B8080
        public void Internal_InstanciateVFXEventAttribute(){} // RVA: 0x7FFD550B80D0
        public void Internal_InitFromAsset(){} // RVA: 0x7FFD550B8210
        public void Release(){} // RVA: 0x7FFD550B8270
        public void Finalize(){} // RVA: 0x7FFD550B8330
        public void Dispose(){} // RVA: 0x7FFD550B8370
        public void Internal_Destroy(){} // RVA: 0x7FFD550B83D0
    }

    public class VFXExpressionValues : Object
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void CreateExpressionValuesWrapper(){} // RVA: 0x7FFD550B8420
    }

    public class VFXManager : Object
    {
        public UnityEngine.VFX.VFXCameraXRSettings kDefaultCameraXRSettings;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD550B8470
    }

    public class VFXSpawnerCallbacks : ScriptableObject
    {
        // ── Methods ──
        public void OnPlay(){} // RVA: 0x7FFD4E09AF60
        public void OnUpdate(){} // RVA: 0x7FFD4E09AF60
        public void OnStop(){} // RVA: 0x7FFD4E09AF60
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class VFXSpawnerState : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public bool m_Owner; // 0x18
        public UnityEngine.VFX.VFXEventAttribute m_WrapEventAttribute; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD550B84D0
        public void CreateSpawnerStateWrapper(){} // RVA: 0x7FFD550B84E0
        public void PrepareWrapper(){} // RVA: 0x7FFD550B86C0
        public void SetWrapValue(){} // RVA: 0x7FFD550B8860
        public void Release(){} // RVA: 0x7FFD550B8980
        public void Finalize(){} // RVA: 0x7FFD550B8A40
        public void Dispose(){} // RVA: 0x7FFD550B8A80
        public void Internal_Destroy(){} // RVA: 0x7FFD550B8AE0
    }

    public class VisualEffect : Behaviour
    {
        public UnityEngine.VFX.VFXEventAttribute visualEffectAsset; // 0x18
        public System.Action`1<ÌÏÌÌÌÏÌÏÌÎÎÍÍÏÌ> outputEventReceived; // 0x20

        // ── Methods ──
        public void get_visualEffectAsset(){} // RVA: 0x7FFD550B8C80
        public void CreateVFXEventAttribute(){} // RVA: 0x7FFD550B8CD0
        public void InvokeGetCachedEventAttributeForOutputEvent_Internal(){} // RVA: 0x7FFD550B8F60
        public void InvokeOutputEventReceived_Internal(){} // RVA: 0x7FFD550B8FF0
    }

    public class VisualEffectAsset : VisualEffectObject
    {
        public int PlayEventID;
        public int StopEventID; // 0x4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD550B8B30
        public void .cctor(){} // RVA: 0x7FFD550B8B80
    }

    public class VisualEffectObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD550B8B30
    }

}