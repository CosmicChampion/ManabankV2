using System.ComponentModel.DataAnnotations;


namespace Manabank.Models
{
    public class AccountVM
    {
        [Key]
        public int ID { get; set; }
        public int Value { get; set; }
        public string Number { get; set; }
        public int UserId { get; set; }
        public UsersVM User { get; set; }
        
        public AccountVM()
        {
            
        }
        public AccountVM(int value, int userId, string number)
        {
            Value = value;
            UserId = userId;
            Number = number;
        }
    }
}
