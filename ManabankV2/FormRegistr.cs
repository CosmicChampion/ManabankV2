using System.CodeDom;
using System.Data;
using Manabank.Models;


namespace Manabank
{
    public partial class FormRegistr : Form
    {
        public FormRegistr()
        {
            InitializeComponent();
        }

        private Form1 _tempForm;
        public FormRegistr(Form1 form)
        {
            InitializeComponent();
            _tempForm = form;
        }

        delegate void MyDelegate(string text);

        MyDelegate d = delegate(string text){
            MessageBox.Show(text);    
        }; 

        private void labelToLogin_Click(object sender, EventArgs e)
        {
            _tempForm.Show();
            this.Hide();
        }

        private void FormRegistr_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GoToReg_Click(object sender, EventArgs e)
        {
            string name = RegtextBoxName.Text;
            string surname = RegtextBoxSurname.Text;
            int age = Int32.Parse(RegtextBoxAge.Text);
            string login = RegTextBoxLog.Text;
            string pass = RegTextBoxPass.Text;

            using (var context = new AppDbContext())
            {
                var check = context.Users.FirstOrDefault(x => x.login == login || x.password == pass);
                
                if (check!= null)
                {
                    
                }
                else
                {
                    var newUser = new UsersVM(0, name, surname, age, login, pass, false);

                    context.Users.Add(newUser);
                    context.SaveChanges();
                    var id = context.Users.OrderBy(x => x.Id).Last().Id;
                    var newAcc = new AccountVM(0, id, CardNumberCreator.CreateNumber());
                    context.Accounts.Add(newAcc);
                    context.SaveChanges();
                    d("Account was created");
                }
            }
        }
    }
}
