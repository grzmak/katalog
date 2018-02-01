using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // nowa biblioteka


public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zawartosc biezacego katalogu : ");
            DirectoryInfo di = new DirectoryInfo("."); //konstruktor to sciezka dostepu do pliku

            DirectoryInfo[] katalogi = di.GetDirectories();
            FileInfo[] pliki = di.GetFiles();

            Console.WriteLine("--- Podkatalogi : ---");
            foreach(DirectoryInfo katalog in katalogi)
            {
                Console.WriteLine(katalog.Name);
            }
            Console.WriteLine("---PLIKI---");
            foreach (FileInfo plik in pliki)
            {
                Console.WriteLine(plik.Name);
            }
        Console.ReadKey();
        }
    }

