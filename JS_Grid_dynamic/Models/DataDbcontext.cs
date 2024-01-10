using Microsoft.EntityFrameworkCore;

namespace JS_Grid_dynamic.Models
{
    public class DataDbcontext: DbContext
    {
        public DataDbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Data> Datas { get; set; }

    }
}
