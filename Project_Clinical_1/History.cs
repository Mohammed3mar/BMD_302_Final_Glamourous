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

namespace Project_Clinical_1
{
    public partial class History : Form
    {
        public History()
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void History_Load(object sender, EventArgs e)
        {
            fillPatient();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            Nurse nr = new Nurse();
            nr.Show();
            this.Hide();
        }

        private void Add_History_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs_History())
            {
                MessageBox.Show("Please check the input filled");
            }
            else
            {
                string query = "insert into HistoryTBL values('" + P_Name.Text + "','" + P_Age.Text + "','" + Chronic_Diseases.Text + "','" + Medications.Text + "','" + Past_Surgries.Text + "','" + Dermatologic_Disease.Text + "','" + Allergy.Text + "')";
                History_cls ad = new History_cls();
                try
                {
                    ad.AddHistory(query);
                    MessageBox.Show("History Added Successfully");

                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private bool ValidateInputs_History()
        {
            if (P_Age.Text == "" || Medication.Text == "" || Allergies.Text == "" || Past_Surgical.Text == "")
                return false;
            if (Dermatologic_Disease.SelectedIndex < 0)
                return false;
            if (P_Name.SelectedIndex < 0)
                return false;
            if (Chronic_Diseases.SelectedIndex < 0)
                return false;
            return true;
        }
    }
}
