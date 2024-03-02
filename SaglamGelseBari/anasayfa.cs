using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SaglamGelseBari
{

    public partial class anasayfa : Form
    {
        
        public anasayfa()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BMusteriGiris bMusteriGiris=new BMusteriGiris();
            bMusteriGiris.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KMusteriGiris kMusteriGiris= new KMusteriGiris();
            kMusteriGiris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelGiris personelGiris=new PersonelGiris();    
            personelGiris.Show();  
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminGiris adminGiris=new AdminGiris();
            adminGiris.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VeriCekme vericekme=new VeriCekme();
            vericekme.Show();
            this.Hide();
        }
    }
}
