namespace Phonebook.Server.Models
{
    public class PersonalData
    {
        public int PersonalDataId { get; set; }
        public string oib { get; set; } = null!;
   

        public int PersonID { get; set; }   
        public Person Person { get; set; }  


    }
}
