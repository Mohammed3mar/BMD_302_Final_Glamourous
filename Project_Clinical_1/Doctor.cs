using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Clinical_1
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Prev_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Show();
            this.Hide();
        }

        private void V_Appointment_Click(object sender, EventArgs e)
        {
            View_Appointments vp = new View_Appointments();
            vp.Show();
            this.Hide();
        }

        private void Medical_Record_Click(object sender, EventArgs e)
        {
            Medical_Record_P mp = new Medical_Record_P();
            mp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            V_History vh = new V_History();
            vh.Show();
            this.Hide();
            */
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OCR ocr = new OCR();
            ocr.Show();
            this.Hide();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doctor_Integrated di = new Doctor_Integrated();
            di.Show();
            this.Hide();
        }
    }
}
