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
            
            // kallar på metoden
            Inlogg();
            //Skapat medlemarna
            Members Jerry = new Members("Jeremy", "Gaming", "Älggryta", "Teal", "Jobb", "Djurö", "Köln", 19,181,1 );
            Members David = new Members("David", "BJJ", "Tacos", "Blå", "Problemlösning", "Norrtälje", "Göteborg", 32, 183, 1);
            Members Johan = new Members("Johan", "Gaming", "Tacos", "Blå", "Trygg Framtid", "Mariefred", "Mariefred", 34, 194, 2);
            Members Oskar = new Members("Oskar", "Fotboll", "Lasagne", "Blå", "Jobb", "Stockholm", "Stockholm", 26, 185, 1);
            Members Cecilia = new Members("Cecilia", "The Sims", "Risotto", "Gul", "Kreativitet", "Norrköping", "Norrköping", 29, 163, 1);
            Members Elin  = new Members("Elin", "Hästar", "Sushi", "Röd", "Personlig utveckling", "Knivsta", "Karlskoga", 31, 170, 2);
            Members Ivo = new Members("Ivo", "Fotografi", "Skampi", "Svart", "Kreativitet", "Uppsla", "Split", 42, 174, 1);
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
                        Console.WriteLine("3. " + Johan.Name);
                        Console.WriteLine("4. " + Oskar.Name);
                        Console.WriteLine("5. " + Cecilia.Name);
                        Console.WriteLine("6. " + Elin.Name);
                        Console.WriteLine("7. " + Ivo.Name);
                        input = Console.ReadLine();
                        isNum = int.TryParse(input, out userInPut);

                    } while (isNum == false);
                   
                    //Skriver ut all indormation om användaren
                    switch (userInPut)
                    {
                        
                        case 1:
                            Console.Clear();
                            Console.WriteLine($"{Jerry.Name}");
                            Console.WriteLine($"{Jerry.Length}");
                            Console.WriteLine($"{Jerry.Age}");
                            Console.WriteLine($"{Jerry.Hobby}");
                            Console.WriteLine($"{Jerry.FavFood}");
                            Console.WriteLine($"{Jerry.FavColor}");
                            Console.WriteLine($"{Jerry.Motivation}");
                            Console.WriteLine($"{Jerry.HomTown}");
                            Console.WriteLine($"{Jerry.BirthPlace}");
                            Console.WriteLine($"{Jerry.Siblings}"); 
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine($"{David.Name}");
                            Console.WriteLine($"{David.Length}");
                            Console.WriteLine($"{David.Age}");
                            Console.WriteLine($"{David.Hobby}");
                            Console.WriteLine($"{David.FavFood}");
                            Console.WriteLine($"{David.FavColor}");
                            Console.WriteLine($"{David.Motivation}");
                            Console.WriteLine($"{David.HomTown}");
                            Console.WriteLine($"{David.BirthPlace}");
                            Console.WriteLine($"{David.Siblings}");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine($"{Johan.Name}");
                            Console.WriteLine($"{Johan.Length}");
                            Console.WriteLine($"{Johan.Age}");
                            Console.WriteLine($"{Johan.Hobby}");
                            Console.WriteLine($"{Johan.FavFood}");
                            Console.WriteLine($"{Johan.FavColor}");
                            Console.WriteLine($"{Johan.Motivation}");
                            Console.WriteLine($"{Johan.HomTown}");
                            Console.WriteLine($"{Johan.BirthPlace}");
                            Console.WriteLine($"{Johan.Siblings}");
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine($"{Oskar.Name}");
                            Console.WriteLine($"{Oskar.Length}");
                            Console.WriteLine($"{Oskar.Age}");
                            Console.WriteLine($"{Oskar.Hobby}");
                            Console.WriteLine($"{Oskar.FavFood}");
                            Console.WriteLine($"{Oskar.FavColor}");
                            Console.WriteLine($"{Oskar.Motivation}");
                            Console.WriteLine($"{Oskar.HomTown}");
                            Console.WriteLine($"{Oskar.BirthPlace}");
                            Console.WriteLine($"{Oskar.Siblings}");
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine($"{Cecilia.Name}");
                            Console.WriteLine($"{Cecilia.Length}");
                            Console.WriteLine($"{Cecilia.Age}");
                            Console.WriteLine($"{Cecilia.Hobby}");
                            Console.WriteLine($"{Cecilia.FavFood}");
                            Console.WriteLine($"{Cecilia.FavColor}");
                            Console.WriteLine($"{Cecilia.Motivation}");
                            Console.WriteLine($"{Cecilia.HomTown}");
                            Console.WriteLine($"{Cecilia.BirthPlace}");
                            Console.WriteLine($"{Cecilia.Siblings}");
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine($"{Elin.Name}");
                            Console.WriteLine($"{Elin.Length}");
                            Console.WriteLine($"{Elin.Age}");
                            Console.WriteLine($"{Elin.Hobby}");
                            Console.WriteLine($"{Elin.FavFood}");
                            Console.WriteLine($"{Elin.FavColor}");
                            Console.WriteLine($"{Elin.Motivation}");
                            Console.WriteLine($"{Elin.HomTown}");
                            Console.WriteLine($"{Elin.BirthPlace}");
                            Console.WriteLine($"{Elin.Siblings}");
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine($"{Ivo.Name}");
                            Console.WriteLine($"{Ivo.Length}");
                            Console.WriteLine($"{Ivo.Age}");
                            Console.WriteLine($"{Ivo.Hobby}");
                            Console.WriteLine($"{Ivo.FavFood}");
                            Console.WriteLine($"{Ivo.FavColor}");
                            Console.WriteLine($"{Ivo.Motivation}");
                            Console.WriteLine($"{Ivo.HomTown}");
                            Console.WriteLine($"{Ivo.BirthPlace}");
                            Console.WriteLine($"{Ivo.Siblings}");
                            break;

                        default:
                            break;
                    }

                    break;
                default:
                    break;
 



            }

            

        }

        //skapade en metod till inlogg
        static void Inlogg()
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
