// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Decompression.Zlib
// Classes: 17
// Methods: 192

namespace ThirdParty.BestHTTP.BestHTTP.Decompression.Zlib
{
    public class Adler
    {
        // ── Methods ──
        public void Adler32(){} // RVA: 0x9826AC0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9826E30
    }

    public class DeflateManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9817B70
        public void _InitializeLazyMatch(){} // RVA: 0x9818050
        public void _InitializeTreeData(){} // RVA: 0x9818190
        public void _InitializeBlocks(){} // RVA: 0x98184B0
        public void pqdownheap(){} // RVA: 0x9818670
        public void _IsSmaller(){} // RVA: 0x98188D0
        public void scan_tree(){} // RVA: 0x9818950
        public void build_bl_tree(){} // RVA: 0x9818BE0
        public void send_all_trees(){} // RVA: 0x9818D60
        public void send_tree(){} // RVA: 0x9818EC0
        public void put_bytes(){} // RVA: 0x9819240
        public void send_code(){} // RVA: 0x9819290
        public void send_bits(){} // RVA: 0x98192E0
        public void _tr_align(){} // RVA: 0x9819450
        public void _tr_tally(){} // RVA: 0x9819640
        public void send_compressed_block(){} // RVA: 0x9819950
        public void set_data_type(){} // RVA: 0x9819D30
        public void bi_flush(){} // RVA: 0x9819EE0
        public void bi_windup(){} // RVA: 0x9819FC0
        public void copy_block(){} // RVA: 0x981A090
        public void flush_block_only(){} // RVA: 0x981A1B0
        public void DeflateNone(){} // RVA: 0x981A220
        public void _tr_stored_block(){} // RVA: 0x981A4E0
        public void _tr_flush_block(){} // RVA: 0x981A660
        public void _fillWindow(){} // RVA: 0x981ACA0
        public void DeflateFast(){} // RVA: 0x981B030
        public void DeflateSlow(){} // RVA: 0x981B5D0
        public void longest_match(){} // RVA: 0x981BCF0
        public void get_WantRfc1950HeaderBytes(){} // RVA: 0x116BE40
        public void set_WantRfc1950HeaderBytes(){} // RVA: 0x116F020
        public void Initialize(){} // RVA: 0x981C3C0 | overloaded x4
        public void Reset(){} // RVA: 0x981C780
        public void End(){} // RVA: 0x981CA30
        public void SetDeflater(){} // RVA: 0x981CCC0
        public void SetParams(){} // RVA: 0x981CEE0
        public void SetDictionary(){} // RVA: 0x981D010
        public void Deflate(){} // RVA: 0x981D340
        public void .cctor(){} // RVA: 0x981DBA0
    }

    public class DeflateStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x981E770 | overloaded x5
        public void get_FlushMode(){} // RVA: 0x981E900
        public void set_FlushMode(){} // RVA: 0x981E920
        public void get_BufferSize(){} // RVA: 0x981E9A0
        public void set_BufferSize(){} // RVA: 0x981E9C0
        public void get_Strategy(){} // RVA: 0x981EB40
        public void set_Strategy(){} // RVA: 0x981EB60
        public void get_TotalIn(){} // RVA: 0x981EBE0
        public void get_TotalOut(){} // RVA: 0x981EC10
        public void Dispose(){} // RVA: 0x981EC40
        public void get_CanRead(){} // RVA: 0x981ECC0
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x981ED50
        public void Flush(){} // RVA: 0x981EDE0
        public void get_Length(){} // RVA: 0x981EE70
        public void get_Position(){} // RVA: 0x981EEB0
        public void set_Position(){} // RVA: 0x981EF00
        public void Read(){} // RVA: 0x981EF40
        public void Seek(){} // RVA: 0x981EFD0
        public void SetLength(){} // RVA: 0x668EB50
        public void Write(){} // RVA: 0x981F010
    }

    public class GZipStream
    {
        // ── Methods ──
        public void get_Comment(){} // RVA: 0x3A5500
        public void set_Comment(){} // RVA: 0x981F0A0
        public void get_FileName(){} // RVA: 0x37E0E0
        public void set_FileName(){} // RVA: 0x981F150
        public void get_Crc32(){} // RVA: 0x59CEC0
        public void .ctor(){} // RVA: 0x981F410 | overloaded x4
        public void get_FlushMode(){} // RVA: 0x981F520
        public void set_FlushMode(){} // RVA: 0x981F540
        public void get_BufferSize(){} // RVA: 0x981F5C0
        public void set_BufferSize(){} // RVA: 0x981F5E0
        public void get_TotalIn(){} // RVA: 0x981F760
        public void get_TotalOut(){} // RVA: 0x981F790
        public void Dispose(){} // RVA: 0x981F7C0
        public void get_CanRead(){} // RVA: 0x981F860
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x981F8F0
        public void Flush(){} // RVA: 0x981F980
        public void get_Length(){} // RVA: 0x981FA10
        public void get_Position(){} // RVA: 0x981FA50
        public void set_Position(){} // RVA: 0x981FAB0
        public void Read(){} // RVA: 0x981FAF0
        public void Seek(){} // RVA: 0x981FC70
        public void SetLength(){} // RVA: 0x981FCB0
        public void Write(){} // RVA: 0x981FCE0
        public void EmitHeader(){} // RVA: 0x981FE00
        public void .cctor(){} // RVA: 0x9820290
    }

    public class InfTree
    {
        // ── Methods ──
        public void huft_build(){} // RVA: 0x9824B50
        public void inflate_trees_bits(){} // RVA: 0x9825490
        public void inflate_trees_dynamic(){} // RVA: 0x9825690
        public void inflate_trees_fixed(){} // RVA: 0x9825A70
        public void initWorkArea(){} // RVA: 0x9825B60
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9825F30
    }

    public class InflateBlocks
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x98203A0
        public void Reset(){} // RVA: 0x9820730
        public void Process(){} // RVA: 0x98207E0
        public void Free(){} // RVA: 0x9821CE0
        public void SetDictionary(){} // RVA: 0x9821E00
        public void SyncPoint(){} // RVA: 0x95B7DE0
        public void Flush(){} // RVA: 0x9821E50
        public void .cctor(){} // RVA: 0x9821FF0
    }

    public class InflateCodes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Init(){} // RVA: 0x95B8100
        public void Process(){} // RVA: 0x98221B0
        public void InflateFast(){} // RVA: 0x9822D70
    }

    public class InflateManager
    {
        // ── Methods ──
        public void get_HandleRfc1950HeaderBytes(){} // RVA: 0x303450
        public void set_HandleRfc1950HeaderBytes(){} // RVA: 0x303460
        public void .ctor(){} // RVA: 0x303460 | overloaded x2
        public void Reset(){} // RVA: 0x9823710
        public void End(){} // RVA: 0x98237B0
        public void Initialize(){} // RVA: 0x9823950
        public void Inflate(){} // RVA: 0x9823BC0
        public void SetDictionary(){} // RVA: 0x98246A0
        public void Sync(){} // RVA: 0x9824840
        public void SyncPoint(){} // RVA: 0x9824A40
        public void .cctor(){} // RVA: 0x9824A70
    }

    public class InternalConstants
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x9826560
    }

    public class InternalInflateConstants
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x98220D0
    }

    public class SharedUtils
    {
        // ── Methods ──
        public void URShift(){} // RVA: 0x9826400
        public void ReadInput(){} // RVA: 0x9826410
        public void ToByteArray(){} // RVA: 0x9469E40
        public void ToCharArray(){} // RVA: 0x9826520
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class StaticTree
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95BC4A0
        public void .cctor(){} // RVA: 0x9826660
    }

    public class ZTree
    {
        // ── Methods ──
        public void DistanceCode(){} // RVA: 0x9829FC0
        public void gen_bitlen(){} // RVA: 0x982A080
        public void build_tree(){} // RVA: 0x982A4E0
        public void gen_codes(){} // RVA: 0x982AA50
        public void bi_reverse(){} // RVA: 0x95C0CE0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x982AC30
    }

    public class ZlibBaseStream
    {
        // ── Methods ──
        public void get_Crc32(){} // RVA: 0x9826E90
        public void .ctor(){} // RVA: 0x9826EE0 | overloaded x2
        public void get__wantCompress(){} // RVA: 0x98270E0
        public void get_z(){} // RVA: 0x98270F0
        public void get_workingBuffer(){} // RVA: 0x9827220
        public void Write(){} // RVA: 0x98272E0
        public void finish(){} // RVA: 0x98276D0
        public void end(){} // RVA: 0x9827FC0
        public void Close(){} // RVA: 0x98282A0
        public void Flush(){} // RVA: 0x98283B0
        public void Seek(){} // RVA: 0x98283E0
        public void SetLength(){} // RVA: 0x9828420
        public void ReadZeroTerminatedString(){} // RVA: 0x9828460
        public void _ReadAndValidateGzipHeader(){} // RVA: 0x9828680
        public void Read(){} // RVA: 0x9828B10
        public void get_CanRead(){} // RVA: 0x9829170
        public void get_CanSeek(){} // RVA: 0x98291A0
        public void get_CanWrite(){} // RVA: 0x98291D0
        public void get_Length(){} // RVA: 0x9829200
        public void get_Position(){} // RVA: 0x9829230
        public void set_Position(){} // RVA: 0x9829270
    }

    public class ZlibCodec
    {
        // ── Methods ──
        public void get_Adler32(){} // RVA: 0x9EAB90
        public void .ctor(){} // RVA: 0x98292C0 | overloaded x2
        public void InitializeInflate(){} // RVA: 0x9829430 | overloaded x4
        public void Inflate(){} // RVA: 0x9829550
        public void EndInflate(){} // RVA: 0x98295C0
        public void SyncInflate(){} // RVA: 0x9829690
        public void InitializeDeflate(){} // RVA: 0x9829760 | overloaded x5
        public void _InternalInitializeDeflate(){} // RVA: 0x9829780
        public void Deflate(){} // RVA: 0x9829930
        public void EndDeflate(){} // RVA: 0x98299A0
        public void ResetDeflate(){} // RVA: 0x9829A50
        public void SetDeflateParams(){} // RVA: 0x9829AC0
        public void SetDictionary(){} // RVA: 0x9829C50
        public void flush_pending(){} // RVA: 0x9829CF0
        public void read_buf(){} // RVA: 0x9829EB0
    }

    public class ZlibConstants
    {
    }

    public class ZlibException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x98263A0 | overloaded x2
    }

}