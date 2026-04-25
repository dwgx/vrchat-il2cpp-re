// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 4
// Methods: 28

public class NullableAttributeStateParser : ValueType
{
    public object Unknown;
    public object _nullableAttributeArgument; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_Unknown(){} // RVA: 0x7FFAC8BF4480
    public void ParseNullableState(){} // RVA: 0x7FFAC8BF4530
    public void .cctor(){} // RVA: 0x7FFAC8BF4800
}

public class Number : Object
{
    public string[] s_posCurrencyFormats;
    public string[] s_negCurrencyFormats; // 0x8
    public string[] s_posPercentFormats; // 0x10
    public string[] s_negPercentFormats; // 0x18
    public string[] s_negNumberFormats; // 0x20
    public string s_posNumberFormat; // 0x28

    // ── Methods ──
    public void IsWhite(){} // RVA: 0x7FFAC8FC6740
    public void MatchChars(){} // RVA: 0x7FFAC8FC6820 | overloaded x2
    public void ParseNumber(){} // RVA: 0x7FFAC8FC6870
    public void TrailingZeros(){} // RVA: 0x7FFAC8FC7330
    public void TryStringToNumber(){} // RVA: 0x7FFAC8FC73B0
    public void Int32ToDecChars(){} // RVA: 0x7FFAC8FC7540
    public void ParseFormatSpecifier(){} // RVA: 0x7FFAC8FC75B0
    public void NumberToString(){} // RVA: 0x7FFAC8FC7750
    public void FormatCurrency(){} // RVA: 0x7FFAC8FC7DF0
    public void wcslen(){} // RVA: 0x7FFAC8FC8040
    public void FormatFixed(){} // RVA: 0x7FFAC8FC8060
    public void FormatNumber(){} // RVA: 0x7FFAC8FC8440
    public void FormatScientific(){} // RVA: 0x7FFAC8FC8640
    public void FormatExponent(){} // RVA: 0x7FFAC8FC8770
    public void FormatGeneral(){} // RVA: 0x7FFAC8FC8910
    public void FormatPercent(){} // RVA: 0x7FFAC8FC8B80
    public void RoundNumber(){} // RVA: 0x7FFAC8FC8DD0
    public void FindSection(){} // RVA: 0x7FFAC8FC8EB0
    public void NumberToStringFormat(){} // RVA: 0x7FFAC8FC8FC0
    public void .cctor(){} // RVA: 0x7FFAC8FC9C90
}

public class NumberBuffer : ValueType
{
    public int sign; // 0x10
    public int digits; // 0x14
    public int _sign; // 0x18
    public DigitsAndNullTerminator _digits; // 0x1C
    public char* _allDigits; // 0x82

    // ── Methods ──
    public void get_sign(){} // RVA: 0x7FFAC8644870
    public void set_sign(){} // RVA: 0x7FFAC8644880
    public void get_digits(){} // RVA: 0x7FFAC8644890
}

public class NumberFormatEntryManaged : ValueType
{
    public int currency_decimal_digits; // 0x10
    public int currency_decimal_separator; // 0x14
    public int currency_group_separator; // 0x18
    public int currency_group_sizes0; // 0x1C
    public int currency_group_sizes1; // 0x20
    public int currency_negative_pattern; // 0x24
    public int currency_positive_pattern; // 0x28
    public int currency_symbol; // 0x2C
    public int nan_symbol; // 0x30
    public int negative_infinity_symbol; // 0x34
    public int negative_sign; // 0x38
    public int number_decimal_digits; // 0x3C
    public int number_decimal_separator; // 0x40
    public int number_group_separator; // 0x44
    public int number_group_sizes0; // 0x48
    public int number_group_sizes1; // 0x4C
    public int number_negative_pattern; // 0x50
    public int per_mille_symbol; // 0x54
    public int percent_negative_pattern; // 0x58
    public int percent_positive_pattern; // 0x5C
    public int percent_symbol; // 0x60
    public int positive_infinity_symbol; // 0x64
    public int positive_sign; // 0x68
}
