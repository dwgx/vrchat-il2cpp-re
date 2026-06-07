// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.NativeUtils
// Classes: 2
// Methods: 41

namespace ThirdParty.Sentry.Sentry.Unity.NativeUtils
{
    public class C
    {
        // ── Methods ──
        public void SetValueIfNotNull(){} // RVA: 0x6385630 | overloaded x4
        public void GetValueOrNul(){} // RVA: 0x6385740
        public void GetValueString(){} // RVA: 0x6385870
        public void GetValueInt(){} // RVA: 0x63859F0
        public void GetValueDouble(){} // RVA: 0x6385B50
        public void sentry_value_new_object(){} // RVA: 0x6385CC0
        public void sentry_value_new_null(){} // RVA: 0x6385D30
        public void sentry_value_new_bool(){} // RVA: 0x6385DA0
        public void sentry_value_new_double(){} // RVA: 0x6385E20
        public void sentry_value_new_int32(){} // RVA: 0x6385EA0
        public void sentry_value_new_string(){} // RVA: 0x6385F20
        public void sentry_value_new_breadcrumb(){} // RVA: 0x6385FD0
        public void sentry_value_set_by_key(){} // RVA: 0x63860A0
        public void IsNull(){} // RVA: 0x6386160
        public void sentry_value_is_null(){} // RVA: 0x63861C0
        public void sentry_value_as_int32(){} // RVA: 0x6386240
        public void sentry_value_as_double(){} // RVA: 0x63862C0
        public void sentry_value_as_string(){} // RVA: 0x6386340
        public void sentry_value_get_length(){} // RVA: 0x63863C0
        public void sentry_value_get_by_index(){} // RVA: 0x6386440
        public void sentry_value_get_by_key(){} // RVA: 0x63864D0
        public void sentry_set_context(){} // RVA: 0x6386580
        public void sentry_add_breadcrumb(){} // RVA: 0x6386630
        public void sentry_set_tag(){} // RVA: 0x63866B0
        public void sentry_remove_tag(){} // RVA: 0x6386770
        public void sentry_set_user(){} // RVA: 0x6386810
        public void sentry_remove_user(){} // RVA: 0x6386890
        public void sentry_set_extra(){} // RVA: 0x6386900
        public void sentry_remove_extra(){} // RVA: 0x63869B0
        public void LoadDebugImages(){} // RVA: 0x6386A50
        public void sentry_get_modules_list(){} // RVA: 0x6387130
        public void sentry_value_decref(){} // RVA: 0x63871A0
        public void .cctor(){} // RVA: 0x6387220
    }

    public class ContextWriter
    {
        // ── Methods ──
        public void WriteApp(){} // RVA: 0x6387360
        public void WriteOS(){} // RVA: 0x63874E0
        public void WriteDevice(){} // RVA: 0x63875E0
        public void WriteGpu(){} // RVA: 0x6387B50
        public void WriteUnity(){} // RVA: 0x6388070
    }

}