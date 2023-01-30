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
    public partial class Doctor_Derma : Form
    {
        public Doctor_Derma()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
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
            View_Appointments vd = new View_Appointments();
            vd.Show();
            this.Hide();
        }

        private void Medical_Record_Click(object sender, EventArgs e)
        {
            Derma_Medical dm = new Derma_Medical();
            dm.Show();
            this.Hide();
        }

        private void V_H_Click(object sender, EventArgs e)
        {
            Doctor_Integrated di = new Doctor_Integrated();
            di.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OCR_Derma_Click(object sender, EventArgs e)
        {
            OCR_Derma ocrd = new OCR_Derma();
            ocrd.Show();
            this.Hide();
        }

        private void Doctor_Derma_Load(object sender, EventArgs e)
        {

        }
    }
}
