using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
    public class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }
    }
   public class Program
    {
       public static void Main()
        {
            var input = Console.ReadLine();


            var result = new List<Exercise>();
            while (input!="go go go")
            {
                var token = input.Split(new[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var topic = token[0];
                var courseName = token[1];
                var judgeContestLink = token[2];
                var problems = token.Skip(3).ToList();


                var newExercise = new Exercise();

                newExercise.Topic = topic;
                newExercise.CourseName = courseName;
                newExercise.JudgeContestLink = judgeContestLink;
                newExercise.Problems = problems;
                result.Add(newExercise);
                input = Console.ReadLine();
            }
            foreach (var item in result)
            {
                var counter = 1;
                Console.WriteLine("Exercises: {0}", item.Topic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.", item.CourseName);
                Console.WriteLine("Check your solutions here: {0}", item.JudgeContestLink);
                foreach (var problem in item.Problems)
                {
                    Console.WriteLine("{0}. {1}", counter, problem);
                    counter++;
                }
            }
        }
    }
}