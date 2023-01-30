using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project_Clinical_1
{
    public partial class Derma_Medical : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\NILE UNIVERSTY\\COURSES\\Fall22\\BMD_302\\Clinical_WorkSpace\\Clinical_Project-main\\Project_Clinical_1\\Clinical_DB.mdf\";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();

        public Derma_Medical()
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

        private void Prev_Click(object sender, EventArgs e)
        {
            Doctor_Derma dr = new Doctor_Derma();
            dr.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Add_Medical_Record_Click(object sender, EventArgs e)
        {
            if (!ValidateInputsDerma_M_R())
            {
                MessageBox.Show("Please check the input filled");
            }
            else
            {
                string query = "insert into Derma_M_R_TBL values('" + P_Name.Text + "','" + P_Age.Text + "','" + P_Gender.Text + "','" + P_M_R_Photo.Image + "','" + Type_of_Session.Text + "','" + Prescription.Text + "','" + Allergies.Text + "')";
                Derma_Medical_cls ad = new Derma_Medical_cls();
                try
                {
                    ad.AddDerma_M_R(query);
                    MessageBox.Show("Medical Record Added Successfully");

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }           
        }

        private void Derma_Medical_Load(object sender, EventArgs e)
        {
            /*
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\NILE UNIVERSTY\\COURSES\\Fall22\\BMD_302\\Clinical_WorkSpace\\Clinical_Project-main\\Project_Clinical_1\\Clinical_DB.mdf\";Integrated Security=True;Connect Timeout=30");
            SqlCommand cm = new SqlCommand("select D_M_R_ID, P_Name, P_Age, P_Gender, P_Photo, Type_of_Session, Prescription, Allergies from Derma_M_R_TBL", con);
            SqlDataAdapter sd = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dt.Columns.Add("PPhoto", Type.GetType("System.Byte[]"));
            foreach (DataRow dr in dt.Rows)
            {
                dr["PPhoto"] = File.ReadAllBytes(dr["P_Photo"].ToString());
            }
            Derma_M_R_DGV.DataSource = dt;
            */
            fillPatient();
            
            /*
            Derma_Medical_cls dmr = new Derma_Medical_cls();
            string query = "select D_M_R_ID, P_Name, P_Age, P_Gender, Type_of_Session, Prescription, Allergies from Derma_M_R_TBL";
            DataSet ds = dmr.ShowDerma_M_R(query);
            Derma_M_R_DGV.DataSource = ds.Tables[0];
            */


            /*
            try
            {
                P_Name.Text = Derma_M_R_DGV.SelectedRows[0].Cells[1].Value.ToString();
                P_Age.Text = Derma_M_R_DGV.SelectedRows[0].Cells[2].Value.ToString();
                P_Gender.Text = Derma_M_R_DGV.SelectedRows[0].Cells[3].Value.ToString();
                byte[] image = Encoding.ASCII.GetBytes(Derma_M_R_DGV.SelectedRows[0].Cells[4].Value.ToString());
                if (image == null)
                    P_M_R_Photo.Image = null;
                else
                {
                    var data = (Byte[])(Derma_M_R_DGV.SelectedRows[0].Cells[5].Value);
                    var stream = new MemoryStream(data);
                    P_M_R_Photo.Image = Image.FromStream(stream);
                }
                Type_of_Session.Text = Derma_M_R_DGV.SelectedRows[0].Cells[5].Value.ToString();
                Prescription.Text = Derma_M_R_DGV.SelectedRows[0].Cells[6].Value.ToString();
                Allergies.Text = Derma_M_R_DGV.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
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

        private void Derma_M_R_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
        }

        private void View_Click(object sender, EventArgs e)
        {
            /*
            Derma_Medical_cls dmr = new Derma_Medical_cls();
            string query = "select D_M_R_ID, P_Name, P_Age, P_Gender, Type_of_Session, Prescription, Allergies from Derma_M_R_TBL";
            DataSet ds = dmr.ShowDerma_M_R(query);
            Derma_M_R_DGV.DataSource = ds.Tables[0];
            */
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
