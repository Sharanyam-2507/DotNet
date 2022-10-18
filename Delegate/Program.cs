using System;
using System.Security.Cryptography.X509Certificates;

class program
{
    public delegate void Calculate(int n1, int n2);
       
static void Main()
    {
        //delegateCalci();
       // SimpleLinq();
    }

    private static void SimpleLinq()
    {
        List<string> names = new List<string>();
        names.Add("Reena");
        names.Add("Meena");
        names.Add("Teena");
        names.Add("Reena Rai");

        names.ForEach((str) =>
        {
            Console.WriteLine(str);
        });


        List<string> result = names.Where((str) =>
        {
            //return str.StartsWith("Re") && str.EndsWith("na");
            return str.StartsWith("Re") || str.EndsWith("na");

        }).ToList();

        Console.WriteLine("Search for Re");
        result.ForEach((str) =>
        {
            Console.WriteLine($"Found match for: {str}");
        });

        //LINQ => Language Integrated Query ==SQL in .Net
        Console.WriteLine("----USING LINQ-----");
        var queryoutput = (from str in names
                           where str.Contains("Reena") && str.Contains("Rai")
                           select str).ToList();
        queryoutput.ForEach((str) => { Console.WriteLine(str); }

         );
    }

    private static void delegateCalci()
    {
        Calculate Cal = new((n1, n2) => { Console.WriteLine($"The Addition of n1 and n2 is {n1 + n2}"); });
        Cal += (n1, n2) => { Console.WriteLine($"The Subtaction of n1 and n2 is {n1 - n2}"); };
        Cal += (n1, n2) => { Console.WriteLine($"The multiplication of n1 and n2 is {n1 * n2}"); };
        Cal += (n1, n2) => { Console.WriteLine($"The Division of n1 and n2 is {n1 / n2}"); };
        Cal(10, 5);
    }

    private static void Division(int n1, int n2)
    {
        Console.WriteLine($"The division of n1 and n2 is {n1/n2}");
    }

    private static void Multiply(int n1, int n2)
    {
        Console.WriteLine($"The multiplication of n1 and n2 is {n1 * n2}");
    }

    private static void Subtract(int n1, int n2)
    {
        Console.WriteLine($"The subtraction of n1 and n2 is {n1 - n2}");
    }

    private static void Add(int n1, int n2)
    {
        Console.WriteLine($"The addition of n1 and n2 is {n1 + n2}");
    }
}
    