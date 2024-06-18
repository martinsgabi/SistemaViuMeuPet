using Microsoft.EntityFrameworkCore;
using ViuMeuPet_ProjetoFinal.Models;

namespace ProjetoFinal.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Usuario>? Usuario { get; set; }
        public DbSet<Animais>? Animais { get; set; }
        public DbSet<Observacoes>? Observacoes { get; set; }
    }
}