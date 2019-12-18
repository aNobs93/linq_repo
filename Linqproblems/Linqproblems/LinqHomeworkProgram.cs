using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqproblems
{
    class LinqHomeworkProgram
    {
        public LinqHomeworkProgram()
        {

        }

        public List<string> ProblemOne()
        {
            var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsWeWant = words.Where(w => w.Contains("th")).ToList();

            return wordsWeWant;
        }

        public List<string> ProblemTwo()
        {
            var names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            var distinctNames = names.Distinct().ToList();
            return distinctNames;
        }

        public double ProblemThree()
        {
            var classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            var integerGrades = new List<List<double>>();
            var gradeSums = new List<double>();
            foreach (var grades in classGrades)
            {
                var gradesAsInt = Array.ConvertAll(grades.Split(','), double.Parse).ToList();
                integerGrades.Add(gradesAsInt);
            }
            foreach (var grades in integerGrades)
            {
                grades.Sort();
            }
            foreach (var grades in integerGrades)
            {
                grades.RemoveAt(0);
            }
            foreach (var grades in integerGrades)
            {
                var individualAverage = grades.Sum() / grades.Count;
                gradeSums.Add(individualAverage);
            }

            var classTotal = gradeSums.Sum();

            var average = classTotal / classGrades.Count();
            return average;
        }
    }
}
