using Manabank.Models;
using Manabank.Exceptions;
using ManabankV2.Exceptions;

namespace Manabank
{
    public static class TransactionManager
    {
        public static void UseCreditCard(Card UserCard, int value)
        {
            if (UserCard.Total + value > UserCard.Limit)
            {
                throw new OutOfLimitException("You use all limit");
            }
            else
            {
                UserCard.Total += value;
            }
        }

        public static void SendMoney(User user, int NumOfCard, string ToNumber, int Amount) {

            if(NumOfCard == -1) 
            {
                if (user.Account.Value < Amount)
                {
                    throw new NotEnoughtMoney("You dont have enough money");
                }

                user.Account.Value -= Amount;

                using (var context = new AppDbContext())
                {
                    var FromAcc = context.Accounts.FirstOrDefault(x => x.UserId == user.Id);
                    var ToAcc = context.Accounts.FirstOrDefault(x => x.Number == CardNumberCreator.MakeSingle(ToNumber));

                    if (ToAcc != null)
                    {
                        FromAcc.Value -= Amount;
                        ToAcc.Value += Amount;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new WrongNumber("Wrong Number");
                    }
                }
            }  //use debit card
            else            
            {
                if (user.Account.cards[NumOfCard].Limit < Amount || user.Account.cards[NumOfCard].Limit - user.Account.cards[NumOfCard].Total < Amount)
                {
                    throw new NotEnoughtMoney("You dont have enough money");
                }

                user.Account.cards[NumOfCard].Total+=Amount;

                using (var context = new AppDbContext())
                {
                    var From = context.Cards.FirstOrDefault(x => x.Number == user.Account.cards[NumOfCard].Number);
                    var To = context.Accounts.FirstOrDefault(x => x.Number == CardNumberCreator.MakeSingle(ToNumber));

                    if (To != null)
                    {
                        From.Total += Amount;
                        To.Value += Amount;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new WrongNumber("Wrong Number");
                    }
                }
            }//use credit card

        }

        public static void RechargCredit(User user, string ToNumber, int Amount)
        {
            if(user.Account.Value< Amount) 
            {
                throw new NotEnoughtMoney("You have not enoght money");
            }
            else
            {
                using (var context = new AppDbContext())
                {
                    var From = context.Accounts.FirstOrDefault(x => x.UserId == user.Id);
                    var To = context.Cards.FirstOrDefault(x => x.Number == ToNumber);
                    if (To != null)
                    {
                        throw new WrongNumber("Wrong number of cacrd");
                    }
                    else 
                    {
                        From.Value -= Amount;
                        To.Total -= Amount;
                    }
                }
            }
            
        }
    }
}
