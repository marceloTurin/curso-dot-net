using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;
using Course.Entities.Enums;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Coment c1 = new Coment("Have a nice strip");
            Coment c2 = new Coment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/6/2018 13:05:44"),
                "Traveling to new Zealand",
                "I'm going to visit this wonderfaul country",
                12
            );

            p1.AddComent(c1);
            p1.AddComent(c2);

            Coment c3 = new Coment("Good night");
            Coment c4 = new Coment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/6/2018 13:05:44"),
                "Good night guys",
                "See you tomorrow",
                5
            );

            p2.AddComent(c3);
            p2.AddComent(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }



    }
}