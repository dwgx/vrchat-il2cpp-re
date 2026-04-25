// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Wrapper.Modules
// Classes: 100
// Methods: 5591

namespace VRC.Udon.Wrapper.Modules
{
    public class ExternUnityEngineParticleSystemNoiseModule : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACACAD9F0
        public void .ctor(){} // RVA: 0x7FFACACADA30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACACADE00
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACACADF30
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACACAE040
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACACAE180
        public void __GetType__SystemType(){} // RVA: 0x7FFACACAE230
        public void __ToString__SystemString(){} // RVA: 0x7FFACACAE320
        public void __get_damping__SystemBoolean(){} // RVA: 0x7FFACACAE3D0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACACAE4B0
        public void __get_frequency__SystemSingle(){} // RVA: 0x7FFACACAE590
        public void __get_octaveCount__SystemInt32(){} // RVA: 0x7FFACACAE670
        public void __get_octaveMultiplier__SystemSingle(){} // RVA: 0x7FFACACAE750
        public void __get_octaveScale__SystemSingle(){} // RVA: 0x7FFACACAE830
        public void __get_positionAmount__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACAE910
        public void __get_quality__UnityEngineParticleSystemNoiseQuality(){} // RVA: 0x7FFACACAEA20
        public void __get_remapEnabled__SystemBoolean(){} // RVA: 0x7FFACACAEB00
        public void __get_remapMultiplier__SystemSingle(){} // RVA: 0x7FFACACAEBE0
        public void __get_remapXMultiplier__SystemSingle(){} // RVA: 0x7FFACACAECC0
        public void __get_remapX__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACAEDA0
        public void __get_remapYMultiplier__SystemSingle(){} // RVA: 0x7FFACACAEEB0
        public void __get_remapY__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACAEF90
        public void __get_remapZMultiplier__SystemSingle(){} // RVA: 0x7FFACACAF0A0
        public void __get_remapZ__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACAF180
        public void __get_remap__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACAF290
        public void __get_rotationAmount__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACAF3A0
        public void __get_scrollSpeedMultiplier__SystemSingle(){} // RVA: 0x7FFACACAF4B0
        public void __get_scrollSpeed__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACAF590
        public void __get_separateAxes__SystemBoolean(){} // RVA: 0x7FFACACAF6A0
        public void __get_sizeAmount__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACAF780
        public void __get_strengthMultiplier__SystemSingle(){} // RVA: 0x7FFACACAF890
        public void __get_strengthXMultiplier__SystemSingle(){} // RVA: 0x7FFACACAF970
        public void __get_strengthX__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACAFA50
        public void __get_strengthYMultiplier__SystemSingle(){} // RVA: 0x7FFACACAFB60
        public void __get_strengthY__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACAFC40
        public void __get_strengthZMultiplier__SystemSingle(){} // RVA: 0x7FFACACAFD50
        public void __get_strengthZ__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACAFE30
        public void __get_strength__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACAFF40
        public void __set_damping__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACB0050
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACB0170
        public void __set_frequency__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACB0290
        public void __set_octaveCount__SystemInt32__SystemVoid(){} // RVA: 0x7FFACACB03B0
        public void __set_octaveMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACB04D0
        public void __set_octaveScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACB05F0
        public void __set_positionAmount__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACB0710
        public void __set_quality__UnityEngineParticleSystemNoiseQuality__SystemVoid(){} // RVA: 0x7FFACACB0840
        public void __set_remapEnabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACB0960
        public void __set_remapMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACB0A80
        public void __set_remapXMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACB0BA0
        public void __set_remapX__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACB0CC0
        public void __set_remapYMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACB0DF0
        public void __set_remapY__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACB0F10
        public void __set_remapZMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACB1040
        public void __set_remapZ__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACB1160
        public void __set_remap__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACB1290
        public void __set_rotationAmount__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACB13C0
        public void __set_scrollSpeedMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACB14F0
        public void __set_scrollSpeed__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACB1610
        public void __set_separateAxes__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACB1740
        public void __set_sizeAmount__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACB1860
        public void __set_strengthMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACB1990
        public void __set_strengthXMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACB1AB0
        public void __set_strengthX__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACB1BD0
        public void __set_strengthYMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACB1D00
        public void __set_strengthY__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACB1E20
        public void __set_strengthZMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACB1F50
        public void __set_strengthZ__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACB2070
        public void __set_strength__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACB21A0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACACB22D0
    }

    public class ExternUnityEngineParticleSystemNoiseModuleArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACACB54B0
        public void .ctor(){} // RVA: 0x7FFACACB54F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACACB58C0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACACB59F0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACACB5B00
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACB5BE0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACB5CC0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACACB5D90
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACACB5EE0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACACB5F80
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACB6080
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACACB61A0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACB62B0
        public void __GetType__SystemType(){} // RVA: 0x7FFACACB63D0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACB64C0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACACB65A0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACACB66C0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACACB6850
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACACB69A0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACACB6AD0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACACB6BF0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACACB6D60
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACACB6EA0
        public void __Get__SystemInt32__UnityEngineParticleSystemNoiseModule(){} // RVA: 0x7FFACACB6FC0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACACB70A0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACACB7110
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACB7230
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACB73B0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACB7510
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACACB7640
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACB7760
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACB78C0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACB7A10
        public void __Set__SystemInt32_UnityEngineParticleSystemNoiseModule__SystemVoid(){} // RVA: 0x7FFACACB7B30
        public void __ToString__SystemString(){} // RVA: 0x7FFACACB7C10
        public void __ctor__SystemInt32__UnityEngineParticleSystemNoiseModuleArray(){} // RVA: 0x7FFACACB7D00
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACACB7EA0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACACB7F40
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACACB7FE0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACACB8080
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACACB8120
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACACB81C0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACACB8260
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACACB8340
    }

    public class ExternUnityEngineParticleSystemParticle : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACACBA260
        public void .ctor(){} // RVA: 0x7FFACACBA2A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACACBA670
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACACBA7A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACACBA8B0
        public void __GetCurrentColor__UnityEngineParticleSystem__UnityEngineColor32(){} // RVA: 0x7FFACACBA9F0
        public void __GetCurrentSize3D__UnityEngineParticleSystem__UnityEngineVector3(){} // RVA: 0x7FFACACBABD0
        public void __GetCurrentSize__UnityEngineParticleSystem__SystemSingle(){} // RVA: 0x7FFACACBADD0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACACBAFD0
        public void __GetMeshIndex__UnityEngineParticleSystem__SystemInt32(){} // RVA: 0x7FFACACBB080
        public void __GetType__SystemType(){} // RVA: 0x7FFACACBB280
        public void __SetMeshIndex__SystemInt32__SystemVoid(){} // RVA: 0x7FFACACBB370
        public void __ToString__SystemString(){} // RVA: 0x7FFACACBB410
        public void __get_angularVelocity3D__UnityEngineVector3(){} // RVA: 0x7FFACACBB4C0
        public void __get_angularVelocity__SystemSingle(){} // RVA: 0x7FFACACBB5A0
        public void __get_animatedVelocity__UnityEngineVector3(){} // RVA: 0x7FFACACBB650
        public void __get_axisOfRotation__UnityEngineVector3(){} // RVA: 0x7FFACACBB710
        public void __get_position__UnityEngineVector3(){} // RVA: 0x7FFACACBB7D0
        public void __get_randomSeed__SystemUInt32(){} // RVA: 0x7FFACACBB890
        public void __get_remainingLifetime__SystemSingle(){} // RVA: 0x7FFACACBB940
        public void __get_rotation3D__UnityEngineVector3(){} // RVA: 0x7FFACACBB9F0
        public void __get_rotation__SystemSingle(){} // RVA: 0x7FFACACBBAC0
        public void __get_startColor__UnityEngineColor32(){} // RVA: 0x7FFACACBBB70
        public void __get_startLifetime__SystemSingle(){} // RVA: 0x7FFACACBBC20
        public void __get_startSize3D__UnityEngineVector3(){} // RVA: 0x7FFACACBBCD0
        public void __get_startSize__SystemSingle(){} // RVA: 0x7FFACACBBDA0
        public void __get_totalVelocity__UnityEngineVector3(){} // RVA: 0x7FFACACBBE50
        public void __get_velocity__UnityEngineVector3(){} // RVA: 0x7FFACACBBF40
        public void __set_angularVelocity3D__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACACBC010
        public void __set_angularVelocity__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACBC230
        public void __set_axisOfRotation__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACACBC420
        public void __set_position__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACACBC5F0
        public void __set_randomSeed__SystemUInt32__SystemVoid(){} // RVA: 0x7FFACACBC7C0
        public void __set_remainingLifetime__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACBC980
        public void __set_rotation3D__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACACBCB60
        public void __set_rotation__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACBCD80
        public void __set_startColor__UnityEngineColor32__SystemVoid(){} // RVA: 0x7FFACACBCF70
        public void __set_startLifetime__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACBD130
        public void __set_startSize3D__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACACBD310
        public void __set_startSize__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACBD4E0
        public void __set_velocity__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACACBD6D0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACACBD8A0
    }

    public class ExternUnityEngineParticleSystemParticleArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACACBF640
        public void .ctor(){} // RVA: 0x7FFACACBF680
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACACBFA50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACACBFB80
        public void __Clone__SystemObject(){} // RVA: 0x7FFACACBFC90
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACBFD70
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACBFE50
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACACBFF20
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACACC0070
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACACC0110
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACC0210
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACACC0330
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACC0440
        public void __GetType__SystemType(){} // RVA: 0x7FFACACC0560
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACC0650
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACACC0730
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACACC0850
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACACC09E0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACACC0B30
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACACC0C60
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACACC0D80
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACACC0EF0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACACC1030
        public void __Get__SystemInt32__UnityEngineParticleSystemParticle(){} // RVA: 0x7FFACACC1150
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACACC12C0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACACC1330
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACC1450
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACC15D0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACC1730
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACACC1860
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACC1980
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACC1AE0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACC1C30
        public void __Set__SystemInt32_UnityEngineParticleSystemParticle__SystemVoid(){} // RVA: 0x7FFACACC1D50
        public void __ToString__SystemString(){} // RVA: 0x7FFACACC1EC0
        public void __ctor__SystemInt32__UnityEngineParticleSystemParticleArray(){} // RVA: 0x7FFACACC1FB0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACACC2150
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACACC21F0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACACC2290
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACACC2330
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACACC23D0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACACC2470
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACACC2510
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACACC25F0
    }

    public class ExternUnityEngineParticleSystemRenderer : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACACC4510
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACACC4550
        public void .ctor(){} // RVA: 0x7FFACACC4600
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACACC49D0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACACC4B00
        public void __BakeMesh__UnityEngineMesh_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACC4C10
        public void __BakeMesh__UnityEngineMesh_UnityEngineCamera_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACC4DA0
        public void __BakeTrailsMesh__UnityEngineMesh_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACC4F40
        public void __BakeTrailsMesh__UnityEngineMesh_UnityEngineCamera_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACC50D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACACC5270
        public void __GetActiveVertexStreams__SystemCollectionsGenericListUnityEngineParticleSystemVertexStream__SystemVoid(){} // RVA: 0x7FFACACC5440
        public void __GetClosestReflectionProbes__SystemCollectionsGenericListUnityEngineRenderingReflectionProbeBlendInfo__SystemVoid(){} // RVA: 0x7FFACACC5560
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACACC5680
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACACC5770
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACACC5A20
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACACC5B80
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACACC5CA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACACC5D90
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACACC6010
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACACC6100
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACACC63B0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACACC6510
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACACC6630
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACACC6720
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACACC69A0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACACC6B10
        public void __GetComponent__T(){} // RVA: 0x7FFACACC6C30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACACC6D10
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACACC6F60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACACC7050
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACACC7380
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACACC7470
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACACC77B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACACC78A0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACACC7BB0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACACC7D20
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACACC7E50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACACC7F40
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACACC8230
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACACC8320
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACACC8660
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACACC8750
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACACC8A60
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACACC8BD0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACACC8D10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACACC8E00
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACACC90F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACACC91E0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACACC94D0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACACC9620
        public void __GetComponents__TArray(){} // RVA: 0x7FFACACC9750
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACACC9840
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACACC9AF0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACACC9C50
        public void __GetMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACACC9DA0
        public void __GetMeshWeightings__SystemSingleArray__SystemInt32(){} // RVA: 0x7FFACACC9EC0
        public void __GetMeshes__UnityEngineMeshArray__SystemInt32(){} // RVA: 0x7FFACACCA020
        public void __GetPropertyBlock__UnityEngineMaterialPropertyBlock_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACCA1C0
        public void __GetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(){} // RVA: 0x7FFACACCA2D0
        public void __GetSharedMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACACCA3F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACACCA510
        public void __HasPropertyBlock__SystemBoolean(){} // RVA: 0x7FFACACCA600
        public void __ResetBounds__SystemVoid(){} // RVA: 0x7FFACACCA720
        public void __ResetLocalBounds__SystemVoid(){} // RVA: 0x7FFACACCA810
        public void __SetActiveVertexStreams__SystemCollectionsGenericListUnityEngineParticleSystemVertexStream__SystemVoid(){} // RVA: 0x7FFACACCA900
        public void __SetMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACACCAA20
        public void __SetMeshWeightings__SystemSingleArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACCABF0
        public void __SetMeshWeightings__SystemSingleArray__SystemVoid(){} // RVA: 0x7FFACACCAD00
        public void __SetMeshes__UnityEngineMeshArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACCADE0
        public void __SetMeshes__UnityEngineMeshArray__SystemVoid(){} // RVA: 0x7FFACACCAF30
        public void __SetPropertyBlock__UnityEngineMaterialPropertyBlock_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACCB060
        public void __SetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(){} // RVA: 0x7FFACACCB170
        public void __SetSharedMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACACCB290
        public void __ToString__SystemString(){} // RVA: 0x7FFACACCB460
        public void __get_activeVertexStreamsCount__SystemInt32(){} // RVA: 0x7FFACACCB5B0
        public void __get_alignment__UnityEngineParticleSystemRenderSpace(){} // RVA: 0x7FFACACCB6D0
        public void __get_allowOcclusionWhenDynamic__SystemBoolean(){} // RVA: 0x7FFACACCB7F0
        public void __get_allowRoll__SystemBoolean(){} // RVA: 0x7FFACACCB910
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACACCBA30
        public void __get_cameraVelocityScale__SystemSingle(){} // RVA: 0x7FFACACCBB80
        public void __get_enableGPUInstancing__SystemBoolean(){} // RVA: 0x7FFACACCBCA0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACACCBDC0
        public void __get_flip__UnityEngineVector3(){} // RVA: 0x7FFACACCBEE0
        public void __get_forceRenderingOff__SystemBoolean(){} // RVA: 0x7FFACACCC020
        public void __get_freeformStretching__SystemBoolean(){} // RVA: 0x7FFACACCC140
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACACCC260
        public void __get_isPartOfStaticBatch__SystemBoolean(){} // RVA: 0x7FFACACCC3A0
        public void __get_isVisible__SystemBoolean(){} // RVA: 0x7FFACACCC4C0
        public void __get_lengthScale__SystemSingle(){} // RVA: 0x7FFACACCC5E0
        public void __get_lightProbeProxyVolumeOverride__UnityEngineGameObject(){} // RVA: 0x7FFACACCC700
        public void __get_lightProbeUsage__UnityEngineRenderingLightProbeUsage(){} // RVA: 0x7FFACACCC840
        public void __get_lightmapIndex__SystemInt32(){} // RVA: 0x7FFACACCC960
        public void __get_lightmapScaleOffset__UnityEngineVector4(){} // RVA: 0x7FFACACCCA80
        public void __get_localBounds__UnityEngineBounds(){} // RVA: 0x7FFACACCCBC0
        public void __get_localToWorldMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACACCCD10
        public void __get_maskInteraction__UnityEngineSpriteMaskInteraction(){} // RVA: 0x7FFACACCCE90
        public void __get_material__UnityEngineMaterial(){} // RVA: 0x7FFACACCCFB0
        public void __get_materials__UnityEngineMaterialArray(){} // RVA: 0x7FFACACCD0F0
        public void __get_maxParticleSize__SystemSingle(){} // RVA: 0x7FFACACCD230
        public void __get_meshCount__SystemInt32(){} // RVA: 0x7FFACACCD350
        public void __get_meshDistribution__UnityEngineParticleSystemMeshDistribution(){} // RVA: 0x7FFACACCD470
        public void __get_mesh__UnityEngineMesh(){} // RVA: 0x7FFACACCD590
        public void __get_minParticleSize__SystemSingle(){} // RVA: 0x7FFACACCD6D0
        public void __get_motionVectorGenerationMode__UnityEngineMotionVectorGenerationMode(){} // RVA: 0x7FFACACCD7F0
        public void __get_name__SystemString(){} // RVA: 0x7FFACACCD910
        public void __get_normalDirection__SystemSingle(){} // RVA: 0x7FFACACCDA60
        public void __get_pivot__UnityEngineVector3(){} // RVA: 0x7FFACACCDB80
        public void __get_probeAnchor__UnityEngineTransform(){} // RVA: 0x7FFACACCDCC0
        public void __get_realtimeLightmapIndex__SystemInt32(){} // RVA: 0x7FFACACCDE00
        public void __get_realtimeLightmapScaleOffset__UnityEngineVector4(){} // RVA: 0x7FFACACCDF30
        public void __get_receiveShadows__SystemBoolean(){} // RVA: 0x7FFACACCE070
        public void __get_reflectionProbeUsage__UnityEngineRenderingReflectionProbeUsage(){} // RVA: 0x7FFACACCE190
        public void __get_renderMode__UnityEngineParticleSystemRenderMode(){} // RVA: 0x7FFACACCE2B0
        public void __get_rendererPriority__SystemInt32(){} // RVA: 0x7FFACACCE3D0
        public void __get_renderingLayerMask__SystemUInt32(){} // RVA: 0x7FFACACCE4F0
        public void __get_rotateWithStretchDirection__SystemBoolean(){} // RVA: 0x7FFACACCE610
        public void __get_shadowBias__SystemSingle(){} // RVA: 0x7FFACACCE730
        public void __get_shadowCastingMode__UnityEngineRenderingShadowCastingMode(){} // RVA: 0x7FFACACCE850
        public void __get_sharedMaterial__UnityEngineMaterial(){} // RVA: 0x7FFACACCE970
        public void __get_sharedMaterials__UnityEngineMaterialArray(){} // RVA: 0x7FFACACCEAB0
        public void __get_sortMode__UnityEngineParticleSystemSortMode(){} // RVA: 0x7FFACACCEBF0
        public void __get_sortingFudge__SystemSingle(){} // RVA: 0x7FFACACCED10
        public void __get_sortingLayerID__SystemInt32(){} // RVA: 0x7FFACACCEE30
        public void __get_sortingLayerName__SystemString(){} // RVA: 0x7FFACACCEF50
        public void __get_sortingOrder__SystemInt32(){} // RVA: 0x7FFACACCF070
        public void __get_staticShadowCaster__SystemBoolean(){} // RVA: 0x7FFACACCF190
        public void __get_trailMaterial__UnityEngineMaterial(){} // RVA: 0x7FFACACCF2B0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACACCF3F0
        public void __get_velocityScale__SystemSingle(){} // RVA: 0x7FFACACCF530
        public void __get_worldToLocalMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACACCF650
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACACCF7D0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACACCFAD0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACACCFCC0
        public void __set_alignment__UnityEngineParticleSystemRenderSpace__SystemVoid(){} // RVA: 0x7FFACACCFFC0
        public void __set_allowOcclusionWhenDynamic__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACD00E0
        public void __set_allowRoll__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACD0210
        public void __set_bounds__UnityEngineBounds__SystemVoid(){} // RVA: 0x7FFACACD0340
        public void __set_cameraVelocityScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACD0480
        public void __set_enableGPUInstancing__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACD05B0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACD06E0
        public void __set_flip__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACACD0810
        public void __set_forceRenderingOff__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACD0950
        public void __set_freeformStretching__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACD0A80
        public void __set_lengthScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACD0BB0
        public void __set_lightProbeProxyVolumeOverride__UnityEngineGameObject__SystemVoid(){} // RVA: 0x7FFACACD0CE0
        public void __set_lightProbeUsage__UnityEngineRenderingLightProbeUsage__SystemVoid(){} // RVA: 0x7FFACACD0E30
        public void __set_lightmapIndex__SystemInt32__SystemVoid(){} // RVA: 0x7FFACACD0F50
        public void __set_lightmapScaleOffset__UnityEngineVector4__SystemVoid(){} // RVA: 0x7FFACACD1080
        public void __set_localBounds__UnityEngineBounds__SystemVoid(){} // RVA: 0x7FFACACD11B0
        public void __set_maskInteraction__UnityEngineSpriteMaskInteraction__SystemVoid(){} // RVA: 0x7FFACACD12F0
        public void __set_material__UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACACD1410
        public void __set_materials__UnityEngineMaterialArray__SystemVoid(){} // RVA: 0x7FFACACD1560
        public void __set_maxParticleSize__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACD1690
        public void __set_meshDistribution__UnityEngineParticleSystemMeshDistribution__SystemVoid(){} // RVA: 0x7FFACACD17C0
        public void __set_mesh__UnityEngineMesh__SystemVoid(){} // RVA: 0x7FFACACD18E0
        public void __set_minParticleSize__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACD1A30
        public void __set_motionVectorGenerationMode__UnityEngineMotionVectorGenerationMode__SystemVoid(){} // RVA: 0x7FFACACD1B60
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACACD1C80
        public void __set_normalDirection__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACD1DD0
        public void __set_pivot__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACACD1F00
        public void __set_probeAnchor__UnityEngineTransform__SystemVoid(){} // RVA: 0x7FFACACD2040
        public void __set_realtimeLightmapIndex__SystemInt32__SystemVoid(){} // RVA: 0x7FFACACD2190
        public void __set_realtimeLightmapScaleOffset__UnityEngineVector4__SystemVoid(){} // RVA: 0x7FFACACD22C0
        public void __set_receiveShadows__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACD23F0
        public void __set_reflectionProbeUsage__UnityEngineRenderingReflectionProbeUsage__SystemVoid(){} // RVA: 0x7FFACACD2520
        public void __set_renderMode__UnityEngineParticleSystemRenderMode__SystemVoid(){} // RVA: 0x7FFACACD2640
        public void __set_rendererPriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACACD2760
        public void __set_renderingLayerMask__SystemUInt32__SystemVoid(){} // RVA: 0x7FFACACD2880
        public void __set_rotateWithStretchDirection__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACD29A0
        public void __set_shadowBias__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACD2AD0
        public void __set_shadowCastingMode__UnityEngineRenderingShadowCastingMode__SystemVoid(){} // RVA: 0x7FFACACD2C00
        public void __set_sharedMaterial__UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACACD2D20
        public void __set_sharedMaterials__UnityEngineMaterialArray__SystemVoid(){} // RVA: 0x7FFACACD2E70
        public void __set_sortMode__UnityEngineParticleSystemSortMode__SystemVoid(){} // RVA: 0x7FFACACD2FA0
        public void __set_sortingFudge__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACD30C0
        public void __set_sortingLayerID__SystemInt32__SystemVoid(){} // RVA: 0x7FFACACD31F0
        public void __set_sortingLayerName__SystemString__SystemVoid(){} // RVA: 0x7FFACACD3310
        public void __set_sortingOrder__SystemInt32__SystemVoid(){} // RVA: 0x7FFACACD3430
        public void __set_staticShadowCaster__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACD3550
        public void __set_trailMaterial__UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACACD3680
        public void __set_velocityScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACD37D0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACACD3900
    }

    public class ExternUnityEngineParticleSystemRendererArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACACDB460
        public void .ctor(){} // RVA: 0x7FFACACDB4A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACACDB870
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACACDB9A0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACACDBAB0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACDBB90
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACDBC70
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACACDBD40
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACACDBE90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACACDBF30
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACDC030
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACACDC150
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACDC260
        public void __GetType__SystemType(){} // RVA: 0x7FFACACDC380
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACDC470
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACACDC550
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACACDC670
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACACDC800
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACACDC950
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACACDCA80
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACACDCBA0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACACDCD10
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACACDCE50
        public void __Get__SystemInt32__UnityEngineParticleSystemRenderer(){} // RVA: 0x7FFACACDCF70
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACACDD0B0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACACDD120
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACDD240
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACDD3C0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACDD520
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACACDD650
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACDD770
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACDD8D0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACDDA20
        public void __Set__SystemInt32_UnityEngineParticleSystemRenderer__SystemVoid(){} // RVA: 0x7FFACACDDB40
        public void __ToString__SystemString(){} // RVA: 0x7FFACACDDCD0
        public void __ctor__SystemInt32__UnityEngineParticleSystemRendererArray(){} // RVA: 0x7FFACACDDDC0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACACDDEB0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACACDDF50
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACACDDFF0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACACDE090
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACACDE130
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACACDE1D0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACACDE270
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACACDE350
    }

    public class ExternUnityEngineParticleSystemRotationBySpeedModule : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACACE0270
        public void .ctor(){} // RVA: 0x7FFACACE02B0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACACE0680
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACACE07B0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACACE08C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACACE0A00
        public void __GetType__SystemType(){} // RVA: 0x7FFACACE0AB0
        public void __ToString__SystemString(){} // RVA: 0x7FFACACE0BA0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACACE0C50
        public void __get_range__UnityEngineVector2(){} // RVA: 0x7FFACACE0D30
        public void __get_separateAxes__SystemBoolean(){} // RVA: 0x7FFACACE0E20
        public void __get_xMultiplier__SystemSingle(){} // RVA: 0x7FFACACE0F00
        public void __get_x__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACE0FE0
        public void __get_yMultiplier__SystemSingle(){} // RVA: 0x7FFACACE10F0
        public void __get_y__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACE11D0
        public void __get_zMultiplier__SystemSingle(){} // RVA: 0x7FFACACE12E0
        public void __get_z__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACE13C0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACE14D0
        public void __set_range__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACACE15F0
        public void __set_separateAxes__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACE1700
        public void __set_xMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACE1820
        public void __set_x__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACE1940
        public void __set_yMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACE1A70
        public void __set_y__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACE1B90
        public void __set_zMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACE1CC0
        public void __set_z__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACE1DE0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACACE1F10
    }

    public class ExternUnityEngineParticleSystemRotationBySpeedModuleArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACACE3160
        public void .ctor(){} // RVA: 0x7FFACACE31A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACACE3570
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACACE36A0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACACE37B0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACE3890
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACE3970
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACACE3A40
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACACE3B90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACACE3C30
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACE3D30
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACACE3E50
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACE3F60
        public void __GetType__SystemType(){} // RVA: 0x7FFACACE4080
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACE4170
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACACE4250
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACACE4370
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACACE4500
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACACE4650
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACACE4780
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACACE48A0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACACE4A10
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACACE4B50
        public void __Get__SystemInt32__UnityEngineParticleSystemRotationBySpeedModule(){} // RVA: 0x7FFACACE4C70
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACACE4D50
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACACE4DC0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACE4EE0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACE5060
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACE51C0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACACE52F0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACE5410
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACE5570
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACE56C0
        public void __Set__SystemInt32_UnityEngineParticleSystemRotationBySpeedModule__SystemVoid(){} // RVA: 0x7FFACACE57E0
        public void __ToString__SystemString(){} // RVA: 0x7FFACACE58C0
        public void __ctor__SystemInt32__UnityEngineParticleSystemRotationBySpeedModuleArray(){} // RVA: 0x7FFACACE59B0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACACE5B50
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACACE5BF0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACACE5C90
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACACE5D30
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACACE5DD0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACACE5E70
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACACE5F10
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACACE5FF0
    }

    public class ExternUnityEngineParticleSystemRotationOverLifetimeModule : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACACE7F10
        public void .ctor(){} // RVA: 0x7FFACACE7F50
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACACE8320
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACACE8450
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACACE8560
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACACE86A0
        public void __GetType__SystemType(){} // RVA: 0x7FFACACE8750
        public void __ToString__SystemString(){} // RVA: 0x7FFACACE8840
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACACE88F0
        public void __get_separateAxes__SystemBoolean(){} // RVA: 0x7FFACACE89D0
        public void __get_xMultiplier__SystemSingle(){} // RVA: 0x7FFACACE8AB0
        public void __get_x__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACE8B90
        public void __get_yMultiplier__SystemSingle(){} // RVA: 0x7FFACACE8CA0
        public void __get_y__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACE8D80
        public void __get_zMultiplier__SystemSingle(){} // RVA: 0x7FFACACE8E90
        public void __get_z__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACE8F70
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACE9080
        public void __set_separateAxes__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACE91A0
        public void __set_xMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACE92C0
        public void __set_x__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACE93E0
        public void __set_yMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACE9510
        public void __set_y__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACE9630
        public void __set_zMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACE9760
        public void __set_z__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACE9880
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACACE99B0
    }

    public class ExternUnityEngineParticleSystemRotationOverLifetimeModuleArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACACEAA80
        public void .ctor(){} // RVA: 0x7FFACACEAAC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACACEAE90
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACACEAFC0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACACEB0D0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACEB1B0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACEB290
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACACEB360
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACACEB4B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACACEB550
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACEB650
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACACEB770
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACEB880
        public void __GetType__SystemType(){} // RVA: 0x7FFACACEB9A0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACEBA90
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACACEBB70
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACACEBC90
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACACEBE20
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACACEBF70
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACACEC0A0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACACEC1C0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACACEC330
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACACEC470
        public void __Get__SystemInt32__UnityEngineParticleSystemRotationOverLifetimeModule(){} // RVA: 0x7FFACACEC590
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACACEC670
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACACEC6E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACEC800
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACEC980
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACECAE0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACACECC10
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACECD30
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACECE90
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACECFE0
        public void __Set__SystemInt32_UnityEngineParticleSystemRotationOverLifetimeModule__SystemVoid(){} // RVA: 0x7FFACACED100
        public void __ToString__SystemString(){} // RVA: 0x7FFACACED1E0
        public void __ctor__SystemInt32__UnityEngineParticleSystemRotationOverLifetimeModuleArray(){} // RVA: 0x7FFACACED2D0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACACED470
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACACED510
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACACED5B0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACACED650
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACACED6F0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACACED790
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACACED830
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACACED910
    }

    public class ExternUnityEngineParticleSystemShapeModule : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACACEF830
        public void .ctor(){} // RVA: 0x7FFACACEF870
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACACEFC40
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACACEFD70
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACACEFE80
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACACEFFC0
        public void __GetType__SystemType(){} // RVA: 0x7FFACACF0070
        public void __ToString__SystemString(){} // RVA: 0x7FFACACF0160
        public void __get_alignToDirection__SystemBoolean(){} // RVA: 0x7FFACACF0210
        public void __get_angle__SystemSingle(){} // RVA: 0x7FFACACF02F0
        public void __get_arcMode__UnityEngineParticleSystemShapeMultiModeValue(){} // RVA: 0x7FFACACF03D0
        public void __get_arcSpeedMultiplier__SystemSingle(){} // RVA: 0x7FFACACF04B0
        public void __get_arcSpeed__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACF0590
        public void __get_arcSpread__SystemSingle(){} // RVA: 0x7FFACACF06A0
        public void __get_arc__SystemSingle(){} // RVA: 0x7FFACACF0780
        public void __get_boxThickness__UnityEngineVector3(){} // RVA: 0x7FFACACF0860
        public void __get_donutRadius__SystemSingle(){} // RVA: 0x7FFACACF0960
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACACF0A40
        public void __get_length__SystemSingle(){} // RVA: 0x7FFACACF0B20
        public void __get_meshMaterialIndex__SystemInt32(){} // RVA: 0x7FFACACF0C00
        public void __get_meshRenderer__UnityEngineMeshRenderer(){} // RVA: 0x7FFACACF0CE0
        public void __get_meshShapeType__UnityEngineParticleSystemMeshShapeType(){} // RVA: 0x7FFACACF0E00
        public void __get_meshSpawnMode__UnityEngineParticleSystemShapeMultiModeValue(){} // RVA: 0x7FFACACF0EE0
        public void __get_meshSpawnSpeedMultiplier__SystemSingle(){} // RVA: 0x7FFACACF0FC0
        public void __get_meshSpawnSpeed__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACF10A0
        public void __get_meshSpawnSpread__SystemSingle(){} // RVA: 0x7FFACACF11B0
        public void __get_mesh__UnityEngineMesh(){} // RVA: 0x7FFACACF1290
        public void __get_normalOffset__SystemSingle(){} // RVA: 0x7FFACACF13B0
        public void __get_position__UnityEngineVector3(){} // RVA: 0x7FFACACF1490
        public void __get_radiusMode__UnityEngineParticleSystemShapeMultiModeValue(){} // RVA: 0x7FFACACF1590
        public void __get_radiusSpeedMultiplier__SystemSingle(){} // RVA: 0x7FFACACF1670
        public void __get_radiusSpeed__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACACF1750
        public void __get_radiusSpread__SystemSingle(){} // RVA: 0x7FFACACF1860
        public void __get_radiusThickness__SystemSingle(){} // RVA: 0x7FFACACF1940
        public void __get_radius__SystemSingle(){} // RVA: 0x7FFACACF1A20
        public void __get_randomDirectionAmount__SystemSingle(){} // RVA: 0x7FFACACF1B00
        public void __get_randomPositionAmount__SystemSingle(){} // RVA: 0x7FFACACF1BE0
        public void __get_rotation__UnityEngineVector3(){} // RVA: 0x7FFACACF1CC0
        public void __get_scale__UnityEngineVector3(){} // RVA: 0x7FFACACF1DC0
        public void __get_shapeType__UnityEngineParticleSystemShapeType(){} // RVA: 0x7FFACACF1EC0
        public void __get_skinnedMeshRenderer__UnityEngineSkinnedMeshRenderer(){} // RVA: 0x7FFACACF1FA0
        public void __get_sphericalDirectionAmount__SystemSingle(){} // RVA: 0x7FFACACF20C0
        public void __get_spriteRenderer__UnityEngineSpriteRenderer(){} // RVA: 0x7FFACACF21A0
        public void __get_sprite__UnityEngineSprite(){} // RVA: 0x7FFACACF22C0
        public void __get_textureAlphaAffectsParticles__SystemBoolean(){} // RVA: 0x7FFACACF23E0
        public void __get_textureBilinearFiltering__SystemBoolean(){} // RVA: 0x7FFACACF24C0
        public void __get_textureClipChannel__UnityEngineParticleSystemShapeTextureChannel(){} // RVA: 0x7FFACACF25A0
        public void __get_textureClipThreshold__SystemSingle(){} // RVA: 0x7FFACACF2680
        public void __get_textureColorAffectsParticles__SystemBoolean(){} // RVA: 0x7FFACACF2760
        public void __get_textureUVChannel__SystemInt32(){} // RVA: 0x7FFACACF2840
        public void __get_texture__UnityEngineTexture2D(){} // RVA: 0x7FFACACF2920
        public void __get_useMeshColors__SystemBoolean(){} // RVA: 0x7FFACACF2A40
        public void __get_useMeshMaterialIndex__SystemBoolean(){} // RVA: 0x7FFACACF2B20
        public void __set_alignToDirection__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACF2C00
        public void __set_angle__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF2D20
        public void __set_arcMode__UnityEngineParticleSystemShapeMultiModeValue__SystemVoid(){} // RVA: 0x7FFACACF2E40
        public void __set_arcSpeedMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF2F60
        public void __set_arcSpeed__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACF3080
        public void __set_arcSpread__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF31B0
        public void __set_arc__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF32D0
        public void __set_boxThickness__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACACF33F0
        public void __set_donutRadius__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF3520
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACF3640
        public void __set_length__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF3760
        public void __set_meshMaterialIndex__SystemInt32__SystemVoid(){} // RVA: 0x7FFACACF3880
        public void __set_meshRenderer__UnityEngineMeshRenderer__SystemVoid(){} // RVA: 0x7FFACACF39A0
        public void __set_meshShapeType__UnityEngineParticleSystemMeshShapeType__SystemVoid(){} // RVA: 0x7FFACACF3AF0
        public void __set_meshSpawnMode__UnityEngineParticleSystemShapeMultiModeValue__SystemVoid(){} // RVA: 0x7FFACACF3C10
        public void __set_meshSpawnSpeedMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF3D30
        public void __set_meshSpawnSpeed__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACF3E50
        public void __set_meshSpawnSpread__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF3F80
        public void __set_mesh__UnityEngineMesh__SystemVoid(){} // RVA: 0x7FFACACF40A0
        public void __set_normalOffset__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF41F0
        public void __set_position__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACACF4310
        public void __set_radiusMode__UnityEngineParticleSystemShapeMultiModeValue__SystemVoid(){} // RVA: 0x7FFACACF4440
        public void __set_radiusSpeedMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF4560
        public void __set_radiusSpeed__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACACF4680
        public void __set_radiusSpread__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF47B0
        public void __set_radiusThickness__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF48D0
        public void __set_radius__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF49F0
        public void __set_randomDirectionAmount__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF4B10
        public void __set_randomPositionAmount__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF4C30
        public void __set_rotation__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACACF4D50
        public void __set_scale__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACACF4E80
        public void __set_shapeType__UnityEngineParticleSystemShapeType__SystemVoid(){} // RVA: 0x7FFACACF4FB0
        public void __set_skinnedMeshRenderer__UnityEngineSkinnedMeshRenderer__SystemVoid(){} // RVA: 0x7FFACACF50D0
        public void __set_sphericalDirectionAmount__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF5220
        public void __set_spriteRenderer__UnityEngineSpriteRenderer__SystemVoid(){} // RVA: 0x7FFACACF5340
        public void __set_sprite__UnityEngineSprite__SystemVoid(){} // RVA: 0x7FFACACF5490
        public void __set_textureAlphaAffectsParticles__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACF55E0
        public void __set_textureBilinearFiltering__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACF5700
        public void __set_textureClipChannel__UnityEngineParticleSystemShapeTextureChannel__SystemVoid(){} // RVA: 0x7FFACACF5820
        public void __set_textureClipThreshold__SystemSingle__SystemVoid(){} // RVA: 0x7FFACACF5940
        public void __set_textureColorAffectsParticles__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACF5A60
        public void __set_textureUVChannel__SystemInt32__SystemVoid(){} // RVA: 0x7FFACACF5B80
        public void __set_texture__UnityEngineTexture2D__SystemVoid(){} // RVA: 0x7FFACACF5CA0
        public void __set_useMeshColors__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACF5DF0
        public void __set_useMeshMaterialIndex__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACACF5F10
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACACF6030
    }

    public class ExternUnityEngineParticleSystemShapeModuleArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACACFA890
        public void .ctor(){} // RVA: 0x7FFACACFA8D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACACFACA0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACACFADD0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACACFAEE0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACFAFC0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACFB0A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACACFB170
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACACFB2C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACACFB360
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACFB460
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACACFB580
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACFB690
        public void __GetType__SystemType(){} // RVA: 0x7FFACACFB7B0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACACFB8A0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACACFB980
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACACFBAA0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACACFBC30
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACACFBD80
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACACFBEB0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACACFBFD0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACACFC140
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACACFC280
        public void __Get__SystemInt32__UnityEngineParticleSystemShapeModule(){} // RVA: 0x7FFACACFC3A0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACACFC480
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACACFC4F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACFC610
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACFC790
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACACFC8F0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACACFCA20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACFCB40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACFCCA0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACACFCDF0
        public void __Set__SystemInt32_UnityEngineParticleSystemShapeModule__SystemVoid(){} // RVA: 0x7FFACACFCF10
        public void __ToString__SystemString(){} // RVA: 0x7FFACACFCFF0
        public void __ctor__SystemInt32__UnityEngineParticleSystemShapeModuleArray(){} // RVA: 0x7FFACACFD0E0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACACFD280
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACACFD320
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACACFD3C0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACACFD460
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACACFD500
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACACFD5A0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACACFD640
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACACFD720
    }

    public class ExternUnityEngineParticleSystemSizeBySpeedModule : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACACFF640
        public void .ctor(){} // RVA: 0x7FFACACFF680
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACACFFA50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACACFFB80
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACACFFC90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACACFFDD0
        public void __GetType__SystemType(){} // RVA: 0x7FFACACFFE80
        public void __ToString__SystemString(){} // RVA: 0x7FFACACFFF70
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAD00020
        public void __get_range__UnityEngineVector2(){} // RVA: 0x7FFACAD00100
        public void __get_separateAxes__SystemBoolean(){} // RVA: 0x7FFACAD001F0
        public void __get_sizeMultiplier__SystemSingle(){} // RVA: 0x7FFACAD002D0
        public void __get_size__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD003B0
        public void __get_xMultiplier__SystemSingle(){} // RVA: 0x7FFACAD004C0
        public void __get_x__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD005A0
        public void __get_yMultiplier__SystemSingle(){} // RVA: 0x7FFACAD006B0
        public void __get_y__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD00790
        public void __get_zMultiplier__SystemSingle(){} // RVA: 0x7FFACAD008A0
        public void __get_z__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD00980
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD00A90
        public void __set_range__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAD00BB0
        public void __set_separateAxes__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD00CC0
        public void __set_sizeMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD00DE0
        public void __set_size__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD00F00
        public void __set_xMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD01030
        public void __set_x__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD01150
        public void __set_yMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD01280
        public void __set_y__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD013A0
        public void __set_zMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD014D0
        public void __set_z__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD015F0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD01720
    }

    public class ExternUnityEngineParticleSystemSizeBySpeedModuleArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD02C80
        public void .ctor(){} // RVA: 0x7FFACAD02CC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD03090
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD031C0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAD032D0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD033B0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD03490
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD03560
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAD036B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD03750
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD03850
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAD03970
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD03A80
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD03BA0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD03C90
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAD03D70
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD03E90
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD04020
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAD04170
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAD042A0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD043C0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD04530
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAD04670
        public void __Get__SystemInt32__UnityEngineParticleSystemSizeBySpeedModule(){} // RVA: 0x7FFACAD04790
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAD04870
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAD048E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD04A00
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD04B80
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD04CE0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAD04E10
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD04F30
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD05090
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD051E0
        public void __Set__SystemInt32_UnityEngineParticleSystemSizeBySpeedModule__SystemVoid(){} // RVA: 0x7FFACAD05300
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD053E0
        public void __ctor__SystemInt32__UnityEngineParticleSystemSizeBySpeedModuleArray(){} // RVA: 0x7FFACAD054D0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAD05670
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAD05710
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAD057B0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAD05850
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAD058F0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAD05990
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAD05A30
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD05B10
    }

    public class ExternUnityEngineParticleSystemSizeOverLifetimeModule : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD07A30
        public void .ctor(){} // RVA: 0x7FFACAD07A70
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD07E40
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD07F70
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD08080
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD081C0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD08270
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD08360
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAD08410
        public void __get_separateAxes__SystemBoolean(){} // RVA: 0x7FFACAD084F0
        public void __get_sizeMultiplier__SystemSingle(){} // RVA: 0x7FFACAD085D0
        public void __get_size__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD086B0
        public void __get_xMultiplier__SystemSingle(){} // RVA: 0x7FFACAD087C0
        public void __get_x__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD088A0
        public void __get_yMultiplier__SystemSingle(){} // RVA: 0x7FFACAD089B0
        public void __get_y__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD08A90
        public void __get_zMultiplier__SystemSingle(){} // RVA: 0x7FFACAD08BA0
        public void __get_z__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD08C80
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD08D90
        public void __set_separateAxes__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD08EB0
        public void __set_sizeMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD08FD0
        public void __set_size__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD090F0
        public void __set_xMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD09220
        public void __set_x__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD09340
        public void __set_yMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD09470
        public void __set_y__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD09590
        public void __set_zMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD096C0
        public void __set_z__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD097E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD09910
    }

    public class ExternUnityEngineParticleSystemSizeOverLifetimeModuleArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD0ACF0
        public void .ctor(){} // RVA: 0x7FFACAD0AD30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD0B100
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD0B230
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAD0B340
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD0B420
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD0B500
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD0B5D0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAD0B720
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD0B7C0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD0B8C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAD0B9E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD0BAF0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD0BC10
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD0BD00
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAD0BDE0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD0BF00
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD0C090
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAD0C1E0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAD0C310
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD0C430
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD0C5A0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAD0C6E0
        public void __Get__SystemInt32__UnityEngineParticleSystemSizeOverLifetimeModule(){} // RVA: 0x7FFACAD0C800
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAD0C8E0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAD0C950
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD0CA70
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD0CBF0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD0CD50
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAD0CE80
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD0CFA0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD0D100
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD0D250
        public void __Set__SystemInt32_UnityEngineParticleSystemSizeOverLifetimeModule__SystemVoid(){} // RVA: 0x7FFACAD0D370
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD0D450
        public void __ctor__SystemInt32__UnityEngineParticleSystemSizeOverLifetimeModuleArray(){} // RVA: 0x7FFACAD0D540
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAD0D6E0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAD0D780
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAD0D820
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAD0D8C0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAD0D960
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAD0DA00
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAD0DAA0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD0DB80
    }

    public class ExternUnityEngineParticleSystemSubEmittersModule : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD0FAA0
        public void .ctor(){} // RVA: 0x7FFACAD0FAE0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD0FEB0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD0FFE0
        public void __AddSubEmitter__UnityEngineParticleSystem_UnityEngineParticleSystemSubEmitterType_UnityEngineParticleSystemSubEmitterProperties_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD100F0
        public void __AddSubEmitter__UnityEngineParticleSystem_UnityEngineParticleSystemSubEmitterType_UnityEngineParticleSystemSubEmitterProperties__SystemVoid(){} // RVA: 0x7FFACAD102C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD10460
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD105A0
        public void __GetSubEmitterEmitProbability__SystemInt32__SystemSingle(){} // RVA: 0x7FFACAD10650
        public void __GetSubEmitterProperties__SystemInt32__UnityEngineParticleSystemSubEmitterProperties(){} // RVA: 0x7FFACAD10770
        public void __GetSubEmitterSystem__SystemInt32__UnityEngineParticleSystem(){} // RVA: 0x7FFACAD10890
        public void __GetSubEmitterType__SystemInt32__UnityEngineParticleSystemSubEmitterType(){} // RVA: 0x7FFACAD109E0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD10B00
        public void __RemoveSubEmitter__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD10BF0
        public void __RemoveSubEmitter__UnityEngineParticleSystem__SystemVoid(){} // RVA: 0x7FFACAD10CD0
        public void __SetSubEmitterEmitProbability__SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD10DF0
        public void __SetSubEmitterProperties__SystemInt32_UnityEngineParticleSystemSubEmitterProperties__SystemVoid(){} // RVA: 0x7FFACAD10F20
        public void __SetSubEmitterSystem__SystemInt32_UnityEngineParticleSystem__SystemVoid(){} // RVA: 0x7FFACAD11040
        public void __SetSubEmitterType__SystemInt32_UnityEngineParticleSystemSubEmitterType__SystemVoid(){} // RVA: 0x7FFACAD11190
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD112B0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAD11360
        public void __get_subEmittersCount__SystemInt32(){} // RVA: 0x7FFACAD11440
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD11520
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD11640
    }

    public class ExternUnityEngineParticleSystemSubEmittersModuleArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD12660
        public void .ctor(){} // RVA: 0x7FFACAD126A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD12A70
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD12BA0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAD12CB0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD12D90
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD12E70
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD12F40
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAD13090
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD13130
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD13230
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAD13350
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD13460
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD13580
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD13670
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAD13750
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD13870
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD13A00
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAD13B50
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAD13C80
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD13DA0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD13F10
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAD14050
        public void __Get__SystemInt32__UnityEngineParticleSystemSubEmittersModule(){} // RVA: 0x7FFACAD14170
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAD14250
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAD142C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD143E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD14560
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD146C0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAD147F0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD14910
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD14A70
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD14BC0
        public void __Set__SystemInt32_UnityEngineParticleSystemSubEmittersModule__SystemVoid(){} // RVA: 0x7FFACAD14CE0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD14DC0
        public void __ctor__SystemInt32__UnityEngineParticleSystemSubEmittersModuleArray(){} // RVA: 0x7FFACAD14EB0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAD15050
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAD150F0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAD15190
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAD15230
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAD152D0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAD15370
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAD15410
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD154F0
    }

    public class ExternUnityEngineParticleSystemTextureSheetAnimationModule : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD17410
        public void .ctor(){} // RVA: 0x7FFACAD17450
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD17820
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD17950
        public void __AddSprite__UnityEngineSprite__SystemVoid(){} // RVA: 0x7FFACAD17A60
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD17B80
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD17CC0
        public void __GetSprite__SystemInt32__UnityEngineSprite(){} // RVA: 0x7FFACAD17D70
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD17EC0
        public void __RemoveSprite__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD17FB0
        public void __SetSprite__SystemInt32_UnityEngineSprite__SystemVoid(){} // RVA: 0x7FFACAD18090
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD181E0
        public void __get_animation__UnityEngineParticleSystemAnimationType(){} // RVA: 0x7FFACAD18290
        public void __get_cycleCount__SystemInt32(){} // RVA: 0x7FFACAD18370
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAD18450
        public void __get_fps__SystemSingle(){} // RVA: 0x7FFACAD18530
        public void __get_frameOverTimeMultiplier__SystemSingle(){} // RVA: 0x7FFACAD18610
        public void __get_frameOverTime__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD186F0
        public void __get_mode__UnityEngineParticleSystemAnimationMode(){} // RVA: 0x7FFACAD18800
        public void __get_numTilesX__SystemInt32(){} // RVA: 0x7FFACAD188E0
        public void __get_numTilesY__SystemInt32(){} // RVA: 0x7FFACAD189C0
        public void __get_rowIndex__SystemInt32(){} // RVA: 0x7FFACAD18AA0
        public void __get_rowMode__UnityEngineParticleSystemAnimationRowMode(){} // RVA: 0x7FFACAD18B80
        public void __get_speedRange__UnityEngineVector2(){} // RVA: 0x7FFACAD18C60
        public void __get_spriteCount__SystemInt32(){} // RVA: 0x7FFACAD18D50
        public void __get_startFrameMultiplier__SystemSingle(){} // RVA: 0x7FFACAD18E30
        public void __get_startFrame__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD18F10
        public void __get_timeMode__UnityEngineParticleSystemAnimationTimeMode(){} // RVA: 0x7FFACAD19020
        public void __get_uvChannelMask__UnityEngineRenderingUVChannelFlags(){} // RVA: 0x7FFACAD19100
        public void __set_animation__UnityEngineParticleSystemAnimationType__SystemVoid(){} // RVA: 0x7FFACAD191E0
        public void __set_cycleCount__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD19300
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD19420
        public void __set_fps__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD19540
        public void __set_frameOverTimeMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD19660
        public void __set_frameOverTime__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD19780
        public void __set_mode__UnityEngineParticleSystemAnimationMode__SystemVoid(){} // RVA: 0x7FFACAD198B0
        public void __set_numTilesX__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD199D0
        public void __set_numTilesY__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD19AF0
        public void __set_rowIndex__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD19C10
        public void __set_rowMode__UnityEngineParticleSystemAnimationRowMode__SystemVoid(){} // RVA: 0x7FFACAD19D30
        public void __set_speedRange__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAD19E50
        public void __set_startFrameMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD19F60
        public void __set_startFrame__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD1A080
        public void __set_timeMode__UnityEngineParticleSystemAnimationTimeMode__SystemVoid(){} // RVA: 0x7FFACAD1A1B0
        public void __set_uvChannelMask__UnityEngineRenderingUVChannelFlags__SystemVoid(){} // RVA: 0x7FFACAD1A2D0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD1A3F0
    }

    public class ExternUnityEngineParticleSystemTextureSheetAnimationModuleArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD1C490
        public void .ctor(){} // RVA: 0x7FFACAD1C4D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD1C8A0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD1C9D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAD1CAE0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD1CBC0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD1CCA0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD1CD70
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAD1CEC0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD1CF60
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD1D060
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAD1D180
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD1D290
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD1D3B0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD1D4A0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAD1D580
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD1D6A0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD1D830
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAD1D980
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAD1DAB0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD1DBD0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD1DD40
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAD1DE80
        public void __Get__SystemInt32__UnityEngineParticleSystemTextureSheetAnimationModule(){} // RVA: 0x7FFACAD1DFA0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAD1E080
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAD1E0F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD1E210
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD1E390
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD1E4F0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAD1E620
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD1E740
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD1E8A0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD1E9F0
        public void __Set__SystemInt32_UnityEngineParticleSystemTextureSheetAnimationModule__SystemVoid(){} // RVA: 0x7FFACAD1EB10
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD1EBF0
        public void __ctor__SystemInt32__UnityEngineParticleSystemTextureSheetAnimationModuleArray(){} // RVA: 0x7FFACAD1ECE0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAD1EE80
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAD1EF20
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAD1EFC0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAD1F060
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAD1F100
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAD1F1A0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAD1F240
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD1F320
    }

    public class ExternUnityEngineParticleSystemTrailModule : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD21240
        public void .ctor(){} // RVA: 0x7FFACAD21280
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD21650
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD21780
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD21890
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD219D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD21A80
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD21B70
        public void __get_attachRibbonsToTransform__SystemBoolean(){} // RVA: 0x7FFACAD21C20
        public void __get_colorOverLifetime__UnityEngineParticleSystemMinMaxGradient(){} // RVA: 0x7FFACAD21D00
        public void __get_colorOverTrail__UnityEngineParticleSystemMinMaxGradient(){} // RVA: 0x7FFACAD21E40
        public void __get_dieWithParticles__SystemBoolean(){} // RVA: 0x7FFACAD21F80
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAD22060
        public void __get_generateLightingData__SystemBoolean(){} // RVA: 0x7FFACAD22140
        public void __get_inheritParticleColor__SystemBoolean(){} // RVA: 0x7FFACAD22220
        public void __get_lifetimeMultiplier__SystemSingle(){} // RVA: 0x7FFACAD22300
        public void __get_lifetime__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD223E0
        public void __get_minVertexDistance__SystemSingle(){} // RVA: 0x7FFACAD224F0
        public void __get_mode__UnityEngineParticleSystemTrailMode(){} // RVA: 0x7FFACAD225D0
        public void __get_ratio__SystemSingle(){} // RVA: 0x7FFACAD226B0
        public void __get_ribbonCount__SystemInt32(){} // RVA: 0x7FFACAD22790
        public void __get_shadowBias__SystemSingle(){} // RVA: 0x7FFACAD22870
        public void __get_sizeAffectsLifetime__SystemBoolean(){} // RVA: 0x7FFACAD22950
        public void __get_sizeAffectsWidth__SystemBoolean(){} // RVA: 0x7FFACAD22A30
        public void __get_splitSubEmitterRibbons__SystemBoolean(){} // RVA: 0x7FFACAD22B10
        public void __get_textureMode__UnityEngineParticleSystemTrailTextureMode(){} // RVA: 0x7FFACAD22BF0
        public void __get_textureScale__UnityEngineVector2(){} // RVA: 0x7FFACAD22CD0
        public void __get_widthOverTrailMultiplier__SystemSingle(){} // RVA: 0x7FFACAD22DC0
        public void __get_widthOverTrail__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD22EA0
        public void __get_worldSpace__SystemBoolean(){} // RVA: 0x7FFACAD22FB0
        public void __set_attachRibbonsToTransform__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD23090
        public void __set_colorOverLifetime__UnityEngineParticleSystemMinMaxGradient__SystemVoid(){} // RVA: 0x7FFACAD231B0
        public void __set_colorOverTrail__UnityEngineParticleSystemMinMaxGradient__SystemVoid(){} // RVA: 0x7FFACAD23300
        public void __set_dieWithParticles__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD23450
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD23570
        public void __set_generateLightingData__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD23690
        public void __set_inheritParticleColor__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD237B0
        public void __set_lifetimeMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD238D0
        public void __set_lifetime__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD239F0
        public void __set_minVertexDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD23B20
        public void __set_mode__UnityEngineParticleSystemTrailMode__SystemVoid(){} // RVA: 0x7FFACAD23C40
        public void __set_ratio__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD23D60
        public void __set_ribbonCount__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD23E80
        public void __set_shadowBias__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD23FA0
        public void __set_sizeAffectsLifetime__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD240C0
        public void __set_sizeAffectsWidth__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD241E0
        public void __set_splitSubEmitterRibbons__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD24300
        public void __set_textureMode__UnityEngineParticleSystemTrailTextureMode__SystemVoid(){} // RVA: 0x7FFACAD24420
        public void __set_textureScale__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAD24540
        public void __set_widthOverTrailMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD24650
        public void __set_widthOverTrail__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD24770
        public void __set_worldSpace__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD248A0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD249C0
    }

    public class ExternUnityEngineParticleSystemTrailModuleArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD26FA0
        public void .ctor(){} // RVA: 0x7FFACAD26FE0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD273B0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD274E0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAD275F0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD276D0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD277B0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD27880
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAD279D0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD27A70
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD27B70
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAD27C90
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD27DA0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD27EC0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD27FB0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAD28090
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD281B0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD28340
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAD28490
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAD285C0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD286E0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD28850
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAD28990
        public void __Get__SystemInt32__UnityEngineParticleSystemTrailModule(){} // RVA: 0x7FFACAD28AB0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAD28B90
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAD28C00
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD28D20
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD28EA0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD29000
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAD29130
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD29250
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD293B0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD29500
        public void __Set__SystemInt32_UnityEngineParticleSystemTrailModule__SystemVoid(){} // RVA: 0x7FFACAD29620
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD29700
        public void __ctor__SystemInt32__UnityEngineParticleSystemTrailModuleArray(){} // RVA: 0x7FFACAD297F0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAD29990
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAD29A30
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAD29AD0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAD29B70
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAD29C10
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAD29CB0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAD29D50
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD29E30
    }

    public class ExternUnityEngineParticleSystemTriggerModule : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD2BD50
        public void .ctor(){} // RVA: 0x7FFACAD2BD90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD2C160
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD2C290
        public void __AddCollider__UnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAD2C3A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD2C4C0
        public void __GetCollider__SystemInt32__UnityEngineComponent(){} // RVA: 0x7FFACAD2C600
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD2C750
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD2C800
        public void __RemoveCollider__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD2C8F0
        public void __RemoveCollider__UnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAD2C9D0
        public void __SetCollider__SystemInt32_UnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAD2CAF0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD2CC40
        public void __get_colliderCount__SystemInt32(){} // RVA: 0x7FFACAD2CCF0
        public void __get_colliderQueryMode__UnityEngineParticleSystemColliderQueryMode(){} // RVA: 0x7FFACAD2CDD0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAD2CEB0
        public void __get_enter__UnityEngineParticleSystemOverlapAction(){} // RVA: 0x7FFACAD2CF90
        public void __get_exit__UnityEngineParticleSystemOverlapAction(){} // RVA: 0x7FFACAD2D070
        public void __get_inside__UnityEngineParticleSystemOverlapAction(){} // RVA: 0x7FFACAD2D150
        public void __get_outside__UnityEngineParticleSystemOverlapAction(){} // RVA: 0x7FFACAD2D230
        public void __get_radiusScale__SystemSingle(){} // RVA: 0x7FFACAD2D310
        public void __set_colliderQueryMode__UnityEngineParticleSystemColliderQueryMode__SystemVoid(){} // RVA: 0x7FFACAD2D3F0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD2D510
        public void __set_enter__UnityEngineParticleSystemOverlapAction__SystemVoid(){} // RVA: 0x7FFACAD2D630
        public void __set_exit__UnityEngineParticleSystemOverlapAction__SystemVoid(){} // RVA: 0x7FFACAD2D750
        public void __set_inside__UnityEngineParticleSystemOverlapAction__SystemVoid(){} // RVA: 0x7FFACAD2D870
        public void __set_outside__UnityEngineParticleSystemOverlapAction__SystemVoid(){} // RVA: 0x7FFACAD2D990
        public void __set_radiusScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD2DAB0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD2DBD0
    }

    public class ExternUnityEngineParticleSystemTriggerModuleArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD2EFB0
        public void .ctor(){} // RVA: 0x7FFACAD2EFF0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD2F3C0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD2F4F0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAD2F600
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD2F6E0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD2F7C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD2F890
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAD2F9E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD2FA80
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD2FB80
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAD2FCA0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD2FDB0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD2FED0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD2FFC0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAD300A0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD301C0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD30350
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAD304A0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAD305D0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD306F0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD30860
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAD309A0
        public void __Get__SystemInt32__UnityEngineParticleSystemTriggerModule(){} // RVA: 0x7FFACAD30AC0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAD30BA0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAD30C10
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD30D30
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD30EB0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD31010
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAD31140
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD31260
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD313C0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD31510
        public void __Set__SystemInt32_UnityEngineParticleSystemTriggerModule__SystemVoid(){} // RVA: 0x7FFACAD31630
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD31710
        public void __ctor__SystemInt32__UnityEngineParticleSystemTriggerModuleArray(){} // RVA: 0x7FFACAD31800
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAD319A0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAD31A40
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAD31AE0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAD31B80
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAD31C20
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAD31CC0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAD31D60
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD31E40
    }

    public class ExternUnityEngineParticleSystemVelocityOverLifetimeModule : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD33D60
        public void .ctor(){} // RVA: 0x7FFACAD33DA0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD34170
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD342A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD343B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD344F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD345A0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD34690
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAD34740
        public void __get_orbitalOffsetXMultiplier__SystemSingle(){} // RVA: 0x7FFACAD34820
        public void __get_orbitalOffsetX__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD34900
        public void __get_orbitalOffsetYMultiplier__SystemSingle(){} // RVA: 0x7FFACAD34A10
        public void __get_orbitalOffsetY__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD34AF0
        public void __get_orbitalOffsetZMultiplier__SystemSingle(){} // RVA: 0x7FFACAD34C00
        public void __get_orbitalOffsetZ__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD34CE0
        public void __get_orbitalXMultiplier__SystemSingle(){} // RVA: 0x7FFACAD34DF0
        public void __get_orbitalX__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD34ED0
        public void __get_orbitalYMultiplier__SystemSingle(){} // RVA: 0x7FFACAD34FE0
        public void __get_orbitalY__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD350C0
        public void __get_orbitalZMultiplier__SystemSingle(){} // RVA: 0x7FFACAD351D0
        public void __get_orbitalZ__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD352B0
        public void __get_radialMultiplier__SystemSingle(){} // RVA: 0x7FFACAD353C0
        public void __get_radial__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD354A0
        public void __get_space__UnityEngineParticleSystemSimulationSpace(){} // RVA: 0x7FFACAD355B0
        public void __get_speedModifierMultiplier__SystemSingle(){} // RVA: 0x7FFACAD35690
        public void __get_speedModifier__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD35770
        public void __get_xMultiplier__SystemSingle(){} // RVA: 0x7FFACAD35880
        public void __get_x__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD35960
        public void __get_yMultiplier__SystemSingle(){} // RVA: 0x7FFACAD35A70
        public void __get_y__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD35B50
        public void __get_zMultiplier__SystemSingle(){} // RVA: 0x7FFACAD35C60
        public void __get_z__UnityEngineParticleSystemMinMaxCurve(){} // RVA: 0x7FFACAD35D40
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD35E50
        public void __set_orbitalOffsetXMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD35F70
        public void __set_orbitalOffsetX__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD36090
        public void __set_orbitalOffsetYMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD361C0
        public void __set_orbitalOffsetY__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD362E0
        public void __set_orbitalOffsetZMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD36410
        public void __set_orbitalOffsetZ__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD36530
        public void __set_orbitalXMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD36660
        public void __set_orbitalX__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD36780
        public void __set_orbitalYMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD368B0
        public void __set_orbitalY__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD369D0
        public void __set_orbitalZMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD36B00
        public void __set_orbitalZ__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD36C20
        public void __set_radialMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD36D50
        public void __set_radial__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD36E70
        public void __set_space__UnityEngineParticleSystemSimulationSpace__SystemVoid(){} // RVA: 0x7FFACAD36FA0
        public void __set_speedModifierMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD370C0
        public void __set_speedModifier__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD371E0
        public void __set_xMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD37310
        public void __set_x__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD37430
        public void __set_yMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD37560
        public void __set_y__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD37680
        public void __set_zMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD377B0
        public void __set_z__UnityEngineParticleSystemMinMaxCurve__SystemVoid(){} // RVA: 0x7FFACAD378D0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD37A00
    }

    public class ExternUnityEngineParticleSystemVelocityOverLifetimeModuleArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD3A2D0
        public void .ctor(){} // RVA: 0x7FFACAD3A310
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD3A6E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD3A810
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAD3A920
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD3AA00
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD3AAE0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD3ABB0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAD3AD00
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD3ADA0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD3AEA0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAD3AFC0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD3B0D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD3B1F0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD3B2E0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAD3B3C0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD3B4E0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD3B670
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAD3B7C0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAD3B8F0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD3BA10
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD3BB80
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAD3BCC0
        public void __Get__SystemInt32__UnityEngineParticleSystemVelocityOverLifetimeModule(){} // RVA: 0x7FFACAD3BDE0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAD3BEC0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAD3BF30
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD3C050
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD3C1D0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD3C330
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAD3C460
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD3C580
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD3C6E0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD3C830
        public void __Set__SystemInt32_UnityEngineParticleSystemVelocityOverLifetimeModule__SystemVoid(){} // RVA: 0x7FFACAD3C950
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD3CA30
        public void __ctor__SystemInt32__UnityEngineParticleSystemVelocityOverLifetimeModuleArray(){} // RVA: 0x7FFACAD3CB20
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAD3CCC0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAD3CD60
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAD3CE00
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAD3CEA0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAD3CF40
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAD3CFE0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAD3D080
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD3D160
    }

    public class ExternUnityEnginePhysicMaterial : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD3F080
        public void .ctor(){} // RVA: 0x7FFACAD3F0C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD3F490
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD3F5C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD3F6D0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD3F8A0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAD3FA00
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD3FB50
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD3FC40
        public void __get_bounceCombine__UnityEnginePhysicMaterialCombine(){} // RVA: 0x7FFACAD3FD90
        public void __get_bounciness__SystemSingle(){} // RVA: 0x7FFACAD3FEB0
        public void __get_dynamicFriction__SystemSingle(){} // RVA: 0x7FFACAD3FFD0
        public void __get_frictionCombine__UnityEnginePhysicMaterialCombine(){} // RVA: 0x7FFACAD400F0
        public void __get_name__SystemString(){} // RVA: 0x7FFACAD40210
        public void __get_staticFriction__SystemSingle(){} // RVA: 0x7FFACAD40360
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAD40480
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAD40780
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAD40970
        public void __set_bounceCombine__UnityEnginePhysicMaterialCombine__SystemVoid(){} // RVA: 0x7FFACAD40C70
        public void __set_bounciness__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD40D90
        public void __set_dynamicFriction__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD40EC0
        public void __set_frictionCombine__UnityEnginePhysicMaterialCombine__SystemVoid(){} // RVA: 0x7FFACAD40FF0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAD41110
        public void __set_staticFriction__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD41260
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD41390
    }

    public class ExternUnityEnginePhysicMaterialArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD42460
        public void .ctor(){} // RVA: 0x7FFACAD424A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD42870
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD429A0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAD42AB0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD42B90
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD42C70
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD42D40
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAD42E90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD42F30
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD43030
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAD43150
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD43260
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD43380
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD43470
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAD43550
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD43670
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAD43800
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAD43950
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAD43A80
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD43BA0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAD43D10
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAD43E50
        public void __Get__SystemInt32__UnityEnginePhysicMaterial(){} // RVA: 0x7FFACAD43F70
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAD440B0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAD44120
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD44240
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD443C0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD44520
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAD44650
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD44770
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD448D0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAD44A20
        public void __Set__SystemInt32_UnityEnginePhysicMaterial__SystemVoid(){} // RVA: 0x7FFACAD44B40
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD44CB0
        public void __ctor__SystemInt32__UnityEnginePhysicMaterialArray(){} // RVA: 0x7FFACAD44DA0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAD44F50
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAD44FF0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAD45090
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAD45130
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAD451D0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAD45270
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAD45310
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD453F0
    }

    public class ExternUnityEnginePhysics : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD47310
        public void .ctor(){} // RVA: 0x7FFACAD47350
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD47720
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD47850
        public void __BakeMesh__SystemInt32_SystemBoolean_UnityEngineMeshColliderCookingOptions__SystemVoid(){} // RVA: 0x7FFACAD47960
        public void __BakeMesh__SystemInt32_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD47AC0
        public void __BoxCastAll__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineQuaternion_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD47C20
        public void __BoxCastAll__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineQuaternion_SystemSingle_SystemInt32__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD47F00
        public void __BoxCastAll__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineQuaternion_SystemSingle__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD481D0
        public void __BoxCastAll__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineQuaternion__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD48470
        public void __BoxCastAll__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD486D0
        public void __BoxCastNonAlloc__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitArray_UnityEngineQuaternion_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACAD48930
        public void __BoxCastNonAlloc__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitArray_UnityEngineQuaternion_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD48C70
        public void __BoxCastNonAlloc__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitArray_UnityEngineQuaternion_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD49060
        public void __BoxCastNonAlloc__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitArray_UnityEngineQuaternion__SystemInt32(){} // RVA: 0x7FFACAD49410
        public void __BoxCastNonAlloc__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitArray__SystemInt32(){} // RVA: 0x7FFACAD49780
        public void __BoxCast__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineQuaternion_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD49AE0
        public void __BoxCast__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineQuaternion_SystemSingle_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD49DD0
        public void __BoxCast__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineQuaternion_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAD4A0B0
        public void __BoxCast__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineQuaternion__SystemBoolean(){} // RVA: 0x7FFACAD4A350
        public void __BoxCast__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitRef_UnityEngineQuaternion_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD4A5B0
        public void __BoxCast__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitRef_UnityEngineQuaternion_SystemSingle_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD4A9F0
        public void __BoxCast__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitRef_UnityEngineQuaternion_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAD4AD40
        public void __BoxCast__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitRef_UnityEngineQuaternion__SystemBoolean(){} // RVA: 0x7FFACAD4B050
        public void __BoxCast__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitRef__SystemBoolean(){} // RVA: 0x7FFACAD4B320
        public void __BoxCast__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3__SystemBoolean(){} // RVA: 0x7FFACAD4B5F0
        public void __CapsuleCastAll__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD4B850
        public void __CapsuleCastAll__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_SystemSingle_SystemInt32__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD4BB20
        public void __CapsuleCastAll__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_SystemSingle__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD4BDD0
        public void __CapsuleCastAll__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD4C050
        public void __CapsuleCastNonAlloc__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitArray_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACAD4C2A0
        public void __CapsuleCastNonAlloc__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD4C5B0
        public void __CapsuleCastNonAlloc__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD4C8C0
        public void __CapsuleCastNonAlloc__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitArray__SystemInt32(){} // RVA: 0x7FFACAD4CB80
        public void __CapsuleCast__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD4CE20
        public void __CapsuleCast__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_SystemSingle_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD4D0F0
        public void __CapsuleCast__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAD4D3B0
        public void __CapsuleCast__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitRef_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD4D640
        public void __CapsuleCast__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitRef_SystemSingle_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD4D990
        public void __CapsuleCast__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitRef_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAD4DCD0
        public void __CapsuleCast__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitRef__SystemBoolean(){} // RVA: 0x7FFACAD4DFD0
        public void __CapsuleCast__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3__SystemBoolean(){} // RVA: 0x7FFACAD4E2A0
        public void __CheckBox__UnityEngineVector3_UnityEngineVector3_UnityEngineQuaternion_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD4E500
        public void __CheckBox__UnityEngineVector3_UnityEngineVector3_UnityEngineQuaternion_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD4E740
        public void __CheckBox__UnityEngineVector3_UnityEngineVector3_UnityEngineQuaternion__SystemBoolean(){} // RVA: 0x7FFACAD4E970
        public void __CheckBox__UnityEngineVector3_UnityEngineVector3__SystemBoolean(){} // RVA: 0x7FFACAD4EC20
        public void __CheckCapsule__UnityEngineVector3_UnityEngineVector3_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD4EED0
        public void __CheckCapsule__UnityEngineVector3_UnityEngineVector3_SystemSingle_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD4F100
        public void __CheckCapsule__UnityEngineVector3_UnityEngineVector3_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAD4F320
        public void __CheckSphere__UnityEngineVector3_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD4F500
        public void __CheckSphere__UnityEngineVector3_SystemSingle_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD4F6D0
        public void __CheckSphere__UnityEngineVector3_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAD4F890
        public void __ClosestPoint__UnityEngineVector3_UnityEngineCollider_UnityEngineVector3_UnityEngineQuaternion__UnityEngineVector3(){} // RVA: 0x7FFACAD4FA10
        public void __ComputePenetration__UnityEngineCollider_UnityEngineVector3_UnityEngineQuaternion_UnityEngineCollider_UnityEngineVector3_UnityEngineQuaternion_UnityEngineVector3Ref_SystemSingleRef__SystemBoolean(){} // RVA: 0x7FFACAD4FCF0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD50100
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD50250
        public void __GetIgnoreCollision__UnityEngineCollider_UnityEngineCollider__SystemBoolean(){} // RVA: 0x7FFACAD50350
        public void __GetIgnoreLayerCollision__SystemInt32_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD504D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD50610
        public void __IgnoreCollision__UnityEngineCollider_UnityEngineCollider_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD50700
        public void __IgnoreCollision__UnityEngineCollider_UnityEngineCollider__SystemVoid(){} // RVA: 0x7FFACAD50850
        public void __Linecast__UnityEngineVector3_UnityEngineVector3_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD50960
        public void __Linecast__UnityEngineVector3_UnityEngineVector3_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD50B40
        public void __Linecast__UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitRef_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD50D10
        public void __Linecast__UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitRef_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD51000
        public void __Linecast__UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitRef__SystemBoolean(){} // RVA: 0x7FFACAD51260
        public void __Linecast__UnityEngineVector3_UnityEngineVector3__SystemBoolean(){} // RVA: 0x7FFACAD51480
        public void __OverlapBoxNonAlloc__UnityEngineVector3_UnityEngineVector3_UnityEngineColliderArray_UnityEngineQuaternion_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACAD51610
        public void __OverlapBoxNonAlloc__UnityEngineVector3_UnityEngineVector3_UnityEngineColliderArray_UnityEngineQuaternion_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD51970
        public void __OverlapBoxNonAlloc__UnityEngineVector3_UnityEngineVector3_UnityEngineColliderArray_UnityEngineQuaternion__SystemInt32(){} // RVA: 0x7FFACAD51CC0
        public void __OverlapBoxNonAlloc__UnityEngineVector3_UnityEngineVector3_UnityEngineColliderArray__SystemInt32(){} // RVA: 0x7FFACAD51FD0
        public void __OverlapBox__UnityEngineVector3_UnityEngineVector3_UnityEngineQuaternion_SystemInt32_UnityEngineQueryTriggerInteraction__UnityEngineColliderArray(){} // RVA: 0x7FFACAD522E0
        public void __OverlapBox__UnityEngineVector3_UnityEngineVector3_UnityEngineQuaternion_SystemInt32__UnityEngineColliderArray(){} // RVA: 0x7FFACAD52550
        public void __OverlapBox__UnityEngineVector3_UnityEngineVector3_UnityEngineQuaternion__UnityEngineColliderArray(){} // RVA: 0x7FFACAD527B0
        public void __OverlapBox__UnityEngineVector3_UnityEngineVector3__UnityEngineColliderArray(){} // RVA: 0x7FFACAD52A80
        public void __OverlapCapsuleNonAlloc__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineColliderArray_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACAD52D50
        public void __OverlapCapsuleNonAlloc__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineColliderArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD53020
        public void __OverlapCapsuleNonAlloc__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineColliderArray__SystemInt32(){} // RVA: 0x7FFACAD532E0
        public void __OverlapCapsule__UnityEngineVector3_UnityEngineVector3_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__UnityEngineColliderArray(){} // RVA: 0x7FFACAD53560
        public void __OverlapCapsule__UnityEngineVector3_UnityEngineVector3_SystemSingle_SystemInt32__UnityEngineColliderArray(){} // RVA: 0x7FFACAD537C0
        public void __OverlapCapsule__UnityEngineVector3_UnityEngineVector3_SystemSingle__UnityEngineColliderArray(){} // RVA: 0x7FFACAD53A10
        public void __OverlapSphereNonAlloc__UnityEngineVector3_SystemSingle_UnityEngineColliderArray_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACAD53C20
        public void __OverlapSphereNonAlloc__UnityEngineVector3_SystemSingle_UnityEngineColliderArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD53E80
        public void __OverlapSphereNonAlloc__UnityEngineVector3_SystemSingle_UnityEngineColliderArray__SystemInt32(){} // RVA: 0x7FFACAD540E0
        public void __OverlapSphere__UnityEngineVector3_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__UnityEngineColliderArray(){} // RVA: 0x7FFACAD54300
        public void __OverlapSphere__UnityEngineVector3_SystemSingle_SystemInt32__UnityEngineColliderArray(){} // RVA: 0x7FFACAD54500
        public void __OverlapSphere__UnityEngineVector3_SystemSingle__UnityEngineColliderArray(){} // RVA: 0x7FFACAD546F0
        public void __RaycastAll__UnityEngineRay_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD548A0
        public void __RaycastAll__UnityEngineRay_SystemSingle_SystemInt32__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD54AD0
        public void __RaycastAll__UnityEngineRay_SystemSingle__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD54CC0
        public void __RaycastAll__UnityEngineRay__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD54E70
        public void __RaycastAll__UnityEngineVector3_UnityEngineVector3_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD54FE0
        public void __RaycastAll__UnityEngineVector3_UnityEngineVector3_SystemSingle_SystemInt32__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD55200
        public void __RaycastAll__UnityEngineVector3_UnityEngineVector3_SystemSingle__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD55420
        public void __RaycastAll__UnityEngineVector3_UnityEngineVector3__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD55600
        public void __RaycastNonAlloc__UnityEngineRay_UnityEngineRaycastHitArray_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACAD557A0
        public void __RaycastNonAlloc__UnityEngineRay_UnityEngineRaycastHitArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD559C0
        public void __RaycastNonAlloc__UnityEngineRay_UnityEngineRaycastHitArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD55C10
        public void __RaycastNonAlloc__UnityEngineRay_UnityEngineRaycastHitArray__SystemInt32(){} // RVA: 0x7FFACAD55D90
        public void __RaycastNonAlloc__UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitArray_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACAD55F60
        public void __RaycastNonAlloc__UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD56220
        public void __RaycastNonAlloc__UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD564A0
        public void __RaycastNonAlloc__UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitArray__SystemInt32(){} // RVA: 0x7FFACAD566E0
        public void __Raycast__UnityEngineRay_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD568E0
        public void __Raycast__UnityEngineRay_SystemSingle_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD56B30
        public void __Raycast__UnityEngineRay_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAD56D40
        public void __Raycast__UnityEngineRay_UnityEngineRaycastHitRef_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD56F10
        public void __Raycast__UnityEngineRay_UnityEngineRaycastHitRef_SystemSingle_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD571C0
        public void __Raycast__UnityEngineRay_UnityEngineRaycastHitRef_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAD573F0
        public void __Raycast__UnityEngineRay_UnityEngineRaycastHitRef__SystemBoolean(){} // RVA: 0x7FFACAD57630
        public void __Raycast__UnityEngineRay__SystemBoolean(){} // RVA: 0x7FFACAD57840
        public void __Raycast__UnityEngineVector3_UnityEngineVector3_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD579D0
        public void __Raycast__UnityEngineVector3_UnityEngineVector3_SystemSingle_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD57C50
        public void __Raycast__UnityEngineVector3_UnityEngineVector3_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAD57E90
        public void __Raycast__UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitRef_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD58090
        public void __Raycast__UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitRef_SystemSingle_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD58380
        public void __Raycast__UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitRef_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAD58630
        public void __Raycast__UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitRef__SystemBoolean(){} // RVA: 0x7FFACAD58890
        public void __Raycast__UnityEngineVector3_UnityEngineVector3__SystemBoolean(){} // RVA: 0x7FFACAD58AB0
        public void __RebuildBroadphaseRegions__UnityEngineBounds_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD58C70
        public void __Simulate__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD58EF0
        public void __SphereCastAll__UnityEngineRay_SystemSingle_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD59090
        public void __SphereCastAll__UnityEngineRay_SystemSingle_SystemSingle_SystemInt32__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD592A0
        public void __SphereCastAll__UnityEngineRay_SystemSingle_SystemSingle__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD594A0
        public void __SphereCastAll__UnityEngineRay_SystemSingle__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD59620
        public void __SphereCastAll__UnityEngineVector3_SystemSingle_UnityEngineVector3_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD59810
        public void __SphereCastAll__UnityEngineVector3_SystemSingle_UnityEngineVector3_SystemSingle_SystemInt32__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD59A70
        public void __SphereCastAll__UnityEngineVector3_SystemSingle_UnityEngineVector3_SystemSingle__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD59CD0
        public void __SphereCastAll__UnityEngineVector3_SystemSingle_UnityEngineVector3__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAD59EF0
        public void __SphereCastNonAlloc__UnityEngineRay_SystemSingle_UnityEngineRaycastHitArray_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACAD5A0E0
        public void __SphereCastNonAlloc__UnityEngineRay_SystemSingle_UnityEngineRaycastHitArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD5A340
        public void __SphereCastNonAlloc__UnityEngineRay_SystemSingle_UnityEngineRaycastHitArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD5A590
        public void __SphereCastNonAlloc__UnityEngineRay_SystemSingle_UnityEngineRaycastHitArray__SystemInt32(){} // RVA: 0x7FFACAD5A7A0
        public void __SphereCastNonAlloc__UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitArray_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACAD5A980
        public void __SphereCastNonAlloc__UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD5AC30
        public void __SphereCastNonAlloc__UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD5AED0
        public void __SphereCastNonAlloc__UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitArray__SystemInt32(){} // RVA: 0x7FFACAD5B140
        public void __SphereCast__UnityEngineRay_SystemSingle_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD5B380
        public void __SphereCast__UnityEngineRay_SystemSingle_SystemSingle_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD5B5A0
        public void __SphereCast__UnityEngineRay_SystemSingle_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAD5B7B0
        public void __SphereCast__UnityEngineRay_SystemSingle_UnityEngineRaycastHitRef_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD5B980
        public void __SphereCast__UnityEngineRay_SystemSingle_UnityEngineRaycastHitRef_SystemSingle_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD5BC30
        public void __SphereCast__UnityEngineRay_SystemSingle_UnityEngineRaycastHitRef_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAD5BED0
        public void __SphereCast__UnityEngineRay_SystemSingle_UnityEngineRaycastHitRef__SystemBoolean(){} // RVA: 0x7FFACAD5C150
        public void __SphereCast__UnityEngineRay_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAD5C390
        public void __SphereCast__UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitRef_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAD5C530
        public void __SphereCast__UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitRef_SystemSingle_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD5C870
        public void __SphereCast__UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitRef_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAD5CBA0
        public void __SphereCast__UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitRef__SystemBoolean(){} // RVA: 0x7FFACAD5CE90
        public void __SyncTransforms__SystemVoid(){} // RVA: 0x7FFACAD5D140
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD5D1C0
        public void __get_AllLayers__SystemInt32(){} // RVA: 0x7FFACAD5D2B0
        public void __get_DefaultRaycastLayers__SystemInt32(){} // RVA: 0x7FFACAD5D320
        public void __get_IgnoreRaycastLayer__SystemInt32(){} // RVA: 0x7FFACAD5D390
        public void __get_bounceThreshold__SystemSingle(){} // RVA: 0x7FFACAD5D400
        public void __get_defaultMaxAngularSpeed__SystemSingle(){} // RVA: 0x7FFACAD5D4D0
        public void __get_defaultPhysicsScene__UnityEnginePhysicsScene(){} // RVA: 0x7FFACAD5D5A0
        public void __get_gravity__UnityEngineVector3(){} // RVA: 0x7FFACAD5D630
        public void __set_bounceThreshold__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD5D760
        public void __set_defaultMaxAngularSpeed__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD5D840
        public void __set_gravity__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAD5D920
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD5DA50
    }

    public class ExternUnityEnginePhysics2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAD651E0
        public void .ctor(){} // RVA: 0x7FFACAD65220
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAD655F0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAD65720
        public void __BoxCastAll__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle_SystemSingle__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD65830
        public void __BoxCastAll__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD65B30
        public void __BoxCastAll__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD65E10
        public void __BoxCastAll__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD660D0
        public void __BoxCastAll__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD66360
        public void __BoxCastNonAlloc__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD665D0
        public void __BoxCastNonAlloc__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD66970
        public void __BoxCastNonAlloc__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD66D00
        public void __BoxCastNonAlloc__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD67070
        public void __BoxCastNonAlloc__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAD672D0
        public void __BoxCast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle_SystemSingle__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD67500
        public void __BoxCast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD67880
        public void __BoxCast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD67BF0
        public void __BoxCast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD67F40
        public void __BoxCast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD68190
        public void __BoxCast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD684D0
        public void __BoxCast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAD68810
        public void __BoxCast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD68B20
        public void __CapsuleCastAll__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle_SystemSingle__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD68D40
        public void __CapsuleCastAll__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD69090
        public void __CapsuleCastAll__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD693C0
        public void __CapsuleCastAll__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_SystemSingle__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD696D0
        public void __CapsuleCastAll__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD699B0
        public void __CapsuleCastNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD69C70
        public void __CapsuleCastNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD6A060
        public void __CapsuleCastNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD6A430
        public void __CapsuleCastNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD6A7F0
        public void __CapsuleCastNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAD6AAA0
        public void __CapsuleCast__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle_SystemSingle__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD6AD20
        public void __CapsuleCast__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD6B0F0
        public void __CapsuleCast__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD6B4B0
        public void __CapsuleCast__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_SystemSingle__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD6B850
        public void __CapsuleCast__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD6BAF0
        public void __CapsuleCast__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD6BE80
        public void __CapsuleCast__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAD6C210
        public void __CapsuleCast__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD6C570
        public void __CircleCastAll__UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle_SystemSingle__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD6C7E0
        public void __CircleCastAll__UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD6CAA0
        public void __CircleCastAll__UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD6CD40
        public void __CircleCastAll__UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD6CFD0
        public void __CircleCastAll__UnityEngineVector2_SystemSingle_UnityEngineVector2__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD6D230
        public void __CircleCastNonAlloc__UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD6D470
        public void __CircleCastNonAlloc__UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD6D7D0
        public void __CircleCastNonAlloc__UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD6DB20
        public void __CircleCastNonAlloc__UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD6DE50
        public void __CircleCastNonAlloc__UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAD6E070
        public void __CircleCast__UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle_SystemSingle__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD6E260
        public void __CircleCast__UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD6E5E0
        public void __CircleCast__UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD6E940
        public void __CircleCast__UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD6EC80
        public void __CircleCast__UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD6EE90
        public void __CircleCast__UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD6F190
        public void __CircleCast__UnityEngineVector2_SystemSingle_UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAD6F490
        public void __CircleCast__UnityEngineVector2_SystemSingle_UnityEngineVector2__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD6F760
        public void __ClosestPoint__UnityEngineVector2_UnityEngineCollider2D__UnityEngineVector2(){} // RVA: 0x7FFACAD6F940
        public void __ClosestPoint__UnityEngineVector2_UnityEngineRigidbody2D__UnityEngineVector2(){} // RVA: 0x7FFACAD6FA80
        public void __Distance__UnityEngineCollider2D_UnityEngineCollider2D__UnityEngineColliderDistance2D(){} // RVA: 0x7FFACAD6FBC0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAD6FD30
        public void __GetContacts__UnityEngineCollider2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAD6FE80
        public void __GetContacts__UnityEngineCollider2D_SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACAD70130
        public void __GetContacts__UnityEngineCollider2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAD70390
        public void __GetContacts__UnityEngineCollider2D_UnityEngineCollider2D_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACAD70640
        public void __GetContacts__UnityEngineCollider2D_UnityEngineCollider2D_UnityEngineContactFilter2D_UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACAD708F0
        public void __GetContacts__UnityEngineCollider2D_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAD70BA0
        public void __GetContacts__UnityEngineCollider2D_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACAD70DC0
        public void __GetContacts__UnityEngineCollider2D_UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAD70F80
        public void __GetContacts__UnityEngineCollider2D_UnityEngineContactFilter2D_UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACAD711A0
        public void __GetContacts__UnityEngineCollider2D_UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACAD71360
        public void __GetContacts__UnityEngineRigidbody2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAD715C0
        public void __GetContacts__UnityEngineRigidbody2D_SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACAD71870
        public void __GetContacts__UnityEngineRigidbody2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAD71AD0
        public void __GetContacts__UnityEngineRigidbody2D_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAD71D80
        public void __GetContacts__UnityEngineRigidbody2D_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACAD71FA0
        public void __GetContacts__UnityEngineRigidbody2D_UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAD72160
        public void __GetContacts__UnityEngineRigidbody2D_UnityEngineContactFilter2D_UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACAD72380
        public void __GetContacts__UnityEngineRigidbody2D_UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACAD72540
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAD727A0
        public void __GetIgnoreCollision__UnityEngineCollider2D_UnityEngineCollider2D__SystemBoolean(){} // RVA: 0x7FFACAD728A0
        public void __GetIgnoreLayerCollision__SystemInt32_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD72A20
        public void __GetLayerCollisionMask__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD72C50
        public void __GetRayIntersectionAll__UnityEngineRay_SystemSingle_SystemInt32__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD72D30
        public void __GetRayIntersectionAll__UnityEngineRay_SystemSingle__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD72EB0
        public void __GetRayIntersectionAll__UnityEngineRay__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD730D0
        public void __GetRayIntersectionNonAlloc__UnityEngineRay_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD732C0
        public void __GetRayIntersectionNonAlloc__UnityEngineRay_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD73530
        public void __GetRayIntersectionNonAlloc__UnityEngineRay_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAD73760
        public void __GetRayIntersection__UnityEngineRay_SystemSingle_SystemInt32__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD73950
        public void __GetRayIntersection__UnityEngineRay_SystemSingle__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD73B10
        public void __GetRayIntersection__UnityEngineRay__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD73D30
        public void __GetType__SystemType(){} // RVA: 0x7FFACAD73F10
        public void __IgnoreCollision__UnityEngineCollider2D_UnityEngineCollider2D_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD74000
        public void __IgnoreCollision__UnityEngineCollider2D_UnityEngineCollider2D__SystemVoid(){} // RVA: 0x7FFACAD74150
        public void __IsTouchingLayers__UnityEngineCollider2D_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAD742E0
        public void __IsTouchingLayers__UnityEngineCollider2D__SystemBoolean(){} // RVA: 0x7FFACAD74460
        public void __IsTouching__UnityEngineCollider2D_UnityEngineCollider2D_UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACAD745E0
        public void __IsTouching__UnityEngineCollider2D_UnityEngineCollider2D__SystemBoolean(){} // RVA: 0x7FFACAD74860
        public void __IsTouching__UnityEngineCollider2D_UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACAD749E0
        public void __LinecastAll__UnityEngineVector2_UnityEngineVector2_SystemInt32_SystemSingle_SystemSingle__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD74C00
        public void __LinecastAll__UnityEngineVector2_UnityEngineVector2_SystemInt32_SystemSingle__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD74EE0
        public void __LinecastAll__UnityEngineVector2_UnityEngineVector2_SystemInt32__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD751A0
        public void __LinecastAll__UnityEngineVector2_UnityEngineVector2__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD75430
        public void __LinecastNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD75690
        public void __LinecastNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD75980
        public void __LinecastNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD75C50
        public void __LinecastNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAD75EF0
        public void __Linecast__UnityEngineVector2_UnityEngineVector2_SystemInt32_SystemSingle_SystemSingle__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD76080
        public void __Linecast__UnityEngineVector2_UnityEngineVector2_SystemInt32_SystemSingle__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD76380
        public void __Linecast__UnityEngineVector2_UnityEngineVector2_SystemInt32__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD76660
        public void __Linecast__UnityEngineVector2_UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D__SystemInt32(){} // RVA: 0x7FFACAD76910
        public void __Linecast__UnityEngineVector2_UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAD76B70
        public void __Linecast__UnityEngineVector2_UnityEngineVector2__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD76DD0
        public void __OverlapAreaAll__UnityEngineVector2_UnityEngineVector2_SystemInt32_SystemSingle_SystemSingle__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD76F60
        public void __OverlapAreaAll__UnityEngineVector2_UnityEngineVector2_SystemInt32_SystemSingle__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD771B0
        public void __OverlapAreaAll__UnityEngineVector2_UnityEngineVector2_SystemInt32__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD773C0
        public void __OverlapAreaAll__UnityEngineVector2_UnityEngineVector2__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD77590
        public void __OverlapAreaNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineCollider2DArray_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD77730
        public void __OverlapAreaNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineCollider2DArray_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD77A10
        public void __OverlapAreaNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineCollider2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD77CE0
        public void __OverlapAreaNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAD77F80
        public void __OverlapArea__UnityEngineVector2_UnityEngineVector2_SystemInt32_SystemSingle_SystemSingle__UnityEngineCollider2D(){} // RVA: 0x7FFACAD781C0
        public void __OverlapArea__UnityEngineVector2_UnityEngineVector2_SystemInt32_SystemSingle__UnityEngineCollider2D(){} // RVA: 0x7FFACAD78450
        public void __OverlapArea__UnityEngineVector2_UnityEngineVector2_SystemInt32__UnityEngineCollider2D(){} // RVA: 0x7FFACAD786C0
        public void __OverlapArea__UnityEngineVector2_UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAD78900
        public void __OverlapArea__UnityEngineVector2_UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAD78B70
        public void __OverlapArea__UnityEngineVector2_UnityEngineVector2__UnityEngineCollider2D(){} // RVA: 0x7FFACAD78DE0
        public void __OverlapBoxAll__UnityEngineVector2_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle_SystemSingle__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD78FD0
        public void __OverlapBoxAll__UnityEngineVector2_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD79220
        public void __OverlapBoxAll__UnityEngineVector2_UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD794C0
        public void __OverlapBoxAll__UnityEngineVector2_UnityEngineVector2_SystemSingle__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD79750
        public void __OverlapBoxNonAlloc__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineCollider2DArray_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD799B0
        public void __OverlapBoxNonAlloc__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineCollider2DArray_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD79D30
        public void __OverlapBoxNonAlloc__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineCollider2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD7A090
        public void __OverlapBoxNonAlloc__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAD7A3D0
        public void __OverlapBox__UnityEngineVector2_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle_SystemSingle__UnityEngineCollider2D(){} // RVA: 0x7FFACAD7A600
        public void __OverlapBox__UnityEngineVector2_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle__UnityEngineCollider2D(){} // RVA: 0x7FFACAD7A910
        public void __OverlapBox__UnityEngineVector2_UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineCollider2D(){} // RVA: 0x7FFACAD7AC10
        public void __OverlapBox__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAD7AEF0
        public void __OverlapBox__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAD7B200
        public void __OverlapBox__UnityEngineVector2_UnityEngineVector2_SystemSingle__UnityEngineCollider2D(){} // RVA: 0x7FFACAD7B510
        public void __OverlapCapsuleAll__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_SystemInt32_SystemSingle_SystemSingle__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD7B6F0
        public void __OverlapCapsuleAll__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_SystemInt32_SystemSingle__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD7BA90
        public void __OverlapCapsuleAll__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_SystemInt32__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD7BE10
        public void __OverlapCapsuleAll__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD7C170
        public void __OverlapCapsuleNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineCollider2DArray_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD7C4A0
        public void __OverlapCapsuleNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineCollider2DArray_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD7C870
        public void __OverlapCapsuleNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineCollider2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD7CC20
        public void __OverlapCapsuleNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAD7CFB0
        public void __OverlapCapsule__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_SystemInt32_SystemSingle_SystemSingle__UnityEngineCollider2D(){} // RVA: 0x7FFACAD7D230
        public void __OverlapCapsule__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_SystemInt32_SystemSingle__UnityEngineCollider2D(){} // RVA: 0x7FFACAD7D590
        public void __OverlapCapsule__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_SystemInt32__UnityEngineCollider2D(){} // RVA: 0x7FFACAD7D8D0
        public void __OverlapCapsule__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAD7DBF0
        public void __OverlapCapsule__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAD7DF50
        public void __OverlapCapsule__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle__UnityEngineCollider2D(){} // RVA: 0x7FFACAD7E2B0
        public void __OverlapCircleAll__UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle_SystemSingle__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD7E4D0
        public void __OverlapCircleAll__UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD7E7E0
        public void __OverlapCircleAll__UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD7EAD0
        public void __OverlapCircleAll__UnityEngineVector2_SystemSingle__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD7EC60
        public void __OverlapCircleNonAlloc__UnityEngineVector2_SystemSingle_UnityEngineCollider2DArray_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD7EF00
        public void __OverlapCircleNonAlloc__UnityEngineVector2_SystemSingle_UnityEngineCollider2DArray_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD7F230
        public void __OverlapCircleNonAlloc__UnityEngineVector2_SystemSingle_UnityEngineCollider2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD7F550
        public void __OverlapCircleNonAlloc__UnityEngineVector2_SystemSingle_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAD7F850
        public void __OverlapCircle__UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle_SystemSingle__UnityEngineCollider2D(){} // RVA: 0x7FFACAD7FA40
        public void __OverlapCircle__UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle__UnityEngineCollider2D(){} // RVA: 0x7FFACAD7FD10
        public void __OverlapCircle__UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineCollider2D(){} // RVA: 0x7FFACAD7FFC0
        public void __OverlapCircle__UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAD80150
        public void __OverlapCircle__UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAD80420
        public void __OverlapCircle__UnityEngineVector2_SystemSingle__UnityEngineCollider2D(){} // RVA: 0x7FFACAD806F0
        public void __OverlapCollider__UnityEngineCollider2D_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAD80890
        public void __OverlapCollider__UnityEngineCollider2D_UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAD80AE0
        public void __OverlapPointAll__UnityEngineVector2_SystemInt32_SystemSingle_SystemSingle__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD80D30
        public void __OverlapPointAll__UnityEngineVector2_SystemInt32_SystemSingle__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD81000
        public void __OverlapPointAll__UnityEngineVector2_SystemInt32__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD812B0
        public void __OverlapPointAll__UnityEngineVector2__UnityEngineCollider2DArray(){} // RVA: 0x7FFACAD81530
        public void __OverlapPointNonAlloc__UnityEngineVector2_UnityEngineCollider2DArray_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD81780
        public void __OverlapPointNonAlloc__UnityEngineVector2_UnityEngineCollider2DArray_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD81A80
        public void __OverlapPointNonAlloc__UnityEngineVector2_UnityEngineCollider2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD81D60
        public void __OverlapPointNonAlloc__UnityEngineVector2_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAD82010
        public void __OverlapPoint__UnityEngineVector2_SystemInt32_SystemSingle_SystemSingle__UnityEngineCollider2D(){} // RVA: 0x7FFACAD821B0
        public void __OverlapPoint__UnityEngineVector2_SystemInt32_SystemSingle__UnityEngineCollider2D(){} // RVA: 0x7FFACAD82440
        public void __OverlapPoint__UnityEngineVector2_SystemInt32__UnityEngineCollider2D(){} // RVA: 0x7FFACAD826B0
        public void __OverlapPoint__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAD82900
        public void __OverlapPoint__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAD82B70
        public void __OverlapPoint__UnityEngineVector2__UnityEngineCollider2D(){} // RVA: 0x7FFACAD82DE0
        public void __RaycastAll__UnityEngineVector2_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle_SystemSingle__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD82F40
        public void __RaycastAll__UnityEngineVector2_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD831C0
        public void __RaycastAll__UnityEngineVector2_UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD83420
        public void __RaycastAll__UnityEngineVector2_UnityEngineVector2_SystemSingle__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD83670
        public void __RaycastAll__UnityEngineVector2_UnityEngineVector2__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAD83890
        public void __RaycastNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD83A60
        public void __RaycastNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD83D90
        public void __RaycastNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAD840A0
        public void __RaycastNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD84390
        public void __RaycastNonAlloc__UnityEngineVector2_UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAD84580
        public void __Raycast__UnityEngineVector2_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle_SystemSingle__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD84720
        public void __Raycast__UnityEngineVector2_UnityEngineVector2_SystemSingle_SystemInt32_SystemSingle__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD84A60
        public void __Raycast__UnityEngineVector2_UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD84D80
        public void __Raycast__UnityEngineVector2_UnityEngineVector2_SystemSingle__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD85080
        public void __Raycast__UnityEngineVector2_UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD85260
        public void __Raycast__UnityEngineVector2_UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAD85520
        public void __Raycast__UnityEngineVector2_UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAD857E0
        public void __Raycast__UnityEngineVector2_UnityEngineVector2__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAD85A50
        public void __SetLayerCollisionMask__SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD85BF0
        public void __Simulate__SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAD85D80
        public void __SyncTransforms__SystemVoid(){} // RVA: 0x7FFACAD85EA0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAD85F20
        public void __get_AllLayers__SystemInt32(){} // RVA: 0x7FFACAD86010
        public void __get_DefaultRaycastLayers__SystemInt32(){} // RVA: 0x7FFACAD86080
        public void __get_IgnoreRaycastLayer__SystemInt32(){} // RVA: 0x7FFACAD860F0
        public void __get_MaxPolygonShapeVertices__SystemInt32(){} // RVA: 0x7FFACAD86160
        public void __get_angularSleepTolerance__SystemSingle(){} // RVA: 0x7FFACAD861D0
        public void __get_baumgarteScale__SystemSingle(){} // RVA: 0x7FFACAD862A0
        public void __get_baumgarteTOIScale__SystemSingle(){} // RVA: 0x7FFACAD86370
        public void __get_callbacksOnDisable__SystemBoolean(){} // RVA: 0x7FFACAD86440
        public void __get_defaultPhysicsScene__UnityEnginePhysicsScene2D(){} // RVA: 0x7FFACAD86510
        public void __get_gravity__UnityEngineVector2(){} // RVA: 0x7FFACAD865A0
        public void __get_linearSleepTolerance__SystemSingle(){} // RVA: 0x7FFACAD866B0
        public void __get_maxAngularCorrection__SystemSingle(){} // RVA: 0x7FFACAD86780
        public void __get_maxLinearCorrection__SystemSingle(){} // RVA: 0x7FFACAD86850
        public void __get_maxRotationSpeed__SystemSingle(){} // RVA: 0x7FFACAD86920
        public void __get_maxTranslationSpeed__SystemSingle(){} // RVA: 0x7FFACAD869F0
        public void __get_positionIterations__SystemInt32(){} // RVA: 0x7FFACAD86AC0
        public void __get_queriesStartInColliders__SystemBoolean(){} // RVA: 0x7FFACAD86B90
        public void __get_reuseCollisionCallbacks__SystemBoolean(){} // RVA: 0x7FFACAD86C60
        public void __get_timeToSleep__SystemSingle(){} // RVA: 0x7FFACAD86D30
        public void __get_velocityIterations__SystemInt32(){} // RVA: 0x7FFACAD86E00
        public void __get_velocityThreshold__SystemSingle(){} // RVA: 0x7FFACAD86ED0
        public void __set_angularSleepTolerance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD86FA0
        public void __set_baumgarteScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD87080
        public void __set_baumgarteTOIScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD87160
        public void __set_callbacksOnDisable__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD87240
        public void __set_gravity__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAD87320
        public void __set_linearSleepTolerance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD87440
        public void __set_maxAngularCorrection__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD87520
        public void __set_maxLinearCorrection__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD87600
        public void __set_maxRotationSpeed__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD876E0
        public void __set_maxTranslationSpeed__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD877C0
        public void __set_positionIterations__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD878A0
        public void __set_queriesStartInColliders__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD87970
        public void __set_reuseCollisionCallbacks__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAD87A50
        public void __set_timeToSleep__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD87B30
        public void __set_velocityIterations__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAD87C10
        public void __set_velocityThreshold__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAD87CE0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAD87DC0
    }

    public class ExternUnityEnginePhysicsMaterial2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACADB6C20
        public void .ctor(){} // RVA: 0x7FFACADB6C60
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACADB7030
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACADB7160
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACADB7270
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACADB7440
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACADB75A0
        public void __GetType__SystemType(){} // RVA: 0x7FFACADB76F0
        public void __ToString__SystemString(){} // RVA: 0x7FFACADB77E0
        public void __get_bounciness__SystemSingle(){} // RVA: 0x7FFACADB7930
        public void __get_friction__SystemSingle(){} // RVA: 0x7FFACADB7A50
        public void __get_name__SystemString(){} // RVA: 0x7FFACADB7B70
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACADB7CC0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACADB7FC0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACADB81B0
        public void __set_bounciness__SystemSingle__SystemVoid(){} // RVA: 0x7FFACADB84B0
        public void __set_friction__SystemSingle__SystemVoid(){} // RVA: 0x7FFACADB85E0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACADB8710
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACADB8860
    }

    public class ExternUnityEnginePhysicsMaterial2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACADB94C0
        public void .ctor(){} // RVA: 0x7FFACADB9500
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACADB98D0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACADB9A00
        public void __Clone__SystemObject(){} // RVA: 0x7FFACADB9B10
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADB9BF0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADB9CD0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACADB9DA0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACADB9EF0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACADB9F90
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADBA090
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACADBA1B0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADBA2C0
        public void __GetType__SystemType(){} // RVA: 0x7FFACADBA3E0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADBA4D0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACADBA5B0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACADBA6D0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACADBA860
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACADBA9B0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACADBAAE0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACADBAC00
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACADBAD70
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACADBAEB0
        public void __Get__SystemInt32__UnityEnginePhysicsMaterial2D(){} // RVA: 0x7FFACADBAFD0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACADBB110
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACADBB180
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADBB2A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADBB420
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADBB580
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACADBB6B0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADBB7D0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADBB930
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADBBA80
        public void __Set__SystemInt32_UnityEnginePhysicsMaterial2D__SystemVoid(){} // RVA: 0x7FFACADBBBA0
        public void __ToString__SystemString(){} // RVA: 0x7FFACADBBD30
        public void __ctor__SystemInt32__UnityEnginePhysicsMaterial2DArray(){} // RVA: 0x7FFACADBBE20
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACADBBFD0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACADBC070
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACADBC110
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACADBC1B0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACADBC250
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACADBC2F0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACADBC390
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACADBC470
    }

    public class ExternUnityEnginePhysicsScene : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACADBE390
        public void .ctor(){} // RVA: 0x7FFACADBE3D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACADBE7A0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACADBE8D0
        public void __BoxCast__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitArray_UnityEngineQuaternion_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACADBE9E0
        public void __BoxCast__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitArray__SystemInt32(){} // RVA: 0x7FFACADBEDA0
        public void __BoxCast__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitRef_UnityEngineQuaternion_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACADBEF80
        public void __BoxCast__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitRef__SystemBoolean(){} // RVA: 0x7FFACADBF380
        public void __CapsuleCast__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitArray_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACADBF6B0
        public void __CapsuleCast__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitRef_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACADBFA40
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACADBFE30
        public void __Equals__UnityEnginePhysicsScene__SystemBoolean(){} // RVA: 0x7FFACADBFFB0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACADC0070
        public void __GetType__SystemType(){} // RVA: 0x7FFACADC0100
        public void __InterpolateBodies__SystemVoid(){} // RVA: 0x7FFACADC01F0
        public void __IsEmpty__SystemBoolean(){} // RVA: 0x7FFACADC0270
        public void __IsValid__SystemBoolean(){} // RVA: 0x7FFACADC0320
        public void __OverlapBox__UnityEngineVector3_UnityEngineVector3_UnityEngineColliderArray_UnityEngineQuaternion_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACADC0400
        public void __OverlapBox__UnityEngineVector3_UnityEngineVector3_UnityEngineColliderArray__SystemInt32(){} // RVA: 0x7FFACADC0730
        public void __OverlapCapsule__UnityEngineVector3_UnityEngineVector3_SystemSingle_UnityEngineColliderArray_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACADC09C0
        public void __OverlapSphere__UnityEngineVector3_SystemSingle_UnityEngineColliderArray_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACADC0CE0
        public void __Raycast__UnityEngineVector3_UnityEngineVector3_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACADC0F90
        public void __Raycast__UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitArray_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACADC11C0
        public void __Raycast__UnityEngineVector3_UnityEngineVector3_UnityEngineRaycastHitRef_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACADC1430
        public void __ResetInterpolationPoses__SystemVoid(){} // RVA: 0x7FFACADC16D0
        public void __Simulate__SystemSingle__SystemVoid(){} // RVA: 0x7FFACADC1750
        public void __SphereCast__UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitArray_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemInt32(){} // RVA: 0x7FFACADC1800
        public void __SphereCast__UnityEngineVector3_SystemSingle_UnityEngineVector3_UnityEngineRaycastHitRef_SystemSingle_SystemInt32_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACADC1B30
        public void __ToString__SystemString(){} // RVA: 0x7FFACADC1ED0
        public void __op_Equality__UnityEnginePhysicsScene_UnityEnginePhysicsScene__SystemBoolean(){} // RVA: 0x7FFACADC1F70
        public void __op_Inequality__UnityEnginePhysicsScene_UnityEnginePhysicsScene__SystemBoolean(){} // RVA: 0x7FFACADC2030
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACADC20F0
    }

    public class ExternUnityEnginePhysicsScene2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACADC3700
        public void .ctor(){} // RVA: 0x7FFACADC3740
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACADC3B10
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACADC3C40
        public void __BoxCast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACADC3D50
        public void __BoxCast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D__SystemInt32(){} // RVA: 0x7FFACADC3FA0
        public void __BoxCast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACADC4280
        public void __BoxCast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACADC4560
        public void __BoxCast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_UnityEngineRaycastHit2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACADC4820
        public void __CapsuleCast__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACADC4A80
        public void __CapsuleCast__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D__SystemInt32(){} // RVA: 0x7FFACADC4D10
        public void __CapsuleCast__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACADC5030
        public void __CapsuleCast__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACADC5350
        public void __CapsuleCast__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineVector2_SystemSingle_UnityEngineRaycastHit2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACADC5660
        public void __CircleCast__UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACADC5910
        public void __CircleCast__UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D__SystemInt32(){} // RVA: 0x7FFACADC5B20
        public void __CircleCast__UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACADC5DC0
        public void __CircleCast__UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACADC6060
        public void __CircleCast__UnityEngineVector2_SystemSingle_UnityEngineVector2_SystemSingle_UnityEngineRaycastHit2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACADC6310
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACADC6530
        public void __Equals__UnityEnginePhysicsScene2D__SystemBoolean(){} // RVA: 0x7FFACADC66B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACADC6770
        public void __GetRayIntersection__UnityEngineRay_SystemSingle_SystemInt32__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACADC6800
        public void __GetRayIntersection__UnityEngineRay_SystemSingle_UnityEngineRaycastHit2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACADC6A30
        public void __GetType__SystemType(){} // RVA: 0x7FFACADC6C70
        public void __IsEmpty__SystemBoolean(){} // RVA: 0x7FFACADC6D60
        public void __IsValid__SystemBoolean(){} // RVA: 0x7FFACADC6E10
        public void __Linecast__UnityEngineVector2_UnityEngineVector2_SystemInt32__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACADC6EF0
        public void __Linecast__UnityEngineVector2_UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D__SystemInt32(){} // RVA: 0x7FFACADC7080
        public void __Linecast__UnityEngineVector2_UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACADC7290
        public void __Linecast__UnityEngineVector2_UnityEngineVector2_UnityEngineContactFilter2D__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACADC74A0
        public void __Linecast__UnityEngineVector2_UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACADC76C0
        public void __OverlapArea__UnityEngineVector2_UnityEngineVector2_SystemInt32__UnityEngineCollider2D(){} // RVA: 0x7FFACADC7850
        public void __OverlapArea__UnityEngineVector2_UnityEngineVector2_UnityEngineCollider2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACADC7A30
        public void __OverlapArea__UnityEngineVector2_UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACADC7C70
        public void __OverlapArea__UnityEngineVector2_UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACADC7EA0
        public void __OverlapArea__UnityEngineVector2_UnityEngineVector2_UnityEngineContactFilter2D__UnityEngineCollider2D(){} // RVA: 0x7FFACADC80D0
        public void __OverlapBox__UnityEngineVector2_UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineCollider2D(){} // RVA: 0x7FFACADC8290
        public void __OverlapBox__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineCollider2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACADC8470
        public void __OverlapBox__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACADC86A0
        public void __OverlapBox__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACADC8980
        public void __OverlapBox__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D__UnityEngineCollider2D(){} // RVA: 0x7FFACADC8C60
        public void __OverlapCapsule__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_SystemInt32__UnityEngineCollider2D(){} // RVA: 0x7FFACADC8EB0
        public void __OverlapCapsule__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineCollider2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACADC90C0
        public void __OverlapCapsule__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACADC9330
        public void __OverlapCapsule__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACADC9660
        public void __OverlapCapsule__UnityEngineVector2_UnityEngineVector2_UnityEngineCapsuleDirection2D_SystemSingle_UnityEngineContactFilter2D__UnityEngineCollider2D(){} // RVA: 0x7FFACADC9990
        public void __OverlapCircle__UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineCollider2D(){} // RVA: 0x7FFACADC9C30
        public void __OverlapCircle__UnityEngineVector2_SystemSingle_UnityEngineCollider2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACADC9DD0
        public void __OverlapCircle__UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACADC9FC0
        public void __OverlapCircle__UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACADCA260
        public void __OverlapCircle__UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D__UnityEngineCollider2D(){} // RVA: 0x7FFACADCA500
        public void __OverlapCollider__UnityEngineCollider2D_UnityEngineCollider2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACADCA710
        public void __OverlapCollider__UnityEngineCollider2D_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACADCA940
        public void __OverlapCollider__UnityEngineCollider2D_UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACADCAB60
        public void __OverlapPoint__UnityEngineVector2_SystemInt32__UnityEngineCollider2D(){} // RVA: 0x7FFACADCAD80
        public void __OverlapPoint__UnityEngineVector2_UnityEngineCollider2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACADCAED0
        public void __OverlapPoint__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACADCB070
        public void __OverlapPoint__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACADCB2B0
        public void __OverlapPoint__UnityEngineVector2_UnityEngineContactFilter2D__UnityEngineCollider2D(){} // RVA: 0x7FFACADCB4F0
        public void __Raycast__UnityEngineVector2_UnityEngineVector2_SystemSingle_SystemInt32__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACADCB6B0
        public void __Raycast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D__SystemInt32(){} // RVA: 0x7FFACADCB890
        public void __Raycast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACADCBAF0
        public void __Raycast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineContactFilter2D__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACADCBD50
        public void __Raycast__UnityEngineVector2_UnityEngineVector2_SystemSingle_UnityEngineRaycastHit2DArray_SystemInt32__SystemInt32(){} // RVA: 0x7FFACADCBFC0
        public void __Simulate__SystemSingle__SystemBoolean(){} // RVA: 0x7FFACADCC1A0
        public void __ToString__SystemString(){} // RVA: 0x7FFACADCC280
        public void __op_Equality__UnityEnginePhysicsScene2D_UnityEnginePhysicsScene2D__SystemBoolean(){} // RVA: 0x7FFACADCC320
        public void __op_Inequality__UnityEnginePhysicsScene2D_UnityEnginePhysicsScene2D__SystemBoolean(){} // RVA: 0x7FFACADCC3E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACADCC4A0
    }

    public class ExternUnityEnginePhysicsScene2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACADCF740
        public void .ctor(){} // RVA: 0x7FFACADCF780
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACADCFB50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACADCFC80
        public void __Clone__SystemObject(){} // RVA: 0x7FFACADCFD90
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADCFE70
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADCFF50
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACADD0020
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACADD0170
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACADD0210
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADD0310
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACADD0430
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADD0540
        public void __GetType__SystemType(){} // RVA: 0x7FFACADD0660
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADD0750
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACADD0830
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACADD0950
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACADD0AE0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACADD0C30
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACADD0D60
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACADD0E80
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACADD0FF0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACADD1130
        public void __Get__SystemInt32__UnityEnginePhysicsScene2D(){} // RVA: 0x7FFACADD1250
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACADD1330
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACADD13A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADD14C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADD1640
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADD17A0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACADD18D0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADD19F0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADD1B50
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADD1CA0
        public void __Set__SystemInt32_UnityEnginePhysicsScene2D__SystemVoid(){} // RVA: 0x7FFACADD1DC0
        public void __ToString__SystemString(){} // RVA: 0x7FFACADD1EA0
        public void __ctor__SystemInt32__UnityEnginePhysicsScene2DArray(){} // RVA: 0x7FFACADD1F90
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACADD2130
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACADD21D0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACADD2270
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACADD2310
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACADD23B0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACADD2450
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACADD24F0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACADD25D0
    }

    public class ExternUnityEnginePhysicsSceneArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACADD44F0
        public void .ctor(){} // RVA: 0x7FFACADD4530
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACADD4900
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACADD4A30
        public void __Clone__SystemObject(){} // RVA: 0x7FFACADD4B40
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADD4C20
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADD4D00
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACADD4DD0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACADD4F20
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACADD4FC0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADD50C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACADD51E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADD52F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACADD5410
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADD5500
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACADD55E0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACADD5700
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACADD5890
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACADD59E0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACADD5B10
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACADD5C30
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACADD5DA0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACADD5EE0
        public void __Get__SystemInt32__UnityEnginePhysicsScene(){} // RVA: 0x7FFACADD6000
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACADD60E0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACADD6150
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADD6270
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADD63F0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADD6550
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACADD6680
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADD67A0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADD6900
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADD6A50
        public void __Set__SystemInt32_UnityEnginePhysicsScene__SystemVoid(){} // RVA: 0x7FFACADD6B70
        public void __ToString__SystemString(){} // RVA: 0x7FFACADD6C50
        public void __ctor__SystemInt32__UnityEnginePhysicsSceneArray(){} // RVA: 0x7FFACADD6D40
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACADD6EE0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACADD6F80
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACADD7020
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACADD70C0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACADD7160
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACADD7200
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACADD72A0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACADD7380
    }

    public class ExternUnityEnginePlane : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACADD92A0
        public void .ctor(){} // RVA: 0x7FFACADD92E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACADD96B0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACADD97E0
        public void __ClosestPointOnPlane__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACADD98F0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACADD9A40
        public void __Flip__SystemVoid(){} // RVA: 0x7FFACADD9B80
        public void __GetDistanceToPoint__UnityEngineVector3__SystemSingle(){} // RVA: 0x7FFACADD9BF0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACADD9D00
        public void __GetSide__UnityEngineVector3__SystemBoolean(){} // RVA: 0x7FFACADD9DB0
        public void __GetType__SystemType(){} // RVA: 0x7FFACADD9ED0
        public void __Raycast__UnityEngineRay_SystemSingleRef__SystemBoolean(){} // RVA: 0x7FFACADD9FC0
        public void __SameSide__UnityEngineVector3_UnityEngineVector3__SystemBoolean(){} // RVA: 0x7FFACADDA200
        public void __Set3Points__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACADDA3A0
        public void __SetNormalAndPosition__UnityEngineVector3_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACADDA500
        public void __ToString__SystemString(){} // RVA: 0x7FFACADDA610
        public void __ToString__SystemString_SystemIFormatProvider__SystemString(){} // RVA: 0x7FFACADDA6C0
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFACADDA7D0
        public void __Translate__UnityEnginePlane_UnityEngineVector3__UnityEnginePlane(){} // RVA: 0x7FFACADDA8A0
        public void __Translate__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACADDAAA0
        public void __ctor__UnityEngineVector3_SystemSingle__UnityEnginePlane(){} // RVA: 0x7FFACADDAB40
        public void __ctor__UnityEngineVector3_UnityEngineVector3_UnityEngineVector3__UnityEnginePlane(){} // RVA: 0x7FFACADDACF0
        public void __ctor__UnityEngineVector3_UnityEngineVector3__UnityEnginePlane(){} // RVA: 0x7FFACADDAE70
        public void __get_distance__SystemSingle(){} // RVA: 0x7FFACADDB050
        public void __get_flipped__UnityEnginePlane(){} // RVA: 0x7FFACADDB0F0
        public void __get_normal__UnityEngineVector3(){} // RVA: 0x7FFACADDB1A0
        public void __set_distance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACADDB250
        public void __set_normal__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACADDB330
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACADDB410
    }

    public class ExternUnityEnginePlaneArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACADDC7F0
        public void .ctor(){} // RVA: 0x7FFACADDC830
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACADDCC00
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACADDCD30
        public void __Clone__SystemObject(){} // RVA: 0x7FFACADDCE40
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADDCF20
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADDD000
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACADDD0D0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACADDD220
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACADDD2C0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADDD3C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACADDD4E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADDD5F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACADDD710
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADDD800
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACADDD8E0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACADDDA00
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACADDDB90
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACADDDCE0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACADDDE10
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACADDDF30
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACADDE0A0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACADDE1E0
        public void __Get__SystemInt32__UnityEnginePlane(){} // RVA: 0x7FFACADDE300
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACADDE3F0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACADDE460
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADDE580
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADDE700
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADDE860
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACADDE990
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADDEAB0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADDEC10
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADDED60
        public void __Set__SystemInt32_UnityEnginePlane__SystemVoid(){} // RVA: 0x7FFACADDEE80
        public void __ToString__SystemString(){} // RVA: 0x7FFACADDEF70
        public void __ctor__SystemInt32__UnityEnginePlaneArray(){} // RVA: 0x7FFACADDF060
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACADDF110
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACADDF1B0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACADDF250
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACADDF2F0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACADDF390
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACADDF430
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACADDF4D0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACADDF5B0
    }

    public class ExternUnityEnginePlatformEffector2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACADE14D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACADE1510
        public void .ctor(){} // RVA: 0x7FFACADE15C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACADE1990
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACADE1AC0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACADE1BD0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACADE1DA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACADE1E90
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACADE2140
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACADE22A0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACADE23C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACADE24B0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACADE2730
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACADE2820
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACADE2AD0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACADE2C30
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACADE2D50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACADE2E40
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACADE30C0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACADE3230
        public void __GetComponent__T(){} // RVA: 0x7FFACADE3350
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACADE3430
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACADE3680
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACADE3770
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACADE3AA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACADE3B90
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACADE3ED0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACADE3FC0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACADE42D0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACADE4440
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACADE4570
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACADE4660
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACADE4950
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACADE4A40
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACADE4D80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACADE4E70
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACADE5180
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACADE52F0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACADE5430
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACADE5520
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACADE5810
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACADE5900
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACADE5BF0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACADE5D40
        public void __GetComponents__TArray(){} // RVA: 0x7FFACADE5E70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACADE5F60
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACADE6210
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACADE6370
        public void __GetType__SystemType(){} // RVA: 0x7FFACADE64C0
        public void __ToString__SystemString(){} // RVA: 0x7FFACADE65B0
        public void __get_colliderMask__SystemInt32(){} // RVA: 0x7FFACADE6700
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACADE6820
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACADE6940
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACADE6A80
        public void __get_name__SystemString(){} // RVA: 0x7FFACADE6BA0
        public void __get_rotationalOffset__SystemSingle(){} // RVA: 0x7FFACADE6CF0
        public void __get_sideArc__SystemSingle(){} // RVA: 0x7FFACADE6E10
        public void __get_surfaceArc__SystemSingle(){} // RVA: 0x7FFACADE6F30
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACADE7050
        public void __get_useColliderMask__SystemBoolean(){} // RVA: 0x7FFACADE7190
        public void __get_useOneWayGrouping__SystemBoolean(){} // RVA: 0x7FFACADE72B0
        public void __get_useOneWay__SystemBoolean(){} // RVA: 0x7FFACADE73D0
        public void __get_useSideBounce__SystemBoolean(){} // RVA: 0x7FFACADE74F0
        public void __get_useSideFriction__SystemBoolean(){} // RVA: 0x7FFACADE7610
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACADE7730
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACADE7A30
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACADE7C20
        public void __set_colliderMask__SystemInt32__SystemVoid(){} // RVA: 0x7FFACADE7F20
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACADE8040
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACADE8170
        public void __set_rotationalOffset__SystemSingle__SystemVoid(){} // RVA: 0x7FFACADE82C0
        public void __set_sideArc__SystemSingle__SystemVoid(){} // RVA: 0x7FFACADE83F0
        public void __set_surfaceArc__SystemSingle__SystemVoid(){} // RVA: 0x7FFACADE8520
        public void __set_useColliderMask__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACADE8650
        public void __set_useOneWayGrouping__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACADE8780
        public void __set_useOneWay__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACADE88B0
        public void __set_useSideBounce__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACADE89E0
        public void __set_useSideFriction__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACADE8B10
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACADE8C40
    }

    public class ExternUnityEnginePlatformEffector2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACADEBA50
        public void .ctor(){} // RVA: 0x7FFACADEBA90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACADEBE60
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACADEBF90
        public void __Clone__SystemObject(){} // RVA: 0x7FFACADEC0A0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADEC180
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADEC260
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACADEC330
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACADEC480
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACADEC520
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADEC620
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACADEC740
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADEC850
        public void __GetType__SystemType(){} // RVA: 0x7FFACADEC970
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADECA60
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACADECB40
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACADECC60
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACADECDF0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACADECF40
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACADED070
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACADED190
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACADED300
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACADED440
        public void __Get__SystemInt32__UnityEnginePlatformEffector2D(){} // RVA: 0x7FFACADED560
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACADED6A0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACADED710
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADED830
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADED9B0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADEDB10
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACADEDC40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADEDD60
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADEDEC0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADEE010
        public void __Set__SystemInt32_UnityEnginePlatformEffector2D__SystemVoid(){} // RVA: 0x7FFACADEE130
        public void __ToString__SystemString(){} // RVA: 0x7FFACADEE2F0
        public void __ctor__SystemInt32__UnityEnginePlatformEffector2DArray(){} // RVA: 0x7FFACADEE3E0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACADEE4D0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACADEE570
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACADEE610
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACADEE6B0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACADEE750
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACADEE7F0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACADEE890
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACADEE970
    }

    public class ExternUnityEnginePlayablesPlayableDirector : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACADF0890
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACADF08D0
        public void .ctor(){} // RVA: 0x7FFACADF0980
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACADF0D50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACADF0E80
        public void __DeferredEvaluate__SystemVoid(){} // RVA: 0x7FFACADF0F90
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACADF1080
        public void __Evaluate__SystemVoid(){} // RVA: 0x7FFACADF1250
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACADF1340
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACADF1430
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACADF16E0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACADF1840
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACADF1960
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACADF1A50
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACADF1CD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACADF1DC0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACADF2070
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACADF21D0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACADF22F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACADF23E0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACADF2660
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACADF27D0
        public void __GetComponent__T(){} // RVA: 0x7FFACADF28F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACADF29D0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACADF2C20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACADF2D10
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACADF3040
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACADF3130
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACADF3470
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACADF3560
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACADF3870
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACADF39E0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACADF3B10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACADF3C00
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACADF3EF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACADF3FE0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACADF4320
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACADF4410
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACADF4720
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACADF4890
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACADF49D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACADF4AC0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACADF4DB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACADF4EA0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACADF5190
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACADF52E0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACADF5410
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACADF5500
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACADF57B0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACADF5910
        public void __GetType__SystemType(){} // RVA: 0x7FFACADF5A60
        public void __Pause__SystemVoid(){} // RVA: 0x7FFACADF5B50
        public void __Play__SystemVoid(){} // RVA: 0x7FFACADF5C40
        public void __Resume__SystemVoid(){} // RVA: 0x7FFACADF5D30
        public void __Stop__SystemVoid(){} // RVA: 0x7FFACADF5E20
        public void __ToString__SystemString(){} // RVA: 0x7FFACADF5F10
        public void __get_duration__SystemDouble(){} // RVA: 0x7FFACADF6060
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACADF6180
        public void __get_extrapolationMode__UnityEnginePlayablesDirectorWrapMode(){} // RVA: 0x7FFACADF62A0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACADF63C0
        public void __get_initialTime__SystemDouble(){} // RVA: 0x7FFACADF6500
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACADF6620
        public void __get_name__SystemString(){} // RVA: 0x7FFACADF6740
        public void __get_playOnAwake__SystemBoolean(){} // RVA: 0x7FFACADF6890
        public void __get_timeUpdateMode__UnityEnginePlayablesDirectorUpdateMode(){} // RVA: 0x7FFACADF69B0
        public void __get_time__SystemDouble(){} // RVA: 0x7FFACADF6AD0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACADF6BF0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACADF6D30
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACADF7030
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACADF7220
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACADF7520
        public void __set_extrapolationMode__UnityEnginePlayablesDirectorWrapMode__SystemVoid(){} // RVA: 0x7FFACADF7650
        public void __set_initialTime__SystemDouble__SystemVoid(){} // RVA: 0x7FFACADF7770
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACADF78A0
        public void __set_playOnAwake__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACADF79F0
        public void __set_timeUpdateMode__UnityEnginePlayablesDirectorUpdateMode__SystemVoid(){} // RVA: 0x7FFACADF7B20
        public void __set_time__SystemDouble__SystemVoid(){} // RVA: 0x7FFACADF7C40
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACADF7D70
    }

    public class ExternUnityEnginePlayablesPlayableDirectorArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACADFAAD0
        public void .ctor(){} // RVA: 0x7FFACADFAB10
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACADFAEE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACADFB010
        public void __Clone__SystemObject(){} // RVA: 0x7FFACADFB120
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADFB200
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADFB2E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACADFB3B0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACADFB500
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACADFB5A0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADFB6A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACADFB7C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADFB8D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACADFB9F0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACADFBAE0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACADFBBC0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACADFBCE0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACADFBE70
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACADFBFC0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACADFC0F0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACADFC210
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACADFC380
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACADFC4C0
        public void __Get__SystemInt32__UnityEnginePlayablesPlayableDirector(){} // RVA: 0x7FFACADFC5E0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACADFC720
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACADFC790
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADFC8B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADFCA30
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACADFCB90
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACADFCCC0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADFCDE0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADFCF40
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACADFD090
        public void __Set__SystemInt32_UnityEnginePlayablesPlayableDirector__SystemVoid(){} // RVA: 0x7FFACADFD1B0
        public void __ToString__SystemString(){} // RVA: 0x7FFACADFD370
        public void __ctor__SystemInt32__UnityEnginePlayablesPlayableDirectorArray(){} // RVA: 0x7FFACADFD460
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACADFD550
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACADFD5F0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACADFD690
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACADFD730
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACADFD7D0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACADFD870
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACADFD910
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACADFD9F0
    }

    public class ExternUnityEnginePointEffector2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACADFF910
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACADFF950
        public void .ctor(){} // RVA: 0x7FFACADFFA00
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACADFFDD0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACADFFF00
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE00010
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAE001E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAE002D0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAE00580
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE006E0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACAE00800
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACAE008F0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAE00B70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAE00C60
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAE00F10
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE01070
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACAE01190
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACAE01280
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACAE01500
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE01670
        public void __GetComponent__T(){} // RVA: 0x7FFACAE01790
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACAE01870
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAE01AC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAE01BB0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE01EE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE01FD0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAE02310
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAE02400
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAE02710
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE02880
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAE029B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAE02AA0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE02D90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE02E80
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAE031C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAE032B0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAE035C0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE03730
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACAE03870
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACAE03960
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAE03C50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAE03D40
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAE04030
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE04180
        public void __GetComponents__TArray(){} // RVA: 0x7FFACAE042B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACAE043A0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE04650
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAE047B0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE04900
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE049F0
        public void __get_angularDrag__SystemSingle(){} // RVA: 0x7FFACAE04B40
        public void __get_colliderMask__SystemInt32(){} // RVA: 0x7FFACAE04C60
        public void __get_distanceScale__SystemSingle(){} // RVA: 0x7FFACAE04D80
        public void __get_drag__SystemSingle(){} // RVA: 0x7FFACAE04EA0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAE04FC0
        public void __get_forceMagnitude__SystemSingle(){} // RVA: 0x7FFACAE050E0
        public void __get_forceMode__UnityEngineEffectorForceMode2D(){} // RVA: 0x7FFACAE05200
        public void __get_forceSource__UnityEngineEffectorSelection2D(){} // RVA: 0x7FFACAE05320
        public void __get_forceTarget__UnityEngineEffectorSelection2D(){} // RVA: 0x7FFACAE05440
        public void __get_forceVariation__SystemSingle(){} // RVA: 0x7FFACAE05560
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACAE05680
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACAE057C0
        public void __get_name__SystemString(){} // RVA: 0x7FFACAE058E0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAE05A30
        public void __get_useColliderMask__SystemBoolean(){} // RVA: 0x7FFACAE05B70
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAE05C90
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAE05F90
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAE06180
        public void __set_angularDrag__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE06480
        public void __set_colliderMask__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE065B0
        public void __set_distanceScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE066D0
        public void __set_drag__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE06800
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE06930
        public void __set_forceMagnitude__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE06A60
        public void __set_forceMode__UnityEngineEffectorForceMode2D__SystemVoid(){} // RVA: 0x7FFACAE06B90
        public void __set_forceSource__UnityEngineEffectorSelection2D__SystemVoid(){} // RVA: 0x7FFACAE06CB0
        public void __set_forceTarget__UnityEngineEffectorSelection2D__SystemVoid(){} // RVA: 0x7FFACAE06DD0
        public void __set_forceVariation__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE06EF0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAE07020
        public void __set_useColliderMask__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE07170
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACAE072A0
    }

    public class ExternUnityEnginePointEffector2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE0A230
        public void .ctor(){} // RVA: 0x7FFACAE0A270
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE0A640
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE0A770
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAE0A880
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE0A960
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE0AA40
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE0AB10
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAE0AC60
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE0AD00
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE0AE00
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAE0AF20
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE0B030
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE0B150
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE0B240
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAE0B320
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE0B440
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE0B5D0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAE0B720
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAE0B850
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE0B970
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE0BAE0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAE0BC20
        public void __Get__SystemInt32__UnityEnginePointEffector2D(){} // RVA: 0x7FFACAE0BD40
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAE0BE80
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAE0BEF0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE0C010
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE0C190
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE0C2F0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAE0C420
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE0C540
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE0C6A0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE0C7F0
        public void __Set__SystemInt32_UnityEnginePointEffector2D__SystemVoid(){} // RVA: 0x7FFACAE0C910
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE0CAD0
        public void __ctor__SystemInt32__UnityEnginePointEffector2DArray(){} // RVA: 0x7FFACAE0CBC0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAE0CCB0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAE0CD50
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAE0CDF0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAE0CE90
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAE0CF30
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAE0CFD0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAE0D070
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE0D150
    }

    public class ExternUnityEnginePolygonCollider2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE0F070
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACAE0F0B0
        public void .ctor(){} // RVA: 0x7FFACAE0F160
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE0F530
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE0F660
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACAE0F770
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACAE0FA40
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAE0FD10
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAE0FF90
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACAE101D0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAE103A0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAE10530
        public void __ClosestPoint__UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACAE10680
        public void __CreateMesh__SystemBoolean_SystemBoolean__UnityEngineMesh(){} // RVA: 0x7FFACAE107E0
        public void __Distance__UnityEngineCollider2D__UnityEngineColliderDistance2D(){} // RVA: 0x7FFACAE10940
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE10AD0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAE10CA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAE10D90
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAE11040
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE111A0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACAE112C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACAE113B0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAE11630
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAE11720
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAE119D0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE11B30
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACAE11C50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACAE11D40
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACAE11FC0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE12130
        public void __GetComponent__T(){} // RVA: 0x7FFACAE12250
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACAE12330
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAE12580
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAE12670
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE129A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE12A90
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAE12DD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAE12EC0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAE131D0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE13340
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAE13470
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAE13560
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE13850
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE13940
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAE13C80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAE13D70
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAE14080
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE141F0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACAE14330
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACAE14420
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAE14710
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAE14800
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAE14AF0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE14C40
        public void __GetComponents__TArray(){} // RVA: 0x7FFACAE14D70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACAE14E60
        public void __GetContacts__SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAE15110
        public void __GetContacts__SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACAE15260
        public void __GetContacts__UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAE15370
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAE154C0
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACAE156F0
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAE158D0
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACAE15B00
        public void __GetContacts__UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACAE15CE0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE15DF0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAE15F50
        public void __GetPath__SystemInt32_SystemCollectionsGenericListUnityEngineVector2__SystemInt32(){} // RVA: 0x7FFACAE160A0
        public void __GetPath__SystemInt32__UnityEngineVector2Array(){} // RVA: 0x7FFACAE161E0
        public void __GetShapeHash__SystemUInt32(){} // RVA: 0x7FFACAE162F0
        public void __GetShapes__UnityEnginePhysicsShapeGroup2D_SystemInt32_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE16410
        public void __GetShapes__UnityEnginePhysicsShapeGroup2D__SystemInt32(){} // RVA: 0x7FFACAE16590
        public void __GetTotalPointCount__SystemInt32(){} // RVA: 0x7FFACAE16710
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE16830
        public void __IsTouchingLayers__SystemBoolean(){} // RVA: 0x7FFACAE16920
        public void __IsTouchingLayers__SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAE16A50
        public void __IsTouching__UnityEngineCollider2D_UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACAE16BB0
        public void __IsTouching__UnityEngineCollider2D__SystemBoolean(){} // RVA: 0x7FFACAE16D70
        public void __IsTouching__UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACAE16ED0
        public void __OverlapCollider__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAE17050
        public void __OverlapCollider__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAE17280
        public void __OverlapPoint__UnityEngineVector2__SystemBoolean(){} // RVA: 0x7FFACAE174B0
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAE17610
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAE17880
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAE17AF0
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAE17D20
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAE17F70
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE18180
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAE18350
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAE184E0
        public void __SetPath__SystemInt32_SystemCollectionsGenericListUnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE18630
        public void __SetPath__SystemInt32_UnityEngineVector2Array__SystemVoid(){} // RVA: 0x7FFACAE18800
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE189D0
        public void __get_attachedRigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACAE18B20
        public void __get_autoTiling__SystemBoolean(){} // RVA: 0x7FFACAE18C60
        public void __get_bounciness__SystemSingle(){} // RVA: 0x7FFACAE18D80
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACAE18EA0
        public void __get_callbackLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACAE18FF0
        public void __get_composite__UnityEngineCompositeCollider2D(){} // RVA: 0x7FFACAE19120
        public void __get_contactCaptureLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACAE19260
        public void __get_density__SystemSingle(){} // RVA: 0x7FFACAE19390
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAE194B0
        public void __get_errorState__UnityEngineColliderErrorState2D(){} // RVA: 0x7FFACAE195D0
        public void __get_excludeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACAE196F0
        public void __get_forceReceiveLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACAE19820
        public void __get_forceSendLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACAE19950
        public void __get_friction__SystemSingle(){} // RVA: 0x7FFACAE19A80
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACAE19BA0
        public void __get_includeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACAE19CE0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACAE19E10
        public void __get_isTrigger__SystemBoolean(){} // RVA: 0x7FFACAE19F30
        public void __get_layerOverridePriority__SystemInt32(){} // RVA: 0x7FFACAE1A050
        public void __get_name__SystemString(){} // RVA: 0x7FFACAE1A170
        public void __get_offset__UnityEngineVector2(){} // RVA: 0x7FFACAE1A2C0
        public void __get_pathCount__SystemInt32(){} // RVA: 0x7FFACAE1A3F0
        public void __get_points__UnityEngineVector2Array(){} // RVA: 0x7FFACAE1A510
        public void __get_shapeCount__SystemInt32(){} // RVA: 0x7FFACAE1A630
        public void __get_sharedMaterial__UnityEnginePhysicsMaterial2D(){} // RVA: 0x7FFACAE1A750
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAE1A890
        public void __get_useDelaunayMesh__SystemBoolean(){} // RVA: 0x7FFACAE1A9D0
        public void __get_usedByComposite__SystemBoolean(){} // RVA: 0x7FFACAE1AAF0
        public void __get_usedByEffector__SystemBoolean(){} // RVA: 0x7FFACAE1AC10
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAE1AD30
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAE1B030
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAE1B220
        public void __set_autoTiling__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE1B520
        public void __set_callbackLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACAE1B650
        public void __set_contactCaptureLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACAE1B770
        public void __set_density__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE1B890
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE1B9C0
        public void __set_excludeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACAE1BAF0
        public void __set_forceReceiveLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACAE1BC10
        public void __set_forceSendLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACAE1BD30
        public void __set_includeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACAE1BE50
        public void __set_isTrigger__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE1BF70
        public void __set_layerOverridePriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE1C0A0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAE1C1C0
        public void __set_offset__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE1C310
        public void __set_pathCount__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE1C430
        public void __set_points__UnityEngineVector2Array__SystemVoid(){} // RVA: 0x7FFACAE1C550
        public void __set_sharedMaterial__UnityEnginePhysicsMaterial2D__SystemVoid(){} // RVA: 0x7FFACAE1C670
        public void __set_useDelaunayMesh__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE1C7C0
        public void __set_usedByComposite__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE1C8F0
        public void __set_usedByEffector__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE1CA20
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACAE1CB50
    }

    public class ExternUnityEnginePolygonCollider2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE22A30
        public void .ctor(){} // RVA: 0x7FFACAE22A70
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE22E40
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE22F70
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAE23080
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE23160
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE23240
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE23310
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAE23460
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE23500
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE23600
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAE23720
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE23830
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE23950
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE23A40
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAE23B20
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE23C40
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE23DD0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAE23F20
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAE24050
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE24170
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE242E0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAE24420
        public void __Get__SystemInt32__UnityEnginePolygonCollider2D(){} // RVA: 0x7FFACAE24540
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAE24680
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAE246F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE24810
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE24990
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE24AF0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAE24C20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE24D40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE24EA0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE24FF0
        public void __Set__SystemInt32_UnityEnginePolygonCollider2D__SystemVoid(){} // RVA: 0x7FFACAE25110
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE252A0
        public void __ctor__SystemInt32__UnityEnginePolygonCollider2DArray(){} // RVA: 0x7FFACAE25390
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAE25480
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAE25520
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAE255C0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAE25660
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAE25700
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAE257A0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAE25840
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE25920
    }

    public class ExternUnityEngineQuaternion : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE27840
        public void .ctor(){} // RVA: 0x7FFACAE27880
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE27C50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE27D80
        public void __AngleAxis__SystemSingle_UnityEngineVector3__UnityEngineQuaternion(){} // RVA: 0x7FFACAE27E90
        public void __Angle__UnityEngineQuaternion_UnityEngineQuaternion__SystemSingle(){} // RVA: 0x7FFACAE27FE0
        public void __Dot__UnityEngineQuaternion_UnityEngineQuaternion__SystemSingle(){} // RVA: 0x7FFACAE28130
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE28240
        public void __Equals__UnityEngineQuaternion__SystemBoolean(){} // RVA: 0x7FFACAE284A0
        public void __Euler__SystemSingle_SystemSingle_SystemSingle__UnityEngineQuaternion(){} // RVA: 0x7FFACAE28640
        public void __Euler__UnityEngineVector3__UnityEngineQuaternion(){} // RVA: 0x7FFACAE287C0
        public void __FromToRotation__UnityEngineVector3_UnityEngineVector3__UnityEngineQuaternion(){} // RVA: 0x7FFACAE288F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE28A50
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE28B80
        public void __Inverse__UnityEngineQuaternion__UnityEngineQuaternion(){} // RVA: 0x7FFACAE28C70
        public void __LerpUnclamped__UnityEngineQuaternion_UnityEngineQuaternion_SystemSingle__UnityEngineQuaternion(){} // RVA: 0x7FFACAE28D70
        public void __Lerp__UnityEngineQuaternion_UnityEngineQuaternion_SystemSingle__UnityEngineQuaternion(){} // RVA: 0x7FFACAE28EE0
        public void __LookRotation__UnityEngineVector3_UnityEngineVector3__UnityEngineQuaternion(){} // RVA: 0x7FFACAE29050
        public void __LookRotation__UnityEngineVector3__UnityEngineQuaternion(){} // RVA: 0x7FFACAE291B0
        public void __Normalize__SystemVoid(){} // RVA: 0x7FFACAE29320
        public void __Normalize__UnityEngineQuaternion__UnityEngineQuaternion(){} // RVA: 0x7FFACAE293A0
        public void __RotateTowards__UnityEngineQuaternion_UnityEngineQuaternion_SystemSingle__UnityEngineQuaternion(){} // RVA: 0x7FFACAE29450
        public void __SetFromToRotation__UnityEngineVector3_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE29590
        public void __SetLookRotation__UnityEngineVector3_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE296E0
        public void __SetLookRotation__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE29830
        public void __Set__SystemSingle_SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE29990
        public void __SlerpUnclamped__UnityEngineQuaternion_UnityEngineQuaternion_SystemSingle__UnityEngineQuaternion(){} // RVA: 0x7FFACAE29A80
        public void __Slerp__UnityEngineQuaternion_UnityEngineQuaternion_SystemSingle__UnityEngineQuaternion(){} // RVA: 0x7FFACAE29BF0
        public void __ToAngleAxis__SystemSingleRef_UnityEngineVector3Ref__SystemVoid(){} // RVA: 0x7FFACAE29D60
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE29EC0
        public void __ToString__SystemString_SystemIFormatProvider__SystemString(){} // RVA: 0x7FFACAE29F70
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFACAE2A080
        public void __ctor__SystemSingle_SystemSingle_SystemSingle_SystemSingle__UnityEngineQuaternion(){} // RVA: 0x7FFACAE2A150
        public void __get_Item__SystemInt32__SystemSingle(){} // RVA: 0x7FFACAE2A2A0
        public void __get_eulerAngles__UnityEngineVector3(){} // RVA: 0x7FFACAE2A3F0
        public void __get_identity__UnityEngineQuaternion(){} // RVA: 0x7FFACAE2A4B0
        public void __get_kEpsilon__SystemSingle(){} // RVA: 0x7FFACAE2A550
        public void __get_normalized__UnityEngineQuaternion(){} // RVA: 0x7FFACAE2A5F0
        public void __get_w__SystemSingle(){} // RVA: 0x7FFACAE2A6A0
        public void __set_w__SystemSingle(){} // RVA: 0x7FFACAE2A7C0
        public void __get_x__SystemSingle(){} // RVA: 0x7FFACAE2A8D0
        public void __set_x__SystemSingle(){} // RVA: 0x7FFACAE2A9F0
        public void __get_y__SystemSingle(){} // RVA: 0x7FFACAE2AB00
        public void __set_y__SystemSingle(){} // RVA: 0x7FFACAE2AC20
        public void __get_z__SystemSingle(){} // RVA: 0x7FFACAE2AD30
        public void __set_z__SystemSingle(){} // RVA: 0x7FFACAE2AE50
        public void __op_Equality__UnityEngineQuaternion_UnityEngineQuaternion__SystemBoolean(){} // RVA: 0x7FFACAE2AF60
        public void __op_Inequality__UnityEngineQuaternion_UnityEngineQuaternion__SystemBoolean(){} // RVA: 0x7FFACAE2B080
        public void __op_Multiply__UnityEngineQuaternion_UnityEngineQuaternion__UnityEngineQuaternion(){} // RVA: 0x7FFACAE2B1A0
        public void __op_Multiply__UnityEngineQuaternion_UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACAE2B3D0
        public void __set_Item__SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE2B680
        public void __set_eulerAngles__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE2B820
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE2B980
    }

    public class ExternUnityEngineQuaternionArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE2DF60
        public void .ctor(){} // RVA: 0x7FFACAE2DFA0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE2E370
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE2E4A0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAE2E5B0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE2E690
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE2E770
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE2E840
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAE2E990
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE2EA30
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE2EB30
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAE2EC50
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE2ED60
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE2EE80
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE2EF70
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAE2F050
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE2F170
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE2F300
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAE2F450
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAE2F580
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE2F6A0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE2F810
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAE2F950
        public void __Get__SystemInt32__UnityEngineQuaternion(){} // RVA: 0x7FFACAE2FA70
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAE2FB60
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAE2FBD0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE2FCF0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE2FE70
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE2FFD0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAE30100
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE30220
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE30380
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE304D0
        public void __Set__SystemInt32_UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACAE305F0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE306E0
        public void __ctor__SystemInt32__UnityEngineQuaternionArray(){} // RVA: 0x7FFACAE307D0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAE30970
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAE30A10
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAE30AB0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAE30B50
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAE30BF0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAE30C90
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAE30D30
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE30E10
    }

    public class ExternUnityEngineRandom : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE32D30
        public void .ctor(){} // RVA: 0x7FFACAE32D70
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE33140
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE33270
        public void __ColorHSV__SystemSingle_SystemSingle_SystemSingle_SystemSingle_SystemSingle_SystemSingle_SystemSingle_SystemSingle__UnityEngineColor(){} // RVA: 0x7FFACAE33380
        public void __ColorHSV__SystemSingle_SystemSingle_SystemSingle_SystemSingle_SystemSingle_SystemSingle__UnityEngineColor(){} // RVA: 0x7FFACAE335E0
        public void __ColorHSV__SystemSingle_SystemSingle_SystemSingle_SystemSingle__UnityEngineColor(){} // RVA: 0x7FFACAE337D0
        public void __ColorHSV__SystemSingle_SystemSingle__UnityEngineColor(){} // RVA: 0x7FFACAE33960
        public void __ColorHSV__UnityEngineColor(){} // RVA: 0x7FFACAE33A80
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE33B30
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE33C80
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE33D80
        public void __InitState__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE33E70
        public void __Range__SystemInt32_SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE33F20
        public void __Range__SystemSingle_SystemSingle__SystemSingle(){} // RVA: 0x7FFACAE34040
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE34110
        public void __get_insideUnitCircle__UnityEngineVector2(){} // RVA: 0x7FFACAE34200
        public void __get_insideUnitSphere__UnityEngineVector3(){} // RVA: 0x7FFACAE342B0
        public void __get_onUnitSphere__UnityEngineVector3(){} // RVA: 0x7FFACAE34380
        public void __get_rotationUniform__UnityEngineQuaternion(){} // RVA: 0x7FFACAE34450
        public void __get_rotation__UnityEngineQuaternion(){} // RVA: 0x7FFACAE34510
        public void __get_value__SystemSingle(){} // RVA: 0x7FFACAE345D0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE34680
    }

    public class ExternUnityEngineRay : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE355E0
        public void .ctor(){} // RVA: 0x7FFACAE35620
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE359F0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE35B20
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE35C30
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE35D70
        public void __GetPoint__SystemSingle__UnityEngineVector3(){} // RVA: 0x7FFACAE35E20
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE35F50
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE36040
        public void __ToString__SystemString_SystemIFormatProvider__SystemString(){} // RVA: 0x7FFACAE360F0
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFACAE36210
        public void __ctor__UnityEngineVector3_UnityEngineVector3__UnityEngineRay(){} // RVA: 0x7FFACAE362F0
        public void __get_direction__UnityEngineVector3(){} // RVA: 0x7FFACAE364A0
        public void __get_origin__UnityEngineVector3(){} // RVA: 0x7FFACAE36560
        public void __set_direction__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE36610
        public void __set_origin__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE367C0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE368C0
    }

    public class ExternUnityEngineRayArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE373A0
        public void .ctor(){} // RVA: 0x7FFACAE373E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE377B0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE378E0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAE379F0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE37AD0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE37BB0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE37C80
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAE37DD0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE37E70
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE37F70
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAE38090
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE381A0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE382C0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE383B0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAE38490
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE385B0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE38740
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAE38890
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAE389C0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE38AE0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE38C50
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAE38D90
        public void __Get__SystemInt32__UnityEngineRay(){} // RVA: 0x7FFACAE38EB0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAE38FB0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAE39020
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE39140
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE392C0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE39420
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAE39550
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE39670
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE397D0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE39920
        public void __Set__SystemInt32_UnityEngineRay__SystemVoid(){} // RVA: 0x7FFACAE39A40
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE39B50
        public void __ctor__SystemInt32__UnityEngineRayArray(){} // RVA: 0x7FFACAE39C40
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAE39DE0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAE39E80
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAE39F20
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAE39FC0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAE3A060
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAE3A100
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAE3A1A0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE3A280
    }

    public class ExternUnityEngineRaycastHit : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE3C1A0
        public void .ctor(){} // RVA: 0x7FFACAE3C1E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE3C5B0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE3C6E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE3C7F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE3C930
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE3C9E0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE3CAD0
        public void __get_articulationBody__UnityEngineArticulationBody(){} // RVA: 0x7FFACAE3CB80
        public void __get_barycentricCoordinate__UnityEngineVector3(){} // RVA: 0x7FFACAE3CC90
        public void __get_colliderInstanceID__SystemInt32(){} // RVA: 0x7FFACAE3CD60
        public void __get_collider__UnityEngineCollider(){} // RVA: 0x7FFACAE3CE00
        public void __get_distance__SystemSingle(){} // RVA: 0x7FFACAE3CF10
        public void __get_lightmapCoord__UnityEngineVector2(){} // RVA: 0x7FFACAE3CFB0
        public void __get_normal__UnityEngineVector3(){} // RVA: 0x7FFACAE3D080
        public void __get_point__UnityEngineVector3(){} // RVA: 0x7FFACAE3D150
        public void __get_rigidbody__UnityEngineRigidbody(){} // RVA: 0x7FFACAE3D200
        public void __get_textureCoord2__UnityEngineVector2(){} // RVA: 0x7FFACAE3D310
        public void __get_textureCoord__UnityEngineVector2(){} // RVA: 0x7FFACAE3D3E0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAE3D4B0
        public void __get_triangleIndex__SystemInt32(){} // RVA: 0x7FFACAE3D5C0
        public void __set_barycentricCoordinate__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE3D670
        public void __set_distance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE3D7A0
        public void __set_normal__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE3D8E0
        public void __set_point__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE3DA20
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE3DB60
    }

    public class ExternUnityEngineRaycastHit2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE3ED00
        public void .ctor(){} // RVA: 0x7FFACAE3ED40
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE3F110
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE3F240
        public void __CompareTo__UnityEngineRaycastHit2D__SystemInt32(){} // RVA: 0x7FFACAE3F350
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE3F460
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE3F5A0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE3F650
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE3F740
        public void __get_centroid__UnityEngineVector2(){} // RVA: 0x7FFACAE3F7F0
        public void __get_collider__UnityEngineCollider2D(){} // RVA: 0x7FFACAE3F8A0
        public void __get_distance__SystemSingle(){} // RVA: 0x7FFACAE3F9A0
        public void __get_fraction__SystemSingle(){} // RVA: 0x7FFACAE3FA40
        public void __get_normal__UnityEngineVector2(){} // RVA: 0x7FFACAE3FAE0
        public void __get_point__UnityEngineVector2(){} // RVA: 0x7FFACAE3FB90
        public void __get_rigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACAE3FC40
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAE3FD40
        public void __op_Implicit__UnityEngineRaycastHit2D__SystemBoolean(){} // RVA: 0x7FFACAE3FE40
        public void __set_centroid__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE3FFD0
        public void __set_distance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE40110
        public void __set_fraction__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE40230
        public void __set_normal__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE40350
        public void __set_point__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE40490
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE405D0
    }

    public class ExternUnityEngineRaycastHit2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE415F0
        public void .ctor(){} // RVA: 0x7FFACAE41630
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE41A00
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE41B30
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAE41C40
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE41D20
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE41E00
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE41ED0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAE42020
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE420C0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE421C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAE422E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE423F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE42510
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE42600
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAE426E0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE42800
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE42990
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAE42AE0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAE42C10
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE42D30
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE42EA0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAE42FE0
        public void __Get__SystemInt32__UnityEngineRaycastHit2D(){} // RVA: 0x7FFACAE43100
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAE43200
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAE43270
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE43390
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE43510
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE43670
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAE437A0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE438C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE43A20
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE43B70
        public void __Set__SystemInt32_UnityEngineRaycastHit2D__SystemVoid(){} // RVA: 0x7FFACAE43C90
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE43DA0
        public void __ctor__SystemInt32__UnityEngineRaycastHit2DArray(){} // RVA: 0x7FFACAE43E90
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAE43F40
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAE43FE0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAE44080
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAE44120
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAE441C0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAE44260
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAE44300
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE443E0
    }

    public class ExternUnityEngineRaycastHitArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE46300
        public void .ctor(){} // RVA: 0x7FFACAE46340
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE46710
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE46840
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAE46950
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE46A30
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE46B10
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE46BE0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAE46D30
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE46DD0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE46ED0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAE46FF0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE47100
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE47220
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE47310
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAE473F0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE47510
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE476A0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAE477F0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAE47920
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE47A40
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE47BB0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAE47CF0
        public void __Get__SystemInt32__UnityEngineRaycastHit(){} // RVA: 0x7FFACAE47E10
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAE47F20
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAE47F90
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE480B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE48230
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE48390
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAE484C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE485E0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE48740
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE48890
        public void __Set__SystemInt32_UnityEngineRaycastHit__SystemVoid(){} // RVA: 0x7FFACAE489B0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE48AC0
        public void __ctor__SystemInt32__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAE48BB0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAE48C60
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAE48D00
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAE48DA0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAE48E40
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAE48EE0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAE48F80
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAE49020
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE49100
    }

    public class ExternUnityEngineRect : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE4B020
        public void .ctor(){} // RVA: 0x7FFACAE4B060
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE4B430
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE4B560
        public void __Contains__UnityEngineVector2__SystemBoolean(){} // RVA: 0x7FFACAE4B670
        public void __Contains__UnityEngineVector3_SystemBoolean__SystemBoolean(){} // RVA: 0x7FFACAE4B790
        public void __Contains__UnityEngineVector3__SystemBoolean(){} // RVA: 0x7FFACAE4B8D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE4B9F0
        public void __Equals__UnityEngineRect__SystemBoolean(){} // RVA: 0x7FFACAE4BC50
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE4BDF0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE4BF20
        public void __MinMaxRect__SystemSingle_SystemSingle_SystemSingle_SystemSingle__UnityEngineRect(){} // RVA: 0x7FFACAE4C010
        public void __NormalizedToPoint__UnityEngineRect_UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACAE4C170
        public void __Overlaps__UnityEngineRect_SystemBoolean__SystemBoolean(){} // RVA: 0x7FFACAE4C2C0
        public void __Overlaps__UnityEngineRect__SystemBoolean(){} // RVA: 0x7FFACAE4C3E0
        public void __PointToNormalized__UnityEngineRect_UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACAE4C500
        public void __Set__SystemSingle_SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE4C660
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE4C750
        public void __ToString__SystemString_SystemIFormatProvider__SystemString(){} // RVA: 0x7FFACAE4C800
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFACAE4C920
        public void __ctor__SystemSingle_SystemSingle_SystemSingle_SystemSingle__UnityEngineRect(){} // RVA: 0x7FFACAE4C9F0
        public void __ctor__UnityEngineRect__UnityEngineRect(){} // RVA: 0x7FFACAE4CB40
        public void __ctor__UnityEngineVector2_UnityEngineVector2__UnityEngineRect(){} // RVA: 0x7FFACAE4CC10
        public void __get_center__UnityEngineVector2(){} // RVA: 0x7FFACAE4CD10
        public void __get_height__SystemSingle(){} // RVA: 0x7FFACAE4CDD0
        public void __get_max__UnityEngineVector2(){} // RVA: 0x7FFACAE4CE70
        public void __get_min__UnityEngineVector2(){} // RVA: 0x7FFACAE4CF30
        public void __get_position__UnityEngineVector2(){} // RVA: 0x7FFACAE4CFD0
        public void __get_size__UnityEngineVector2(){} // RVA: 0x7FFACAE4D070
        public void __get_width__SystemSingle(){} // RVA: 0x7FFACAE4D120
        public void __get_xMax__SystemSingle(){} // RVA: 0x7FFACAE4D1C0
        public void __get_xMin__SystemSingle(){} // RVA: 0x7FFACAE4D260
        public void __get_x__SystemSingle(){} // RVA: 0x7FFACAE4D300
        public void __get_yMax__SystemSingle(){} // RVA: 0x7FFACAE4D3A0
        public void __get_yMin__SystemSingle(){} // RVA: 0x7FFACAE4D450
        public void __get_y__SystemSingle(){} // RVA: 0x7FFACAE4D4F0
        public void __get_zero__UnityEngineRect(){} // RVA: 0x7FFACAE4D590
        public void __op_Equality__UnityEngineRect_UnityEngineRect__SystemBoolean(){} // RVA: 0x7FFACAE4D600
        public void __op_Inequality__UnityEngineRect_UnityEngineRect__SystemBoolean(){} // RVA: 0x7FFACAE4D710
        public void __set_center__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE4D820
        public void __set_height__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE4D950
        public void __set_max__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE4DA30
        public void __set_min__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE4DB50
        public void __set_position__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE4DC80
        public void __set_size__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE4DD90
        public void __set_width__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE4DEA0
        public void __set_xMax__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE4DF80
        public void __set_xMin__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE4E090
        public void __set_x__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE4E1B0
        public void __set_yMax__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE4E2C0
        public void __set_yMin__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE4E3D0
        public void __set_y__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE4E4F0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE4E5D0
    }

    public class ExternUnityEngineRectArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE50BB0
        public void .ctor(){} // RVA: 0x7FFACAE50BF0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE50FC0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE510F0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAE51200
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE512E0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE513C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE51490
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAE515E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE51680
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE51780
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAE518A0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE519B0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE51AD0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE51BC0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAE51CA0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE51DC0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE51F50
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAE520A0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAE521D0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE522F0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE52460
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAE525A0
        public void __Get__SystemInt32__UnityEngineRect(){} // RVA: 0x7FFACAE526C0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAE527B0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAE52820
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE52940
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE52AC0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE52C20
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAE52D50
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE52E70
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE52FD0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE53120
        public void __Set__SystemInt32_UnityEngineRect__SystemVoid(){} // RVA: 0x7FFACAE53240
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE53330
        public void __ctor__SystemInt32__UnityEngineRectArray(){} // RVA: 0x7FFACAE53420
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAE535C0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAE53660
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAE53700
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAE537A0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAE53840
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAE538E0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAE53980
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE53A60
    }

    public class ExternUnityEngineRectTransform : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE55980
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACAE559C0
        public void .ctor(){} // RVA: 0x7FFACAE55A70
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE55E40
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE55F70
        public void __DetachChildren__SystemVoid(){} // RVA: 0x7FFACAE56080
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE56170
        public void __Find__SystemString__UnityEngineTransform(){} // RVA: 0x7FFACAE56340
        public void __ForceUpdateRectTransforms__SystemVoid(){} // RVA: 0x7FFACAE56510
        public void __GetChild__SystemInt32__UnityEngineTransform(){} // RVA: 0x7FFACAE56600
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAE56770
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAE56860
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAE56B10
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE56C70
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACAE56D90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACAE56E80
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAE57100
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAE571F0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAE574A0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE57600
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACAE57720
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACAE57810
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACAE57A90
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE57C00
        public void __GetComponent__T(){} // RVA: 0x7FFACAE57D20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACAE57E00
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAE58050
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAE58140
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE58470
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE58560
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAE588A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAE58990
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAE58CA0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE58E10
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAE58F40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAE59030
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE59320
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE59410
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAE59750
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAE59840
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAE59B50
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE59CC0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACAE59E00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACAE59EF0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAE5A1E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAE5A2D0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAE5A5C0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE5A710
        public void __GetComponents__TArray(){} // RVA: 0x7FFACAE5A840
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACAE5A930
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAE5ABE0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE5ACC0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAE5AE20
        public void __GetLocalCorners__UnityEngineVector3Array__SystemVoid(){} // RVA: 0x7FFACAE5AF70
        public void __GetLocalPositionAndRotation__UnityEngineVector3Ref_UnityEngineQuaternionRef__SystemVoid(){} // RVA: 0x7FFACAE5B050
        public void __GetPositionAndRotation__UnityEngineVector3Ref_UnityEngineQuaternionRef__SystemVoid(){} // RVA: 0x7FFACAE5B1E0
        public void __GetSiblingIndex__SystemInt32(){} // RVA: 0x7FFACAE5B370
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE5B490
        public void __GetWorldCorners__UnityEngineVector3Array__SystemVoid(){} // RVA: 0x7FFACAE5B580
        public void __InverseTransformDirection__SystemSingle_SystemSingle_SystemSingle__UnityEngineVector3(){} // RVA: 0x7FFACAE5B660
        public void __InverseTransformDirection__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACAE5B850
        public void __InverseTransformPoint__SystemSingle_SystemSingle_SystemSingle__UnityEngineVector3(){} // RVA: 0x7FFACAE5B9E0
        public void __InverseTransformPoint__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACAE5BBD0
        public void __InverseTransformVector__SystemSingle_SystemSingle_SystemSingle__UnityEngineVector3(){} // RVA: 0x7FFACAE5BD60
        public void __InverseTransformVector__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACAE5BF50
        public void __IsChildOf__UnityEngineTransform__SystemBoolean(){} // RVA: 0x7FFACAE5C0E0
        public void __LookAt__UnityEngineTransform_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE5C240
        public void __LookAt__UnityEngineTransform__SystemVoid(){} // RVA: 0x7FFACAE5C370
        public void __LookAt__UnityEngineVector3_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE5C460
        public void __LookAt__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE5C5E0
        public void __RotateAround__UnityEngineVector3_UnityEngineVector3_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE5C6D0
        public void __Rotate__SystemSingle_SystemSingle_SystemSingle_UnityEngineSpace__SystemVoid(){} // RVA: 0x7FFACAE5C870
        public void __Rotate__SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE5CA10
        public void __Rotate__UnityEngineVector3_SystemSingle_UnityEngineSpace__SystemVoid(){} // RVA: 0x7FFACAE5CB70
        public void __Rotate__UnityEngineVector3_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE5CCF0
        public void __Rotate__UnityEngineVector3_UnityEngineSpace__SystemVoid(){} // RVA: 0x7FFACAE5CE30
        public void __Rotate__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE5CF70
        public void __SetAsFirstSibling__SystemVoid(){} // RVA: 0x7FFACAE5D070
        public void __SetAsLastSibling__SystemVoid(){} // RVA: 0x7FFACAE5D160
        public void __SetInsetAndSizeFromParentEdge__UnityEngineRectTransformEdge_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE5D250
        public void __SetLocalPositionAndRotation__UnityEngineVector3_UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACAE5D3A0
        public void __SetParent__UnityEngineTransform_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE5D520
        public void __SetParent__UnityEngineTransform__SystemVoid(){} // RVA: 0x7FFACAE5D640
        public void __SetPositionAndRotation__UnityEngineVector3_UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACAE5D770
        public void __SetSiblingIndex__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE5D8F0
        public void __SetSizeWithCurrentAnchors__UnityEngineRectTransformAxis_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE5DA10
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE5DB30
        public void __TransformDirection__SystemSingle_SystemSingle_SystemSingle__UnityEngineVector3(){} // RVA: 0x7FFACAE5DC80
        public void __TransformDirection__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACAE5DE70
        public void __TransformPoint__SystemSingle_SystemSingle_SystemSingle__UnityEngineVector3(){} // RVA: 0x7FFACAE5E000
        public void __TransformPoint__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACAE5E1F0
        public void __TransformVector__SystemSingle_SystemSingle_SystemSingle__UnityEngineVector3(){} // RVA: 0x7FFACAE5E380
        public void __TransformVector__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACAE5E570
        public void __Translate__SystemSingle_SystemSingle_SystemSingle_UnityEngineSpace__SystemVoid(){} // RVA: 0x7FFACAE5E700
        public void __Translate__SystemSingle_SystemSingle_SystemSingle_UnityEngineTransform__SystemVoid(){} // RVA: 0x7FFACAE5E8A0
        public void __Translate__SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE5EA50
        public void __Translate__UnityEngineVector3_UnityEngineSpace__SystemVoid(){} // RVA: 0x7FFACAE5EBB0
        public void __Translate__UnityEngineVector3_UnityEngineTransform__SystemVoid(){} // RVA: 0x7FFACAE5ECF0
        public void __Translate__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE5EE30
        public void __get_anchorMax__UnityEngineVector2(){} // RVA: 0x7FFACAE5EF30
        public void __get_anchorMin__UnityEngineVector2(){} // RVA: 0x7FFACAE5F060
        public void __get_anchoredPosition3D__UnityEngineVector3(){} // RVA: 0x7FFACAE5F190
        public void __get_anchoredPosition__UnityEngineVector2(){} // RVA: 0x7FFACAE5F280
        public void __get_childCount__SystemInt32(){} // RVA: 0x7FFACAE5F3B0
        public void __get_drivenByObject__UnityEngineObject(){} // RVA: 0x7FFACAE5F4D0
        public void __get_eulerAngles__UnityEngineVector3(){} // RVA: 0x7FFACAE5F680
        public void __get_forward__UnityEngineVector3(){} // RVA: 0x7FFACAE5F7E0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACAE5F8D0
        public void __get_hasChanged__SystemBoolean(){} // RVA: 0x7FFACAE5FA10
        public void __get_hierarchyCapacity__SystemInt32(){} // RVA: 0x7FFACAE5FB30
        public void __get_hierarchyCount__SystemInt32(){} // RVA: 0x7FFACAE5FC50
        public void __get_localEulerAngles__UnityEngineVector3(){} // RVA: 0x7FFACAE5FD70
        public void __get_localPosition__UnityEngineVector3(){} // RVA: 0x7FFACAE5FED0
        public void __get_localRotation__UnityEngineQuaternion(){} // RVA: 0x7FFACAE60010
        public void __get_localScale__UnityEngineVector3(){} // RVA: 0x7FFACAE60150
        public void __get_localToWorldMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACAE60290
        public void __get_lossyScale__UnityEngineVector3(){} // RVA: 0x7FFACAE60410
        public void __get_name__SystemString(){} // RVA: 0x7FFACAE60550
        public void __get_offsetMax__UnityEngineVector2(){} // RVA: 0x7FFACAE606A0
        public void __get_offsetMin__UnityEngineVector2(){} // RVA: 0x7FFACAE60780
        public void __get_parent__UnityEngineTransform(){} // RVA: 0x7FFACAE60860
        public void __get_pivot__UnityEngineVector2(){} // RVA: 0x7FFACAE60990
        public void __get_position__UnityEngineVector3(){} // RVA: 0x7FFACAE60AC0
        public void __get_rect__UnityEngineRect(){} // RVA: 0x7FFACAE60C00
        public void __get_right__UnityEngineVector3(){} // RVA: 0x7FFACAE60D40
        public void __get_root__UnityEngineTransform(){} // RVA: 0x7FFACAE60E30
        public void __get_rotation__UnityEngineQuaternion(){} // RVA: 0x7FFACAE60F60
        public void __get_sizeDelta__UnityEngineVector2(){} // RVA: 0x7FFACAE610A0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAE611D0
        public void __get_up__UnityEngineVector3(){} // RVA: 0x7FFACAE61310
        public void __get_worldToLocalMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACAE61400
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAE61580
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAE61880
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAE61A70
        public void __set_anchorMax__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE61D70
        public void __set_anchorMin__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE61E90
        public void __set_anchoredPosition3D__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE61FB0
        public void __set_anchoredPosition__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE620A0
        public void __set_eulerAngles__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE621C0
        public void __set_forward__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE622B0
        public void __set_hasChanged__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE623A0
        public void __set_hierarchyCapacity__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE624D0
        public void __set_localEulerAngles__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE625F0
        public void __set_localPosition__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE626E0
        public void __set_localRotation__UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACAE62820
        public void __set_localScale__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE62950
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAE62A90
        public void __set_offsetMax__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE62BE0
        public void __set_offsetMin__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE62CC0
        public void __set_parent__UnityEngineTransform__SystemVoid(){} // RVA: 0x7FFACAE62DA0
        public void __set_pivot__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE62E90
        public void __set_position__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE62FB0
        public void __set_right__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE630F0
        public void __set_rotation__UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACAE631E0
        public void __set_sizeDelta__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE63310
        public void __set_up__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE63430
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACAE63520
    }

    public class ExternUnityEngineRectTransformArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE69DC0
        public void .ctor(){} // RVA: 0x7FFACAE69E00
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE6A1D0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE6A300
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAE6A410
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE6A4F0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE6A5D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE6A6A0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAE6A7F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE6A890
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE6A990
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAE6AAB0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE6ABC0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE6ACE0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE6ADD0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAE6AEB0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE6AFD0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE6B160
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAE6B2B0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAE6B3E0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE6B500
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE6B670
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAE6B7B0
        public void __Get__SystemInt32__UnityEngineRectTransform(){} // RVA: 0x7FFACAE6B8D0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAE6BA10
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAE6BA80
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE6BBA0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE6BD20
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE6BE80
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAE6BFB0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE6C0D0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE6C230
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE6C380
        public void __Set__SystemInt32_UnityEngineRectTransform__SystemVoid(){} // RVA: 0x7FFACAE6C4A0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE6C630
        public void __ctor__SystemInt32__UnityEngineRectTransformArray(){} // RVA: 0x7FFACAE6C720
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAE6C810
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAE6C8B0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAE6C950
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAE6C9F0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAE6CA90
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAE6CB30
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAE6CBD0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE6CCB0
    }

    public class ExternUnityEngineReflectionProbe : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE6EBD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACAE6EC10
        public void .ctor(){} // RVA: 0x7FFACAE6ECC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE6F090
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE6F1C0
        public void __BlendCubemap__UnityEngineTexture_UnityEngineTexture_SystemSingle_UnityEngineRenderTexture__SystemBoolean(){} // RVA: 0x7FFACAE6F2D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE6F500
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAE6F6D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAE6F7C0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAE6FA70
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE6FBD0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACAE6FCF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACAE6FDE0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAE70060
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAE70150
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAE70400
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE70560
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACAE70680
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACAE70770
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACAE709F0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE70B60
        public void __GetComponent__T(){} // RVA: 0x7FFACAE70C80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACAE70D60
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAE70FB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAE710A0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE713D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE714C0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAE71800
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAE718F0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAE71C00
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE71D70
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAE71EA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAE71F90
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE72280
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE72370
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAE726B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAE727A0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAE72AB0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE72C20
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACAE72D60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACAE72E50
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAE73140
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAE73230
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAE73520
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE73670
        public void __GetComponents__TArray(){} // RVA: 0x7FFACAE737A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACAE73890
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE73B40
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAE73CA0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE73DF0
        public void __IsFinishedRendering__SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAE73EE0
        public void __RenderProbe__SystemInt32(){} // RVA: 0x7FFACAE74040
        public void __RenderProbe__UnityEngineRenderTexture__SystemInt32(){} // RVA: 0x7FFACAE74120
        public void __Reset__SystemVoid(){} // RVA: 0x7FFACAE74260
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE74350
        public void __UpdateCachedState__SystemVoid(){} // RVA: 0x7FFACAE744A0
        public void __get_backgroundColor__UnityEngineColor(){} // RVA: 0x7FFACAE74520
        public void __get_bakedTexture__UnityEngineTexture(){} // RVA: 0x7FFACAE74660
        public void __get_blendDistance__SystemSingle(){} // RVA: 0x7FFACAE747A0
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACAE748C0
        public void __get_boxProjection__SystemBoolean(){} // RVA: 0x7FFACAE74A10
        public void __get_center__UnityEngineVector3(){} // RVA: 0x7FFACAE74B30
        public void __get_clearFlags__UnityEngineRenderingReflectionProbeClearFlags(){} // RVA: 0x7FFACAE74C70
        public void __get_cullingMask__SystemInt32(){} // RVA: 0x7FFACAE74D90
        public void __get_customBakedTexture__UnityEngineTexture(){} // RVA: 0x7FFACAE74EB0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAE74FF0
        public void __get_farClipPlane__SystemSingle(){} // RVA: 0x7FFACAE75110
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACAE75230
        public void __get_hdr__SystemBoolean(){} // RVA: 0x7FFACAE75370
        public void __get_importance__SystemInt32(){} // RVA: 0x7FFACAE75490
        public void __get_intensity__SystemSingle(){} // RVA: 0x7FFACAE755B0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACAE756D0
        public void __get_maxBakedCubemapResolution__SystemInt32(){} // RVA: 0x7FFACAE757F0
        public void __get_minBakedCubemapResolution__SystemInt32(){} // RVA: 0x7FFACAE758C0
        public void __get_mode__UnityEngineRenderingReflectionProbeMode(){} // RVA: 0x7FFACAE75990
        public void __get_name__SystemString(){} // RVA: 0x7FFACAE75AB0
        public void __get_nearClipPlane__SystemSingle(){} // RVA: 0x7FFACAE75C00
        public void __get_realtimeTexture__UnityEngineRenderTexture(){} // RVA: 0x7FFACAE75D20
        public void __get_refreshMode__UnityEngineRenderingReflectionProbeRefreshMode(){} // RVA: 0x7FFACAE75E60
        public void __get_renderDynamicObjects__SystemBoolean(){} // RVA: 0x7FFACAE75F80
        public void __get_resolution__SystemInt32(){} // RVA: 0x7FFACAE760A0
        public void __get_shadowDistance__SystemSingle(){} // RVA: 0x7FFACAE761C0
        public void __get_size__UnityEngineVector3(){} // RVA: 0x7FFACAE762E0
        public void __get_textureHDRDecodeValues__UnityEngineVector4(){} // RVA: 0x7FFACAE76420
        public void __get_texture__UnityEngineTexture(){} // RVA: 0x7FFACAE76560
        public void __get_timeSlicingMode__UnityEngineRenderingReflectionProbeTimeSlicingMode(){} // RVA: 0x7FFACAE766A0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAE767C0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAE76900
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAE76C00
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAE76DF0
        public void __set_backgroundColor__UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACAE770F0
        public void __set_bakedTexture__UnityEngineTexture__SystemVoid(){} // RVA: 0x7FFACAE77220
        public void __set_blendDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE77370
        public void __set_boxProjection__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE774A0
        public void __set_center__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE775D0
        public void __set_clearFlags__UnityEngineRenderingReflectionProbeClearFlags__SystemVoid(){} // RVA: 0x7FFACAE77710
        public void __set_cullingMask__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE77830
        public void __set_customBakedTexture__UnityEngineTexture__SystemVoid(){} // RVA: 0x7FFACAE77950
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE77AA0
        public void __set_farClipPlane__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE77BD0
        public void __set_hdr__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE77D00
        public void __set_importance__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE77E30
        public void __set_intensity__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE77F50
        public void __set_mode__UnityEngineRenderingReflectionProbeMode__SystemVoid(){} // RVA: 0x7FFACAE78080
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAE781A0
        public void __set_nearClipPlane__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE782F0
        public void __set_realtimeTexture__UnityEngineRenderTexture__SystemVoid(){} // RVA: 0x7FFACAE78420
        public void __set_refreshMode__UnityEngineRenderingReflectionProbeRefreshMode__SystemVoid(){} // RVA: 0x7FFACAE78570
        public void __set_renderDynamicObjects__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE78690
        public void __set_resolution__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE787C0
        public void __set_shadowDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE788E0
        public void __set_size__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAE78A10
        public void __set_timeSlicingMode__UnityEngineRenderingReflectionProbeTimeSlicingMode__SystemVoid(){} // RVA: 0x7FFACAE78B50
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACAE78C70
    }

    public class ExternUnityEngineReflectionProbeArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE7D4D0
        public void .ctor(){} // RVA: 0x7FFACAE7D510
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE7D8E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE7DA10
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAE7DB20
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE7DC00
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE7DCE0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE7DDB0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAE7DF00
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE7DFA0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE7E0A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAE7E1C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE7E2D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE7E3F0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE7E4E0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAE7E5C0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE7E6E0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE7E870
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAE7E9C0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAE7EAF0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE7EC10
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE7ED80
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAE7EEC0
        public void __Get__SystemInt32__UnityEngineReflectionProbe(){} // RVA: 0x7FFACAE7EFE0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAE7F120
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAE7F190
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE7F2B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE7F430
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE7F590
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAE7F6C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE7F7E0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE7F940
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE7FA90
        public void __Set__SystemInt32_UnityEngineReflectionProbe__SystemVoid(){} // RVA: 0x7FFACAE7FBB0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE7FD40
        public void __ctor__SystemInt32__UnityEngineReflectionProbeArray(){} // RVA: 0x7FFACAE7FE30
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAE7FF20
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAE7FFC0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAE80060
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAE80100
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAE801A0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAE80240
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAE802E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE803C0
    }

    public class ExternUnityEngineRelativeJoint2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE822E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACAE82320
        public void .ctor(){} // RVA: 0x7FFACAE823D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE827A0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE828D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE829E0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAE82BB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAE82CA0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAE82F50
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE830B0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACAE831D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACAE832C0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAE83540
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAE83630
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAE838E0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE83A40
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACAE83B60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACAE83C50
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACAE83ED0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE84040
        public void __GetComponent__T(){} // RVA: 0x7FFACAE84160
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACAE84240
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAE84490
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAE84580
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE848B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE849A0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAE84CE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAE84DD0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAE850E0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE85250
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAE85380
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAE85470
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE85760
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE85850
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAE85B90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAE85C80
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAE85F90
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE86100
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACAE86240
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACAE86330
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAE86620
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAE86710
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAE86A00
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE86B50
        public void __GetComponents__TArray(){} // RVA: 0x7FFACAE86C80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACAE86D70
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE87020
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAE87180
        public void __GetReactionForce__SystemSingle__UnityEngineVector2(){} // RVA: 0x7FFACAE872D0
        public void __GetReactionTorque__SystemSingle__SystemSingle(){} // RVA: 0x7FFACAE873E0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE87540
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE87630
        public void __get_angularOffset__SystemSingle(){} // RVA: 0x7FFACAE87780
        public void __get_attachedRigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACAE878A0
        public void __get_autoConfigureOffset__SystemBoolean(){} // RVA: 0x7FFACAE879E0
        public void __get_breakAction__UnityEngineJointBreakAction2D(){} // RVA: 0x7FFACAE87B00
        public void __get_breakForce__SystemSingle(){} // RVA: 0x7FFACAE87C20
        public void __get_breakTorque__SystemSingle(){} // RVA: 0x7FFACAE87D40
        public void __get_connectedBody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACAE87E60
        public void __get_correctionScale__SystemSingle(){} // RVA: 0x7FFACAE87FA0
        public void __get_enableCollision__SystemBoolean(){} // RVA: 0x7FFACAE880C0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAE881E0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACAE88300
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACAE88440
        public void __get_linearOffset__UnityEngineVector2(){} // RVA: 0x7FFACAE88560
        public void __get_maxForce__SystemSingle(){} // RVA: 0x7FFACAE88690
        public void __get_maxTorque__SystemSingle(){} // RVA: 0x7FFACAE887B0
        public void __get_name__SystemString(){} // RVA: 0x7FFACAE888D0
        public void __get_reactionForce__UnityEngineVector2(){} // RVA: 0x7FFACAE88A20
        public void __get_reactionTorque__SystemSingle(){} // RVA: 0x7FFACAE88B50
        public void __get_target__UnityEngineVector2(){} // RVA: 0x7FFACAE88C70
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAE88DA0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAE88EE0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAE891E0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAE893D0
        public void __set_angularOffset__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE896D0
        public void __set_autoConfigureOffset__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE89800
        public void __set_breakAction__UnityEngineJointBreakAction2D__SystemVoid(){} // RVA: 0x7FFACAE89930
        public void __set_breakForce__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE89A50
        public void __set_breakTorque__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE89B80
        public void __set_connectedBody__UnityEngineRigidbody2D__SystemVoid(){} // RVA: 0x7FFACAE89CB0
        public void __set_correctionScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE89E00
        public void __set_enableCollision__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE89F30
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAE8A060
        public void __set_linearOffset__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAE8A190
        public void __set_maxForce__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE8A2B0
        public void __set_maxTorque__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAE8A3E0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAE8A510
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACAE8A660
    }

    public class ExternUnityEngineRelativeJoint2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE8DC00
        public void .ctor(){} // RVA: 0x7FFACAE8DC40
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE8E010
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE8E140
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAE8E250
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE8E330
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE8E410
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE8E4E0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAE8E630
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE8E6D0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE8E7D0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAE8E8F0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE8EA00
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE8EB20
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE8EC10
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAE8ECF0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE8EE10
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE8EFA0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAE8F0F0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAE8F220
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE8F340
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE8F4B0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAE8F5F0
        public void __Get__SystemInt32__UnityEngineRelativeJoint2D(){} // RVA: 0x7FFACAE8F710
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAE8F850
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAE8F8C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE8F9E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE8FB60
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE8FCC0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAE8FDF0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE8FF10
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE90070
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE901C0
        public void __Set__SystemInt32_UnityEngineRelativeJoint2D__SystemVoid(){} // RVA: 0x7FFACAE902E0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE90470
        public void __ctor__SystemInt32__UnityEngineRelativeJoint2DArray(){} // RVA: 0x7FFACAE90560
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAE90650
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAE906F0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAE90790
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAE90830
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAE908D0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAE90970
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAE90A10
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE90AF0
    }

    public class ExternUnityEngineRenderBuffer : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE92A10
        public void .ctor(){} // RVA: 0x7FFACAE92A50
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE92E20
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE92F50
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE93060
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE931A0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE93250
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE93340
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE933F0
    }

    public class ExternUnityEngineRenderBufferArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE938C0
        public void .ctor(){} // RVA: 0x7FFACAE93900
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE93CD0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE93E00
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAE93F10
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE93FF0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE940D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE941A0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAE942F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE94390
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE94490
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAE945B0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE946C0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE947E0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAE948D0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAE949B0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE94AD0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAE94C60
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAE94DB0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAE94EE0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE95000
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAE95170
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAE952B0
        public void __Get__SystemInt32__UnityEngineRenderBuffer(){} // RVA: 0x7FFACAE953D0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAE954C0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAE95530
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE95650
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE957D0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE95930
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAE95A60
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE95B80
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE95CE0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAE95E30
        public void __Set__SystemInt32_UnityEngineRenderBuffer__SystemVoid(){} // RVA: 0x7FFACAE95F50
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE96040
        public void __ctor__SystemInt32__UnityEngineRenderBufferArray(){} // RVA: 0x7FFACAE96130
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAE962D0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAE96370
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAE96410
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAE964B0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAE96550
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAE965F0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAE96690
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAE96770
    }

    public class ExternUnityEngineRenderSettings : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAEC4870
        public void .ctor(){} // RVA: 0x7FFACAEC48B0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAEC4C80
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAEC4DB0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAEC4EC0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAEC5090
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAEC51F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAEC5340
        public void __ToString__SystemString(){} // RVA: 0x7FFACAEC5430
        public void __get_ambientEquatorColor__UnityEngineColor(){} // RVA: 0x7FFACAEC5580
        public void __get_ambientGroundColor__UnityEngineColor(){} // RVA: 0x7FFACAEC5640
        public void __get_ambientIntensity__SystemSingle(){} // RVA: 0x7FFACAEC5700
        public void __get_ambientLight__UnityEngineColor(){} // RVA: 0x7FFACAEC57B0
        public void __get_ambientMode__UnityEngineRenderingAmbientMode(){} // RVA: 0x7FFACAEC5870
        public void __get_ambientProbe__UnityEngineRenderingSphericalHarmonicsL2(){} // RVA: 0x7FFACAEC5920
        public void __get_ambientSkyColor__UnityEngineColor(){} // RVA: 0x7FFACAEC5A50
        public void __get_customReflectionTexture__UnityEngineTexture(){} // RVA: 0x7FFACAEC5B10
        public void __get_defaultReflectionMode__UnityEngineRenderingDefaultReflectionMode(){} // RVA: 0x7FFACAEC5BF0
        public void __get_defaultReflectionResolution__SystemInt32(){} // RVA: 0x7FFACAEC5CA0
        public void __get_flareFadeSpeed__SystemSingle(){} // RVA: 0x7FFACAEC5D50
        public void __get_flareStrength__SystemSingle(){} // RVA: 0x7FFACAEC5E00
        public void __get_fogColor__UnityEngineColor(){} // RVA: 0x7FFACAEC5EB0
        public void __get_fogDensity__SystemSingle(){} // RVA: 0x7FFACAEC5F70
        public void __get_fogEndDistance__SystemSingle(){} // RVA: 0x7FFACAEC6020
        public void __get_fogMode__UnityEngineFogMode(){} // RVA: 0x7FFACAEC60D0
        public void __get_fogStartDistance__SystemSingle(){} // RVA: 0x7FFACAEC6180
        public void __get_fog__SystemBoolean(){} // RVA: 0x7FFACAEC6230
        public void __get_haloStrength__SystemSingle(){} // RVA: 0x7FFACAEC62E0
        public void __get_name__SystemString(){} // RVA: 0x7FFACAEC6390
        public void __get_reflectionBounces__SystemInt32(){} // RVA: 0x7FFACAEC64E0
        public void __get_reflectionIntensity__SystemSingle(){} // RVA: 0x7FFACAEC6590
        public void __get_skybox__UnityEngineMaterial(){} // RVA: 0x7FFACAEC6640
        public void __get_subtractiveShadowColor__UnityEngineColor(){} // RVA: 0x7FFACAEC6720
        public void __get_sun__UnityEngineLight(){} // RVA: 0x7FFACAEC67E0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAEC68C0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAEC6BC0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAEC6DB0
        public void __set_ambientEquatorColor__UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACAEC70B0
        public void __set_ambientGroundColor__UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACAEC7160
        public void __set_ambientIntensity__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEC7210
        public void __set_ambientLight__UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACAEC72D0
        public void __set_ambientMode__UnityEngineRenderingAmbientMode__SystemVoid(){} // RVA: 0x7FFACAEC7380
        public void __set_ambientProbe__UnityEngineRenderingSphericalHarmonicsL2__SystemVoid(){} // RVA: 0x7FFACAEC7430
        public void __set_ambientSkyColor__UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACAEC7540
        public void __set_customReflectionTexture__UnityEngineTexture__SystemVoid(){} // RVA: 0x7FFACAEC75F0
        public void __set_defaultReflectionMode__UnityEngineRenderingDefaultReflectionMode__SystemVoid(){} // RVA: 0x7FFACAEC76D0
        public void __set_defaultReflectionResolution__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEC7780
        public void __set_flareFadeSpeed__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEC7830
        public void __set_flareStrength__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEC78F0
        public void __set_fogColor__UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACAEC79B0
        public void __set_fogDensity__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEC7A60
        public void __set_fogEndDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEC7B20
        public void __set_fogMode__UnityEngineFogMode__SystemVoid(){} // RVA: 0x7FFACAEC7BE0
        public void __set_fogStartDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEC7C90
        public void __set_fog__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEC7D50
        public void __set_haloStrength__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEC7E00
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAEC7EC0
        public void __set_reflectionBounces__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEC8010
        public void __set_reflectionIntensity__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEC80C0
        public void __set_skybox__UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACAEC8180
        public void __set_subtractiveShadowColor__UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACAEC8260
        public void __set_sun__UnityEngineLight__SystemVoid(){} // RVA: 0x7FFACAEC8310
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAEC83F0
    }

    public class ExternUnityEngineRenderTexture : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAECB150
        public void .ctor(){} // RVA: 0x7FFACAECB190
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAECB560
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAECB690
        public void __ConvertToEquirect__UnityEngineRenderTexture_UnityEngineCameraMonoOrStereoscopicEye__SystemVoid(){} // RVA: 0x7FFACAECB7A0
        public void __Create__SystemBoolean(){} // RVA: 0x7FFACAECB8C0
        public void __DiscardContents__SystemBoolean_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAECB9E0
        public void __DiscardContents__SystemVoid(){} // RVA: 0x7FFACAECBAF0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAECBBE0
        public void __GenerateMips__SystemVoid(){} // RVA: 0x7FFACAECBDB0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAECBEA0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAECC000
        public void __GetType__SystemType(){} // RVA: 0x7FFACAECC150
        public void __IncrementUpdateCount__SystemVoid(){} // RVA: 0x7FFACAECC240
        public void __IsCreated__SystemBoolean(){} // RVA: 0x7FFACAECC330
        public void __Release__SystemVoid(){} // RVA: 0x7FFACAECC450
        public void __ResolveAntiAliasedSurface__SystemVoid(){} // RVA: 0x7FFACAECC540
        public void __ResolveAntiAliasedSurface__UnityEngineRenderTexture__SystemVoid(){} // RVA: 0x7FFACAECC630
        public void __SupportsStencil__UnityEngineRenderTexture__SystemBoolean(){} // RVA: 0x7FFACAECC760
        public void __ToString__SystemString(){} // RVA: 0x7FFACAECC880
        public void __ctor__SystemInt32_SystemInt32_SystemInt32_UnityEngineRenderTextureFormat_SystemInt32__UnityEngineRenderTexture(){} // RVA: 0x7FFACAECC9D0
        public void __ctor__SystemInt32_SystemInt32_SystemInt32_UnityEngineRenderTextureFormat_UnityEngineRenderTextureReadWrite__UnityEngineRenderTexture(){} // RVA: 0x7FFACAECCBC0
        public void __ctor__SystemInt32_SystemInt32_SystemInt32_UnityEngineRenderTextureFormat__UnityEngineRenderTexture(){} // RVA: 0x7FFACAECCDD0
        public void __ctor__SystemInt32_SystemInt32_SystemInt32__UnityEngineRenderTexture(){} // RVA: 0x7FFACAECCF80
        public void __ctor__UnityEngineRenderTextureDescriptor__UnityEngineRenderTexture(){} // RVA: 0x7FFACAECD100
        public void __ctor__UnityEngineRenderTexture__UnityEngineRenderTexture(){} // RVA: 0x7FFACAECD270
        public void __get_anisoLevel__SystemInt32(){} // RVA: 0x7FFACAECD390
        public void __get_antiAliasing__SystemInt32(){} // RVA: 0x7FFACAECD4B0
        public void __get_autoGenerateMips__SystemBoolean(){} // RVA: 0x7FFACAECD5D0
        public void __get_bindTextureMS__SystemBoolean(){} // RVA: 0x7FFACAECD6F0
        public void __get_colorBuffer__UnityEngineRenderBuffer(){} // RVA: 0x7FFACAECD810
        public void __get_depthBuffer__UnityEngineRenderBuffer(){} // RVA: 0x7FFACAECD950
        public void __get_depth__SystemInt32(){} // RVA: 0x7FFACAECDA90
        public void __get_descriptor__UnityEngineRenderTextureDescriptor(){} // RVA: 0x7FFACAECDBB0
        public void __get_dimension__UnityEngineRenderingTextureDimension(){} // RVA: 0x7FFACAECDCD0
        public void __get_enableRandomWrite__SystemBoolean(){} // RVA: 0x7FFACAECDDC0
        public void __get_filterMode__UnityEngineFilterMode(){} // RVA: 0x7FFACAECDEE0
        public void __get_format__UnityEngineRenderTextureFormat(){} // RVA: 0x7FFACAECE000
        public void __get_height__SystemInt32(){} // RVA: 0x7FFACAECE0E0
        public void __get_isDataSRGB__SystemBoolean(){} // RVA: 0x7FFACAECE1D0
        public void __get_isPowerOfTwo__SystemBoolean(){} // RVA: 0x7FFACAECE300
        public void __get_isReadable__SystemBoolean(){} // RVA: 0x7FFACAECE420
        public void __get_mipMapBias__SystemSingle(){} // RVA: 0x7FFACAECE510
        public void __get_mipmapCount__SystemInt32(){} // RVA: 0x7FFACAECE630
        public void __get_name__SystemString(){} // RVA: 0x7FFACAECE750
        public void __get_sRGB__SystemBoolean(){} // RVA: 0x7FFACAECE8A0
        public void __get_texelSize__UnityEngineVector2(){} // RVA: 0x7FFACAECE9C0
        public void __get_updateCount__SystemUInt32(){} // RVA: 0x7FFACAECEAF0
        public void __get_useDynamicScale__SystemBoolean(){} // RVA: 0x7FFACAECEC10
        public void __get_useMipMap__SystemBoolean(){} // RVA: 0x7FFACAECED30
        public void __get_volumeDepth__SystemInt32(){} // RVA: 0x7FFACAECEE50
        public void __get_vrUsage__UnityEngineVRTextureUsage(){} // RVA: 0x7FFACAECEF70
        public void __get_width__SystemInt32(){} // RVA: 0x7FFACAECF090
        public void __get_wrapModeU__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACAECF180
        public void __get_wrapModeV__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACAECF2A0
        public void __get_wrapModeW__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACAECF3C0
        public void __get_wrapMode__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACAECF4E0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAECF600
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAECF900
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAECFAF0
        public void __set_anisoLevel__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAECFDF0
        public void __set_antiAliasing__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAECFF10
        public void __set_autoGenerateMips__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAED0030
        public void __set_bindTextureMS__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAED0160
        public void __set_depth__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAED0290
        public void __set_descriptor__UnityEngineRenderTextureDescriptor__SystemVoid(){} // RVA: 0x7FFACAED03B0
        public void __set_dimension__UnityEngineRenderingTextureDimension__SystemVoid(){} // RVA: 0x7FFACAED04D0
        public void __set_enableRandomWrite__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAED05C0
        public void __set_filterMode__UnityEngineFilterMode__SystemVoid(){} // RVA: 0x7FFACAED06F0
        public void __set_format__UnityEngineRenderTextureFormat__SystemVoid(){} // RVA: 0x7FFACAED0810
        public void __set_height__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAED08F0
        public void __set_isPowerOfTwo__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAED09E0
        public void __set_mipMapBias__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAED0AB0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAED0BE0
        public void __set_useDynamicScale__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAED0D30
        public void __set_useMipMap__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAED0E60
        public void __set_volumeDepth__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAED0F90
        public void __set_vrUsage__UnityEngineVRTextureUsage__SystemVoid(){} // RVA: 0x7FFACAED10B0
        public void __set_width__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAED11D0
        public void __set_wrapModeU__UnityEngineTextureWrapMode__SystemVoid(){} // RVA: 0x7FFACAED12C0
        public void __set_wrapModeV__UnityEngineTextureWrapMode__SystemVoid(){} // RVA: 0x7FFACAED13E0
        public void __set_wrapModeW__UnityEngineTextureWrapMode__SystemVoid(){} // RVA: 0x7FFACAED1500
        public void __set_wrapMode__UnityEngineTextureWrapMode__SystemVoid(){} // RVA: 0x7FFACAED1620
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAED1740
    }

    public class ExternUnityEngineRenderTextureArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAED5460
        public void .ctor(){} // RVA: 0x7FFACAED54A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAED5870
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAED59A0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAED5AB0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAED5B90
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAED5C70
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAED5D40
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAED5E90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAED5F30
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAED6030
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAED6150
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAED6260
        public void __GetType__SystemType(){} // RVA: 0x7FFACAED6380
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAED6470
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAED6550
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAED6670
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAED6800
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAED6950
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAED6A80
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAED6BA0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAED6D10
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAED6E50
        public void __Get__SystemInt32__UnityEngineRenderTexture(){} // RVA: 0x7FFACAED6F70
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAED70B0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAED7120
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAED7240
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAED73C0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAED7520
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAED7650
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAED7770
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAED78D0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAED7A20
        public void __Set__SystemInt32_UnityEngineRenderTexture__SystemVoid(){} // RVA: 0x7FFACAED7B40
        public void __ToString__SystemString(){} // RVA: 0x7FFACAED7CB0
        public void __ctor__SystemInt32__UnityEngineRenderTextureArray(){} // RVA: 0x7FFACAED7DA0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAED7F50
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAED7FF0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAED8090
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAED8130
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAED81D0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAED8270
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAED8310
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAED83F0
    }

    public class ExternUnityEngineRenderTextureDescriptor : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAEDA310
        public void .ctor(){} // RVA: 0x7FFACAEDA350
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAEDA720
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAEDA850
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAEDA960
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAEDAAA0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAEDAB50
        public void __ToString__SystemString(){} // RVA: 0x7FFACAEDAC40
        public void __ctor__SystemInt32_SystemInt32_UnityEngineRenderTextureFormat_SystemInt32_SystemInt32_UnityEngineRenderTextureReadWrite__UnityEngineRenderTextureDescriptor(){} // RVA: 0x7FFACAEDACF0
        public void __ctor__SystemInt32_SystemInt32_UnityEngineRenderTextureFormat_SystemInt32_SystemInt32__UnityEngineRenderTextureDescriptor(){} // RVA: 0x7FFACAEDAF20
        public void __ctor__SystemInt32_SystemInt32_UnityEngineRenderTextureFormat_SystemInt32__UnityEngineRenderTextureDescriptor(){} // RVA: 0x7FFACAEDB110
        public void __ctor__SystemInt32_SystemInt32_UnityEngineRenderTextureFormat__UnityEngineRenderTextureDescriptor(){} // RVA: 0x7FFACAEDB330
        public void __ctor__SystemInt32_SystemInt32__UnityEngineRenderTextureDescriptor(){} // RVA: 0x7FFACAEDB520
        public void __get_autoGenerateMips__SystemBoolean(){} // RVA: 0x7FFACAEDB6D0
        public void __get_bindMS__SystemBoolean(){} // RVA: 0x7FFACAEDB780
        public void __get_colorFormat__UnityEngineRenderTextureFormat(){} // RVA: 0x7FFACAEDB840
        public void __get_depthBufferBits__SystemInt32(){} // RVA: 0x7FFACAEDB9C0
        public void __get_dimension__UnityEngineRenderingTextureDimension(){} // RVA: 0x7FFACAEDBAF0
        public void __get_enableRandomWrite__SystemBoolean(){} // RVA: 0x7FFACAEDBBA0
        public void __get_flags__UnityEngineRenderTextureCreationFlags(){} // RVA: 0x7FFACAEDBC50
        public void __get_height__SystemInt32(){} // RVA: 0x7FFACAEDBD00
        public void __get_memoryless__UnityEngineRenderTextureMemoryless(){} // RVA: 0x7FFACAEDBDB0
        public void __get_mipCount__SystemInt32(){} // RVA: 0x7FFACAEDBE50
        public void __get_msaaSamples__SystemInt32(){} // RVA: 0x7FFACAEDBF00
        public void __get_sRGB__SystemBoolean(){} // RVA: 0x7FFACAEDBFB0
        public void __get_shadowSamplingMode__UnityEngineRenderingShadowSamplingMode(){} // RVA: 0x7FFACAEDC0F0
        public void __get_useDynamicScale__SystemBoolean(){} // RVA: 0x7FFACAEDC1A0
        public void __get_useMipMap__SystemBoolean(){} // RVA: 0x7FFACAEDC260
        public void __get_volumeDepth__SystemInt32(){} // RVA: 0x7FFACAEDC310
        public void __get_vrUsage__UnityEngineVRTextureUsage(){} // RVA: 0x7FFACAEDC3C0
        public void __get_width__SystemInt32(){} // RVA: 0x7FFACAEDC470
        public void __set_autoGenerateMips__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEDC520
        public void __set_bindMS__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEDC670
        public void __set_colorFormat__UnityEngineRenderTextureFormat__SystemVoid(){} // RVA: 0x7FFACAEDC7C0
        public void __set_depthBufferBits__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEDC8F0
        public void __set_dimension__UnityEngineRenderingTextureDimension__SystemVoid(){} // RVA: 0x7FFACAEDCA30
        public void __set_enableRandomWrite__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEDCB60
        public void __set_height__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEDCCB0
        public void __set_memoryless__UnityEngineRenderTextureMemoryless__SystemVoid(){} // RVA: 0x7FFACAEDCDE0
        public void __set_mipCount__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEDCF00
        public void __set_msaaSamples__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEDD030
        public void __set_sRGB__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEDD160
        public void __set_shadowSamplingMode__UnityEngineRenderingShadowSamplingMode__SystemVoid(){} // RVA: 0x7FFACAEDD290
        public void __set_useDynamicScale__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEDD3C0
        public void __set_useMipMap__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEDD510
        public void __set_volumeDepth__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEDD660
        public void __set_vrUsage__UnityEngineVRTextureUsage__SystemVoid(){} // RVA: 0x7FFACAEDD790
        public void __set_width__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEDD8C0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAEDD9F0
    }

    public class ExternUnityEngineRenderTextureDescriptorArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAEDFCD0
        public void .ctor(){} // RVA: 0x7FFACAEDFD10
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAEE00E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAEE0210
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAEE0320
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEE0400
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEE04E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAEE05B0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAEE0700
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAEE07A0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAEE08A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAEE09C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAEE0AD0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAEE0BF0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAEE0CE0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAEE0DC0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAEE0EE0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAEE1070
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAEE11C0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAEE12F0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAEE1410
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAEE1580
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAEE16C0
        public void __Get__SystemInt32__UnityEngineRenderTextureDescriptor(){} // RVA: 0x7FFACAEE17E0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAEE18F0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAEE1960
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEE1A80
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEE1C00
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEE1D60
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAEE1E90
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEE1FB0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEE2110
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEE2260
        public void __Set__SystemInt32_UnityEngineRenderTextureDescriptor__SystemVoid(){} // RVA: 0x7FFACAEE2380
        public void __ToString__SystemString(){} // RVA: 0x7FFACAEE2490
        public void __ctor__SystemInt32__UnityEngineRenderTextureDescriptorArray(){} // RVA: 0x7FFACAEE2580
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAEE2720
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAEE27C0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAEE2860
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAEE2900
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAEE29A0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAEE2A40
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAEE2AE0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAEE2BC0
    }

    public class ExternUnityEngineRenderer : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAE98690
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACAE986D0
        public void .ctor(){} // RVA: 0x7FFACAE98780
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAE98B50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAE98C80
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAE98D90
        public void __GetClosestReflectionProbes__SystemCollectionsGenericListUnityEngineRenderingReflectionProbeBlendInfo__SystemVoid(){} // RVA: 0x7FFACAE98F60
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAE99080
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAE99170
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAE99420
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE99580
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACAE996A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACAE99790
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAE99A10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAE99B00
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAE99DB0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE99F10
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACAE9A030
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACAE9A120
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACAE9A3A0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAE9A510
        public void __GetComponent__T(){} // RVA: 0x7FFACAE9A630
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACAE9A710
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAE9A960
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAE9AA50
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE9AD80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE9AE70
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAE9B1B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAE9B2A0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAE9B5B0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE9B720
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAE9B850
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAE9B940
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE9BC30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAE9BD20
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAE9C060
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAE9C150
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAE9C460
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE9C5D0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACAE9C710
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACAE9C800
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAE9CAF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAE9CBE0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAE9CED0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAE9D020
        public void __GetComponents__TArray(){} // RVA: 0x7FFACAE9D150
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACAE9D240
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAE9D4F0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAE9D650
        public void __GetMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACAE9D7A0
        public void __GetPropertyBlock__UnityEngineMaterialPropertyBlock_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE9D8C0
        public void __GetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(){} // RVA: 0x7FFACAE9D9D0
        public void __GetSharedMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACAE9DAF0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAE9DC10
        public void __HasPropertyBlock__SystemBoolean(){} // RVA: 0x7FFACAE9DD00
        public void __ResetBounds__SystemVoid(){} // RVA: 0x7FFACAE9DE20
        public void __ResetLocalBounds__SystemVoid(){} // RVA: 0x7FFACAE9DF10
        public void __SetMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACAE9E000
        public void __SetPropertyBlock__UnityEngineMaterialPropertyBlock_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAE9E1D0
        public void __SetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(){} // RVA: 0x7FFACAE9E2E0
        public void __SetSharedMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACAE9E400
        public void __ToString__SystemString(){} // RVA: 0x7FFACAE9E5D0
        public void __get_allowOcclusionWhenDynamic__SystemBoolean(){} // RVA: 0x7FFACAE9E720
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACAE9E840
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAE9E990
        public void __get_forceRenderingOff__SystemBoolean(){} // RVA: 0x7FFACAE9EAB0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACAE9EBD0
        public void __get_isPartOfStaticBatch__SystemBoolean(){} // RVA: 0x7FFACAE9ED10
        public void __get_isVisible__SystemBoolean(){} // RVA: 0x7FFACAE9EE30
        public void __get_lightProbeProxyVolumeOverride__UnityEngineGameObject(){} // RVA: 0x7FFACAE9EF50
        public void __get_lightProbeUsage__UnityEngineRenderingLightProbeUsage(){} // RVA: 0x7FFACAE9F090
        public void __get_lightmapIndex__SystemInt32(){} // RVA: 0x7FFACAE9F1B0
        public void __get_lightmapScaleOffset__UnityEngineVector4(){} // RVA: 0x7FFACAE9F2D0
        public void __get_localBounds__UnityEngineBounds(){} // RVA: 0x7FFACAE9F410
        public void __get_localToWorldMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACAE9F560
        public void __get_material__UnityEngineMaterial(){} // RVA: 0x7FFACAE9F6E0
        public void __get_materials__UnityEngineMaterialArray(){} // RVA: 0x7FFACAE9F820
        public void __get_motionVectorGenerationMode__UnityEngineMotionVectorGenerationMode(){} // RVA: 0x7FFACAE9F960
        public void __get_name__SystemString(){} // RVA: 0x7FFACAE9FA80
        public void __get_probeAnchor__UnityEngineTransform(){} // RVA: 0x7FFACAE9FBD0
        public void __get_realtimeLightmapIndex__SystemInt32(){} // RVA: 0x7FFACAE9FD10
        public void __get_realtimeLightmapScaleOffset__UnityEngineVector4(){} // RVA: 0x7FFACAE9FE40
        public void __get_receiveShadows__SystemBoolean(){} // RVA: 0x7FFACAE9FF80
        public void __get_reflectionProbeUsage__UnityEngineRenderingReflectionProbeUsage(){} // RVA: 0x7FFACAEA00A0
        public void __get_rendererPriority__SystemInt32(){} // RVA: 0x7FFACAEA01C0
        public void __get_renderingLayerMask__SystemUInt32(){} // RVA: 0x7FFACAEA02E0
        public void __get_shadowCastingMode__UnityEngineRenderingShadowCastingMode(){} // RVA: 0x7FFACAEA0400
        public void __get_sharedMaterial__UnityEngineMaterial(){} // RVA: 0x7FFACAEA0520
        public void __get_sharedMaterials__UnityEngineMaterialArray(){} // RVA: 0x7FFACAEA0660
        public void __get_sortingLayerID__SystemInt32(){} // RVA: 0x7FFACAEA07A0
        public void __get_sortingLayerName__SystemString(){} // RVA: 0x7FFACAEA08C0
        public void __get_sortingOrder__SystemInt32(){} // RVA: 0x7FFACAEA09E0
        public void __get_staticShadowCaster__SystemBoolean(){} // RVA: 0x7FFACAEA0B00
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAEA0C20
        public void __get_worldToLocalMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACAEA0D60
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAEA0EE0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAEA11E0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAEA13D0
        public void __set_allowOcclusionWhenDynamic__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEA16D0
        public void __set_bounds__UnityEngineBounds__SystemVoid(){} // RVA: 0x7FFACAEA1800
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEA1940
        public void __set_forceRenderingOff__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEA1A70
        public void __set_lightProbeProxyVolumeOverride__UnityEngineGameObject__SystemVoid(){} // RVA: 0x7FFACAEA1BA0
        public void __set_lightProbeUsage__UnityEngineRenderingLightProbeUsage__SystemVoid(){} // RVA: 0x7FFACAEA1CF0
        public void __set_lightmapIndex__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEA1E10
        public void __set_lightmapScaleOffset__UnityEngineVector4__SystemVoid(){} // RVA: 0x7FFACAEA1F40
        public void __set_localBounds__UnityEngineBounds__SystemVoid(){} // RVA: 0x7FFACAEA2070
        public void __set_material__UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACAEA21B0
        public void __set_materials__UnityEngineMaterialArray__SystemVoid(){} // RVA: 0x7FFACAEA2300
        public void __set_motionVectorGenerationMode__UnityEngineMotionVectorGenerationMode__SystemVoid(){} // RVA: 0x7FFACAEA2430
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAEA2550
        public void __set_probeAnchor__UnityEngineTransform__SystemVoid(){} // RVA: 0x7FFACAEA26A0
        public void __set_realtimeLightmapIndex__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEA27F0
        public void __set_realtimeLightmapScaleOffset__UnityEngineVector4__SystemVoid(){} // RVA: 0x7FFACAEA2920
        public void __set_receiveShadows__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEA2A50
        public void __set_reflectionProbeUsage__UnityEngineRenderingReflectionProbeUsage__SystemVoid(){} // RVA: 0x7FFACAEA2B80
        public void __set_rendererPriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEA2CA0
        public void __set_renderingLayerMask__SystemUInt32__SystemVoid(){} // RVA: 0x7FFACAEA2DC0
        public void __set_shadowCastingMode__UnityEngineRenderingShadowCastingMode__SystemVoid(){} // RVA: 0x7FFACAEA2EE0
        public void __set_sharedMaterial__UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACAEA3000
        public void __set_sharedMaterials__UnityEngineMaterialArray__SystemVoid(){} // RVA: 0x7FFACAEA3150
        public void __set_sortingLayerID__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEA3280
        public void __set_sortingLayerName__SystemString__SystemVoid(){} // RVA: 0x7FFACAEA33A0
        public void __set_sortingOrder__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEA34C0
        public void __set_staticShadowCaster__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEA35E0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACAEA3710
    }

    public class ExternUnityEngineRendererArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAEA8870
        public void .ctor(){} // RVA: 0x7FFACAEA88B0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAEA8C80
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAEA8DB0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAEA8EC0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEA8FA0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEA9080
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAEA9150
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAEA92A0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAEA9340
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAEA9440
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAEA9560
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAEA9670
        public void __GetType__SystemType(){} // RVA: 0x7FFACAEA9790
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAEA9880
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAEA9960
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAEA9A80
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAEA9C10
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAEA9D60
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAEA9E90
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAEA9FB0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAEAA120
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAEAA260
        public void __Get__SystemInt32__UnityEngineRenderer(){} // RVA: 0x7FFACAEAA380
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAEAA4C0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAEAA530
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEAA650
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEAA7D0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEAA930
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAEAAA60
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEAAB80
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEAACE0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEAAE30
        public void __Set__SystemInt32_UnityEngineRenderer__SystemVoid(){} // RVA: 0x7FFACAEAAF50
        public void __ToString__SystemString(){} // RVA: 0x7FFACAEAB0C0
        public void __ctor__SystemInt32__UnityEngineRendererArray(){} // RVA: 0x7FFACAEAB1B0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAEAB2A0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAEAB340
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAEAB3E0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAEAB480
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAEAB520
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAEAB5C0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAEAB660
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAEAB740
    }

    public class ExternUnityEngineRendererExtensions : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAEAD660
        public void .ctor(){} // RVA: 0x7FFACAEAD6A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAEADA70
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAEADBA0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAEADCB0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAEADE00
        public void __GetType__SystemType(){} // RVA: 0x7FFACAEADF00
        public void __ToString__SystemString(){} // RVA: 0x7FFACAEADFF0
        public void __UpdateGIMaterials__UnityEngineRenderer__SystemVoid(){} // RVA: 0x7FFACAEAE0E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAEAE1C0
    }

    public class ExternUnityEngineRenderingPostProcessingPostProcessVolume : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAEAE760
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACAEAE7A0
        public void .ctor(){} // RVA: 0x7FFACAEAE850
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAEAEC20
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAEAED50
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAEAEE60
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAEAF030
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAEAF120
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAEAF3D0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAEAF530
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACAEAF650
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACAEAF740
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAEAF9C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAEAFAB0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAEAFD60
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAEAFEC0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACAEAFFE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACAEB00D0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACAEB0350
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAEB04C0
        public void __GetComponent__T(){} // RVA: 0x7FFACAEB05E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACAEB06C0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAEB0910
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAEB0A00
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAEB0D30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAEB0E20
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAEB1160
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAEB1250
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAEB1560
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAEB16D0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAEB1800
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAEB18F0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAEB1BE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAEB1CD0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAEB2010
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAEB2100
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAEB2410
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAEB2580
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACAEB26C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACAEB27B0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAEB2AA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAEB2B90
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAEB2E80
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAEB2FD0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACAEB3100
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACAEB31F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAEB34A0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAEB3600
        public void __ToString__SystemString(){} // RVA: 0x7FFACAEB36F0
        public void __get_blendDistance__SystemSingle(){} // RVA: 0x7FFACAEB3840
        public void __set_blendDistance__SystemSingle(){} // RVA: 0x7FFACAEB3920
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAEB3A00
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACAEB3B20
        public void __get_isGlobal__SystemBoolean(){} // RVA: 0x7FFACAEB3C60
        public void __set_isGlobal__SystemBoolean(){} // RVA: 0x7FFACAEB3D40
        public void __get_name__SystemString(){} // RVA: 0x7FFACAEB3E20
        public void __get_priority__SystemSingle(){} // RVA: 0x7FFACAEB3F70
        public void __set_priority__SystemSingle(){} // RVA: 0x7FFACAEB4050
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAEB4130
        public void __get_weight__SystemSingle(){} // RVA: 0x7FFACAEB4270
        public void __set_weight__SystemSingle(){} // RVA: 0x7FFACAEB4350
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAEB4430
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAEB4730
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAEB4920
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEB4C20
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAEB4D50
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACAEB4EA0
    }

    public class ExternUnityEngineRenderingPostProcessingPostProcessVolumeArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAEB73C0
        public void .ctor(){} // RVA: 0x7FFACAEB7400
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAEB77D0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAEB7900
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAEB7A10
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEB7AF0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEB7BD0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAEB7CA0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAEB7DF0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAEB7E90
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAEB7F90
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAEB80B0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAEB81C0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAEB82E0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAEB83D0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAEB84B0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAEB85D0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAEB8760
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAEB88B0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAEB89E0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAEB8B00
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAEB8C70
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAEB8DB0
        public void __Get__SystemInt32__UnityEngineRenderingPostProcessingPostProcessVolume(){} // RVA: 0x7FFACAEB8ED0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAEB9010
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAEB9080
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEB91A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEB9320
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEB9480
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAEB95B0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEB96D0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEB9830
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEB9980
        public void __Set__SystemInt32_UnityEngineRenderingPostProcessingPostProcessVolume__SystemVoid(){} // RVA: 0x7FFACAEB9AA0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAEB9C30
        public void __ctor__SystemInt32__UnityEngineRenderingPostProcessingPostProcessVolumeArray(){} // RVA: 0x7FFACAEB9D20
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAEB9E10
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAEB9EB0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAEB9F50
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAEB9FF0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAEBA090
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAEBA130
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAEBA1D0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAEBA2B0
    }

    public class ExternUnityEngineRenderingSphericalHarmonicsL2 : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAEBC1D0
        public void .ctor(){} // RVA: 0x7FFACAEBC210
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAEBC5E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAEBC710
        public void __AddAmbientLight__UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACAEBC820
        public void __AddDirectionalLight__UnityEngineVector3_UnityEngineColor_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEBC9A0
        public void __Clear__SystemVoid(){} // RVA: 0x7FFACAEBCC00
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAEBCD40
        public void __Equals__UnityEngineRenderingSphericalHarmonicsL2__SystemBoolean(){} // RVA: 0x7FFACAEBCEC0
        public void __Evaluate__UnityEngineVector3Array_UnityEngineColorArray__SystemVoid(){} // RVA: 0x7FFACAEBD0C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAEBD370
        public void __GetType__SystemType(){} // RVA: 0x7FFACAEBD480
        public void __ToString__SystemString(){} // RVA: 0x7FFACAEBD570
        public void __get_Item__SystemInt32_SystemInt32__SystemSingle(){} // RVA: 0x7FFACAEBD620
        public void __op_Addition__UnityEngineRenderingSphericalHarmonicsL2_UnityEngineRenderingSphericalHarmonicsL2__UnityEngineRenderingSphericalHarmonicsL2(){} // RVA: 0x7FFACAEBD790
        public void __op_Equality__UnityEngineRenderingSphericalHarmonicsL2_UnityEngineRenderingSphericalHarmonicsL2__SystemBoolean(){} // RVA: 0x7FFACAEBD990
        public void __op_Inequality__UnityEngineRenderingSphericalHarmonicsL2_UnityEngineRenderingSphericalHarmonicsL2__SystemBoolean(){} // RVA: 0x7FFACAEBDB90
        public void __op_Multiply__SystemSingle_UnityEngineRenderingSphericalHarmonicsL2__UnityEngineRenderingSphericalHarmonicsL2(){} // RVA: 0x7FFACAEBDDA0
        public void __op_Multiply__UnityEngineRenderingSphericalHarmonicsL2_SystemSingle__UnityEngineRenderingSphericalHarmonicsL2(){} // RVA: 0x7FFACAEBE660
        public void __set_Item__SystemInt32_SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEBE9E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAEBEBE0
    }

    public class ExternUnityEngineRenderingSphericalHarmonicsL2Array : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAEBF9C0
        public void .ctor(){} // RVA: 0x7FFACAEBFA00
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAEBFDD0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAEBFF00
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAEC0010
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEC00F0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEC01D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAEC02A0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAEC03F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAEC0490
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAEC0590
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAEC06B0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAEC07C0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAEC08E0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAEC09D0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAEC0AB0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAEC0BD0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAEC0D60
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAEC0EB0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAEC0FE0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAEC1100
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAEC1270
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAEC13B0
        public void __Get__SystemInt32__UnityEngineRenderingSphericalHarmonicsL2(){} // RVA: 0x7FFACAEC14D0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAEC1630
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAEC16A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEC17C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEC1940
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEC1AA0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAEC1BD0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEC1CF0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEC1E50
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAEC1FA0
        public void __Set__SystemInt32_UnityEngineRenderingSphericalHarmonicsL2__SystemVoid(){} // RVA: 0x7FFACAEC20C0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAEC2220
        public void __ctor__SystemInt32__UnityEngineRenderingSphericalHarmonicsL2Array(){} // RVA: 0x7FFACAEC2310
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAEC24B0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAEC2550
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAEC25F0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAEC2690
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAEC2730
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAEC27D0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAEC2870
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAEC2950
    }

    public class ExternUnityEngineRigidbody : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAEE4AE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACAEE4B20
        public void .ctor(){} // RVA: 0x7FFACAEE4BD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAEE4FA0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAEE50D0
        public void __AddExplosionForce__SystemSingle_UnityEngineVector3_SystemSingle_SystemSingle_UnityEngineForceMode__SystemVoid(){} // RVA: 0x7FFACAEE51E0
        public void __AddExplosionForce__SystemSingle_UnityEngineVector3_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEE5420
        public void __AddExplosionForce__SystemSingle_UnityEngineVector3_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEE5630
        public void __AddForceAtPosition__UnityEngineVector3_UnityEngineVector3_UnityEngineForceMode__SystemVoid(){} // RVA: 0x7FFACAEE5810
        public void __AddForceAtPosition__UnityEngineVector3_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAEE59E0
        public void __AddForce__SystemSingle_SystemSingle_SystemSingle_UnityEngineForceMode__SystemVoid(){} // RVA: 0x7FFACAEE5B60
        public void __AddForce__SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEE5D40
        public void __AddForce__UnityEngineVector3_UnityEngineForceMode__SystemVoid(){} // RVA: 0x7FFACAEE5ED0
        public void __AddForce__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAEE6050
        public void __AddRelativeForce__SystemSingle_SystemSingle_SystemSingle_UnityEngineForceMode__SystemVoid(){} // RVA: 0x7FFACAEE6190
        public void __AddRelativeForce__SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEE6370
        public void __AddRelativeForce__UnityEngineVector3_UnityEngineForceMode__SystemVoid(){} // RVA: 0x7FFACAEE6500
        public void __AddRelativeForce__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAEE6680
        public void __AddRelativeTorque__SystemSingle_SystemSingle_SystemSingle_UnityEngineForceMode__SystemVoid(){} // RVA: 0x7FFACAEE67C0
        public void __AddRelativeTorque__SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEE69A0
        public void __AddRelativeTorque__UnityEngineVector3_UnityEngineForceMode__SystemVoid(){} // RVA: 0x7FFACAEE6B30
        public void __AddRelativeTorque__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAEE6CB0
        public void __AddTorque__SystemSingle_SystemSingle_SystemSingle_UnityEngineForceMode__SystemVoid(){} // RVA: 0x7FFACAEE6DF0
        public void __AddTorque__SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEE6FD0
        public void __AddTorque__UnityEngineVector3_UnityEngineForceMode__SystemVoid(){} // RVA: 0x7FFACAEE7160
        public void __AddTorque__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAEE72E0
        public void __ClosestPointOnBounds__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACAEE7420
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAEE7610
        public void __GetAccumulatedForce__SystemSingle__UnityEngineVector3(){} // RVA: 0x7FFACAEE77E0
        public void __GetAccumulatedForce__UnityEngineVector3(){} // RVA: 0x7FFACAEE7970
        public void __GetAccumulatedTorque__SystemSingle__UnityEngineVector3(){} // RVA: 0x7FFACAEE7B10
        public void __GetAccumulatedTorque__UnityEngineVector3(){} // RVA: 0x7FFACAEE7CA0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAEE7E40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAEE7F30
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAEE81E0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAEE8340
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACAEE8460
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACAEE8550
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAEE87D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAEE88C0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAEE8B70
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAEE8CD0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACAEE8DF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACAEE8EE0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACAEE9160
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAEE92D0
        public void __GetComponent__T(){} // RVA: 0x7FFACAEE93F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACAEE94D0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAEE9720
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAEE9810
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAEE9B40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAEE9C30
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAEE9F70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAEEA060
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAEEA370
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAEEA4E0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAEEA610
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAEEA700
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAEEA9F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAEEAAE0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAEEAE20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAEEAF10
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAEEB220
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAEEB390
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACAEEB4D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACAEEB5C0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAEEB8B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAEEB9A0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAEEBC90
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAEEBDE0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACAEEBF10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACAEEC000
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAEEC2B0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAEEC410
        public void __GetPointVelocity__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACAEEC560
        public void __GetRelativePointVelocity__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACAEEC6F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAEEC880
        public void __IsSleeping__SystemBoolean(){} // RVA: 0x7FFACAEEC970
        public void __MovePosition__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAEECA90
        public void __MoveRotation__UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACAEECBD0
        public void __Move__UnityEngineVector3_UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACAEECD00
        public void __ResetCenterOfMass__SystemVoid(){} // RVA: 0x7FFACAEECE80
        public void __ResetInertiaTensor__SystemVoid(){} // RVA: 0x7FFACAEECF70
        public void __SetDensity__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEED060
        public void __Sleep__SystemVoid(){} // RVA: 0x7FFACAEED190
        public void __SweepTestAll__UnityEngineVector3_SystemSingle_UnityEngineQueryTriggerInteraction__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAEED280
        public void __SweepTestAll__UnityEngineVector3_SystemSingle__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAEED430
        public void __SweepTestAll__UnityEngineVector3__UnityEngineRaycastHitArray(){} // RVA: 0x7FFACAEED5A0
        public void __SweepTest__UnityEngineVector3_UnityEngineRaycastHitRef_SystemSingle_UnityEngineQueryTriggerInteraction__SystemBoolean(){} // RVA: 0x7FFACAEED6D0
        public void __SweepTest__UnityEngineVector3_UnityEngineRaycastHitRef_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAEED930
        public void __SweepTest__UnityEngineVector3_UnityEngineRaycastHitRef__SystemBoolean(){} // RVA: 0x7FFACAEEDB40
        public void __ToString__SystemString(){} // RVA: 0x7FFACAEEDD20
        public void __WakeUp__SystemVoid(){} // RVA: 0x7FFACAEEDE70
        public void __get_angularDrag__SystemSingle(){} // RVA: 0x7FFACAEEDF60
        public void __get_angularVelocity__UnityEngineVector3(){} // RVA: 0x7FFACAEEE080
        public void __get_automaticCenterOfMass__SystemBoolean(){} // RVA: 0x7FFACAEEE1C0
        public void __get_automaticInertiaTensor__SystemBoolean(){} // RVA: 0x7FFACAEEE2E0
        public void __get_centerOfMass__UnityEngineVector3(){} // RVA: 0x7FFACAEEE400
        public void __get_collisionDetectionMode__UnityEngineCollisionDetectionMode(){} // RVA: 0x7FFACAEEE540
        public void __get_constraints__UnityEngineRigidbodyConstraints(){} // RVA: 0x7FFACAEEE660
        public void __get_detectCollisions__SystemBoolean(){} // RVA: 0x7FFACAEEE780
        public void __get_drag__SystemSingle(){} // RVA: 0x7FFACAEEE8A0
        public void __get_excludeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACAEEE9C0
        public void __get_freezeRotation__SystemBoolean(){} // RVA: 0x7FFACAEEEAF0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACAEEEC10
        public void __get_includeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACAEEED50
        public void __get_inertiaTensorRotation__UnityEngineQuaternion(){} // RVA: 0x7FFACAEEEE80
        public void __get_inertiaTensor__UnityEngineVector3(){} // RVA: 0x7FFACAEEEFC0
        public void __get_interpolation__UnityEngineRigidbodyInterpolation(){} // RVA: 0x7FFACAEEF100
        public void __get_isKinematic__SystemBoolean(){} // RVA: 0x7FFACAEEF220
        public void __get_mass__SystemSingle(){} // RVA: 0x7FFACAEEF340
        public void __get_maxAngularVelocity__SystemSingle(){} // RVA: 0x7FFACAEEF460
        public void __get_maxDepenetrationVelocity__SystemSingle(){} // RVA: 0x7FFACAEEF580
        public void __get_maxLinearVelocity__SystemSingle(){} // RVA: 0x7FFACAEEF6A0
        public void __get_name__SystemString(){} // RVA: 0x7FFACAEEF7C0
        public void __get_position__UnityEngineVector3(){} // RVA: 0x7FFACAEEF910
        public void __get_rotation__UnityEngineQuaternion(){} // RVA: 0x7FFACAEEFA50
        public void __get_solverIterations__SystemInt32(){} // RVA: 0x7FFACAEEFB90
        public void __get_solverVelocityIterations__SystemInt32(){} // RVA: 0x7FFACAEEFCB0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAEEFDD0
        public void __get_useGravity__SystemBoolean(){} // RVA: 0x7FFACAEEFF10
        public void __get_velocity__UnityEngineVector3(){} // RVA: 0x7FFACAEF0030
        public void __get_worldCenterOfMass__UnityEngineVector3(){} // RVA: 0x7FFACAEF0170
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAEF02B0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAEF05B0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAEF07A0
        public void __set_angularDrag__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEF0AA0
        public void __set_angularVelocity__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAEF0BD0
        public void __set_automaticCenterOfMass__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEF0D10
        public void __set_automaticInertiaTensor__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEF0E40
        public void __set_centerOfMass__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAEF0F70
        public void __set_collisionDetectionMode__UnityEngineCollisionDetectionMode__SystemVoid(){} // RVA: 0x7FFACAEF10B0
        public void __set_constraints__UnityEngineRigidbodyConstraints__SystemVoid(){} // RVA: 0x7FFACAEF11D0
        public void __set_detectCollisions__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEF12F0
        public void __set_drag__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEF1420
        public void __set_excludeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACAEF1550
        public void __set_freezeRotation__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEF1670
        public void __set_includeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACAEF17A0
        public void __set_inertiaTensorRotation__UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACAEF18C0
        public void __set_inertiaTensor__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAEF19F0
        public void __set_interpolation__UnityEngineRigidbodyInterpolation__SystemVoid(){} // RVA: 0x7FFACAEF1B30
        public void __set_isKinematic__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEF1C50
        public void __set_mass__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEF1D80
        public void __set_maxAngularVelocity__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEF1EB0
        public void __set_maxDepenetrationVelocity__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEF1FE0
        public void __set_maxLinearVelocity__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEF2110
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAEF2240
        public void __set_position__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAEF2390
        public void __set_rotation__UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACAEF24D0
        public void __set_solverIterations__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEF2600
        public void __set_solverVelocityIterations__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAEF2720
        public void __set_useGravity__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAEF2840
        public void __set_velocity__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAEF2970
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACAEF2AB0
    }

    public class ExternUnityEngineRigidbody2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAEF9100
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACAEF9140
        public void .ctor(){} // RVA: 0x7FFACAEF91F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAEF95C0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAEF96F0
        public void __AddForceAtPosition__UnityEngineVector2_UnityEngineVector2_UnityEngineForceMode2D__SystemVoid(){} // RVA: 0x7FFACAEF9800
        public void __AddForceAtPosition__UnityEngineVector2_UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAEF9960
        public void __AddForce__UnityEngineVector2_UnityEngineForceMode2D__SystemVoid(){} // RVA: 0x7FFACAEF9AC0
        public void __AddForce__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAEF9C30
        public void __AddRelativeForce__UnityEngineVector2_UnityEngineForceMode2D__SystemVoid(){} // RVA: 0x7FFACAEF9D50
        public void __AddRelativeForce__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAEF9EC0
        public void __AddTorque__SystemSingle_UnityEngineForceMode2D__SystemVoid(){} // RVA: 0x7FFACAEF9FE0
        public void __AddTorque__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAEFA100
        public void __Cast__UnityEngineVector2_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAEFA230
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAEFA410
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAEFA680
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAEFA8F0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACAEFAB20
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACAEFACB0
        public void __ClosestPoint__UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACAEFAE10
        public void __Distance__UnityEngineCollider2D__UnityEngineColliderDistance2D(){} // RVA: 0x7FFACAEFAF70
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAEFB0D0
        public void __GetAttachedColliders__SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAEFB2A0
        public void __GetAttachedColliders__UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAEFB440
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAEFB5E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAEFB6D0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAEFB980
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAEFBAE0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACAEFBC00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACAEFBCF0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAEFBF70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAEFC060
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAEFC310
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAEFC470
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACAEFC590
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACAEFC680
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACAEFC900
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAEFCA70
        public void __GetComponent__T(){} // RVA: 0x7FFACAEFCB90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACAEFCC70
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAEFCEC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAEFCFB0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAEFD2E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAEFD3D0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAEFD710
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAEFD800
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAEFDB10
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAEFDC80
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAEFDDB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAEFDEA0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAEFE190
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAEFE280
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAEFE5C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAEFE6B0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAEFE9C0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAEFEB30
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACAEFEC70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACAEFED60
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAEFF050
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAEFF140
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAEFF430
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAEFF580
        public void __GetComponents__TArray(){} // RVA: 0x7FFACAEFF6B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACAEFF7A0
        public void __GetContacts__SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAEFFA50
        public void __GetContacts__SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACAEFFC70
        public void __GetContacts__UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAEFFE30
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAF00050
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACAF00280
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAF00460
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACAF00690
        public void __GetContacts__UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACAF00870
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF00A30
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAF00B90
        public void __GetPointVelocity__UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACAF00CE0
        public void __GetPoint__UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACAF00E40
        public void __GetRelativePointVelocity__UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACAF00FA0
        public void __GetRelativePoint__UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACAF01100
        public void __GetRelativeVector__UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACAF01260
        public void __GetShapes__UnityEnginePhysicsShapeGroup2D__SystemInt32(){} // RVA: 0x7FFACAF013C0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF01530
        public void __GetVector__UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACAF01620
        public void __IsAwake__SystemBoolean(){} // RVA: 0x7FFACAF01780
        public void __IsSleeping__SystemBoolean(){} // RVA: 0x7FFACAF018A0
        public void __IsTouchingLayers__SystemBoolean(){} // RVA: 0x7FFACAF019C0
        public void __IsTouchingLayers__SystemInt32__SystemBoolean(){} // RVA: 0x7FFACAF01AF0
        public void __IsTouching__UnityEngineCollider2D_UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACAF01C50
        public void __IsTouching__UnityEngineCollider2D__SystemBoolean(){} // RVA: 0x7FFACAF01E40
        public void __IsTouching__UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACAF01FC0
        public void __MovePosition__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAF02140
        public void __MoveRotation__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF02260
        public void __MoveRotation__UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACAF02390
        public void __OverlapCollider__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACAF024C0
        public void __OverlapCollider__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACAF026F0
        public void __OverlapPoint__UnityEngineVector2__SystemBoolean(){} // RVA: 0x7FFACAF02920
        public void __SetRotation__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF02A80
        public void __SetRotation__UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACAF02BB0
        public void __Sleep__SystemVoid(){} // RVA: 0x7FFACAF02CE0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF02DD0
        public void __WakeUp__SystemVoid(){} // RVA: 0x7FFACAF02F20
        public void __get_angularDrag__SystemSingle(){} // RVA: 0x7FFACAF03010
        public void __get_angularVelocity__SystemSingle(){} // RVA: 0x7FFACAF03130
        public void __get_attachedColliderCount__SystemInt32(){} // RVA: 0x7FFACAF03250
        public void __get_bodyType__UnityEngineRigidbodyType2D(){} // RVA: 0x7FFACAF03370
        public void __get_centerOfMass__UnityEngineVector2(){} // RVA: 0x7FFACAF03490
        public void __get_collisionDetectionMode__UnityEngineCollisionDetectionMode2D(){} // RVA: 0x7FFACAF035C0
        public void __get_constraints__UnityEngineRigidbodyConstraints2D(){} // RVA: 0x7FFACAF036E0
        public void __get_drag__SystemSingle(){} // RVA: 0x7FFACAF03800
        public void __get_excludeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACAF03920
        public void __get_freezeRotation__SystemBoolean(){} // RVA: 0x7FFACAF03A50
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACAF03B70
        public void __get_gravityScale__SystemSingle(){} // RVA: 0x7FFACAF03CB0
        public void __get_includeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACAF03DD0
        public void __get_inertia__SystemSingle(){} // RVA: 0x7FFACAF03F00
        public void __get_interpolation__UnityEngineRigidbodyInterpolation2D(){} // RVA: 0x7FFACAF04020
        public void __get_isKinematic__SystemBoolean(){} // RVA: 0x7FFACAF04140
        public void __get_mass__SystemSingle(){} // RVA: 0x7FFACAF04270
        public void __get_name__SystemString(){} // RVA: 0x7FFACAF04390
        public void __get_position__UnityEngineVector2(){} // RVA: 0x7FFACAF044E0
        public void __get_rotation__SystemSingle(){} // RVA: 0x7FFACAF04610
        public void __get_sharedMaterial__UnityEnginePhysicsMaterial2D(){} // RVA: 0x7FFACAF04730
        public void __get_simulated__SystemBoolean(){} // RVA: 0x7FFACAF04870
        public void __get_sleepMode__UnityEngineRigidbodySleepMode2D(){} // RVA: 0x7FFACAF04990
        public void __get_totalForce__UnityEngineVector2(){} // RVA: 0x7FFACAF04AB0
        public void __get_totalTorque__SystemSingle(){} // RVA: 0x7FFACAF04BE0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAF04D00
        public void __get_useAutoMass__SystemBoolean(){} // RVA: 0x7FFACAF04E40
        public void __get_useFullKinematicContacts__SystemBoolean(){} // RVA: 0x7FFACAF04F60
        public void __get_velocity__UnityEngineVector2(){} // RVA: 0x7FFACAF05080
        public void __get_worldCenterOfMass__UnityEngineVector2(){} // RVA: 0x7FFACAF051B0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF052E0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF055E0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF057D0
        public void __set_angularDrag__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF05AD0
        public void __set_angularVelocity__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF05C00
        public void __set_bodyType__UnityEngineRigidbodyType2D__SystemVoid(){} // RVA: 0x7FFACAF05D30
        public void __set_centerOfMass__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAF05E50
        public void __set_collisionDetectionMode__UnityEngineCollisionDetectionMode2D__SystemVoid(){} // RVA: 0x7FFACAF05F70
        public void __set_constraints__UnityEngineRigidbodyConstraints2D__SystemVoid(){} // RVA: 0x7FFACAF06090
        public void __set_drag__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF061B0
        public void __set_excludeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACAF062E0
        public void __set_freezeRotation__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF06400
        public void __set_gravityScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF06530
        public void __set_includeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACAF06660
        public void __set_inertia__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF06780
        public void __set_interpolation__UnityEngineRigidbodyInterpolation2D__SystemVoid(){} // RVA: 0x7FFACAF068B0
        public void __set_isKinematic__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF069D0
        public void __set_mass__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF06AF0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAF06C20
        public void __set_position__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAF06D70
        public void __set_rotation__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF06E90
        public void __set_sharedMaterial__UnityEnginePhysicsMaterial2D__SystemVoid(){} // RVA: 0x7FFACAF06FC0
        public void __set_simulated__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF07110
        public void __set_sleepMode__UnityEngineRigidbodySleepMode2D__SystemVoid(){} // RVA: 0x7FFACAF07240
        public void __set_totalForce__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAF07360
        public void __set_totalTorque__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF07480
        public void __set_useAutoMass__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF075B0
        public void __set_useFullKinematicContacts__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF076E0
        public void __set_velocity__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAF07810
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACAF07930
    }

    public class ExternUnityEngineRigidbody2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF0E410
        public void .ctor(){} // RVA: 0x7FFACAF0E450
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF0E820
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF0E950
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAF0EA60
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF0EB40
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF0EC20
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF0ECF0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAF0EE40
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF0EEE0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF0EFE0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAF0F100
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF0F210
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF0F330
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF0F420
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAF0F500
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF0F620
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF0F7B0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAF0F900
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAF0FA30
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF0FB50
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF0FCC0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAF0FE00
        public void __Get__SystemInt32__UnityEngineRigidbody2D(){} // RVA: 0x7FFACAF0FF20
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAF10060
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAF100D0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF101F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF10370
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF104D0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAF10600
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF10720
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF10880
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF109D0
        public void __Set__SystemInt32_UnityEngineRigidbody2D__SystemVoid(){} // RVA: 0x7FFACAF10AF0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF10C80
        public void __ctor__SystemInt32__UnityEngineRigidbody2DArray(){} // RVA: 0x7FFACAF10D70
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAF10E60
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAF10F00
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAF10FA0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAF11040
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAF110E0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAF11180
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAF11220
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAF11300
    }

    public class ExternUnityEngineRigidbodyArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF13220
        public void .ctor(){} // RVA: 0x7FFACAF13260
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF13630
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF13760
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAF13870
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF13950
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF13A30
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF13B00
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAF13C50
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF13CF0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF13DF0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAF13F10
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF14020
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF14140
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF14230
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAF14310
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF14430
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF145C0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAF14710
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAF14840
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF14960
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF14AD0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAF14C10
        public void __Get__SystemInt32__UnityEngineRigidbody(){} // RVA: 0x7FFACAF14D30
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAF14E70
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAF14EE0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF15000
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF15180
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF152E0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAF15410
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF15530
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF15690
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF157E0
        public void __Set__SystemInt32_UnityEngineRigidbody__SystemVoid(){} // RVA: 0x7FFACAF15900
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF15AC0
        public void __ctor__SystemInt32__UnityEngineRigidbodyArray(){} // RVA: 0x7FFACAF15BB0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAF15CA0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAF15D40
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAF15DE0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAF15E80
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAF15F20
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAF15FC0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAF16060
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAF16140
    }

    public class ExternUnityEngineRuntimeAnimatorController : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF3A140
        public void .ctor(){} // RVA: 0x7FFACAF3A180
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF3A550
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF3A680
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF3A790
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF3A960
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAF3AAC0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF3AC10
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF3AD00
        public void __get_animationClips__UnityEngineAnimationClipArray(){} // RVA: 0x7FFACAF3AE50
        public void __get_name__SystemString(){} // RVA: 0x7FFACAF3AF90
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF3B0E0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF3B3E0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF3B5D0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAF3B8D0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAF3BA20
    }

    public class ExternUnityEngineRuntimeAnimatorControllerArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF3C430
        public void .ctor(){} // RVA: 0x7FFACAF3C470
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF3C840
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF3C970
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAF3CA80
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF3CB60
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF3CC40
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF3CD10
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAF3CE60
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF3CF00
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF3D000
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAF3D120
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF3D230
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF3D350
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF3D440
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAF3D520
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF3D640
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF3D7D0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAF3D920
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAF3DA50
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF3DB70
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF3DCE0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAF3DE20
        public void __Get__SystemInt32__UnityEngineRuntimeAnimatorController(){} // RVA: 0x7FFACAF3DF40
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAF3E080
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAF3E0F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF3E210
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF3E390
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF3E4F0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAF3E620
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF3E740
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF3E8A0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF3E9F0
        public void __Set__SystemInt32_UnityEngineRuntimeAnimatorController__SystemVoid(){} // RVA: 0x7FFACAF3EB10
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF3ECD0
        public void __ctor__SystemInt32__UnityEngineRuntimeAnimatorControllerArray(){} // RVA: 0x7FFACAF3EDC0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAF3EF70
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAF3F010
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAF3F0B0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAF3F150
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAF3F1F0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAF3F290
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAF3F330
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAF3F410
    }

    public class ExternUnityEngineSkeletonBone : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF41330
        public void .ctor(){} // RVA: 0x7FFACAF41370
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF41740
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF41870
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF41980
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF41AC0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF41B70
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF41C60
        public void __get_name__SystemString(){} // RVA: 0x7FFACAF41D10
        public void __set_name__SystemString(){} // RVA: 0x7FFACAF41E60
        public void __get_position__UnityEngineVector3(){} // RVA: 0x7FFACAF41FD0
        public void __set_position__UnityEngineVector3(){} // RVA: 0x7FFACAF42140
        public void __get_rotation__UnityEngineQuaternion(){} // RVA: 0x7FFACAF42290
        public void __set_rotation__UnityEngineQuaternion(){} // RVA: 0x7FFACAF423F0
        public void __get_scale__UnityEngineVector3(){} // RVA: 0x7FFACAF42530
        public void __set_scale__UnityEngineVector3(){} // RVA: 0x7FFACAF426A0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAF427F0
    }

    public class ExternUnityEngineSkeletonBoneArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF432D0
        public void .ctor(){} // RVA: 0x7FFACAF43310
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF436E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF43810
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAF43920
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF43A00
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF43AE0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF43BB0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAF43D00
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF43DA0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF43EA0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAF43FC0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF440D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF441F0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF442E0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAF443C0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF444E0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF44670
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAF447C0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAF448F0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF44A10
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF44B80
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAF44CC0
        public void __Get__SystemInt32__UnityEngineSkeletonBone(){} // RVA: 0x7FFACAF44DE0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAF44EF0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAF44F60
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF45080
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF45200
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF45360
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAF45490
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF455B0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF45710
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF45860
        public void __Set__SystemInt32_UnityEngineSkeletonBone__SystemVoid(){} // RVA: 0x7FFACAF45980
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF45B00
        public void __ctor__SystemInt32__UnityEngineSkeletonBoneArray(){} // RVA: 0x7FFACAF45BF0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAF45CA0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAF45D40
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAF45DE0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAF45E80
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAF45F20
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAF45FC0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAF46060
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAF46140
    }

    public class ExternUnityEngineSkinnedMeshRenderer : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF48060
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACAF480A0
        public void .ctor(){} // RVA: 0x7FFACAF48150
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF48520
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF48650
        public void __BakeMesh__UnityEngineMesh_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF48760
        public void __BakeMesh__UnityEngineMesh__SystemVoid(){} // RVA: 0x7FFACAF488A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF489F0
        public void __GetBlendShapeWeight__SystemInt32__SystemSingle(){} // RVA: 0x7FFACAF48BC0
        public void __GetClosestReflectionProbes__SystemCollectionsGenericListUnityEngineRenderingReflectionProbeBlendInfo__SystemVoid(){} // RVA: 0x7FFACAF48D20
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAF48E40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAF48F30
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAF491E0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAF49340
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACAF49460
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACAF49550
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAF497D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAF498C0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAF49B70
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAF49CD0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACAF49DF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACAF49EE0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACAF4A160
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAF4A2D0
        public void __GetComponent__T(){} // RVA: 0x7FFACAF4A3F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACAF4A4D0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAF4A720
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAF4A810
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF4AB40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF4AC30
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAF4AF70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAF4B060
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAF4B370
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAF4B4E0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAF4B610
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAF4B700
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF4B9F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF4BAE0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAF4BE20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAF4BF10
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAF4C220
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAF4C390
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACAF4C4D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACAF4C5C0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAF4C8B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAF4C9A0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAF4CC90
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAF4CDE0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACAF4CF10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACAF4D000
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF4D2B0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAF4D410
        public void __GetMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACAF4D560
        public void __GetPropertyBlock__UnityEngineMaterialPropertyBlock_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF4D680
        public void __GetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(){} // RVA: 0x7FFACAF4D790
        public void __GetSharedMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACAF4D8B0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF4D9D0
        public void __HasPropertyBlock__SystemBoolean(){} // RVA: 0x7FFACAF4DAC0
        public void __ResetBounds__SystemVoid(){} // RVA: 0x7FFACAF4DBE0
        public void __ResetLocalBounds__SystemVoid(){} // RVA: 0x7FFACAF4DCD0
        public void __SetBlendShapeWeight__SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF4DDC0
        public void __SetMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACAF4DF20
        public void __SetPropertyBlock__UnityEngineMaterialPropertyBlock_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF4E0F0
        public void __SetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(){} // RVA: 0x7FFACAF4E200
        public void __SetSharedMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACAF4E320
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF4E4F0
        public void __get_allowOcclusionWhenDynamic__SystemBoolean(){} // RVA: 0x7FFACAF4E640
        public void __get_bones__UnityEngineTransformArray(){} // RVA: 0x7FFACAF4E760
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACAF4E8A0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAF4E9F0
        public void __get_forceMatrixRecalculationPerRender__SystemBoolean(){} // RVA: 0x7FFACAF4EB10
        public void __get_forceRenderingOff__SystemBoolean(){} // RVA: 0x7FFACAF4EC30
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACAF4ED50
        public void __get_isPartOfStaticBatch__SystemBoolean(){} // RVA: 0x7FFACAF4EE90
        public void __get_isVisible__SystemBoolean(){} // RVA: 0x7FFACAF4EFB0
        public void __get_lightProbeProxyVolumeOverride__UnityEngineGameObject(){} // RVA: 0x7FFACAF4F0D0
        public void __get_lightProbeUsage__UnityEngineRenderingLightProbeUsage(){} // RVA: 0x7FFACAF4F210
        public void __get_lightmapIndex__SystemInt32(){} // RVA: 0x7FFACAF4F330
        public void __get_lightmapScaleOffset__UnityEngineVector4(){} // RVA: 0x7FFACAF4F450
        public void __get_localBounds__UnityEngineBounds(){} // RVA: 0x7FFACAF4F590
        public void __get_localToWorldMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACAF4F6E0
        public void __get_material__UnityEngineMaterial(){} // RVA: 0x7FFACAF4F860
        public void __get_materials__UnityEngineMaterialArray(){} // RVA: 0x7FFACAF4F9A0
        public void __get_motionVectorGenerationMode__UnityEngineMotionVectorGenerationMode(){} // RVA: 0x7FFACAF4FAE0
        public void __get_name__SystemString(){} // RVA: 0x7FFACAF4FC00
        public void __get_probeAnchor__UnityEngineTransform(){} // RVA: 0x7FFACAF4FD50
        public void __get_quality__UnityEngineSkinQuality(){} // RVA: 0x7FFACAF4FE90
        public void __get_realtimeLightmapIndex__SystemInt32(){} // RVA: 0x7FFACAF4FFB0
        public void __get_realtimeLightmapScaleOffset__UnityEngineVector4(){} // RVA: 0x7FFACAF500E0
        public void __get_receiveShadows__SystemBoolean(){} // RVA: 0x7FFACAF50220
        public void __get_reflectionProbeUsage__UnityEngineRenderingReflectionProbeUsage(){} // RVA: 0x7FFACAF50340
        public void __get_rendererPriority__SystemInt32(){} // RVA: 0x7FFACAF50460
        public void __get_renderingLayerMask__SystemUInt32(){} // RVA: 0x7FFACAF50580
        public void __get_rootBone__UnityEngineTransform(){} // RVA: 0x7FFACAF506A0
        public void __get_shadowCastingMode__UnityEngineRenderingShadowCastingMode(){} // RVA: 0x7FFACAF507E0
        public void __get_sharedMaterial__UnityEngineMaterial(){} // RVA: 0x7FFACAF50900
        public void __get_sharedMaterials__UnityEngineMaterialArray(){} // RVA: 0x7FFACAF50A40
        public void __get_sharedMesh__UnityEngineMesh(){} // RVA: 0x7FFACAF50B80
        public void __get_skinnedMotionVectors__SystemBoolean(){} // RVA: 0x7FFACAF50CC0
        public void __get_sortingLayerID__SystemInt32(){} // RVA: 0x7FFACAF50DE0
        public void __get_sortingLayerName__SystemString(){} // RVA: 0x7FFACAF50F00
        public void __get_sortingOrder__SystemInt32(){} // RVA: 0x7FFACAF51020
        public void __get_staticShadowCaster__SystemBoolean(){} // RVA: 0x7FFACAF51140
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAF51260
        public void __get_updateWhenOffscreen__SystemBoolean(){} // RVA: 0x7FFACAF513A0
        public void __get_worldToLocalMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACAF514C0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF51640
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF51940
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF51B30
        public void __set_allowOcclusionWhenDynamic__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF51E30
        public void __set_bones__UnityEngineTransformArray__SystemVoid(){} // RVA: 0x7FFACAF51F60
        public void __set_bounds__UnityEngineBounds__SystemVoid(){} // RVA: 0x7FFACAF520C0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF52200
        public void __set_forceMatrixRecalculationPerRender__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF52330
        public void __set_forceRenderingOff__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF52460
        public void __set_lightProbeProxyVolumeOverride__UnityEngineGameObject__SystemVoid(){} // RVA: 0x7FFACAF52590
        public void __set_lightProbeUsage__UnityEngineRenderingLightProbeUsage__SystemVoid(){} // RVA: 0x7FFACAF526E0
        public void __set_lightmapIndex__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF52800
        public void __set_lightmapScaleOffset__UnityEngineVector4__SystemVoid(){} // RVA: 0x7FFACAF52930
        public void __set_localBounds__UnityEngineBounds__SystemVoid(){} // RVA: 0x7FFACAF52A60
        public void __set_material__UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACAF52BA0
        public void __set_materials__UnityEngineMaterialArray__SystemVoid(){} // RVA: 0x7FFACAF52CF0
        public void __set_motionVectorGenerationMode__UnityEngineMotionVectorGenerationMode__SystemVoid(){} // RVA: 0x7FFACAF52E20
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAF52F40
        public void __set_probeAnchor__UnityEngineTransform__SystemVoid(){} // RVA: 0x7FFACAF53090
        public void __set_quality__UnityEngineSkinQuality__SystemVoid(){} // RVA: 0x7FFACAF531E0
        public void __set_realtimeLightmapIndex__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF53300
        public void __set_realtimeLightmapScaleOffset__UnityEngineVector4__SystemVoid(){} // RVA: 0x7FFACAF53430
        public void __set_receiveShadows__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF53560
        public void __set_reflectionProbeUsage__UnityEngineRenderingReflectionProbeUsage__SystemVoid(){} // RVA: 0x7FFACAF53690
        public void __set_rendererPriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF537B0
        public void __set_renderingLayerMask__SystemUInt32__SystemVoid(){} // RVA: 0x7FFACAF538D0
        public void __set_rootBone__UnityEngineTransform__SystemVoid(){} // RVA: 0x7FFACAF539F0
        public void __set_shadowCastingMode__UnityEngineRenderingShadowCastingMode__SystemVoid(){} // RVA: 0x7FFACAF53B40
        public void __set_sharedMaterial__UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACAF53C60
        public void __set_sharedMaterials__UnityEngineMaterialArray__SystemVoid(){} // RVA: 0x7FFACAF53DB0
        public void __set_sharedMesh__UnityEngineMesh__SystemVoid(){} // RVA: 0x7FFACAF53EE0
        public void __set_skinnedMotionVectors__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF54030
        public void __set_sortingLayerID__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF54160
        public void __set_sortingLayerName__SystemString__SystemVoid(){} // RVA: 0x7FFACAF54280
        public void __set_sortingOrder__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF543A0
        public void __set_staticShadowCaster__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF544C0
        public void __set_updateWhenOffscreen__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF545F0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACAF54720
    }

    public class ExternUnityEngineSkinnedMeshRendererArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF5A600
        public void .ctor(){} // RVA: 0x7FFACAF5A640
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF5AA10
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF5AB40
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAF5AC50
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF5AD30
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF5AE10
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF5AEE0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAF5B030
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF5B0D0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF5B1D0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAF5B2F0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF5B400
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF5B520
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF5B610
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAF5B6F0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF5B810
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF5B9A0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAF5BAF0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAF5BC20
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF5BD40
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF5BEB0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAF5BFF0
        public void __Get__SystemInt32__UnityEngineSkinnedMeshRenderer(){} // RVA: 0x7FFACAF5C110
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAF5C250
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAF5C2C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF5C3E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF5C560
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF5C6C0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAF5C7F0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF5C910
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF5CA70
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF5CBC0
        public void __Set__SystemInt32_UnityEngineSkinnedMeshRenderer__SystemVoid(){} // RVA: 0x7FFACAF5CCE0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF5CE50
        public void __ctor__SystemInt32__UnityEngineSkinnedMeshRendererArray(){} // RVA: 0x7FFACAF5CF40
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAF5D030
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAF5D0D0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAF5D170
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAF5D210
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAF5D2B0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAF5D350
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAF5D3F0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAF5D4D0
    }

    public class ExternUnityEngineSliderJoint2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF5F3F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACAF5F430
        public void .ctor(){} // RVA: 0x7FFACAF5F4E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF5F8B0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF5F9E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF5FAF0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAF5FCC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAF5FDB0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAF60060
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAF601C0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACAF602E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACAF603D0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAF60650
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAF60740
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAF609F0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAF60B50
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACAF60C70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACAF60D60
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACAF60FE0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAF61150
        public void __GetComponent__T(){} // RVA: 0x7FFACAF61270
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACAF61350
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAF615A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAF61690
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF619C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF61AB0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAF61DF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAF61EE0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAF621F0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAF62360
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAF62490
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAF62580
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF62870
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF62960
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAF62CA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAF62D90
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAF630A0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAF63210
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACAF63350
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACAF63440
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAF63730
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAF63820
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAF63B10
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAF63C60
        public void __GetComponents__TArray(){} // RVA: 0x7FFACAF63D90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACAF63E80
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF64130
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAF64290
        public void __GetMotorForce__SystemSingle__SystemSingle(){} // RVA: 0x7FFACAF643E0
        public void __GetReactionForce__SystemSingle__UnityEngineVector2(){} // RVA: 0x7FFACAF64540
        public void __GetReactionTorque__SystemSingle__SystemSingle(){} // RVA: 0x7FFACAF64650
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF647B0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF648A0
        public void __get_anchor__UnityEngineVector2(){} // RVA: 0x7FFACAF649F0
        public void __get_angle__SystemSingle(){} // RVA: 0x7FFACAF64B20
        public void __get_attachedRigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACAF64C40
        public void __get_autoConfigureAngle__SystemBoolean(){} // RVA: 0x7FFACAF64D80
        public void __get_autoConfigureConnectedAnchor__SystemBoolean(){} // RVA: 0x7FFACAF64EA0
        public void __get_breakAction__UnityEngineJointBreakAction2D(){} // RVA: 0x7FFACAF64FC0
        public void __get_breakForce__SystemSingle(){} // RVA: 0x7FFACAF650E0
        public void __get_breakTorque__SystemSingle(){} // RVA: 0x7FFACAF65200
        public void __get_connectedAnchor__UnityEngineVector2(){} // RVA: 0x7FFACAF65320
        public void __get_connectedBody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACAF65450
        public void __get_enableCollision__SystemBoolean(){} // RVA: 0x7FFACAF65590
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAF656B0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACAF657D0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACAF65910
        public void __get_jointSpeed__SystemSingle(){} // RVA: 0x7FFACAF65A30
        public void __get_jointTranslation__SystemSingle(){} // RVA: 0x7FFACAF65B50
        public void __get_limitState__UnityEngineJointLimitState2D(){} // RVA: 0x7FFACAF65C70
        public void __get_limits__UnityEngineJointTranslationLimits2D(){} // RVA: 0x7FFACAF65D90
        public void __get_motor__UnityEngineJointMotor2D(){} // RVA: 0x7FFACAF65EC0
        public void __get_name__SystemString(){} // RVA: 0x7FFACAF65FF0
        public void __get_reactionForce__UnityEngineVector2(){} // RVA: 0x7FFACAF66140
        public void __get_reactionTorque__SystemSingle(){} // RVA: 0x7FFACAF66270
        public void __get_referenceAngle__SystemSingle(){} // RVA: 0x7FFACAF66390
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAF664B0
        public void __get_useLimits__SystemBoolean(){} // RVA: 0x7FFACAF665F0
        public void __get_useMotor__SystemBoolean(){} // RVA: 0x7FFACAF66710
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF66830
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF66B30
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF66D20
        public void __set_anchor__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAF67020
        public void __set_angle__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF67140
        public void __set_autoConfigureAngle__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF67270
        public void __set_autoConfigureConnectedAnchor__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF673A0
        public void __set_breakAction__UnityEngineJointBreakAction2D__SystemVoid(){} // RVA: 0x7FFACAF674D0
        public void __set_breakForce__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF675F0
        public void __set_breakTorque__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF67720
        public void __set_connectedAnchor__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACAF67850
        public void __set_connectedBody__UnityEngineRigidbody2D__SystemVoid(){} // RVA: 0x7FFACAF67970
        public void __set_enableCollision__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF67AC0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF67BF0
        public void __set_limits__UnityEngineJointTranslationLimits2D__SystemVoid(){} // RVA: 0x7FFACAF67D20
        public void __set_motor__UnityEngineJointMotor2D__SystemVoid(){} // RVA: 0x7FFACAF67E40
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAF67F60
        public void __set_useLimits__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF680B0
        public void __set_useMotor__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF681E0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACAF68310
    }

    public class ExternUnityEngineSliderJoint2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF6C030
        public void .ctor(){} // RVA: 0x7FFACAF6C070
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF6C440
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF6C570
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAF6C680
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF6C760
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF6C840
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF6C910
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAF6CA60
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF6CB00
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF6CC00
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAF6CD20
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF6CE30
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF6CF50
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF6D040
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAF6D120
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF6D240
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF6D3D0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAF6D520
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAF6D650
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF6D770
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF6D8E0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAF6DA20
        public void __Get__SystemInt32__UnityEngineSliderJoint2D(){} // RVA: 0x7FFACAF6DB40
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAF6DC80
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAF6DCF0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF6DE10
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF6DF90
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF6E0F0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAF6E220
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF6E340
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF6E4A0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF6E5F0
        public void __Set__SystemInt32_UnityEngineSliderJoint2D__SystemVoid(){} // RVA: 0x7FFACAF6E710
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF6E8A0
        public void __ctor__SystemInt32__UnityEngineSliderJoint2DArray(){} // RVA: 0x7FFACAF6E990
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAF6EA80
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAF6EB20
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAF6EBC0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAF6EC60
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAF6ED00
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAF6EDA0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAF6EE40
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAF6EF20
    }

    public class ExternUnityEngineSoftJointLimit : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF70E40
        public void .ctor(){} // RVA: 0x7FFACAF70E80
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF71250
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF71380
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF71490
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF715D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF71680
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF71770
        public void __get_bounciness__SystemSingle(){} // RVA: 0x7FFACAF71820
        public void __get_contactDistance__SystemSingle(){} // RVA: 0x7FFACAF718D0
        public void __get_limit__SystemSingle(){} // RVA: 0x7FFACAF71970
        public void __set_bounciness__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF71A20
        public void __set_contactDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF71B20
        public void __set_limit__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF71C00
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAF71D00
    }

    public class ExternUnityEngineSoftJointLimitArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF72660
        public void .ctor(){} // RVA: 0x7FFACAF726A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF72A70
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF72BA0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAF72CB0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF72D90
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF72E70
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF72F40
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAF73090
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF73130
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF73230
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAF73350
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF73460
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF73580
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF73670
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAF73750
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF73870
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF73A00
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAF73B50
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAF73C80
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF73DA0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF73F10
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAF74050
        public void __Get__SystemInt32__UnityEngineSoftJointLimit(){} // RVA: 0x7FFACAF74170
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAF74270
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAF742E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF74400
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF74580
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF746E0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAF74810
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF74930
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF74A90
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF74BE0
        public void __Set__SystemInt32_UnityEngineSoftJointLimit__SystemVoid(){} // RVA: 0x7FFACAF74D00
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF74E10
        public void __ctor__SystemInt32__UnityEngineSoftJointLimitArray(){} // RVA: 0x7FFACAF74F00
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAF750A0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAF75140
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAF751E0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAF75280
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAF75320
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAF753C0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAF75460
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAF75540
    }

    public class ExternUnityEngineSoftJointLimitSpring : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF77460
        public void .ctor(){} // RVA: 0x7FFACAF774A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF77870
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF779A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF77AB0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF77BF0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF77CA0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF77D90
        public void __get_damper__SystemSingle(){} // RVA: 0x7FFACAF77E40
        public void __get_spring__SystemSingle(){} // RVA: 0x7FFACAF77EE0
        public void __set_damper__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF77F80
        public void __set_spring__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF78050
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAF78120
    }

    public class ExternUnityEngineSoftJointLimitSpringArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF78900
        public void .ctor(){} // RVA: 0x7FFACAF78940
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF78D10
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF78E40
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAF78F50
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF79030
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF79110
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF791E0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAF79330
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF793D0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF794D0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAF795F0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF79700
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF79820
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF79910
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAF799F0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF79B10
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF79CA0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAF79DF0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAF79F20
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF7A040
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF7A1B0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAF7A2F0
        public void __Get__SystemInt32__UnityEngineSoftJointLimitSpring(){} // RVA: 0x7FFACAF7A410
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAF7A4F0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAF7A560
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF7A680
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF7A800
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF7A960
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAF7AA90
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF7ABB0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF7AD10
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF7AE60
        public void __Set__SystemInt32_UnityEngineSoftJointLimitSpring__SystemVoid(){} // RVA: 0x7FFACAF7AF80
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF7B080
        public void __ctor__SystemInt32__UnityEngineSoftJointLimitSpringArray(){} // RVA: 0x7FFACAF7B170
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAF7B310
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAF7B3B0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAF7B450
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAF7B4F0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAF7B590
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAF7B630
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAF7B6D0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAF7B7B0
    }

    public class ExternUnityEngineSphereCollider : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF7D6D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACAF7D710
        public void .ctor(){} // RVA: 0x7FFACAF7D7C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF7DB90
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF7DCC0
        public void __ClosestPointOnBounds__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACAF7DDD0
        public void __ClosestPoint__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACAF7DFC0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF7E150
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAF7E320
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAF7E410
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAF7E6C0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAF7E820
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACAF7E940
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACAF7EA30
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAF7ECB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAF7EDA0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAF7F050
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAF7F1B0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACAF7F2D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACAF7F3C0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACAF7F640
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAF7F7B0
        public void __GetComponent__T(){} // RVA: 0x7FFACAF7F8D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACAF7F9B0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAF7FC00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAF7FCF0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF80020
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF80110
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAF80450
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAF80540
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAF80850
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAF809C0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAF80AF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAF80BE0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF80ED0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF80FC0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAF81300
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAF813F0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAF81700
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAF81870
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACAF819B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACAF81AA0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAF81D90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAF81E80
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAF82170
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAF822C0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACAF823F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACAF824E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF82790
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAF828F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF82A40
        public void __Raycast__UnityEngineRay_UnityEngineRaycastHitRef_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACAF82B30
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF82D80
        public void __get_attachedArticulationBody__UnityEngineArticulationBody(){} // RVA: 0x7FFACAF82ED0
        public void __get_attachedRigidbody__UnityEngineRigidbody(){} // RVA: 0x7FFACAF83010
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACAF83150
        public void __get_center__UnityEngineVector3(){} // RVA: 0x7FFACAF832A0
        public void __get_contactOffset__SystemSingle(){} // RVA: 0x7FFACAF833E0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACAF83500
        public void __get_excludeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACAF83620
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACAF83750
        public void __get_hasModifiableContacts__SystemBoolean(){} // RVA: 0x7FFACAF83890
        public void __get_includeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACAF839B0
        public void __get_isTrigger__SystemBoolean(){} // RVA: 0x7FFACAF83AE0
        public void __get_layerOverridePriority__SystemInt32(){} // RVA: 0x7FFACAF83C00
        public void __get_material__UnityEnginePhysicMaterial(){} // RVA: 0x7FFACAF83D20
        public void __get_name__SystemString(){} // RVA: 0x7FFACAF83E60
        public void __get_providesContacts__SystemBoolean(){} // RVA: 0x7FFACAF83FB0
        public void __get_radius__SystemSingle(){} // RVA: 0x7FFACAF840D0
        public void __get_sharedMaterial__UnityEnginePhysicMaterial(){} // RVA: 0x7FFACAF841F0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAF84330
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF84470
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF84770
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF84960
        public void __set_center__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAF84C60
        public void __set_contactOffset__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF84DA0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF84ED0
        public void __set_excludeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACAF85000
        public void __set_hasModifiableContacts__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF85120
        public void __set_includeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACAF85250
        public void __set_isTrigger__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF85370
        public void __set_layerOverridePriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF854A0
        public void __set_material__UnityEnginePhysicMaterial__SystemVoid(){} // RVA: 0x7FFACAF855C0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAF85710
        public void __set_providesContacts__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF85860
        public void __set_radius__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF85990
        public void __set_sharedMaterial__UnityEnginePhysicMaterial__SystemVoid(){} // RVA: 0x7FFACAF85AC0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACAF85C10
    }

    public class ExternUnityEngineSphereColliderArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF890E0
        public void .ctor(){} // RVA: 0x7FFACAF89120
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF894F0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF89620
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAF89730
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF89810
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF898F0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF899C0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAF89B10
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF89BB0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF89CB0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAF89DD0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF89EE0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF8A000
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF8A0F0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAF8A1D0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF8A2F0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF8A480
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAF8A5D0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAF8A700
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF8A820
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF8A990
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAF8AAD0
        public void __Get__SystemInt32__UnityEngineSphereCollider(){} // RVA: 0x7FFACAF8ABF0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAF8AD30
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAF8ADA0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF8AEC0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF8B040
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF8B1A0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAF8B2D0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF8B3F0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF8B550
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF8B6A0
        public void __Set__SystemInt32_UnityEngineSphereCollider__SystemVoid(){} // RVA: 0x7FFACAF8B7C0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF8B980
        public void __ctor__SystemInt32__UnityEngineSphereColliderArray(){} // RVA: 0x7FFACAF8BA70
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAF8BB60
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAF8BC00
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAF8BCA0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAF8BD40
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAF8BDE0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAF8BE80
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAF8BF20
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAF8C000
    }

    public class ExternUnityEngineSpringJoint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF8DF20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACAF8DF60
        public void .ctor(){} // RVA: 0x7FFACAF8E010
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF8E3E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF8E510
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF8E620
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAF8E7F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAF8E8E0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAF8EB90
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAF8ECF0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACAF8EE10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACAF8EF00
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAF8F180
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAF8F270
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAF8F520
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAF8F680
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACAF8F7A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACAF8F890
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACAF8FB10
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAF8FC80
        public void __GetComponent__T(){} // RVA: 0x7FFACAF8FDA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACAF8FE80
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAF900D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAF901C0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF904F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF905E0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAF90920
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAF90A10
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAF90D20
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAF90E90
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAF90FC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAF910B0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF913A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAF91490
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAF917D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAF918C0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAF91BD0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAF91D40
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACAF91E80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACAF91F70
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAF92260
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAF92350
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAF92640
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAF92790
        public void __GetComponents__TArray(){} // RVA: 0x7FFACAF928C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACAF929B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF92C60
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAF92DC0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF92F10
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF93000
        public void __get_anchor__UnityEngineVector3(){} // RVA: 0x7FFACAF93150
        public void __get_autoConfigureConnectedAnchor__SystemBoolean(){} // RVA: 0x7FFACAF93290
        public void __get_axis__UnityEngineVector3(){} // RVA: 0x7FFACAF933B0
        public void __get_breakForce__SystemSingle(){} // RVA: 0x7FFACAF934F0
        public void __get_breakTorque__SystemSingle(){} // RVA: 0x7FFACAF93610
        public void __get_connectedAnchor__UnityEngineVector3(){} // RVA: 0x7FFACAF93730
        public void __get_connectedArticulationBody__UnityEngineArticulationBody(){} // RVA: 0x7FFACAF93870
        public void __get_connectedBody__UnityEngineRigidbody(){} // RVA: 0x7FFACAF939B0
        public void __get_connectedMassScale__SystemSingle(){} // RVA: 0x7FFACAF93AF0
        public void __get_currentForce__UnityEngineVector3(){} // RVA: 0x7FFACAF93C10
        public void __get_currentTorque__UnityEngineVector3(){} // RVA: 0x7FFACAF93D00
        public void __get_damper__SystemSingle(){} // RVA: 0x7FFACAF93DF0
        public void __get_enableCollision__SystemBoolean(){} // RVA: 0x7FFACAF93F10
        public void __get_enablePreprocessing__SystemBoolean(){} // RVA: 0x7FFACAF94030
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACAF94150
        public void __get_massScale__SystemSingle(){} // RVA: 0x7FFACAF94290
        public void __get_maxDistance__SystemSingle(){} // RVA: 0x7FFACAF943B0
        public void __get_minDistance__SystemSingle(){} // RVA: 0x7FFACAF944D0
        public void __get_name__SystemString(){} // RVA: 0x7FFACAF945F0
        public void __get_spring__SystemSingle(){} // RVA: 0x7FFACAF94740
        public void __get_tolerance__SystemSingle(){} // RVA: 0x7FFACAF94860
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAF94980
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF94AC0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF94DC0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAF94FB0
        public void __set_anchor__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAF952B0
        public void __set_autoConfigureConnectedAnchor__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF953F0
        public void __set_axis__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAF95520
        public void __set_breakForce__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF95660
        public void __set_breakTorque__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF95790
        public void __set_connectedAnchor__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAF958C0
        public void __set_connectedArticulationBody__UnityEngineArticulationBody__SystemVoid(){} // RVA: 0x7FFACAF95A00
        public void __set_connectedBody__UnityEngineRigidbody__SystemVoid(){} // RVA: 0x7FFACAF95B50
        public void __set_connectedMassScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF95CA0
        public void __set_damper__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF95DD0
        public void __set_enableCollision__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF95F00
        public void __set_enablePreprocessing__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAF96030
        public void __set_massScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF96160
        public void __set_maxDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF96290
        public void __set_minDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF963C0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAF964F0
        public void __set_spring__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF96640
        public void __set_tolerance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAF96770
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACAF968A0
    }

    public class ExternUnityEngineSpringJointArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF9A200
        public void .ctor(){} // RVA: 0x7FFACAF9A240
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF9A610
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF9A740
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAF9A850
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF9A930
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF9AA10
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAF9AAE0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAF9AC30
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAF9ACD0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF9ADD0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAF9AEF0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF9B000
        public void __GetType__SystemType(){} // RVA: 0x7FFACAF9B120
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAF9B210
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAF9B2F0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF9B410
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAF9B5A0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAF9B6F0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAF9B820
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF9B940
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAF9BAB0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAF9BBF0
        public void __Get__SystemInt32__UnityEngineSpringJoint(){} // RVA: 0x7FFACAF9BD10
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAF9BE50
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAF9BEC0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF9BFE0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF9C160
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAF9C2C0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAF9C3F0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF9C510
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF9C670
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAF9C7C0
        public void __Set__SystemInt32_UnityEngineSpringJoint__SystemVoid(){} // RVA: 0x7FFACAF9C8E0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAF9CAA0
        public void __ctor__SystemInt32__UnityEngineSpringJointArray(){} // RVA: 0x7FFACAF9CB90
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAF9CC80
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAF9CD20
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAF9CDC0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAF9CE60
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAF9CF00
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAF9CFA0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAF9D040
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAF9D120
    }

    public class ExternUnityEngineSprite : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAF9F040
        public void .ctor(){} // RVA: 0x7FFACAF9F080
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAF9F450
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAF9F580
        public void __Create__UnityEngineTexture2D_UnityEngineRect_UnityEngineVector2_SystemSingle_SystemUInt32_UnityEngineSpriteMeshType_UnityEngineVector4_SystemBoolean_UnityEngineSecondarySpriteTextureArray__UnityEngineSprite(){} // RVA: 0x7FFACAF9F690
        public void __Create__UnityEngineTexture2D_UnityEngineRect_UnityEngineVector2_SystemSingle_SystemUInt32_UnityEngineSpriteMeshType_UnityEngineVector4_SystemBoolean__UnityEngineSprite(){} // RVA: 0x7FFACAF9F9E0
        public void __Create__UnityEngineTexture2D_UnityEngineRect_UnityEngineVector2_SystemSingle_SystemUInt32_UnityEngineSpriteMeshType_UnityEngineVector4__UnityEngineSprite(){} // RVA: 0x7FFACAF9FCF0
        public void __Create__UnityEngineTexture2D_UnityEngineRect_UnityEngineVector2_SystemSingle_SystemUInt32_UnityEngineSpriteMeshType__UnityEngineSprite(){} // RVA: 0x7FFACAF9FFC0
        public void __Create__UnityEngineTexture2D_UnityEngineRect_UnityEngineVector2_SystemSingle_SystemUInt32__UnityEngineSprite(){} // RVA: 0x7FFACAFA0220
        public void __Create__UnityEngineTexture2D_UnityEngineRect_UnityEngineVector2_SystemSingle__UnityEngineSprite(){} // RVA: 0x7FFACAFA0450
        public void __Create__UnityEngineTexture2D_UnityEngineRect_UnityEngineVector2__UnityEngineSprite(){} // RVA: 0x7FFACAFA0640
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAFA07F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAFA09C0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAFA0B20
        public void __GetPhysicsShapeCount__SystemInt32(){} // RVA: 0x7FFACAFA0C70
        public void __GetPhysicsShapePointCount__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAFA0D90
        public void __GetPhysicsShape__SystemInt32_SystemCollectionsGenericListUnityEngineVector2__SystemInt32(){} // RVA: 0x7FFACAFA0FF0
        public void __GetSecondaryTextureCount__SystemInt32(){} // RVA: 0x7FFACAFA12C0
        public void __GetSecondaryTextures__UnityEngineSecondarySpriteTextureArray__SystemInt32(){} // RVA: 0x7FFACAFA13E0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAFA1540
        public void __OverrideGeometry__UnityEngineVector2Array_SystemUInt16Array__SystemVoid(){} // RVA: 0x7FFACAFA1630
        public void __OverridePhysicsShape__SystemCollectionsGenericIListUnityEngineVector2Array__SystemVoid(){} // RVA: 0x7FFACAFA1780
        public void __ToString__SystemString(){} // RVA: 0x7FFACAFA1860
        public void __get_associatedAlphaSplitTexture__UnityEngineTexture2D(){} // RVA: 0x7FFACAFA19B0
        public void __get_border__UnityEngineVector4(){} // RVA: 0x7FFACAFA1AF0
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACAFA1C30
        public void __get_name__SystemString(){} // RVA: 0x7FFACAFA1D80
        public void __get_packed__SystemBoolean(){} // RVA: 0x7FFACAFA1ED0
        public void __get_packingMode__UnityEngineSpritePackingMode(){} // RVA: 0x7FFACAFA2000
        public void __get_packingRotation__UnityEngineSpritePackingRotation(){} // RVA: 0x7FFACAFA2120
        public void __get_pivot__UnityEngineVector2(){} // RVA: 0x7FFACAFA2240
        public void __get_pixelsPerUnit__SystemSingle(){} // RVA: 0x7FFACAFA2370
        public void __get_rect__UnityEngineRect(){} // RVA: 0x7FFACAFA2490
        public void __get_spriteAtlasTextureScale__SystemSingle(){} // RVA: 0x7FFACAFA25D0
        public void __get_textureRectOffset__UnityEngineVector2(){} // RVA: 0x7FFACAFA26F0
        public void __get_textureRect__UnityEngineRect(){} // RVA: 0x7FFACAFA2820
        public void __get_texture__UnityEngineTexture2D(){} // RVA: 0x7FFACAFA2960
        public void __get_triangles__SystemUInt16Array(){} // RVA: 0x7FFACAFA2AA0
        public void __get_uv__UnityEngineVector2Array(){} // RVA: 0x7FFACAFA2BC0
        public void __get_vertices__UnityEngineVector2Array(){} // RVA: 0x7FFACAFA2CE0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAFA2E00
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAFA3100
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAFA32F0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAFA35F0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAFA3740
    }

    public class ExternUnityEngineSpriteArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAFA5720
        public void .ctor(){} // RVA: 0x7FFACAFA5760
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAFA5B30
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAFA5C60
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAFA5D70
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAFA5E50
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAFA5F30
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAFA6000
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAFA6150
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAFA61F0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAFA62F0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAFA6410
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAFA6520
        public void __GetType__SystemType(){} // RVA: 0x7FFACAFA6640
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAFA6730
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAFA6810
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAFA6930
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAFA6AC0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAFA6C10
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAFA6D40
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAFA6E60
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAFA6FD0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAFA7110
        public void __Get__SystemInt32__UnityEngineSprite(){} // RVA: 0x7FFACAFA7230
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAFA7370
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAFA73E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAFA7500
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAFA7680
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAFA77E0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAFA7910
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAFA7A30
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAFA7B90
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAFA7CE0
        public void __Set__SystemInt32_UnityEngineSprite__SystemVoid(){} // RVA: 0x7FFACAFA7E00
        public void __ToString__SystemString(){} // RVA: 0x7FFACAFA7F90
        public void __ctor__SystemInt32__UnityEngineSpriteArray(){} // RVA: 0x7FFACAFA8080
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAFA8170
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAFA8210
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAFA82B0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAFA8350
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAFA83F0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAFA8490
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAFA8530
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAFA8610
    }

    public class ExternUnityEngineSpritePackingMode : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAFAA530
        public void .ctor(){} // RVA: 0x7FFACAFAA570
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAFAA940
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAFAAA70
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x7FFACAFAAB80
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAFAACB0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAFAADF0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAFAAEA0
        public void __HasFlag__SystemEnum__SystemBoolean(){} // RVA: 0x7FFACAFAAF90
        public void __ToString__SystemString(){} // RVA: 0x7FFACAFAB060
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFACAFAB110
        public void __get_Rectangle__UnityEngineSpritePackingMode(){} // RVA: 0x7FFACAFAB1E0
        public void __get_Tight__UnityEngineSpritePackingMode(){} // RVA: 0x7FFACAFAB250
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAFAB2C0
    }

}