using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static aciktimProje.usersInfo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aciktimProje
{
    public partial class kayitEkrani : Form

        
    {
        public kayitEkrani()
        {
            InitializeComponent();
        }
        

        connect con = new connect();
        public string email = "";

        

        private void btnKayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_Users (NAME,SURNAME,Mail,PASSWORD) values(@p1,@p2,@p3,@p4)", con.connection());


            komut.Parameters.AddWithValue("@p1", txtName.Text);
            komut.Parameters.AddWithValue("@p2", txtSurname.Text);
            komut.Parameters.AddWithValue("@p3", txtMail.Text);
            komut.Parameters.AddWithValue("@p4", txtPassword.Text);
            

            komut.ExecuteNonQuery();

            con.connection().Close();


            MessageBox.Show("YOU CAN NOW ENJOY FAST FOOD WITH ACIKTIM \n\n    **REGISTIRATION SUCCESSFUL**  ");
        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {


            
            

            SqlCommand command = new SqlCommand("select * from tbl_Users where Mail=@p1 and PASSWORD=@p2", con.connection());
            command.Parameters.AddWithValue("@p1", txtGirisEmail.Text);
            command.Parameters.AddWithValue("@p2", txtGirisPassword.Text);

            SqlDataReader dt = command.ExecuteReader();

            
            if (dt.Read())
            {
                //shops.lblMail.Text = email;
                
                shops sh = new shops();
                sh.kullaniciMail=txtGirisEmail.Text;
                sh.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Oops!! Wrong Informations. Please enter correctly.");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }

        private void txtGirisPassword_TextChanged_1(object sender, EventArgs e)
        {
            txtGirisPassword.PasswordChar = '●';
        }
    }
    }

