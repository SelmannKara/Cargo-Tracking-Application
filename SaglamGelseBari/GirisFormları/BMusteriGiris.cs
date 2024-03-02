using SaglamGelseBari.IslemFormları;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglamGelseBari
{
    public partial class BMusteriGiris : Form
    {
        public BMusteriGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BMusteriIslem bMusteriIslem= new BMusteriIslem();   
            bMusteriIslem.Show();
            this.Hide();
        }
    }
}
