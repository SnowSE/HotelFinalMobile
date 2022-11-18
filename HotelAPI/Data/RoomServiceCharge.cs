using System;
using System.Collections.Generic;

namespace HotelAPI.Data;

public partial class RoomServiceCharge
{
    public int Id { get; set; }

    public int RentalRoomId { get; set; }

    public string? Decription { get; set; }

    public virtual RentalRoom RentalRoom { get; set; } = null!;

    public virtual ICollection<RoomServiceCharngeItem> RoomServiceCharngeItems { get; } = new List<RoomServiceCharngeItem>();
}
