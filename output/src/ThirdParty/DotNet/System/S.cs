// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 100
// Methods: 1334

namespace ThirdParty.DotNet.System
{
    public class SByte : ValueType
    {
        public object m_value;

        // ── Methods ──
        public void CompareTo(){} // RVA: 0x8BB1E0
        public void Equals(){} // RVA: 0x8B0980
        public void GetHashCode(){} // RVA: 0x8BB250
        public void ToString(){} // RVA: 0x8BB290
        public void TryFormat(){} // RVA: 0x8BB2A0
        public void Parse(){} // RVA: 0x692AA70
        public void TryParse(){} // RVA: 0x692ADC0
        public void GetTypeCode(){} // RVA: 0x423A40
        public void System.IConvertible.ToBoolean(){} // RVA: 0x8BB2F0
        public void System.IConvertible.ToChar(){} // RVA: 0x8BB340
        public void System.IConvertible.ToSByte(){} // RVA: 0x90520
        public void System.IConvertible.ToByte(){} // RVA: 0x8BB3D0
        public void System.IConvertible.ToInt16(){} // RVA: 0x8BB460
        public void System.IConvertible.ToUInt16(){} // RVA: 0x8BB4B0
        public void System.IConvertible.ToInt32(){} // RVA: 0x8BB540
        public void System.IConvertible.ToUInt32(){} // RVA: 0x8BB550
        public void System.IConvertible.ToInt64(){} // RVA: 0x8BB5E0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x8BB630
        public void System.IConvertible.ToSingle(){} // RVA: 0x8BB6C0
        public void System.IConvertible.ToDouble(){} // RVA: 0x8BB710
        public void System.IConvertible.ToDecimal(){} // RVA: 0x8BB770
        public void System.IConvertible.ToDateTime(){} // RVA: 0x8BB830
        public void System.IConvertible.ToType(){} // RVA: 0x8BB840
    }

    public class SByte[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB7390
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A700
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC7990
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E70C00
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A700
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SR : Object
    {
        public object s_usingResourceKeys;
        public object s_resourceManager;

        // ── Methods ──
        public void UsingResourceKeys(){} // RVA: 0x72A05A0
        public void GetResourceString(){} // RVA: 0x72A0870
        public void Format(){} // RVA: 0x72A1740
        public void get_ResourceManager(){} // RVA: 0x72A1880
        public void get_ArrayDepthTooLarge(){} // RVA: 0x72A1A00
        public void get_CallFlushToAvoidDataLoss(){} // RVA: 0x72A1A60
        public void get_CannotReadIncompleteUTF16(){} // RVA: 0x72A1AC0
        public void get_CannotReadInvalidUTF16(){} // RVA: 0x72A1B20
        public void get_CannotStartObjectArrayAfterPrimitiveOrClose(){} // RVA: 0x72A1B80
        public void get_CannotStartObjectArrayWithoutProperty(){} // RVA: 0x72A1BE0
        public void get_CannotTranscodeInvalidUtf8(){} // RVA: 0x72A1C40
        public void get_CannotDecodeInvalidBase64(){} // RVA: 0x72A1CA0
        public void get_CannotTranscodeInvalidUtf16(){} // RVA: 0x72A1D00
        public void get_CannotEncodeInvalidUTF16(){} // RVA: 0x72A1D60
        public void get_CannotEncodeInvalidUTF8(){} // RVA: 0x72A1DC0
        public void get_CannotWritePropertyWithinArray(){} // RVA: 0x72A1E20
        public void get_CannotWritePropertyAfterProperty(){} // RVA: 0x72A1E80
        public void get_CannotWriteValueAfterPrimitiveOrClose(){} // RVA: 0x72A1EE0
        public void get_CannotWriteValueWithinObject(){} // RVA: 0x72A1F40
        public void get_DepthTooLarge(){} // RVA: 0x72A1FA0
        public void get_DestinationTooShort(){} // RVA: 0x72A2000
        public void get_EmptyJsonIsInvalid(){} // RVA: 0x72A2060
        public void get_EndOfCommentNotFound(){} // RVA: 0x72A20C0
        public void get_EndOfStringNotFound(){} // RVA: 0x72A2120
        public void get_ExpectedEndAfterSingleJson(){} // RVA: 0x72A2180
        public void get_ExpectedEndOfDigitNotFound(){} // RVA: 0x72A21E0
        public void get_ExpectedFalse(){} // RVA: 0x72A2240
        public void get_ExpectedJsonTokens(){} // RVA: 0x72A22A0
        public void get_ExpectedOneCompleteToken(){} // RVA: 0x72A2300
        public void get_ExpectedNextDigitEValueNotFound(){} // RVA: 0x72A2360
        public void get_ExpectedNull(){} // RVA: 0x72A23C0
        public void get_ExpectedSeparatorAfterPropertyNameNotFound(){} // RVA: 0x72A2420
        public void get_ExpectedStartOfPropertyNotFound(){} // RVA: 0x72A2480
        public void get_ExpectedStartOfPropertyOrValueNotFound(){} // RVA: 0x72A24E0
        public void get_ExpectedStartOfValueNotFound(){} // RVA: 0x72A2540
        public void get_ExpectedTrue(){} // RVA: 0x72A25A0
        public void get_ExpectedValueAfterPropertyNameNotFound(){} // RVA: 0x72A2600
        public void get_FailedToGetLargerSpan(){} // RVA: 0x72A2660
        public void get_FoundInvalidCharacter(){} // RVA: 0x72A26C0
        public void get_InvalidCast(){} // RVA: 0x72A2720
        public void get_InvalidCharacterAfterEscapeWithinString(){} // RVA: 0x72A2780
        public void get_InvalidCharacterWithinString(){} // RVA: 0x72A27E0
        public void get_InvalidEnumTypeWithSpecialChar(){} // RVA: 0x72A2840
        public void get_InvalidEndOfJsonNonPrimitive(){} // RVA: 0x72A28A0
        public void get_InvalidHexCharacterWithinString(){} // RVA: 0x72A2900
        public void get_JsonDocumentDoesNotSupportComments(){} // RVA: 0x72A2960
        public void get_JsonElementHasWrongType(){} // RVA: 0x72A29C0
        public void get_DefaultTypeInfoResolverImmutable(){} // RVA: 0x72A2A20
        public void get_TypeInfoResolverChainImmutable(){} // RVA: 0x72A2A80
        public void get_TypeInfoImmutable(){} // RVA: 0x72A2AE0
        public void get_MaxDepthMustBePositive(){} // RVA: 0x72A2B40
        public void get_CommentHandlingMustBeValid(){} // RVA: 0x72A2BA0
        public void get_MismatchedObjectArray(){} // RVA: 0x72A2C00
        public void get_CannotWriteEndAfterProperty(){} // RVA: 0x72A2C60
        public void get_ObjectDepthTooLarge(){} // RVA: 0x72A2CC0
        public void get_PropertyNameTooLarge(){} // RVA: 0x72A2D20
        public void get_FormatDecimal(){} // RVA: 0x72A2D80
        public void get_FormatDouble(){} // RVA: 0x72A2DE0
        public void get_FormatInt32(){} // RVA: 0x72A2E40
        public void get_FormatInt64(){} // RVA: 0x72A2EA0
        public void get_FormatSingle(){} // RVA: 0x72A2F00
        public void get_FormatUInt32(){} // RVA: 0x72A2F60
        public void get_FormatUInt64(){} // RVA: 0x72A2FC0
        public void get_RequiredDigitNotFoundAfterDecimal(){} // RVA: 0x72A3020
        public void get_RequiredDigitNotFoundAfterSign(){} // RVA: 0x72A3080
        public void get_RequiredDigitNotFoundEndOfData(){} // RVA: 0x72A30E0
        public void get_SpecialNumberValuesNotSupported(){} // RVA: 0x72A3140
        public void get_ValueTooLarge(){} // RVA: 0x72A31A0
        public void get_ZeroDepthAtEnd(){} // RVA: 0x72A3200
        public void get_DeserializeUnableToConvertValue(){} // RVA: 0x72A3260
        public void get_DeserializeWrongType(){} // RVA: 0x72A32C0
        public void get_SerializationInvalidBufferSize(){} // RVA: 0x72A3320
        public void get_BufferWriterAdvancedTooFar(){} // RVA: 0x72A3380
        public void get_InvalidComparison(){} // RVA: 0x72A33E0
        public void get_UnsupportedFormat(){} // RVA: 0x72A3440
        public void get_ExpectedStartOfPropertyOrValueAfterComment(){} // RVA: 0x72A34A0
        public void get_TrailingCommaNotAllowedBeforeArrayEnd(){} // RVA: 0x72A3500
        public void get_TrailingCommaNotAllowedBeforeObjectEnd(){} // RVA: 0x72A3560
        public void get_SerializerOptionsReadOnly(){} // RVA: 0x72A35C0
        public void get_SerializerOptions_InvalidChainedResolver(){} // RVA: 0x72A3620
        public void get_StreamNotWritable(){} // RVA: 0x72A3680
        public void get_CannotWriteCommentWithEmbeddedDelimiter(){} // RVA: 0x72A36E0
        public void get_SerializerPropertyNameConflict(){} // RVA: 0x72A3740
        public void get_SerializerPropertyNameNull(){} // RVA: 0x72A37A0
        public void get_SerializationDataExtensionPropertyInvalid(){} // RVA: 0x72A3800
        public void get_SerializationDuplicateTypeAttribute(){} // RVA: 0x72A3860
        public void get_ExtensionDataConflictsWithUnmappedMemberHandling(){} // RVA: 0x72A38C0
        public void get_SerializationNotSupportedType(){} // RVA: 0x72A3920
        public void get_TypeRequiresAsyncSerialization(){} // RVA: 0x72A3980
        public void get_InvalidCharacterAtStartOfComment(){} // RVA: 0x72A39E0
        public void get_UnexpectedEndOfDataWhileReadingComment(){} // RVA: 0x72A3A40
        public void get_CannotSkip(){} // RVA: 0x72A3AA0
        public void get_NotEnoughData(){} // RVA: 0x72A3B00
        public void get_UnexpectedEndOfLineSeparator(){} // RVA: 0x72A3B60
        public void get_JsonSerializerDoesNotSupportComments(){} // RVA: 0x72A3BC0
        public void get_DeserializeNoConstructor(){} // RVA: 0x72A3C20
        public void get_DeserializePolymorphicInterface(){} // RVA: 0x72A3C80
        public void get_SerializationConverterOnAttributeNotCompatible(){} // RVA: 0x72A3CE0
        public void get_SerializationConverterOnAttributeInvalid(){} // RVA: 0x72A3D40
        public void get_SerializationConverterRead(){} // RVA: 0x72A3DA0
        public void get_SerializationConverterNotCompatible(){} // RVA: 0x72A3E00
        public void get_ResolverTypeNotCompatible(){} // RVA: 0x72A3E60
        public void get_ResolverTypeInfoOptionsNotCompatible(){} // RVA: 0x72A3EC0
        public void get_SerializationConverterWrite(){} // RVA: 0x72A3F20
        public void get_NamingPolicyReturnNull(){} // RVA: 0x72A3F80
        public void get_SerializationDuplicateAttribute(){} // RVA: 0x72A3FE0
        public void get_SerializeUnableToSerialize(){} // RVA: 0x72A4040
        public void get_FormatByte(){} // RVA: 0x72A40A0
        public void get_FormatInt16(){} // RVA: 0x72A4100
        public void get_FormatSByte(){} // RVA: 0x72A4160
        public void get_FormatUInt16(){} // RVA: 0x72A41C0
        public void get_SerializerCycleDetected(){} // RVA: 0x72A4220
        public void get_InvalidLeadingZeroInNumber(){} // RVA: 0x72A4280
        public void get_MetadataCannotParsePreservedObjectToImmutable(){} // RVA: 0x72A42E0
        public void get_MetadataDuplicateIdFound(){} // RVA: 0x72A4340
        public void get_MetadataIdIsNotFirstProperty(){} // RVA: 0x72A43A0
        public void get_MetadataInvalidReferenceToValueType(){} // RVA: 0x72A4400
        public void get_MetadataInvalidTokenAfterValues(){} // RVA: 0x72A4460
        public void get_MetadataPreservedArrayFailed(){} // RVA: 0x72A44C0
        public void get_MetadataInvalidPropertyInArrayMetadata(){} // RVA: 0x72A4520
        public void get_MetadataStandaloneValuesProperty(){} // RVA: 0x72A4580
        public void get_MetadataReferenceCannotContainOtherProperties(){} // RVA: 0x72A45E0
        public void get_MetadataReferenceNotFound(){} // RVA: 0x72A4640
        public void get_MetadataValueWasNotString(){} // RVA: 0x72A46A0
        public void get_MetadataInvalidPropertyWithLeadingDollarSign(){} // RVA: 0x72A4700
        public void get_MetadataUnexpectedProperty(){} // RVA: 0x72A4760
        public void get_UnmappedJsonProperty(){} // RVA: 0x72A47C0
        public void get_MetadataDuplicateTypeProperty(){} // RVA: 0x72A4820
        public void get_MultipleMembersBindWithConstructorParameter(){} // RVA: 0x72A4880
        public void get_ConstructorParamIncompleteBinding(){} // RVA: 0x72A48E0
        public void get_ObjectWithParameterizedCtorRefMetadataNotSupported(){} // RVA: 0x72A4940
        public void get_SerializerConverterFactoryReturnsNull(){} // RVA: 0x72A49A0
        public void get_SerializationNotSupportedParentType(){} // RVA: 0x72A4A00
        public void get_ExtensionDataCannotBindToCtorParam(){} // RVA: 0x72A4A60
        public void get_BufferMaximumSizeExceeded(){} // RVA: 0x72A4AC0
        public void get_CannotSerializeInvalidType(){} // RVA: 0x72A4B20
        public void get_SerializeTypeInstanceNotSupported(){} // RVA: 0x72A4B80
        public void get_JsonIncludeOnInaccessibleProperty(){} // RVA: 0x72A4BE0
        public void get_CannotSerializeInvalidMember(){} // RVA: 0x72A4C40
        public void get_CannotPopulateCollection(){} // RVA: 0x72A4CA0
        public void get_ConstructorContainsNullParameterNames(){} // RVA: 0x72A4D00
        public void get_DefaultIgnoreConditionAlreadySpecified(){} // RVA: 0x72A4D60
        public void get_DefaultIgnoreConditionInvalid(){} // RVA: 0x72A4DC0
        public void get_DictionaryKeyTypeNotSupported(){} // RVA: 0x72A4E20
        public void get_IgnoreConditionOnValueTypeInvalid(){} // RVA: 0x72A4E80
        public void get_NumberHandlingOnPropertyInvalid(){} // RVA: 0x72A4EE0
        public void get_ConverterCanConvertMultipleTypes(){} // RVA: 0x72A4F40
        public void get_MetadataReferenceOfTypeCannotBeAssignedToType(){} // RVA: 0x72A4FA0
        public void get_DeserializeUnableToAssignValue(){} // RVA: 0x72A5000
        public void get_DeserializeUnableToAssignNull(){} // RVA: 0x72A5060
        public void get_SerializerConverterFactoryReturnsJsonConverterFactory(){} // RVA: 0x72A50C0
        public void get_SerializerConverterFactoryInvalidArgument(){} // RVA: 0x72A5120
        public void get_NodeElementWrongType(){} // RVA: 0x72A5180
        public void get_NodeElementCannotBeObjectOrArray(){} // RVA: 0x72A51E0
        public void get_NodeAlreadyHasParent(){} // RVA: 0x72A5240
        public void get_NodeCycleDetected(){} // RVA: 0x72A52A0
        public void get_NodeUnableToConvert(){} // RVA: 0x72A5300
        public void get_NodeUnableToConvertElement(){} // RVA: 0x72A5360
        public void get_NodeValueNotAllowed(){} // RVA: 0x72A53C0
        public void get_NodeWrongType(){} // RVA: 0x72A5420
        public void get_NodeParentWrongType(){} // RVA: 0x72A5480
        public void get_NodeDuplicateKey(){} // RVA: 0x72A54E0
        public void get_SerializerContextOptionsReadOnly(){} // RVA: 0x72A5540
        public void get_ConverterForPropertyMustBeValid(){} // RVA: 0x72A55A0
        public void get_NoMetadataForType(){} // RVA: 0x72A5600
        public void get_AmbiguousMetadataForType(){} // RVA: 0x72A5660
        public void get_CollectionIsReadOnly(){} // RVA: 0x72A56C0
        public void get_ArrayIndexNegative(){} // RVA: 0x72A5720
        public void get_ArrayTooSmall(){} // RVA: 0x72A5780
        public void get_NodeJsonObjectCustomConverterNotAllowedOnExtensionProperty(){} // RVA: 0x72A57E0
        public void get_NoMetadataForTypeProperties(){} // RVA: 0x72A5840
        public void get_FieldCannotBeVirtual(){} // RVA: 0x72A58A0
        public void get_MissingFSharpCoreMember(){} // RVA: 0x72A5900
        public void get_FSharpDiscriminatedUnionsNotSupported(){} // RVA: 0x72A5960
        public void get_Polymorphism_BaseConverterDoesNotSupportMetadata(){} // RVA: 0x72A59C0
        public void get_Polymorphism_DerivedConverterDoesNotSupportMetadata(){} // RVA: 0x72A5A20
        public void get_Polymorphism_TypeDoesNotSupportPolymorphism(){} // RVA: 0x72A5A80
        public void get_Polymorphism_DerivedTypeIsNotSupported(){} // RVA: 0x72A5AE0
        public void get_Polymorphism_DerivedTypeIsAlreadySpecified(){} // RVA: 0x72A5B40
        public void get_Polymorphism_TypeDicriminatorIdIsAlreadySpecified(){} // RVA: 0x72A5BA0
        public void get_Polymorphism_InvalidCustomTypeDiscriminatorPropertyName(){} // RVA: 0x72A5C00
        public void get_Polymorphism_ConfigurationDoesNotSpecifyDerivedTypes(){} // RVA: 0x72A5C60
        public void get_Polymorphism_UnrecognizedTypeDiscriminator(){} // RVA: 0x72A5CC0
        public void get_Polymorphism_RuntimeTypeNotSupported(){} // RVA: 0x72A5D20
        public void get_Polymorphism_RuntimeTypeDiamondAmbiguity(){} // RVA: 0x72A5D80
        public void get_InvalidJsonTypeInfoOperationForKind(){} // RVA: 0x72A5DE0
        public void get_CreateObjectConverterNotCompatible(){} // RVA: 0x72A5E40
        public void get_JsonPropertyInfoBoundToDifferentParent(){} // RVA: 0x72A5EA0
        public void get_JsonSerializerOptionsNoTypeInfoResolverSpecified(){} // RVA: 0x72A5F00
        public void get_JsonSerializerIsReflectionDisabled(){} // RVA: 0x72A5F60
        public void get_JsonPolymorphismOptionsAssociatedWithDifferentJsonTypeInfo(){} // RVA: 0x72A5FC0
        public void get_JsonPropertyRequiredAndNotDeserializable(){} // RVA: 0x72A6020
        public void get_JsonPropertyRequiredAndExtensionData(){} // RVA: 0x72A6080
        public void get_JsonRequiredPropertiesMissing(){} // RVA: 0x72A60E0
        public void get_ObjectCreationHandlingPopulateNotSupportedByConverter(){} // RVA: 0x72A6140
        public void get_ObjectCreationHandlingPropertyMustHaveAGetter(){} // RVA: 0x72A61A0
        public void get_ObjectCreationHandlingPropertyValueTypeMustHaveASetter(){} // RVA: 0x72A6200
        public void get_ObjectCreationHandlingPropertyCannotAllowPolymorphicDeserialization(){} // RVA: 0x72A6260
        public void get_ObjectCreationHandlingPropertyCannotAllowReadOnlyMember(){} // RVA: 0x72A62C0
        public void get_ObjectCreationHandlingPropertyCannotAllowReferenceHandling(){} // RVA: 0x72A6320
        public void get_ObjectCreationHandlingPropertyDoesNotSupportParameterizedConstructors(){} // RVA: 0x72A6380
        public void get_FormatInt128(){} // RVA: 0x72A63E0
        public void get_FormatUInt128(){} // RVA: 0x72A6440
        public void get_FormatHalf(){} // RVA: 0x72A64A0
        public void .cctor(){} // RVA: 0x72A6500
    }

    public class SR : Object
    {
        public object s_usingResourceKeys;
        public object s_resourceManager;

        // ── Methods ──
        public void UsingResourceKeys(){} // RVA: 0x6D5F080
        public void GetResourceString(){} // RVA: 0x6D5F0E0
        public void Format(){} // RVA: 0x6D5FA00
        public void get_ResourceManager(){} // RVA: 0x6D5FB20
        public void get_ArrayDepthTooLarge(){} // RVA: 0x6D5FCA0
        public void get_CannotReadIncompleteUTF16(){} // RVA: 0x6D5FD00
        public void get_CannotReadInvalidUTF16(){} // RVA: 0x6D5FD60
        public void get_CannotStartObjectArrayAfterPrimitiveOrClose(){} // RVA: 0x6D5FDC0
        public void get_CannotStartObjectArrayWithoutProperty(){} // RVA: 0x6D5FE20
        public void get_CannotTranscodeInvalidUtf8(){} // RVA: 0x6D5FE80
        public void get_CannotDecodeInvalidBase64(){} // RVA: 0x6D5FEE0
        public void get_CannotTranscodeInvalidUtf16(){} // RVA: 0x6D5FF40
        public void get_CannotEncodeInvalidUTF16(){} // RVA: 0x6D5FFA0
        public void get_CannotEncodeInvalidUTF8(){} // RVA: 0x6D60000
        public void get_CannotWritePropertyWithinArray(){} // RVA: 0x6D60060
        public void get_CannotWritePropertyAfterProperty(){} // RVA: 0x6D600C0
        public void get_CannotWriteValueAfterPrimitiveOrClose(){} // RVA: 0x6D60120
        public void get_CannotWriteValueWithinObject(){} // RVA: 0x6D60180
        public void get_DepthTooLarge(){} // RVA: 0x6D601E0
        public void get_EndOfCommentNotFound(){} // RVA: 0x6D60240
        public void get_EndOfStringNotFound(){} // RVA: 0x6D602A0
        public void get_ExpectedEndAfterSingleJson(){} // RVA: 0x6D60300
        public void get_ExpectedEndOfDigitNotFound(){} // RVA: 0x6D60360
        public void get_ExpectedFalse(){} // RVA: 0x6D603C0
        public void get_ExpectedJsonTokens(){} // RVA: 0x6D60420
        public void get_ExpectedOneCompleteToken(){} // RVA: 0x6D60480
        public void get_ExpectedNextDigitEValueNotFound(){} // RVA: 0x6D604E0
        public void get_ExpectedNull(){} // RVA: 0x6D60540
        public void get_ExpectedSeparatorAfterPropertyNameNotFound(){} // RVA: 0x6D605A0
        public void get_ExpectedStartOfPropertyNotFound(){} // RVA: 0x6D60600
        public void get_ExpectedStartOfPropertyOrValueNotFound(){} // RVA: 0x6D60660
        public void get_ExpectedStartOfValueNotFound(){} // RVA: 0x6D606C0
        public void get_ExpectedTrue(){} // RVA: 0x6D60720
        public void get_ExpectedValueAfterPropertyNameNotFound(){} // RVA: 0x6D60780
        public void get_FailedToGetLargerSpan(){} // RVA: 0x6D607E0
        public void get_FoundInvalidCharacter(){} // RVA: 0x6D60840
        public void get_InvalidCast(){} // RVA: 0x6D608A0
        public void get_InvalidCharacterAfterEscapeWithinString(){} // RVA: 0x6D60900
        public void get_InvalidCharacterWithinString(){} // RVA: 0x6D60960
        public void get_InvalidEndOfJsonNonPrimitive(){} // RVA: 0x6D609C0
        public void get_InvalidHexCharacterWithinString(){} // RVA: 0x6D60A20
        public void get_JsonDocumentDoesNotSupportComments(){} // RVA: 0x6D60A80
        public void get_JsonElementHasWrongType(){} // RVA: 0x6D60AE0
        public void get_MaxDepthMustBePositive(){} // RVA: 0x6D60B40
        public void get_CommentHandlingMustBeValid(){} // RVA: 0x6D60BA0
        public void get_MismatchedObjectArray(){} // RVA: 0x6D60C00
        public void get_CannotWriteEndAfterProperty(){} // RVA: 0x6D60C60
        public void get_ObjectDepthTooLarge(){} // RVA: 0x6D60CC0
        public void get_PropertyNameTooLarge(){} // RVA: 0x6D60D20
        public void get_FormatDecimal(){} // RVA: 0x6D60D80
        public void get_FormatDouble(){} // RVA: 0x6D60DE0
        public void get_FormatInt32(){} // RVA: 0x6D60E40
        public void get_FormatInt64(){} // RVA: 0x6D60EA0
        public void get_FormatSingle(){} // RVA: 0x6D60F00
        public void get_FormatUInt32(){} // RVA: 0x6D60F60
        public void get_FormatUInt64(){} // RVA: 0x6D60FC0
        public void get_RequiredDigitNotFoundAfterDecimal(){} // RVA: 0x6D61020
        public void get_RequiredDigitNotFoundAfterSign(){} // RVA: 0x6D61080
        public void get_RequiredDigitNotFoundEndOfData(){} // RVA: 0x6D610E0
        public void get_SpecialNumberValuesNotSupported(){} // RVA: 0x6D61140
        public void get_ValueTooLarge(){} // RVA: 0x6D611A0
        public void get_ZeroDepthAtEnd(){} // RVA: 0x6D61200
        public void get_DeserializeUnableToConvertValue(){} // RVA: 0x6D61260
        public void get_BufferWriterAdvancedTooFar(){} // RVA: 0x6D612C0
        public void get_FormatDateTime(){} // RVA: 0x6D61320
        public void get_FormatDateTimeOffset(){} // RVA: 0x6D61380
        public void get_FormatTimeSpan(){} // RVA: 0x6D613E0
        public void get_FormatGuid(){} // RVA: 0x6D61440
        public void get_ExpectedStartOfPropertyOrValueAfterComment(){} // RVA: 0x6D614A0
        public void get_TrailingCommaNotAllowedBeforeArrayEnd(){} // RVA: 0x6D61500
        public void get_TrailingCommaNotAllowedBeforeObjectEnd(){} // RVA: 0x6D61560
        public void get_SerializerOptionsImmutable(){} // RVA: 0x6D615C0
        public void get_StreamNotWritable(){} // RVA: 0x6D61620
        public void get_SerializerPropertyNameConflict(){} // RVA: 0x6D61680
        public void get_SerializerPropertyNameNull(){} // RVA: 0x6D616E0
        public void get_SerializationDataExtensionPropertyInvalid(){} // RVA: 0x6D61740
        public void get_SerializationDuplicateTypeAttribute(){} // RVA: 0x6D617A0
        public void get_SerializationNotSupportedType(){} // RVA: 0x6D61800
        public void get_TypeRequiresAsyncSerialization(){} // RVA: 0x6D61860
        public void get_InvalidCharacterAtStartOfComment(){} // RVA: 0x6D618C0
        public void get_UnexpectedEndOfDataWhileReadingComment(){} // RVA: 0x6D61920
        public void get_CannotSkip(){} // RVA: 0x6D61980
        public void get_NotEnoughData(){} // RVA: 0x6D619E0
        public void get_UnexpectedEndOfLineSeparator(){} // RVA: 0x6D61A40
        public void get_DeserializeNoConstructor(){} // RVA: 0x6D61AA0
        public void get_DeserializePolymorphicInterface(){} // RVA: 0x6D61B00
        public void get_SerializationConverterOnAttributeNotCompatible(){} // RVA: 0x6D61B60
        public void get_SerializationConverterOnAttributeInvalid(){} // RVA: 0x6D61BC0
        public void get_SerializationConverterRead(){} // RVA: 0x6D61C20
        public void get_SerializationConverterNotCompatible(){} // RVA: 0x6D61C80
        public void get_SerializationConverterWrite(){} // RVA: 0x6D61CE0
        public void get_NamingPolicyReturnNull(){} // RVA: 0x6D61D40
        public void get_SerializationDuplicateAttribute(){} // RVA: 0x6D61DA0
        public void get_SerializeUnableToSerialize(){} // RVA: 0x6D61E00
        public void get_FormatByte(){} // RVA: 0x6D61E60
        public void get_FormatInt16(){} // RVA: 0x6D61EC0
        public void get_FormatSByte(){} // RVA: 0x6D61F20
        public void get_FormatUInt16(){} // RVA: 0x6D61F80
        public void get_SerializerCycleDetected(){} // RVA: 0x6D61FE0
        public void get_InvalidLeadingZeroInNumber(){} // RVA: 0x6D62040
        public void get_MetadataCannotParsePreservedObjectToImmutable(){} // RVA: 0x6D620A0
        public void get_MetadataDuplicateIdFound(){} // RVA: 0x6D62100
        public void get_MetadataIdIsNotFirstProperty(){} // RVA: 0x6D62160
        public void get_MetadataInvalidReferenceToValueType(){} // RVA: 0x6D621C0
        public void get_MetadataInvalidTokenAfterValues(){} // RVA: 0x6D62220
        public void get_MetadataPreservedArrayFailed(){} // RVA: 0x6D62280
        public void get_MetadataPreservedArrayInvalidProperty(){} // RVA: 0x6D622E0
        public void get_MetadataPreservedArrayPropertyNotFound(){} // RVA: 0x6D62340
        public void get_MetadataReferenceCannotContainOtherProperties(){} // RVA: 0x6D623A0
        public void get_MetadataReferenceNotFound(){} // RVA: 0x6D62400
        public void get_MetadataValueWasNotString(){} // RVA: 0x6D62460
        public void get_MetadataInvalidPropertyWithLeadingDollarSign(){} // RVA: 0x6D624C0
        public void get_MultipleMembersBindWithConstructorParameter(){} // RVA: 0x6D62520
        public void get_ConstructorParamIncompleteBinding(){} // RVA: 0x6D62580
        public void get_ConstructorMaxOf64Parameters(){} // RVA: 0x6D625E0
        public void get_ObjectWithParameterizedCtorRefMetadataNotHonored(){} // RVA: 0x6D62640
        public void get_SerializerConverterFactoryReturnsNull(){} // RVA: 0x6D626A0
        public void get_SerializationNotSupportedParentType(){} // RVA: 0x6D62700
        public void get_ExtensionDataCannotBindToCtorParam(){} // RVA: 0x6D62760
        public void get_BufferMaximumSizeExceeded(){} // RVA: 0x6D627C0
        public void get_CannotSerializeInvalidType(){} // RVA: 0x6D62820
        public void get_SerializeTypeInstanceNotSupported(){} // RVA: 0x6D62880
        public void get_JsonIncludeOnNonPublicInvalid(){} // RVA: 0x6D628E0
        public void get_CannotSerializeInvalidMember(){} // RVA: 0x6D62940
        public void get_CannotPopulateCollection(){} // RVA: 0x6D629A0
        public void get_DefaultIgnoreConditionAlreadySpecified(){} // RVA: 0x6D62A00
        public void get_DefaultIgnoreConditionInvalid(){} // RVA: 0x6D62A60
        public void get_FormatBoolean(){} // RVA: 0x6D62AC0
        public void get_DictionaryKeyTypeNotSupported(){} // RVA: 0x6D62B20
        public void get_IgnoreConditionOnValueTypeInvalid(){} // RVA: 0x6D62B80
        public void get_NumberHandlingOnPropertyInvalid(){} // RVA: 0x6D62BE0
        public void get_ConverterCanConvertMultipleTypes(){} // RVA: 0x6D62C40
        public void get_MetadataReferenceOfTypeCannotBeAssignedToType(){} // RVA: 0x6D62CA0
        public void get_DeserializeUnableToAssignValue(){} // RVA: 0x6D62D00
        public void get_DeserializeUnableToAssignNull(){} // RVA: 0x6D62D60
        public void get_SerializerConverterFactoryReturnsJsonConverterFactory(){} // RVA: 0x6D62DC0
        public void get_NodeAlreadyHasParent(){} // RVA: 0x6D62E20
        public void get_NodeCycleDetected(){} // RVA: 0x6D62E80
        public void get_NodeValueNotAllowed(){} // RVA: 0x6D62EE0
        public void get_NodeWrongType(){} // RVA: 0x6D62F40
        public void get_NodeDuplicateKey(){} // RVA: 0x6D62FA0
        public void get_SerializerContextOptionsImmutable(){} // RVA: 0x6D63000
        public void get_OptionsAlreadyBoundToContext(){} // RVA: 0x6D63060
        public void get_BuiltInConvertersNotRooted(){} // RVA: 0x6D630C0
        public void get_NoMetadataForType(){} // RVA: 0x6D63120
        public void get_NodeCollectionIsReadOnly(){} // RVA: 0x6D63180
        public void get_NodeArrayIndexNegative(){} // RVA: 0x6D631E0
        public void get_NodeArrayTooSmall(){} // RVA: 0x6D63240
        public void get_NodeJsonObjectCustomConverterNotAllowedOnExtensionProperty(){} // RVA: 0x6D632A0
        public void get_NoMetadataForTypeProperties(){} // RVA: 0x6D63300
        public void get_MissingFSharpCoreMember(){} // RVA: 0x6D63360
        public void get_FSharpDiscriminatedUnionsNotSupported(){} // RVA: 0x6D633C0
        public void get_NoMetadataForTypeCtorParams(){} // RVA: 0x6D63420
        public void .cctor(){} // RVA: 0x6D63480
    }

    public class SR : Object
    {
        public object s_usingResourceKeys;
        public object s_resourceManager;

        // ── Methods ──
        public void UsingResourceKeys(){} // RVA: 0x6D3F960
        public void GetResourceString(){} // RVA: 0x6D3F9C0
        public void Format(){} // RVA: 0x6D3FCA0
        public void get_ResourceManager(){} // RVA: 0x6D3FE80
        public void get_ImageTooSmall(){} // RVA: 0x6D40000
        public void get_InvalidCorHeaderSize(){} // RVA: 0x6D40060
        public void get_InvalidHandle(){} // RVA: 0x6D400C0
        public void get_InvalidMetadataSectionSpan(){} // RVA: 0x6D40120
        public void get_InvalidPESignature(){} // RVA: 0x6D40180
        public void get_InvalidToken(){} // RVA: 0x6D401E0
        public void get_PEImageNotAvailable(){} // RVA: 0x6D40240
        public void get_MissingDataDirectory(){} // RVA: 0x6D402A0
        public void get_SectionTooSmall(){} // RVA: 0x6D40300
        public void get_StreamMustSupportReadAndSeek(){} // RVA: 0x6D40360
        public void get_UnknownFileFormat(){} // RVA: 0x6D403C0
        public void get_UnknownPEMagicValue(){} // RVA: 0x6D40420
        public void get_MetadataTableNotSorted(){} // RVA: 0x6D40480
        public void get_ModuleTableInvalidNumberOfRows(){} // RVA: 0x6D404E0
        public void get_UnknownTables(){} // RVA: 0x6D40540
        public void get_IllegalTablesInCompressedMetadataStream(){} // RVA: 0x6D405A0
        public void get_TableRowCountSpaceTooSmall(){} // RVA: 0x6D40600
        public void get_OutOfBoundsRead(){} // RVA: 0x6D40660
        public void get_MetadataHeaderTooSmall(){} // RVA: 0x6D406C0
        public void get_MetadataSignature(){} // RVA: 0x6D40720
        public void get_NotEnoughSpaceForVersionString(){} // RVA: 0x6D40780
        public void get_StreamHeaderTooSmall(){} // RVA: 0x6D407E0
        public void get_NotEnoughSpaceForStreamHeaderName(){} // RVA: 0x6D40840
        public void get_NotEnoughSpaceForStringStream(){} // RVA: 0x6D408A0
        public void get_NotEnoughSpaceForBlobStream(){} // RVA: 0x6D40900
        public void get_NotEnoughSpaceForGUIDStream(){} // RVA: 0x6D40960
        public void get_NotEnoughSpaceForMetadataStream(){} // RVA: 0x6D409C0
        public void get_InvalidMetadataStreamFormat(){} // RVA: 0x6D40A20
        public void get_MetadataTablesTooSmall(){} // RVA: 0x6D40A80
        public void get_MetadataTableHeaderTooSmall(){} // RVA: 0x6D40AE0
        public void get_WinMDMissingMscorlibRef(){} // RVA: 0x6D40B40
        public void get_UnexpectedStreamEnd(){} // RVA: 0x6D40BA0
        public void get_InvalidNumberOfSections(){} // RVA: 0x6D40C00
        public void get_InvalidCompressedInteger(){} // RVA: 0x6D40C60
        public void get_InvalidDocumentName(){} // RVA: 0x6D40CC0
        public void get_RowIdOrHeapOffsetTooLarge(){} // RVA: 0x6D40D20
        public void get_StreamTooLarge(){} // RVA: 0x6D40D80
        public void get_ImageTooSmallOrContainsInvalidOffsetOrCount(){} // RVA: 0x6D40DE0
        public void get_MetadataStringDecoderEncodingMustBeUtf8(){} // RVA: 0x6D40E40
        public void get_InvalidRowCount(){} // RVA: 0x6D40EA0
        public void get_InvalidEntryPointToken(){} // RVA: 0x6D40F00
        public void get_SequencePointValueOutOfRange(){} // RVA: 0x6D40F60
        public void get_InvalidDirectoryRVA(){} // RVA: 0x6D40FC0
        public void get_InvalidDirectorySize(){} // RVA: 0x6D41020
        public void get_InvalidDebugDirectoryEntryCharacteristics(){} // RVA: 0x6D41080
        public void get_UnexpectedCodeViewDataSignature(){} // RVA: 0x6D410E0
        public void get_InvalidPdbChecksumDataFormat(){} // RVA: 0x6D41140
        public void get_UnexpectedDebugDirectoryType(){} // RVA: 0x6D411A0
        public void .cctor(){} // RVA: 0x6D41200
    }

    public class SR : Object
    {
        public object s_resourceManager;
        public object _resourceType;

        // ── Methods ──
        public void get_ResourceManager(){} // RVA: 0x6D2EA60
        public void UsingResourceKeys(){} // RVA: 0xB43320
        public void GetResourceString(){} // RVA: 0x6D2EBC0
        public void Format(){} // RVA: 0x6D2EE60
        public void get_ResourceType(){} // RVA: 0x6D2F000
        public void get_NotSupported_CannotCallEqualsOnSpan(){} // RVA: 0x6D2F060
        public void get_NotSupported_CannotCallGetHashCodeOnSpan(){} // RVA: 0x6D2F0C0
        public void get_Argument_InvalidTypeWithPointersNotSupported(){} // RVA: 0x6D2F120
        public void get_Argument_DestinationTooShort(){} // RVA: 0x6D2F180
        public void get_Argument_BadFormatSpecifier(){} // RVA: 0x6D2F1E0
        public void get_Argument_GWithPrecisionNotSupported(){} // RVA: 0x6D2F240
        public void get_Argument_PrecisionTooLarge(){} // RVA: 0x6D2F2A0
        public void get_EndPositionNotReached(){} // RVA: 0x6D2F300
        public void .cctor(){} // RVA: 0x6D2F360
    }

    public class SR : Object
    {
        public object s_usingResourceKeys;
        public object s_resourceManager;

        // ── Methods ──
        public void UsingResourceKeys(){} // RVA: 0x6605CF0
        public void GetResourceString(){} // RVA: 0x6605D50
        public void Format(){} // RVA: 0x6606670
        public void get_ResourceManager(){} // RVA: 0x6606790
        public void get_AmbiguousConstructorException(){} // RVA: 0x6606910
        public void get_CannotResolveService(){} // RVA: 0x6606970
        public void get_CircularDependencyException(){} // RVA: 0x66069D0
        public void get_UnableToActivateTypeException(){} // RVA: 0x6606A30
        public void get_OpenGenericServiceRequiresOpenGenericImplementation(){} // RVA: 0x6606A90
        public void get_ArityOfOpenGenericServiceNotEqualArityOfOpenGenericImplementation(){} // RVA: 0x6606AF0
        public void get_TypeCannotBeActivated(){} // RVA: 0x6606B50
        public void get_NoConstructorMatch(){} // RVA: 0x6606BB0
        public void get_ScopedInSingletonException(){} // RVA: 0x6606C10
        public void get_ScopedResolvedFromRootException(){} // RVA: 0x6606C70
        public void get_DirectScopedResolvedFromRootException(){} // RVA: 0x6606CD0
        public void get_ConstantCantBeConvertedToServiceType(){} // RVA: 0x6606D30
        public void get_ImplementationTypeCantBeConvertedToServiceType(){} // RVA: 0x6606D90
        public void get_AsyncDisposableServiceDispose(){} // RVA: 0x6606DF0
        public void get_InvalidServiceDescriptor(){} // RVA: 0x6606E50
        public void get_ServiceDescriptorNotExist(){} // RVA: 0x6606EB0
        public void get_CallSiteTypeNotSupported(){} // RVA: 0x6606F10
        public void get_TrimmingAnnotationsDoNotMatch(){} // RVA: 0x6606F70
        public void get_TrimmingAnnotationsDoNotMatch_NewConstraint(){} // RVA: 0x6606FD0
        public void get_AotCannotCreateEnumerableValueType(){} // RVA: 0x6607030
        public void get_AotCannotCreateGenericValueType(){} // RVA: 0x6607090
        public void get_InvalidServiceKeyType(){} // RVA: 0x66070F0
        public void .cctor(){} // RVA: 0x6607150
    }

    public class SequencePosition : ValueType
    {
        public object _object;
        public object _integer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x28E70
        public void GetObject(){} // RVA: 0x77900
        public void GetInteger(){} // RVA: 0x14790
        public void Equals(){} // RVA: 0x8E8140
        public void GetHashCode(){} // RVA: 0x8E8200
    }

    public class SequencePosition : ValueType
    {
        public object _object;
        public object _integer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x28E70
        public void GetObject(){} // RVA: 0x77900
        public void GetInteger(){} // RVA: 0x14790
        public void Equals(){} // RVA: 0x8BE3F0
        public void GetHashCode(){} // RVA: 0x8BE4B0
    }

    public class SerializableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Single : ValueType
    {
        public object m_value;

        // ── Methods ──
        public void IsFinite(){} // RVA: 0x692B4E0
        public void IsInfinity(){} // RVA: 0x692B500
        public void IsNaN(){} // RVA: 0x692B520
        public void IsNegativeInfinity(){} // RVA: 0x692B540
        public void IsPositiveInfinity(){} // RVA: 0x692B560
        public void CompareTo(){} // RVA: 0x8BB8E0
        public void Equals(){} // RVA: 0x8BB9B0
        public void GetHashCode(){} // RVA: 0x8BB9E0
        public void ToString(){} // RVA: 0x8BBA30
        public void TryFormat(){} // RVA: 0x8BBA40
        public void Parse(){} // RVA: 0x692BCB0
        public void TryParse(){} // RVA: 0x692BEF0
        public void GetTypeCode(){} // RVA: 0x8BBB10
        public void System.IConvertible.ToBoolean(){} // RVA: 0x8BBB20
        public void System.IConvertible.ToChar(){} // RVA: 0x8BBB90
        public void System.IConvertible.ToSByte(){} // RVA: 0x8BBBA0
        public void System.IConvertible.ToByte(){} // RVA: 0x8BBC40
        public void System.IConvertible.ToInt16(){} // RVA: 0x8BBCE0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x8BBD80
        public void System.IConvertible.ToInt32(){} // RVA: 0x8BBE20
        public void System.IConvertible.ToUInt32(){} // RVA: 0x8BBEC0
        public void System.IConvertible.ToInt64(){} // RVA: 0x8BBF60
        public void System.IConvertible.ToUInt64(){} // RVA: 0x8BC000
        public void System.IConvertible.ToSingle(){} // RVA: 0x88D10
        public void System.IConvertible.ToDouble(){} // RVA: 0x8BC0A0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x8BC100
        public void System.IConvertible.ToDateTime(){} // RVA: 0x8BC180
        public void System.IConvertible.ToType(){} // RVA: 0x8BC190
    }

    public class Single[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB80C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7CA40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8AF0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E71430
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7CA40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Single[][] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SpanHelpers : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x29BDBD0
        public void IndexOfAny(){} // RVA: 0x29BEF30
        public void LastIndexOf(){} // RVA: 0xA94080
        public void SequenceEqual(){} // RVA: 0x29BC810
        public void SequenceCompareTo(){} // RVA: 0x692D2A0
        public void LocateFirstFoundChar(){} // RVA: 0x692D7E0
        public void LocateLastFoundChar(){} // RVA: 0x692D960
        public void StartsWithCultureHelper(){} // RVA: 0x692D980
        public void StartsWithCultureIgnoreCaseHelper(){} // RVA: 0x692DAF0
        public void StartsWithOrdinalIgnoreCaseHelper(){} // RVA: 0x692DC50
        public void EndsWithCultureHelper(){} // RVA: 0x692DD50
        public void EndsWithCultureIgnoreCaseHelper(){} // RVA: 0x692DEC0
        public void EndsWithOrdinalIgnoreCaseHelper(){} // RVA: 0x692E020
        public void ClearWithoutReferences(){} // RVA: 0x692E130
        public void ClearWithReferences(){} // RVA: 0x692E390
    }

    public class SpanHelpers : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0xA94080
        public void IndexOfAny(){} // RVA: 0xA94080
        public void SequenceEqual(){} // RVA: 0x880A10
        public void LocateFirstFoundByte(){} // RVA: 0x6D2E1E0
        public void GetVector(){} // RVA: 0x6D2E200
        public void LocateFirstFoundChar(){} // RVA: 0x692D7E0
        public void Add(){} // RVA: 0x29B6B80
        public void IsReferenceOrContainsReferences(){} // RVA: 0x29A52C0
        public void IsReferenceOrContainsReferencesCore(){} // RVA: 0x6D2E580
        public void ClearLessThanPointerSized(){} // RVA: 0x6D2E8A0
        public void ClearPointerSizedWithoutReferences(){} // RVA: 0x6D2E930
        public void ClearPointerSizedWithReferences(){} // RVA: 0x6D2E9B0
        public void LessThanEqual(){} // RVA: 0x6D2EA40
        public void CopyTo(){} // RVA: 0x29B6C20
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x899290
        public void get_Item(){} // RVA: 0x87C160
        public void GetPinnableReference(){} // RVA: 0x87C0A0
        public void Clear(){} // RVA: 0x894290
        public void Fill(){} // RVA: 0xA94080
        public void CopyTo(){} // RVA: 0xA94080
        public void TryCopyTo(){} // RVA: 0xA94080
        public void op_Equality(){} // RVA: 0xA94080
        public void op_Implicit(){} // RVA: 0xA94080
        public void ToString(){} // RVA: 0x87C0A0
        public void Slice(){} // RVA: 0xA94080
        public void ToArray(){} // RVA: 0x87C0A0
        public void get_Length(){} // RVA: 0x87C130
        public void get_IsEmpty(){} // RVA: 0x87D280
        public void Equals(){} // RVA: 0x87D350
        public void GetHashCode(){} // RVA: 0x87C130
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x272B890
        public void .ctor(){} // RVA: 0x25742E0
        public void op_Implicit(){} // RVA: 0x4B23520
        public void get_Item(){} // RVA: 0x49E1410
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B23120
        public void Fill(){} // RVA: 0x4B23140
        public void CopyTo(){} // RVA: 0x49E1430
        public void TryCopyTo(){} // RVA: 0x49E14E0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B231F0
        public void Slice(){} // RVA: 0x49E1810
        public void ToArray(){} // RVA: 0x4B23400
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25742E0
        public void get_Item(){} // RVA: 0x49DAFC0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B1C670
        public void Fill(){} // RVA: 0x4B2A510
        public void CopyTo(){} // RVA: 0x49DAFE0
        public void TryCopyTo(){} // RVA: 0x49DB090
        public void op_Equality(){} // RVA: 0x49D3340
        public void op_Implicit(){} // RVA: 0x4B1CA70
        public void ToString(){} // RVA: 0x4B2A5C0
        public void Slice(){} // RVA: 0x49DB3C0
        public void ToArray(){} // RVA: 0x4B1C940
        public void get_Length(){} // RVA: 0x272B890
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x272B890
        public void op_Implicit(){} // RVA: 0x4B1DB60
        public void .ctor(){} // RVA: 0x25742E0
        public void get_Item(){} // RVA: 0x49DC210
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B1D7F0
        public void Fill(){} // RVA: 0x4B1D810
        public void CopyTo(){} // RVA: 0x49DC230
        public void TryCopyTo(){} // RVA: 0x49DC2E0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B22180
        public void Slice(){} // RVA: 0xE3F700
        public void ToArray(){} // RVA: 0x4B1DA40
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x272B890
        public void get_Item(){} // RVA: 0x49D31F0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D3120
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void get_Length(){} // RVA: 0x272B890
        public void ToArray(){} // RVA: 0x4B1C940
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void get_Length(){} // RVA: 0x272B890
        public void .ctor(){} // RVA: 0x25742E0
        public void get_Item(){} // RVA: 0x49D38D0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void Clear(){} // RVA: 0x4B2B9B0
        public void Fill(){} // RVA: 0x4B2B9D0
        public void CopyTo(){} // RVA: 0x49E8830
        public void TryCopyTo(){} // RVA: 0x49E88E0
        public void op_Equality(){} // RVA: 0x49D3340
        public void op_Implicit(){} // RVA: 0x4B2BEB0
        public void ToString(){} // RVA: 0x4B2BB80
        public void Slice(){} // RVA: 0x49E8C10
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
        public void .ctor(){} // RVA: 0x49D3120
        public void ToArray(){} // RVA: 0x4B2BD90
        public void get_Item(){} // RVA: 0x49E8810
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void get_Length(){} // RVA: 0x272B890
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void get_Length(){} // RVA: 0x272B890
        public void get_Item(){} // RVA: 0x49D38D0
        public void .ctor(){} // RVA: 0x25742E0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D3120
        public void get_Length(){} // RVA: 0x272B890
        public void GetPinnableReference(){} // RVA: 0x49D3210
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x272B890
        public void .ctor(){} // RVA: 0x49D3120
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B1A180
        public void .ctor(){} // RVA: 0x25742E0
        public void get_Item(){} // RVA: 0x49D4B90
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B198A0
        public void Fill(){} // RVA: 0x4B2AF30
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2B590
        public void Slice(){} // RVA: 0x49D4E40
        public void ToArray(){} // RVA: 0x4B0B4A0
        public void get_Length(){} // RVA: 0x272B890
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x272B890
        public void get_Item(){} // RVA: 0x49D38D0
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void .ctor(){} // RVA: 0x25742E0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void Clear(){} // RVA: 0x4B23120
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void get_Length(){} // RVA: 0x272B890
        public void get_Item(){} // RVA: 0x49D38D0
        public void .ctor(){} // RVA: 0x25742E0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25742E0
    }

    public class Span`1 : ValueType
    {
        // ── Methods ──
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void .ctor(){} // RVA: 0x49D3120
        public void get_Length(){} // RVA: 0x272B890
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void Slice(){} // RVA: 0x49D3CD0
        public void op_Implicit(){} // RVA: 0x4B0B240
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x49D38D0
        public void get_Length(){} // RVA: 0x272B890
        public void .ctor(){} // RVA: 0x25742E0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25742E0
        public void ToArray(){} // RVA: 0x4B19780
        public void get_Item(){} // RVA: 0x49D31F0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B19470
        public void Fill(){} // RVA: 0x4B19490
        public void CopyTo(){} // RVA: 0x49D46A0
        public void TryCopyTo(){} // RVA: 0x49D4750
        public void op_Equality(){} // RVA: 0x49D3340
        public void op_Implicit(){} // RVA: 0x4B0B5A0
        public void ToString(){} // RVA: 0x4B28E90
        public void Slice(){} // RVA: 0x49D35E0
        public void get_Length(){} // RVA: 0x272B890
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x49D37F0
    }

    public class Span`1 : ValueType
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x49D37F0
    }

    public class Span`1 : ValueType
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x49D37F0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void Slice(){} // RVA: 0x49D3CD0
        public void op_Implicit(){} // RVA: 0x4B0B240
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void get_Length(){} // RVA: 0x272B890
        public void .ctor(){} // RVA: 0x25742E0
        public void get_Item(){} // RVA: 0x49D38D0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x49D38D0
        public void get_Length(){} // RVA: 0x272B890
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void .ctor(){} // RVA: 0x25742E0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void Slice(){} // RVA: 0x49D3CD0
        public void op_Implicit(){} // RVA: 0x4B0B240
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void get_Length(){} // RVA: 0x272B890
        public void get_Item(){} // RVA: 0x49D38D0
        public void .ctor(){} // RVA: 0x25742E0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void get_Length(){} // RVA: 0x272B890
        public void get_Item(){} // RVA: 0x49D38D0
        public void .ctor(){} // RVA: 0x25742E0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void get_Length(){} // RVA: 0x272B890
        public void .ctor(){} // RVA: 0x4B0AB30
        public void get_Item(){} // RVA: 0x49D38D0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B0B240
        public void get_Length(){} // RVA: 0x272B890
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x49D38D0
        public void get_Length(){} // RVA: 0x272B890
        public void .ctor(){} // RVA: 0x25742E0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25742E0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void .ctor(){} // RVA: 0x25742E0
        public void get_Item(){} // RVA: 0x49D38D0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_Length(){} // RVA: 0x272B890
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void get_Length(){} // RVA: 0x272B890
        public void .ctor(){} // RVA: 0x4B0AB30
        public void get_Item(){} // RVA: 0x49D38D0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x49D38D0
        public void get_Length(){} // RVA: 0x272B890
        public void .ctor(){} // RVA: 0x25742E0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x49D38D0
        public void get_Length(){} // RVA: 0x272B890
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void Slice(){} // RVA: 0x49D3C60
        public void .ctor(){} // RVA: 0x4B0AB30
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x49D38D0
        public void get_Length(){} // RVA: 0x272B890
        public void .ctor(){} // RVA: 0x4B0AB30
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void Slice(){} // RVA: 0x49D3CD0
        public void op_Implicit(){} // RVA: 0x4B0B240
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void Slice(){} // RVA: 0x49D3CD0
        public void op_Implicit(){} // RVA: 0x4B0B240
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25742E0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25742E0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x272B890
        public void get_Item(){} // RVA: 0x49D38D0
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void .ctor(){} // RVA: 0x4B0AB30
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void Slice(){} // RVA: 0x49D3CD0
        public void op_Implicit(){} // RVA: 0x4B0B240
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x272B890
        public void get_Item(){} // RVA: 0x49D38D0
        public void op_Implicit(){} // RVA: 0x4B1C520
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void get_Length(){} // RVA: 0x272B890
        public void .ctor(){} // RVA: 0x25742E0
        public void get_Item(){} // RVA: 0x49D38D0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void Slice(){} // RVA: 0x49D3CD0
        public void op_Implicit(){} // RVA: 0x4B0B240
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void get_Length(){} // RVA: 0x272B890
        public void get_Item(){} // RVA: 0x49D38D0
        public void .ctor(){} // RVA: 0x25742E0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void Slice(){} // RVA: 0x49D3CD0
        public void op_Implicit(){} // RVA: 0x4B0B240
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x272B890
        public void get_Item(){} // RVA: 0x49D38D0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x272B890
        public void get_Item(){} // RVA: 0x49D38D0
        public void op_Implicit(){} // RVA: 0x4B1C520
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void get_Length(){} // RVA: 0x272B890
        public void Slice(){} // RVA: 0x49D3C60
        public void get_Item(){} // RVA: 0x49D38D0
        public void .ctor(){} // RVA: 0x4B0AB30
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void Slice(){} // RVA: 0x49D3CD0
        public void op_Implicit(){} // RVA: 0x4B0B240
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
        public void ToArray(){} // RVA: 0x4B262B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x272B890
        public void op_Implicit(){} // RVA: 0x4B0B240
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B1C520
        public void get_Length(){} // RVA: 0x272B890
        public void get_Item(){} // RVA: 0x49D38D0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x49D38D0
        public void get_Length(){} // RVA: 0x272B890
        public void .ctor(){} // RVA: 0x4B0AB30
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void Slice(){} // RVA: 0x49D3CD0
        public void op_Implicit(){} // RVA: 0x4B0B240
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x49D31F0
        public void get_Length(){} // RVA: 0x272B890
        public void .ctor(){} // RVA: 0x49D3140
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x4B2FAC0
        public void get_Length(){} // RVA: 0x272B890
        public void .ctor(){} // RVA: 0x25742E0
        public void get_Item(){} // RVA: 0x49D38D0
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void Clear(){} // RVA: 0x4B2F370
        public void Fill(){} // RVA: 0x4B2F380
        public void CopyTo(){} // RVA: 0x4B0B120
        public void TryCopyTo(){} // RVA: 0x4B0B1B0
        public void op_Equality(){} // RVA: 0x49D3340
        public void ToString(){} // RVA: 0x4B2F8B0
        public void Slice(){} // RVA: 0x49D3CD0
        public void ToArray(){} // RVA: 0x46683F0
        public void get_IsEmpty(){} // RVA: 0x3F2EED0
        public void Equals(){} // RVA: 0x49D3750
        public void GetHashCode(){} // RVA: 0x49D37A0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        // ── Methods ──
        public void GetPinnableReference(){} // RVA: 0x49D3210
        public void .ctor(){} // RVA: 0x49D3120
        public void get_Length(){} // RVA: 0x272B890
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pointer;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D38B0
    }

    public class Span`1 : ValueType
    {
        public object _pinnable;
        public object _byteOffset;
        public object _length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x87C130
        public void get_IsEmpty(){} // RVA: 0x87D280
        public void Equals(){} // RVA: 0x87D350
        public void GetHashCode(){} // RVA: 0x87C130
        public void op_Implicit(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x89AB90
        public void Create(){} // RVA: 0xA94080
        public void get_Item(){} // RVA: 0x87C160
        public void GetPinnableReference(){} // RVA: 0x87C0A0
        public void Clear(){} // RVA: 0x894290
        public void Fill(){} // RVA: 0xA94080
        public void CopyTo(){} // RVA: 0xA94080
        public void TryCopyTo(){} // RVA: 0xA94080
        public void ToString(){} // RVA: 0x87C0A0
        public void Slice(){} // RVA: 0xA94080
        public void ToArray(){} // RVA: 0x87C0A0
        public void DangerousGetPinnableReference(){} // RVA: 0x87C0A0
        public void get_Pinnable(){} // RVA: 0x87C0A0
        public void get_ByteOffset(){} // RVA: 0x87C0A0
    }

    public class Span`1 : ValueType
    {
        public object _pinnable;
        public object _byteOffset;
        public object _length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x8C7E0
        public void DangerousGetPinnableReference(){} // RVA: 0x491FD0
        public void op_Implicit(){} // RVA: 0x4B21CC0
        public void Slice(){} // RVA: 0x491F50
        public void get_IsEmpty(){} // RVA: 0x491D80
        public void Equals(){} // RVA: 0x491D90
        public void GetHashCode(){} // RVA: 0x491DA0
        public void .ctor(){} // RVA: 0x491DE0
        public void Create(){} // RVA: 0x315C2C0
        public void get_Item(){} // RVA: 0x491E40
        public void GetPinnableReference(){} // RVA: 0x491E80
        public void Clear(){} // RVA: 0x4A11C0
        public void Fill(){} // RVA: 0x4A1200
        public void CopyTo(){} // RVA: 0x4A1240
        public void TryCopyTo(){} // RVA: 0x4A12A0
        public void ToString(){} // RVA: 0x4A12D0
        public void ToArray(){} // RVA: 0x4A12E0
        public void get_Pinnable(){} // RVA: 0x77900
        public void get_ByteOffset(){} // RVA: 0x77ED0
    }

    public class String : Object
    {
        public object StackallocIntBufferSizeLimit;
        public object PROBABILISTICMAP_BLOCK_INDEX_MASK;
        public object PROBABILISTICMAP_BLOCK_INDEX_SHIFT;
        public object PROBABILISTICMAP_SIZE;
        public object _stringLength;
        public object _firstChar;
        public object Empty;

        // ── Methods ──
        public void EqualsHelper(){} // RVA: 0x669C5F0
        public void CompareOrdinalHelper(){} // RVA: 0x669C670
        public void Compare(){} // RVA: 0x669D100
        public void CompareOrdinal(){} // RVA: 0x669D690
        public void CompareTo(){} // RVA: 0x669C7B0
        public void EndsWith(){} // RVA: 0x669DF20
        public void Equals(){} // RVA: 0x669E330
        public void op_Equality(){} // RVA: 0x669E2F0
        public void op_Inequality(){} // RVA: 0x669E640
        public void GetHashCode(){} // RVA: 0x669E6E0
        public void GetLegacyNonRandomizedHashCode(){} // RVA: 0x669E690
        public void StartsWith(){} // RVA: 0x669EE80
        public void CheckStringComparison(){} // RVA: 0x669EEA0
        public void .ctor(){} // RVA: 0x669FBD0
        public void Ctor(){} // RVA: 0x669FBF0
        public void CreateStringForSByteConstructor(){} // RVA: 0x669F760
        public void Create(){} // RVA: 0x29CA670
        public void op_Implicit(){} // RVA: 0x669FCC0
        public void Clone(){} // RVA: 0x2303260
        public void Copy(){} // RVA: 0x669FD40
        public void CopyTo(){} // RVA: 0x669FE10
        public void ToCharArray(){} // RVA: 0x66A0160
        public void IsNullOrEmpty(){} // RVA: 0x66A0340
        public void IsNullOrWhiteSpace(){} // RVA: 0x66A0350
        public void GetRawStringData(){} // RVA: 0x66A03E0
        public void CreateStringFromEncoding(){} // RVA: 0x66A03F0
        public void CreateFromChar(){} // RVA: 0x66A04C0
        public void wstrcpy(){} // RVA: 0x30174F0
        public void ToString(){} // RVA: 0x2303260
        public void GetEnumerator(){} // RVA: 0x66A0540
        public void System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator(){} // RVA: 0x66A05E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x66A0680
        public void wcslen(){} // RVA: 0x66A0720
        public void GetTypeCode(){} // RVA: 0x1F7C790
        public void System.IConvertible.ToBoolean(){} // RVA: 0x66A0810
        public void System.IConvertible.ToChar(){} // RVA: 0x66A0880
        public void System.IConvertible.ToSByte(){} // RVA: 0x66A0970
        public void System.IConvertible.ToByte(){} // RVA: 0x66A0A40
        public void System.IConvertible.ToInt16(){} // RVA: 0x66A0B10
        public void System.IConvertible.ToUInt16(){} // RVA: 0x66A0BE0
        public void System.IConvertible.ToInt32(){} // RVA: 0x66A0CB0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x66A0D30
        public void System.IConvertible.ToInt64(){} // RVA: 0x66A0DB0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x66A0E30
        public void System.IConvertible.ToSingle(){} // RVA: 0x66A0EB0
        public void System.IConvertible.ToDouble(){} // RVA: 0x66A0F30
        public void System.IConvertible.ToDecimal(){} // RVA: 0x66A0FB0
        public void System.IConvertible.ToDateTime(){} // RVA: 0x66A10A0
        public void System.IConvertible.ToType(){} // RVA: 0x66A1150
        public void IsNormalized(){} // RVA: 0x66A11D0
        public void Normalize(){} // RVA: 0x66A12E0
        public void FillStringChecked(){} // RVA: 0x66A13E0
        public void Concat(){} // RVA: 0x66A22C0
        public void Format(){} // RVA: 0x666D430
        public void FormatHelper(){} // RVA: 0x66A2820
        public void Insert(){} // RVA: 0x66A2970
        public void Join(){} // RVA: 0x29CADD0
        public void JoinCore(){} // RVA: 0x29CB120
        public void PadLeft(){} // RVA: 0x66A38B0
        public void PadRight(){} // RVA: 0x66A39E0
        public void Remove(){} // RVA: 0x66A3D50
        public void Replace(){} // RVA: 0x66A44F0
        public void ReplaceCore(){} // RVA: 0x66A4030
        public void ReplaceHelper(){} // RVA: 0x66A4820
        public void Split(){} // RVA: 0x66A5480
        public void SplitInternal(){} // RVA: 0x66A59D0
        public void SplitKeepEmptyEntries(){} // RVA: 0x66A5E10
        public void SplitOmitEmptyEntries(){} // RVA: 0x66A6060
        public void MakeSeparatorList(){} // RVA: 0x66A68D0
        public void Substring(){} // RVA: 0x66A6B30
        public void InternalSubString(){} // RVA: 0x66A6D20
        public void ToLower(){} // RVA: 0x66A6E80
        public void ToLowerInvariant(){} // RVA: 0x66A6F20
        public void ToUpper(){} // RVA: 0x66A70C0
        public void ToUpperInvariant(){} // RVA: 0x66A7160
        public void Trim(){} // RVA: 0x66A7270
        public void TrimStart(){} // RVA: 0x66A7310
        public void TrimEnd(){} // RVA: 0x66A73A0
        public void TrimWhiteSpaceHelper(){} // RVA: 0x66A7400
        public void TrimHelper(){} // RVA: 0x66A7550
        public void CreateTrimmedString(){} // RVA: 0x66A7690
        public void Contains(){} // RVA: 0x66A78F0
        public void IndexOf(){} // RVA: 0x66A8670
        public void IndexOfAny(){} // RVA: 0x66A81B0
        public void IndexOfCharArray(){} // RVA: 0x66A8200
        public void InitializeProbabilisticMap(){} // RVA: 0x66A8370
        public void ArrayContains(){} // RVA: 0x66A8440
        public void IsCharBitSet(){} // RVA: 0x66A8490
        public void SetCharBit(){} // RVA: 0x66A84B0
        public void LastIndexOf(){} // RVA: 0x66A9170
        public void LastIndexOfAny(){} // RVA: 0x66A8C20
        public void LastIndexOfCharArray(){} // RVA: 0x66A8EC0
        public void get_Length(){} // RVA: 0xB8F8F0
        public void IndexOfUnchecked(){} // RVA: 0x66A95A0
        public void IndexOfUncheckedIgnoreCase(){} // RVA: 0x66A9680
        public void LastIndexOfUnchecked(){} // RVA: 0x66A9890
        public void LastIndexOfUncheckedIgnoreCase(){} // RVA: 0x66A9960
        public void StartsWithOrdinalUnchecked(){} // RVA: 0x66A9B20
        public void FastAllocateString(){} // RVA: 0x66A9B70
        public void InternalIsInterned(){} // RVA: 0x66A9B80
        public void InternalIntern(){} // RVA: 0x66A9B90
        public void memset(){} // RVA: 0x66A9BA0
        public void memcpy(){} // RVA: 0x66A9C90
        public void bzero(){} // RVA: 0x66A9CA0
        public void bzero_aligned_1(){} // RVA: 0x27217F0
        public void bzero_aligned_2(){} // RVA: 0x66A9D90
        public void bzero_aligned_4(){} // RVA: 0x275FD30
        public void bzero_aligned_8(){} // RVA: 0x66A9DA0
        public void memcpy_aligned_1(){} // RVA: 0x66A9DB0
        public void memcpy_aligned_2(){} // RVA: 0x66A9DC0
        public void memcpy_aligned_4(){} // RVA: 0x66A9DD0
        public void memcpy_aligned_8(){} // RVA: 0x66A9DE0
        public void CreateString(){} // RVA: 0x66AA100
        public void get_Chars(){} // RVA: 0x66AA200
        public void Intern(){} // RVA: 0x66AA230
        public void IsInterned(){} // RVA: 0x66AA2A0
    }

    public class StringComparer : Object
    {
        public object s_invariantCulture;
        public object s_invariantCultureIgnoreCase;
        public object s_ordinal;
        public object s_ordinalIgnoreCase;

        // ── Methods ──
        public void get_InvariantCulture(){} // RVA: 0x692E4A0
        public void get_InvariantCultureIgnoreCase(){} // RVA: 0x692E500
        public void get_CurrentCulture(){} // RVA: 0x692E560
        public void get_CurrentCultureIgnoreCase(){} // RVA: 0x692E630
        public void get_Ordinal(){} // RVA: 0x692E700
        public void get_OrdinalIgnoreCase(){} // RVA: 0x692E760
        public void FromComparison(){} // RVA: 0x692E7C0
        public void Create(){} // RVA: 0x692E940
        public void Compare(){} // RVA: 0x881CA0
        public void Equals(){} // RVA: 0x87D3C0
        public void GetHashCode(){} // RVA: 0x87D050
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x692EC80
    }

    public class String[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class String[][] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SystemException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

}