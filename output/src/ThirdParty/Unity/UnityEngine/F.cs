// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 8
// Methods: 25

namespace ThirdParty.Unity.UnityEngine
{
    public class FailedToLoadScriptObject : Object
    {
    }

    public class FixedJoint : Joint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class FixedJoint2D : AnchoredJoint2D
    {
        public object dampingRatio;
        public object frequency;
        public object referenceAngle;

        // ── Methods ──
        public void get_dampingRatio(){} // RVA: 0x7FFAC99852F0
        public void set_dampingRatio(){} // RVA: 0x7FFAC9985340
        public void get_frequency(){} // RVA: 0x7FFAC99853A0
        public void set_frequency(){} // RVA: 0x7FFAC99853F0
        public void get_referenceAngle(){} // RVA: 0x7FFAC9985450
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Flare : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9888930
        public void Internal_Create(){} // RVA: 0x7FFAC98889C0
    }

    public class FlareLayer : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Font : Object
    {
        public System.Action`1<UnityEngine.Font> material;
        public FontTextureRebuildCallback dynamic; // 0x18

        // ── Methods ──
        public void add_textureRebuilt(){} // RVA: 0x7FFAC9A4B740
        public void remove_textureRebuilt(){} // RVA: 0x7FFAC9A4B870
        public void get_material(){} // RVA: 0x7FFAC9A4B9A0
        public void get_dynamic(){} // RVA: 0x7FFAC9A4B9F0
        public void get_fontSize(){} // RVA: 0x7FFAC9A4BA40
        public void .ctor(){} // RVA: 0x7FFAC9A4BA90
        public void InvokeTextureRebuilt_Internal(){} // RVA: 0x7FFAC9A4BB20
        public void HasCharacter(){} // RVA: 0x7FFAC9A4BC00 | overloaded x2
        public void Internal_CreateFont(){} // RVA: 0x7FFAC9A4BC60
    }

    public class FrictionJoint2D : AnchoredJoint2D
    {
        public object maxForce;
        public object maxTorque;

        // ── Methods ──
        public void get_maxForce(){} // RVA: 0x7FFAC99838C0
        public void set_maxForce(){} // RVA: 0x7FFAC9983910
        public void get_maxTorque(){} // RVA: 0x7FFAC9983970
        public void set_maxTorque(){} // RVA: 0x7FFAC99839C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class FrustumPlanes : ValueType
    {
        public float left; // 0x10
        public float right; // 0x14
        public float bottom; // 0x18
        public float top; // 0x1C
        public float zNear; // 0x20
        public float zFar; // 0x24
    }

}