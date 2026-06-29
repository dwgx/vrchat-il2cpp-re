// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 5
// Methods: 356

namespace ThirdParty.DotNet.System.Data
{
    public class EvaluateException : InvalidExpressionException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7135CB0
    }

    public class ExceptionBuilder : Object
    {
        // ── Methods ──
        public void TraceException(){} // RVA: 0x71360C0
        public void TraceExceptionAsReturnValue(){} // RVA: 0x7136150
        public void TraceExceptionForCapture(){} // RVA: 0x7136200
        public void TraceExceptionWithoutRethrow(){} // RVA: 0x71362B0
        public void _Argument(){} // RVA: 0x7136440
        public void _ArgumentNull(){} // RVA: 0x71364C0
        public void _ArgumentOutOfRange(){} // RVA: 0x7136540
        public void _IndexOutOfRange(){} // RVA: 0x71365C0
        public void _InvalidOperation(){} // RVA: 0x7136630
        public void _InvalidEnumArgumentException(){} // RVA: 0xA94080
        public void ThrowDataException(){} // RVA: 0x7136710
        public void _Data(){} // RVA: 0x7136780
        public void _Constraint(){} // RVA: 0x71367F0
        public void _InvalidConstraint(){} // RVA: 0x7136860
        public void _DeletedRowInaccessible(){} // RVA: 0x71368D0
        public void _DuplicateName(){} // RVA: 0x7136940
        public void _InRowChangingEvent(){} // RVA: 0x71369B0
        public void _NoNullAllowed(){} // RVA: 0x7136A20
        public void _ReadOnly(){} // RVA: 0x7136A90
        public void _RowNotInTable(){} // RVA: 0x7136B00
        public void _VersionNotFound(){} // RVA: 0x7136B70
        public void ArgumentNull(){} // RVA: 0x7136BE0
        public void ArgumentOutOfRange(){} // RVA: 0x7136C90
        public void BadObjectPropertyAccess(){} // RVA: 0x7136CE0
        public void ArgumentContainsNull(){} // RVA: 0x7136D30
        public void TypeNotAllowed(){} // RVA: 0x7136DD0
        public void CannotModifyCollection(){} // RVA: 0x7136E40
        public void CaseInsensitiveNameConflict(){} // RVA: 0x7136E80
        public void NamespaceNameConflict(){} // RVA: 0x7136ED0
        public void InvalidOffsetLength(){} // RVA: 0x7136F20
        public void ColumnNotInTheTable(){} // RVA: 0x7136F60
        public void ColumnNotInAnyTable(){} // RVA: 0x7136FC0
        public void ColumnOutOfRange(){} // RVA: 0x71370D0
        public void CannotAddColumn1(){} // RVA: 0x7137120
        public void CannotAddColumn2(){} // RVA: 0x7137170
        public void CannotAddColumn3(){} // RVA: 0x71371C0
        public void CannotAddColumn4(){} // RVA: 0x7137200
        public void CannotAddDuplicate(){} // RVA: 0x7137250
        public void CannotAddDuplicate2(){} // RVA: 0x71372A0
        public void CannotAddDuplicate3(){} // RVA: 0x71372F0
        public void CannotRemoveColumn(){} // RVA: 0x7137340
        public void CannotRemovePrimaryKey(){} // RVA: 0x7137380
        public void CannotRemoveChildKey(){} // RVA: 0x71373C0
        public void CannotRemoveConstraint(){} // RVA: 0x7137410
        public void CannotRemoveExpression(){} // RVA: 0x7137470
        public void AddPrimaryKeyConstraint(){} // RVA: 0x71374D0
        public void NoConstraintName(){} // RVA: 0x7137510
        public void ConstraintViolation(){} // RVA: 0x7137840
        public void KeysToString(){} // RVA: 0x71375A0
        public void UniqueConstraintViolationText(){} // RVA: 0x71376B0
        public void ConstraintOutOfRange(){} // RVA: 0x7137860
        public void DuplicateConstraint(){} // RVA: 0x7137930
        public void DuplicateConstraintName(){} // RVA: 0x7137980
        public void NeededForForeignKeyConstraint(){} // RVA: 0x71379D0
        public void UniqueConstraintViolation(){} // RVA: 0x7137A70
        public void ConstraintForeignTable(){} // RVA: 0x7137AB0
        public void ConstraintParentValues(){} // RVA: 0x7137AF0
        public void ConstraintAddFailed(){} // RVA: 0x7137B30
        public void ConstraintRemoveFailed(){} // RVA: 0x7137B90
        public void FailedCascadeDelete(){} // RVA: 0x7137BD0
        public void FailedCascadeUpdate(){} // RVA: 0x7137C20
        public void FailedClearParentTable(){} // RVA: 0x7137C70
        public void ForeignKeyViolation(){} // RVA: 0x7137CE0
        public void RemoveParentRow(){} // RVA: 0x7137D50
        public void MaxLengthViolationText(){} // RVA: 0x7137DC0
        public void NotAllowDBNullViolationText(){} // RVA: 0x7137E10
        public void CantAddConstraintToMultipleNestedTable(){} // RVA: 0x7137E60
        public void AutoIncrementAndExpression(){} // RVA: 0x7137EB0
        public void AutoIncrementAndDefaultValue(){} // RVA: 0x7137EF0
        public void AutoIncrementSeed(){} // RVA: 0x7137F30
        public void CantChangeDataType(){} // RVA: 0x7137F70
        public void NullDataType(){} // RVA: 0x7137FB0
        public void ColumnNameRequired(){} // RVA: 0x7137FF0
        public void DefaultValueAndAutoIncrement(){} // RVA: 0x7138030
        public void DefaultValueDataType(){} // RVA: 0x7138070
        public void DefaultValueColumnDataType(){} // RVA: 0x71381A0
        public void ExpressionAndUnique(){} // RVA: 0x7138270
        public void ExpressionAndReadOnly(){} // RVA: 0x71382B0
        public void ExpressionAndConstraint(){} // RVA: 0x71382F0
        public void ExpressionInConstraint(){} // RVA: 0x7138380
        public void ExpressionCircular(){} // RVA: 0x71383E0
        public void NonUniqueValues(){} // RVA: 0x7138420
        public void NullKeyValues(){} // RVA: 0x7138470
        public void NullValues(){} // RVA: 0x71384C0
        public void ReadOnlyAndExpression(){} // RVA: 0x7138560
        public void ReadOnly(){} // RVA: 0x71385A0
        public void UniqueAndExpression(){} // RVA: 0x71385F0
        public void SetFailed(){} // RVA: 0x7138E90
        public void CannotSetToNull(){} // RVA: 0x7138740
        public void LongerThanMaxLength(){} // RVA: 0x71387A0
        public void CannotSetMaxLength(){} // RVA: 0x7138800
        public void CannotSetMaxLength2(){} // RVA: 0x71388F0
        public void CannotSetSimpleContentType(){} // RVA: 0x7138950
        public void CannotSetSimpleContent(){} // RVA: 0x71389B0
        public void CannotChangeNamespace(){} // RVA: 0x7138A10
        public void HasToBeStringType(){} // RVA: 0x7138A60
        public void AutoIncrementCannotSetIfHasData(){} // RVA: 0x7138AC0
        public void INullableUDTwithoutStaticNull(){} // RVA: 0x7138B10
        public void IComparableNotImplemented(){} // RVA: 0x7138B60
        public void UDTImplementsIChangeTrackingButnotIRevertible(){} // RVA: 0x7138BB0
        public void InvalidDataColumnMapping(){} // RVA: 0x7138C00
        public void CannotSetDateTimeModeForNonDateTimeColumns(){} // RVA: 0x7138C70
        public void InvalidDateTimeMode(){} // RVA: 0x7138CB0
        public void CantChangeDateTimeMode(){} // RVA: 0x7138CF0
        public void ColumnTypeNotSupported(){} // RVA: 0x7138DB0
        public void SetRowStateFilter(){} // RVA: 0x7138EE0
        public void CanNotUseDataViewManager(){} // RVA: 0x7138F20
        public void CanNotSetTable(){} // RVA: 0x7138F60
        public void CanNotUse(){} // RVA: 0x7138FA0
        public void CanNotBindTable(){} // RVA: 0x7138FE0
        public void SetTable(){} // RVA: 0x7139020
        public void SetIListObject(){} // RVA: 0x7139060
        public void AddNewNotAllowNull(){} // RVA: 0x71390A0
        public void NotOpen(){} // RVA: 0x71390E0
        public void CreateChildView(){} // RVA: 0x7139120
        public void CanNotDelete(){} // RVA: 0x7139160
        public void GetElementIndex(){} // RVA: 0x71391A0
        public void AddExternalObject(){} // RVA: 0x7139270
        public void CanNotClear(){} // RVA: 0x71392B0
        public void InsertExternalObject(){} // RVA: 0x71392F0
        public void RemoveExternalObject(){} // RVA: 0x7139330
        public void ColumnToSortIsOutOfRange(){} // RVA: 0x7139370
        public void KeyTableMismatch(){} // RVA: 0x71393C0
        public void KeyNoColumns(){} // RVA: 0x7139400
        public void KeyTooManyColumns(){} // RVA: 0x7139440
        public void KeyDuplicateColumns(){} // RVA: 0x7139510
        public void RelationDataSetMismatch(){} // RVA: 0x7139560
        public void ColumnsTypeMismatch(){} // RVA: 0x71395A0
        public void KeyLengthMismatch(){} // RVA: 0x71395E0
        public void KeyLengthZero(){} // RVA: 0x7139620
        public void ForeignRelation(){} // RVA: 0x7139660
        public void KeyColumnsIdentical(){} // RVA: 0x71396A0
        public void RelationForeignTable(){} // RVA: 0x71396E0
        public void GetParentRowTableMismatch(){} // RVA: 0x7139740
        public void SetParentRowTableMismatch(){} // RVA: 0x71397A0
        public void RelationForeignRow(){} // RVA: 0x7139800
        public void RelationNestedReadOnly(){} // RVA: 0x7139840
        public void TableCantBeNestedInTwoTables(){} // RVA: 0x7139880
        public void LoopInNestedRelations(){} // RVA: 0x71398D0
        public void RelationDoesNotExist(){} // RVA: 0x7139920
        public void ParentOrChildColumnsDoNotHaveDataSet(){} // RVA: 0x7139960
        public void InValidNestedRelation(){} // RVA: 0x71399A0
        public void InvalidParentNamespaceinNestedRelation(){} // RVA: 0x71399F0
        public void RowNotInTheDataSet(){} // RVA: 0x7139A40
        public void RowNotInTheTable(){} // RVA: 0x7139A80
        public void EditInRowChanging(){} // RVA: 0x7139AC0
        public void EndEditInRowChanging(){} // RVA: 0x7139B00
        public void BeginEditInRowChanging(){} // RVA: 0x7139B40
        public void CancelEditInRowChanging(){} // RVA: 0x7139B80
        public void DeleteInRowDeleting(){} // RVA: 0x7139BC0
        public void ValueArrayLength(){} // RVA: 0x7139C00
        public void NoCurrentData(){} // RVA: 0x7139C40
        public void NoOriginalData(){} // RVA: 0x7139C80
        public void NoProposedData(){} // RVA: 0x7139CC0
        public void RowRemovedFromTheTable(){} // RVA: 0x7139D00
        public void DeletedRowInaccessible(){} // RVA: 0x7139D40
        public void RowAlreadyDeleted(){} // RVA: 0x7139D80
        public void RowEmpty(){} // RVA: 0x7139DC0
        public void InvalidRowVersion(){} // RVA: 0x7139E00
        public void RowOutOfRange(){} // RVA: 0x7139E40
        public void RowInsertTwice(){} // RVA: 0x7139F10
        public void RowInsertMissing(){} // RVA: 0x7139FE0
        public void RowAlreadyRemoved(){} // RVA: 0x713A030
        public void MultipleParents(){} // RVA: 0x713A070
        public void InvalidRowState(){} // RVA: 0x713A0B0
        public void InvalidRowBitPattern(){} // RVA: 0x713A0F0
        public void SetDataSetNameToEmpty(){} // RVA: 0x713A130
        public void SetDataSetNameConflicting(){} // RVA: 0x713A170
        public void DataSetUnsupportedSchema(){} // RVA: 0x713A1C0
        public void MergeMissingDefinition(){} // RVA: 0x713A210
        public void TablesInDifferentSets(){} // RVA: 0x713A260
        public void RelationAlreadyExists(){} // RVA: 0x713A2A0
        public void RowAlreadyInOtherCollection(){} // RVA: 0x713A2E0
        public void RowAlreadyInTheCollection(){} // RVA: 0x713A320
        public void RecordStateRange(){} // RVA: 0x713A360
        public void IndexKeyLength(){} // RVA: 0x713A3A0
        public void RemovePrimaryKey(){} // RVA: 0x713A480
        public void RelationAlreadyInOtherDataSet(){} // RVA: 0x713A510
        public void RelationAlreadyInTheDataSet(){} // RVA: 0x713A550
        public void RelationNotInTheDataSet(){} // RVA: 0x713A590
        public void RelationOutOfRange(){} // RVA: 0x713A5E0
        public void DuplicateRelation(){} // RVA: 0x713A660
        public void RelationTableNull(){} // RVA: 0x713A6B0
        public void RelationDataSetNull(){} // RVA: 0x713A6F0
        public void RelationTableWasRemoved(){} // RVA: 0x713A730
        public void ParentTableMismatch(){} // RVA: 0x713A770
        public void ChildTableMismatch(){} // RVA: 0x713A7B0
        public void EnforceConstraint(){} // RVA: 0x713A7F0
        public void CaseLocaleMismatch(){} // RVA: 0x713A830
        public void CannotChangeCaseLocale(){} // RVA: 0x713A8B0
        public void InvalidRemotingFormat(){} // RVA: 0x713A900
        public void TableForeignPrimaryKey(){} // RVA: 0x713A940
        public void TableCannotAddToSimpleContent(){} // RVA: 0x713A980
        public void NoTableName(){} // RVA: 0x713A9C0
        public void MultipleTextOnlyColumns(){} // RVA: 0x713AA00
        public void InvalidSortString(){} // RVA: 0x713AA40
        public void DuplicateTableName(){} // RVA: 0x713AA90
        public void DuplicateTableName2(){} // RVA: 0x713AAE0
        public void SelfnestedDatasetConflictingName(){} // RVA: 0x713AB40
        public void DatasetConflictingName(){} // RVA: 0x713AB90
        public void TableAlreadyInOtherDataSet(){} // RVA: 0x713ABE0
        public void TableAlreadyInTheDataSet(){} // RVA: 0x713AC20
        public void TableOutOfRange(){} // RVA: 0x713AC60
        public void TableNotInTheDataSet(){} // RVA: 0x713AD30
        public void TableInRelation(){} // RVA: 0x713AD80
        public void TableInConstraint(){} // RVA: 0x713ADC0
        public void CanNotSerializeDataTableHierarchy(){} // RVA: 0x713AE50
        public void CanNotRemoteDataTable(){} // RVA: 0x713AE90
        public void CanNotSetRemotingFormat(){} // RVA: 0x713AED0
        public void CanNotSerializeDataTableWithEmptyName(){} // RVA: 0x713AF10
        public void TableNotFound(){} // RVA: 0x713AF50
        public void AggregateException(){} // RVA: 0x713AFA0
        public void InvalidStorageType(){} // RVA: 0x713B060
        public void RangeArgument(){} // RVA: 0x713B0E0
        public void NullRange(){} // RVA: 0x713B210
        public void NegativeMinimumCapacity(){} // RVA: 0x713B250
        public void ProblematicChars(){} // RVA: 0x713B290
        public void StorageSetFailed(){} // RVA: 0x713B440
        public void SimpleTypeNotSupported(){} // RVA: 0x713B480
        public void MissingAttribute(){} // RVA: 0x713B530
        public void InvalidAttributeValue(){} // RVA: 0x713B590
        public void AttributeValues(){} // RVA: 0x713B5F0
        public void ElementTypeNotFound(){} // RVA: 0x713B660
        public void RelationParentNameMissing(){} // RVA: 0x713B6B0
        public void RelationChildNameMissing(){} // RVA: 0x713B700
        public void RelationTableKeyMissing(){} // RVA: 0x713B750
        public void RelationChildKeyMissing(){} // RVA: 0x713B7A0
        public void UndefinedDatatype(){} // RVA: 0x713B7F0
        public void DatatypeNotDefined(){} // RVA: 0x713B840
        public void MismatchKeyLength(){} // RVA: 0x713B880
        public void InvalidField(){} // RVA: 0x713B8C0
        public void InvalidSelector(){} // RVA: 0x713B910
        public void CircularComplexType(){} // RVA: 0x713B960
        public void CannotInstantiateAbstract(){} // RVA: 0x713B9B0
        public void InvalidKey(){} // RVA: 0x713BA00
        public void DiffgramMissingTable(){} // RVA: 0x713BA50
        public void DiffgramMissingSQL(){} // RVA: 0x713BAA0
        public void DuplicateConstraintRead(){} // RVA: 0x713BAE0
        public void ColumnTypeConflict(){} // RVA: 0x713BB30
        public void CannotConvert(){} // RVA: 0x713BB80
        public void MissingRefer(){} // RVA: 0x713BBE0
        public void InvalidPrefix(){} // RVA: 0x713BC70
        public void CanNotDeserializeObjectType(){} // RVA: 0x713BCC0
        public void IsDataSetAttributeMissingInSchema(){} // RVA: 0x713BD00
        public void TooManyIsDataSetAtributeInSchema(){} // RVA: 0x713BD40
        public void NestedCircular(){} // RVA: 0x713BD80
        public void MultipleParentRows(){} // RVA: 0x713BDD0
        public void PolymorphismNotSupported(){} // RVA: 0x713BE20
        public void DataTableInferenceNotSupported(){} // RVA: 0x713BE70
        public void ThrowMultipleTargetConverter(){} // RVA: 0x713BEB0
        public void DuplicateDeclaration(){} // RVA: 0x713BF00
        public void FoundEntity(){} // RVA: 0x713BF50
        public void MergeFailed(){} // RVA: 0x713BF90
        public void ConvertFailed(){} // RVA: 0x713BFA0
        public void InvalidDuplicateNamedSimpleTypeDelaration(){} // RVA: 0x713C040
        public void InternalRBTreeError(){} // RVA: 0x713C0A0
        public void EnumeratorModified(){} // RVA: 0x713C100
    }

    public class ExprException : Object
    {
        // ── Methods ──
        public void _Overflow(){} // RVA: 0x7189350
        public void _Expr(){} // RVA: 0x71893C0
        public void _Syntax(){} // RVA: 0x7189430
        public void _Eval(){} // RVA: 0x7189510
        public void InvokeArgument(){} // RVA: 0x7189580
        public void NYI(){} // RVA: 0x71895C0
        public void MissingOperand(){} // RVA: 0x7189660
        public void MissingOperator(){} // RVA: 0x71896F0
        public void TypeMismatch(){} // RVA: 0x7189740
        public void FunctionArgumentOutOfRange(){} // RVA: 0x7189790
        public void ExpressionTooComplex(){} // RVA: 0x71897F0
        public void UnboundName(){} // RVA: 0x7189830
        public void InvalidString(){} // RVA: 0x7189880
        public void UndefinedFunction(){} // RVA: 0x71898D0
        public void SyntaxError(){} // RVA: 0x7189920
        public void FunctionArgumentCount(){} // RVA: 0x7189960
        public void MissingRightParen(){} // RVA: 0x71899B0
        public void UnknownToken(){} // RVA: 0x7189AC0
        public void DatatypeConvertion(){} // RVA: 0x7189C10
        public void DatavalueConvertion(){} // RVA: 0x7189CB0
        public void InvalidName(){} // RVA: 0x7189DA0
        public void InvalidDate(){} // RVA: 0x7189DF0
        public void NonConstantArgument(){} // RVA: 0x7189E40
        public void InvalidPattern(){} // RVA: 0x7189E80
        public void InWithoutParentheses(){} // RVA: 0x7189ED0
        public void InWithoutList(){} // RVA: 0x7189F10
        public void InvalidIsSyntax(){} // RVA: 0x7189F50
        public void Overflow(){} // RVA: 0x7189F90
        public void ArgumentType(){} // RVA: 0x718A060
        public void ArgumentTypeInteger(){} // RVA: 0x718A180
        public void TypeMismatchInBinop(){} // RVA: 0x718A250
        public void AmbiguousBinop(){} // RVA: 0x718A340
        public void UnsupportedOperator(){} // RVA: 0x718A430
        public void InvalidNameBracketing(){} // RVA: 0x718A4B0
        public void MissingOperandBefore(){} // RVA: 0x718A500
        public void TooManyRightParentheses(){} // RVA: 0x718A550
        public void UnresolvedRelation(){} // RVA: 0x718A590
        public void BindFailure(){} // RVA: 0x718A5F0
        public void AggregateArgument(){} // RVA: 0x718A640
        public void AggregateUnbound(){} // RVA: 0x718A680
        public void EvalNoContext(){} // RVA: 0x718A6D0
        public void ExpressionUnbound(){} // RVA: 0x718A710
        public void ComputeNotAggregate(){} // RVA: 0x718A760
        public void FilterConvertion(){} // RVA: 0x718A7B0
        public void LookupArgument(){} // RVA: 0x718A800
        public void InvalidType(){} // RVA: 0x718A840
        public void InvalidHoursArgument(){} // RVA: 0x718A890
        public void InvalidMinutesArgument(){} // RVA: 0x718A8D0
        public void InvalidTimeZoneRange(){} // RVA: 0x718A910
        public void MismatchKindandTimeSpan(){} // RVA: 0x718A950
        public void UnsupportedDataType(){} // RVA: 0x718A990
    }

    public class ExpressionNode : Object
    {
        public object _table;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_FormatProvider(){} // RVA: 0x7185310
        public void get_IsSqlColumn(){} // RVA: 0xB43320
        public void get_table(){} // RVA: 0xB5DBF0
        public void BindTable(){} // RVA: 0xB44D60
        public void Bind(){} // RVA: 0x8943B0
        public void Eval(){} // RVA: 0x87C540
        public void IsConstant(){} // RVA: 0x87D280
        public void IsTableConstant(){} // RVA: 0x87D280
        public void HasLocalAggregate(){} // RVA: 0x87D280
        public void HasRemoteAggregate(){} // RVA: 0x87D280
        public void Optimize(){} // RVA: 0x87C0A0
        public void DependsOn(){} // RVA: 0xB43320
        public void IsInteger(){} // RVA: 0x71853B0
        public void IsIntegerSql(){} // RVA: 0x71853D0
        public void IsSigned(){} // RVA: 0x71853F0
        public void IsSignedSql(){} // RVA: 0x7185410
        public void IsUnsigned(){} // RVA: 0x7185450
        public void IsUnsignedSql(){} // RVA: 0x7185470
        public void IsNumeric(){} // RVA: 0x7185490
        public void IsNumericSql(){} // RVA: 0x71854C0
        public void IsFloat(){} // RVA: 0x7185500
        public void IsFloatSql(){} // RVA: 0x7185520
    }

    public class ExpressionParser : Object
    {
        public object s_reservedwords;
        public object _escape;
        public object _decimalSeparator;
        public object _listSeparator;
        public object _exponentL;
        public object _exponentU;
        public object _text;
        public object _pos;
        public object _start;
        public object _token;
        public object _op;
        public object _ops;
        public object _topOperator;
        public object _topNode;
        public object _table;
        public object _nodeStack;
        public object _prevOperand;
        public object _expression;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7185540
        public void LoadExpression(){} // RVA: 0x71856D0
        public void StartScan(){} // RVA: 0x7185890
        public void Parse(){} // RVA: 0x7185920
        public void ParseAggregateArgument(){} // RVA: 0x7186D30
        public void NodePop(){} // RVA: 0x7187080
        public void NodePeek(){} // RVA: 0x71870C0
        public void NodePush(){} // RVA: 0x7187100
        public void BuildExpression(){} // RVA: 0x71871A0
        public void CheckToken(){} // RVA: 0x7187550
        public void Scan(){} // RVA: 0x71875A0
        public void ScanNumeric(){} // RVA: 0x7187CF0
        public void ScanName(){} // RVA: 0x7187FB0
        public void ScanDate(){} // RVA: 0x71880F0
        public void ScanBinaryConstant(){} // RVA: 0xB43310
        public void ScanReserved(){} // RVA: 0x7188210
        public void ScanString(){} // RVA: 0x71884D0
        public void ScanToken(){} // RVA: 0x71885B0
        public void ScanWhite(){} // RVA: 0x7188610
        public void IsWhiteSpace(){} // RVA: 0x7188660
        public void IsAlphaNumeric(){} // RVA: 0x7188670
        public void IsDigit(){} // RVA: 0x7188710
        public void IsAlpha(){} // RVA: 0x7188770
        public void .cctor(){} // RVA: 0x71887F0
    }

}