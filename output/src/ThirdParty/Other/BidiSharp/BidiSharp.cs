// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.BidiSharp
// Classes: 2
// Methods: 29

namespace ThirdParty.Other.BidiSharp
{
    public class Bidi : Object
    {
        public int MAX_DEPTH;
        public URA.DateTime<char,char> _bracketPairs;

        // ── Methods ──
        public void LogicalToVisual(){} // RVA: 0x7FFD53654570
        public void ClassifyCharacters(){} // RVA: 0x7FFD53654E90
        public void GetParagraphEmbeddingLevel(){} // RVA: 0x7FFD53655020
        public void GetExplicitEmbeddingLevels(){} // RVA: 0x7FFD536550B0
        public void ResolveWeaks(){} // RVA: 0x7FFD53655710
        public void ResolveNeutrals(){} // RVA: 0x7FFD53655BC0
        public void ResolveImplicit(){} // RVA: 0x7FFD53655E30
        public void ApplyTypesAndLevels(){} // RVA: 0x7FFD53656010
        public void GetReorderedIndexes(){} // RVA: 0x7FFD536560C0
        public void GetMatchingPDI(){} // RVA: 0x7FFD53656380
        public void RemoveX9Characters(){} // RVA: 0x7FFD536565C0
        public void GetLevelRuns(){} // RVA: 0x7FFD53656620
        public void GetRunForCharacter(){} // RVA: 0x7FFD536567E0
        public void GetIsolatingRunSequences(){} // RVA: 0x7FFD53656900
        public void ComputeIsolatingRunSequence(){} // RVA: 0x7FFD53656D40
        public void SetLevels(){} // RVA: 0x7FFD53657110
        public void GetRunLimit(){} // RVA: 0x7FFD53657170
        public void SetRunTypes(){} // RVA: 0x7FFD536571F0
        public void LeastGreaterOdd(){} // RVA: 0x7FFD53657240
        public void LeastGreaterEven(){} // RVA: 0x7FFD53657290
        public void IsOdd(){} // RVA: 0x7FFD536572E0
        public void GetTypeForLevel(){} // RVA: 0x7FFD536572F0
        public void GetTextLevels(){} // RVA: 0x7FFD53657300
        public void GetMultiLineReordered(){} // RVA: 0x7FFD53657430
        public void ComputeReorderingIndexes(){} // RVA: 0x7FFD536575D0
        public void ReverseStringAndFlipBrackets(){} // RVA: 0x7FFD536577E0
        public void GetOrderedString(){} // RVA: 0x7FFD53657AF0
        public void .cctor(){} // RVA: 0x7FFD53657C80
    }

    public class Bidi_Types : Object
    {
        public byte[] BidiCharTypes;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD53657ED0
    }

}