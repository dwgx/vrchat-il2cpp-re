// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 25
// Methods: 461

namespace VRC.Core
{
    public class APIGroup : ApiModel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1755FB0
        public void get_ownerId(){} // RVA: 0x7A8153390
        public void set_ownerId(){} // RVA: 0x7A81533A0
        public void get_name(){} // RVA: 0x7A81A00E0
        public void set_name(){} // RVA: 0x7A81A00F0
        public void get_shortCode(){} // RVA: 0x7A82C2060
        public void set_shortCode(){} // RVA: 0x7A82C0530
        public void get_discriminator(){} // RVA: 0x7A825E100
        public void set_discriminator(){} // RVA: 0x7A825F860
        public void get_description(){} // RVA: 0x7A81163D0
        public void set_description(){} // RVA: 0x7A825E460
        public void get_iconUrl(){} // RVA: 0x7A8555100
        public void set_iconUrl(){} // RVA: 0x7A8919DE0
        public void get_bannerUrl(){} // RVA: 0x7A87D9C10
        public void set_bannerUrl(){} // RVA: 0x7A8744720
        public void get_memberCount(){} // RVA: 0x7A9B79A40
        public void set_memberCount(){} // RVA: 0x7A9B79A00
        public void get_onlineMemberCount(){} // RVA: 0x7ABA390E0
        public void set_onlineMemberCount(){} // RVA: 0x7ABA390F0
        public void get_memberCountSyncedAt(){} // RVA: 0x7A87D9480
        public void set_memberCountSyncedAt(){} // RVA: 0x7A8881790
        public void get_privacy(){} // RVA: 0x7A8142610
        public void set_privacy(){} // RVA: 0x7A8142620
        public void get_joinState(){} // RVA: 0x7A8142680
        public void set_joinState(){} // RVA: 0x7A8142690
        public void get_myMember(){} // RVA: 0x7A81426F0
        public void set_myMember(){} // RVA: 0x7A8142700
        public void get_createdAt(){} // RVA: 0x7A82305B0
        public void set_createdAt(){} // RVA: 0x7B09A02E0
        public void get_updatedAt(){} // RVA: 0x7A81F50F0
        public void set_updatedAt(){} // RVA: 0x7AE6C3A40
        public void get_membershipStatus(){} // RVA: 0x7A8854870
        public void set_membershipStatus(){} // RVA: 0x7A8158EF0
        public void get_bannerId(){} // RVA: 0x7A8158F50
        public void set_bannerId(){} // RVA: 0x7A8158F60
        public void get_iconId(){} // RVA: 0x7A8158FC0
        public void set_iconId(){} // RVA: 0x7A8158FD0
        public void get_rules(){} // RVA: 0x7A8142870
        public void set_rules(){} // RVA: 0x7A8142880
        public void get_initialRoleIds(){} // RVA: 0x7A8592710
        public void set_initialRoleIds(){} // RVA: 0x7A84442D0
        public void get_isSystemGroup(){} // RVA: 0x7A8F95140
        public void set_isSystemGroup(){} // RVA: 0x7A8F94B50
        public void get_isVerified(){} // RVA: 0x7A9906080
        public void set_isVerified(){} // RVA: 0x7A9905F70
        public void get_galleries(){} // RVA: 0x7A884DED0
        public void set_galleries(){} // RVA: 0x7A8AB6790
        public void get_tags(){} // RVA: 0x7A884F050
        public void set_tags(){} // RVA: 0x7A8B5D8D0
        public void get_isSearchable(){} // RVA: 0x7B16FCAA0
        public void set_isSearchable(){} // RVA: 0x7B16FCAB0
        public void get_sizeQuality(){} // RVA: 0x7AF143880
        public void set_sizeQuality(){} // RVA: 0x7AF143890
        public void get_activityQuality(){} // RVA: 0x7A8ADBD10
        public void set_activityQuality(){} // RVA: 0x7AE066100
        public void get_engagementQuality(){} // RVA: 0x7ADF29B00
        public void set_engagementQuality(){} // RVA: 0x7ADF29B10
        public void get_contentQuality(){} // RVA: 0x7AE0664A0
        public void set_contentQuality(){} // RVA: 0x7AE0664B0
        public void get_roles(){} // RVA: 0x7A884C460
        public void set_roles(){} // RVA: 0x7A8B68960
        public void get_links(){} // RVA: 0x7A8850FF0
        public void set_links(){} // RVA: 0x7A8854900
        public void get_languages(){} // RVA: 0x7A8142BC0
        public void set_languages(){} // RVA: 0x7A8142BD0
        public void get_lastPostCreatedAt(){} // RVA: 0x7A8142C30
        public void set_lastPostCreatedAt(){} // RVA: 0x7AE088AB0
        public void get_storeId(){} // RVA: 0x7A87BB380
        public void set_storeId(){} // RVA: 0x7A8B52120
        public void UpdateData(){} // RVA: 0x7B17565D0
        public void GetGroup(){} // RVA: 0x7B1757040
        public void FetchAllData(){} // RVA: 0x7B1757260
        public void RequestToJoin(){} // RVA: 0x7B1757700
        public void LeaveGroup(){} // RVA: 0x7B1757AD0
        public void GetGroupInvites(){} // RVA: 0x7B1757E50
        public void InviteUser(){} // RVA: 0x7B17582D0
        public void BanUser(){} // RVA: 0x7B1758710
        public void GetMembers(){} // RVA: 0x7B1758B50
        public void GetGroupCapacity(){} // RVA: 0x7B1759120
        public void SetRepresentation(){} // RVA: 0x7B1759240
        public void GetGroupGalleryImages(){} // RVA: 0x7B17596D0
        public void GetGroupProducts(){} // RVA: 0x7B175A1F0
        public void GetGroupAnnouncements(){} // RVA: 0x7B175A650
        public void SetAnnouncementSubscription(){} // RVA: 0x7B175ABD0
        public void SetEventAnnouncementSubscription(){} // RVA: 0x7B175B030
        public void GetUsingShortCode(){} // RVA: 0x7B175B490
        public void StrictSearch(){} // RVA: 0x7B175B7C0
        public void GetActiveGroupInstances(){} // RVA: 0x7B175BC30
        public void GetRoles(){} // RVA: 0x7B175C090
        public void GetAllGroupPermissions(){} // RVA: 0x7B175C4B0
        public void GetGroupPermissions(){} // RVA: 0x7B175C7E0
        public void ExtractPermissions(){} // RVA: 0x7B175CC60
    }

    public class APIGroupAnnouncement : ApiModel
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7A8153390
        public void set_groupId(){} // RVA: 0x7A81533A0
        public void get_authorId(){} // RVA: 0x7A81A00E0
        public void set_authorId(){} // RVA: 0x7A81A00F0
        public void get_title(){} // RVA: 0x7A82C2060
        public void set_title(){} // RVA: 0x7A82C0530
        public void get_text(){} // RVA: 0x7A825E100
        public void set_text(){} // RVA: 0x7A825F860
        public void get_imageUrl(){} // RVA: 0x7A81163D0
        public void set_imageUrl(){} // RVA: 0x7A825E460
        public void get_visibility(){} // RVA: 0x7A8555100
        public void set_visibility(){} // RVA: 0x7A8919DE0
        public void get_createdAt(){} // RVA: 0x7A87D9C10
        public void set_createdAt(){} // RVA: 0x7AD543B50
        public void get_updatedAt(){} // RVA: 0x7A87C5850
        public void set_updatedAt(){} // RVA: 0x7ADDE2D30
        public void get_roleIds(){} // RVA: 0x7A87D9480
        public void set_roleIds(){} // RVA: 0x7A8881790
        public void SetLastPostReadAt(){} // RVA: 0x7B175E760
        public void .ctor(){} // RVA: 0x7B175EB70
    }

    public class APIGroupInstance : ApiWorldInstance
    {
        // ── Methods ──
        public void BuildRequest(){} // RVA: 0x7B175EC10
        public void .ctor(){} // RVA: 0x7B175EEC0
    }

    public class APIGroupInvite : ApiModel
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7A8153390
        public void set_groupId(){} // RVA: 0x7A81533A0
        public void get_userId(){} // RVA: 0x7A81A00E0
        public void set_userId(){} // RVA: 0x7A81A00F0
        public void get_state(){} // RVA: 0x7A82C2060
        public void set_state(){} // RVA: 0x7A82C0530
        public void CancelRequest(){} // RVA: 0x7B175E3C0
        public void .ctor(){} // RVA: 0x7B175E6C0
    }

    public class APIGroupJoinResponse : ApiModel
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7A8153390
        public void set_groupId(){} // RVA: 0x7A81533A0
        public void get_userId(){} // RVA: 0x7A81A00E0
        public void set_userId(){} // RVA: 0x7A81A00F0
        public void get_createdAt(){} // RVA: 0x7A82C2060
        public void set_createdAt(){} // RVA: 0x7AD89C580
        public void get_isOnProfile(){} // RVA: 0x7A8361EA0
        public void set_isOnProfile(){} // RVA: 0x7A835F4F0
        public void get_isOnNameplate(){} // RVA: 0x7A8358B70
        public void set_isOnNameplate(){} // RVA: 0x7A835A580
        public void get_joinedAt(){} // RVA: 0x7A81163D0
        public void set_joinedAt(){} // RVA: 0x7A887B550
        public void get_updatedAt(){} // RVA: 0x7A8555100
        public void set_updatedAt(){} // RVA: 0x7A9ABC8A0
        public void get_isActive(){} // RVA: 0x7A862ABC0
        public void set_isActive(){} // RVA: 0x7A862ABD0
        public void get_requestedJoin(){} // RVA: 0x7A8628920
        public void set_requestedJoin(){} // RVA: 0x7ADFAB600
        public void get_inviteId(){} // RVA: 0x7A87C5850
        public void set_inviteId(){} // RVA: 0x7A87446C0
        public void .ctor(){} // RVA: 0x7B175E370
    }

    public class APIGroupList : ApiModel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B175F060
    }

    public class APIGroupLocations : ApiModel
    {
        // ── Methods ──
        public void get_fetchedAt(){} // RVA: 0x7A8153390
        public void set_fetchedAt(){} // RVA: 0x7A9D11620
        public void get_instances(){} // RVA: 0x7A81A00E0
        public void set_instances(){} // RVA: 0x7A81A00F0
        public void GetLocations(){} // RVA: 0x7B175F150
        public void .ctor(){} // RVA: 0x7B175F4A0
    }

    public class APIGroupMember : ApiModel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B175F930
        public void get_groupId(){} // RVA: 0x7A8153390
        public void set_groupId(){} // RVA: 0x7A81533A0
        public void get_userId(){} // RVA: 0x7A81A00E0
        public void set_userId(){} // RVA: 0x7A81A00F0
        public void get_roleIds(){} // RVA: 0x7A82C2060
        public void set_roleIds(){} // RVA: 0x7A82C0530
        public void get_mRoleIds(){} // RVA: 0x7A825E100
        public void set_mRoleIds(){} // RVA: 0x7A825F860
        public void get_permissions(){} // RVA: 0x7A81163D0
        public void set_permissions(){} // RVA: 0x7A825E460
        public void get_memberVisibility(){} // RVA: 0x7A8555100
        public void set_memberVisibility(){} // RVA: 0x7A8919DE0
        public void get_membershipStatus(){} // RVA: 0x7A87D9C10
        public void set_membershipStatus(){} // RVA: 0x7A8744720
        public void get_isRepresenting(){} // RVA: 0x7A9905F60
        public void set_isRepresenting(){} // RVA: 0x7A8935600
        public void get_mutualGroup(){} // RVA: 0x7A9B256A0
        public void set_mutualGroup(){} // RVA: 0x7A9B256B0
        public void get_name(){} // RVA: 0x7A87D9480
        public void set_name(){} // RVA: 0x7A8881790
        public void get_ownerId(){} // RVA: 0x7A8142610
        public void set_ownerId(){} // RVA: 0x7A8142620
        public void get_shortCode(){} // RVA: 0x7A8142680
        public void set_shortCode(){} // RVA: 0x7A8142690
        public void get_discriminator(){} // RVA: 0x7A81426F0
        public void set_discriminator(){} // RVA: 0x7A8142700
        public void get_iconUrl(){} // RVA: 0x7A82305B0
        public void set_iconUrl(){} // RVA: 0x7A82305C0
        public void get_bannerUrl(){} // RVA: 0x7A81F50F0
        public void set_bannerUrl(){} // RVA: 0x7A81F5100
        public void get_privacy(){} // RVA: 0x7A8854870
        public void set_privacy(){} // RVA: 0x7A8158EF0
        public void get_visibility(){} // RVA: 0x7A8158F50
        public void set_visibility(){} // RVA: 0x7A8158F60
        public void get_isSubscribedToAnnouncements(){} // RVA: 0x7A92C23E0
        public void set_isSubscribedToAnnouncements(){} // RVA: 0x7A96655B0
        public void get_isSubscribedToEventAnnouncements(){} // RVA: 0x7AE49A7A0
        public void set_isSubscribedToEventAnnouncements(){} // RVA: 0x7B17021D0
        public void get_memberCount(){} // RVA: 0x7A9AAC1C0
        public void set_memberCount(){} // RVA: 0x7AE0660E0
        public void get_joinedAt(){} // RVA: 0x7A8142870
        public void set_joinedAt(){} // RVA: 0x7AE1BD200
        public void get_bannedAt(){} // RVA: 0x7A8592710
        public void set_bannedAt(){} // RVA: 0x7ABBECE80
        public void get_lastPostReadAt(){} // RVA: 0x7A8852A30
        public void set_lastPostReadAt(){} // RVA: 0x7A94BD7B0
        public void get_lastPostCreatedAt(){} // RVA: 0x7A884DED0
        public void set_lastPostCreatedAt(){} // RVA: 0x7A9A836D0
        public void get_user(){} // RVA: 0x7A884F050
        public void set_user(){} // RVA: 0x7A8B5D8D0
        public void get_group(){} // RVA: 0x7A864CFF0
        public void set_group(){} // RVA: 0x7A864C880
        public void GetMemberships(){} // RVA: 0x7B175F990
        public void SetVisibility(){} // RVA: 0x7B175FD70
        public void FetchGroup(){} // RVA: 0x7B1760240
        public void GetRepresentation(){} // RVA: 0x7B1760590
    }

    public class APIGroupMemberList : ApiModel
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7A8153390
        public void set_groupId(){} // RVA: 0x7A81533A0
        public void get_members(){} // RVA: 0x7A81A00E0
        public void set_members(){} // RVA: 0x7A81A00F0
        public void .ctor(){} // RVA: 0x7B1760D10
    }

    public class APIGroupPosts : ApiModel
    {
        // ── Methods ──
        public void get_total(){} // RVA: 0x7A9A93870
        public void set_total(){} // RVA: 0x7A9A93880
        public void get_posts(){} // RVA: 0x7A81A00E0
        public void set_posts(){} // RVA: 0x7A81A00F0
        public void .ctor(){} // RVA: 0x7B175E710
    }

    public class APIGroupRole : ApiModel
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7A8153390
        public void set_groupId(){} // RVA: 0x7A81533A0
        public void get_name(){} // RVA: 0x7A81A00E0
        public void set_name(){} // RVA: 0x7A81A00F0
        public void get_description(){} // RVA: 0x7A82C2060
        public void set_description(){} // RVA: 0x7A82C0530
        public void get_isSelfAssignable(){} // RVA: 0x7A8361EA0
        public void set_isSelfAssignable(){} // RVA: 0x7A835F4F0
        public void get_requiresTwoFactor(){} // RVA: 0x7A8358B70
        public void set_requiresTwoFactor(){} // RVA: 0x7A835A580
        public void get_isManagementRole(){} // RVA: 0x7A8EFF4A0
        public void set_isManagementRole(){} // RVA: 0x7ADD852E0
        public void get_requiresPurchase(){} // RVA: 0x7A92AE6E0
        public void set_requiresPurchase(){} // RVA: 0x7ADDE2AF0
        public void get_createdAt(){} // RVA: 0x7A81163D0
        public void set_createdAt(){} // RVA: 0x7A887B550
        public void get_updatedAt(){} // RVA: 0x7A8555100
        public void set_updatedAt(){} // RVA: 0x7A9ABC8A0
        public void get_defaultRole(){} // RVA: 0x7A862ABC0
        public void set_defaultRole(){} // RVA: 0x7A862ABD0
        public void get_order(){} // RVA: 0x7A9B79A10
        public void set_order(){} // RVA: 0x7A9B79A30
        public void get_permissions(){} // RVA: 0x7A87C5850
        public void set_permissions(){} // RVA: 0x7A87446C0
        public void .ctor(){} // RVA: 0x7B1760E70
    }

    public class APIGroupRoleList : ApiModel
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7A8153390
        public void set_groupId(){} // RVA: 0x7A81533A0
        public void get_roles(){} // RVA: 0x7A81A00E0
        public void set_roles(){} // RVA: 0x7A81A00F0
        public void .ctor(){} // RVA: 0x7B1761180
    }

    public class APIGroup[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AnalyticsInterface : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7B176FF10
        public void SetBuildVersion(){} // RVA: 0x7B1770070
        public void SetLogger(){} // RVA: 0x7B1770120
        public void Send(){} // RVA: 0x7B1770210
        public void SendWithTimestamp(){} // RVA: 0x7B17702E0
        public void SetUserId(){} // RVA: 0x7B17703C0
        public void SetSessionId(){} // RVA: 0x7B1770470
        public void GetSessionId(){} // RVA: 0x7B1770530
        public void SetUserProperties(){} // RVA: 0x7B17705D0
        public void ClearCachedData(){} // RVA: 0x7B1770690
        public void OnApplicationQuit(){} // RVA: 0x7B17707D0
        public void HasPendingEvents(){} // RVA: 0x7B17708A0
        public void OnApplicationFocused(){} // RVA: 0x7B1770970
        public void OnApplicationPaused(){} // RVA: 0x7B1770A10
        public void CheckInstance(){} // RVA: 0x7B1770AD0
    }

    public class AnalyticsSDK : Object
    {
        // ── Methods ──
        public void GetProjectTypeString(){} // RVA: 0x7B1770BB0
        public void Initialize(){} // RVA: 0x7B1770C60
        public void LoggedInUserChanged(){} // RVA: 0x7B1770DD0
        public void AddOtherProperties(){} // RVA: 0x7B1771020
        public void AvatarUploadFailed(){} // RVA: 0x7B17711C0
        public void WorldUploadFailed(){} // RVA: 0x7B1771330
        public void PropUploadFailed(){} // RVA: 0x7B17714A0
        public void ExampleCentralOpened(){} // RVA: 0x7B1771610
        public void ExampleDownloaded(){} // RVA: 0x7B17717B0
        public void ExamplePreviewed(){} // RVA: 0x7B17719F0
        public void CheckInit(){} // RVA: 0x7B1771D60
        public void BuildAndTestLaunched(){} // RVA: 0x7B1771E90
        public void ProjectPublished(){} // RVA: 0x7B1772120
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1772580
    }

    public class ApiBindingCommandReference[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ApiGroupGalleryImage : ApiModel
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7A8153390
        public void set_name(){} // RVA: 0x7A81533A0
        public void get_groupId(){} // RVA: 0x7A81A00E0
        public void set_groupId(){} // RVA: 0x7A81A00F0
        public void get_galleryId(){} // RVA: 0x7A82C2060
        public void set_galleryId(){} // RVA: 0x7A82C0530
        public void get_fileId(){} // RVA: 0x7A825E100
        public void set_fileId(){} // RVA: 0x7A825F860
        public void get_imageUrl(){} // RVA: 0x7A81163D0
        public void set_imageUrl(){} // RVA: 0x7A825E460
        public void get_createdAt(){} // RVA: 0x7A8555100
        public void set_createdAt(){} // RVA: 0x7A9ABC8A0
        public void get_approved(){} // RVA: 0x7A862ABC0
        public void set_approved(){} // RVA: 0x7A862ABD0
        public void get_approvedAt(){} // RVA: 0x7A87C5850
        public void set_approvedAt(){} // RVA: 0x7ADDE2D30
        public void get_approvedByUserId(){} // RVA: 0x7A87D9480
        public void set_approvedByUserId(){} // RVA: 0x7A8881790
        public void get_submittedByUserId(){} // RVA: 0x7A8142610
        public void set_submittedByUserId(){} // RVA: 0x7A8142620
        public void get_file(){} // RVA: 0x7A8142680
        public void set_file(){} // RVA: 0x7A8142690
        public void .ctor(){} // RVA: 0x7B175EBC0
    }

    public class ApiInventoryBundleDrop[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB6DAB00
        public void ValidModelData(){} // RVA: 0x7AB6DACC0
        public void Validate(){} // RVA: 0x7AB6DAD90
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB6DAB00
        public void ValidModelData(){} // RVA: 0x7AB6DACC0
        public void Validate(){} // RVA: 0x7AB6DAD90
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB6DAF40
        public void get_ResponseModels(){} // RVA: 0x7A8153390
        public void set_ResponseModels(){} // RVA: 0x7A81533A0
        public void Validate(){} // RVA: 0x7AB6DAFC0
    }

    public class ApiMutualFriend : ApiModel
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x7A80F2570
        public void set_id(){} // RVA: 0x7A80D8E20
        public void get_displayName(){} // RVA: 0x7A8153390
        public void set_displayName(){} // RVA: 0x7A81533A0
        public void get_status(){} // RVA: 0x7A81A00E0
        public void set_status(){} // RVA: 0x7A81A00F0
        public void get_statusDescription(){} // RVA: 0x7A82C2060
        public void set_statusDescription(){} // RVA: 0x7A82C0530
        public void get_currentAvatarImageUrl(){} // RVA: 0x7A825E100
        public void set_currentAvatarImageUrl(){} // RVA: 0x7A825F860
        public void get_avatarThumbnail(){} // RVA: 0x7A81163D0
        public void set_avatarThumbnail(){} // RVA: 0x7A825E460
        public void get_currentAvatarTags(){} // RVA: 0x7A8555100
        public void set_currentAvatarTags(){} // RVA: 0x7A8919DE0
        public void get_profilePicOverride(){} // RVA: 0x7A87D9C10
        public void set_profilePicOverride(){} // RVA: 0x7A8744720
        public void get_userIcon(){} // RVA: 0x7A87C5850
        public void set_userIcon(){} // RVA: 0x7A87446C0
        public void get_world(){} // RVA: 0x7A87D9480
        public void set_world(){} // RVA: 0x7A8881790
        public void get_instance(){} // RVA: 0x7A8142610
        public void set_instance(){} // RVA: 0x7A8142620
        public void get_instanceType(){} // RVA: 0x7A8142680
        public void set_instanceType(){} // RVA: 0x7A8142690
        public void get_travelingToWorld(){} // RVA: 0x7A81426F0
        public void set_travelingToWorld(){} // RVA: 0x7A8142700
        public void get_travelingToInstance(){} // RVA: 0x7A82305B0
        public void set_travelingToInstance(){} // RVA: 0x7A82305C0
        public void get_platform(){} // RVA: 0x7A81F50F0
        public void set_platform(){} // RVA: 0x7A81F5100
        public void get_groups(){} // RVA: 0x7A8854870
        public void set_groups(){} // RVA: 0x7A8158EF0
        public void get_profilePicImageUrl(){} // RVA: 0x7B1764E80
        public void get_profilePicThumbnailImageUrl(){} // RVA: 0x7B1764EA0
        public void FetchMutualFriendsAsync(){} // RVA: 0x7B1764ED0
        public void .ctor(){} // RVA: 0x7B17650A0
    }

    public class ApiMutualGroup : ApiModel
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x7A80F2570
        public void set_id(){} // RVA: 0x7A80D8E20
        public void get_name(){} // RVA: 0x7A8153390
        public void set_name(){} // RVA: 0x7A81533A0
        public void get_discriminator(){} // RVA: 0x7A81A00E0
        public void set_discriminator(){} // RVA: 0x7A81A00F0
        public void get_ownerId(){} // RVA: 0x7A82C2060
        public void set_ownerId(){} // RVA: 0x7A82C0530
        public void get_privacy(){} // RVA: 0x7A825E100
        public void set_privacy(){} // RVA: 0x7A825F860
        public void get_memberCount(){} // RVA: 0x7A897F560
        public void set_memberCount(){} // RVA: 0x7A8980300
        public void get_shortCode(){} // RVA: 0x7A8555100
        public void set_shortCode(){} // RVA: 0x7A8919DE0
        public void get_description(){} // RVA: 0x7A87D9C10
        public void set_description(){} // RVA: 0x7A8744720
        public void get_bannerId(){} // RVA: 0x7A87C5850
        public void set_bannerId(){} // RVA: 0x7A87446C0
        public void get_bannerUrl(){} // RVA: 0x7A87D9480
        public void set_bannerUrl(){} // RVA: 0x7A8881790
        public void get_iconId(){} // RVA: 0x7A8142610
        public void set_iconId(){} // RVA: 0x7A8142620
        public void get_iconUrl(){} // RVA: 0x7A8142680
        public void set_iconUrl(){} // RVA: 0x7A8142690
        public void get_lastPostCreatedAt(){} // RVA: 0x7A81426F0
        public void set_lastPostCreatedAt(){} // RVA: 0x7A8142700
        public void FetchMutualGroupsAsync(){} // RVA: 0x7B1765D90
        public void .ctor(){} // RVA: 0x7B1765F60
    }

    public class ApiSharedConnectionCounts : ApiModel
    {
        // ── Methods ──
        public void get_CacheLifetime(){} // RVA: 0x7B1766C50
        public void get_friends(){} // RVA: 0x7A9A93870
        public void set_friends(){} // RVA: 0x7A9A93880
        public void get_groups(){} // RVA: 0x7A9A93890
        public void set_groups(){} // RVA: 0x7A9A938A0
        public void FetchSharedConnectionCountsAsync(){} // RVA: 0x7B1766DE0
        public void GetLifeSpan(){} // RVA: 0x7B1766C50
        public void .ctor(){} // RVA: 0x7B1766F90
    }

    public class ApiStoreShelf : ApiModel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1761470
        public void get_ShelfTitle(){} // RVA: 0x7A8153390
        public void set_ShelfTitle(){} // RVA: 0x7A81533A0
        public void get_ShelfDescription(){} // RVA: 0x7A81A00E0
        public void set_ShelfDescription(){} // RVA: 0x7A81A00F0
        public void get_ShelfLayout(){} // RVA: 0x7A82C2060
        public void set_ShelfLayout(){} // RVA: 0x7A82C0530
        public void get_UpdatedAt(){} // RVA: 0x7A825E100
        public void set_UpdatedAt(){} // RVA: 0x7A9D11630
        public void get_CreatedAt(){} // RVA: 0x7A81163D0
        public void set_CreatedAt(){} // RVA: 0x7A887B550
        public void get_ListingIds(){} // RVA: 0x7A8555100
        public void set_ListingIds(){} // RVA: 0x7A8919DE0
        public void get_ShelfVisibility(){} // RVA: 0x7A87D9C10
        public void set_ShelfVisibility(){} // RVA: 0x7A8744720
        public void get_StoreId(){} // RVA: 0x7A87C5850
        public void set_StoreId(){} // RVA: 0x7A87446C0
        public void get_SellerId(){} // RVA: 0x7A87D9480
        public void set_SellerId(){} // RVA: 0x7A8881790
        public void get_HighlightListingId(){} // RVA: 0x7A8142610
        public void set_HighlightListingId(){} // RVA: 0x7A8142620
        public void get_ShelfTabBackgroundImageId(){} // RVA: 0x7A8142680
        public void set_ShelfTabBackgroundImageId(){} // RVA: 0x7A8142690
        public void get_ShelfTabBackgroundImageUrl(){} // RVA: 0x7B17614C0
        public void get_ShelfBackgroundImageId(){} // RVA: 0x7A81426F0
        public void set_ShelfBackgroundImageId(){} // RVA: 0x7A8142700
        public void get_ShelfBackgroundImageUrl(){} // RVA: 0x7B1761530
        public void get_ShelfIconImageId(){} // RVA: 0x7A82305B0
        public void set_ShelfIconImageId(){} // RVA: 0x7A82305C0
        public void get_ShelfIconImageUrl(){} // RVA: 0x7B17615A0
        public void get_Listings(){} // RVA: 0x7A81F50F0
        public void set_Listings(){} // RVA: 0x7A81F5100
        public void get_HighlightListing(){} // RVA: 0x7A8854870
        public void set_HighlightListing(){} // RVA: 0x7A8158EF0
    }

}