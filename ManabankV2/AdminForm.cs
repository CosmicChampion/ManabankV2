using System.Windows.Forms;
using Manabank;
using System;
using Manabank.Interface;
using Manabank.Models;
using Microsoft.EntityFrameworkCore;

namespace Manabank
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            UpdateInformation();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBAN_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["CheckedColumn"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(checkBoxCell.Value) == true)
                {
                    selectedRows.Add(row);
                }
            }

            Admin.BanUser(selectedRows);

            UpdateInformation();

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["CheckedColumn"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(checkBoxCell.Value) == true)
                {
                    selectedRows.Add(row);
                }
            }
            Admin.DeleteUser(selectedRows);
            UpdateInformation();
        }


        public void UpdateInformation()
        {

            using (var context = new AppDbContext())
            {
                context.Cards.Include(c => c.Account).ThenInclude(a => a.User).Where(c => c.Limit <= c.Total).Load();

                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.Columns.Add("NameColumn", "Name");
                dataGridView1.Columns["NameColumn"].DataPropertyName = "Account.User.Name";

                dataGridView1.Columns.Add("SurNameColumn", "Surname");
                dataGridView1.Columns["SurNameColumn"].DataPropertyName = "Account.User.Surname";

                dataGridView1.Columns.Add("BalanceColumn", "Balance");
                dataGridView1.Columns["BalanceColumn"].DataPropertyName = "Account.Value";

                dataGridView1.Columns.Add("NumberColumn", "Number");
                dataGridView1.Columns["NumberColumn"].DataPropertyName = "Number";

                dataGridView1.Columns.Add("LimitColumn", "Limit");
                dataGridView1.Columns["LimitColumn"].DataPropertyName = "Limit";

                dataGridView1.Columns.Add("TotalColumn", "Total");
                dataGridView1.Columns["TotalColumn"].DataPropertyName = "Total";

                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Checked";
                checkBoxColumn.Name = "CheckedColumn";
                checkBoxColumn.DataPropertyName = "Checked";
                dataGridView1.Columns.Add(checkBoxColumn);

                dataGridView1.DataSource = context.Cards.Local.ToList();


                if (context.Cards.Local.Any())
                {
                    Console.WriteLine("Загальна кількість об'єктів у колекції Local: " + context.Cards.Local.Count);

                    // Виведіть дані кожного об'єкта в колекції Local
                    foreach (var card in context.Cards.Local)
                    {
                        Console.WriteLine("ID: " + card.ID);
                        Console.WriteLine("Номер картки: " + card.Number);
                        Console.WriteLine("Ліміт: " + card.Limit);
                        Console.WriteLine("Загальна сума: " + card.Total);

                        // Виведіть дані користувача, пов'язаного з цією карткою
                        if (card.Account != null && card.Account.User != null)
                        {
                            Console.WriteLine("Ім'я користувача: " + card.Account.User.Name);
                            Console.WriteLine("Прізвище користувача: " + card.Account.User.Surname);
                        }
                        else
                        {
                            Console.WriteLine("Користувач не знайдений.");
                        }

                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Колекція Local не містить об'єктів.");
                }
            }
        }
    }


}

