namespace OOP_Bookcase_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int id;
        BookDb bookDB = new BookDb();

        private void Clean()
        {
            id = 0;
            txtBookName.Clear();
            txtAuthor.Clear();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bookDB.Listele();

            // DataGridView kolon isimlerini �zelle�tirme
            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["name"].HeaderText = "Kitap Ad�";
            dataGridView1.Columns["author"].HeaderText = "Yazar";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book ktp = new Book();
            ktp.name = txtBookName.Text;
            ktp.author = txtAuthor.Text;
            bookDB.AddBook(ktp);
            Clean();
            dataGridView1.DataSource = bookDB.Listele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.id = this.id;
            book.name = txtBookName.Text;
            book.author = txtAuthor.Text;
            bookDB.UpdateBook(book);
            Clean();
            dataGridView1.DataSource = bookDB.Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            id = Convert.ToInt16(dataGridView1.Rows[selected].Cells[0].Value.ToString());
            txtBookName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtAuthor.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.id = this.id;
            bookDB.DeleteBook(book);
            Clean();
            dataGridView1.DataSource = bookDB.Listele();
        }
    }
}