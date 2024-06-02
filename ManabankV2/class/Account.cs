using Manabank.Exceptions;
using Manabank.Models;

namespace Manabank
{
    public class Account
    {
		public int Id { get; set; }
		private float _value;
		public float Value
		{
			get { return _value; }
			set 
			{
				if (value < 0)
				{
					throw new OutOfLimitException("Invalid Value");
				}
				else
				{
                    _value = value;
                }
				 
			}
		}
		public string Number { get; set; }
		public List<Card> cards { get; set; } = new List<Card>();

        public Card this[int index]
        {
            get
            {
                if (index >= 0 && index < cards.Count)
                {
                    return cards[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < cards.Count)
                {
                    cards[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public User User { get; set; }
        public Account(AccountVM tempAcc)
        {
			Id = tempAcc.ID;
            Value = tempAcc.Value;
			Number = tempAcc.Number;

			using (var context = new AppDbContext())
			{
				var AllCard = context.Cards.Where(x => x.AccountID == tempAcc.ID);
				foreach(var i in AllCard)
				{
					Card card = new Card(i);
                    cards.Add(card);
				}
			}

        }
        public Account(float value)
		{
			if (value > 0)
			{
				Value = value;
			}
			else
			{
				throw new ArgumentOutOfRangeException();
			}
		}
        public Account()
        {
            
        }
		
    }
}
