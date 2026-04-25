// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.BidiSharp
// Classes: 2
// Methods: 29

namespace ThirdParty.Other.BidiSharp
{
    public class Bidi : Object
    {
        public int MAX_DEPTH;
        public System.Collections.Generic.Dictionary`2<char,char> _bracketPairs;

        // ── Methods ──
        public void LogicalToVisual(){} // RVA: 0x7FFAC8234570
        public void ClassifyCharacters(){} // RVA: 0x7FFAC8234E90
        public void GetParagraphEmbeddingLevel(){} // RVA: 0x7FFAC8235020
        public void GetExplicitEmbeddingLevels(){} // RVA: 0x7FFAC82350B0
        public void ResolveWeaks(){} // RVA: 0x7FFAC8235710
        public void ResolveNeutrals(){} // RVA: 0x7FFAC8235BC0
        public void ResolveImplicit(){} // RVA: 0x7FFAC8235E30
        public void ApplyTypesAndLevels(){} // RVA: 0x7FFAC8236010
        public void GetReorderedIndexes(){} // RVA: 0x7FFAC82360C0
        public void GetMatchingPDI(){} // RVA: 0x7FFAC8236380
        public void RemoveX9Characters(){} // RVA: 0x7FFAC82365C0
        public void GetLevelRuns(){} // RVA: 0x7FFAC8236620
        public void GetRunForCharacter(){} // RVA: 0x7FFAC82367E0
        public void GetIsolatingRunSequences(){} // RVA: 0x7FFAC8236900
        public void ComputeIsolatingRunSequence(){} // RVA: 0x7FFAC8236D40
        public void SetLevels(){} // RVA: 0x7FFAC8237110
        public void GetRunLimit(){} // RVA: 0x7FFAC8237170
        public void SetRunTypes(){} // RVA: 0x7FFAC82371F0
        public void LeastGreaterOdd(){} // RVA: 0x7FFAC8237240
        public void LeastGreaterEven(){} // RVA: 0x7FFAC8237290
        public void IsOdd(){} // RVA: 0x7FFAC82372E0
        public void GetTypeForLevel(){} // RVA: 0x7FFAC82372F0
        public void GetTextLevels(){} // RVA: 0x7FFAC8237300
        public void GetMultiLineReordered(){} // RVA: 0x7FFAC8237430
        public void ComputeReorderingIndexes(){} // RVA: 0x7FFAC82375D0
        public void ReverseStringAndFlipBrackets(){} // RVA: 0x7FFAC82377E0
        public void GetOrderedString(){} // RVA: 0x7FFAC8237AF0
        public void .cctor(){} // RVA: 0x7FFAC8237C80
    }

    public class Bidi_Types : Object
    {
        public byte[] BidiCharTypes;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8237ED0
    }

}