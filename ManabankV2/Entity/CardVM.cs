
namespace Manabank.Models
{
    public class CardVM
    {   
        public int ID { get; set; }
        public int AccountID { get; set; }
        public string Number { get; set; }
        public float Limit { get; set; }
        public float Total { get; set; }
        public AccountVM Account { get; set; }

        public CardVM()
        {
            
        }

        public CardVM(int accID, float limit, float total, string number)
        {
            this.Number = number;
            this.AccountID = accID;
            this.Limit = limit;
            this.Total = total;
        }
    }
}
