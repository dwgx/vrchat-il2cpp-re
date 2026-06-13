// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 92
// Methods: 639

namespace ThirdParty.DotNet.System
{
    public class Random
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5EAFFA0 | overloaded x2
        public void Sample(){} // RVA: 0x5EB01D0
        public void InternalSample(){} // RVA: 0x5EB01F0
        public void GenerateSeed(){} // RVA: 0x5EB0280
        public void GenerateGlobalSeed(){} // RVA: 0x5E96E00
        public void Next(){} // RVA: 0x5EB0730 | overloaded x3
        public void GetSampleForLargeRange(){} // RVA: 0x5EB05A0
        public void NextDouble(){} // RVA: 0x391BC0
        public void NextBytes(){} // RVA: 0x5EB07F0
        public void .cctor(){} // RVA: 0x5EB0910
    }

    public class Range
    {
        public System.Index <Start>k__BackingField; // 0x10
        public System.Index <End>k__BackingField; // 0x14

        // ── Methods ──
        public void get_Start(){} // RVA: 0x19689B0
        public void get_End(){} // RVA: 0x19689E0
        public void Equals(){} // RVA: 0x5EB0A70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5EB0A90
        public void ToString(){} // RVA: 0x5EB0C60
    }

    public class Range
    {
        public System.Index <Start>k__BackingField; // 0x10
        public System.Index <End>k__BackingField; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x644C8F0 | overloaded x2
        public void get_EqualityContract(){} // RVA: 0x644C1A0
        public void get_Start(){} // RVA: 0x32A5C0
        public void set_Start(){} // RVA: 0x2E00C0
        public void get_End(){} // RVA: 0x8ABED0
        public void set_End(){} // RVA: 0x8AC660
        public void ToString(){} // RVA: 0x644C250
        public void StartAt(){} // RVA: 0x644C320
        public void EndAt(){} // RVA: 0x644C370
        public void get_All(){} // RVA: 0x644C3C0
        public void GetOffsetAndLength(){} // RVA: 0x644C410
        public void PrintMembers(){} // RVA: 0x644C4E0
        public void op_Inequality(){} // RVA: 0x1D77880
        public void op_Equality(){} // RVA: 0x1D778C0
        public void GetHashCode(){} // RVA: 0x644C5A0
        public void Equals(){} // RVA: 0x644C750 | overloaded x2
        public void <Clone>$(){} // RVA: 0x644C890
        public void Deconstruct(){} // RVA: 0x644C910
    }

    public class RankException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x3
    }

    public class ReadOnlyMemory`1
    {
        public object Length;
        public int Span;
        public int _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x3
        public void op_Implicit(){} // RVA: 0x283FA0
        public void get_Empty(){} // RVA: 0x283FA0
        public void get_Length(){} // RVA: 0xD840
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void ToString(){} // RVA: 0xCD60
        public void Slice(){} // RVA: 0x283FA0 | overloaded x2
        public void get_Span(){} // RVA: 0x283FA0
        public void ToArray(){} // RVA: 0xCD60
        public void Equals(){} // RVA: 0x283FA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0xD840
        public void CombineHashCodes(){} // RVA: 0x13CA0 | overloaded x2
        public void GetObjectStartLength(){} // RVA: 0x1E6A0
    }

    public class ReadOnlyMemory`1
    {
        public object _object;
        public int _index;
        public int _length;
        public int RemoveFlagsBitMask;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x3
        public void op_Implicit(){} // RVA: 0x283FA0 | overloaded x2
        public void get_Empty(){} // RVA: 0x283FA0
        public void get_Length(){} // RVA: 0xD840
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void ToString(){} // RVA: 0xCD60
        public void Slice(){} // RVA: 0x283FA0 | overloaded x2
        public void get_Span(){} // RVA: 0x283FA0
        public void Pin(){} // RVA: 0x283FA0
        public void ToArray(){} // RVA: 0xCD60
        public void Equals(){} // RVA: 0x283FA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0xD840
        public void CombineHashCodes(){} // RVA: 0x13CA0 | overloaded x2
        public void GetObjectStartLength(){} // RVA: 0x1E6A0
    }

    public class ReadOnlyMemory`1
    {
        public object _object; // 0x10
        public int _index; // 0x18
        public int _length; // 0x1C
        public int RemoveFlagsBitMask;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3C214B0 | overloaded x3
        public void op_Implicit(){} // RVA: 0x3F0EE70 | overloaded x2
        public void get_Empty(){} // RVA: 0x1529E90
        public void get_Length(){} // RVA: 0x3C216E0
        public void get_IsEmpty(){} // RVA: 0x3F0EF90
        public void ToString(){} // RVA: 0x3F17110
        public void Slice(){} // RVA: 0x3F0F2A0 | overloaded x2
        public void get_Span(){} // RVA: 0x3F17410
        public void Pin(){} // RVA: 0x3F17810
        public void ToArray(){} // RVA: 0x3F17C20
        public void Equals(){} // RVA: 0x3C22690 | overloaded x2
        public void GetHashCode(){} // RVA: 0x3F0FEB0
        public void CombineHashCodes(){} // RVA: 0x3C22790 | overloaded x2
        public void GetObjectStartLength(){} // RVA: 0x3F0FF80
    }

    public class ReadOnlyMemory`1
    {
        public object _object; // 0x10
        public int _index; // 0x18
        public int _length; // 0x1C
        public int RemoveFlagsBitMask;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3C214B0 | overloaded x3
        public void op_Implicit(){} // RVA: 0x3F0EE70 | overloaded x2
        public void get_Empty(){} // RVA: 0x1529E90
        public void get_Length(){} // RVA: 0x3C216E0
        public void get_IsEmpty(){} // RVA: 0x3F0EF90
        public void ToString(){} // RVA: 0x3F186D0
        public void Slice(){} // RVA: 0x3F0F2A0 | overloaded x2
        public void get_Span(){} // RVA: 0x3F189D0
        public void Pin(){} // RVA: 0x3F18DD0
        public void ToArray(){} // RVA: 0x3F191E0
        public void Equals(){} // RVA: 0x3C22690 | overloaded x2
        public void GetHashCode(){} // RVA: 0x3F0FEB0
        public void CombineHashCodes(){} // RVA: 0x3C22790 | overloaded x2
        public void GetObjectStartLength(){} // RVA: 0x3F0FF80
    }

    public class ReadOnlyMemory`1
    {
        public object _object; // 0x10
        public int _index; // 0x18
        public int _length; // 0x1C
        public int RemoveFlagsBitMask;
    }

    public class ReadOnlyMemory`1
    {
        public object _object; // 0x10
        public int _index; // 0x18
        public int _length; // 0x1C
        public int RemoveFlagsBitMask;
    }

    public class ReadOnlyMemory`1
    {
        public object _object; // 0x10
        public int _index; // 0x18
        public int _length; // 0x1C
        public int RemoveFlagsBitMask;
    }

    public class ReadOnlyMemory`1
    {
        public object _object; // 0x10
        public int _index; // 0x18
        public int _length; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3C214B0 | overloaded x3
        public void op_Implicit(){} // RVA: 0x3C21520
        public void get_Empty(){} // RVA: 0x1529E90
        public void get_Length(){} // RVA: 0x3C216E0
        public void get_IsEmpty(){} // RVA: 0x3F0EF90
        public void ToString(){} // RVA: 0x3F163C0
        public void Slice(){} // RVA: 0x3F16760 | overloaded x2
        public void get_Span(){} // RVA: 0x3F16800
        public void ToArray(){} // RVA: 0x3F16E90
        public void Equals(){} // RVA: 0x3C22690 | overloaded x2
        public void GetHashCode(){} // RVA: 0x3C2C010
        public void CombineHashCodes(){} // RVA: 0x3C22790 | overloaded x2
        public void GetObjectStartLength(){} // RVA: 0x3F0FF80
    }

    public class ReadOnlyMemory`1
    {
        public object _object; // 0x10
        public int _index; // 0x18
        public int _length; // 0x1C
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<T> _pointer;
        public int _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2BAA0 | overloaded x4
        public void get_Item(){} // RVA: 0x1BCC0
        public void GetPinnableReference(){} // RVA: 0xCD60
        public void CopyTo(){} // RVA: 0x283FA0
        public void TryCopyTo(){} // RVA: 0x283FA0
        public void op_Equality(){} // RVA: 0x283FA0
        public void ToString(){} // RVA: 0xCD60
        public void Slice(){} // RVA: 0x283FA0 | overloaded x2
        public void ToArray(){} // RVA: 0xCD60
        public void get_Length(){} // RVA: 0xD840
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void Equals(){} // RVA: 0xDE40
        public void GetHashCode(){} // RVA: 0xD840
        public void op_Implicit(){} // RVA: 0x283FA0
        public void get_Empty(){} // RVA: 0x283FA0
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<byte> HasValue; // 0x10
        public int Value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5B50 | overloaded x4
        public void get_Item(){} // RVA: 0x3F37E40
        public void GetPinnableReference(){} // RVA: 0x3F337A0
        public void CopyTo(){} // RVA: 0x3F37E60
        public void TryCopyTo(){} // RVA: 0x3F37F10
        public void op_Equality(){} // RVA: 0x3F338D0
        public void ToString(){} // RVA: 0x3F3F970
        public void Slice(){} // RVA: 0x5BEF90 | overloaded x2
        public void ToArray(){} // RVA: 0x3F38290
        public void get_Length(){} // RVA: 0x1EA9890
        public void get_IsEmpty(){} // RVA: 0x34B3520
        public void Equals(){} // RVA: 0x3F33D30
        public void GetHashCode(){} // RVA: 0x3F33D80
        public void op_Implicit(){} // RVA: 0x3F33DD0
        public void get_Empty(){} // RVA: 0x1529E90
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<char> _pointer; // 0x10
        public int _length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5B50 | overloaded x4
        public void get_Item(){} // RVA: 0x3F40920
        public void GetPinnableReference(){} // RVA: 0x3F337A0
        public void CopyTo(){} // RVA: 0x3F40940
        public void TryCopyTo(){} // RVA: 0x3F409F0
        public void op_Equality(){} // RVA: 0x3F338D0
        public void ToString(){} // RVA: 0x3F40AA0
        public void Slice(){} // RVA: 0x3F40D70 | overloaded x2
        public void ToArray(){} // RVA: 0x3F40DE0
        public void get_Length(){} // RVA: 0x1EA9890
        public void get_IsEmpty(){} // RVA: 0x34B3520
        public void Equals(){} // RVA: 0x3F33D30
        public void GetHashCode(){} // RVA: 0x3F33D80
        public void op_Implicit(){} // RVA: 0x3F33DD0
        public void get_Empty(){} // RVA: 0x1529E90
    }

    public class ReadOnlySpan`1
    {
        public System.Pinnable`1<T> RequiresDynamicMemberAccessors;
        public UIntPtr _byteOffset;
        public int _length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0xD840
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void Equals(){} // RVA: 0xDE40
        public void GetHashCode(){} // RVA: 0xD840
        public void op_Implicit(){} // RVA: 0x283FA0
        public void get_Empty(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x4
        public void get_Item(){} // RVA: 0x1BCC0
        public void GetPinnableReference(){} // RVA: 0xCD60
        public void CopyTo(){} // RVA: 0x283FA0
        public void TryCopyTo(){} // RVA: 0x283FA0
        public void ToString(){} // RVA: 0xCD60
        public void Slice(){} // RVA: 0x283FA0 | overloaded x2
        public void ToArray(){} // RVA: 0xCD60
        public void DangerousGetPinnableReference(){} // RVA: 0xCD60
        public void get_Pinnable(){} // RVA: 0xCD60
        public void get_ByteOffset(){} // RVA: 0xCD60
    }

    public class ReadOnlySpan`1
    {
        public System.Pinnable`1<byte> _pinnable; // 0x10
        public UIntPtr _byteOffset; // 0x18
        public int _length; // 0x20

        // ── Methods ──
        public void get_Length(){} // RVA: 0x32A5C0
        public void get_IsEmpty(){} // RVA: 0x355E190
        public void Equals(){} // RVA: 0x3F3EBD0
        public void GetHashCode(){} // RVA: 0x3F3EC40
        public void op_Implicit(){} // RVA: 0x3F3ECB0
        public void get_Empty(){} // RVA: 0x3F3ED10
        public void .ctor(){} // RVA: 0x3F3F0A0 | overloaded x4
        public void get_Item(){} // RVA: 0x3F3F100
        public void GetPinnableReference(){} // RVA: 0x3F3F130
        public void CopyTo(){} // RVA: 0x3F3F160
        public void TryCopyTo(){} // RVA: 0x3F3F1C0
        public void ToString(){} // RVA: 0x3F3F2D0
        public void Slice(){} // RVA: 0x3F3F6C0 | overloaded x2
        public void ToArray(){} // RVA: 0x3F3F770
        public void DangerousGetPinnableReference(){} // RVA: 0x3F3F950
        public void get_Pinnable(){} // RVA: 0x1AD4690
        public void get_ByteOffset(){} // RVA: 0x19689C0
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<UnityEngine.GameObject[]> <5; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<int> _pointer; // 0x10
        public int _length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5B50 | overloaded x4
        public void get_Item(){} // RVA: 0x3F369C0
        public void GetPinnableReference(){} // RVA: 0x3F337A0
        public void CopyTo(){} // RVA: 0x3F369E0
        public void TryCopyTo(){} // RVA: 0x3F36A90
        public void op_Equality(){} // RVA: 0x3F338D0
        public void ToString(){} // RVA: 0x3F42DC0
        public void Slice(){} // RVA: 0x3F36E10 | overloaded x2
        public void ToArray(){} // RVA: 0x3F36E80
        public void get_Length(){} // RVA: 0x1EA9890
        public void get_IsEmpty(){} // RVA: 0x34B3520
        public void Equals(){} // RVA: 0x3F33D30
        public void GetHashCode(){} // RVA: 0x3F33D80
        public void op_Implicit(){} // RVA: 0x3F33DD0
        public void get_Empty(){} // RVA: 0x1529E90
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÌÍÏÏÍÎÎÌÎÏÎÌÌÍÍÍÌÏÍÎÌÍÎ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<System.ValueTuple`2<int,ÌÍÏÏÍÎÎÌÎÏÎÌÌÍÍÍÌÏÍÎÌÍÎ>> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÌÏÏÍÏÎÌÌÏÏÎÎÏÎÎÌÏÎÏÍÌÌÍ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<string> _pointer; // 0x10
        public int _length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5B50 | overloaded x4
        public void get_Item(){} // RVA: 0x3F33EB0
        public void GetPinnableReference(){} // RVA: 0x3F337A0
        public void CopyTo(){} // RVA: 0x3F337B0
        public void TryCopyTo(){} // RVA: 0x3F33840
        public void op_Equality(){} // RVA: 0x3F338D0
        public void ToString(){} // RVA: 0x3F45AC0
        public void Slice(){} // RVA: 0x3F34300 | overloaded x2
        public void ToArray(){} // RVA: 0x3F35CC0
        public void get_Length(){} // RVA: 0x1EA9890
        public void get_IsEmpty(){} // RVA: 0x34B3520
        public void Equals(){} // RVA: 0x3F33D30
        public void GetHashCode(){} // RVA: 0x3F33D80
        public void op_Implicit(){} // RVA: 0x3F33DD0
        public void get_Empty(){} // RVA: 0x1529E90
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<string[]> <5; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÌÎÎÍÍÌÏÍÎÏÏÌÍÎÍÏÌÍÏÍÎÎÍ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÎÍÏÎÏÎÎÏÍÎÏÏÎÌÎÎÌÍÏÌÎÏÍ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ZLogger.InterpolatedStringParameter> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<System.TimeZoneInfo> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<VRC.SDKBase.VRC_SceneDescriptor> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<UnityEngine.Object> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<object> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÎÎÏÍÏÌÎÎÎÌÎÍÎÏÍÍÏÎÍÍÎÍÌ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<Discord.Sdk.UserHandle> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<UnityEngine.Transform> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÎÌÏÏÍÎÍÎÌÍÎÌÍÌÌÎÎÎÍÎÏÏÏ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÎÌÏÏÍÎÍÎÌÍÎÌÍÌÌÎÎÎÍÎÏÏÏ[]> <5; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÌÏÍÌÍÍÏÌÌÍÎÍÏÍÏÏÎÌÏÏÏÍÎ> _pointer; // 0x10
        public int _length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5B50 | overloaded x4
        public void get_Item(){} // RVA: 0x3F33EB0
        public void GetPinnableReference(){} // RVA: 0x3F337A0
        public void CopyTo(){} // RVA: 0x3F337B0
        public void TryCopyTo(){} // RVA: 0x3F33840
        public void op_Equality(){} // RVA: 0x3F338D0
        public void ToString(){} // RVA: 0x3F45AC0
        public void Slice(){} // RVA: 0x3F34300 | overloaded x2
        public void ToArray(){} // RVA: 0x3F35CC0
        public void get_Length(){} // RVA: 0x1EA9890
        public void get_IsEmpty(){} // RVA: 0x34B3520
        public void Equals(){} // RVA: 0x3F33D30
        public void GetHashCode(){} // RVA: 0x3F33D80
        public void op_Implicit(){} // RVA: 0x3F33DD0
        public void get_Empty(){} // RVA: 0x1529E90
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÏÎÌÎÏÍÎÎÍÌÌÎÌÌÌÌÏÎÏÍÌÎÌ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÍÍÍÏÍÏÎÏÎÌÌÌÏÍÌÏÍÌÌÎÎÌÍ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<EmojiParticleSystem> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÎÌÍÎÎÎÌÍÌÍÌÎÏÎÎÍÏÌÎÌÏÏÍ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<VRC.Core.ApiPurchase> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÏÍÎÏÌÎÎÌÏÏÎÌÎÍÍÌÍÍÍÏÌÌÍ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÌÌÏÌÎÌÏÎÌÍÏÍÌÌÌÎÍÏÏÏÍÏÍ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÏÍÌÏÌÏÍÌÍÏÌÍÌÌÎÎÌÎÎÍÌÏÎ<System.Collections.IList>> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<VRC.Core.ApiInventoryItem> _pointer; // 0x10
        public int _length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5B50 | overloaded x4
        public void get_Item(){} // RVA: 0x3F33EB0
        public void GetPinnableReference(){} // RVA: 0x3F337A0
        public void CopyTo(){} // RVA: 0x3F337B0
        public void TryCopyTo(){} // RVA: 0x3F33840
        public void op_Equality(){} // RVA: 0x3F338D0
        public void ToString(){} // RVA: 0x3F45AC0
        public void Slice(){} // RVA: 0x3F34300 | overloaded x2
        public void ToArray(){} // RVA: 0x3F35CC0
        public void get_Length(){} // RVA: 0x1EA9890
        public void get_IsEmpty(){} // RVA: 0x34B3520
        public void Equals(){} // RVA: 0x3F33D30
        public void GetHashCode(){} // RVA: 0x3F33D80
        public void op_Implicit(){} // RVA: 0x3F33DD0
        public void get_Empty(){} // RVA: 0x1529E90
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÎÎÌÏÌÍÏÏÍÏÎÏÌÏÌÏÌÍÏÌÌÏÌ> _pointer; // 0x10
        public int _length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5B50 | overloaded x4
        public void get_Item(){} // RVA: 0x3F33EB0
        public void GetPinnableReference(){} // RVA: 0x3F337A0
        public void CopyTo(){} // RVA: 0x3F337B0
        public void TryCopyTo(){} // RVA: 0x3F33840
        public void op_Equality(){} // RVA: 0x3F338D0
        public void ToString(){} // RVA: 0x3F45AC0
        public void Slice(){} // RVA: 0x3F34300 | overloaded x2
        public void ToArray(){} // RVA: 0x3F35CC0
        public void get_Length(){} // RVA: 0x1EA9890
        public void get_IsEmpty(){} // RVA: 0x34B3520
        public void Equals(){} // RVA: 0x3F33D30
        public void GetHashCode(){} // RVA: 0x3F33D80
        public void op_Implicit(){} // RVA: 0x3F33DD0
        public void get_Empty(){} // RVA: 0x1529E90
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÍÌÏÍÍÎÍÏÍÍÍÍÌÎÍÎÍÌÎÌÍÍÌ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÏÌÎÌÌÌÎÍÌÎÎÌÍÍÌÎÍÎÎÏÎÌÏ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÌÏÌÌÎÏÎÏÏÎÌÏÎÎÌÎÍÌÎÎÌÏÎ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÌÏÌÌÎÏÎÏÏÎÌÏÎÎÌÎÍÌÎÎÌÏÎ[]> <5; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÏÌÎÌÌÌÎÍÌÎÎÌÍÍÌÎÍÎÎÏÎÌÏ[]> <5; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÍÎÍÎÎÍÌÌÏÍÌÏÎÌÎÏÎÍÍÌÍÏÎ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<System.Collections.Generic.KeyValuePair`2<string,ÏÏÎÏÏÎÏÌÏÎÍÏÍÎÏÎÌÌÌÎÎÎÍ>> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<UnityEngine.GameObject> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÍÌÏÎÌÏÌÏÌÏÌÌÌÌÌÏÏÏÎÍÎÏÍ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<System.Collections.Generic.KeyValuePair`2<string,System.Collections.Generic.List`1<VRC.Core.ApiPlayerModeration>>> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<VRC.Core.Networking.IVRC_FlatBufferSerializer> _pointer; // 0x10
        public int _length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5B50 | overloaded x4
        public void get_Item(){} // RVA: 0x3F33EB0
        public void GetPinnableReference(){} // RVA: 0x3F337A0
        public void CopyTo(){} // RVA: 0x3F337B0
        public void TryCopyTo(){} // RVA: 0x3F33840
        public void op_Equality(){} // RVA: 0x3F338D0
        public void ToString(){} // RVA: 0x3F45AC0
        public void Slice(){} // RVA: 0x3F34300 | overloaded x2
        public void ToArray(){} // RVA: 0x3F35CC0
        public void get_Length(){} // RVA: 0x1EA9890
        public void get_IsEmpty(){} // RVA: 0x34B3520
        public void Equals(){} // RVA: 0x3F33D30
        public void GetHashCode(){} // RVA: 0x3F33D80
        public void op_Implicit(){} // RVA: 0x3F33DD0
        public void get_Empty(){} // RVA: 0x1529E90
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<VRC.Core.Networking.IVRC_FlatBufferSerializer[]> <5; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<UnityEngine.Material> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<0x659C0BA8> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<Transmtn.DTO.Notifications.Notification> _pointer; // 0x10
        public int _length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5B50 | overloaded x4
        public void get_Item(){} // RVA: 0x3F33EB0
        public void GetPinnableReference(){} // RVA: 0x3F337A0
        public void CopyTo(){} // RVA: 0x3F337B0
        public void TryCopyTo(){} // RVA: 0x3F33840
        public void op_Equality(){} // RVA: 0x3F338D0
        public void ToString(){} // RVA: 0x3F45AC0
        public void Slice(){} // RVA: 0x3F34300 | overloaded x2
        public void ToArray(){} // RVA: 0x3F35CC0
        public void get_Length(){} // RVA: 0x1EA9890
        public void get_IsEmpty(){} // RVA: 0x34B3520
        public void Equals(){} // RVA: 0x3F33D30
        public void GetHashCode(){} // RVA: 0x3F33D80
        public void op_Implicit(){} // RVA: 0x3F33DD0
        public void get_Empty(){} // RVA: 0x1529E90
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<System.Collections.Generic.SortedSet`1<...>> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<Transmtn.DTO.Notifications.Notification[]> <5; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÍÌÍÌÎÌÎÌÌÌÍÏÏÎÎÌÏÏÍÍÍÎÎ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ> _pointer; // 0x10
        public int _length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5B50 | overloaded x4
        public void get_Item(){} // RVA: 0x3F33EB0
        public void GetPinnableReference(){} // RVA: 0x3F337A0
        public void CopyTo(){} // RVA: 0x3F337B0
        public void TryCopyTo(){} // RVA: 0x3F33840
        public void op_Equality(){} // RVA: 0x3F338D0
        public void ToString(){} // RVA: 0x3F45AC0
        public void Slice(){} // RVA: 0x3F34300 | overloaded x2
        public void ToArray(){} // RVA: 0x3F35CC0
        public void get_Length(){} // RVA: 0x1EA9890
        public void get_IsEmpty(){} // RVA: 0x34B3520
        public void Equals(){} // RVA: 0x3F33D30
        public void GetHashCode(){} // RVA: 0x3F33D80
        public void op_Implicit(){} // RVA: 0x3F33DD0
        public void get_Empty(){} // RVA: 0x1529E90
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÌÏÏÎÎÎÌÍÍÍÎÍÌÌÌÍÏÌÎÍÌÏÌ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.ComponentInfoT> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.ComponentInfoT[]> <5; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<System.Collections.Generic.KeyValuePair`2<string,int>> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<VRC.Core.ApiPlayerModeration> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<VRC.Core.ApiLicense> _pointer; // 0x10
        public int _length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5B50 | overloaded x4
        public void get_Item(){} // RVA: 0x3F33EB0
        public void GetPinnableReference(){} // RVA: 0x3F337A0
        public void CopyTo(){} // RVA: 0x3F337B0
        public void TryCopyTo(){} // RVA: 0x3F33840
        public void op_Equality(){} // RVA: 0x3F338D0
        public void ToString(){} // RVA: 0x3F45AC0
        public void Slice(){} // RVA: 0x3F34300 | overloaded x2
        public void ToArray(){} // RVA: 0x3F35CC0
        public void get_Length(){} // RVA: 0x1EA9890
        public void get_IsEmpty(){} // RVA: 0x34B3520
        public void Equals(){} // RVA: 0x3F33D30
        public void GetHashCode(){} // RVA: 0x3F33D80
        public void op_Implicit(){} // RVA: 0x3F33DD0
        public void get_Empty(){} // RVA: 0x1529E90
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<System.Collections.Generic.KeyValuePair`2<string,System.Collections.Generic.List`1<VRC.Core.ApiModeration>>> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÌÏÌÍÏÌÌÍÌÌÍÌÎÍÌÍÎÏÌÌÌÎÏ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<System.Collections.Generic.KeyValuePair`2<string,System.Collections.Generic.List`1<VRC.Core.ApiAvatarModeration>>> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<int[]> <5; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<System.Type> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.Pinnable`1<System.Reflection.PortableExecutable.SectionHeader> _pinnable; // 0x10
        public UIntPtr _byteOffset; // 0x18
        public int _length; // 0x20
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<VRC.Core.ApiVRChatSubscription> _pointer; // 0x10
        public int _length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5B50 | overloaded x4
        public void get_Item(){} // RVA: 0x3F33EB0
        public void GetPinnableReference(){} // RVA: 0x3F337A0
        public void CopyTo(){} // RVA: 0x3F337B0
        public void TryCopyTo(){} // RVA: 0x3F33840
        public void op_Equality(){} // RVA: 0x3F338D0
        public void ToString(){} // RVA: 0x3F45AC0
        public void Slice(){} // RVA: 0x3F34300 | overloaded x2
        public void ToArray(){} // RVA: 0x3F35CC0
        public void get_Length(){} // RVA: 0x1EA9890
        public void get_IsEmpty(){} // RVA: 0x34B3520
        public void Equals(){} // RVA: 0x3F33D30
        public void GetHashCode(){} // RVA: 0x3F33D80
        public void op_Implicit(){} // RVA: 0x3F33DD0
        public void get_Empty(){} // RVA: 0x1529E90
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<VRC.Core.ApiUserIcon> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<ÍÎÌÏÏÌÍÌÌÌÌÍÌÌÏÍÏÌÎÏÏÌÍ> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<uint> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReadOnlySpan`1
    {
        public System.ByReference`1<uint> _pointer; // 0x10
        public int _length; // 0x18
    }

    public class ReflectionOnlyType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5EF7B10
        public void get_TypeHandle(){} // RVA: 0x5EF7B50
    }

    public class ResolveEventArgs
    {
        public string <Name>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5EB1070 | overloaded x2
        public void get_Name(){} // RVA: 0x2F8380
    }

    public class ResolveEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33AF1B0
        public void Invoke(){} // RVA: 0x439370
    }

    public class RuntimeArgumentHandle
    {
    }

    public class RuntimeFieldHandle
    {
        public UIntPtr value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F0B4D0 | overloaded x2
        public void get_Value(){} // RVA: 0x1AD4690
        public void GetObjectData(){} // RVA: 0x5F0B690
        public void Equals(){} // RVA: 0x5F0B8F0
        public void GetHashCode(){} // RVA: 0x19689B0
        public void SetValueInternal(){} // RVA: 0x5D9C240
        public void SetValue(){} // RVA: 0x5D9C240
        public void SetValueDirect(){} // RVA: 0x5F0B9E0
    }

    public class RuntimeMethodHandle
    {
        public UIntPtr value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F0B9F0 | overloaded x2
        public void get_Value(){} // RVA: 0x1AD4690
        public void GetObjectData(){} // RVA: 0x5F0BBB0
        public void Equals(){} // RVA: 0x5F0BE00
        public void GetHashCode(){} // RVA: 0x19689B0
        public void ConstructInstantiation(){} // RVA: 0x5F0BEF0
        public void IsNullHandle(){} // RVA: 0x1D26810
    }

    public class RuntimeType
    {
        public System.RuntimeType ValueType;
        public System.RuntimeType EnumType; // 0x8
        public System.RuntimeType ObjectType; // 0x10
        public System.RuntimeType StringType; // 0x18
        public System.RuntimeType DelegateType; // 0x20
        public System.Type[] s_SICtorParamTypes; // 0x28
        public System.Func`3<System.Type,System.Type[],System.Type> MakeTypeBuilderInstantiation; // 0x30
        public 0x657F3700 MemberBindingMask;
        public 0x657F3700 InvocationMask;
        public 0x657F3700 BinderNonCreateInstance;
        public 0x657F3700 BinderGetSetProperty;
        public 0x657F3700 BinderSetInvokeProperty;
        public 0x657F3700 BinderGetSetField;
        public 0x657F3700 BinderSetInvokeField;
        public 0x657F3700 BinderNonFieldGetSet;
        public 0x657F3700 ClassicBindingMask;
        public System.RuntimeType s_typedRef; // 0x38
        public System.MonoTypeInfo type_info; // 0x18
        public object GenericCache; // 0x20
        public System.Reflection.RuntimeConstructorInfo m_serializationCtor; // 0x28
        public int GenericParameterCountAny;

        // ── Methods ──
        public void GetType(){} // RVA: 0x5EE8800
        public void ThrowIfTypeNeverValidGenericArgument(){} // RVA: 0x5EE8880
        public void SanityCheckGenericArguments(){} // RVA: 0x5EE89F0
        public void SplitName(){} // RVA: 0x5EE8C50
        public void FilterPreCalculate(){} // RVA: 0x5EE9090
        public void FilterHelper(){} // RVA: 0x5EE93A0 | overloaded x2
        public void FilterApplyPrefixLookup(){} // RVA: 0x5EE9440
        public void FilterApplyBase(){} // RVA: 0x5EE9670
        public void FilterApplyType(){} // RVA: 0x5EE9880
        public void FilterApplyMethodInfo(){} // RVA: 0x5EE99F0
        public void FilterApplyConstructorInfo(){} // RVA: 0x5EE9A90
        public void FilterApplyMethodBase(){} // RVA: 0x5EE9B30
        public void .ctor(){} // RVA: 0x5EE9DD0
        public void GetMethodCandidates(){} // RVA: 0x5EF7010 | overloaded x2
        public void GetConstructorCandidates(){} // RVA: 0x5EEA0A0
        public void GetPropertyCandidates(){} // RVA: 0x5EEA5C0
        public void GetEventCandidates(){} // RVA: 0x5EEA7D0
        public void GetFieldCandidates(){} // RVA: 0x5EEA9D0
        public void GetNestedTypeCandidates(){} // RVA: 0x5EEAB90
        public void GetMethods(){} // RVA: 0x5EEB110
        public void GetConstructors(){} // RVA: 0x5EEB1C0
        public void GetProperties(){} // RVA: 0x5EEB260
        public void GetEvents(){} // RVA: 0x5EEB300
        public void GetFields(){} // RVA: 0x5EEB390
        public void GetMembers(){} // RVA: 0x5EEB420
        public void GetConstructorImpl(){} // RVA: 0x5EEBA20
        public void GetPropertyImpl(){} // RVA: 0x5EEBD10
        public void GetEvent(){} // RVA: 0x5EEC020
        public void GetField(){} // RVA: 0x5EEC240
        public void GetInterface(){} // RVA: 0x5EEC610
        public void GetNestedType(){} // RVA: 0x5EECEA0
        public void GetMember(){} // RVA: 0x5EED240
        public void get_Module(){} // RVA: 0x5EED980
        public void GetRuntimeModule(){} // RVA: 0x5EED980
        public void get_Assembly(){} // RVA: 0x5EED9A0
        public void GetRuntimeAssembly(){} // RVA: 0x5EED9A0
        public void get_TypeHandle(){} // RVA: 0x4EE6280
        public void IsInstanceOfType(){} // RVA: 0x5EED9C0
        public void IsAssignableFrom(){} // RVA: 0x5EED9F0
        public void IsEquivalentTo(){} // RVA: 0x5EEDB30
        public void get_BaseType(){} // RVA: 0x5EEDBF0
        public void GetBaseType(){} // RVA: 0x5EEDC00
        public void get_UnderlyingSystemType(){} // RVA: 0x1A3F520
        public void GetAttributeFlagsImpl(){} // RVA: 0x5EEDEF0
        public void IsContextfulImpl(){} // RVA: 0x5EEDF20
        public void IsByRefImpl(){} // RVA: 0x5EEE000
        public void IsPrimitiveImpl(){} // RVA: 0x5EEE020
        public void IsPointerImpl(){} // RVA: 0x5EEE050
        public void IsCOMObjectImpl(){} // RVA: 0x27694F0
        public void IsValueTypeImpl(){} // RVA: 0x5EEE070
        public void get_IsEnum(){} // RVA: 0x5EEE1C0
        public void HasElementTypeImpl(){} // RVA: 0x5EEE230
        public void get_GenericParameterAttributes(){} // RVA: 0x5EEE260
        public void get_IsSzArray(){} // RVA: 0x5EEE320
        public void IsArrayImpl(){} // RVA: 0x5EEE340
        public void GetArrayRank(){} // RVA: 0x5EEE360
        public void GetElementType(){} // RVA: 0x5EEE400
        public void GetEnumNames(){} // RVA: 0x5EEE470
        public void GetEnumValues(){} // RVA: 0x5EEE660
        public void GetEnumUnderlyingType(){} // RVA: 0x5EEE7F0
        public void IsEnumDefined(){} // RVA: 0x5EEE900
        public void GetEnumName(){} // RVA: 0x5EEEFF0
        public void GetGenericArgumentsInternal(){} // RVA: 0x5EF5800 | overloaded x2
        public void GetGenericArguments(){} // RVA: 0x5EEF2F0
        public void MakeGenericType(){} // RVA: 0x5EF48E0 | overloaded x2
        public void get_IsGenericTypeDefinition(){} // RVA: 0x5EEF890
        public void get_IsGenericParameter(){} // RVA: 0x5EEF8D0
        public void get_GenericParameterPosition(){} // RVA: 0x5EEF8F0
        public void GetGenericTypeDefinition(){} // RVA: 0x5EEF9A0
        public void get_IsGenericType(){} // RVA: 0x5EEFA70
        public void get_IsConstructedGenericType(){} // RVA: 0x5EEFAB0
        public void InvokeMember(){} // RVA: 0x5EEFB00
        public void Equals(){} // RVA: 0x20D62C0
        public void op_Equality(){} // RVA: 0x2878D00
        public void op_Inequality(){} // RVA: 0x5EB94A0
        public void Clone(){} // RVA: 0x1A3F520
        public void GetObjectData(){} // RVA: 0x5EF1260
        public void GetCustomAttributes(){} // RVA: 0x5EF1380 | overloaded x2
        public void IsDefined(){} // RVA: 0x5EF1530
        public void GetCustomAttributesData(){} // RVA: 0x5D97B30
        public void FormatTypeName(){} // RVA: 0x5EF16E0
        public void get_MemberType(){} // RVA: 0x5EF18D0
        public void get_ReflectedType(){} // RVA: 0x43E1C0
        public void get_MetadataToken(){} // RVA: 0x5EF1930
        public void CreateInstanceCheckThis(){} // RVA: 0x5EF1960
        public void CreateInstanceImpl(){} // RVA: 0x5EF1C70
        public void CreateInstanceDefaultCtor(){} // RVA: 0x5EF2510
        public void GetDefaultConstructor(){} // RVA: 0x5EF2680
        public void GetDefaultMemberName(){} // RVA: 0x5EF2860
        public void GetSerializationCtor(){} // RVA: 0x5EF29C0
        public void CreateInstanceSlow(){} // RVA: 0x5EF2C10
        public void CreateInstanceMono(){} // RVA: 0x5EF2C60
        public void CheckValue(){} // RVA: 0x5EF3010
        public void TryConvertToType(){} // RVA: 0x5EF3230
        public void IsConvertibleToPrimitiveType(){} // RVA: 0x5EF3530
        public void GetCachedName(){} // RVA: 0x5EF41F0
        public void make_array_type(){} // RVA: 0x5EF4260
        public void MakeArrayType(){} // RVA: 0x5EF4310 | overloaded x2
        public void make_byref_type(){} // RVA: 0x5EF4370
        public void MakeByRefType(){} // RVA: 0x5EF4390
        public void MakePointerType(){} // RVA: 0x5EF4450 | overloaded x2
        public void get_ContainsGenericParameters(){} // RVA: 0x5EF4550
        public void GetGenericParameterConstraints(){} // RVA: 0x5EF4690
        public void CreateInstanceForAnotherGenericParameter(){} // RVA: 0x5EF47A0
        public void GetMethodsByName_native(){} // RVA: 0x5EF48F0
        public void GetMethodsByName(){} // RVA: 0x5EF4900
        public void GetPropertiesByName_native(){} // RVA: 0x5EF4C90
        public void GetConstructors_native(){} // RVA: 0x5EF4CA0
        public void GetConstructors_internal(){} // RVA: 0x5EF4CB0
        public void GetPropertiesByName(){} // RVA: 0x5EF4F40
        public void GetGUID(){} // RVA: 0x5EF5390
        public void get_GUID(){} // RVA: 0x5EF53D0
        public void GetTypeCodeImpl(){} // RVA: 0x5EF5530
        public void GetTypeCodeImplInternal(){} // RVA: 0x5EF5580
        public void ToString(){} // RVA: 0x5EF5590
        public void IsGenericCOMObjectImpl(){} // RVA: 0x2DD320
        public void CreateInstanceInternal(){} // RVA: 0x5EF55A0
        public void get_DeclaringMethod(){} // RVA: 0x5EF55F0
        public void getFullName(){} // RVA: 0x5EF5670
        public void GetGenericParameterAttributes(){} // RVA: 0x5EF5810
        public void GetGenericParameterPosition(){} // RVA: 0x5EF5850
        public void GetEvents_native(){} // RVA: 0x5EF5880
        public void GetFields_native(){} // RVA: 0x5EF5890
        public void GetFields_internal(){} // RVA: 0x5EF58A0
        public void GetEvents_internal(){} // RVA: 0x5EF5D00
        public void GetInterfaces(){} // RVA: 0x5EF60D0
        public void GetNestedTypes_native(){} // RVA: 0x5EF60E0
        public void GetNestedTypes_internal(){} // RVA: 0x5EF60F0
        public void get_AssemblyQualifiedName(){} // RVA: 0x5EF6500
        public void get_DeclaringType(){} // RVA: 0x5EF6510
        public void get_Name(){} // RVA: 0x5EF65B0
        public void get_Namespace(){} // RVA: 0x5EF6690
        public void GetHashCode(){} // RVA: 0x5EF6700
        public void get_FullName(){} // RVA: 0x5EF67B0
        public void get_IsSZArray(){} // RVA: 0x5EF6990
        public void IsSubclassOf(){} // RVA: 0x5EF6A00
        public void GetMethodImpl(){} // RVA: 0x5EF6B10
        public void GetMethodImplCommon(){} // RVA: 0x5EF6B60
        public void .cctor(){} // RVA: 0x5EF7250
    }

    public class RuntimeTypeHandle
    {
        public UIntPtr value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F0C080 | overloaded x3
        public void get_Value(){} // RVA: 0x1AD4690
        public void GetObjectData(){} // RVA: 0x5F0C240
        public void Equals(){} // RVA: 0x3554450 | overloaded x2
        public void GetHashCode(){} // RVA: 0x19689B0
        public void GetAttributes(){} // RVA: 0x5EEDEF0
        public void GetMetadataToken(){} // RVA: 0x5EF1930
        public void GetToken(){} // RVA: 0x5EF1930
        public void GetGenericTypeDefinition_impl(){} // RVA: 0x5F0C5E0
        public void GetGenericTypeDefinition(){} // RVA: 0x5F0C5E0
        public void IsPrimitive(){} // RVA: 0x5EEE020
        public void IsByRef(){} // RVA: 0x5EEE000
        public void IsPointer(){} // RVA: 0x5EEE050
        public void IsArray(){} // RVA: 0x5EEE340
        public void IsSzArray(){} // RVA: 0x5EEE320
        public void HasElementType(){} // RVA: 0x5EEE230
        public void GetCorElementType(){} // RVA: 0x5F0C640
        public void HasInstantiation(){} // RVA: 0x5EEFA70
        public void IsComObject(){} // RVA: 0x2DD320 | overloaded x2
        public void IsInstanceOfType(){} // RVA: 0x5EED9C0
        public void HasReferences(){} // RVA: 0x5F0C660
        public void IsContextful(){} // RVA: 0x5EEDF20
        public void IsEquivalentTo(){} // RVA: 0x2DD320
        public void IsInterface(){} // RVA: 0x5F0C680
        public void GetArrayRank(){} // RVA: 0x5F0C6B0
        public void GetAssembly(){} // RVA: 0x5EED9A0
        public void GetElementType(){} // RVA: 0x5EEE400
        public void GetModule(){} // RVA: 0x5EED980
        public void IsGenericVariable(){} // RVA: 0x5EEF8D0
        public void GetBaseType(){} // RVA: 0x5F0C6D0
        public void CanCastTo(){} // RVA: 0x5F0C700
        public void type_is_assignable_from(){} // RVA: 0x5F0C780
        public void IsGenericTypeDefinition(){} // RVA: 0x5EEF890
        public void GetGenericParameterInfo(){} // RVA: 0x5F0C800
        public void IsSubclassOf(){} // RVA: 0x5F0C820
        public void is_subclass_of(){} // RVA: 0x5F0C850
        public void internal_from_name(){} // RVA: 0x5F0C860
        public void GetTypeByName(){} // RVA: 0x5F0C880
    }

}