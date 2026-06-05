// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Decompression.Zlib
// Classes: 17
// Methods: 192

namespace ThirdParty.BestHTTP.BestHTTP.Decompression.Zlib
{
    public class Adler
    {
        // ── Methods ──
        public void Adler32(){} // RVA: 0x7FFAFC2D6AC0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC2D6E30
    }

    public class DeflateManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2C7B70
        public void _InitializeLazyMatch(){} // RVA: 0x7FFAFC2C8050
        public void _InitializeTreeData(){} // RVA: 0x7FFAFC2C8190
        public void _InitializeBlocks(){} // RVA: 0x7FFAFC2C84B0
        public void pqdownheap(){} // RVA: 0x7FFAFC2C8670
        public void _IsSmaller(){} // RVA: 0x7FFAFC2C88D0
        public void scan_tree(){} // RVA: 0x7FFAFC2C8950
        public void build_bl_tree(){} // RVA: 0x7FFAFC2C8BE0
        public void send_all_trees(){} // RVA: 0x7FFAFC2C8D60
        public void send_tree(){} // RVA: 0x7FFAFC2C8EC0
        public void put_bytes(){} // RVA: 0x7FFAFC2C9240
        public void send_code(){} // RVA: 0x7FFAFC2C9290
        public void send_bits(){} // RVA: 0x7FFAFC2C92E0
        public void _tr_align(){} // RVA: 0x7FFAFC2C9450
        public void _tr_tally(){} // RVA: 0x7FFAFC2C9640
        public void send_compressed_block(){} // RVA: 0x7FFAFC2C9950
        public void set_data_type(){} // RVA: 0x7FFAFC2C9D30
        public void bi_flush(){} // RVA: 0x7FFAFC2C9EE0
        public void bi_windup(){} // RVA: 0x7FFAFC2C9FC0
        public void copy_block(){} // RVA: 0x7FFAFC2CA090
        public void flush_block_only(){} // RVA: 0x7FFAFC2CA1B0
        public void DeflateNone(){} // RVA: 0x7FFAFC2CA220
        public void _tr_stored_block(){} // RVA: 0x7FFAFC2CA4E0
        public void _tr_flush_block(){} // RVA: 0x7FFAFC2CA660
        public void _fillWindow(){} // RVA: 0x7FFAFC2CACA0
        public void DeflateFast(){} // RVA: 0x7FFAFC2CB030
        public void DeflateSlow(){} // RVA: 0x7FFAFC2CB5D0
        public void longest_match(){} // RVA: 0x7FFAFC2CBCF0
        public void get_WantRfc1950HeaderBytes(){} // RVA: 0x7FFAF3C1BE40
        public void set_WantRfc1950HeaderBytes(){} // RVA: 0x7FFAF3C1F020
        public void Initialize(){} // RVA: 0x7FFAFC2CC3C0 | overloaded x4
        public void Reset(){} // RVA: 0x7FFAFC2CC780
        public void End(){} // RVA: 0x7FFAFC2CCA30
        public void SetDeflater(){} // RVA: 0x7FFAFC2CCCC0
        public void SetParams(){} // RVA: 0x7FFAFC2CCEE0
        public void SetDictionary(){} // RVA: 0x7FFAFC2CD010
        public void Deflate(){} // RVA: 0x7FFAFC2CD340
        public void .cctor(){} // RVA: 0x7FFAFC2CDBA0
    }

    public class DeflateStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2CE770 | overloaded x5
        public void get_FlushMode(){} // RVA: 0x7FFAFC2CE900
        public void set_FlushMode(){} // RVA: 0x7FFAFC2CE920
        public void get_BufferSize(){} // RVA: 0x7FFAFC2CE9A0
        public void set_BufferSize(){} // RVA: 0x7FFAFC2CE9C0
        public void get_Strategy(){} // RVA: 0x7FFAFC2CEB40
        public void set_Strategy(){} // RVA: 0x7FFAFC2CEB60
        public void get_TotalIn(){} // RVA: 0x7FFAFC2CEBE0
        public void get_TotalOut(){} // RVA: 0x7FFAFC2CEC10
        public void Dispose(){} // RVA: 0x7FFAFC2CEC40
        public void get_CanRead(){} // RVA: 0x7FFAFC2CECC0
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAFC2CED50
        public void Flush(){} // RVA: 0x7FFAFC2CEDE0
        public void get_Length(){} // RVA: 0x7FFAFC2CEE70
        public void get_Position(){} // RVA: 0x7FFAFC2CEEB0
        public void set_Position(){} // RVA: 0x7FFAFC2CEF00
        public void Read(){} // RVA: 0x7FFAFC2CEF40
        public void Seek(){} // RVA: 0x7FFAFC2CEFD0
        public void SetLength(){} // RVA: 0x7FFAF913EB50
        public void Write(){} // RVA: 0x7FFAFC2CF010
    }

    public class GZipStream
    {
        // ── Methods ──
        public void get_Comment(){} // RVA: 0x7FFAF2E55500
        public void set_Comment(){} // RVA: 0x7FFAFC2CF0A0
        public void get_FileName(){} // RVA: 0x7FFAF2E2E0E0
        public void set_FileName(){} // RVA: 0x7FFAFC2CF150
        public void get_Crc32(){} // RVA: 0x7FFAF304CEC0
        public void .ctor(){} // RVA: 0x7FFAFC2CF410 | overloaded x4
        public void get_FlushMode(){} // RVA: 0x7FFAFC2CF520
        public void set_FlushMode(){} // RVA: 0x7FFAFC2CF540
        public void get_BufferSize(){} // RVA: 0x7FFAFC2CF5C0
        public void set_BufferSize(){} // RVA: 0x7FFAFC2CF5E0
        public void get_TotalIn(){} // RVA: 0x7FFAFC2CF760
        public void get_TotalOut(){} // RVA: 0x7FFAFC2CF790
        public void Dispose(){} // RVA: 0x7FFAFC2CF7C0
        public void get_CanRead(){} // RVA: 0x7FFAFC2CF860
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAFC2CF8F0
        public void Flush(){} // RVA: 0x7FFAFC2CF980
        public void get_Length(){} // RVA: 0x7FFAFC2CFA10
        public void get_Position(){} // RVA: 0x7FFAFC2CFA50
        public void set_Position(){} // RVA: 0x7FFAFC2CFAB0
        public void Read(){} // RVA: 0x7FFAFC2CFAF0
        public void Seek(){} // RVA: 0x7FFAFC2CFC70
        public void SetLength(){} // RVA: 0x7FFAFC2CFCB0
        public void Write(){} // RVA: 0x7FFAFC2CFCE0
        public void EmitHeader(){} // RVA: 0x7FFAFC2CFE00
        public void .cctor(){} // RVA: 0x7FFAFC2D0290
    }

    public class InfTree
    {
        // ── Methods ──
        public void huft_build(){} // RVA: 0x7FFAFC2D4B50
        public void inflate_trees_bits(){} // RVA: 0x7FFAFC2D5490
        public void inflate_trees_dynamic(){} // RVA: 0x7FFAFC2D5690
        public void inflate_trees_fixed(){} // RVA: 0x7FFAFC2D5A70
        public void initWorkArea(){} // RVA: 0x7FFAFC2D5B60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC2D5F30
    }

    public class InflateBlocks
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2D03A0
        public void Reset(){} // RVA: 0x7FFAFC2D0730
        public void Process(){} // RVA: 0x7FFAFC2D07E0
        public void Free(){} // RVA: 0x7FFAFC2D1CE0
        public void SetDictionary(){} // RVA: 0x7FFAFC2D1E00
        public void SyncPoint(){} // RVA: 0x7FFAFC067DE0
        public void Flush(){} // RVA: 0x7FFAFC2D1E50
        public void .cctor(){} // RVA: 0x7FFAFC2D1FF0
    }

    public class InflateCodes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Init(){} // RVA: 0x7FFAFC068100
        public void Process(){} // RVA: 0x7FFAFC2D21B0
        public void InflateFast(){} // RVA: 0x7FFAFC2D2D70
    }

    public class InflateManager
    {
        // ── Methods ──
        public void get_HandleRfc1950HeaderBytes(){} // RVA: 0x7FFAF2DB3450
        public void set_HandleRfc1950HeaderBytes(){} // RVA: 0x7FFAF2DB3460
        public void .ctor(){} // RVA: 0x7FFAF2DB3460 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAFC2D3710
        public void End(){} // RVA: 0x7FFAFC2D37B0
        public void Initialize(){} // RVA: 0x7FFAFC2D3950
        public void Inflate(){} // RVA: 0x7FFAFC2D3BC0
        public void SetDictionary(){} // RVA: 0x7FFAFC2D46A0
        public void Sync(){} // RVA: 0x7FFAFC2D4840
        public void SyncPoint(){} // RVA: 0x7FFAFC2D4A40
        public void .cctor(){} // RVA: 0x7FFAFC2D4A70
    }

    public class InternalConstants
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC2D6560
    }

    public class InternalInflateConstants
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC2D20D0
    }

    public class SharedUtils
    {
        // ── Methods ──
        public void URShift(){} // RVA: 0x7FFAFC2D6400
        public void ReadInput(){} // RVA: 0x7FFAFC2D6410
        public void ToByteArray(){} // RVA: 0x7FFAFBF19E40
        public void ToCharArray(){} // RVA: 0x7FFAFC2D6520
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class StaticTree
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC06C4A0
        public void .cctor(){} // RVA: 0x7FFAFC2D6660
    }

    public class ZTree
    {
        // ── Methods ──
        public void DistanceCode(){} // RVA: 0x7FFAFC2D9FC0
        public void gen_bitlen(){} // RVA: 0x7FFAFC2DA080
        public void build_tree(){} // RVA: 0x7FFAFC2DA4E0
        public void gen_codes(){} // RVA: 0x7FFAFC2DAA50
        public void bi_reverse(){} // RVA: 0x7FFAFC070CE0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC2DAC30
    }

    public class ZlibBaseStream
    {
        // ── Methods ──
        public void get_Crc32(){} // RVA: 0x7FFAFC2D6E90
        public void .ctor(){} // RVA: 0x7FFAFC2D6EE0 | overloaded x2
        public void get__wantCompress(){} // RVA: 0x7FFAFC2D70E0
        public void get_z(){} // RVA: 0x7FFAFC2D70F0
        public void get_workingBuffer(){} // RVA: 0x7FFAFC2D7220
        public void Write(){} // RVA: 0x7FFAFC2D72E0
        public void finish(){} // RVA: 0x7FFAFC2D76D0
        public void end(){} // RVA: 0x7FFAFC2D7FC0
        public void Close(){} // RVA: 0x7FFAFC2D82A0
        public void Flush(){} // RVA: 0x7FFAFC2D83B0
        public void Seek(){} // RVA: 0x7FFAFC2D83E0
        public void SetLength(){} // RVA: 0x7FFAFC2D8420
        public void ReadZeroTerminatedString(){} // RVA: 0x7FFAFC2D8460
        public void _ReadAndValidateGzipHeader(){} // RVA: 0x7FFAFC2D8680
        public void Read(){} // RVA: 0x7FFAFC2D8B10
        public void get_CanRead(){} // RVA: 0x7FFAFC2D9170
        public void get_CanSeek(){} // RVA: 0x7FFAFC2D91A0
        public void get_CanWrite(){} // RVA: 0x7FFAFC2D91D0
        public void get_Length(){} // RVA: 0x7FFAFC2D9200
        public void get_Position(){} // RVA: 0x7FFAFC2D9230
        public void set_Position(){} // RVA: 0x7FFAFC2D9270
    }

    public class ZlibCodec
    {
        // ── Methods ──
        public void get_Adler32(){} // RVA: 0x7FFAF349AB90
        public void .ctor(){} // RVA: 0x7FFAFC2D92C0 | overloaded x2
        public void InitializeInflate(){} // RVA: 0x7FFAFC2D9430 | overloaded x4
        public void Inflate(){} // RVA: 0x7FFAFC2D9550
        public void EndInflate(){} // RVA: 0x7FFAFC2D95C0
        public void SyncInflate(){} // RVA: 0x7FFAFC2D9690
        public void InitializeDeflate(){} // RVA: 0x7FFAFC2D9760 | overloaded x5
        public void _InternalInitializeDeflate(){} // RVA: 0x7FFAFC2D9780
        public void Deflate(){} // RVA: 0x7FFAFC2D9930
        public void EndDeflate(){} // RVA: 0x7FFAFC2D99A0
        public void ResetDeflate(){} // RVA: 0x7FFAFC2D9A50
        public void SetDeflateParams(){} // RVA: 0x7FFAFC2D9AC0
        public void SetDictionary(){} // RVA: 0x7FFAFC2D9C50
        public void flush_pending(){} // RVA: 0x7FFAFC2D9CF0
        public void read_buf(){} // RVA: 0x7FFAFC2D9EB0
    }

    public class ZlibConstants
    {
    }

    public class ZlibException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2D63A0 | overloaded x2
    }

}