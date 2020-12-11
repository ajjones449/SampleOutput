using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            int rmLeng = "16"; //Room length

            int rmWidt = "10"; //Room width
            int sqFt; //Room area in Sq. Ft.
            double costSqFt = "2.23"; //Cost per Sq. Ft. of carpet
            double ttlCost; //Total carpet cost
            ////////////Above:  Variable declaration, Below:  Calculations
            sqFt = rmLeng * rmWidt; //Calculate area
            ttlCost = sqFt * costSqFt;
            Console.WriteLine("A room that is {0} feet long by {1} feet wide has an area of {2} square feet.  If you use carpet that cost {3} a square foot, the total cost of the carpet would be {4}!", rmLeng, rmWidt, sqFt, costSqFt, ttlCost);
            Console.ReadLine();
        }
    }
}
