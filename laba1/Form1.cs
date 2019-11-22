using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace laba1
{
    public partial class Form1 : Form
    {
        public static string A = string.Empty;
        public Form1()
        {
            InitializeComponent();
            DataTable T = GetAllTable();

            //PrintTable(T);
            //label1.Text = A;

            dataGridView1.DataSource = T;

        }
        public static DataTable GetAllTable()
        {
            string DB = "Data Source=(LocalDB)\\v11.0;Initial Catalog=TestD;Integrated Security=True";
            string Query = "select * from MyTableFamily";
            using (SqlConnection Conn = new SqlConnection(DB))
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                Conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(Query, DB);
                da.Fill(ds);
                dt = ds.Tables[0];
                return dt;
            }
        }
        

    }
}
