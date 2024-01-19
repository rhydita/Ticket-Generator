using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate___Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Traveller Lamia = new Traveller("Lamia", "female", 22);
            BUS Ena = new BUS(500, "Online", "Mymensingh");
            Iprint color_Printer = new Color_Printer();
            Booking_Agency booking_Agency = new Booking_Agency();
            booking_Agency.Ticket_Generator(Ena, Lamia);
            booking_Agency.Ticket_printer(color_Printer, Ena, Lamia);

            Console.WriteLine("\n\n");

            Train Ekota= new Train(1000, "online", "Dhaka");
            Traveller Rhydita = new Traveller("Rhydita", "female", 21);
            Iprint grayscale_Printer = new Grayscale_Printer();
            booking_Agency.Ticket_Generator(Ekota, Rhydita);
            booking_Agency.Ticket_printer(grayscale_Printer, Ekota,Rhydita);

            Console.WriteLine("\n\n");

            BUS Miami = new BUS(1000, "online", "Cox Bazar");
            Traveller Rifah = new Traveller("Rifah", "female", 21);
            Iprint grayscales_Printer = new Grayscale_Printer();
            booking_Agency.Ticket_Generator(Miami, Rifah);
            booking_Agency.Ticket_printer(grayscale_Printer, Miami, Rifah);

            Console.ReadKey();
        }
    }
}
