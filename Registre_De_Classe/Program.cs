using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Registre_De_Classe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            HomePage();
        }

        
        public static void HomePage()
        {
            Console.Clear();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Programme for save and read my classmates in 5Th                                   By James");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("READ or SAVE :");
            Console.WriteLine("\n");
            string choix1 = Console.ReadLine();
            
            if (choix1 == "READ" || choix1 == "read")
            {
                Read(path);
            }
            else if (choix1 == "SAVE" || choix1 == "save")
            {
                SavePartiOne(path);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!! Error !!!");
                Console.WriteLine("!!! tape enter !!!");
                Console.ReadLine();
                HomePage();
            }

        }

        
        public static void Read(string path)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("____________________________");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The list by the all mates :");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("____________________________");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n");
            string[] ReadTextFromFile = File.ReadAllLines(path + @"\fsocity.txt");
            //Console.WriteLine(File.ReadAllText(path + @"\fsocity.txt"));
            foreach (string textLine in ReadTextFromFile)
            {
                Console.WriteLine("\t" + textLine);
            }
            Console.WriteLine("\n");

            Console.WriteLine("You want to go home ?");
            Console.WriteLine("yes or no");
            string choix2 = Console.ReadLine();
            if (choix2 == "yes" || choix2 == "YES")
            {
                HomePage();
            }
            else if (choix2 == "no" || choix2 == "NO")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!! Error !!!");
                Console.WriteLine("!!! tape enter !!!");
                Console.ReadLine();
                Read(path);
            }
          
        }

        
        public static void SavePartiOne(string path)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Indicate the name, surname and date of birth ");
            Console.WriteLine("Example : Name Surname 09/11/2001 : ---> birth");
            Console.ForegroundColor = ConsoleColor.White;
            String New = Console.ReadLine();
            //code for enrigistement the nex info
            

            String fichier = path + @"\fsocity.txt";
            string OldInfo = File.ReadAllText(path + @"\fsocity.txt");
            File.WriteAllText(fichier, OldInfo + Environment.NewLine + New);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The information were been saved");
            Console.WriteLine("\n"); 
            SavePartiTwo(path);
        }

        
        public static void SavePartiTwo(string path)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You want to go home or display the list?");
            Console.WriteLine("home or list");
            string choix2 = Console.ReadLine();
            if (choix2 == "home" || choix2 == "HOME")
            {
                HomePage();
            }
            else if (choix2 == "list" || choix2 == "LIST")
            {
                Read(path);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!! Error !!!");
                Console.WriteLine("!!! tape enter !!!");
                Console.ReadLine();
                Console.Clear();
                SavePartiTwo(path);
            }
        }
    }
}
