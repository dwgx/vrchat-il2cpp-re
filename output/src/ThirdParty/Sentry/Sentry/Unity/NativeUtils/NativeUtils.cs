// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.NativeUtils
// Classes: 2
// Methods: 41

namespace ThirdParty.Sentry.Sentry.Unity.NativeUtils
{
    public class C : Object
    {
        // ── Methods ──
        public void SetValueIfNotNull(){} // RVA: 0x7FFE86EC6050 | overloaded x4
        public void GetValueOrNul(){} // RVA: 0x7FFE86EC6160
        public void GetValueString(){} // RVA: 0x7FFE86EC6290
        public void GetValueInt(){} // RVA: 0x7FFE86EC6410
        public void GetValueDouble(){} // RVA: 0x7FFE86EC6570
        public void sentry_value_new_object(){} // RVA: 0x7FFE86EC66E0
        public void sentry_value_new_null(){} // RVA: 0x7FFE86EC6750
        public void sentry_value_new_bool(){} // RVA: 0x7FFE86EC67C0
        public void sentry_value_new_double(){} // RVA: 0x7FFE86EC6840
        public void sentry_value_new_int32(){} // RVA: 0x7FFE86EC68C0
        public void sentry_value_new_string(){} // RVA: 0x7FFE86EC6940
        public void sentry_value_new_breadcrumb(){} // RVA: 0x7FFE86EC69F0
        public void sentry_value_set_by_key(){} // RVA: 0x7FFE86EC6AC0
        public void IsNull(){} // RVA: 0x7FFE86EC6B80
        public void sentry_value_is_null(){} // RVA: 0x7FFE86EC6BE0
        public void sentry_value_as_int32(){} // RVA: 0x7FFE86EC6C60
        public void sentry_value_as_double(){} // RVA: 0x7FFE86EC6CE0
        public void sentry_value_as_string(){} // RVA: 0x7FFE86EC6D60
        public void sentry_value_get_length(){} // RVA: 0x7FFE86EC6DE0
        public void sentry_value_get_by_index(){} // RVA: 0x7FFE86EC6E60
        public void sentry_value_get_by_key(){} // RVA: 0x7FFE86EC6EF0
        public void sentry_set_context(){} // RVA: 0x7FFE86EC6FA0
        public void sentry_add_breadcrumb(){} // RVA: 0x7FFE86EC7050
        public void sentry_set_tag(){} // RVA: 0x7FFE86EC70D0
        public void sentry_remove_tag(){} // RVA: 0x7FFE86EC7190
        public void sentry_set_user(){} // RVA: 0x7FFE86EC7230
        public void sentry_remove_user(){} // RVA: 0x7FFE86EC72B0
        public void sentry_set_extra(){} // RVA: 0x7FFE86EC7320
        public void sentry_remove_extra(){} // RVA: 0x7FFE86EC73D0
        public void LoadDebugImages(){} // RVA: 0x7FFE86EC7470
        public void sentry_get_modules_list(){} // RVA: 0x7FFE86EC7B50
        public void sentry_value_decref(){} // RVA: 0x7FFE86EC7BC0
        public void .cctor(){} // RVA: 0x7FFE86EC7C40
    }

    public class ContextWriter : Object
    {
        // ── Methods ──
        public void WriteApp(){} // RVA: 0x7FFE86EC7D80
        public void WriteOS(){} // RVA: 0x7FFE86EC7F00
        public void WriteDevice(){} // RVA: 0x7FFE86EC8000
        public void WriteGpu(){} // RVA: 0x7FFE86EC8570
        public void WriteUnity(){} // RVA: 0x7FFE86EC8A90
    }

}