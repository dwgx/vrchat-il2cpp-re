// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 10
// Methods: 42

namespace ThirdParty.Google.Google.Protobuf
{
    public class FieldCodec
    {
        // ── Methods ──
        public void ForString(){} // RVA: 0x5A227A0 | overloaded x2
        public void ForInt32(){} // RVA: 0x5A22AA0 | overloaded x2
        public void ForUInt32(){} // RVA: 0x5A22F20 | overloaded x2
        public void ForFloat(){} // RVA: 0x5A233A0 | overloaded x2
        public void ForMessage(){} // RVA: 0x283FA0
    }

    public class FieldCodec`1
    {
        public System.Collections.Generic.EqualityComparer`1<T> EqualityComparer;
        public T DefaultDefault;
        public bool TypeSupportsPacking;
        public bool <PackedRepeatedField>k__BackingField;
        public Google.Protobuf.ValueWriter`1<T> <ValueWriter>k__BackingField;
        public System.Func`2<T,int> <ValueSizeCalculator>k__BackingField;
        public Google.Protobuf.ValueReader`1<T> <ValueReader>k__BackingField;
        public InputMerger<T> <ValueMerger>k__BackingField;
        public ValuesMerger<T> <FieldMerger>k__BackingField;
        public int <FixedSize>k__BackingField;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x24A80
        public void IsPackedRepeatedField(){} // RVA: 0xE680
        public void get_PackedRepeatedField(){} // RVA: 0xDBE0
        public void get_ValueWriter(){} // RVA: 0xCD60
        public void get_ValueSizeCalculator(){} // RVA: 0xCD60
        public void get_ValueReader(){} // RVA: 0xCD60
        public void get_ValueMerger(){} // RVA: 0xCD60
        public void get_FieldMerger(){} // RVA: 0xCD60
        public void get_FixedSize(){} // RVA: 0xD840
        public void get_Tag(){} // RVA: 0xD840
        public void get_EndTag(){} // RVA: 0xD840
        public void get_DefaultValue(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x4
        public void WriteTagAndValue(){} // RVA: 0x283FA0
        public void Read(){} // RVA: 0x283FA0 | overloaded x2
        public void CalculateSizeWithTag(){} // RVA: 0x283FA0
        public void CalculateUnconditionalSizeWithTag(){} // RVA: 0x283FA0
        public void IsDefault(){} // RVA: 0x283FA0
    }

    public class FieldCodec`1
    {
        public System.Collections.Generic.EqualityComparer`1<string> EqualityComparer;
        public string DefaultDefault; // 0x8
        public bool TypeSupportsPacking; // 0x10
        public bool <PackedRepeatedField>k__BackingField; // 0x10
        public Google.Protobuf.ValueWriter`1<string> <ValueWriter>k__BackingField; // 0x18
        public System.Func`2<string,int> <ValueSizeCalculator>k__BackingField; // 0x20
        public Google.Protobuf.ValueReader`1<string> <ValueReader>k__BackingField; // 0x28
        public InputMerger<string> <ValueMerger>k__BackingField; // 0x30
        public ValuesMerger<string> <FieldMerger>k__BackingField; // 0x38
        public int <FixedSize>k__BackingField; // 0x40
    }

    public class FieldCodec`1
    {
        public System.Collections.Generic.EqualityComparer`1<int> EqualityComparer;
        public int DefaultDefault; // 0x8
        public bool TypeSupportsPacking; // 0xC
        public bool <PackedRepeatedField>k__BackingField; // 0x10
        public Google.Protobuf.ValueWriter`1<int> <ValueWriter>k__BackingField; // 0x18
        public System.Func`2<int,int> <ValueSizeCalculator>k__BackingField; // 0x20
        public Google.Protobuf.ValueReader`1<int> <ValueReader>k__BackingField; // 0x28
        public InputMerger<int> <ValueMerger>k__BackingField; // 0x30
        public ValuesMerger<int> <FieldMerger>k__BackingField; // 0x38
        public int <FixedSize>k__BackingField; // 0x40
    }

    public class FieldCodec`1
    {
        public System.Collections.Generic.EqualityComparer`1<float> EqualityComparer;
        public float DefaultDefault; // 0x8
        public bool TypeSupportsPacking; // 0xC
        public bool <PackedRepeatedField>k__BackingField; // 0x10
        public Google.Protobuf.ValueWriter`1<float> <ValueWriter>k__BackingField; // 0x18
        public System.Func`2<float,int> <ValueSizeCalculator>k__BackingField; // 0x20
        public Google.Protobuf.ValueReader`1<float> <ValueReader>k__BackingField; // 0x28
        public InputMerger<float> <ValueMerger>k__BackingField; // 0x30
        public ValuesMerger<float> <FieldMerger>k__BackingField; // 0x38
        public int <FixedSize>k__BackingField; // 0x40
    }

    public class FieldCodec`1
    {
        public System.Collections.Generic.EqualityComparer`1<Interval> EqualityComparer;
        public Interval DefaultDefault; // 0x8
        public bool TypeSupportsPacking; // 0x10
        public bool <PackedRepeatedField>k__BackingField; // 0x10
        public Google.Protobuf.ValueWriter`1<Interval> <ValueWriter>k__BackingField; // 0x18
        public System.Func`2<Interval,int> <ValueSizeCalculator>k__BackingField; // 0x20
        public Google.Protobuf.ValueReader`1<Interval> <ValueReader>k__BackingField; // 0x28
        public InputMerger<Interval> <ValueMerger>k__BackingField; // 0x30
        public ValuesMerger<Interval> <FieldMerger>k__BackingField; // 0x38
        public int <FixedSize>k__BackingField; // 0x40
    }

    public class FieldCodec`1
    {
        public System.Collections.Generic.EqualityComparer`1<RelativeKeypoint> EqualityComparer;
        public RelativeKeypoint DefaultDefault; // 0x8
        public bool TypeSupportsPacking; // 0x10
        public bool <PackedRepeatedField>k__BackingField; // 0x10
        public Google.Protobuf.ValueWriter`1<RelativeKeypoint> <ValueWriter>k__BackingField; // 0x18
        public System.Func`2<RelativeKeypoint,int> <ValueSizeCalculator>k__BackingField; // 0x20
        public Google.Protobuf.ValueReader`1<RelativeKeypoint> <ValueReader>k__BackingField; // 0x28
        public InputMerger<RelativeKeypoint> <ValueMerger>k__BackingField; // 0x30
        public ValuesMerger<RelativeKeypoint> <FieldMerger>k__BackingField; // 0x38
        public int <FixedSize>k__BackingField; // 0x40
    }

    public class FieldCodec`1
    {
        public System.Collections.Generic.EqualityComparer`1<AssociatedDetection> EqualityComparer;
        public AssociatedDetection DefaultDefault; // 0x8
        public bool TypeSupportsPacking; // 0x10
        public bool <PackedRepeatedField>k__BackingField; // 0x10
        public Google.Protobuf.ValueWriter`1<AssociatedDetection> <ValueWriter>k__BackingField; // 0x18
        public System.Func`2<AssociatedDetection,int> <ValueSizeCalculator>k__BackingField; // 0x20
        public Google.Protobuf.ValueReader`1<AssociatedDetection> <ValueReader>k__BackingField; // 0x28
        public InputMerger<AssociatedDetection> <ValueMerger>k__BackingField; // 0x30
        public ValuesMerger<AssociatedDetection> <FieldMerger>k__BackingField; // 0x38
        public int <FixedSize>k__BackingField; // 0x40
    }

    public class FieldMaskTree
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A23A90 | overloaded x2
        public void ToString(){} // RVA: 0x5A23B50
        public void AddFieldPath(){} // RVA: 0x5A23B90
        public void MergeFromFieldMask(){} // RVA: 0x5A23E20
        public void ToFieldMask(){} // RVA: 0x5A24000
        public void GetFieldPaths(){} // RVA: 0x5A24130
        public void IntersectFieldPath(){} // RVA: 0x5A243E0
        public void Merge(){} // RVA: 0x5A24900 | overloaded x2
    }

    public class FrameworkPortability
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5A25460
    }

}