using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part one
            Console.WriteLine("Enter The Project Budget");
            double proBud = double.Parse(Console.ReadLine());
            if (proBud <= 50000) { Console.WriteLine("According to that budget This Project is Small"); }
            else if (proBud > 50000 && proBud <= 100000) { Console.WriteLine("According to that budget This Project is Medium"); }
            else if (proBud > 100000) { Console.WriteLine("According to that budget This Project is Large"); }
            else { Console.WriteLine("We Connot Categorize this project"); }
            #endregion

            Console.WriteLine("\n\n\n");

            #region Part two
            Console.WriteLine("Selecting The Project Type by Chooseing The pre number");
            Console.WriteLine("1- Residential                  2- Commercial\n" +
                              "3- Industrial                   4- Infrastructure");
            int userAns = int.Parse(Console.ReadLine());
            switch (userAns)
            {
                case 1:
                    Console.WriteLine("The Selected Project Type is Residential");
                    break;
                case 2:
                    Console.WriteLine("The Selected Project Type is Commercial");
                    break;
                case 3:
                    Console.WriteLine("The Selected Project Type is Industrial");
                    break;
                case 4:
                    Console.WriteLine("The Selected Project Type is Infrastructure");
                    break;
                default:
                    Console.WriteLine("You Did Not Choosed a valid number");
                    break;
            }
            #endregion

            Console.WriteLine("\n\n\n");

            #region Part Three
            List<string> projectNames = new List<string>();
            Console.WriteLine("Enter The Projects Name then Enter done to finish");
            string userAns00 = Console.ReadLine();
            int CursTo = Console.CursorTop;
            while (userAns00 != "done")
            {
                projectNames.Add(userAns00);
                Console.CursorTop = CursTo - 1;
                Console.WriteLine("                                            ");
                Console.CursorTop = CursTo - 1;
                userAns00 = Console.ReadLine();
            }
            Console.WriteLine("The Projects Names is");
            foreach (string projectName in projectNames)
            {
                Console.Write(projectName);
                Console.Write(" - ");
            }
            Console.WriteLine("                           ");
            #endregion
        }
    }
}
