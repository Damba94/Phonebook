using Microsoft.EntityFrameworkCore;
using Phonebook.Server.Models;

namespace Phonebook.Server.Data
{
    public class PhonebookContext:DbContext

    {
        public PhonebookContext(DbContextOptions<PhonebookContext> options) : base(options)
        {
        }
        public DbSet<Address> addresses { get; set; } = null!;
        public DbSet<Person> persons { get; set; } = null!;
        public DbSet<City> cities { get; set; } = null!;
        public DbSet<PersonalData> PersonalDatas { get; set; } = null!;

 
    }
}
