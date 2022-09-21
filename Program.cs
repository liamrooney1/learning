using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Getting_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter Your Name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter Your age: ");
            //string age = Console.ReadLine();
            //Console.WriteLine("hi " + name +  " you are " + age);



            Console.WriteLine("Lets Get Started!!!");
            int milliseconds = 1500;
            Thread.Sleep(milliseconds);
            Console.WriteLine("Just a few questions....");
            Thread.Sleep(milliseconds);
            Console.WriteLine("whats your name?");
            string name = Console.ReadLine();

            Thread.Sleep(milliseconds);
            Console.WriteLine("hmmm.... thats a funny name  " + name + ", How old are you?");
            string age = Console.ReadLine();

            Thread.Sleep(milliseconds);
            Console.WriteLine("damn! " + age + "? Youre old as hell, " + name);

            Thread.Sleep(milliseconds);
            Console.WriteLine("whats your email? we promise we wont sell your info to marketers....;) ");
            string email = Console.ReadLine();

            Thread.Sleep(milliseconds);
            Console.WriteLine("Thanks,  lets confirm your info ");


            Thread.Sleep(milliseconds);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("age: " + age);
            Console.WriteLine("email: " + email);

            Console.WriteLine("Correct? please type y/n");
            string confirmation = Console.ReadLine();

            if (confirmation == "y")
                
            {
                string message = "Awesome! Thanks for the info";
                Console.WriteLine(message);
            }


            else if (confirmation == "n")
            
            {
                string message = "Sorry im usually a good listener... lets try again";
                  Console.WriteLine(message);  
                    
                    }

            








            Console.ReadLine();











        }
    }
}
