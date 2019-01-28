using System;
using System.Collections.Generic;

namespace Projekt_na_studia
{
    class Program
    {
        static void wyswietlTablice(List<string> owoce)
        {
            Console.WriteLine("Twoje owoce:");
            Console.WriteLine("------------");
            for (int i = 0; i < owoce.Count; i++)
            {
                Console.WriteLine(owoce[i]);

            }
            Console.WriteLine(); // jako przejscie do nowej linii
        }

        static void dodajOwoc(List<string> owoce)
        {
            string nowyOwoc;
            Console.Write("Podaj nazwe owocu do dodania: ");
            nowyOwoc = Console.ReadLine();
            owoce.Add(nowyOwoc);

            Console.WriteLine("\nWlasnie dodales {0} do tablicy owocow.\n", nowyOwoc);
        }

        static void edytujOwoc(List<string> owoce)
        {
            string szukanyOwoc;
            string nowyOwoc;
            Console.Write("Podaj nazwe owocu do edycji: ");
            szukanyOwoc = Console.ReadLine();
            if (owoce.Contains(szukanyOwoc))
            {
                Console.Write("\n Podaj nazwe nowego owocu: ");
                nowyOwoc = Console.ReadLine();

                owoce[owoce.FindIndex(ind => ind.Equals(szukanyOwoc))] = nowyOwoc;

                Console.WriteLine("Zmieniono {0} na {1}.", szukanyOwoc, nowyOwoc);

            }
            else
            {
                Console.WriteLine("Nie znaleziono takiego owocu w tablicy.");
            }
            
        }

        static void usunOwoc(List<string> owoce)
        {
            string doUsuniecia;
            Console.Write("Jaki owoc chcesz usunac z tablicy? ");
            doUsuniecia = Console.ReadLine();

            if (owoce.Contains(doUsuniecia))
            {
                owoce.Remove(doUsuniecia);
                Console.WriteLine("Usunieto {0} z tablicy.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono takiego owocu w tablicy.");
            }

        }

        static void Main(string[] args)
        {
            var owoce = new List<string>();
            int wybor;
            string wyborStr;

            owoce.Add("Banan");

            Console.WriteLine(owoce[0] + "\n");

                do {
                    Console.WriteLine("MENU:");
                    Console.WriteLine("[1] Wyswietl tablice owocow.");
                    Console.WriteLine("[2] Dodaj owoc do tablicy.");
                    Console.WriteLine("[3] Edytuj dany owoc.");
                    Console.WriteLine("[4] Usun owoc z tablicy.");
                    Console.WriteLine("[0] Zamknij aplikacje.\n");

                
                    Console.Write("Wybierz opcje: ");
                    wyborStr = Console.ReadLine();
                    try
                    {
                        wybor = Convert.ToInt32(wyborStr);
                    }
                    catch (FormatException) { Console.WriteLine("Bledne dane wejsciowe!"); Console.ReadKey(); return;}


                    wybor = Convert.ToInt32(wyborStr);

                    Console.Write("\n");



                    switch (wybor)
                    {
                        case 1:
                            wyswietlTablice(owoce);
                            break;

                        case 2:
                            dodajOwoc(owoce);
                            break;

                        case 3:
                            edytujOwoc(owoce);
                            break;

                        case 4:
                            usunOwoc(owoce);
                            break;

                        case 0:
                            Console.WriteLine("Dziekuje za skorzystanie z aplikacji!");
                            break;

                        default:
                            Console.WriteLine("Nie ma takiej opcji.\n");
                            break;
                    }
                

                } while (wybor != 0);


            Console.ReadKey();
        }
    }
}
