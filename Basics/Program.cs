using System;
class Program
{
    
    static void Main()
    {
        Program p = new Program();
        //ReadName();
        //buildinTypes();
        //WriteName();
        //CommonOperators();
        //CoalescingOperators();
        //NotNullable();
        //DatatypeConv();
        //MyArray();
        //Ifstatement();
        //switchcase();
        //whileloop();
        //p.forloop();
        int Sum= p.Add(20, 30);
        Console.WriteLine(Sum);



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

    static void switchcase()
    {
        int PizzaCost = 0;
        Console.WriteLine("Welcome To Yummy Pizza!!!");
        Console.WriteLine("-------------------------------");

        Start:
        Console.WriteLine("please Select Pizza size: ");
        Console.WriteLine("1: Small\n2: medium\n3: Large ");

        int thenumber = int.Parse(Console.ReadLine());

        switch (thenumber)
        {
            case 1:
                PizzaCost += 450;             
                break;

            case 2:
                PizzaCost += 850;               
                break;
            case 3:
                PizzaCost += 1050;               
                break;

            default:
                Console.WriteLine("{0} is invalid,please select a valid number, try again",thenumber);
                goto Start;
                
        }
        AnotherBuy:
        Console.WriteLine("Order another Pizza -Yes or No");
        String Userdecision = Console.ReadLine();
        switch (Userdecision.ToUpper())
        {
            case "YES":
                goto Start;
            case "NO":
                break;
            default:
                Console.WriteLine("Your Choice is Invalid!!!!,please try again");
                goto AnotherBuy;
                
        }
        Console.WriteLine("Thank you for shopping with us");
        Console.WriteLine("Cost Ksh {0}", PizzaCost);
        
    }

    static void whileloop()
    {
        string userChoice = "";
        do
        {
            Console.WriteLine("Enter a number");
            int usernum = int.Parse(Console.ReadLine());

            int typenum = -10;
            while (typenum <= usernum)
            {
                Console.Write(typenum + " ");
                typenum += 1;


            }

            do
            {
                Console.WriteLine("Do you want to continue: Yes or No");
                userChoice = Console.ReadLine();


                if (userChoice.ToUpper() != "YES" && userChoice.ToUpper() != "NO")
                {
                    Console.WriteLine("Invalid Choice,try again...");
                }
            } while (userChoice.ToUpper() != "YES" && userChoice.ToUpper() != "NO");

        } while (userChoice.ToUpper()== "YES");






    }

    public void forloop()
    {
        int[] myarray = new int[10];
        myarray[0] = 200;
        myarray[1] = 100;
        myarray[2] = 300;
        myarray[3] = 500;
        myarray[4] = 600;
        myarray[5] = 700;
        myarray[6] = 900;
        myarray[7] = 50;

        foreach (int k in myarray)
        {
            Console.WriteLine(k);
            if (k == 500)
                break;
        }
        for(int i = 0; i<=30; i++)
        {
            if (i % 2 == 1)
                continue;
            Console.Write(i + " ");

        }

        //for(int x = 0; x<myarray.Length; x++)
        //{
        //    Console.WriteLine(myarray[x]);
        //}

    }
    public int Add(int FN, int LN)
    {
        return FN + LN;
    }


}
