using System.Collections.Generic;
using System.IO;

namespace BluntKeys
{
    class ScanCodeMap
    {
        public List<(ushort FromKey, ushort ToKey)> Entries = new List<(ushort, ushort)>();

        public ScanCodeMap() { }
        public ScanCodeMap(byte[] bytes) => Parse(bytes);

        public byte[] Serialize()
        {
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                bw.Write(0);                        //version reserved- set to 0
                bw.Write(0);                        //flags reserved-   set to 0
                bw.Write(Entries.Count + 1);        //number of mappings + terminator
                foreach (var mapping in Entries)
                {
                    bw.Write(mapping.ToKey);
                    bw.Write(mapping.FromKey);
                }
                bw.Write(0);                        //null terminator-  set to 0
                return ms.ToArray();
            }
        }

        public void Parse(byte[] bytes)
        {
            // Start offset 	Size  	Data
            // ------------     ----    ----
            // 0 				4 		Header: Version Information
            // 4 				4 		Header: Flags
            // 8 				4 		Header: Number of Mappings
            // 12 				4 		Individual Mapping
            // ... 				... 	...
            // Last 4 bytes 	4 		Null Terminator (0x00000000)

            Entries = new List<(ushort FromKey, ushort ToKey)>();
            if (bytes.Length < 16) //Mimimum size of a valid scancode map
                return;

            using (var ms = new MemoryStream(bytes))
            using (var br = new BinaryReader(ms))
            {
                br.ReadInt32();                             //ignore version
                br.ReadInt32();                             //ignore flags

                for (int i = br.ReadInt32(); 1 < i; i--)    //skip the null final mapping.
                {
                    var toKey = br.ReadUInt16();
                    var fromKey = br.ReadUInt16();
                    Entries.Add((fromKey, toKey));
                }
            }
        }
    }
}
