namespace Manabank
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            buttonRecharge = new Button();
            buttonSendMoney = new Button();
            panel1 = new Panel();
            labelNumber = new Label();
            labelName = new Label();
            labelTotal = new Label();
            labelBalance = new Label();
            buttonGoLeft = new Button();
            buttonGoRight = new Button();
            tabPage2 = new TabPage();
            buttonGoBack = new Button();
            buttonSend = new Button();
            label4 = new Label();
            label3 = new Label();
            textBoxAmount = new TextBox();
            textBoxNumber = new TextBox();
            tabPage3 = new TabPage();
            button2 = new Button();
            buttonCreateCard = new Button();
            textBox3 = new TextBox();
            textBoxLimit = new TextBox();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-3, -23);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(740, 809);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(buttonRecharge);
            tabPage1.Controls.Add(buttonSendMoney);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(buttonGoLeft);
            tabPage1.Controls.Add(buttonGoRight);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(732, 781);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.Enter += tabPage1_Enter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(263, 649);
            button1.Name = "button1";
            button1.Size = new Size(165, 64);
            button1.TabIndex = 5;
            button1.Text = "Create new credit card";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rubik", 12F);
            label2.Location = new Point(378, 382);
            label2.Name = "label2";
            label2.Size = new Size(171, 19);
            label2.TabIndex = 4;
            label2.Text = "Recharge Credit Card";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rubik", 12F);
            label1.Location = new Point(205, 382);
            label1.Name = "label1";
            label1.Size = new Size(103, 19);
            label1.TabIndex = 4;
            label1.Text = "Send money";
            // 
            // buttonRecharge
            // 
            buttonRecharge.FlatStyle = FlatStyle.Popup;
            buttonRecharge.ForeColor = SystemColors.ActiveCaption;
            buttonRecharge.Image = (Image)resources.GetObject("buttonRecharge.Image");
            buttonRecharge.Location = new Point(424, 309);
            buttonRecharge.Name = "buttonRecharge";
            buttonRecharge.Size = new Size(70, 70);
            buttonRecharge.TabIndex = 3;
            buttonRecharge.UseVisualStyleBackColor = true;
            buttonRecharge.Click += buttonRecharge_Click;
            // 
            // buttonSendMoney
            // 
            buttonSendMoney.FlatStyle = FlatStyle.Popup;
            buttonSendMoney.ForeColor = SystemColors.ActiveCaption;
            buttonSendMoney.Image = (Image)resources.GetObject("buttonSendMoney.Image");
            buttonSendMoney.Location = new Point(216, 309);
            buttonSendMoney.Name = "buttonSendMoney";
            buttonSendMoney.Size = new Size(70, 70);
            buttonSendMoney.TabIndex = 3;
            buttonSendMoney.UseVisualStyleBackColor = true;
            buttonSendMoney.Click += buttonSendMoney_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(labelNumber);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(labelTotal);
            panel1.Controls.Add(labelBalance);
            panel1.Location = new Point(171, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 218);
            panel1.TabIndex = 2;
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Font = new Font("Segoe UI", 14F);
            labelNumber.Location = new Point(45, 108);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(63, 25);
            labelNumber.TabIndex = 0;
            labelNumber.Text = "label1";
            labelNumber.Click += labelNumber_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(21, 181);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 21);
            labelName.TabIndex = 0;
            labelName.Text = "label1";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 14F);
            labelTotal.Location = new Point(24, 71);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(63, 25);
            labelTotal.TabIndex = 0;
            labelTotal.Text = "label1";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 17F);
            labelBalance.Location = new Point(21, 40);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(76, 31);
            labelBalance.TabIndex = 0;
            labelBalance.Text = "label1";
            // 
            // buttonGoLeft
            // 
            buttonGoLeft.BackColor = Color.White;
            buttonGoLeft.Location = new Point(9, 36);
            buttonGoLeft.Name = "buttonGoLeft";
            buttonGoLeft.Size = new Size(75, 227);
            buttonGoLeft.TabIndex = 1;
            buttonGoLeft.Text = "<<";
            buttonGoLeft.UseVisualStyleBackColor = false;
            buttonGoLeft.Click += buttonGoLeft_Click;
            // 
            // buttonGoRight
            // 
            buttonGoRight.BackColor = Color.White;
            buttonGoRight.Location = new Point(649, 36);
            buttonGoRight.Name = "buttonGoRight";
            buttonGoRight.Size = new Size(75, 227);
            buttonGoRight.TabIndex = 1;
            buttonGoRight.Text = ">>";
            buttonGoRight.UseVisualStyleBackColor = false;
            buttonGoRight.Click += buttonGoRight_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonGoBack);
            tabPage2.Controls.Add(buttonSend);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(textBoxAmount);
            tabPage2.Controls.Add(textBoxNumber);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(732, 781);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonGoBack
            // 
            buttonGoBack.Font = new Font("Segoe UI", 14F);
            buttonGoBack.Location = new Point(427, 361);
            buttonGoBack.Name = "buttonGoBack";
            buttonGoBack.Size = new Size(118, 46);
            buttonGoBack.TabIndex = 2;
            buttonGoBack.Text = "Cancel";
            buttonGoBack.UseVisualStyleBackColor = true;
            buttonGoBack.Click += buttonGoBack_Click;
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Segoe UI", 14F);
            buttonSend.Location = new Point(205, 361);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(183, 46);
            buttonSend.TabIndex = 2;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(95, 267);
            label4.Name = "label4";
            label4.Size = new Size(116, 21);
            label4.TabIndex = 1;
            label4.Text = "Enter a amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(93, 184);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 1;
            label3.Text = "Enter a number";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Font = new Font("Segoe UI", 12F);
            textBoxAmount.Location = new Point(96, 291);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(166, 29);
            textBoxAmount.TabIndex = 0;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Font = new Font("Segoe UI", 12F);
            textBoxNumber.Location = new Point(96, 211);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(270, 29);
            textBoxNumber.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(buttonCreateCard);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(textBoxLimit);
            tabPage3.Controls.Add(label5);
            tabPage3.Font = new Font("Segoe UI", 11F);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(732, 781);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(303, 468);
            button2.Name = "button2";
            button2.Size = new Size(76, 29);
            button2.TabIndex = 3;
            button2.Text = "Main";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonCreateCard
            // 
            buttonCreateCard.Location = new Point(292, 397);
            buttonCreateCard.Name = "buttonCreateCard";
            buttonCreateCard.Size = new Size(97, 41);
            buttonCreateCard.TabIndex = 3;
            buttonCreateCard.Text = "OK";
            buttonCreateCard.UseVisualStyleBackColor = true;
            buttonCreateCard.Click += buttonCreateCard_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLightLight;
            textBox3.Location = new Point(231, 298);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(220, 75);
            textBox3.TabIndex = 2;
            textBox3.Text = "We will review your statement within 10 minutes";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxLimit
            // 
            textBoxLimit.Font = new Font("Segoe UI", 13F);
            textBoxLimit.Location = new Point(260, 250);
            textBoxLimit.Name = "textBoxLimit";
            textBoxLimit.Size = new Size(152, 31);
            textBoxLimit.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(256, 212);
            label5.Name = "label5";
            label5.Size = new Size(156, 25);
            label5.TabIndex = 0;
            label5.Text = "Wtite desired limit";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 770);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Manabank";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Label labelBalance;
        private Panel panel1;
        private Label labelName;
        private Button buttonGoRight;
        private Label labelNumber;
        private Button buttonSendMoney;
        private Label label1;
        private Button buttonRecharge;
        private Label label2;
        private Button buttonGoLeft;
        private Button buttonGoBack;
        private Button buttonSend;
        private Label label4;
        private Label label3;
        private TextBox textBoxAmount;
        private TextBox textBoxNumber;
        private Button button1;
        private TabPage tabPage3;
        private TextBox textBoxLimit;
        private Label label5;
        private TextBox textBox3;
        private Button buttonCreateCard;
        private Button button2;
        private Label labelTotal;
    }
}