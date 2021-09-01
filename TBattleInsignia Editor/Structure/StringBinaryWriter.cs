using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TBattleInsignia_Editor
{
    class StringBinaryWriter : BinaryWriter
    {
        public StringBinaryWriter(Stream input) : base(input)
        {

        }

        public override void Write(String value)
        {
            base.Write(Convert.ToByte(value.Length));
            base.Write(Encoding.Default.GetBytes(value));
        }
    }
}
