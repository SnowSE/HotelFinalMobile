using System;
using System.Collections.Generic;

namespace HotelAPI.Data;

public partial class RoomServiceItem
{
    public int Id { get; set; }

    public string ItemName { get; set; } = null!;

    public decimal CurrentCost { get; set; }

    public virtual ICollection<RoomServiceCharngeItem> RoomServiceCharngeItems { get; } = new List<RoomServiceCharngeItem>();
}
