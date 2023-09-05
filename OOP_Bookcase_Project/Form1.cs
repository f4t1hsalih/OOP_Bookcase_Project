namespace OOP_Bookcase_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BookDb bookDB = new BookDb();

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bookDB.Liste();
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
        }
    }
}