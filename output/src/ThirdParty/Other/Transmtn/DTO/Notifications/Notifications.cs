// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Transmtn.DTO.Notifications
// Classes: 4
// Methods: 87

namespace ThirdParty.Other.Transmtn.DTO.Notifications
{
    public class Notification : Object
    {
        public object _id;
        public object _version;
        public object _fullType;
        public object _type;
        public object _descriptor;
        public object _category;
        public object _isSystem;
        public object _senderUserId;
        public object _senderUsername;
        public object _receiverUserId;
        public object _relatedNotificationsId;
        public object _title;
        public object _message;
        public object _imageUrl;
        public object _link;
        public object _linkText;
        public object _data;
        public object _responses;
        public object _expiresAt;
        public object _expiryAfterSeen;
        public object _requireSeen;
        public object _seen;
        public object _ignoreDND;
        public object _canDelete;
        public object _createdAt;
        public object _updatedAt;
        public object _created_at;
        public object details;
        public object _payload;
        public object _notificationDataTuples;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7B33A0
        public void Create(){} // RVA: 0xA7B3B30
        public void get_id(){} // RVA: 0xB5DBF0
        public void set_id(){} // RVA: 0xB44D60
        public void get_version(){} // RVA: 0xE62D00
        public void set_version(){} // RVA: 0x1033F40
        public void get_fullType(){} // RVA: 0xB700F0
        public void set_fullType(){} // RVA: 0xB70100
        public void get_type(){} // RVA: 0xB70160
        public void set_type(){} // RVA: 0xB44DC0
        public void get_descriptor(){} // RVA: 0xD33E60
        public void set_descriptor(){} // RVA: 0xB708C0
        public void get_category(){} // RVA: 0xD05CA0
        public void set_category(){} // RVA: 0xD09D70
        public void get_isSystem(){} // RVA: 0xC02470
        public void set_isSystem(){} // RVA: 0xC02480
        public void get_senderUserId(){} // RVA: 0xBBF8F0
        public void set_senderUserId(){} // RVA: 0xBBF900
        public void get_senderUsername(){} // RVA: 0xBE58B0
        public void set_senderUsername(){} // RVA: 0xCA4DF0
        public void get_receiverUserId(){} // RVA: 0xC0FFC0
        public void set_receiverUserId(){} // RVA: 0xC0FFD0
        public void get_relatedNotificationsId(){} // RVA: 0xBE2C60
        public void set_relatedNotificationsId(){} // RVA: 0xBE2C70
        public void get_title(){} // RVA: 0x9F808B0
        public void set_title(){} // RVA: 0x9F808D0
        public void get_message(){} // RVA: 0xA08CF50
        public void set_message(){} // RVA: 0xA7B3D00
        public void get_imageUrl(){} // RVA: 0xBAE3B0
        public void set_imageUrl(){} // RVA: 0xBAE3C0
        public void get_link(){} // RVA: 0xBAE420
        public void set_link(){} // RVA: 0xBAE430
        public void get_linkText(){} // RVA: 0xA7B3D80
        public void set_linkText(){} // RVA: 0xA7B3DB0
        public void get_data(){} // RVA: 0xBAE5A0
        public void set_data(){} // RVA: 0xBAE5B0
        public void get_responses(){} // RVA: 0x135A7B0
        public void set_responses(){} // RVA: 0xEC0BB0
        public void get_expiresAt(){} // RVA: 0x10B4170
        public void set_expiresAt(){} // RVA: 0x1FDB9B0
        public void get_expiryAfterSeen(){} // RVA: 0x10B9D50
        public void set_expiryAfterSeen(){} // RVA: 0xD9D280
        public void get_requireSeen(){} // RVA: 0x1184420
        public void set_requireSeen(){} // RVA: 0x1EBEA50
        public void get_seen(){} // RVA: 0x12578B0
        public void set_seen(){} // RVA: 0x1CA1B40
        public void get_ignoreDND(){} // RVA: 0x1187440
        public void set_ignoreDND(){} // RVA: 0x11868E0
        public void get_canDelete(){} // RVA: 0x1CA3DF0
        public void set_canDelete(){} // RVA: 0x1CB1050
        public void get_createdAt(){} // RVA: 0xDA0520
        public void set_createdAt(){} // RVA: 0xA7B3E30
        public void get_updatedAt(){} // RVA: 0x114AC20
        public void set_updatedAt(){} // RVA: 0x6E3F300
        public void get_notificationType(){} // RVA: 0xB70160
        public void get_created_at(){} // RVA: 0xA7B3E40
        public void set_created_at(){} // RVA: 0xA0D8CF0
        public void get_payload(){} // RVA: 0x135A170
        public void set_payload(){} // RVA: 0x1365A40
        public void ToString(){} // RVA: 0xA7B3E60
        public void Equals(){} // RVA: 0xA7B42E0
        public void GetHashCode(){} // RVA: 0xA7B4680
        public void GetNotificationDataAsTuples(){} // RVA: 0xA7B46B0
        public void CompareTo(){} // RVA: 0xA7B4B80
        public void .cctor(){} // RVA: 0xA7B4E10
    }

    public class NotificationDetails : Dictionary`2
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0xA7B4ED0
        public void ToString(){} // RVA: 0xA7B4FC0
        public void .ctor(){} // RVA: 0xA7B52C0
    }

    public class NotificationDetailsConverter : JsonConverter
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0xA7B5300
        public void ReadJson(){} // RVA: 0xA7B53A0
        public void WriteJson(){} // RVA: 0xA7B5700
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Notification[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}