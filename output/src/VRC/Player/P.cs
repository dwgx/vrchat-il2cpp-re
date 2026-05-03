// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Player
// Classes: 100
// Methods: 1665

namespace VRC.Player
{
    /// <summary>Originally: ÌÍÌÍÌÍÎÌÏÏÎÎÏÎÏÎÏÍÏÎÎÏÏ</summary>
    public class PlayerCalculateLayoutInputHorizCalculateLayout_8C3D : LayoutGroup
    {
        public float _m_Padding; // 0x60
        public float _m_ChildAlignment; // 0x64
        public float _m_Rect; // 0x68
        public float _m_Tracker; // 0x6C
        public bool _m_TotalMinSize; // 0x70

        // ── Methods ──
        public void get_padding(){} // RVA: 0x7FFE826A8A70
        public void set_padding(){} // RVA: 0x7FFE826A8ED0
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFE826A8EF0
        public void OnDisable(){} // RVA: 0x7FFE826A90D0
        public void get_rectTransform(){} // RVA: 0x7FFE826A9130
        public void get_rectChildren(){} // RVA: 0x7FFE826A9150
        public void CalculateLayoutInputVertical_494778FDA4E6(){} // RVA: 0x7FFE826A9990
        public void SetLayoutHorizontal_45C186773FB5(){} // RVA: 0x7FFE826A9A50
        public void .ctor(){} // RVA: 0x7FFE826A9AB0
        public void SetLayoutHorizontal(){} // RVA: 0x7FFE826A9B80
        public void get_flexibleWidth(){} // RVA: 0x7FFE826A9B90
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFE826A9BA0
        public void get_preferredHeight(){} // RVA: 0x7FFE826A9D70
        public void get_flexibleHeight(){} // RVA: 0x7FFE826A9B90
        public void get_layoutPriority(){} // RVA: 0x7FFE826A9E40
        public void GetPadding(){} // RVA: 0x7FFE826A9F00
        public void SetPadding(){} // RVA: 0x7FFE826A9F60
        public void UpdatePadding(){} // RVA: 0x7FFE826AA3B0
        public void OnEnable(){} // RVA: 0x7FFE826AAC10
        public void ReadComponentState(){} // RVA: 0x7FFE826AAC60
        public void SetLayoutVertical(){} // RVA: 0x7FFE826AB0A0
        public void GetTotalMinSize(){} // RVA: 0x7FFE826AB0B0
        public void GetTotalPreferredSize(){} // RVA: 0x7FFE826AB0D0
        public void GetTotalFlexibleSize(){} // RVA: 0x7FFE826AB0F0
        public void GetStartOffset(){} // RVA: 0x7FFE826AB1C0
    }

    /// <summary>Originally: ÌÏÍÎÌÍÎÏÍÎÏÍÎÏÌÍÍÌÎÏÌÌÏ</summary>
    public class PlayerJoinedPlayerLeftSibling_4B28 : Object
    {
        public string[] _m_CachedPtr; // 0x10
        public string[] _offsetOfInstanceIDInCPlusPlusObject; // 0x18
        public ÌÏÎÌÎÏÌÌÎÌÌÏÌÏÌÏÍÏÏÏÎÌÌ f_568;
        public System.Collections.Generic.List`1<ÏÏÎÍÍÎÌÏÎÍÍÏÍÏÌÍÏÎÏÏÍÏÏ> f_C91; // 0x20
        public ÏÏÎÍÍÎÌÏÎÍÍÏÍÏÌÍÏÎÏÏÍÏÏ f_14C; // 0x28
        public System.Collections.Generic.Dictionary`2<int,ÏÏÎÍÍÎÌÏÎÍÍÏÍÏÌÍÏÎÏÏÍÏÏ> f_EF3; // 0x30
        public System.Collections.Generic.Dictionary`2<UnityEngine.GameObject,ÏÏÎÍÍÎÌÏÎÍÍÏÍÏÌÍÏÎÏÏÍÏÏ> f_A29; // 0x38
        public System.Collections.Generic.HashSet`1<string> f_DEF; // 0x40
        public System.Collections.Generic.HashSet`1<string> f_D8A; // 0x48
        public System.Collections.Generic.HashSet`1<string> f_A30; // 0x50
        public System.Collections.Generic.Dictionary`2<string,int> f_7FD; // 0x58
        public UnityEngine.GameObject f_E5A; // 0x60
        public object field_12; // 0xA9F
        public object field_13; // 0xAA0
        public object field_14; // 0xAA1

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82977B20
        public void Equals(){} // RVA: 0x7FFE82977CD0
        public void GetHashCode(){} // RVA: 0x7FFE82977D30
        public void op_Implicit(){} // RVA: 0x7FFE82977DB0
        public void CompareBaseObjects(){} // RVA: 0x7FFE82977E30
        public void Internal_CloneSingle(){} // RVA: 0x7FFE82980640 | overloaded x4
        public void GetCachedPtr(){} // RVA: 0x7FFE82978140
        public void get_name(){} // RVA: 0x7FFE824E9A70
        public void set_name(){} // RVA: 0x7FFE82978190
        public void Instantiate(){} // RVA: 0x7FFE82978230
        public void Dispose(){} // RVA: 0x7FFE82978410
        public void Cleanup(){} // RVA: 0x7FFE829789C0
        public void ToString(){} // RVA: 0x7FFE82978E00
        public void OnPlayerJoined(){} // RVA: 0x7FFE82978E80
        public void OnPlayerLeft(){} // RVA: 0x7FFE82979280
        public void RegisterPlayerCallback(){} // RVA: 0x7FFE82979690
        public void UnregisterPlayerCallback(){} // RVA: 0x7FFE829797C0
        public void InvokePlayerJoinHandler(){} // RVA: 0x7FFE82979CC0
        public void Destroy(){} // RVA: 0x7FFE82979D60
        public void InvokePlayerLeaveHandler(){} // RVA: 0x7FFE8297AAA0
        public void DestroyImmediate(){} // RVA: 0x7FFE8297B770
        public void GetPlayerJoinTime(){} // RVA: 0x7FFE8297D120
        public void FindObjectsOfType(){} // RVA: 0x7FFE8297D2B0
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFE82981500 | overloaded x4
        public void FindObjectsByType(){} // RVA: 0x7FFE8297DA50
        public void DontDestroyOnLoad(){} // RVA: 0x7FFE8297DA70
        public void get_hideFlags(){} // RVA: 0x7FFE8297E130
        public void BroadcastPlayerJoined(){} // RVA: 0x7FFE8297ED30
        public void FindObjectOfType(){} // RVA: 0x7FFE8297EDA0
        public void FindFirstObjectByType(){} // RVA: 0x7FFE8297EF50
        public void BroadcastPlayerLeft(){} // RVA: 0x7FFE81176730
        public void CheckNullArgument(){} // RVA: 0x7FFE8297F970
        public void ClearPlayerCallbacks(){} // RVA: 0x7FFE8297F990
        public void GetPlayerCount(){} // RVA: 0x7FFE8297FA90
        public void op_Equality(){} // RVA: 0x7FFE8297FE10
        public void op_Inequality(){} // RVA: 0x7FFE829800F0
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFE82980150
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFE82980770
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFE82980840
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFE81178740
        public void GetName(){} // RVA: 0x7FFE82980930
        public void SetName(){} // RVA: 0x7FFE829809B0
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFE82980A50
        public void .ctor(){} // RVA: 0x7FFE82980AA0
        public void Initialize(){} // RVA: 0x7FFE82981130
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFE82981390
        // ── Unresolved (hash) ──
        public void m_423(){} // RVA: 0x7FFE8297FCF0
        public void m_D52(){} // RVA: 0x7FFE8297FDD0
        public void m_D85(){} // RVA: 0x7FFE82980910
        public void m_6E3(){} // RVA: 0x7FFE82981180
        public void m_638(){} // RVA: 0x7FFE829816F0
        public void m_992(){} // RVA: 0x7FFE82981CC0
        public void m_8C9(){} // RVA: 0x7FFE82981DB0
        public void m_056(){} // RVA: 0x7FFE82980910
        public void m_894(){} // RVA: 0x7FFE8297FE10
    }

    /// <summary>Originally: ÌÎÍÌÏÌÍÌÏÍÎÎÍÏÌÏÌÍÏÏÎÎÏ</summary>
    public class PlayerLeft_D0B2 : Object
    {
        public string _m_CachedPtr;
        public string _offsetOfInstanceIDInCPlusPlusObject;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE815178E0
        public void Equals(){} // RVA: 0x7FFE815179E0
        public void GetHashCode(){} // RVA: 0x7FFE81517AF0
        public void op_Implicit(){} // RVA: 0x7FFE81517DA0
        public void CompareBaseObjects(){} // RVA: 0x7FFE814B8390
        public void OnPlayerLeft(){} // RVA: 0x7FFE81517DB0
        public void GetCachedPtr(){} // RVA: 0x7FFE81517E40
        public void get_name(){} // RVA: 0x7FFE815180F0
        public void set_name(){} // RVA: 0x7FFE814B8390
        public void Instantiate(){} // RVA: 0x7FFE815181F0
        public void ToString(){} // RVA: 0x7FFE81518F90 | overloaded x2
        public void OnPlayerLeft_7FD0BD2E4186(){} // RVA: 0x7FFE81519300
        public void .ctor(){} // RVA: 0x7FFE815195B0
        public void Initialize(){} // RVA: 0x7FFE81519AC0
        public void OnPlayerLeft_AD05390D1D21(){} // RVA: 0x7FFE81519D70
        public void .cctor_06FE7BD41BF7(){} // RVA: 0x7FFE81519E70
        public void RemovePlayerData(){} // RVA: 0x7FFE81519F70
        public void NotifyPlayerLeft(){} // RVA: 0x7FFE81519FD0
    }

    /// <summary>Originally: ÌÍÎÍÎÌÏÍÎÎÌÏÎÏÌÌÍÌÌÏÍÎÌ</summary>
    public class PlayerMoveNext_00F2 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE821F3E30
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE821F3E70
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE821F4160
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE821F43F0
        public void GetCachedPtr(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÌÌÍÎÌÎÎÏÏÍÌÌÏÏÍÎÌÍÏÍÎÌ</summary>
    public class PlayerMoveNext_0151 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void MoveNext(){} // RVA: 0x7FFE813FBAB0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FB310
        public void GetCachedPtr(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82471360
        public void set_name(){} // RVA: 0x7FFE824713A0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void Instantiate(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÎÏÍÌÌÎÏÍÎÍÏÌÌÌÌÏÎÌÍÏÍÏ</summary>
    public class PlayerMoveNext_0475 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void get_Current(){} // RVA: 0x7FFE827E8BD0
        public void op_Implicit(){} // RVA: 0x7FFE810FB310
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE827E8C10
        public void get_name(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE827E8C50
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÎÌÎÌÌÍÎÎÎÎÍÍÏÏÎÌÍÏÎÍÌÌ</summary>
    public class PlayerMoveNext_0A45 : Object
    {
        public int _m_CachedPtr;
        public object _offsetOfInstanceIDInCPlusPlusObject;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE80E2E2E0
        public void CompareBaseObjects(){} // RVA: 0x7FFE80E45FE0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE80E45FE0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE80E45FE0
        public void set_name(){} // RVA: 0x7FFE80E2E2E0
        public void MoveNext(){} // RVA: 0x7FFE80E2F150
        public void Instantiate(){} // RVA: 0x7FFE80E2E2E0
        public void get_Current(){} // RVA: 0x7FFE80E2F150
    }

    /// <summary>Originally: ÌÍÎÏÎÍÏÌÏÏÏÎÏÎÌÌÏÎÎÏÎÎÍ</summary>
    public class PlayerMoveNext_0CE0 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82037A10
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE82037A50
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void CompareBaseObjects(){} // RVA: 0x7FFE82037A90
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82037AD0
        public void MoveNext(){} // RVA: 0x7FFE82037B10
        public void set_name(){} // RVA: 0x7FFE810FB310
        public void Instantiate(){} // RVA: 0x7FFE82037E90
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE82038210
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÌÏÎÌÏÎÏÎÏÏÏÍÌÏÎÎÎÏÏÎÏÏ</summary>
    public class PlayerMoveNext_0E69 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE897D60E0
        public void get_Current(){} // RVA: 0x7FFE897D61B0
        public void op_Implicit(){} // RVA: 0x7FFE897D61F0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE897D6230
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE897D6270
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÍÍÏÏÌÌÎÏÎÌÎÌÏÎÏÏÎÏÍÎÍÌ</summary>
    public class PlayerMoveNext_0FBA : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82593F70
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE825942E0
        public void GetCachedPtr(){} // RVA: 0x7FFE810FE7C0
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE82594320
    }

    /// <summary>Originally: ÌÎÎÌÍÎÏÍÎÏÎÌÌÌÌÏÏÍÎÎÎÌÍ</summary>
    public class PlayerMoveNext_0FBD : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81EE6A50
        public void get_Current(){} // RVA: 0x7FFE81EE6A90
        public void Equals(){} // RVA: 0x7FFE81EE6AD0
        public void op_Implicit(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE81EE6B10
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_name(){} // RVA: 0x7FFE81EE6B50
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE81EE6B90
        public void MoveNext(){} // RVA: 0x7FFE81EE7B10
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÌÌÏÎÎÏÎÏÏÎÌÎÎÏÌÍÌÍÏÌÏÌ</summary>
    public class PlayerMoveNext_12E2 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE81695230
        public void op_Implicit(){} // RVA: 0x7FFE816953A0
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81695510
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE81695550
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÌÌÍÌÏÎÌÏÏÍÌÏÏÌÍÎÏÏÌÎÎÏ</summary>
    public class PlayerMoveNext_1319 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE826392B0
        public void MoveNext(){} // RVA: 0x7FFE826392F0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FB310
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE82639700
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    /// <summary>Originally: ÌÎÎÏÍÎÏÌÎÍÎÍÎÍÏÎÌÌÌÏÎÏÎ</summary>
    public class PlayerMoveNext_1D72 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFE827073C0
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82707780
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE827077C0
        public void set_name(){} // RVA: 0x7FFE82707B80
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCode(){} // RVA: 0x7FFE810FB310
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void ToString(){} // RVA: 0x7FFE810FE7C0
        public void Dispose(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÌÎÌÎÏÎÏÌÏÏÎÌÎÎÌÌÎÌÍÌÎÍ</summary>
    public class PlayerMoveNext_1F30 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE89C279C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE89C27A00
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE89C27C80
        public void GetCachedPtr(){} // RVA: 0x7FFE89C27EC0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void set_name(){} // RVA: 0x7FFE89C27F00
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE89C28180
        public void get_Current(){} // RVA: 0x7FFE89C281C0
    }

    /// <summary>Originally: ÌÏÌÎÍÍÏÎÏÍÎÎÎÌÎÏÏÍÏÎÎÏÍ</summary>
    public class PlayerMoveNext_1F38 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE89842C40
        public void Equals(){} // RVA: 0x7FFE89843220
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE89843530
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE89843570
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÏÌÏÌÍÎÌÍÏÌÎÍÏÌÌÎÎÌÌÎÎÏ</summary>
    public class PlayerMoveNext_23BB : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void MoveNext(){} // RVA: 0x7FFE82672A10
        public void op_Implicit(){} // RVA: 0x7FFE810FB310
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FB310
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE82672BB0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82672BF0
    }

    /// <summary>Originally: ÌÍÏÍÍÍÍÍÎÎÌÎÎÏÎÎÎÍÍÎÏÍÏ</summary>
    public class PlayerMoveNext_280E : Object
    {
        public int _m_CachedPtr; // 0x10
        public System.Collections.Generic.KeyValuePair`2<int,System.Collections.Generic.List`1<string>> _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE81B56280
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE81B56310
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81B564D0
        public void MoveNext(){} // RVA: 0x7FFE81B56510
        public void CompareBaseObjects(){} // RVA: 0x7FFE81B56E50
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE81B56E90
        public void GetCachedPtr(){} // RVA: 0x7FFE81B56ED0
        public void get_name(){} // RVA: 0x7FFE81B56F10
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE81B56F60
        public void .ctor(){} // RVA: 0x7FFE81B56FB0
        public void Initialize(){} // RVA: 0x7FFE81B56FD0
        public void System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Collections.Generic.List<System.String>>>.get_Current(){} // RVA: 0x7FFE81703940
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Collections.Generic.List<System.String>>>.GetEnumerator(){} // RVA: 0x7FFE81B56280
        public void Instantiate(){} // RVA: 0x7FFE81703940
        public void GetEnumerator(){} // RVA: 0x7FFE81703940
        public void get_Current(){} // RVA: 0x7FFE81B57010
        public void Equals(){} // RVA: 0x7FFE81B57050
        public void GetHashCode(){} // RVA: 0x7FFE81B56ED0
    }

    /// <summary>Originally: ÌÏÌÏÏÎÌÍÍÍÏÌÌÏÏÏÍÎÎÌÍÎÍ</summary>
    public class PlayerMoveNext_2A34 : Object
    {
        public int _m_CachedPtr; // 0x10
        public string _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.Generic.IEnumerator<System.String>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerable<System.String>.GetEnumerator(){} // RVA: 0x7FFE82B17A70
        public void op_Implicit(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82B17B40
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE82B17B80
        public void GetCachedPtr(){} // RVA: 0x7FFE82B17C40
        public void .ctor(){} // RVA: 0x7FFE8156F420
        public void MoveNext(){} // RVA: 0x7FFE82B17CA0
        public void Instantiate(){} // RVA: 0x7FFE82B18050
        public void GetEnumerator(){} // RVA: 0x7FFE82B18120
        public void get_Current(){} // RVA: 0x7FFE82B18500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE82B17A70
        public void Equals(){} // RVA: 0x7FFE82B18540
        public void GetHashCode(){} // RVA: 0x7FFE82B185A0
    }

    /// <summary>Originally: ÌÍÌÍÎÏÎÎÎÍÍÍÎÌÍÎÍÎÍÌÌÍÍ</summary>
    public class PlayerMoveNext_2AE0 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFE8200A710
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE8200AA90
        public void get_Current(){} // RVA: 0x7FFE8200AAD0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE8200AE50
        public void Equals(){} // RVA: 0x7FFE810FB310
        public void GetHashCode(){} // RVA: 0x7FFE8200AE90
    }

    /// <summary>Originally: ÌÌÏÏÎÌÏÌÎÏÌÎÍÍÌÌÏÎÎÏÌÏÌ</summary>
    public class PlayerMoveNext_2B32 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFE8157FE90
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE81580640
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE81580DF0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE81581510
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81581560
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCode(){} // RVA: 0x7FFE815815A0
        public void ToString(){} // RVA: 0x7FFE815815F0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE815817D0
    }

    /// <summary>Originally: ÌÎÍÍÎÌÌÌÌÍÌÍÍÌÎÏÏÎÎÎÏÎÌ</summary>
    public class PlayerMoveNext_2F91 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void get_Current(){} // RVA: 0x7FFE81BF21A0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void op_Implicit(){} // RVA: 0x7FFE81BF2340
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void MoveNext(){} // RVA: 0x7FFE81BF2380
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81BF2530
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÏÎÎÎÍÌÌÎÎÌÍÏÌÏÌÌÏÌÌÏÏÎ</summary>
    public class PlayerMoveNext_32E4 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE89878C20
        public void MoveNext(){} // RVA: 0x7FFE89878C60
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FE7C0
        public void GetCachedPtr(){} // RVA: 0x7FFE810FB310
        public void get_name(){} // RVA: 0x7FFE89879730
        public void set_name(){} // RVA: 0x7FFE89879770
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FB310
        public void Equals(){} // RVA: 0x7FFE89879B90
    }

    /// <summary>Originally: ÌÌÏÏÍÏÍÌÍÍÌÏÎÌÎÏÍÏÎÎÍÏÎ</summary>
    public class PlayerMoveNext_3C50 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void op_Implicit(){} // RVA: 0x7FFE82702050
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FB310
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE82702370
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE827026A0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE827029F0
        public void GetHashCode(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÏÌÌÏÌÍÍÌÍÏÏÍÌÎÏÎÌÍÏÌÌÌ</summary>
    public class PlayerMoveNext_3CFC : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFE8242F130
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE8242F4E0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE8242F520
        public void GetCachedPtr(){} // RVA: 0x7FFE8242F560
        public void get_name(){} // RVA: 0x7FFE8242F9A0
        public void set_name(){} // RVA: 0x7FFE810FB310
        public void Instantiate(){} // RVA: 0x7FFE810FB310
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE810FB310
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÌÍÌÍÌÍÍÎÎÍÍÌÍÏÏÌÎÏÎÏÎÎ</summary>
    public class PlayerMoveNext_3E0B : Object
    {
        public int _m_CachedPtr; // 0x10
        public ÍÏÍÏÌÏÏÎÌÍÏÌÍÏÏÎÍÌÍÎÍÍÏ _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE826F3D90
        public void GetEnumerator(){} // RVA: 0x7FFE826F3E20
        public void MoveNext(){} // RVA: 0x7FFE826F3EF0
        public void op_Implicit(){} // RVA: 0x7FFE810FB310
        public void CompareBaseObjects(){} // RVA: 0x7FFE826F3FC0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE826F3FE0
        public void Initialize(){} // RVA: 0x7FFE826F4000
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE826F40E0
        public void System.Collections.Generic.IEnumerable<PortMidi.MidiDeviceInfo>.GetEnumerator(){} // RVA: 0x7FFE826F3D90
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE826F4140
        public void System.Collections.Generic.IEnumerator<PortMidi.MidiDeviceInfo>.get_Current(){} // RVA: 0x7FFE826F3FC0
        public void Instantiate(){} // RVA: 0x7FFE826F4180
    }

    /// <summary>Originally: ÌÌÎÍÏÌÌÏÍÌÍÏÎÏÍÎÎÏÌÏÍÍÌ</summary>
    public class PlayerMoveNext_3E98 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void op_Implicit(){} // RVA: 0x7FFE810FB310
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81675890
        public void get_name(){} // RVA: 0x7FFE816758D0
        public void MoveNext(){} // RVA: 0x7FFE81675910
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE810FB310
        public void get_Current(){} // RVA: 0x7FFE81675FA0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÎÏÍÍÎÏÎÌÎÎÍÌÍÍÎÍÎÏÏÏÏÏ</summary>
    public class PlayerMoveNext_3F10 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE816BC0F0
        public void MoveNext(){} // RVA: 0x7FFE816BC130
        public void CompareBaseObjects(){} // RVA: 0x7FFE816BCA60
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FB310
        public void Instantiate(){} // RVA: 0x7FFE816BD390
        public void get_Current(){} // RVA: 0x7FFE816BD3D0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÎÍÍÍÏÏÌÌÍÍÏÎÍÎÍÌÏÍÏÍÏÏ</summary>
    public class PlayerMoveNext_4341 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE828A0AC0
        public void op_Implicit(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE828A0F20
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE828A0F60
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCode(){} // RVA: 0x7FFE828A0FA0
        public void ToString(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÎÏÎÌÎÎÏÌÏÍÌÎÏÌÌÏÌÏÏÎÌÌ</summary>
    public class PlayerMoveNext_4919 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE81396D50
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void op_Implicit(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE81396F90
        public void GetCachedPtr(){} // RVA: 0x7FFE810FE7C0
        public void get_name(){} // RVA: 0x7FFE81397190
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE813973E0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81397420
    }

    /// <summary>Originally: ÌÎÎÌÍÏÎÍÏÎÎÌÌÏÏÏÏÍÍÍÌÌÎ</summary>
    public class PlayerMoveNext_4965 : Object
    {
        public int _m_CachedPtr;
        public object _offsetOfInstanceIDInCPlusPlusObject;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE80E2E2E0
        public void get_Current(){} // RVA: 0x7FFE80E45FE0
        public void Equals(){} // RVA: 0x7FFE80E2F150
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE80E45FE0
        public void CompareBaseObjects(){} // RVA: 0x7FFE80E2F150
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE80E45FE0
        public void get_name(){} // RVA: 0x7FFE80E45FE0
        public void MoveNext(){} // RVA: 0x7FFE80E2F150
        public void Instantiate(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void Initialize(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE80E2E2E0
    }

    /// <summary>Originally: ÌÏÏÏÏÌÏÎÌÌÍÍÌÏÎÍÏÍÍÏÌÍÍ</summary>
    public class PlayerMoveNext_49B1 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE812D3590
        public void op_Implicit(){} // RVA: 0x7FFE812D35D0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE812D3880
        public void GetCachedPtr(){} // RVA: 0x7FFE812D38C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE812D3C00
        public void get_Current(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE812D3C40
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÌÎÍÍÍÌÏÎÍÏÏÎÏÏÍÏÌÌÎÏÍÎ</summary>
    public class PlayerMoveNext_4A50 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE8201C420
        public void get_Current(){} // RVA: 0x7FFE8201C460
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE8201C500
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE8201C540
        public void MoveNext(){} // RVA: 0x7FFE8201C580
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCode(){} // RVA: 0x7FFE8201C620
    }

    /// <summary>Originally: ÌÍÍÌÏÎÏÌÏÏÎÍÎÍÎÌÌÌÏÍÍÏÏ</summary>
    public class PlayerMoveNext_4AEF : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE82047350
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void op_Implicit(){} // RVA: 0x7FFE810FB310
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82047640
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FB310
        public void Instantiate(){} // RVA: 0x7FFE82047680
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE82047970
    }

    /// <summary>Originally: ÌÍÌÎÎÌÌÌÌÏÏÌÏÍÍÏÌÏÎÏÎÎÌ</summary>
    public class PlayerMoveNext_4E5F : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FB310
        public void get_Current(){} // RVA: 0x7FFE813948D0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81394910
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void GetCachedPtr(){} // RVA: 0x7FFE81394950
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE81394BE0
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCode(){} // RVA: 0x7FFE810FB310
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÍÎÌÎÍÍÏÌÍÎÌÎÍÌÍÏÎÍÍÎÍÎ</summary>
    public class PlayerMoveNext_51A6 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE820469D0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82046AC0
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FB310
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE82046B00
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÏÏÎÎÍÍÍÍÏÎÏÌÏÍÌÎÎÏÍÍÌÍ</summary>
    public class PlayerMoveNext_5617 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81674F10
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void op_Implicit(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE81674F50
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE81675430
        public void GetCachedPtr(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81675850
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÌÏÎÎÎÍÍÎÏÎÌÏÏÎÏÌÌÏÍÌÎÍ</summary>
    public class PlayerMoveNext_5AE2 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void op_Implicit(){} // RVA: 0x7FFE81792930
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void get_name(){} // RVA: 0x7FFE81793810
        public void set_name(){} // RVA: 0x7FFE817946F0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81794860
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE817948A0
    }

    /// <summary>Originally: ÌÌÍÏÍÍÎÌÌÍÏÌÏÎÎÎÍÎÏÍÏÍÏ</summary>
    public class PlayerMoveNext_649D : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE8264A3C0
        public void get_Current(){} // RVA: 0x7FFE8264A480
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE8264AE30
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE8264AE70
        public void GetCachedPtr(){} // RVA: 0x7FFE8264B820
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE8264C1D0
        public void Instantiate(){} // RVA: 0x7FFE8264C250
        public void Equals(){} // RVA: 0x7FFE8264C2A0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCode(){} // RVA: 0x7FFE8264CC50
    }

    /// <summary>Originally: ÌÏÌÎÏÏÌÍÌÌÎÏÍÍÌÏÌÎÎÏÍÍÌ</summary>
    public class PlayerMoveNext_70DB : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82735C90
        public void MoveNext(){} // RVA: 0x7FFE82735CD0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82735F30
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE82735F70
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE82735FB0
        public void get_Current(){} // RVA: 0x7FFE82735FF0
    }

    /// <summary>Originally: ÌÎÌÌÌÌÌÏÏÍÌÏÏÍÎÍÏÌÌÎÎÍÌ</summary>
    public class PlayerMoveNext_7164 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE81693AD0
        public void get_Current(){} // RVA: 0x7FFE81693F70
        public void op_Implicit(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81694410
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_name(){} // RVA: 0x7FFE810FB310
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE81694450
    }

    /// <summary>Originally: ÌÏÏÏÎÎÎÎÌÌÌÏÌÏÍÏÏÍÏÍÏÍÏ</summary>
    public class PlayerMoveNext_7810 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FB310
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE81C00930
        public void GetCachedPtr(){} // RVA: 0x7FFE81C00970
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81C009B0
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE81C009F0
        public void MoveNext(){} // RVA: 0x7FFE81C00A30
        public void get_Current(){} // RVA: 0x7FFE81C00CE0
    }

    /// <summary>Originally: ÌÎÌÎÌÏÍÎÎÏÎÏÏÍÍÎÎÏÎÌÎÌÎ</summary>
    public class PlayerMoveNext_7B1E : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82752C00
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FB310
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE82752C40
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE82752EE0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    /// <summary>Originally: ÌÏÌÌÌÎÍÎÎÎÎÍÍÎÌÌÌÌÌÎÍÌÏ</summary>
    public class PlayerMoveNext_8042 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFE815F01B0
        public void get_Current(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE815F0300
        public void op_Implicit(){} // RVA: 0x7FFE810FE7C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE815F0340
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void get_name(){} // RVA: 0x7FFE815F04A0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void GetHashCode(){} // RVA: 0x7FFE815F04E0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÎÌÎÌÌÎÌÌÌÌÍÏÌÌÎÌÎÎÍÎÏÍ</summary>
    public class PlayerMoveNext_81E8 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE89D79CD0
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void op_Implicit(){} // RVA: 0x7FFE810FE7C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE89D79F30
        public void GetCachedPtr(){} // RVA: 0x7FFE89D79F70
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE89D7A1C0
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE89D7A4B0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÍÍÎÎÎÏÏÏÍÏÌÏÌÌÎÎÍÌÎÌÎÎ</summary>
    public class PlayerMoveNext_81EB : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void op_Implicit(){} // RVA: 0x7FFE8278FE20
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FB310
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void GetCachedPtr(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE82790950
        public void Instantiate(){} // RVA: 0x7FFE827914A0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82791FF0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    /// <summary>Originally: ÌÍÌÎÎÌÎÍÎÎÎÌÏÎÌÌÎÍÏÌÍÍÍ</summary>
    public class PlayerMoveNext_83B1 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE8218D940
        public void get_Current(){} // RVA: 0x7FFE8218E400
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE8218E440
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FE7C0
        public void GetCachedPtr(){} // RVA: 0x7FFE8218E480
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE8218EF40
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE8218FA10
        public void Equals(){} // RVA: 0x7FFE8218FA50
        public void GetHashCode(){} // RVA: 0x7FFE82190510
        public void ToString(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÎÎÌÍÎÏÍÎÌÍÎÍÎÌÎÌÎÌÏÎÍÎ</summary>
    public class PlayerMoveNext_859F : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82344750
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FE7C0
        public void GetCachedPtr(){} // RVA: 0x7FFE810FE7C0
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE82344790
        public void Instantiate(){} // RVA: 0x7FFE82344C00
        public void Equals(){} // RVA: 0x7FFE810FB310
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCode(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÎÎÌÎÌÏÍÎÏÌÌÌÍÍÏÌÏÎÍÎÏÌ</summary>
    public class PlayerMoveNext_8AA8 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81765420
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE817656F0
        public void op_Implicit(){} // RVA: 0x7FFE81765730
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FB310
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE81765770
        public void MoveNext(){} // RVA: 0x7FFE817657B0
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE81765BA0
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÎÎÌÍÎÌÎÍÏÌÎÎÌÏÎÍÎÏÍÌÌÍ</summary>
    public class PlayerMoveNext_931B : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void get_Current(){} // RVA: 0x7FFE8270E9F0
        public void Equals(){} // RVA: 0x7FFE8270EA30
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void MoveNext(){} // RVA: 0x7FFE8270EA70
        public void GetCachedPtr(){} // RVA: 0x7FFE810FE7C0
        public void get_name(){} // RVA: 0x7FFE810FB310
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE8270EC90
    }

    /// <summary>Originally: ÌÎÌÎÎÏÌÎÏÏÏÏÎÍÍÏÏÎÏÏÎÏÏ</summary>
    public class PlayerMoveNext_98FD : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE824B79A0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE824B79E0
        public void MoveNext(){} // RVA: 0x7FFE824B7A20
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FB310
        public void GetCachedPtr(){} // RVA: 0x7FFE810FB310
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE824B8220
    }

    /// <summary>Originally: ÌÌÍÍÎÏÌÍÏÌÎÌÎÍÌÍÎÎÏÏÍÎÍ</summary>
    public class PlayerMoveNext_9C12 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE898DE8F0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE898DE930
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void op_Implicit(){} // RVA: 0x7FFE898DE970
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void get_name(){} // RVA: 0x7FFE810FB310
        public void set_name(){} // RVA: 0x7FFE898DEA90
        public void MoveNext(){} // RVA: 0x7FFE898DEBC0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE898DECE0
    }

    /// <summary>Originally: ÌÍÌÌÏÌÎÌÎÎÏÍÌÏÎÎÏÌÍÏÍÍÍ</summary>
    public class PlayerMoveNext_9D36 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE82015290
        public void Equals(){} // RVA: 0x7FFE82015B80
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void CompareBaseObjects(){} // RVA: 0x7FFE82015BC0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE82015C00
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82016720
        public void Instantiate(){} // RVA: 0x7FFE810FB310
        public void GetHashCode(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void ToString(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÌÌÎÍÌÍÏÍÏÍÎÏÌÍÌÎÎÍÏÎÍÍ</summary>
    public class PlayerMoveNext_9DBE : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8262CBD0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE8262CC10
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void GetCachedPtr(){} // RVA: 0x7FFE8262CC50
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE8262CC90
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FB310
        public void Equals(){} // RVA: 0x7FFE8262CDE0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCode(){} // RVA: 0x7FFE8262CF40
    }

    /// <summary>Originally: ÍÌÌÍÍÌÏÏÏÏÏÍÌÏÌÍÎÌÏÍÌÍÍ</summary>
    public class PlayerMoveNext_A50E : Object
    {
        public int _m_CachedPtr;
        public object _offsetOfInstanceIDInCPlusPlusObject;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE80E2E2E0
        public void op_Implicit(){} // RVA: 0x7FFE80E2F150
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE80E45FE0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE80E2E2E0
        public void GetCachedPtr(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE80E2E2E0
        public void set_name(){} // RVA: 0x7FFE80E2F150
        public void Instantiate(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE80E45FE0
        public void MoveNext(){} // RVA: 0x7FFE80E2F150
        public void get_Current(){} // RVA: 0x7FFE80E45FE0
    }

    /// <summary>Originally: ÌÍÌÎÎÏÏÎÍÌÎÍÏÍÍÎÍÌÏÌÏÏÍ</summary>
    public class PlayerMoveNext_A591 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE824A3F60
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void op_Implicit(){} // RVA: 0x7FFE810FE7C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE824A4660
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE824A5060
    }

    /// <summary>Originally: ÌÎÏÏÌÎÎÏÍÎÍÏÌÌÌÎÍÌÏÍÍÎÏ</summary>
    public class PlayerMoveNext_AD70 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE8202F1D0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void op_Implicit(){} // RVA: 0x7FFE810FB310
        public void CompareBaseObjects(){} // RVA: 0x7FFE8202F360
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE8202F4F0
        public void get_Current(){} // RVA: 0x7FFE8202F530
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE8202F570
    }

    /// <summary>Originally: ÌÌÌÎÎÎÌÏÌÍÎÏÌÌÍÍÍÍÏÏÏÌÍ</summary>
    public class PlayerMoveNext_B0B8 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE810FB310
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE81E284F0
        public void GetCachedPtr(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE81E28A90
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81E29040
    }

    /// <summary>Originally: ÌÌÌÌÌÌÌÍÏÎÍÎÏÍÌÌÏÍÎÌÌÌÍ</summary>
    public class PlayerMoveNext_B2C0 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81676600
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE81676800
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81676A00
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void Instantiate(){} // RVA: 0x7FFE81676A40
        public void Equals(){} // RVA: 0x7FFE81676A80
    }

    /// <summary>Originally: ÌÍÎÏÍÍÏÍÍÎÌÎÍÍÍÎÌÏÍÌÍÍÌ</summary>
    public class PlayerMoveNext_B2DD : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82047C60
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE82047CA0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE82047CE0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82047DA0
        public void MoveNext(){} // RVA: 0x7FFE82047DE0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE8204BF70
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE8204BFB0
        public void Equals(){} // RVA: 0x7FFE8204BFF0
    }

    /// <summary>Originally: ÌÌÌÍÏÏÎÍÍÍÏÏÏÏÎÍÍÌÎÌÏÌÏ</summary>
    public class PlayerMoveNext_B6B2 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FB310
        public void op_Implicit(){} // RVA: 0x7FFE810FE7C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE817E51F0
        public void MoveNext(){} // RVA: 0x7FFE817E60D0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE817E6EA0
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE817E6EE0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÌÎÎÎÌÎÌÍÏÌÎÏÏÍÏÎÎÌÌÏÎÍ</summary>
    public class PlayerMoveNext_B8F7 : Object
    {
        public int _m_CachedPtr; // 0x10
        public string _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE82B15220
        public void GetEnumerator(){} // RVA: 0x7FFE82B152F0
        public void get_Current(){} // RVA: 0x7FFE82B15410
        public void System.Collections.Generic.IEnumerable<System.String>.GetEnumerator(){} // RVA: 0x7FFE82B15220
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.String>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE82B154E0
        public void Instantiate(){} // RVA: 0x7FFE810FB310
        public void Equals(){} // RVA: 0x7FFE82B15600
        public void GetHashCode(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE8156F420
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82B15640
    }

    /// <summary>Originally: ÌÌÎÍÍÌÌÏÌÍÎÌÎÍÏÎÏÌÌÎÎÍÎ</summary>
    public class PlayerMoveNext_BA90 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE82672D00
        public void MoveNext(){} // RVA: 0x7FFE82672D00
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FB310
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82672EC0
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE82672F00
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÍÎÍÎÎÎÌÎÍÎÍÍÍÌÌÌÎÎÌÏÎÏ</summary>
    public class PlayerMoveNext_BEC1 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void GetCachedPtr(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE8971BAD0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE8971BD10
        public void Instantiate(){} // RVA: 0x7FFE8971BD50
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCode(){} // RVA: 0x7FFE810FE7C0
        public void ToString(){} // RVA: 0x7FFE810FE7C0
        public void Dispose(){} // RVA: 0x7FFE8971BF60
    }

    /// <summary>Originally: ÌÎÌÏÏÍÎÍÎÎÌÎÍÏÍÏÍÌÎÌÎÌÎ</summary>
    public class PlayerMoveNext_C009 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE819BCAC0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE819BCB00
        public void CompareBaseObjects(){} // RVA: 0x7FFE819BCC30
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void GetCachedPtr(){} // RVA: 0x7FFE810FB310
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FB310
        public void Instantiate(){} // RVA: 0x7FFE819BCD60
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void get_Current(){} // RVA: 0x7FFE819BCDA0
    }

    /// <summary>Originally: ÌÍÏÏÎÌÌÍÍÍÏÏÍÎÏÌÏÏÏÍÎÍÏ</summary>
    public class PlayerMoveNext_C2E1 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE89A46870
        public void get_Current(){} // RVA: 0x7FFE89A468B0
        public void op_Implicit(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE89A46960
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FE7C0
        public void GetCachedPtr(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE89A46B80
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE89A46DA0
    }

    /// <summary>Originally: ÌÎÌÏÏÌÍÍÏÌÍÍÌÏÎÍÍÌÎÏÍÍÏ</summary>
    public class PlayerMoveNext_C3DA : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE82460EF0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE824615B0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82461CD0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCode(){} // RVA: 0x7FFE810FE7C0
        public void ToString(){} // RVA: 0x7FFE810FE7C0
        public void Dispose(){} // RVA: 0x7FFE810FE7C0
        public void Dispose_F87877A3F133(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÏÍÏÌÎÏÏÏÍÏÌÎÌÌÎÏÎÎÏÎÍÍ</summary>
    public class PlayerMoveNext_C6DB : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE8202ADB0
        public void Equals(){} // RVA: 0x7FFE8202B0C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE8202B3E0
        public void GetCachedPtr(){} // RVA: 0x7FFE8202B700
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE8202BA20
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCode(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÌÏÍÏÍÌÎÎÌÏÎÌÌÏÏÍÎÌÎÎÎÍ</summary>
    public class PlayerMoveNext_C81B : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void op_Implicit(){} // RVA: 0x7FFE810FE7C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE82672D00
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE82672D10
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82672D50
        public void MoveNext(){} // RVA: 0x7FFE82672D00
    }

    /// <summary>Originally: ÌÍÍÍÍÌÌÏÏÏÌÎÏÏÏÏÌÎÌÎÌÎÏ</summary>
    public class PlayerMoveNext_CC17 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE8267AB20
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void op_Implicit(){} // RVA: 0x7FFE8267AB60
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE8267ACE0
        public void GetCachedPtr(){} // RVA: 0x7FFE8267AE70
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE8267AEB0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void Instantiate(){} // RVA: 0x7FFE810FB310
        public void Equals(){} // RVA: 0x7FFE810FB310
        public void GetHashCode(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÍÏÌÍÎÏÏÌÍÎÍÎÌÎÏÎÏÍÏÎÍÌ</summary>
    public class PlayerMoveNext_D17E : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE82678C30
        public void get_Current(){} // RVA: 0x7FFE82678C70
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE82678EE0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE826793A0
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÏÌÍÎÍÍÌÌÌÎÎÏÌÍÏÍÎÌÎÎÎÏ</summary>
    public class PlayerMoveNext_D214 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE81395F90
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81396240
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE810FB310
        public void get_Current(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÎÎÍÍÎÌÏÍÏÌÌÍÎÍÍÌÍÎÌÏÎÏ</summary>
    public class PlayerMoveNext_D2AB : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE896AA3A0
        public void op_Implicit(){} // RVA: 0x7FFE896AA550
        public void CompareBaseObjects(){} // RVA: 0x7FFE896AA590
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void GetCachedPtr(){} // RVA: 0x7FFE896AA5D0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE896AA770
        public void MoveNext(){} // RVA: 0x7FFE896AA7B0
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE896AA960
        public void GetHashCode(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÎÏÌÎÏÌÌÎÏÎÏÎÌÎÍÏÎÎÎÏÍÍ</summary>
    public class PlayerMoveNext_D38D : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FB310
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FB310
        public void GetCachedPtr(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE827033B0
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82703650
        public void Instantiate(){} // RVA: 0x7FFE810FB310
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÎÌÌÏÍÎÍÏÎÏÍÌÎÌÎÌÎÍÍÏÎÍ</summary>
    public class PlayerMoveNext_D4A0 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81474E00
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FB310
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void GetCachedPtr(){} // RVA: 0x7FFE81474E40
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE81474E80
        public void Instantiate(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÍÍÏÌÍÏÌÌÌÎÌÎÎÏÏÍÍÌÏÏÌÏ</summary>
    public class PlayerMoveNext_D5EC : Object
    {
        public int _m_CachedPtr; // 0x10
        public UnityEngine.GameObject _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void GetEnumerator(){} // RVA: 0x7FFE81AFC820
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE81AFC9F0
        public void MoveNext(){} // RVA: 0x7FFE81AFCAB0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE81AFD3D0
        public void System.Collections.Generic.IEnumerable<UnityEngine.GameObject>.GetEnumerator(){} // RVA: 0x7FFE81AFD430
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE81AFD430
        public void System.Collections.Generic.IEnumerator<UnityEngine.GameObject>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81AFD4C0
        public void get_Current(){} // RVA: 0x7FFE81AFD500
        public void Equals(){} // RVA: 0x7FFE81AFD540
        public void GetHashCode(){} // RVA: 0x7FFE81AFDE00
        public void .ctor(){} // RVA: 0x7FFE8156F420
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void ToString(){} // RVA: 0x7FFE81AFDE60
    }

    /// <summary>Originally: ÌÌÏÍÏÍÍÎÍÎÎÏÎÎÎÎÎÎÍÎÌÎÎ</summary>
    public class PlayerMoveNext_D6F2 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFE82006180
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82006E50
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE82006E90
        public void GetCachedPtr(){} // RVA: 0x7FFE810FB310
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void Instantiate(){} // RVA: 0x7FFE82006ED0
    }

    /// <summary>Originally: ÌÏÌÎÎÏÍÌÏÏÌÍÏÍÎÏÏÍÌÌÏÌÎ</summary>
    public class PlayerMoveNext_D7C8 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFE823E3B10
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE823E3D70
        public void GetCachedPtr(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void set_name(){} // RVA: 0x7FFE823E3DB0
        public void Instantiate(){} // RVA: 0x7FFE823E3DF0
        public void get_Current(){} // RVA: 0x7FFE810FB310
        public void Equals(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÌÌÎÍÎÌÎÍÍÎÍÍÌÎÎÏÌÏÎÏÌÌ</summary>
    public class PlayerMoveNext_DA2D : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE82651DD0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void op_Implicit(){} // RVA: 0x7FFE82651E10
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FB310
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE82651E50
        public void GetCachedPtr(){} // RVA: 0x7FFE810FB310
        public void get_name(){} // RVA: 0x7FFE82651E90
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE82651ED0
    }

    /// <summary>Originally: ÌÎÏÍÏÌÎÌÏÏÍÏÌÍÎÌÌÏÎÏÏÏÏ</summary>
    public class PlayerMoveNext_DD3C : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FB310
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE819A3B50
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE819A3B90
        public void MoveNext(){} // RVA: 0x7FFE819A3BD0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FE7C0
        public void GetCachedPtr(){} // RVA: 0x7FFE810FB310
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÍÌÌÍÌÍÌÏÍÍÍÌÌÎÍÎÌÍÏÍÍÍ</summary>
    public class PlayerMoveNext_DF07 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE8219C190
        public void op_Implicit(){} // RVA: 0x7FFE8219C1D0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE8219C210
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void get_name(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE8219C250
        public void Instantiate(){} // RVA: 0x7FFE810FB310
        public void get_Current(){} // RVA: 0x7FFE8219C340
    }

    /// <summary>Originally: ÌÎÍÍÌÌÎÌÎÏÌÌÌÍÏÏÍÍÌÏÍÌÏ</summary>
    public class PlayerMoveNext_E87A : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81398600
        public void get_Current(){} // RVA: 0x7FFE810FB310
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FB310
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81398640
        public void MoveNext(){} // RVA: 0x7FFE81398680
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void set_name(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE81398760
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÌÌÌÏÏÍÏÍÌÎÎÍÎÍÎÌÎÏÍÍÏÌ</summary>
    public class PlayerMoveNext_EB63 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE81627D40
        public void op_Implicit(){} // RVA: 0x7FFE81628080
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE816283C0
        public void GetCachedPtr(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81628400
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÌÌÎÍÌÌÌÌÎÌÏÏÌÏÏÌÌÌÎÎÍÍ</summary>
    public class PlayerMoveNext_EC2C : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void MoveNext(){} // RVA: 0x7FFE825F0AD0
        public void get_Current(){} // RVA: 0x7FFE825F0BC0
        public void op_Implicit(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE825F0C30
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE825F0CA0
        public void Instantiate(){} // RVA: 0x7FFE825F0CE0
    }

    /// <summary>Originally: ÌÏÏÍÏÌÏÍÌÌÎÌÏÏÏÍÍÎÍÍÎÌÍ</summary>
    public class PlayerMoveNext_F956 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FB310
        public void get_Current(){} // RVA: 0x7FFE810FB310
        public void Equals(){} // RVA: 0x7FFE81C24FE0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE81C255F0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE81C25C10
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÌÏÎÌÎÏÌÎÍÍÌÎÏÏÎÎÍÍÏÎÎÍ</summary>
    public class PlayerMoveNext_FC00 : Object
    {
        public int _m_CachedPtr; // 0x10
        public object _offsetOfInstanceIDInCPlusPlusObject; // 0x18

        // ── Methods ──
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE827042E0
        public void MoveNext(){} // RVA: 0x7FFE82704320
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
        public void CompareBaseObjects(){} // RVA: 0x7FFE827046B0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE827046F0
        public void GetCachedPtr(){} // RVA: 0x7FFE810FE7C0
        public void get_name(){} // RVA: 0x7FFE810FB310
        public void set_name(){} // RVA: 0x7FFE82704A80
        public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void Instantiate(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÌÍÎÌÎÍÏÏÍÍÎÌÎÏÏÌÎÍÍÍÏÎ</summary>
    public class PlayerNet : NetworkReadyHandler_FB37
    {
        public 0x66648F64 _typeId; // 0x58
        public VRC.Core.Networking.PositionEvent f_8FF; // 0x60
        public VRC.Core.Networking.PositionEvent f_189; // 0x68
        public VRC.Core.Networking.PositionEvent _lastPosition; // 0x70
        public VRC.Core.Networking.ConcurrentLimitedCapacityList`1<VRC.Core.Networking.PositionEvent> _uniqueHash; // 0x78
        public System.Action`1<bool> f_112; // 0x80
        public bool f_A54; // 0x88
        public bool f_B8A; // 0x89
        public bool f_319; // 0x8A
        public bool f_DA2; // 0x8B
        public bool f_6A3; // 0x8C
        public bool f_5BF; // 0x8D
        public bool f_8F0; // 0x8E
        public bool f_2BD; // 0x8F
        public bool f_C3E; // 0x90
        public bool f_FC2; // 0x91
        public bool f_7A3; // 0x92
        public bool f_125; // 0x93
        public bool f_6B6; // 0x94
        public 0x66699D44 f_0FE;
        public 0x66699D44 f_2A4;
        public bool f_E5A; // 0x95
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3T f_13C; // 0x98
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionT f_111; // 0xA0
        public bool f_7F0; // 0xA8

        // ── Methods ──
        public void EnableKinematic(){} // RVA: 0x7FFE820BB6E0
        public void GetPlayerNetworkId(){} // RVA: 0x7FFE81643620
        public void SyncPlayerState(){} // RVA: 0x7FFE81FF0890
        public void GetVideoHeight(){} // RVA: 0x7FFE820BB920
        public void SerializePlayerData(){} // RVA: 0x7FFE820BBB00
        public void GenerateComponentInfo(){} // RVA: 0x7FFE820BC640
        public void DeserializePlayerData(){} // RVA: 0x7FFE820BC750
        public void GetLastPosition(){} // RVA: 0x7FFE820BC880
        public void SetLastPosition(){} // RVA: 0x7FFE820BCD00
        public void SerializedName(){} // RVA: 0x7FFE820BCE10
        public void OnPlayerSerialize(){} // RVA: 0x7FFE820BCF80
        public void Decode(){} // RVA: 0x7FFE820C2620 | overloaded x3
        public void OnPlayerDeserialize(){} // RVA: 0x7FFE820BD460
        public void GetNetworkOwner(){} // RVA: 0x7FFE820BD5D0
        public void OnCollisionEnter(){} // RVA: 0x7FFE820BD5E0
        public void TransferPlayerOwnership(){} // RVA: 0x7FFE820BD7B0
        public void CanSerialize32Bit(){} // RVA: 0x7FFE810FB320
        public void RequestNetworkSync(){} // RVA: 0x7FFE820BD7C0
        public void BroadcastPlayerData(){} // RVA: 0x7FFE820BD970
        public void GetTypeId(){} // RVA: 0x7FFE820BDAA0
        public void GetUniqueHash(){} // RVA: 0x7FFE820BDD90
        public void ResetSyncState(){} // RVA: 0x7FFE820BDDE0
        public void EnableNetworkSync(){} // RVA: 0x7FFE820BDF60
        public void DisableNetworkSync(){} // RVA: 0x7FFE820BDF70
        public void GetNetworkLatency_C7F4EEF36768(){} // RVA: 0x7FFE820C46D0 | overloaded x2
        public void set_TypeId(){} // RVA: 0x7FFE813A0830
        public void OnNetworkInitialized(){} // RVA: 0x7FFE820BE3A0
        public void GetNetworkPosition(){} // RVA: 0x7FFE820BE3B0
        public void get_TypeId(){} // RVA: 0x7FFE817F39D0
        public void Encode(){} // RVA: 0x7FFE820BFD20 | overloaded x2
        public void OnControllerColliderHit(){} // RVA: 0x7FFE820BF0C0
        public void CanSerialize8Bit(){} // RVA: 0x7FFE811E0850
        public void Awake(){} // RVA: 0x7FFE820BF410
        public void SetNetworkSynchronizationEnabled(){} // RVA: 0x7FFE820BF4E0
        public void DisableGravity(){} // RVA: 0x7FFE820BFEC0
        public void .cctor(){} // RVA: 0x7FFE820C02F0
        public void Start(){} // RVA: 0x7FFE820C06F0
        public void OnDestroy(){} // RVA: 0x7FFE820C07A0
        public void NeedsSync(){} // RVA: 0x7FFE820C0940
        public void set_LastPosition(){} // RVA: 0x7FFE820C1700
        public void .ctor(){} // RVA: 0x7FFE820C1810
        public void Initialize(){} // RVA: 0x7FFE820C1950
        public void get_LastPosition(){} // RVA: 0x7FFE81199370
        public void DisableKinematic(){} // RVA: 0x7FFE820C1B70
        public void NeedsImportant(){} // RVA: 0x7FFE820C1F60
        public void set_UniqueHash(){} // RVA: 0x7FFE820C2750
        public void get_UniqueHash(){} // RVA: 0x7FFE817F39D0
        public void OnDisable(){} // RVA: 0x7FFE820C36F0
        public void CanUsePersistenceHashes(){} // RVA: 0x7FFE820C4240
        public void GetNetworkProperty288(){} // RVA: 0x7FFE820C4CF0
        public void EnableGravity(){} // RVA: 0x7FFE820C8040
        // ── 59 unresolved (hash) ──
        public void m_AF5(){} // RVA: 0x7FFE820BE500
        public void m_495(){} // RVA: 0x7FFE820BF340
        public void m_02B(){} // RVA: 0x7FFE81163520
        public void m_FFA(){} // RVA: 0x7FFE81163530
        public void m_273(){} // RVA: 0x7FFE813A1DA0
        // ... 54 more unresolved methods
    }

    /// <summary>Originally: ÌÏÏÏÍÍÏÏÏÍÏÎÌÍÎÍÏÏÎÍÍÌÏ</summary>
    public class PlayerOwnerCanUseAnimatedEmoji_190F : BackingFieldBase_C330
    {
        public bool f_C2E; // 0x20
        public string _fullResolutionTexture; // 0x28
        public UnityEngine.Material _isAnimated; // 0x30
        public ÍÏÌÌÍÏÍÍÌÍÌÍÍÍÌÌÎÍÍÏÍÎÌ _ownerCanUseAnimatedEmoji; // 0x38
        public string _isSpecialFX;
        public VRC.Profiling.ProfilerMarker _sprite; // 0x40
        public VRC.Profiling.ProfilerMarker _isPremium; // 0x50
        public ÍÎÎÍÎÍÏÍÎÍÎÌÏÌÌÏÍÍÍÍÌÍÌ f_6C4; // 0x60
        public ÏÌÌÍÏÍÍÏÎÍÍÎÏÎÍÏÍÎÌÍÌÌÌ<UnityEngine.Texture2D> f_EF1; // 0x68
        public ÏÌÌÍÏÍÍÏÎÍÍÎÏÎÍÏÍÎÌÍÌÌÌ<UnityEngine.Texture2D> f_7C8; // 0x70
        public int _maskTag;
        public object field_11; // 0xAC6
        public object field_12; // 0xAC7
        public object field_13; // 0xAC8
        public object field_14; // 0xAC9
        public object field_15; // 0xACA
        public object field_16; // 0xACB
        public object field_17; // 0xACC
        public object field_18; // 0xACD
        public object field_19; // 0xACE

        // ── Methods ──
        public void get_FullResolutionTexture(){} // RVA: 0x7FFE811C3590
        public void set_FullResolutionTexture(){} // RVA: 0x7FFE81129130
        public void get_IsAnimated(){} // RVA: 0x7FFE829BF150
        public void get_OwnerCanUseAnimatedEmoji(){} // RVA: 0x7FFE811E99D0
        public void set_IsAnimated(){} // RVA: 0x7FFE829BF170
        public void set_IsSpecialFX(){} // RVA: 0x7FFE81199380
        public void get_IsSpecialFX(){} // RVA: 0x7FFE81CC8410
        public void set_IsPremium(){} // RVA: 0x7FFE810FCE90
        public void set_Sprite(){} // RVA: 0x7FFE829BF230
        public void get_FullResolutionTexture_26438B58A324(){} // RVA: 0x7FFE811C35A0
        public void get_Sprite(){} // RVA: 0x7FFE813240E0
        public void get_IsPremium(){} // RVA: 0x7FFE829BF250
        public void set_MaskTag(){} // RVA: 0x7FFE811E99E0
        public void .ctor(){} // RVA: 0x7FFE829BF270
        public void Initialize(){} // RVA: 0x7FFE829BF400
        public void set_FPS(){} // RVA: 0x7FFE810FCE90
        public void get_MaskTag(){} // RVA: 0x7FFE81758DE0
        public void get_IsSpecialFX_847EA416C069(){} // RVA: 0x7FFE829BF450
        public void get_IsAnimated_BEB0A3809A14(){} // RVA: 0x7FFE811C35A0
        public void get_FPS(){} // RVA: 0x7FFE81D31400
        public void set_LoopStyle(){} // RVA: 0x7FFE829BF510
        public void get_LoopStyle(){} // RVA: 0x7FFE829BF580
        public void set_OwnerCanUseAnimatedEmoji(){} // RVA: 0x7FFE811E99E0
        public void set_IsBuiltIn(){} // RVA: 0x7FFE829BF5E0
        public void set_AnimationStyle(){} // RVA: 0x7FFE81C798B0
        public void set_LoadFrom(){} // RVA: 0x7FFE81199370
        public void get_Sprite_EB4DFDB9587A(){} // RVA: 0x7FFE8170F950
        public void get_IsBuiltIn(){} // RVA: 0x7FFE810FB320
        public void get_FileId_0905863ADCAE(){} // RVA: 0x7FFE8144E200
        public void get_LoadFrom(){} // RVA: 0x7FFE829BF7A0
        public void get_AnimationStyle(){} // RVA: 0x7FFE8170F950
        public void set_DisplayTexture(){} // RVA: 0x7FFE829BF7D0
        public void set_EffectBundleID(){} // RVA: 0x7FFE81176D60
        public void get_DisplayTexture(){} // RVA: 0x7FFE81176D50
        public void get_EffectBundleID(){} // RVA: 0x7FFE81728950
        public void get_FileId(){} // RVA: 0x7FFE81C3B5F0
        public void get_SpawnablePrefabName(){} // RVA: 0x7FFE81129130
        public void set_SpawnablePrefabName(){} // RVA: 0x7FFE811C35A0
        public void get_Frames(){} // RVA: 0x7FFE829BF230
    }

    /// <summary>Originally: ÌÌÌÌÍÏÎÎÍÍÌÍÍÌÎÎÎÌÎÍÌÎÌ</summary>
    public class PlayerRectTransformDimensRelated_9C87 : Object
    {
        public UnityEngine.Vector2 _m_CachedPtr; // 0x10

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE89E5D190
        public void Equals(){} // RVA: 0x7FFE89E5DE30
        public void GetHashCode(){} // RVA: 0x7FFE89E5DF00
        public void op_Implicit(){} // RVA: 0x7FFE89E5DFD0
        public void CompareBaseObjects(){} // RVA: 0x7FFE89E5E0A0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE826F2ED0
        public void GetCachedPtr(){} // RVA: 0x7FFE83BB1530
        public void .ctor(){} // RVA: 0x7FFE89E5EF30
        public void Initialize(){} // RVA: 0x7FFE89E5F090
        public void Instantiate(){} // RVA: 0x7FFE83BB1530
        public void ToString(){} // RVA: 0x7FFE89E5F150
        public void GetHashCode_B141D57B5F2E(){} // RVA: 0x7FFE89E5F220
        public void ToString_7F4C6B10889D(){} // RVA: 0x7FFE826F2ED0
    }

    /// <summary>Originally: ÌÏÍÏÍÎÏÎÌÎÏÎÎÎÍÍÏÏÌÌÏÍÏ</summary>
    public class PlayerShouldActivateModuleIsModuleSupported_D8D5 : PointerInputModule
    {
        public float f_109;
        public float f_FFB;
        public float f_1C1;
        public float f_E2F; // 0x4
        public string m_HorizontalAxis; // 0x68
        public string m_VerticalAxis; // 0x70
        public float m_InputActionsPerSecond; // 0x78

        // ── Methods ──
        public void GetPointerData(){} // RVA: 0x7FFE81176D50
        public void DeactivateModule(){} // RVA: 0x7FFE825FB450
        public void .ctor(){} // RVA: 0x7FFE825FB460
        public void ShouldActivateModule(){} // RVA: 0x7FFE825FB8F0
        public void StateForMouseButton(){} // RVA: 0x7FFE811C3590
        public void Start(){} // RVA: 0x7FFE825FBB00
        public void GetMousePointerEventData(){} // RVA: 0x7FFE825FBD30
        public void ActivateModule(){} // RVA: 0x7FFE825FBED0
        public void ShouldStartDrag(){} // RVA: 0x7FFE813A1130
        public void ProcessDrag(){} // RVA: 0x7FFE825FC030
        public void IsModuleSupported(){} // RVA: 0x7FFE811E0850
        public void IsPointerOverGameObject(){} // RVA: 0x7FFE811240E0
        public void ClearSelection(){} // RVA: 0x7FFE825FC6D0
        public void ShouldActivateModule_64774D6B27AE(){} // RVA: 0x7FFE825FC800
        public void DeselectIfSelectionChanged(){} // RVA: 0x7FFE825FCB60
        public void IsModuleSupported_4C16D783CB0C(){} // RVA: 0x7FFE825FCBF0
        public void ProcessMove(){} // RVA: 0x7FFE825FCCC0
        public void GetPointerData_737FC1EE7F4B(){} // RVA: 0x7FFE825FCCE0
        public void GetMousePointerEventData_FE3E1FB91A56(){} // RVA: 0x7FFE825FCFC0
        public void ProcessMouseEvent(){} // RVA: 0x7FFE825FD060
        public void ProcessTouchEvent(){} // RVA: 0x7FFE811240F0
        public void UpdateModule_E6C5699D8589(){} // RVA: 0x7FFE825FDCC0
        public void DeactivateModule_B56C138020AE(){} // RVA: 0x7FFE813A2040
        public void ActivateModule_1638765F46A9(){} // RVA: 0x7FFE81124110
        public void ProcessInput(){} // RVA: 0x7FFE81124100
        public void ClearPointerSelection(){} // RVA: 0x7FFE81176D60
        public void HandlePointerExit(){} // RVA: 0x7FFE825FE9E0
        public void HandlePointerEnter(){} // RVA: 0x7FFE825FEA90
        public void OnFocusChanged(){} // RVA: 0x7FFE813A1130
        public void GetMouseButtonState(){} // RVA: 0x7FFE811C35A0
        public void ResetInputModule(){} // RVA: 0x7FFE825FEB60
        public void Process(){} // RVA: 0x7FFE825FED00
        public void UpdateModule(){} // RVA: 0x7FFE825FFA40
        public void .cctor(){} // RVA: 0x7FFE825FFA90
        // ── 16 unresolved (hash) ──
        public void m_931(){} // RVA: 0x7FFE825FF050
        public void m_F59(){} // RVA: 0x7FFE825FF220
        public void m_E64(){} // RVA: 0x7FFE825FF590
        public void m_6FB(){} // RVA: 0x7FFE813240E0
        public void m_4D8(){} // RVA: 0x7FFE825FF890
        // ... 11 more unresolved methods
    }

    /// <summary>Originally: ÌÎÎÍÍÎÎÏÍÏÏÌÌÍÌÌÌÎÎÍÏÎÌ</summary>
    public class Playerk__BackingFieldCompRelated_68A4 : Playerk__BackingFieldComponentSibling_681D
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82411A90
        public void Initialize(){} // RVA: 0x7FFE82411AD0
        // ── Unresolved (hash) ──
        public void m_659(){} // RVA: 0x7FFE824111E0
        public void m_BDE(){} // RVA: 0x7FFE824113F0
        public void m_B1F(){} // RVA: 0x7FFE82411600
        public void m_1AA(){} // RVA: 0x7FFE82411670
        public void m_C0B(){} // RVA: 0x7FFE82411880
        public void m_305(){} // RVA: 0x7FFE82411B10
        public void m_347(){} // RVA: 0x7FFE82411D20
        public void m_516(){} // RVA: 0x7FFE82411F30
        public void m_50E(){} // RVA: 0x7FFE824120C0
        public void m_89E(){} // RVA: 0x7FFE824122D0
    }

    /// <summary>Originally: ÍÌÌÍÎÍÎÏÎÎÌÏÌÍÍÌÏÌÏÍÌÎÌ</summary>
    public class Playerk__BackingFieldComponentSibling_171E : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81581920
        public void Equals(){} // RVA: 0x7FFE81581F20
        public void GetHashCode(){} // RVA: 0x7FFE81582370
        public void op_Implicit(){} // RVA: 0x7FFE81582550
        public void .ctor(){} // RVA: 0x7FFE815826F0
        public void Initialize(){} // RVA: 0x7FFE81582940
        public void GetCachedPtr(){} // RVA: 0x7FFE81582A40
        public void get_name(){} // RVA: 0x7FFE81582C20
        public void set_name(){} // RVA: 0x7FFE81582DF0
        public void Instantiate(){} // RVA: 0x7FFE81583240
        public void ToString(){} // RVA: 0x7FFE81583A70
        public void FailFast(){} // RVA: 0x7FFE815841B0
        public void .ctor_BB5C92452907(){} // RVA: 0x7FFE81584350
        public void Initialize_0133EBB407DB(){} // RVA: 0x7FFE81584E10
        public void ToString_956FE7FE4DBF(){} // RVA: 0x7FFE81585440
        public void .cctor(){} // RVA: 0x7FFE81586560
        public void GetBooleanFromDelegate(){} // RVA: 0x7FFE81587180
        public void GetIntegerFromDelegate(){} // RVA: 0x7FFE81587350
        // ── Unresolved (hash) ──
        public void m_D33(){} // RVA: 0x7FFE815873D0
    }

    /// <summary>Originally: ÌÍÏÎÌÍÌÍÌÍÍÏÏÎÎÍÍÌÎÎÍÎÌ</summary>
    public class Playerk__BackingFieldComponentSibling_1BA5
    {
        // ── Unresolved (hash) ──
        public void m_A67(){} // RVA: 0x7FFE80E2E2E0
        public void m_986(){} // RVA: 0x7FFE80E2E2E0
        public void m_541(){} // RVA: 0x7FFE80E2F150
        public void m_B4D(){} // RVA: 0x7FFE80E2EDB0
        public void m_F58(){} // RVA: 0x7FFE80E2E2E0
        public void m_EAD(){} // RVA: 0x7FFE80E2F150
        public void m_360(){} // RVA: 0x7FFE80E2F150
        public void m_162(){} // RVA: 0x7FFE80E2E2E0
        public void m_1B2(){} // RVA: 0x7FFE80E2E2E0
        public void m_DC2(){} // RVA: 0x7FFE80E2E2E0
    }

    /// <summary>Originally: ÌÌÍÌÏÌÎÌÎÏÍÍÍÎÌÏÍÎÎÍÍÏÍ</summary>
    public class Playerk__BackingFieldComponentSibling_493C : Object
    {
        public ÌÌÍÌÏÌÎÌÎÏÍÍÍÎÌÏÍÎÎÍÍÏÍ _m_CachedPtr;
        public bool _offsetOfInstanceIDInCPlusPlusObject; // 0x10
        public string f_D7E; // 0x18
        public string f_9D8; // 0x20
        public object field_4; // 0xC5C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE814EB680
        public void Initialize(){} // RVA: 0x7FFE814EB720
        public void Equals(){} // RVA: 0x7FFE814EB7B0
        public void op_Implicit(){} // RVA: 0x7FFE814EB870
        public void CompareBaseObjects(){} // RVA: 0x7FFE814EB930
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE814EB9D0
        public void GetCachedPtr(){} // RVA: 0x7FFE814EBA60
        public void get_name(){} // RVA: 0x7FFE814EBAF0
        public void set_name(){} // RVA: 0x7FFE814EBA60
        public void Instantiate(){} // RVA: 0x7FFE814EBB90
        public void GetHashCode(){} // RVA: 0x7FFE814EBBD0
        public void ToString(){} // RVA: 0x7FFE814EBC90
        public void GetHashCode_E9848305AF00(){} // RVA: 0x7FFE814EBD30
        public void .ctor_B277F382F1D1(){} // RVA: 0x7FFE814EBF00
        // ── Unresolved (hash) ──
        public void m_283(){} // RVA: 0x7FFE814EBDF0
    }

    /// <summary>Originally: ÌÍÌÏÏÎÏÍÎÍÌÎÎÌÎÎÎÎÌÏÌÍÎ</summary>
    public class Playerk__BackingFieldComponentSibling_50BB
    {
        // ── 28 unresolved (hash) ──
        public void m_77E(){} // RVA: 0x7FFE80E2EDB0
        public void m_D64(){} // RVA: 0x7FFE80E2E2E0
        public void m_AF8(){} // RVA: 0x7FFE80E2E2E0
        public void m_1C6(){} // RVA: 0x7FFE80E2E2E0
        public void m_450(){} // RVA: 0x7FFE80E2E2E0
        // ... 23 more unresolved methods
    }

    /// <summary>Originally: ÌÎÍÌÍÌÏÍÍÍÏÍÏÎÏÎÍÏÌÎÍÌÍ</summary>
    public class Playerk__BackingFieldComponentSibling_79FC
    {
        // ── 12 unresolved (hash) ──
        public void m_B1F(){} // RVA: 0x7FFE80E2E390
        public void m_834(){} // RVA: 0x7FFE80E2E390
        public void m_2E2(){} // RVA: 0x7FFE80E460A0
        public void m_2EB(){} // RVA: 0x7FFE80E460A0
        public void m_A4D(){} // RVA: 0x7FFE80E460A0
        // ... 7 more unresolved methods
    }

    /// <summary>Originally: ÌÎÎÌÏÌÎÌÎÏÎÎÌÍÏÍÎÍÌÍÌÎÍ</summary>
    public class Playerk__BackingFieldComponentSibling_8126 : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8290A1D0
        public void Equals(){} // RVA: 0x7FFE8290A4B0
        public void op_Implicit(){} // RVA: 0x7FFE8290A8B0 | overloaded x2
        public void CompareBaseObjects(){} // RVA: 0x7FFE8290AE50
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810A1420
        public void GetCachedPtr(){} // RVA: 0x7FFE810A1420
        public void get_name(){} // RVA: 0x7FFE8290B320
        public void set_name(){} // RVA: 0x7FFE8290B4C0
        public void Instantiate(){} // RVA: 0x7FFE810A1420
        public void ToString(){} // RVA: 0x7FFE8290B730
        public void GetHashCode(){} // RVA: 0x7FFE8290B8D0
        public void Instantiate_9FE32F4DAF74(){} // RVA: 0x7FFE8290BD90
        public void Instantiate_DF18F240FE7B(){} // RVA: 0x7FFE8290BEF0
        public void Instantiate_F86062846EC3(){} // RVA: 0x7FFE8290BFF0
        public void Instantiate_47823FF1A1C0(){} // RVA: 0x7FFE8290C0F0
        public void Destroy(){} // RVA: 0x7FFE8290C1F0
        public void Destroy_311FE5C48CC8(){} // RVA: 0x7FFE8290C2F0
        public void Destroy_3578F6C89AB0(){} // RVA: 0x7FFE8290C3F0
        public void .cctor(){} // RVA: 0x7FFE8290C550
    }

    /// <summary>Originally: ÌÌÌÎÍÌÍÎÌÏÌÌÌÌÍÏÍÍÌÌÎÌÌ</summary>
    public class Playerk__BackingFieldComponentSibling_8F85 : Object
    {
        public ÌÌÌÎÍÌÍÎÌÏÌÌÌÌÍÏÍÍÌÌÎÌÌ _m_CachedPtr;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82132A10
        public void Equals(){} // RVA: 0x7FFE82132BD0
        public void GetHashCode(){} // RVA: 0x7FFE82132D30
        public void op_Implicit(){} // RVA: 0x7FFE82132F00
        public void CompareBaseObjects(){} // RVA: 0x7FFE821331C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE82133270
        public void .cctor(){} // RVA: 0x7FFE821332D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE821334B0
        public void Instantiate(){} // RVA: 0x7FFE82133770
        public void ToString(){} // RVA: 0x7FFE82133930
        public void DoJoinCore(){} // RVA: 0x7FFE82133BD0
        public void .ctor_08AC7C0F352F(){} // RVA: 0x7FFE82133DA0
        public void .cctor_431BBDFB10EB(){} // RVA: 0x7FFE82133E50
        // ── Unresolved (hash) ──
        public void m_F04(){} // RVA: 0x7FFE82133A90
        public void m_9A9(){} // RVA: 0x7FFE82133EB0
    }

    /// <summary>Originally: ÌÎÏÍÏÍÍÌÎÍÍÌÏÎÌÎÎÌÎÏÌÌÎ</summary>
    public class Playerk__BackingFieldComponent_7639 : MonoBehaviour
    {
        public ÌÎÏÍÏÍÍÌÎÍÍÌÏÎÌÎÎÌÎÏÌÌÎ _m_CancellationTokenSource;
        public UnityEngine.LayerMask layerMask; // 0x20
        public UnityEngine.LayerMask f_FE8; // 0x24
        public UnityEngine.GameObject f_1AB; // 0x28
        public VRC.StickerCollectionPrefab f_473; // 0x30
        public ÏÌÎÎÎÏÌÍÍÎÌÌÎÍÏÌÏÌÍÎÎÏÌ<System.Collections.Generic.List`1<ÌÎÍÍÌÍÎÏÍÎÌÏÌÎÌÎÎÍÍÎÏÌÌ>> f_9F1; // 0x38
        public string f_1CA; // 0x8
        public int f_AA6; // 0x40
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_456; // 0x48
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_AE7; // 0x50
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<System.Collections.Generic.List`1<ÌÎÍÍÌÍÎÏÍÎÌÏÌÎÌÎÎÍÍÎÏÌÌ>> f_60A; // 0x58
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<System.Collections.Generic.List`1<ÌÎÍÍÌÍÎÏÍÎÌÏÌÎÌÎÎÍÍÎÏÌÌ>> f_5E6; // 0x60
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<System.Collections.Generic.List`1<ÌÎÍÍÌÍÎÏÍÎÌÏÌÎÌÎÎÍÍÎÏÌÌ>> f_6A3; // 0x68
        public System.Collections.Generic.List`1<ÌÎÌÏÌÌÎÍÎÏÌÍÌÎÏÌÍÌÍÌÏÎÏ> f_4F6; // 0x70
        public ÌÎÍÍÌÎÎÍÌÌÍÏÍÎÏÌÎÍÌÏÍÏÎ f_CF2; // 0x78
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<int> f_5DE; // 0x80
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<int> f_76E; // 0x88
        public System.Collections.Generic.HashSet`1<ÌÍÏÍÎÍÌÎÏÌÎÏÌÍÏÍÎÍÎÍÎÎÍ> f_91B; // 0x90
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<System.Collections.Generic.List`1<ÌÎÍÍÌÎÎÍÌÌÍÏÍÎÏÌÎÍÌÏÍÏÎ>> f_B8B; // 0x98
        public ÌÎÍÍÌÎÎÍÌÌÍÏÍÎÏÌÎÍÌÏÍÏÎ f_D37; // 0xA0
        public ÌÎÍÍÌÎÎÍÌÌÍÏÍÎÏÌÎÍÌÏÍÏÎ f_003; // 0xA8
        public ÌÎÍÍÌÎÎÍÌÌÍÏÍÎÏÌÎÍÌÏÍÏÎ f_94C; // 0xB0
        public ÌÎÍÍÌÎÎÍÌÌÍÏÍÎÏÌÎÍÌÏÍÏÎ f_01E; // 0xB8
        public ÌÎÍÍÌÎÎÍÌÌÍÏÍÎÏÌÎÍÌÏÍÏÎ f_432; // 0xC0
        public ÌÏÌÎÌÌÌÏÌÍÍÌÏÏÏÏÎÏÍÌÌÎÌ f_70A; // 0xC8

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE81C57BA0
        public void RaiseCancellation(){} // RVA: 0x7FFE81C57BF0
        public void IsInvoking(){} // RVA: 0x7FFE81218100
        public void CancelInvoke(){} // RVA: 0x7FFE81C57DF0
        public void Invoke(){} // RVA: 0x7FFE8158E950
        public void InvokeRepeating(){} // RVA: 0x7FFE81C58150
        public void StartCoroutine(){} // RVA: 0x7FFE81C581E0
        public void .ctor(){} // RVA: 0x7FFE81C58350
        public void Initialize(){} // RVA: 0x7FFE81C58D90
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE81C58EB0
        public void StopCoroutine(){} // RVA: 0x7FFE81C58EE0
        public void .cctor(){} // RVA: 0x7FFE81C59010
        public void StopAllCoroutines(){} // RVA: 0x7FFE81C599C0
        public void get_useGUILayout(){} // RVA: 0x7FFE81C59AB0
        public void set_useGUILayout(){} // RVA: 0x7FFE81C59E70
        public void print(){} // RVA: 0x7FFE81C5A0D0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE81C5A4B0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFE81C5AC10
        public void InvokeDelayed(){} // RVA: 0x7FFE81C5AE30
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFE81C5C190 | overloaded x2
        public void StartCoroutineManaged(){} // RVA: 0x7FFE81C5B9A0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFE81C5BC30
        public void StopCoroutineManaged(){} // RVA: 0x7FFE81C5BDA0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFE81C5C0D0
        public void GetScriptClassName(){} // RVA: 0x7FFE81C5C130
        public void Awake(){} // RVA: 0x7FFE81166130
        public void OnEnable(){} // RVA: 0x7FFE81C5C1A0
        public void Start(){} // RVA: 0x7FFE81C5C240
        public void Update(){} // RVA: 0x7FFE81C5DCF0
        public void LateUpdate(){} // RVA: 0x7FFE81C5DDF0
        public void OnDisable(){} // RVA: 0x7FFE81C5E0F0
        public void OnApplicationPause(){} // RVA: 0x7FFE811660C0
        public void OnApplicationQuit(){} // RVA: 0x7FFE81C5E6D0
        public void OnBecameVisible(){} // RVA: 0x7FFE8119C0E0
        public void OnBecameInvisible(){} // RVA: 0x7FFE81C5F0D0
        public void OnCollisionEnter(){} // RVA: 0x7FFE81C5F320
        public void OnCollisionStay(){} // RVA: 0x7FFE8158C5E0
        public void OnCollisionExit(){} // RVA: 0x7FFE81166120
        public void OnTriggerEnter(){} // RVA: 0x7FFE81C5F490
        public void OnTriggerStay(){} // RVA: 0x7FFE81C5F4E0
        public void OnTriggerExit(){} // RVA: 0x7FFE81C5F590
        public void FixedUpdate(){} // RVA: 0x7FFE81C61C20
        public void OnDestroy(){} // RVA: 0x7FFE81C620D0
        // ── 57 unresolved (hash) ──
        public void m_CD1(){} // RVA: 0x7FFE811660B0
        public void m_E59(){} // RVA: 0x7FFE81C581B0
        public void m_486(){} // RVA: 0x7FFE81C59920
        public void m_F26(){} // RVA: 0x7FFE81C5B100
        public void m_956(){} // RVA: 0x7FFE81C60870
        // ... 52 more unresolved methods
    }

    /// <summary>Originally: ÌÌÎÍÍÏÏÍÎÍÍÍÍÏÏÏÎÎÌÌÎÍÏ</summary>
    public class PlayeruserEventCarouselnotificationComponent_6081 : MonoBehaviour
    {
        public ÌÌÎÍÍÏÏÍÎÍÍÍÍÏÏÏÎÎÌÌÎÍÏ _6081;
        public ÍÏÏÎÌÍÏÍÍÎÏÏÍÍÎÏÎÌÏÎÍÍÌ notification; // 0x20
        public ÏÌÎÌÎÌÌÌÏÌÌÌÎÏÎÍÍÎÌÌÎÌÌ move; // 0x28
        public ÎÌÏÎÏÍÏÎÏÏÌÌÌÎÌÏÍÍÎÍÍÍÏ userEventCarousel; // 0x30

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE81A7D1D0
        public void RaiseCancellation(){} // RVA: 0x7FFE8119C0E0
        public void IsInvoking(){} // RVA: 0x7FFE81A7D270
        public void CancelInvoke(){} // RVA: 0x7FFE81318010
        public void Invoke(){} // RVA: 0x7FFE81A7D2D0
        public void InvokeRepeating(){} // RVA: 0x7FFE81A7DAC0
        public void OnEnable(){} // RVA: 0x7FFE81A7DCB0
        public void FixedUpdate(){} // RVA: 0x7FFE810FB320
        public void StartCoroutine(){} // RVA: 0x7FFE81A7DF80
        public void Update(){} // RVA: 0x7FFE81A7E100
        public void LateUpdate(){} // RVA: 0x7FFE81A7E150
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE81A7E1F0
        public void OnDestroy(){} // RVA: 0x7FFE81A7E2D0
        public void StopCoroutine(){} // RVA: 0x7FFE81A7ECA0
        public void OnApplicationQuit(){} // RVA: 0x7FFE81A7F0A0
        public void StopAllCoroutines(){} // RVA: 0x7FFE81A7F280
        public void get_useGUILayout(){} // RVA: 0x7FFE81A7F2A0
        public void set_useGUILayout(){} // RVA: 0x7FFE81A7F3D0
        public void print(){} // RVA: 0x7FFE81A7F500
        public void .ctor(){} // RVA: 0x7FFE81A7F810
        public void Start(){} // RVA: 0x7FFE81A7F8C0
        public void InvokeDelayed(){} // RVA: 0x7FFE81A7F960
        public void OnTriggerExit(){} // RVA: 0x7FFE81A7FC00
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE81A7FDD0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE81A7FF80
        public void StartCoroutineManaged(){} // RVA: 0x7FFE81A801B0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFE81A80380
        public void StopCoroutineManaged(){} // RVA: 0x7FFE81A80600
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFE81A80860
        public void GetScriptClassName(){} // RVA: 0x7FFE81A809F0
        public void Awake(){} // RVA: 0x7FFE81A80D20
        public void OnCollisionStay(){} // RVA: 0x7FFE81A80FF0
        public void OnCollisionExit(){} // RVA: 0x7FFE81A81160
        public void OnTriggerEnter(){} // RVA: 0x7FFE81A812D0
        public void OnTriggerStay(){} // RVA: 0x7FFE81A812E0
        public void OnTriggerExit_68F9FA1D6228(){} // RVA: 0x7FFE81A81570
        public void OnDisable(){} // RVA: 0x7FFE81317920
        public void RetrieveAndProcessComponentData(){} // RVA: 0x7FFE81A816A0
        public void OnApplicationPause(){} // RVA: 0x7FFE81A819C0
        public void HasComponentState(){} // RVA: 0x7FFE81A81A10
        public void OnBecameVisible(){} // RVA: 0x7FFE81A82200
    }

}