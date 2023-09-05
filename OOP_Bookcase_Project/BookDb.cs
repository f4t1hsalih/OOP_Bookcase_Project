﻿using System.Data.OleDb;

namespace OOP_Bookcase_Project
{
    internal class BookDb
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Yazilim\\C#\\OOP_Bookcase_Project\\OOP_Bookcase_Project\\krsDbBookcase.accdb");

        public List<Book> Liste()
        {
            List<Book> book = new List<Book>();

            connection.Open();
            string command = "Select * from tbl_Books";
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
    }
}