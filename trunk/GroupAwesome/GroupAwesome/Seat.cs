//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GroupAwesome
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seat
    {
        public Seat()
        {
            this.RoomSeats = new HashSet<RoomSeat>();
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int Id { get; set; }
        public int No { get; set; }
        public byte Usable { get; set; }
    
        public virtual ICollection<RoomSeat> RoomSeats { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
