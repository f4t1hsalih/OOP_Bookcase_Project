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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            lblBookName = new Label();
            lblAuthor = new Label();
            txtBookName = new TextBox();
            txtAuthor = new TextBox();
            btnList = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(209, 222, 216);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(46, 51, 72);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(440, 284);
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
            btnList.Location = new Point(231, 292);
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
            btnSave.Location = new Point(231, 331);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 33);
            btnSave.TabIndex = 6;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.FromArgb(46, 51, 72);
            btnDelete.Location = new Point(334, 331);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 33);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = Color.FromArgb(46, 51, 72);
            btnUpdate.Location = new Point(334, 292);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(97, 33);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(108, 138, 175);
            ClientSize = new Size(441, 376);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnList);
            Controls.Add(txtAuthor);
            Controls.Add(txtBookName);
            Controls.Add(lblAuthor);
            Controls.Add(lblBookName);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(46, 51, 72);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Kitaplık";
            FormClosed += Form1_FormClosed;
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
        private Button btnDelete;
        private Button btnUpdate;
    }
}