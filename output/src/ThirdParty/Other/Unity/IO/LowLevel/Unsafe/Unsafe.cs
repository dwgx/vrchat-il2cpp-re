// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.IO.LowLevel.Unsafe
// Classes: 2
// Methods: 0

namespace ThirdParty.Other.Unity.IO.LowLevel.Unsafe
{
    public class AsyncReadManagerMetricsFilters : Object
    {
        public ulong[] TypeIDs; // 0x10
        public 0x664D7950[] States; // 0x18
        public 0x664D79A8[] ReadTypes; // 0x20
        public 0x664D78F8[] PriorityLevels; // 0x28
        public 0x664D78A0[] Subsystems; // 0x30
    }

    public class AsyncReadManagerRequestMetric : ValueType
    {
        public string <AssetName>k__BackingField; // 0x10
        public string <FileName>k__BackingField; // 0x18
        public ulong <OffsetBytes>k__BackingField; // 0x20
        public ulong <SizeBytes>k__BackingField; // 0x28
        public ulong <AssetTypeId>k__BackingField; // 0x30
        public ulong <CurrentBytesRead>k__BackingField; // 0x38
        public uint <BatchReadCount>k__BackingField; // 0x40
        public bool <IsBatchRead>k__BackingField; // 0x44
        public 0x664D7950 <State>k__BackingField; // 0x48
        public 0x664D79A8 <ReadType>k__BackingField; // 0x4C
        public 0x664D78F8 <PriorityLevel>k__BackingField; // 0x50
        public 0x664D78A0 <Subsystem>k__BackingField; // 0x54
        public double <RequestTimeMicroseconds>k__BackingField; // 0x58
        public double <TimeInQueueMicroseconds>k__BackingField; // 0x60
        public double <TotalTimeMicroseconds>k__BackingField; // 0x68
    }

}