namespace Phonebook.Server.Models
{
    public class Person
    {
        public int Personid { get;set; }
        public string name { get; set; } = null!;
        public string lastname { get; set; } = null!;


        public PersonalData PersonalData { get; set; }=null!;   

        public ICollection<Address> Addresses { get; set; }=null!;

    }
}
