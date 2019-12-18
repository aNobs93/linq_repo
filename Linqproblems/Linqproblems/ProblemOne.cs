using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqproblems
{
    class ProblemOne
    {
        public ProblemOne()
        {
            var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsWithTH = new List<string>();

            foreach (var word in words)
            {
                if (word.Contains("th"))
                {
                    wordsWithTH.Add(word);
                }
            }
            foreach (var word in wordsWithTH)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
