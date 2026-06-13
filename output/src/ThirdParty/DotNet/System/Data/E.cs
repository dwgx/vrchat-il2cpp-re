// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 5
// Methods: 371

namespace ThirdParty.DotNet.System.Data
{
    public class EvaluateException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66CC480 | overloaded x3
    }

    public class ExceptionBuilder
    {
        // ── Methods ──
        public void TraceException(){} // RVA: 0x66CC890
        public void TraceExceptionAsReturnValue(){} // RVA: 0x66CC920
        public void TraceExceptionForCapture(){} // RVA: 0x66CC9D0
        public void TraceExceptionWithoutRethrow(){} // RVA: 0x66CCA80
        public void _Argument(){} // RVA: 0x66CCC10 | overloaded x3
        public void _ArgumentNull(){} // RVA: 0x66CCC90
        public void _ArgumentOutOfRange(){} // RVA: 0x66CCD10
        public void _IndexOutOfRange(){} // RVA: 0x66CCD90
        public void _InvalidOperation(){} // RVA: 0x66CCE00
        public void _InvalidEnumArgumentException(){} // RVA: 0x283FA0 | overloaded x2
        public void ThrowDataException(){} // RVA: 0x66CCEE0
        public void _Data(){} // RVA: 0x66CCF50
        public void _Constraint(){} // RVA: 0x66CCFC0
        public void _InvalidConstraint(){} // RVA: 0x66CD030
        public void _DeletedRowInaccessible(){} // RVA: 0x66CD0A0
        public void _DuplicateName(){} // RVA: 0x66CD110
        public void _InRowChangingEvent(){} // RVA: 0x66CD180
        public void _NoNullAllowed(){} // RVA: 0x66CD1F0
        public void _ReadOnly(){} // RVA: 0x66CD260
        public void _RowNotInTable(){} // RVA: 0x66CD2D0
        public void _VersionNotFound(){} // RVA: 0x66CD340
        public void ArgumentNull(){} // RVA: 0x66CD3B0
        public void ArgumentOutOfRange(){} // RVA: 0x66CD460
        public void BadObjectPropertyAccess(){} // RVA: 0x66CD4B0
        public void ArgumentContainsNull(){} // RVA: 0x66CD500
        public void TypeNotAllowed(){} // RVA: 0x66CD5A0
        public void CannotModifyCollection(){} // RVA: 0x66CD610
        public void CaseInsensitiveNameConflict(){} // RVA: 0x66CD650
        public void NamespaceNameConflict(){} // RVA: 0x66CD6A0
        public void InvalidOffsetLength(){} // RVA: 0x66CD6F0
        public void ColumnNotInTheTable(){} // RVA: 0x66CD730
        public void ColumnNotInAnyTable(){} // RVA: 0x66CD790
        public void ColumnOutOfRange(){} // RVA: 0x66CD8A0 | overloaded x2
        public void CannotAddColumn1(){} // RVA: 0x66CD8F0
        public void CannotAddColumn2(){} // RVA: 0x66CD940
        public void CannotAddColumn3(){} // RVA: 0x66CD990
        public void CannotAddColumn4(){} // RVA: 0x66CD9D0
        public void CannotAddDuplicate(){} // RVA: 0x66CDA20
        public void CannotAddDuplicate2(){} // RVA: 0x66CDA70
        public void CannotAddDuplicate3(){} // RVA: 0x66CDAC0
        public void CannotRemoveColumn(){} // RVA: 0x66CDB10
        public void CannotRemovePrimaryKey(){} // RVA: 0x66CDB50
        public void CannotRemoveChildKey(){} // RVA: 0x66CDB90
        public void CannotRemoveConstraint(){} // RVA: 0x66CDBE0
        public void CannotRemoveExpression(){} // RVA: 0x66CDC40
        public void AddPrimaryKeyConstraint(){} // RVA: 0x66CDCA0
        public void NoConstraintName(){} // RVA: 0x66CDCE0
        public void ConstraintViolation(){} // RVA: 0x66CE020 | overloaded x2
        public void KeysToString(){} // RVA: 0x66CDD70
        public void UniqueConstraintViolationText(){} // RVA: 0x66CDE90
        public void ConstraintOutOfRange(){} // RVA: 0x66CE040
        public void DuplicateConstraint(){} // RVA: 0x66CE110
        public void DuplicateConstraintName(){} // RVA: 0x66CE160
        public void NeededForForeignKeyConstraint(){} // RVA: 0x66CE1B0
        public void UniqueConstraintViolation(){} // RVA: 0x66CE250
        public void ConstraintForeignTable(){} // RVA: 0x66CE290
        public void ConstraintParentValues(){} // RVA: 0x66CE2D0
        public void ConstraintAddFailed(){} // RVA: 0x66CE310
        public void ConstraintRemoveFailed(){} // RVA: 0x66CE370
        public void FailedCascadeDelete(){} // RVA: 0x66CE3B0
        public void FailedCascadeUpdate(){} // RVA: 0x66CE400
        public void FailedClearParentTable(){} // RVA: 0x66CE450
        public void ForeignKeyViolation(){} // RVA: 0x66CE4C0
        public void RemoveParentRow(){} // RVA: 0x66CE530
        public void MaxLengthViolationText(){} // RVA: 0x66CE5A0
        public void NotAllowDBNullViolationText(){} // RVA: 0x66CE5F0
        public void CantAddConstraintToMultipleNestedTable(){} // RVA: 0x66CE640
        public void AutoIncrementAndExpression(){} // RVA: 0x66CE690
        public void AutoIncrementAndDefaultValue(){} // RVA: 0x66CE6D0
        public void AutoIncrementSeed(){} // RVA: 0x66CE710
        public void CantChangeDataType(){} // RVA: 0x66CE750
        public void NullDataType(){} // RVA: 0x66CE790
        public void ColumnNameRequired(){} // RVA: 0x66CE7D0
        public void DefaultValueAndAutoIncrement(){} // RVA: 0x66CE810
        public void DefaultValueDataType(){} // RVA: 0x66CE850
        public void DefaultValueColumnDataType(){} // RVA: 0x66CE980
        public void ExpressionAndUnique(){} // RVA: 0x66CEA50
        public void ExpressionAndReadOnly(){} // RVA: 0x66CEA90
        public void ExpressionAndConstraint(){} // RVA: 0x66CEAD0
        public void ExpressionInConstraint(){} // RVA: 0x66CEB60
        public void ExpressionCircular(){} // RVA: 0x66CEBC0
        public void NonUniqueValues(){} // RVA: 0x66CEC00
        public void NullKeyValues(){} // RVA: 0x66CEC50
        public void NullValues(){} // RVA: 0x66CECA0
        public void ReadOnlyAndExpression(){} // RVA: 0x66CED40
        public void ReadOnly(){} // RVA: 0x66CED80
        public void UniqueAndExpression(){} // RVA: 0x66CEDD0
        public void SetFailed(){} // RVA: 0x66CF670 | overloaded x2
        public void CannotSetToNull(){} // RVA: 0x66CEF20
        public void LongerThanMaxLength(){} // RVA: 0x66CEF80
        public void CannotSetMaxLength(){} // RVA: 0x66CEFE0
        public void CannotSetMaxLength2(){} // RVA: 0x66CF0D0
        public void CannotSetSimpleContentType(){} // RVA: 0x66CF130
        public void CannotSetSimpleContent(){} // RVA: 0x66CF190
        public void CannotChangeNamespace(){} // RVA: 0x66CF1F0
        public void HasToBeStringType(){} // RVA: 0x66CF240
        public void AutoIncrementCannotSetIfHasData(){} // RVA: 0x66CF2A0
        public void INullableUDTwithoutStaticNull(){} // RVA: 0x66CF2F0
        public void IComparableNotImplemented(){} // RVA: 0x66CF340
        public void UDTImplementsIChangeTrackingButnotIRevertible(){} // RVA: 0x66CF390
        public void InvalidDataColumnMapping(){} // RVA: 0x66CF3E0
        public void CannotSetDateTimeModeForNonDateTimeColumns(){} // RVA: 0x66CF450
        public void InvalidDateTimeMode(){} // RVA: 0x66CF490
        public void CantChangeDateTimeMode(){} // RVA: 0x66CF4D0
        public void ColumnTypeNotSupported(){} // RVA: 0x66CF590
        public void SetRowStateFilter(){} // RVA: 0x66CF6C0
        public void CanNotUseDataViewManager(){} // RVA: 0x66CF700
        public void CanNotSetTable(){} // RVA: 0x66CF740
        public void CanNotUse(){} // RVA: 0x66CF780
        public void CanNotBindTable(){} // RVA: 0x66CF7C0
        public void SetTable(){} // RVA: 0x66CF800
        public void SetIListObject(){} // RVA: 0x66CF840
        public void AddNewNotAllowNull(){} // RVA: 0x66CF880
        public void NotOpen(){} // RVA: 0x66CF8C0
        public void CreateChildView(){} // RVA: 0x66CF900
        public void CanNotDelete(){} // RVA: 0x66CF940
        public void GetElementIndex(){} // RVA: 0x66CF980
        public void AddExternalObject(){} // RVA: 0x66CFA50
        public void CanNotClear(){} // RVA: 0x66CFA90
        public void InsertExternalObject(){} // RVA: 0x66CFAD0
        public void RemoveExternalObject(){} // RVA: 0x66CFB10
        public void ColumnToSortIsOutOfRange(){} // RVA: 0x66CFB50
        public void KeyTableMismatch(){} // RVA: 0x66CFBA0
        public void KeyNoColumns(){} // RVA: 0x66CFBE0
        public void KeyTooManyColumns(){} // RVA: 0x66CFC20
        public void KeyDuplicateColumns(){} // RVA: 0x66CFCF0
        public void RelationDataSetMismatch(){} // RVA: 0x66CFD40
        public void ColumnsTypeMismatch(){} // RVA: 0x66CFD80
        public void KeyLengthMismatch(){} // RVA: 0x66CFDC0
        public void KeyLengthZero(){} // RVA: 0x66CFE00
        public void ForeignRelation(){} // RVA: 0x66CFE40
        public void KeyColumnsIdentical(){} // RVA: 0x66CFE80
        public void RelationForeignTable(){} // RVA: 0x66CFEC0
        public void GetParentRowTableMismatch(){} // RVA: 0x66CFF20
        public void SetParentRowTableMismatch(){} // RVA: 0x66CFF80
        public void RelationForeignRow(){} // RVA: 0x66CFFE0
        public void RelationNestedReadOnly(){} // RVA: 0x66D0020
        public void TableCantBeNestedInTwoTables(){} // RVA: 0x66D0060
        public void LoopInNestedRelations(){} // RVA: 0x66D00B0
        public void RelationDoesNotExist(){} // RVA: 0x66D0100
        public void ParentOrChildColumnsDoNotHaveDataSet(){} // RVA: 0x66D0140
        public void InValidNestedRelation(){} // RVA: 0x66D0180
        public void InvalidParentNamespaceinNestedRelation(){} // RVA: 0x66D01D0
        public void RowNotInTheDataSet(){} // RVA: 0x66D0220
        public void RowNotInTheTable(){} // RVA: 0x66D0260
        public void EditInRowChanging(){} // RVA: 0x66D02A0
        public void EndEditInRowChanging(){} // RVA: 0x66D02E0
        public void BeginEditInRowChanging(){} // RVA: 0x66D0320
        public void CancelEditInRowChanging(){} // RVA: 0x66D0360
        public void DeleteInRowDeleting(){} // RVA: 0x66D03A0
        public void ValueArrayLength(){} // RVA: 0x66D03E0
        public void NoCurrentData(){} // RVA: 0x66D0420
        public void NoOriginalData(){} // RVA: 0x66D0460
        public void NoProposedData(){} // RVA: 0x66D04A0
        public void RowRemovedFromTheTable(){} // RVA: 0x66D04E0
        public void DeletedRowInaccessible(){} // RVA: 0x66D0520
        public void RowAlreadyDeleted(){} // RVA: 0x66D0560
        public void RowEmpty(){} // RVA: 0x66D05A0
        public void InvalidRowVersion(){} // RVA: 0x66D05E0
        public void RowOutOfRange(){} // RVA: 0x66D0620
        public void RowInsertTwice(){} // RVA: 0x66D06F0
        public void RowInsertMissing(){} // RVA: 0x66D07C0
        public void RowAlreadyRemoved(){} // RVA: 0x66D0810
        public void MultipleParents(){} // RVA: 0x66D0850
        public void InvalidRowState(){} // RVA: 0x66D0890
        public void InvalidRowBitPattern(){} // RVA: 0x66D08D0
        public void SetDataSetNameToEmpty(){} // RVA: 0x66D0910
        public void SetDataSetNameConflicting(){} // RVA: 0x66D0950
        public void DataSetUnsupportedSchema(){} // RVA: 0x66D09A0
        public void MergeMissingDefinition(){} // RVA: 0x66D09F0
        public void TablesInDifferentSets(){} // RVA: 0x66D0A40
        public void RelationAlreadyExists(){} // RVA: 0x66D0A80
        public void RowAlreadyInOtherCollection(){} // RVA: 0x66D0AC0
        public void RowAlreadyInTheCollection(){} // RVA: 0x66D0B00
        public void RecordStateRange(){} // RVA: 0x66D0B40
        public void IndexKeyLength(){} // RVA: 0x66D0B80
        public void RemovePrimaryKey(){} // RVA: 0x66D0C60
        public void RelationAlreadyInOtherDataSet(){} // RVA: 0x66D0CF0
        public void RelationAlreadyInTheDataSet(){} // RVA: 0x66D0D30
        public void RelationNotInTheDataSet(){} // RVA: 0x66D0D70
        public void RelationOutOfRange(){} // RVA: 0x66D0DC0
        public void DuplicateRelation(){} // RVA: 0x66D0E40
        public void RelationTableNull(){} // RVA: 0x66D0E90
        public void RelationDataSetNull(){} // RVA: 0x66D0ED0
        public void RelationTableWasRemoved(){} // RVA: 0x66D0F10
        public void ParentTableMismatch(){} // RVA: 0x66D0F50
        public void ChildTableMismatch(){} // RVA: 0x66D0F90
        public void EnforceConstraint(){} // RVA: 0x66D0FD0
        public void CaseLocaleMismatch(){} // RVA: 0x66D1010
        public void CannotChangeCaseLocale(){} // RVA: 0x66D1090 | overloaded x2
        public void InvalidRemotingFormat(){} // RVA: 0x66D10E0
        public void TableForeignPrimaryKey(){} // RVA: 0x66D1120
        public void TableCannotAddToSimpleContent(){} // RVA: 0x66D1160
        public void NoTableName(){} // RVA: 0x66D11A0
        public void MultipleTextOnlyColumns(){} // RVA: 0x66D11E0
        public void InvalidSortString(){} // RVA: 0x66D1220
        public void DuplicateTableName(){} // RVA: 0x66D1270
        public void DuplicateTableName2(){} // RVA: 0x66D12C0
        public void SelfnestedDatasetConflictingName(){} // RVA: 0x66D1320
        public void DatasetConflictingName(){} // RVA: 0x66D1370
        public void TableAlreadyInOtherDataSet(){} // RVA: 0x66D13C0
        public void TableAlreadyInTheDataSet(){} // RVA: 0x66D1400
        public void TableOutOfRange(){} // RVA: 0x66D1440
        public void TableNotInTheDataSet(){} // RVA: 0x66D1510
        public void TableInRelation(){} // RVA: 0x66D1560
        public void TableInConstraint(){} // RVA: 0x66D15A0
        public void CanNotSerializeDataTableHierarchy(){} // RVA: 0x66D1630
        public void CanNotRemoteDataTable(){} // RVA: 0x66D1670
        public void CanNotSetRemotingFormat(){} // RVA: 0x66D16B0
        public void CanNotSerializeDataTableWithEmptyName(){} // RVA: 0x66D16F0
        public void TableNotFound(){} // RVA: 0x66D1730
        public void AggregateException(){} // RVA: 0x66D1780
        public void InvalidStorageType(){} // RVA: 0x66D1840
        public void RangeArgument(){} // RVA: 0x66D18C0
        public void NullRange(){} // RVA: 0x66D19F0
        public void NegativeMinimumCapacity(){} // RVA: 0x66D1A30
        public void ProblematicChars(){} // RVA: 0x66D1A70
        public void StorageSetFailed(){} // RVA: 0x66D1C20
        public void SimpleTypeNotSupported(){} // RVA: 0x66D1C60
        public void MissingAttribute(){} // RVA: 0x66D1D30 | overloaded x2
        public void InvalidAttributeValue(){} // RVA: 0x66D1D90
        public void AttributeValues(){} // RVA: 0x66D1DF0
        public void ElementTypeNotFound(){} // RVA: 0x66D1E60
        public void RelationParentNameMissing(){} // RVA: 0x66D1EB0
        public void RelationChildNameMissing(){} // RVA: 0x66D1F00
        public void RelationTableKeyMissing(){} // RVA: 0x66D1F50
        public void RelationChildKeyMissing(){} // RVA: 0x66D1FA0
        public void UndefinedDatatype(){} // RVA: 0x66D1FF0
        public void DatatypeNotDefined(){} // RVA: 0x66D2040
        public void MismatchKeyLength(){} // RVA: 0x66D2080
        public void InvalidField(){} // RVA: 0x66D20C0
        public void InvalidSelector(){} // RVA: 0x66D2110
        public void CircularComplexType(){} // RVA: 0x66D2160
        public void CannotInstantiateAbstract(){} // RVA: 0x66D21B0
        public void InvalidKey(){} // RVA: 0x66D2200
        public void DiffgramMissingTable(){} // RVA: 0x66D2250
        public void DiffgramMissingSQL(){} // RVA: 0x66D22A0
        public void DuplicateConstraintRead(){} // RVA: 0x66D22E0
        public void ColumnTypeConflict(){} // RVA: 0x66D2330
        public void CannotConvert(){} // RVA: 0x66D2380
        public void MissingRefer(){} // RVA: 0x66D23E0
        public void InvalidPrefix(){} // RVA: 0x66D2470
        public void CanNotDeserializeObjectType(){} // RVA: 0x66D24C0
        public void IsDataSetAttributeMissingInSchema(){} // RVA: 0x66D2500
        public void TooManyIsDataSetAtributeInSchema(){} // RVA: 0x66D2540
        public void NestedCircular(){} // RVA: 0x66D2580
        public void MultipleParentRows(){} // RVA: 0x66D25D0
        public void PolymorphismNotSupported(){} // RVA: 0x66D2620
        public void DataTableInferenceNotSupported(){} // RVA: 0x66D2670
        public void ThrowMultipleTargetConverter(){} // RVA: 0x66D26B0
        public void DuplicateDeclaration(){} // RVA: 0x66D2700
        public void FoundEntity(){} // RVA: 0x66D2750
        public void MergeFailed(){} // RVA: 0x66D2790
        public void ConvertFailed(){} // RVA: 0x66D27A0
        public void InvalidDuplicateNamedSimpleTypeDelaration(){} // RVA: 0x66D2840
        public void InternalRBTreeError(){} // RVA: 0x66D28A0
        public void EnumeratorModified(){} // RVA: 0x66D2910
    }

    public class ExprException
    {
        // ── Methods ──
        public void _Overflow(){} // RVA: 0x67217A0
        public void _Expr(){} // RVA: 0x6721810
        public void _Syntax(){} // RVA: 0x6721880
        public void _Eval(){} // RVA: 0x6721960 | overloaded x2
        public void InvokeArgument(){} // RVA: 0x67219D0
        public void NYI(){} // RVA: 0x6721A10
        public void MissingOperand(){} // RVA: 0x6721AB0
        public void MissingOperator(){} // RVA: 0x6721B40
        public void TypeMismatch(){} // RVA: 0x6721B90
        public void FunctionArgumentOutOfRange(){} // RVA: 0x6721BE0
        public void ExpressionTooComplex(){} // RVA: 0x6721C40
        public void UnboundName(){} // RVA: 0x6721C80
        public void InvalidString(){} // RVA: 0x6721CD0
        public void UndefinedFunction(){} // RVA: 0x6721D20
        public void SyntaxError(){} // RVA: 0x6721D70
        public void FunctionArgumentCount(){} // RVA: 0x6721DB0
        public void MissingRightParen(){} // RVA: 0x6721E00
        public void UnknownToken(){} // RVA: 0x6721F10 | overloaded x2
        public void DatatypeConvertion(){} // RVA: 0x6722060
        public void DatavalueConvertion(){} // RVA: 0x6722100
        public void InvalidName(){} // RVA: 0x67221F0
        public void InvalidDate(){} // RVA: 0x6722240
        public void NonConstantArgument(){} // RVA: 0x6722290
        public void InvalidPattern(){} // RVA: 0x67222D0
        public void InWithoutParentheses(){} // RVA: 0x6722320
        public void InWithoutList(){} // RVA: 0x6722360
        public void InvalidIsSyntax(){} // RVA: 0x67223A0
        public void Overflow(){} // RVA: 0x67223E0
        public void ArgumentType(){} // RVA: 0x67224B0
        public void ArgumentTypeInteger(){} // RVA: 0x67225D0
        public void TypeMismatchInBinop(){} // RVA: 0x67226A0
        public void AmbiguousBinop(){} // RVA: 0x6722790
        public void UnsupportedOperator(){} // RVA: 0x6722880
        public void InvalidNameBracketing(){} // RVA: 0x6722900
        public void MissingOperandBefore(){} // RVA: 0x6722950
        public void TooManyRightParentheses(){} // RVA: 0x67229A0
        public void UnresolvedRelation(){} // RVA: 0x67229E0
        public void BindFailure(){} // RVA: 0x6722A40
        public void AggregateArgument(){} // RVA: 0x6722A90
        public void AggregateUnbound(){} // RVA: 0x6722AD0
        public void EvalNoContext(){} // RVA: 0x6722B20
        public void ExpressionUnbound(){} // RVA: 0x6722B60
        public void ComputeNotAggregate(){} // RVA: 0x6722BB0
        public void FilterConvertion(){} // RVA: 0x6722C00
        public void LookupArgument(){} // RVA: 0x6722C50
        public void InvalidType(){} // RVA: 0x6722C90
        public void InvalidHoursArgument(){} // RVA: 0x6722CE0
        public void InvalidMinutesArgument(){} // RVA: 0x6722D20
        public void InvalidTimeZoneRange(){} // RVA: 0x6722D60
        public void MismatchKindandTimeSpan(){} // RVA: 0x6722DA0
        public void UnsupportedDataType(){} // RVA: 0x6722DE0
    }

    public class ExpressionNode
    {
        public System.Data.DataTable _table; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_FormatProvider(){} // RVA: 0x671D690
        public void get_IsSqlColumn(){} // RVA: 0x2DD320
        public void get_table(){} // RVA: 0x2F8380
        public void BindTable(){} // RVA: 0x2DEE30
        public void Bind(){} // RVA: 0x2DC60
        public void Eval(){} // RVA: 0xCE10 | overloaded x3
        public void IsConstant(){} // RVA: 0xDBE0
        public void IsTableConstant(){} // RVA: 0xDBE0
        public void HasLocalAggregate(){} // RVA: 0xDBE0
        public void HasRemoteAggregate(){} // RVA: 0xDBE0
        public void Optimize(){} // RVA: 0xCD60
        public void DependsOn(){} // RVA: 0x2DD320
        public void IsInteger(){} // RVA: 0x671D730
        public void IsIntegerSql(){} // RVA: 0x671D750
        public void IsSigned(){} // RVA: 0x671D770
        public void IsSignedSql(){} // RVA: 0x671D790
        public void IsUnsigned(){} // RVA: 0x671D7D0
        public void IsUnsignedSql(){} // RVA: 0x671D7F0
        public void IsNumeric(){} // RVA: 0x671D810
        public void IsNumericSql(){} // RVA: 0x671D840
        public void IsFloat(){} // RVA: 0x671D880
        public void IsFloatSql(){} // RVA: 0x671D8A0
    }

    public class ExpressionParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x671D8C0
        public void LoadExpression(){} // RVA: 0x671DA50
        public void StartScan(){} // RVA: 0x671DC10
        public void Parse(){} // RVA: 0x671DCA0
        public void ParseAggregateArgument(){} // RVA: 0x671F100
        public void NodePop(){} // RVA: 0x671F500
        public void NodePeek(){} // RVA: 0x671F540
        public void NodePush(){} // RVA: 0x671F580
        public void BuildExpression(){} // RVA: 0x671F620
        public void CheckToken(){} // RVA: 0x671F9D0
        public void Scan(){} // RVA: 0x671FA20
        public void ScanNumeric(){} // RVA: 0x6720160
        public void ScanName(){} // RVA: 0x6720420 | overloaded x2
        public void ScanDate(){} // RVA: 0x6720560
        public void ScanBinaryConstant(){} // RVA: 0x2DD310
        public void ScanReserved(){} // RVA: 0x6720680
        public void ScanString(){} // RVA: 0x6720930
        public void ScanToken(){} // RVA: 0x6720A10
        public void ScanWhite(){} // RVA: 0x6720A70
        public void IsWhiteSpace(){} // RVA: 0x6720AC0
        public void IsAlphaNumeric(){} // RVA: 0x6720AD0
        public void IsDigit(){} // RVA: 0x6720B70
        public void IsAlpha(){} // RVA: 0x6720BC0
        public void .cctor(){} // RVA: 0x6720C40
    }

}