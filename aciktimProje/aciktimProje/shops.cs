using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static aciktimProje.usersInfo;

namespace aciktimProje
{
    public partial class shops : Form

    {
        private int toplamFiyat = 0;
        public string kullaniciMail = "";
        
        
        
        private int sayac = 0;
        private int sayac1 = 0;
        private int sayac2 = 0;
        private int sayac3 = 0;
        private int sayac4 = 0;
        private int sayac5 = 0;
        private int sayac6 = 0;
        private int sayac7 = 0;
        private int sayac8 = 0;
        private int sayac9 = 0;
        private int sayac10 = 0;
        private int sayac11 = 0;
        private int sayac12 = 0;
        private int sayac13 = 0;
        private int sayac14 = 0;
        private int sayac15 = 0;
        private int sayac16 = 0;
        private int sayac17 = 0;
        public shops()
        {
            InitializeComponent();
            updateTotalPrice();
        }

        

        public string email = "";

          

        private void updateTotalPrice()
        {
            lblupdatePrice.Text = "TOTAL PRICE: " + toplamFiyat.ToString();
        }

       

        

        private void btnarti70_Click(object sender, EventArgs e)
        {

            sayac++;
            sycAkin1.Text = sayac.ToString();
            toplamFiyat += 70;
            updateTotalPrice();
        }

        private void btnarti40_Click(object sender, EventArgs e)
        {
            sayac1++;
            sycAkin2.Text = sayac1.ToString();
            toplamFiyat += 40;
            updateTotalPrice();
        }

        private void btnarti15_Click(object sender, EventArgs e)
        {
            sayac2++;
            sycAkin3.Text = sayac2.ToString();
            toplamFiyat += 15;
            updateTotalPrice();
        }

        private void btnarti135_Click(object sender, EventArgs e)
        {
            sayac3++;
            sycArif1.Text = sayac3.ToString();
            toplamFiyat += 135;
            updateTotalPrice();
        }

        private void btnarti185_Click(object sender, EventArgs e)
        {
            sayac4++;
            sycArif2.Text = sayac4.ToString();
            toplamFiyat += 185;
            updateTotalPrice();
        }

        private void btnarti35_Click(object sender, EventArgs e)
        {
            sayac5++;
            sycArif3.Text = sayac5.ToString();
            toplamFiyat += 35;
            updateTotalPrice();
        }

        private void btnarti59_Click(object sender, EventArgs e)
        {
            sayac6++;
            sycElif1.Text = sayac6.ToString();
            toplamFiyat += 59;
            updateTotalPrice();
        }

        private void btnarti90_Click(object sender, EventArgs e)
        {
            sayac7++;
            sycElif2.Text = sayac7.ToString();
            toplamFiyat += 90;
            updateTotalPrice();
        }

        private void btnarti36_Click(object sender, EventArgs e)
        {
            sayac8++;
            sycElif3.Text = sayac8.ToString();
            toplamFiyat += 36;
            updateTotalPrice();
        }

        private void btnarti250_Click(object sender, EventArgs e)
        {
            sayac9++;
            sycNisa1.Text = sayac9.ToString();
            toplamFiyat += 250;
            updateTotalPrice();
        }

        private void btnarti350_Click(object sender, EventArgs e)
        {
            sayac10++;
            sycNisa2.Text = sayac10.ToString();
            toplamFiyat += 350;
            updateTotalPrice();
        }

        private void btnarti140_Click(object sender, EventArgs e)
        {
            sayac11++;
            sycNisa3.Text = sayac11.ToString();
            toplamFiyat += 140;
            updateTotalPrice();
        }

        private void btnarti139_Click(object sender, EventArgs e)
        {
            sayac12++;
            sycAli1.Text = sayac12.ToString();
            toplamFiyat += 139;
            updateTotalPrice();
        }

        private void btnarti120_Click(object sender, EventArgs e)
        {
            sayac13++;
            sycAli2.Text = sayac13.ToString();
            toplamFiyat += 120;
            updateTotalPrice();
        }

        private void btnarti39_Click(object sender, EventArgs e)
        {
            sayac14++;
            sycAli3.Text = sayac14.ToString();
            toplamFiyat += 39;
            updateTotalPrice();
        }

        private void btnarti141_Click(object sender, EventArgs e)
        {
            sayac15++;
            sycHasan1.Text = sayac15.ToString();
            toplamFiyat += 141;
            updateTotalPrice();
        }

        private void btnarti142_Click(object sender, EventArgs e)
        {
            sayac16++;
            sycHasan2.Text = sayac16.ToString();
            toplamFiyat +=142;
            updateTotalPrice();
        }

        private void btnarti37_Click(object sender, EventArgs e)
        {
            sayac17++;
            sycHasan3.Text = sayac17.ToString();
            toplamFiyat += 37;
            updateTotalPrice();
        }

        private void btneksi70_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac--;
                sycAkin1.Text = sayac.ToString();
                toplamFiyat -= 70;
                updateTotalPrice();
            }
        }

        private void btneksi40_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac1--;
                sycAkin2.Text = sayac1.ToString();
                toplamFiyat -= 140;
                updateTotalPrice();
                

            }
        }

        private void btneksi15_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac2--;
                sycAkin3.Text = sayac2.ToString();
                toplamFiyat -= 15;
                updateTotalPrice();
            }
        }

        private void btneksi135_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac3--;
                sycArif1.Text = sayac3.ToString();
                toplamFiyat -= 135;
                updateTotalPrice();
            }
        }

        private void btneksi185_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac4--;
                sycArif2.Text = sayac4.ToString();
                toplamFiyat -= 185;
                updateTotalPrice();
            }
        }

        private void btneksi35_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac5--;
                sycArif3.Text = sayac5.ToString();
                toplamFiyat -= 35;
                updateTotalPrice();
            }
        }

        private void btneksi59_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac6--;
                sycElif1.Text = sayac6.ToString();
                toplamFiyat -= 59;
                updateTotalPrice();
            }
        }

        private void btneksi90_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac7--;
                sycElif2.Text = sayac7.ToString();
                toplamFiyat -= 90;
                updateTotalPrice();
            }
        }

        private void btneksi36_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac8--;
                sycElif3.Text = sayac8.ToString();
                toplamFiyat -= 36;
                updateTotalPrice();
            }
        }

        private void btneksi250_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac9--;
                sycNisa1.Text = sayac9.ToString();
                toplamFiyat -= 250;
                updateTotalPrice();
            }
        }

        private void btneksi350_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac10--;
                sycNisa2.Text = sayac10.ToString();
                toplamFiyat -= 350;
                updateTotalPrice();
            }
        }

        private void btneksi140_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac11--;
                sycNisa3.Text = sayac11.ToString();
                toplamFiyat -= 140;
                updateTotalPrice();
            }
        }

        private void btneksi139_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac12--;
                sycAli1.Text = sayac12.ToString();
                toplamFiyat -= 139;
                updateTotalPrice();
            }
        }

        private void btneksi120_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac13--;
                sycAli2.Text = sayac13.ToString();
                toplamFiyat -= 120;
                updateTotalPrice();
            }
        }

        private void btneksi39_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac14--;
                sycAli3.Text = sayac14.ToString();
                toplamFiyat -= 39;
                updateTotalPrice();
            }
        }

        private void btneksi141_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac15--;
                sycHasan1.Text = sayac15.ToString();
                toplamFiyat -= 141;
                updateTotalPrice();
            }
        }

        private void btneksi142_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac16--;
                sycHasan2.Text = sayac16.ToString();
                toplamFiyat -= 142;
                updateTotalPrice();
            }
        }

        private void btneksi37_Click(object sender, EventArgs e)
        {
            if (toplamFiyat > 0)
            {
                sayac17--;
                sycHasan3.Text = sayac17.ToString();
                toplamFiyat -= 37;
                updateTotalPrice();
            }
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            connect con = new connect();

            
            {
                SqlCommand command = new SqlCommand("INSERT INTO tbl_Orders (Mail, Fiyat) VALUES (@p1, @p2)", con.connection());


                {
                    command.Parameters.AddWithValue("@p1", kullaniciMail);
                    command.Parameters.AddWithValue("@p2", toplamFiyat);
                    

                    command.ExecuteNonQuery();
                    con.connection().Close();
                    
                }
            }
             
            MessageBox.Show("YOUR ORDER IS COMPLETED.\n \n YOU CAN CHECK THE ORDER LIST");
            orders or = new orders();
            or.Show();
            this.Hide();

        }

        private void shops_Load_1(object sender, EventArgs e)
        {
            lblMail.Text = kullaniciMail;
        }
    }
    

    
}
    
