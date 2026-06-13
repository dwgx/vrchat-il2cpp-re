// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Transmtn.DTO.Notifications
// Classes: 3
// Methods: 73

namespace ThirdParty.Other.Transmtn.DTO.Notifications
{
    public class Notification
    {
        public string <id>k__BackingField; // 0x10
        public int <version>k__BackingField; // 0x18
        public string <fullType>k__BackingField; // 0x20
        public string <type>k__BackingField; // 0x28
        public string <descriptor>k__BackingField; // 0x30
        public string <category>k__BackingField; // 0x38
        public bool <isSystem>k__BackingField; // 0x40
        public string <senderUserId>k__BackingField; // 0x48
        public string <senderUsername>k__BackingField; // 0x50
        public string <receiverUserId>k__BackingField; // 0x58
        public string <relatedNotificationsId>k__BackingField; // 0x60
        public VRC.Localization.LocalizableString <title>k__BackingField; // 0x68
        public VRC.Localization.LocalizableString <message>k__BackingField; // 0x90
        public string <imageUrl>k__BackingField; // 0xB8
        public string <link>k__BackingField; // 0xC0
        public VRC.Localization.LocalizableString <linkText>k__BackingField; // 0xC8
        public System.Collections.Generic.Dictionary`2<string,string> <data>k__BackingField; // 0xF0
        public System.Collections.Generic.Dictionary`2<string,object>[] <responses>k__BackingField; // 0xF8
        public System.DateTime <expiresAt>k__BackingField; // 0x100
        public System.Nullable`1<int> <expiryAfterSeen>k__BackingField; // 0x108
        public bool <requireSeen>k__BackingField; // 0x110
        public bool <seen>k__BackingField; // 0x111
        public bool <ignoreDND>k__BackingField; // 0x112
        public bool <canDelete>k__BackingField; // 0x113
        public System.DateTime <createdAt>k__BackingField; // 0x118
        public System.DateTime <updatedAt>k__BackingField; // 0x120
        public System.DateTime _created_at; // 0x128
        public Transmtn.DTO.Notifications.NotificationDetails details; // 0x130
        public object <payload>k__BackingField; // 0x138

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B05000 | overloaded x2
        public void Create(){} // RVA: 0x9B057B0
        public void get_id(){} // RVA: 0x2F8380
        public void set_id(){} // RVA: 0x2DEE30
        public void get_version(){} // RVA: 0x5BED50
        public void set_version(){} // RVA: 0x6374E0
        public void get_fullType(){} // RVA: 0x30B0C0
        public void set_fullType(){} // RVA: 0x30B0D0
        public void get_type(){} // RVA: 0x30B130
        public void set_type(){} // RVA: 0x2DEE90
        public void get_descriptor(){} // RVA: 0x6374D0
        public void set_descriptor(){} // RVA: 0x30B890
        public void get_category(){} // RVA: 0x4976A0
        public void set_category(){} // RVA: 0x49B830
        public void get_isSystem(){} // RVA: 0x398C00
        public void set_isSystem(){} // RVA: 0x398C10
        public void get_senderUserId(){} // RVA: 0x358730
        public void set_senderUserId(){} // RVA: 0x358740
        public void get_senderUsername(){} // RVA: 0x37E0E0
        public void set_senderUsername(){} // RVA: 0x4354D0
        public void get_receiverUserId(){} // RVA: 0x3A5500
        public void set_receiverUserId(){} // RVA: 0x3A5510
        public void get_relatedNotificationsId(){} // RVA: 0x37B370
        public void set_relatedNotificationsId(){} // RVA: 0x37B380
        public void get_title(){} // RVA: 0x9321690
        public void set_title(){} // RVA: 0x93216B0
        public void get_message(){} // RVA: 0x9B05980
        public void set_message(){} // RVA: 0x9B059B0
        public void get_imageUrl(){} // RVA: 0x3480B0
        public void set_imageUrl(){} // RVA: 0x3480C0
        public void get_link(){} // RVA: 0x348120
        public void set_link(){} // RVA: 0x348130
        public void get_linkText(){} // RVA: 0x9B05A30
        public void set_linkText(){} // RVA: 0x9B05A60
        public void get_data(){} // RVA: 0x3482A0
        public void set_data(){} // RVA: 0x3482B0
        public void get_responses(){} // RVA: 0x7F7DB0
        public void set_responses(){} // RVA: 0x63D280
        public void get_expiresAt(){} // RVA: 0xA94E10
        public void set_expiresAt(){} // RVA: 0x1702E00
        public void get_expiryAfterSeen(){} // RVA: 0xA902E0
        public void set_expiryAfterSeen(){} // RVA: 0x507D00
        public void get_requireSeen(){} // RVA: 0x66C530
        public void set_requireSeen(){} // RVA: 0x66C8F0
        public void get_seen(){} // RVA: 0x98D170
        public void set_seen(){} // RVA: 0x13CBDE0
        public void get_ignoreDND(){} // RVA: 0x8D1950
        public void set_ignoreDND(){} // RVA: 0x8CA8E0
        public void get_canDelete(){} // RVA: 0x13CA3D0
        public void set_canDelete(){} // RVA: 0x13C42A0
        public void get_createdAt(){} // RVA: 0x507D10
        public void set_createdAt(){} // RVA: 0x9B05AE0
        public void get_updatedAt(){} // RVA: 0x59E660
        public void set_updatedAt(){} // RVA: 0x63CFC10
        public void get_notificationType(){} // RVA: 0x30B130
        public void get_created_at(){} // RVA: 0x9B05AF0
        public void set_created_at(){} // RVA: 0x9439860
        public void get_payload(){} // RVA: 0xA933D0
        public void set_payload(){} // RVA: 0xA96DC0
        public void ToString(){} // RVA: 0x9B05B10
        public void Equals(){} // RVA: 0x9B05FA0
        public void GetHashCode(){} // RVA: 0x9B06340
        public void GetNotificationDataAsTuples(){} // RVA: 0x9B06370
        public void CompareTo(){} // RVA: 0x9B06810
        public void .cctor(){} // RVA: 0x9B06AB0
    }

    public class NotificationDetails
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x9B06B70
        public void ToString(){} // RVA: 0x9B06C60
        public void .ctor(){} // RVA: 0x9B06F60
    }

    public class NotificationDetailsConverter
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x9B06FA0
        public void ReadJson(){} // RVA: 0x9B07070
        public void WriteJson(){} // RVA: 0x9B073D0
        public void .ctor(){} // RVA: 0x2DD310
    }

}