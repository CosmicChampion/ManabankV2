
using Manabank.Models;



namespace Manabank
{
    public class User : Human
{
        public Account Account;
        public int Id {  get; set; }
        public bool IsBlocketed { get; set; } = false;
       
        public User()
        {
        }
        public User(UsersVM temp)
        {
            this.Id = temp.Id;
            this.Name = temp.Name;
            this.Age = temp.Age;
            this.Surname = temp.Surname;
            this.IsBlocketed = temp.IsBlocked;

            using (var context = new AppDbContext())
            {
                Account = new Account( context.Accounts.FirstOrDefault(x => x.UserId == Id));
            }
        }
        public User(Account account, string name, string surname, int age) 
        {
            Name = name;
            this.Age = age;
            this.Surname = surname;
            Account = account;
        }

        public sealed override void Show()
        {
            MessageBox.Show("User");
            base.Show();  
        }
    }
}