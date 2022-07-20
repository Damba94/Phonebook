using Microsoft.EntityFrameworkCore;
using Phonebook.Server.Models;

namespace Phonebook.Server.Data
{
    public class PhonebookContext:DbContext
    {
        public DbSet<Address> addresses { get; set; } = null!;
        public DbSet<Person> persons { get; set; } = null!;
        public DbSet<City> cities { get; set; } = null!;
        public DbSet<PersonalData> PersonalDatas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
