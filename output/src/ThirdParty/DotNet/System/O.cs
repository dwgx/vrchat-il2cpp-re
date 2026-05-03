// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 11
// Methods: 64

namespace ThirdParty.DotNet.System
{
    public class Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE8660AF70 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Finalize(){} // RVA: 0x7FFE810FB310
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void GetType(){} // RVA: 0x7FFE869FD5E0
        public void MemberwiseClone(){} // RVA: 0x7FFE868BC310
        public void ToString(){} // RVA: 0x7FFE868D44B0
        public void ReferenceEquals(){} // RVA: 0x7FFE835C1CA0
        public void InternalGetHashCode(){} // RVA: 0x7FFE867A47B0
        public void FieldGetter(){} // RVA: 0x7FFE810FB310
        public void FieldSetter(){} // RVA: 0x7FFE810FB310
    }

    public class ObjectDisposedException : InvalidOperationException
    {
        public string _objectName; // 0x90
        public object field_1; // 0xA8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869EE1B0 | overloaded x4
        public void GetObjectData(){} // RVA: 0x7FFE869EE2C0
        public void get_Message(){} // RVA: 0x7FFE869EE4C0
        public void get_ObjectName(){} // RVA: 0x7FFE869EE590
    }

    public class ObsoleteAttribute : Attribute
    {
        public string _message; // 0x10
        public bool _error; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828378F0 | overloaded x3
        public void get_Message(){} // RVA: 0x7FFE81116380
        public void get_IsError(){} // RVA: 0x7FFE811164E0
    }

    public class Obsoletions : Object
    {
    }

    public class OperatingSystem : Object
    {
        public System.Version _version; // 0x10
        public 0x664BD2D4 _platform; // 0x18
        public string _servicePack; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A095B0 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFE86A09700
        public void get_Platform(){} // RVA: 0x7FFE813DB630
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void Clone(){} // RVA: 0x7FFE86A09740
        public void ToString(){} // RVA: 0x7FFE86A097D0
        public void get_VersionString(){} // RVA: 0x7FFE86A097E0
    }

    public class OperationCanceledException : SystemException
    {
        public System.Threading.CancellationToken _cancellationToken; // 0x90

        // ── Methods ──
        public void get_CancellationToken(){} // RVA: 0x7FFE8154EB60
        public void set_CancellationToken(){} // RVA: 0x7FFE818CE320
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x7
    }

    public class OrdinalCaseSensitiveComparer : OrdinalComparer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869F7F10
        public void Compare(){} // RVA: 0x7FFE8688C180
        public void Equals(){} // RVA: 0x7FFE8688C1D0
        public void GetHashCode(){} // RVA: 0x7FFE869F7F60
        public void GetObjectData(){} // RVA: 0x7FFE869F7F90
    }

    public class OrdinalComparer : StringComparer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869F7AD0
        public void Compare(){} // RVA: 0x7FFE869F7B30
        public void Equals(){} // RVA: 0x7FFE869F7E10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE869F7EB0 | overloaded x2
    }

    public class OrdinalIgnoreCaseComparer : OrdinalComparer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869F8090
        public void Compare(){} // RVA: 0x7FFE869F80E0
        public void Equals(){} // RVA: 0x7FFE869F81D0
        public void GetHashCode(){} // RVA: 0x7FFE869F82A0
        public void GetObjectData(){} // RVA: 0x7FFE869F8300
    }

    public class OutOfMemoryException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class OverflowException : ArithmeticException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x4
    }

}