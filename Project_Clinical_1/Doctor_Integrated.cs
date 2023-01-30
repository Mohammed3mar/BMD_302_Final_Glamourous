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
    public partial class Doctor_Integrated : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\NILE UNIVERSTY\\COURSES\\Fall22\\BMD_302\\Clinical_WorkSpace\\Clinical_Project-main\\Project_Clinical_1\\Clinical_DB.mdf\";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();

        
        //Connection String  
        string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\NILE UNIVERSTY\\COURSES\\Fall22\\BMD_302\\Clinical_WorkSpace\\Clinical_Project-main\\Project_Clinical_1\\Clinical_DB.mdf\";Integrated Security=True;Connect Timeout=30";
        SqlConnection Con;
        SqlDataAdapter adapt;
        DataTable dt;
        

        public Doctor_Integrated()
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


        private void Set_History_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Integrated_Load(object sender, EventArgs e)
        {
            fillPatient();

            
            Con = new SqlConnection(cs);
            Con.Open();
            adapt = new SqlDataAdapter("select * from AppointmentTBL", Con);
            dt = new DataTable();
            adapt.Fill(dt);
            AppointmentDGV.DataSource = dt;
            Con.Close();

            Con = new SqlConnection(cs);
            Con.Open();
            adapt = new SqlDataAdapter("select P_M_R_ID, P_Name, P_Age, P_Gender, Type_of_Session, Prescription, Allergies from Plastic_M_R_TBL", Con);
            dt = new DataTable();
            adapt.Fill(dt);
            M_R_DGV.DataSource = dt;
            Con.Close();

            Con = new SqlConnection(cs);
            Con.Open();
            adapt = new SqlDataAdapter("select * from HistoryTBL", Con);
            dt = new DataTable();
            adapt.Fill(dt);
            History_DGV.DataSource = dt;
            Con.Close();
        }

        private void P_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con = new SqlConnection(cs);
            Con.Open();
            adapt = new SqlDataAdapter("select * from AppointmentTBL where P_Name like '" + P_Name.Text + "%'", Con);
            dt = new DataTable();
            adapt.Fill(dt);
            AppointmentDGV.DataSource = dt;
            Con.Close();

            Con = new SqlConnection(cs);
            Con.Open();
            adapt = new SqlDataAdapter("select P_M_R_ID, P_Name, P_Age, P_Gender, Type_of_Session, Prescription, Allergies from Plastic_M_R_TBL where P_Name like '" + P_Name.Text + "%'", Con);
            dt = new DataTable();
            adapt.Fill(dt);
            M_R_DGV.DataSource = dt;
            Con.Close();

            Con = new SqlConnection(cs);
            Con.Open();
            adapt = new SqlDataAdapter("select * from HistoryTBL where P_Name like '" + P_Name.Text + "%'", Con);
            dt = new DataTable();
            adapt.Fill(dt);
            History_DGV.DataSource = dt;
            Con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
            this.Hide();
        }
    }
}
