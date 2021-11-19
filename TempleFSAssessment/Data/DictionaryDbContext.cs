using Microsoft.EntityFrameworkCore;
using TempleFSAssessment.Data.Entities;

namespace TempleFSAssessment.Data
{
    public partial class DictionaryDbContext : DbContext
    {
        public virtual DbSet<WordDefinition> WordDefinitions { get; set; }
        public virtual DbSet<WordModel> Words { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=OwlDictionaryDb;Integrated Security=True;");
        }
    }
}