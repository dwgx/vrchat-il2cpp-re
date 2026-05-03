// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 5
// Methods: 371

namespace ThirdParty.DotNet.System.Data
{
    public class EvaluateException : InvalidExpressionException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8720B370 | overloaded x3
    }

    public class ExceptionBuilder : Object
    {
        // ── Methods ──
        public void TraceException(){} // RVA: 0x7FFE8720B780
        public void TraceExceptionAsReturnValue(){} // RVA: 0x7FFE8720B810
        public void TraceExceptionForCapture(){} // RVA: 0x7FFE8720B8C0
        public void TraceExceptionWithoutRethrow(){} // RVA: 0x7FFE8720B970
        public void _Argument(){} // RVA: 0x7FFE8720BB00 | overloaded x3
        public void _ArgumentNull(){} // RVA: 0x7FFE8720BB80
        public void _ArgumentOutOfRange(){} // RVA: 0x7FFE8720BC00
        public void _IndexOutOfRange(){} // RVA: 0x7FFE8720BC80
        public void _InvalidOperation(){} // RVA: 0x7FFE8720BCF0
        public void _InvalidEnumArgumentException(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ThrowDataException(){} // RVA: 0x7FFE8720BDD0
        public void _Data(){} // RVA: 0x7FFE8720BE40
        public void _Constraint(){} // RVA: 0x7FFE8720BEB0
        public void _InvalidConstraint(){} // RVA: 0x7FFE8720BF20
        public void _DeletedRowInaccessible(){} // RVA: 0x7FFE8720BF90
        public void _DuplicateName(){} // RVA: 0x7FFE8720C000
        public void _InRowChangingEvent(){} // RVA: 0x7FFE8720C070
        public void _NoNullAllowed(){} // RVA: 0x7FFE8720C0E0
        public void _ReadOnly(){} // RVA: 0x7FFE8720C150
        public void _RowNotInTable(){} // RVA: 0x7FFE8720C1C0
        public void _VersionNotFound(){} // RVA: 0x7FFE8720C230
        public void ArgumentNull(){} // RVA: 0x7FFE8720C2A0
        public void ArgumentOutOfRange(){} // RVA: 0x7FFE8720C350
        public void BadObjectPropertyAccess(){} // RVA: 0x7FFE8720C3A0
        public void ArgumentContainsNull(){} // RVA: 0x7FFE8720C3F0
        public void TypeNotAllowed(){} // RVA: 0x7FFE8720C490
        public void CannotModifyCollection(){} // RVA: 0x7FFE8720C500
        public void CaseInsensitiveNameConflict(){} // RVA: 0x7FFE8720C540
        public void NamespaceNameConflict(){} // RVA: 0x7FFE8720C590
        public void InvalidOffsetLength(){} // RVA: 0x7FFE8720C5E0
        public void ColumnNotInTheTable(){} // RVA: 0x7FFE8720C620
        public void ColumnNotInAnyTable(){} // RVA: 0x7FFE8720C680
        public void ColumnOutOfRange(){} // RVA: 0x7FFE8720C790 | overloaded x2
        public void CannotAddColumn1(){} // RVA: 0x7FFE8720C7E0
        public void CannotAddColumn2(){} // RVA: 0x7FFE8720C830
        public void CannotAddColumn3(){} // RVA: 0x7FFE8720C880
        public void CannotAddColumn4(){} // RVA: 0x7FFE8720C8C0
        public void CannotAddDuplicate(){} // RVA: 0x7FFE8720C910
        public void CannotAddDuplicate2(){} // RVA: 0x7FFE8720C960
        public void CannotAddDuplicate3(){} // RVA: 0x7FFE8720C9B0
        public void CannotRemoveColumn(){} // RVA: 0x7FFE8720CA00
        public void CannotRemovePrimaryKey(){} // RVA: 0x7FFE8720CA40
        public void CannotRemoveChildKey(){} // RVA: 0x7FFE8720CA80
        public void CannotRemoveConstraint(){} // RVA: 0x7FFE8720CAD0
        public void CannotRemoveExpression(){} // RVA: 0x7FFE8720CB30
        public void AddPrimaryKeyConstraint(){} // RVA: 0x7FFE8720CB90
        public void NoConstraintName(){} // RVA: 0x7FFE8720CBD0
        public void ConstraintViolation(){} // RVA: 0x7FFE8720CF10 | overloaded x2
        public void KeysToString(){} // RVA: 0x7FFE8720CC60
        public void UniqueConstraintViolationText(){} // RVA: 0x7FFE8720CD80
        public void ConstraintOutOfRange(){} // RVA: 0x7FFE8720CF30
        public void DuplicateConstraint(){} // RVA: 0x7FFE8720D000
        public void DuplicateConstraintName(){} // RVA: 0x7FFE8720D050
        public void NeededForForeignKeyConstraint(){} // RVA: 0x7FFE8720D0A0
        public void UniqueConstraintViolation(){} // RVA: 0x7FFE8720D140
        public void ConstraintForeignTable(){} // RVA: 0x7FFE8720D180
        public void ConstraintParentValues(){} // RVA: 0x7FFE8720D1C0
        public void ConstraintAddFailed(){} // RVA: 0x7FFE8720D200
        public void ConstraintRemoveFailed(){} // RVA: 0x7FFE8720D260
        public void FailedCascadeDelete(){} // RVA: 0x7FFE8720D2A0
        public void FailedCascadeUpdate(){} // RVA: 0x7FFE8720D2F0
        public void FailedClearParentTable(){} // RVA: 0x7FFE8720D340
        public void ForeignKeyViolation(){} // RVA: 0x7FFE8720D3B0
        public void RemoveParentRow(){} // RVA: 0x7FFE8720D420
        public void MaxLengthViolationText(){} // RVA: 0x7FFE8720D490
        public void NotAllowDBNullViolationText(){} // RVA: 0x7FFE8720D4E0
        public void CantAddConstraintToMultipleNestedTable(){} // RVA: 0x7FFE8720D530
        public void AutoIncrementAndExpression(){} // RVA: 0x7FFE8720D580
        public void AutoIncrementAndDefaultValue(){} // RVA: 0x7FFE8720D5C0
        public void AutoIncrementSeed(){} // RVA: 0x7FFE8720D600
        public void CantChangeDataType(){} // RVA: 0x7FFE8720D640
        public void NullDataType(){} // RVA: 0x7FFE8720D680
        public void ColumnNameRequired(){} // RVA: 0x7FFE8720D6C0
        public void DefaultValueAndAutoIncrement(){} // RVA: 0x7FFE8720D700
        public void DefaultValueDataType(){} // RVA: 0x7FFE8720D740
        public void DefaultValueColumnDataType(){} // RVA: 0x7FFE8720D870
        public void ExpressionAndUnique(){} // RVA: 0x7FFE8720D940
        public void ExpressionAndReadOnly(){} // RVA: 0x7FFE8720D980
        public void ExpressionAndConstraint(){} // RVA: 0x7FFE8720D9C0
        public void ExpressionInConstraint(){} // RVA: 0x7FFE8720DA50
        public void ExpressionCircular(){} // RVA: 0x7FFE8720DAB0
        public void NonUniqueValues(){} // RVA: 0x7FFE8720DAF0
        public void NullKeyValues(){} // RVA: 0x7FFE8720DB40
        public void NullValues(){} // RVA: 0x7FFE8720DB90
        public void ReadOnlyAndExpression(){} // RVA: 0x7FFE8720DC30
        public void ReadOnly(){} // RVA: 0x7FFE8720DC70
        public void UniqueAndExpression(){} // RVA: 0x7FFE8720DCC0
        public void SetFailed(){} // RVA: 0x7FFE8720E560 | overloaded x2
        public void CannotSetToNull(){} // RVA: 0x7FFE8720DE10
        public void LongerThanMaxLength(){} // RVA: 0x7FFE8720DE70
        public void CannotSetMaxLength(){} // RVA: 0x7FFE8720DED0
        public void CannotSetMaxLength2(){} // RVA: 0x7FFE8720DFC0
        public void CannotSetSimpleContentType(){} // RVA: 0x7FFE8720E020
        public void CannotSetSimpleContent(){} // RVA: 0x7FFE8720E080
        public void CannotChangeNamespace(){} // RVA: 0x7FFE8720E0E0
        public void HasToBeStringType(){} // RVA: 0x7FFE8720E130
        public void AutoIncrementCannotSetIfHasData(){} // RVA: 0x7FFE8720E190
        public void INullableUDTwithoutStaticNull(){} // RVA: 0x7FFE8720E1E0
        public void IComparableNotImplemented(){} // RVA: 0x7FFE8720E230
        public void UDTImplementsIChangeTrackingButnotIRevertible(){} // RVA: 0x7FFE8720E280
        public void InvalidDataColumnMapping(){} // RVA: 0x7FFE8720E2D0
        public void CannotSetDateTimeModeForNonDateTimeColumns(){} // RVA: 0x7FFE8720E340
        public void InvalidDateTimeMode(){} // RVA: 0x7FFE8720E380
        public void CantChangeDateTimeMode(){} // RVA: 0x7FFE8720E3C0
        public void ColumnTypeNotSupported(){} // RVA: 0x7FFE8720E480
        public void SetRowStateFilter(){} // RVA: 0x7FFE8720E5B0
        public void CanNotUseDataViewManager(){} // RVA: 0x7FFE8720E5F0
        public void CanNotSetTable(){} // RVA: 0x7FFE8720E630
        public void CanNotUse(){} // RVA: 0x7FFE8720E670
        public void CanNotBindTable(){} // RVA: 0x7FFE8720E6B0
        public void SetTable(){} // RVA: 0x7FFE8720E6F0
        public void SetIListObject(){} // RVA: 0x7FFE8720E730
        public void AddNewNotAllowNull(){} // RVA: 0x7FFE8720E770
        public void NotOpen(){} // RVA: 0x7FFE8720E7B0
        public void CreateChildView(){} // RVA: 0x7FFE8720E7F0
        public void CanNotDelete(){} // RVA: 0x7FFE8720E830
        public void GetElementIndex(){} // RVA: 0x7FFE8720E870
        public void AddExternalObject(){} // RVA: 0x7FFE8720E940
        public void CanNotClear(){} // RVA: 0x7FFE8720E980
        public void InsertExternalObject(){} // RVA: 0x7FFE8720E9C0
        public void RemoveExternalObject(){} // RVA: 0x7FFE8720EA00
        public void ColumnToSortIsOutOfRange(){} // RVA: 0x7FFE8720EA40
        public void KeyTableMismatch(){} // RVA: 0x7FFE8720EA90
        public void KeyNoColumns(){} // RVA: 0x7FFE8720EAD0
        public void KeyTooManyColumns(){} // RVA: 0x7FFE8720EB10
        public void KeyDuplicateColumns(){} // RVA: 0x7FFE8720EBE0
        public void RelationDataSetMismatch(){} // RVA: 0x7FFE8720EC30
        public void ColumnsTypeMismatch(){} // RVA: 0x7FFE8720EC70
        public void KeyLengthMismatch(){} // RVA: 0x7FFE8720ECB0
        public void KeyLengthZero(){} // RVA: 0x7FFE8720ECF0
        public void ForeignRelation(){} // RVA: 0x7FFE8720ED30
        public void KeyColumnsIdentical(){} // RVA: 0x7FFE8720ED70
        public void RelationForeignTable(){} // RVA: 0x7FFE8720EDB0
        public void GetParentRowTableMismatch(){} // RVA: 0x7FFE8720EE10
        public void SetParentRowTableMismatch(){} // RVA: 0x7FFE8720EE70
        public void RelationForeignRow(){} // RVA: 0x7FFE8720EED0
        public void RelationNestedReadOnly(){} // RVA: 0x7FFE8720EF10
        public void TableCantBeNestedInTwoTables(){} // RVA: 0x7FFE8720EF50
        public void LoopInNestedRelations(){} // RVA: 0x7FFE8720EFA0
        public void RelationDoesNotExist(){} // RVA: 0x7FFE8720EFF0
        public void ParentOrChildColumnsDoNotHaveDataSet(){} // RVA: 0x7FFE8720F030
        public void InValidNestedRelation(){} // RVA: 0x7FFE8720F070
        public void InvalidParentNamespaceinNestedRelation(){} // RVA: 0x7FFE8720F0C0
        public void RowNotInTheDataSet(){} // RVA: 0x7FFE8720F110
        public void RowNotInTheTable(){} // RVA: 0x7FFE8720F150
        public void EditInRowChanging(){} // RVA: 0x7FFE8720F190
        public void EndEditInRowChanging(){} // RVA: 0x7FFE8720F1D0
        public void BeginEditInRowChanging(){} // RVA: 0x7FFE8720F210
        public void CancelEditInRowChanging(){} // RVA: 0x7FFE8720F250
        public void DeleteInRowDeleting(){} // RVA: 0x7FFE8720F290
        public void ValueArrayLength(){} // RVA: 0x7FFE8720F2D0
        public void NoCurrentData(){} // RVA: 0x7FFE8720F310
        public void NoOriginalData(){} // RVA: 0x7FFE8720F350
        public void NoProposedData(){} // RVA: 0x7FFE8720F390
        public void RowRemovedFromTheTable(){} // RVA: 0x7FFE8720F3D0
        public void DeletedRowInaccessible(){} // RVA: 0x7FFE8720F410
        public void RowAlreadyDeleted(){} // RVA: 0x7FFE8720F450
        public void RowEmpty(){} // RVA: 0x7FFE8720F490
        public void InvalidRowVersion(){} // RVA: 0x7FFE8720F4D0
        public void RowOutOfRange(){} // RVA: 0x7FFE8720F510
        public void RowInsertTwice(){} // RVA: 0x7FFE8720F5E0
        public void RowInsertMissing(){} // RVA: 0x7FFE8720F6B0
        public void RowAlreadyRemoved(){} // RVA: 0x7FFE8720F700
        public void MultipleParents(){} // RVA: 0x7FFE8720F740
        public void InvalidRowState(){} // RVA: 0x7FFE8720F780
        public void InvalidRowBitPattern(){} // RVA: 0x7FFE8720F7C0
        public void SetDataSetNameToEmpty(){} // RVA: 0x7FFE8720F800
        public void SetDataSetNameConflicting(){} // RVA: 0x7FFE8720F840
        public void DataSetUnsupportedSchema(){} // RVA: 0x7FFE8720F890
        public void MergeMissingDefinition(){} // RVA: 0x7FFE8720F8E0
        public void TablesInDifferentSets(){} // RVA: 0x7FFE8720F930
        public void RelationAlreadyExists(){} // RVA: 0x7FFE8720F970
        public void RowAlreadyInOtherCollection(){} // RVA: 0x7FFE8720F9B0
        public void RowAlreadyInTheCollection(){} // RVA: 0x7FFE8720F9F0
        public void RecordStateRange(){} // RVA: 0x7FFE8720FA30
        public void IndexKeyLength(){} // RVA: 0x7FFE8720FA70
        public void RemovePrimaryKey(){} // RVA: 0x7FFE8720FB50
        public void RelationAlreadyInOtherDataSet(){} // RVA: 0x7FFE8720FBE0
        public void RelationAlreadyInTheDataSet(){} // RVA: 0x7FFE8720FC20
        public void RelationNotInTheDataSet(){} // RVA: 0x7FFE8720FC60
        public void RelationOutOfRange(){} // RVA: 0x7FFE8720FCB0
        public void DuplicateRelation(){} // RVA: 0x7FFE8720FD30
        public void RelationTableNull(){} // RVA: 0x7FFE8720FD80
        public void RelationDataSetNull(){} // RVA: 0x7FFE8720FDC0
        public void RelationTableWasRemoved(){} // RVA: 0x7FFE8720FE00
        public void ParentTableMismatch(){} // RVA: 0x7FFE8720FE40
        public void ChildTableMismatch(){} // RVA: 0x7FFE8720FE80
        public void EnforceConstraint(){} // RVA: 0x7FFE8720FEC0
        public void CaseLocaleMismatch(){} // RVA: 0x7FFE8720FF00
        public void CannotChangeCaseLocale(){} // RVA: 0x7FFE8720FF80 | overloaded x2
        public void InvalidRemotingFormat(){} // RVA: 0x7FFE8720FFD0
        public void TableForeignPrimaryKey(){} // RVA: 0x7FFE87210010
        public void TableCannotAddToSimpleContent(){} // RVA: 0x7FFE87210050
        public void NoTableName(){} // RVA: 0x7FFE87210090
        public void MultipleTextOnlyColumns(){} // RVA: 0x7FFE872100D0
        public void InvalidSortString(){} // RVA: 0x7FFE87210110
        public void DuplicateTableName(){} // RVA: 0x7FFE87210160
        public void DuplicateTableName2(){} // RVA: 0x7FFE872101B0
        public void SelfnestedDatasetConflictingName(){} // RVA: 0x7FFE87210210
        public void DatasetConflictingName(){} // RVA: 0x7FFE87210260
        public void TableAlreadyInOtherDataSet(){} // RVA: 0x7FFE872102B0
        public void TableAlreadyInTheDataSet(){} // RVA: 0x7FFE872102F0
        public void TableOutOfRange(){} // RVA: 0x7FFE87210330
        public void TableNotInTheDataSet(){} // RVA: 0x7FFE87210400
        public void TableInRelation(){} // RVA: 0x7FFE87210450
        public void TableInConstraint(){} // RVA: 0x7FFE87210490
        public void CanNotSerializeDataTableHierarchy(){} // RVA: 0x7FFE87210520
        public void CanNotRemoteDataTable(){} // RVA: 0x7FFE87210560
        public void CanNotSetRemotingFormat(){} // RVA: 0x7FFE872105A0
        public void CanNotSerializeDataTableWithEmptyName(){} // RVA: 0x7FFE872105E0
        public void TableNotFound(){} // RVA: 0x7FFE87210620
        public void AggregateException(){} // RVA: 0x7FFE87210670
        public void InvalidStorageType(){} // RVA: 0x7FFE87210730
        public void RangeArgument(){} // RVA: 0x7FFE872107B0
        public void NullRange(){} // RVA: 0x7FFE872108E0
        public void NegativeMinimumCapacity(){} // RVA: 0x7FFE87210920
        public void ProblematicChars(){} // RVA: 0x7FFE87210960
        public void StorageSetFailed(){} // RVA: 0x7FFE87210B10
        public void SimpleTypeNotSupported(){} // RVA: 0x7FFE87210B50
        public void MissingAttribute(){} // RVA: 0x7FFE87210C20 | overloaded x2
        public void InvalidAttributeValue(){} // RVA: 0x7FFE87210C80
        public void AttributeValues(){} // RVA: 0x7FFE87210CE0
        public void ElementTypeNotFound(){} // RVA: 0x7FFE87210D50
        public void RelationParentNameMissing(){} // RVA: 0x7FFE87210DA0
        public void RelationChildNameMissing(){} // RVA: 0x7FFE87210DF0
        public void RelationTableKeyMissing(){} // RVA: 0x7FFE87210E40
        public void RelationChildKeyMissing(){} // RVA: 0x7FFE87210E90
        public void UndefinedDatatype(){} // RVA: 0x7FFE87210EE0
        public void DatatypeNotDefined(){} // RVA: 0x7FFE87210F30
        public void MismatchKeyLength(){} // RVA: 0x7FFE87210F70
        public void InvalidField(){} // RVA: 0x7FFE87210FB0
        public void InvalidSelector(){} // RVA: 0x7FFE87211000
        public void CircularComplexType(){} // RVA: 0x7FFE87211050
        public void CannotInstantiateAbstract(){} // RVA: 0x7FFE872110A0
        public void InvalidKey(){} // RVA: 0x7FFE872110F0
        public void DiffgramMissingTable(){} // RVA: 0x7FFE87211140
        public void DiffgramMissingSQL(){} // RVA: 0x7FFE87211190
        public void DuplicateConstraintRead(){} // RVA: 0x7FFE872111D0
        public void ColumnTypeConflict(){} // RVA: 0x7FFE87211220
        public void CannotConvert(){} // RVA: 0x7FFE87211270
        public void MissingRefer(){} // RVA: 0x7FFE872112D0
        public void InvalidPrefix(){} // RVA: 0x7FFE87211360
        public void CanNotDeserializeObjectType(){} // RVA: 0x7FFE872113B0
        public void IsDataSetAttributeMissingInSchema(){} // RVA: 0x7FFE872113F0
        public void TooManyIsDataSetAtributeInSchema(){} // RVA: 0x7FFE87211430
        public void NestedCircular(){} // RVA: 0x7FFE87211470
        public void MultipleParentRows(){} // RVA: 0x7FFE872114C0
        public void PolymorphismNotSupported(){} // RVA: 0x7FFE87211510
        public void DataTableInferenceNotSupported(){} // RVA: 0x7FFE87211560
        public void ThrowMultipleTargetConverter(){} // RVA: 0x7FFE872115A0
        public void DuplicateDeclaration(){} // RVA: 0x7FFE872115F0
        public void FoundEntity(){} // RVA: 0x7FFE87211640
        public void MergeFailed(){} // RVA: 0x7FFE87211680
        public void ConvertFailed(){} // RVA: 0x7FFE87211690
        public void InvalidDuplicateNamedSimpleTypeDelaration(){} // RVA: 0x7FFE87211730
        public void InternalRBTreeError(){} // RVA: 0x7FFE87211790
        public void EnumeratorModified(){} // RVA: 0x7FFE87211800
    }

    public class ExprException : Object
    {
        // ── Methods ──
        public void _Overflow(){} // RVA: 0x7FFE872606A0
        public void _Expr(){} // RVA: 0x7FFE87260710
        public void _Syntax(){} // RVA: 0x7FFE87260780
        public void _Eval(){} // RVA: 0x7FFE87260860 | overloaded x2
        public void InvokeArgument(){} // RVA: 0x7FFE872608D0
        public void NYI(){} // RVA: 0x7FFE87260910
        public void MissingOperand(){} // RVA: 0x7FFE872609B0
        public void MissingOperator(){} // RVA: 0x7FFE87260A40
        public void TypeMismatch(){} // RVA: 0x7FFE87260A90
        public void FunctionArgumentOutOfRange(){} // RVA: 0x7FFE87260AE0
        public void ExpressionTooComplex(){} // RVA: 0x7FFE87260B40
        public void UnboundName(){} // RVA: 0x7FFE87260B80
        public void InvalidString(){} // RVA: 0x7FFE87260BD0
        public void UndefinedFunction(){} // RVA: 0x7FFE87260C20
        public void SyntaxError(){} // RVA: 0x7FFE87260C70
        public void FunctionArgumentCount(){} // RVA: 0x7FFE87260CB0
        public void MissingRightParen(){} // RVA: 0x7FFE87260D00
        public void UnknownToken(){} // RVA: 0x7FFE87260E10 | overloaded x2
        public void DatatypeConvertion(){} // RVA: 0x7FFE87260F60
        public void DatavalueConvertion(){} // RVA: 0x7FFE87261000
        public void InvalidName(){} // RVA: 0x7FFE872610F0
        public void InvalidDate(){} // RVA: 0x7FFE87261140
        public void NonConstantArgument(){} // RVA: 0x7FFE87261190
        public void InvalidPattern(){} // RVA: 0x7FFE872611D0
        public void InWithoutParentheses(){} // RVA: 0x7FFE87261220
        public void InWithoutList(){} // RVA: 0x7FFE87261260
        public void InvalidIsSyntax(){} // RVA: 0x7FFE872612A0
        public void Overflow(){} // RVA: 0x7FFE872612E0
        public void ArgumentType(){} // RVA: 0x7FFE872613B0
        public void ArgumentTypeInteger(){} // RVA: 0x7FFE872614D0
        public void TypeMismatchInBinop(){} // RVA: 0x7FFE872615A0
        public void AmbiguousBinop(){} // RVA: 0x7FFE87261690
        public void UnsupportedOperator(){} // RVA: 0x7FFE87261780
        public void InvalidNameBracketing(){} // RVA: 0x7FFE87261800
        public void MissingOperandBefore(){} // RVA: 0x7FFE87261850
        public void TooManyRightParentheses(){} // RVA: 0x7FFE872618A0
        public void UnresolvedRelation(){} // RVA: 0x7FFE872618E0
        public void BindFailure(){} // RVA: 0x7FFE87261940
        public void AggregateArgument(){} // RVA: 0x7FFE87261990
        public void AggregateUnbound(){} // RVA: 0x7FFE872619D0
        public void EvalNoContext(){} // RVA: 0x7FFE87261A20
        public void ExpressionUnbound(){} // RVA: 0x7FFE87261A60
        public void ComputeNotAggregate(){} // RVA: 0x7FFE87261AB0
        public void FilterConvertion(){} // RVA: 0x7FFE87261B00
        public void LookupArgument(){} // RVA: 0x7FFE87261B50
        public void InvalidType(){} // RVA: 0x7FFE87261B90
        public void InvalidHoursArgument(){} // RVA: 0x7FFE87261BE0
        public void InvalidMinutesArgument(){} // RVA: 0x7FFE87261C20
        public void InvalidTimeZoneRange(){} // RVA: 0x7FFE87261C60
        public void MismatchKindandTimeSpan(){} // RVA: 0x7FFE87261CA0
        public void UnsupportedDataType(){} // RVA: 0x7FFE87261CE0
    }

    public class ExpressionNode : Object
    {
        public System.Data.DataTable _table; // 0x10
        public object field_1; // 0x112
        public object field_2; // 0x113

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_FormatProvider(){} // RVA: 0x7FFE8725C590
        public void get_IsSqlColumn(){} // RVA: 0x7FFE810FB320
        public void get_table(){} // RVA: 0x7FFE81116380
        public void BindTable(){} // RVA: 0x7FFE810FCE30
        public void Bind(){} // RVA: 0x7FFE80E4F230
        public void Eval(){} // RVA: 0x7FFE80E2E390 | overloaded x3
        public void IsConstant(){} // RVA: 0x7FFE80E2F150
        public void IsTableConstant(){} // RVA: 0x7FFE80E2F150
        public void HasLocalAggregate(){} // RVA: 0x7FFE80E2F150
        public void HasRemoteAggregate(){} // RVA: 0x7FFE80E2F150
        public void Optimize(){} // RVA: 0x7FFE80E2E2E0
        public void DependsOn(){} // RVA: 0x7FFE810FB320
        public void IsInteger(){} // RVA: 0x7FFE8725C630
        public void IsIntegerSql(){} // RVA: 0x7FFE8725C650
        public void IsSigned(){} // RVA: 0x7FFE8725C670
        public void IsSignedSql(){} // RVA: 0x7FFE8725C690
        public void IsUnsigned(){} // RVA: 0x7FFE8725C6D0
        public void IsUnsignedSql(){} // RVA: 0x7FFE8725C6F0
        public void IsNumeric(){} // RVA: 0x7FFE8725C710
        public void IsNumericSql(){} // RVA: 0x7FFE8725C740
        public void IsFloat(){} // RVA: 0x7FFE8725C780
        public void IsFloatSql(){} // RVA: 0x7FFE8725C7A0
    }

    public class ExpressionParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8725C7C0
        public void LoadExpression(){} // RVA: 0x7FFE8725C950
        public void StartScan(){} // RVA: 0x7FFE8725CB10
        public void Parse(){} // RVA: 0x7FFE8725CBA0
        public void ParseAggregateArgument(){} // RVA: 0x7FFE8725E000
        public void NodePop(){} // RVA: 0x7FFE8725E400
        public void NodePeek(){} // RVA: 0x7FFE8725E440
        public void NodePush(){} // RVA: 0x7FFE8725E480
        public void BuildExpression(){} // RVA: 0x7FFE8725E520
        public void CheckToken(){} // RVA: 0x7FFE8725E8D0
        public void Scan(){} // RVA: 0x7FFE8725E920
        public void ScanNumeric(){} // RVA: 0x7FFE8725F060
        public void ScanName(){} // RVA: 0x7FFE8725F320 | overloaded x2
        public void ScanDate(){} // RVA: 0x7FFE8725F460
        public void ScanBinaryConstant(){} // RVA: 0x7FFE810FB310
        public void ScanReserved(){} // RVA: 0x7FFE8725F580
        public void ScanString(){} // RVA: 0x7FFE8725F830
        public void ScanToken(){} // RVA: 0x7FFE8725F910
        public void ScanWhite(){} // RVA: 0x7FFE8725F970
        public void IsWhiteSpace(){} // RVA: 0x7FFE8725F9C0
        public void IsAlphaNumeric(){} // RVA: 0x7FFE8725F9D0
        public void IsDigit(){} // RVA: 0x7FFE8725FA70
        public void IsAlpha(){} // RVA: 0x7FFE8725FAC0
        public void .cctor(){} // RVA: 0x7FFE8725FB40
    }

}