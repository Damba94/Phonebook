namespace Phonebook.Server.Models
{
    public class PersonalData
    {
        public int Id { get; set; }
        public string Oib { get; set; } = null!;
   

        public int PersonID { get; set; }   
        public Person Person { get; set; }  


    }
}
