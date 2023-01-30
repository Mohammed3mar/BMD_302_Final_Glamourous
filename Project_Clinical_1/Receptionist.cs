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
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Appointments D = new Appointments();
            D.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Appointments P = new Appointments();
            P.Show();
            this.Hide();
        }

        private void Adding_Patient_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
            this.Hide();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {

        }
    }
}
