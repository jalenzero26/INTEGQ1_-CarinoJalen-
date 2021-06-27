using System;
using MySql.Data.MySqlClient;
namespace DLayer
{
    public class SqlConnect
    { 
        static public void connect(string membername, string facultyid) 
        {
            //undone connect
            string CString = "server=localhost;database=facultymem;uid=root;pwd=pwd;";
                MySqlConnection connectmydb 
                = new MySqlConnection(CString);
            {
                var inputeddata = "INSERT INTO members " + "(membername, facultyid)" + " VALUES ('@membername', '@facultyid')";
                Console.WriteLine();
                MySqlCommand userinput 
                = new MySqlCommand(inputeddata, connectmydb);
                Console.WriteLine();
                userinput.Parameters.AddWithValue("@memberfacultyid", membername);
                userinput.Parameters.AddWithValue("@facultyid", facultyid);
                //userinput.GetHashCode();
                connectmydb.Open();
                Console.WriteLine();
                userinput.ExecuteNonQuery();
                userinput.BeginExecuteReader();
                Console.WriteLine();
                //connectmydb.BeginTransaction();
                connectmydb.Close();
                
                Console.WriteLine();
                Console.WriteLine("DONE SUBMITTING \t");
            }
        }   
    }
}
