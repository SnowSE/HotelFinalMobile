using System;
using System.Collections.Generic;

namespace HotelAPI.Data;

public partial class RentalRoom
{
    public int Id { get; set; }

    public int RentalId { get; set; }

    public int RoomCleaningId { get; set; }

    public decimal RentalRate { get; set; }

    public virtual Rental Rental { get; set; } = null!;

    public virtual RoomCleaning RoomCleaning { get; set; } = null!;

    public virtual ICollection<RoomServiceCharge> RoomServiceCharges { get; } = new List<RoomServiceCharge>();
}
