// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 6
// Methods: 42

namespace ThirdParty.DotNet.System
{
    public class Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD53681650 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Finalize(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD5381AE70
        public void GetType(){} // RVA: 0x7FFD53A73DF0
        public void MemberwiseClone(){} // RVA: 0x7FFD53932B10
        public void ToString(){} // RVA: 0x7FFD5394AC80
        public void ReferenceEquals(){} // RVA: 0x7FFD5072B460
        public void InternalGetHashCode(){} // RVA: 0x7FFD5381AE70
        public void FieldGetter(){} // RVA: 0x7FFD4E341310
        public void FieldSetter(){} // RVA: 0x7FFD4E341310
    }

    public class ObsoleteAttribute : Attribute
    {
        public object Message;
        public object IsError;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F9887E0 | overloaded x3
        public void get_Message(){} // RVA: 0x7FFD4E35C380
        public void get_IsError(){} // RVA: 0x7FFD4E35C4E0
    }

    public class OperationCanceledException : SystemException
    {
        public object CancellationToken;

        // ── Methods ──
        public void get_CancellationToken(){} // RVA: 0x7FFD4E70F640
        public void set_CancellationToken(){} // RVA: 0x7FFD4E96E360
        public void .ctor(){} // RVA: 0x7FFD4F917540 | overloaded x7
    }

    public class OrdinalCaseSensitiveComparer : OrdinalComparer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53A6E720
        public void Compare(){} // RVA: 0x7FFD53902950
        public void Equals(){} // RVA: 0x7FFD539029A0
        public void GetHashCode(){} // RVA: 0x7FFD53A6E770
        public void GetObjectData(){} // RVA: 0x7FFD53A6E7A0
    }

    public class OrdinalComparer : StringComparer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53A6E2E0
        public void Compare(){} // RVA: 0x7FFD53A6E340
        public void Equals(){} // RVA: 0x7FFD53A6E620 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53A6E6C0 | overloaded x2
    }

    public class OrdinalIgnoreCaseComparer : OrdinalComparer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53A6E8A0
        public void Compare(){} // RVA: 0x7FFD53A6E8F0
        public void Equals(){} // RVA: 0x7FFD53A6E9E0
        public void GetHashCode(){} // RVA: 0x7FFD53A6EAB0
        public void GetObjectData(){} // RVA: 0x7FFD53A6EB10
    }

}