namespace OOP_Bookcase_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            lblBookName = new Label();
            lblAuthor = new Label();
            txtBookName = new TextBox();
            txtAuthor = new TextBox();
            btnList = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(209, 222, 216);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(413, 284);
            dataGridView1.TabIndex = 0;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(12, 298);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(79, 21);
            lblBookName.TabIndex = 1;
            lblBookName.Text = "Kitap Adı: ";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(33, 333);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(58, 21);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Yazarı: ";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(97, 295);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(115, 29);
            txtBookName.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(97, 330);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(115, 29);
            txtAuthor.TabIndex = 4;
            // 
            // btnList
            // 
            btnList.ForeColor = Color.FromArgb(46, 51, 72);
            btnList.Location = new Point(304, 291);
            btnList.Name = "btnList";
            btnList.Size = new Size(97, 33);
            btnList.TabIndex = 5;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnSave
            // 
            btnSave.ForeColor = Color.FromArgb(46, 51, 72);
            btnSave.Location = new Point(304, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 33);
            btnSave.TabIndex = 6;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(108, 138, 175);
            ClientSize = new Size(413, 376);
            Controls.Add(btnSave);
            Controls.Add(btnList);
            Controls.Add(txtAuthor);
            Controls.Add(txtBookName);
            Controls.Add(lblAuthor);
            Controls.Add(lblBookName);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(231, 229, 172);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Kitaplık";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblBookName;
        private Label lblAuthor;
        private TextBox txtBookName;
        private TextBox txtAuthor;
        private Button btnList;
        private Button btnSave;
    }
}