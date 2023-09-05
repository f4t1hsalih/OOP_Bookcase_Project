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
    }
}