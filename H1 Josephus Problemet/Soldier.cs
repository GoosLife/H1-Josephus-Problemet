using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Josephus_Problemet
{
    internal class Soldier
    {
        // The soldiers initial position
        private int initialIndex;
        public int InitialIndex
        {
            get { return initialIndex; }
            private set { initialIndex = value; }
        }

        public Soldier(int index)
        {
            InitialIndex = index;
        }
    }
}
