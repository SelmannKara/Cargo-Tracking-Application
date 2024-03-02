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
    public partial class KMusteriGiris : Form
    {
        public KMusteriGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KMusteriIslem kMusteriIslem = new KMusteriIslem();
            kMusteriIslem.Show();
            this.Hide();
        }
    }
}
