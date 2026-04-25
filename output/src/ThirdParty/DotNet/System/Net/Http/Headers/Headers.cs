// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Http.Headers
// Classes: 9
// Methods: 62

namespace ThirdParty.DotNet.System.Net.Http.Headers
{
    public class CollectionExtensions : Object
    {
        // ── Methods ──
        public void SequenceEqual(){} // RVA: 0x7FFD4E07A350
        public void SetValue(){} // RVA: 0x7FFD543C3210
        public void ToString(){} // RVA: 0x7FFD4E078F80
        public void ToStringBuilder(){} // RVA: 0x7FFD4E090C80
    }

    public class CollectionParser : Object
    {
        // ── Methods ──
        public void TryParse(){} // RVA: 0x7FFD543C3490 | overloaded x2
        public void TryParseStringElement(){} // RVA: 0x7FFD543C3550
    }

    public class ElementTryParser`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){}
    }

    public class HashCodeCalculator : Object
    {
        // ── Methods ──
        public void Calculate(){} // RVA: 0x7FFD4E079A40
    }

    public class HeaderInfo : Object
    {
        public object CustomToString;
        public object Separator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD543C5990
        public void CreateSingle(){} // RVA: 0x7FFD4E08AC80
        public void CreateMulti(){} // RVA: 0x7FFD4E2ADC40
        public void CreateCollection(){} // RVA: 0x7FFD4E08A6F0 | overloaded x2
        public void get_CustomToString(){} // RVA: 0x7FFD4E36F0C0
        public void set_CustomToString(){} // RVA: 0x7FFD4E36F0D0
        public void get_Separator(){} // RVA: 0x7FFD543C5A10
        public void AddToCollection(){} // RVA: 0x7FFD4E099B30
        public void ToStringCollection(){} // RVA: 0x7FFD4E078F40
        public void TryParse(){} // RVA: 0x7FFD4E07D200
    }

    public class HttpHeaderValueCollection`1 : Object
    {
        public object Count;
        public object InvalidValues;
        public object IsReadOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_InvalidValues(){} // RVA: 0x7FFD4E078E90
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void AddRange(){} // RVA: 0x7FFD4E090A40
        public void AddInvalidValue(){} // RVA: 0x7FFD4E090A40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void Find(){} // RVA: 0x7FFD4E2ADC40
    }

    public class HttpHeaders : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD543C6020
        public void .ctor(){} // RVA: 0x7FFD543C8CC0 | overloaded x2
        public void Add(){} // RVA: 0x7FFD543C8EB0 | overloaded x2
        public void AddInternal(){} // RVA: 0x7FFD543C8F50
        public void TryAddWithoutValidation(){} // RVA: 0x7FFD543C9400
        public void CheckName(){} // RVA: 0x7FFD543C94D0
        public void TryCheckName(){} // RVA: 0x7FFD543C9650
        public void Contains(){} // RVA: 0x7FFD543C97D0
        public void GetEnumerator(){} // RVA: 0x7FFD543C9850
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD543C98F0
        public void Remove(){} // RVA: 0x7FFD543C9900
        public void TryGetValues(){} // RVA: 0x7FFD543C9970
        public void GetSingleHeaderString(){} // RVA: 0x7FFD543C9B30
        public void ToString(){} // RVA: 0x7FFD543C9ED0
        public void AddOrRemove(){} // RVA: 0x7FFD4E2ADC40
        public void GetAllHeaderValues(){} // RVA: 0x7FFD543CA1B0
        public void GetKnownHeaderKind(){} // RVA: 0x7FFD543CA390
        public void GetValue(){} // RVA: 0x7FFD4E2ADC40
        public void GetValues(){} // RVA: 0x7FFD4E078F40
        public void SetValue(){} // RVA: 0x7FFD4E2ADC40
    }

    public class TryParseDelegate`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E07D200
    }

    public class TryParseListDelegate`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){}
    }

}