using System;
class Program
{
    
    static void Main()
    {
        //ReadName();
        //buildinTypes();
        //WriteName();
        CommonOperators();



    }
    static void ReadName ()
    {
        Console.WriteLine("\"welcome to C# my man\"");
        Console.WriteLine("One\nTwo\nThree");
        
        

    }

    static void WriteName()
    {
        //Use Contactination
        Console.WriteLine("Enter your first name:");
        String FirstName = Console.ReadLine();

        Console.WriteLine("Enter your last name:");
        String LastName = Console.ReadLine();


        //Use Contactination
        //Console.WriteLine("Hello " + UserName + ",nice to meet you");

        //Use Placeholder
        Console.WriteLine("Hello {0} {1}, nice to meet you", FirstName, LastName);
    }

    static void CommonOperators()
    {
        Console.WriteLine("Enter first number");
        String FirstNumber = Console.ReadLine();
        int fnumber = Int32.Parse(FirstNumber);

        Console.WriteLine("Enter second number");
        String LastNumber = Console.ReadLine();
        int snumber = Int32.Parse(LastNumber);

        int result = fnumber - snumber;
        Console.WriteLine("result = {0} " ,result);

        if(result == 10 || result < 5)
        {
            Console.WriteLine("This is awesome");
        }
        else if(result > 10 && result < 20)
        {
            Console.WriteLine("This is great");
        }
        else
        {
            Console.WriteLine("This is perfect");
        }

    }

    static void buildinTypes()
    {
        int x = 0;
        Console.WriteLine("MinValue is {0} and MaxValue is {1}", int.MinValue, int.MaxValue);
    }


}
