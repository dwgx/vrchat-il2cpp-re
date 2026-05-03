// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.VFX
// Classes: 12
// Methods: 33

namespace ThirdParty.Unity.UnityEngine.VFX
{
    public class VFXBatchInfo : ValueType
    {
    }

    public class VFXBatchedEffectInfo : ValueType
    {
    }

    public class VFXCameraXRSettings : ValueType
    {
    }

    public class VFXEventAttribute : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88040760
        public void CreateEventAttributeWrapper(){} // RVA: 0x7FFE880407C0
        public void SetWrapValue(){} // RVA: 0x7FFE88040860
        public void Internal_Create(){} // RVA: 0x7FFE880408D0
        public void Internal_InstanciateVFXEventAttribute(){} // RVA: 0x7FFE88040920
        public void Internal_InitFromAsset(){} // RVA: 0x7FFE88040A60
        public void Release(){} // RVA: 0x7FFE88040AC0
        public void Finalize(){} // RVA: 0x7FFE88040B80
        public void Dispose(){} // RVA: 0x7FFE88040BC0
        public void Internal_Destroy(){} // RVA: 0x7FFE88040C20
    }

    public class VFXExpressionValues : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CreateExpressionValuesWrapper(){} // RVA: 0x7FFE88040C70
    }

    public class VFXManager : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE88040CC0
    }

    public class VFXOutputEventArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE844576B0
    }

    public class VFXSpawnerCallbacks : ScriptableObject
    {
        // ── Methods ──
        public void OnPlay(){} // RVA: 0x7FFE80E50660
        public void OnUpdate(){} // RVA: 0x7FFE80E50660
        public void OnStop(){} // RVA: 0x7FFE80E50660
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class VFXSpawnerState : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88040D20
        public void CreateSpawnerStateWrapper(){} // RVA: 0x7FFE88040D30
        public void PrepareWrapper(){} // RVA: 0x7FFE88040F10
        public void SetWrapValue(){} // RVA: 0x7FFE880410B0
        public void Release(){} // RVA: 0x7FFE880411D0
        public void Finalize(){} // RVA: 0x7FFE88041290
        public void Dispose(){} // RVA: 0x7FFE880412D0
        public void Internal_Destroy(){} // RVA: 0x7FFE88041330
    }

    public class VisualEffect : Behaviour
    {
        public UnityEngine.VFX.VFXEventAttribute m_cachedEventAttribute; // 0x18

        // ── Methods ──
        public void get_visualEffectAsset(){} // RVA: 0x7FFE880414D0
        public void CreateVFXEventAttribute(){} // RVA: 0x7FFE88041520
        public void InvokeGetCachedEventAttributeForOutputEvent_Internal(){} // RVA: 0x7FFE880417B0
        public void InvokeOutputEventReceived_Internal(){} // RVA: 0x7FFE88041840
    }

    public class VisualEffectAsset : VisualEffectObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88041380
        public void .cctor(){} // RVA: 0x7FFE880413D0
    }

    public class VisualEffectObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88041380
    }

}