using System.Data.OleDb;

namespace OOP_Bookcase_Project
{
    internal class BookDb
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Yazilim\\C#\\OOP_Bookcase_Project\\OOP_Bookcase_Project\\krsDbBookcase.accdb");

        public List<Book> Listele()
        {
            List<Book> book = new List<Book>();

            connection.Open();
            string command = "Select id as 'ID', book_name as 'Kitap Adı', author as 'Yazar' from tbl_Books";
            OleDbCommand cmd = new OleDbCommand(command, connection);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Book k = new Book();
                k.id = Convert.ToInt16(dr[0].ToString());
                k.name = dr[1].ToString();
                k.author = dr[2].ToString();

                book.Add(k);
            }
            connection.Close();
            return book;
        }

        public void AddBook(Book book)
        {
            connection.Open();
            string command = "insert into tbl_Books(book_name, author) values (@p1, @p2)";
            OleDbCommand cmd = new OleDbCommand(command, connection);
            cmd.Parameters.AddWithValue("@p1", book.name);
            cmd.Parameters.AddWithValue("@p2", book.author);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kitap Başarıyla Kaydedildi");
        }

        public void UpdateBook(Book book)
        {
            connection.Open();
            string command = "Update tbl_Books set book_name=@p1, author=@p2 where id=@p3";
            OleDbCommand cmd = new OleDbCommand(command, connection);
            cmd.Parameters.AddWithValue("@p1", book.name);
            cmd.Parameters.AddWithValue("@p2", book.author);
            cmd.Parameters.AddWithValue("@p3", book.id);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kitap Başarıyla Güncelleni");
        }

        public void DeleteBook(Book book)
        {
            connection.Open();
            string command = "Delete from tbl_Books where id=@p1";
            OleDbCommand cmd = new OleDbCommand(command, connection);
            cmd.Parameters.AddWithValue("@p1", book.id);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kayıt Başarıyla Silindi");
        }

    }
}
