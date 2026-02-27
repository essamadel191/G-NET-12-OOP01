using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace G_NET_12_OOP01.TicketBookingSystem
{
    internal class Ticket
    {
        public string MovieName { get; set; }
        public TicketTypes Type { get; set; }

        public SeatLocation Seat { get; set; }

        private double Price;

        // Old Way 
        //public Ticket(string? movieName,string? type, char? seatRow , int? seatNumber , string? Price)
        //{
        //    MovieName = movieName ?? "default";
        //    Type = type != null ? Enum.Parse<TicketTypes>(type) : TicketTypes.Standard;
        //    Seat = seatRow != null ? new SeatLocation(seatRow.Value, seatNumber) : new SeatLocation('A', 1);
        //    price = Price != null ? double.Parse(Price) : 50;
        //}

        public Ticket(string movieName, TicketTypes type, SeatLocation seat, double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }

        // Constructor Chainning (this())
        public Ticket(string movieName)
            : this(movieName, TicketTypes.Standard, new SeatLocation('A', 1), 50.0)
        {
        }

        public double CalcTotal(double taxPercent)
        {
            double total = Price + (Price * taxPercent / 100);
            return total;
        }

        public double ApplyDiscount(double discountAmount)
        {
            
            if (discountAmount > 0 && discountAmount <= Price) 
            {
                Price = Price - (Price * discountAmount / 100);
                discountAmount = 0;
            }
            return Price;
        }

        public string PrintTicket(double discountAmount)
        {
            string ticketInfo = $"""
                ===== Ticket Info =====
                Movie : {MovieName}
                Type : {Type}
                Seat : {Seat.ToString()}
                Pricing : {Price}
                Total (14% tax) : {CalcTotal(14)}

                ===== After Discount =====
                Discount Before : {Price}
                Discount After : {ApplyDiscount(discountAmount)}
                Movie : {MovieName}
                Type : {Type}
                """;
            return ticketInfo;
        }


    }
}
