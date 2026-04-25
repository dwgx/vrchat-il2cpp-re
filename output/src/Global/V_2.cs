// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 6
// Methods: 4

public class VolatileInt32 : ValueType
{
    public int Value; // 0x10
}

public class VolatileIntPtr : ValueType
{
    public UIntPtr Value; // 0x10
}

public class VolatileObject : ValueType
{
    public object Value; // 0x10
}

public class VrcDataElement : Object
{
    public string name; // 0x10
    public 0x6B251488 mirror; // 0x18
    public 0x6B2514E0 type; // 0x1C
    public UnityEngine.MonoBehaviour serializeComponent; // 0x20
    public bool valueBool; // 0x28
    public int valueInt; // 0x2C
    public float valueFloat; // 0x30
    public string valueString; // 0x38
    public byte[] valueSerializedBytes; // 0x40
    public bool modified; // 0x48
    public bool added; // 0x49
    public VRC.SDKBase.VRC_DataStorage dataStorage; // 0x50

    // ── Methods ──
    public void Serialize(){} // RVA: 0x7FFAC2E8DC40
    public void Deserialize(){} // RVA: 0x7FFAC2C59F60
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class VrcEvent : Object
{
    public string Name; // 0x10
    public 0x6B2517A0 EventType; // 0x18
    public string ParameterString; // 0x20
    public 0x6B2518A8 ParameterBoolOp; // 0x28
    public bool ParameterBool; // 0x2C
    public float ParameterFloat; // 0x30
    public int ParameterInt; // 0x34
    public UnityEngine.GameObject ParameterObject; // 0x38
    public UnityEngine.GameObject[] ParameterObjects; // 0x40
    public byte[] ParameterBytes; // 0x48
    public System.Nullable`1<int> ParameterBytesVersion; // 0x50
    public bool TakeOwnershipOfTarget; // 0x58

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACC0771D0
}

public class v
{
}
