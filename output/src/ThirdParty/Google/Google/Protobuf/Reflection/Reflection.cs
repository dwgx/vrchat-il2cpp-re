// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.Reflection
// Classes: 13
// Methods: 436

namespace ThirdParty.Google.Google.Protobuf.Reflection
{
    public class DescriptorPool : Object
    {
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
        public object _Extensions;
        public object Parser;
        public object Descriptor;
        public object pb::Google.Protobuf.IMessage.Descriptor;
        public object AllowAlias;
        public object HasAllowAlias;
        public object Deprecated;
        public object HasDeprecated;
        public object UninterpretedOption;

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
        public object _Extensions;
        public object Parser;
        public object Descriptor;
        public object pb::Google.Protobuf.IMessage.Descriptor;
        public object Deprecated;
        public object HasDeprecated;
        public object UninterpretedOption;

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
        public object _Extensions;
        public object Parser;
        public object Descriptor;
        public object pb::Google.Protobuf.IMessage.Descriptor;
        public object UninterpretedOption;

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
        public object _Extensions;
        public object Parser;
        public object Descriptor;
        public object pb::Google.Protobuf.IMessage.Descriptor;
        public object Ctype;
        public object HasCtype;
        public object Packed;
        public object HasPacked;
        public object Jstype;
        public object HasJstype;
        public object Lazy;
        public object HasLazy;
        public object UnverifiedLazy;
        public object HasUnverifiedLazy;
        public object Deprecated;
        public object HasDeprecated;
        public object Weak;
        public object HasWeak;
        public object UninterpretedOption;

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
        public object Proto;
        public object Syntax;
        public object Name;
        public object Package;
        public object MessageTypes;
        public object EnumTypes;
        public object Services;
        public object Extensions;
        public object Dependencies;
        public object PublicDependencies;
        public object Google.Protobuf.Reflection.IDescriptor.FullName;
        public object Google.Protobuf.Reflection.IDescriptor.File;
        public object DescriptorPool;

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
        public object _Extensions;
        public object Parser;
        public object Descriptor;
        public object pb::Google.Protobuf.IMessage.Descriptor;
        public object JavaPackage;
        public object HasJavaPackage;
        public object JavaOuterClassname;
        public object HasJavaOuterClassname;
        public object JavaMultipleFiles;
        public object HasJavaMultipleFiles;
        public object JavaGenerateEqualsAndHash;
        public object HasJavaGenerateEqualsAndHash;
        public object JavaStringCheckUtf8;
        public object HasJavaStringCheckUtf8;
        public object OptimizeFor;
        public object HasOptimizeFor;
        public object GoPackage;
        public object HasGoPackage;
        public object CcGenericServices;
        public object HasCcGenericServices;
        public object JavaGenericServices;
        public object HasJavaGenericServices;
        public object PyGenericServices;
        public object HasPyGenericServices;
        public object PhpGenericServices;
        public object HasPhpGenericServices;
        public object Deprecated;
        public object HasDeprecated;
        public object CcEnableArenas;
        public object HasCcEnableArenas;
        public object ObjcClassPrefix;
        public object HasObjcClassPrefix;
        public object CsharpNamespace;
        public object HasCsharpNamespace;
        public object SwiftPrefix;
        public object HasSwiftPrefix;
        public object PhpClassPrefix;
        public object HasPhpClassPrefix;
        public object PhpNamespace;
        public object HasPhpNamespace;
        public object PhpMetadataNamespace;
        public object HasPhpMetadataNamespace;
        public object RubyPackage;
        public object HasRubyPackage;
        public object UninterpretedOption;

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
        public object _Extensions;
        public object Parser; // 0x4
        public string Descriptor; // 0x8
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x10
        public string MessageSetWireFormat; // 0x18
        public string HasMessageSetWireFormat; // 0x20
        public string NoStandardDescriptorAccessor; // 0x28
        public string HasNoStandardDescriptorAccessor; // 0x30
        public string Deprecated; // 0x38
        public ÎÌÍÏÏÌÍÏ HasDeprecated; // 0x10
        public rectoryInformation<ÎÏÌÎÎÎÌÌÌ.lerVisibility,ÎÏÌÎÎÎÌÌÌ.?> MapEntry; // 0x18
        public ÎÏÌÎÎÎÌÌÌ.? HasMapEntry; // 0x20
        public ÎÏÌÎÎÎÌÌÌ.omLeftRadius UninterpretedOption; // 0x28
        public CopyBackIndices.xDecl m_MultiColumnHeader; // 0x30

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
        public object _Extensions;
        public object Parser;
        public object Descriptor;
        public object pb::Google.Protobuf.IMessage.Descriptor;
        public object Deprecated;
        public object HasDeprecated;
        public object IdempotencyLevel;
        public object HasIdempotencyLevel;
        public object UninterpretedOption;

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
        public object _Extensions;
        public object Parser;
        public object Descriptor;
        public object pb::Google.Protobuf.IMessage.Descriptor;
        public object UninterpretedOption;

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
        public object CanConvertEnumFuncToInt32Func;

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
        public object _Extensions;
        public object Parser;
        public object Descriptor;
        public object pb::Google.Protobuf.IMessage.Descriptor;
        public object Deprecated;
        public object HasDeprecated;
        public object UninterpretedOption;

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