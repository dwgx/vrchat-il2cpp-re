// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UI
// Classes: 1
// Methods: 111

namespace VRC.UI
{
    /// <summary>Originally: ÍÎÌÎÏÎÌÍÏÍÍÍÌÎÌÎÎÏÍÏÎÎÍ</summary>
    public class VirtualizedScrollLayoutController
    {
        public System.Action`1<UnityEngine.Vector2> ÏÍÏÏÏÍÏÍÍÍÌÎÏÏÏÌÏÍÍÍÎÏÏ; // 0xD0
        public UnityEngine.RectTransform _content; // 0xD8
        public UnityEngine.GameObject _scrollbarPrefab; // 0xE0
        public UnityEngine.Vector2 <ÍÍÏÌÌÏÏÌÎÌÏÎÌÌÎÏÍÍÍÏÍÍÎ>k__BackingField; // 0xE8
        public bool ÌÍÌÎÎÍÍÎÎÌÎÌÍÏÍÏÌÌÎÌÌÎÎ; // 0xF0
        public bool ÎÎÎÍÎÏÌÎÌÏÏÍÍÍÍÏÍÍÌÌÏÌÍ; // 0xF1
        public VRC.UI.Core.Styles.StyleEngine ÏÌÏÏÌÍÎÌÌÍÏÎÏÏÎÎÍÏÎÌÏÍÏ; // 0xF8
        public ÏÎÌÎÌÍÎÍÎÎÏÎÎÏÏÎÎÌÌÎÏÍÎ ÍÍÍÏÏÍÎÏÏÎÎÎÏÎÍÍÌÍÍÏÍÎÍ; // 0x100
        public System.Collections.Generic.List`1<System.ValueTuple`2<object,int>> ÍÏÎÌÎÌÍÏÌÍÎÌÎÌÍÌÎÎÎÌÌÏÎ; // 0x108
        public System.Collections.Generic.List`1<System.ValueTuple`6<int,ÏÌÍÏÏÍÌÏÏÏÎÎÏÎÏÎÎÍÎÏÏÍÏ,int,UnityEngine.Rect,UnityEngine.Vector2,bool>> ÎÌÌÏÍÎÌÏÌÌÌÌÎÌÎÌÍÌÎÎÏÏÌ; // 0x110
        public System.Collections.Generic.List`1<System.ValueTuple`2<object,int>> ÍÎÏÏÌÍÍÌÏÍÌÎÍÏÍÌÍÍÏÎÏÏÌ; // 0x118
        public System.Collections.Generic.List`1<System.ValueTuple`6<int,ÏÌÍÏÏÍÌÏÏÏÎÎÏÎÏÎÎÍÎÏÏÍÏ,int,UnityEngine.Rect,UnityEngine.Vector2,bool>> ÎÏÎÌÌÌÎÏÌÌÎÎÌÌÎÌÏÏÏÌÏÌÏ; // 0x120
        public ÏÏÎÌÌÏÏÎÎÍÍÍÌÍÏÍÌÌÌÍÌÏÏ ÎÏÌÏÌÏÍÌÏÍÍÏÌÌÍÍÍÎÏÍÍÍÎ; // 0x128
        public System.Collections.Generic.List`1<UnityEngine.Rect> ÏÍÏÍÏÏÌÌÎÌÎÍÍÎÏÎÎÍÌÏÌÍÍ; // 0x130
        public System.Collections.Generic.List`1<object> ÎÍÌÏÎÍÏÌÎÌÎÍÏÏÎÌÎÍÍÌÍÎÌ; // 0x138
        public System.Collections.Generic.List`1<ÏÌÍÏÏÍÌÏÏÏÎÎÏÎÏÎÎÍÎÏÏÍÏ> ÏÍÌÌÏÍÏÍÍÌÎÌÏÍÌÍÍÏÎÏÌÍÏ; // 0x140
        public ÌÍÍÎÌÍÎÎÎÍÍÌÏÎÎÌÎÎÎÍÎÎÌ ÎÍÎÎÎÎÏÎÌÌÏÌÎÍÌÍÌÎÍÌÎÎÌ; // 0x148
        public int ÍÍÏÌÎÏÏÎÎÍÎÌÍÎÎÎÌÏÍÎÏÌÏ;
        public DG.Tweening.Tweener ÌÍÎÌÍÍÍÏÍÍÎÏÎÏÏÍÏÎÍÏÏÌÍ; // 0x150
        public UnityEngine.Vector2 ÎÎÏÍÎÌÍÌÍÌÏÎÍÎÌÎÌÏÏÎÏÏÎ; // 0x158
        public 0x65989578 _layoutMode; // 0x160
        public UnityEngine.Vector2 ÎÍÏÍÎÎÎÏÌÍÌÍÎÌÍÏÎÍÎÍÍÏÏ; // 0x164
        public UnityEngine.Vector2 ÎÌÎÌÍÎÎÎÍÌÌÌÏÎÏÏÎÎÍÌÌÍÎ; // 0x16C
        public bool _shouldWrap; // 0x174
        public UnityEngine.Vector2 _maxPreferredSize; // 0x178
        public bool _scrollable; // 0x180
        public UnityEngine.UI.ScrollRect ÍÏÏÍÏÍÏÍÏÎÍÌÏÌÍÏÎÌÌÍÏÏÌ; // 0x188
        public UnityEngine.UI.Scrollbar ÎÏÎÎÎÌÏÍÌÏÍÍÎÌÍÌÏÌÌÏÏÏÌ; // 0x190

        // ── Methods ──
        public void OnRectTransformDimensionsChange_DE86C5A1EB77(){} // RVA: 0x93FDB60
        public void UnityEngine.UI.ILayoutElement.get_layoutPriority(){} // RVA: 0x519240
        public void UnityEngine.UI.ILayoutElement.get_minWidth(){} // RVA: 0xAFF380
        public void UnityEngine.UI.ILayoutElement.get_flexibleHeight(){} // RVA: 0xAFF380
        public void UnityEngine.UI.ILayoutElement.get_preferredWidth(){} // RVA: 0x93FDF60
        public void RectChildren(){} // RVA: 0x93FE050
        public void UnityEngine.UI.ILayoutElement.get_flexibleWidth(){} // RVA: 0xAFF380
        public void OnRectTransformDimensionsChange(){} // RVA: 0x93FE4E0
        public void OnTransformChildrenChanged(){} // RVA: 0x93FE5B0
        public void SetLayoutVertical(){} // RVA: 0x93FE670
        public void UnityEngine.UI.ILayoutElement.get_preferredHeight(){} // RVA: 0x93FE710
        public void get_Instant(){} // RVA: 0x93FE770
        public void Update(){} // RVA: 0x93FE890
        public void SetLayoutHorizontal(){} // RVA: 0x93FEC80
        public void GetEnumerator(){} // RVA: 0xCD60
        public void LateUpdate(){} // RVA: 0x93FEDB0
        public void SetStateMachine(){} // RVA: 0x93FEEF0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x9401430
        public void CalculateLayoutInputVertical(){} // RVA: 0x94014F0
        public void get_ReadState(){} // RVA: 0x6914B70
        public void set_Disallow(){} // RVA: 0x6016310
        public void MinWidth(){} // RVA: 0x93FD100
        public void get_isCurated(){} // RVA: 0x94015D0
        public void SetLayoutHorizontal_D137951C8F84(){} // RVA: 0x9401F40
        public void SetLayoutVertical_DA38FB71FCFF(){} // RVA: 0x9401FF0
        public void Spacing(){} // RVA: 0x9402860
        public void ChildForceExpandWidth(){} // RVA: 0x94028B0
        public void ChildForceExpandHeight(){} // RVA: 0x9402930
        public void ChildControlWidth(){} // RVA: 0x9402A30
        public void ChildControlHeight(){} // RVA: 0x9402A50
        public void ProcessAnimation(){} // RVA: 0x9402F10
        public void ChildScaleWidth(){} // RVA: 0x9403040
        public void ChildScaleHeight(){} // RVA: 0x9403050
        public void ReverseArrangement(){} // RVA: 0x94030F0
        public void Awake(){} // RVA: 0x94033C0
        public void OnDestroy(){} // RVA: 0x9FF920
        public void ProcessAnimation_66F5D44F09B9(){} // RVA: 0x94036A0
        public void ProcessAnimation_74EBCAE90D34(){} // RVA: 0x94036C0
        public void .ctor(){} // RVA: 0x94036F0
        public void Initialize(){} // RVA: 0x9403C80
        public void ProcessAnimation_B6403326E0E2(){} // RVA: 0x9403CD0
        public void ProcessAnimation_5130627CB5DA(){} // RVA: 0x9403D70
        public void ProcessAnimation_864FBE5C5D0C(){} // RVA: 0x9404250
        public void TotalFlexibleSize_B489AAA28853(){} // RVA: 0x283FA0 | overloaded x2
        public void CalculateLayout(){} // RVA: 0x9404460
        public void CalculateLayout_EA8DE464E284(){} // RVA: 0x9404620
        public void Rect(){} // RVA: 0x9404790
        public void Tracker(){} // RVA: 0xA96D30
        public void TotalMinSize(){} // RVA: 0x9404840
        public void TotalPreferredSize(){} // RVA: 0x93FE4E0
        public void CalculateLayout_4463E66B1C10(){} // RVA: 0x94048A0
        public void CalculateLayout_C8984F4F8E92(){} // RVA: 0x94048B0
        public void CalculateLayout_E93BDF594790(){} // RVA: 0x9404930
        public void UnityEngine.UI.ILayoutElement.get_minHeight(){} // RVA: 0xAFF380
        // ── 55 unresolved (hash) ──
        public void m_2BD(){} // RVA: 0x93FD0A0
        public void m_AA5(){} // RVA: 0x93FD100
        public void m_3EB(){} // RVA: 0x93FD110
        public void m_E60(){} // RVA: 0x1C9ABB0
        public void m_EC1(){} // RVA: 0x93FD130
        // ... 50 more unresolved methods
    }

}