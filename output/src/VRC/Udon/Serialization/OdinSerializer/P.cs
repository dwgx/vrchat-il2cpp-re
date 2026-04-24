// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 4
// Methods: 42

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class PrefabModification : Object
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFD55414520
        public void ApplyValue(){} // RVA: 0x7FFD554145E0
        public void ApplyListLength(){} // RVA: 0x7FFD554148C0
        public void ApplyDictionaryModifications(){} // RVA: 0x7FFD55415520
        public void ReplaceAllReferencesInGraph(){} // RVA: 0x7FFD55415BD0
        public void GetInstanceFromPath(){} // RVA: 0x7FFD55416190
        public void GetInstanceOfStep(){} // RVA: 0x7FFD55416280
        public void SetInstanceToPath(){} // RVA: 0x7FFD554174C0 | overloaded x2
        public void TrySetInstanceOfStep(){} // RVA: 0x7FFD554175C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class PreviouslySerializedAsAttribute : Attribute
    {
        public object Name;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4E35C380
        public void set_Name(){} // RVA: 0x7FFD4E342E30
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class PrimitiveArrayFormatter`1 : MinimalBaseFormatter`1
    {
        public sageKind.ironmentVariable_native _synchronizationContext;
        public ileFullDirectoryInformation<T1717584336> _handler;
        public sageKind.st _invokeHandlers;
        public tTable<T1717584336> ProgressChanged;

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E078E90
        public void Read(){} // RVA: 0x7FFD4E099B30
        public void Write(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class ProperBitConverter : Object
    {
        // ── Methods ──
        public void CreateByteToHexLookup(){} // RVA: 0x7FFD55418BC0
        public void BytesToHexString(){} // RVA: 0x7FFD55418F20
        public void HexStringToBytes(){} // RVA: 0x7FFD55419060
        public void ToInt16(){} // RVA: 0x7FFD55419820
        public void ToUInt16(){} // RVA: 0x7FFD55419820
        public void ToInt32(){} // RVA: 0x7FFD537925F0
        public void ToUInt32(){} // RVA: 0x7FFD537925F0
        public void ToInt64(){} // RVA: 0x7FFD55419870
        public void ToUInt64(){} // RVA: 0x7FFD55419870
        public void ToSingle(){} // RVA: 0x7FFD55419980
        public void ToDouble(){} // RVA: 0x7FFD55419A00
        public void ToDecimal(){} // RVA: 0x7FFD55419AE0
        public void ToGuid(){} // RVA: 0x7FFD55419AE0
        public void GetBytes(){} // RVA: 0x7FFD5541A140 | overloaded x10
        public void .cctor(){} // RVA: 0x7FFD5541A370
    }

}