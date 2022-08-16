using System;
using System.Collections.Generic;

namespace H1_Josephus_Problemet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new Josephus problem with an amount of soldiers and an execution interval
            JosephusProblem exampleProblem = new JosephusProblem(41, 3);

            // Create a calculator object, that can calculate which position will be Last Man Standing
            SafePositionCalculator spc = new SafePositionCalculator();
            
            // Output the solution to the problem
            Console.WriteLine(spc.Calculate(exampleProblem));
        }
    }
}