// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Collections
// Classes: 96
// Methods: 372

namespace ThirdParty.Other.Unity.Collections
{
    public class AllocatorManager : Object
    {
        public AllocatorHandle Invalid;
        public AllocatorHandle None; // 0x4
        public AllocatorHandle Temp; // 0x8
        public AllocatorHandle TempJob; // 0xC
        public AllocatorHandle Persistent; // 0x10
        public AllocatorHandle AudioKernel; // 0x14
        public ushort NumGlobalScratchAllocators; // 0x18
        public ushort MaxNumGlobalAllocators; // 0x1A
        public uint GlobalAllocatorBaseIndex; // 0x1C
        public uint FirstGlobalScratchpadAllocatorIndex; // 0x20

        // ── Methods ──
        public void AllocateBlock(){} // RVA: 0x7FFAC2E8DC40
        public void Allocate(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void AllocateStruct(){} // RVA: 0x7FFAC2E8DC40
        public void FreeBlock(){} // RVA: 0x7FFAC2C70C80
        public void Free(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void CheckDelegate(){} // RVA: 0x7FFAC7DE1980
        public void UseDelegate(){} // RVA: 0x7FFAC950E690
        public void allocate_block(){} // RVA: 0x7FFAC950E6E0
        public void forward_mono_allocate_block(){} // RVA: 0x7FFAC950E780
        public void LegacyOf(){} // RVA: 0x7FFAC950E8A0
        public void TryLegacy(){} // RVA: 0x7FFAC950E8B0
        public void Try(){} // RVA: 0x7FFAC950EA50
        public void IsCustomAllocator(){} // RVA: 0x7FFAC950EDC0
        public void .cctor(){} // RVA: 0x7FFAC950EDD0
        public void Initialize$StackAllocator_Try_000000AB$BurstDirectCall(){} // RVA: 0x7FFAC950EF90
        public void Initialize$SlabAllocator_Try_000000B9$BurstDirectCall(){} // RVA: 0x7FFAC950EFE0
    }

    public class ArrayOfArrays`1 : ValueType
    {
        public AllocatorHandle BlockSizeInElements;
        public int BlockSizeInBytes;
        public int BlockMask;
        public int Length;
        public int Item;
        public UIntPtr* m_block;

        // ── Methods ──
        public void get_BlockSizeInElements(){} // RVA: 0x7FFAC2C59960
        public void get_BlockSizeInBytes(){} // RVA: 0x7FFAC2C59960
        public void get_BlockMask(){} // RVA: 0x7FFAC2C59960
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void LockfreeAdd(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item(){} // RVA: 0x7FFAC2C67DE0
        public void Rewind(){} // RVA: 0x7FFAC2C70980
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void RemoveAtSwapBack(){} // RVA: 0x7FFAC2C70ED0
        public void BlockIndexOfElement(){} // RVA: 0x7FFAC2C600D0
        public void TrimExcess(){} // RVA: 0x7FFAC2C70980
    }

    public class AutoFreeAllocator : ValueType
    {
        public Unity.Collections.ArrayOfArrays`1<UIntPtr> Handle; // 0x10
        public Unity.Collections.ArrayOfArrays`1<UIntPtr> m_tofree; // 0x30
        public AllocatorHandle m_handle; // 0x50
        public AllocatorHandle m_backingAllocatorHandle; // 0x54

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFAC9510620
        public void FreeAll(){} // RVA: 0x7FFAC9510780
        public void Dispose(){} // RVA: 0x7FFAC95108D0
        public void Try(){} // RVA: 0x7FFAC9510A20 | overloaded x2
        public void get_Handle(){} // RVA: 0x7FFAC2FC2080
        public void Try$BurstManaged(){} // RVA: 0x7FFAC9510A80
    }

    public class CollectionHelper : Object
    {
        // ── Methods ──
        public void Align(){} // RVA: 0x7FFAC9511010
        public void Hash(){} // RVA: 0x7FFAC9511030
        public void ShouldDeallocate(){} // RVA: 0x7FFAC9511060
        public void AssumePositive(){} // RVA: 0x7FFAC4BE6C10
        public void CreateNativeArray(){} // RVA: 0x7FFAC2E8DC40
    }

    public class DeallocateOnJobCompletionAttribute : Attribute
    {
    }

    public class ExcludeFromBurstCompatTestingAttribute : Attribute
    {
        public string Reason; // 0x10

        // ── Methods ──
        public void set_Reason(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class FixedBytes128Align8 : ValueType
    {
        public Unity.Collections.FixedBytes16Align8 offset0000; // 0x10
        public Unity.Collections.FixedBytes16Align8 offset0016; // 0x20
        public Unity.Collections.FixedBytes16Align8 offset0032; // 0x30
        public Unity.Collections.FixedBytes16Align8 offset0048; // 0x40
        public Unity.Collections.FixedBytes16Align8 offset0064; // 0x50
        public Unity.Collections.FixedBytes16Align8 offset0080; // 0x60
        public Unity.Collections.FixedBytes16Align8 offset0096; // 0x70
        public Unity.Collections.FixedBytes16Align8 offset0112; // 0x80
    }

    public class FixedBytes16Align8 : ValueType
    {
        public ulong byte0000; // 0x10
        public ulong byte0008; // 0x18
    }

    public class FixedBytes32Align8 : ValueType
    {
        public Unity.Collections.FixedBytes16Align8 offset0000; // 0x10
        public Unity.Collections.FixedBytes16Align8 offset0016; // 0x20
    }

    public class FixedBytes4096Align8 : ValueType
    {
        public Unity.Collections.FixedBytes16Align8 offset0000; // 0x10
        public Unity.Collections.FixedBytes16Align8 offset0016; // 0x20
        public Unity.Collections.FixedBytes16Align8 offset0032; // 0x30
        public Unity.Collections.FixedBytes16Align8 offset0048; // 0x40
        public Unity.Collections.FixedBytes16Align8 offset0064; // 0x50
        public Unity.Collections.FixedBytes16Align8 offset0080; // 0x60
        public Unity.Collections.FixedBytes16Align8 offset0096; // 0x70
        public Unity.Collections.FixedBytes16Align8 offset0112; // 0x80
        public Unity.Collections.FixedBytes16Align8 offset0128; // 0x90
        public Unity.Collections.FixedBytes16Align8 offset0144; // 0xA0
        public Unity.Collections.FixedBytes16Align8 offset0160; // 0xB0
        public Unity.Collections.FixedBytes16Align8 offset0176; // 0xC0
        public Unity.Collections.FixedBytes16Align8 offset0192; // 0xD0
        public Unity.Collections.FixedBytes16Align8 offset0208; // 0xE0
        public Unity.Collections.FixedBytes16Align8 offset0224; // 0xF0
        public Unity.Collections.FixedBytes16Align8 offset0240; // 0x100
        public Unity.Collections.FixedBytes16Align8 offset0256; // 0x110
        public Unity.Collections.FixedBytes16Align8 offset0272; // 0x120
        public Unity.Collections.FixedBytes16Align8 offset0288; // 0x130
        public Unity.Collections.FixedBytes16Align8 offset0304; // 0x140
        public Unity.Collections.FixedBytes16Align8 offset0320; // 0x150
        public Unity.Collections.FixedBytes16Align8 offset0336; // 0x160
        public Unity.Collections.FixedBytes16Align8 offset0352; // 0x170
        public Unity.Collections.FixedBytes16Align8 offset0368; // 0x180
        public Unity.Collections.FixedBytes16Align8 offset0384; // 0x190
        public Unity.Collections.FixedBytes16Align8 offset0400; // 0x1A0
        public Unity.Collections.FixedBytes16Align8 offset0416; // 0x1B0
        public Unity.Collections.FixedBytes16Align8 offset0432; // 0x1C0
        public Unity.Collections.FixedBytes16Align8 offset0448; // 0x1D0
        public Unity.Collections.FixedBytes16Align8 offset0464; // 0x1E0
        public Unity.Collections.FixedBytes16Align8 offset0480; // 0x1F0
        public Unity.Collections.FixedBytes16Align8 offset0496; // 0x200
        public Unity.Collections.FixedBytes16Align8 offset0512; // 0x210
        public Unity.Collections.FixedBytes16Align8 offset0528; // 0x220
        public Unity.Collections.FixedBytes16Align8 offset0544; // 0x230
        public Unity.Collections.FixedBytes16Align8 offset0560; // 0x240
        public Unity.Collections.FixedBytes16Align8 offset0576; // 0x250
        public Unity.Collections.FixedBytes16Align8 offset0592; // 0x260
        public Unity.Collections.FixedBytes16Align8 offset0608; // 0x270
        public Unity.Collections.FixedBytes16Align8 offset0624; // 0x280
        public Unity.Collections.FixedBytes16Align8 offset0640; // 0x290
        public Unity.Collections.FixedBytes16Align8 offset0656; // 0x2A0
        public Unity.Collections.FixedBytes16Align8 offset0672; // 0x2B0
        public Unity.Collections.FixedBytes16Align8 offset0688; // 0x2C0
        public Unity.Collections.FixedBytes16Align8 offset0704; // 0x2D0
        public Unity.Collections.FixedBytes16Align8 offset0720; // 0x2E0
        public Unity.Collections.FixedBytes16Align8 offset0736; // 0x2F0
        public Unity.Collections.FixedBytes16Align8 offset0752; // 0x300
        public Unity.Collections.FixedBytes16Align8 offset0768; // 0x310
        public Unity.Collections.FixedBytes16Align8 offset0784; // 0x320
        public Unity.Collections.FixedBytes16Align8 offset0800; // 0x330
        public Unity.Collections.FixedBytes16Align8 offset0816; // 0x340
        public Unity.Collections.FixedBytes16Align8 offset0832; // 0x350
        public Unity.Collections.FixedBytes16Align8 offset0848; // 0x360
        public Unity.Collections.FixedBytes16Align8 offset0864; // 0x370
        public Unity.Collections.FixedBytes16Align8 offset0880; // 0x380
        public Unity.Collections.FixedBytes16Align8 offset0896; // 0x390
        public Unity.Collections.FixedBytes16Align8 offset0912; // 0x3A0
        public Unity.Collections.FixedBytes16Align8 offset0928; // 0x3B0
        public Unity.Collections.FixedBytes16Align8 offset0944; // 0x3C0
        public Unity.Collections.FixedBytes16Align8 offset0960; // 0x3D0
        public Unity.Collections.FixedBytes16Align8 offset0976; // 0x3E0
        public Unity.Collections.FixedBytes16Align8 offset0992; // 0x3F0
        public Unity.Collections.FixedBytes16Align8 offset1008; // 0x400
        public Unity.Collections.FixedBytes16Align8 offset1024; // 0x410
        public Unity.Collections.FixedBytes16Align8 offset1040; // 0x420
        public Unity.Collections.FixedBytes16Align8 offset1056; // 0x430
        public Unity.Collections.FixedBytes16Align8 offset1072; // 0x440
        public Unity.Collections.FixedBytes16Align8 offset1088; // 0x450
        public Unity.Collections.FixedBytes16Align8 offset1104; // 0x460
        public Unity.Collections.FixedBytes16Align8 offset1120; // 0x470
        public Unity.Collections.FixedBytes16Align8 offset1136; // 0x480
        public Unity.Collections.FixedBytes16Align8 offset1152; // 0x490
        public Unity.Collections.FixedBytes16Align8 offset1168; // 0x4A0
        public Unity.Collections.FixedBytes16Align8 offset1184; // 0x4B0
        public Unity.Collections.FixedBytes16Align8 offset1200; // 0x4C0
        public Unity.Collections.FixedBytes16Align8 offset1216; // 0x4D0
        public Unity.Collections.FixedBytes16Align8 offset1232; // 0x4E0
        public Unity.Collections.FixedBytes16Align8 offset1248; // 0x4F0
        public Unity.Collections.FixedBytes16Align8 offset1264; // 0x500
        public Unity.Collections.FixedBytes16Align8 offset1280; // 0x510
        public Unity.Collections.FixedBytes16Align8 offset1296; // 0x520
        public Unity.Collections.FixedBytes16Align8 offset1312; // 0x530
        public Unity.Collections.FixedBytes16Align8 offset1328; // 0x540
        public Unity.Collections.FixedBytes16Align8 offset1344; // 0x550
        public Unity.Collections.FixedBytes16Align8 offset1360; // 0x560
        public Unity.Collections.FixedBytes16Align8 offset1376; // 0x570
        public Unity.Collections.FixedBytes16Align8 offset1392; // 0x580
        public Unity.Collections.FixedBytes16Align8 offset1408; // 0x590
        public Unity.Collections.FixedBytes16Align8 offset1424; // 0x5A0
        public Unity.Collections.FixedBytes16Align8 offset1440; // 0x5B0
        public Unity.Collections.FixedBytes16Align8 offset1456; // 0x5C0
        public Unity.Collections.FixedBytes16Align8 offset1472; // 0x5D0
        public Unity.Collections.FixedBytes16Align8 offset1488; // 0x5E0
        public Unity.Collections.FixedBytes16Align8 offset1504; // 0x5F0
        public Unity.Collections.FixedBytes16Align8 offset1520; // 0x600
        public Unity.Collections.FixedBytes16Align8 offset1536; // 0x610
        public Unity.Collections.FixedBytes16Align8 offset1552; // 0x620
        public Unity.Collections.FixedBytes16Align8 offset1568; // 0x630
        public Unity.Collections.FixedBytes16Align8 offset1584; // 0x640
        public Unity.Collections.FixedBytes16Align8 offset1600; // 0x650
        public Unity.Collections.FixedBytes16Align8 offset1616; // 0x660
        public Unity.Collections.FixedBytes16Align8 offset1632; // 0x670
        public Unity.Collections.FixedBytes16Align8 offset1648; // 0x680
        public Unity.Collections.FixedBytes16Align8 offset1664; // 0x690
        public Unity.Collections.FixedBytes16Align8 offset1680; // 0x6A0
        public Unity.Collections.FixedBytes16Align8 offset1696; // 0x6B0
        public Unity.Collections.FixedBytes16Align8 offset1712; // 0x6C0
        public Unity.Collections.FixedBytes16Align8 offset1728; // 0x6D0
        public Unity.Collections.FixedBytes16Align8 offset1744; // 0x6E0
        public Unity.Collections.FixedBytes16Align8 offset1760; // 0x6F0
        public Unity.Collections.FixedBytes16Align8 offset1776; // 0x700
        public Unity.Collections.FixedBytes16Align8 offset1792; // 0x710
        public Unity.Collections.FixedBytes16Align8 offset1808; // 0x720
        public Unity.Collections.FixedBytes16Align8 offset1824; // 0x730
        public Unity.Collections.FixedBytes16Align8 offset1840; // 0x740
        public Unity.Collections.FixedBytes16Align8 offset1856; // 0x750
        public Unity.Collections.FixedBytes16Align8 offset1872; // 0x760
        public Unity.Collections.FixedBytes16Align8 offset1888; // 0x770
        public Unity.Collections.FixedBytes16Align8 offset1904; // 0x780
        public Unity.Collections.FixedBytes16Align8 offset1920; // 0x790
        public Unity.Collections.FixedBytes16Align8 offset1936; // 0x7A0
        public Unity.Collections.FixedBytes16Align8 offset1952; // 0x7B0
        public Unity.Collections.FixedBytes16Align8 offset1968; // 0x7C0
        public Unity.Collections.FixedBytes16Align8 offset1984; // 0x7D0
        public Unity.Collections.FixedBytes16Align8 offset2000; // 0x7E0
        public Unity.Collections.FixedBytes16Align8 offset2016; // 0x7F0
        public Unity.Collections.FixedBytes16Align8 offset2032; // 0x800
        public Unity.Collections.FixedBytes16Align8 offset2048; // 0x810
        public Unity.Collections.FixedBytes16Align8 offset2064; // 0x820
        public Unity.Collections.FixedBytes16Align8 offset2080; // 0x830
        public Unity.Collections.FixedBytes16Align8 offset2096; // 0x840
        public Unity.Collections.FixedBytes16Align8 offset2112; // 0x850
        public Unity.Collections.FixedBytes16Align8 offset2128; // 0x860
        public Unity.Collections.FixedBytes16Align8 offset2144; // 0x870
        public Unity.Collections.FixedBytes16Align8 offset2160; // 0x880
        public Unity.Collections.FixedBytes16Align8 offset2176; // 0x890
        public Unity.Collections.FixedBytes16Align8 offset2192; // 0x8A0
        public Unity.Collections.FixedBytes16Align8 offset2208; // 0x8B0
        public Unity.Collections.FixedBytes16Align8 offset2224; // 0x8C0
        public Unity.Collections.FixedBytes16Align8 offset2240; // 0x8D0
        public Unity.Collections.FixedBytes16Align8 offset2256; // 0x8E0
        public Unity.Collections.FixedBytes16Align8 offset2272; // 0x8F0
        public Unity.Collections.FixedBytes16Align8 offset2288; // 0x900
        public Unity.Collections.FixedBytes16Align8 offset2304; // 0x910
        public Unity.Collections.FixedBytes16Align8 offset2320; // 0x920
        public Unity.Collections.FixedBytes16Align8 offset2336; // 0x930
        public Unity.Collections.FixedBytes16Align8 offset2352; // 0x940
        public Unity.Collections.FixedBytes16Align8 offset2368; // 0x950
        public Unity.Collections.FixedBytes16Align8 offset2384; // 0x960
        public Unity.Collections.FixedBytes16Align8 offset2400; // 0x970
        public Unity.Collections.FixedBytes16Align8 offset2416; // 0x980
        public Unity.Collections.FixedBytes16Align8 offset2432; // 0x990
        public Unity.Collections.FixedBytes16Align8 offset2448; // 0x9A0
        public Unity.Collections.FixedBytes16Align8 offset2464; // 0x9B0
        public Unity.Collections.FixedBytes16Align8 offset2480; // 0x9C0
        public Unity.Collections.FixedBytes16Align8 offset2496; // 0x9D0
        public Unity.Collections.FixedBytes16Align8 offset2512; // 0x9E0
        public Unity.Collections.FixedBytes16Align8 offset2528; // 0x9F0
        public Unity.Collections.FixedBytes16Align8 offset2544; // 0xA00
        public Unity.Collections.FixedBytes16Align8 offset2560; // 0xA10
        public Unity.Collections.FixedBytes16Align8 offset2576; // 0xA20
        public Unity.Collections.FixedBytes16Align8 offset2592; // 0xA30
        public Unity.Collections.FixedBytes16Align8 offset2608; // 0xA40
        public Unity.Collections.FixedBytes16Align8 offset2624; // 0xA50
        public Unity.Collections.FixedBytes16Align8 offset2640; // 0xA60
        public Unity.Collections.FixedBytes16Align8 offset2656; // 0xA70
        public Unity.Collections.FixedBytes16Align8 offset2672; // 0xA80
        public Unity.Collections.FixedBytes16Align8 offset2688; // 0xA90
        public Unity.Collections.FixedBytes16Align8 offset2704; // 0xAA0
        public Unity.Collections.FixedBytes16Align8 offset2720; // 0xAB0
        public Unity.Collections.FixedBytes16Align8 offset2736; // 0xAC0
        public Unity.Collections.FixedBytes16Align8 offset2752; // 0xAD0
        public Unity.Collections.FixedBytes16Align8 offset2768; // 0xAE0
        public Unity.Collections.FixedBytes16Align8 offset2784; // 0xAF0
        public Unity.Collections.FixedBytes16Align8 offset2800; // 0xB00
        public Unity.Collections.FixedBytes16Align8 offset2816; // 0xB10
        public Unity.Collections.FixedBytes16Align8 offset2832; // 0xB20
        public Unity.Collections.FixedBytes16Align8 offset2848; // 0xB30
        public Unity.Collections.FixedBytes16Align8 offset2864; // 0xB40
        public Unity.Collections.FixedBytes16Align8 offset2880; // 0xB50
        public Unity.Collections.FixedBytes16Align8 offset2896; // 0xB60
        public Unity.Collections.FixedBytes16Align8 offset2912; // 0xB70
        public Unity.Collections.FixedBytes16Align8 offset2928; // 0xB80
        public Unity.Collections.FixedBytes16Align8 offset2944; // 0xB90
        public Unity.Collections.FixedBytes16Align8 offset2960; // 0xBA0
        public Unity.Collections.FixedBytes16Align8 offset2976; // 0xBB0
        public Unity.Collections.FixedBytes16Align8 offset2992; // 0xBC0
        public Unity.Collections.FixedBytes16Align8 offset3008; // 0xBD0
        public Unity.Collections.FixedBytes16Align8 offset3024; // 0xBE0
        public Unity.Collections.FixedBytes16Align8 offset3040; // 0xBF0
        public Unity.Collections.FixedBytes16Align8 offset3056; // 0xC00
        public Unity.Collections.FixedBytes16Align8 offset3072; // 0xC10
        public Unity.Collections.FixedBytes16Align8 offset3088; // 0xC20
        public Unity.Collections.FixedBytes16Align8 offset3104; // 0xC30
        public Unity.Collections.FixedBytes16Align8 offset3120; // 0xC40
        public Unity.Collections.FixedBytes16Align8 offset3136; // 0xC50
        public Unity.Collections.FixedBytes16Align8 offset3152; // 0xC60
        public Unity.Collections.FixedBytes16Align8 offset3168; // 0xC70
        public Unity.Collections.FixedBytes16Align8 offset3184; // 0xC80
        public Unity.Collections.FixedBytes16Align8 offset3200; // 0xC90
        public Unity.Collections.FixedBytes16Align8 offset3216; // 0xCA0
        public Unity.Collections.FixedBytes16Align8 offset3232; // 0xCB0
        public Unity.Collections.FixedBytes16Align8 offset3248; // 0xCC0
        public Unity.Collections.FixedBytes16Align8 offset3264; // 0xCD0
        public Unity.Collections.FixedBytes16Align8 offset3280; // 0xCE0
        public Unity.Collections.FixedBytes16Align8 offset3296; // 0xCF0
        public Unity.Collections.FixedBytes16Align8 offset3312; // 0xD00
        public Unity.Collections.FixedBytes16Align8 offset3328; // 0xD10
        public Unity.Collections.FixedBytes16Align8 offset3344; // 0xD20
        public Unity.Collections.FixedBytes16Align8 offset3360; // 0xD30
        public Unity.Collections.FixedBytes16Align8 offset3376; // 0xD40
        public Unity.Collections.FixedBytes16Align8 offset3392; // 0xD50
        public Unity.Collections.FixedBytes16Align8 offset3408; // 0xD60
        public Unity.Collections.FixedBytes16Align8 offset3424; // 0xD70
        public Unity.Collections.FixedBytes16Align8 offset3440; // 0xD80
        public Unity.Collections.FixedBytes16Align8 offset3456; // 0xD90
        public Unity.Collections.FixedBytes16Align8 offset3472; // 0xDA0
        public Unity.Collections.FixedBytes16Align8 offset3488; // 0xDB0
        public Unity.Collections.FixedBytes16Align8 offset3504; // 0xDC0
        public Unity.Collections.FixedBytes16Align8 offset3520; // 0xDD0
        public Unity.Collections.FixedBytes16Align8 offset3536; // 0xDE0
        public Unity.Collections.FixedBytes16Align8 offset3552; // 0xDF0
        public Unity.Collections.FixedBytes16Align8 offset3568; // 0xE00
        public Unity.Collections.FixedBytes16Align8 offset3584; // 0xE10
        public Unity.Collections.FixedBytes16Align8 offset3600; // 0xE20
        public Unity.Collections.FixedBytes16Align8 offset3616; // 0xE30
        public Unity.Collections.FixedBytes16Align8 offset3632; // 0xE40
        public Unity.Collections.FixedBytes16Align8 offset3648; // 0xE50
        public Unity.Collections.FixedBytes16Align8 offset3664; // 0xE60
        public Unity.Collections.FixedBytes16Align8 offset3680; // 0xE70
        public Unity.Collections.FixedBytes16Align8 offset3696; // 0xE80
        public Unity.Collections.FixedBytes16Align8 offset3712; // 0xE90
        public Unity.Collections.FixedBytes16Align8 offset3728; // 0xEA0
        public Unity.Collections.FixedBytes16Align8 offset3744; // 0xEB0
        public Unity.Collections.FixedBytes16Align8 offset3760; // 0xEC0
        public Unity.Collections.FixedBytes16Align8 offset3776; // 0xED0
        public Unity.Collections.FixedBytes16Align8 offset3792; // 0xEE0
        public Unity.Collections.FixedBytes16Align8 offset3808; // 0xEF0
        public Unity.Collections.FixedBytes16Align8 offset3824; // 0xF00
        public Unity.Collections.FixedBytes16Align8 offset3840; // 0xF10
        public Unity.Collections.FixedBytes16Align8 offset3856; // 0xF20
        public Unity.Collections.FixedBytes16Align8 offset3872; // 0xF30
        public Unity.Collections.FixedBytes16Align8 offset3888; // 0xF40
        public Unity.Collections.FixedBytes16Align8 offset3904; // 0xF50
        public Unity.Collections.FixedBytes16Align8 offset3920; // 0xF60
        public Unity.Collections.FixedBytes16Align8 offset3936; // 0xF70
        public Unity.Collections.FixedBytes16Align8 offset3952; // 0xF80
        public Unity.Collections.FixedBytes16Align8 offset3968; // 0xF90
        public Unity.Collections.FixedBytes16Align8 offset3984; // 0xFA0
        public Unity.Collections.FixedBytes16Align8 offset4000; // 0xFB0
        public Unity.Collections.FixedBytes16Align8 offset4016; // 0xFC0
        public Unity.Collections.FixedBytes16Align8 offset4032; // 0xFD0
        public Unity.Collections.FixedBytes16Align8 offset4048; // 0xFE0
        public Unity.Collections.FixedBytes16Align8 offset4064; // 0xFF0
        public Unity.Collections.FixedBytes16Align8 offset4080; // 0x1000
    }

    public class FixedBytes512Align8 : ValueType
    {
        public Unity.Collections.FixedBytes16Align8 offset0000; // 0x10
        public Unity.Collections.FixedBytes16Align8 offset0016; // 0x20
        public Unity.Collections.FixedBytes16Align8 offset0032; // 0x30
        public Unity.Collections.FixedBytes16Align8 offset0048; // 0x40
        public Unity.Collections.FixedBytes16Align8 offset0064; // 0x50
        public Unity.Collections.FixedBytes16Align8 offset0080; // 0x60
        public Unity.Collections.FixedBytes16Align8 offset0096; // 0x70
        public Unity.Collections.FixedBytes16Align8 offset0112; // 0x80
        public Unity.Collections.FixedBytes16Align8 offset0128; // 0x90
        public Unity.Collections.FixedBytes16Align8 offset0144; // 0xA0
        public Unity.Collections.FixedBytes16Align8 offset0160; // 0xB0
        public Unity.Collections.FixedBytes16Align8 offset0176; // 0xC0
        public Unity.Collections.FixedBytes16Align8 offset0192; // 0xD0
        public Unity.Collections.FixedBytes16Align8 offset0208; // 0xE0
        public Unity.Collections.FixedBytes16Align8 offset0224; // 0xF0
        public Unity.Collections.FixedBytes16Align8 offset0240; // 0x100
        public Unity.Collections.FixedBytes16Align8 offset0256; // 0x110
        public Unity.Collections.FixedBytes16Align8 offset0272; // 0x120
        public Unity.Collections.FixedBytes16Align8 offset0288; // 0x130
        public Unity.Collections.FixedBytes16Align8 offset0304; // 0x140
        public Unity.Collections.FixedBytes16Align8 offset0320; // 0x150
        public Unity.Collections.FixedBytes16Align8 offset0336; // 0x160
        public Unity.Collections.FixedBytes16Align8 offset0352; // 0x170
        public Unity.Collections.FixedBytes16Align8 offset0368; // 0x180
        public Unity.Collections.FixedBytes16Align8 offset0384; // 0x190
        public Unity.Collections.FixedBytes16Align8 offset0400; // 0x1A0
        public Unity.Collections.FixedBytes16Align8 offset0416; // 0x1B0
        public Unity.Collections.FixedBytes16Align8 offset0432; // 0x1C0
        public Unity.Collections.FixedBytes16Align8 offset0448; // 0x1D0
        public Unity.Collections.FixedBytes16Align8 offset0464; // 0x1E0
        public Unity.Collections.FixedBytes16Align8 offset0480; // 0x1F0
        public Unity.Collections.FixedBytes16Align8 offset0496; // 0x200
    }

    public class FixedBytes64Align8 : ValueType
    {
        public Unity.Collections.FixedBytes16Align8 offset0000; // 0x10
        public Unity.Collections.FixedBytes16Align8 offset0016; // 0x20
        public Unity.Collections.FixedBytes16Align8 offset0032; // 0x30
        public Unity.Collections.FixedBytes16Align8 offset0048; // 0x40
    }

    public class FixedList : ValueType
    {
        // ── Methods ──
        public void PaddingBytes(){} // RVA: 0x7FFAC2C59990
    }

    public class FixedList128BytesDebugView`1 : Object
    {
    }

    public class FixedList128Bytes`1 : ValueType
    {
        public Unity.Collections.FixedBytes128Align8 length;

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFAC2C58DC0
        public void get_buffer(){} // RVA: 0x7FFAC2E8DC40
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void get_LengthInBytes(){} // RVA: 0x7FFAC2C59960
        public void get_Buffer(){} // RVA: 0x7FFAC2E8DC40
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void CompareTo(){} // RVA: 0x7FFAC2E8DC40 | overloaded x5
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class FixedList32BytesDebugView`1 : Object
    {
    }

    public class FixedList32Bytes`1 : ValueType
    {
        public Unity.Collections.FixedBytes32Align8 length;

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFAC2C58DC0
        public void get_buffer(){} // RVA: 0x7FFAC2E8DC40
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void get_LengthInBytes(){} // RVA: 0x7FFAC2C59960
        public void get_Buffer(){} // RVA: 0x7FFAC2E8DC40
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void CompareTo(){} // RVA: 0x7FFAC2E8DC40 | overloaded x5
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class FixedList4096BytesDebugView`1 : Object
    {
    }

    public class FixedList4096Bytes`1 : ValueType
    {
        public Unity.Collections.FixedBytes4096Align8 length;

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFAC2C58DC0
        public void get_buffer(){} // RVA: 0x7FFAC2E8DC40
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void get_LengthInBytes(){} // RVA: 0x7FFAC2C59960
        public void get_Buffer(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void CompareTo(){} // RVA: 0x7FFAC2E8DC40 | overloaded x5
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class FixedList512BytesDebugView`1 : Object
    {
    }

    public class FixedList512Bytes`1 : ValueType
    {
        public Unity.Collections.FixedBytes512Align8 length;

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFAC2C58DC0
        public void get_buffer(){} // RVA: 0x7FFAC2E8DC40
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void get_LengthInBytes(){} // RVA: 0x7FFAC2C59960
        public void get_Buffer(){} // RVA: 0x7FFAC2E8DC40
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void CompareTo(){} // RVA: 0x7FFAC2E8DC40 | overloaded x5
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class FixedList64BytesDebugView`1 : Object
    {
    }

    public class FixedList64Bytes`1 : ValueType
    {
        public Unity.Collections.FixedBytes64Align8 length;

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFAC2C58DC0
        public void get_buffer(){} // RVA: 0x7FFAC2E8DC40
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void get_LengthInBytes(){} // RVA: 0x7FFAC2C59960
        public void get_Buffer(){} // RVA: 0x7FFAC2E8DC40
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void CompareTo(){} // RVA: 0x7FFAC2E8DC40 | overloaded x5
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class FixedStringMethods : Object
    {
        // ── Methods ──
        public void ConvertToString(){} // RVA: 0x7FFAC2C58F80
    }

    public class GenerateTestsForBurstCompatibilityAttribute : Attribute
    {
        public System.Type[] GenericTypeArguments; // 0x10

        // ── Methods ──
        public void set_GenericTypeArguments(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Hash128Long_00000A71$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC9514460
        public void GetFunctionPointer(){} // RVA: 0x7FFAC95145A0
        public void Constructor(){} // RVA: 0x7FFAC9514710
        public void Initialize(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9514710
        public void Invoke(){} // RVA: 0x7FFAC95147D0
    }

    public class Hash128Long_00000A71$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9514380
        public void Invoke(){} // RVA: 0x7FFAC5C60E20
    }

    public class Hash64Long_00000A6A$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC9513D30
        public void GetFunctionPointer(){} // RVA: 0x7FFAC9513E70
        public void Constructor(){} // RVA: 0x7FFAC9513FE0
        public void Initialize(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9513FE0
        public void Invoke(){} // RVA: 0x7FFAC95140A0
    }

    public class Hash64Long_00000A6A$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8370B30
        public void Invoke(){} // RVA: 0x7FFAC383F780
    }

    public class IIndexable`1
    {
        public object Length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFAC2C59960
    }

    public class INativeList`1
    {
    }

    public class IUTF8Bytes
    {
        // ── Methods ──
        public void GetUnsafePtr(){} // RVA: 0x7FFAC2E8DC40
    }

    public class KVPair`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.HashMapHelper`1<T>* m_Data;
        public int m_Index;
        public int m_Next;
    }

    public class ListExtensions : Object
    {
        // ── Methods ──
        public void RemoveAtSwapBack(){} // RVA: 0x7FFAC2C76370
    }

    public class Long1024 : ValueType
    {
        public Unity.Collections.Long512 Length; // 0x10
        public Unity.Collections.Long512 f1; // 0x1010

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFAC9511080
        public void ElementAt(){} // RVA: 0x7FFAC9511090
    }

    public class Long512 : ValueType
    {
        public Unity.Collections.Long64 f0; // 0x10
        public Unity.Collections.Long64 f1; // 0x210
        public Unity.Collections.Long64 f2; // 0x410
        public Unity.Collections.Long64 f3; // 0x610
        public Unity.Collections.Long64 f4; // 0x810
        public Unity.Collections.Long64 f5; // 0xA10
        public Unity.Collections.Long64 f6; // 0xC10
        public Unity.Collections.Long64 f7; // 0xE10
    }

    public class Long64 : ValueType
    {
        public Unity.Collections.Long8 f0; // 0x10
        public Unity.Collections.Long8 f1; // 0x50
        public Unity.Collections.Long8 f2; // 0x90
        public Unity.Collections.Long8 f3; // 0xD0
        public Unity.Collections.Long8 f4; // 0x110
        public Unity.Collections.Long8 f5; // 0x150
        public Unity.Collections.Long8 f6; // 0x190
        public Unity.Collections.Long8 f7; // 0x1D0
    }

    public class Long8 : ValueType
    {
        public long f0; // 0x10
        public long f1; // 0x18
        public long f2; // 0x20
        public long f3; // 0x28
        public long f4; // 0x30
        public long f5; // 0x38
        public long f6; // 0x40
        public long f7; // 0x48
    }

    public class Memory : ValueType
    {
    }

    public class NativeArrayDebugView`1 : Object
    {
    }

    public class NativeArrayDispose : ValueType
    {
        public void* m_Buffer; // 0x10
        public 0x6B177E20 m_AllocatorLabel; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC9850DA0
    }

    public class NativeArrayDisposeJob : ValueType
    {
        public Unity.Collections.NativeArrayDispose Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC9850DA0
        public void RegisterNativeArrayDisposeJobReflectionData(){} // RVA: 0x7FFAC9850E00
    }

    public class NativeArrayExtensions : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void Initialize(){} // RVA: 0x7FFAC2E8DC40
    }

    public class NativeArrayReadOnlyDebugView`1 : Object
    {
    }

    public class NativeArray`1 : ValueType
    {
        public void* Length;
        public int Item;
        public 0x6B177E20 IsCreated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void Allocate(){} // RVA: 0x7FFAC2C72740
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void get_IsCreated(){} // RVA: 0x7FFAC2C59D00
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void CopyFrom(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFAC2C58E90
        public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void Copy(){} // RVA: 0x7FFAC2E8DC40 | overloaded x5
        public void CopySafe(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void GetSubArray(){} // RVA: 0x7FFAC2E8DC40
        public void AsReadOnly(){} // RVA: 0x7FFAC2E8DC40
    }

    public class NativeBitArrayDispose : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeBitArray* m_BitArrayData; // 0x10
        public AllocatorHandle m_Allocator; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC95113E0
    }

    public class NativeBitArrayDisposeJob : ValueType
    {
        public Unity.Collections.NativeBitArrayDispose Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC95114F0
    }

    public class NativeDisableParallelForRestrictionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NativeFixedLengthAttribute : Attribute
    {
    }

    public class NativeHashMapDebuggerTypeProxy`2 : Object
    {
    }

    public class NativeHashMapDispose : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeHashMap`2<int,int>* m_HashMapData; // 0x10
        public AllocatorHandle m_Allocator; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC9511500
    }

    public class NativeHashMapDisposeJob : ValueType
    {
        public Unity.Collections.NativeHashMapDispose Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC9511680
    }

    public class NativeHashMap`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.HashMapHelper`1<T>* IsCreated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void get_IsCreated(){} // RVA: 0x7FFAC2C59D00
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void TryAdd(){} // RVA: 0x7FFAC2E8DC40
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetValue(){} // RVA: 0x7FFAC2E8DC40
        public void ContainsKey(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void GetKeyArray(){} // RVA: 0x7FFAC2E8DC40
        public void GetValueArray(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class NativeListDebugView`1 : Object
    {
    }

    public class NativeListDispose : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList* m_ListData; // 0x10

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC9511690
    }

    public class NativeListDisposeJob : ValueType
    {
        public Unity.Collections.NativeListDispose Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC9511690
    }

    public class NativeListExtensions : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
    }

    public class NativeList`1 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<T>* Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAC2C72BC0
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void set_Length(){} // RVA: 0x7FFAC2C70ED0
        public void get_Capacity(){} // RVA: 0x7FFAC2C59960
        public void Add(){} // RVA: 0x7FFAC2C70A40
        public void AddRange(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void RemoveAtSwapBack(){} // RVA: 0x7FFAC2C70ED0
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void get_IsCreated(){} // RVA: 0x7FFAC2C59D00
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void AsArray(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void SetCapacity(){} // RVA: 0x7FFAC2C70ED0
    }

    public class NativeMatchesParallelForLengthAttribute : Attribute
    {
    }

    public class NativeParallelHashMapDebuggerTypeProxy`2 : Object
    {
    }

    public class NativeParallelHashMapExtensions : Object
    {
        // ── Methods ──
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
    }

    public class NativeParallelHashMap`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap`2<T,T> IsCreated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void get_IsCreated(){} // RVA: 0x7FFAC2C59D00
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void AsParallelWriter(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class NativeParallelMultiHashMapDebuggerTypeProxy`2 : Object
    {
    }

    public class NativeParallelMultiHashMapIterator`1 : ValueType
    {
        public T key;
        public int NextEntryIndex;
        public int EntryIndex;
    }

    public class NativeParallelMultiHashMap`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelMultiHashMap`2<T,T> IsCreated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Initialize(){} // RVA: 0x7FFAC2C72BC0
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetFirstValue(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNextValue(){} // RVA: 0x7FFAC2C5D200
        public void get_IsCreated(){} // RVA: 0x7FFAC2C59D00
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class NativeQueueDispose : ValueType
    {
        public Unity.Collections.UnsafeQueue`1<int>* m_QueueData; // 0x10

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC95116D0
    }

    public class NativeQueueDisposeJob : ValueType
    {
        public Unity.Collections.NativeQueueDispose Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC95116D0
    }

    public class NativeQueue`1 : ValueType
    {
        public Unity.Collections.UnsafeQueue`1<T>* IsCreated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Enqueue(){} // RVA: 0x7FFAC2E8DC40
        public void TryDequeue(){} // RVA: 0x7FFAC2C59F60
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void get_IsCreated(){} // RVA: 0x7FFAC2C59D00
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void AsParallelWriter(){} // RVA: 0x7FFAC2E8DC40
    }

    public class NativeReferenceDispose : ValueType
    {
        public void* m_Data; // 0x10
        public AllocatorHandle m_AllocatorLabel; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC9511710
    }

    public class NativeReferenceDisposeJob : ValueType
    {
        public Unity.Collections.NativeReferenceDispose Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC9511710
    }

    public class NativeRingQueueDispose : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeRingQueue`1<int>* m_QueueData; // 0x10

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC9511750
    }

    public class NativeRingQueueDisposeJob : ValueType
    {
        public Unity.Collections.NativeRingQueueDispose Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC95118A0
    }

    public class NativeSliceDebugView`1 : Object
    {
    }

    public class NativeSliceExtensions : Object
    {
        // ── Methods ──
        public void Slice(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
    }

    public class NativeSlice`1 : ValueType
    {
        public byte* Item;
        public int Stride;
        public int Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void CopyFrom(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void get_Stride(){} // RVA: 0x7FFAC2C59960
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
    }

    public class NativeStream : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeStream IsCreated; // 0x10

        // ── Methods ──
        public void get_IsCreated(){} // RVA: 0x7FFAC5DC6CA0
        public void Dispose(){} // RVA: 0x7FFAC95118B0
        public void AllocateForEach(){} // RVA: 0x7FFAC95118C0
    }

    public class NativeStreamDispose : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeStream m_StreamData; // 0x10

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC95118B0
    }

    public class NativeStreamDisposeJob : ValueType
    {
        public Unity.Collections.NativeStreamDispose Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC95118B0
    }

    public class NativeTextDispose : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeText* m_TextData; // 0x10

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC9511910
    }

    public class NativeTextDisposeJob : ValueType
    {
        public Unity.Collections.NativeTextDispose Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC9511A30
    }

    public class ReadOnlyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RewindableAllocator : ValueType
    {
        public Unity.Collections.Spinner Handle; // 0x10
        public AllocatorHandle m_handle; // 0x14
        public Unity.Collections.UnmanagedArray`1<MemoryBlock> m_block; // 0x18
        public int m_last; // 0x28
        public int m_used; // 0x2C
        public byte m_enableBlockFree; // 0x30
        public byte m_reachMaxBlockSize; // 0x31

        // ── Methods ──
        public void Rewind(){} // RVA: 0x7FFAC9511A40
        public void Dispose(){} // RVA: 0x7FFAC9511BD0
        public void TryAllocate(){} // RVA: 0x7FFAC9511D20
        public void Try(){} // RVA: 0x7FFAC95121F0 | overloaded x2
        public void get_Handle(){} // RVA: 0x7FFAC44202A0
        public void Try$BurstManaged(){} // RVA: 0x7FFAC9512250
    }

    public class Spinner : ValueType
    {
        public int m_Lock; // 0x10

        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFAC950E5E0
        public void Release(){} // RVA: 0x7FFAC950E600
    }

    public class Try_000000E3$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC9510A90
        public void GetFunctionPointer(){} // RVA: 0x7FFAC9510BD0
        public void Constructor(){} // RVA: 0x7FFAC9510D40
        public void Initialize(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9510D40
        public void Invoke(){} // RVA: 0x7FFAC9510E00
    }

    public class Try_000000E3$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class Try_000009DF$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC95123C0
        public void GetFunctionPointer(){} // RVA: 0x7FFAC9512500
        public void Constructor(){} // RVA: 0x7FFAC9512670
        public void Initialize(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9512670
        public void Invoke(){} // RVA: 0x7FFAC9512730
    }

    public class Try_000009DF$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class Unicode : ValueType
    {
        public object ReplacementCharacter;

        // ── Methods ──
        public void IsValidCodePoint(){} // RVA: 0x7FFAC9512940
        public void NotTrailer(){} // RVA: 0x7FFAC9512950
        public void get_ReplacementCharacter(){} // RVA: 0x7FFAC8A836C0
        public void Utf8ToUcs(){} // RVA: 0x7FFAC9512960
        public void UcsToUtf16(){} // RVA: 0x7FFAC9512B50
        public void Utf8ToUtf16(){} // RVA: 0x7FFAC9512BF0
    }

    public class UnmanagedArray`1 : ValueType
    {
        public UIntPtr Item;
        public int m_length;
        public AllocatorHandle m_allocator;

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void get_Item(){} // RVA: 0x7FFAC2C67DE0
    }

    public class UnsafeQueueBlockHeader : ValueType
    {
        public Unity.Collections.UnsafeQueueBlockHeader* m_NextBlock; // 0x10
        public int m_NumItems; // 0x18
    }

    public class UnsafeQueueData : ValueType
    {
        public int m_BlockSize;
        public UIntPtr m_FirstBlock; // 0x10
        public UIntPtr m_LastBlock; // 0x18
        public int m_MaxItems; // 0x20
        public int m_CurrentRead; // 0x24
        public byte* m_CurrentWriteBlockTLS; // 0x28

        // ── Methods ──
        public void GetCurrentWriteBlockTLS(){} // RVA: 0x7FFAC9512D80
        public void SetCurrentWriteBlockTLS(){} // RVA: 0x7FFAC9512D90
        public void AllocateWriteBlockMT(){} // RVA: 0x7FFAC2E8DC40
        public void AllocateQueue(){} // RVA: 0x7FFAC2E8DC40
        public void DeallocateQueue(){} // RVA: 0x7FFAC9512DA0
    }

    public class UnsafeQueueDispose : ValueType
    {
        public Unity.Collections.UnsafeQueueData* m_Buffer; // 0x10
        public AllocatorHandle m_AllocatorLabel; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC9512F10
    }

    public class UnsafeQueueDisposeJob : ValueType
    {
        public Unity.Collections.UnsafeQueueDispose Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC9512F10
    }

    public class UnsafeQueue`1 : ValueType
    {
        public Unity.Collections.UnsafeQueueData* IsCreated;
        public AllocatorHandle m_AllocatorLabel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Alloc(){} // RVA: 0x7FFAC2E8DC40
        public void Free(){} // RVA: 0x7FFAC2E8DC40
        public void Enqueue(){} // RVA: 0x7FFAC2E8DC40
        public void TryDequeue(){} // RVA: 0x7FFAC2C59F60
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void get_IsCreated(){} // RVA: 0x7FFAC2C59D00
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void AsParallelWriter(){} // RVA: 0x7FFAC2E8DC40
    }

    public class WriteOnlyAttribute : Attribute
    {
    }

    public class xxHash3 : Object
    {
        // ── Methods ──
        public void Avx2HashLongInternalLoop(){} // RVA: 0x7FFAC35D2DD0
        public void Avx2ScrambleAcc(){} // RVA: 0x7FFAC35D2DD0
        public void Avx2Accumulate(){} // RVA: 0x7FFAC35D2DD0
        public void Avx2Accumulate512(){} // RVA: 0x7FFAC35D2DD0
        public void Hash64Long(){} // RVA: 0x7FFAC9512F20
        public void Hash128Long(){} // RVA: 0x7FFAC9512FB0
        public void ToUint4(){} // RVA: 0x7FFAC9513040
        public void Read64LE(){} // RVA: 0x7FFAC3AD9F60
        public void Write64LE(){} // RVA: 0x7FFAC45BB120
        public void Mul32To64(){} // RVA: 0x7FFAC85B6350
        public void XorShift64(){} // RVA: 0x7FFAC8F93F70
        public void Mul128Fold64(){} // RVA: 0x7FFAC9513060
        public void Avalanche(){} // RVA: 0x7FFAC8F93BB0
        public void Mix2Acc(){} // RVA: 0x7FFAC95130C0
        public void MergeAcc(){} // RVA: 0x7FFAC9513120
        public void DefaultHashLongInternalLoop(){} // RVA: 0x7FFAC9513310
        public void DefaultAccumulate(){} // RVA: 0x7FFAC95136A0
        public void DefaultAccumulate512(){} // RVA: 0x7FFAC9513880
        public void DefaultScrambleAcc(){} // RVA: 0x7FFAC95139E0
        public void Hash64Long$BurstManaged(){} // RVA: 0x7FFAC9513AC0
        public void Hash128Long$BurstManaged(){} // RVA: 0x7FFAC9513BE0
    }

}