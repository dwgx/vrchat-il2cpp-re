// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Decompression.Zlib
// Classes: 16
// Methods: 171

namespace ThirdParty.BestHTTP.BestHTTP.Decompression.Zlib
{
    public class Adler : Object
    {
        // ── Methods ──
        public void Adler32(){} // RVA: 0x7B1661330
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B16616D0
    }

    public class DeflateManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1651F40
        public void _InitializeLazyMatch(){} // RVA: 0x7B1652420
        public void _InitializeTreeData(){} // RVA: 0x7B1652560
        public void _InitializeBlocks(){} // RVA: 0x7B1652880
        public void pqdownheap(){} // RVA: 0x7B1652A80
        public void _IsSmaller(){} // RVA: 0x7B1652CF0
        public void scan_tree(){} // RVA: 0x7B1652D70
        public void build_bl_tree(){} // RVA: 0x7B1653030
        public void send_all_trees(){} // RVA: 0x7B16531C0
        public void send_tree(){} // RVA: 0x7B1653330
        public void put_bytes(){} // RVA: 0x7B16536D0
        public void send_code(){} // RVA: 0x7B1653720
        public void send_bits(){} // RVA: 0x7B1653770
        public void _tr_align(){} // RVA: 0x7B16538E0
        public void _tr_tally(){} // RVA: 0x7B1653AD0
        public void send_compressed_block(){} // RVA: 0x7B1653DF0
        public void set_data_type(){} // RVA: 0x7B16541D0
        public void bi_flush(){} // RVA: 0x7B1654390
        public void bi_windup(){} // RVA: 0x7B1654470
        public void copy_block(){} // RVA: 0x7B1654540
        public void flush_block_only(){} // RVA: 0x7B1654660
        public void DeflateNone(){} // RVA: 0x7B16546D0
        public void _tr_stored_block(){} // RVA: 0x7B1654990
        public void _tr_flush_block(){} // RVA: 0x7B1654B10
        public void _fillWindow(){} // RVA: 0x7B1655000
        public void DeflateFast(){} // RVA: 0x7B16553A0
        public void DeflateSlow(){} // RVA: 0x7B1655940
        public void longest_match(){} // RVA: 0x7B1656060
        public void get_WantRfc1950HeaderBytes(){} // RVA: 0x7A8F242C0
        public void set_WantRfc1950HeaderBytes(){} // RVA: 0x7A8F26CE0
        public void Initialize(){} // RVA: 0x7B1656740
        public void Reset(){} // RVA: 0x7B1656B00
        public void End(){} // RVA: 0x7B1656DB0
        public void SetDeflater(){} // RVA: 0x7B1657040
        public void SetParams(){} // RVA: 0x7B1657260
        public void SetDictionary(){} // RVA: 0x7B16573B0
        public void Deflate(){} // RVA: 0x7B16576E0
        public void .cctor(){} // RVA: 0x7B1657F40
    }

    public class DeflateStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1658B10
        public void get_FlushMode(){} // RVA: 0x7B1658CA0
        public void set_FlushMode(){} // RVA: 0x7B1658CC0
        public void get_BufferSize(){} // RVA: 0x7B1658D40
        public void set_BufferSize(){} // RVA: 0x7B1658D60
        public void get_Strategy(){} // RVA: 0x7B1658EE0
        public void set_Strategy(){} // RVA: 0x7B1658F00
        public void get_TotalIn(){} // RVA: 0x7B1658F80
        public void get_TotalOut(){} // RVA: 0x7B1658FB0
        public void Dispose(){} // RVA: 0x7B1658FE0
        public void get_CanRead(){} // RVA: 0x7B1659060
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7B16590F0
        public void Flush(){} // RVA: 0x7B1659180
        public void get_Length(){} // RVA: 0x7B1659210
        public void get_Position(){} // RVA: 0x7B1659250
        public void set_Position(){} // RVA: 0x7B16592A0
        public void Read(){} // RVA: 0x7B16592E0
        public void Seek(){} // RVA: 0x7B1659370
        public void SetLength(){} // RVA: 0x7AE47D1C0
        public void Write(){} // RVA: 0x7B16593B0
    }

    public class GZipStream : Stream
    {
        // ── Methods ──
        public void get_Comment(){} // RVA: 0x7A81A0050
        public void set_Comment(){} // RVA: 0x7B1659440
        public void get_FileName(){} // RVA: 0x7A8178B90
        public void set_FileName(){} // RVA: 0x7B16594F0
        public void get_Crc32(){} // RVA: 0x7A83562E0
        public void .ctor(){} // RVA: 0x7B16597B0
        public void get_FlushMode(){} // RVA: 0x7B16598D0
        public void set_FlushMode(){} // RVA: 0x7B16598F0
        public void get_BufferSize(){} // RVA: 0x7B1659970
        public void set_BufferSize(){} // RVA: 0x7B1659990
        public void get_TotalIn(){} // RVA: 0x7B1659B10
        public void get_TotalOut(){} // RVA: 0x7B1659B40
        public void Dispose(){} // RVA: 0x7B1659B70
        public void get_CanRead(){} // RVA: 0x7B1659C10
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7B1659CA0
        public void Flush(){} // RVA: 0x7B1659D30
        public void get_Length(){} // RVA: 0x7B1659DC0
        public void get_Position(){} // RVA: 0x7B1659E00
        public void set_Position(){} // RVA: 0x7B1659E60
        public void Read(){} // RVA: 0x7B1659EA0
        public void Seek(){} // RVA: 0x7B165A020
        public void SetLength(){} // RVA: 0x7B165A060
        public void Write(){} // RVA: 0x7B165A090
        public void EmitHeader(){} // RVA: 0x7B165A1B0
        public void .cctor(){} // RVA: 0x7B165A640
    }

    public class InfTree : Object
    {
        // ── Methods ──
        public void huft_build(){} // RVA: 0x7B165F300
        public void inflate_trees_bits(){} // RVA: 0x7B165FCE0
        public void inflate_trees_dynamic(){} // RVA: 0x7B165FEE0
        public void inflate_trees_fixed(){} // RVA: 0x7B16602D0
        public void initWorkArea(){} // RVA: 0x7B16603C0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1660790
    }

    public class InflateBlocks : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B165A750
        public void Reset(){} // RVA: 0x7B165AB00
        public void Process(){} // RVA: 0x7B165ABB0
        public void Free(){} // RVA: 0x7B165C340
        public void SetDictionary(){} // RVA: 0x7B165C460
        public void SyncPoint(){} // RVA: 0x7B13EED20
        public void Flush(){} // RVA: 0x7B165C4B0
        public void .cctor(){} // RVA: 0x7B165C650
    }

    public class InflateCodes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Init(){} // RVA: 0x7B13EF040
        public void Process(){} // RVA: 0x7B165C810
        public void InflateFast(){} // RVA: 0x7B165D480
    }

    public class InflateManager : Object
    {
        // ── Methods ──
        public void get_HandleRfc1950HeaderBytes(){} // RVA: 0x7A80FD690
        public void set_HandleRfc1950HeaderBytes(){} // RVA: 0x7A80FD6A0
        public void .ctor(){} // RVA: 0x7A80FD6A0
        public void Reset(){} // RVA: 0x7B165DEA0
        public void End(){} // RVA: 0x7B165DF40
        public void Initialize(){} // RVA: 0x7B165E0E0
        public void Inflate(){} // RVA: 0x7B165E360
        public void SetDictionary(){} // RVA: 0x7B165EE40
        public void Sync(){} // RVA: 0x7B165EFD0
        public void SyncPoint(){} // RVA: 0x7B165F1F0
        public void .cctor(){} // RVA: 0x7B165F220
    }

    public class InternalConstants : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B1660DC0
    }

    public class InternalInflateConstants : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B165C730
    }

    public class SharedUtils : Object
    {
        // ── Methods ──
        public void URShift(){} // RVA: 0x7B1660C60
        public void ReadInput(){} // RVA: 0x7B1660C70
        public void ToByteArray(){} // RVA: 0x7B129DBE0
        public void ToCharArray(){} // RVA: 0x7B1660D80
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class StaticTree : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13F3660
        public void .cctor(){} // RVA: 0x7B1660EC0
    }

    public class ZTree : Object
    {
        // ── Methods ──
        public void DistanceCode(){} // RVA: 0x7B1664890
        public void gen_bitlen(){} // RVA: 0x7B1664950
        public void build_tree(){} // RVA: 0x7B1664DF0
        public void gen_codes(){} // RVA: 0x7B1665360
        public void bi_reverse(){} // RVA: 0x7B13F7E10
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1665560
    }

    public class ZlibBaseStream : Stream
    {
        // ── Methods ──
        public void get_Crc32(){} // RVA: 0x7B1661730
        public void .ctor(){} // RVA: 0x7B1661780
        public void get__wantCompress(){} // RVA: 0x7B1661990
        public void get_z(){} // RVA: 0x7B16619A0
        public void get_workingBuffer(){} // RVA: 0x7B1661AC0
        public void Write(){} // RVA: 0x7B1661B80
        public void finish(){} // RVA: 0x7B1661F90
        public void end(){} // RVA: 0x7B1662890
        public void Close(){} // RVA: 0x7B1662B70
        public void Flush(){} // RVA: 0x7B1662C80
        public void Seek(){} // RVA: 0x7B1662CB0
        public void SetLength(){} // RVA: 0x7B1662CF0
        public void ReadZeroTerminatedString(){} // RVA: 0x7B1662D30
        public void _ReadAndValidateGzipHeader(){} // RVA: 0x7B1662F50
        public void Read(){} // RVA: 0x7B16633E0
        public void get_CanRead(){} // RVA: 0x7B1663A30
        public void get_CanSeek(){} // RVA: 0x7B1663A60
        public void get_CanWrite(){} // RVA: 0x7B1663A90
        public void get_Length(){} // RVA: 0x7B1663AC0
        public void get_Position(){} // RVA: 0x7B1663AF0
        public void set_Position(){} // RVA: 0x7B1663B30
    }

    public class ZlibCodec : Object
    {
        // ── Methods ──
        public void get_Adler32(){} // RVA: 0x7A87A7DA0
        public void .ctor(){} // RVA: 0x7B1663B80
        public void InitializeInflate(){} // RVA: 0x7B1663CE0
        public void Inflate(){} // RVA: 0x7B1663E00
        public void EndInflate(){} // RVA: 0x7B1663E70
        public void SyncInflate(){} // RVA: 0x7B1663F40
        public void InitializeDeflate(){} // RVA: 0x7B1664010
        public void _InternalInitializeDeflate(){} // RVA: 0x7B1664030
        public void Deflate(){} // RVA: 0x7B16641E0
        public void EndDeflate(){} // RVA: 0x7B1664250
        public void ResetDeflate(){} // RVA: 0x7B1664310
        public void SetDeflateParams(){} // RVA: 0x7B1664380
        public void SetDictionary(){} // RVA: 0x7B1664520
        public void flush_pending(){} // RVA: 0x7B16645C0
        public void read_buf(){} // RVA: 0x7B1664780
    }

    public class ZlibException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1660C00
    }

}