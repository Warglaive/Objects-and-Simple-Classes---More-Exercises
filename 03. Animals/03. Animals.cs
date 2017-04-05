using System;
using System.Collections.Generic;

namespace _03.Animals
{
    public class Program
    {
        public static void Main()
        {
            var dogResult = new Dictionary<string, Dog>();
            var catResult = new Dictionary<string, Cat>();
            var snakeResult = new Dictionary<string, Snake>();
            var command = Console.ReadLine();
            while (command != "I'm your Huckleberry")
            {
                var token = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (token.Length > 3)
                {
                    var inputClass = token[0];
                    var name = token[1];
                    var age = int.Parse(token[2]);
                    var parameter = int.Parse(token[3]);
                    if (inputClass == "Dog")
                    {
                        var currentDog = new Dog();
                        currentDog.Name = name;
                        currentDog.Age = age;
                        currentDog.NumberOfLegs = parameter;
                        dogResult[name] = currentDog;
                    }
                    else if (inputClass == "Cat")
                    {
                        var currentCat = new Cat();
                        currentCat.Name = name;
                        currentCat.Age = age;
                        currentCat.IntelligenceQuotient = parameter;
                        catResult[name] = currentCat;
                    }
                    else if (inputClass == "Snake")
                    {
                        var currentSnake = new Snake();
                        currentSnake.Name = name;
                        currentSnake.Age = age;
                        currentSnake.CrueltyCoefficient = parameter;
                        snakeResult[name] = currentSnake;
                    }
                    command = Console.ReadLine();
                }
                else
                {
                    if (command == "I'm your Huckleberry")
                    {
                        break;
                    }
                    token = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string animalName = token[1];
                    if (dogResult.ContainsKey(animalName))
                    {
                        dogResult[animalName].ProduceSound();
                        
                    }
                    else if (catResult.ContainsKey(animalName))
                    {
                        catResult[animalName].ProduceSound();
                    }
                    else if (snakeResult.ContainsKey(animalName))
                    {
                        snakeResult[animalName].ProduceSound();
                    }
                    command = Console.ReadLine();
                    if (command == "I'm your Huckleberry")
                    {
                        break;
                    }
                }
                if (command == "I'm your Huckleberry")
                {
                    break;
                }
            }
            foreach (var dog in dogResult.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
                    
            }
            foreach (var cat in catResult.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }
            foreach (var snake in snakeResult.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }
    }
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }
        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
                
        }
    }
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IntelligenceQuotient { get; set; }
        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau."); 
        }
    }
    public class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }
        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }
}