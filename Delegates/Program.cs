using System;
using Oops;


class program
{
    //Create a new Datatype
    //Viz. DECLARATION OF DELEGATE
    public delegate void BlackPink(string requirement);

    static void Main()
    {
        // DelegatesBlackPink();
        //Delegates();
        Thread t1 = new Thread(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Hand Movement animation:: y-co-rnidate={i}");
            }
        });
        t1.Name = "Hand-animation";

        Thread t2 = new Thread(() =>
        {
            for (int i = 0; i > 100; i--)
            {
                Console.WriteLine($"Ball Movement animation:: y-co-rnidate={i}");
            }
        });
        t2.Name = "Ball-animation";
        //start the threads
        t1.Start();
        t2.Start();
        Thread.Sleep(3000);
        Console.WriteLine("====The game has complted====");



        //Collection of Rectangles
        List<Rectangle> rectangles = new List<Rectangle>();
        rectangles.Add(new Rectangle(10, 5));
        rectangles.Add(new Rectangle(10, 3));
        rectangles.Add(new Rectangle(20, 7));
        rectangles.Add(new Rectangle(25, 5));

        //query: get all rectangles whose length=10
        rectangles
            .Where((r) => { return r.length == 10; })
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Length: {r.length} | {r.breadth}");
            });

        //using LINQ ~ sql in .net
        var searchedRectangles = from r in rectangles
                                 where r.length == 10
                                 select r;

        //Display
        searchedRectangles
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Output from LINQ:Rectangle Length X Breadth::{r.length} X {r.breadth} ");
            });


        //Lab 15
        // Write lambda and Linq query for
        //query: get all rectangles whose breadth = 3
        //query: get all rectangles whose  length=10 breadth = 5
        rectangles
           .Where((r) => { return r.breadth == 3; })
           .ToList()
           .ForEach((r) =>
           {
               Console.WriteLine($"Breadth: {r.length} | {r.breadth}");
           });

        //using LINQ ~ sql in .net
        var searchedRectangles1 = from r in rectangles
                                 where r.breadth == 3
                                 select r;

        //Display
        searchedRectangles1
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Output from LINQ:Rectangle Length X Breadth::{r.length} X {r.breadth} ");
            });

        //length=10 and breadth=5
        rectangles
           .Where((r) => { return r.length == 10 && r.breadth==5; })
           .ToList()
           .ForEach((r) =>
           {
               Console.WriteLine($"Length: {r.length} | {r.breadth}");
           });

        //using LINQ ~ sql in .net
        var searchedRectangles2 = from r in rectangles
                                 where r.length == 10 && r.breadth==5
                                 select r;

        //Display
        searchedRectangles2
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Output from LINQ:Rectangle Length X Breadth::{r.length} X {r.breadth} ");
            });



        // private static void DelegatesBlackPink()
        {
            //object or instantiation of delegate
            BlackPink Lisa = new BlackPink((requirement) => { Console.WriteLine("I, Jennie have started preparation for Pink Venom"); });
            Lisa += (requirement) => { Console.WriteLine("I, Rose have started preparation for How you like that"); };
            Lisa += (requirement) => { Console.WriteLine("I, Jisoo have started preparation for Ice-cream!!"); };

            //calling Lisa
            //INVOKING DELEGATE
            Lisa("Preparation for the Stage Concert");
        }

        //private static void Jisoo(string requirement)
        {
            Console.WriteLine("I, Jisoo have started preparation for the Stage Concert");
        }

        //private static void Rose(string requirement)
        {
            Console.WriteLine("I, Rose have started preparation for the Stage Concert");
        }

        //    private static void Jennie(string requirement)
        {
            Console.WriteLine("I, Jennie have started preparation for the Stage Concert");
        }
    }

    private static void Delegates()
    {
        List<string> names = new List<string>();
        names.Add("Lisa");
        names.Add("Jennie");
        names.Add("Rose");
        names.Add("Jisoo");

        names.ForEach((str) =>
        {
            Console.WriteLine(str);
        });

        List<string> result = names.Where((str) =>
        {
            return str == "Jennie";
        }).ToList();

        Console.WriteLine("Search for Jennie");
        result.ForEach((str) =>
        {
            Console.WriteLine($"Found match for: {str}");
        });
    }
}

