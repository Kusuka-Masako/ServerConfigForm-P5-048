using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using ServiceMtk_P1_048;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerConfigForm_P5_048
{
    public partial class Form1 : Form
    {
        ServiceHost Host;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnon.Enabled = true;
            btnoff.Enabled = false;
            Host.Close();
            labelket.Text = "klik ON untuk Menjalankan Server";
            labelOnOrOff.Text = "Server OFF";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnon_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnOrOff.Text = "Server ON";
            labelket.Text = "Klik OFF untuk Mematikan Server";
            Host.Open();
            btnon.Enabled = false;
            btnoff.Enabled = true;
        }
    }
}
