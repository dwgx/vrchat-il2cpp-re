// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.Reflection
// Classes: 13
// Methods: 436

namespace ThirdParty.Google.Google.Protobuf.Reflection
{
    public class DescriptorPool : Object
    {
        public URA.X_CALENDARS<string,ate.thSize> descriptorsByName; // 0x10
        public URA.X_CALENDARS<gBox.dialAimBlend<ate.thSize>,ate.nel> fieldsByNumber; // 0x18
        public URA.X_CALENDARS<gBox.dialAimBlend<ate.thSize>,ate.meOwnerName> enumValuesByNumber; // 0x20
        public URA.onsDepth<ate.ination> dependencies; // 0x28
        public tor.neStore ValidationRegex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53635110
        public void ImportPublicDependencies(){} // RVA: 0x7FFD536357D0
        public void FindSymbol(){} // RVA: 0x7FFD4E2ADC40
        public void AddPackage(){} // RVA: 0x7FFD53635A00
        public void AddSymbol(){} // RVA: 0x7FFD53635E00
        public void ValidateSymbolName(){} // RVA: 0x7FFD53636220
        public void FindFieldByNumber(){} // RVA: 0x7FFD536364A0
        public void AddFieldByNumber(){} // RVA: 0x7FFD53636600
        public void AddEnumValueByNumber(){} // RVA: 0x7FFD53636A20
        public void LookupSymbol(){} // RVA: 0x7FFD53636C70
        public void .cctor(){} // RVA: 0x7FFD53636F60
    }

    public class DescriptorUtil : Object
    {
        // ── Methods ──
        public void ConvertAndMakeReadOnly(){} // RVA: 0x7FFD4E078FF0
    }

    public class EnumOptions : Object
    {
        public gBox.itionBlend<ate.aPending> _Extensions;
        public gBox.ra Parser; // 0x10
        public gBox.centerTarget<ate.aPending> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public bool AllowAlias; // 0x8
        public bool HasAllowAlias; // 0x24
        public bool Deprecated; // 0x9
        public bool HasDeprecated; // 0x25
        public gBox.PathNoRoll<ate.ePoint>g__ClosestPointOnSegment|9_2> UninterpretedOption; // 0x10
        public r>k__BackingField.resentations<ate.ePoint>g__ClosestPointOnSegment|9_2> uninterpretedOption_; // 0x28

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFD4E3447C0
        public void get_Parser(){} // RVA: 0x7FFD53628650
        public void get_Descriptor(){} // RVA: 0x7FFD536286B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD53628770
        public void .ctor(){} // RVA: 0x7FFD53628920 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD53628B40
        public void get_AllowAlias(){} // RVA: 0x7FFD53628BA0
        public void set_AllowAlias(){} // RVA: 0x7FFD53624E30
        public void get_HasAllowAlias(){} // RVA: 0x7FFD53621340
        public void ClearAllowAlias(){} // RVA: 0x7FFD53621350
        public void get_Deprecated(){} // RVA: 0x7FFD53628C10
        public void set_Deprecated(){} // RVA: 0x7FFD53624EB0
        public void get_HasDeprecated(){} // RVA: 0x7FFD53621160
        public void ClearDeprecated(){} // RVA: 0x7FFD53621170
        public void get_UninterpretedOption(){} // RVA: 0x7FFD4E36F130
        public void Equals(){} // RVA: 0x7FFD53628DF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53628F30
        public void ToString(){} // RVA: 0x7FFD53629040
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD53629090
        public void CalculateSize(){} // RVA: 0x7FFD536291D0
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD53629460
        public void GetExtension(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFD4E078F40
        public void SetExtension(){} // RVA: 0x7FFD4E2ADC40
        public void HasExtension(){} // RVA: 0x7FFD4E079F60
        public void ClearExtension(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD536295E0
    }

    public class EnumValueOptions : Object
    {
        public gBox.itionBlend<ate.tLM> _Extensions;
        public gBox.ra Parser; // 0x10
        public gBox.centerTarget<ate.tLM> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public bool Deprecated; // 0x8
        public bool HasDeprecated; // 0x24
        public gBox.PathNoRoll<ate.ePoint>g__ClosestPointOnSegment|9_2> UninterpretedOption; // 0x10
        public r>k__BackingField.resentations<ate.ePoint>g__ClosestPointOnSegment|9_2> uninterpretedOption_; // 0x28

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFD4E3447C0
        public void get_Parser(){} // RVA: 0x7FFD53629980
        public void get_Descriptor(){} // RVA: 0x7FFD536299E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD53629AA0
        public void .ctor(){} // RVA: 0x7FFD53629C50 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD53629E60
        public void get_Deprecated(){} // RVA: 0x7FFD53629EC0
        public void set_Deprecated(){} // RVA: 0x7FFD53624E30
        public void get_HasDeprecated(){} // RVA: 0x7FFD53621340
        public void ClearDeprecated(){} // RVA: 0x7FFD53621350
        public void get_UninterpretedOption(){} // RVA: 0x7FFD4E36F130
        public void Equals(){} // RVA: 0x7FFD5362A080 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD5362A190
        public void ToString(){} // RVA: 0x7FFD5362A260
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD5362A2B0
        public void CalculateSize(){} // RVA: 0x7FFD5362A3C0
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD5362A620
        public void GetExtension(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFD4E078F40
        public void SetExtension(){} // RVA: 0x7FFD4E2ADC40
        public void HasExtension(){} // RVA: 0x7FFD4E079F60
        public void ClearExtension(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD5362A770
    }

    public class ExtensionRangeOptions : Object
    {
        public gBox.itionBlend<ate.e> _Extensions;
        public gBox.ra Parser; // 0x10
        public gBox.centerTarget<ate.e> Descriptor; // 0x18
        public gBox.PathNoRoll<ate.ePoint>g__ClosestPointOnSegment|9_2> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public r>k__BackingField.resentations<ate.ePoint>g__ClosestPointOnSegment|9_2> UninterpretedOption; // 0x20

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFD4E3447C0
        public void get_Parser(){} // RVA: 0x7FFD53615120
        public void get_Descriptor(){} // RVA: 0x7FFD53615180
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD53615240
        public void .ctor(){} // RVA: 0x7FFD536153F0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD53615600
        public void get_UninterpretedOption(){} // RVA: 0x7FFD4E36F0C0
        public void Equals(){} // RVA: 0x7FFD536157A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53615890
        public void ToString(){} // RVA: 0x7FFD53615920
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD53615970
        public void CalculateSize(){} // RVA: 0x7FFD53615A60
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD53615CA0
        public void GetExtension(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFD4E078F40
        public void SetExtension(){} // RVA: 0x7FFD4E2ADC40
        public void HasExtension(){} // RVA: 0x7FFD4E079F60
        public void ClearExtension(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD53615DD0
    }

    public class FieldOptions : Object
    {
        public gBox.itionBlend<ate.Node> _Extensions;
        public gBox.ra Parser; // 0x10
        public gBox.centerTarget<ate.Node> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public nsertLocalMinima Ctype; // 0x8
        public nsertLocalMinima HasCtype; // 0x24
        public bool Packed; // 0xC
        public bool HasPacked; // 0x28
        public alMinima Jstype; // 0x10
        public alMinima HasJstype; // 0x2C
        public bool Lazy; // 0x14
        public bool HasLazy; // 0x30
        public bool UnverifiedLazy; // 0x15
        public bool HasUnverifiedLazy; // 0x31
        public bool Deprecated; // 0x16
        public bool HasDeprecated; // 0x32
        public bool Weak; // 0x17
        public bool HasWeak; // 0x33
        public gBox.PathNoRoll<ate.ePoint>g__ClosestPointOnSegment|9_2> UninterpretedOption; // 0x18
        public r>k__BackingField.resentations<ate.ePoint>g__ClosestPointOnSegment|9_2> uninterpretedOption_; // 0x38

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFD4E3447C0
        public void get_Parser(){} // RVA: 0x7FFD53625D30
        public void get_Descriptor(){} // RVA: 0x7FFD53625D90
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD53625E50
        public void .ctor(){} // RVA: 0x7FFD53626000 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD53626240
        public void get_Ctype(){} // RVA: 0x7FFD536262A0
        public void set_Ctype(){} // RVA: 0x7FFD53626310
        public void get_HasCtype(){} // RVA: 0x7FFD53621340
        public void ClearCtype(){} // RVA: 0x7FFD53621350
        public void get_Packed(){} // RVA: 0x7FFD53626320
        public void set_Packed(){} // RVA: 0x7FFD53626390
        public void get_HasPacked(){} // RVA: 0x7FFD53621160
        public void ClearPacked(){} // RVA: 0x7FFD53621170
        public void get_Jstype(){} // RVA: 0x7FFD536263A0
        public void set_Jstype(){} // RVA: 0x7FFD53626410
        public void get_HasJstype(){} // RVA: 0x7FFD53621690
        public void ClearJstype(){} // RVA: 0x7FFD536216A0
        public void get_Lazy(){} // RVA: 0x7FFD53626420
        public void set_Lazy(){} // RVA: 0x7FFD53626490
        public void get_HasLazy(){} // RVA: 0x7FFD536215F0
        public void ClearLazy(){} // RVA: 0x7FFD53621600
        public void get_UnverifiedLazy(){} // RVA: 0x7FFD536264A0
        public void set_UnverifiedLazy(){} // RVA: 0x7FFD53626510
        public void get_HasUnverifiedLazy(){} // RVA: 0x7FFD536217D0
        public void ClearUnverifiedLazy(){} // RVA: 0x7FFD536217E0
        public void get_Deprecated(){} // RVA: 0x7FFD53626520
        public void set_Deprecated(){} // RVA: 0x7FFD53626590
        public void get_HasDeprecated(){} // RVA: 0x7FFD53621550
        public void ClearDeprecated(){} // RVA: 0x7FFD53621560
        public void get_Weak(){} // RVA: 0x7FFD536265A0
        public void set_Weak(){} // RVA: 0x7FFD53626610
        public void get_HasWeak(){} // RVA: 0x7FFD53621200
        public void ClearWeak(){} // RVA: 0x7FFD53621210
        public void get_UninterpretedOption(){} // RVA: 0x7FFD4E5F0140
        public void Equals(){} // RVA: 0x7FFD53626680 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53626860
        public void ToString(){} // RVA: 0x7FFD53626A10
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD53626A60
        public void CalculateSize(){} // RVA: 0x7FFD53626C70
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD53627070
        public void GetExtension(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFD4E078F40
        public void SetExtension(){} // RVA: 0x7FFD4E2ADC40
        public void HasExtension(){} // RVA: 0x7FFD4E079F60
        public void ClearExtension(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD536272C0
    }

    public class FileDescriptor : Object
    {
        public dle<URA.DateTime<ate.thSize,ate.?>> Proto; // 0x10
        public ate.ed Syntax; // 0x18
        public ate.? Name; // 0x20
        public URA.?<ate.nt64Size> Package; // 0x28
        public URA.?<ate.?> MessageTypes; // 0x30
        public URA.?<ate.portsPacking> EnumTypes; // 0x38
        public ate.royProfileCopy Services; // 0x40
        public URA.?<ate.ination> Extensions; // 0x48
        public URA.?<ate.ination> Dependencies; // 0x50
        public gBox.mumDistance PublicDependencies; // 0x58
        public ate.t Google.Protobuf.Reflection.IDescriptor.FullName; // 0x60

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD5363A9B0
        public void .ctor(){} // RVA: 0x7FFD5363AA60
        public void CreateDeclarationMap(){} // RVA: 0x7FFD5363B3E0
        public void FindDescriptorForPath(){} // RVA: 0x7FFD5363B6D0
        public void GetDescriptorFromList(){} // RVA: 0x7FFD5363BA80
        public void GetNestedDescriptorListForField(){} // RVA: 0x7FFD5363BBC0
        public void ComputeFullName(){} // RVA: 0x7FFD5363BCA0
        public void DeterminePublicDependencies(){} // RVA: 0x7FFD5363BD40
        public void get_Proto(){} // RVA: 0x7FFD4E3447C0
        public void get_Syntax(){} // RVA: 0x7FFD4E4FBBE0
        public void get_Name(){} // RVA: 0x7FFD5363C190
        public void get_Package(){} // RVA: 0x7FFD5363C200
        public void get_MessageTypes(){} // RVA: 0x7FFD4E36F130
        public void get_EnumTypes(){} // RVA: 0x7FFD4E5F95E0
        public void get_Services(){} // RVA: 0x7FFD4E5F0140
        public void get_Extensions(){} // RVA: 0x7FFD4E3BE740
        public void get_Dependencies(){} // RVA: 0x7FFD4E3BC730
        public void get_PublicDependencies(){} // RVA: 0x7FFD4E3E20E0
        public void Google.Protobuf.Reflection.IDescriptor.get_FullName(){} // RVA: 0x7FFD5363C270
        public void Google.Protobuf.Reflection.IDescriptor.get_File(){} // RVA: 0x7FFD4F9181E0
        public void get_DescriptorPool(){} // RVA: 0x7FFD4E3DF370
        public void BuildFrom(){} // RVA: 0x7FFD5363C280
        public void CrossLink(){} // RVA: 0x7FFD5363C410
        public void FromGeneratedCode(){} // RVA: 0x7FFD5363C7C0
        public void GetAllExtensions(){} // RVA: 0x7FFD5363CD90
        public void GetAllGeneratedExtensions(){} // RVA: 0x7FFD5363CF30
        public void GetAllDependedExtensions(){} // RVA: 0x7FFD5363D150
        public void GetAllDependedExtensionsFromMessage(){} // RVA: 0x7FFD5363D560
        public void ToString(){} // RVA: 0x7FFD5363D8D0
        public void ForceReflectionInitialization(){} // RVA: 0x7FFD4E0909B0
    }

    public class FileOptions : Object
    {
        public gBox.itionBlend<ate.LanguageInAppX> _Extensions;
        public gBox.ra Parser; // 0x10
        public gBox.centerTarget<ate.LanguageInAppX> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public string JavaPackage; // 0x8
        public string HasJavaPackage; // 0x28
        public string JavaOuterClassname; // 0x10
        public string HasJavaOuterClassname; // 0x30
        public bool JavaMultipleFiles; // 0x18
        public bool HasJavaMultipleFiles; // 0x38
        public bool JavaGenerateEqualsAndHash; // 0x19
        public bool HasJavaGenerateEqualsAndHash; // 0x39
        public bool JavaStringCheckUtf8; // 0x1A
        public bool HasJavaStringCheckUtf8; // 0x3A
        public oint OptimizeFor; // 0x1C
        public oint HasOptimizeFor; // 0x3C
        public string GoPackage; // 0x20
        public string HasGoPackage; // 0x40
        public bool CcGenericServices; // 0x28
        public bool HasCcGenericServices; // 0x48
        public bool JavaGenericServices; // 0x29
        public bool HasJavaGenericServices; // 0x49
        public bool PyGenericServices; // 0x2A
        public bool HasPyGenericServices; // 0x4A
        public bool PhpGenericServices; // 0x2B
        public bool HasPhpGenericServices; // 0x4B
        public bool Deprecated; // 0x2C
        public bool HasDeprecated; // 0x4C
        public bool CcEnableArenas; // 0x2D
        public bool HasCcEnableArenas; // 0x4D
        public string ObjcClassPrefix; // 0x30
        public string HasObjcClassPrefix; // 0x50
        public string CsharpNamespace; // 0x38
        public string HasCsharpNamespace; // 0x58
        public string SwiftPrefix; // 0x40
        public string HasSwiftPrefix; // 0x60
        public string PhpClassPrefix; // 0x48
        public string HasPhpClassPrefix; // 0x68
        public string PhpNamespace; // 0x50
        public string HasPhpNamespace; // 0x70
        public string PhpMetadataNamespace; // 0x58
        public string HasPhpMetadataNamespace; // 0x78
        public string RubyPackage; // 0x60
        public string HasRubyPackage; // 0x80
        public gBox.PathNoRoll<ate.ePoint>g__ClosestPointOnSegment|9_2> UninterpretedOption; // 0x68
        public r>k__BackingField.resentations<ate.ePoint>g__ClosestPointOnSegment|9_2> uninterpretedOption_; // 0x88

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFD4E3447C0
        public void get_Parser(){} // RVA: 0x7FFD53620530
        public void get_Descriptor(){} // RVA: 0x7FFD53620590
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD53620650
        public void .ctor(){} // RVA: 0x7FFD53620800 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD53620DA0
        public void get_JavaPackage(){} // RVA: 0x7FFD53620E00
        public void set_JavaPackage(){} // RVA: 0x7FFD53620E70
        public void get_HasJavaPackage(){} // RVA: 0x7FFD5361F390
        public void ClearJavaPackage(){} // RVA: 0x7FFD50812F70
        public void get_JavaOuterClassname(){} // RVA: 0x7FFD53620F70
        public void set_JavaOuterClassname(){} // RVA: 0x7FFD53620FE0
        public void get_HasJavaOuterClassname(){} // RVA: 0x7FFD52C3E0A0
        public void ClearJavaOuterClassname(){} // RVA: 0x7FFD5361F510
        public void get_JavaMultipleFiles(){} // RVA: 0x7FFD536210E0
        public void set_JavaMultipleFiles(){} // RVA: 0x7FFD53621150
        public void get_HasJavaMultipleFiles(){} // RVA: 0x7FFD53621160
        public void ClearJavaMultipleFiles(){} // RVA: 0x7FFD53621170
        public void get_JavaGenerateEqualsAndHash(){} // RVA: 0x7FFD53621180
        public void set_JavaGenerateEqualsAndHash(){} // RVA: 0x7FFD536211F0
        public void get_HasJavaGenerateEqualsAndHash(){} // RVA: 0x7FFD53621200
        public void ClearJavaGenerateEqualsAndHash(){} // RVA: 0x7FFD53621210
        public void get_JavaStringCheckUtf8(){} // RVA: 0x7FFD53621220
        public void set_JavaStringCheckUtf8(){} // RVA: 0x7FFD53621290
        public void get_HasJavaStringCheckUtf8(){} // RVA: 0x7FFD536212A0
        public void ClearJavaStringCheckUtf8(){} // RVA: 0x7FFD536212B0
        public void get_OptimizeFor(){} // RVA: 0x7FFD536212C0
        public void set_OptimizeFor(){} // RVA: 0x7FFD53621330
        public void get_HasOptimizeFor(){} // RVA: 0x7FFD53621340
        public void ClearOptimizeFor(){} // RVA: 0x7FFD53621350
        public void get_GoPackage(){} // RVA: 0x7FFD53621360
        public void set_GoPackage(){} // RVA: 0x7FFD536213D0
        public void get_HasGoPackage(){} // RVA: 0x7FFD52C3E0B0
        public void ClearGoPackage(){} // RVA: 0x7FFD53616D10
        public void get_CcGenericServices(){} // RVA: 0x7FFD536214D0
        public void set_CcGenericServices(){} // RVA: 0x7FFD53621540
        public void get_HasCcGenericServices(){} // RVA: 0x7FFD53621550
        public void ClearCcGenericServices(){} // RVA: 0x7FFD53621560
        public void get_JavaGenericServices(){} // RVA: 0x7FFD53621570
        public void set_JavaGenericServices(){} // RVA: 0x7FFD536215E0
        public void get_HasJavaGenericServices(){} // RVA: 0x7FFD536215F0
        public void ClearJavaGenericServices(){} // RVA: 0x7FFD53621600
        public void get_PyGenericServices(){} // RVA: 0x7FFD53621610
        public void set_PyGenericServices(){} // RVA: 0x7FFD53621680
        public void get_HasPyGenericServices(){} // RVA: 0x7FFD53621690
        public void ClearPyGenericServices(){} // RVA: 0x7FFD536216A0
        public void get_PhpGenericServices(){} // RVA: 0x7FFD536216B0
        public void set_PhpGenericServices(){} // RVA: 0x7FFD53621720
        public void get_HasPhpGenericServices(){} // RVA: 0x7FFD53621730
        public void ClearPhpGenericServices(){} // RVA: 0x7FFD53621740
        public void get_Deprecated(){} // RVA: 0x7FFD53621750
        public void set_Deprecated(){} // RVA: 0x7FFD536217C0
        public void get_HasDeprecated(){} // RVA: 0x7FFD536217D0
        public void ClearDeprecated(){} // RVA: 0x7FFD536217E0
        public void get_CcEnableArenas(){} // RVA: 0x7FFD536217F0
        public void set_CcEnableArenas(){} // RVA: 0x7FFD53621860
        public void get_HasCcEnableArenas(){} // RVA: 0x7FFD53621870
        public void ClearCcEnableArenas(){} // RVA: 0x7FFD53621880
        public void get_ObjcClassPrefix(){} // RVA: 0x7FFD53621890
        public void set_ObjcClassPrefix(){} // RVA: 0x7FFD53621900
        public void get_HasObjcClassPrefix(){} // RVA: 0x7FFD52C3EE40
        public void ClearObjcClassPrefix(){} // RVA: 0x7FFD4F8EE0C0
        public void get_CsharpNamespace(){} // RVA: 0x7FFD53621A00
        public void set_CsharpNamespace(){} // RVA: 0x7FFD53621A70
        public void get_HasCsharpNamespace(){} // RVA: 0x7FFD52C3EE50
        public void ClearCsharpNamespace(){} // RVA: 0x7FFD53617160
        public void get_SwiftPrefix(){} // RVA: 0x7FFD53621B70
        public void set_SwiftPrefix(){} // RVA: 0x7FFD53621BE0
        public void get_HasSwiftPrefix(){} // RVA: 0x7FFD4FC56B90
        public void ClearSwiftPrefix(){} // RVA: 0x7FFD53621CE0
        public void get_PhpClassPrefix(){} // RVA: 0x7FFD53621D40
        public void set_PhpClassPrefix(){} // RVA: 0x7FFD53621DB0
        public void get_HasPhpClassPrefix(){} // RVA: 0x7FFD4F221380
        public void ClearPhpClassPrefix(){} // RVA: 0x7FFD4F8EBCB0
        public void get_PhpNamespace(){} // RVA: 0x7FFD53621EB0
        public void set_PhpNamespace(){} // RVA: 0x7FFD53621F20
        public void get_HasPhpNamespace(){} // RVA: 0x7FFD5360E650
        public void ClearPhpNamespace(){} // RVA: 0x7FFD4F8EB460
        public void get_PhpMetadataNamespace(){} // RVA: 0x7FFD53622020
        public void set_PhpMetadataNamespace(){} // RVA: 0x7FFD53622090
        public void get_HasPhpMetadataNamespace(){} // RVA: 0x7FFD53622190
        public void ClearPhpMetadataNamespace(){} // RVA: 0x7FFD536221A0
        public void get_RubyPackage(){} // RVA: 0x7FFD53622200
        public void set_RubyPackage(){} // RVA: 0x7FFD53622270
        public void get_HasRubyPackage(){} // RVA: 0x7FFD53622370
        public void ClearRubyPackage(){} // RVA: 0x7FFD4F6F5870
        public void get_UninterpretedOption(){} // RVA: 0x7FFD4E380010
        public void Equals(){} // RVA: 0x7FFD536223E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53622990
        public void ToString(){} // RVA: 0x7FFD53622DE0
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD53622E30
        public void CalculateSize(){} // RVA: 0x7FFD536232C0
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD53623A40
        public void GetExtension(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFD4E078F40
        public void SetExtension(){} // RVA: 0x7FFD4E2ADC40
        public void HasExtension(){} // RVA: 0x7FFD4E079F60
        public void ClearExtension(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD53623FB0
    }

    public class MessageOptions : Object
    {
        public gBox.itionBlend<ate.ode> _Extensions;
        public gBox.ra Parser; // 0x10
        public gBox.centerTarget<ate.ode> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public bool MessageSetWireFormat; // 0x8
        public bool HasMessageSetWireFormat; // 0x24
        public bool NoStandardDescriptorAccessor; // 0x9
        public bool HasNoStandardDescriptorAccessor; // 0x25
        public bool Deprecated; // 0xA
        public bool HasDeprecated; // 0x26
        public bool MapEntry; // 0xB
        public bool HasMapEntry; // 0x27
        public gBox.PathNoRoll<ate.ePoint>g__ClosestPointOnSegment|9_2> UninterpretedOption; // 0x10
        public r>k__BackingField.resentations<ate.ePoint>g__ClosestPointOnSegment|9_2> uninterpretedOption_; // 0x28

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFD4E3447C0
        public void get_Parser(){} // RVA: 0x7FFD53624860
        public void get_Descriptor(){} // RVA: 0x7FFD536248C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD53624980
        public void .ctor(){} // RVA: 0x7FFD53624B30 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD53624D60
        public void get_MessageSetWireFormat(){} // RVA: 0x7FFD53624DC0
        public void set_MessageSetWireFormat(){} // RVA: 0x7FFD53624E30
        public void get_HasMessageSetWireFormat(){} // RVA: 0x7FFD53621340
        public void ClearMessageSetWireFormat(){} // RVA: 0x7FFD53621350
        public void get_NoStandardDescriptorAccessor(){} // RVA: 0x7FFD53624E40
        public void set_NoStandardDescriptorAccessor(){} // RVA: 0x7FFD53624EB0
        public void get_HasNoStandardDescriptorAccessor(){} // RVA: 0x7FFD53621160
        public void ClearNoStandardDescriptorAccessor(){} // RVA: 0x7FFD53621170
        public void get_Deprecated(){} // RVA: 0x7FFD53624EC0
        public void set_Deprecated(){} // RVA: 0x7FFD53624F30
        public void get_HasDeprecated(){} // RVA: 0x7FFD53621550
        public void ClearDeprecated(){} // RVA: 0x7FFD53621560
        public void get_MapEntry(){} // RVA: 0x7FFD53624F40
        public void set_MapEntry(){} // RVA: 0x7FFD53624FB0
        public void get_HasMapEntry(){} // RVA: 0x7FFD536215F0
        public void ClearMapEntry(){} // RVA: 0x7FFD53621600
        public void get_UninterpretedOption(){} // RVA: 0x7FFD4E36F130
        public void Equals(){} // RVA: 0x7FFD53625020 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD536251A0
        public void ToString(){} // RVA: 0x7FFD53625300
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD53625350
        public void CalculateSize(){} // RVA: 0x7FFD536254E0
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD536257A0
        public void GetExtension(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFD4E078F40
        public void SetExtension(){} // RVA: 0x7FFD4E2ADC40
        public void HasExtension(){} // RVA: 0x7FFD4E079F60
        public void ClearExtension(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD53625970
    }

    public class MethodOptions : Object
    {
        public gBox.itionBlend<ate.s> _Extensions;
        public gBox.ra Parser; // 0x10
        public gBox.centerTarget<ate.s> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public bool Deprecated; // 0x8
        public bool HasDeprecated; // 0x24
        public on IdempotencyLevel; // 0xC
        public on HasIdempotencyLevel; // 0x28
        public gBox.PathNoRoll<ate.ePoint>g__ClosestPointOnSegment|9_2> UninterpretedOption; // 0x10
        public r>k__BackingField.resentations<ate.ePoint>g__ClosestPointOnSegment|9_2> uninterpretedOption_; // 0x30

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFD4E3447C0
        public void get_Parser(){} // RVA: 0x7FFD5362BC90
        public void get_Descriptor(){} // RVA: 0x7FFD5362BCF0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD5362BDB0
        public void .ctor(){} // RVA: 0x7FFD5362BF60 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD5362C180
        public void get_Deprecated(){} // RVA: 0x7FFD5362C1E0
        public void set_Deprecated(){} // RVA: 0x7FFD53624E30
        public void get_HasDeprecated(){} // RVA: 0x7FFD53621340
        public void ClearDeprecated(){} // RVA: 0x7FFD53621350
        public void get_IdempotencyLevel(){} // RVA: 0x7FFD5362C250
        public void set_IdempotencyLevel(){} // RVA: 0x7FFD5362C2C0
        public void get_HasIdempotencyLevel(){} // RVA: 0x7FFD53621160
        public void ClearIdempotencyLevel(){} // RVA: 0x7FFD53621170
        public void get_UninterpretedOption(){} // RVA: 0x7FFD4E5F95E0
        public void Equals(){} // RVA: 0x7FFD5362C440 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD5362C580
        public void ToString(){} // RVA: 0x7FFD5362C670
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD5362C6C0
        public void CalculateSize(){} // RVA: 0x7FFD5362C800
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD5362CB00
        public void GetExtension(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFD4E078F40
        public void SetExtension(){} // RVA: 0x7FFD4E2ADC40
        public void HasExtension(){} // RVA: 0x7FFD4E079F60
        public void ClearExtension(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD5362CC80
    }

    public class OneofOptions : Object
    {
        public gBox.itionBlend<ate.am> _Extensions;
        public gBox.ra Parser; // 0x10
        public gBox.centerTarget<ate.am> Descriptor; // 0x18
        public gBox.PathNoRoll<ate.ePoint>g__ClosestPointOnSegment|9_2> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public r>k__BackingField.resentations<ate.ePoint>g__ClosestPointOnSegment|9_2> UninterpretedOption; // 0x20

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFD4E3447C0
        public void get_Parser(){} // RVA: 0x7FFD536276B0
        public void get_Descriptor(){} // RVA: 0x7FFD53627710
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD536277D0
        public void .ctor(){} // RVA: 0x7FFD53627980 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD53627B90
        public void get_UninterpretedOption(){} // RVA: 0x7FFD4E36F0C0
        public void Equals(){} // RVA: 0x7FFD53627D30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53615890
        public void ToString(){} // RVA: 0x7FFD53627E20
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD53627E70
        public void CalculateSize(){} // RVA: 0x7FFD53627F60
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD536281A0
        public void GetExtension(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFD4E078F40
        public void SetExtension(){} // RVA: 0x7FFD4E2ADC40
        public void HasExtension(){} // RVA: 0x7FFD4E079F60
        public void ClearExtension(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD536282D0
    }

    public class ReflectionUtil : Object
    {
        public ?[] CanConvertEnumFuncToInt32Func;
        public bool <CanConvertEnumFuncToInt32Func>k__BackingField; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD536421B0
        public void ForceInitialize(){} // RVA: 0x7FFD4E0909B0
        public void CreateFuncIMessageObject(){} // RVA: 0x7FFD536426F0
        public void CreateFuncIMessageInt32(){} // RVA: 0x7FFD53642840
        public void CreateActionIMessageObject(){} // RVA: 0x7FFD53642970
        public void CreateActionIMessage(){} // RVA: 0x7FFD53642AF0
        public void CreateFuncIMessageBool(){} // RVA: 0x7FFD53642CB0
        public void CreateExtensionHelper(){} // RVA: 0x7FFD53642E00
        public void GetReflectionHelper(){} // RVA: 0x7FFD536430E0
        public void get_CanConvertEnumFuncToInt32Func(){} // RVA: 0x7FFD536432E0
        public void CheckCanConvertEnumFuncToInt32Func(){} // RVA: 0x7FFD53643340
        public void SampleEnumMethod(){} // RVA: 0x7FFD4E919180
    }

    public class ServiceOptions : Object
    {
        public gBox.itionBlend<ate.nbeam> _Extensions;
        public gBox.ra Parser; // 0x10
        public gBox.centerTarget<ate.nbeam> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public bool Deprecated; // 0x8
        public bool HasDeprecated; // 0x24
        public gBox.PathNoRoll<ate.ePoint>g__ClosestPointOnSegment|9_2> UninterpretedOption; // 0x10
        public r>k__BackingField.resentations<ate.ePoint>g__ClosestPointOnSegment|9_2> uninterpretedOption_; // 0x28

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFD4E3447C0
        public void get_Parser(){} // RVA: 0x7FFD5362AB00
        public void get_Descriptor(){} // RVA: 0x7FFD5362AB60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD5362AC20
        public void .ctor(){} // RVA: 0x7FFD5362ADD0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD5362AFE0
        public void get_Deprecated(){} // RVA: 0x7FFD5362B040
        public void set_Deprecated(){} // RVA: 0x7FFD53624E30
        public void get_HasDeprecated(){} // RVA: 0x7FFD53621340
        public void ClearDeprecated(){} // RVA: 0x7FFD53621350
        public void get_UninterpretedOption(){} // RVA: 0x7FFD4E36F130
        public void Equals(){} // RVA: 0x7FFD5362B200 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD5362B310
        public void ToString(){} // RVA: 0x7FFD5362B3E0
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD5362B430
        public void CalculateSize(){} // RVA: 0x7FFD5362B550
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD5362B7B0
        public void GetExtension(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFD4E078F40
        public void SetExtension(){} // RVA: 0x7FFD4E2ADC40
        public void HasExtension(){} // RVA: 0x7FFD4E079F60
        public void ClearExtension(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD5362B900
    }

}