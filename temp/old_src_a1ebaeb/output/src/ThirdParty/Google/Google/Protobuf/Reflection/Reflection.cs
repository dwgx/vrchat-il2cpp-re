// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.Reflection
// Classes: 13
// Methods: 436

namespace ThirdParty.Google.Google.Protobuf.Reflection
{
    public class DescriptorPool : Object
    {
        public object enumValuesByNumber; // 0x31739FF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc362c0
        public void ImportPublicDependencies(){} // RVA: 0x7ffaadc36980
        public void FindSymbol(){} // RVA: 0x7ffaa887e5c0
        public void AddPackage(){} // RVA: 0x7ffaadc36bb0
        public void AddSymbol(){} // RVA: 0x7ffaadc36fb0
        public void ValidateSymbolName(){} // RVA: 0x7ffaadc373d0
        public void FindFieldByNumber(){} // RVA: 0x7ffaadc37650
        public void AddFieldByNumber(){} // RVA: 0x7ffaadc377b0
        public void AddEnumValueByNumber(){} // RVA: 0x7ffaadc37bd0
        public void LookupSymbol(){} // RVA: 0x7ffaadc37e20
        public void .cctor(){} // RVA: 0x7ffaadc38110
    }

    public class DescriptorUtil : Object
    {
        // ── Original Methods ──
        public void ConvertAndMakeReadOnly(){} // RVA: 0x7ffaa8649330
    }

    public class EnumOptions : Object
    {
        public object _extensions; // 0x3173B9A0
        public object allowAlias_; // 0x3173B9A0
        public object _repeated_uninterpretedOption_codec; // 0x3173B9A0

        // ── Original Methods ──
        public void get__Extensions(){} // RVA: 0x7ffaa89357c0
        public void get_Parser(){} // RVA: 0x7ffaadc29800
        public void get_Descriptor(){} // RVA: 0x7ffaadc29860
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadc29920
        public void .ctor(){} // RVA: 0x7ffaadc29ad0
        public void .ctor(){} // RVA: 0x7ffaadc29ad0
        public void Clone(){} // RVA: 0x7ffaadc29cf0
        public void get_AllowAlias(){} // RVA: 0x7ffaadc29d50
        public void set_AllowAlias(){} // RVA: 0x7ffaadc25fe0
        public void get_HasAllowAlias(){} // RVA: 0x7ffaadc224f0
        public void ClearAllowAlias(){} // RVA: 0x7ffaadc22500
        public void get_Deprecated(){} // RVA: 0x7ffaadc29dc0
        public void set_Deprecated(){} // RVA: 0x7ffaadc26060
        public void get_HasDeprecated(){} // RVA: 0x7ffaadc22310
        public void ClearDeprecated(){} // RVA: 0x7ffaadc22320
        public void get_UninterpretedOption(){} // RVA: 0x7ffaa8960130
        public void Equals(){} // RVA: 0x7ffaadc29fa0
        public void Equals(){} // RVA: 0x7ffaadc29fa0
        public void ToString(){} // RVA: 0x7ffaadc2a1f0
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadc2a240
        public void CalculateSize(){} // RVA: 0x7ffaadc2a380
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadc2a610
        public void HasExtension(){} // RVA: 0x7ffaa864a2a0
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void .cctor(){} // RVA: 0x7ffaadc2a790
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadc2a0e0
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetOrInitializeExtension(){} // RVA: 0x7ffaa8649280
        public void SetExtension(){} // RVA: 0x7ffaa887e5c0
    }

    public class EnumValueOptions : Object
    {
        public object _extensions; // 0x3173BC20
        public object deprecated_; // 0x3173BC20

        // ── Original Methods ──
        public void get__Extensions(){} // RVA: 0x7ffaa89357c0
        public void get_Parser(){} // RVA: 0x7ffaadc2ab30
        public void get_Descriptor(){} // RVA: 0x7ffaadc2ab90
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadc2ac50
        public void .ctor(){} // RVA: 0x7ffaadc2ae00
        public void .ctor(){} // RVA: 0x7ffaadc2ae00
        public void Clone(){} // RVA: 0x7ffaadc2b010
        public void get_Deprecated(){} // RVA: 0x7ffaadc2b070
        public void set_Deprecated(){} // RVA: 0x7ffaadc25fe0
        public void get_HasDeprecated(){} // RVA: 0x7ffaadc224f0
        public void ClearDeprecated(){} // RVA: 0x7ffaadc22500
        public void get_UninterpretedOption(){} // RVA: 0x7ffaa8960130
        public void Equals(){} // RVA: 0x7ffaadc2b230
        public void Equals(){} // RVA: 0x7ffaadc2b230
        public void ToString(){} // RVA: 0x7ffaadc2b410
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadc2b460
        public void CalculateSize(){} // RVA: 0x7ffaadc2b570
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadc2b7d0
        public void HasExtension(){} // RVA: 0x7ffaa864a2a0
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void .cctor(){} // RVA: 0x7ffaadc2b920
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadc2b340
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetOrInitializeExtension(){} // RVA: 0x7ffaa8649280
        public void SetExtension(){} // RVA: 0x7ffaa887e5c0
    }

    public class ExtensionRangeOptions : Object
    {
        public object _extensions; // 0x317521B0

        // ── Original Methods ──
        public void get__Extensions(){} // RVA: 0x7ffaa89357c0
        public void get_Parser(){} // RVA: 0x7ffaadc162d0
        public void get_Descriptor(){} // RVA: 0x7ffaadc16330
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadc163f0
        public void .ctor(){} // RVA: 0x7ffaadc165a0
        public void .ctor(){} // RVA: 0x7ffaadc165a0
        public void Clone(){} // RVA: 0x7ffaadc167b0
        public void get_UninterpretedOption(){} // RVA: 0x7ffaa89600c0
        public void Equals(){} // RVA: 0x7ffaadc16950
        public void Equals(){} // RVA: 0x7ffaadc16950
        public void ToString(){} // RVA: 0x7ffaadc16ad0
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadc16b20
        public void CalculateSize(){} // RVA: 0x7ffaadc16c10
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadc16e50
        public void HasExtension(){} // RVA: 0x7ffaa864a2a0
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void .cctor(){} // RVA: 0x7ffaadc16f80
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadc16a40
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetOrInitializeExtension(){} // RVA: 0x7ffaa8649280
        public void SetExtension(){} // RVA: 0x7ffaa887e5c0
    }

    public class FieldOptions : Object
    {
        public object _extensions; // 0x317530B0
        public object ctype_; // 0x317530B0
        public object JstypeDefaultValue; // 0x317530B0
        public object lazy_; // 0x317530B0
        public object DeprecatedDefaultValue; // 0x317530B0
        public object weak_; // 0x317530B0

        // ── Original Methods ──
        public void get__Extensions(){} // RVA: 0x7ffaa89357c0
        public void get_Parser(){} // RVA: 0x7ffaadc26ee0
        public void get_Descriptor(){} // RVA: 0x7ffaadc26f40
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadc27000
        public void .ctor(){} // RVA: 0x7ffaadc271b0
        public void .ctor(){} // RVA: 0x7ffaadc271b0
        public void Clone(){} // RVA: 0x7ffaadc273f0
        public void get_Ctype(){} // RVA: 0x7ffaadc27450
        public void set_Ctype(){} // RVA: 0x7ffaadc274c0
        public void get_HasCtype(){} // RVA: 0x7ffaadc224f0
        public void ClearCtype(){} // RVA: 0x7ffaadc22500
        public void get_Packed(){} // RVA: 0x7ffaadc274d0
        public void set_Packed(){} // RVA: 0x7ffaadc27540
        public void get_HasPacked(){} // RVA: 0x7ffaadc22310
        public void ClearPacked(){} // RVA: 0x7ffaadc22320
        public void get_Jstype(){} // RVA: 0x7ffaadc27550
        public void set_Jstype(){} // RVA: 0x7ffaadc275c0
        public void get_HasJstype(){} // RVA: 0x7ffaadc22840
        public void ClearJstype(){} // RVA: 0x7ffaadc22850
        public void get_Lazy(){} // RVA: 0x7ffaadc275d0
        public void set_Lazy(){} // RVA: 0x7ffaadc27640
        public void get_HasLazy(){} // RVA: 0x7ffaadc227a0
        public void ClearLazy(){} // RVA: 0x7ffaadc227b0
        public void get_UnverifiedLazy(){} // RVA: 0x7ffaadc27650
        public void set_UnverifiedLazy(){} // RVA: 0x7ffaadc276c0
        public void get_HasUnverifiedLazy(){} // RVA: 0x7ffaadc22980
        public void ClearUnverifiedLazy(){} // RVA: 0x7ffaadc22990
        public void get_Deprecated(){} // RVA: 0x7ffaadc276d0
        public void set_Deprecated(){} // RVA: 0x7ffaadc27740
        public void get_HasDeprecated(){} // RVA: 0x7ffaadc22700
        public void ClearDeprecated(){} // RVA: 0x7ffaadc22710
        public void get_Weak(){} // RVA: 0x7ffaadc27750
        public void set_Weak(){} // RVA: 0x7ffaadc277c0
        public void get_HasWeak(){} // RVA: 0x7ffaadc223b0
        public void ClearWeak(){} // RVA: 0x7ffaadc223c0
        public void get_UninterpretedOption(){} // RVA: 0x7ffaa8bf45b0
        public void Equals(){} // RVA: 0x7ffaadc27830
        public void Equals(){} // RVA: 0x7ffaadc27830
        public void ToString(){} // RVA: 0x7ffaadc27bc0
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadc27c10
        public void CalculateSize(){} // RVA: 0x7ffaadc27e20
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadc28220
        public void HasExtension(){} // RVA: 0x7ffaa864a2a0
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void .cctor(){} // RVA: 0x7ffaadc28470
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadc27a10
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetOrInitializeExtension(){} // RVA: 0x7ffaa8649280
        public void SetExtension(){} // RVA: 0x7ffaa887e5c0
    }

    public class FileDescriptor : Object
    {
        public object _syntax; // 0x31753330, was: <Syntax>k__BackingField
        public object _services; // 0x31753330, was: <Services>k__BackingField
        public object _publicDependencies; // 0x31753330, was: <PublicDependencies>k__Backing

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaadc3bb60
        public void .ctor(){} // RVA: 0x7ffaadc3bc10
        public void CreateDeclarationMap(){} // RVA: 0x7ffaadc3c590
        public void FindDescriptorForPath(){} // RVA: 0x7ffaadc3c880
        public void ComputeFullName(){} // RVA: 0x7ffaadc3ce50
        public void DeterminePublicDependencies(){} // RVA: 0x7ffaadc3cef0
        public void get_Proto(){} // RVA: 0x7ffaa89357c0
        public void get_Syntax(){} // RVA: 0x7ffaa8aeced0
        public void get_Name(){} // RVA: 0x7ffaadc3d340
        public void get_Package(){} // RVA: 0x7ffaadc3d3b0
        public void get_MessageTypes(){} // RVA: 0x7ffaa8960130
        public void get_EnumTypes(){} // RVA: 0x7ffaa8bfcc80
        public void get_Services(){} // RVA: 0x7ffaa8bf45b0
        public void get_Extensions(){} // RVA: 0x7ffaa89af740
        public void get_Dependencies(){} // RVA: 0x7ffaa89ad730
        public void get_PublicDependencies(){} // RVA: 0x7ffaa89d30e0
        public void Google.Protobuf.Reflection.IDescriptor.get_FullName(){} // RVA: 0x7ffaadc3d420
        public void Google.Protobuf.Reflection.IDescriptor.get_File(){} // RVA: 0x7ffaa9f19100
        public void get_DescriptorPool(){} // RVA: 0x7ffaa89d0370
        public void BuildFrom(){} // RVA: 0x7ffaadc3d430
        public void CrossLink(){} // RVA: 0x7ffaadc3d5c0
        public void FromGeneratedCode(){} // RVA: 0x7ffaadc3d970
        public void ToString(){} // RVA: 0x7ffaadc3ea80
        public void ForceReflectionInitialization(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetDescriptorFromList(){} // RVA: 0x7ffaadc3cc30
        public void GetNestedDescriptorListForField(){} // RVA: 0x7ffaadc3cd70
        public void GetAllExtensions(){} // RVA: 0x7ffaadc3df40
        public void GetAllGeneratedExtensions(){} // RVA: 0x7ffaadc3e0e0
        public void GetAllDependedExtensions(){} // RVA: 0x7ffaadc3e300
        public void GetAllDependedExtensionsFromMessage(){} // RVA: 0x7ffaadc3e710
    }

    public class FileOptions : Object
    {
        public object _extensions; // 0x317534E0
        public object javaPackage_; // 0x317534E0
        public object JavaMultipleFilesDefaultValue; // 0x317534E0
        public object javaGenerateEqualsAndHash_; // 0x317534E0
        public object OptimizeForDefaultValue; // 0x317534E0
        public object goPackage_; // 0x317534E0
        public object JavaGenericServicesDefaultValue; // 0x317534E0
        public object pyGenericServices_; // 0x317534E0
        public object DeprecatedDefaultValue; // 0x317534E0
        public object ccEnableArenas_; // 0x317534E0
        public object CsharpNamespaceDefaultValue; // 0x317534E0
        public object swiftPrefix_; // 0x317534E0
        public object PhpNamespaceDefaultValue; // 0x317534E0
        public object phpMetadataNamespace_; // 0x317534E0
        public object _repeated_uninterpretedOption_codec; // 0x317534E0

        // ── Original Methods ──
        public void get__Extensions(){} // RVA: 0x7ffaa89357c0
        public void get_Parser(){} // RVA: 0x7ffaadc216e0
        public void get_Descriptor(){} // RVA: 0x7ffaadc21740
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadc21800
        public void .ctor(){} // RVA: 0x7ffaadc219b0
        public void .ctor(){} // RVA: 0x7ffaadc219b0
        public void Clone(){} // RVA: 0x7ffaadc21f50
        public void get_JavaPackage(){} // RVA: 0x7ffaadc21fb0
        public void set_JavaPackage(){} // RVA: 0x7ffaadc22020
        public void get_HasJavaPackage(){} // RVA: 0x7ffaadc20540
        public void ClearJavaPackage(){} // RVA: 0x7ffaaadf67e0
        public void get_JavaOuterClassname(){} // RVA: 0x7ffaadc22120
        public void set_JavaOuterClassname(){} // RVA: 0x7ffaadc22190
        public void get_HasJavaOuterClassname(){} // RVA: 0x7ffaad26b400
        public void ClearJavaOuterClassname(){} // RVA: 0x7ffaadc206c0
        public void get_JavaMultipleFiles(){} // RVA: 0x7ffaadc22290
        public void set_JavaMultipleFiles(){} // RVA: 0x7ffaadc22300
        public void get_HasJavaMultipleFiles(){} // RVA: 0x7ffaadc22310
        public void ClearJavaMultipleFiles(){} // RVA: 0x7ffaadc22320
        public void get_JavaGenerateEqualsAndHash(){} // RVA: 0x7ffaadc22330
        public void set_JavaGenerateEqualsAndHash(){} // RVA: 0x7ffaadc223a0
        public void get_HasJavaGenerateEqualsAndHash(){} // RVA: 0x7ffaadc223b0
        public void ClearJavaGenerateEqualsAndHash(){} // RVA: 0x7ffaadc223c0
        public void get_JavaStringCheckUtf8(){} // RVA: 0x7ffaadc223d0
        public void set_JavaStringCheckUtf8(){} // RVA: 0x7ffaadc22440
        public void get_HasJavaStringCheckUtf8(){} // RVA: 0x7ffaadc22450
        public void ClearJavaStringCheckUtf8(){} // RVA: 0x7ffaadc22460
        public void get_OptimizeFor(){} // RVA: 0x7ffaadc22470
        public void set_OptimizeFor(){} // RVA: 0x7ffaadc224e0
        public void get_HasOptimizeFor(){} // RVA: 0x7ffaadc224f0
        public void ClearOptimizeFor(){} // RVA: 0x7ffaadc22500
        public void get_GoPackage(){} // RVA: 0x7ffaadc22510
        public void set_GoPackage(){} // RVA: 0x7ffaadc22580
        public void get_HasGoPackage(){} // RVA: 0x7ffaad26b4b0
        public void ClearGoPackage(){} // RVA: 0x7ffaadc17ec0
        public void get_CcGenericServices(){} // RVA: 0x7ffaadc22680
        public void set_CcGenericServices(){} // RVA: 0x7ffaadc226f0
        public void get_HasCcGenericServices(){} // RVA: 0x7ffaadc22700
        public void ClearCcGenericServices(){} // RVA: 0x7ffaadc22710
        public void get_JavaGenericServices(){} // RVA: 0x7ffaadc22720
        public void set_JavaGenericServices(){} // RVA: 0x7ffaadc22790
        public void get_HasJavaGenericServices(){} // RVA: 0x7ffaadc227a0
        public void ClearJavaGenericServices(){} // RVA: 0x7ffaadc227b0
        public void get_PyGenericServices(){} // RVA: 0x7ffaadc227c0
        public void set_PyGenericServices(){} // RVA: 0x7ffaadc22830
        public void get_HasPyGenericServices(){} // RVA: 0x7ffaadc22840
        public void ClearPyGenericServices(){} // RVA: 0x7ffaadc22850
        public void get_PhpGenericServices(){} // RVA: 0x7ffaadc22860
        public void set_PhpGenericServices(){} // RVA: 0x7ffaadc228d0
        public void get_HasPhpGenericServices(){} // RVA: 0x7ffaadc228e0
        public void ClearPhpGenericServices(){} // RVA: 0x7ffaadc228f0
        public void get_Deprecated(){} // RVA: 0x7ffaadc22900
        public void set_Deprecated(){} // RVA: 0x7ffaadc22970
        public void get_HasDeprecated(){} // RVA: 0x7ffaadc22980
        public void ClearDeprecated(){} // RVA: 0x7ffaadc22990
        public void get_CcEnableArenas(){} // RVA: 0x7ffaadc229a0
        public void set_CcEnableArenas(){} // RVA: 0x7ffaadc22a10
        public void get_HasCcEnableArenas(){} // RVA: 0x7ffaadc22a20
        public void ClearCcEnableArenas(){} // RVA: 0x7ffaadc22a30
        public void get_ObjcClassPrefix(){} // RVA: 0x7ffaadc22a40
        public void set_ObjcClassPrefix(){} // RVA: 0x7ffaadc22ab0
        public void get_HasObjcClassPrefix(){} // RVA: 0x7ffaad26c1a0
        public void ClearObjcClassPrefix(){} // RVA: 0x7ffaa9ed5f40
        public void get_CsharpNamespace(){} // RVA: 0x7ffaadc22bb0
        public void set_CsharpNamespace(){} // RVA: 0x7ffaadc22c20
        public void get_HasCsharpNamespace(){} // RVA: 0x7ffaad26c610
        public void ClearCsharpNamespace(){} // RVA: 0x7ffaadc18310
        public void get_SwiftPrefix(){} // RVA: 0x7ffaadc22d20
        public void set_SwiftPrefix(){} // RVA: 0x7ffaadc22d90
        public void get_HasSwiftPrefix(){} // RVA: 0x7ffaaa23eaa0
        public void ClearSwiftPrefix(){} // RVA: 0x7ffaadc22e90
        public void get_PhpClassPrefix(){} // RVA: 0x7ffaadc22ef0
        public void set_PhpClassPrefix(){} // RVA: 0x7ffaadc22f60
        public void get_HasPhpClassPrefix(){} // RVA: 0x7ffaa98370e0
        public void ClearPhpClassPrefix(){} // RVA: 0x7ffaa9ed4d20
        public void get_PhpNamespace(){} // RVA: 0x7ffaadc23060
        public void set_PhpNamespace(){} // RVA: 0x7ffaadc230d0
        public void get_HasPhpNamespace(){} // RVA: 0x7ffaadc0f800
        public void ClearPhpNamespace(){} // RVA: 0x7ffaa9ed3bb0
        public void get_PhpMetadataNamespace(){} // RVA: 0x7ffaadc231d0
        public void set_PhpMetadataNamespace(){} // RVA: 0x7ffaadc23240
        public void get_HasPhpMetadataNamespace(){} // RVA: 0x7ffaadc23340
        public void ClearPhpMetadataNamespace(){} // RVA: 0x7ffaadc23350
        public void get_RubyPackage(){} // RVA: 0x7ffaadc233b0
        public void set_RubyPackage(){} // RVA: 0x7ffaadc23420
        public void get_HasRubyPackage(){} // RVA: 0x7ffaadc23520
        public void ClearRubyPackage(){} // RVA: 0x7ffaa9cfdc20
        public void get_UninterpretedOption(){} // RVA: 0x7ffaa8971010
        public void Equals(){} // RVA: 0x7ffaadc23590
        public void Equals(){} // RVA: 0x7ffaadc23590
        public void ToString(){} // RVA: 0x7ffaadc23f90
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadc23fe0
        public void CalculateSize(){} // RVA: 0x7ffaadc24470
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadc24bf0
        public void HasExtension(){} // RVA: 0x7ffaa864a2a0
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void .cctor(){} // RVA: 0x7ffaadc25160
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadc23b40
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetOrInitializeExtension(){} // RVA: 0x7ffaa8649280
        public void SetExtension(){} // RVA: 0x7ffaa887e5c0
    }

    public class MessageOptions : Object
    {
        public object _extensions; // 0x31831140
        public object messageSetWireFormat_; // 0x31831140
        public object DeprecatedDefaultValue; // 0x31831140
        public object mapEntry_; // 0x31831140

        // ── Original Methods ──
        public void get__Extensions(){} // RVA: 0x7ffaa89357c0
        public void get_Parser(){} // RVA: 0x7ffaadc25a10
        public void get_Descriptor(){} // RVA: 0x7ffaadc25a70
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadc25b30
        public void .ctor(){} // RVA: 0x7ffaadc25ce0
        public void .ctor(){} // RVA: 0x7ffaadc25ce0
        public void Clone(){} // RVA: 0x7ffaadc25f10
        public void get_MessageSetWireFormat(){} // RVA: 0x7ffaadc25f70
        public void set_MessageSetWireFormat(){} // RVA: 0x7ffaadc25fe0
        public void get_HasMessageSetWireFormat(){} // RVA: 0x7ffaadc224f0
        public void ClearMessageSetWireFormat(){} // RVA: 0x7ffaadc22500
        public void get_NoStandardDescriptorAccessor(){} // RVA: 0x7ffaadc25ff0
        public void set_NoStandardDescriptorAccessor(){} // RVA: 0x7ffaadc26060
        public void get_HasNoStandardDescriptorAccessor(){} // RVA: 0x7ffaadc22310
        public void ClearNoStandardDescriptorAccessor(){} // RVA: 0x7ffaadc22320
        public void get_Deprecated(){} // RVA: 0x7ffaadc26070
        public void set_Deprecated(){} // RVA: 0x7ffaadc260e0
        public void get_HasDeprecated(){} // RVA: 0x7ffaadc22700
        public void ClearDeprecated(){} // RVA: 0x7ffaadc22710
        public void get_MapEntry(){} // RVA: 0x7ffaadc260f0
        public void set_MapEntry(){} // RVA: 0x7ffaadc26160
        public void get_HasMapEntry(){} // RVA: 0x7ffaadc227a0
        public void ClearMapEntry(){} // RVA: 0x7ffaadc227b0
        public void get_UninterpretedOption(){} // RVA: 0x7ffaa8960130
        public void Equals(){} // RVA: 0x7ffaadc261d0
        public void Equals(){} // RVA: 0x7ffaadc261d0
        public void ToString(){} // RVA: 0x7ffaadc264b0
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadc26500
        public void CalculateSize(){} // RVA: 0x7ffaadc26690
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadc26950
        public void HasExtension(){} // RVA: 0x7ffaa864a2a0
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void .cctor(){} // RVA: 0x7ffaadc26b20
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadc26350
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetOrInitializeExtension(){} // RVA: 0x7ffaa8649280
        public void SetExtension(){} // RVA: 0x7ffaa887e5c0
    }

    public class MethodOptions : Object
    {
        public object _extensions; // 0x31831540
        public object deprecated_; // 0x31831540
        public object _repeated_uninterpretedOption_codec; // 0x31831540

        // ── Original Methods ──
        public void get__Extensions(){} // RVA: 0x7ffaa89357c0
        public void get_Parser(){} // RVA: 0x7ffaadc2ce40
        public void get_Descriptor(){} // RVA: 0x7ffaadc2cea0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadc2cf60
        public void .ctor(){} // RVA: 0x7ffaadc2d110
        public void .ctor(){} // RVA: 0x7ffaadc2d110
        public void Clone(){} // RVA: 0x7ffaadc2d330
        public void get_Deprecated(){} // RVA: 0x7ffaadc2d390
        public void set_Deprecated(){} // RVA: 0x7ffaadc25fe0
        public void get_HasDeprecated(){} // RVA: 0x7ffaadc224f0
        public void ClearDeprecated(){} // RVA: 0x7ffaadc22500
        public void get_IdempotencyLevel(){} // RVA: 0x7ffaadc2d400
        public void set_IdempotencyLevel(){} // RVA: 0x7ffaadc2d470
        public void get_HasIdempotencyLevel(){} // RVA: 0x7ffaadc22310
        public void ClearIdempotencyLevel(){} // RVA: 0x7ffaadc22320
        public void get_UninterpretedOption(){} // RVA: 0x7ffaa8bfcc80
        public void Equals(){} // RVA: 0x7ffaadc2d5f0
        public void Equals(){} // RVA: 0x7ffaadc2d5f0
        public void ToString(){} // RVA: 0x7ffaadc2d820
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadc2d870
        public void CalculateSize(){} // RVA: 0x7ffaadc2d9b0
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadc2dcb0
        public void HasExtension(){} // RVA: 0x7ffaa864a2a0
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void .cctor(){} // RVA: 0x7ffaadc2de30
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadc2d730
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetOrInitializeExtension(){} // RVA: 0x7ffaa8649280
        public void SetExtension(){} // RVA: 0x7ffaa887e5c0
    }

    public class OneofOptions : Object
    {
        public object _extensions; // 0x31858A50

        // ── Original Methods ──
        public void get__Extensions(){} // RVA: 0x7ffaa89357c0
        public void get_Parser(){} // RVA: 0x7ffaadc28860
        public void get_Descriptor(){} // RVA: 0x7ffaadc288c0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadc28980
        public void .ctor(){} // RVA: 0x7ffaadc28b30
        public void .ctor(){} // RVA: 0x7ffaadc28b30
        public void Clone(){} // RVA: 0x7ffaadc28d40
        public void get_UninterpretedOption(){} // RVA: 0x7ffaa89600c0
        public void Equals(){} // RVA: 0x7ffaadc28ee0
        public void Equals(){} // RVA: 0x7ffaadc28ee0
        public void ToString(){} // RVA: 0x7ffaadc28fd0
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadc29020
        public void CalculateSize(){} // RVA: 0x7ffaadc29110
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadc29350
        public void HasExtension(){} // RVA: 0x7ffaa864a2a0
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void .cctor(){} // RVA: 0x7ffaadc29480
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadc16a40
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetOrInitializeExtension(){} // RVA: 0x7ffaa8649280
        public void SetExtension(){} // RVA: 0x7ffaa887e5c0
    }

    public class ReflectionUtil : Object
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaadc43360
        public void ForceInitialize(){} // RVA: 0x7ffaa8660cf0
        public void CreateFuncIMessageObject(){} // RVA: 0x7ffaadc438a0
        public void CreateFuncIMessageInt32(){} // RVA: 0x7ffaadc439f0
        public void CreateActionIMessageObject(){} // RVA: 0x7ffaadc43b20
        public void CreateActionIMessage(){} // RVA: 0x7ffaadc43ca0
        public void CreateFuncIMessageBool(){} // RVA: 0x7ffaadc43e60
        public void CreateExtensionHelper(){} // RVA: 0x7ffaadc43fb0
        public void get_CanConvertEnumFuncToInt32Func(){} // RVA: 0x7ffaadc44490
        public void SampleEnumMethod(){} // RVA: 0x7ffaa8f22da0
        // ── Binary Analysis Named ──
        public void GetReflectionHelper(){} // RVA: 0x7ffaadc44290
        public void CheckCanConvertEnumFuncToInt32Func(){} // RVA: 0x7ffaadc444f0
    }

    public class ServiceOptions : Object
    {
        public object _extensions; // 0x318A8760
        public object deprecated_; // 0x318A8760

        // ── Original Methods ──
        public void get__Extensions(){} // RVA: 0x7ffaa89357c0
        public void get_Parser(){} // RVA: 0x7ffaadc2bcb0
        public void get_Descriptor(){} // RVA: 0x7ffaadc2bd10
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadc2bdd0
        public void .ctor(){} // RVA: 0x7ffaadc2bf80
        public void .ctor(){} // RVA: 0x7ffaadc2bf80
        public void Clone(){} // RVA: 0x7ffaadc2c190
        public void get_Deprecated(){} // RVA: 0x7ffaadc2c1f0
        public void set_Deprecated(){} // RVA: 0x7ffaadc25fe0
        public void get_HasDeprecated(){} // RVA: 0x7ffaadc224f0
        public void ClearDeprecated(){} // RVA: 0x7ffaadc22500
        public void get_UninterpretedOption(){} // RVA: 0x7ffaa8960130
        public void Equals(){} // RVA: 0x7ffaadc2c3b0
        public void Equals(){} // RVA: 0x7ffaadc2c3b0
        public void ToString(){} // RVA: 0x7ffaadc2c590
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadc2c5e0
        public void CalculateSize(){} // RVA: 0x7ffaadc2c700
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadc2c960
        public void HasExtension(){} // RVA: 0x7ffaa864a2a0
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void .cctor(){} // RVA: 0x7ffaadc2cab0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadc2c4c0
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetOrInitializeExtension(){} // RVA: 0x7ffaa8649280
        public void SetExtension(){} // RVA: 0x7ffaa887e5c0
    }

}