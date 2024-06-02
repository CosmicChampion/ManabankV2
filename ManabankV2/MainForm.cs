using Manabank.Interface;
using Manabank.Models;

namespace Manabank
{
    public partial class MainForm : Form, IUserUpdate
    {
        private User _thisUser;
        private int _currentCard = -1;
        private int _numOfCards;

        delegate void MyDelegate(string text);

        MyDelegate del = delegate (string text)
        {
            MessageBox.Show(text);
        };

        MyDelegate lamb = (string text) =>
            MessageBox.Show(text);

        public MainForm(UsersVM tempUser)
        {
            _thisUser = new User(tempUser);
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (_thisUser.IsBlocketed == true)
            {
                MessageBox.Show("Your account has been blocked");

                buttonGoLeft.Visible = false;
                labelTotal.Visible = false;
                buttonGoRight.Visible = false;
                buttonRecharge.Visible = false;
                label2.Visible = false;
                buttonSendMoney.Visible = false;
                buttonRecharge.Visible = false;
                label1.Visible = false;
                button1.Visible = false;
            }

            labelName.Text = _thisUser.FullName();
            labelBalance.Text = _thisUser.Account.Value.ToString() + " $";

            labelNumber.Text = CardNumberCreator.MakePretty(_thisUser.Account.Number.ToString());

            buttonGoLeft.Visible = false;
            labelTotal.Visible = false;

            if (_thisUser.Account.cards.Count() <= 0)
            {
                buttonGoRight.Visible = false;
                buttonRecharge.Visible = false;
                label2.Visible = false;
            }
            else
            {
                _numOfCards = _thisUser.Account.cards.Count() - 1;
            }
        }

        private void buttonSendMoney_Click(object sender, EventArgs e)
        {

            tabControl1.SelectTab(1);
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string ToNumber = textBoxNumber.Text;
            int Amount = Int32.Parse(textBoxAmount.Text);

            try
            {
                TransactionManager.SendMoney(_thisUser, _currentCard, ToNumber, Amount);
                del("Monye was succsesfuly sended");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void labelNumber_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelNumber.Text);
            MessageBox.Show("Номер скопійовано");
        }

        private void buttonCreateCard_Click(object sender, EventArgs e)
        {
            float _newLimit;
            if (float.TryParse(textBoxLimit.Text, out _newLimit))
            {
                if (_newLimit < 0)
                {
                    MessageBox.Show("Неправильний ліміт");
                }
                else
                {
                    var newCard = new Card(_newLimit, 0);
                    _thisUser.Account.cards.Add(newCard);

                    using (var context = new AppDbContext())
                    {
                        context.Cards.Add(new CardVM(_thisUser.Account.Id, _newLimit, 0, CardNumberCreator.CreateNumber()));
                        context.SaveChanges();
                    }
                    MessageBox.Show("Заявка прийнята");
                }
            }
            else
            {
                MessageBox.Show("Неправильний формат введеного значення ліміту");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void buttonGoRight_Click(object sender, EventArgs e)
        {
            NextCard();
        }

        private void buttonGoLeft_Click(object sender, EventArgs e)
        {
            PreviousCard();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            UpdateInformation(_thisUser);
        }

        public void UpdateInformation(User olduser)
        {
            using (var context = new AppDbContext())
            {
                UsersVM upd = context.Users.FirstOrDefault(x => x.Id == _thisUser.Id);
                if (upd != null) _thisUser = new User(upd);
            }

            _currentCard = -1;

            labelName.Text = _thisUser.FullName();
            labelBalance.Text = _thisUser.Account.Value.ToString() + " $";
            labelNumber.Text = CardNumberCreator.MakePretty(_thisUser.Account.Number.ToString());

            buttonGoRight.Visible = true;
            buttonGoLeft.Visible = false;
            labelTotal.Visible = false;

            if (_thisUser.Account.cards.Count() <= 0)
            {
                buttonGoRight.Visible = false;
                buttonRecharge.Visible = false;
                label2.Visible = false;
            }
            else
            {
                _numOfCards = _thisUser.Account.cards.Count() - 1;
            }
        }

        public void NextCard()
        {
            buttonGoLeft.Visible = true;
            labelTotal.Visible = true;
            _currentCard++;

            if (_currentCard == _numOfCards)
            {
                buttonGoRight.Visible = false;
            }
            labelNumber.Text = CardNumberCreator.MakePretty(_thisUser.Account.cards[_currentCard].Number);
            labelBalance.Text = _thisUser.Account.cards[_currentCard].Limit.ToString() + " $";
            labelTotal.Text = _thisUser.Account.cards[_currentCard].Total.ToString() + " $";
        }

        public void PreviousCard()
        {
            buttonGoRight.Visible = true;
            _currentCard--;

            if (_currentCard == -1)
            {
                buttonGoLeft.Visible = false;
                labelTotal.Visible = false;

                labelBalance.Text = _thisUser.Account.Value.ToString() + " $";
                labelNumber.Text = CardNumberCreator.MakePretty(_thisUser.Account.Number.ToString());
            }
            else
            {
                labelNumber.Text = CardNumberCreator.MakePretty(_thisUser.Account.cards[_currentCard].Number);
                labelBalance.Text = _thisUser.Account.cards[_currentCard].Limit.ToString() + " $";
                labelTotal.Text = _thisUser.Account.cards[_currentCard].Total.ToString() + " $";
            }

        }


        private void foo()
        {
            Human user_for_fun = new User();

            user_for_fun.Show();


        }

        private void buttonRecharge_Click(object sender, EventArgs e)
        {

        }
    }
}
