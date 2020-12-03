using System;
using System.Threading;

namespace inlamning2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            bool isNum = false;
            int userInPut = 0;
            
            
            MainMenu();

            Members Jerry = new Members("Jerry", "Gaming", "favFood", "favColor", "motivation", "homTwon", "birthPlace", 19,181,1 );
         
           
            Members David = new Members("David ", "hobby ", "favFood", "favColor", "motivation", "homTwon", "birthPlace", 19, 181, 1);           
            do
            {
                Console.Clear();
                Console.WriteLine("1) Välj en anvädare ");
                Console.WriteLine("2) Ta bort en användare");
                Console.WriteLine("3) Stäng av programmet");


                input = Console.ReadLine();
                isNum = int.TryParse(input, out userInPut);
            } while (isNum == false);
            switch  (userInPut)
          
            {
                //Skriver ut namnen
                case 1:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1. " + Jerry.Name);
                        Console.WriteLine("2. " + David.Name);
                        input = Console.ReadLine();
                        isNum = int.TryParse(input, out userInPut);

                    } while (isNum == false);
                   
                    //Skriver ut all indormation om användaren
                    switch (userInPut)
                    {
                        
                        case 1:
                            Console.WriteLine($"{Jerry.Name} {Jerry.Hobby}");
                            break;
                        default:
                            break;
                    }

                    break;
                default:
                    break;
 



            }
            

        }
        static void MainMenu()
        {
            string pWord;

            do
            {
                Console.Write("Enter Password:");
                pWord = Console.ReadLine();

                if (pWord != "bästkusten")
                {
                    Console.WriteLine("Wrong password try again! ");
                    Thread.Sleep(5000);
                    Console.Clear();
                }


            } while (pWord != "bästkusten");
        }
    }
}
