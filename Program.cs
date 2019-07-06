using Encapsulation;
using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
                people.Add(person);
            }
            Team team = new Team("SoftUni");

            foreach (var person in people)
            {
                team.AddPlayer(person);
            }
            Console.WriteLine($"first team players = {team.FirstTeam.Count}");
            Console.WriteLine($"secont team players = {team.ReverseTeam.Count}");


        }
    }
}
