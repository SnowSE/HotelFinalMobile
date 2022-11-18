using Microsoft.EntityFrameworkCore;

namespace HotelAPI.Conext
{
    public class HotelContext: DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {

        }
    }
}
