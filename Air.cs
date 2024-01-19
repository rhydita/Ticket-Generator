using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate___Print
{
    public class Air : Ticket
    {
        public Air(int price, string source, string destination)
        {
            this.price = price;
            this.source = source;
            this.destination = destination;

        }
        public override void generate_ticket(Traveller traveller)
        {
            Console.WriteLine("Generating Ticket for Air of " + traveller.name);
        }
    }
}
