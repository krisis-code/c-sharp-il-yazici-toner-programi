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
            Bitmap MyChartPanel = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(MyChartPanel, new Rectangle(0, 0, panel1.Width, panel1.Height));

            PrintDialog MyPrintDialog = new PrintDialog();

            if (MyPrintDialog.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Printing.PrinterSettings values;
                values = MyPrintDialog.PrinterSettings;
                MyPrintDialog.Document = MyPrintDocument;
                MyPrintDocument.PrintController = new System.Drawing.Printing.StandardPrintController();
                MyPrintDocument.Print();
            }

            MyPrintDocument.Dispose();
        }
        void PrintChart(object sender, PrintPageEventArgs ev)
        {
            using (var f = new System.Drawing.Font("Arial", 10))
            {
                var size = ev.Graphics.MeasureString(Text, f);
                ev.Graphics.DrawString("Whatever text you want", f, Brushes.Black, ev.PageBounds.X + (ev.PageBounds.Width - size.Width) / 2, ev.PageBounds.Y);
            }

            //Note, the chart printing code wants to print in pixels.
            System.Drawing.Rectangle marginBounds = ev.MarginBounds;
            if (ev.Graphics.PageUnit != GraphicsUnit.Pixel)
            {
                ev.Graphics.PageUnit = GraphicsUnit.Pixel;
                marginBounds.X = (int)(marginBounds.X * (ev.Graphics.DpiX / 100f));
                marginBounds.Y = (int)(marginBounds.Y * (ev.Graphics.DpiY / 100f));
                marginBounds.Width = (int)(marginBounds.Width * (ev.Graphics.DpiX / 100f));
                marginBounds.Height = (int)(marginBounds.Height * (ev.Graphics.DpiY / 100f));
            }

            chart1.Printing.PrintPaint(ev.Graphics, marginBounds);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult yazdirmaIslemi;
            yazdirmaIslemi = printDialog1.ShowDialog();
            if (yazdirmaIslemi == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
