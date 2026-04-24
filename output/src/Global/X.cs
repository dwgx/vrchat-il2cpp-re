// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 10
// Methods: 6

public class XHashtableState : Object
{
    public int[] _buckets;
    public ?<T1717741296>[] _entries;
    public int _numEntries;
    public ToWorldMatrix<T1717741296> _extractKey;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E097970
    public void Resize(){} // RVA: 0x7FFD4E078E90
    public void TryGetValue(){}
    public void TryAdd(){} // RVA: 0x7FFD4E2ADC40
    public void FindEntry(){} // RVA: 0x7FFD4E2ADC40
    public void ComputeHashCode(){} // RVA: 0x7FFD4E082120
}

public class XRBlitParams : ValueType
{
    public Offset srcTex; // 0x10
    public int srcTexArraySlice; // 0x18
    public dRecorder srcRect; // 0x1C
    public dRecorder destRect; // 0x2C
    public UIntPtr foveatedRenderingInfo; // 0x40
    public bool srcHdrEncoded; // 0x48
    public ectInt srcHdrColorGamut; // 0x4C
    public int srcHdrMaxLuminance; // 0x50
}

public class XREarlyUpdate : ValueType
{
}

public class XRFixedUpdate : ValueType
{
}

public class XRMirrorViewBlitDesc : ValueType
{
    public UIntPtr displaySubsystemInstance; // 0x10
    public bool nativeBlitAvailable; // 0x18
    public bool nativeBlitInvalidStates; // 0x19
    public int blitParamsCount; // 0x1C
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
    public UIntPtr displaySubsystemInstance; // 0x10
    public int renderPassIndex; // 0x18
    public ons.get_disableInPlaceEditing renderTarget; // 0x20
    public ode renderTargetDesc; // 0x48
    public bool hasMotionVectorPass; // 0x7C
    public ons.get_disableInPlaceEditing motionVectorRenderTarget; // 0x80
    public ode motionVectorRenderTargetDesc; // 0xA8
    public bool shouldFillOutDepth; // 0xDC
    public int cullingPassIndex; // 0xE0
    public UIntPtr foveatedRenderingInfo; // 0xE8
}

public class XRUpdate : ValueType
{
}
