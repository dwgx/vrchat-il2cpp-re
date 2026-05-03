// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Transmtn.DTO.Notifications
// Classes: 3
// Methods: 71

namespace ThirdParty.Other.Transmtn.DTO.Notifications
{
    public class Notification : Object
    {
        public string _id; // 0x10
        public int _version; // 0x18
        public string _type; // 0x20
        public string _descriptor; // 0x28
        public string _category; // 0x30
        public bool _isSystem; // 0x38
        public string _senderUserId; // 0x40
        public string _senderUsername; // 0x48
        public string _receiverUserId; // 0x50
        public string _relatedNotificationsId; // 0x58
        public VRC.Localization.LocalizableString _title; // 0x60
        public VRC.Localization.LocalizableString _message; // 0x88
        public string _imageUrl; // 0xB0
        public string _link; // 0xB8
        public VRC.Localization.LocalizableString _linkText; // 0xC0
        public System.Collections.Generic.Dictionary`2<string,string> _data; // 0xE8
        public System.Collections.Generic.Dictionary`2<string,object>[] _responses; // 0xF0
        public System.DateTime _expiresAt; // 0xF8
        public System.Nullable`1<int> _expiryAfterSeen; // 0x100
        public bool _requireSeen; // 0x108
        public bool _seen; // 0x109
        public bool _ignoreDND; // 0x10A
        public bool _canDelete; // 0x10B
        public System.DateTime _createdAt; // 0x110
        public System.DateTime _updatedAt; // 0x118
        public System.DateTime _created_at; // 0x120
        public Transmtn.DTO.Notifications.NotificationDetails details; // 0x128
        public object _payload; // 0x130

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A544A10 | overloaded x2
        public void Create(){} // RVA: 0x7FFE8A545180
        public void get_id(){} // RVA: 0x7FFE81116380
        public void set_id(){} // RVA: 0x7FFE810FCE30
        public void get_version(){} // RVA: 0x7FFE813DB630
        public void set_version(){} // RVA: 0x7FFE8144DF00
        public void get_type(){} // RVA: 0x7FFE811290C0
        public void set_type(){} // RVA: 0x7FFE811290D0
        public void get_descriptor(){} // RVA: 0x7FFE81129130
        public void set_descriptor(){} // RVA: 0x7FFE810FCE90
        public void get_category(){} // RVA: 0x7FFE8144E200
        public void set_category(){} // RVA: 0x7FFE81129890
        public void get_isSystem(){} // RVA: 0x7FFE812CF770
        public void set_isSystem(){} // RVA: 0x7FFE812D0010
        public void get_senderUserId(){} // RVA: 0x7FFE81178740
        public void set_senderUserId(){} // RVA: 0x7FFE81123200
        public void get_senderUsername(){} // RVA: 0x7FFE81176730
        public void set_senderUsername(){} // RVA: 0x7FFE81176740
        public void get_receiverUserId(){} // RVA: 0x7FFE8119C0E0
        public void set_receiverUserId(){} // RVA: 0x7FFE812534D0
        public void get_relatedNotificationsId(){} // RVA: 0x7FFE811C3500
        public void set_relatedNotificationsId(){} // RVA: 0x7FFE811C3510
        public void get_title(){} // RVA: 0x7FFE82B9B4F0
        public void set_title(){} // RVA: 0x7FFE82B9B580
        public void get_message(){} // RVA: 0x7FFE82B9B8F0
        public void set_message(){} // RVA: 0x7FFE82B9B730
        public void get_imageUrl(){} // RVA: 0x7FFE81166040
        public void set_imageUrl(){} // RVA: 0x7FFE81166050
        public void get_link(){} // RVA: 0x7FFE811660B0
        public void set_link(){} // RVA: 0x7FFE811660C0
        public void get_linkText(){} // RVA: 0x7FFE81CB0DD0
        public void set_linkText(){} // RVA: 0x7FFE81CB1440
        public void get_data(){} // RVA: 0x7FFE8117C970
        public void set_data(){} // RVA: 0x7FFE8117C980
        public void get_responses(){} // RVA: 0x7FFE811662A0
        public void set_responses(){} // RVA: 0x7FFE811662B0
        public void get_expiresAt(){} // RVA: 0x7FFE8158D5D0
        public void set_expiresAt(){} // RVA: 0x7FFE84A61F90
        public void get_expiryAfterSeen(){} // RVA: 0x7FFE81828B50
        public void set_expiryAfterSeen(){} // RVA: 0x7FFE82472650
        public void get_requireSeen(){} // RVA: 0x7FFE82472660
        public void set_requireSeen(){} // RVA: 0x7FFE82472670
        public void get_seen(){} // RVA: 0x7FFE82904DF0
        public void set_seen(){} // RVA: 0x7FFE82904650
        public void get_ignoreDND(){} // RVA: 0x7FFE82904CE0
        public void set_ignoreDND(){} // RVA: 0x7FFE82904820
        public void get_canDelete(){} // RVA: 0x7FFE82904DE0
        public void set_canDelete(){} // RVA: 0x7FFE82904720
        public void get_createdAt(){} // RVA: 0x7FFE81317980
        public void set_createdAt(){} // RVA: 0x7FFE86F10630
        public void get_updatedAt(){} // RVA: 0x7FFE81318010
        public void set_updatedAt(){} // RVA: 0x7FFE8A545350
        public void get_notificationType(){} // RVA: 0x7FFE811290C0
        public void get_created_at(){} // RVA: 0x7FFE8A545360
        public void set_created_at(){} // RVA: 0x7FFE86F10640
        public void get_payload(){} // RVA: 0x7FFE81823850
        public void set_payload(){} // RVA: 0x7FFE81B31120
        public void ToString(){} // RVA: 0x7FFE8A545380
        public void Equals(){} // RVA: 0x7FFE8A545810
        public void GetHashCode(){} // RVA: 0x7FFE8A545BB0
        public void GetNotificationDataAsTuples(){} // RVA: 0x7FFE8A545BE0
        public void CompareTo(){} // RVA: 0x7FFE8A546080
        public void .cctor(){} // RVA: 0x7FFE8A546320
    }

    public class NotificationDetails : Dictionary`2
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFE8A5463E0
        public void ToString(){} // RVA: 0x7FFE8A5464D0
        public void .ctor(){} // RVA: 0x7FFE8A5467D0
    }

    public class NotificationDetailsConverter : JsonConverter
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFE8A546810
        public void ReadJson(){} // RVA: 0x7FFE8A5468E0
        public void WriteJson(){} // RVA: 0x7FFE8A546C40
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}