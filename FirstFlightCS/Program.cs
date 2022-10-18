// See https://aka.ms/new-console-template for more information
using System;
using Oops;
class Program
{
    static void Main(string[] args)
    {
        //CallParamsAndNullableTypes()
        // VirtualOverriding();
        //UseOverloading();
        // UsingAbstract();

        //base = new derived
        //derived =base
        IEmpContract Kim = new KpmgEmployee();
        Console.WriteLine($"Sick Leaves clause for Kim: { Kim.SickLeavesClause()}");
        Console.WriteLine($"Work hours clause for Kim:{Kim.WorkHourClause()}");

        IEmpContract Taehyung = new DellEmployee();
        Console.WriteLine($"Sick Leaves clause for Taehyung:{Taehyung.SickLeavesClause()}");
        Console.WriteLine($"Work hours clause for Taehyung:{Taehyung.WorkHourClause()}");    

    }

    private static void UsingAbstract()
    {
        Shape sh = new Circle() { Radius = 5 };
        sh.Draw();
    }

    private static void VirtualOverriding()
    {
        Console.WriteLine("--Parent p= new Child()");
        //base class = newDerivedClass()
        Parent Meena = new Child();
        Meena.ChooseCareer(); //without permission overriding
        Meena.NoNightOuts(); // without permission hiding

        Console.WriteLine("Child ch = new Child()");
        Child nxgenChild = new Child();
        nxgenChild.NoNightOuts(); //child's function will be called
    }

    private static void UseOverloading()
    {
        ToDo myToDo = new ToDo()
        {
            Name = "Coding",
            StartDate = DateTime.Now.AddDays(-15),
            EndDate = DateTime.Now.AddDays(15),
            IsCompleted = false
        };
        myToDo.Create(0);
        myToDo.Name = "Angular Training";
        myToDo.StartDate = DateTime.Now.AddDays(-10);
        myToDo.EndDate = DateTime.Now.AddDays(-4);
        myToDo.IsCompleted = true;

        myToDo.Create(1);
        //view all tools
        myToDo.ViewToDos();
        myToDo.ViewToDos("Coding");
    }

    private static void UsingInheritance()
    {
        Rectangle r1 = new Rectangle(20, 5);
        float area = r1.CalculateArea();
        Console.WriteLine($"Area of R1 with length" + $"{r1.length} and breadth {r1.breadth} is" + $"{area}");

        square sq1 = new square(10);
        area = sq1.CalculateArea();
        Console.WriteLine($"Area of sq1 with length" + $"{sq1.length} and breadth {sq1.breadth} is" + $"{area}");
    }

    private static void CallParamsAndNullableTypes()
    {
        OrderFood();

        //UseArithmeticFunctions();//PrintAndRead();
        var intNum = 100;
        var doubleNum = 100d;
        var floatNum = 100f;
        var decimalNum = 100m;
        Console.WriteLine($"Datatype of intNum is: {intNum.GetType().ToString()}");
        Console.WriteLine($"Datatype of doubleNum is: {doubleNum.GetType().ToString()}");
        Console.WriteLine($"Datatype of floatNum is: {floatNum.GetType().ToString()}");
        Console.WriteLine($"Datatype of decimalNum is: {decimalNum.GetType().ToString()}");

        DefaultAndNullable("Coding", null, true);
        DefaultAndNullable("Training", "Typescript", true);
        var empId = 123456;
        Execute("Storeproceedure", "Name: spselAll");
        Execute("query", "select * from emp", $"where id={empId}");
    }

    static void DefaultAndNullable(string task, string? details, bool isCompleted = false)
    {
        Console.WriteLine(task);
        Console.WriteLine(details);
        Console.WriteLine(isCompleted); 
    }

    static void Execute(params string[] p1)
    {
        Console.WriteLine("Execution deatails are:");
        for (int i = 0; i < p1.Length; i++)
        {
            Console.WriteLine(p1[i]);
        }  
    }
    public static void OrderFood() {
        Console.WriteLine($"Enter the Food");
        var food = Console.ReadLine();
        Console.WriteLine($"Enter the cost of the food");
        double gst = 0.18;
       // double cost = 200;
        double cost = Convert.ToDouble(Console.ReadLine());
        double gst1 = gst * cost;
        Console.WriteLine($"The total cost of the food is: { cost + gst1}");
    
    }

    private static void UseArithmeticFunctions()
    {
        try
        {
            Calculate(100, 25, "Add");
            Calculate(100, 25, "Subtract");
            Calculate(100, 25, "Multiply");
            Calculate(100, 25, "Divide");
            Calculate(100, 25, "Exponent");

        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Something has gone wrong,"
                + $"Please contact support with this error code:{ex.Message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    private static void PrintAndRead()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("wassup :-)");
        Console.WriteLine("How you guys doing??");

        Console.WriteLine("The person's name is :");
        Console.WriteLine("Lives in");
        Console.WriteLine("Hobbies are");

        var input = Console.ReadLine();
        var input1 = Console.ReadLine();
        var input2 = Console.ReadLine();

        Console.WriteLine(input);
        Console.WriteLine(input1);
        Console.WriteLine(input2);

        Console.WriteLine("The person's name is " + input + ". " + input + "Lives in " + input1 + ". " + input + "Hobbies are " + input2 + ".");
        Console.WriteLine("Improvised Concatenation:{0}", input);  //dotnet old version
        Console.WriteLine($"Latest technique of concatenation: {input}");   //dotnet latest
    }
    static void Calculate(int num1, int num2, string operationType)
    {
        //Take 2 numbers from user
        //Take which operation to perform from user
        //use switch case and write the code for all arithmetic operations

        switch (operationType)
        {
            case "Add":
                Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
                break;
            case "Subtract":
                Console.WriteLine($"The difference of {num1} and {num2} is {num1 - num2}");
                break;
            case "Multiply":
                Console.WriteLine($"The product of {num1} and {num2} is {num1 * num2}");
                break;
            case "Divide":
                Console.WriteLine($"The division of {num1} and {num2} is {num1 / num2}");
                break;

            default:
                throw new Exception("ERR-1001");

        }
    }
}



