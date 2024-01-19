using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate___Print
{
    public abstract class Ticket
    {
        public int price;
        public string source;
        public string destination;
        public DateTime departure_time;
        public DateTime arrival_time;
        


        public abstract void generate_ticket(Traveller traveller);

             
    }
}
