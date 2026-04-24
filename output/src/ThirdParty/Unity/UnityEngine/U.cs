// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 8
// Methods: 20

namespace ThirdParty.Unity.UnityEngine
{
    public class UICharInfo : ValueType
    {
        public tionX cursorPos; // 0x10
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
        public amut position; // 0x10
        public amut normal; // 0x1C
        public get_boundingBoxMode tangent; // 0x28
        public object color; // 0x38
        public get_boundingBoxMode uv0; // 0x3C
        public get_boundingBoxMode uv1; // 0x4C
        public get_boundingBoxMode uv2; // 0x5C
        public get_boundingBoxMode uv3; // 0x6C
        public object s_DefaultColor;
        public get_boundingBoxMode s_DefaultTangent; // 0x4
        public cTotalCost simpleVert; // 0x14

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
        public URA.woDigitYearMax<apLimitGroupName> m_AsyncWorkQueue; // 0x18
        public URA.woDigitYearMax<apLimitGroupName> m_CurrentFrameWork; // 0x20
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