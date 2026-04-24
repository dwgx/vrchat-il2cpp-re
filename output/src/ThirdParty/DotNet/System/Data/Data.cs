// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 5
// Methods: 413

namespace ThirdParty.DotNet.System.Data
{
    public class DataCommonEventSource : EventSource
    {
        // ── Methods ──
        public void Trace(){} // RVA: 0x7FFD4E2ADC40 | overloaded x7
        public void EnterScope(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void ExitScope(){} // RVA: 0x7FFD542A41E0
        public void .ctor(){} // RVA: 0x7FFD539C5E30
        public void .cctor(){} // RVA: 0x7FFD542A42A0
    }

    public class ExceptionBuilder : Object
    {
        // ── Methods ──
        public void TraceException(){} // RVA: 0x7FFD54283350
        public void TraceExceptionAsReturnValue(){} // RVA: 0x7FFD542833E0
        public void TraceExceptionForCapture(){} // RVA: 0x7FFD54283490
        public void TraceExceptionWithoutRethrow(){} // RVA: 0x7FFD54283540
        public void _Argument(){} // RVA: 0x7FFD542836D0 | overloaded x3
        public void _ArgumentNull(){} // RVA: 0x7FFD54283750
        public void _ArgumentOutOfRange(){} // RVA: 0x7FFD542837D0
        public void _IndexOutOfRange(){} // RVA: 0x7FFD54283850
        public void _InvalidOperation(){} // RVA: 0x7FFD542838C0
        public void _InvalidEnumArgumentException(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ThrowDataException(){} // RVA: 0x7FFD542839A0
        public void _Data(){} // RVA: 0x7FFD54283A10
        public void _Constraint(){} // RVA: 0x7FFD54283A80
        public void _InvalidConstraint(){} // RVA: 0x7FFD54283AF0
        public void _DeletedRowInaccessible(){} // RVA: 0x7FFD54283B60
        public void _DuplicateName(){} // RVA: 0x7FFD54283BD0
        public void _InRowChangingEvent(){} // RVA: 0x7FFD54283C40
        public void _NoNullAllowed(){} // RVA: 0x7FFD54283CB0
        public void _ReadOnly(){} // RVA: 0x7FFD54283D20
        public void _RowNotInTable(){} // RVA: 0x7FFD54283D90
        public void _VersionNotFound(){} // RVA: 0x7FFD54283E00
        public void ArgumentNull(){} // RVA: 0x7FFD54283E70
        public void ArgumentOutOfRange(){} // RVA: 0x7FFD54283F20
        public void BadObjectPropertyAccess(){} // RVA: 0x7FFD54283F70
        public void ArgumentContainsNull(){} // RVA: 0x7FFD54283FC0
        public void TypeNotAllowed(){} // RVA: 0x7FFD54284060
        public void CannotModifyCollection(){} // RVA: 0x7FFD542840D0
        public void CaseInsensitiveNameConflict(){} // RVA: 0x7FFD54284110
        public void NamespaceNameConflict(){} // RVA: 0x7FFD54284160
        public void InvalidOffsetLength(){} // RVA: 0x7FFD542841B0
        public void ColumnNotInTheTable(){} // RVA: 0x7FFD542841F0
        public void ColumnNotInAnyTable(){} // RVA: 0x7FFD54284250
        public void ColumnOutOfRange(){} // RVA: 0x7FFD54284360 | overloaded x2
        public void CannotAddColumn1(){} // RVA: 0x7FFD542843B0
        public void CannotAddColumn2(){} // RVA: 0x7FFD54284400
        public void CannotAddColumn3(){} // RVA: 0x7FFD54284450
        public void CannotAddColumn4(){} // RVA: 0x7FFD54284490
        public void CannotAddDuplicate(){} // RVA: 0x7FFD542844E0
        public void CannotAddDuplicate2(){} // RVA: 0x7FFD54284530
        public void CannotAddDuplicate3(){} // RVA: 0x7FFD54284580
        public void CannotRemoveColumn(){} // RVA: 0x7FFD542845D0
        public void CannotRemovePrimaryKey(){} // RVA: 0x7FFD54284610
        public void CannotRemoveChildKey(){} // RVA: 0x7FFD54284650
        public void CannotRemoveConstraint(){} // RVA: 0x7FFD542846A0
        public void CannotRemoveExpression(){} // RVA: 0x7FFD54284700
        public void AddPrimaryKeyConstraint(){} // RVA: 0x7FFD54284760
        public void NoConstraintName(){} // RVA: 0x7FFD542847A0
        public void ConstraintViolation(){} // RVA: 0x7FFD54284AE0 | overloaded x2
        public void KeysToString(){} // RVA: 0x7FFD54284830
        public void UniqueConstraintViolationText(){} // RVA: 0x7FFD54284950
        public void ConstraintOutOfRange(){} // RVA: 0x7FFD54284B00
        public void DuplicateConstraint(){} // RVA: 0x7FFD54284BD0
        public void DuplicateConstraintName(){} // RVA: 0x7FFD54284C20
        public void NeededForForeignKeyConstraint(){} // RVA: 0x7FFD54284C70
        public void UniqueConstraintViolation(){} // RVA: 0x7FFD54284D10
        public void ConstraintForeignTable(){} // RVA: 0x7FFD54284D50
        public void ConstraintParentValues(){} // RVA: 0x7FFD54284D90
        public void ConstraintAddFailed(){} // RVA: 0x7FFD54284DD0
        public void ConstraintRemoveFailed(){} // RVA: 0x7FFD54284E30
        public void FailedCascadeDelete(){} // RVA: 0x7FFD54284E70
        public void FailedCascadeUpdate(){} // RVA: 0x7FFD54284EC0
        public void FailedClearParentTable(){} // RVA: 0x7FFD54284F10
        public void ForeignKeyViolation(){} // RVA: 0x7FFD54284F80
        public void RemoveParentRow(){} // RVA: 0x7FFD54284FF0
        public void MaxLengthViolationText(){} // RVA: 0x7FFD54285060
        public void NotAllowDBNullViolationText(){} // RVA: 0x7FFD542850B0
        public void CantAddConstraintToMultipleNestedTable(){} // RVA: 0x7FFD54285100
        public void AutoIncrementAndExpression(){} // RVA: 0x7FFD54285150
        public void AutoIncrementAndDefaultValue(){} // RVA: 0x7FFD54285190
        public void AutoIncrementSeed(){} // RVA: 0x7FFD542851D0
        public void CantChangeDataType(){} // RVA: 0x7FFD54285210
        public void NullDataType(){} // RVA: 0x7FFD54285250
        public void ColumnNameRequired(){} // RVA: 0x7FFD54285290
        public void DefaultValueAndAutoIncrement(){} // RVA: 0x7FFD542852D0
        public void DefaultValueDataType(){} // RVA: 0x7FFD54285310
        public void DefaultValueColumnDataType(){} // RVA: 0x7FFD54285440
        public void ExpressionAndUnique(){} // RVA: 0x7FFD54285510
        public void ExpressionAndReadOnly(){} // RVA: 0x7FFD54285550
        public void ExpressionAndConstraint(){} // RVA: 0x7FFD54285590
        public void ExpressionInConstraint(){} // RVA: 0x7FFD54285620
        public void ExpressionCircular(){} // RVA: 0x7FFD54285680
        public void NonUniqueValues(){} // RVA: 0x7FFD542856C0
        public void NullKeyValues(){} // RVA: 0x7FFD54285710
        public void NullValues(){} // RVA: 0x7FFD54285760
        public void ReadOnlyAndExpression(){} // RVA: 0x7FFD54285800
        public void ReadOnly(){} // RVA: 0x7FFD54285840
        public void UniqueAndExpression(){} // RVA: 0x7FFD54285890
        public void SetFailed(){} // RVA: 0x7FFD54286130 | overloaded x2
        public void CannotSetToNull(){} // RVA: 0x7FFD542859E0
        public void LongerThanMaxLength(){} // RVA: 0x7FFD54285A40
        public void CannotSetMaxLength(){} // RVA: 0x7FFD54285AA0
        public void CannotSetMaxLength2(){} // RVA: 0x7FFD54285B90
        public void CannotSetSimpleContentType(){} // RVA: 0x7FFD54285BF0
        public void CannotSetSimpleContent(){} // RVA: 0x7FFD54285C50
        public void CannotChangeNamespace(){} // RVA: 0x7FFD54285CB0
        public void HasToBeStringType(){} // RVA: 0x7FFD54285D00
        public void AutoIncrementCannotSetIfHasData(){} // RVA: 0x7FFD54285D60
        public void INullableUDTwithoutStaticNull(){} // RVA: 0x7FFD54285DB0
        public void IComparableNotImplemented(){} // RVA: 0x7FFD54285E00
        public void UDTImplementsIChangeTrackingButnotIRevertible(){} // RVA: 0x7FFD54285E50
        public void InvalidDataColumnMapping(){} // RVA: 0x7FFD54285EA0
        public void CannotSetDateTimeModeForNonDateTimeColumns(){} // RVA: 0x7FFD54285F10
        public void InvalidDateTimeMode(){} // RVA: 0x7FFD54285F50
        public void CantChangeDateTimeMode(){} // RVA: 0x7FFD54285F90
        public void ColumnTypeNotSupported(){} // RVA: 0x7FFD54286050
        public void SetRowStateFilter(){} // RVA: 0x7FFD54286180
        public void CanNotUseDataViewManager(){} // RVA: 0x7FFD542861C0
        public void CanNotSetTable(){} // RVA: 0x7FFD54286200
        public void CanNotUse(){} // RVA: 0x7FFD54286240
        public void CanNotBindTable(){} // RVA: 0x7FFD54286280
        public void SetTable(){} // RVA: 0x7FFD542862C0
        public void SetIListObject(){} // RVA: 0x7FFD54286300
        public void AddNewNotAllowNull(){} // RVA: 0x7FFD54286340
        public void NotOpen(){} // RVA: 0x7FFD54286380
        public void CreateChildView(){} // RVA: 0x7FFD542863C0
        public void CanNotDelete(){} // RVA: 0x7FFD54286400
        public void GetElementIndex(){} // RVA: 0x7FFD54286440
        public void AddExternalObject(){} // RVA: 0x7FFD54286510
        public void CanNotClear(){} // RVA: 0x7FFD54286550
        public void InsertExternalObject(){} // RVA: 0x7FFD54286590
        public void RemoveExternalObject(){} // RVA: 0x7FFD542865D0
        public void ColumnToSortIsOutOfRange(){} // RVA: 0x7FFD54286610
        public void KeyTableMismatch(){} // RVA: 0x7FFD54286660
        public void KeyNoColumns(){} // RVA: 0x7FFD542866A0
        public void KeyTooManyColumns(){} // RVA: 0x7FFD542866E0
        public void KeyDuplicateColumns(){} // RVA: 0x7FFD542867B0
        public void RelationDataSetMismatch(){} // RVA: 0x7FFD54286800
        public void ColumnsTypeMismatch(){} // RVA: 0x7FFD54286840
        public void KeyLengthMismatch(){} // RVA: 0x7FFD54286880
        public void KeyLengthZero(){} // RVA: 0x7FFD542868C0
        public void ForeignRelation(){} // RVA: 0x7FFD54286900
        public void KeyColumnsIdentical(){} // RVA: 0x7FFD54286940
        public void RelationForeignTable(){} // RVA: 0x7FFD54286980
        public void GetParentRowTableMismatch(){} // RVA: 0x7FFD542869E0
        public void SetParentRowTableMismatch(){} // RVA: 0x7FFD54286A40
        public void RelationForeignRow(){} // RVA: 0x7FFD54286AA0
        public void RelationNestedReadOnly(){} // RVA: 0x7FFD54286AE0
        public void TableCantBeNestedInTwoTables(){} // RVA: 0x7FFD54286B20
        public void LoopInNestedRelations(){} // RVA: 0x7FFD54286B70
        public void RelationDoesNotExist(){} // RVA: 0x7FFD54286BC0
        public void ParentOrChildColumnsDoNotHaveDataSet(){} // RVA: 0x7FFD54286C00
        public void InValidNestedRelation(){} // RVA: 0x7FFD54286C40
        public void InvalidParentNamespaceinNestedRelation(){} // RVA: 0x7FFD54286C90
        public void RowNotInTheDataSet(){} // RVA: 0x7FFD54286CE0
        public void RowNotInTheTable(){} // RVA: 0x7FFD54286D20
        public void EditInRowChanging(){} // RVA: 0x7FFD54286D60
        public void EndEditInRowChanging(){} // RVA: 0x7FFD54286DA0
        public void BeginEditInRowChanging(){} // RVA: 0x7FFD54286DE0
        public void CancelEditInRowChanging(){} // RVA: 0x7FFD54286E20
        public void DeleteInRowDeleting(){} // RVA: 0x7FFD54286E60
        public void ValueArrayLength(){} // RVA: 0x7FFD54286EA0
        public void NoCurrentData(){} // RVA: 0x7FFD54286EE0
        public void NoOriginalData(){} // RVA: 0x7FFD54286F20
        public void NoProposedData(){} // RVA: 0x7FFD54286F60
        public void RowRemovedFromTheTable(){} // RVA: 0x7FFD54286FA0
        public void DeletedRowInaccessible(){} // RVA: 0x7FFD54286FE0
        public void RowAlreadyDeleted(){} // RVA: 0x7FFD54287020
        public void RowEmpty(){} // RVA: 0x7FFD54287060
        public void InvalidRowVersion(){} // RVA: 0x7FFD542870A0
        public void RowOutOfRange(){} // RVA: 0x7FFD542870E0
        public void RowInsertTwice(){} // RVA: 0x7FFD542871B0
        public void RowInsertMissing(){} // RVA: 0x7FFD54287280
        public void RowAlreadyRemoved(){} // RVA: 0x7FFD542872D0
        public void MultipleParents(){} // RVA: 0x7FFD54287310
        public void InvalidRowState(){} // RVA: 0x7FFD54287350
        public void InvalidRowBitPattern(){} // RVA: 0x7FFD54287390
        public void SetDataSetNameToEmpty(){} // RVA: 0x7FFD542873D0
        public void SetDataSetNameConflicting(){} // RVA: 0x7FFD54287410
        public void DataSetUnsupportedSchema(){} // RVA: 0x7FFD54287460
        public void MergeMissingDefinition(){} // RVA: 0x7FFD542874B0
        public void TablesInDifferentSets(){} // RVA: 0x7FFD54287500
        public void RelationAlreadyExists(){} // RVA: 0x7FFD54287540
        public void RowAlreadyInOtherCollection(){} // RVA: 0x7FFD54287580
        public void RowAlreadyInTheCollection(){} // RVA: 0x7FFD542875C0
        public void RecordStateRange(){} // RVA: 0x7FFD54287600
        public void IndexKeyLength(){} // RVA: 0x7FFD54287640
        public void RemovePrimaryKey(){} // RVA: 0x7FFD54287720
        public void RelationAlreadyInOtherDataSet(){} // RVA: 0x7FFD542877B0
        public void RelationAlreadyInTheDataSet(){} // RVA: 0x7FFD542877F0
        public void RelationNotInTheDataSet(){} // RVA: 0x7FFD54287830
        public void RelationOutOfRange(){} // RVA: 0x7FFD54287880
        public void DuplicateRelation(){} // RVA: 0x7FFD54287900
        public void RelationTableNull(){} // RVA: 0x7FFD54287950
        public void RelationDataSetNull(){} // RVA: 0x7FFD54287990
        public void RelationTableWasRemoved(){} // RVA: 0x7FFD542879D0
        public void ParentTableMismatch(){} // RVA: 0x7FFD54287A10
        public void ChildTableMismatch(){} // RVA: 0x7FFD54287A50
        public void EnforceConstraint(){} // RVA: 0x7FFD54287A90
        public void CaseLocaleMismatch(){} // RVA: 0x7FFD54287AD0
        public void CannotChangeCaseLocale(){} // RVA: 0x7FFD54287B50 | overloaded x2
        public void InvalidRemotingFormat(){} // RVA: 0x7FFD54287BA0
        public void TableForeignPrimaryKey(){} // RVA: 0x7FFD54287BE0
        public void TableCannotAddToSimpleContent(){} // RVA: 0x7FFD54287C20
        public void NoTableName(){} // RVA: 0x7FFD54287C60
        public void MultipleTextOnlyColumns(){} // RVA: 0x7FFD54287CA0
        public void InvalidSortString(){} // RVA: 0x7FFD54287CE0
        public void DuplicateTableName(){} // RVA: 0x7FFD54287D30
        public void DuplicateTableName2(){} // RVA: 0x7FFD54287D80
        public void SelfnestedDatasetConflictingName(){} // RVA: 0x7FFD54287DE0
        public void DatasetConflictingName(){} // RVA: 0x7FFD54287E30
        public void TableAlreadyInOtherDataSet(){} // RVA: 0x7FFD54287E80
        public void TableAlreadyInTheDataSet(){} // RVA: 0x7FFD54287EC0
        public void TableOutOfRange(){} // RVA: 0x7FFD54287F00
        public void TableNotInTheDataSet(){} // RVA: 0x7FFD54287FD0
        public void TableInRelation(){} // RVA: 0x7FFD54288020
        public void TableInConstraint(){} // RVA: 0x7FFD54288060
        public void CanNotSerializeDataTableHierarchy(){} // RVA: 0x7FFD542880F0
        public void CanNotRemoteDataTable(){} // RVA: 0x7FFD54288130
        public void CanNotSetRemotingFormat(){} // RVA: 0x7FFD54288170
        public void CanNotSerializeDataTableWithEmptyName(){} // RVA: 0x7FFD542881B0
        public void TableNotFound(){} // RVA: 0x7FFD542881F0
        public void AggregateException(){} // RVA: 0x7FFD54288240
        public void InvalidStorageType(){} // RVA: 0x7FFD54288300
        public void RangeArgument(){} // RVA: 0x7FFD54288380
        public void NullRange(){} // RVA: 0x7FFD542884B0
        public void NegativeMinimumCapacity(){} // RVA: 0x7FFD542884F0
        public void ProblematicChars(){} // RVA: 0x7FFD54288530
        public void StorageSetFailed(){} // RVA: 0x7FFD542886E0
        public void SimpleTypeNotSupported(){} // RVA: 0x7FFD54288720
        public void MissingAttribute(){} // RVA: 0x7FFD542887F0 | overloaded x2
        public void InvalidAttributeValue(){} // RVA: 0x7FFD54288850
        public void AttributeValues(){} // RVA: 0x7FFD542888B0
        public void ElementTypeNotFound(){} // RVA: 0x7FFD54288920
        public void RelationParentNameMissing(){} // RVA: 0x7FFD54288970
        public void RelationChildNameMissing(){} // RVA: 0x7FFD542889C0
        public void RelationTableKeyMissing(){} // RVA: 0x7FFD54288A10
        public void RelationChildKeyMissing(){} // RVA: 0x7FFD54288A60
        public void UndefinedDatatype(){} // RVA: 0x7FFD54288AB0
        public void DatatypeNotDefined(){} // RVA: 0x7FFD54288B00
        public void MismatchKeyLength(){} // RVA: 0x7FFD54288B40
        public void InvalidField(){} // RVA: 0x7FFD54288B80
        public void InvalidSelector(){} // RVA: 0x7FFD54288BD0
        public void CircularComplexType(){} // RVA: 0x7FFD54288C20
        public void CannotInstantiateAbstract(){} // RVA: 0x7FFD54288C70
        public void InvalidKey(){} // RVA: 0x7FFD54288CC0
        public void DiffgramMissingTable(){} // RVA: 0x7FFD54288D10
        public void DiffgramMissingSQL(){} // RVA: 0x7FFD54288D60
        public void DuplicateConstraintRead(){} // RVA: 0x7FFD54288DA0
        public void ColumnTypeConflict(){} // RVA: 0x7FFD54288DF0
        public void CannotConvert(){} // RVA: 0x7FFD54288E40
        public void MissingRefer(){} // RVA: 0x7FFD54288EA0
        public void InvalidPrefix(){} // RVA: 0x7FFD54288F30
        public void CanNotDeserializeObjectType(){} // RVA: 0x7FFD54288F80
        public void IsDataSetAttributeMissingInSchema(){} // RVA: 0x7FFD54288FC0
        public void TooManyIsDataSetAtributeInSchema(){} // RVA: 0x7FFD54289000
        public void NestedCircular(){} // RVA: 0x7FFD54289040
        public void MultipleParentRows(){} // RVA: 0x7FFD54289090
        public void PolymorphismNotSupported(){} // RVA: 0x7FFD542890E0
        public void DataTableInferenceNotSupported(){} // RVA: 0x7FFD54289130
        public void ThrowMultipleTargetConverter(){} // RVA: 0x7FFD54289170
        public void DuplicateDeclaration(){} // RVA: 0x7FFD542891C0
        public void FoundEntity(){} // RVA: 0x7FFD54289210
        public void MergeFailed(){} // RVA: 0x7FFD54289250
        public void ConvertFailed(){} // RVA: 0x7FFD54289260
        public void InvalidDuplicateNamedSimpleTypeDelaration(){} // RVA: 0x7FFD54289300
        public void InternalRBTreeError(){} // RVA: 0x7FFD54289360
        public void EnumeratorModified(){} // RVA: 0x7FFD542893D0
    }

    public class Index : Object
    {
        public object HasRemoteAggregate;
        public object ObjectID;
        public object RecordStates;
        public object RowFilter;
        public object HasDuplicates;
        public object RecordCount;
        public object RefCount;
        public object DoListChanged;
        public object Table;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD542E6640 | overloaded x3
        public void GetAllFields(){} // RVA: 0x7FFD542E6490
        public void Equal(){} // RVA: 0x7FFD542E6C80
        public void get_HasRemoteAggregate(){} // RVA: 0x7FFD5367F9A0
        public void get_ObjectID(){} // RVA: 0x7FFD4ECB13D0
        public void get_RecordStates(){} // RVA: 0x7FFD4E70C4C0
        public void get_RowFilter(){} // RVA: 0x7FFD542E6D30
        public void GetRecord(){} // RVA: 0x7FFD542E6DC0
        public void get_HasDuplicates(){} // RVA: 0x7FFD542E6E70
        public void get_RecordCount(){} // RVA: 0x7FFD4E3E2080
        public void AcceptRecord(){} // RVA: 0x7FFD542E6EF0 | overloaded x2
        public void ListChangedAdd(){} // RVA: 0x7FFD542E7030
        public void ListChangedRemove(){} // RVA: 0x7FFD542E70F0
        public void get_RefCount(){} // RVA: 0x7FFD4E3E20A0
        public void AddRef(){} // RVA: 0x7FFD542E72A0
        public void RemoveRef(){} // RVA: 0x7FFD542E74A0
        public void ApplyChangeAction(){} // RVA: 0x7FFD542E7660
        public void CheckUnique(){} // RVA: 0x7FFD542E7700
        public void CompareRecords(){} // RVA: 0x7FFD542E7750
        public void CompareDataRows(){} // RVA: 0x7FFD542E7980
        public void CompareDuplicateRecords(){} // RVA: 0x7FFD542E7A00
        public void CompareRecordToKey(){} // RVA: 0x7FFD542E7B90
        public void DeleteRecordFromIndex(){} // RVA: 0x7FFD542E7C90
        public void DeleteRecord(){} // RVA: 0x7FFD542E7CB0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFD542E7DC0
        public void GetIndex(){} // RVA: 0x7FFD542E7E80 | overloaded x2
        public void GetUniqueKeyValues(){} // RVA: 0x7FFD542EA630 | overloaded x2
        public void FindNodeByKey(){} // RVA: 0x7FFD542E8180
        public void FindNodeByKeys(){} // RVA: 0x7FFD542E8450
        public void FindNodeByKeyRecord(){} // RVA: 0x7FFD542E8800
        public void GetRangeFromNode(){} // RVA: 0x7FFD542E8920
        public void FindRecords(){} // RVA: 0x7FFD542E8B30 | overloaded x2
        public void FireResetEvent(){} // RVA: 0x7FFD542E8B80
        public void GetChangeAction(){} // RVA: 0x7FFD542E8C70
        public void GetReplaceAction(){} // RVA: 0x7FFD542E8C90
        public void GetRow(){} // RVA: 0x7FFD542E8CB0
        public void GetRows(){} // RVA: 0x7FFD542E8D50 | overloaded x2
        public void InitRecords(){} // RVA: 0x7FFD542E8F70
        public void InsertRecordToIndex(){} // RVA: 0x7FFD542E93B0
        public void InsertRecord(){} // RVA: 0x7FFD542E9410
        public void IsKeyInIndex(){} // RVA: 0x7FFD542E9660 | overloaded x2
        public void IsKeyRecordInIndex(){} // RVA: 0x7FFD542E9680
        public void get_DoListChanged(){} // RVA: 0x7FFD542E97A0
        public void OnListChanged(){} // RVA: 0x7FFD542E9950 | overloaded x3
        public void MaintainDataView(){} // RVA: 0x7FFD542E9B50
        public void Reset(){} // RVA: 0x7FFD542E9C90
        public void RecordChanged(){} // RVA: 0x7FFD542E9E50 | overloaded x2
        public void RecordStateChanged(){} // RVA: 0x7FFD542EA150 | overloaded x2
        public void get_Table(){} // RVA: 0x7FFD4E35C380
        public void IndexOfReference(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Listeners`1 : Object
    {
        public object HasListeners;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E092BC0
        public void get_HasListeners(){} // RVA: 0x7FFD4E079D00
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void IndexOfReference(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void Notify(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveNullListeners(){} // RVA: 0x7FFD4E090ED0
    }

    public class RBTree`1 : Object
    {
        public object Count;
        public object HasDuplicates;
        public object Item;

        // ── Methods ──
        public void CompareNode(){} // RVA: 0x7FFD4E2ADC40
        public void CompareSateliteTreeNode(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090ED0
        public void InitTree(){} // RVA: 0x7FFD4E090980
        public void FreePage(){} // RVA: 0x7FFD4E090A40
        public void AllocPage(){} // RVA: 0x7FFD4E087DE0
        public void MarkPageFull(){} // RVA: 0x7FFD4E090A40
        public void MarkPageFree(){} // RVA: 0x7FFD4E090A40
        public void GetIntValueFromBitMap(){} // RVA: 0x7FFD4E080110
        public void FreeNode(){} // RVA: 0x7FFD4E090ED0
        public void GetIndexOfPageWithFreeSlot(){} // RVA: 0x7FFD4E07FB50
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_HasDuplicates(){} // RVA: 0x7FFD4E079D00
        public void GetNewNode(){} // RVA: 0x7FFD4E2ADC40
        public void Successor(){} // RVA: 0x7FFD4E07D200 | overloaded x2
        public void Minimum(){} // RVA: 0x7FFD4E0800D0
        public void LeftRotate(){}
        public void RightRotate(){}
        public void RBInsert(){} // RVA: 0x7FFD4E2ADC40
        public void UpdateNodeKey(){} // RVA: 0x7FFD4E2ADC40
        public void DeleteByIndex(){} // RVA: 0x7FFD4E2ADC40
        public void RBDelete(){} // RVA: 0x7FFD4E0800D0
        public void RBDeleteX(){}
        public void RBDeleteFixup(){} // RVA: 0x7FFD4E2ADC40
        public void SearchSubTree(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void GetNodeByKey(){} // RVA: 0x7FFD4E2ADC40
        public void GetIndexByKey(){} // RVA: 0x7FFD4E2ADC40
        public void GetIndexByNode(){} // RVA: 0x7FFD4E0800D0
        public void GetIndexByNodePath(){} // RVA: 0x7FFD4E2ADC40
        public void ComputeIndexByNode(){} // RVA: 0x7FFD4E0800D0
        public void ComputeIndexWithSatelliteByNode(){} // RVA: 0x7FFD4E0800D0
        public void GetNodeByIndex(){} // RVA: 0x7FFD4E2ADC40
        public void ComputeNodeByIndex(){} // RVA: 0x7FFD4E080290 | overloaded x2
        public void Insert(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void InsertAt(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void CopyTo(){} // RVA: 0x7FFD4E097970 | overloaded x2
        public void SetRight(){} // RVA: 0x7FFD4E092E60
        public void SetLeft(){} // RVA: 0x7FFD4E092E60
        public void SetParent(){} // RVA: 0x7FFD4E092E60
        public void SetColor(){} // RVA: 0x7FFD4E2ADC40
        public void SetKey(){} // RVA: 0x7FFD4E2ADC40
        public void SetNext(){} // RVA: 0x7FFD4E092E60
        public void SetSubTreeSize(){} // RVA: 0x7FFD4E092E60
        public void IncreaseSize(){} // RVA: 0x7FFD4E090ED0
        public void RecomputeSize(){} // RVA: 0x7FFD4E090ED0
        public void DecreaseSize(){} // RVA: 0x7FFD4E090ED0
        public void Right(){} // RVA: 0x7FFD4E0800D0
        public void Left(){} // RVA: 0x7FFD4E0800D0
        public void Parent(){} // RVA: 0x7FFD4E0800D0
        public void color(){} // RVA: 0x7FFD4E2ADC40
        public void Next(){} // RVA: 0x7FFD4E0800D0
        public void SubTreeSize(){} // RVA: 0x7FFD4E0800D0
        public void Key(){} // RVA: 0x7FFD4E2ADC40
    }

}