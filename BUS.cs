﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate___Print
{
    public class BUS : Ticket
    {
        public BUS(int price, string source, string destination)
        {
            this.price = price;
            this.source = source;
            this.destination = destination;
            
        }
        public override void generate_ticket(Traveller traveller)
        {
            Console.WriteLine("Generating Ticket for BUS of "+traveller.name);
        }

 
    }
}
