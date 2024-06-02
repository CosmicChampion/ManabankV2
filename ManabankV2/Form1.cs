
namespace Manabank
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {  
            string Login = AutTextBoxName.Text;
            string Pass = AutTextBoxPass.Text;
            
            if (Login == "admin" && Pass == "admin") 
            {
                var form = new AdminForm();
                this.Hide();
                form.Show();
            }
            else
            {
                using (var context = new AppDbContext())
                {
                    var user = context.Users.FirstOrDefault(user => user.login == Login && user.password == Pass);

                    if (user == null)
                    {
                        MessageBox.Show("Wrong login or password!");
                    }
                    else
                    {
                        var form = new MainForm(user);
                        this.Hide();
                        form.Show();
                    }
                }
            }
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
        }

        private void labelToReg_Click(object sender, EventArgs e)
        {
            FormRegistr registr = new FormRegistr(this);
            this.Hide();
            registr.Show();
        }
    }
}
