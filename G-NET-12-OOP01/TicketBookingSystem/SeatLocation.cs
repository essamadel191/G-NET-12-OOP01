using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP01.TicketBookingSystem
{
    internal struct SeatLocation
    {
        public char Row { get; set; }
        public int Number { get; set; }

        public SeatLocation(char row , int? number)
        {
            Row = row;
            Number = number ?? 1;
        }
        public override string ToString()
        {
            return $"{Row}{Number}";
        }
    }
}
