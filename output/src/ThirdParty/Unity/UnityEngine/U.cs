// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 13
// Methods: 44

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

    public class UINumericFieldsUtils : Object
    {
        public string k_AllowedCharactersForFloat;
        public string k_AllowedCharactersForInt; // 0x8
        public string k_DoubleFieldFormatString; // 0x10
        public string k_FloatFieldFormatString; // 0x18
        public string k_IntFieldFormatString; // 0x20

        // ── Methods ──
        public void TryConvertStringToDouble(){} // RVA: 0x7FFAC98CD010 | overloaded x2
        public void TryConvertStringToFloat(){} // RVA: 0x7FFAC98CD190
        public void TryConvertStringToLong(){} // RVA: 0x7FFAC98CD300 | overloaded x2
        public void TryConvertStringToULong(){} // RVA: 0x7FFAC98CD5A0 | overloaded x2
        public void TryConvertStringToInt(){} // RVA: 0x7FFAC98CD7B0
        public void TryConvertStringToUInt(){} // RVA: 0x7FFAC98CD860
        public void .cctor(){} // RVA: 0x7FFAC98CD910
    }

    public class UISystemProfilerApi : Object
    {
        // ── Methods ──
        public void BeginSample(){} // RVA: 0x7FFAC9C39080
        public void EndSample(){} // RVA: 0x7FFAC9C390D0
        public void AddMarker(){} // RVA: 0x7FFAC9C39120
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
        public void .cctor(){} // RVA: 0x7FFAC9A4B4F0
    }

    public class UnassignedReferenceException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98C48D0 | overloaded x2
    }

    public class UnhandledExceptionHandler : Object
    {
        // ── Methods ──
        public void RegisterUECatcher(){} // RVA: 0x7FFAC98C5840
    }

    public class UnityAPICompatibilityVersionAttribute : Attribute
    {
        public string _version; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98C5B20 | overloaded x2
    }

    public class UnityEngineModuleAssembly : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UnityException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98C47E0 | overloaded x3
    }

    public class UnityLogWriter : TextWriter
    {
        public object Encoding;

        // ── Methods ──
        public void WriteStringToUnityLog(){} // RVA: 0x7FFAC98A80A0
        public void WriteStringToUnityLogImpl(){} // RVA: 0x7FFAC98A8100
        public void Init(){} // RVA: 0x7FFAC98A8150
        public void get_Encoding(){} // RVA: 0x7FFAC98A8200
        public void Write(){} // RVA: 0x7FFAC98A8350 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAC98A83C0
    }

    public class UnityString : Object
    {
        // ── Methods ──
        public void Format(){} // RVA: 0x7FFAC99EDD30
    }

    public class UnitySynchronizationContext : SynchronizationContext
    {
        public System.Collections.Generic.List`1<WorkRequest> m_AsyncWorkQueue; // 0x18
        public System.Collections.Generic.List`1<WorkRequest> m_CurrentFrameWork; // 0x20
        public int m_MainThreadID; // 0x28
        public int m_TrackedCount; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98C7F40 | overloaded x2
        public void Send(){} // RVA: 0x7FFAC98C8100
        public void OperationStarted(){} // RVA: 0x7FFAC98C8450
        public void OperationCompleted(){} // RVA: 0x7FFAC98C8460
        public void Post(){} // RVA: 0x7FFAC98C8470
        public void CreateCopy(){} // RVA: 0x7FFAC98C8660
        public void Exec(){} // RVA: 0x7FFAC98C8850
        public void HasPendingTasks(){} // RVA: 0x7FFAC98C8C00
        public void InitializeSynchronizationContext(){} // RVA: 0x7FFAC98C8C60
        public void ExecuteTasks(){} // RVA: 0x7FFAC98C8D20
        public void ExecutePendingTasks(){} // RVA: 0x7FFAC98C8D80
    }

}