using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Repository.Entities;
using Projeto.Repository.Mappings;
using System.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Projeto.Repository.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["LivroDB"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new LivroMap());
            modelBuilder.Configurations.Add(new AssuntoMap());
            modelBuilder.Configurations.Add(new AutorMap());
        }

        public DbSet<Livro> Livro { get; set; }
        public DbSet<Assunto> Assunto { get; set; }
        public DbSet<Autor> Autor { get; set; }
    }
}
