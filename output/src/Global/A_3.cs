// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 806

public class Action : Object
{
    // ── Methods ──
    public void Enable(){} // RVA: 0x894750
    public void set_enabled(){} // RVA: 0x6724DF0
    public void .ctor(){} // RVA: 0xB43310
}

public class ActionEvent : UnityEvent`1
{
    public object m_ActionId;
    public object m_ActionName;

    // ── Methods ──
    public void get_actionId(){} // RVA: 0xD33E60
    public void get_actionName(){} // RVA: 0xD05CA0
    public void .ctor(){} // RVA: 0x78E3000
}

public class ActionEventPtr : ValueType
{
    public object m_State;
    public object m_Ptr;

    // ── Methods ──
    public void get_action(){} // RVA: 0x92DD20
    public void get_phase(){} // RVA: 0x92DD50
    public void get_control(){} // RVA: 0x92DD60
    public void get_interaction(){} // RVA: 0x92DDA0
    public void get_time(){} // RVA: 0x92DDF0
    public void get_startTime(){} // RVA: 0x92DE50
    public void get_duration(){} // RVA: 0x92DE60
    public void get_valueSizeInBytes(){} // RVA: 0x92DE70
    public void ReadValueAsObject(){} // RVA: 0x92DE80
    public void ReadValue(){} // RVA: 0xA94080
    public void ToString(){} // RVA: 0x92DF70
}

public class ActionEvent[] : Array
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

public class ActionQueryMatcher : UQueryMatcher
{
    public object _callBack;

    // ── Methods ──
    public void get_callBack(){} // RVA: 0x87C0A0
    public void set_callBack(){} // RVA: 0x894320
    public void OnRuleMatchedElement(){} // RVA: 0x87D3C0
    public void .ctor(){} // RVA: 0x894290
}

public class Activity : ValueType
{
    public object Handle;

    // ── Methods ──
    public void Init(){} // RVA: 0x26D8FA0
    public void Drop(){} // RVA: 0x26D9020
    public void SetState(){} // RVA: 0x26D90A0
    public void Assets(){} // RVA: 0x26D9130
    public void SetAssets(){} // RVA: 0x26D91C0
    public void Timestamps(){} // RVA: 0x26D9250
    public void SetTimestamps(){} // RVA: 0x26D92E0
    public void Party(){} // RVA: 0x26D9370
    public void SetParty(){} // RVA: 0x26D9400
    public void Secrets(){} // RVA: 0x26D9490
    public void SetSecrets(){} // RVA: 0x26D9520
}

public class ActivityJoinCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB9DF20
    public void Invoke(){} // RVA: 0xB9E010
}

public class ActivityJoinCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26DB610
    public void Invoke(){} // RVA: 0x26DB6E0
}

public class Alloc2D : ValueType
{
    public object rect;
    public object row;
    public object alloc;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x99C0F0
}

public class AnalyticsExperiment : ApiModel
{
    public object _key;
    public object _variant;

    // ── Methods ──
    public void get_key(){} // RVA: 0xBBFF90
    public void set_key(){} // RVA: 0xBBFFA0
    public void get_variant(){} // RVA: 0xC10050
    public void set_variant(){} // RVA: 0xC10060
    public void .ctor(){} // RVA: 0xA51BCC0
}

public class AnimatedButton[] : Array
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

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x87C130
    public void set_capacity(){} // RVA: 0x8944F0
    public void LocalInit(){} // RVA: 0x894290
    public void Create(){} // RVA: 0xA94080
    public void IndexOf(){} // RVA: 0x880270
    public void Add(){} // RVA: 0xA94080
    public void Remove(){} // RVA: 0x8944F0
    public void Replace(){} // RVA: 0xA94080
    public void RemoveAll(){} // RVA: 0x894290
    public void GetActivePropertiesForElement(){} // RVA: 0x8943B0
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x35A1A0
    public void LocalInit(){} // RVA: 0x35A1B0
    public void Create(){} // RVA: 0x4214340
    public void IndexOf(){} // RVA: 0x35A1C0
    public void Add(){} // RVA: 0x35A1D0
    public void Remove(){} // RVA: 0x35A230
    public void Replace(){} // RVA: 0x359840
    public void RemoveAll(){} // RVA: 0x35A250
    public void GetActivePropertiesForElement(){} // RVA: 0x35A260
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34EDD0
    public void LocalInit(){} // RVA: 0x34EDE0
    public void Create(){} // RVA: 0x40F7BC0
    public void IndexOf(){} // RVA: 0x34EDF0
    public void Add(){} // RVA: 0x34EE00
    public void Remove(){} // RVA: 0x34EE10
    public void Replace(){} // RVA: 0x34EE20
    public void RemoveAll(){} // RVA: 0x34EE80
    public void GetActivePropertiesForElement(){} // RVA: 0x34EE90
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x3597A0
    public void LocalInit(){} // RVA: 0x3597B0
    public void Create(){} // RVA: 0x420F040
    public void IndexOf(){} // RVA: 0x3597C0
    public void Add(){} // RVA: 0x3597D0
    public void Remove(){} // RVA: 0x359830
    public void Replace(){} // RVA: 0x359840
    public void RemoveAll(){} // RVA: 0x359930
    public void GetActivePropertiesForElement(){} // RVA: 0x359940
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34E630
    public void LocalInit(){} // RVA: 0x34E640
    public void Create(){} // RVA: 0x40F34D0
    public void IndexOf(){} // RVA: 0x34E650
    public void Add(){} // RVA: 0x34E660
    public void Remove(){} // RVA: 0x34E670
    public void Replace(){} // RVA: 0x34E680
    public void RemoveAll(){} // RVA: 0x34E6E0
    public void GetActivePropertiesForElement(){} // RVA: 0x34E6F0
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x359A10
    public void LocalInit(){} // RVA: 0x359A20
    public void Create(){} // RVA: 0x42100B0
    public void IndexOf(){} // RVA: 0x359A30
    public void Add(){} // RVA: 0x359A40
    public void Remove(){} // RVA: 0x359AB0
    public void Replace(){} // RVA: 0x358F60
    public void RemoveAll(){} // RVA: 0x359AD0
    public void GetActivePropertiesForElement(){} // RVA: 0x359AE0
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34E7C0
    public void LocalInit(){} // RVA: 0x34E7D0
    public void Create(){} // RVA: 0x40F4310
    public void IndexOf(){} // RVA: 0x34E7E0
    public void Add(){} // RVA: 0x34E7F0
    public void Remove(){} // RVA: 0x34E800
    public void Replace(){} // RVA: 0x34DF40
    public void RemoveAll(){} // RVA: 0x34E820
    public void GetActivePropertiesForElement(){} // RVA: 0x34E830
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x359360
    public void LocalInit(){} // RVA: 0x359370
    public void Create(){} // RVA: 0x420CD40
    public void IndexOf(){} // RVA: 0x359380
    public void Add(){} // RVA: 0x359390
    public void Remove(){} // RVA: 0x359410
    public void Replace(){} // RVA: 0x359420
    public void RemoveAll(){} // RVA: 0x3594A0
    public void GetActivePropertiesForElement(){} // RVA: 0x3594B0
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34E250
    public void LocalInit(){} // RVA: 0x34E260
    public void Create(){} // RVA: 0x40F16B0
    public void IndexOf(){} // RVA: 0x34E270
    public void Add(){} // RVA: 0x34E280
    public void Remove(){} // RVA: 0x34E2C0
    public void Replace(){} // RVA: 0x34E2D0
    public void RemoveAll(){} // RVA: 0x34E330
    public void GetActivePropertiesForElement(){} // RVA: 0x34E340
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34F440
    public void LocalInit(){} // RVA: 0x34F450
    public void Create(){} // RVA: 0x40FB510
    public void IndexOf(){} // RVA: 0x34F460
    public void Add(){} // RVA: 0x34F470
    public void Remove(){} // RVA: 0x34F520
    public void Replace(){} // RVA: 0x34F530
    public void RemoveAll(){} // RVA: 0x34F5D0
    public void GetActivePropertiesForElement(){} // RVA: 0x34F5E0
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34DAE0
    public void LocalInit(){} // RVA: 0x34DAF0
    public void Create(){} // RVA: 0x40EDB70
    public void IndexOf(){} // RVA: 0x34DB00
    public void Add(){} // RVA: 0x34DB10
    public void Remove(){} // RVA: 0x34DB60
    public void Replace(){} // RVA: 0x34DB70
    public void RemoveAll(){} // RVA: 0x34DC40
    public void GetActivePropertiesForElement(){} // RVA: 0x34DC50
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x359580
    public void LocalInit(){} // RVA: 0x359590
    public void Create(){} // RVA: 0x420DE00
    public void IndexOf(){} // RVA: 0x3595A0
    public void Add(){} // RVA: 0x3595B0
    public void Remove(){} // RVA: 0x359630
    public void Replace(){} // RVA: 0x359640
    public void RemoveAll(){} // RVA: 0x3596C0
    public void GetActivePropertiesForElement(){} // RVA: 0x3596D0
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34E410
    public void LocalInit(){} // RVA: 0x34E420
    public void Create(){} // RVA: 0x40F2500
    public void IndexOf(){} // RVA: 0x34E430
    public void Add(){} // RVA: 0x34E440
    public void Remove(){} // RVA: 0x34E480
    public void Replace(){} // RVA: 0x34E490
    public void RemoveAll(){} // RVA: 0x34E550
    public void GetActivePropertiesForElement(){} // RVA: 0x34E560
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x359BB0
    public void LocalInit(){} // RVA: 0x359BC0
    public void Create(){} // RVA: 0x4211060
    public void IndexOf(){} // RVA: 0x359BD0
    public void Add(){} // RVA: 0x359BE0
    public void Remove(){} // RVA: 0x359C50
    public void Replace(){} // RVA: 0x359C60
    public void RemoveAll(){} // RVA: 0x359CC0
    public void GetActivePropertiesForElement(){} // RVA: 0x359CD0
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34E900
    public void LocalInit(){} // RVA: 0x34E910
    public void Create(){} // RVA: 0x40F5100
    public void IndexOf(){} // RVA: 0x34E920
    public void Add(){} // RVA: 0x34E930
    public void Remove(){} // RVA: 0x34E940
    public void Replace(){} // RVA: 0x34E950
    public void RemoveAll(){} // RVA: 0x34E9A0
    public void GetActivePropertiesForElement(){} // RVA: 0x34E9B0
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x35A330
    public void LocalInit(){} // RVA: 0x35A340
    public void Create(){} // RVA: 0x42152D0
    public void IndexOf(){} // RVA: 0x35A350
    public void Add(){} // RVA: 0x35A360
    public void Remove(){} // RVA: 0x35A400
    public void Replace(){} // RVA: 0x35A410
    public void RemoveAll(){} // RVA: 0x35A4B0
    public void GetActivePropertiesForElement(){} // RVA: 0x35A4C0
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34EF60
    public void LocalInit(){} // RVA: 0x34EF70
    public void Create(){} // RVA: 0x40F89F0
    public void IndexOf(){} // RVA: 0x34EF80
    public void Add(){} // RVA: 0x34EF90
    public void Remove(){} // RVA: 0x34EFE0
    public void Replace(){} // RVA: 0x34EFF0
    public void RemoveAll(){} // RVA: 0x34F070
    public void GetActivePropertiesForElement(){} // RVA: 0x34F080
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x359FF0
    public void LocalInit(){} // RVA: 0x35A000
    public void Create(){} // RVA: 0x4213370
    public void IndexOf(){} // RVA: 0x35A010
    public void Add(){} // RVA: 0x35A020
    public void Remove(){} // RVA: 0x35A0A0
    public void Replace(){} // RVA: 0x359420
    public void RemoveAll(){} // RVA: 0x35A0C0
    public void GetActivePropertiesForElement(){} // RVA: 0x35A0D0
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34EC60
    public void LocalInit(){} // RVA: 0x34EC70
    public void Create(){} // RVA: 0x40F6DC0
    public void IndexOf(){} // RVA: 0x34EC80
    public void Add(){} // RVA: 0x34EC90
    public void Remove(){} // RVA: 0x34ECD0
    public void Replace(){} // RVA: 0x34E2D0
    public void RemoveAll(){} // RVA: 0x34ECF0
    public void GetActivePropertiesForElement(){} // RVA: 0x34ED00
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x359DA0
    public void LocalInit(){} // RVA: 0x359DB0
    public void Create(){} // RVA: 0x4212250
    public void IndexOf(){} // RVA: 0x359DC0
    public void Add(){} // RVA: 0x359DD0
    public void Remove(){} // RVA: 0x359E70
    public void Replace(){} // RVA: 0x359E80
    public void RemoveAll(){} // RVA: 0x359F10
    public void GetActivePropertiesForElement(){} // RVA: 0x359F20
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34EA80
    public void LocalInit(){} // RVA: 0x34EA90
    public void Create(){} // RVA: 0x40F5F20
    public void IndexOf(){} // RVA: 0x34EAA0
    public void Add(){} // RVA: 0x34EAB0
    public void Remove(){} // RVA: 0x34EB00
    public void Replace(){} // RVA: 0x34EB10
    public void RemoveAll(){} // RVA: 0x34EB80
    public void GetActivePropertiesForElement(){} // RVA: 0x34EB90
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x35A750
    public void LocalInit(){} // RVA: 0x35A760
    public void Create(){} // RVA: 0x42173F0
    public void IndexOf(){} // RVA: 0x35A770
    public void Add(){} // RVA: 0x35A780
    public void Remove(){} // RVA: 0x35A820
    public void Replace(){} // RVA: 0x359E80
    public void RemoveAll(){} // RVA: 0x35A840
    public void GetActivePropertiesForElement(){} // RVA: 0x35A850
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34F2C0
    public void LocalInit(){} // RVA: 0x34F2D0
    public void Create(){} // RVA: 0x40FA6D0
    public void IndexOf(){} // RVA: 0x34F2E0
    public void Add(){} // RVA: 0x34F2F0
    public void Remove(){} // RVA: 0x34F340
    public void Replace(){} // RVA: 0x34EB10
    public void RemoveAll(){} // RVA: 0x34F360
    public void GetActivePropertiesForElement(){} // RVA: 0x34F370
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x35A590
    public void LocalInit(){} // RVA: 0x35A5A0
    public void Create(){} // RVA: 0x4216400
    public void IndexOf(){} // RVA: 0x35A5B0
    public void Add(){} // RVA: 0x35A5C0
    public void Remove(){} // RVA: 0x35A650
    public void Replace(){} // RVA: 0x359200
    public void RemoveAll(){} // RVA: 0x35A670
    public void GetActivePropertiesForElement(){} // RVA: 0x35A680
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34F150
    public void LocalInit(){} // RVA: 0x34F160
    public void Create(){} // RVA: 0x40F98B0
    public void IndexOf(){} // RVA: 0x34F170
    public void Add(){} // RVA: 0x34F180
    public void Remove(){} // RVA: 0x34F1C0
    public void Replace(){} // RVA: 0x34E100
    public void RemoveAll(){} // RVA: 0x34F1E0
    public void GetActivePropertiesForElement(){} // RVA: 0x34F1F0
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34F6B0
    public void LocalInit(){} // RVA: 0x34F6C0
    public void Create(){} // RVA: 0x40FC690
    public void IndexOf(){} // RVA: 0x34F6D0
    public void Add(){} // RVA: 0x34F6E0
    public void Remove(){} // RVA: 0x34F760
    public void Replace(){} // RVA: 0x34F770
    public void RemoveAll(){} // RVA: 0x34F870
    public void GetActivePropertiesForElement(){} // RVA: 0x34F880
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34DD20
    public void LocalInit(){} // RVA: 0x34DD30
    public void Create(){} // RVA: 0x40EEB60
    public void IndexOf(){} // RVA: 0x34DD40
    public void Add(){} // RVA: 0x34DD50
    public void Remove(){} // RVA: 0x34DD90
    public void Replace(){} // RVA: 0x34DDA0
    public void RemoveAll(){} // RVA: 0x34DE10
    public void GetActivePropertiesForElement(){} // RVA: 0x34DE20
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x358EB0
    public void LocalInit(){} // RVA: 0x358EC0
    public void Create(){} // RVA: 0x420ABC0
    public void IndexOf(){} // RVA: 0x358ED0
    public void Add(){} // RVA: 0x358EE0
    public void Remove(){} // RVA: 0x358F50
    public void Replace(){} // RVA: 0x358F60
    public void RemoveAll(){} // RVA: 0x359050
    public void GetActivePropertiesForElement(){} // RVA: 0x359060
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34DEF0
    public void LocalInit(){} // RVA: 0x34DF00
    public void Create(){} // RVA: 0x40EF9F0
    public void IndexOf(){} // RVA: 0x34DF10
    public void Add(){} // RVA: 0x34DF20
    public void Remove(){} // RVA: 0x34DF30
    public void Replace(){} // RVA: 0x34DF40
    public void RemoveAll(){} // RVA: 0x34DFA0
    public void GetActivePropertiesForElement(){} // RVA: 0x34DFB0
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x359130
    public void LocalInit(){} // RVA: 0x359140
    public void Create(){} // RVA: 0x420BC50
    public void IndexOf(){} // RVA: 0x359150
    public void Add(){} // RVA: 0x359160
    public void Remove(){} // RVA: 0x3591F0
    public void Replace(){} // RVA: 0x359200
    public void RemoveAll(){} // RVA: 0x359280
    public void GetActivePropertiesForElement(){} // RVA: 0x359290
}

public class AnimationDataSet`2 : ValueType
{
    public object elements;
    public object properties;
    public object timing;
    public object style;
    public object count;
    public object indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x318730
    public void set_capacity(){} // RVA: 0x34E080
    public void LocalInit(){} // RVA: 0x34E090
    public void Create(){} // RVA: 0x40F0830
    public void IndexOf(){} // RVA: 0x34E0A0
    public void Add(){} // RVA: 0x34E0B0
    public void Remove(){} // RVA: 0x34E0F0
    public void Replace(){} // RVA: 0x34E100
    public void RemoveAll(){} // RVA: 0x34E170
    public void GetActivePropertiesForElement(){} // RVA: 0x34E180
}

public class ApiGalleryImageContainer : ApiModel
{
    public object _totalCount;
    public object _results;

    // ── Methods ──
    public void get_totalCount(){} // RVA: 0x2536460
    public void set_totalCount(){} // RVA: 0x25406E0
    public void get_results(){} // RVA: 0xC10050
    public void set_results(){} // RVA: 0xC10060
    public void .ctor(){} // RVA: 0xA5C9300
}

public class ApiPopupBuilderData : ApiModel
{
    public object _key;
    public object _title;
    public object _spacing;
    public object _content;

    // ── Methods ──
    public void get_key(){} // RVA: 0xBBFF90
    public void set_key(){} // RVA: 0xBBFFA0
    public void get_title(){} // RVA: 0xC10050
    public void set_title(){} // RVA: 0xC10060
    public void get_spacing(){} // RVA: 0xB6B260
    public void set_spacing(){} // RVA: 0xB6B270
    public void get_content(){} // RVA: 0xCD48B0
    public void set_content(){} // RVA: 0xCD3600
    public void .ctor(){} // RVA: 0xA51C320
}

public class ApiPopupBuilderRecipe : ApiModel
{
    public object _pages;

    // ── Methods ──
    public void get_pages(){} // RVA: 0xBBFF90
    public void set_pages(){} // RVA: 0xBBFFA0
    public void .ctor(){} // RVA: 0xA51C2D0
}

public class ApiPromotionNotification : ApiModel
{
    public object _title;
    public object _body;
    public object _imageUrl;
    public object _command;
    public object _parameter;

    // ── Methods ──
    public void get_title(){} // RVA: 0xBBFF90
    public void set_title(){} // RVA: 0xBBFFA0
    public void get_body(){} // RVA: 0xC10050
    public void set_body(){} // RVA: 0xC10060
    public void get_imageUrl(){} // RVA: 0xCD3320
    public void set_imageUrl(){} // RVA: 0xCD4740
    public void get_command(){} // RVA: 0xCD48B0
    public void set_command(){} // RVA: 0xCD3600
    public void get_parameter(){} // RVA: 0xB813B0
    public void set_parameter(){} // RVA: 0xD5CBB0
    public void .ctor(){} // RVA: 0xA51C280
}

public class ApiRequestData : ValueType
{
    public object RawJson;
    public object RequestParams;
    public object FormData;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA73430
    public void op_Implicit(){} // RVA: 0xA4FD2F0
}

public class ApiVRChatProductStore : ApiModel
{
    public object _planId;

    // ── Methods ──
    public void get_planId(){} // RVA: 0xBBFF90
    public void set_planId(){} // RVA: 0xBBFFA0
    public void .ctor(){} // RVA: 0xA59AC90
}

public class ApplySettingsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DB94B0
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x23E7ED0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ApplySettingsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DB94B0
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x23E7ED0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ApplySettingsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DB94B0
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x23E7ED0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ApplySettingsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DB94B0
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x23E7ED0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ApplySettingsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DB94B0
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x23E7ED0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class Area : Object
{
    public object rect;
    public object allocator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7F3C5B0
}

public class AreaNode : Object
{
    public object s_Pool;
    public object rect;
    public object previous;
    public object next;

    // ── Methods ──
    public void Acquire(){} // RVA: 0x80A4F90
    public void Release(){} // RVA: 0x80A5130
    public void RemoveFromChain(){} // RVA: 0x80A51C0
    public void AddAfter(){} // RVA: 0x80A5330
    public void .ctor(){} // RVA: 0xB43310
    public void .cctor(){} // RVA: 0x80A5520
}

public class Arm : BodyPart
{
    public object target;
    public object bendGoal;
    public object positionWeight;
    public object rotationWeight;
    public object shoulderRotationMode;
    public object vrcExtraShoulderReach;
    public object vrcAvoidElbowClipping;
    public object vrcIsForcedElbowDirection;
    public object vrcForcedElbowDirection;
    public object vrcElbowTracking;
    public object vrcShoulderTracking;
    public object vrcShoulderWidthCompensation;
    public object vrcInVRMode;
    public object vrcShoulderWidthToArmRatio;
    public object vrcShoulderHeightAboveChest;
    public object postSpineStretchRootPos;
    public object postSpineStretchRootRot;
    public object _vrcPoseElbowBendDir;
    public object oldBendGoalWeight;
    public object _vrcPoseWristRot;
    public object _finalHandRot;
    public object LeftWristAlign;
    public object RightWristAlign;
    public object _vrcCharacterSpaceBendOffsetLeft;
    public object _vrcCharacterSpaceBendOffsetRight;
    public object _vrcIsFrontSide;
    public object _vrcHandNearOppositeShoulder;
    public object shoulderTarget;
    public object torsoAddScale;
    public object pushingFactor;
    public object crossFrontElbowForwardFactor;
    public object shiftChestForward;
    public object elbowClipIterations;
    public object shoulderRotationWeight;
    public object shoulderTwistWeight;
    public object bendGoalWeight;
    public object swivelOffset;
    public object wristToPalmAxis;
    public object palmToThumbAxis;
    public object armLengthMlp;
    public object stretchCurve;
    public object IKPosition;
    public object IKRotation;
    public object bendDirection;
    public object handPositionOffset;
    public object _position;
    public object _rotation;
    public object hasShoulder;
    public object chestForwardAxis;
    public object chestUpAxis;
    public object chestRotation;
    public object chestForward;
    public object chestUp;
    public object forearmRelToUpperArm;
    public object upperArmBendAxis;
    public object yawOffsetAngle;
    public object pitchOffsetAngle;

    // ── Methods ──
    public void get_position(){} // RVA: 0xC6A380
    public void set_position(){} // RVA: 0xC6A3A0
    public void get_rotation(){} // RVA: 0xC6A3C0
    public void set_rotation(){} // RVA: 0xC6A3D0
    public void get_shoulder(){} // RVA: 0xC6A3E0
    public void get_upperArm(){} // RVA: 0xC6A410
    public void get_forearm(){} // RVA: 0xC6A460
    public void get_hand(){} // RVA: 0xC6A4B0
    public void OnRead(){} // RVA: 0xC6A500
    public void PreSolve(){} // RVA: 0xC6B780
    public void ApplyOffsets(){} // RVA: 0xC6BE30
    public void Stretching(){} // RVA: 0xC6BE90
    public void VrcGetZeroWeightElbowDir(){} // RVA: 0xC6C5E0
    public void VrcAdjustBendFromTargetRot(){} // RVA: 0xC6D5F0
    public void VrcAvoidElbowClipping(){} // RVA: 0xC6EBF0
    public void Solve(){} // RVA: 0xC706E0
    public void ResetOffsets(){} // RVA: 0xC742C0
    public void Write(){} // RVA: 0xC74320
    public void VrcSetPoseBend(){} // RVA: 0xC746B0
    public void VrcSetPoseWristRot(){} // RVA: 0xC746D0
    public void DamperValue(){} // RVA: 0xC746E0
    public void GetBendNormal(){} // RVA: 0xC747B0
    public void Visualize(){} // RVA: 0xC75D60
    public void .ctor(){} // RVA: 0xC76020
}

public class Arm[] : Array
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

public class ArrayPoolImpl`1 : Object
{
    public object syncLock;
    public object Pool;
    public object Instance;

    // ── Methods ──
    public void Get(){} // RVA: 0x43CF840
    public void get_ObjectType(){} // RVA: 0x43CF670
    public void get_CountInactive(){} // RVA: 0x434E0A0
    public void .ctor(){} // RVA: 0x43CF6B0
    public void Contains(){} // RVA: 0x434E870
    public void Release(){} // RVA: 0x434EA80
    public void Cleanup(){} // RVA: 0x43CFB90
    public void .cctor(){} // RVA: 0x43D02B0
}

public class ArrayPoolImpl`1 : Object
{
    public object syncLock;
    public object Pool;
    public object Instance;

    // ── Methods ──
    public void Get(){} // RVA: 0x43D06F0
    public void get_ObjectType(){} // RVA: 0x434E060
    public void get_CountInactive(){} // RVA: 0x434E0A0
    public void .ctor(){} // RVA: 0x43D0560
    public void Contains(){} // RVA: 0x434E870
    public void Release(){} // RVA: 0x434EA80
    public void Cleanup(){} // RVA: 0x43D0A40
    public void .cctor(){} // RVA: 0x43D1160
}

public class ArrayPoolImpl`1 : Object
{
    public object syncLock;
    public object Pool;
    public object Instance;

    // ── Methods ──
    public void Get(){} // RVA: 0x434E520
    public void get_ObjectType(){} // RVA: 0x434E060
    public void get_CountInactive(){} // RVA: 0x434E0A0
    public void .ctor(){} // RVA: 0x434E390
    public void Contains(){} // RVA: 0x434E870
    public void Release(){} // RVA: 0x434EA80
    public void Cleanup(){} // RVA: 0x434EEA0
    public void .cctor(){} // RVA: 0x434F5C0
}

public class ArrayPoolImpl`1 : Object
{
    public object syncLock;
    public object Pool;
    public object Instance;

    // ── Methods ──
    public void Get(){} // RVA: 0x43CBD40
    public void get_ObjectType(){} // RVA: 0x434E060
    public void get_CountInactive(){} // RVA: 0x434E0A0
    public void .ctor(){} // RVA: 0x43CBBB0
    public void Contains(){} // RVA: 0x434E870
    public void Release(){} // RVA: 0x434EA80
    public void Cleanup(){} // RVA: 0x43CC090
    public void .cctor(){} // RVA: 0x43CC7B0
}

public class ArrayPoolImpl`1 : Object
{
    public object syncLock;
    public object Pool;
    public object Instance;

    // ── Methods ──
    public void Get(){} // RVA: 0x43CDAA0
    public void get_ObjectType(){} // RVA: 0x434E060
    public void get_CountInactive(){} // RVA: 0x434E0A0
    public void .ctor(){} // RVA: 0x43CD910
    public void Contains(){} // RVA: 0x434E870
    public void Release(){} // RVA: 0x434EA80
    public void Cleanup(){} // RVA: 0x43CDDF0
    public void .cctor(){} // RVA: 0x43CE510
}

public class ArrayPoolImpl`1 : Object
{
    public object syncLock;
    public object Pool;
    public object Instance;

    // ── Methods ──
    public void get_ObjectType(){} // RVA: 0x87C0A0
    public void get_CountInactive(){} // RVA: 0x87C130
    public void .ctor(){} // RVA: 0x894290
    public void Get(){} // RVA: 0xA94080
    public void Contains(){} // RVA: 0x87D350
    public void Release(){} // RVA: 0x894320
    public void Cleanup(){} // RVA: 0x87C130
    public void .cctor(){} // RVA: 0x8942F0
}

public class Article : ApiModel
{
    public object _content;
    public object _sectionLinks;
    public object _embeddedLinkData;
    public object _moreInfoLinks;

    // ── Methods ──
    public void get_content(){} // RVA: 0xBBFF90
    public void set_content(){} // RVA: 0xBBFFA0
    public void get_sectionLinks(){} // RVA: 0xC10050
    public void set_sectionLinks(){} // RVA: 0xC10060
    public void get_embeddedLinkData(){} // RVA: 0xCD3320
    public void set_embeddedLinkData(){} // RVA: 0xCD4740
    public void get_moreInfoLinks(){} // RVA: 0xCD48B0
    public void set_moreInfoLinks(){} // RVA: 0xCD3600
    public void .ctor(){} // RVA: 0xA51C120
}

public class ArticleContent : ApiModel
{
    public object _title;
    public object _text;
    public object _imageUrl;
    public object _videoUrl;
    public object _onPressed;

    // ── Methods ──
    public void get_title(){} // RVA: 0xBBFF90
    public void set_title(){} // RVA: 0xBBFFA0
    public void get_text(){} // RVA: 0xC10050
    public void set_text(){} // RVA: 0xC10060
    public void get_imageUrl(){} // RVA: 0xCD3320
    public void set_imageUrl(){} // RVA: 0xCD4740
    public void get_videoUrl(){} // RVA: 0xCD48B0
    public void set_videoUrl(){} // RVA: 0xCD3600
    public void get_onPressed(){} // RVA: 0xB813B0
    public void set_onPressed(){} // RVA: 0xD5CBB0
    public void .ctor(){} // RVA: 0xA51C170
}

public class ArticleContent[] : Array
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

public class Asn1SequenceParserImpl : Object
{
    public object outer;
    public object max;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA370D40
    public void ReadObject(){} // RVA: 0xA370DC0
    public void ToAsn1Object(){} // RVA: 0xB5DBF0
}

public class Asn1SetParserImpl : Object
{
    public object outer;
    public object max;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA372160
    public void ReadObject(){} // RVA: 0xA3721E0
    public void ToAsn1Object(){} // RVA: 0xB5DBF0
}

public class AssetEntry : ValueType
{
    public object m_Path;
    public object m_TypeFullName;
    public object m_AssetReference;
    public object m_InstanceID;
    public object m_CachedType;

    // ── Methods ──
    public void get_type(){} // RVA: 0x99B5F0
    public void get_path(){} // RVA: 0x77900
    public void get_asset(){} // RVA: 0x99B600
    public void .ctor(){} // RVA: 0x99B610
}

public class AssetEntry[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E320
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A900
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4160
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E345E0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A900
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class AssociatedDetection : Object
{
    public object _parser;
    public object _unknownFields;
    public object _hasBits0;
    public object IdFieldNumber;
    public object IdDefaultValue;
    public object id_;
    public object ConfidenceFieldNumber;
    public object ConfidenceDefaultValue;
    public object confidence_;

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x6586CA0
    public void get_Descriptor(){} // RVA: 0x6586D00
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x6586D80
    public void .ctor(){} // RVA: 0x6586E30
    public void Clone(){} // RVA: 0x6586F20
    public void get_Id(){} // RVA: 0x6587040
    public void set_Id(){} // RVA: 0x64D65C0
    public void get_HasId(){} // RVA: 0x64D65D0
    public void ClearId(){} // RVA: 0x64D65E0
    public void get_Confidence(){} // RVA: 0x65870B0
    public void set_Confidence(){} // RVA: 0x6580EA0
    public void get_HasConfidence(){} // RVA: 0x64D6670
    public void ClearConfidence(){} // RVA: 0x64D6680
    public void Equals(){} // RVA: 0x6587270
    public void GetHashCode(){} // RVA: 0x6587390
    public void ToString(){} // RVA: 0x6587470
    public void WriteTo(){} // RVA: 0x64B3910
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x65874C0
    public void CalculateSize(){} // RVA: 0x6587550
    public void MergeFrom(){} // RVA: 0x64B3C50
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x6587700
    public void .cctor(){} // RVA: 0x65877A0
}

public class AssociatedDetection[] : Array
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

public class AttachExternalCancellationSource`1 : Object
{
    public object cancellationCallbackDelegate;
    public object cancellationToken;
    public object tokenRegistration;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x609A820
    public void RunTask(){} // RVA: 0x609AB60
    public void CancellationCallback(){} // RVA: 0x609ACE0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x609AD90
    public void GetResult(){} // RVA: 0x609AD90
    public void GetStatus(){} // RVA: 0x609ADB0
    public void OnCompleted(){} // RVA: 0x609ADD0
    public void UnsafeGetStatus(){} // RVA: 0x609AE00
    public void .cctor(){} // RVA: 0x609AE20
}

public class AttachExternalCancellationSource`1 : Object
{
    public object cancellationCallbackDelegate;
    public object cancellationToken;
    public object tokenRegistration;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x609A820
    public void RunTask(){} // RVA: 0x609AB60
    public void CancellationCallback(){} // RVA: 0x609ACE0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x609AD90
    public void GetResult(){} // RVA: 0x609AD90
    public void GetStatus(){} // RVA: 0x609ADB0
    public void OnCompleted(){} // RVA: 0x609ADD0
    public void UnsafeGetStatus(){} // RVA: 0x609AE00
    public void .cctor(){} // RVA: 0x609AE20
}

public class AttachExternalCancellationSource`1 : Object
{
    public object cancellationCallbackDelegate;
    public object cancellationToken;
    public object tokenRegistration;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x60983F0
    public void RunTask(){} // RVA: 0x6098730
    public void CancellationCallback(){} // RVA: 0x60988E0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x6098980
    public void GetResult(){} // RVA: 0x60989B0
    public void GetStatus(){} // RVA: 0x6098A00
    public void OnCompleted(){} // RVA: 0x6098A20
    public void UnsafeGetStatus(){} // RVA: 0x6098A50
    public void .cctor(){} // RVA: 0x6098A60
}

public class AttachExternalCancellationSource`1 : Object
{
    public object cancellationCallbackDelegate;
    public object cancellationToken;
    public object tokenRegistration;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x609A140
    public void RunTask(){} // RVA: 0x609A460
    public void CancellationCallback(){} // RVA: 0x609A5D0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x609A670
    public void GetResult(){} // RVA: 0x609A670
    public void GetStatus(){} // RVA: 0x609A690
    public void OnCompleted(){} // RVA: 0x609A6B0
    public void UnsafeGetStatus(){} // RVA: 0x609A6E0
    public void .cctor(){} // RVA: 0x609A6F0
}

public class Attachment : ApiModel
{
    public object _partId;
    public object _isEnabled;
    public object _path;
    public object _position;
    public object _rotation;
    public object _scale;
    public object _variables;

    // ── Methods ──
    public void get_partId(){} // RVA: 0xBBFF90
    public void set_partId(){} // RVA: 0xBBFFA0
    public void get_isEnabled(){} // RVA: 0xBC03E0
    public void set_isEnabled(){} // RVA: 0xBC03F0
    public void get_path(){} // RVA: 0xCD3320
    public void set_path(){} // RVA: 0xCD4740
    public void get_position(){} // RVA: 0xCD48B0
    public void set_position(){} // RVA: 0xCD3600
    public void get_rotation(){} // RVA: 0xB813B0
    public void set_rotation(){} // RVA: 0xD5CBB0
    public void get_scale(){} // RVA: 0x1069350
    public void set_scale(){} // RVA: 0xD5CC10
    public void get_variables(){} // RVA: 0x106A7D0
    public void set_variables(){} // RVA: 0xD5CC70
    public void .ctor(){} // RVA: 0xA505100
}

public class AttributeEntry[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class AttributeOverride : ValueType
{
    public object m_ElementName;
    public object m_NamesPath;
    public object m_AttributeName;
    public object m_Value;

    // ── Methods ──
    public void NamesPathMatchesElementNamesPath(){} // RVA: 0x99AA90
}

public class AttributeOverrideRange : ValueType
{
    public object sourceAsset;
    public object attributeOverrides;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x76310
}

public class AuthEnvelopedSecureReadable : Object
{
    public object parent;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void get_Algorithm(){} // RVA: 0x13F92F0
    public void get_CryptoObject(){} // RVA: 0xDAC980
    public void GetReadable(){} // RVA: 0xA337180
}

public class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs
{
    public object Reserved;
    public object s_completedSentinel;
    public object s_availableSentinel;
    public object _continuation;
    public object _executionContext;
    public object _scheduler;
    public object _token;
    public object _wrapExceptionsInIOExceptions;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x760B880
    public void get_WrapExceptionsInIOExceptions(){} // RVA: 0x760B940
    public void set_WrapExceptionsInIOExceptions(){} // RVA: 0x760B950
    public void Reserve(){} // RVA: 0x760B960
    public void Release(){} // RVA: 0x760BA30
    public void OnCompleted(){} // RVA: 0x760C330
    public void ReceiveAsync(){} // RVA: 0x760BEB0
    public void SendAsyncForNetworkStream(){} // RVA: 0x760C0D0
    public void GetStatus(){} // RVA: 0x760C290
    public void InvokeContinuation(){} // RVA: 0x760C670
    public void GetResult(){} // RVA: 0x760C980
    public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x760C9E0
    public void ThrowIncorrectTokenException(){} // RVA: 0x760CA30
    public void ThrowMultipleContinuationsException(){} // RVA: 0x760CA80
    public void ThrowException(){} // RVA: 0x760CAD0
    public void CreateException(){} // RVA: 0x760CB00
    public void .cctor(){} // RVA: 0x760CC20
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746010
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746010
}

public class Awaiter : ValueType
{
    public object _coroutine;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void OnCompleted(){} // RVA: 0x894320
    public void get_IsCompleted(){} // RVA: 0x87D280
    public void GetResult(){} // RVA: 0xA94080
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x769C70
    public void UnsafeOnCompleted(){} // RVA: 0x769D70
    public void SourceOnCompleted(){} // RVA: 0x769D80
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746010
    public void get_IsCompleted(){} // RVA: 0x746020
    public void GetResult(){} // RVA: 0x747280
    public void OnCompleted(){} // RVA: 0x76E220
    public void UnsafeOnCompleted(){} // RVA: 0x76E320
    public void SourceOnCompleted(){} // RVA: 0x746290
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746010
    public void get_IsCompleted(){} // RVA: 0x746020
    public void GetResult(){} // RVA: 0x747280
    public void OnCompleted(){} // RVA: 0x7472C0
    public void UnsafeOnCompleted(){} // RVA: 0x7473C0
    public void SourceOnCompleted(){} // RVA: 0x746290
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746010
    public void get_IsCompleted(){} // RVA: 0x746020
    public void GetResult(){} // RVA: 0x747280
    public void OnCompleted(){} // RVA: 0x7472C0
    public void UnsafeOnCompleted(){} // RVA: 0x7473C0
    public void SourceOnCompleted(){} // RVA: 0x746290
}

public class Awaiter : ValueType
{
    public object timing;
    public object cancellationToken;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3616C0
    public void GetAwaiter(){} // RVA: 0x7BF80
    public void get_IsCompleted(){} // RVA: 0x9208E0
    public void GetResult(){} // RVA: 0x9208F0
    public void OnCompleted(){} // RVA: 0x920900
    public void UnsafeOnCompleted(){} // RVA: 0x920960
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x769C70
    public void UnsafeOnCompleted(){} // RVA: 0x769D70
    public void SourceOnCompleted(){} // RVA: 0x769D80
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}
