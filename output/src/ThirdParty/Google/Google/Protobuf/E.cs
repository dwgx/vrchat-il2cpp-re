// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 6
// Methods: 51

namespace ThirdParty.Google.Google.Protobuf
{
    public class Extension
    {
        public int <FieldNumber>k__BackingField; // 0x10

        // ── Methods ──
        public void get_TargetType(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2E00C0
        public void CreateValue(){} // RVA: 0xCD60
        public void get_FieldNumber(){} // RVA: 0x32A5C0
        public void get_IsRepeated(){} // RVA: 0xDBE0
    }

    public class ExtensionRegistry
    {
        public System.Collections.Generic.IDictionary`2<Google.Protobuf.ObjectIntPair`1<System.Type>,Google.Protobuf.Extension> extensions; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A210E0 | overloaded x2
        public void get_Count(){} // RVA: 0x5A21550
        public void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void ContainsInputField(){} // RVA: 0x5A215A0
        public void Add(){} // RVA: 0x5A21710
        public void AddRange(){} // RVA: 0x5A21880
        public void Clear(){} // RVA: 0x5A21AA0
        public void Contains(){} // RVA: 0x5A21AF0
        public void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.CopyTo(){} // RVA: 0x5A21CD0
        public void GetEnumerator(){} // RVA: 0x5A21FF0
        public void Remove(){} // RVA: 0x5A22070
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5A21FF0
        public void Clone(){} // RVA: 0x5A22250
    }

    public class ExtensionSet
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x114C0
        public void Get(){} // RVA: 0xCEC0 | overloaded x2
        public void GetOrInitialize(){} // RVA: 0xCEC0
        public void Set(){} // RVA: 0x283FA0
        public void Has(){} // RVA: 0xE230
        public void Clear(){} // RVA: 0x24D50 | overloaded x2
        public void TryMergeFieldFrom(){} // RVA: 0xE230
        public void MergeFrom(){} // RVA: 0x24D50
        public void Clone(){} // RVA: 0xCE50
    }

    public class ExtensionSet`1
    {
        public System.Collections.Generic.Dictionary`2<int,Google.Protobuf.IExtensionValue> <ValuesByNumber>k__BackingField;

        // ── Methods ──
        public void get_ValuesByNumber(){} // RVA: 0xCD60
        public void GetHashCode(){} // RVA: 0xD840
        public void Equals(){} // RVA: 0xDE40
        public void CalculateSize(){} // RVA: 0xD840
        public void WriteTo(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x24A50
    }

    public class ExtensionValue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void CalculateSize(){} // RVA: 0xD840
        public void Clone(){} // RVA: 0xCD60
        public void Equals(){} // RVA: 0xDE40
        public void GetHashCode(){} // RVA: 0xD840
        public void MergeFrom(){} // RVA: 0x24B10 | overloaded x2
        public void WriteTo(){} // RVA: 0x24B10
        public void GetValue(){} // RVA: 0x283FA0
        public void SetValue(){} // RVA: 0x283FA0
    }

    public class Extension`2
    {
        public Google.Protobuf.FieldCodec`1<T> codec;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x26C40
        public void get_DefaultValue(){} // RVA: 0x283FA0
        public void get_TargetType(){} // RVA: 0xCD60
        public void get_IsRepeated(){} // RVA: 0xDBE0
        public void CreateValue(){} // RVA: 0xCD60
    }

}