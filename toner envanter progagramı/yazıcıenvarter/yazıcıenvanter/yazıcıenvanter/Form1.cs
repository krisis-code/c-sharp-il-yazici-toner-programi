using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using Microsoft.Office.Tools.Excel.Controls;


namespace yazıcıenvanter
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9JCBJ7U;Initial Catalog=tonerStok;Integrated Security=True");
         SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            griddoldur();
            StokTxbx.Enabled = false;
            KullanilanTbx.Enabled = false;
            Arama();

        }
        public void griddoldur()
        {

            SqlDataAdapter TstokDa = new SqlDataAdapter("SELECT * FROM   Tstok", con);
            con.Open();
            System.Data.DataTable TstokTablo = new System.Data.DataTable();
            TstokDa.Fill(TstokTablo);
            datagrip.DataSource = TstokTablo;
            con.Close();
        }


        public void StokEKleme()
        {
            int Stok = 0;
            int Kullanılan = 0;

            for (int i = 0; i < datagrip.Rows.Count; i++)
            {

                Stok += Convert.ToInt32(datagrip.Rows[i].Cells["Stok"].Value);
                


            }
            Arama();
            guncelle();
            label1.Text = Stok.ToString();
            if (label1.Text=="0")
            {
                SqlCommand VoCmd = new SqlCommand("INSERT INTO Tstok (YaziciNumarasi,Renk,Stok,SatinAlimTarihi,EksikStok,Kullanılan) " +
                 "VALUES(@YaziciNumarasi,@Renk,@Stok,@SatinAlimTarihi,@EksikStok,@Kullanılan)", con);

                VoCmd.Parameters.AddWithValue("@YaziciNumarasi", YpCmbx.Text);
                VoCmd.Parameters.AddWithValue("@Renk", RenkCmbx.Text);
                VoCmd.Parameters.AddWithValue("@Stok", StokTxbx.Text);
                VoCmd.Parameters.AddWithValue("@EksikStok", "0");
                VoCmd.Parameters.AddWithValue("@Kullanılan", "0");
                VoCmd.Parameters.AddWithValue("@SatinAlimTarihi", dateTimePicker1.Value);

                con.Open();
                VoCmd.ExecuteNonQuery();
                MessageBox.Show("Kaydedildi");

                con.Close();

                Arama();
                guncelle();
            }
            else
            {
                SqlCommand cmd = new SqlCommand(" update  Tstok  set  Stok=@Stok where YaziciNumarasi = '" + YpCmbx.Text + "' and Renk = '" + RenkCmbx.Text + "' ", con);
                con.Open();
                
                cmd.Parameters.AddWithValue("@Stok",int.Parse( StokTxbx.Text) + int.Parse( Stok.ToString()));
                
                cmd.ExecuteNonQuery();
                con.Close();
                Arama();
                guncelle();
            }


            
         

        }
        public void StokCikti()
        {
            int Stok = 0;
            int Kullanılan = 0;
            int kullan = 0;

            for (int i = 0; i < datagrip.Rows.Count; i++)
            {

                Stok += Convert.ToInt32(datagrip.Rows[i].Cells["Stok"].Value);
                Kullanılan += Convert.ToInt32(datagrip.Rows[i].Cells["Kullanılan"].Value);
                kullan += Convert.ToInt32(datagrip.Rows[i].Cells["EksikStok"].Value);


            }

            label1.Text = Stok.ToString();
            label2.Text = Kullanılan.ToString();
            label3.Text = kullan.ToString();
            Arama();
            guncelle();
            if (label1.Text == "0")
            {
                MessageBox.Show("Stok kalmadı");
                
            }
            if (Kullanılan.ToString() == "0")
            {
                SqlCommand cmd = new SqlCommand(" update  Tstok  set  Stok=@Stok, Kullanılan = @Kullanılan, EksikStok=@EksikStok,KullanimTarihi= @KullanimTarihi where YaziciNumarasi = '" + YpCmbx.Text + "' and Renk = '" + RenkCmbx.Text + "' ", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Kullanılan", KullanilanTbx.Text);
                cmd.Parameters.AddWithValue("@KullanimTarihi", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Stok", int.Parse(label1.Text) - int.Parse(KullanilanTbx.Text));
                cmd.Parameters.AddWithValue("@EksikStok", int.Parse(KullanilanTbx.Text) + int.Parse(label2.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                Arama();
                guncelle();
            }
            else
            {
                SqlCommand cmd = new SqlCommand(" update  Tstok  set  Stok=@Stok, Kullanılan = @Kullanılan, EksikStok=@EksikStok,KullanimTarihi= @KullanimTarihi where YaziciNumarasi = '" + YpCmbx.Text + "' and Renk = '" + RenkCmbx.Text + "' ", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Kullanılan", int.Parse(KullanilanTbx.Text) + int.Parse(label2.Text));
                cmd.Parameters.AddWithValue("@KullanimTarihi", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Stok", int.Parse(label1.Text) - int.Parse(label2.Text));
                cmd.Parameters.AddWithValue("@EksikStok", int.Parse(KullanilanTbx.Text) + int.Parse(label2.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                Arama();
                guncelle();
            }
          
            for (int i = 0; i < datagrip.Rows.Count; i++)
            {

                Stok += Convert.ToInt32(datagrip.Rows[i].Cells["Stok"].Value);
                Kullanılan += Convert.ToInt32(datagrip.Rows[i].Cells["Kullanılan"].Value);
                kullan += Convert.ToInt32(datagrip.Rows[i].Cells["EksikStok"].Value);


            }

            label1.Text = Stok.ToString();
            label2.Text = Kullanılan.ToString();
            label3.Text = kullan.ToString();
            Arama();
            guncelle();


        }
        public void cikti()
        {
            int Stok = 0;
            int Kullanılan = 0;

            for (int i = 0; i < datagrip.Rows.Count; i++)
            {

                Stok += Convert.ToInt32(datagrip.Rows[i].Cells["Stok"].Value);
                Kullanılan += Convert.ToInt32(datagrip.Rows[i].Cells["Kullanılan"].Value);


            }

            label1.Text = Stok.ToString();
            label2.Text = Kullanılan.ToString();

            SqlCommand cmd = new SqlCommand(" update  Tstok  set  Stok=@Stok, Kullanılan = @Kullanılan, EksikStok=@EksikStok,KullanimTarihi= @KullanimTarihi where YaziciNumarasi = '%"+YpCmbx.SelectedValue+"%' and Renk = '%" +RenkCmbx.SelectedValue+ "%' ", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Kullanılan", KullanilanTbx.Text);
            cmd.Parameters.AddWithValue("@KullanimTarihi", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Stok", int.Parse(label1.Text) - int.Parse(label2.Text));
            cmd.Parameters.AddWithValue("@EksikStok",label2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            guncelle();
            StokCikti();
        }

        public void Arama()
        {
            
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Tstok where  YaziciNumarasi  Like  '" + YpCmbx.Text + "' and Renk Like '%" + RenkCmbx.Text + "%'  ", con);
                con.Open();
                SqlDataAdapter da3 = new SqlDataAdapter();
                System.Data.DataTable dt3 = new System.Data.DataTable();
                da3.SelectCommand = cmd;
                dt3.Clear();
                da3.Fill(dt3);
                datagrip.DataSource = dt3;
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Besin değeri Tarihe göre listeleme hatası" + ex.Message);
            }
          

           


        }
        public void guncelle()
        {
            int Stok = 0;
            int Kullanılan = 0;
            int kullan = 0;

            for (int i = 0; i < datagrip.Rows.Count; i++)
            {

                Stok += Convert.ToInt32(datagrip.Rows[i].Cells["Stok"].Value);
                Kullanılan += Convert.ToInt32(datagrip.Rows[i].Cells["Kullanılan"].Value);
                kullan += Convert.ToInt32(datagrip.Rows[i].Cells["EksikStok"].Value);


            }

            label1.Text = Stok.ToString();
            label2.Text = Kullanılan.ToString();
            label3.Text = kullan.ToString();
        }
        private void islemButton_Click(object sender, EventArgs e)
        {
            if (IslemCmbx.Text == "Girdi")
            {
                StokTxbx.Enabled = true;
                KullanilanTbx.Enabled = false;
                StokEKleme();
            }
            if (IslemCmbx.Text == "Çıktı")
            {
                KullanilanTbx.Enabled = true;
                StokTxbx.Enabled = false;
                StokCikti();

            }
            
        }

        private void IslemCmbx_SelectedValueChanged(object sender, EventArgs e)
        {
            if (IslemCmbx.Text=="Girdi")
            {
                StokTxbx.Enabled = true;
                KullanilanTbx.Enabled = false;
                Arama();
            }
            if (IslemCmbx.Text == "Çıktı")
            {
                KullanilanTbx.Enabled = true;
                StokTxbx.Enabled = false;
                Arama();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void YpCmbx_SelectedValueChanged(object sender, EventArgs e)
        {
            Arama();
        }

        private void RenkCmbx_SelectedValueChanged(object sender, EventArgs e)
        {
            Arama();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < datagrip.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = datagrip.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < datagrip.Rows.Count; i++)
            {
                for (int j = 0; j < datagrip.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = datagrip[j, i].Value == null ? "" : datagrip[j, i].Value;
                    myRange.Select();


                }
            }
        }
    }
}
