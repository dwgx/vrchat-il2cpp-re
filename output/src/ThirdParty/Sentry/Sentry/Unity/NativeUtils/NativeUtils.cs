// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.NativeUtils
// Classes: 2
// Methods: 38

namespace ThirdParty.Sentry.Sentry.Unity.NativeUtils
{
    public class C : Object
    {
        public object DebugImages;

        // ── Methods ──
        public void SetValueIfNotNull(){} // RVA: 0x6DF2C80
        public void GetValueOrNul(){} // RVA: 0x6DF2D90
        public void GetValueString(){} // RVA: 0x6DF2EC0
        public void GetValueInt(){} // RVA: 0x6DF3040
        public void GetValueDouble(){} // RVA: 0x6DF31A0
        public void sentry_value_new_object(){} // RVA: 0x6DF3310
        public void sentry_value_new_null(){} // RVA: 0x6DF3380
        public void sentry_value_new_bool(){} // RVA: 0x6DF33F0
        public void sentry_value_new_double(){} // RVA: 0x6DF3470
        public void sentry_value_new_int32(){} // RVA: 0x6DF34F0
        public void sentry_value_new_string(){} // RVA: 0x6DF3570
        public void sentry_value_new_breadcrumb(){} // RVA: 0x6DF3620
        public void sentry_value_set_by_key(){} // RVA: 0x6DF36F0
        public void IsNull(){} // RVA: 0x6DF37B0
        public void sentry_value_is_null(){} // RVA: 0x6DF3810
        public void sentry_value_as_int32(){} // RVA: 0x6DF3890
        public void sentry_value_as_double(){} // RVA: 0x6DF3910
        public void sentry_value_as_string(){} // RVA: 0x6DF3990
        public void sentry_value_get_length(){} // RVA: 0x6DF3A10
        public void sentry_value_get_by_index(){} // RVA: 0x6DF3A90
        public void sentry_value_get_by_key(){} // RVA: 0x6DF3B20
        public void sentry_set_context(){} // RVA: 0x6DF3BD0
        public void sentry_add_breadcrumb(){} // RVA: 0x6DF3C80
        public void sentry_set_tag(){} // RVA: 0x6DF3D00
        public void sentry_remove_tag(){} // RVA: 0x6DF3DC0
        public void sentry_set_user(){} // RVA: 0x6DF3E60
        public void sentry_remove_user(){} // RVA: 0x6DF3EE0
        public void sentry_set_extra(){} // RVA: 0x6DF3F50
        public void sentry_remove_extra(){} // RVA: 0x6DF4000
        public void LoadDebugImages(){} // RVA: 0x6DF40A0
        public void sentry_get_modules_list(){} // RVA: 0x6DF4780
        public void sentry_value_decref(){} // RVA: 0x6DF47F0
        public void .cctor(){} // RVA: 0x6DF4870
    }

    public class ContextWriter : Object
    {
        // ── Methods ──
        public void WriteApp(){} // RVA: 0x6DF49B0
        public void WriteOS(){} // RVA: 0x6DF4B30
        public void WriteDevice(){} // RVA: 0x6DF4C30
        public void WriteGpu(){} // RVA: 0x6DF51A0
        public void WriteUnity(){} // RVA: 0x6DF56C0
    }

}