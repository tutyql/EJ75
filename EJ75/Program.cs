using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ75
{
    class Program
    {
        static void Main(string[] args)
        {
            string Palabras;
            int numero;

            ArrayList Lista = new ArrayList();
            Console.WriteLine("Ingrese la primera palabra");
            Palabras = Console.ReadLine();
            while (Palabras != "")
            {
                Lista.Add(Palabras);
                Console.WriteLine("Ingrese la próxima palabra");
                Palabras = Console.ReadLine();
            }
            
            Console.WriteLine("Ingrese la posición de la palabra que desea ver:");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("en esa posicion se encuentra:");
            
            while (numero != 0)
            {
                if (numero <= Lista.Count && numero > 0)
                {
                    numero--;
                    Console.WriteLine((string)Lista[numero]);
                    Console.WriteLine("Ingrese la posición de la palabra que desea ver:");
                  
                    numero = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine(" posición inexistente Ingrese otra posición");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
            }


        }
    }
}
