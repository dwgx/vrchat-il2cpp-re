// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib
// Classes: 14
// Methods: 186

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib
{
    public class Adler32
    {
        // ── Methods ──
        public void adler32(){} // RVA: 0x7FFAFBF19F90
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Deflate
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC0613C0
        public void .ctor(){} // RVA: 0x7FFAFC061BC0
        public void lm_init(){} // RVA: 0x7FFAFC061FC0
        public void tr_init(){} // RVA: 0x7FFAFC0621B0
        public void init_block(){} // RVA: 0x7FFAFC0624C0
        public void pqdownheap(){} // RVA: 0x7FFAFC0625B0
        public void smaller(){} // RVA: 0x7FFAFC062810
        public void scan_tree(){} // RVA: 0x7FFAFC062890
        public void build_bl_tree(){} // RVA: 0x7FFAFC062A60
        public void send_all_trees(){} // RVA: 0x7FFAFC062BA0
        public void send_tree(){} // RVA: 0x7FFAFC062D00
        public void put_byte(){} // RVA: 0x7FFAFC063010 | overloaded x2
        public void put_short(){} // RVA: 0x7FFAFC063050
        public void putShortMSB(){} // RVA: 0x7FFAFC0630B0
        public void send_code(){} // RVA: 0x7FFAFC063110
        public void send_bits(){} // RVA: 0x7FFAFC063160
        public void _tr_align(){} // RVA: 0x7FFAFC063230
        public void _tr_tally(){} // RVA: 0x7FFAFC063390
        public void compress_block(){} // RVA: 0x7FFAFC063640
        public void set_data_type(){} // RVA: 0x7FFAFC0639A0
        public void bi_flush(){} // RVA: 0x7FFAFC063A70
        public void bi_windup(){} // RVA: 0x7FFAFC063B40
        public void copy_block(){} // RVA: 0x7FFAFC063C00
        public void flush_block_only(){} // RVA: 0x7FFAFC063D20
        public void deflate_stored(){} // RVA: 0x7FFAFC063D90
        public void _tr_stored_block(){} // RVA: 0x7FFAFC063F60
        public void _tr_flush_block(){} // RVA: 0x7FFAFC064080
        public void fill_window(){} // RVA: 0x7FFAFC064550
        public void deflate_fast(){} // RVA: 0x7FFAFC064810
        public void deflate_slow(){} // RVA: 0x7FFAFC064C80
        public void longest_match(){} // RVA: 0x7FFAFC065180
        public void deflateInit(){} // RVA: 0x7FFAFC065590 | overloaded x2
        public void deflateInit2(){} // RVA: 0x7FFAFC0655C0
        public void deflateReset(){} // RVA: 0x7FFAFC065900
        public void deflateEnd(){} // RVA: 0x7FFAFC0659F0
        public void deflateParams(){} // RVA: 0x7FFAFC065B70
        public void deflateSetDictionary(){} // RVA: 0x7FFAFC065DE0
        public void deflate(){} // RVA: 0x7FFAFC065FC0
    }

    public class InfBlocks
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0665E0
        public void reset(){} // RVA: 0x7FFAFC066950
        public void proc(){} // RVA: 0x7FFAFC0669E0
        public void free(){} // RVA: 0x7FFAFC067C60
        public void set_dictionary(){} // RVA: 0x7FFAFC067D90
        public void sync_point(){} // RVA: 0x7FFAFC067DE0
        public void inflate_flush(){} // RVA: 0x7FFAFC067DF0
        public void .cctor(){} // RVA: 0x7FFAFC067F60
    }

    public class InfCodes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void init(){} // RVA: 0x7FFAFC068100
        public void proc(){} // RVA: 0x7FFAFC068230
        public void free(){} // RVA: 0x7FFAF2D8D310
        public void inflate_fast(){} // RVA: 0x7FFAFC068DC0
        public void .cctor(){} // RVA: 0x7FFAFC069760
    }

    public class InfTree
    {
        // ── Methods ──
        public void huft_build(){} // RVA: 0x7FFAFC06AC60
        public void inflate_trees_bits(){} // RVA: 0x7FFAFC06B5A0
        public void inflate_trees_dynamic(){} // RVA: 0x7FFAFC06B7A0
        public void inflate_trees_fixed(){} // RVA: 0x7FFAFC06BB80
        public void initWorkArea(){} // RVA: 0x7FFAFC06BC70
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC06C040
    }

    public class Inflate
    {
        // ── Methods ──
        public void inflateReset(){} // RVA: 0x7FFAFC069840
        public void inflateEnd(){} // RVA: 0x7FFAFC069950
        public void inflateInit(){} // RVA: 0x7FFAFC069AF0
        public void inflate(){} // RVA: 0x7FFAFC069E50
        public void inflateSetDictionary(){} // RVA: 0x7FFAFC06A780
        public void inflateSync(){} // RVA: 0x7FFAFC06A8D0
        public void inflateSyncPoint(){} // RVA: 0x7FFAFC06AAC0
        public void .ctor(){} // RVA: 0x7FFAFC06AAF0
        public void .cctor(){} // RVA: 0x7FFAFC06AB80
    }

    public class JZlib
    {
        // ── Methods ──
        public void version(){} // RVA: 0x7FFAFC06C460
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class LowMemoryCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC06C4A0
        public void .cctor(){} // RVA: 0x7FFAFC06C570
    }

    public class ZDeflaterOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC06CA00 | overloaded x3
        public void get_CanRead(){} // RVA: 0x7FFAF2D8D320
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAF2E72850
        public void get_Length(){} // RVA: 0x7FFAF2FC9240
        public void get_Position(){} // RVA: 0x7FFAF2FC9240
        public void set_Position(){} // RVA: 0x7FFAF2D8D310
        public void Write(){} // RVA: 0x7FFAFC06CC40
        public void Seek(){} // RVA: 0x7FFAF2FC9240
        public void SetLength(){} // RVA: 0x7FFAF2D8D310
        public void Read(){} // RVA: 0x7FFAF2FC9240
        public void Flush(){} // RVA: 0x7FFAFC06CE90
        public void WriteByte(){} // RVA: 0x7FFAFC06CEC0
        public void Finish(){} // RVA: 0x7FFAFC06CF10
        public void End(){} // RVA: 0x7FFAFC06D0E0
        public void Close(){} // RVA: 0x7FFAFC06D170
    }

    public class ZInflaterInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC06D370 | overloaded x2
        public void get_CanRead(){} // RVA: 0x7FFAF2E72850
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAF2D8D320
        public void get_Length(){} // RVA: 0x7FFAF2FC9240
        public void get_Position(){} // RVA: 0x7FFAF2FC9240
        public void set_Position(){} // RVA: 0x7FFAF2D8D310
        public void Write(){} // RVA: 0x7FFAF2D8D310
        public void Seek(){} // RVA: 0x7FFAF2FC9240
        public void SetLength(){} // RVA: 0x7FFAF2D8D310
        public void Read(){} // RVA: 0x7FFAFC06D620
        public void Flush(){} // RVA: 0x7FFAFC06CE90
        public void WriteByte(){} // RVA: 0x7FFAF2D8D310
        public void Close(){} // RVA: 0x7FFAFC06D860
        public void ReadByte(){} // RVA: 0x7FFAFC06D8E0
    }

    public class ZInputStream
    {
        // ── Methods ──
        public void GetDefaultZStream(){} // RVA: 0x7FFAFC06D950
        public void .ctor(){} // RVA: 0x7FFAFC06DE10 | overloaded x5
        public void get_CanRead(){} // RVA: 0x7FFAF7AF2220
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAF2D8D320
        public void Close(){} // RVA: 0x7FFAFC06E0C0
        public void Flush(){} // RVA: 0x7FFAF2D8D310
        public void get_FlushMode(){} // RVA: 0x7FFAF2DE8CD0
        public void set_FlushMode(){} // RVA: 0x7FFAF2DE8CE0
        public void get_Length(){} // RVA: 0x7FFAFC06E150
        public void get_Position(){} // RVA: 0x7FFAFC06E190
        public void set_Position(){} // RVA: 0x7FFAFC06E1D0
        public void Read(){} // RVA: 0x7FFAFC06E210
        public void ReadByte(){} // RVA: 0x7FFAFC06D8E0
        public void Seek(){} // RVA: 0x7FFAFC06E4A0
        public void SetLength(){} // RVA: 0x7FFAFC06E4E0
        public void get_TotalIn(){} // RVA: 0x7FFAF6B3F310
        public void get_TotalOut(){} // RVA: 0x7FFAF8B1C090
        public void Write(){} // RVA: 0x7FFAFC06E520
    }

    public class ZOutputStream
    {
        // ── Methods ──
        public void GetDefaultZStream(){} // RVA: 0x7FFAFC06E560
        public void .ctor(){} // RVA: 0x7FFAFC06E9A0 | overloaded x5
        public void get_CanRead(){} // RVA: 0x7FFAF2D8D320
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAF7AF2220
        public void Close(){} // RVA: 0x7FFAFC06EBE0
        public void DoClose(){} // RVA: 0x7FFAFC06EC10
        public void End(){} // RVA: 0x7FFAFC06ED80
        public void Finish(){} // RVA: 0x7FFAFC06EEB0
        public void Flush(){} // RVA: 0x7FFAFC06F0E0
        public void get_FlushMode(){} // RVA: 0x7FFAF2DE8CD0
        public void set_FlushMode(){} // RVA: 0x7FFAF2DE8CE0
        public void get_Length(){} // RVA: 0x7FFAFC06F110
        public void get_Position(){} // RVA: 0x7FFAFC06F150
        public void set_Position(){} // RVA: 0x7FFAFC06F190
        public void Read(){} // RVA: 0x7FFAFC06F1D0
        public void Seek(){} // RVA: 0x7FFAFC06F210
        public void SetLength(){} // RVA: 0x7FFAFC06F250
        public void get_TotalIn(){} // RVA: 0x7FFAF6B3F310
        public void get_TotalOut(){} // RVA: 0x7FFAF8B1C090
        public void Write(){} // RVA: 0x7FFAFC06F290
        public void WriteByte(){} // RVA: 0x7FFAFC06CEC0
    }

    public class ZStream
    {
        // ── Methods ──
        public void inflateInit(){} // RVA: 0x7FFAFC06F570 | overloaded x4
        public void inflate(){} // RVA: 0x7FFAFC06F6E0
        public void inflateEnd(){} // RVA: 0x7FFAFC06F700
        public void inflateSync(){} // RVA: 0x7FFAFC06F790
        public void inflateSetDictionary(){} // RVA: 0x7FFAFC06F7B0
        public void deflateInit(){} // RVA: 0x7FFAFC06F970 | overloaded x4
        public void deflate(){} // RVA: 0x7FFAFC06FA70
        public void deflateEnd(){} // RVA: 0x7FFAFC06FA90
        public void deflateParams(){} // RVA: 0x7FFAFC06FC90
        public void deflateSetDictionary(){} // RVA: 0x7FFAFC06FCD0
        public void flush_pending(){} // RVA: 0x7FFAFC06FD10
        public void read_buf(){} // RVA: 0x7FFAFC06FDD0
        public void free(){} // RVA: 0x7FFAFC06FE90
        public void .ctor(){} // RVA: 0x7FFAFC06FFE0
    }

    public class ZTree
    {
        // ── Methods ──
        public void d_code(){} // RVA: 0x7FFAFC070070
        public void gen_bitlen(){} // RVA: 0x7FFAFC070130
        public void build_tree(){} // RVA: 0x7FFAFC0704F0
        public void gen_codes(){} // RVA: 0x7FFAFC070B40
        public void bi_reverse(){} // RVA: 0x7FFAFC070CE0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC070D10
    }

}