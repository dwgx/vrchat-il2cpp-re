// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.IO.LowLevel.Unsafe
// Classes: 2
// Methods: 0

namespace ThirdParty.Other.Unity.IO.LowLevel.Unsafe
{
    public class AsyncReadManagerMetricsFilters : Object
    {
        public ulong[] TypeIDs; // 0x10
        public ÏÎÌÎÏÏÌÍÌ.ÎÏ[] States; // 0x18
        public ÏÎÌÎÏÏÌÍÌ.?[] ReadTypes; // 0x20
        public ÏÎÌÎÏÏÌÍÌ.ÍÏÌÏÍÏÎÏ[] PriorityLevels; // 0x28
        public ÏÎÌÎÏÏÌÍÌ.?[] Subsystems; // 0x30
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
        public ÏÎÌÎÏÏÌÍÌ.ÎÏ <State>k__BackingField; // 0x48
        public ÏÎÌÎÏÏÌÍÌ.? <ReadType>k__BackingField; // 0x4C
        public ÏÎÌÎÏÏÌÍÌ.ÍÏÌÏÍÏÎÏ <PriorityLevel>k__BackingField; // 0x50
        public ÏÎÌÎÏÏÌÍÌ.? <Subsystem>k__BackingField; // 0x54
        public double <RequestTimeMicroseconds>k__BackingField; // 0x58
        public double <TimeInQueueMicroseconds>k__BackingField; // 0x60
        public double <TotalTimeMicroseconds>k__BackingField; // 0x68
    }

}