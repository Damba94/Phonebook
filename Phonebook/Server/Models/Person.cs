namespace Phonebook.Server.Models
{
    public class Person
    {
        public int Id { get;set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;


        public PersonalData PersonalData { get; set; }=null!;   

        public List<Address> Addresses { get; set; }=null!;

    }
}
