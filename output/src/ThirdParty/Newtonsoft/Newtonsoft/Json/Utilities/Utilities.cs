// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Utilities
// Classes: 19
// Methods: 286

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Utilities
{
    public class AotHelper : Object
    {
        public bool s_alwaysFalse;

        // ── Methods ──
        public void Ensure(){} // RVA: 0x7FFD53B72E20
        public void EnsureType(){} // RVA: 0x7FFD4E0909B0
        public void EnsureList(){} // RVA: 0x7FFD4E0909B0
        public void EnsureDictionary(){} // RVA: 0x7FFD4E0909B0
        public void IsFalse(){} // RVA: 0x7FFD53B72F40
        public void .cctor(){} // RVA: 0x7FFD53B72FA0
    }

    public class AsyncUtils : Object
    {
        public utes.?<bool> False;
        public utes.?<bool> True; // 0x8
        public utes.Line CompletedTask; // 0x10

        // ── Methods ──
        public void ToAsync(){} // RVA: 0x7FFD53B73060
        public void CancelIfRequestedAsync(){} // RVA: 0x7FFD4E087ED0 | overloaded x2
        public void FromCanceled(){} // RVA: 0x7FFD4E087ED0 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFD53B73530 | overloaded x3
        public void ReadAsync(){} // RVA: 0x7FFD53B73620
        public void IsCompletedSuccessfully(){} // RVA: 0x7FFD53B73730
        public void .cctor(){} // RVA: 0x7FFD53B737E0
    }

    public class BidirectionalDictionary`2 : Object
    {
        public URA.X_CALENDARS<T1717644880,T1717644896> _firstToSecond;
        public URA.X_CALENDARS<T1717644896,T1717644880> _secondToFirst;
        public string _duplicateFirstErrorMessage;
        public string _duplicateSecondErrorMessage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09B8C0 | overloaded x3
        public void Set(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetByFirst(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetBySecond(){} // RVA: 0x7FFD4E2ADC40
    }

    public class CollectionUtils : Object
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x7FFD4E079DE0
        public void AddRange(){} // RVA: 0x7FFD4E090C80
        public void IsDictionaryType(){} // RVA: 0x7FFD53B76560
        public void ResolveEnumerableCollectionConstructor(){} // RVA: 0x7FFD53B76910 | overloaded x2
        public void AddDistinct(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ContainsValue(){} // RVA: 0x7FFD4E2ADC40
        public void AddRangeDistinct(){} // RVA: 0x7FFD4E07D5A0
        public void IndexOf(){} // RVA: 0x7FFD4E07E730
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void IndexOfReference(){} // RVA: 0x7FFD4E2ADC40
        public void FastReverse(){} // RVA: 0x7FFD4E090A10
        public void GetDimensions(){} // RVA: 0x7FFD53B76BF0
        public void CopyFromJaggedToMultidimensionalArray(){} // RVA: 0x7FFD53B76FB0
        public void JaggedArrayGetValue(){} // RVA: 0x7FFD53B77250
        public void ToMultidimensionalArray(){} // RVA: 0x7FFD53B77350
        public void ArrayEmpty(){} // RVA: 0x7FFD4E078A90
    }

    public class CollectionWrapper`1 : Object
    {
        public mePatterns.eseCalendarDTFI Count;
        public URA.tCalendarData<T1717645104> IsReadOnly;
        public object System.Collections.IList.IsFixedSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD4E090A40
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD4E087DE0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void VerifyValueType(){} // RVA: 0x7FFD4E090A10
        public void IsCompatibleObject(){} // RVA: 0x7FFD4E079DE0
        public void get_UnderlyingCollection(){} // RVA: 0x7FFD4E078E90
    }

    public class Creator`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
        public void BeginInvoke(){} // RVA: 0x7FFD4E08A6F0
        public void EndInvoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class DictionaryWrapper`2 : Object
    {
        public mePatterns.ears GenericDictionary;
        public URA.X_CALENDARS<T1717645216,T1717645232> Keys;
        public URA.DayNames<T1717645216,T1717645232> Values;
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x3
        public void get_GenericDictionary(){} // RVA: 0x7FFD4E078E90
        public void Add(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ContainsKey(){} // RVA: 0x7FFD4E2ADC40
        public void get_Keys(){} // RVA: 0x7FFD4E078E90
        public void Remove(){} // RVA: 0x7FFD4E090A40 | overloaded x3
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void get_Values(){} // RVA: 0x7FFD4E078E90
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFD4E099B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFD4E078F40
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFD4E099B30
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void get_UnderlyingDictionary(){} // RVA: 0x7FFD4E078E90
    }

    public class DynamicProxyMetaObject`1 : DynamicMetaObject
    {
        public rnToTarget.g<T1717645504> NoArgs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void IsOverridden(){} // RVA: 0x7FFD4E079F60
        public void BindGetMember(){} // RVA: 0x7FFD4E078F40
        public void BindSetMember(){} // RVA: 0x7FFD4E08A6F0
        public void BindDeleteMember(){} // RVA: 0x7FFD4E078F40
        public void BindConvert(){} // RVA: 0x7FFD4E078F40
        public void BindInvokeMember(){} // RVA: 0x7FFD4E08A6F0
        public void BindCreateInstance(){} // RVA: 0x7FFD4E08A6F0
        public void BindInvoke(){} // RVA: 0x7FFD4E08A6F0
        public void BindBinaryOperation(){} // RVA: 0x7FFD4E08A6F0
        public void BindUnaryOperation(){} // RVA: 0x7FFD4E078F40
        public void BindGetIndex(){} // RVA: 0x7FFD4E08A6F0
        public void BindSetIndex(){} // RVA: 0x7FFD4E08AE80
        public void BindDeleteIndex(){} // RVA: 0x7FFD4E08A6F0
        public void get_NoArgs(){} // RVA: 0x7FFD4E078A90
        public void GetArgs(){} // RVA: 0x7FFD4E078F80
        public void GetArgArray(){} // RVA: 0x7FFD4E078FF0 | overloaded x2
        public void Constant(){} // RVA: 0x7FFD4E078F80
        public void CallMethodWithResult(){} // RVA: 0x7FFD4E08B2B0
        public void BuildCallMethodWithResult(){} // RVA: 0x7FFD4E08B2B0
        public void CallMethodReturnLast(){} // RVA: 0x7FFD4E08B140
        public void CallMethodNoResult(){} // RVA: 0x7FFD4E08B140
        public void GetRestrictions(){} // RVA: 0x7FFD4E078E90
        public void GetDynamicMemberNames(){} // RVA: 0x7FFD4E078E90
    }

    public class DynamicProxy`1 : Object
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x7FFD4E2ADC40
        public void TryBinaryOperation(){} // RVA: 0x7FFD4E2ADC40
        public void TryConvert(){} // RVA: 0x7FFD4E2ADC40
        public void TryCreateInstance(){} // RVA: 0x7FFD4E2ADC40
        public void TryDeleteIndex(){} // RVA: 0x7FFD4E2ADC40
        public void TryDeleteMember(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetIndex(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetMember(){} // RVA: 0x7FFD4E2ADC40
        public void TryInvoke(){} // RVA: 0x7FFD4E2ADC40
        public void TryInvokeMember(){} // RVA: 0x7FFD4E2ADC40
        public void TrySetIndex(){} // RVA: 0x7FFD4E2ADC40
        public void TrySetMember(){} // RVA: 0x7FFD4E2ADC40
        public void TryUnaryOperation(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class EnumUtils : Object
    {
        public char EnumSeparatorChar;
        public string EnumSeparatorString;
        public rnToTarget.ltFloatParseHandling<rnToTarget.?<?,eckAdditionalContent.eference>,rnToTarget.rameters> ValuesAndNamesPerEnum;
        public eckAdditionalContent.ultMaxDepth _camelCaseNamingStrategy; // 0x8

        // ── Methods ──
        public void InitializeValuesAndNames(){} // RVA: 0x7FFD53B84C50
        public void GetFlagsValues(){} // RVA: 0x7FFD4E2ADC40
        public void TryToString(){} // RVA: 0x7FFD53B853F0 | overloaded x2
        public void InternalFlagsFormat(){} // RVA: 0x7FFD53B85700
        public void GetEnumValuesAndNames(){} // RVA: 0x7FFD53B858B0
        public void ToUInt64(){} // RVA: 0x7FFD53B85A30
        public void ParseEnum(){} // RVA: 0x7FFD53B85DE0
        public void MatchName(){} // RVA: 0x7FFD53B866E0
        public void FindIndexByName(){} // RVA: 0x7FFD53B867D0
        public void .cctor(){} // RVA: 0x7FFD53B868C0
    }

    public class FSharpUtils : Object
    {
        public object Instance;
        public rnToTarget.rategyInstance>k__BackingField FSharpCoreAssembly; // 0x8
        public m.jectMapInfo IsUnion; // 0x10
        public object GetUnionCases; // 0x18
        public m.ormation PreComputeUnionTagReader; // 0x20
        public rnToTarget.?<object,object> PreComputeUnionReader; // 0x28
        public rnToTarget.?<object,object> PreComputeUnionConstructor; // 0x30
        public rnToTarget.?<object,object> GetUnionCaseInfoDeclaringType; // 0x38
        public rnToTarget.?<object,object> GetUnionCaseInfoName; // 0x40
        public rnToTarget.?<object,object> GetUnionCaseInfoTag; // 0x48
        public n<object,object> GetUnionCaseInfoFields; // 0x50
        public n<object,object> <GetUnionCaseInfoName>k__BackingField; // 0x58
        public n<object,object> <GetUnionCaseInfoTag>k__BackingField; // 0x60
        public rnToTarget.?<object,object> <GetUnionCaseInfoFields>k__BackingField; // 0x68
        public string FSharpSetTypeName;
        public string FSharpListTypeName;
        public string FSharpMapTypeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53B86B60
        public void get_Instance(){} // RVA: 0x7FFD53B87730
        public void get_FSharpCoreAssembly(){} // RVA: 0x7FFD4E36F0C0
        public void set_FSharpCoreAssembly(){} // RVA: 0x7FFD4E36F0D0
        public void get_IsUnion(){} // RVA: 0x7FFD4E36F130
        public void set_IsUnion(){} // RVA: 0x7FFD4E342E90
        public void get_GetUnionCases(){} // RVA: 0x7FFD4E5F95E0
        public void set_GetUnionCases(){} // RVA: 0x7FFD4E36F890
        public void get_PreComputeUnionTagReader(){} // RVA: 0x7FFD4E5F0140
        public void set_PreComputeUnionTagReader(){} // RVA: 0x7FFD4E5F0C20
        public void get_PreComputeUnionReader(){} // RVA: 0x7FFD4E3BE740
        public void set_PreComputeUnionReader(){} // RVA: 0x7FFD4E369200
        public void get_PreComputeUnionConstructor(){} // RVA: 0x7FFD4E3BC730
        public void set_PreComputeUnionConstructor(){} // RVA: 0x7FFD4E3BC740
        public void get_GetUnionCaseInfoDeclaringType(){} // RVA: 0x7FFD4E3E20E0
        public void set_GetUnionCaseInfoDeclaringType(){} // RVA: 0x7FFD4E4994D0
        public void get_GetUnionCaseInfoName(){} // RVA: 0x7FFD4E409500
        public void set_GetUnionCaseInfoName(){} // RVA: 0x7FFD4E409510
        public void get_GetUnionCaseInfoTag(){} // RVA: 0x7FFD4E3DF370
        public void set_GetUnionCaseInfoTag(){} // RVA: 0x7FFD4E3DF380
        public void get_GetUnionCaseInfoFields(){} // RVA: 0x7FFD4E3BCD50
        public void set_GetUnionCaseInfoFields(){} // RVA: 0x7FFD4E3BCD60
        public void EnsureInitialized(){} // RVA: 0x7FFD53B87790
        public void GetMethodWithNonPublicFallback(){} // RVA: 0x7FFD53B87A00
        public void CreateFSharpFuncCall(){} // RVA: 0x7FFD53B87B10
        public void CreateSeq(){} // RVA: 0x7FFD53B87EB0
        public void CreateMap(){} // RVA: 0x7FFD53B87FC0
        public void BuildMapCreator(){} // RVA: 0x7FFD4E078E90
        public void .cctor(){} // RVA: 0x7FFD53B88290
    }

    public class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
    {
        public rnToTarget.Input>k__BackingField Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFD53B8E570
        public void CreateParameterizedConstructor(){} // RVA: 0x7FFD53B8E5D0
        public void CreateMethodCall(){} // RVA: 0x7FFD4E078F40
        public void CreateDefaultConstructor(){} // RVA: 0x7FFD4E078F40
        public void CreateGet(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void CreateSet(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD53B8E800
    }

    public class MethodCall`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
        public void BeginInvoke(){} // RVA: 0x7FFD4E2ADC40
        public void EndInvoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ReflectionDelegateFactory : Object
    {
        // ── Methods ──
        public void CreateGet(){} // RVA: 0x7FFD4E078F40 | overloaded x3
        public void CreateSet(){} // RVA: 0x7FFD4E078F40 | overloaded x3
        public void CreateMethodCall(){} // RVA: 0x7FFD4E078F40
        public void CreateParameterizedConstructor(){} // RVA: 0x7FFD4E078F40
        public void CreateDefaultConstructor(){} // RVA: 0x7FFD4E078F40
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ReflectionObject : Object
    {
        public object Creator;
        public object Members;

        // ── Methods ──
        public void get_Creator(){} // RVA: 0x7FFD4E35C380
        public void get_Members(){} // RVA: 0x7FFD4E3447C0
        public void .ctor(){} // RVA: 0x7FFD53B8F6A0
        public void GetValue(){} // RVA: 0x7FFD53B8F7C0
        public void SetValue(){} // RVA: 0x7FFD53B8F840
        public void GetType(){} // RVA: 0x7FFD53B8F8D0
        public void Create(){} // RVA: 0x7FFD53B8F940 | overloaded x2
    }

    public class ReflectionUtils : Object
    {
        public ?[] EmptyTypes;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD53B903F0
        public void IsVirtual(){} // RVA: 0x7FFD53B904C0
        public void GetBaseDefinition(){} // RVA: 0x7FFD53B905D0
        public void IsPublic(){} // RVA: 0x7FFD53B906E0
        public void GetObjectType(){} // RVA: 0x7FFD53B90780
        public void GetTypeName(){} // RVA: 0x7FFD53B907A0
        public void GetFullyQualifiedTypeName(){} // RVA: 0x7FFD53B90870
        public void RemoveAssemblyDetails(){} // RVA: 0x7FFD53B90B60
        public void HasDefaultConstructor(){} // RVA: 0x7FFD53B90CD0
        public void GetDefaultConstructor(){} // RVA: 0x7FFD53B90E90 | overloaded x2
        public void IsNullable(){} // RVA: 0x7FFD53B91030
        public void IsNullableType(){} // RVA: 0x7FFD53B91110
        public void EnsureNotNullableType(){} // RVA: 0x7FFD53B91220
        public void EnsureNotByRefType(){} // RVA: 0x7FFD53B91290
        public void IsGenericDefinition(){} // RVA: 0x7FFD53B91300
        public void ImplementsGenericDefinition(){} // RVA: 0x7FFD53B91420 | overloaded x2
        public void InheritsGenericDefinition(){} // RVA: 0x7FFD53B917A0 | overloaded x2
        public void InheritsGenericDefinitionInternal(){} // RVA: 0x7FFD53B91AF0
        public void GetCollectionItemType(){} // RVA: 0x7FFD53B91C80
        public void GetDictionaryKeyValueTypes(){} // RVA: 0x7FFD53B91FC0
        public void GetMemberUnderlyingType(){} // RVA: 0x7FFD53B92450
        public void IsByRefLikeType(){} // RVA: 0x7FFD53B92710
        public void IsIndexedProperty(){} // RVA: 0x7FFD53B928B0
        public void GetMemberValue(){} // RVA: 0x7FFD53B92960
        public void SetMemberValue(){} // RVA: 0x7FFD53B92CB0
        public void CanReadMemberValue(){} // RVA: 0x7FFD53B92F40
        public void CanSetMemberValue(){} // RVA: 0x7FFD53B930B0
        public void GetFieldsAndProperties(){} // RVA: 0x7FFD53B93270
        public void IsOverridenGenericMember(){} // RVA: 0x7FFD53B93AE0
        public void GetAttribute(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetAttributes(){} // RVA: 0x7FFD53B93D00 | overloaded x2
        public void SplitFullyQualifiedTypeName(){} // RVA: 0x7FFD53B94180
        public void GetAssemblyDelimiterIndex(){} // RVA: 0x7FFD53B94330
        public void GetMemberInfoFromType(){} // RVA: 0x7FFD53B943F0
        public void GetFields(){} // RVA: 0x7FFD53B94820
        public void GetChildPrivateFields(){} // RVA: 0x7FFD53B94970
        public void GetProperties(){} // RVA: 0x7FFD53B94B80
        public void RemoveFlag(){} // RVA: 0x7FFD53B94F00
        public void GetChildPrivateProperties(){} // RVA: 0x7FFD53B94F20
        public void IsMethodOverridden(){} // RVA: 0x7FFD53B95340
        public void GetDefaultValue(){} // RVA: 0x7FFD53B954F0
    }

    public class StringUtils : Object
    {
        public string CarriageReturnLineFeed;
        public string Empty;
        public char CarriageReturn;
        public char LineFeed;
        public char Tab;

        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x7FFD53B966C0
        public void FormatWith(){} // RVA: 0x7FFD53B96E40 | overloaded x5
        public void IsWhiteSpace(){} // RVA: 0x7FFD53B96F80
        public void CreateStringWriter(){} // RVA: 0x7FFD53B97080
        public void ToCharAsUnicode(){} // RVA: 0x7FFD53B97190
        public void ForgivingCaseSensitiveFind(){} // RVA: 0x7FFD4E2ADC40
        public void ToCamelCase(){} // RVA: 0x7FFD53B97270
        public void ToLower(){} // RVA: 0x7FFD53B97460
        public void ToSnakeCase(){} // RVA: 0x7FFD53B975B0
        public void ToKebabCase(){} // RVA: 0x7FFD53B975C0
        public void ToSeparatedCase(){} // RVA: 0x7FFD53B975D0
        public void IsHighSurrogate(){} // RVA: 0x7FFD53B97950
        public void IsLowSurrogate(){} // RVA: 0x7FFD53B979C0
        public void IndexOf(){} // RVA: 0x7FFD53B97A30
        public void Replace(){} // RVA: 0x7FFD53B97A60
        public void StartsWith(){} // RVA: 0x7FFD53B97A80
        public void EndsWith(){} // RVA: 0x7FFD53B97AB0
        public void Trim(){} // RVA: 0x7FFD53B97B00
    }

    public class StructMultiKey`2 : ValueType
    {
        public T1717646096 Value1;
        public T1717646112 Value2;
    }

    public class ThreadSafeStore`2 : Object
    {
        public JapaneseLangName.erns<T1717646128,T1717646144> _concurrentStore;
        public n<T1717646128,T1717646144> _creator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD520C44C0
        public void Get(){} // RVA: 0x7FFD520C46F0
    }

}