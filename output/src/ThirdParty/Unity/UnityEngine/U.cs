// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 8
// Methods: 20

namespace ThirdParty.Unity.UnityEngine
{
    public class UICharInfo : ValueType
    {
        public UnityEngine.Vector2 cursorPos; // 0x10
        public float charWidth; // 0x18
    }

    public class UILineInfo : ValueType
    {
        public int startCharIdx; // 0x10
        public int height; // 0x14
        public float topY; // 0x18
        public float leading; // 0x1C
    }

    public class UIVertex : ValueType
    {
        public UnityEngine.Vector3 position; // 0x10
        public UnityEngine.Vector3 normal; // 0x1C
        public UnityEngine.Vector4 tangent; // 0x28
        public UnityEngine.Color32 color; // 0x38
        public UnityEngine.Vector4 uv0; // 0x3C
        public UnityEngine.Vector4 uv1; // 0x4C
        public UnityEngine.Vector4 uv2; // 0x5C
        public UnityEngine.Vector4 uv3; // 0x6C
        public UnityEngine.Color32 s_DefaultColor;
        public UnityEngine.Vector4 s_DefaultTangent; // 0x4
        public UnityEngine.UIVertex simpleVert; // 0x14

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54E6B4F0
    }

    public class UnhandledExceptionHandler : Object
    {
        // ── Methods ──
        public void RegisterUECatcher(){} // RVA: 0x7FFD54CE5840
    }

    public class UnityAPICompatibilityVersionAttribute : Attribute
    {
        public string _version; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54CE5B20 | overloaded x2
    }

    public class UnityEngineModuleAssembly : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UnityException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54CE47E0 | overloaded x3
    }

    public class UnitySynchronizationContext : SynchronizationContext
    {
        public System.Collections.Generic.List`1<WorkRequest> m_AsyncWorkQueue; // 0x18
        public System.Collections.Generic.List`1<WorkRequest> m_CurrentFrameWork; // 0x20
        public int m_MainThreadID; // 0x28
        public int m_TrackedCount; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54CE7F40 | overloaded x2
        public void Send(){} // RVA: 0x7FFD54CE8100
        public void OperationStarted(){} // RVA: 0x7FFD54CE8450
        public void OperationCompleted(){} // RVA: 0x7FFD54CE8460
        public void Post(){} // RVA: 0x7FFD54CE8470
        public void CreateCopy(){} // RVA: 0x7FFD54CE8660
        public void Exec(){} // RVA: 0x7FFD54CE8850
        public void HasPendingTasks(){} // RVA: 0x7FFD54CE8C00
        public void InitializeSynchronizationContext(){} // RVA: 0x7FFD54CE8C60
        public void ExecuteTasks(){} // RVA: 0x7FFD54CE8D20
        public void ExecutePendingTasks(){} // RVA: 0x7FFD54CE8D80
    }

}