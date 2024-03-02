using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglamGelseBari
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new anasayfa());
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KargoUygulamasi;Integrated Security=SSPI");
        }
    }
}
