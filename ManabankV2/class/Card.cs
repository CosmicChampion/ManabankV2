using Manabank.Models;

namespace Manabank
{
    public class Card
    {
        public string Number { get; set; }

        private float _limit; // Limit of Credit Card
        public float Limit 
        { 
            get 
            {
                return _limit;
            } 
            set
            {
                if(value < 0)
                {
                    _limit = 0;
                }
                else _limit = value;
            }
        }
        
        private float _total; //total used money
        public float Total
        {
            get
            {
                return _total;
            }
            set
            {
                if (value < 0)
                {
                    _total = 0;
                }
                else _total = value;
            }
        }

        public Card()
        {
            
        }
        public Card(CardVM newCard)
        {
            Number = newCard.Number;
            Limit = newCard.Limit;
            Total = newCard.Total;
        }
        public Card(float limit, float total)
        {
            
            Limit = limit;
            Total = total;
        }

        
    }
}
