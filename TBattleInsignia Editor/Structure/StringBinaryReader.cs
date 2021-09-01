using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TBattleInsignia_Editor
{
    class StringBinaryReader : BinaryReader
    {
        public StringBinaryReader(Stream input) : base(input)
        {

        }

        public override string ReadString()
        {
            Byte[] String = new Byte[base.ReadByte()];
            for (int i = 0; i < String.Length; i++)
            {
                String[i] = base.ReadByte();
            }
            return System.Text.Encoding.Default.GetString(String);
        }
    }
}
