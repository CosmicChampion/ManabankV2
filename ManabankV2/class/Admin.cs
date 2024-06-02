using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manabank { 
    public sealed class Admin : Human
    {
        public static void  BanUser(List<DataGridViewRow> selectedRows)
        {
            using (var context = new AppDbContext())
            {
                foreach (var row in selectedRows)
                {
                    var numberValue = row.Cells["NumberColumn"].Value.ToString();

                    var card = context.Cards.FirstOrDefault(x => x.Number == numberValue);
                    var acc = context.Accounts.FirstOrDefault(x => x.ID == card.AccountID);
                    var user = context.Users.FirstOrDefault(x => x.Id == acc.UserId);

                    user.IsBlocked = true;

                }
                context.SaveChanges();
            }
        }

        public static void DeleteUser(List<DataGridViewRow> selectedRows)
        {
            using (var context = new AppDbContext())
            {
                foreach (var row in selectedRows)
                {
                    var numberValue = row.Cells["NumberColumn"].Value.ToString();

                    var card = context.Cards.FirstOrDefault(x => x.Number == numberValue);
                    var acc = context.Accounts.FirstOrDefault(x => x.ID == card.AccountID);
                    var user = context.Users.FirstOrDefault(x => x.Id == acc.UserId);

                    context.Users.Attach(user);

                    context.Users.Remove(user);
                }
                context.SaveChanges();
            }
        }

    }
}
