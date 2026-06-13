// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Pool
// Classes: 55
// Methods: 660

namespace VRC.Core.Pool
{
    public class ObjectPool`1
    {
        public object syncLock;
        public System.Collections.Generic.Stack`1<T> Pool;
        public int LowWaterMark;
        public System.Func`1<T> CreateFunc;

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x283FA0
        public void get_CountActive(){} // RVA: 0xD840
        public void set_CountActive(){} // RVA: 0x24FA0
        public void get_CountInactive(){} // RVA: 0xD840
        public void get_CountAll(){} // RVA: 0xD840
        public void Clear(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x24A50
        public void Get(){} // RVA: 0x283FA0 | overloaded x2
        public void Release(){} // RVA: 0x283FA0
        public void Cleanup(){} // RVA: 0xD840
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.LowLevel.PlayerLoopSystem>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.LowLevel.PlayerLoopSystem>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.Component>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.Component>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.Dictionary`2<UnityEngine.Material,bool>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.Dictionary`2<UnityEngine.Material,bool>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.Dictionary`2<UnityEngine.Material,UnityEngine.Material>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.Dictionary`2<UnityEngine.Material,UnityEngine.Material>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.Transform>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.Transform>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.Dictionary`2<System.ReadOnlyMemory`1<char>,string>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.Dictionary`2<System.ReadOnlyMemory`1<char>,string>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<Token>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<Token>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<string>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<string>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<ObjectEnumerator> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<ObjectEnumerator> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Text.StringBuilder> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Text.StringBuilder> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.AudioSource>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.AudioSource>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<VRC.SDKBase.VRC_SceneDescriptor>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<VRC.SDKBase.VRC_SceneDescriptor>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.ParticleSystemRenderer>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.ParticleSystemRenderer>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.UI.Graphic>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.UI.Graphic>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<VRC.Udon.UdonBehaviour>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<VRC.Udon.UdonBehaviour>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<VRC.Dynamics.VRCPhysBoneBase>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<VRC.Dynamics.VRCPhysBoneBase>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<VRC.Dynamics.VRCConstraintBase>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<VRC.Dynamics.VRCConstraintBase>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<VRC.Dynamics.VRCPhysBoneColliderBase>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<VRC.Dynamics.VRCPhysBoneColliderBase>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<VRC.Dynamics.ContactBase>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<VRC.Dynamics.ContactBase>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.Camera>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.Camera>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<VRC.SDKBase.VRC_SpecialLayer>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<VRC.SDKBase.VRC_SpecialLayer>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<TMPro.TMP_InputField>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<TMPro.TMP_InputField>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<VRC.SDK3.Components.VRCUrlInputField>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<VRC.SDK3.Components.VRCUrlInputField>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.Light>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.Light>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.ParticleSystem>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.ParticleSystem>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<VRC.SDKBase.VRC_StereoObject>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<VRC.SDKBase.VRC_StereoObject>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.UI.InputField>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.UI.InputField>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.Canvas>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.Canvas>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<ÏÎÌÌÌÌÏÌÍÎÌÌÏÎÍÎÍÏÎÌÎÌÌ>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<ÏÎÌÌÌÌÏÌÍÎÌÌÏÎÍÎÍÏÎÌÎÌÌ>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<System.ValueTuple`2<ÏÎÌÌÌÌÏÌÍÎÌÌÏÎÍÎÍÏÎÌÎÌÌ,bool>>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<System.ValueTuple`2<ÏÎÌÌÌÌÏÌÍÎÌÌÏÎÍÎÍÏÎÌÎÌÌ,bool>>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<VRC.Core.Networking.INetworkReadyReceiver>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<VRC.Core.Networking.INetworkReadyReceiver>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.Renderer>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.Renderer>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.Rigidbody>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.Rigidbody>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<VRC.Dynamics.IParameterSetup>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<VRC.Dynamics.IParameterSetup>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.MeshRenderer>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.MeshRenderer>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.SkinnedMeshRenderer>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.SkinnedMeshRenderer>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<int>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<int>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<ÏÍÎÎÎÌÏÌÌÏÎÍÍÏÌÎÎÏÍÏÌÍÏ>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.HashSet`1<ÏÍÎÎÎÌÏÌÌÏÎÍÍÏÌÎÎÏÍÏÌÍÏ>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.Material>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.Material>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.Animations.IConstraint>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.Animations.IConstraint>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<ÌÏÏÍÍÌÎÏÎÎÎÌÌÍÌÏÌÍÌÍÌÏÌ>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<ÌÏÏÍÍÌÎÏÎÎÎÌÌÍÌÏÌÍÌÍÌÏÌ>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<UnityEngine.Mesh>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.HashSet`1<UnityEngine.Mesh>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.MeshFilter>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.MeshFilter>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<ÎÎÏÍÏÏÏÍÎÌÍÎÍÏÎÍÏÍÎÌÏÏÌ>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<ÎÎÏÍÏÏÏÍÎÌÍÎÍÏÎÍÏÍÎÌÏÏÌ>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.Collider>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.Collider>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<ÏÍÌÌÏÎÍÏÏÎÍÍÌÏÌÏÎÎÎÌÎÎÏ>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<ÏÍÌÌÏÎÍÏÏÎÍÍÌÏÌÏÎÎÎÌÎÎÏ>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<int>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.HashSet`1<int>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<Cysharp.Threading.Tasks.UniTask>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<Cysharp.Threading.Tasks.UniTask>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<ÌÍÌÌÎÎÌÏÌÍÎÎÎÏÏÏÌÎÏÌÍÌÎ>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<ÌÍÌÌÎÎÌÏÌÍÎÎÎÏÏÏÌÎÏÌÍÌÎ>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<Cysharp.Threading.Tasks.UniTask`1<bool>>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<Cysharp.Threading.Tasks.UniTask`1<bool>>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.Dictionary`2<ÌÍÌÌÎÎÌÏÌÍÎÎÎÏÏÏÌÎÏÌÍÌÎ,ÍÌÌÍÎÏÍÎÏÌÏÏÍÏÎÍÏÏÎÏÎÌÎ>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.Dictionary`2<ÌÍÌÌÎÎÌÏÌÍÎÎÎÏÏÏÌÎÏÌÍÌÎ,ÍÌÌÍÎÏÍÎÏÌÏÏÍÏÎÍÏÏÎÏÎÌÎ>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<VRC.SDKBase.INetworkID>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<VRC.SDKBase.INetworkID>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<UnityEngine.Transform>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.HashSet`1<UnityEngine.Transform>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

    public class ObjectPool`1
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<VRC.SDK3.Dynamics.PhysBone.Components.VRCPhysBone>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<VRC.SDK3.Dynamics.PhysBone.Components.VRCPhysBone>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x3D93250
        public void .ctor(){} // RVA: 0x3D93300
        public void get_CountActive(){} // RVA: 0x59C540
        public void set_CountActive(){} // RVA: 0x65F570
        public void get_CountInactive(){} // RVA: 0x33B7190
        public void get_CountAll(){} // RVA: 0x3D93630
        public void Clear(){} // RVA: 0x3D93650
        public void Dispose(){} // RVA: 0x3D93840
        public void Get(){} // RVA: 0x3D93AD0 | overloaded x2
        public void Release(){} // RVA: 0x3D93B90
        public void Cleanup(){} // RVA: 0x3D93EB0
    }

}