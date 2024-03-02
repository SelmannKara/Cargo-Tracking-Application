using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using excell= Microsoft.Office.Interop.Excel;
namespace SaglamGelseBari
{
    public partial class VeriCekme : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KargoUygulamasi;Integrated Security=SSPI");
        public VeriCekme()
        {
            InitializeComponent();
        }
   

        private void VeriCekme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kargoUygulamasiDataSet.Rapor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.raporTableAdapter.Fill(this.kargoUygulamasiDataSet.Rapor);
            // TODO: Bu kod satırı 'kargoUygulamasiDataSet1.Rapor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.raporTableAdapter.Fill(this.kargoUygulamasiDataSet.Rapor);
            // TODO: Bu kod satırı 'kargoUygulamasiDataSet.Alici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


        }



        public void button1_Click(object sender, EventArgs e)
        {
            
           

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.raporTableAdapter.FillBy(this.kargoUygulamasiDataSet.Rapor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
