using System.Text;


namespace Manabank
{
    public static class CardNumberCreator
    {
        static readonly Random random = new Random();
        public static string CreateNumber()
        {
            StringBuilder cardNumber = new StringBuilder();

            cardNumber.Append(random.Next(1, 10));
            for (int i = 0; i < 15; i++)
            {
                cardNumber.Append(random.Next(0, 10));
            }
            return cardNumber.ToString();
        }
        public static string MakePretty(string num)
        {
            StringBuilder sb = new StringBuilder(num);

            for (int i = 4; i < sb.Length; i += 5)
            {
                sb.Insert(i, ' ');
            }

            return sb.ToString();
        }
        public static string MakeSingle(string num)
        {
            return num.Replace(" ", "");
        }
    }
        
}
