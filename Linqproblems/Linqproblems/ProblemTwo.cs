using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqproblems
{
    class ProblemTwo
    {
        public ProblemTwo()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };

            var distinctNames = names.Distinct();
            foreach (var name in distinctNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

    }
}
