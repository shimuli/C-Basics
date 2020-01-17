using System;
using MyFunctionsA.PrintMethods;

public class Students
{
    public string firstname= "Cedric";
    public string lastname= "Gyan";
    public string email= "ced@gmail.com";


    //public Students(string Fname, string Lname, string Email)
    //{
    //    this.firstname = Fname;
    //    this.lastname = Lname;
    //    this.email = Email;


    //}

    public virtual void PrintNames()
    {
        Console.WriteLine("Full name is {0} and email is {1}", this.firstname + " " + this.lastname, email);
    }
}
public class FirstYear : Students
{
    //public string year;

    //public void printYear()
    //{
    //    Console.WriteLine("Year of study {0}", year);
    //}

    public override void PrintNames()
    {
        Console.WriteLine("Full name is {0} and email is {1}", this.firstname + " " + this.lastname, email + " -First Year");
    }


}

public class SecondYear : Students
{
    public string year;
    //public void printYear()
    //{
    //    Console.WriteLine("Year of study {0}", year);
    //}
    public override void PrintNames()
    {
        Console.WriteLine("Full name is {0} and email is {1}", this.firstname + " " + this.lastname, email + " -Second Year");
    }



}

public class ThirdYear : Students
{
    //public string year;
    public override void PrintNames()
    {
        Console.WriteLine("Full name is {0} and email is {1}", this.firstname + " " + this.lastname, email + " -Third Year");
    }

}

public class FourthYear : Students
{
    //public string year;
    public override void PrintNames()
    {
        Console.WriteLine("Full name is {0} and email is {1}", this.firstname + " " + this.lastname, email + " -Fourth Year");
    }

}


class Circle
{
    int radius;
    static float pi = 3.142F;

    public Circle(int Radius)
    {
        this.radius = Radius;
    }
    public float Area()
    {
       return Circle.pi * this.radius * this.radius;
    }
}

class Employees
{
    private string name;
    private int id;
    private int salary = 40000;

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be Empty");
            }
            this.name = value;
        }

        get
        {
            if (string.IsNullOrEmpty(this.name))
            {
                Console.WriteLine("Name is Empty");
            }
            return this.name;
        }
    }


    public int Id
    {
        set { 
        if(value <= 0)
        {
            throw new Exception("Id cannot be less than 0");
        }
        this.id = value;
        }

        get
        {
            return this.id;
        }

    }


    public int Salo
    {
        get
        {
            return this.salary;
        }
        
    }

    public string City
    {
        get;
        set;
    }
}

//structure

    public struct Customer
{
    private int id;
    private string name;

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }

    public Customer(int Id, string Name)
    {
        this.id = Id;
        this.name = Name;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Id is {0} and Name is {1}", this.id, this.name);
    }
}

interface IPerson
{
    void Print();
}

interface Iperson2
{
    void print1();
}

class Person : IPerson, Iperson2
{
    public void Print()
    {
        Console.WriteLine("Interfaces");
    }

    public void print1()
    {
        Console.WriteLine("Interfaces2");
    }
}

interface IPerson3 : Iperson2
{
    void Print3();
}

class Person3 : IPerson3
{
    public void print1()
    {
        throw new NotImplementedException();
    }

    public void Print3()
    {
        throw new NotImplementedException();
    }
}

class MyPerson : IPerson
{
    public void Print()
    {
        Console.WriteLine("Interface one implementation");
    }
}

interface I1
{
    void InterfaceMethod();
}

interface I2
{
    void InterfaceMethod();
}

class Class1: I1, I2
{
    void I1.InterfaceMethod()
    {
        Console.WriteLine("Inteface 1");
    }

    void I2.InterfaceMethod()
    {
        Console.WriteLine("Inteface 2");
    }


}

abstract class ABClass
{
    public abstract void MyMethod();
}

class TestClass : ABClass
{
    public override void MyMethod()
    {
        Console.WriteLine("My abstract");
    }
}





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
        //int Sum= p.Add(20, 30);
        //Console.WriteLine(Sum);

        //int i = 2;
        //Mynumber(ref i);
        //Console.WriteLine(i);

        //int v = 2;
        //MynumberValue(v);
        //Console.WriteLine(v);

        //int Total = 0;
        //int prod = 0;
        ////Cal(10, 20, out Total, out prod);
        ////Console.WriteLine("Sum={0} and Prod = {1}", Total,prod);

        ////printer.Print();

        ////Students student = new Students("Cedric", "Shimuli");
        ////Students students = new Students("Cedric", "Shimuli");
        ////student.PrintNames();

        //Circle circle = new Circle(7);
        //float Area = circle.Area();
        //Console.WriteLine(Area);

        //Circle circle1 = new Circle(89);
        //float Area1 = circle1.Area();
        //Console.WriteLine(Area1);

        //FirstYear firstyear = new FirstYear();
        //firstyear.email = "cedric@gmail.com";
        //firstyear.firstname = "Cedric";
        //firstyear.lastname = "Shimuli";
        //firstyear.year = "first";
        //firstyear.PrintNames();
        //firstyear.printYear();

        //SecondYear secondyear = new SecondYear();
        //secondyear.email = "gyan@gmail.com";
        //secondyear.firstname = "Gyan";
        //secondyear.lastname = "Shimuli";
        //secondyear.year = "second";
        //secondyear.PrintNames();
        //secondyear.printYear();

        //Students[] studnets = new Students[5];

        //studnets[0] = new Students();
        //studnets[1] = new FirstYear();
        //studnets[2] = new SecondYear();
        //studnets[3] = new ThirdYear();
        //studnets[4] = new FourthYear();


        //foreach(Students s in studnets)
        //{
        //    s.PrintNames();
        //}

        //Employees emp = new Employees();
        //emp.Id = 20;
        //emp.Name= "Cedric";
        //emp.City = "Kisii";



        //Console.WriteLine("Id is {0}", emp.Id);
        //Console.WriteLine("Name is {0}", emp.Name);
        //Console.WriteLine("Salary is {0}", emp.Salo);
        //Console.WriteLine("From  {0}", emp.City);

        //Customer customer = new Customer(10, "cedric");
        //customer.PrintDetails();

        //Customer customer1 = new Customer
        //{
        //    Id = 12,
        //    Name = "Steve"

        //};
        //customer1.PrintDetails();

        MyPerson person = new MyPerson ();
        person.Print();

        I1 i1 = new Class1();
        I2 i2 = new Class1();

        i1.InterfaceMethod();
        i2.InterfaceMethod();

        TestClass testclass = new TestClass();
        testclass.MyMethod();


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

    static void Mynumber(ref int j)
    {
        j = 254;
    }

    static void MynumberValue(int j)
    {
        j = 254;
    }

    static void Cal(int x, int y, out int Sum,out int Pro)
    {
        Sum = x + y;
        Pro = x * y;
    }

    //Method Overloading
    static void sum(int FN, int SN)
    {
        Console.WriteLine("Sum is {0}", FN + SN);
    }

    static void sum(int FN, int SN, int TN)  //Method Overloading with number of parameters
    {
        Console.WriteLine("Sum is {0}", FN + SN+ TN);
    }

    static void sum(float FN, float SN)  //Method Overloading with different type of parameters
    {
        
        Console.WriteLine("Sum is {0}", FN + SN);
    }

    static void sum(int FN, int SN, out int TN)  //Method Overloading with type of parameter
    {
        Console.WriteLine("Sum is {0}", FN + SN );
        TN = FN + SN;
    }



}

namespace MyFunctionsA
{
    namespace PrintMethods
    {
        class printer
        {
            public static void Print()
            {
                Console.WriteLine("This all about name space");
            }
        }
    }
}

