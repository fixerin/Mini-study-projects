using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projekt2
{
    class Program
    {

        static string converting(string number, int fromBase, int toBase)
        {

            string result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            return result;
        }

        static int[] wypelnienie(int n)
        {

            int[] tabLiczb = new int[n];

            Console.WriteLine("\nWypisz te liczby: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Wpisz liczbe nr {0}: ", i + 1);
                tabLiczb[i] = Convert.ToInt32(Console.ReadLine());
            }

            return tabLiczb;
        }

        static void pierwiastkowanie()
        {
            double liczba, stopien, wynik;
            Console.Write("\nPodaj liczbe do pierwiastkowania: ");
            liczba = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nPodaj stopien pierwiastka: ");
            stopien = Convert.ToDouble(Console.ReadLine());

            wynik = Math.Pow(liczba, 1.0 / stopien);

            Console.WriteLine("\nPierwiastek {0} stopnia z {1} wynosi {2}\n",stopien, liczba, wynik);

            Console.ReadKey();

        }

        static void potegowanie()
        {
            double liczba, stopien, wynik;
            Console.Write("\nPodaj liczbe do potegowania: ");
            liczba = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nPodaj stopien potegi: ");
            stopien = Convert.ToDouble(Console.ReadLine());

            wynik = Math.Pow(liczba, stopien);

            Console.WriteLine("\n{0} podniesione do {1} postegi wynosi {2}", liczba, stopien, wynik);
            Console.WriteLine();

            Console.ReadKey();
        }

        static void systemLiczby()
        {
            int baseInt, toInt;
            string wynikStr, liczbaStr;

            Console.Write("\nZ jakiego systemu chcesz przekonwertowac liczbe? (podaj liczbe systemu) ..");
            baseInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNa jaki system przekonwertować? (podaj liczbe systemu) ..");
            toInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPodaj liczbe do konwersji: ");
            //liczba = Convert.ToInt32(Console.ReadLine());
            liczbaStr = Console.ReadLine();

            wynikStr = converting(liczbaStr, baseInt, toInt);
            Console.WriteLine("\n{0} w systemie {1} przekonwertowana na system {2} to {3}", liczbaStr, baseInt, toInt, wynikStr);

            Console.ReadKey();

        }

        



        static void minMax()
        {
            int n;
            
            Console.Write("\nZ posrod ilu liczb chcesz wyszukac min/max? ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] tabLiczb = wypelnienie(n);

            int min = tabLiczb[0];
            int max = tabLiczb[0];

            for (int i = 1; i < n; i++)
            {
                if (min > tabLiczb[i]) min = tabLiczb[i];
                if (max < tabLiczb[i]) max = tabLiczb[i];
            }

            Console.WriteLine("\nNajmniejsza liczba to: {0}", min);
            Console.WriteLine("Najwieksza liczba to: {0}", max);

            Console.WriteLine();
            Console.ReadKey();
        }

        static void szeregowanie()
        {
            int n;

            Console.Write("\nWpisz ilosc licz do szeregowania? ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] tabLiczb = wypelnienie(n);

            Array.Sort(tabLiczb);
            // write array
            Console.WriteLine("\nPosortowane liczby od najmniejszej do najwiekszej:");
            foreach (int i in tabLiczb) Console.Write(i + " ");  

            Array.Reverse(tabLiczb);

            Console.WriteLine("\nPosortowane liczby od najwiekszej do najmniejszej:");
            foreach (int i in tabLiczb) Console.Write(i + " ");

            Console.WriteLine("\n\n");

            Console.ReadKey();

        }

        

        static void zaokraglanie()
        {
            int n;
            double liczba, wynik;
            string liczbaStr;

            Console.Write("\nDo ilu miejsc po przecinku chcesz zaokraglic? ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nJaka liczbe chcesz zaokraglic? ");
            liczbaStr = Console.ReadLine();

            liczba = double.Parse(liczbaStr);

            wynik = Math.Round(liczba, n);

            Console.WriteLine("{0} zaokraglona do {1} miejsc po przecinku wynosi {2}", liczba, n, wynik);
            Console.WriteLine();

            Console.ReadKey();

        }

        static void Main(string[] args)
        {

            int wybor;

            do
            {
                Console.WriteLine("Menu: \n");
                Console.WriteLine("[1] Pierwiastkowanie");
                Console.WriteLine("[2] Potegowanie");
                Console.WriteLine("[3] Zmiana na zapis liczby w różnych systemach");
                Console.WriteLine("[4] Znajdowanie min/max z podanych liczb");
                Console.WriteLine("[5] Szeregowanie liczb wg wielkosci");
                Console.WriteLine("[6] Zaokraglanie do zadanej ilosci miejsc po przecinku");
                Console.WriteLine("[0] Zamknij aplikacje\n");

                Console.Write("Wybierz numer opcji: ");
                wybor = Convert.ToInt32(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        pierwiastkowanie();
                        break;

                    case 2:
                        potegowanie();
                        break;

                    case 3:
                        systemLiczby();
                        break;

                    case 4:
                        minMax();
                        break;

                    case 5:
                        szeregowanie();
                        break;

                    case 6:
                        zaokraglanie();
                        break;

                    case 0:
                        Console.WriteLine("\nDziekuje za skorzystanie z aplikacji!");
                        break;

                    default:
                        Console.WriteLine("Wprowadzono bledny numer opcji!");
                        break;
                }


            } while (wybor != 0);

            Console.ReadKey();

        }
    }
}
