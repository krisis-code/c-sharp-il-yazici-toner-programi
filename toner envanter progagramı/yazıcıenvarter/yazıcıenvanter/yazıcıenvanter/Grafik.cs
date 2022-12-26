using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazıcıenvanter
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            
            InitializeComponent();
        }

        private void Grafik_Load(object sender, EventArgs e)
        {

        }
        public void VoKaydetChart()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-9JCBJ7U;Initial Catalog=TonerStokGenel;Integrated Security=True");


                SqlCommand VoChartcmd = new SqlCommand("SELECT Kullanılan,KullanimTarihi FROM tonerStokGenel ORDER BY KullanimTarihi ", conn);
                conn.Open();
                SqlDataReader VoRead = VoChartcmd.ExecuteReader();
                while (VoRead.Read())
                {
                    chart1.Series["Series1"].Points.AddXY(VoRead[1], VoRead[0]);
                    

                }
                VoRead.Close();
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Vucut ölçüleri chart veri tabanına kaydetme hatsı" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           VoKaydetChart();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Printing.PrintPreview();
        }
    }
}
