// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem
// Classes: 77
// Methods: 1621

namespace ThirdParty.Unity.UnityEngine.InputSystem
{
    public class IInputActionCollection
    {
        // ── Methods ──
        public void get_bindingMask(){} // RVA: 0x7A8051B10
        public void set_bindingMask(){} // RVA: 0x7A7E18800
        public void get_devices(){} // RVA: 0x7A8051B10
        public void set_devices(){} // RVA: 0x7A7E18800
        public void get_controlSchemes(){} // RVA: 0x7A7E00490
        public void Contains(){} // RVA: 0x7A7E019D0
        public void Enable(){} // RVA: 0x7A7E18770
        public void Disable(){} // RVA: 0x7A7E18770
    }

    public class IInputActionCollection2
    {
        // ── Methods ──
        public void get_bindings(){} // RVA: 0x7A7E00680
        public void FindAction(){} // RVA: 0x7A7E01780
        public void FindBinding(){} // RVA: 0x7A7E06320
    }

    public class IInputInteraction
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7A7E18800
        public void Reset(){} // RVA: 0x7A7E18770
    }

    public class IInputInteraction[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputAction : Object
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7A80F2570
        public void get_type(){} // RVA: 0x7A83782A0
        public void get_id(){} // RVA: 0x7AEB70260
        public void get_idDontGenerate(){} // RVA: 0x7AEB702B0
        public void get_expectedControlType(){} // RVA: 0x7A81052C0
        public void set_expectedControlType(){} // RVA: 0x7A81052D0
        public void get_processors(){} // RVA: 0x7A83F69F0
        public void get_interactions(){} // RVA: 0x7A8292C30
        public void get_actionMap(){} // RVA: 0x7AEB703B0
        public void get_bindingMask(){} // RVA: 0x7AC02B6A0
        public void set_bindingMask(){} // RVA: 0x7AEB703D0
        public void get_bindings(){} // RVA: 0x7AEB70730
        public void get_controls(){} // RVA: 0x7AEB70830
        public void get_phase(){} // RVA: 0x7AEB70960
        public void get_inProgress(){} // RVA: 0x7AEB709C0
        public void get_enabled(){} // RVA: 0x7AEB70A20
        public void add_started(){} // RVA: 0x7AEB70A80
        public void remove_started(){} // RVA: 0x7AEB70AE0
        public void add_canceled(){} // RVA: 0x7AEB70B40
        public void remove_canceled(){} // RVA: 0x7AEB70BA0
        public void add_performed(){} // RVA: 0x7AEB70C00
        public void remove_performed(){} // RVA: 0x7AEB70C60
        public void get_triggered(){} // RVA: 0x7AEB70CC0
        public void get_activeControl(){} // RVA: 0x7AEB70D60
        public void get_activeValueType(){} // RVA: 0x7AEB70DE0
        public void get_wantsInitialStateCheck(){} // RVA: 0x7AEB70E60
        public void set_wantsInitialStateCheck(){} // RVA: 0x7AEB70E70
        public void .ctor(){} // RVA: 0x7AEB70F80
        public void Dispose(){} // RVA: 0x7AEB71580
        public void ToString(){} // RVA: 0x7AEB715A0
        public void Enable(){} // RVA: 0x7AEB718E0
        public void Disable(){} // RVA: 0x7AEB71C30
        public void Clone(){} // RVA: 0x7AEB71F50
        public void System.ICloneable.Clone(){} // RVA: 0x7AEB72210
        public void ReadValue(){} // RVA: 0x7AA4C4A30
        public void ReadValueAsObject(){} // RVA: 0x7AEB72220
        public void GetControlMagnitude(){} // RVA: 0x7AEB722B0
        public void Reset(){} // RVA: 0x7AEB72310
        public void IsPressed(){} // RVA: 0x7AEB723B0
        public void IsInProgress(){} // RVA: 0x7AEB72410
        public void ExpectedFrame(){} // RVA: 0x7AEB72480
        public void WasPressedThisFrame(){} // RVA: 0x7AEB72530
        public void WasPressedThisDynamicUpdate(){} // RVA: 0x7AEB725D0
        public void WasReleasedThisFrame(){} // RVA: 0x7AEB72640
        public void WasReleasedThisDynamicUpdate(){} // RVA: 0x7AEB726E0
        public void WasPerformedThisFrame(){} // RVA: 0x7AEB70CC0
        public void WasPerformedThisDynamicUpdate(){} // RVA: 0x7AEB72750
        public void WasCompletedThisFrame(){} // RVA: 0x7AEB727C0
        public void WasCompletedThisDynamicUpdate(){} // RVA: 0x7AEB72860
        public void GetTimeoutCompletionPercentage(){} // RVA: 0x7AEB728D0
        public void get_isSingletonAction(){} // RVA: 0x7AEB72A30
        public void get_currentState(){} // RVA: 0x7AEB72A50
        public void MakeSureIdIsInPlace(){} // RVA: 0x7AEB72AE0
        public void GenerateId(){} // RVA: 0x7AEB72B10
        public void GetOrCreateActionMap(){} // RVA: 0x7AEB72C00
        public void CreateInternalActionMapForSingletonAction(){} // RVA: 0x7AEB72C40
        public void RequestInitialStateCheckOnEnabledAction(){} // RVA: 0x7AEB72E80
        public void ActiveControlIsValid(){} // RVA: 0x7AEB72F50
        public void FindEffectiveBindingMask(){} // RVA: 0x7AEB73050
        public void BindingIndexOnActionToBindingIndexOnMap(){} // RVA: 0x7AEB73180
        public void BindingIndexOnMapToBindingIndexOnAction(){} // RVA: 0x7AEB73330
        public void .cctor(){} // RVA: 0x7AEB734E0
    }

    public class InputActionAsset : ScriptableObject
    {
        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7AEB74250
        public void get_actionMaps(){} // RVA: 0x7AEB74430
        public void get_controlSchemes(){} // RVA: 0x7AEB744F0
        public void get_bindings(){} // RVA: 0x7AEB745B0
        public void get_bindingMask(){} // RVA: 0x7AEB74660
        public void set_bindingMask(){} // RVA: 0x7AEB746A0
        public void get_devices(){} // RVA: 0x7AEB748C0
        public void set_devices(){} // RVA: 0x7AEB74900
        public void get_Item(){} // RVA: 0x7AEB74980
        public void ToJson(){} // RVA: 0x7AEB74A10
        public void LoadFromJson(){} // RVA: 0x7AEB74D50
        public void FromJson(){} // RVA: 0x7AEB74F10
        public void FindAction(){} // RVA: 0x7AEB75B40
        public void FindBinding(){} // RVA: 0x7AEB75590
        public void FindActionMap(){} // RVA: 0x7AEB75A20
        public void FindControlSchemeIndex(){} // RVA: 0x7AEB75CF0
        public void FindControlScheme(){} // RVA: 0x7AEB75EA0
        public void IsUsableWithDevice(){} // RVA: 0x7AEB76020
        public void Enable(){} // RVA: 0x7AEB761B0
        public void Disable(){} // RVA: 0x7AEB763D0
        public void Contains(){} // RVA: 0x7AEB765B0
        public void GetEnumerator(){} // RVA: 0x7AEB76730
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AEB767D0
        public void MarkAsDirty(){} // RVA: 0x7A80D7310
        public void IsEmpty(){} // RVA: 0x7AEB767E0
        public void OnWantToChangeSetup(){} // RVA: 0x7AEB76870
        public void OnSetupChanged(){} // RVA: 0x7AEB768E0
        public void ReResolveIfNecessary(){} // RVA: 0x7AEB769B0
        public void ResolveBindingsIfNecessary(){} // RVA: 0x7AEB769F0
        public void OnDestroy(){} // RVA: 0x7AEB76A90
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class InputActionAsset[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputActionMap : Object
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7A80F2570
        public void get_asset(){} // RVA: 0x7A81052C0
        public void get_id(){} // RVA: 0x7AEB77450
        public void get_idDontGenerate(){} // RVA: 0x7AEB774A0
        public void get_enabled(){} // RVA: 0x7AE4EE270
        public void get_actions(){} // RVA: 0x7AEB775A0
        public void get_bindings(){} // RVA: 0x7AEB77660
        public void UnityEngine.InputSystem.IInputActionCollection2.get_bindings(){} // RVA: 0x7AEB77720
        public void get_controlSchemes(){} // RVA: 0x7AEB77780
        public void get_bindingMask(){} // RVA: 0x7AEB77890
        public void set_bindingMask(){} // RVA: 0x7AEB778D0
        public void get_devices(){} // RVA: 0x7AEB77AE0
        public void set_devices(){} // RVA: 0x7AEB77BC0
        public void get_Item(){} // RVA: 0x7AEB77C10
        public void add_actionTriggered(){} // RVA: 0x7AEB77D20
        public void remove_actionTriggered(){} // RVA: 0x7AEB77D80
        public void .ctor(){} // RVA: 0x7AEB77E50
        public void Dispose(){} // RVA: 0x7AEB77F10
        public void FindActionIndex(){} // RVA: 0x7AEB784E0
        public void SetUpActionLookupTable(){} // RVA: 0x7AEB78280
        public void ClearActionLookupTable(){} // RVA: 0x7AEB78490
        public void FindAction(){} // RVA: 0x7AEB78720
        public void IsUsableWithDevice(){} // RVA: 0x7AEB78850
        public void Enable(){} // RVA: 0x7AEB78950
        public void Disable(){} // RVA: 0x7AEB789C0
        public void Clone(){} // RVA: 0x7AEB789F0
        public void System.ICloneable.Clone(){} // RVA: 0x7AEB78FB0
        public void Contains(){} // RVA: 0x7AEB78FC0
        public void ToString(){} // RVA: 0x7AEB78FF0
        public void GetEnumerator(){} // RVA: 0x7AEB79150
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AEB79150
        public void get_needToResolveBindings(){} // RVA: 0x7AEB79280
        public void set_needToResolveBindings(){} // RVA: 0x7AEB79290
        public void get_bindingResolutionNeedsFullReResolve(){} // RVA: 0x7AEB792B0
        public void set_bindingResolutionNeedsFullReResolve(){} // RVA: 0x7AEB792C0
        public void get_controlsForEachActionInitialized(){} // RVA: 0x7AEB792E0
        public void set_controlsForEachActionInitialized(){} // RVA: 0x7AEB792F0
        public void get_bindingsForEachActionInitialized(){} // RVA: 0x7AEB79310
        public void set_bindingsForEachActionInitialized(){} // RVA: 0x7AEB79320
        public void GetBindingsForSingleAction(){} // RVA: 0x7AEB79340
        public void GetControlsForSingleAction(){} // RVA: 0x7AEB79420
        public void SetUpPerActionControlAndBindingArrays(){} // RVA: 0x7AEB79500
        public void OnWantToChangeSetup(){} // RVA: 0x7AEB7A360
        public void OnSetupChanged(){} // RVA: 0x7AEB7A6D0
        public void OnBindingModified(){} // RVA: 0x7AEB7AA50
        public void ClearCachedActionData(){} // RVA: 0x7AEB7AA80
        public void GenerateId(){} // RVA: 0x7AEB7ABA0
        public void LazyResolveBindings(){} // RVA: 0x7AEB7AC90
        public void ResolveBindingsIfNecessary(){} // RVA: 0x7AEB7ADD0
        public void ResolveBindings(){} // RVA: 0x7AEB7AE10
        public void FindBinding(){} // RVA: 0x7AEB7C100
        public void FindBindingRelativeToMap(){} // RVA: 0x7AEB7C440
        public void FromJson(){} // RVA: 0x7AEB7C4F0
        public void ToJson(){} // RVA: 0x7AEB7C750
        public void OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void OnAfterDeserialize(){} // RVA: 0x7AEB7C8E0
        public void .cctor(){} // RVA: 0x7AEB7CAC0
    }

    public class InputActionMap[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputActionProperty : ValueType
    {
        // ── Methods ──
        public void get_action(){} // RVA: 0x7A7EA9580
        public void get_reference(){} // RVA: 0x7A7EA9590
        public void get_serializedAction(){} // RVA: 0x7A765F080
        public void get_serializedReference(){} // RVA: 0x7A7664CF0
        public void .ctor(){} // RVA: 0x7A7EA95B0
        public void Equals(){} // RVA: 0x7A7EA9620
        public void GetHashCode(){} // RVA: 0x7A7EA9700
        public void op_Equality(){} // RVA: 0x7AEB8EC80
        public void op_Inequality(){} // RVA: 0x7AEB8ECB0
    }

    public class InputActionRebindingExtensions : Object
    {
        // ── Methods ──
        public void GetParameterValue(){} // RVA: 0x7A8051B10
        public void ApplyParameterOverride(){} // RVA: 0x7AEB81820
        public void ExtractParameterOverride(){} // RVA: 0x7A8051B10
        public void GetBindingIndex(){} // RVA: 0x7AEB828A0
        public void GetBindingForControl(){} // RVA: 0x7AEB829D0
        public void GetBindingIndexForControl(){} // RVA: 0x7AEB82CB0
        public void GetBindingDisplayString(){} // RVA: 0x7AEB835B0
        public void ApplyBindingOverride(){} // RVA: 0x7AEB84820
        public void RemoveBindingOverride(){} // RVA: 0x7AEB84C90
        public void RemoveAllBindingOverrides(){} // RVA: 0x7AEB85150
        public void ApplyBindingOverrides(){} // RVA: 0x7AEB85380
        public void RemoveBindingOverrides(){} // RVA: 0x7AEB85650
        public void ApplyBindingOverridesOnMatchingControls(){} // RVA: 0x7AEB85DA0
        public void SaveBindingOverridesAsJson(){} // RVA: 0x7AEB86300
        public void AddBindingOverrideJsonTo(){} // RVA: 0x7AEB867D0
        public void LoadBindingOverridesFromJson(){} // RVA: 0x7AEB86B10
        public void LoadBindingOverridesFromJsonInternal(){} // RVA: 0x7AEB86C50
        public void PerformInteractiveRebinding(){} // RVA: 0x7AEB87380
        public void DeferBindingResolution(){} // RVA: 0x7AEB879E0
    }

    public class InputActionReference : ScriptableObject
    {
        // ── Methods ──
        public void get_asset(){} // RVA: 0x7A80DA7B0
        public void get_action(){} // RVA: 0x7AEB8ECE0
        public void Set(){} // RVA: 0x7AEB8F240
        public void SetInternal(){} // RVA: 0x7AEB8F590
        public void ToString(){} // RVA: 0x7AEB8F970
        public void GetDisplayName(){} // RVA: 0x7AEB8FBB0
        public void ToDisplayName(){} // RVA: 0x7AEB8FC30
        public void op_Implicit(){} // RVA: 0x7AEB8FCE0
        public void Create(){} // RVA: 0x7AEB8FCF0
        public void ResetCachedAction(){} // RVA: 0x7AEB8FD70
        public void ToInputAction(){} // RVA: 0x7AEB8FF60
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class InputActionSetupExtensions : Object
    {
        // ── Methods ──
        public void AddActionMap(){} // RVA: 0x7AEB901D0
        public void RemoveActionMap(){} // RVA: 0x7AEB90810
        public void AddAction(){} // RVA: 0x7AEB909A0
        public void RemoveAction(){} // RVA: 0x7AEB91600
        public void AddBinding(){} // RVA: 0x7AEB92500
        public void AddCompositeBinding(){} // RVA: 0x7AEB92650
        public void AddBindingInternal(){} // RVA: 0x7AEB92A00
        public void ChangeBinding(){} // RVA: 0x7AEB936B0
        public void ChangeBindingWithId(){} // RVA: 0x7AEB93240
        public void ChangeBindingWithGroup(){} // RVA: 0x7AEB933D0
        public void ChangeBindingWithPath(){} // RVA: 0x7AEB93540
        public void ChangeCompositeBinding(){} // RVA: 0x7AEB93A20
        public void Rename(){} // RVA: 0x7AEB93E30
        public void AddControlScheme(){} // RVA: 0x7AEB945B0
        public void RemoveControlScheme(){} // RVA: 0x7AEB948B0
        public void WithBindingGroup(){} // RVA: 0x7AEB94B20
        public void WithDevice(){} // RVA: 0x7AEB94CA0
        public void WithRequiredDevice(){} // RVA: 0x7AEB94EC0
        public void WithOptionalDevice(){} // RVA: 0x7AEB95020
        public void OrWithRequiredDevice(){} // RVA: 0x7AEB95180
        public void OrWithOptionalDevice(){} // RVA: 0x7AEB952E0
    }

    public class InputActionState : Object
    {
        // ── Methods ──
        public void get_totalCompositeCount(){} // RVA: 0x7A835E820
        public void get_totalMapCount(){} // RVA: 0x7A8178B70
        public void get_totalActionCount(){} // RVA: 0x7A9231EA0
        public void get_totalBindingCount(){} // RVA: 0x7A8A22410
        public void get_totalInteractionCount(){} // RVA: 0x7A8355950
        public void get_totalControlCount(){} // RVA: 0x7A87A7DA0
        public void get_mapIndices(){} // RVA: 0x7A8142680
        public void get_actionStates(){} // RVA: 0x7A8175DF0
        public void get_bindingStates(){} // RVA: 0x7A8153390
        public void get_interactionStates(){} // RVA: 0x7A81A00E0
        public void get_controlIndexToBindingIndex(){} // RVA: 0x7A87C5850
        public void get_controlGroupingAndComplexity(){} // RVA: 0x7A87D9480
        public void get_controlMagnitudes(){} // RVA: 0x7A82C2060
        public void get_enabledControls(){} // RVA: 0x7A81163D0
        public void get_isProcessingControlStateChange(){} // RVA: 0x7AE6C39B0
        public void Initialize(){} // RVA: 0x7AEB988A0
        public void ComputeControlGroupingIfNecessary(){} // RVA: 0x7AEB989C0
        public void ClaimDataFrom(){} // RVA: 0x7AEB98BD0
        public void Finalize(){} // RVA: 0x7AEB98E20
        public void Dispose(){} // RVA: 0x7AEB98E90
        public void Destroy(){} // RVA: 0x7AEB98EA0
        public void Clone(){} // RVA: 0x7AEB99230
        public void System.ICloneable.Clone(){} // RVA: 0x7AEB99560
        public void IsUsingDevice(){} // RVA: 0x7AEB99570
        public void CanUseDevice(){} // RVA: 0x7AEB99710
        public void HasEnabledActions(){} // RVA: 0x7AEB99A30
        public void FinishBindingCompositeSetups(){} // RVA: 0x7AEB99A90
        public void PrepareForBindingReResolution(){} // RVA: 0x7AEB99BD0
        public void FinishBindingResolution(){} // RVA: 0x7AEB9A120
        public void RestoreActionStatesAfterReResolvingBindings(){} // RVA: 0x7AEB9A320
        public void IsActiveControl(){} // RVA: 0x7AEB9ACA0
        public void FindControlIndexOnBinding(){} // RVA: 0x7AEB9AD60
        public void ResetActionStatesDrivenBy(){} // RVA: 0x7AEB9ADF0
        public void IsActionBoundToControlFromDevice(){} // RVA: 0x7AEB9AF70
        public void ResetActionState(){} // RVA: 0x7AEB9B090
        public void FetchActionState(){} // RVA: 0x7AEB9B310
        public void FetchMapIndices(){} // RVA: 0x7AEB9B340
        public void EnableAllActions(){} // RVA: 0x7AEB9B390
        public void EnableControls(){} // RVA: 0x7AEB9BD30
        public void EnableSingleAction(){} // RVA: 0x7AEB9B560
        public void DisableAllActions(){} // RVA: 0x7AEBA2150
        public void DisableControls(){} // RVA: 0x7AEB9BF20
        public void DisableSingleAction(){} // RVA: 0x7AEB9BA90
        public void SetInitialStateCheckPending(){} // RVA: 0x7AEB9C1E0
        public void IsControlEnabled(){} // RVA: 0x7AEB9C220
        public void SetControlEnabled(){} // RVA: 0x7AEB9C260
        public void HookOnBeforeUpdate(){} // RVA: 0x7AEB9C2A0
        public void UnhookOnBeforeUpdate(){} // RVA: 0x7AEB9C420
        public void OnBeforeInitialUpdate(){} // RVA: 0x7AEB9C4F0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7AEB9C8D0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7AEB9C920
        public void ToCombinedMapAndControlAndBindingIndex(){} // RVA: 0x7AEB9C970
        public void SplitUpMapAndControlAndBindingIndex(){} // RVA: 0x7AEB9C9B0
        public void GetComplexityFromMonitorIndex(){} // RVA: 0x7AEB9C9E0
        public void ProcessControlStateChange(){} // RVA: 0x7AEB9C9F0
        public void ProcessButtonState(){} // RVA: 0x7AEB9D1B0
        public void ShouldIgnoreInputOnCompositeBinding(){} // RVA: 0x7AEB9D400
        public void IsConflictingInput(){} // RVA: 0x7AEB9D420
        public void GetActionBindingStartIndexAndCount(){} // RVA: 0x7AEB9D950
        public void ProcessDefaultInteraction(){} // RVA: 0x7AEB9D980
        public void ProcessInteractions(){} // RVA: 0x7AEB9DD10
        public void ProcessTimeout(){} // RVA: 0x7AEB9DFC0
        public void SetTotalTimeoutCompletionTime(){} // RVA: 0x7AEB9E3C0
        public void StartTimeout(){} // RVA: 0x7AEB9E400
        public void StopTimeout(){} // RVA: 0x7AEB9E5C0
        public void ChangePhaseOfInteraction(){} // RVA: 0x7AEB9E6C0
        public void ChangePhaseOfAction(){} // RVA: 0x7AEB9EC70
        public void ChangePhaseOfActionInternal(){} // RVA: 0x7AEB9EF00
        public void CallActionListeners(){} // RVA: 0x7AEB9F240
        public void GetActionOrNoneString(){} // RVA: 0x7AEB9F570
        public void GetActionOrNull(){} // RVA: 0x7AEB9F670
        public void GetControl(){} // RVA: 0x7AEB9F710
        public void GetInteractionOrNull(){} // RVA: 0x7AEB9F760
        public void GetBindingIndexInMap(){} // RVA: 0x7AEB9F7A0
        public void GetBindingIndexInState(){} // RVA: 0x7AEB9F7F0
        public void GetBindingState(){} // RVA: 0x7AEB9F830
        public void GetBinding(){} // RVA: 0x7AEB9F840
        public void GetActionMap(){} // RVA: 0x7AEB9F8D0
        public void ResetInteractionStateAndCancelIfNecessary(){} // RVA: 0x7AEB9F910
        public void ResetInteractionState(){} // RVA: 0x7AEB9F9F0
        public void GetValueSizeInBytes(){} // RVA: 0x7AEB9FAC0
        public void GetValueType(){} // RVA: 0x7AEB9FB70
        public void IsActuated(){} // RVA: 0x7AEB9FC20
        public void ReadValue(){} // RVA: 0x7AA4C8930
        public void ApplyProcessors(){} // RVA: 0x7AA4C6890
        public void EvaluateCompositePartMagnitude(){} // RVA: 0x7AEB9FF70
        public void GetCompositePartPressTime(){} // RVA: 0x7AEBA0060
        public void ReadCompositePartValue(){} // RVA: 0x7AA4C6D90
        public void ReadCompositePartValueAsObject(){} // RVA: 0x7AEBA0240
        public void ReadValueAsObject(){} // RVA: 0x7AEBA0380
        public void ReadValueAsButton(){} // RVA: 0x7AEBA0610
        public void SaveAndResetState(){} // RVA: 0x7AEBA0780
        public void AddToGlobalList(){} // RVA: 0x7AEBA0D50
        public void RemoveMapFromGlobalList(){} // RVA: 0x7AEBA0DE0
        public void CompactGlobalList(){} // RVA: 0x7AEBA0F90
        public void NotifyListenersOfActionChange(){} // RVA: 0x7AEBA13D0
        public void ResetGlobals(){} // RVA: 0x7AEBA1500
        public void FindAllEnabledActions(){} // RVA: 0x7AEBA1730
        public void OnDeviceChange(){} // RVA: 0x7AEBA1A50
        public void DeferredResolutionOfBindings(){} // RVA: 0x7AEBA1E20
        public void DestroyAllActionMapStates(){} // RVA: 0x7AEBA22F0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AEBA2550
    }

    public class InputAction[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputBinding : ValueType
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7A765F710
        public void set_name(){} // RVA: 0x7A7637E60
        public void get_id(){} // RVA: 0x7A7EAB540
        public void set_id(){} // RVA: 0x7A7EAB570
        public void get_path(){} // RVA: 0x7A7664CF0
        public void set_path(){} // RVA: 0x7A7664E50
        public void get_overridePath(){} // RVA: 0x7A768E520
        public void set_overridePath(){} // RVA: 0x7A764C2F0
        public void get_interactions(){} // RVA: 0x7A767FF40
        public void set_interactions(){} // RVA: 0x7A767FF60
        public void get_overrideInteractions(){} // RVA: 0x7A76AAE30
        public void set_overrideInteractions(){} // RVA: 0x7A76AAD20
        public void get_processors(){} // RVA: 0x7A7677A70
        public void set_processors(){} // RVA: 0x7A7677A80
        public void get_overrideProcessors(){} // RVA: 0x7A7690C30
        public void set_overrideProcessors(){} // RVA: 0x7A76AAD80
        public void get_groups(){} // RVA: 0x7A7677A20
        public void set_groups(){} // RVA: 0x7A76779C0
        public void get_action(){} // RVA: 0x7A7690C10
        public void set_action(){} // RVA: 0x7A7690C80
        public void get_isComposite(){} // RVA: 0x7A7EAB610
        public void set_isComposite(){} // RVA: 0x7A7EAB620
        public void get_isPartOfComposite(){} // RVA: 0x7A7EAB640
        public void set_isPartOfComposite(){} // RVA: 0x7A7EAB650
        public void get_hasOverrides(){} // RVA: 0x7A7EAB670
        public void .ctor(){} // RVA: 0x7A7EAB690
        public void GetNameOfComposite(){} // RVA: 0x7A7EAB6A0
        public void GenerateId(){} // RVA: 0x7A7EAB6B0
        public void RemoveOverrides(){} // RVA: 0x7A7EAB6C0
        public void MaskByGroup(){} // RVA: 0x7AEBA44C0
        public void MaskByGroups(){} // RVA: 0x7AEBA4540
        public void get_effectivePath(){} // RVA: 0x7A7EAB6D0
        public void get_effectiveInteractions(){} // RVA: 0x7A7EAB6E0
        public void get_effectiveProcessors(){} // RVA: 0x7A7EAB6F0
        public void get_isEmpty(){} // RVA: 0x7A7EAB700
        public void Equals(){} // RVA: 0x7A7EAB790
        public void op_Equality(){} // RVA: 0x7AEBA4C60
        public void op_Inequality(){} // RVA: 0x7AEBA4CB0
        public void GetHashCode(){} // RVA: 0x7A7EAB7A0
        public void ToString(){} // RVA: 0x7A7EAB7B0
        public void ToDisplayString(){} // RVA: 0x7A7EAB800
        public void TriggersAction(){} // RVA: 0x7A7EAB810
        public void Matches(){} // RVA: 0x7A7EAB880
    }

    public class InputBindingComposite : Object
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7A7E00680
        public void get_valueSizeInBytes(){} // RVA: 0x7A7E00710
        public void ReadValue(){} // RVA: 0x7A8051B10
        public void ReadValueAsObject(){} // RVA: 0x7A7E00B20
        public void EvaluateMagnitude(){} // RVA: 0x7AEBA57D0
        public void FinishSetup(){} // RVA: 0x7A80D7310
        public void CallFinishSetup(){} // RVA: 0x7AE9E7E00
        public void GetValueType(){} // RVA: 0x7AEBA57E0
        public void GetExpectedControlLayoutName(){} // RVA: 0x7AEBA5920
        public void GetPartNames(){} // RVA: 0x7AEBA5AC0
        public void GetDisplayFormatString(){} // RVA: 0x7AEBA5B70
        public void .ctor(){} // RVA: 0x7A80D7310
        public void s_Composites(){} // RVA: 0x7B3FB4428
    }

    public class InputBindingCompositeContext : ValueType
    {
        // ── Methods ──
        public void get_controls(){} // RVA: 0x7A7EAED60
        public void EvaluateMagnitude(){} // RVA: 0x7A7EAED70
        public void ReadValue(){} // RVA: 0x7A77AFA90
        public void ReadValueAsButton(){} // RVA: 0x7A7EAED80
        public void ReadValueAsObject(){} // RVA: 0x7A7EAEDA0
        public void GetPressTime(){} // RVA: 0x7A7EAEDB0
    }

    public class InputBindingComposite[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputBindingComposite`1 : InputBindingComposite
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7A7E00680
        public void get_valueSizeInBytes(){} // RVA: 0x7A7E00710
        public void ReadValue(){} // RVA: 0x7A8051B10
        public void ReadValueAsObject(){} // RVA: 0x7A7E00B20
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class InputBindingComposite`1 : InputBindingComposite
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7AB39A6D0
        public void get_valueSizeInBytes(){} // RVA: 0x7A88217C0
        public void ReadValue(){} // RVA: 0x7AB39A780
        public void ReadValueAsObject(){} // RVA: 0x7AB39A8D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class InputBindingComposite`1 : InputBindingComposite
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7AB39A460
        public void get_valueSizeInBytes(){} // RVA: 0x7A883BE70
        public void ReadValue(){} // RVA: 0x7AB39A510
        public void ReadValueAsObject(){} // RVA: 0x7AB39A660
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class InputBindingComposite`1 : InputBindingComposite
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7AB39A940
        public void get_valueSizeInBytes(){} // RVA: 0x7A9F22B10
        public void ReadValue(){} // RVA: 0x7AB39A9F0
        public void ReadValueAsObject(){} // RVA: 0x7AB39AB60
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class InputBindingResolver : ValueType
    {
        // ── Methods ──
        public void get_totalMapCount(){} // RVA: 0x7A765EE70
        public void get_totalActionCount(){} // RVA: 0x7A77197A0
        public void get_totalBindingCount(){} // RVA: 0x7A76B7200
        public void get_totalControlCount(){} // RVA: 0x7A768E6D0
        public void Dispose(){} // RVA: 0x7A7EAEE00
        public void StartWithPreviousResolve(){} // RVA: 0x7A7EAEE10
        public void AddActionMap(){} // RVA: 0x7A7EAEE20
        public void InstantiateWithParameters(){} // RVA: 0x7A77AFAE0
        public void InstantiateBindingComposite(){} // RVA: 0x7AEBCE340
        public void ApplyParameters(){} // RVA: 0x7AEBCE6D0
        public void AssignCompositePartIndex(){} // RVA: 0x7AEBCEBF0
    }

    public class InputBinding[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D2A10
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E190
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E3050
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA280D00
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E190
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputControl : Object
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7AEBD9D10
        public void get_displayName(){} // RVA: 0x7AEBD9D70
        public void set_displayName(){} // RVA: 0x7A8296DE0
        public void get_shortDisplayName(){} // RVA: 0x7AEBD9E10
        public void set_shortDisplayName(){} // RVA: 0x7A8152D90
        public void get_path(){} // RVA: 0x7AEBD9E70
        public void get_layout(){} // RVA: 0x7AEBDA000
        public void get_variants(){} // RVA: 0x7AEBDA060
        public void get_device(){} // RVA: 0x7A82C2060
        public void get_parent(){} // RVA: 0x7A825E100
        public void get_children(){} // RVA: 0x7AEBDA0C0
        public void get_usages(){} // RVA: 0x7AEBDA180
        public void get_aliases(){} // RVA: 0x7AEBDA240
        public void get_stateBlock(){} // RVA: 0x7A97277F0
        public void get_noisy(){} // RVA: 0x7AEBDA300
        public void set_noisy(){} // RVA: 0x7AEBDA310
        public void get_synthetic(){} // RVA: 0x7AEBDA410
        public void set_synthetic(){} // RVA: 0x7AEBDA420
        public void get_Item(){} // RVA: 0x7AEBDA440
        public void get_valueType(){} // RVA: 0x7A7E00680
        public void get_valueSizeInBytes(){} // RVA: 0x7A7E00710
        public void get_magnitude(){} // RVA: 0x7AEBDA500
        public void ToString(){} // RVA: 0x7AEBDA580
        public void DebuggerDisplay(){} // RVA: 0x7AEBDA630
        public void EvaluateMagnitude(){} // RVA: 0x7AEBA57D0
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7A8051B10
        public void ReadValueFromStateAsObject(){} // RVA: 0x7A8051B10
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7A8051B10
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7AEBDA7B0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7AEBDA820
        public void CompareValue(){} // RVA: 0x7A8051B10
        public void TryGetChildControl(){} // RVA: 0x7A8051B10
        public void GetChildControl(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7AB39E550
        public void FinishSetup(){} // RVA: 0x7A80D7310
        public void RefreshConfigurationIfNeeded(){} // RVA: 0x7AEBDAA50
        public void RefreshConfiguration(){} // RVA: 0x7A80D7310
        public void get_currentStatePtr(){} // RVA: 0x7AEBDAA90
        public void get_previousFrameStatePtr(){} // RVA: 0x7AEBDAAF0
        public void get_defaultStatePtr(){} // RVA: 0x7AEBDAB50
        public void get_noiseMaskPtr(){} // RVA: 0x7AEBDAB90
        public void get_stateOffsetRelativeToDeviceRoot(){} // RVA: 0x7AEBDABD0
        public void get_optimizedControlDataType(){} // RVA: 0x7A9A94050
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7A82D1450
        public void ApplyParameterChanges(){} // RVA: 0x7AEBDAC40
        public void SetOptimizedControlDataType(){} // RVA: 0x7AEBDAD10
        public void SetOptimizedControlDataTypeRecursively(){} // RVA: 0x7AEBDADB0
        public void EnsureOptimizationTypeHasNotChanged(){} // RVA: 0x7AEBDAFA0
        public void get_isSetupFinished(){} // RVA: 0x7AEBDB3F0
        public void set_isSetupFinished(){} // RVA: 0x7AEBDB400
        public void get_isButton(){} // RVA: 0x7AEBDB420
        public void set_isButton(){} // RVA: 0x7AEBDB430
        public void get_isConfigUpToDate(){} // RVA: 0x7AEBDB450
        public void set_isConfigUpToDate(){} // RVA: 0x7AEBDB460
        public void get_dontReset(){} // RVA: 0x7AEBDB480
        public void set_dontReset(){} // RVA: 0x7AEBDB490
        public void get_usesStateFromOtherControl(){} // RVA: 0x7AEBDB4B0
        public void set_usesStateFromOtherControl(){} // RVA: 0x7AEBDB4C0
        public void get_hasDefaultState(){} // RVA: 0x7AEBDB4E0
        public void CallFinishSetupRecursive(){} // RVA: 0x7AEBDB4F0
        public void MakeChildPath(){} // RVA: 0x7AEBDB5D0
        public void BakeOffsetIntoStateBlockRecursive(){} // RVA: 0x7AEBDB680
        public void GetDeviceIndex(){} // RVA: 0x7AEBDB770
        public void IsValueConsideredPressed(){} // RVA: 0x7AEBDB8E0
        public void AddProcessor(){} // RVA: 0x7A80D7310
        public void MarkAsStale(){} // RVA: 0x7AEBDB990
        public void MarkAsStaleRecursively(){} // RVA: 0x7AEBDB9A0
    }

    public class InputControlExtensions : Object
    {
        // ── Methods ──
        public void FindInParentChain(){} // RVA: 0x7A8051B10
        public void IsPressed(){} // RVA: 0x7AEBDBBC0
        public void IsActuated(){} // RVA: 0x7AEBDBD10
        public void ReadValueAsObject(){} // RVA: 0x7AEBDBDB0
        public void ReadValueIntoBuffer(){} // RVA: 0x7AEBDBE30
        public void ReadDefaultValueAsObject(){} // RVA: 0x7AEBDBF30
        public void ReadValueFromEvent(){} // RVA: 0x7A8051B10
        public void ReadValueFromEventAsObject(){} // RVA: 0x7AEBDBFE0
        public void ReadUnprocessedValueFromEvent(){} // RVA: 0x7A8051B10
        public void WriteValueFromObjectIntoEvent(){} // RVA: 0x7AEBDC110
        public void WriteValueIntoState(){} // RVA: 0x7A8051B10
        public void WriteValueIntoEvent(){} // RVA: 0x7A8051B10
        public void CopyState(){} // RVA: 0x7A7E18AA0
        public void CheckStateIsAtDefault(){} // RVA: 0x7AEBDC6E0
        public void CheckStateIsAtDefaultIgnoringNoise(){} // RVA: 0x7AEBDC950
        public void CompareStateIgnoringNoise(){} // RVA: 0x7AEBDCAA0
        public void CompareState(){} // RVA: 0x7AEBDCD70
        public void HasValueChangeInState(){} // RVA: 0x7AEBDCE60
        public void HasValueChangeInEvent(){} // RVA: 0x7AEBDCF40
        public void GetStatePtrFromStateEvent(){} // RVA: 0x7AEBDD040
        public void GetStatePtrFromStateEventUnchecked(){} // RVA: 0x7AEBDD100
        public void ResetToDefaultStateInEvent(){} // RVA: 0x7AEBDD3F0
        public void QueueValueChange(){} // RVA: 0x7A8051B10
        public void AccumulateValueInEvent(){} // RVA: 0x7AEBDD780
        public void FindControlsRecursive(){} // RVA: 0x7A7E1E060
        public void BuildPath(){} // RVA: 0x7AEBDD8A0
        public void EnumerateControls(){} // RVA: 0x7AEBDDDC0
        public void EnumerateChangedControls(){} // RVA: 0x7AEBDE040
        public void HasButtonPress(){} // RVA: 0x7AEBDE090
        public void GetFirstButtonPressOrNull(){} // RVA: 0x7AEBDE0B0
        public void GetAllButtonPresses(){} // RVA: 0x7AEBDE310
        public void Setup(){} // RVA: 0x7AEBDE4C0
    }

    public class InputControlList`1 : ValueType
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7A7E00710
        public void get_Capacity(){} // RVA: 0x7A7E00710
        public void set_Capacity(){} // RVA: 0x7A7E189D0
        public void get_IsReadOnly(){} // RVA: 0x7A7E01900
        public void get_Item(){} // RVA: 0x7A8051B10
        public void set_Item(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A7E18800
        public void Resize(){} // RVA: 0x7A7E189D0
        public void Add(){} // RVA: 0x7A8051B10
        public void AddSlice(){} // RVA: 0x7A8051B10
        public void AddRange(){} // RVA: 0x7A7E1E220
        public void Remove(){} // RVA: 0x7A8051B10
        public void RemoveAt(){} // RVA: 0x7A7E189D0
        public void CopyTo(){} // RVA: 0x7A7E1D590
        public void IndexOf(){} // RVA: 0x7A8051B10
        public void Insert(){} // RVA: 0x7A8051B10
        public void Clear(){} // RVA: 0x7A7E18770
        public void Contains(){} // RVA: 0x7A8051B10
        public void SwapElements(){} // RVA: 0x7A7E1ABE0
        public void Sort(){} // RVA: 0x7A8051B10
        public void ToArray(){} // RVA: 0x7A7E063A0
        public void AppendTo(){} // RVA: 0x7A7E18890
        public void Dispose(){} // RVA: 0x7A7E18770
        public void GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
        public void ToString(){} // RVA: 0x7A7E00680
        public void ToIndex(){} // RVA: 0x7A8051B10
        public void FromIndex(){} // RVA: 0x7A8051B10
    }

    public class InputControlList`1 : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7A78E5DE0
        public void .ctor(){} // RVA: 0x7A78E59C0
        public void get_Count(){} // RVA: 0x7A765F070
        public void Add(){} // RVA: 0x7A78E5B00
        public void get_Capacity(){} // RVA: 0x7A78E58D0
        public void set_Capacity(){} // RVA: 0x7A78E5920
        public void get_IsReadOnly(){} // RVA: 0x7A77CFDD0
        public void get_Item(){} // RVA: 0x7A78E5930
        public void set_Item(){} // RVA: 0x7A78E5940
        public void Resize(){} // RVA: 0x7A78E5AF0
        public void AddSlice(){} // RVA: 0x7A8051B10
        public void AddRange(){} // RVA: 0x7A78E5B10
        public void Remove(){} // RVA: 0x7A78E5B20
        public void RemoveAt(){} // RVA: 0x7A78E5BE0
        public void CopyTo(){} // RVA: 0x7A78E5BF0
        public void IndexOf(){} // RVA: 0x7A78E5C60
        public void Insert(){} // RVA: 0x7A78E5BF0
        public void Clear(){} // RVA: 0x7A7682C10
        public void Contains(){} // RVA: 0x7A78E5C80
        public void SwapElements(){} // RVA: 0x7A78E5D00
        public void Sort(){} // RVA: 0x7A8051B10
        public void ToArray(){} // RVA: 0x7A78E5D10
        public void AppendTo(){} // RVA: 0x7A78E5D20
        public void GetEnumerator(){} // RVA: 0x7A78E5E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A78E5E50
        public void ToString(){} // RVA: 0x7A78E5E90
        public void ToIndex(){} // RVA: 0x7AB39C9C0
        public void FromIndex(){} // RVA: 0x7AB39CAB0
    }

    public class InputControlList`1 : ValueType
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7A765F070
        public void get_Capacity(){} // RVA: 0x7A78E58D0
        public void set_Capacity(){} // RVA: 0x7A78E5920
        public void get_IsReadOnly(){} // RVA: 0x7A77CFDD0
        public void get_Item(){} // RVA: 0x7A78E5930
        public void set_Item(){} // RVA: 0x7A78E5940
        public void .ctor(){} // RVA: 0x7A78E59C0
        public void Resize(){} // RVA: 0x7A78E5AF0
        public void Add(){} // RVA: 0x7A78E5B00
        public void AddSlice(){} // RVA: 0x7A8051B10
        public void AddRange(){} // RVA: 0x7A78E5B10
        public void Remove(){} // RVA: 0x7A78E5B20
        public void RemoveAt(){} // RVA: 0x7A78E5BE0
        public void CopyTo(){} // RVA: 0x7A78E5BF0
        public void IndexOf(){} // RVA: 0x7A78E5C60
        public void Insert(){} // RVA: 0x7A78E5BF0
        public void Clear(){} // RVA: 0x7A7682C10
        public void Contains(){} // RVA: 0x7A78E5C80
        public void SwapElements(){} // RVA: 0x7A78E5D00
        public void Sort(){} // RVA: 0x7A8051B10
        public void ToArray(){} // RVA: 0x7A78E5D10
        public void AppendTo(){} // RVA: 0x7A78E5D20
        public void Dispose(){} // RVA: 0x7A78E5DE0
        public void GetEnumerator(){} // RVA: 0x7A78E5E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A78E5E50
        public void ToString(){} // RVA: 0x7A78E5E90
        public void ToIndex(){} // RVA: 0x7AB39C9C0
        public void FromIndex(){} // RVA: 0x7AB39CAB0
    }

    public class InputControlPath : Object
    {
        // ── Methods ──
        public void CleanSlashes(){} // RVA: 0x7AEBE0A10
        public void Combine(){} // RVA: 0x7AEBE0A40
        public void ToHumanReadableString(){} // RVA: 0x7AEBE0B80
        public void TryGetDeviceUsages(){} // RVA: 0x7AEBE1200
        public void TryGetDeviceLayout(){} // RVA: 0x7AEBE1440
        public void TryGetControlLayout(){} // RVA: 0x7AEBE15F0
        public void FindControlLayoutRecursive(){} // RVA: 0x7AEBE1AC0
        public void ControlLayoutMatchesPathComponent(){} // RVA: 0x7AEBE1DA0
        public void StringMatches(){} // RVA: 0x7AEBE1FE0
        public void TryFindControl(){} // RVA: 0x7AA4CFB70
        public void TryFindControls(){} // RVA: 0x7AA4CFC60
        public void TryFindChild(){} // RVA: 0x7A8051B10
        public void Matches(){} // RVA: 0x7AEBE27D0
        public void MatchControlComponent(){} // RVA: 0x7AEBE2980
        public void MatchesPrefix(){} // RVA: 0x7AEBE2DC0
        public void MatchesRecursive(){} // RVA: 0x7AEBE2F80
        public void MatchControlsRecursive(){} // RVA: 0x7AA4CF110
        public void MatchByUsageAtDeviceRootRecursive(){} // RVA: 0x7AA4CEC30
        public void MatchChildrenRecursive(){} // RVA: 0x7AA4CEFD0
        public void MatchPathComponent(){} // RVA: 0x7AEBE3010
        public void PathComponentCanYieldMultipleMatches(){} // RVA: 0x7AEBE33D0
        public void Parse(){} // RVA: 0x7AEBE3490
    }

    public class InputControlScheme : ValueType
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7A765F710
        public void get_bindingGroup(){} // RVA: 0x7A765F080
        public void set_bindingGroup(){} // RVA: 0x7A765F010
        public void get_deviceRequirements(){} // RVA: 0x7A7EAF270
        public void .ctor(){} // RVA: 0x7A7EAF2A0
        public void SetNameAndBindingGroup(){} // RVA: 0x7A7EAF2B0
        public void FindControlSchemeForDevices(){} // RVA: 0x7A8051B10
        public void FindControlSchemeForDevice(){} // RVA: 0x7A8051B10
        public void SupportsDevice(){} // RVA: 0x7A7EAF2C0
        public void PickDevicesFrom(){} // RVA: 0x7A8051B10
        public void Equals(){} // RVA: 0x7A7EAF300
        public void GetHashCode(){} // RVA: 0x7A7EAF310
        public void ToString(){} // RVA: 0x7A7EAF320
        public void op_Equality(){} // RVA: 0x7AEBCFBD0
        public void op_Inequality(){} // RVA: 0x7AEBCFC00
    }

    public class InputControlScheme[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D2EE0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DF80
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2C90
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA281100
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DF80
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputControl[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7A7E00680
        public void get_valueSizeInBytes(){} // RVA: 0x7A7E00710
        public void get_value(){} // RVA: 0x7A7E00680
        public void get_unprocessedValue(){} // RVA: 0x7A7E00680
        public void ReadValue(){} // RVA: 0x7A8051B10
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7A8051B10
        public void ReadDefaultValue(){} // RVA: 0x7A8051B10
        public void ReadValueFromState(){} // RVA: 0x7A8051B10
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7A8051B10
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7A8051B10
        public void ReadUnprocessedValue(){} // RVA: 0x7A8051B10
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7A8051B10
        public void ReadValueFromStateAsObject(){} // RVA: 0x7A8051B10
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7A8051B10
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7A8051B10
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7A8051B10
        public void WriteValueIntoState(){} // RVA: 0x7A8051B10
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7A8051B10
        public void CompareValue(){} // RVA: 0x7A8051B10
        public void ProcessValue(){} // RVA: 0x7A7E18800
        public void TryGetProcessor(){} // RVA: 0x7A8051B10
        public void AddProcessor(){} // RVA: 0x7A7E18800
        public void FinishSetup(){} // RVA: 0x7A7E18770
        public void get_processors(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7AB3A76F0
        public void get_valueSizeInBytes(){} // RVA: 0x7A883BE70
        public void get_value(){} // RVA: 0x7AB3A77A0
        public void get_unprocessedValue(){} // RVA: 0x7AB3A7860
        public void ReadValue(){} // RVA: 0x7AB3A7980
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7AB3A79A0
        public void ReadDefaultValue(){} // RVA: 0x7AB3A7AB0
        public void ReadValueFromState(){} // RVA: 0x7AB3A7B90
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7AB3A7C20
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7AB3A7D50
        public void ReadUnprocessedValue(){} // RVA: 0x7AB3A7E10
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7A80804D0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7AB3A7E30
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7AB3A7F00
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7AB3A80B0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7AB3A8250
        public void WriteValueIntoState(){} // RVA: 0x7AB39DB20
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7AB3A8440
        public void CompareValue(){} // RVA: 0x7AB3A8600
        public void ProcessValue(){} // RVA: 0x7AB3A87B0
        public void TryGetProcessor(){} // RVA: 0x7A8051B10
        public void AddProcessor(){} // RVA: 0x7AB39E130
        public void FinishSetup(){} // RVA: 0x7AB3A8890
        public void get_processors(){} // RVA: 0x7AB39E530
        public void .ctor(){} // RVA: 0x7AB39E550
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7AB3A29E0
        public void get_valueSizeInBytes(){} // RVA: 0x7A883BE70
        public void get_value(){} // RVA: 0x7AB3A2A90
        public void get_unprocessedValue(){} // RVA: 0x7AB3A2B50
        public void ReadValue(){} // RVA: 0x7AB3A2C70
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7AB3A2C80
        public void ReadDefaultValue(){} // RVA: 0x7AB3A2D90
        public void ReadValueFromState(){} // RVA: 0x7AB3A2E70
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7AB3A2F00
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7AB3A3020
        public void ReadUnprocessedValue(){} // RVA: 0x7AB3A30E0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7A80804D0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7AB3A30F0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7AB3A31B0
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7AB3A3360
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7AB3A34F0
        public void WriteValueIntoState(){} // RVA: 0x7AB39DB20
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7AB3A36E0
        public void CompareValue(){} // RVA: 0x7AB3A39A0
        public void ProcessValue(){} // RVA: 0x7AB3A3B40
        public void TryGetProcessor(){} // RVA: 0x7A8051B10
        public void AddProcessor(){} // RVA: 0x7AB39E130
        public void FinishSetup(){} // RVA: 0x7AB3A3C20
        public void get_processors(){} // RVA: 0x7AB39E530
        public void .ctor(){} // RVA: 0x7AB39E550
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7AB39FA20
        public void get_valueSizeInBytes(){} // RVA: 0x7A88217C0
        public void get_value(){} // RVA: 0x7AB39FAD0
        public void get_unprocessedValue(){} // RVA: 0x7AB39FB90
        public void ReadValue(){} // RVA: 0x7AB39FCB0
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7AB39FCD0
        public void ReadDefaultValue(){} // RVA: 0x7AB39FDE0
        public void ReadValueFromState(){} // RVA: 0x7AB39FEC0
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7AB39FF50
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7AB3A0080
        public void ReadUnprocessedValue(){} // RVA: 0x7AB3A0140
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7A80804D0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7AB3A0160
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7AB3A0230
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7AB3A03E0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7AB3A0580
        public void WriteValueIntoState(){} // RVA: 0x7AB39DB20
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7AB3A0770
        public void CompareValue(){} // RVA: 0x7AB3A0980
        public void ProcessValue(){} // RVA: 0x7AB3A0B30
        public void TryGetProcessor(){} // RVA: 0x7A8051B10
        public void AddProcessor(){} // RVA: 0x7AB39E130
        public void FinishSetup(){} // RVA: 0x7AB3A0C10
        public void get_processors(){} // RVA: 0x7AB39E530
        public void .ctor(){} // RVA: 0x7AB39E550
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7AB3AAD00
        public void get_valueSizeInBytes(){} // RVA: 0x7A88217C0
        public void get_value(){} // RVA: 0x7AB3AADB0
        public void get_unprocessedValue(){} // RVA: 0x7AB3AAE80
        public void ReadValue(){} // RVA: 0x7AB3AAFC0
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7AB3AAFE0
        public void ReadDefaultValue(){} // RVA: 0x7AB3AB0F0
        public void ReadValueFromState(){} // RVA: 0x7AB3AB1D0
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7AB3AB260
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7AB3AB3A0
        public void ReadUnprocessedValue(){} // RVA: 0x7AB3AB470
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7A80804D0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7AB3AB490
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7AB3AB550
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7AB3AB700
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7AB3AB890
        public void WriteValueIntoState(){} // RVA: 0x7AB39DB20
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7AB3ABA90
        public void CompareValue(){} // RVA: 0x7AB3ABC50
        public void ProcessValue(){} // RVA: 0x7AB3ABE00
        public void TryGetProcessor(){} // RVA: 0x7A8051B10
        public void AddProcessor(){} // RVA: 0x7AB39E130
        public void FinishSetup(){} // RVA: 0x7AB3ABEE0
        public void get_processors(){} // RVA: 0x7AB39E530
        public void .ctor(){} // RVA: 0x7AB39E550
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7AB3AC0E0
        public void get_valueSizeInBytes(){} // RVA: 0x7A9F22B10
        public void get_value(){} // RVA: 0x7AB3AC190
        public void get_unprocessedValue(){} // RVA: 0x7AB3AC260
        public void ReadValue(){} // RVA: 0x7AB3AC390
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7AB3AC3C0
        public void ReadDefaultValue(){} // RVA: 0x7AB3AC510
        public void ReadValueFromState(){} // RVA: 0x7AB3AC620
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7AB3AC6E0
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7AB3AC840
        public void ReadUnprocessedValue(){} // RVA: 0x7AB3AC920
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7A80804D0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7AB3AC950
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7AB3ACA30
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7AB3ACC10
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7AB3ACDC0
        public void WriteValueIntoState(){} // RVA: 0x7AB39DB20
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7AB3ACFD0
        public void CompareValue(){} // RVA: 0x7AB3AD1F0
        public void ProcessValue(){} // RVA: 0x7AB3AD410
        public void TryGetProcessor(){} // RVA: 0x7A8051B10
        public void AddProcessor(){} // RVA: 0x7AB39E130
        public void FinishSetup(){} // RVA: 0x7AB3AD550
        public void get_processors(){} // RVA: 0x7AB39E530
        public void .ctor(){} // RVA: 0x7AB39E550
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7AB3A61D0
        public void get_valueSizeInBytes(){} // RVA: 0x7A9F22B20
        public void get_value(){} // RVA: 0x7AB3A6280
        public void get_unprocessedValue(){} // RVA: 0x7AB3A6340
        public void ReadValue(){} // RVA: 0x7AB3A6460
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7AB3A6480
        public void ReadDefaultValue(){} // RVA: 0x7AB3A65B0
        public void ReadValueFromState(){} // RVA: 0x7AB3A66B0
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7AB3A6760
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7AB3A68B0
        public void ReadUnprocessedValue(){} // RVA: 0x7AB3A6980
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7A80804D0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7AB3A69A0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7AB3A6A70
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7AB3A6C30
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7AB3A6DD0
        public void WriteValueIntoState(){} // RVA: 0x7AB39DB20
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7AB3A6FD0
        public void CompareValue(){} // RVA: 0x7AB3A71E0
        public void ProcessValue(){} // RVA: 0x7AB3A73D0
        public void TryGetProcessor(){} // RVA: 0x7A8051B10
        public void AddProcessor(){} // RVA: 0x7AB39E130
        public void FinishSetup(){} // RVA: 0x7AB3A74F0
        public void get_processors(){} // RVA: 0x7AB39E530
        public void .ctor(){} // RVA: 0x7AB39E550
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7AB3A8A90
        public void get_valueSizeInBytes(){} // RVA: 0x7A9F26090
        public void get_value(){} // RVA: 0x7AB3A8B40
        public void get_unprocessedValue(){} // RVA: 0x7AB3A8C40
        public void ReadValue(){} // RVA: 0x7AB3A8D90
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7AB3A8DD0
        public void ReadDefaultValue(){} // RVA: 0x7AB3A8F50
        public void ReadValueFromState(){} // RVA: 0x7AB3A9090
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7AB3A9180
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7AB3A9330
        public void ReadUnprocessedValue(){} // RVA: 0x7AB3A9420
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7A80804D0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7AB3A9460
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7AB3A9580
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7AB3A97B0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7AB3A99B0
        public void WriteValueIntoState(){} // RVA: 0x7AB39DB20
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7AB3A9BD0
        public void CompareValue(){} // RVA: 0x7AB3A9E30
        public void ProcessValue(){} // RVA: 0x7AB3AA0D0
        public void TryGetProcessor(){} // RVA: 0x7A8051B10
        public void AddProcessor(){} // RVA: 0x7AB39E130
        public void FinishSetup(){} // RVA: 0x7AB3AA280
        public void get_processors(){} // RVA: 0x7AB39E530
        public void .ctor(){} // RVA: 0x7AB39E550
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7AB3A3E20
        public void get_valueSizeInBytes(){} // RVA: 0x7A883BE70
        public void get_value(){} // RVA: 0x7AB3A3ED0
        public void get_unprocessedValue(){} // RVA: 0x7AB3A3F90
        public void ReadValue(){} // RVA: 0x7AB3A40B0
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7AB3A2C80
        public void ReadDefaultValue(){} // RVA: 0x7AB3A2D90
        public void ReadValueFromState(){} // RVA: 0x7AB3A2E70
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7AB3A40D0
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7AB3A4200
        public void ReadUnprocessedValue(){} // RVA: 0x7AB3A42C0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7A80804D0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7AB3A30F0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7AB3A31B0
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7AB3A3360
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7AB3A42D0
        public void WriteValueIntoState(){} // RVA: 0x7AB39DB20
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7AB3A36E0
        public void CompareValue(){} // RVA: 0x7AB3A39A0
        public void ProcessValue(){} // RVA: 0x7AB3A3B40
        public void TryGetProcessor(){} // RVA: 0x7A8051B10
        public void AddProcessor(){} // RVA: 0x7AB39E130
        public void FinishSetup(){} // RVA: 0x7AB3A44C0
        public void get_processors(){} // RVA: 0x7AB39E530
        public void .ctor(){} // RVA: 0x7AB39E550
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7AB3A46C0
        public void get_valueSizeInBytes(){} // RVA: 0x7A9F261E0
        public void get_value(){} // RVA: 0x7AB3A4770
        public void get_unprocessedValue(){} // RVA: 0x7AB3A4890
        public void ReadValue(){} // RVA: 0x7AB3A49F0
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7AB3A4A30
        public void ReadDefaultValue(){} // RVA: 0x7AB3A4BC0
        public void ReadValueFromState(){} // RVA: 0x7AB3A4D10
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7AB3A4E10
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7AB3A4FD0
        public void ReadUnprocessedValue(){} // RVA: 0x7AB3A50C0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7A80804D0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7AB3A5100
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7AB3A5230
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7AB3A5450
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7AB3A5660
        public void WriteValueIntoState(){} // RVA: 0x7AB39DB20
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7AB3A5880
        public void CompareValue(){} // RVA: 0x7AB3A5AF0
        public void ProcessValue(){} // RVA: 0x7AB3A5DC0
        public void TryGetProcessor(){} // RVA: 0x7A8051B10
        public void AddProcessor(){} // RVA: 0x7AB39E130
        public void FinishSetup(){} // RVA: 0x7AB3A5F90
        public void get_processors(){} // RVA: 0x7AB39E530
        public void .ctor(){} // RVA: 0x7AB39E550
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7AB39CC10
        public void get_valueSizeInBytes(){} // RVA: 0x7A9F22B70
        public void get_value(){} // RVA: 0x7AB39CCC0
        public void get_unprocessedValue(){} // RVA: 0x7AB39CD90
        public void ReadValue(){} // RVA: 0x7AB39CEC0
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7AB39CEF0
        public void ReadDefaultValue(){} // RVA: 0x7AB39D040
        public void ReadValueFromState(){} // RVA: 0x7AB39D150
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7AB39D210
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7AB39D370
        public void ReadUnprocessedValue(){} // RVA: 0x7AB39D450
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7A80804D0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7AB39D480
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7AB39D560
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7AB39D750
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7AB39D910
        public void WriteValueIntoState(){} // RVA: 0x7AB39DB20
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7AB39DB90
        public void CompareValue(){} // RVA: 0x7AB39DDC0
        public void ProcessValue(){} // RVA: 0x7AB39DFE0
        public void TryGetProcessor(){} // RVA: 0x7A8051B10
        public void AddProcessor(){} // RVA: 0x7AB39E130
        public void FinishSetup(){} // RVA: 0x7AB39E330
        public void get_processors(){} // RVA: 0x7AB39E530
        public void .ctor(){} // RVA: 0x7AB39E550
    }

    public class InputControl`1 : InputControl
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7AB3A0E10
        public void get_valueSizeInBytes(){} // RVA: 0x7A9F26190
        public void get_value(){} // RVA: 0x7AB3A0EC0
        public void get_unprocessedValue(){} // RVA: 0x7AB3A0FF0
        public void ReadValue(){} // RVA: 0x7AB3A1160
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7AB3A11B0
        public void ReadDefaultValue(){} // RVA: 0x7AB3A1350
        public void ReadValueFromState(){} // RVA: 0x7AB3A14B0
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7AB3A15C0
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7AB3A17A0
        public void ReadUnprocessedValue(){} // RVA: 0x7AB3A18A0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7A80804D0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7AB3A18F0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7AB3A1A40
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7AB3A1C80
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7AB3A1E70
        public void WriteValueIntoState(){} // RVA: 0x7AB39DB20
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7AB3A20A0
        public void CompareValue(){} // RVA: 0x7AB3A2300
        public void ProcessValue(){} // RVA: 0x7AB3A25F0
        public void TryGetProcessor(){} // RVA: 0x7A8051B10
        public void AddProcessor(){} // RVA: 0x7AB39E130
        public void FinishSetup(){} // RVA: 0x7AB3A27E0
        public void get_processors(){} // RVA: 0x7AB39E530
        public void .ctor(){} // RVA: 0x7AB39E550
    }

    public class InputDevice : InputControl
    {
        // ── Methods ──
        public void get_description(){} // RVA: 0x7AEBE7340
        public void get_enabled(){} // RVA: 0x7AEBE7380
        public void get_canRunInBackground(){} // RVA: 0x7AEBE73A0
        public void get_canDeviceRunInBackground(){} // RVA: 0x7AEBE73A0
        public void get_added(){} // RVA: 0x7AEBE7470
        public void get_remote(){} // RVA: 0x7AEBE7480
        public void get_native(){} // RVA: 0x7AEBE7490
        public void get_updateBeforeRender(){} // RVA: 0x7AEBE74A0
        public void get_deviceId(){} // RVA: 0x7A9AAEF60
        public void get_lastUpdateTime(){} // RVA: 0x7AEBE74B0
        public void get_wasUpdatedThisFrame(){} // RVA: 0x7AEBE7500
        public void get_allControls(){} // RVA: 0x7AEBE7550
        public void get_valueType(){} // RVA: 0x7AEBE7620
        public void get_valueSizeInBytes(){} // RVA: 0x7AEBE76D0
        public void get_all(){} // RVA: 0x7AEBE7760
        public void .ctor(){} // RVA: 0x7AEBE7810
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7AEBE7880
        public void ReadValueFromStateAsObject(){} // RVA: 0x7AEBE78C0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7AEBE7A10
        public void CompareValue(){} // RVA: 0x7AEBE7C10
        public void NotifyConfigurationChanged(){} // RVA: 0x7AEBE7D80
        public void MakeCurrent(){} // RVA: 0x7A80D7310
        public void OnAdded(){} // RVA: 0x7A80D7310
        public void OnRemoved(){} // RVA: 0x7A80D7310
        public void OnConfigurationChanged(){} // RVA: 0x7A80D7310
        public void ExecuteCommand(){} // RVA: 0x7AA4D7430
        public void QueryEnabledStateFromRuntime(){} // RVA: 0x7AEBE7E90
        public void get_disabledInFrontend(){} // RVA: 0x7AEBE7F50
        public void set_disabledInFrontend(){} // RVA: 0x7AEBE7F60
        public void get_disabledInRuntime(){} // RVA: 0x7AEBE7F80
        public void set_disabledInRuntime(){} // RVA: 0x7AEBE7F90
        public void get_disabledWhileInBackground(){} // RVA: 0x7AEBE7FC0
        public void set_disabledWhileInBackground(){} // RVA: 0x7AEBE7FD0
        public void EncodeStateOffsetToControlMapEntry(){} // RVA: 0x7AEBE8000
        public void DecodeStateOffsetToControlMapEntry(){} // RVA: 0x7AEBE8010
        public void get_hasControlsWithDefaultState(){} // RVA: 0x7AEBE8030
        public void set_hasControlsWithDefaultState(){} // RVA: 0x7AEBE8040
        public void get_hasDontResetControls(){} // RVA: 0x7AEBE8060
        public void set_hasDontResetControls(){} // RVA: 0x7AEBE8070
        public void get_hasStateCallbacks(){} // RVA: 0x7AEBE80A0
        public void set_hasStateCallbacks(){} // RVA: 0x7AEBE80B0
        public void get_hasEventMerger(){} // RVA: 0x7AEBE80D0
        public void set_hasEventMerger(){} // RVA: 0x7AEBE80E0
        public void get_hasEventPreProcessor(){} // RVA: 0x7AEBE8110
        public void set_hasEventPreProcessor(){} // RVA: 0x7AEBE8120
        public void AddDeviceUsage(){} // RVA: 0x7AEBE8150
        public void RemoveDeviceUsage(){} // RVA: 0x7AEBE8210
        public void ClearDeviceUsages(){} // RVA: 0x7AEBE8400
        public void RequestSync(){} // RVA: 0x7AEBE8470
        public void RequestReset(){} // RVA: 0x7AEBE8500
        public void ExecuteEnableCommand(){} // RVA: 0x7AEBE8590
        public void ExecuteDisableCommand(){} // RVA: 0x7AEBE8620
        public void NotifyAdded(){} // RVA: 0x7A95E9DD0
        public void NotifyRemoved(){} // RVA: 0x7AB65E3A0
        public void Build(){} // RVA: 0x7AA4D4A90
        public void WriteChangedControlStates(){} // RVA: 0x7AEBE8690
        public void WritePartialChangedControlStatesInternal(){} // RVA: 0x7AEBE8810
        public void DumpControlBitRangeNode(){} // RVA: 0x7AEBE8C70
        public void DumpControlTree(){} // RVA: 0x7AEBE9310
        public void WriteChangedControlStatesInternal(){} // RVA: 0x7AEBE93F0
        public void HasDataChangedInRange(){} // RVA: 0x7AEBE99D0
    }

    public class InputDevice[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputExtensions : Object
    {
        // ── Methods ──
        public void IsInProgress(){} // RVA: 0x7ADD47E30
        public void IsEndedOrCanceled(){} // RVA: 0x7AEC4FFF0
        public void IsActive(){} // RVA: 0x7AEC50000
        public void IsModifierKey(){} // RVA: 0x7AEC50020
        public void IsTextInputKey(){} // RVA: 0x7AEC50030
    }

    public class InputInteraction : Object
    {
        // ── Methods ──
        public void GetValueType(){} // RVA: 0x7AEB6FEE0
        public void GetDisplayName(){} // RVA: 0x7AEB700C0
    }

    public class InputInteractionContext : ValueType
    {
        // ── Methods ──
        public void get_action(){} // RVA: 0x7A7EB0770
        public void get_control(){} // RVA: 0x7A7EB07A0
        public void get_phase(){} // RVA: 0x7A76D1F70
        public void get_time(){} // RVA: 0x7A7EB07F0
        public void get_startTime(){} // RVA: 0x7A7EB0800
        public void get_timerHasExpired(){} // RVA: 0x7A7EAFE70
        public void set_timerHasExpired(){} // RVA: 0x7A7EAFE80
        public void get_isWaiting(){} // RVA: 0x7A7EB0810
        public void get_isStarted(){} // RVA: 0x7A7EB0820
        public void ComputeMagnitude(){} // RVA: 0x7A76870B0
        public void ControlIsActuated(){} // RVA: 0x7A7EB0830
        public void Started(){} // RVA: 0x7A7EB0840
        public void Performed(){} // RVA: 0x7A7EB0890
        public void PerformedAndStayStarted(){} // RVA: 0x7A7EB08F0
        public void PerformedAndStayPerformed(){} // RVA: 0x7A7EB0950
        public void Canceled(){} // RVA: 0x7A7EB09A0
        public void Waiting(){} // RVA: 0x7A7EB09F0
        public void SetTimeout(){} // RVA: 0x7A7EB0A40
        public void SetTotalTimeoutCompletionTime(){} // RVA: 0x7A7EB0A70
        public void ReadValue(){} // RVA: 0x7A8051B10
        public void get_mapIndex(){} // RVA: 0x7A7EB0A80
        public void get_controlIndex(){} // RVA: 0x7A7EB0A90
        public void get_bindingIndex(){} // RVA: 0x7A7EB0AB0
        public void get_interactionIndex(){} // RVA: 0x7A7EB0AC0
    }

    public class InputManager : Object
    {
        // ── Methods ──
        public void get_devices(){} // RVA: 0x7AEC50050
        public void get_processors(){} // RVA: 0x7A81A0050
        public void get_interactions(){} // RVA: 0x7A8175DF0
        public void get_composites(){} // RVA: 0x7A8153390
        public void get_metrics(){} // RVA: 0x7AEC50100
        public void get_settings(){} // RVA: 0x7A8B55F70
        public void set_settings(){} // RVA: 0x7AEC50360
        public void get_actions(){} // RVA: 0x7A8B59C40
        public void set_actions(){} // RVA: 0x7AEC50580
        public void get_updateMask(){} // RVA: 0x7A8A69800
        public void set_updateMask(){} // RVA: 0x7AEC505E0
        public void get_defaultUpdateType(){} // RVA: 0x7AEC50600
        public void get_scrollDeltaBehavior(){} // RVA: 0x7A9AAEF70
        public void set_scrollDeltaBehavior(){} // RVA: 0x7AEC50640
        public void get_pollingFrequency(){} // RVA: 0x7A82023E0
        public void set_pollingFrequency(){} // RVA: 0x7AEC50650
        public void add_onDeviceChange(){} // RVA: 0x7AEC50730
        public void remove_onDeviceChange(){} // RVA: 0x7AEC50790
        public void add_onDeviceStateChange(){} // RVA: 0x7AEC507F0
        public void remove_onDeviceStateChange(){} // RVA: 0x7AEC50850
        public void add_onDeviceCommand(){} // RVA: 0x7AEC508B0
        public void remove_onDeviceCommand(){} // RVA: 0x7AEC50910
        public void add_onFindControlLayoutForDevice(){} // RVA: 0x7AEC50970
        public void remove_onFindControlLayoutForDevice(){} // RVA: 0x7AEC509D0
        public void add_onLayoutChange(){} // RVA: 0x7AEC50A30
        public void remove_onLayoutChange(){} // RVA: 0x7AEC50A90
        public void add_onEvent(){} // RVA: 0x7AEC50AF0
        public void remove_onEvent(){} // RVA: 0x7AEC50B50
        public void add_onBeforeUpdate(){} // RVA: 0x7AEC50BB0
        public void remove_onBeforeUpdate(){} // RVA: 0x7AEC50C10
        public void add_onAfterUpdate(){} // RVA: 0x7AEC50C70
        public void remove_onAfterUpdate(){} // RVA: 0x7AEC50CD0
        public void add_onSettingsChange(){} // RVA: 0x7AEC50D30
        public void remove_onSettingsChange(){} // RVA: 0x7AEC50D90
        public void add_onActionsChange(){} // RVA: 0x7AEC50DF0
        public void remove_onActionsChange(){} // RVA: 0x7AEC50E50
        public void get_isProcessingEvents(){} // RVA: 0x7AEC50EB0
        public void get_gameIsPlaying(){} // RVA: 0x7A81BD750
        public void get_gameHasFocus(){} // RVA: 0x7AEC50EC0
        public void get_gameShouldGetInputRegardlessOfFocus(){} // RVA: 0x7AEC50F00
        public void RegisterControlLayout(){} // RVA: 0x7AEC51790
        public void RegisterControlLayoutBuilder(){} // RVA: 0x7AEC51FC0
        public void PerformLayoutPostRegistration(){} // RVA: 0x7AEC52280
        public void RegisterPrecompiledLayout(){} // RVA: 0x7AA4D9780
        public void RecreateDevicesUsingLayout(){} // RVA: 0x7AEC52AC0
        public void IsControlOrChildUsingLayoutRecursive(){} // RVA: 0x7AEC52D20
        public void IsControlUsingLayout(){} // RVA: 0x7AEC52E20
        public void RegisterControlLayoutMatcher(){} // RVA: 0x7AEC53170
        public void RecreateDevicesUsingLayoutWithInferiorMatch(){} // RVA: 0x7AEC533C0
        public void RecreateDevice(){} // RVA: 0x7AEC53710
        public void AddAvailableDevicesMatchingDescription(){} // RVA: 0x7AEC53960
        public void RemoveControlLayout(){} // RVA: 0x7AEC53DF0
        public void TryLoadControlLayout(){} // RVA: 0x7AEC54420
        public void TryFindMatchingControlLayout(){} // RVA: 0x7AEC54450
        public void FindOrRegisterDeviceLayoutForType(){} // RVA: 0x7AEC54A30
        public void IsDeviceLayoutMarkedAsSupportedInSettings(){} // RVA: 0x7AEC54AE0
        public void ListControlLayouts(){} // RVA: 0x7AEC54C20
        public void GetControls(){} // RVA: 0x7AA4D9540
        public void SetDeviceUsage(){} // RVA: 0x7AEC54D30
        public void AddDeviceUsage(){} // RVA: 0x7AEC55000
        public void RemoveDeviceUsage(){} // RVA: 0x7AEC55160
        public void NotifyUsageChanged(){} // RVA: 0x7AEC552C0
        public void AddDevice(){} // RVA: 0x7AEC566C0
        public void RemoveDevice(){} // RVA: 0x7AEC56810
        public void FlushDisconnectedDevices(){} // RVA: 0x7AEC570D0
        public void ResetDevice(){} // RVA: 0x7AEC57130
        public void TryGetDevice(){} // RVA: 0x7AEC57AE0
        public void GetDevice(){} // RVA: 0x7AEC57A40
        public void TryGetDeviceById(){} // RVA: 0x7AEC57B70
        public void GetUnsupportedDevices(){} // RVA: 0x7AEC57BF0
        public void EnableOrDisableDevice(){} // RVA: 0x7AEC57DD0
        public void QueueEvent(){} // RVA: 0x7A7E18800
        public void Update(){} // RVA: 0x7AEC582F0
        public void Initialize(){} // RVA: 0x7AEC58350
        public void Destroy(){} // RVA: 0x7AEC58500
        public void InitializeActions(){} // RVA: 0x7AEC58740
        public void InitializeData(){} // RVA: 0x7AEC58830
        public void RegisterCustomTypes(){} // RVA: 0x7AEC5B050
        public void InstallRuntime(){} // RVA: 0x7AEC5B320
        public void InstallGlobals(){} // RVA: 0x7AEC5B740
        public void UninstallGlobals(){} // RVA: 0x7AEC5BBF0
        public void get_optimizedControlsFeatureEnabled(){} // RVA: 0x7AEC5BE80
        public void set_optimizedControlsFeatureEnabled(){} // RVA: 0x7AEC5BE90
        public void get_readValueCachingFeatureEnabled(){} // RVA: 0x7AEC5BEA0
        public void set_readValueCachingFeatureEnabled(){} // RVA: 0x7AEC5BEB0
        public void get_paranoidReadValueCachingChecksEnabled(){} // RVA: 0x7AEC5BEC0
        public void set_paranoidReadValueCachingChecksEnabled(){} // RVA: 0x7AEC5BED0
        public void MakeDeviceNameUnique(){} // RVA: 0x7AEC5BEE0
        public void ResetControlPathsRecursive(){} // RVA: 0x7AEC5C1F0
        public void AssignUniqueDeviceId(){} // RVA: 0x7AEC5C330
        public void ReallocateStateBuffers(){} // RVA: 0x7AEC5C4A0
        public void InitializeDefaultState(){} // RVA: 0x7AEC5C780
        public void InitializeDeviceState(){} // RVA: 0x7AEC5C970
        public void OnNativeDeviceDiscovered(){} // RVA: 0x7AEC5CC90
        public void MakeEscapedJsonString(){} // RVA: 0x7AEC5D210
        public void TryMatchDisconnectedDevice(){} // RVA: 0x7AEC5D570
        public void InstallBeforeUpdateHookIfNecessary(){} // RVA: 0x7AEC5D8D0
        public void RestoreDevicesAfterDomainReloadIfNecessary(){} // RVA: 0x7A80D7310
        public void WarnAboutDevicesFailingToRecreateAfterDomainReload(){} // RVA: 0x7A80D7310
        public void OnBeforeUpdate(){} // RVA: 0x7AEC5D990
        public void ApplySettings(){} // RVA: 0x7AEC5DCC0
        public void ApplyActions(){} // RVA: 0x7AEC5E640
        public void ExecuteGlobalCommand(){} // RVA: 0x7A7E00B20
        public void AddAvailableDevicesThatAreNowRecognized(){} // RVA: 0x7AEC5E6D0
        public void ShouldRunDeviceInBackground(){} // RVA: 0x7AEC5E9D0
        public void OnFocusChanged(){} // RVA: 0x7AEC5EA10
        public void ShouldRunUpdate(){} // RVA: 0x7AEC5EC50
        public void OnUpdate(){} // RVA: 0x7AEC5EC70
        public void AreMaximumEventBytesPerUpdateExceeded(){} // RVA: 0x7AEC5FFD0
        public void MakeStringWithEventsProcessedByDevice(){} // RVA: 0x7AEC60140
        public void ResetCurrentProcessedEventBytesForDevices(){} // RVA: 0x7AEC60320
        public void CheckAllDevicesOptimizedControlsHaveValidState(){} // RVA: 0x7AEC60400
        public void InvokeAfterUpdateCallback(){} // RVA: 0x7AEC60600
        public void DontMakeCurrentlyUpdatingDeviceCurrent(){} // RVA: 0x7AEC606A0
        public void UpdateState(){} // RVA: 0x7AEC607C0
        public void WriteStateChange(){} // RVA: 0x7AEC60F00
        public void FlipBuffersForDeviceIfNecessary(){} // RVA: 0x7AEC612B0
        public void AddStateChangeMonitor(){} // RVA: 0x7AEC61360
        public void RemoveStateChangeMonitors(){} // RVA: 0x7AEC61510
        public void RemoveStateChangeMonitor(){} // RVA: 0x7AEC61710
        public void AddStateChangeMonitorTimeout(){} // RVA: 0x7AEC61960
        public void RemoveStateChangeMonitorTimeout(){} // RVA: 0x7AEC61AF0
        public void SortStateChangeMonitorsIfNecessary(){} // RVA: 0x7AEC61C80
        public void SignalStateChangeMonitor(){} // RVA: 0x7AEC61CD0
        public void FireStateChangeNotifications(){} // RVA: 0x7AEC62340
        public void ProcessStateChangeMonitors(){} // RVA: 0x7AEC61EF0
        public void ProcessStateChangeMonitorTimeouts(){} // RVA: 0x7AEC62740
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AEC62A90
        public void <TryFindMatchingControlLayout>b__94_0(){} // RVA: 0x7AEC630F0
    }

    public class InputProcessor : Object
    {
        // ── Methods ──
        public void ProcessAsObject(){} // RVA: 0x7A7E00BD0
        public void Process(){} // RVA: 0x7A8051B10
        public void GetValueTypeFromType(){} // RVA: 0x7AEBE62B0
        public void get_cachingPolicy(){} // RVA: 0x7A82D1450
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class InputProcessor[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7A8051B10
        public void ProcessAsObject(){} // RVA: 0x7A7E00BD0
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7AB3B1970
        public void ProcessAsObject(){} // RVA: 0x7AB3B1760
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7AB3B0DB0
        public void ProcessAsObject(){} // RVA: 0x7AB3B0BA0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7AB3B0580
        public void ProcessAsObject(){} // RVA: 0x7AB3B0370
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7AB3B2150
        public void ProcessAsObject(){} // RVA: 0x7AB3B1F30
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7AB3B2510
        public void ProcessAsObject(){} // RVA: 0x7AB3B22D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7AB3B15B0
        public void ProcessAsObject(){} // RVA: 0x7AB3B1390
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7AB3B1D50
        public void ProcessAsObject(){} // RVA: 0x7AB3B1AF0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7AB3B0DB0
        public void ProcessAsObject(){} // RVA: 0x7AB3B0BA0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7A7E00C90
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7A7E00C90
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7A7E00C90
    }

    public class InputProcessor`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputProcessor`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputProcessor`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputProcessor`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputProcessor`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputProcessor`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputRemoting : Object
    {
        // ── Methods ──
        public void get_sending(){} // RVA: 0x7ADD21F90
        public void set_sending(){} // RVA: 0x7AEC46620
        public void .ctor(){} // RVA: 0x7AEC46640
        public void StartSending(){} // RVA: 0x7AEC46700
        public void StopSending(){} // RVA: 0x7AEC46900
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(){} // RVA: 0x7AEC46AE0
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(){} // RVA: 0x7A80D7310
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted(){} // RVA: 0x7A80D7310
        public void Subscribe(){} // RVA: 0x7AEC46D70
        public void SendInitialMessages(){} // RVA: 0x7AEC46EF0
        public void SendAllGeneratedLayouts(){} // RVA: 0x7AEC46F10
        public void SendLayout(){} // RVA: 0x7AEC471A0
        public void SendAllDevices(){} // RVA: 0x7AEC47240
        public void SendDevice(){} // RVA: 0x7AEC47490
        public void SendEvent(){} // RVA: 0x7AEC47520
        public void SendDeviceChange(){} // RVA: 0x7AEC47570
        public void SendLayoutChange(){} // RVA: 0x7AEC47700
        public void Send(){} // RVA: 0x7AEC47860
        public void FindOrCreateSenderRecord(){} // RVA: 0x7AEC479A0
        public void BuildLayoutNamespace(){} // RVA: 0x7AEC47A60
        public void FindLocalDeviceId(){} // RVA: 0x7AEC47B30
        public void TryGetDeviceByRemoteId(){} // RVA: 0x7AEC47BB0
        public void get_manager(){} // RVA: 0x7A80DA7B0
        public void RemoveRemoteDevices(){} // RVA: 0x7AEC47BE0
        public void SerializeData(){} // RVA: 0x7A8051B10
        public void DeserializeData(){} // RVA: 0x7A8051B10
    }

    public class InputSettings : ScriptableObject
    {
        // ── Methods ──
        public void get_updateMode(){} // RVA: 0x7A851DB90
        public void set_updateMode(){} // RVA: 0x7AEC65A50
        public void get_scrollDeltaBehavior(){} // RVA: 0x7A8AB15F0
        public void set_scrollDeltaBehavior(){} // RVA: 0x7AEC65A60
        public void get_compensateForScreenOrientation(){} // RVA: 0x7A80FD690
        public void set_compensateForScreenOrientation(){} // RVA: 0x7AEC65A70
        public void get_filterNoiseOnCurrent(){} // RVA: 0x7A80D7320
        public void set_filterNoiseOnCurrent(){} // RVA: 0x7A80D7310
        public void get_defaultDeadzoneMin(){} // RVA: 0x7A85D5650
        public void set_defaultDeadzoneMin(){} // RVA: 0x7AEC65A80
        public void get_defaultDeadzoneMax(){} // RVA: 0x7A80DF900
        public void set_defaultDeadzoneMax(){} // RVA: 0x7AEC65AA0
        public void get_defaultButtonPressPoint(){} // RVA: 0x7A8C85980
        public void set_defaultButtonPressPoint(){} // RVA: 0x7AEC65AC0
        public void get_buttonReleaseThreshold(){} // RVA: 0x7A8AD0680
        public void set_buttonReleaseThreshold(){} // RVA: 0x7AEC65B00
        public void get_defaultTapTime(){} // RVA: 0x7A813FA00
        public void set_defaultTapTime(){} // RVA: 0x7AEC65B20
        public void get_defaultSlowTapTime(){} // RVA: 0x7A861F990
        public void set_defaultSlowTapTime(){} // RVA: 0x7AEC65B40
        public void get_defaultHoldTime(){} // RVA: 0x7A8100220
        public void set_defaultHoldTime(){} // RVA: 0x7AEC65B60
        public void get_tapRadius(){} // RVA: 0x7A8100240
        public void set_tapRadius(){} // RVA: 0x7AEC65B80
        public void get_multiTapDelayTime(){} // RVA: 0x7A81E8E60
        public void set_multiTapDelayTime(){} // RVA: 0x7AEC65BA0
        public void get_backgroundBehavior(){} // RVA: 0x7A82C2070
        public void set_backgroundBehavior(){} // RVA: 0x7AEC65BC0
        public void get_editorInputBehaviorInPlayMode(){} // RVA: 0x7A8D863F0
        public void set_editorInputBehaviorInPlayMode(){} // RVA: 0x7AEC65BD0
        public void get_inputActionPropertyDrawerMode(){} // RVA: 0x7A864E8D0
        public void set_inputActionPropertyDrawerMode(){} // RVA: 0x7AEC65BE0
        public void get_maxEventBytesPerUpdate(){} // RVA: 0x7A854FDE0
        public void set_maxEventBytesPerUpdate(){} // RVA: 0x7AEC65BF0
        public void get_maxQueuedEventsPerUpdate(){} // RVA: 0x7A8F9ACE0
        public void set_maxQueuedEventsPerUpdate(){} // RVA: 0x7AEC65C00
        public void get_supportedDevices(){} // RVA: 0x7AEC65C10
        public void set_supportedDevices(){} // RVA: 0x7AEC65CD0
        public void get_disableRedundantEventsMerging(){} // RVA: 0x7A9250CD0
        public void set_disableRedundantEventsMerging(){} // RVA: 0x7AEC65EA0
        public void get_shortcutKeysConsumeInput(){} // RVA: 0x7AE4F7C60
        public void set_shortcutKeysConsumeInput(){} // RVA: 0x7AEC65EB0
        public void SetInternalFeatureFlag(){} // RVA: 0x7AEC65EC0
        public void IsFeatureEnabled(){} // RVA: 0x7AEC66080
        public void OnChange(){} // RVA: 0x7AEC66100
        public void CompareFloats(){} // RVA: 0x7AEC66280
        public void CompareSets(){} // RVA: 0x7A8051B10
        public void CompareFeatureFlag(){} // RVA: 0x7AEC662A0
        public void AreEqual(){} // RVA: 0x7AEC66390
        public void .ctor(){} // RVA: 0x7AEC66B00
    }

    public class InputSettings[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputSystem : Object
    {
        // ── Methods ──
        public void add_onLayoutChange(){} // RVA: 0x7AEBD1590
        public void remove_onLayoutChange(){} // RVA: 0x7AEBD1750
        public void RegisterLayout(){} // RVA: 0x7AA4DE2D0
        public void RegisterLayoutOverride(){} // RVA: 0x7AEBD1BC0
        public void RegisterLayoutMatcher(){} // RVA: 0x7AA4DE530
        public void RegisterLayoutBuilder(){} // RVA: 0x7AEBD1CD0
        public void RegisterPrecompiledLayout(){} // RVA: 0x7A7E18830
        public void RemoveLayout(){} // RVA: 0x7AEBD1EA0
        public void TryFindMatchingLayout(){} // RVA: 0x7AEBD1F10
        public void ListLayouts(){} // RVA: 0x7AEBD1FE0
        public void ListLayoutsBasedOn(){} // RVA: 0x7AEBD2050
        public void LoadLayout(){} // RVA: 0x7A7E006B0
        public void GetNameOfBaseLayout(){} // RVA: 0x7AEBD2220
        public void IsFirstLayoutBasedOnSecond(){} // RVA: 0x7AEBD2420
        public void RegisterProcessor(){} // RVA: 0x7A7E18830
        public void TryGetProcessor(){} // RVA: 0x7AEBD2A90
        public void ListProcessors(){} // RVA: 0x7AEBD2B70
        public void get_devices(){} // RVA: 0x7AEBD2BF0
        public void get_disconnectedDevices(){} // RVA: 0x7AEBD2C70
        public void add_onDeviceChange(){} // RVA: 0x7AEBD2D60
        public void remove_onDeviceChange(){} // RVA: 0x7AEBD2F80
        public void add_onDeviceCommand(){} // RVA: 0x7AEBD31A0
        public void remove_onDeviceCommand(){} // RVA: 0x7AEBD33C0
        public void add_onFindLayoutForDevice(){} // RVA: 0x7AEBD35E0
        public void remove_onFindLayoutForDevice(){} // RVA: 0x7AEBD37B0
        public void get_pollingFrequency(){} // RVA: 0x7AEBD3970
        public void set_pollingFrequency(){} // RVA: 0x7AEBD39E0
        public void AddDevice(){} // RVA: 0x7AEBD3D70
        public void RemoveDevice(){} // RVA: 0x7AEBD3E30
        public void FlushDisconnectedDevices(){} // RVA: 0x7AEBD3EB0
        public void GetDevice(){} // RVA: 0x7A8051B10
        public void GetDeviceById(){} // RVA: 0x7AEBD42C0
        public void GetUnsupportedDevices(){} // RVA: 0x7AEBD43C0
        public void EnableDevice(){} // RVA: 0x7AEBD45F0
        public void DisableDevice(){} // RVA: 0x7AEBD4670
        public void TrySyncDevice(){} // RVA: 0x7AEBD4700
        public void ResetDevice(){} // RVA: 0x7AEBD47D0
        public void TryResetDevice(){} // RVA: 0x7AEBD4860
        public void PauseHaptics(){} // RVA: 0x7AEBD48D0
        public void ResumeHaptics(){} // RVA: 0x7AEBD4A20
        public void ResetHaptics(){} // RVA: 0x7AEBD4B70
        public void SetDeviceUsage(){} // RVA: 0x7AEBD4DB0
        public void AddDeviceUsage(){} // RVA: 0x7AEBD4F00
        public void RemoveDeviceUsage(){} // RVA: 0x7AEBD5050
        public void FindControl(){} // RVA: 0x7AEBD50E0
        public void FindControls(){} // RVA: 0x7AA4DCB00
        public void get_isProcessingEvents(){} // RVA: 0x7AEBD5420
        public void get_onEvent(){} // RVA: 0x7A80D7320
        public void set_onEvent(){} // RVA: 0x7A80D7310
        public void get_onAnyButtonPress(){} // RVA: 0x7AEBD5490
        public void QueueEvent(){} // RVA: 0x7A7E18830
        public void QueueStateEvent(){} // RVA: 0x7A8051B10
        public void QueueDeltaStateEvent(){} // RVA: 0x7A8051B10
        public void QueueConfigChangeEvent(){} // RVA: 0x7AEBD5B70
        public void QueueTextEvent(){} // RVA: 0x7AEBD5DC0
        public void Update(){} // RVA: 0x7AEBD6110
        public void add_onBeforeUpdate(){} // RVA: 0x7AEBD62C0
        public void remove_onBeforeUpdate(){} // RVA: 0x7AEBD6490
        public void add_onAfterUpdate(){} // RVA: 0x7AEBD6650
        public void remove_onAfterUpdate(){} // RVA: 0x7AEBD6810
        public void get_settings(){} // RVA: 0x7AEBD69D0
        public void set_settings(){} // RVA: 0x7AEBD6A40
        public void add_onSettingsChange(){} // RVA: 0x7AEBD6C80
        public void remove_onSettingsChange(){} // RVA: 0x7AEBD6D30
        public void EnableActions(){} // RVA: 0x7AEBD6DE0
        public void DisableActions(){} // RVA: 0x7AEBD6F00
        public void get_actions(){} // RVA: 0x7AEBD7010
        public void set_actions(){} // RVA: 0x7AEBD7080
        public void add_onActionsChange(){} // RVA: 0x7AEBD72E0
        public void remove_onActionsChange(){} // RVA: 0x7AEBD7390
        public void add_onActionChange(){} // RVA: 0x7AEBD7440
        public void remove_onActionChange(){} // RVA: 0x7AEBD7510
        public void RegisterInteraction(){} // RVA: 0x7A7E18830
        public void TryGetInteraction(){} // RVA: 0x7AEBD7770
        public void ListInteractions(){} // RVA: 0x7AEBD7850
        public void RegisterBindingComposite(){} // RVA: 0x7A7E18830
        public void TryGetBindingComposite(){} // RVA: 0x7AEBD7A60
        public void DisableAllEnabledActions(){} // RVA: 0x7AEBD7B40
        public void ListEnabledActions(){} // RVA: 0x7AEBD7E40
        public void get_remoting(){} // RVA: 0x7AEBD7EE0
        public void get_version(){} // RVA: 0x7AEBD7F40
        public void get_runInBackground(){} // RVA: 0x7AEBD8070
        public void set_runInBackground(){} // RVA: 0x7AEBD8100
        public void get_metrics(){} // RVA: 0x7AEBD81A0
        public void .cctor(){} // RVA: 0x7AEBD8240
        public void RunInitializeInPlayer(){} // RVA: 0x7AEBD82F0
        public void EnsureInitialized(){} // RVA: 0x7A80D7310
        public void InitializeInPlayer(){} // RVA: 0x7AEBD8370
        public void RunInitialUpdate(){} // RVA: 0x7AEBD8870
        public void PerformDefaultPluginInitialization(){} // RVA: 0x7AEBD88C0
    }

    public class InputValue : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7A8051B10
        public void get_isPressed(){} // RVA: 0x7AEC6BDE0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}