using Microsoft.EntityFrameworkCore;

namespace Bigon.WebUI.Models.Persistences
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions options)
            : base(options)
        {
            
        }
    }
}
