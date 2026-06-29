// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Bindings
// Classes: 26
// Methods: 64

namespace ThirdParty.Unity.UnityEngine.Bindings
{
    public class BindingsAllocator : Object
    {
        // ── Methods ──
        public void Free(){} // RVA: 0x7C27F00
        public void FreeNativeOwnedMemory(){} // RVA: 0x7C27F50
        public void GetNativeOwnedDataPointer(){} // RVA: 0x3174F40
    }

    public class BlittableArrayWrapper : ValueType
    {
        public object data;
        public object size;
        public object updateFlags;

        // ── Methods ──
        public void Unmarshal(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0x7C27FA0
    }

    public class BlittableListWrapper : ValueType
    {
        public object arrayWrapper;
        public object listSize;

        // ── Methods ──
        public void Unmarshal(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0x425D090
    }

    public class ExceptionMarshaller : Object
    {
        public object s_pendingException;

        // ── Methods ──
        public void SetPendingException(){} // RVA: 0x7C27FB0
    }

    public class ExceptionMarshaller[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class FreeFunctionAttribute : NativeMethodAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7DA9870
    }

    public class IgnoreAttribute : Attribute
    {
        public object _doesNotContributeToSize;

        // ── Methods ──
        public void set_DoesNotContributeToSize(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class JobScheduleParameters : Attribute
    {
        public object _name;
        public object _type;

        // ── Methods ──
        public void set_Name(){} // RVA: 0xB44D60
        public void set_Type(){} // RVA: 0x1033F40
        public void .ctor(){} // RVA: 0x2615F10
    }

    public class ManagedSpanWrapper : ValueType
    {
        public object begin;
        public object length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25742E0
    }

    public class NativeAsStructAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NativeConditionalAttribute : Attribute
    {
        public object _condition;
        public object _stubReturnStatement;
        public object _enabled;

        // ── Methods ──
        public void set_Condition(){} // RVA: 0xB44D60
        public void set_StubReturnStatement(){} // RVA: 0xBA9BA0
        public void set_Enabled(){} // RVA: 0xC38370
        public void .ctor(){} // RVA: 0x7DA90A0
    }

    public class NativeHeaderAttribute : Attribute
    {
        public object _header;

        // ── Methods ──
        public void set_Header(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x7DA9150
    }

    public class NativeMethodAttribute : Attribute
    {
        public object _name;
        public object _isThreadSafe;
        public object _isFreeFunction;
        public object _throwsException;
        public object _hasExplicitThis;

        // ── Methods ──
        public void set_Name(){} // RVA: 0xB44D60
        public void set_IsThreadSafe(){} // RVA: 0xB5DD60
        public void set_IsFreeFunction(){} // RVA: 0x17F4D80
        public void set_ThrowsException(){} // RVA: 0x246E8E0
        public void set_HasExplicitThis(){} // RVA: 0x246FE00
        public void .ctor(){} // RVA: 0x7DA95D0
    }

    public class NativeNameAttribute : Attribute
    {
        public object _name;

        // ── Methods ──
        public void set_Name(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x7DA92C0
    }

    public class NativePropertyAttribute : NativeMethodAttribute
    {
        public object _targetType;

        // ── Methods ──
        public void set_TargetType(){} // RVA: 0x1269760
        public void .ctor(){} // RVA: 0x7DA9620
    }

    public class NativeThrowsAttribute : Attribute
    {
        public object _throwsException;

        // ── Methods ──
        public void set_ThrowsException(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xF482F0
    }

    public class NativeTypeAttribute : Attribute
    {
        public object _header;
        public object _intermediateScriptingStructName;
        public object _codegenOptions;

        // ── Methods ──
        public void set_Header(){} // RVA: 0xB44D60
        public void set_IntermediateScriptingStructName(){} // RVA: 0xBA9BA0
        public void set_CodegenOptions(){} // RVA: 0x1269760
        public void .ctor(){} // RVA: 0x7DA97E0
    }

    public class NotNullAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OutStringMarshaller : ValueType
    {
        // ── Methods ──
        public void GetStringAndDispose(){} // RVA: 0x7C28100
    }

    public class PreventReadOnlyInstanceModificationAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StringMarshaller : Object
    {
        // ── Methods ──
        public void TryMarshalEmptyOrNullString(){} // RVA: 0x7C280C0
    }

    public class ThreadSafeAttribute : NativeMethodAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xCABC00
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x7C27E50
        public void ThrowNullReferenceException(){} // RVA: 0x7C27EB0
    }

    public class Unmarshal : ValueType
    {
        // ── Methods ──
        public void UnmarshalUnityObject(){} // RVA: 0x2AFB3D0
        public void FromIntPtrUnsafe(){} // RVA: 0x7C27E10
    }

    public class UnmarshalledAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class VisibleToOtherModulesAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

}