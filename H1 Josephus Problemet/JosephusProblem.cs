using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Josephus_Problemet
{
    internal class JosephusProblem
    {
        // List holding all living soldiers related to the current problem
        private List<Soldier> soldiers;
        public List<Soldier> Soldiers
        {
            get { return soldiers; }
            private set { soldiers = value; }
        }

        // Total amount of soldiers
        private int soldierCount;
        public int SoldierCount
        {
            get { return soldierCount; }
            private set { soldierCount = value; }
        }

        // Execution interval
        private int interval;
        public int Interval
        {
            get { return interval; }
            private set { interval = value; }
        }

        // Create a Josephus problem to solve
        public JosephusProblem(int soldierCount, int interval)
        {
            Soldiers = new List<Soldier>();

            SoldierCount = soldierCount;
            Interval = interval - 1; // (interval - 1)th soldier will be  executed

            AddSoldiers();
        }

        // Creates as many soldiers as are needed.
        private void AddSoldiers()
        {
            for  (int i = 1; i <= SoldierCount; i++)
            {
                Soldier s = new Soldier(i);
                Soldiers.Add(s);
            }
        }
    }
}
