using System;

namespace inlamning2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pWord;

            do
            {
                Console.Write("Enter Password:");
                pWord = Console.ReadLine();

                if (pWord != "bästkusten")
                {
                    Console.WriteLine("Wrong password try again! ");
                }
               

            } while (pWord != "bästkusten");

            
            

            Console.WriteLine("1) Välj en anvädare ");
            Console.WriteLine("2) Ta bort en användare");
            Console.WriteLine("3) Stäng av programmet");

        }
    }
}
