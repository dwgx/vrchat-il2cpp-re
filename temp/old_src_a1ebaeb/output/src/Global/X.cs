// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 10
// Methods: 6

public class XHashtableState : Object
{
    public object _numEntries; // 0x31531870

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8667cb0
    public void Resize(){} // RVA: 0x7ffaa86491d0
    public void TryGetValue(){}
    public void TryAdd(){} // RVA: 0x7ffaa887e5c0
    public void FindEntry(){} // RVA: 0x7ffaa887e5c0
    public void ComputeHashCode(){} // RVA: 0x7ffaa8652460
}

public class XRBlitParams : ValueType
{
    public object srcRect; // 0x32D51D80
    public object srcHdrEncoded; // 0x32D51D80
    public object 800; // 0x40000B1
    public object 800; // 0x40000B4
}

public class XREarlyUpdate : ValueType
{
}

public class XRFixedUpdate : ValueType
{
}

public class XRMirrorViewBlitDesc : ValueType
{
    public object nativeBlitInvalidStates; // 0x32D51F00
}

public class XRPostLateUpdate : ValueType
{
}

public class XRPostPresent : ValueType
{
}

public class XRPreEndFrame : ValueType
{
}

public class XRRenderPass : ValueType
{
    public object renderTarget; // 0x32D51C00
    public object motionVectorRenderTarget; // 0x32D51C00
    public object cullingPassIndex; // 0x32D51C00
    public object 800; // 0x40000AA
    public object 800; // 0x40000AD
}

public class XRUpdate : ValueType
{
}
