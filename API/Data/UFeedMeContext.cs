using Microsoft.EntityFrameworkCore;
using UFeedMeApi.Models;

namespace UFeedMeApi.Data
{
    public class UFeedMeContext : DbContext
    {
        public UFeedMeContext(DbContextOptions<UFeedMeContext> options) : base(options) { }

        public DbSet<Avaliacao> Avaliacoes { get; set; }
    }
}
