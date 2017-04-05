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
<<<<<<< HEAD
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
=======
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
>>>>>>> 658d3e1db967a0c0019df25d83cbe6c8ffb6cce2
                }
            }
        }
    }
}