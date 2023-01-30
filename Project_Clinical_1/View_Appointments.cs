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
    public partial class View_Appointments : Form
    {
        public View_Appointments()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Prev_Click(object sender, EventArgs e)
        {
            Doctor_Derma dr = new Doctor_Derma();
            dr.Show();
            this.Hide();
        }

        private void View_Appointments_Load(object sender, EventArgs e)
        {
            V_Appointments_cls app = new V_Appointments_cls();
            string query = "select * from AppointmentTBL";
            DataSet ds = app.Show_Appointment(query);
            V_Appointments_DGV.DataSource = ds.Tables[0];
        }
    }
}
