
namespace Manabank.Models
{
    public class UsersVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public bool IsBlocked { get; set; } = false;

        public AccountVM Account { get; set; }

        public UsersVM()
        {
            
        }
        public UsersVM(int id, string name, string surname, int age, string login, string pass1, bool isBl)
        {
                this.Id = id;
                this.Name = name;
                this.Age = age;
                this.Surname = surname;
                this.login = login;
                this.password = pass1;
                this.IsBlocked = isBl;
        }
    }
}
