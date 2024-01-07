using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aciktimProje
{
    public partial class orders : Form
    {
        SqlDataAdapter adtr;
        DataTable tablo = new DataTable();

        public orders()
        {
            InitializeComponent();
            
        }
        connect con = new connect();
        void ListOrder()
        {
            tablo.Clear();
            adtr = new SqlDataAdapter("sp_ListOrders", con.connection());
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        void AddUser()
        {
            tablo.Clear();
            adtr = new SqlDataAdapter("sp_ListUsers", con.connection());
            adtr.Fill(tablo);
            dataGridView2.DataSource = tablo;
        }

       

        void DeleteUser()
        {

            tablo.Clear();
            adtr = new SqlDataAdapter("sp_ListOrders", con.connection());
            adtr.Fill(tablo);
            dataGridView3.DataSource = tablo;

        }
        void ListUsers()
        {
            tablo.Clear();
            adtr = new SqlDataAdapter("sp_ListUsers", con.connection());
            adtr.Fill(tablo);
            dataGridView4.DataSource = tablo;
        }
        
        

        

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser();

        }
        private void btnListUsers_Click(object sender, EventArgs e)
        {
            ListUsers();
        }

        private void btnListOrders_Click(object sender, EventArgs e)
        {
            ListOrder();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }
    }
}
