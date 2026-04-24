// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 19
// Methods: 144

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class UIDocument : MonoBehaviour
    {
        public object panelSettings;
        public object parentUI;
        public object visualTreeAsset;
        public object rootVisualElement;
        public object firstChildInserIndex;
        public object sortingOrder;

        // ── Methods ──
        public void get_panelSettings(){} // RVA: 0x7FFD54CFDAD0
        public void set_panelSettings(){} // RVA: 0x7FFD54FBB260
        public void get_parentUI(){} // RVA: 0x7FFD4E5F0140
        public void set_parentUI(){} // RVA: 0x7FFD4E5F0C20
        public void get_visualTreeAsset(){} // RVA: 0x7FFD54D3F8D0
        public void set_visualTreeAsset(){} // RVA: 0x7FFD54FBB970
        public void get_rootVisualElement(){} // RVA: 0x7FFD54D3F940
        public void get_firstChildInserIndex(){} // RVA: 0x7FFD4E558C20
        public void get_sortingOrder(){} // RVA: 0x7FFD4E36A040
        public void set_sortingOrder(){} // RVA: 0x7FFD54FBB9D0
        public void ApplySortingOrder(){} // RVA: 0x7FFD54FBB9F0
        public void .ctor(){} // RVA: 0x7FFD54FBBA00
        public void Awake(){} // RVA: 0x7FFD54FBBB90
        public void OnEnable(){} // RVA: 0x7FFD54FBBBA0
        public void SetupFromHierarchy(){} // RVA: 0x7FFD54FBBDA0
        public void FindUIDocumentParent(){} // RVA: 0x7FFD54FBC0A0
        public void Reset(){} // RVA: 0x7FFD54FBC240
        public void AddChildAndInsertContentToVisualTree(){} // RVA: 0x7FFD54FBC4E0
        public void RemoveChild(){} // RVA: 0x7FFD54FBC620
        public void RecreateUI(){} // RVA: 0x7FFD54FBC6A0
        public void SetupRootClassList(){} // RVA: 0x7FFD54FBCEF0
        public void AddRootVisualElementToTree(){} // RVA: 0x7FFD54FBD010
        public void RemoveFromHierarchy(){} // RVA: 0x7FFD54FBD200
        public void OnDisable(){} // RVA: 0x7FFD54FBD3F0
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFD54FBD460
        public void OnTransformParentChanged(){} // RVA: 0x7FFD54FBD720
        public void ReactToHierarchyChanged(){} // RVA: 0x7FFD54FBD730
    }

    public class UIElementsRuntimeUtility : Object
    {
        public object activeEventSystem;
        public object useDefaultEventSystem;
        public object defaultEventSystem;

        // ── Methods ──
        public void add_onCreatePanel(){} // RVA: 0x7FFD5503C1F0
        public void remove_onCreatePanel(){} // RVA: 0x7FFD5503C350
        public void .cctor(){} // RVA: 0x7FFD5503C4B0
        public void CreateEvent(){} // RVA: 0x7FFD5503CBB0
        public void FindOrCreateRuntimePanel(){} // RVA: 0x7FFD5503CC60
        public void DisposeRuntimePanel(){} // RVA: 0x7FFD5503CEA0
        public void RegisterCachedPanelInternal(){} // RVA: 0x7FFD5503D1A0
        public void RemoveCachedPanelInternal(){} // RVA: 0x7FFD5503D4B0
        public void RepaintOffscreenPanels(){} // RVA: 0x7FFD5503D710
        public void RepaintOverlayPanel(){} // RVA: 0x7FFD5503D9C0
        public void BeginRenderOverlays(){} // RVA: 0x7FFD5503DC30
        public void RenderOverlaysBeforePriority(){} // RVA: 0x7FFD5503DC90
        public void EndRenderOverlays(){} // RVA: 0x7FFD5503DEB0
        public void get_activeEventSystem(){} // RVA: 0x7FFD5503DF20
        public void set_activeEventSystem(){} // RVA: 0x7FFD5503DF80
        public void get_useDefaultEventSystem(){} // RVA: 0x7FFD5503E040
        public void RegisterEventSystem(){} // RVA: 0x7FFD5503E180
        public void UnregisterEventSystem(){} // RVA: 0x7FFD5503E4A0
        public void get_defaultEventSystem(){} // RVA: 0x7FFD5503E640
        public void UpdateRuntimePanels(){} // RVA: 0x7FFD5503E750
        public void MarkPotentiallyEmpty(){} // RVA: 0x7FFD5503EB20
        public void RemoveUnusedPanels(){} // RVA: 0x7FFD5503EC80
        public void RegisterPlayerloopCallback(){} // RVA: 0x7FFD5503EEB0
        public void UnregisterPlayerloopCallback(){} // RVA: 0x7FFD5503EFD0
        public void SetPanelOrderingDirty(){} // RVA: 0x7FFD5503F0A0
        public void GetSortedPlayerPanels(){} // RVA: 0x7FFD5503F100
        public void SortPanels(){} // RVA: 0x7FFD5503F1A0
        public void MultiDisplayBottomLeftToPanelPosition(){} // RVA: 0x7FFD5503F550
        public void MultiDisplayToLocalScreenPosition(){} // RVA: 0x7FFD5503F6E0
        public void ScreenBottomLeftToPanelPosition(){} // RVA: 0x7FFD5503F8A0
        public void ScreenBottomLeftToPanelDelta(){} // RVA: 0x7FFD5503F9C0
    }

    public class UIElementsRuntimeUtilityNative : Object
    {
        // ── Methods ──
        public void RepaintOverlayPanels(){} // RVA: 0x7FFD54FC6550
        public void UpdateRuntimePanels(){} // RVA: 0x7FFD54FC65B0
        public void RepaintOffscreenPanels(){} // RVA: 0x7FFD54FC6610
        public void RegisterPlayerloopCallback(){} // RVA: 0x7FFD54FC6670
        public void UnregisterPlayerloopCallback(){} // RVA: 0x7FFD54FC66C0
        public void VisualElementCreation(){} // RVA: 0x7FFD54FC6710
    }

    public class UIEventRegistration : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD5503FC90
        public void RegisterUIElementSystem(){} // RVA: 0x7FFD55040620
        public void TakeCapture(){} // RVA: 0x7FFD550406B0
        public void ReleaseCapture(){} // RVA: 0x7FFD55040850
        public void EndContainerGUIFromException(){} // RVA: 0x7FFD550409F0
        public void ProcessEvent(){} // RVA: 0x7FFD55040BE0
        public void CleanupRoots(){} // RVA: 0x7FFD55040E40
        public void MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7FFD55040FE0
    }

    public class UQuery : Object
    {
    }

    public class UQueryBuilder`1 : ValueType
    {
        public object styleSelectors;
        public object parts;

        // ── Methods ──
        public void get_styleSelectors(){} // RVA: 0x7FFD4E078E90
        public void get_parts(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Class(){} // RVA: 0x7FFD4E2ADC40
        public void Name(){} // RVA: 0x7FFD4E2ADC40
        public void SingleBaseType(){} // RVA: 0x7FFD4E2ADC40
        public void AddClass(){} // RVA: 0x7FFD4E090A40
        public void AddName(){} // RVA: 0x7FFD4E090A40
        public void AddPseudoStatesRuleIfNecessasy(){} // RVA: 0x7FFD4E090980
        public void FinishSelector(){} // RVA: 0x7FFD4E090980
        public void CurrentSelectorEmpty(){} // RVA: 0x7FFD4E079D00
        public void FinishCurrentSelector(){} // RVA: 0x7FFD4E090980
        public void Build(){} // RVA: 0x7FFD4E2ADC40
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
    }

    public class UQueryExtensions : Object
    {
        // ── Methods ──
        public void Q(){} // RVA: 0x7FFD55044790 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD55044E60
    }

    public class UQueryState`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void RebuildOn(){} // RVA: 0x7FFD4E2ADC40
        public void Single(){} // RVA: 0x7FFD4E2ADC40
        public void First(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class UxmlAsset : Object
    {
        public object fullTypeName;
        public object id;
        public object orderInDocument;
        public object parentId;

        // ── Methods ──
        public void get_fullTypeName(){} // RVA: 0x7FFD4E35C380
        public void get_id(){} // RVA: 0x7FFD4E577800
        public void get_orderInDocument(){} // RVA: 0x7FFD4F8557F0
        public void get_parentId(){} // RVA: 0x7FFD4E4FBBE0
        public void TryGetAttributeValue(){} // RVA: 0x7FFD5504B100
        public void SetAttribute(){} // RVA: 0x7FFD5504B2E0
        public void SetOrAddProperty(){} // RVA: 0x7FFD5504B2F0
    }

    public class UxmlAttributeDescription : Object
    {
        public string name; // 0x10
        public string[] obsoleteNames; // 0x18
        public string type; // 0x20
        public string typeNamespace; // 0x28
        public ÍÏÎÌÏÌÌÌÍÏÌÌÌÏÌÏÌÌÎ use; // 0x30
        public ÎÏÌÎÎÎÌÌÌ.tyleDataGroup`1 restriction; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5213E3D0
        public void get_name(){} // RVA: 0x7FFD4E35C380
        public void set_name(){} // RVA: 0x7FFD4E342E30
        public void set_obsoleteNames(){} // RVA: 0x7FFD55046F50
        public void set_type(){} // RVA: 0x7FFD4E36F0D0
        public void set_typeNamespace(){} // RVA: 0x7FFD4E342E90
        public void set_use(){} // RVA: 0x7FFD4E39CCE0
        public void set_restriction(){} // RVA: 0x7FFD4E5F0C20
        public void TryGetValueFromBagAsString(){} // RVA: 0x7FFD55047070
        public void TryGetValueFromBag(){} // RVA: 0x7FFD4E2ADC40
        public void GetValueFromBag(){} // RVA: 0x7FFD4E2ADC40
    }

    public class UxmlEnumAttributeDescription`1 : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void GetValueFromBag(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValueFromBag(){} // RVA: 0x7FFD4E2ADC40
        public void ConvertValueToEnum(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumNameErrorMessage(){} // RVA: 0x7FFD4E078FF0
        public void GetEnumRangeErrorMessage(){} // RVA: 0x7FFD4E078FF0
    }

    public class UxmlFactory`1 : UxmlFactory`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD52275C30
        public void .ctor(){} // RVA: 0x7FFD52275CC0
    }

    public class UxmlObjectAttributeDescription`1 : Object
    {
        public object defaultValue;

        // ── Methods ──
        public void get_defaultValue(){} // RVA: 0x7FFD4E35C380
        public void GetValueFromBag(){} // RVA: 0x7FFD52275CE0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UxmlObjectFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFD4E27B230
        public void .ctor(){} // RVA: 0x7FFD51079B40
    }

    public class UxmlObjectListAttributeDescription`1 : UxmlObjectAttributeDescription`1
    {
        // ── Methods ──
        public void GetValueFromBag(){}
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class UxmlObjectTraits`1 : BaseUxmlTraits
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E64C870
    }

    public class UxmlTraits : BaseUxmlTraits
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E64C870
    }

    public class UxmlTypeAttributeDescription`1 : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void GetValueFromBag(){}
        public void ConvertValueToType(){} // RVA: 0x7FFD4E08A6F0
        public void <GetValueFromBag>b__3_0(){} // RVA: 0x7FFD4E08A6F0
    }

}