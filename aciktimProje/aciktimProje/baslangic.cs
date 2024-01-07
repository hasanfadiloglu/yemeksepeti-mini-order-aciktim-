using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aciktimProje
{
    public partial class baslangic : Form
    {
        public baslangic()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 2;
            
            if (progressBar1.Value == 100) { 
                timer1.Stop();

                this.Hide();

                kayitEkrani ke = new kayitEkrani();
                ke.Show();
                
            }

        }
    }
}
