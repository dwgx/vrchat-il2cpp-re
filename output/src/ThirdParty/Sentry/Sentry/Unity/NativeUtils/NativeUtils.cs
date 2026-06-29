// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.NativeUtils
// Classes: 2
// Methods: 38

namespace ThirdParty.Sentry.Sentry.Unity.NativeUtils
{
    public class C : Object
    {
        // ── Methods ──
        public void SetValueIfNotNull(){} // RVA: 0x7AE172050
        public void GetValueOrNul(){} // RVA: 0x7AE172160
        public void GetValueString(){} // RVA: 0x7AE172290
        public void GetValueInt(){} // RVA: 0x7AE172410
        public void GetValueDouble(){} // RVA: 0x7AE172570
        public void sentry_value_new_object(){} // RVA: 0x7AE1726E0
        public void sentry_value_new_null(){} // RVA: 0x7AE172750
        public void sentry_value_new_bool(){} // RVA: 0x7AE1727C0
        public void sentry_value_new_double(){} // RVA: 0x7AE172840
        public void sentry_value_new_int32(){} // RVA: 0x7AE1728C0
        public void sentry_value_new_string(){} // RVA: 0x7AE172940
        public void sentry_value_new_breadcrumb(){} // RVA: 0x7AE1729F0
        public void sentry_value_set_by_key(){} // RVA: 0x7AE172AC0
        public void IsNull(){} // RVA: 0x7AE172B80
        public void sentry_value_is_null(){} // RVA: 0x7AE172BE0
        public void sentry_value_as_int32(){} // RVA: 0x7AE172C60
        public void sentry_value_as_double(){} // RVA: 0x7AE172CE0
        public void sentry_value_as_string(){} // RVA: 0x7AE172D60
        public void sentry_value_get_length(){} // RVA: 0x7AE172DE0
        public void sentry_value_get_by_index(){} // RVA: 0x7AE172E60
        public void sentry_value_get_by_key(){} // RVA: 0x7AE172EF0
        public void sentry_set_context(){} // RVA: 0x7AE172FA0
        public void sentry_add_breadcrumb(){} // RVA: 0x7AE173050
        public void sentry_set_tag(){} // RVA: 0x7AE1730D0
        public void sentry_remove_tag(){} // RVA: 0x7AE173190
        public void sentry_set_user(){} // RVA: 0x7AE173230
        public void sentry_remove_user(){} // RVA: 0x7AE1732B0
        public void sentry_set_extra(){} // RVA: 0x7AE173320
        public void sentry_remove_extra(){} // RVA: 0x7AE1733D0
        public void LoadDebugImages(){} // RVA: 0x7AE173470
        public void sentry_get_modules_list(){} // RVA: 0x7AE173B50
        public void sentry_value_decref(){} // RVA: 0x7AE173BC0
        public void .cctor(){} // RVA: 0x7AE173C40
    }

    public class ContextWriter : Object
    {
        // ── Methods ──
        public void WriteApp(){} // RVA: 0x7AE173D80
        public void WriteOS(){} // RVA: 0x7AE173F00
        public void WriteDevice(){} // RVA: 0x7AE174000
        public void WriteGpu(){} // RVA: 0x7AE174570
        public void WriteUnity(){} // RVA: 0x7AE174A90
    }

}