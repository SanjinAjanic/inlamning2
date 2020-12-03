using System;
using System.Threading;
using System.Collections.Generic;

namespace inlamning2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            bool isNum = false;
            int userInPut = 0;
            bool exit = false;

            // kallar på metoden
            Inlogg();

            //Skapat medlemana och tilldelat varje fält ett värde
            //med hjälp av konstruktorn
            Members Jerry = new Members("Jeremy", "Gaming", "Älggryta", "Teal", "Jobb", "Djurö", "Köln", 19, 181, 1);
            Members David = new Members("David", "BJJ", "Tacos", "Blå", "Problemlösning", "Norrtälje", "Göteborg", 32, 183, 1);
            Members Johan = new Members("Johan", "Gaming", "Tacos", "Blå", "Trygg Framtid", "Mariefred", "Mariefred", 34, 194, 2);
            Members Oskar = new Members("Oskar", "Fotboll", "Lasagne", "Blå", "Jobb", "Stockholm", "Stockholm", 26, 185, 1);
            Members Cecilia = new Members("Cecilia", "The Sims", "Risotto", "Gul", "Kreativitet", "Norrköping", "Norrköping", 29, 163, 1);
            Members Elin = new Members("Elin", "Hästar", "Sushi", "Röd", "Personlig utveckling", "Knivsta", "Karlskoga", 31, 170, 2);
            Members Ivo = new Members("Ivo", "Fotografi", "Skampi", "Svart", "Kreativitet", "Uppsla", "Split", 42, 174, 1);


            //Lägger alla medlemar in i en lista
            List<Members> group = new List<Members>();
            group.Add(Jerry);
            group.Add(David);
            group.Add(Johan);
            group.Add(Oskar);
            group.Add(Cecilia);
            group.Add(Elin);
            group.Add(Ivo);

            

            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("1) Lista alla medlemmar.");
                    Console.WriteLine("2) Välj en anvädare att få mer info om.");
                    Console.WriteLine("3) Ta bort en användare.");
                    Console.WriteLine("4) Stäng av programmet.");


                    input = Console.ReadLine();
                    isNum = int.TryParse(input, out userInPut);
                } while (isNum == false);

                switch (userInPut)
                {
                    //Skriver ut namnen
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Detta är alla medlemmar i Bästkusten.");
                        //Går igenom hela listan group och skriver den ut varje 
                        //medlems namn följt av ett kommatecken.
                        foreach (Members member in group)
                        {
                            Console.Write(member.Name + ", ");
                        }
                        Console.ReadLine();
                        break;
                    //Skriver ut namnen igen
                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Vilken medlem vill du veta mer om?");
                            //Går igenom hela listan group och skriver ut varje medlems
                            //namn med en siffra innan.
                            for (int i = 0; i < group.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {group[i].Name}");                                
                            }
                            
                            isNum = int.TryParse(Console.ReadLine(), out userInPut);

                        } while (isNum == false);


                        //Anväder userinput för att komma åt medlem som användaren vill titta på,
                        //minskar userinput med 1 för att det är 0 indexerat
                        userInPut--;
                        Console.Clear();
                        Console.WriteLine($"Namn: {group[userInPut].Name}");
                        Console.WriteLine($"Längd: {group[userInPut].Length} cm");
                        Console.WriteLine($"Ålder: {group[userInPut].Age} år");
                        Console.WriteLine($"Hobby: {group[userInPut].Hobby}");
                        Console.WriteLine($"Favoriträtt: {group[userInPut].FavFood}");
                        Console.WriteLine($"Favoritfärg: {group[userInPut].FavColor}");
                        Console.WriteLine($"Motivation till programmering: {group[userInPut].Motivation}");
                        Console.WriteLine($"Hemort: {group[userInPut].HomTown}");
                        Console.WriteLine($"Fördelseort: {group[userInPut].BirthPlace}");
                        Console.WriteLine($"Antal syskon: {group[userInPut].Siblings}");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Vilken medlem vill du ta bort?");
                        for (int i = 0; i < group.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {group[i].Name}");
                        }
                        int.TryParse(Console.ReadLine(), out int userInput);
                        Console.WriteLine($"Du valde att ta bort {group[userInput - 1].Name}.");
                        // Raderar medlemen som användaren valt från listan.
                        group.RemoveAt(userInput - 1);
                        Thread.Sleep(2000);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Nu stängs programmet!");
                        //Här sätter jag exit till true så do-while loopen bryts 
                        //och programmet avslutas.
                        exit = true;
                        Thread.Sleep(2000);
                        break;
                    default:
                        break;
                } 
            } while (exit == false);
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
