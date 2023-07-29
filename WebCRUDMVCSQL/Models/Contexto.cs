using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace WebCRUDMVCSQL.Models
{
    public class Contexto : DbContext
    {
        public Contexto( DbContextOptions<Contexto> options):base(options)
        {
        
       
        }
        public DbSet<Produto> Produtos { get; set; }
    }
}
