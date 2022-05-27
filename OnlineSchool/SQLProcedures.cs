using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool
{
    internal class SQLProcedures
    {
        public static string connstr = "Data Source=DESKTOP-GD1AGLQ\\SQLEXPRESS;Initial Catalog=OnlineSchool;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connstr);
        public static SqlCommand cmd;
        public static SqlDataAdapter dataAdapter;

        public static DataTable refresh()
        {
            cmd = new SqlCommand("refresh", conn);
            dataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }

        public static void InsertStudent(Student student)
        {
            cmd = new SqlCommand("InsertStudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            sqlParameters[0].Value = student.name;
            sqlParameters[1] = new SqlParameter("@surname", SqlDbType.NVarChar, 50);
            sqlParameters[1].Value = student.surname;
            sqlParameters[2] = new SqlParameter("@email", SqlDbType.NVarChar, 50);
            sqlParameters[2].Value = student.email;
            sqlParameters[3] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            sqlParameters[3].Value = student.password;
            sqlParameters[4] = new SqlParameter("@mobileNumber", SqlDbType.Int);
            sqlParameters[4].Value = student.mobile_number;
            sqlParameters[5] = new SqlParameter("@grade", SqlDbType.Int);
            sqlParameters[5].Value = student.grade;
            sqlParameters[6] = new SqlParameter("@gender", SqlDbType.NVarChar, 50);
            sqlParameters[6].Value = student.gender;
            sqlParameters[7] = new SqlParameter("@school", SqlDbType.NVarChar, 50);
            sqlParameters[7].Value = student.school;
            cmd.Parameters.AddRange(sqlParameters);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
