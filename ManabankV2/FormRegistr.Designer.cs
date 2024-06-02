using System.Windows.Forms;

namespace Manabank
{
    partial class FormRegistr
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
            label2 = new Label();
            label1 = new Label();
            GoToReg = new Button();
            RegTextBoxPass = new TextBox();
            RegTextBoxLog = new TextBox();
            labelToLogin = new Label();
            label3 = new Label();
            RegtextBoxName = new TextBox();
            RegtextBoxSurname = new TextBox();
            label4 = new Label();
            RegtextBoxAge = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(108, 296);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 22);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(108, 224);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 22);
            label1.TabIndex = 10;
            label1.Text = "Login";
            // 
            // GoToReg
            // 
            GoToReg.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GoToReg.Location = new Point(135, 424);
            GoToReg.Margin = new Padding(4, 3, 4, 3);
            GoToReg.Name = "GoToReg";
            GoToReg.Size = new Size(175, 35);
            GoToReg.TabIndex = 7;
            GoToReg.Text = "Registr";
            GoToReg.UseVisualStyleBackColor = true;
            GoToReg.Click += GoToReg_Click;
            // 
            // RegTextBoxPass
            // 
            RegTextBoxPass.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegTextBoxPass.Location = new Point(113, 325);
            RegTextBoxPass.Margin = new Padding(4, 3, 4, 3);
            RegTextBoxPass.Name = "RegTextBoxPass";
            RegTextBoxPass.Size = new Size(214, 29);
            RegTextBoxPass.TabIndex = 6;
            // 
            // RegTextBoxLog
            // 
            RegTextBoxLog.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegTextBoxLog.Location = new Point(113, 253);
            RegTextBoxLog.Margin = new Padding(4, 3, 4, 3);
            RegTextBoxLog.Name = "RegTextBoxLog";
            RegTextBoxLog.Size = new Size(214, 29);
            RegTextBoxLog.TabIndex = 5;
            // 
            // labelToLogin
            // 
            labelToLogin.AutoSize = true;
            labelToLogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelToLogin.Location = new Point(145, 488);
            labelToLogin.Margin = new Padding(4, 0, 4, 0);
            labelToLogin.Name = "labelToLogin";
            labelToLogin.Size = new Size(165, 17);
            labelToLogin.TabIndex = 11;
            labelToLogin.Text = "Already have a account?";
            labelToLogin.TextAlign = ContentAlignment.MiddleCenter;
            labelToLogin.Click += labelToLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(108, 15);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 22);
            label3.TabIndex = 13;
            label3.Text = "Name";
            // 
            // RegtextBoxName
            // 
            RegtextBoxName.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegtextBoxName.Location = new Point(113, 44);
            RegtextBoxName.Margin = new Padding(4, 3, 4, 3);
            RegtextBoxName.Name = "RegtextBoxName";
            RegtextBoxName.Size = new Size(214, 29);
            RegtextBoxName.TabIndex = 12;
            // 
            // RegtextBoxSurname
            // 
            RegtextBoxSurname.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegtextBoxSurname.Location = new Point(113, 117);
            RegtextBoxSurname.Margin = new Padding(4, 3, 4, 3);
            RegtextBoxSurname.Name = "RegtextBoxSurname";
            RegtextBoxSurname.Size = new Size(214, 29);
            RegtextBoxSurname.TabIndex = 12;
            RegtextBoxSurname.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(108, 88);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 22);
            label4.TabIndex = 13;
            label4.Text = "Surname";
            
            // 
            // RegtextBoxAge
            // 
            RegtextBoxAge.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegtextBoxAge.Location = new Point(113, 182);
            RegtextBoxAge.Margin = new Padding(4, 3, 4, 3);
            RegtextBoxAge.Name = "RegtextBoxAge";
            RegtextBoxAge.Size = new Size(214, 29);
            RegtextBoxAge.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(108, 153);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 22);
            label5.TabIndex = 10;
            label5.Text = "Age";
            // 
            // FormRegistr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 532);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(RegtextBoxSurname);
            Controls.Add(RegtextBoxName);
            Controls.Add(labelToLogin);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(GoToReg);
            Controls.Add(RegTextBoxPass);
            Controls.Add(RegtextBoxAge);
            Controls.Add(RegTextBoxLog);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormRegistr";
            Text = "FormRegistr";
            FormClosing += FormRegistr_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GoToReg;
        private System.Windows.Forms.TextBox RegTextBoxPass;
        private System.Windows.Forms.TextBox RegTextBoxLog;
        private System.Windows.Forms.Label labelToLogin;
        private Label label3;
        private TextBox RegtextBoxName;
        private TextBox RegtextBoxSurname;
        private Label label4;
        private TextBox RegtextBoxAge;
        private Label label5;
    }
}