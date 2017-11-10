using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassesCLI
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true){

                Console.WriteLine("Digite um número: ");
                string str = Console.ReadLine();
                Console.Clear();
                if (str == "0")
                {
                    break;
                }
                int num = int.Parse(str);
                new Numero(num).print();

            }
        }
    }

}
