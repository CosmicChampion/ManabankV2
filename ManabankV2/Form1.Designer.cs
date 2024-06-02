using System.Windows.Forms;

namespace Manabank
{
    partial class Form1
    {
        private Form _tempForm;
        public Form1(Form form)
        {
            _tempForm = form;
        }
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
            this.label2 = new System.Windows.Forms.Label();
            this.AutTextBoxPass = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.AutTextBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelToReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(87, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // AutTextBoxPass
            // 
            this.AutTextBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutTextBoxPass.Location = new System.Drawing.Point(91, 190);
            this.AutTextBoxPass.Name = "AutTextBoxPass";
            this.AutTextBoxPass.Size = new System.Drawing.Size(184, 29);
            this.AutTextBoxPass.TabIndex = 1;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogIn.Location = new System.Drawing.Point(137, 244);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(95, 30);
            this.buttonLogIn.TabIndex = 2;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // AutTextBoxName
            // 
            this.AutTextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutTextBoxName.Location = new System.Drawing.Point(91, 115);
            this.AutTextBoxName.Name = "AutTextBoxName";
            this.AutTextBoxName.Size = new System.Drawing.Size(184, 29);
            this.AutTextBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // labelToReg
            // 
            this.labelToReg.AutoSize = true;
            this.labelToReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToReg.Location = new System.Drawing.Point(115, 292);
            this.labelToReg.Name = "labelToReg";
            this.labelToReg.Size = new System.Drawing.Size(134, 17);
            this.labelToReg.TabIndex = 12;
            this.labelToReg.Text = "Create new Account";
            this.labelToReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelToReg.Click += new System.EventHandler(this.labelToReg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.labelToReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.AutTextBoxPass);
            this.Controls.Add(this.AutTextBoxName);
            this.Name = "Form1";
            this.Text = "Autorization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AutTextBoxPass;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox AutTextBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelToReg;
    }
}

