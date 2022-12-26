using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

            //chart1.Series["Deneme"].Points.AddXY("enes", 12);
            //chart1.Series["Deneme"].Points.AddXY("enes", 12);
            chart1.Series["Deneme"].Points.AddXY("enes", 1);
            InitializeComponent();
        }
        

    }
}
