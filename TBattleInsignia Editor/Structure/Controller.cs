using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBattleInsignia_Editor
{
    class Controller
    {
        public Structure[] Structures;

        public Controller(UInt16 SizeStructure)
        {
            Structures = new Structure[SizeStructure];
        }

        public void RaiseStructureSize(int Size = 1)
        {
            Structure[] array = new Structure[Structures.Length + Size];
            for (int i = 0; i < Structures.Length; i++)
            {
                array[i] = Structures[i];
            }
            Structures = array;
        }

        public void DeleteStructure(Int16 position)
        {
            if (position != -1)
            {
                Structure[] array = new Structure[Structures.Length - 1];

                int i;
                for (i = 0; i < position; i++)
                {
                    array[i] = Structures[i];
                }
                for (; i < Structures.Length - 1; i++)
                {
                    array[i] = Structures[i + 1];
                }
                Structures = array;
            }
        }
    }
}
