using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Josephus_Problemet
{
    internal class SafePositionCalculator
    {
        // Recursive solution
        public int Calculate(JosephusProblem problem, int index = 0)
        {
            // Return the initial position of the last standing soldier.
            if (problem.Soldiers.Count == 1)
            {
                return problem.Soldiers[0].InitialIndex;
            }

            // Update the index to be the index of the soldier who is about to be executed
            index = ((index + problem.Interval) % problem.Soldiers.Count); // This nifty little calculation allows us to roll over and continue counting from 0,
                                                                           // when our index + interval exceeds the amount of soldiers left.

            // Execute soldier
            problem.Soldiers.RemoveAt(index);

            // Run the function recursively until one last soldier stands, then return that soldiers starting position.
            int result = Calculate(problem, index);
            return result;
        }
    }
}
