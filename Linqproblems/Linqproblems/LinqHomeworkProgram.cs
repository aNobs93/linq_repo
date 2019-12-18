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

        public List<string> ProblemOne(List<string> words)
        {
            var wordsWeWant = words.Where(w => w.Contains("th")).ToList();

            return wordsWeWant;
        }

        public List<string> ProblemTwo(List<string> names)
        {
            var distinctNames = names.Distinct().ToList();
            return distinctNames;
        }

        public double ProblemThree(List<string> classGrades)
        {
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

        public string ProblemFour(string str)
        {
            var setOfCountedCharacters = new List<string>();
            str = str.ToLower();

            foreach (var characterToCheck in str)
            {
                var count = str.Where(c => (c == characterToCheck) && !(c == ' ')).Count().ToString();
                string charAndCount = characterToCheck + count;
                if (!setOfCountedCharacters.Contains(charAndCount))
                {
                    setOfCountedCharacters.Add(charAndCount);
                }
            }

            setOfCountedCharacters.Sort();

            StringBuilder strBuilder = new StringBuilder();
            foreach (var item in setOfCountedCharacters)
            {
                strBuilder.AppendLine(item);
            }

            return strBuilder.ToString();
        }
    }
}

