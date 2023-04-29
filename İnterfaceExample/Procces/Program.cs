using InterfaceExample.Proccesses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            bool status = true;
            while (status)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("---------- Proccess Menu -----------");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("-------- Select Proccess -----------");
                Console.WriteLine("Product Proccess   (1)");
                Console.WriteLine("Category Proccess  (2)");
                Console.WriteLine("User Proccess      (3)");
                Console.WriteLine("Exit Program       (0)");
                Console.Write("Selecet Proccess: ");
                char selected = Convert.ToChar(Console.ReadLine().Substring(0, 1));

                switch (selected)
                {
                    case '1':
                        ProductProccess.Menu();

                        break;
                    default:
                        Console.WriteLine("Tanımsız İşlem. Tekrar Deneyiniz.");
                        break;
                }


            }

        }
    }
}