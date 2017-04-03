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
            var exercises = new List<Exercise>();
            string inputLine = Console.ReadLine();
            while (inputLine != "go go go")
            {
                var inputParams = inputLine.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string topic = inputParams[0];
                string courseName = inputParams[1];
                string JudgeContestLink = inputParams[2];
                List<string> problems = inputParams.Skip(3).ToList();

                var newExercise = new Exercise();
                newExercise.Topic = topic;
                newExercise.CourseName = courseName;
                newExercise.JudgeContestLink = JudgeContestLink;
                newExercise.Problems = problems;
                exercises.Add(newExercise);
                inputLine = Console.ReadLine();
            }
            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here {exercise.JudgeContestLink}");

                var count = 1;
                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine("{0}. {1}", count, problem);
                    count++;
                }
            }
        }
    }
}