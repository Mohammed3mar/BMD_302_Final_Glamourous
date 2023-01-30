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
    public partial class Nurse : Form
    {
        public Nurse()
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
        private void fillEquipment()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select E_Name from EquipmentTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("E_Name", typeof(string));
            dt.Load(rdr);
            E_NameCB.ValueMember = "E_Name";
            E_NameCB.DataSource = dt;
            Con.Close();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Show();
            this.Hide();
        }

        private void Set_History_Click(object sender, EventArgs e)
        {
            History hs = new History();
            hs.Show();
            this.Hide();
        }

        private void Add_Equipment_Click(object sender, EventArgs e)
        {
            if (!ValidateInputsNuse_E())
            {
                MessageBox.Show("Please check the input filled");
            }
            else
            {
                ConnectionString MyConnection = new ConnectionString();
                SqlConnection Con = MyConnection.GetCon();

                string query = "insert into EquipmentTBL values('" + E_Name.Text + "','" + E_Speciality.Text + "')";
                Nurse_cls ad = new Nurse_cls();
                try
                {
                    ad.AddEquipment(query);
                    MessageBox.Show("Equipment Added Successfully");

                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

                Admincls dc = new Admincls();
                string querey = "select * from EquipmentTBL";
                DataSet ds = dc.ShowNurse(querey);
                EquipmentDGV.DataSource = ds.Tables[0];

                try
                {
                    Con.Open();
                    DataSet des = new DataSet();
                    string EName = "SELECT E_Name FROM EquipmentTBL";
                    SqlDataAdapter sda = new SqlDataAdapter(EName, Con);
                    sda.Fill(des);
                    E_NameCB.DataSource = des.Tables[0];
                    E_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Loading Nurse Name" + ex);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private void Equipment_Click(object sender, EventArgs e)
        {

        }

        private void Nurse_Load(object sender, EventArgs e)
        {
            fillPatient();
            fillEquipment();

            Nurse_cls ap = new Nurse_cls();
            string qury = "select * from AppointmentTBL";
            DataSet des = ap.ShowAppointment(qury);
            Appointment_DGV.DataSource = des.Tables[0];

            Nurse_cls hs = new Nurse_cls();
            string qery = "select * from HistoryTBL";
            DataSet dse = hs.ShowHistory(qery);
            History_DGV.DataSource = dse.Tables[0];
        }

        private void View_Equipment_Click(object sender, EventArgs e)
        {
            Nurse_cls eq = new Nurse_cls();
            string query = "select * from EquipmentTBL";
            DataSet ds = eq.ShowEquipment(query);
            EquipmentDGV.DataSource = ds.Tables[0];
        }

        private void Delete_Equipment_Click(object sender, EventArgs e)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            try
            {
                Con.Open();
                SqlCommand del = new SqlCommand("DELETE FROM [EquipmentTBL] WHERE E_Name = '" + E_NameCB.Text + "'", Con);
                del.ExecuteNonQuery();
                MessageBox.Show("Equipment Successfully Deleted");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                Con.Close();
            }

            Admincls dc = new Admincls();
            string query = "select * from EquipmentTBL";
            DataSet ds = dc.ShowNurse(query);
            EquipmentDGV.DataSource = ds.Tables[0];

            try
            {
                Con.Open();
                DataSet des = new DataSet();
                string EName = "SELECT E_Name FROM EquipmentTBL";
                SqlDataAdapter sda = new SqlDataAdapter(EName, Con);
                sda.Fill(des);
                E_NameCB.DataSource = des.Tables[0];
                E_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Nurse Name" + ex);
            }
            finally
            {
                Con.Close();
            }
        }

        private void Appointment_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void History_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool ValidateInputsNuse_E()
        {
            if (E_Name.Text == "")
                return false;
            if (E_Speciality.SelectedIndex < 0)
                return false;
            if (E_NameCB.SelectedIndex < 0)
                return false;
            return true;
        }
    }
}
