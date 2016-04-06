using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_ej
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var cliente1 = new  Cliente(){Id=1};
            var cliente2 =new Cliente(){Id=2};
           
                if(cliente1.CompareTo(cliente2)<0){
                    Console.WriteLine("El Cliente 2 es mayor que Cliente 1");

                }
                else if (cliente1.CompareTo(cliente2) > 0) {
                    Console.WriteLine("El Cliente 1 es mayor que Cliente 2");
                }else{
                Console.WriteLine("El Cliente 1 es igual que Cliente 2");
                }*/
            var clientes = new List<Cliente>(){
                new Cliente(){Id=1},
                new Cliente(){Id=2}
            };
            int compare;
            for (int i = 0; i < clientes.Count; i++)
            {
                
                if ((i + 1) != clientes.Count)
                {
                    compare = clientes[i].CompareTo(clientes[i + 1]);
                    if (compare < 0)
                    {
                        Console.WriteLine("El Cliente 2 es mayor que Cliente 1");

                    }
                    else if (compare > 0)
                    {
                        Console.WriteLine("El Cliente 1 es mayor que Cliente 2");
                    }
                    else
                    {
                        Console.WriteLine("El Cliente 1 es igual que Cliente 2");
                    }
                }
            }

                Console.ReadLine();
        }
    }
}
