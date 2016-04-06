using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IComparable_ej
{
    public class Cliente:IComparable{
        public int Id { get; set; }
    
        public int CompareTo(object o)
        {
            
            Cliente otroCliente = o as Cliente;
            if (otroCliente != null)
            {
                return this.Id.CompareTo(otroCliente.Id);

            }
        
                return -1;
            
            
 	        
        }
    }
}
