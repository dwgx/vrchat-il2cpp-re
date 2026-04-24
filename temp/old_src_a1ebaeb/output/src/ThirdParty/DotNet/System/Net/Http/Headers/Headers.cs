// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Http.Headers
// Classes: 10
// Methods: 62

namespace ThirdParty.DotNet.System.Net.Http.Headers
{
    public class CollectionExtensions : Object
    {
        // ── Original Methods ──
        public void SequenceEqual(){} // RVA: 0x7ffaa864a690
        public void ToString(){} // RVA: 0x7ffaa86492c0
        public void ToStringBuilder(){} // RVA: 0x7ffaa8660fc0
        // ── Binary Analysis Named ──
        public void SetValue(){} // RVA: 0x7ffaae9c51e0
    }

    public class CollectionParser : Object
    {
        // ── Original Methods ──
        public void TryParse(){} // RVA: 0x7ffaae9c5460
        public void TryParse(){} // RVA: 0x7ffaae9c5460
        public void TryParseStringElement(){} // RVA: 0x7ffaae9c5520
    }

    public class ElementTryParser`1 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void Invoke(){}
    }

    public class HashCodeCalculator : Object
    {
        // ── Original Methods ──
        public void Calculate(){} // RVA: 0x7ffaa8649d80
    }

    public class HeaderInfo : Object
    {
        public object Name; // 0x30E046F0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae9c7960
        public void CreateSingle(){} // RVA: 0x7ffaa865afc0
        public void CreateMulti(){} // RVA: 0x7ffaa887e5c0
        public void CreateCollection(){} // RVA: 0x7ffaa865aa30
        public void get_CustomToString(){} // RVA: 0x7ffaa89600c0
        public void set_CustomToString(){} // RVA: 0x7ffaa89600d0
        public void get_Separator(){} // RVA: 0x7ffaae9c79e0
        public void AddToCollection(){} // RVA: 0x7ffaa8669e70
        public void CreateCollection(){} // RVA: 0x7ffaa865aa30
        public void ToStringCollection(){} // RVA: 0x7ffaa8649280
        public void TryParse(){} // RVA: 0x7ffaa864d540
    }

    public class HttpHeaderValueCollection`1 : Object
    {
        public object headerInfo; // 0x310250B0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8669e70
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void get_InvalidValues(){} // RVA: 0x7ffaa86491d0
        public void get_IsReadOnly(){} // RVA: 0x7ffaa864a040
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void AddRange(){} // RVA: 0x7ffaa8660d80
        public void AddInvalidValue(){} // RVA: 0x7ffaa8660d80
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void Contains(){} // RVA: 0x7ffaa887e5c0
        public void CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void ToString(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void Find(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa86491d0
    }

    public class HttpHeaders : Object
    {
        public object HeaderKind; // 0x317913C0

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaae9c7ff0
        public void .ctor(){} // RVA: 0x7ffaae9cac90
        public void .ctor(){} // RVA: 0x7ffaae9cac90
        public void Add(){} // RVA: 0x7ffaae9cae80
        public void Add(){} // RVA: 0x7ffaae9cae80
        public void AddInternal(){} // RVA: 0x7ffaae9caf20
        public void TryAddWithoutValidation(){} // RVA: 0x7ffaae9cb3d0
        public void TryCheckName(){} // RVA: 0x7ffaae9cb620
        public void Contains(){} // RVA: 0x7ffaae9cb7a0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaae9cb8c0
        public void Remove(){} // RVA: 0x7ffaae9cb8d0
        public void TryGetValues(){} // RVA: 0x7ffaae9cb940
        public void ToString(){} // RVA: 0x7ffaae9cbea0
        public void AddOrRemove(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void CheckName(){} // RVA: 0x7ffaae9cb4a0
        public void GetEnumerator(){} // RVA: 0x7ffaae9cb820
        public void GetSingleHeaderString(){} // RVA: 0x7ffaae9cbb00
        public void GetAllHeaderValues(){} // RVA: 0x7ffaae9cc180
        public void GetKnownHeaderKind(){} // RVA: 0x7ffaae9cc360
        public void GetValue(){} // RVA: 0x7ffaa887e5c0
        public void GetValues(){} // RVA: 0x7ffaa8649280
        public void SetValue(){} // RVA: 0x7ffaa887e5c0
    }

    public class TryParseDelegate`1 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7ffaa864d540
    }

    public class TryParseDelegate`1 : MulticastDelegate
    {
    }

    public class TryParseListDelegate`1 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void Invoke(){}
    }

}