// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization.Converters
// Classes: 18
// Methods: 86

namespace ThirdParty.DotNet.System.Text.Json.Serialization.Converters
{
    public class SByteConverter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DD4590
        public void Read(){} // RVA: 0x6DD45E0
        public void Write(){} // RVA: 0x6DD4640
        public void ReadAsPropertyNameCore(){} // RVA: 0x6DD4670
        public void WriteAsPropertyNameCore(){} // RVA: 0x6DD4680
        public void ReadNumberWithCustomHandling(){} // RVA: 0x6DD46B0
        public void WriteNumberWithCustomHandling(){} // RVA: 0x6DD4730
    }

    public class SByteConverter : JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7349A40
        public void Read(){} // RVA: 0x7349AA0
        public void Write(){} // RVA: 0x7349AE0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7349B40
        public void WriteAsPropertyNameCore(){} // RVA: 0x7349B90
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7349BC0
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7349C30
    }

    public class SingleConverter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DD4770
        public void Read(){} // RVA: 0x6DD47C0
        public void Write(){} // RVA: 0x6DD4820
        public void ReadAsPropertyNameCore(){} // RVA: 0x6DD4850
        public void WriteAsPropertyNameCore(){} // RVA: 0x6DD4860
        public void ReadNumberWithCustomHandling(){} // RVA: 0x6DD4890
        public void WriteNumberWithCustomHandling(){} // RVA: 0x6DD4920
    }

    public class SingleConverter : JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7349CB0
        public void Read(){} // RVA: 0x7349D10
        public void Write(){} // RVA: 0x7349D50
        public void ReadAsPropertyNameCore(){} // RVA: 0x7349D80
        public void WriteAsPropertyNameCore(){} // RVA: 0x7349D90
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7349DC0
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7349E30
    }

    public class SlimObjectConverter : ObjectConverter
    {
        public object _originatingResolver;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73469C0
        public void Read(){} // RVA: 0x7346A60
    }

    public class SmallObjectWithParameterizedConstructorConverter`5 : ObjectWithParameterizedConstructorConverter`1
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x87C540
        public void ReadAndCacheConstructorArgument(){} // RVA: 0x87D710
        public void TryRead(){} // RVA: 0x87D760
        public void InitializeConstructorArgumentCaches(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0x894290
    }

    public class SmallObjectWithParameterizedConstructorConverter`5 : ObjectWithParameterizedConstructorConverter`1
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x4AD6950
        public void ReadAndCacheConstructorArgument(){} // RVA: 0x4AD6D40
        public void TryRead(){} // RVA: 0x87D760
        public void InitializeConstructorArgumentCaches(){} // RVA: 0x4AD6F90
        public void .ctor(){} // RVA: 0x4121390
    }

    public class SmallObjectWithParameterizedConstructorConverter`5 : ObjectWithParameterizedConstructorConverter`1
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x87C540
        public void ReadAndCacheConstructorArgument(){} // RVA: 0x87D710
        public void TryRead(){} // RVA: 0x880CD0
        public void InitializeConstructorArgumentCaches(){} // RVA: 0x8943B0
        public void ConfigureJsonTypeInfoUsingReflection(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0x894290
    }

    public class StackOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x8943B0
        public void CreateCollection(){} // RVA: 0x8954D0
        public void .ctor(){} // RVA: 0x894290
    }

    public class StackOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x87D280
        public void Add(){} // RVA: 0x8943B0
        public void CreateCollection(){} // RVA: 0x8954D0
        public void .ctor(){} // RVA: 0x894290
    }

    public class StackOrQueueConverterWithReflection`1 : StackOrQueueConverter`1
    {
        // ── Methods ──
        public void get_RequiresDynamicMemberAccessors(){} // RVA: 0x87D280
        public void .ctor(){} // RVA: 0x894290
        public void Initialize(){} // RVA: 0x8943B0
    }

    public class StackOrQueueConverterWithReflection`1 : StackOrQueueConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void ConfigureJsonTypeInfoUsingReflection(){} // RVA: 0x8943B0
    }

    public class StackOrQueueConverter`1 : JsonCollectionConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x8943B0
        public void CreateCollection(){} // RVA: 0x8954D0
        public void OnWriteResume(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
    }

    public class StackOrQueueConverter`1 : JsonCollectionConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x4B45D80
        public void CreateCollection(){} // RVA: 0x4B45FC0
        public void OnWriteResume(){} // RVA: 0x4B46080
        public void .ctor(){} // RVA: 0x428AEF0
    }

    public class StackOrQueueConverter`1 : JsonCollectionConverter`2
    {
        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x87D280
        public void Add(){} // RVA: 0x8943B0
        public void CreateCollection(){} // RVA: 0x8954D0
        public void OnWriteResume(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
    }

    public class StackOrQueueConverter`1 : JsonCollectionConverter`2
    {
        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0xC2E4C0
        public void Add(){} // RVA: 0x4B46420
        public void CreateCollection(){} // RVA: 0x4B46660
        public void OnWriteResume(){} // RVA: 0x4B46780
        public void .ctor(){} // RVA: 0x428AEF0
    }

    public class StringConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x6DD4970
        public void Write(){} // RVA: 0x6DD4980
        public void ReadAsPropertyNameCore(){} // RVA: 0x6DD4970
        public void WriteAsPropertyNameCore(){} // RVA: 0x6DD4A30
        public void .ctor(){} // RVA: 0x6DD4B80
    }

    public class StringConverter : JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7349E80
        public void Write(){} // RVA: 0x7349E90
        public void ReadAsPropertyNameCore(){} // RVA: 0x7349E80
        public void WriteAsPropertyNameCore(){} // RVA: 0x7349F30
        public void .ctor(){} // RVA: 0x734A000
    }

}