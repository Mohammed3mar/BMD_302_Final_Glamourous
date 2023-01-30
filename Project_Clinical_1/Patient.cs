using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_Clinical_1
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Prev_Click(object sender, EventArgs e)
        {
            Receptionist re = new Receptionist();
            re.Show();
            this.Hide();
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void Add_Patient_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs_Patient())
            {
                MessageBox.Show("Please check the input filled");
            }
            else
            {
                string query = "insert into PatientTBL values('" + P_National_ID.Text + "','" + P_Name.Text + "','" + P_Age.Text + "','" + P_Phone_Number.Text + "','" + P_Gender.Text + "','" + P_Photo.Image + "')";
                myPatient MP = new myPatient();
                try
                {
                    MP.AddPatient(query);
                    MessageBox.Show("Patient Successfully Added");

                }


                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }           
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                P_Photo.Image = new Bitmap(openFileDialog.FileName);
            }
        }
        private bool ValidateInputs_Patient()
        {
            if (P_Age.Text == "" || P_Name.Text == "" || P_National_ID.Text == "" || P_Phone_Number.Text == "")
                return false; if (P_Gender.SelectedIndex < 0)
                return false;
            return true;
        }
    }
}
