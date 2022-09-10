using Microsoft.EntityFrameworkCore;
using Phonebook.Server.Models;

namespace Phonebook.Server.Data
{
    public class PhonebookContext:DbContext

    {
        public PhonebookContext(DbContextOptions<PhonebookContext> options) : base(options)
        {
        }
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PersonalData> PersonalDatas { get; set; } = null!;
        public DbSet<Admin> Admins { get; set; } = null!;   

 
    }
}
