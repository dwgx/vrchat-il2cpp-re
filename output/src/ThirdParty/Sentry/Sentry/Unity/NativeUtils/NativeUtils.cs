// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.NativeUtils
// Classes: 2
// Methods: 41

namespace ThirdParty.Sentry.Sentry.Unity.NativeUtils
{
    public class C : Object
    {
        public System.Lazy`1<System.Collections.Generic.IEnumerable`1<Sentry.Protocol.DebugImage>> DebugImages;

        // ── Methods ──
        public void SetValueIfNotNull(){} // RVA: 0x7FFAC8B1C9E0 | overloaded x4
        public void GetValueOrNul(){} // RVA: 0x7FFAC8B1CAF0
        public void GetValueString(){} // RVA: 0x7FFAC8B1CC20
        public void GetValueInt(){} // RVA: 0x7FFAC8B1CDA0
        public void GetValueDouble(){} // RVA: 0x7FFAC8B1CF00
        public void sentry_value_new_object(){} // RVA: 0x7FFAC8B1D070
        public void sentry_value_new_null(){} // RVA: 0x7FFAC8B1D0E0
        public void sentry_value_new_bool(){} // RVA: 0x7FFAC8B1D150
        public void sentry_value_new_double(){} // RVA: 0x7FFAC8B1D1D0
        public void sentry_value_new_int32(){} // RVA: 0x7FFAC8B1D250
        public void sentry_value_new_string(){} // RVA: 0x7FFAC8B1D2D0
        public void sentry_value_new_breadcrumb(){} // RVA: 0x7FFAC8B1D380
        public void sentry_value_set_by_key(){} // RVA: 0x7FFAC8B1D450
        public void IsNull(){} // RVA: 0x7FFAC8B1D510
        public void sentry_value_is_null(){} // RVA: 0x7FFAC8B1D570
        public void sentry_value_as_int32(){} // RVA: 0x7FFAC8B1D5F0
        public void sentry_value_as_double(){} // RVA: 0x7FFAC8B1D670
        public void sentry_value_as_string(){} // RVA: 0x7FFAC8B1D6F0
        public void sentry_value_get_length(){} // RVA: 0x7FFAC8B1D770
        public void sentry_value_get_by_index(){} // RVA: 0x7FFAC8B1D7F0
        public void sentry_value_get_by_key(){} // RVA: 0x7FFAC8B1D880
        public void sentry_set_context(){} // RVA: 0x7FFAC8B1D930
        public void sentry_add_breadcrumb(){} // RVA: 0x7FFAC8B1D9E0
        public void sentry_set_tag(){} // RVA: 0x7FFAC8B1DA60
        public void sentry_remove_tag(){} // RVA: 0x7FFAC8B1DB20
        public void sentry_set_user(){} // RVA: 0x7FFAC8B1DBC0
        public void sentry_remove_user(){} // RVA: 0x7FFAC8B1DC40
        public void sentry_set_extra(){} // RVA: 0x7FFAC8B1DCB0
        public void sentry_remove_extra(){} // RVA: 0x7FFAC8B1DD60
        public void LoadDebugImages(){} // RVA: 0x7FFAC8B1DE00
        public void sentry_get_modules_list(){} // RVA: 0x7FFAC8B1E4E0
        public void sentry_value_decref(){} // RVA: 0x7FFAC8B1E550
        public void .cctor(){} // RVA: 0x7FFAC8B1E5D0
    }

    public class ContextWriter : Object
    {
        // ── Methods ──
        public void WriteApp(){} // RVA: 0x7FFAC8B1E710
        public void WriteOS(){} // RVA: 0x7FFAC8B1E890
        public void WriteDevice(){} // RVA: 0x7FFAC8B1E990
        public void WriteGpu(){} // RVA: 0x7FFAC8B1EF00
        public void WriteUnity(){} // RVA: 0x7FFAC8B1F420
    }

}