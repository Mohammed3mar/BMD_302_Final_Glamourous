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

namespace Project_Clinical_1
{
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        ConnectionString MyCon = new ConnectionString();

        private void fillPatient()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select P_Name from PatientTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("P_Name", typeof(string));
            dt.Load(rdr);
            P_Name.ValueMember = "P_Name";
            P_Name.DataSource = dt;
            Con.Close();
        }

        private void fillDoctor()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select D_Name from DoctorTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("D_Name", typeof(string));
            dt.Load(rdr);
            P_Doctor.ValueMember = "D_Name";
            P_Doctor.DataSource = dt;
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Prev_Click(object sender, EventArgs e)
        {
            Receptionist re = new Receptionist();
            re.Show();
            this.Hide();
        }

        private void Reserve_Appointment_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs_Appointments())
            {
                MessageBox.Show("Please check the input filled");
            }
            else
            {
                string query = "insert into AppointmentTBL values('" + P_Name.Text + "','" + P_Phone_Number.Text + "','" + D_O_A.Value.Date + "','" + Slot.Text + "','" + Type_of_Session.Text + "','" + P_Doctor.Text + "')";
                Appointmentcls ad = new Appointmentcls();
                try
                {
                    ad.AddAppointment(query);
                    MessageBox.Show("Appointment Regesterd Successfully");

                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            fillPatient();
            fillDoctor();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool ValidateInputs_Appointments()
        {
            if (P_Phone_Number.Text == "")
                return false;
            if (Type_of_Session.SelectedIndex < 0)
                return false;
            if (P_Doctor.SelectedIndex < 0)
                return false;
            if (Slot.SelectedIndex < 0)
                return false;
            return true;
        }
    }
}
