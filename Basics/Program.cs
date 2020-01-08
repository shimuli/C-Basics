using System;
class Program
{
    
    static void Main()
    {
        //ReadName();
        //buildinTypes();
        //WriteName();
        //CommonOperators();
        //CoalescingOperators();
        //NotNullable();
        //DatatypeConv();
        //MyArray();
        Ifstatement();



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

    static void NotNullable()
    {
        bool? myname = null;
        if(myname == true)
        {
            Console.WriteLine("This is my name");
        }

         else if (myname == false)
        {
            Console.WriteLine("This is not my name");
        }

        else
        {
            Console.WriteLine("None of the above");
        }
    }

    static void CoalescingOperators()
    {
        int? TicketsOnSale = 206345673;
        int AvailableTickets = TicketsOnSale ?? 0;
        

            Console.WriteLine("Available ticket {0}", AvailableTickets);
        
    }

    static void DatatypeConv()
    {
        int num = 23;
        //inplicit
        float numfloat = num;
        Console.WriteLine(numfloat);

        //explicit
        float fnumber = 34.544F;
        int inumber = (int)fnumber;
        int intnumber = Convert.ToInt32(fnumber);

        //string
        string snumber = "10000";
        int isnum = int.Parse(snumber);

        Console.WriteLine(fnumber);
        Console.WriteLine(inumber);
        Console.WriteLine(intnumber);
        Console.WriteLine(isnum);

        string mynumber = "232YOU";
         bool isCorrect = int.TryParse(mynumber, out int result);
        if(isCorrect)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("You are not serious");
        }


    }

    static void MyArray()
    {
        /*khjbjkjg
         * fighkvkhjnlkh
            */
        int[] theArray = new int[4];
        theArray[0] = 4;
        theArray[1] = 3;
        theArray[2] = 7;
        theArray[3] = 9;

        Console.WriteLine(theArray[0]);
    }

    static void Ifstatement()
    {
        Console.WriteLine("Enter a number");
        int mynumber = int.Parse(Console.ReadLine());

        if (mynumber == 2)
        {
            Console.WriteLine("Your number is 2");
        }
        else if (mynumber == 4)
        {
            Console.WriteLine("Your number is 4");
        }
        else
        {
            Console.WriteLine("Your number is {0}", mynumber);
        }
    }


}
