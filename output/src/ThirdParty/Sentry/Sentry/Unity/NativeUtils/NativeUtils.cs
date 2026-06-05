// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.NativeUtils
// Classes: 2
// Methods: 41

namespace ThirdParty.Sentry.Sentry.Unity.NativeUtils
{
    public class C
    {
        // ── Methods ──
        public void SetValueIfNotNull(){} // RVA: 0x7FFAF8E35630 | overloaded x4
        public void GetValueOrNul(){} // RVA: 0x7FFAF8E35740
        public void GetValueString(){} // RVA: 0x7FFAF8E35870
        public void GetValueInt(){} // RVA: 0x7FFAF8E359F0
        public void GetValueDouble(){} // RVA: 0x7FFAF8E35B50
        public void sentry_value_new_object(){} // RVA: 0x7FFAF8E35CC0
        public void sentry_value_new_null(){} // RVA: 0x7FFAF8E35D30
        public void sentry_value_new_bool(){} // RVA: 0x7FFAF8E35DA0
        public void sentry_value_new_double(){} // RVA: 0x7FFAF8E35E20
        public void sentry_value_new_int32(){} // RVA: 0x7FFAF8E35EA0
        public void sentry_value_new_string(){} // RVA: 0x7FFAF8E35F20
        public void sentry_value_new_breadcrumb(){} // RVA: 0x7FFAF8E35FD0
        public void sentry_value_set_by_key(){} // RVA: 0x7FFAF8E360A0
        public void IsNull(){} // RVA: 0x7FFAF8E36160
        public void sentry_value_is_null(){} // RVA: 0x7FFAF8E361C0
        public void sentry_value_as_int32(){} // RVA: 0x7FFAF8E36240
        public void sentry_value_as_double(){} // RVA: 0x7FFAF8E362C0
        public void sentry_value_as_string(){} // RVA: 0x7FFAF8E36340
        public void sentry_value_get_length(){} // RVA: 0x7FFAF8E363C0
        public void sentry_value_get_by_index(){} // RVA: 0x7FFAF8E36440
        public void sentry_value_get_by_key(){} // RVA: 0x7FFAF8E364D0
        public void sentry_set_context(){} // RVA: 0x7FFAF8E36580
        public void sentry_add_breadcrumb(){} // RVA: 0x7FFAF8E36630
        public void sentry_set_tag(){} // RVA: 0x7FFAF8E366B0
        public void sentry_remove_tag(){} // RVA: 0x7FFAF8E36770
        public void sentry_set_user(){} // RVA: 0x7FFAF8E36810
        public void sentry_remove_user(){} // RVA: 0x7FFAF8E36890
        public void sentry_set_extra(){} // RVA: 0x7FFAF8E36900
        public void sentry_remove_extra(){} // RVA: 0x7FFAF8E369B0
        public void LoadDebugImages(){} // RVA: 0x7FFAF8E36A50
        public void sentry_get_modules_list(){} // RVA: 0x7FFAF8E37130
        public void sentry_value_decref(){} // RVA: 0x7FFAF8E371A0
        public void .cctor(){} // RVA: 0x7FFAF8E37220
    }

    public class ContextWriter
    {
        // ── Methods ──
        public void WriteApp(){} // RVA: 0x7FFAF8E37360
        public void WriteOS(){} // RVA: 0x7FFAF8E374E0
        public void WriteDevice(){} // RVA: 0x7FFAF8E375E0
        public void WriteGpu(){} // RVA: 0x7FFAF8E37B50
        public void WriteUnity(){} // RVA: 0x7FFAF8E38070
    }

}