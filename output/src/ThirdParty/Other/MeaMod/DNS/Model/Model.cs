// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Model
// Classes: 5
// Methods: 32

namespace ThirdParty.Other.MeaMod.DNS.Model
{
    public class DnsObject : Object
    {
        public DependencyInjector CreationTime; // 0x10

        // ── Methods ──
        public void get_CreationTime(){} // RVA: 0x7FFD4E35C380
        public void set_CreationTime(){} // RVA: 0x7FFD4F83EFB0
        public void Length(){} // RVA: 0x7FFD5366F750
        public void Clone(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Read(){} // RVA: 0x7FFD4E078F40 | overloaded x4
        public void ToByteArray(){} // RVA: 0x7FFD5366FC10
        public void Write(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD5366FDA0
    }

    public class EdnsOptionRegistry : Object
    {
        public URA.DateTime<rbitalXMultiplier.ed,ormation<rbitalXMultiplier.njected>> Options;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD53672970
        public void Register(){} // RVA: 0x7FFD4E0909B0
    }

    public class ResourceRegistry : Object
    {
        public URA.DateTime<rbitalXMultiplier.ffsetY,ormation<rbitalXMultiplier.engthY>> Records;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD536821A0
        public void Register(){} // RVA: 0x7FFD4E0909B0
        public void Create(){} // RVA: 0x7FFD53682510
    }

    public class UpdatePrerequisiteList : List`1
    {
        // ── Methods ──
        public void MustExist(){} // RVA: 0x7FFD536840D0 | overloaded x4
        public void MustNotExist(){} // RVA: 0x7FFD4E078F40 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFD536842C0
    }

    public class UpdateResourceList : List`1
    {
        // ── Methods ──
        public void AddResource(){} // RVA: 0x7FFD53684330
        public void DeleteResource(){} // RVA: 0x7FFD4E078F40 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFD53684680
    }

}