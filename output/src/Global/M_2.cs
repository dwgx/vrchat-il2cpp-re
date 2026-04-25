// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 18
// Methods: 46

public class MulOvfUInt32 : MulOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE12D0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class MulOvfUInt64 : MulOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE14A0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class MulSingle : MulInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE0430
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class MulUInt16 : MulInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE0030
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class MulUInt32 : MulInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE0190
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class MulUInt64 : MulInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE02E0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Multiplier : Object
{
    public 0x6B1C0D28 curve; // 0x10
    public float multiplier; // 0x14
    public 0x6B1C0D28 result; // 0x18

    // ── Methods ──
    public void GetValue(){} // RVA: 0x7FFAC3077390
    public void .ctor(){} // RVA: 0x7FFAC2FE07F0
}

public class MuscleDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class MuscleProps : ValueType
{
    public float unpinParents; // 0x10
    public float unpinChildren; // 0x14
    public float unpinGroup; // 0x18
    public float minMappingWeight; // 0x1C
    public float maxMappingWeight; // 0x20
    public float minPinWeight; // 0x24
    public bool disableColliders; // 0x28
    public float regainPinSpeed; // 0x2C
    public float collisionResistance; // 0x30
    public float knockOutDistance; // 0x34
    public UnityEngine.PhysicMaterial puppetMaterial; // 0x38
    public UnityEngine.PhysicMaterial unpinnedMaterial; // 0x40
}

public class MusclePropsGroup : ValueType
{
    public string name; // 0x10
    public 0x6B1BDBA8[] groups; // 0x18
    public MuscleProps props; // 0x20
}

public class MutableBox : InitializeLocalInstruction
{
    public System.Type InstructionName; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC47EB5F0
    public void Run(){} // RVA: 0x7FFAC8DDD4D0
    public void get_InstructionName(){} // RVA: 0x7FFAC8DDD610
}

public class MutableValue : InitializeLocalInstruction
{
    public System.Type InstructionName; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC47EB5F0
    public void Run(){} // RVA: 0x7FFAC8DDD330
    public void BoxIfIndexMatches(){} // RVA: 0x7FFAC8DDD3E0
    public void get_InstructionName(){} // RVA: 0x7FFAC8DDD490
}

public class MutationInput : ValueType
{
    public System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<U,T>> Root;
    public Comparers<U,T> Comparers;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void get_Root(){} // RVA: 0x7FFAC2C58E90
    public void get_Comparers(){} // RVA: 0x7FFAC2C58E90
    public void get_KeyComparer(){} // RVA: 0x7FFAC2C58E90
    public void get_ValueComparer(){} // RVA: 0x7FFAC2C58E90
}

public class MutationResult : ValueType
{
    public System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<U,T>> Root;
    public int CountAdjustment;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C77970
    public void get_Root(){} // RVA: 0x7FFAC2C58E90
    public void get_CountAdjustment(){} // RVA: 0x7FFAC2C59960
    public void Finalize(){} // RVA: 0x7FFAC2C58F40
}

public class MutexAcquired : ValueType
{
    public System.Threading.Mutex mutex; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACC0EE0A0
    public void Dispose(){} // RVA: 0x7FFACC0EE200
}

public class MyAction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
}

public class MyIntersectNodeSort : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFAC485CBA0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class mincore : Object
{
    // ── Methods ──
    public void GetProcessHeap(){} // RVA: 0x7FFAC838B920
    public void HeapAlloc(){} // RVA: 0x7FFAC838B990
    public void CreateThreadpoolIo(){} // RVA: 0x7FFAC838BA30
    public void CloseThreadpoolIo(){} // RVA: 0x7FFAC838BBA0
    public void StartThreadpoolIo(){} // RVA: 0x7FFAC838BC20
    public void CancelThreadpoolIo(){} // RVA: 0x7FFAC838BCE0
}
