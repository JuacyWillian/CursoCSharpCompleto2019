using System;

using Exercicio210.Entities;


namespace Exercicio210
{
    class Program
    {
        static void Main(string[] args)
        {

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Travaling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
            );

            p1.AddComment(new Comment("Have a nice trip"));
            p1.AddComment(new Comment("Wow that's awesome!"));

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
            );

            p2.AddComment(new Comment("Good night"));
            p2.AddComment(new Comment("May the force be with you"));


            Console.WriteLine();
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
