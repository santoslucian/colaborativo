using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraoo
{
    class Program
    {
        static void Main(string[] args)
        {   
            // cria uma variavel da classe Somar.
            Soma somar;

            //O operador "new" cria um objeto da classe; 
            somar = new Soma();

            somar.num1 = 5;
            somar.n2 = 10;
            somar.total = somar.num1 + somar.n2;

            Console.WriteLine("Primeiro Numero : " + somar.num1);
            Console.WriteLine("Segundo Numero : " + somar.n2);
            Console.ReadKey();
        }
    }
}
