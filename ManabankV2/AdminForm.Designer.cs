namespace Manabank
{
    partial class AdminForm
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
            dataGridView1 = new DataGridView();
            buttonBAN = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(600, 670);
            dataGridView1.TabIndex = 0;
            // 
            // buttonBAN
            // 
            buttonBAN.Location = new Point(741, 631);
            buttonBAN.Name = "buttonBAN";
            buttonBAN.Size = new Size(137, 51);
            buttonBAN.TabIndex = 1;
            buttonBAN.Text = "BAN";
            buttonBAN.UseVisualStyleBackColor = true;
            buttonBAN.Click += buttonBAN_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(741, 561);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(137, 51);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 694);
            Controls.Add(buttonDelete);
            Controls.Add(buttonBAN);
            Controls.Add(dataGridView1);
            Name = "AdminForm";
            Text = "AdminForm";
            FormClosing += AdminForm_FormClosing;
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonBAN;
        private Button buttonDelete;
    }
}