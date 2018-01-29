using System;

namespace HelloWorldAgain
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Chapter 5
            //string userName = "";
            //int userAge = 0;
            //int currentYear = 0;

            //Console.Write("Please enter yur name: ");
            //userName = Console.ReadLine();

            //Console.Write("Please enter your age: ");
            //userAge = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enter the current year: ");
            //currentYear = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Hello World! My name is {0} and I am {1} years old. I ws born in {2}.", userName, userAge, currentYear - userAge);

            // Cahpter 6

            int userAge;

            Console.Write("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge < 0 || userAge > 100)
            {
                Console.WriteLine("Invalid Age");
                Console.WriteLine(" Age must be between 0 and 100");
            }
            else if (userAge < 18)
                Console.WriteLine("Sorry you are udnerage");
            else if (userAge < 21)
                Console.WriteLine("you need parental consent");
            else 
            {
                Console.WriteLine("Congratulations!");
                Console.WriteLine("You may sign up for the event!");
            }




        }
    }
}
