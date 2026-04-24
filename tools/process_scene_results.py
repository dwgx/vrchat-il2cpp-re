#!/usr/bin/env python3
"""Process scene traversal results and merge into dump."""
import json, sys, re
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')
BASE_DIR = Path(__file__).resolve().parent.parent

data = [
{"v":"0x333A8CD0","g":["_Application"]},
{"v":"0x33A34C20","g":["_Application"]},
{"v":"0x33C4F170","g":["_Application"]},
{"v":"0x3343E520","g":["PropsManager"]},
{"v":"0x33A6EFD0","g":["PrintManager"]},
{"v":"0x33A16E40","g":["InfoPushSystemManager"]},
{"v":"0x338D5B40","g":["StickerManager"]},
{"v":"0x339B5C50","g":["EmojiManager"]},
{"v":"0x3389C030","g":["AvatarsManager"]},
{"v":"0x33BE72B0","g":["Modal_MM_Keyboard"]},
{"v":"0x334C4030","g":["Menu_Settings"]},
{"v":"0x3341DAE0","g":["Cell_MM_SettingStat"]},
{"v":"0x31A12A20","g":["Options","Badges","Credits","Avatars Container","Tags_Container","Profile","Collections","ItemCounter","Banners"]},
{"v":"0x33A1E9F0","g":["Menu_MM_Profile"]},
{"v":"0x3376F1F0","g":["Menu_MM_Profile"]},
{"v":"0x31A12C30","g":["Playlists","AttributeRow","Cell_Avatar_Attribute_Row"]},
{"v":"0x334E85D0","g":["Worlds","Avatars","SubscriptionGroup_Expired","Panel"]},
{"v":"0x333B3080","g":["Gradient","Icon_AgeVerification","Icon_Status"]},
{"v":"0x31A13100","g":["InventoryContents","Page_MM_UserIcons","Page_MM_Prints","Page_MM_Photos"]},
{"v":"0x319BD950","g":["Category_WarpEffects","Category_LoadingScreens","Category_PortalSkins","Category_DroneSkins"]},
{"v":"0x3385CC10","g":["Menu_MM_LiveNow"]},
{"v":"0x33CC5540","g":["Menu_MM_Avatars"]},
{"v":"0x30B88030","g":["Items_Filter","Items","Stickers_Filter","Stickers","Groups","Wing_Menu_Worlds_Filter"]},
{"v":"0x33C04720","g":["Wing_FriendsFilter"]},
{"v":"0x3399DE80","g":["Menu_QM_Launchpad"]},
{"v":"0x33AA6410","g":["Modal_QM_SharedConnectionsLists"]},
{"v":"0x33434030","g":["Modal_QM_ChangeShieldLevel"]},
{"v":"0x33AAD4D0","g":["Modal_QM_ConfirmURLDialog"]},
{"v":"0x338EC030","g":["Modal_ConfirmListDialog"]},
{"v":"0x333DEB50","g":["Modal_ConfirmDialog","Modal_NotificationFullMessage","Modal_LongText"]},
{"v":"0x339D4ED0","g":["Modal_QM_HoveredDrone"]},
{"v":"0x33CFA960","g":["Modal_QM_ViewPhoto"]},
{"v":"0x33CA98B0","g":["Modal_QM_MoreActions"]},
{"v":"0x334D2F00","g":["Modal_QM_GroupInviteUser"]},
{"v":"0x33CC4CA0","g":["Modal_QM_AddAvatarToFavorites"]},
{"v":"0x333DE430","g":["Modal_QM_AddWorldToPlaylist"]},
{"v":"0x337873C0","g":["Modal_AddMessage"]},
{"v":"0x33976B00","g":["Modal_QM_PopupBuilder"]},
{"v":"0x338F4030","g":["Modal_QM_MassGiftingMethod"]},
{"v":"0x3387C6E0","g":["Menu_QM_Report"]},
{"v":"0x33CC4030","g":["Menu_QM_AvatarDetails"]},
{"v":"0x337C6710","g":["Menu_QM_Gallery"]},
{"v":"0x33ACC030","g":["Menu_InviteResponse"]},
{"v":"0x33414030","g":["Menu_QM_SelectedProp"]},
{"v":"0x33A373E0","g":["Menu_QM_SelectedPrint"]},
{"v":"0x336ECA70","g":["Menu_QM_SelectedDrone"]},
{"v":"0x3383EA50","g":["Menu_QM_SelectedSticker"]},
{"v":"0x33659600","g":["Modal_QM_BoopDialog"]},
{"v":"0x33588030","g":["Menu_SelectedUser_Remote","Menu_SelectedUser_Local"]},
{"v":"0x3387C030","g":["Menu_DevTools"]},
{"v":"0x336A4A30","g":["Menu_MassGifting"]},
{"v":"0x3379DFB0","g":["Menu_QM_ReportHere"]},
{"v":"0x3341EE90","g":["Menu_QM_GeneralSettings"]},
{"v":"0x33756DF0","g":["Menu_QM_VRChatPlus"]},
{"v":"0x33C26A60","g":["Menu_QM_AudioSettings"]},
{"v":"0x33AE6000","g":["Menu_Camera"]},
{"v":"0x3390C030","g":["Menu_Here"]},
{"v":"0x335E1820","g":["Menu_Notifications"]},
{"v":"0x336A41C0","g":["ActionMenu"]},
{"v":"0x339BEAC0","g":["InputPopup","InputKeypadPopup"]},
{"v":"0x334D2330","g":["DatePopup"]},
{"v":"0x334EA260","g":["ThirdPersonViewController"]},
{"v":"0x33CABBD0","g":["InventoryBundlesManager"]},
{"v":"0x333FFBF0","g":["Nameplate"]},
{"v":"0x33AB4670","g":["NotificationManager"]},
{"v":"0x3397EF30","g":["CursorManager"]},
{"v":"0x336CF070","g":["PersonalMirror"]},
{"v":"0x3336AE50","g":["UserCamera"]},
{"v":"0x333812D0","g":["UserCamera"]},
{"v":"0x33380AD0","g":["UserCamera"]},
{"v":"0x3336B9E0","g":["UserCamera"]},
{"v":"0x31A29950","g":["UserCamera"]},
{"v":"0x30B91390","g":["AnalyticsManager"]},
{"v":"0x3372CED0","g":["NetworkManager"]},
{"v":"0x3387DFA0","g":["ControllerBindingsManager"]},
{"v":"0x339D64C0","g":["InputManager"]},
{"v":"0x31641BB0","g":["AssetManagement"]},
{"v":"0x33757620","g":["FlowManager"]},
]

# Build name suggestions
OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')

# Load dump to get deobf_names
with open(BASE_DIR / 'output' / 'deobfuscated_dump.json', 'r', encoding='utf-8') as f:
    dump = json.load(f)

va_to_type = {}
for ns, types in dump['namespaces'].items():
    for t in types:
        va = t.get('va', '').upper()
        if va:
            va_to_type[va] = t

identifications = []
for entry in data:
    va = entry['v'].upper()
    gos = entry['g']
    typ = va_to_type.get(va, {})
    current_name = typ.get('name', '?')

    # Clean primary GO name for suggested class name
    primary = gos[0]
    suggested = primary.replace('(Clone)', '').strip()
    suggested = suggested.split(' ')[0]  # Remove UUIDs
    suggested = re.sub(r'\s*\(\d+\)$', '', suggested)

    # Confidence
    if len(gos) == 1 and '_Application' not in primary:
        confidence = 'high'
    elif len(gos) <= 3 and '_Application' not in primary:
        confidence = 'medium'
    else:
        confidence = 'low'

    identifications.append({
        'va': entry['v'],
        'current_name': current_name,
        'suggested_name': suggested,
        'gameObjects': gos,
        'confidence': confidence,
    })

# Print summary
high = [i for i in identifications if i['confidence'] == 'high']
med = [i for i in identifications if i['confidence'] == 'medium']
low = [i for i in identifications if i['confidence'] == 'low']

print(f"Total: {len(identifications)} classes identified")
print(f"  High confidence: {len(high)}")
print(f"  Medium confidence: {len(med)}")
print(f"  Low confidence: {len(low)}")
print()

print("=== HIGH CONFIDENCE (single unique GO) ===")
for i in sorted(high, key=lambda x: x['suggested_name']):
    marker = "NEW" if 'Complex' in i['current_name'] else "known"
    print(f"  [{marker:5s}] {i['current_name']:45s} -> {i['suggested_name']}")

print(f"\n=== MEDIUM CONFIDENCE (2-3 GOs) ===")
for i in sorted(med, key=lambda x: x['suggested_name']):
    marker = "NEW" if 'Complex' in i['current_name'] else "known"
    print(f"  [{marker:5s}] {i['current_name']:45s} -> {i['suggested_name']} (also: {', '.join(i['gameObjects'][1:])})")

# Count genuinely NEW identifications (still named ComplexComponent*)
new_high = [i for i in high if 'Complex' in i['current_name']]
new_med = [i for i in med if 'Complex' in i['current_name']]
print(f"\n*** NEW identifications: {len(new_high)} high + {len(new_med)} medium = {len(new_high)+len(new_med)} ***")

# Save
output = {
    'generated_by': 'scene_traversal_v2',
    'timestamp': '2026-04-08',
    'method': 'Full BFS scene traversal (30,285 GOs) + component enumeration',
    'identifications': identifications,
    'stats': {
        'total': len(identifications),
        'high': len(high), 'medium': len(med), 'low': len(low),
        'new_high': len(new_high), 'new_med': len(new_med),
        'gos_visited': 30285
    }
}
with open(BASE_DIR / 'output' / 'scene_traversal_results.json', 'w', encoding='utf-8') as f:
    json.dump(output, f, ensure_ascii=False, indent=2)
print(f"\nSaved to output/scene_traversal_results.json")
