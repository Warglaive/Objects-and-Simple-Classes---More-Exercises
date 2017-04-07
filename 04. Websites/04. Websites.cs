using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Websites
{
    public class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }
    }
   public class Program
    {
       public static void Main()
        {
            var input = Console.ReadLine();
            var result = new List<Website>();
            while (input != "end") 
            {
                var token = input.Split(new[] { ' ', '|',',' },StringSplitOptions.RemoveEmptyEntries);
                var host = token[0];
                var domain = token[1];
                var queries = token.Skip(2).ToList();
                var newWebsite = new Website();
                newWebsite.Host = host;
                newWebsite.Domain = domain;
                newWebsite.Queries = queries;
                result.Add(newWebsite);
                input = Console.ReadLine();
            }
            foreach (var hostDomainAndQuery in result)
            {
                if (hostDomainAndQuery.Queries.Count > 1)
                {
                    Console.Write($"https://www.{hostDomainAndQuery.Host}.{hostDomainAndQuery.Domain}/");
                    for (int i = 0; i < 1; i++)
                    {
                        Console.Write($"query?=[{hostDomainAndQuery.Queries[i]}]");
                        for (int j = i + 1; j < hostDomainAndQuery.Queries.Count; j++)
                        {
                            Console.Write($"&[{hostDomainAndQuery.Queries[j]}]");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"https://www.{hostDomainAndQuery.Host}.{hostDomainAndQuery.Domain}");
                }
                Console.WriteLine();
            }
        }
    }
}