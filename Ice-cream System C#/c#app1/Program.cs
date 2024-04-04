using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace c_app1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
           
            printloop();
            Console.ReadLine();
          
        }

        public static void printloop()
        {
            int mango = 150;
            int banana = 100;
            int kulfa = 120;

            int Quantity = 0;
            int Total = 0;
            int AllTotal = 0;
            int Asking = 0;
            Console.WriteLine("\t\t\t\t\t" +
                "----Welcome To The Ice Creame Shop----"
                + "\n\n");
            Console.WriteLine(
                "1)Mango--" + mango + "Rs\n" +
                "2)Banana--" + banana + "Rs\n" +
                "3)Kulfa--" + kulfa + "Rs\n"
                );

            Console.WriteLine("Please Slelect any Ice Cream");
            int ice = int.Parse(Console.ReadLine());
            while (ice >= 4)
            {
                Console.Write("\a Please Select Valid Option:");
                ice = int.Parse(Console.ReadLine());
            }

            if (ice == 1)
            {
                Console.Write("Please Mention Quantity:");
                Quantity = int.Parse(Console.ReadLine());
                Total = Quantity * mango;
            }
            else if (ice == 2)
            {
                Console.Write("Please Mention Quantity:");
                Quantity = int.Parse(Console.ReadLine());
                Total = Quantity * banana;
            }
            else if (ice == 3)
            {
                Console.Write("Please Mention Quantity:");
                Quantity = int.Parse(Console.ReadLine());
                Total = Quantity * kulfa;
            }

            AllTotal += Total;

          
            Console.Write("\nDo you Want to By More?:"); 
            Console.WriteLine("\n1)Yes \t\t\t 2)No");
            Asking = int.Parse(Console.ReadLine());
            if (Asking == 1)
            {
    printloop();
              
            }
            else if(Asking == 2)
            {
              Console.WriteLine("\nThank You For Shopping Your Total Amount is:" + AllTotal + "Rs\n");
              
            }
          
            

        }

    }
}
