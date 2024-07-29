using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WindowsFormsApp6
{
    internal class Class1
    {
        //public bool setreservroom(string rno, string sts)
        //{
        //    OleDbConnection ro = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\db.accdb");
        //    ro.Open();
        //    string j = "Update room set Status =@status WHERE Room_ID=@roomno";
        //    OleDbCommand com = new OleDbCommand(j, ro);
        //    com.Parameters.Add("@status", OleDbType.VarChar).Value = rno;
        //    com.Parameters.Add("@roomno", OleDbType.VarChar).Value = sts;
        //    ro.Open();
        //    if (com.ExecuteNonQuery() == 1)
        //    {
        //        ro.Close();
        //        return true;
        //    }
        //    else
        //    {
        //        ro.Close();
        //        return false;
        //    }


        //}
    }
}
