// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Collections
// Classes: 69
// Methods: 358

namespace ThirdParty.Other.Unity.Collections
{
    public class AllocatorManager : Object
    {
        public ield Invalid;
        public ield None; // 0x4
        public ield Temp; // 0x8
        public ield TempJob; // 0xC
        public ield Persistent; // 0x10
        public ield AudioKernel; // 0x14
        public ushort NumGlobalScratchAllocators; // 0x18
        public ushort MaxNumGlobalAllocators; // 0x1A
        public uint GlobalAllocatorBaseIndex; // 0x1C
        public uint FirstGlobalScratchpadAllocatorIndex; // 0x20

        // ── Methods ──
        public void AllocateBlock(){} // RVA: 0x7FFD4E2ADC40
        public void Allocate(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void AllocateStruct(){} // RVA: 0x7FFD4E2ADC40
        public void FreeBlock(){} // RVA: 0x7FFD4E090C80
        public void Free(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void CheckDelegate(){} // RVA: 0x7FFD53201980
        public void UseDelegate(){} // RVA: 0x7FFD5492E690
        public void allocate_block(){} // RVA: 0x7FFD5492E6E0
        public void forward_mono_allocate_block(){} // RVA: 0x7FFD5492E780
        public void LegacyOf(){} // RVA: 0x7FFD5492E8A0
        public void TryLegacy(){} // RVA: 0x7FFD5492E8B0
        public void Try(){} // RVA: 0x7FFD5492EA50
        public void IsCustomAllocator(){} // RVA: 0x7FFD5492EDC0
        public void .cctor(){} // RVA: 0x7FFD5492EDD0
        public void Initialize$StackAllocator_Try_000000AB$BurstDirectCall(){} // RVA: 0x7FFD5492EF90
        public void Initialize$SlabAllocator_Try_000000B9$BurstDirectCall(){} // RVA: 0x7FFD5492EFE0
    }

    public class ArrayOfArrays`1 : ValueType
    {
        public ield BlockSizeInElements; // 0x10
        public int BlockSizeInBytes; // 0x14
        public int BlockMask; // 0x18
        public int Length; // 0x1C
        public int Item; // 0x20
        public IntPtr m_block; // 0x28

        // ── Methods ──
        public void get_BlockSizeInElements(){} // RVA: 0x7FFD4E079960
        public void get_BlockSizeInBytes(){} // RVA: 0x7FFD4E079960
        public void get_BlockMask(){} // RVA: 0x7FFD4E079960
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void LockfreeAdd(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E087DE0
        public void Rewind(){} // RVA: 0x7FFD4E090980
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void RemoveAtSwapBack(){} // RVA: 0x7FFD4E090ED0
        public void BlockIndexOfElement(){} // RVA: 0x7FFD4E0800D0
        public void TrimExcess(){} // RVA: 0x7FFD4E090980
    }

    public class AutoFreeAllocator : ValueType
    {
        public ÍÎÏÎÎ.kingField<UIntPtr> Handle; // 0x10
        public ÍÎÏÎÎ.kingField<UIntPtr> m_tofree; // 0x30
        public ield m_handle; // 0x50
        public ield m_backingAllocatorHandle; // 0x54

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFD54930620
        public void FreeAll(){} // RVA: 0x7FFD54930780
        public void Dispose(){} // RVA: 0x7FFD549308D0
        public void Try(){} // RVA: 0x7FFD54930A20 | overloaded x2
        public void get_Handle(){} // RVA: 0x7FFD4E3E2080
        public void Try$BurstManaged(){} // RVA: 0x7FFD54930A80
    }

    public class CollectionHelper : Object
    {
        // ── Methods ──
        public void Align(){} // RVA: 0x7FFD54931010
        public void Hash(){} // RVA: 0x7FFD54931030
        public void ShouldDeallocate(){} // RVA: 0x7FFD54931060
        public void AssumePositive(){} // RVA: 0x7FFD50006C10
        public void CreateNativeArray(){} // RVA: 0x7FFD4E2ADC40
    }

    public class DeallocateOnJobCompletionAttribute : Attribute
    {
    }

    public class FixedBytes128Align8 : ValueType
    {
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0000; // 0x10
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0016; // 0x20
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0032; // 0x30
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0048; // 0x40
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0064; // 0x50
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0080; // 0x60
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0096; // 0x70
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0112; // 0x80
    }

    public class FixedBytes16Align8 : ValueType
    {
        public ulong byte0000; // 0x10
        public ulong byte0008; // 0x18
    }

    public class FixedBytes32Align8 : ValueType
    {
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0000; // 0x10
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0016; // 0x20
    }

    public class FixedBytes4096Align8 : ValueType
    {
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0000; // 0x10
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0016; // 0x20
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0032; // 0x30
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0048; // 0x40
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0064; // 0x50
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0080; // 0x60
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0096; // 0x70
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0112; // 0x80
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0128; // 0x90
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0144; // 0xA0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0160; // 0xB0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0176; // 0xC0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0192; // 0xD0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0208; // 0xE0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0224; // 0xF0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0240; // 0x100
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0256; // 0x110
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0272; // 0x120
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0288; // 0x130
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0304; // 0x140
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0320; // 0x150
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0336; // 0x160
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0352; // 0x170
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0368; // 0x180
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0384; // 0x190
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0400; // 0x1A0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0416; // 0x1B0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0432; // 0x1C0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0448; // 0x1D0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0464; // 0x1E0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0480; // 0x1F0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0496; // 0x200
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0512; // 0x210
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0528; // 0x220
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0544; // 0x230
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0560; // 0x240
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0576; // 0x250
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0592; // 0x260
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0608; // 0x270
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0624; // 0x280
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0640; // 0x290
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0656; // 0x2A0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0672; // 0x2B0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0688; // 0x2C0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0704; // 0x2D0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0720; // 0x2E0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0736; // 0x2F0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0752; // 0x300
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0768; // 0x310
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0784; // 0x320
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0800; // 0x330
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0816; // 0x340
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0832; // 0x350
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0848; // 0x360
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0864; // 0x370
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0880; // 0x380
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0896; // 0x390
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0912; // 0x3A0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0928; // 0x3B0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0944; // 0x3C0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0960; // 0x3D0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0976; // 0x3E0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0992; // 0x3F0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1008; // 0x400
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1024; // 0x410
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1040; // 0x420
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1056; // 0x430
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1072; // 0x440
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1088; // 0x450
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1104; // 0x460
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1120; // 0x470
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1136; // 0x480
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1152; // 0x490
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1168; // 0x4A0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1184; // 0x4B0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1200; // 0x4C0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1216; // 0x4D0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1232; // 0x4E0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1248; // 0x4F0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1264; // 0x500
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1280; // 0x510
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1296; // 0x520
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1312; // 0x530
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1328; // 0x540
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1344; // 0x550
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1360; // 0x560
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1376; // 0x570
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1392; // 0x580
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1408; // 0x590
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1424; // 0x5A0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1440; // 0x5B0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1456; // 0x5C0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1472; // 0x5D0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1488; // 0x5E0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1504; // 0x5F0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1520; // 0x600
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1536; // 0x610
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1552; // 0x620
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1568; // 0x630
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1584; // 0x640
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1600; // 0x650
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1616; // 0x660
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1632; // 0x670
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1648; // 0x680
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1664; // 0x690
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1680; // 0x6A0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1696; // 0x6B0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1712; // 0x6C0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1728; // 0x6D0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1744; // 0x6E0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1760; // 0x6F0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1776; // 0x700
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1792; // 0x710
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1808; // 0x720
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1824; // 0x730
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1840; // 0x740
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1856; // 0x750
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1872; // 0x760
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1888; // 0x770
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1904; // 0x780
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1920; // 0x790
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1936; // 0x7A0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1952; // 0x7B0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1968; // 0x7C0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset1984; // 0x7D0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2000; // 0x7E0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2016; // 0x7F0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2032; // 0x800
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2048; // 0x810
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2064; // 0x820
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2080; // 0x830
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2096; // 0x840
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2112; // 0x850
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2128; // 0x860
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2144; // 0x870
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2160; // 0x880
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2176; // 0x890
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2192; // 0x8A0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2208; // 0x8B0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2224; // 0x8C0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2240; // 0x8D0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2256; // 0x8E0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2272; // 0x8F0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2288; // 0x900
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2304; // 0x910
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2320; // 0x920
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2336; // 0x930
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2352; // 0x940
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2368; // 0x950
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2384; // 0x960
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2400; // 0x970
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2416; // 0x980
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2432; // 0x990
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2448; // 0x9A0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2464; // 0x9B0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2480; // 0x9C0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2496; // 0x9D0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2512; // 0x9E0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2528; // 0x9F0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2544; // 0xA00
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2560; // 0xA10
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2576; // 0xA20
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2592; // 0xA30
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2608; // 0xA40
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2624; // 0xA50
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2640; // 0xA60
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2656; // 0xA70
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2672; // 0xA80
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2688; // 0xA90
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2704; // 0xAA0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2720; // 0xAB0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2736; // 0xAC0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2752; // 0xAD0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2768; // 0xAE0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2784; // 0xAF0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2800; // 0xB00
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2816; // 0xB10
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2832; // 0xB20
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2848; // 0xB30
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2864; // 0xB40
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2880; // 0xB50
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2896; // 0xB60
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2912; // 0xB70
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2928; // 0xB80
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2944; // 0xB90
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2960; // 0xBA0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2976; // 0xBB0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset2992; // 0xBC0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3008; // 0xBD0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3024; // 0xBE0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3040; // 0xBF0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3056; // 0xC00
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3072; // 0xC10
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3088; // 0xC20
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3104; // 0xC30
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3120; // 0xC40
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3136; // 0xC50
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3152; // 0xC60
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3168; // 0xC70
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3184; // 0xC80
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3200; // 0xC90
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3216; // 0xCA0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3232; // 0xCB0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3248; // 0xCC0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3264; // 0xCD0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3280; // 0xCE0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3296; // 0xCF0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3312; // 0xD00
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3328; // 0xD10
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3344; // 0xD20
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3360; // 0xD30
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3376; // 0xD40
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3392; // 0xD50
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3408; // 0xD60
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3424; // 0xD70
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3440; // 0xD80
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3456; // 0xD90
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3472; // 0xDA0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3488; // 0xDB0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3504; // 0xDC0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3520; // 0xDD0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3536; // 0xDE0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3552; // 0xDF0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3568; // 0xE00
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3584; // 0xE10
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3600; // 0xE20
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3616; // 0xE30
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3632; // 0xE40
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3648; // 0xE50
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3664; // 0xE60
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3680; // 0xE70
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3696; // 0xE80
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3712; // 0xE90
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3728; // 0xEA0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3744; // 0xEB0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3760; // 0xEC0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3776; // 0xED0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3792; // 0xEE0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3808; // 0xEF0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3824; // 0xF00
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3840; // 0xF10
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3856; // 0xF20
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3872; // 0xF30
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3888; // 0xF40
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3904; // 0xF50
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3920; // 0xF60
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3936; // 0xF70
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3952; // 0xF80
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3968; // 0xF90
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset3984; // 0xFA0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset4000; // 0xFB0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset4016; // 0xFC0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset4032; // 0xFD0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset4048; // 0xFE0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset4064; // 0xFF0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset4080; // 0x1000
    }

    public class FixedBytes512Align8 : ValueType
    {
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0000; // 0x10
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0016; // 0x20
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0032; // 0x30
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0048; // 0x40
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0064; // 0x50
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0080; // 0x60
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0096; // 0x70
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0112; // 0x80
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0128; // 0x90
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0144; // 0xA0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0160; // 0xB0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0176; // 0xC0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0192; // 0xD0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0208; // 0xE0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0224; // 0xF0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0240; // 0x100
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0256; // 0x110
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0272; // 0x120
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0288; // 0x130
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0304; // 0x140
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0320; // 0x150
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0336; // 0x160
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0352; // 0x170
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0368; // 0x180
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0384; // 0x190
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0400; // 0x1A0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0416; // 0x1B0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0432; // 0x1C0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0448; // 0x1D0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0464; // 0x1E0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0480; // 0x1F0
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0496; // 0x200
    }

    public class FixedBytes64Align8 : ValueType
    {
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0000; // 0x10
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0016; // 0x20
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0032; // 0x30
        public ÍÎÏÎÎ.ric.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current offset0048; // 0x40
    }

    public class FixedList : ValueType
    {
        // ── Methods ──
        public void PaddingBytes(){} // RVA: 0x7FFD4E079990
    }

    public class FixedList128Bytes`1 : ValueType
    {
        public ÍÎÏÎÎ.ing>>>.get_Current length; // 0x10

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFD4E078DC0
        public void get_buffer(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_LengthInBytes(){} // RVA: 0x7FFD4E079960
        public void get_Buffer(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void CompareTo(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class FixedList32Bytes`1 : ValueType
    {
        public ÍÎÏÎÎ.neric.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current length; // 0x10

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFD4E078DC0
        public void get_buffer(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_LengthInBytes(){} // RVA: 0x7FFD4E079960
        public void get_Buffer(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void CompareTo(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class FixedList4096Bytes`1 : ValueType
    {
        public ÍÎÏÎÎ.nsferEncodingChunked>b__71_0 length; // 0x10

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFD4E078DC0
        public void get_buffer(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_LengthInBytes(){} // RVA: 0x7FFD4E079960
        public void get_Buffer(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void CompareTo(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class FixedList512Bytes`1 : ValueType
    {
        public ÍÎÏÎÎ..Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.Current length; // 0x10

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFD4E078DC0
        public void get_buffer(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_LengthInBytes(){} // RVA: 0x7FFD4E079960
        public void get_Buffer(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void CompareTo(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class FixedList64Bytes`1 : ValueType
    {
        public ÍÎÏÎÎ.ollections.Generic.IEnumerable<System.String>>>.get_Current length; // 0x10

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFD4E078DC0
        public void get_buffer(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_LengthInBytes(){} // RVA: 0x7FFD4E079960
        public void get_Buffer(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void CompareTo(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class FixedStringMethods : Object
    {
        // ── Methods ──
        public void ConvertToString(){} // RVA: 0x7FFD4E078F80
    }

    public class GenerateTestsForBurstCompatibilityAttribute : Attribute
    {
        public ?[] GenericTypeArguments; // 0x10

        // ── Methods ──
        public void set_GenericTypeArguments(){} // RVA: 0x7FFD4E342E30
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Hash128Long_00000A71$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD54934460
        public void GetFunctionPointer(){} // RVA: 0x7FFD549345A0
        public void Constructor(){} // RVA: 0x7FFD54934710
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54934710
        public void Invoke(){} // RVA: 0x7FFD549347D0
    }

    public class Hash128Long_00000A71$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54934380
        public void Invoke(){} // RVA: 0x7FFD51080E20
    }

    public class Hash64Long_00000A6A$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD54933D30
        public void GetFunctionPointer(){} // RVA: 0x7FFD54933E70
        public void Constructor(){} // RVA: 0x7FFD54933FE0
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54933FE0
        public void Invoke(){} // RVA: 0x7FFD549340A0
    }

    public class Hash64Long_00000A6A$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53790B30
        public void Invoke(){} // RVA: 0x7FFD4EC5F780
    }

    public class IIndexable`1
    {
        public object Length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFD4E079960
    }

    public class INativeList`1
    {
    }

    public class IUTF8Bytes
    {
        // ── Methods ──
        public void GetUnsafePtr(){} // RVA: 0x7FFD4E2ADC40
    }

    public class KVPair`2 : ValueType
    {
        public IntPtr m_Data;
        public int m_Index;
        public int m_Next;
    }

    public class ListExtensions : Object
    {
        // ── Methods ──
        public void RemoveAtSwapBack(){} // RVA: 0x7FFD4E096370
    }

    public class Memory : ValueType
    {
    }

    public class NativeArrayDispose : ValueType
    {
        public IntPtr m_Buffer; // 0x10
        public ÍÎÏÎÎ.ments.ITextEdition.autoCorrection m_AllocatorLabel; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD54C70DA0
    }

    public class NativeArrayDisposeJob : ValueType
    {
        public ÍÎÏÎÎ.ÌÌÏÍÍÏÎÌÎÏÌÎÏÏÍÎÌÍÌÎÎÌÌ Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD54C70DA0
        public void RegisterNativeArrayDisposeJobReflectionData(){} // RVA: 0x7FFD54C70E00
    }

    public class NativeArrayExtensions : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void Initialize(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NativeArray`1 : ValueType
    {
        public IntPtr Length; // 0x10
        public int Item; // 0x18
        public ÍÎÏÎÎ.ments.ITextEdition.autoCorrection IsCreated; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void Allocate(){} // RVA: 0x7FFD4E092740
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void CopyFrom(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFD4E078E90
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void Copy(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void CopySafe(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void GetSubArray(){} // RVA: 0x7FFD4E2ADC40
        public void AsReadOnly(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NativeBitArrayDispose : ValueType
    {
        public IntPtr m_BitArrayData; // 0x10
        public ield m_Allocator; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD549313E0
    }

    public class NativeBitArrayDisposeJob : ValueType
    {
        public ÍÎÏÎÎ.ProxyOnRenderObject Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD549314F0
    }

    public class NativeDisableParallelForRestrictionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class NativeFixedLengthAttribute : Attribute
    {
    }

    public class NativeHashMapDispose : ValueType
    {
        public IntPtr m_HashMapData; // 0x10
        public ield m_Allocator; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD54931500
    }

    public class NativeHashMapDisposeJob : ValueType
    {
        public ÍÎÏÎÎ.? Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD54931680
    }

    public class NativeHashMap`2 : ValueType
    {
        public IntPtr IsCreated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void TryAdd(){} // RVA: 0x7FFD4E2ADC40
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void ContainsKey(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void GetKeyArray(){} // RVA: 0x7FFD4E2ADC40
        public void GetValueArray(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class NativeListDispose : ValueType
    {
        public IntPtr m_ListData; // 0x10

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD54931690
    }

    public class NativeListDisposeJob : ValueType
    {
        public ÍÎÏÎÎ.s Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD54931690
    }

    public class NativeListExtensions : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NativeList`1 : ValueType
    {
        public IntPtr Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFD4E092BC0
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void set_Length(){} // RVA: 0x7FFD4E090ED0
        public void get_Capacity(){} // RVA: 0x7FFD4E079960
        public void Add(){} // RVA: 0x7FFD4E090A40
        public void AddRange(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void RemoveAtSwapBack(){} // RVA: 0x7FFD4E090ED0
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void AsArray(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void SetCapacity(){} // RVA: 0x7FFD4E090ED0
    }

    public class NativeMatchesParallelForLengthAttribute : Attribute
    {
    }

    public class NativeParallelHashMapExtensions : Object
    {
        // ── Methods ──
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NativeParallelHashMap`2 : ValueType
    {
        public TANCERESTORED<T1717728800,T1717728816> IsCreated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void AsParallelWriter(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class NativeParallelMultiHashMapIterator`1 : ValueType
    {
        public T1717728896 key;
        public int NextEntryIndex;
        public int EntryIndex;
    }

    public class NativeParallelMultiHashMap`2 : ValueType
    {
        public ON_EVENT_ONPOSTSERIALIZATION<T1717728928,T1717728944> IsCreated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Initialize(){} // RVA: 0x7FFD4E092BC0
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetFirstValue(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNextValue(){} // RVA: 0x7FFD4E07D200
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class NativeQueueDispose : ValueType
    {
        public IntPtr m_QueueData; // 0x10

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD549316D0
    }

    public class NativeQueueDisposeJob : ValueType
    {
        public ÍÎÏÎÎ.nagedFixedUpdateProfilerMarker Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD549316D0
    }

    public class NativeQueue`1 : ValueType
    {
        public IntPtr IsCreated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Enqueue(){} // RVA: 0x7FFD4E2ADC40
        public void TryDequeue(){} // RVA: 0x7FFD4E079F60
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void AsParallelWriter(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NativeSliceExtensions : Object
    {
        // ── Methods ──
        public void Slice(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
    }

    public class NativeSlice`1 : ValueType
    {
        public object Item;
        public object Stride;
        public object Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void CopyFrom(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void get_Stride(){} // RVA: 0x7FFD4E079960
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
    }

    public class NativeStream : ValueType
    {
        public _EVENT_ONINSTANCESTORAGEWARNING IsCreated; // 0x10

        // ── Methods ──
        public void get_IsCreated(){} // RVA: 0x7FFD511E6CA0
        public void Dispose(){} // RVA: 0x7FFD549318B0
        public void AllocateForEach(){} // RVA: 0x7FFD549318C0
    }

    public class ReadOnlyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class RewindableAllocator : ValueType
    {
        public ÍÎÏÎÎ.TryParseElement Handle; // 0x10
        public ield m_handle; // 0x14
        public ÍÎÏÎÎ.tionHook<orts> m_block; // 0x18
        public int m_last; // 0x28
        public int m_used; // 0x2C
        public byte m_enableBlockFree; // 0x30
        public byte m_reachMaxBlockSize; // 0x31

        // ── Methods ──
        public void Rewind(){} // RVA: 0x7FFD54931A40
        public void Dispose(){} // RVA: 0x7FFD54931BD0
        public void TryAllocate(){} // RVA: 0x7FFD54931D20
        public void Try(){} // RVA: 0x7FFD549321F0 | overloaded x2
        public void get_Handle(){} // RVA: 0x7FFD4F8402A0
        public void Try$BurstManaged(){} // RVA: 0x7FFD54932250
    }

    public class Spinner : ValueType
    {
        public int m_Lock; // 0x10

        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFD5492E5E0
        public void Release(){} // RVA: 0x7FFD5492E600
    }

    public class Try_000000E3$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD54930A90
        public void GetFunctionPointer(){} // RVA: 0x7FFD54930BD0
        public void Constructor(){} // RVA: 0x7FFD54930D40
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54930D40
        public void Invoke(){} // RVA: 0x7FFD54930E00
    }

    public class Try_000000E3$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5337FAB0
        public void Invoke(){} // RVA: 0x7FFD4E49D370
    }

    public class Try_000009DF$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD549323C0
        public void GetFunctionPointer(){} // RVA: 0x7FFD54932500
        public void Constructor(){} // RVA: 0x7FFD54932670
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54932670
        public void Invoke(){} // RVA: 0x7FFD54932730
    }

    public class Try_000009DF$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5337FAB0
        public void Invoke(){} // RVA: 0x7FFD4E49D370
    }

    public class Unicode : ValueType
    {
        public object ReplacementCharacter;

        // ── Methods ──
        public void IsValidCodePoint(){} // RVA: 0x7FFD54932940
        public void NotTrailer(){} // RVA: 0x7FFD54932950
        public void get_ReplacementCharacter(){} // RVA: 0x7FFD53EA36C0
        public void Utf8ToUcs(){} // RVA: 0x7FFD54932960
        public void UcsToUtf16(){} // RVA: 0x7FFD54932B50
        public void Utf8ToUtf16(){} // RVA: 0x7FFD54932BF0
    }

    public class UnmanagedArray`1 : ValueType
    {
        public UIntPtr Item; // 0x10
        public int m_length; // 0x18
        public ield m_allocator; // 0x1C

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void get_Item(){} // RVA: 0x7FFD4E087DE0
    }

    public class UnsafeQueueBlockHeader : ValueType
    {
        public IntPtr m_NextBlock; // 0x10
        public int m_NumItems; // 0x18
    }

    public class UnsafeQueueData : ValueType
    {
        public int m_BlockSize;
        public UIntPtr m_FirstBlock; // 0x10
        public UIntPtr m_LastBlock; // 0x18
        public int m_MaxItems; // 0x20
        public int m_CurrentRead; // 0x24
        public IntPtr m_CurrentWriteBlockTLS; // 0x28

        // ── Methods ──
        public void GetCurrentWriteBlockTLS(){} // RVA: 0x7FFD54932D80
        public void SetCurrentWriteBlockTLS(){} // RVA: 0x7FFD54932D90
        public void AllocateWriteBlockMT(){} // RVA: 0x7FFD4E2ADC40
        public void AllocateQueue(){} // RVA: 0x7FFD4E2ADC40
        public void DeallocateQueue(){} // RVA: 0x7FFD54932DA0
    }

    public class UnsafeQueue`1 : ValueType
    {
        public IntPtr IsCreated;
        public ield m_AllocatorLabel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Alloc(){} // RVA: 0x7FFD4E2ADC40
        public void Free(){} // RVA: 0x7FFD4E2ADC40
        public void Enqueue(){} // RVA: 0x7FFD4E2ADC40
        public void TryDequeue(){} // RVA: 0x7FFD4E079F60
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void AsParallelWriter(){} // RVA: 0x7FFD4E2ADC40
    }

    public class WriteOnlyAttribute : Attribute
    {
    }

    public class xxHash3 : Object
    {
        // ── Methods ──
        public void Avx2HashLongInternalLoop(){} // RVA: 0x7FFD4E9F2DD0
        public void Avx2ScrambleAcc(){} // RVA: 0x7FFD4E9F2DD0
        public void Avx2Accumulate(){} // RVA: 0x7FFD4E9F2DD0
        public void Avx2Accumulate512(){} // RVA: 0x7FFD4E9F2DD0
        public void Hash64Long(){} // RVA: 0x7FFD54932F20
        public void Hash128Long(){} // RVA: 0x7FFD54932FB0
        public void ToUint4(){} // RVA: 0x7FFD54933040
        public void Read64LE(){} // RVA: 0x7FFD4EEF9F60
        public void Write64LE(){} // RVA: 0x7FFD4F9DB120
        public void Mul32To64(){} // RVA: 0x7FFD539D6350
        public void XorShift64(){} // RVA: 0x7FFD543B3F70
        public void Mul128Fold64(){} // RVA: 0x7FFD54933060
        public void Avalanche(){} // RVA: 0x7FFD543B3BB0
        public void Mix2Acc(){} // RVA: 0x7FFD549330C0
        public void MergeAcc(){} // RVA: 0x7FFD54933120
        public void DefaultHashLongInternalLoop(){} // RVA: 0x7FFD54933310
        public void DefaultAccumulate(){} // RVA: 0x7FFD549336A0
        public void DefaultAccumulate512(){} // RVA: 0x7FFD54933880
        public void DefaultScrambleAcc(){} // RVA: 0x7FFD549339E0
        public void Hash64Long$BurstManaged(){} // RVA: 0x7FFD54933AC0
        public void Hash128Long$BurstManaged(){} // RVA: 0x7FFD54933BE0
    }

}