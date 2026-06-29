// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem
// Classes: 77
// Methods: 1621

namespace ThirdParty.Unity.UnityEngine.InputSystem
{
    public class IInputActionCollection
    {
        // ── Methods ──
        public void get_bindingMask(){} // RVA: 0xA94080
        public void set_bindingMask(){} // RVA: 0x894320
        public void get_devices(){} // RVA: 0xA94080
        public void set_devices(){} // RVA: 0x894320
        public void get_controlSchemes(){} // RVA: 0x87BEB0
        public void Contains(){} // RVA: 0x87D350
        public void Enable(){} // RVA: 0x894290
        public void Disable(){} // RVA: 0x894290
    }

    public class IInputActionCollection2
    {
        // ── Methods ──
        public void get_bindings(){} // RVA: 0x87C0A0
        public void FindAction(){} // RVA: 0x87D1A0
        public void FindBinding(){} // RVA: 0x881CA0
    }

    public class IInputInteraction
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x894320
        public void Reset(){} // RVA: 0x894290
    }

    public class IInputInteraction[] : Array
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

    public class InputAction : Object
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0xA94080
        public void get_name(){} // RVA: 0xB5DBF0
        public void get_type(){} // RVA: 0xE62D00
        public void get_id(){} // RVA: 0x77D96E0
        public void get_idDontGenerate(){} // RVA: 0x77D9730
        public void get_expectedControlType(){} // RVA: 0xB700F0
        public void set_expectedControlType(){} // RVA: 0xB70100
        public void get_processors(){} // RVA: 0xD33E60
        public void get_interactions(){} // RVA: 0xD05CA0
        public void get_actionMap(){} // RVA: 0x77D9830
        public void get_bindingMask(){} // RVA: 0x4D226E0
        public void set_bindingMask(){} // RVA: 0x77D9850
        public void get_bindings(){} // RVA: 0x77D9BB0
        public void get_controls(){} // RVA: 0x77D9CB0
        public void get_phase(){} // RVA: 0x77D9DE0
        public void get_inProgress(){} // RVA: 0x77D9E40
        public void get_enabled(){} // RVA: 0x77D9EA0
        public void add_started(){} // RVA: 0x77D9F00
        public void remove_started(){} // RVA: 0x77D9F60
        public void add_canceled(){} // RVA: 0x77D9FC0
        public void remove_canceled(){} // RVA: 0x77DA020
        public void add_performed(){} // RVA: 0x77DA080
        public void remove_performed(){} // RVA: 0x77DA0E0
        public void get_triggered(){} // RVA: 0x77DA140
        public void get_activeControl(){} // RVA: 0x77DA1E0
        public void get_activeValueType(){} // RVA: 0x77DA260
        public void get_wantsInitialStateCheck(){} // RVA: 0x77DA2E0
        public void set_wantsInitialStateCheck(){} // RVA: 0x77DA2F0
        public void .ctor(){} // RVA: 0x77DA400
        public void Dispose(){} // RVA: 0x77DAA00
        public void ToString(){} // RVA: 0x77DAA20
        public void Enable(){} // RVA: 0x77DAD60
        public void Disable(){} // RVA: 0x77DB0B0
        public void Clone(){} // RVA: 0x77DB3D0
        public void System.ICloneable.Clone(){} // RVA: 0x77DB690
        public void ReadValueAsObject(){} // RVA: 0x77DB6A0
        public void GetControlMagnitude(){} // RVA: 0x77DB730
        public void Reset(){} // RVA: 0x77DB790
        public void IsPressed(){} // RVA: 0x77DB830
        public void IsInProgress(){} // RVA: 0x77DB890
        public void ExpectedFrame(){} // RVA: 0x77DB900
        public void WasPressedThisFrame(){} // RVA: 0x77DB9B0
        public void WasPressedThisDynamicUpdate(){} // RVA: 0x77DBA50
        public void WasReleasedThisFrame(){} // RVA: 0x77DBAC0
        public void WasReleasedThisDynamicUpdate(){} // RVA: 0x77DBB60
        public void WasPerformedThisFrame(){} // RVA: 0x77DA140
        public void WasPerformedThisDynamicUpdate(){} // RVA: 0x77DBBD0
        public void WasCompletedThisFrame(){} // RVA: 0x77DBC40
        public void WasCompletedThisDynamicUpdate(){} // RVA: 0x77DBCE0
        public void GetTimeoutCompletionPercentage(){} // RVA: 0x77DBD50
        public void get_isSingletonAction(){} // RVA: 0x77DBEB0
        public void get_currentState(){} // RVA: 0x77DBED0
        public void MakeSureIdIsInPlace(){} // RVA: 0x77DBF60
        public void GenerateId(){} // RVA: 0x77DBF90
        public void GetOrCreateActionMap(){} // RVA: 0x77DC080
        public void CreateInternalActionMapForSingletonAction(){} // RVA: 0x77DC0C0
        public void RequestInitialStateCheckOnEnabledAction(){} // RVA: 0x77DC300
        public void ActiveControlIsValid(){} // RVA: 0x77DC3D0
        public void FindEffectiveBindingMask(){} // RVA: 0x77DC4D0
        public void BindingIndexOnActionToBindingIndexOnMap(){} // RVA: 0x77DC600
        public void BindingIndexOnMapToBindingIndexOnAction(){} // RVA: 0x77DC7A0
        public void .cctor(){} // RVA: 0x77DC950
    }

    public class InputActionAsset : ScriptableObject
    {
        // ── Methods ──
        public void get_enabled(){} // RVA: 0x77DD630
        public void get_actionMaps(){} // RVA: 0x77DD810
        public void get_controlSchemes(){} // RVA: 0x77DD8D0
        public void get_bindings(){} // RVA: 0x77DD990
        public void get_bindingMask(){} // RVA: 0x77DDA40
        public void set_bindingMask(){} // RVA: 0x77DDA80
        public void get_devices(){} // RVA: 0x77DDCA0
        public void set_devices(){} // RVA: 0x77DDCE0
        public void get_Item(){} // RVA: 0x77DDD60
        public void ToJson(){} // RVA: 0x77DDDF0
        public void LoadFromJson(){} // RVA: 0x77DE130
        public void FromJson(){} // RVA: 0x77DE2C0
        public void FindAction(){} // RVA: 0x77DF050
        public void FindBinding(){} // RVA: 0x77DEAA0
        public void FindActionMap(){} // RVA: 0x77DEF30
        public void FindControlSchemeIndex(){} // RVA: 0x77DF200
        public void FindControlScheme(){} // RVA: 0x77DF3B0
        public void IsUsableWithDevice(){} // RVA: 0x77DF530
        public void Enable(){} // RVA: 0x77DF6C0
        public void Disable(){} // RVA: 0x77DF8E0
        public void Contains(){} // RVA: 0x77DFAC0
        public void GetEnumerator(){} // RVA: 0x77DFC40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x77DFCE0
        public void MarkAsDirty(){} // RVA: 0xB43310
        public void IsEmpty(){} // RVA: 0x77DFCF0
        public void OnWantToChangeSetup(){} // RVA: 0x77DFD80
        public void OnSetupChanged(){} // RVA: 0x77DFDF0
        public void ReResolveIfNecessary(){} // RVA: 0x77DFEC0
        public void ResolveBindingsIfNecessary(){} // RVA: 0x77DFF00
        public void OnDestroy(){} // RVA: 0x77DFFA0
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class InputActionAsset[] : Array
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

    public class InputActionMap : Object
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0xB5DBF0
        public void get_asset(){} // RVA: 0xB700F0
        public void get_id(){} // RVA: 0x77E0960
        public void get_idDontGenerate(){} // RVA: 0x77E09B0
        public void get_enabled(){} // RVA: 0x71684C0
        public void get_actions(){} // RVA: 0x77E0AB0
        public void get_bindings(){} // RVA: 0x77E0B70
        public void UnityEngine.InputSystem.IInputActionCollection2.get_bindings(){} // RVA: 0x77E0C30
        public void get_controlSchemes(){} // RVA: 0x77E0C90
        public void get_bindingMask(){} // RVA: 0x77E0DA0
        public void set_bindingMask(){} // RVA: 0x77E0DE0
        public void get_devices(){} // RVA: 0x77E0FF0
        public void set_devices(){} // RVA: 0x77E10D0
        public void get_Item(){} // RVA: 0x77E1120
        public void add_actionTriggered(){} // RVA: 0x77E1230
        public void remove_actionTriggered(){} // RVA: 0x77E1290
        public void .ctor(){} // RVA: 0x77E1360
        public void Dispose(){} // RVA: 0x77E1420
        public void FindActionIndex(){} // RVA: 0x77E19F0
        public void SetUpActionLookupTable(){} // RVA: 0x77E1790
        public void ClearActionLookupTable(){} // RVA: 0x77E19A0
        public void FindAction(){} // RVA: 0x77E1C30
        public void IsUsableWithDevice(){} // RVA: 0x77E1D60
        public void Enable(){} // RVA: 0x77E1E60
        public void Disable(){} // RVA: 0x77E1ED0
        public void Clone(){} // RVA: 0x77E1F00
        public void System.ICloneable.Clone(){} // RVA: 0x77E24C0
        public void Contains(){} // RVA: 0x77E24D0
        public void ToString(){} // RVA: 0x77E2500
        public void GetEnumerator(){} // RVA: 0x77E2660
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x77E2660
        public void get_needToResolveBindings(){} // RVA: 0x77E2790
        public void set_needToResolveBindings(){} // RVA: 0x77E27A0
        public void get_bindingResolutionNeedsFullReResolve(){} // RVA: 0x77E27C0
        public void set_bindingResolutionNeedsFullReResolve(){} // RVA: 0x77E27D0
        public void get_controlsForEachActionInitialized(){} // RVA: 0x77E27F0
        public void set_controlsForEachActionInitialized(){} // RVA: 0x77E2800
        public void get_bindingsForEachActionInitialized(){} // RVA: 0x77E2820
        public void set_bindingsForEachActionInitialized(){} // RVA: 0x77E2830
        public void GetBindingsForSingleAction(){} // RVA: 0x77E2850
        public void GetControlsForSingleAction(){} // RVA: 0x77E2930
        public void SetUpPerActionControlAndBindingArrays(){} // RVA: 0x77E2A10
        public void OnWantToChangeSetup(){} // RVA: 0x77E3870
        public void OnSetupChanged(){} // RVA: 0x77E3BE0
        public void OnBindingModified(){} // RVA: 0x77E3F60
        public void ClearCachedActionData(){} // RVA: 0x77E3F90
        public void GenerateId(){} // RVA: 0x77E40B0
        public void LazyResolveBindings(){} // RVA: 0x77E41A0
        public void ResolveBindingsIfNecessary(){} // RVA: 0x77E42E0
        public void ResolveBindings(){} // RVA: 0x77E4320
        public void FindBinding(){} // RVA: 0x77E5610
        public void FindBindingRelativeToMap(){} // RVA: 0x77E5950
        public void FromJson(){} // RVA: 0x77E5A00
        public void ToJson(){} // RVA: 0x77E5C20
        public void OnBeforeSerialize(){} // RVA: 0xB43310
        public void OnAfterDeserialize(){} // RVA: 0x77E5DB0
        public void .cctor(){} // RVA: 0x77E5F90
    }

    public class InputActionMap[] : Array
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

    public class InputActionProperty : ValueType
    {
        // ── Methods ──
        public void get_action(){} // RVA: 0x929BE0
        public void get_reference(){} // RVA: 0x929BF0
        public void get_serializedAction(){} // RVA: 0x77ED0
        public void get_serializedReference(){} // RVA: 0x7E450
        public void .ctor(){} // RVA: 0x929C10
        public void Equals(){} // RVA: 0x929C80
        public void GetHashCode(){} // RVA: 0x929D60
        public void op_Equality(){} // RVA: 0x77FEA90
        public void op_Inequality(){} // RVA: 0x77FEAC0
    }

    public class InputActionRebindingExtensions : Object
    {
        // ── Methods ──
        public void GetParameterValue(){} // RVA: 0xA94080
        public void ApplyParameterOverride(){} // RVA: 0x77EACA0
        public void ExtractParameterOverride(){} // RVA: 0xA94080
        public void GetBindingIndex(){} // RVA: 0x77EBCE0
        public void GetBindingForControl(){} // RVA: 0x77EBE10
        public void GetBindingIndexForControl(){} // RVA: 0x77EC0F0
        public void GetBindingDisplayString(){} // RVA: 0x77EC9D0
        public void ApplyBindingOverride(){} // RVA: 0x77EDC20
        public void RemoveBindingOverride(){} // RVA: 0x77EE080
        public void RemoveAllBindingOverrides(){} // RVA: 0x77EE540
        public void ApplyBindingOverrides(){} // RVA: 0x77EE770
        public void RemoveBindingOverrides(){} // RVA: 0x77EEA40
        public void ApplyBindingOverridesOnMatchingControls(){} // RVA: 0x77EF190
        public void SaveBindingOverridesAsJson(){} // RVA: 0x77EF6E0
        public void AddBindingOverrideJsonTo(){} // RVA: 0x77EFBA0
        public void LoadBindingOverridesFromJson(){} // RVA: 0x77EFEE0
        public void LoadBindingOverridesFromJsonInternal(){} // RVA: 0x77F0020
        public void PerformInteractiveRebinding(){} // RVA: 0x77F0720
        public void DeferBindingResolution(){} // RVA: 0x77F0D40
    }

    public class InputActionReference : ScriptableObject
    {
        // ── Methods ──
        public void get_asset(){} // RVA: 0xB465B0
        public void get_action(){} // RVA: 0x77FEAF0
        public void Set(){} // RVA: 0x77FF050
        public void SetInternal(){} // RVA: 0x77FF3A0
        public void ToString(){} // RVA: 0x77FF780
        public void GetDisplayName(){} // RVA: 0x77FF9C0
        public void ToDisplayName(){} // RVA: 0x77FFA40
        public void op_Implicit(){} // RVA: 0x77FFAF0
        public void Create(){} // RVA: 0x77FFB00
        public void ResetCachedAction(){} // RVA: 0x77FFB80
        public void ToInputAction(){} // RVA: 0x77FFD30
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class InputActionSetupExtensions : Object
    {
        // ── Methods ──
        public void AddActionMap(){} // RVA: 0x77FFFA0
        public void RemoveActionMap(){} // RVA: 0x78005E0
        public void AddAction(){} // RVA: 0x7800770
        public void RemoveAction(){} // RVA: 0x78013D0
        public void AddBinding(){} // RVA: 0x78022D0
        public void AddCompositeBinding(){} // RVA: 0x7802420
        public void AddBindingInternal(){} // RVA: 0x78027D0
        public void ChangeBinding(){} // RVA: 0x7803480
        public void ChangeBindingWithId(){} // RVA: 0x7803010
        public void ChangeBindingWithGroup(){} // RVA: 0x78031A0
        public void ChangeBindingWithPath(){} // RVA: 0x7803310
        public void ChangeCompositeBinding(){} // RVA: 0x78037F0
        public void Rename(){} // RVA: 0x7803C00
        public void AddControlScheme(){} // RVA: 0x7804380
        public void RemoveControlScheme(){} // RVA: 0x7804680
        public void WithBindingGroup(){} // RVA: 0x78048F0
        public void WithDevice(){} // RVA: 0x7804A70
        public void WithRequiredDevice(){} // RVA: 0x7804C90
        public void WithOptionalDevice(){} // RVA: 0x7804DF0
        public void OrWithRequiredDevice(){} // RVA: 0x7804F50
        public void OrWithOptionalDevice(){} // RVA: 0x78050B0
    }

    public class InputActionState : Object
    {
        // ── Methods ──
        public void get_totalCompositeCount(){} // RVA: 0xE36310
        public void get_totalMapCount(){} // RVA: 0xBE5890
        public void get_totalActionCount(){} // RVA: 0x1D46130
        public void get_totalBindingCount(){} // RVA: 0x15443F0
        public void get_totalInteractionCount(){} // RVA: 0xE32C80
        public void get_totalControlCount(){} // RVA: 0x12BB630
        public void get_mapIndices(){} // RVA: 0xBAE3B0
        public void get_actionStates(){} // RVA: 0xBE2C60
        public void get_bindingStates(){} // RVA: 0xBBFF90
        public void get_interactionStates(){} // RVA: 0xC10050
        public void get_controlIndexToBindingIndex(){} // RVA: 0x106A050
        public void get_controlGroupingAndComplexity(){} // RVA: 0x12EB090
        public void get_controlMagnitudes(){} // RVA: 0xCD3320
        public void get_enabledControls(){} // RVA: 0xB813B0
        public void get_isProcessingControlStateChange(){} // RVA: 0x2646660
        public void Initialize(){} // RVA: 0x78085E0
        public void ComputeControlGroupingIfNecessary(){} // RVA: 0x7808700
        public void ClaimDataFrom(){} // RVA: 0x7808910
        public void Finalize(){} // RVA: 0x7808B60
        public void Dispose(){} // RVA: 0x7808BD0
        public void Destroy(){} // RVA: 0x7808BE0
        public void Clone(){} // RVA: 0x7808F70
        public void System.ICloneable.Clone(){} // RVA: 0x78092A0
        public void IsUsingDevice(){} // RVA: 0x78092B0
        public void CanUseDevice(){} // RVA: 0x7809450
        public void HasEnabledActions(){} // RVA: 0x7809770
        public void FinishBindingCompositeSetups(){} // RVA: 0x78097D0
        public void PrepareForBindingReResolution(){} // RVA: 0x7809910
        public void FinishBindingResolution(){} // RVA: 0x7809E60
        public void RestoreActionStatesAfterReResolvingBindings(){} // RVA: 0x780A060
        public void IsActiveControl(){} // RVA: 0x780A9E0
        public void FindControlIndexOnBinding(){} // RVA: 0x780AAA0
        public void ResetActionStatesDrivenBy(){} // RVA: 0x780AB30
        public void IsActionBoundToControlFromDevice(){} // RVA: 0x780ACB0
        public void ResetActionState(){} // RVA: 0x780ADD0
        public void FetchActionState(){} // RVA: 0x780B050
        public void FetchMapIndices(){} // RVA: 0x780B080
        public void EnableAllActions(){} // RVA: 0x780B0D0
        public void EnableControls(){} // RVA: 0x780BA70
        public void EnableSingleAction(){} // RVA: 0x780B2A0
        public void DisableAllActions(){} // RVA: 0x7811EC0
        public void DisableControls(){} // RVA: 0x780BC60
        public void DisableSingleAction(){} // RVA: 0x780B7D0
        public void SetInitialStateCheckPending(){} // RVA: 0x780BF20
        public void IsControlEnabled(){} // RVA: 0x780BF60
        public void SetControlEnabled(){} // RVA: 0x780BFA0
        public void HookOnBeforeUpdate(){} // RVA: 0x780BFE0
        public void UnhookOnBeforeUpdate(){} // RVA: 0x780C160
        public void OnBeforeInitialUpdate(){} // RVA: 0x780C230
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x780C610
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x780C660
        public void ToCombinedMapAndControlAndBindingIndex(){} // RVA: 0x780C6B0
        public void SplitUpMapAndControlAndBindingIndex(){} // RVA: 0x780C6F0
        public void GetComplexityFromMonitorIndex(){} // RVA: 0x780C720
        public void ProcessControlStateChange(){} // RVA: 0x780C730
        public void ProcessButtonState(){} // RVA: 0x780CEF0
        public void ShouldIgnoreInputOnCompositeBinding(){} // RVA: 0x780D140
        public void IsConflictingInput(){} // RVA: 0x780D160
        public void GetActionBindingStartIndexAndCount(){} // RVA: 0x780D690
        public void ProcessDefaultInteraction(){} // RVA: 0x780D6C0
        public void ProcessInteractions(){} // RVA: 0x780DA50
        public void ProcessTimeout(){} // RVA: 0x780DD00
        public void SetTotalTimeoutCompletionTime(){} // RVA: 0x780E100
        public void StartTimeout(){} // RVA: 0x780E140
        public void StopTimeout(){} // RVA: 0x780E300
        public void ChangePhaseOfInteraction(){} // RVA: 0x780E400
        public void ChangePhaseOfAction(){} // RVA: 0x780E9B0
        public void ChangePhaseOfActionInternal(){} // RVA: 0x780EC40
        public void CallActionListeners(){} // RVA: 0x780EF80
        public void GetActionOrNoneString(){} // RVA: 0x780F2B0
        public void GetActionOrNull(){} // RVA: 0x780F3B0
        public void GetControl(){} // RVA: 0x780F450
        public void GetInteractionOrNull(){} // RVA: 0x780F4A0
        public void GetBindingIndexInMap(){} // RVA: 0x780F4E0
        public void GetBindingIndexInState(){} // RVA: 0x780F530
        public void GetBindingState(){} // RVA: 0x780F570
        public void GetBinding(){} // RVA: 0x780F580
        public void GetActionMap(){} // RVA: 0x780F610
        public void ResetInteractionStateAndCancelIfNecessary(){} // RVA: 0x780F650
        public void ResetInteractionState(){} // RVA: 0x780F730
        public void GetValueSizeInBytes(){} // RVA: 0x780F800
        public void GetValueType(){} // RVA: 0x780F8B0
        public void IsActuated(){} // RVA: 0x780F960
        public void ReadValue(){} // RVA: 0x30F8170
        public void ApplyProcessors(){} // RVA: 0x30F6690
        public void EvaluateCompositePartMagnitude(){} // RVA: 0x780FCB0
        public void GetCompositePartPressTime(){} // RVA: 0x780FDA0
        public void ReadCompositePartValue(){} // RVA: 0x30F6CF0
        public void ReadCompositePartValueAsObject(){} // RVA: 0x780FF80
        public void ReadValueAsObject(){} // RVA: 0x78100C0
        public void ReadValueAsButton(){} // RVA: 0x7810350
        public void SaveAndResetState(){} // RVA: 0x78104C0
        public void AddToGlobalList(){} // RVA: 0x7810A90
        public void RemoveMapFromGlobalList(){} // RVA: 0x7810B20
        public void CompactGlobalList(){} // RVA: 0x7810CE0
        public void NotifyListenersOfActionChange(){} // RVA: 0x7811130
        public void ResetGlobals(){} // RVA: 0x7811260
        public void FindAllEnabledActions(){} // RVA: 0x7811490
        public void OnDeviceChange(){} // RVA: 0x78117C0
        public void DeferredResolutionOfBindings(){} // RVA: 0x7811B90
        public void DestroyAllActionMapStates(){} // RVA: 0x7812070
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x78122D0
    }

    public class InputAction[] : Array
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

    public class InputBinding : ValueType
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x77900
        public void set_name(){} // RVA: 0x47F10
        public void get_id(){} // RVA: 0x92BE20
        public void set_id(){} // RVA: 0x92BE50
        public void get_path(){} // RVA: 0x7E450
        public void set_path(){} // RVA: 0x7E3E0
        public void get_overridePath(){} // RVA: 0xA3290
        public void set_overridePath(){} // RVA: 0x63E40
        public void get_interactions(){} // RVA: 0x931A0
        public void set_interactions(){} // RVA: 0x93120
        public void get_overrideInteractions(){} // RVA: 0xC26F0
        public void set_overrideInteractions(){} // RVA: 0xC2690
        public void get_processors(){} // RVA: 0x8C630
        public void set_processors(){} // RVA: 0x8C670
        public void get_overrideProcessors(){} // RVA: 0xA6BD0
        public void set_overrideProcessors(){} // RVA: 0xC2700
        public void get_groups(){} // RVA: 0x8C700
        public void set_groups(){} // RVA: 0x8C5A0
        public void get_action(){} // RVA: 0xA6BB0
        public void set_action(){} // RVA: 0xA6B00
        public void get_isComposite(){} // RVA: 0x92BEF0
        public void set_isComposite(){} // RVA: 0x92BF00
        public void get_isPartOfComposite(){} // RVA: 0x92BF20
        public void set_isPartOfComposite(){} // RVA: 0x92BF30
        public void get_hasOverrides(){} // RVA: 0x92BF50
        public void .ctor(){} // RVA: 0x92BF70
        public void GetNameOfComposite(){} // RVA: 0x92BF80
        public void GenerateId(){} // RVA: 0x92BF90
        public void RemoveOverrides(){} // RVA: 0x92BFA0
        public void MaskByGroup(){} // RVA: 0x7814120
        public void MaskByGroups(){} // RVA: 0x78141A0
        public void get_effectivePath(){} // RVA: 0x92BFB0
        public void get_effectiveInteractions(){} // RVA: 0x92BFC0
        public void get_effectiveProcessors(){} // RVA: 0x92BFD0
        public void get_isEmpty(){} // RVA: 0x92BFE0
        public void Equals(){} // RVA: 0x92C070
        public void op_Equality(){} // RVA: 0x78148C0
        public void op_Inequality(){} // RVA: 0x7814910
        public void GetHashCode(){} // RVA: 0x92C080
        public void ToString(){} // RVA: 0x92C090
        public void ToDisplayString(){} // RVA: 0x92C0E0
        public void TriggersAction(){} // RVA: 0x92C0F0
        public void Matches(){} // RVA: 0x92C160
    }

    public class InputBindingComposite : Object
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x87C0A0
        public void get_valueSizeInBytes(){} // RVA: 0x87C130
        public void ReadValue(){} // RVA: 0xA94080
        public void ReadValueAsObject(){} // RVA: 0x87C540
        public void EvaluateMagnitude(){} // RVA: 0x7815340
        public void FinishSetup(){} // RVA: 0xB43310
        public void CallFinishSetup(){} // RVA: 0x7659E80
        public void GetValueType(){} // RVA: 0x7815350
        public void GetExpectedControlLayoutName(){} // RVA: 0x78154A0
        public void GetPartNames(){} // RVA: 0x7815630
        public void GetDisplayFormatString(){} // RVA: 0x78156E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InputBindingCompositeContext : ValueType
    {
        // ── Methods ──
        public void get_controls(){} // RVA: 0x92FE00
        public void EvaluateMagnitude(){} // RVA: 0x92FE10
        public void ReadValue(){} // RVA: 0x1F8F10
        public void ReadValueAsButton(){} // RVA: 0x92FE20
        public void ReadValueAsObject(){} // RVA: 0x92FE40
        public void GetPressTime(){} // RVA: 0x92FE50
    }

    public class InputBindingComposite[] : Array
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

    public class InputBindingComposite`1 : InputBindingComposite
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x87C0A0
        public void get_valueSizeInBytes(){} // RVA: 0x87C130
        public void ReadValue(){} // RVA: 0xA94080
        public void ReadValueAsObject(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0x894290
    }

    public class InputBindingComposite`1 : InputBindingComposite
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x3DCE540
        public void get_valueSizeInBytes(){} // RVA: 0x17FCE50
        public void ReadValue(){} // RVA: 0x403C910
        public void ReadValueAsObject(){} // RVA: 0x403CA50
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InputBindingComposite`1 : InputBindingComposite
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x3DCE540
        public void get_valueSizeInBytes(){} // RVA: 0x1347420
        public void ReadValue(){} // RVA: 0x403C760
        public void ReadValueAsObject(){} // RVA: 0x403C8A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InputBindingComposite`1 : InputBindingComposite
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x3DCE540
        public void get_valueSizeInBytes(){} // RVA: 0x2AFB6E0
        public void ReadValue(){} // RVA: 0x403CAC0
        public void ReadValueAsObject(){} // RVA: 0x403CC20
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InputBindingResolver : ValueType
    {
        // ── Methods ──
        public void get_totalMapCount(){} // RVA: 0x77D20
        public void get_totalActionCount(){} // RVA: 0x13F8C0
        public void get_totalBindingCount(){} // RVA: 0xCFDC0
        public void get_totalControlCount(){} // RVA: 0xA3790
        public void Dispose(){} // RVA: 0x92FFE0
        public void StartWithPreviousResolve(){} // RVA: 0x92FFF0
        public void AddActionMap(){} // RVA: 0x930000
        public void InstantiateWithParameters(){} // RVA: 0x1F8F60
        public void InstantiateBindingComposite(){} // RVA: 0x783D810
        public void ApplyParameters(){} // RVA: 0x783DB80
        public void AssignCompositePartIndex(){} // RVA: 0x783E070
    }

    public class InputBinding[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB0F20
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7AA60
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC43E0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6C6A0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7AA60
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class InputControl : Object
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x67D9AE0
        public void get_displayName(){} // RVA: 0x7848F40
        public void set_displayName(){} // RVA: 0xD09D70
        public void get_shortDisplayName(){} // RVA: 0x7848FB0
        public void set_shortDisplayName(){} // RVA: 0xBBF900
        public void get_path(){} // RVA: 0x7849010
        public void get_layout(){} // RVA: 0x7849160
        public void get_variants(){} // RVA: 0x7849180
        public void get_device(){} // RVA: 0xCD3320
        public void get_parent(){} // RVA: 0xCD48B0
        public void get_children(){} // RVA: 0x78491A0
        public void get_usages(){} // RVA: 0x7849260
        public void get_aliases(){} // RVA: 0x7849320
        public void get_stateBlock(){} // RVA: 0x22343B0
        public void get_noisy(){} // RVA: 0x78493E0
        public void set_noisy(){} // RVA: 0x78493F0
        public void get_synthetic(){} // RVA: 0x78494F0
        public void set_synthetic(){} // RVA: 0x7849500
        public void get_Item(){} // RVA: 0x7849520
        public void get_valueType(){} // RVA: 0x87C0A0
        public void get_valueSizeInBytes(){} // RVA: 0x87C130
        public void get_magnitude(){} // RVA: 0x78495E0
        public void ToString(){} // RVA: 0x7849660
        public void DebuggerDisplay(){} // RVA: 0x78496E0
        public void EvaluateMagnitude(){} // RVA: 0x7815340
        public void ReadValueFromBufferAsObject(){} // RVA: 0xA94080
        public void ReadValueFromStateAsObject(){} // RVA: 0xA94080
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0xA94080
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7849830
        public void WriteValueFromObjectIntoState(){} // RVA: 0x78498A0
        public void CompareValue(){} // RVA: 0xA94080
        public void TryGetChildControl(){} // RVA: 0xA94080
        public void GetChildControl(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x4040410
        public void FinishSetup(){} // RVA: 0xB43310
        public void RefreshConfigurationIfNeeded(){} // RVA: 0x7849AD0
        public void RefreshConfiguration(){} // RVA: 0xB43310
        public void get_currentStatePtr(){} // RVA: 0x7849B10
        public void get_previousFrameStatePtr(){} // RVA: 0x7849B70
        public void get_defaultStatePtr(){} // RVA: 0x7849BD0
        public void get_noiseMaskPtr(){} // RVA: 0x7849C10
        public void get_stateOffsetRelativeToDeviceRoot(){} // RVA: 0x7849C50
        public void get_optimizedControlDataType(){} // RVA: 0x2540E90
        public void CalculateOptimizedControlDataType(){} // RVA: 0xDAC980
        public void ApplyParameterChanges(){} // RVA: 0x7849CC0
        public void SetOptimizedControlDataType(){} // RVA: 0x7849D90
        public void SetOptimizedControlDataTypeRecursively(){} // RVA: 0x7849E30
        public void EnsureOptimizationTypeHasNotChanged(){} // RVA: 0x784A020
        public void get_isSetupFinished(){} // RVA: 0x784A480
        public void set_isSetupFinished(){} // RVA: 0x784A490
        public void get_isButton(){} // RVA: 0x784A4B0
        public void set_isButton(){} // RVA: 0x784A4C0
        public void get_isConfigUpToDate(){} // RVA: 0x784A4E0
        public void set_isConfigUpToDate(){} // RVA: 0x784A4F0
        public void get_dontReset(){} // RVA: 0x784A510
        public void set_dontReset(){} // RVA: 0x784A520
        public void get_usesStateFromOtherControl(){} // RVA: 0x784A540
        public void set_usesStateFromOtherControl(){} // RVA: 0x784A550
        public void get_hasDefaultState(){} // RVA: 0x784A570
        public void CallFinishSetupRecursive(){} // RVA: 0x784A580
        public void MakeChildPath(){} // RVA: 0x784A660
        public void BakeOffsetIntoStateBlockRecursive(){} // RVA: 0x784A710
        public void GetDeviceIndex(){} // RVA: 0x784A800
        public void IsValueConsideredPressed(){} // RVA: 0x784A970
        public void AddProcessor(){} // RVA: 0xB43310
        public void MarkAsStale(){} // RVA: 0x784AA20
        public void MarkAsStaleRecursively(){} // RVA: 0x784AA30
    }

    public class InputControlExtensions : Object
    {
        // ── Methods ──
        public void FindInParentChain(){} // RVA: 0xA94080
        public void IsPressed(){} // RVA: 0x784AC50
        public void IsActuated(){} // RVA: 0x784ADA0
        public void ReadValueAsObject(){} // RVA: 0x784AE40
        public void ReadValueIntoBuffer(){} // RVA: 0x784AEC0
        public void ReadDefaultValueAsObject(){} // RVA: 0x784AFC0
        public void ReadValueFromEvent(){} // RVA: 0xA94080
        public void ReadValueFromEventAsObject(){} // RVA: 0x784B070
        public void ReadUnprocessedValueFromEvent(){} // RVA: 0xA94080
        public void WriteValueFromObjectIntoEvent(){} // RVA: 0x784B1A0
        public void WriteValueIntoState(){} // RVA: 0xA94080
        public void WriteValueIntoEvent(){} // RVA: 0xA94080
        public void CopyState(){} // RVA: 0x8945C0
        public void CheckStateIsAtDefault(){} // RVA: 0x784B770
        public void CheckStateIsAtDefaultIgnoringNoise(){} // RVA: 0x784B9E0
        public void CompareStateIgnoringNoise(){} // RVA: 0x784BB30
        public void CompareState(){} // RVA: 0x784BE00
        public void HasValueChangeInState(){} // RVA: 0x784BEF0
        public void HasValueChangeInEvent(){} // RVA: 0x784BFD0
        public void GetStatePtrFromStateEvent(){} // RVA: 0x784C0D0
        public void GetStatePtrFromStateEventUnchecked(){} // RVA: 0x784C190
        public void ResetToDefaultStateInEvent(){} // RVA: 0x784C480
        public void QueueValueChange(){} // RVA: 0xA94080
        public void AccumulateValueInEvent(){} // RVA: 0x784C810
        public void FindControlsRecursive(){} // RVA: 0x899D10
        public void BuildPath(){} // RVA: 0x784C930
        public void EnumerateControls(){} // RVA: 0x784CE20
        public void EnumerateChangedControls(){} // RVA: 0x784D0A0
        public void HasButtonPress(){} // RVA: 0x784D0F0
        public void GetFirstButtonPressOrNull(){} // RVA: 0x784D110
        public void GetAllButtonPresses(){} // RVA: 0x784D370
        public void Setup(){} // RVA: 0x784D520
    }

    public class InputControlList`1 : ValueType
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x87C130
        public void get_Capacity(){} // RVA: 0x87C130
        public void set_Capacity(){} // RVA: 0x8944F0
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894320
        public void Resize(){} // RVA: 0x8944F0
        public void Add(){} // RVA: 0xA94080
        public void AddSlice(){} // RVA: 0xA94080
        public void AddRange(){} // RVA: 0x89B9B0
        public void Remove(){} // RVA: 0xA94080
        public void RemoveAt(){} // RVA: 0x8944F0
        public void CopyTo(){} // RVA: 0x899290
        public void IndexOf(){} // RVA: 0xA94080
        public void Insert(){} // RVA: 0xA94080
        public void Clear(){} // RVA: 0x894290
        public void Contains(){} // RVA: 0xA94080
        public void SwapElements(){} // RVA: 0x8965E0
        public void Sort(){} // RVA: 0xA94080
        public void ToArray(){} // RVA: 0x881D20
        public void AppendTo(){} // RVA: 0x8943B0
        public void Dispose(){} // RVA: 0x894290
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void ToString(){} // RVA: 0x87C0A0
        public void ToIndex(){} // RVA: 0xA94080
        public void FromIndex(){} // RVA: 0xA94080
    }

    public class InputControlList`1 : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x32DE30
        public void .ctor(){} // RVA: 0x32DA10
        public void get_Count(){} // RVA: 0x77E60
        public void Add(){} // RVA: 0x32DB50
        public void get_Capacity(){} // RVA: 0x32D920
        public void set_Capacity(){} // RVA: 0x32D970
        public void get_IsReadOnly(){} // RVA: 0x20C460
        public void get_Item(){} // RVA: 0x32D980
        public void set_Item(){} // RVA: 0x32D990
        public void Resize(){} // RVA: 0x32DB40
        public void AddSlice(){} // RVA: 0xA94080
        public void AddRange(){} // RVA: 0x32DB60
        public void Remove(){} // RVA: 0x32DB70
        public void RemoveAt(){} // RVA: 0x32DC30
        public void CopyTo(){} // RVA: 0x32DC40
        public void IndexOf(){} // RVA: 0x32DCB0
        public void Insert(){} // RVA: 0x32DC40
        public void Clear(){} // RVA: 0x96220
        public void Contains(){} // RVA: 0x32DCD0
        public void SwapElements(){} // RVA: 0x32DD50
        public void Sort(){} // RVA: 0xA94080
        public void ToArray(){} // RVA: 0x32DD60
        public void AppendTo(){} // RVA: 0x32DD70
        public void GetEnumerator(){} // RVA: 0x32DE90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x32DEA0
        public void ToString(){} // RVA: 0x32DEE0
        public void ToIndex(){} // RVA: 0x403E990
        public void FromIndex(){} // RVA: 0x403EA80
    }

    public class InputControlList`1 : ValueType
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x77E60
        public void get_Capacity(){} // RVA: 0x32D920
        public void set_Capacity(){} // RVA: 0x32D970
        public void get_IsReadOnly(){} // RVA: 0x20C460
        public void get_Item(){} // RVA: 0x32D980
        public void set_Item(){} // RVA: 0x32D990
        public void .ctor(){} // RVA: 0x32DA10
        public void Resize(){} // RVA: 0x32DB40
        public void Add(){} // RVA: 0x32DB50
        public void AddSlice(){} // RVA: 0xA94080
        public void AddRange(){} // RVA: 0x32DB60
        public void Remove(){} // RVA: 0x32DB70
        public void RemoveAt(){} // RVA: 0x32DC30
        public void CopyTo(){} // RVA: 0x32DC40
        public void IndexOf(){} // RVA: 0x32DCB0
        public void Insert(){} // RVA: 0x32DC40
        public void Clear(){} // RVA: 0x96220
        public void Contains(){} // RVA: 0x32DCD0
        public void SwapElements(){} // RVA: 0x32DD50
        public void Sort(){} // RVA: 0xA94080
        public void ToArray(){} // RVA: 0x32DD60
        public void AppendTo(){} // RVA: 0x32DD70
        public void Dispose(){} // RVA: 0x32DE30
        public void GetEnumerator(){} // RVA: 0x32DE90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x32DEA0
        public void ToString(){} // RVA: 0x32DEE0
        public void ToIndex(){} // RVA: 0x403E990
        public void FromIndex(){} // RVA: 0x403EA80
    }

    public class InputControlPath : Object
    {
        // ── Methods ──
        public void CleanSlashes(){} // RVA: 0x784FA10
        public void Combine(){} // RVA: 0x784FA40
        public void ToHumanReadableString(){} // RVA: 0x784FB60
        public void TryGetDeviceUsages(){} // RVA: 0x78501E0
        public void TryGetDeviceLayout(){} // RVA: 0x7850420
        public void TryGetControlLayout(){} // RVA: 0x78505F0
        public void FindControlLayoutRecursive(){} // RVA: 0x7850AA0
        public void ControlLayoutMatchesPathComponent(){} // RVA: 0x7850D40
        public void StringMatches(){} // RVA: 0x7850F80
        public void TryFindControl(){} // RVA: 0xA94080
        public void TryFindControls(){} // RVA: 0x30FFA60
        public void TryFindChild(){} // RVA: 0xA94080
        public void Matches(){} // RVA: 0x7851760
        public void MatchControlComponent(){} // RVA: 0x7851910
        public void MatchesPrefix(){} // RVA: 0x7851D50
        public void MatchesRecursive(){} // RVA: 0x7851F10
        public void MatchControlsRecursive(){} // RVA: 0x30FF050
        public void MatchByUsageAtDeviceRootRecursive(){} // RVA: 0x30FEC00
        public void MatchChildrenRecursive(){} // RVA: 0x30FEF10
        public void MatchPathComponent(){} // RVA: 0x7851FA0
        public void PathComponentCanYieldMultipleMatches(){} // RVA: 0x7852350
        public void Parse(){} // RVA: 0x7852410
    }

    public class InputControlScheme : ValueType
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x77900
        public void get_bindingGroup(){} // RVA: 0x77ED0
        public void set_bindingGroup(){} // RVA: 0x77E70
        public void get_deviceRequirements(){} // RVA: 0x930450
        public void .ctor(){} // RVA: 0x930480
        public void SetNameAndBindingGroup(){} // RVA: 0x930490
        public void FindControlSchemeForDevices(){} // RVA: 0xA94080
        public void FindControlSchemeForDevice(){} // RVA: 0xA94080
        public void SupportsDevice(){} // RVA: 0x9304A0
        public void PickDevicesFrom(){} // RVA: 0xA94080
        public void Equals(){} // RVA: 0x9304E0
        public void GetHashCode(){} // RVA: 0x9304F0
        public void ToString(){} // RVA: 0x930500
        public void op_Equality(){} // RVA: 0x783F030
        public void op_Inequality(){} // RVA: 0x783F060
    }

    public class InputControlScheme[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB13F0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3EE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6CAA0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class InputControl[] : Array
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

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x87C0A0
        public void get_valueSizeInBytes(){} // RVA: 0x87C130
        public void get_value(){} // RVA: 0x87C0A0
        public void get_unprocessedValue(){} // RVA: 0x87C0A0
        public void ReadValue(){} // RVA: 0xA94080
        public void ReadValueFromPreviousFrame(){} // RVA: 0xA94080
        public void ReadDefaultValue(){} // RVA: 0xA94080
        public void ReadValueFromState(){} // RVA: 0xA94080
        public void ReadValueFromStateWithCaching(){} // RVA: 0xA94080
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0xA94080
        public void ReadUnprocessedValue(){} // RVA: 0xA94080
        public void ReadUnprocessedValueFromState(){} // RVA: 0xA94080
        public void ReadValueFromStateAsObject(){} // RVA: 0xA94080
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0xA94080
        public void WriteValueFromBufferIntoState(){} // RVA: 0xA94080
        public void WriteValueFromObjectIntoState(){} // RVA: 0xA94080
        public void WriteValueIntoState(){} // RVA: 0xA94080
        public void ReadValueFromBufferAsObject(){} // RVA: 0xA94080
        public void CompareValue(){} // RVA: 0xA94080
        public void ProcessValue(){} // RVA: 0x894320
        public void TryGetProcessor(){} // RVA: 0xA94080
        public void AddProcessor(){} // RVA: 0x894320
        public void FinishSetup(){} // RVA: 0x894290
        public void get_processors(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x894290
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x3DCE540
        public void get_valueSizeInBytes(){} // RVA: 0x1347420
        public void get_value(){} // RVA: 0x4048EE0
        public void get_unprocessedValue(){} // RVA: 0x4048FA0
        public void ReadValue(){} // RVA: 0x40490C0
        public void ReadValueFromPreviousFrame(){} // RVA: 0x40490E0
        public void ReadDefaultValue(){} // RVA: 0x40491F0
        public void ReadValueFromState(){} // RVA: 0x40492D0
        public void ReadValueFromStateWithCaching(){} // RVA: 0x4049360
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x4049490
        public void ReadUnprocessedValue(){} // RVA: 0x4049550
        public void ReadUnprocessedValueFromState(){} // RVA: 0xA94080
        public void ReadValueFromStateAsObject(){} // RVA: 0x4049570
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x4049640
        public void WriteValueFromBufferIntoState(){} // RVA: 0x40497E0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x4049970
        public void WriteValueIntoState(){} // RVA: 0x403FA00
        public void ReadValueFromBufferAsObject(){} // RVA: 0x4049B50
        public void CompareValue(){} // RVA: 0x4049CF0
        public void ProcessValue(){} // RVA: 0x4049EA0
        public void TryGetProcessor(){} // RVA: 0xA94080
        public void AddProcessor(){} // RVA: 0x403FFF0
        public void FinishSetup(){} // RVA: 0x4049F80
        public void get_processors(){} // RVA: 0x40403F0
        public void .ctor(){} // RVA: 0x4040410
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x3DCE540
        public void get_valueSizeInBytes(){} // RVA: 0x1347420
        public void get_value(){} // RVA: 0x40445B0
        public void get_unprocessedValue(){} // RVA: 0x4044670
        public void ReadValue(){} // RVA: 0x4044790
        public void ReadValueFromPreviousFrame(){} // RVA: 0x40447A0
        public void ReadDefaultValue(){} // RVA: 0x40448B0
        public void ReadValueFromState(){} // RVA: 0x4044990
        public void ReadValueFromStateWithCaching(){} // RVA: 0x4044A20
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x4044B40
        public void ReadUnprocessedValue(){} // RVA: 0x4044C00
        public void ReadUnprocessedValueFromState(){} // RVA: 0xA94080
        public void ReadValueFromStateAsObject(){} // RVA: 0x4044C10
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x4044CD0
        public void WriteValueFromBufferIntoState(){} // RVA: 0x4044E70
        public void WriteValueFromObjectIntoState(){} // RVA: 0x4044FF0
        public void WriteValueIntoState(){} // RVA: 0x403FA00
        public void ReadValueFromBufferAsObject(){} // RVA: 0x40451D0
        public void CompareValue(){} // RVA: 0x4045480
        public void ProcessValue(){} // RVA: 0x4045620
        public void TryGetProcessor(){} // RVA: 0xA94080
        public void AddProcessor(){} // RVA: 0x403FFF0
        public void FinishSetup(){} // RVA: 0x4045700
        public void get_processors(){} // RVA: 0x40403F0
        public void .ctor(){} // RVA: 0x4040410
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x3DCE540
        public void get_valueSizeInBytes(){} // RVA: 0x17FCE50
        public void get_value(){} // RVA: 0x40417E0
        public void get_unprocessedValue(){} // RVA: 0x40418A0
        public void ReadValue(){} // RVA: 0x40419C0
        public void ReadValueFromPreviousFrame(){} // RVA: 0x40419E0
        public void ReadDefaultValue(){} // RVA: 0x4041AF0
        public void ReadValueFromState(){} // RVA: 0x4041BD0
        public void ReadValueFromStateWithCaching(){} // RVA: 0x4041C60
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x4041D90
        public void ReadUnprocessedValue(){} // RVA: 0x4041E50
        public void ReadUnprocessedValueFromState(){} // RVA: 0xA94080
        public void ReadValueFromStateAsObject(){} // RVA: 0x4041E70
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x4041F40
        public void WriteValueFromBufferIntoState(){} // RVA: 0x40420E0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x4042270
        public void WriteValueIntoState(){} // RVA: 0x403FA00
        public void ReadValueFromBufferAsObject(){} // RVA: 0x4042450
        public void CompareValue(){} // RVA: 0x4042640
        public void ProcessValue(){} // RVA: 0x40427F0
        public void TryGetProcessor(){} // RVA: 0xA94080
        public void AddProcessor(){} // RVA: 0x403FFF0
        public void FinishSetup(){} // RVA: 0x40428D0
        public void get_processors(){} // RVA: 0x40403F0
        public void .ctor(){} // RVA: 0x4040410
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x3DCE540
        public void get_valueSizeInBytes(){} // RVA: 0x17FCE50
        public void get_value(){} // RVA: 0x404C240
        public void get_unprocessedValue(){} // RVA: 0x404C310
        public void ReadValue(){} // RVA: 0x404C450
        public void ReadValueFromPreviousFrame(){} // RVA: 0x404C470
        public void ReadDefaultValue(){} // RVA: 0x404C580
        public void ReadValueFromState(){} // RVA: 0x404C660
        public void ReadValueFromStateWithCaching(){} // RVA: 0x404C6F0
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x404C830
        public void ReadUnprocessedValue(){} // RVA: 0x404C900
        public void ReadUnprocessedValueFromState(){} // RVA: 0xA94080
        public void ReadValueFromStateAsObject(){} // RVA: 0x404C920
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x404C9E0
        public void WriteValueFromBufferIntoState(){} // RVA: 0x404CB80
        public void WriteValueFromObjectIntoState(){} // RVA: 0x404CD00
        public void WriteValueIntoState(){} // RVA: 0x403FA00
        public void ReadValueFromBufferAsObject(){} // RVA: 0x404CEF0
        public void CompareValue(){} // RVA: 0x404D090
        public void ProcessValue(){} // RVA: 0x404D240
        public void TryGetProcessor(){} // RVA: 0xA94080
        public void AddProcessor(){} // RVA: 0x403FFF0
        public void FinishSetup(){} // RVA: 0x404D320
        public void get_processors(){} // RVA: 0x40403F0
        public void .ctor(){} // RVA: 0x4040410
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x3DCE540
        public void get_valueSizeInBytes(){} // RVA: 0x2AFB6E0
        public void get_value(){} // RVA: 0x404D520
        public void get_unprocessedValue(){} // RVA: 0x404D5F0
        public void ReadValue(){} // RVA: 0x404D720
        public void ReadValueFromPreviousFrame(){} // RVA: 0x404D750
        public void ReadDefaultValue(){} // RVA: 0x404D8A0
        public void ReadValueFromState(){} // RVA: 0x404D9B0
        public void ReadValueFromStateWithCaching(){} // RVA: 0x404DA70
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x404DBD0
        public void ReadUnprocessedValue(){} // RVA: 0x404DCB0
        public void ReadUnprocessedValueFromState(){} // RVA: 0xA94080
        public void ReadValueFromStateAsObject(){} // RVA: 0x404DCE0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x404DDC0
        public void WriteValueFromBufferIntoState(){} // RVA: 0x404DF90
        public void WriteValueFromObjectIntoState(){} // RVA: 0x404E130
        public void WriteValueIntoState(){} // RVA: 0x403FA00
        public void ReadValueFromBufferAsObject(){} // RVA: 0x404E320
        public void CompareValue(){} // RVA: 0x404E520
        public void ProcessValue(){} // RVA: 0x404E740
        public void TryGetProcessor(){} // RVA: 0xA94080
        public void AddProcessor(){} // RVA: 0x403FFF0
        public void FinishSetup(){} // RVA: 0x404E880
        public void get_processors(){} // RVA: 0x40403F0
        public void .ctor(){} // RVA: 0x4040410
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x3DCE540
        public void get_valueSizeInBytes(){} // RVA: 0x2AFB680
        public void get_value(){} // RVA: 0x4047AC0
        public void get_unprocessedValue(){} // RVA: 0x4047B80
        public void ReadValue(){} // RVA: 0x4047CA0
        public void ReadValueFromPreviousFrame(){} // RVA: 0x4047CC0
        public void ReadDefaultValue(){} // RVA: 0x4047DF0
        public void ReadValueFromState(){} // RVA: 0x4047EF0
        public void ReadValueFromStateWithCaching(){} // RVA: 0x4047FA0
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x40480F0
        public void ReadUnprocessedValue(){} // RVA: 0x40481C0
        public void ReadUnprocessedValueFromState(){} // RVA: 0xA94080
        public void ReadValueFromStateAsObject(){} // RVA: 0x40481E0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x40482B0
        public void WriteValueFromBufferIntoState(){} // RVA: 0x4048460
        public void WriteValueFromObjectIntoState(){} // RVA: 0x40485F0
        public void WriteValueIntoState(){} // RVA: 0x403FA00
        public void ReadValueFromBufferAsObject(){} // RVA: 0x40487E0
        public void CompareValue(){} // RVA: 0x40489D0
        public void ProcessValue(){} // RVA: 0x4048BC0
        public void TryGetProcessor(){} // RVA: 0xA94080
        public void AddProcessor(){} // RVA: 0x403FFF0
        public void FinishSetup(){} // RVA: 0x4048CE0
        public void get_processors(){} // RVA: 0x40403F0
        public void .ctor(){} // RVA: 0x4040410
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x3DCE540
        public void get_valueSizeInBytes(){} // RVA: 0x2AFF440
        public void get_value(){} // RVA: 0x404A180
        public void get_unprocessedValue(){} // RVA: 0x404A280
        public void ReadValue(){} // RVA: 0x404A3D0
        public void ReadValueFromPreviousFrame(){} // RVA: 0x404A410
        public void ReadDefaultValue(){} // RVA: 0x404A590
        public void ReadValueFromState(){} // RVA: 0x404A6D0
        public void ReadValueFromStateWithCaching(){} // RVA: 0x404A7C0
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x404A970
        public void ReadUnprocessedValue(){} // RVA: 0x404AA60
        public void ReadUnprocessedValueFromState(){} // RVA: 0xA94080
        public void ReadValueFromStateAsObject(){} // RVA: 0x404AAA0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x404ABC0
        public void WriteValueFromBufferIntoState(){} // RVA: 0x404ADE0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x404AFD0
        public void WriteValueIntoState(){} // RVA: 0x403FA00
        public void ReadValueFromBufferAsObject(){} // RVA: 0x404B1E0
        public void CompareValue(){} // RVA: 0x404B430
        public void ProcessValue(){} // RVA: 0x404B6D0
        public void TryGetProcessor(){} // RVA: 0xA94080
        public void AddProcessor(){} // RVA: 0x403FFF0
        public void FinishSetup(){} // RVA: 0x404B880
        public void get_processors(){} // RVA: 0x40403F0
        public void .ctor(){} // RVA: 0x4040410
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x3DCE540
        public void get_valueSizeInBytes(){} // RVA: 0x1347420
        public void get_value(){} // RVA: 0x4045900
        public void get_unprocessedValue(){} // RVA: 0x40459C0
        public void ReadValue(){} // RVA: 0x4045AE0
        public void ReadValueFromPreviousFrame(){} // RVA: 0x40447A0
        public void ReadDefaultValue(){} // RVA: 0x40448B0
        public void ReadValueFromState(){} // RVA: 0x4044990
        public void ReadValueFromStateWithCaching(){} // RVA: 0x4045B00
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x4045C30
        public void ReadUnprocessedValue(){} // RVA: 0x4045CF0
        public void ReadUnprocessedValueFromState(){} // RVA: 0xA94080
        public void ReadValueFromStateAsObject(){} // RVA: 0x4044C10
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x4044CD0
        public void WriteValueFromBufferIntoState(){} // RVA: 0x4044E70
        public void WriteValueFromObjectIntoState(){} // RVA: 0x4045D00
        public void WriteValueIntoState(){} // RVA: 0x403FA00
        public void ReadValueFromBufferAsObject(){} // RVA: 0x40451D0
        public void CompareValue(){} // RVA: 0x4045480
        public void ProcessValue(){} // RVA: 0x4045620
        public void TryGetProcessor(){} // RVA: 0xA94080
        public void AddProcessor(){} // RVA: 0x403FFF0
        public void FinishSetup(){} // RVA: 0x4045EE0
        public void get_processors(){} // RVA: 0x40403F0
        public void .ctor(){} // RVA: 0x4040410
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x3DCE540
        public void get_valueSizeInBytes(){} // RVA: 0x2AFF560
        public void get_value(){} // RVA: 0x40460E0
        public void get_unprocessedValue(){} // RVA: 0x4046200
        public void ReadValue(){} // RVA: 0x4046360
        public void ReadValueFromPreviousFrame(){} // RVA: 0x40463A0
        public void ReadDefaultValue(){} // RVA: 0x4046530
        public void ReadValueFromState(){} // RVA: 0x4046680
        public void ReadValueFromStateWithCaching(){} // RVA: 0x4046780
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x4046940
        public void ReadUnprocessedValue(){} // RVA: 0x4046A30
        public void ReadUnprocessedValueFromState(){} // RVA: 0xA94080
        public void ReadValueFromStateAsObject(){} // RVA: 0x4046A70
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x4046BA0
        public void WriteValueFromBufferIntoState(){} // RVA: 0x4046DB0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x4046FB0
        public void WriteValueIntoState(){} // RVA: 0x403FA00
        public void ReadValueFromBufferAsObject(){} // RVA: 0x40471C0
        public void CompareValue(){} // RVA: 0x4047420
        public void ProcessValue(){} // RVA: 0x40476F0
        public void TryGetProcessor(){} // RVA: 0xA94080
        public void AddProcessor(){} // RVA: 0x403FFF0
        public void FinishSetup(){} // RVA: 0x40478C0
        public void get_processors(){} // RVA: 0x40403F0
        public void .ctor(){} // RVA: 0x4040410
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x3DCE540
        public void get_valueSizeInBytes(){} // RVA: 0x2AFBE90
        public void get_value(){} // RVA: 0x403EBE0
        public void get_unprocessedValue(){} // RVA: 0x403ECB0
        public void ReadValue(){} // RVA: 0x403EDE0
        public void ReadValueFromPreviousFrame(){} // RVA: 0x403EE10
        public void ReadDefaultValue(){} // RVA: 0x403EF60
        public void ReadValueFromState(){} // RVA: 0x403F070
        public void ReadValueFromStateWithCaching(){} // RVA: 0x403F130
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x403F290
        public void ReadUnprocessedValue(){} // RVA: 0x403F370
        public void ReadUnprocessedValueFromState(){} // RVA: 0xA94080
        public void ReadValueFromStateAsObject(){} // RVA: 0x403F3A0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x403F480
        public void WriteValueFromBufferIntoState(){} // RVA: 0x403F660
        public void WriteValueFromObjectIntoState(){} // RVA: 0x403F810
        public void WriteValueIntoState(){} // RVA: 0x403FA00
        public void ReadValueFromBufferAsObject(){} // RVA: 0x403FA70
        public void CompareValue(){} // RVA: 0x403FC80
        public void ProcessValue(){} // RVA: 0x403FEA0
        public void TryGetProcessor(){} // RVA: 0xA94080
        public void AddProcessor(){} // RVA: 0x403FFF0
        public void FinishSetup(){} // RVA: 0x40401F0
        public void get_processors(){} // RVA: 0x40403F0
        public void .ctor(){} // RVA: 0x4040410
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x3DCE540
        public void get_valueSizeInBytes(){} // RVA: 0x2AFF510
        public void get_value(){} // RVA: 0x4042AD0
        public void get_unprocessedValue(){} // RVA: 0x4042C00
        public void ReadValue(){} // RVA: 0x4042D70
        public void ReadValueFromPreviousFrame(){} // RVA: 0x4042DC0
        public void ReadDefaultValue(){} // RVA: 0x4042F60
        public void ReadValueFromState(){} // RVA: 0x40430C0
        public void ReadValueFromStateWithCaching(){} // RVA: 0x40431D0
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x40433B0
        public void ReadUnprocessedValue(){} // RVA: 0x40434B0
        public void ReadUnprocessedValueFromState(){} // RVA: 0xA94080
        public void ReadValueFromStateAsObject(){} // RVA: 0x4043500
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x4043650
        public void WriteValueFromBufferIntoState(){} // RVA: 0x4043880
        public void WriteValueFromObjectIntoState(){} // RVA: 0x4043A60
        public void WriteValueIntoState(){} // RVA: 0x403FA00
        public void ReadValueFromBufferAsObject(){} // RVA: 0x4043C80
        public void CompareValue(){} // RVA: 0x4043ED0
        public void ProcessValue(){} // RVA: 0x40441C0
        public void TryGetProcessor(){} // RVA: 0xA94080
        public void AddProcessor(){} // RVA: 0x403FFF0
        public void FinishSetup(){} // RVA: 0x40443B0
        public void get_processors(){} // RVA: 0x40403F0
        public void .ctor(){} // RVA: 0x4040410
    }

    public class InputDevice : InputControl
    {
        // ── Methods ──
        public void Build(){} // RVA: 0xA94080
        public void get_description(){} // RVA: 0x78560D0
        public void get_enabled(){} // RVA: 0x7856110
        public void get_canRunInBackground(){} // RVA: 0x7856130
        public void get_canDeviceRunInBackground(){} // RVA: 0x7856130
        public void get_added(){} // RVA: 0x7856200
        public void get_remote(){} // RVA: 0x7856210
        public void get_native(){} // RVA: 0x7856220
        public void get_updateBeforeRender(){} // RVA: 0x7856230
        public void get_deviceId(){} // RVA: 0x31178C0
        public void get_lastUpdateTime(){} // RVA: 0x7856240
        public void get_wasUpdatedThisFrame(){} // RVA: 0x7856290
        public void get_allControls(){} // RVA: 0x78562E0
        public void get_valueType(){} // RVA: 0x78563B0
        public void get_valueSizeInBytes(){} // RVA: 0x7856430
        public void get_all(){} // RVA: 0x78564C0
        public void .ctor(){} // RVA: 0x7856570
        public void ReadValueFromBufferAsObject(){} // RVA: 0x78565E0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7856620
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7856770
        public void CompareValue(){} // RVA: 0x7856960
        public void NotifyConfigurationChanged(){} // RVA: 0x7856AD0
        public void MakeCurrent(){} // RVA: 0xB43310
        public void OnAdded(){} // RVA: 0xB43310
        public void OnRemoved(){} // RVA: 0xB43310
        public void OnConfigurationChanged(){} // RVA: 0xB43310
        public void ExecuteCommand(){} // RVA: 0x3107230
        public void QueryEnabledStateFromRuntime(){} // RVA: 0x7856BE0
        public void get_disabledInFrontend(){} // RVA: 0x7856CA0
        public void set_disabledInFrontend(){} // RVA: 0x7856CB0
        public void get_disabledInRuntime(){} // RVA: 0x7856CD0
        public void set_disabledInRuntime(){} // RVA: 0x7856CE0
        public void get_disabledWhileInBackground(){} // RVA: 0x7856D10
        public void set_disabledWhileInBackground(){} // RVA: 0x7856D20
        public void EncodeStateOffsetToControlMapEntry(){} // RVA: 0x7856D50
        public void DecodeStateOffsetToControlMapEntry(){} // RVA: 0x7856D60
        public void get_hasControlsWithDefaultState(){} // RVA: 0x7856D80
        public void set_hasControlsWithDefaultState(){} // RVA: 0x7856D90
        public void get_hasDontResetControls(){} // RVA: 0x7856DB0
        public void set_hasDontResetControls(){} // RVA: 0x7856DC0
        public void get_hasStateCallbacks(){} // RVA: 0x7856DF0
        public void set_hasStateCallbacks(){} // RVA: 0x7856E00
        public void get_hasEventMerger(){} // RVA: 0x7856E20
        public void set_hasEventMerger(){} // RVA: 0x7856E30
        public void get_hasEventPreProcessor(){} // RVA: 0x7856E60
        public void set_hasEventPreProcessor(){} // RVA: 0x7856E70
        public void AddDeviceUsage(){} // RVA: 0x7856EA0
        public void RemoveDeviceUsage(){} // RVA: 0x7856F60
        public void ClearDeviceUsages(){} // RVA: 0x7857150
        public void RequestSync(){} // RVA: 0x78571C0
        public void RequestReset(){} // RVA: 0x7857250
        public void ExecuteEnableCommand(){} // RVA: 0x78572E0
        public void ExecuteDisableCommand(){} // RVA: 0x7857370
        public void NotifyAdded(){} // RVA: 0x13C3640
        public void NotifyRemoved(){} // RVA: 0x42E82B0
        public void WriteChangedControlStates(){} // RVA: 0x78573E0
        public void WritePartialChangedControlStatesInternal(){} // RVA: 0x7857560
        public void DumpControlBitRangeNode(){} // RVA: 0x78579C0
        public void DumpControlTree(){} // RVA: 0x7858030
        public void WriteChangedControlStatesInternal(){} // RVA: 0x7858110
        public void HasDataChangedInRange(){} // RVA: 0x78586F0
    }

    public class InputDevice[] : Array
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

    public class InputExtensions : Object
    {
        // ── Methods ──
        public void IsInProgress(){} // RVA: 0x69D09B0
        public void IsEndedOrCanceled(){} // RVA: 0x78BEA70
        public void IsActive(){} // RVA: 0x78BEA80
        public void IsModifierKey(){} // RVA: 0x78BEAA0
        public void IsTextInputKey(){} // RVA: 0x78BEAB0
    }

    public class InputInteraction : Object
    {
        // ── Methods ──
        public void GetValueType(){} // RVA: 0x77D9250
        public void GetDisplayName(){} // RVA: 0x77D9550
    }

    public class InputInteractionContext : ValueType
    {
        // ── Methods ──
        public void get_action(){} // RVA: 0x9319D0
        public void get_control(){} // RVA: 0x931A00
        public void get_phase(){} // RVA: 0xEE1B0
        public void get_time(){} // RVA: 0x931A50
        public void get_startTime(){} // RVA: 0x931A60
        public void get_timerHasExpired(){} // RVA: 0x931050
        public void set_timerHasExpired(){} // RVA: 0x931060
        public void get_isWaiting(){} // RVA: 0x931A70
        public void get_isStarted(){} // RVA: 0x931A80
        public void ComputeMagnitude(){} // RVA: 0x9B070
        public void ControlIsActuated(){} // RVA: 0x931A90
        public void Started(){} // RVA: 0x931AA0
        public void Performed(){} // RVA: 0x931AF0
        public void PerformedAndStayStarted(){} // RVA: 0x931B50
        public void PerformedAndStayPerformed(){} // RVA: 0x931BB0
        public void Canceled(){} // RVA: 0x931C00
        public void Waiting(){} // RVA: 0x931C50
        public void SetTimeout(){} // RVA: 0x931CA0
        public void SetTotalTimeoutCompletionTime(){} // RVA: 0x931CD0
        public void ReadValue(){} // RVA: 0xA94080
        public void get_mapIndex(){} // RVA: 0x931CE0
        public void get_controlIndex(){} // RVA: 0x931CF0
        public void get_bindingIndex(){} // RVA: 0x931D10
        public void get_interactionIndex(){} // RVA: 0x931D20
    }

    public class InputManager : Object
    {
        // ── Methods ──
        public void get_devices(){} // RVA: 0x78BEAD0
        public void get_processors(){} // RVA: 0xC0FFC0
        public void get_interactions(){} // RVA: 0xBE2C60
        public void get_composites(){} // RVA: 0xBBFF90
        public void get_metrics(){} // RVA: 0x78BEB80
        public void get_settings(){} // RVA: 0x163D1E0
        public void set_settings(){} // RVA: 0x78BEDE0
        public void get_actions(){} // RVA: 0x165E400
        public void set_actions(){} // RVA: 0x78BF000
        public void get_updateMask(){} // RVA: 0x158C700
        public void set_updateMask(){} // RVA: 0x78BF060
        public void get_defaultUpdateType(){} // RVA: 0x78BF080
        public void get_scrollDeltaBehavior(){} // RVA: 0x485FD30
        public void set_scrollDeltaBehavior(){} // RVA: 0x78BF0C0
        public void get_pollingFrequency(){} // RVA: 0xC76400
        public void set_pollingFrequency(){} // RVA: 0x78BF150
        public void add_onDeviceChange(){} // RVA: 0x78BF230
        public void remove_onDeviceChange(){} // RVA: 0x78BF290
        public void add_onDeviceStateChange(){} // RVA: 0x78BF2F0
        public void remove_onDeviceStateChange(){} // RVA: 0x78BF350
        public void add_onDeviceCommand(){} // RVA: 0x78BF3B0
        public void remove_onDeviceCommand(){} // RVA: 0x78BF410
        public void add_onFindControlLayoutForDevice(){} // RVA: 0x78BF470
        public void remove_onFindControlLayoutForDevice(){} // RVA: 0x78BF4D0
        public void add_onLayoutChange(){} // RVA: 0x78BF530
        public void remove_onLayoutChange(){} // RVA: 0x78BF590
        public void add_onEvent(){} // RVA: 0x78BF5F0
        public void remove_onEvent(){} // RVA: 0x78BF650
        public void add_onBeforeUpdate(){} // RVA: 0x78BF6B0
        public void remove_onBeforeUpdate(){} // RVA: 0x78BF710
        public void add_onAfterUpdate(){} // RVA: 0x78BF770
        public void remove_onAfterUpdate(){} // RVA: 0x78BF7D0
        public void add_onSettingsChange(){} // RVA: 0x78BF830
        public void remove_onSettingsChange(){} // RVA: 0x78BF890
        public void add_onActionsChange(){} // RVA: 0x78BF8F0
        public void remove_onActionsChange(){} // RVA: 0x78BF950
        public void get_isProcessingEvents(){} // RVA: 0x78BF9B0
        public void get_gameIsPlaying(){} // RVA: 0xC2E4C0
        public void get_gameHasFocus(){} // RVA: 0x78BF9C0
        public void get_gameShouldGetInputRegardlessOfFocus(){} // RVA: 0x78BFA00
        public void RegisterControlLayout(){} // RVA: 0x78C0290
        public void RegisterControlLayoutBuilder(){} // RVA: 0x78C0A40
        public void PerformLayoutPostRegistration(){} // RVA: 0x78C0D00
        public void RegisterPrecompiledLayout(){} // RVA: 0x3109580
        public void RecreateDevicesUsingLayout(){} // RVA: 0x78C1490
        public void IsControlOrChildUsingLayoutRecursive(){} // RVA: 0x78C16F0
        public void IsControlUsingLayout(){} // RVA: 0x78C17F0
        public void RegisterControlLayoutMatcher(){} // RVA: 0x78C1B10
        public void RecreateDevicesUsingLayoutWithInferiorMatch(){} // RVA: 0x78C1D10
        public void RecreateDevice(){} // RVA: 0x78C2060
        public void AddAvailableDevicesMatchingDescription(){} // RVA: 0x78C2240
        public void RemoveControlLayout(){} // RVA: 0x78C26D0
        public void TryLoadControlLayout(){} // RVA: 0x78C2D10
        public void TryFindMatchingControlLayout(){} // RVA: 0x78C2D40
        public void FindOrRegisterDeviceLayoutForType(){} // RVA: 0x78C32B0
        public void IsDeviceLayoutMarkedAsSupportedInSettings(){} // RVA: 0x78C3360
        public void ListControlLayouts(){} // RVA: 0x78C34A0
        public void GetControls(){} // RVA: 0x3109340
        public void SetDeviceUsage(){} // RVA: 0x78C35B0
        public void AddDeviceUsage(){} // RVA: 0x78C3880
        public void RemoveDeviceUsage(){} // RVA: 0x78C39E0
        public void NotifyUsageChanged(){} // RVA: 0x78C3B40
        public void AddDevice(){} // RVA: 0x78C4DF0
        public void RemoveDevice(){} // RVA: 0x78C4F40
        public void FlushDisconnectedDevices(){} // RVA: 0x78C5800
        public void ResetDevice(){} // RVA: 0x78C5860
        public void TryGetDevice(){} // RVA: 0x78C6210
        public void GetDevice(){} // RVA: 0x78C6170
        public void TryGetDeviceById(){} // RVA: 0x78C6270
        public void GetUnsupportedDevices(){} // RVA: 0x78C62F0
        public void EnableOrDisableDevice(){} // RVA: 0x78C64D0
        public void QueueEvent(){} // RVA: 0x894320
        public void Update(){} // RVA: 0x78C69F0
        public void Initialize(){} // RVA: 0x78C6A50
        public void Destroy(){} // RVA: 0x78C6C00
        public void InitializeActions(){} // RVA: 0x78C6E70
        public void InitializeData(){} // RVA: 0x78C6F60
        public void RegisterCustomTypes(){} // RVA: 0x78C9210
        public void InstallRuntime(){} // RVA: 0x78C94A0
        public void InstallGlobals(){} // RVA: 0x78C98C0
        public void UninstallGlobals(){} // RVA: 0x78C9D70
        public void get_optimizedControlsFeatureEnabled(){} // RVA: 0x78CA000
        public void set_optimizedControlsFeatureEnabled(){} // RVA: 0x78CA010
        public void get_readValueCachingFeatureEnabled(){} // RVA: 0x78CA020
        public void set_readValueCachingFeatureEnabled(){} // RVA: 0x78CA030
        public void get_paranoidReadValueCachingChecksEnabled(){} // RVA: 0x78CA040
        public void set_paranoidReadValueCachingChecksEnabled(){} // RVA: 0x78CA050
        public void MakeDeviceNameUnique(){} // RVA: 0x78CA060
        public void ResetControlPathsRecursive(){} // RVA: 0x78CA310
        public void AssignUniqueDeviceId(){} // RVA: 0x78CA450
        public void ReallocateStateBuffers(){} // RVA: 0x78CA5C0
        public void InitializeDefaultState(){} // RVA: 0x78CA8A0
        public void InitializeDeviceState(){} // RVA: 0x78CAA90
        public void OnNativeDeviceDiscovered(){} // RVA: 0x78CADB0
        public void MakeEscapedJsonString(){} // RVA: 0x78CB330
        public void TryMatchDisconnectedDevice(){} // RVA: 0x78CB680
        public void InstallBeforeUpdateHookIfNecessary(){} // RVA: 0x78CB9E0
        public void RestoreDevicesAfterDomainReloadIfNecessary(){} // RVA: 0xB43310
        public void WarnAboutDevicesFailingToRecreateAfterDomainReload(){} // RVA: 0xB43310
        public void OnBeforeUpdate(){} // RVA: 0x78CBAA0
        public void ApplySettings(){} // RVA: 0x78CBDD0
        public void ApplyActions(){} // RVA: 0x78CC7C0
        public void ExecuteGlobalCommand(){} // RVA: 0x87C540
        public void AddAvailableDevicesThatAreNowRecognized(){} // RVA: 0x78CC850
        public void ShouldRunDeviceInBackground(){} // RVA: 0x78CCB50
        public void OnFocusChanged(){} // RVA: 0x78CCB90
        public void ShouldRunUpdate(){} // RVA: 0x78CCDD0
        public void OnUpdate(){} // RVA: 0x78CCDF0
        public void AreMaximumEventBytesPerUpdateExceeded(){} // RVA: 0x78CE160
        public void MakeStringWithEventsProcessedByDevice(){} // RVA: 0x78CE2C0
        public void ResetCurrentProcessedEventBytesForDevices(){} // RVA: 0x78CE490
        public void CheckAllDevicesOptimizedControlsHaveValidState(){} // RVA: 0x78CE570
        public void InvokeAfterUpdateCallback(){} // RVA: 0x78CE770
        public void DontMakeCurrentlyUpdatingDeviceCurrent(){} // RVA: 0x78CE810
        public void UpdateState(){} // RVA: 0x78CE930
        public void WriteStateChange(){} // RVA: 0x78CF070
        public void FlipBuffersForDeviceIfNecessary(){} // RVA: 0x78CF420
        public void AddStateChangeMonitor(){} // RVA: 0x78CF4D0
        public void RemoveStateChangeMonitors(){} // RVA: 0x78CF680
        public void RemoveStateChangeMonitor(){} // RVA: 0x78CF880
        public void AddStateChangeMonitorTimeout(){} // RVA: 0x78CFAD0
        public void RemoveStateChangeMonitorTimeout(){} // RVA: 0x78CFC60
        public void SortStateChangeMonitorsIfNecessary(){} // RVA: 0x78CFDF0
        public void SignalStateChangeMonitor(){} // RVA: 0x78CFE40
        public void FireStateChangeNotifications(){} // RVA: 0x78D04B0
        public void ProcessStateChangeMonitors(){} // RVA: 0x78D0060
        public void ProcessStateChangeMonitorTimeouts(){} // RVA: 0x78D08B0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x78D0C00
        public void <TryFindMatchingControlLayout>b__94_0(){} // RVA: 0x78D0F70
    }

    public class InputProcessor : Object
    {
        // ── Methods ──
        public void ProcessAsObject(){} // RVA: 0x87C5F0
        public void Process(){} // RVA: 0xA94080
        public void GetValueTypeFromType(){} // RVA: 0x7855040
        public void get_cachingPolicy(){} // RVA: 0xDAC980
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InputProcessor[] : Array
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

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0xA94080
        public void ProcessAsObject(){} // RVA: 0x87C5F0
        public void .ctor(){} // RVA: 0x894290
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x4052B30
        public void ProcessAsObject(){} // RVA: 0x4052920
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x4051FA0
        public void ProcessAsObject(){} // RVA: 0x4051DA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x40517B0
        public void ProcessAsObject(){} // RVA: 0x40515A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x40532E0
        public void ProcessAsObject(){} // RVA: 0x40530D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x4053680
        public void ProcessAsObject(){} // RVA: 0x4053450
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x4052780
        public void ProcessAsObject(){} // RVA: 0x4052560
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x4052F00
        public void ProcessAsObject(){} // RVA: 0x4052CA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x4051FA0
        public void ProcessAsObject(){} // RVA: 0x4051DA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x87C6B0
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x87C6B0
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x87C6B0
    }

    public class InputProcessor`1[] : Array
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

    public class InputProcessor`1[] : Array
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

    public class InputProcessor`1[] : Array
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

    public class InputProcessor`1[] : Array
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

    public class InputProcessor`1[] : Array
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

    public class InputProcessor`1[] : Array
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

    public class InputRemoting : Object
    {
        // ── Methods ──
        public void get_sending(){} // RVA: 0x69AADC0
        public void set_sending(){} // RVA: 0x78B5330
        public void .ctor(){} // RVA: 0x78B5350
        public void StartSending(){} // RVA: 0x78B5410
        public void StopSending(){} // RVA: 0x78B5610
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(){} // RVA: 0x78B57F0
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(){} // RVA: 0xB43310
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted(){} // RVA: 0xB43310
        public void Subscribe(){} // RVA: 0x78B5A80
        public void SendInitialMessages(){} // RVA: 0x78B5C00
        public void SendAllGeneratedLayouts(){} // RVA: 0x78B5C20
        public void SendLayout(){} // RVA: 0x78B5E80
        public void SendAllDevices(){} // RVA: 0x78B5F20
        public void SendDevice(){} // RVA: 0x78B6170
        public void SendEvent(){} // RVA: 0x78B6200
        public void SendDeviceChange(){} // RVA: 0x78B6250
        public void SendLayoutChange(){} // RVA: 0x78B63E0
        public void Send(){} // RVA: 0x78B6540
        public void FindOrCreateSenderRecord(){} // RVA: 0x78B6680
        public void BuildLayoutNamespace(){} // RVA: 0x78B6740
        public void FindLocalDeviceId(){} // RVA: 0x78B6800
        public void TryGetDeviceByRemoteId(){} // RVA: 0x78B6880
        public void get_manager(){} // RVA: 0xB465B0
        public void RemoveRemoteDevices(){} // RVA: 0x78B68B0
        public void SerializeData(){} // RVA: 0xA94080
        public void DeserializeData(){} // RVA: 0xA94080
    }

    public class InputSettings : ScriptableObject
    {
        // ── Methods ──
        public void get_updateMode(){} // RVA: 0xFEAE90
        public void set_updateMode(){} // RVA: 0x78D3750
        public void get_scrollDeltaBehavior(){} // RVA: 0x15AF000
        public void set_scrollDeltaBehavior(){} // RVA: 0x78D3760
        public void get_compensateForScreenOrientation(){} // RVA: 0xB68DF0
        public void set_compensateForScreenOrientation(){} // RVA: 0x78D3770
        public void get_filterNoiseOnCurrent(){} // RVA: 0xB43320
        public void set_filterNoiseOnCurrent(){} // RVA: 0xB43310
        public void get_defaultDeadzoneMin(){} // RVA: 0xD344A0
        public void set_defaultDeadzoneMin(){} // RVA: 0x78D3780
        public void get_defaultDeadzoneMax(){} // RVA: 0xB4B880
        public void set_defaultDeadzoneMax(){} // RVA: 0x78D37A0
        public void get_defaultButtonPressPoint(){} // RVA: 0x1767220
        public void set_defaultButtonPressPoint(){} // RVA: 0x78D37C0
        public void get_buttonReleaseThreshold(){} // RVA: 0x15CB5C0
        public void set_buttonReleaseThreshold(){} // RVA: 0x78D3800
        public void get_defaultTapTime(){} // RVA: 0xBAB430
        public void set_defaultTapTime(){} // RVA: 0x78D3820
        public void get_defaultSlowTapTime(){} // RVA: 0x1122A70
        public void set_defaultSlowTapTime(){} // RVA: 0x78D3840
        public void get_defaultHoldTime(){} // RVA: 0xB6B160
        public void set_defaultHoldTime(){} // RVA: 0x78D3860
        public void get_tapRadius(){} // RVA: 0xB6B180
        public void set_tapRadius(){} // RVA: 0x78D3880
        public void get_multiTapDelayTime(){} // RVA: 0xC5C4A0
        public void set_multiTapDelayTime(){} // RVA: 0x78D38A0
        public void get_backgroundBehavior(){} // RVA: 0xE9CE60
        public void set_backgroundBehavior(){} // RVA: 0x78D38C0
        public void get_editorInputBehaviorInPlayMode(){} // RVA: 0x18A0130
        public void set_editorInputBehaviorInPlayMode(){} // RVA: 0x78D38D0
        public void get_inputActionPropertyDrawerMode(){} // RVA: 0x114DAD0
        public void set_inputActionPropertyDrawerMode(){} // RVA: 0x78D38E0
        public void get_maxEventBytesPerUpdate(){} // RVA: 0x1065D50
        public void set_maxEventBytesPerUpdate(){} // RVA: 0x78D38F0
        public void get_maxQueuedEventsPerUpdate(){} // RVA: 0x1AE5AC0
        public void set_maxQueuedEventsPerUpdate(){} // RVA: 0x78D3900
        public void get_supportedDevices(){} // RVA: 0x78D3910
        public void set_supportedDevices(){} // RVA: 0x78D39D0
        public void get_disableRedundantEventsMerging(){} // RVA: 0x1D450E0
        public void set_disableRedundantEventsMerging(){} // RVA: 0x78D3BA0
        public void get_shortcutKeysConsumeInput(){} // RVA: 0x1D3EFC0
        public void set_shortcutKeysConsumeInput(){} // RVA: 0x78D3BB0
        public void SetInternalFeatureFlag(){} // RVA: 0x78D3BC0
        public void IsFeatureEnabled(){} // RVA: 0x78D3D80
        public void OnChange(){} // RVA: 0x78D3E00
        public void CompareFloats(){} // RVA: 0x78D3F80
        public void CompareSets(){} // RVA: 0xA94080
        public void CompareFeatureFlag(){} // RVA: 0x78D3FA0
        public void AreEqual(){} // RVA: 0x78D4090
        public void .ctor(){} // RVA: 0x78D4800
    }

    public class InputSettings[] : Array
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

    public class InputSystem : Object
    {
        // ── Methods ──
        public void add_onLayoutChange(){} // RVA: 0x78409D0
        public void remove_onLayoutChange(){} // RVA: 0x7840B90
        public void RegisterLayout(){} // RVA: 0x310DE00
        public void RegisterLayoutOverride(){} // RVA: 0x7840FF0
        public void RegisterLayoutMatcher(){} // RVA: 0x310E010
        public void RegisterLayoutBuilder(){} // RVA: 0x7841100
        public void RegisterPrecompiledLayout(){} // RVA: 0x894350
        public void RemoveLayout(){} // RVA: 0x78412D0
        public void TryFindMatchingLayout(){} // RVA: 0x7841340
        public void ListLayouts(){} // RVA: 0x78413E0
        public void ListLayoutsBasedOn(){} // RVA: 0x7841450
        public void LoadLayout(){} // RVA: 0x87C0D0
        public void GetNameOfBaseLayout(){} // RVA: 0x7841620
        public void IsFirstLayoutBasedOnSecond(){} // RVA: 0x78417F0
        public void RegisterProcessor(){} // RVA: 0x894350
        public void TryGetProcessor(){} // RVA: 0x7841E50
        public void ListProcessors(){} // RVA: 0x7841F30
        public void get_devices(){} // RVA: 0x7841FB0
        public void get_disconnectedDevices(){} // RVA: 0x7842030
        public void add_onDeviceChange(){} // RVA: 0x7842120
        public void remove_onDeviceChange(){} // RVA: 0x7842340
        public void add_onDeviceCommand(){} // RVA: 0x7842560
        public void remove_onDeviceCommand(){} // RVA: 0x7842780
        public void add_onFindLayoutForDevice(){} // RVA: 0x78429A0
        public void remove_onFindLayoutForDevice(){} // RVA: 0x7842B70
        public void get_pollingFrequency(){} // RVA: 0x7842D30
        public void set_pollingFrequency(){} // RVA: 0x7842DA0
        public void AddDevice(){} // RVA: 0x7843130
        public void RemoveDevice(){} // RVA: 0x78431F0
        public void FlushDisconnectedDevices(){} // RVA: 0x7843270
        public void GetDevice(){} // RVA: 0xA94080
        public void GetDeviceById(){} // RVA: 0x7843680
        public void GetUnsupportedDevices(){} // RVA: 0x7843780
        public void EnableDevice(){} // RVA: 0x78439B0
        public void DisableDevice(){} // RVA: 0x7843A30
        public void TrySyncDevice(){} // RVA: 0x7843AC0
        public void ResetDevice(){} // RVA: 0x7843B90
        public void TryResetDevice(){} // RVA: 0x7843C20
        public void PauseHaptics(){} // RVA: 0x7843C90
        public void ResumeHaptics(){} // RVA: 0x7843DE0
        public void ResetHaptics(){} // RVA: 0x7843F30
        public void SetDeviceUsage(){} // RVA: 0x7844170
        public void AddDeviceUsage(){} // RVA: 0x78442C0
        public void RemoveDeviceUsage(){} // RVA: 0x7844410
        public void FindControl(){} // RVA: 0x78444A0
        public void FindControls(){} // RVA: 0x310C7A0
        public void get_isProcessingEvents(){} // RVA: 0x78447E0
        public void get_onEvent(){} // RVA: 0xB43320
        public void set_onEvent(){} // RVA: 0xB43310
        public void get_onAnyButtonPress(){} // RVA: 0x7844850
        public void QueueEvent(){} // RVA: 0x894350
        public void QueueStateEvent(){} // RVA: 0xA94080
        public void QueueDeltaStateEvent(){} // RVA: 0xA94080
        public void QueueConfigChangeEvent(){} // RVA: 0x7844F30
        public void QueueTextEvent(){} // RVA: 0x7845180
        public void Update(){} // RVA: 0x78454D0
        public void add_onBeforeUpdate(){} // RVA: 0x7845680
        public void remove_onBeforeUpdate(){} // RVA: 0x7845850
        public void add_onAfterUpdate(){} // RVA: 0x7845A10
        public void remove_onAfterUpdate(){} // RVA: 0x7845BD0
        public void get_settings(){} // RVA: 0x7845D90
        public void set_settings(){} // RVA: 0x7845E00
        public void add_onSettingsChange(){} // RVA: 0x7846040
        public void remove_onSettingsChange(){} // RVA: 0x78460F0
        public void EnableActions(){} // RVA: 0x78461A0
        public void DisableActions(){} // RVA: 0x78462C0
        public void get_actions(){} // RVA: 0x78463D0
        public void set_actions(){} // RVA: 0x7846440
        public void add_onActionsChange(){} // RVA: 0x78466A0
        public void remove_onActionsChange(){} // RVA: 0x7846750
        public void add_onActionChange(){} // RVA: 0x7846800
        public void remove_onActionChange(){} // RVA: 0x78468D0
        public void RegisterInteraction(){} // RVA: 0x894350
        public void TryGetInteraction(){} // RVA: 0x7846B10
        public void ListInteractions(){} // RVA: 0x7846BF0
        public void RegisterBindingComposite(){} // RVA: 0x894350
        public void TryGetBindingComposite(){} // RVA: 0x7846DE0
        public void DisableAllEnabledActions(){} // RVA: 0x7846EC0
        public void ListEnabledActions(){} // RVA: 0x7847030
        public void get_remoting(){} // RVA: 0x78470D0
        public void get_version(){} // RVA: 0x7847130
        public void get_runInBackground(){} // RVA: 0x7847260
        public void set_runInBackground(){} // RVA: 0x78472F0
        public void get_scrollWheelDeltaPerTick(){} // RVA: 0x7847390
        public void get_metrics(){} // RVA: 0x7847400
        public void .cctor(){} // RVA: 0x78474A0
        public void RunInitializeInPlayer(){} // RVA: 0x7847520
        public void EnsureInitialized(){} // RVA: 0xB43310
        public void InitializeInPlayer(){} // RVA: 0x78475A0
        public void RunInitialUpdate(){} // RVA: 0x7847AA0
        public void PerformDefaultPluginInitialization(){} // RVA: 0x7847AF0
    }

    public class InputValue : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0xA94080
        public void get_isPressed(){} // RVA: 0x78D9B10
        public void .ctor(){} // RVA: 0xB43310
    }

}