// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Transmtn.DTO.Notifications
// Classes: 3
// Methods: 71

namespace ThirdParty.Other.Transmtn.DTO.Notifications
{
    public class Notification : Object
    {
        public string id; // 0x10
        public int version; // 0x18
        public string type; // 0x20
        public string descriptor; // 0x28
        public string category; // 0x30
        public bool isSystem; // 0x38
        public string senderUserId; // 0x40
        public string senderUsername; // 0x48
        public string receiverUserId; // 0x50
        public string relatedNotificationsId; // 0x58
        public VRC.Localization.LocalizableString title; // 0x60
        public VRC.Localization.LocalizableString message; // 0x88
        public string imageUrl; // 0xB0
        public string link; // 0xB8
        public VRC.Localization.LocalizableString linkText; // 0xC0
        public System.Collections.Generic.Dictionary`2<string,string> data; // 0xE8
        public System.Collections.Generic.Dictionary`2<string,object>[] responses; // 0xF0
        public System.DateTime expiresAt; // 0xF8
        public System.Nullable`1<int> expiryAfterSeen; // 0x100
        public bool requireSeen; // 0x108
        public bool seen; // 0x109
        public bool ignoreDND; // 0x10A
        public bool canDelete; // 0x10B
        public System.DateTime createdAt; // 0x110
        public System.DateTime updatedAt; // 0x118
        public System.DateTime notificationType; // 0x120
        public Transmtn.DTO.Notifications.NotificationDetails created_at; // 0x128
        public object payload; // 0x130
        public System.Tuple`2<string,object>[] _notificationDataTuples;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0DEA40 | overloaded x2
        public void Create(){} // RVA: 0x7FFACC0DF1B0
        public void get_id(){} // RVA: 0x7FFAC2F3C380
        public void set_id(){} // RVA: 0x7FFAC2F22E30
        public void get_version(){} // RVA: 0x7FFAC3157800
        public void set_version(){} // RVA: 0x7FFAC392CD10
        public void get_type(){} // RVA: 0x7FFAC2F4F0C0
        public void set_type(){} // RVA: 0x7FFAC2F4F0D0
        public void get_descriptor(){} // RVA: 0x7FFAC2F4F130
        public void set_descriptor(){} // RVA: 0x7FFAC2F22E90
        public void get_category(){} // RVA: 0x7FFAC31D95E0
        public void set_category(){} // RVA: 0x7FFAC2F4F890
        public void get_isSystem(){} // RVA: 0x7FFAC31D95D0
        public void set_isSystem(){} // RVA: 0x7FFAC31D95C0
        public void get_senderUserId(){} // RVA: 0x7FFAC2F9E740
        public void set_senderUserId(){} // RVA: 0x7FFAC2F49200
        public void get_senderUsername(){} // RVA: 0x7FFAC2F9C730
        public void set_senderUsername(){} // RVA: 0x7FFAC2F9C740
        public void get_receiverUserId(){} // RVA: 0x7FFAC2FC20E0
        public void set_receiverUserId(){} // RVA: 0x7FFAC30794D0
        public void get_relatedNotificationsId(){} // RVA: 0x7FFAC2FE9500
        public void set_relatedNotificationsId(){} // RVA: 0x7FFAC2FE9510
        public void get_title(){} // RVA: 0x7FFAC4931870
        public void set_title(){} // RVA: 0x7FFAC4931690
        public void get_message(){} // RVA: 0x7FFAC4931700
        public void set_message(){} // RVA: 0x7FFAC4931890
        public void get_imageUrl(){} // RVA: 0x7FFAC2F8C040
        public void set_imageUrl(){} // RVA: 0x7FFAC2F8C050
        public void get_link(){} // RVA: 0x7FFAC2F8C0B0
        public void set_link(){} // RVA: 0x7FFAC2F8C0C0
        public void get_linkText(){} // RVA: 0x7FFAC34F7430
        public void set_linkText(){} // RVA: 0x7FFAC34F67B0
        public void get_data(){} // RVA: 0x7FFAC2FA2970
        public void set_data(){} // RVA: 0x7FFAC2FA2980
        public void get_responses(){} // RVA: 0x7FFAC2F8C2A0
        public void set_responses(){} // RVA: 0x7FFAC2F8C2B0
        public void get_expiresAt(){} // RVA: 0x7FFAC3331F50
        public void set_expiresAt(){} // RVA: 0x7FFAC6715870
        public void get_expiryAfterSeen(){} // RVA: 0x7FFAC34F6C80
        public void set_expiryAfterSeen(){} // RVA: 0x7FFAC4196020
        public void get_requireSeen(){} // RVA: 0x7FFAC4196030
        public void set_requireSeen(){} // RVA: 0x7FFAC4196040
        public void get_seen(){} // RVA: 0x7FFAC45CA6A0
        public void set_seen(){} // RVA: 0x7FFAC45C9FB0
        public void get_ignoreDND(){} // RVA: 0x7FFAC45C9D70
        public void set_ignoreDND(){} // RVA: 0x7FFAC45C9F80
        public void get_canDelete(){} // RVA: 0x7FFAC45C9F70
        public void set_canDelete(){} // RVA: 0x7FFAC45C9F40
        public void get_createdAt(){} // RVA: 0x7FFAC354B170
        public void set_createdAt(){} // RVA: 0x7FFAC8B66FB0
        public void get_updatedAt(){} // RVA: 0x7FFAC33BC6D0
        public void set_updatedAt(){} // RVA: 0x7FFACC0DF380
        public void get_notificationType(){} // RVA: 0x7FFAC2F4F0C0
        public void get_created_at(){} // RVA: 0x7FFACC0DF390
        public void set_created_at(){} // RVA: 0x7FFAC8B66FC0
        public void get_payload(){} // RVA: 0x7FFAC3544340
        public void set_payload(){} // RVA: 0x7FFAC39A79B0
        public void ToString(){} // RVA: 0x7FFACC0DF3B0
        public void Equals(){} // RVA: 0x7FFACC0DF840
        public void GetHashCode(){} // RVA: 0x7FFACC0DFBE0
        public void GetNotificationDataAsTuples(){} // RVA: 0x7FFACC0DFC10
        public void CompareTo(){} // RVA: 0x7FFACC0E00B0
        public void .cctor(){} // RVA: 0x7FFACC0E0350
    }

    public class NotificationDetails : Dictionary`2
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFACC0E0410
        public void ToString(){} // RVA: 0x7FFACC0E0500
        public void .ctor(){} // RVA: 0x7FFACC0E0800
    }

    public class NotificationDetailsConverter : JsonConverter
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFACC0E0840
        public void ReadJson(){} // RVA: 0x7FFACC0E0910
        public void WriteJson(){} // RVA: 0x7FFACC0E0C70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}