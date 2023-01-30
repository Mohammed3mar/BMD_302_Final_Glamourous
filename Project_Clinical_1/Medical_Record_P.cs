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
    public partial class Medical_Record_P : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\NILE UNIVERSTY\\COURSES\\Fall22\\BMD_302\\Clinical_WorkSpace\\Clinical_Project-main\\Project_Clinical_1\\Clinical_DB.mdf\";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();

        public Medical_Record_P()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Medical_Record_P_Load(object sender, EventArgs e)
        {
            fillPatient();
            /*
            fillPatient();
            Plastic_Medical_cls dmr = new Plastic_Medical_cls();
            string query = "select P_M_R_ID, P_Name, P_Age, P_Gender, Type_of_Session, Prescription, Allergies from Plastic_M_R_TBL";
            DataSet ds = dmr.ShowPlastic_M_R(query);
            Plastic_M_R_DGV.DataSource = ds.Tables[0];
            */
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
            this.Hide();
        }

        private void Add_M_R_Click(object sender, EventArgs e)
        {
            if (!ValidateInputsDerma_M_R())
            {
                MessageBox.Show("Please check the input filled");
            }
            else
            {
                string query = "insert into Plastic_M_R_TBL values('" + P_Name.Text + "','" + P_Age.Text + "','" + P_Gender.Text + "','" + P_M_R_Photo.Image + "','" + Type_of_Session.Text + "','" + Prescription.Text + "','" + Allergies.Text + "')";
                Plastic_Medical_cls ad = new Plastic_Medical_cls();
                try
                {
                    ad.AddPlastic_M_R(query);
                    MessageBox.Show("Medical Record Added Successfully");

                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            
        }

        private void Add_Photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                P_M_R_Photo.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void P_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool ValidateInputsDerma_M_R()
        {
            if (P_Age.Text == "" || Prescription.Text == "" || Allergies.Text == "")
                return false;
            if (Type_of_Session.SelectedIndex < 0)
                return false;
            if (P_Name.SelectedIndex < 0)
                return false;
            if (P_Gender.SelectedIndex < 0)
                return false;
            return true;
        }
    }
}
