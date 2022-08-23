using System;

namespace OurDotnetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
            /*Explorer Mode*/
            //Variables
            int numberofCupsOfCoffee = 2;
            string name = "Jimmy Comoletti";
            string today = "today 22 August";
            /*Console.WriteLine(numberofCupsOfCoffee + name + today);



            Console.WriteLine(numberofCupsOfCoffee);
            Console.WriteLine(name);
            Console.WriteLine(today);

            Console.Write(numberofCupsOfCoffee);
            Console.Write(name);
            Console.Write(today);*/

            Console.WriteLine("\n" + numberofCupsOfCoffee + " " + name + " " + today);


            //Getting Input from user


            Console.WriteLine("Hey what's your name");
            string userName = Console.ReadLine();
            Console.WriteLine("Hey, " + userName + ".");
        }

    }
}



