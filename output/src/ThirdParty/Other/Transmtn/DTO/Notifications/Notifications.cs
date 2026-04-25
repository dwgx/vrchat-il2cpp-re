// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Transmtn.DTO.Notifications
// Classes: 2
// Methods: 67

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
        public void .ctor(){} // RVA: 0x7FFD574FEA40 | overloaded x2
        public void Create(){} // RVA: 0x7FFD574FF1B0
        public void get_id(){} // RVA: 0x7FFD4E35C380
        public void set_id(){} // RVA: 0x7FFD4E342E30
        public void get_version(){} // RVA: 0x7FFD4E577800
        public void set_version(){} // RVA: 0x7FFD4ED4CD10
        public void get_type(){} // RVA: 0x7FFD4E36F0C0
        public void set_type(){} // RVA: 0x7FFD4E36F0D0
        public void get_descriptor(){} // RVA: 0x7FFD4E36F130
        public void set_descriptor(){} // RVA: 0x7FFD4E342E90
        public void get_category(){} // RVA: 0x7FFD4E5F95E0
        public void set_category(){} // RVA: 0x7FFD4E36F890
        public void get_isSystem(){} // RVA: 0x7FFD4E5F95D0
        public void set_isSystem(){} // RVA: 0x7FFD4E5F95C0
        public void get_senderUserId(){} // RVA: 0x7FFD4E3BE740
        public void set_senderUserId(){} // RVA: 0x7FFD4E369200
        public void get_senderUsername(){} // RVA: 0x7FFD4E3BC730
        public void set_senderUsername(){} // RVA: 0x7FFD4E3BC740
        public void get_receiverUserId(){} // RVA: 0x7FFD4E3E20E0
        public void set_receiverUserId(){} // RVA: 0x7FFD4E4994D0
        public void get_relatedNotificationsId(){} // RVA: 0x7FFD4E409500
        public void set_relatedNotificationsId(){} // RVA: 0x7FFD4E409510
        public void get_title(){} // RVA: 0x7FFD4FD51870
        public void set_title(){} // RVA: 0x7FFD4FD51690
        public void get_message(){} // RVA: 0x7FFD4FD51700
        public void set_message(){} // RVA: 0x7FFD4FD51890
        public void get_imageUrl(){} // RVA: 0x7FFD4E3AC040
        public void set_imageUrl(){} // RVA: 0x7FFD4E3AC050
        public void get_link(){} // RVA: 0x7FFD4E3AC0B0
        public void set_link(){} // RVA: 0x7FFD4E3AC0C0
        public void get_linkText(){} // RVA: 0x7FFD4E917430
        public void set_linkText(){} // RVA: 0x7FFD4E9167B0
        public void get_data(){} // RVA: 0x7FFD4E3C2970
        public void set_data(){} // RVA: 0x7FFD4E3C2980
        public void get_responses(){} // RVA: 0x7FFD4E3AC2A0
        public void set_responses(){} // RVA: 0x7FFD4E3AC2B0
        public void get_expiresAt(){} // RVA: 0x7FFD4E751F50
        public void set_expiresAt(){} // RVA: 0x7FFD51B35870
        public void get_expiryAfterSeen(){} // RVA: 0x7FFD4E916C80
        public void set_expiryAfterSeen(){} // RVA: 0x7FFD4F5B6020
        public void get_requireSeen(){} // RVA: 0x7FFD4F5B6030
        public void set_requireSeen(){} // RVA: 0x7FFD4F5B6040
        public void get_seen(){} // RVA: 0x7FFD4F9EA6A0
        public void set_seen(){} // RVA: 0x7FFD4F9E9FB0
        public void get_ignoreDND(){} // RVA: 0x7FFD4F9E9D70
        public void set_ignoreDND(){} // RVA: 0x7FFD4F9E9F80
        public void get_canDelete(){} // RVA: 0x7FFD4F9E9F70
        public void set_canDelete(){} // RVA: 0x7FFD4F9E9F40
        public void get_createdAt(){} // RVA: 0x7FFD4E96B170
        public void set_createdAt(){} // RVA: 0x7FFD53F86FB0
        public void get_updatedAt(){} // RVA: 0x7FFD4E7DC6D0
        public void set_updatedAt(){} // RVA: 0x7FFD574FF380
        public void get_notificationType(){} // RVA: 0x7FFD4E36F0C0
        public void get_created_at(){} // RVA: 0x7FFD574FF390
        public void set_created_at(){} // RVA: 0x7FFD53F86FC0
        public void get_payload(){} // RVA: 0x7FFD4E964340
        public void set_payload(){} // RVA: 0x7FFD4EDC79B0
        public void ToString(){} // RVA: 0x7FFD574FF3B0
        public void Equals(){} // RVA: 0x7FFD574FF840
        public void GetHashCode(){} // RVA: 0x7FFD574FFBE0
        public void GetNotificationDataAsTuples(){} // RVA: 0x7FFD574FFC10
        public void CompareTo(){} // RVA: 0x7FFD575000B0
        public void .cctor(){} // RVA: 0x7FFD57500350
    }

    public class NotificationDetails : Dictionary`2
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFD57500410
        public void ToString(){} // RVA: 0x7FFD57500500
        public void .ctor(){} // RVA: 0x7FFD57500800
    }

}